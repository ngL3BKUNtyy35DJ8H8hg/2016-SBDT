Imports DanhMuc
Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My.Resources
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Xml

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgCacKyHieu
		Inherits Form

		Private Structure SPLITOBJECTS
			Public Obj1 As GraphicObject

			Public Obj2 As GraphicObject
		End Structure

		Private Structure EDITNODE
			Public r As Rectangle

			Public iPart As Integer

			Public iNode As Integer
		End Structure

		Private Enum VeTools
			None
			Edit
			Polygon
			Line
			Curve
			ClosedCurve
			Cycle
			Pie
			Text
			Image
			Move
			MoveShape
			Scale
			ScaleShape
			Rotate
			RotateShape
			GroupMove
			GroupMoveShape
			GroupScale
			GroupScaleShape
			Split
			DangSplit
			ChangeRoot
		End Enum

		Private components As IContainer

		<AccessedThroughProperty("cmnuThumbNail")>
		Private _cmnuThumbNail As ContextMenu

		<AccessedThroughProperty("cmnuKichThuoc")>
		Private _cmnuKichThuoc As MenuItem

		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		<AccessedThroughProperty("ContextMenu1")>
		Private _ContextMenu1 As ContextMenu

		<AccessedThroughProperty("MnXoaNode")>
		Private _MnXoaNode As MenuItem

		<AccessedThroughProperty("MenuItem2")>
		Private _MenuItem2 As MenuItem

		<AccessedThroughProperty("MnuAddNode")>
		Private _MnuAddNode As MenuItem

		<AccessedThroughProperty("MenuItem3")>
		Private _MenuItem3 As MenuItem

		<AccessedThroughProperty("MnuChangeNodeType")>
		Private _MnuChangeNodeType As MenuItem

		<AccessedThroughProperty("MenuItem13")>
		Private _MenuItem13 As MenuItem

		<AccessedThroughProperty("mnu1stNode")>
		Private _mnu1stNode As MenuItem

		<AccessedThroughProperty("ContextMenu2")>
		Private _ContextMenu2 As ContextMenu

		<AccessedThroughProperty("MnuMoveShape")>
		Private _MnuMoveShape As MenuItem

		<AccessedThroughProperty("MenuItem9")>
		Private _MenuItem9 As MenuItem

		<AccessedThroughProperty("MnuScaleShape")>
		Private _MnuScaleShape As MenuItem

		<AccessedThroughProperty("MenuItem5")>
		Private _MenuItem5 As MenuItem

		<AccessedThroughProperty("MnuRotateShape")>
		Private _MnuRotateShape As MenuItem

		<AccessedThroughProperty("MenuItem11")>
		Private _MenuItem11 As MenuItem

		<AccessedThroughProperty("mnuFlip")>
		Private _mnuFlip As MenuItem

		<AccessedThroughProperty("MenuItem7")>
		Private _MenuItem7 As MenuItem

		<AccessedThroughProperty("MnuDeleteShape")>
		Private _MnuDeleteShape As MenuItem

		<AccessedThroughProperty("MenuItem6")>
		Private _MenuItem6 As MenuItem

		<AccessedThroughProperty("MnuChangeColor")>
		Private _MnuChangeColor As MenuItem

		<AccessedThroughProperty("MenuItem8")>
		Private _MenuItem8 As MenuItem

		<AccessedThroughProperty("MnuNodesEdit")>
		Private _MnuNodesEdit As MenuItem

		<AccessedThroughProperty("MenuItem1")>
		Private _MenuItem1 As MenuItem

		<AccessedThroughProperty("MnuSendBack")>
		Private _MnuSendBack As MenuItem

		<AccessedThroughProperty("MenuItem4")>
		Private _MenuItem4 As MenuItem

		<AccessedThroughProperty("MnuCopyShape")>
		Private _MnuCopyShape As MenuItem

		<AccessedThroughProperty("MenuItem10")>
		Private _MenuItem10 As MenuItem

		<AccessedThroughProperty("mnuClosedCurveToCurve")>
		Private _mnuClosedCurveToCurve As MenuItem

		<AccessedThroughProperty("MenuItem12")>
		Private _MenuItem12 As MenuItem

		<AccessedThroughProperty("mnuCurveToClosedCurve")>
		Private _mnuCurveToClosedCurve As MenuItem

		<AccessedThroughProperty("MnuGroup")>
		Private _MnuGroup As ContextMenu

		<AccessedThroughProperty("MnuGroupMove")>
		Private _MnuGroupMove As MenuItem

		<AccessedThroughProperty("MenuItem14")>
		Private _MenuItem14 As MenuItem

		<AccessedThroughProperty("MnuGroupScale")>
		Private _MnuGroupScale As MenuItem

		<AccessedThroughProperty("mnuGroupAll")>
		Private _mnuGroupAll As ContextMenu

		<AccessedThroughProperty("mnuGroupAllMove")>
		Private _mnuGroupAllMove As MenuItem

		<AccessedThroughProperty("MenuItem16")>
		Private _MenuItem16 As MenuItem

		<AccessedThroughProperty("mnuGroupAllScale")>
		Private _mnuGroupAllScale As MenuItem

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		<AccessedThroughProperty("txtTyLe")>
		Private _txtTyLe As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("picThumbNails")>
		Private _picThumbNails As PictureBox

		<AccessedThroughProperty("Splitter2")>
		Private _Splitter2 As Splitter

		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		<AccessedThroughProperty("txtKyHieu_ID")>
		Private _txtKyHieu_ID As TextBox

		<AccessedThroughProperty("btnDelete")>
		Private _btnDelete As Button

		<AccessedThroughProperty("btnSave")>
		Private _btnSave As Button

		<AccessedThroughProperty("txtTenKH")>
		Private _txtTenKH As TextBox

		<AccessedThroughProperty("btnNew")>
		Private _btnNew As Button

		<AccessedThroughProperty("btnEdit")>
		Private _btnEdit As Button

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		<AccessedThroughProperty("Splitter1")>
		Private _Splitter1 As Splitter

		<AccessedThroughProperty("ToolBar1")>
		Private _ToolBar1 As ToolBar

		<AccessedThroughProperty("ToolBarButton1")>
		Private _ToolBarButton1 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton2")>
		Private _ToolBarButton2 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton3")>
		Private _ToolBarButton3 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton4")>
		Private _ToolBarButton4 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton5")>
		Private _ToolBarButton5 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton6")>
		Private _ToolBarButton6 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton7")>
		Private _ToolBarButton7 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton8")>
		Private _ToolBarButton8 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton9")>
		Private _ToolBarButton9 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton10")>
		Private _ToolBarButton10 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton11")>
		Private _ToolBarButton11 As ToolBarButton

		<AccessedThroughProperty("ToolBarButton12")>
		Private _ToolBarButton12 As ToolBarButton

		<AccessedThroughProperty("StatusBar1")>
		Private _StatusBar1 As StatusBar

		<AccessedThroughProperty("StatusBarPanel1")>
		Private _StatusBarPanel1 As StatusBarPanel

		<AccessedThroughProperty("StatusBarPanel2")>
		Private _StatusBarPanel2 As StatusBarPanel

		<AccessedThroughProperty("StatusBarPanel3")>
		Private _StatusBarPanel3 As StatusBarPanel

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		<AccessedThroughProperty("VScrollBar1")>
		Private _VScrollBar1 As VScrollBar

		<AccessedThroughProperty("HScrollBar1")>
		Private _HScrollBar1 As HScrollBar

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("StatusBarPanel4")>
		Private _StatusBarPanel4 As StatusBarPanel

		<AccessedThroughProperty("MnuSplitShape")>
		Private _MnuSplitShape As MenuItem

		<AccessedThroughProperty("MenuItem17")>
		Private _MenuItem17 As MenuItem

		<AccessedThroughProperty("MenuItem15")>
		Private _MenuItem15 As MenuItem

		<AccessedThroughProperty("mnuGroupAllPast")>
		Private _mnuGroupAllPast As MenuItem

		<AccessedThroughProperty("cmnuKyHieu")>
		Private _cmnuKyHieu As ContextMenu

		<AccessedThroughProperty("cmnuCopyTo")>
		Private _cmnuCopyTo As MenuItem

		<AccessedThroughProperty("MenuItem19")>
		Private _MenuItem19 As MenuItem

		<AccessedThroughProperty("cmnuDeleteKH")>
		Private _cmnuDeleteKH As MenuItem

		<AccessedThroughProperty("btnUp")>
		Private _btnUp As Button

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("MenuItem20")>
		Private _MenuItem20 As MenuItem

		<AccessedThroughProperty("MnuGroupCopy")>
		Private _MnuGroupCopy As MenuItem

		<AccessedThroughProperty("MenuItem21")>
		Private _MenuItem21 As MenuItem

		<AccessedThroughProperty("mnuGroupPast")>
		Private _mnuGroupPast As MenuItem

		<AccessedThroughProperty("MnuSendFront")>
		Private _MnuSendFront As MenuItem

		<AccessedThroughProperty("btnDown")>
		Private _btnDown As Button

		<AccessedThroughProperty("DBiCombo1")>
		Private _DBiCombo1 As DBiCombo

		Private EditNodes As dlgCacKyHieu.EDITNODE()

		Private EditNodesCount As Integer

		Private myKHConnStr As String

		<AccessedThroughProperty("myThumbNails")>
		Private _myThumbNails As CThumbNails

		Private myRootX As Integer

		Private myRootY As Integer

		Public myORootX As Integer

		Public myORootY As Integer

		Private RootDragging As Boolean

		Private dragOffset As PointF

		Private selectionDragging As Boolean

		Private selectionRect As RectangleF

		Private DrawingDragging As Boolean

		Private DrawingRect As Rectangle

		Private DrawingPicking As Boolean

		Private myPts As PointF()

		Private myfromPt As PointF

		Private mytoPt As PointF

		Private myrootPt As PointF

		Private EditObj As GraphicObject

		Private iEditNode As Integer

		Private iEditNode2 As Integer

		Private m_SelectedObject As GraphicObject

		Private m_CopyObject As GraphicObject

		Private m_drawingObjects As CGraphicObjs

		Private m_OdrawingObjects As CGraphicObjs

		Private m_selectedObjects As CGraphicObjs

		Private m_EditingObjects As CGraphicObjs

		Private m_CopyObjects As CGraphicObjs

		Private m_DrawTool As dlgCacKyHieu.VeTools

		Private Const MinW As Integer = 40

		Private Const MinH As Integer = 40

		Private Const MaxW As Integer = 1500

		Private Const MaxH As Integer = 1500

		Private pointTL As Point

		Private bSnap As Boolean

		Public myScale As Integer

		Public myGridWidth As Integer

		Public myWidth As Integer

		Public myHeight As Integer

		Private GridSize As Size

		Private GridRect As Rectangle

		Private myDataTable As DataTable

		Private bLoadXong As Boolean

		Private GridPen As Pen

		Private dvLoaiKH As DataView

		Private Mode As String

		Friend Overridable Property cmnuThumbNail() As ContextMenu
			Get
				Return Me._cmnuThumbNail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._cmnuThumbNail = value
			End Set
		End Property

		Friend Overridable Property cmnuKichThuoc() As MenuItem
			Get
				Return Me._cmnuKichThuoc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.cmnuKichThuoc_Click
				If Me._cmnuKichThuoc IsNot Nothing Then
					RemoveHandler Me._cmnuKichThuoc.Click, value2
				End If
				Me._cmnuKichThuoc = value
				If Me._cmnuKichThuoc IsNot Nothing Then
					AddHandler Me._cmnuKichThuoc.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ImageList1() As ImageList
			Get
				Return Me._ImageList1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		Friend Overridable Property ContextMenu1() As ContextMenu
			Get
				Return Me._ContextMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Friend Overridable Property MnXoaNode() As MenuItem
			Get
				Return Me._MnXoaNode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnXoaNode_Click
				If Me._MnXoaNode IsNot Nothing Then
					RemoveHandler Me._MnXoaNode.Click, value2
				End If
				Me._MnXoaNode = value
				If Me._MnXoaNode IsNot Nothing Then
					AddHandler Me._MnXoaNode.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem2() As MenuItem
			Get
				Return Me._MenuItem2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem2 = value
			End Set
		End Property

		Friend Overridable Property MnuAddNode() As MenuItem
			Get
				Return Me._MnuAddNode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuAddNode_Click
				If Me._MnuAddNode IsNot Nothing Then
					RemoveHandler Me._MnuAddNode.Click, value2
				End If
				Me._MnuAddNode = value
				If Me._MnuAddNode IsNot Nothing Then
					AddHandler Me._MnuAddNode.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem3() As MenuItem
			Get
				Return Me._MenuItem3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem3 = value
			End Set
		End Property

		Friend Overridable Property MnuChangeNodeType() As MenuItem
			Get
				Return Me._MnuChangeNodeType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuChangeNodeType_Click
				If Me._MnuChangeNodeType IsNot Nothing Then
					RemoveHandler Me._MnuChangeNodeType.Click, value2
				End If
				Me._MnuChangeNodeType = value
				If Me._MnuChangeNodeType IsNot Nothing Then
					AddHandler Me._MnuChangeNodeType.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem13() As MenuItem
			Get
				Return Me._MenuItem13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem13 = value
			End Set
		End Property

		Friend Overridable Property mnu1stNode() As MenuItem
			Get
				Return Me._mnu1stNode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnu1stNode_Click
				If Me._mnu1stNode IsNot Nothing Then
					RemoveHandler Me._mnu1stNode.Click, value2
				End If
				Me._mnu1stNode = value
				If Me._mnu1stNode IsNot Nothing Then
					AddHandler Me._mnu1stNode.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ContextMenu2() As ContextMenu
			Get
				Return Me._ContextMenu2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu2 = value
			End Set
		End Property

		Friend Overridable Property MnuMoveShape() As MenuItem
			Get
				Return Me._MnuMoveShape
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuMoveShape_Click
				If Me._MnuMoveShape IsNot Nothing Then
					RemoveHandler Me._MnuMoveShape.Click, value2
				End If
				Me._MnuMoveShape = value
				If Me._MnuMoveShape IsNot Nothing Then
					AddHandler Me._MnuMoveShape.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem9() As MenuItem
			Get
				Return Me._MenuItem9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem9 = value
			End Set
		End Property

		Friend Overridable Property MnuScaleShape() As MenuItem
			Get
				Return Me._MnuScaleShape
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuScaleShape_Click
				If Me._MnuScaleShape IsNot Nothing Then
					RemoveHandler Me._MnuScaleShape.Click, value2
				End If
				Me._MnuScaleShape = value
				If Me._MnuScaleShape IsNot Nothing Then
					AddHandler Me._MnuScaleShape.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem5() As MenuItem
			Get
				Return Me._MenuItem5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem5 = value
			End Set
		End Property

		Friend Overridable Property MnuRotateShape() As MenuItem
			Get
				Return Me._MnuRotateShape
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuRotateShape_Click
				If Me._MnuRotateShape IsNot Nothing Then
					RemoveHandler Me._MnuRotateShape.Click, value2
				End If
				Me._MnuRotateShape = value
				If Me._MnuRotateShape IsNot Nothing Then
					AddHandler Me._MnuRotateShape.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem11() As MenuItem
			Get
				Return Me._MenuItem11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem11 = value
			End Set
		End Property

		Friend Overridable Property mnuFlip() As MenuItem
			Get
				Return Me._mnuFlip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFlip_Click
				If Me._mnuFlip IsNot Nothing Then
					RemoveHandler Me._mnuFlip.Click, value2
				End If
				Me._mnuFlip = value
				If Me._mnuFlip IsNot Nothing Then
					AddHandler Me._mnuFlip.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem7() As MenuItem
			Get
				Return Me._MenuItem7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem7 = value
			End Set
		End Property

		Friend Overridable Property MnuDeleteShape() As MenuItem
			Get
				Return Me._MnuDeleteShape
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuDeleteShape_Click
				If Me._MnuDeleteShape IsNot Nothing Then
					RemoveHandler Me._MnuDeleteShape.Click, value2
				End If
				Me._MnuDeleteShape = value
				If Me._MnuDeleteShape IsNot Nothing Then
					AddHandler Me._MnuDeleteShape.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem6() As MenuItem
			Get
				Return Me._MenuItem6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem6 = value
			End Set
		End Property

		Friend Overridable Property MnuChangeColor() As MenuItem
			Get
				Return Me._MnuChangeColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuChangeColor_Click
				If Me._MnuChangeColor IsNot Nothing Then
					RemoveHandler Me._MnuChangeColor.Click, value2
				End If
				Me._MnuChangeColor = value
				If Me._MnuChangeColor IsNot Nothing Then
					AddHandler Me._MnuChangeColor.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem8() As MenuItem
			Get
				Return Me._MenuItem8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem8 = value
			End Set
		End Property

		Friend Overridable Property MnuNodesEdit() As MenuItem
			Get
				Return Me._MnuNodesEdit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuNodesEdit_Click
				If Me._MnuNodesEdit IsNot Nothing Then
					RemoveHandler Me._MnuNodesEdit.Click, value2
				End If
				Me._MnuNodesEdit = value
				If Me._MnuNodesEdit IsNot Nothing Then
					AddHandler Me._MnuNodesEdit.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem1() As MenuItem
			Get
				Return Me._MenuItem1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem1 = value
			End Set
		End Property

		Friend Overridable Property MnuSendBack() As MenuItem
			Get
				Return Me._MnuSendBack
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuSendBack_Click
				If Me._MnuSendBack IsNot Nothing Then
					RemoveHandler Me._MnuSendBack.Click, value2
				End If
				Me._MnuSendBack = value
				If Me._MnuSendBack IsNot Nothing Then
					AddHandler Me._MnuSendBack.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem4() As MenuItem
			Get
				Return Me._MenuItem4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem4 = value
			End Set
		End Property

		Friend Overridable Property MnuCopyShape() As MenuItem
			Get
				Return Me._MnuCopyShape
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuCopyShape_Click
				If Me._MnuCopyShape IsNot Nothing Then
					RemoveHandler Me._MnuCopyShape.Click, value2
				End If
				Me._MnuCopyShape = value
				If Me._MnuCopyShape IsNot Nothing Then
					AddHandler Me._MnuCopyShape.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem10() As MenuItem
			Get
				Return Me._MenuItem10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem10 = value
			End Set
		End Property

		Friend Overridable Property mnuClosedCurveToCurve() As MenuItem
			Get
				Return Me._mnuClosedCurveToCurve
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuClosedCurveToCurve_Click
				If Me._mnuClosedCurveToCurve IsNot Nothing Then
					RemoveHandler Me._mnuClosedCurveToCurve.Click, value2
				End If
				Me._mnuClosedCurveToCurve = value
				If Me._mnuClosedCurveToCurve IsNot Nothing Then
					AddHandler Me._mnuClosedCurveToCurve.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem12() As MenuItem
			Get
				Return Me._MenuItem12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem12 = value
			End Set
		End Property

		Friend Overridable Property mnuCurveToClosedCurve() As MenuItem
			Get
				Return Me._mnuCurveToClosedCurve
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuCurveToClosedCurve_Click
				If Me._mnuCurveToClosedCurve IsNot Nothing Then
					RemoveHandler Me._mnuCurveToClosedCurve.Click, value2
				End If
				Me._mnuCurveToClosedCurve = value
				If Me._mnuCurveToClosedCurve IsNot Nothing Then
					AddHandler Me._mnuCurveToClosedCurve.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MnuGroup() As ContextMenu
			Get
				Return Me._MnuGroup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._MnuGroup = value
			End Set
		End Property

		Friend Overridable Property MnuGroupMove() As MenuItem
			Get
				Return Me._MnuGroupMove
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuGroupMove_Click
				If Me._MnuGroupMove IsNot Nothing Then
					RemoveHandler Me._MnuGroupMove.Click, value2
				End If
				Me._MnuGroupMove = value
				If Me._MnuGroupMove IsNot Nothing Then
					AddHandler Me._MnuGroupMove.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem14() As MenuItem
			Get
				Return Me._MenuItem14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem14 = value
			End Set
		End Property

		Friend Overridable Property MnuGroupScale() As MenuItem
			Get
				Return Me._MnuGroupScale
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuGroupScale_Click
				If Me._MnuGroupScale IsNot Nothing Then
					RemoveHandler Me._MnuGroupScale.Click, value2
				End If
				Me._MnuGroupScale = value
				If Me._MnuGroupScale IsNot Nothing Then
					AddHandler Me._MnuGroupScale.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property mnuGroupAll() As ContextMenu
			Get
				Return Me._mnuGroupAll
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._mnuGroupAll = value
			End Set
		End Property

		Friend Overridable Property mnuGroupAllMove() As MenuItem
			Get
				Return Me._mnuGroupAllMove
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuGroupAllMove_Click
				If Me._mnuGroupAllMove IsNot Nothing Then
					RemoveHandler Me._mnuGroupAllMove.Click, value2
				End If
				Me._mnuGroupAllMove = value
				If Me._mnuGroupAllMove IsNot Nothing Then
					AddHandler Me._mnuGroupAllMove.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem16() As MenuItem
			Get
				Return Me._MenuItem16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem16 = value
			End Set
		End Property

		Friend Overridable Property mnuGroupAllScale() As MenuItem
			Get
				Return Me._mnuGroupAllScale
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuGroupAllScale_Click
				If Me._mnuGroupAllScale IsNot Nothing Then
					RemoveHandler Me._mnuGroupAllScale.Click, value2
				End If
				Me._mnuGroupAllScale = value
				If Me._mnuGroupAllScale IsNot Nothing Then
					AddHandler Me._mnuGroupAllScale.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Panel1() As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Friend Overridable Property Panel3() As Panel
			Get
				Return Me._Panel3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel3 = value
			End Set
		End Property

		Friend Overridable Property txtTyLe() As TextBox
			Get
				Return Me._txtTyLe
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTyLe = value
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property picThumbNails() As PictureBox
			Get
				Return Me._picThumbNails
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._picThumbNails = value
			End Set
		End Property

		Friend Overridable Property Splitter2() As Splitter
			Get
				Return Me._Splitter2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter2 = value
			End Set
		End Property

		Friend Overridable Property Panel4() As Panel
			Get
				Return Me._Panel4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel4 = value
			End Set
		End Property

		Friend Overridable Property txtKyHieu_ID() As TextBox
			Get
				Return Me._txtKyHieu_ID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtKyHieu_ID = value
			End Set
		End Property

		Friend Overridable Property btnDelete() As Button
			Get
				Return Me._btnDelete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDelete_Click
				If Me._btnDelete IsNot Nothing Then
					RemoveHandler Me._btnDelete.Click, value2
				End If
				Me._btnDelete = value
				If Me._btnDelete IsNot Nothing Then
					AddHandler Me._btnDelete.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnSave() As Button
			Get
				Return Me._btnSave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSave_Click
				If Me._btnSave IsNot Nothing Then
					RemoveHandler Me._btnSave.Click, value2
				End If
				Me._btnSave = value
				If Me._btnSave IsNot Nothing Then
					AddHandler Me._btnSave.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtTenKH() As TextBox
			Get
				Return Me._txtTenKH
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTenKH = value
			End Set
		End Property

		Friend Overridable Property btnNew() As Button
			Get
				Return Me._btnNew
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnNew_Click
				If Me._btnNew IsNot Nothing Then
					RemoveHandler Me._btnNew.Click, value2
				End If
				Me._btnNew = value
				If Me._btnNew IsNot Nothing Then
					AddHandler Me._btnNew.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnEdit() As Button
			Get
				Return Me._btnEdit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnEdit_Click
				If Me._btnEdit IsNot Nothing Then
					RemoveHandler Me._btnEdit.Click, value2
				End If
				Me._btnEdit = value
				If Me._btnEdit IsNot Nothing Then
					AddHandler Me._btnEdit.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property PictureBox2() As PictureBox
			Get
				Return Me._PictureBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.PictureBox2_Paint
				If Me._PictureBox2 IsNot Nothing Then
					RemoveHandler Me._PictureBox2.Paint, value2
				End If
				Me._PictureBox2 = value
				If Me._PictureBox2 IsNot Nothing Then
					AddHandler Me._PictureBox2.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property Splitter1() As Splitter
			Get
				Return Me._Splitter1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter1 = value
			End Set
		End Property

		Friend Overridable Property ToolBar1() As ToolBar
			Get
				Return Me._ToolBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.ToolBar1_ButtonClick
				If Me._ToolBar1 IsNot Nothing Then
					RemoveHandler Me._ToolBar1.ButtonClick, value2
				End If
				Me._ToolBar1 = value
				If Me._ToolBar1 IsNot Nothing Then
					AddHandler Me._ToolBar1.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolBarButton1() As ToolBarButton
			Get
				Return Me._ToolBarButton1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton1 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton2() As ToolBarButton
			Get
				Return Me._ToolBarButton2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton2 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton3() As ToolBarButton
			Get
				Return Me._ToolBarButton3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton3 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton4() As ToolBarButton
			Get
				Return Me._ToolBarButton4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton4 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton5() As ToolBarButton
			Get
				Return Me._ToolBarButton5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton5 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton6() As ToolBarButton
			Get
				Return Me._ToolBarButton6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton6 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton7() As ToolBarButton
			Get
				Return Me._ToolBarButton7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton7 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton8() As ToolBarButton
			Get
				Return Me._ToolBarButton8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton8 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton9() As ToolBarButton
			Get
				Return Me._ToolBarButton9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton9 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton10() As ToolBarButton
			Get
				Return Me._ToolBarButton10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton10 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton11() As ToolBarButton
			Get
				Return Me._ToolBarButton11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton11 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton12() As ToolBarButton
			Get
				Return Me._ToolBarButton12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton12 = value
			End Set
		End Property

		Friend Overridable Property StatusBar1() As StatusBar
			Get
				Return Me._StatusBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBar)
				Me._StatusBar1 = value
			End Set
		End Property

		Friend Overridable Property StatusBarPanel1() As StatusBarPanel
			Get
				Return Me._StatusBarPanel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel1 = value
			End Set
		End Property

		Friend Overridable Property StatusBarPanel2() As StatusBarPanel
			Get
				Return Me._StatusBarPanel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel2 = value
			End Set
		End Property

		Friend Overridable Property StatusBarPanel3() As StatusBarPanel
			Get
				Return Me._StatusBarPanel3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel3 = value
			End Set
		End Property

		Friend Overridable Property Panel2() As Panel
			Get
				Return Me._Panel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As EventHandler = AddressOf Me.Panel2_Resize
				If Me._Panel2 IsNot Nothing Then
					RemoveHandler Me._Panel2.Resize, value2
				End If
				Me._Panel2 = value
				If Me._Panel2 IsNot Nothing Then
					AddHandler Me._Panel2.Resize, value2
				End If
			End Set
		End Property

		Friend Overridable Property VScrollBar1() As VScrollBar
			Get
				Return Me._VScrollBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As VScrollBar)
				Dim value2 As EventHandler = AddressOf Me.VScrollBar1_ValueChanged
				If Me._VScrollBar1 IsNot Nothing Then
					RemoveHandler Me._VScrollBar1.ValueChanged, value2
				End If
				Me._VScrollBar1 = value
				If Me._VScrollBar1 IsNot Nothing Then
					AddHandler Me._VScrollBar1.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property HScrollBar1() As HScrollBar
			Get
				Return Me._HScrollBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HScrollBar)
				Dim value2 As EventHandler = AddressOf Me.HScrollBar1_ValueChanged
				If Me._HScrollBar1 IsNot Nothing Then
					RemoveHandler Me._HScrollBar1.ValueChanged, value2
				End If
				Me._HScrollBar1 = value
				If Me._HScrollBar1 IsNot Nothing Then
					AddHandler Me._HScrollBar1.ValueChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property PictureBox1() As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox1_DoubleClick
				Dim value3 As PaintEventHandler = AddressOf Me.PictureBox1_Paint
				Dim value4 As MouseEventHandler = AddressOf Me.PictureBox1_MouseUp
				Dim value5 As MouseEventHandler = AddressOf Me.PictureBox1_MouseDown
				Dim value6 As MouseEventHandler = AddressOf Me.PictureBox1_MouseMove
				Dim value7 As KeyEventHandler = AddressOf Me.PictureBox1_KeyUp
				If Me._PictureBox1 IsNot Nothing Then
					RemoveHandler Me._PictureBox1.DoubleClick, value2
					RemoveHandler Me._PictureBox1.Paint, value3
					RemoveHandler Me._PictureBox1.MouseUp, value4
					RemoveHandler Me._PictureBox1.MouseDown, value5
					RemoveHandler Me._PictureBox1.MouseMove, value6
					RemoveHandler Me._PictureBox1.KeyUp, value7
				End If
				Me._PictureBox1 = value
				If Me._PictureBox1 IsNot Nothing Then
					AddHandler Me._PictureBox1.DoubleClick, value2
					AddHandler Me._PictureBox1.Paint, value3
					AddHandler Me._PictureBox1.MouseUp, value4
					AddHandler Me._PictureBox1.MouseDown, value5
					AddHandler Me._PictureBox1.MouseMove, value6
					AddHandler Me._PictureBox1.KeyUp, value7
				End If
			End Set
		End Property

		Friend Overridable Property StatusBarPanel4() As StatusBarPanel
			Get
				Return Me._StatusBarPanel4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel4 = value
			End Set
		End Property

		Friend Overridable Property MnuSplitShape() As MenuItem
			Get
				Return Me._MnuSplitShape
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuSplitShape_Click
				If Me._MnuSplitShape IsNot Nothing Then
					RemoveHandler Me._MnuSplitShape.Click, value2
				End If
				Me._MnuSplitShape = value
				If Me._MnuSplitShape IsNot Nothing Then
					AddHandler Me._MnuSplitShape.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem17() As MenuItem
			Get
				Return Me._MenuItem17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem17 = value
			End Set
		End Property

		Friend Overridable Property MenuItem15() As MenuItem
			Get
				Return Me._MenuItem15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem15 = value
			End Set
		End Property

		Friend Overridable Property mnuGroupAllPast() As MenuItem
			Get
				Return Me._mnuGroupAllPast
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuGroupAllPast_Click
				If Me._mnuGroupAllPast IsNot Nothing Then
					RemoveHandler Me._mnuGroupAllPast.Click, value2
				End If
				Me._mnuGroupAllPast = value
				If Me._mnuGroupAllPast IsNot Nothing Then
					AddHandler Me._mnuGroupAllPast.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property cmnuKyHieu() As ContextMenu
			Get
				Return Me._cmnuKyHieu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._cmnuKyHieu = value
			End Set
		End Property

		Friend Overridable Property cmnuCopyTo() As MenuItem
			Get
				Return Me._cmnuCopyTo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.cmnuCopyTo_Click
				If Me._cmnuCopyTo IsNot Nothing Then
					RemoveHandler Me._cmnuCopyTo.Click, value2
				End If
				Me._cmnuCopyTo = value
				If Me._cmnuCopyTo IsNot Nothing Then
					AddHandler Me._cmnuCopyTo.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem19() As MenuItem
			Get
				Return Me._MenuItem19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem19 = value
			End Set
		End Property

		Friend Overridable Property cmnuDeleteKH() As MenuItem
			Get
				Return Me._cmnuDeleteKH
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.cmnuDeleteKH_Click
				If Me._cmnuDeleteKH IsNot Nothing Then
					RemoveHandler Me._cmnuDeleteKH.Click, value2
				End If
				Me._cmnuDeleteKH = value
				If Me._cmnuDeleteKH IsNot Nothing Then
					AddHandler Me._cmnuDeleteKH.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnUp() As Button
			Get
				Return Me._btnUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnUp_Click
				If Me._btnUp IsNot Nothing Then
					RemoveHandler Me._btnUp.Click, value2
				End If
				Me._btnUp = value
				If Me._btnUp IsNot Nothing Then
					AddHandler Me._btnUp.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property MenuItem20() As MenuItem
			Get
				Return Me._MenuItem20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem20 = value
			End Set
		End Property

		Friend Overridable Property MnuGroupCopy() As MenuItem
			Get
				Return Me._MnuGroupCopy
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuGroupCopy_Click
				If Me._MnuGroupCopy IsNot Nothing Then
					RemoveHandler Me._MnuGroupCopy.Click, value2
				End If
				Me._MnuGroupCopy = value
				If Me._MnuGroupCopy IsNot Nothing Then
					AddHandler Me._MnuGroupCopy.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem21() As MenuItem
			Get
				Return Me._MenuItem21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem21 = value
			End Set
		End Property

		Friend Overridable Property mnuGroupPast() As MenuItem
			Get
				Return Me._mnuGroupPast
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuGroupPast_Click
				If Me._mnuGroupPast IsNot Nothing Then
					RemoveHandler Me._mnuGroupPast.Click, value2
				End If
				Me._mnuGroupPast = value
				If Me._mnuGroupPast IsNot Nothing Then
					AddHandler Me._mnuGroupPast.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MnuSendFront() As MenuItem
			Get
				Return Me._MnuSendFront
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuSendFront_Click
				If Me._MnuSendFront IsNot Nothing Then
					RemoveHandler Me._MnuSendFront.Click, value2
				End If
				Me._MnuSendFront = value
				If Me._MnuSendFront IsNot Nothing Then
					AddHandler Me._MnuSendFront.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnDown() As Button
			Get
				Return Me._btnDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDown_Click
				If Me._btnDown IsNot Nothing Then
					RemoveHandler Me._btnDown.Click, value2
				End If
				Me._btnDown = value
				If Me._btnDown IsNot Nothing Then
					AddHandler Me._btnDown.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DBiCombo1() As DBiCombo
			Get
				Return Me._DBiCombo1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DBiCombo)
				Dim obj As DBiCombo.DaChonEventHandler = AddressOf Me.DBiCombo1_DaChon1
				If Me._DBiCombo1 IsNot Nothing Then
					RemoveHandler Me._DBiCombo1.DaChon, obj
				End If
				Me._DBiCombo1 = value
				If Me._DBiCombo1 IsNot Nothing Then
					AddHandler Me._DBiCombo1.DaChon, obj
				End If
			End Set
		End Property

		Friend Overridable Property myThumbNails() As CThumbNails
			Get
				Return Me._myThumbNails
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CThumbNails)
				Dim obj As CThumbNails.ChonEventHandler = AddressOf Me.myThumbNails_Chon
				Dim obj2 As CThumbNails.SelectedIndexChangedEventHandler = AddressOf Me.myThumbNails_SelectedIndexChanged
				If Me._myThumbNails IsNot Nothing Then
					RemoveHandler Me._myThumbNails.Chon, obj
					RemoveHandler Me._myThumbNails.SelectedIndexChanged, obj2
				End If
				Me._myThumbNails = value
				If Me._myThumbNails IsNot Nothing Then
					AddHandler Me._myThumbNails.Chon, obj
					AddHandler Me._myThumbNails.SelectedIndexChanged, obj2
				End If
			End Set
		End Property

		Public ReadOnly Property OdrawingObjects() As CGraphicObjs
			Get
				Return Me.m_OdrawingObjects
			End Get
		End Property

		Public Property SelectedObject() As GraphicObject
			Get
				Return Me.m_SelectedObject
			End Get
			Set(value As GraphicObject)
				If value IsNot Me.m_SelectedObject AndAlso (Me.m_drawingObjects.Contains(value) OrElse value Is Nothing) Then
					Me.m_SelectedObject = value
					If value Is Nothing Then
					End If
					Me.Invalidate()
				End If
			End Set
		End Property

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(dlgCacKyHieu))
			Me.cmnuThumbNail = New ContextMenu()
			Me.cmnuKichThuoc = New MenuItem()
			Me.ImageList1 = New ImageList(Me.components)
			Me.ContextMenu1 = New ContextMenu()
			Me.MnXoaNode = New MenuItem()
			Me.MenuItem2 = New MenuItem()
			Me.MnuAddNode = New MenuItem()
			Me.MenuItem3 = New MenuItem()
			Me.MnuChangeNodeType = New MenuItem()
			Me.MenuItem13 = New MenuItem()
			Me.mnu1stNode = New MenuItem()
			Me.ContextMenu2 = New ContextMenu()
			Me.MnuMoveShape = New MenuItem()
			Me.MenuItem9 = New MenuItem()
			Me.MnuScaleShape = New MenuItem()
			Me.MenuItem5 = New MenuItem()
			Me.MnuRotateShape = New MenuItem()
			Me.MenuItem11 = New MenuItem()
			Me.mnuFlip = New MenuItem()
			Me.MenuItem7 = New MenuItem()
			Me.MnuSplitShape = New MenuItem()
			Me.MenuItem17 = New MenuItem()
			Me.MnuDeleteShape = New MenuItem()
			Me.MenuItem6 = New MenuItem()
			Me.MnuChangeColor = New MenuItem()
			Me.MenuItem8 = New MenuItem()
			Me.MnuNodesEdit = New MenuItem()
			Me.MenuItem1 = New MenuItem()
			Me.MnuSendBack = New MenuItem()
			Me.MnuSendFront = New MenuItem()
			Me.MenuItem4 = New MenuItem()
			Me.MnuCopyShape = New MenuItem()
			Me.MenuItem10 = New MenuItem()
			Me.mnuClosedCurveToCurve = New MenuItem()
			Me.MenuItem12 = New MenuItem()
			Me.mnuCurveToClosedCurve = New MenuItem()
			Me.MnuGroup = New ContextMenu()
			Me.MnuGroupMove = New MenuItem()
			Me.MenuItem14 = New MenuItem()
			Me.MnuGroupScale = New MenuItem()
			Me.MenuItem20 = New MenuItem()
			Me.MnuGroupCopy = New MenuItem()
			Me.mnuGroupAll = New ContextMenu()
			Me.mnuGroupAllMove = New MenuItem()
			Me.MenuItem16 = New MenuItem()
			Me.mnuGroupAllScale = New MenuItem()
			Me.MenuItem15 = New MenuItem()
			Me.mnuGroupAllPast = New MenuItem()
			Me.MenuItem21 = New MenuItem()
			Me.mnuGroupPast = New MenuItem()
			Me.Panel1 = New Panel()
			Me.Panel3 = New Panel()
			Me.DBiCombo1 = New DBiCombo()
			Me.Label2 = New Label()
			Me.txtTyLe = New TextBox()
			Me.Label1 = New Label()
			Me.picThumbNails = New PictureBox()
			Me.Splitter2 = New Splitter()
			Me.Panel4 = New Panel()
			Me.btnDown = New Button()
			Me.txtKyHieu_ID = New TextBox()
			Me.btnUp = New Button()
			Me.btnDelete = New Button()
			Me.btnSave = New Button()
			Me.txtTenKH = New TextBox()
			Me.btnNew = New Button()
			Me.btnEdit = New Button()
			Me.PictureBox2 = New PictureBox()
			Me.Splitter1 = New Splitter()
			Me.ToolBar1 = New ToolBar()
			Me.ToolBarButton1 = New ToolBarButton()
			Me.ToolBarButton2 = New ToolBarButton()
			Me.ToolBarButton3 = New ToolBarButton()
			Me.ToolBarButton4 = New ToolBarButton()
			Me.ToolBarButton5 = New ToolBarButton()
			Me.ToolBarButton6 = New ToolBarButton()
			Me.ToolBarButton7 = New ToolBarButton()
			Me.ToolBarButton12 = New ToolBarButton()
			Me.ToolBarButton11 = New ToolBarButton()
			Me.ToolBarButton8 = New ToolBarButton()
			Me.ToolBarButton9 = New ToolBarButton()
			Me.ToolBarButton10 = New ToolBarButton()
			Me.StatusBar1 = New StatusBar()
			Me.StatusBarPanel4 = New StatusBarPanel()
			Me.StatusBarPanel1 = New StatusBarPanel()
			Me.StatusBarPanel2 = New StatusBarPanel()
			Me.StatusBarPanel3 = New StatusBarPanel()
			Me.Panel2 = New Panel()
			Me.VScrollBar1 = New VScrollBar()
			Me.HScrollBar1 = New HScrollBar()
			Me.PictureBox1 = New PictureBox()
			Me.cmnuKyHieu = New ContextMenu()
			Me.cmnuCopyTo = New MenuItem()
			Me.MenuItem19 = New MenuItem()
			Me.cmnuDeleteKH = New MenuItem()
			Me.Panel1.SuspendLayout()
			Me.Panel3.SuspendLayout()
			(CType(Me.picThumbNails, ISupportInitialize)).BeginInit()
			Me.Panel4.SuspendLayout()
			(CType(Me.PictureBox2, ISupportInitialize)).BeginInit()
			(CType(Me.StatusBarPanel4, ISupportInitialize)).BeginInit()
			(CType(Me.StatusBarPanel1, ISupportInitialize)).BeginInit()
			(CType(Me.StatusBarPanel2, ISupportInitialize)).BeginInit()
			(CType(Me.StatusBarPanel3, ISupportInitialize)).BeginInit()
			Me.Panel2.SuspendLayout()
			(CType(Me.PictureBox1, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.cmnuThumbNail.MenuItems.AddRange(New MenuItem() { Me.cmnuKichThuoc })
			Me.cmnuKichThuoc.Index = 0
			Me.cmnuKichThuoc.Text = "Kich thuoc"
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), ImageListStreamer)
			Me.ImageList1.TransparentColor = Color.Silver
			Me.ImageList1.Images.SetKeyName(0, "")
			Me.ImageList1.Images.SetKeyName(1, "")
			Me.ImageList1.Images.SetKeyName(2, "")
			Me.ImageList1.Images.SetKeyName(3, "")
			Me.ImageList1.Images.SetKeyName(4, "")
			Me.ImageList1.Images.SetKeyName(5, "")
			Me.ImageList1.Images.SetKeyName(6, "")
			Me.ImageList1.Images.SetKeyName(7, "")
			Me.ImageList1.Images.SetKeyName(8, "")
			Me.ImageList1.Images.SetKeyName(9, "")
			Me.ImageList1.Images.SetKeyName(10, "")
			Me.ImageList1.Images.SetKeyName(11, "image.JPG")
			Me.ImageList1.Images.SetKeyName(12, "Rectangle.bmp")
			Me.ContextMenu1.MenuItems.AddRange(New MenuItem() { Me.MnXoaNode, Me.MenuItem2, Me.MnuAddNode, Me.MenuItem3, Me.MnuChangeNodeType, Me.MenuItem13, Me.mnu1stNode })
			Me.MnXoaNode.Index = 0
			Me.MnXoaNode.Text = "Delete Node"
			Me.MenuItem2.Index = 1
			Me.MenuItem2.Text = "-"
			Me.MnuAddNode.Index = 2
			Me.MnuAddNode.Text = "Add Node"
			Me.MenuItem3.Index = 3
			Me.MenuItem3.Text = "-"
			Me.MnuChangeNodeType.Index = 4
			Me.MnuChangeNodeType.Text = "Change Node Type"
			Me.MenuItem13.Index = 5
			Me.MenuItem13.Text = "-"
			Me.mnu1stNode.Index = 6
			Me.mnu1stNode.Text = "1st Node"
			Me.ContextMenu2.MenuItems.AddRange(New MenuItem() { Me.MnuMoveShape, Me.MenuItem9, Me.MnuScaleShape, Me.MenuItem5, Me.MnuRotateShape, Me.MenuItem11, Me.mnuFlip, Me.MenuItem7, Me.MnuSplitShape, Me.MenuItem17, Me.MnuDeleteShape, Me.MenuItem6, Me.MnuChangeColor, Me.MenuItem8, Me.MnuNodesEdit, Me.MenuItem1, Me.MnuSendBack, Me.MnuSendFront, Me.MenuItem4, Me.MnuCopyShape, Me.MenuItem10, Me.mnuClosedCurveToCurve, Me.MenuItem12, Me.mnuCurveToClosedCurve })
			Me.MnuMoveShape.Index = 0
			Me.MnuMoveShape.Text = "Move"
			Me.MenuItem9.Index = 1
			Me.MenuItem9.Text = "-"
			Me.MnuScaleShape.Index = 2
			Me.MnuScaleShape.Text = "Scale"
			Me.MenuItem5.Index = 3
			Me.MenuItem5.Text = "-"
			Me.MnuRotateShape.Index = 4
			Me.MnuRotateShape.Text = "Rotate"
			Me.MenuItem11.Index = 5
			Me.MenuItem11.Text = "-"
			Me.mnuFlip.Index = 6
			Me.mnuFlip.Text = "Flip"
			Me.MenuItem7.Index = 7
			Me.MenuItem7.Text = "-"
			Me.MnuSplitShape.Index = 8
			Me.MnuSplitShape.Text = "Split"
			Me.MenuItem17.Index = 9
			Me.MenuItem17.Text = "-"
			Me.MnuDeleteShape.Index = 10
			Me.MnuDeleteShape.Text = "Delete"
			Me.MenuItem6.Index = 11
			Me.MenuItem6.Text = "-"
			Me.MnuChangeColor.Index = 12
			Me.MnuChangeColor.Text = "Change"
			Me.MenuItem8.Index = 13
			Me.MenuItem8.Text = "-"
			Me.MnuNodesEdit.Index = 14
			Me.MnuNodesEdit.Text = "Nodes Edit"
			Me.MenuItem1.Index = 15
			Me.MenuItem1.Text = "-"
			Me.MnuSendBack.Index = 16
			Me.MnuSendBack.Text = "Send back"
			Me.MnuSendFront.Index = 17
			Me.MnuSendFront.Text = "Send front"
			Me.MenuItem4.Index = 18
			Me.MenuItem4.Text = "-"
			Me.MnuCopyShape.Index = 19
			Me.MnuCopyShape.Text = "Copy"
			Me.MenuItem10.Index = 20
			Me.MenuItem10.Text = "-"
			Me.mnuClosedCurveToCurve.Index = 21
			Me.mnuClosedCurveToCurve.Text = "ClosedCurve to Curve"
			Me.MenuItem12.Index = 22
			Me.MenuItem12.Text = "-"
			Me.mnuCurveToClosedCurve.Index = 23
			Me.mnuCurveToClosedCurve.Text = "Curve to ClosedCurve"
			Me.MnuGroup.MenuItems.AddRange(New MenuItem() { Me.MnuGroupMove, Me.MenuItem14, Me.MnuGroupScale, Me.MenuItem20, Me.MnuGroupCopy })
			Me.MnuGroupMove.Index = 0
			Me.MnuGroupMove.Text = "Group Move"
			Me.MenuItem14.Index = 1
			Me.MenuItem14.Text = "-"
			Me.MnuGroupScale.Index = 2
			Me.MnuGroupScale.Text = "Group Scale"
			Me.MenuItem20.Index = 3
			Me.MenuItem20.Text = "-"
			Me.MnuGroupCopy.Index = 4
			Me.MnuGroupCopy.Text = "Group Copy"
			Me.mnuGroupAll.MenuItems.AddRange(New MenuItem() { Me.mnuGroupAllMove, Me.MenuItem16, Me.mnuGroupAllScale, Me.MenuItem15, Me.mnuGroupAllPast, Me.MenuItem21, Me.mnuGroupPast })
			Me.mnuGroupAllMove.Index = 0
			Me.mnuGroupAllMove.Text = "Move All"
			Me.MenuItem16.Index = 1
			Me.MenuItem16.Text = "-"
			Me.mnuGroupAllScale.Index = 2
			Me.mnuGroupAllScale.Text = "Scale All"
			Me.MenuItem15.Index = 3
			Me.MenuItem15.Text = "-"
			Me.mnuGroupAllPast.Index = 4
			Me.mnuGroupAllPast.Text = "Past from Map"
			Me.MenuItem21.Index = 5
			Me.MenuItem21.Text = "-"
			Me.mnuGroupPast.Index = 6
			Me.mnuGroupPast.Text = "Past form copy group"
			Me.Panel1.Controls.Add(Me.Panel3)
			Me.Panel1.Controls.Add(Me.Splitter2)
			Me.Panel1.Controls.Add(Me.Panel4)
			Me.Panel1.Dock = DockStyle.Left
			Dim arg_D54_0 As Control = Me.Panel1
			Dim location As Point = New Point(0, 0)
			arg_D54_0.Location = location
			Me.Panel1.Name = "Panel1"
			Dim arg_D82_0 As Control = Me.Panel1
			Dim size As Size = New Size(239, 462)
			arg_D82_0.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel3.BorderStyle = BorderStyle.Fixed3D
			Me.Panel3.Controls.Add(Me.DBiCombo1)
			Me.Panel3.Controls.Add(Me.Label2)
			Me.Panel3.Controls.Add(Me.txtTyLe)
			Me.Panel3.Controls.Add(Me.Label1)
			Me.Panel3.Controls.Add(Me.picThumbNails)
			Me.Panel3.Dock = DockStyle.Fill
			Dim arg_E2A_0 As Control = Me.Panel3
			location = New Point(0, 0)
			arg_E2A_0.Location = location
			Me.Panel3.Name = "Panel3"
			Dim arg_E58_0 As Control = Me.Panel3
			size = New Size(239, 307)
			arg_E58_0.Size = size
			Me.Panel3.TabIndex = 4
			Me.DBiCombo1.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.DBiCombo1.ConnStr = ""
			Me.DBiCombo1.CuoiFieldName = "Cuoi"
			Me.DBiCombo1.DMIDFieldName = ""
			Me.DBiCombo1.DMIDValue = 0
			Me.DBiCombo1.FilterFieldName = ""
			Me.DBiCombo1.FilterValue = 0
			Me.DBiCombo1.IDFieldName = "LoaiKH_ID"
			Me.DBiCombo1.IDValue = 0L
			Dim arg_EFD_0 As Control = Me.DBiCombo1
			location = New Point(8, 9)
			arg_EFD_0.Location = location
			Me.DBiCombo1.MaFieldName = "MaLoaiKH"
			Me.DBiCombo1.MnuChonText = ""
			Me.DBiCombo1.MucLen = 2
			Me.DBiCombo1.Name = "DBiCombo1"
			Me.DBiCombo1.Password = ""
			Dim arg_F64_0 As Control = Me.DBiCombo1
			size = New Size(219, 24)
			arg_F64_0.Size = size
			Me.DBiCombo1.TabIndex = 23
			Me.DBiCombo1.TableName = "tblLoaiKH"
			Me.DBiCombo1.TenFieldName = "TenLoaiKH"
			Me.DBiCombo1.TextValue = ""
			Me.DBiCombo1.TreeLinesNo = 10
			Me.DBiCombo1.TreeWidthScale = 1.5F
			Me.DBiCombo1.UserID = ""
			Me.Label2.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Dim arg_1001_0 As Control = Me.Label2
			location = New Point(10, 281)
			arg_1001_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_1029_0 As Control = Me.Label2
			size = New Size(38, 13)
			arg_1029_0.Size = size
			Me.Label2.TabIndex = 22
			Me.Label2.Text = "Label2"
			Me.txtTyLe.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Dim arg_1071_0 As Control = Me.txtTyLe
			location = New Point(195, 278)
			arg_1071_0.Location = location
			Me.txtTyLe.Name = "txtTyLe"
			Dim arg_1099_0 As Control = Me.txtTyLe
			size = New Size(32, 21)
			arg_1099_0.Size = size
			Me.txtTyLe.TabIndex = 20
			Me.txtTyLe.Text = "1"
			Me.Label1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Label1.AutoSize = True
			Dim arg_10EA_0 As Control = Me.Label1
			location = New Point(84, 281)
			arg_10EA_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_1112_0 As Control = Me.Label1
			size = New Size(105, 13)
			arg_1112_0.Size = size
			Me.Label1.TabIndex = 19
			Me.Label1.Text = "T" & ChrW(7927) & " l" & ChrW(7879) & " khi l" & ChrW(7845) & "y vào B" & ChrW(272) & ":"
			Me.Label1.TextAlign = ContentAlignment.MiddleRight
			Me.picThumbNails.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.picThumbNails.BackColor = SystemColors.Window
			Me.picThumbNails.BorderStyle = BorderStyle.Fixed3D
			Dim arg_117C_0 As Control = Me.picThumbNails
			location = New Point(8, 40)
			arg_117C_0.Location = location
			Me.picThumbNails.Name = "picThumbNails"
			Dim arg_11AA_0 As Control = Me.picThumbNails
			size = New Size(219, 232)
			arg_11AA_0.Size = size
			Me.picThumbNails.TabIndex = 0
			Me.picThumbNails.TabStop = False
			Me.Splitter2.Dock = DockStyle.Bottom
			Dim arg_11E8_0 As Control = Me.Splitter2
			location = New Point(0, 307)
			arg_11E8_0.Location = location
			Me.Splitter2.Name = "Splitter2"
			Dim arg_1212_0 As Control = Me.Splitter2
			size = New Size(239, 3)
			arg_1212_0.Size = size
			Me.Splitter2.TabIndex = 3
			Me.Splitter2.TabStop = False
			Me.Panel4.BorderStyle = BorderStyle.Fixed3D
			Me.Panel4.Controls.Add(Me.btnDown)
			Me.Panel4.Controls.Add(Me.txtKyHieu_ID)
			Me.Panel4.Controls.Add(Me.btnUp)
			Me.Panel4.Controls.Add(Me.btnDelete)
			Me.Panel4.Controls.Add(Me.btnSave)
			Me.Panel4.Controls.Add(Me.txtTenKH)
			Me.Panel4.Controls.Add(Me.btnNew)
			Me.Panel4.Controls.Add(Me.btnEdit)
			Me.Panel4.Controls.Add(Me.PictureBox2)
			Me.Panel4.Dock = DockStyle.Bottom
			Dim arg_1322_0 As Control = Me.Panel4
			location = New Point(0, 310)
			arg_1322_0.Location = location
			Me.Panel4.Name = "Panel4"
			Dim arg_1350_0 As Control = Me.Panel4
			size = New Size(239, 152)
			arg_1350_0.Size = size
			Me.Panel4.TabIndex = 2
			Me.btnDown.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.btnDown.Image = Resources.FillDown
			Dim arg_1393_0 As Control = Me.btnDown
			location = New Point(206, 4)
			arg_1393_0.Location = location
			Me.btnDown.Name = "btnDown"
			Dim arg_13BB_0 As Control = Me.btnDown
			size = New Size(25, 23)
			arg_13BB_0.Size = size
			Me.btnDown.TabIndex = 35
			Me.btnDown.UseVisualStyleBackColor = True
			Dim arg_13EF_0 As Control = Me.txtKyHieu_ID
			location = New Point(187, 105)
			arg_13EF_0.Location = location
			Me.txtKyHieu_ID.Name = "txtKyHieu_ID"
			Dim arg_1417_0 As Control = Me.txtKyHieu_ID
			size = New Size(40, 21)
			arg_1417_0.Size = size
			Me.txtKyHieu_ID.TabIndex = 34
			Me.txtKyHieu_ID.Text = "44"
			Me.txtKyHieu_ID.Visible = False
			Me.btnUp.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.btnUp.Image = Resources.FillUp
			Dim arg_1477_0 As Control = Me.btnUp
			location = New Point(183, 4)
			arg_1477_0.Location = location
			Me.btnUp.Name = "btnUp"
			Dim arg_149F_0 As Control = Me.btnUp
			size = New Size(23, 23)
			arg_149F_0.Size = size
			Me.btnUp.TabIndex = 21
			Me.btnUp.UseVisualStyleBackColor = True
			Dim arg_14CF_0 As Control = Me.btnDelete
			location = New Point(120, 4)
			arg_14CF_0.Location = location
			Me.btnDelete.Name = "btnDelete"
			Dim arg_14F7_0 As Control = Me.btnDelete
			size = New Size(48, 24)
			arg_14F7_0.Size = size
			Me.btnDelete.TabIndex = 23
			Me.btnDelete.Text = "Del"
			Dim arg_152B_0 As Control = Me.btnSave
			location = New Point(56, 4)
			arg_152B_0.Location = location
			Me.btnSave.Name = "btnSave"
			Dim arg_1553_0 As Control = Me.btnSave
			size = New Size(56, 24)
			arg_1553_0.Size = size
			Me.btnSave.TabIndex = 22
			Me.btnSave.Text = "Update"
			Me.txtTenKH.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.txtTenKH.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_15B1_0 As Control = Me.txtTenKH
			location = New Point(6, 36)
			arg_15B1_0.Location = location
			Me.txtTenKH.Name = "txtTenKH"
			Dim arg_15DC_0 As Control = Me.txtTenKH
			size = New Size(223, 21)
			arg_15DC_0.Size = size
			Me.txtTenKH.TabIndex = 17
			Dim arg_15FF_0 As Control = Me.btnNew
			location = New Point(8, 4)
			arg_15FF_0.Location = location
			Me.btnNew.Name = "btnNew"
			Dim arg_1627_0 As Control = Me.btnNew
			size = New Size(40, 24)
			arg_1627_0.Size = size
			Me.btnNew.TabIndex = 21
			Me.btnNew.Text = "New"
			Me.btnEdit.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_166C_0 As Control = Me.btnEdit
			location = New Point(183, 72)
			arg_166C_0.Location = location
			Me.btnEdit.Name = "btnEdit"
			Dim arg_1694_0 As Control = Me.btnEdit
			size = New Size(48, 24)
			arg_1694_0.Size = size
			Me.btnEdit.TabIndex = 20
			Me.btnEdit.Text = "Edit"
			Me.PictureBox2.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.PictureBox2.BackColor = SystemColors.Window
			Me.PictureBox2.BorderStyle = BorderStyle.Fixed3D
			Dim arg_16F1_0 As Control = Me.PictureBox2
			location = New Point(8, 68)
			arg_16F1_0.Location = location
			Me.PictureBox2.Name = "PictureBox2"
			Dim arg_171C_0 As Control = Me.PictureBox2
			size = New Size(167, 73)
			arg_171C_0.Size = size
			Me.PictureBox2.TabIndex = 18
			Me.PictureBox2.TabStop = False
			Dim arg_174F_0 As Control = Me.Splitter1
			location = New Point(239, 0)
			arg_174F_0.Location = location
			Me.Splitter1.Name = "Splitter1"
			Dim arg_1779_0 As Control = Me.Splitter1
			size = New Size(4, 462)
			arg_1779_0.Size = size
			Me.Splitter1.TabIndex = 2
			Me.Splitter1.TabStop = False
			Me.ToolBar1.Buttons.AddRange(New ToolBarButton() { Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton12, Me.ToolBarButton11, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton10 })
			Me.ToolBar1.DropDownArrows = True
			Me.ToolBar1.ImageList = Me.ImageList1
			Dim arg_185E_0 As Control = Me.ToolBar1
			location = New Point(243, 0)
			arg_185E_0.Location = location
			Me.ToolBar1.Name = "ToolBar1"
			Me.ToolBar1.ShowToolTips = True
			Dim arg_1895_0 As Control = Me.ToolBar1
			size = New Size(506, 28)
			arg_1895_0.Size = size
			Me.ToolBar1.TabIndex = 3
			Me.ToolBarButton1.ImageIndex = 0
			Me.ToolBarButton1.Name = "ToolBarButton1"
			Me.ToolBarButton1.Tag = "Line"
			Me.ToolBarButton1.ToolTipText = "Line"
			Me.ToolBarButton2.ImageIndex = 1
			Me.ToolBarButton2.Name = "ToolBarButton2"
			Me.ToolBarButton2.Tag = "Polygon"
			Me.ToolBarButton2.ToolTipText = "Polygon"
			Me.ToolBarButton3.ImageIndex = 2
			Me.ToolBarButton3.Name = "ToolBarButton3"
			Me.ToolBarButton3.Tag = "Curve"
			Me.ToolBarButton3.ToolTipText = "Curve"
			Me.ToolBarButton4.ImageIndex = 3
			Me.ToolBarButton4.Name = "ToolBarButton4"
			Me.ToolBarButton4.Tag = "ClosedCurve"
			Me.ToolBarButton4.ToolTipText = "ClosedCurve"
			Me.ToolBarButton5.ImageIndex = 4
			Me.ToolBarButton5.Name = "ToolBarButton5"
			Me.ToolBarButton5.Tag = "Ellipse"
			Me.ToolBarButton5.ToolTipText = "Ellipse"
			Me.ToolBarButton6.ImageIndex = 5
			Me.ToolBarButton6.Name = "ToolBarButton6"
			Me.ToolBarButton6.Tag = "Pie"
			Me.ToolBarButton6.ToolTipText = "Pie"
			Me.ToolBarButton7.ImageIndex = 6
			Me.ToolBarButton7.Name = "ToolBarButton7"
			Me.ToolBarButton7.Tag = "Text"
			Me.ToolBarButton7.ToolTipText = "Text"
			Me.ToolBarButton12.ImageIndex = 11
			Me.ToolBarButton12.Name = "ToolBarButton12"
			Me.ToolBarButton12.Tag = "Image"
			Me.ToolBarButton12.ToolTipText = "Image"
			Me.ToolBarButton11.ImageIndex = 10
			Me.ToolBarButton11.Name = "ToolBarButton11"
			Me.ToolBarButton11.Tag = "Root"
			Me.ToolBarButton11.ToolTipText = "Change Root"
			Me.ToolBarButton8.ImageIndex = 7
			Me.ToolBarButton8.Name = "ToolBarButton8"
			Me.ToolBarButton8.Tag = "Edit"
			Me.ToolBarButton8.ToolTipText = "Nodes Edit"
			Me.ToolBarButton9.ImageIndex = 8
			Me.ToolBarButton9.Name = "ToolBarButton9"
			Me.ToolBarButton9.Tag = "Past"
			Me.ToolBarButton9.ToolTipText = "Past"
			Me.ToolBarButton10.ImageIndex = 9
			Me.ToolBarButton10.Name = "ToolBarButton10"
			Me.ToolBarButton10.Tag = "Option"
			Me.ToolBarButton10.ToolTipText = "Option"
			Dim arg_1B92_0 As Control = Me.StatusBar1
			location = New Point(243, 440)
			arg_1B92_0.Location = location
			Me.StatusBar1.Name = "StatusBar1"
			Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel4, Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3 })
			Me.StatusBar1.ShowPanels = True
			Dim arg_1C0B_0 As Control = Me.StatusBar1
			size = New Size(506, 22)
			arg_1C0B_0.Size = size
			Me.StatusBar1.TabIndex = 5
			Me.StatusBar1.Text = "StatusBar1"
			Me.StatusBarPanel4.AutoSize = StatusBarPanelAutoSize.Contents
			Me.StatusBarPanel4.Name = "StatusBarPanel4"
			Me.StatusBarPanel4.Width = 10
			Me.StatusBarPanel1.AutoSize = StatusBarPanelAutoSize.Contents
			Me.StatusBarPanel1.Name = "StatusBarPanel1"
			Me.StatusBarPanel1.Width = 10
			Me.StatusBarPanel2.AutoSize = StatusBarPanelAutoSize.Contents
			Me.StatusBarPanel2.Name = "StatusBarPanel2"
			Me.StatusBarPanel2.Width = 10
			Me.StatusBarPanel3.AutoSize = StatusBarPanelAutoSize.Contents
			Me.StatusBarPanel3.Name = "StatusBarPanel3"
			Me.StatusBarPanel3.Width = 10
			Me.Panel2.BorderStyle = BorderStyle.Fixed3D
			Me.Panel2.Controls.Add(Me.VScrollBar1)
			Me.Panel2.Controls.Add(Me.HScrollBar1)
			Me.Panel2.Controls.Add(Me.PictureBox1)
			Me.Panel2.Dock = DockStyle.Fill
			Dim arg_1D40_0 As Control = Me.Panel2
			location = New Point(243, 28)
			arg_1D40_0.Location = location
			Me.Panel2.Name = "Panel2"
			Dim arg_1D6E_0 As Control = Me.Panel2
			size = New Size(506, 412)
			arg_1D6E_0.Size = size
			Me.Panel2.TabIndex = 12
			Me.VScrollBar1.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_1DA2_0 As Control = Me.VScrollBar1
			location = New Point(485, 0)
			arg_1DA2_0.Location = location
			Me.VScrollBar1.Name = "VScrollBar1"
			Dim arg_1DCD_0 As Control = Me.VScrollBar1
			size = New Size(17, 271)
			arg_1DCD_0.Size = size
			Me.VScrollBar1.TabIndex = 2
			Me.HScrollBar1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_1DFF_0 As Control = Me.HScrollBar1
			location = New Point(0, 391)
			arg_1DFF_0.Location = location
			Me.HScrollBar1.Name = "HScrollBar1"
			Dim arg_1E2A_0 As Control = Me.HScrollBar1
			size = New Size(344, 17)
			arg_1E2A_0.Size = size
			Me.HScrollBar1.TabIndex = 1
			Me.PictureBox1.Anchor = AnchorStyles.None
			Me.PictureBox1.BackColor = SystemColors.Window
			Dim arg_1E6A_0 As Control = Me.PictureBox1
			location = New Point(40, 21)
			arg_1E6A_0.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_1E98_0 As Control = Me.PictureBox1
			size = New Size(296, 280)
			arg_1E98_0.Size = size
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.cmnuKyHieu.MenuItems.AddRange(New MenuItem() { Me.cmnuCopyTo, Me.MenuItem19, Me.cmnuDeleteKH })
			Me.cmnuCopyTo.Index = 0
			Me.cmnuCopyTo.Text = "Copy sang nhóm..."
			Me.MenuItem19.Index = 1
			Me.MenuItem19.Text = "-"
			Me.cmnuDeleteKH.Index = 2
			Me.cmnuDeleteKH.Text = "Xóa ký hi" & ChrW(7879) & "u"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(749, 462)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.StatusBar1)
			Me.Controls.Add(Me.ToolBar1)
			Me.Controls.Add(Me.Splitter1)
			Me.Controls.Add(Me.Panel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCacKyHieu"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Các Ký hi" & ChrW(7879) & "u"
			Me.Panel1.ResumeLayout(False)
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			(CType(Me.picThumbNails, ISupportInitialize)).EndInit()
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			(CType(Me.PictureBox2, ISupportInitialize)).EndInit()
			(CType(Me.StatusBarPanel4, ISupportInitialize)).EndInit()
			(CType(Me.StatusBarPanel1, ISupportInitialize)).EndInit()
			(CType(Me.StatusBarPanel2, ISupportInitialize)).EndInit()
			(CType(Me.StatusBarPanel3, ISupportInitialize)).EndInit()
			Me.Panel2.ResumeLayout(False)
			(CType(Me.PictureBox1, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub dlgCacKyHieu_FormClosing(sender As Object, e As FormClosingEventArgs)
			modBdTC.myTyLeKH2Map = 1F
			Try
				modBdTC.myTyLeKH2Map = Conversions.ToSingle(Me.txtTyLe.Text)
			Catch expr_21 As Exception
				ProjectData.SetProjectError(expr_21)
				ProjectData.ClearProjectError()
			End Try
			Me.myThumbNails = Nothing
			modBdTC.fCacKyHieu = Nothing
			myModule.fMain.myBando.NhanKHXong()
		End Sub

		Private Sub dlgCacKyHieu_Load(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Me.Location = myModule.fMain.Location
				Me.Height = myModule.fMain.Height - 20
				Me.Panel1.Width = modBdTC.defaImageWidth * 3 + modBdTC.defaHorizontalSpacing * 10
				Me.HScrollBar1.Visible = False
				Me.VScrollBar1.Visible = False
				Me.StatusBar1.Visible = False
				Me.ToolBar1.Visible = False
				Me.PictureBox1.Visible = False
				Me.Splitter1.Visible = False
				Me.Panel2.Visible = False
				Me.Width = Me.Panel2.Left
				Me.Panel1.Dock = DockStyle.Fill
				Me.picThumbNails.Left = 0
				Me.picThumbNails.Width = Me.Panel3.Width
				Me.Panel4.Height = 0
				Directory.SetCurrentDirectory(modSaBan.myCurrentDirectory)
				Me.myKHConnStr = modBdTC.myKHCnnString
				Me.myThumbNails = New CThumbNails(Me.picThumbNails)
				Me.btnEdit.Enabled = False
				Me.EditNodesCount = 0
				Me.EditNodes = New dlgCacKyHieu.EDITNODE(Me.EditNodesCount - 1 + 1 - 1) {}
				Me.iEditNode = 0
				Dim dBiCombo As DBiCombo = Me.DBiCombo1
				dBiCombo.ConnStr = Me.myKHConnStr
				dBiCombo.UserID = "Admin"
				dBiCombo.Password = ""
				dBiCombo.TableName = "tblLoaiKH"
				dBiCombo.MaFieldName = "MaLoaiKH"
				dBiCombo.TenFieldName = "TenLoaiKH"
				dBiCombo.CuoiFieldName = "Cuoi"
				dBiCombo.IDFieldName = "LoaiKH_ID"
				dBiCombo.KhoiDong(modBdTC.myLoaiKH_ID)
				If Me.m_drawingObjects.Count > 0 Then
					Me.EditFromMap()
				End If
				Me.PopulateList(CInt(modBdTC.myLoaiKH_ID))
				Me.PopulateForm()
				Me.txtTyLe.Text = Conversions.ToString(modBdTC.myTyLeKH2Map)
				modBdTC.fCacKyHieu = Me
				Me.bLoadXong = True
			Catch arg_1E9_0 As Exception
				ProjectData.SetProjectError(arg_1E9_0)
				Me.Close()
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.btnEdit.Text, "Edit", False) = 0 Then
				Me.OnEdit()
			Else
				Me.OnUnEdit()
			End If
		End Sub

		Private Sub OnUnEdit()
			Me.HScrollBar1.Visible = False
			Me.VScrollBar1.Visible = False
			Me.StatusBar1.Visible = False
			Me.ToolBar1.Visible = False
			Me.PictureBox1.Visible = False
			Me.Splitter1.Visible = False
			Me.Panel2.Visible = False
			Me.Width = Me.Panel2.Left
			Me.Panel1.Dock = DockStyle.Fill
			Me.btnNew.Enabled = True
			Me.DBiCombo1.Enabled = True
			Me.picThumbNails.Enabled = True
			Me.btnDelete.Enabled = True
			Me.btnSave.Enabled = True
			Me.btnEdit.Text = "Edit"
		End Sub

		Private Sub OnEdit()
			' The following expression was wrapped in a checked-statement
			Me.Width = Me.Panel2.Left + Me.Panel2.Width
			Me.Panel1.Dock = DockStyle.Left
			Me.Panel2.Visible = True
			Me.Splitter1.Visible = True
			Me.ToolBar1.Visible = True
			Me.StatusBar1.Visible = True
			Me.HScrollBar1.Visible = True
			Me.VScrollBar1.Visible = True
			Me.m_SelectedObject = Nothing
			Dim size As Size = Me.m_drawingObjects.GetSize()
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				Me.myWidth = 50
				Me.myHeight = 50
			Else
				Me.myWidth = size.Width
				Me.myHeight = size.Height
			End If
			Me.ThayDoiGrid()
			Me.pointTL = New Point(0, 0)
			Me.PictureBox1.Location = Me.pointTL
			Dim arg_110_0 As Control = Me.PictureBox1
			Dim size2 As Size = New Size(Me.myWidth * Me.myScale, Me.myHeight * Me.myScale)
			arg_110_0.Size = size2
			Me.PictureBox1.Visible = True
			Me.btnNew.Enabled = False
			Me.btnDelete.Enabled = False
			Me.btnSave.Enabled = False
			Me.DBiCombo1.Enabled = False
			Me.picThumbNails.Enabled = False
			Me.DisplayScrollBars()
			Me.btnEdit.Enabled = True
			Me.btnEdit.Text = "UnEdit"
			Me.OnCapNhatCT()
		End Sub

		Friend Sub OnCapNhatCT()
			Me.m_DrawTool = dlgCacKyHieu.VeTools.None
			Me.UpdateTB("")
			Me.StatusBarPanel1.Text = "Ch" & ChrW(7885) & "n"
			Me.StatusBarPanel2.Text = "RightClick " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n Menu. (" & ChrW(7845) & "n Shift và kéo chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n nhi" & ChrW(7873) & "u chi ti" & ChrW(7871) & "t)"
			Me.PictureBox1.Invalidate()
			Me.PictureBox2.Invalidate()
		End Sub

		Private Sub PopulateForm()
			If Me.myThumbNails.SelectedIndex > -1 Then
				Dim cThumbNail As CThumbNail = Me.myThumbNails(Me.myThumbNails.SelectedIndex)
				Me.txtTenKH.Text = cThumbNail.Value
				Me.txtKyHieu_ID.Text = Conversions.ToString(cThumbNail.ID)
				Dim symbols As String = cThumbNail.Symbols
				Me.GetSize(symbols)
				Me.m_drawingObjects = CGraphicObjs.Str2Objects(symbols, 0, 0, modBdTC.cDecSepa, modBdTC.cGrpSepa)
				Me.PictureBox2.Invalidate()
				Me.btnDelete.Enabled = True
				Me.btnNew.Enabled = True
				Me.btnEdit.Enabled = True
				Me.Mode = "Update"
			Else
				Me.m_drawingObjects = CGraphicObjs.Str2Objects("", 0, 0, modBdTC.cDecSepa, modBdTC.cGrpSepa)
				Me.PictureBox2.Invalidate()
				Me.btnDelete.Enabled = False
				Me.btnNew.Enabled = True
				Me.btnEdit.Enabled = False
				Me.btnSave.Enabled = False
				Me.Mode = "None"
			End If
			' The following expression was wrapped in a checked-expression
			Me.Label2.Text = (Me.myThumbNails.SelectedIndex + 1).ToString() + " / " + Me.myThumbNails.GetCount().ToString()
		End Sub

		Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs)
			Me.OnCapNhatCT()
		End Sub

		Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
			Dim pointF As PointF = Me.gscTogoc(e.X, e.Y)
			If Me.bSnap Then
				pointF = Me.Snap(pointF.X, pointF.Y)
			End If
			Me.StatusBarPanel4.Text = pointF.X.ToString() + ", " + pointF.Y.ToString()
			If Me.m_SelectedObject IsNot Nothing Then
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape Then
					Me.mytoPt = pointF
					Me.m_SelectedObject.Rotate(Me.myrootPt, Me.myfromPt, Me.mytoPt)
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape Then
					Me.mytoPt = pointF
					Me.m_SelectedObject.Zoom(Me.myrootPt, Me.myfromPt, Me.mytoPt)
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit Then
					Me.mytoPt = pointF
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape Then
					Me.mytoPt = pointF
					Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape Then
					Me.mytoPt = pointF
					Try
						Dim enumerator As IEnumerator = Me.m_EditingObjects.GetEnumerator()
						While enumerator.MoveNext()
							Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
							graphicObject.Move(Me.myfromPt, Me.mytoPt)
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape Then
					Me.mytoPt = pointF
					Try
						Dim enumerator2 As IEnumerator = Me.m_EditingObjects.GetEnumerator()
						While enumerator2.MoveNext()
							Dim graphicObject2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
							graphicObject2.Zoom(Me.myrootPt, Me.myfromPt, Me.mytoPt)
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							(TryCast(enumerator2, IDisposable)).Dispose()
						End If
					End Try
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				End If
			Else
				' The following expression was wrapped in a checked-statement
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape Then
					Me.mytoPt = pointF
					Try
						Dim enumerator3 As IEnumerator = Me.m_EditingObjects.GetEnumerator()
						While enumerator3.MoveNext()
							Dim graphicObject3 As GraphicObject = CType(enumerator3.Current, GraphicObject)
							graphicObject3.Move(Me.myfromPt, Me.mytoPt)
						End While
					Finally
						Dim enumerator3 As IEnumerator
						If TypeOf enumerator3 Is IDisposable Then
							(TryCast(enumerator3, IDisposable)).Dispose()
						End If
					End Try
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape Then
					Me.mytoPt = pointF
					Try
						Dim enumerator4 As IEnumerator = Me.m_EditingObjects.GetEnumerator()
						While enumerator4.MoveNext()
							Dim graphicObject4 As GraphicObject = CType(enumerator4.Current, GraphicObject)
							graphicObject4.Zoom(Me.myrootPt, Me.myfromPt, Me.mytoPt)
						End While
					Finally
						Dim enumerator4 As IEnumerator
						If TypeOf enumerator4 Is IDisposable Then
							(TryCast(enumerator4, IDisposable)).Dispose()
						End If
					End Try
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.ChangeRoot AndAlso Me.RootDragging Then
					Me.myRootX = CInt(Math.Round(CDec(pointF.X)))
					If Me.myRootX < 0 Then
						Me.myRootX = 0
					End If
					If Me.myRootX > Me.myWidth Then
						Me.myRootX = Me.myWidth
					End If
					Me.myRootY = CInt(Math.Round(CDec(pointF.Y)))
					If Me.myRootY < 0 Then
						Me.myRootY = 0
					End If
					If Me.myRootY > Me.myHeight Then
						Me.myRootY = Me.myHeight
					End If
					Me.PictureBox1.Invalidate()
					Me.StatusBarPanel1.Text = "Root"
					Me.StatusBarPanel2.Text = String.Concat(New String() { "G" & ChrW(7889) & "c=(", Conversions.ToString(Me.myRootX), ",", Conversions.ToString(Me.myRootY), ") Kéo g" & ChrW(7889) & "c " & ChrW(273) & ChrW(7871) & "n v" & ChrW(7883) & " trí m" & ChrW(7899) & "i..." })
				End If
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode > -1 Then
					Me.EditObj.MoveNodeTo(Me.iEditNode, pointF)
					Me.PictureBox1.Invalidate()
				End If
				If Me.DrawingDragging Then
					' The following expression was wrapped in a unchecked-expression
					Me.DrawingRect.Width = CInt(Math.Round(CDec((pointF.X - CSng(Me.DrawingRect.X)))))
					' The following expression was wrapped in a unchecked-expression
					Me.DrawingRect.Height = CInt(Math.Round(CDec((pointF.Y - CSng(Me.DrawingRect.Y)))))
					Me.PictureBox1.Invalidate()
				End If
				If Me.DrawingPicking Then
					Dim value As Object = Me.myPts.GetUpperBound(0)
					Me.myPts(Conversions.ToInteger(value)) = pointF
					Me.PictureBox1.Invalidate()
				End If
				If Me.selectionDragging Then
					' The following expression was wrapped in a checked-expression
					Me.selectionRect.Width = CSng((e.X - Me.AutoScrollPosition.X)) - Me.selectionRect.X
					' The following expression was wrapped in a checked-expression
					Me.selectionRect.Height = CSng((e.Y - Me.AutoScrollPosition.Y)) - Me.selectionRect.Y
					Me.PictureBox1.Invalidate()
				End If
			End If
		End Sub

		Private Function Snap(px As Single, py As Single) As Point
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim result As Point = New Point(CInt(Math.Round(Math.Round(CDec((px / CSng(Me.myGridWidth))), 0) * CDec(Me.myGridWidth))), CInt(Math.Round(Math.Round(CDec((py / CSng(Me.myGridWidth))), 0) * CDec(Me.myGridWidth))))
			Return result
		End Function

		Private Sub UpdateTB(pTag As String)
			Try
				Dim enumerator As IEnumerator = Me.ToolBar1.Buttons.GetEnumerator()
				While enumerator.MoveNext()
					Dim toolBarButton As ToolBarButton = CType(enumerator.Current, ToolBarButton)
					If Operators.ConditionalCompareObjectEqual(toolBarButton.Tag, pTag, False) Then
						toolBarButton.Pushed = True
					Else
						toolBarButton.Pushed = False
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub PastObjectAt(pObj As GraphicObject, pt1 As PointF)
			If pObj IsNot Nothing Then
				Dim graphicObject As GraphicObject = pObj.Clone()
				Dim arg_20_0 As GraphicObject = graphicObject
				Dim fromPt As PointF = New PointF(graphicObject.X, graphicObject.Y)
				arg_20_0.Move(fromPt, pt1)
				Me.m_drawingObjects.Add(graphicObject)
			End If
		End Sub

		Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.PictureBox1.[Select]()
			Dim pt As PointF = Me.gscTogoc(e.X, e.Y)
			Dim pointF As PointF = Me.gscTogoc(e.X, e.Y)
			If Me.bSnap Then
				pointF = Me.Snap(pointF.X, pointF.Y)
			End If
			' The following expression was wrapped in a checked-statement
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.None
					If(Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
						Me.m_SelectedObject = Me.m_drawingObjects.FindObjectAtPoint(pt)
						If Me.m_SelectedObject IsNot Nothing Then
							Dim flag As Boolean = False
							Try
								Dim enumerator As IEnumerator = Me.m_selectedObjects.GetEnumerator()
								While enumerator.MoveNext()
									Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
									If graphicObject Is Me.m_SelectedObject Then
										flag = True
									End If
								End While
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									(TryCast(enumerator, IDisposable)).Dispose()
								End If
							End Try
							If flag Then
								Me.m_selectedObjects.Remove(Me.m_SelectedObject)
							Else
								Me.m_selectedObjects.Add(Me.m_SelectedObject)
							End If
							Me.PictureBox1.Invalidate()
						End If
					Else If Me.m_selectedObjects.Count > 0 Then
						Me.m_EditingObjects.Clear()
						Try
							Dim enumerator2 As IEnumerator = Me.m_selectedObjects.GetEnumerator()
							While enumerator2.MoveNext()
								Dim aGObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
								Me.m_EditingObjects.Add(aGObj)
							End While
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								(TryCast(enumerator2, IDisposable)).Dispose()
							End If
						End Try
						If(e.Button And MouseButtons.Right) > MouseButtons.None Then
							Dim arg_414_0 As ContextMenu = Me.MnuGroup
							Dim arg_414_1 As Control = Me.PictureBox1
							Dim autoScrollPosition As Point = New Point(e.X, e.Y)
							arg_414_0.Show(arg_414_1, autoScrollPosition)
						End If
						Me.m_selectedObjects.Clear()
					Else If(Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
						If(e.Button And MouseButtons.Left) > MouseButtons.None Then
							Me.selectionDragging = True
							Dim arg_471_0 As Single = CSng(e.X)
							Dim autoScrollPosition As Point = Me.AutoScrollPosition
							Me.selectionRect.X = arg_471_0 - CSng(autoScrollPosition.X)
							Dim arg_493_0 As Single = CSng(e.Y)
							autoScrollPosition = Me.AutoScrollPosition
							Me.selectionRect.Y = arg_493_0 - CSng(autoScrollPosition.Y)
							Me.selectionRect.Height = 0F
							Me.selectionRect.Width = 0F
						End If
					Else
						Me.m_SelectedObject = Me.m_drawingObjects.FindObjectAtPoint(pt)
						Me.m_selectedObjects.Clear()
						Me.PictureBox1.Invalidate()
						If Me.m_SelectedObject IsNot Nothing Then
							If(e.Button And MouseButtons.Left) > MouseButtons.None Then
								If(Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
									Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape
									Me.myfromPt = pointF
									Me.mytoPt = pointF
									Me.myrootPt = New PointF(100F, 100F)
									Me.myrootPt = Me.m_SelectedObject.GetCenter()
								Else If(Control.ModifierKeys And Keys.Control) = Keys.Control Then
									Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape
									Me.myfromPt = pointF
									Me.mytoPt = pointF
								Else If(Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
									Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape
									Me.myfromPt = pointF
									Me.mytoPt = pointF
									Me.myrootPt = Nothing
									Me.myrootPt = Me.m_SelectedObject.GetCenter()
								End If
							Else
								Dim arg_5FF_0 As ContextMenu = Me.ContextMenu2
								Dim arg_5FF_1 As Control = Me.PictureBox1
								Dim autoScrollPosition As Point = New Point(e.X, e.Y)
								arg_5FF_0.Show(arg_5FF_1, autoScrollPosition)
							End If
						Else If(e.Button And MouseButtons.Right) > MouseButtons.None Then
							Dim arg_638_0 As ContextMenu = Me.mnuGroupAll
							Dim arg_638_1 As Control = Me.PictureBox1
							Dim autoScrollPosition As Point = New Point(e.X, e.Y)
							arg_638_0.Show(arg_638_1, autoScrollPosition)
						End If
					End If
				Case dlgCacKyHieu.VeTools.Edit
					Me.iEditNode = Me.EditObj.FindNodeAtPoint(pt)
					If Me.iEditNode > -1 Then
						If(e.Button And MouseButtons.Right) > MouseButtons.None Then
							Me.StatusBarPanel3.Text = Me.iEditNode.ToString() + "/" + Me.EditObj.GetPoints().GetUpperBound(0).ToString()
							Me.iEditNode2 = Me.iEditNode
							Dim arg_176_0 As ContextMenu = Me.ContextMenu1
							Dim arg_176_1 As Control = Me.PictureBox1
							Dim autoScrollPosition As Point = New Point(e.X, e.Y)
							arg_176_0.Show(arg_176_1, autoScrollPosition)
						End If
					Else
						Me.OnCapNhatCT()
					End If
				Case dlgCacKyHieu.VeTools.Polygon, dlgCacKyHieu.VeTools.Line, dlgCacKyHieu.VeTools.Curve, dlgCacKyHieu.VeTools.ClosedCurve
					If(e.Button And MouseButtons.Left) > MouseButtons.None Then
						If Not Me.DrawingPicking Then
							Me.DrawingPicking = True
							Me.myPts = New PointF(1) {}
							Me.myPts(0) = pointF
							Me.myPts(1) = pointF
						Else
							Dim num As Integer = Me.myPts.GetUpperBound(0)
							num += 1
							Me.myPts = CType(Utils.CopyArray(CType(Me.myPts, Array), New PointF(num + 1 - 1) {}), PointF())
							Me.myPts(num) = pointF
						End If
					Else
						If Me.myPts.GetUpperBound(0) > 0 Then
							Me.AddNewObj()
						End If
						Me.OnCapNhatCT()
						Me.DrawingPicking = False
					End If
				Case dlgCacKyHieu.VeTools.Cycle
					If(e.Button And MouseButtons.Left) > MouseButtons.None Then
						Me.DrawingDragging = True
						Me.DrawingRect.X = CInt(Math.Round(CDec(pointF.X)))
						Me.DrawingRect.Y = CInt(Math.Round(CDec(pointF.Y)))
						Me.DrawingRect.Height = 0
						Me.DrawingRect.Width = 0
					End If
				Case dlgCacKyHieu.VeTools.Pie
					If(e.Button And MouseButtons.Left) > MouseButtons.None Then
						Me.DrawingDragging = True
						Me.DrawingRect.X = CInt(Math.Round(CDec(pointF.X)))
						Me.DrawingRect.Y = CInt(Math.Round(CDec(pointF.Y)))
						Me.DrawingRect.Height = 0
						Me.DrawingRect.Width = 0
					End If
				Case dlgCacKyHieu.VeTools.Text
					Me.myPts = New PointF(0) {}
					Me.myPts(0) = pointF
					Me.AddNewObj()
					Me.OnCapNhatCT()
				Case dlgCacKyHieu.VeTools.Image
					Me.myPts = New PointF(0) {}
					Me.myPts(0) = pointF
					Me.AddNewObj()
					Me.OnCapNhatCT()
				Case dlgCacKyHieu.VeTools.Move
					Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape
					Me.myfromPt = pointF
					Me.mytoPt = pointF
				Case dlgCacKyHieu.VeTools.Scale
					Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape
					Me.myfromPt = pointF
					Me.mytoPt = pointF
					Me.myrootPt = New PointF(100F, 100F)
					Me.myrootPt = Me.m_SelectedObject.GetCenter()
				Case dlgCacKyHieu.VeTools.Rotate
					Me.StatusBarPanel1.Text = "dang Rotate"
					Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape
					Me.myfromPt = pointF
					Me.mytoPt = pointF
					Me.myrootPt = Nothing
					Me.myrootPt = Me.m_SelectedObject.GetCenter()
				Case dlgCacKyHieu.VeTools.GroupMove
					Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape
					Me.myfromPt = pointF
					Me.mytoPt = pointF
					Me.m_selectedObjects.Clear()
					Me.m_SelectedObject = Nothing
				Case dlgCacKyHieu.VeTools.GroupScale
					Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape
					Me.myfromPt = pointF
					Me.mytoPt = pointF
					Me.myrootPt = New PointF(0F, 0F)
					Me.m_selectedObjects.Clear()
					Me.m_SelectedObject = Nothing
				Case dlgCacKyHieu.VeTools.Split
					Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit
					Me.myfromPt = pointF
					Me.mytoPt = pointF
				Case dlgCacKyHieu.VeTools.ChangeRoot
					If Me.RootHitTest(pointF) Then
						Me.RootDragging = True
					Else
						Me.OnCapNhatCT()
						Me.RootDragging = False
					End If
			End Select
		End Sub

		Private Sub AddNewObj()
			Dim graphicObject As GraphicObject = Nothing
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.Polygon
					graphicObject = New PolygonGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBdTC.defaGenPen1W), .LineColor = modBdTC.defaGenPen1C, .Line2Width = CSng(modBdTC.defaGenPen2W), .Line2Color = modBdTC.defaGenPen2C, .Fill = modBdTC.defaGenFill, .FillColor = modBdTC.defaGenFillC, .LineStyle = modBdTC.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.Line
					graphicObject = New LinesGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBdTC.defaGenPen1W), .LineColor = modBdTC.defaGenPen1C, .Line2Width = CSng(modBdTC.defaGenPen2W), .Line2Color = modBdTC.defaGenPen2C, .FillColor = modBdTC.defaGenFillC, .LineStyle = modBdTC.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.Curve
					graphicObject = New CurveGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBdTC.defaGenPen1W), .LineColor = modBdTC.defaGenPen1C, .Line2Width = CSng(modBdTC.defaGenPen2W), .Line2Color = modBdTC.defaGenPen2C, .FillColor = modBdTC.defaGenFillC, .LineStyle = modBdTC.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.ClosedCurve
					If Me.myPts.GetUpperBound(0) > 1 Then
						graphicObject = New ClosedCurveGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBdTC.defaGenPen1W), .LineColor = modBdTC.defaGenPen1C, .Line2Width = CSng(modBdTC.defaGenPen2W), .Line2Color = modBdTC.defaGenPen2C, .Fill = modBdTC.defaGenFill, .FillColor = modBdTC.defaGenFillC, .LineStyle = modBdTC.defaGenLineStyle }
					End If
				Case dlgCacKyHieu.VeTools.Cycle
					graphicObject = New EllipseGraphic(CSng(Me.DrawingRect.Left), CSng(Me.DrawingRect.Top), CSng(Me.DrawingRect.Width), CSng(Me.DrawingRect.Height), 0F) With { .LineWidth = CSng(modBdTC.defaGenPen1W), .LineColor = modBdTC.defaGenPen1C, .Line2Width = CSng(modBdTC.defaGenPen2W), .Line2Color = modBdTC.defaGenPen2C, .Fill = modBdTC.defaGenFill, .FillColor = modBdTC.defaGenFillC, .LineStyle = modBdTC.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.Pie
					If Me.DrawDrawingPie(Me.PictureBox1.CreateGraphics(), Me.DrawingRect) Then
						graphicObject = New PieGraphic(CSng(Me.DrawingRect.Left), CSng(Me.DrawingRect.Top), CSng(Me.DrawingRect.Width), CSng(Me.DrawingRect.Height), 0F) With { .LineWidth = CSng(modBdTC.defaPiePen1W), .Fill = modBdTC.defaPieFill, .FillColor = modBdTC.defaPieFillC, .LineColor = modBdTC.defaPiePen1C, .IsArc = modBdTC.defaPieArc, .StartAngle = CSng(modBdTC.defaPieStartA), .SweepAngle = CSng(modBdTC.defaPieSweepA) }
					End If
				Case dlgCacKyHieu.VeTools.Text
					graphicObject = New TextGraphic(Me.myPts(0).X, Me.myPts(0).Y, "Text", modBdTC.defaTextFont, modBdTC.defaTextC) With { .Rotation = 0F, .AutoSize = True }
					graphicObject.Rotation = 0F
				Case dlgCacKyHieu.VeTools.Image
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
					Dim openFileDialog2 As OpenFileDialog = openFileDialog
					openFileDialog2.CheckFileExists = True
					openFileDialog2.CheckPathExists = True
					openFileDialog2.Title = "Select Image File"
					openFileDialog2.Filter = "Image Files (*.bmp)|*.bmp;*.gif;*.wmf;*.emf;*.jpg;*.jpeg|All files (*.*)|*.*"
					openFileDialog2.AddExtension = True
					openFileDialog2.Multiselect = False
					openFileDialog2.RestoreDirectory = True
					If openFileDialog.ShowDialog() = DialogResult.OK Then
						Dim fileName As String = openFileDialog.FileName
						If fileName.Length > 0 Then
							Try
								Dim image As Image = New Bitmap(fileName)
								modBdTC.fCacKyHieu.myScale = 1
								modBdTC.fCacKyHieu.myGridWidth = 4
								Me.myWidth = image.Width
								Me.myHeight = image.Height
								Me.ThayDoiGrid()
								Me.DisplayScrollBars()
								Me.PictureBox1.Invalidate()
								Dim pImageType As String = "bmp"
								If image.RawFormat.Equals(ImageFormat.MemoryBmp) Then
									pImageType = "kro"
								End If
								' The following expression was wrapped in a checked-expression
								graphicObject = New EmbeddedImageGraphic(pImageType, CInt(Math.Round(CDec(Me.myPts(0).X))), CInt(Math.Round(CDec(Me.myPts(0).Y))), image) With { .Transparent = True, .TransparentColor = Color.White }
								Dim graphicObject2 As GraphicObject = graphicObject
								graphicObject2.Rotation = 0F
								graphicObject2.AutoSize = False
								graphicObject2.X = Me.myPts(0).X
								graphicObject2.Y = Me.myPts(0).Y
								graphicObject2.Width = CSng(image.Width)
								graphicObject2.Height = CSng(image.Height)
								If graphicObject2.Width > 1500F Then
									graphicObject2.Width = 1500F
								End If
								If graphicObject2.Height > 1500F Then
									graphicObject2.Height = 1500F
								End If
							Catch expr_595 As Exception
								ProjectData.SetProjectError(expr_595)
								ProjectData.ClearProjectError()
							End Try
						End If
					End If
			End Select
			If graphicObject IsNot Nothing Then
				Me.m_drawingObjects.Add(graphicObject)
			End If
		End Sub

		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Dim pointF As PointF = Me.gscTogoc(e.X, e.Y)
			If Me.bSnap Then
				pointF = Me.Snap(pointF.X, pointF.Y)
			End If
			If Me.m_EditingObjects.Count > 0 Then
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape Then
					Me.m_EditingObjects.Clear()
					Me.OnCapNhatCT()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape Then
					Me.m_EditingObjects.Clear()
					Me.OnCapNhatCT()
				End If
			End If
			If Me.m_SelectedObject IsNot Nothing Then
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape Then
					Me.OnCapNhatCT()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape Then
					Me.OnCapNhatCT()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit Then
					Dim sPLITOBJECTS As dlgCacKyHieu.SPLITOBJECTS = Me.To2Objects(Me.m_SelectedObject, Me.myfromPt, Me.mytoPt)
					Me.m_drawingObjects.Remove(Me.m_SelectedObject)
					If Not Information.IsNothing(sPLITOBJECTS.Obj1) Then
						Me.m_drawingObjects.Add(sPLITOBJECTS.Obj1)
						Me.m_SelectedObject = sPLITOBJECTS.Obj1
					End If
					If Not Information.IsNothing(sPLITOBJECTS.Obj2) Then
						Me.m_drawingObjects.Add(sPLITOBJECTS.Obj2)
						Me.m_SelectedObject = sPLITOBJECTS.Obj2
					End If
					Me.OnCapNhatCT()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape Then
					Me.OnCapNhatCT()
				Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape Then
					Me.OnCapNhatCT()
				End If
			Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0 Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			If Me.selectionDragging Then
				Dim rect As RectangleF = Me.DeZoomRectangle(Me.selectionRect)
				Me.m_selectedObjects.Clear()
				Try
					Dim enumerator As IEnumerator = Me.m_drawingObjects.GetEnumerator()
					While enumerator.MoveNext()
						Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
						If graphicObject.HitTest(rect) Then
							Me.m_SelectedObject = graphicObject
							Me.m_selectedObjects.Add(graphicObject)
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				Me.selectionDragging = False
				Me.PictureBox1.Invalidate()
			End If
			If Me.DrawingDragging Then
				Me.DrawingDragging = False
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			End If
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.Cycle, dlgCacKyHieu.VeTools.Pie
					Me.AddNewObj()
					Me.OnCapNhatCT()
			End Select
			Me.RootDragging = False
		End Sub

		Private Sub ToolBar1_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Dim text As String = Conversions.ToString(e.Button.Tag)
			Me.UpdateTB(text)
			Dim left As String = text
			If Operators.CompareString(left, "Line", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Line
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Line"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
			Else If Operators.CompareString(left, "Polygon", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Polygon
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Polygon"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
			Else If Operators.CompareString(left, "Curve", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Curve
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Curve"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
			Else If Operators.CompareString(left, "ClosedCurve", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.ClosedCurve
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "ClosedCurve"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
			Else If Operators.CompareString(left, "Text", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Text
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Text"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n v" & ChrW(7883) & " trí Text."
			Else If Operators.CompareString(left, "Ellipse", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Cycle
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Elippse"
				Me.StatusBarPanel2.Text = "Kéo chu" & ChrW(7897) & "t d" & ChrW(7885) & "c theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng kính " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " Ellipse"
			Else If Operators.CompareString(left, "Pie", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Pie
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Pie"
				Me.StatusBarPanel2.Text = "Kéo chu" & ChrW(7897) & "t d" & ChrW(7885) & "c theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng kính " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " Pie"
			Else If Operators.CompareString(left, "Edit", False) = 0 Then
				Me.OnNodesEdit()
			Else If Operators.CompareString(left, "Past", False) = 0 Then
				If Me.m_CopyObject IsNot Nothing Then
					Dim arg_24B_1 As GraphicObject = Me.m_CopyObject
					Dim pt As PointF = New PointF(Me.m_CopyObject.X + 5F, Me.m_CopyObject.Y + 5F)
					Me.PastObjectAt(arg_24B_1, pt)
					Me.PictureBox1.Invalidate()
					Me.PictureBox2.Invalidate()
				End If
			Else If Operators.CompareString(left, "Option", False) = 0 Then
				Dim dlgOption As dlgOption = New dlgOption()
				dlgOption.nudScale.Value = New Decimal(Me.myScale)
				dlgOption.nudGrid.Value = New Decimal(Me.myGridWidth)
				dlgOption.nudWidth.Value = New Decimal(Me.myWidth)
				dlgOption.nudHeight.Value = New Decimal(Me.myHeight)
				dlgOption.chkSnap.Checked = Me.bSnap
				If dlgOption.ShowDialog(Me) = DialogResult.OK Then
					Me.myScale = Convert.ToInt32(dlgOption.nudScale.Value)
					Me.myGridWidth = Convert.ToInt32(dlgOption.nudGrid.Value)
					Me.myWidth = Convert.ToInt32(dlgOption.nudWidth.Value)
					Me.myHeight = Convert.ToInt32(dlgOption.nudHeight.Value)
					Me.ThayDoiGrid()
					Me.bSnap = dlgOption.chkSnap.Checked
				End If
				Me.DisplayScrollBars()
				Me.PictureBox1.Invalidate()
			Else If Operators.CompareString(left, "Root", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.ChangeRoot
				If Me.myRootX < 0 Then
					Me.myRootX = 0
				End If
				If Me.myRootX > Me.myWidth Then
					Me.myRootX = Me.myWidth
				End If
				If Me.myRootY < 0 Then
					Me.myRootY = 0
				End If
				If Me.myRootY > Me.myHeight Then
					Me.myRootY = Me.myHeight
				End If
				Dim graphics As Graphics = Me.PictureBox1.CreateGraphics()
				Me.PictureBox1.Invalidate()
				Me.StatusBarPanel1.Text = "Root"
				Me.StatusBarPanel2.Text = String.Concat(New String() { "G" & ChrW(7889) & "c=(", Conversions.ToString(Me.myRootX), ",", Conversions.ToString(Me.myRootY), ") Kéo g" & ChrW(7889) & "c " & ChrW(273) & ChrW(7871) & "n v" & ChrW(7883) & " trí m" & ChrW(7899) & "i..." })
			Else If Operators.CompareString(left, "Image", False) = 0 Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Image
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Image"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n v" & ChrW(7883) & " trí Image."
			End If
		End Sub

		Private Sub MnuAddNode_Click(sender As Object, e As EventArgs)
			Me.EditObj.InsertNode(Me.iEditNode2)
			If Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0 Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub MnuChangeNodeType_Click(sender As Object, e As EventArgs)
			Me.EditObj.ChangeNodeType(Me.iEditNode2)
			If Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0 Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub MnXoaNode_Click(sender As Object, e As EventArgs)
			Me.EditObj.RemoveNode(Me.iEditNode2)
			If Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0 Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub MnuChangeColor_Click(sender As Object, e As EventArgs)
			Select Case Me.m_SelectedObject.GetObjType()
				Case OBJECTTYPE.Pie
					If New dlgChangePie() With { .myObj = CType(Me.SelectedObject, PieGraphic) }.ShowDialog(Me) = DialogResult.OK Then
						Me.PictureBox1.Invalidate()
						Me.PictureBox2.Invalidate()
					End If
					Return
				Case OBJECTTYPE.Text
					If New dlgChangeLabel() With { .myObj = CType(Me.SelectedObject, TextGraphic) }.ShowDialog(Me) = DialogResult.OK Then
						Me.PictureBox1.Invalidate()
						Me.PictureBox2.Invalidate()
					End If
					Return
				Case OBJECTTYPE.EmbeddedImage
					Dim embeddedImageGraphic As EmbeddedImageGraphic = CType(Me.m_SelectedObject, EmbeddedImageGraphic)
					Dim dlgChangeImage As dlgChangeImage = New dlgChangeImage()
					dlgChangeImage.chkTransparent.Checked = embeddedImageGraphic.Transparent
					dlgChangeImage.txtTransparentColor.BackColor = embeddedImageGraphic.TransparentColor
					If dlgChangeImage.ShowDialog(Me) = DialogResult.OK Then
						embeddedImageGraphic.Transparent = dlgChangeImage.chkTransparent.Checked
						embeddedImageGraphic.TransparentColor = dlgChangeImage.txtTransparentColor.BackColor
					End If
					Return
			End Select
			If New dlgChangeColor() With { .myObj = CType(Me.SelectedObject, ShapeGraphic) }.ShowDialog(Me) = DialogResult.OK Then
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			End If
		End Sub

		Private Sub MnuDeleteShape_Click(sender As Object, e As EventArgs)
			Me.m_drawingObjects.Remove(Me.m_SelectedObject)
			Me.PictureBox1.Invalidate()
			Me.PictureBox2.Invalidate()
		End Sub

		Private Sub btnNew_Click(sender As Object, e As EventArgs)
			Me.OnAddNew()
		End Sub

		Private Sub EditFromMap()
			Me.txtKyHieu_ID.Text = "-1"
			Me.txtTenKH.Text = ""
			Me.PictureBox2.Invalidate()
			Me.Mode = "Add"
			Me.btnDelete.Enabled = False
			Me.btnNew.Enabled = False
			Me.OnEdit()
		End Sub

		Private Sub OnAddNew()
			Me.ClearForm()
			Me.Mode = "Add"
			Me.btnDelete.Enabled = False
			Me.btnNew.Enabled = False
			Me.OnEdit()
		End Sub

		Private Sub ClearForm()
			Me.txtKyHieu_ID.Text = "-1"
			Me.txtTenKH.Text = ""
			Me.m_drawingObjects.Clear()
			Me.PictureBox2.Invalidate()
		End Sub

		Public Sub OnUpdate()
			Dim size As Size = Me.m_drawingObjects.GetSize()
			Me.myWidth = size.Width
			Me.myHeight = size.Height
			' The following expression was wrapped in a checked-statement
			If Me.myRootX < 0 Or Me.myRootX > Me.myWidth Then
				Me.myRootX = CInt(Math.Round(CDec(Me.myWidth) / 2.0))
			End If
			If Me.myRootY < 0 Or Me.myRootY > Me.myHeight Then
				Me.myRootY = CInt(Math.Round(CDec(Me.myHeight) / 2.0))
			End If
			If Operators.CompareString(Me.Mode, "Add", False) = 0 Then
				If Me.AddKyHieu() Then
					Me.myThumbNails.SelectedIndex = Me.myThumbNails.Count - 1
				End If
			Else If Me.UpdateKyHieu() Then
				Me.picThumbNails.Invalidate()
			End If
		End Sub

		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.OnUpdate()
			Me.PopulateForm()
		End Sub

		Private Function CreateKHTable() As DataTable
			Dim dataTable As DataTable = New DataTable("MyDataTable")
			Dim dataColumn As DataColumn = New DataColumn()
			dataColumn.DataType = Type.[GetType]("System.Int32")
			dataColumn.ColumnName = "KH_ID"
			dataTable.Columns.Add(dataColumn)
			dataColumn = New DataColumn()
			dataColumn.DataType = Type.[GetType]("System.String")
			dataColumn.ColumnName = "TenKH"
			dataTable.Columns.Add(dataColumn)
			Return dataTable
		End Function

		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			If Me.myThumbNails.SelectedIndex > -1 Then
				Dim selectedIndex As Integer = Me.myThumbNails.SelectedIndex
				Me.DeleteKyHieu(Me.myThumbNails(selectedIndex))
				If selectedIndex >= Me.myThumbNails.Count Then
					' The following expression was wrapped in a checked-expression
					Me.myThumbNails.SelectedIndex = selectedIndex - 1
				End If
				Me.PopulateForm()
			End If
		End Sub

		Private Sub MnuSendBack_Click(sender As Object, e As EventArgs)
			Me.m_drawingObjects.SendBack(Me.m_SelectedObject)
			Me.PictureBox1.Invalidate()
			Me.PictureBox2.Invalidate()
		End Sub

		Private Sub MnuScaleShape_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.Scale
			Me.StatusBarPanel1.Text = "Scale"
			Me.StatusBarPanel2.Text = "Zoom: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " thu, phóng"
		End Sub

		Private Sub MnuRotateShape_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.Rotate
			Me.StatusBarPanel1.Text = "Rotate"
			Me.StatusBarPanel2.Text = "Rotate: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " quay"
		End Sub

		Private Sub MnuCopyShape_Click(sender As Object, e As EventArgs)
			Me.m_CopyObject = Me.m_SelectedObject.Clone()
		End Sub

		Private Sub ThayDoiGrid()
			' The following expression was wrapped in a checked-statement
			Me.GridRect.Width = Me.myWidth * Me.myScale
			Me.GridRect.Height = Me.myHeight * Me.myScale
			Me.GridSize = New Size(Me.myGridWidth * Me.myScale, Me.myGridWidth * Me.myScale)
		End Sub

		Private Function AddKyHieu() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			If Not Me.IsValidForm() Then
				result = False
			Else
				Dim value As Object = Me.GetMaxStt(CInt(modBdTC.myLoaiKH_ID)) + 1
				Dim pKH As String = Me.Objects2String(Me.myWidth, Me.myHeight, Me.myRootX, Me.myRootY, Me.m_drawingObjects)
				result = Me.AddKyHieu(pKH, Me.txtTenKH.Text, CInt(modBdTC.myLoaiKH_ID), Conversions.ToInteger(value))
			End If
			Return result
		End Function

		Private Function AddKyHieu(pKH As String, pTenKH As String, pLoaiKH_ID As Integer, pStt As Integer) As Boolean
			Dim flag As Boolean = False
			Dim intID As Integer
			Try
				Dim text As String = "INSERT INTO tblKyHieu "
				text += "(LoaiKH_ID"
				text += ", TenKH"
				text += ", KyHieu, Stt)"
				text += " VALUES (?, ?, ?, ?)"
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				oleDbCommand.Parameters.Add(New OleDbParameter("LoaiKH_ID", OleDbType.[Integer], 0, "LoaiKH_ID"))
				oleDbCommand.Parameters.Add(New OleDbParameter("TenKH", OleDbType.VarWChar, 50, "TenKH"))
				oleDbCommand.Parameters.Add(New OleDbParameter("KyHieu", OleDbType.VarWChar, 0, "KyHieu"))
				oleDbCommand.Parameters.Add(New OleDbParameter("Stt", OleDbType.[Integer], 0, "Stt"))
				oleDbCommand.Parameters("LoaiKH_ID").Value = pLoaiKH_ID
				oleDbCommand.Parameters("TenKH").Value = pTenKH
				oleDbCommand.Parameters("KyHieu").Value = pKH
				oleDbCommand.Parameters("Stt").Value = pStt
				If oleDbCommand.ExecuteNonQuery() = 1 Then
					oleDbCommand.CommandText = "SELECT @@IDENTITY AS 'Identity'"
					intID = Conversions.ToInteger(oleDbCommand.ExecuteScalar())
				End If
				oleDbConnection.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Dispose()
				flag = True
			Catch expr_173 As OleDbException
				ProjectData.SetProjectError(expr_173)
				Dim ex As OleDbException = expr_173
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_196 As Exception
				ProjectData.SetProjectError(expr_196)
				Dim ex2 As Exception = expr_196
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			If flag AndAlso CLng(pLoaiKH_ID) = modBdTC.myLoaiKH_ID Then
				Dim aThumbNail As CThumbNail = New CThumbNail(pTenKH, intID, pKH)
				Me.myThumbNails.Add(aThumbNail)
				Me.myThumbNails.CalculateRowsAndColumns()
				Me.picThumbNails.Invalidate()
			End If
			Return flag
		End Function

		Private Function IsValidForm() As Boolean
			Dim result As Boolean
			If Me.txtTenKH.Text.Length > 0 Then
				result = True
			Else
				Interaction.MsgBox("Ten Ky Hieu Sai.", MsgBoxStyle.Exclamation, Me.Text)
				result = False
			End If
			Return result
		End Function

		Private Function UpdateKyHieu() As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			If Not Me.IsValidForm() Then
				result = False
			Else
				Dim text As String = Me.Objects2String(Me.myWidth, Me.myHeight, Me.myRootX, Me.myRootY, Me.m_drawingObjects)
				Me.myThumbNails(Me.myThumbNails.SelectedIndex).Symbols = text
				Me.myThumbNails(Me.myThumbNails.SelectedIndex).Value = Me.txtTenKH.Text
				Dim text2 As String = ""
				Try
					text2 = "UPDATE tblKyHieu SET"
					text2 += " TenKH = ?"
					text2 += ", KyHieu = ?"
					text2 += " WHERE KH_ID = ?"
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
					oleDbConnection.Open()
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, oleDbConnection)
					oleDbCommand.Parameters.Add(New OleDbParameter("TenKH", OleDbType.VarWChar, 50, "TenKH"))
					oleDbCommand.Parameters.Add(New OleDbParameter("KyHieu", OleDbType.VarWChar, 0, "KyHieu"))
					oleDbCommand.Parameters.Add(New OleDbParameter("Original_KH_ID", OleDbType.[Integer], 0, ParameterDirection.Input, False, 10, 0, "KH_ID", DataRowVersion.Original, Nothing))
					oleDbCommand.Parameters("TenKH").Value = Me.txtTenKH.Text
					oleDbCommand.Parameters("KyHieu").Value = text
					oleDbCommand.Parameters("Original_KH_ID").Value = Me.myThumbNails(Me.myThumbNails.SelectedIndex).ID
					Dim num As Integer = oleDbCommand.ExecuteNonQuery()
					If num <> 1 Then
						Interaction.MsgBox("Update Failed.", MsgBoxStyle.Critical, "Update")
					End If
					oleDbConnection.Close()
					oleDbCommand.Dispose()
					oleDbConnection.Dispose()
					flag = True
				Catch expr_1D8 As OleDbException
					ProjectData.SetProjectError(expr_1D8)
					Dim ex As OleDbException = expr_1D8
					Interaction.MsgBox(text2, MsgBoxStyle.OkOnly, Nothing)
					Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Error")
					ProjectData.ClearProjectError()
				Catch expr_205 As Exception
					ProjectData.SetProjectError(expr_205)
					Dim ex2 As Exception = expr_205
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
					ProjectData.ClearProjectError()
				End Try
				result = flag
			End If
			Return result
		End Function

		Public Sub DeleteKyHieu(aThumbNail As CThumbNail)
			Dim flag As Boolean = False
			Try
				Dim cmdText As String = "DELETE FROM tblKyHieu WHERE KH_ID = " + Conversions.ToString(aThumbNail.ID)
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(cmdText, oleDbConnection)
				Dim num As Integer = oleDbCommand.ExecuteNonQuery()
				If num <> 1 Then
					Interaction.MsgBox("Delete Failed. KyHieu ID " + Conversions.ToString(aThumbNail.ID) + " not found.", MsgBoxStyle.Critical, "Delete")
				Else
					flag = True
				End If
				oleDbConnection.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Dispose()
			Catch expr_7E As OleDbException
				ProjectData.SetProjectError(expr_7E)
				Dim ex As OleDbException = expr_7E
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_A1 As Exception
				ProjectData.SetProjectError(expr_A1)
				Dim ex2 As Exception = expr_A1
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			If flag Then
				Me.myThumbNails.Remove(aThumbNail)
				Me.myThumbNails.CalculateRowsAndColumns()
				Me.picThumbNails.Invalidate()
			End If
		End Sub

		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Try
				Dim graphics As Graphics = e.Graphics
				ControlPaint.DrawGrid(graphics, Me.GridRect, Me.GridSize, Color.Red)
				Dim drawingObjects As CGraphicObjs = Me.m_drawingObjects
				drawingObjects.DrawObjects(graphics, CSng(Me.myScale))
				drawingObjects.DrawSelectedObject(graphics, Me.m_SelectedObject, CSng(Me.myScale))
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape Then
					Me.DrawMuiTen(graphics)
				End If
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape Then
					Me.DrawMuiTen(graphics)
				End If
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit Then
					Me.DrawSplitLine(graphics)
				End If
				If Me.selectionDragging Then
					Me.DrawSelectionRectangle(graphics, Me.selectionRect)
				End If
				If Me.DrawingDragging Then
					If Me.m_DrawTool = dlgCacKyHieu.VeTools.Cycle Then
						Me.DrawDrawingEllipse(graphics, Me.DrawingRect)
					Else If Me.m_DrawTool = dlgCacKyHieu.VeTools.Pie Then
						Me.DrawDrawingPie(graphics, Me.DrawingRect)
					End If
				End If
				If Me.DrawingPicking AndAlso Me.myPts.GetUpperBound(0) > 0 Then
					Me.DrawDrawingLine(graphics, Me.myPts)
				End If
				If Me.m_selectedObjects.Count > 0 Then
					Try
						Dim enumerator As IEnumerator = Me.m_selectedObjects.GetEnumerator()
						While enumerator.MoveNext()
							Dim selectedObject As GraphicObject = CType(enumerator.Current, GraphicObject)
							Me.m_selectedObjects.DrawSelectedObject(graphics, selectedObject, CSng(Me.myScale))
						End While
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
				End If
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit Then
					Me.DrawEditNodes(graphics)
				End If
				If Me.m_DrawTool = dlgCacKyHieu.VeTools.ChangeRoot Then
					Dim arg_17E_1 As Graphics = graphics
					Dim pPt As PointF = New PointF(CSng(Me.myRootX), CSng(Me.myRootY))
					Me.DrawDrawingRoot(arg_17E_1, pPt)
				End If
			Catch expr_185 As Exception
				ProjectData.SetProjectError(expr_185)
				Dim innerException As Exception = expr_185
				Throw New ApplicationException("Error Drawing Graphics Surface", innerException)
			End Try
		End Sub

		Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs)
			Dim graphics As Graphics = e.Graphics
			Me.m_drawingObjects.DrawObjects(graphics, 1F)
		End Sub

		Public Sub SetScrollBarValues(pImageSize As Size)
			Me.VScrollBar1.Minimum = 0
			Me.HScrollBar1.Minimum = 0
			Me.VScrollBar1.Maximum = 0
			Me.HScrollBar1.Maximum = 0
			' The following expression was wrapped in a checked-statement
			If pImageSize.Width - Me.Panel2.ClientSize.Width > 0 Then
				Me.HScrollBar1.Maximum = pImageSize.Width - Me.Panel2.ClientSize.Width
			End If
			Dim hScrollBar As HScrollBar
			If Me.VScrollBar1.Visible Then
				hScrollBar = Me.HScrollBar1
				hScrollBar.Maximum += Me.VScrollBar1.Width
			End If
			Me.HScrollBar1.LargeChange = CInt(Math.Round(CDec((Me.HScrollBar1.Maximum * Me.Panel2.ClientSize.Width)) / CDec(pImageSize.Width)))
			Me.HScrollBar1.SmallChange = CInt(Math.Round(CDec(Me.HScrollBar1.Maximum) / 20.0))
			hScrollBar = Me.HScrollBar1
			hScrollBar.Maximum += Me.HScrollBar1.LargeChange
			If pImageSize.Height - Me.Panel2.ClientSize.Height > 0 Then
				Me.VScrollBar1.Maximum = pImageSize.Height - Me.Panel2.ClientSize.Height
			End If
			Dim vScrollBar As VScrollBar
			If Me.HScrollBar1.Visible Then
				vScrollBar = Me.VScrollBar1
				vScrollBar.Maximum += Me.HScrollBar1.Height
			End If
			Me.VScrollBar1.LargeChange = CInt(Math.Round(CDec((Me.VScrollBar1.Maximum * Me.Panel2.ClientSize.Height)) / CDec(pImageSize.Height)))
			Me.VScrollBar1.SmallChange = CInt(Math.Round(CDec(Me.VScrollBar1.Maximum) / 20.0))
			vScrollBar = Me.VScrollBar1
			vScrollBar.Maximum += Me.VScrollBar1.LargeChange
		End Sub

		Private Sub VScrollBar1_ValueChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Me.pointTL.Y = 0 - Me.VScrollBar1.Value
			Me.PictureBox1.Location = Me.pointTL
		End Sub

		Public Sub DisplayScrollBars()
			Me.HScrollBar1.Value = 0
			Me.VScrollBar1.Value = 0
			Me.pointTL.X = 0
			Me.pointTL.Y = 0
			' The following expression was wrapped in a checked-statement
			Dim clientSize As Size
			If Me.PictureBox1.Visible Then
				Me.PictureBox1.Location = Me.pointTL
				Dim arg_79_0 As Control = Me.PictureBox1
				clientSize = New Size(Me.myWidth * Me.myScale, Me.myHeight * Me.myScale)
				arg_79_0.Size = clientSize
				If Me.Panel2.Width > Me.PictureBox1.Width Then
					Me.HScrollBar1.Visible = False
				Else
					Me.HScrollBar1.Visible = True
				End If
				If Me.Panel2.Height > Me.PictureBox1.Height Then
					Me.VScrollBar1.Visible = False
				Else
					Me.VScrollBar1.Visible = True
				End If
				If Me.VScrollBar1.Visible Then
					Dim arg_114_0 As Control = Me.HScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_114_0.Width = clientSize.Width - Me.VScrollBar1.Width
				Else
					Dim arg_134_0 As Control = Me.HScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_134_0.Width = clientSize.Width
				End If
				If Me.HScrollBar1.Visible Then
					Dim arg_16B_0 As Control = Me.VScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_16B_0.Height = clientSize.Height - Me.HScrollBar1.Height
				Else
					Dim arg_18B_0 As Control = Me.VScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_18B_0.Height = clientSize.Height
				End If
			End If
			clientSize = New Size(Me.myWidth * Me.myScale, Me.myHeight * Me.myScale)
			Me.SetScrollBarValues(clientSize)
		End Sub

		Private Sub HScrollBar1_ValueChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Me.pointTL.X = 0 - Me.HScrollBar1.Value
			Me.PictureBox1.Location = Me.pointTL
		End Sub

		Private Sub Panel2_Resize(sender As Object, e As EventArgs)
			Me.DisplayScrollBars()
		End Sub

		Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs)
			Me.dragOffset.Y = Me.dragOffset.Y + CSng(Me.m_drawingObjects.GetSize().Height)
		End Sub

		Public Function gscTogoc(gsPT As Point) As PointF
			' The following expression was wrapped in a checked-statement
			Dim result As PointF
			result.X = CSng((CInt(Math.Round(CDec(gsPT.X) / CDec(Me.myScale)))))
			result.Y = CSng((CInt(Math.Round(CDec(gsPT.Y) / CDec(Me.myScale)))))
			Return result
		End Function

		Private Function gscTogoc(X As Integer, Y As Integer) As PointF
			' The following expression was wrapped in a checked-statement
			Dim result As PointF
			result.X = CSng((CInt(Math.Round(CDec(X) / CDec(Me.myScale)))))
			result.Y = CSng((CInt(Math.Round(CDec(Y) / CDec(Me.myScale)))))
			Return result
		End Function

		Private Sub DrawSelectionRectangle(g As Graphics, selectionRect As RectangleF)
			Dim brush As SolidBrush = New SolidBrush(Color.FromArgb(75, Color.Gray))
			Dim rect As RectangleF
			rect.Size = selectionRect.Size
			If selectionRect.Width < 0F Then
				rect.X = selectionRect.X - rect.Width
			Else
				rect.X = selectionRect.X
			End If
			If selectionRect.Height < 0F Then
				rect.Y = selectionRect.Y - rect.Height
			Else
				rect.Y = selectionRect.Y
			End If
			g.FillRectangle(brush, rect)
		End Sub

		Private Sub DrawDrawingRectangle(g As Graphics, DrawingRect As Rectangle)
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			Dim rect As Rectangle
			rect.Size = DrawingRect.Size
			' The following expression was wrapped in a checked-statement
			If DrawingRect.Width < 0 Then
				rect.X = DrawingRect.X - rect.Width
			Else
				rect.X = DrawingRect.X
			End If
			If DrawingRect.Height < 0 Then
				rect.Y = DrawingRect.Y - rect.Height
			Else
				rect.Y = DrawingRect.Y
			End If
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawRectangle(pen, rect)
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
		End Sub

		Private Function DrawDrawingPie(g As Graphics, DrawingRect As Rectangle) As Boolean
			Dim result As Boolean = False
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			' The following expression was wrapped in a checked-expression
			Dim rect As Rectangle = New Rectangle(DrawingRect.Left - DrawingRect.Width, DrawingRect.Top - DrawingRect.Height, DrawingRect.Width * 2, DrawingRect.Height * 2)
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			Try
				If modBdTC.defaPieArc Then
					g.DrawArc(pen, rect, CSng(modBdTC.defaPieStartA), CSng(modBdTC.defaPieSweepA))
				Else
					g.DrawPie(pen, rect, CSng(modBdTC.defaPieStartA), CSng(modBdTC.defaPieSweepA))
				End If
				result = True
			Catch arg_B1_0 As Exception
				ProjectData.SetProjectError(arg_B1_0)
				ProjectData.ClearProjectError()
			End Try
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
			Return result
		End Function

		Private Sub DrawDrawingEllipse(g As Graphics, DrawingRect As Rectangle)
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawEllipse(pen, DrawingRect)
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
		End Sub

		Private Sub DrawDrawingLine(g As Graphics, pPts As PointF())
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.Polygon
					g.DrawPolygon(pen, pPts)
				Case dlgCacKyHieu.VeTools.Line
					g.DrawLines(pen, pPts)
				Case dlgCacKyHieu.VeTools.Curve
					g.DrawCurve(pen, pPts)
				Case dlgCacKyHieu.VeTools.ClosedCurve
					If pPts.GetUpperBound(0) > 1 Then
						g.DrawClosedCurve(pen, pPts)
					Else
						g.DrawLines(pen, pPts)
					End If
			End Select
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
		End Sub

		Private Sub DrawEditNodes(g As Graphics)
			Try
				Dim points As PointF() = Me.EditObj.GetPoints()
				Dim transform As Matrix = g.Transform
				Dim container As GraphicsContainer = g.BeginContainer()
				Dim matrix As Matrix = New Matrix()
				matrix.Scale(CSng(Me.myScale), CSng(Me.myScale))
				matrix.TransformPoints(points)
				modBdTC.DrawNodes(g, points, 2F)
				g.EndContainer(container)
				g.Transform = transform
			Catch arg_57_0 As Exception
				ProjectData.SetProjectError(arg_57_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub DrawMuiTen(g As Graphics)
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			pen.EndCap = LineCap.ArrowAnchor
			pen.StartCap = LineCap.RoundAnchor
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawLine(pen, Me.myrootPt, Me.mytoPt)
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
		End Sub

		Private Sub DrawSplitLine(g As Graphics)
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			pen.EndCap = LineCap.ArrowAnchor
			pen.StartCap = LineCap.RoundAnchor
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawLine(pen, Me.myfromPt, Me.mytoPt)
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
		End Sub

		Protected Function DeZoomRectangle(originalRect As RectangleF) As RectangleF
			Dim result As RectangleF = New RectangleF(originalRect.X / CSng(Me.myScale), originalRect.Y / CSng(Me.myScale), originalRect.Width / CSng(Me.myScale), originalRect.Height / CSng(Me.myScale))
			Return result
		End Function

		Private Sub OnNodesEdit()
			If Me.m_SelectedObject IsNot Nothing Then
				Me.EditObj = Me.m_SelectedObject
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.m_SelectedObject = Nothing
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit
				Me.StatusBarPanel1.Text = "Nodes Edit"
				Me.StatusBarPanel2.Text = "Kéo các nút nh" & ChrW(7887) & " " & ChrW(273) & ChrW(7875) & " tinh ch" & ChrW(7881) & "nh. (RightClick " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n Menu)"
				Me.PictureBox1.Invalidate()
			Else
				Me.OnCapNhatCT()
				Me.EditObj = Nothing
				Me.iEditNode = -1
				Interaction.MsgBox("ko co selEditObj", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub MnuNodesEdit_Click(sender As Object, e As EventArgs)
			Me.OnNodesEdit()
		End Sub

		Private Sub MnuMoveShape_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.Move
			Me.StatusBarPanel1.Text = "Move"
			Me.StatusBarPanel2.Text = "Move: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " di chuy" & ChrW(7875) & "n"
		End Sub

		Private Sub MnuGroupMove_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMove
			Me.StatusBarPanel1.Text = "GroupMove"
			Me.StatusBarPanel2.Text = "GroupMove: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " di chuy" & ChrW(7875) & "n"
		End Sub

		Private Sub myThumbNails_Chon(index As Integer)
			If Not Information.IsNothing(modBdTC.fChonTyleKH) Then
				modBdTC.fChonTyleKH.ChonKH()
				Me.Close()
			End If
		End Sub

		Private Sub DBiCombo1_DaChon1(IdValue As Long, TxtValue As String)
			modBdTC.myLoaiKH_ID = IdValue
			' The following expression was wrapped in a checked-expression
			Me.PopulateList(CInt(modBdTC.myLoaiKH_ID))
			Me.PopulateForm()
		End Sub

		Private Sub mnuFlip_Click(sender As Object, e As EventArgs)
			Dim bounds As RectangleF = Me.m_SelectedObject.GetBounds()
			Dim pX As Single = (bounds.Left + bounds.Right) / 2F
			Me.m_SelectedObject.VFlip(pX)
			Me.PictureBox1.Invalidate()
			Me.PictureBox2.Invalidate()
		End Sub

		Private Sub mnuClosedCurveToCurve_Click(sender As Object, e As EventArgs)
			If Me.m_SelectedObject.GetObjType() = OBJECTTYPE.ClosedCurve Then
				Me.m_drawingObjects.MoClosedCurve(Me.m_SelectedObject)
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			Else
				Interaction.MsgBox("Chi lam duoc voi ClosedCurve thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub mnuCurveToClosedCurve_Click(sender As Object, e As EventArgs)
			If Me.m_SelectedObject.GetObjType() = OBJECTTYPE.Curve Then
				Me.m_drawingObjects.DongCurve(Me.m_SelectedObject)
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			Else
				Interaction.MsgBox("Chi lam duoc voi Curve thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub mnu1stNode_Click(sender As Object, e As EventArgs)
			If Me.EditObj.GetObjType() = OBJECTTYPE.ClosedCurve Then
				Dim closedCurveGraphic As ClosedCurveGraphic = CType(Me.EditObj, ClosedCurveGraphic)
				closedCurveGraphic.To1stNode(Me.iEditNode2)
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			Else
				Interaction.MsgBox("Chi lam duoc voi ClosedCurve thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub cmnuKichThuoc_Click(sender As Object, e As EventArgs)
			Dim dlgThumbnailOption As dlgThumbnailOption = New dlgThumbnailOption()
			dlgThumbnailOption.txtImageWidth.Text = Conversions.ToString(Me.myThumbNails.ImageWidth)
			dlgThumbnailOption.txtImageHeight.Text = Conversions.ToString(Me.myThumbNails.ImageHeight)
			dlgThumbnailOption.txtHorizontalSpacing.Text = Conversions.ToString(Me.myThumbNails.HorizontalSpacing)
			dlgThumbnailOption.txtVerticalSpacing.Text = Conversions.ToString(Me.myThumbNails.VerticalSpacing)
			If dlgThumbnailOption.ShowDialog(Me) = DialogResult.OK Then
				Try
					Me.myThumbNails.ImageWidth = Conversions.ToInteger(dlgThumbnailOption.txtImageWidth.Text)
					Me.myThumbNails.ImageHeight = Conversions.ToInteger(dlgThumbnailOption.txtImageHeight.Text)
					Me.myThumbNails.HorizontalSpacing = Conversions.ToInteger(dlgThumbnailOption.txtHorizontalSpacing.Text)
					Me.myThumbNails.VerticalSpacing = Conversions.ToInteger(dlgThumbnailOption.txtVerticalSpacing.Text)
					' The following expression was wrapped in a checked-expression
					Me.PopulateList(CInt(modBdTC.myLoaiKH_ID))
					modBdTC.defaImageWidth = Me.myThumbNails.ImageWidth
					modBdTC.defaImageHeight = Me.myThumbNails.ImageHeight
					modBdTC.defaHorizontalSpacing = Me.myThumbNails.HorizontalSpacing
					modBdTC.defaVerticalSpacing = Me.myThumbNails.VerticalSpacing
				Catch expr_139 As Exception
					ProjectData.SetProjectError(expr_139)
					ProjectData.ClearProjectError()
				End Try
			End If
		End Sub

		Private Sub MnuGroupScale_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScale
			Me.StatusBarPanel1.Text = "GroupScale"
			Me.StatusBarPanel2.Text = "GroupScale: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " thu, phóng"
		End Sub

		Private Sub mnuGroupAllMove_Click(sender As Object, e As EventArgs)
			Me.m_EditingObjects.Clear()
			Try
				Dim enumerator As IEnumerator = Me.m_drawingObjects.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_EditingObjects.Add(aGObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMove
			Me.StatusBarPanel1.Text = "GroupMove"
			Me.StatusBarPanel2.Text = "GroupMove: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " di chuy" & ChrW(7875) & "n"
		End Sub

		Private Sub mnuGroupAllScale_Click(sender As Object, e As EventArgs)
			Me.m_EditingObjects.Clear()
			Try
				Dim enumerator As IEnumerator = Me.m_drawingObjects.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_EditingObjects.Add(aGObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScale
			Me.StatusBarPanel1.Text = "GroupScale"
			Me.StatusBarPanel2.Text = "GroupScale: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " thu, phóng"
		End Sub

		Private Sub GetSize(xmlFrag As String)
			Dim nameTable As NameTable = New NameTable()
			Dim xmlNamespaceManager As XmlNamespaceManager = New XmlNamespaceManager(nameTable)
			xmlNamespaceManager.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, xmlNamespaceManager, Nothing, XmlSpace.None)
			Dim xmlTextReader As XmlTextReader = New XmlTextReader(xmlFrag, XmlNodeType.Element, context)
			Dim num As Integer = 40
			Dim num2 As Integer = 40
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			While xmlTextReader.Read()
				Dim nodeType As XmlNodeType = xmlTextReader.NodeType
				Dim xmlNodeType As XmlNodeType = nodeType
				If xmlNodeType = XmlNodeType.Element Then
					Dim name As String = xmlTextReader.Name
					If Operators.CompareString(name, "KyHieu", False) = 0 AndAlso xmlTextReader.AttributeCount > 0 Then
						While xmlTextReader.MoveToNextAttribute()
							Dim name2 As String = xmlTextReader.Name
							If Operators.CompareString(name2, "W", False) = 0 Then
								num = Conversions.ToInteger(xmlTextReader.Value)
							Else If Operators.CompareString(name2, "H", False) = 0 Then
								num2 = Conversions.ToInteger(xmlTextReader.Value)
							Else If Operators.CompareString(name2, "CX", False) = 0 Then
								num3 = Conversions.ToInteger(xmlTextReader.Value)
							Else If Operators.CompareString(name2, "CY", False) = 0 Then
								num4 = Conversions.ToInteger(xmlTextReader.Value)
							End If
						End While
					End If
				End If
			End While
			xmlTextReader.Close()
			Me.myWidth = num
			Me.myHeight = num2
			Me.myRootX = num3
			Me.myRootY = num4
		End Sub

		Private Function Objects2String(pWidth As Integer, pHeight As Integer, pRootX As Integer, pRootY As Integer, pGObjs As CGraphicObjs) As String
			Dim stringWriter As StringWriter = New StringWriter()
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(stringWriter)
			xmlTextWriter.WriteStartElement("KyHieu")
			xmlTextWriter.WriteAttributeString("W", pWidth.ToString())
			xmlTextWriter.WriteAttributeString("H", pHeight.ToString())
			xmlTextWriter.WriteAttributeString("CX", pRootX.ToString())
			xmlTextWriter.WriteAttributeString("CY", pRootY.ToString())
			pGObjs.Objects2String(xmlTextWriter)
			xmlTextWriter.WriteEndElement()
			xmlTextWriter.Close()
			Return stringWriter.ToString()
		End Function

		Private Sub DrawDrawingRoot(g As Graphics, pPt As PointF)
			Dim pen As Pen = New Pen(Color.FromArgb(75, Color.Black), 1F)
			Dim transform As Matrix = g.Transform
			Dim container As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawLine(pen, pPt.X - 2F, pPt.Y - 2F, pPt.X + 2F, pPt.Y + 2F)
			g.DrawLine(pen, pPt.X - 2F, pPt.Y + 2F, pPt.X + 2F, pPt.Y - 2F)
			pen.Dispose()
			g.EndContainer(container)
			g.Transform = transform
		End Sub

		Private Function RootHitTest(pt As PointF) As Boolean
			' The following expression was wrapped in a checked-expression
			Dim rectangleF As RectangleF = New RectangleF(CSng((Me.myRootX - 3)), CSng((Me.myRootY - 3)), 7F, 7F)
			Return rectangleF.Contains(pt)
		End Function

		Private Function GetMaxStt(pLoaiKH_ID As Integer) As Integer
			Dim result As Integer = 0
			Try
				Dim text As String = "SELECT Stt"
				text += " FROM tblKyHieu"
				text = text + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				text += " ORDER BY tblKyHieu.Stt"
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				While oleDbDataReader.Read()
					result = Conversions.ToInteger(oleDbDataReader(0))
				End While
				oleDbDataReader.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Close()
				oleDbConnection.Dispose()
			Catch expr_8E As OleDbException
				ProjectData.SetProjectError(expr_8E)
				Dim ex As OleDbException = expr_8E
				Interaction.MsgBox(Conversions.ToString(ex.ErrorCode) + ":" + ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_C7 As Exception
				ProjectData.SetProjectError(expr_C7)
				Dim ex2 As Exception = expr_C7
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function

		Private Sub PopulateList(pLoaiKH_ID As Integer)
			Try
				Dim text As String = "SELECT tblKyHieu.KH_ID, tblKyHieu.TenKH, tblKyHieu.KyHieu"
				text += " FROM tblKyHieu LEFT JOIN tblLoaiKH ON tblKyHieu.LoaiKH_ID = tblLoaiKH.LoaiKH_ID"
				If pLoaiKH_ID > 0 Then
					text = text + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				End If
				text += " ORDER BY tblLoaiKH.MaLoaiKH, tblKyHieu.Stt"
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				Me.myThumbNails.Clear()
				While oleDbDataReader.Read()
					Me.myThumbNails.Add(New CThumbNail(oleDbDataReader("TenKH").ToString(), Conversions.ToInteger(oleDbDataReader("KH_ID")), Conversions.ToString(oleDbDataReader("KyHieu"))))
				End While
				oleDbDataReader.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Close()
				oleDbConnection.Dispose()
			Catch expr_C4 As OleDbException
				ProjectData.SetProjectError(expr_C4)
				Dim ex As OleDbException = expr_C4
				Interaction.MsgBox(Conversions.ToString(ex.ErrorCode) + ":" + ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_FD As Exception
				ProjectData.SetProjectError(expr_FD)
				Dim ex2 As Exception = expr_FD
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			If Me.myThumbNails.Count > 0 Then
				' The following expression was wrapped in a checked-expression
				Me.myThumbNails.SelectedIndex = Me.myThumbNails.Count - 1
				Me.myThumbNails.SelectedIndex = 0
			Else
				Me.myThumbNails.SelectedIndex = -1
			End If
			Me.picThumbNails.Invalidate()
		End Sub

		Private Function UpdateSoTT(pKH_ID As Integer, pStt As Integer) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			If Not Me.IsValidForm() Then
				result = False
			Else
				Dim text As String = ""
				Try
					text = "UPDATE tblKyHieu SET"
					text += " Stt = ?"
					text += " WHERE KH_ID = ?"
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
					oleDbConnection.Open()
					Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
					oleDbCommand.Parameters.Add(New OleDbParameter("Stt", OleDbType.[Integer], 0, "Stt"))
					oleDbCommand.Parameters.Add(New OleDbParameter("Original_KH_ID", OleDbType.[Integer], 0, ParameterDirection.Input, False, 10, 0, "KH_ID", DataRowVersion.Original, Nothing))
					oleDbCommand.Parameters("Stt").Value = pStt
					oleDbCommand.Parameters("Original_KH_ID").Value = pKH_ID
					Dim num As Integer = oleDbCommand.ExecuteNonQuery()
					If num <> 1 Then
						Interaction.MsgBox("Update Failed.", MsgBoxStyle.Critical, "Update")
					End If
					oleDbConnection.Close()
					oleDbCommand.Dispose()
					oleDbConnection.Dispose()
					flag = True
				Catch expr_105 As OleDbException
					ProjectData.SetProjectError(expr_105)
					Dim ex As OleDbException = expr_105
					Interaction.MsgBox(text, MsgBoxStyle.OkOnly, Nothing)
					Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Error")
					ProjectData.ClearProjectError()
				Catch expr_132 As Exception
					ProjectData.SetProjectError(expr_132)
					Dim ex2 As Exception = expr_132
					Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
					ProjectData.ClearProjectError()
				End Try
				result = flag
			End If
			Return result
		End Function

		Private Function SoTTisOK(pLoaiKH_ID As Integer) As Boolean
			Dim result As Boolean = True
			Try
				Dim text As String = "SELECT tblKyHieu.KH_ID, tblKyHieu.TenKH, tblKyHieu.Stt"
				text += " FROM tblKyHieu LEFT JOIN tblLoaiKH ON tblKyHieu.LoaiKH_ID = tblLoaiKH.LoaiKH_ID"
				If pLoaiKH_ID > 0 Then
					text = text + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				End If
				text += " ORDER BY tblLoaiKH.MaLoaiKH, tblKyHieu.Stt"
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				Dim num As Integer = 0
				While oleDbDataReader.Read()
					Dim num2 As Integer = Conversions.ToInteger(oleDbDataReader("Stt"))
					If num2 = num Then
						result = False
						Exit While
					End If
					num = num2
				End While
				oleDbDataReader.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Close()
				oleDbConnection.Dispose()
			Catch expr_A9 As OleDbException
				ProjectData.SetProjectError(expr_A9)
				Dim ex As OleDbException = expr_A9
				Interaction.MsgBox(Conversions.ToString(ex.ErrorCode) + ":" + ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_E2 As Exception
				ProjectData.SetProjectError(expr_E2)
				Dim ex2 As Exception = expr_E2
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function

		Private Function GetSoTT(pKH_ID As Integer) As Integer
			Dim result As Integer = -1
			Try
				Dim text As String = "SELECT tblKyHieu.Stt  FROM tblKyHieu"
				text = text + " WHERE tblKyHieu.KH_ID = " + Conversions.ToString(pKH_ID)
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				While oleDbDataReader.Read()
					result = Conversions.ToInteger(oleDbDataReader("Stt"))
				End While
				oleDbDataReader.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Close()
				oleDbConnection.Dispose()
			Catch expr_76 As OleDbException
				ProjectData.SetProjectError(expr_76)
				Dim ex As OleDbException = expr_76
				Interaction.MsgBox(Conversions.ToString(ex.ErrorCode) + ":" + ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_AF As Exception
				ProjectData.SetProjectError(expr_AF)
				Dim ex2 As Exception = expr_AF
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function

		Private Sub DanhSoTT(pLoaiKH_ID As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "SELECT tblKyHieu.KH_ID, tblKyHieu.TenKH, tblKyHieu.KyHieu"
				text += " FROM tblKyHieu LEFT JOIN tblLoaiKH ON tblKyHieu.LoaiKH_ID = tblLoaiKH.LoaiKH_ID"
				If pLoaiKH_ID > 0 Then
					text = text + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				End If
				text += " ORDER BY tblLoaiKH.MaLoaiKH, tblKyHieu.Stt"
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				Dim num As Integer = 0
				While oleDbDataReader.Read()
					num += 1
					Me.UpdateSoTT(Conversions.ToInteger(oleDbDataReader("KH_ID")), num)
				End While
				oleDbDataReader.Close()
				oleDbCommand.Dispose()
				oleDbConnection.Close()
				oleDbConnection.Dispose()
			Catch expr_9B As OleDbException
				ProjectData.SetProjectError(expr_9B)
				Dim ex As OleDbException = expr_9B
				Interaction.MsgBox(Conversions.ToString(ex.ErrorCode) + ":" + ex.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_D4 As Exception
				ProjectData.SetProjectError(expr_D4)
				Dim ex2 As Exception = expr_D4
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Function GetFirstLoaiKH() As Long
			Dim result As Long = 0L
			Dim text As String = "SELECT LoaiKH_ID FROM tblLoaiKH"
			text += " WHERE Cuoi <> 0"
			text += " ORDER BY MaLoaiKH;"
			Try
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				If oleDbDataReader.Read() Then
					result = Conversions.ToLong(oleDbDataReader.GetValue(0))
				End If
				oleDbDataReader.Close()
				oleDbConnection.Close()
			Catch arg_74_0 As Exception
				ProjectData.SetProjectError(arg_74_0)
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function

		Private Sub MnuSplitShape_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.Split
			Me.StatusBarPanel1.Text = "Split"
			Me.StatusBarPanel2.Text = "C" & ChrW(7855) & "t: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng c" & ChrW(7855) & "t."
		End Sub

		Private Function To2Objects(pObject As GraphicObject, pPT0 As PointF, pPT1 As PointF) As dlgCacKyHieu.SPLITOBJECTS
			Dim result As dlgCacKyHieu.SPLITOBJECTS = Nothing
			result.Obj1 = Nothing
			result.Obj2 = Nothing
			Dim array As PointF() = New PointF() { pPT0, pPT1 }
			Dim num As Single = modBdTC.AngleToPoint(array(0), array(1))
			Dim graphicObject As GraphicObject = modBdTC.ObjToCurve(pObject)
			' The following expression was wrapped in a checked-statement
			If graphicObject.GetObjType() = OBJECTTYPE.Curve Then
				Dim points As PointF() = graphicObject.GetPoints()
				Dim intersectPoints As modBdTC.INTERSECTNODE() = modBdTC.GetIntersectPoints(array(0), array(1), points)
				If intersectPoints.GetUpperBound(0) > -1 Then
					Dim array2 As PointF() = New PointF(points.GetUpperBound(0) + intersectPoints.GetUpperBound(0) + 1 + 1 - 1) {}
					Dim num2 As Integer = 0
					Dim arg_CB_0 As Integer = 0
					Dim upperBound As Integer = intersectPoints.GetUpperBound(0)
					For i As Integer = arg_CB_0 To upperBound
						Dim arg_E4_0 As Integer = num2
						Dim nodeIndex As Integer = intersectPoints(i).NodeIndex
						For j As Integer = arg_E4_0 To nodeIndex
							array2(j + i) = points(j)
						Next
						array2(intersectPoints(i).NodeIndex + i + 1) = intersectPoints(i).PT
						num2 = intersectPoints(i).NodeIndex + 1
						intersectPoints(i).NodeIndex = intersectPoints(i).NodeIndex + i + 1
					Next
					Dim arg_18E_0 As Integer = num2
					Dim upperBound2 As Integer = points.GetUpperBound(0)
					For k As Integer = arg_18E_0 To upperBound2
						array2(k + intersectPoints.GetUpperBound(0) + 1) = points(k)
					Next
					Dim array3 As PointF() = New PointF(-1) {}
					Dim array4 As PointF() = New PointF(-1) {}
					Dim num3 As Integer = 0
					Dim arg_1E3_0 As Integer = 0
					Dim upperBound3 As Integer = intersectPoints.GetUpperBound(0)
					For l As Integer = arg_1E3_0 To upperBound3
						Dim array5 As PointF() = New PointF(intersectPoints(l).NodeIndex - num3 + 1 - 1) {}
						Dim arg_216_0 As Integer = num3
						Dim nodeIndex2 As Integer = intersectPoints(l).NodeIndex
						For m As Integer = arg_216_0 To nodeIndex2
							array5(m - num3) = array2(m)
						Next
						num3 = intersectPoints(l).NodeIndex
						If modBdTC.AngleToPoint(array(0), array5(array5.GetUpperBound(0) - 1)) > num Then
							Dim upperBound4 As Integer = array3.GetUpperBound(0)
							array3 = CType(Utils.CopyArray(CType(array3, Array), New PointF(upperBound4 + array5.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_2BB_0 As Integer = 0
							Dim upperBound5 As Integer = array5.GetUpperBound(0)
							For n As Integer = arg_2BB_0 To upperBound5
								array3(n + upperBound4 + 1) = array5(n)
							Next
						Else
							Dim upperBound6 As Integer = array4.GetUpperBound(0)
							array4 = CType(Utils.CopyArray(CType(array4, Array), New PointF(upperBound6 + array5.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_32A_0 As Integer = 0
							Dim upperBound7 As Integer = array5.GetUpperBound(0)
							For num4 As Integer = arg_32A_0 To upperBound7
								array4(num4 + upperBound6 + 1) = array5(num4)
							Next
						End If
					Next
					Dim array6 As PointF() = New PointF(array2.GetUpperBound(0) - num3 + 1 - 1) {}
					Dim arg_38A_0 As Integer = num3
					Dim upperBound8 As Integer = array2.GetUpperBound(0)
					For num5 As Integer = arg_38A_0 To upperBound8
						array6(num5 - num3) = array2(num5)
					Next
					If modBdTC.AngleToPoint(array(0), array6(1)) > num Then
						Dim upperBound9 As Integer = array3.GetUpperBound(0)
						array3 = CType(Utils.CopyArray(CType(array3, Array), New PointF(upperBound9 + array6.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
						Dim arg_416_0 As Integer = 0
						Dim upperBound10 As Integer = array6.GetUpperBound(0)
						For num6 As Integer = arg_416_0 To upperBound10
							array3(num6 + upperBound9 + 1) = array6(num6)
						Next
					Else
						Dim upperBound11 As Integer = array4.GetUpperBound(0)
						array4 = CType(Utils.CopyArray(CType(array4, Array), New PointF(upperBound11 + array6.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
						Dim arg_485_0 As Integer = 0
						Dim upperBound12 As Integer = array6.GetUpperBound(0)
						For num7 As Integer = arg_485_0 To upperBound12
							array4(num7 + upperBound11 + 1) = array6(num7)
						Next
					End If
					Dim curveGraphic As CurveGraphic = CType(graphicObject.Clone(), CurveGraphic)
					curveGraphic.Nodes.Clear()
					Dim arg_4DA_0 As Integer = 0
					Dim upperBound13 As Integer = array3.GetUpperBound(0)
					For num8 As Integer = arg_4DA_0 To upperBound13
						Dim cNODE As CNODE = New CNODE(array3(num8))
						cNODE.IsControl = True
						curveGraphic.Nodes.Add(cNODE)
					Next
					result.Obj1 = curveGraphic
					Dim curveGraphic2 As CurveGraphic = CType(graphicObject.Clone(), CurveGraphic)
					curveGraphic2.Nodes.Clear()
					Dim arg_542_0 As Integer = 0
					Dim upperBound14 As Integer = array4.GetUpperBound(0)
					For num9 As Integer = arg_542_0 To upperBound14
						Dim cNODE2 As CNODE = New CNODE(array4(num9))
						cNODE2.IsControl = True
						curveGraphic2.Nodes.Add(cNODE2)
					Next
					result.Obj2 = curveGraphic2
				Else If modBdTC.AngleToPoint(array(0), points(0)) > num Then
					result.Obj1 = pObject
				Else
					result.Obj2 = pObject
				End If
			Else If graphicObject.GetObjType() = OBJECTTYPE.ClosedCurve Then
				Dim array7 As PointF() = graphicObject.GetPoints()
				Dim upperBound15 As Integer = array7.GetUpperBound(0)
				array7 = CType(Utils.CopyArray(CType(array7, Array), New PointF(upperBound15 + 1 + 1 - 1) {}), PointF())
				array7(upperBound15 + 1) = array7(0)
				Dim intersectPoints2 As modBdTC.INTERSECTNODE() = modBdTC.GetIntersectPoints(array(0), array(1), array7)
				array7 = CType(Utils.CopyArray(CType(array7, Array), New PointF(upperBound15 + 1 - 1) {}), PointF())
				If intersectPoints2.GetUpperBound(0) > 0 Then
					Dim array8 As PointF() = New PointF(-1) {}
					Dim array9 As PointF() = New PointF(-1) {}
					Dim arg_681_0 As Integer = 0
					Dim num10 As Integer = intersectPoints2.GetUpperBound(0) - 1
					For num11 As Integer = arg_681_0 To num10
						Dim nodeIndex3 As Integer = intersectPoints2(num11).NodeIndex
						Dim array10 As PointF() = New PointF(intersectPoints2(num11 + 1).NodeIndex - nodeIndex3 + 1 + 1 - 1) {}
						array10(0) = intersectPoints2(num11).PT
						Dim arg_6E7_0 As Integer = 1
						Dim num12 As Integer = intersectPoints2(num11 + 1).NodeIndex - nodeIndex3
						For num13 As Integer = arg_6E7_0 To num12
							array10(num13) = array7(nodeIndex3 + num13)
						Next
						array10(intersectPoints2(num11 + 1).NodeIndex - nodeIndex3 + 1) = intersectPoints2(num11 + 1).PT
						If modBdTC.AngleToPoint(array(0), array10(1)) > num Then
							Dim upperBound16 As Integer = array8.GetUpperBound(0)
							array8 = CType(Utils.CopyArray(CType(array8, Array), New PointF(upperBound16 + array10.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_7A4_0 As Integer = 0
							Dim upperBound17 As Integer = array10.GetUpperBound(0)
							For num14 As Integer = arg_7A4_0 To upperBound17
								array8(num14 + upperBound16 + 1) = array10(num14)
							Next
						Else
							Dim upperBound18 As Integer = array9.GetUpperBound(0)
							array9 = CType(Utils.CopyArray(CType(array9, Array), New PointF(upperBound18 + array10.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_813_0 As Integer = 0
							Dim upperBound19 As Integer = array10.GetUpperBound(0)
							For num15 As Integer = arg_813_0 To upperBound19
								array9(num15 + upperBound18 + 1) = array10(num15)
							Next
						End If
					Next
					Dim upperBound20 As Integer = intersectPoints2.GetUpperBound(0)
					Dim num16 As Integer = upperBound15 - intersectPoints2(upperBound20).NodeIndex
					Dim num17 As Integer = intersectPoints2(0).NodeIndex + 1
					Dim array11 As PointF() = New PointF(num16 + num17 + 1 + 1 - 1) {}
					array11(0) = intersectPoints2(upperBound20).PT
					Dim nodeIndex4 As Integer = intersectPoints2(upperBound20).NodeIndex
					Dim arg_8C1_0 As Integer = 1
					Dim num18 As Integer = num16
					For num19 As Integer = arg_8C1_0 To num18
						array11(num19) = array7(nodeIndex4 + num19)
					Next
					Dim arg_8F7_0 As Integer = 0
					Dim num20 As Integer = num17 - 1
					For num21 As Integer = arg_8F7_0 To num20
						array11(num21 + num16 + 1) = array7(num21)
					Next
					array11(num16 + num17 + 1) = intersectPoints2(0).PT
					If modBdTC.AngleToPoint(array(0), array11(1)) > num Then
						Dim upperBound21 As Integer = array8.GetUpperBound(0)
						array8 = CType(Utils.CopyArray(CType(array8, Array), New PointF(upperBound21 + array11.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
						Dim arg_9A5_0 As Integer = 0
						Dim upperBound22 As Integer = array11.GetUpperBound(0)
						For num22 As Integer = arg_9A5_0 To upperBound22
							array8(num22 + upperBound21 + 1) = array11(num22)
						Next
					Else
						Dim upperBound23 As Integer = array9.GetUpperBound(0)
						array9 = CType(Utils.CopyArray(CType(array9, Array), New PointF(upperBound23 + array11.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
						Dim arg_A14_0 As Integer = 0
						Dim upperBound24 As Integer = array11.GetUpperBound(0)
						For num23 As Integer = arg_A14_0 To upperBound24
							array9(num23 + upperBound23 + 1) = array11(num23)
						Next
					End If
					Dim closedCurveGraphic As ClosedCurveGraphic = CType(graphicObject.Clone(), ClosedCurveGraphic)
					closedCurveGraphic.Nodes.Clear()
					Dim arg_A69_0 As Integer = 0
					Dim upperBound25 As Integer = array8.GetUpperBound(0)
					For num24 As Integer = arg_A69_0 To upperBound25
						Dim cNODE3 As CNODE = New CNODE(array8(num24))
						cNODE3.IsControl = True
						closedCurveGraphic.Nodes.Add(cNODE3)
					Next
					result.Obj1 = closedCurveGraphic
					Dim closedCurveGraphic2 As ClosedCurveGraphic = CType(graphicObject.Clone(), ClosedCurveGraphic)
					closedCurveGraphic2.Nodes.Clear()
					Dim arg_AD1_0 As Integer = 0
					Dim upperBound26 As Integer = array9.GetUpperBound(0)
					For num25 As Integer = arg_AD1_0 To upperBound26
						Dim cNODE4 As CNODE = New CNODE(array9(num25))
						cNODE4.IsControl = True
						closedCurveGraphic2.Nodes.Add(cNODE4)
					Next
					result.Obj2 = closedCurveGraphic2
				Else If modBdTC.AngleToPoint(array(0), array7(0)) > num Then
					result.Obj1 = pObject
				Else
					result.Obj2 = pObject
				End If
			Else
				Dim points2 As PointF() = pObject.GetPoints()
				If modBdTC.AngleToPoint(array(0), points2(0)) > num Then
					result.Obj1 = pObject
				Else
					result.Obj2 = pObject
				End If
			End If
			Return result
		End Function

		Private Sub PictureBox1_KeyUp(sender As Object, e As KeyEventArgs)
			Select Case e.KeyCode
				Case Keys.Left
					If Not Information.IsNothing(Me.m_SelectedObject) Then
						If(Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
							Dim bounds As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim deltaX As Single = (bounds.Width - 1F) / bounds.Width
							Dim deltaY As Single = 1F
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, deltaX, deltaY)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Control) = Keys.Control Then
							Me.myfromPt = Me.m_SelectedObject.GetCenter()
							Me.mytoPt = Me.myfromPt
							Me.mytoPt.X = Me.mytoPt.X - 1F
							Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Rotate2(Me.myrootPt, -modBdTC.myTinhChinhGocQuay)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						End If
					End If
				Case Keys.Up
					If Not Information.IsNothing(Me.m_SelectedObject) Then
						If(Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
							Dim bounds2 As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim deltaX2 As Single = 1F
							Dim deltaY2 As Single = (bounds2.Height + 1F) / bounds2.Height
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, deltaX2, deltaY2)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Control) = Keys.Control Then
							Me.myfromPt = Me.m_SelectedObject.GetCenter()
							Me.mytoPt = Me.myfromPt
							Me.mytoPt.Y = Me.mytoPt.Y - 1F
							Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
						End If
					End If
				Case Keys.Right
					If Not Information.IsNothing(Me.m_SelectedObject) Then
						If(Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
							Dim bounds3 As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim deltaX3 As Single = (bounds3.Width + 1F) / bounds3.Width
							Dim deltaY3 As Single = 1F
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, deltaX3, deltaY3)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Control) = Keys.Control Then
							Me.myfromPt = Me.m_SelectedObject.GetCenter()
							Me.mytoPt = Me.myfromPt
							Me.mytoPt.X = Me.mytoPt.X + 1F
							Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Rotate2(Me.myrootPt, modBdTC.myTinhChinhGocQuay)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						End If
					End If
				Case Keys.Down
					If Not Information.IsNothing(Me.m_SelectedObject) Then
						If(Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
							Dim bounds4 As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim deltaX4 As Single = 1F
							Dim deltaY4 As Single = (bounds4.Height - 1F) / bounds4.Height
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, deltaX4, deltaY4)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Control) = Keys.Control Then
							Me.myfromPt = Me.m_SelectedObject.GetCenter()
							Me.mytoPt = Me.myfromPt
							Me.mytoPt.Y = Me.mytoPt.Y + 1F
							Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else If(Control.ModifierKeys And Keys.Alt) = Keys.Alt Then
						End If
					End If
				Case Keys.Delete
					If Not Information.IsNothing(Me.m_SelectedObject) Then
						Me.m_drawingObjects.Remove(Me.m_SelectedObject)
						Me.PictureBox1.Invalidate()
						Me.PictureBox2.Invalidate()
					End If
			End Select
		End Sub

		Private Sub mnuGroupAllPast_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Not Information.IsNothing(myModule.fMain.myBando.SelectedSymbol) Then
				Me.m_drawingObjects.Clear()
				Dim num As Single = 0F
				Dim num2 As Single = 0F
				Dim num3 As Single = 0F
				Dim num4 As Single = 0F
				Try
					Dim enumerator As IEnumerator = myModule.fMain.myBando.SelectedSymbol.GObjs.GetEnumerator()
					While enumerator.MoveNext()
						Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim bounds As RectangleF = graphicObject.GetBounds()
						If bounds.Left < num Then
							num = bounds.Left
						End If
						If bounds.Top < num2 Then
							num2 = bounds.Top
						End If
						If bounds.Width > num3 Then
							num3 = bounds.Width
						End If
						If bounds.Height > num4 Then
							num4 = bounds.Height
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				' The following expression was wrapped in a unchecked-expression
				Me.myRootX = CInt(Math.Round(CDec(-num)))
				' The following expression was wrapped in a unchecked-expression
				Me.myRootY = CInt(Math.Round(CDec(-num2)))
				Me.myWidth = CInt(Math.Round(CDec(num3)))
				Me.myHeight = CInt(Math.Round(CDec(num4)))
				Try
					Dim enumerator2 As IEnumerator = myModule.fMain.myBando.SelectedSymbol.GObjs.GetEnumerator()
					While enumerator2.MoveNext()
						Dim graphicObject2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
						Dim graphicObject3 As GraphicObject = graphicObject2.Clone()
						Dim arg_175_0 As GraphicObject = graphicObject3
						Dim pointF As PointF = New PointF(0F, 0F)
						Dim arg_175_1 As PointF = pointF
						Dim toPt As PointF = New PointF(CSng(Me.myRootX), CSng(Me.myRootY))
						arg_175_0.Move(arg_175_1, toPt)
						Me.m_drawingObjects.Add(graphicObject3)
					End While
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						(TryCast(enumerator2, IDisposable)).Dispose()
					End If
				End Try
				Me.ThayDoiGrid()
				Me.DisplayScrollBars()
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			End If
		End Sub

		Public Sub CopyFromMap(pSymbol As CSymbol, pTyle As Single)
			' The following expression was wrapped in a checked-statement
			If Not Information.IsNothing(pSymbol) Then
				Dim cGraphicObjs As CGraphicObjs = New CGraphicObjs()
				Dim num As Single = 0F
				Dim num2 As Single = 0F
				Dim num3 As Single = 10F
				Dim num4 As Single = 10F
				Try
					Dim enumerator As IEnumerator = pSymbol.GObjs.GetEnumerator()
					While enumerator.MoveNext()
						Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim bounds As RectangleF = graphicObject.GetBounds()
						If bounds.Left < num Then
							num = bounds.Left
						End If
						If bounds.Top < num2 Then
							num2 = bounds.Top
						End If
						If bounds.Width > num3 Then
							num3 = bounds.Width
						End If
						If bounds.Height > num4 Then
							num4 = bounds.Height
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				' The following expression was wrapped in a unchecked-expression
				Dim num5 As Integer = CInt(Math.Round(CDec(-num)))
				' The following expression was wrapped in a unchecked-expression
				Dim num6 As Integer = CInt(Math.Round(CDec(-num2)))
				Try
					Dim enumerator2 As IEnumerator = pSymbol.GObjs.GetEnumerator()
					While enumerator2.MoveNext()
						Dim graphicObject2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
						Dim graphicObject3 As GraphicObject = graphicObject2.Clone()
						Dim arg_121_0 As GraphicObject = graphicObject3
						Dim pointF As PointF = New PointF(0F, 0F)
						Dim arg_121_1 As PointF = pointF
						Dim pointF2 As PointF = New PointF(CSng(num5), CSng(num6))
						arg_121_0.Move(arg_121_1, pointF2)
						Dim arg_13D_0 As GraphicObject = graphicObject3
						pointF2 = New PointF(0F, 0F)
						arg_13D_0.Zoom2(pointF2, pTyle, pTyle)
						cGraphicObjs.Add(graphicObject3)
					End While
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						(TryCast(enumerator2, IDisposable)).Dispose()
					End If
				End Try
				Dim pKH As String = Me.Objects2String(CInt(Math.Round(CDec(num3))), CInt(Math.Round(CDec(num4))), num5, num6, cGraphicObjs)
				Dim value As Object = Me.GetMaxStt(CInt(modBdTC.myLoaiKH_ID)) + 1
				If Me.AddKyHieu(pKH, pSymbol.Description, CInt(modBdTC.myLoaiKH_ID), Conversions.ToInteger(value)) Then
					Me.myThumbNails.SelectedIndex = Me.myThumbNails.Count - 1
				End If
			End If
		End Sub

		Private Sub cmnuDeleteKH_Click(sender As Object, e As EventArgs)
			If MessageBox.Show("Xóa ký hi" & ChrW(7879) & "u này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				Me.btnDelete_Click(Nothing, Nothing)
			End If
		End Sub

		Private Sub cmnuCopyTo_Click(sender As Object, e As EventArgs)
			Dim dlgCopyKH As dlgCopyKH = New dlgCopyKH()
			Dim dBiTraDM As DBiTraDM = dlgCopyKH.DBiTraDM1
			dBiTraDM.ConnStr = Me.myKHConnStr
			dBiTraDM.TableName = "tblLoaiKH"
			dBiTraDM.MaFieldName = "MaLoaiKH"
			dBiTraDM.TenFieldName = "TenLoaiKH"
			dBiTraDM.CuoiFieldName = "Cuoi"
			If dlgCopyKH.ShowDialog(Me) = DialogResult.OK Then
				Dim pKH As String = Me.Objects2String(Me.myWidth, Me.myHeight, Me.myRootX, Me.myRootY, Me.m_drawingObjects)
				' The following expression was wrapped in a checked-expression
				Dim value As Object = Me.GetMaxStt(Conversions.ToInteger(dlgCopyKH.txtLoaiKH_ID.Text)) + 1
				Me.AddKyHieu(pKH, Me.txtTenKH.Text, Conversions.ToInteger(dlgCopyKH.txtLoaiKH_ID.Text), Conversions.ToInteger(value))
			End If
		End Sub

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgCacKyHieu_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgCacKyHieu_Load
			Me.myRootX = 0
			Me.myRootY = 0
			Me.myORootX = 0
			Me.myORootY = 0
			Me.RootDragging = False
			Me.dragOffset = New PointF(0F, 0F)
			Me.selectionDragging = False
			Me.DrawingDragging = False
			Me.DrawingPicking = False
			Me.m_drawingObjects = New CGraphicObjs()
			Me.m_OdrawingObjects = New CGraphicObjs()
			Me.m_selectedObjects = New CGraphicObjs()
			Me.m_EditingObjects = New CGraphicObjs()
			Me.m_CopyObjects = New CGraphicObjs()
			Me.bSnap = True
			Me.myScale = 4
			Me.myGridWidth = 2
			Me.myWidth = 40
			Me.myHeight = 40
			' The following expression was wrapped in a checked-statement
			Me.GridSize = New Size(Me.myGridWidth * Me.myScale, Me.myGridWidth * Me.myScale)
			Me.GridRect = New Rectangle(0, 0, Me.myWidth * Me.myScale, Me.myHeight * Me.myScale)
			Me.bLoadXong = False
			Me.GridPen = New Pen(Color.Black, 1F)
			Me.Mode = "Update"
			Me.InitializeComponent()
		End Sub

		Private Sub btnUp_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If modBdTC.myLoaiKH_ID > 0L Then
				If Me.myThumbNails.SelectedIndex > 0 Then
					Dim selectedIndex As Integer = Me.myThumbNails.SelectedIndex
					If Not Me.SoTTisOK(CInt(modBdTC.myLoaiKH_ID)) Then
						Me.DanhSoTT(CInt(modBdTC.myLoaiKH_ID))
					End If
					Dim iD As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex).ID
					Dim iD2 As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex - 1).ID
					Dim soTT As Integer = Me.GetSoTT(iD2)
					Dim soTT2 As Integer = Me.GetSoTT(iD)
					Me.UpdateSoTT(iD2, soTT2)
					Me.UpdateSoTT(iD, soTT)
					Me.PopulateList(CInt(modBdTC.myLoaiKH_ID))
					Me.myThumbNails.SelectedIndex = selectedIndex - 1
					Me.myThumbNails.CalculateRowsAndColumns()
					Me.picThumbNails.Invalidate()
				End If
			Else
				Interaction.MsgBox("Ch" & ChrW(7881) & " s" & ChrW(7855) & "p x" & ChrW(7871) & "p th" & ChrW(7913) & " t" & ChrW(7921) & " trong t" & ChrW(7915) & "ng nhóm!", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub MnuGroupCopy_Click(sender As Object, e As EventArgs)
			If Me.m_EditingObjects.Count > 0 Then
				Me.m_CopyObjects.Clear()
				Try
					Dim enumerator As IEnumerator = Me.m_EditingObjects.GetEnumerator()
					While enumerator.MoveNext()
						Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim aGObj As GraphicObject = graphicObject.Clone()
						Me.m_CopyObjects.Add(aGObj)
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
			End If
		End Sub

		Private Sub mnuGroupPast_Click(sender As Object, e As EventArgs)
			If Me.m_CopyObjects.Count > 0 Then
				Me.m_selectedObjects.Clear()
				Try
					Dim enumerator As IEnumerator = Me.m_CopyObjects.GetEnumerator()
					While enumerator.MoveNext()
						Dim graphicObject As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim aGObj As GraphicObject = graphicObject.Clone()
						Me.m_drawingObjects.Add(aGObj)
						Me.m_selectedObjects.Add(aGObj)
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			End If
		End Sub

		Private Sub MnuSendFront_Click(sender As Object, e As EventArgs)
			Me.m_drawingObjects.SendFront(Me.m_SelectedObject)
			Me.PictureBox1.Invalidate()
			Me.PictureBox2.Invalidate()
		End Sub

		Private Sub btnDown_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If modBdTC.myLoaiKH_ID > 0L Then
				If Me.myThumbNails.SelectedIndex < Me.myThumbNails.Count - 1 Then
					Dim selectedIndex As Integer = Me.myThumbNails.SelectedIndex
					If Not Me.SoTTisOK(CInt(modBdTC.myLoaiKH_ID)) Then
						Me.DanhSoTT(CInt(modBdTC.myLoaiKH_ID))
					End If
					Dim iD As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex).ID
					Dim iD2 As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex + 1).ID
					Dim soTT As Integer = Me.GetSoTT(iD2)
					Dim soTT2 As Integer = Me.GetSoTT(iD)
					Me.UpdateSoTT(iD2, soTT2)
					Me.UpdateSoTT(iD, soTT)
					Me.PopulateList(CInt(modBdTC.myLoaiKH_ID))
					Me.myThumbNails.SelectedIndex = selectedIndex + 1
					Me.myThumbNails.CalculateRowsAndColumns()
					Me.picThumbNails.Invalidate()
				End If
			Else
				Interaction.MsgBox("Ch" & ChrW(7881) & " s" & ChrW(7855) & "p x" & ChrW(7871) & "p th" & ChrW(7913) & " t" & ChrW(7921) & " trong t" & ChrW(7915) & "ng nhóm!", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub myThumbNails_SelectedIndexChanged(e As MouseEventArgs)
			Me.PopulateForm()
			Me.m_OdrawingObjects = Me.m_drawingObjects
			Me.myORootX = Me.myRootX
			Me.myORootY = Me.myRootY
			If modBdTC.fChonTyleKH Is Nothing Then
				If e.Button = MouseButtons.Right Then
					If Me.myThumbNails.SelectedIndex > -1 Then
						Dim arg_73_0 As ContextMenu = Me.cmnuKyHieu
						Dim arg_73_1 As Control = modBdTC.fCacKyHieu.picThumbNails
						Dim pos As Point = New Point(e.X, e.Y)
						arg_73_0.Show(arg_73_1, pos)
					Else
						Dim arg_9E_0 As ContextMenu = Me.cmnuThumbNail
						Dim arg_9E_1 As Control = modBdTC.fCacKyHieu.picThumbNails
						Dim pos As Point = New Point(e.X, e.Y)
						arg_9E_0.Show(arg_9E_1, pos)
					End If
				Else If e.Button = MouseButtons.Left Then
					If Me.myThumbNails.SelectedIndex > -1 Then
						myModule.fMain.myBando.ChuanBiNhanKH()
					Else
						myModule.fMain.myBando.NhanKHXong()
					End If
				End If
				Me.picThumbNails.Invalidate()
			End If
		End Sub
	End Class
End Namespace
