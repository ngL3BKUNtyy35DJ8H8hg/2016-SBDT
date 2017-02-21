Imports DBiGraphicObjs.DBiGraphicObjects
Imports System
Imports System.Diagnostics

Namespace BdTC
	Public Class CFOUNDNODE
		Private m_FoundObject As GraphicObject

		Private m_NodeIndex As Integer

		Public Property FoundObject() As GraphicObject
			Get
				Return Me.m_FoundObject
			End Get
			Set(value As GraphicObject)
				Me.m_FoundObject = value
			End Set
		End Property

		Public Property NodeIndex() As Integer
			Get
				Return Me.m_NodeIndex
			End Get
			Set(value As Integer)
				Me.m_NodeIndex = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub
	End Class
End Namespace
