<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm2
    Inherits System.Windows.Forms.Form

    ' Dispose method
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Declare controls
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents LoginText As System.Windows.Forms.Label


    ' Initialize form and controls
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        LoginText = New Label()
        RegisterButton = New Button()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(217, 24)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&Email"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(217, 81)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(217, 50)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(217, 107)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(217, 161)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 4
        OK.Text = "Login"
        OK.UseVisualStyleBackColor = True
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(343, 161)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 5
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' LoginText
        ' 
        LoginText.Font = New Font("Sitka Small", 27.75F, FontStyle.Bold)
        LoginText.Location = New Point(27, 52)
        LoginText.Name = "LoginText"
        LoginText.Size = New Size(139, 78)
        LoginText.TabIndex = 6
        LoginText.Text = "Login"
        LoginText.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(217, 213)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(220, 23)
        RegisterButton.TabIndex = 6
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' LoginForm2
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(640, 338)
        Controls.Add(RegisterButton)
        Controls.Add(LoginText)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm2"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()




    End Sub

    Friend WithEvents RegisterButton As Button

End Class
