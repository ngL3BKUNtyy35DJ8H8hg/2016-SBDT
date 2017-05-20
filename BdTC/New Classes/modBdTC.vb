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

    'Public fDefBDTC As dlgDefBdTC

    'Public fChonTyleKH As dlgChonTyLeKH

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
        Return Double.Parse(value)
    End Function

    Public Function GetSingle(ByVal str1 As String) As Single
        Dim value As String = str1.Replace(modBdTC.cGrpSepa, modBdTC.cDecSepa)
        Return Single.Parse(value)
    End Function

    Public Sub LoadDefa(ByVal pFileName As String)
        Try
            Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
            modBdTC.XML2Defa(xmlTextReader)
            xmlTextReader.Close()
            modBdTC.defaTableTFont = New Font(modBdTC.defaTableTFontName, modBdTC.defaTableTFontSize, CType(modBdTC.defaTableTFontStyle, FontStyle), GraphicsUnit.Point)
            ' The following expression was wrapped in a checked-expression
            modBdTC.defaTextFont = New Font(modBdTC.defaTextFontName, modBdTC.defaTextFontSize, CType(Math.Round(CDec(modBdTC.defaTextFontStyle)), FontStyle), GraphicsUnit.Point)
        Catch expr_50 As Exception
            'ProjectData.SetProjectError(expr_50)
            'ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub XML2Defa(ByVal rr As XmlTextReader)
        ' The following expression was wrapped in a checked-statement
        Try
            While rr.Read()
                Dim nodeType As XmlNodeType = rr.NodeType
                Dim xmlNodeType As XmlNodeType = nodeType
                If xmlNodeType = XmlNodeType.Element Then
                    Dim name As String = rr.Name
                    If name = "DEFAS" AndAlso rr.AttributeCount > 0 Then
                        While rr.MoveToNextAttribute()
                            Dim name2 As String = rr.Name
                            If name2 = "QuanDoColor" Then
                                modBdTC.QuanDoColor = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "QuanXanhColor" Then
                                modBdTC.QuanXanhColor = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaGenPen1W" Then
                                modBdTC.defaGenPen1W = Integer.Parse(Conversion.Int(rr.Value))
                            ElseIf name2 = "defaGenPen1C" Then
                                modBdTC.defaGenPen1C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaGenPen2W" Then
                                modBdTC.defaGenPen2W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaGenPen2C" Then
                                modBdTC.defaGenPen2C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaGenFill" Then
                                modBdTC.defaGenFill = Boolean.Parse(Interaction.IIf(rr.Value = "True", True, False))
                            ElseIf name2 = "defaGenFillC" Then
                                modBdTC.defaGenFillC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaGenLineStyle" Then
                                modBdTC.defaGenLineStyle = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaSongSongSize" Then
                                modBdTC.defaSongSongSize = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaSongSongLinesNo" Then
                                modBdTC.defaSongSongLinesNo = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaSongSongPen1W" Then
                                modBdTC.defaSongSongPen1W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaSongSongPen1C" Then
                                modBdTC.defaSongSongPen1C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaSongSongPen2W" Then
                                modBdTC.defaSongSongPen2W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaSongSongPen2C" Then
                                modBdTC.defaSongSongPen2C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaSongSongLineStyle" Then
                                modBdTC.defaSongSongLineStyle = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenDoRong" Then
                                modBdTC.defaMuiTenDoRong = Single.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenPen1W" Then
                                modBdTC.defaMuiTenPen1W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenPen1C" Then
                                modBdTC.defaMuiTenPen1C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaMuiTenPen2W" Then
                                modBdTC.defaMuiTenPen2W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenPen2C" Then
                                modBdTC.defaMuiTenPen2C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaMuiTenFill" Then
                                modBdTC.defaMuiTenFill = Boolean.Parse(Interaction.IIf(rr.Value = "True", True, False))
                            ElseIf name2 = "defaMuiTenFillC" Then
                                modBdTC.defaMuiTenFillC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaMuiTenDacDoDai" Then
                                modBdTC.defaMuiTenDacDoDai = Single.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenDacDoRong" Then
                                modBdTC.defaMuiTenDacDoRong = Single.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenDacPen1W" Then
                                modBdTC.defaMuiTenDacPen1W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenDacPen1C" Then
                                modBdTC.defaMuiTenDacPen1C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaMuiTenDacPen2W" Then
                                modBdTC.defaMuiTenDacPen2W = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaMuiTenDacPen2C" Then
                                modBdTC.defaMuiTenDacPen2C = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaMuiTenDacFill" Then
                                modBdTC.defaMuiTenDacFill = Boolean.Parse(Interaction.IIf(rr.Value = "True", True, False))
                            ElseIf name2 = "defaMuiTenDacFillC" Then
                                modBdTC.defaMuiTenDacFillC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaTableColsNo" Then
                                modBdTC.defaTableColsNo = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaTableRowsNo" Then
                                modBdTC.defaTableRowsNo = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaTableBorderW" Then
                                modBdTC.defaTableBorderW = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaTableBorderC" Then
                                modBdTC.defaTableBorderC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaTableLineW" Then
                                modBdTC.defaTableLineW = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaTableLineC" Then
                                modBdTC.defaTableLineC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaTableFillC" Then
                                modBdTC.defaTableFillC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaTableTFontName" Then
                                modBdTC.defaTableTFontName = rr.Value
                            ElseIf name2 = "defaTableTFontSize" Then
                                modBdTC.defaTableTFontSize = Single.Parse(rr.Value)
                            ElseIf name2 = "defaTableTFontStyle" Then
                                modBdTC.defaTableTFontStyle = Integer.Parse(rr.Value)
                            ElseIf name2 = "defaTableTextC" Then
                                modBdTC.defaTableTextC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "defaTextFontName" Then
                                modBdTC.defaTextFontName = rr.Value
                            ElseIf name2 = "defaTextFontSize" Then
                                modBdTC.defaTextFontSize = Single.Parse(rr.Value)
                            ElseIf name2 = "defaTextFontStyle" Then
                                modBdTC.defaTextFontStyle = Single.Parse(rr.Value)
                            ElseIf name2 = "defaTextC" Then
                                modBdTC.defaTextC = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "DanhDauColor" Then
                                modBdTC.DanhDauColor = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "DanhDauColor2" Then
                                modBdTC.DanhDauColor2 = Color.FromArgb(Integer.Parse(rr.Value))
                            ElseIf name2 = "VeBoundColor" Then
                                modBdTC.VeBoundColor = Color.FromKnownColor(CType(Integer.Parse(rr.Value), KnownColor))
                            ElseIf name2 = "defaUndosNo" Then
                                modBdTC.defaUndosNo = Integer.Parse(rr.Value)
                            ElseIf name2 = "ColorsTable" Then
                                Dim value As String = rr.Value
                                Dim array As String() = value.Split(New Char() {" "c})
                                If array.GetUpperBound(0) = 31 Then
                                    Dim num As Integer = 0
                                    Do
                                        modBdTC.myColor(num) = Color.FromArgb(Integer.Parse(array(num)))
                                        num += 1
                                    Loop While num <= 31
                                End If
                            End If
                        End While
                    End If
                End If
            End While
        Catch expr_8BC As Exception
            'ProjectData.SetProjectError(expr_8BC)
            'Dim ex As Exception = expr_8BC
            'Throw ex
        End Try
    End Sub

    Public Sub Defa2File(ByVal pFileName As String)
        Dim w As StreamWriter = New StreamWriter(pFileName)
        Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
        modBdTC.Defa2xml(xmlTextWriter)
        xmlTextWriter.Close()
    End Sub

    Private Sub Defa2xml(ByRef wr As XmlTextWriter)
        wr.WriteStartElement("DEFAS")
        wr.WriteAttributeString("QuanDoColor", modBdTC.QuanDoColor.ToArgb().ToString())
        wr.WriteAttributeString("QuanXanhColor", modBdTC.QuanXanhColor.ToArgb().ToString())
        wr.WriteAttributeString("defaGenPen1W", modBdTC.defaGenPen1W)
        wr.WriteAttributeString("defaGenPen1C", modBdTC.defaGenPen1C.ToArgb().ToString())
        wr.WriteAttributeString("defaGenPen2W", modBdTC.defaGenPen2W)
        wr.WriteAttributeString("defaGenPen2C", modBdTC.defaGenPen2C.ToArgb().ToString())
        wr.WriteAttributeString("defaGenFill", modBdTC.defaGenFill.ToString())
        wr.WriteAttributeString("defaGenFillC", modBdTC.defaGenFillC.ToArgb().ToString())
        wr.WriteAttributeString("defaGenLineStyle", modBdTC.defaGenLineStyle)
        wr.WriteAttributeString("defaSongSongSize", modBdTC.defaSongSongSize)
        wr.WriteAttributeString("defaSongSongLinesNo", modBdTC.defaSongSongLinesNo)
        wr.WriteAttributeString("defaSongSongPen1W", modBdTC.defaSongSongPen1W)
        wr.WriteAttributeString("defaSongSongPen1C", modBdTC.defaSongSongPen1C.ToArgb().ToString())
        wr.WriteAttributeString("defaSongSongPen2W", modBdTC.defaSongSongPen2W)
        wr.WriteAttributeString("defaSongSongPen2C", modBdTC.defaSongSongPen2C.ToArgb().ToString())
        wr.WriteAttributeString("defaSongSongLineStyle", modBdTC.defaSongSongLineStyle)
        wr.WriteAttributeString("defaMuiTenDoRong", modBdTC.defaMuiTenDoRong)
        wr.WriteAttributeString("defaMuiTenPen1W", modBdTC.defaMuiTenPen1W)
        wr.WriteAttributeString("defaMuiTenPen1C", modBdTC.defaMuiTenPen1C.ToArgb().ToString())
        wr.WriteAttributeString("defaMuiTenPen2W", modBdTC.defaMuiTenPen2W)
        wr.WriteAttributeString("defaMuiTenPen2C", modBdTC.defaMuiTenPen2C.ToArgb().ToString())
        wr.WriteAttributeString("defaMuiTenFill", modBdTC.defaMuiTenFill.ToString())
        wr.WriteAttributeString("defaMuiTenFillC", modBdTC.defaMuiTenFillC.ToArgb().ToString())
        wr.WriteAttributeString("defaMuiTenDacDoDai", modBdTC.defaMuiTenDacDoDai)
        wr.WriteAttributeString("defaMuiTenDacDoRong", modBdTC.defaMuiTenDacDoRong)
        wr.WriteAttributeString("defaMuiTenDacPen1W", modBdTC.defaMuiTenDacPen1W)
        wr.WriteAttributeString("defaMuiTenDacPen1C", modBdTC.defaMuiTenDacPen1C.ToArgb().ToString())
        wr.WriteAttributeString("defaMuiTenDacPen2W", modBdTC.defaMuiTenDacPen2W)
        wr.WriteAttributeString("defaMuiTenDacPen2C", modBdTC.defaMuiTenDacPen2C.ToArgb().ToString())
        wr.WriteAttributeString("defaMuiTenDacFill", modBdTC.defaMuiTenDacFill.ToString())
        wr.WriteAttributeString("defaMuiTenDacFillC", modBdTC.defaMuiTenDacFillC.ToArgb().ToString())
        wr.WriteAttributeString("defaTableColsNo", modBdTC.defaTableColsNo)
        wr.WriteAttributeString("defaTableRowsNo", modBdTC.defaTableRowsNo)
        wr.WriteAttributeString("defaTableBorderW", modBdTC.defaTableBorderW)
        wr.WriteAttributeString("defaTableBorderC", modBdTC.defaTableBorderC.ToArgb().ToString())
        wr.WriteAttributeString("defaTableLineW", modBdTC.defaTableLineW)
        wr.WriteAttributeString("defaTableLineC", modBdTC.defaTableLineC.ToArgb().ToString())
        wr.WriteAttributeString("defaTableFillC", modBdTC.defaTableFillC.ToArgb().ToString())
        wr.WriteAttributeString("defaTableTFontName", modBdTC.defaTableTFontName)
        wr.WriteAttributeString("defaTableTFontSize", modBdTC.defaTableTFontSize)
        wr.WriteAttributeString("defaTableTFontStyle", modBdTC.defaTableTFontStyle)
        wr.WriteAttributeString("defaTableTextC", modBdTC.defaTableTextC.ToArgb().ToString())
        wr.WriteAttributeString("defaTextFontName", modBdTC.defaTextFontName)
        wr.WriteAttributeString("defaTextFontSize", modBdTC.defaTextFontSize)
        wr.WriteAttributeString("defaTextFontStyle", modBdTC.defaTextFontStyle)
        wr.WriteAttributeString("defaTextC", modBdTC.defaTextC.ToArgb().ToString())
        wr.WriteAttributeString("DanhDauColor", modBdTC.DanhDauColor.ToArgb().ToString())
        wr.WriteAttributeString("DanhDauColor2", modBdTC.DanhDauColor2.ToArgb().ToString())
        wr.WriteAttributeString("VeBoundColor", CInt(modBdTC.VeBoundColor.ToKnownColor()).ToString())
        wr.WriteAttributeString("defaUndosNo", modBdTC.defaUndosNo)
        Dim text As String = modBdTC.myColor(0).ToArgb().ToString()
        Dim num As Integer = 1
        ' The following expression was wrapped in a checked-statement
        Do
            text = text + " " + modBdTC.myColor(num).ToArgb()
            num += 1
        Loop While num <= 31
        wr.WriteAttributeString("ColorsTable", text)
        wr.WriteEndElement()
    End Sub

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
            'ProjectData.SetProjectError(arg_139_0)
            'ProjectData.ClearProjectError()
        Finally
            pen.Dispose()
            solidBrush.Dispose()
        End Try
    End Sub

    '-- modBanDo --
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

    '-- modBanDo --
    Private Function GetIntersectPoint(ByVal PT1 As PointF, ByVal PT2 As PointF, ByVal PTs As PointF(), ByVal index As Integer) As Object
        ' The following expression was wrapped in a checked-statement
        Dim result As Object
        If PTs.GetUpperBound(0) >= index + 1 Then
            Dim num As Integer = PTs.GetUpperBound(0) - 1
            For i As Integer = index To num
                Dim objectValue As Object = modBdTC.GetIntersectPoint(PT1, PT2, PTs(i), PTs(i + 1))
                If Not Information.IsNothing(objectValue) Then
                    Dim expr_52 As Object = objectValue
                    Dim iNTERSECTNODE As modBdTC.INTERSECTNODE
                    Dim pointF As PointF
                    iNTERSECTNODE.PT = IIf((objectValue IsNot Nothing), (CType(expr_52, PointF)), pointF)
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
