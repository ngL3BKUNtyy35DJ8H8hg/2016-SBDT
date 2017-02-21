Imports DBiGraphicObjs.DBiGraphicObjects
Imports System

Namespace SaBan
	Public Class SelectionChangedEventArgs
		Inherits EventArgs

		Private m_SelectedObject As GraphicObject

		Public ReadOnly Property SelectedObject() As GraphicObject
			Get
				Return Me.m_SelectedObject
			End Get
		End Property

		Public Sub New(selectedObject As GraphicObject)
			Me.m_SelectedObject = selectedObject
		End Sub
	End Class
End Namespace
