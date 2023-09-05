Public Class About

    ' Make Some setting 
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.ShowInTaskbar = False
    End Sub
    ' Design Close it
    Private Sub About_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub
    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Me.Close()
    End Sub

End Class