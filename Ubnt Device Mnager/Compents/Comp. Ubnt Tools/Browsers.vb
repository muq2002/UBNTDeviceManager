Module Browsers
    Public InLeft As Integer = 0
    ' Login Requirements
    Public Function OpenBrowserPerUser()
        ' Add Browser Here
        Dim WebBrowser As New WebBrowser
        Main.TabChart.SelectedTab.Controls.Add(WebBrowser)
        ' Setting Controls
        WebBrowser.Hide()
        WebBrowser.WebBrowserShortcutsEnabled = False
        WebBrowser.IsWebBrowserContextMenuEnabled = False
        WebBrowser.ScrollBarsEnabled = False
        WebBrowser.Dock = DockStyle.Fill
    End Function
    Public Function UbntLogin(Web As Integer, Url As String, User As String, Pass As String) As String
        Main.ReadyPro.Text = ""
        ' Goto Navigate: IP Address
        CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Navigate(Url)
        Do While CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).ReadyState <> WebBrowserReadyState.Complete Or CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).IsBusy : Application.DoEvents() : Loop
        If CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("username").InnerText = User
                CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementsByTagName("input").Count - 1
                    CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button

                Do Until CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                    If CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsoluteUri.ToString = "https://" & Url & "/login.cgi" Then
                        ' Fetch  Fetch error
                        If CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                            For Err As Integer = 0 To (CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementsByTagName("div").Count) - 1
                                If CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                    UbntLogin = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementsByTagName("div")(Err).InnerText()
                                    Exit Function
                                End If
                            Next Err
                        End If
                    End If
                    Application.DoEvents()
                Loop

                ' Make Sure Open Ubnt and Load Successfully
                Do Until CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On " & Url & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Main.ReadyPro.Text = "Ready"
    End Function

    ' Get Info Spy User TAB
    Public Function GetInfo(Web As Integer, TypeInfo As Integer) As String
        ' Make Sure Open Webbrowser Successfully
        Do While CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).ReadyState <> WebBrowserReadyState.Complete Or CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).IsBusy : Application.DoEvents() : Loop
        ' Do Until CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
        Try
            'Get Info
            Select Case TypeInfo
                Case 1
                    'Device Name 
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("hostname").InnerText
                Case 2
                    ' Device Model
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("devmodel").InnerText
                Case 3
                    ' Version
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("fwversion").InnerText
                Case 4
                    ' Distance
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("ack").InnerText
                Case 5
                    ' Stranght 
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("signal").InnerText
                Case 6
                    ' Noise floor
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("noisef").InnerText
                Case 7
                    'Transmit CCQ
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("ccq").InnerText
                Case 8
                    ' TX/RX Rate
                    GetInfo = ""
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("txrate").InnerText & " / " & CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("rxrate").InnerText
                Case 9
                    ' AP MAC
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("apmac").InnerText
                Case 10
                    ' SSID
                    GetInfo = CType(Main.TabChart.SelectedTab.Controls.Item(Web), WebBrowser).Document.GetElementById("essid").InnerText
            End Select

        Catch ex As Exception
            MsgBox("There error IP Address is not Found !", vbExclamation)
        End Try
    End Function

    ' discover Survey TAB
    Public Function DiscoveySurveyBrowser(Url As String, User As String, Pass As String)
        'Login In ubnt 
        ' Goto Navigate: IP Address
        Try
            Serverdiscovery.WebSurvey.Navigate(Url)
            Do While Serverdiscovery.WebSurvey.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebSurvey.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On" & Url & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
        End Try
        If Serverdiscovery.WebSurvey.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                Serverdiscovery.WebSurvey.Document.GetElementById("username").InnerText = User
                Serverdiscovery.WebSurvey.Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To Serverdiscovery.WebSurvey.Document.GetElementsByTagName("input").Count - 1
                    Serverdiscovery.WebSurvey.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button

                Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                    If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString = "https://" & Url & "/login.cgi" Then
                        ' Fetch  Error Logim
                        If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                            For Err As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("div").Count - 1
                                If Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                    DiscoveySurveyBrowser = Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                    Exit Function
                                End If
                            Next Err
                        End If
                    End If
                    Application.DoEvents()
                Loop
                ' Make Sure Open Ubnt and Load Successfully
                Do Until Serverdiscovery.WebSurvey.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error in open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Try
            'Goto  Search Surey Site
            Serverdiscovery.WebSurvey.Navigate(Url & "/survey.cgi?iface=ath0")
            Do While Serverdiscovery.WebSurvey.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebSurvey.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On : " + url + vbNewLine + "There are error in excute procedure ! ", vbExclamation)
        End Try
    End Function
    Public Function discoverSurveyRefreshData()
        Try
            Dim Data As String
            For L = 2 To Serverdiscovery.WebSurvey.Document.GetElementsByTagName("td").Count - 1

                For J = 0 To 7
                    Data = Serverdiscovery.WebSurvey.Document.GetElementsByTagName("td")(L).InnerText
                    If Trim(Data) <> "" Then
                        If Data.IndexOf("Selectable SSID's") = -1 Then
                            If J = 0 Then
                                Main.ListSurey.Items.Add(Main.ListSurey.Items.Count + 1)
                            Else
                                Main.ListSurey.Items(Main.ListSurey.Items.Count - 1).SubItems.Add(Serverdiscovery.WebSurvey.Document.GetElementsByTagName("td")(L).InnerText)
                                Data = Serverdiscovery.WebSurvey.Document.GetElementsByTagName("td")(L).InnerText
                                L = L + 1
                            End If
                        End If
                    End If
                Next J
            Next L
        Catch ex As Exception
            MsgBox("There is error fetch Data from UBNT Drive Because " & vbNewLine & " You may be dosen't make scan ." & vbNewLine & "Please, Scan Or wait and try again", vbExclamation)
        End Try
    End Function

    ' discover IPs TAB
    Public Function DiscoveyIPsBrowser(Url As String, User As String, Pass As String)
        'Login In ubnt 
        ' Goto Navigate: IP Address
        Try
            Serverdiscovery.WebIP.Navigate(Url)
            Do While Serverdiscovery.WebIP.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebIP.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On" & Url & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
        End Try
        If Serverdiscovery.WebIP.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                Serverdiscovery.WebIP.Document.GetElementById("username").InnerText = User
                Serverdiscovery.WebIP.Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("input").Count - 1
                    Serverdiscovery.WebIP.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button

                Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                    If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString = "https://" & Url & "/login.cgi" Then
                        ' Fetch  Error Logim
                        If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                            For Err As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("div").Count - 1
                                If Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                    DiscoveyIPsBrowser = Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                    Exit Function
                                End If
                            Next Err
                        End If
                    End If
                    Application.DoEvents()
                Loop

                ' Make Sure Open Ubnt and Load Successfully

                Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On " & Url & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Try
            'Goto  Search Surey Site
            Serverdiscovery.WebIP.Navigate(Url & "/discovery.cgi")
            Do While Serverdiscovery.WebIP.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebIP.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On : " + Url + vbNewLine + "There are error in excute procedure ! ", vbExclamation)
        End Try
    End Function
    Public Function discoveryIPsRefreshData()
        Try
            Dim RangePage As Integer = Val(Serverdiscovery.WebIP.Document.GetElementsByTagName("a").Count) - 24
            For Page = 1 To RangePage
                ' Fetach Data > From MAC address To Product
                Dim Data As String
                For L = 1 To Serverdiscovery.WebIP.Document.GetElementsByTagName("td").Count - 2

                    For J = 0 To 7
                        Data = Serverdiscovery.WebIP.Document.GetElementsByTagName("td")(L).InnerText
                        If Trim(Data) <> "" And Data <> ">" And Data <> "<" And Data <> ">>" And Data <> "<<" Then
                            If J = 0 Then
                                Main.ListIPs.Items.Add(Main.ListIPs.Items.Count + 1)
                            Else
                                Main.ListIPs.Items(Main.ListIPs.Items.Count - 1).SubItems.Add(Serverdiscovery.WebIP.Document.GetElementsByTagName("td")(L).InnerText)
                                Data = Serverdiscovery.WebIP.Document.GetElementsByTagName("td")(L).InnerText
                                L = L + 1
                            End If
                        End If
                    Next J
                    L = L - 1
                Next L
                ' Click New Page
                If Main.ListIPs.Items.Count = 20 Then
                    For FindPage = 19 To Serverdiscovery.WebIP.Document.GetElementsByTagName("a").Count - 1
                        If Serverdiscovery.WebIP.Document.GetElementsByTagName("a")(FindPage).InnerText = ">" Then
                            Serverdiscovery.WebIP.Document.GetElementsByTagName("a")(FindPage).InvokeMember("click")
                            Exit For
                        End If
                    Next FindPage
                End If
            Next Page

            'First Page
            For FindPage = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("a").Count - 1
                If Serverdiscovery.WebIP.Document.GetElementsByTagName("a")(FindPage).InnerText = "1" Then
                    Serverdiscovery.WebIP.Document.GetElementsByTagName("a")(FindPage).InvokeMember("click")
                End If
            Next FindPage
        Catch ex As Exception
            MsgBox("There is error fetch Data from UBNT Drive Because" & vbNewLine & "You may be dosen't make scan ." & vbNewLine & "Please, Scan or wait and  try again", vbExclamation)
        End Try
    End Function

    ' Open Web Browser Tool
    Public Function OpenWebBrowserIP(IP As String, User As String, Pass As String)
        Try

            ServerOpen.Web1.Navigate(IP)
            ' Login In Web Browser 
            Do While ServerOpen.Web1.ReadyState <> WebBrowserReadyState.Complete Or ServerOpen.Web1.IsBusy : Application.DoEvents() : Loop
            If ServerOpen.Web1.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
                Try
                    ' Set Username and Password 
                    ServerOpen.Web1.Document.GetElementById("username").InnerText = User
                    ServerOpen.Web1.Document.GetElementById("password").InnerText = Pass
                    'Click Login Buttons
                    For Button As Integer = 0 To ServerOpen.Web1.Document.GetElementsByTagName("input").Count - 1
                        ServerOpen.Web1.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                    Next Button
                    Try
                        Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                            If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString = "https://" & IP & "/login.cgi" Then
                                ' Fetch  Error Logim
                                If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                                    For Err As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("div").Count - 1
                                        If Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                            OpenWebBrowserIP = Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                            Exit Function
                                        End If
                                    Next Err
                                End If
                            End If
                            Application.DoEvents()
                        Loop
                    Catch ex As Exception

                    End Try
                    ' Make Sure Open Ubnt and Load Successfully
                    Do Until ServerOpen.Web1.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
                Catch ex As Exception
                    MsgBox("On " & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
                End Try
            End If
            Do While ServerOpen.Web1.ReadyState <> WebBrowserReadyState.Complete Or ServerOpen.Web1.IsBusy : Application.DoEvents() : Loop

            ServerOpen.Show()
        Catch ex As Exception
            MsgBox("On " & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
        End Try
    End Function

    ' Reboot WebBrowser Tool
    Public Function Reboot(IP As String, User As String, Pass As String)
        ' Now Login and reboot
        Serverdiscovery.WebReboot.Navigate(IP)
        Do While Serverdiscovery.WebReboot.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebReboot.IsBusy : Application.DoEvents() : Loop
        If Serverdiscovery.WebReboot.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                Serverdiscovery.WebReboot.Document.GetElementById("username").InnerText = User
                Serverdiscovery.WebReboot.Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To Serverdiscovery.WebReboot.Document.GetElementsByTagName("input").Count - 1
                    Serverdiscovery.WebReboot.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button
                Do Until Serverdiscovery.WebReboot.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop

                ' Fetch  Fetch error
                If Serverdiscovery.WebReboot.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                    For Err As Integer = 0 To Serverdiscovery.WebReboot.Document.GetElementsByTagName("div").Count - 1
                        If Serverdiscovery.WebReboot.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                            Reboot = Serverdiscovery.WebReboot.Document.GetElementsByTagName("div")(Err).InnerText()
                            Exit Function
                        End If
                    Next Err
                End If
                ' Make Sure Open Ubnt and Load Successfully
                Do Until Serverdiscovery.WebReboot.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On " & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Do While Serverdiscovery.WebReboot.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebReboot.IsBusy : Application.DoEvents() : Loop
        '  Goto  :  Reboot TAB
        Serverdiscovery.WebReboot.Navigate(IP & "/reboot.cgi")
        Do While Serverdiscovery.WebReboot.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebReboot.IsBusy : Application.DoEvents() : Loop

        'Find Reboot Button 
        Serverdiscovery.WebReboot.Document.GetElementsByTagName("input")(1).InvokeMember("click")
    End Function
    ' Changer IPs TAB
    Public Function ChangerIPsTool()
        For L = 0 To Main.ListChangeIPs.Items.Count - 1
            'Login In ubnt 
            Dim Url As String, user As String, pass As String

            ' Goto Navigate: IP Address
            Url = Main.ListChangeIPs.Items(L).SubItems(0).Text
            user = Main.ListSpy.Items(L).SubItems(12).Text
            pass = Main.ListSpy.Items(L).SubItems(13).Text

            Try
                Serverdiscovery.WebChangeIP.Navigate(Url)
                Do While Serverdiscovery.WebChangeIP.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebChangeIP.IsBusy : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On" & Url & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
            End Try
            Try
                If Serverdiscovery.WebIP.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
                    ' Set Username and Password 
                    Serverdiscovery.WebChangeIP.Document.GetElementById("username").InnerText = user
                    Serverdiscovery.WebChangeIP.Document.GetElementById("password").InnerText = pass
                    'Click Login Buttons
                    For Button As Integer = 0 To Serverdiscovery.WebChangeIP.Document.GetElementsByTagName("input").Count - 1
                        Serverdiscovery.WebChangeIP.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                    Next Button
                    Do Until Serverdiscovery.WebChangeIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop

                    ' Fetch  Fetch error
                    If Serverdiscovery.WebChangeIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                        For Err As Integer = 0 To Serverdiscovery.WebChangeIP.Document.GetElementsByTagName("div").Count - 1
                            If Serverdiscovery.WebChangeIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                ChangerIPsTool = Serverdiscovery.WebChangeIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                Exit Function
                            End If
                        Next Err
                    End If
                    ' Make Sure Open Ubnt and Load Successfully
                    Do Until Serverdiscovery.WebChangeIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
                End If
            Catch ex As Exception
                MsgBox("There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
                Exit Function
            End Try


            Try

                ' Goto :  Change IPs
                Main.ListChangeIPs.Focus()
                Dim NewIP As String
                Dim GetWayIP As String

                NewIP = Main.ListChangeIPs.Items(L).SubItems(2).Text
                GetWayIP = Main.ListChangeIPs.Items(L).SubItems(3).Text

                Serverdiscovery.WebChangeIP.Navigate(Url & "/network.cgi")
                Do While Serverdiscovery.WebChangeIP.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebChangeIP.IsBusy : Application.DoEvents() : Loop

                'Set IP Address 
                Serverdiscovery.WebChangeIP.Document.GetElementById("mgmtIpAddr").InnerText = NewIP
                'Set IP Gatway 
                Serverdiscovery.WebChangeIP.Document.GetElementById("mgmtGateway").InnerText = GetWayIP
                'Click Chnage Button
                Serverdiscovery.WebChangeIP.Document.GetElementById("change").InvokeMember("click")
                Do While Serverdiscovery.WebChangeIP.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebChangeIP.IsBusy : Application.DoEvents() : Loop
                'Save Data Apply
                Serverdiscovery.WebChangeIP.Document.GetElementById("apply_button").InvokeMember("click")
                Do While Serverdiscovery.WebChangeIP.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebChangeIP.IsBusy : Application.DoEvents() : Loop

                ' Change IP successfully
                Main.ListChangeIPs.Items(L).SubItems(4).Text = "Changed IP"

            Catch ex As Exception
                MsgBox("On : " + Url + vbNewLine + "There are error in excute procedure ! ", vbExclamation)
            End Try
        Next L
    End Function

    ' Ping TAB
    Public Function PingTestGoto(PingFROM As String, PingTO As String, User As String, Pass As String, PacketCount As String, PacketSize As String)
        Try
            Serverdiscovery.WebPing.Navigate(PingFROM)
            Do While Serverdiscovery.WebPing.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebPing.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On" & PingFROM & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
        End Try
        If Serverdiscovery.WebPing.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                Serverdiscovery.WebPing.Document.GetElementById("username").InnerText = User
                Serverdiscovery.WebPing.Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To Serverdiscovery.WebPing.Document.GetElementsByTagName("input").Count - 1
                    Serverdiscovery.WebPing.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button

                Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                    If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString = "https://" & PingFROM & "/login.cgi" Then
                        ' Fetch  Error Logim
                        If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                            For Err As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("div").Count - 1
                                If Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                    PingTestGoto = Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                    Exit Function
                                End If
                            Next Err
                        End If
                    End If
                    Application.DoEvents()
                Loop

                ' Make Sure Open Ubnt and Load Successfully
                Do Until Serverdiscovery.WebPing.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On " & PingFROM & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Try
            Do While Serverdiscovery.WebPing.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebPing.IsBusy : Application.DoEvents() : Loop

            Serverdiscovery.WebPing.Navigate(PingFROM & "/pingtest.cgi")
            Do While Serverdiscovery.WebPing.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebPing.IsBusy : Application.DoEvents() : Loop
            ' Set Values 
            Serverdiscovery.WebPing.Document.GetElementById("dst_addr_input").InnerText = PingTO
            Serverdiscovery.WebPing.Document.GetElementById("ping_count").InnerText = PacketCount
            Serverdiscovery.WebPing.Document.GetElementById("ping_size").InnerText = PacketSize
            ' Click Ping Buttons
            Serverdiscovery.WebPing.Document.GetElementById("ping").InvokeMember("click")

        Catch ex As Exception
            MsgBox("On : " + PingFROM + vbNewLine + "There are error in excute procedure ! ", vbExclamation)
        End Try

    End Function
    Public Sub FetchDataToPing(PacketCount As Integer)
        Try
            If Serverdiscovery.WebPing.Url.AbsoluteUri.ToString.IndexOf("pingtest.cgi") > -1 Then
                If Main.ListPing.Items.Count <> PacketCount Then
                    ' Fetch Ping Information
                    Main.ListPing.Items.Clear()
                    Dim A As Integer = 19 + (3 * PacketCount)
                    Do While Main.CheckAutoBringData.Checked = True
                        If Serverdiscovery.WebPing.Document.GetElementsByTagName("td").Count > 24 Then
                            Dim Counter As Integer = Serverdiscovery.WebPing.Document.GetElementsByTagName("td").Count - 1
                            For L = 19 To Counter Step 3
                                If Serverdiscovery.WebPing.Document.GetElementsByTagName("td")(L).InnerText.IndexOf("of") = -1 Then

                                    Main.ListPing.Items.Add(Serverdiscovery.WebPing.Document.GetElementsByTagName("td")(L).InnerText)
                                    For J = L + 1 To (L + 2)
                                        Main.ListPing.Items(Main.ListPing.Items.Count - 1).SubItems.Add(Serverdiscovery.WebPing.Document.GetElementsByTagName("td")(J).InnerText)
                                    Next
                                    Counter = Serverdiscovery.WebPing.Document.GetElementsByTagName("td").Count - 1
                                Else

                                    If Val(Serverdiscovery.WebPing.Document.GetElementsByTagName("td")(A).InnerText.Substring(0, Serverdiscovery.WebPing.Document.GetElementsByTagName("td")(A).InnerText.IndexOf(" of"))) = Val(PacketCount) Then
                                        Exit Sub
                                    Else
                                        Main.ListPing.Items.Clear()
                                        Exit For
                                    End If
                                End If
                                    Application.DoEvents()
                            Next
                        End If
                        Application.DoEvents()
                    Loop
                Else
                    MsgBox("Ok, Done Successfully !", vbInformation)
                End If
            End If
        Catch ex As Exception
            MsgBox("Please , Make Ping Correctly . You didn't click ping buttons.", vbExclamation)
        End Try

    End Sub

    ' Info  AP TAB  Speed Test
    Public Function SpeedTestUsers(IP As String, IPTO As String, User As String, Pass As String)
        Try
            Serverdiscovery.WebSpeed.Navigate(IP)
            Do While Serverdiscovery.WebSpeed.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebSpeed.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On" & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
        End Try
        If Serverdiscovery.WebSpeed.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                Serverdiscovery.WebSpeed.Document.GetElementById("username").InnerText = User
                Serverdiscovery.WebSpeed.Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To Serverdiscovery.WebSpeed.Document.GetElementsByTagName("input").Count - 1
                    Serverdiscovery.WebSpeed.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button

                Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                    If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString = "https://" & IP & "/login.cgi" Then
                        ' Fetch  Error Logim
                        If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                            For Err As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("div").Count - 1
                                If Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                    SpeedTestUsers = Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                    Exit Function
                                End If
                            Next Err
                        End If
                    End If
                    Application.DoEvents()
                Loop

                ' Make Sure Open Ubnt and Load Successfully
                Do Until Serverdiscovery.WebSpeed.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On " & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Try
            Do While Serverdiscovery.WebSpeed.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebSpeed.IsBusy : Application.DoEvents() : Loop

            Serverdiscovery.WebSpeed.Navigate(IP & "/sptest.cgi")
            Do While Serverdiscovery.WebSpeed.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebSpeed.IsBusy : Application.DoEvents() : Loop
            ' Set Values 
            Serverdiscovery.WebSpeed.Document.GetElementById("dst_addr_input").InnerText = IPTO
            Serverdiscovery.WebSpeed.Document.GetElementById("auth_user").InnerText = User
            Serverdiscovery.WebSpeed.Document.GetElementById("auth_password").InnerText = Pass
            ' Click Speed Test Buttons :  Start 
            Serverdiscovery.WebSpeed.Document.GetElementById("runtest").InvokeMember("click")


            FetchDataSpeedTest()
        Catch ex As Exception
            MsgBox("On : " + IP + vbNewLine + "There are error in excute procedure ! ", vbExclamation)
        End Try
    End Function
    Public Function FetchDataSpeedTest()
        On Error Resume Next
        Do While Serverdiscovery.WebSpeed.Document.GetElementById("result").InnerText = ""
            Dim TX, RX, Total As String
            TX = Serverdiscovery.WebSpeed.Document.GetElementById("tx_results").InnerText
            RX = Serverdiscovery.WebSpeed.Document.GetElementById("rx_results").InnerText
            Total = Serverdiscovery.WebSpeed.Document.GetElementById("total_results").InnerText
            ' Chart Clear Old Points
            Main.ChartSpeedTest.Series(0).Points.Clear()
            Main.ChartSpeedTest.Series(2).Points.Clear()
            Main.ChartSpeedTest.Series(4).Points.Clear()
            'ADD to Chart
            Main.ChartSpeedTest.Series(0).Points.AddXY("", Val(TX.Substring(0, TX.IndexOf(" Mbps"))))
            Main.ChartSpeedTest.Series(2).Points.AddXY("", Val(RX.Substring(0, RX.IndexOf(" Mbps"))))
            Main.ChartSpeedTest.Series(4).Points.AddXY("", Val(Total.Substring(0, Total.IndexOf(" Mbps"))))

            ' Add To label
            Main.LabTX.Text = "TX (Upload): " & TX
            Main.LabRX.Text = "RX (Downlaod): " & RX
            Main.LabTotal.Text = "Total: " & Total
            Application.DoEvents()
        Loop

    End Function

    Public Function TracerouteMaker(IP As String, User As String, Pass As String, hostDis As String) As String
        Try
            Serverdiscovery.WebTraceroute.Navigate(IP)
            Do While Serverdiscovery.WebTraceroute.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebTraceroute.IsBusy : Application.DoEvents() : Loop
        Catch ex As Exception
            MsgBox("On" & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & " IP address is not found !")
        End Try
        If Serverdiscovery.WebTraceroute.Url.AbsolutePath().ToString.IndexOf("login.cgi") > -1 Then
            Try
                ' Set Username and Password 
                Serverdiscovery.WebTraceroute.Document.GetElementById("username").InnerText = User
                Serverdiscovery.WebTraceroute.Document.GetElementById("password").InnerText = Pass
                'Click Login Buttons
                For Button As Integer = 0 To Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("input").Count - 1
                    Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("input")(Button).InvokeMember("click")
                Next Button

                Do Until Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1
                    If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString = "https://" & IP & "/login.cgi" Then
                        ' Fetch  Error Logim
                        If Serverdiscovery.WebIP.Url.AbsoluteUri.ToString.IndexOf("index.cgi") = -1 Then
                            For Err As Integer = 0 To Serverdiscovery.WebIP.Document.GetElementsByTagName("div").Count - 1
                                If Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText.IndexOf("Invalid") > -1 Then
                                    TracerouteMaker = Serverdiscovery.WebIP.Document.GetElementsByTagName("div")(Err).InnerText()
                                    Exit Function
                                End If
                            Next Err
                        End If
                    End If
                    Application.DoEvents()
                Loop

                ' Make Sure Open Ubnt and Load Successfully
                Do Until Serverdiscovery.WebTraceroute.Url.AbsoluteUri.ToString.IndexOf("index.cgi") > -1 : Application.DoEvents() : Loop
            Catch ex As Exception
                MsgBox("On " & IP & vbNewLine & "There is error in login to UBNT Drive Because" & vbNewLine & "1- IP address is not found !" & vbNewLine & "2- Network is weak!" & vbNewLine & "3- Or error on open http URL." & vbNewLine & "Please, Fix this error and try again", vbExclamation)
            End Try
        End If
        Try
            Do While Serverdiscovery.WebTraceroute.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebTraceroute.IsBusy : Application.DoEvents() : Loop

            Serverdiscovery.WebTraceroute.Navigate(IP & "/traceroute.cgi")
            Do While Serverdiscovery.WebTraceroute.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebTraceroute.IsBusy : Application.DoEvents() : Loop
            ' Set Values 
            Serverdiscovery.WebTraceroute.Document.GetElementById("dst_host").InnerText = hostDis
            Do While Serverdiscovery.WebTraceroute.ReadyState <> WebBrowserReadyState.Complete Or Serverdiscovery.WebTraceroute.IsBusy : Application.DoEvents() : Loop
            ' Click Speed Test Buttons :  Start 
            Serverdiscovery.WebTraceroute.Document.GetElementById("tr_start").InvokeMember("click")
            TracerouteBringData()
        Catch ex As Exception
            MsgBox("On : " + IP + vbNewLine + "There are error in excute procedure ! ", vbExclamation)
        End Try
    End Function

    Public Function TracerouteBringData()
        On Error Resume Next
        Dim Check As Integer = Serverdiscovery.WebTraceroute.Document.GetElementById("tr_start").OuterHtml.IndexOf("Stop")
        Do While Check > -1
            Main.ListTaceroute.Items.Clear()
            For L = 9 To Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("td").Count - 1 Step 4
                If Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("td")(L).InnerText <> "" Then
                    Main.ListTaceroute.Items.Add(Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("td")(L).InnerText)
                    'Column's Function
                    For J = L + 1 To (L + 3)
                        If Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("td")(J).InnerText <> "" Then
                            Main.ListTaceroute.Items(Main.ListTaceroute.Items.Count - 1).SubItems.Add(Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("td")(J).InnerText)
                        Else
                            Main.ListTaceroute.Items(Main.ListTaceroute.Items.Count - 1).SubItems.Add(Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("td")(J).FirstChild.InnerText)
                        End If
                    Next
                End If
                ' Rest
                Check = Serverdiscovery.WebTraceroute.Document.GetElementById("tr_start").OuterHtml.IndexOf("Stop")
            Next
            'FOR 
            For L = 3 To Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("input").Count - 1
                Dim data As String = Serverdiscovery.WebTraceroute.Document.GetElementsByTagName("input")(L).OuterHtml
                data = data.Substring(data.IndexOf("value="))
                data = data.Replace("value=", "")
                For J = 0 To Main.ListTaceroute.Items.Count - 1
                    If Main.ListTaceroute.Items(J).SubItems(1).Text = "" Then
                        Main.ListTaceroute.Items(J).SubItems(1).Text = data.Replace(">", "")
                        Exit For
                    End If
                Next
            Next
            Application.DoEvents()
        Loop
    End Function
End Module
