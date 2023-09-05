Public Class SpeedTestConfigration

    Private Sub SpeedTestConfigration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        'load IP Address
        For L = 0 To Main.ListSpy.Items.Count - 1
            ComboIPsInfo.Items.Add(Main.ListSpy.Items(L).SubItems(1).Text)
        Next
    End Sub

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        If ComboIPsInfo.Text <> "" And TextIPAddress.Text <> "" And TextUsername.Text <> "" And TextPassword.Text <> "" Then
            ' Excute Procedure
            SpeedTestUsers(ComboIPsInfo.Text, TextIPAddress.Text, TextUsername.Text, TextPassword.Text)
            Me.Close()
        Else
            MsgBox("Error in Input Values !", vbExclamation)
        End If

    End Sub
End Class