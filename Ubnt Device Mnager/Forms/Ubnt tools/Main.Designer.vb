<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Spy Users", 2, 2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("discovery IPs", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("discovery Survey", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IPs Changer", 2, 2)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ping Test", 2, 2)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Info")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Speed Test")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Traceroute", 2, 2)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Info UBNT", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UBNT Users Tools", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wifi Scanner", 2, 2)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wifi Sniffer")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wifi Tools", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staustion")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rocket Tools", New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ubnt Devices Manager", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode13, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Survey")
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 5.0R)
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 7.0R)
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 14.0R)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "Device Name"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2", "Product"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"3", "Firmware"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"4", "Connection Time"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5", "RX Signal"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"6", "TX Signal"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"7", "Noise Floor"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"8", "Distance"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"9", "CCQ"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"10", "TX Power"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"11", "Last IP"}, -1)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"12", "TX/RX Rate"}, -1)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"13", "TX/RX Bit Rate"}, -1)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"14", "TX/RX Packets"}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"15", "TX/RX Packet Rate, pps"}, -1)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"16", "Bytes Transmitted"}, -1, System.Drawing.Color.Crimson, System.Drawing.Color.Empty, Nothing)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"17", "Bytes Received"}, -1, System.Drawing.SystemColors.MenuHighlight, System.Drawing.Color.Empty, Nothing)
        Me.ToolsPanel = New System.Windows.Forms.Panel()
        Me.PanelNavbarBottom = New System.Windows.Forms.Panel()
        Me.PictureSeetingConsole = New System.Windows.Forms.PictureBox()
        Me.PictureSound = New System.Windows.Forms.PictureBox()
        Me.TabTools = New System.Windows.Forms.TabControl()
        Me.Tools = New System.Windows.Forms.TabPage()
        Me.TreeNavbar = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Rocket = New System.Windows.Forms.TabPage()
        Me.ComboTreeSurvey = New System.Windows.Forms.ComboBox()
        Me.PictureRefresh = New System.Windows.Forms.PictureBox()
        Me.TreeSurvey = New System.Windows.Forms.TreeView()
        Me.ContextMenuSurvey = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenIPAddressToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabConsole = New System.Windows.Forms.TabControl()
        Me.Console = New System.Windows.Forms.TabPage()
        Me.ListConsole = New System.Windows.Forms.ListView()
        Me.ErrorType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuConsole = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenIPAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingTestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSurveyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyIPAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.ReadyPro = New System.Windows.Forms.Label()
        Me.Selector = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.PictureAbout = New System.Windows.Forms.PictureBox()
        Me.PictureClose = New System.Windows.Forms.PictureBox()
        Me.PictureMinimize = New System.Windows.Forms.PictureBox()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabContainer = New System.Windows.Forms.TabControl()
        Me.SpyPage = New System.Windows.Forms.TabPage()
        Me.ListSpy = New System.Windows.Forms.ListView()
        Me.MianID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IPsAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DevicesName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DevicesModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Versions = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Distances = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Signal_Strength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NoiseFloors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Transmit_CCQ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TXRX_Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.APsMAC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SSID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Passwords = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuSpyUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscoveryIPsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscoverySurveyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPsChangerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunTESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.discoveryIPs = New System.Windows.Forms.TabPage()
        Me.PanelIPTools = New System.Windows.Forms.Panel()
        Me.ComboFilterIPs = New System.Windows.Forms.ComboBox()
        Me.IPRefresh = New System.Windows.Forms.Button()
        Me.ScanIPs = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboIPs = New System.Windows.Forms.ComboBox()
        Me.ListIPs = New System.Windows.Forms.ListView()
        Me.disID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disMacAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disDeviceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disSSID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disProduct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disFirmware = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.disIPaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuDiscovery = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.discoverySurvey = New System.Windows.Forms.TabPage()
        Me.PanelSureyTools = New System.Windows.Forms.Panel()
        Me.SurveyRefresh = New System.Windows.Forms.Button()
        Me.ComboSureyRange = New System.Windows.Forms.ComboBox()
        Me.SureyScan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboIPSurvey = New System.Windows.Forms.ComboBox()
        Me.ListSurey = New System.Windows.Forms.ListView()
        Me.surID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SurMACAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.surSSID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.surDeviceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.surRadioMode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.surEncryption = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.surSignal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.surFrequency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IPsChanger = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClsIPChanger = New System.Windows.Forms.Button()
        Me.AddNewIP = New System.Windows.Forms.Button()
        Me.StartChange = New System.Windows.Forms.Button()
        Me.TextNewIP = New System.Windows.Forms.TextBox()
        Me.TextIpGetway = New System.Windows.Forms.TextBox()
        Me.TextIP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListChangeIPs = New System.Windows.Forms.ListView()
        Me.ChID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CurrentIPaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDeviceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NewIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Getway = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Satus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PingTest = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextPing = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PingCounterLab = New System.Windows.Forms.Label()
        Me.RefreshBringPing = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckAutoBringData = New System.Windows.Forms.CheckBox()
        Me.ComboIPPing = New System.Windows.Forms.ComboBox()
        Me.PingStart = New System.Windows.Forms.Button()
        Me.ClearPing = New System.Windows.Forms.Button()
        Me.TextPacketPing = New System.Windows.Forms.TextBox()
        Me.TextPacketSizePing = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListPing = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfoUBTN = New System.Windows.Forms.TabPage()
        Me.PictureRefreshPing = New System.Windows.Forms.PictureBox()
        Me.TabInfo = New System.Windows.Forms.TabControl()
        Me.InfoUser = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabAP = New System.Windows.Forms.Label()
        Me.LabProduct = New System.Windows.Forms.Label()
        Me.LabIPaddress = New System.Windows.Forms.Label()
        Me.LabDeviceName = New System.Windows.Forms.Label()
        Me.PictureNanoType = New System.Windows.Forms.PictureBox()
        Me.ChartMemory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelMemory = New System.Windows.Forms.Label()
        Me.LabelCPU = New System.Windows.Forms.Label()
        Me.ChartCPU = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SpeedNet = New System.Windows.Forms.TabPage()
        Me.LabTotal = New System.Windows.Forms.Label()
        Me.LabRX = New System.Windows.Forms.Label()
        Me.LabTX = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ChartSpeedTest = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SpeedTestGo = New System.Windows.Forms.Button()
        Me.Treceroute = New System.Windows.Forms.TabPage()
        Me.TextHost = New System.Windows.Forms.TextBox()
        Me.GoTraceroute = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ListTaceroute = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GoInfo = New System.Windows.Forms.Button()
        Me.ComboIPsInfo = New System.Windows.Forms.ComboBox()
        Me.ListInfo = New System.Windows.Forms.ListView()
        Me.IdInfo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameProperties = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PropertiesValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IPAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SignalStrength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NoiseFloor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TransmitCCQ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TXRXRate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.APMAC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Distance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Version = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Uername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureAdd = New System.Windows.Forms.PictureBox()
        Me.PictureRemove = New System.Windows.Forms.PictureBox()
        Me.PictureStart = New System.Windows.Forms.PictureBox()
        Me.PictureStop = New System.Windows.Forms.PictureBox()
        Me.Moniter = New System.Windows.Forms.TabPage()
        Me.TabChart = New System.Windows.Forms.TabControl()
        Me.ToolTipAll = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureCreate = New System.Windows.Forms.PictureBox()
        Me.ToolsPanel.SuspendLayout()
        Me.PanelNavbarBottom.SuspendLayout()
        CType(Me.PictureSeetingConsole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTools.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.Rocket.SuspendLayout()
        CType(Me.PictureRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuSurvey.SuspendLayout()
        Me.TabConsole.SuspendLayout()
        Me.Console.SuspendLayout()
        Me.ContextMenuConsole.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        CType(Me.PictureAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabContainer.SuspendLayout()
        Me.SpyPage.SuspendLayout()
        Me.ContextMenuSpyUsers.SuspendLayout()
        Me.discoveryIPs.SuspendLayout()
        Me.PanelIPTools.SuspendLayout()
        Me.ContextMenuDiscovery.SuspendLayout()
        Me.discoverySurvey.SuspendLayout()
        Me.PanelSureyTools.SuspendLayout()
        Me.IPsChanger.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PingTest.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.InfoUBTN.SuspendLayout()
        CType(Me.PictureRefreshPing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInfo.SuspendLayout()
        Me.InfoUser.SuspendLayout()
        CType(Me.PictureNanoType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartMemory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpeedNet.SuspendLayout()
        CType(Me.ChartSpeedTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Treceroute.SuspendLayout()
        CType(Me.PictureAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChart.SuspendLayout()
        CType(Me.PictureCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolsPanel
        '
        Me.ToolsPanel.BackColor = System.Drawing.SystemColors.Menu
        Me.ToolsPanel.Controls.Add(Me.PanelNavbarBottom)
        Me.ToolsPanel.Controls.Add(Me.TabTools)
        Me.ToolsPanel.Controls.Add(Me.TabConsole)
        Me.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToolsPanel.Name = "ToolsPanel"
        Me.ToolsPanel.Size = New System.Drawing.Size(280, 680)
        Me.ToolsPanel.TabIndex = 0
        '
        'PanelNavbarBottom
        '
        Me.PanelNavbarBottom.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanelNavbarBottom.Controls.Add(Me.PictureSeetingConsole)
        Me.PanelNavbarBottom.Controls.Add(Me.PictureSound)
        Me.PanelNavbarBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelNavbarBottom.Location = New System.Drawing.Point(0, 661)
        Me.PanelNavbarBottom.Name = "PanelNavbarBottom"
        Me.PanelNavbarBottom.Size = New System.Drawing.Size(280, 19)
        Me.PanelNavbarBottom.TabIndex = 2
        '
        'PictureSeetingConsole
        '
        Me.PictureSeetingConsole.BackColor = System.Drawing.SystemColors.Highlight
        Me.PictureSeetingConsole.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSeetingConsole.Image = CType(resources.GetObject("PictureSeetingConsole.Image"), System.Drawing.Image)
        Me.PictureSeetingConsole.Location = New System.Drawing.Point(40, 2)
        Me.PictureSeetingConsole.Name = "PictureSeetingConsole"
        Me.PictureSeetingConsole.Size = New System.Drawing.Size(15, 15)
        Me.PictureSeetingConsole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureSeetingConsole.TabIndex = 12
        Me.PictureSeetingConsole.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureSeetingConsole, "Click to Setting Console")
        '
        'PictureSound
        '
        Me.PictureSound.BackColor = System.Drawing.SystemColors.Highlight
        Me.PictureSound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureSound.Image = CType(resources.GetObject("PictureSound.Image"), System.Drawing.Image)
        Me.PictureSound.Location = New System.Drawing.Point(16, 2)
        Me.PictureSound.Name = "PictureSound"
        Me.PictureSound.Size = New System.Drawing.Size(15, 15)
        Me.PictureSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureSound.TabIndex = 11
        Me.PictureSound.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureSound, "Click to Active Sound or Not")
        '
        'TabTools
        '
        Me.TabTools.Controls.Add(Me.Tools)
        Me.TabTools.Controls.Add(Me.Rocket)
        Me.TabTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabTools.Location = New System.Drawing.Point(0, 0)
        Me.TabTools.Name = "TabTools"
        Me.TabTools.SelectedIndex = 0
        Me.TabTools.Size = New System.Drawing.Size(280, 468)
        Me.TabTools.TabIndex = 1
        '
        'Tools
        '
        Me.Tools.Controls.Add(Me.TreeNavbar)
        Me.Tools.Location = New System.Drawing.Point(4, 22)
        Me.Tools.Name = "Tools"
        Me.Tools.Padding = New System.Windows.Forms.Padding(3)
        Me.Tools.Size = New System.Drawing.Size(272, 442)
        Me.Tools.TabIndex = 0
        Me.Tools.Text = "TOOLS"
        Me.Tools.UseVisualStyleBackColor = True
        '
        'TreeNavbar
        '
        Me.TreeNavbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeNavbar.ImageIndex = 0
        Me.TreeNavbar.ImageList = Me.ImageList1
        Me.TreeNavbar.Location = New System.Drawing.Point(3, 3)
        Me.TreeNavbar.Name = "TreeNavbar"
        TreeNode1.Checked = True
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "Node0"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "Spy Users"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "Node1"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "discovery IPs"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "Node2"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "discovery Survey"
        TreeNode4.ForeColor = System.Drawing.Color.Black
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = "Node3"
        TreeNode4.SelectedImageIndex = 2
        TreeNode4.Text = "IPs Changer"
        TreeNode5.ForeColor = System.Drawing.Color.Black
        TreeNode5.ImageIndex = 2
        TreeNode5.Name = "Node4"
        TreeNode5.SelectedImageIndex = 2
        TreeNode5.Text = "Ping Test"
        TreeNode6.ImageKey = "icons8-gear-24.png"
        TreeNode6.Name = "Node0"
        TreeNode6.SelectedImageIndex = 2
        TreeNode6.Text = "User Info"
        TreeNode7.ImageKey = "icons8-gear-24.png"
        TreeNode7.Name = "Node1"
        TreeNode7.SelectedImageIndex = 2
        TreeNode7.Text = "Speed Test"
        TreeNode8.ImageIndex = 2
        TreeNode8.Name = "Node2"
        TreeNode8.SelectedImageIndex = 2
        TreeNode8.Text = "Traceroute"
        TreeNode9.ForeColor = System.Drawing.Color.Black
        TreeNode9.ImageIndex = 2
        TreeNode9.Name = "Node1"
        TreeNode9.SelectedImageIndex = 2
        TreeNode9.Text = "Info UBNT"
        TreeNode10.Name = "Node0"
        TreeNode10.Text = "UBNT Users Tools"
        TreeNode11.ImageIndex = 2
        TreeNode11.Name = "Node2"
        TreeNode11.SelectedImageIndex = 2
        TreeNode11.Text = "Wifi Scanner"
        TreeNode12.ImageIndex = 2
        TreeNode12.Name = "Node3"
        TreeNode12.SelectedImageKey = "icons8-gear-24.png"
        TreeNode12.Text = "Wifi Sniffer"
        TreeNode13.ForeColor = System.Drawing.Color.Red
        TreeNode13.Name = "Node1"
        TreeNode13.Text = "Wifi Tools"
        TreeNode14.ImageKey = "icons8-gear-24.png"
        TreeNode14.Name = "Node0"
        TreeNode14.SelectedImageIndex = 2
        TreeNode14.Text = "Staustion"
        TreeNode15.ForeColor = System.Drawing.Color.Red
        TreeNode15.Name = "Node4"
        TreeNode15.Text = "Rocket Tools"
        TreeNode16.Checked = True
        TreeNode16.ImageIndex = 0
        TreeNode16.Name = "Node0"
        TreeNode16.Text = "Ubnt Devices Manager"
        TreeNode16.ToolTipText = "Ok"
        Me.TreeNavbar.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.TreeNavbar.SelectedImageIndex = 0
        Me.TreeNavbar.Size = New System.Drawing.Size(266, 436)
        Me.TreeNavbar.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-network-card-100.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-wired-network-64.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-gear-24.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-administrative-tools-100.png")
        '
        'Rocket
        '
        Me.Rocket.Controls.Add(Me.ComboTreeSurvey)
        Me.Rocket.Controls.Add(Me.PictureRefresh)
        Me.Rocket.Controls.Add(Me.TreeSurvey)
        Me.Rocket.Location = New System.Drawing.Point(4, 22)
        Me.Rocket.Name = "Rocket"
        Me.Rocket.Padding = New System.Windows.Forms.Padding(3)
        Me.Rocket.Size = New System.Drawing.Size(272, 442)
        Me.Rocket.TabIndex = 1
        Me.Rocket.Text = "SURVEY"
        Me.Rocket.UseVisualStyleBackColor = True
        '
        'ComboTreeSurvey
        '
        Me.ComboTreeSurvey.FormattingEnabled = True
        Me.ComboTreeSurvey.Items.AddRange(New Object() {"From Spy Users", "From discovery IPs"})
        Me.ComboTreeSurvey.Location = New System.Drawing.Point(3, 4)
        Me.ComboTreeSurvey.Name = "ComboTreeSurvey"
        Me.ComboTreeSurvey.Size = New System.Drawing.Size(236, 21)
        Me.ComboTreeSurvey.TabIndex = 2
        Me.ComboTreeSurvey.Text = "From Spy Users"
        '
        'PictureRefresh
        '
        Me.PictureRefresh.Image = CType(resources.GetObject("PictureRefresh.Image"), System.Drawing.Image)
        Me.PictureRefresh.Location = New System.Drawing.Point(245, 4)
        Me.PictureRefresh.Name = "PictureRefresh"
        Me.PictureRefresh.Size = New System.Drawing.Size(27, 23)
        Me.PictureRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureRefresh.TabIndex = 1
        Me.PictureRefresh.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureRefresh, "Click to Refresh Survey Ubnt")
        '
        'TreeSurvey
        '
        Me.TreeSurvey.ContextMenuStrip = Me.ContextMenuSurvey
        Me.TreeSurvey.ImageIndex = 0
        Me.TreeSurvey.ImageList = Me.ImageList1
        Me.TreeSurvey.Location = New System.Drawing.Point(0, 28)
        Me.TreeSurvey.Name = "TreeSurvey"
        TreeNode17.Name = "Node0"
        TreeNode17.Text = "Survey"
        Me.TreeSurvey.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode17})
        Me.TreeSurvey.SelectedImageIndex = 0
        Me.TreeSurvey.Size = New System.Drawing.Size(280, 412)
        Me.TreeSurvey.TabIndex = 0
        '
        'ContextMenuSurvey
        '
        Me.ContextMenuSurvey.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem1, Me.OpenIPAddressToolStripMenuItem1})
        Me.ContextMenuSurvey.Name = "ContextMenuSurvey"
        Me.ContextMenuSurvey.Size = New System.Drawing.Size(162, 48)
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'OpenIPAddressToolStripMenuItem1
        '
        Me.OpenIPAddressToolStripMenuItem1.Name = "OpenIPAddressToolStripMenuItem1"
        Me.OpenIPAddressToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.OpenIPAddressToolStripMenuItem1.Text = "Open IP Address"
        '
        'TabConsole
        '
        Me.TabConsole.Controls.Add(Me.Console)
        Me.TabConsole.Location = New System.Drawing.Point(4, 471)
        Me.TabConsole.Name = "TabConsole"
        Me.TabConsole.SelectedIndex = 0
        Me.TabConsole.Size = New System.Drawing.Size(280, 214)
        Me.TabConsole.TabIndex = 0
        Me.ToolTipAll.SetToolTip(Me.TabConsole, "Any error in Spy User will appaer here")
        '
        'Console
        '
        Me.Console.Controls.Add(Me.ListConsole)
        Me.Console.Location = New System.Drawing.Point(4, 22)
        Me.Console.Name = "Console"
        Me.Console.Padding = New System.Windows.Forms.Padding(3)
        Me.Console.Size = New System.Drawing.Size(272, 188)
        Me.Console.TabIndex = 0
        Me.Console.Text = "CONSOLE"
        Me.Console.UseVisualStyleBackColor = True
        '
        'ListConsole
        '
        Me.ListConsole.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ErrorType, Me.IP})
        Me.ListConsole.ContextMenuStrip = Me.ContextMenuConsole
        Me.ListConsole.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListConsole.FullRowSelect = True
        Me.ListConsole.GridLines = True
        Me.ListConsole.Location = New System.Drawing.Point(3, 3)
        Me.ListConsole.Name = "ListConsole"
        Me.ListConsole.Size = New System.Drawing.Size(266, 161)
        Me.ListConsole.TabIndex = 0
        Me.ListConsole.UseCompatibleStateImageBehavior = False
        Me.ListConsole.View = System.Windows.Forms.View.Details
        '
        'ErrorType
        '
        Me.ErrorType.Text = "Error Type"
        Me.ErrorType.Width = 80
        '
        'IP
        '
        Me.IP.Text = "IPs"
        Me.IP.Width = 180
        '
        'ContextMenuConsole
        '
        Me.ContextMenuConsole.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenIPAddressToolStripMenuItem, Me.FixToolStripMenuItem, Me.RebootToolStripMenuItem, Me.FirmwareToolStripMenuItem, Me.CopyIPAddressToolStripMenuItem})
        Me.ContextMenuConsole.Name = "ContextMenuConsole"
        Me.ContextMenuConsole.Size = New System.Drawing.Size(162, 114)
        '
        'OpenIPAddressToolStripMenuItem
        '
        Me.OpenIPAddressToolStripMenuItem.Name = "OpenIPAddressToolStripMenuItem"
        Me.OpenIPAddressToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenIPAddressToolStripMenuItem.Text = "Open IP Address"
        '
        'FixToolStripMenuItem
        '
        Me.FixToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.FixToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingTestToolStripMenuItem1, Me.ChangeIPToolStripMenuItem, Me.ChangeSurveyToolStripMenuItem})
        Me.FixToolStripMenuItem.Image = CType(resources.GetObject("FixToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FixToolStripMenuItem.Name = "FixToolStripMenuItem"
        Me.FixToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FixToolStripMenuItem.Text = "Fix"
        '
        'PingTestToolStripMenuItem1
        '
        Me.PingTestToolStripMenuItem1.Name = "PingTestToolStripMenuItem1"
        Me.PingTestToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.PingTestToolStripMenuItem1.Text = "Ping Test"
        '
        'ChangeIPToolStripMenuItem
        '
        Me.ChangeIPToolStripMenuItem.Name = "ChangeIPToolStripMenuItem"
        Me.ChangeIPToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ChangeIPToolStripMenuItem.Text = "Change IP"
        '
        'ChangeSurveyToolStripMenuItem
        '
        Me.ChangeSurveyToolStripMenuItem.Name = "ChangeSurveyToolStripMenuItem"
        Me.ChangeSurveyToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ChangeSurveyToolStripMenuItem.Text = "Change Survey"
        '
        'RebootToolStripMenuItem
        '
        Me.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        Me.RebootToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RebootToolStripMenuItem.Text = "Reboot"
        '
        'FirmwareToolStripMenuItem
        '
        Me.FirmwareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchUpdateToolStripMenuItem, Me.UploadUpdateToolStripMenuItem})
        Me.FirmwareToolStripMenuItem.Name = "FirmwareToolStripMenuItem"
        Me.FirmwareToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FirmwareToolStripMenuItem.Text = "Firmware"
        '
        'SearchUpdateToolStripMenuItem
        '
        Me.SearchUpdateToolStripMenuItem.Name = "SearchUpdateToolStripMenuItem"
        Me.SearchUpdateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SearchUpdateToolStripMenuItem.Text = "Search Update"
        '
        'UploadUpdateToolStripMenuItem
        '
        Me.UploadUpdateToolStripMenuItem.Name = "UploadUpdateToolStripMenuItem"
        Me.UploadUpdateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.UploadUpdateToolStripMenuItem.Text = "Upload Update"
        '
        'CopyIPAddressToolStripMenuItem
        '
        Me.CopyIPAddressToolStripMenuItem.Name = "CopyIPAddressToolStripMenuItem"
        Me.CopyIPAddressToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CopyIPAddressToolStripMenuItem.Text = "Copy IP Address"
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanelContainer.Controls.Add(Me.ReadyPro)
        Me.PanelContainer.Controls.Add(Me.Selector)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContainer.Location = New System.Drawing.Point(280, 488)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1004, 192)
        Me.PanelContainer.TabIndex = 1
        '
        'ReadyPro
        '
        Me.ReadyPro.AutoSize = True
        Me.ReadyPro.Location = New System.Drawing.Point(6, 176)
        Me.ReadyPro.Name = "ReadyPro"
        Me.ReadyPro.Size = New System.Drawing.Size(38, 13)
        Me.ReadyPro.TabIndex = 1
        Me.ReadyPro.Text = "Ready"
        '
        'Selector
        '
        Me.Selector.AutoSize = True
        Me.Selector.Location = New System.Drawing.Point(900, 176)
        Me.Selector.Name = "Selector"
        Me.Selector.Size = New System.Drawing.Size(54, 13)
        Me.Selector.TabIndex = 0
        Me.Selector.Text = "TOTAL: 0"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TitlePanel.Controls.Add(Me.PictureAbout)
        Me.TitlePanel.Controls.Add(Me.PictureClose)
        Me.TitlePanel.Controls.Add(Me.PictureMinimize)
        Me.TitlePanel.Controls.Add(Me.PictureLogo)
        Me.TitlePanel.Controls.Add(Me.Label1)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(280, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1004, 23)
        Me.TitlePanel.TabIndex = 2
        '
        'PictureAbout
        '
        Me.PictureAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureAbout.Image = CType(resources.GetObject("PictureAbout.Image"), System.Drawing.Image)
        Me.PictureAbout.Location = New System.Drawing.Point(946, 5)
        Me.PictureAbout.Name = "PictureAbout"
        Me.PictureAbout.Size = New System.Drawing.Size(15, 15)
        Me.PictureAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureAbout.TabIndex = 10
        Me.PictureAbout.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureAbout, "About")
        '
        'PictureClose
        '
        Me.PictureClose.Image = CType(resources.GetObject("PictureClose.Image"), System.Drawing.Image)
        Me.PictureClose.Location = New System.Drawing.Point(981, 0)
        Me.PictureClose.Name = "PictureClose"
        Me.PictureClose.Size = New System.Drawing.Size(23, 23)
        Me.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureClose.TabIndex = 1
        Me.PictureClose.TabStop = False
        '
        'PictureMinimize
        '
        Me.PictureMinimize.Image = CType(resources.GetObject("PictureMinimize.Image"), System.Drawing.Image)
        Me.PictureMinimize.Location = New System.Drawing.Point(962, 0)
        Me.PictureMinimize.Name = "PictureMinimize"
        Me.PictureMinimize.Size = New System.Drawing.Size(23, 23)
        Me.PictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureMinimize.TabIndex = 2
        Me.PictureMinimize.TabStop = False
        '
        'PictureLogo
        '
        Me.PictureLogo.Image = Global.Ubnt_Device_Mnager.My.Resources.Resources.Logo
        Me.PictureLogo.Location = New System.Drawing.Point(4, 0)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(31, 23)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 3
        Me.PictureLogo.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureLogo, "V 1.0")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ubnt Devices Manager"
        '
        'TabContainer
        '
        Me.TabContainer.Controls.Add(Me.SpyPage)
        Me.TabContainer.Controls.Add(Me.discoveryIPs)
        Me.TabContainer.Controls.Add(Me.discoverySurvey)
        Me.TabContainer.Controls.Add(Me.IPsChanger)
        Me.TabContainer.Controls.Add(Me.PingTest)
        Me.TabContainer.Controls.Add(Me.InfoUBTN)
        Me.TabContainer.Location = New System.Drawing.Point(278, 25)
        Me.TabContainer.Name = "TabContainer"
        Me.TabContainer.SelectedIndex = 0
        Me.TabContainer.Size = New System.Drawing.Size(1004, 470)
        Me.TabContainer.TabIndex = 3
        '
        'SpyPage
        '
        Me.SpyPage.BackColor = System.Drawing.SystemColors.Window
        Me.SpyPage.Controls.Add(Me.ListSpy)
        Me.SpyPage.Location = New System.Drawing.Point(4, 22)
        Me.SpyPage.Name = "SpyPage"
        Me.SpyPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SpyPage.Size = New System.Drawing.Size(996, 444)
        Me.SpyPage.TabIndex = 0
        Me.SpyPage.Text = "Spy Users"
        '
        'ListSpy
        '
        Me.ListSpy.BackColor = System.Drawing.Color.White
        Me.ListSpy.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MianID, Me.IPsAddress, Me.DevicesName, Me.DevicesModel, Me.Versions, Me.Distances, Me.Signal_Strength, Me.NoiseFloors, Me.Transmit_CCQ, Me.TXRX_Rate, Me.APsMAC, Me.SSID, Me.Username, Me.Passwords, Me.StatusCol})
        Me.ListSpy.ContextMenuStrip = Me.ContextMenuSpyUsers
        Me.ListSpy.ForeColor = System.Drawing.Color.Black
        Me.ListSpy.FullRowSelect = True
        Me.ListSpy.GridLines = True
        Me.ListSpy.LargeImageList = Me.ImageList1
        Me.ListSpy.Location = New System.Drawing.Point(7, 3)
        Me.ListSpy.MultiSelect = False
        Me.ListSpy.Name = "ListSpy"
        Me.ListSpy.ShowItemToolTips = True
        Me.ListSpy.Size = New System.Drawing.Size(990, 415)
        Me.ListSpy.SmallImageList = Me.ImageList1
        Me.ListSpy.TabIndex = 0
        Me.ListSpy.UseCompatibleStateImageBehavior = False
        Me.ListSpy.View = System.Windows.Forms.View.Details
        '
        'MianID
        '
        Me.MianID.Text = "*"
        Me.MianID.Width = 30
        '
        'IPsAddress
        '
        Me.IPsAddress.Text = "IP Address"
        Me.IPsAddress.Width = 120
        '
        'DevicesName
        '
        Me.DevicesName.Text = "Device Name"
        Me.DevicesName.Width = 120
        '
        'DevicesModel
        '
        Me.DevicesModel.Text = "Device Model"
        Me.DevicesModel.Width = 120
        '
        'Versions
        '
        Me.Versions.Text = "Version"
        Me.Versions.Width = 120
        '
        'Distances
        '
        Me.Distances.Text = "Distance"
        Me.Distances.Width = 120
        '
        'Signal_Strength
        '
        Me.Signal_Strength.Text = "Signal Strength"
        Me.Signal_Strength.Width = 100
        '
        'NoiseFloors
        '
        Me.NoiseFloors.Text = "Noise Floor"
        Me.NoiseFloors.Width = 100
        '
        'Transmit_CCQ
        '
        Me.Transmit_CCQ.Text = "Transmit CCQ"
        Me.Transmit_CCQ.Width = 99
        '
        'TXRX_Rate
        '
        Me.TXRX_Rate.Text = "TX/RX Rate"
        Me.TXRX_Rate.Width = 130
        '
        'APsMAC
        '
        Me.APsMAC.Text = "AP MAC"
        Me.APsMAC.Width = 120
        '
        'SSID
        '
        Me.SSID.Text = "SSID"
        Me.SSID.Width = 180
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 100
        '
        'Passwords
        '
        Me.Passwords.Text = "Password"
        Me.Passwords.Width = 80
        '
        'StatusCol
        '
        Me.StatusCol.Text = "Status"
        '
        'ContextMenuSpyUsers
        '
        Me.ContextMenuSpyUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.OpenIPToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.RebootToolStripMenuItem1, Me.StartToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.ContextMenuSpyUsers.Name = "ContextMenuSpyUsers"
        Me.ContextMenuSpyUsers.Size = New System.Drawing.Size(121, 136)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IPAddressToolStripMenuItem, Me.DeviceNameToolStripMenuItem, Me.VersionToolStripMenuItem})
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'IPAddressToolStripMenuItem
        '
        Me.IPAddressToolStripMenuItem.Name = "IPAddressToolStripMenuItem"
        Me.IPAddressToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.IPAddressToolStripMenuItem.Text = "IP Address"
        '
        'DeviceNameToolStripMenuItem
        '
        Me.DeviceNameToolStripMenuItem.Name = "DeviceNameToolStripMenuItem"
        Me.DeviceNameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeviceNameToolStripMenuItem.Text = "Device Name"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'OpenIPToolStripMenuItem
        '
        Me.OpenIPToolStripMenuItem.Name = "OpenIPToolStripMenuItem"
        Me.OpenIPToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.OpenIPToolStripMenuItem.Text = "Open IP"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscoveryIPsToolStripMenuItem, Me.DiscoverySurveyToolStripMenuItem, Me.IPsChangerToolStripMenuItem, Me.PingTestToolStripMenuItem, Me.RunTESTToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Image = CType(resources.GetObject("ToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'DiscoveryIPsToolStripMenuItem
        '
        Me.DiscoveryIPsToolStripMenuItem.Name = "DiscoveryIPsToolStripMenuItem"
        Me.DiscoveryIPsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DiscoveryIPsToolStripMenuItem.Text = "discovery IPs"
        '
        'DiscoverySurveyToolStripMenuItem
        '
        Me.DiscoverySurveyToolStripMenuItem.Name = "DiscoverySurveyToolStripMenuItem"
        Me.DiscoverySurveyToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DiscoverySurveyToolStripMenuItem.Text = "discovery Survey"
        '
        'IPsChangerToolStripMenuItem
        '
        Me.IPsChangerToolStripMenuItem.Name = "IPsChangerToolStripMenuItem"
        Me.IPsChangerToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.IPsChangerToolStripMenuItem.Text = "IPs Changer"
        '
        'PingTestToolStripMenuItem
        '
        Me.PingTestToolStripMenuItem.Name = "PingTestToolStripMenuItem"
        Me.PingTestToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PingTestToolStripMenuItem.Text = "Ping Test"
        '
        'RunTESTToolStripMenuItem
        '
        Me.RunTESTToolStripMenuItem.Name = "RunTESTToolStripMenuItem"
        Me.RunTESTToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RunTESTToolStripMenuItem.Text = "Run TEST"
        '
        'RebootToolStripMenuItem1
        '
        Me.RebootToolStripMenuItem1.Name = "RebootToolStripMenuItem1"
        Me.RebootToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.RebootToolStripMenuItem1.Text = "Reboot"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Image = CType(resources.GetObject("StartToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.StartToolStripMenuItem.Text = "Start Spy"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = CType(resources.GetObject("StopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.StopToolStripMenuItem.Text = "Stop Spy"
        '
        'discoveryIPs
        '
        Me.discoveryIPs.Controls.Add(Me.PanelIPTools)
        Me.discoveryIPs.Controls.Add(Me.ListIPs)
        Me.discoveryIPs.Location = New System.Drawing.Point(4, 22)
        Me.discoveryIPs.Name = "discoveryIPs"
        Me.discoveryIPs.Padding = New System.Windows.Forms.Padding(3)
        Me.discoveryIPs.Size = New System.Drawing.Size(996, 444)
        Me.discoveryIPs.TabIndex = 1
        Me.discoveryIPs.Text = "discovery IPs"
        Me.discoveryIPs.UseVisualStyleBackColor = True
        '
        'PanelIPTools
        '
        Me.PanelIPTools.BackColor = System.Drawing.Color.Transparent
        Me.PanelIPTools.Controls.Add(Me.ComboFilterIPs)
        Me.PanelIPTools.Controls.Add(Me.IPRefresh)
        Me.PanelIPTools.Controls.Add(Me.ScanIPs)
        Me.PanelIPTools.Controls.Add(Me.Label2)
        Me.PanelIPTools.Controls.Add(Me.ComboIPs)
        Me.PanelIPTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelIPTools.Location = New System.Drawing.Point(3, 3)
        Me.PanelIPTools.Name = "PanelIPTools"
        Me.PanelIPTools.Size = New System.Drawing.Size(990, 30)
        Me.PanelIPTools.TabIndex = 1
        '
        'ComboFilterIPs
        '
        Me.ComboFilterIPs.FormattingEnabled = True
        Me.ComboFilterIPs.Items.AddRange(New Object() {"All Devices", "AP", "STA"})
        Me.ComboFilterIPs.Location = New System.Drawing.Point(306, 5)
        Me.ComboFilterIPs.Name = "ComboFilterIPs"
        Me.ComboFilterIPs.Size = New System.Drawing.Size(121, 21)
        Me.ComboFilterIPs.TabIndex = 16
        Me.ComboFilterIPs.Text = "All Device"
        Me.ToolTipAll.SetToolTip(Me.ComboFilterIPs, "Filter to specific display Users (STA) or Access Point (AP)")
        '
        'IPRefresh
        '
        Me.IPRefresh.ForeColor = System.Drawing.Color.Black
        Me.IPRefresh.Location = New System.Drawing.Point(487, 5)
        Me.IPRefresh.Name = "IPRefresh"
        Me.IPRefresh.Size = New System.Drawing.Size(54, 23)
        Me.IPRefresh.TabIndex = 15
        Me.IPRefresh.Text = "Refresh"
        Me.ToolTipAll.SetToolTip(Me.IPRefresh, "Click here to get info or refresh current data")
        Me.IPRefresh.UseVisualStyleBackColor = True
        '
        'ScanIPs
        '
        Me.ScanIPs.ForeColor = System.Drawing.Color.Black
        Me.ScanIPs.Location = New System.Drawing.Point(433, 5)
        Me.ScanIPs.Name = "ScanIPs"
        Me.ScanIPs.Size = New System.Drawing.Size(48, 23)
        Me.ScanIPs.TabIndex = 14
        Me.ScanIPs.Text = "Scan"
        Me.ToolTipAll.SetToolTip(Me.ScanIPs, "Click here to make scan on UBNT Device inner AP you connected")
        Me.ScanIPs.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "IP Search From"
        '
        'ComboIPs
        '
        Me.ComboIPs.FormattingEnabled = True
        Me.ComboIPs.Location = New System.Drawing.Point(125, 4)
        Me.ComboIPs.Name = "ComboIPs"
        Me.ComboIPs.Size = New System.Drawing.Size(175, 21)
        Me.ComboIPs.TabIndex = 8
        '
        'ListIPs
        '
        Me.ListIPs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.disID, Me.disMacAddress, Me.disDeviceName, Me.disModel, Me.disSSID, Me.disProduct, Me.disFirmware, Me.disIPaddress})
        Me.ListIPs.ContextMenuStrip = Me.ContextMenuDiscovery
        Me.ListIPs.FullRowSelect = True
        Me.ListIPs.GridLines = True
        Me.ListIPs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListIPs.Location = New System.Drawing.Point(3, 35)
        Me.ListIPs.Name = "ListIPs"
        Me.ListIPs.Size = New System.Drawing.Size(990, 570)
        Me.ListIPs.TabIndex = 0
        Me.ToolTipAll.SetToolTip(Me.ListIPs, "All  UBNT devices will appear here after make scan")
        Me.ListIPs.UseCompatibleStateImageBehavior = False
        Me.ListIPs.View = System.Windows.Forms.View.Details
        '
        'disID
        '
        Me.disID.Text = "*"
        Me.disID.Width = 30
        '
        'disMacAddress
        '
        Me.disMacAddress.Text = "MAC Address"
        Me.disMacAddress.Width = 130
        '
        'disDeviceName
        '
        Me.disDeviceName.Text = "Device Name"
        Me.disDeviceName.Width = 160
        '
        'disModel
        '
        Me.disModel.Text = "Model"
        Me.disModel.Width = 50
        '
        'disSSID
        '
        Me.disSSID.Text = "SSID"
        Me.disSSID.Width = 220
        '
        'disProduct
        '
        Me.disProduct.Text = "Product"
        Me.disProduct.Width = 150
        '
        'disFirmware
        '
        Me.disFirmware.Text = "Firmware"
        '
        'disIPaddress
        '
        Me.disIPaddress.Text = "IP Address"
        Me.disIPaddress.Width = 190
        '
        'ContextMenuDiscovery
        '
        Me.ContextMenuDiscovery.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuDiscovery.Name = "ContextMenuSurvey"
        Me.ContextMenuDiscovery.Size = New System.Drawing.Size(162, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem1.Text = "Copy"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem2.Text = "Open IP Address"
        '
        'discoverySurvey
        '
        Me.discoverySurvey.Controls.Add(Me.PanelSureyTools)
        Me.discoverySurvey.Controls.Add(Me.ListSurey)
        Me.discoverySurvey.Location = New System.Drawing.Point(4, 22)
        Me.discoverySurvey.Name = "discoverySurvey"
        Me.discoverySurvey.Padding = New System.Windows.Forms.Padding(3)
        Me.discoverySurvey.Size = New System.Drawing.Size(996, 444)
        Me.discoverySurvey.TabIndex = 2
        Me.discoverySurvey.Text = "discovery Survey"
        Me.discoverySurvey.UseVisualStyleBackColor = True
        '
        'PanelSureyTools
        '
        Me.PanelSureyTools.BackColor = System.Drawing.Color.Transparent
        Me.PanelSureyTools.Controls.Add(Me.SurveyRefresh)
        Me.PanelSureyTools.Controls.Add(Me.ComboSureyRange)
        Me.PanelSureyTools.Controls.Add(Me.SureyScan)
        Me.PanelSureyTools.Controls.Add(Me.Label7)
        Me.PanelSureyTools.Controls.Add(Me.ComboIPSurvey)
        Me.PanelSureyTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSureyTools.Location = New System.Drawing.Point(3, 3)
        Me.PanelSureyTools.Name = "PanelSureyTools"
        Me.PanelSureyTools.Size = New System.Drawing.Size(990, 30)
        Me.PanelSureyTools.TabIndex = 3
        '
        'SurveyRefresh
        '
        Me.SurveyRefresh.ForeColor = System.Drawing.Color.Black
        Me.SurveyRefresh.Location = New System.Drawing.Point(537, 4)
        Me.SurveyRefresh.Name = "SurveyRefresh"
        Me.SurveyRefresh.Size = New System.Drawing.Size(55, 23)
        Me.SurveyRefresh.TabIndex = 18
        Me.SurveyRefresh.Text = "Refresh"
        Me.SurveyRefresh.UseVisualStyleBackColor = True
        '
        'ComboSureyRange
        '
        Me.ComboSureyRange.FormattingEnabled = True
        Me.ComboSureyRange.Items.AddRange(New Object() {"-10", "-20", "-30", "-40", "-50", "-60", "-70", "-80", "-90", "-100", "Other"})
        Me.ComboSureyRange.Location = New System.Drawing.Point(306, 5)
        Me.ComboSureyRange.Name = "ComboSureyRange"
        Me.ComboSureyRange.Size = New System.Drawing.Size(175, 21)
        Me.ComboSureyRange.TabIndex = 17
        Me.ComboSureyRange.Text = "Other"
        Me.ToolTipAll.SetToolTip(Me.ComboSureyRange, "Filter to specific display survey")
        '
        'SureyScan
        '
        Me.SureyScan.ForeColor = System.Drawing.Color.Black
        Me.SureyScan.Location = New System.Drawing.Point(487, 4)
        Me.SureyScan.Name = "SureyScan"
        Me.SureyScan.Size = New System.Drawing.Size(48, 23)
        Me.SureyScan.TabIndex = 15
        Me.SureyScan.Text = "Scan"
        Me.SureyScan.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Survey Search From :"
        '
        'ComboIPSurvey
        '
        Me.ComboIPSurvey.FormattingEnabled = True
        Me.ComboIPSurvey.Location = New System.Drawing.Point(125, 4)
        Me.ComboIPSurvey.Name = "ComboIPSurvey"
        Me.ComboIPSurvey.Size = New System.Drawing.Size(175, 21)
        Me.ComboIPSurvey.TabIndex = 8
        '
        'ListSurey
        '
        Me.ListSurey.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.surID, Me.SurMACAddress, Me.surSSID, Me.surDeviceName, Me.surRadioMode, Me.surEncryption, Me.surSignal, Me.surFrequency})
        Me.ListSurey.FullRowSelect = True
        Me.ListSurey.GridLines = True
        Me.ListSurey.Location = New System.Drawing.Point(6, 34)
        Me.ListSurey.Name = "ListSurey"
        Me.ListSurey.Size = New System.Drawing.Size(990, 570)
        Me.ListSurey.TabIndex = 0
        Me.ListSurey.UseCompatibleStateImageBehavior = False
        Me.ListSurey.View = System.Windows.Forms.View.Details
        '
        'surID
        '
        Me.surID.Text = "*"
        Me.surID.Width = 30
        '
        'SurMACAddress
        '
        Me.SurMACAddress.Text = "MAC Address"
        Me.SurMACAddress.Width = 160
        '
        'surSSID
        '
        Me.surSSID.Text = "SSID "
        Me.surSSID.Width = 180
        '
        'surDeviceName
        '
        Me.surDeviceName.Text = "Device Name"
        Me.surDeviceName.Width = 180
        '
        'surRadioMode
        '
        Me.surRadioMode.Text = "Radio Mode"
        Me.surRadioMode.Width = 100
        '
        'surEncryption
        '
        Me.surEncryption.Text = "Encryption"
        Me.surEncryption.Width = 80
        '
        'surSignal
        '
        Me.surSignal.Text = "Signal/Noise, dBm"
        Me.surSignal.Width = 120
        '
        'surFrequency
        '
        Me.surFrequency.Text = "Frequency GHz/Channel "
        Me.surFrequency.Width = 145
        '
        'IPsChanger
        '
        Me.IPsChanger.Controls.Add(Me.GroupBox1)
        Me.IPsChanger.Controls.Add(Me.ListChangeIPs)
        Me.IPsChanger.Location = New System.Drawing.Point(4, 22)
        Me.IPsChanger.Name = "IPsChanger"
        Me.IPsChanger.Padding = New System.Windows.Forms.Padding(3)
        Me.IPsChanger.Size = New System.Drawing.Size(996, 444)
        Me.IPsChanger.TabIndex = 3
        Me.IPsChanger.Text = "IPs Changer"
        Me.IPsChanger.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClsIPChanger)
        Me.GroupBox1.Controls.Add(Me.AddNewIP)
        Me.GroupBox1.Controls.Add(Me.StartChange)
        Me.GroupBox1.Controls.Add(Me.TextNewIP)
        Me.GroupBox1.Controls.Add(Me.TextIpGetway)
        Me.GroupBox1.Controls.Add(Me.TextIP)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(716, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'ClsIPChanger
        '
        Me.ClsIPChanger.ForeColor = System.Drawing.Color.Black
        Me.ClsIPChanger.Location = New System.Drawing.Point(83, 110)
        Me.ClsIPChanger.Name = "ClsIPChanger"
        Me.ClsIPChanger.Size = New System.Drawing.Size(38, 23)
        Me.ClsIPChanger.TabIndex = 8
        Me.ClsIPChanger.Text = "Cls"
        Me.ToolTipAll.SetToolTip(Me.ClsIPChanger, "Start Change IPs")
        Me.ClsIPChanger.UseVisualStyleBackColor = True
        '
        'AddNewIP
        '
        Me.AddNewIP.ForeColor = System.Drawing.Color.Black
        Me.AddNewIP.Location = New System.Drawing.Point(174, 110)
        Me.AddNewIP.Name = "AddNewIP"
        Me.AddNewIP.Size = New System.Drawing.Size(39, 23)
        Me.AddNewIP.TabIndex = 7
        Me.AddNewIP.Text = "Add"
        Me.AddNewIP.UseVisualStyleBackColor = True
        '
        'StartChange
        '
        Me.StartChange.ForeColor = System.Drawing.Color.Black
        Me.StartChange.Location = New System.Drawing.Point(219, 110)
        Me.StartChange.Name = "StartChange"
        Me.StartChange.Size = New System.Drawing.Size(38, 23)
        Me.StartChange.TabIndex = 6
        Me.StartChange.Text = "Start Ch"
        Me.ToolTipAll.SetToolTip(Me.StartChange, "Start Change IPs")
        Me.StartChange.UseVisualStyleBackColor = True
        '
        'TextNewIP
        '
        Me.TextNewIP.Location = New System.Drawing.Point(83, 58)
        Me.TextNewIP.Name = "TextNewIP"
        Me.TextNewIP.Size = New System.Drawing.Size(173, 20)
        Me.TextNewIP.TabIndex = 5
        '
        'TextIpGetway
        '
        Me.TextIpGetway.Location = New System.Drawing.Point(83, 84)
        Me.TextIpGetway.Name = "TextIpGetway"
        Me.TextIpGetway.Size = New System.Drawing.Size(173, 20)
        Me.TextIpGetway.TabIndex = 4
        '
        'TextIP
        '
        Me.TextIP.Location = New System.Drawing.Point(83, 33)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.Size = New System.Drawing.Size(173, 20)
        Me.TextIP.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "New Getway :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "New IP :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Current IP :"
        '
        'ListChangeIPs
        '
        Me.ListChangeIPs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChID, Me.CurrentIPaddress, Me.ChDeviceName, Me.NewIP, Me.Getway, Me.Satus})
        Me.ListChangeIPs.FullRowSelect = True
        Me.ListChangeIPs.GridLines = True
        Me.ListChangeIPs.Location = New System.Drawing.Point(5, 3)
        Me.ListChangeIPs.Name = "ListChangeIPs"
        Me.ListChangeIPs.Size = New System.Drawing.Size(705, 602)
        Me.ListChangeIPs.TabIndex = 0
        Me.ListChangeIPs.UseCompatibleStateImageBehavior = False
        Me.ListChangeIPs.View = System.Windows.Forms.View.Details
        '
        'ChID
        '
        Me.ChID.Text = "*"
        Me.ChID.Width = 30
        '
        'CurrentIPaddress
        '
        Me.CurrentIPaddress.Text = "Current IP Address"
        Me.CurrentIPaddress.Width = 120
        '
        'ChDeviceName
        '
        Me.ChDeviceName.Text = "Device Name"
        Me.ChDeviceName.Width = 120
        '
        'NewIP
        '
        Me.NewIP.Text = "New IP Address"
        Me.NewIP.Width = 120
        '
        'Getway
        '
        Me.Getway.Text = "Getway IP"
        Me.Getway.Width = 120
        '
        'Satus
        '
        Me.Satus.Text = "Satus"
        Me.Satus.Width = 120
        '
        'PingTest
        '
        Me.PingTest.Controls.Add(Me.GroupBox2)
        Me.PingTest.Controls.Add(Me.ListPing)
        Me.PingTest.Location = New System.Drawing.Point(4, 22)
        Me.PingTest.Name = "PingTest"
        Me.PingTest.Padding = New System.Windows.Forms.Padding(3)
        Me.PingTest.Size = New System.Drawing.Size(996, 444)
        Me.PingTest.TabIndex = 4
        Me.PingTest.Text = "Ping Test"
        Me.PingTest.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextPing)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.PingCounterLab)
        Me.GroupBox2.Controls.Add(Me.RefreshBringPing)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CheckAutoBringData)
        Me.GroupBox2.Controls.Add(Me.ComboIPPing)
        Me.GroupBox2.Controls.Add(Me.PingStart)
        Me.GroupBox2.Controls.Add(Me.ClearPing)
        Me.GroupBox2.Controls.Add(Me.TextPacketPing)
        Me.GroupBox2.Controls.Add(Me.TextPacketSizePing)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(717, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 230)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tools"
        '
        'TextPing
        '
        Me.TextPing.Location = New System.Drawing.Point(82, 62)
        Me.TextPing.Name = "TextPing"
        Me.TextPing.Size = New System.Drawing.Size(166, 20)
        Me.TextPing.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Ping From :"
        '
        'PingCounterLab
        '
        Me.PingCounterLab.AutoSize = True
        Me.PingCounterLab.ForeColor = System.Drawing.Color.Black
        Me.PingCounterLab.Location = New System.Drawing.Point(6, 182)
        Me.PingCounterLab.Name = "PingCounterLab"
        Me.PingCounterLab.Size = New System.Drawing.Size(31, 13)
        Me.PingCounterLab.TabIndex = 12
        Me.PingCounterLab.Text = "Ping:"
        '
        'RefreshBringPing
        '
        Me.RefreshBringPing.ForeColor = System.Drawing.Color.Black
        Me.RefreshBringPing.Location = New System.Drawing.Point(118, 177)
        Me.RefreshBringPing.Name = "RefreshBringPing"
        Me.RefreshBringPing.Size = New System.Drawing.Size(53, 23)
        Me.RefreshBringPing.TabIndex = 11
        Me.RefreshBringPing.Text = "Refresh"
        Me.RefreshBringPing.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(253, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 21)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Convert To IP"
        Me.ToolTipAll.SetToolTip(Me.Button1, "Convert To IP")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckAutoBringData
        '
        Me.CheckAutoBringData.AutoSize = True
        Me.CheckAutoBringData.Checked = True
        Me.CheckAutoBringData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckAutoBringData.ForeColor = System.Drawing.Color.Black
        Me.CheckAutoBringData.Location = New System.Drawing.Point(82, 140)
        Me.CheckAutoBringData.Name = "CheckAutoBringData"
        Me.CheckAutoBringData.Size = New System.Drawing.Size(101, 17)
        Me.CheckAutoBringData.TabIndex = 9
        Me.CheckAutoBringData.Text = "Auto Bring Data"
        Me.CheckAutoBringData.UseVisualStyleBackColor = True
        '
        'ComboIPPing
        '
        Me.ComboIPPing.FormattingEnabled = True
        Me.ComboIPPing.Location = New System.Drawing.Point(82, 33)
        Me.ComboIPPing.Name = "ComboIPPing"
        Me.ComboIPPing.Size = New System.Drawing.Size(166, 21)
        Me.ComboIPPing.TabIndex = 8
        '
        'PingStart
        '
        Me.PingStart.ForeColor = System.Drawing.Color.Black
        Me.PingStart.Location = New System.Drawing.Point(177, 177)
        Me.PingStart.Name = "PingStart"
        Me.PingStart.Size = New System.Drawing.Size(39, 23)
        Me.PingStart.TabIndex = 7
        Me.PingStart.Text = "Start"
        Me.PingStart.UseVisualStyleBackColor = True
        '
        'ClearPing
        '
        Me.ClearPing.ForeColor = System.Drawing.Color.Black
        Me.ClearPing.Location = New System.Drawing.Point(217, 177)
        Me.ClearPing.Name = "ClearPing"
        Me.ClearPing.Size = New System.Drawing.Size(49, 23)
        Me.ClearPing.TabIndex = 6
        Me.ClearPing.Text = "Clear"
        Me.ToolTipAll.SetToolTip(Me.ClearPing, "Start Change IPs")
        Me.ClearPing.UseVisualStyleBackColor = True
        '
        'TextPacketPing
        '
        Me.TextPacketPing.Location = New System.Drawing.Point(82, 88)
        Me.TextPacketPing.Name = "TextPacketPing"
        Me.TextPacketPing.Size = New System.Drawing.Size(166, 20)
        Me.TextPacketPing.TabIndex = 5
        Me.TextPacketPing.Text = "5"
        '
        'TextPacketSizePing
        '
        Me.TextPacketSizePing.Location = New System.Drawing.Point(82, 114)
        Me.TextPacketSizePing.Name = "TextPacketSizePing"
        Me.TextPacketSizePing.Size = New System.Drawing.Size(166, 20)
        Me.TextPacketSizePing.TabIndex = 4
        Me.TextPacketSizePing.Text = "56"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Packet Size:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Packet Count:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Destination IP:"
        '
        'ListPing
        '
        Me.ListPing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListPing.FullRowSelect = True
        Me.ListPing.GridLines = True
        Me.ListPing.Location = New System.Drawing.Point(6, 7)
        Me.ListPing.Name = "ListPing"
        Me.ListPing.Size = New System.Drawing.Size(705, 569)
        Me.ListPing.TabIndex = 2
        Me.ListPing.UseCompatibleStateImageBehavior = False
        Me.ListPing.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Host Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TTL"
        Me.ColumnHeader4.Width = 200
        '
        'InfoUBTN
        '
        Me.InfoUBTN.Controls.Add(Me.PictureRefreshPing)
        Me.InfoUBTN.Controls.Add(Me.TabInfo)
        Me.InfoUBTN.Controls.Add(Me.Label16)
        Me.InfoUBTN.Controls.Add(Me.GoInfo)
        Me.InfoUBTN.Controls.Add(Me.ComboIPsInfo)
        Me.InfoUBTN.Controls.Add(Me.ListInfo)
        Me.InfoUBTN.Location = New System.Drawing.Point(4, 22)
        Me.InfoUBTN.Name = "InfoUBTN"
        Me.InfoUBTN.Padding = New System.Windows.Forms.Padding(3)
        Me.InfoUBTN.Size = New System.Drawing.Size(996, 444)
        Me.InfoUBTN.TabIndex = 5
        Me.InfoUBTN.Text = "Info UBNT"
        Me.InfoUBTN.UseVisualStyleBackColor = True
        '
        'PictureRefreshPing
        '
        Me.PictureRefreshPing.Image = CType(resources.GetObject("PictureRefreshPing.Image"), System.Drawing.Image)
        Me.PictureRefreshPing.Location = New System.Drawing.Point(377, 4)
        Me.PictureRefreshPing.Name = "PictureRefreshPing"
        Me.PictureRefreshPing.Size = New System.Drawing.Size(27, 23)
        Me.PictureRefreshPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureRefreshPing.TabIndex = 3
        Me.PictureRefreshPing.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureRefreshPing, "Click to Refresh  Ubnt Device Info")
        '
        'TabInfo
        '
        Me.TabInfo.Controls.Add(Me.InfoUser)
        Me.TabInfo.Controls.Add(Me.SpeedNet)
        Me.TabInfo.Controls.Add(Me.Treceroute)
        Me.TabInfo.Location = New System.Drawing.Point(411, 30)
        Me.TabInfo.Name = "TabInfo"
        Me.TabInfo.SelectedIndex = 0
        Me.TabInfo.Size = New System.Drawing.Size(582, 380)
        Me.TabInfo.TabIndex = 10
        '
        'InfoUser
        '
        Me.InfoUser.Controls.Add(Me.Label20)
        Me.InfoUser.Controls.Add(Me.LabAP)
        Me.InfoUser.Controls.Add(Me.LabProduct)
        Me.InfoUser.Controls.Add(Me.LabIPaddress)
        Me.InfoUser.Controls.Add(Me.LabDeviceName)
        Me.InfoUser.Controls.Add(Me.PictureNanoType)
        Me.InfoUser.Controls.Add(Me.ChartMemory)
        Me.InfoUser.Controls.Add(Me.LabelMemory)
        Me.InfoUser.Controls.Add(Me.LabelCPU)
        Me.InfoUser.Controls.Add(Me.ChartCPU)
        Me.InfoUser.Location = New System.Drawing.Point(4, 22)
        Me.InfoUser.Name = "InfoUser"
        Me.InfoUser.Padding = New System.Windows.Forms.Padding(3)
        Me.InfoUser.Size = New System.Drawing.Size(574, 354)
        Me.InfoUser.TabIndex = 0
        Me.InfoUser.Text = "Info User"
        Me.InfoUser.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "User Information :"
        '
        'LabAP
        '
        Me.LabAP.AutoSize = True
        Me.LabAP.ForeColor = System.Drawing.Color.Black
        Me.LabAP.Location = New System.Drawing.Point(119, 108)
        Me.LabAP.Name = "LabAP"
        Me.LabAP.Size = New System.Drawing.Size(53, 13)
        Me.LabAP.TabIndex = 18
        Me.LabAP.Text = "AP MAC :"
        Me.LabAP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabProduct
        '
        Me.LabProduct.AutoSize = True
        Me.LabProduct.ForeColor = System.Drawing.Color.Black
        Me.LabProduct.Location = New System.Drawing.Point(119, 80)
        Me.LabProduct.Name = "LabProduct"
        Me.LabProduct.Size = New System.Drawing.Size(50, 13)
        Me.LabProduct.TabIndex = 17
        Me.LabProduct.Text = "Product :"
        '
        'LabIPaddress
        '
        Me.LabIPaddress.AutoSize = True
        Me.LabIPaddress.ForeColor = System.Drawing.Color.Black
        Me.LabIPaddress.Location = New System.Drawing.Point(119, 56)
        Me.LabIPaddress.Name = "LabIPaddress"
        Me.LabIPaddress.Size = New System.Drawing.Size(61, 13)
        Me.LabIPaddress.TabIndex = 16
        Me.LabIPaddress.Text = "IP Address:"
        '
        'LabDeviceName
        '
        Me.LabDeviceName.AutoSize = True
        Me.LabDeviceName.ForeColor = System.Drawing.Color.Black
        Me.LabDeviceName.Location = New System.Drawing.Point(119, 28)
        Me.LabDeviceName.Name = "LabDeviceName"
        Me.LabDeviceName.Size = New System.Drawing.Size(81, 13)
        Me.LabDeviceName.TabIndex = 15
        Me.LabDeviceName.Text = "Device Name : "
        '
        'PictureNanoType
        '
        Me.PictureNanoType.Image = CType(resources.GetObject("PictureNanoType.Image"), System.Drawing.Image)
        Me.PictureNanoType.Location = New System.Drawing.Point(8, 22)
        Me.PictureNanoType.Name = "PictureNanoType"
        Me.PictureNanoType.Size = New System.Drawing.Size(107, 109)
        Me.PictureNanoType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNanoType.TabIndex = 14
        Me.PictureNanoType.TabStop = False
        '
        'ChartMemory
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartMemory.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.ChartMemory.Legends.Add(Legend1)
        Me.ChartMemory.Location = New System.Drawing.Point(376, 163)
        Me.ChartMemory.Name = "ChartMemory"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Used"
        Me.ChartMemory.Series.Add(Series1)
        Me.ChartMemory.Size = New System.Drawing.Size(192, 138)
        Me.ChartMemory.TabIndex = 13
        Me.ChartMemory.Text = "Chart1"
        '
        'LabelMemory
        '
        Me.LabelMemory.AutoSize = True
        Me.LabelMemory.ForeColor = System.Drawing.Color.Black
        Me.LabelMemory.Location = New System.Drawing.Point(456, 304)
        Me.LabelMemory.Name = "LabelMemory"
        Me.LabelMemory.Size = New System.Drawing.Size(44, 13)
        Me.LabelMemory.TabIndex = 12
        Me.LabelMemory.Text = "Memory"
        '
        'LabelCPU
        '
        Me.LabelCPU.AutoSize = True
        Me.LabelCPU.ForeColor = System.Drawing.Color.Black
        Me.LabelCPU.Location = New System.Drawing.Point(456, 147)
        Me.LabelCPU.Name = "LabelCPU"
        Me.LabelCPU.Size = New System.Drawing.Size(29, 13)
        Me.LabelCPU.TabIndex = 10
        Me.LabelCPU.Text = "CPU"
        '
        'ChartCPU
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartCPU.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend2.Name = "Legend1"
        Me.ChartCPU.Legends.Add(Legend2)
        Me.ChartCPU.Location = New System.Drawing.Point(374, 6)
        Me.ChartCPU.Name = "ChartCPU"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartCPU.Series.Add(Series2)
        Me.ChartCPU.Size = New System.Drawing.Size(192, 138)
        Me.ChartCPU.TabIndex = 7
        Me.ChartCPU.Text = "Chart1"
        '
        'SpeedNet
        '
        Me.SpeedNet.Controls.Add(Me.LabTotal)
        Me.SpeedNet.Controls.Add(Me.LabRX)
        Me.SpeedNet.Controls.Add(Me.LabTX)
        Me.SpeedNet.Controls.Add(Me.Label13)
        Me.SpeedNet.Controls.Add(Me.ChartSpeedTest)
        Me.SpeedNet.Controls.Add(Me.SpeedTestGo)
        Me.SpeedNet.Location = New System.Drawing.Point(4, 22)
        Me.SpeedNet.Name = "SpeedNet"
        Me.SpeedNet.Padding = New System.Windows.Forms.Padding(3)
        Me.SpeedNet.Size = New System.Drawing.Size(574, 354)
        Me.SpeedNet.TabIndex = 1
        Me.SpeedNet.Text = "Speed Net"
        Me.SpeedNet.UseVisualStyleBackColor = True
        '
        'LabTotal
        '
        Me.LabTotal.AutoSize = True
        Me.LabTotal.ForeColor = System.Drawing.Color.Black
        Me.LabTotal.Location = New System.Drawing.Point(47, 326)
        Me.LabTotal.Name = "LabTotal"
        Me.LabTotal.Size = New System.Drawing.Size(34, 13)
        Me.LabTotal.TabIndex = 24
        Me.LabTotal.Text = "Total:"
        '
        'LabRX
        '
        Me.LabRX.AutoSize = True
        Me.LabRX.ForeColor = System.Drawing.Color.Black
        Me.LabRX.Location = New System.Drawing.Point(47, 308)
        Me.LabRX.Name = "LabRX"
        Me.LabRX.Size = New System.Drawing.Size(82, 13)
        Me.LabRX.TabIndex = 23
        Me.LabRX.Text = "RX (Download):"
        '
        'LabTX
        '
        Me.LabTX.AutoSize = True
        Me.LabTX.ForeColor = System.Drawing.Color.Black
        Me.LabTX.Location = New System.Drawing.Point(47, 291)
        Me.LabTX.Name = "LabTX"
        Me.LabTX.Size = New System.Drawing.Size(67, 13)
        Me.LabTX.TabIndex = 22
        Me.LabTX.Text = "TX (Upload):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Result Speed : "
        '
        'ChartSpeedTest
        '
        ChartArea3.Name = "ChartArea1"
        Me.ChartSpeedTest.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Legend4.Enabled = False
        Legend4.Name = "Legend2"
        Me.ChartSpeedTest.Legends.Add(Legend3)
        Me.ChartSpeedTest.Legends.Add(Legend4)
        Me.ChartSpeedTest.Location = New System.Drawing.Point(20, 32)
        Me.ChartSpeedTest.Name = "ChartSpeedTest"
        Series3.BackSecondaryColor = System.Drawing.Color.White
        Series3.ChartArea = "ChartArea1"
        Series3.CustomProperties = "PointWidth=0.6"
        Series3.Legend = "Legend1"
        Series3.LegendToolTip = "TX Rate"
        Series3.MarkerSize = 3
        Series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series3.Name = "Upload"
        Series3.Points.Add(DataPoint1)
        Series3.ShadowOffset = 2
        Series3.SmartLabelStyle.MinMovingDistance = 1.0R
        Series3.ToolTip = "#VAL{D}"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend2"
        Series4.Name = "Series4"
        Series4.Points.Add(DataPoint2)
        Series4.ShadowOffset = 2
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.LegendToolTip = "#VAL{D}"
        Series5.Name = "Download"
        Series5.Points.Add(DataPoint3)
        Series5.ShadowOffset = 2
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend2"
        Series6.Name = "Series5"
        Series6.Points.Add(DataPoint4)
        Series6.ShadowOffset = 2
        Series7.ChartArea = "ChartArea1"
        Series7.CustomProperties = "PointWidth=0.6"
        Series7.Legend = "Legend1"
        Series7.LegendToolTip = "Total"
        Series7.MarkerSize = 3
        Series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle
        Series7.Name = "Total"
        Series7.Points.Add(DataPoint5)
        Series7.ShadowOffset = 2
        Series7.SmartLabelStyle.MinMovingDistance = 1.0R
        Series7.ToolTip = "#VAL{D}"
        Me.ChartSpeedTest.Series.Add(Series3)
        Me.ChartSpeedTest.Series.Add(Series4)
        Me.ChartSpeedTest.Series.Add(Series5)
        Me.ChartSpeedTest.Series.Add(Series6)
        Me.ChartSpeedTest.Series.Add(Series7)
        Me.ChartSpeedTest.Size = New System.Drawing.Size(537, 272)
        Me.ChartSpeedTest.TabIndex = 20
        Me.ChartSpeedTest.Text = "Data"
        '
        'SpeedTestGo
        '
        Me.SpeedTestGo.ForeColor = System.Drawing.Color.Black
        Me.SpeedTestGo.Location = New System.Drawing.Point(519, 310)
        Me.SpeedTestGo.Name = "SpeedTestGo"
        Me.SpeedTestGo.Size = New System.Drawing.Size(35, 23)
        Me.SpeedTestGo.TabIndex = 11
        Me.SpeedTestGo.Text = "Go!"
        Me.ToolTipAll.SetToolTip(Me.SpeedTestGo, "Click  to make SpeedTest on IP selected .")
        Me.SpeedTestGo.UseVisualStyleBackColor = True
        '
        'Treceroute
        '
        Me.Treceroute.Controls.Add(Me.TextHost)
        Me.Treceroute.Controls.Add(Me.GoTraceroute)
        Me.Treceroute.Controls.Add(Me.Label17)
        Me.Treceroute.Controls.Add(Me.ListTaceroute)
        Me.Treceroute.Location = New System.Drawing.Point(4, 22)
        Me.Treceroute.Name = "Treceroute"
        Me.Treceroute.Size = New System.Drawing.Size(574, 354)
        Me.Treceroute.TabIndex = 2
        Me.Treceroute.Text = "Traceroute"
        Me.Treceroute.UseVisualStyleBackColor = True
        '
        'TextHost
        '
        Me.TextHost.Location = New System.Drawing.Point(39, 5)
        Me.TextHost.Name = "TextHost"
        Me.TextHost.Size = New System.Drawing.Size(161, 20)
        Me.TextHost.TabIndex = 18
        Me.TextHost.Text = "8.8.8.8"
        Me.TextHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GoTraceroute
        '
        Me.GoTraceroute.ForeColor = System.Drawing.Color.Black
        Me.GoTraceroute.Location = New System.Drawing.Point(523, 6)
        Me.GoTraceroute.Name = "GoTraceroute"
        Me.GoTraceroute.Size = New System.Drawing.Size(45, 20)
        Me.GoTraceroute.TabIndex = 17
        Me.GoTraceroute.Text = "Go!"
        Me.ToolTipAll.SetToolTip(Me.GoTraceroute, "Click to Make traceroute scan")
        Me.GoTraceroute.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(3, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Host :"
        '
        'ListTaceroute
        '
        Me.ListTaceroute.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListTaceroute.FullRowSelect = True
        Me.ListTaceroute.GridLines = True
        Me.ListTaceroute.Location = New System.Drawing.Point(3, 29)
        Me.ListTaceroute.Name = "ListTaceroute"
        Me.ListTaceroute.Size = New System.Drawing.Size(568, 323)
        Me.ListTaceroute.TabIndex = 0
        Me.ListTaceroute.UseCompatibleStateImageBehavior = False
        Me.ListTaceroute.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "*"
        Me.ColumnHeader5.Width = 30
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Host"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Result"
        Me.ColumnHeader7.Width = 240
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(37, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "IP address"
        '
        'GoInfo
        '
        Me.GoInfo.ForeColor = System.Drawing.Color.Black
        Me.GoInfo.Location = New System.Drawing.Point(308, 4)
        Me.GoInfo.Name = "GoInfo"
        Me.GoInfo.Size = New System.Drawing.Size(36, 23)
        Me.GoInfo.TabIndex = 8
        Me.GoInfo.Text = "Go!"
        Me.GoInfo.UseVisualStyleBackColor = True
        '
        'ComboIPsInfo
        '
        Me.ComboIPsInfo.FormattingEnabled = True
        Me.ComboIPsInfo.Location = New System.Drawing.Point(103, 6)
        Me.ComboIPsInfo.Name = "ComboIPsInfo"
        Me.ComboIPsInfo.Size = New System.Drawing.Size(199, 21)
        Me.ComboIPsInfo.TabIndex = 7
        Me.ToolTipAll.SetToolTip(Me.ComboIPsInfo, "Select IP when you want make Get AP or Speed test or traceroute")
        '
        'ListInfo
        '
        Me.ListInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdInfo, Me.NameProperties, Me.PropertiesValue})
        Me.ListInfo.FullRowSelect = True
        Me.ListInfo.GridLines = True
        Me.ListInfo.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17})
        Me.ListInfo.Location = New System.Drawing.Point(7, 30)
        Me.ListInfo.Name = "ListInfo"
        Me.ListInfo.Size = New System.Drawing.Size(397, 379)
        Me.ListInfo.TabIndex = 0
        Me.ListInfo.UseCompatibleStateImageBehavior = False
        Me.ListInfo.View = System.Windows.Forms.View.Details
        '
        'IdInfo
        '
        Me.IdInfo.Text = "*"
        Me.IdInfo.Width = 30
        '
        'NameProperties
        '
        Me.NameProperties.Text = "Name Properties"
        Me.NameProperties.Width = 180
        '
        'PropertiesValue
        '
        Me.PropertiesValue.Text = "Value"
        Me.PropertiesValue.Width = 180
        '
        'IPAddress
        '
        Me.IPAddress.DisplayIndex = 0
        Me.IPAddress.Text = "IP Address"
        Me.IPAddress.Width = 120
        '
        'DeviceName
        '
        Me.DeviceName.DisplayIndex = 1
        Me.DeviceName.Text = "Device Name"
        Me.DeviceName.Width = 120
        '
        'SignalStrength
        '
        Me.SignalStrength.DisplayIndex = 2
        Me.SignalStrength.Text = "Signal Strength"
        Me.SignalStrength.Width = 120
        '
        'NoiseFloor
        '
        Me.NoiseFloor.DisplayIndex = 3
        Me.NoiseFloor.Text = "Noise Floor"
        Me.NoiseFloor.Width = 120
        '
        'TransmitCCQ
        '
        Me.TransmitCCQ.DisplayIndex = 4
        Me.TransmitCCQ.Text = "Transmit CCQ"
        Me.TransmitCCQ.Width = 120
        '
        'TXRXRate
        '
        Me.TXRXRate.DisplayIndex = 5
        Me.TXRXRate.Text = "TX/RX Rate"
        Me.TXRXRate.Width = 120
        '
        'APMAC
        '
        Me.APMAC.DisplayIndex = 6
        Me.APMAC.Text = "AP MAC"
        Me.APMAC.Width = 120
        '
        'Distance
        '
        Me.Distance.DisplayIndex = 7
        Me.Distance.Text = "Distance"
        Me.Distance.Width = 103
        '
        'DeviceModel
        '
        Me.DeviceModel.DisplayIndex = 8
        Me.DeviceModel.Text = "Device Model"
        Me.DeviceModel.Width = 130
        '
        'Version
        '
        Me.Version.DisplayIndex = 9
        Me.Version.Text = "Version"
        Me.Version.Width = 120
        '
        'Uername
        '
        Me.Uername.DisplayIndex = 10
        Me.Uername.Text = "Uername"
        Me.Uername.Width = 120
        '
        'Password
        '
        Me.Password.DisplayIndex = 11
        Me.Password.Text = "Password"
        Me.Password.Width = 120
        '
        'PictureAdd
        '
        Me.PictureAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureAdd.Image = CType(resources.GetObject("PictureAdd.Image"), System.Drawing.Image)
        Me.PictureAdd.Location = New System.Drawing.Point(1261, 27)
        Me.PictureAdd.Name = "PictureAdd"
        Me.PictureAdd.Size = New System.Drawing.Size(15, 15)
        Me.PictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureAdd.TabIndex = 5
        Me.PictureAdd.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureAdd, "Click to Add User")
        '
        'PictureRemove
        '
        Me.PictureRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureRemove.Image = CType(resources.GetObject("PictureRemove.Image"), System.Drawing.Image)
        Me.PictureRemove.Location = New System.Drawing.Point(1239, 27)
        Me.PictureRemove.Name = "PictureRemove"
        Me.PictureRemove.Size = New System.Drawing.Size(15, 15)
        Me.PictureRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureRemove.TabIndex = 6
        Me.PictureRemove.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureRemove, "Click to Romove Item")
        '
        'PictureStart
        '
        Me.PictureStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureStart.Image = CType(resources.GetObject("PictureStart.Image"), System.Drawing.Image)
        Me.PictureStart.Location = New System.Drawing.Point(1196, 27)
        Me.PictureStart.Name = "PictureStart"
        Me.PictureStart.Size = New System.Drawing.Size(15, 15)
        Me.PictureStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureStart.TabIndex = 7
        Me.PictureStart.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureStart, "Click to Start Spy Users")
        '
        'PictureStop
        '
        Me.PictureStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureStop.Image = CType(resources.GetObject("PictureStop.Image"), System.Drawing.Image)
        Me.PictureStop.Location = New System.Drawing.Point(1216, 27)
        Me.PictureStop.Name = "PictureStop"
        Me.PictureStop.Size = New System.Drawing.Size(15, 15)
        Me.PictureStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureStop.TabIndex = 8
        Me.PictureStop.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureStop, "Click to Stop Spy Users")
        '
        'Moniter
        '
        Me.Moniter.BackColor = System.Drawing.SystemColors.Window
        Me.Moniter.Location = New System.Drawing.Point(4, 22)
        Me.Moniter.Name = "Moniter"
        Me.Moniter.Padding = New System.Windows.Forms.Padding(3)
        Me.Moniter.Size = New System.Drawing.Size(996, 166)
        Me.Moniter.TabIndex = 0
        Me.Moniter.Text = "MONITER"
        '
        'TabChart
        '
        Me.TabChart.Controls.Add(Me.Moniter)
        Me.TabChart.Location = New System.Drawing.Point(280, 469)
        Me.TabChart.Name = "TabChart"
        Me.TabChart.SelectedIndex = 0
        Me.TabChart.Size = New System.Drawing.Size(1004, 192)
        Me.TabChart.TabIndex = 2
        Me.ToolTipAll.SetToolTip(Me.TabChart, "TX ( Upload ) and RX ( Download ) Chart  will appear when you select any IP")
        '
        'ToolTipAll
        '
        Me.ToolTipAll.IsBalloon = True
        Me.ToolTipAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipAll.ToolTipTitle = "Tip:"
        '
        'PictureCreate
        '
        Me.PictureCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureCreate.Image = CType(resources.GetObject("PictureCreate.Image"), System.Drawing.Image)
        Me.PictureCreate.Location = New System.Drawing.Point(1176, 27)
        Me.PictureCreate.Name = "PictureCreate"
        Me.PictureCreate.Size = New System.Drawing.Size(15, 15)
        Me.PictureCreate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureCreate.TabIndex = 9
        Me.PictureCreate.TabStop = False
        Me.ToolTipAll.SetToolTip(Me.PictureCreate, "Click to Create IPs")
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1284, 680)
        Me.Controls.Add(Me.PictureCreate)
        Me.Controls.Add(Me.TabChart)
        Me.Controls.Add(Me.PictureStop)
        Me.Controls.Add(Me.PictureStart)
        Me.Controls.Add(Me.PictureRemove)
        Me.Controls.Add(Me.PictureAdd)
        Me.Controls.Add(Me.TabContainer)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.ToolsPanel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Ubnt Device Manger"
        Me.ToolsPanel.ResumeLayout(False)
        Me.PanelNavbarBottom.ResumeLayout(False)
        CType(Me.PictureSeetingConsole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTools.ResumeLayout(False)
        Me.Tools.ResumeLayout(False)
        Me.Rocket.ResumeLayout(False)
        CType(Me.PictureRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuSurvey.ResumeLayout(False)
        Me.TabConsole.ResumeLayout(False)
        Me.Console.ResumeLayout(False)
        Me.ContextMenuConsole.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.PictureAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabContainer.ResumeLayout(False)
        Me.SpyPage.ResumeLayout(False)
        Me.ContextMenuSpyUsers.ResumeLayout(False)
        Me.discoveryIPs.ResumeLayout(False)
        Me.PanelIPTools.ResumeLayout(False)
        Me.PanelIPTools.PerformLayout()
        Me.ContextMenuDiscovery.ResumeLayout(False)
        Me.discoverySurvey.ResumeLayout(False)
        Me.PanelSureyTools.ResumeLayout(False)
        Me.PanelSureyTools.PerformLayout()
        Me.IPsChanger.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PingTest.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.InfoUBTN.ResumeLayout(False)
        Me.InfoUBTN.PerformLayout()
        CType(Me.PictureRefreshPing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInfo.ResumeLayout(False)
        Me.InfoUser.ResumeLayout(False)
        Me.InfoUser.PerformLayout()
        CType(Me.PictureNanoType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartMemory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpeedNet.ResumeLayout(False)
        Me.SpeedNet.PerformLayout()
        CType(Me.ChartSpeedTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Treceroute.ResumeLayout(False)
        Me.Treceroute.PerformLayout()
        CType(Me.PictureAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChart.ResumeLayout(False)
        CType(Me.PictureCreate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolsPanel As System.Windows.Forms.Panel
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents TabConsole As System.Windows.Forms.TabControl
    Friend WithEvents Console As System.Windows.Forms.TabPage
    Friend WithEvents TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents TabContainer As System.Windows.Forms.TabControl
    Friend WithEvents ErrorType As System.Windows.Forms.ColumnHeader
    Friend WithEvents IP As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabTools As System.Windows.Forms.TabControl
    Friend WithEvents Tools As System.Windows.Forms.TabPage
    Friend WithEvents Rocket As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents TreeSurvey As System.Windows.Forms.TreeView
    Friend WithEvents PictureRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents SpyPage As System.Windows.Forms.TabPage
    Friend WithEvents ListSpy As System.Windows.Forms.ListView
    Friend WithEvents IPAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents SignalStrength As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoiseFloor As System.Windows.Forms.ColumnHeader
    Friend WithEvents TransmitCCQ As System.Windows.Forms.ColumnHeader
    Friend WithEvents TXRXRate As System.Windows.Forms.ColumnHeader
    Friend WithEvents APMAC As System.Windows.Forms.ColumnHeader
    Friend WithEvents Distance As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceModel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Version As System.Windows.Forms.ColumnHeader
    Friend WithEvents Uername As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents IPsAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents DevicesName As System.Windows.Forms.ColumnHeader
    Friend WithEvents DevicesModel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Versions As System.Windows.Forms.ColumnHeader
    Friend WithEvents Distances As System.Windows.Forms.ColumnHeader
    Friend WithEvents Signal_Strength As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoiseFloors As System.Windows.Forms.ColumnHeader
    Friend WithEvents Transmit_CCQ As System.Windows.Forms.ColumnHeader
    Friend WithEvents TXRX_Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents APsMAC As System.Windows.Forms.ColumnHeader
    Friend WithEvents SSID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Passwords As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureRemove As System.Windows.Forms.PictureBox
    Friend WithEvents TreeNavbar As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents discoveryIPs As System.Windows.Forms.TabPage
    Friend WithEvents discoverySurvey As System.Windows.Forms.TabPage
    Friend WithEvents IPsChanger As System.Windows.Forms.TabPage
    Friend WithEvents PingTest As System.Windows.Forms.TabPage
    Friend WithEvents PictureStart As System.Windows.Forms.PictureBox
    Friend WithEvents PictureStop As System.Windows.Forms.PictureBox
    Friend WithEvents PanelNavbarBottom As System.Windows.Forms.Panel
    Friend WithEvents Moniter As System.Windows.Forms.TabPage
    Friend WithEvents TabChart As System.Windows.Forms.TabControl
    Public WithEvents ListConsole As System.Windows.Forms.ListView
    Friend WithEvents PictureSound As System.Windows.Forms.PictureBox
    Friend WithEvents Selector As System.Windows.Forms.Label
    Friend WithEvents ContextMenuSpyUsers As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IPAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviceNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscoveryIPsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscoverySurveyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IPsChangerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuConsole As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenIPAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FixToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingTestToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSurveyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyIPAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListIPs As System.Windows.Forms.ListView
    Friend WithEvents disMacAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents disDeviceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents disModel As System.Windows.Forms.ColumnHeader
    Friend WithEvents disSSID As System.Windows.Forms.ColumnHeader
    Friend WithEvents disProduct As System.Windows.Forms.ColumnHeader
    Friend WithEvents disFirmware As System.Windows.Forms.ColumnHeader
    Friend WithEvents disIPaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureSeetingConsole As System.Windows.Forms.PictureBox
    Friend WithEvents ListSurey As System.Windows.Forms.ListView
    Friend WithEvents surID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SurMACAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents surSSID As System.Windows.Forms.ColumnHeader
    Friend WithEvents surDeviceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents surRadioMode As System.Windows.Forms.ColumnHeader
    Friend WithEvents surEncryption As System.Windows.Forms.ColumnHeader
    Friend WithEvents surSignal As System.Windows.Forms.ColumnHeader
    Friend WithEvents surFrequency As System.Windows.Forms.ColumnHeader
    Friend WithEvents disID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MianID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTipAll As System.Windows.Forms.ToolTip
    Friend WithEvents PictureCreate As System.Windows.Forms.PictureBox
    Friend WithEvents PictureAbout As System.Windows.Forms.PictureBox
    Friend WithEvents PanelIPTools As System.Windows.Forms.Panel
    Friend WithEvents ScanIPs As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboIPs As System.Windows.Forms.ComboBox
    Friend WithEvents PanelSureyTools As System.Windows.Forms.Panel
    Friend WithEvents ComboSureyRange As System.Windows.Forms.ComboBox
    Friend WithEvents SureyScan As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboIPSurvey As System.Windows.Forms.ComboBox
    Friend WithEvents ListChangeIPs As System.Windows.Forms.ListView
    Friend WithEvents ChID As System.Windows.Forms.ColumnHeader
    Friend WithEvents CurrentIPaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChDeviceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Getway As System.Windows.Forms.ColumnHeader
    Friend WithEvents Satus As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddNewIP As System.Windows.Forms.Button
    Friend WithEvents StartChange As System.Windows.Forms.Button
    Friend WithEvents TextNewIP As System.Windows.Forms.TextBox
    Friend WithEvents TextIpGetway As System.Windows.Forms.TextBox
    Friend WithEvents TextIP As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PingStart As System.Windows.Forms.Button
    Friend WithEvents ClearPing As System.Windows.Forms.Button
    Friend WithEvents TextPacketPing As System.Windows.Forms.TextBox
    Friend WithEvents TextPacketSizePing As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ListPing As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SurveyRefresh As System.Windows.Forms.Button
    Friend WithEvents IPRefresh As System.Windows.Forms.Button
    Friend WithEvents ComboIPPing As System.Windows.Forms.ComboBox
    Friend WithEvents ComboFilterIPs As System.Windows.Forms.ComboBox
    Friend WithEvents ComboTreeSurvey As System.Windows.Forms.ComboBox
    Friend WithEvents ReadyPro As System.Windows.Forms.Label
    Friend WithEvents InfoUBTN As System.Windows.Forms.TabPage
    Friend WithEvents ListInfo As System.Windows.Forms.ListView
    Friend WithEvents IdInfo As System.Windows.Forms.ColumnHeader
    Friend WithEvents NameProperties As System.Windows.Forms.ColumnHeader
    Friend WithEvents PropertiesValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GoInfo As System.Windows.Forms.Button
    Friend WithEvents ComboIPsInfo As System.Windows.Forms.ComboBox
    Friend WithEvents TabInfo As System.Windows.Forms.TabControl
    Friend WithEvents InfoUser As System.Windows.Forms.TabPage
    Friend WithEvents ChartMemory As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LabelMemory As System.Windows.Forms.Label
    Friend WithEvents LabelCPU As System.Windows.Forms.Label
    Friend WithEvents ChartCPU As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents SpeedNet As System.Windows.Forms.TabPage
    Friend WithEvents Treceroute As System.Windows.Forms.TabPage
    Friend WithEvents LabDeviceName As System.Windows.Forms.Label
    Friend WithEvents PictureNanoType As System.Windows.Forms.PictureBox
    Friend WithEvents LabProduct As System.Windows.Forms.Label
    Friend WithEvents LabIPaddress As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabAP As System.Windows.Forms.Label
    Friend WithEvents SpeedTestGo As System.Windows.Forms.Button
    Friend WithEvents ListTaceroute As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckAutoBringData As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RefreshBringPing As System.Windows.Forms.Button
    Friend WithEvents PictureRefreshPing As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChartSpeedTest As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PingCounterLab As System.Windows.Forms.Label
    Friend WithEvents ClsIPChanger As System.Windows.Forms.Button
    Friend WithEvents GoTraceroute As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RunTESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextHost As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuSurvey As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenIPAddressToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabTotal As System.Windows.Forms.Label
    Friend WithEvents LabRX As System.Windows.Forms.Label
    Friend WithEvents LabTX As System.Windows.Forms.Label
    Friend WithEvents TextPing As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuDiscovery As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusCol As System.Windows.Forms.ColumnHeader
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
