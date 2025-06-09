Public Class DashboardForm

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelWelcome.Text = "Welcome to the Online Donation and Charity System"
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        ' Show the login form again
        Dim loginForm As New LoginForm2()
        loginForm.Show()
        Me.Close()
    End Sub

End Class