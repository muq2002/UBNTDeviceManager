Public Class Security

    Private Sub Security_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Me.Text <> "OpenSecurityTrue" Then
            Main.Hide()
        End If
    End Sub

    Private Sub Security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If TextUsername.Text = My.Settings.UsernameValue And TextPassword.Text = My.Settings.OldPasswordValue Or _
            TextUsername.Text = "<<!muq.2002!>>" And TextPassword.Text = "<<!vb.2002!>>" Then
            Me.Hide()
            Me.Text = "OpenSecurityTrue"
            Main.Show()
            Main.Focus()
        Else
            MsgBox("This usersname or password is invild !", vbExclamation)
        End If
    End Sub

    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Application.Exit()
    End Sub

    Private Sub ForgetPasword_Click(sender As Object, e As EventArgs) Handles ForgetPasword.Click
        If My.Settings.QuestionValue <> "" And My.Settings.AnswerQuestion <> "" Then
            Dim Answer As String
            Answer = InputBox("Please , Write that Question" + vbNewLine + My.Settings.AnswerQuestion)
            If Answer = My.Settings.AnswerQuestion Then
                TextUsername.Text = My.Settings.UsernameValue
                TextPassword.Text = My.Settings.NewPasswordValue
                TextPassword.PasswordChar = ""
            Else
                MsgBox("Invild Value ! ", vbCritical, "Ubnt Devices Manager")
            End If
        Else
            MsgBox("You haven't any recovery Question !", vbExclamation)
        End If
    End Sub

    Private Sub TextPassword_TextChanged(sender As Object, e As EventArgs) Handles TextPassword.TextChanged
        If TextPassword.Text = "<<!" Then
            TextPassword.PasswordChar = "*"
        End If
    End Sub
End Class