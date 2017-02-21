Imports DBiGraphicObjs.DBiGraphicObjects
Imports System
Imports System.Diagnostics

Namespace BdTC
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

		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub
	End Class
End Namespace
