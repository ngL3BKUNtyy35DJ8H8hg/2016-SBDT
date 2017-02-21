Imports DBiGraphicObjs.DBiGraphicObjects
Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	Public Class CThumbNails
		Inherits CollectionBase

		Public Delegate Sub SelectedIndexChangedEventHandler(e As EventArgs)

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private SelectedIndexChangedEvent As CThumbNails.SelectedIndexChangedEventHandler

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
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			AddHandler
				Me.SelectedIndexChangedEvent = CType([Delegate].Combine(Me.SelectedIndexChangedEvent, value), CThumbNails.SelectedIndexChangedEventHandler)
			End AddHandler
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			RemoveHandler
				Me.SelectedIndexChangedEvent = CType([Delegate].Remove(Me.SelectedIndexChangedEvent, value), CThumbNails.SelectedIndexChangedEventHandler)
			End RemoveHandler
		End Event

		Private Overridable Property m_PicBox() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._m_PicBox
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim flag As Boolean = Me._m_PicBox IsNot Nothing
				If flag Then
					RemoveHandler Me._m_PicBox.MouseUp, AddressOf Me.m_PicBox_MouseUp
					RemoveHandler Me._m_PicBox.Resize, AddressOf Me.m_PicBox_Resize
					RemoveHandler Me._m_PicBox.Paint, AddressOf Me.m_PicBox_Paint
					RemoveHandler Me._m_PicBox.MouseWheel, AddressOf Me.m_PicBox_MouseWheel
				End If
				Me._m_PicBox = value
				flag = (Me._m_PicBox IsNot Nothing)
				If flag Then
					AddHandler Me._m_PicBox.MouseUp, AddressOf Me.m_PicBox_MouseUp
					AddHandler Me._m_PicBox.Resize, AddressOf Me.m_PicBox_Resize
					AddHandler Me._m_PicBox.Paint, AddressOf Me.m_PicBox_Paint
					AddHandler Me._m_PicBox.MouseWheel, AddressOf Me.m_PicBox_MouseWheel
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
				Dim myList As IList = Me.List
				Dim flag As Boolean = myList IsNot Nothing
				' The following expression was wrapped in a checked-statement
				If flag Then
					Dim oldTopLeftItem As Integer = Me.currentTopLeftItem
					Dim oldValue As Integer = Me.m_SelectedIndex
					flag = (value < 0)
					If flag Then
						Me.m_SelectedIndex = value
					Else
						flag = (value >= 0 And value < myList.Count)
						If flag Then
							flag = (value - Me.currentTopLeftItem >= Me.rowsPerPage * Me.colsPerPage)
							If flag Then
								Do
									Me.currentTopLeftItem += Me.rowsPerPage * Me.colsPerPage
								Loop While value - Me.currentTopLeftItem >= Me.rowsPerPage * Me.colsPerPage
							Else
								flag = (value - Me.currentTopLeftItem < 0)
								If flag Then
									Do
										Me.currentTopLeftItem -= Me.rowsPerPage * Me.colsPerPage
									Loop While value - Me.currentTopLeftItem < 0
								End If
							End If
							flag = (Me.currentTopLeftItem < 0)
							If flag Then
								Me.currentTopLeftItem = 0
							End If
							flag = (oldValue <> value)
							If flag Then
								Me.m_SelectedIndex = value
								Dim selectedIndexChangedEvent As CThumbNails.SelectedIndexChangedEventHandler = Me.SelectedIndexChangedEvent
								flag = (selectedIndexChangedEvent IsNot Nothing)
								If flag Then
									selectedIndexChangedEvent(New EventArgs())
								End If
								flag = (oldTopLeftItem <> Me.currentTopLeftItem)
								If flag Then
									Me.m_PicBox.Invalidate()
								Else
									Me.RefreshItem(oldValue)
									Me.RefreshItem(value)
								End If
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
			Dim flag As Boolean = index > Me.Count Or index < 0
			If flag Then
				MessageBox.Show("Index not valid!")
			Else
				flag = (index = Me.Count)
				If flag Then
					Me.List.Add(aThumbNail)
				Else
					Me.List.Insert(index, aThumbNail)
				End If
			End If
		End Sub

		Public Sub Remove(index As Integer)
			' The following expression was wrapped in a checked-expression
			Dim flag As Boolean = index > Me.Count - 1 Or index < 0
			If flag Then
				MessageBox.Show("Index not valid!")
			Else
				Me.List.RemoveAt(index)
			End If
		End Sub

		Public Sub Remove(aThumbNail As CThumbNail)
			Me.List.Remove(aThumbNail)
		End Sub

		Public Function GetItemByID(pId As Integer) As CThumbNail
			Dim GetItemByID As CThumbNail
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim aThumbNail As CThumbNail = CType(enumerator.Current, CThumbNail)
					Dim flag As Boolean = aThumbNail.ID = pId
					If flag Then
						GetItemByID = aThumbNail
						Return GetItemByID
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			GetItemByID = Nothing
			Return GetItemByID
		End Function

		Public Function MoveItem(pItemId As Integer, pDestItemID As Integer) As Integer
			Dim i As Integer = -1
			Dim pItem As CThumbNail = Me.GetItemByID(pItemId)
			Me.Remove(pItem)
			' The following expression was wrapped in a checked-statement
			Dim MoveItem As Integer
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim aThumbNail As CThumbNail = CType(enumerator.Current, CThumbNail)
					i += 1
					Dim flag As Boolean = aThumbNail.ID = pDestItemID
					If flag Then
						Me.InsertAt(i, pItem)
						MoveItem = i
						Return MoveItem
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			MoveItem = -1
			Return MoveItem
		End Function

		Public Function GetMaxID() As Integer
			Dim iMax As Integer = 0
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim aThumbNail As CThumbNail = CType(enumerator.Current, CThumbNail)
					Dim flag As Boolean = aThumbNail.ID > iMax
					If flag Then
						iMax = aThumbNail.ID
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return iMax
		End Function

		Private Sub m_PicBox_MouseWheel(sender As Object, e As MouseEventArgs)
			Dim oldSelectedIndex As Integer = Me.m_SelectedIndex
			Dim flag As Boolean = e.Delta > 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean = oldSelectedIndex > 0
				If flag2 Then
					Me.SelectedIndex = oldSelectedIndex - 1
				End If
			Else
				Dim flag2 As Boolean = e.Delta < 0
				If flag2 Then
					flag = (oldSelectedIndex < Me.List.Count - 1)
					If flag Then
						Me.SelectedIndex = oldSelectedIndex + 1
					End If
				End If
			End If
		End Sub

		Private Sub m_PicBox_Paint(sender As Object, e As PaintEventArgs)
			Dim gr As Graphics = e.Graphics
			gr.SmoothingMode = SmoothingMode.AntiAlias
			Dim myList As IList = Me.List
			Dim flag As Boolean = myList IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean = myList.Count > 0
				If flag2 Then
					Dim itemCount As Integer = myList.Count
					Dim itemsDisplayed As Integer = Me.currentTopLeftItem
					Dim arg_53_0 As Integer = 0
					Dim num As Integer = Me.rowsPerPage - 1
					Dim i As Integer = arg_53_0
					While True
						Dim arg_A1_0 As Integer = i
						Dim num2 As Integer = num
						If arg_A1_0 > num2 Then
							Exit While
						End If
						Dim arg_61_0 As Integer = 0
						Dim num3 As Integer = Me.colsPerPage - 1
						Dim j As Integer = arg_61_0
						While True
							Dim arg_93_0 As Integer = j
							num2 = num3
							If arg_93_0 > num2 Then
								Exit While
							End If
							flag2 = (itemsDisplayed < itemCount)
							If flag2 Then
								Me.DrawOneItem(itemsDisplayed, i, j, gr)
								itemsDisplayed += 1
							End If
							j += 1
						End While
						i += 1
					End While
					Dim webdingsFont As Font = New Font("Webdings", 20F, FontStyle.Regular, GraphicsUnit.Pixel)
					Dim textBrush As SolidBrush = New SolidBrush(Me.m_PicBox.ForeColor)
					flag2 = (itemsDisplayed < itemCount - 1)
					If flag2 Then
						gr.DrawString("6", webdingsFont, textBrush, 0F, CSng((Me.m_PicBox.Height - 24)))
					End If
					flag2 = (Me.currentTopLeftItem > 0)
					If flag2 Then
						gr.DrawString("5", webdingsFont, textBrush, 0F, 0F)
					End If
					webdingsFont.Dispose()
					textBrush.Dispose()
				End If
			End If
		End Sub

		Private Sub DrawOneItem(index As Integer, row As Integer, col As Integer, gr As Graphics)
			Dim textFont As Font = Me.m_PicBox.Font
			Dim textBrush As SolidBrush = New SolidBrush(Me.m_PicBox.ForeColor)
			Dim myStringFormat As StringFormat = New StringFormat()
			myStringFormat.Alignment = StringAlignment.Center
			myStringFormat.FormatFlags = StringFormatFlags.LineLimit
			Dim aThumbNail As CThumbNail = CType(Me.List(index), CThumbNail)
			Dim strKyHieu As String = aThumbNail.Symbols
			Dim mdrawingObjects As CGraphicObjs = CGraphicObjs.Str2Objects(strKyHieu, 0, 0)
			Dim mSiZe As Size = mdrawingObjects.GetSize()
			Dim flag As Boolean = mSiZe.Height > Me.h
			' The following expression was wrapped in a checked-statement
			Dim Height As Integer
			Dim Width As Integer
			If flag Then
				Height = Me.h
				' The following expression was wrapped in a unchecked-expression
				Width = CInt(Math.Round(CDec(Me.h) / CDec(mSiZe.Height) * CDec(mSiZe.Width)))
			Else
				Height = mSiZe.Height
				Width = mSiZe.Width
			End If
			flag = (Width > Me.w)
			If flag Then
				' The following expression was wrapped in a unchecked-expression
				Height = CInt(Math.Round(CDec(Me.w) / CDec(Width) * CDec(Height)))
				Width = Me.w
			End If
			Dim mRect As Rectangle = New Rectangle(2 * Me.x + col * (2 * Me.x + Me.w), 1 * Me.y + row * (2 * Me.y + Me.h), Me.w, Me.h)
			gr.FillRectangle(New SolidBrush(Color.LightGray), mRect)
			Dim imageRect As Rectangle = New Rectangle(2 * Me.x + col * (2 * Me.x + Me.w) + (Me.w - Width) / 2, 1 * Me.y + row * (2 * Me.y + Me.h) + (Me.h - Height) / 2, Width, Height)
			Me.DrawThumbNail(gr, mdrawingObjects, imageRect)
			flag = (index = Me.m_SelectedIndex)
			If flag Then
				Dim myNewPen As Pen = New Pen(Color.Yellow)
				myNewPen.Width = 4F
				gr.DrawRectangle(myNewPen, mRect)
				myNewPen.Dispose()
			End If
			Dim textHeight As Integer = Me.y * 2
			Dim arg_257_1 As String = aThumbNail.Value
			Dim arg_257_2 As Font = textFont
			Dim arg_257_3 As Brush = textBrush
			Dim layoutRectangle As RectangleF = New RectangleF(CSng((Me.x + col * (2 * Me.x + Me.w))), CSng((2 + 1 * Me.y + Me.h + row * (2 * Me.y + Me.h))), CSng((Me.w + 2 * Me.x)), CSng(textHeight))
			gr.DrawString(arg_257_1, arg_257_2, arg_257_3, layoutRectangle, myStringFormat)
		End Sub

		Private Sub DrawThumbNail(g As Graphics, mObjs As CGraphicObjs, imageRect As Rectangle)
			Dim ImageW As Single = CSng(mObjs.GetSize().Width)
			Dim flag As Boolean = ImageW > 0F
			Dim Scale As Single
			If flag Then
				Scale = CSng(imageRect.Width) / ImageW
			Else
				Scale = 1F
			End If
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(CSng(imageRect.X), CSng(imageRect.Y))
			g.ScaleTransform(Scale, Scale)
			Try
				Dim enumerator As IEnumerator = mObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim drawObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					flag = (drawObj.GetObjType() <> OBJECTTYPE.Text)
					If flag Then
						drawObj.Draw(g)
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			g.EndContainer(gCon)
		End Sub

		Public Sub CalculateRowsAndColumns()
			' The following expression was wrapped in a checked-statement
			Dim new_rowsPerPage As Integer = (Me.m_PicBox.Height - Me.y) / (2 * Me.y + Me.h)
			Dim new_colsPerPage As Integer = Me.m_PicBox.Width / (2 * Me.x + Me.w)
			Dim flag As Boolean = new_rowsPerPage <> Me.rowsPerPage OrElse new_colsPerPage <> Me.colsPerPage
			If flag Then
				Me.rowsPerPage = new_rowsPerPage
				Me.colsPerPage = new_colsPerPage
			End If
		End Sub

		Private Function GetItemRect(index As Integer) As Rectangle
			' The following expression was wrapped in a checked-statement
			Dim selectedRow As Integer = CInt(Math.Round(Math.Floor(CDec((index - Me.currentTopLeftItem)) / CDec(Me.colsPerPage))))
			Dim selectedColumn As Integer = (index - Me.currentTopLeftItem) Mod Me.colsPerPage
			Dim itemRect As Rectangle = New Rectangle(Me.x + selectedColumn * (2 * Me.x + Me.w), 1 * Me.y + selectedRow * (2 * Me.y + Me.h), Me.w + 2 * Me.x, Me.h + Me.y * 2)
			Return itemRect
		End Function

		Private Sub m_PicBox_Resize(sender As Object, e As EventArgs)
			Me.CalculateRowsAndColumns()
			Me.m_PicBox.Invalidate()
		End Sub

		Public Sub New(pPicBox As PictureBox)
			CThumbNails.__ENCList.Add(New WeakReference(Me))
			Me.currentTopLeftItem = 0
			Me.m_SelectedIndex = -1
			Me.m_GenericImage = ""
			Me.x = 10
			Me.y = 32
			Me.h = 40
			Me.w = 80
			Me.rowsPerPage = 0
			Me.colsPerPage = 0
			Me.m_PicBox = pPicBox
			Me.w = modBanDo.defaImageWidth
			Me.h = modBanDo.defaImageHeight
			Me.x = modBanDo.defaHorizontalSpacing
			Me.y = modBanDo.defaVerticalSpacing
			Me.CalculateRowsAndColumns()
			Me.SelectedIndex = 0
		End Sub

		Private Function HitTest(loc As Point) As Integer
			Dim found As Boolean = False
			Dim i As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean
			While i < Me.List.Count And Not found
				flag = Me.GetItemRect(i).Contains(loc)
				If flag Then
					found = True
				Else
					i += 1
				End If
			End While
			flag = found
			Dim HitTest As Integer
			If flag Then
				HitTest = i
			Else
				HitTest = -1
			End If
			Return HitTest
		End Function

		Protected Sub RefreshItem(index As Integer)
			Dim itemRect As Rectangle = Me.GetItemRect(index)
			itemRect.Inflate(5, 5)
			Me.m_PicBox.Invalidate(itemRect)
		End Sub

		Private Sub m_PicBox_MouseUp(sender As Object, e As MouseEventArgs)
			Dim mouseLoc As Point = New Point(e.X, e.Y)
			Dim itemHit As Integer = Me.HitTest(mouseLoc)
			Dim flag As Boolean = itemHit <> -1
			If flag Then
				Me.SelectedIndex = itemHit
			Else
				Me.SelectedIndex = -1
			End If
			flag = (e.Button = MouseButtons.Right)
			If flag Then
				Dim flag2 As Boolean = Me.SelectedIndex > -1
				If flag2 Then
					Dim arg_85_0 As ContextMenu = modBanDo.fCacKyHieu.cmnuKyHieu
					Dim arg_85_1 As Control = modBanDo.fCacKyHieu.picThumbNails
					Dim pos As Point = New Point(e.X, e.Y)
					arg_85_0.Show(arg_85_1, pos)
				Else
					Dim arg_B7_0 As ContextMenu = modBanDo.fCacKyHieu.cmnuThumbNail
					Dim arg_B7_1 As Control = modBanDo.fCacKyHieu.picThumbNails
					Dim pos As Point = New Point(e.X, e.Y)
					arg_B7_0.Show(arg_B7_1, pos)
				End If
			Else
				Dim flag2 As Boolean = e.Button = MouseButtons.Left
				If flag2 Then
					flag = (Me.SelectedIndex > -1)
					If flag Then
						myModule.fMain.myBando.ChuanBiNhanKH()
					Else
						myModule.fMain.myBando.NhanKHXong()
					End If
				End If
			End If
			Me.m_PicBox.Invalidate()
		End Sub
	End Class
End Namespace
