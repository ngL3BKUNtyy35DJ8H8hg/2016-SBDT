Imports System.Windows.Forms
Imports mySaBanLib
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports BdTC.FormMain

Public Class dlgShootAction
    Private Parentf As dlgActions
    Private ActionDef As CShootDef
    Private Mode As String = "Update"

    Private Sub UpdateAction()
        ActionDef.Name = Me.txtActionName.Text
        ActionDef.ObjName = Me.txtObjName.Text
        ActionDef.SoundLoop = Me.chkLoop.Checked
        ActionDef.SoundName = Me.txtSoundName.Text
        ActionDef.startanimation = Me.txtStart.Text
        ActionDef.speed = Me.txtSpeed.Text
        ActionDef.duration = Me.txtDuration.Text
        ActionDef.imagefile = Me.txtImageFileName.Text
        ActionDef.width = Me.txtWidth.Text
        ActionDef.height = Me.txtHeight.Text
        If Me.txtObjName.Text.Length > 0 Then
            Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
            If mTargets.Count > 0 Then
                'ActionDef.position = mTargets(0)
                ActionDef.target = mTargets(0)
            End If
        Else
            Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
            If mTargets.Count = 2 Then
                ActionDef.position = mTargets(0)
                ActionDef.target = mTargets(1)
            End If
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
        'If mTargets.Count >= 2 Then
        'kq = True
        'Else
        'MsgBox("Chưa có đường bắn.")
        'End If

        If ActionDef.ActionType = "ShootFromTexObj" Then
            If (Me.txtObjName.Text.Length > 0) And (mTargets.Count > 0) Then
                kq = True
            End If
        ElseIf ActionDef.ActionType = "ShootFromModel" Then
            If (Me.txtObjName.Text.Length > 0) And (mTargets.Count > 0) Then
                kq = True
            End If
        ElseIf ActionDef.ActionType = "ShootFromBillboard" Then
            If (Me.txtObjName.Text.Length > 0) And (mTargets.Count > 0) Then
                kq = True
            End If
        Else
            If Me.txtObjType.Text = "TexObj" Then
                ActionDef.ActionType = "ShootFromTexObj"
                If (Me.txtObjName.Text.Length > 0) And (mTargets.Count > 0) Then
                    kq = True
                End If
            ElseIf Me.txtObjType.Text = "Model" Then
                ActionDef.ActionType = "ShootFromModel"
                If (Me.txtObjName.Text.Length > 0) And (mTargets.Count > 0) Then
                    kq = True
                End If
            ElseIf Me.txtObjType.Text = "Billboard" Then
                ActionDef.ActionType = "ShootFromBillboard"
                If (Me.txtObjName.Text.Length > 0) And (mTargets.Count > 0) Then
                    kq = True
                End If
            ElseIf Me.txtObjType.Text.Length = 0 Then
                'Dim mTargets As List(Of Vector3) = CActionDefs.ReadTargets(Me.txtPath.Text)
                If mTargets.Count >= 1 Then
                    ActionDef.ActionType = "Shoot"
                    kq = True
                Else
                    MsgBox("Chưa có đích.")
                End If
            Else
                MsgBox("Chưa đường bắn.")
            End If

        End If

        Return kq
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If isOK() Then
            UpdateAction()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
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

    Private Sub btnGetPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetPath.Click
        Me.txtPath.Text = ""
        'fMain.myBando.OnGetTarget(Me.txtPath, 0)
        Parentf.OnGetTarget(Me.txtPath, 0)

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

    Private Sub dlgShootAction_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Parentf.Visible = True
    End Sub

    Private Sub dlgShootAction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Parentf.Visible = False
        Me.OK_Button.Text = Mode
        Me.Text = "Bắn"

        Me.txtActionName.Text = ActionDef.Name
        Me.txtObjName.Text = ActionDef.ObjName
        Me.chkLoop.Checked = ActionDef.SoundLoop
        Me.txtSoundName.Text = ActionDef.SoundName
        Me.txtStart.Text = ActionDef.startanimation
        Me.txtSpeed.Text = ActionDef.speed
        Me.txtDuration.Text = ActionDef.duration
        Me.txtImageFileName.Text = ActionDef.imagefile
        Me.txtWidth.Text = ActionDef.width
        Me.txtHeight.Text = ActionDef.height

        If Me.txtObjName.Text.Length > 0 Then
            'Me.txtPath.Text = "<Target X=""" & ActionDef.position.X.ToString & """ Y=""" & ActionDef.position.Y.ToString & """ Z=""" & ActionDef.position.Z.ToString & """>" & "</Target>" & vbCrLf
            Me.txtPath.Text &= "<Target X=""" & ActionDef.target.X.ToString & """ Y=""" & ActionDef.target.Y.ToString & """ Z=""" & ActionDef.target.Z.ToString & """>" & "</Target>" & vbCrLf
        Else
            Me.txtPath.Text = "<Target X=""" & ActionDef.position.X.ToString & """ Y=""" & ActionDef.position.Y.ToString & """ Z=""" & ActionDef.position.Z.ToString & """>" & "</Target>" & vbCrLf
            Me.txtPath.Text &= "<Target X=""" & ActionDef.target.X.ToString & """ Y=""" & ActionDef.target.Y.ToString & """ Z=""" & ActionDef.target.Z.ToString & """>" & "</Target>" & vbCrLf
        End If

    End Sub

    Private Sub txtImageFileName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImageFileName.DoubleClick
        Dim f As New dlgGetName
        f.txtNameType.Text = "Image"
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtImageFileName.Text = f.txtName.Text
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
