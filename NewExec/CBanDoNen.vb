Imports AxMapXLib
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace SaBan
	Public Class CBanDoNen
		Public Enum MapTools
			None
			Ruller
		End Enum

		Public myMapTool As CBanDoNen.MapTools

		Private m_Map As AxMap

		Private m_ParentForm As Form

		Private m_ToolStripStatusLabel3 As ToolStripStatusLabel

		Private m_ToolStripStatusLabel1 As ToolStripStatusLabel

		Private strDistanceUnit As String

		Private strDistanceKQ As String

		Private DistanceKQ As Integer

		Private myPts As PointF()

		Private myfromPt As PointF

		Private mytoPt As PointF

		Private myrootPt As PointF

		Private DrawingPicking As Boolean

		Public Sub New(pMap As AxMap, pForm As Form, pToolStripStatusLabel3 As ToolStripStatusLabel, pToolStripStatusLabel1 As ToolStripStatusLabel)
			Me.strDistanceUnit = "m"
			Me.DrawingPicking = False
			Me.m_ParentForm = pForm
			Me.m_Map = pMap
			Me.m_ToolStripStatusLabel3 = pToolStripStatusLabel3
			Me.m_ToolStripStatusLabel1 = pToolStripStatusLabel1
			Me.myMapTool = CBanDoNen.MapTools.None
		End Sub

		Public Shared Sub AddDataSets(pMap As AxMap)
			pMap.DataSets.RemoveAll()
			' The following expression was wrapped in a checked-statement
			If pMap.Layers.Count > 0 Then
				Dim arg_26_0 As Integer = 1
				Dim count As Integer = pMap.Layers.Count
				For i As Integer = arg_26_0 To count
					Dim layer As Layer = pMap.Layers(i)
					If layer.Type = LayerTypeConstants.miLayerTypeNormal Then
						Try
							pMap.DataSets.Add(DatasetTypeConstants.miDataSetLayer, layer, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value)
						Catch expr_72 As Exception
							ProjectData.SetProjectError(expr_72)
							ProjectData.ClearProjectError()
						End Try
					End If
				Next
			End If
		End Sub

		Public Shared Sub LoadGst(pMap As AxMap, pMapGst As String)
			Try
				pMap.GeoSet = pMapGst
				pMap.Title.Visible = False
				pMap.MapUnit = MapUnitConstants.miUnitMeter
				Dim displayCoordSys As CoordSys = pMap.DisplayCoordSys
				pMap.NumericCoordSys = displayCoordSys
				pMap.InfotipSupport = False
				pMap.NumericCoordSys.[Set](CType(modBanDo.myCoordSysType, CoordSysTypeConstants), displayCoordSys.Datum, pMap.NumericCoordSys.Units, pMap.NumericCoordSys.OriginLongitude, pMap.NumericCoordSys.OriginLatitude, pMap.NumericCoordSys.StandardParallelOne, pMap.NumericCoordSys.StandardParallelTwo, pMap.NumericCoordSys.Azimuth, pMap.NumericCoordSys.ScaleFactor, pMap.NumericCoordSys.FalseEasting, pMap.NumericCoordSys.FalseNorthing, pMap.NumericCoordSys.Range, Missing.Value, Missing.Value)
				pMap.PaperUnit = PaperUnitConstants.miPaperUnitCentimeter
			Catch expr_F8 As Exception
				ProjectData.SetProjectError(expr_F8)
				Dim ex As Exception = expr_F8
				Throw ex
			End Try
		End Sub

		Public Sub Zoom1X()
			Dim zoomLevel As Double = modBanDo.GetZoomLevel(Me.m_Map, modBanDo.BDTyLeBanDo)
			Me.m_Map.ZoomTo(zoomLevel, modBanDo.BDKinhDo, modBanDo.BDViDo)
		End Sub

		Public Sub OnDoKhoangCach()
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CBanDoNen.MapTools.Ruller
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.strDistanceKQ = ""
			Me.myPts = New PointF(-1) {}
			Me.DrawingPicking = False
			Me.m_ToolStripStatusLabel3.Text = ChrW(272) & "o kho" & ChrW(7843) & "ng cách: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các V" & ChrW(7883) & " trí, RightClick " & ChrW(273) & ChrW(7875) & " xem K" & ChrW(7871) & "t qu" & ChrW(7843) & "."
		End Sub

		Public Sub procThongTin(x1 As Double, y1 As Double)
			Dim feature As Feature = Nothing
			Dim point As MapXLib.Point = New PointClass()
			point.[Set](x1, y1)
			Dim num As Long = 0L
			Dim arg_29_0 As Integer = 2
			Dim count As Integer = Me.m_Map.Layers.Count
			' The following expression was wrapped in a checked-statement
			For i As Integer = arg_29_0 To count
				Dim layer As Layer = Me.m_Map.Layers(i)
				Try
					If num = 0L Then
						Dim features As Features = layer.SearchAtPoint(point, Missing.Value)
						If features.Count > 0 Then
							feature = features(1)
							layer.Selection.SelectByID(feature.FeatureID, SelectionTypeConstants.miSelectionNew)
							' The following expression was wrapped in a unchecked-expression
							num = CLng(feature.FeatureID)
						End If
					Else
						layer.Selection.ClearSelection()
					End If
				Catch expr_9F As Exception
					ProjectData.SetProjectError(expr_9F)
					ProjectData.ClearProjectError()
				End Try
			Next
			If num > 0L Then
				Me.ThongTinKhac(feature)
			End If
		End Sub

		Private Sub ThongTinKhac(pf As Feature)
			Dim dataset As Dataset = Nothing
			Dim layer As Layer = pf.Layer
			Dim text As String = ""
			Dim arg_23_0 As Integer = 1
			Dim count As Integer = Me.m_Map.DataSets.Count
			' The following expression was wrapped in a checked-statement
			For i As Integer = arg_23_0 To count
				dataset = Me.m_Map.DataSets(i)
				If Operators.CompareString(dataset.Layer.Name, layer.Name, False) = 0 Then
					Exit For
				End If
			Next
			Dim rowValues As RowValues = dataset.get_RowValues(pf)
			Dim arg_75_0 As Integer = 1
			Dim count2 As Integer = rowValues.Count
			For i As Integer = arg_75_0 To count2
				Dim rowValue As RowValue = rowValues(i)
				Dim field As Field = CType(rowValue.Field, Field)
				text = String.Concat(New String() { text, myModule.toUnicode(field.Name), ": ", myModule.toUnicode(RuntimeHelpers.GetObjectValue(rowValue.Value)), vbCrLf })
			Next
			text = Strings.Left(text, Strings.Len(text) - 2)
			MessageBox.Show(Me.m_ParentForm, text, "L" & ChrW(7899) & "p: " + layer.Name)
			layer.Selection.ClearSelection()
		End Sub

		Public Sub m_Map_MouseDownEvent(sender As Object, e As CMapXEvents_MouseDownEvent)
			' The following expression was wrapped in a checked-statement
			Dim point As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			Dim instance As Object = point
			If Me.myMapTool = CBanDoNen.MapTools.Ruller Then
				If e.button = 1S Then
					If Not Me.DrawingPicking Then
						Me.DrawingPicking = True
						Me.myPts = New PointF(1) {}
						Me.myPts(0) = New PointF(Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "X", New Object(-1) {}, Nothing, Nothing, Nothing)), Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "Y", New Object(-1) {}, Nothing, Nothing, Nothing)))
						Me.myPts(1) = New PointF(Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "X", New Object(-1) {}, Nothing, Nothing, Nothing)), Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "Y", New Object(-1) {}, Nothing, Nothing, Nothing)))
					Else
						Dim num As Integer = Me.myPts.GetUpperBound(0)
						num += 1
						Me.myPts = CType(Utils.CopyArray(CType(Me.myPts, Array), New PointF(num + 1 - 1) {}), PointF())
						Me.myPts(num) = New PointF(Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "X", New Object(-1) {}, Nothing, Nothing, Nothing)), Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "Y", New Object(-1) {}, Nothing, Nothing, Nothing)))
					End If
				Else
					If Me.myPts.GetUpperBound(0) > 0 Then
						Dim i As Integer
						If Me.myPts.GetUpperBound(0) > 0 Then
							Dim arg_19C_0 As Integer = 1
							Dim upperBound As Integer = Me.myPts.GetUpperBound(0)
							i = arg_19C_0
							While i <= upperBound
								Dim arg_1EB_0 As AxMap = Me.m_Map
								Dim array As PointF() = Me.myPts
								Dim arg_1B9_0 As PointF() = array
								Dim num2 As Integer = i - 1
								Dim num3 As Single = arg_1B9_0(num2).X
								Dim array2 As PointF() = Me.myPts
								Dim arg_1D8_0 As PointF() = array2
								Dim num4 As Integer = i - 1
								Dim num5 As Single = arg_1D8_0(num4).Y
								Dim x As Double
								Dim y As Double
								arg_1EB_0.ConvertCoord(num3, num5, x, y, ConversionConstants.miScreenToMap)
								array2(num4).Y = num5
								array(num2).X = num3
								Dim arg_255_0 As AxMap = Me.m_Map
								array2 = Me.myPts
								Dim arg_225_0 As PointF() = array2
								num4 = i
								num5 = arg_225_0(num4).X
								array = Me.myPts
								Dim arg_242_0 As PointF() = array
								num2 = i
								num3 = arg_242_0(num2).Y
								Dim x2 As Double
								Dim y2 As Double
								arg_255_0.ConvertCoord(num5, num3, x2, y2, ConversionConstants.miScreenToMap)
								array(num2).Y = num3
								array2(num4).X = num5
								Dim num6 As Integer = CInt(Math.Round(Me.m_Map.Distance(x, y, x2, y2)))
								If Me.strDistanceKQ.Length > 0 Then
									Me.DistanceKQ += num6
									Me.strDistanceKQ = Me.strDistanceKQ + " + " + Strings.Format(num6, "#,###")
								Else
									Me.DistanceKQ = num6
									Me.strDistanceKQ = Strings.Format(num6, "#,###")
								End If
								i += 1
							End While
						End If
						If Me.strDistanceKQ.IndexOf("+") > -1 Then
							Me.strDistanceKQ = String.Concat(New String() { Me.strDistanceKQ, " = ", Strings.Format(Me.DistanceKQ, "#,###"), " ", Me.strDistanceUnit })
						Else
							Me.strDistanceKQ = Strings.Format(Me.DistanceKQ, "#,###") + " " + Me.strDistanceUnit
						End If
						i = Me.myPts.GetUpperBound(0)
						Dim hDG As Double = modSaBan.GetHDG(Me.myPts(i - 1), Me.myPts(i))
						Me.strDistanceKQ = Me.strDistanceKQ + vbCr & "Góc: " + hDG.ToString("#,###")
						MessageBox.Show(Me.m_ParentForm, Me.strDistanceKQ, "K" & ChrW(7871) & "t qu" & ChrW(7843) & " " & ChrW(273) & "o:", MessageBoxButtons.OK)
						SendKeys.Send("{ESC}")
					End If
					Me.DrawingPicking = False
					Me.strDistanceKQ = ""
					Me.myPts = New PointF(-1) {}
					Me.m_ToolStripStatusLabel3.Text = ""
					Me.myMapTool = CBanDoNen.MapTools.None
				End If
			End If
		End Sub

		Private Function gscTogoc(X As Integer, Y As Integer) As PointF
			Dim arg_17_0 As AxMap = Me.m_Map
			Dim num As Single = CSng(X)
			Dim num2 As Single = CSng(Y)
			Dim num3 As Double
			Dim num4 As Double
			arg_17_0.ConvertCoord(num, num2, num3, num4, ConversionConstants.miScreenToMap)
			' The following expression was wrapped in a checked-statement
			Y = CInt(Math.Round(CDec(num2)))
			X = CInt(Math.Round(CDec(num)))
			Dim result As PointF = New PointF(CSng(num3), CSng(num4))
			Return result
		End Function

		Public Sub m_Map_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			' The following expression was wrapped in a checked-statement
			Dim pointF As PointF = Me.gscTogoc(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			Dim arg_AE_0 As ToolStripItem = Me.m_ToolStripStatusLabel1
			Dim array As String() = New String(7) {}
			array(0) = modSaBan.getDPGstr(CDec(pointF.X))
			array(1) = ", "
			array(2) = modSaBan.getDPGstr(CDec(pointF.Y))
			array(3) = " ("
			Dim arg_7B_0 As String() = array
			Dim arg_7B_1 As Integer = 4
			Dim x As Single = pointF.X
			arg_7B_0(arg_7B_1) = x.ToString("0.00000000")
			array(5) = ", "
			Dim arg_9D_0 As String() = array
			Dim arg_9D_1 As Integer = 6
			Dim y As Single = pointF.Y
			arg_9D_0(arg_9D_1) = y.ToString("0.00000000")
			array(7) = ")"
			arg_AE_0.Text = String.Concat(array)
			Dim point As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			Dim instance As Object = point
			If Me.myMapTool = CBanDoNen.MapTools.Ruller AndAlso Me.DrawingPicking Then
				Dim obj As Object = Me.myPts.GetUpperBound(0)
				Me.myPts(Conversions.ToInteger(obj)).X = Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "X", New Object(-1) {}, Nothing, Nothing, Nothing))
				Me.myPts(Conversions.ToInteger(obj)).Y = Conversions.ToSingle(NewLateBinding.LateGet(instance, Nothing, "Y", New Object(-1) {}, Nothing, Nothing, Nothing))
				Me.DrawDrawingLine(Me.myPts)
				Dim arg_1D6_0 As AxMap = Me.m_Map
				Dim array2 As PointF() = Me.myPts
				Dim arg_196_0 As PointF() = array2
				Dim num As Integer = Conversions.ToInteger(Operators.SubtractObject(obj, 1))
				x = arg_196_0(num).X
				Dim array3 As PointF() = Me.myPts
				Dim arg_1C3_0 As PointF() = array3
				Dim num2 As Integer = Conversions.ToInteger(Operators.SubtractObject(obj, 1))
				y = arg_1C3_0(num2).Y
				Dim x2 As Double
				Dim y2 As Double
				arg_1D6_0.ConvertCoord(x, y, x2, y2, ConversionConstants.miScreenToMap)
				array3(num2).Y = y
				array2(num).X = x
				Dim arg_24A_0 As AxMap = Me.m_Map
				array3 = Me.myPts
				Dim arg_215_0 As PointF() = array3
				num2 = Conversions.ToInteger(obj)
				x = arg_215_0(num2).X
				array2 = Me.myPts
				Dim arg_237_0 As PointF() = array2
				num = Conversions.ToInteger(obj)
				y = arg_237_0(num).Y
				Dim x3 As Double
				Dim y3 As Double
				arg_24A_0.ConvertCoord(x, y, x3, y3, ConversionConstants.miScreenToMap)
				array2(num).Y = y
				array3(num2).X = x
				Dim num3 As Integer = CInt(Math.Round(Me.m_Map.Distance(x2, y2, x3, y3)))
				Dim hDG As Double = modSaBan.GetHDG(Me.myPts(Conversions.ToInteger(Operators.SubtractObject(obj, 1))), Me.myPts(Conversions.ToInteger(obj)))
				Me.m_ToolStripStatusLabel3.Text = ChrW(272) & "o: " + num3.ToString("#,###") + "; Góc: " + hDG.ToString("#,###")
			End If
		End Sub

		Private Sub DrawDrawingLine(pPts As PointF())
			Dim graphics As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			Dim upperBound As Integer = pPts.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim array As System.Drawing.Point() = New System.Drawing.Point(upperBound + 1 - 1) {}
			Dim arg_46_0 As Integer = 0
			Dim num As Integer = upperBound
			For i As Integer = arg_46_0 To num
				array(i).X = CInt(Math.Round(CDec(pPts(i).X)))
				array(i).Y = CInt(Math.Round(CDec(pPts(i).Y)))
			Next
			graphics.DrawLines(pen, array)
			pen.Dispose()
		End Sub

		Public Shared Sub NhapNhayFeature(m_Map As AxMap, pLop As String, pFKey As String, pSoLan As Integer)
			Dim num3 As Integer
			Dim num4 As Integer
			Try
				IL_00:
				Dim num As Integer = 1
				Dim style As Style = New StyleClass()
				IL_0A:
				num = 2
				Dim num2 As UInteger = 0UI
				IL_15:
				ProjectData.ClearProjectError()
				num3 = 2
				IL_1D:
				num = 4
				Dim layer As Layer = m_Map.Layers(pLop)
				IL_2E:
				num = 5
				Dim feature As Feature = layer.GetFeatureByKey(pFKey)
				IL_3A:
				num = 6
				If m_Map.IsPointVisible(feature.CenterX, feature.CenterY) Then
					GoTo IL_6F
				End If
				IL_51:
				num = 7
				m_Map.CenterX = feature.CenterX
				IL_60:
				num = 8
				m_Map.CenterY = feature.CenterY
				IL_6F:
				num = 10
				If feature.Type <> FeatureTypeConstants.miFeatureTypeSymbol Then
					GoTo IL_8D
				End If
				IL_7C:
				num = 11
				CBanDoNen.NhapNhayFeature(m_Map, feature, pSoLan)
				IL_88:
				GoTo IL_226
				IL_8D:
				num = 13
				IL_91:
				num = 14
				style = feature.Style
				IL_9D:
				num = 15
				If feature.Type <> FeatureTypeConstants.miFeatureTypeLine Then
					GoTo IL_D3
				End If
				IL_AA:
				num = 16
				style.LineColor = UInteger.Parse(Conversions.ToString(255))
				IL_C4:
				num = 17
				style.LineStyle = CType(46, PenStyleConstants)
				IL_D1:
				GoTo IL_149
				IL_D3:
				num = 19
				If feature.Type <> FeatureTypeConstants.miFeatureTypeRegion Then
					GoTo IL_122
				End If
				IL_E0:
				num = 20
				style.RegionBorderColor = UInteger.Parse(Conversions.ToString(16777215))
				IL_FA:
				num = 21
				style.RegionPattern = FillPatternConstants.miPatternDiagCross
				IL_106:
				num = 22
				style.RegionColor = UInteger.Parse(Conversions.ToString(255))
				IL_120:
				GoTo IL_149
				IL_122:
				num = 24
				If feature.Type <> FeatureTypeConstants.miFeatureTypeText Then
					GoTo IL_149
				End If
				IL_12F:
				num = 25
				style.TextFontColor = UInteger.Parse(Conversions.ToString(16777215))
				IL_149:
				num = 27
				feature.Style = style
				IL_155:
				num = 28
				Dim layer2 As Layer = m_Map.Layers.CreateLayer("tempAnimate", Missing.Value, 1, Missing.Value, Missing.Value)
				IL_17F:
				num = 29
				m_Map.Layers.AnimationLayer = layer2
				IL_18F:
				num = 30
				layer2.AddFeature(feature, Missing.Value)
				IL_1A0:
				num = 31
				' The following expression was wrapped in a checked-statement
				For i As Integer = 1 To pSoLan
					IL_1AB:
					num = 32
					layer2.Visible = True
					IL_1B6:
					num = 33
					Thread.Sleep(120)
					IL_1C1:
					num = 34
					Application.DoEvents()
					IL_1CA:
					num = 35
					layer2.Visible = False
					IL_1D5:
					num = 36
					Thread.Sleep(120)
					IL_1E0:
					num = 37
					Application.DoEvents()
					IL_1E9:
					num = 38
				Next
				IL_1F6:
				num = 39
				Thread.Sleep(200)
				IL_204:
				num = 40
				feature = Nothing
				IL_20A:
				ProjectData.ClearProjectError()
				num3 = 1
				IL_212:
				num = 42
				m_Map.Layers.Remove("tempAnimate")
				IL_226:
				GoTo IL_37A
				IL_22B:
				num = 45
				Interaction.MsgBox("Khong tim thay.", MsgBoxStyle.OkOnly, Nothing)
				IL_23C:
				num = 46
				ProjectData.ClearProjectError()
				If num4 <> 0 Then
					GoTo IL_254
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_254:
				num4 = 0
				IL_257:
				IL_259:
				GoTo IL_37A
				IL_262:
				Dim arg_269_0 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_269_0)
				IL_332:
				GoTo IL_36F
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_34B:
				GoTo IL_36F
			End Try
			Dim arg_34D_0 As Object
			endfilter(TypeOf arg_34D_0 Is Exception And num3 <> 0 And num4 = 0)
			IL_36F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_37A:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Shared Sub NhapNhayFeature(m_Map As AxMap, pObj As Feature, pSoLan As Integer)
			Dim num3 As Integer
			Dim num4 As Integer
			Try
				IL_00:
				Dim num As Integer = 1
				Dim feature As Feature = New FeatureClass()
				IL_09:
				num = 2
				Dim style As Style = New StyleClass()
				IL_13:
				num = 3
				Dim style2 As Style = New StyleClass()
				IL_1D:
				num = 4
				Dim num2 As UInteger = 0UI
				IL_28:
				ProjectData.ClearProjectError()
				num3 = 2
				IL_30:
				num = 6
				Dim layer As Layer = m_Map.Layers.CreateLayer("tempAnimate", Missing.Value, 1, Missing.Value, Missing.Value)
				IL_59:
				num = 7
				m_Map.Layers.AnimationLayer = layer
				IL_68:
				num = 8
				style.SymbolFont.Name = "MapInfo Cartographic"
				IL_7C:
				num = 9
				style.SymbolFont.Size = New Decimal(18L)
				IL_94:
				num = 10
				style.SymbolCharacter = 72S
				IL_A1:
				num = 11
				style.SymbolFontColor = UInteger.Parse(Conversions.ToString(16711935))
				IL_BB:
				num = 12
				style2.SymbolFont.Name = "MapInfo Cartographic"
				IL_D0:
				num = 13
				style2.SymbolFont.Size = New Decimal(18L)
				IL_E8:
				num = 14
				style2.SymbolCharacter = 72S
				IL_F5:
				num = 15
				style2.SymbolFontColor = UInteger.Parse(Conversions.ToString(16777215))
				IL_10F:
				num = 16
				Dim point As MapXLib.Point = New PointClass()
				IL_11A:
				num = 17
				point.[Set](pObj.Point.X, pObj.Point.Y)
				IL_13B:
				num = 18
				Dim feature2 As Feature = layer.AddFeature(m_Map.FeatureFactory.CreateSymbol(point, style), Missing.Value)
				IL_15B:
				num = 19
				' The following expression was wrapped in a checked-statement
				For i As Integer = 1 To pSoLan
					IL_166:
					num = 20
					Thread.Sleep(40)
					IL_171:
					num = 21
					Application.DoEvents()
					IL_17A:
					num = 22
					feature2.Style = style
					IL_187:
					num = 23
					layer.UpdateFeature(feature2, feature2, Missing.Value)
					IL_19A:
					num = 24
					Thread.Sleep(40)
					IL_1A5:
					num = 25
					Application.DoEvents()
					IL_1AE:
					num = 26
					feature2.Style = style2
					IL_1BB:
					num = 27
					layer.UpdateFeature(feature2, feature2, Missing.Value)
					IL_1CE:
					num = 28
				Next
				IL_1DB:
				num = 29
				style = Nothing
				IL_1E2:
				num = 30
				style2 = Nothing
				IL_1E9:
				num = 31
				IL_1EF:
				num = 32
				feature2 = Nothing
				IL_1F6:
				ProjectData.ClearProjectError()
				num3 = 1
				IL_1FE:
				num = 34
				m_Map.Layers.Remove("tempAnimate")
				IL_212:
				GoTo IL_32D
				IL_217:
				num = 36
				ProjectData.ClearProjectError()
				If num4 <> 0 Then
					GoTo IL_22F
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_22F:
				num4 = 0
				IL_232:
				IL_234:
				GoTo IL_32D
				IL_23D:
				Dim arg_244_0 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_244_0)
				IL_2E5:
				GoTo IL_322
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2FE:
				GoTo IL_322
			End Try
			Dim arg_300_0 As Object
			endfilter(TypeOf arg_300_0 Is Exception And num3 <> 0 And num4 = 0)
			IL_322:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_32D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub
	End Class
End Namespace
