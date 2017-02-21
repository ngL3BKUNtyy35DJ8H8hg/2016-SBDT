Imports DanhMuc
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgPhanLoaiKH
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("DMucCtrl1")>
		Private _DMucCtrl1 As DMucCtrl

		Private myKHConnStr As String

		Friend Overridable Property DMucCtrl1() As DMucCtrl
			<DebuggerNonUserCode()>
			Get
				Return Me._DMucCtrl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DMucCtrl)
				Me._DMucCtrl1 = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgPhanLoaiKH_Load
			dlgPhanLoaiKH.__ENCList.Add(New WeakReference(Me))
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
			Me.DMucCtrl1 = New DMucCtrl()
			Me.SuspendLayout()
			Me.DMucCtrl1.BxFieldName = ""
			Me.DMucCtrl1.ConnStr = ""
			Me.DMucCtrl1.CuoiFieldName = ""
			Me.DMucCtrl1.DMIDFieldName = ""
			Me.DMucCtrl1.DMIDValue = 0
			Me.DMucCtrl1.Dock = DockStyle.Fill
			Me.DMucCtrl1.FilterFieldName = ""
			Me.DMucCtrl1.FilterValue = 0
			Dim arg_A1_0 As Control = Me.DMucCtrl1
			Dim location As Point = New Point(0, 0)
			arg_A1_0.Location = location
			Me.DMucCtrl1.MaFieldName = ""
			Me.DMucCtrl1.MucLen = 2
			Me.DMucCtrl1.Name = "DMucCtrl1"
			Me.DMucCtrl1.Password = ""
			Dim arg_100_0 As Control = Me.DMucCtrl1
			Dim size As Size = New Size(583, 315)
			arg_100_0.Size = size
			Me.DMucCtrl1.TabIndex = 0
			Me.DMucCtrl1.TableName = ""
			Me.DMucCtrl1.TenCay = ""
			Me.DMucCtrl1.TenFieldName = ""
			Me.DMucCtrl1.UserID = ""
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(583, 315)
			Me.ClientSize = size
			Me.Controls.Add(Me.DMucCtrl1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgPhanLoaiKH"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgPhanLoaiKH"
			Me.ResumeLayout(False)
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgPhanLoaiKH_Load(sender As Object, e As EventArgs)
			Me.Text = "Phân nhóm Ký hi" & ChrW(7879) & "u"
			Me.myKHConnStr = "File Name = " + modBanDo.myCacKyHieuUDL
			Dim dMucCtrl As DMucCtrl = Me.DMucCtrl1
			dMucCtrl.ConnStr = Me.myKHConnStr
			dMucCtrl.TableName = "tblLoaiKH"
			dMucCtrl.MaFieldName = "MaLoaiKH"
			dMucCtrl.TenFieldName = "TenLoaiKH"
			dMucCtrl.CuoiFieldName = "Cuoi"
			dMucCtrl.TenCay = "Các nhóm"
			dMucCtrl.LoadDanhMuc()
		End Sub
	End Class
End Namespace
