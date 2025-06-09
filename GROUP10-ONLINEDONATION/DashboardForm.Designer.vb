<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    ' Dispose logic...
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Form controls
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents LogoutButton As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LabelWelcome = New Label()
        LogoutButton = New Button()
        SuspendLayout()
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.AutoSize = True
        LabelWelcome.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LabelWelcome.Location = New Point(113, 34)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(321, 21)
        LabelWelcome.TabIndex = 0
        LabelWelcome.Text = "Welcome to the Online Donation System"
        ' 
        ' LogoutButton
        ' 
        LogoutButton.Location = New Point(444, 65)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(105, 38)
        LogoutButton.TabIndex = 1
        LogoutButton.Text = "Logout"
        LogoutButton.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(561, 315)
        Controls.Add(LabelWelcome)
        Controls.Add(LogoutButton)
        Name = "DashboardForm"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class
