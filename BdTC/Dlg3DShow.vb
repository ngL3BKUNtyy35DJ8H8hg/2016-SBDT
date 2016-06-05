Imports System.Windows.Forms
Imports mySaBanLib
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Public Class Dlg3DShow
    Private CameraPos As Vector3
    Private CameraTarget As Vector3
    Private mySaBan As CSaBan
    Private m_TexImage As Bitmap


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dlg3DShow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        mySaBan.ClearTexObjs()
        mySaBan.ClearSounds()
    End Sub

    Private Sub Dlg3DShow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            If mySaBan.bPlaying Then
                mySaBan.PauseAction()
            Else
                mySaBan.ResumeAction()
            End If
        ElseIf e.KeyCode = Keys.R Then
            'mySaBan.ClearSounds()
            'mySaBan.bPlaying = False
            mySaBan.ResetAction()
        ElseIf e.KeyCode = Keys.S Then
            'mySaBan.ClearSounds()
            'mySaBan.bPlaying = False
            mySaBan.StopAction()
        ElseIf e.KeyCode = Keys.M Then
            mySaBan.SwitchFillMode()
        ElseIf e.KeyCode = Keys.Escape Then
            mySaBan.ClearSounds()
            Me.Close()
        End If
    End Sub

    Private Sub Dlg3DShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mySaBan.InitTerrain(m_TexImage, CameraPos, _
            CameraTarget, -Math.PI / 10, _
            New Vector3(1.0F, 1.0F, -20.0F), New Vector3(0.0F, 10.0F, 5.0F))

        'mySaBan.ClearSounds()
        'mySaBan.bPlaying = False
        'mySaBan.ResetAction()

    End Sub

    Public Overloads Sub ShowDialog(ByVal pTexImage As Bitmap, ByVal heightData(,) As Single _
    , ByVal pCamPos As Vector3, ByVal pCamTarget As Vector3, ByVal pMenuFile As String)
        'Me.WindowState = FormWindowState.Maximized
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.Opaque, True)
        Me.Text = "  SpaceBar = Chạy/Tạm dừng;  R = Bắt đầu lại;  S = Kết thúc;  Escape = Thoát ra."

        mySaBan = New CSaBan(Me, heightData, mySCALE_FACTOR)

        mySaBan.LoadBillboardMeshs("D3DBillboardMesh.xml")

        mySaBan.LoadModelMeshs("D3DModelMesh.xml")

        mySaBan.LoadSpriteTexs("D3DSpriteTexs.xml")

        mySaBan.LoadSounds(mySaBanDir & "\D3DSounds.xml")

        mySaBan.LoadModels(mySaBanDir & "\D3DModels.xml")

        mySaBan.LoadBillboards(mySaBanDir & "\D3DBillboards.xml")

        mySaBan.LoadTexObjs(mySaBanDir & "\D3DTexObjs.xml")

        'Dim maxFrame As Integer = mySaBan.LoadActions(pActionsFile)
        'mySaBan.LoadActions1("actions1.xml")
        'MsgBox("pMenuFile: " & pMenuFile)


        mySaBan.LoadMenu(pMenuFile)

        m_TexImage = pTexImage

        CameraPos = pCamPos
        CameraTarget = pCamTarget

        Me.ShowDialog()
    End Sub

End Class
