Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Namespace BdTC
	Public Class frmRegister
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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
			<DebuggerNonUserCode()>
			Get
				Return Me._txtText
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtText = value
			End Set
		End Property

		Friend Overridable Property txtHash() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtHash
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtHash = value
			End Set
		End Property

		Friend Overridable Property btnRegister() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnRegister
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnRegister IsNot Nothing
				If flag Then
					RemoveHandler Me._btnRegister.Click, AddressOf Me.btnRegister_Click
				End If
				Me._btnRegister = value
				flag = (Me._btnRegister IsNot Nothing)
				If flag Then
					AddHandler Me._btnRegister.Click, AddressOf Me.btnRegister_Click
				End If
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			frmRegister.__ENCList.Add(New WeakReference(Me))
			Me.RegKQ = False
			Me.InitializeComponent()
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing Then
				Dim flag As Boolean = Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
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
			Dim arg_4B_0 As Control = Me.txtText
			Dim location As Point = New Point(16, 16)
			arg_4B_0.Location = location
			Me.txtText.Name = "txtText"
			Me.txtText.[ReadOnly] = True
			Dim arg_85_0 As Control = Me.txtText
			Dim size As Size = New Size(296, 21)
			arg_85_0.Size = size
			Me.txtText.TabIndex = 2
			Me.txtText.Text = ""
			Dim arg_BC_0 As Control = Me.txtHash
			location = New Point(16, 96)
			arg_BC_0.Location = location
			Me.txtHash.Name = "txtHash"
			Dim arg_E9_0 As Control = Me.txtHash
			size = New Size(296, 21)
			arg_E9_0.Size = size
			Me.txtHash.TabIndex = 4
			Me.txtHash.Text = ""
			Dim arg_126_0 As Control = Me.btnRegister
			location = New Point(216, 128)
			arg_126_0.Location = location
			Me.btnRegister.Name = "btnRegister"
			Dim arg_150_0 As Control = Me.btnRegister
			size = New Size(96, 32)
			arg_150_0.Size = size
			Me.btnRegister.TabIndex = 7
			Me.btnRegister.Text = "Register"
			Dim arg_187_0 As Control = Me.Label1
			location = New Point(16, 48)
			arg_187_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_1B4_0 As Control = Me.Label1
			size = New Size(272, 40)
			arg_1B4_0.Size = size
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
			Dim uEncode As UnicodeEncoding = New UnicodeEncoding()
			Dim strHashForCompare As String = Me.GenerateHashDigest("minhbinhh4h776", Me.txtText.Text).ToUpper()
			Dim flag As Boolean = Operators.CompareString(strHashForCompare, Me.txtHash.Text, False) = 0
			If flag Then
				Me.RandomPlain = Me.txtText.Text
				Me.RandomHash = strHashForCompare
				Me.HDIDPlain = Me.GetHDIDTho(Application.ProductName)
				Me.HDIDHash = Me.GenerateHashDigest("minhbinhh4h776", Me.HDIDPlain)
				Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly()
				Try
					Dim isoStream As IsolatedStorageFileStream = New IsolatedStorageFileStream("myregister.dat", FileMode.Create, isoStore)
					UserSettings.Save(Me, isoStream)
					myModule.RegisterOK = True
					Me.RegKQ = True
				Catch arg_AC_0 As Exception
					ProjectData.SetProjectError(arg_AC_0)
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
			Dim uEncode As UnicodeEncoding = New UnicodeEncoding()
			Dim key As Byte() = uEncode.GetBytes(strKey)
			Dim data As Byte() = uEncode.GetBytes(strSource)
			Dim hmac As HMACSHA1 = New HMACSHA1(key)
			Dim cs As CryptoStream = New CryptoStream(Stream.Null, hmac, CryptoStreamMode.Write)
			cs.Write(data, 0, data.Length)
			cs.Close()
			Dim result As Byte() = hmac.Hash
			Return Convert.ToBase64String(result)
		End Function

		Private Function GetHDID() As String
			Return Me.VTSGetDiskSerNum("C:\\").ToString() + "1234567"
		End Function

		Private Function GetHDIDTho(pAppName As String) As String
			Return "D" + Me.VTSGetDiskSerNum("C:\\").ToString() + pAppName + "C"
		End Function

		Private Function VTSGetDiskSerNum(RootPath As String) As Integer
			Dim VSerNum As Integer = 0
			Dim vName As String
			Dim VNameSize As Integer
			Dim MaxCompLen As Integer
			Dim FileSystemFlags As Integer
			Dim FileSystemName As String
			Dim FileSystemNameSize As Integer
			Dim Res As Integer = myModule.GetVolumeInformation(RootPath, vName, VNameSize, VSerNum, MaxCompLen, FileSystemFlags, FileSystemName, FileSystemNameSize)
			Dim flag As Boolean = Res <> 0
			Dim VTSGetDiskSerNum As Integer
			If flag Then
				VTSGetDiskSerNum = VSerNum
			Else
				VTSGetDiskSerNum = 0
			End If
			Return VTSGetDiskSerNum
		End Function

		Public Function IsRegOK() As Boolean
			Dim bKQ As Boolean = False
			Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly()
			Dim flag As Boolean = isoStore.GetFileNames("myregister.dat").Length > 0
			If flag Then
				Dim isoStream As IsolatedStorageFileStream = New IsolatedStorageFileStream("myregister.dat", FileMode.Open, isoStore)
				flag = UserSettings.Load(isoStream, Me)
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(Me.HDIDHash, Me.GenerateHashDigest("minhbinhh4h776", Me.GetHDIDTho(Application.ProductName)), False) = 0
					If flag2 Then
						bKQ = True
					End If
				End If
				isoStream.Close()
			End If
			Return bKQ
		End Function
	End Class
End Namespace
