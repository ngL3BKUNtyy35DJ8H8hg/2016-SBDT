Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Math

Imports System.IO
Imports System.Xml
Imports DBiGraphicObjs.DBiGraphicObjects

Module modBdTC
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

    Public cDecSepa As Char = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    Public cGrpSepa As Char = Application.CurrentCulture.NumberFormat.NumberGroupSeparator

    Public fCacKyHieu As dlgCacKyHieu

    Public fDefBDTC As dlgDefBdTC

    Public fChonTyleKH As dlgChonTyLeKH

    Public BDTyLeLayKH As Integer = 100
    '-- modBanDo --
    Public myTyLeKH2Map As Single = 1.0F

    Public myLoaiKH_ID As Long = 0L

    Public MyOtherLineStyle As COtherLineStyle

    Public DanhDauColor As Color = Color.FromArgb(75, Color.Red)
    Public DanhDauColor2 As Color = Color.FromArgb(75, Color.Black)
    Public VeBoundColor As Color = Color.FromKnownColor(KnownColor.HotTrack)

    '-- modBanDo --
    Public defaUndosNo As Integer = 10
    Public stackUnDos() As UNDOITEM
    Public stackReDos() As UNDOITEM

    '-- modBanDo --
    Public defaMyLineStyle As Integer = 0
    Public QuanDoColor As Color = Color.Red
    Public QuanXanhColor As Color = Color.Blue
    Public myColor(31) As Color

    '-- modBanDo --
    Public defaGenPen1W As Integer = 1
    Public defaGenPen1C As Color = Color.Red
    Public defaGenPen2W As Integer = 0
    Public defaGenPen2C As Color = Color.Yellow
    Public defaGenFill As Boolean = False
    Public defaGenFillC As Color = Color.Red
    Public defaGenLineStyle As Integer = 0

    '-- modBanDo --
    Public defaSongSongSize As Integer = 6
    Public defaSongSongLinesNo As Integer = 2
    Public defaSongSongPen1W As Integer = 1
    Public defaSongSongPen1C As Color = Color.Red
    Public defaSongSongPen2W As Integer = 0
    Public defaSongSongPen2C As Color = Color.Yellow
    Public defaSongSongLineStyle As Integer = 0

    '-- modBanDo --
    Public myMuiTenDoRong As Single = 30
    Public defaMuiTenDoRong As Single = 30
    Public defaMuiTenPen1W As Integer = 1
    Public defaMuiTenPen1C As Color = Color.Red
    Public defaMuiTenPen2W As Integer = 0
    Public defaMuiTenPen2C As Color = Color.Yellow
    Public defaMuiTenFill As Boolean = True
    Public defaMuiTenFillC As Color = Color.FromArgb(100, Color.Red) 'Color.Red

    '-- modBanDo --
    Public defaMuiTenDacDoRong As Single = 6
    Public defaMuiTenDacPen1W As Integer = 1
    Public defaMuiTenDacPen1C As Color = Color.Red
    Public defaMuiTenDacPen2W As Integer = 0
    Public defaMuiTenDacPen2C As Color = Color.Yellow
    Public defaMuiTenDacFill As Boolean = True
    Public defaMuiTenDacFillC As Color = Color.FromArgb(255, Color.Red)
    Public defaMuiTenDacDoDai As Single = 100

    '-- modBanDo --
    Public defaPiePen1W As Integer = 1
    Public defaPiePen1C As Color = Color.Red
    Public defaPiePen2W As Integer = 0
    Public defaPiePen2C As Color = Color.Yellow
    Public defaPieFill As Boolean = True
    Public defaPieFillC As Color = Color.FromArgb(100, Color.Red) 'Color.Red
    Public defaPieArc As Boolean = False
    Public defaPieStartA As Integer = 0
    Public defaPieSweepA As Integer = 90

    '-- modBanDo --
    Public defaTableColsNo As Integer = 2
    Public defaTableRowsNo As Integer = 8
    Public defaTableBorderW As Integer = 1
    Public defaTableBorderC As Color = Color.Blue
    Public defaTableLineW As Integer = 1
    Public defaTableLineC As Color = Color.Gray
    Public defaTableFillC As Color = Color.FromArgb(100, Color.LightYellow)

    '-- modBanDo --
    Public defaTableTFont As Font = New Font("Tahoma", 10, FontStyle.Regular, GraphicsUnit.Point)
    Public defaTableTFontName As String = "Tahoma"
    Public defaTableTFontSize As Single = 10
    Public defaTableTFontStyle As Integer = 0
    Public defaTableTextC As Color = Color.Black

    '-- modBanDo --
    Public defaTextFont As Font = New Font("Tahoma", 10, FontStyle.Regular, GraphicsUnit.Point)
    Public defaTextFontName As String = "Tahoma"
    Public defaTextFontSize As Single = 10
    Public defaTextFontStyle As Single = 0
    Public defaTextC As Color = Color.Red

    Public defaImageWidth As Integer = 80 '40
    Public defaImageHeight As Integer = 40
    Public defaHorizontalSpacing As Integer = 10
    Public defaVerticalSpacing As Integer = 32 '16



    '-- modSaBan --
    Public myDefaFileName As String = "Defas.def"
    Public myNewBdTC As String = "New.bdtc"

    Public myKHCnnString As String = ""
    '-- modBanDo --
    Public myTinhChinhGocQuay As Double = 0.5

    Public Function GetDouble(ByVal str1 As String) As Double
        Dim value As String = str1.Replace(modBdTC.cGrpSepa, modBdTC.cDecSepa)
        Return Conversions.ToDouble(value)
    End Function

    Public Function GetSingle(ByVal str1 As String) As Single
        Dim value As String = str1.Replace(modBdTC.cGrpSepa, modBdTC.cDecSepa)
        Return Conversions.ToSingle(value)
    End Function

    'Public Sub LoadDefa(ByVal pFileName As String)
    '    Try
    '        Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
    '        modBdTC.XML2Defa(xmlTextReader)
    '        xmlTextReader.Close()
    '        modBdTC.defaTableTFont = New Font(modBdTC.defaTableTFontName, modBdTC.defaTableTFontSize, CType(modBdTC.defaTableTFontStyle, FontStyle), GraphicsUnit.Point)
    '        ' The following expression was wrapped in a checked-expression
    '        modBdTC.defaTextFont = New Font(modBdTC.defaTextFontName, modBdTC.defaTextFontSize, CType(Math.Round(CDec(modBdTC.defaTextFontStyle)), FontStyle), GraphicsUnit.Point)
    '    Catch expr_50 As Exception
    '        ProjectData.SetProjectError(expr_50)
    '        ProjectData.ClearProjectError()
    '    End Try
    'End Sub

    'Private Sub XML2Defa(ByVal rr As XmlTextReader)
    '    ' The following expression was wrapped in a checked-statement
    '    Try
    '        While rr.Read()
    '            Dim nodeType As XmlNodeType = rr.NodeType
    '            Dim xmlNodeType As XmlNodeType = nodeType
    '            If xmlNodeType = XmlNodeType.Element Then
    '                Dim name As String = rr.Name
    '                If Operators.CompareString(name, "DEFAS", False) = 0 AndAlso rr.AttributeCount > 0 Then
    '                    While rr.MoveToNextAttribute()
    '                        Dim name2 As String = rr.Name
    '                        If Operators.CompareString(name2, "QuanDoColor", False) = 0 Then
    '                            modBdTC.QuanDoColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "QuanXanhColor", False) = 0 Then
    '                            modBdTC.QuanXanhColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaGenPen1W", False) = 0 Then
    '                            modBdTC.defaGenPen1W = Conversions.ToInteger(Conversion.Int(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaGenPen1C", False) = 0 Then
    '                            modBdTC.defaGenPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaGenPen2W", False) = 0 Then
    '                            modBdTC.defaGenPen2W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaGenPen2C", False) = 0 Then
    '                            modBdTC.defaGenPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaGenFill", False) = 0 Then
    '                            modBdTC.defaGenFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
    '                        ElseIf Operators.CompareString(name2, "defaGenFillC", False) = 0 Then
    '                            modBdTC.defaGenFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaGenLineStyle", False) = 0 Then
    '                            modBdTC.defaGenLineStyle = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaSongSongSize", False) = 0 Then
    '                            modBdTC.defaSongSongSize = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaSongSongLinesNo", False) = 0 Then
    '                            modBdTC.defaSongSongLinesNo = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaSongSongPen1W", False) = 0 Then
    '                            modBdTC.defaSongSongPen1W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaSongSongPen1C", False) = 0 Then
    '                            modBdTC.defaSongSongPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaSongSongPen2W", False) = 0 Then
    '                            modBdTC.defaSongSongPen2W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaSongSongPen2C", False) = 0 Then
    '                            modBdTC.defaSongSongPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaSongSongLineStyle", False) = 0 Then
    '                            modBdTC.defaSongSongLineStyle = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDoRong", False) = 0 Then
    '                            modBdTC.defaMuiTenDoRong = Conversions.ToSingle(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenPen1W", False) = 0 Then
    '                            modBdTC.defaMuiTenPen1W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenPen1C", False) = 0 Then
    '                            modBdTC.defaMuiTenPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenPen2W", False) = 0 Then
    '                            modBdTC.defaMuiTenPen2W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenPen2C", False) = 0 Then
    '                            modBdTC.defaMuiTenPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenFill", False) = 0 Then
    '                            modBdTC.defaMuiTenFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenFillC", False) = 0 Then
    '                            modBdTC.defaMuiTenFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacDoDai", False) = 0 Then
    '                            modBdTC.defaMuiTenDacDoDai = Conversions.ToSingle(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacDoRong", False) = 0 Then
    '                            modBdTC.defaMuiTenDacDoRong = Conversions.ToSingle(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacPen1W", False) = 0 Then
    '                            modBdTC.defaMuiTenDacPen1W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacPen1C", False) = 0 Then
    '                            modBdTC.defaMuiTenDacPen1C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacPen2W", False) = 0 Then
    '                            modBdTC.defaMuiTenDacPen2W = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacPen2C", False) = 0 Then
    '                            modBdTC.defaMuiTenDacPen2C = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacFill", False) = 0 Then
    '                            modBdTC.defaMuiTenDacFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
    '                        ElseIf Operators.CompareString(name2, "defaMuiTenDacFillC", False) = 0 Then
    '                            modBdTC.defaMuiTenDacFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaTableColsNo", False) = 0 Then
    '                            modBdTC.defaTableColsNo = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTableRowsNo", False) = 0 Then
    '                            modBdTC.defaTableRowsNo = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTableBorderW", False) = 0 Then
    '                            modBdTC.defaTableBorderW = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTableBorderC", False) = 0 Then
    '                            modBdTC.defaTableBorderC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaTableLineW", False) = 0 Then
    '                            modBdTC.defaTableLineW = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTableLineC", False) = 0 Then
    '                            modBdTC.defaTableLineC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaTableFillC", False) = 0 Then
    '                            modBdTC.defaTableFillC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaTableTFontName", False) = 0 Then
    '                            modBdTC.defaTableTFontName = rr.Value
    '                        ElseIf Operators.CompareString(name2, "defaTableTFontSize", False) = 0 Then
    '                            modBdTC.defaTableTFontSize = Conversions.ToSingle(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTableTFontStyle", False) = 0 Then
    '                            modBdTC.defaTableTFontStyle = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTableTextC", False) = 0 Then
    '                            modBdTC.defaTableTextC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "defaTextFontName", False) = 0 Then
    '                            modBdTC.defaTextFontName = rr.Value
    '                        ElseIf Operators.CompareString(name2, "defaTextFontSize", False) = 0 Then
    '                            modBdTC.defaTextFontSize = Conversions.ToSingle(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTextFontStyle", False) = 0 Then
    '                            modBdTC.defaTextFontStyle = Conversions.ToSingle(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "defaTextC", False) = 0 Then
    '                            modBdTC.defaTextC = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "DanhDauColor", False) = 0 Then
    '                            modBdTC.DanhDauColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "DanhDauColor2", False) = 0 Then
    '                            modBdTC.DanhDauColor2 = Color.FromArgb(Conversions.ToInteger(rr.Value))
    '                        ElseIf Operators.CompareString(name2, "VeBoundColor", False) = 0 Then
    '                            modBdTC.VeBoundColor = Color.FromKnownColor(CType(Conversions.ToInteger(rr.Value), KnownColor))
    '                        ElseIf Operators.CompareString(name2, "defaUndosNo", False) = 0 Then
    '                            modBdTC.defaUndosNo = Conversions.ToInteger(rr.Value)
    '                        ElseIf Operators.CompareString(name2, "ColorsTable", False) = 0 Then
    '                            Dim value As String = rr.Value
    '                            Dim array As String() = value.Split(New Char() {" "c})
    '                            If array.GetUpperBound(0) = 31 Then
    '                                Dim num As Integer = 0
    '                                Do
    '                                    modBdTC.myColor(num) = Color.FromArgb(Conversions.ToInteger(array(num)))
    '                                    num += 1
    '                                Loop While num <= 31
    '                            End If
    '                        End If
    '                    End While
    '                End If
    '            End If
    '        End While
    '    Catch expr_8BC As Exception
    '        ProjectData.SetProjectError(expr_8BC)
    '        Dim ex As Exception = expr_8BC
    '        Throw ex
    '    End Try
    'End Sub

    'Public Sub Defa2File(ByVal pFileName As String)
    '    Dim w As StreamWriter = New StreamWriter(pFileName)
    '    Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
    '    modBdTC.Defa2xml(xmlTextWriter)
    '    xmlTextWriter.Close()
    'End Sub

    'Private Sub Defa2xml(ByRef wr As XmlTextWriter)
    '    wr.WriteStartElement("DEFAS")
    '    wr.WriteAttributeString("QuanDoColor", Conversions.ToString(modBdTC.QuanDoColor.ToArgb()))
    '    wr.WriteAttributeString("QuanXanhColor", Conversions.ToString(modBdTC.QuanXanhColor.ToArgb()))
    '    wr.WriteAttributeString("defaGenPen1W", Conversions.ToString(modBdTC.defaGenPen1W))
    '    wr.WriteAttributeString("defaGenPen1C", Conversions.ToString(modBdTC.defaGenPen1C.ToArgb()))
    '    wr.WriteAttributeString("defaGenPen2W", Conversions.ToString(modBdTC.defaGenPen2W))
    '    wr.WriteAttributeString("defaGenPen2C", Conversions.ToString(modBdTC.defaGenPen2C.ToArgb()))
    '    wr.WriteAttributeString("defaGenFill", modBdTC.defaGenFill.ToString())
    '    wr.WriteAttributeString("defaGenFillC", Conversions.ToString(modBdTC.defaGenFillC.ToArgb()))
    '    wr.WriteAttributeString("defaGenLineStyle", Conversions.ToString(modBdTC.defaGenLineStyle))
    '    wr.WriteAttributeString("defaSongSongSize", Conversions.ToString(modBdTC.defaSongSongSize))
    '    wr.WriteAttributeString("defaSongSongLinesNo", Conversions.ToString(modBdTC.defaSongSongLinesNo))
    '    wr.WriteAttributeString("defaSongSongPen1W", Conversions.ToString(modBdTC.defaSongSongPen1W))
    '    wr.WriteAttributeString("defaSongSongPen1C", Conversions.ToString(modBdTC.defaSongSongPen1C.ToArgb()))
    '    wr.WriteAttributeString("defaSongSongPen2W", Conversions.ToString(modBdTC.defaSongSongPen2W))
    '    wr.WriteAttributeString("defaSongSongPen2C", Conversions.ToString(modBdTC.defaSongSongPen2C.ToArgb()))
    '    wr.WriteAttributeString("defaSongSongLineStyle", Conversions.ToString(modBdTC.defaSongSongLineStyle))
    '    wr.WriteAttributeString("defaMuiTenDoRong", Conversions.ToString(modBdTC.defaMuiTenDoRong))
    '    wr.WriteAttributeString("defaMuiTenPen1W", Conversions.ToString(modBdTC.defaMuiTenPen1W))
    '    wr.WriteAttributeString("defaMuiTenPen1C", Conversions.ToString(modBdTC.defaMuiTenPen1C.ToArgb()))
    '    wr.WriteAttributeString("defaMuiTenPen2W", Conversions.ToString(modBdTC.defaMuiTenPen2W))
    '    wr.WriteAttributeString("defaMuiTenPen2C", Conversions.ToString(modBdTC.defaMuiTenPen2C.ToArgb()))
    '    wr.WriteAttributeString("defaMuiTenFill", modBdTC.defaMuiTenFill.ToString())
    '    wr.WriteAttributeString("defaMuiTenFillC", Conversions.ToString(modBdTC.defaMuiTenFillC.ToArgb()))
    '    wr.WriteAttributeString("defaMuiTenDacDoDai", Conversions.ToString(modBdTC.defaMuiTenDacDoDai))
    '    wr.WriteAttributeString("defaMuiTenDacDoRong", Conversions.ToString(modBdTC.defaMuiTenDacDoRong))
    '    wr.WriteAttributeString("defaMuiTenDacPen1W", Conversions.ToString(modBdTC.defaMuiTenDacPen1W))
    '    wr.WriteAttributeString("defaMuiTenDacPen1C", Conversions.ToString(modBdTC.defaMuiTenDacPen1C.ToArgb()))
    '    wr.WriteAttributeString("defaMuiTenDacPen2W", Conversions.ToString(modBdTC.defaMuiTenDacPen2W))
    '    wr.WriteAttributeString("defaMuiTenDacPen2C", Conversions.ToString(modBdTC.defaMuiTenDacPen2C.ToArgb()))
    '    wr.WriteAttributeString("defaMuiTenDacFill", modBdTC.defaMuiTenDacFill.ToString())
    '    wr.WriteAttributeString("defaMuiTenDacFillC", Conversions.ToString(modBdTC.defaMuiTenDacFillC.ToArgb()))
    '    wr.WriteAttributeString("defaTableColsNo", Conversions.ToString(modBdTC.defaTableColsNo))
    '    wr.WriteAttributeString("defaTableRowsNo", Conversions.ToString(modBdTC.defaTableRowsNo))
    '    wr.WriteAttributeString("defaTableBorderW", Conversions.ToString(modBdTC.defaTableBorderW))
    '    wr.WriteAttributeString("defaTableBorderC", Conversions.ToString(modBdTC.defaTableBorderC.ToArgb()))
    '    wr.WriteAttributeString("defaTableLineW", Conversions.ToString(modBdTC.defaTableLineW))
    '    wr.WriteAttributeString("defaTableLineC", Conversions.ToString(modBdTC.defaTableLineC.ToArgb()))
    '    wr.WriteAttributeString("defaTableFillC", Conversions.ToString(modBdTC.defaTableFillC.ToArgb()))
    '    wr.WriteAttributeString("defaTableTFontName", modBdTC.defaTableTFontName)
    '    wr.WriteAttributeString("defaTableTFontSize", Conversions.ToString(modBdTC.defaTableTFontSize))
    '    wr.WriteAttributeString("defaTableTFontStyle", Conversions.ToString(modBdTC.defaTableTFontStyle))
    '    wr.WriteAttributeString("defaTableTextC", Conversions.ToString(modBdTC.defaTableTextC.ToArgb()))
    '    wr.WriteAttributeString("defaTextFontName", modBdTC.defaTextFontName)
    '    wr.WriteAttributeString("defaTextFontSize", Conversions.ToString(modBdTC.defaTextFontSize))
    '    wr.WriteAttributeString("defaTextFontStyle", Conversions.ToString(modBdTC.defaTextFontStyle))
    '    wr.WriteAttributeString("defaTextC", Conversions.ToString(modBdTC.defaTextC.ToArgb()))
    '    wr.WriteAttributeString("DanhDauColor", Conversions.ToString(modBdTC.DanhDauColor.ToArgb()))
    '    wr.WriteAttributeString("DanhDauColor2", Conversions.ToString(modBdTC.DanhDauColor2.ToArgb()))
    '    wr.WriteAttributeString("VeBoundColor", Conversions.ToString(CInt(modBdTC.VeBoundColor.ToKnownColor())))
    '    wr.WriteAttributeString("defaUndosNo", Conversions.ToString(modBdTC.defaUndosNo))
    '    Dim text As String = Conversions.ToString(modBdTC.myColor(0).ToArgb())
    '    Dim num As Integer = 1
    '    ' The following expression was wrapped in a checked-statement
    '    Do
    '        text = text + " " + Conversions.ToString(modBdTC.myColor(num).ToArgb())
    '        num += 1
    '    Loop While num <= 31
    '    wr.WriteAttributeString("ColorsTable", text)
    '    wr.WriteEndElement()
    'End Sub

    'Public Function GetMau(ByVal pColor As Color) As Color
    '    Dim dlgGetColor As dlgGetColor = New dlgGetColor()
    '    dlgGetColor.SeleColor = pColor
    '    dlgGetColor.TopMost = True
    '    Dim result As Color
    '    If dlgGetColor.ShowDialog() = DialogResult.OK Then
    '        result = dlgGetColor.SeleColor
    '    Else
    '        result = pColor
    '    End If
    '    Return result
    'End Function

    Public Sub DrawNodes(ByVal g As Graphics, ByVal mPts As PointF(), ByVal radius As Single)
        Dim pen As Pen = New Pen(Color.Black, 1.0F)
        Dim solidBrush As SolidBrush = New SolidBrush(Color.FromArgb(75, Color.Orange))
        Try
            Dim rect As RectangleF = New RectangleF(0.0F, 0.0F, 1.0F + radius * 2.0F, 1.0F + radius * 2.0F)
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

    Private Function GetIntersectPoint(ByVal PT1 As PointF, ByVal PT2 As PointF, ByVal PT3 As PointF, ByVal PT4 As PointF) As Object
        Dim pointF As PointF = Nothing
        If PT2.X = PT1.X Then
            PT2.X += 1.0F
        End If
        Dim graphicsPath As GraphicsPath = New GraphicsPath()
        graphicsPath.AddLine(PT1, PT2)
        Dim graphicsPath2 As GraphicsPath = New GraphicsPath()
        graphicsPath2.AddLine(PT3, PT4)
        pointF = COtherLineStyle.GiaoDiem(PT1, PT2, PT3, PT4)
        Dim result As Object
        If graphicsPath.IsOutlineVisible(pointF, New Pen(Color.Black, 2.0F)) Then
            If graphicsPath2.IsOutlineVisible(pointF, New Pen(Color.Black, 2.0F)) Then
                result = pointF
            Else
                result = Nothing
            End If
        Else
            result = Nothing
        End If
        Return result
    End Function

    Private Function GetIntersectPoint(ByVal PT1 As PointF, ByVal PT2 As PointF, ByVal PTs As PointF(), ByVal index As Integer) As Object
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

    '-- modBanDo --
    Public Function GetIntersectPoints(ByVal PT1 As PointF, ByVal PT2 As PointF, ByVal PTs() As PointF) As INTERSECTNODE()
        Dim mINTERSECTNODEs() As INTERSECTNODE
        Dim mINTERSECTNODE As Object
        Dim j As Integer = -1
        ReDim mINTERSECTNODEs(-1)
        Dim i As Integer = 0
        Do While i <= PTs.GetUpperBound(0)
            mINTERSECTNODE = GetIntersectPoint(PT1, PT2, PTs, i)
            If Not IsNothing(mINTERSECTNODE) Then
                j += 1
                ReDim Preserve mINTERSECTNODEs(j)
                mINTERSECTNODEs(j) = CType(mINTERSECTNODE, INTERSECTNODE)
                i = mINTERSECTNODEs(j).NodeIndex + 1
            Else
                Exit Do
            End If
        Loop
        Return mINTERSECTNODEs
    End Function

    '-- modBanDo --
    Public Function AngleToPoint(ByVal Origin As PointF, ByVal Target As PointF) As Single
        Dim Angle As Single
        Target.X = Target.X - Origin.X
        Target.Y = Target.Y - Origin.Y
        Angle = Math.Atan2(Target.Y, Target.X) / (Math.PI / 180)
        Return Angle
    End Function

    '-- modBanDo --
    Public Function ObjToCurve(ByVal pObj As GraphicObject) As GraphicObject
        Dim gObj As GraphicObject = Nothing

        Select Case pObj.GetObjType
            Case OBJECTTYPE.Line, OBJECTTYPE.Curve
                Dim mObj As ShapeGraphic = CType(pObj, ShapeGraphic)
                Dim mPath As GraphicsPath = mObj.GetPath()
                mPath.Flatten(New Matrix, 0.5)
                Dim pPts() As PointF = mPath.PathPoints
                Dim myCurve As New CurveGraphic(pPts, 1, Color.Red)
                myCurve.Rotation = 0
                myCurve.LineColor = mObj.LineColor
                myCurve.LineWidth = mObj.LineWidth
                myCurve.Line2Color = mObj.Line2Color
                myCurve.Line2Width = mObj.Line2Width
                myCurve.Fill = mObj.Fill
                myCurve.FillColor = mObj.FillColor
                myCurve.LineStyle = mObj.LineStyle
                gObj = myCurve

            Case OBJECTTYPE.Polygon, OBJECTTYPE.ClosedCurve
                Dim mObj As ShapeGraphic = CType(pObj, ShapeGraphic)
                Dim mPath As GraphicsPath = mObj.GetPath()
                mPath.Flatten(New Matrix, 0.5)
                Dim pPts() As PointF = mPath.PathPoints
                Dim myCurve As New ClosedCurveGraphic(pPts, 1, Color.Red)
                myCurve.Rotation = 0
                myCurve.LineColor = mObj.LineColor
                myCurve.LineWidth = mObj.LineWidth
                myCurve.Line2Color = mObj.Line2Color
                myCurve.Line2Width = mObj.Line2Width
                myCurve.Fill = mObj.Fill
                myCurve.FillColor = mObj.FillColor
                myCurve.LineStyle = mObj.LineStyle
                gObj = myCurve
            Case OBJECTTYPE.Ellipse, OBJECTTYPE.Cycle
                Dim mObj As ShapeGraphic = CType(pObj, ShapeGraphic)
                Dim mPath As GraphicsPath = mObj.GetPath()
                mPath.Flatten(New Matrix, 0.5)
                Dim pPts() As PointF = mPath.PathPoints
                Dim j As Integer = pPts.GetUpperBound(0)
                ReDim Preserve pPts(j - 1)
                Dim myCurve As New ClosedCurveGraphic(pPts, 1, Color.Red)
                myCurve.Rotation = 0
                myCurve.LineColor = mObj.LineColor
                myCurve.LineWidth = mObj.LineWidth
                myCurve.Line2Color = mObj.Line2Color
                myCurve.Line2Width = mObj.Line2Width
                myCurve.Fill = mObj.Fill
                myCurve.LineStyle = mObj.LineStyle
                myCurve.FillColor = mObj.FillColor
                gObj = myCurve
            Case OBJECTTYPE.Pie
                Dim mObj As PieGraphic = CType(pObj, PieGraphic)
                Dim mPath As GraphicsPath = mObj.GetPath()
                mPath.Flatten(New Matrix, 0.5)
                Dim pPts() As PointF = mPath.PathPoints
                If mObj.IsArc = True Then
                    Dim myCurve As New CurveGraphic(pPts, 1, Color.Red)
                    myCurve.Rotation = 0
                    myCurve.LineColor = mObj.LineColor
                    myCurve.LineWidth = mObj.LineWidth
                    myCurve.Line2Color = mObj.Line2Color
                    myCurve.Line2Width = mObj.Line2Width
                    myCurve.Fill = mObj.Fill
                    myCurve.FillColor = mObj.FillColor
                    myCurve.LineStyle = mObj.LineStyle
                    gObj = myCurve
                Else
                    Dim myCurve As New ClosedCurveGraphic(pPts, 1, Color.Red)
                    myCurve.Rotation = 0
                    myCurve.LineColor = mObj.LineColor
                    myCurve.LineWidth = mObj.LineWidth
                    myCurve.Line2Color = mObj.Line2Color
                    myCurve.Line2Width = mObj.Line2Width
                    myCurve.Fill = mObj.Fill
                    myCurve.FillColor = mObj.FillColor
                    myCurve.LineStyle = mObj.LineStyle
                    gObj = myCurve
                End If
        End Select

        If Not gObj Is Nothing Then
            Dim gObj2 As NodesShapeGraphic = CType(gObj, NodesShapeGraphic)
            For i As Integer = 0 To gObj2.Nodes.Count - 1
                gObj2.Nodes.Item(i).IsControl = True
            Next
            Return gObj2
        Else
            Return pObj
        End If
    End Function
End Module
