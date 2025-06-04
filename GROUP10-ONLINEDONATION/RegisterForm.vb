Imports Microsoft.Data.SqlClient
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class RegisterForm

    Private Function SystemSecurityCrypographySHA256HashData(rawData As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

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

        Dim passwordHash = SystemSecurityCrypographySHA256HashData(password)

        Dim connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\RUMIL\ONEDRIVE\DESKTOP\DATABASE.MDF;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)
        conn.Open()
        Dim query = "INSERT INTO users (role_id, full_name, email, password_hash) VALUES (1, @FullName, @Email, @PasswordHash)"
        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FullName", fullName)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration successful!")
                Me.Close()
            Catch ex As SqlException
                MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class
