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
	Public Class dlgMenuReloc
		Inherits Form

		Private Enum VeTools
			None
			MoveMnuItem
		End Enum

		Private components As IContainer

		<AccessedThroughProperty("AllContextMenuStrip")>
		Private _AllContextMenuStrip As ContextMenuStrip

		<AccessedThroughProperty("ChangeFontToolStripMenuItem")>
		Private _ChangeFontToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("MoveHidenItemsToolStripMenuItem")>
		Private _MoveHidenItemsToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("DoiMauNenToolStripMenuItem")>
		Private _DoiMauNenToolStripMenuItem As ToolStripMenuItem

		Private MyMnuDef As CMyMnuDef

		Private seleMnuItems As List(Of CMnuItemDef)

		Private selectionDragging As Boolean

		Private selectionRect As Rectangle

		Private snapX As Integer

		Private snapY As Integer

		Private deltaX As Integer

		Private deltaY As Integer

		Private CounterPos As Integer

		Private mNoActBrush As SolidBrush

		Private mActBrush As SolidBrush

		Private myFont As Font

		Private bLoaded As Boolean

		Private CtxMnuPt As Point

		Private m_DrawTool As dlgMenuReloc.VeTools

		Private m_ShiftY As Integer

		Private myfromPt As Point

		Private mytoPt As Point

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

		Friend Overridable Property MoveHidenItemsToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._MoveHidenItemsToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MoveHidenItemsToolStripMenuItem_Click
				If Me._MoveHidenItemsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._MoveHidenItemsToolStripMenuItem.Click, value2
				End If
				Me._MoveHidenItemsToolStripMenuItem = value
				If Me._MoveHidenItemsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._MoveHidenItemsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property PictureBox1() As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.dlgMenu_Paint
				Dim value3 As MouseEventHandler = AddressOf Me.dlgMenu_MouseUp
				Dim value4 As MouseEventHandler = AddressOf Me.dlgMenu_MouseMove
				Dim value5 As MouseEventHandler = AddressOf Me.dlgMenu_MouseDown
				Dim value6 As MouseEventHandler = AddressOf Me.dlgMenuReloc_MouseDoubleClick
				If Me._PictureBox1 IsNot Nothing Then
					RemoveHandler Me._PictureBox1.Paint, value2
					RemoveHandler Me._PictureBox1.MouseUp, value3
					RemoveHandler Me._PictureBox1.MouseMove, value4
					RemoveHandler Me._PictureBox1.MouseDown, value5
					RemoveHandler Me._PictureBox1.MouseDoubleClick, value6
				End If
				Me._PictureBox1 = value
				If Me._PictureBox1 IsNot Nothing Then
					AddHandler Me._PictureBox1.Paint, value2
					AddHandler Me._PictureBox1.MouseUp, value3
					AddHandler Me._PictureBox1.MouseMove, value4
					AddHandler Me._PictureBox1.MouseDown, value5
					AddHandler Me._PictureBox1.MouseDoubleClick, value6
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

		Friend Overridable Property ToolStripSeparator2() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		Friend Overridable Property DoiMauNenToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DoiMauNenToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DoiMauNenToolStripMenuItem_Click
				If Me._DoiMauNenToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DoiMauNenToolStripMenuItem.Click, value2
				End If
				Me._DoiMauNenToolStripMenuItem = value
				If Me._DoiMauNenToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DoiMauNenToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgMenu_Load
			Me.seleMnuItems = New List(Of CMnuItemDef)()
			Me.selectionDragging = False
			Me.snapX = 10
			Me.snapY = 5
			Me.deltaX = 5
			Me.deltaY = 2
			' The following expression was wrapped in a checked-expression
			Me.CounterPos = CInt(Math.Round(CDec(modSaBan.MenuFontSize))) + 18
			Me.mNoActBrush = New SolidBrush(modSaBan.NoActColor)
			Me.mActBrush = New SolidBrush(modSaBan.ActColor)
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
			Me.AllContextMenuStrip = New ContextMenuStrip(Me.components)
			Me.ChangeFontToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.MoveHidenItemsToolStripMenuItem = New ToolStripMenuItem()
			Me.PictureBox1 = New PictureBox()
			Me.Label5 = New Label()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.DoiMauNenToolStripMenuItem = New ToolStripMenuItem()
			Me.AllContextMenuStrip.SuspendLayout()
			(CType(Me.PictureBox1, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.AllContextMenuStrip.Items.AddRange(New ToolStripItem() { Me.ChangeFontToolStripMenuItem, Me.ToolStripSeparator1, Me.MoveHidenItemsToolStripMenuItem, Me.ToolStripSeparator2, Me.DoiMauNenToolStripMenuItem })
			Me.AllContextMenuStrip.Name = "AllContextMenuStrip"
			Dim arg_EF_0 As Control = Me.AllContextMenuStrip
			Dim size As Size = New Size(301, 82)
			arg_EF_0.Size = size
			Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
			Dim arg_119_0 As ToolStripItem = Me.ChangeFontToolStripMenuItem
			size = New Size(300, 22)
			arg_119_0.Size = size
			Me.ChangeFontToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i font"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim arg_152_0 As ToolStripItem = Me.ToolStripSeparator1
			size = New Size(297, 6)
			arg_152_0.Size = size
			Me.MoveHidenItemsToolStripMenuItem.Name = "MoveHidenItemsToolStripMenuItem"
			Dim arg_17C_0 As ToolStripItem = Me.MoveHidenItemsToolStripMenuItem
			size = New Size(300, 22)
			arg_17C_0.Size = size
			Me.MoveHidenItemsToolStripMenuItem.Text = "Chuy" & ChrW(7875) & "n MenuItem không nhìn th" & ChrW(7845) & "y l" & ChrW(7841) & "i " & ChrW(273) & "ây"
			Me.PictureBox1.Dock = DockStyle.Fill
			Dim arg_1AE_0 As Control = Me.PictureBox1
			Dim location As Point = New Point(0, 0)
			arg_1AE_0.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_1DB_0 As Control = Me.PictureBox1
			size = New Size(1131, 429)
			arg_1DB_0.Size = size
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.Label5.BackColor = Color.LightCyan
			Me.Label5.ForeColor = SystemColors.ControlText
			Dim arg_22E_0 As Control = Me.Label5
			location = New Point(359, 9)
			arg_22E_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_258_0 As Control = Me.Label5
			size = New Size(682, 35)
			arg_258_0.Size = size
			Me.Label5.TabIndex = 40
			Me.Label5.Text = "Tro giup"
			Me.Label5.TextAlign = ContentAlignment.MiddleCenter
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim arg_2AB_0 As ToolStripItem = Me.ToolStripSeparator2
			size = New Size(297, 6)
			arg_2AB_0.Size = size
			Me.DoiMauNenToolStripMenuItem.Name = "DoiMauNenToolStripMenuItem"
			Dim arg_2D5_0 As ToolStripItem = Me.DoiMauNenToolStripMenuItem
			size = New Size(300, 22)
			arg_2D5_0.Size = size
			Me.DoiMauNenToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i m" & ChrW(7847) & "u nèn"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.LightBlue
			size = New Size(1131, 429)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.PictureBox1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgMenuReloc"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Dlg3DShow"
			Me.WindowState = FormWindowState.Maximized
			Me.AllContextMenuStrip.ResumeLayout(False)
			(CType(Me.PictureBox1, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private Function SelesHit(pt As Point, pseleMnuItems As List(Of CMnuItemDef)) As Boolean
			Dim result As Boolean = False
			Try
				Dim enumerator As List(Of CMnuItemDef).Enumerator = pseleMnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItemDef = enumerator.Current
					If current.HitTest(pt) Then
						result = True
						Exit While
					End If
				End While
			Finally
				Dim enumerator As List(Of CMnuItemDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Return result
		End Function

		Private Function FindMnuItem(pt As Point) As CMnuItemDef
			Dim result As CMnuItemDef = Nothing
			Try
				Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.MyMnuDef.MnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItemDef = enumerator.Current
					If current.HitTest(pt) Then
						result = current
						Exit While
					End If
				End While
			Finally
				Dim enumerator As List(Of CMnuItemDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Return result
		End Function

		Public Function ShowDialog(pParentf As dlgMenuEdit, pMyMnuDef As CMyMnuDef) As DialogResult
			Me.MyMnuDef = pMyMnuDef
			Return Me.ShowDialog(pParentf)
		End Function

		Private Sub dlgMenu_Load(sender As Object, e As EventArgs)
			Me.PictureBox1.BackColor = modSaBan.BGrColor
			Me.Text = "    B" & ChrW(7889) & " trí l" & ChrW(7841) & "i Menu:"
			Dim obj As Object = ChrW(272) & ChrW(7875) & " b" & ChrW(7889) & " trí l" & ChrW(7841) & "i Menu: kéo tr" & ChrW(7921) & "c ti" & ChrW(7871) & "p các MenuItem " & ChrW(273) & ChrW(7875) & " thay " & ChrW(273) & ChrW(7893) & "i v" & ChrW(7883) & " trí... Nháy ph" & ChrW(7843) & "i chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " hi" & ChrW(7879) & "n menu thay " & ChrW(273) & ChrW(7893) & "i font. " & vbCrLf
			obj = Operators.ConcatenateObject(obj, "(" & ChrW(272) & ChrW(7875) & " ch" & ChrW(7885) & "n nhi" & ChrW(7873) & "u MenuItem: b" & ChrW(7845) & "m Shift + kéo chu" & ChrW(7897) & "t theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng chéo, b" & ChrW(7845) & "m Ctrl + nháy chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n b" & ChrW(7893) & " xung)")
			Me.Label5.Text = Conversions.ToString(obj)
			Me.PreUpdateMnuItem()
			Me.bLoaded = True
		End Sub

		Private Sub PreUpdateMnuItem()
			' The following expression was wrapped in a checked-statement
			Me.CounterPos = CInt(Math.Round(CDec(modSaBan.MenuFontSize))) + 18
			Me.mNoActBrush.Color = modSaBan.NoActColor
			Me.mActBrush.Color = modSaBan.ActColor
			Dim graphics As Graphics = Me.PictureBox1.CreateGraphics()
			Try
				Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.MyMnuDef.MnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItemDef = enumerator.Current
					Dim cMnuItemDef As CMnuItemDef = current
					Dim sizeF As SizeF = graphics.MeasureString(cMnuItemDef.Name, Me.myFont)
					cMnuItemDef.Width = CInt(Math.Round(CDec(sizeF.Width)))
					cMnuItemDef.Height = CInt(Math.Round(CDec(sizeF.Height)))
				End While
			Finally
				Dim enumerator As List(Of CMnuItemDef).Enumerator
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
			g.DrawString("60.00 fps", Me.myFont, Brushes.Red, 10F, 10F)
			g.DrawString("Ch" & ChrW(7885) & "n hành " & ChrW(273) & ChrW(7897) & "ng...", Me.myFont, Brushes.Black, 10F, CSng(Me.CounterPos))
			Try
				Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.MyMnuDef.MnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItemDef = enumerator.Current
					Dim cMnuItemDef As CMnuItemDef = current
					If cMnuItemDef.PosX <> 0 Or cMnuItemDef.PosY <> 0 Then
						If Me.seleMnuItems.IndexOf(current) > -1 Then
							g.DrawString(cMnuItemDef.Name, Me.myFont, Me.mActBrush, CSng(cMnuItemDef.PosX), CSng(cMnuItemDef.PosY))
						Else
							g.DrawString(cMnuItemDef.Name, Me.myFont, Me.mNoActBrush, CSng(cMnuItemDef.PosX), CSng(cMnuItemDef.PosY))
						End If
					End If
				End While
			Finally
				Dim enumerator As List(Of CMnuItemDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
		End Sub

		Private Sub DrawSelectionRectangle(selectionRect As RectangleF)
			Dim graphics As Graphics = Me.PictureBox1.CreateGraphics()
			Me.Refresh()
			Dim brush As SolidBrush = New SolidBrush(Color.FromArgb(75, Color.Gray))
			Dim rect As RectangleF
			rect.Size = selectionRect.Size
			If selectionRect.Width < 0F Then
				rect.X = selectionRect.X - rect.Width
			Else
				rect.X = selectionRect.X
			End If
			If selectionRect.Height < 0F Then
				rect.Y = selectionRect.Y - rect.Height
			Else
				rect.Y = selectionRect.Y
			End If
			graphics.FillRectangle(brush, rect)
		End Sub

		Private Sub dlgMenuReloc_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Dim pt As Point = New Point(e.X, e.Y)
			Dim cMnuItemDef As CMnuItemDef = Me.FindMnuItem(pt)
			If Not Information.IsNothing(cMnuItemDef) Then
				Dim text As String = ""
				Try
					Dim enumerator As List(Of CItemScriptDef).Enumerator = cMnuItemDef.ItemScripts.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As CItemScriptDef = enumerator.Current
						text = text + current.ToStr() + vbCrLf
					End While
				Finally
					Dim enumerator As List(Of CItemScriptDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
				Interaction.MsgBox(text, MsgBoxStyle.OkOnly, cMnuItemDef.Name)
			End If
		End Sub

		Private Sub dlgMenu_MouseDown(sender As Object, e As MouseEventArgs)
			Dim pt As Point = Me.Snap(CSng(e.X), CSng(e.Y))
			If(e.Button And MouseButtons.Right) > MouseButtons.None Then
				Me.seleMnuItems.Clear()
				Me.PictureBox1.Invalidate()
				Me.CtxMnuPt = New Point(e.X, e.Y)
				Dim arg_6F_0 As ToolStripDropDown = Me.AllContextMenuStrip
				Dim point As Point = New Point(e.X, e.Y)
				arg_6F_0.Show(Me, point)
			Else If(Control.ModifierKeys And Keys.Control) = Keys.Control Then
				Dim cMnuItemDef As CMnuItemDef = Me.FindMnuItem(pt)
				If Not Information.IsNothing(cMnuItemDef) Then
					If Me.seleMnuItems.Contains(cMnuItemDef) Then
						Me.seleMnuItems.Remove(cMnuItemDef)
					Else
						Me.seleMnuItems.Add(cMnuItemDef)
					End If
				End If
				Me.PictureBox1.Invalidate()
			Else If(Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
				Me.seleMnuItems.Clear()
				Me.PictureBox1.Invalidate()
				Me.selectionDragging = True
				Me.selectionRect.X = e.X
				Me.selectionRect.Y = e.Y
				Me.selectionRect.Height = 0
				Me.selectionRect.Width = 0
			Else
				If Me.seleMnuItems.Count > 0 Then
					Dim point As Point = New Point(e.X, e.Y)
					If Me.SelesHit(point, Me.seleMnuItems) Then
						Me.m_DrawTool = dlgMenuReloc.VeTools.MoveMnuItem
						Me.myfromPt = pt
						Me.mytoPt = pt
					Else
						Me.seleMnuItems.Clear()
						Dim cMnuItemDef2 As CMnuItemDef = Me.FindMnuItem(pt)
						If Not Information.IsNothing(cMnuItemDef2) Then
							Me.seleMnuItems.Add(cMnuItemDef2)
							Me.m_DrawTool = dlgMenuReloc.VeTools.MoveMnuItem
							Me.myfromPt = pt
							Me.mytoPt = pt
						End If
					End If
				Else
					Dim cMnuItemDef3 As CMnuItemDef = Me.FindMnuItem(pt)
					If Not Information.IsNothing(cMnuItemDef3) Then
						Me.seleMnuItems.Add(cMnuItemDef3)
						Me.m_DrawTool = dlgMenuReloc.VeTools.MoveMnuItem
						Me.myfromPt = pt
						Me.mytoPt = pt
					End If
				End If
				Me.PictureBox1.Invalidate()
			End If
		End Sub

		Private Sub dlgMenu_MouseMove(sender As Object, e As MouseEventArgs)
			Dim point As Point = Me.Snap(CSng(e.X), CSng(e.Y))
			' The following expression was wrapped in a checked-statement
			If Me.selectionDragging Then
				Me.selectionRect.Width = e.X - Me.selectionRect.X
				Me.selectionRect.Height = e.Y - Me.selectionRect.Y
				Me.DrawSelectionRectangle(Me.selectionRect)
			End If
			If Me.m_DrawTool = dlgMenuReloc.VeTools.MoveMnuItem AndAlso Me.seleMnuItems.Count > 0 Then
				Me.mytoPt = point
				Try
					Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.seleMnuItems.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As CMnuItemDef = enumerator.Current
						Dim cMnuItemDef As CMnuItemDef = current
						Dim cMnuItemDef2 As CMnuItemDef = cMnuItemDef
						cMnuItemDef2.PosX += Me.mytoPt.X - Me.myfromPt.X
						cMnuItemDef2 = cMnuItemDef
						cMnuItemDef2.PosY += Me.mytoPt.Y - Me.myfromPt.Y
					End While
				Finally
					Dim enumerator As List(Of CMnuItemDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
				Me.PictureBox1.Invalidate()
				Me.myfromPt = Me.mytoPt
			End If
		End Sub

		Private Sub dlgMenu_MouseUp(sender As Object, e As MouseEventArgs)
			If Me.selectionDragging Then
				Me.selectionDragging = False
				Try
					Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.MyMnuDef.MnuItems.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As CMnuItemDef = enumerator.Current
						If current.IsInRect(Me.selectionRect) Then
							Me.seleMnuItems.Add(current)
						End If
					End While
				Finally
					Dim enumerator As List(Of CMnuItemDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
				Me.PictureBox1.Invalidate()
			End If
			Me.m_DrawTool = dlgMenuReloc.VeTools.None
		End Sub

		Private Sub dlgMenu_Paint(sender As Object, e As PaintEventArgs)
			If Me.bLoaded Then
				Dim graphics As Graphics = e.Graphics
				graphics.TranslateTransform(0F, CSng(Me.m_ShiftY))
				Me.DrawMenu(graphics)
			End If
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
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
				Me.PictureBox1.Invalidate()
			End If
		End Sub

		Private Sub MoveHidenItemsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim list As List(Of CMnuItemDef) = New List(Of CMnuItemDef)()
			Dim pRect As Rectangle = New Rectangle(0, 0, Me.PictureBox1.Width, Me.PictureBox1.Height)
			Try
				Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.MyMnuDef.MnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItemDef = enumerator.Current
					If current.NotInRect(pRect) Then
						list.Add(current)
					End If
				End While
			Finally
				Dim enumerator As List(Of CMnuItemDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			' The following expression was wrapped in a checked-statement
			If list.Count > 0 Then
				Dim num As Integer = 0
				Dim num2 As Integer = CInt(Math.Round(CDec(modSaBan.MenuFontSize))) + 4
				Try
					Dim enumerator2 As List(Of CMnuItemDef).Enumerator = list.GetEnumerator()
					While enumerator2.MoveNext()
						Dim current2 As CMnuItemDef = enumerator2.Current
						Dim cMnuItemDef As CMnuItemDef = current2
						cMnuItemDef.PosX = Me.CtxMnuPt.X
						cMnuItemDef.PosY = Me.CtxMnuPt.Y + num * num2
						num += 1
					End While
				Finally
					Dim enumerator2 As List(Of CMnuItemDef).Enumerator
					(CType(enumerator2, IDisposable)).Dispose()
				End Try
				Me.PictureBox1.Invalidate()
			Else
				Interaction.MsgBox("Không có MenuItem nào không nhìn th" & ChrW(7845) & "y.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub DoiMauNenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim colorDialog As ColorDialog = New ColorDialog()
			colorDialog.AllowFullOpen = True
			colorDialog.ShowHelp = True
			colorDialog.Color = Me.PictureBox1.BackColor
			colorDialog.ShowDialog()
			modSaBan.BGrColor = colorDialog.Color
			Me.PictureBox1.BackColor = modSaBan.BGrColor
			Me.PictureBox1.Invalidate()
		End Sub
	End Class
End Namespace
