Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace BdTC
	Friend Module myModule
		Public fMain As frmMain

		Public fActions As dlgActions

		Friend fCallForm As Form

		Public RegisterOK As Boolean = False

		Public myMapGst As String = "BanDo.gst"

		Public myMapNhoGst As String = "BanDoNho.gst"

		Public myHienDanhSach As Boolean = True

		Public myCoordSysType As Integer = 1

		Friend fBanDoNho As dlgBanDoNho

		Friend intMonitorW As Integer

		Friend intMonitorH As Integer

		Public Declare Ansi Function MoveWindow Lib "user32" (hWnd As Integer, x As Integer, y As Integer, nWidth As Integer, nHeight As Integer, bRepaint As Integer) As Integer

		Public Declare Ansi Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpRootPathName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpVolumeNameBuffer As String, nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileSystemNameBuffer As String, nFileSystemNameSize As Integer) As Integer

		Friend Function toUnicode(t1 As Object) As String
			Dim KQ As String = ""
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = t1 Is Nothing
				If flag Then
					t1 = ""
				Else
					t1 = Conversions.ToString(t1)
				End If
				Dim aViet As String() = New String() { ChrW(258), "Â", "Ê", "Ô", ChrW(416), ChrW(431), ChrW(272), ChrW(259), "â", "ê", "ô", ChrW(417), ChrW(432), ChrW(273), "*", "*", "*", "*", "*", "*", "à", ChrW(7843), "ã", "á", ChrW(7841), "*", ChrW(7857), ChrW(7859), ChrW(7861), ChrW(7855), "*", "*", "*", "*", "*", "*", "*", ChrW(7863), ChrW(7847), ChrW(7849), ChrW(7851), ChrW(7845), ChrW(7853), "è", "*", ChrW(7867), ChrW(7869), "é", ChrW(7865), ChrW(7873), ChrW(7875), ChrW(7877), ChrW(7871), ChrW(7879), "ì", ChrW(7881), "*", "*", "*", ChrW(297), "í", ChrW(7883), "ò", "à", ChrW(7887), "õ", "ó", ChrW(7885), ChrW(7891), ChrW(7893), ChrW(7895), ChrW(7889), ChrW(7897), ChrW(7901), ChrW(7903), ChrW(7905), ChrW(7899), ChrW(7907), "ù", "*", ChrW(7911), ChrW(361), "ú", ChrW(7909), ChrW(7915), ChrW(7917), ChrW(7919), ChrW(7913), ChrW(7921), ChrW(7923), ChrW(7927), ChrW(7929), "ý", ChrW(7925), "*" }
				Dim t2 As String = ""
				Dim arg_452_0 As Integer = 1
				Dim num As Integer = Strings.Len(RuntimeHelpers.GetObjectValue(t1))
				Dim i As Integer = arg_452_0
				While True
					Dim arg_4EC_0 As Integer = i
					Dim num2 As Integer = num
					If arg_4EC_0 > num2 Then
						Exit While
					End If
					Dim j As Integer = Strings.Asc(Strings.Mid(Conversions.ToString(t1), i, 1)) - 161
					flag = (j < 0)
					If flag Then
						t2 += Strings.Mid(Conversions.ToString(t1), i, 1)
					Else
						flag = (Operators.CompareString(Strings.Mid(Conversions.ToString(t1), j, 1), "*", False) = 0)
						If flag Then
							t2 += Strings.Mid(Conversions.ToString(t1), i, 1)
						Else
							t2 += aViet(j)
						End If
					End If
					i += 1
				End While
				KQ = t2
			Catch arg_4F6_0 As Exception
				ProjectData.SetProjectError(arg_4F6_0)
				ProjectData.ClearProjectError()
			End Try
			Return KQ
		End Function
	End Module
End Namespace
