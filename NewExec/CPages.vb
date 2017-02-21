Imports AxMapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml

Namespace SaBan
	Public Class CPages
		Inherits CollectionBase

		Public ReadOnly Default Property Item(index As Integer) As CPage
			Get
				Return CType(Me.List(index), CPage)
			End Get
		End Property

		Private Sub Add(aPage As CPage)
			Me.List.Add(aPage)
		End Sub

		Public Function AddNewPage(strSymbols As String) As CPage
			' The following expression was wrapped in a checked-expression
			Dim intID As Integer = Me.GetMaxID() + 1
			Dim cPage As CPage = New CPage("Trang " + intID.ToString(), intID, strSymbols, True)
			Me.Add(cPage)
			Return cPage
		End Function

		Public Sub InsertAt(index As Integer, aPage As CPage)
			If index > Me.Count Or index < 0 Then
				MessageBox.Show("Index not valid!")
			Else If index = Me.Count Then
				Me.List.Add(aPage)
			Else
				Me.List.Insert(index, aPage)
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

		Public Sub Remove(aPage As CPage)
			Me.List.Remove(aPage)
		End Sub

		Public Function GetItemByID(pId As Integer) As CPage
			Dim result As CPage
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cPage As CPage = CType(enumerator.Current, CPage)
					If cPage.ID = pId Then
						result = cPage
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
			Dim itemByID As CPage = Me.GetItemByID(pItemId)
			Me.Remove(itemByID)
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cPage As CPage = CType(enumerator.Current, CPage)
					num += 1
					If cPage.ID = pDestItemID Then
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

		Private Function GetMaxID() As Integer
			Dim num As Integer = 0
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cPage As CPage = CType(enumerator.Current, CPage)
					If cPage.ID > num Then
						num = cPage.ID
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

		Public Sub Pages2File(pMap As AxMap, pFileName As String)
			Dim stringWriter As StringWriter = New StringWriter()
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(stringWriter)
			Me.Pages2xml(pMap, xmlTextWriter)
			xmlTextWriter.Close()
			Dim value As String = stringWriter.ToString()
			Dim streamWriter As StreamWriter = New StreamWriter(pFileName)
			streamWriter.Write(value)
			streamWriter.Close()
		End Sub

		Public Function Pages2String(pMap As AxMap) As String
			Dim stringWriter As StringWriter = New StringWriter()
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(stringWriter)
			Me.Pages2xml(pMap, xmlTextWriter)
			xmlTextWriter.Close()
			Return stringWriter.ToString()
		End Function

		Private Sub Pages2xml(pMap As AxMap, ByRef wr As XmlTextWriter)
			wr.WriteStartElement("Pages")
			wr.WriteAttributeString("SCALE", modBanDo.BDTyLeBanDo.ToString())
			wr.WriteAttributeString("LON", modBanDo.BDKinhDo.ToString())
			wr.WriteAttributeString("LAT", modBanDo.BDViDo.ToString())
			wr.WriteAttributeString("TYLE", modBdTC.BDTyLeLayKH.ToString())
			Try
				Dim enumerator As IEnumerator = Me.List.GetEnumerator()
				While enumerator.MoveNext()
					Dim cPage As CPage = CType(enumerator.Current, CPage)
					wr.WriteStartElement("Page")
					wr.WriteAttributeString("Name", cPage.Value)
					wr.WriteAttributeString("Checked", cPage.Checked.ToString())
					wr.WriteAttributeString("Symbols", cPage.Symbols)
					wr.WriteElementString("ID", cPage.ID.ToString())
					wr.WriteEndElement()
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			wr.WriteEndElement()
		End Sub

		Private Sub XML2Pages(pStr As String)
			Dim nameTable As NameTable = New NameTable()
			Dim xmlNamespaceManager As XmlNamespaceManager = New XmlNamespaceManager(nameTable)
			xmlNamespaceManager.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, xmlNamespaceManager, Nothing, XmlSpace.None)
			Dim xmlTextReader As XmlTextReader = New XmlTextReader(pStr, XmlNodeType.Element, context)
			Dim value As String = ""
			Dim symbols As String = ""
			Dim checked As Boolean = False
			Dim bDTyLeBanDo As Integer = 0
			Dim bDKinhDo As Double = modBanDo.BDKinhDo
			Dim bDViDo As Double = modBanDo.BDViDo
			Dim bDTyLeLayKH As Integer = modBdTC.BDTyLeLayKH
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Try
				Me.List.Clear()
				While xmlTextReader.Read()
					Dim nodeType As XmlNodeType = xmlTextReader.NodeType
					Dim xmlNodeType As XmlNodeType = nodeType
					If xmlNodeType = XmlNodeType.Element Then
						Dim name As String = xmlTextReader.Name
						If Operators.CompareString(name, "Pages", False) = 0 OrElse Operators.CompareString(name, "Slides", False) = 0 Then
							If xmlTextReader.AttributeCount > 0 Then
								While xmlTextReader.MoveToNextAttribute()
									Dim name2 As String = xmlTextReader.Name
									If Operators.CompareString(name2, "SCALE", False) = 0 Then
										bDTyLeBanDo = Conversions.ToInteger(xmlTextReader.Value)
									Else If Operators.CompareString(name2, "LON", False) = 0 Then
										bDKinhDo = modBdTC.GetDouble(xmlTextReader.Value)
									Else If Operators.CompareString(name2, "LAT", False) = 0 Then
										bDViDo = modBdTC.GetDouble(xmlTextReader.Value)
									Else If Operators.CompareString(name2, "TYLE", False) = 0 Then
										bDTyLeLayKH = Conversions.ToInteger(xmlTextReader.Value)
									End If
								End While
							End If
						Else If Operators.CompareString(name, "Page", False) = 0 OrElse Operators.CompareString(name, "Slide", False) = 0 Then
							value = ""
							symbols = ""
							checked = False
							If xmlTextReader.AttributeCount > 0 Then
								While xmlTextReader.MoveToNextAttribute()
									Dim name3 As String = xmlTextReader.Name
									If Operators.CompareString(name3, "Name", False) = 0 Then
										value = xmlTextReader.Value
									Else If Operators.CompareString(name3, "Symbols", False) = 0 Then
										symbols = xmlTextReader.Value
									Else If Operators.CompareString(name3, "Checked", False) = 0 Then
										checked = (Operators.CompareString(xmlTextReader.Value, "True", False) = 0)
									End If
								End While
							End If
						End If
					Else If xmlNodeType = XmlNodeType.EndElement Then
						Dim name4 As String = xmlTextReader.Name
						If Operators.CompareString(name4, "Page", False) = 0 OrElse Operators.CompareString(name4, "Slide", False) = 0 Then
							num += 1
							Dim cPage As CPage = New CPage()
							Dim cPage2 As CPage = cPage
							cPage2.ID = num
							cPage2.Value = value
							cPage2.Symbols = symbols
							cPage2.Checked = checked
							Me.List.Add(cPage)
						End If
					End If
				End While
				modBanDo.BDTyLeBanDo = bDTyLeBanDo
				modBanDo.BDKinhDo = bDKinhDo
				modBanDo.BDViDo = bDViDo
				modBdTC.BDTyLeLayKH = bDTyLeLayKH
			Catch expr_2A9 As Exception
				ProjectData.SetProjectError(expr_2A9)
				Dim ex As Exception = expr_2A9
				Interaction.MsgBox("Khong doc duoc XML: " + ex.Message, MsgBoxStyle.OkOnly, Nothing)
				Throw ex
			End Try
		End Sub

		Public Function LoadFromStr(strKQ As String) As Boolean
			Dim result As Boolean = False
			Try
				Me.XML2Pages(strKQ)
				result = True
			Catch expr_0D As Exception
				ProjectData.SetProjectError(expr_0D)
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function
	End Class
End Namespace
