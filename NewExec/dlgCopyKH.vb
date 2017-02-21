Imports DanhMuc
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
	Public Class dlgCopyKH
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("DBiTraDM1")>
		Private _DBiTraDM1 As DBiTraDM

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("txtLoaiKH_ID")>
		Private _txtLoaiKH_ID As TextBox

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

		Friend Overridable Property DBiTraDM1() As DBiTraDM
			Get
				Return Me._DBiTraDM1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DBiTraDM)
				Dim obj As DBiTraDM.DaChonEventHandler = AddressOf Me.DBiTraDM1_DaChon
				If Me._DBiTraDM1 IsNot Nothing Then
					RemoveHandler Me._DBiTraDM1.DaChon, obj
				End If
				Me._DBiTraDM1 = value
				If Me._DBiTraDM1 IsNot Nothing Then
					AddHandler Me._DBiTraDM1.DaChon, obj
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

		Friend Overridable Property txtLoaiKH_ID() As TextBox
			Get
				Return Me._txtLoaiKH_ID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtLoaiKH_ID = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgCopyKH_Load
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
			Me.DBiTraDM1 = New DBiTraDM()
			Me.Label1 = New Label()
			Me.txtLoaiKH_ID = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_EC_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(277, 274)
			arg_EC_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_13E_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_13E_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_16B_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_16B_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_192_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_192_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1DC_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1DC_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_203_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_203_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.DBiTraDM1.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.DBiTraDM1.ConnStr = ""
			Me.DBiTraDM1.CuoiFieldName = "Cuoi"
			Me.DBiTraDM1.DMIDFieldName = ""
			Me.DBiTraDM1.DMIDValue = 0
			Me.DBiTraDM1.FilterFieldName = ""
			Me.DBiTraDM1.FilterValue = 0
			Me.DBiTraDM1.IDFieldName = "LoaiKH_ID"
			Me.DBiTraDM1.IDValue = 0L
			Dim arg_2B8_0 As Control = Me.DBiTraDM1
			location = New Point(12, 12)
			arg_2B8_0.Location = location
			Me.DBiTraDM1.MaFieldName = "MaLoaiKH"
			Me.DBiTraDM1.MucLen = 2
			Me.DBiTraDM1.myCayDM = Nothing
			Me.DBiTraDM1.Name = "DBiTraDM1"
			Me.DBiTraDM1.Password = ""
			Dim arg_31D_0 As Control = Me.DBiTraDM1
			size = New Size(411, 247)
			arg_31D_0.Size = size
			Me.DBiTraDM1.TabIndex = 1
			Me.DBiTraDM1.TableName = "tblLoaiKH"
			Me.DBiTraDM1.TenFieldName = "TenLoaiKH"
			Me.DBiTraDM1.TextValue = ""
			Me.DBiTraDM1.UserID = ""
			Me.Label1.AutoSize = True
			Dim arg_38F_0 As Control = Me.Label1
			location = New Point(10, 282)
			arg_38F_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_3B6_0 As Control = Me.Label1
			size = New Size(35, 13)
			arg_3B6_0.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Copy "
			Dim arg_3EF_0 As Control = Me.txtLoaiKH_ID
			location = New Point(205, 291)
			arg_3EF_0.Location = location
			Me.txtLoaiKH_ID.Name = "txtLoaiKH_ID"
			Dim arg_416_0 As Control = Me.txtLoaiKH_ID
			size = New Size(56, 21)
			arg_416_0.Size = size
			Me.txtLoaiKH_ID.TabIndex = 3
			Me.txtLoaiKH_ID.Text = "0"
			Me.txtLoaiKH_ID.Visible = False
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(435, 315)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtLoaiKH_ID)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.DBiTraDM1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCopyKH"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgCopyKH"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Conversions.ToDouble(Me.txtLoaiKH_ID.Text) > 0.0 Then
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Interaction.MsgBox("Ch" & ChrW(432) & "a ch" & ChrW(7885) & "n Nhóm ký hi" & ChrW(7879) & "u ...", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgCopyKH_Load(sender As Object, e As EventArgs)
			Me.Text = "Copy ký hi" & ChrW(7879) & "u"
			Dim dBiTraDM As DBiTraDM = Me.DBiTraDM1
			dBiTraDM.KhoiDong(0L)
		End Sub

		Private Sub DBiTraDM1_DaChon(IdValue As Long, TxtValue As String, MaValue As String)
			Me.txtLoaiKH_ID.Text = Conversions.ToString(IdValue)
			Me.Label1.Text = "Copy vào nhóm '" + TxtValue + "'?"
		End Sub
	End Class
End Namespace
