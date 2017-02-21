Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Xml

Namespace BdTC
	Friend Module modBanDo
		Public Structure UNDOITEM
			Public UndoSymbols As CSymbols

			Public MapX As Double

			Public MapY As Double

			Public SeleSymbol As CSymbol
		End Structure

		Public Structure INTERSECTNODE
			Public PT As PointF

			Public NodeIndex As Integer
		End Structure

		Public Structure EDITNODE
			Public r As Rectangle

			Public iPart As Integer

			Public iNode As Integer
		End Structure

		Public cDecSepa As Char = Conversions.ToChar(Application.CurrentCulture.NumberFormat.NumberDecimalSeparator)

		Public cGrpSepa As Char = Conversions.ToChar(Application.CurrentCulture.NumberFormat.NumberGroupSeparator)

		Public EditNodes As modBanDo.EDITNODE()

		Public EditNodesCount As Integer

		Public iEditNode As Integer

		Public Const myToolInfo As Integer = 3

		Public Const NHAPNHAYDELAY As Integer = 100

		Public myDefaFileName As String = "Defas.def"

		Public myNewBdTC As String = "New.bdtc"

		Public LastBdTC As String = "New.bdtc"

		Public myTyLeKH2Map As Single = 1F

		Public mySoPixelsPer1000m As Integer = 312

		Public myTyLeLayKH As Single = 1F

		Public myDaLayKH As Boolean = False

		Public myKHQSMWidth As Integer = 1436

		Public myKHQSZoom As Integer = 3357

		Public myTinhChinhGocQuay As Double = 0.5

		Public fCacKyHieu As dlgCacKyHieu

		Public myTextureFile As String = "LongThanh.jpg"

		Public myGridDataFile As String = "GridData.txt"

		Public myGRID_WIDTH As Integer = 101

		Public myGRID_HEIGHT As Integer = 119

		Public mySCALE_FACTOR As Single = 2F

		Public myFlag3DsFile As String = "Flag3Ds.xml"

		Public myResourcePath As String

		Public mySaBanDir As String = "SaBan1"

		Public mySaBanDefFileName As String = "LastSaBan.def"

		Public myCacKyHieuUDL As String = "KHData.udl"

		Public myLoaiKH_ID As Long = 0L

		Public MyOtherLineStyle As COtherLineStyle

		Public BDTyLeBanDo As Integer = 100000

		Public BDKinhDo As Double = 104.255

		Public BDViDo As Double = 17.0

		Public BDZoomLevel As Double = 4000.0

		Public DanhDauColor As Color = Color.FromArgb(75, Color.Red)

		Public DanhDauColor2 As Color = Color.FromArgb(75, Color.Black)

		Public VeBoundColor As Color = Color.FromKnownColor(KnownColor.HotTrack)

		Public defaUndosNo As Integer = 10

		Public stackUnDos As modBanDo.UNDOITEM()

		Public stackReDos As modBanDo.UNDOITEM()

		Public MaxStyle As Integer = 8

		Public ADStyles As Integer()

		Public defaMyLineStyle As Integer = 0

		Public QuanDoColor As Color = Color.Red

		Public QuanXanhColor As Color = Color.Blue

		Public myColor As Color() = New Color(31) {}

		Public defaGenPen1W As Integer = 1

		Public defaGenPen1C As Color = Color.Red

		Public defaGenPen2W As Integer = 0

		Public defaGenPen2C As Color = Color.Yellow

		Public defaGenFill As Boolean = False

		Public defaGenFillC As Color = Color.Red

		Public defaGenLineStyle As Integer = 0

		Public defaSongSongSize As Integer = 6

		Public defaSongSongLinesNo As Integer = 2

		Public defaSongSongPen1W As Integer = 1

		Public defaSongSongPen1C As Color = Color.Red

		Public defaSongSongPen2W As Integer = 0

		Public defaSongSongPen2C As Color = Color.Yellow

		Public defaSongSongLineStyle As Integer = 0

		Public myMuiTenDoRong As Single = 30F

		Public defaMuiTenDoRong As Single = 30F

		Public defaMuiTenPen1W As Integer = 1

		Public defaMuiTenPen1C As Color = Color.Red

		Public defaMuiTenPen2W As Integer = 0

		Public defaMuiTenPen2C As Color = Color.Yellow

		Public defaMuiTenFill As Boolean = True

		Public defaMuiTenFillC As Color = Color.FromArgb(100, Color.Red)

		Public defaMuiTenDacDoRong As Single = 6F

		Public defaMuiTenDacPen1W As Integer = 1

		Public defaMuiTenDacPen1C As Color = Color.Red

		Public defaMuiTenDacPen2W As Integer = 0

		Public defaMuiTenDacPen2C As Color = Color.Yellow

		Public defaMuiTenDacFill As Boolean = True

		Public defaMuiTenDacFillC As Color = Color.FromArgb(255, Color.Red)

		Public defaMuiTenDacDoDai As Single = 100F

		Public defaPiePen1W As Integer = 1

		Public defaPiePen1C As Color = Color.Red

		Public defaPiePen2W As Integer = 0

		Public defaPiePen2C As Color = Color.Yellow

		Public defaPieFill As Boolean = True

		Public defaPieFillC As Color = Color.FromArgb(100, Color.Red)

		Public defaPieArc As Boolean = False

		Public defaPieStartA As Integer = 0

		Public defaPieSweepA As Integer = 90

		Public defaTableColsNo As Integer = 2

		Public defaTableRowsNo As Integer = 8

		Public defaTableBorderW As Integer = 1

		Public defaTableBorderC As Color = Color.Blue

		Public defaTableLineW As Integer = 1

		Public defaTableLineC As Color = Color.Gray

		Public defaTableFillC As Color = Color.FromArgb(100, Color.LightYellow)

		Public defaTableTFont As Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point)

		Public defaTableTFontName As String = "Tahoma"

		Public defaTableTFontSize As Single = 10F

		Public defaTableTFontStyle As Integer = 0

		Public defaTableTextC As Color = Color.Black

		Public defaTextFont As Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point)

		Public defaTextFontName As String = "Tahoma"

		Public defaTextFontSize As Single = 10F

		Public defaTextFontStyle As Single = 0F

		Public defaTextC As Color = Color.Red

		Public defaImageWidth As Integer = 80

		Public defaImageHeight As Integer = 40

		Public defaHorizontalSpacing As Integer = 10

		Public defaVerticalSpacing As Integer = 32

		Public myMap1X As Double = 106.941953898199

		Public myMap1Y As Double = 10.844428647015

		Public mySurf1X As Double = 0.0

		Public mySurf1Y As Double = 0.0

		Public myMap2X As Double = 107.00178

		Public myMap2Y As Double = 10.77494

		Public mySurf2X As Double = 2047.0

		Public mySurf2Y As Double = 2405.0

		Public my3DSoPixelsPer1000m As Integer = 312

		Public Function GetSurfPosition(pMapX As Double, pMapY As Double) As PointF
			Dim kq As PointF = New PointF(0F, 0F)
			Dim mdX As Double = (pMapX - modBanDo.myMap1X) * (modBanDo.mySurf2X - modBanDo.mySurf1X) / (modBanDo.myMap2X - modBanDo.myMap1X) + modBanDo.mySurf1X
			Dim mdY As Double = (modBanDo.myMap1Y - pMapY) * (modBanDo.mySurf2Y - modBanDo.mySurf1Y) / (modBanDo.myMap1Y - modBanDo.myMap2Y) + modBanDo.mySurf1Y
			kq.X = CSng(mdX)
			kq.Y = CSng(mdY)
			Return kq
		End Function

		Private Function GetIntersectPoint(PT1 As PointF, PT2 As PointF, PT3 As PointF, PT4 As PointF) As Object
			Dim mPT As PointF = Nothing
			Dim flag As Boolean = PT2.X = PT1.X
			If flag Then
				PT2.X += 1F
			End If
			Dim mPath As GraphicsPath = New GraphicsPath()
			mPath.AddLine(PT1, PT2)
			Dim mPath2 As GraphicsPath = New GraphicsPath()
			mPath2.AddLine(PT3, PT4)
			mPT = COtherLineStyle.GiaoDiem(PT1, PT2, PT3, PT4)
			flag = mPath.IsOutlineVisible(mPT, New Pen(Color.Black, 2F))
			Dim GetIntersectPoint As Object
			If flag Then
				Dim flag2 As Boolean = mPath2.IsOutlineVisible(mPT, New Pen(Color.Black, 2F))
				If flag2 Then
					GetIntersectPoint = mPT
				Else
					GetIntersectPoint = Nothing
				End If
			Else
				GetIntersectPoint = Nothing
			End If
			Return GetIntersectPoint
		End Function

		Private Function GetIntersectPoint(PT1 As PointF, PT2 As PointF, PTs As PointF(), index As Integer) As Object
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = PTs.GetUpperBound(0) >= index + 1
			Dim GetIntersectPoint As Object
			If flag Then
				Dim num As Integer = PTs.GetUpperBound(0) - 1
				Dim i As Integer = index
				Dim mPT As Object
				While True
					Dim arg_9B_0 As Integer = i
					Dim num2 As Integer = num
					If arg_9B_0 > num2 Then
						GoTo Block_4
					End If
					mPT = RuntimeHelpers.GetObjectValue(modBanDo.GetIntersectPoint(PT1, PT2, PTs(i), PTs(i + 1)))
					flag = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(mPT))
					If flag Then
						Exit While
					End If
					i += 1
				End While
				Dim expr_66 As Object = mPT
				Dim mINTERSECTNODE As modBanDo.INTERSECTNODE
				Dim pointF As PointF
				mINTERSECTNODE.PT = (If((expr_66 IsNot Nothing), (CType(expr_66, PointF)), pointF))
				mINTERSECTNODE.NodeIndex = i
				GetIntersectPoint = mINTERSECTNODE
				Return GetIntersectPoint
				Block_4:
				GetIntersectPoint = Nothing
			Else
				GetIntersectPoint = Nothing
			End If
			Return GetIntersectPoint
		End Function

		Public Function GetIntersectPoints(PT1 As PointF, PT2 As PointF, PTs As PointF()) As modBanDo.INTERSECTNODE()
			Dim i As Integer = -1
			Dim mINTERSECTNODEs As modBanDo.INTERSECTNODE() = New modBanDo.INTERSECTNODE(-1) {}
			' The following expression was wrapped in a checked-statement
			For j As Integer = 0 To PTs.GetUpperBound(0)
				Dim mINTERSECTNODE As Object = RuntimeHelpers.GetObjectValue(modBanDo.GetIntersectPoint(PT1, PT2, PTs, j))
				Dim flag As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(mINTERSECTNODE))
				If Not flag Then
					Exit For
				End If
				i += 1
				mINTERSECTNODEs = CType(Utils.CopyArray(CType(mINTERSECTNODEs, Array), New modBanDo.INTERSECTNODE(i + 1 - 1) {}), modBanDo.INTERSECTNODE())
				Dim arg_6C_0_cp_0 As modBanDo.INTERSECTNODE() = mINTERSECTNODEs
				Dim arg_6C_0_cp_1 As Integer = i
				Dim expr_5A As Object = mINTERSECTNODE
				Dim iNTERSECTNODE As modBanDo.INTERSECTNODE
				arg_6C_0_cp_0(arg_6C_0_cp_1) = (If((expr_5A IsNot Nothing), (CType(expr_5A, modBanDo.INTERSECTNODE)), iNTERSECTNODE))
			Next
			Return mINTERSECTNODEs
		End Function

		Public Function AngleToPoint(Origin As PointF, Target As PointF) As Single
			Target.X -= Origin.X
			Target.Y -= Origin.Y
			Return CSng((Math.Atan2(CDec(Target.Y), CDec(Target.X)) / 0.017453292519943295))
		End Function

		Public Function ObjToCurve(pObj As GraphicObject) As GraphicObject
			Dim gObj As GraphicObject = Nothing
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean
			Select Case pObj.GetObjType()
				Case OBJECTTYPE.Polygon, OBJECTTYPE.ClosedCurve
					Dim mObj As ShapeGraphic = CType(pObj, ShapeGraphic)
					Dim mPath As GraphicsPath = mObj.GetPath()
					mPath.Flatten(New Matrix(), 0.5F)
					Dim pPts As PointF() = mPath.PathPoints
					gObj = New ClosedCurveGraphic(pPts, 1F, Color.Red) With { .Rotation = 0F, .LineColor = mObj.LineColor, .LineWidth = mObj.LineWidth, .Line2Color = mObj.Line2Color, .Line2Width = mObj.Line2Width, .Fill = mObj.Fill, .FillColor = mObj.FillColor, .LineStyle = mObj.LineStyle }
				Case OBJECTTYPE.Line, OBJECTTYPE.Curve
					Dim mObj2 As ShapeGraphic = CType(pObj, ShapeGraphic)
					Dim mPath2 As GraphicsPath = mObj2.GetPath()
					mPath2.Flatten(New Matrix(), 0.5F)
					Dim pPts2 As PointF() = mPath2.PathPoints
					gObj = New CurveGraphic(pPts2, 1F, Color.Red) With { .Rotation = 0F, .LineColor = mObj2.LineColor, .LineWidth = mObj2.LineWidth, .Line2Color = mObj2.Line2Color, .Line2Width = mObj2.Line2Width, .Fill = mObj2.Fill, .FillColor = mObj2.FillColor, .LineStyle = mObj2.LineStyle }
				Case OBJECTTYPE.Cycle, OBJECTTYPE.Ellipse
					Dim mObj3 As ShapeGraphic = CType(pObj, ShapeGraphic)
					Dim mPath3 As GraphicsPath = mObj3.GetPath()
					mPath3.Flatten(New Matrix(), 0.5F)
					Dim pPts3 As PointF() = mPath3.PathPoints
					Dim i As Integer = pPts3.GetUpperBound(0)
					pPts3 = CType(Utils.CopyArray(CType(pPts3, Array), New PointF(i - 1 + 1 - 1) {}), PointF())
					gObj = New ClosedCurveGraphic(pPts3, 1F, Color.Red) With { .Rotation = 0F, .LineColor = mObj3.LineColor, .LineWidth = mObj3.LineWidth, .Line2Color = mObj3.Line2Color, .Line2Width = mObj3.Line2Width, .Fill = mObj3.Fill, .LineStyle = mObj3.LineStyle, .FillColor = mObj3.FillColor }
				Case OBJECTTYPE.Pie
					Dim mObj4 As PieGraphic = CType(pObj, PieGraphic)
					Dim mPath4 As GraphicsPath = mObj4.GetPath()
					mPath4.Flatten(New Matrix(), 0.5F)
					Dim pPts4 As PointF() = mPath4.PathPoints
					flag = mObj4.IsArc
					If flag Then
						gObj = New CurveGraphic(pPts4, 1F, Color.Red) With { .Rotation = 0F, .LineColor = mObj4.LineColor, .LineWidth = mObj4.LineWidth, .Line2Color = mObj4.Line2Color, .Line2Width = mObj4.Line2Width, .Fill = mObj4.Fill, .FillColor = mObj4.FillColor, .LineStyle = mObj4.LineStyle }
					Else
						gObj = New ClosedCurveGraphic(pPts4, 1F, Color.Red) With { .Rotation = 0F, .LineColor = mObj4.LineColor, .LineWidth = mObj4.LineWidth, .Line2Color = mObj4.Line2Color, .Line2Width = mObj4.Line2Width, .Fill = mObj4.Fill, .FillColor = mObj4.FillColor, .LineStyle = mObj4.LineStyle }
					End If
			End Select
			flag = (gObj IsNot Nothing)
			Dim ObjToCurve As GraphicObject
			If flag Then
				Dim gObj2 As NodesShapeGraphic = CType(gObj, NodesShapeGraphic)
				Dim arg_421_0 As Integer = 0
				Dim num As Integer = gObj2.Nodes.Count - 1
				Dim j As Integer = arg_421_0
				While True
					Dim arg_449_0 As Integer = j
					Dim num2 As Integer = num
					If arg_449_0 > num2 Then
						Exit While
					End If
					gObj2.Nodes(j).IsControl = True
					j += 1
				End While
				ObjToCurve = gObj2
			Else
				ObjToCurve = pObj
			End If
			Return ObjToCurve
		End Function

		Public Sub LoadDefa(pFileName As String)
			Try
				Dim rr As XmlTextReader = New XmlTextReader(pFileName)
				modBanDo.XML2Defa(rr)
				rr.Close()
				modBanDo.defaTableTFont = New Font(modBanDo.defaTableTFontName, modBanDo.defaTableTFontSize, CType(modBanDo.defaTableTFontStyle, FontStyle), GraphicsUnit.Point)
				' The following expression was wrapped in a checked-expression
				modBanDo.defaTextFont = New Font(modBanDo.defaTextFontName, modBanDo.defaTextFontSize, CType(Math.Round(CDec(modBanDo.defaTextFontStyle)), FontStyle), GraphicsUnit.Point)
			Catch expr_54 As Exception
				ProjectData.SetProjectError(expr_54)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub XML2Defa(rr As XmlTextReader)
			' The following expression was wrapped in a checked-statement
			Try
				While rr.Read()
					Dim oNodeType As XmlNodeType = rr.NodeType
					Dim xmlNodeType As XmlNodeType = oNodeType
					Dim flag As Boolean = xmlNodeType = XmlNodeType.Element
					If flag Then
						Dim name As String = rr.Name
						Dim flag2 As Boolean = Operators.CompareString(name, "DEFAS", False) = 0
						If flag2 Then
							Dim flag3 As Boolean = rr.AttributeCount > 0
							If flag3 Then
								While rr.MoveToNextAttribute()
									Dim name2 As String = rr.Name
									Dim flag4 As Boolean = Operators.CompareString(name2, "QuanDoColor", False) = 0
									If flag4 Then
										modBanDo.QuanDoColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
									Else
										flag4 = (Operators.CompareString(name2, "QuanXanhColor", False) = 0)
										If flag4 Then
											modBanDo.QuanXanhColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
										Else
											flag4 = (Operators.CompareString(name2, "defaGenPen1W", False) = 0)
											If flag4 Then
												modBanDo.defaGenPen1W = Conversions.ToInteger(Conversion.Int(rr.Value))
											Else
												flag4 = (Operators.CompareString(name2, "defaGenPen1C", False) = 0)
												If flag4 Then
													modBanDo.defaGenPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
												Else
													flag4 = (Operators.CompareString(name2, "defaGenPen2W", False) = 0)
													If flag4 Then
														modBanDo.defaGenPen2W = Conversions.ToInteger(rr.Value)
													Else
														flag4 = (Operators.CompareString(name2, "defaGenPen2C", False) = 0)
														If flag4 Then
															modBanDo.defaGenPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
														Else
															flag4 = (Operators.CompareString(name2, "defaGenFill", False) = 0)
															If flag4 Then
																modBanDo.defaGenFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
															Else
																flag4 = (Operators.CompareString(name2, "defaGenFillC", False) = 0)
																If flag4 Then
																	modBanDo.defaGenFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																Else
																	flag4 = (Operators.CompareString(name2, "defaGenLineStyle", False) = 0)
																	If flag4 Then
																		modBanDo.defaGenLineStyle = Conversions.ToInteger(rr.Value)
																	Else
																		flag4 = (Operators.CompareString(name2, "defaSongSongSize", False) = 0)
																		If flag4 Then
																			modBanDo.defaSongSongSize = Conversions.ToInteger(rr.Value)
																		Else
																			flag4 = (Operators.CompareString(name2, "defaSongSongLinesNo", False) = 0)
																			If flag4 Then
																				modBanDo.defaSongSongLinesNo = Conversions.ToInteger(rr.Value)
																			Else
																				flag4 = (Operators.CompareString(name2, "defaSongSongPen1W", False) = 0)
																				If flag4 Then
																					modBanDo.defaSongSongPen1W = Conversions.ToInteger(rr.Value)
																				Else
																					flag4 = (Operators.CompareString(name2, "defaSongSongPen1C", False) = 0)
																					If flag4 Then
																						modBanDo.defaSongSongPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
																					Else
																						flag4 = (Operators.CompareString(name2, "defaSongSongPen2W", False) = 0)
																						If flag4 Then
																							modBanDo.defaSongSongPen2W = Conversions.ToInteger(rr.Value)
																						Else
																							flag4 = (Operators.CompareString(name2, "defaSongSongPen2C", False) = 0)
																							If flag4 Then
																								modBanDo.defaSongSongPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
																							Else
																								flag4 = (Operators.CompareString(name2, "defaSongSongLineStyle", False) = 0)
																								If flag4 Then
																									modBanDo.defaSongSongLineStyle = Conversions.ToInteger(rr.Value)
																								Else
																									flag4 = (Operators.CompareString(name2, "defaMuiTenDoRong", False) = 0)
																									If flag4 Then
																										modBanDo.defaMuiTenDoRong = Conversions.ToSingle(rr.Value)
																									Else
																										flag4 = (Operators.CompareString(name2, "defaMuiTenPen1W", False) = 0)
																										If flag4 Then
																											modBanDo.defaMuiTenPen1W = Conversions.ToInteger(rr.Value)
																										Else
																											flag4 = (Operators.CompareString(name2, "defaMuiTenPen1C", False) = 0)
																											If flag4 Then
																												modBanDo.defaMuiTenPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
																											Else
																												flag4 = (Operators.CompareString(name2, "defaMuiTenPen2W", False) = 0)
																												If flag4 Then
																													modBanDo.defaMuiTenPen2W = Conversions.ToInteger(rr.Value)
																												Else
																													flag4 = (Operators.CompareString(name2, "defaMuiTenPen2C", False) = 0)
																													If flag4 Then
																														modBanDo.defaMuiTenPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
																													Else
																														flag4 = (Operators.CompareString(name2, "defaMuiTenFill", False) = 0)
																														If flag4 Then
																															modBanDo.defaMuiTenFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
																														Else
																															flag4 = (Operators.CompareString(name2, "defaMuiTenFillC", False) = 0)
																															If flag4 Then
																																modBanDo.defaMuiTenFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																															Else
																																flag4 = (Operators.CompareString(name2, "defaMuiTenDacDoDai", False) = 0)
																																If flag4 Then
																																	modBanDo.defaMuiTenDacDoDai = Conversions.ToSingle(rr.Value)
																																Else
																																	flag4 = (Operators.CompareString(name2, "defaMuiTenDacDoRong", False) = 0)
																																	If flag4 Then
																																		modBanDo.defaMuiTenDacDoRong = Conversions.ToSingle(rr.Value)
																																	Else
																																		flag4 = (Operators.CompareString(name2, "defaMuiTenDacPen1W", False) = 0)
																																		If flag4 Then
																																			modBanDo.defaMuiTenDacPen1W = Conversions.ToInteger(rr.Value)
																																		Else
																																			flag4 = (Operators.CompareString(name2, "defaMuiTenDacPen1C", False) = 0)
																																			If flag4 Then
																																				modBanDo.defaMuiTenDacPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																			Else
																																				flag4 = (Operators.CompareString(name2, "defaMuiTenDacPen2W", False) = 0)
																																				If flag4 Then
																																					modBanDo.defaMuiTenDacPen2W = Conversions.ToInteger(rr.Value)
																																				Else
																																					flag4 = (Operators.CompareString(name2, "defaMuiTenDacPen2C", False) = 0)
																																					If flag4 Then
																																						modBanDo.defaMuiTenDacPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																					Else
																																						flag4 = (Operators.CompareString(name2, "defaMuiTenDacFill", False) = 0)
																																						If flag4 Then
																																							modBanDo.defaMuiTenDacFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
																																						Else
																																							flag4 = (Operators.CompareString(name2, "defaMuiTenDacFillC", False) = 0)
																																							If flag4 Then
																																								modBanDo.defaMuiTenDacFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																							Else
																																								flag4 = (Operators.CompareString(name2, "defaTableColsNo", False) = 0)
																																								If flag4 Then
																																									modBanDo.defaTableColsNo = Conversions.ToInteger(rr.Value)
																																								Else
																																									flag4 = (Operators.CompareString(name2, "defaTableRowsNo", False) = 0)
																																									If flag4 Then
																																										modBanDo.defaTableRowsNo = Conversions.ToInteger(rr.Value)
																																									Else
																																										flag4 = (Operators.CompareString(name2, "defaTableBorderW", False) = 0)
																																										If flag4 Then
																																											modBanDo.defaTableBorderW = Conversions.ToInteger(rr.Value)
																																										Else
																																											flag4 = (Operators.CompareString(name2, "defaTableBorderC", False) = 0)
																																											If flag4 Then
																																												modBanDo.defaTableBorderC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																											Else
																																												flag4 = (Operators.CompareString(name2, "defaTableLineW", False) = 0)
																																												If flag4 Then
																																													modBanDo.defaTableLineW = Conversions.ToInteger(rr.Value)
																																												Else
																																													flag4 = (Operators.CompareString(name2, "defaTableLineC", False) = 0)
																																													If flag4 Then
																																														modBanDo.defaTableLineC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																													Else
																																														flag4 = (Operators.CompareString(name2, "defaTableFillC", False) = 0)
																																														If flag4 Then
																																															modBanDo.defaTableFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																														Else
																																															flag4 = (Operators.CompareString(name2, "defaTableTFontName", False) = 0)
																																															If flag4 Then
																																																modBanDo.defaTableTFontName = rr.Value
																																															Else
																																																flag4 = (Operators.CompareString(name2, "defaTableTFontSize", False) = 0)
																																																If flag4 Then
																																																	modBanDo.defaTableTFontSize = Conversions.ToSingle(rr.Value)
																																																Else
																																																	flag4 = (Operators.CompareString(name2, "defaTableTFontStyle", False) = 0)
																																																	If flag4 Then
																																																		modBanDo.defaTableTFontStyle = Conversions.ToInteger(rr.Value)
																																																	Else
																																																		flag4 = (Operators.CompareString(name2, "defaTableTextC", False) = 0)
																																																		If flag4 Then
																																																			modBanDo.defaTableTextC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																																		Else
																																																			flag4 = (Operators.CompareString(name2, "defaTextFontName", False) = 0)
																																																			If flag4 Then
																																																				modBanDo.defaTextFontName = rr.Value
																																																			Else
																																																				flag4 = (Operators.CompareString(name2, "defaTextFontSize", False) = 0)
																																																				If flag4 Then
																																																					modBanDo.defaTextFontSize = Conversions.ToSingle(rr.Value)
																																																				Else
																																																					flag4 = (Operators.CompareString(name2, "defaTextFontStyle", False) = 0)
																																																					If flag4 Then
																																																						modBanDo.defaTextFontStyle = Conversions.ToSingle(rr.Value)
																																																					Else
																																																						flag4 = (Operators.CompareString(name2, "defaTextC", False) = 0)
																																																						If flag4 Then
																																																							modBanDo.defaTextC = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																																						Else
																																																							flag4 = (Operators.CompareString(name2, "DanhDauColor", False) = 0)
																																																							If flag4 Then
																																																								modBanDo.DanhDauColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																																							Else
																																																								flag4 = (Operators.CompareString(name2, "DanhDauColor2", False) = 0)
																																																								If flag4 Then
																																																									modBanDo.DanhDauColor2 = Color.FromArgb(Conversions.ToInteger(rr.Value))
																																																								Else
																																																									flag4 = (Operators.CompareString(name2, "VeBoundColor", False) = 0)
																																																									If flag4 Then
																																																										modBanDo.VeBoundColor = Color.FromKnownColor(CType(Conversions.ToInteger(rr.Value), KnownColor))
																																																									Else
																																																										flag4 = (Operators.CompareString(name2, "defaUndosNo", False) = 0)
																																																										If flag4 Then
																																																											modBanDo.defaUndosNo = Conversions.ToInteger(rr.Value)
																																																										Else
																																																											flag4 = (Operators.CompareString(name2, "ColorsTable", False) = 0)
																																																											If flag4 Then
																																																												Dim strColors As String = rr.Value
																																																												Dim data As String() = strColors.Split(New Char() { " "c })
																																																												flag4 = (data.GetUpperBound(0) = 31)
																																																												If flag4 Then
																																																													Dim i As Integer = 0
																																																													Dim arg_A2B_0 As Integer
																																																													Dim num As Integer
																																																													Do
																																																														modBanDo.myColor(i) = Color.FromArgb(Conversions.ToInteger(data(i)))
																																																														i += 1
																																																														arg_A2B_0 = i
																																																														num = 31
																																																													Loop While arg_A2B_0 <= num
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
												End If
											End If
										End If
									End If
								End While
							End If
						End If
					End If
				End While
			Catch expr_A54 As Exception
				ProjectData.SetProjectError(expr_A54)
				Dim e As Exception = expr_A54
				Throw e
			End Try
		End Sub

		Public Sub Defa2File(pFileName As String)
			Dim sw As StreamWriter = New StreamWriter(pFileName)
			Dim wr As XmlTextWriter = New XmlTextWriter(sw)
			modBanDo.Defa2xml(wr)
			wr.Close()
		End Sub

		Private Sub Defa2xml(ByRef wr As XmlTextWriter)
			wr.WriteStartElement("DEFAS")
			wr.WriteAttributeString("QuanDoColor", Conversions.ToString(modBanDo.QuanDoColor.ToArgb()))
			wr.WriteAttributeString("QuanXanhColor", Conversions.ToString(modBanDo.QuanXanhColor.ToArgb()))
			wr.WriteAttributeString("defaGenPen1W", Conversions.ToString(modBanDo.defaGenPen1W))
			wr.WriteAttributeString("defaGenPen1C", Conversions.ToString(modBanDo.defaGenPen1C.ToArgb()))
			wr.WriteAttributeString("defaGenPen2W", Conversions.ToString(modBanDo.defaGenPen2W))
			wr.WriteAttributeString("defaGenPen2C", Conversions.ToString(modBanDo.defaGenPen2C.ToArgb()))
			wr.WriteAttributeString("defaGenFill", modBanDo.defaGenFill.ToString())
			wr.WriteAttributeString("defaGenFillC", Conversions.ToString(modBanDo.defaGenFillC.ToArgb()))
			wr.WriteAttributeString("defaGenLineStyle", Conversions.ToString(modBanDo.defaGenLineStyle))
			wr.WriteAttributeString("defaSongSongSize", Conversions.ToString(modBanDo.defaSongSongSize))
			wr.WriteAttributeString("defaSongSongLinesNo", Conversions.ToString(modBanDo.defaSongSongLinesNo))
			wr.WriteAttributeString("defaSongSongPen1W", Conversions.ToString(modBanDo.defaSongSongPen1W))
			wr.WriteAttributeString("defaSongSongPen1C", Conversions.ToString(modBanDo.defaSongSongPen1C.ToArgb()))
			wr.WriteAttributeString("defaSongSongPen2W", Conversions.ToString(modBanDo.defaSongSongPen2W))
			wr.WriteAttributeString("defaSongSongPen2C", Conversions.ToString(modBanDo.defaSongSongPen2C.ToArgb()))
			wr.WriteAttributeString("defaSongSongLineStyle", Conversions.ToString(modBanDo.defaSongSongLineStyle))
			wr.WriteAttributeString("defaMuiTenDoRong", Conversions.ToString(modBanDo.defaMuiTenDoRong))
			wr.WriteAttributeString("defaMuiTenPen1W", Conversions.ToString(modBanDo.defaMuiTenPen1W))
			wr.WriteAttributeString("defaMuiTenPen1C", Conversions.ToString(modBanDo.defaMuiTenPen1C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenPen2W", Conversions.ToString(modBanDo.defaMuiTenPen2W))
			wr.WriteAttributeString("defaMuiTenPen2C", Conversions.ToString(modBanDo.defaMuiTenPen2C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenFill", modBanDo.defaMuiTenFill.ToString())
			wr.WriteAttributeString("defaMuiTenFillC", Conversions.ToString(modBanDo.defaMuiTenFillC.ToArgb()))
			wr.WriteAttributeString("defaMuiTenDacDoDai", Conversions.ToString(modBanDo.defaMuiTenDacDoDai))
			wr.WriteAttributeString("defaMuiTenDacDoRong", Conversions.ToString(modBanDo.defaMuiTenDacDoRong))
			wr.WriteAttributeString("defaMuiTenDacPen1W", Conversions.ToString(modBanDo.defaMuiTenDacPen1W))
			wr.WriteAttributeString("defaMuiTenDacPen1C", Conversions.ToString(modBanDo.defaMuiTenDacPen1C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenDacPen2W", Conversions.ToString(modBanDo.defaMuiTenDacPen2W))
			wr.WriteAttributeString("defaMuiTenDacPen2C", Conversions.ToString(modBanDo.defaMuiTenDacPen2C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenDacFill", modBanDo.defaMuiTenDacFill.ToString())
			wr.WriteAttributeString("defaMuiTenDacFillC", Conversions.ToString(modBanDo.defaMuiTenDacFillC.ToArgb()))
			wr.WriteAttributeString("defaTableColsNo", Conversions.ToString(modBanDo.defaTableColsNo))
			wr.WriteAttributeString("defaTableRowsNo", Conversions.ToString(modBanDo.defaTableRowsNo))
			wr.WriteAttributeString("defaTableBorderW", Conversions.ToString(modBanDo.defaTableBorderW))
			wr.WriteAttributeString("defaTableBorderC", Conversions.ToString(modBanDo.defaTableBorderC.ToArgb()))
			wr.WriteAttributeString("defaTableLineW", Conversions.ToString(modBanDo.defaTableLineW))
			wr.WriteAttributeString("defaTableLineC", Conversions.ToString(modBanDo.defaTableLineC.ToArgb()))
			wr.WriteAttributeString("defaTableFillC", Conversions.ToString(modBanDo.defaTableFillC.ToArgb()))
			wr.WriteAttributeString("defaTableTFontName", modBanDo.defaTableTFontName)
			wr.WriteAttributeString("defaTableTFontSize", Conversions.ToString(modBanDo.defaTableTFontSize))
			wr.WriteAttributeString("defaTableTFontStyle", Conversions.ToString(modBanDo.defaTableTFontStyle))
			wr.WriteAttributeString("defaTableTextC", Conversions.ToString(modBanDo.defaTableTextC.ToArgb()))
			wr.WriteAttributeString("defaTextFontName", modBanDo.defaTextFontName)
			wr.WriteAttributeString("defaTextFontSize", Conversions.ToString(modBanDo.defaTextFontSize))
			wr.WriteAttributeString("defaTextFontStyle", Conversions.ToString(modBanDo.defaTextFontStyle))
			wr.WriteAttributeString("defaTextC", Conversions.ToString(modBanDo.defaTextC.ToArgb()))
			wr.WriteAttributeString("DanhDauColor", Conversions.ToString(modBanDo.DanhDauColor.ToArgb()))
			wr.WriteAttributeString("DanhDauColor2", Conversions.ToString(modBanDo.DanhDauColor2.ToArgb()))
			wr.WriteAttributeString("VeBoundColor", Conversions.ToString(CInt(modBanDo.VeBoundColor.ToKnownColor())))
			wr.WriteAttributeString("defaUndosNo", Conversions.ToString(modBanDo.defaUndosNo))
			Dim strColors As String = Conversions.ToString(modBanDo.myColor(0).ToArgb())
			Dim i As Integer = 1
			' The following expression was wrapped in a checked-statement
			Dim arg_52E_0 As Integer
			Dim num As Integer
			Do
				strColors = strColors + " " + Conversions.ToString(modBanDo.myColor(i).ToArgb())
				i += 1
				arg_52E_0 = i
				num = 31
			Loop While arg_52E_0 <= num
			wr.WriteAttributeString("ColorsTable", strColors)
			wr.WriteEndElement()
		End Sub

		Public Function GetMauGoc(pColor As Color) As Color
			Dim MyDialog As ColorDialog = New ColorDialog()
			MyDialog.AllowFullOpen = True
			MyDialog.ShowHelp = True
			MyDialog.Color = pColor
			Dim flag As Boolean = MyDialog.ShowDialog() = DialogResult.OK
			Dim GetMauGoc As Color
			If flag Then
				GetMauGoc = MyDialog.Color
			Else
				GetMauGoc = pColor
			End If
			Return GetMauGoc
		End Function

		Public Function GetMau(pColor As Color) As Color
			Dim MyDialog As dlgGetColor = New dlgGetColor()
			MyDialog.SeleColor = pColor
			MyDialog.TopMost = True
			Dim flag As Boolean = MyDialog.ShowDialog() = DialogResult.OK
			Dim GetMau As Color
			If flag Then
				GetMau = MyDialog.SeleColor
			Else
				GetMau = pColor
			End If
			Return GetMau
		End Function
	End Module
End Namespace
