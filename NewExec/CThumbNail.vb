Imports System

Namespace SaBan
	Public Class CThumbNail
		Private mValue As String

		Private mID As Integer

		Private mSymbols As String

		Private mSymbolStyle As Integer

		Public Property ID() As Integer
			Get
				Return Me.mID
			End Get
			Set(value As Integer)
				Me.mID = value
			End Set
		End Property

		Public Property Value() As String
			Get
				Return Me.mValue
			End Get
			Set(value As String)
				Me.mValue = value
			End Set
		End Property

		Public Property Symbols() As String
			Get
				Return Me.mSymbols
			End Get
			Set(value As String)
				Me.mSymbols = value
			End Set
		End Property

		Public Property SymbolStyle() As Integer
			Get
				Return Me.mSymbolStyle
			End Get
			Set(value As Integer)
				Me.mSymbolStyle = value
			End Set
		End Property

		Public Sub New(strValue As String, intID As Integer, strSymbols As String, intSymbolStyle As Integer)
			Me.mValue = strValue
			Me.mID = intID
			Me.mSymbols = strSymbols
			Me.mSymbolStyle = intSymbolStyle
		End Sub

		Public Sub New(strValue As String, intID As Integer, strSymbols As String)
			Me.mValue = strValue
			Me.mID = intID
			Me.mSymbols = strSymbols
			Me.mSymbolStyle = 0
		End Sub

		Public Sub New()
			Me.mValue = ""
			Me.mID = 0
			Me.mSymbols = ""
			Me.mSymbolStyle = 0
		End Sub

		Public Overrides Function ToString() As String
			Return Me.mValue
		End Function
	End Class
End Namespace
