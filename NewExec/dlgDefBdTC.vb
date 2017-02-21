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
	Public Class dlgDefBdTC
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("txtKinhDo")>
		Private _txtKinhDo As TextBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("txtViDo")>
		Private _txtViDo As TextBox

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		<AccessedThroughProperty("btnZoomTo")>
		Private _btnZoomTo As Button

		<AccessedThroughProperty("btnDieuChinh")>
		Private _btnDieuChinh As Button

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtTyLeLayKH")>
		Private _txtTyLeLayKH As TextBox

		<AccessedThroughProperty("txtTyLeBanDo")>
		Private _txtTyLeBanDo As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		Private m_Zoom As Double

		Private m_PhanTramMax As Integer

		Private m_PhanTramMin As Integer

		Private m_BDTyLeBanDo As Integer

		Private m_BDKinhDo As Double

		Private m_BDViDo As Double

		Private m_BDTyLeLayKH As Integer

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

		Friend Overridable Property GroupBox1() As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property txtKinhDo() As TextBox
			Get
				Return Me._txtKinhDo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtKinhDo = value
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

		Friend Overridable Property txtViDo() As TextBox
			Get
				Return Me._txtViDo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtViDo = value
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

		Friend Overridable Property btnZoomTo() As Button
			Get
				Return Me._btnZoomTo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnZoomTo_Click
				If Me._btnZoomTo IsNot Nothing Then
					RemoveHandler Me._btnZoomTo.Click, value2
				End If
				Me._btnZoomTo = value
				If Me._btnZoomTo IsNot Nothing Then
					AddHandler Me._btnZoomTo.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnDieuChinh() As Button
			Get
				Return Me._btnDieuChinh
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDieuChinh_Click
				If Me._btnDieuChinh IsNot Nothing Then
					RemoveHandler Me._btnDieuChinh.Click, value2
				End If
				Me._btnDieuChinh = value
				If Me._btnDieuChinh IsNot Nothing Then
					AddHandler Me._btnDieuChinh.Click, value2
				End If
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

		Friend Overridable Property txtTyLeLayKH() As TextBox
			Get
				Return Me._txtTyLeLayKH
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTyLeLayKH = value
			End Set
		End Property

		Friend Overridable Property txtTyLeBanDo() As TextBox
			Get
				Return Me._txtTyLeBanDo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTyLeBanDo_Validated
				If Me._txtTyLeBanDo IsNot Nothing Then
					RemoveHandler Me._txtTyLeBanDo.Validated, value2
				End If
				Me._txtTyLeBanDo = value
				If Me._txtTyLeBanDo IsNot Nothing Then
					AddHandler Me._txtTyLeBanDo.Validated, value2
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

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgDefBdTC_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgDefBdTC_Load
			Me.m_PhanTramMax = 800
			Me.m_PhanTramMin = 10
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
			Me.GroupBox1 = New GroupBox()
			Me.txtKinhDo = New TextBox()
			Me.Label8 = New Label()
			Me.txtViDo = New TextBox()
			Me.Label9 = New Label()
			Me.btnZoomTo = New Button()
			Me.btnDieuChinh = New Button()
			Me.Label4 = New Label()
			Me.txtTyLeLayKH = New TextBox()
			Me.txtTyLeBanDo = New TextBox()
			Me.Label1 = New Label()
			Me.Label2 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_157_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(81, 258)
			arg_157_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1A9_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1A9_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1D6_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1D6_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1FD_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1FD_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_247_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_247_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_26E_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_26E_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.GroupBox1.Controls.Add(Me.txtKinhDo)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.txtViDo)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.btnZoomTo)
			Me.GroupBox1.Controls.Add(Me.btnDieuChinh)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.txtTyLeLayKH)
			Me.GroupBox1.Controls.Add(Me.txtTyLeBanDo)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Dim arg_393_0 As Control = Me.GroupBox1
			location = New Point(12, 12)
			arg_393_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_3C0_0 As Control = Me.GroupBox1
			size = New Size(216, 231)
			arg_3C0_0.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Dim arg_3F2_0 As Control = Me.txtKinhDo
			location = New Point(136, 97)
			arg_3F2_0.Location = location
			Me.txtKinhDo.Name = "txtKinhDo"
			Dim arg_419_0 As Control = Me.txtKinhDo
			size = New Size(64, 21)
			arg_419_0.Size = size
			Me.txtKinhDo.TabIndex = 4
			Me.txtKinhDo.Text = "105.2980"
			Dim arg_44C_0 As Control = Me.Label8
			location = New Point(80, 97)
			arg_44C_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_473_0 As Control = Me.Label8
			size = New Size(48, 23)
			arg_473_0.Size = size
			Me.Label8.TabIndex = 27
			Me.Label8.Text = "Kinh " & ChrW(273) & ChrW(7897) & ":"
			Dim arg_4AA_0 As Control = Me.txtViDo
			location = New Point(136, 73)
			arg_4AA_0.Location = location
			Me.txtViDo.Name = "txtViDo"
			Dim arg_4D1_0 As Control = Me.txtViDo
			size = New Size(64, 21)
			arg_4D1_0.Size = size
			Me.txtViDo.TabIndex = 3
			Me.txtViDo.Text = "21.4469"
			Dim arg_504_0 As Control = Me.Label9
			location = New Point(88, 73)
			arg_504_0.Location = location
			Me.Label9.Name = "Label9"
			Dim arg_52B_0 As Control = Me.Label9
			size = New Size(40, 23)
			arg_52B_0.Size = size
			Me.Label9.TabIndex = 25
			Me.Label9.Text = "V" & ChrW(297) & " " & ChrW(273) & ChrW(7897) & ":"
			Dim arg_55F_0 As Control = Me.btnZoomTo
			location = New Point(112, 124)
			arg_55F_0.Location = location
			Me.btnZoomTo.Name = "btnZoomTo"
			Dim arg_586_0 As Control = Me.btnZoomTo
			size = New Size(88, 23)
			arg_586_0.Size = size
			Me.btnZoomTo.TabIndex = 6
			Me.btnZoomTo.Text = "Thu phóng B" & ChrW(272)
			Dim arg_5BC_0 As Control = Me.btnDieuChinh
			location = New Point(112, 188)
			arg_5BC_0.Location = location
			Me.btnDieuChinh.Name = "btnDieuChinh"
			Dim arg_5E3_0 As Control = Me.btnDieuChinh
			size = New Size(88, 23)
			arg_5E3_0.Size = size
			Me.btnDieuChinh.TabIndex = 8
			Me.btnDieuChinh.Text = ChrW(272) & "i" & ChrW(7873) & "u ch" & ChrW(7881) & "nh"
			Dim arg_615_0 As Control = Me.Label4
			location = New Point(8, 57)
			arg_615_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_63C_0 As Control = Me.Label4
			size = New Size(96, 16)
			arg_63C_0.Size = size
			Me.Label4.TabIndex = 20
			Me.Label4.Text = "To" & ChrW(7841) & " " & ChrW(273) & ChrW(7897) & " trung tâm:"
			Me.txtTyLeLayKH.Enabled = False
			Dim arg_67F_0 As Control = Me.txtTyLeLayKH
			location = New Point(64, 188)
			arg_67F_0.Location = location
			Me.txtTyLeLayKH.Name = "txtTyLeLayKH"
			Dim arg_6A6_0 As Control = Me.txtTyLeLayKH
			size = New Size(40, 21)
			arg_6A6_0.Size = size
			Me.txtTyLeLayKH.TabIndex = 7
			Me.txtTyLeLayKH.Text = "100"
			Dim arg_6DC_0 As Control = Me.txtTyLeBanDo
			location = New Point(136, 25)
			arg_6DC_0.Location = location
			Me.txtTyLeBanDo.Name = "txtTyLeBanDo"
			Dim arg_703_0 As Control = Me.txtTyLeBanDo
			size = New Size(64, 21)
			arg_703_0.Size = size
			Me.txtTyLeBanDo.TabIndex = 0
			Me.txtTyLeBanDo.Text = "100000"
			Dim arg_735_0 As Control = Me.Label1
			location = New Point(8, 25)
			arg_735_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_75F_0 As Control = Me.Label1
			size = New Size(128, 23)
			arg_75F_0.Size = size
			Me.Label1.TabIndex = 10
			Me.Label1.Text = "T" & ChrW(7927) & " l" & ChrW(7879) & " B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " (1:xxxxxx):"
			Dim arg_795_0 As Control = Me.Label2
			location = New Point(8, 164)
			arg_795_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_7BF_0 As Control = Me.Label2
			size = New Size(176, 32)
			arg_7BF_0.Size = size
			Me.Label2.TabIndex = 14
			Me.Label2.Text = "Ký hi" & ChrW(7879) & "u " & ChrW(273) & ChrW(432) & ChrW(7907) & "c l" & ChrW(7845) & "y vào B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " v" & ChrW(7899) & "i t" & ChrW(7927) & " l" & ChrW(7879) & " (%):"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(239, 299)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgDefBdTC"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "S" & ChrW(7889) & " li" & ChrW(7879) & "u m" & ChrW(7863) & "c " & ChrW(273) & ChrW(7883) & "nh c" & ChrW(7911) & "a  B" & ChrW(272) & "TC"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private Sub TinhLai()
			Me.m_BDTyLeBanDo = Conversions.ToInteger(Conversion.Int(Me.txtTyLeBanDo.Text))
			Me.m_BDKinhDo = Conversions.ToDouble(Me.txtKinhDo.Text)
			Me.m_BDViDo = Conversions.ToDouble(Me.txtViDo.Text)
			Me.m_Zoom = modBanDo.GetZoomLevel(myModule.fMain.AxMap1, Me.m_BDTyLeBanDo)
		End Sub

		Private Sub ChapNhan()
			Me.TinhLai()
			modBdTC.BDTyLeLayKH = Conversions.ToInteger(Conversion.Int(Me.txtTyLeLayKH.Text))
			modBanDo.BDTyLeBanDo = Me.m_BDTyLeBanDo
			modBanDo.BDKinhDo = Me.m_BDKinhDo
			modBanDo.BDViDo = Me.m_BDViDo
			myModule.fMain.bNewBdTC = True
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.ChapNhan()
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgDefBdTC_FormClosing(sender As Object, e As FormClosingEventArgs)
			modBdTC.fDefBDTC = Nothing
		End Sub

		Private Sub dlgDefBdTC_Load(sender As Object, e As EventArgs)
			modBdTC.fDefBDTC = Me
			Dim location As Point = New Point(10, 10)
			Me.Location = location
			Me.m_BDTyLeBanDo = modBanDo.GetTyLeBD(myModule.fMain.AxMap1, myModule.fMain.AxMap1.Zoom)
			Me.txtTyLeBanDo.Text = Conversions.ToString(Me.m_BDTyLeBanDo)
			' The following expression was wrapped in a checked-expression
			Me.m_BDTyLeLayKH = CInt(Math.Round(CDec((modBdTC.BDTyLeLayKH * modBanDo.BDTyLeBanDo)) / CDec(Me.m_BDTyLeBanDo)))
			Me.txtTyLeLayKH.Text = Conversions.ToString(Me.m_BDTyLeLayKH)
			Me.txtKinhDo.Text = Conversions.ToString(myModule.fMain.AxMap1.CenterX)
			Me.txtViDo.Text = Conversions.ToString(myModule.fMain.AxMap1.CenterY)
			Me.TinhLai()
		End Sub

		Private Sub txtTyLeBanDo_Validated(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Integer = Conversions.ToInteger(Operators.DivideObject(modBanDo.BDTyLeBanDo * modBdTC.BDTyLeLayKH, Conversion.Int(Me.txtTyLeBanDo.Text)))
			If num > Me.m_PhanTramMax Then
				num = Me.m_PhanTramMax
			End If
			If num < Me.m_PhanTramMin Then
				num = Me.m_PhanTramMin
			End If
			Me.txtTyLeLayKH.Text = Conversions.ToString(num)
		End Sub

		Private Sub btnZoomTo_Click(sender As Object, e As EventArgs)
			Me.TinhLai()
			myModule.fMain.AxMap1.ZoomTo(Me.m_Zoom, Me.m_BDKinhDo, Me.m_BDViDo)
		End Sub

		Private Sub btnDieuChinh_Click(sender As Object, e As EventArgs)
			Me.TinhLai()
			myModule.fMain.AxMap1.ZoomTo(Me.m_Zoom, Me.m_BDKinhDo, Me.m_BDViDo)
			Dim dlgChonTyLeKH As dlgChonTyLeKH = New dlgChonTyLeKH()
			dlgChonTyLeKH.nudPhanTram.Maximum = New Decimal(Me.m_PhanTramMax)
			dlgChonTyLeKH.nudPhanTram.Minimum = New Decimal(Me.m_PhanTramMin)
			dlgChonTyLeKH.HScrollBar1.Maximum = Me.m_PhanTramMax
			dlgChonTyLeKH.HScrollBar1.Minimum = Me.m_PhanTramMin
			Dim num As Integer = Conversions.ToInteger(Me.txtTyLeLayKH.Text)
			If num > Me.m_PhanTramMax Then
				num = Me.m_PhanTramMax
			End If
			If num < Me.m_PhanTramMin Then
				num = Me.m_PhanTramMin
			End If
			Me.txtTyLeLayKH.Text = Conversions.ToString(num)
			dlgChonTyLeKH.nudPhanTram.Value = New Decimal(num)
			dlgChonTyLeKH.fparent = Me
			dlgChonTyLeKH.ShowDialog(Me)
		End Sub
	End Class
End Namespace
