Imports AxMapXLib
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgOLuoiGoto
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("btnOK")>
		Private _btnOK As Button

		<AccessedThroughProperty("txtX")>
		Private _txtX As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As System.Windows.Forms.Label

		<AccessedThroughProperty("txtY")>
		Private _txtY As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As System.Windows.Forms.Label

		Friend Overridable Property btnOK() As Button
			Get
				Return Me._btnOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOK_Click
				If Me._btnOK IsNot Nothing Then
					RemoveHandler Me._btnOK.Click, value2
				End If
				Me._btnOK = value
				If Me._btnOK IsNot Nothing Then
					AddHandler Me._btnOK.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtX() As TextBox
			Get
				Return Me._txtX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtX = value
			End Set
		End Property

		Friend Overridable Property Label2() As System.Windows.Forms.Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property txtY() As TextBox
			Get
				Return Me._txtY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtY = value
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

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgOLuoiGoto_Load
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
			Me.btnOK = New Button()
			Me.txtX = New TextBox()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.txtY = New TextBox()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			Dim arg_4F_0 As Control = Me.btnOK
			Dim location As System.Drawing.Point = New System.Drawing.Point(33, 84)
			arg_4F_0.Location = location
			Me.btnOK.Name = "btnOK"
			Dim arg_76_0 As Control = Me.btnOK
			Dim size As Size = New Size(88, 24)
			arg_76_0.Size = size
			Me.btnOK.TabIndex = 21
			Me.btnOK.Text = "Nh" & ChrW(7849) & "y"
			Dim arg_AA_0 As Control = Me.txtX
			location = New System.Drawing.Point(57, 44)
			arg_AA_0.Location = location
			Me.txtX.Name = "txtX"
			Dim arg_D1_0 As Control = Me.txtX
			size = New Size(64, 21)
			arg_D1_0.Size = size
			Me.txtX.TabIndex = 20
			Me.txtX.Text = "82"
			Dim arg_105_0 As Control = Me.Label2
			location = New System.Drawing.Point(17, 52)
			arg_105_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_12C_0 As Control = Me.Label2
			size = New Size(26, 23)
			arg_12C_0.Size = size
			Me.Label2.TabIndex = 19
			Me.Label2.Text = "x:"
			Dim arg_160_0 As Control = Me.txtY
			location = New System.Drawing.Point(57, 20)
			arg_160_0.Location = location
			Me.txtY.Name = "txtY"
			Dim arg_187_0 As Control = Me.txtY
			size = New Size(64, 21)
			arg_187_0.Size = size
			Me.txtY.TabIndex = 18
			Me.txtY.Text = "171"
			Dim arg_1BB_0 As Control = Me.Label1
			location = New System.Drawing.Point(17, 20)
			arg_1BB_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_1E2_0 As Control = Me.Label1
			size = New Size(34, 23)
			arg_1E2_0.Size = size
			Me.Label1.TabIndex = 17
			Me.Label1.Text = "y:"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(138, 128)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.txtX)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtY)
			Me.Controls.Add(Me.Label1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgOLuoiGoto"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Nh" & ChrW(7849) & "y t" & ChrW(7899) & "i Ô"
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

		Private Sub dlgOLuoiGoto_Load(sender As Object, e As EventArgs)
			Me.txtX.Text = Conversions.ToString(modBanDo.OLuoiX)
			Me.txtY.Text = Conversions.ToString(modBanDo.OLuoiY)
		End Sub

		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			Dim centerX As Double = modBanDo.OLuoiKinhDo + (Conversion.Val(Me.txtX.Text) - CDec(modBanDo.OLuoiX) + 0.5) / modBanDo.OluoiXRate
			Dim centerY As Double = modBanDo.OLuoiViDo + (Conversion.Val(Me.txtY.Text) - CDec(modBanDo.OLuoiY) + 0.5) / modBanDo.OluoiYRate
			myModule.fMain.AxMap1.CenterX = centerX
			myModule.fMain.AxMap1.CenterY = centerY
			Dim num As Double = modBanDo.OLuoiKinhDo + (Conversion.Val(Me.txtX.Text) - CDec(modBanDo.OLuoiX)) / modBanDo.OluoiXRate
			Dim num2 As Double = modBanDo.OLuoiViDo + (Conversion.Val(Me.txtY.Text) - CDec(modBanDo.OLuoiY)) / modBanDo.OluoiYRate
			Dim num3 As Double = modBanDo.OLuoiKinhDo + (Conversion.Val(Me.txtX.Text) - CDec(modBanDo.OLuoiX) + 1.0) / modBanDo.OluoiXRate
			Dim num4 As Double = modBanDo.OLuoiViDo + (Conversion.Val(Me.txtY.Text) - CDec(modBanDo.OLuoiY) + 1.0) / modBanDo.OluoiYRate
			Dim arg_140_0 As AxMap = myModule.fMain.AxMap1
			Dim num6 As Integer
			Dim num5 As Single = CSng(num6)
			Dim num8 As Integer
			Dim num7 As Single = CSng(num8)
			arg_140_0.ConvertCoord(num5, num7, num, num2, ConversionConstants.miMapToScreen)
			' The following expression was wrapped in a checked-statement
			num8 = CInt(Math.Round(CDec(num7)))
			num6 = CInt(Math.Round(CDec(num5)))
			Dim arg_177_0 As AxMap = myModule.fMain.AxMap1
			Dim num9 As Integer
			num7 = CSng(num9)
			Dim num10 As Integer
			num5 = CSng(num10)
			arg_177_0.ConvertCoord(num7, num5, num3, num4, ConversionConstants.miMapToScreen)
			num10 = CInt(Math.Round(CDec(num5)))
			num9 = CInt(Math.Round(CDec(num7)))
			Me.NhapNhay(CInt(Math.Round(CDec((num6 + num9)) / 2.0)), CInt(Math.Round(CDec((num8 + num10)) / 2.0)))
			Dim drawingRect As System.Drawing.Rectangle = New System.Drawing.Rectangle(num6, num10, num9 - num6, num8 - num10)
			Me.DrawRectangle(drawingRect)
		End Sub

		Private Sub NhapNhay(pPTx As Integer, pPTy As Integer)
			Dim graphics As Graphics = myModule.fMain.AxMap1.CreateGraphics()
			Dim pen As Pen = New Pen(Color.Red, 2F)
			Dim pen2 As Pen = New Pen(Color.White, 2F)
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Do
				Me.DanhDau(graphics, pPTx, pPTy, pen)
				Thread.Sleep(40)
				myModule.fMain.AxMap1.Refresh()
				Me.DanhDau(graphics, pPTx, pPTy, pen2)
				Thread.Sleep(40)
				myModule.fMain.AxMap1.Refresh()
				num += 1
			Loop While num <= 5
			pen.Dispose()
			pen2.Dispose()
			graphics.Dispose()
		End Sub

		Private Sub DanhDau(g As Graphics, pPTx As Integer, pPTy As Integer, pPen As Pen)
			' The following expression was wrapped in a checked-statement
			g.DrawLine(pPen, pPTx - 7, pPTy - 7, pPTx + 7, pPTy + 7)
			g.DrawLine(pPen, pPTx - 7, pPTy + 7, pPTx + 7, pPTy - 7)
		End Sub

		Private Sub DrawRectangle(DrawingRect As System.Drawing.Rectangle)
			Dim graphics As Graphics = myModule.fMain.AxMap1.CreateGraphics()
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			Dim rect As System.Drawing.Rectangle
			rect.Size = DrawingRect.Size
			' The following expression was wrapped in a checked-statement
			If DrawingRect.Width < 0 Then
				rect.X = DrawingRect.X - rect.Width
			Else
				rect.X = DrawingRect.X
			End If
			If DrawingRect.Height < 0 Then
				rect.Y = DrawingRect.Y - rect.Height
			Else
				rect.Y = DrawingRect.Y
			End If
			graphics.DrawRectangle(pen, rect)
			pen.Dispose()
			Dim pen2 As Pen = New Pen(Color.Red, 2F)
			Me.DanhDau(graphics, CInt(Math.Round(CDec((rect.Left + rect.Right)) / 2.0)), CInt(Math.Round(CDec((rect.Top + rect.Bottom)) / 2.0)), pen2)
			pen2.Dispose()
			graphics.Dispose()
		End Sub
	End Class
End Namespace
