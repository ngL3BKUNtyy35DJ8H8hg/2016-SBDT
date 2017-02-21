Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml

Namespace SaBan
	Public Class CMyMnuDef
		Public MnuItems As List(Of CMnuItemDef)

		Public Sub New()
			Me.MnuItems = New List(Of CMnuItemDef)()
		End Sub

		Public Function ToStr() As String
			Dim xmlWriterSettings As XmlWriterSettings = New XmlWriterSettings()
			xmlWriterSettings.Indent = True
			xmlWriterSettings.IndentChars = vbTab
			xmlWriterSettings.OmitXmlDeclaration = True
			Dim result As String
			Using Dim stringWriter As StringWriter = New StringWriter()
				Using Dim xmlWriter As XmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings)
					Dim xmlWriter2 As XmlWriter = xmlWriter
					Me.ToXml(xmlWriter2)
				End Using
				result = stringWriter.ToString()
			End Using
			Return result
		End Function

		Public Sub ToFile(pFileName As String)
			Using Dim xmlWriter As XmlWriter = XmlWriter.Create(pFileName, New XmlWriterSettings() With { .Indent = True, .IndentChars = vbTab, .OmitXmlDeclaration = True })
				Dim xmlWriter2 As XmlWriter = xmlWriter
				Me.ToXml(xmlWriter2)
			End Using
		End Sub

		Private Sub ToXml(ByRef wr As XmlWriter)
			wr.WriteStartElement("Mnu")
			Try
				Dim enumerator As List(Of CMnuItemDef).Enumerator = Me.MnuItems.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CMnuItemDef = enumerator.Current
					wr.WriteWhitespace(vbCrLf)
					current.ToXml(wr)
				End While
			Finally
				Dim enumerator As List(Of CMnuItemDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			wr.WriteWhitespace(vbCrLf)
			wr.WriteEndElement()
		End Sub
	End Class
End Namespace
