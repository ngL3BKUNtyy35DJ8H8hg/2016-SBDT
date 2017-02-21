Imports DienTapLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgMenuRepos
		Inherits Form

		Private Enum VeTools
			None
			MoveScreen
			MoveMnuItem
		End Enum

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("AllContextMenuStrip")>
		Private _AllContextMenuStrip As ContextMenuStrip

		<AccessedThroughProperty("ChangeFontToolStripMenuItem")>
		Private _ChangeFontToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("DonDongToolStripMenuItem")>
		Private _DonDongToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DanDongToolStripMenuItem")>
		Private _DanDongToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("DichLenToolStripMenuItem")>
		Private _DichLenToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DichXuongToolStripMenuItem")>
		Private _DichXuongToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DichTraiToolStripMenuItem")>
		Private _DichTraiToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DichPhaiToolStripMenuItem")>
		Private _DichPhaiToolStripMenuItem As ToolStripMenuItem

		Private MenuFileName As String

		Private seleMnuItem As CMnuItem

		Private snapX As Integer

		Private snapY As Integer

		Private deltaX As Integer

		Private deltaY As Integer

		Private CounterPos As Integer

		Private mnuItems As List(Of CMnuItem)

		Private myFont As Font

		Private bLoaded As Boolean

		Private m_DrawTool As dlgMenuRepos.VeTools

		Private m_ShiftY As Integer

		Private myfromPt As Point

		Private mytoPt As Point

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

		Friend Overridable Property AllContextMenuStrip() As ContextMenuStrip
			Get
				Return Me._AllContextMenuStrip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._AllContextMenuStrip = value
			End Set
		End Property

		Friend Overridable Property ChangeFontToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._ChangeFontToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ChangeFontToolStripMenuItem_Click
				If Me._ChangeFontToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ChangeFontToolStripMenuItem.Click, value2
				End If
				Me._ChangeFontToolStripMenuItem = value
				If Me._ChangeFontToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ChangeFontToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator1() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		Friend Overridable Property DonDongToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DonDongToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DonDongToolStripMenuItem_Click
				If Me._DonDongToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DonDongToolStripMenuItem.Click, value2
				End If
				Me._DonDongToolStripMenuItem = value
				If Me._DonDongToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DonDongToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DanDongToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DanDongToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DanDongToolStripMenuItem_Click
				If Me._DanDongToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DanDongToolStripMenuItem.Click, value2
				End If
				Me._DanDongToolStripMenuItem = value
				If Me._DanDongToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DanDongToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator2() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		Friend Overridable Property DichLenToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DichLenToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DichLenToolStripMenuItem_Click
				If Me._DichLenToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DichLenToolStripMenuItem.Click, value2
				End If
				Me._DichLenToolStripMenuItem = value
				If Me._DichLenToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DichLenToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DichXuongToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DichXuongToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DichXuongToolStripMenuItem_Click
				If Me._DichXuongToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DichXuongToolStripMenuItem.Click, value2
				End If
				Me._DichXuongToolStripMenuItem = value
				If Me._DichXuongToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DichXuongToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DichTraiToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DichTraiToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DichTraiToolStripMenuItem_Click
				If Me._DichTraiToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DichTraiToolStripMenuItem.Click, value2
				End If
				Me._DichTraiToolStripMenuItem = value
				If Me._DichTraiToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DichTraiToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DichPhaiToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DichPhaiToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DichPhaiToolStripMenuItem_Click
				If Me._DichPhaiToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DichPhaiToolStripMenuItem.Click, value2
				End If
				Me._DichPhaiToolStripMenuItem = value
				If Me._DichPhaiToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DichPhaiToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.MouseMove, AddressOf Me.dlgMenu_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.dlgMenu_MouseUp
			AddHandler MyBase.Paint, AddressOf Me.dlgMenu_Paint
			AddHandler MyBase.Load, AddressOf Me.dlgMenu_Load
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.dlgMenuRepos_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.dlgMenu_MouseDown
			Me.MenuFileName = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
			Me.snapX = 10
			Me.snapY = 5
			Me.deltaX = 5
			Me.deltaY = 2
			Me.CounterPos = 30
			Me.myFont = New Font(modSaBan.MenuFontName, modSaBan.MenuFontSize, modSaBan.MenuFontStyle, GraphicsUnit.Point)
			Me.bLoaded = False
			Me.m_ShiftY = 0
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
			Me.components = New Container()
			Me.TableLayoutPanel1 = New TableLayoutPanel()
			Me.OK_Button = New Button()
			Me.Cancel_Button = New Button()
			Me.AllContextMenuStrip = New ContextMenuStrip(Me.components)
			Me.ChangeFontToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.DonDongToolStripMenuItem = New ToolStripMenuItem()
			Me.DanDongToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.DichLenToolStripMenuItem = New ToolStripMenuItem()
			Me.DichXuongToolStripMenuItem = New ToolStripMenuItem()
			Me.DichTraiToolStripMenuItem = New ToolStripMenuItem()
			Me.DichPhaiToolStripMenuItem = New ToolStripMenuItem()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.AllContextMenuStrip.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_155_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(860, 703)
			arg_155_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1A7_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1A7_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 1
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1D4_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1D4_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1FB_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1FB_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_245_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_245_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_26C_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_26C_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.AllContextMenuStrip.Items.AddRange(New ToolStripItem() { Me.ChangeFontToolStripMenuItem, Me.ToolStripSeparator1, Me.DonDongToolStripMenuItem, Me.DanDongToolStripMenuItem, Me.ToolStripSeparator2, Me.DichLenToolStripMenuItem, Me.DichXuongToolStripMenuItem, Me.DichTraiToolStripMenuItem, Me.DichPhaiToolStripMenuItem })
			Me.AllContextMenuStrip.Name = "AllContextMenuStrip"
			Dim arg_32A_0 As Control = Me.AllContextMenuStrip
			size = New Size(136, 170)
			arg_32A_0.Size = size
			Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
			Dim arg_354_0 As ToolStripItem = Me.ChangeFontToolStripMenuItem
			size = New Size(135, 22)
			arg_354_0.Size = size
			Me.ChangeFontToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i font"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim arg_38D_0 As ToolStripItem = Me.ToolStripSeparator1
			size = New Size(132, 6)
			arg_38D_0.Size = size
			Me.DonDongToolStripMenuItem.Name = "DonDongToolStripMenuItem"
			Dim arg_3B7_0 As ToolStripItem = Me.DonDongToolStripMenuItem
			size = New Size(135, 22)
			arg_3B7_0.Size = size
			Me.DonDongToolStripMenuItem.Text = "D" & ChrW(7891) & "n dòng"
			Me.DanDongToolStripMenuItem.Name = "DanDongToolStripMenuItem"
			Dim arg_3F1_0 As ToolStripItem = Me.DanDongToolStripMenuItem
			size = New Size(135, 22)
			arg_3F1_0.Size = size
			Me.DanDongToolStripMenuItem.Text = "Dãn dòng"
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim arg_42A_0 As ToolStripItem = Me.ToolStripSeparator2
			size = New Size(132, 6)
			arg_42A_0.Size = size
			Me.DichLenToolStripMenuItem.Name = "DichLenToolStripMenuItem"
			Dim arg_454_0 As ToolStripItem = Me.DichLenToolStripMenuItem
			size = New Size(135, 22)
			arg_454_0.Size = size
			Me.DichLenToolStripMenuItem.Text = "D" & ChrW(7883) & "ch lên"
			Me.DichXuongToolStripMenuItem.Name = "DichXuongToolStripMenuItem"
			Dim arg_48E_0 As ToolStripItem = Me.DichXuongToolStripMenuItem
			size = New Size(135, 22)
			arg_48E_0.Size = size
			Me.DichXuongToolStripMenuItem.Text = "D" & ChrW(7883) & "ch xu" & ChrW(7889) & "ng"
			Me.DichTraiToolStripMenuItem.Name = "DichTraiToolStripMenuItem"
			Dim arg_4C8_0 As ToolStripItem = Me.DichTraiToolStripMenuItem
			size = New Size(135, 22)
			arg_4C8_0.Size = size
			Me.DichTraiToolStripMenuItem.Text = "D" & ChrW(7883) & "ch trái"
			Me.DichPhaiToolStripMenuItem.Name = "DichPhaiToolStripMenuItem"
			Dim arg_502_0 As ToolStripItem = Me.DichPhaiToolStripMenuItem
			size = New Size(135, 22)
			arg_502_0.Size = size
			Me.DichPhaiToolStripMenuItem.Text = "D" & ChrW(7883) & "ch ph" & ChrW(7843) & "i"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.LightBlue
			size = New Size(1018, 744)
			Me.ClientSize = size
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgMenuRepos"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Dlg3DShow"
			Me.WindowState = FormWindowState.Maximized
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.AllContextMenuStrip.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private Function HitTest(pMnuItem As CMnuItem, pt As Point) As Boolean
			' The following expression was wrapped in a checked-expression
			Dim rectangleF As RectangleF = New RectangleF(CSng(pMnuItem.PosX), CSng((Me.m_ShiftY + pMnuItem.PosY)), CSng(pMnuItem.Width), CSng(pMnuItem.Height))
			Return rectangleF.Contains(pt)
		End Function

		Private Function FindMnuItem(pt As Point) As CMnuItem
			Dim result As CMnuItem = Nothing
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					If Me.HitTest(current, pt) Then
						result = current
						Exit While
					End If
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Return result
		End Function

		Private Sub dlgMenu_Load(sender As Object, e As EventArgs)
			Me.Text = "B" & ChrW(7889) & " trí l" & ChrW(7841) & "i Menu. kéo tr" & ChrW(7921) & "c ti" & ChrW(7871) & "p các MenuItem " & ChrW(273) & ChrW(7875) & " thay " & ChrW(273) & ChrW(7893) & "i v" & ChrW(7883) & " trí... (Nháy chu" & ChrW(7897) & "t ph" & ChrW(7843) & "i " & ChrW(273) & ChrW(7875) & " hi" & ChrW(7879) & "n menu)"
			If MyProject.Computer.FileSystem.FileExists(Me.MenuFileName) Then
				Me.mnuItems = CMnuDef.GetMnuItems(Me.MenuFileName)
				Me.PreUpdateMnuItem()
				Me.bLoaded = True
			Else
				Interaction.MsgBox("Không th" & ChrW(7845) & "y file: " + Me.MenuFileName, MsgBoxStyle.OkOnly, Nothing)
				Me.Close()
			End If
		End Sub

		Private Sub PreUpdateMnuItem()
			Dim graphics As Graphics = Me.CreateGraphics()
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim sizeF As SizeF = graphics.MeasureString(cMnuItem.Name, Me.myFont)
					cMnuItem.Width = CInt(Math.Round(CDec(sizeF.Width)))
					cMnuItem.Height = CInt(Math.Round(CDec(sizeF.Height)))
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
		End Sub

		Private Function Snap(px As Single, py As Single) As Point
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim result As Point = New Point(CInt(Math.Round(Math.Round(CDec((px / CSng(Me.snapX))), 0) * CDec(Me.snapX))), CInt(Math.Round(Math.Round(CDec((py / CSng(Me.snapY))), 0) * CDec(Me.snapY))))
			Return result
		End Function

		Private Sub DrawMenu(g As Graphics)
			' The following expression was wrapped in a checked-expression
			Me.CounterPos = CInt(Math.Round(CDec(modSaBan.MenuFontSize))) + 18
			Dim red As Brush = Brushes.Red
			g.DrawString("60.00 fps", Me.myFont, red, 10F, 10F)
			Dim black As Brush = Brushes.Black
			g.DrawString("Ch" & ChrW(7885) & "n hành " & ChrW(273) & ChrW(7897) & "ng...", Me.myFont, black, 10F, CSng(Me.CounterPos))
			Dim brush As SolidBrush = New SolidBrush(modSaBan.NoActColor)
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					g.DrawString(cMnuItem.Name, Me.myFont, brush, CSng(cMnuItem.PosX), CSng(cMnuItem.PosY))
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			If Not Information.IsNothing(Me.seleMnuItem) Then
				Dim brush2 As SolidBrush = New SolidBrush(modSaBan.ActColor)
				Dim cMnuItem2 As CMnuItem = Me.seleMnuItem
				g.DrawString(cMnuItem2.Name, Me.myFont, brush2, CSng(cMnuItem2.PosX), CSng(cMnuItem2.PosY))
			End If
		End Sub

		Private Sub dlgMenuRepos_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			If Not Information.IsNothing(Me.seleMnuItem) Then
				Dim itemScript As String = Me.GetItemScript(Me.seleMnuItem)
				Interaction.MsgBox(itemScript, MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub dlgMenu_MouseDown(sender As Object, e As MouseEventArgs)
			Dim pt As Point = Me.Snap(CSng(e.X), CSng(e.Y))
			If(Control.ModifierKeys And Keys.Control) <> Keys.Control Then
				Me.seleMnuItem = Me.FindMnuItem(pt)
				If Not Information.IsNothing(Me.seleMnuItem) Then
					Me.m_DrawTool = dlgMenuRepos.VeTools.MoveMnuItem
					Me.myfromPt = pt
					Me.mytoPt = pt
				End If
				Me.Invalidate()
			End If
			If Information.IsNothing(Me.seleMnuItem) Then
				If(e.Button And MouseButtons.Right) > MouseButtons.None Then
					Dim arg_99_0 As ToolStripDropDown = Me.AllContextMenuStrip
					Dim position As Point = New Point(e.X, e.Y)
					arg_99_0.Show(Me, position)
				End If
			End If
		End Sub

		Private Sub dlgMenu_MouseMove(sender As Object, e As MouseEventArgs)
			Dim point As Point = Me.Snap(CSng(e.X), CSng(e.Y))
			' The following expression was wrapped in a checked-statement
			If Me.m_DrawTool = dlgMenuRepos.VeTools.MoveScreen Then
				Me.mytoPt = point
				Me.m_ShiftY += Me.mytoPt.Y - Me.myfromPt.Y
				Me.Invalidate()
				Me.myfromPt = Me.mytoPt
			Else If Me.m_DrawTool = dlgMenuRepos.VeTools.MoveMnuItem AndAlso Not Information.IsNothing(Me.seleMnuItem) Then
				Me.mytoPt = point
				Dim cMnuItem As CMnuItem = Me.seleMnuItem
				Dim cMnuItem2 As CMnuItem = cMnuItem
				cMnuItem2.PosX += Me.mytoPt.X - Me.myfromPt.X
				cMnuItem2 = cMnuItem
				cMnuItem2.PosY += Me.mytoPt.Y - Me.myfromPt.Y
				Me.Invalidate()
				Me.myfromPt = Me.mytoPt
			End If
		End Sub

		Private Sub dlgMenu_MouseUp(sender As Object, e As MouseEventArgs)
			Me.seleMnuItem = Nothing
			Me.m_DrawTool = dlgMenuRepos.VeTools.None
		End Sub

		Private Sub dlgMenu_Paint(sender As Object, e As PaintEventArgs)
			If Me.bLoaded Then
				Dim graphics As Graphics = e.Graphics
				graphics.TranslateTransform(0F, CSng(Me.m_ShiftY))
				Me.DrawMenu(graphics)
			End If
		End Sub

		Private Sub UpdateMenu()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array As String() = File.ReadAllLines(Me.MenuFileName)
			Dim num As Integer = 0
			Dim array2 As String() = array
			' The following expression was wrapped in a checked-statement
			For i As Integer = 0 To array2.Length - 1
				Dim text As String = array2(i)
				If text.Contains("<MnuItem") Then
					Dim itemStr As String = Me.GetItemStr(Me.mnuItems(num))
					num += 1
					stringBuilder.Append(itemStr + vbCrLf)
				Else
					stringBuilder.Append(text + vbCrLf)
				End If
			Next
			File.WriteAllText(Me.MenuFileName, stringBuilder.ToString())
		End Sub

		Private Function GetItemStr(pMnuItem As CMnuItem) As String
			Dim str As String = "<MnuItem"
			If pMnuItem.id.Length > 0 Then
				str = str + " ID=""" + pMnuItem.id + """"
			End If
			str = str + " Name=""" + pMnuItem.Name + """"
			str = str + " PosX=""" + pMnuItem.PosX.ToString() + """"
			str = str + " PosY=""" + pMnuItem.PosY.ToString() + """"
			str = str + " Width=""" + pMnuItem.Width.ToString() + """"
			str = str + " Height=""" + pMnuItem.Height.ToString() + """"
			Return str + ">"
		End Function

		Private Function GetItemScript(pMnuItem As CMnuItem) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim array As String() = File.ReadAllLines(Me.MenuFileName)
			Dim flag As Boolean = False
			Dim array2 As String() = array
			' The following expression was wrapped in a checked-statement
			For i As Integer = 0 To array2.Length - 1
				Dim text As String = array2(i)
				If text.Contains("<MnuItem") And text.Contains(pMnuItem.Name) Then
					flag = True
				Else If text.Contains("</MnuItem>") Then
					flag = False
				Else If flag Then
					stringBuilder.Append(text + vbCrLf)
				End If
			Next
			Return stringBuilder.ToString()
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.UpdateMenu()
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.myFont
			fontDialog.Color = modSaBan.NoActColor
			fontDialog.ShowColor = True
			If fontDialog.ShowDialog() <> DialogResult.Cancel Then
				modSaBan.MenuFontName = fontDialog.Font.Name
				modSaBan.MenuFontSize = fontDialog.Font.Size
				modSaBan.MenuFontStyle = fontDialog.Font.Style
				modSaBan.NoActColor = fontDialog.Color
				Me.myFont = fontDialog.Font
				Me.PreUpdateMnuItem()
				Me.Invalidate()
			End If
		End Sub

		Private Sub DonDongToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim cMnuItem2 As CMnuItem = cMnuItem
					cMnuItem2.PosY -= Me.deltaY * num
					num += 1
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.Invalidate()
		End Sub

		Private Sub DanDongToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim cMnuItem2 As CMnuItem = cMnuItem
					cMnuItem2.PosY += Me.deltaY * num
					num += 1
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.Invalidate()
		End Sub

		Private Sub DichTraiToolStripMenuItem_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim cMnuItem2 As CMnuItem = cMnuItem
					cMnuItem2.PosX -= Me.deltaX
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.Invalidate()
		End Sub

		Private Sub DichPhaiToolStripMenuItem_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim cMnuItem2 As CMnuItem = cMnuItem
					cMnuItem2.PosX += Me.deltaX
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.Invalidate()
		End Sub

		Private Sub DichLenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim cMnuItem2 As CMnuItem = cMnuItem
					cMnuItem2.PosY -= Me.deltaY
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.Invalidate()
		End Sub

		Private Sub DichXuongToolStripMenuItem_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CMnuItem).Enumerator = Me.mnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItem = enumerator.Current
					Dim cMnuItem As CMnuItem = current
					Dim cMnuItem2 As CMnuItem = cMnuItem
					cMnuItem2.PosY += Me.deltaY
				End While
			Finally
				Dim enumerator As List(Of CMnuItem).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.Invalidate()
		End Sub
	End Class
End Namespace
