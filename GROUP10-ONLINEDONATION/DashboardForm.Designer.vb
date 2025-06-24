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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        LabelWelcome = New Label()
        LogoutButton = New Button()
        DonateButton = New Button()
        DonatePanel = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        SubmitDonationButton = New Button()
        AmountTextBox = New TextBox()
        PaymentMethodComboBox = New ComboBox()
        CampaignComboBox = New ComboBox()
        CreateCampaignButton = New Button()
        CampaignPanel = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        SaveCampaignButton = New Button()
        CampaignUpdateComboBox = New ComboBox()
        EndDatePicker = New DateTimePicker()
        StartDatePicker = New DateTimePicker()
        GoalAmountTextBox = New TextBox()
        DescriptionTextBox = New TextBox()
        TitleTextBox = New TextBox()
        CampaignsFlowPanel = New FlowLayoutPanel()
        DonatePanel.SuspendLayout()
        CampaignPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.AutoSize = True
        LabelWelcome.BackColor = Color.Transparent
        LabelWelcome.FlatStyle = FlatStyle.Flat
        LabelWelcome.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelWelcome.ImageAlign = ContentAlignment.TopLeft
        LabelWelcome.Location = New Point(12, 12)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(689, 39)
        LabelWelcome.TabIndex = 0
        LabelWelcome.Text = "Welcome to the Online Donation System!"
        ' 
        ' LogoutButton
        ' 
        LogoutButton.Location = New Point(1158, 12)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(105, 38)
        LogoutButton.TabIndex = 1
        LogoutButton.Text = "Logout"
        LogoutButton.UseVisualStyleBackColor = True
        ' 
        ' DonateButton
        ' 
        DonateButton.BackColor = Color.LightYellow
        DonateButton.Location = New Point(124, 101)
        DonateButton.Name = "DonateButton"
        DonateButton.Size = New Size(121, 37)
        DonateButton.TabIndex = 2
        DonateButton.Text = "Donate"
        DonateButton.UseVisualStyleBackColor = False
        ' 
        ' DonatePanel
        ' 
        DonatePanel.BackColor = SystemColors.ActiveCaption
        DonatePanel.BackgroundImage = CType(resources.GetObject("DonatePanel.BackgroundImage"), Image)
        DonatePanel.Controls.Add(Label4)
        DonatePanel.Controls.Add(Label3)
        DonatePanel.Controls.Add(Label2)
        DonatePanel.Controls.Add(SubmitDonationButton)
        DonatePanel.Controls.Add(AmountTextBox)
        DonatePanel.Controls.Add(PaymentMethodComboBox)
        DonatePanel.Controls.Add(CampaignComboBox)
        DonatePanel.Location = New Point(42, 152)
        DonatePanel.Name = "DonatePanel"
        DonatePanel.Size = New Size(286, 331)
        DonatePanel.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(29, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 10
        Label4.Text = "Amount"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(6, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 9
        Label3.Text = "Payment Method"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(29, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 8
        Label2.Text = "Campaign"
        ' 
        ' SubmitDonationButton
        ' 
        SubmitDonationButton.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitDonationButton.Location = New Point(29, 252)
        SubmitDonationButton.Name = "SubmitDonationButton"
        SubmitDonationButton.Size = New Size(230, 40)
        SubmitDonationButton.TabIndex = 7
        SubmitDonationButton.Text = "Submit"
        SubmitDonationButton.UseVisualStyleBackColor = True
        ' 
        ' AmountTextBox
        ' 
        AmountTextBox.Location = New Point(111, 168)
        AmountTextBox.Name = "AmountTextBox"
        AmountTextBox.Size = New Size(150, 23)
        AmountTextBox.TabIndex = 6
        ' 
        ' PaymentMethodComboBox
        ' 
        PaymentMethodComboBox.FormattingEnabled = True
        PaymentMethodComboBox.Location = New Point(111, 105)
        PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        PaymentMethodComboBox.Size = New Size(148, 23)
        PaymentMethodComboBox.TabIndex = 5
        ' 
        ' CampaignComboBox
        ' 
        CampaignComboBox.FormattingEnabled = True
        CampaignComboBox.Location = New Point(113, 50)
        CampaignComboBox.Name = "CampaignComboBox"
        CampaignComboBox.Size = New Size(148, 23)
        CampaignComboBox.TabIndex = 4
        ' 
        ' CreateCampaignButton
        ' 
        CreateCampaignButton.BackColor = Color.LightYellow
        CreateCampaignButton.Location = New Point(478, 101)
        CreateCampaignButton.Name = "CreateCampaignButton"
        CreateCampaignButton.Size = New Size(121, 37)
        CreateCampaignButton.TabIndex = 5
        CreateCampaignButton.Text = "Create A Campaign"
        CreateCampaignButton.UseVisualStyleBackColor = False
        ' 
        ' CampaignPanel
        ' 
        CampaignPanel.BackColor = SystemColors.ActiveCaption
        CampaignPanel.BackgroundImage = CType(resources.GetObject("CampaignPanel.BackgroundImage"), Image)
        CampaignPanel.Controls.Add(Label11)
        CampaignPanel.Controls.Add(Label10)
        CampaignPanel.Controls.Add(Label9)
        CampaignPanel.Controls.Add(Label8)
        CampaignPanel.Controls.Add(Label7)
        CampaignPanel.Controls.Add(Label6)
        CampaignPanel.Controls.Add(Label5)
        CampaignPanel.Controls.Add(SaveCampaignButton)
        CampaignPanel.Controls.Add(CampaignUpdateComboBox)
        CampaignPanel.Controls.Add(EndDatePicker)
        CampaignPanel.Controls.Add(StartDatePicker)
        CampaignPanel.Controls.Add(GoalAmountTextBox)
        CampaignPanel.Controls.Add(DescriptionTextBox)
        CampaignPanel.Controls.Add(TitleTextBox)
        CampaignPanel.Location = New Point(390, 152)
        CampaignPanel.Name = "CampaignPanel"
        CampaignPanel.Size = New Size(286, 329)
        CampaignPanel.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Location = New Point(16, 220)
        Label11.Name = "Label11"
        Label11.Size = New Size(81, 15)
        Label11.TabIndex = 17
        Label11.Text = "(Update Here)"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Location = New Point(6, 203)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 15)
        Label10.TabIndex = 16
        Label10.Text = "Current Campaign"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(195, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(27, 15)
        Label9.TabIndex = 15
        Label9.Text = "End"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Location = New Point(66, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 14
        Label8.Text = "Start"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(30, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 13
        Label7.Text = "Amount"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(30, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 12
        Label6.Text = "Description"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(9, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 11
        Label5.Text = "Title Of Campaign"
        ' 
        ' SaveCampaignButton
        ' 
        SaveCampaignButton.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveCampaignButton.Location = New Point(30, 250)
        SaveCampaignButton.Name = "SaveCampaignButton"
        SaveCampaignButton.Size = New Size(230, 40)
        SaveCampaignButton.TabIndex = 11
        SaveCampaignButton.Text = "Save Campaign"
        SaveCampaignButton.UseVisualStyleBackColor = True
        ' 
        ' CampaignUpdateComboBox
        ' 
        CampaignUpdateComboBox.FormattingEnabled = True
        CampaignUpdateComboBox.Location = New Point(117, 203)
        CampaignUpdateComboBox.Name = "CampaignUpdateComboBox"
        CampaignUpdateComboBox.Size = New Size(148, 23)
        CampaignUpdateComboBox.TabIndex = 11
        ' 
        ' EndDatePicker
        ' 
        EndDatePicker.Location = New Point(166, 158)
        EndDatePicker.Name = "EndDatePicker"
        EndDatePicker.Size = New Size(94, 23)
        EndDatePicker.TabIndex = 11
        ' 
        ' StartDatePicker
        ' 
        StartDatePicker.Location = New Point(30, 158)
        StartDatePicker.Name = "StartDatePicker"
        StartDatePicker.Size = New Size(94, 23)
        StartDatePicker.TabIndex = 10
        ' 
        ' GoalAmountTextBox
        ' 
        GoalAmountTextBox.Location = New Point(119, 103)
        GoalAmountTextBox.Name = "GoalAmountTextBox"
        GoalAmountTextBox.Size = New Size(146, 23)
        GoalAmountTextBox.TabIndex = 9
        ' 
        ' DescriptionTextBox
        ' 
        DescriptionTextBox.Location = New Point(119, 59)
        DescriptionTextBox.Name = "DescriptionTextBox"
        DescriptionTextBox.Size = New Size(146, 23)
        DescriptionTextBox.TabIndex = 8
        ' 
        ' TitleTextBox
        ' 
        TitleTextBox.Location = New Point(119, 13)
        TitleTextBox.Name = "TitleTextBox"
        TitleTextBox.Size = New Size(146, 23)
        TitleTextBox.TabIndex = 7
        ' 
        ' CampaignsFlowPanel
        ' 
        CampaignsFlowPanel.AutoScroll = True
        CampaignsFlowPanel.BackColor = Color.FromArgb(CByte(120), CByte(150), CByte(190))
        CampaignsFlowPanel.Location = New Point(734, 101)
        CampaignsFlowPanel.Name = "CampaignsFlowPanel"
        CampaignsFlowPanel.Size = New Size(529, 419)
        CampaignsFlowPanel.TabIndex = 8
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(120), CByte(140), CByte(186))
        ClientSize = New Size(1275, 532)
        Controls.Add(CampaignsFlowPanel)
        Controls.Add(CampaignPanel)
        Controls.Add(CreateCampaignButton)
        Controls.Add(DonatePanel)
        Controls.Add(DonateButton)
        Controls.Add(LabelWelcome)
        Controls.Add(LogoutButton)
        Name = "DashboardForm"
        Text = "Dashboard"
        DonatePanel.ResumeLayout(False)
        DonatePanel.PerformLayout()
        CampaignPanel.ResumeLayout(False)
        CampaignPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DonateButton As Button
    Friend WithEvents DonatePanel As Panel
    Friend WithEvents PaymentMethodComboBox As ComboBox
    Friend WithEvents CampaignComboBox As ComboBox
    Friend WithEvents SubmitDonationButton As Button
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CreateCampaignButton As Button
    Friend WithEvents CampaignPanel As Panel
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents GoalAmountTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveCampaignButton As Button
    Friend WithEvents CampaignUpdateComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CampaignsFlowPanel As FlowLayoutPanel
End Class
