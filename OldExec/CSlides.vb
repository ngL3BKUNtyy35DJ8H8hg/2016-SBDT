Imports AxMapXLib
Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml

Namespace BdTC
	Public Class CSlides
		Inherits CollectionBase

		Public ReadOnly Default Property Item(index As Integer) As CSlide
			Get
				Return CType(Me.List(index), CSlide)
			End Get
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		Public Sub Add(aSlide As CSlide)
			Me.List.Add(aSlide)
		End Sub

		Public Sub InsertAt(index As Integer, aSlide As CSlide)
			Dim flag As Boolean = index > Me.Count Or index < 0
			If flag Then
				MessageBox.Show("Index not valid!")
			Else
				flag = (index = Me.Count)
				If flag Then
					Me.List.Add(aSlide)
				Else
					Me.List.Insert(index, aSlide)
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

		Public Sub Remove(aSlide As CSlide)
			Me.List.Remove(aSlide)
		End Sub

		Public Sub Update(aSlide As CSlide, pKH As String, pTyLeLayKH As Single, pDaLayKH As Boolean)
			aSlide.Symbols = pKH
			aSlide.TyLeLayKH = pTyLeLayKH
			aSlide.DaLayKH = pDaLayKH
		End Sub

		Public Function GetItemByID(pId As Integer) As CSlide
			Dim GetItemByID As CSlide
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim aSlide As CSlide = CType(enumerator.Current, CSlide)
					Dim flag As Boolean = aSlide.ID = pId
					If flag Then
						GetItemByID = aSlide
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
			Dim pItem As CSlide = Me.GetItemByID(pItemId)
			Me.Remove(pItem)
			' The following expression was wrapped in a checked-statement
			Dim MoveItem As Integer
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim aSlide As CSlide = CType(enumerator.Current, CSlide)
					i += 1
					Dim flag As Boolean = aSlide.ID = pDestItemID
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
					Dim aSlide As CSlide = CType(enumerator.Current, CSlide)
					Dim flag As Boolean = aSlide.ID > iMax
					If flag Then
						iMax = aSlide.ID
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

		Public Sub Slides2File(pMap As AxMap, pFileName As String)
			Dim sw As StringWriter = New StringWriter()
			Dim wr As XmlTextWriter = New XmlTextWriter(sw)
			Me.Slides2xml(pMap, wr)
			wr.Close()
			Dim strKQ As String = sw.ToString()
			Dim sw2 As StreamWriter = New StreamWriter(pFileName)
			sw2.Write(strKQ)
			sw2.Close()
		End Sub

		Public Function Slides2String(pMap As AxMap) As String
			Dim sw As StringWriter = New StringWriter()
			Dim wr As XmlTextWriter = New XmlTextWriter(sw)
			Me.Slides2xml(pMap, wr)
			wr.Close()
			Return sw.ToString()
		End Function

		Private Sub Slides2xml(pMap As AxMap, ByRef wr As XmlTextWriter)
			wr.WriteStartElement("Slides")
			wr.WriteAttributeString("BDLON", pMap.CenterX.ToString())
			wr.WriteAttributeString("BDLAT", pMap.CenterY.ToString())
			wr.WriteAttributeString("BDZOOM", pMap.Zoom.ToString())
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSlide As CSlide = CType(enumerator.Current, CSlide)
					wr.WriteStartElement("Slide")
					wr.WriteAttributeString("Name", mSlide.Value)
					wr.WriteAttributeString("Checked", mSlide.Checked.ToString())
					wr.WriteAttributeString("TyLe", mSlide.TyLeLayKH.ToString())
					wr.WriteAttributeString("DaLayKH", mSlide.DaLayKH.ToString())
					wr.WriteAttributeString("Symbols", mSlide.Symbols)
					wr.WriteElementString("ID", mSlide.ID.ToString())
					wr.WriteEndElement()
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			wr.WriteEndElement()
		End Sub
	End Class
End Namespace
