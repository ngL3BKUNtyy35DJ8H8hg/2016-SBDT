Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace SaBan
	Public Class CSymbol
		Private m_GocX As Double

		Private m_GocY As Double

		Private m_Zoom As Double

		Private m_MWidth As Single

		Private m_GObjs As CGraphicObjs

		Private m_Description As String

		Private m_Blinking As Boolean

		Public Heading As Single

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
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			Me.m_GObjs.DrawObjects(g, num)
			g.EndContainer(container)
		End Sub

		Public Sub DanhDau(pMap As AxMap, g As Graphics, Color As Color)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			g.ScaleTransform(num, num)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.DanhDau(g, Color)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			g.EndContainer(container)
		End Sub

		Public Sub DanhDau(pMap As AxMap, g As Graphics, Pen As Pen)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			g.ScaleTransform(num, num)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.DanhDau(g, Pen)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			g.EndContainer(container)
		End Sub

		Public Sub DanhDau(pMap As AxMap, g As Graphics, pObj As GraphicObject, Color As Color)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			g.ScaleTransform(num, num)
			pObj.DanhDau(g, Color)
			g.EndContainer(container)
		End Sub

		Public Function GetBounds(pMap As AxMap) As RectangleF
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim offsetX As Single
			Dim offsetY As Single
			pMap.ConvertCoord(offsetX, offsetY, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim matrix As Matrix = New Matrix()
			matrix.Translate(offsetX, offsetY)
			matrix.Scale(num, num)
			Dim left As Single
			Dim top As Single
			Dim right As Single
			Dim bottom As Single
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim bounds As RectangleF = graphicObject.GetBounds()
					If bounds.Left < left Then
						left = bounds.Left
					End If
					If bounds.Top < top Then
						top = bounds.Top
					End If
					If bounds.Right > right Then
						right = bounds.Right
					End If
					If bounds.Bottom > bottom Then
						bottom = bounds.Bottom
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim array As PointF() = New PointF(3) {}
			array(0) = New PointF(left, top)
			array(1) = New PointF(right, top)
			array(2) = New PointF(right, bottom)
			array(3) = New PointF(left, bottom)
			matrix.TransformPoints(array)
			matrix.Dispose()
			Dim array2 As PointF() = New PointF(1) {}
			array2(0).X = Math.Min(Math.Min(Math.Min(array(0).X, array(1).X), array(2).X), array(3).X)
			array2(0).Y = Math.Min(Math.Min(Math.Min(array(0).Y, array(1).Y), array(2).Y), array(3).Y)
			array2(1).X = Math.Max(Math.Max(Math.Max(array(0).X, array(1).X), array(2).X), array(3).X)
			array2(1).Y = Math.Max(Math.Max(Math.Max(array(0).Y, array(1).Y), array(2).Y), array(3).Y)
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim r As System.Drawing.Rectangle = New System.Drawing.Rectangle(CInt(Math.Round(CDec(array2(0).X))), CInt(Math.Round(CDec(array2(0).Y))), CInt(Math.Round(CDec((array2(1).X - array2(0).X)))), CInt(Math.Round(CDec((array2(1).Y - array2(0).Y)))))
			Return r
		End Function

		Public Sub VeBound(pMap As AxMap, g As Graphics, Color As Color)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			g.ScaleTransform(num, num)
			Dim left As Single
			Dim top As Single
			Dim right As Single
			Dim bottom As Single
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim bounds As RectangleF = graphicObject.GetBounds()
					If bounds.Left < left Then
						left = bounds.Left
					End If
					If bounds.Top < top Then
						top = bounds.Top
					End If
					If bounds.Right > right Then
						right = bounds.Right
					End If
					If bounds.Bottom > bottom Then
						bottom = bounds.Bottom
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim pen As Pen = New Pen(Color.Black)
			pen.DashStyle = DashStyle.Dot
			pen.Width = 2F
			pen.Color = Color.White
			Dim arg_175_1 As Pen = pen
			' The following expression was wrapped in a checked-statement
			Dim rect As System.Drawing.Rectangle = New System.Drawing.Rectangle(CInt(Math.Round(CDec(left))), CInt(Math.Round(CDec(top))), CInt(Math.Round(CDec((right - left)))), CInt(Math.Round(CDec((bottom - top)))))
			g.DrawRectangle(arg_175_1, rect)
			pen.Width = 1F
			pen.Color = Color
			Dim arg_1C5_1 As Pen = pen
			rect = New System.Drawing.Rectangle(CInt(Math.Round(CDec(left))), CInt(Math.Round(CDec(top))), CInt(Math.Round(CDec((right - left)))), CInt(Math.Round(CDec((bottom - top)))))
			g.DrawRectangle(arg_1C5_1, rect)
			pen.Dispose()
			g.EndContainer(container)
		End Sub

		Public Sub VeBound(pMap As AxMap, g As Graphics, pObj As GraphicObject, Color As Color)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			g.ScaleTransform(num, num)
			pObj.VeBound(g, Color)
			g.EndContainer(container)
		End Sub

		Public Sub DrawNodes(pMap As AxMap, g As Graphics)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim dx As Single
			Dim dy As Single
			pMap.ConvertCoord(dx, dy, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim container As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(dx, dy)
			g.ScaleTransform(num, num)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim points As PointF() = graphicObject.GetPoints()
					modBdTC.DrawNodes(g, points, 3F)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			g.EndContainer(container)
		End Sub

		Public Sub DrawRoot(pMap As AxMap, g As Graphics)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim pen As Pen = New Pen(Color.Black, 2F)
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim rect As System.Drawing.Rectangle = New System.Drawing.Rectangle(CInt(Math.Round(CDec((num - 3F)))), CInt(Math.Round(CDec((num2 - 3F)))), 7, 7)
			g.DrawRectangle(pen, rect)
			pen.Dispose()
		End Sub

		Public Function HitTest(pMap As AxMap, pt As PointF) As Boolean
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim num2 As Single
			Dim num3 As Single
			pMap.ConvertCoord(num2, num3, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim matrix As Matrix = New Matrix()
			matrix.Translate(-num2, -num3, MatrixOrder.Append)
			matrix.Scale(1F / num, 1F / num, MatrixOrder.Append)
			Dim array As PointF() = New PointF() { pt }
			matrix.TransformPoints(array)
			Dim pt2 As PointF = New PointF(array(0).X, array(0).Y)
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			If Me.m_GObjs.Count > 0 Then
				For i As Integer = Me.m_GObjs.Count - 1 To 0 Step -1
					Dim graphicObject As GraphicObject = Me.m_GObjs(i)
					If graphicObject.HitTest(pt2) Then
						result = True
						Return result
					End If
				Next
			End If
			result = False
			Return result
		End Function

		Public Function HitTest(pMap As AxMap, rect As RectangleF) As Boolean
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim num2 As Single
			Dim num3 As Single
			pMap.ConvertCoord(num2, num3, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim matrix As Matrix = New Matrix()
			matrix.Translate(-num2, -num3, MatrixOrder.Append)
			matrix.Scale(1F / num, 1F / num, MatrixOrder.Append)
			Dim array As PointF() = New PointF(1) {}
			array(0) = New PointF(rect.Left, rect.Top)
			array(1) = New PointF(rect.Left + rect.Width, rect.Top + rect.Height)
			matrix.TransformPoints(array)
			Dim rect2 As RectangleF = New RectangleF(array(0).X, array(0).Y, array(1).X - array(0).X, array(1).Y - array(0).Y)
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			If Me.m_GObjs.Count > 0 Then
				For i As Integer = Me.m_GObjs.Count - 1 To 0 Step -1
					Dim graphicObject As GraphicObject = Me.m_GObjs(i)
					If Not graphicObject.HitTest(rect2) Then
						result = False
						Return result
					End If
				Next
			End If
			result = True
			Return result
		End Function

		Public Function FindObjectAtPoint(pMap As AxMap, pt As PointF) As GraphicObject
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim num2 As Single
			Dim num3 As Single
			pMap.ConvertCoord(num2, num3, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim matrix As Matrix = New Matrix()
			matrix.Translate(-num2, -num3, MatrixOrder.Append)
			matrix.Scale(1F / num, 1F / num, MatrixOrder.Append)
			Dim array As PointF() = New PointF() { pt }
			matrix.TransformPoints(array)
			Dim pt2 As PointF = New PointF(array(0).X, array(0).Y)
			Return Me.m_GObjs.FindObjectAtPoint(pt2)
		End Function

		Public Sub MoveNodeTo(pMap As AxMap, ENode As CFOUNDNODE, pt As PointF)
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim num2 As Single
			Dim num3 As Single
			pMap.ConvertCoord(num2, num3, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim matrix As Matrix = New Matrix()
			Dim foundObject As GraphicObject = ENode.FoundObject
			matrix.Translate(-num2, -num3, MatrixOrder.Append)
			matrix.Scale(1F / num, 1F / num, MatrixOrder.Append)
			Dim array As PointF() = New PointF() { pt }
			matrix.TransformPoints(array)
			Dim pt2 As PointF = New PointF(array(0).X, array(0).Y)
			foundObject.MoveNodeTo(ENode.NodeIndex, pt2)
		End Sub

		Public Function Noi2Objs(pFoundNode As CFOUNDNODE) As Boolean
			Dim result As Boolean = False
			' The following expression was wrapped in a checked-statement
			If pFoundNode.FoundObject.GetObjType() = OBJECTTYPE.Curve Or pFoundNode.FoundObject.GetObjType() = OBJECTTYPE.Line Then
				Dim nodesShapeGraphic As NodesShapeGraphic = CType(pFoundNode.FoundObject, NodesShapeGraphic)
				If pFoundNode.NodeIndex = 0 Or pFoundNode.NodeIndex = nodesShapeGraphic.Nodes.Count - 1 Then
					Dim cFOUNDNODE As CFOUNDNODE = Me.Tim2ndNode(pFoundNode)
					If pFoundNode.NodeIndex = 0 Then
						nodesShapeGraphic.ReverseNodes()
					End If
					If cFOUNDNODE.NodeIndex = 0 Then
						Dim nodesShapeGraphic2 As NodesShapeGraphic = CType(cFOUNDNODE.FoundObject, NodesShapeGraphic)
						If nodesShapeGraphic2.Nodes.Count > 1 Then
							Dim arg_A1_0 As Integer = 1
							Dim num As Integer = nodesShapeGraphic2.Nodes.Count - 1
							For i As Integer = arg_A1_0 To num
								nodesShapeGraphic.Nodes.Add(nodesShapeGraphic2.Nodes(i))
							Next
						End If
						Me.m_GObjs.Remove(cFOUNDNODE.FoundObject)
						result = True
					Else If cFOUNDNODE.NodeIndex > 0 Then
						Dim nodesShapeGraphic3 As NodesShapeGraphic = CType(cFOUNDNODE.FoundObject, NodesShapeGraphic)
						If nodesShapeGraphic3.Nodes.Count > 1 Then
							For j As Integer = nodesShapeGraphic3.Nodes.Count - 2 To 0 Step -1
								nodesShapeGraphic.Nodes.Add(nodesShapeGraphic3.Nodes(j))
							Next
						End If
						Me.m_GObjs.Remove(cFOUNDNODE.FoundObject)
						result = True
					End If
				End If
			End If
			Return result
		End Function

		Private Function Tim2ndNode(pFoundNode As CFOUNDNODE) As CFOUNDNODE
			Dim cFOUNDNODE As CFOUNDNODE = New CFOUNDNODE()
			cFOUNDNODE.NodeIndex = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					If(graphicObject.GetObjType() = OBJECTTYPE.Curve Or graphicObject.GetObjType() = OBJECTTYPE.Line) AndAlso graphicObject IsNot pFoundNode.FoundObject Then
						Dim nodesShapeGraphic As NodesShapeGraphic = CType(graphicObject, NodesShapeGraphic)
						Dim nodesShapeGraphic2 As NodesShapeGraphic = CType(pFoundNode.FoundObject, NodesShapeGraphic)
						If nodesShapeGraphic.Nodes(0).X = nodesShapeGraphic2.Nodes(pFoundNode.NodeIndex).X And nodesShapeGraphic.Nodes(0).Y = nodesShapeGraphic2.Nodes(pFoundNode.NodeIndex).Y Then
							cFOUNDNODE.FoundObject = graphicObject
							cFOUNDNODE.NodeIndex = 0
						Else If nodesShapeGraphic.Nodes(nodesShapeGraphic.Nodes.Count - 1).X = nodesShapeGraphic2.Nodes(pFoundNode.NodeIndex).X And nodesShapeGraphic.Nodes(nodesShapeGraphic.Nodes.Count - 1).Y = nodesShapeGraphic2.Nodes(pFoundNode.NodeIndex).Y Then
							cFOUNDNODE.FoundObject = graphicObject
							cFOUNDNODE.NodeIndex = nodesShapeGraphic.Nodes.Count - 1
						End If
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return cFOUNDNODE
		End Function

		Public Function FindNodeAtPoint(pMap As AxMap, pt As PointF) As CFOUNDNODE
			Dim cFOUNDNODE As CFOUNDNODE = New CFOUNDNODE()
			Dim num As Single = CSng((Me.m_Zoom / pMap.Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, pMap.MapScreenWidth / Me.m_MWidth, 1)))
			Dim num2 As Single
			Dim num3 As Single
			pMap.ConvertCoord(num2, num3, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim matrix As Matrix = New Matrix()
			matrix.Translate(-num2, -num3, MatrixOrder.Append)
			matrix.Scale(1F / num, 1F / num, MatrixOrder.Append)
			Dim array As PointF() = New PointF() { pt }
			matrix.TransformPoints(array)
			Dim pt2 As PointF = New PointF(array(0).X, array(0).Y)
			' The following expression was wrapped in a checked-statement
			Dim result As CFOUNDNODE
			For i As Integer = Me.m_GObjs.Count - 1 To 0 Step -1
				Dim graphicObject As GraphicObject = Me.m_GObjs(i)
				Dim num4 As Integer = graphicObject.FindNodeAtPoint(pt2, 4F)
				If num4 > -1 Then
					Dim nodeIndex As Integer = num4
					cFOUNDNODE.FoundObject = graphicObject
					cFOUNDNODE.NodeIndex = nodeIndex
					result = cFOUNDNODE
					Return result
				End If
			Next
			result = Nothing
			Return result
		End Function

		Public Function RootHitTest(pMap As AxMap, pt As PointF) As Boolean
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim rectangleF As RectangleF = New RectangleF(num - 3F, num2 - 3F, 7F, 7F)
			Return rectangleF.Contains(pt)
		End Function

		Public Sub Move(pMap As AxMap, fromPt As PointF, toPt As PointF)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			num += toPt.X - fromPt.X
			num2 += toPt.Y - fromPt.Y
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
		End Sub

		Public Sub Shift(pMap As AxMap, deltaX As Single, deltaY As Single)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			num += deltaX
			num2 += deltaY
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miScreenToMap)
		End Sub

		Public Sub Shift(deltaX As Double, deltaY As Double)
			Me.m_GocX += deltaX
			Me.m_GocY += deltaY
		End Sub

		Public Sub ChangeRoot(pMap As AxMap, newGocX As Double, newGocY As Double)
			Dim num As Single = CSng((pMap.Zoom / Me.m_Zoom))
			num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, Me.m_MWidth / pMap.MapScreenWidth, 1)))
			Dim num2 As Single
			Dim num3 As Single
			pMap.ConvertCoord(num2, num3, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			Dim num4 As Single
			Dim num5 As Single
			pMap.ConvertCoord(num4, num5, newGocX, newGocY, ConversionConstants.miMapToScreen)
			Me.m_GocX = newGocX
			Me.m_GocY = newGocY
			Dim toPt As PointF = New PointF(num2 * num, num3 * num)
			Dim fromPt As PointF = New PointF(num4 * num, num5 * num)
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.Move(fromPt, toPt)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub ChangeZoomMWidtht(newZoom As Double, newMWidth As Single)
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim points As PointF() = graphicObject.GetPoints()
					Dim num As Single = CSng((Me.m_Zoom / newZoom))
					num = Conversions.ToSingle(Operators.MultiplyObject(num, Interaction.IIf(Me.m_MWidth > 0F, newMWidth / Me.m_MWidth, 1)))
					Dim matrix As Matrix = New Matrix()
					matrix.Reset()
					matrix.Scale(num, num, MatrixOrder.Append)
					matrix.TransformPoints(points)
					Dim arg_8C_0 As Integer = 0
					Dim upperBound As Integer = points.GetUpperBound(0)
					For i As Integer = arg_8C_0 To upperBound
						graphicObject.MoveNodeTo(i, points(i))
					Next
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Zoom = newZoom
			Me.m_MWidth = newMWidth
		End Sub

		Public Sub Rotate(pMap As AxMap, rootPt As PointF, fromPt As PointF, toPt As PointF)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			num -= rootPt.X
			num2 -= rootPt.Y
			Dim rootPt2 As PointF = Nothing
			rootPt2.X = num
			rootPt2.Y = num2
			fromPt.X -= rootPt.X
			fromPt.Y -= rootPt.Y
			toPt.X -= rootPt.X
			toPt.Y -= rootPt.Y
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.Rotate(rootPt2, fromPt, toPt)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Rotate2(pMap As AxMap, rootPt As PointF, degree As Double)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			num -= rootPt.X
			num2 -= rootPt.Y
			Dim rootPt2 As PointF = Nothing
			rootPt2.X = num
			rootPt2.Y = num2
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.Rotate2(rootPt2, degree)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Scale(pMap As AxMap, rootPt As PointF, fromPt As PointF, toPt As PointF)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			num -= rootPt.X
			num2 -= rootPt.Y
			Dim rootPt2 As PointF = Nothing
			rootPt2.X = num
			rootPt2.Y = num2
			fromPt.X -= rootPt.X
			fromPt.Y -= rootPt.Y
			toPt.X -= rootPt.X
			toPt.Y -= rootPt.Y
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.Zoom(rootPt2, fromPt, toPt)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub Scale2(pMap As AxMap, rootPt As PointF, deltaX As Single, deltaY As Single)
			Dim num As Single
			Dim num2 As Single
			pMap.ConvertCoord(num, num2, Me.m_GocX, Me.m_GocY, ConversionConstants.miMapToScreen)
			num -= rootPt.X
			num2 -= rootPt.Y
			Dim rootPt2 As PointF = Nothing
			rootPt2.X = num
			rootPt2.Y = num2
			Dim bounds As RectangleF = Me.GetBounds(pMap)
			Dim deltaX2 As Single = (bounds.Width + deltaX) / bounds.Width
			Dim deltaY2 As Single = (bounds.Height + deltaY) / bounds.Height
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					graphicObject.Zoom2(rootPt2, deltaX2, deltaY2)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub VFlip()
			Dim bounds As RectangleF
			Try
				Dim enumerator As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					bounds = graphicObject.GetBounds()
					Dim left As Single
					If bounds.Left < left Then
						left = bounds.Left
					End If
					Dim top As Single
					If bounds.Top < top Then
						top = bounds.Top
					End If
					Dim right As Single
					If bounds.Right > right Then
						right = bounds.Right
					End If
					Dim bottom As Single
					If bounds.Bottom > bottom Then
						bottom = bounds.Bottom
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Dim pX As Single = (bounds.Left + bounds.Right) / 2F
			Try
				Dim enumerator2 As IEnumerator = Me.m_GObjs.GetEnumerator()
				While enumerator2.MoveNext()
					Dim graphicObject2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
					graphicObject2.VFlip(pX)
				End While
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					(TryCast(enumerator2, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Protected Sub New()
			Me.Heading = 0F
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
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
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
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
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
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
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
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
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
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
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
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = pDesc
			Me.m_Blinking = False
		End Sub

		Public Sub New(pDesc As String, pBlinking As Boolean, pZoom As Double, pMWidth As Single, pGocX As Double, pGocY As Double, pGObjs As CGraphicObjs, pHeading As Single)
			Me.New()
			Me.m_GocX = pGocX
			Me.m_GocY = pGocY
			Me.m_Zoom = pZoom
			Me.m_MWidth = pMWidth
			Me.m_GObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_GObjs.Add(graphicObject.Clone())
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_Description = pDesc
			Me.m_Blinking = pBlinking
			Me.Heading = pHeading
		End Sub
	End Class
End Namespace
