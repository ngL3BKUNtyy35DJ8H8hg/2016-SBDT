<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgShow))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ExitToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrevToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.NextToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ZoomInToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ZoomOutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToPPTToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AxMap1 = New AxMapXLib.AxMap
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AxMap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripButton, Me.ToolStripSeparator1, Me.PrevToolStripButton, Me.NextToolStripButton, Me.ToolStripSeparator2, Me.ZoomInToolStripButton, Me.ZoomOutToolStripButton, Me.ToolStripSeparator3, Me.ToPPTToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(226, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ExitToolStripButton
        '
        Me.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExitToolStripButton.Image = CType(resources.GetObject("ExitToolStripButton.Image"), System.Drawing.Image)
        Me.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitToolStripButton.Name = "ExitToolStripButton"
        Me.ExitToolStripButton.Size = New System.Drawing.Size(29, 22)
        Me.ExitToolStripButton.Text = "Exit"
        Me.ExitToolStripButton.ToolTipText = "Thoát"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrevToolStripButton
        '
        Me.PrevToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrevToolStripButton.Image = Global.BdTC.My.Resources.Resources.GoToPrevious
        Me.PrevToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrevToolStripButton.Name = "PrevToolStripButton"
        Me.PrevToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrevToolStripButton.Text = "Trang trước"
        Me.PrevToolStripButton.ToolTipText = "Trang trước"
        '
        'NextToolStripButton
        '
        Me.NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextToolStripButton.Image = Global.BdTC.My.Resources.Resources.GoToNext
        Me.NextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextToolStripButton.Name = "NextToolStripButton"
        Me.NextToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NextToolStripButton.Text = "Trang sau"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ZoomInToolStripButton
        '
        Me.ZoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomInToolStripButton.Image = Global.BdTC.My.Resources.Resources.zoomin
        Me.ZoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomInToolStripButton.Name = "ZoomInToolStripButton"
        Me.ZoomInToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ZoomInToolStripButton.Text = "Phóng to"
        '
        'ZoomOutToolStripButton
        '
        Me.ZoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomOutToolStripButton.Image = Global.BdTC.My.Resources.Resources.zoomout
        Me.ZoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomOutToolStripButton.Name = "ZoomOutToolStripButton"
        Me.ZoomOutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ZoomOutToolStripButton.Text = "Thu nhỏ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToPPTToolStripButton
        '
        Me.ToPPTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToPPTToolStripButton.Image = CType(resources.GetObject("ToPPTToolStripButton.Image"), System.Drawing.Image)
        Me.ToPPTToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToPPTToolStripButton.Name = "ToPPTToolStripButton"
        Me.ToPPTToolStripButton.Size = New System.Drawing.Size(44, 22)
        Me.ToPPTToolStripButton.Text = "To PPT"
        Me.ToPPTToolStripButton.ToolTipText = "Xuất ra PowerPoint"
        '
        'AxMap1
        '
        Me.AxMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxMap1.Enabled = True
        Me.AxMap1.Location = New System.Drawing.Point(0, 0)
        Me.AxMap1.Name = "AxMap1"
        Me.AxMap1.OcxState = CType(resources.GetObject("AxMap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMap1.Size = New System.Drawing.Size(435, 315)
        Me.AxMap1.TabIndex = 2
        '
        'dlgShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AxMap1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgShow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgShow"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AxMap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxMap1 As AxMapXLib.AxMap
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ZoomInToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZoomOutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToPPTToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrevToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripButton As System.Windows.Forms.ToolStripButton

End Class
