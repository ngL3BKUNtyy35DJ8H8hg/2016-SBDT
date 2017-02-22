<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFlyAction
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPath = New System.Windows.Forms.Label
        Me.txtActionName = New System.Windows.Forms.TextBox
        Me.btnObjName = New System.Windows.Forms.Button
        Me.txtObjName = New System.Windows.Forms.TextBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.lblDoCao = New System.Windows.Forms.Label
        Me.txtDoCao = New System.Windows.Forms.TextBox
        Me.btnGetPath = New System.Windows.Forms.Button
        Me.txtSoundName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkLoop = New System.Windows.Forms.CheckBox
        Me.txtStart = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSpeed = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtObjType = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(242, 315)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên hành động:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên đối tượng:"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 178)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(65, 13)
        Me.lblPath.TabIndex = 3
        Me.lblPath.Text = "Đường bay:"
        '
        'txtActionName
        '
        Me.txtActionName.Location = New System.Drawing.Point(121, 15)
        Me.txtActionName.Name = "txtActionName"
        Me.txtActionName.Size = New System.Drawing.Size(157, 21)
        Me.txtActionName.TabIndex = 0
        '
        'btnObjName
        '
        Me.btnObjName.Location = New System.Drawing.Point(286, 66)
        Me.btnObjName.Name = "btnObjName"
        Me.btnObjName.Size = New System.Drawing.Size(105, 23)
        Me.btnObjName.TabIndex = 3
        Me.btnObjName.Text = "Lấy ĐT trên BĐ"
        Me.btnObjName.UseVisualStyleBackColor = True
        '
        'txtObjName
        '
        Me.txtObjName.Location = New System.Drawing.Point(121, 68)
        Me.txtObjName.Name = "txtObjName"
        Me.txtObjName.ReadOnly = True
        Me.txtObjName.Size = New System.Drawing.Size(157, 21)
        Me.txtObjName.TabIndex = 2
        Me.txtObjName.Text = "MayBay2"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(12, 194)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPath.Size = New System.Drawing.Size(379, 115)
        Me.txtPath.TabIndex = 6
        '
        'lblDoCao
        '
        Me.lblDoCao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDoCao.AutoSize = True
        Me.lblDoCao.Location = New System.Drawing.Point(127, 178)
        Me.lblDoCao.Name = "lblDoCao"
        Me.lblDoCao.Size = New System.Drawing.Size(45, 13)
        Me.lblDoCao.TabIndex = 9
        Me.lblDoCao.Text = "Độ cao:"
        '
        'txtDoCao
        '
        Me.txtDoCao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDoCao.Location = New System.Drawing.Point(177, 170)
        Me.txtDoCao.Name = "txtDoCao"
        Me.txtDoCao.Size = New System.Drawing.Size(44, 21)
        Me.txtDoCao.TabIndex = 7
        Me.txtDoCao.Text = "10"
        '
        'btnGetPath
        '
        Me.btnGetPath.Location = New System.Drawing.Point(248, 168)
        Me.btnGetPath.Name = "btnGetPath"
        Me.btnGetPath.Size = New System.Drawing.Size(143, 23)
        Me.btnGetPath.TabIndex = 8
        Me.btnGetPath.Text = "Lấy Đường bay trên BĐ"
        Me.btnGetPath.UseVisualStyleBackColor = True
        '
        'txtSoundName
        '
        Me.txtSoundName.Location = New System.Drawing.Point(121, 122)
        Me.txtSoundName.Name = "txtSoundName"
        Me.txtSoundName.Size = New System.Drawing.Size(157, 21)
        Me.txtSoundName.TabIndex = 5
        Me.txtSoundName.Text = "b17-01.wav"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Âm thanh:"
        '
        'chkLoop
        '
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Checked = True
        Me.chkLoop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoop.Location = New System.Drawing.Point(286, 126)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(43, 17)
        Me.chkLoop.TabIndex = 6
        Me.chkLoop.Text = "Lặp"
        Me.chkLoop.UseVisualStyleBackColor = True
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(121, 42)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(157, 21)
        Me.txtStart.TabIndex = 1
        Me.txtStart.Text = "10"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Thời điểm Bắt đầu:"
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(121, 95)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(51, 21)
        Me.txtSpeed.TabIndex = 4
        Me.txtSpeed.Text = "0.18"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tốc độ:"
        '
        'txtObjType
        '
        Me.txtObjType.Location = New System.Drawing.Point(286, 95)
        Me.txtObjType.Name = "txtObjType"
        Me.txtObjType.Size = New System.Drawing.Size(102, 21)
        Me.txtObjType.TabIndex = 16
        Me.txtObjType.Visible = False
        '
        'dlgFlyAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(400, 356)
        Me.Controls.Add(Me.txtObjType)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.txtSoundName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGetPath)
        Me.Controls.Add(Me.lblDoCao)
        Me.Controls.Add(Me.txtDoCao)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.txtObjName)
        Me.Controls.Add(Me.btnObjName)
        Me.Controls.Add(Me.txtActionName)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFlyAction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgFlyAction"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents txtActionName As System.Windows.Forms.TextBox
    Friend WithEvents btnObjName As System.Windows.Forms.Button
    Friend WithEvents txtObjName As System.Windows.Forms.TextBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents lblDoCao As System.Windows.Forms.Label
    Friend WithEvents txtDoCao As System.Windows.Forms.TextBox
    Friend WithEvents btnGetPath As System.Windows.Forms.Button
    Friend WithEvents txtSoundName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkLoop As System.Windows.Forms.CheckBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObjType As System.Windows.Forms.TextBox

End Class
