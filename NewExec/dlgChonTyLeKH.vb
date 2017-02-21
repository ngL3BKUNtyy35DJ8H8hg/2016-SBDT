Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports MapXLib
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
	Public Class dlgChonTyLeKH
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("HScrollBar1")>
		Private _HScrollBar1 As HScrollBar

		<AccessedThroughProperty("txtKH")>
		Private _txtKH As TextBox

		<AccessedThroughProperty("btnChonKH")>
		Private _btnChonKH As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As System.Windows.Forms.Label

		<AccessedThroughProperty("nudPhanTram")>
		Private _nudPhanTram As NumericUpDown

		Public fparent As dlgDefBdTC

		Public mySymbol As CSymbol

		Friend Overridable Property HScrollBar1() As HScrollBar
			Get
				Return Me._HScrollBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HScrollBar)
				Dim value2 As EventHandler = AddressOf Me.HScrollBar1_ValueChanged
				If Me._HScrollBar1 IsNot Nothing Then
					RemoveHandler Me._HScrollBar1.ValueChanged, value2
				End If
				Me._HScrollBar1 = value
				If Me._HScrollBar1 IsNot Nothing Then
					AddHandler Me._HScrollBar1.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtKH() As TextBox
			Get
				Return Me._txtKH
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtKH = value
			End Set
		End Property

		Friend Overridable Property btnChonKH() As Button
			Get
				Return Me._btnChonKH
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnChonKH_Click
				If Me._btnChonKH IsNot Nothing Then
					RemoveHandler Me._btnChonKH.Click, value2
				End If
				Me._btnChonKH = value
				If Me._btnChonKH IsNot Nothing Then
					AddHandler Me._btnChonKH.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label1() As System.Windows.Forms.Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property nudPhanTram() As NumericUpDown
			Get
				Return Me._nudPhanTram
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Dim value2 As EventHandler = AddressOf Me.nudPhanTram_ValueChanged
				If Me._nudPhanTram IsNot Nothing Then
					RemoveHandler Me._nudPhanTram.ValueChanged, value2
				End If
				Me._nudPhanTram = value
				If Me._nudPhanTram IsNot Nothing Then
					AddHandler Me._nudPhanTram.ValueChanged, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgChonTyLeKH_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgChonTyLeKH_Load
			Me.mySymbol = Nothing
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
			Me.HScrollBar1 = New HScrollBar()
			Me.txtKH = New TextBox()
			Me.btnChonKH = New Button()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.nudPhanTram = New NumericUpDown()
			(CType(Me.nudPhanTram, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Dim arg_5A_0 As Control = Me.HScrollBar1
			Dim location As System.Drawing.Point = New System.Drawing.Point(12, 76)
			arg_5A_0.Location = location
			Me.HScrollBar1.Maximum = 400
			Me.HScrollBar1.Minimum = 10
			Me.HScrollBar1.Name = "HScrollBar1"
			Dim arg_A1_0 As Control = Me.HScrollBar1
			Dim size As Size = New Size(208, 16)
			arg_A1_0.Size = size
			Me.HScrollBar1.TabIndex = 7
			Me.HScrollBar1.Value = 100
			Dim arg_D1_0 As Control = Me.txtKH
			location = New System.Drawing.Point(12, 12)
			arg_D1_0.Location = location
			Me.txtKH.Name = "txtKH"
			Dim arg_FB_0 As Control = Me.txtKH
			size = New Size(208, 21)
			arg_FB_0.Size = size
			Me.txtKH.TabIndex = 11
			Dim arg_11F_0 As Control = Me.btnChonKH
			location = New System.Drawing.Point(11, 41)
			arg_11F_0.Location = location
			Me.btnChonKH.Name = "btnChonKH"
			Dim arg_146_0 As Control = Me.btnChonKH
			size = New Size(75, 23)
			arg_146_0.Size = size
			Me.btnChonKH.TabIndex = 10
			Me.btnChonKH.Text = "Ch" & ChrW(7885) & "n KH"
			Me.btnChonKH.UseVisualStyleBackColor = True
			Dim arg_189_0 As Control = Me.Label1
			location = New System.Drawing.Point(165, 44)
			arg_189_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_1B0_0 As Control = Me.Label1
			size = New Size(32, 16)
			arg_1B0_0.Size = size
			Me.Label1.TabIndex = 9
			Me.Label1.Text = "%"
			Dim arg_1E4_0 As Control = Me.nudPhanTram
			location = New System.Drawing.Point(117, 44)
			arg_1E4_0.Location = location
			Dim arg_21A_0 As NumericUpDown = Me.nudPhanTram
			Dim num As Decimal = New Decimal(New Integer() { 400, 0, 0, 0 })
			arg_21A_0.Maximum = num
			Dim arg_24D_0 As NumericUpDown = Me.nudPhanTram
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_24D_0.Minimum = num
			Me.nudPhanTram.Name = "nudPhanTram"
			Dim arg_274_0 As Control = Me.nudPhanTram
			size = New Size(48, 21)
			arg_274_0.Size = size
			Me.nudPhanTram.TabIndex = 8
			Dim arg_2B3_0 As NumericUpDown = Me.nudPhanTram
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			arg_2B3_0.Value = num
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(233, 113)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtKH)
			Me.Controls.Add(Me.btnChonKH)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.nudPhanTram)
			Me.Controls.Add(Me.HScrollBar1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChonTyLeKH"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Ch" & ChrW(7885) & "n T" & ChrW(7927) & " l" & ChrW(7879) & " Ký hi" & ChrW(7879) & "u"
			(CType(Me.nudPhanTram, ISupportInitialize)).EndInit()
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

		Private Sub dlgChonTyLeKH_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.fparent.txtTyLeLayKH.Text = Conversions.ToString(Me.nudPhanTram.Value)
			myModule.fMain.AxMap1.Refresh()
			modBdTC.fChonTyleKH = Nothing
		End Sub

		Private Sub dlgChonTyLeKH_Load(sender As Object, e As EventArgs)
			modBdTC.fChonTyleKH = Me
			Dim location As System.Drawing.Point = New System.Drawing.Point(40, 100)
			Me.Location = location
		End Sub

		Public Sub ChonKH()
			Me.txtKH.Text = modBdTC.fCacKyHieu.txtTenKH.Text
			Dim x As Single = 200F
			Dim y As Single = 100F
			Try
				Dim arg_67_0 As AxMap = myModule.fMain.AxMap1
				Dim num As Double = Conversions.ToDouble(Me.fparent.txtKinhDo.Text)
				Dim num2 As Double = Conversions.ToDouble(Me.fparent.txtViDo.Text)
				arg_67_0.ConvertCoord(x, y, num, num2, ConversionConstants.miMapToScreen)
			Catch expr_6E As Exception
				ProjectData.SetProjectError(expr_6E)
				ProjectData.ClearProjectError()
			End Try
			Dim pointF As PointF = New PointF(x, y)
			Dim obj As Object = pointF
			Dim arg_DD_0 As CBdTC = myModule.fMain.myBando
			Dim arg_DD_1 As String = modBdTC.fCacKyHieu.txtTenKH.Text
			Dim arg_DD_2 As CGraphicObjs = modBdTC.fCacKyHieu.OdrawingObjects
			Dim arg_DD_3 As Integer = modBdTC.fCacKyHieu.myORootX
			Dim arg_DD_4 As Integer = modBdTC.fCacKyHieu.myORootY
			Dim expr_C6 As Object = obj
			Dim pointF2 As PointF
			Me.mySymbol = arg_DD_0.GetKHfromVeKH(arg_DD_1, arg_DD_2, arg_DD_3, arg_DD_4, If((expr_C6 IsNot Nothing), (CType(expr_C6, PointF)), pointF2), 1F)
			Me.nudPhanTram.[Select]()
			SendKeys.Send("{UP}{DOWN}")
		End Sub

		Private Sub VeThu()
			If Not Information.IsNothing(Me.mySymbol) Then
				' The following expression was wrapped in a checked-expression
				Dim value As Integer = CInt(Math.Round(modBanDo.GetZoomLevel(myModule.fMain.AxMap1, Conversions.ToInteger(modBdTC.fDefBDTC.txtTyLeBanDo.Text))))
				Dim zoom As Double = Convert.ToDouble(Decimal.Divide(Decimal.Multiply(New Decimal(value), Me.nudPhanTram.Value), New Decimal(100L)))
				Dim mapScreenWidth As Single = myModule.fMain.AxMap1.MapScreenWidth
				Me.mySymbol.Zoom = zoom
				Me.mySymbol.MWidth = mapScreenWidth
				Dim g As Graphics = myModule.fMain.AxMap1.CreateGraphics()
				myModule.fMain.AxMap1.Refresh()
				Me.mySymbol.Draw(myModule.fMain.AxMap1, g)
			End If
		End Sub

		Private Sub nudPhanTram_ValueChanged(sender As Object, e As EventArgs)
			Me.HScrollBar1.Value = Convert.ToInt32(Me.nudPhanTram.Value)
			Me.VeThu()
		End Sub

		Private Sub HScrollBar1_ValueChanged(sender As Object, e As EventArgs)
			Me.nudPhanTram.Value = New Decimal(Me.HScrollBar1.Value)
		End Sub

		Private Sub btnChonKH_Click(sender As Object, e As EventArgs)
			If Information.IsNothing(modBdTC.fCacKyHieu) Then
				New dlgCacKyHieu() With { .TopMost = True }.ShowDialog(Me)
			End If
		End Sub
	End Class
End Namespace
