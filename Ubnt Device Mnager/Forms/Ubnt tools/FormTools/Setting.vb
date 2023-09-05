Imports System.IO
Public Class Setting

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        CheckPassword.Visible = False
        Me.ShowInTaskbar = False
        TextNameActive.Text = My.User.Name
        TextActiveNumber.Text = GetKActiveNumber()
        TextSerialNumber.Text = GetSerialNumber(TextActiveNumber.Text)

        ' Load Values :Console And Log

        Sound.Text = My.Settings.SoundType
        TextSignal.Text = My.Settings.SignalValue
        TextNoise.Text = My.Settings.NoiseFloorValue
        TextCCQ.Text = My.Settings.TransmitCCQValue
        TextTXrate.Text = My.Settings.TxRxRateValue
        TextRXrate.Text = My.Settings.TxRxRateValue

        'Load Values  : Active Setting and Security 
        TextDateActive.Text = My.Settings.DateActiveValue
        TextUername.Text = My.Settings.UsernameValue
        TextNewPassword.Text = My.Settings.NewPasswordValue
        TextRecovaryQuestion.Text = My.Settings.QuestionValue
        TextAnswer.Text = My.Settings.AnswerQuestion
        ComboCMDColor.Text = My.Settings.ColorCMD
        ' Disable Some Features
        If My.Settings.OldPasswordValue = "" Then
            TextNewPassword.Enabled = True
            TextOldPassword.Enabled = False
        Else
            TextNewPassword.Enabled = False
            TextOldPassword.Enabled = True
        End If
    End Sub

    ' this code make setting form saving data successfully
    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        ' Save Sound And Console Setting
        'Set Values
        My.Settings.SoundType = Sound.Text
        My.Settings.SignalValue = TextSignal.Text
        My.Settings.NoiseFloorValue = TextNoise.Text
        My.Settings.TransmitCCQValue = TextCCQ.Text
        My.Settings.TxRxRateValue = TextRXrate.Text



        ' Save Active And Security Setting
        If My.Settings.ActiveNumberValue <> "" Then
            ' To make user saver to all user that prevent copy data and setting between two users

            My.Settings.ActiveNumberValue = GetKActiveNumber()
            My.Settings.UsernameValue = TextUername.Text
            My.Settings.OldPasswordValue = TextNewPassword.Text
            My.Settings.NewPasswordValue = TextNewPassword.Text
            My.Settings.QuestionValue = TextRecovaryQuestion.Text
            My.Settings.AnswerQuestion = TextAnswer.Text
            My.Settings.ColorCMD = ComboCMDColor.Text
        End If
        ' Save Values
        My.Settings.Save()

        Me.Close()
    End Sub

    ' Design Image and Some texts box 
    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Me.Close()
    End Sub
    Private Sub TextOldPassword_TextChanged(sender As Object, e As EventArgs) Handles TextOldPassword.TextChanged
        If TextOldPassword.Text <> "" Then
            If TextOldPassword.Text = My.Settings.OldPasswordValue Then

                TextNewPassword.Enabled = True
            Else
                TextNewPassword.Enabled = False
            End If
        End If
    End Sub
    Private Sub TextNewPassword_TextChanged(sender As Object, e As EventArgs) Handles TextNewPassword.TextChanged
        If TextOldPassword.Text = "" Then
            TextNewPassword.Text = My.Settings.NewPasswordValue
            TextNewPassword.Enabled = False
        End If
    End Sub

    'Combo Box Design
    Private Sub Sound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sound.SelectedIndexChanged
        Try
            Select Case Sound.Text
                Case "Sound: Beeping Normal"
                    My.Computer.Audio.Play(My.Resources.beeping1, AudioPlayMode.Background)
                Case "Sound: Beeping Middle"
                    My.Computer.Audio.Play(My.Resources.beeping2, AudioPlayMode.Background)
                Case "Sound: Beeping Long"
                    My.Computer.Audio.Play(My.Resources.beeping3, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
            MsgBox("Err Select Sound !", vbExclamation)
        End Try
    End Sub

    Private Sub RestBTN_Click(sender As Object, e As EventArgs) Handles RestBTN.Click
        If MsgBox("Do want clear all Setting and List ?", vbExclamation + vbYesNo) = vbYes Then
            My.Settings.SerialNumber = ""
            RestDataPerActivtion()
            My.Settings.Save()
            Me.Close()
        End If
   
    End Sub




    Private Sub LoadBTN_Click(sender As Object, e As EventArgs) Handles LoadBTN.Click
        TextPath.Text = FilesDialog()
        Dim SerialNumber, IPs, Users, Pass As String
        If MsgBox("Do want Backup all setting that cause remove and claer all current settings ." + vbNewLine, vbInformation + vbYesNo) = vbYes Then
            If Trim(TextPath.Text) <> "" And TextPath.Text.IndexOf(".txt") > -1 Then
                RestoreBackUP()
                ' Fetch Data
                ' I'm Using Serial Number to  check  this backup to current user.
                SerialNumber = textBackUP.Text.Substring(textBackUP.Text.IndexOf("SerialNumber:") + 13, textBackUP.Text.IndexOf("IPsAddress:") - 14)
                If SerialNumber = My.Settings.SerialNumber Then
                    ' Remove Serial Number 
                    textBackUP.Text = textBackUP.Text.Replace("SerialNumber:" & SerialNumber, "")
                    textBackUP.Text = textBackUP.Text.Remove(0, 1)

                    ' Get IPs Address 
                    IPs = textBackUP.Text.Substring(textBackUP.Text.IndexOf("IPsAddress:") + 11, textBackUP.Text.IndexOf("Usernames:") - 11)
                    My.Settings.IPs = IPs
                    ' Remove IPs Address 
                    textBackUP.Text = textBackUP.Text.Replace("IPsAddress:" & IPs, "")

                    ' Get Username 
                    Users = textBackUP.Text.Substring(textBackUP.Text.IndexOf("Usernames:") + 10, textBackUP.Text.IndexOf("Passwords:") - 10)
                    My.Settings.IPs = Users

                    ' Remove Username 
                    textBackUP.Text = textBackUP.Text.Replace("Usernames:" & Users, "")

                    ' Get Password 
                    Pass = textBackUP.Text.Substring(textBackUP.Text.IndexOf("Passwords:") + 10)
                    My.Settings.IPs = Pass

                    ' Remove Passwords 
                    textBackUP.Text = textBackUP.Text.Replace("Passwords:" & Pass, "")

                    Main.ListSpy.Items.Clear()
                    SettingRead()
                Else
                    textBackUP.Text = ""

                End If
            End If
        End If
    End Sub
    Public Function FilesDialog() As String
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = Application.StartupPath
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FilesDialog = fd.FileName
        End If
    End Function
    Public Sub CreateBackUP()
        Dim Cre As New StreamWriter(Application.StartupPath & "\NewBack.txt")

        ' First Line< Serial Number >: 
        Cre.WriteLine("SerialNumber:" & My.Settings.SerialNumber)
        ' Second Line< IPs Address >:
        Cre.WriteLine("IPsAddress:" & My.Settings.IPs)
        ' Third Line<  Username's >: 
        Cre.WriteLine("Usernames:" & My.Settings.User)
        ' Fourth Line< Password's >:
        Cre.WriteLine("Passwords:" & My.Settings.Pass)

        Cre.Close()
    End Sub
    Public Sub RestoreBackUP()
        Dim objReader As StreamReader
        objReader = New System.IO.StreamReader(TextPath.Text)
        textBackUP.Text = DecryptTEXT(objReader.ReadToEnd)
        objReader.Close()
    End Sub
    Private Sub MakeBackUPBTN_Click(sender As Object, e As EventArgs) Handles MakeBackUPBTN.Click
        CreateBackUP()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class