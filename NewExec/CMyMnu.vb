Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml

Namespace SaBan
	Public Class CMyMnu
		Public Shared Function LoadMyMnu(pMnuFile As String) As CMyMnuDef
			Dim cMyMnuDef As CMyMnuDef = New CMyMnuDef()
			Dim strMnuItems As String = ""
			Using Dim xmlTextReader As XmlTextReader = New XmlTextReader(pMnuFile)
				While xmlTextReader.Read()
					If xmlTextReader.NodeType = XmlNodeType.Element AndAlso Operators.CompareString(xmlTextReader.Name, "Mnu", False) = 0 Then
						strMnuItems = xmlTextReader.ReadOuterXml()
						Exit While
					End If
				End While
				cMyMnuDef.MnuItems = CMyMnu.LoadMyMnuItems(strMnuItems)
			End Using
			Return cMyMnuDef
		End Function

		Private Shared Function LoadMyMnuItems(strMnuItems As String) As List(Of CMnuItemDef)
			Dim list As List(Of CMnuItemDef) = New List(Of CMnuItemDef)()
			Dim list2 As List(Of String) = New List(Of String)()
			Using Dim stringReader As StringReader = New StringReader(strMnuItems)
				Using Dim xmlTextReader As XmlTextReader = New XmlTextReader(stringReader)
					While xmlTextReader.Read()
						If xmlTextReader.NodeType = XmlNodeType.Comment Then
							Dim value As String = xmlTextReader.Value
							list2.Add(value)
						Else If xmlTextReader.NodeType = XmlNodeType.Element AndAlso Operators.CompareString(xmlTextReader.Name, "MnuItem", False) = 0 Then
							Dim strMnuItem As String = xmlTextReader.ReadOuterXml()
							Dim cMnuItemDef As CMnuItemDef = CMyMnu.LoadMyMnuItem(strMnuItem)
							cMnuItemDef.Comments = list2
							list2 = New List(Of String)()
							list.Add(cMnuItemDef)
						End If
					End While
				End Using
			End Using
			Return list
		End Function

		Private Shared Function LoadMyMnuItem(strMnuItem As String) As CMnuItemDef
			Dim cMnuItemDef As CMnuItemDef = New CMnuItemDef()
			' The following expression was wrapped in a checked-statement
			Using Dim stringReader As StringReader = New StringReader(strMnuItem)
				Using Dim xmlTextReader As XmlTextReader = New XmlTextReader(stringReader)
					While xmlTextReader.Read()
						Dim iD As String = ""
						Dim name As String = ""
						Dim title As String = ""
						Dim posX As Integer = 0
						Dim posY As Integer = 0
						Dim width As Integer = 0
						Dim height As Integer = 0
						If xmlTextReader.NodeType = XmlNodeType.Element AndAlso Operators.CompareString(xmlTextReader.Name, "MnuItem", False) = 0 Then
							If xmlTextReader.AttributeCount > 0 Then
								While xmlTextReader.MoveToNextAttribute()
									Dim name2 As String = xmlTextReader.Name
									If Operators.CompareString(name2, "ID", False) = 0 Then
										iD = xmlTextReader.Value
									Else If Operators.CompareString(name2, "Name", False) = 0 Then
										name = xmlTextReader.Value
									Else If Operators.CompareString(name2, "PosX", False) = 0 Then
										posX = CInt(Math.Round(Conversion.Val(xmlTextReader.Value)))
									Else If Operators.CompareString(name2, "PosY", False) = 0 Then
										posY = CInt(Math.Round(Conversion.Val(xmlTextReader.Value)))
									Else If Operators.CompareString(name2, "Width", False) = 0 Then
										width = CInt(Math.Round(Conversion.Val(xmlTextReader.Value)))
									Else If Operators.CompareString(name2, "Height", False) = 0 Then
										height = CInt(Math.Round(Conversion.Val(xmlTextReader.Value)))
									Else If Operators.CompareString(name2, "Title", False) = 0 Then
										title = xmlTextReader.Value
									End If
								End While
							End If
							Dim cMnuItemDef2 As CMnuItemDef = cMnuItemDef
							cMnuItemDef2.ID = iD
							cMnuItemDef2.Name = name
							cMnuItemDef2.Title = title
							cMnuItemDef2.PosX = posX
							cMnuItemDef2.PosY = posY
							cMnuItemDef2.Width = width
							cMnuItemDef2.Height = height
							cMnuItemDef2.ItemScripts = CMyMnu.LoadItemScripts(strMnuItem)
						End If
					End While
				End Using
			End Using
			Return cMnuItemDef
		End Function

		Private Shared Function LoadItemScripts(strMnuItem As String) As List(Of CItemScriptDef)
			Dim list As List(Of CItemScriptDef) = New List(Of CItemScriptDef)()
			Dim list2 As List(Of String) = New List(Of String)()
			Using Dim stringReader As StringReader = New StringReader(strMnuItem)
				Using Dim xmlTextReader As XmlTextReader = New XmlTextReader(stringReader)
					While xmlTextReader.Read()
						If xmlTextReader.NodeType = XmlNodeType.Comment Then
							Dim value As String = xmlTextReader.Value
							list2.Add(value)
						Else If xmlTextReader.NodeType = XmlNodeType.Element AndAlso Operators.CompareString(xmlTextReader.Name, "Script", False) = 0 Then
							Dim strItemScriptDef As String = xmlTextReader.ReadOuterXml()
							Dim cItemScriptDef As CItemScriptDef = CMyMnu.LoadItemScript(strItemScriptDef)
							cItemScriptDef.Comments = list2
							list2 = New List(Of String)()
							list.Add(cItemScriptDef)
						End If
					End While
				End Using
			End Using
			Return list
		End Function

		Private Shared Function LoadItemScript(strItemScriptDef As String) As CItemScriptDef
			Dim cItemScriptDef As CItemScriptDef = New CItemScriptDef()
			Using Dim stringReader As StringReader = New StringReader(strItemScriptDef)
				Using Dim xmlTextReader As XmlTextReader = New XmlTextReader(stringReader)
					While xmlTextReader.Read()
						Dim iD As String = ""
						Dim scrptFile As String = ""
						Dim mnuItemRef As String = ""
						Dim start As String = "0"
						If xmlTextReader.NodeType = XmlNodeType.Element AndAlso Operators.CompareString(xmlTextReader.Name, "Script", False) = 0 Then
							If xmlTextReader.AttributeCount > 0 Then
								While xmlTextReader.MoveToNextAttribute()
									Dim name As String = xmlTextReader.Name
									If Operators.CompareString(name, "ID", False) = 0 Then
										iD = xmlTextReader.Value
									Else If Operators.CompareString(name, "ScrptFile", False) = 0 Then
										scrptFile = xmlTextReader.Value
									Else If Operators.CompareString(name, "MnuItemRef", False) = 0 Then
										mnuItemRef = xmlTextReader.Value
									Else If Operators.CompareString(name, "Start", False) = 0 Then
										start = xmlTextReader.Value
									End If
								End While
							End If
							Dim cItemScriptDef2 As CItemScriptDef = cItemScriptDef
							cItemScriptDef2.ID = iD
							cItemScriptDef2.ScrptFile = scrptFile
							cItemScriptDef2.MnuItemRef = mnuItemRef
							cItemScriptDef2.Start = start
						End If
					End While
				End Using
			End Using
			Return cItemScriptDef
		End Function
	End Class
End Namespace
