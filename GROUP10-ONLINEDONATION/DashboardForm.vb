Imports System.Configuration
Imports System.Data.SqlClient

Public Class DashboardForm
    Public Property LoggedInUserID As Integer

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCampaigns()
        LoadPaymentMethods()
        LoadUserCampaigns()
        LoadCampaignProgress()
    End Sub

    Private Sub LoadCampaigns()
        CampaignComboBox.Items.Clear()
        Dim connStr = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using conn As New SqlConnection(connStr)
            Dim cmd = New SqlCommand("SELECT campaign_id, title FROM campaigns WHERE is_active = 1", conn)
            conn.Open()
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    Dim item As New KeyValuePair(Of Integer, String)(reader("campaign_id"), reader("title").ToString())
                    CampaignComboBox.Items.Add(item)
                End While
            End Using
        End Using
    End Sub

    Private Sub LoadPaymentMethods()
        PaymentMethodComboBox.Items.Clear()
        Dim connStr = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using conn As New SqlConnection(connStr)
            Dim cmd = New SqlCommand("SELECT payment_method_id, method_name FROM payment_methods", conn)
            conn.Open()
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    Dim item As New KeyValuePair(Of Integer, String)(reader("payment_method_id"), reader("method_name").ToString())
                    PaymentMethodComboBox.Items.Add(item)
                End While
            End Using
        End Using
    End Sub

    Private Sub SubmitDonationButton_Click(sender As Object, e As EventArgs) Handles SubmitDonationButton.Click
        If CampaignComboBox.SelectedItem Is Nothing OrElse PaymentMethodComboBox.SelectedItem Is Nothing OrElse AmountTextBox.Text.Trim = "" Then
            MessageBox.Show("Please complete all donation fields.")
            Return
        End If

        Dim campaignId = CType(CampaignComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim paymentMethodId = CType(PaymentMethodComboBox.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim amount As Decimal

        If Not Decimal.TryParse(AmountTextBox.Text.Trim, amount) Then
            MessageBox.Show("Invalid donation amount.")
            Return
        End If

        Dim connStr = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd = New SqlCommand("INSERT INTO donations (user_id, campaign_id, amount, payment_method_id) VALUES (@UserId, @CampaignId, @Amount, @PaymentMethodId); UPDATE campaigns SET current_amount = current_amount + @Amount WHERE campaign_id = @CampaignId", conn)
            cmd.Parameters.AddWithValue("@UserId", LoggedInUserID)
            cmd.Parameters.AddWithValue("@CampaignId", campaignId)
            cmd.Parameters.AddWithValue("@Amount", amount)
            cmd.Parameters.AddWithValue("@PaymentMethodId", paymentMethodId)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Thank you for your donation!")
                AmountTextBox.Clear()
                LoadCampaignProgress()
            Catch ex As Exception
                MessageBox.Show("Error processing donation: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        LoginForm2.Show()
        Me.Close()
    End Sub

    Private Sub SaveCampaignButton_Click(sender As Object, e As EventArgs) Handles SaveCampaignButton.Click
        Dim title = TitleTextBox.Text.Trim()
        Dim description = DescriptionTextBox.Text.Trim()
        Dim goalAmount As Decimal
        Decimal.TryParse(GoalAmountTextBox.Text.Trim(), goalAmount)
        Dim startDate = StartDatePicker.Value
        Dim endDate = EndDatePicker.Value

        If title = "" OrElse goalAmount <= 0 Then
            MessageBox.Show("Please enter a valid title and goal amount.")
            Return
        End If

        Dim connStr = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim insertQuery = "INSERT INTO campaigns (user_id, title, description, goal_amount, start_date, end_date, current_amount, is_active) 
                           VALUES (@UserID, @Title, @Description, @GoalAmount, @StartDate, @EndDate, 0, 1)"
            Using cmd As New SqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)
                cmd.Parameters.AddWithValue("@Title", title)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.Parameters.AddWithValue("@GoalAmount", goalAmount)
                cmd.Parameters.AddWithValue("@StartDate", startDate)
                cmd.Parameters.AddWithValue("@EndDate", endDate)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Campaign created successfully.")
            TitleTextBox.Clear()
            DescriptionTextBox.Clear()
            GoalAmountTextBox.Clear()

            LoadCampaigns()
            LoadCampaignProgress()
        End Using
    End Sub

    Private Sub LoadUserCampaigns()

        Dim connStr = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd = New SqlCommand("SELECT campaign_id, title FROM campaigns WHERE user_id = @UserID", conn)
            cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)

        End Using
    End Sub

    Private Sub LoadCampaignProgress()
        CampaignsFlowPanel.Controls.Clear()

        Dim connStr = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim query = "SELECT campaign_id, title, goal_amount, current_amount, start_date, end_date FROM campaigns WHERE current_amount < goal_amount AND end_date >= GETDATE()"
            Using cmd As New SqlCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim panel As New Panel With {
                            .Width = 400,
                            .Height = 120,
                            .BorderStyle = BorderStyle.FixedSingle,
                            .Padding = New Padding(10),
                            .Margin = New Padding(5)
                        }

                        Dim titleLabel As New Label With {
                            .Text = "Title: " & reader("title").ToString(),
                            .AutoSize = True
                        }
                        Dim goalLabel As New Label With {
                            .Text = "Goal: ₱" & reader("goal_amount").ToString(),
                            .AutoSize = True
                        }
                        Dim amountLabel As New Label With {
                            .Text = "Raised: ₱" & reader("current_amount").ToString(),
                            .AutoSize = True
                        }
                        Dim dateLabel As New Label With {
                            .Text = "Duration: " & Convert.ToDateTime(reader("start_date")).ToShortDateString() & " to " & Convert.ToDateTime(reader("end_date")).ToShortDateString(),
                            .AutoSize = True
                        }

                        Dim progressBar As New ProgressBar With {
                            .Minimum = 0,
                            .Maximum = 100,
                            .Value = Math.Min(100, CInt((Convert.ToDecimal(reader("current_amount")) / Convert.ToDecimal(reader("goal_amount"))) * 100)),
                            .Width = 350,
                            .Height = 20,
                            .ForeColor = Color.Blue
                        }

                        panel.Controls.Add(titleLabel)
                        panel.Controls.Add(goalLabel)
                        panel.Controls.Add(amountLabel)
                        panel.Controls.Add(dateLabel)
                        panel.Controls.Add(progressBar)

                        For Each ctrl As Control In panel.Controls
                            ctrl.Top = panel.Controls.IndexOf(ctrl) * 20
                        Next

                        CampaignsFlowPanel.Controls.Add(panel)
                    End While
                End Using
            End Using
        End Using
    End Sub


End Class
