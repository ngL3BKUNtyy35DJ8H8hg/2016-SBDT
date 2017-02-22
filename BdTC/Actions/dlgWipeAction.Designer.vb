<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWipeAction
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
        Me.txtActionName = New System.Windows.Forms.TextBox
        Me.btnObjName = New System.Windows.Forms.Button
        Me.txtObjName = New System.Windows.Forms.TextBox
        Me.txtSoundName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkLoop = New System.Windows.Forms.CheckBox
        Me.txtStart = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtStep = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDelay = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbWipeUp = New System.Windows.Forms.RadioButton
        Me.rbWipeDown = New System.Windows.Forms.RadioButton
        Me.rbWipeLeft = New System.Windows.Forms.RadioButton
        Me.rbWipeRight = New System.Windows.Forms.RadioButton
        Me.txtObjType = New System.Windows.Forms.TextBox
        Me.txtRepeat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(242, 330)
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
        'txtSoundName
        '
        Me.txtSoundName.Location = New System.Drawing.Point(121, 280)
        Me.txtSoundName.Name = "txtSoundName"
        Me.txtSoundName.Size = New System.Drawing.Size(157, 21)
        Me.txtSoundName.TabIndex = 7
        Me.txtSoundName.Text = "b17-01.wav"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 283)
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
        Me.chkLoop.Location = New System.Drawing.Point(286, 284)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(43, 17)
        Me.chkLoop.TabIndex = 8
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
        'txtStep
        '
        Me.txtStep.Location = New System.Drawing.Point(121, 190)
        Me.txtStep.Name = "txtStep"
        Me.txtStep.Size = New System.Drawing.Size(51, 21)
        Me.txtStep.TabIndex = 5
        Me.txtStep.Text = "15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Phân khúc:"
        '
        'txtDelay
        '
        Me.txtDelay.Location = New System.Drawing.Point(121, 217)
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(51, 21)
        Me.txtDelay.TabIndex = 6
        Me.txtDelay.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Độ chậm:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbWipeUp)
        Me.GroupBox1.Controls.Add(Me.rbWipeDown)
        Me.GroupBox1.Controls.Add(Me.rbWipeLeft)
        Me.GroupBox1.Controls.Add(Me.rbWipeRight)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 75)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Xuất hiện:"
        '
        'rbWipeUp
        '
        Me.rbWipeUp.AutoSize = True
        Me.rbWipeUp.Location = New System.Drawing.Point(138, 43)
        Me.rbWipeUp.Name = "rbWipeUp"
        Me.rbWipeUp.Size = New System.Drawing.Size(100, 17)
        Me.rbWipeUp.TabIndex = 3
        Me.rbWipeUp.TabStop = True
        Me.rbWipeUp.Text = "từ dưới lên trên"
        Me.rbWipeUp.UseVisualStyleBackColor = True
        '
        'rbWipeDown
        '
        Me.rbWipeDown.AutoSize = True
        Me.rbWipeDown.Location = New System.Drawing.Point(6, 43)
        Me.rbWipeDown.Name = "rbWipeDown"
        Me.rbWipeDown.Size = New System.Drawing.Size(116, 17)
        Me.rbWipeDown.TabIndex = 2
        Me.rbWipeDown.TabStop = True
        Me.rbWipeDown.Text = "từ trên xuống dưới"
        Me.rbWipeDown.UseVisualStyleBackColor = True
        '
        'rbWipeLeft
        '
        Me.rbWipeLeft.AutoSize = True
        Me.rbWipeLeft.Location = New System.Drawing.Point(138, 20)
        Me.rbWipeLeft.Name = "rbWipeLeft"
        Me.rbWipeLeft.Size = New System.Drawing.Size(104, 17)
        Me.rbWipeLeft.TabIndex = 1
        Me.rbWipeLeft.TabStop = True
        Me.rbWipeLeft.Text = "từ phải sang trái"
        Me.rbWipeLeft.UseVisualStyleBackColor = True
        '
        'rbWipeRight
        '
        Me.rbWipeRight.AutoSize = True
        Me.rbWipeRight.Location = New System.Drawing.Point(6, 20)
        Me.rbWipeRight.Name = "rbWipeRight"
        Me.rbWipeRight.Size = New System.Drawing.Size(104, 17)
        Me.rbWipeRight.TabIndex = 0
        Me.rbWipeRight.TabStop = True
        Me.rbWipeRight.Text = "từ trái sang phải"
        Me.rbWipeRight.UseVisualStyleBackColor = True
        '
        'txtObjType
        '
        Me.txtObjType.Location = New System.Drawing.Point(289, 95)
        Me.txtObjType.Name = "txtObjType"
        Me.txtObjType.Size = New System.Drawing.Size(102, 21)
        Me.txtObjType.TabIndex = 18
        Me.txtObjType.Visible = False
        '
        'txtRepeat
        '
        Me.txtRepeat.Location = New System.Drawing.Point(121, 244)
        Me.txtRepeat.Name = "txtRepeat"
        Me.txtRepeat.Size = New System.Drawing.Size(51, 21)
        Me.txtRepeat.TabIndex = 19
        Me.txtRepeat.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Số lần:"
        '
        'dlgWipeAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(400, 371)
        Me.Controls.Add(Me.txtRepeat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtObjType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDelay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.txtSoundName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtObjName)
        Me.Controls.Add(Me.btnObjName)
        Me.Controls.Add(Me.txtActionName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWipeAction"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgFlyAction"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtActionName As System.Windows.Forms.TextBox
    Friend WithEvents btnObjName As System.Windows.Forms.Button
    Friend WithEvents txtObjName As System.Windows.Forms.TextBox
    Friend WithEvents txtSoundName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkLoop As System.Windows.Forms.CheckBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStep As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbWipeUp As System.Windows.Forms.RadioButton
    Friend WithEvents rbWipeDown As System.Windows.Forms.RadioButton
    Friend WithEvents rbWipeLeft As System.Windows.Forms.RadioButton
    Friend WithEvents rbWipeRight As System.Windows.Forms.RadioButton
    Friend WithEvents txtObjType As System.Windows.Forms.TextBox
    Friend WithEvents txtRepeat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
