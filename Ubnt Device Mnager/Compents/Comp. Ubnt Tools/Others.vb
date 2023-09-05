Imports System.IO
Imports System.Net
Imports System.Security.AccessControl

Module Others
    ' Make Dome tree and it bring ips and ssid  from ip spyusesr
    Public Sub RefreshDomeTreeSurveyFromSpyUser()
        For L = 0 To Main.ListSpy.Items.Count - 1
            'SSID
            Dim D As String = Main.ListSpy.Items(L).SubItems(11).Text
            Dim Check As Boolean = True
            ' Skip  Add AP at same nodes
            If D <> "" Then
                For J = 0 To Main.TreeSurvey.Nodes(0).GetNodeCount(False) - 1
                    If Main.TreeSurvey.Nodes(0).GetNodeCount(False) = 0 Then
                        Main.TreeSurvey.Nodes(0).Nodes.Add(D)
                    Else
                        If D = Main.TreeSurvey.Nodes(0).Nodes(J).Text Then
                            Check = False
                            Exit For
                        End If
                    End If
                Next
                If Check Then
                    Main.TreeSurvey.Nodes(0).Nodes.Add(D)
                End If
            End If
        Next


        ' Add Child 
        For K = 0 To Main.TreeSurvey.Nodes(0).GetNodeCount(False) - 1
            For Y = 0 To Main.ListSpy.Items.Count - 1
                If Main.TreeSurvey.Nodes(0).Nodes(K).Text = Main.ListSpy.Items(Y).SubItems(11).Text Then
                    'Set IPs Address
                    Main.TreeSurvey.Nodes(0).Nodes(K).Nodes.Add(Main.ListSpy.Items(Y).SubItems(1).Text)
                End If
            Next Y
        Next
        ' Count Node
        For U = 0 To Main.TreeSurvey.Nodes(0).GetNodeCount(False) - 1
            Main.TreeSurvey.Nodes(0).Nodes(U).Text = Main.TreeSurvey.Nodes(0).Nodes(U).Text & " ( " & Main.TreeSurvey.Nodes(0).Nodes(U).GetNodeCount(False) & " )"
        Next

    End Sub
    ' Make Dome tree and it bring ips and ssid  from ip discovery 
    Public Sub RefreshDomeTreeSurveyFromIPdiscovery()

        For L = 0 To Main.ListIPs.Items.Count - 1
            'SSID
            Dim D As String = Main.ListIPs.Items(L).SubItems(4).Text
            Dim Check As Boolean = True
            ' Skip  Add AP at same nodes
            If D <> "" Then
                For J = 0 To Main.TreeSurvey.Nodes(0).GetNodeCount(False) - 1
                    If Main.TreeSurvey.Nodes(0).GetNodeCount(False) = 0 Then
                        Main.TreeSurvey.Nodes(0).Nodes.Add(D)
                    Else
                        If D = Main.TreeSurvey.Nodes(0).Nodes(J).Text Then
                            Check = False
                            Exit For
                        End If
                    End If
                Next
                If Check Then
                    Main.TreeSurvey.Nodes(0).Nodes.Add(D)
                End If
            End If
        Next

        ' Add Child 
        For K = 0 To Main.TreeSurvey.Nodes(0).GetNodeCount(False) - 1
            For Y = 0 To Main.ListIPs.Items.Count - 1
                If Main.TreeSurvey.Nodes(0).Nodes(K).Text = Main.ListIPs.Items(Y).SubItems(4).Text Then
                    'Set IPs Address
                    If Main.ListIPs.Items(Y).SubItems(3).Text <> "AP" Then
                        Main.TreeSurvey.Nodes(0).Nodes(K).Nodes.Add(Main.ListIPs.Items(Y).SubItems(7).Text)
                    End If
                End If
            Next Y
        Next
        SelectNode(Main.TreeSurvey.Nodes)
        ' Count Node
        For U = 0 To Main.TreeSurvey.Nodes(0).GetNodeCount(False) - 1
            Main.TreeSurvey.Nodes(0).Nodes(U).Text = Main.TreeSurvey.Nodes(0).Nodes(U).Text & " ( " & Main.TreeSurvey.Nodes(0).Nodes(U).GetNodeCount(False) & " )"
        Next

    End Sub

    'this function make me : Select Spyuser tab on I load my program
    Private Sub SelectNode(ByVal MyNodes As TreeNodeCollection)
        For Each n As TreeNode In MyNodes
            If n.Text.Equals(Main.ListIPs.Items(0).SubItems(4).Text) Then
                Main.TreeSurvey.Focus()
                Main.TreeSurvey.SelectedNode = n
                Return
            End If

            If n.Nodes.Count > 0 Then
                SelectNode(n.Nodes)
            End If
        Next
    End Sub
    '  This convert URL to IP address
    Public Function ConvertURLToIPaddress(Url As String)
        Dim Hostname As IPHostEntry = Dns.GetHostByName(Url)
        Dim IPaddress As IPAddress() = Hostname.AddressList
        ConvertURLToIPaddress = IPaddress(0).ToString
    End Function



    ' Brian Of Program Check  File Loading AND not use from users 
    Public Function CheckFilesNotUse() As Boolean
        '  Check  Active Files
        If System.IO.File.Exists(Application.StartupPath & "\active.txt") Then
            CheckFilesNotUse = True
        Else
            CheckFilesNotUse = False
            Exit Function
        End If

        ' Check  List Files
        If System.IO.File.Exists(Application.StartupPath & "\list\ips.txt") _
            And System.IO.File.Exists(Application.StartupPath & "\list\users.txt") _
            And System.IO.File.Exists(Application.StartupPath & "\list\passwords.txt") Then
            CheckFilesNotUse = True
        Else
            CheckFilesNotUse = False
            Exit Function
        End If

        ' Check Image Files
        If System.IO.File.Exists(Application.StartupPath & "\image\logo.ico") _
    And System.IO.File.Exists(Application.StartupPath & "\image\Sound.png") _
    And System.IO.File.Exists(Application.StartupPath & "\image\muteSound.png") Then
            CheckFilesNotUse = True
        Else
            CheckFilesNotUse = False
            Exit Function
        End If

        ' Check  Sounds Files
        If System.IO.File.Exists(Application.StartupPath & "\sound\beeping1.wav") _
    And System.IO.File.Exists(Application.StartupPath & "\sound\beeping2.wav") _
    And System.IO.File.Exists(Application.StartupPath & "\sound\beeping3.wav") Then
            CheckFilesNotUse = True
        Else
            CheckFilesNotUse = False
            Exit Function
        End If
    End Function

    Public Function RestDataPerActivtion()
        '  Clear Setting Data
        My.Settings.DateActiveValue = ""
        My.Settings.UsernameValue = ""
        My.Settings.OldPasswordValue = ""
        My.Settings.NewPasswordValue = ""
        My.Settings.QuestionValue = ""
        My.Settings.AnswerQuestion = ""

        My.Settings.IPs = ""
        My.Settings.Devname = ""
        My.Settings.Product = ""
        My.Settings.SSID = ""
        My.Settings.User = ""
        My.Settings.Pass = ""
        My.Settings.ColorCMD = "7 : White"

    End Function


    Public Function FixAutoLogoutFromUNBTDevices(Web As Integer)
        Dim URL, User, Pass, Result As String
        If CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsolutePath.ToString.IndexOf("login.cgi") > -1 Then
            ' URL as IP address
            URL = Main.ListSpy.Items(Web).SubItems(1).Text
            ' Username here
            User = Main.ListSpy.Items(Web).SubItems(12).Text
            ' Password here
            Pass = Main.ListSpy.Items(Web).SubItems(13).Text
            ' Now Login again
            Result = UbntLogin(Web, URL, User, Pass)
            If Result <> "" Then
                MsgBox("On " & URL & vbNewLine & Result, vbExclamation)
            End If
        End If
    End Function
    '  Set permission
    Public Function SetPermisson(PATH As String)

    End Function

    Public Function RunCMD(commnand As String, Optional ShowWindow As Boolean = False, Optional WaitForProcessComplete As Boolean = False)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo

        pi.Arguments = " " + "/K " + commnand
        pi.FileName = "cmd.exe"


        pi.CreateNoWindow = Not ShowWindow
        If ShowWindow Then
            pi.WindowStyle = ProcessWindowStyle.Normal
        Else
            pi.WindowStyle = ProcessWindowStyle.Hidden
        End If

        p.StartInfo = pi
        p.Start()
        If WaitForProcessComplete Then Do Until p.HasExited : Loop
    End Function
    '  Check  Offline
    Public Function CheckOffline() As Boolean
        On Error GoTo Line1
        My.Computer.Network.Ping("www.google.com")
        CheckOffline = False
        Exit Function
Line1:
        CheckOffline = True
    End Function
End Module
