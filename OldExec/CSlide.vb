Imports System

Namespace BdTC
	<Serializable()>
	Public Class CSlide
		Private mValue As String

		Private mID As Integer

		Private mSymbols As String

		Private mChecked As Boolean

		Private m_DaLayKH As Boolean

		Private m_TyLeLayKH As Single

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

		Public Property Checked() As Boolean
			Get
				Return Me.mChecked
			End Get
			Set(value As Boolean)
				Me.mChecked = value
			End Set
		End Property

		Public Property TyLeLayKH() As Single
			Get
				Return Me.m_TyLeLayKH
			End Get
			Set(value As Single)
				Me.m_TyLeLayKH = value
			End Set
		End Property

		Public Property DaLayKH() As Boolean
			Get
				Return Me.m_DaLayKH
			End Get
			Set(value As Boolean)
				Me.m_DaLayKH = value
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

		Public Sub New(strValue As String, intID As Integer, strSymbols As String, bChecked As Boolean)
			Me.m_DaLayKH = False
			Me.m_TyLeLayKH = 1F
			Me.mValue = strValue
			Me.mID = intID
			Me.mSymbols = strSymbols
			Me.mChecked = bChecked
			Me.m_DaLayKH = False
		End Sub

		Public Sub New()
			Me.m_DaLayKH = False
			Me.m_TyLeLayKH = 1F
			Me.mValue = ""
			Me.mID = 0
			Me.mSymbols = ""
			Me.mChecked = False
			Me.m_DaLayKH = False
		End Sub

		Public Overrides Function ToString() As String
			Return Me.mValue
		End Function
	End Class
End Namespace
