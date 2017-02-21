Imports System

Namespace BdTC
	Public Class CThumbNail
		Private mValue As String

		Private mID As Integer

		Private mSymbols As String

		Private mVanToc As Integer

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

		Public Property VanToc() As Integer
			Get
				Return Me.mVanToc
			End Get
			Set(value As Integer)
				Me.mVanToc = value
			End Set
		End Property

		Public Sub New(strValue As String, intID As Integer, strSymbols As String)
			Me.mVanToc = 4
			Me.mValue = strValue
			Me.mID = intID
			Me.mSymbols = strSymbols
		End Sub

		Public Sub New(strValue As String, intID As Integer, strSymbols As String, intVanToc As Integer)
			Me.mVanToc = 4
			Me.mValue = strValue
			Me.mID = intID
			Me.mSymbols = strSymbols
			Me.mVanToc = intVanToc
		End Sub

		Public Sub New()
			Me.mVanToc = 4
			Me.mValue = ""
			Me.mID = 0
			Me.mSymbols = ""
		End Sub

		Public Overrides Function ToString() As String
			Return Me.mValue
		End Function
	End Class
End Namespace
