Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgChangePie
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("chkArc")>
		Private _chkArc As CheckBox

		<AccessedThroughProperty("nudSweepAngle")>
		Private _nudSweepAngle As NumericUpDown

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("nudStartAngle")>
		Private _nudStartAngle As NumericUpDown

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtDashValues")>
		Private _txtDashValues As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtHStyle")>
		Private _txtHStyle As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("txtHatchColor")>
		Private _txtHatchColor As TextBox

		<AccessedThroughProperty("nudAlpha")>
		Private _nudAlpha As NumericUpDown

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("txtBrushColor")>
		Private _txtBrushColor As TextBox

		<AccessedThroughProperty("chkBrush")>
		Private _chkBrush As CheckBox

		<AccessedThroughProperty("nudPenWidth2")>
		Private _nudPenWidth2 As NumericUpDown

		<AccessedThroughProperty("txtColor2")>
		Private _txtColor2 As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("nudPenWidth")>
		Private _nudPenWidth As NumericUpDown

		<AccessedThroughProperty("txtColor")>
		Private _txtColor As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		Private myHStyle As Integer

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

		Friend Overridable Property chkArc() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._chkArc
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim flag As Boolean = Me._chkArc IsNot Nothing
				If flag Then
					RemoveHandler Me._chkArc.CheckedChanged, AddressOf Me.chkArc_CheckedChanged
				End If
				Me._chkArc = value
				flag = (Me._chkArc IsNot Nothing)
				If flag Then
					AddHandler Me._chkArc.CheckedChanged, AddressOf Me.chkArc_CheckedChanged
				End If
			End Set
		End Property

		Friend Overridable Property nudSweepAngle() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudSweepAngle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudSweepAngle = value
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

		Friend Overridable Property nudStartAngle() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudStartAngle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudStartAngle = value
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

		Friend Overridable Property txtDashValues() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtDashValues
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDashValues = value
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

		Friend Overridable Property txtHStyle() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtHStyle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtHStyle IsNot Nothing
				If flag Then
					RemoveHandler Me._txtHStyle.TextChanged, AddressOf Me.txtHStyle_TextChanged
				End If
				Me._txtHStyle = value
				flag = (Me._txtHStyle IsNot Nothing)
				If flag Then
					AddHandler Me._txtHStyle.TextChanged, AddressOf Me.txtHStyle_TextChanged
				End If
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

		Friend Overridable Property PictureBox1() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.DoubleClick, AddressOf Me.PictureBox1_DoubleClick
					RemoveHandler Me._PictureBox1.Click, AddressOf Me.PictureBox1_Click
				End If
				Me._PictureBox1 = value
				flag = (Me._PictureBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox1.DoubleClick, AddressOf Me.PictureBox1_DoubleClick
					AddHandler Me._PictureBox1.Click, AddressOf Me.PictureBox1_Click
				End If
			End Set
		End Property

		Friend Overridable Property txtHatchColor() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtHatchColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtHatchColor IsNot Nothing
				If flag Then
					RemoveHandler Me._txtHatchColor.DoubleClick, AddressOf Me.txtHatchColor_DoubleClick
				End If
				Me._txtHatchColor = value
				flag = (Me._txtHatchColor IsNot Nothing)
				If flag Then
					AddHandler Me._txtHatchColor.DoubleClick, AddressOf Me.txtHatchColor_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property nudAlpha() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudAlpha
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudAlpha = value
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

		Friend Overridable Property txtBrushColor() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtBrushColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtBrushColor IsNot Nothing
				If flag Then
					RemoveHandler Me._txtBrushColor.DoubleClick, AddressOf Me.txtBrushColor_DoubleClick
				End If
				Me._txtBrushColor = value
				flag = (Me._txtBrushColor IsNot Nothing)
				If flag Then
					AddHandler Me._txtBrushColor.DoubleClick, AddressOf Me.txtBrushColor_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property chkBrush() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._chkBrush
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkBrush = value
			End Set
		End Property

		Friend Overridable Property nudPenWidth2() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudPenWidth2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudPenWidth2 = value
			End Set
		End Property

		Friend Overridable Property txtColor2() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor2 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor2.DoubleClick, AddressOf Me.txtColor2_DoubleClick
				End If
				Me._txtColor2 = value
				flag = (Me._txtColor2 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor2.DoubleClick, AddressOf Me.txtColor2_DoubleClick
				End If
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

		Friend Overridable Property nudPenWidth() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudPenWidth
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudPenWidth = value
			End Set
		End Property

		Friend Overridable Property txtColor() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor.DoubleClick, AddressOf Me.txtColor_DoubleClick
				End If
				Me._txtColor = value
				flag = (Me._txtColor IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor.DoubleClick, AddressOf Me.txtColor_DoubleClick
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

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgChangePie_Load
			dlgChangePie.__ENCList.Add(New WeakReference(Me))
			Me.myHStyle = 0
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
			Me.chkArc = New CheckBox()
			Me.nudSweepAngle = New NumericUpDown()
			Me.Label7 = New Label()
			Me.nudStartAngle = New NumericUpDown()
			Me.Label6 = New Label()
			Me.Label4 = New Label()
			Me.txtDashValues = New TextBox()
			Me.Label3 = New Label()
			Me.txtHStyle = New TextBox()
			Me.Label2 = New Label()
			Me.PictureBox1 = New PictureBox()
			Me.txtHatchColor = New TextBox()
			Me.nudAlpha = New NumericUpDown()
			Me.Label1 = New Label()
			Me.txtBrushColor = New TextBox()
			Me.chkBrush = New CheckBox()
			Me.nudPenWidth2 = New NumericUpDown()
			Me.txtColor2 = New TextBox()
			Me.Label8 = New Label()
			Me.nudPenWidth = New NumericUpDown()
			Me.txtColor = New TextBox()
			Me.Label5 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			(CType(Me.nudSweepAngle, ISupportInitialize)).BeginInit()
			(CType(Me.nudStartAngle, ISupportInitialize)).BeginInit()
			(CType(Me.PictureBox1, ISupportInitialize)).BeginInit()
			(CType(Me.nudAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.nudPenWidth2, ISupportInitialize)).BeginInit()
			(CType(Me.nudPenWidth, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_222_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(-1, 360)
			arg_222_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_278_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_278_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_2A9_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_2A9_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_2D3_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_2D3_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_323_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_323_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_34D_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_34D_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_384_0 As Control = Me.chkArc
			location = New Point(26, 66)
			arg_384_0.Location = location
			Me.chkArc.Name = "chkArc"
			Dim arg_3AE_0 As Control = Me.chkArc
			size = New Size(80, 24)
			arg_3AE_0.Size = size
			Me.chkArc.TabIndex = 78
			Me.chkArc.Text = "Arc"
			Dim arg_3FB_0 As NumericUpDown = Me.nudSweepAngle
			Dim num As Decimal = New Decimal(New Integer() { 15, 0, 0, 0 })
			arg_3FB_0.Increment = num
			Dim arg_414_0 As Control = Me.nudSweepAngle
			location = New Point(71, 34)
			arg_414_0.Location = location
			Dim arg_445_0 As NumericUpDown = Me.nudSweepAngle
			num = New Decimal(New Integer() { 360, 0, 0, 0 })
			arg_445_0.Maximum = num
			Me.nudSweepAngle.Name = "nudSweepAngle"
			Dim arg_46F_0 As Control = Me.nudSweepAngle
			size = New Size(43, 21)
			arg_46F_0.Size = size
			Me.nudSweepAngle.TabIndex = 77
			Dim arg_4AB_0 As NumericUpDown = Me.nudSweepAngle
			num = New Decimal(New Integer() { 90, 0, 0, 0 })
			arg_4AB_0.Value = num
			Dim arg_4C4_0 As Control = Me.Label7
			location = New Point(26, 34)
			arg_4C4_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_4EE_0 As Control = Me.Label7
			size = New Size(40, 16)
			arg_4EE_0.Size = size
			Me.Label7.TabIndex = 76
			Me.Label7.Text = "Sweep"
			Dim arg_53B_0 As NumericUpDown = Me.nudStartAngle
			num = New Decimal(New Integer() { 15, 0, 0, 0 })
			arg_53B_0.Increment = num
			Dim arg_554_0 As Control = Me.nudStartAngle
			location = New Point(72, 10)
			arg_554_0.Location = location
			Dim arg_585_0 As NumericUpDown = Me.nudStartAngle
			num = New Decimal(New Integer() { 360, 0, 0, 0 })
			arg_585_0.Maximum = num
			Me.nudStartAngle.Name = "nudStartAngle"
			Dim arg_5AF_0 As Control = Me.nudStartAngle
			size = New Size(42, 21)
			arg_5AF_0.Size = size
			Me.nudStartAngle.TabIndex = 75
			Dim arg_5D6_0 As Control = Me.Label6
			location = New Point(26, 10)
			arg_5D6_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_600_0 As Control = Me.Label6
			size = New Size(40, 16)
			arg_600_0.Size = size
			Me.Label6.TabIndex = 74
			Me.Label6.Text = "Start"
			Dim arg_63B_0 As Control = Me.Label4
			location = New Point(26, 154)
			arg_63B_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_665_0 As Control = Me.Label4
			size = New Size(80, 16)
			arg_665_0.Size = size
			Me.Label4.TabIndex = 73
			Me.Label4.Text = "DashValues:"
			Dim arg_6A0_0 As Control = Me.txtDashValues
			location = New Point(26, 170)
			arg_6A0_0.Location = location
			Me.txtDashValues.Name = "txtDashValues"
			Dim arg_6CA_0 As Control = Me.txtDashValues
			size = New Size(88, 21)
			arg_6CA_0.Size = size
			Me.txtDashValues.TabIndex = 72
			Dim arg_6F4_0 As Control = Me.Label3
			location = New Point(26, 274)
			arg_6F4_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_71E_0 As Control = Me.Label3
			size = New Size(64, 16)
			arg_71E_0.Size = size
			Me.Label3.TabIndex = 71
			Me.Label3.Text = "HatchStyle"
			Dim arg_759_0 As Control = Me.txtHStyle
			location = New Point(90, 274)
			arg_759_0.Location = location
			Me.txtHStyle.Name = "txtHStyle"
			Dim arg_783_0 As Control = Me.txtHStyle
			size = New Size(24, 21)
			arg_783_0.Size = size
			Me.txtHStyle.TabIndex = 70
			Me.txtHStyle.Text = "-1"
			Dim arg_7BE_0 As Control = Me.Label2
			location = New Point(26, 250)
			arg_7BE_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_7E8_0 As Control = Me.Label2
			size = New Size(64, 16)
			arg_7E8_0.Size = size
			Me.Label2.TabIndex = 69
			Me.Label2.Text = "HatchColor:"
			Me.PictureBox1.BackColor = SystemColors.HighlightText
			Me.PictureBox1.BorderStyle = BorderStyle.Fixed3D
			Dim arg_841_0 As Control = Me.PictureBox1
			location = New Point(26, 298)
			arg_841_0.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_86B_0 As Control = Me.PictureBox1
			size = New Size(88, 56)
			arg_86B_0.Size = size
			Me.PictureBox1.TabIndex = 68
			Me.PictureBox1.TabStop = False
			Me.txtHatchColor.BackColor = SystemColors.Highlight
			Me.txtHatchColor.ForeColor = SystemColors.HighlightText
			Dim arg_8C4_0 As Control = Me.txtHatchColor
			location = New Point(90, 250)
			arg_8C4_0.Location = location
			Me.txtHatchColor.Name = "txtHatchColor"
			Dim arg_8EE_0 As Control = Me.txtHatchColor
			size = New Size(24, 21)
			arg_8EE_0.Size = size
			Me.txtHatchColor.TabIndex = 67
			Dim arg_918_0 As Control = Me.nudAlpha
			location = New Point(66, 226)
			arg_918_0.Location = location
			Dim arg_949_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_949_0.Maximum = num
			Me.nudAlpha.Name = "nudAlpha"
			Dim arg_973_0 As Control = Me.nudAlpha
			size = New Size(48, 21)
			arg_973_0.Size = size
			Me.nudAlpha.TabIndex = 66
			Dim arg_9B2_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_9B2_0.Value = num
			Dim arg_9CE_0 As Control = Me.Label1
			location = New Point(26, 226)
			arg_9CE_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_9F8_0 As Control = Me.Label1
			size = New Size(40, 16)
			arg_9F8_0.Size = size
			Me.Label1.TabIndex = 65
			Me.Label1.Text = "Alpha"
			Me.txtBrushColor.BackColor = Color.Red
			Me.txtBrushColor.ForeColor = SystemColors.HighlightText
			Dim arg_A55_0 As Control = Me.txtBrushColor
			location = New Point(90, 202)
			arg_A55_0.Location = location
			Me.txtBrushColor.Name = "txtBrushColor"
			Dim arg_A7F_0 As Control = Me.txtBrushColor
			size = New Size(24, 21)
			arg_A7F_0.Size = size
			Me.txtBrushColor.TabIndex = 64
			Dim arg_AA9_0 As Control = Me.chkBrush
			location = New Point(26, 202)
			arg_AA9_0.Location = location
			Me.chkBrush.Name = "chkBrush"
			Dim arg_AD3_0 As Control = Me.chkBrush
			size = New Size(87, 24)
			arg_AD3_0.Size = size
			Me.chkBrush.TabIndex = 63
			Me.chkBrush.Text = "Fill color"
			Dim arg_B0E_0 As Control = Me.nudPenWidth2
			location = New Point(82, 130)
			arg_B0E_0.Location = location
			Dim arg_B3C_0 As NumericUpDown = Me.nudPenWidth2
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_B3C_0.Maximum = num
			Me.nudPenWidth2.Name = "nudPenWidth2"
			Dim arg_B66_0 As Control = Me.nudPenWidth2
			size = New Size(32, 21)
			arg_B66_0.Size = size
			Me.nudPenWidth2.TabIndex = 62
			Me.txtColor2.BackColor = SystemColors.Highlight
			Me.txtColor2.ForeColor = SystemColors.HighlightText
			Dim arg_BB2_0 As Control = Me.txtColor2
			location = New Point(66, 130)
			arg_BB2_0.Location = location
			Me.txtColor2.Name = "txtColor2"
			Dim arg_BDC_0 As Control = Me.txtColor2
			size = New Size(16, 21)
			arg_BDC_0.Size = size
			Me.txtColor2.TabIndex = 61
			Dim arg_C06_0 As Control = Me.Label8
			location = New Point(26, 130)
			arg_C06_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_C30_0 As Control = Me.Label8
			size = New Size(32, 16)
			arg_C30_0.Size = size
			Me.Label8.TabIndex = 60
			Me.Label8.Text = "Pen2:"
			Dim arg_C68_0 As Control = Me.nudPenWidth
			location = New Point(82, 106)
			arg_C68_0.Location = location
			Dim arg_C96_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_C96_0.Maximum = num
			Dim arg_CC3_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_CC3_0.Minimum = num
			Me.nudPenWidth.Name = "nudPenWidth"
			Dim arg_CED_0 As Control = Me.nudPenWidth
			size = New Size(32, 21)
			arg_CED_0.Size = size
			Me.nudPenWidth.TabIndex = 59
			Dim arg_D28_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_D28_0.Value = num
			Me.txtColor.BackColor = Color.Red
			Me.txtColor.ForeColor = SystemColors.HighlightText
			Dim arg_D63_0 As Control = Me.txtColor
			location = New Point(66, 106)
			arg_D63_0.Location = location
			Me.txtColor.Name = "txtColor"
			Dim arg_D8D_0 As Control = Me.txtColor
			size = New Size(16, 21)
			arg_D8D_0.Size = size
			Me.txtColor.TabIndex = 58
			Dim arg_DB4_0 As Control = Me.Label5
			location = New Point(26, 106)
			arg_DB4_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_DDE_0 As Control = Me.Label5
			size = New Size(32, 16)
			arg_DDE_0.Size = size
			Me.Label5.TabIndex = 57
			Me.Label5.Text = "Pen"
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(148, 392)
			Me.ClientSize = size
			Me.Controls.Add(Me.chkArc)
			Me.Controls.Add(Me.nudSweepAngle)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.nudStartAngle)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtDashValues)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtHStyle)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.txtHatchColor)
			Me.Controls.Add(Me.nudAlpha)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.txtBrushColor)
			Me.Controls.Add(Me.chkBrush)
			Me.Controls.Add(Me.nudPenWidth2)
			Me.Controls.Add(Me.txtColor2)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.nudPenWidth)
			Me.Controls.Add(Me.txtColor)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChangePie"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Change Pie"
			Me.TableLayoutPanel1.ResumeLayout(False)
			(CType(Me.nudSweepAngle, ISupportInitialize)).EndInit()
			(CType(Me.nudStartAngle, ISupportInitialize)).EndInit()
			(CType(Me.PictureBox1, ISupportInitialize)).EndInit()
			(CType(Me.nudAlpha, ISupportInitialize)).EndInit()
			(CType(Me.nudPenWidth2, ISupportInitialize)).EndInit()
			(CType(Me.nudPenWidth, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgChangePie_Load(sender As Object, e As EventArgs)
			Me.txtHStyle.[Select]()
		End Sub

		Private Sub txtBrushColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtBrushColor.BackColor = modBanDo.GetMau(Me.txtBrushColor.BackColor)
		End Sub

		Private Sub txtColor2_DoubleClick(sender As Object, e As EventArgs)
			Me.txtColor2.BackColor = modBanDo.GetMau(Me.txtColor2.BackColor)
		End Sub

		Private Sub txtColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtColor.BackColor = modBanDo.GetMau(Me.txtColor.BackColor)
		End Sub

		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Me.XemThu()
		End Sub

		Private Sub txtHStyle_TextChanged(sender As Object, e As EventArgs)
			Me.XemThu()
		End Sub

		Private Sub XemThu()
			Dim mPen As Pen = New Pen(Me.txtColor.BackColor, Convert.ToSingle(Me.nudPenWidth.Value))
			Dim mPen2 As Pen = New Pen(Me.txtColor2.BackColor, Convert.ToSingle(Me.nudPenWidth2.Value))
			mPen2.Alignment = PenAlignment.Inset
			Dim mColor As Color = Nothing
			mColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), CInt(Me.txtBrushColor.BackColor.R), CInt(Me.txtBrushColor.BackColor.G), CInt(Me.txtBrushColor.BackColor.B))
			' The following expression was wrapped in a checked-statement
			Dim r As Rectangle = New Rectangle(3, 3, Me.PictureBox1.Width - 9, Me.PictureBox1.Height - 9)
			Dim DValues As String = Me.txtDashValues.Text.ToString()
			Dim flag As Boolean = DValues.Length > 2
			If flag Then
				Dim strDValues As String() = DValues.Split(New Char() { ","c })
				Dim arg_113_0 As Integer = 0
				Dim upperBound As Integer = strDValues.GetUpperBound(0)
				Dim i As Integer = arg_113_0
				Dim iMax As Integer
				Dim mDashValues As Single()
				While True
					Dim arg_175_0 As Integer = i
					Dim num As Integer = upperBound
					If arg_175_0 > num Then
						Exit While
					End If
					flag = (Conversion.Val(strDValues(i)) > 0.0)
					If Not flag Then
						Exit While
					End If
					iMax = i
					mDashValues = CType(Utils.CopyArray(CType(mDashValues, Array), New Single(i + 1 - 1) {}), Single())
					mDashValues(i) = CSng(Conversion.Val(strDValues(i)))
					i += 1
				End While
				flag = (iMax > 1)
				If flag Then
					mPen.DashPattern = mDashValues
					mPen2.DashPattern = mDashValues
				End If
			End If
			Me.myHStyle = CInt(Math.Round(Conversion.Val(Me.txtHStyle.Text)))
			Me.PictureBox1.CreateGraphics().Clear(Color.White)
			Try
				flag = Me.chkBrush.Checked
				If flag Then
					Dim hBrush As HatchBrush = New HatchBrush(CType(Me.myHStyle, HatchStyle), Me.txtHatchColor.BackColor, mColor)
					Me.PictureBox1.CreateGraphics().FillRectangle(hBrush, r)
				End If
				Me.PictureBox1.CreateGraphics().DrawRectangle(mPen2, r)
				Me.PictureBox1.CreateGraphics().DrawRectangle(mPen, r)
			Catch arg_233_0 As Exception
				ProjectData.SetProjectError(arg_233_0)
				Me.txtHStyle.Text = "-1"
				flag = Me.chkBrush.Checked
				If flag Then
					Dim sBrush As SolidBrush = New SolidBrush(mColor)
					Me.PictureBox1.CreateGraphics().FillRectangle(sBrush, r)
				End If
				Me.PictureBox1.CreateGraphics().DrawRectangle(mPen2, r)
				Me.PictureBox1.CreateGraphics().DrawRectangle(mPen, r)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub txtHatchColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtHatchColor.BackColor = modBanDo.GetMau(Me.txtHatchColor.BackColor)
		End Sub

		Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Me.myHStyle += 1
			Me.txtHStyle.Text = Conversions.ToString(Me.myHStyle)
		End Sub

		Private Sub chkArc_CheckedChanged(sender As Object, e As EventArgs)
			Me.XemThu()
		End Sub
	End Class
End Namespace
