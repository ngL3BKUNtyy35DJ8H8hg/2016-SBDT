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

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgChangeSymbol
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		Friend Overridable Property TabControl1() As TabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._TabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		Friend Overridable Property TabPage1() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		Friend Overridable Property TabPage2() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		Friend Overridable Property TabPage3() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		Friend Overridable Property TabPage4() As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage4 = value
			End Set
		End Property

		Friend Overridable Property picLineColor() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._picLineColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim flag As Boolean = Me._picLineColor IsNot Nothing
				If flag Then
					RemoveHandler Me._picLineColor.DoubleClick, AddressOf Me.picLineColor_DoubleClick
					RemoveHandler Me._picLineColor.Paint, AddressOf Me.picLineColor_Paint
				End If
				Me._picLineColor = value
				flag = (Me._picLineColor IsNot Nothing)
				If flag Then
					AddHandler Me._picLineColor.DoubleClick, AddressOf Me.picLineColor_DoubleClick
					AddHandler Me._picLineColor.Paint, AddressOf Me.picLineColor_Paint
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

		Friend Overridable Property lstLineColor() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstLineColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstLineColor IsNot Nothing
				If flag Then
					RemoveHandler Me._lstLineColor.DrawItem, AddressOf Me.lstLineColor_DrawItem
				End If
				Me._lstLineColor = value
				flag = (Me._lstLineColor IsNot Nothing)
				If flag Then
					AddHandler Me._lstLineColor.DrawItem, AddressOf Me.lstLineColor_DrawItem
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

		Friend Overridable Property lstLineWidth() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstLineWidth
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstLineWidth IsNot Nothing
				If flag Then
					RemoveHandler Me._lstLineWidth.DrawItem, AddressOf Me.lstLineWidth_DrawItem
				End If
				Me._lstLineWidth = value
				flag = (Me._lstLineWidth IsNot Nothing)
				If flag Then
					AddHandler Me._lstLineWidth.DrawItem, AddressOf Me.lstLineWidth_DrawItem
				End If
			End Set
		End Property

		Friend Overridable Property picFillColor() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._picFillColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim flag As Boolean = Me._picFillColor IsNot Nothing
				If flag Then
					RemoveHandler Me._picFillColor.Paint, AddressOf Me.picFillColor_Paint
					RemoveHandler Me._picFillColor.DoubleClick, AddressOf Me.picFillColor_DoubleClick
				End If
				Me._picFillColor = value
				flag = (Me._picFillColor IsNot Nothing)
				If flag Then
					AddHandler Me._picFillColor.Paint, AddressOf Me.picFillColor_Paint
					AddHandler Me._picFillColor.DoubleClick, AddressOf Me.picFillColor_DoubleClick
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

		Friend Overridable Property lstFillColor() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstFillColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstFillColor IsNot Nothing
				If flag Then
					RemoveHandler Me._lstFillColor.SelectedValueChanged, AddressOf Me.lstFillColor_SelectedValueChanged
					RemoveHandler Me._lstFillColor.DrawItem, AddressOf Me.lstFillColor_DrawItem
				End If
				Me._lstFillColor = value
				flag = (Me._lstFillColor IsNot Nothing)
				If flag Then
					AddHandler Me._lstFillColor.SelectedValueChanged, AddressOf Me.lstFillColor_SelectedValueChanged
					AddHandler Me._lstFillColor.DrawItem, AddressOf Me.lstFillColor_DrawItem
				End If
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

		Friend Overridable Property lstLineStyle() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstLineStyle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstLineStyle IsNot Nothing
				If flag Then
					RemoveHandler Me._lstLineStyle.DrawItem, AddressOf Me.lstLineStyle_DrawItem
				End If
				Me._lstLineStyle = value
				flag = (Me._lstLineStyle IsNot Nothing)
				If flag Then
					AddHandler Me._lstLineStyle.DrawItem, AddressOf Me.lstLineStyle_DrawItem
				End If
			End Set
		End Property

		Friend Overridable Property nudLineWidth() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudLineWidth
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudLineWidth = value
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

		Friend Overridable Property cboStyle() As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._cboStyle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim flag As Boolean = Me._cboStyle IsNot Nothing
				If flag Then
					RemoveHandler Me._cboStyle.DrawItem, AddressOf Me.cboStyle_DrawItem
				End If
				Me._cboStyle = value
				flag = (Me._cboStyle IsNot Nothing)
				If flag Then
					AddHandler Me._cboStyle.DrawItem, AddressOf Me.cboStyle_DrawItem
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
			dlgChangeSymbol.__ENCList.Add(New WeakReference(Me))
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
			Dim arg_226_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(155, 250)
			arg_226_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_27C_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_27C_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_2AD_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_2AD_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_2D7_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_2D7_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_327_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_327_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_351_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_351_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.TabControl1.Controls.Add(Me.TabPage1)
			Me.TabControl1.Controls.Add(Me.TabPage2)
			Me.TabControl1.Controls.Add(Me.TabPage3)
			Me.TabControl1.Controls.Add(Me.TabPage4)
			Dim arg_3E2_0 As Control = Me.TabControl1
			location = New Point(8, 8)
			arg_3E2_0.Location = location
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Dim arg_41F_0 As Control = Me.TabControl1
			size = New Size(297, 229)
			arg_41F_0.Size = size
			Me.TabControl1.TabIndex = 1
			Me.TabPage1.Controls.Add(Me.picLineColor)
			Me.TabPage1.Controls.Add(Me.Label1)
			Me.TabPage1.Controls.Add(Me.lstLineColor)
			Dim arg_489_0 As TabPage = Me.TabPage1
			location = New Point(4, 22)
			arg_489_0.Location = location
			Me.TabPage1.Name = "TabPage1"
			Dim arg_4B0_0 As Control = Me.TabPage1
			Dim padding As Padding = New Padding(3)
			arg_4B0_0.Padding = padding
			Dim arg_4CF_0 As Control = Me.TabPage1
			size = New Size(289, 203)
			arg_4CF_0.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "M" & ChrW(7847) & "u nét v" & ChrW(7869)
			Me.TabPage1.UseVisualStyleBackColor = True
			Me.picLineColor.BackColor = SystemColors.ActiveCaptionText
			Me.picLineColor.BorderStyle = BorderStyle.Fixed3D
			Dim arg_534_0 As Control = Me.picLineColor
			location = New Point(191, 63)
			arg_534_0.Location = location
			Me.picLineColor.Name = "picLineColor"
			Dim arg_55E_0 As Control = Me.picLineColor
			size = New Size(30, 25)
			arg_55E_0.Size = size
			Me.picLineColor.TabIndex = 2
			Me.picLineColor.TabStop = False
			Me.Label1.AutoSize = True
			Dim arg_5A1_0 As Control = Me.Label1
			location = New Point(153, 67)
			arg_5A1_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_5CB_0 As Control = Me.Label1
			size = New Size(15, 13)
			arg_5CB_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "="
			Me.lstLineColor.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstLineColor.FormattingEnabled = True
			Me.lstLineColor.ItemHeight = 20
			Dim arg_628_0 As Control = Me.lstLineColor
			location = New Point(8, 8)
			arg_628_0.Location = location
			Me.lstLineColor.Name = "lstLineColor"
			Me.lstLineColor.SelectionMode = SelectionMode.MultiSimple
			Dim arg_665_0 As Control = Me.lstLineColor
			size = New Size(128, 184)
			arg_665_0.Size = size
			Me.lstLineColor.TabIndex = 0
			Me.TabPage2.Controls.Add(Me.nudLineWidth)
			Me.TabPage2.Controls.Add(Me.Label2)
			Me.TabPage2.Controls.Add(Me.lstLineWidth)
			Dim arg_6CF_0 As TabPage = Me.TabPage2
			location = New Point(4, 22)
			arg_6CF_0.Location = location
			Me.TabPage2.Name = "TabPage2"
			Dim arg_6F6_0 As Control = Me.TabPage2
			padding = New Padding(3)
			arg_6F6_0.Padding = padding
			Dim arg_715_0 As Control = Me.TabPage2
			size = New Size(289, 203)
			arg_715_0.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = ChrW(272) & ChrW(7897) & " d" & ChrW(7847) & "y nét"
			Me.TabPage2.UseVisualStyleBackColor = True
			Dim arg_75C_0 As Control = Me.nudLineWidth
			location = New Point(198, 62)
			arg_75C_0.Location = location
			Dim arg_78B_0 As NumericUpDown = Me.nudLineWidth
			Dim num As Decimal = New Decimal(New Integer() { 36, 0, 0, 0 })
			arg_78B_0.Maximum = num
			Me.nudLineWidth.Name = "nudLineWidth"
			Dim arg_7B5_0 As Control = Me.nudLineWidth
			size = New Size(41, 21)
			arg_7B5_0.Size = size
			Me.nudLineWidth.TabIndex = 5
			Me.Label2.AutoSize = True
			Dim arg_7EB_0 As Control = Me.Label2
			location = New Point(166, 67)
			arg_7EB_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_815_0 As Control = Me.Label2
			size = New Size(15, 13)
			arg_815_0.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "="
			Me.lstLineWidth.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstLineWidth.FormattingEnabled = True
			Me.lstLineWidth.ItemHeight = 20
			Dim arg_872_0 As Control = Me.lstLineWidth
			location = New Point(8, 8)
			arg_872_0.Location = location
			Me.lstLineWidth.Name = "lstLineWidth"
			Me.lstLineWidth.SelectionMode = SelectionMode.MultiSimple
			Dim arg_8AF_0 As Control = Me.lstLineWidth
			size = New Size(128, 184)
			arg_8AF_0.Size = size
			Me.lstLineWidth.TabIndex = 3
			Me.TabPage3.Controls.Add(Me.nudAlpha)
			Me.TabPage3.Controls.Add(Me.Label5)
			Me.TabPage3.Controls.Add(Me.Label3)
			Me.TabPage3.Controls.Add(Me.picFillColor)
			Me.TabPage3.Controls.Add(Me.lstFillColor)
			Dim arg_947_0 As TabPage = Me.TabPage3
			location = New Point(4, 22)
			arg_947_0.Location = location
			Me.TabPage3.Name = "TabPage3"
			Dim arg_977_0 As Control = Me.TabPage3
			size = New Size(289, 203)
			arg_977_0.Size = size
			Me.TabPage3.TabIndex = 2
			Me.TabPage3.Text = "M" & ChrW(7847) & "u tô"
			Me.TabPage3.UseVisualStyleBackColor = True
			Dim arg_9BE_0 As Control = Me.nudAlpha
			location = New Point(204, 100)
			arg_9BE_0.Location = location
			Dim arg_9F0_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_9F0_0.Maximum = num
			Me.nudAlpha.Name = "nudAlpha"
			Dim arg_A1A_0 As Control = Me.nudAlpha
			size = New Size(45, 21)
			arg_A1A_0.Size = size
			Me.nudAlpha.TabIndex = 7
			Dim arg_A59_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_A59_0.Value = num
			Me.Label5.AutoSize = True
			Dim arg_A82_0 As Control = Me.Label5
			location = New Point(157, 102)
			arg_A82_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_AAC_0 As Control = Me.Label5
			size = New Size(42, 13)
			arg_AAC_0.Size = size
			Me.Label5.TabIndex = 6
			Me.Label5.Text = ChrW(272) & ChrW(7897) & " m" & ChrW(7901) & ":"
			Me.Label3.AutoSize = True
			Dim arg_AF3_0 As Control = Me.Label3
			location = New Point(166, 67)
			arg_AF3_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_B1D_0 As Control = Me.Label3
			size = New Size(15, 13)
			arg_B1D_0.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "="
			Me.picFillColor.BackColor = SystemColors.ActiveCaptionText
			Me.picFillColor.BorderStyle = BorderStyle.Fixed3D
			Dim arg_B75_0 As Control = Me.picFillColor
			location = New Point(204, 63)
			arg_B75_0.Location = location
			Me.picFillColor.Name = "picFillColor"
			Dim arg_B9F_0 As Control = Me.picFillColor
			size = New Size(30, 25)
			arg_B9F_0.Size = size
			Me.picFillColor.TabIndex = 5
			Me.picFillColor.TabStop = False
			Me.lstFillColor.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstFillColor.FormattingEnabled = True
			Me.lstFillColor.ItemHeight = 20
			Dim arg_BF8_0 As Control = Me.lstFillColor
			location = New Point(8, 8)
			arg_BF8_0.Location = location
			Me.lstFillColor.Name = "lstFillColor"
			Me.lstFillColor.SelectionMode = SelectionMode.MultiSimple
			Dim arg_C35_0 As Control = Me.lstFillColor
			size = New Size(128, 184)
			arg_C35_0.Size = size
			Me.lstFillColor.TabIndex = 3
			Me.TabPage4.Controls.Add(Me.lstLineStyle)
			Me.TabPage4.Controls.Add(Me.cboStyle)
			Me.TabPage4.Controls.Add(Me.Label4)
			Dim arg_C9F_0 As TabPage = Me.TabPage4
			location = New Point(4, 22)
			arg_C9F_0.Location = location
			Me.TabPage4.Name = "TabPage4"
			Dim arg_CCF_0 As Control = Me.TabPage4
			size = New Size(289, 203)
			arg_CCF_0.Size = size
			Me.TabPage4.TabIndex = 3
			Me.TabPage4.Text = "Ki" & ChrW(7875) & "u nét"
			Me.TabPage4.UseVisualStyleBackColor = True
			Me.lstLineStyle.DrawMode = DrawMode.OwnerDrawFixed
			Me.lstLineStyle.FormattingEnabled = True
			Me.lstLineStyle.ItemHeight = 30
			Dim arg_D39_0 As Control = Me.lstLineStyle
			location = New Point(8, 8)
			arg_D39_0.Location = location
			Me.lstLineStyle.Name = "lstLineStyle"
			Me.lstLineStyle.SelectionMode = SelectionMode.MultiSimple
			Dim arg_D73_0 As Control = Me.lstLineStyle
			size = New Size(120, 184)
			arg_D73_0.Size = size
			Me.lstLineStyle.TabIndex = 3
			Me.cboStyle.DrawMode = DrawMode.OwnerDrawFixed
			Me.cboStyle.DropDownHeight = 136
			Me.cboStyle.FormattingEnabled = True
			Me.cboStyle.IntegralHeight = False
			Me.cboStyle.ItemHeight = 30
			Dim arg_DE2_0 As Control = Me.cboStyle
			location = New Point(145, 65)
			arg_DE2_0.Location = location
			Me.cboStyle.Name = "cboStyle"
			Dim arg_E0F_0 As Control = Me.cboStyle
			size = New Size(136, 36)
			arg_E0F_0.Size = size
			Me.cboStyle.TabIndex = 5
			Me.Label4.AutoSize = True
			Dim arg_E45_0 As Control = Me.Label4
			location = New Point(133, 65)
			arg_E45_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_E6F_0 As Control = Me.Label4
			size = New Size(15, 13)
			arg_E6F_0.Size = size
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
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = mSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim mObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case mObj.GetObjType()
								Case OBJECTTYPE.Text
									Dim mText As TextGraphic = CType(mObj, TextGraphic)
									Dim flag As Boolean = mText.Color.ToArgb() = SColor.ToArgb()
									If flag Then
										mText.Color = DColor
									End If
								Case OBJECTTYPE.Table
									Dim mTable As TableGraphic = CType(mObj, TableGraphic)
									Dim flag As Boolean = mTable.BorderColor.ToArgb() = SColor.ToArgb()
									If flag Then
										mTable.BorderColor = DColor
									End If
									flag = (mTable.LineColor.ToArgb() = SColor.ToArgb())
									If flag Then
										mTable.LineColor = DColor
									End If
									Try
										Dim enumerator3 As IEnumerator = mTable.Cells.GetEnumerator()
										While enumerator3.MoveNext()
											Dim mCell As CCell = CType(enumerator3.Current, CCell)
											flag = (mCell.Color.ToArgb() = SColor.ToArgb())
											If flag Then
												mCell.Color = DColor
											End If
										End While
									Finally
										Dim enumerator3 As IEnumerator
										flag = (TypeOf enumerator3 Is IDisposable)
										If flag Then
											(TryCast(enumerator3, IDisposable)).Dispose()
										End If
									End Try
								Case Else
									Dim mShape As ShapeGraphic = CType(mObj, ShapeGraphic)
									Dim flag As Boolean = mShape.LineColor.ToArgb() = SColor.ToArgb()
									If flag Then
										mShape.LineColor = DColor
									End If
									flag = (mShape.Line2Color.ToArgb() = SColor.ToArgb())
									If flag Then
										mShape.Line2Color = DColor
									End If
									flag = (mShape.HatchColor.ToArgb() = SColor.ToArgb())
									If flag Then
										mShape.HatchColor = DColor
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag As Boolean = TypeOf enumerator2 Is IDisposable
						If flag Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Change1FillColor(SColor As Color, DColor As Color)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = mSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim mObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case mObj.GetObjType()
								Case OBJECTTYPE.Text
								Case OBJECTTYPE.Table
									Dim mTable As TableGraphic = CType(mObj, TableGraphic)
									Dim flag As Boolean = mTable.FiColor.ToArgb() = SColor.ToArgb()
									If flag Then
										mTable.FiColor = DColor
									End If
								Case Else
									Dim mShape As ShapeGraphic = CType(mObj, ShapeGraphic)
									Dim flag As Boolean = mShape.FillColor.ToArgb() = SColor.ToArgb()
									If flag Then
										mShape.FillColor = DColor
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag As Boolean = TypeOf enumerator2 Is IDisposable
						If flag Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Change1Style(SStyle As Integer, DStyle As Integer)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = mSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim mObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case mObj.GetObjType()
								Case OBJECTTYPE.Text
								Case OBJECTTYPE.Table
								Case Else
									Dim mShape As ShapeGraphic = CType(mObj, ShapeGraphic)
									Dim flag As Boolean = mShape.LineStyle = SStyle
									If flag Then
										mShape.LineStyle = DStyle
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag As Boolean = TypeOf enumerator2 Is IDisposable
						If flag Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Change1Width(SWidth As Integer, DWidth As Integer)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = mSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim mObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case mObj.GetObjType()
								Case OBJECTTYPE.Text
								Case OBJECTTYPE.Table
								Case Else
									Dim mShape As ShapeGraphic = CType(mObj, ShapeGraphic)
									Dim flag As Boolean = mShape.LineWidth = CSng(SWidth)
									Dim flag2 As Boolean
									If flag Then
										flag2 = (DWidth > 0)
										If flag2 Then
											mShape.LineWidth = CSng(DWidth)
										Else
											mShape.LineWidth = 1F
										End If
									End If
									flag2 = (mShape.Line2Width = CSng(SWidth))
									If flag2 Then
										mShape.Line2Width = CSng(DWidth)
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag2 As Boolean = TypeOf enumerator2 Is IDisposable
						If flag2 Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = Me.lstLineColor.SelectedItems.Count + Me.lstFillColor.SelectedItems.Count + Me.lstLineWidth.SelectedItems.Count + Me.lstLineStyle.SelectedItems.Count > 0
			If flag Then
				myModule.fMain.myBando.PopUndo()
				flag = (Me.lstLineColor.SelectedItems.Count > 0)
				Dim color As Color
				If flag Then
					Dim arg_8E_0 As Integer = 0
					Dim num As Integer = Me.lstLineColor.SelectedItems.Count - 1
					Dim i As Integer = arg_8E_0
					While True
						Dim arg_CF_0 As Integer = i
						Dim num2 As Integer = num
						If arg_CF_0 > num2 Then
							Exit While
						End If
						Dim expr_A2 As Object = Me.lstLineColor.SelectedItems(i)
						Dim SColor As Color = If((expr_A2 IsNot Nothing), (CType(expr_A2, Color)), color)
						Me.Change1Color(SColor, Me.LineColor)
						i += 1
					End While
				End If
				flag = (Me.lstFillColor.SelectedItems.Count > 0)
				If flag Then
					Me.FillColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.FillColor)
					Dim arg_121_0 As Integer = 0
					Dim num3 As Integer = Me.lstFillColor.SelectedItems.Count - 1
					Dim j As Integer = arg_121_0
					While True
						Dim arg_162_0 As Integer = j
						Dim num2 As Integer = num3
						If arg_162_0 > num2 Then
							Exit While
						End If
						Dim expr_135 As Object = Me.lstFillColor.SelectedItems(j)
						Dim SColor2 As Color = If((expr_135 IsNot Nothing), (CType(expr_135, Color)), color)
						Me.Change1FillColor(SColor2, Me.FillColor)
						j += 1
					End While
				End If
				flag = (Me.lstLineStyle.SelectedItems.Count > 0)
				If flag Then
					Dim arg_193_0 As Integer = 0
					Dim num4 As Integer = Me.lstLineStyle.SelectedItems.Count - 1
					Dim k As Integer = arg_193_0
					While True
						Dim arg_1E3_0 As Integer = k
						Dim num2 As Integer = num4
						If arg_1E3_0 > num2 Then
							Exit While
						End If
						Dim SStyle As Integer = Conversions.ToInteger(Me.lstLineStyle.SelectedItems(k))
						Me.Change1Style(SStyle, CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.cboStyle.SelectedItem)))))
						k += 1
					End While
				End If
				flag = (Me.lstLineWidth.SelectedItems.Count > 0)
				If flag Then
					Dim arg_214_0 As Integer = 0
					Dim num5 As Integer = Me.lstLineWidth.SelectedItems.Count - 1
					Dim l As Integer = arg_214_0
					While True
						Dim arg_259_0 As Integer = l
						Dim num2 As Integer = num5
						If arg_259_0 > num2 Then
							Exit While
						End If
						Dim SWidth As Integer = Conversions.ToInteger(Me.lstLineWidth.SelectedItems(l))
						Me.Change1Width(SWidth, Convert.ToInt32(Me.nudLineWidth.Value))
						l += 1
					End While
				End If
				myModule.fMain.myBando.RefreshMap()
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
			Dim i As Integer = -1
			Me.AFillColors = New Color(-1) {}
			Dim iFill As Integer = -1
			Me.AWidths = New Integer(-1) {}
			Dim iWidth As Integer = -1
			Me.AStyles = New Integer(-1) {}
			Dim iStyle As Integer = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = Me.m_Symbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Try
						Dim enumerator2 As IEnumerator = mSymbol.GObjs.GetEnumerator()
						While enumerator2.MoveNext()
							Dim mObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
							Select Case mObj.GetObjType()
								Case OBJECTTYPE.Text
									Dim mText As TextGraphic = CType(mObj, TextGraphic)
									Dim flag As Boolean = Me.IsNewColor(mText.Color)
									If flag Then
										i += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
										Me.AColors(i) = mText.Color
									End If
								Case OBJECTTYPE.Table
									Dim mTable As TableGraphic = CType(mObj, TableGraphic)
									Dim flag As Boolean = Me.IsNewColor(mTable.BorderColor)
									If flag Then
										i += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
										Me.AColors(i) = mTable.BorderColor
									End If
									flag = Me.IsNewColor(mTable.LineColor)
									If flag Then
										i += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
										Me.AColors(i) = mTable.LineColor
									End If
									Try
										Dim enumerator3 As IEnumerator = mTable.Cells.GetEnumerator()
										While enumerator3.MoveNext()
											Dim mCell As CCell = CType(enumerator3.Current, CCell)
											flag = Me.IsNewColor(mCell.Color)
											If flag Then
												i += 1
												Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
												Me.AColors(i) = mCell.Color
											End If
										End While
									Finally
										Dim enumerator3 As IEnumerator
										flag = (TypeOf enumerator3 Is IDisposable)
										If flag Then
											(TryCast(enumerator3, IDisposable)).Dispose()
										End If
									End Try
									flag = Me.IsNewFillColor(mTable.FiColor)
									If flag Then
										iFill += 1
										Me.AFillColors = CType(Utils.CopyArray(CType(Me.AFillColors, Array), New Color(iFill + 1 - 1) {}), Color())
										Me.AFillColors(iFill) = mTable.FiColor
									End If
									flag = Me.IsNewWidth(mTable.LineWidth)
									If flag Then
										iWidth += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(iWidth + 1 - 1) {}), Integer())
										Me.AWidths(iWidth) = mTable.LineWidth
									End If
									flag = Me.IsNewWidth(mTable.BorderWidth)
									If flag Then
										iWidth += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(iWidth + 1 - 1) {}), Integer())
										Me.AWidths(iWidth) = mTable.BorderWidth
									End If
								Case Else
									Dim mShape As ShapeGraphic = CType(mObj, ShapeGraphic)
									Dim flag As Boolean = Me.IsNewColor(mShape.LineColor)
									If flag Then
										i += 1
										Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
										Me.AColors(i) = mShape.LineColor
									End If
									flag = (mShape.Line2Width > 0F)
									Dim flag2 As Boolean
									If flag Then
										flag2 = Me.IsNewColor(mShape.Line2Color)
										If flag2 Then
											i += 1
											Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
											Me.AColors(i) = mShape.Line2Color
										End If
									End If
									flag2 = mShape.Fill
									If flag2 Then
										flag = Me.IsNewFillColor(mShape.FillColor)
										If flag Then
											iFill += 1
											Me.AFillColors = CType(Utils.CopyArray(CType(Me.AFillColors, Array), New Color(iFill + 1 - 1) {}), Color())
											Me.AFillColors(iFill) = mShape.FillColor
										End If
										flag2 = Me.IsNewColor(mShape.HatchColor)
										If flag2 Then
											i += 1
											Me.AColors = CType(Utils.CopyArray(CType(Me.AColors, Array), New Color(i + 1 - 1) {}), Color())
											Me.AColors(i) = mShape.HatchColor
										End If
									End If
									flag2 = Me.IsNewWidth(CInt(Math.Round(CDec(mShape.LineWidth))))
									If flag2 Then
										iWidth += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(iWidth + 1 - 1) {}), Integer())
										Me.AWidths(iWidth) = CInt(Math.Round(CDec(mShape.LineWidth)))
									End If
									flag2 = Me.IsNewWidth(CInt(Math.Round(CDec(mShape.Line2Width))))
									If flag2 Then
										iWidth += 1
										Me.AWidths = CType(Utils.CopyArray(CType(Me.AWidths, Array), New Integer(iWidth + 1 - 1) {}), Integer())
										Me.AWidths(iWidth) = CInt(Math.Round(CDec(mShape.Line2Width)))
									End If
									flag2 = Me.IsNewStyle(mShape.LineStyle)
									If flag2 Then
										iStyle += 1
										Me.AStyles = CType(Utils.CopyArray(CType(Me.AStyles, Array), New Integer(iStyle + 1 - 1) {}), Integer())
										Me.AStyles(iStyle) = mShape.LineStyle
									End If
							End Select
						End While
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag2 As Boolean = TypeOf enumerator2 Is IDisposable
						If flag2 Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim arg_632_0 As Integer = 0
			Dim upperBound As Integer = Me.AColors.GetUpperBound(0)
			Dim j As Integer = arg_632_0
			While True
				Dim arg_66D_0 As Integer = j
				Dim num As Integer = upperBound
				If arg_66D_0 > num Then
					Exit While
				End If
				Me.lstLineColor.Items.Add(Me.AColors(j))
				j += 1
			End While
			Dim arg_67E_0 As Integer = 0
			Dim upperBound2 As Integer = Me.AFillColors.GetUpperBound(0)
			Dim k As Integer = arg_67E_0
			While True
				Dim arg_6B9_0 As Integer = k
				Dim num As Integer = upperBound2
				If arg_6B9_0 > num Then
					Exit While
				End If
				Me.lstFillColor.Items.Add(Me.AFillColors(k))
				k += 1
			End While
			Dim arg_6CA_0 As Integer = 0
			Dim upperBound3 As Integer = Me.AWidths.GetUpperBound(0)
			Dim l As Integer = arg_6CA_0
			While True
				Dim arg_6FC_0 As Integer = l
				Dim num As Integer = upperBound3
				If arg_6FC_0 > num Then
					Exit While
				End If
				Me.lstLineWidth.Items.Add(Me.AWidths(l))
				l += 1
			End While
			Dim arg_70D_0 As Integer = 0
			Dim upperBound4 As Integer = Me.AStyles.GetUpperBound(0)
			Dim m As Integer = arg_70D_0
			While True
				Dim arg_73F_0 As Integer = m
				Dim num As Integer = upperBound4
				If arg_73F_0 > num Then
					Exit While
				End If
				Me.lstLineStyle.Items.Add(Me.AStyles(m))
				m += 1
			End While
		End Sub

		Private Function IsNewColor(pColor As Color) As Boolean
			Dim arg_0F_0 As Integer = 0
			Dim upperBound As Integer = Me.AColors.GetUpperBound(0)
			Dim i As Integer = arg_0F_0
			' The following expression was wrapped in a checked-statement
			While True
				Dim arg_40_0 As Integer = i
				Dim num As Integer = upperBound
				If arg_40_0 > num Then
					GoTo Block_2
				End If
				Dim flag As Boolean = pColor.ToArgb() = Me.AColors(i).ToArgb()
				If flag Then
					Exit While
				End If
				i += 1
			End While
			Dim IsNewColor As Boolean = False
			Return IsNewColor
			Block_2:
			IsNewColor = True
			Return IsNewColor
		End Function

		Private Function IsNewFillColor(pColor As Color) As Boolean
			Dim arg_0F_0 As Integer = 0
			Dim upperBound As Integer = Me.AFillColors.GetUpperBound(0)
			Dim i As Integer = arg_0F_0
			' The following expression was wrapped in a checked-statement
			While True
				Dim arg_40_0 As Integer = i
				Dim num As Integer = upperBound
				If arg_40_0 > num Then
					GoTo Block_2
				End If
				Dim flag As Boolean = pColor.ToArgb() = Me.AFillColors(i).ToArgb()
				If flag Then
					Exit While
				End If
				i += 1
			End While
			Dim IsNewFillColor As Boolean = False
			Return IsNewFillColor
			Block_2:
			IsNewFillColor = True
			Return IsNewFillColor
		End Function

		Private Function IsNewWidth(pWidth As Integer) As Boolean
			Dim arg_0F_0 As Integer = 0
			Dim upperBound As Integer = Me.AWidths.GetUpperBound(0)
			Dim i As Integer = arg_0F_0
			' The following expression was wrapped in a checked-statement
			While True
				Dim arg_31_0 As Integer = i
				Dim num As Integer = upperBound
				If arg_31_0 > num Then
					GoTo Block_2
				End If
				Dim flag As Boolean = pWidth = Me.AWidths(i)
				If flag Then
					Exit While
				End If
				i += 1
			End While
			Dim IsNewWidth As Boolean = False
			Return IsNewWidth
			Block_2:
			IsNewWidth = True
			Return IsNewWidth
		End Function

		Private Function IsNewStyle(pStyle As Integer) As Boolean
			Dim arg_0F_0 As Integer = 0
			Dim upperBound As Integer = Me.AStyles.GetUpperBound(0)
			Dim i As Integer = arg_0F_0
			' The following expression was wrapped in a checked-statement
			While True
				Dim arg_31_0 As Integer = i
				Dim num As Integer = upperBound
				If arg_31_0 > num Then
					GoTo Block_2
				End If
				Dim flag As Boolean = pStyle = Me.AStyles(i)
				If flag Then
					Exit While
				End If
				i += 1
			End While
			Dim IsNewStyle As Boolean = False
			Return IsNewStyle
			Block_2:
			IsNewStyle = True
			Return IsNewStyle
		End Function

		Private Sub dlgChangeSymbol_Load(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			modBanDo.ADStyles = New Integer(modBanDo.MaxStyle + 1 - 1) {}
			Dim arg_1F_0 As Integer = 0
			Dim upperBound As Integer = modBanDo.ADStyles.GetUpperBound(0)
			Dim i As Integer = arg_1F_0
			While True
				Dim arg_50_0 As Integer = i
				Dim num As Integer = upperBound
				If arg_50_0 > num Then
					Exit While
				End If
				modBanDo.ADStyles(i) = i
				Me.cboStyle.Items.Add(modBanDo.ADStyles(i))
				i += 1
			End While
			Me.PopulationLists()
			Me.cboStyle.SelectedIndex = 0
		End Sub

		Private Sub lstLineColor_DrawItem(sender As Object, e As DrawItemEventArgs)
			Dim brColor As Brush = Nothing
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
				Dim brText As Brush
				If flag Then
					brText = Brushes.White
				Else
					brText = Brushes.Black
				End If
				e.DrawBackground()
				Dim rct As Rectangle = New Rectangle(e.Bounds.X + 5, e.Bounds.Y + 5, 15, 10)
				Dim penOutline As Pen = Pens.Black
				brColor = New SolidBrush(Me.AColors(e.Index))
				e.Graphics.DrawRectangle(penOutline, rct)
				e.Graphics.FillRectangle(brColor, rct)
				e.Graphics.DrawString(String.Concat(New String() { Me.AColors(e.Index).R.ToString(), ",", Me.AColors(e.Index).G.ToString(), ",", Me.AColors(e.Index).B.ToString() }), Me.lstLineColor.Font, brText, CSng((rct.Left + rct.Width + 5)), CSng(e.Bounds.Y))
				e.DrawFocusRectangle()
			Catch expr_16A As Exception
				ProjectData.SetProjectError(expr_16A)
				ProjectData.ClearProjectError()
			Finally
				Dim flag As Boolean = brColor IsNot Nothing
				If flag Then
					brColor.Dispose()
				End If
			End Try
		End Sub

		Private Sub picLineColor_DoubleClick(sender As Object, e As EventArgs)
			Me.LineColor = modBanDo.GetMau(Me.LineColor)
			Me.picLineColor.Invalidate()
		End Sub

		Private Sub picFillColor_DoubleClick(sender As Object, e As EventArgs)
			Me.FillColor = modBanDo.GetMau(Me.FillColor)
			Me.FillColor = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.FillColor)
			Me.picFillColor.Invalidate()
		End Sub

		Private Sub picFillColor_Paint(sender As Object, e As PaintEventArgs)
			Dim rct As Rectangle = New Rectangle(5, 5, 15, 10)
			Dim penOutline As Pen = Pens.Black
			Dim brColor As Object = New SolidBrush(Color.FromArgb(255, CInt(Me.FillColor.R), CInt(Me.FillColor.G), CInt(Me.FillColor.B)))
			e.Graphics.DrawRectangle(penOutline, rct)
			Dim arg_97_0 As Object = e.Graphics
			Dim arg_97_1 As Type = Nothing
			Dim arg_97_2 As String = "FillRectangle"
			Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(brColor), rct }
			Dim arg_97_3 As Object() = array
			Dim arg_97_4 As String() = Nothing
			Dim arg_97_5 As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True, True }
			NewLateBinding.LateCall(arg_97_0, arg_97_1, arg_97_2, arg_97_3, arg_97_4, arg_97_5, array2, True)
			If array2(0) Then
				brColor = RuntimeHelpers.GetObjectValue(array(0))
			End If
			If array2(1) Then
				rct = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Rectangle)), Rectangle)
			End If
		End Sub

		Private Sub lstFillColor_DrawItem(sender As Object, e As DrawItemEventArgs)
			Dim brColor As Brush = Nothing
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
				Dim brText As Brush
				If flag Then
					brText = Brushes.White
				Else
					brText = Brushes.Black
				End If
				e.DrawBackground()
				Dim rct As Rectangle = New Rectangle(e.Bounds.X + 5, e.Bounds.Y + 5, 15, 10)
				Dim penOutline As Pen = Pens.Black
				brColor = New SolidBrush(Me.AFillColors(e.Index))
				e.Graphics.DrawRectangle(penOutline, rct)
				e.Graphics.FillRectangle(brColor, rct)
				e.Graphics.DrawString(String.Concat(New String() { Me.AFillColors(e.Index).R.ToString(), ",", Me.AFillColors(e.Index).G.ToString(), ",", Me.AFillColors(e.Index).B.ToString(), "|", Me.AFillColors(e.Index).A.ToString() }), Me.lstFillColor.Font, brText, CSng((rct.Left + rct.Width + 5)), CSng(e.Bounds.Y))
				e.DrawFocusRectangle()
			Catch expr_198 As Exception
				ProjectData.SetProjectError(expr_198)
				ProjectData.ClearProjectError()
			Finally
				Dim flag As Boolean = brColor IsNot Nothing
				If flag Then
					brColor.Dispose()
				End If
			End Try
		End Sub

		Private Sub lstFillColor_SelectedValueChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstFillColor.SelectedItems.Count > 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				Dim expr_3B As Object = Me.lstFillColor.SelectedItems(Me.lstFillColor.SelectedItems.Count - 1)
				Dim color As Color
				Me.FillColor = (If((expr_3B IsNot Nothing), (CType(expr_3B, Color)), color))
				Me.nudAlpha.Value = New Decimal(CInt(Me.FillColor.A))
				Me.picFillColor.Invalidate()
			End If
		End Sub

		Private Sub lstLineStyle_DrawItem(sender As Object, e As DrawItemEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
				Dim brText As Brush
				If flag Then
					brText = Brushes.White
				Else
					brText = Brushes.Black
				End If
				e.DrawBackground()
				e.Graphics.DrawString(Me.AStyles(e.Index).ToString(), Me.lstLineStyle.Font, brText, CSng((e.Bounds.X + 5)), CSng((e.Bounds.Y + 10)))
				Me.m_drawingObjects = Me.GetLineObj(CSng((e.Bounds.X + 20)), CSng((e.Bounds.Y + 20)), CSng((e.Bounds.X + e.Bounds.Width - 5)), CSng((e.Bounds.Y + 20)), 1, Me.AStyles(e.Index))
				Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
				e.DrawFocusRectangle()
			Catch expr_10F As Exception
				ProjectData.SetProjectError(expr_10F)
				ProjectData.ClearProjectError()
			Finally
			End Try
		End Sub

		Private Function GetLineObj(x1 As Single, y1 As Single, x2 As Single, y2 As Single, width As Integer, style As Integer) As CGraphicObjs
			Dim mDrawingObjects As CGraphicObjs = New CGraphicObjs()
			Dim mPts As PointF() = New PointF(1) {}
			mPts(0).X = x1
			mPts(0).Y = y1
			mPts(1).X = x2
			mPts(1).Y = y2
			Dim gObj As GraphicObject = New LinesGraphic(mPts, 1F, Color.Red) With { .LineStyle = style, .StyleWidth = 10F, .LineWidth = CSng(width) }
			Dim flag As Boolean = gObj IsNot Nothing
			If flag Then
				mDrawingObjects.Add(gObj)
			End If
			Return mDrawingObjects
		End Function

		Private Sub lstLineWidth_DrawItem(sender As Object, e As DrawItemEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
				Dim brText As Brush
				If flag Then
					brText = Brushes.White
				Else
					brText = Brushes.Black
				End If
				e.DrawBackground()
				e.Graphics.DrawString(Me.AWidths(e.Index).ToString(), Me.lstLineWidth.Font, brText, CSng((e.Bounds.X + 5)), CSng(e.Bounds.Y))
				Me.m_drawingObjects = Me.GetLineObj(CSng((e.Bounds.X + 20)), CSng((e.Bounds.Y + 10)), CSng((e.Bounds.X + e.Bounds.Width - 25)), CSng((e.Bounds.Y + 10)), Me.AWidths(e.Index), 0)
				Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
				e.DrawFocusRectangle()
			Catch expr_10E As Exception
				ProjectData.SetProjectError(expr_10E)
				ProjectData.ClearProjectError()
			Finally
			End Try
		End Sub

		Private Sub cboStyle_DrawItem(sender As Object, e As DrawItemEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
				Dim brText As Brush
				If flag Then
					brText = Brushes.White
				Else
					brText = Brushes.Black
				End If
				e.DrawBackground()
				e.Graphics.DrawString(modBanDo.ADStyles(e.Index).ToString(), Me.cboStyle.Font, brText, CSng((e.Bounds.X + 5)), CSng((e.Bounds.Y + 10)))
				Me.m_drawingObjects = Me.GetLineObj(CSng((e.Bounds.X + 20)), CSng((e.Bounds.Y + 20)), CSng((e.Bounds.X + e.Bounds.Width - 5)), CSng((e.Bounds.Y + 20)), 1, modBanDo.ADStyles(e.Index))
				Me.m_drawingObjects.DrawObjects(e.Graphics, Me.m_Scale)
				e.DrawFocusRectangle()
			Catch expr_10D As Exception
				ProjectData.SetProjectError(expr_10D)
				ProjectData.ClearProjectError()
			Finally
			End Try
		End Sub

		Private Sub picLineColor_Paint(sender As Object, e As PaintEventArgs)
			Dim rct As Rectangle = New Rectangle(5, 5, 15, 10)
			Dim penOutline As Pen = Pens.Black
			Dim brColor As Object = New SolidBrush(Me.LineColor)
			e.Graphics.DrawRectangle(penOutline, rct)
			Dim arg_72_0 As Object = e.Graphics
			Dim arg_72_1 As Type = Nothing
			Dim arg_72_2 As String = "FillRectangle"
			Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(brColor), rct }
			Dim arg_72_3 As Object() = array
			Dim arg_72_4 As String() = Nothing
			Dim arg_72_5 As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True, True }
			NewLateBinding.LateCall(arg_72_0, arg_72_1, arg_72_2, arg_72_3, arg_72_4, arg_72_5, array2, True)
			If array2(0) Then
				brColor = RuntimeHelpers.GetObjectValue(array(0))
			End If
			If array2(1) Then
				rct = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Rectangle)), Rectangle)
			End If
		End Sub
	End Class
End Namespace
