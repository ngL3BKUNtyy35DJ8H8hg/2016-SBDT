Imports DienTapLib
Imports System

Namespace SaBan
	Public Class CActDef2
		Public scrindex As Integer

		Public scrname As String

		Public actdef As CActDef

		Public actindex As Integer

		Public Sub New()
			Me.scrindex = -1
			Me.scrname = ""
			Me.actdef = Nothing
			Me.actindex = -1
		End Sub

		Public Overrides Function ToString() As String
			Return Me.actdef.ToString()
		End Function
	End Class
End Namespace
