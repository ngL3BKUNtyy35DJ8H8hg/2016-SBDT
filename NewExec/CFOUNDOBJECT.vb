Imports DBiGraphicObjs.DBiGraphicObjects
Imports System

Namespace SaBan
	Public Class CFOUNDOBJECT
		Private m_FoundObject As GraphicObject

		Private m_FoundSymbol As CSymbol

		Public Property FoundObject() As GraphicObject
			Get
				Return Me.m_FoundObject
			End Get
			Set(value As GraphicObject)
				Me.m_FoundObject = value
			End Set
		End Property

		Public Property FoundSymbol() As CSymbol
			Get
				Return Me.m_FoundSymbol
			End Get
			Set(value As CSymbol)
				Me.m_FoundSymbol = value
			End Set
		End Property
	End Class
End Namespace
