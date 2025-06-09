Imports System.Configuration
Imports System.Data.SqlClient

Public Class LoginForm2

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim email As String = UsernameTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text.Trim()

        If email = "" OrElse password = "" Then
            MessageBox.Show("Please enter both email and password.")
            Return
        End If

        Try
            Dim connStr As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

            Using conn As New SqlConnection(connStr)
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then

                        Dim dashboard As New DashboardForm()
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid email or password. Please try again.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Select()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim regForm As New RegisterForm()
        regForm.ShowDialog()
    End Sub
End Class
