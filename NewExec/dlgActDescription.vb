Imports DienTapLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgActDescription
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("txtActionName")>
		Private _txtActionName As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtTextDesc")>
		Private _txtTextDesc As TextBox

		<AccessedThroughProperty("txtStart")>
		Private _txtStart As TextBox

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("chkLoop")>
		Private _chkLoop As CheckBox

		<AccessedThroughProperty("txtSoundName")>
		Private _txtSoundName As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("lblSoundDuration")>
		Private _lblSoundDuration As Label

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("rbDuoi")>
		Private _rbDuoi As RadioButton

		<AccessedThroughProperty("rbGiua")>
		Private _rbGiua As RadioButton

		<AccessedThroughProperty("rbTren")>
		Private _rbTren As RadioButton

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("chkSaBanHide")>
		Private _chkSaBanHide As CheckBox

		Private Parentf As dlgActions

		Private ActionDef As CDescriptionDef

		Private Mode As String

		Friend Overridable Property TableLayoutPanel1() As TableLayoutPanel
			Get
				Return Me._TableLayoutPanel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel1 = value
			End Set
		End Property

		Friend Overridable Property OK_Button() As Button
			Get
				Return Me._OK_Button
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.OK_Button_Click
				If Me._OK_Button IsNot Nothing Then
					RemoveHandler Me._OK_Button.Click, value2
				End If
				Me._OK_Button = value
				If Me._OK_Button IsNot Nothing Then
					AddHandler Me._OK_Button.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Cancel_Button() As Button
			Get
				Return Me._Cancel_Button
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cancel_Button_Click
				If Me._Cancel_Button IsNot Nothing Then
					RemoveHandler Me._Cancel_Button.Click, value2
				End If
				Me._Cancel_Button = value
				If Me._Cancel_Button IsNot Nothing Then
					AddHandler Me._Cancel_Button.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property txtActionName() As TextBox
			Get
				Return Me._txtActionName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActionName = value
			End Set
		End Property

		Friend Overridable Property Label3() As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property txtTextDesc() As TextBox
			Get
				Return Me._txtTextDesc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTextDesc = value
			End Set
		End Property

		Friend Overridable Property txtStart() As TextBox
			Get
				Return Me._txtStart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtStart = value
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property chkLoop() As CheckBox
			Get
				Return Me._chkLoop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkLoop = value
			End Set
		End Property

		Friend Overridable Property txtSoundName() As TextBox
			Get
				Return Me._txtSoundName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSoundName_DoubleClick
				If Me._txtSoundName IsNot Nothing Then
					RemoveHandler Me._txtSoundName.DoubleClick, value2
				End If
				Me._txtSoundName = value
				If Me._txtSoundName IsNot Nothing Then
					AddHandler Me._txtSoundName.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label5() As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		Friend Overridable Property lblSoundDuration() As Label
			Get
				Return Me._lblSoundDuration
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSoundDuration = value
			End Set
		End Property

		Friend Overridable Property txtDuration() As TextBox
			Get
				Return Me._txtDuration
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDuration = value
			End Set
		End Property

		Friend Overridable Property Label8() As Label
			Get
				Return Me._Label8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property rbDuoi() As RadioButton
			Get
				Return Me._rbDuoi
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbDuoi_CheckedChanged
				If Me._rbDuoi IsNot Nothing Then
					RemoveHandler Me._rbDuoi.CheckedChanged, value2
				End If
				Me._rbDuoi = value
				If Me._rbDuoi IsNot Nothing Then
					AddHandler Me._rbDuoi.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbGiua() As RadioButton
			Get
				Return Me._rbGiua
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbGiua_CheckedChanged
				If Me._rbGiua IsNot Nothing Then
					RemoveHandler Me._rbGiua.CheckedChanged, value2
				End If
				Me._rbGiua = value
				If Me._rbGiua IsNot Nothing Then
					AddHandler Me._rbGiua.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property rbTren() As RadioButton
			Get
				Return Me._rbTren
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.rbTren_CheckedChanged
				If Me._rbTren IsNot Nothing Then
					RemoveHandler Me._rbTren.CheckedChanged, value2
				End If
				Me._rbTren = value
				If Me._rbTren IsNot Nothing Then
					AddHandler Me._rbTren.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label4() As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property chkSaBanHide() As CheckBox
			Get
				Return Me._chkSaBanHide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSaBanHide = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgExplodeAction_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgExplodeAction_Load
			Me.Mode = "Update"
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.TableLayoutPanel1 = New TableLayoutPanel()
			Me.OK_Button = New Button()
			Me.Cancel_Button = New Button()
			Me.Label1 = New Label()
			Me.txtActionName = New TextBox()
			Me.Label3 = New Label()
			Me.txtTextDesc = New TextBox()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.chkLoop = New CheckBox()
			Me.txtSoundName = New TextBox()
			Me.Label5 = New Label()
			Me.lblSoundDuration = New Label()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.Label2 = New Label()
			Me.rbDuoi = New RadioButton()
			Me.rbGiua = New RadioButton()
			Me.rbTren = New RadioButton()
			Me.Label4 = New Label()
			Me.chkSaBanHide = New CheckBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_191_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(993, 481)
			arg_191_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1E3_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1E3_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 5
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_210_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_210_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_237_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_237_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_281_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_281_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_2A8_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_2A8_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_2E7_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_2E7_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_30E_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_30E_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Dim arg_341_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_341_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_36B_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_36B_0.Size = size
			Me.txtActionName.TabIndex = 0
			Me.Label3.AutoSize = True
			Dim arg_39A_0 As Control = Me.Label3
			location = New Point(12, 100)
			arg_39A_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_3C1_0 As Control = Me.Label3
			size = New Size(84, 13)
			arg_3C1_0.Size = size
			Me.Label3.TabIndex = 18
			Me.Label3.Text = "L" & ChrW(7901) & "i thuy" & ChrW(7871) & "t minh:"
			Me.txtTextDesc.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_402_0 As Control = Me.txtTextDesc
			location = New Point(12, 117)
			arg_402_0.Location = location
			Me.txtTextDesc.Multiline = True
			Me.txtTextDesc.Name = "txtTextDesc"
			Dim arg_43B_0 As Control = Me.txtTextDesc
			size = New Size(1125, 277)
			arg_43B_0.Size = size
			Me.txtTextDesc.TabIndex = 3
			Dim arg_45E_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_45E_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_488_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_488_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "10"
			Me.Label6.AutoSize = True
			Dim arg_4C7_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_4C7_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_4EE_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_4EE_0.Size = size
			Me.Label6.TabIndex = 30
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Me.chkLoop.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_559_0 As Control = Me.chkLoop
			location = New Point(822, 444)
			arg_559_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_580_0 As Control = Me.chkLoop
			size = New Size(43, 17)
			arg_580_0.Size = size
			Me.chkLoop.TabIndex = 32
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Me.txtSoundName.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_5D0_0 As Control = Me.txtSoundName
			location = New Point(121, 440)
			arg_5D0_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_5FA_0 As Control = Me.txtSoundName
			size = New Size(691, 21)
			arg_5FA_0.Size = size
			Me.txtSoundName.TabIndex = 4
			Me.txtSoundName.Text = "b17-01.wav"
			Me.Label5.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label5.AutoSize = True
			Dim arg_648_0 As Control = Me.Label5
			location = New Point(50, 443)
			arg_648_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_66F_0 As Control = Me.Label5
			size = New Size(57, 13)
			arg_66F_0.Size = size
			Me.Label5.TabIndex = 33
			Me.Label5.Text = "Âm thanh:"
			Me.lblSoundDuration.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.lblSoundDuration.AutoSize = True
			Dim arg_6BE_0 As Control = Me.lblSoundDuration
			location = New Point(118, 464)
			arg_6BE_0.Location = location
			Me.lblSoundDuration.Name = "lblSoundDuration"
			Dim arg_6E5_0 As Control = Me.lblSoundDuration
			size = New Size(100, 13)
			arg_6E5_0.Size = size
			Me.lblSoundDuration.TabIndex = 34
			Me.lblSoundDuration.Text = "Sound duration = 0"
			Dim arg_719_0 As Control = Me.txtDuration
			location = New Point(121, 69)
			arg_719_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_743_0 As Control = Me.txtDuration
			size = New Size(157, 21)
			arg_743_0.Size = size
			Me.txtDuration.TabIndex = 2
			Me.txtDuration.Text = "0"
			Me.Label8.AutoSize = True
			Dim arg_782_0 As Control = Me.Label8
			location = New Point(12, 72)
			arg_782_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_7A9_0 As Control = Me.Label8
			size = New Size(54, 13)
			arg_7A9_0.Size = size
			Me.Label8.TabIndex = 36
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = SystemColors.ActiveCaption
			Dim arg_7FC_0 As Control = Me.Label2
			location = New Point(288, 72)
			arg_7FC_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_826_0 As Control = Me.Label2
			size = New Size(320, 13)
			arg_826_0.Size = size
			Me.Label2.TabIndex = 37
			Me.Label2.Text = "(=0 n" & ChrW(7871) & "u mu" & ChrW(7889) & "n Thuy" & ChrW(7871) & "t minh hi" & ChrW(7879) & "n cho " & ChrW(273) & ChrW(7871) & "n khi có thuy" & ChrW(7871) & "t minh khác)"
			Me.rbDuoi.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.rbDuoi.AutoSize = True
			Me.rbDuoi.Checked = True
			Dim arg_881_0 As Control = Me.rbDuoi
			location = New Point(121, 400)
			arg_881_0.Location = location
			Me.rbDuoi.Name = "rbDuoi"
			Dim arg_8A8_0 As Control = Me.rbDuoi
			size = New Size(47, 17)
			arg_8A8_0.Size = size
			Me.rbDuoi.TabIndex = 38
			Me.rbDuoi.TabStop = True
			Me.rbDuoi.Text = "D" & ChrW(432) & ChrW(7899) & "i"
			Me.rbDuoi.UseVisualStyleBackColor = True
			Me.rbGiua.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.rbGiua.AutoSize = True
			Dim arg_912_0 As Control = Me.rbGiua
			location = New Point(187, 400)
			arg_912_0.Location = location
			Me.rbGiua.Name = "rbGiua"
			Dim arg_939_0 As Control = Me.rbGiua
			size = New Size(47, 17)
			arg_939_0.Size = size
			Me.rbGiua.TabIndex = 39
			Me.rbGiua.TabStop = True
			Me.rbGiua.Text = "Gi" & ChrW(7919) & "a"
			Me.rbGiua.UseVisualStyleBackColor = True
			Me.rbTren.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.rbTren.AutoSize = True
			Dim arg_9A3_0 As Control = Me.rbTren
			location = New Point(249, 400)
			arg_9A3_0.Location = location
			Me.rbTren.Name = "rbTren"
			Dim arg_9CA_0 As Control = Me.rbTren
			size = New Size(47, 17)
			arg_9CA_0.Size = size
			Me.rbTren.TabIndex = 40
			Me.rbTren.Text = "Trên"
			Me.rbTren.UseVisualStyleBackColor = True
			Me.Label4.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label4.AutoSize = True
			Dim arg_A25_0 As Control = Me.Label4
			location = New Point(11, 400)
			arg_A25_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_A4C_0 As Control = Me.Label4
			size = New Size(90, 13)
			arg_A4C_0.Size = size
			Me.Label4.TabIndex = 41
			Me.Label4.Text = "Lo" & ChrW(7841) & "i thuy" & ChrW(7871) & "t minh:"
			Me.chkSaBanHide.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.chkSaBanHide.AutoSize = True
			Dim arg_A9E_0 As Control = Me.chkSaBanHide
			location = New Point(361, 400)
			arg_A9E_0.Location = location
			Me.chkSaBanHide.Name = "chkSaBanHide"
			Dim arg_AC5_0 As Control = Me.chkSaBanHide
			size = New Size(75, 17)
			arg_AC5_0.Size = size
			Me.chkSaBanHide.TabIndex = 46
			Me.chkSaBanHide.Text = ChrW(7848) & "n Sa bàn"
			Me.chkSaBanHide.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(1151, 522)
			Me.ClientSize = size
			Me.Controls.Add(Me.chkSaBanHide)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.rbTren)
			Me.Controls.Add(Me.rbGiua)
			Me.Controls.Add(Me.rbDuoi)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.lblSoundDuration)
			Me.Controls.Add(Me.chkLoop)
			Me.Controls.Add(Me.txtSoundName)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.txtTextDesc)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtActionName)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActDescription"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgFlyAction"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub UpdateAction()
			Me.ActionDef.Name = Me.txtActionName.Text
			Me.ActionDef.SoundLoop = Me.chkLoop.Checked
			Me.ActionDef.SoundName = Me.txtSoundName.Text
			Me.ActionDef.start = Me.txtStart.Text
			Me.ActionDef.DescText = Me.txtTextDesc.Text
			Me.ActionDef.Pos = CType(Conversions.ToInteger(Interaction.IIf(Me.rbDuoi.Checked, DescPos.Duoi, RuntimeHelpers.GetObjectValue(Interaction.IIf(Me.rbGiua.Checked, DescPos.Giua, DescPos.Tren)))), DescPos)
			Me.ActionDef.SaBanHide = Me.chkSaBanHide.Checked
			Me.ActionDef.duration = Me.txtDuration.Text
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Return True
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Me.isOK() Then
				Me.UpdateAction()
				modSaBan.fActions.bDirty = True
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Interaction.MsgBox("Ch" & ChrW(432) & "a OK.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CDescriptionDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub dlgExplodeAction_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgExplodeAction_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = "Thuy" & ChrW(7871) & "t minh"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtStart.Text = Me.ActionDef.start
			Me.txtDuration.Text = Me.ActionDef.duration
			Me.txtTextDesc.Font = New Font(modSaBan.DescFontName, modSaBan.DescFontSize, modSaBan.DescFontStyle, GraphicsUnit.Point)
			Me.txtTextDesc.ForeColor = modSaBan.DescColor
			Me.txtTextDesc.Text = Me.ActionDef.DescText
			If Me.ActionDef.Pos = DescPos.Tren Then
				Me.rbTren.Checked = True
				Me.txtTextDesc.BackColor = modSaBan.BGrColor
			Else If Me.ActionDef.Pos = DescPos.Giua Then
				Me.rbGiua.Checked = True
				Me.txtTextDesc.BackColor = modSaBan.BGrColor
			Else
				Me.rbDuoi.Checked = True
				Me.txtTextDesc.BackColor = modSaBan.clrColor
			End If
			Me.chkSaBanHide.Checked = Me.ActionDef.SaBanHide
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			If Me.txtSoundName.Text.Length > 0 Then
				Dim text As String = Me.txtSoundName.Text
				If text.IndexOf("\") < 0 Then
					text = modSaBan.mySoundsPath + "\" + Me.txtSoundName.Text
				End If
				Dim soundLength As Integer = CHelper.GetSoundLength(text)
				Me.lblSoundDuration.Text = "Sound duration = " + (CDec(soundLength) / 1000.0).ToString("0.###")
			End If
		End Sub

		Private Sub temp2()
			Dim dlgGetName As dlgGetName = New dlgGetName()
			dlgGetName.txtNameType.Text = "TMSound"
			If dlgGetName.ShowDialog(Me) = DialogResult.OK Then
				Dim text As String = modSaBan.myTMSoundsPath + "\" + dlgGetName.txtName.Text
				Me.txtSoundName.Text = text
				Dim soundLength As Integer = CHelper.GetSoundLength(text)
				Me.lblSoundDuration.Text = "Sound duration = " + (CDec(soundLength) / 1000.0).ToString("0.###")
				Me.txtDuration.Text = Conversions.ToString(Math.Ceiling(CDec(soundLength) / 1000.0))
			End If
		End Sub

		Private Function GetParentDir(pDir As String) As String
			Dim result As String = ""
			Dim num As Integer = pDir.LastIndexOf("\")
			If num > -1 Then
				result = pDir.Substring(0, num)
			End If
			Return result
		End Function

		Private Sub txtSoundName_DoubleClick(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "Wav files (*.wav)|*.wav"
			openFileDialog.FilterIndex = 1
			openFileDialog.InitialDirectory = modSaBan.myTMSoundsPath
			openFileDialog.RestoreDirectory = False
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = openFileDialog.FileName
				If fileName.Length > 0 Then
					Try
						Dim text As String = fileName.Replace(Me.GetParentDir(modSaBan.myCurrentDirectory), "..")
						Me.txtSoundName.Text = text
						Dim soundLength As Integer = CHelper.GetSoundLength(text)
						Me.lblSoundDuration.Text = "Sound duration = " + (CDec(soundLength) / 1000.0).ToString("0.###")
						Me.txtDuration.Text = Conversions.ToString(Math.Ceiling(CDec(soundLength) / 1000.0))
					Catch expr_C7 As Exception
						ProjectData.SetProjectError(expr_C7)
						ProjectData.ClearProjectError()
					End Try
				End If
			End If
		End Sub

		Private Sub txtTextDesc_DoubleClick(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.txtTextDesc.Font
			fontDialog.Color = Me.txtTextDesc.ForeColor
			fontDialog.ShowColor = True
			If fontDialog.ShowDialog() <> DialogResult.Cancel Then
				Me.txtTextDesc.Font = fontDialog.Font
				Me.txtTextDesc.ForeColor = fontDialog.Color
			End If
		End Sub

		Private Sub rbDuoi_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbDuoi.Checked Then
				Me.txtTextDesc.BackColor = modSaBan.clrColor
			End If
		End Sub

		Private Sub rbGiua_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbGiua.Checked Then
				Me.txtTextDesc.BackColor = modSaBan.BGrColor
			End If
		End Sub

		Private Sub rbTren_CheckedChanged(sender As Object, e As EventArgs)
			If Me.rbTren.Checked Then
				Me.txtTextDesc.BackColor = modSaBan.BGrColor
			End If
		End Sub
	End Class
End Namespace
