Public Class ServerOpen

    Private Sub Server_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Web1.ScriptErrorsSuppressed = True
    End Sub

    ' Desgin Title Bar
    Private Sub PictureMinimize_Click(sender As Object, e As EventArgs) Handles PictureMinimize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Me.Close()
    End Sub

    Private Sub Web1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Web1.DocumentCompleted
        Me.Title.Text = "OpenWeb : " & Web1.Url.AbsoluteUri.ToString
    End Sub
End Class