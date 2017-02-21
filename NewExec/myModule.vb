Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace SaBan
	Friend Module myModule
		Public fMain As frmMain

		Public RegisterOK As Boolean = False

		Friend intMonitorW As Integer

		Friend intMonitorH As Integer

		Public Declare Ansi Function MoveWindow Lib "user32" (hWnd As Integer, x As Integer, y As Integer, nWidth As Integer, nHeight As Integer, bRepaint As Integer) As Integer

		Public Declare Ansi Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, nFileSystemNameSize As Integer) As Integer

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub Main(CmdArgs As String())
			myModule.RegisterOK = True
			If Not myModule.RegisterOK Then
				MessageBox.Show("Chua Dang ky. Stop.")
				ProjectData.EndApp()
			End If
			If myModule.RegisterOK Then
				Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize
				myModule.intMonitorW = primaryMonitorSize.Width
				myModule.intMonitorH = primaryMonitorSize.Height
				Dim frmMain As frmMain = New frmMain()
				frmMain.ShowDialog()
			End If
			ProjectData.EndApp()
		End Sub

		Private Function GetReg() As Boolean
			Dim frmRegister As frmRegister = New frmRegister()
			Dim flag As Boolean = frmRegister.IsRegOK()
			If Not flag AndAlso frmRegister.ShowDialog() = DialogResult.OK Then
				flag = frmRegister.RegKQ
			End If
			Return flag
		End Function

		Friend Function toUnicode(t1 As Object) As String
			Dim result As String = ""
			' The following expression was wrapped in a checked-statement
			Try
				If t1 Is Nothing Then
					t1 = ""
				Else
					t1 = Conversions.ToString(t1)
				End If
				Dim array As String() = New String() { ChrW(258), "Â", "Ê", "Ô", ChrW(416), ChrW(431), ChrW(272), ChrW(259), "â", "ê", "ô", ChrW(417), ChrW(432), ChrW(273), "*", "*", "*", "*", "*", "*", "à", ChrW(7843), "ã", "á", ChrW(7841), "*", ChrW(7857), ChrW(7859), ChrW(7861), ChrW(7855), "*", "*", "*", "*", "*", "*", "*", ChrW(7863), ChrW(7847), ChrW(7849), ChrW(7851), ChrW(7845), ChrW(7853), "è", "*", ChrW(7867), ChrW(7869), "é", ChrW(7865), ChrW(7873), ChrW(7875), ChrW(7877), ChrW(7871), ChrW(7879), "ì", ChrW(7881), "*", "*", "*", ChrW(297), "í", ChrW(7883), "ò", "à", ChrW(7887), "õ", "ó", ChrW(7885), ChrW(7891), ChrW(7893), ChrW(7895), ChrW(7889), ChrW(7897), ChrW(7901), ChrW(7903), ChrW(7905), ChrW(7899), ChrW(7907), "ù", "*", ChrW(7911), ChrW(361), "ú", ChrW(7909), ChrW(7915), ChrW(7917), ChrW(7919), ChrW(7913), ChrW(7921), ChrW(7923), ChrW(7927), ChrW(7929), "ý", ChrW(7925), "*" }
				Dim text As String = ""
				Dim arg_3E8_0 As Integer = 1
				Dim num As Integer = Strings.Len(RuntimeHelpers.GetObjectValue(t1))
				For i As Integer = arg_3E8_0 To num
					Dim num2 As Integer = Strings.Asc(Strings.Mid(Conversions.ToString(t1), i, 1)) - 161
					If num2 < 0 Then
						text += Strings.Mid(Conversions.ToString(t1), i, 1)
					Else If Operators.CompareString(Strings.Mid(Conversions.ToString(t1), num2, 1), "*", False) = 0 Then
						text += Strings.Mid(Conversions.ToString(t1), i, 1)
					Else
						text += array(num2)
					End If
				Next
				result = text
			Catch arg_474_0 As Exception
				ProjectData.SetProjectError(arg_474_0)
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function
	End Module
End Namespace
