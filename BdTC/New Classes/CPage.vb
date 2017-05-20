Imports System

Namespace SaBan
    <Serializable()> Public Class CPage
        Private mValue As String

        Private mID As Integer

        Private mSymbols As String

        Private mChecked As Boolean

        Public Property ID() As Integer
            Get
                Return Me.mID
            End Get
            Set(ByVal value As Integer)
                Me.mID = value
            End Set
        End Property

        Public Property Value() As String
            Get
                Return Me.mValue
            End Get
            Set(ByVal value As String)
                Me.mValue = value
            End Set
        End Property

        Public Property Symbols() As String
            Get
                Return Me.mSymbols
            End Get
            Set(ByVal value As String)
                Me.mSymbols = value
            End Set
        End Property

        Public Property Checked() As Boolean
            Get
                Return Me.mChecked
            End Get
            Set(ByVal value As Boolean)
                Me.mChecked = value
            End Set
        End Property

        Public Sub New(ByVal strValue As String, ByVal intID As Integer, ByVal strSymbols As String, ByVal bChecked As Boolean)
            Me.mValue = strValue
            Me.mID = intID
            Me.mSymbols = strSymbols
            Me.mChecked = bChecked
        End Sub

        Public Sub New()
            Me.mValue = ""
            Me.mID = 0
            Me.mSymbols = ""
            Me.mChecked = False
        End Sub

        Public Overrides Function ToString() As String
            Return Me.mValue
        End Function

        Public Sub Update(ByVal pKHstr As String)
            Me.mSymbols = pKHstr
        End Sub
    End Class
End Namespace
