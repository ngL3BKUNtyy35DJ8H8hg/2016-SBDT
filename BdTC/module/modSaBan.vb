Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Xml
Imports BdTC.Actions


Public Module modSaBan
    Public MyMnuName As String = "MyMnu.xml"

    Public myHienDanhSach As Boolean = True

    Public fActions As dlgActions

    Public clrColor As Color = Color.LightCoral

    Public BGrColor As Color = Color.LightBlue

    Public ActColor As Color = Color.Red
    Public NoActColor As Color = Color.Blue

    Public MenuFontName As String = "Arial"
    Public MenuFontSize As Single = 12.0F
    Public MenuFontStyle As FontStyle = FontStyle.Regular

    Public TitleColor As Color = Color.Black
    Public TitleFontName As String = "Arial"
    Public TitleFontSize As Single = 24.0F
    Public TitleFontStyle As FontStyle = FontStyle.Regular
    Public TitleText As String = ""
    Public TitlePointX As Integer = 400
    Public TitlePointY As Integer = 4

    Public DescColor As Color = Color.Yellow
    Public DescFontName As String = "Times New Roman"
    Public DescFontSize As Single = 18.0F
    Public DescFontStyle As FontStyle = FontStyle.Bold
    Public DescTrenColor As Color = Color.Red
    Public DescTrenFontName As String = "Times New Roman"
    Public DescTrenFontSize As Single = 20.0F
    Public DescTrenFontStyle As FontStyle = FontStyle.Bold
    Public DescGiuaColor As Color = Color.Black
    Public DescGiuaFontName As String = "Times New Roman"
    Public DescGiuaFontSize As Single = 18.0F
    Public DescGiuaFontStyle As FontStyle = FontStyle.Bold

    Public myMuiTenFile As String = "..\Defas\MuiTen.txt"
    Public myExplodeFile As String = "..\Defas\Explode.txt"

    Public myApplPath As String

    Public myCTpara As String = "SaBan.para"

    Public myDiaHinhDef As String = "ThucHanh3.diahinh"

    Public myCurrentDirectory As String = "E:\fromMinh\20100327\SaBanData\LongThanh"

    Public mySoundsPath As String = "..\sounds"
    Public myTMSoundsPath As String = "..\sounds\ThuyetMinh"
    Public myImagesPath As String = "..\images"

    Public myD3DModelMeshFile As String = "..\MeshDef\D3DModelMesh.xml"
    Public myBillboardMeshFile As String = "..\MeshDef\D3DBillboardMesh.xml"
    Public mySpriteTexsFile As String = "..\MeshDef\D3DSpriteTexs.xml"

    Public myLastSaBan As String = "ThucHanh3.last"
    Public mySaBanDir As String = "ThucHanh3"
    Public LastBdTC As String = "ThucHanh3\ThucHanhCD.BDTC"

    '-- modBanDo --
    Public myTextureFile As String = "LongThanh.jpg"
    Public myGridDataFile As String = "GridData.txt"
    Public myGridDataType As String = "txt"

    '-- modBanDo --
    Public myMap1X As Double = 106.941953898199D
    Public myMap1Y As Double = 10.844428647015D
    Public myMap2X As Double = 107.00178D
    Public myMap2Y As Double = 10.77494D

    '-- modBanDo --
    Public myGRID_WIDTH As Integer = 101
    Public myGRID_HEIGHT As Integer = 119
    Public mySCALE_FACTOR As Single = 6.5F

    Public myLightDir As Vector3 = New Vector3(9.0F, -9.0F, -27.0F)

    Public myCamPos As Vector3 = New Vector3(0.0F, -44.0F, -22.0F)

    Public myCamTarget As Vector3 = New Vector3(0.0F, 0.0F, 0.0F)

    Public myAngleZ As Single = 0.0F

    Public myAngleX As Single = -0.448798954F

    Public myCenterX As Single = 0.5F
    Public myCenterY As Single = 0.5F

    Public mySurf1X As Double = 0.0
    Public mySurf1Y As Double = 0.0
    Public mySurf2X As Double = 2047D
    Public mySurf2Y As Double = 2405D

    Public my3DSoPixelsPer1000m As Double = 312.0

    Public Const RadsToDegs As Double = 57.29578

    Public Const DegsToRads As Double = 0.0174532925

    Public heightData As Single(,)

    Public Function getDPGstr(ByVal pX As Double) As String
        Dim dPG As DPGFormat = modSaBan.getDPG(pX)
        Return String.Concat(New String() {dPG.ido.ToString("#0"), "°", dPG.iphut.ToString("#0"), ":", dPG.igiay.ToString("#0")})
    End Function

    Public Function getDPG(ByVal pX As Double) As DPGFormat
        Dim result As DPGFormat = Nothing
        ' The following expression was wrapped in a checked-statement
        result.ido = CInt(Math.Round(Math.Floor(pX)))
        result.iphut = CInt(Math.Round(Math.Floor((pX - CDec(result.ido)) * 60.0)))
        result.igiay = CInt(Math.Round(Math.Floor(((pX - CDec(result.ido)) * 60.0 - CDec(result.iphut)) * 60.0)))
        Return result
    End Function

    Public Function GetSurfPosition(ByVal pMapX As Double, ByVal pMapY As Double) As PointF
        Dim result As PointF = New PointF(0.0F, 0.0F)
        Dim num As Double
        If Operators.CompareString(modSaBan.myGridDataType, "xyz", False) = 0 Then
            num = (pMapX - modSaBan.myMap2X) * (modSaBan.mySurf2X - modSaBan.mySurf1X) / (modSaBan.myMap1X - modSaBan.myMap2X)
        Else
            num = (modSaBan.myMap1X - pMapX) * (modSaBan.mySurf2X - modSaBan.mySurf1X) / (modSaBan.myMap1X - modSaBan.myMap2X) + modSaBan.mySurf1X
        End If
        Dim num2 As Double = (modSaBan.myMap1Y - pMapY) * (modSaBan.mySurf2Y - modSaBan.mySurf1Y) / (modSaBan.myMap1Y - modSaBan.myMap2Y) + modSaBan.mySurf1Y
        result.X = CSng(num)
        result.Y = CSng(num2)
        Return result
    End Function

    Public Function GetSurfPosition0(ByVal pMapX As Double, ByVal pMapY As Double) As PointF
        Dim result As PointF = New PointF(0.0F, 0.0F)
        Dim num As Double = (modSaBan.myMap1X - pMapX) * (modSaBan.mySurf2X - modSaBan.mySurf1X) / (modSaBan.myMap1X - modSaBan.myMap2X) + modSaBan.mySurf1X
        Dim num2 As Double = (modSaBan.myMap1Y - pMapY) * (modSaBan.mySurf2Y - modSaBan.mySurf1Y) / (modSaBan.myMap1Y - modSaBan.myMap2Y) + modSaBan.mySurf1Y
        result.X = CSng(num)
        result.Y = CSng(num2)
        Return result
    End Function

    Public Function imagenameOK(ByVal name As String) As Boolean
        Dim result As Boolean = False
        Dim dataSet As DataSet = New DataSet()
        dataSet.ReadXml(modSaBan.mySpriteTexsFile)
        Dim dataTable As DataTable = dataSet.Tables(0)
        If dataTable.Rows.Count > 0 Then
            Try
                Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
                While enumerator.MoveNext()
                    Dim dataRow As DataRow = CType(enumerator.Current, DataRow)
                    Dim text As String = Conversions.ToString(dataRow(0))
                    If text.IndexOf(name) > -1 Then
                        result = True
                        Exit While
                    End If
                End While
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
                End If
            End Try
        End If
        Return result
    End Function

    Public Function File2Para(ByVal pFileName As String) As Boolean
        Dim result As Boolean = False
        Try
            Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
            modSaBan.XML2Para(xmlTextReader)
            xmlTextReader.Close()
            result = True
        Catch expr_19 As Exception
            ProjectData.SetProjectError(expr_19)
            ProjectData.ClearProjectError()
        End Try
        Return result
    End Function

    Public Function ParaOK() As Boolean
        Dim flag As Boolean = True
        Dim result As Boolean
        If Directory.Exists(modSaBan.myCurrentDirectory) Then
            Directory.SetCurrentDirectory(modSaBan.myCurrentDirectory)
            ' The following expression was wrapped in a checked-expression
            If Not Directory.Exists(modSaBan.mySoundsPath) Then
                result = False
            ElseIf Not Directory.Exists(modSaBan.myImagesPath) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myLastSaBan) Then
                result = False
            ElseIf Not File.Exists(modBdTC.myDefaFileName) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myMuiTenFile) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myExplodeFile) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myD3DModelMeshFile) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myBillboardMeshFile) Then
                result = False
            ElseIf Not File.Exists(modSaBan.mySpriteTexsFile) Then
                result = False
            ElseIf Not File.Exists(modBanDo.myMapGst) Then
                result = False
            ElseIf Not File.Exists(modBanDo.myMapNhoGst) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myTextureFile) Then
                result = False
            ElseIf Not File.Exists(modSaBan.myGridDataFile) Then
                result = False
            ElseIf modSaBan.myGRID_WIDTH * modSaBan.myGRID_HEIGHT > 32000 Then
                Interaction.MsgBox("(myGRID_WIDTH * myGRID_HEIGHT) > 32000", MsgBoxStyle.OkOnly, Nothing)
                result = False
            Else
                result = flag
            End If
        Else
            result = False
        End If
        Return result
    End Function

    Private Sub XML2Para(ByVal rr As XmlTextReader)
        Try
            modSaBan.mySoundsPath = ""
            modSaBan.myImagesPath = ""
            modSaBan.myCurrentDirectory = ""
            While rr.Read()
                Dim nodeType As XmlNodeType = rr.NodeType
                Dim xmlNodeType As XmlNodeType = nodeType
                If xmlNodeType = xmlNodeType.Element Then
                    Dim name As String = rr.Name
                    If Operators.CompareString(name, "PARA", False) = 0 AndAlso rr.AttributeCount > 0 Then
                        While rr.MoveToNextAttribute()
                            Dim name2 As String = rr.Name
                            If Operators.CompareString(name2, "myCurrentDirectory", False) = 0 Then
                                modSaBan.myCurrentDirectory = rr.Value
                            ElseIf Operators.CompareString(name2, "myDefaFileName", False) = 0 Then
                                modBdTC.myDefaFileName = rr.Value
                            ElseIf Operators.CompareString(name2, "myKHCnnString", False) = 0 Then
                                modBdTC.myKHCnnString = rr.Value
                            ElseIf Operators.CompareString(name2, "myMapGst", False) = 0 Then
                                myMapGst = rr.Value
                            ElseIf Operators.CompareString(name2, "myMapNhoGst", False) = 0 Then
                                myMapNhoGst = rr.Value
                            ElseIf Operators.CompareString(name2, "mySaiSo", False) = 0 Then
                                modBanDo.BDSaiSo = modBdTC.GetDouble(rr.Value)
                            ElseIf Operators.CompareString(name2, "myTinhChinhGocQuay", False) = 0 Then
                                modBdTC.myTinhChinhGocQuay = modBdTC.GetDouble(rr.Value)
                            ElseIf Operators.CompareString(name2, "myLastSaBan", False) = 0 Then
                                modSaBan.myLastSaBan = rr.Value
                            ElseIf Operators.CompareString(name2, "myD3DModelMeshFile", False) = 0 Then
                                modSaBan.myD3DModelMeshFile = rr.Value
                            ElseIf Operators.CompareString(name2, "myBillboardMeshFile", False) = 0 Then
                                modSaBan.myBillboardMeshFile = rr.Value
                            ElseIf Operators.CompareString(name2, "mySpriteTexsFile", False) = 0 Then
                                modSaBan.mySpriteTexsFile = rr.Value
                            ElseIf Operators.CompareString(name2, "myImagesPath", False) = 0 Then
                                modSaBan.myImagesPath = rr.Value
                            ElseIf Operators.CompareString(name2, "mySoundsPath", False) = 0 Then
                                modSaBan.mySoundsPath = rr.Value
                            ElseIf Operators.CompareString(name2, "myTMSoundsPath", False) = 0 Then
                                modSaBan.myTMSoundsPath = rr.Value
                            ElseIf Operators.CompareString(name2, "myMuiTenFile", False) = 0 Then
                                modSaBan.myMuiTenFile = rr.Value
                            ElseIf Operators.CompareString(name2, "myExplodeFile", False) = 0 Then
                                modSaBan.myExplodeFile = rr.Value
                            ElseIf Operators.CompareString(name2, "myTextureFile", False) = 0 Then
                                modSaBan.myTextureFile = rr.Value
                            ElseIf Operators.CompareString(name2, "myMap1X", False) = 0 Then
                                modSaBan.myMap1X = modBdTC.GetDouble(rr.Value)
                            ElseIf Operators.CompareString(name2, "myMap1Y", False) = 0 Then
                                modSaBan.myMap1Y = modBdTC.GetDouble(rr.Value)
                            ElseIf Operators.CompareString(name2, "myMap2X", False) = 0 Then
                                modSaBan.myMap2X = modBdTC.GetDouble(rr.Value)
                            ElseIf Operators.CompareString(name2, "myMap2Y", False) = 0 Then
                                modSaBan.myMap2Y = modBdTC.GetDouble(rr.Value)
                            ElseIf Operators.CompareString(name2, "myGridDataFile", False) = 0 Then
                                modSaBan.myGridDataFile = rr.Value
                            ElseIf Operators.CompareString(name2, "myGridDataType", False) = 0 Then
                                modSaBan.myGridDataType = rr.Value
                            ElseIf Operators.CompareString(name2, "myGRID_WIDTH", False) = 0 Then
                                modSaBan.myGRID_WIDTH = Conversions.ToInteger(rr.Value)
                            ElseIf Operators.CompareString(name2, "myGRID_HEIGHT", False) = 0 Then
                                modSaBan.myGRID_HEIGHT = Conversions.ToInteger(rr.Value)
                            ElseIf Operators.CompareString(name2, "mySCALE_FACTOR", False) = 0 Then
                                modSaBan.mySCALE_FACTOR = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "myLightDir", False) = 0 Then
                                Dim value As String = rr.Value
                                Dim array As String() = value.Split(New Char() {","c})
                                If array.GetUpperBound(0) = 2 Then
                                    modSaBan.myLightDir.X = modBdTC.GetSingle(array(0))
                                    modSaBan.myLightDir.Y = modBdTC.GetSingle(array(1))
                                    modSaBan.myLightDir.Z = modBdTC.GetSingle(array(2))
                                End If
                            ElseIf Operators.CompareString(name2, "myCamPos", False) = 0 Then
                                Dim value2 As String = rr.Value
                                Dim array2 As String() = value2.Split(New Char() {","c})
                                If array2.GetUpperBound(0) = 2 Then
                                    modSaBan.myCamPos.X = modBdTC.GetSingle(array2(0))
                                    modSaBan.myCamPos.Y = modBdTC.GetSingle(array2(1))
                                    modSaBan.myCamPos.Z = modBdTC.GetSingle(array2(2))
                                End If
                            End If
                        End While
                    End If
                End If
            End While
        Catch expr_4CE As Exception
            ProjectData.SetProjectError(expr_4CE)
            Dim ex As Exception = expr_4CE
            Throw ex
        End Try
    End Sub

    Public Sub LoadDienTap(ByVal pFileName As String)
        Try
            Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
            modSaBan.XML2DienTap(xmlTextReader)
            xmlTextReader.Close()
        Catch expr_15 As Exception
            ProjectData.SetProjectError(expr_15)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub XML2DienTap(ByVal rr As XmlTextReader)
        Try
            While rr.Read()
                Dim nodeType As XmlNodeType = rr.NodeType
                Dim xmlNodeType As XmlNodeType = nodeType
                If xmlNodeType = xmlNodeType.Element Then
                    Dim name As String = rr.Name
                    If Operators.CompareString(name, "LAST", False) = 0 AndAlso rr.AttributeCount > 0 Then
                        While rr.MoveToNextAttribute()
                            Dim name2 As String = rr.Name
                            If Operators.CompareString(name2, "mySaBanDir", False) = 0 Then
                                modSaBan.mySaBanDir = rr.Value
                            ElseIf Operators.CompareString(name2, "LastBdTC", False) = 0 Then
                                modSaBan.LastBdTC = rr.Value
                            ElseIf Operators.CompareString(name2, "DescColor", False) = 0 Then
                                modSaBan.DescColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            ElseIf Operators.CompareString(name2, "DescFontName", False) = 0 Then
                                modSaBan.DescFontName = rr.Value
                            ElseIf Operators.CompareString(name2, "DescFontSize", False) = 0 Then
                                modSaBan.DescFontSize = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "DescFontStyle", False) = 0 Then
                                modSaBan.DescFontStyle = CType(Conversions.ToInteger(rr.Value), FontStyle)
                            ElseIf Operators.CompareString(name2, "DescTrenColor", False) = 0 Then
                                modSaBan.DescTrenColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            ElseIf Operators.CompareString(name2, "DescTrenFontName", False) = 0 Then
                                modSaBan.DescTrenFontName = rr.Value
                            ElseIf Operators.CompareString(name2, "DescTrenFontSize", False) = 0 Then
                                modSaBan.DescTrenFontSize = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "DescTrenFontStyle", False) = 0 Then
                                modSaBan.DescTrenFontStyle = CType(Conversions.ToInteger(rr.Value), FontStyle)
                            ElseIf Operators.CompareString(name2, "DescGiuaColor", False) = 0 Then
                                modSaBan.DescGiuaColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            ElseIf Operators.CompareString(name2, "DescGiuaFontName", False) = 0 Then
                                modSaBan.DescGiuaFontName = rr.Value
                            ElseIf Operators.CompareString(name2, "DescGiuaFontSize", False) = 0 Then
                                modSaBan.DescGiuaFontSize = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "DescGiuaFontStyle", False) = 0 Then
                                modSaBan.DescGiuaFontStyle = CType(Conversions.ToInteger(rr.Value), FontStyle)
                            ElseIf Operators.CompareString(name2, "TitleColor", False) = 0 Then
                                modSaBan.TitleColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            ElseIf Operators.CompareString(name2, "TitleFontName", False) = 0 Then
                                modSaBan.TitleFontName = rr.Value
                            ElseIf Operators.CompareString(name2, "TitleFontSize", False) = 0 Then
                                modSaBan.TitleFontSize = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "TitleFontStyle", False) = 0 Then
                                modSaBan.TitleFontStyle = CType(Conversions.ToInteger(rr.Value), FontStyle)
                            ElseIf Operators.CompareString(name2, "TitleText", False) = 0 Then
                                modSaBan.TitleText = rr.Value
                            ElseIf Operators.CompareString(name2, "TitlePointX", False) = 0 Then
                                modSaBan.TitlePointX = Conversions.ToInteger(rr.Value)
                            ElseIf Operators.CompareString(name2, "TitlePointY", False) = 0 Then
                                modSaBan.TitlePointY = Conversions.ToInteger(rr.Value)
                            ElseIf Operators.CompareString(name2, "MenuFontName", False) = 0 Then
                                modSaBan.MenuFontName = rr.Value
                            ElseIf Operators.CompareString(name2, "MenuFontSize", False) = 0 Then
                                modSaBan.MenuFontSize = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "MenuFontStyle", False) = 0 Then
                                modSaBan.MenuFontStyle = CType(Conversions.ToInteger(rr.Value), FontStyle)
                            ElseIf Operators.CompareString(name2, "ActColor", False) = 0 Then
                                modSaBan.ActColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            ElseIf Operators.CompareString(name2, "NoActColor", False) = 0 Then
                                modSaBan.NoActColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            ElseIf Operators.CompareString(name2, "BGrColor", False) = 0 Then
                                modSaBan.BGrColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
                            End If
                        End While
                    End If
                End If
            End While
        Catch expr_433 As Exception
            ProjectData.SetProjectError(expr_433)
            Dim ex As Exception = expr_433
            Throw ex
        End Try
    End Sub

    Public Sub DienTap2File(ByVal pFileName As String)
        Dim w As StreamWriter = New StreamWriter(pFileName)
        Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
        modSaBan.DienTap2xml(xmlTextWriter)
        xmlTextWriter.Close()
    End Sub

    Private Sub DienTap2xml(ByRef wr As XmlTextWriter)
        wr.WriteStartElement("LAST")
        wr.WriteAttributeString("mySaBanDir", modSaBan.mySaBanDir)
        wr.WriteAttributeString("LastBdTC", modSaBan.LastBdTC)
        wr.WriteAttributeString("DescColor", Conversions.ToString(modSaBan.DescColor.ToArgb()))
        wr.WriteAttributeString("DescFontName", modSaBan.DescFontName)
        wr.WriteAttributeString("DescFontSize", Conversions.ToString(modSaBan.DescFontSize))
        wr.WriteAttributeString("DescFontStyle", Conversions.ToString(CInt(modSaBan.DescFontStyle)))
        wr.WriteAttributeString("DescTrenColor", Conversions.ToString(modSaBan.DescTrenColor.ToArgb()))
        wr.WriteAttributeString("DescTrenFontName", modSaBan.DescTrenFontName)
        wr.WriteAttributeString("DescTrenFontSize", Conversions.ToString(modSaBan.DescTrenFontSize))
        wr.WriteAttributeString("DescTrenFontStyle", Conversions.ToString(CInt(modSaBan.DescTrenFontStyle)))
        wr.WriteAttributeString("DescGiuaColor", Conversions.ToString(modSaBan.DescGiuaColor.ToArgb()))
        wr.WriteAttributeString("DescGiuaFontName", modSaBan.DescGiuaFontName)
        wr.WriteAttributeString("DescGiuaFontSize", Conversions.ToString(modSaBan.DescGiuaFontSize))
        wr.WriteAttributeString("DescGiuaFontStyle", Conversions.ToString(CInt(modSaBan.DescGiuaFontStyle)))
        wr.WriteAttributeString("TitleColor", Conversions.ToString(modSaBan.TitleColor.ToArgb()))
        wr.WriteAttributeString("TitleFontName", modSaBan.TitleFontName)
        wr.WriteAttributeString("TitleFontSize", Conversions.ToString(modSaBan.TitleFontSize))
        wr.WriteAttributeString("TitleFontStyle", Conversions.ToString(CInt(modSaBan.TitleFontStyle)))
        wr.WriteAttributeString("TitleText", modSaBan.TitleText)
        wr.WriteAttributeString("TitlePointX", Conversions.ToString(modSaBan.TitlePointX))
        wr.WriteAttributeString("TitlePointY", Conversions.ToString(modSaBan.TitlePointY))
        wr.WriteAttributeString("MenuFontName", modSaBan.MenuFontName)
        wr.WriteAttributeString("MenuFontSize", Conversions.ToString(modSaBan.MenuFontSize))
        wr.WriteAttributeString("MenuFontStyle", Conversions.ToString(CInt(modSaBan.MenuFontStyle)))
        wr.WriteAttributeString("ActColor", Conversions.ToString(modSaBan.ActColor.ToArgb()))
        wr.WriteAttributeString("NoActColor", Conversions.ToString(modSaBan.NoActColor.ToArgb()))
        wr.WriteAttributeString("BGrColor", Conversions.ToString(modSaBan.BGrColor.ToArgb()))
        wr.WriteEndElement()
    End Sub

    Public Sub LoadSaBanPos(ByVal pFileName As String)
        Try
            Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
            modSaBan.XML2SaBanPos(xmlTextReader)
            xmlTextReader.Close()
        Catch expr_15 As Exception
            ProjectData.SetProjectError(expr_15)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub XML2SaBanPos(ByVal rr As XmlTextReader)
        Try
            While rr.Read()
                Dim nodeType As XmlNodeType = rr.NodeType
                Dim xmlNodeType As XmlNodeType = nodeType
                If xmlNodeType = xmlNodeType.Element Then
                    Dim name As String = rr.Name
                    If Operators.CompareString(name, "LAST", False) = 0 AndAlso rr.AttributeCount > 0 Then
                        While rr.MoveToNextAttribute()
                            Dim name2 As String = rr.Name
                            If Operators.CompareString(name2, "CamPos", False) = 0 Then
                                Dim value As String = rr.Value
                                Dim array As String() = value.Split(New Char() {";"c})
                                If array.GetUpperBound(0) = 2 Then
                                    modSaBan.myCamPos.X = modBdTC.GetSingle(array(0))
                                    modSaBan.myCamPos.Y = modBdTC.GetSingle(array(1))
                                    modSaBan.myCamPos.Z = modBdTC.GetSingle(array(2))
                                End If
                            ElseIf Operators.CompareString(name2, "CamTarget", False) = 0 Then
                                Dim value2 As String = rr.Value
                                Dim array2 As String() = value2.Split(New Char() {";"c})
                                If array2.GetUpperBound(0) = 2 Then
                                    modSaBan.myCamTarget.X = modBdTC.GetSingle(array2(0))
                                    modSaBan.myCamTarget.Y = modBdTC.GetSingle(array2(1))
                                    modSaBan.myCamTarget.Z = modBdTC.GetSingle(array2(2))
                                End If
                            ElseIf Operators.CompareString(name2, "AngleZ", False) = 0 Then
                                modSaBan.myAngleZ = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "AngleX", False) = 0 Then
                                modSaBan.myAngleX = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "CenterX", False) = 0 Then
                                modSaBan.myCenterX = modBdTC.GetSingle(rr.Value)
                            ElseIf Operators.CompareString(name2, "CenterY", False) = 0 Then
                                modSaBan.myCenterY = modBdTC.GetSingle(rr.Value)
                            End If
                        End While
                    End If
                End If
            End While
        Catch expr_1D1 As Exception
            ProjectData.SetProjectError(expr_1D1)
            Dim ex As Exception = expr_1D1
            Throw ex
        End Try
    End Sub

    Public Sub SaBanPos2File(ByVal pFileName As String)
        Dim w As StreamWriter = New StreamWriter(pFileName)
        Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
        modSaBan.SaBanPos2xml(xmlTextWriter)
        xmlTextWriter.Close()
    End Sub

    Private Sub SaBanPos2xml(ByRef wr As XmlTextWriter)
        wr.WriteStartElement("LAST")
        wr.WriteAttributeString("CamPos", String.Concat(New String() {modSaBan.myCamPos.X.ToString(), ";", modSaBan.myCamPos.Y.ToString(), ";", modSaBan.myCamPos.Z.ToString()}))
        wr.WriteAttributeString("CamTarget", String.Concat(New String() {modSaBan.myCamTarget.X.ToString(), ";", modSaBan.myCamTarget.Y.ToString(), ";", modSaBan.myCamTarget.Z.ToString()}))
        wr.WriteAttributeString("AngleZ", Conversions.ToString(modSaBan.myAngleZ))
        wr.WriteAttributeString("AngleX", Conversions.ToString(modSaBan.myAngleX))
        wr.WriteAttributeString("CenterX", Conversions.ToString(modSaBan.myCenterX))
        wr.WriteAttributeString("CenterY", Conversions.ToString(modSaBan.myCenterY))
        wr.WriteEndElement()
    End Sub

    Public Function GetHDG(ByVal pPT1 As PointF, ByVal pPT2 As PointF) As Double
        ' The following expression was wrapped in a checked-expression
        ' The following expression was wrapped in a unchecked-expression
        Return modSaBan.HieuChinhGoc(CDec((CInt(Math.Round(Math.Atan2(CDec((pPT1.Y - pPT2.Y)), CDec((pPT1.X - pPT2.X))) * 57.29578 + 270.0)))))
    End Function

    Public Function HieuChinhGoc(ByVal pGoc As Double) As Double
        Dim num As Double
        num = pGoc
        While num < 0.0
            num += 360.0
        End While
        While num >= 360.0
            num -= 360.0
        End While
        Return num
    End Function

    Public Sub LoadLastDiaHinh(ByVal pFileName As String)
        Try
            Dim xmlTextReader As XmlTextReader = New XmlTextReader(pFileName)
            modSaBan.XML2LastDiaHinh(xmlTextReader)
            xmlTextReader.Close()
        Catch expr_15 As Exception
            ProjectData.SetProjectError(expr_15)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub XML2LastDiaHinh(ByVal rr As XmlTextReader)
        Try
            While rr.Read()
                Dim nodeType As XmlNodeType = rr.NodeType
                Dim xmlNodeType As XmlNodeType = nodeType
                If xmlNodeType = xmlNodeType.Element Then
                    Dim name As String = rr.Name
                    If Operators.CompareString(name, "PARA", False) = 0 AndAlso rr.AttributeCount > 0 Then
                        While rr.MoveToNextAttribute()
                            Dim name2 As String = rr.Name
                            If Operators.CompareString(name2, "myDiaHinhDef", False) = 0 Then
                                modSaBan.myDiaHinhDef = rr.Value
                            End If
                        End While
                    End If
                End If
            End While
        Catch expr_65 As Exception
            ProjectData.SetProjectError(expr_65)
            Dim ex As Exception = expr_65
            Throw ex
        End Try
    End Sub

    Public Sub LastDiaHinh2File(ByVal pFileName As String)
        Dim w As StreamWriter = New StreamWriter(pFileName)
        Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
        modSaBan.LastDiaHinh2xml(xmlTextWriter)
        xmlTextWriter.Close()
    End Sub

    Private Sub LastDiaHinh2xml(ByRef wr As XmlTextWriter)
        wr.WriteStartElement("PARA")
        wr.WriteAttributeString("myDiaHinhDef", modSaBan.myDiaHinhDef)
        wr.WriteEndElement()
    End Sub

    Public Function LoadPara(ByVal pDefFile As String) As Boolean
        modSaBan.heightData = New Single(-1, -1) {}
        Dim result As Boolean = False
        If modSaBan.File2Para(pDefFile) Then
            If modSaBan.ParaOK() Then
                modSaBan.myDiaHinhDef = pDefFile
                modSaBan.LastDiaHinh2File(modSaBan.myCTpara)
                If Operators.CompareString(modSaBan.myGridDataType, "xyz", False) = 0 Then
                    modSaBan.LoadXYZData(modSaBan.myGridDataFile)
                Else
                    modSaBan.LoadHeightData(modSaBan.myGridDataFile)
                End If
                result = True
            Else
                Interaction.MsgBox("Xem lai '" + pDefFile + "'", MsgBoxStyle.OkOnly, Nothing)
            End If
        End If
        Return result
    End Function

    Private Sub LoadXYZData(ByVal fileName As String)
        ' The following expression was wrapped in a checked-statement
        modSaBan.myGRID_WIDTH += 1
        modSaBan.myGRID_HEIGHT += 1
        modSaBan.heightData = New Single(modSaBan.myGRID_WIDTH - 1 + 1 - 1, modSaBan.myGRID_HEIGHT - 1 + 1 - 1) {}
        Dim arg_3D_0 As Integer = 0
        Dim num As Integer = modSaBan.myGRID_WIDTH - 1
        For i As Integer = arg_3D_0 To num
            Dim arg_49_0 As Integer = 0
            Dim num2 As Integer = modSaBan.myGRID_HEIGHT - 1
            For j As Integer = arg_49_0 To num2
                modSaBan.heightData(i, j) = 0.0F
            Next
        Next
        modSaBan.LoadHArrayFromFile(fileName)
    End Sub

    Private Sub LoadHArrayFromFile(ByVal xyzfile As String)
        ' The following expression was wrapped in a checked-expression
        Dim num As Double = (modSaBan.myMap1X - modSaBan.myMap2X) / CDec((modSaBan.myGRID_WIDTH - 1))
        Dim streamReader As StreamReader = New StreamReader(xyzfile)
        ' The following expression was wrapped in a checked-statement
        Dim text As String
        Do
            text = streamReader.ReadLine()
            If text Is Nothing Then
                Exit Do
            End If
            Dim array As String() = text.Split(New Char() {","c})
            If array.GetLength(0) = 3 Then
                Dim [double] As Double = modBdTC.GetDouble(array(0))
                Dim double2 As Double = modBdTC.GetDouble(array(1))
                If [double] >= modSaBan.myMap2X And [double] <= modSaBan.myMap1X And double2 >= modSaBan.myMap2Y And double2 <= modSaBan.myMap1Y Then
                    ' The following expression was wrapped in a unchecked-expression
                    Dim num2 As Integer = CInt(Math.Round([double] - modSaBan.myMap2X / num))
                    ' The following expression was wrapped in a unchecked-expression
                    Dim num3 As Integer = CInt(Math.Round(double2 - modSaBan.myMap2Y / num))
                    Dim [single] As Single = modBdTC.GetSingle(array(2))
                    If num2 < modSaBan.myGRID_WIDTH And num3 < modSaBan.myGRID_HEIGHT Then
                        modSaBan.heightData(num2, num3) = [single]
                    End If
                End If
            End If
        Loop While text IsNot Nothing
        streamReader.Close()
    End Sub

    Private Sub LoadHeightData(ByVal fileName As String)
        ' The following expression was wrapped in a checked-statement
        modSaBan.heightData = New Single(modSaBan.myGRID_WIDTH - 1 + 1 - 1, modSaBan.myGRID_HEIGHT - 1 + 1 - 1) {}
        If File.Exists(fileName) Then
            Dim streamReader As StreamReader = New StreamReader(fileName)
            For i As Integer = modSaBan.myGRID_HEIGHT - 1 To 0 Step -1
                Dim arg_40_0 As Integer = 0
                Dim num As Integer = modSaBan.myGRID_WIDTH - 1
                For j As Integer = arg_40_0 To num
                    Dim text As String = streamReader.ReadLine()
                    Dim array As String() = text.Split(New Char() {" "c})
                    Dim [single] As Single = modBdTC.GetSingle(array(2))
                    modSaBan.heightData(j, i) = [single]
                Next
            Next
            streamReader.Close()
        Else
            For k As Integer = modSaBan.myGRID_HEIGHT - 1 To 0 Step -1
                Dim arg_AE_0 As Integer = 0
                Dim num2 As Integer = modSaBan.myGRID_WIDTH - 1
                For l As Integer = arg_AE_0 To num2
                    modSaBan.heightData(l, k) = 0.0F
                Next
            Next
        End If
    End Sub
End Module
