Imports System.Windows.Forms
Imports System.IO
Imports mySaBanLib
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Public Class dlgActions
    'Private ActionsFileName As String
    Private MenuFileName As String
    Private ActItems As List(Of CActMenuItem)

    Private Parentf As frmMain
    Private actions As List(Of CActionDef)
    Private CurrIndex As Integer = 0
    Private bDirty As Boolean = False
    Private bMenuLoaded As Boolean = False

    Private Sub RefreshCombo(ByVal pIndex As Integer)
        Me.cboMenuItem.DataSource = Nothing
        Me.cboMenuItem.DataSource = ActItems
        If pIndex < Me.cboMenuItem.Items.Count Then
            Me.cboMenuItem.SelectedIndex = pIndex
        End If
    End Sub

    Private Sub RefreshList(ByVal pIndex As Integer)
        Me.lstActions.DataSource = Nothing
        Me.lstActions.DataSource = actions
        If pIndex < Me.lstActions.Items.Count Then
            Me.lstActions.SelectedIndex = pIndex
        End If
    End Sub

    Public Sub AddAction(ByVal pAction As CActionDef)
        Dim i As Integer = Me.lstActions.SelectedIndex
        If i >= 0 Then
            actions.Insert(i + 1, pAction)
        Else
            actions.Add(pAction)
        End If
        'Me.lstActions.DataSource = Nothing
        'Me.lstActions.DataSource = actions
        RefreshList(i + 1)
    End Sub

    Public Sub UpdateAction()
        RefreshList(CurrIndex)
    End Sub

    Public Function IsNameOK(ByVal pName As String) As Boolean
        Dim Kq As Boolean = True
        Dim mFounds As Integer = 0
        If pName.Length > 0 Then
            For Each aSB As CSymbol In fMain.myBando.drawingSymbols
                If aSB.Description = pName Then
                    mFounds += 1
                    If mFounds > 1 Then
                        Exit For
                    End If
                End If
            Next
            If mFounds > 1 Then Kq = False
        Else
            Kq = False
        End If
        Return Kq
    End Function

    Private Sub UpdateScript(ByVal pActFileName As String)
        'CActionDefs.WriteActionDef(actions, ActionsFileName)
        'Dim mMenuItem As CActMenuItem = Me.cboMenuItem.SelectedItem
        'actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
        If bDirty Then
            CActionDefs.WriteActionDef(actions, pActFileName)
        End If
    End Sub

    Private Sub ExportSounds(ByVal pFileName As String, ByVal pActions As List(Of CActionDef))
        Dim SoundNames As Dictionary(Of String, String) = New Dictionary(Of String, String)

        Dim mTexImage As Bitmap = New Bitmap(myTextureFile)
        Dim g As Graphics = Graphics.FromImage(mTexImage)

        Using sw As StreamWriter = New StreamWriter(pFileName)
            sw.WriteLine("<Sounds>")
            For Each aAction As CActionDef In pActions
                Try
                    Dim mSoundName As String = aAction.SoundName
                    If mSoundName.Length > 0 Then
                        SoundNames.Add(mSoundName, "sounds\" & mSoundName)
                        sw.WriteLine("<Sound File=""" & "sounds\" & mSoundName & """ />")
                    End If
                Catch ex As Exception

                End Try
            Next
            sw.WriteLine("</Sounds>")

            sw.Close()
        End Using
    End Sub

    Private Sub ExportObjs()
        Dim allActions As New List(Of CActionDef)
        For Each mMenuItem As CActMenuItem In Me.cboMenuItem.Items
            actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
            For Each action As CActionDef In actions
                allActions.Add(action)
            Next
        Next
        ExportSounds(mySaBanDir & "\D3DSounds.xml", allActions)
        Parentf.ExportCacDT(allActions)

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'ExportSounds("D3DSounds.xml")
        'Parentf.ExportCacDT(actions)
        If My.Computer.FileSystem.DirectoryExists(mySaBanDir) Then
            If bDirty Then
                'If actions.Count > 0 Then
                UpdateScript(Me.txtActFileName.Text)
                ExportObjs()
                'My.Computer.FileSystem.WriteAllText(mySaBanDefFileName, mySaBanDir, False)
                'End If
            End If
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgActions_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        fActions = Nothing
    End Sub

    Private Sub dlgActions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fActions = Me
        Me.Text = "Các Kịch bản"

        'bMenuLoaded = True
        LoadKichBan(MenuFileName)
    End Sub

    Private Sub LoadKichBan(ByVal pMenuFileName As String)
        If My.Computer.FileSystem.FileExists(pMenuFileName) Then
            ActItems = CActItemsDef.LoadItems(pMenuFileName)
        Else
            ActItems = New List(Of CActMenuItem)
        End If

        bMenuLoaded = True
        RefreshCombo(0)
    End Sub

    Public Overloads Sub Show(ByVal pFileName As String, ByVal pform As Form)
        'ActionsFileName = pFileName
        MenuFileName = pFileName

        Parentf = pform

        Me.Show(ParentForm)
    End Sub

    Private Sub FlyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New dlgFlyAction
        f.TopMost = True
        f.Show(Me)
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = Me.lstActions.SelectedIndex
        If i < actions.Count - 1 Then
            Dim oAction As CActionDef = actions(i)
            actions.Remove(oAction)
            actions.Insert(i + 1, oAction)
        End If
        'Me.lstActions.DataSource = Nothing
        'Me.lstActions.DataSource = actions
        RefreshList(i + 1)

        bDirty = True
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer = Me.lstActions.SelectedIndex
        If i > 0 Then
            Dim oAction As CActionDef = actions(i)
            actions.Remove(oAction)
            actions.Insert(i - 1, oAction)
        End If
        'Me.lstActions.DataSource = Nothing
        'Me.lstActions.DataSource = actions
        RefreshList(i - 1)

        bDirty = True
    End Sub

    Private Sub lstActions_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstActions.KeyUp
        If e.KeyCode = Keys.Delete Then
            Dim i As Integer = Me.lstActions.SelectedIndex
            If i >= 0 Then
                Dim oAction As CActionDef = actions(i)
                actions.Remove(oAction)
            End If
            'Me.lstActions.DataSource = Nothing
            'Me.lstActions.DataSource = actions
            RefreshList(i)

            bDirty = True
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim mFileName As String
        Dim openFileDialog1 As New OpenFileDialog

        openFileDialog1.Filter = "Kịch bản files (*.scrpt)|*.scrpt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            mFileName = openFileDialog1.FileName
            If mFileName.Length > 0 Then
                Try
                    actions = CActionDefs.ReadActionDef(mFileName)
                    Me.Text = "Kịch bản (" & mFileName & ")"
                    'Me.lstActions.DataSource = Nothing
                    'Me.lstActions.DataSource = actions
                    RefreshList(0)
                    bDirty = True
                Catch ex As Exception
                End Try
            End If
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Dim mFileName As String

        saveFileDialog1.Filter = "Kịch bản files (*.scrpt)|*.scrpt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            mFileName = saveFileDialog1.FileName
            If mFileName.Length > 0 Then
                CActionDefs.WriteActionDef(actions, mFileName)
                Me.Text = "Kịch bản (" & mFileName & ")"
            End If
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Text = "Kịch bản"
        Try
            actions = New List(Of CActionDef)
            'Me.lstActions.DataSource = Nothing
            'Me.lstActions.DataSource = actions
            RefreshList(0)
            bDirty = True
        Catch ex As Exception
        End Try

    End Sub

    Private Sub lstActions_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstActions.DoubleClick
        CurrIndex = Me.lstActions.SelectedIndex
        Dim oAction As CActionDef = Me.lstActions.SelectedItem
        Select Case oAction.ActionType
            Case "FlyModel"
                Dim f As New dlgFlyAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "MoveModel", "MoveBillboard"
                Dim f As New dlgFlyAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "MoveTex"
                Dim f As New dlgFlyAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "Wipe", "WipeLeft", "WipeUp", "WipeDown"
                Dim f As New dlgWipeAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "Blink", "BlinkModel"
                Dim f As New dlgBlinkAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "HideTex", "HideModel", "HideBillboard"
                Dim f As New dlgHideAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "Shoot", "ShootFromModel", "ShootFromTexObj", "ShootFromBillboard"
                Dim f As New dlgShootAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case "Explosion", "ExplodeModel", "ExplodeTex"
                Dim f As New dlgExplodeAction
                f.TopMost = True
                f.Show(Me, oAction, "Update")
            Case Else
                MsgBox(oAction.GetActionStr())
        End Select
        bDirty = True
    End Sub

    Private Sub btnWipe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWipe.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CWipeDef("Wipe", "Xuất hiện", "", mAction.startanimation, 15, 5, 1, "", False)
        Else
            oAction = New CWipeDef("Wipe", "Xuất hiện", "", "Start()", 15, 5, 1, "", False)
        End If

        Dim f As New dlgWipeAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True
    End Sub

    Private Sub btnBlink_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBlink.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CBlinkDef("Blink", "Nhấp nháy", "", mAction.startanimation, 15, 5, "", False)
        Else
            oAction = New CBlinkDef("Blink", "Nhấp nháy", "", "Start()", 15, 5, "", False)
        End If

        Dim f As New dlgBlinkAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True

    End Sub

    Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CMoveDef("MoveModel", "Chạy", "", mAction.startanimation, 0.08, New List(Of Vector3), "", True)
        Else
            oAction = New CMoveDef("MoveModel", "Chạy", "", "Start()", 0.08, New List(Of Vector3), "", True)
        End If

        Dim f As New dlgFlyAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True

    End Sub

    Private Sub btnFly_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFly.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CMoveDef("FlyModel", "Bay", "", mAction.startanimation, 0.18, New List(Of Vector3), "b17-01.wav", True)
        Else
            oAction = New CMoveDef("FlyModel", "Bay", "", "Start()", 0.18, New List(Of Vector3), "b17-01.wav", True)
        End If

        Dim f As New dlgFlyAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True
    End Sub

    Private Sub cboMenuItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMenuItem.SelectedIndexChanged
        If bMenuLoaded Then
            If Not IsNothing(Me.cboMenuItem.SelectedItem) Then
                UpdateScript(Me.txtActFileName.Text)

                Dim mMenuItem As CActMenuItem = Me.cboMenuItem.SelectedItem
                actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
                Me.txtActFileName.Text = mMenuItem.ActFileName
                bDirty = False

                RefreshList(0)
            End If
        End If
    End Sub

    Private Sub btnHide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CHideDef("Hide", "Ẩn", "", mAction.startanimation)
        Else
            oAction = New CHideDef("Hide", "Ẩn", "", "0")
        End If

        Dim f As New dlgHideAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True

    End Sub

    Private Sub btnShoot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShoot.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CShootDef("Shoot", "Bắn", "dan2.bmp", 1.0, 1.5, mAction.startanimation, 400, 2.0, New Vector3(0, 0, 0), New Vector3(0, 0, 0), "gun_shotgun1.wav", True)
        Else
            oAction = New CShootDef("Shoot", "Bắn", "dan2.bmp", 1.0, 1.5, "Start()", 400, 2.0, New Vector3(0, 0, 0), New Vector3(0, 0, 0), "gun_shotgun1.wav", True)
        End If

        Dim f As New dlgShootAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True

    End Sub

    Private Sub btnExplode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExplode.Click
        Dim oAction As CActionDef
        If Me.lstActions.SelectedIndex > -1 Then
            Dim mAction As CActionDef = Me.lstActions.SelectedItem
            oAction = New CExplodeDef("Explosion", "Nổ", mAction.startanimation, 1, 3, "explosion1.bmp", 3, 3, New Vector3(0, 0, 0), "explosion.wav", True)
        Else
            oAction = New CExplodeDef("Explosion", "Nổ", "Start()", 1, 3, "explosion1.bmp", 3, 3, New Vector3(0, 0, 0), "explosion.wav", True)
        End If

        Dim f As New dlgExplodeAction
        f.TopMost = True
        f.Show(Me, oAction, "Add")

        bDirty = True

    End Sub

    Private Sub NewSaBanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewSaBanToolStripMenuItem.Click
        Dim f As New dlgNewSaBan
        'f.ShowDialog(Me)
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'mySaBanDir = Me.txtName.Text
            'My.Computer.FileSystem.WriteAllText(mySaBanDefFileName, mySaBanDir, False)
            MenuFileName = mySaBanDir & "\MyMenu.xml"
            LoadKichBan(MenuFileName)
            bDirty = True
        End If
    End Sub

    Private Sub OpenSaBanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenSaBanToolStripMenuItem.Click
        Dim f As New dlgNewSaBan
        f.txtMode.Text = "Open"
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            MenuFileName = mySaBanDir & "\MyMenu.xml"
            LoadKichBan(MenuFileName)
            bDirty = False
        End If
    End Sub

    Private Sub UpdateMenuToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateMenuToolStripMenuItem.Click
        Dim f As New dlgEditMenu
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            MenuFileName = mySaBanDir & "\MyMenu.xml"
            LoadKichBan(MenuFileName)
        End If
    End Sub

    Private Sub btnRebuild_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRebuild.Click
        If My.Computer.FileSystem.DirectoryExists(mySaBanDir) Then
            For Each mMenuItem As CActMenuItem In Me.cboMenuItem.Items
                actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
                CActionDefs.WriteActionDef(actions, mMenuItem.ActFileName)
            Next
            ExportObjs()
            bDirty = False

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class
