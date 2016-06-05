Imports System.Drawing
Imports System.Drawing.Drawing2D

Imports DBiGraphicObjs.DBiGraphicObjects

Public Class CSymbol3
    Public Name As String
    Private m_GocX As Double
    Private m_GocY As Double
    Private m_Zoom As Double = 1
    Private m_GObjs As CGraphicObjs

    Property GocX() As Double
        Get
            Return m_GocX
        End Get
        Set(ByVal Value As Double)
            m_GocX = Value
        End Set
    End Property

    Property GocY() As Double
        Get
            Return m_GocY
        End Get
        Set(ByVal Value As Double)
            m_GocY = Value
        End Set
    End Property

    Property GObjs() As CGraphicObjs
        Get
            Return m_GObjs
        End Get
        Set(ByVal Value As CGraphicObjs)
            m_GObjs = Value
        End Set
    End Property

    Property Zoom() As Double
        Get
            Return m_Zoom
        End Get
        Set(ByVal Value As Double)
            m_Zoom = Value
        End Set
    End Property

    Protected Sub New()
    End Sub

    Public Sub New(ByVal pName As String, ByVal pt0 As PointF, ByVal pGObjs As CGraphicObjs)
        Me.New()

        Name = pName

        m_GocX = pt0.X
        m_GocY = pt0.Y
        m_GObjs = New CGraphicObjs
        For Each aGObj As GraphicObject In pGObjs
            m_GObjs.Add(aGObj)
        Next
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        Dim gCon As Drawing2D.GraphicsContainer
        gCon = g.BeginContainer
        g.TranslateTransform(m_GocX, m_GocY)
        g.ScaleTransform(m_Zoom, m_Zoom)

        For Each mGObj As GraphicObject In m_GObjs
            mGObj.Draw(g)
        Next

        g.EndContainer(gCon)

    End Sub

    Public Sub VeBound(ByVal g As Graphics, ByVal Color As Color)
        Dim gCon As Drawing2D.GraphicsContainer
        gCon = g.BeginContainer
        g.TranslateTransform(m_GocX, m_GocY)
        g.ScaleTransform(m_Zoom, m_Zoom)

        Dim myL, myT, myR, myB As Single
        Dim myRect As RectangleF
        For Each mGObj As GraphicObject In m_GObjs
            myRect = mGObj.GetBounds
            If myRect.Left < myL Then
                myL = myRect.Left
            End If
            If myRect.Top < myT Then
                myT = myRect.Top
            End If
            If myRect.Right > myR Then
                myR = myRect.Right
            End If
            If myRect.Bottom > myB Then
                myB = myRect.Bottom
            End If
        Next

        Dim myPen As New Pen(Color.Black)
        myPen.DashStyle = Drawing2D.DashStyle.Dot
        myPen.Width = 2
        myPen.Color = Color.White
        g.DrawRectangle(myPen, New Rectangle(myL, myT, myR - myL, myB - myT))
        myPen.Width = 1
        myPen.Color = Color
        g.DrawRectangle(myPen, New Rectangle(myL, myT, myR - myL, myB - myT))

        myPen.Dispose()

        g.EndContainer(gCon)

    End Sub


    Public Function GetBounds() As Rectangle
        Dim mMatrix As New Matrix
        mMatrix.Translate(m_GocX, m_GocY)
        mMatrix.Scale(m_Zoom, m_Zoom)

        Dim myL, myT, myR, myB As Single
        Dim myRect As RectangleF
        For Each mGObj As GraphicObject In m_GObjs
            myRect = mGObj.GetBounds
            If myRect.Left < myL Then
                myL = myRect.Left
            End If
            If myRect.Top < myT Then
                myT = myRect.Top
            End If
            If myRect.Right > myR Then
                myR = myRect.Right
            End If
            If myRect.Bottom > myB Then
                myB = myRect.Bottom
            End If
        Next
        Dim mPts(1) As PointF
        mPts(0) = New PointF(myL, myT)
        mPts(1) = New PointF(myR, myB)
        mMatrix.TransformPoints(mPts)
        mMatrix.Dispose()

        Return New Rectangle(mPts(0).X, mPts(0).Y, mPts(1).X - mPts(0).X, mPts(1).Y - mPts(0).Y)

    End Function


End Class
