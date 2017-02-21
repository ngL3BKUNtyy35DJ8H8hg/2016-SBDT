Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Xml

Namespace SaBan
	Public Class CMnuItemDef
		Public Comments As List(Of String)

		Public ID As String

		Public Name As String

		Public Title As String

		Public PosX As Integer

		Public PosY As Integer

		Public Width As Integer

		Public Height As Integer

		Public ItemScripts As List(Of CItemScriptDef)

		Public Overrides Function ToString() As String
			Return String.Concat(New String() { "ID=""", Me.ID, """ Name=""", Me.Name.ToString(), """" })
		End Function

		Public Function HitTest(pt As Point) As Boolean
			Dim result As Boolean = False
			If Me.PosX <> 0 Or Me.PosY <> 0 Then
				Dim rectangle As Rectangle = New Rectangle(Me.PosX, Me.PosY, Me.Width, Me.Height)
				result = rectangle.Contains(pt)
			End If
			Return result
		End Function

		Public Function IsInRect(pRect As Rectangle) As Boolean
			Dim result As Boolean = False
			If Me.PosX <> 0 Or Me.PosY <> 0 Then
				Dim rect As Rectangle = New Rectangle(Me.PosX, Me.PosY, Me.Width, Me.Height)
				result = pRect.Contains(rect)
			End If
			Return result
		End Function

		Public Function NotInRect(pRect As Rectangle) As Boolean
			Dim result As Boolean = False
			If Me.PosX <> 0 Or Me.PosY <> 0 Then
				Dim rect As Rectangle = New Rectangle(Me.PosX, Me.PosY, Me.Width, Me.Height)
				result = Not pRect.Contains(rect)
			End If
			Return result
		End Function

		Public Function ToStr() As String
			Dim xmlWriterSettings As XmlWriterSettings = New XmlWriterSettings()
			xmlWriterSettings.Indent = True
			xmlWriterSettings.IndentChars = vbTab
			xmlWriterSettings.OmitXmlDeclaration = True
			Dim result As String
			Using Dim stringWriter As StringWriter = New StringWriter()
				Using Dim xmlWriter As XmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings)
					Me.ToXml(xmlWriter)
				End Using
				result = stringWriter.ToString()
			End Using
			Return result
		End Function

		Public Sub ToXml(wr As XmlWriter)
			If Me.Comments.Count > 0 Then
				Try
					Dim enumerator As List(Of String).Enumerator = Me.Comments.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As String = enumerator.Current
						wr.WriteComment(current)
						wr.WriteWhitespace(vbCrLf)
					End While
				Finally
					Dim enumerator As List(Of String).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
			End If
			wr.WriteStartElement("MnuItem")
			If Me.ID.Length > 0 Then
				wr.WriteAttributeString("ID", Me.ID)
			End If
			wr.WriteAttributeString("Name", Me.Name)
			wr.WriteAttributeString("PosX", Me.PosX.ToString())
			wr.WriteAttributeString("PosY", Me.PosY.ToString())
			wr.WriteAttributeString("Width", Me.Width.ToString())
			wr.WriteAttributeString("Height", Me.Height.ToString())
			wr.WriteAttributeString("Title", Me.Title)
			Try
				Dim enumerator2 As List(Of CItemScriptDef).Enumerator = Me.ItemScripts.GetEnumerator()
				While enumerator2.MoveNext()
					Dim current2 As CItemScriptDef = enumerator2.Current
					wr.WriteWhitespace(vbCrLf)
					current2.ToXml(wr)
				End While
			Finally
				Dim enumerator2 As List(Of CItemScriptDef).Enumerator
				(CType(enumerator2, IDisposable)).Dispose()
			End Try
			wr.WriteWhitespace(vbCrLf)
			wr.WriteEndElement()
		End Sub

		Public Sub New()
			Me.ID = ""
			Me.Name = ""
			Me.Title = ""
			Me.PosX = 0
			Me.PosY = 0
			Me.Width = 0
			Me.Height = 0
			Me.Comments = New List(Of String)()
			Me.ItemScripts = New List(Of CItemScriptDef)()
		End Sub
	End Class
End Namespace
