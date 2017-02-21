Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic
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
	Public Class dlgChangeSymbol
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		<AccessedThroughProperty("TabPage4")>
		Private _TabPage4 As TabPage

		<AccessedThroughProperty("picLineColor")>
		Private _picLineColor As PictureBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("lstLineColor")>
		Private _lstLineColor As ListBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("lstLineWidth")>
		Private _lstLineWidth As ListBox

		<AccessedThroughProperty("picFillColor")>
		Private _picFillColor As PictureBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("lstFillColor")>
		Private _lstFillColor As ListBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("lstLineStyle")>
		Private _lstLineStyle As ListBox

		<AccessedThroughProperty("nudLineWidth")>
		Private _nudLineWidth As NumericUpDown

		<AccessedThroughProperty("nudAlpha")>
		Private _nudAlpha As NumericUpDown

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("cboStyle")>
		Private _cboStyle As ComboBox

		Private MaxStyle As Integer

		Private ADStyles As Integer()

		Private m_Symbols As CSymbols

		Private AColors As Color()

		Private LineColor As Color

		Private AFillColors As Color()

		Private FillColor As Color

		Private AWidths As Integer()

		Private LineWidth As Integer

		Private AStyles As Integer()

		Private LineStyle As Integer

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

		Friend Overridable Property TabControl1() As TabControl
			Get
				Return Me._TabControl1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		Friend Overridable Property TabPage1() As TabPage
			Get
				Return Me._TabPage1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		Friend Overridable Property TabPage2() As TabPage
			Get
				Return Me._TabPage2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		Friend Overridable Property TabPage3() As TabPage
			Get
				Return Me._TabPage3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		Friend Overridable Property TabPage4() As TabPage
			Get
				Return Me._TabPage4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage4 = value
			End Set
		End Property

		Friend Overridable Property picLineColor() As PictureBox
			Get
				Return Me._picLineColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.picLineColor_Paint
				Dim value3 As EventHandler = AddressOf Me.picLineColor_DoubleClick
				If Me._picLineColor IsNot Nothing Then
					RemoveHandler Me._picLineColor.Paint, value2
					RemoveHandler Me._picLineColor.DoubleClick, value3
				End If
				Me._picLineColor = value
				If Me._picLineColor IsNot Nothing Then
					AddHandler Me._picLineColor.Paint, value2
					AddHandler Me._picLineColor.DoubleClick, value3
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

		Friend Overridable Property lstLineColor() As ListBox
			Get
				Return Me._lstLineColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As DrawItemEventHandler = AddressOf Me.lstLineColor_DrawItem
				If Me._lstLineColor IsNot Nothing Then
					RemoveHandler Me._lstLineColor.DrawItem, value2
				End If
				Me._lstLineColor = value
				If Me._lstLineColor IsNot Nothing Then
					AddHandler Me._lstLineColor.DrawItem, value2
				End If
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

		Friend Overridable Property lstLineWidth() As ListBox
			Get
				Return Me._lstLineWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As DrawItemEventHandler = AddressOf Me.lstLineWidth_DrawItem
				If Me._lstLineWidth IsNot Nothing Then
					RemoveHandler Me._lstLineWidth.DrawItem, value2
				End If
				Me._lstLineWidth = value
				If Me._lstLineWidth IsNot Nothing Then
					AddHandler Me._lstLineWidth.DrawItem, value2
				End If
			End Set
		End Property

		Friend Overridable Property picFillColor() As PictureBox
			Get
				Return Me._picFillColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.picFillColor_Paint
				Dim value3 As EventHandler = AddressOf Me.picFillColor_DoubleClick
				If Me._picFillColor IsNot Nothing Then
					RemoveHandler Me._picFillColor.Paint, value2
					RemoveHandler Me._picFillColor.DoubleClick, value3
				End If
				Me._picFillColor = value
				If Me._picFillColor IsNot Nothing Then
					AddHandler Me._picFillColor.Paint, value2
					AddHandler Me._picFillColor.DoubleClick, value3
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

		Friend Overridable Property lstFillColor() As ListBox
			Get
				Return Me._lstFillColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstFillColor_SelectedValueChanged
				Dim value3 As DrawItemEventHandler = AddressOf Me.lstFillColor_DrawItem
				If Me._lstFillColor IsNot Nothing Then
					RemoveHandler Me._lstFillColor.SelectedValueChanged, value2
					RemoveHandler Me._lstFillColor.DrawItem, value3
				End If
				Me._lstFillColor = value
				If Me._lstFillColor IsNot Nothing Then
					AddHandler Me._lstFillColor.SelectedValueChanged, value2
					AddHandler Me._lstFillColor.DrawItem, value3
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

		Friend Overridable Property lstLineStyle() As ListBox
			Get
				Return Me._lstLineStyle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As DrawItemEventHandler = AddressOf Me.lstLineStyle_DrawItem
				If Me._lstLineStyle IsNot Nothing Then
					RemoveHandler Me._lstLineStyle.DrawItem, value2
				End If
				Me._lstLineStyle = value
				If Me._lstLineStyle IsNot Nothing Then
					AddHandler Me._lstLineStyle.DrawItem, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudLineWidth() As NumericUpDown
			Get
				Return Me._nudLineWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudLineWidth = value
			End Set
		End Property

		Friend Overridable Property nudAlpha() As NumericUpDown
			Get
				Return Me._nudAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudAlpha = value
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

		Friend Overridable Property cboStyle() As ComboBox
			Get
				Return Me._cboStyle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As DrawItemEventHandler = AddressOf Me.cboStyle_DrawItem
				If Me._cboStyle IsNot Nothing Then
					RemoveHandler Me._cboStyle.DrawItem, value2
				End If
				Me._cboStyle = value
				If Me._cboStyle IsNot Nothing Then
					AddHandler Me._cboStyle.DrawItem, value2
				End If
			End Set
		End Property

		Public Property Symbols() As CSymbols
			Get
				Return Me.m_Symbols
			End Get
			Set(value As CSymbols)
				Me.m_Symbols = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgChangeSymbol_Load
			Me.MaxStyle = 8
			Me.LineColor = Color.Black
			Me.FillColor = Color.FromArgb(100, Color.Red)
			Me.LineWidth = 1
			Me.LineStyle = 0
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
			Me.TabControl1 = New TabControl()
			Me.TabPage1 = New TabPage()
			Me.picLineColor = New PictureBox()
			Me.Label1 = New Label()
			Me.lstLineColor = New ListBox()
			Me.TabPage2 = New TabPage()
			Me.nudLineWidth = New NumericUpDown()
			Me.Label2 = New Label()
			Me.lstLineWidth = New ListBox()
			Me.TabPage3 = New TabPage()
			Me.nudAlpha = New NumericUpDown()
			Me.Label5 = New Label()
			Me.Label3 = New Label()
			Me.picFillColor = New PictureBox()
			Me.lstFillColor = New ListBox()
			Me.TabPage4 = New TabPage()
			Me.lstLineStyle = New ListBox()
			Me.cboStyle = New ComboBox()
			Me.Label4 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.TabControl1.SuspendLayout()
			Me.TabPage1.SuspendLayout()
			(CType(Me.picLineColor, ISupportInitialize)).BeginInit()
			Me.TabPage2.SuspendLayout()
			(CType(Me.nudLineWidth, ISupportInitialize)).BeginInit()
			Me.TabPage3.SuspendLayout()
			(CType(Me.nudAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.picFillColor, ISupportInitialize)).BeginInit()
			Me.TabPage4.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_1FF_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(155, 250)
			arg_1FF_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_251_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_251_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_27E_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_27E_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_2A5_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_2A5_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_2EF_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_2EF_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_316_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_316_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Controls.Add(Me.TabPage3)
			Me.TabControl1.Controls.Add(Me.TabPage4)
			Dim arg_39F_0 As Control = Me.TabControl1
			location = New Point(8, 8)
			arg_39F_0.Location = location
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Dim arg_3D8_0 As Control = Me.TabControl1
			size = New Size(297, 229)
			arg_3D8_0.Size = size
			Me.TabControl1.TabIndex = 1
			Me.TabPage1.Controls.Add(Me.picLineColor)
			Me.TabPage1.Controls.Add(Me.Label1)
			Me.TabPage1.Controls.Add(Me.lstLineColor)
			Dim arg_43C_0 As TabPage = Me.TabPage1
			location = New Point(4, 22)
			arg_43C_0.Location = location
			Me.TabPage1.Name = "TabPage1"
			Dim arg_461_0 As Control = Me.TabPage1
			Dim padding As Padding = New Padding(3)
			arg_461_0.Padding = padding
			Dim arg_47E_0 As Control = Me.TabPage1
			size = New Size(289, 203)
			arg_47E_0.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "M" & ChrW(7847) & "u nét v" & ChrW(7869)
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.picLineColor.BackColor = SystemColors.ActiveCaptionText
			Me.picLineColor.BorderStyle = BorderStyle.Fixed3D
			Dim arg_4DC_0 As Control = Me.picLineColor
			location = New Point(191, 63)
			arg_4DC_0.Location = location
			Me.picLineColor.Name = "picLineColor"
			Dim arg_503_0 As Control = Me.picLineColor
			size = New Size(30, 25)
			arg_503_0.Size = size
			Me.picLineColor.TabIndex = 2
			Me.picLineColor.TabStop = False
			Me.Label1.AutoSize = True
			Dim arg_541_0 As Control = Me.Label1
			location = New Point(153, 67)
			arg_541_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_568_0 As Control = Me.Label1
			size = New Size(15, 13)
			arg_568_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "="
			Me.lstLineColor.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstLineColor.FormattingEnabled = True
			Me.lstLineColor.ItemHeight = 20
			Dim arg_5BE_0 As Control = Me.lstLineColor
			location = New Point(8, 8)
			arg_5BE_0.Location = location
			Me.lstLineColor.Name = "lstLineColor"
			Me.lstLineColor.SelectionMode = SelectionMode.MultiSimple
			Dim arg_5F7_0 As Control = Me.lstLineColor
			size = New Size(128, 184)
			arg_5F7_0.Size = size
			Me.lstLineColor.TabIndex = 0
			Me.TabPage2.Controls.Add(Me.nudLineWidth)
			Me.TabPage2.Controls.Add(Me.Label2)
			Me.TabPage2.Controls.Add(Me.lstLineWidth)
			Dim arg_65B_0 As TabPage = Me.TabPage2
			location = New Point(4, 22)
			arg_65B_0.Location = location
			Me.TabPage2.Name = "TabPage2"
			Dim arg_680_0 As Control = Me.TabPage2
			padding = New Padding(3)
			arg_680_0.Padding = padding
			Dim arg_69D_0 As Control = Me.TabPage2
			size = New Size(289, 203)
			arg_69D_0.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = ChrW(272) & ChrW(7897) & " d" & ChrW(7847) & "y nét"
			Me.TabPage2.UseVisualStyleBackColor = True
			Dim arg_6DF_0 As Control = Me.nudLineWidth
			location = New Point(198, 62)
			arg_6DF_0.Location = location
			Dim arg_712_0 As NumericUpDown = Me.nudLineWidth
			Dim num As Decimal = New Decimal(New Integer() { 36, 0, 0, 0 })
			arg_712_0.Maximum = num
			Me.nudLineWidth.Name = "nudLineWidth"
			Dim arg_739_0 As Control = Me.nudLineWidth
			size = New Size(41, 21)
			arg_739_0.Size = size
			Me.nudLineWidth.TabIndex = 5
			Me.Label2.AutoSize = True
			Dim arg_76B_0 As Control = Me.Label2
			location = New Point(166, 67)
			arg_76B_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_792_0 As Control = Me.Label2
			size = New Size(15, 13)
			arg_792_0.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "="
			Me.lstLineWidth.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstLineWidth.FormattingEnabled = True
			Me.lstLineWidth.ItemHeight = 20
			Dim arg_7E8_0 As Control = Me.lstLineWidth
			location = New Point(8, 8)
			arg_7E8_0.Location = location
			Me.lstLineWidth.Name = "lstLineWidth"
			Me.lstLineWidth.SelectionMode = SelectionMode.MultiSimple
			Dim arg_821_0 As Control = Me.lstLineWidth
			size = New Size(128, 184)
			arg_821_0.Size = size
			Me.lstLineWidth.TabIndex = 3
			Me.TabPage3.Controls.Add(Me.nudAlpha)
			Me.TabPage3.Controls.Add(Me.Label5)
			Me.TabPage3.Controls.Add(Me.Label3)
			Me.TabPage3.Controls.Add(Me.picFillColor)
			Me.TabPage3.Controls.Add(Me.lstFillColor)
			Dim arg_8B1_0 As TabPage = Me.TabPage3
			location = New Point(4, 22)
			arg_8B1_0.Location = location
			Me.TabPage3.Name = "TabPage3"
			Dim arg_8DE_0 As Control = Me.TabPage3
			size = New Size(289, 203)
			arg_8DE_0.Size = size
			Me.TabPage3.TabIndex = 2
			Me.TabPage3.Text = "M" & ChrW(7847) & "u tô"
			Me.TabPage3.UseVisualStyleBackColor = True
			Dim arg_920_0 As Control = Me.nudAlpha
			location = New Point(204, 100)
			arg_920_0.Location = location
			Dim arg_956_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_956_0.Maximum = num
			Me.nudAlpha.Name = "nudAlpha"
			Dim arg_97D_0 As Control = Me.nudAlpha
			size = New Size(45, 21)
			arg_97D_0.Size = size
			Me.nudAlpha.TabIndex = 7
			Dim arg_9BF_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_9BF_0.Value = num
			Me.Label5.AutoSize = True
			Dim arg_9E5_0 As Control = Me.Label5
			location = New Point(157, 102)
			arg_9E5_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_A0C_0 As Control = Me.Label5
			size = New Size(42, 13)
			arg_A0C_0.Size = size
			Me.Label5.TabIndex = 6
			Me.Label5.Text = ChrW(272) & ChrW(7897) & " m" & ChrW(7901) & ":"
			Me.Label3.AutoSize = True
			Dim arg_A4E_0 As Control = Me.Label3
			location = New Point(166, 67)
			arg_A4E_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_A75_0 As Control = Me.Label3
			size = New Size(15, 13)
			arg_A75_0.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "="
			Me.picFillColor.BackColor = SystemColors.ActiveCaptionText
			Me.picFillColor.BorderStyle = BorderStyle.Fixed3D
			Dim arg_AC7_0 As Control = Me.picFillColor
			location = New Point(204, 63)
			arg_AC7_0.Location = location
			Me.picFillColor.Name = "picFillColor"
			Dim arg_AEE_0 As Control = Me.picFillColor
			size = New Size(30, 25)
			arg_AEE_0.Size = size
			Me.picFillColor.TabIndex = 5
			Me.picFillColor.TabStop = False
			Me.lstFillColor.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstFillColor.FormattingEnabled = True
			Me.lstFillColor.ItemHeight = 20
			Dim arg_B40_0 As Control = Me.lstFillColor
			location = New Point(8, 8)
			arg_B40_0.Location = location
			Me.lstFillColor.Name = "lstFillColor"
			Me.lstFillColor.SelectionMode = SelectionMode.MultiSimple
			Dim arg_B79_0 As Control = Me.lstFillColor
			size = New Size(128, 184)
			arg_B79_0.Size = size
			Me.lstFillColor.TabIndex = 3
			Me.TabPage4.Controls.Add(Me.lstLineStyle)
			Me.TabPage4.Controls.Add(Me.cboStyle)
			Me.TabPage4.Controls.Add(Me.Label4)
			Dim arg_BDD_0 As TabPage = Me.TabPage4
			location = New Point(4, 22)
			arg_BDD_0.Location = location
			Me.TabPage4.Name = "TabPage4"
			Dim arg_C0A_0 As Control = Me.TabPage4
			size = New Size(289, 203)
			arg_C0A_0.Size = size
			Me.TabPage4.TabIndex = 3
			Me.TabPage4.Text = "Ki" & ChrW(7875) & "u nét"
			Me.TabPage4.UseVisualStyleBackColor = True
			Me.lstLineStyle.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstLineStyle.FormattingEnabled = True
			Me.lstLineStyle.ItemHeight = 30
			Dim arg_C6C_0 As Control = Me.lstLineStyle
			location = New Point(8, 8)
			arg_C6C_0.Location = location
			Me.lstLineStyle.Name = "lstLineStyle"
			Me.lstLineStyle.SelectionMode = SelectionMode.MultiSimple
			Dim arg_CA2_0 As Control = Me.lstLineStyle
			size = New Size(120, 184)
			arg_CA2_0.Size = size
			Me.lstLineStyle.TabIndex = 3
			Me.cboStyle.DrawMode = DrawMode.OwnerDrawFixed
			Me.cboStyle.DropDownHeight = 136
			Me.cboStyle.FormattingEnabled = True
			Me.cboStyle.IntegralHeight = False
			Me.cboStyle.ItemHeight = 30
			Dim arg_D09_0 As Control = Me.cboStyle
			location = New Point(145, 65)
			arg_D09_0.Location = location
			Me.cboStyle.Name = "cboStyle"
			Dim arg_D33_0 As Control = Me.cboStyle
			size = New Size(136, 36)
			arg_D33_0.Size = size
			Me.cboStyle.TabIndex = 5
			Me.Label4.AutoSize = True
			Dim arg_D65_0 As Control = Me.Label4
			location = New Point(133, 65)
			arg_D65_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_D8C_0 As Control = Me.Label4
			size = New Size(15, 13)
			arg_D8C_0.Size = size
			Me.Label4.TabIndex = 4
			Me.Label4.Text = "="
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(313, 291)
			Me.ClientSize = size
			Me.Controls.Add(Me.TabControl1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChangeSymbol"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = ChrW(272) & ChrW(7893) & "i các thu" & ChrW(7897) & "c tính"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.TabControl1.ResumeLayout(False)
			Me.TabPage1.ResumeLayout(False)
			Me.TabPage1.PerformLayout()
			(CType(Me.picLineColor, ISupportInitialize)).EndInit()
			Me.TabPage2.ResumeLayout(False)
			Me.TabPage2.PerformLayout()
			(CType(Me.nudLineWidth, ISupportInitialize)).EndInit()
			Me.TabPage3.ResumeLayout(False)
			Me.TabPage3.PerformLayout()
			(CType(Me.nudAlpha, ISupportInitialize)).EndInit()
			(CType(Me.picFillColor, ISupportInitialize)).EndInit()
			Me.TabPage4.ResumeLayout(False)
			Me.TabPage4.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private Sub Change1Color(SColor As Color, DColor As Color)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = cSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim graphicObject As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case graphicObject.GetObjType()
								Case OBJECTTYPE.Text
									Dim textGraphic As TextGraphic = CType(graphicObject, TextGraphic)
									If textGraphic.Color.ToArgb() = SColor.ToArgb() Then
										textGraphic.Color = DColor
									End If
								Case OBJECTTYPE.Table
									Dim tableGraphic As TableGraphic = CType(graphicObject, TableGraphic)
									If tableGraphic.BorderColor.ToArgb() = SColor.ToArgb() Then
										tableGraphic.BorderColor = DColor
									End If
									If tableGraphic.LineColor.ToArgb() = SColor.ToArgb() Then
										tableGraphic.LineColor = DColor
									End If
									Try
										Dim enumerator3 As IEnumerator = tableGraphic.Cells.GetEnumerator()
										While enumerator3.MoveNext()
											Dim cCell As CCell = CType(enumerator3.Current, CCell)
											If cCell.Color.ToArgb() = SColor.ToArgb() Then
												cCell.Color = DColor
											End If
										End While
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											(TryCast(enumerator3, IDisposable)).Dispose()
										End If
									End Try
								Case Else
									Dim shapeGraphic As ShapeGraphic = CType(graphicObject, ShapeGraphic)
									If shapeGraphic.LineColor.ToArgb() = SColor.ToArgb() Then
										shapeGraphic.LineColor = DColor
									End If
									If shapeGraphic.Line2Color.ToArgb() = SColor.ToArgb() Then
										shapeGraphic.Line2Color = DColor
									End If
									If shapeGraphic.HatchColor.ToArgb() = SColor.ToArgb() Then
										shapeGraphic.HatchColor = DColor
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Change1FillColor(SColor As Color, DColor As Color)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = cSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim graphicObject As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case graphicObject.GetObjType()
								Case OBJECTTYPE.Text
								Case OBJECTTYPE.Table
									Dim tableGraphic As TableGraphic = CType(graphicObject, TableGraphic)
									If tableGraphic.FiColor.ToArgb() = SColor.ToArgb() Then
										tableGraphic.FiColor = DColor
									End If
								Case Else
									Dim shapeGraphic As ShapeGraphic = CType(graphicObject, ShapeGraphic)
									If shapeGraphic.FillColor.ToArgb() = SColor.ToArgb() Then
										shapeGraphic.FillColor = DColor
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Change1Style(SStyle As Integer, DStyle As Integer)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = cSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim graphicObject As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case graphicObject.GetObjType()
								Case OBJECTTYPE.Text
								Case OBJECTTYPE.Table
								Case Else
									Dim shapeGraphic As ShapeGraphic = CType(graphicObject, ShapeGraphic)
									If shapeGraphic.LineStyle = SStyle Then
										shapeGraphic.LineStyle = DStyle
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Change1Width(SWidth As Integer, DWidth As Integer)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = cSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim graphicObject As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case graphicObject.GetObjType()
								Case OBJECTTYPE.Text
								Case OBJECTTYPE.Table
								Case Else
									Dim shapeGraphic As ShapeGraphic = CType(graphicObject, ShapeGraphic)
									If shapeGraphic.LineWidth = CSng(SWidth) Then
										If DWidth > 0 Then
											shapeGraphic.LineWidth = CSng(DWidth)
										Else
											shapeGraphic.LineWidth = 1F
										End If
									End If
									If shapeGraphic.Line2Width = CSng(SWidth) Then
										shapeGraphic.Line2Width = CSng(DWidth)
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.lstLineColor.SelectedItems.Count + Me.lstFillColor.SelectedItems.Count + Me.lstLineWidth.SelectedItems.Count + Me.lstLineStyle.SelectedItems.Count > 0 Then
				myModule.fMain.myBando.PopUndo()
				Dim color As Color
				If Me.lstLineColor.SelectedItems.Count > 0 Then
					Dim arg_80_0 As Integer = 0
					Dim num As Integer = Me.lstLineColor.SelectedItems.Count - 1
					For i As Integer = arg_80_0 To num
						Dim expr_94 As Object = Me.lstLineColor.SelectedItems(i)
						Dim sColor As Color = If((expr_94 IsNot Nothing), (CType(expr_94, Color)), color)
						Me.Change1Color(sColor, Me.LineColor)
					Next
				End If
				If Me.lstFillColor.SelectedItems.Count > 0 Then
					Me.FillColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.FillColor)
					Dim arg_106_0 As Integer = 0
					Dim num2 As Integer = Me.lstFillColor.SelectedItems.Count - 1
					For j As Integer = arg_106_0 To num2
						Dim expr_11A As Object = Me.lstFillColor.SelectedItems(j)
						Dim sColor2 As Color = If((expr_11A IsNot Nothing), (CType(expr_11A, Color)), color)
						Me.Change1FillColor(sColor2, Me.FillColor)
					Next
				End If
				If Me.lstLineStyle.SelectedItems.Count > 0 Then
					Dim arg_16B_0 As Integer = 0
					Dim num3 As Integer = Me.lstLineStyle.SelectedItems.Count - 1
					For k As Integer = arg_16B_0 To num3
						Dim sStyle As Integer = Conversions.ToInteger(Me.lstLineStyle.SelectedItems(k))
						Me.Change1Style(sStyle, CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.cboStyle.SelectedItem)))))
					Next
				End If
				If Me.lstLineWidth.SelectedItems.Count > 0 Then
					Dim arg_1DF_0 As Integer = 0
					Dim num4 As Integer = Me.lstLineWidth.SelectedItems.Count - 1
					For l As Integer = arg_1DF_0 To num4
						Dim sWidth As Integer = Conversions.ToInteger(Me.lstLineWidth.SelectedItems(l))
						Me.Change1Width(sWidth, Convert.ToInt32(Me.nudLineWidth.Value))
					Next
				End If
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Interaction.MsgBox("Ch" & ChrW(432) & "a ch" & ChrW(7885) & "n cái c" & ChrW(7847) & "n " & ChrW(273) & ChrW(7893) & "i.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub PopulationLists()
			Me.AColors = New Color(-1) {}
			Dim num As Integer = -1
			Me.AFillColors = New Color(-1) {}
			Dim num2 As Integer = -1
			Me.AWidths = New Integer(-1) {}
			Dim num3 As Integer = -1
			Me.AStyles = New Integer(-1) {}
			Dim num4 As Integer = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = cSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim graphicObject As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case graphicObject.GetObjType()
								Case OBJECTTYPE.Text
									Dim textGraphic As TextGraphic = CType(graphicObject, TextGraphic)
									If Me.IsNewColor(textGraphic.Color) Then
										num += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
										Me.AColors(num) = textGraphic.Color
									End If
								Case OBJECTTYPE.Table
									Dim tableGraphic As TableGraphic = CType(graphicObject, TableGraphic)
									If Me.IsNewColor(tableGraphic.BorderColor) Then
										num += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
										Me.AColors(num) = tableGraphic.BorderColor
									End If
									If Me.IsNewColor(tableGraphic.LineColor) Then
										num += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
										Me.AColors(num) = tableGraphic.LineColor
									End If
									Try
										Dim enumerator3 As IEnumerator = tableGraphic.Cells.GetEnumerator()
										While enumerator3.MoveNext()
											Dim cCell As CCell = CType(enumerator3.Current, CCell)
											If Me.IsNewColor(cCell.Color) Then
												num += 1
												Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
												Me.AColors(num) = cCell.Color
											End If
										End While
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											(TryCast(enumerator3, IDisposable)).Dispose()
										End If
									End Try
									If Me.IsNewFillColor(tableGraphic.FiColor) Then
										num2 += 1
										Me.AFillColors = CType(Utils.CopyArray(CType(Me.AFillColors, Array), New Color(num2 + 1 - 1) {}), Color())
										Me.AFillColors(num2) = tableGraphic.FiColor
									End If
									If Me.IsNewWidth(tableGraphic.LineWidth) Then
										num3 += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(num3 + 1 - 1) {}), Integer())
										Me.AWidths(num3) = tableGraphic.LineWidth
									End If
									If Me.IsNewWidth(tableGraphic.BorderWidth) Then
										num3 += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(num3 + 1 - 1) {}), Integer())
										Me.AWidths(num3) = tableGraphic.BorderWidth
									End If
								Case Else
									Dim shapeGraphic As ShapeGraphic = CType(graphicObject, ShapeGraphic)
									If Me.IsNewColor(shapeGraphic.LineColor) Then
										num += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
										Me.AColors(num) = shapeGraphic.LineColor
									End If
									If shapeGraphic.Line2Width > 0F AndAlso Me.IsNewColor(shapeGraphic.Line2Color) Then
										num += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
										Me.AColors(num) = shapeGraphic.Line2Color
									End If
									If shapeGraphic.Fill Then
										If Me.IsNewFillColor(shapeGraphic.FillColor) Then
											num2 += 1
											Me.AFillColors = CType(Utils.CopyArray(CType(Me.AFillColors, Array), New Color(num2 + 1 - 1) {}), Color())
											Me.AFillColors(num2) = shapeGraphic.FillColor
										End If
										If Me.IsNewColor(shapeGraphic.HatchColor) Then
											num += 1
											Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(num + 1 - 1) {}), Color())
											Me.AColors(num) = shapeGraphic.HatchColor
										End If
									End If
									If Me.IsNewWidth(CInt(Math.Round(CDec(shapeGraphic.LineWidth)))) Then
										num3 += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(num3 + 1 - 1) {}), Integer())
										Me.AWidths(num3) = CInt(Math.Round(CDec(shapeGraphic.LineWidth)))
									End If
									If Me.IsNewWidth(CInt(Math.Round(CDec(shapeGraphic.Line2Width)))) Then
										num3 += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(num3 + 1 - 1) {}), Integer())
										Me.AWidths(num3) = CInt(Math.Round(CDec(shapeGraphic.Line2Width)))
									End If
									If Me.IsNewStyle(shapeGraphic.LineStyle) Then
										num4 += 1
										Me.AStyles = CType(Utils.CopyArray(CType(Me.AStyles, Array), New Integer(num4 + 1 - 1) {}), Integer())
										Me.AStyles(num4) = shapeGraphic.LineStyle
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim arg_59D_0 As Integer = 0
			Dim upperBound As Integer = Me.AColors.GetUpperBound(0)
			For i As Integer = arg_59D_0 To upperBound
				Me.lstLineColor.Items.Add(Me.AColors(i))
			Next
			Dim arg_5E4_0 As Integer = 0
			Dim upperBound2 As Integer = Me.AFillColors.GetUpperBound(0)
			For j As Integer = arg_5E4_0 To upperBound2
				Me.lstFillColor.Items.Add(Me.AFillColors(j))
			Next
			Dim arg_62B_0 As Integer = 0
			Dim upperBound3 As Integer = Me.AWidths.GetUpperBound(0)
			For k As Integer = arg_62B_0 To upperBound3
				Me.lstLineWidth.Items.Add(Me.AWidths(k))
			Next
			Dim arg_669_0 As Integer = 0
			Dim upperBound4 As Integer = Me.AStyles.GetUpperBound(0)
			For l As Integer = arg_669_0 To upperBound4
				Me.lstLineStyle.Items.Add(Me.AStyles(l))
			Next
		End Sub

		Private Function IsNewColor(pColor As Color) As Boolean
			Dim arg_0E_0 As Integer = 0
			Dim upperBound As Integer = Me.AColors.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			For i As Integer = arg_0E_0 To upperBound
				If pColor.ToArgb() = Me.AColors(i).ToArgb() Then
					result = False
					Return result
				End If
			Next
			result = True
			Return result
		End Function

		Private Function IsNewFillColor(pColor As Color) As Boolean
			Dim arg_0E_0 As Integer = 0
			Dim upperBound As Integer = Me.AFillColors.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			For i As Integer = arg_0E_0 To upperBound
				If pColor.ToArgb() = Me.AFillColors(i).ToArgb() Then
					result = False
					Return result
				End If
			Next
			result = True
			Return result
		End Function

		Private Function IsNewWidth(pWidth As Integer) As Boolean
			Dim arg_0E_0 As Integer = 0
			Dim upperBound As Integer = Me.AWidths.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			For i As Integer = arg_0E_0 To upperBound
				If pWidth = Me.AWidths(i) Then
					result = False
					Return result
				End If
			Next
			result = True
			Return result
		End Function

		Private Function IsNewStyle(pStyle As Integer) As Boolean
			Dim arg_0E_0 As Integer = 0
			Dim upperBound As Integer = Me.AStyles.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			For i As Integer = arg_0E_0 To upperBound
				If pStyle = Me.AStyles(i) Then
					result = False
					Return result
				End If
			Next
			result = True
			Return result
		End Function

		Private Sub dlgChangeSymbol_Load(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Me.ADStyles = New Integer(Me.MaxStyle + 1 - 1) {}
			Dim arg_21_0 As Integer = 0
			Dim upperBound As Integer = Me.ADStyles.GetUpperBound(0)
			For i As Integer = arg_21_0 To upperBound
				Me.ADStyles(i) = i
				Me.cboStyle.Items.Add(Me.ADStyles(i))
			Next
			Me.PopulationLists()
			Me.cboStyle.SelectedIndex = 0
		End Sub

		Private Sub lstLineColor_DrawItem(sender As Object, e As DrawItemEventArgs)
			Dim brush As Brush = Nothing
			' The following expression was wrapped in a checked-statement
			Try
				Dim brush2 As Brush
				If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
					brush2 = Brushes.White
				Else
					brush2 = Brushes.Black
				End If
				e.DrawBackground()
				Dim rect As Rectangle = New Rectangle(e.Bounds.X + 5, e.Bounds.Y + 5, 15, 10)
				Dim black As Pen = Pens.Black
				brush = New SolidBrush(Me.AColors(e.Index))
				e.Graphics.DrawRectangle(black, rect)
				e.Graphics.FillRectangle(brush, rect)
				e.Graphics.DrawString(String.Concat(New String() { Me.AColors(e.Index).R.ToString(), ",", Me.AColors(e.Index).G.ToString(), ",", Me.AColors(e.Index).B.ToString() }), Me.lstLineColor.Font, brush2, CSng((rect.Left + rect.Width + 5)), CSng(e.Bounds.Y))
				e.DrawFocusRectangle()
			Catch expr_155 As Exception
				ProjectData.SetProjectError(expr_155)
				ProjectData.ClearProjectError()
			Finally
				If brush IsNot Nothing Then
					brush.Dispose()
				End If
			End Try
		End Sub

		Private Sub picLineColor_DoubleClick(sender As Object, e As EventArgs)
			Me.LineColor = modBdTC.GetMau(Me.LineColor)
			Me.picLineColor.Invalidate()
		End Sub

		Private Sub picFillColor_DoubleClick(sender As Object, e As EventArgs)
			Me.FillColor = modBdTC.GetMau(Me.FillColor)
			Me.FillColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.FillColor)
			Me.picFillColor.Invalidate()
		End Sub

		Private Sub picFillColor_Paint(sender As Object, e As PaintEventArgs)
			Dim rectangle As Rectangle = New Rectangle(5, 5, 15, 10)
			Dim black As Pen = Pens.Black
			Dim obj As Object = New SolidBrush(Color.FromArgb(255, CInt(Me.FillColor.R), CInt(Me.FillColor.G), CInt(Me.FillColor.B)))
			e.Graphics.DrawRectangle(black, rectangle)
			Dim arg_92_0 As Object = e.Graphics
			Dim arg_92_1 As Type = Nothing
			Dim arg_92_2 As String = "FillRectangle"
			Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj), rectangle }
			Dim arg_92_3 As Object() = array
			Dim arg_92_4 As String() = Nothing
			Dim arg_92_5 As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True, True }
			NewLateBinding.LateCall(arg_92_0, arg_92_1, arg_92_2, arg_92_3, arg_92_4, arg_92_5, array2, True)
			If array2(0) Then
				obj = RuntimeHelpers.GetObjectValue(array(0))
			End If
			If array2(1) Then
				rectangle = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Rectangle)), Rectangle)
			End If
		End Sub

		Private Sub lstFillColor_DrawItem(sender As Object, e As DrawItemEventArgs)
			Dim brush As Brush = Nothing
			' The following expression was wrapped in a checked-statement
			Try
				Dim brush2 As Brush
				If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
					brush2 = Brushes.White
				Else
					brush2 = Brushes.Black
				End If
				e.DrawBackground()
				Dim rect As Rectangle = New Rectangle(e.Bounds.X + 5, e.Bounds.Y + 5, 15, 10)
				Dim black As Pen = Pens.Black
				brush = New SolidBrush(Me.AFillColors(e.Index))
				e.Graphics.DrawRectangle(black, rect)
				e.Graphics.FillRectangle(brush, rect)
				e.Graphics.DrawString(String.Concat(New String() { Me.AFillColors(e.Index).R.ToString(), ",", Me.AFillColors(e.Index).G.ToString(), ",", Me.AFillColors(e.Index).B.ToString(), "|", Me.AFillColors(e.Index).A.ToString() }), Me.lstFillColor.Font, brush2, CSng((rect.Left + rect.Width + 5)), CSng(e.Bounds.Y))
				e.DrawFocusRectangle()
			Catch expr_181 As Exception
				ProjectData.SetProjectError(expr_181)
				ProjectData.ClearProjectError()
			Finally
				If brush IsNot Nothing Then
					brush.Dispose()
				End If
			End Try
		End Sub

		Private Sub lstFillColor_SelectedValueChanged(sender As Object, e As EventArgs)
			If Me.lstFillColor.SelectedItems.Count > 0 Then
				' The following expression was wrapped in a checked-expression
				Dim expr_36 As Object = Me.lstFillColor.SelectedItems(Me.lstFillColor.SelectedItems.Count - 1)
				Dim color As Color
				Me.FillColor = (If((expr_36 IsNot Nothing), (CType(expr_36, Color)), color))
				Me.nudAlpha.Value = New Decimal(CInt(Me.FillColor.A))
				Me.picFillColor.Invalidate()
			End If
		End Sub

		Private Sub lstLineStyle_DrawItem(sender As Object, e As DrawItemEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim brush As Brush
				If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
					brush = Brushes.White
				Else
					brush = Brushes.Black
				End If
				e.DrawBackground()
				e.Graphics.DrawString(Me.AStyles(e.Index).ToString(), Me.lstLineStyle.Font, brush, CSng((e.Bounds.X + 5)), CSng((e.Bounds.Y + 10)))
				Me.m_drawingObjects = Me.GetLineObj(CSng((e.Bounds.X + 20)), CSng((e.Bounds.Y + 20)), CSng((e.Bounds.X + e.Bounds.Width - 5)), CSng((e.Bounds.Y + 20)), 1, Me.AStyles(e.Index))
				Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
				e.DrawFocusRectangle()
			Catch expr_101 As Exception
				ProjectData.SetProjectError(expr_101)
				ProjectData.ClearProjectError()
			Finally
			End Try
		End Sub

		Private Function GetLineObj(x1 As Single, y1 As Single, x2 As Single, y2 As Single, width As Integer, style As Integer) As CGraphicObjs
			Dim cGraphicObjs As CGraphicObjs = New CGraphicObjs()
			Dim array As PointF() = New PointF(1) {}
			array(0).X = x1
			array(0).Y = y1
			array(1).X = x2
			array(1).Y = y2
			Dim graphicObject As GraphicObject = New LinesGraphic(array, 1F, Color.Red) With { .LineStyle = style, .StyleWidth = 10F, .LineWidth = CSng(width) }
			If graphicObject IsNot Nothing Then
				cGraphicObjs.Add(graphicObject)
			End If
			Return cGraphicObjs
		End Function

		Private Sub lstLineWidth_DrawItem(sender As Object, e As DrawItemEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim brush As Brush
				If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
					brush = Brushes.White
				Else
					brush = Brushes.Black
				End If
				e.DrawBackground()
				e.Graphics.DrawString(Me.AWidths(e.Index).ToString(), Me.lstLineWidth.Font, brush, CSng((e.Bounds.X + 5)), CSng(e.Bounds.Y))
				Me.m_drawingObjects = Me.GetLineObj(CSng((e.Bounds.X + 20)), CSng((e.Bounds.Y + 10)), CSng((e.Bounds.X + e.Bounds.Width - 25)), CSng((e.Bounds.Y + 10)), Me.AWidths(e.Index), 0)
				Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
				e.DrawFocusRectangle()
			Catch expr_100 As Exception
				ProjectData.SetProjectError(expr_100)
				ProjectData.ClearProjectError()
			Finally
			End Try
		End Sub

		Private Sub cboStyle_DrawItem(sender As Object, e As DrawItemEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim brush As Brush
				If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
					brush = Brushes.White
				Else
					brush = Brushes.Black
				End If
				e.DrawBackground()
				e.Graphics.DrawString(Me.ADStyles(e.Index).ToString(), Me.cboStyle.Font, brush, CSng((e.Bounds.X + 5)), CSng((e.Bounds.Y + 10)))
				Me.m_drawingObjects = Me.GetLineObj(CSng((e.Bounds.X + 20)), CSng((e.Bounds.Y + 20)), CSng((e.Bounds.X + e.Bounds.Width - 5)), CSng((e.Bounds.Y + 20)), 1, Me.ADStyles(e.Index))
				Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
				e.DrawFocusRectangle()
			Catch expr_101 As Exception
				ProjectData.SetProjectError(expr_101)
				ProjectData.ClearProjectError()
			Finally
			End Try
		End Sub

		Private Sub picLineColor_Paint(sender As Object, e As PaintEventArgs)
			Dim rectangle As Rectangle = New Rectangle(5, 5, 15, 10)
			Dim black As Pen = Pens.Black
			Dim obj As Object = New SolidBrush(Me.LineColor)
			e.Graphics.DrawRectangle(black, rectangle)
			Dim arg_6D_0 As Object = e.Graphics
			Dim arg_6D_1 As Type = Nothing
			Dim arg_6D_2 As String = "FillRectangle"
			Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(obj), rectangle }
			Dim arg_6D_3 As Object() = array
			Dim arg_6D_4 As String() = Nothing
			Dim arg_6D_5 As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True, True }
			NewLateBinding.LateCall(arg_6D_0, arg_6D_1, arg_6D_2, arg_6D_3, arg_6D_4, arg_6D_5, array2, True)
			If array2(0) Then
				obj = RuntimeHelpers.GetObjectValue(array(0))
			End If
			If array2(1) Then
				rectangle = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Rectangle)), Rectangle)
			End If
		End Sub
	End Class
End Namespace
