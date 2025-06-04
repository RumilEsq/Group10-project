Imports System.Data.SqlClient
Imports System.Configuration

Public Class LoginForm2

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim email As String = UsernameTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text.Trim()

        If email = "" OrElse password = "" Then
            MessageBox.Show("Please enter both email and password.")
            Return
        End If

        Dim connStr As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

        Using conn As New SqlConnection(connStr)
            Try
                conn.Open()

                Dim query As String = "SELECT full_name FROM users WHERE email = @Email AND password_hash = @Password"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password) ' Replace with hashed if needed

                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        MessageBox.Show("Welcome, " & reader("full_name").ToString() & "!", "Success")
                        ' Me.Hide()
                        ' New MainForm().Show()
                    Else
                        MessageBox.Show("Invalid email or password.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim regForm As New RegisterForm()
        regForm.ShowDialog()

    End Sub
End Class
