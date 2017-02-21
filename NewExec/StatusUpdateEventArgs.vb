Imports DBiGraphicObjs.DBiGraphicObjects
Imports System
Imports System.Drawing

Namespace SaBan
	Public Class StatusUpdateEventArgs
		Inherits EventArgs

		Private m_UpdateType As StatusUpdateType

		Private m_SelectedObject As GraphicObject

		Private m_Message As String

		Private m_Coord As Point

		Private m_Amount As Single

		Public ReadOnly Property Type() As StatusUpdateType
			Get
				Return Me.m_UpdateType
			End Get
		End Property

		Public ReadOnly Property SelectedObject() As GraphicObject
			Get
				Return Me.m_SelectedObject
			End Get
		End Property

		Public ReadOnly Property Message() As String
			Get
				Return Me.m_Message
			End Get
		End Property

		Public ReadOnly Property Coordinates() As Point
			Get
				Return Me.m_Coord
			End Get
		End Property

		Public ReadOnly Property Amount() As Single
			Get
				Return Me.m_Amount
			End Get
		End Property

		Public Sub New(UpdateType As StatusUpdateType, Selection As GraphicObject, StatusMessage As String, Coord As Point, Amt As Single)
			Me.m_UpdateType = UpdateType
			Me.m_SelectedObject = Selection
			Me.m_Message = StatusMessage
			Me.m_Coord = Coord
			Me.m_Amount = Amt
		End Sub
	End Class
End Namespace
