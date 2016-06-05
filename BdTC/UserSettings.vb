Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()> _
Public Class UserSettings
    Public HDIDHash As String

    Shared Sub Save( _
       ByVal frm As frmRegister, ByVal stm As Stream)

        Dim us As New UserSettings()
        us.HDIDHash = frm.HDIDHash

        Dim bf As New BinaryFormatter()
        bf.Serialize(stm, us)
    End Sub

    Shared Function Load(ByVal stm As Stream, ByVal frm As frmRegister) As Boolean
        Dim bKQ As Boolean = False
        Dim bf As New BinaryFormatter
        Dim us As UserSettings
        Try
            us = DirectCast(bf.Deserialize(stm), UserSettings)
            frm.HDIDHash = us.HDIDHash
            bKQ = True
        Catch ex As Exception
        End Try
        Return bKQ
    End Function
End Class
