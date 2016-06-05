Imports DBiGraphicObjs.DBiGraphicObjects
Imports System.IO
Imports System.Xml
Imports System.Drawing
Imports System.Drawing.Imaging

Imports mySaBanLib
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Public Class frmMain
    Private myPixelsPerGridX As Double
    Private myPixelsPerGridY As Double

    Private myDiaHinh As CTerrain
    Private m_TexImage As Bitmap

    Private heightData(,) As Single

    Private Sub LoadHeightData(ByVal fileName As String)
        ReDim heightData(myGRID_WIDTH - 1, myGRID_HEIGHT - 1)

        Dim line As String
        Dim point() As String
        Dim z As Single

        Dim file As System.IO.StreamReader = New System.IO.StreamReader(fileName)

        For y As Integer = myGRID_HEIGHT - 1 To 0 Step -1
            For x As Integer = 0 To myGRID_WIDTH - 1
                line = file.ReadLine()
                point = line.Split(" ")
                z = System.Convert.ToSingle(point(2))
                heightData(x, y) = z
            Next
        Next
        file.Close()
    End Sub

    Private m_LastMapCX As Double = 0
    Private m_LastMapCY As Double = 0

    Friend myBando As CBanDo
    Public myLastZoom, myLastCX, myLastCY As Double

    Friend mySlides As CSlides
    Private CurrSlide As CSlide

    Private bLoaded As Boolean = False

    Public myDirty As Boolean = False

    Private Sub PopulateList()
        Me.lvPages.Clear()

        Dim mLabel, mTag As String
        Dim mSlide As CSlide
        For Each mSlide In mySlides
            mLabel = mSlide.Value
            mTag = mSlide.ID.ToString
            Dim mItem As ListViewItem = New ListViewItem(mLabel)
            mItem.Tag = mTag
            mItem.ImageIndex = 0
            mItem.StateImageIndex = 0
            mItem.Checked = mSlide.Checked
            lvPages.Items.Add(mItem)
        Next

    End Sub

    Private Sub PopulateForm()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'myBando.StopBlinking()

        Try
            If Me.lvPages.SelectedItems.Count > 0 Then
                Dim itmY As ListViewItem
                Dim iTag As Integer

                itmY = Me.lvPages.SelectedItems(0)
                If Not itmY Is Nothing Then
                    iTag = CType(itmY.Tag, Integer)
                    CurrSlide = mySlides.GetItemByID(iTag)
                    If Not IsNothing(CurrSlide) Then
                        Try
                            myBando.KHsFromString(CurrSlide.Symbols)

                            myTyLeLayKH = CurrSlide.TyLeLayKH
                            myDaLayKH = CurrSlide.DaLayKH
                        Catch
                        End Try
                    End If
                    'Me.txtDescription.Text = CurrSlide.Desc
                    'Me.txtDonViBC.Text = CurrSlide.DonViBC
                    'Me.txtFileSpec.Text = CurrSlide.AttFileName
                    'myTyLeLayKH = CurrSlide.TyLeLayKH
                    'myDaLayKH = CurrSlide.DaLayKH
                End If
                itmY = Nothing

            Else
                AxMap1.CenterX = AxMap1.CenterX
            End If

            'myBando.UnseleKH()
            'AxMap1.ZoomTo(myBando.myZoom, myBando.myCX, myBando.myCY)
            AxMap1.Refresh()
            'AxMap1.CenterX = AxMap1.CenterX
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Pop General Error")
        End Try

        PopulateListKH(Nothing)

        'myBando.StartBlinking()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PopulateForm(ByVal i As Integer)
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim mSlide As CSlide
            Dim mKyHieu As String

            Dim itmY As ListViewItem
            Dim iTag As Integer
            itmY = Me.lvPages.Items(i - 1)
            If Not itmY Is Nothing Then
                iTag = CType(itmY.Tag, Integer)
                mSlide = mySlides.GetItemByID(iTag)
                If Not IsNothing(mSlide) Then
                    mKyHieu = mSlide.Symbols
                    Try
                        myBando.KHsFromString(mKyHieu)
                    Catch
                    End Try
                    mSlide = Nothing
                End If
                itmY = Nothing
            End If
            'myBando.UnseleKH()
            'AxMap1.ZoomTo(myBando.myZoom, myBando.myCX, myBando.myCY)
            'AxMap1.Refresh()
            'myBando.StartBlinking()

        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Pop2 General Error")
        End Try

        'Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FirstSlide()
        HideDrawTools()
        If IsNothing(mySlides) Then
            mySlides = New CSlides
        Else
            mySlides.Clear()
        End If
        CurrSlide = New CSlide("Trang 1", 1, "", True)
        mySlides.Add(CurrSlide)

        'gan luon mytylelaykh co dinh
        GetTyleLayKH()
        CurrSlide.TyLeLayKH = myTyLeLayKH
        CurrSlide.DaLayKH = True

        PopulateList()

        Me.lvPages.Items(0).Selected = True
        PopulateForm()

        'myTyLeLayKH = CDbl(Me.AxMap1.Width * 1000) / CDbl(Me.AxMap1.Zoom * mySoPixelsPer1000m)

    End Sub

    Private Sub HideDrawTools()
        If Not IsNothing(fCacKyHieu) Then
            Try
                fCacKyHieu.Close()
            Catch ex As Exception
            End Try
        End If

        myBando.SelectedSymbol = Nothing

        Me.TableToolStripButton.Visible = False
        Me.OptionsToolStripButton.Visible = False
        Me.UndoToolStripButton.Visible = False
        Me.RedoToolStripButton.Visible = False
        Me.LineToolStripButton.Visible = False
        Me.PolygonToolStripButton.Visible = False
        Me.ArcToolStripButton.Visible = False
        Me.EllipseToolStripButton.Visible = False
        Me.RectangleToolStripButton.Visible = False
        Me.MuiTenDonToolStripButton.Visible = False
        Me.MuiTenDacToolStripButton.Visible = False
        'Me.MuiTenToolStripSplitButton.Visible = False
        'Me.MuiTenHoToolStripSplitButton.Visible = False
        Me.CurveToolStripSplitButton.Visible = False
        Me.ClosedCurveToolStripButton.Visible = False
        Me.SongSongKinToolStripButton.Visible = False
        Me.TextToolStripButton.Visible = False
        Me.SymbolToolStripButton.Visible = False

        Me.CNToolStripButton.Checked = False

        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.myMapTool = CBanDo.MapTools.None
        Me.ToolStripStatusLabel3.Text = ""
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'myDiaHinh = Nothing

        'myBando.StopBlinking()
        myBando.Dispose()

        fMain = Nothing
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'RegisterOK = GetReg() 'True
        RegisterOK = True
        If RegisterOK = False Then
            MessageBox.Show("Chua Dang ky. Stop.")
            End
        End If

        fMain = Me
        'Me.Location = New Point(0, 0)

        'Directory.SetCurrentDirectory(Application.StartupPath + "\..\..\..\..\Map\")
        myCacKyHieuUDL = My.Settings.myCacKyHieuUDL
        'Dim mIndex As Integer = myCacKyHieuUDL.LastIndexOf("\"c)
        'Dim mPath As String = myCacKyHieuUDL.Substring(0, mIndex + 1)
        'Directory.SetCurrentDirectory(mPath)

        myDefaFileName = My.Settings.myDefaFileName

        LoadDefa(myDefaFileName)

        myHienDanhSach = My.Settings.myHienDanhSach

        mySoPixelsPer1000m = My.Settings.mySoPixelsPer1000m
        myKHQSZoom = My.Settings.myKHQSZoom
        myKHQSMWidth = My.Settings.myKHQSMWidth
        myTinhChinhGocQuay = My.Settings.myTinhChinhGocQuay

        myTextureFile = My.Settings.myTextureFile
        myGridDataFile = My.Settings.myGridDataFile
        myGRID_WIDTH = My.Settings.myGRID_WIDTH
        myGRID_HEIGHT = My.Settings.myGRID_HEIGHT
        mySCALE_FACTOR = My.Settings.mySCALE_FACTOR

        myMap1X = My.Settings.myMap1X
        myMap1Y = My.Settings.myMap1Y
        myMap2X = My.Settings.myMap2X
        myMap2Y = My.Settings.myMap2Y

        myFlag3DsFile = My.Settings.myFlag3DsFile
        'myResourcePath = My.Settings.myResourcePath
        Dim mIndex As Integer = myFlag3DsFile.LastIndexOf("\"c)
        Dim mPath As String = myFlag3DsFile.Substring(0, mIndex + 1)
        myResourcePath = mPath
        Directory.SetCurrentDirectory(mPath)

        'myEffectFile = My.Settings.myEffectFile

        my3DSoPixelsPer1000m = My.Settings.my3DSoPixelsPer1000m

        Try
            myMapNhoGst = My.Settings.myMapNhoGst
        Catch ex As Exception
        End Try
        Try
            myMapGst = My.Settings.myMapGst
        Catch ex As Exception
        End Try

        myBando = New CBanDo(Me.AxMap1, Me, Me.Panel2DMap)


        MyOtherLineStyle = New COtherLineStyle
        CreateMyMenu()

        'FirstSlide()
        'LastBdTC = myNewBdTC '"New.bdtc"
        'Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"

        Me.DanhSachToolStripMenuItem.Checked = myHienDanhSach 'False
        DanhSachToolStripMenuItem_CheckStateChanged(Nothing, Nothing)

        Me.WindowState = FormWindowState.Maximized

        FirstSlide()
        LastBdTC = myNewBdTC '"New.bdtc"
        Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"

        InitTerrain()

        bLoaded = True
    End Sub

    Private Function GetReg() As Boolean
        Dim mRegisterOK As Boolean = False
        Dim f1 As New frmRegister
        mRegisterOK = f1.IsRegOK()
        If mRegisterOK = False Then
            If f1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                mRegisterOK = f1.RegKQ
            End If
        End If
        Return mRegisterOK
    End Function

    Private Sub SaBanToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaBanToolStripMenuItem.CheckStateChanged
        If Me.SaBanToolStripMenuItem.Checked Then
            'myDiaHinh = New CDiaHinh(Me, Me.Panel3D, m_TexFileName)
            Me.Panel3D.Visible = True
            Me.Splitter3D.Visible = True
        Else
            Me.Panel3D.Visible = False
            Me.Splitter3D.Visible = False
        End If
    End Sub

    Private Sub SaBanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaBanToolStripMenuItem.Click
        Me.SaBanToolStripMenuItem.Checked = Not Me.SaBanToolStripMenuItem.Checked
    End Sub

    Private Sub DanhSachToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DanhSachToolStripMenuItem.CheckStateChanged
        If Me.DanhSachToolStripMenuItem.Checked Then
            Me.Splitter1.Visible = True
            Me.Panel1.Visible = True
        Else
            Me.Panel1.Visible = False
            Me.Splitter1.Visible = False
        End If
    End Sub

    Private Sub DanhSachToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DanhSachToolStripMenuItem.Click
        Me.DanhSachToolStripMenuItem.Checked = Not Me.DanhSachToolStripMenuItem.Checked
    End Sub

    Private Sub SelectorToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectorToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        If Me.CNToolStripButton.Checked Then
            Me.myBando.OnCapNhatKH()
        Else
            HideDrawTools()
        End If

    End Sub

    Private Sub PanToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miPanTool
        myBando.myMapTool = CBanDo.MapTools.None
        Me.ToolStripStatusLabel3.Text = ""
    End Sub

    Private Sub ZoomInToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomInToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miZoomInTool
        myBando.myMapTool = CBanDo.MapTools.None
        Me.ToolStripStatusLabel3.Text = ""
    End Sub

    Private Sub ZoomOutToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomOutToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miZoomOutTool
        myBando.myMapTool = CBanDo.MapTools.None
        Me.ToolStripStatusLabel3.Text = ""
    End Sub

    Public Sub ChangeDesc(ByVal pSymbol As CSymbol, ByVal pParent As Form)
        Dim f As New dlgInputBox
        f.Label1.Text = "Ghi chú:"
        f.TextBox1.Text = pSymbol.Description
        If f.ShowDialog(pParent) = Windows.Forms.DialogResult.OK Then
            pSymbol.Description = f.TextBox1.Text
        End If
        Me.PopulateListKH(pSymbol)
    End Sub

    Private Sub MenuItemFileClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mSeleItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim mTag As String = mSeleItem.Tag
        Dim data() As String = mTag.Split("|"c)
        If data.GetUpperBound(0) > 0 Then
            Dim iNhom As Integer = data(0) 'mSeleParent.index
            Dim iMuc As Integer = data(1)
            Dim iStyle As Integer = MyOtherLineStyle.GetStyleIndex(iNhom, iMuc)
            defaMyLineStyle = iStyle + 1
            Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
            Me.myBando.OnDrawObj("Curve")
            Me.ToolStripStatusLabel3.Text = "vẽ " & MyOtherLineStyle.StyleName(iStyle) & ": Click để chọn các điểm, RightClick để kết thúc."
        End If

    End Sub

    Private Sub CreateMyMenu()
        Dim handlerFile As EventHandler = New EventHandler(AddressOf MenuItemFileClick)

        Dim mNhomCount = MyOtherLineStyle.NhomCount
        Dim pMenuItems(mNhomCount - 1) As ToolStripMenuItem 'System.Windows.Forms.MenuItem
        For i As Integer = 0 To mNhomCount - 1
            pMenuItems(i) = New ToolStripMenuItem(MyOtherLineStyle.NhomName(i))
            Me.CurveToolStripSplitButton.DropDownItems.Add(pMenuItems(i))
            If MyOtherLineStyle.StyleCount(i) > 0 Then
                For j As Integer = 0 To MyOtherLineStyle.StyleCount(i) - 1
                    Dim mIndex As Integer = MyOtherLineStyle.GetStyleIndex(i, j)
                    Dim mBitmap As Bitmap = getImage(mIndex + 1)
                    Dim mToolStripMenuItem As ToolStripMenuItem = New ToolStripMenuItem(MyOtherLineStyle.StyleName(mIndex) & " ", mBitmap, handlerFile)
                    mToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                    mToolStripMenuItem.Tag = i.ToString("00") & "|" & j.ToString("00")
                    pMenuItems(i).DropDownItems.Add(mToolStripMenuItem)
                Next
            End If
        Next
    End Sub

    Private Function getImage(ByVal StyleIndex As Integer) As Bitmap
        Dim mNewBmp As New Bitmap(64, 24)
        Dim g As Graphics = Graphics.FromImage(mNewBmp)
        VeLineStyle(g, StyleIndex, 0, 0)
        Return (mNewBmp)
    End Function

    Private Sub VeLineStyle(ByVal g As Graphics, ByVal StyleIndex As Integer, ByVal pLeft As Single, ByVal pTop As Single)
        Dim mPts(1) As PointF
        mPts(0).X = 8
        mPts(0).Y = 12
        mPts(1).X = 64
        mPts(1).Y = 12

        Dim mObjs() As GraphicObject = MyOtherLineStyle.GetGraphicObjs(StyleIndex, mPts)
        Dim mySymbol As New CGraphicObjs
        For Each mObj As GraphicObject In mObjs
            'CType(mObj, ShapeGraphic).StyleWidth = CType(mObj, ShapeGraphic).StyleWidth * 0.7
            mySymbol.Add(mObj)
        Next
        Dim gCon As Drawing2D.GraphicsContainer
        gCon = g.BeginContainer
        g.TranslateTransform(pLeft, pTop)
        mySymbol.DrawObjects(g, 0.8)
        'mySymbol.DrawObjects(g, 1)

        g.EndContainer(gCon)
    End Sub

    Public Sub PopulateListKH(ByVal pSymbol As CSymbol)
        Cursor.Current = Cursors.WaitCursor
        lstCacKyHieu.DataSource = Nothing
        lstCacKyHieu.DataSource = Me.myBando.drawingSymbols

        Dim i As Integer = -1
        Dim index As Integer = -1
        Try
            'lstCacKyHieu.Items.Clear()
            For Each aSymbol As CSymbol In Me.myBando.drawingSymbols
                i += 1
                'lstCacKyHieu.Items.Add(aSymbol)
                If aSymbol.Equals(pSymbol) Then
                    index = i
                End If
            Next

            If lstCacKyHieu.Items.Count > 0 Then
                If index > -1 Then
                    lstCacKyHieu.SetSelected(index, True)
                Else
                    lstCacKyHieu.SetSelected(0, True)
                End If
            End If
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "General Error")
        End Try

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub StatusBarToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.CheckStateChanged
        Me.StatusStrip1.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusBarToolStripMenuItem.Checked = Not Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub BdTCToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BdTCToolStripMenuItem.CheckStateChanged
        If Me.BdTCToolStripMenuItem.Checked Then
            Me.Panel2DMap.Visible = True
            Me.Splitter3D.Visible = True
            Me.Panel3D.Dock = DockStyle.Bottom
        Else
            Me.Panel2DMap.Visible = False
            Me.Splitter3D.Visible = False
            Me.Panel3D.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub BdTCToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BdTCToolStripMenuItem.Click
        Me.BdTCToolStripMenuItem.Checked = Not Me.BdTCToolStripMenuItem.Checked
    End Sub

    Private Sub MuiTenToolStripSplitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        myMuiTenDoRong = defaMuiTenDoRong
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTen")
    End Sub

    Private Sub MuiTenToToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        myMuiTenDoRong = defaMuiTenDoRong * 1.5
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTen")
    End Sub

    Private Sub MuiTenNhoToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        myMuiTenDoRong = defaMuiTenDoRong * 0.5
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTen")
    End Sub

    Private Sub MuiTenKhacToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mPhanTram As Integer = CInt(myMuiTenDoRong * 100 / defaMuiTenDoRong)
        Dim f As New dlgInputBox
        f.Label1.Text = "Bao nhiêu %:"
        f.TextBox1.Text = mPhanTram.ToString
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            mPhanTram = Val(f.TextBox1.Text)
            If mPhanTram > 0 Then
                myMuiTenDoRong = defaMuiTenDoRong * mPhanTram / 100
                Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
                Me.myBando.OnDrawObj("MuiTen")
            End If
        End If
    End Sub

    Private Sub MuiTenHoToolStripSplitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        myMuiTenDoRong = defaMuiTenDoRong
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTenHo")
    End Sub

    Private Sub MuiTenHoToToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        myMuiTenDoRong = defaMuiTenDoRong * 1.5
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTenHo")
    End Sub

    Private Sub MuiTenHoNhoToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        myMuiTenDoRong = defaMuiTenDoRong * 0.5
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTenHo")
    End Sub

    Private Sub MuiTenHoKhacToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mPhanTram As Integer = CInt(myMuiTenDoRong * 100 / defaMuiTenDoRong)
        Dim f As New dlgInputBox
        f.Label1.Text = "Bao nhiêu %:"
        f.TextBox1.Text = mPhanTram.ToString
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            mPhanTram = Val(f.TextBox1.Text)
            If mPhanTram > 0 Then
                myMuiTenDoRong = defaMuiTenDoRong * mPhanTram / 100
                Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
                Me.myBando.OnDrawObj("MuiTenHo")
            End If
        End If
    End Sub

    Private Sub MuiTenDonToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MuiTenDonToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTenDon")
    End Sub

    Private Sub EllipseToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EllipseToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Ellipse")
    End Sub

    Private Sub RectangleToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RectangleToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Rectangle")
    End Sub

    Private Sub CurveToolStripSplitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CurveToolStripSplitButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Curve")
    End Sub

    Private Sub ClosedCurveToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClosedCurveToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("ClosedCurve")
    End Sub

    Private Sub SongSongKinToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SongSongKinToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("SongSongKin")
    End Sub

    Private Sub TextToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Text")
    End Sub

    Private Sub SymbolToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SymbolToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool

        If IsNothing(fCacKyHieu) Then
            'If myLoaiKH_ID = 0 Then
            'myLoaiKH_ID = fCacKyHieu.GetFirstLoaiKH()
            'End If

            Me.myBando.myMapCurrTool = Me.AxMap1.CurrentTool
            Dim f As New dlgCacKyHieu
            'f.Size = New Size(defaImageWidth * 3 + defaHorizontalSpacing * 4, Me.Height - 20)
            'f.Location = Me.Location

            fCallForm = Me 'm_ParentForm
            Me.ToolStripStatusLabel3.Text = "AddKH: Click để chọn vi tri ky hieu."

            f.TopMost = True
            f.Show()
        End If

        Me.myBando.OnCapNhatKH()

    End Sub

    Private Sub CNToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CNToolStripButton.Click
        If Me.CNToolStripButton.Checked Then
            Me.TableToolStripButton.Visible = True
            Me.OptionsToolStripButton.Visible = True
            Me.UndoToolStripButton.Visible = True
            Me.RedoToolStripButton.Visible = True
            Me.LineToolStripButton.Visible = True
            Me.PolygonToolStripButton.Visible = True
            Me.ArcToolStripButton.Visible = True
            Me.EllipseToolStripButton.Visible = True
            Me.RectangleToolStripButton.Visible = True
            Me.MuiTenDonToolStripButton.Visible = True
            Me.MuiTenDacToolStripButton.Visible = True
            'Me.MuiTenToolStripSplitButton.Visible = True
            'Me.MuiTenHoToolStripSplitButton.Visible = True
            Me.CurveToolStripSplitButton.Visible = True
            Me.ClosedCurveToolStripButton.Visible = True
            Me.SongSongKinToolStripButton.Visible = True
            Me.TextToolStripButton.Visible = True
            Me.SymbolToolStripButton.Visible = True

            Me.myBando.OnCapNhatKH()

        Else
            HideDrawTools()
            'Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
            'Me.myBando.myMapTool = CBanDo.MapTools.None
        End If

        Me.ToolStripStatusLabel3.Text = ""
        'Me.myMap.mySymbolTool = CMapEdit.SymbolTools.None
        'Me.myMap.Surface.SurfaceTool = SurfaceCtrl.enumSurfaceTool.None
    End Sub

    Private Sub UpdateSlide()
        HideDrawTools()

        'If myDirty Then
        'myDirty = False
        If Not IsNothing(CurrSlide) Then
            If Not IsNothing(Me.myBando.drawingSymbols) Then
                Dim mKyHieu As String = Me.myBando.drawingSymbols.KH2String(Me.AxMap1)
                mySlides.Update(CurrSlide, mKyHieu, myTyLeLayKH, myDaLayKH)
            End If
        End If
        'End If
    End Sub

    Private Sub NewPageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewPageToolStripMenuItem.Click
        If Not IsNothing(mySlides) Then

            UpdateSlide()

            'Dim mSlideId As Integer = mySlides.GetMaxID + 1
            'Dim mSlide As New CSlide("Trang " & mSlideId.ToString, mSlideId, "", True)
            'mySlides.Add(mSlide)
            Dim mSlideId As Integer = mySlides.GetMaxID + 1
            Dim mNewSlide As CSlide = New CSlide("Trang " & mSlideId.ToString, mSlideId, "", True)
            With mNewSlide
                '.Symbols = CurrSlide.Symbols
                .DaLayKH = CurrSlide.DaLayKH
                .TyLeLayKH = CurrSlide.TyLeLayKH
            End With
            mySlides.Add(mNewSlide)

            PopulateList()
            Me.lvPages.Items(mySlides.Count - 1).Selected = True
            PopulateForm()

        End If

    End Sub

    Private Sub NhapNhayKH()
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool

        If Not IsNothing(Me.lstCacKyHieu.SelectedItem) Then
            lstCacKyHieu.Enabled = False
            'Me.myBando.StopBlinking()
            Try
                Dim oSymbol As CSymbol = Me.lstCacKyHieu.SelectedItem
                'Dim mPT As New Point(oSymbol.GocX, oSymbol.GocY)
                'Me.myMap.NhapNhayDT(mPT)
                If Me.AxMap1.IsPointVisible(oSymbol.GocX, oSymbol.GocY) = False Then
                    'Me.myBando.CenterTo(mPT.X, mPT.Y)
                    Me.AxMap1.CenterX = oSymbol.GocX
                    Me.AxMap1.CenterY = oSymbol.GocY
                End If
                Me.myBando.NhapNhaySymbol(oSymbol, 5)
            Catch
            End Try
            lstCacKyHieu.Enabled = True

            'Me.myBando.StartBlinking()
        End If
    End Sub

    Private Sub lstCacKyHieu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCacKyHieu.DoubleClick
        NhapNhayKH()
    End Sub

    Private Sub NhapNhayToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NhapNhayToolStripMenuItem.Click
        NhapNhayKH()
    End Sub

    Public Sub XoaKH(ByVal pSymbol As CSymbol)
        Try
            Dim i As Integer = Me.lstCacKyHieu.Items.IndexOf(pSymbol)
            Dim index As Integer = 0

            Me.myBando.drawingSymbols.Remove(pSymbol)
            Me.myBando.RefreshMap() ' .Surface.Invalidate()
            lstCacKyHieu.Items.Remove(pSymbol)
            If i < (Me.lstCacKyHieu.Items.Count) Then
                index = i
            Else
                index = i - 1
            End If
            If index > -1 Then
                Me.lstCacKyHieu.SelectedIndex = index
            End If
        Catch
        End Try
    End Sub

    Private Sub XoaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles XoaToolStripMenuItem.Click
        If Not IsNothing(Me.lstCacKyHieu.SelectedItem) Then
            lstCacKyHieu.Enabled = False
            Dim mKyHieu As CSymbol = lstCacKyHieu.SelectedItem
            If MessageBox.Show(Me, "Thật sự muốn xoá Ký hiệu này?", "Xoá:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'XoaKH(mKyHieu)
                Me.myBando.SelectedSymbol = mKyHieu
                Me.myBando.OnXoa()
            End If
            lstCacKyHieu.Enabled = True
        End If
    End Sub

    Private Sub XoaTatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles XoaTatToolStripMenuItem.Click
        Me.lstCacKyHieu.Enabled = False
        If Me.myBando.drawingSymbols.Count > 0 Then
            Try
                If MessageBox.Show(Me, "Thật sự muốn xoá tất cả các Ký hiệu?", "Xoá:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.myBando.drawingSymbols.Clear()
                    myBando.RefreshMap()
                    Me.PopulateListKH(Nothing)
                End If
            Catch
            End Try
        End If
        Me.lstCacKyHieu.Enabled = True
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        If Not IsNothing(Me.lstCacKyHieu.SelectedItem) Then
            Dim oSymbol As CSymbol = Me.lstCacKyHieu.SelectedItem
            ChangeDesc(oSymbol, Me)
        End If
    End Sub

    Private Sub lvPages_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles lvPages.AfterLabelEdit
        If Not IsNothing(CurrSlide) Then
            CurrSlide.Value = e.Label
        End If
    End Sub

    Private Sub PageReNameToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageReNameToolStripMenuItem.Click
        If Me.lvPages.SelectedItems.Count > 0 Then
            Me.lvPages.SelectedItems(0).BeginEdit()
        End If
    End Sub

    Private Sub PageDeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageDeleteToolStripMenuItem.Click
        If Me.lvPages.SelectedItems.Count > 0 Then
            Dim i As Integer = CType(Me.lvPages.SelectedItems(0).Tag, Integer)
            Dim aSlide As CSlide = mySlides.GetItemByID(i)
            mySlides.Remove(aSlide)

            PopulateList()
        End If

    End Sub

    Private Sub DuplicatePageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DuplicatePageToolStripMenuItem.Click
        If Not IsNothing(mySlides) Then
            UpdateSlide()

            'Dim mKyHieu As String = CurrSlide.Symbols
            Dim mSlideId As Integer = mySlides.GetMaxID + 1
            'CurrSlide = New CSlide("Trang " & mSlideId.ToString, mSlideId, "", True)
            'CurrSlide.Symbols = mKyHieu
            'mySlides.Add(CurrSlide)
            Dim mNewSlide As CSlide = New CSlide("Trang " & mSlideId.ToString, mSlideId, "", True)
            With mNewSlide
                .Symbols = CurrSlide.Symbols
                .DaLayKH = CurrSlide.DaLayKH
                .TyLeLayKH = CurrSlide.TyLeLayKH
            End With
            mySlides.Add(mNewSlide)

            PopulateList()
            Me.lvPages.Items(mySlides.Count - 1).Selected = True
            PopulateForm()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'StatusBar1.Panels(2).Text = ""
        'myBando.myMapTool = CBanDo.MapTools.None
        Dim mFileName As String
        Dim openFileDialog1 As New OpenFileDialog

        'openFileDialog1.InitialDirectory = Application.StartupPath
        openFileDialog1.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            mFileName = openFileDialog1.FileName
            If mFileName.Length > 0 Then
                myBando.drawingSymbols.Clear()
                myBando.XoaUndoStack()

                If IsNothing(mySlides) Then
                    mySlides = New CSlides
                Else
                    mySlides.Clear()
                End If

                If LoadSlides(mFileName) = True Then
                    Me.AxMap1.ZoomTo(BDZoomLevel, BDKinhDo, BDViDo)

                    HideDrawTools()

                    PopulateList()
                    Me.lvPages.Items(0).Selected = True
                    PopulateForm()

                    myBando.UnseleKH()

                End If
                LastBdTC = mFileName
                Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"
            End If
        End If
    End Sub

    Private Function LoadSlides(ByVal pFileName As String) As Boolean
        Dim bKQ As Boolean = False

        Dim sr As StreamReader
        Dim strKQ As String = ""
        Try
            ' Create a StreamReader using a Shared (static) File class.
            sr = File.OpenText(pFileName)
            ' Read the entire file in one pass, and add the contents to 
            '   txtFileText text box.
            strKQ = sr.ReadToEnd()
        Catch exc As Exception
            ' Show the exception to the user.
            MsgBox("File could not be opened or read." + vbCrLf + _
                "Please verify that the filename is correct, " + _
                "and that you have read permissions for the desired " + _
                "directory." + vbCrLf + vbCrLf + "Exception: " + exc.Message)
        Finally
            ' Close the object if it has been created.
            If Not sr Is Nothing Then
                sr.Close()
            End If
        End Try

        If strKQ.Length > 8 Then
            If strKQ.StartsWith("<Slides") = True Then
                Dim mSlides As CSlides = Str2Slides(strKQ)
                If mSlides.Count > 0 Then
                    'If IsNothing(mySlides) Then
                    'mySlides = New CSlides
                    'Else
                    'mySlides.Clear()
                    'End If

                    Dim i As Integer = mySlides.Count '0
                    Dim mSlide As CSlide
                    For Each mSlide In mSlides
                        i += 1
                        mSlide.ID = i

                        'gan myTyLeLayKH co dinh luon:
                        mSlide.TyLeLayKH = myTyLeLayKH
                        mSlide.DaLayKH = True

                        mySlides.Add(mSlide)
                    Next
                    bKQ = True
                End If
            Else
                MsgBox("Không được ...")
            End If

        End If

        Return bKQ

    End Function

    Private Function Str2Slides(ByVal pStr As String) As CSlides
        Dim mSlides As CSlides = Nothing

        If pStr.StartsWith("<Slides") = True Then
            Dim nt As NameTable = New NameTable
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(nt)
            nsmgr.AddNamespace("bk", "urn:sample")

            'Create the XmlParserContext.
            Dim context As XmlParserContext = New XmlParserContext(Nothing, nsmgr, Nothing, XmlSpace.None)
            'Create the reader. 
            Dim rr As XmlTextReader = New XmlTextReader(pStr, XmlNodeType.Element, context)


            mSlides = XML2Slides(rr)
            rr.Close()

            'OluoiXRate = Me.AxMap1.Distance(OLuoiKinhDo, OLuoiViDo, OLuoiKinhDo + 1, OLuoiViDo) / OLuoiSize
            'OluoiYRate = Me.AxMap1.Distance(OLuoiKinhDo, OLuoiViDo, OLuoiKinhDo, OLuoiViDo + 1) / OLuoiSize
            'BDKinhDo = OLuoiKinhDo + 0.5 / OluoiXRate
            'BDViDo = OLuoiViDo + 0.5 / OluoiYRate

        End If

        Return mSlides
    End Function

    Private Function XML2Slides(ByVal rr As XmlTextReader) As CSlides
        Dim mSlides As New CSlides
        Dim oNodeType As XmlNodeType
        Dim mName As String = ""
        'Dim mDesc As String = ""
        'Dim mDonViBC As String = ""
        'Dim mAttFileName As String = ""
        Dim mSymbols As String = ""
        Dim mChecked As Boolean = False
        Dim mDaLayKH As Boolean = False
        Dim mTyleLayKH As Single = 1

        'Dim mBDTyLeBanDo As Integer = 0 'BDTyLeBanDo
        Dim mBDKinhDo As Double = Me.AxMap1.CenterX
        Dim mBDViDo As Double = Me.AxMap1.CenterY
        Dim mBDZoomLevel As Integer = Me.AxMap1.Zoom

        'Dim mOLuoiX As Integer = 82
        'Dim mOLuoiY As Integer = 171
        'Dim mOLuoiKinhDo As Double = 104.255
        'Dim mOLuoiViDo As Double = 17.0
        'Dim mOLuoiSize As Integer = 1000
        'Friend OluoiXRate As Single = 100
        'Friend OluoiYRate As Single = 120
        'Dim mBDTyLeLayKH As Integer = BDTyLeLayKH

        Try
            Do While rr.Read
                oNodeType = rr.NodeType
                Select Case oNodeType
                    Case XmlNodeType.Element
                        Select Case rr.Name
                            Case "Slides"
                                If rr.AttributeCount > 0 Then
                                    Do While rr.MoveToNextAttribute
                                        Select Case rr.Name
                                            Case "BDLON"
                                                mBDKinhDo = CDbl(rr.Value)
                                            Case "BDLAT"
                                                mBDViDo = CDbl(rr.Value)
                                            Case "BDZOOM"
                                                mBDZoomLevel = rr.Value
                                        End Select
                                    Loop
                                End If
                            Case "Slide"
                                mName = ""
                                mSymbols = ""
                                'mDesc = ""
                                'mDonViBC = ""
                                'mAttFileName = ""
                                mTyleLayKH = 1
                                mChecked = False
                                mDaLayKH = False
                                If rr.AttributeCount > 0 Then
                                    Do While rr.MoveToNextAttribute
                                        Select Case rr.Name
                                            Case "Name"
                                                mName = rr.Value
                                            Case "Checked"
                                                mChecked = IIf(rr.Value = "True", True, False)
                                            Case "DaLayKH"
                                                mDaLayKH = IIf(rr.Value = "True", True, False)
                                            Case "TyLe"
                                                mTyleLayKH = 1
                                                Try
                                                    mTyleLayKH = CSng(rr.Value)
                                                Catch ex As Exception
                                                End Try
                                                'Case "Desc"
                                                'mDesc = rr.Value
                                                'Case "DonViBC"
                                                'mDonViBC = rr.Value
                                                'Case "AFN"
                                                'mAttFileName = rr.Value
                                            Case "Symbols"
                                                mSymbols = rr.Value
                                        End Select
                                    Loop
                                End If
                        End Select
                    Case XmlNodeType.EndElement
                        Select Case rr.Name
                            Case "Slide"
                                Dim mSlide As CSlide = New CSlide
                                mSlide.Value = mName
                                mSlide.Symbols = mSymbols
                                mSlide.Checked = mChecked
                                mSlide.DaLayKH = mDaLayKH
                                'mSlide.Desc = mDesc
                                'mSlide.DonViBC = mDonViBC
                                'mSlide.AttFileName = mAttFileName
                                mSlide.TyLeLayKH = mTyleLayKH
                                mSlides.Add(mSlide)

                        End Select
                End Select
            Loop
            'BDTyLeBanDo = mBDTyLeBanDo
            'OLuoiX = mOLuoiX
            'OLuoiY = mOLuoiY
            'OLuoiKinhDo = mOLuoiKinhDo
            'OLuoiViDo = mOLuoiViDo
            'OLuoiSize = mOLuoiSize

            BDKinhDo = mBDKinhDo
            BDViDo = mBDViDo
            BDZoomLevel = mBDZoomLevel
        Catch
            MsgBox("Khong doc duoc XML Nay")
        End Try

        Return mSlides
    End Function

    Private Sub ToolStripMenuBDView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuBDView.Click
        If Me.myBando.bBanDo2Loaded = False Then
            If Not IsNothing(fBanDoNho) Then
                fBanDoNho.Close()
            End If
            fCallForm = Me
            fBanDoNho = New dlgBanDoNho
            fBanDoNho.Show(Me)
        Else
            If Not IsNothing(fBanDoNho) Then
                fBanDoNho.Close()
            End If
        End If
        Me.ToolStripMenuBDView.Checked = Me.myBando.bBanDo2Loaded
    End Sub

    Private Sub ToolStripMenuCacLopBD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuCacLopBD.Click
        Me.myBando.CacLopBD()
    End Sub

    Private Sub ToolStripMenuLuuGeoSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuLuuGeoSet.Click
        Me.myBando.LuuGeoSet()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'myBando.StopBlinking()
        'mySlides.Clear()
        'mySlides = Nothing
        myBando.drawingSymbols.Clear()
        myBando.XoaUndoStack()
        'myBando.Dispose()
        'myBando = Nothing
        'myBando = New CBanDo(Me.AxMap1, Me, Me.Panel2DMap)
        myBando.Zoom1X()

        FirstSlide()
        LastBdTC = myNewBdTC '"New.bdtc"
        Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"

    End Sub

    Private Sub TrangSauToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrangSauToolStripMenuItem.Click
        If Me.lvPages.Items.Count > 0 Then
            Dim mIndex As Integer = 0
            For i As Integer = 0 To Me.lvPages.Items.Count - 1
                If Me.lvPages.Items(i).Selected Then
                    mIndex = i
                    Exit For
                End If
            Next
            If mIndex < (Me.lvPages.Items.Count - 1) Then
                UpdateSlide()
                Me.lvPages.Items(mIndex).Selected = False
                Me.lvPages.Items(mIndex + 1).Selected = True
                PopulateForm()
            Else
                MsgBox("Trang cuối rồi")
            End If
        End If
    End Sub

    Private Sub TrangTruocToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrangTruocToolStripMenuItem.Click
        If Me.lvPages.Items.Count > 0 Then
            Dim mIndex As Integer = 0
            For i As Integer = 0 To Me.lvPages.Items.Count - 1
                If Me.lvPages.Items(i).Selected Then
                    mIndex = i
                    Exit For
                End If
            Next
            If mIndex > 0 Then
                UpdateSlide()
                Me.lvPages.Items(mIndex).Selected = False
                Me.lvPages.Items(mIndex - 1).Selected = True
                PopulateForm()
            Else
                MsgBox("Trang đầu rồi")
            End If
        End If

    End Sub

    Private Sub LineToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LineToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Line")
    End Sub

    Private Sub PolygonToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PolygonToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Polygon")
    End Sub

    Private Sub UndoToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UndoToolStripButton.Click
        myBando.OnUndoClick()
    End Sub

    Private Sub RedoToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RedoToolStripButton.Click
        myBando.OnRedoClick()
    End Sub

    Private Sub TableToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Table")
    End Sub

    Private Sub OptionsToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptionsToolStripButton.Click
        Dim f As Form = New dlgOptions
        fCallForm = Me
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Defa2File(myDefaFileName)
        End If
        'e.Button.Pushed = False
    End Sub

    Private Sub Zoom1XToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Zoom1XToolStripButton.Click
        myBando.Zoom1X()
    End Sub

    Private Sub ZoomToToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomToToolStripMenuItem.Click
        Dim f As New dlgZoomTo
        f.ShowDialog(Me)
    End Sub

    Private Sub lvPages_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPages.Click
        lvPages.Enabled = False

        UpdateSlide()

        PopulateForm()

        lvPages.Enabled = True
    End Sub

    Public Function GetTyleLayKH() As Single
        Dim kq As Single = myTyLeLayKH '1
        If myDaLayKH = False Then
            myTyLeLayKH = CDbl(Me.AxMap1.Width * 1000) / CDbl(Me.AxMap1.Zoom * mySoPixelsPer1000m)
            'CurrSlide.DaLayKH = True
        End If
        kq = myTyLeLayKH
        Return kq
    End Function

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If Not IsNothing(mySlides) Then
            UpdateSlide()

            Dim saveFileDialog1 As New SaveFileDialog
            Dim mFileName As String

            saveFileDialog1.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                mFileName = saveFileDialog1.FileName
                If mFileName.Length > 0 Then
                    SaveBDTC(mFileName)
                    LastBdTC = mFileName
                    Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"
                End If
            End If
        End If

    End Sub

    Private Sub SaveBDTC(ByVal mFileName As String)
        Dim i As Integer
        For i = 0 To Me.lvPages.Items.Count - 1
            mySlides(i).Checked = Me.lvPages.Items(i).Checked
        Next

        Dim strKQ As String = ""
        Try
            strKQ = mySlides.Slides2String(AxMap1)
        Catch ex As Exception
        End Try

        If strKQ.Length > 8 Then
            Dim sw2 As New StreamWriter(mFileName)
            sw2.Write(strKQ)
            sw2.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If Not IsNothing(mySlides) Then
            UpdateSlide()
            If LastBdTC = myNewBdTC Then
                Dim saveFileDialog1 As New SaveFileDialog
                Dim mFileName As String

                saveFileDialog1.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
                saveFileDialog1.FilterIndex = 1
                saveFileDialog1.RestoreDirectory = True

                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    mFileName = saveFileDialog1.FileName
                    If mFileName.Length > 0 Then
                        LastBdTC = mFileName
                        Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"
                    End If
                End If
            End If
            SaveBDTC(LastBdTC)
        End If
    End Sub

    Private Function isCheckedItem() As Boolean
        Dim i As Integer
        For i = 0 To Me.lvPages.Items.Count - 1
            If Me.lvPages.Items(i).Checked Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

    Private Sub ShowAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowAllToolStripMenuItem.Click
        If isCheckedItem() Then
            UpdateSlide()

            'myBando.StopBlinking()

            Dim f As New dlgShow
            f.iCurrSlide = Me.lvPages.SelectedIndices.Item(0)
            f.ShowDialog(Me)

            'myBando.StartBlinking()
        Else
            MsgBox("Khong con Trang nao duoc chon.")
        End If

    End Sub

    Private Sub AxMap1_MapDraw(ByVal sender As Object, ByVal e As AxMapXLib.CMapXEvents_MapDrawEvent) Handles AxMap1.MapDraw
        If e.flag = 2 Then  'miDrawEnd
            If Me.ToolStripMenuBDView.Checked Then
                On Error Resume Next
                fBanDoNho.UpdateHinhChuNhat()
            End If
            If (Me.AxMap1.CenterX <> m_LastMapCX) Or (Me.AxMap1.CenterY <> m_LastMapCY) Then
                'myDiaHinh.ChangeFocus(Me.AxMap1.CenterX, Me.AxMap1.CenterY)
                ChangeDHFocus(Me.AxMap1.CenterX, Me.AxMap1.CenterY)
            End If
        End If

    End Sub

    Private Sub ChangeDHFocus(ByVal pLon As Double, ByVal pLat As Double)
        If ((pLon > myMap1X) And (pLon < myMap2X)) _
            And ((pLat < myMap1Y) And (pLat > myMap2Y)) Then
            Dim mSurfPos As System.Drawing.PointF = GetSurfPosition(pLon, pLat)
            myDiaHinh.ChangeFocus(mSurfPos.X / m_TexImage.Width, (m_TexImage.Height - mSurfPos.Y) / m_TexImage.Height)
            m_LastMapCX = pLon 'Me.AxMap1.CenterX
            m_LastMapCY = pLat 'Me.AxMap1.CenterY
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        intMonitorW = My.Computer.Screen.WorkingArea.Width
        intMonitorH = My.Computer.Screen.WorkingArea.Height

        'Me.Width = intMonitorW
    End Sub

    Private Sub DrawSymbolToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DrawSymbolToolStripButton.Click
        HienKyHieu()
    End Sub

    Private Sub HideSymbolToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HideSymbolToolStripButton.Click
        XoaKyHieu()
    End Sub

    Private Sub PhanLoaiKyHieuToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhanLoaiKyHieuToolStripMenuItem.Click
        Dim f As New dlgPhanLoaiKH
        f.ShowDialog(Me)
    End Sub

    Private Sub MuiTenDacToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MuiTenDacToolStripButton.Click
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("MuiTenDac")
    End Sub

    Private Sub AddPagesFromToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddPagesFromToolStripMenuItem.Click
        UpdateSlide()

        Dim mFileName As String
        Dim openFileDialog1 As New OpenFileDialog

        openFileDialog1.InitialDirectory = Application.StartupPath
        openFileDialog1.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            mFileName = openFileDialog1.FileName
            If mFileName.Length > 0 Then
                myBando.drawingSymbols.Clear()
                myBando.XoaUndoStack()
                If LoadSlides(mFileName) = True Then
                    Me.AxMap1.ZoomTo(BDZoomLevel, BDKinhDo, BDViDo)

                    HideDrawTools()

                    PopulateList()
                    Me.lvPages.Items(0).Selected = True
                    PopulateForm()

                    myBando.UnseleKH()

                End If
                'LastBdTC = mFileName
                'Me.Text = "Bản đồ tác chiến (" & LastBdTC & ")"
            End If
        End If

    End Sub

    Private Sub ArcToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ArcToolStripButton.Click
        defaMyLineStyle = 0
        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miArrowTool
        Me.myBando.OnDrawObj("Arc")
    End Sub

    Private Sub RullerToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RullerToolStripButton.Click
        myBando.OnDoKhoangCach()
    End Sub

    'Phan Dia hinh:
    Private m_Symbol3Objs As ArrayList
    'Private m_TexObjs As ArrayList
    'Private m_NotTexObjName = "Ký hiệu mới"

    Private Sub InitTerrain()
        LoadHeightData(myGridDataFile)

        myDiaHinh = New CTerrain(Me.Panel3D, heightData, mySCALE_FACTOR)

        m_TexImage = New Bitmap(myTextureFile)
        'myDiaHinh.LoadMemStream(m_TexImage)
        myPixelsPerGridX = CDbl(m_TexImage.Width) / (myGRID_WIDTH - 1)
        myPixelsPerGridY = CDbl(m_TexImage.Height) / (myGRID_HEIGHT - 1)

        mySurf2X = m_TexImage.Width
        mySurf2Y = m_TexImage.Height

        'm_OWidth = CDbl(m_TexImage.Width) / (m_Width)
        'm_OHeight = CDbl(m_TexImage.Height) / (m_Height)

        myDiaHinh.InitTerrain(m_TexImage, New Vector3(0, -44, -22), New Vector3(0, 0, 0), _
        -Math.PI / 7, New Vector3(-15.0F, -15.0F, -20.0F), New Vector3(0.0F, 10.0F, 5.0F))

        m_Symbol3Objs = New ArrayList
        'm_TexObjs = New ArrayList

        'AddHandler Me.MouseWheel, AddressOf Me.frmMain_MouseWheel

        myDiaHinh.LoadModelMeshs("D3DModelMesh.xml")

        myDiaHinh.LoadBillboardMeshs("D3DBillboardMesh.xml")
    End Sub

    Private Sub HienKyHieu()
        LoadSymbols()

        m_TexImage = New Bitmap(myTextureFile)
        DrawSymbol(m_TexImage)
        'Me.ExportSymbols()
        myDiaHinh.LoadMemStream(m_TexImage)

        'myDiaHinh.OnDeviceReset(Nothing, Nothing)
    End Sub

    Public Sub XoaKyHieu()
        Me.myDiaHinh.ClearModels()

        m_TexImage = New Bitmap(myTextureFile)
        myDiaHinh.LoadMemStream(m_TexImage)

        'myDiaHinh.OnDeviceReset(Nothing, Nothing)
    End Sub

    Public Function GetSymbolType(ByVal pSymbol As CSymbol) As String
        Dim Kq As String = "TexObj"
        Dim mIndex As Integer
        mIndex = myDiaHinh.GetModelMeshIndex(pSymbol.Description)
        If mIndex > -1 Then
            Kq = "Model"
        Else
            mIndex = myDiaHinh.GetBillboardMeshIndex(pSymbol.Description)
            If mIndex > -1 Then
                Kq = "Billboard"
            End If
        End If
        Return Kq
    End Function

    Private Sub LoadSymbols()
        Me.myDiaHinh.ClearModels()
        Me.myDiaHinh.ClearBillboards()
        m_Symbol3Objs.Clear()

        Dim m_OWidth As Double = CDbl(m_TexImage.Width * 1000D) / (myGRID_WIDTH - 1) / 1000
        Dim m_OHeight As Double = CDbl(m_TexImage.Height * 1000D) / (myGRID_HEIGHT - 1) / 1000

        For Each aSB As CSymbol In myBando.drawingSymbols
            Dim mSurfPos As System.Drawing.PointF = GetSurfPosition(aSB.GocX, aSB.GocY)
            Dim mIndex As Integer
            mIndex = myDiaHinh.GetModelMeshIndex(aSB.Description)
            If mIndex > -1 Then
                Dim mSX As Single = CDbl(mSurfPos.X) / m_OWidth
                Dim mSY As Single = CDbl(myGRID_HEIGHT - 1) - CDbl(mSurfPos.Y) / m_OHeight
                Dim mPos As Vector3 = New Vector3(mSX, mSY, -7)
                myDiaHinh.Load1Model(aSB.Description, mIndex, mPos)
            Else
                mIndex = myDiaHinh.GetBillboardMeshIndex(aSB.Description)
                If mIndex > -1 Then
                    Dim mSX As Single = CDbl(mSurfPos.X) / m_OWidth
                    Dim mSY As Single = CDbl(myGRID_HEIGHT - 1) - CDbl(mSurfPos.Y) / m_OHeight
                    Dim mPos As Vector3 = New Vector3(mSX, mSY, -7)
                    myDiaHinh.Load1Billboard(aSB.Description, mIndex, mPos)
                Else
                    Dim Scale As Single = (aSB.Zoom / aSB.MWidth) * (CDbl(my3DSoPixelsPer1000m) / 1000)

                    Dim mGObjs As New CGraphicObjs
                    For Each aGObj As GraphicObject In aSB.GObjs
                        Dim mGobj As GraphicObject = aGObj.Clone
                        mGObjs.Add(mGobj)
                    Next
                    Dim mSymbolObj As New CSymbol3(aSB.Description, mSurfPos, mGObjs)
                    mSymbolObj.Zoom = Scale

                    m_Symbol3Objs.Add(mSymbolObj)
                End If
            End If
        Next

    End Sub

    Private Sub DrawSymbol(ByVal bmpImage As Image)
        Dim g As Graphics = Graphics.FromImage(bmpImage)
        For Each aSymbol As CSymbol3 In m_Symbol3Objs
            aSymbol.Draw(g)
            'Dim rect As Rectangle = aSymbol.GetBounds()
            'g.DrawRectangle(New Pen(Color.Black), rect)
        Next
        'bmpImage.Save("images\map.jpg")
    End Sub

    Private Sub ExportModels(ByVal pFileName As String)
        Dim sw As New StreamWriter(pFileName)
        Dim wr As XmlTextWriter = New XmlTextWriter(sw)

        'Models2xml(wr)
        Dim i As Integer = 0
        Dim mName As String
        Dim iMesh As Integer

        wr.WriteStartElement("Models")

        For Each aModel As CModel In myDiaHinh.Models
            i += 1
            mName = aModel.Name  'aModel.ModelMesh.myName 
            iMesh = myDiaHinh.ModelMeshs.IndexOf(aModel.ModelMesh)
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

    Private Sub ExportBillboards(ByVal pFileName As String)
        Dim sw As New StreamWriter(pFileName)
        Dim wr As XmlTextWriter = New XmlTextWriter(sw)

        'Billboards2xml(wr)
        Dim i As Integer = 0
        Dim mName As String
        Dim iMesh As Integer

        wr.WriteStartElement("Billboards")

        For Each aBillboard As CBillboard In myDiaHinh.Billboards
            i += 1
            mName = aBillboard.Name  'aModel.ModelMesh.myName 
            iMesh = myDiaHinh.BillboardMeshs.IndexOf(aBillboard.BillboardMesh)
            wr.WriteStartElement("Billboard")
            wr.WriteAttributeString("Name", mName)
            wr.WriteAttributeString("iMesh", iMesh.ToString)
            wr.WriteAttributeString("X", aBillboard.Position.X.ToString)
            wr.WriteAttributeString("Y", aBillboard.Position.Y.ToString)
            wr.WriteAttributeString("Z", aBillboard.Z.ToString)
            'wr.WriteElementString("ID", mSlide.ID.ToString)
            wr.WriteEndElement()
        Next
        wr.WriteEndElement()

        wr.Close()

        'MsgBox("Export Billboards xong.")

    End Sub

    Private Function IsActiveSymbol(ByVal pName As String, ByVal pActions As List(Of CActionDef)) As Boolean
        Dim kq As Boolean = False
        If pName.Length > 0 Then
            For Each aAction As CActionDef In pActions
                If aAction.ObjName = pName Then
                    kq = True
                    Exit For
                End If
            Next
        End If
        Return kq
    End Function

    Private Sub ExportTexObjs(ByVal pFileName As String, ByVal pActions As List(Of CActionDef))
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

        strKQ &= " />"
        Return strKQ
    End Function

    Private Sub Panel3D_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3D.MouseClick
        Me.Panel3D.Select()
    End Sub


    Private Sub XemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XemToolStripMenuItem.Click
        'myBando.StopBlinking()
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(mySaBanDefFileName)
        If fileReader.Length > 0 Then
            mySaBanDir = fileReader
        End If
        'Dim MyName As String = Dir(mySaBanDir, vbDirectory)
        'If MyName = mySaBanDir Then

        If My.Computer.FileSystem.DirectoryExists(mySaBanDir) Then
            If My.Computer.FileSystem.FileExists(mySaBanDir & "\MyMenu.xml") Then
                Dim f = New Dlg3DShow
                Dim mTexImage As Bitmap = New Bitmap(mySaBanDir & "\DienTapMap.jpg")

                f.ShowDialog(mTexImage, heightData, myDiaHinh.cameraPos * 1.4, myDiaHinh.cameraTarget * 1.4, mySaBanDir & "\MyMenu.xml")
                mTexImage.Dispose()
                f.Dispose()
            Else
                MsgBox("Không thấy file: " & mySaBanDir & "\MyMenu.xml")
            End If
        Else
            MsgBox("Không thấy thư mục: " & mySaBanDir)
        End If
        'myBando.StartBlinking()
    End Sub

    Public Sub ExportCacDT(ByVal pActions As List(Of CActionDef))
        LoadSymbols()

        ExportModels(mySaBanDir & "\D3DModels.xml")
        ExportBillboards(mySaBanDir & "\D3DBillboards.xml")
        ExportTexObjs(mySaBanDir & "\D3DTexObjs.xml", pActions)
    End Sub

    Private Sub MoTaDienBienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoTaDienBienToolStripMenuItem.Click
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(mySaBanDefFileName)
        If fileReader.Length > 0 Then
            'MsgBox("Dir: " & fileReader)
            mySaBanDir = fileReader
        End If
        Dim f As New dlgActions
        f.TopMost = True
        f.Show(mySaBanDir & "\MyMenu.xml", Me)
    End Sub

End Class
