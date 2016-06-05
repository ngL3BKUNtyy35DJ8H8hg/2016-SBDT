Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class dlgShow
    Private mySlides As CSlides

    Private myBanDo As CBanDo
    Private SlideCount As Integer
    Public iCurrSlide As Integer = 0

    Private ZoomDelta As Single = 0.05

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgShow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myBanDo.Dispose()
        myBanDo = Nothing
    End Sub

    Private Sub dlgShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.TopMost = True
        Me.WindowState = FormWindowState.Maximized

        Try
            myBanDo = New CBanDo(Me.AxMap1, fMain)

            mySlides = New CSlides
            For Each aSlide As CSlide In fMain.mySlides
                mySlides.Add(aSlide)
            Next

            SlideCount = mySlides.Count
            'iCurrSlide = 0

        Catch ex As Exception
            MessageBox.Show("SaiRoi: " & ex.Message)
            Me.Dispose()
        End Try

        AxMap1.ZoomTo(fMain.AxMap1.Zoom, fMain.AxMap1.CenterX, fMain.AxMap1.CenterY)

        ShowSlide(iCurrSlide)
    End Sub

    Private Sub ShowSlide(ByVal pSlideIndex As Integer)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try

            'myBanDo.StopBlinking()

            Dim mSlide As CSlide = mySlides(pSlideIndex)
            If Not IsNothing(mSlide) Then
                myBanDo.KHsFromString(mSlide.Symbols)
                mSlide = Nothing
            End If

            AxMap1.Refresh()
            'myBanDo.StartBlinking()
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Show Error")
        End Try

        Me.Cursor = System.Windows.Forms.Cursors.Default

        iCurrSlide = pSlideIndex
        Me.AxMap1.Select()

        Me.AxMap1.CurrentTool = MapXLib.ToolConstants.miPanTool
    End Sub


    Private Sub Exp2PPT(ByVal pFileSpec As String)
        'Dim oApp As PowerPoint.Application
        'Dim oPres As PowerPoint.Presentation
        ''Start Powerpoint and make its window visible but minimized.
        'oApp = New PowerPoint.Application
        'oApp.Visible = True
        'oApp.WindowState = PowerPoint.PpWindowState.ppWindowMinimized

        ''Create a new presentation based on the specified template.
        'oPres = oApp.Presentations.Add(True)  'Open(sTemplate, , , True)

        'Dim sngSlideW As Single = oApp.ActivePresentation.PageSetup.SlideWidth
        'Dim sngSlideH As Single = oApp.ActivePresentation.PageSetup.SlideHeight

        ''MsgBox("W=" & sngSlideW.ToString & "; H=" & sngSlideH.ToString)

        ''AxMap1.ZoomTo(myLastZoom, myLastCX, myLastCY)
        'Dim mFileName As String = Application.StartupPath & "\\temp.emf"
        ''Exp2EMF(mFileName)
        'myBando.drawingSymbols.Clear()
        'ExpBanDo2EMF(mFileName)

        'Dim i As Integer
        'For i = 1 To mySlides.Count

        '    Dim oSlide As PowerPoint.Slide = oPres.Slides.Add(i, PowerPoint.PpSlideLayout.ppLayoutBlank)

        '    Dim oShape As PowerPoint.Shape
        '    oShape = oSlide.Shapes.AddPicture(mFileName, _
        '    Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, _
        '    0, 0, sngSlideW, sngSlideH)

        '    Dim mTyleX As Single = sngSlideW / AxMap1.MapScreenWidth
        '    Dim mTyleY As Single = sngSlideH / AxMap1.MapScreenHeight

        '    oShape = Nothing

        '    Dim g As Graphics = Me.AxMap1.CreateGraphics
        '    Dim hdc As IntPtr = g.GetHdc()

        '    'PopulateForm(i)
        '    ShowSlide(i - 1)

        '    Dim mRect As New RectangleF(-20, -20, AxMap1.MapScreenWidth + 40, AxMap1.MapScreenHeight + 40)
        '    Dim j As Integer = 0
        '    Dim mSymbol As CSymbol
        '    For Each mSymbol In myBando.drawingSymbols
        '        If mSymbol.HitTest(AxMap1, mRect) Then
        '            Dim mData() As String = mFileName.Split(".")
        '            j += 1
        '            Dim mFileName1 As String = mData(0) & j.ToString & "." & mData(1)
        '            Dim mMetafile1 As New Metafile(mFileName1, hdc)
        '            Dim g31 As Graphics = Graphics.FromImage(mMetafile1)

        '            mSymbol.Draw(Me.AxMap1, g31)
        '            Dim mFileHeader As MetafileHeader = mMetafile1.GetMetafileHeader()
        '            mMetafile1.Dispose()
        '            mMetafile1 = Nothing

        '            Dim mMetafile2 As New Metafile(mFileName1)
        '            Dim mRF2 As RectangleF = mMetafile2.GetBounds(System.Drawing.GraphicsUnit.Pixel)
        '            mMetafile2.Dispose()
        '            mMetafile2 = Nothing

        '            Dim mX2, mY2 As Single
        '            mX2 = mRF2.Left * mTyleX
        '            mY2 = mRF2.Top * mTyleY
        '            Dim mW2, mH2 As Single
        '            mW2 = mRF2.Width * mTyleX
        '            mH2 = mRF2.Height * mTyleY
        '            Dim oShape1 As PowerPoint.Shape = oSlide.Shapes.AddPicture(mFileName1, _
        '            Microsoft.Office.Core.MsoTriState.msoFalse, _
        '            Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, mW2, mH2)
        '            With oShape1
        '                .IncrementLeft(mX2)
        '                .IncrementTop(mY2)
        '            End With

        '            oShape1 = Nothing
        '            g31.Dispose()
        '        End If
        '    Next
        '    oSlide = Nothing
        'Next

        'oPres.SaveAs(pFileSpec)

        ''Close the presentation without saving changes and quit PowerPoint.
        'oPres.Saved = True
        'oPres.Close()
        'oPres = Nothing
        'oApp.Quit()
        'oApp = Nothing
        'GC.Collect()
    End Sub

    Private Sub ExpBanDo2EMF(ByVal pFileSpec As String)
        Dim mMapFileName As String = "MapTemp.wmf"
        Dim mOutFileName As String = pFileSpec

        AxMap1.ExportMap(mMapFileName, MapXLib.ExportFormatConstants.miFormatWMF)
        Dim myMapfile As New System.Drawing.Imaging.Metafile(mMapFileName)

        'Dim mBoundRect As Rectangle = New Rectangle(0, 0, AxMap1.MapScreenWidth, AxMap1.MapScreenHeight)
        Dim g As Graphics = Me.AxMap1.CreateGraphics
        Dim hdc As IntPtr = g.GetHdc()
        Dim mMetafile As New System.Drawing.Imaging.Metafile(mOutFileName, hdc)
        Dim g3 As Graphics = Graphics.FromImage(mMetafile)


        g3.DrawImage(myMapfile, 0, 0)
        myMapfile = Nothing

        mMetafile.Dispose()
        mMetafile = Nothing
    End Sub

    Private Sub ToPPTToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToPPTToolStripButton.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Dim mFileName As String

        saveFileDialog1.Filter = "PowerPoint files (*.ppt)|*.ppt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            mFileName = saveFileDialog1.FileName
            If mFileName.Length > 0 Then
                Exp2PPT(mFileName)
            End If
        End If

    End Sub

    Private Sub CheckNextPrev()
        If iCurrSlide > 0 Then
            Me.PrevToolStripButton.Enabled = True
        Else
            Me.PrevToolStripButton.Enabled = False
        End If
        If iCurrSlide < SlideCount - 1 Then
            Me.NextToolStripButton.Enabled = True
        Else
            Me.NextToolStripButton.Enabled = False
        End If
    End Sub

    Private Sub AxMap1_MouseMoveEvent(ByVal sender As Object, ByVal e As AxMapXLib.CMapXEvents_MouseMoveEvent) Handles AxMap1.MouseMoveEvent
        If (e.y < 40) And (e.x < 300) Then
            CheckNextPrev()
            Me.ToolStrip1.Visible = True
        Else
            Me.ToolStrip1.Visible = False
        End If
    End Sub

    Private Sub PrevToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrevToolStripButton.Click
        If iCurrSlide > 0 Then
            ShowSlide(iCurrSlide - 1)
        End If
        CheckNextPrev()
    End Sub

    Private Sub NextToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NextToolStripButton.Click
        If iCurrSlide < SlideCount - 1 Then
            ShowSlide(iCurrSlide + 1)
        End If
        CheckNextPrev()
    End Sub

    Private Sub ExitToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripButton.Click
        Me.Close()
    End Sub

    Private Sub ZoomInToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomInToolStripButton.Click
        Me.AxMap1.ZoomTo(Me.AxMap1.Zoom * (1.0 - ZoomDelta), Me.AxMap1.CenterX, Me.AxMap1.CenterY)
    End Sub

    Private Sub ZoomOutToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomOutToolStripButton.Click
        Me.AxMap1.ZoomTo(Me.AxMap1.Zoom * (1.0 + ZoomDelta), Me.AxMap1.CenterX, Me.AxMap1.CenterY)
    End Sub
End Class
