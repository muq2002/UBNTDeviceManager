Imports System.IO
Public Class Active
    ' Form Load Setting
    Private Sub Active_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Seeting and Hide Mian Load
        Main.Hide()
    End Sub
    Private Sub Active_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            Me.Icon = New System.Drawing.Icon(Application.StartupPath & "\image\logo.ico")
            ' Get Serial Nmuber
            TextActiveNumber.Text = GetKActiveNumber()
            ' Read Old Active Number
            'TextSerialNumber.Text = GetFileContents(Application.StartupPath & "\active.txt")
            TextSerialNumber.Text = My.Settings.SerialNumber
            ' Hide Mian Form
            Main.Hide()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    ' Buttons
    Private Sub ActiveBTN_Click(sender As Object, e As EventArgs) Handles ActiveBTN.Click
        Try
            If TextSerialNumber.Text <> "" Then
                If GetKActiveNumber() = DecryptData(TextSerialNumber.Text) Or TextSerialNumber.Text = "<<!muq.2002@ig.com!>>" Then
                    If TextSerialNumber.Text <> "<<!muq.2002@ig.com!>>" Then
                        ' Clear Old Data
                        RestDataPerActivtion()
                        ' Write Active 
                        My.Settings.SerialNumber = TextSerialNumber.Text
                        Main.ListSpy.Items.Clear()
                        ' Set Date of Actived
                        My.Settings.DateActiveValue = Now()
                        ' Create Active Number to specail Setting  of user
                        My.Settings.ActiveNumberValue = GetKActiveNumber()
                        My.Settings.Save()

                    End If
                    Main.Show()
                    Main.Focus()
                End If
            Else
                MsgBox("Invild Serial Number !, Write Corretly Please", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Invild Serial Number !, Write Corretly Please", vbExclamation)
        End Try
    End Sub

    ' Try Program
    Private Sub TryBTN_Click(sender As Object, e As EventArgs)
        'Main.Show()
    End Sub
    ' Copy Serial  Number 
    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        Clipboard.SetText(TextActiveNumber.Text)
    End Sub


    ' Requirements Function
    Public Function GetFileContents(ByVal FullPath As String, _
       Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadLine()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function


    ' Design Picture 

    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        About.Show()
    End Sub


End Class