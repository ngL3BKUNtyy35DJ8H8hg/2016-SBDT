Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports DienTapLib
Imports MapXLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Xml

Namespace SaBan
	Public Class CVeActs
		Public Enum MapTools
			None
			GetTarget
			GetObjName
			GetObjName2
			GetFocus
		End Enum

		Private SymbolZoom As Double

		Private SymbolMapScreenWidth As Single

		Public myMapTool As CVeActs.MapTools

		Private myActSymbol As CSymbol

		Private mySeleActName As String

		Private myActSymbols As CSymbols

		Public dlx As Double

		Public dly As Double

		Private myActDTs As CSymbols

		Private myPts As PointF()

		Private myfromPt As PointF

		Private mytoPt As PointF

		Private myrootPt As PointF

		Private DrawingPicking As Boolean

		Private myDoCao As Single

		Private txtKQ As TextBox

		Private txtObjType As TextBox

		Private txtKQ2 As TextBox

		Private m_Map As AxMap

		Private m_ParentForm As frmMain

		Private Sub CalcSymbolZoom()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(modBanDo.GetZoomLevel(Me.m_Map, modBanDo.BDTyLeBanDo)))
			Me.SymbolZoom = CDec((num * modBdTC.BDTyLeLayKH)) / 100.0
			Me.SymbolMapScreenWidth = Me.m_Map.MapScreenWidth
		End Sub

		Public Sub New(pMap As AxMap, pForm As Form)
			Me.mySeleActName = ""
			Me.myActSymbols = New CSymbols()
			Me.myActDTs = New CSymbols()
			Me.DrawingPicking = False
			Me.myDoCao = 0F
			Me.m_ParentForm = CType(pForm, frmMain)
			Me.m_Map = pMap
			Me.myMapTool = CVeActs.MapTools.None
		End Sub

		Public Sub OnGetTarget(ptxtKQ As TextBox, pDoCao As Single)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CVeActs.MapTools.GetTarget
			myModule.fMain.myBando.SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.myDoCao = pDoCao
			Me.txtKQ = ptxtKQ
			Me.myPts = New PointF(-1) {}
			Me.DrawingPicking = False
			myModule.fMain.ToolStripStatusLabel3.Text = "Lay V" & ChrW(7883) & " trí: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các V" & ChrW(7883) & " trí, RightClick " & ChrW(273) & ChrW(7875) & " xem K" & ChrW(7871) & "t qu" & ChrW(7843) & "."
		End Sub

		Public Sub OnGetFocus(ptxtKQ As TextBox, ptxtKQ2 As TextBox)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CVeActs.MapTools.GetFocus
			myModule.fMain.myBando.SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.txtKQ = ptxtKQ
			Me.txtKQ2 = ptxtKQ2
			myModule.fMain.ToolStripStatusLabel3.Text = "L" & ChrW(7845) & "y Tiêu " & ChrW(273) & "i" & ChrW(7875) & "m: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n Tiêu " & ChrW(273) & "i" & ChrW(7875) & "m."
		End Sub

		Private Sub GetTargets()
			' The following expression was wrapped in a checked-expression
			Dim num As Double = modSaBan.mySurf2X * 1000.0 / CDec((modSaBan.myGRID_WIDTH - 1)) / 1000.0
			' The following expression was wrapped in a checked-expression
			Dim num2 As Double = modSaBan.mySurf2Y * 1000.0 / CDec((modSaBan.myGRID_HEIGHT - 1)) / 1000.0
			' The following expression was wrapped in a checked-statement
			If Me.myPts.GetUpperBound(0) <= 1 Then
				Dim arg_69_0 As Integer = 0
				Dim upperBound As Integer = Me.myPts.GetUpperBound(0)
				For i As Integer = arg_69_0 To upperBound
					Dim arg_B4_0 As AxMap = Me.m_Map
					Dim array As PointF() = Me.myPts
					Dim arg_84_0 As PointF() = array
					Dim num3 As Integer = i
					Dim num4 As Single = arg_84_0(num3).X
					Dim array2 As PointF() = Me.myPts
					Dim arg_A1_0 As PointF() = array2
					Dim num5 As Integer = i
					Dim num6 As Single = arg_A1_0(num5).Y
					Dim pMapX As Double
					Dim pMapY As Double
					arg_B4_0.ConvertCoord(num4, num6, pMapX, pMapY, ConversionConstants.miScreenToMap)
					array2(num5).Y = num6
					array(num3).X = num4
					Dim surfPosition As PointF = modSaBan.GetSurfPosition(pMapX, pMapY)
					Dim num7 As Single = CSng((CDec(surfPosition.X) / num))
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim num8 As Single = CSng((CDec((modSaBan.myGRID_HEIGHT - 1)) - CDec(surfPosition.Y) / num2))
					Dim textBox As TextBox = Me.txtKQ
					textBox.Text = String.Concat(New String() { textBox.Text, "<Target X=""", num7.ToString(), """ Y=""", num8.ToString(), """ Z=""", Me.myDoCao.ToString(), """>", (i + 1).ToString(), "</Target>" & vbCrLf })
				Next
			Else
				Dim graphicsPath As GraphicsPath = New GraphicsPath()
				graphicsPath.AddCurve(Me.myPts)
				graphicsPath.Flatten(New System.Drawing.Drawing2D.Matrix(), 0.25F)
				Dim pathPoints As PointF() = graphicsPath.PathPoints
				Dim arg_1DD_0 As Integer = 0
				Dim upperBound2 As Integer = pathPoints.GetUpperBound(0)
				For i As Integer = arg_1DD_0 To upperBound2
					Dim arg_220_0 As AxMap = Me.m_Map
					Dim array2 As PointF() = pathPoints
					Dim arg_1F4_0 As PointF() = array2
					Dim num5 As Integer = i
					Dim num6 As Single = arg_1F4_0(num5).X
					Dim array As PointF() = pathPoints
					Dim arg_20D_0 As PointF() = array
					Dim num3 As Integer = i
					Dim num4 As Single = arg_20D_0(num3).Y
					Dim pMapX As Double
					Dim pMapY As Double
					arg_220_0.ConvertCoord(num6, num4, pMapX, pMapY, ConversionConstants.miScreenToMap)
					array(num3).Y = num4
					array2(num5).X = num6
					Dim surfPosition As PointF = modSaBan.GetSurfPosition(pMapX, pMapY)
					Dim num7 As Single = CSng((CDec(surfPosition.X) / num))
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim num8 As Single = CSng((CDec((modSaBan.myGRID_HEIGHT - 1)) - CDec(surfPosition.Y) / num2))
					Dim textBox As TextBox = Me.txtKQ
					textBox.Text = String.Concat(New String() { textBox.Text, "<Target X=""", num7.ToString(), """ Y=""", num8.ToString(), """ Z=""", Me.myDoCao.ToString(), """>", (i + 1).ToString(), "</Target>" & vbCrLf })
				Next
			End If
		End Sub

		Private Function GetMapPoint(target As Vector3) As MAPPOINT
			Dim result As MAPPOINT = Nothing
			result.X = modSaBan.myMap1X + CDec(target.X) * Me.dlx
			If Operators.CompareString(modSaBan.myGridDataType, "xyz", False) = 0 Then
				result.X = modSaBan.myMap2X - CDec(target.X) * Me.dlx
			End If
			result.Y = modSaBan.myMap2Y + CDec(target.Y) * Me.dly
			Return result
		End Function

		Private Function GetPts(targets As List(Of Vector3)) As List(Of MAPPOINT)
			Dim list As List(Of MAPPOINT) = New List(Of MAPPOINT)()
			Try
				Dim enumerator As List(Of Vector3).Enumerator = targets.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As Vector3 = enumerator.Current
					Dim mapPoint As MAPPOINT = Me.GetMapPoint(current)
					list.Add(mapPoint)
				End While
			Finally
                'Dim enumerator As List(Of Vector3).Enumerator
                '(CType(enumerator, IDisposable)).Dispose()
			End Try
			Return list
		End Function

		Private Function GetSymbolByName(Name As String) As CSymbol
			Dim result As CSymbol = Nothing
			Try
				Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					If Operators.CompareString(cSymbol.Description, Name, False) = 0 Then
						result = cSymbol
						Exit While
					End If
				End While
			Finally
                'Dim enumerator As IEnumerator
                'If TypeOf enumerator Is IDisposable Then
                '	(TryCast(enumerator, IDisposable)).Dispose()
                'End If
			End Try
			Return result
		End Function

		Private Sub DrawActDef(g As Graphics)
			Dim cSymbol As CSymbol = Nothing
			Try
				Dim enumerator As IEnumerator = Me.myActSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol2 As CSymbol = CType(enumerator.Current, CSymbol)
					If Not Information.IsNothing(cSymbol2) Then
						If Operators.CompareString(cSymbol2.Description, Me.mySeleActName, False) = 0 Then
							cSymbol = cSymbol2
						Else
							cSymbol2.Draw(Me.m_Map, g)
						End If
					End If
				End While
			Finally
                'Dim enumerator As IEnumerator
                'If TypeOf enumerator Is IDisposable Then
                '	(TryCast(enumerator, IDisposable)).Dispose()
                'End If
			End Try
			If Not Information.IsNothing(cSymbol) Then
				cSymbol.DanhDau(Me.m_Map, g, Color.Aqua)
			End If
		End Sub

		Private Sub LoadActDefs(pActDefs As List(Of CActDef))
			Me.myActSymbols.Clear()
			Dim cSymbol As CSymbol = Nothing
			Try
				Dim enumerator As List(Of CActDef).Enumerator = pActDefs.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CActDef = enumerator.Current
					Dim actionType As String = current.ActionType
					If Operators.CompareString(actionType, "Move", False) = 0 OrElse Operators.CompareString(actionType, "Fly", False) = 0 Then
						cSymbol = Me.GetMoveActSymbol(current)
					Else If Operators.CompareString(actionType, "Shoot", False) = 0 OrElse Operators.CompareString(actionType, "Bombard", False) = 0 Then
						cSymbol = Me.GetShootActSymbol(current)
					Else If Operators.CompareString(actionType, "SpinTo", False) = 0 Then
						cSymbol = Me.GetSpinActSymbol(current)
					Else
						If Operators.CompareString(actionType, "Explode", False) <> 0 Then
							If Operators.CompareString(actionType, "Appear", False) <> 0 AndAlso Operators.CompareString(actionType, "AppearLeft", False) <> 0 Then
								If Operators.CompareString(actionType, "AppearUp", False) <> 0 Then
									If Operators.CompareString(actionType, "AppearDown", False) <> 0 Then
										If Operators.CompareString(actionType, "AppearA", False) <> 0 Then
											If Operators.CompareString(actionType, "Disappear", False) <> 0 Then
												If Operators.CompareString(actionType, "DisappearLeft", False) <> 0 Then
													If Operators.CompareString(actionType, "DisappearUp", False) <> 0 Then
														If Operators.CompareString(actionType, "DisappearDown", False) <> 0 Then
															If Operators.CompareString(actionType, "DisappearA", False) <> 0 Then
																If Operators.CompareString(actionType, "Hide", False) <> 0 Then
																	If Operators.CompareString(actionType, "Unhide", False) <> 0 Then
																		If Operators.CompareString(actionType, "Blink", False) <> 0 Then
																			GoTo IL_197
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
							IL_18F:
							cSymbol = Me.GetAppearActSymbol(current)
							GoTo IL_197
							IL_17E:
							GoTo IL_18F
							IL_16D:
							GoTo IL_17E
							IL_15C:
							GoTo IL_16D
							IL_14B:
							GoTo IL_15C
							IL_13A:
							GoTo IL_14B
							IL_129:
							GoTo IL_13A
							IL_118:
							GoTo IL_129
							IL_107:
							GoTo IL_118
							IL_F6:
							GoTo IL_107
							GoTo IL_F6
						End If
						cSymbol = Me.GetExplodeActSymbol(current)
					End If
					IL_197:
					If Not Information.IsNothing(cSymbol) Then
						Me.myActSymbols.Add(cSymbol)
					End If
				End While
			Finally
                'Dim enumerator As List(Of CActDef).Enumerator
                '(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.mySeleActName = "***"
		End Sub

		Public Sub OnActDefEdit(pActDefs As List(Of CActDef))
			Me.LoadActDefs(pActDefs)
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Public Sub OnSeleActDef(pActDef As CActDef)
			Me.mySeleActName = modSaBan.fActions.lstActions.SelectedIndex.ToString()
			Me.myActSymbol = Nothing
			Try
				Dim enumerator As IEnumerator = Me.myActSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					If Operators.CompareString(cSymbol.Description, Me.mySeleActName, False) = 0 Then
						Me.myActSymbol = cSymbol
						Exit While
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			If Not Information.IsNothing(Me.myActSymbol) Then
				Dim symbolByName As CSymbol = Me.GetSymbolByName(pActDef.ObjName)
				If Not Information.IsNothing(symbolByName) Then
					symbolByName.DanhDau(Me.m_Map, Me.m_Map.CreateGraphics(), Color.Aqua)
				End If
				If Not Me.m_Map.IsPointVisible(Me.myActSymbol.GocX, Me.myActSymbol.GocY) Then
					Me.m_Map.CenterX = Me.myActSymbol.GocX
					Me.m_Map.CenterY = Me.myActSymbol.GocY
				Else
					Me.m_Map.CenterX = Me.m_Map.CenterX
				End If
				If Operators.CompareString(pActDef.ActionType, "Move", False) = 0 Or Operators.CompareString(pActDef.ActionType, "Fly", False) = 0 Then
					Dim bounds As RectangleF = Me.myActSymbol.GetBounds(Me.m_Map)
					Dim arg_1A6_0 As AxMap = Me.m_Map
					Dim num As Single = (bounds.Left + bounds.Right) / 2F
					Dim num2 As Single = (bounds.Top + bounds.Bottom) / 2F
					Dim x As Double
					Dim y As Double
					arg_1A6_0.ConvertCoord(num, num2, x, y, ConversionConstants.miScreenToMap)
					Dim arg_1CC_0 As AxMap = Me.m_Map
					num2 = bounds.Left
					num = bounds.Top
					Dim num3 As Double
					Dim num4 As Double
					arg_1CC_0.ConvertCoord(num2, num, num3, num4, ConversionConstants.miScreenToMap)
					Dim arg_1F2_0 As AxMap = Me.m_Map
					num2 = bounds.Right
					num = bounds.Bottom
					Dim num5 As Double
					Dim num6 As Double
					arg_1F2_0.ConvertCoord(num2, num, num5, num6, ConversionConstants.miScreenToMap)
					If Me.m_Map.IsPointVisible(num3, num4) And Me.m_Map.IsPointVisible(num5, num6) Then
						Me.m_Map.CenterX = Me.m_Map.CenterX
					Else
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a unchecked-expression
						Dim num7 As Integer = CInt(Math.Round(Me.m_Map.Distance(num3, num4, num5, num6) * 1.5))
						Me.m_Map.ZoomTo(CDec(num7), x, y)
					End If
				End If
			Else
				Me.m_Map.CenterX = Me.m_Map.CenterX
			End If
		End Sub

		Private Sub DoiMau2(pGObjs As CGraphicObjs, pMau As Color)
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Select Case graphicObject.GetObjType()
						Case OBJECTTYPE.Ellipse, OBJECTTYPE.Pie
							Dim shapeGraphic As ShapeGraphic = CType(graphicObject, ShapeGraphic)
							Dim shapeGraphic2 As ShapeGraphic = shapeGraphic
							shapeGraphic2.LineColor = pMau
							shapeGraphic2.Line2Color = pMau
							shapeGraphic2.FillColor = Color.FromArgb(CInt(shapeGraphic2.FillColor.A), pMau)
						Case OBJECTTYPE.Text
							Dim textGraphic As TextGraphic = CType(graphicObject, TextGraphic)
							Dim textGraphic2 As TextGraphic = textGraphic
							textGraphic2.Color = pMau
						Case OBJECTTYPE.Table
						Case OBJECTTYPE.EmbeddedImage
						Case Else
							Try
								Dim nodesShapeGraphic As NodesShapeGraphic = CType(graphicObject, NodesShapeGraphic)
								Dim nodesShapeGraphic2 As NodesShapeGraphic = nodesShapeGraphic
								nodesShapeGraphic2.LineColor = pMau
								nodesShapeGraphic2.Line2Color = pMau
								nodesShapeGraphic2.FillColor = Color.FromArgb(CInt(nodesShapeGraphic2.FillColor.A), pMau)
							Catch expr_DA As Exception
								ProjectData.SetProjectError(expr_DA)
								ProjectData.ClearProjectError()
							End Try
					End Select
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Function GetLine(pPts As PointF()) As CSymbol
			Dim aGObj As GraphicObject = Nothing
			Dim normalPts As PointF() = COtherLineStyle.GetNormalPts(pPts, 1)
			Dim pt As PointF = Nothing
			If normalPts.GetUpperBound(0) > 0 Then
				Dim graphicsPath As GraphicsPath = New GraphicsPath()
				graphicsPath.AddLines(normalPts)
				Dim bounds As RectangleF = graphicsPath.GetBounds()
				pt.X = normalPts(0).X
				pt.Y = normalPts(0).Y
				Dim arg_6D_0 As Integer = 0
				Dim upperBound As Integer = normalPts.GetUpperBound(0)
				' The following expression was wrapped in a checked-expression
				For i As Integer = arg_6D_0 To upperBound
					Dim array As PointF() = normalPts
					Dim arg_7D_0 As PointF() = array
					Dim num As Integer = i
					arg_7D_0(num).X = array(num).X - pt.X
					array = normalPts
					Dim arg_A9_0 As PointF() = array
					num = i
					arg_A9_0(num).Y = array(num).Y - pt.Y
				Next
				aGObj = New LinesGraphic(normalPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = 1F, .LineColor = Color.Black, .Line2Width = 0F }
			End If
			Dim cGraphicObjs As CGraphicObjs = New CGraphicObjs()
			cGraphicObjs.Add(aGObj)
			Return New CSymbol(Me.m_Map, pt, cGraphicObjs, Me.m_Map.Zoom, Me.m_Map.MapScreenWidth)
		End Function

		Private Function GetSymbol(pPt As PointF, pFile As String, pTyle As Single) As CSymbol
			Dim cSymbol As CSymbol = Nothing
			Try
				Dim xmlFrag As String = MyProject.Computer.FileSystem.ReadAllText(pFile)
				Dim pGObjs As CGraphicObjs = CGraphicObjs.Str2Objects(xmlFrag, 0, 0, modBdTC.cDecSepa, modBdTC.cGrpSepa)
				Dim symbolRoot As System.Drawing.Point = Me.GetSymbolRoot(xmlFrag)
				Dim tyLe1GObjs As CGraphicObjs = Me.GetTyLe1GObjs(pGObjs)
				cSymbol = New CSymbol(Me.m_Map, pPt, tyLe1GObjs, Me.m_Map.Zoom, Me.m_Map.MapScreenWidth)
				Dim fromPt As PointF = Nothing
				Dim toPt As PointF = Nothing
				toPt.X = pPt.X + CSng(symbolRoot.X)
				toPt.Y = pPt.Y + CSng(symbolRoot.Y)
				Dim arg_BF_0 As AxMap = Me.m_Map
				Dim x As Single = toPt.X
				Dim y As Single = toPt.Y
				Dim newGocX As Double
				Dim newGocY As Double
				arg_BF_0.ConvertCoord(x, y, newGocX, newGocY, ConversionConstants.miScreenToMap)
				toPt.Y = y
				toPt.X = x
				cSymbol.ChangeRoot(Me.m_Map, newGocX, newGocY)
				fromPt.X = toPt.X
				fromPt.Y = toPt.Y
				toPt.X = pPt.X
				toPt.Y = pPt.Y
				cSymbol.Move(Me.m_Map, fromPt, toPt)
				Me.CalcSymbolZoom()
				cSymbol.Zoom = Me.SymbolZoom * CDec(pTyle)
				cSymbol.MWidth = Me.SymbolMapScreenWidth
			Catch expr_150 As Exception
				ProjectData.SetProjectError(expr_150)
				ProjectData.ClearProjectError()
			End Try
			Return cSymbol
		End Function

		Private Function GetSymbolRoot(xmlFrag As String) As System.Drawing.Point
			Dim nameTable As NameTable = New NameTable()
			Dim xmlNamespaceManager As XmlNamespaceManager = New XmlNamespaceManager(nameTable)
			xmlNamespaceManager.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, xmlNamespaceManager, Nothing, XmlSpace.None)
			Dim xmlTextReader As XmlTextReader = New XmlTextReader(xmlFrag, XmlNodeType.Element, context)
			Dim x As Integer = 0
			Dim y As Integer = 0
			While xmlTextReader.Read()
				Dim nodeType As XmlNodeType = xmlTextReader.NodeType
				Dim xmlNodeType As XmlNodeType = nodeType
				If xmlNodeType = XmlNodeType.Element Then
					Dim name As String = xmlTextReader.Name
					If Operators.CompareString(name, "KyHieu", False) = 0 AndAlso xmlTextReader.AttributeCount > 0 Then
						While xmlTextReader.MoveToNextAttribute()
							Dim name2 As String = xmlTextReader.Name
							If Operators.CompareString(name2, "CX", False) = 0 Then
								x = Conversions.ToInteger(xmlTextReader.Value)
							Else If Operators.CompareString(name2, "CY", False) = 0 Then
								y = Conversions.ToInteger(xmlTextReader.Value)
							End If
						End While
					End If
				End If
			End While
			xmlTextReader.Close()
			Dim result As System.Drawing.Point = New System.Drawing.Point(x, y)
			Return result
		End Function

		Private Function GetExplodeActSymbol(pActDef As CActDef) As CSymbol
			Dim cSymbol As CSymbol = Nothing
			Try
				Dim cExplodeObjDef As CExplodeObjDef = CType(pActDef, CExplodeObjDef)
				Dim pPt As PointF = New PointF(0F, 0F)
				If cExplodeObjDef.ObjName.Length = 0 Then
					Dim mapPoint As MAPPOINT = Me.GetMapPoint(cExplodeObjDef.frompos)
					Dim arg_61_0 As AxMap = Me.m_Map
					Dim num As Single = pPt.X
					Dim num2 As Single = pPt.Y
					arg_61_0.ConvertCoord(num, num2, mapPoint.X, mapPoint.Y, ConversionConstants.miMapToScreen)
					pPt.Y = num2
					pPt.X = num
				Else
					Dim symbolByName As Object = Me.GetSymbolByName(cExplodeObjDef.ObjName)
					If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(symbolByName)) Then
						Dim arg_FF_0 As AxMap = Me.m_Map
						Dim num2 As Single = pPt.X
						Dim num As Single = pPt.Y
						Dim instance As Object = symbolByName
						Dim num3 As Double = Conversions.ToDouble(NewLateBinding.LateGet(instance, Nothing, "gocx", New Object(-1) {}, Nothing, Nothing, Nothing))
						Dim instance2 As Object = symbolByName
						Dim num4 As Double = Conversions.ToDouble(NewLateBinding.LateGet(instance2, Nothing, "gocy", New Object(-1) {}, Nothing, Nothing, Nothing))
						arg_FF_0.ConvertCoord(num2, num, num3, num4, ConversionConstants.miMapToScreen)
						NewLateBinding.LateSetComplex(instance2, Nothing, "gocy", New Object() { num4 }, Nothing, Nothing, True, False)
						NewLateBinding.LateSetComplex(instance, Nothing, "gocx", New Object() { num3 }, Nothing, Nothing, True, False)
						pPt.Y = num
						pPt.X = num2
					End If
				End If
				cSymbol = Me.GetSymbol(pPt, modSaBan.myExplodeFile, 2F)
				If Not Information.IsNothing(cSymbol) Then
					cSymbol.Description = modSaBan.fActions.lstActions.Items.IndexOf(pActDef).ToString()
					Me.DoiMau2(cSymbol.GObjs, Color.DarkViolet)
				End If
			Catch expr_1B3 As Exception
				ProjectData.SetProjectError(expr_1B3)
				ProjectData.ClearProjectError()
			End Try
			Return cSymbol
		End Function

		Private Function GetAppearActSymbol(pActDef As CActDef) As CSymbol
			Dim cSymbol As CSymbol = Nothing
			Try
				Dim symbolByName As Object = Me.GetSymbolByName(pActDef.ObjName)
				If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(symbolByName)) Then
					Dim pt As PointF = Nothing
					Dim arg_88_0 As AxMap = Me.m_Map
					Dim x As Single = pt.X
					Dim y As Single = pt.Y
					Dim instance As Object = symbolByName
					Dim num As Double = Conversions.ToDouble(NewLateBinding.LateGet(instance, Nothing, "gocx", New Object(-1) {}, Nothing, Nothing, Nothing))
					Dim instance2 As Object = symbolByName
					Dim num2 As Double = Conversions.ToDouble(NewLateBinding.LateGet(instance2, Nothing, "gocy", New Object(-1) {}, Nothing, Nothing, Nothing))
					arg_88_0.ConvertCoord(x, y, num, num2, ConversionConstants.miMapToScreen)
					NewLateBinding.LateSetComplex(instance2, Nothing, "gocy", New Object() { num2 }, Nothing, Nothing, True, False)
					NewLateBinding.LateSetComplex(instance, Nothing, "gocx", New Object() { num }, Nothing, Nothing, True, False)
					pt.Y = y
					pt.X = x
					cSymbol = New CSymbol(Me.m_Map, pt, CType(NewLateBinding.LateGet(symbolByName, Nothing, "GObjs", New Object(-1) {}, Nothing, Nothing, Nothing), CGraphicObjs), Conversions.ToDouble(NewLateBinding.LateGet(symbolByName, Nothing, "Zoom", New Object(-1) {}, Nothing, Nothing, Nothing)), Conversions.ToSingle(NewLateBinding.LateGet(symbolByName, Nothing, "MWidth", New Object(-1) {}, Nothing, Nothing, Nothing)))
					CBdTC.DoiMau(cSymbol.GObjs, Color.Gray)
					cSymbol.Description = modSaBan.fActions.lstActions.Items.IndexOf(pActDef).ToString()
				End If
			Catch expr_17C As Exception
				ProjectData.SetProjectError(expr_17C)
				ProjectData.ClearProjectError()
			End Try
			Return cSymbol
		End Function

		Private Function GetMoveActSymbol(pActDef As CActDef) As CSymbol
			Dim cSymbol As CSymbol = Nothing
			Try
				Dim cMoveObjDef As CMoveObjDef = CType(pActDef, CMoveObjDef)
				Dim pts As List(Of MAPPOINT) = Me.GetPts(cMoveObjDef.targets)
				Dim count As Integer = pts.Count
				' The following expression was wrapped in a checked-statement
				Dim array As PointF() = New PointF(count - 1 + 1 - 1) {}
				Dim arg_33_0 As Integer = 0
				Dim num As Integer = count - 1
				For i As Integer = arg_33_0 To num
					Dim arg_A1_0 As AxMap = Me.m_Map
					Dim array2 As PointF() = array
					Dim arg_4C_0 As PointF() = array2
					Dim num2 As Integer = i
					Dim x As Single = arg_4C_0(num2).X
					Dim array3 As PointF() = array
					Dim arg_66_0 As PointF() = array3
					Dim num3 As Integer = i
					Dim y As Single = arg_66_0(num3).Y
					Dim x2 As Double = pts(i).X
					Dim y2 As Double = pts(i).Y
					arg_A1_0.ConvertCoord(x, y, x2, y2, ConversionConstants.miMapToScreen)
					array3(num3).Y = y
					array2(num2).X = x
				Next
				Dim line As CSymbol = Me.GetLine(array)
				cSymbol = New CSymbol(Me.m_Map, array(0), line.GObjs, line.Zoom, line.MWidth)
				cSymbol.Description = modSaBan.fActions.lstActions.Items.IndexOf(pActDef).ToString()
				cSymbol.ChangeRoot(Me.m_Map, pts(count - 1).X, pts(count - 1).Y)
				Dim symbol As CSymbol = Me.GetSymbol(array(count - 1), modSaBan.myMuiTenFile, 1.5F)
				If Not Information.IsNothing(symbol) Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim num4 As Single = modBdTC.AngleToPoint(array(count - 2), array(count - 1)) + 90F
					symbol.Rotate2(Me.m_Map, array(count - 1), CDec(num4))
					Try
						Dim enumerator As IEnumerator = symbol.GObjs.GetEnumerator()
						While enumerator.MoveNext()
							Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
							cSymbol.GObjs.Add(aGObj)
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
				End If
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a checked-expression
				cSymbol.ChangeRoot(Me.m_Map, (pts(count - 1).X + pts(0).X) / 2.0, (pts(count - 1).Y + pts(0).Y) / 2.0)
				Me.DoiMau2(cSymbol.GObjs, Color.Blue)
			Catch expr_29F As Exception
				ProjectData.SetProjectError(expr_29F)
				ProjectData.ClearProjectError()
			End Try
			Return cSymbol
		End Function

		Private Function GetShootActSymbol(pActDef As CActDef) As CSymbol
			Dim cSymbol As CSymbol = Nothing
			' The following expression was wrapped in a checked-statement
			Try
				Dim vector As Vector3
				Dim mapPoint As MAPPOINT
				If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(pActDef, Nothing, "ObjName", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Length", New Object(-1) {}, Nothing, Nothing, Nothing), 0, False) Then
					Dim expr_54 As Object = NewLateBinding.LateGet(pActDef, Nothing, "frompos", New Object(-1) {}, Nothing, Nothing, Nothing)
					mapPoint = Me.GetMapPoint(If((expr_54 IsNot Nothing), (CType(expr_54, Vector3)), vector))
				Else
					Dim symbolByName As CSymbol = Me.GetSymbolByName(Conversions.ToString(NewLateBinding.LateGet(pActDef, Nothing, "ObjName", New Object(-1) {}, Nothing, Nothing, Nothing)))
					If Not Information.IsNothing(symbolByName) Then
						mapPoint.X = symbolByName.GocX
						mapPoint.Y = symbolByName.GocY
					End If
				End If
				Dim pointF As PointF = New PointF(0F, 0F)
				Dim arg_F2_0 As AxMap = Me.m_Map
				Dim num As Single = pointF.X
				Dim num2 As Single = pointF.Y
				arg_F2_0.ConvertCoord(num, num2, mapPoint.X, mapPoint.Y, ConversionConstants.miMapToScreen)
				pointF.Y = num2
				pointF.X = num
				Dim pointF2 As PointF = New PointF(0F, 0F)
				Dim expr_131 As Object = NewLateBinding.LateGet(pActDef, Nothing, "topos", New Object(-1) {}, Nothing, Nothing, Nothing)
				Dim mapPoint2 As MAPPOINT = Me.GetMapPoint(If((expr_131 IsNot Nothing), (CType(expr_131, Vector3)), vector))
				Dim arg_175_0 As AxMap = Me.m_Map
				num2 = pointF2.X
				num = pointF2.Y
				arg_175_0.ConvertCoord(num2, num, mapPoint2.X, mapPoint2.Y, ConversionConstants.miMapToScreen)
				pointF2.Y = num
				pointF2.X = num2
				Dim num3 As Integer = 2
				Dim array As PointF() = New PointF(num3 - 1 + 1 - 1) {}
				array(0) = pointF
				array(1) = pointF2
				Dim line As CSymbol = Me.GetLine(array)
				cSymbol = New CSymbol(Me.m_Map, array(0), line.GObjs, line.Zoom, line.MWidth)
				cSymbol.Description = modSaBan.fActions.lstActions.Items.IndexOf(pActDef).ToString()
				cSymbol.ChangeRoot(Me.m_Map, mapPoint2.X, mapPoint2.Y)
				Dim symbol As CSymbol = Me.GetSymbol(array(num3 - 1), modSaBan.myMuiTenFile, 0.8F)
				If Not Information.IsNothing(symbol) Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim num4 As Single = modBdTC.AngleToPoint(array(num3 - 2), array(num3 - 1)) + 90F
					symbol.Rotate2(Me.m_Map, array(num3 - 1), CDec(num4))
					Try
						Dim enumerator As IEnumerator = symbol.GObjs.GetEnumerator()
						While enumerator.MoveNext()
							Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
							cSymbol.GObjs.Add(aGObj)
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
				End If
				Me.DoiMau2(cSymbol.GObjs, Color.DarkViolet)
			Catch expr_304 As Exception
				ProjectData.SetProjectError(expr_304)
				ProjectData.ClearProjectError()
			End Try
			Return cSymbol
		End Function

		Private Function GetSpinActSymbol(pActDef As CActDef) As CSymbol
			Dim cSymbol As CSymbol = Nothing
			' The following expression was wrapped in a checked-statement
			Try
				Dim vector As Vector3
				Dim mapPoint As MAPPOINT
				If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(pActDef, Nothing, "ObjName", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Length", New Object(-1) {}, Nothing, Nothing, Nothing), 0, False) Then
					Dim expr_54 As Object = NewLateBinding.LateGet(pActDef, Nothing, "frompos", New Object(-1) {}, Nothing, Nothing, Nothing)
					mapPoint = Me.GetMapPoint(If((expr_54 IsNot Nothing), (CType(expr_54, Vector3)), vector))
				Else
					Dim symbolByName As CSymbol = Me.GetSymbolByName(Conversions.ToString(NewLateBinding.LateGet(pActDef, Nothing, "ObjName", New Object(-1) {}, Nothing, Nothing, Nothing)))
					If Not Information.IsNothing(symbolByName) Then
						mapPoint.X = symbolByName.GocX
						mapPoint.Y = symbolByName.GocY
					End If
				End If
				Dim pointF As PointF = New PointF(0F, 0F)
				Dim arg_F2_0 As AxMap = Me.m_Map
				Dim num As Single = pointF.X
				Dim num2 As Single = pointF.Y
				arg_F2_0.ConvertCoord(num, num2, mapPoint.X, mapPoint.Y, ConversionConstants.miMapToScreen)
				pointF.Y = num2
				pointF.X = num
				Dim pointF2 As PointF = New PointF(0F, 0F)
				Dim expr_131 As Object = NewLateBinding.LateGet(pActDef, Nothing, "topos", New Object(-1) {}, Nothing, Nothing, Nothing)
				Dim mapPoint2 As MAPPOINT = Me.GetMapPoint(If((expr_131 IsNot Nothing), (CType(expr_131, Vector3)), vector))
				Dim arg_175_0 As AxMap = Me.m_Map
				num2 = pointF2.X
				num = pointF2.Y
				arg_175_0.ConvertCoord(num2, num, mapPoint2.X, mapPoint2.Y, ConversionConstants.miMapToScreen)
				pointF2.Y = num
				pointF2.X = num2
				Dim num3 As Integer = 2
				Dim array As PointF() = New PointF(num3 - 1 + 1 - 1) {}
				array(0) = pointF
				array(1) = pointF2
				Dim line As CSymbol = Me.GetLine(array)
				cSymbol = New CSymbol(Me.m_Map, array(0), line.GObjs, line.Zoom, line.MWidth)
				cSymbol.Description = modSaBan.fActions.lstActions.Items.IndexOf(pActDef).ToString()
				cSymbol.ChangeRoot(Me.m_Map, mapPoint2.X, mapPoint2.Y)
				Dim symbol As CSymbol = Me.GetSymbol(array(num3 - 1), modSaBan.myMuiTenFile, 0.4F)
				If Not Information.IsNothing(symbol) Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim num4 As Single = modBdTC.AngleToPoint(array(num3 - 2), array(num3 - 1)) + 90F
					symbol.Rotate2(Me.m_Map, array(num3 - 1), CDec(num4))
					Try
						Dim enumerator As IEnumerator = symbol.GObjs.GetEnumerator()
						While enumerator.MoveNext()
							Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
							cSymbol.GObjs.Add(aGObj)
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
				End If
				Me.DoiMau2(cSymbol.GObjs, Color.Gray)
			Catch expr_304 As Exception
				ProjectData.SetProjectError(expr_304)
				ProjectData.ClearProjectError()
			End Try
			Return cSymbol
		End Function

		Public Sub OnGetObjName(ptxtKQ As TextBox, ptxtObjType As TextBox)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CVeActs.MapTools.GetObjName
			myModule.fMain.myBando.SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.txtKQ = ptxtKQ
			Me.txtObjType = ptxtObjType
			myModule.fMain.ToolStripStatusLabel3.Text = "Lay Ten DT: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n DT."
		End Sub

		Public Sub OnGetObjName2(ptxtKQ As TextBox, ptxtObjType As TextBox)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CVeActs.MapTools.GetObjName2
			myModule.fMain.myBando.SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.txtKQ = ptxtKQ
			Me.txtObjType = ptxtObjType
			myModule.fMain.ToolStripStatusLabel3.Text = "Lay Ten DT: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n DT."
		End Sub

		Private Sub GetObjName2(pSymbol As CSymbol)
			Me.txtKQ.Text = pSymbol.Description
			Me.txtObjType.Text = myModule.fMain.myTerrain.GetSymbolType(pSymbol)
			myModule.fMain.ToolStripStatusLabel3.Text = ""
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CVeActs.MapTools.None
		End Sub

		Private Sub GetObjName(pSymbol As CSymbol)
			If Not modSaBan.fActions.IsNameOK(pSymbol.Description) Then
				pSymbol.Description = modSaBan.fActions.GetUniqObjName(pSymbol.Description)
				myModule.fMain.lstCacKyHieu.SelectedIndex = myModule.fMain.lstCacKyHieu.Items.IndexOf(pSymbol)
				myModule.fMain.myBando.ChangeDesc(pSymbol, CType(Me.txtKQ.Parent, Form))
			End If
			Me.txtKQ.Text = pSymbol.Description
			Me.txtObjType.Text = myModule.fMain.myTerrain.GetSymbolType(pSymbol)
			myModule.fMain.ToolStripStatusLabel3.Text = ""
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CVeActs.MapTools.None
		End Sub

		Private Function GetTyLe1GObjs(pGObjs As CGraphicObjs) As CGraphicObjs
			Dim cGraphicObjs As CGraphicObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim aGObj As GraphicObject = graphicObject.Clone()
					cGraphicObjs.Add(aGObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return cGraphicObjs
		End Function

		Private Sub DrawDrawingLine(pPts As PointF())
			Dim graphics As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			Dim transform As System.Drawing.Drawing2D.Matrix = graphics.Transform
			Dim container As GraphicsContainer = graphics.BeginContainer()
			graphics.PageUnit = GraphicsUnit.Pixel
			graphics.ScaleTransform(1F, 1F)
			Dim upperBound As Integer = pPts.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim array As System.Drawing.Point() = New System.Drawing.Point(upperBound + 1 - 1) {}
			Dim arg_6D_0 As Integer = 0
			Dim num As Integer = upperBound
			For i As Integer = arg_6D_0 To num
				array(i).X = CInt(Math.Round(CDec(pPts(i).X)))
				array(i).Y = CInt(Math.Round(CDec(pPts(i).Y)))
			Next
			graphics.DrawCurve(pen, array)
			graphics.EndContainer(container)
			graphics.Transform = transform
			pen.Dispose()
		End Sub

		Public Sub m_Map_DrawUserLayer(sender As Object, e As CMapXEvents_DrawUserLayerEvent)
			Dim hdc As IntPtr = New IntPtr(e.hOutputDC)
			Dim g As Graphics = Graphics.FromHdc(hdc)
			Me.DrawActDef(g)
		End Sub

		Public Sub m_Map_MouseDownEvent(sender As Object, e As CMapXEvents_MouseDownEvent)
			' The following expression was wrapped in a checked-statement
			Dim point As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			If modSaBan.fActions.bView AndAlso Me.m_Map.CurrentTool = ToolConstants.miArrowTool Then
				modSaBan.fActions.lstActions.SelectedItems.Clear()
				modSaBan.fActions.lstActions.SelectionMode = SelectionMode.MultiSimple
				Dim arg_8A_0 As CSymbols = Me.myActSymbols
				Dim arg_8A_1 As AxMap = Me.m_Map
				Dim pt As PointF = New PointF(e.x, e.y)
				Dim list As List(Of CSymbol) = arg_8A_0.FindSymbolsAtPoint(arg_8A_1, pt)
				If list.Count > 0 Then
					Try
						Dim enumerator As List(Of CSymbol).Enumerator = list.GetEnumerator()
						While enumerator.MoveNext()
							Dim current As CSymbol = enumerator.Current
							Dim cActDef As CActDef = CType(modSaBan.fActions.lstActions.Items(CInt(Math.Round(Conversion.Val(current.Description)))), CActDef)
							modSaBan.fActions.lstActions.SelectedItems.Add(cActDef)
							Me.OnSeleActDef(cActDef)
						End While
					Finally
						Dim enumerator As List(Of CSymbol).Enumerator
						(CType(enumerator, IDisposable)).Dispose()
					End Try
				Else
					Dim arg_13A_0 As CSymbols = myModule.fMain.myBando.drawingSymbols
					Dim arg_13A_1 As AxMap = Me.m_Map
					pt = New PointF(e.x, e.y)
					Dim cSymbol As CSymbol = arg_13A_0.FindSymbolAtPoint(arg_13A_1, pt)
					If cSymbol IsNot Nothing Then
						Dim arg_15E_0 As Integer = 0
						Dim num As Integer = modSaBan.fActions.lstActions.Items.Count - 1
						For i As Integer = arg_15E_0 To num
							Dim cActDef2 As CActDef = CType(modSaBan.fActions.lstActions.Items(i), CActDef)
							If Operators.CompareString(cActDef2.ObjName, cSymbol.Description, False) = 0 Then
								modSaBan.fActions.lstActions.SelectedItems.Add(cActDef2)
								Me.OnSeleActDef(cActDef2)
							End If
						Next
					End If
				End If
			End If
			Select Case Me.myMapTool
				Case CVeActs.MapTools.GetTarget
					If e.button = 1S Then
						If Not Me.DrawingPicking Then
							Me.DrawingPicking = True
							Me.myPts = New PointF(1) {}
							Me.myPts(0) = New PointF(CSng(point.X), CSng(point.Y))
							Me.myPts(1) = New PointF(CSng(point.X), CSng(point.Y))
						Else
							Dim num2 As Integer = Me.myPts.GetUpperBound(0)
							num2 += 1
							Me.myPts = CType(Utils.CopyArray(CType(Me.myPts, Array), New PointF(num2 + 1 - 1) {}), PointF())
							Me.myPts(num2) = New PointF(CSng(point.X), CSng(point.Y))
						End If
					Else
						If Not Me.DrawingPicking AndAlso Me.myMapTool = CVeActs.MapTools.GetTarget Then
							Me.myPts = New PointF(0) {}
							Me.myPts(0) = New PointF(CSng(point.X), CSng(point.Y))
							Me.GetTargets()
						End If
						If Me.myPts.GetUpperBound(0) > 0 AndAlso Me.myMapTool = CVeActs.MapTools.GetTarget Then
							Me.GetTargets()
						End If
						Me.DrawingPicking = False
						If Me.myMapTool = CVeActs.MapTools.GetTarget Then
							Me.myPts = New PointF(-1) {}
							myModule.fMain.ToolStripStatusLabel3.Text = ""
							Me.m_Map.CurrentTool = ToolConstants.miArrowTool
							Me.myMapTool = CVeActs.MapTools.None
						End If
					End If
				Case CVeActs.MapTools.GetObjName
					Dim arg_20C_0 As CSymbols = myModule.fMain.myBando.drawingSymbols
					Dim arg_20C_1 As AxMap = Me.m_Map
					Dim pt As PointF = New PointF(e.x, e.y)
					Dim cSymbol2 As CSymbol = arg_20C_0.FindSymbolAtPoint(arg_20C_1, pt)
					If cSymbol2 IsNot Nothing Then
						Me.GetObjName(cSymbol2)
					End If
				Case CVeActs.MapTools.GetObjName2
					Dim arg_24E_0 As CSymbols = myModule.fMain.myBando.drawingSymbols
					Dim arg_24E_1 As AxMap = Me.m_Map
					Dim pt As PointF = New PointF(e.x, e.y)
					Dim cSymbol3 As CSymbol = arg_24E_0.FindSymbolAtPoint(arg_24E_1, pt)
					If cSymbol3 IsNot Nothing Then
						Me.GetObjName2(cSymbol3)
					End If
				Case CVeActs.MapTools.GetFocus
					Dim pMapX As Double
					Dim pMapY As Double
					Me.m_Map.ConvertCoord(e.x, e.y, pMapX, pMapY, ConversionConstants.miScreenToMap)
					Dim surfPosition As PointF = modSaBan.GetSurfPosition(pMapX, pMapY)
					Dim num3 As Single = CSng((CDec(surfPosition.X) / modSaBan.mySurf2X))
					' The following expression was wrapped in a unchecked-expression
					Dim num4 As Single = CSng((modSaBan.mySurf2Y - CDec(surfPosition.Y) / modSaBan.mySurf2Y))
					Me.txtKQ.Text = num3.ToString()
					Me.txtKQ2.Text = num4.ToString()
					myModule.fMain.ToolStripStatusLabel3.Text = ""
					Me.m_Map.CurrentTool = ToolConstants.miArrowTool
					Me.myMapTool = CVeActs.MapTools.None
			End Select
		End Sub

		Public Sub m_Map_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			' The following expression was wrapped in a checked-expression
			Dim point As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			If Me.DrawingPicking Then
				Dim value As Object = Me.myPts.GetUpperBound(0)
				Me.myPts(Conversions.ToInteger(value)).X = CSng(point.X)
				Me.myPts(Conversions.ToInteger(value)).Y = CSng(point.Y)
				Me.DrawDrawingLine(Me.myPts)
			End If
		End Sub
	End Class
End Namespace
