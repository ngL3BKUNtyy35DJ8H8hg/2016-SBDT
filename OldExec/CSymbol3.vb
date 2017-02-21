Imports DBiGraphicObjs.DBiGraphicObjects
Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace BdTC
	Public Class CSymbol3
		Public Name As String

		Private m_GocX As Double

		Private m_GocY As Double

		Private m_Zoom As Double

		Private m_GObjs As CGraphicObjs

		Public Property GocX() As Double
			Get
				Return Me.m_GocX
			End Get
			Set(value As Double)
				Me.m_GocX = value
			End Set
		End Property

		Public Property GocY() As Double
			Get
				Return Me.m_GocY
			End Get
			Set(value As Double)
				Me.m_GocY = value
			End Set
		End Property

		Public Property GObjs() As CGraphicObjs
			Get
				Return Me.m_GObjs
			End Get
			Set(value As CGraphicObjs)
				Me.m_GObjs = value
			End Set
		End Property

		Public Property Zoom() As Double
			Get
				Return Me.m_Zoom
			End Get
			Set(value As Double)
				Me.m_Zoom = value
			End Set
		End Property

		Protected Sub New()
			Me.m_Zoom = 1.0
		End Sub

		Public Sub New(pName As String, pt0 As PointF, pGObjs As CGraphicObjs)
			Me.New()
			Me.Name = pName
			Me.m_GocX = CDec(pt0.X)
			Me.m_GocY = CDec(pt0.Y)
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Draw(g As Graphics)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(CSng(Me.m_GocX), CSng(Me.m_GocY))
			g.ScaleTransform(CSng(Me.m_Zoom), CSng(Me.m_Zoom))
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mGObj.Draw(g)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			g.EndContainer(gCon)
		End Sub

		Public Sub VeBound(g As Graphics, Color As Color)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(CSng(Me.m_GocX), CSng(Me.m_GocY))
			g.ScaleTransform(CSng(Me.m_Zoom), CSng(Me.m_Zoom))
			Dim myL As Single
			Dim myT As Single
			Dim myR As Single
			Dim myB As Single
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim myRect As RectangleF = mGObj.GetBounds()
					Dim flag As Boolean = myRect.Left < myL
					If flag Then
						myL = myRect.Left
					End If
					flag = (myRect.Top < myT)
					If flag Then
						myT = myRect.Top
					End If
					flag = (myRect.Right > myR)
					If flag Then
						myR = myRect.Right
					End If
					flag = (myRect.Bottom > myB)
					If flag Then
						myB = myRect.Bottom
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim myPen As Pen = New Pen(Color.Black)
			myPen.DashStyle = DashStyle.Dot
			myPen.Width = 2F
			myPen.Color = Color.White
			Dim arg_15A_1 As Pen = myPen
			' The following expression was wrapped in a checked-statement
			Dim rect As Rectangle = New Rectangle(CInt(Math.Round(CDec(myL))), CInt(Math.Round(CDec(myT))), CInt(Math.Round(CDec((myR - myL)))), CInt(Math.Round(CDec((myB - myT)))))
			g.DrawRectangle(arg_15A_1, rect)
			myPen.Width = 1F
			myPen.Color = Color
			Dim arg_1A9_1 As Pen = myPen
			rect = New Rectangle(CInt(Math.Round(CDec(myL))), CInt(Math.Round(CDec(myT))), CInt(Math.Round(CDec((myR - myL)))), CInt(Math.Round(CDec((myB - myT)))))
			g.DrawRectangle(arg_1A9_1, rect)
			myPen.Dispose()
			g.EndContainer(gCon)
		End Sub

		Public Function GetBounds() As Rectangle
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(CSng(Me.m_GocX), CSng(Me.m_GocY))
			mMatrix.Scale(CSng(Me.m_Zoom), CSng(Me.m_Zoom))
			Dim myL As Single
			Dim myT As Single
			Dim myR As Single
			Dim myB As Single
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim myRect As RectangleF = mGObj.GetBounds()
					Dim flag As Boolean = myRect.Left < myL
					If flag Then
						myL = myRect.Left
					End If
					flag = (myRect.Top < myT)
					If flag Then
						myT = myRect.Top
					End If
					flag = (myRect.Right > myR)
					If flag Then
						myR = myRect.Right
					End If
					flag = (myRect.Bottom > myB)
					If flag Then
						myB = myRect.Bottom
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim mPts As PointF() = New PointF(1) {}
			mPts(0) = New PointF(myL, myT)
			mPts(1) = New PointF(myR, myB)
			mMatrix.TransformPoints(mPts)
			mMatrix.Dispose()
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim result As Rectangle = New Rectangle(CInt(Math.Round(CDec(mPts(0).X))), CInt(Math.Round(CDec(mPts(0).Y))), CInt(Math.Round(CDec((mPts(1).X - mPts(0).X)))), CInt(Math.Round(CDec((mPts(1).Y - mPts(0).Y)))))
			Return result
		End Function
	End Class
End Namespace
