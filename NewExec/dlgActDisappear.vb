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
	Public Class dlgActDisappear
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

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtActionName")>
		Private _txtActionName As TextBox

		<AccessedThroughProperty("btnObjName")>
		Private _btnObjName As Button

		<AccessedThroughProperty("txtObjName")>
		Private _txtObjName As TextBox

		<AccessedThroughProperty("txtSoundName")>
		Private _txtSoundName As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("chkLoop")>
		Private _chkLoop As CheckBox

		<AccessedThroughProperty("txtStart")>
		Private _txtStart As TextBox

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtStep")>
		Private _txtStep As TextBox

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("rbUp")>
		Private _rbUp As RadioButton

		<AccessedThroughProperty("rbDown")>
		Private _rbDown As RadioButton

		<AccessedThroughProperty("rbLeft")>
		Private _rbLeft As RadioButton

		<AccessedThroughProperty("rbRight")>
		Private _rbRight As RadioButton

		<AccessedThroughProperty("txtObjType")>
		Private _txtObjType As TextBox

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("rbAlpha")>
		Private _rbAlpha As RadioButton

		<AccessedThroughProperty("txtPartial")>
		Private _txtPartial As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		Private Parentf As dlgActions

		Private ActionDef As CAppearDef

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

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
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

		Friend Overridable Property btnObjName() As Button
			Get
				Return Me._btnObjName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnObjName_Click
				If Me._btnObjName IsNot Nothing Then
					RemoveHandler Me._btnObjName.Click, value2
				End If
				Me._btnObjName = value
				If Me._btnObjName IsNot Nothing Then
					AddHandler Me._btnObjName.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtObjName() As TextBox
			Get
				Return Me._txtObjName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjName = value
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

		Friend Overridable Property chkLoop() As CheckBox
			Get
				Return Me._chkLoop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkLoop = value
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

		Friend Overridable Property txtStep() As TextBox
			Get
				Return Me._txtStep
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtStep = value
			End Set
		End Property

		Friend Overridable Property Label7() As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		Friend Overridable Property GroupBox1() As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property rbUp() As RadioButton
			Get
				Return Me._rbUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbUp = value
			End Set
		End Property

		Friend Overridable Property rbDown() As RadioButton
			Get
				Return Me._rbDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbDown = value
			End Set
		End Property

		Friend Overridable Property rbLeft() As RadioButton
			Get
				Return Me._rbLeft
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbLeft = value
			End Set
		End Property

		Friend Overridable Property rbRight() As RadioButton
			Get
				Return Me._rbRight
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbRight = value
			End Set
		End Property

		Friend Overridable Property txtObjType() As TextBox
			Get
				Return Me._txtObjType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjType = value
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

		Friend Overridable Property rbAlpha() As RadioButton
			Get
				Return Me._rbAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbAlpha = value
			End Set
		End Property

		Friend Overridable Property txtPartial() As TextBox
			Get
				Return Me._txtPartial
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPartial = value
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

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgActDisappear_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgActDisappear_Load
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
			Me.Label2 = New Label()
			Me.txtActionName = New TextBox()
			Me.btnObjName = New Button()
			Me.txtObjName = New TextBox()
			Me.txtSoundName = New TextBox()
			Me.Label5 = New Label()
			Me.chkLoop = New CheckBox()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.txtStep = New TextBox()
			Me.Label7 = New Label()
			Me.GroupBox1 = New GroupBox()
			Me.rbAlpha = New RadioButton()
			Me.rbUp = New RadioButton()
			Me.rbDown = New RadioButton()
			Me.rbLeft = New RadioButton()
			Me.rbRight = New RadioButton()
			Me.txtObjType = New TextBox()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.txtPartial = New TextBox()
			Me.Label3 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_1D3_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(183, 335)
			arg_1D3_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_225_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_225_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 8
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_252_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_252_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_279_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_279_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_2C3_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_2C3_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_2EA_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_2EA_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_329_0 As Control = Me.Label1
			location = New Point(21, 18)
			arg_329_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_350_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_350_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Me.Label2.AutoSize = True
			Dim arg_38F_0 As Control = Me.Label2
			location = New Point(21, 74)
			arg_38F_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_3B6_0 As Control = Me.Label2
			size = New Size(78, 13)
			arg_3B6_0.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng:"
			Dim arg_3E9_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_3E9_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_413_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_413_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_439_0 As Control = Me.btnObjName
			location = New Point(173, 98)
			arg_439_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_460_0 As Control = Me.btnObjName
			size = New Size(105, 23)
			arg_460_0.Size = size
			Me.btnObjName.TabIndex = 2
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_49F_0 As Control = Me.txtObjName
			location = New Point(121, 71)
			arg_49F_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Me.txtObjName.[ReadOnly] = True
			Dim arg_4D5_0 As Control = Me.txtObjName
			size = New Size(157, 21)
			arg_4D5_0.Size = size
			Me.txtObjName.TabIndex = 2
			Me.txtObjName.Text = "MayBay2"
			Dim arg_50B_0 As Control = Me.txtSoundName
			location = New Point(121, 294)
			arg_50B_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_535_0 As Control = Me.txtSoundName
			size = New Size(157, 21)
			arg_535_0.Size = size
			Me.txtSoundName.TabIndex = 6
			Me.txtSoundName.Text = "b17-01.wav"
			Me.Label5.AutoSize = True
			Dim arg_577_0 As Control = Me.Label5
			location = New Point(24, 299)
			arg_577_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_59E_0 As Control = Me.Label5
			size = New Size(57, 13)
			arg_59E_0.Size = size
			Me.Label5.TabIndex = 11
			Me.Label5.Text = "Âm thanh:"
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_5FC_0 As Control = Me.chkLoop
			location = New Point(284, 298)
			arg_5FC_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_623_0 As Control = Me.chkLoop
			size = New Size(43, 17)
			arg_623_0.Size = size
			Me.chkLoop.TabIndex = 7
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Dim arg_662_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_662_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_68C_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_68C_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "0"
			Me.Label6.AutoSize = True
			Dim arg_6CB_0 As Control = Me.Label6
			location = New Point(19, 45)
			arg_6CB_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_6F2_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_6F2_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_729_0 As Control = Me.txtStep
			location = New Point(121, 213)
			arg_729_0.Location = location
			Me.txtStep.Name = "txtStep"
			Dim arg_750_0 As Control = Me.txtStep
			size = New Size(51, 21)
			arg_750_0.Size = size
			Me.txtStep.TabIndex = 4
			Me.txtStep.Text = "30"
			Me.Label7.AutoSize = True
			Dim arg_792_0 As Control = Me.Label7
			location = New Point(24, 216)
			arg_792_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_7B9_0 As Control = Me.Label7
			size = New Size(60, 13)
			arg_7B9_0.Size = size
			Me.Label7.TabIndex = 15
			Me.Label7.Text = "Phân khúc:"
			Me.GroupBox1.Controls.Add(Me.rbAlpha)
			Me.GroupBox1.Controls.Add(Me.rbUp)
			Me.GroupBox1.Controls.Add(Me.rbDown)
			Me.GroupBox1.Controls.Add(Me.rbLeft)
			Me.GroupBox1.Controls.Add(Me.rbRight)
			Dim arg_85B_0 As Control = Me.GroupBox1
			location = New Point(18, 127)
			arg_85B_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_885_0 As Control = Me.GroupBox1
			size = New Size(308, 71)
			arg_885_0.Size = size
			Me.GroupBox1.TabIndex = 3
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Bi" & ChrW(7871) & "n m" & ChrW(7845) & "t:"
			Me.rbAlpha.AutoSize = True
			Dim arg_8D3_0 As Control = Me.rbAlpha
			location = New Point(246, 43)
			arg_8D3_0.Location = location
			Me.rbAlpha.Name = "rbAlpha"
			Dim arg_8FA_0 As Control = Me.rbAlpha
			size = New Size(60, 17)
			arg_8FA_0.Size = size
			Me.rbAlpha.TabIndex = 4
			Me.rbAlpha.Text = "m" & ChrW(7901) & " d" & ChrW(7847) & "n"
			Me.rbAlpha.UseVisualStyleBackColor = True
			Me.rbUp.AutoSize = True
			Dim arg_948_0 As Control = Me.rbUp
			location = New Point(138, 43)
			arg_948_0.Location = location
			Me.rbUp.Name = "rbUp"
			Dim arg_96F_0 As Control = Me.rbUp
			size = New Size(100, 17)
			arg_96F_0.Size = size
			Me.rbUp.TabIndex = 3
			Me.rbUp.TabStop = True
			Me.rbUp.Text = "t" & ChrW(7915) & " d" & ChrW(432) & ChrW(7899) & "i lên trên"
			Me.rbUp.UseVisualStyleBackColor = True
			Me.rbDown.AutoSize = True
			Dim arg_9C5_0 As Control = Me.rbDown
			location = New Point(6, 43)
			arg_9C5_0.Location = location
			Me.rbDown.Name = "rbDown"
			Dim arg_9EC_0 As Control = Me.rbDown
			size = New Size(116, 17)
			arg_9EC_0.Size = size
			Me.rbDown.TabIndex = 2
			Me.rbDown.TabStop = True
			Me.rbDown.Text = "t" & ChrW(7915) & " trên xu" & ChrW(7889) & "ng d" & ChrW(432) & ChrW(7899) & "i"
			Me.rbDown.UseVisualStyleBackColor = True
			Me.rbLeft.AutoSize = True
			Dim arg_A46_0 As Control = Me.rbLeft
			location = New Point(138, 20)
			arg_A46_0.Location = location
			Me.rbLeft.Name = "rbLeft"
			Dim arg_A6D_0 As Control = Me.rbLeft
			size = New Size(104, 17)
			arg_A6D_0.Size = size
			Me.rbLeft.TabIndex = 1
			Me.rbLeft.TabStop = True
			Me.rbLeft.Text = "t" & ChrW(7915) & " ph" & ChrW(7843) & "i sang trái"
			Me.rbLeft.UseVisualStyleBackColor = True
			Me.rbRight.AutoSize = True
			Me.rbRight.Checked = True
			Dim arg_ACF_0 As Control = Me.rbRight
			location = New Point(6, 20)
			arg_ACF_0.Location = location
			Me.rbRight.Name = "rbRight"
			Dim arg_AF6_0 As Control = Me.rbRight
			size = New Size(104, 17)
			arg_AF6_0.Size = size
			Me.rbRight.TabIndex = 0
			Me.rbRight.TabStop = True
			Me.rbRight.Text = "t" & ChrW(7915) & " trái sang ph" & ChrW(7843) & "i"
			Me.rbRight.UseVisualStyleBackColor = True
			Dim arg_B44_0 As Control = Me.txtObjType
			location = New Point(18, 340)
			arg_B44_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_B6B_0 As Control = Me.txtObjType
			size = New Size(102, 21)
			arg_B6B_0.Size = size
			Me.txtObjType.TabIndex = 18
			Me.txtObjType.Visible = False
			Dim arg_B9E_0 As Control = Me.txtDuration
			location = New Point(121, 240)
			arg_B9E_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_BC8_0 As Control = Me.txtDuration
			size = New Size(157, 21)
			arg_BC8_0.Size = size
			Me.txtDuration.TabIndex = 5
			Me.txtDuration.Text = "400"
			Me.Label8.AutoSize = True
			Dim arg_C0A_0 As Control = Me.Label8
			location = New Point(24, 243)
			arg_C0A_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_C31_0 As Control = Me.Label8
			size = New Size(54, 13)
			arg_C31_0.Size = size
			Me.Label8.TabIndex = 25
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Dim arg_C68_0 As Control = Me.txtPartial
			location = New Point(121, 267)
			arg_C68_0.Location = location
			Me.txtPartial.Name = "txtPartial"
			Dim arg_C8F_0 As Control = Me.txtPartial
			size = New Size(51, 21)
			arg_C8F_0.Size = size
			Me.txtPartial.TabIndex = 28
			Me.txtPartial.Text = "1"
			Me.Label3.AutoSize = True
			Dim arg_CD2_0 As Control = Me.Label3
			location = New Point(24, 270)
			arg_CD2_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_CF9_0 As Control = Me.Label3
			size = New Size(83, 13)
			arg_CF9_0.Size = size
			Me.Label3.TabIndex = 29
			Me.Label3.Text = "Ph" & ChrW(7847) & "n " & ChrW(7849) & "n (<=1):"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(341, 376)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtPartial)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtObjType)
			Me.Controls.Add(Me.GroupBox1)
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
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActDisappear"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Appear"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub UpdateAction()
			If Operators.CompareString(Me.txtObjType.Text, "TexObj", False) = 0 Or Me.txtObjType.Text.Length = 0 Then
				If Me.rbLeft.Checked Then
					Me.ActionDef.ActionType = "DisappearLeft"
				Else If Me.rbUp.Checked Then
					Me.ActionDef.ActionType = "DisappearUp"
				Else If Me.rbDown.Checked Then
					Me.ActionDef.ActionType = "DisappearDown"
				Else If Me.rbRight.Checked Then
					Me.ActionDef.ActionType = "Disappear"
				Else
					Me.ActionDef.ActionType = "DisappearA"
				End If
			Else
				Me.ActionDef.ActionType = "Hide"
			End If
			Me.ActionDef.Name = Me.txtActionName.Text
			Me.ActionDef.ObjName = Me.txtObjName.Text
			Me.ActionDef.SoundLoop = Me.chkLoop.Checked
			Me.ActionDef.SoundName = Me.txtSoundName.Text
			Me.ActionDef.steps = Conversions.ToInteger(Me.txtStep.Text)
			Me.ActionDef.[partial] = Conversions.ToSingle(Me.txtPartial.Text)
			Me.ActionDef.duration = Me.txtDuration.Text
			Me.ActionDef.start = Me.txtStart.Text
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
				If Me.Parentf.IsNameOK(Me.txtObjName.Text) Then
					Me.UpdateAction()
					modSaBan.fActions.bDirty = True
					Me.DialogResult = DialogResult.OK
					Me.Close()
				Else
					Interaction.MsgBox("Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng không duy nh" & ChrW(7845) & "t.", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CAppearDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myVeActs.OnGetObjName(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub dlgActDisappear_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgActDisappear_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = ChrW(7848) & "n"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtObjName.Text = Me.ActionDef.ObjName
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			Me.txtStep.Text = Conversions.ToString(Me.ActionDef.steps)
			Me.txtPartial.Text = Conversions.ToString(Me.ActionDef.[partial])
			Me.txtDuration.Text = Me.ActionDef.duration
			Me.txtStart.Text = Me.ActionDef.start
			Dim actionType As String = Me.ActionDef.ActionType
			If Operators.CompareString(actionType, "DisappearLeft", False) = 0 Then
				Me.rbLeft.Checked = True
			Else If Operators.CompareString(actionType, "DisappearUp", False) = 0 Then
				Me.rbUp.Checked = True
			Else If Operators.CompareString(actionType, "DisappearDown", False) = 0 Then
				Me.rbDown.Checked = True
			Else If Operators.CompareString(actionType, "DisappearRight", False) = 0 OrElse Operators.CompareString(actionType, "Disappear", False) = 0 Then
				Me.rbRight.Checked = True
			Else
				Me.rbAlpha.Checked = True
			End If
		End Sub

		Private Sub txtSoundName_DoubleClick(sender As Object, e As EventArgs)
			Dim dlgGetName As dlgGetName = New dlgGetName()
			dlgGetName.txtNameType.Text = "Sound"
			If dlgGetName.ShowDialog(Me) = DialogResult.OK Then
				Me.txtSoundName.Text = dlgGetName.txtName.Text
			End If
		End Sub
	End Class
End Namespace
