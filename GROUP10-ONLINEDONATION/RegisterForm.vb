Imports System.Data.SqlClient

Public Class RegisterForm


    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim fullName = FullNameTextBox.Text.Trim()
        Dim email = EmailTextBox.Text.Trim()
        Dim password = PasswordTextBox.Text
        Dim confirmPassword = ConfirmPasswordTextBox.Text

        If fullName = "" OrElse email = "" OrElse password = "" OrElse confirmPassword = "" Then
            MessageBox.Show("All fields are required.")
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Dim connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\RUMIL\ONEDRIVE\DESKTOP\DATABASE.MDF;Integrated Security=True"
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String = "INSERT INTO users (role_id, full_name, email, password) VALUES (@RoleID, @FullName, @Email, @Password)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RoleID", 1)
                    cmd.Parameters.AddWithValue("@FullName", fullName)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration successful!")
                    Me.Close()
                End Using

            Catch ex As SqlException
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub FullNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FullNameTextBox.TextChanged
    End Sub

End Class
