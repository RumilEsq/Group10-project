<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    ' Required by Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FullNameTextBox = New TextBox()
        EmailTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        ConfirmPasswordTextBox = New TextBox()
        RegisterButton = New Button()
        CancelButton = New Button()
        SuspendLayout()
        ' 
        ' FullNameTextBox
        ' 
        FullNameTextBox.Location = New Point(30, 30)
        FullNameTextBox.Name = "FullNameTextBox"
        FullNameTextBox.PlaceholderText = "Full Name"
        FullNameTextBox.Size = New Size(220, 23)
        FullNameTextBox.TabIndex = 0
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(30, 70)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.PlaceholderText = "Email"
        EmailTextBox.Size = New Size(220, 23)
        EmailTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(30, 110)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.PlaceholderText = "Password"
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 2
        ' 
        ' ConfirmPasswordTextBox
        ' 
        ConfirmPasswordTextBox.Location = New Point(30, 150)
        ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        ConfirmPasswordTextBox.PasswordChar = "*"c
        ConfirmPasswordTextBox.PlaceholderText = "Confirm Password"
        ConfirmPasswordTextBox.Size = New Size(220, 23)
        ConfirmPasswordTextBox.TabIndex = 3
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(30, 190)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(100, 30)
        RegisterButton.TabIndex = 4
        RegisterButton.Text = "Register"
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(150, 190)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(100, 30)
        CancelButton.TabIndex = 5
        CancelButton.Text = "Cancel"
        ' 
        ' RegisterForm
        ' 
        AcceptButton = RegisterButton
        ClientSize = New Size(289, 278)
        Controls.Add(FullNameTextBox)
        Controls.Add(EmailTextBox)
        Controls.Add(PasswordTextBox)
        Controls.Add(ConfirmPasswordTextBox)
        Controls.Add(RegisterButton)
        Controls.Add(CancelButton)
        Name = "RegisterForm"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents RegisterButton As Button
    Friend WithEvents CancelButton As Button
End Class
