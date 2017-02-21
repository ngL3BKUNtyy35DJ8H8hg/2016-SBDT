Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports mySaBanLib
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgHideAction
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		Private Parentf As dlgActions

		Private ActionDef As CHideDef

		Private Mode As String

		Friend Overridable Property TableLayoutPanel1() As TableLayoutPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._TableLayoutPanel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel1 = value
			End Set
		End Property

		Friend Overridable Property OK_Button() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._OK_Button
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._OK_Button IsNot Nothing
				If flag Then
					RemoveHandler Me._OK_Button.Click, AddressOf Me.OK_Button_Click
				End If
				Me._OK_Button = value
				flag = (Me._OK_Button IsNot Nothing)
				If flag Then
					AddHandler Me._OK_Button.Click, AddressOf Me.OK_Button_Click
				End If
			End Set
		End Property

		Friend Overridable Property Cancel_Button() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cancel_Button
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._Cancel_Button IsNot Nothing
				If flag Then
					RemoveHandler Me._Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
				End If
				Me._Cancel_Button = value
				flag = (Me._Cancel_Button IsNot Nothing)
				If flag Then
					AddHandler Me._Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
				End If
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property txtActionName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtActionName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActionName = value
			End Set
		End Property

		Friend Overridable Property btnObjName() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnObjName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnObjName IsNot Nothing
				If flag Then
					RemoveHandler Me._btnObjName.Click, AddressOf Me.btnObjName_Click
				End If
				Me._btnObjName = value
				flag = (Me._btnObjName IsNot Nothing)
				If flag Then
					AddHandler Me._btnObjName.Click, AddressOf Me.btnObjName_Click
				End If
			End Set
		End Property

		Friend Overridable Property txtObjName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtObjName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjName = value
			End Set
		End Property

		Friend Overridable Property txtSoundName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtSoundName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSoundName = value
			End Set
		End Property

		Friend Overridable Property Label5() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		Friend Overridable Property chkLoop() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._chkLoop
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkLoop = value
			End Set
		End Property

		Friend Overridable Property txtStart() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtStart
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtStart = value
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property txtObjType() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtObjType
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjType = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgHideAction_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgHideAction_Load
			dlgHideAction.__ENCList.Add(New WeakReference(Me))
			Me.Mode = "Update"
			Me.InitializeComponent()
		End Sub

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
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
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_15A_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(242, 205)
			arg_15A_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1B0_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1B0_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 9
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1E2_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1E2_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_20C_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_20C_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_25C_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_25C_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_286_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_286_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_2CA_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_2CA_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_2F4_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_2F4_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Me.Label2.AutoSize = True
			Dim arg_338_0 As Control = Me.Label2
			location = New Point(12, 71)
			arg_338_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_362_0 As Control = Me.Label2
			size = New Size(78, 13)
			arg_362_0.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng:"
			Dim arg_399_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_399_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_3C6_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_3C6_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_3EF_0 As Control = Me.btnObjName
			location = New Point(286, 66)
			arg_3EF_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_419_0 As Control = Me.btnObjName
			size = New Size(105, 23)
			arg_419_0.Size = size
			Me.btnObjName.TabIndex = 3
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_45D_0 As Control = Me.txtObjName
			location = New Point(121, 68)
			arg_45D_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Me.txtObjName.[ReadOnly] = True
			Dim arg_497_0 As Control = Me.txtObjName
			size = New Size(157, 21)
			arg_497_0.Size = size
			Me.txtObjName.TabIndex = 2
			Me.txtObjName.Text = "MayBay2"
			Dim arg_4D1_0 As Control = Me.txtSoundName
			location = New Point(121, 151)
			arg_4D1_0.Location = location
			Me.txtSoundName.Name = "txtSoundName"
			Dim arg_4FE_0 As Control = Me.txtSoundName
			size = New Size(157, 21)
			arg_4FE_0.Size = size
			Me.txtSoundName.TabIndex = 7
			Me.txtSoundName.Text = "b17-01.wav"
			Me.Label5.AutoSize = True
			Dim arg_545_0 As Control = Me.Label5
			location = New Point(12, 154)
			arg_545_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_56F_0 As Control = Me.Label5
			size = New Size(57, 13)
			arg_56F_0.Size = size
			Me.Label5.TabIndex = 11
			Me.Label5.Text = "Âm thanh:"
			Me.chkLoop.AutoSize = True
			Me.chkLoop.Checked = True
			Me.chkLoop.CheckState = CheckState.Checked
			Dim arg_5D4_0 As Control = Me.chkLoop
			location = New Point(286, 155)
			arg_5D4_0.Location = location
			Me.chkLoop.Name = "chkLoop"
			Dim arg_5FE_0 As Control = Me.chkLoop
			size = New Size(43, 17)
			arg_5FE_0.Size = size
			Me.chkLoop.TabIndex = 8
			Me.chkLoop.Text = "L" & ChrW(7863) & "p"
			Me.chkLoop.UseVisualStyleBackColor = True
			Dim arg_642_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_642_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_66F_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_66F_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "10"
			Me.Label6.AutoSize = True
			Dim arg_6B3_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_6B3_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_6DD_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_6DD_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_718_0 As Control = Me.txtObjType
			location = New Point(289, 95)
			arg_718_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_742_0 As Control = Me.txtObjType
			size = New Size(102, 21)
			arg_742_0.Size = size
			Me.txtObjType.TabIndex = 18
			Me.txtObjType.Visible = False
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(400, 246)
			Me.ClientSize = size
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
			Me.Name = "dlgHideAction"
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
			Me.ActionDef.startanimation = Me.txtStart.Text
			Dim flag As Boolean = Operators.CompareString(Me.Mode, "Add", False) = 0
			If flag Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Dim kq As Boolean = False
			Dim flag As Boolean = Operators.CompareString(Me.txtObjType.Text, "TexObj", False) = 0
			If flag Then
				Me.ActionDef.ActionType = "HideTex"
				kq = True
			Else
				flag = (Operators.CompareString(Me.txtObjType.Text, "Model", False) = 0)
				If flag Then
					Me.ActionDef.ActionType = "HideModel"
					kq = True
				Else
					flag = (Operators.CompareString(Me.txtObjType.Text, "Billboard", False) = 0)
					If flag Then
						Me.ActionDef.ActionType = "HideBillboard"
						kq = True
					Else
						flag = (Me.txtObjType.Text.Length = 0)
						If flag Then
							kq = True
						Else
							Interaction.MsgBox("Không " & ChrW(273) & "úng " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng.", MsgBoxStyle.OkOnly, Nothing)
						End If
					End If
				End If
			End If
			Return kq
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.isOK()
			If flag Then
				Dim flag2 As Boolean = Me.Parentf.IsNameOK(Me.txtObjName.Text)
				If flag2 Then
					Me.UpdateAction()
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

		Public Sub Show(pform As dlgActions, pAction As CActionDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CHideDef)
			Me.Mode = pMode
			Me.Show(Me.ParentForm)
		End Sub

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myBando.OnGetObjName(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub dlgHideAction_FormClosing(sender As Object, e As FormClosingEventArgs)
		End Sub

		Private Sub dlgHideAction_Load(sender As Object, e As EventArgs)
			Me.OK_Button.Text = Me.Mode
			Me.Text = ChrW(7848) & "n " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtObjName.Text = Me.ActionDef.ObjName
			Me.chkLoop.Checked = Me.ActionDef.SoundLoop
			Me.txtSoundName.Text = Me.ActionDef.SoundName
			Me.txtStart.Text = Me.ActionDef.startanimation
		End Sub
	End Class
End Namespace
