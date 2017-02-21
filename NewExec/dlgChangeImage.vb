Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgChangeImage
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("chkTransparent")>
		Private _chkTransparent As CheckBox

		<AccessedThroughProperty("txtTransparentColor")>
		Private _txtTransparentColor As TextBox

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

		Friend Overridable Property chkTransparent() As CheckBox
			Get
				Return Me._chkTransparent
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkTransparent = value
			End Set
		End Property

		Friend Overridable Property txtTransparentColor() As TextBox
			Get
				Return Me._txtTransparentColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTransparentColor_DoubleClick
				If Me._txtTransparentColor IsNot Nothing Then
					RemoveHandler Me._txtTransparentColor.DoubleClick, value2
				End If
				Me._txtTransparentColor = value
				If Me._txtTransparentColor IsNot Nothing Then
					AddHandler Me._txtTransparentColor.DoubleClick, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgChangeImage_Load
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
			Me.chkTransparent = New CheckBox()
			Me.txtTransparentColor = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_DB_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(12, 76)
			arg_DB_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_12D_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_12D_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_15A_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_15A_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_181_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_181_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1CB_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1CB_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_1F2_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_1F2_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_225_0 As Control = Me.chkTransparent
			location = New Point(12, 27)
			arg_225_0.Location = location
			Me.chkTransparent.Name = "chkTransparent"
			Dim arg_24C_0 As Control = Me.chkTransparent
			size = New Size(112, 24)
			arg_24C_0.Size = size
			Me.chkTransparent.TabIndex = 41
			Me.chkTransparent.Text = "Transparent color"
			Me.txtTransparentColor.BackColor = Color.Red
			Me.txtTransparentColor.ForeColor = SystemColors.HighlightText
			Dim arg_2A3_0 As Control = Me.txtTransparentColor
			location = New Point(130, 29)
			arg_2A3_0.Location = location
			Me.txtTransparentColor.Name = "txtTransparentColor"
			Dim arg_2CA_0 As Control = Me.txtTransparentColor
			size = New Size(24, 21)
			arg_2CA_0.Size = size
			Me.txtTransparentColor.TabIndex = 42
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(170, 117)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtTransparentColor)
			Me.Controls.Add(Me.chkTransparent)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChangeImage"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgChangeImage"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgChangeImage_Load(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtTransparentColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtTransparentColor.BackColor = modBdTC.GetMau(Me.txtTransparentColor.BackColor)
		End Sub
	End Class
End Namespace
