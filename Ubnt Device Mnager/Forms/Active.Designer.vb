<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Active
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Active))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureClose = New System.Windows.Forms.PictureBox()
        Me.Paneltitle = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextActiveNumber = New System.Windows.Forms.TextBox()
        Me.TextSerialNumber = New System.Windows.Forms.TextBox()
        Me.ActiveBTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Copy = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneltitle.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Ubnt Devices Manager [ Active ]"
        '
        'PictureClose
        '
        Me.PictureClose.Image = CType(resources.GetObject("PictureClose.Image"), System.Drawing.Image)
        Me.PictureClose.Location = New System.Drawing.Point(447, 0)
        Me.PictureClose.Name = "PictureClose"
        Me.PictureClose.Size = New System.Drawing.Size(23, 23)
        Me.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureClose.TabIndex = 2
        Me.PictureClose.TabStop = False
        '
        'Paneltitle
        '
        Me.Paneltitle.BackColor = System.Drawing.SystemColors.Highlight
        Me.Paneltitle.Controls.Add(Me.PictureBox2)
        Me.Paneltitle.Controls.Add(Me.Label6)
        Me.Paneltitle.Controls.Add(Me.PictureClose)
        Me.Paneltitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltitle.Location = New System.Drawing.Point(0, 0)
        Me.Paneltitle.Name = "Paneltitle"
        Me.Paneltitle.Size = New System.Drawing.Size(470, 21)
        Me.Paneltitle.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Active Number : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Serial Number :"
        '
        'TextActiveNumber
        '
        Me.TextActiveNumber.Enabled = False
        Me.TextActiveNumber.Location = New System.Drawing.Point(194, 62)
        Me.TextActiveNumber.Name = "TextActiveNumber"
        Me.TextActiveNumber.Size = New System.Drawing.Size(239, 20)
        Me.TextActiveNumber.TabIndex = 6
        '
        'TextSerialNumber
        '
        Me.TextSerialNumber.Location = New System.Drawing.Point(194, 99)
        Me.TextSerialNumber.Name = "TextSerialNumber"
        Me.TextSerialNumber.Size = New System.Drawing.Size(239, 20)
        Me.TextSerialNumber.TabIndex = 7
        '
        'ActiveBTN
        '
        Me.ActiveBTN.Location = New System.Drawing.Point(385, 153)
        Me.ActiveBTN.Name = "ActiveBTN"
        Me.ActiveBTN.Size = New System.Drawing.Size(48, 23)
        Me.ActiveBTN.TabIndex = 8
        Me.ActiveBTN.Text = "Active"
        Me.ActiveBTN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Support: 07800126600"
        '
        'Copy
        '
        Me.Copy.Location = New System.Drawing.Point(435, 60)
        Me.Copy.Name = "Copy"
        Me.Copy.Size = New System.Drawing.Size(23, 23)
        Me.Copy.TabIndex = 10
        Me.Copy.Text = "C"
        Me.ToolTip1.SetToolTip(Me.Copy, "Copy Active Number")
        Me.Copy.UseVisualStyleBackColor = True
        '
        'Active
        '
        Me.AcceptButton = Me.ActiveBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 187)
        Me.Controls.Add(Me.Copy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ActiveBTN)
        Me.Controls.Add(Me.TextSerialNumber)
        Me.Controls.Add(Me.TextActiveNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Paneltitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Active"
        Me.Text = "Active"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneltitle.ResumeLayout(False)
        Me.Paneltitle.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents Paneltitle As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextActiveNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents ActiveBTN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Copy As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
