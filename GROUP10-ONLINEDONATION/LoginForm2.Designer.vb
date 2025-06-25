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
    Friend WithEvents Picturebox1 As System.Windows.Forms.PictureBox

    ' Initialize form and controls
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm2))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        LoginText = New Label()
        RegisterButton = New Button()
        Panel2 = New Panel()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel2.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(106, 233)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Email"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(106, 293)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = SystemColors.Window
        UsernameTextBox.BorderStyle = BorderStyle.FixedSingle
        UsernameTextBox.Location = New Point(106, 259)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.BorderStyle = BorderStyle.FixedSingle
        PasswordTextBox.Location = New Point(106, 319)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.BackColor = Color.Transparent
        OK.Location = New Point(106, 348)
        OK.Name = "OK"
        OK.Size = New Size(94, 36)
        OK.TabIndex = 4
        OK.Text = "Login"
        OK.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(232, 348)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 36)
        Cancel.TabIndex = 5
        Cancel.Text = "Cancel"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' LoginText
        ' 
        LoginText.Font = New Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginText.Location = New Point(113, 140)
        LoginText.Name = "LoginText"
        LoginText.Size = New Size(213, 78)
        LoginText.TabIndex = 6
        LoginText.Text = "LOGIN"
        LoginText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(106, 395)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(220, 39)
        RegisterButton.TabIndex = 6
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(RegisterButton)
        Panel2.Controls.Add(IconPictureBox1)
        Panel2.Controls.Add(Cancel)
        Panel2.Controls.Add(LoginText)
        Panel2.Controls.Add(OK)
        Panel2.Controls.Add(UsernameTextBox)
        Panel2.Controls.Add(PasswordTextBox)
        Panel2.Controls.Add(PasswordLabel)
        Panel2.Controls.Add(UsernameLabel)
        Panel2.Location = New Point(336, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(426, 478)
        Panel2.TabIndex = 8
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.Transparent
        IconPictureBox1.ForeColor = SystemColors.ActiveCaptionText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLarge
        IconPictureBox1.IconColor = SystemColors.ActiveCaptionText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 92
        IconPictureBox1.Location = New Point(178, 34)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(92, 94)
        IconPictureBox1.TabIndex = 10
        IconPictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Location = New Point(296, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(34, 451)
        Panel1.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.Location = New Point(768, 40)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(34, 451)
        Panel3.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.Location = New Point(808, 62)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(34, 400)
        Panel4.TabIndex = 10
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.Location = New Point(256, 62)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(34, 400)
        Panel5.TabIndex = 11
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), Image)
        Panel6.Location = New Point(216, 77)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(34, 371)
        Panel6.TabIndex = 12
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), Image)
        Panel7.Location = New Point(848, 77)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(34, 371)
        Panel7.TabIndex = 13
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.Location = New Point(-3, -3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(15, 551)
        Panel8.TabIndex = 13
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), Image)
        Panel9.Location = New Point(1027, -3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(13, 551)
        Panel9.TabIndex = 14
        ' 
        ' LoginForm2
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(120), CByte(140), CByte(186))
        CancelButton = Cancel
        ClientSize = New Size(1040, 529)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm2"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)




    End Sub

    Friend WithEvents RegisterButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel

End Class
