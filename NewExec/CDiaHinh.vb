Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports DienTapLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Xml
Imports XuLyKHLib

Namespace SaBan
	Public Class CDiaHinh
		Inherits CTerrain

		Private m_AngleZ As Single

		Private m_AngleX As Single

		Private m_TexImage As Bitmap

		Private myPixelsPerGridX As Double

		Private myPixelsPerGridY As Double

		Private heightData As Single(,)

		Private m_Map As AxMap

		Private m_ParentForm As frmMain

		Private m_LastMapCX As Double

		Private m_LastMapCY As Double

		Private m_Symbol3Objs As ArrayList

		Public Sub New(pMap As AxMap, pForm As frmMain, pheightData As Single(,), pDecSepa As Char, pGrpSepa As Char)
			MyBase.New(pForm.Panel3D, pheightData, modSaBan.mySCALE_FACTOR, pDecSepa, pGrpSepa)
			Me.m_AngleZ = 0F
			Me.m_AngleX = 0F
			Me.m_LastMapCX = 0.0
			Me.m_LastMapCY = 0.0
			Me.m_ParentForm = pForm
			Me.m_Map = pMap
			Me.heightData = pheightData
		End Sub

		Public Sub InitDiaHinh(pCamPos As Vector3)
			If File.Exists(modSaBan.myTextureFile) Then
				Me.m_TexImage = New Bitmap(modSaBan.myTextureFile)
			Else
				Me.m_TexImage = New Bitmap(modSaBan.myGRID_WIDTH, modSaBan.myGRID_HEIGHT)
			End If
			modSaBan.my3DSoPixelsPer1000m = Me.GetSoPixelsPer1000m()
			' The following expression was wrapped in a checked-statement
			Me.myPixelsPerGridX = CDec(Me.m_TexImage.Width) / CDec((modSaBan.myGRID_WIDTH - 1))
			Me.myPixelsPerGridY = CDec(Me.m_TexImage.Height) / CDec((modSaBan.myGRID_HEIGHT - 1))
			modSaBan.mySurf2X = CDec(Me.m_TexImage.Width)
			modSaBan.mySurf2Y = CDec(Me.m_TexImage.Height)
			Dim arg_BF_1 As Bitmap = Me.m_TexImage
			Dim pcameraTarget As Vector3 = New Vector3(0F, 0F, 0F)
			MyBase.InitTerrain(arg_BF_1, pCamPos, pcameraTarget, -0.448798954F, modSaBan.myLightDir)
			modSaBan.clrColor = CHelper.GetClrColor(Me.m_TexImage)
			Me.m_Symbol3Objs = New ArrayList()
			MyBase.LoadModelMeshs(modSaBan.myD3DModelMeshFile)
			MyBase.LoadBillboardMeshs(modSaBan.myBillboardMeshFile)
			Me.m_AngleZ = MyBase.GetAngleZ()
			Me.m_AngleX = MyBase.GetAngleX()
		End Sub

		Private Function GetSoPixelsPer1000m0() As Object
			Dim num As Double = Me.m_Map.Distance(modSaBan.myMap1X, modSaBan.myMap1Y, modSaBan.myMap2X, modSaBan.myMap1Y)
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim num2 As Integer = CInt(Math.Round(CDec(Me.m_TexImage.Width) * 1000.0 / num))
			Return num2
		End Function

		Private Function GetSoPixelsPer1000m() As Double
			Dim num As Double = Me.m_Map.Distance(modSaBan.myMap1X, modSaBan.myMap1Y, modSaBan.myMap2X, modSaBan.myMap1Y)
			Return CDec(Me.m_TexImage.Width) * 1000.0 / num
		End Function

		Public Function GetSymbolType(pSymbol As CSymbol) As String
			Dim result As String = "TexObj"
			Dim num As Integer = MyBase.GetModelMeshIndex(pSymbol.Description)
			If num > -1 Then
				result = "Model"
			Else
				num = MyBase.GetBillboardMeshIndex(pSymbol.Description)
				If num > -1 Then
					result = "Billboard"
				End If
			End If
			Return result
		End Function

		Private Sub LoadSymbols()
			MyBase.ClearModels()
			MyBase.ClearBillboards()
			Me.m_Symbol3Objs.Clear()
			Dim num As Double
			Dim num2 As Double
			' The following expression was wrapped in a checked-statement
			num = Convert.ToDouble(Decimal.Multiply(New Decimal(Me.m_TexImage.Width), New Decimal(1000L))) / CDec((modSaBan.myGRID_WIDTH - 1)) / 1000.0
			num2 = Convert.ToDouble(Decimal.Multiply(New Decimal(Me.m_TexImage.Height), New Decimal(1000L))) / CDec((modSaBan.myGRID_HEIGHT - 1)) / 1000.0
			Dim graphics As Graphics = Graphics.FromImage(Me.m_TexImage)
			Try
				Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Dim surfPosition As PointF = modSaBan.GetSurfPosition(cSymbol.GocX, cSymbol.GocY)
					Dim valueX As Single = CSng((CDec(surfPosition.X) / num))
					' The following expression was wrapped in a checked-expression
					Dim valueY As Single = CSng((CDec((modSaBan.myGRID_HEIGHT - 1)) - CDec(surfPosition.Y) / num2))
					Dim dHeading As Single = -CTerrain.DegreeToRadian(cSymbol.Heading)
					Dim pPos As Vector3 = New Vector3(valueX, valueY, -7F)
					Dim num3 As Integer = MyBase.GetModelMeshIndex(cSymbol.Description)
					If num3 > -1 Then
						MyBase.Load1Model(cSymbol.Description, num3, pPos, dHeading)
					Else
						num3 = MyBase.GetBillboardMeshIndex(cSymbol.Description)
						If num3 > -1 Then
							MyBase.Load1Billboard(cSymbol.Description, num3, pPos, dHeading)
						Else
							Dim zoom As Double = cSymbol.Zoom / CDec(cSymbol.MWidth) * (modSaBan.my3DSoPixelsPer1000m / 1000.0)
							Dim cGraphicObjs As CGraphicObjs = New CGraphicObjs()
							Try
								Dim enumerator2 As IEnumerator = cSymbol.GObjs.GetEnumerator()
								While enumerator2.MoveNext()
									Dim graphicObject As GraphicObject = CType(enumerator2.Current, GraphicObject)
									Dim aGObj As GraphicObject = graphicObject.Clone()
									cGraphicObjs.Add(aGObj)
								End While
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									(TryCast(enumerator2, IDisposable)).Dispose()
								End If
							End Try
							Dim cSymbol2 As CSymbol3 = New CSymbol3(cSymbol.Description, surfPosition, cGraphicObjs)
							cSymbol2.Zoom = zoom
							cSymbol2.Heading = cSymbol.Heading
							Me.m_Symbol3Objs.Add(cSymbol2)
						End If
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub Draw3(g As Graphics, pSymbol As CSymbol3)
			Dim graphics As Graphics = Me.m_Map.CreateGraphics()
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(CSng(pSymbol.GocX), CSng(pSymbol.GocY))
			g.RotateTransform(pSymbol.Heading)
			Try
				Dim enumerator As IEnumerator = pSymbol.GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Try
						If graphicObject.GetObjType() = OBJECTTYPE.Text Then
							Dim sizeF As SizeF = g.MeasureString((CType(graphicObject, TextGraphic)).Text, (CType(graphicObject, TextGraphic)).Font)
							Dim num As Single = graphics.MeasureString((CType(graphicObject, TextGraphic)).Text, (CType(graphicObject, TextGraphic)).Font).Width / sizeF.Width
							Dim font As Font = New Font((CType(graphicObject, TextGraphic)).Font.Name, (CType(graphicObject, TextGraphic)).Font.Size * num, (CType(graphicObject, TextGraphic)).Font.Style, (CType(graphicObject, TextGraphic)).Font.Unit)
							(CType(graphicObject, TextGraphic)).Font = font
						End If
					Catch expr_104 As Exception
						ProjectData.SetProjectError(expr_104)
						ProjectData.ClearProjectError()
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			pSymbol.GObjs.DrawObjects(g, CSng(pSymbol.Zoom))
			g.EndContainer(container)
		End Sub

		Private Sub DrawSymbol3(pbmpImage As Image)
			Dim g As Graphics = Graphics.FromImage(pbmpImage)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbol3Objs.GetEnumerator()
				While enumerator.MoveNext()
					Dim pSymbol As CSymbol3 = CType(enumerator.Current, CSymbol3)
					Me.Draw3(g, pSymbol)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub ExportModels(pFileName As String)
			Dim w As StreamWriter = New StreamWriter(pFileName)
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
			Dim num As Integer = 0
			xmlTextWriter.WriteStartElement("Models")
			xmlTextWriter.WriteString(vbCrLf)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CModel).Enumerator = Me.Models.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CModel = enumerator.Current
					num += 1
					Dim name As String = current.Name
					Dim num2 As Integer = MyBase.ModelMeshs.IndexOf(current.ModelMesh)
					xmlTextWriter.WriteStartElement("Model")
					xmlTextWriter.WriteAttributeString("Name", name)
					xmlTextWriter.WriteAttributeString("iMesh", num2.ToString())
					xmlTextWriter.WriteAttributeString("X", current.X.ToString())
					xmlTextWriter.WriteAttributeString("Y", current.Y.ToString())
					xmlTextWriter.WriteAttributeString("Z", current.Z.ToString())
					xmlTextWriter.WriteAttributeString("Heading", current.angleZ.ToString())
					xmlTextWriter.WriteEndElement()
					xmlTextWriter.WriteString(vbCrLf)
				End While
			Finally
				Dim enumerator As List(Of CModel).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			xmlTextWriter.WriteEndElement()
			xmlTextWriter.WriteString(vbCrLf)
			xmlTextWriter.Close()
		End Sub

		Private Sub ExportBillboards(pFileName As String)
			Dim w As StreamWriter = New StreamWriter(pFileName)
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
			Dim num As Integer = 0
			xmlTextWriter.WriteStartElement("Billboards")
			xmlTextWriter.WriteString(vbCrLf)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CBillboard).Enumerator = Me.Billboards.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CBillboard = enumerator.Current
					num += 1
					Dim name As String = current.Name
					Dim num2 As Integer = MyBase.BillboardMeshs.IndexOf(current.BillboardMesh)
					xmlTextWriter.WriteStartElement("Billboard")
					xmlTextWriter.WriteAttributeString("Name", name)
					xmlTextWriter.WriteAttributeString("iMesh", num2.ToString())
					xmlTextWriter.WriteAttributeString("X", current.Position.X.ToString())
					xmlTextWriter.WriteAttributeString("Y", current.Position.Y.ToString())
					xmlTextWriter.WriteAttributeString("Z", current.Z.ToString())
					xmlTextWriter.WriteAttributeString("Heading", current.angleZ.ToString())
					xmlTextWriter.WriteEndElement()
					xmlTextWriter.WriteString(vbCrLf)
				End While
			Finally
				Dim enumerator As List(Of CBillboard).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			xmlTextWriter.WriteEndElement()
			xmlTextWriter.WriteString(vbCrLf)
			xmlTextWriter.Close()
		End Sub

		Private Function IsActiveSymbol(pName As String, pActions As List(Of CActDef)) As Boolean
			Dim result As Boolean = False
			If pName.Length > 0 Then
				Try
					Dim enumerator As List(Of CActDef).Enumerator = pActions.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As CActDef = enumerator.Current
						If Operators.CompareString(current.ObjName, pName, False) = 0 Then
							result = True
							Exit While
						End If
					End While
				Finally
					Dim enumerator As List(Of CActDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
			End If
			Return result
		End Function

		Private Sub ExportTexObjs(pFileName As String, pActions As List(Of CActDef))
			Dim num As Integer = 0
			Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			Dim bitmap As Bitmap = New Bitmap(modSaBan.myTextureFile)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			graphics.SmoothingMode = SmoothingMode.AntiAlias
			' The following expression was wrapped in a checked-statement
			Using Dim streamWriter As StreamWriter = New StreamWriter(pFileName)
				streamWriter.WriteLine("<TexObjs>")
				Try
					Dim enumerator As IEnumerator = Me.m_Symbol3Objs.GetEnumerator()
					While enumerator.MoveNext()
						Dim cSymbol As CSymbol3 = CType(enumerator.Current, CSymbol3)
						If Me.IsActiveSymbol(cSymbol.Name, pActions) Then
							num += 1
							Dim mImageFile As String = modSaBan.mySaBanDir + "\TexObj" + num.ToString("000") + ".xml"
							streamWriter.WriteLine(Me.GetTexObjStr(cSymbol, mImageFile))
						Else
							Me.Draw3(graphics, cSymbol)
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				streamWriter.WriteLine("</TexObjs>")
				streamWriter.Close()
			End Using
			bitmap.Save(modSaBan.mySaBanDir + "\DienTapMap.jpg")
			bitmap.Dispose()
		End Sub

		Private Function GetTexObjStr(aSymbol As CSymbol3, mImageFile As String) As String
			Dim str As String = "<TexObj"
			Dim bounds As RectangleF = aSymbol.GetBounds()
			Dim name As String
			Dim value As Integer
			Dim value2 As Integer
			Dim value3 As Integer
			Dim value4 As Integer
			Dim rectangle As Rectangle
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(Math.Floor(CDec(bounds.X) / Me.myPixelsPerGridX) - 1.0))
			Dim num2 As Integer = CInt(Math.Round(Math.Floor(CDec(bounds.Y) / Me.myPixelsPerGridY) - 1.0))
			Dim num3 As Integer = CInt(Math.Round(Math.Ceiling(CDec((bounds.X + bounds.Width)) / Me.myPixelsPerGridX) + 1.0))
			Dim num4 As Integer = CInt(Math.Round(Math.Ceiling(CDec((bounds.Y + bounds.Height)) / Me.myPixelsPerGridY) + 1.0))
			name = aSymbol.Name
			value = num3 - num
			value2 = num4 - num2
			value3 = num
			value4 = modSaBan.myGRID_HEIGHT - 1 - num4
			rectangle = New Rectangle(CInt(Math.Round(CDec(num) * Me.myPixelsPerGridX)), CInt(Math.Round(CDec(num2) * Me.myPixelsPerGridY)), CInt(Math.Round(CDec((num3 - num)) * Me.myPixelsPerGridX)), CInt(Math.Round(CDec((num4 - num2)) * Me.myPixelsPerGridY)))
			aSymbol.GocX -= CDec(rectangle.X)
			aSymbol.GocY -= CDec(rectangle.Y)
			aSymbol.KH2File(mImageFile)
			str = str + " Name=""" + name + """"
			str = str + " ImageFile=""" + mImageFile + """"
			str = str + " Width=""" + Conversions.ToString(value) + """"
			str = str + " Height=""" + Conversions.ToString(value2) + """"
			str = str + " ShiftX=""" + Conversions.ToString(value3) + """"
			str = str + " ShiftY=""" + Conversions.ToString(value4) + """"
			str = str + " ImageWidth=""" + Conversions.ToString(rectangle.Width) + """"
			str = str + " ImageHeight=""" + Conversions.ToString(rectangle.Height) + """"
			Return str + " />"
		End Function

		Public Sub ExportCacDT(pActions As List(Of CActDef))
			Me.LoadSymbols()
			Me.ExportModels(modSaBan.mySaBanDir + "\D3DModels.xml")
			Me.ExportBillboards(modSaBan.mySaBanDir + "\D3DBillboards.xml")
			Me.ExportTexObjs(modSaBan.mySaBanDir + "\D3DTexObjs.xml", pActions)
		End Sub

		Public Sub ChangeDHFocus(pLon As Double, pLat As Double)
			If(Me.m_Map.CenterX <> Me.m_LastMapCX Or Me.m_Map.CenterY <> Me.m_LastMapCY) AndAlso (pLon > modSaBan.myMap2X And pLon < modSaBan.myMap1X And (pLat > modSaBan.myMap2Y And pLat < modSaBan.myMap1Y)) Then
				Dim surfPosition As PointF = modSaBan.GetSurfPosition(pLon, pLat)
				MyBase.ChangeFocus(surfPosition.X / CSng(Me.m_TexImage.Width), (CSng(Me.m_TexImage.Height) - surfPosition.Y) / CSng(Me.m_TexImage.Height))
				Me.m_LastMapCX = pLon
				Me.m_LastMapCY = pLat
			End If
		End Sub

		Public Sub Hien3DSymbols()
			Me.LoadSymbols()
			Me.m_TexImage = New Bitmap(modSaBan.myTextureFile)
			Me.DrawSymbol3(Me.m_TexImage)
			MyBase.LoadMemStream(Me.m_TexImage)
		End Sub

		Public Sub Xoa3DSymbols()
			MyBase.ClearModels()
			Me.m_TexImage = New Bitmap(modSaBan.myTextureFile)
			MyBase.LoadMemStream(Me.m_TexImage)
		End Sub

		Public Sub ShowSaBan()
			If MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir) Then
				Dim text As String = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
				If MyProject.Computer.FileSystem.FileExists(text) Then
					Dim dlg3DShow As Dlg3DShow = New Dlg3DShow()
					Dim bitmap As Bitmap = New Bitmap(modSaBan.mySaBanDir + "\DienTapMap.jpg")
					Dim cameraPos As Vector3 = Me.cameraPos
					Dim cameraTarget As Vector3 = Me.cameraTarget
					Dim angleZ As Single = MyBase.GetAngleZ()
					Dim angleX As Single = MyBase.GetAngleX()
					dlg3DShow.ShowDialog(bitmap, Me.heightData, cameraPos, cameraTarget, text, modSaBan.myLightDir, angleZ, angleX)
					bitmap.Dispose()
					dlg3DShow.Dispose()
				Else
					Interaction.MsgBox("Không th" & ChrW(7845) & "y file: " + text, MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Không th" & ChrW(7845) & "y th" & ChrW(432) & " m" & ChrW(7909) & "c: " + modSaBan.mySaBanDir, MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Public Sub ScriptsEdit()
			If MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir) Then
				Dim text As String = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
				If MyProject.Computer.FileSystem.FileExists(text) Then
					New dlgActions() With { .TopMost = True }.Show(text, myModule.fMain)
				Else
					Interaction.MsgBox("Không th" & ChrW(7845) & "y file: " + text, MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Không th" & ChrW(7845) & "y th" & ChrW(432) & " m" & ChrW(7909) & "c: " + modSaBan.mySaBanDir, MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub
	End Class
End Namespace
