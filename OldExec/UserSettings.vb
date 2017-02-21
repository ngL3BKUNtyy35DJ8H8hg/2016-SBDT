Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Namespace BdTC
	<Serializable()>
	Public Class UserSettings
		Public HDIDHash As String

		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		Public Shared Sub Save(frm As frmRegister, stm As Stream)
			Dim us As UserSettings = New UserSettings()
			us.HDIDHash = frm.HDIDHash
			Dim bf As BinaryFormatter = New BinaryFormatter()
			bf.Serialize(stm, us)
		End Sub

		Public Shared Function Load(stm As Stream, frm As frmRegister) As Boolean
			Dim bKQ As Boolean = False
			Dim bf As BinaryFormatter = New BinaryFormatter()
			Try
				Dim us As UserSettings = CType(bf.Deserialize(stm), UserSettings)
				frm.HDIDHash = us.HDIDHash
				bKQ = True
			Catch expr_27 As Exception
				ProjectData.SetProjectError(expr_27)
				ProjectData.ClearProjectError()
			End Try
			Return bKQ
		End Function
	End Class
End Namespace
