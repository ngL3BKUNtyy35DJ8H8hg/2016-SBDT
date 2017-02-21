Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace BdTC
	Public Class CSymbol
		Private m_GocX As Double

		Private m_GocY As Double

		Private m_Zoom As Double

		Private m_MWidth As Single

		Private m_GObjs As CGraphicObjs

		Private m_Description As String

		Private m_Blinking As Boolean

		Public Xfile As String

		Public Property Blinking() As Boolean
			Get
				Return Me.m_Blinking
			End Get
			Set(value As Boolean)
				Me.m_Blinking = value
			End Set
		End Property

		Public Property Description() As String
			Get
				Return Me.m_Description
			End Get
			Set(value As String)
				Me.m_Description = value
			End Set
		End Property

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

		Public Property MWidth() As Single
			Get
				Return Me.m_MWidth
			End Get
			Set(value As Single)
				Me.m_MWidth = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return Me.m_Description
		End Function

		Public Sub Draw(pMap As AxMap, g As Graphics)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
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

		Public Sub DanhDau(pMap As AxMap, g As Graphics, Color As Color)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mGObj.DanhDau(g, Color)
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

		Public Sub DanhDau(pMap As AxMap, g As Graphics, Pen As Pen)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mGObj.DanhDau(g, Pen)
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

		Public Function GetBounds(pMap As AxMap) As System.Drawing.Rectangle
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(mX, mY)
			mMatrix.Scale(Scale, Scale)
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
			Dim result As System.Drawing.Rectangle = New System.Drawing.Rectangle(CInt(Math.Round(CDec(mPts(0).X))), CInt(Math.Round(CDec(mPts(0).Y))), CInt(Math.Round(CDec((mPts(1).X - mPts(0).X)))), CInt(Math.Round(CDec((mPts(1).Y - mPts(0).Y)))))
			Return result
		End Function

		Public Sub VeBound(pMap As AxMap, g As Graphics, Color As Color)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
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
			Dim arg_1B2_1 As Pen = myPen
			' The following expression was wrapped in a checked-statement
			Dim rect As System.Drawing.Rectangle = New System.Drawing.Rectangle(CInt(Math.Round(CDec(myL))), CInt(Math.Round(CDec(myT))), CInt(Math.Round(CDec((myR - myL)))), CInt(Math.Round(CDec((myB - myT)))))
			g.DrawRectangle(arg_1B2_1, rect)
			myPen.Width = 1F
			myPen.Color = Color
			Dim arg_206_1 As Pen = myPen
			rect = New System.Drawing.Rectangle(CInt(Math.Round(CDec(myL))), CInt(Math.Round(CDec(myT))), CInt(Math.Round(CDec((myR - myL)))), CInt(Math.Round(CDec((myB - myT)))))
			g.DrawRectangle(arg_206_1, rect)
			myPen.Dispose()
			g.EndContainer(gCon)
		End Sub

		Public Sub VeBound(pMap As AxMap, g As Graphics, pObj As GraphicObject, Color As Color)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
			pObj.VeBound(g, Color)
			g.EndContainer(gCon)
		End Sub

		Public Sub DanhDau(pMap As AxMap, g As Graphics, pObj As GraphicObject, Color As Color)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
			pObj.DanhDau(g, Color)
			g.EndContainer(gCon)
		End Sub

		Public Sub DrawNodes(pMap As AxMap, g As Graphics)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mGObj.DrawNodes(g)
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

		Public Sub DrawNodes1(pMap As AxMap, g As Graphics)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mBrush As SolidBrush = New SolidBrush(Color.FromArgb(75, Color.Orange))
			Dim mPen As Pen = New Pen(Color.Black, 2F)
			Dim r As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, 5, 5)
			' The following expression was wrapped in a checked-statement
			r.X = CInt(Math.Round(CDec((mX - 2F))))
			r.Y = CInt(Math.Round(CDec((mY - 2F))))
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(mX, mY)
			g.ScaleTransform(Scale, Scale)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim mPts As PointF() = mGObj.GetPoints()
					' The following expression was wrapped in a unchecked-expression
					r.X = CInt(Math.Round(CDec((mPts(0).X - 2F))))
					' The following expression was wrapped in a unchecked-expression
					r.Y = CInt(Math.Round(CDec((mPts(0).Y - 2F))))
					g.FillEllipse(mBrush, r)
					g.DrawEllipse(mPen, r)
					g.DrawLine(mPen, r.Left - 1, r.Top - 1, r.Right + 1, r.Bottom + 1)
					g.DrawLine(mPen, r.Left - 1, r.Bottom + 1, r.Right + 1, r.Top - 1)
					Dim flag As Boolean = mPts.GetUpperBound(0) > 0
					If flag Then
						Dim arg_1D7_0 As Integer = 1
						Dim upperBound As Integer = mPts.GetUpperBound(0)
						Dim i As Integer = arg_1D7_0
						While True
							Dim arg_246_0 As Integer = i
							Dim num As Integer = upperBound
							If arg_246_0 > num Then
								Exit While
							End If
							' The following expression was wrapped in a unchecked-expression
							r.X = CInt(Math.Round(CDec((mPts(i).X - 2F))))
							' The following expression was wrapped in a unchecked-expression
							r.Y = CInt(Math.Round(CDec((mPts(i).Y - 2F))))
							g.FillEllipse(mBrush, r)
							g.DrawEllipse(mPen, r)
							i += 1
						End While
					End If
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

		Public Sub DrawRoot(pMap As AxMap, g As Graphics)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mPen As Pen = New Pen(Color.Black, 2F)
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim r As System.Drawing.Rectangle = New System.Drawing.Rectangle(CInt(Math.Round(CDec((mX - 3F)))), CInt(Math.Round(CDec((mY - 3F)))), 7, 7)
			g.DrawRectangle(mPen, r)
			mPen.Dispose()
		End Sub

		Public Function HitTest(pMap As AxMap, pt As PointF) As Boolean
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(-mX, -mY, MatrixOrder.Append)
			mMatrix.Scale(1F / Scale, 1F / Scale, MatrixOrder.Append)
			Dim mPts As PointF() = New PointF() { pt }
			mMatrix.TransformPoints(mPts)
			Dim mPt As PointF = New PointF(mPts(0).X, mPts(0).Y)
			Dim flag As Boolean = Me.m_GObjs.Count > 0
			' The following expression was wrapped in a checked-statement
			Dim HitTest As Boolean
			If flag Then
				Dim i As Integer = Me.m_GObjs.Count - 1
				While True
					Dim arg_125_0 As Integer = i
					Dim num As Integer = 0
					If arg_125_0 < num Then
						GoTo IL_127
					End If
					Dim drawObj As GraphicObject = Me.m_GObjs(i)
					flag = drawObj.HitTest(mPt)
					If flag Then
						Exit While
					End If
					i += -1
				End While
				HitTest = True
				Return HitTest
			End If
			IL_127:
			HitTest = False
			Return HitTest
		End Function

		Public Function HitTest(pMap As AxMap, rect As RectangleF) As Boolean
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(-mX, -mY, MatrixOrder.Append)
			mMatrix.Scale(1F / Scale, 1F / Scale, MatrixOrder.Append)
			Dim mPts As PointF() = New PointF(1) {}
			mPts(0) = New PointF(rect.Left, rect.Top)
			mPts(1) = New PointF(rect.Left + rect.Width, rect.Top + rect.Height)
			mMatrix.TransformPoints(mPts)
			Dim mrect As RectangleF = New RectangleF(mPts(0).X, mPts(0).Y, mPts(1).X - mPts(0).X, mPts(1).Y - mPts(0).Y)
			Dim flag As Boolean = Me.m_GObjs.Count > 0
			' The following expression was wrapped in a checked-statement
			Dim HitTest As Boolean
			If flag Then
				Dim i As Integer = Me.m_GObjs.Count - 1
				While True
					Dim arg_198_0 As Integer = i
					Dim num As Integer = 0
					If arg_198_0 < num Then
						GoTo IL_19A
					End If
					Dim drawObj As GraphicObject = Me.m_GObjs(i)
					flag = Not drawObj.HitTest(mrect)
					If flag Then
						Exit While
					End If
					i += -1
				End While
				HitTest = False
				Return HitTest
			End If
			IL_19A:
			HitTest = True
			Return HitTest
		End Function

		Public Function FindObjectAtPoint(pMap As AxMap, pt As PointF) As GraphicObject
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(-mX, -mY, MatrixOrder.Append)
			mMatrix.Scale(1F / Scale, 1F / Scale, MatrixOrder.Append)
			Dim mPts As PointF() = New PointF() { pt }
			mMatrix.TransformPoints(mPts)
			Dim mPt As PointF = New PointF(mPts(0).X, mPts(0).Y)
			Return Me.m_GObjs.FindObjectAtPoint(mPt)
		End Function

		Public Sub MoveNodeTo(pMap As AxMap, ENode As CFOUNDNODE, pt As PointF)
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mMatrix As Matrix = New Matrix()
			Dim drawObj As GraphicObject = ENode.FoundObject
			mMatrix.Translate(-mX, -mY, MatrixOrder.Append)
			mMatrix.Scale(1F / Scale, 1F / Scale, MatrixOrder.Append)
			Dim mPts As PointF() = New PointF() { pt }
			mMatrix.TransformPoints(mPts)
			Dim mPt As PointF = New PointF(mPts(0).X, mPts(0).Y)
			drawObj.MoveNodeTo(ENode.NodeIndex, mPt)
		End Sub

		Public Function Noi2Objs(pFoundNode As CFOUNDNODE) As Boolean
			Dim kq As Boolean = False
			Dim flag As Boolean = pFoundNode.FoundObject.GetObjType() = OBJECTTYPE.Curve Or pFoundNode.FoundObject.GetObjType() = OBJECTTYPE.Line
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mNShape As NodesShapeGraphic = CType(pFoundNode.FoundObject, NodesShapeGraphic)
				flag = (pFoundNode.NodeIndex = 0 Or pFoundNode.NodeIndex = mNShape.Nodes.Count - 1)
				If flag Then
					Dim mFoundNode2 As CFOUNDNODE = Me.Tim2ndNode(pFoundNode)
					flag = (pFoundNode.NodeIndex = 0)
					If flag Then
						mNShape.ReverseNodes()
					End If
					flag = (mFoundNode2.NodeIndex = 0)
					If flag Then
						Dim mNShape2 As NodesShapeGraphic = CType(mFoundNode2.FoundObject, NodesShapeGraphic)
						flag = (mNShape2.Nodes.Count > 1)
						If flag Then
							Dim arg_BE_0 As Integer = 1
							Dim num As Integer = mNShape2.Nodes.Count - 1
							Dim i As Integer = arg_BE_0
							While True
								Dim arg_EB_0 As Integer = i
								Dim num2 As Integer = num
								If arg_EB_0 > num2 Then
									Exit While
								End If
								mNShape.Nodes.Add(mNShape2.Nodes(i))
								i += 1
							End While
						End If
						Me.m_GObjs.Remove(mFoundNode2.FoundObject)
						kq = True
					Else
						flag = (mFoundNode2.NodeIndex > 0)
						If flag Then
							Dim mNShape3 As NodesShapeGraphic = CType(mFoundNode2.FoundObject, NodesShapeGraphic)
							flag = (mNShape3.Nodes.Count > 1)
							If flag Then
								Dim j As Integer = mNShape3.Nodes.Count - 2
								While True
									Dim arg_172_0 As Integer = j
									Dim num2 As Integer = 0
									If arg_172_0 < num2 Then
										Exit While
									End If
									mNShape.Nodes.Add(mNShape3.Nodes(j))
									j += -1
								End While
							End If
							Me.m_GObjs.Remove(mFoundNode2.FoundObject)
							kq = True
						End If
					End If
				End If
			End If
			Return kq
		End Function

		Private Function Tim2ndNode(pFoundNode As CFOUNDNODE) As CFOUNDNODE
			Dim kq As CFOUNDNODE = New CFOUNDNODE()
			kq.NodeIndex = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim flag As Boolean = aObj.GetObjType() = OBJECTTYPE.Curve Or aObj.GetObjType() = OBJECTTYPE.Line
					If flag Then
						Dim flag2 As Boolean = aObj IsNot pFoundNode.FoundObject
						If flag2 Then
							Dim mNShape As NodesShapeGraphic = CType(aObj, NodesShapeGraphic)
							Dim mNShape2 As NodesShapeGraphic = CType(pFoundNode.FoundObject, NodesShapeGraphic)
							flag2 = (mNShape.Nodes(0).X = mNShape2.Nodes(pFoundNode.NodeIndex).X And mNShape.Nodes(0).Y = mNShape2.Nodes(pFoundNode.NodeIndex).Y)
							If flag2 Then
								kq.FoundObject = aObj
								kq.NodeIndex = 0
							Else
								flag2 = (mNShape.Nodes(mNShape.Nodes.Count - 1).X = mNShape2.Nodes(pFoundNode.NodeIndex).X And mNShape.Nodes(mNShape.Nodes.Count - 1).Y = mNShape2.Nodes(pFoundNode.NodeIndex).Y)
								If flag2 Then
									kq.FoundObject = aObj
									kq.NodeIndex = mNShape.Nodes.Count - 1
								End If
							End If
						End If
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return kq
		End Function

		Public Function FindNodeAtPoint(pMap As AxMap, pt As PointF) As CFOUNDNODE
			Dim KQ As CFOUNDNODE = New CFOUNDNODE()
			Dim Scale As Single = CSng((Me.m_Zoom / pMap.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(-mX, -mY, MatrixOrder.Append)
			mMatrix.Scale(1F / Scale, 1F / Scale, MatrixOrder.Append)
			Dim mPts As PointF() = New PointF() { pt }
			mMatrix.TransformPoints(mPts)
			Dim mPt As PointF = New PointF(mPts(0).X, mPts(0).Y)
			' The following expression was wrapped in a checked-statement
			Dim i As Integer = Me.m_GObjs.Count - 1
			Dim drawObj As GraphicObject
			Dim j As Integer
			While True
				Dim arg_139_0 As Integer = i
				Dim num As Integer = 0
				If arg_139_0 < num Then
					GoTo Block_2
				End If
				drawObj = Me.m_GObjs(i)
				j = drawObj.FindNodeAtPoint(mPt)
				Dim flag As Boolean = j > -1
				If flag Then
					Exit While
				End If
				i += -1
			End While
			Dim iNode As Integer = j
			KQ.FoundObject = drawObj
			KQ.NodeIndex = iNode
			Dim FindNodeAtPoint As CFOUNDNODE = KQ
			Return FindNodeAtPoint
			Block_2:
			FindNodeAtPoint = Nothing
			Return FindNodeAtPoint
		End Function

		Public Function RootHitTest(pMap As AxMap, pt As PointF) As Boolean
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim r As RectangleF = New RectangleF(mX - 3F, mY - 3F, 7F, 7F)
			Return r.Contains(pt)
		End Function

		Public Sub Move(pMap As AxMap, fromPt As PointF, toPt As PointF)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			mX += toPt.X - fromPt.X
			mY += toPt.Y - fromPt.Y
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
		End Sub

		Public Sub Shift(pMap As AxMap, deltaX As Single, deltaY As Single)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			mX += deltaX
			mY += deltaY
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
		End Sub

		Public Sub ChangeRoot(pMap As AxMap, newGocX As Double, newGocY As Double)
			Dim mScale As Single = CSng((pMap.Zoom / Me.m_Zoom))
			mScale = Conversions.ToSingle(Operators.MultiplyObject(mScale, Interaction.IIf(Me.m_MWidth > 0F, Me.m_MWidth / pMap.MapScreenWidth, 1)))
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mX2 As Single
			Dim mY2 As Single
			pMap.ConvertCoord(mX2, mY2, newGocX, newGocY, ConversionConstants.miMapToScreen)
			Me.m_GocX = newGocX
			Me.m_GocY = newGocY
			Dim mPt As PointF = New PointF(mX * mScale, mY * mScale)
			Dim mPt2 As PointF = New PointF(mX2 * mScale, mY2 * mScale)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mObj.Move(mPt2, mPt)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub ChangeZoomMWidtht(newZoom As Double, newMWidth As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim mPts As PointF() = mObj.GetPoints()
					Dim mScale As Single = CSng((Me.m_Zoom / newZoom))
					mScale = Conversions.ToSingle(Operators.MultiplyObject(mScale, Interaction.IIf(Me.m_MWidth > 0F, newMWidth / Me.m_MWidth, 1)))
					Dim mMatrix As Matrix = New Matrix()
					mMatrix.Reset()
					mMatrix.Scale(mScale, mScale, MatrixOrder.Append)
					mMatrix.TransformPoints(mPts)
					Dim arg_91_0 As Integer = 0
					Dim upperBound As Integer = mPts.GetUpperBound(0)
					Dim i As Integer = arg_91_0
					While True
						Dim arg_BA_0 As Integer = i
						Dim num As Integer = upperBound
						If arg_BA_0 > num Then
							Exit While
						End If
						mObj.MoveNodeTo(i, mPts(i))
						i += 1
					End While
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Zoom = newZoom
			Me.m_MWidth = newMWidth
		End Sub

		Public Sub Rotate(pMap As AxMap, rootPt As PointF, fromPt As PointF, toPt As PointF)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			mX -= rootPt.X
			mY -= rootPt.Y
			Dim mRoot As PointF = Nothing
			mRoot.X = mX
			mRoot.Y = mY
			fromPt.X -= rootPt.X
			fromPt.Y -= rootPt.Y
			toPt.X -= rootPt.X
			toPt.Y -= rootPt.Y
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mObj.Rotate(mRoot, fromPt, toPt)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Rotate2(pMap As AxMap, rootPt As PointF, degree As Double)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			mX -= rootPt.X
			mY -= rootPt.Y
			Dim mRoot As PointF = Nothing
			mRoot.X = mX
			mRoot.Y = mY
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mObj.Rotate2(mRoot, degree)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Scale(pMap As AxMap, rootPt As PointF, fromPt As PointF, toPt As PointF)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			mX -= rootPt.X
			mY -= rootPt.Y
			Dim mRoot As PointF = Nothing
			mRoot.X = mX
			mRoot.Y = mY
			fromPt.X -= rootPt.X
			fromPt.Y -= rootPt.Y
			toPt.X -= rootPt.X
			toPt.Y -= rootPt.Y
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mObj.Zoom(mRoot, fromPt, toPt)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Scale2(pMap As AxMap, rootPt As PointF, deltaX As Single, deltaY As Single)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			mX -= rootPt.X
			mY -= rootPt.Y
			Dim mRoot As PointF = Nothing
			mRoot.X = mX
			mRoot.Y = mY
			Dim rect As System.Drawing.Rectangle = Me.GetBounds(pMap)
			Dim dX As Single = (CSng(rect.Width) + deltaX) / CSng(rect.Width)
			Dim dY As Single = (CSng(rect.Height) + deltaY) / CSng(rect.Height)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mObj.Zoom2(mRoot, dX, dY)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub VFlip()
			Dim myRect As RectangleF
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					myRect = mGObj.GetBounds()
					Dim myL As Single
					Dim flag As Boolean = myRect.Left < myL
					If flag Then
						myL = myRect.Left
					End If
					Dim myT As Single
					flag = (myRect.Top < myT)
					If flag Then
						myT = myRect.Top
					End If
					Dim myR As Single
					flag = (myRect.Right > myR)
					If flag Then
						myR = myRect.Right
					End If
					Dim myB As Single
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
			Dim mX0 As Single = (myRect.Left + myRect.Right) / 2F
			Try
				Dim enumerator2 As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator2.MoveNext()
					Dim mGObj2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
					mGObj2.VFlip(mX0)
				End While
			Finally
				Dim enumerator2 As IEnumerator
				Dim flag As Boolean = TypeOf enumerator2 Is IDisposable
				If flag Then
					(TryCast(enumerator2, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub VFlip(pMap As AxMap)
			Dim mX As Single
			Dim mY As Single
			pMap.ConvertCoord(mX, mY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim mX2 As Single = mX
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					mGObj.VFlip(mX2)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Protected Sub New()
			Me.Xfile = ""
		End Sub

		Public Sub New(pMap As AxMap, pGObjs As CGraphicObjs)
			Me.New()
			Dim num As Single = 0F
			Dim num2 As Single = 0F
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
			Me.m_Zoom = pMap.Zoom
			Me.m_MWidth = pMap.MapScreenWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = ""
			Me.m_Blinking = False
		End Sub

		Public Sub New(pMap As AxMap, pGObjs As CGraphicObjs, pZoom As Double, pMWidth As Single)
			Me.New()
			Dim num As Single = 0F
			Dim num2 As Single = 0F
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
			Me.m_Zoom = pZoom
			Me.m_MWidth = pMWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = ""
			Me.m_Blinking = False
		End Sub

		Public Sub New(pMap As AxMap, pt0 As PointF, pGObjs As CGraphicObjs)
			Me.New()
			Dim x As Single = pt0.X
			Dim y As Single = pt0.Y
			pMap.ConvertCoord(x, y, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
			pt0.Y = y
			pt0.X = x
			Me.m_Zoom = pMap.Zoom
			Me.m_MWidth = pMap.MapScreenWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = ""
			Me.m_Blinking = False
		End Sub

		Public Sub New(pMap As AxMap, pt0 As PointF, pGObjs As CGraphicObjs, pMapScreenWidth As Single)
			Me.New()
			Dim x As Single = pt0.X
			Dim y As Single = pt0.Y
			pMap.ConvertCoord(x, y, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
			pt0.Y = y
			pt0.X = x
			Me.m_Zoom = pMap.Zoom
			Me.m_MWidth = pMapScreenWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = ""
			Me.m_Blinking = False
		End Sub

		Public Sub New(pMap As AxMap, pt0 As PointF, pGObjs As CGraphicObjs, pZoom As Double, pMWidth As Single)
			Me.New()
			Dim x As Single = pt0.X
			Dim y As Single = pt0.Y
			pMap.ConvertCoord(x, y, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
			pt0.Y = y
			pt0.X = x
			Me.m_Zoom = pZoom
			Me.m_MWidth = pMWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = ""
			Me.m_Blinking = False
		End Sub

		Public Sub New(pDesc As String, pZoom As Double, pMWidth As Single, pGocX As Double, pGocY As Double, pGObjs As CGraphicObjs)
			Me.New()
			Me.m_GocX = pGocX
			Me.m_GocY = pGocY
			Me.m_Zoom = pZoom
			Me.m_MWidth = pMWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = pDesc
			Me.m_Blinking = False
		End Sub

		Public Sub New(pDesc As String, pBlinking As Boolean, pZoom As Double, pMWidth As Single, pGocX As Double, pGocY As Double, pGObjs As CGraphicObjs)
			Me.New()
			Me.m_GocX = pGocX
			Me.m_GocY = pGocY
			Me.m_Zoom = pZoom
			Me.m_MWidth = pMWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(aGObj.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = pDesc
			Me.m_Blinking = pBlinking
		End Sub
	End Class
End Namespace
