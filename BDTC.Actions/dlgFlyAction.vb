Imports System.Windows.Forms
Imports mySaBanLib
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class dlgFlyAction
    Private Parentf As dlgActions
    Private ActionDef As CMoveDef
    Private Mode As String = "Update"

    Private Function GetSmoothPath(ByVal pTargets As List(Of Vector3)) As List(Of Vector3)
        Dim kq As List(Of Vector3) '= New List(Of Vector3)
        Dim m_OWidth As Double = CDbl(Parentf.mySurf2X * 1000D) / (Parentf.myGRID_WIDTH - 1) / 1000
        Dim m_OHeight As Double = CDbl(Parentf.mySurf2Y * 1000D) / (Parentf.myGRID_HEIGHT - 1) / 1000

        Dim mCount = pTargets.Count
        If mCount > 2 Then
            Dim mPts() As PointF
            ReDim mPts(mCount - 1)
            For i As Integer = 0 To mPts.GetUpperBound(0)
                mPts(i).X = pTargets(i).X * m_OWidth
                mPts(i).Y = pTargets(i).Y * m_OHeight
            Next

            Dim mPath As New GraphicsPath
            mPath.AddCurve(mPts)
            mPath.Flatten(New System.Drawing.Drawing2D.Matrix, 0.25)
            Dim mPts2() As PointF = mPath.PathPoints
            Dim mCount2 = mPts2.GetUpperBound(0)
            MsgBox("mCount2=" & mCount2.ToString)

            kq = New List(Of Vector3)
            For i As Integer = 0 To mCount2
                kq.Add(New Vector3(mPts2(i).X / m_OWidth, mPts2(i).Y / m_OHeight, pTargets(0).Z))
            Next
        Else
            kq = pTargets
        End If

        Return kq
    End Function

    Private Sub UpdateAction()
        ActionDef.Name = Me.txtActionName.Text
        ActionDef.ObjName = Me.txtObjName.Text
        ActionDef.SoundLoop = Me.chkLoop.Checked
        ActionDef.SoundName = Me.txtSoundName.Text
        ActionDef.speed = Me.txtSpeed.Text
        ActionDef.startanimation = Me.txtStart.Text

        Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
        'Dim mTargets As List(Of Vector3) = GetSmoothPath(mTargets0)
        If mTargets.Count > 0 Then
            ActionDef.targets.Clear()
            For Each mTarget As Vector3 In mTargets
                ActionDef.targets.Add(mTarget)
            Next
        End If
        If Mode = "Add" Then
            Parentf.AddAction(ActionDef)
        Else
            Parentf.UpdateAction()
        End If
    End Sub

    Private Function isOK() As Boolean
        Dim kq As Boolean = False
        Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
        If ActionDef.ActionType = "FlyModel" Then
            If mTargets.Count > 1 Then
                If Me.txtObjType.Text = "Model" Then
                    kq = True
                ElseIf Me.txtObjType.Text.Length = 0 Then
                    kq = True
                Else
                    MsgBox("Không đúng đối tượng.")
                End If
            Else
                MsgBox("Chưa có đường bay.")
            End If
        Else
            If mTargets.Count > 1 Then
                If Me.txtObjType.Text = "Model" Then
                    ActionDef.ActionType = "MoveModel"
                    kq = True
                ElseIf Me.txtObjType.Text = "Billboard" Then
                    ActionDef.ActionType = "MoveBillboard"
                    kq = True
                ElseIf Me.txtObjType.Text = "TexObj" Then
                    ActionDef.ActionType = "MoveTex"
                    kq = True
                ElseIf Me.txtObjType.Text.Length = 0 Then
                    kq = True
                Else
                    MsgBox("Không đúng đối tượng.")
                End If
            Else
                MsgBox("Chưa có đường chạy.")
            End If
        End If
        Return kq
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If isOK() Then
            If Parentf.IsNameOK(Me.txtObjName.Text) Then
                UpdateAction()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Tên đối tượng không duy nhất.")
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Overloads Sub Show(ByVal pform As dlgActions, ByVal pAction As CActionDef, ByVal pMode As String)
        Parentf = pform
        ActionDef = pAction
        Mode = pMode
        Me.Show(ParentForm)
    End Sub

    ''' <summary>
    ''' 2017-02-22
    ''' CODEEDIT
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGetPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetPath.Click
        Me.txtPath.Text = ""
        Dim mDoCao As Single = 0
        Try
            mDoCao = -CSng(Me.txtDoCao.Text)
        Catch ex As Exception
        End Try
        'fMain.myBando.OnGetTarget(Me.txtPath, mDoCao)
        Parentf.OnGetTarget(Me.txtPath, mDoCao)
    End Sub

    ''' <summary>
    ''' 2017-02-22
    ''' CODEEDIT
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnObjName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnObjName.Click
        Me.txtObjName.Text = ""
        'fMain.myBando.OnGetObjName(Me.txtObjName, Me.txtObjType)
        Parentf.OnGetObjName(Me.txtObjName, Me.txtObjType)
    End Sub

    Private Sub dlgFlyAction_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Parentf.Visible = True
    End Sub

    Private Sub dlgFlyAction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Parentf.Visible = False
        Me.OK_Button.Text = Mode
        If ActionDef.ActionType = "FlyModel" Then
            Me.Text = "Bay"
            Me.lblPath.Text = "Đường bay"
            Me.btnGetPath.Text = "Lấy Đường bay trên BĐ"
            Me.txtDoCao.Text = "10"
            Me.txtDoCao.Visible = True
            Me.lblDoCao.Visible = True
        Else
            Me.Text = "Chạy"
            Me.lblPath.Text = "Đường chạy"
            Me.btnGetPath.Text = "Lấy Đường chạy trên BĐ"
            Me.txtDoCao.Text = "0"
            Me.txtDoCao.Visible = False
            Me.lblDoCao.Visible = False
        End If

        Me.txtActionName.Text = ActionDef.Name
        Me.txtObjName.Text = ActionDef.ObjName
        Me.chkLoop.Checked = ActionDef.SoundLoop
        Me.txtSoundName.Text = ActionDef.SoundName
        Me.txtSpeed.Text = ActionDef.speed
        Me.txtStart.Text = ActionDef.startanimation
        If ActionDef.targets.Count > 0 Then
            For Each mTarget As Vector3 In ActionDef.targets
                Me.txtPath.Text &= "<Target X=""" & mTarget.X.ToString & """ Y=""" & mTarget.Y.ToString & """ Z=""" & mTarget.Z.ToString & """>" & "</Target>" & vbCrLf
            Next
        End If

    End Sub

    Private Sub txtSoundName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoundName.DoubleClick
        Dim f As New dlgGetName
        f.txtNameType.Text = "Sound"
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtSoundName.Text = f.txtName.Text
        End If
    End Sub
End Class
