Imports DienTapLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgActExplode
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

		<AccessedThroughProperty("lblPath")>
		Private _lblPath As Label

		<AccessedThroughProperty("txtActionName")>
		Private _txtActionName As TextBox

		<AccessedThroughProperty("btnObjName")>
		Private _btnObjName As Button

		<AccessedThroughProperty("txtObjName")>
		Private _txtObjName As TextBox

		<AccessedThroughProperty("txtPath")>
		Private _txtPath As TextBox

		<AccessedThroughProperty("btnGetPath")>
		Private _btnGetPath As Button

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

		<AccessedThroughProperty("txtObjType")>
		Private _txtObjType As TextBox

		<AccessedThroughProperty("txtImageFileName")>
		Private _txtImageFileName As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtWidth")>
		Private _txtWidth As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtHeight")>
		Private _txtHeight As TextBox

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("txtSpeed")>
		Private _txtSpeed As TextBox

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("txtShiftZ")>
		Private _txtShiftZ As TextBox

		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		Private Parentf As dlgActions

		Private ActionDef As CExplodeObjDef

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

		Friend Overridable Property lblPath() As Label
			Get
				Return Me._lblPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPath = value
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

		Friend Overridable Property txtPath() As TextBox
			Get
				Return Me._txtPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPath = value
			End Set
		End Property

		Friend Overridable Property btnGetPath() As Button
			Get
				Return Me._btnGetPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnGetPath_Click
				If Me._btnGetPath IsNot Nothing Then
					RemoveHandler Me._btnGetPath.Click, value2
				End If
				Me._btnGetPath = value
				If Me._btnGetPath IsNot Nothing Then
					AddHandler Me._btnGetPath.Click, value2
				End If
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

		Friend Overridable Property txtObjType() As TextBox
			Get
				Return Me._txtObjType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjType = value
			End Set
		End Property

		Friend Overridable Property txtImageFileName() As TextBox
			Get
				Return Me._txtImageFileName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtImageFileName_DoubleClick
				If Me._txtImageFileName IsNot Nothing Then
					RemoveHandler Me._txtImageFileName.DoubleClick, value2
				End If
				Me._txtImageFileName = value
				If Me._txtImageFileName IsNot Nothing Then
					AddHandler Me._txtImageFileName.DoubleClick, value2
				End If
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

		Friend Overridable Property txtWidth() As TextBox
			Get
				Return Me._txtWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtWidth = value
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

		Friend Overridable Property txtHeight() As TextBox
			Get
				Return Me._txtHeight
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtHeight = value
			End Set
		End Property

		Friend Overridable Property Label9() As Label
			Get
				Return Me._Label9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
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

		Friend Overridable Property txtSpeed() As TextBox
			Get
				Return Me._txtSpeed
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSpeed = value
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

		Friend Overridable Property txtShiftZ() As TextBox
			Get
				Return Me._txtShiftZ
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtShiftZ = value
			End Set
		End Property

		Friend Overridable Property Label10() As Label
			Get
				Return Me._Label10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
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
			Me.Label2 = New Label()
			Me.lblPath = New Label()
			Me.txtActionName = New TextBox()
			Me.btnObjName = New Button()
			Me.txtObjName = New TextBox()
			Me.txtPath = New TextBox()
			Me.btnGetPath = New Button()
			Me.txtSoundName = New TextBox()
			Me.Label5 = New Label()
			Me.chkLoop = New CheckBox()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.txtObjType = New TextBox()
			Me.txtImageFileName = New TextBox()
			Me.Label3 = New Label()
			Me.txtWidth = New TextBox()
			Me.Label4 = New Label()
			Me.txtHeight = New TextBox()
			Me.Label9 = New Label()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.txtSpeed = New TextBox()
			Me.Label7 = New Label()
			Me.txtShiftZ = New TextBox()
			Me.Label10 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_1E9_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(242, 352)
			arg_1E9_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_23B_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_23B_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 13
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_269_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_269_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_290_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_290_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_2DA_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_2DA_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_301_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_301_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_340_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_340_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_367_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_367_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Me.Label2.AutoSize = True
			Dim arg_3A6_0 As Control = Me.Label2
			location = New Point(12, 71)
			arg_3A6_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_3CD_0 As Control = Me.Label2
			size = New Size(78, 13)
			arg_3CD_0.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng:"
			Me.lblPath.AutoSize = True
			Dim arg_40F_0 As Control = Me.lblPath
			location = New Point(12, 280)
			arg_40F_0.Location = location
			Me.lblPath.Name = "lblPath"
			Dim arg_436_0 As Control = Me.lblPath
			size = New Size(47, 13)
			arg_436_0.Size = size
			Me.lblPath.TabIndex = 3
			Me.lblPath.Text = "V" & ChrW(7883) & " trí n" & ChrW(7893) & ":"
			Dim arg_469_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_469_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_493_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_493_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_4B9_0 As Control = Me.btnObjName
			location = New Point(286, 66)
			arg_4B9_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_4E0_0 As Control = Me.btnObjName
			size = New Size(105, 23)
			arg_4E0_0.Size = size
			Me.btnObjName.TabIndex = 2
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_51F_0 As Control = Me.txtObjName
			location = New Point(121, 68)
			arg_51F_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Me.txtObjName.[ReadOnly] = True
			Dim arg_555_0 As Control = Me.txtObjName
			size = New Size(157, 21)
			arg_555_0.Size = size
			Me.txtObjName.TabIndex = 2
			Me.txtPath.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_588_0 As Control = Me.txtPath
			location = New Point(12, 299)
			arg_588_0.Location = location
			Me.txtPath.Multiline = True
			Me.txtPath.Name = "txtPath"
			Me.txtPath.ScrollBars = ScrollBars.Vertical
			Dim arg_5CA_0 As Control = Me.txtPath
			size = New Size(379, 47)
			arg_5CA_0.Size = size
			Me.txtPath.TabIndex = 12
			Dim arg_5F4_0 As Control = Me.btnGetPath
			location = New Point(248, 270)
			arg_5F4_0.Location = location
			Me.btnGetPath.Name = "btnGetPath"
			Dim arg_61E_0 As Control = Me.btnGetPath
			size = New Size(143, 23)
			arg_61E_0.Size = size
			Me.btnGetPath.TabIndex = 11
			Me.btnGetPath.Text = "L" & ChrW(7845) & "y v" & ChrW(7883) & " trí n" & ChrW(7893) & " trên B" & ChrW(272)
			Me.btnGetPath.UseVisualStyleBackColor = True
			Dim arg_661_0 As Control = Me.txtSoundName
			location = New Point(121, 232)
			arg_661_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_68B_0 As Control = Me.txtSoundName
			size = New Size(157, 21)
			arg_68B_0.Size = size
			Me.txtSoundName.TabIndex = 9
			Me.txtSoundName.Text = "explosion.wav"
			Me.Label5.AutoSize = True
			Dim arg_6CE_0 As Control = Me.Label5
			location = New Point(12, 235)
			arg_6CE_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_6F5_0 As Control = Me.Label5
			size = New Size(57, 13)
			arg_6F5_0.Size = size
			Me.Label5.TabIndex = 11
			Me.Label5.Text = "Âm thanh:"
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_753_0 As Control = Me.chkLoop
			location = New Point(286, 236)
			arg_753_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_77A_0 As Control = Me.chkLoop
			size = New Size(43, 17)
			arg_77A_0.Size = size
			Me.chkLoop.TabIndex = 10
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Dim arg_7BA_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_7BA_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_7E4_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_7E4_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "10"
			Me.Label6.AutoSize = True
			Dim arg_823_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_823_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_84A_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_84A_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_881_0 As Control = Me.txtObjType
			location = New Point(286, 95)
			arg_881_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_8A8_0 As Control = Me.txtObjType
			size = New Size(102, 21)
			arg_8A8_0.Size = size
			Me.txtObjType.TabIndex = 16
			Me.txtObjType.Visible = False
			Dim arg_8D8_0 As Control = Me.txtImageFileName
			location = New Point(121, 95)
			arg_8D8_0.Location = location
			Me.txtImageFileName.Name = "txtImageFileName"
			Dim arg_902_0 As Control = Me.txtImageFileName
			size = New Size(157, 21)
			arg_902_0.Size = size
			Me.txtImageFileName.TabIndex = 3
			Me.txtImageFileName.Text = "explosion1.bmp"
			Me.Label3.AutoSize = True
			Dim arg_941_0 As Control = Me.Label3
			location = New Point(12, 98)
			arg_941_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_968_0 As Control = Me.Label3
			size = New Size(53, 13)
			arg_968_0.Size = size
			Me.Label3.TabIndex = 18
			Me.Label3.Text = "Hình " & ChrW(7843) & "nh:"
			Dim arg_99C_0 As Control = Me.txtWidth
			location = New Point(121, 122)
			arg_99C_0.Location = location
			Me.txtWidth.Name = "txtWidth"
			Dim arg_9C3_0 As Control = Me.txtWidth
			size = New Size(51, 21)
			arg_9C3_0.Size = size
			Me.txtWidth.TabIndex = 4
			Me.txtWidth.Text = "3"
			Me.Label4.AutoSize = True
			Dim arg_A02_0 As Control = Me.Label4
			location = New Point(12, 125)
			arg_A02_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_A29_0 As Control = Me.Label4
			size = New Size(61, 13)
			arg_A29_0.Size = size
			Me.Label4.TabIndex = 20
			Me.Label4.Text = "Kích th" & ChrW(432) & ChrW(7899) & "c:"
			Dim arg_A60_0 As Control = Me.txtHeight
			location = New Point(197, 122)
			arg_A60_0.Location = location
			Me.txtHeight.Name = "txtHeight"
			Dim arg_A87_0 As Control = Me.txtHeight
			size = New Size(51, 21)
			arg_A87_0.Size = size
			Me.txtHeight.TabIndex = 5
			Me.txtHeight.Text = "3"
			Me.Label9.AutoSize = True
			Dim arg_AC9_0 As Control = Me.Label9
			location = New Point(178, 125)
			arg_AC9_0.Location = location
			Me.Label9.Name = "Label9"
			Dim arg_AF0_0 As Control = Me.Label9
			size = New Size(13, 13)
			arg_AF0_0.Size = size
			Me.Label9.TabIndex = 24
			Me.Label9.Text = "X"
			Dim arg_B27_0 As Control = Me.txtDuration
			location = New Point(121, 205)
			arg_B27_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_B51_0 As Control = Me.txtDuration
			size = New Size(157, 21)
			arg_B51_0.Size = size
			Me.txtDuration.TabIndex = 8
			Me.txtDuration.Text = "400"
			Me.Label8.AutoSize = True
			Dim arg_B93_0 As Control = Me.Label8
			location = New Point(12, 208)
			arg_B93_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_BBA_0 As Control = Me.Label8
			size = New Size(54, 13)
			arg_BBA_0.Size = size
			Me.Label8.TabIndex = 28
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Dim arg_BF1_0 As Control = Me.txtSpeed
			location = New Point(121, 178)
			arg_BF1_0.Location = location
			Me.txtSpeed.Name = "txtSpeed"
			Dim arg_C18_0 As Control = Me.txtSpeed
			size = New Size(51, 21)
			arg_C18_0.Size = size
			Me.txtSpeed.TabIndex = 7
			Me.txtSpeed.Text = "2.0"
			Me.Label7.AutoSize = True
			Dim arg_C5A_0 As Control = Me.Label7
			location = New Point(12, 181)
			arg_C5A_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_C81_0 As Control = Me.Label7
			size = New Size(43, 13)
			arg_C81_0.Size = size
			Me.Label7.TabIndex = 26
			Me.Label7.Text = "T" & ChrW(7889) & "c " & ChrW(273) & ChrW(7897) & ":"
			Dim arg_CB8_0 As Control = Me.txtShiftZ
			location = New Point(121, 149)
			arg_CB8_0.Location = location
			Me.txtShiftZ.Name = "txtShiftZ"
			Dim arg_CDF_0 As Control = Me.txtShiftZ
			size = New Size(51, 21)
			arg_CDF_0.Size = size
			Me.txtShiftZ.TabIndex = 6
			Me.txtShiftZ.Text = "0"
			Me.Label10.AutoSize = True
			Dim arg_D21_0 As Control = Me.Label10
			location = New Point(12, 152)
			arg_D21_0.Location = location
			Me.Label10.Name = "Label10"
			Dim arg_D48_0 As Control = Me.Label10
			size = New Size(45, 13)
			arg_D48_0.Size = size
			Me.Label10.TabIndex = 30
			Me.Label10.Text = ChrW(272) & ChrW(7897) & " cao:"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(400, 393)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtShiftZ)
			Me.Controls.Add(Me.Label10)
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtSpeed)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.txtHeight)
			Me.Controls.Add(Me.txtWidth)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtImageFileName)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtObjType)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.chkLoop)
			Me.Controls.Add(Me.txtSoundName)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.btnGetPath)
			Me.Controls.Add(Me.txtPath)
			Me.Controls.Add(Me.txtObjName)
			Me.Controls.Add(Me.btnObjName)
			Me.Controls.Add(Me.txtActionName)
			Me.Controls.Add(Me.lblPath)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActExplode"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgFlyAction"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub UpdateAction()
			Me.ActionDef.Name = Me.txtActionName.Text
			Me.ActionDef.ObjName = Me.txtObjName.Text
			Me.ActionDef.SoundLoop = Me.chkLoop.Checked
			Me.ActionDef.SoundName = Me.txtSoundName.Text
			Me.ActionDef.start = Me.txtStart.Text
			Me.ActionDef.speed = Conversions.ToSingle(Me.txtSpeed.Text)
			Me.ActionDef.duration = Me.txtDuration.Text
			Me.ActionDef.imagefile = Me.txtImageFileName.Text
			Me.ActionDef.width = Conversions.ToSingle(Me.txtWidth.Text)
			Me.ActionDef.height = Conversions.ToSingle(Me.txtHeight.Text)
			Me.ActionDef.shiftZ = Conversions.ToSingle(Me.txtShiftZ.Text)
			If Me.txtObjName.Text.Length <= 0 Then
				Dim list As List(Of Vector3) = CActDefs.ReadTargets(Me.txtPath.Text)
				If list.Count = 1 Then
					Me.ActionDef.frompos = list(0)
				End If
			End If
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Dim result As Boolean = False
			Dim list As List(Of Vector3) = CActDefs.ReadTargets(Me.txtPath.Text)
			If Me.txtObjName.Text.Length > 0 Then
				result = True
			Else If list.Count > 0 Then
				result = True
			End If
			Return result
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Me.isOK() Then
				If modSaBan.imagenameOK(Me.txtImageFileName.Text) Then
					Me.UpdateAction()
					modSaBan.fActions.bDirty = True
					Me.DialogResult = DialogResult.OK
					Me.Close()
				Else
					Interaction.MsgBox("ImageFileName sai.", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Ch" & ChrW(432) & "a xác " & ChrW(273) & ChrW(7883) & "nh v" & ChrW(7883) & " trí.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CExplodeObjDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub btnGetPath_Click(sender As Object, e As EventArgs)
			Me.txtPath.Text = ""
			myModule.fMain.myVeActs.OnGetTarget(Me.txtPath, 0F)
		End Sub

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myVeActs.OnGetObjName(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub dlgExplodeAction_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgExplodeAction_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = "N" & ChrW(7893)
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtObjName.Text = Me.ActionDef.ObjName
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			Me.txtStart.Text = Me.ActionDef.start
			Me.txtDuration.Text = Me.ActionDef.duration
			Me.txtSpeed.Text = Conversions.ToString(Me.ActionDef.speed)
			Me.txtImageFileName.Text = Me.ActionDef.imagefile
			Me.txtWidth.Text = Conversions.ToString(Me.ActionDef.width)
			Me.txtHeight.Text = Conversions.ToString(Me.ActionDef.height)
			Me.txtShiftZ.Text = Conversions.ToString(Me.ActionDef.shiftZ)
			Me.txtPath.Text = String.Concat(New String() { "<Target X=""", Me.ActionDef.frompos.X.ToString(), """ Y=""", Me.ActionDef.frompos.Y.ToString(), """ Z=""", Me.ActionDef.frompos.Z.ToString(), """></Target>" & vbCrLf })
		End Sub

		Private Sub txtImageFileName_DoubleClick(sender As Object, e As EventArgs)
			Dim dlgGetName As dlgGetName = New dlgGetName()
			dlgGetName.txtNameType.Text = "Image"
			If dlgGetName.ShowDialog(Me) = DialogResult.OK Then
				Me.txtImageFileName.Text = dlgGetName.txtName.Text
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
