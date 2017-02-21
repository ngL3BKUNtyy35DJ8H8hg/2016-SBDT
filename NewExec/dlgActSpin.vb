Imports DienTapLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgActSpin
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("lblPath")>
		Private _lblPath As Label

		<AccessedThroughProperty("txtActionName")>
		Private _txtActionName As TextBox

		<AccessedThroughProperty("btnObjName")>
		Private _btnObjName As Button

		<AccessedThroughProperty("txtObjName")>
		Private _txtObjName As TextBox

		<AccessedThroughProperty("txtPath")>
		Private _txtPath As TextBox

		<AccessedThroughProperty("btnGetPath")>
		Private _btnGetPath As Button

		<AccessedThroughProperty("txtSoundName")>
		Private _txtSoundName As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("chkLoop")>
		Private _chkLoop As CheckBox

		<AccessedThroughProperty("txtStart")>
		Private _txtStart As TextBox

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtObjType")>
		Private _txtObjType As TextBox

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		Private Parentf As dlgActions

		Private ActionDef As CSpinToDef

		Private Mode As String

		Friend Overridable Property TableLayoutPanel1() As TableLayoutPanel
			Get
				Return Me._TableLayoutPanel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel1 = value
			End Set
		End Property

		Friend Overridable Property OK_Button() As Button
			Get
				Return Me._OK_Button
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.OK_Button_Click
				If Me._OK_Button IsNot Nothing Then
					RemoveHandler Me._OK_Button.Click, value2
				End If
				Me._OK_Button = value
				If Me._OK_Button IsNot Nothing Then
					AddHandler Me._OK_Button.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Cancel_Button() As Button
			Get
				Return Me._Cancel_Button
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cancel_Button_Click
				If Me._Cancel_Button IsNot Nothing Then
					RemoveHandler Me._Cancel_Button.Click, value2
				End If
				Me._Cancel_Button = value
				If Me._Cancel_Button IsNot Nothing Then
					AddHandler Me._Cancel_Button.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property lblPath() As Label
			Get
				Return Me._lblPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPath = value
			End Set
		End Property

		Friend Overridable Property txtActionName() As TextBox
			Get
				Return Me._txtActionName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActionName = value
			End Set
		End Property

		Friend Overridable Property btnObjName() As Button
			Get
				Return Me._btnObjName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnObjName_Click
				If Me._btnObjName IsNot Nothing Then
					RemoveHandler Me._btnObjName.Click, value2
				End If
				Me._btnObjName = value
				If Me._btnObjName IsNot Nothing Then
					AddHandler Me._btnObjName.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtObjName() As TextBox
			Get
				Return Me._txtObjName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjName = value
			End Set
		End Property

		Friend Overridable Property txtPath() As TextBox
			Get
				Return Me._txtPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPath = value
			End Set
		End Property

		Friend Overridable Property btnGetPath() As Button
			Get
				Return Me._btnGetPath
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnGetPath_Click
				If Me._btnGetPath IsNot Nothing Then
					RemoveHandler Me._btnGetPath.Click, value2
				End If
				Me._btnGetPath = value
				If Me._btnGetPath IsNot Nothing Then
					AddHandler Me._btnGetPath.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtSoundName() As TextBox
			Get
				Return Me._txtSoundName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSoundName_DoubleClick
				If Me._txtSoundName IsNot Nothing Then
					RemoveHandler Me._txtSoundName.DoubleClick, value2
				End If
				Me._txtSoundName = value
				If Me._txtSoundName IsNot Nothing Then
					AddHandler Me._txtSoundName.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label5() As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		Friend Overridable Property chkLoop() As CheckBox
			Get
				Return Me._chkLoop
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkLoop = value
			End Set
		End Property

		Friend Overridable Property txtStart() As TextBox
			Get
				Return Me._txtStart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtStart = value
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property txtObjType() As TextBox
			Get
				Return Me._txtObjType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjType = value
			End Set
		End Property

		Friend Overridable Property txtDuration() As TextBox
			Get
				Return Me._txtDuration
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDuration = value
			End Set
		End Property

		Friend Overridable Property Label8() As Label
			Get
				Return Me._Label8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgShootAction_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgShootAction_Load
			Me.Mode = "Update"
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.TableLayoutPanel1 = New TableLayoutPanel()
			Me.OK_Button = New Button()
			Me.Cancel_Button = New Button()
			Me.Label1 = New Label()
			Me.Label2 = New Label()
			Me.lblPath = New Label()
			Me.txtActionName = New TextBox()
			Me.btnObjName = New Button()
			Me.txtObjName = New TextBox()
			Me.txtPath = New TextBox()
			Me.btnGetPath = New Button()
			Me.txtSoundName = New TextBox()
			Me.Label5 = New Label()
			Me.chkLoop = New CheckBox()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.txtObjType = New TextBox()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_17B_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(242, 240)
			arg_17B_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1CD_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1CD_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 9
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1FB_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1FB_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_222_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_222_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_26C_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_26C_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_293_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_293_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_2D2_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_2D2_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_2F9_0 As Control = Me.Label1
			size = New Size(96, 14)
			arg_2F9_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Me.Label2.AutoSize = True
			Dim arg_338_0 As Control = Me.Label2
			location = New Point(12, 71)
			arg_338_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_35F_0 As Control = Me.Label2
			size = New Size(91, 14)
			arg_35F_0.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng:"
			Me.lblPath.AutoSize = True
			Dim arg_3A1_0 As Control = Me.lblPath
			location = New Point(12, 166)
			arg_3A1_0.Location = location
			Me.lblPath.Name = "lblPath"
			Dim arg_3CB_0 As Control = Me.lblPath
			size = New Size(230, 14)
			arg_3CB_0.Size = size
			Me.lblPath.TabIndex = 3
			Me.lblPath.Text = "Click ph" & ChrW(7843) & "i chu" & ChrW(7897) & "t vào " & ChrW(273) & "i" & ChrW(7875) & "m c" & ChrW(7847) & "n h" & ChrW(432) & ChrW(7899) & "ng t" & ChrW(7899) & "i:"
			Dim arg_3FE_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_3FE_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_428_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_428_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_44E_0 As Control = Me.btnObjName
			location = New Point(286, 66)
			arg_44E_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_475_0 As Control = Me.btnObjName
			size = New Size(105, 23)
			arg_475_0.Size = size
			Me.btnObjName.TabIndex = 3
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_4B4_0 As Control = Me.txtObjName
			location = New Point(121, 68)
			arg_4B4_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Me.txtObjName.[ReadOnly] = True
			Dim arg_4EA_0 As Control = Me.txtObjName
			size = New Size(157, 21)
			arg_4EA_0.Size = size
			Me.txtObjName.TabIndex = 2
			Me.txtPath.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_51D_0 As Control = Me.txtPath
			location = New Point(12, 181)
			arg_51D_0.Location = location
			Me.txtPath.Multiline = True
			Me.txtPath.Name = "txtPath"
			Me.txtPath.ScrollBars = ScrollBars.Vertical
			Dim arg_55F_0 As Control = Me.txtPath
			size = New Size(379, 47)
			arg_55F_0.Size = size
			Me.txtPath.TabIndex = 6
			Dim arg_588_0 As Control = Me.btnGetPath
			location = New Point(263, 156)
			arg_588_0.Location = location
			Me.btnGetPath.Name = "btnGetPath"
			Dim arg_5B2_0 As Control = Me.btnGetPath
			size = New Size(128, 23)
			arg_5B2_0.Size = size
			Me.btnGetPath.TabIndex = 8
			Me.btnGetPath.Text = "L" & ChrW(7845) & "y h" & ChrW(432) & ChrW(7899) & "ng trên B" & ChrW(272)
			Me.btnGetPath.UseVisualStyleBackColor = True
			Dim arg_5F1_0 As Control = Me.txtSoundName
			location = New Point(121, 122)
			arg_5F1_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_61B_0 As Control = Me.txtSoundName
			size = New Size(157, 21)
			arg_61B_0.Size = size
			Me.txtSoundName.TabIndex = 5
			Me.txtSoundName.Text = "gun_shotgun1.wav"
			Me.Label5.AutoSize = True
			Dim arg_65A_0 As Control = Me.Label5
			location = New Point(12, 125)
			arg_65A_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_681_0 As Control = Me.Label5
			size = New Size(65, 14)
			arg_681_0.Size = size
			Me.Label5.TabIndex = 11
			Me.Label5.Text = "Âm thanh:"
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_6DC_0 As Control = Me.chkLoop
			location = New Point(286, 126)
			arg_6DC_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_703_0 As Control = Me.chkLoop
			size = New Size(45, 18)
			arg_703_0.Size = size
			Me.chkLoop.TabIndex = 6
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Dim arg_742_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_742_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_76C_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_76C_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "0"
			Me.Label6.AutoSize = True
			Dim arg_7AB_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_7AB_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_7D2_0 As Control = Me.Label6
			size = New Size(111, 14)
			arg_7D2_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_809_0 As Control = Me.txtObjType
			location = New Point(286, 95)
			arg_809_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_830_0 As Control = Me.txtObjType
			size = New Size(102, 21)
			arg_830_0.Size = size
			Me.txtObjType.TabIndex = 16
			Me.txtObjType.Visible = False
			Dim arg_860_0 As Control = Me.txtDuration
			location = New Point(121, 95)
			arg_860_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_88A_0 As Control = Me.txtDuration
			size = New Size(157, 21)
			arg_88A_0.Size = size
			Me.txtDuration.TabIndex = 22
			Me.txtDuration.Text = "5"
			Me.Label8.AutoSize = True
			Dim arg_8CA_0 As Control = Me.Label8
			location = New Point(12, 98)
			arg_8CA_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_8F1_0 As Control = Me.Label8
			size = New Size(61, 14)
			arg_8F1_0.Size = size
			Me.Label8.TabIndex = 23
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(400, 281)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtObjType)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.chkLoop)
			Me.Controls.Add(Me.txtSoundName)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.btnGetPath)
			Me.Controls.Add(Me.txtPath)
			Me.Controls.Add(Me.txtObjName)
			Me.Controls.Add(Me.btnObjName)
			Me.Controls.Add(Me.txtActionName)
			Me.Controls.Add(Me.lblPath)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActSpin"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgFlyAction"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub UpdateAction()
			Me.ActionDef.Name = Me.txtActionName.Text
			Me.ActionDef.ObjName = Me.txtObjName.Text
			Me.ActionDef.SoundLoop = Me.chkLoop.Checked
			Me.ActionDef.SoundName = Me.txtSoundName.Text
			Me.ActionDef.start = Me.txtStart.Text
			Me.ActionDef.duration = Me.txtDuration.Text
			Dim list As List(Of Vector3) = CActDefs.ReadTargets(Me.txtPath.Text)
			If list.Count > 0 Then
				' The following expression was wrapped in a checked-expression
				Me.ActionDef.topos = list(list.Count - 1)
			End If
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Dim result As Boolean = False
			Dim list As List(Of Vector3) = CActDefs.ReadTargets(Me.txtPath.Text)
			If Me.txtObjName.Text.Length > 0 AndAlso (Operators.CompareString(Me.txtObjType.Text, "Model", False) = 0 Or Operators.CompareString(Me.txtObjType.Text, "Billboard", False) = 0) AndAlso list.Count > 0 Then
				result = True
			End If
			Return result
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Me.isOK() Then
				Me.UpdateAction()
				modSaBan.fActions.bDirty = True
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Interaction.MsgBox("Ch" & ChrW(432) & "a xác " & ChrW(273) & ChrW(7883) & "nh h" & ChrW(432) & ChrW(7899) & "ng, ho" & ChrW(7863) & "c " & ChrW(272) & "t không ph" & ChrW(7843) & "i 3D.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CSpinToDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub btnGetPath_Click(sender As Object, e As EventArgs)
			Me.txtPath.Text = ""
			myModule.fMain.myVeActs.OnGetTarget(Me.txtPath, 0F)
		End Sub

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myVeActs.OnGetObjName(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub dlgShootAction_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgShootAction_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = "H" & ChrW(432) & ChrW(7899) & "ng t" & ChrW(7899) & "i"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtObjName.Text = Me.ActionDef.ObjName
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			Me.txtStart.Text = Me.ActionDef.start
			Me.txtDuration.Text = Me.ActionDef.duration
			Dim txtPath As TextBox = Me.txtPath
			txtPath.Text = String.Concat(New String() { txtPath.Text, "<Target X=""", Me.ActionDef.topos.X.ToString(), """ Y=""", Me.ActionDef.topos.Y.ToString(), """ Z=""", Me.ActionDef.topos.Z.ToString(), """></Target>" & vbCrLf })
		End Sub

		Private Sub txtSoundName_DoubleClick(sender As Object, e As EventArgs)
			Dim dlgGetName As dlgGetName = New dlgGetName()
			dlgGetName.txtNameType.Text = "Sound"
			If dlgGetName.ShowDialog(Me) = DialogResult.OK Then
				Me.txtSoundName.Text = dlgGetName.txtName.Text
			End If
		End Sub
	End Class
End Namespace
