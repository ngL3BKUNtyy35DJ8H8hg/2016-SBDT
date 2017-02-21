Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgChangeColor
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("nudStyleWidth")>
		Private _nudStyleWidth As NumericUpDown

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("nudHStyle")>
		Private _nudHStyle As NumericUpDown

		<AccessedThroughProperty("nudLineStyle")>
		Private _nudLineStyle As NumericUpDown

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtDashValues")>
		Private _txtDashValues As TextBox

		<AccessedThroughProperty("txtHatchColor")>
		Private _txtHatchColor As TextBox

		<AccessedThroughProperty("txtBrushColor")>
		Private _txtBrushColor As TextBox

		<AccessedThroughProperty("txtColor2")>
		Private _txtColor2 As TextBox

		<AccessedThroughProperty("txtColor")>
		Private _txtColor As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("nudAlpha")>
		Private _nudAlpha As NumericUpDown

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("chkBrush")>
		Private _chkBrush As CheckBox

		<AccessedThroughProperty("nudPenWidth2")>
		Private _nudPenWidth2 As NumericUpDown

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("nudPenWidth")>
		Private _nudPenWidth As NumericUpDown

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		Private m_myObj As ShapeGraphic

		Private m_drawingObjects As CGraphicObjs

		Private m_Scale As Single

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

		Friend Overridable Property nudStyleWidth() As NumericUpDown
			Get
				Return Me._nudStyleWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudStyleWidth_ValueChanged
				If Me._nudStyleWidth IsNot Nothing Then
					RemoveHandler Me._nudStyleWidth.ValueChanged, value2
				End If
				Me._nudStyleWidth = value
				If Me._nudStyleWidth IsNot Nothing Then
					AddHandler Me._nudStyleWidth.ValueChanged, value2
				End If
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

		Friend Overridable Property nudHStyle() As NumericUpDown
			Get
				Return Me._nudHStyle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudHStyle_ValueChanged
				If Me._nudHStyle IsNot Nothing Then
					RemoveHandler Me._nudHStyle.ValueChanged, value2
				End If
				Me._nudHStyle = value
				If Me._nudHStyle IsNot Nothing Then
					AddHandler Me._nudHStyle.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudLineStyle() As NumericUpDown
			Get
				Return Me._nudLineStyle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudLineStyle_ValueChanged
				If Me._nudLineStyle IsNot Nothing Then
					RemoveHandler Me._nudLineStyle.ValueChanged, value2
				End If
				Me._nudLineStyle = value
				If Me._nudLineStyle IsNot Nothing Then
					AddHandler Me._nudLineStyle.ValueChanged, value2
				End If
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

		Friend Overridable Property Label4() As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property txtDashValues() As TextBox
			Get
				Return Me._txtDashValues
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtDashValues_TextChanged
				If Me._txtDashValues IsNot Nothing Then
					RemoveHandler Me._txtDashValues.TextChanged, value2
				End If
				Me._txtDashValues = value
				If Me._txtDashValues IsNot Nothing Then
					AddHandler Me._txtDashValues.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtHatchColor() As TextBox
			Get
				Return Me._txtHatchColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtHatchColor_BackColorChanged
				Dim value3 As EventHandler = AddressOf Me.txtHatchColor_DoubleClick
				If Me._txtHatchColor IsNot Nothing Then
					RemoveHandler Me._txtHatchColor.BackColorChanged, value2
					RemoveHandler Me._txtHatchColor.DoubleClick, value3
				End If
				Me._txtHatchColor = value
				If Me._txtHatchColor IsNot Nothing Then
					AddHandler Me._txtHatchColor.BackColorChanged, value2
					AddHandler Me._txtHatchColor.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtBrushColor() As TextBox
			Get
				Return Me._txtBrushColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtBrushColor_BackColorChanged
				Dim value3 As EventHandler = AddressOf Me.txtBrushColor_DoubleClick
				If Me._txtBrushColor IsNot Nothing Then
					RemoveHandler Me._txtBrushColor.BackColorChanged, value2
					RemoveHandler Me._txtBrushColor.DoubleClick, value3
				End If
				Me._txtBrushColor = value
				If Me._txtBrushColor IsNot Nothing Then
					AddHandler Me._txtBrushColor.BackColorChanged, value2
					AddHandler Me._txtBrushColor.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor2() As TextBox
			Get
				Return Me._txtColor2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor2_BackColorChanged
				Dim value3 As EventHandler = AddressOf Me.txtColor2_DoubleClick
				If Me._txtColor2 IsNot Nothing Then
					RemoveHandler Me._txtColor2.BackColorChanged, value2
					RemoveHandler Me._txtColor2.DoubleClick, value3
				End If
				Me._txtColor2 = value
				If Me._txtColor2 IsNot Nothing Then
					AddHandler Me._txtColor2.BackColorChanged, value2
					AddHandler Me._txtColor2.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor() As TextBox
			Get
				Return Me._txtColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor_BackColorChanged
				Dim value3 As EventHandler = AddressOf Me.txtColor_DoubleClick
				If Me._txtColor IsNot Nothing Then
					RemoveHandler Me._txtColor.BackColorChanged, value2
					RemoveHandler Me._txtColor.DoubleClick, value3
				End If
				Me._txtColor = value
				If Me._txtColor IsNot Nothing Then
					AddHandler Me._txtColor.BackColorChanged, value2
					AddHandler Me._txtColor.DoubleClick, value3
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

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property PictureBox1() As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.PictureBox1_Paint
				If Me._PictureBox1 IsNot Nothing Then
					RemoveHandler Me._PictureBox1.Paint, value2
				End If
				Me._PictureBox1 = value
				If Me._PictureBox1 IsNot Nothing Then
					AddHandler Me._PictureBox1.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudAlpha() As NumericUpDown
			Get
				Return Me._nudAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudAlpha_ValueChanged
				If Me._nudAlpha IsNot Nothing Then
					RemoveHandler Me._nudAlpha.ValueChanged, value2
				End If
				Me._nudAlpha = value
				If Me._nudAlpha IsNot Nothing Then
					AddHandler Me._nudAlpha.ValueChanged, value2
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

		Friend Overridable Property chkBrush() As CheckBox
			Get
				Return Me._chkBrush
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkBrush_CheckedChanged
				If Me._chkBrush IsNot Nothing Then
					RemoveHandler Me._chkBrush.CheckedChanged, value2
				End If
				Me._chkBrush = value
				If Me._chkBrush IsNot Nothing Then
					AddHandler Me._chkBrush.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudPenWidth2() As NumericUpDown
			Get
				Return Me._nudPenWidth2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudPenWidth2_ValueChanged
				If Me._nudPenWidth2 IsNot Nothing Then
					RemoveHandler Me._nudPenWidth2.ValueChanged, value2
				End If
				Me._nudPenWidth2 = value
				If Me._nudPenWidth2 IsNot Nothing Then
					AddHandler Me._nudPenWidth2.ValueChanged, value2
				End If
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

		Friend Overridable Property nudPenWidth() As NumericUpDown
			Get
				Return Me._nudPenWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudPenWidth_ValueChanged
				If Me._nudPenWidth IsNot Nothing Then
					RemoveHandler Me._nudPenWidth.ValueChanged, value2
				End If
				Me._nudPenWidth = value
				If Me._nudPenWidth IsNot Nothing Then
					AddHandler Me._nudPenWidth.ValueChanged, value2
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

		Public WriteOnly Property myObj() As ShapeGraphic
			Set(value As ShapeGraphic)
				Me.m_myObj = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgChangeColor_Load
			Me.m_drawingObjects = New CGraphicObjs()
			Me.m_Scale = 1F
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
			Me.nudStyleWidth = New NumericUpDown()
			Me.Label7 = New Label()
			Me.nudHStyle = New NumericUpDown()
			Me.nudLineStyle = New NumericUpDown()
			Me.Label6 = New Label()
			Me.Label4 = New Label()
			Me.txtDashValues = New TextBox()
			Me.txtHatchColor = New TextBox()
			Me.txtBrushColor = New TextBox()
			Me.txtColor2 = New TextBox()
			Me.txtColor = New TextBox()
			Me.Label3 = New Label()
			Me.Label2 = New Label()
			Me.PictureBox1 = New PictureBox()
			Me.nudAlpha = New NumericUpDown()
			Me.Label1 = New Label()
			Me.chkBrush = New CheckBox()
			Me.nudPenWidth2 = New NumericUpDown()
			Me.Label8 = New Label()
			Me.nudPenWidth = New NumericUpDown()
			Me.Label5 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			(CType(Me.nudStyleWidth, ISupportInitialize)).BeginInit()
			(CType(Me.nudHStyle, ISupportInitialize)).BeginInit()
			(CType(Me.nudLineStyle, ISupportInitialize)).BeginInit()
			(CType(Me.PictureBox1, ISupportInitialize)).BeginInit()
			(CType(Me.nudAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.nudPenWidth2, ISupportInitialize)).BeginInit()
			(CType(Me.nudPenWidth, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 46.2963F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 53.7037F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_1FC_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(10, 408)
			arg_1FC_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_24B_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(108, 29)
			arg_24B_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_278_0 As Control = Me.OK_Button
			location = New Point(4, 3)
			arg_278_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_29F_0 As Control = Me.OK_Button
			size = New Size(41, 23)
			arg_29F_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_2E9_0 As Control = Me.Cancel_Button
			location = New Point(52, 3)
			arg_2E9_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_310_0 As Control = Me.Cancel_Button
			size = New Size(53, 23)
			arg_310_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_343_0 As Control = Me.nudStyleWidth
			location = New Point(70, 92)
			arg_343_0.Location = location
			Dim arg_376_0 As NumericUpDown = Me.nudStyleWidth
			Dim num As Decimal = New Decimal(New Integer() { 30, 0, 0, 0 })
			arg_376_0.Maximum = num
			Me.nudStyleWidth.Name = "nudStyleWidth"
			Dim arg_39D_0 As Control = Me.nudStyleWidth
			size = New Size(40, 21)
			arg_39D_0.Size = size
			Me.nudStyleWidth.TabIndex = 77
			Dim arg_3DC_0 As NumericUpDown = Me.nudStyleWidth
			num = New Decimal(New Integer() { 4, 0, 0, 0 })
			arg_3DC_0.Value = num
			Dim arg_3F3_0 As Control = Me.Label7
			location = New Point(14, 92)
			arg_3F3_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_41A_0 As Control = Me.Label7
			size = New Size(40, 16)
			arg_41A_0.Size = size
			Me.Label7.TabIndex = 76
			Me.Label7.Text = "Width"
			Dim arg_451_0 As Control = Me.nudHStyle
			location = New Point(62, 244)
			arg_451_0.Location = location
			Dim arg_484_0 As NumericUpDown = Me.nudHStyle
			num = New Decimal(New Integer() { 60, 0, 0, 0 })
			arg_484_0.Maximum = num
			Dim arg_4BA_0 As NumericUpDown = Me.nudHStyle
			num = New Decimal(New Integer() { 1, 0, 0, -2147483648 })
			arg_4BA_0.Minimum = num
			Me.nudHStyle.Name = "nudHStyle"
			Dim arg_4E1_0 As Control = Me.nudHStyle
			size = New Size(40, 21)
			arg_4E1_0.Size = size
			Me.nudHStyle.TabIndex = 75
			Dim arg_524_0 As NumericUpDown = Me.nudHStyle
			num = New Decimal(New Integer() { 1, 0, 0, -2147483648 })
			arg_524_0.Value = num
			Dim arg_53B_0 As Control = Me.nudLineStyle
			location = New Point(70, 68)
			arg_53B_0.Location = location
			Dim arg_571_0 As NumericUpDown = Me.nudLineStyle
			num = New Decimal(New Integer() { 300, 0, 0, 0 })
			arg_571_0.Maximum = num
			Me.nudLineStyle.Name = "nudLineStyle"
			Dim arg_598_0 As Control = Me.nudLineStyle
			size = New Size(40, 21)
			arg_598_0.Size = size
			Me.nudLineStyle.TabIndex = 74
			Dim arg_5BC_0 As Control = Me.Label6
			location = New Point(14, 68)
			arg_5BC_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_5E3_0 As Control = Me.Label6
			size = New Size(40, 16)
			arg_5E3_0.Size = size
			Me.Label6.TabIndex = 73
			Me.Label6.Text = "Style"
			Dim arg_617_0 As Control = Me.Label4
			location = New Point(14, 124)
			arg_617_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_63E_0 As Control = Me.Label4
			size = New Size(80, 16)
			arg_63E_0.Size = size
			Me.Label4.TabIndex = 72
			Me.Label4.Text = "DashValues:"
			Dim arg_675_0 As Control = Me.txtDashValues
			location = New Point(14, 140)
			arg_675_0.Location = location
			Me.txtDashValues.Name = "txtDashValues"
			Dim arg_69C_0 As Control = Me.txtDashValues
			size = New Size(88, 21)
			arg_69C_0.Size = size
			Me.txtDashValues.TabIndex = 71
			Me.txtHatchColor.BackColor = SystemColors.Highlight
			Me.txtHatchColor.ForeColor = SystemColors.HighlightText
			Dim arg_6E3_0 As Control = Me.txtHatchColor
			location = New Point(78, 220)
			arg_6E3_0.Location = location
			Me.txtHatchColor.Name = "txtHatchColor"
			Dim arg_70A_0 As Control = Me.txtHatchColor
			size = New Size(24, 21)
			arg_70A_0.Size = size
			Me.txtHatchColor.TabIndex = 67
			Me.txtBrushColor.BackColor = Color.Red
			Me.txtBrushColor.ForeColor = SystemColors.HighlightText
			Dim arg_751_0 As Control = Me.txtBrushColor
			location = New Point(78, 172)
			arg_751_0.Location = location
			Me.txtBrushColor.Name = "txtBrushColor"
			Dim arg_778_0 As Control = Me.txtBrushColor
			size = New Size(24, 21)
			arg_778_0.Size = size
			Me.txtBrushColor.TabIndex = 64
			Me.txtColor2.BackColor = SystemColors.Highlight
			Me.txtColor2.ForeColor = SystemColors.HighlightText
			Dim arg_7BC_0 As Control = Me.txtColor2
			location = New Point(54, 36)
			arg_7BC_0.Location = location
			Me.txtColor2.Name = "txtColor2"
			Dim arg_7E3_0 As Control = Me.txtColor2
			size = New Size(24, 21)
			arg_7E3_0.Size = size
			Me.txtColor2.TabIndex = 61
			Me.txtColor.BackColor = Color.Red
			Me.txtColor.ForeColor = SystemColors.HighlightText
			Dim arg_827_0 As Control = Me.txtColor
			location = New Point(54, 12)
			arg_827_0.Location = location
			Me.txtColor.Name = "txtColor"
			Dim arg_84E_0 As Control = Me.txtColor
			size = New Size(24, 21)
			arg_84E_0.Size = size
			Me.txtColor.TabIndex = 58
			Dim arg_875_0 As Control = Me.Label3
			location = New Point(14, 244)
			arg_875_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_89C_0 As Control = Me.Label3
			size = New Size(40, 16)
			arg_89C_0.Size = size
			Me.Label3.TabIndex = 70
			Me.Label3.Text = "HStyle"
			Dim arg_8D3_0 As Control = Me.Label2
			location = New Point(14, 220)
			arg_8D3_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_8FA_0 As Control = Me.Label2
			size = New Size(64, 16)
			arg_8FA_0.Size = size
			Me.Label2.TabIndex = 69
			Me.Label2.Text = "HatchColor:"
			Me.PictureBox1.BackColor = SystemColors.HighlightText
			Me.PictureBox1.BorderStyle = BorderStyle.Fixed3D
			Dim arg_94C_0 As Control = Me.PictureBox1
			location = New Point(6, 268)
			arg_94C_0.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_976_0 As Control = Me.PictureBox1
			size = New Size(112, 128)
			arg_976_0.Size = size
			Me.PictureBox1.TabIndex = 68
			Me.PictureBox1.TabStop = False
			Dim arg_9A9_0 As Control = Me.nudAlpha
			location = New Point(54, 196)
			arg_9A9_0.Location = location
			Dim arg_9DF_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_9DF_0.Maximum = num
			Me.nudAlpha.Name = "nudAlpha"
			Dim arg_A06_0 As Control = Me.nudAlpha
			size = New Size(48, 21)
			arg_A06_0.Size = size
			Me.nudAlpha.TabIndex = 66
			Dim arg_A49_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_A49_0.Value = num
			Dim arg_A63_0 As Control = Me.Label1
			location = New Point(14, 196)
			arg_A63_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_A8A_0 As Control = Me.Label1
			size = New Size(40, 16)
			arg_A8A_0.Size = size
			Me.Label1.TabIndex = 65
			Me.Label1.Text = "Alpha"
			Dim arg_AC1_0 As Control = Me.chkBrush
			location = New Point(14, 172)
			arg_AC1_0.Location = location
			Me.chkBrush.Name = "chkBrush"
			Dim arg_AE8_0 As Control = Me.chkBrush
			size = New Size(87, 24)
			arg_AE8_0.Size = size
			Me.chkBrush.TabIndex = 63
			Me.chkBrush.Text = "Fill color"
			Dim arg_B1C_0 As Control = Me.nudPenWidth2
			location = New Point(78, 36)
			arg_B1C_0.Location = location
			Dim arg_B4F_0 As NumericUpDown = Me.nudPenWidth2
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_B4F_0.Maximum = num
			Me.nudPenWidth2.Name = "nudPenWidth2"
			Dim arg_B76_0 As Control = Me.nudPenWidth2
			size = New Size(32, 21)
			arg_B76_0.Size = size
			Me.nudPenWidth2.TabIndex = 62
			Dim arg_B9A_0 As Control = Me.Label8
			location = New Point(14, 36)
			arg_B9A_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_BC1_0 As Control = Me.Label8
			size = New Size(32, 16)
			arg_BC1_0.Size = size
			Me.Label8.TabIndex = 60
			Me.Label8.Text = "Pen2:"
			Dim arg_BF5_0 As Control = Me.nudPenWidth
			location = New Point(78, 12)
			arg_BF5_0.Location = location
			Dim arg_C28_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_C28_0.Maximum = num
			Dim arg_C5A_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_C5A_0.Minimum = num
			Me.nudPenWidth.Name = "nudPenWidth"
			Dim arg_C81_0 As Control = Me.nudPenWidth
			size = New Size(32, 21)
			arg_C81_0.Size = size
			Me.nudPenWidth.TabIndex = 59
			Dim arg_CC0_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_CC0_0.Value = num
			Dim arg_CD7_0 As Control = Me.Label5
			location = New Point(14, 12)
			arg_CD7_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_CFE_0 As Control = Me.Label5
			size = New Size(32, 16)
			arg_CFE_0.Size = size
			Me.Label5.TabIndex = 57
			Me.Label5.Text = "Pen"
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(126, 449)
			Me.ClientSize = size
			Me.Controls.Add(Me.nudStyleWidth)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.nudHStyle)
			Me.Controls.Add(Me.nudLineStyle)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtDashValues)
			Me.Controls.Add(Me.txtHatchColor)
			Me.Controls.Add(Me.txtBrushColor)
			Me.Controls.Add(Me.txtColor2)
			Me.Controls.Add(Me.txtColor)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.nudAlpha)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.chkBrush)
			Me.Controls.Add(Me.nudPenWidth2)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.nudPenWidth)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChangeColor"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Change Color"
			Me.TableLayoutPanel1.ResumeLayout(False)
			(CType(Me.nudStyleWidth, ISupportInitialize)).EndInit()
			(CType(Me.nudHStyle, ISupportInitialize)).EndInit()
			(CType(Me.nudLineStyle, ISupportInitialize)).EndInit()
			(CType(Me.PictureBox1, ISupportInitialize)).EndInit()
			(CType(Me.nudAlpha, ISupportInitialize)).EndInit()
			(CType(Me.nudPenWidth2, ISupportInitialize)).EndInit()
			(CType(Me.nudPenWidth, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.OK
			Dim myObj As ShapeGraphic = Me.m_myObj
			myObj.LineColor = Me.txtColor.BackColor
			myObj.LineWidth = Convert.ToSingle(Me.nudPenWidth.Value)
			myObj.Line2Color = Me.txtColor2.BackColor
			myObj.Line2Width = Convert.ToSingle(Me.nudPenWidth2.Value)
			myObj.DValues = Me.txtDashValues.Text
			myObj.LineStyle = Convert.ToInt32(Me.nudLineStyle.Value)
			myObj.StyleWidth = Convert.ToSingle(Me.nudStyleWidth.Value)
			If Me.chkBrush.Checked Then
				myObj.Fill = True
				myObj.FillColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.txtBrushColor.BackColor)
				myObj.HatchColor = Me.txtHatchColor.BackColor
				myObj.HatchStyle = Convert.ToInt32(Me.nudHStyle.Value)
			Else
				myObj.Fill = False
			End If
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgChangeColor_Load(sender As Object, e As EventArgs)
			Dim myObj As ShapeGraphic = Me.m_myObj
			Me.txtColor.BackColor = myObj.LineColor
			Me.txtColor2.BackColor = myObj.Line2Color
			Me.txtDashValues.Text = myObj.DValues
			Me.nudPenWidth.Value = New Decimal(myObj.LineWidth)
			Me.nudPenWidth2.Value = New Decimal(myObj.Line2Width)
			Me.nudLineStyle.Value = New Decimal(myObj.LineStyle)
			Me.nudStyleWidth.Value = New Decimal(myObj.StyleWidth)
			Me.chkBrush.Checked = myObj.Fill
			If Me.chkBrush.Checked Then
				Me.txtBrushColor.BackColor = Color.FromArgb(255, CInt(myObj.FillColor.R), CInt(myObj.FillColor.G), CInt(myObj.FillColor.B))
				Me.nudAlpha.Value = New Decimal(CInt(myObj.FillColor.A))
				Me.txtHatchColor.BackColor = Color.FromArgb(255, CInt(myObj.HatchColor.R), CInt(myObj.HatchColor.G), CInt(myObj.HatchColor.B))
				Me.nudHStyle.Value = New Decimal(myObj.HatchStyle)
			End If
			Dim bounds As RectangleF = myObj.GetBounds()
			Me.m_Scale = 1F
			Me.AddNewObj()
			Me.nudHStyle.Maximum = New Decimal(52L)
			Me.ThuDoiTT()
		End Sub

		Private Function GetMau() As Color
			Dim colorDialog As ColorDialog = New ColorDialog()
			colorDialog.AllowFullOpen = True
			colorDialog.ShowHelp = True
			colorDialog.Color = Me.txtColor.BackColor
			colorDialog.ShowDialog()
			Return colorDialog.Color
		End Function

		Private Sub txtBrushColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtBrushColor.BackColor = Me.GetMau()
			Me.ThuDoiTT()
		End Sub

		Private Sub txtColor2_DoubleClick(sender As Object, e As EventArgs)
			Me.txtColor2.BackColor = Me.GetMau()
			Me.ThuDoiTT()
		End Sub

		Private Sub txtColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtColor.BackColor = Me.GetMau()
			Me.ThuDoiTT()
		End Sub

		Private Sub txtHStyle_TextChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub txtHatchColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtHatchColor.BackColor = Me.GetMau()
			Me.ThuDoiTT()
		End Sub

		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
		End Sub

		Private Sub AddNewObj()
			' The following expression was wrapped in a checked-expression
			Dim graphicObject As GraphicObject = New EllipseGraphic(15F, 10F, CSng((Me.PictureBox1.Width - 30)), CSng((Me.PictureBox1.Height - 20)), 0F) With { .LineWidth = 1F, .LineColor = Color.Red }
			If graphicObject IsNot Nothing Then
				Me.m_drawingObjects.Add(graphicObject)
			End If
		End Sub

		Private Sub nudLineStyle_ValueChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub ThuDoiTT()
			Try
				Dim enumerator As IEnumerator = Me.m_drawingObjects.GetEnumerator()
				While enumerator.MoveNext()
					Dim shapeGraphic As ShapeGraphic = CType(enumerator.Current, ShapeGraphic)
					Dim shapeGraphic2 As ShapeGraphic = shapeGraphic
					shapeGraphic2.LineStyle = Convert.ToInt32(Me.nudLineStyle.Value)
					shapeGraphic2.LineColor = Me.txtColor.BackColor
					shapeGraphic2.LineWidth = Convert.ToSingle(Me.nudPenWidth.Value)
					shapeGraphic2.Line2Color = Me.txtColor2.BackColor
					shapeGraphic2.Line2Width = Convert.ToSingle(Me.nudPenWidth2.Value)
					shapeGraphic2.DValues = Me.txtDashValues.Text
					shapeGraphic2.LineStyle = Convert.ToInt32(Me.nudLineStyle.Value)
					shapeGraphic2.StyleWidth = Convert.ToSingle(Me.nudStyleWidth.Value)
					If Me.chkBrush.Checked Then
						shapeGraphic2.Fill = True
						shapeGraphic2.FillColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.txtBrushColor.BackColor)
						shapeGraphic2.HatchColor = Me.txtHatchColor.BackColor
						shapeGraphic2.HatchStyle = Convert.ToInt32(Me.nudHStyle.Value)
					Else
						shapeGraphic2.Fill = False
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub nudPenWidth_ValueChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub nudAlpha_ValueChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub nudPenWidth2_ValueChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub txtDashValues_TextChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub txtBrushColor_BackColorChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub txtHatchColor_BackColorChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub txtColor_BackColorChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub txtColor2_BackColorChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub chkBrush_CheckedChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub nudHStyle_ValueChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub

		Private Sub nudStyleWidth_ValueChanged(sender As Object, e As EventArgs)
			Me.ThuDoiTT()
		End Sub
	End Class
End Namespace
