<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.PictureClose = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.TabContainer = New System.Windows.Forms.TabControl()
        Me.ConsoleSetting = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboCMDColor = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextRXrate = New System.Windows.Forms.TextBox()
        Me.TextTXrate = New System.Windows.Forms.TextBox()
        Me.TextCCQ = New System.Windows.Forms.TextBox()
        Me.TextNoise = New System.Windows.Forms.TextBox()
        Me.TextSignal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sound = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActivedSetting = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckPassword = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextAnswer = New System.Windows.Forms.TextBox()
        Me.TextRecovaryQuestion = New System.Windows.Forms.TextBox()
        Me.TextNewPassword = New System.Windows.Forms.TextBox()
        Me.TextOldPassword = New System.Windows.Forms.TextBox()
        Me.TextUername = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextSerialNumber = New System.Windows.Forms.TextBox()
        Me.TextActiveNumber = New System.Windows.Forms.TextBox()
        Me.TextExpireDate = New System.Windows.Forms.TextBox()
        Me.TextDateActive = New System.Windows.Forms.TextBox()
        Me.TextNameActive = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackUPSetting = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MakeBackUPBTN = New System.Windows.Forms.Button()
        Me.LoadBTN = New System.Windows.Forms.Button()
        Me.TextPath = New System.Windows.Forms.TextBox()
        Me.textBackUP = New System.Windows.Forms.RichTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.RestBTN = New System.Windows.Forms.Button()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabContainer.SuspendLayout()
        Me.ConsoleSetting.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ActivedSetting.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.BackUPSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanelTitle.Controls.Add(Me.PictureLogo)
        Me.PanelTitle.Controls.Add(Me.PictureClose)
        Me.PanelTitle.Controls.Add(Me.Label7)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(617, 23)
        Me.PanelTitle.TabIndex = 0
        '
        'PictureLogo
        '
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(0, -1)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(31, 23)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 4
        Me.PictureLogo.TabStop = False
        '
        'PictureClose
        '
        Me.PictureClose.Image = CType(resources.GetObject("PictureClose.Image"), System.Drawing.Image)
        Me.PictureClose.Location = New System.Drawing.Point(592, 0)
        Me.PictureClose.Name = "PictureClose"
        Me.PictureClose.Size = New System.Drawing.Size(23, 23)
        Me.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureClose.TabIndex = 3
        Me.PictureClose.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "SETTING"
        '
        'SaveBTN
        '
        Me.SaveBTN.Location = New System.Drawing.Point(566, 404)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(45, 23)
        Me.SaveBTN.TabIndex = 1
        Me.SaveBTN.Text = "Save"
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'TabContainer
        '
        Me.TabContainer.Controls.Add(Me.ConsoleSetting)
        Me.TabContainer.Controls.Add(Me.ActivedSetting)
        Me.TabContainer.Controls.Add(Me.BackUPSetting)
        Me.TabContainer.Location = New System.Drawing.Point(0, 24)
        Me.TabContainer.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.TabContainer.Name = "TabContainer"
        Me.TabContainer.SelectedIndex = 0
        Me.TabContainer.Size = New System.Drawing.Size(615, 377)
        Me.TabContainer.TabIndex = 2
        '
        'ConsoleSetting
        '
        Me.ConsoleSetting.BackColor = System.Drawing.SystemColors.Control
        Me.ConsoleSetting.Controls.Add(Me.GroupBox2)
        Me.ConsoleSetting.Controls.Add(Me.GroupBox1)
        Me.ConsoleSetting.Location = New System.Drawing.Point(4, 22)
        Me.ConsoleSetting.Name = "ConsoleSetting"
        Me.ConsoleSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.ConsoleSetting.Size = New System.Drawing.Size(607, 351)
        Me.ConsoleSetting.TabIndex = 0
        Me.ConsoleSetting.Text = "Console Setting"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboCMDColor)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TextRXrate)
        Me.GroupBox2.Controls.Add(Me.TextTXrate)
        Me.GroupBox2.Controls.Add(Me.TextCCQ)
        Me.GroupBox2.Controls.Add(Me.TextNoise)
        Me.GroupBox2.Controls.Add(Me.TextSignal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 268)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'ComboCMDColor
        '
        Me.ComboCMDColor.FormattingEnabled = True
        Me.ComboCMDColor.Items.AddRange(New Object() {"0 : Black", "1 : Blue", "2 : Green", "3 : Aqua", "4 : Red", "5 : Purple", "6 : Yellow", "7 : White", "8 : Gray", "9 : Lite Blue", "A : Light Green", "B : Light Aqua", "C : Light Red", "D : Light Purple", "E : Light Yellow", "F : Bright White"})
        Me.ComboCMDColor.Location = New System.Drawing.Point(137, 207)
        Me.ComboCMDColor.Name = "ComboCMDColor"
        Me.ComboCMDColor.Size = New System.Drawing.Size(217, 21)
        Me.ComboCMDColor.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "CMD Color :"
        '
        'TextRXrate
        '
        Me.TextRXrate.Location = New System.Drawing.Point(137, 177)
        Me.TextRXrate.Name = "TextRXrate"
        Me.TextRXrate.Size = New System.Drawing.Size(217, 20)
        Me.TextRXrate.TabIndex = 10
        Me.TextRXrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTXrate
        '
        Me.TextTXrate.Location = New System.Drawing.Point(137, 148)
        Me.TextTXrate.Name = "TextTXrate"
        Me.TextTXrate.Size = New System.Drawing.Size(217, 20)
        Me.TextTXrate.TabIndex = 9
        Me.TextTXrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCCQ
        '
        Me.TextCCQ.Location = New System.Drawing.Point(137, 118)
        Me.TextCCQ.Name = "TextCCQ"
        Me.TextCCQ.Size = New System.Drawing.Size(217, 20)
        Me.TextCCQ.TabIndex = 8
        Me.TextCCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNoise
        '
        Me.TextNoise.Location = New System.Drawing.Point(137, 85)
        Me.TextNoise.Name = "TextNoise"
        Me.TextNoise.Size = New System.Drawing.Size(217, 20)
        Me.TextNoise.TabIndex = 7
        Me.TextNoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextSignal
        '
        Me.TextSignal.Location = New System.Drawing.Point(137, 50)
        Me.TextSignal.Name = "TextSignal"
        Me.TextSignal.Size = New System.Drawing.Size(217, 20)
        Me.TextSignal.TabIndex = 6
        Me.TextSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "RX Rate(Download):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TX Rate(Upload):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Transmit CCQ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Noise Floor :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Signal Strength :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Sound)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sound"
        '
        'Sound
        '
        Me.Sound.FormattingEnabled = True
        Me.Sound.Items.AddRange(New Object() {"Sound: Beeping Normal", "Sound: Beeping Middle", "Sound: Beeping Long"})
        Me.Sound.Location = New System.Drawing.Point(137, 29)
        Me.Sound.Name = "Sound"
        Me.Sound.Size = New System.Drawing.Size(217, 21)
        Me.Sound.TabIndex = 1
        Me.Sound.Text = "Sound: Beeping Normal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Sound :"
        '
        'ActivedSetting
        '
        Me.ActivedSetting.BackColor = System.Drawing.SystemColors.Menu
        Me.ActivedSetting.Controls.Add(Me.GroupBox4)
        Me.ActivedSetting.Controls.Add(Me.GroupBox3)
        Me.ActivedSetting.Location = New System.Drawing.Point(4, 22)
        Me.ActivedSetting.Name = "ActivedSetting"
        Me.ActivedSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.ActivedSetting.Size = New System.Drawing.Size(607, 351)
        Me.ActivedSetting.TabIndex = 2
        Me.ActivedSetting.Text = "Actived Setting And Security"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckPassword)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TextAnswer)
        Me.GroupBox4.Controls.Add(Me.TextRecovaryQuestion)
        Me.GroupBox4.Controls.Add(Me.TextNewPassword)
        Me.GroupBox4.Controls.Add(Me.TextOldPassword)
        Me.GroupBox4.Controls.Add(Me.TextUername)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(595, 185)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Security Setting"
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.Location = New System.Drawing.Point(297, 80)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.Size = New System.Drawing.Size(42, 13)
        Me.CheckPassword.TabIndex = 17
        Me.CheckPassword.Text = "Not OK"
        Me.CheckPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(349, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Answer"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextAnswer
        '
        Me.TextAnswer.Location = New System.Drawing.Point(403, 59)
        Me.TextAnswer.Name = "TextAnswer"
        Me.TextAnswer.Size = New System.Drawing.Size(172, 20)
        Me.TextAnswer.TabIndex = 15
        '
        'TextRecovaryQuestion
        '
        Me.TextRecovaryQuestion.Location = New System.Drawing.Point(403, 33)
        Me.TextRecovaryQuestion.Name = "TextRecovaryQuestion"
        Me.TextRecovaryQuestion.Size = New System.Drawing.Size(172, 20)
        Me.TextRecovaryQuestion.TabIndex = 14
        '
        'TextNewPassword
        '
        Me.TextNewPassword.Location = New System.Drawing.Point(119, 106)
        Me.TextNewPassword.Name = "TextNewPassword"
        Me.TextNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextNewPassword.Size = New System.Drawing.Size(172, 20)
        Me.TextNewPassword.TabIndex = 12
        '
        'TextOldPassword
        '
        Me.TextOldPassword.Location = New System.Drawing.Point(119, 77)
        Me.TextOldPassword.Name = "TextOldPassword"
        Me.TextOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextOldPassword.Size = New System.Drawing.Size(172, 20)
        Me.TextOldPassword.TabIndex = 11
        '
        'TextUername
        '
        Me.TextUername.Location = New System.Drawing.Point(119, 29)
        Me.TextUername.Name = "TextUername"
        Me.TextUername.Size = New System.Drawing.Size(172, 20)
        Me.TextUername.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Old Password :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(308, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Rcovery Question :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "New Password :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Username :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextSerialNumber)
        Me.GroupBox3.Controls.Add(Me.TextActiveNumber)
        Me.GroupBox3.Controls.Add(Me.TextExpireDate)
        Me.GroupBox3.Controls.Add(Me.TextDateActive)
        Me.GroupBox3.Controls.Add(Me.TextNameActive)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(595, 154)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Active Setting"
        '
        'TextSerialNumber
        '
        Me.TextSerialNumber.Enabled = False
        Me.TextSerialNumber.Location = New System.Drawing.Point(377, 67)
        Me.TextSerialNumber.Name = "TextSerialNumber"
        Me.TextSerialNumber.Size = New System.Drawing.Size(172, 20)
        Me.TextSerialNumber.TabIndex = 9
        '
        'TextActiveNumber
        '
        Me.TextActiveNumber.Enabled = False
        Me.TextActiveNumber.Location = New System.Drawing.Point(377, 33)
        Me.TextActiveNumber.Name = "TextActiveNumber"
        Me.TextActiveNumber.Size = New System.Drawing.Size(172, 20)
        Me.TextActiveNumber.TabIndex = 8
        '
        'TextExpireDate
        '
        Me.TextExpireDate.Enabled = False
        Me.TextExpireDate.Location = New System.Drawing.Point(104, 95)
        Me.TextExpireDate.Name = "TextExpireDate"
        Me.TextExpireDate.Size = New System.Drawing.Size(172, 20)
        Me.TextExpireDate.TabIndex = 7
        Me.TextExpireDate.Text = "1/1/2020 00:00:00"
        '
        'TextDateActive
        '
        Me.TextDateActive.Enabled = False
        Me.TextDateActive.Location = New System.Drawing.Point(104, 67)
        Me.TextDateActive.Name = "TextDateActive"
        Me.TextDateActive.Size = New System.Drawing.Size(172, 20)
        Me.TextDateActive.TabIndex = 6
        '
        'TextNameActive
        '
        Me.TextNameActive.Location = New System.Drawing.Point(104, 36)
        Me.TextNameActive.Name = "TextNameActive"
        Me.TextNameActive.Size = New System.Drawing.Size(172, 20)
        Me.TextNameActive.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(282, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Serial Number :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(282, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Actived Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Expire Date :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Date Actived"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Name Actived"
        '
        'BackUPSetting
        '
        Me.BackUPSetting.BackColor = System.Drawing.SystemColors.Menu
        Me.BackUPSetting.Controls.Add(Me.Label20)
        Me.BackUPSetting.Controls.Add(Me.MakeBackUPBTN)
        Me.BackUPSetting.Controls.Add(Me.LoadBTN)
        Me.BackUPSetting.Controls.Add(Me.TextPath)
        Me.BackUPSetting.Controls.Add(Me.textBackUP)
        Me.BackUPSetting.Controls.Add(Me.Label19)
        Me.BackUPSetting.Location = New System.Drawing.Point(4, 22)
        Me.BackUPSetting.Name = "BackUPSetting"
        Me.BackUPSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.BackUPSetting.Size = New System.Drawing.Size(607, 351)
        Me.BackUPSetting.TabIndex = 3
        Me.BackUPSetting.Text = "BackUP Setting"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(349, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Do you want make Backup ?"
        '
        'MakeBackUPBTN
        '
        Me.MakeBackUPBTN.Location = New System.Drawing.Point(517, 10)
        Me.MakeBackUPBTN.Name = "MakeBackUPBTN"
        Me.MakeBackUPBTN.Size = New System.Drawing.Size(84, 23)
        Me.MakeBackUPBTN.TabIndex = 5
        Me.MakeBackUPBTN.Text = "Make Backup"
        Me.MakeBackUPBTN.UseVisualStyleBackColor = True
        '
        'LoadBTN
        '
        Me.LoadBTN.Location = New System.Drawing.Point(556, 37)
        Me.LoadBTN.Name = "LoadBTN"
        Me.LoadBTN.Size = New System.Drawing.Size(45, 23)
        Me.LoadBTN.TabIndex = 4
        Me.LoadBTN.Text = "Load"
        Me.LoadBTN.UseVisualStyleBackColor = True
        '
        'TextPath
        '
        Me.TextPath.Location = New System.Drawing.Point(94, 39)
        Me.TextPath.Name = "TextPath"
        Me.TextPath.Size = New System.Drawing.Size(461, 20)
        Me.TextPath.TabIndex = 2
        '
        'textBackUP
        '
        Me.textBackUP.Location = New System.Drawing.Point(11, 68)
        Me.textBackUP.Name = "textBackUP"
        Me.textBackUP.Size = New System.Drawing.Size(590, 280)
        Me.textBackUP.TabIndex = 1
        Me.textBackUP.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Load Backup : "
        '
        'RestBTN
        '
        Me.RestBTN.Location = New System.Drawing.Point(515, 403)
        Me.RestBTN.Name = "RestBTN"
        Me.RestBTN.Size = New System.Drawing.Size(45, 23)
        Me.RestBTN.TabIndex = 3
        Me.RestBTN.Text = "Rest"
        Me.RestBTN.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 432)
        Me.Controls.Add(Me.RestBTN)
        Me.Controls.Add(Me.TabContainer)
        Me.Controls.Add(Me.SaveBTN)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabContainer.ResumeLayout(False)
        Me.ConsoleSetting.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ActivedSetting.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.BackUPSetting.ResumeLayout(False)
        Me.BackUPSetting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaveBTN As System.Windows.Forms.Button
    Friend WithEvents TabContainer As System.Windows.Forms.TabControl
    Friend WithEvents ConsoleSetting As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextRXrate As System.Windows.Forms.TextBox
    Friend WithEvents TextTXrate As System.Windows.Forms.TextBox
    Friend WithEvents TextCCQ As System.Windows.Forms.TextBox
    Friend WithEvents TextNoise As System.Windows.Forms.TextBox
    Friend WithEvents TextSignal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sound As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ActivedSetting As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextRecovaryQuestion As System.Windows.Forms.TextBox
    Friend WithEvents TextNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextUername As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextActiveNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextExpireDate As System.Windows.Forms.TextBox
    Friend WithEvents TextDateActive As System.Windows.Forms.TextBox
    Friend WithEvents TextNameActive As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextAnswer As System.Windows.Forms.TextBox
    Friend WithEvents CheckPassword As System.Windows.Forms.Label
    Friend WithEvents ComboCMDColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RestBTN As System.Windows.Forms.Button
    Friend WithEvents BackUPSetting As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents textBackUP As System.Windows.Forms.RichTextBox
    Friend WithEvents LoadBTN As System.Windows.Forms.Button
    Friend WithEvents TextPath As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents MakeBackUPBTN As System.Windows.Forms.Button
End Class
