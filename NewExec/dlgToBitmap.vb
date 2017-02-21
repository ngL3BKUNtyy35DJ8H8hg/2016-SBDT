Imports AxMapXLib
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports ScreenCapture
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgToBitmap
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("txtMapScale")>
		Private _txtMapScale As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As System.Windows.Forms.Label

		Private m_Zoom As Double

		Private m_CenterX As Double

		Private m_CenterY As Double

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

		Friend Overridable Property txtMapScale() As TextBox
			Get
				Return Me._txtMapScale
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMapScale = value
			End Set
		End Property

		Friend Overridable Property Label5() As System.Windows.Forms.Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Label)
				Me._Label5 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgToBitmap_Load
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
			Me.txtMapScale = New TextBox()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_DB_0 As Control = Me.TableLayoutPanel1
			Dim location As System.Drawing.Point = New System.Drawing.Point(107, 62)
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
			location = New System.Drawing.Point(3, 3)
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
			location = New System.Drawing.Point(76, 3)
			arg_1CB_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_1F2_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_1F2_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_225_0 As Control = Me.txtMapScale
			location = New System.Drawing.Point(107, 25)
			arg_225_0.Location = location
			Me.txtMapScale.Name = "txtMapScale"
			Dim arg_24C_0 As Control = Me.txtMapScale
			size = New Size(80, 21)
			arg_24C_0.Size = size
			Me.txtMapScale.TabIndex = 13
			Dim arg_270_0 As Control = Me.Label5
			location = New System.Drawing.Point(26, 14)
			arg_270_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_297_0 As Control = Me.Label5
			size = New Size(75, 32)
			arg_297_0.Size = size
			Me.Label5.TabIndex = 14
			Me.Label5.Text = "T" & ChrW(7927) & " l" & ChrW(7879) & " b" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & "  (1:xxxxxx):"
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(265, 103)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtMapScale)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgToBitmap"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Xu" & ChrW(7845) & "t ra file " & ChrW(7843) & "nh"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.ToBmp()
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgToBitmap_Load(sender As Object, e As EventArgs)
			Me.txtMapScale.Text = Conversions.ToString(modBanDo.GetTyLeBD(myModule.fMain.AxMap1, myModule.fMain.AxMap1.Zoom))
		End Sub

		Private Sub ToBmp()
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "bitmap files (*.jpg)|*.jpg|All files (*.*)|*.*"
			saveFileDialog.FilterIndex = 1
			saveFileDialog.RestoreDirectory = True
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = saveFileDialog.FileName
				If fileName.Length > 0 Then
					Me.MapCapture(fileName)
					Interaction.MsgBox("Xong!", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub MapCapture(pFileName As String)
			Me.m_Zoom = myModule.fMain.AxMap1.Zoom
			Me.m_CenterX = myModule.fMain.AxMap1.CenterX
			Me.m_CenterY = myModule.fMain.AxMap1.CenterY
			Me.WindowState = FormWindowState.Minimized
			myModule.fMain.TopMost = True
			Application.DoEvents()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDec((myModule.fMain.Width - myModule.fMain.ClientSize.Width)) / 2.0))
			Dim num2 As Integer = myModule.fMain.Height - myModule.fMain.ClientSize.Height - num
			Dim x As Integer = myModule.fMain.Left + num + myModule.fMain.Panel2.Left + 2
			Dim y As Integer = myModule.fMain.Top + num2 + myModule.fMain.Panel2DMap.Top + myModule.fMain.Panel2.Top + myModule.fMain.AxMap1.Top + 2
			Dim part As System.Drawing.Rectangle = New System.Drawing.Rectangle(x, y, myModule.fMain.AxMap1.Width - 4, myModule.fMain.AxMap1.Height - 4)
			Dim zoomLevel As Double = modBanDo.GetZoomLevel(myModule.fMain.AxMap1, Conversions.ToInteger(Me.txtMapScale.Text))
			Dim mTyle As Double = Me.m_Zoom / zoomLevel
			Me.MapCapture(myModule.fMain.AxMap1, pFileName, mTyle, part)
			myModule.fMain.AxMap1.ZoomTo(Me.m_Zoom, Me.m_CenterX, Me.m_CenterY)
			myModule.fMain.TopMost = False
			Me.WindowState = FormWindowState.Normal
		End Sub

		Private Sub MapCapture0(pFileName As String)
			Me.m_Zoom = myModule.fMain.AxMap1.Zoom
			Me.m_CenterX = myModule.fMain.AxMap1.CenterX
			Me.m_CenterY = myModule.fMain.AxMap1.CenterY
			Me.WindowState = FormWindowState.Minimized
			myModule.fMain.TopMost = True
			Application.DoEvents()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDec((myModule.fMain.Width - myModule.fMain.ClientSize.Width)) / 2.0))
			Dim num2 As Integer = myModule.fMain.Height - myModule.fMain.ClientSize.Height - num
			Dim x As Integer = myModule.fMain.Left + num + myModule.fMain.Panel2DMap.Left + 2
			Dim y As Integer = myModule.fMain.Top + num2 + myModule.fMain.Panel2DMap.Top + myModule.fMain.AxMap1.Top + 2
			Dim part As System.Drawing.Rectangle = New System.Drawing.Rectangle(x, y, myModule.fMain.AxMap1.Width - 4, myModule.fMain.AxMap1.Height - 4)
			Dim zoomLevel As Double = modBanDo.GetZoomLevel(myModule.fMain.AxMap1, Conversions.ToInteger(Me.txtMapScale.Text))
			Dim mTyle As Double = Me.m_Zoom / zoomLevel
			Me.MapCapture(myModule.fMain.AxMap1, pFileName, mTyle, part)
			myModule.fMain.AxMap1.ZoomTo(Me.m_Zoom, Me.m_CenterX, Me.m_CenterY)
			myModule.fMain.TopMost = False
			Me.WindowState = FormWindowState.Normal
		End Sub

		Private Sub MapCapture(pMap As AxMap, pFileName As String, mTyle As Double, part As System.Drawing.Rectangle)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(Math.Ceiling(mTyle)))
			Dim num2 As Integer = num
			Dim list As List(Of List(Of Bitmap)) = New List(Of List(Of Bitmap))()
			Me.zoomto(pMap, mTyle)
			Application.DoEvents()
			Dim arg_2E_0 As Integer = 0
			Dim num3 As Integer = num2 - 1
			For i As Integer = arg_2E_0 To num3
				list.Add(New List(Of Bitmap)())
				Dim flag As Boolean = i Mod 2 = 0
				Dim num4 As Integer = Conversions.ToInteger(Interaction.IIf(flag, 0, num - 1))
				Dim num5 As Integer = Conversions.ToInteger(Interaction.IIf(flag, num, 0))
				Dim num6 As Integer = num4
				Dim num7 As Integer = part.Width
				Dim num8 As Integer = 0 - part.Height
				While (num6 < num5 And flag) Or (num6 >= num5 And Not flag)
					Dim desktopImage As Bitmap = CaptureScreen.GetDesktopImage()
					Dim bitmap As Bitmap = New Bitmap(desktopImage, part.Size)
					Dim graphics As Graphics = Graphics.FromImage(bitmap)
					graphics.DrawImage(desktopImage, 0, 0, part, GraphicsUnit.Pixel)
					graphics.Dispose()
					If flag Then
						list(i).Add(bitmap)
						num7 = part.Width
					Else
						list(i).Insert(0, bitmap)
						num7 = 0 - part.Width
					End If
					If(num6 < num5 - 1 And flag) Or (num6 >= num5 + 1 And Not flag) Then
						myModule.fMain.AxMap1.Pan(CSng(num7), 0F)
						Application.DoEvents()
					End If
					num6 = Conversions.ToInteger(Operators.AddObject(num6, Interaction.IIf(flag, 1, -1)))
				End While
				If i < num2 - 1 Then
					myModule.fMain.AxMap1.Pan(0F, CSng(num8))
					Application.DoEvents()
				End If
			Next
			Dim width As Integer = CInt(Math.Round(Math.Ceiling(CDec(part.Width) * mTyle)))
			Dim height As Integer = CInt(Math.Round(Math.Ceiling(CDec(part.Height) * mTyle)))
			Dim obj As Object = New Bitmap(width, height)
			Dim arg_1F8_0 As Integer = 0
			Dim num9 As Integer = num2 - 1
			For j As Integer = arg_1F8_0 To num9
				Dim arg_203_0 As Integer = 0
				Dim num10 As Integer = num - 1
				For k As Integer = arg_203_0 To num10
					Dim graphics As Graphics = Graphics.FromImage(CType(obj, Image))
					graphics.DrawImage(list(j)(k), k * part.Width, j * part.Height)
					graphics.Dispose()
				Next
			Next
			Dim arg_294_0 As Object = obj
			Dim arg_294_1 As Type = Nothing
			Dim arg_294_2 As String = "Save"
			Dim array As Object() = New Object() { pFileName, ImageFormat.Jpeg }
			Dim arg_294_3 As Object() = array
			Dim arg_294_4 As String() = Nothing
			Dim arg_294_5 As Type() = Nothing
			Dim array2 As Boolean() = New Boolean() { True, False }
			NewLateBinding.LateCall(arg_294_0, arg_294_1, arg_294_2, arg_294_3, arg_294_4, arg_294_5, array2, True)
			If array2(0) Then
				pFileName = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
			End If
		End Sub

		Private Sub zoomto(pMap As AxMap, mTyle As Double)
			Dim ctlBounds As MapXLib.Rectangle = myModule.fMain.AxMap1.CtlBounds
			Dim xMin As Double = ctlBounds.XMin
			Dim yMax As Double = ctlBounds.YMax
			Dim centerX As Double = myModule.fMain.AxMap1.CenterX
			Dim centerY As Double = myModule.fMain.AxMap1.CenterY
			Dim num As Single = CSng((1.0 / mTyle))
			Dim x As Double = CDec(num) * (centerX - xMin) + xMin
			Dim y As Double = CDec(num) * (centerY - yMax) + yMax
			Dim zoom As Double = myModule.fMain.AxMap1.Zoom * CDec(num)
			pMap.ZoomTo(zoom, x, y)
		End Sub
	End Class
End Namespace
