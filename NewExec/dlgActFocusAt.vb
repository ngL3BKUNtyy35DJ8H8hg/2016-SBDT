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
	Public Class dlgActFocusAt
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

		<AccessedThroughProperty("btnGetPath")>
		Private _btnGetPath As Button

		<AccessedThroughProperty("txtStart")>
		Private _txtStart As TextBox

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtCenterX")>
		Private _txtCenterX As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("txtCenterY")>
		Private _txtCenterY As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtAngleX")>
		Private _txtAngleX As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtAngleZ")>
		Private _txtAngleZ As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtCamX")>
		Private _txtCamX As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("txtCamY")>
		Private _txtCamY As TextBox

		<AccessedThroughProperty("txtCamZ")>
		Private _txtCamZ As TextBox

		<AccessedThroughProperty("btnGetCamera")>
		Private _btnGetCamera As Button

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("txtDuration")>
		Private _txtDuration As TextBox

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		Private Parentf As dlgActions

		Private ActionDef As CFocusAtDef

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

		Friend Overridable Property txtCenterX() As TextBox
			Get
				Return Me._txtCenterX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCenterX = value
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

		Friend Overridable Property txtCenterY() As TextBox
			Get
				Return Me._txtCenterY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCenterY = value
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

		Friend Overridable Property txtAngleX() As TextBox
			Get
				Return Me._txtAngleX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtAngleX = value
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

		Friend Overridable Property txtAngleZ() As TextBox
			Get
				Return Me._txtAngleZ
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtAngleZ = value
			End Set
		End Property

		Friend Overridable Property Label4() As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property txtCamX() As TextBox
			Get
				Return Me._txtCamX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCamX = value
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

		Friend Overridable Property txtCamY() As TextBox
			Get
				Return Me._txtCamY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCamY = value
			End Set
		End Property

		Friend Overridable Property txtCamZ() As TextBox
			Get
				Return Me._txtCamZ
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCamZ = value
			End Set
		End Property

		Friend Overridable Property btnGetCamera() As Button
			Get
				Return Me._btnGetCamera
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnGetCamera_Click
				If Me._btnGetCamera IsNot Nothing Then
					RemoveHandler Me._btnGetCamera.Click, value2
				End If
				Me._btnGetCamera = value
				If Me._btnGetCamera IsNot Nothing Then
					AddHandler Me._btnGetCamera.Click, value2
				End If
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

		Friend Overridable Property txtDuration() As TextBox
			Get
				Return Me._txtDuration
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDuration = value
			End Set
		End Property

		Friend Overridable Property Label9() As Label
			Get
				Return Me._Label9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
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
			Me.txtActionName = New TextBox()
			Me.btnGetPath = New Button()
			Me.txtStart = New TextBox()
			Me.Label6 = New Label()
			Me.txtCenterX = New TextBox()
			Me.Label8 = New Label()
			Me.txtCenterY = New TextBox()
			Me.Label2 = New Label()
			Me.txtAngleX = New TextBox()
			Me.Label3 = New Label()
			Me.txtAngleZ = New TextBox()
			Me.Label4 = New Label()
			Me.txtCamX = New TextBox()
			Me.Label5 = New Label()
			Me.txtCamY = New TextBox()
			Me.txtCamZ = New TextBox()
			Me.btnGetCamera = New Button()
			Me.Label7 = New Label()
			Me.txtDuration = New TextBox()
			Me.Label9 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_1B2_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(192, 342)
			arg_1B2_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_204_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_204_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 11
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_232_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_232_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_259_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_259_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_2A3_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_2A3_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_2CA_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_2CA_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_309_0 As Control = Me.Label1
			location = New Point(12, 18)
			arg_309_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_330_0 As Control = Me.Label1
			size = New Size(83, 13)
			arg_330_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên hành " & ChrW(273) & ChrW(7897) & "ng:"
			Dim arg_363_0 As Control = Me.txtActionName
			location = New Point(121, 15)
			arg_363_0.Location = location
			Me.txtActionName.Name = "txtActionName"
			Dim arg_38D_0 As Control = Me.txtActionName
			size = New Size(157, 21)
			arg_38D_0.Size = size
			Me.txtActionName.TabIndex = 0
			Dim arg_3B6_0 As Control = Me.btnGetPath
			location = New Point(190, 277)
			arg_3B6_0.Location = location
			Me.btnGetPath.Name = "btnGetPath"
			Dim arg_3E0_0 As Control = Me.btnGetPath
			size = New Size(139, 23)
			arg_3E0_0.Size = size
			Me.btnGetPath.TabIndex = 4
			Me.btnGetPath.Text = "L" & ChrW(7845) & "y Tiêu " & ChrW(273) & "i" & ChrW(7875) & "m trên B" & ChrW(272)
			Me.btnGetPath.UseVisualStyleBackColor = True
			Me.btnGetPath.Visible = False
			Dim arg_42B_0 As Control = Me.txtStart
			location = New Point(121, 42)
			arg_42B_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_455_0 As Control = Me.txtStart
			size = New Size(157, 21)
			arg_455_0.Size = size
			Me.txtStart.TabIndex = 1
			Me.txtStart.Text = "0"
			Me.Label6.AutoSize = True
			Dim arg_494_0 As Control = Me.Label6
			location = New Point(12, 45)
			arg_494_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_4BB_0 As Control = Me.Label6
			size = New Size(96, 13)
			arg_4BB_0.Size = size
			Me.Label6.TabIndex = 13
			Me.Label6.Text = "Th" & ChrW(7901) & "i " & ChrW(273) & "i" & ChrW(7875) & "m B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u:"
			Dim arg_4F2_0 As Control = Me.txtCenterX
			location = New Point(121, 304)
			arg_4F2_0.Location = location
			Me.txtCenterX.Name = "txtCenterX"
			Dim arg_519_0 As Control = Me.txtCenterX
			size = New Size(63, 21)
			arg_519_0.Size = size
			Me.txtCenterX.TabIndex = 2
			Me.txtCenterX.Text = "0.5"
			Me.Label8.AutoSize = True
			Dim arg_55B_0 As Control = Me.Label8
			location = New Point(39, 308)
			arg_55B_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_582_0 As Control = Me.Label8
			size = New Size(65, 13)
			arg_582_0.Size = size
			Me.Label8.TabIndex = 25
			Me.Label8.Text = "Tiêu " & ChrW(273) & "i" & ChrW(7875) & "m X:"
			Me.Label8.TextAlign = ContentAlignment.MiddleRight
			Dim arg_5C9_0 As Control = Me.txtCenterY
			location = New Point(215, 304)
			arg_5C9_0.Location = location
			Me.txtCenterY.Name = "txtCenterY"
			Dim arg_5F0_0 As Control = Me.txtCenterY
			size = New Size(63, 21)
			arg_5F0_0.Size = size
			Me.txtCenterY.TabIndex = 3
			Me.txtCenterY.Text = "0.5"
			Me.Label2.AutoSize = True
			Dim arg_635_0 As Control = Me.Label2
			location = New Point(192, 307)
			arg_635_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_65C_0 As Control = Me.Label2
			size = New Size(17, 13)
			arg_65C_0.Size = size
			Me.Label2.TabIndex = 27
			Me.Label2.Text = "Y:"
			Dim arg_693_0 As Control = Me.txtAngleX
			location = New Point(121, 257)
			arg_693_0.Location = location
			Me.txtAngleX.Name = "txtAngleX"
			Dim arg_6BA_0 As Control = Me.txtAngleX
			size = New Size(63, 21)
			arg_6BA_0.Size = size
			Me.txtAngleX.TabIndex = 9
			Me.txtAngleX.Text = "0.5"
			Me.Label3.AutoSize = True
			Dim arg_6FD_0 As Control = Me.Label3
			location = New Point(41, 260)
			arg_6FD_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_724_0 As Control = Me.Label3
			size = New Size(65, 13)
			arg_724_0.Size = size
			Me.Label3.TabIndex = 31
			Me.Label3.Text = "Góc quay X:"
			Dim arg_75B_0 As Control = Me.txtAngleZ
			location = New Point(121, 230)
			arg_75B_0.Location = location
			Me.txtAngleZ.Name = "txtAngleZ"
			Dim arg_782_0 As Control = Me.txtAngleZ
			size = New Size(63, 21)
			arg_782_0.Size = size
			Me.txtAngleZ.TabIndex = 8
			Me.txtAngleZ.Text = "0.5"
			Me.Label4.AutoSize = True
			Dim arg_7C4_0 As Control = Me.Label4
			location = New Point(42, 237)
			arg_7C4_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_7EB_0 As Control = Me.Label4
			size = New Size(65, 13)
			arg_7EB_0.Size = size
			Me.Label4.TabIndex = 29
			Me.Label4.Text = "Góc quay Z:"
			Me.Label4.TextAlign = ContentAlignment.MiddleRight
			Dim arg_82F_0 As Control = Me.txtCamX
			location = New Point(122, 203)
			arg_82F_0.Location = location
			Me.txtCamX.Name = "txtCamX"
			Dim arg_856_0 As Control = Me.txtCamX
			size = New Size(62, 21)
			arg_856_0.Size = size
			Me.txtCamX.TabIndex = 5
			Me.txtCamX.Text = "0.5"
			Me.Label5.AutoSize = True
			Dim arg_898_0 As Control = Me.Label5
			location = New Point(30, 205)
			arg_898_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_8BF_0 As Control = Me.Label5
			size = New Size(77, 13)
			arg_8BF_0.Size = size
			Me.Label5.TabIndex = 33
			Me.Label5.Text = "Camera X,Y,Z:"
			Me.Label5.TextAlign = ContentAlignment.MiddleRight
			Dim arg_906_0 As Control = Me.txtCamY
			location = New Point(190, 203)
			arg_906_0.Location = location
			Me.txtCamY.Name = "txtCamY"
			Dim arg_92D_0 As Control = Me.txtCamY
			size = New Size(57, 21)
			arg_92D_0.Size = size
			Me.txtCamY.TabIndex = 6
			Me.txtCamY.Text = "0.5"
			Dim arg_966_0 As Control = Me.txtCamZ
			location = New Point(253, 203)
			arg_966_0.Location = location
			Me.txtCamZ.Name = "txtCamZ"
			Dim arg_98D_0 As Control = Me.txtCamZ
			size = New Size(56, 21)
			arg_98D_0.Size = size
			Me.txtCamZ.TabIndex = 7
			Me.txtCamZ.Text = "0.5"
			Dim arg_9C3_0 As Control = Me.btnGetCamera
			location = New Point(121, 174)
			arg_9C3_0.Location = location
			Me.btnGetCamera.Name = "btnGetCamera"
			Dim arg_9ED_0 As Control = Me.btnGetCamera
			size = New Size(208, 23)
			arg_9ED_0.Size = size
			Me.btnGetCamera.TabIndex = 10
			Me.btnGetCamera.Text = "L" & ChrW(7845) & "y v" & ChrW(7883) & " trí góc nhìn Sa bàn"
			Me.btnGetCamera.UseVisualStyleBackColor = True
			Me.Label7.BorderStyle = BorderStyle.Fixed3D
			Me.Label7.Font = New Font("Times New Roman", 8.164948F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label7.ForeColor = SystemColors.ActiveCaption
			Dim arg_A66_0 As Control = Me.Label7
			location = New Point(15, 112)
			arg_A66_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_A90_0 As Control = Me.Label7
			size = New Size(323, 59)
			arg_A90_0.Size = size
			Me.Label7.TabIndex = 34
			Me.Label7.Text = "L" & ChrW(7845) & "y tiêu " & ChrW(273) & "i" & ChrW(7875) & "m 1 cách tr" & ChrW(7921) & "c quan:  T" & ChrW(7855) & "t c" & ChrW(7917) & "a s" & ChrW(7893) & " b" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & ". Zoom, nghiêng, xoay sa bàn, nháy kép vào tiêu " & ChrW(273) & "i" & ChrW(7875) & "m. Sau " & ChrW(273) & "ó b" & ChrW(7845) & "m nút 'L" & ChrW(7845) & "y_v" & ChrW(7883) & "_trí_góc_nhìn_sa_bàn' "
			Me.Label7.TextAlign = ContentAlignment.MiddleCenter
			Dim arg_AD1_0 As Control = Me.txtDuration
			location = New Point(122, 69)
			arg_AD1_0.Location = location
			Me.txtDuration.Name = "txtDuration"
			Dim arg_AFB_0 As Control = Me.txtDuration
			size = New Size(157, 21)
			arg_AFB_0.Size = size
			Me.txtDuration.TabIndex = 35
			Me.txtDuration.Text = "5"
			Me.Label9.AutoSize = True
			Dim arg_B3B_0 As Control = Me.Label9
			location = New Point(13, 72)
			arg_B3B_0.Location = location
			Me.Label9.Name = "Label9"
			Dim arg_B62_0 As Control = Me.Label9
			size = New Size(54, 13)
			arg_B62_0.Size = size
			Me.Label9.TabIndex = 36
			Me.Label9.Text = "Th" & ChrW(7901) & "i gian:"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(350, 383)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtDuration)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.btnGetCamera)
			Me.Controls.Add(Me.txtCamZ)
			Me.Controls.Add(Me.txtCamY)
			Me.Controls.Add(Me.txtCamX)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.txtAngleX)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtAngleZ)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtCenterY)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtCenterX)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.btnGetPath)
			Me.Controls.Add(Me.txtActionName)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActFocusAt"
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
			Me.ActionDef.duration = Me.txtDuration.Text
			Me.ActionDef.CenterX = Conversions.ToSingle(Me.txtCenterX.Text)
			Me.ActionDef.CenterY = Conversions.ToSingle(Me.txtCenterY.Text)
			Me.ActionDef.cameraPos.X = Conversions.ToSingle(Me.txtCamX.Text)
			Me.ActionDef.cameraPos.Y = Conversions.ToSingle(Me.txtCamY.Text)
			Me.ActionDef.cameraPos.Z = Conversions.ToSingle(Me.txtCamZ.Text)
			Me.ActionDef.angleZ = Conversions.ToSingle(Me.txtAngleZ.Text)
			Me.ActionDef.angleX = Conversions.ToSingle(Me.txtAngleX.Text)
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				Me.Parentf.AddAction(Me.ActionDef)
			Else
				Me.Parentf.UpdateAction()
			End If
		End Sub

		Private Function isOK() As Boolean
			Dim result As Boolean = False
			Dim num As Single = 0.5F
			Try
				num = Conversions.ToSingle(Me.txtCenterX.Text)
			Catch expr_1B As Exception
				ProjectData.SetProjectError(expr_1B)
				ProjectData.ClearProjectError()
			End Try
			Dim num2 As Single = 0.5F
			Try
				num2 = Conversions.ToSingle(Me.txtCenterY.Text)
			Catch expr_43 As Exception
				ProjectData.SetProjectError(expr_43)
				ProjectData.ClearProjectError()
			End Try
			If num >= 0F And num <= 1F And num2 >= 0F And num2 <= 1F Then
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
				Interaction.MsgBox("SL tiêu " & ChrW(273) & "i" & ChrW(7875) & "m không h" & ChrW(7907) & "p lý.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Sub Show(pform As dlgActions, pAction As CActDef, pMode As String)
			Me.Parentf = pform
			Me.ActionDef = CType(pAction, CFocusAtDef)
			Me.Mode = pMode
			Me.Show(Me.Parentf)
		End Sub

		Private Sub btnGetPath_Click(sender As Object, e As EventArgs)
			myModule.fMain.myVeActs.OnGetFocus(Me.txtCenterX, Me.txtCenterY)
		End Sub

		Private Sub dlgShootAction_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Parentf.bView = True
		End Sub

		Private Sub dlgShootAction_Load(sender As Object, e As EventArgs)
			Me.Parentf.bView = False
			Me.OK_Button.Text = Me.Mode
			Me.Text = "Tiêu " & ChrW(273) & "i" & ChrW(7875) & "m"
			Me.txtActionName.Text = Me.ActionDef.Name
			Me.txtStart.Text = Me.ActionDef.start
			Me.txtDuration.Text = Me.ActionDef.duration
			Me.txtCenterX.Text = Me.ActionDef.CenterX.ToString()
			Me.txtCenterY.Text = Me.ActionDef.CenterY.ToString()
			Me.txtCamX.Text = Conversions.ToString(Me.ActionDef.cameraPos.X)
			Me.txtCamY.Text = Conversions.ToString(Me.ActionDef.cameraPos.Y)
			Me.txtCamZ.Text = Conversions.ToString(Me.ActionDef.cameraPos.Z)
			Me.txtAngleZ.Text = Conversions.ToString(Me.ActionDef.angleZ)
			Me.txtAngleX.Text = Conversions.ToString(Me.ActionDef.angleX)
			myModule.fMain.myTerrain.ChangeFocus(Me.ActionDef.CenterX, Me.ActionDef.CenterY, Me.ActionDef.cameraPos, Me.ActionDef.angleZ, Me.ActionDef.angleX)
		End Sub

		Private Sub btnGetCamera_Click(sender As Object, e As EventArgs)
			Me.txtCenterX.Text = Conversions.ToString(myModule.fMain.myTerrain.CenterX)
			Me.txtCenterY.Text = Conversions.ToString(myModule.fMain.myTerrain.CenterY)
			Me.txtCamX.Text = Conversions.ToString(myModule.fMain.myTerrain.cameraPos.X)
			Me.txtCamY.Text = Conversions.ToString(myModule.fMain.myTerrain.cameraPos.Y)
			Me.txtCamZ.Text = Conversions.ToString(myModule.fMain.myTerrain.cameraPos.Z)
			Me.txtAngleZ.Text = Conversions.ToString(myModule.fMain.myTerrain.GetAngleZ())
			Me.txtAngleX.Text = Conversions.ToString(myModule.fMain.myTerrain.GetAngleX())
		End Sub
	End Class
End Namespace
