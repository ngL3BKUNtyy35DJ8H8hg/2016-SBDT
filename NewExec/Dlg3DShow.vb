Imports DienTapLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class Dlg3DShow
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		Private TongHopID As String

		Private bAutoRun As Boolean

		Private myTrangDauFile As String

		Private myTrangDau As Bitmap

		Private heightData As Single(,)

		Private MenuFile As String

		Private m_AngleX As Single

		Private m_AngleZ As Single

		Private LightDir As Vector3

		Private CameraPos As Vector3

		Private CameraTarget As Vector3

		<AccessedThroughProperty("mySaBan")>
		Private _mySaBan As CThucHanh

		Private m_TexImage As Bitmap

		Private myHeight As Integer

		Private myMaxHeight As Integer

		Private bLoaded As Boolean

		Private bLoaded0 As Boolean

		Friend Overridable Property PictureBox1() As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.PictureBox1_Paint
				Dim value3 As MouseEventHandler = AddressOf Me.PictureBox1_MouseUp
				If Me._PictureBox1 IsNot Nothing Then
					RemoveHandler Me._PictureBox1.Paint, value2
					RemoveHandler Me._PictureBox1.MouseUp, value3
				End If
				Me._PictureBox1 = value
				If Me._PictureBox1 IsNot Nothing Then
					AddHandler Me._PictureBox1.Paint, value2
					AddHandler Me._PictureBox1.MouseUp, value3
				End If
			End Set
		End Property

		Private Overridable Property mySaBan() As CThucHanh
			Get
				Return Me._mySaBan
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CThucHanh)
				Dim value2 As EventHandler = AddressOf Me.mySaBan_OnESC
				If Me._mySaBan IsNot Nothing Then
					RemoveHandler Me._mySaBan.OnESC, value2
				End If
				Me._mySaBan = value
				If Me._mySaBan IsNot Nothing Then
					AddHandler Me._mySaBan.OnESC, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.Dlg3DShow_Resize
			AddHandler MyBase.FormClosing, AddressOf Me.Dlg3DShow_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Dlg3DShow_Load
			AddHandler MyBase.KeyDown, AddressOf Me.Dlg3DShow_KeyDown
			Me.TongHopID = "TongHop"
			Me.bAutoRun = False
			Me.myTrangDauFile = "TrangDau.bmp"
			Me.m_AngleX = 0F
			Me.m_AngleZ = 0F
			Me.myHeight = 1
			Me.myMaxHeight = 1
			Me.bLoaded = False
			Me.bLoaded0 = False
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
			Me.PictureBox1 = New PictureBox()
			(CType(Me.PictureBox1, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.Dock = DockStyle.Fill
			Dim arg_38_0 As Control = Me.PictureBox1
			Dim location As Point = New Point(0, 0)
			arg_38_0.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_65_0 As Control = Me.PictureBox1
			Dim size As Size = New Size(1018, 744)
			arg_65_0.Size = size
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(1018, 744)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.PictureBox1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Dlg3DShow"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Dlg3DShow"
			Me.WindowState = FormWindowState.Maximized
			(CType(Me.PictureBox1, ISupportInitialize)).EndInit()
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

		Private Sub Dlg3DShow_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				If Me.bLoaded Then
					Me.mySaBan.mySound.ClearSounds()
				End If
				Me.mySaBan.ClearTerrain()
			Catch expr_25 As Exception
				ProjectData.SetProjectError(expr_25)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub Dlg3DShow_KeyDown(sender As Object, e As KeyEventArgs)
			If Me.bLoaded Then
				If e.KeyCode = Keys.Escape Then
					Me.Close()
				Else If e.KeyCode = Keys.P Then
					Me.mySaBan.PauseAction()
				Else If e.KeyCode = Keys.T Then
					Me.mySaBan.SwitchDescVisible()
				Else If e.KeyCode = Keys.S Then
					Dim mySaBan As CThucHanh = Me.mySaBan
					modSaBan.myCenterX = mySaBan.CenterX
					modSaBan.myCenterY = mySaBan.CenterY
					modSaBan.myCamPos = mySaBan.cameraPos
					modSaBan.myCamTarget = mySaBan.cameraTarget
					modSaBan.myAngleZ = mySaBan.getAngleZ()
					modSaBan.myAngleX = mySaBan.getAngleX()
					Dim pFileName As String = modSaBan.mySaBanDir + "\SaBan.pos"
					modSaBan.SaBanPos2File(pFileName)
				Else If e.KeyCode = Keys.T Then
					Me.mySaBan.SwitchDescVisible()
				Else If e.KeyCode = Keys.L Then
					Me.mySaBan.TerrainLighting = Not Me.mySaBan.TerrainLighting
				Else If e.KeyCode = Keys.M Then
					Me.mySaBan.SwitchFillMode()
				Else If e.KeyCode = Keys.D1 Then
					Me.mySaBan.tangX()
				Else If e.KeyCode = Keys.D2 Then
					Me.mySaBan.tangY()
				Else If e.KeyCode = Keys.D3 Then
					Me.mySaBan.tangZ()
				Else If e.KeyCode = Keys.D4 Then
					Me.mySaBan.giamX()
				Else If e.KeyCode = Keys.D5 Then
					Me.mySaBan.giamY()
				Else If e.KeyCode = Keys.D6 Then
					Me.mySaBan.giamZ()
				End If
			Else If e.KeyCode = Keys.Escape Then
				Me.Close()
			End If
		End Sub

		Private Sub Dlg3DShow_Load(sender As Object, e As EventArgs)
			Me.Text = "Nh" & ChrW(7845) & "n chu" & ChrW(7897) & "t trái " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7841) & "y t" & ChrW(7921) & " " & ChrW(273) & ChrW(7897) & "ng, Nh" & ChrW(7845) & "n chu" & ChrW(7897) & "t ph" & ChrW(7843) & "i " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7841) & "y có ch" & ChrW(7885) & "n l" & ChrW(7921) & "a"
			Me.myHeight = Me.Height
			Me.mySaBan = New CThucHanh(Me, Me.heightData, modSaBan.mySCALE_FACTOR, modBdTC.cDecSepa, modBdTC.cGrpSepa)
			Try
				Dim filename As String = modSaBan.myCurrentDirectory + "\" + Me.myTrangDauFile
				Me.myTrangDau = New Bitmap(filename)
			Catch expr_5C As Exception
				ProjectData.SetProjectError(expr_5C)
				Me.myTrangDau = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
				ProjectData.ClearProjectError()
			End Try
			Me.bLoaded0 = True
		End Sub

		Private Sub InitSaBan(pAuto As Boolean)
			Me.bLoaded = False
			Me.SetStyle(ControlStyles.Opaque Or ControlStyles.AllPaintingInWmPaint, True)
			Me.Text = ChrW(272) & "ang n" & ChrW(7841) & "p d" & ChrW(7919) & " li" & ChrW(7879) & "u ..."
			Me.mySaBan.LoadBillboardMeshs(modSaBan.myBillboardMeshFile)
			Me.mySaBan.LoadModelMeshs(modSaBan.myD3DModelMeshFile)
			Me.mySaBan.LoadSpriteTexs(modSaBan.mySpriteTexsFile)
			CHelper.SetClrColor(Me.m_TexImage)
			Me.mySaBan.LoadSounds(modSaBan.mySaBanDir + "\D3DSounds.xml")
			Me.mySaBan.LoadModels(modSaBan.mySaBanDir + "\D3DModels.xml")
			Me.mySaBan.LoadBillboards(modSaBan.mySaBanDir + "\D3DBillboards.xml")
			Me.mySaBan.LoadTexObjs(modSaBan.mySaBanDir + "\D3DTexObjs.xml")
			Dim mySaBan As CThucHanh = Me.mySaBan
			mySaBan.BGrColor = modSaBan.BGrColor
			mySaBan.ActColor = modSaBan.ActColor
			mySaBan.NoActColor = modSaBan.NoActColor
			mySaBan.MenuFontName = modSaBan.MenuFontName
			mySaBan.MenuFontSize = modSaBan.MenuFontSize
			mySaBan.MenuFontStyle = modSaBan.MenuFontStyle
			mySaBan.TitleColor = modSaBan.TitleColor
			mySaBan.TitleFontName = modSaBan.TitleFontName
			mySaBan.TitleFontSize = modSaBan.TitleFontSize
			mySaBan.TitleFontStyle = modSaBan.TitleFontStyle
			mySaBan.TitleText = modSaBan.TitleText
			mySaBan.TitlePointX = modSaBan.TitlePointX
			mySaBan.TitlePointY = modSaBan.TitlePointY
			mySaBan.DescColor = modSaBan.DescColor
			mySaBan.DescFontName = modSaBan.DescFontName
			mySaBan.DescFontSize = modSaBan.DescFontSize
			mySaBan.DescFontStyle = modSaBan.DescFontStyle
			mySaBan.DescTrenColor = modSaBan.DescTrenColor
			mySaBan.DescTrenFontName = modSaBan.DescTrenFontName
			mySaBan.DescTrenFontSize = modSaBan.DescTrenFontSize
			mySaBan.DescTrenFontStyle = modSaBan.DescTrenFontStyle
			mySaBan.DescGiuaColor = modSaBan.DescGiuaColor
			mySaBan.DescGiuaFontName = modSaBan.DescGiuaFontName
			mySaBan.DescGiuaFontSize = modSaBan.DescGiuaFontSize
			mySaBan.DescGiuaFontStyle = modSaBan.DescGiuaFontStyle
			Me.mySaBan.LoadMenu(Me.MenuFile)
			Me.mySaBan.InitTerrain(Me.m_TexImage, Me.CameraPos, Me.CameraTarget, Me.m_AngleZ, Me.m_AngleX, Me.LightDir)
			Me.mySaBan.ChangeFocus(modSaBan.myCenterX, modSaBan.myCenterY)
			Me.myMaxHeight = Me.Height
			Me.Text = " Escape = Thoát ra.    P = T" & ChrW(7841) & "m d" & ChrW(7915) & "ng / Ch" & ChrW(7841) & "y ti" & ChrW(7871) & "p.    T = T" & ChrW(7855) & "t/b" & ChrW(7853) & "t l" & ChrW(7901) & "i bình.   B" & ChrW(7845) & "m vào 'Ô " & ChrW(273) & ChrW(7871) & "m th" & ChrW(7901) & "i gian' " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc k" & ChrW(7883) & "ch b" & ChrW(7843) & "n."
			If Me.bAutoRun Then
				Me.mySaBan.RunTongHop(Me.TongHopID)
			End If
			Me.bLoaded = True
		End Sub

		Public Sub ShowDialog(pTexImage As Bitmap, pheightData As Single(,), pCamPos As Vector3, pCamTarget As Vector3, pMenuFile As String, pLightDir As Vector3, pAngleZ As Single, pAngleX As Single)
			Try
				Me.m_TexImage = pTexImage
				Me.heightData = pheightData
				Me.MenuFile = pMenuFile
				Me.CameraPos = pCamPos
				Me.CameraTarget = pCamTarget
				Me.LightDir = pLightDir
				Me.m_AngleZ = pAngleZ
				Me.m_AngleX = pAngleX
				Me.ShowDialog()
			Catch expr_46 As Exception
				ProjectData.SetProjectError(expr_46)
				Dim ex As Exception = expr_46
				Throw ex
			End Try
		End Sub

		Private Sub Dlg3DShow_Resize(sender As Object, e As EventArgs)
			If Me.bLoaded Then
				Dim tyleMH As Single = CSng(Me.myHeight) / CSng(Me.myMaxHeight)
				Me.mySaBan.setTyleMH(tyleMH)
			End If
		End Sub

		Private Sub VeTrangDau(g As Graphics, mTrangDau As Bitmap)
			mTrangDau.SetResolution(g.DpiX, g.DpiY)
			' The following expression was wrapped in a checked-statement
			Dim x As Integer = CInt(Math.Round(CDec((Me.PictureBox1.Width - mTrangDau.Width)) / 2.0))
			Dim y As Integer = CInt(Math.Round(CDec((Me.PictureBox1.Height - mTrangDau.Height)) / 2.0))
			g.Clear(modSaBan.BGrColor)
			g.DrawImage(mTrangDau, x, y)
		End Sub

		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Me.PictureBox1.Enabled = False
			If(e.Button And MouseButtons.Left) > MouseButtons.None Then
				Me.bAutoRun = True
				Me.InitSaBan(Me.bAutoRun)
				Me.PictureBox1.Visible = False
			Else
				Me.InitSaBan(Me.bAutoRun)
				Me.PictureBox1.Visible = False
			End If
		End Sub

		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			If Me.bLoaded0 Then
				Me.VeTrangDau(e.Graphics, Me.myTrangDau)
			End If
		End Sub

		Private Sub mySaBan_OnESC(sender As Object, e As EventArgs)
			Me.Close()
		End Sub
	End Class
End Namespace
