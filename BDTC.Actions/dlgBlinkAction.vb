﻿Imports System.Windows.Forms
Imports mySaBanLib
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports BdTC.FormMain

Public Class dlgBlinkAction
    Private Parentf As dlgActions
    Private ActionDef As CBlinkDef
    Private Mode As String = "Update"

    Private Sub UpdateAction()
        ActionDef.Name = Me.txtActionName.Text
        ActionDef.ObjName = Me.txtObjName.Text
        ActionDef.SoundLoop = Me.chkLoop.Checked
        ActionDef.SoundName = Me.txtSoundName.Text
        ActionDef.repeat = Me.txtRepeat.Text
        ActionDef.delay = Me.txtDelay.Text
        ActionDef.startanimation = Me.txtStart.Text
        If Mode = "Add" Then
            Parentf.AddAction(ActionDef)
        Else
            Parentf.UpdateAction()
        End If
    End Sub

    Private Function isOK() As Boolean
        Dim kq As Boolean = False
        If Me.txtObjType.Text = "TexObj" Then
            ActionDef.ActionType = "Blink"
            kq = True
        ElseIf Me.txtObjType.Text = "Model" Then
            ActionDef.ActionType = "BlinkModel"
            kq = True
        ElseIf Me.txtObjType.Text.Length = 0 Then
            kq = True
        Else
            MsgBox("Không đúng đối tượng.")
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
        'ActionsFileName = pFileName
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
    Private Sub btnObjName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnObjName.Click
        Me.txtObjName.Text = ""
        'fMain.myBando.OnGetObjName(Me.txtObjName, Me.txtObjType)
        Parentf.OnGetObjName(Me.txtObjName, Me.txtObjType)
    End Sub

    Private Sub dlgBlinkAction_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Parentf.Visible = True
    End Sub

    Private Sub dlgBlinkAction_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Parentf.Visible = False
        Me.OK_Button.Text = Mode
        Me.Text = "Nhấp nháy"

        Me.txtActionName.Text = ActionDef.Name
        Me.txtObjName.Text = ActionDef.ObjName
        Me.chkLoop.Checked = ActionDef.SoundLoop
        Me.txtSoundName.Text = ActionDef.SoundName
        Me.txtRepeat.Text = ActionDef.repeat
        Me.txtDelay.Text = ActionDef.delay
        Me.txtStart.Text = ActionDef.startanimation
    End Sub

    Private Sub txtSoundName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSoundName.DoubleClick
        Dim f As New dlgGetName
        f.txtNameType.Text = "Sound"
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtSoundName.Text = f.txtName.Text
        End If
    End Sub
End Class
