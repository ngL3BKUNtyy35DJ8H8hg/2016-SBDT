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

Namespace SaBan
	Friend Module modBdTC
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

		Public cDecSepa As Char = Conversions.ToChar(Application.CurrentCulture.NumberFormat.NumberDecimalSeparator)

		Public cGrpSepa As Char = Conversions.ToChar(Application.CurrentCulture.NumberFormat.NumberGroupSeparator)

		Public fCacKyHieu As dlgCacKyHieu

		Public fDefBDTC As dlgDefBdTC

		Public fChonTyleKH As dlgChonTyLeKH

		Public BDTyLeLayKH As Integer = 100

		Public myTyLeKH2Map As Single = 1F

		Public myLoaiKH_ID As Long = 0L

		Public MyOtherLineStyle As COtherLineStyle

		Public DanhDauColor As Color = Color.FromArgb(75, Color.Red)

		Public DanhDauColor2 As Color = Color.FromArgb(75, Color.Black)

		Public VeBoundColor As Color = Color.FromKnownColor(KnownColor.HotTrack)

		Public defaUndosNo As Integer = 10

		Public stackUnDos As modBdTC.UNDOITEM()

		Public stackReDos As modBdTC.UNDOITEM()

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

		Public myNewBdTC As String = "New.bdtc"

		Public myDefaFileName As String = "Defas.def"

		Public myKHCnnString As String = ""

		Public myTinhChinhGocQuay As Double = 0.5

		Public Function GetDouble(str1 As String) As Double
			Dim value As String = str1.Replace(modBdTC.cGrpSepa, modBdTC.cDecSepa)
			Return Conversions.ToDouble(value)
		End Function

		Public Function GetSingle(str1 As String) As Single
			Dim value As String = str1.Replace(modBdTC.cGrpSepa, modBdTC.cDecSepa)
			Return Conversions.ToSingle(value)
		End Function

		Public Sub LoadDefa(pFileName As String)
			Try
				Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
				modBdTC.XML2Defa(xmlTextReader)
				xmlTextReader.Close()
				modBdTC.defaTableTFont = New Font(modBdTC.defaTableTFontName, modBdTC.defaTableTFontSize, CType(modBdTC.defaTableTFontStyle, FontStyle), GraphicsUnit.Point)
				' The following expression was wrapped in a checked-expression
				modBdTC.defaTextFont = New Font(modBdTC.defaTextFontName, modBdTC.defaTextFontSize, CType(Math.Round(CDec(modBdTC.defaTextFontStyle)), FontStyle), GraphicsUnit.Point)
			Catch expr_50 As Exception
				ProjectData.SetProjectError(expr_50)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub XML2Defa(rr As XmlTextReader)
			' The following expression was wrapped in a checked-statement
			Try
				While rr.Read()
					Dim nodeType As XmlNodeType = rr.NodeType
					Dim xmlNodeType As XmlNodeType = nodeType
					If xmlNodeType = XmlNodeType.Element Then
						Dim name As String = rr.Name
						If Operators.CompareString(name, "DEFAS", False) = 0 AndAlso rr.AttributeCount > 0 Then
							While rr.MoveToNextAttribute()
								Dim name2 As String = rr.Name
								If Operators.CompareString(name2, "QuanDoColor", False) = 0 Then
									modBdTC.QuanDoColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "QuanXanhColor", False) = 0 Then
									modBdTC.QuanXanhColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaGenPen1W", False) = 0 Then
									modBdTC.defaGenPen1W = Conversions.ToInteger(Conversion.Int(rr.Value))
								Else If Operators.CompareString(name2, "defaGenPen1C", False) = 0 Then
									modBdTC.defaGenPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaGenPen2W", False) = 0 Then
									modBdTC.defaGenPen2W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaGenPen2C", False) = 0 Then
									modBdTC.defaGenPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaGenFill", False) = 0 Then
									modBdTC.defaGenFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
								Else If Operators.CompareString(name2, "defaGenFillC", False) = 0 Then
									modBdTC.defaGenFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaGenLineStyle", False) = 0 Then
									modBdTC.defaGenLineStyle = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaSongSongSize", False) = 0 Then
									modBdTC.defaSongSongSize = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaSongSongLinesNo", False) = 0 Then
									modBdTC.defaSongSongLinesNo = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaSongSongPen1W", False) = 0 Then
									modBdTC.defaSongSongPen1W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaSongSongPen1C", False) = 0 Then
									modBdTC.defaSongSongPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaSongSongPen2W", False) = 0 Then
									modBdTC.defaSongSongPen2W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaSongSongPen2C", False) = 0 Then
									modBdTC.defaSongSongPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaSongSongLineStyle", False) = 0 Then
									modBdTC.defaSongSongLineStyle = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenDoRong", False) = 0 Then
									modBdTC.defaMuiTenDoRong = Conversions.ToSingle(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenPen1W", False) = 0 Then
									modBdTC.defaMuiTenPen1W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenPen1C", False) = 0 Then
									modBdTC.defaMuiTenPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaMuiTenPen2W", False) = 0 Then
									modBdTC.defaMuiTenPen2W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenPen2C", False) = 0 Then
									modBdTC.defaMuiTenPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaMuiTenFill", False) = 0 Then
									modBdTC.defaMuiTenFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
								Else If Operators.CompareString(name2, "defaMuiTenFillC", False) = 0 Then
									modBdTC.defaMuiTenFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaMuiTenDacDoDai", False) = 0 Then
									modBdTC.defaMuiTenDacDoDai = Conversions.ToSingle(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenDacDoRong", False) = 0 Then
									modBdTC.defaMuiTenDacDoRong = Conversions.ToSingle(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenDacPen1W", False) = 0 Then
									modBdTC.defaMuiTenDacPen1W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenDacPen1C", False) = 0 Then
									modBdTC.defaMuiTenDacPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaMuiTenDacPen2W", False) = 0 Then
									modBdTC.defaMuiTenDacPen2W = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaMuiTenDacPen2C", False) = 0 Then
									modBdTC.defaMuiTenDacPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaMuiTenDacFill", False) = 0 Then
									modBdTC.defaMuiTenDacFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
								Else If Operators.CompareString(name2, "defaMuiTenDacFillC", False) = 0 Then
									modBdTC.defaMuiTenDacFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaTableColsNo", False) = 0 Then
									modBdTC.defaTableColsNo = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaTableRowsNo", False) = 0 Then
									modBdTC.defaTableRowsNo = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaTableBorderW", False) = 0 Then
									modBdTC.defaTableBorderW = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaTableBorderC", False) = 0 Then
									modBdTC.defaTableBorderC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaTableLineW", False) = 0 Then
									modBdTC.defaTableLineW = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaTableLineC", False) = 0 Then
									modBdTC.defaTableLineC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaTableFillC", False) = 0 Then
									modBdTC.defaTableFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaTableTFontName", False) = 0 Then
									modBdTC.defaTableTFontName = rr.Value
								Else If Operators.CompareString(name2, "defaTableTFontSize", False) = 0 Then
									modBdTC.defaTableTFontSize = Conversions.ToSingle(rr.Value)
								Else If Operators.CompareString(name2, "defaTableTFontStyle", False) = 0 Then
									modBdTC.defaTableTFontStyle = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "defaTableTextC", False) = 0 Then
									modBdTC.defaTableTextC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "defaTextFontName", False) = 0 Then
									modBdTC.defaTextFontName = rr.Value
								Else If Operators.CompareString(name2, "defaTextFontSize", False) = 0 Then
									modBdTC.defaTextFontSize = Conversions.ToSingle(rr.Value)
								Else If Operators.CompareString(name2, "defaTextFontStyle", False) = 0 Then
									modBdTC.defaTextFontStyle = Conversions.ToSingle(rr.Value)
								Else If Operators.CompareString(name2, "defaTextC", False) = 0 Then
									modBdTC.defaTextC = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "DanhDauColor", False) = 0 Then
									modBdTC.DanhDauColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "DanhDauColor2", False) = 0 Then
									modBdTC.DanhDauColor2 = Color.FromArgb(Conversions.ToInteger(rr.Value))
								Else If Operators.CompareString(name2, "VeBoundColor", False) = 0 Then
									modBdTC.VeBoundColor = Color.FromKnownColor(CType(Conversions.ToInteger(rr.Value), KnownColor))
								Else If Operators.CompareString(name2, "defaUndosNo", False) = 0 Then
									modBdTC.defaUndosNo = Conversions.ToInteger(rr.Value)
								Else If Operators.CompareString(name2, "ColorsTable", False) = 0 Then
									Dim value As String = rr.Value
									Dim array As String() = value.Split(New Char() { " "c })
									If array.GetUpperBound(0) = 31 Then
										Dim num As Integer = 0
										Do
											modBdTC.myColor(num) = Color.FromArgb(Conversions.ToInteger(array(num)))
											num += 1
										Loop While num <= 31
									End If
								End If
							End While
						End If
					End If
				End While
			Catch expr_8BC As Exception
				ProjectData.SetProjectError(expr_8BC)
				Dim ex As Exception = expr_8BC
				Throw ex
			End Try
		End Sub

		Public Sub Defa2File(pFileName As String)
			Dim w As StreamWriter = New StreamWriter(pFileName)
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
			modBdTC.Defa2xml(xmlTextWriter)
			xmlTextWriter.Close()
		End Sub

		Private Sub Defa2xml(ByRef wr As XmlTextWriter)
			wr.WriteStartElement("DEFAS")
			wr.WriteAttributeString("QuanDoColor", Conversions.ToString(modBdTC.QuanDoColor.ToArgb()))
			wr.WriteAttributeString("QuanXanhColor", Conversions.ToString(modBdTC.QuanXanhColor.ToArgb()))
			wr.WriteAttributeString("defaGenPen1W", Conversions.ToString(modBdTC.defaGenPen1W))
			wr.WriteAttributeString("defaGenPen1C", Conversions.ToString(modBdTC.defaGenPen1C.ToArgb()))
			wr.WriteAttributeString("defaGenPen2W", Conversions.ToString(modBdTC.defaGenPen2W))
			wr.WriteAttributeString("defaGenPen2C", Conversions.ToString(modBdTC.defaGenPen2C.ToArgb()))
			wr.WriteAttributeString("defaGenFill", modBdTC.defaGenFill.ToString())
			wr.WriteAttributeString("defaGenFillC", Conversions.ToString(modBdTC.defaGenFillC.ToArgb()))
			wr.WriteAttributeString("defaGenLineStyle", Conversions.ToString(modBdTC.defaGenLineStyle))
			wr.WriteAttributeString("defaSongSongSize", Conversions.ToString(modBdTC.defaSongSongSize))
			wr.WriteAttributeString("defaSongSongLinesNo", Conversions.ToString(modBdTC.defaSongSongLinesNo))
			wr.WriteAttributeString("defaSongSongPen1W", Conversions.ToString(modBdTC.defaSongSongPen1W))
			wr.WriteAttributeString("defaSongSongPen1C", Conversions.ToString(modBdTC.defaSongSongPen1C.ToArgb()))
			wr.WriteAttributeString("defaSongSongPen2W", Conversions.ToString(modBdTC.defaSongSongPen2W))
			wr.WriteAttributeString("defaSongSongPen2C", Conversions.ToString(modBdTC.defaSongSongPen2C.ToArgb()))
			wr.WriteAttributeString("defaSongSongLineStyle", Conversions.ToString(modBdTC.defaSongSongLineStyle))
			wr.WriteAttributeString("defaMuiTenDoRong", Conversions.ToString(modBdTC.defaMuiTenDoRong))
			wr.WriteAttributeString("defaMuiTenPen1W", Conversions.ToString(modBdTC.defaMuiTenPen1W))
			wr.WriteAttributeString("defaMuiTenPen1C", Conversions.ToString(modBdTC.defaMuiTenPen1C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenPen2W", Conversions.ToString(modBdTC.defaMuiTenPen2W))
			wr.WriteAttributeString("defaMuiTenPen2C", Conversions.ToString(modBdTC.defaMuiTenPen2C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenFill", modBdTC.defaMuiTenFill.ToString())
			wr.WriteAttributeString("defaMuiTenFillC", Conversions.ToString(modBdTC.defaMuiTenFillC.ToArgb()))
			wr.WriteAttributeString("defaMuiTenDacDoDai", Conversions.ToString(modBdTC.defaMuiTenDacDoDai))
			wr.WriteAttributeString("defaMuiTenDacDoRong", Conversions.ToString(modBdTC.defaMuiTenDacDoRong))
			wr.WriteAttributeString("defaMuiTenDacPen1W", Conversions.ToString(modBdTC.defaMuiTenDacPen1W))
			wr.WriteAttributeString("defaMuiTenDacPen1C", Conversions.ToString(modBdTC.defaMuiTenDacPen1C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenDacPen2W", Conversions.ToString(modBdTC.defaMuiTenDacPen2W))
			wr.WriteAttributeString("defaMuiTenDacPen2C", Conversions.ToString(modBdTC.defaMuiTenDacPen2C.ToArgb()))
			wr.WriteAttributeString("defaMuiTenDacFill", modBdTC.defaMuiTenDacFill.ToString())
			wr.WriteAttributeString("defaMuiTenDacFillC", Conversions.ToString(modBdTC.defaMuiTenDacFillC.ToArgb()))
			wr.WriteAttributeString("defaTableColsNo", Conversions.ToString(modBdTC.defaTableColsNo))
			wr.WriteAttributeString("defaTableRowsNo", Conversions.ToString(modBdTC.defaTableRowsNo))
			wr.WriteAttributeString("defaTableBorderW", Conversions.ToString(modBdTC.defaTableBorderW))
			wr.WriteAttributeString("defaTableBorderC", Conversions.ToString(modBdTC.defaTableBorderC.ToArgb()))
			wr.WriteAttributeString("defaTableLineW", Conversions.ToString(modBdTC.defaTableLineW))
			wr.WriteAttributeString("defaTableLineC", Conversions.ToString(modBdTC.defaTableLineC.ToArgb()))
			wr.WriteAttributeString("defaTableFillC", Conversions.ToString(modBdTC.defaTableFillC.ToArgb()))
			wr.WriteAttributeString("defaTableTFontName", modBdTC.defaTableTFontName)
			wr.WriteAttributeString("defaTableTFontSize", Conversions.ToString(modBdTC.defaTableTFontSize))
			wr.WriteAttributeString("defaTableTFontStyle", Conversions.ToString(modBdTC.defaTableTFontStyle))
			wr.WriteAttributeString("defaTableTextC", Conversions.ToString(modBdTC.defaTableTextC.ToArgb()))
			wr.WriteAttributeString("defaTextFontName", modBdTC.defaTextFontName)
			wr.WriteAttributeString("defaTextFontSize", Conversions.ToString(modBdTC.defaTextFontSize))
			wr.WriteAttributeString("defaTextFontStyle", Conversions.ToString(modBdTC.defaTextFontStyle))
			wr.WriteAttributeString("defaTextC", Conversions.ToString(modBdTC.defaTextC.ToArgb()))
			wr.WriteAttributeString("DanhDauColor", Conversions.ToString(modBdTC.DanhDauColor.ToArgb()))
			wr.WriteAttributeString("DanhDauColor2", Conversions.ToString(modBdTC.DanhDauColor2.ToArgb()))
			wr.WriteAttributeString("VeBoundColor", Conversions.ToString(CInt(modBdTC.VeBoundColor.ToKnownColor())))
			wr.WriteAttributeString("defaUndosNo", Conversions.ToString(modBdTC.defaUndosNo))
			Dim text As String = Conversions.ToString(modBdTC.myColor(0).ToArgb())
			Dim num As Integer = 1
			' The following expression was wrapped in a checked-statement
			Do
				text = text + " " + Conversions.ToString(modBdTC.myColor(num).ToArgb())
				num += 1
			Loop While num <= 31
			wr.WriteAttributeString("ColorsTable", text)
			wr.WriteEndElement()
		End Sub

		Public Function GetMau(pColor As Color) As Color
			Dim dlgGetColor As dlgGetColor = New dlgGetColor()
			dlgGetColor.SeleColor = pColor
			dlgGetColor.TopMost = True
			Dim result As Color
			If dlgGetColor.ShowDialog() = DialogResult.OK Then
				result = dlgGetColor.SeleColor
			Else
				result = pColor
			End If
			Return result
		End Function

		Public Sub DrawNodes(g As Graphics, mPts As PointF(), radius As Single)
			Dim pen As Pen = New Pen(Color.Black, 1F)
			Dim solidBrush As SolidBrush = New SolidBrush(Color.FromArgb(75, Color.Orange))
			Try
				Dim rect As RectangleF = New RectangleF(0F, 0F, 1F + radius * 2F, 1F + radius * 2F)
				rect.X = mPts(0).X - radius
				rect.Y = mPts(0).Y - radius
				g.FillEllipse(solidBrush, rect)
				g.DrawEllipse(pen, rect)
				g.DrawLine(pen, rect.Left - radius, rect.Top - radius, rect.Right + radius, rect.Bottom + radius)
				g.DrawLine(pen, rect.Left - radius, rect.Bottom + radius, rect.Right + radius, rect.Top - radius)
				If mPts.GetUpperBound(0) > 0 Then
					Dim arg_F1_0 As Integer = 1
					Dim upperBound As Integer = mPts.GetUpperBound(0)
					' The following expression was wrapped in a checked-expression
					For i As Integer = arg_F1_0 To upperBound
						rect.X = mPts(i).X - radius
						rect.Y = mPts(i).Y - radius
						g.FillEllipse(solidBrush, rect)
						g.DrawEllipse(pen, rect)
					Next
				End If
			Catch arg_139_0 As Exception
				ProjectData.SetProjectError(arg_139_0)
				ProjectData.ClearProjectError()
			Finally
				pen.Dispose()
				solidBrush.Dispose()
			End Try
		End Sub

		Private Function GetIntersectPoint(PT1 As PointF, PT2 As PointF, PT3 As PointF, PT4 As PointF) As Object
			Dim pointF As PointF = Nothing
			If PT2.X = PT1.X Then
				PT2.X += 1F
			End If
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			graphicsPath.AddLine(PT1, PT2)
			Dim graphicsPath2 As GraphicsPath = New GraphicsPath()
			graphicsPath2.AddLine(PT3, PT4)
			pointF = COtherLineStyle.GiaoDiem(PT1, PT2, PT3, PT4)
			Dim result As Object
			If graphicsPath.IsOutlineVisible(pointF, New Pen(Color.Black, 2F)) Then
				If graphicsPath2.IsOutlineVisible(pointF, New Pen(Color.Black, 2F)) Then
					result = pointF
				Else
					result = Nothing
				End If
			Else
				result = Nothing
			End If
			Return result
		End Function

		Private Function GetIntersectPoint(PT1 As PointF, PT2 As PointF, PTs As PointF(), index As Integer) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			If PTs.GetUpperBound(0) >= index + 1 Then
				Dim num As Integer = PTs.GetUpperBound(0) - 1
				For i As Integer = index To num
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(modBdTC.GetIntersectPoint(PT1, PT2, PTs(i), PTs(i + 1)))
					If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)) Then
						Dim expr_52 As Object = objectValue
						Dim iNTERSECTNODE As modBdTC.INTERSECTNODE
						Dim pointF As PointF
						iNTERSECTNODE.PT = (If((expr_52 IsNot Nothing), (CType(expr_52, PointF)), pointF))
						iNTERSECTNODE.NodeIndex = i
						result = iNTERSECTNODE
						Return result
					End If
				Next
				result = Nothing
			Else
				result = Nothing
			End If
			Return result
		End Function

		Public Function GetIntersectPoints(PT1 As PointF, PT2 As PointF, PTs As PointF()) As modBdTC.INTERSECTNODE()
			Dim num As Integer = -1
			Dim array As modBdTC.INTERSECTNODE() = New modBdTC.INTERSECTNODE(-1) {}
			' The following expression was wrapped in a checked-statement
			For i As Integer = 0 To PTs.GetUpperBound(0)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(modBdTC.GetIntersectPoint(PT1, PT2, PTs, i))
				If Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue)) Then
					Exit For
				End If
				num += 1
				array = CType(Utils.CopyArray(CType(array, Array), New modBdTC.INTERSECTNODE(num + 1 - 1) {}), modBdTC.INTERSECTNODE())
				Dim arg_64_0_cp_0 As modBdTC.INTERSECTNODE() = array
				Dim arg_64_0_cp_1 As Integer = num
				Dim expr_52 As Object = objectValue
				Dim iNTERSECTNODE As modBdTC.INTERSECTNODE
				arg_64_0_cp_0(arg_64_0_cp_1) = (If((expr_52 IsNot Nothing), (CType(expr_52, modBdTC.INTERSECTNODE)), iNTERSECTNODE))
			Next
			Return array
		End Function

		Public Function AngleToPoint(Origin As PointF, Target As PointF) As Single
			Target.X -= Origin.X
			Target.Y -= Origin.Y
			Return CSng((Math.Atan2(CDec(Target.Y), CDec(Target.X)) / 0.017453292519943295))
		End Function

		Public Function ObjToCurve(pObj As GraphicObject) As GraphicObject
			Dim graphicObject As GraphicObject = Nothing
			' The following expression was wrapped in a checked-statement
			Select Case pObj.GetObjType()
				Case OBJECTTYPE.Polygon, OBJECTTYPE.ClosedCurve
					Dim shapeGraphic As ShapeGraphic = CType(pObj, ShapeGraphic)
					Dim path As GraphicsPath = shapeGraphic.GetPath()
					path.Flatten(New Matrix(), 0.5F)
					Dim pathPoints As PointF() = path.PathPoints
					graphicObject = New ClosedCurveGraphic(pathPoints, 1F, Color.Red) With { .Rotation = 0F, .LineColor = shapeGraphic.LineColor, .LineWidth = shapeGraphic.LineWidth, .Line2Color = shapeGraphic.Line2Color, .Line2Width = shapeGraphic.Line2Width, .Fill = shapeGraphic.Fill, .FillColor = shapeGraphic.FillColor, .LineStyle = shapeGraphic.LineStyle, .StyleWidth = shapeGraphic.StyleWidth }
				Case OBJECTTYPE.Line, OBJECTTYPE.Curve
					Dim shapeGraphic2 As ShapeGraphic = CType(pObj, ShapeGraphic)
					Dim path2 As GraphicsPath = shapeGraphic2.GetPath()
					path2.Flatten(New Matrix(), 0.5F)
					Dim pathPoints2 As PointF() = path2.PathPoints
					graphicObject = New CurveGraphic(pathPoints2, 1F, Color.Red) With { .Rotation = 0F, .LineColor = shapeGraphic2.LineColor, .LineWidth = shapeGraphic2.LineWidth, .Line2Color = shapeGraphic2.Line2Color, .Line2Width = shapeGraphic2.Line2Width, .Fill = shapeGraphic2.Fill, .FillColor = shapeGraphic2.FillColor, .LineStyle = shapeGraphic2.LineStyle, .StyleWidth = shapeGraphic2.StyleWidth }
				Case OBJECTTYPE.Cycle, OBJECTTYPE.Ellipse
					Dim shapeGraphic3 As ShapeGraphic = CType(pObj, ShapeGraphic)
					Dim path3 As GraphicsPath = shapeGraphic3.GetPath()
					path3.Flatten(New Matrix(), 0.5F)
					Dim array As PointF() = path3.PathPoints
					Dim upperBound As Integer = array.GetUpperBound(0)
					array = CType(Utils.CopyArray(CType(array, Array), New PointF(upperBound - 1 + 1 - 1) {}), PointF())
					graphicObject = New ClosedCurveGraphic(array, 1F, Color.Red) With { .Rotation = 0F, .LineColor = shapeGraphic3.LineColor, .LineWidth = shapeGraphic3.LineWidth, .Line2Color = shapeGraphic3.Line2Color, .Line2Width = shapeGraphic3.Line2Width, .Fill = shapeGraphic3.Fill, .FillColor = shapeGraphic3.FillColor, .LineStyle = shapeGraphic3.LineStyle, .StyleWidth = shapeGraphic3.StyleWidth }
				Case OBJECTTYPE.Pie
					Dim pieGraphic As PieGraphic = CType(pObj, PieGraphic)
					Dim path4 As GraphicsPath = pieGraphic.GetPath()
					path4.Flatten(New Matrix(), 0.5F)
					Dim pathPoints3 As PointF() = path4.PathPoints
					If pieGraphic.IsArc Then
						graphicObject = New CurveGraphic(pathPoints3, 1F, Color.Red) With { .Rotation = 0F, .LineColor = pieGraphic.LineColor, .LineWidth = pieGraphic.LineWidth, .Line2Color = pieGraphic.Line2Color, .Line2Width = pieGraphic.Line2Width, .Fill = pieGraphic.Fill, .FillColor = pieGraphic.FillColor, .LineStyle = pieGraphic.LineStyle, .StyleWidth = pieGraphic.StyleWidth }
					Else
						graphicObject = New ClosedCurveGraphic(pathPoints3, 1F, Color.Red) With { .Rotation = 0F, .LineColor = pieGraphic.LineColor, .LineWidth = pieGraphic.LineWidth, .Line2Color = pieGraphic.Line2Color, .Line2Width = pieGraphic.Line2Width, .Fill = pieGraphic.Fill, .FillColor = pieGraphic.FillColor, .LineStyle = pieGraphic.LineStyle, .StyleWidth = pieGraphic.StyleWidth }
					End If
			End Select
			Dim result As GraphicObject
			If graphicObject IsNot Nothing Then
				Dim nodesShapeGraphic As NodesShapeGraphic = CType(graphicObject, NodesShapeGraphic)
				Dim arg_41F_0 As Integer = 0
				Dim num As Integer = nodesShapeGraphic.Nodes.Count - 1
				For i As Integer = arg_41F_0 To num
					nodesShapeGraphic.Nodes(i).IsControl = True
				Next
				result = nodesShapeGraphic
			Else
				result = pObj
			End If
			Return result
		End Function
	End Module
End Namespace
