<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgActions
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
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.lstActions = New System.Windows.Forms.ListBox
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnShoot = New System.Windows.Forms.Button
        Me.btnExplode = New System.Windows.Forms.Button
        Me.btnRun = New System.Windows.Forms.Button
        Me.btnFly = New System.Windows.Forms.Button
        Me.btnBlink = New System.Windows.Forms.Button
        Me.btnWipe = New System.Windows.Forms.Button
        Me.btnHide = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SaBanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewSaBanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenSaBanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cboMenuItem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtActFileName = New System.Windows.Forms.TextBox
        Me.btnRebuild = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(420, 36)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK_Button.Location = New System.Drawing.Point(347, 36)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'lstActions
        '
        Me.lstActions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstActions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstActions.FormattingEnabled = True
        Me.lstActions.ItemHeight = 14
        Me.lstActions.Location = New System.Drawing.Point(12, 94)
        Me.lstActions.Name = "lstActions"
        Me.lstActions.Size = New System.Drawing.Size(475, 284)
        Me.lstActions.TabIndex = 2
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.Image = Global.BdTC.My.Resources.Resources.FillDown
        Me.btnDown.Location = New System.Drawing.Point(431, 387)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(25, 23)
        Me.btnDown.TabIndex = 4
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.Image = Global.BdTC.My.Resources.Resources.FillUp
        Me.btnUp.Location = New System.Drawing.Point(464, 387)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(23, 23)
        Me.btnUp.TabIndex = 3
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnShoot)
        Me.GroupBox1.Controls.Add(Me.btnExplode)
        Me.GroupBox1.Controls.Add(Me.btnRun)
        Me.GroupBox1.Controls.Add(Me.btnFly)
        Me.GroupBox1.Controls.Add(Me.btnBlink)
        Me.GroupBox1.Controls.Add(Me.btnWipe)
        Me.GroupBox1.Controls.Add(Me.btnHide)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 387)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 86)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm mới:"
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(259, 49)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(75, 23)
        Me.btnShoot.TabIndex = 6
        Me.btnShoot.Text = "Bắn"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'btnExplode
        '
        Me.btnExplode.Location = New System.Drawing.Point(178, 49)
        Me.btnExplode.Name = "btnExplode"
        Me.btnExplode.Size = New System.Drawing.Size(75, 23)
        Me.btnExplode.TabIndex = 5
        Me.btnExplode.Text = "Nổ"
        Me.btnExplode.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(97, 49)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Chạy"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnFly
        '
        Me.btnFly.Location = New System.Drawing.Point(16, 49)
        Me.btnFly.Name = "btnFly"
        Me.btnFly.Size = New System.Drawing.Size(75, 23)
        Me.btnFly.TabIndex = 3
        Me.btnFly.Text = "Bay"
        Me.btnFly.UseVisualStyleBackColor = True
        '
        'btnBlink
        '
        Me.btnBlink.Location = New System.Drawing.Point(259, 20)
        Me.btnBlink.Name = "btnBlink"
        Me.btnBlink.Size = New System.Drawing.Size(75, 23)
        Me.btnBlink.TabIndex = 2
        Me.btnBlink.Text = "Nhấp nháy"
        Me.btnBlink.UseVisualStyleBackColor = True
        '
        'btnWipe
        '
        Me.btnWipe.Location = New System.Drawing.Point(97, 20)
        Me.btnWipe.Name = "btnWipe"
        Me.btnWipe.Size = New System.Drawing.Size(156, 23)
        Me.btnWipe.TabIndex = 1
        Me.btnWipe.Text = "Di chuyển theo hướng"
        Me.btnWipe.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(16, 20)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "Ẩn"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaBanToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaBanToolStripMenuItem
        '
        Me.SaBanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaBanToolStripMenuItem, Me.ToolStripMenuItem3, Me.OpenSaBanToolStripMenuItem, Me.ToolStripMenuItem4, Me.UpdateMenuToolStripMenuItem})
        Me.SaBanToolStripMenuItem.Name = "SaBanToolStripMenuItem"
        Me.SaBanToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SaBanToolStripMenuItem.Text = "Sa bàn"
        '
        'NewSaBanToolStripMenuItem
        '
        Me.NewSaBanToolStripMenuItem.Name = "NewSaBanToolStripMenuItem"
        Me.NewSaBanToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewSaBanToolStripMenuItem.Text = "Sa bàn mới"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(135, 6)
        '
        'OpenSaBanToolStripMenuItem
        '
        Me.OpenSaBanToolStripMenuItem.Name = "OpenSaBanToolStripMenuItem"
        Me.OpenSaBanToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OpenSaBanToolStripMenuItem.Text = "Mở Sa bàn"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(135, 6)
        '
        'UpdateMenuToolStripMenuItem
        '
        Me.UpdateMenuToolStripMenuItem.Name = "UpdateMenuToolStripMenuItem"
        Me.UpdateMenuToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.UpdateMenuToolStripMenuItem.Text = "Soạn Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem2, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FileToolStripMenuItem.Text = "Các Kịch bản"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewToolStripMenuItem.Text = "Kịch bản mới"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.OpenToolStripMenuItem.Text = "Mở kịch bản"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(142, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SaveAsToolStripMenuItem.Text = "Lưu kịch bản"
        '
        'cboMenuItem
        '
        Me.cboMenuItem.FormattingEnabled = True
        Me.cboMenuItem.Location = New System.Drawing.Point(76, 36)
        Me.cboMenuItem.Name = "cboMenuItem"
        Me.cboMenuItem.Size = New System.Drawing.Size(201, 21)
        Me.cboMenuItem.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Các mục:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kịch bản:"
        '
        'txtActFileName
        '
        Me.txtActFileName.Location = New System.Drawing.Point(76, 70)
        Me.txtActFileName.Name = "txtActFileName"
        Me.txtActFileName.ReadOnly = True
        Me.txtActFileName.Size = New System.Drawing.Size(201, 21)
        Me.txtActFileName.TabIndex = 10
        '
        'btnRebuild
        '
        Me.btnRebuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRebuild.Location = New System.Drawing.Point(347, 65)
        Me.btnRebuild.Name = "btnRebuild"
        Me.btnRebuild.Size = New System.Drawing.Size(67, 23)
        Me.btnRebuild.TabIndex = 11
        Me.btnRebuild.Text = "Rebuild"
        '
        'dlgActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(499, 485)
        Me.Controls.Add(Me.btnRebuild)
        Me.Controls.Add(Me.txtActFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMenuItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lstActions)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgActions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgActions"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lstActions As System.Windows.Forms.ListBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShoot As System.Windows.Forms.Button
    Friend WithEvents btnExplode As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnFly As System.Windows.Forms.Button
    Friend WithEvents btnBlink As System.Windows.Forms.Button
    Friend WithEvents btnWipe As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboMenuItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaBanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewSaBanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenSaBanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtActFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnRebuild As System.Windows.Forms.Button

End Class
