Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports DienTapLib
Imports Microsoft.DirectX
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Xml
Imports XuLyKHLib

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

    Public Sub New(ByVal pMap As AxMap, ByVal pForm As frmMain, ByVal pheightData As Single(,), ByVal pDecSepa As Char, ByVal pGrpSepa As Char)
        MyBase.New(pForm.Panel3D, pheightData, modSaBan.mySCALE_FACTOR, pDecSepa, pGrpSepa)
        Me.m_AngleZ = 0.0F
        Me.m_AngleX = 0.0F
        Me.m_LastMapCX = 0.0
        Me.m_LastMapCY = 0.0
        Me.m_ParentForm = pForm
        Me.m_Map = pMap
        Me.heightData = pheightData
    End Sub

    Public Sub InitDiaHinh(ByVal pCamPos As Vector3)
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
        Dim pcameraTarget As Vector3 = New Vector3(0.0F, 0.0F, 0.0F)
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

    Public Function GetSymbolType(ByVal pSymbol As CSymbol) As String
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

    ''' <summary>
    ''' '-- frmMain --
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadSymbols()
        MyBase.ClearModels()
        MyBase.ClearBillboards()
        Me.m_Symbol3Objs.Clear()
        Dim num As Double
        Dim num2 As Double
        ' The following expression was wrapped in a checked-statement
        num = Convert.ToDouble(Decimal.Multiply(New Decimal(Me.m_TexImage.Width), New Decimal(1000L))) / CDec((modSaBan.myGRID_WIDTH - 1)) / 1000.0
        num2 = Convert.ToDouble(Decimal.Multiply(New Decimal(Me.m_TexImage.Height), New Decimal(1000L))) / CDec((modSaBan.myGRID_HEIGHT - 1)) / 1000.0
        Dim graphics As Graphics = Drawing.Graphics.FromImage(Me.m_TexImage)
        Try
            Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
            While enumerator.MoveNext()
                Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
                Dim surfPosition As PointF = modSaBan.GetSurfPosition(cSymbol.GocX, cSymbol.GocY)
                Dim valueX As Single = CSng((CDec(surfPosition.X) / num))
                ' The following expression was wrapped in a checked-expression
                Dim valueY As Single = CSng((CDec((modSaBan.myGRID_HEIGHT - 1)) - CDec(surfPosition.Y) / num2))
                Dim dHeading As Single = -CTerrain.DegreeToRadian(cSymbol.Heading)
                Dim pPos As Vector3 = New Vector3(valueX, valueY, -7.0F)
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
                            '                   Dim enumerator2 As IEnumerator
                            '                   If TypeOf enumerator2 Is IDisposable Then
                            '(TryCast(enumerator2, IDisposable)).Dispose()
                            '                   End If
                        End Try
                        Dim cSymbol2 As CSymbol3 = New CSymbol3(cSymbol.Description, surfPosition, cGraphicObjs)
                        cSymbol2.Zoom = zoom
                        cSymbol2.Heading = cSymbol.Heading
                        Me.m_Symbol3Objs.Add(cSymbol2)
                    End If
                End If
            End While
        Finally
            '       Dim enumerator As IEnumerator
            '       If TypeOf enumerator Is IDisposable Then
            '(TryCast(enumerator, IDisposable)).Dispose()
            '       End If
        End Try
    End Sub

    Private Sub Draw3(ByVal g As Graphics, ByVal pSymbol As CSymbol3)
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
                    'ProjectData.SetProjectError(expr_104)
                    'ProjectData.ClearProjectError()
                End Try
            End While
        Finally
            '       Dim enumerator As IEnumerator
            '       If TypeOf enumerator Is IDisposable Then
            '(TryCast(enumerator, IDisposable)).Dispose()
            '       End If
        End Try
        pSymbol.GObjs.DrawObjects(g, CSng(pSymbol.Zoom))
        g.EndContainer(container)
    End Sub

    Private Sub DrawSymbol3(ByVal pbmpImage As Image)
        Dim g As Graphics = Graphics.FromImage(pbmpImage)
        Try
            Dim enumerator As IEnumerator = Me.m_Symbol3Objs.GetEnumerator()
            While enumerator.MoveNext()
                Dim pSymbol As CSymbol3 = CType(enumerator.Current, CSymbol3)
                Me.Draw3(g, pSymbol)
            End While
        Finally
            '       Dim enumerator As IEnumerator
            '       If TypeOf enumerator Is IDisposable Then
            '(TryCast(enumerator, IDisposable)).Dispose()
            '       End If
        End Try
    End Sub

    ''' <summary>
    ''' '-- frmMain --
    ''' </summary>
    ''' <param name="pFileName"></param>
    ''' <remarks></remarks>
    Private Sub ExportModels(ByVal pFileName As String)
        Dim sw As New StreamWriter(pFileName)
        Dim wr As XmlTextWriter = New XmlTextWriter(sw)

        'Models2xml(wr)
        Dim i As Integer = 0
        Dim mName As String
        Dim iMesh As Integer

        wr.WriteStartElement("Models")

        For Each aModel As CModel In Models
            i += 1
            mName = aModel.Name  'aModel.ModelMesh.myName 
            iMesh = ModelMeshs.IndexOf(aModel.ModelMesh)
            wr.WriteStartElement("Model")
            wr.WriteAttributeString("Name", mName)
            wr.WriteAttributeString("iMesh", iMesh.ToString)
            wr.WriteAttributeString("X", aModel.X.ToString)
            wr.WriteAttributeString("Y", aModel.Y.ToString)
            wr.WriteAttributeString("Z", aModel.Z.ToString)
            'wr.WriteElementString("ID", mSlide.ID.ToString)
            wr.WriteEndElement()
        Next
        wr.WriteEndElement()

        wr.Close()

        'MsgBox("Export Models xong.")

    End Sub

    ''' <summary>
    ''' '-- frmMain --
    ''' </summary>
    ''' <param name="pFileName"></param>
    ''' <remarks></remarks>
    Private Sub ExportBillboards(ByVal pFileName As String)
        Dim sw As New StreamWriter(pFileName)
        Dim wr As XmlTextWriter = New XmlTextWriter(sw)

        'Billboards2xml(wr)
        Dim i As Integer = 0
        Dim mName As String
        Dim iMesh As Integer

        wr.WriteStartElement("Billboards")

        For Each aBillboard As CBillboard In Billboards
            i += 1
            mName = aBillboard.Name  'aModel.ModelMesh.myName 
            iMesh = BillboardMeshs.IndexOf(aBillboard.BillboardMesh)
            wr.WriteStartElement("Billboard")
            wr.WriteAttributeString("Name", mName)
            wr.WriteAttributeString("iMesh", iMesh.ToString)
            wr.WriteAttributeString("X", aBillboard.Position.X.ToString)
            wr.WriteAttributeString("Y", aBillboard.Position.Y.ToString)
            wr.WriteAttributeString("Z", aBillboard.Z.ToString)
            'wr.WriteElementString("ID", mSlide.ID.ToString)
            wr.WriteAttributeString("Heading", aBillboard.angleZ.ToString())
            wr.WriteEndElement()
        Next
        wr.WriteEndElement()

        wr.Close()

        'MsgBox("Export Billboards xong.")

    End Sub

    ''' <summary>
    ''' '-- frmMain --
    ''' Phiên bản mới CActDef sửa thành CActDef
    ''' </summary>
    ''' <param name="pName"></param>
    ''' <param name="pActions"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsActiveSymbol(ByVal pName As String, ByVal pActions As List(Of CActDef)) As Boolean
        Dim kq As Boolean = False
        If pName.Length > 0 Then
            For Each aAction As CActDef In pActions
                If aAction.ObjName = pName Then
                    kq = True
                    Exit For
                End If
            Next
        End If
        Return kq
    End Function


    ''' <summary>
    ''' '-- frmMain --
    ''' Phiên bản mới CActDef sửa thành CActDef 
    ''' </summary>
    ''' <param name="pFileName"></param>
    ''' <param name="pActions"></param>
    ''' <remarks></remarks>
    Private Sub ExportTexObjs(ByVal pFileName As String, ByVal pActions As List(Of CActDef))
        Dim i As Integer = 0
        Dim mImageFile As String

        Dim TexObjNames As Dictionary(Of String, String) = New Dictionary(Of String, String)

        Dim mTexImage As Bitmap = New Bitmap(myTextureFile)
        Dim g As Graphics = Graphics.FromImage(mTexImage)

        Using sw As StreamWriter = New StreamWriter(pFileName)
            sw.WriteLine("<TexObjs>")
            For Each aSymbol As CSymbol3 In m_Symbol3Objs
                If IsActiveSymbol(aSymbol.Name, pActions) Then
                    'Try
                    'TexObjNames.Add(aSymbol.Name, aSymbol.Name)
                    i += 1
                    mImageFile = mySaBanDir & "\TexObj" & i.ToString("000") & ".bmp"
                    sw.WriteLine(GetTexObjStr(aSymbol, mImageFile))
                    'Catch ex As Exception
                    'End Try
                Else
                    aSymbol.Draw(g)
                End If
            Next
            sw.WriteLine("</TexObjs>")

            sw.Close()
        End Using

        mTexImage.Save(mySaBanDir & "\DienTapMap.jpg")
        mTexImage.Dispose()
    End Sub

    ''' <summary>
    ''' '-- frmMain --
    ''' Phiên bản mới CActDef sửa thành CActDef 
    ''' </summary>
    ''' <param name="aSymbol"></param>
    ''' <param name="mImageFile"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetTexObjStr(ByVal aSymbol As CSymbol3, ByVal mImageFile As String) As String
        Dim strKQ As String = "<TexObj"
        Dim mName As String
        Dim mWidth As Integer
        Dim mHeight As Integer
        Dim mShiftX As Integer
        Dim mShiftY As Integer

        Dim rect As Rectangle
        Dim mMinX As Integer
        Dim mMinY As Integer
        Dim mMaxX As Integer
        Dim mMaxY As Integer

        rect = aSymbol.GetBounds()
        mMinX = Math.Floor(CDbl(rect.X) / myPixelsPerGridX)
        mMinY = Math.Floor(CDbl(rect.Y) / myPixelsPerGridY)
        mMaxX = Math.Ceiling(CDbl(rect.X + rect.Width) / myPixelsPerGridX)
        mMaxY = Math.Ceiling(CDbl(rect.Y + rect.Height) / myPixelsPerGridY)

        mName = aSymbol.Name
        mWidth = mMaxX - mMinX
        mHeight = mMaxY - mMinY
        mShiftX = mMinX
        mShiftY = myGRID_HEIGHT - 1 - mMaxY

        Dim mSymbolRect As Rectangle = New Rectangle(mMinX * myPixelsPerGridX, mMinY * myPixelsPerGridY, (mMaxX - mMinX) * myPixelsPerGridX, (mMaxY - mMinY) * myPixelsPerGridY)
        Dim mSymbolImage As Bitmap = New Bitmap(mSymbolRect.Width, mSymbolRect.Height)

        aSymbol.GocX -= mSymbolRect.X
        aSymbol.GocY -= mSymbolRect.Y
        Dim g As Graphics = Graphics.FromImage(mSymbolImage)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias '.HighQuality
        g.Clear(Color.White)
        aSymbol.Draw(g)
        g.Dispose()

        mSymbolImage.Save(mImageFile, Imaging.ImageFormat.Bmp)

        strKQ &= " Name=""" & mName & """"
        strKQ &= " ImageFile=""" & mImageFile & """"
        strKQ &= " Width=""" & mWidth & """"
        strKQ &= " Height=""" & mHeight & """"
        strKQ &= " ShiftX=""" & mShiftX & """"
        strKQ &= " ShiftY=""" & mShiftY & """"
        strKQ &= " ImageWidth=""" + mSymbolRect.Width + """"
        strKQ &= " ImageHeight=""" + mSymbolRect.Height + """"
        strKQ &= " />"
        Return strKQ
    End Function

    ''' <summary>
    ''' '-- frmMain --
    ''' </summary>
    ''' <param name="pActions"></param>
    ''' <remarks></remarks>
    Public Sub ExportCacDT(ByVal pActions As List(Of CActDef))
        Me.LoadSymbols()
        Me.ExportModels(modSaBan.mySaBanDir + "\D3DModels.xml")
        Me.ExportBillboards(modSaBan.mySaBanDir + "\D3DBillboards.xml")
        Me.ExportTexObjs(modSaBan.mySaBanDir + "\D3DTexObjs.xml", pActions)
    End Sub

    ''' <summary>
    ''' frmMain.vb
    ''' </summary>
    ''' <param name="pLon"></param>
    ''' <param name="pLat"></param>
    ''' <remarks></remarks>
    Public Sub ChangeDHFocus(ByVal pLon As Double, ByVal pLat As Double)
        If (Me.m_Map.CenterX <> Me.m_LastMapCX Or Me.m_Map.CenterY <> Me.m_LastMapCY) AndAlso (pLon > modSaBan.myMap2X And pLon < modSaBan.myMap1X And (pLat > modSaBan.myMap2Y And pLat < modSaBan.myMap1Y)) Then
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
