Public Class AddUser
    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' design some requirements : Form
        Me.CenterToParent()
        Me.ShowInTaskbar = False
        'Load Special IPs address uisng select tab to  combobox to  edit or add some users.
        If Main.TabContainer.SelectedTab.Text = "discovery IPs" Then
            For L = 0 To Main.ListIPs.Items.Count - 1
                If Main.ListIPs.Items(L).SubItems(7).Text <> "" And Main.ListIPs.Items(L).SubItems(3).Text <> "AP" Then
                    IPaddress.Items.Add(Main.ListIPs.Items(L).SubItems(7).Text & "," & Main.ListIPs.Items(L).SubItems(2).Text)
                End If
            Next L
        End If
        Try
            If Main.TabContainer.SelectedTab.Text = "Spy Users" Then
                For L = 0 To Main.ListSpy.Items.Count - 1
                    If Main.ListSpy.Items(L).SubItems(1).Text <> "" Then
                        IPaddress.Items.Add(Main.ListSpy.Items(L).SubItems(1).Text)
                    End If
                Next L
            End If
            If Main.ListSpy.Items.Count > 0 Then
                IPaddress.Text = Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems(1).Text
                Username.Text = Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems(12).Text
                Password.Text = Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems(13).Text
            End If
        Catch ex As Exception

        End Try

    End Sub

    '  This add user and heart of this form
    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        If IPaddress.Text <> "" And Username.Text <> "" And Password.Text <> "" Then
            Dim IP As String
            '  Now ,  Applying Edit and remove old data
            If IPaddress.Text <> "" Then
                If IPaddress.Text.IndexOf(",") > -1 Then
                    IPaddress.Text = IPaddress.Text.Substring(0, IPaddress.Text.IndexOf(","))
                    IP = Trim(IPaddress.Text)
                Else
                    IP = Trim(IPaddress.Text)
                End If

            End If
            For L = 0 To Main.ListSpy.Items.Count - 1
                If IPaddress.Text = Main.ListSpy.Items(L).SubItems(1).Text Then
                    Main.ListSpy.Items(L).Remove()
                    Exit For
                End If
            Next L
            ' Set ID
            Main.ListSpy.Items.Add(Main.ListSpy.Items.Count + 1)
            ' Set IP address
            Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add(IP)
            'Jump Users Column
            For L = 1 To 10
                Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add("")
            Next
            Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add(Username.Text)
            Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add(Password.Text)
            Main.ListSpy.Items(Main.ListSpy.Items.Count - 1).SubItems.Add("Start")
            IPaddress.Text =
            SettingWrite()
            Me.Close()
        Else
            MsgBox("There are empty fields !", vbExclamation)
        End If
    End Sub


    'design Code and get username and password in spylist using ip address .
    Private Sub IPaddress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IPaddress.SelectedIndexChanged
        If Main.TabContainer.SelectedTab.Text = "Spy Users" Then
            For L = 0 To Main.ListSpy.Items.Count - 1
                If IPaddress.Text = Main.ListSpy.Items(L).SubItems(1).Text Then
                    Username.Text = Main.ListSpy.Items(L).SubItems(12).Text
                    Password.Text = Main.ListSpy.Items(L).SubItems(13).Text
                End If
            Next L
        End If

    End Sub
    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Me.Close()
    End Sub

End Class