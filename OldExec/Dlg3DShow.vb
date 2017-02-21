Imports Microsoft.DirectX
Imports Microsoft.VisualBasic.CompilerServices
Imports mySaBanLib
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class Dlg3DShow
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		Private CameraPos As Vector3

		Private CameraTarget As Vector3

		Private mySaBan As CSaBan

		Private m_TexImage As Bitmap

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.Dlg3DShow_KeyDown
			AddHandler MyBase.Load, AddressOf Me.Dlg3DShow_Load
			AddHandler MyBase.FormClosing, AddressOf Me.Dlg3DShow_FormClosing
			Dlg3DShow.__ENCList.Add(New WeakReference(Me))
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
			Me.SuspendLayout()
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Dim clientSize As Size = New Size(787, 563)
			Me.ClientSize = clientSize
			Me.ControlBox = False
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Dlg3DShow"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Dlg3DShow"
			Me.WindowState = FormWindowState.Maximized
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
			Me.mySaBan.ClearTexObjs()
			Me.mySaBan.ClearSounds()
		End Sub

		Private Sub Dlg3DShow_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Space
			If flag Then
				Dim flag2 As Boolean = Me.mySaBan.bPlaying
				If flag2 Then
					Me.mySaBan.PauseAction()
				Else
					Me.mySaBan.ResumeAction()
				End If
			Else
				Dim flag2 As Boolean = e.KeyCode = Keys.R
				If flag2 Then
					Me.mySaBan.ResetAction()
				Else
					flag2 = (e.KeyCode = Keys.S)
					If flag2 Then
						Me.mySaBan.StopAction()
					Else
						flag2 = (e.KeyCode = Keys.M)
						If flag2 Then
							Me.mySaBan.SwitchFillMode()
						Else
							flag2 = (e.KeyCode = Keys.Escape)
							If flag2 Then
								Me.mySaBan.ClearSounds()
								Me.Close()
							End If
						End If
					End If
				End If
			End If
		End Sub

		Private Sub Dlg3DShow_Load(sender As Object, e As EventArgs)
			Dim arg_4E_0 As CSaBan = Me.mySaBan
			Dim arg_4E_1 As Bitmap = Me.m_TexImage
			Dim arg_4E_2 As Vector3 = Me.CameraPos
			Dim arg_4E_3 As Vector3 = Me.CameraTarget
			Dim arg_4E_4 As Single = -0.314159274F
			Dim vector As Vector3 = New Vector3(1F, 1F, -20F)
			Dim arg_4E_5 As Vector3 = vector
			Dim pModellightDirection As Vector3 = New Vector3(0F, 10F, 5F)
			arg_4E_0.InitTerrain(arg_4E_1, arg_4E_2, arg_4E_3, arg_4E_4, arg_4E_5, pModellightDirection)
		End Sub

		Public Sub ShowDialog(pTexImage As Bitmap, heightData As Single(,), pCamPos As Vector3, pCamTarget As Vector3, pMenuFile As String)
			Me.SetStyle(ControlStyles.Opaque Or ControlStyles.AllPaintingInWmPaint, True)
			Me.Text = "  SpaceBar = Ch" & ChrW(7841) & "y/T" & ChrW(7841) & "m d" & ChrW(7915) & "ng;  R = B" & ChrW(7855) & "t " & ChrW(273) & ChrW(7847) & "u l" & ChrW(7841) & "i;  S = K" & ChrW(7871) & "t thúc;  Escape = Thoát ra."
			Me.mySaBan = New CSaBan(Me, heightData, modBanDo.mySCALE_FACTOR)
			Me.mySaBan.LoadBillboardMeshs("D3DBillboardMesh.xml")
			Me.mySaBan.LoadModelMeshs("D3DModelMesh.xml")
			Me.mySaBan.LoadSpriteTexs("D3DSpriteTexs.xml")
			Me.mySaBan.LoadSounds(modBanDo.mySaBanDir + "\D3DSounds.xml")
			Me.mySaBan.LoadModels(modBanDo.mySaBanDir + "\D3DModels.xml")
			Me.mySaBan.LoadBillboards(modBanDo.mySaBanDir + "\D3DBillboards.xml")
			Me.mySaBan.LoadTexObjs(modBanDo.mySaBanDir + "\D3DTexObjs.xml")
			Me.mySaBan.LoadMenu(pMenuFile)
			Me.m_TexImage = pTexImage
			Me.CameraPos = pCamPos
			Me.CameraTarget = pCamTarget
			Me.ShowDialog()
		End Sub
	End Class
End Namespace
