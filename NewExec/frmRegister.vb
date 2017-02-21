Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Namespace SaBan
	Public Class frmRegister
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("txtText")>
		Private _txtText As TextBox

		<AccessedThroughProperty("txtHash")>
		Private _txtHash As TextBox

		<AccessedThroughProperty("btnRegister")>
		Private _btnRegister As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		Private Const REGISTER_FILE As String = "myregister.dat"

		Private Const REGISTER_KEY As String = "minhbinhh4h776"

		Public RandomPlain As String

		Public RandomHash As String

		Public HDIDPlain As String

		Public HDIDHash As String

		Public RegKQ As Boolean

		Friend Overridable Property txtText() As TextBox
			Get
				Return Me._txtText
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtText = value
			End Set
		End Property

		Friend Overridable Property txtHash() As TextBox
			Get
				Return Me._txtHash
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtHash = value
			End Set
		End Property

		Friend Overridable Property btnRegister() As Button
			Get
				Return Me._btnRegister
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnRegister_Click
				If Me._btnRegister IsNot Nothing Then
					RemoveHandler Me._btnRegister.Click, value2
				End If
				Me._btnRegister = value
				If Me._btnRegister IsNot Nothing Then
					AddHandler Me._btnRegister.Click, value2
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

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.RegKQ = False
			Me.InitializeComponent()
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.txtText = New TextBox()
			Me.txtHash = New TextBox()
			Me.btnRegister = New Button()
			Me.Label1 = New Label()
			Me.SuspendLayout()
			Dim arg_44_0 As Control = Me.txtText
			Dim location As Point = New Point(16, 16)
			arg_44_0.Location = location
			Me.txtText.Name = "txtText"
			Me.txtText.[ReadOnly] = True
			Dim arg_7A_0 As Control = Me.txtText
			Dim size As Size = New Size(296, 21)
			arg_7A_0.Size = size
			Me.txtText.TabIndex = 2
			Me.txtText.Text = ""
			Dim arg_AD_0 As Control = Me.txtHash
			location = New Point(16, 96)
			arg_AD_0.Location = location
			Me.txtHash.Name = "txtHash"
			Dim arg_D7_0 As Control = Me.txtHash
			size = New Size(296, 21)
			arg_D7_0.Size = size
			Me.txtHash.TabIndex = 4
			Me.txtHash.Text = ""
			Dim arg_110_0 As Control = Me.btnRegister
			location = New Point(216, 128)
			arg_110_0.Location = location
			Me.btnRegister.Name = "btnRegister"
			Dim arg_137_0 As Control = Me.btnRegister
			size = New Size(96, 32)
			arg_137_0.Size = size
			Me.btnRegister.TabIndex = 7
			Me.btnRegister.Text = "Register"
			Dim arg_16A_0 As Control = Me.Label1
			location = New Point(16, 48)
			arg_16A_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_194_0 As Control = Me.Label1
			size = New Size(272, 40)
			arg_194_0.Size = size
			Me.Label1.TabIndex = 8
			Me.Label1.Text = "Ð" & ChrW(7885) & "c dòng ch" & ChrW(7919) & " trên cho ng" & ChrW(432) & ChrW(7901) & "i cung c" & ChrW(7845) & "p ch" & ChrW(432) & ChrW(417) & "ng trình xin khoá.  Nh" & ChrW(7853) & "p vào dòng d" & ChrW(432) & ChrW(7899) & "i, r" & ChrW(7891) & "i b" & ChrW(7845) & "m nút 'Register' " & ChrW(273) & ChrW(7875) & " " & ChrW(273) & ChrW(259) & "ng ký ch" & ChrW(432) & ChrW(417) & "ng trình."
			size = New Size(5, 14)
			Me.AutoScaleBaseSize = size
			size = New Size(346, 174)
			Me.ClientSize = size
			Me.Controls.AddRange(New Control() { Me.Label1, Me.btnRegister, Me.txtHash, Me.txtText })
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.Name = "frmRegister"
			Me.Text = "Register"
			Me.ResumeLayout(False)
		End Sub

		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.txtHash.Text = Me.GenerateHashDigest("minhbinhh4h776", Me.txtText.Text).ToUpper()
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Me.RegKQ = False
			Me.txtText.Text = Me.GetHDIDTho(Application.ProductName)
		End Sub

		Private Sub btnRegister_Click(sender As Object, e As EventArgs)
			Dim unicodeEncoding As UnicodeEncoding = New UnicodeEncoding()
			Dim text As String = Me.GenerateHashDigest("minhbinhh4h776", Me.txtText.Text).ToUpper()
			If Operators.CompareString(text, Me.txtHash.Text, False) = 0 Then
				Me.RandomPlain = Me.txtText.Text
				Me.RandomHash = text
				Me.HDIDPlain = Me.GetHDIDTho(Application.ProductName)
				Me.HDIDHash = Me.GenerateHashDigest("minhbinhh4h776", Me.HDIDPlain)
				Dim userStoreForAssembly As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly()
				Try
					Dim stm As IsolatedStorageFileStream = New IsolatedStorageFileStream("myregister.dat", FileMode.Create, userStoreForAssembly)
					UserSettings.Save(Me, stm)
					myModule.RegisterOK = True
					Me.RegKQ = True
				Catch arg_A3_0 As Exception
					ProjectData.SetProjectError(arg_A3_0)
					Interaction.MsgBox("Register truc trac.", MsgBoxStyle.OkOnly, Nothing)
					ProjectData.ClearProjectError()
				End Try
			Else
				Interaction.MsgBox("khong Register duoc.", MsgBoxStyle.OkOnly, Nothing)
			End If
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Public Function GenerateHashDigest(strKey As String, strSource As String) As String
			Dim unicodeEncoding As UnicodeEncoding = New UnicodeEncoding()
			Dim bytes As Byte() = unicodeEncoding.GetBytes(strKey)
			Dim bytes2 As Byte() = unicodeEncoding.GetBytes(strSource)
			Dim hMACSHA As HMACSHA1 = New HMACSHA1(bytes)
			Dim cryptoStream As CryptoStream = New CryptoStream(Stream.Null, hMACSHA, CryptoStreamMode.Write)
			cryptoStream.Write(bytes2, 0, bytes2.Length)
			cryptoStream.Close()
			Dim hash As Byte() = hMACSHA.Hash
			Return Convert.ToBase64String(hash)
		End Function

		Private Function GetHDID() As String
			Return Me.VTSGetDiskSerNum("C:\\").ToString() + "1234567"
		End Function

		Private Function GetHDIDTho(pAppName As String) As String
			Return "D" + Me.VTSGetDiskSerNum("C:\\").ToString() + pAppName + "C"
		End Function

		Private Function VTSGetDiskSerNum(RootPath As String) As Integer
			Dim text As String = ""
			Dim num As Integer = 0
			Dim text2 As String = ""
			Dim nVolumeNameSize As Integer
			Dim num2 As Integer
			Dim num3 As Integer
			Dim nFileSystemNameSize As Integer
			Dim volumeInformation As Integer = myModule.GetVolumeInformation(RootPath, text, nVolumeNameSize, num, num2, num3, text2, nFileSystemNameSize)
			Dim result As Integer
			If volumeInformation <> 0 Then
				result = num
			Else
				result = 0
			End If
			Return result
		End Function

		Public Function IsRegOK() As Boolean
			Dim result As Boolean = False
			Dim userStoreForAssembly As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly()
			If userStoreForAssembly.GetFileNames("myregister.dat").Length > 0 Then
				Dim isolatedStorageFileStream As IsolatedStorageFileStream = New IsolatedStorageFileStream("myregister.dat", FileMode.Open, userStoreForAssembly)
				If UserSettings.Load(isolatedStorageFileStream, Me) AndAlso Operators.CompareString(Me.HDIDHash, Me.GenerateHashDigest("minhbinhh4h776", Me.GetHDIDTho(Application.ProductName)), False) = 0 Then
					result = True
				End If
				isolatedStorageFileStream.Close()
			End If
			Return result
		End Function
	End Class
End Namespace
