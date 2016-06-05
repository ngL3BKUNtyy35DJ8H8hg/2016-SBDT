Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO.IsolatedStorage

Public Class frmRegister
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents txtHash As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(16, 16)
        Me.txtText.Name = "txtText"
        Me.txtText.ReadOnly = True
        Me.txtText.Size = New System.Drawing.Size(296, 21)
        Me.txtText.TabIndex = 2
        Me.txtText.Text = ""
        '
        'txtHash
        '
        Me.txtHash.Location = New System.Drawing.Point(16, 96)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.Size = New System.Drawing.Size(296, 21)
        Me.txtHash.TabIndex = 4
        Me.txtHash.Text = ""
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(216, 128)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 32)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Register"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ðọc dòng chữ trên cho người cung cấp chương trình xin khoá.  Nhập vào dòng dưới, " & _
        "rồi bấm nút 'Register' để đăng ký chương trình."
        '
        'frmRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(346, 174)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.btnRegister, Me.txtHash, Me.txtText})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRegister"
        Me.Text = "Register"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const REGISTER_FILE As String = "myregister.dat"
    Private Const REGISTER_KEY As String = "minhbinhh4h776"
    Public RandomPlain As String
    Public RandomHash As String
    Public HDIDPlain As String
    Public HDIDHash As String
    Public RegKQ As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtHash.Text = GenerateHashDigest(REGISTER_KEY, Me.txtText.Text).ToUpper
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.txtText.Text = System.Guid.NewGuid.ToString("N").ToUpper
        RegKQ = False
        Me.txtText.Text = GetHDIDTho(Application.ProductName)
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        Dim uEncode As New UnicodeEncoding()

        Dim strHashForCompare As String = GenerateHashDigest(REGISTER_KEY, Me.txtText.Text).ToUpper
        If strHashForCompare = Me.txtHash.Text Then
            Me.RandomPlain = Me.txtText.Text
            Me.RandomHash = strHashForCompare
            Me.HDIDPlain = GetHDIDTho(Application.ProductName)  'GetHDID()
            Me.HDIDHash = GenerateHashDigest(REGISTER_KEY, HDIDPlain)
            Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly
            Try
                Dim isoStream As New IsolatedStorageFileStream(REGISTER_FILE, FileMode.Create, isoStore)
                UserSettings.Save(Me, isoStream)
                RegisterOK = True
                RegKQ = True
            Catch
                MsgBox("Register truc trac.")
            End Try
        Else
            MsgBox("khong Register duoc.")
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Function GenerateHashDigest(ByVal strKey As String, ByVal strSource As String) As String
        Dim uEncode As New UnicodeEncoding()

        Dim key() As Byte = uEncode.GetBytes(strKey)
        Dim data() As Byte = uEncode.GetBytes(strSource)

        Dim hmac As New HMACSHA1(key)
        Dim cs As New CryptoStream(Stream.Null, hmac, CryptoStreamMode.Write)
        cs.Write(data, 0, data.Length)
        cs.Close()

        Dim result As Byte() = hmac.Hash

        Return Convert.ToBase64String(result)
    End Function

    Private Function GetHDID() As String
        Return VTSGetDiskSerNum("C:\\").ToString & "1234567"
    End Function

    Private Function GetHDIDTho(ByVal pAppName As String) As String
        Return "D" & VTSGetDiskSerNum("C:\\").ToString & pAppName & "C"
    End Function

    Private Function VTSGetDiskSerNum(ByVal RootPath As String) As Integer
        Dim vName As String
        Dim VNameSize As Integer
        Dim VSerNum As Integer = 0
        Dim MaxCompLen As Integer
        Dim FileSystemFlags As Integer
        Dim FileSystemName As String
        Dim FileSystemNameSize As Integer
        Dim Res As Integer
        Res = GetVolumeInformation(RootPath, vName, VNameSize, _
                VSerNum, MaxCompLen, FileSystemFlags, FileSystemName, FileSystemNameSize)
        If Res Then
            Return VSerNum
        Else
            Return 0
        End If
    End Function

    Public Function IsRegOK() As Boolean
        Dim bKQ As Boolean = False
        Dim isoStore As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly
        If isoStore.GetFileNames(REGISTER_FILE).Length > 0 Then
            Dim isoStream As New IsolatedStorageFileStream(REGISTER_FILE, FileMode.Open, isoStore)
            If UserSettings.Load(isoStream, Me) = True Then
                If HDIDHash = GenerateHashDigest(REGISTER_KEY, GetHDIDTho(Application.ProductName)) Then
                    bKQ = True
                End If
            End If
            isoStream.Close()
        End If
        Return bKQ
    End Function
End Class
