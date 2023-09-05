<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerOpen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerOpen))
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.PictureClose = New System.Windows.Forms.PictureBox()
        Me.PictureMinimize = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Web1 = New System.Windows.Forms.WebBrowser()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanelTitle.Controls.Add(Me.PictureLogo)
        Me.PanelTitle.Controls.Add(Me.PictureClose)
        Me.PanelTitle.Controls.Add(Me.PictureMinimize)
        Me.PanelTitle.Controls.Add(Me.Title)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1200, 23)
        Me.PanelTitle.TabIndex = 0
        '
        'PictureLogo
        '
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(3, 0)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(31, 23)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 4
        Me.PictureLogo.TabStop = False
        '
        'PictureClose
        '
        Me.PictureClose.Image = CType(resources.GetObject("PictureClose.Image"), System.Drawing.Image)
        Me.PictureClose.Location = New System.Drawing.Point(1177, 0)
        Me.PictureClose.Name = "PictureClose"
        Me.PictureClose.Size = New System.Drawing.Size(23, 23)
        Me.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureClose.TabIndex = 3
        Me.PictureClose.TabStop = False
        '
        'PictureMinimize
        '
        Me.PictureMinimize.Image = CType(resources.GetObject("PictureMinimize.Image"), System.Drawing.Image)
        Me.PictureMinimize.Location = New System.Drawing.Point(1154, 0)
        Me.PictureMinimize.Name = "PictureMinimize"
        Me.PictureMinimize.Size = New System.Drawing.Size(23, 23)
        Me.PictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureMinimize.TabIndex = 4
        Me.PictureMinimize.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(38, 7)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(65, 13)
        Me.Title.TabIndex = 0
        Me.Title.Text = "OpenWeb : "
        '
        'Web1
        '
        Me.Web1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Web1.Location = New System.Drawing.Point(0, 23)
        Me.Web1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web1.Name = "Web1"
        Me.Web1.Size = New System.Drawing.Size(1200, 765)
        Me.Web1.TabIndex = 1
        '
        'ServerOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 788)
        Me.Controls.Add(Me.Web1)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServerOpen"
        Me.Text = "Server"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Web1 As System.Windows.Forms.WebBrowser
    Friend WithEvents PictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
End Class
