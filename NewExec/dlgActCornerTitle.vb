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
	Public Class dlgActCornerTitle
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

		<AccessedThroughProperty("txtActionName")>
		Private _txtActionName As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtTextDesc")>
		Private _txtTextDesc As TextBox

		<AccessedThroughProperty("txtStart")>
		Private _txtStart As TextBox

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		Private Parentf As dlgActions

		Private ActionDef As CCornerTitleDef

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

		Friend Overridable Property txtActionName() As TextBox
			Get
				Return Me._txtActionName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActionName = value
			End Set
		End Property

		Friend Overridable Property Label3() As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property txtTextDesc() As TextBox
			Get
				Return Me._txtTextDesc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTextDesc = value
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

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgExplodeAction_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgExplodeAction_Load
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
			Me.txtActionName = New TextBox()
			Me.Label3 = New Label()
			Me.txtTextDesc = New TextBox()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.txtDuration = New TextBox()
			Me.Label8 = New Label()
			Me.Label2 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_12E_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(311, 154)
			arg_12E_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_180_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_180_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 5
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1AD_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1AD_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1D4_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1D4_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_21E_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_21E_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_245_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_245_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_284_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_284_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_2AB_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_2AB_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Dim arg_2DE_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_2DE_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_308_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_308_0.Size = size
			Me.txtActionName.TabIndex = 0
			Me.Label3.AutoSize = True
			Dim arg_337_0 As Control = Me.Label3
			location = New Point(12, 100)
			arg_337_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_35E_0 As Control = Me.Label3
			size = New Size(46, 13)
			arg_35E_0.Size = size
			Me.Label3.TabIndex = 18
			Me.Label3.Text = "Tiêu " & ChrW(273) & ChrW(7873) & ":"
			Me.txtTextDesc.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_39F_0 As Control = Me.txtTextDesc
			location = New Point(11, 116)
			arg_39F_0.Location = location
			Me.txtTextDesc.Name = "txtTextDesc"
			Dim arg_3C9_0 As Control = Me.txtTextDesc
			size = New Size(446, 21)
			arg_3C9_0.Size = size
			Me.txtTextDesc.TabIndex = 3
			Dim arg_3EC_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_3EC_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_416_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_416_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "10"
			Me.Label6.AutoSize = True
			Dim arg_455_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_455_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_47C_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_47C_0.Size = size
			Me.Label6.TabIndex = 30
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_4B0_0 As Control = Me.txtDuration
			location = New Point(121, 69)
			arg_4B0_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_4D7_0 As Control = Me.txtDuration
			size = New Size(54, 21)
			arg_4D7_0.Size = size
			Me.txtDuration.TabIndex = 2
			Me.txtDuration.Text = "0"
			Me.Label8.AutoSize = True
			Dim arg_516_0 As Control = Me.Label8
			location = New Point(12, 72)
			arg_516_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_53D_0 As Control = Me.Label8
			size = New Size(54, 13)
			arg_53D_0.Size = size
			Me.Label8.TabIndex = 36
			Me.Label8.Text = "Th" & ChrW(7901) & "i gian:"
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = SystemColors.ActiveCaption
			Dim arg_590_0 As Control = Me.Label2
			location = New Point(186, 72)
			arg_590_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_5BA_0 As Control = Me.Label2
			size = New Size(272, 13)
			arg_5BA_0.Size = size
			Me.Label2.TabIndex = 37
			Me.Label2.Text = "(=0 n" & ChrW(7871) & "u mu" & ChrW(7889) & "n Tiêu " & ChrW(273) & ChrW(7873) & " hi" & ChrW(7879) & "n cho " & ChrW(273) & ChrW(7871) & "n khi có tiêu " & ChrW(273) & ChrW(7873) & " khác)"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(469, 195)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.txtTextDesc)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtActionName)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActCornerTitle"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgFlyAction"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub UpdateAction()
			Me.ActionDef.Name = Me.txtActionName.Text
			Me.ActionDef.start = Me.txtStart.Text
			Me.ActionDef.CornerText = Me.txtTextDesc.Text
			Me.ActionDef.duration = Me.txtDuration.Text
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
				Me.UpdateAction()
				modSaBan.fActions.bDirty = True
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Interaction.MsgBox("Ch" & ChrW(432) & "a OK.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CCornerTitleDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub dlgExplodeAction_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgExplodeAction_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = "Tiêu " & ChrW(273) & ChrW(7873) & " góc"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtStart.Text = Me.ActionDef.start
			Me.txtDuration.Text = Me.ActionDef.duration
			Me.txtTextDesc.Font = New Font(modSaBan.MenuFontName, modSaBan.MenuFontSize, modSaBan.MenuFontStyle, GraphicsUnit.Point)
			Me.txtTextDesc.ForeColor = modSaBan.ActColor
			Me.txtTextDesc.Text = Me.ActionDef.CornerText
			Me.txtTextDesc.BackColor = modSaBan.BGrColor
		End Sub
	End Class
End Namespace
