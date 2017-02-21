Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	Public Class CThumbNails
		Inherits CollectionBase

		Public Delegate Sub SelectedIndexChangedEventHandler(e As MouseEventArgs)

		Public Delegate Sub ChonEventHandler(index As Integer)

		Private SelectedIndexChangedEvent As CThumbNails.SelectedIndexChangedEventHandler

		Private ChonEvent As CThumbNails.ChonEventHandler

		<AccessedThroughProperty("m_PicBox")>
		Private _m_PicBox As PictureBox

		Private currentTopLeftItem As Integer

		Private m_SelectedIndex As Integer

		Private m_GenericImage As String

		Private x As Integer

		Private y As Integer

		Private h As Integer

		Private w As Integer

		Private rowsPerPage As Integer

		Private colsPerPage As Integer

		Public Custom Event SelectedIndexChanged As CThumbNails.SelectedIndexChangedEventHandler
			<MethodImpl(MethodImplOptions.Synchronized)>
			AddHandler
				Me.SelectedIndexChangedEvent = CType([Delegate].Combine(Me.SelectedIndexChangedEvent, value), CThumbNails.SelectedIndexChangedEventHandler)
			End AddHandler
			<MethodImpl(MethodImplOptions.Synchronized)>
			RemoveHandler
				Me.SelectedIndexChangedEvent = CType([Delegate].Remove(Me.SelectedIndexChangedEvent, value), CThumbNails.SelectedIndexChangedEventHandler)
			End RemoveHandler
		End Event

		Public Custom Event Chon As CThumbNails.ChonEventHandler
			<MethodImpl(MethodImplOptions.Synchronized)>
			AddHandler
				Me.ChonEvent = CType([Delegate].Combine(Me.ChonEvent, value), CThumbNails.ChonEventHandler)
			End AddHandler
			<MethodImpl(MethodImplOptions.Synchronized)>
			RemoveHandler
				Me.ChonEvent = CType([Delegate].Remove(Me.ChonEvent, value), CThumbNails.ChonEventHandler)
			End RemoveHandler
		End Event

		Protected Overridable Property m_PicBox() As PictureBox
			Get
				Return Me._m_PicBox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.m_PicBox_Resize
				Dim value3 As PaintEventHandler = AddressOf Me.m_PicBox_Paint
				Dim value4 As EventHandler = AddressOf Me.m_PicBox_DoubleClick
				Dim value5 As MouseEventHandler = AddressOf Me.m_PicBox_MouseUp
				If Me._m_PicBox IsNot Nothing Then
					RemoveHandler Me._m_PicBox.Resize, value2
					RemoveHandler Me._m_PicBox.Paint, value3
					RemoveHandler Me._m_PicBox.DoubleClick, value4
					RemoveHandler Me._m_PicBox.MouseUp, value5
				End If
				Me._m_PicBox = value
				If Me._m_PicBox IsNot Nothing Then
					AddHandler Me._m_PicBox.Resize, value2
					AddHandler Me._m_PicBox.Paint, value3
					AddHandler Me._m_PicBox.DoubleClick, value4
					AddHandler Me._m_PicBox.MouseUp, value5
				End If
			End Set
		End Property

		Public Property HorizontalSpacing() As Integer
			Get
				Return Me.x
			End Get
			Set(value As Integer)
				Me.x = value
				Me.CalculateRowsAndColumns()
			End Set
		End Property

		Public Property VerticalSpacing() As Integer
			Get
				Return Me.y
			End Get
			Set(value As Integer)
				Me.y = value
				Me.CalculateRowsAndColumns()
			End Set
		End Property

		Public Property ImageHeight() As Integer
			Get
				Return Me.h
			End Get
			Set(value As Integer)
				Me.h = value
				Me.CalculateRowsAndColumns()
			End Set
		End Property

		Public Property ImageWidth() As Integer
			Get
				Return Me.w
			End Get
			Set(value As Integer)
				Me.w = value
				Me.CalculateRowsAndColumns()
			End Set
		End Property

		Public Property SelectedIndex() As Integer
			Get
				Return Me.m_SelectedIndex
			End Get
			Set(value As Integer)
				Dim list As IList = Me.List
				' The following expression was wrapped in a checked-statement
				If list IsNot Nothing Then
					Dim num As Integer = Me.currentTopLeftItem
					Dim selectedIndex As Integer = Me.m_SelectedIndex
					If value < 0 Then
						If selectedIndex <> value Then
							Me.m_SelectedIndex = value
							Me.m_PicBox.Invalidate()
						End If
					Else If value >= 0 And value < list.Count Then
						If value - Me.currentTopLeftItem >= Me.rowsPerPage * Me.colsPerPage Then
							Do
								Me.currentTopLeftItem += Me.rowsPerPage * Me.colsPerPage
							Loop While value - Me.currentTopLeftItem >= Me.rowsPerPage * Me.colsPerPage
						Else If value - Me.currentTopLeftItem < 0 Then
							Do
								Me.currentTopLeftItem -= Me.rowsPerPage * Me.colsPerPage
							Loop While value - Me.currentTopLeftItem < 0
						End If
						If Me.currentTopLeftItem < 0 Then
							Me.currentTopLeftItem = 0
						End If
						If selectedIndex <> value Then
							Me.m_SelectedIndex = value
							If num <> Me.currentTopLeftItem Then
								Me.m_PicBox.Invalidate()
							Else
								Me.RefreshItem(selectedIndex)
								Me.RefreshItem(value)
							End If
						End If
					End If
				End If
			End Set
		End Property

		Public ReadOnly Default Property Item(index As Integer) As CThumbNail
			Get
				Return CType(Me.List(index), CThumbNail)
			End Get
		End Property

		Public Sub Add(aThumbNail As CThumbNail)
			Me.List.Add(aThumbNail)
		End Sub

		Public Function GetCount() As Integer
			Return Me.List.Count
		End Function

		Public Sub InsertAt(index As Integer, aThumbNail As CThumbNail)
			If index > Me.Count Or index < 0 Then
				MessageBox.Show("Index not valid!")
			Else If index = Me.Count Then
				Me.List.Add(aThumbNail)
			Else
				Me.List.Insert(index, aThumbNail)
			End If
		End Sub

		Public Sub Remove(index As Integer)
			' The following expression was wrapped in a checked-expression
			If index > Me.Count - 1 Or index < 0 Then
				MessageBox.Show("Index not valid!")
			Else
				Me.List.RemoveAt(index)
			End If
		End Sub

		Public Sub Remove(aThumbNail As CThumbNail)
			Me.List.Remove(aThumbNail)
		End Sub

		Public Function GetItemByID(pId As Integer) As CThumbNail
			Dim result As CThumbNail
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cThumbNail As CThumbNail = CType(enumerator.Current, CThumbNail)
					If cThumbNail.ID = pId Then
						result = cThumbNail
						Return result
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			result = Nothing
			Return result
		End Function

		Public Function MoveItem(pItemId As Integer, pDestItemID As Integer) As Integer
			Dim num As Integer = -1
			Dim itemByID As CThumbNail = Me.GetItemByID(pItemId)
			Me.Remove(itemByID)
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cThumbNail As CThumbNail = CType(enumerator.Current, CThumbNail)
					num += 1
					If cThumbNail.ID = pDestItemID Then
						Me.InsertAt(num, itemByID)
						result = num
						Return result
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			result = -1
			Return result
		End Function

		Public Function GetMaxID() As Integer
			Dim num As Integer = 0
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cThumbNail As CThumbNail = CType(enumerator.Current, CThumbNail)
					If cThumbNail.ID > num Then
						num = cThumbNail.ID
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return num
		End Function

		Private Sub m_PicBox_Paint(sender As Object, e As PaintEventArgs)
			Dim graphics As Graphics = e.Graphics
			graphics.SmoothingMode = SmoothingMode.AntiAlias
			Dim list As IList = Me.List
			' The following expression was wrapped in a checked-statement
			If list IsNot Nothing AndAlso list.Count > 0 Then
				Dim count As Integer = list.Count
				Dim num As Integer = Me.currentTopLeftItem
				Dim arg_41_0 As Integer = 0
				Dim num2 As Integer = Me.rowsPerPage - 1
				For i As Integer = arg_41_0 To num2
					Dim arg_4F_0 As Integer = 0
					Dim num3 As Integer = Me.colsPerPage - 1
					For j As Integer = arg_4F_0 To num3
						If num < count Then
							Me.DrawOneItem(num, i, j, graphics)
							num += 1
						End If
					Next
				Next
				Dim font As Font = New Font("Webdings", 20F, FontStyle.Regular, GraphicsUnit.Pixel)
				Dim solidBrush As SolidBrush = New SolidBrush(Me.m_PicBox.ForeColor)
				If num <= count - 1 Then
					graphics.DrawString("6", font, solidBrush, 0F, CSng((Me.m_PicBox.Height - 24)))
				End If
				If Me.currentTopLeftItem > 0 Then
					graphics.DrawString("5", font, solidBrush, 0F, 0F)
				End If
				font.Dispose()
				solidBrush.Dispose()
			End If
		End Sub

		Private Sub DrawOneItem(index As Integer, row As Integer, col As Integer, gr As Graphics)
			Dim font As Font = Me.m_PicBox.Font
			Dim solidBrush As SolidBrush = New SolidBrush(Me.m_PicBox.ForeColor)
			Dim stringFormat As StringFormat = New StringFormat()
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.FormatFlags = StringFormatFlags.LineLimit
			Dim cThumbNail As CThumbNail = CType(Me.List(index), CThumbNail)
			Dim symbols As String = cThumbNail.Symbols
			Dim cGraphicObjs As CGraphicObjs = CGraphicObjs.Str2Objects(symbols, 0, 0, modBdTC.cDecSepa, modBdTC.cGrpSepa)
			Dim size As Size = cGraphicObjs.GetSize()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num2 As Integer
			If size.Height > Me.h Then
				num = Me.h
				' The following expression was wrapped in a unchecked-expression
				num2 = CInt(Math.Round(CDec(Me.h) / CDec(size.Height) * CDec(size.Width)))
			Else
				num = size.Height
				num2 = size.Width
			End If
			If num2 > Me.w Then
				' The following expression was wrapped in a unchecked-expression
				num = CInt(Math.Round(CDec(Me.w) / CDec(num2) * CDec(num)))
				num2 = Me.w
			End If
			Dim rect As Rectangle = New Rectangle(2 * Me.x + col * (2 * Me.x + Me.w), 1 * Me.y + row * (2 * Me.y + Me.h), Me.w, Me.h)
			gr.FillRectangle(New SolidBrush(Color.LightGray), rect)
			Dim imageRect As Rectangle = New Rectangle(2 * Me.x + col * (2 * Me.x + Me.w) + (Me.w - num2) / 2, 1 * Me.y + row * (2 * Me.y + Me.h) + (Me.h - num) / 2, num2, num)
			Me.DrawThumbNail(gr, cGraphicObjs, imageRect)
			Dim pen As Pen = Nothing
			If index = Me.m_SelectedIndex Then
				pen = New Pen(Color.Yellow)
				pen.Width = 4F
				gr.DrawRectangle(pen, rect)
			End If
			If Not Information.IsNothing(pen) Then
				pen.Dispose()
			End If
			Dim num3 As Integer = Me.y * 2
			Dim arg_24A_1 As String = cThumbNail.Value
			Dim arg_24A_2 As Font = font
			Dim arg_24A_3 As Brush = solidBrush
			Dim layoutRectangle As RectangleF = New RectangleF(CSng((Me.x + col * (2 * Me.x + Me.w))), CSng((2 + 1 * Me.y + Me.h + row * (2 * Me.y + Me.h))), CSng((Me.w + 2 * Me.x)), CSng(num3))
			gr.DrawString(arg_24A_1, arg_24A_2, arg_24A_3, layoutRectangle, stringFormat)
		End Sub

		Private Sub DrawThumbNail(g As Graphics, mObjs As CGraphicObjs, imageRect As Rectangle)
			Dim num As Single = CSng(mObjs.GetSize().Width)
			Dim num2 As Single
			If num > 0F Then
				num2 = CSng(imageRect.Width) / num
			Else
				num2 = 1F
			End If
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(CSng(imageRect.X), CSng(imageRect.Y))
			g.ScaleTransform(num2, num2)
			Try
				Dim enumerator As IEnumerator = mObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					If graphicObject.GetObjType() <> OBJECTTYPE.Text Then
						graphicObject.Draw(g)
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			g.EndContainer(container)
		End Sub

		Public Sub CalculateRowsAndColumns()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.m_PicBox.Height - 24
			Dim num2 As Integer = (num - Me.y) / (2 * Me.y + Me.h)
			Dim num3 As Integer = Me.m_PicBox.Width / (2 * Me.x + Me.w)
			If num2 <> Me.rowsPerPage OrElse num3 <> Me.colsPerPage Then
				Me.rowsPerPage = num2
				Me.colsPerPage = num3
			End If
		End Sub

		Private Function GetItemRect(index As Integer) As Rectangle
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(Math.Floor(CDec((index - Me.currentTopLeftItem)) / CDec(Me.colsPerPage))))
			Dim num2 As Integer = (index - Me.currentTopLeftItem) Mod Me.colsPerPage
			Dim result As Rectangle = New Rectangle(Me.x + num2 * (2 * Me.x + Me.w), 1 * Me.y + num * (2 * Me.y + Me.h), Me.w + 2 * Me.x, Me.h + Me.y * 2)
			Return result
		End Function

		Private Sub m_PicBox_Resize(sender As Object, e As EventArgs)
			Me.CalculateRowsAndColumns()
			Me.m_PicBox.Invalidate()
		End Sub

		Public Sub New(pPicBox As PictureBox)
			Me.currentTopLeftItem = 0
			Me.m_SelectedIndex = 0
			Me.m_GenericImage = ""
			Me.x = 10
			Me.y = 16
			Me.h = 40
			Me.w = 40
			Me.rowsPerPage = 0
			Me.colsPerPage = 0
			Me.m_PicBox = pPicBox
			Me.CalculateRowsAndColumns()
		End Sub

		Private Function HitTest(loc As Point) As Integer
			Dim flag As Boolean = False
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			While num < Me.List.Count And Not flag
				If Me.GetItemRect(num).Contains(loc) Then
					flag = True
				Else
					num += 1
				End If
			End While
			Dim result As Integer
			If flag Then
				result = num
			Else
				result = -1
			End If
			Return result
		End Function

		Protected Sub RefreshItem(index As Integer)
			Dim itemRect As Rectangle = Me.GetItemRect(index)
			itemRect.Inflate(5, 5)
			Me.m_PicBox.Invalidate(itemRect)
		End Sub

		Private Sub m_PicBox_MouseUp(sender As Object, e As MouseEventArgs)
			Dim loc As Point = New Point(e.X, e.Y)
			Dim num As Integer = Me.HitTest(loc)
			If num > -1 Then
				Me.SelectedIndex = num
			Else
				Me.SelectedIndex = -1
			End If
			Dim selectedIndexChangedEvent As CThumbNails.SelectedIndexChangedEventHandler = Me.SelectedIndexChangedEvent
			If selectedIndexChangedEvent IsNot Nothing Then
				selectedIndexChangedEvent(e)
			End If
		End Sub

		Private Sub m_PicBox_DoubleClick(sender As Object, e As EventArgs)
			If Me.m_SelectedIndex > -1 Then
				Dim chonEvent As CThumbNails.ChonEventHandler = Me.ChonEvent
				If chonEvent IsNot Nothing Then
					chonEvent(Me.m_SelectedIndex)
				End If
			End If
		End Sub
	End Class
End Namespace
