Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports mySaBanLib
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgShootAction
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		<AccessedThroughProperty("txtSpeed")>
		Private _txtSpeed As TextBox

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

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

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		Private Parentf As dlgActions

		Private ActionDef As CShootDef

		Private Mode As String

		Friend Overridable Property TableLayoutPanel1() As TableLayoutPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._TableLayoutPanel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel1 = value
			End Set
		End Property

		Friend Overridable Property OK_Button() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._OK_Button
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._OK_Button IsNot Nothing
				If flag Then
					RemoveHandler Me._OK_Button.Click, AddressOf Me.OK_Button_Click
				End If
				Me._OK_Button = value
				flag = (Me._OK_Button IsNot Nothing)
				If flag Then
					AddHandler Me._OK_Button.Click, AddressOf Me.OK_Button_Click
				End If
			End Set
		End Property

		Friend Overridable Property Cancel_Button() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cancel_Button
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._Cancel_Button IsNot Nothing
				If flag Then
					RemoveHandler Me._Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
				End If
				Me._Cancel_Button = value
				flag = (Me._Cancel_Button IsNot Nothing)
				If flag Then
					AddHandler Me._Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
				End If
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property lblPath() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._lblPath
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPath = value
			End Set
		End Property

		Friend Overridable Property txtActionName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtActionName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActionName = value
			End Set
		End Property

		Friend Overridable Property btnObjName() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnObjName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnObjName IsNot Nothing
				If flag Then
					RemoveHandler Me._btnObjName.Click, AddressOf Me.btnObjName_Click
				End If
				Me._btnObjName = value
				flag = (Me._btnObjName IsNot Nothing)
				If flag Then
					AddHandler Me._btnObjName.Click, AddressOf Me.btnObjName_Click
				End If
			End Set
		End Property

		Friend Overridable Property txtObjName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtObjName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjName = value
			End Set
		End Property

		Friend Overridable Property txtPath() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtPath
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPath = value
			End Set
		End Property

		Friend Overridable Property btnGetPath() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnGetPath
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnGetPath IsNot Nothing
				If flag Then
					RemoveHandler Me._btnGetPath.Click, AddressOf Me.btnGetPath_Click
				End If
				Me._btnGetPath = value
				flag = (Me._btnGetPath IsNot Nothing)
				If flag Then
					AddHandler Me._btnGetPath.Click, AddressOf Me.btnGetPath_Click
				End If
			End Set
		End Property

		Friend Overridable Property txtSoundName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtSoundName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtSoundName IsNot Nothing
				If flag Then
					RemoveHandler Me._txtSoundName.DoubleClick, AddressOf Me.txtSoundName_DoubleClick
				End If
				Me._txtSoundName = value
				flag = (Me._txtSoundName IsNot Nothing)
				If flag Then
					AddHandler Me._txtSoundName.DoubleClick, AddressOf Me.txtSoundName_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property Label5() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		Friend Overridable Property chkLoop() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._chkLoop
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkLoop = value
			End Set
		End Property

		Friend Overridable Property txtStart() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtStart
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtStart = value
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property txtSpeed() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtSpeed
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSpeed = value
			End Set
		End Property

		Friend Overridable Property Label7() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		Friend Overridable Property txtObjType() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtObjType
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjType = value
			End Set
		End Property

		Friend Overridable Property txtImageFileName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtImageFileName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtImageFileName IsNot Nothing
				If flag Then
					RemoveHandler Me._txtImageFileName.DoubleClick, AddressOf Me.txtImageFileName_DoubleClick
				End If
				Me._txtImageFileName = value
				flag = (Me._txtImageFileName IsNot Nothing)
				If flag Then
					AddHandler Me._txtImageFileName.DoubleClick, AddressOf Me.txtImageFileName_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property Label3() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property txtWidth() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtWidth
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtWidth = value
			End Set
		End Property

		Friend Overridable Property Label4() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property txtHeight() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtHeight
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtHeight = value
			End Set
		End Property

		Friend Overridable Property txtDuration() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtDuration
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDuration = value
			End Set
		End Property

		Friend Overridable Property Label8() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		Friend Overridable Property Label9() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgShootAction_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgShootAction_Load
			dlgShootAction.__ENCList.Add(New WeakReference(Me))
			Me.Mode = "Update"
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
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
			Me.txtSpeed = New TextBox()
			Me.Label7 = New Label()
			Me.txtObjType = New TextBox()
			Me.txtImageFileName = New TextBox()
			Me.Label3 = New Label()
			Me.txtWidth = New TextBox()
			Me.Label4 = New Label()
			Me.txtHeight = New TextBox()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.Label9 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_1F6_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(242, 320)
			arg_1F6_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_24C_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_24C_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 9
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_27E_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_27E_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_2A8_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_2A8_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_2F8_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_2F8_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_322_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_322_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_366_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_366_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_390_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_390_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Me.Label2.AutoSize = True
			Dim arg_3D4_0 As Control = Me.Label2
			location = New Point(12, 71)
			arg_3D4_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_3FE_0 As Control = Me.Label2
			size = New Size(78, 13)
			arg_3FE_0.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng:"
			Me.lblPath.AutoSize = True
			Dim arg_445_0 As Control = Me.lblPath
			location = New Point(12, 251)
			arg_445_0.Location = location
			Me.lblPath.Name = "lblPath"
			Dim arg_46F_0 As Control = Me.lblPath
			size = New Size(65, 13)
			arg_46F_0.Size = size
			Me.lblPath.TabIndex = 3
			Me.lblPath.Text = ChrW(272) & ChrW(432) & ChrW(7901) & "ng b" & ChrW(7855) & "n:"
			Dim arg_4A6_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_4A6_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_4D3_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_4D3_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_4FC_0 As Control = Me.btnObjName
			location = New Point(286, 66)
			arg_4FC_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_526_0 As Control = Me.btnObjName
			size = New Size(105, 23)
			arg_526_0.Size = size
			Me.btnObjName.TabIndex = 3
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_56A_0 As Control = Me.txtObjName
			location = New Point(121, 68)
			arg_56A_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Me.txtObjName.[ReadOnly] = True
			Dim arg_5A4_0 As Control = Me.txtObjName
			size = New Size(157, 21)
			arg_5A4_0.Size = size
			Me.txtObjName.TabIndex = 2
			Me.txtPath.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_5DB_0 As Control = Me.txtPath
			location = New Point(12, 267)
			arg_5DB_0.Location = location
			Me.txtPath.Multiline = True
			Me.txtPath.Name = "txtPath"
			Me.txtPath.ScrollBars = ScrollBars.Vertical
			Dim arg_622_0 As Control = Me.txtPath
			size = New Size(379, 47)
			arg_622_0.Size = size
			Me.txtPath.TabIndex = 6
			Dim arg_64E_0 As Control = Me.btnGetPath
			location = New Point(248, 241)
			arg_64E_0.Location = location
			Me.btnGetPath.Name = "btnGetPath"
			Dim arg_67B_0 As Control = Me.btnGetPath
			size = New Size(143, 23)
			arg_67B_0.Size = size
			Me.btnGetPath.TabIndex = 8
			Me.btnGetPath.Text = "L" & ChrW(7845) & "y " & ChrW(272) & ChrW(432) & ChrW(7901) & "ng b" & ChrW(7855) & "n trên B" & ChrW(272)
			Me.btnGetPath.UseVisualStyleBackColor = True
			Dim arg_6C2_0 As Control = Me.txtSoundName
			location = New Point(121, 203)
			arg_6C2_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_6EF_0 As Control = Me.txtSoundName
			size = New Size(157, 21)
			arg_6EF_0.Size = size
			Me.txtSoundName.TabIndex = 5
			Me.txtSoundName.Text = "gun_shotgun1.wav"
			Me.Label5.AutoSize = True
			Dim arg_736_0 As Control = Me.Label5
			location = New Point(12, 206)
			arg_736_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_760_0 As Control = Me.Label5
			size = New Size(57, 13)
			arg_760_0.Size = size
			Me.Label5.TabIndex = 11
			Me.Label5.Text = "Âm thanh:"
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_7C5_0 As Control = Me.chkLoop
			location = New Point(286, 207)
			arg_7C5_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_7EF_0 As Control = Me.chkLoop
			size = New Size(43, 17)
			arg_7EF_0.Size = size
			Me.chkLoop.TabIndex = 6
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Dim arg_833_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_833_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_860_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_860_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "10"
			Me.Label6.AutoSize = True
			Dim arg_8A4_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_8A4_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_8CE_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_8CE_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_909_0 As Control = Me.txtSpeed
			location = New Point(121, 149)
			arg_909_0.Location = location
			Me.txtSpeed.Name = "txtSpeed"
			Dim arg_933_0 As Control = Me.txtSpeed
			size = New Size(51, 21)
			arg_933_0.Size = size
			Me.txtSpeed.TabIndex = 4
			Me.txtSpeed.Text = "2.0"
			Me.Label7.AutoSize = True
			Dim arg_97A_0 As Control = Me.Label7
			location = New Point(12, 152)
			arg_97A_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_9A4_0 As Control = Me.Label7
			size = New Size(43, 13)
			arg_9A4_0.Size = size
			Me.Label7.TabIndex = 15
			Me.Label7.Text = "T" & ChrW(7889) & "c " & ChrW(273) & ChrW(7897) & ":"
			Dim arg_9DF_0 As Control = Me.txtObjType
			location = New Point(286, 95)
			arg_9DF_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_A09_0 As Control = Me.txtObjType
			size = New Size(102, 21)
			arg_A09_0.Size = size
			Me.txtObjType.TabIndex = 16
			Me.txtObjType.Visible = False
			Dim arg_A3D_0 As Control = Me.txtImageFileName
			location = New Point(121, 95)
			arg_A3D_0.Location = location
			Me.txtImageFileName.Name = "txtImageFileName"
			Dim arg_A6A_0 As Control = Me.txtImageFileName
			size = New Size(157, 21)
			arg_A6A_0.Size = size
			Me.txtImageFileName.TabIndex = 17
			Me.txtImageFileName.Text = "dan2.bmp"
			Me.Label3.AutoSize = True
			Dim arg_AAF_0 As Control = Me.Label3
			location = New Point(12, 98)
			arg_AAF_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_AD9_0 As Control = Me.Label3
			size = New Size(53, 13)
			arg_AD9_0.Size = size
			Me.Label3.TabIndex = 18
			Me.Label3.Text = "Hình " & ChrW(7843) & "nh:"
			Dim arg_B11_0 As Control = Me.txtWidth
			location = New Point(121, 122)
			arg_B11_0.Location = location
			Me.txtWidth.Name = "txtWidth"
			Dim arg_B3B_0 As Control = Me.txtWidth
			size = New Size(51, 21)
			arg_B3B_0.Size = size
			Me.txtWidth.TabIndex = 19
			Me.txtWidth.Text = "0.5"
			Me.Label4.AutoSize = True
			Dim arg_B80_0 As Control = Me.Label4
			location = New Point(12, 125)
			arg_B80_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_BAA_0 As Control = Me.Label4
			size = New Size(61, 13)
			arg_BAA_0.Size = size
			Me.Label4.TabIndex = 20
			Me.Label4.Text = "Kích th" & ChrW(432) & ChrW(7899) & "c:"
			Dim arg_BE5_0 As Control = Me.txtHeight
			location = New Point(197, 122)
			arg_BE5_0.Location = location
			Me.txtHeight.Name = "txtHeight"
			Dim arg_C0F_0 As Control = Me.txtHeight
			size = New Size(51, 21)
			arg_C0F_0.Size = size
			Me.txtHeight.TabIndex = 21
			Me.txtHeight.Text = "0.15"
			Dim arg_C4A_0 As Control = Me.txtDuration
			location = New Point(121, 176)
			arg_C4A_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_C74_0 As Control = Me.txtDuration
			size = New Size(51, 21)
			arg_C74_0.Size = size
			Me.txtDuration.TabIndex = 22
			Me.txtDuration.Text = "400"
			Me.Label8.AutoSize = True
			Dim arg_CBC_0 As Control = Me.Label8
			location = New Point(12, 179)
			arg_CBC_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_CE6_0 As Control = Me.Label8
			size = New Size(54, 13)
			arg_CE6_0.Size = size
			Me.Label8.TabIndex = 23
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Me.Label9.AutoSize = True
			Dim arg_D2E_0 As Control = Me.Label9
			location = New Point(178, 125)
			arg_D2E_0.Location = location
			Me.Label9.Name = "Label9"
			Dim arg_D58_0 As Control = Me.Label9
			size = New Size(13, 13)
			arg_D58_0.Size = size
			Me.Label9.TabIndex = 24
			Me.Label9.Text = "X"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(400, 361)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtHeight)
			Me.Controls.Add(Me.txtWidth)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtImageFileName)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtObjType)
			Me.Controls.Add(Me.txtSpeed)
			Me.Controls.Add(Me.Label7)
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
			Me.Name = "dlgShootAction"
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
			Me.ActionDef.startanimation = Me.txtStart.Text
			Me.ActionDef.speed = Conversions.ToSingle(Me.txtSpeed.Text)
			Me.ActionDef.duration = Conversions.ToInteger(Me.txtDuration.Text)
			Me.ActionDef.imagefile = Me.txtImageFileName.Text
			Me.ActionDef.width = Conversions.ToSingle(Me.txtWidth.Text)
			Me.ActionDef.height = Conversions.ToSingle(Me.txtHeight.Text)
			Dim flag As Boolean = Me.txtObjName.Text.Length > 0
			If flag Then
				Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
				flag = (mTargets.Count > 0)
				If flag Then
					Me.ActionDef.target = mTargets(0)
				End If
			Else
				Dim mTargets2 As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
				flag = (mTargets2.Count = 2)
				If flag Then
					Me.ActionDef.position = mTargets2(0)
					Me.ActionDef.target = mTargets2(1)
				End If
			End If
			flag = (Operators.CompareString(Me.Mode, "Add", False) = 0)
			If flag Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Dim kq As Boolean = False
			Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
			Dim flag As Boolean = Operators.CompareString(Me.ActionDef.ActionType, "ShootFromTexObj", False) = 0
			If flag Then
				Dim flag2 As Boolean = Me.txtObjName.Text.Length > 0 And mTargets.Count > 0
				If flag2 Then
					kq = True
				End If
			Else
				Dim flag2 As Boolean = Operators.CompareString(Me.ActionDef.ActionType, "ShootFromModel", False) = 0
				If flag2 Then
					flag = (Me.txtObjName.Text.Length > 0 And mTargets.Count > 0)
					If flag Then
						kq = True
					End If
				Else
					flag2 = (Operators.CompareString(Me.ActionDef.ActionType, "ShootFromBillboard", False) = 0)
					If flag2 Then
						flag = (Me.txtObjName.Text.Length > 0 And mTargets.Count > 0)
						If flag Then
							kq = True
						End If
					Else
						flag2 = (Operators.CompareString(Me.txtObjType.Text, "TexObj", False) = 0)
						If flag2 Then
							Me.ActionDef.ActionType = "ShootFromTexObj"
							flag2 = (Me.txtObjName.Text.Length > 0 And mTargets.Count > 0)
							If flag2 Then
								kq = True
							End If
						Else
							flag2 = (Operators.CompareString(Me.txtObjType.Text, "Model", False) = 0)
							If flag2 Then
								Me.ActionDef.ActionType = "ShootFromModel"
								flag2 = (Me.txtObjName.Text.Length > 0 And mTargets.Count > 0)
								If flag2 Then
									kq = True
								End If
							Else
								flag2 = (Operators.CompareString(Me.txtObjType.Text, "Billboard", False) = 0)
								If flag2 Then
									Me.ActionDef.ActionType = "ShootFromBillboard"
									flag2 = (Me.txtObjName.Text.Length > 0 And mTargets.Count > 0)
									If flag2 Then
										kq = True
									End If
								Else
									flag2 = (Me.txtObjType.Text.Length = 0)
									If flag2 Then
										flag = (mTargets.Count >= 1)
										If flag Then
											Me.ActionDef.ActionType = "Shoot"
											kq = True
										Else
											Interaction.MsgBox("Ch" & ChrW(432) & "a có " & ChrW(273) & "ích.", MsgBoxStyle.OkOnly, Nothing)
										End If
									Else
										Interaction.MsgBox("Ch" & ChrW(432) & "a " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng b" & ChrW(7855) & "n.", MsgBoxStyle.OkOnly, Nothing)
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Return kq
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.isOK()
			If flag Then
				Me.UpdateAction()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActionDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CShootDef)
			Me.Mode = pMode
			Me.Show(Me.ParentForm)
		End Sub

		Private Sub btnGetPath_Click(sender As Object, e As EventArgs)
			Me.txtPath.Text = ""
			myModule.fMain.myBando.OnGetTarget(Me.txtPath, 0F)
		End Sub

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myBando.OnGetObjName(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub dlgShootAction_FormClosing(sender As Object, e As FormClosingEventArgs)
		End Sub

		Private Sub dlgShootAction_Load(sender As Object, e As EventArgs)
			Me.OK_Button.Text = Me.Mode
			Me.Text = "B" & ChrW(7855) & "n"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtObjName.Text = Me.ActionDef.ObjName
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			Me.txtStart.Text = Me.ActionDef.startanimation
			Me.txtSpeed.Text = Conversions.ToString(Me.ActionDef.speed)
			Me.txtDuration.Text = Conversions.ToString(Me.ActionDef.duration)
			Me.txtImageFileName.Text = Me.ActionDef.imagefile
			Me.txtWidth.Text = Conversions.ToString(Me.ActionDef.width)
			Me.txtHeight.Text = Conversions.ToString(Me.ActionDef.height)
			Dim flag As Boolean = Me.txtObjName.Text.Length > 0
			If flag Then
				Dim txtPath As TextBox = Me.txtPath
				txtPath.Text = String.Concat(New String() { txtPath.Text, "<Target X=""", Me.ActionDef.target.X.ToString(), """ Y=""", Me.ActionDef.target.Y.ToString(), """ Z=""", Me.ActionDef.target.Z.ToString(), """></Target>" & vbCrLf })
			Else
				Me.txtPath.Text = String.Concat(New String() { "<Target X=""", Me.ActionDef.position.X.ToString(), """ Y=""", Me.ActionDef.position.Y.ToString(), """ Z=""", Me.ActionDef.position.Z.ToString(), """></Target>" & vbCrLf })
				Dim txtPath As TextBox = Me.txtPath
				txtPath.Text = String.Concat(New String() { txtPath.Text, "<Target X=""", Me.ActionDef.target.X.ToString(), """ Y=""", Me.ActionDef.target.Y.ToString(), """ Z=""", Me.ActionDef.target.Z.ToString(), """></Target>" & vbCrLf })
			End If
		End Sub

		Private Sub txtImageFileName_DoubleClick(sender As Object, e As EventArgs)
			Dim f As dlgGetName = New dlgGetName()
			f.txtNameType.Text = "Image"
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Me.txtImageFileName.Text = f.txtName.Text
			End If
		End Sub

		Private Sub txtSoundName_DoubleClick(sender As Object, e As EventArgs)
			Dim f As dlgGetName = New dlgGetName()
			f.txtNameType.Text = "Sound"
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Me.txtSoundName.Text = f.txtName.Text
			End If
		End Sub
	End Class
End Namespace
