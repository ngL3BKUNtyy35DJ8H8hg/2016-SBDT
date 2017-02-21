Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Namespace SaBan
	<Serializable()>
	Public Class UserSettings
		Public HDIDHash As String

		Public Shared Sub Save(frm As frmRegister, stm As Stream)
			Dim userSettings As UserSettings = New UserSettings()
			userSettings.HDIDHash = frm.HDIDHash
			Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
			binaryFormatter.Serialize(stm, userSettings)
		End Sub

		Public Shared Function Load(stm As Stream, frm As frmRegister) As Boolean
			Dim result As Boolean = False
			Dim binaryFormatter As BinaryFormatter = New BinaryFormatter()
			Try
				Dim userSettings As UserSettings = CType(binaryFormatter.Deserialize(stm), UserSettings)
				frm.HDIDHash = userSettings.HDIDHash
				result = True
			Catch expr_25 As Exception
				ProjectData.SetProjectError(expr_25)
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function
	End Class
End Namespace
