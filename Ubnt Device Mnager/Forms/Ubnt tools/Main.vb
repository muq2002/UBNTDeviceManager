Imports System.IO
Public Class Main

    ' This code blow ,  Make some setting to  main form such as :  Checking Active and Security Login
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Check  Active Program
        Active.TextSerialNumber.Text = My.Settings.SerialNumber ' Load Key Active
        If Active.TextSerialNumber.Text <> "" Then
            If GetKActiveNumber() = DecryptData(Active.TextSerialNumber.Text) Then
                Active.Close()
                If Security.Text <> "OpenSecurityTrue" Then
                    If My.Settings.UsernameValue <> "" And My.Settings.NewPasswordValue <> "" Then
                        Security.Show()
                        Security.Focus()
                    End If
                End If
            Else
                Active.Show()
                Active.Focus()
            End If
        Else
            Active.Show()
            Active.Focus()
        End If
    End Sub
    ' Load main form and set some images are  okay.  read all old data
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        'Desgin Tree View
        TreeNavbar.HideSelection = False
        SelectNode(TreeNavbar.Nodes)
        'Design Image
        PictureRemove.Visible = False
        Selector.Visible = False
        PictureCreate.Location = New Point(1239, 27)
        Selector.Text = "TOTAL: " & ListSpy.Items.Count
        PictureStart.Visible = False
        PictureStop.Visible = False

        PictureCreate.Location = New Point(1216, 27)
        PictureRemove.Visible = True
        PictureRemove.Location = New Point(1239, 27)

        ' Design of Info  Tab charts 

        ChartCPU.Visible = False
        LabelCPU.Visible = False
        ChartMemory.Visible = False
        LabelMemory.Visible = False
        ' Read Old Data
        ListSpy.Focus()
        If My.Settings.SerialNumber <> "" Then
            SettingRead()
        End If

    End Sub

    'design : Picture 
    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Dim Procedure As String = MsgBox("Are You Want Save New Changes ?", MsgBoxStyle.Information + vbYesNoCancel)

        If Procedure = "6" Then ' Yes
            SettingWrite()
            Application.Exit()
        ElseIf Procedure = "7" Then ' No
            Application.Exit()
        End If

    End Sub
    Private Sub PictureMinimize_Click(sender As Object, e As EventArgs) Handles PictureMinimize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    ' Open Add users Form
    Private Sub PictureAdd_Click(sender As Object, e As EventArgs) Handles PictureAdd.Click
        AddUser.Show()
        AddUser.Focus()
    End Sub
    ' Open Setting Form
    Private Sub PictureSeetingConsole_Click(sender As Object, e As EventArgs) Handles PictureSeetingConsole.Click
        Setting.Show()
        Setting.Focus()
    End Sub
    Private Sub PictureRemove_Click(sender As Object, e As EventArgs) Handles PictureRemove.Click
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                If MsgBox("Are you sure remove this item ??", vbCritical + vbYesNo) = vbYes Then
                    ListSpy.SelectedItems(0).Remove()
                    ' Save Data in Hard Desk
                    SettingWrite()
                End If
                ' Set Id NUMBER 
                For L = 0 To ListSpy.Items.Count - 1
                    ListSpy.Items(L).SubItems(0).Text = L + 1
                Next
                Selector.Text = "TOTAL: " & ListSpy.Items.Count
            End If
        Catch ex As Exception

        End Try

    End Sub

    '  This Code to  Create Webbrowser
    Public CreateWebBrowser As Boolean = False
    Private Sub PictureCreate_Click(sender As Object, e As EventArgs) Handles PictureCreate.Click

        Dim IP, User, Pass, State As String
        ListSpy.Focus()
        If ListSpy.Items.Count > 0 Then
            For L = 0 To ListSpy.Items.Count - 1
                If ListSpy.Items(L).SubItems(1).Text <> "" And ListSpy.Items(L).SubItems(12).Text <> "" And ListSpy.Items(L).SubItems(13).Text <> "" Then
                    'Create Browser for all users
                    OpenBrowserPerUser()
                    ' Set Values
                    IP = ListSpy.Items(L).SubItems(1).Text
                    User = ListSpy.Items(L).SubItems(12).Text
                    Pass = ListSpy.Items(L).SubItems(13).Text
                    ' Set State
                    ListSpy.Items(L).SubItems(14).Text = "Start"
                    'Goto Login
                    State = UbntLogin(L, IP, User, Pass)
                    If State <> "" Then
                        MsgBox("On " & IP & vbNewLine & State, vbExclamation)
                    End If
                End If
            Next L
            CreateWebBrowser = True
            PictureCreate.Visible = False
            PictureStart.Visible = True
            PictureStart.Location = New Point(1216, 27)
        End If
    End Sub

    ' This code to  make setting sound okay
    Public SoundSatus As Boolean = True
    Private Sub PictureSound_Click(sender As Object, e As EventArgs) Handles PictureSound.Click
        If SoundSatus = False Then
            PictureSound.Image = My.Resources.Sound
            Select Case Setting.Sound.Text
                Case "Sound: Beeping Normal"
                    My.Computer.Audio.Play(My.Resources.beeping1, AudioPlayMode.Background)
                Case "Sound: Beeping Middle"
                    My.Computer.Audio.Play(My.Resources.beeping2, AudioPlayMode.Background)
                Case "Sound: Beeping Long"
                    My.Computer.Audio.Play(My.Resources.beeping3, AudioPlayMode.Background)
            End Select
            SoundSatus = True

        Else
            PictureSound.Image = My.Resources.muteSound
            SoundSatus = False
        End If
    End Sub
    'refresh Node Trees
    Private Sub PictureRefresh_Click(sender As Object, e As EventArgs) Handles PictureRefresh.Click

        TreeSurvey.Nodes(0).Nodes.Clear()
        If ListSpy.Items.Count > 0 Then
            If ComboTreeSurvey.Text = "From Spy Users" Then
                RefreshDomeTreeSurveyFromSpyUser()
            Else
                If ListIPs.Items.Count > 0 Then
                    RefreshDomeTreeSurveyFromIPdiscovery()
                Else
                    MsgBox("No IPs address You Should make Scan and try again", vbInformation)
                End If
            End If
        Else
            MsgBox("Please, Add one or more IP address to scan survey !", vbInformation)
        End If

    End Sub
    ' Open About From
    Private Sub PictureAbout_Click(sender As Object, e As EventArgs) Handles PictureAbout.Click
        About.Show()
    End Sub


    'desgin : Container 
    Private Sub TreeNavbar_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeNavbar.AfterSelect
        Dim SelectNode As String = TreeNavbar.SelectedNode.Text
        Select Case SelectNode
            Case "Spy Users"
                Me.TabContainer.SelectedTab = Me.SpyPage
            Case "discovery IPs"
                Me.TabContainer.SelectedTab = Me.discoveryIPs
            Case "discovery Survey"
                Me.TabContainer.SelectedTab = Me.discoverySurvey
            Case "IPs Changer"
                Me.TabContainer.SelectedTab = Me.IPsChanger
            Case "Ping Test"
                Me.TabContainer.SelectedTab = Me.PingTest
            Case "Info UBNT"
                Me.TabContainer.SelectedTab = Me.InfoUBTN
            Case "User Info"
                Me.TabContainer.SelectedTab = Me.InfoUBTN
                Me.TabInfo.SelectedTab = Me.InfoUser
            Case "Speed Test"
                Me.TabContainer.SelectedTab = Me.InfoUBTN
                Me.TabInfo.SelectedTab = Me.SpeedNet
            Case "Traceroute"
                Me.TabContainer.SelectedTab = Me.InfoUBTN
                Me.TabInfo.SelectedTab = Me.Treceroute
        End Select

    End Sub
    ' here Rest some special code to design tab contianer
    Private Sub TabContainer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabContainer.SelectedIndexChanged
        Dim SelectTab As String = Me.TabContainer.SelectedTab.Text
        Select Case SelectTab
            Case "Spy Users"
                TabChart.Show()
                'Design Picture
                PanelContainer.Height = 192
                PictureCreate.Visible = True
                PictureRemove.Visible = True
                If ListSpy.Items.Count = 0 Then
                    PictureRemove.Visible = False
                    PictureCreate.Location = New Point(1239, 27)
                Else
                    PictureRemove.Visible = True
                    PictureCreate.Location = New Point(1216, 27)
                End If
                If CreateWebBrowser = True Then
                    PictureStart.Visible = True
                    PictureStart.Location = New Point(1216, 27)
                    PictureCreate.Visible = False
                End If
                If StartBringData = True Then
                    PictureStart.Visible = False
                    PictureStop.Visible = True
                    PictureStop.Location = New Point(1216, 27)
                End If
            Case "discovery IPs"
                TabChart.Hide()
                PanelContainer.Height = 19
                TabContainer.Height = 631
                PictureCreate.Visible = False
                PictureRemove.Visible = False
                PictureStart.Visible = False
                PictureStop.Visible = False
                ' Fetch Ips
                ComboIPs.Items.Clear()
                If ListSpy.Items.Count > 0 Then
                    ComboIPs.Text = ListSpy.Items(0).SubItems(1).Text
                    For L = 0 To ListSpy.Items.Count - 1
                        Dim IPtext As String
                        IPtext = ListSpy.Items(L).SubItems(1).Text
                        ComboIPs.Items.Add(IPtext)
                    Next L
                End If
            Case "discovery Survey"
                ComboIPSurvey.Items.Clear()
                TabChart.Hide()
                PanelContainer.Height = 19
                TabContainer.Height = 631
                PictureCreate.Visible = False
                PictureRemove.Visible = False
                PictureStart.Visible = False
                PictureStop.Visible = False
                ' Fetch Ips
                Dim IPtext As String
                If ListSpy.Items.Count > 0 Then
                    ComboIPSurvey.Text = ListSpy.Items(0).SubItems(1).Text
                    For L = 0 To ListSpy.Items.Count - 1
                        IPtext = ListSpy.Items(L).SubItems(1).Text
                        ComboIPSurvey.Items.Add(IPtext)
                    Next L
                End If
            Case "IPs Changer"
                TabChart.Hide()
                TabContainer.Height = 631
                PanelContainer.Height = 19
                PictureCreate.Visible = False
                PictureRemove.Visible = False
                PictureStart.Visible = False
                PictureStop.Visible = False
                ' Set Up List View
                ListChangeIPs.Items.Clear()
                If ListSpy.Items.Count > 0 Then
                    For L = 0 To ListSpy.Items.Count - 1
                        ' Set Number
                        ListChangeIPs.Items.Add(ListChangeIPs.Items.Count + 1)
                        ' Set Current IP
                        ListChangeIPs.Items(L).SubItems.Add(ListSpy.Items(L).SubItems(1).Text)
                        ' Set Device name
                        ListChangeIPs.Items(L).SubItems.Add(ListSpy.Items(L).SubItems(2).Text)
                    Next L
                End If
                TextIpGetway.Enabled = False
                TextNewIP.Enabled = False
            Case "Ping Test"

                TabChart.Hide()
                TabContainer.Height = 631
                ListPing.Height = 602
                ListPing.Width = 705
                PanelContainer.Height = 19
                PictureCreate.Visible = False
                PictureRemove.Visible = False
                PictureStart.Visible = False
                PictureStop.Visible = False
                'Fetch Ip
                ' Fetch Ips
                If ListSpy.Items.Count > 0 Then
                    ComboIPPing.Text = ListSpy.Items(0).SubItems(1).Text
                    For L = 0 To ListSpy.Items.Count - 1
                        Dim IPtext As String
                        IPtext = ListSpy.Items(L).SubItems(1).Text
                        ComboIPPing.Items.Clear()
                        ComboIPPing.Items.Add(IPtext)
                    Next L
                End If
            Case "Info UBNT"

                TabChart.Show()
                PictureCreate.Visible = False
                PictureRemove.Visible = False
                PictureStart.Visible = False
                PictureStop.Visible = False
                ComboIPsInfo.Items.Clear()
                For L = 0 To ListSpy.Items.Count - 1
                    ComboIPsInfo.Items.Add(ListSpy.Items(L).SubItems(1).Text)
                Next
                If ListSpy.Items.Count > 0 Then
                    ComboIPsInfo.Text = ListSpy.Items(0).SubItems(1).Text
                End If
                Selector.BringToFront()
        End Select
    End Sub

    'desgin : Meun 
    Private Sub OpenIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenIPToolStripMenuItem.Click
        Try
            Dim Err As String
            If ListSpy.SelectedIndices(0) > -1 Then
                Err = OpenWebBrowserIP(ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text, ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(12).Text, ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(13).Text)
                If Err <> "" Then
                    MsgBox("On " & ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text & vbNewLine & Err, vbExclamation)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    ' Copy Meun, Design 
    Private Sub IPAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IPAddressToolStripMenuItem.Click
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                Dim IPaddress As String
                IPaddress = ListSpy.SelectedItems(0).SubItems(1).Text
                If IPaddress <> "" Then
                    Clipboard.SetText(IPaddress)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DeviceNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceNameToolStripMenuItem.Click
        Try

            If ListSpy.SelectedIndices(0) > -1 Then
                Dim DeviceName As String
                DeviceName = ListSpy.SelectedItems(0).SubItems(2).Text
                If DeviceName <> "" Then
                    Clipboard.SetText(DeviceName)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        Try

            If ListSpy.SelectedIndices(0) > -1 Then
                Dim Version As String
                Version = ListSpy.SelectedItems(0).SubItems(4).Text
                If Version <> "" Then
                    Clipboard.SetText(Version)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Tools Meun, Design
    Private Sub DiscoveryIPsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoveryIPsToolStripMenuItem.Click
        Try

            If ListSpy.SelectedIndices(0) > -1 Then
                Me.TabContainer.SelectedTab = Me.discoveryIPs
                ComboIPs.Text = ListSpy.SelectedItems(0).SubItems(1).Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DiscoverySurveyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoverySurveyToolStripMenuItem.Click
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                Me.TabContainer.SelectedTab = Me.discoverySurvey
                ComboIPSurvey.Text = ListSpy.SelectedItems(0).SubItems(1).Text
            End If
        Catch ex As Exception

        End Try
    End Sub


    ' Console Meun Desgin

    Private Sub OpenIPAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenIPAddressToolStripMenuItem.Click
        Try
            Dim Err As String
            Dim IP, User, Password As String
            If ListConsole.SelectedIndices(0) > -1 Then
                IP = ListConsole.Items(ListConsole.SelectedIndices(0)).SubItems(1).Text
                For L = 0 To ListSpy.Items.Count - 1
                    If IP = ListSpy.Items(L).SubItems(1).Text Then
                        User = ListSpy.Items(L).SubItems(12).Text
                        Password = ListSpy.Items(L).SubItems(13).Text
                        Exit For
                    End If
                Next L
            End If
            Err = OpenWebBrowserIP(ListConsole.Items(ListConsole.SelectedIndices(0)).SubItems(1).Text, User, Password)
            If Err <> "" Then
                MsgBox("On" & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub RebootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToolStripMenuItem.Click
        Try
            Dim Err As String
            If ListConsole.SelectedIndices(0) > -1 Then
                If MsgBox("On " & ListConsole.FocusedItem.SubItems(1).Text & vbNewLine & "Do you want reboot ?", vbYesNo + MsgBoxStyle.Information) = vbYes Then
                    Dim IP, User, Password As String
                    'fetch password and username 
                    IP = ListConsole.Items(ListConsole.SelectedIndices(0)).SubItems(1).Text
                    For L = 0 To ListSpy.Items.Count - 1
                        If IP = ListSpy.Items(L).SubItems(1).Text Then
                            User = ListSpy.Items(L).SubItems(12).Text
                            Password = ListSpy.Items(L).SubItems(13).Text
                            Exit For
                        End If
                    Next L
                    Err = Reboot(IP, User, Password)
                    If Err <> "" Then
                        MsgBox("On " & IP & vbNewLine & Err, vbExclamation)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Code : Spy List
    Public StartBringData As Boolean = False
    Private Sub PictureStart_Click(sender As Object, e As EventArgs) Handles PictureStart.Click
        If CreateWebBrowser = True Then
            PictureStop.Visible = True
            PictureStart.Visible = False
            If ListSpy.Items.Count > 0 Then
                Try
                    'Get Fixed Data
                    For L = 0 To ListSpy.Items.Count - 1
                        ' Check  If users want run start spy Users
                        If ListSpy.Items(L).SubItems(14).Text = "Start" Then
                            ' Check  Auto  Logout 
                            FixAutoLogoutFromUNBTDevices(L)
                            'Check  Work Current Nano Station And Using LAN
                            'Device Name
                            ListSpy.Items(L).SubItems(2).Text = GetInfo(L, 1)
                            ''Device Model
                            ListSpy.Items(L).SubItems(3).Text = GetInfo(L, 2)
                            'Version
                            ListSpy.Items(L).SubItems(4).Text = GetInfo(L, 3)
                            'Distance
                            ListSpy.Items(L).SubItems(5).Text = GetInfo(L, 4)
                            'MAC
                            ListSpy.Items(L).SubItems(10).Text = GetInfo(L, 9)
                            'SSID
                            ListSpy.Items(L).SubItems(11).Text = GetInfo(L, 10)
                        End If
                        Application.DoEvents()
                    Next L
                    StartBringData = True
                    Do While StartBringData = True
                        'Get Changeable Data
                        For L = 0 To ListSpy.Items.Count - 1
                            If ListSpy.Items(L).SubItems(14).Text = "Start" Then

                                'Signal Strenght
                                ListSpy.Items(L).SubItems(6).Text = GetInfo(L, 5)
                                'Noise Floor
                                ListSpy.Items(L).SubItems(7).Text = GetInfo(L, 6)
                                'CCQ
                                ListSpy.Items(L).SubItems(8).Text = GetInfo(L, 7)
                                'TX-RX
                                ListSpy.Items(L).SubItems(9).Text = GetInfo(L, 8)
                            End If
                            Application.DoEvents()

                        Next L

                        Application.DoEvents()
                        'Refresh Data In Console
                        ListConsole.Items.Clear()
                        For Item As Integer = 0 To ListSpy.Items.Count - 1
                            If ListSpy.Items(Item).SubItems(14).Text = "Start" Then
                                'Singal Strength
                                If Val(Trim(ListSpy.Items(Item).SubItems(6).Text).Replace("dBm", "")) <= Trim(Val(My.Settings.SignalValue)).Replace("dBm", "") Then
                                    ListConsole.Items.Add("Singal Strength")
                                    ListConsole.Items(ListConsole.Items.Count - 1).SubItems.Add(ListSpy.Items(Item).SubItems(1).Text)
                                End If
                                'Noise Floor
                                If Val(Trim(ListSpy.Items(Item).SubItems(7).Text).Replace("dBm", "")) <= Trim(Val(My.Settings.NoiseFloorValue)).Replace("dBm", "") Then
                                    ListConsole.Items.Add("Noise Floor")
                                    ListConsole.Items(ListConsole.Items.Count - 1).SubItems.Add(ListSpy.Items(Item).SubItems(1).Text)
                                End If
                                'Transmit CCQ
                                If Val(Trim(ListSpy.Items(Item).SubItems(8).Text).Replace("%", "")) <= Trim(Val(My.Settings.TransmitCCQValue)).Replace("%", "") Then
                                    ListConsole.Items.Add("Transmit CCQ")
                                    ListConsole.Items(ListConsole.Items.Count - 1).SubItems.Add(ListSpy.Items(Item).SubItems(1).Text)
                                End If
                                'TX/RX Rate
                                If Val(Trim(ListSpy.Items(Item).SubItems(9).Text).Replace("Mbps /", "").Substring(0, 4)) <= Val(My.Settings.TxRxRateValue) Then
                                    ListConsole.Items.Add("TX/RX Rate")
                                    ListConsole.Items(ListConsole.Items.Count - 1).SubItems.Add(ListSpy.Items(Item).SubItems(1).Text)
                                End If
                            End If
                        Next Item
                        ListConsole.Items(0).Selected = True
                        Application.DoEvents()
                    Loop
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
        End If
        PictureStart.Visible = False
        PictureStop.Visible = True
        PictureStop.Location = New Point(1216, 27)
    End Sub
    Private Sub PictureStop_Click(sender As Object, e As EventArgs) Handles PictureStop.Click
        Application.DoEvents()
        PictureStop.Visible = False
        PictureStart.Visible = True
        PictureStart.BringToFront()
        PictureStart.Location = New Point(1216, 27)
        StartBringData = False
    End Sub


    Private Sub ListSpy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSpy.SelectedIndexChanged
        Selector.Visible = True
        Selector.Text = "TOTAL: " & ListSpy.Items.Count
        PictureCreate.Location = New Point(1216, 27)
        PictureRemove.Visible = True
        PictureRemove.Location = New Point(1239, 27)

        Try
            'View Chart and Hidden
            Dim IPWeb As String
            If ListSpy.Items.Count > 0 Then

                'Hidden All Old  (ListSpy.SelectedIndices(0)
                If CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 Then
                    IPWeb = ComboIPs.Text
                    Do While CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).ReadyState <> WebBrowserReadyState.Complete Or CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).IsBusy : Application.DoEvents() : Loop
                    CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).BringToFront()
                    For L = 0 To 2
                        CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).Document.Window.ScrollTo(0, 583)
                    Next L
                    Do While CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).ReadyState <> WebBrowserReadyState.Complete Or CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).IsBusy : Application.DoEvents() : Loop
                    CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).BringToFront()
                    ' Show current WebBrowser and Hide all webbrowser
                    For L = 0 To TabChart.SelectedTab.Controls.Count - 1
                        If L <> ListSpy.SelectedIndices(0) Then
                            CType(TabChart.SelectedTab.Controls.Item(L), WebBrowser).Hide()
                        Else
                            CType(TabChart.SelectedTab.Controls.Item(L), WebBrowser).Show()
                        End If
                    Next
                Else
                    CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).Hide()
                End If
                ' Show tr and rx rate 
                ToolTipAll.SetToolTip(Me.ListSpy, "On " & IPWeb & vbNewLine & CType(TabChart.SelectedTab.Controls.Item(ListSpy.SelectedIndices(0)), WebBrowser).Document.GetElementsByTagName("table")(4).InnerText)
            End If
        Catch ex As Exception

        End Try
        Application.DoEvents()
    End Sub


    ' Code : Console List 
    Private Sub ListConsole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListConsole.SelectedIndexChanged
        If SoundSatus <> False Then
            If ListConsole.Items.Count > 0 Then
                Try
                    Select Case Setting.Sound.Text
                        Case "Sound: Beeping Normal"
                            My.Computer.Audio.Play(My.Resources.beeping1, AudioPlayMode.Background)
                        Case "Sound: Beeping Middle"
                            My.Computer.Audio.Play(My.Resources.beeping2, AudioPlayMode.Background)
                        Case "Sound: Beeping Long"
                            My.Computer.Audio.Play(My.Resources.beeping3, AudioPlayMode.Background)
                    End Select
                Catch ex As Exception
                    MsgBox("Error on Select Sound !", vbExclamation)
                End Try
            End If
        End If
    End Sub




    ' discovery Survey TAB
    '  Login in UBNT Device and go to survey.cgi
    Private Sub SureyScan_Click(sender As Object, e As EventArgs) Handles SureyScan.Click
        SureyScan.Enabled = False
        Dim Username, Password, IPaddress, Err As String
        If ListSpy.Items.Count > 0 Then
            If ComboIPSurvey.Text <> "" Then
                IPaddress = ComboIPSurvey.Text
                For L = 0 To ListSpy.Items.Count - 1
                    If IPaddress = ListSpy.Items(L).SubItems(1).Text Then
                        Username = ListSpy.Items(L).SubItems(12).Text
                        Password = ListSpy.Items(L).SubItems(13).Text
                        Exit For
                    End If
                Next L
                Err = DiscoveySurveyBrowser(IPaddress, Username, Password)
                If Err <> "" Then
                    MsgBox("On " & IPaddress & vbNewLine & Err, vbExclamation)
                End If
            End If
        End If
        SureyScan.Enabled = True
    End Sub
    ' Fetch and refresh data from ubnt ip web server that make me can control on login Progress
    Private Sub SurveyRefresh_Click(sender As Object, e As EventArgs) Handles SurveyRefresh.Click
        Try
            If Serverdiscovery.WebSurvey.Url.AbsoluteUri.ToString.IndexOf("survey.cgi") > -1 Then
                ListSurey.Items.Clear()
                discoverSurveyRefreshData()
            Else
                MsgBox("Please , Wait me to load some data from UBNT Device !", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Please , Sacn and try again !", vbExclamation)
        End Try
    End Sub
    'Filter 
    Private Sub ComboSureyRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSureyRange.SelectedIndexChanged
        On Error Resume Next
        Dim Signal, RngSignal As String
        If Me.TabContainer.SelectedTab.Text = "discovery Survey" Then
            If ListSurey.Items.Count > 0 Then
                ' CLEAR FILTER
                ListSurey.Items.Clear()
                discoverSurveyRefreshData()
                If ComboSureyRange.Text <> "Other" Then
                    For L = 0 To ListSurey.Items.Count - 1
                        If ListSurey.Items(L).SubItems(6).Text <> "" Then
                            Signal = ListSurey.Items(L).SubItems(6).Text.Substring(0, ListSurey.Items(L).SubItems(6).Text.IndexOf(" /"))
                            RngSignal = Val(ComboSureyRange.Text)
                            If Val(Signal) <= Val(RngSignal) Then
                                ListSurey.Items(L).Remove()
                            End If
                        End If
                        Application.DoEvents()
                    Next
                Else
                    ' CLEAR FILTER
                    ListSurey.Items.Clear()
                    discoverSurveyRefreshData()
                End If
            Else
                MsgBox("Please ,  Scan Survey and try again", vbInformation)
            End If
        End If
    End Sub


    ' discovery IP TAB
    '  Login in UBNT Device and go to discovery.cgi
    Private Sub ScanIPs_Click(sender As Object, e As EventArgs) Handles ScanIPs.Click
        Dim Err As String
        ScanIPs.Enabled = False
        If ComboIPs.Text <> "" Then
            For L = 0 To ListSpy.Items.Count - 1
                Try
                    If ComboIPs.Text = ListSpy.Items(L).SubItems(1).Text Then
                        Err = DiscoveyIPsBrowser(ComboIPs.Text, ListSpy.Items(L).SubItems(12).Text, ListSpy.Items(L).SubItems(13).Text)
                        If Err <> "" Then
                            MsgBox("On " & ComboIPs.Text & vbNewLine & Err, vbExclamation)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("There are error in fill user or password, Please Fill correctly .", vbExclamation)
                End Try

            Next L

        Else
            MsgBox("There error in fill user or password, Please Fill correctly and try again", vbExclamation)
        End If
        ScanIPs.Enabled = True

    End Sub
    ' Fetch and refresh data from ubnt ip web server that make me can control on login Progress
    Private Sub IPRefresh_Click(sender As Object, e As EventArgs) Handles IPRefresh.Click
        Try
            If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("discovery.cgi") > -1 Then
                ListIPs.Items.Clear()
                discoveryIPsRefreshData()
            Else
                MsgBox("Please , Wait me to load some data from UBNT Device !", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Please , Sacn and try again !", vbExclamation)
        End Try

    End Sub
    ' Filter applying using remove items
    Private Sub ComboFilterIPs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFilterIPs.SelectedIndexChanged
        If Me.TabContainer.SelectedTab.Text = "discovery IPs" Then
            If ComboFilterIPs.Text = "AP" Or ComboFilterIPs.Text = "STA" Then
                'Set Filter Type
                ListIPs.Items.Clear()
                discoveryIPsRefreshData()
                On Error Resume Next
                Dim Product As String
                Dim Counter As Integer
                ' Loop Remove To Make Sure all done
                For dOOL = 0 To 100
                    Counter = ListIPs.Items.Count - 1
                    For J = 0 To Counter
                        Product = ListIPs.Items(J).SubItems(3).Text
                        If Product <> ComboFilterIPs.Text Then
                            ListIPs.Items.RemoveAt(J)
                            Counter = ListIPs.Items.Count - 1
                        End If
                    Next J
                    Application.DoEvents()
                Next dOOL
                ' Set Id NUMBER 
                For L = 0 To ListIPs.Items.Count - 1
                    ListIPs.Items(L).SubItems(0).Text = L + 1
                Next
            Else
                ListIPs.Items.Clear()
                discoveryIPsRefreshData()
            End If
        End If
    End Sub




    ' IPs changer TAB
    Private Sub ListChangeIPs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListChangeIPs.SelectedIndexChanged
        TextIP.Text = ListChangeIPs.Items(ListChangeIPs.FocusedItem.Index).SubItems(1).Text
        TextIpGetway.Enabled = True
        TextNewIP.Enabled = True
    End Sub
    Private Sub AddNewIP_Click(sender As Object, e As EventArgs) Handles AddNewIP.Click
        If TextNewIP.Text <> "" And TextIpGetway.Text <> "" Then
            For L = 0 To ListChangeIPs.Items.Count - 1
                If TextIP.Text = ListChangeIPs.Items(L).SubItems(1).Text Then
                    If ListChangeIPs.Items(L).SubItems(2).Text = "" Then
                        ListChangeIPs.Items(L).SubItems.Add("")
                    End If
                    ListChangeIPs.Items(L).SubItems.Add(TextNewIP.Text)
                    ListChangeIPs.Items(L).SubItems.Add(TextIpGetway.Text)
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub StartChange_Click(sender As Object, e As EventArgs) Handles StartChange.Click
        ListChangeIPs.Focus()
        Dim Err As String
        Err = ChangerIPsTool()
        If Err <> "" Then
            MsgBox(Err, vbExclamation)
        End If
    End Sub

    ' Ping Test TAB
    Private Sub PingStart_Click(sender As Object, e As EventArgs) Handles PingStart.Click
        Dim Err As String
        If ListSpy.Items.Count > 0 Then
            If TextPing.Text <> "" And ComboIPPing.Text <> "" And TextPacketPing.Text <> "" And TextPacketSizePing.Text <> "" Then
                PingStart.Enabled = False
                TextPing.Enabled = False
                TextPacketPing.Enabled = False
                TextPacketSizePing.Enabled = False
                For L = 0 To ListSpy.Items.Count - 1
                    If ListSpy.Items(L).SubItems(1).Text = ComboIPPing.Text Then
                        Err = PingTestGoto(ComboIPPing.Text, TextPing.Text, ListSpy.Items(L).SubItems(12).Text, ListSpy.Items(L).SubItems(13).Text, TextPacketPing.Text, TextPacketSizePing.Text)
                        If Err <> "" Then
                            MsgBox("On " & ComboIPPing.Text & vbNewLine & Err, vbExclamation)
                        End If
                        Exit For
                    End If
                Next
                PingStart.Enabled = True
                TextPing.Enabled = True
                TextPacketPing.Enabled = True
                TextPacketSizePing.Enabled = True
            Else
                MsgBox("Please ,  Write Correctly !", vbInformation)
            End If
        End If
    End Sub








    ' Function
    'this function make me : Select Spyuser tab on I load my program
    Private Sub SelectNode(ByVal MyNodes As TreeNodeCollection)
        For Each n As TreeNode In MyNodes
            If n.Text.Equals("Spy Users") Then
                TreeNavbar.Focus()
                TreeNavbar.SelectedNode = n
                Return
            End If

            If n.Nodes.Count > 0 Then
                SelectNode(n.Nodes)
            End If
        Next
    End Sub

    Private Sub AddNode(root As TreeNode, newnode As TreeNode)
        Dim curr As TreeNode = Nothing
        Dim prev As TreeNode = root
        Dim i As Integer
        For i = 0 To root.Nodes.Count - 1
            curr = root.Nodes(i)
            If curr.Text > newnode.Text Then Exit For
            prev = curr
        Next
        root.Nodes.Insert(i, newnode)
    End Sub


    ' Text Design
    Private Sub TextNewIP_TextChanged(sender As Object, e As EventArgs) Handles TextNewIP.TextChanged
        TextIpGetway.Text = TextNewIP.Text
    End Sub

    '  Ubnt Info  TAB
    Private Sub GoInfo_Click(sender As Object, e As EventArgs) Handles GoInfo.Click
        GoButtonClick = False
        If ComboIPsInfo.Text <> "" Then
            GoInfo.Enabled = False
            Serverdiscovery.WebAPInfo.Navigate(ComboIPsInfo.Text)
            Do While Serverdiscovery.WebAPInfo.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebAPInfo.IsBusy : Application.DoEvents() : Loop
            Try
                If Serverdiscovery.WebAPInfo.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
                    ' Set Username and Password 
                    Dim User, Pass As String
                    ' Find Username and Password
                    For L = 0 To ListSpy.Items.Count - 1
                        If ComboIPsInfo.Text = ListSpy.Items(L).SubItems(1).Text Then
                            User = ListSpy.Items(L).SubItems(12).Text
                            Pass = ListSpy.Items(L).SubItems(13).Text
                            Exit For
                        End If
                    Next
                    Serverdiscovery.WebAPInfo.Document.GetElementById("username").InnerText = User
                    Serverdiscovery.WebAPInfo.Document.GetElementById("password").InnerText = Pass
                    'Click Login Buttons
                    For Button As Integer = 0 To Serverdiscovery.WebAPInfo.Document.GetElementsByTagName("input").Count - 1
                        Serverdiscovery.WebAPInfo.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                    Next Button
                    Do While Serverdiscovery.WebAPInfo.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebAPInfo.IsBusy : Application.DoEvents() : Loop
                    Do Until Serverdiscovery.WebAPInfo.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
                End If
            Catch ex As Exception
                MsgBox("There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
            GoButtonClick = True
            GoInfo.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckOffline() <> True Then
            If ComboIPPing.Text <> "" Then
                ComboIPPing.Text = ConvertURLToIPaddress(ComboIPPing.Text)
            End If
        Else
            MsgBox("No internet , This feature need to network  available !", vbInformation)
        End If
    End Sub

    Private Sub RefreshBringPing_Click(sender As Object, e As EventArgs) Handles RefreshBringPing.Click
        If ListPing.Items.Count <> TextPacketPing.Text Then
            FetchDataToPing(TextPacketPing.Text)
            PingCounterLab.Text = "Ping: " & ListPing.Items.Count
        End If
    End Sub

    Private Sub ClearPing_Click(sender As Object, e As EventArgs) Handles ClearPing.Click
        ListPing.Items.Clear()
    End Sub
    Public GoButtonClick As Boolean = False
    Private Sub PictureRefreshPing_Click(sender As Object, e As EventArgs) Handles PictureRefreshPing.Click
        On Error Resume Next
        If GoButtonClick Then
            Dim StopF As Boolean = True
            ' New Navigate to  Info AP
            Serverdiscovery.WebAPInfo.Document.GetElementById("a_stainfo").InvokeMember("click")
            Do While Serverdiscovery.WebAPInfo.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebAPInfo.IsBusy : Application.DoEvents() : Loop
            If Serverdiscovery.WebAPInfo.Document.GetElementById("si_name").InnerText <> "" Then
                ListInfo.Items(0).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_name").InnerText)
                ListInfo.Items(1).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_product").InnerText)
                ListInfo.Items(2).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_fwversion").InnerText)
                ListInfo.Items(3).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_uptime").InnerText)
                ListInfo.Items(4).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_signal").InnerText)
                ListInfo.Items(5).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_signal_peer").InnerText)
                ListInfo.Items(6).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_noise").InnerText)
                ListInfo.Items(7).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_ack").InnerText)
                ListInfo.Items(8).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_ccq").InnerText)
                ListInfo.Items(9).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_tx_power").InnerText)
                ListInfo.Items(10).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_lastip").InnerText)
                ListInfo.Items(11).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_rate").InnerText)
                ListInfo.Items(12).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_bps").InnerText)
                ListInfo.Items(13).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_packets").InnerText)
                ListInfo.Items(14).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_packet_rate").InnerText)

                ListInfo.Items(15).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_txbytes").InnerText)
                ListInfo.Items(16).SubItems.Add(Serverdiscovery.WebAPInfo.Document.GetElementById("si_rxbytes").InnerText)
                ' Info Username

                LabDeviceName.Text = "Device Name : " & Serverdiscovery.WebAPInfo.Document.GetElementById("hostname").InnerText
                LabProduct.Text = "Product : " & Serverdiscovery.WebAPInfo.Document.GetElementById("devmodel").InnerText
                LabAP.Text = "MAC AP : " & Serverdiscovery.WebAPInfo.Document.GetElementById("apmac").InnerText
                LabIPaddress.Text = "IP address : " & ComboIPsInfo.Text


            End If
            ' Chart  Set Values : Chart CPU
            Do While StopF = True
                Dim CPU As String
                ChartCPU.Series(0).Points.Clear()
                CPU = Serverdiscovery.WebAPInfo.Document.GetElementById("cpu").InnerText
                If CPU <> "" Then
                    CPU = CPU.Replace(" %", "")
                    ChartCPU.Series(0).Points.AddXY("", (100 - Val(CPU)))
                    ChartCPU.Series(0).Points.AddXY(CPU & " %", Val(CPU))
                    ChartCPU.Visible = True
                    LabelCPU.Visible = True
                End If

                ' Chart  Set Values : Chart Memory
                Dim Memory As String
                ChartMemory.Series(0).Points.Clear()
                Memory = Serverdiscovery.WebAPInfo.Document.GetElementById("memory").InnerText
                If Memory <> "" Then
                    Memory = Memory.Replace(" %", "")

                    ChartMemory.Series(0).Points.AddXY("", (100 - Val(Memory)))
                    ChartMemory.Series(0).Points.AddXY(Memory & " %", Val(Memory))
                    ChartMemory.Visible = True
                    LabelMemory.Visible = True
                End If
                Application.DoEvents()
            Loop
        Else
            MsgBox("Please , Wait Me", vbInformation)
        End If

    End Sub

    Private Sub ComboIPsInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIPsInfo.SelectedIndexChanged
        Try
            'View Chart and Hidden
            If ListSpy.Items.Count > 0 Then
                If CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 Then
                    Dim IPWeb As String
                    IPWeb = ComboIPs.Text
                    Do While CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).ReadyState <> WebBrowserReadyState.Complete Or CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).IsBusy : Application.DoEvents() : Loop
                    CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).BringToFront()

                    For L = 0 To 2
                        CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).Document.Window.ScrollTo(0, 583)
                    Next L
                    Do While CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).ReadyState <> WebBrowserReadyState.Complete Or CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).IsBusy : Application.DoEvents() : Loop
                    CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).BringToFront()
                    ' Show current WebBrowser and Hide all webbrowser
                    For L = 0 To TabChart.SelectedTab.Controls.Count - 1
                        If L <> ComboIPsInfo.SelectedIndex Then
                            CType(TabChart.SelectedTab.Controls.Item(L), WebBrowser).Hide()
                        Else
                            CType(TabChart.SelectedTab.Controls.Item(L), WebBrowser).Show()
                        End If
                    Next
                Else
                    CType(TabChart.SelectedTab.Controls.Item(ComboIPsInfo.SelectedIndex), WebBrowser).Hide()
                End If
            End If
        Catch ex As Exception

        End Try

        LabIPaddress.Text = "IP Address :" & ListSpy.Items(ComboIPsInfo.SelectedIndex).SubItems(1).Text
        LabDeviceName.Text = "Device Name :" & ListSpy.Items(ComboIPsInfo.SelectedIndex).SubItems(2).Text
        LabProduct.Text = "Product :" & ListSpy.Items(ComboIPsInfo.SelectedIndex).SubItems(3).Text
    End Sub

    Private Sub ClsIPChanger_Click(sender As Object, e As EventArgs) Handles ClsIPChanger.Click
        Try
            If ListChangeIPs.SelectedIndices(0) > -1 Then
                ListChangeIPs.Items(ListChangeIPs.SelectedIndices(0)).SubItems(3).Text = ""
                ListChangeIPs.Items(ListChangeIPs.SelectedIndices(0)).SubItems(4).Text = ""

            End If
        Catch ex As Exception
            MsgBox("Please ,  Select IP correctly !", vbInformation)
        End Try

    End Sub

    Private Sub SpeedTestGo_Click(sender As Object, e As EventArgs) Handles SpeedTestGo.Click
        SpeedTestGo.Enabled = False
        SpeedTestConfigration.Show()
        SpeedTestGo.Enabled = True
    End Sub



    Private Sub GoTraceroute_Click(sender As Object, e As EventArgs) Handles GoTraceroute.Click
        GoTraceroute.Enabled = False
        Dim IP, Username, Password, Err As String

        IP = ComboIPsInfo.Text
        For L = 0 To ListSpy.Items.Count - 1
            If IP = ListSpy.Items(L).SubItems(1).Text Then
                Username = ListSpy.Items(L).SubItems(12).Text
                Password = ListSpy.Items(L).SubItems(13).Text
                Exit For
            End If
        Next
        ' Excute Pecedure
        Err = TracerouteMaker(IP, Username, Password, TextHost.Text)
        If Err <> "" Then
            MsgBox("On " & IP & vbNewLine & Err, vbExclamation)
        End If
        GoTraceroute.Enabled = True
    End Sub

    Private Sub PingTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingTestToolStripMenuItem.Click
        Try
            If 1 > -1 Then
                Me.TabContainer.SelectedTab = Me.PingTest
                ComboIPPing.Text = ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IPsChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IPsChangerToolStripMenuItem.Click
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                Me.TabContainer.SelectedTab = Me.IPsChanger
                TextIP.Text = ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RunTESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunTESTToolStripMenuItem.Click
        If ListSpy.Items.Count > 0 Then
            Try
                Dim Color As String = My.Settings.ColorCMD.Substring(0, 1)
                If ListSpy.SelectedIndices(0) > -1 Then
                    RunCMD("color " & Color & " & title=UBNT Device Manager & ping " & ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text & " -t", True)
                End If
            Catch ex As Exception
                Try
                    RunCMD("title=UBNT Device Manager & ping " & ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text & " -t", True)
                Catch ex1 As Exception

                End Try
            End Try
        End If
    End Sub



    Private Sub RebootToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RebootToolStripMenuItem1.Click
        Try
            Dim Err As String
            If ListSpy.SelectedIndices(0) > -1 Then
                If MsgBox("On " & ListSpy.FocusedItem.SubItems(1).Text & vbNewLine & "Do you want reboot ?", vbYesNo + MsgBoxStyle.Information) = vbYes Then
                    Dim IP, User, Password As String
                    'fetch password and username 
                    IP = ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(1).Text
                    For L = 0 To ListSpy.Items.Count - 1
                        If IP = ListSpy.Items(L).SubItems(1).Text Then
                            User = ListSpy.Items(L).SubItems(12).Text
                            Password = ListSpy.Items(L).SubItems(13).Text
                            Exit For
                        End If
                    Next L
                    Err = Reboot(IP, User, Password)
                    If Err <> "" Then
                        MsgBox("On " & IP & vbNewLine & Err, vbExclamation)

                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TreeSurvey_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeSurvey.AfterSelect
        Dim SelectNode As String
        SelectNode = TreeSurvey.SelectedNode.Text
        If ComboTreeSurvey.Text = "From Spy Users" Then
            For L = 0 To ListSpy.Items.Count - 1
                Dim SSID As String
                If SelectNode.Length >= ListSpy.Items(L).SubItems(11).Text.Length Then
                    SSID = (SelectNode.Substring(0, ListSpy.Items(L).SubItems(11).Text.Length))
                End If
                If SelectNode = ListSpy.Items(L).SubItems(1).Text Or SSID = ListSpy.Items(L).SubItems(11).Text Then
                    ListSpy.Items(L).BackColor = Color.BlueViolet
                    ListSpy.Items(L).ForeColor = Color.White
                Else
                    ListSpy.Items(L).BackColor = Color.White
                    ListSpy.Items(L).ForeColor = Color.Black
                End If
            Next
        Else
            For L = 0 To ListIPs.Items.Count - 1
                Dim SSID As String
                If SelectNode.Length >= ListIPs.Items(L).SubItems(4).Text.Length Then
                    SSID = (SelectNode.Substring(0, ListIPs.Items(L).SubItems(4).Text.Length))
                End If
                If SelectNode = ListIPs.Items(L).SubItems(7).Text Or SSID = ListIPs.Items(L).SubItems(4).Text Then
                    If ListIPs.Items(L).SubItems(3).Text = "AP" Then
                        ListIPs.Items(L).BackColor = Color.Red
                    Else
                        ListIPs.Items(L).BackColor = Color.BlueViolet
                    End If

                    ListIPs.Items(L).ForeColor = Color.White
                Else
                    ListIPs.Items(L).BackColor = Color.White
                    ListIPs.Items(L).ForeColor = Color.Black
                End If
            Next
        End If


    End Sub

    Private Sub CopyIPAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyIPAddressToolStripMenuItem.Click
        Try
            If ListConsole.SelectedIndices(0) > -1 Then
                Clipboard.SetText(ListConsole.Items(ListConsole.SelectedIndices(0)).SubItems(1).Text)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub OpenIPAddressToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenIPAddressToolStripMenuItem1.Click
        Dim IP, User, Password, Err As String
        If TreeSurvey.SelectedNode.Text <> "" And TreeSurvey.SelectedNode.Text.IndexOf("(") = -1 Then
            IP = TreeSurvey.SelectedNode.Text
            For L = 0 To ListSpy.Items.Count - 1
                If IP = ListSpy.Items(L).SubItems(1).Text Then
                    User = ListSpy.Items(L).SubItems(12).Text
                    Password = ListSpy.Items(L).SubItems(13).Text
                    Exit For
                End If
            Next L
            Err = OpenWebBrowserIP(IP, User, Password)
            If Err <> "" Then
                MsgBox("On " & IP & vbNewLine & Err, vbExclamation)
            End If
        End If
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        If TreeSurvey.SelectedNode.Text <> "" And TreeSurvey.SelectedNode.Text.IndexOf("(") = -1 Then
            Clipboard.SetText(TreeSurvey.SelectedNode.Text)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If ListIPs.SelectedIndices(0) > -1 Then
                Clipboard.SetText(ListIPs.Items(ListIPs.SelectedIndices(0)).SubItems(7).Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If ListIPs.SelectedIndices(0) > -1 Then
                ServerOpen.Web1.Navigate(ListIPs.Items(ListIPs.SelectedIndices(0)).SubItems(7).Text)
                ServerOpen.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(14).Text = "Start"
            End If
            StartToolStripMenuItem.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(14).Text = "Stop"
            End If
            StopToolStripMenuItem.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuSpyUsers_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuSpyUsers.Opening
        Try
            If ListSpy.SelectedIndices(0) > -1 Then
                If ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(14).Text = "Start" Then
                    StartToolStripMenuItem.Enabled = False
                    StopToolStripMenuItem.Enabled = True
                ElseIf ListSpy.Items(ListSpy.SelectedIndices(0)).SubItems(14).Text = "Stop" Then
                    StartToolStripMenuItem.Enabled = True
                    StopToolStripMenuItem.Enabled = False
                Else
                    StartToolStripMenuItem.Enabled = True
                    StopToolStripMenuItem.Enabled = True
                End If
            End If
        Catch ex As Exception
            ContextMenuSpyUsers.Visible = False
        End Try
    End Sub


End Class
