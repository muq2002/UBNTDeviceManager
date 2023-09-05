<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Serverdiscovery
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
        Me.WebIP = New System.Windows.Forms.WebBrowser()
        Me.WebSurvey = New System.Windows.Forms.WebBrowser()
        Me.WebPing = New System.Windows.Forms.WebBrowser()
        Me.WebChangeIP = New System.Windows.Forms.WebBrowser()
        Me.WebReboot = New System.Windows.Forms.WebBrowser()
        Me.WebAPInfo = New System.Windows.Forms.WebBrowser()
        Me.WebSpeed = New System.Windows.Forms.WebBrowser()
        Me.WebTraceroute = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebIP
        '
        Me.WebIP.Location = New System.Drawing.Point(13, 13)
        Me.WebIP.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebIP.Name = "WebIP"
        Me.WebIP.Size = New System.Drawing.Size(472, 408)
        Me.WebIP.TabIndex = 0
        '
        'WebSurvey
        '
        Me.WebSurvey.Location = New System.Drawing.Point(500, 12)
        Me.WebSurvey.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebSurvey.Name = "WebSurvey"
        Me.WebSurvey.Size = New System.Drawing.Size(472, 408)
        Me.WebSurvey.TabIndex = 1
        '
        'WebPing
        '
        Me.WebPing.Location = New System.Drawing.Point(12, 427)
        Me.WebPing.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebPing.Name = "WebPing"
        Me.WebPing.Size = New System.Drawing.Size(472, 408)
        Me.WebPing.TabIndex = 2
        '
        'WebChangeIP
        '
        Me.WebChangeIP.Location = New System.Drawing.Point(500, 426)
        Me.WebChangeIP.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebChangeIP.Name = "WebChangeIP"
        Me.WebChangeIP.Size = New System.Drawing.Size(472, 408)
        Me.WebChangeIP.TabIndex = 3
        '
        'WebReboot
        '
        Me.WebReboot.Location = New System.Drawing.Point(985, 12)
        Me.WebReboot.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebReboot.Name = "WebReboot"
        Me.WebReboot.Size = New System.Drawing.Size(472, 408)
        Me.WebReboot.TabIndex = 4
        '
        'WebAPInfo
        '
        Me.WebAPInfo.Location = New System.Drawing.Point(985, 427)
        Me.WebAPInfo.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebAPInfo.Name = "WebAPInfo"
        Me.WebAPInfo.Size = New System.Drawing.Size(472, 408)
        Me.WebAPInfo.TabIndex = 5
        '
        'WebSpeed
        '
        Me.WebSpeed.Location = New System.Drawing.Point(1477, 432)
        Me.WebSpeed.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebSpeed.Name = "WebSpeed"
        Me.WebSpeed.Size = New System.Drawing.Size(472, 408)
        Me.WebSpeed.TabIndex = 6
        '
        'WebTraceroute
        '
        Me.WebTraceroute.Location = New System.Drawing.Point(1477, 18)
        Me.WebTraceroute.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebTraceroute.Name = "WebTraceroute"
        Me.WebTraceroute.Size = New System.Drawing.Size(472, 408)
        Me.WebTraceroute.TabIndex = 7
        '
        'Serverdiscovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.WebTraceroute)
        Me.Controls.Add(Me.WebSpeed)
        Me.Controls.Add(Me.WebAPInfo)
        Me.Controls.Add(Me.WebReboot)
        Me.Controls.Add(Me.WebChangeIP)
        Me.Controls.Add(Me.WebPing)
        Me.Controls.Add(Me.WebSurvey)
        Me.Controls.Add(Me.WebIP)
        Me.Name = "Serverdiscovery"
        Me.Text = "Serverdiscovery"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebIP As System.Windows.Forms.WebBrowser
    Friend WithEvents WebSurvey As System.Windows.Forms.WebBrowser
    Friend WithEvents WebPing As System.Windows.Forms.WebBrowser
    Friend WithEvents WebChangeIP As System.Windows.Forms.WebBrowser
    Friend WithEvents WebReboot As System.Windows.Forms.WebBrowser
    Friend WithEvents WebAPInfo As System.Windows.Forms.WebBrowser
    Friend WithEvents WebSpeed As System.Windows.Forms.WebBrowser
    Friend WithEvents WebTraceroute As System.Windows.Forms.WebBrowser
End Class
