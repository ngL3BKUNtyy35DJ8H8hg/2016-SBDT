Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml

Namespace SaBan
	Public Class CItemScriptDef
		Public Comments As List(Of String)

		Public ID As String

		Public ScrptFile As String

		Public MnuItemRef As String

		Public Start As String

		Public Overrides Function ToString() As String
			Return Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ID=""" + Me.ID + """ Start=""" + Me.Start, Interaction.IIf(Me.ScrptFile.Length > 0, """ ScrptFile=""" + Me.ScrptFile.ToString(), """ MnuItemRef=""" + Me.MnuItemRef.ToString())), """"))
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
			wr.WriteStartElement("Script")
			If Me.ID.Length > 0 Then
				wr.WriteAttributeString("ID", Me.ID)
			End If
			If Me.ScrptFile.Length > 0 Then
				wr.WriteAttributeString("ScrptFile", Me.ScrptFile)
			End If
			If Me.MnuItemRef.Length > 0 Then
				wr.WriteAttributeString("MnuItemRef", Me.MnuItemRef)
			End If
			wr.WriteAttributeString("Start", Me.Start)
			wr.WriteEndElement()
		End Sub

		Public Sub New()
			Me.ID = ""
			Me.ScrptFile = ""
			Me.MnuItemRef = ""
			Me.Start = "0"
			Me.Comments = New List(Of String)()
		End Sub
	End Class
End Namespace
