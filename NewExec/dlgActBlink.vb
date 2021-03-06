Imports DienTapLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgActBlink
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

		<AccessedThroughProperty("txtActionName")>
		Private _txtActionName As TextBox

		<AccessedThroughProperty("btnObjName")>
		Private _btnObjName As Button

		<AccessedThroughProperty("txtObjName")>
		Private _txtObjName As TextBox

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

		<AccessedThroughProperty("txtSpeed")>
		Private _txtSpeed As TextBox

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		Private Parentf As dlgActions

		Private ActionDef As CBlinkDef

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

		Friend Overridable Property txtSpeed() As TextBox
			Get
				Return Me._txtSpeed
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSpeed = value
			End Set
		End Property

		Friend Overridable Property Label7() As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgBlinkAction_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgBlinkAction_Load
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
			Me.txtActionName = New TextBox()
			Me.btnObjName = New Button()
			Me.txtObjName = New TextBox()
			Me.txtSoundName = New TextBox()
			Me.Label5 = New Label()
			Me.chkLoop = New CheckBox()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.txtObjType = New TextBox()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.txtSpeed = New TextBox()
			Me.Label7 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_170_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(242, 190)
			arg_170_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1C2_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1C2_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 7
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1EF_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1EF_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_216_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_216_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_260_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_260_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_287_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_287_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_2C6_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_2C6_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_2ED_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_2ED_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Me.Label2.AutoSize = True
			Dim arg_32C_0 As Control = Me.Label2
			location = New Point(12, 71)
			arg_32C_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_353_0 As Control = Me.Label2
			size = New Size(78, 13)
			arg_353_0.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng:"
			Dim arg_386_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_386_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_3B0_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_3B0_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_3D6_0 As Control = Me.btnObjName
			location = New Point(286, 66)
			arg_3D6_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_3FD_0 As Control = Me.btnObjName
			size = New Size(105, 23)
			arg_3FD_0.Size = size
			Me.btnObjName.TabIndex = 2
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_43C_0 As Control = Me.txtObjName
			location = New Point(121, 68)
			arg_43C_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Me.txtObjName.[ReadOnly] = True
			Dim arg_472_0 As Control = Me.txtObjName
			size = New Size(157, 21)
			arg_472_0.Size = size
			Me.txtObjName.TabIndex = 2
			Me.txtObjName.Text = "MayBay2"
			Dim arg_4A8_0 As Control = Me.txtSoundName
			location = New Point(121, 151)
			arg_4A8_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_4D2_0 As Control = Me.txtSoundName
			size = New Size(157, 21)
			arg_4D2_0.Size = size
			Me.txtSoundName.TabIndex = 5
			Me.txtSoundName.Text = "b17-01.wav"
			Me.Label5.AutoSize = True
			Dim arg_514_0 As Control = Me.Label5
			location = New Point(12, 154)
			arg_514_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_53B_0 As Control = Me.Label5
			size = New Size(57, 13)
			arg_53B_0.Size = size
			Me.Label5.TabIndex = 11
			Me.Label5.Text = "Âm thanh:"
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_599_0 As Control = Me.chkLoop
			location = New Point(286, 155)
			arg_599_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_5C0_0 As Control = Me.chkLoop
			size = New Size(43, 17)
			arg_5C0_0.Size = size
			Me.chkLoop.TabIndex = 6
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Dim arg_5FF_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_5FF_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_629_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_629_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "10"
			Me.Label6.AutoSize = True
			Dim arg_668_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_668_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_68F_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_68F_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_6C6_0 As Control = Me.txtObjType
			location = New Point(289, 95)
			arg_6C6_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_6ED_0 As Control = Me.txtObjType
			size = New Size(102, 21)
			arg_6ED_0.Size = size
			Me.txtObjType.TabIndex = 18
			Me.txtObjType.Visible = False
			Dim arg_71D_0 As Control = Me.txtDuration
			location = New Point(121, 122)
			arg_71D_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_747_0 As Control = Me.txtDuration
			size = New Size(157, 21)
			arg_747_0.Size = size
			Me.txtDuration.TabIndex = 4
			Me.txtDuration.Text = "400"
			Me.Label8.AutoSize = True
			Dim arg_786_0 As Control = Me.Label8
			location = New Point(12, 125)
			arg_786_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_7AD_0 As Control = Me.Label8
			size = New Size(54, 13)
			arg_7AD_0.Size = size
			Me.Label8.TabIndex = 27
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Dim arg_7E1_0 As Control = Me.txtSpeed
			location = New Point(121, 95)
			arg_7E1_0.Location = location
			Me.txtSpeed.Name = "txtSpeed"
			Dim arg_808_0 As Control = Me.txtSpeed
			size = New Size(51, 21)
			arg_808_0.Size = size
			Me.txtSpeed.TabIndex = 3
			Me.txtSpeed.Text = "2.0"
			Me.Label7.AutoSize = True
			Dim arg_847_0 As Control = Me.Label7
			location = New Point(12, 98)
			arg_847_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_86E_0 As Control = Me.Label7
			size = New Size(43, 13)
			arg_86E_0.Size = size
			Me.Label7.TabIndex = 25
			Me.Label7.Text = "T" & ChrW(7889) & "c " & ChrW(273) & ChrW(7897) & ":"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(400, 231)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtSpeed)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.txtObjType)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.chkLoop)
			Me.Controls.Add(Me.txtSoundName)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.txtObjName)
			Me.Controls.Add(Me.btnObjName)
			Me.Controls.Add(Me.txtActionName)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActBlink"
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
			Me.ActionDef.speed = Conversions.ToSingle(Me.txtSpeed.Text)
			Me.ActionDef.duration = Me.txtDuration.Text
			Me.ActionDef.start = Me.txtStart.Text
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Return True
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Me.isOK() Then
				If Me.Parentf.IsNameOK(Me.txtObjName.Text) Then
					Me.UpdateAction()
					modSaBan.fActions.bDirty = True
					Me.DialogResult = DialogResult.OK
					Me.Close()
				Else
					Interaction.MsgBox("Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng không duy nh" & ChrW(7845) & "t.", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CBlinkDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myVeActs.OnGetObjName(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub dlgBlinkAction_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgBlinkAction_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = "Nh" & ChrW(7845) & "p nháy"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtObjName.Text = Me.ActionDef.ObjName
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			Me.txtSpeed.Text = Conversions.ToString(Me.ActionDef.speed)
			Me.txtDuration.Text = Me.ActionDef.duration
			Me.txtStart.Text = Me.ActionDef.start
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
