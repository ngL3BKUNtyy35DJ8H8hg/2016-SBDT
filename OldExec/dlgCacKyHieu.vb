Imports BdTC.My.Resources
Imports DanhMuc
Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
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

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgCacKyHieu
		Inherits Form

		Private Structure SPLITOBJECTS
			Public Obj1 As GraphicObject

			Public Obj2 As GraphicObject
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

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		<AccessedThroughProperty("DBiCombo1")>
		Private _DBiCombo1 As DBiCombo

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
			<DebuggerNonUserCode()>
			Get
				Return Me._cmnuThumbNail
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._cmnuThumbNail = value
			End Set
		End Property

		Friend Overridable Property cmnuKichThuoc() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._cmnuKichThuoc
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._cmnuKichThuoc IsNot Nothing
				If flag Then
					RemoveHandler Me._cmnuKichThuoc.Click, AddressOf Me.cmnuKichThuoc_Click
				End If
				Me._cmnuKichThuoc = value
				flag = (Me._cmnuKichThuoc IsNot Nothing)
				If flag Then
					AddHandler Me._cmnuKichThuoc.Click, AddressOf Me.cmnuKichThuoc_Click
				End If
			End Set
		End Property

		Friend Overridable Property ImageList1() As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ImageList1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		Friend Overridable Property ContextMenu1() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenu1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Friend Overridable Property MnXoaNode() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnXoaNode
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnXoaNode IsNot Nothing
				If flag Then
					RemoveHandler Me._MnXoaNode.Click, AddressOf Me.MnXoaNode_Click
				End If
				Me._MnXoaNode = value
				flag = (Me._MnXoaNode IsNot Nothing)
				If flag Then
					AddHandler Me._MnXoaNode.Click, AddressOf Me.MnXoaNode_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem2() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem2 = value
			End Set
		End Property

		Friend Overridable Property MnuAddNode() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuAddNode
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuAddNode IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuAddNode.Click, AddressOf Me.MnuAddNode_Click
				End If
				Me._MnuAddNode = value
				flag = (Me._MnuAddNode IsNot Nothing)
				If flag Then
					AddHandler Me._MnuAddNode.Click, AddressOf Me.MnuAddNode_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem3() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem3 = value
			End Set
		End Property

		Friend Overridable Property MnuChangeNodeType() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuChangeNodeType
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuChangeNodeType IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuChangeNodeType.Click, AddressOf Me.MnuChangeNodeType_Click
				End If
				Me._MnuChangeNodeType = value
				flag = (Me._MnuChangeNodeType IsNot Nothing)
				If flag Then
					AddHandler Me._MnuChangeNodeType.Click, AddressOf Me.MnuChangeNodeType_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem13() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem13 = value
			End Set
		End Property

		Friend Overridable Property mnu1stNode() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnu1stNode
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnu1stNode IsNot Nothing
				If flag Then
					RemoveHandler Me._mnu1stNode.Click, AddressOf Me.mnu1stNode_Click
				End If
				Me._mnu1stNode = value
				flag = (Me._mnu1stNode IsNot Nothing)
				If flag Then
					AddHandler Me._mnu1stNode.Click, AddressOf Me.mnu1stNode_Click
				End If
			End Set
		End Property

		Friend Overridable Property ContextMenu2() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenu2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu2 = value
			End Set
		End Property

		Friend Overridable Property MnuMoveShape() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuMoveShape
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuMoveShape IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuMoveShape.Click, AddressOf Me.MnuMoveShape_Click
				End If
				Me._MnuMoveShape = value
				flag = (Me._MnuMoveShape IsNot Nothing)
				If flag Then
					AddHandler Me._MnuMoveShape.Click, AddressOf Me.MnuMoveShape_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem9() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem9 = value
			End Set
		End Property

		Friend Overridable Property MnuScaleShape() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuScaleShape
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuScaleShape IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuScaleShape.Click, AddressOf Me.MnuScaleShape_Click
				End If
				Me._MnuScaleShape = value
				flag = (Me._MnuScaleShape IsNot Nothing)
				If flag Then
					AddHandler Me._MnuScaleShape.Click, AddressOf Me.MnuScaleShape_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem5() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem5 = value
			End Set
		End Property

		Friend Overridable Property MnuRotateShape() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuRotateShape
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuRotateShape IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuRotateShape.Click, AddressOf Me.MnuRotateShape_Click
				End If
				Me._MnuRotateShape = value
				flag = (Me._MnuRotateShape IsNot Nothing)
				If flag Then
					AddHandler Me._MnuRotateShape.Click, AddressOf Me.MnuRotateShape_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem11() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem11 = value
			End Set
		End Property

		Friend Overridable Property mnuFlip() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuFlip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuFlip IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuFlip.Click, AddressOf Me.mnuFlip_Click
				End If
				Me._mnuFlip = value
				flag = (Me._mnuFlip IsNot Nothing)
				If flag Then
					AddHandler Me._mnuFlip.Click, AddressOf Me.mnuFlip_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem7() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem7 = value
			End Set
		End Property

		Friend Overridable Property MnuDeleteShape() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuDeleteShape
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuDeleteShape IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuDeleteShape.Click, AddressOf Me.MnuDeleteShape_Click
				End If
				Me._MnuDeleteShape = value
				flag = (Me._MnuDeleteShape IsNot Nothing)
				If flag Then
					AddHandler Me._MnuDeleteShape.Click, AddressOf Me.MnuDeleteShape_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem6() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem6 = value
			End Set
		End Property

		Friend Overridable Property MnuChangeColor() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuChangeColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuChangeColor IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuChangeColor.Click, AddressOf Me.MnuChangeColor_Click
				End If
				Me._MnuChangeColor = value
				flag = (Me._MnuChangeColor IsNot Nothing)
				If flag Then
					AddHandler Me._MnuChangeColor.Click, AddressOf Me.MnuChangeColor_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem8() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem8 = value
			End Set
		End Property

		Friend Overridable Property MnuNodesEdit() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuNodesEdit
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuNodesEdit IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuNodesEdit.Click, AddressOf Me.MnuNodesEdit_Click
				End If
				Me._MnuNodesEdit = value
				flag = (Me._MnuNodesEdit IsNot Nothing)
				If flag Then
					AddHandler Me._MnuNodesEdit.Click, AddressOf Me.MnuNodesEdit_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem1() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem1 = value
			End Set
		End Property

		Friend Overridable Property MnuSendBack() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuSendBack
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuSendBack IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuSendBack.Click, AddressOf Me.MnuSendBack_Click
				End If
				Me._MnuSendBack = value
				flag = (Me._MnuSendBack IsNot Nothing)
				If flag Then
					AddHandler Me._MnuSendBack.Click, AddressOf Me.MnuSendBack_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem4() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem4 = value
			End Set
		End Property

		Friend Overridable Property MnuCopyShape() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCopyShape
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuCopyShape IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuCopyShape.Click, AddressOf Me.MnuCopyShape_Click
				End If
				Me._MnuCopyShape = value
				flag = (Me._MnuCopyShape IsNot Nothing)
				If flag Then
					AddHandler Me._MnuCopyShape.Click, AddressOf Me.MnuCopyShape_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem10() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem10 = value
			End Set
		End Property

		Friend Overridable Property mnuClosedCurveToCurve() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuClosedCurveToCurve
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuClosedCurveToCurve IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuClosedCurveToCurve.Click, AddressOf Me.mnuClosedCurveToCurve_Click
				End If
				Me._mnuClosedCurveToCurve = value
				flag = (Me._mnuClosedCurveToCurve IsNot Nothing)
				If flag Then
					AddHandler Me._mnuClosedCurveToCurve.Click, AddressOf Me.mnuClosedCurveToCurve_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem12() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem12 = value
			End Set
		End Property

		Friend Overridable Property mnuCurveToClosedCurve() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuCurveToClosedCurve
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuCurveToClosedCurve IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuCurveToClosedCurve.Click, AddressOf Me.mnuCurveToClosedCurve_Click
				End If
				Me._mnuCurveToClosedCurve = value
				flag = (Me._mnuCurveToClosedCurve IsNot Nothing)
				If flag Then
					AddHandler Me._mnuCurveToClosedCurve.Click, AddressOf Me.mnuCurveToClosedCurve_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuGroup() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGroup
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._MnuGroup = value
			End Set
		End Property

		Friend Overridable Property MnuGroupMove() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGroupMove
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGroupMove IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGroupMove.Click, AddressOf Me.MnuGroupMove_Click
				End If
				Me._MnuGroupMove = value
				flag = (Me._MnuGroupMove IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGroupMove.Click, AddressOf Me.MnuGroupMove_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem14() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem14 = value
			End Set
		End Property

		Friend Overridable Property MnuGroupScale() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGroupScale
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGroupScale IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGroupScale.Click, AddressOf Me.MnuGroupScale_Click
				End If
				Me._MnuGroupScale = value
				flag = (Me._MnuGroupScale IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGroupScale.Click, AddressOf Me.MnuGroupScale_Click
				End If
			End Set
		End Property

		Friend Overridable Property mnuGroupAll() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuGroupAll
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._mnuGroupAll = value
			End Set
		End Property

		Friend Overridable Property mnuGroupAllMove() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuGroupAllMove
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuGroupAllMove IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuGroupAllMove.Click, AddressOf Me.mnuGroupAllMove_Click
				End If
				Me._mnuGroupAllMove = value
				flag = (Me._mnuGroupAllMove IsNot Nothing)
				If flag Then
					AddHandler Me._mnuGroupAllMove.Click, AddressOf Me.mnuGroupAllMove_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem16() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem16 = value
			End Set
		End Property

		Friend Overridable Property mnuGroupAllScale() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuGroupAllScale
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuGroupAllScale IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuGroupAllScale.Click, AddressOf Me.mnuGroupAllScale_Click
				End If
				Me._mnuGroupAllScale = value
				flag = (Me._mnuGroupAllScale IsNot Nothing)
				If flag Then
					AddHandler Me._mnuGroupAllScale.Click, AddressOf Me.mnuGroupAllScale_Click
				End If
			End Set
		End Property

		Friend Overridable Property Panel1() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Friend Overridable Property Panel3() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim flag As Boolean = Me._Panel3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel3.MouseUp, AddressOf Me.Panel3_MouseUp
				End If
				Me._Panel3 = value
				flag = (Me._Panel3 IsNot Nothing)
				If flag Then
					AddHandler Me._Panel3.MouseUp, AddressOf Me.Panel3_MouseUp
				End If
			End Set
		End Property

		Friend Overridable Property txtTyLe() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtTyLe
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTyLe = value
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property DBiCombo1() As DBiCombo
			<DebuggerNonUserCode()>
			Get
				Return Me._DBiCombo1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DBiCombo)
				Dim flag As Boolean = Me._DBiCombo1 IsNot Nothing
				If flag Then
					RemoveHandler Me._DBiCombo1.DaChon, AddressOf Me.DBiCombo1_DaChon1
				End If
				Me._DBiCombo1 = value
				flag = (Me._DBiCombo1 IsNot Nothing)
				If flag Then
					AddHandler Me._DBiCombo1.DaChon, AddressOf Me.DBiCombo1_DaChon1
				End If
			End Set
		End Property

		Friend Overridable Property picThumbNails() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._picThumbNails
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._picThumbNails = value
			End Set
		End Property

		Friend Overridable Property Splitter2() As Splitter
			<DebuggerNonUserCode()>
			Get
				Return Me._Splitter2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter2 = value
			End Set
		End Property

		Friend Overridable Property Panel4() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel4 = value
			End Set
		End Property

		Friend Overridable Property txtKyHieu_ID() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtKyHieu_ID
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtKyHieu_ID = value
			End Set
		End Property

		Friend Overridable Property btnDelete() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnDelete
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnDelete IsNot Nothing
				If flag Then
					RemoveHandler Me._btnDelete.Click, AddressOf Me.btnDelete_Click
				End If
				Me._btnDelete = value
				flag = (Me._btnDelete IsNot Nothing)
				If flag Then
					AddHandler Me._btnDelete.Click, AddressOf Me.btnDelete_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnSave() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnSave
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnSave IsNot Nothing
				If flag Then
					RemoveHandler Me._btnSave.Click, AddressOf Me.btnSave_Click
				End If
				Me._btnSave = value
				flag = (Me._btnSave IsNot Nothing)
				If flag Then
					AddHandler Me._btnSave.Click, AddressOf Me.btnSave_Click
				End If
			End Set
		End Property

		Friend Overridable Property txtTenKH() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtTenKH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTenKH = value
			End Set
		End Property

		Friend Overridable Property btnNew() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnNew
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnNew IsNot Nothing
				If flag Then
					RemoveHandler Me._btnNew.Click, AddressOf Me.btnNew_Click
				End If
				Me._btnNew = value
				flag = (Me._btnNew IsNot Nothing)
				If flag Then
					AddHandler Me._btnNew.Click, AddressOf Me.btnNew_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnEdit() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnEdit
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnEdit IsNot Nothing
				If flag Then
					RemoveHandler Me._btnEdit.Click, AddressOf Me.btnEdit_Click
				End If
				Me._btnEdit = value
				flag = (Me._btnEdit IsNot Nothing)
				If flag Then
					AddHandler Me._btnEdit.Click, AddressOf Me.btnEdit_Click
				End If
			End Set
		End Property

		Friend Overridable Property PictureBox2() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim flag As Boolean = Me._PictureBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox2.Paint, AddressOf Me.PictureBox2_Paint
				End If
				Me._PictureBox2 = value
				flag = (Me._PictureBox2 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox2.Paint, AddressOf Me.PictureBox2_Paint
				End If
			End Set
		End Property

		Friend Overridable Property Splitter1() As Splitter
			<DebuggerNonUserCode()>
			Get
				Return Me._Splitter1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter1 = value
			End Set
		End Property

		Friend Overridable Property ToolBar1() As ToolBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim flag As Boolean = Me._ToolBar1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolBar1.ButtonClick, AddressOf Me.ToolBar1_ButtonClick
				End If
				Me._ToolBar1 = value
				flag = (Me._ToolBar1 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolBar1.ButtonClick, AddressOf Me.ToolBar1_ButtonClick
				End If
			End Set
		End Property

		Friend Overridable Property ToolBarButton1() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton1 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton2() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton2 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton3() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton3 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton4() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton4 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton5() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton5 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton6() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton6 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton7() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton7 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton8() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton8 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton9() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton9 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton10() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton10 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton11() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton11 = value
			End Set
		End Property

		Friend Overridable Property ToolBarButton12() As ToolBarButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolBarButton12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton12 = value
			End Set
		End Property

		Friend Overridable Property StatusBar1() As StatusBar
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBar)
				Me._StatusBar1 = value
			End Set
		End Property

		Friend Overridable Property StatusBarPanel1() As StatusBarPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBarPanel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel1 = value
			End Set
		End Property

		Friend Overridable Property StatusBarPanel2() As StatusBarPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBarPanel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel2 = value
			End Set
		End Property

		Friend Overridable Property StatusBarPanel3() As StatusBarPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBarPanel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel3 = value
			End Set
		End Property

		Friend Overridable Property Panel2() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim flag As Boolean = Me._Panel2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel2.Resize, AddressOf Me.Panel2_Resize
				End If
				Me._Panel2 = value
				flag = (Me._Panel2 IsNot Nothing)
				If flag Then
					AddHandler Me._Panel2.Resize, AddressOf Me.Panel2_Resize
				End If
			End Set
		End Property

		Friend Overridable Property VScrollBar1() As VScrollBar
			<DebuggerNonUserCode()>
			Get
				Return Me._VScrollBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As VScrollBar)
				Dim flag As Boolean = Me._VScrollBar1 IsNot Nothing
				If flag Then
					RemoveHandler Me._VScrollBar1.ValueChanged, AddressOf Me.VScrollBar1_ValueChanged
				End If
				Me._VScrollBar1 = value
				flag = (Me._VScrollBar1 IsNot Nothing)
				If flag Then
					AddHandler Me._VScrollBar1.ValueChanged, AddressOf Me.VScrollBar1_ValueChanged
				End If
			End Set
		End Property

		Friend Overridable Property HScrollBar1() As HScrollBar
			<DebuggerNonUserCode()>
			Get
				Return Me._HScrollBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HScrollBar)
				Dim flag As Boolean = Me._HScrollBar1 IsNot Nothing
				If flag Then
					RemoveHandler Me._HScrollBar1.ValueChanged, AddressOf Me.HScrollBar1_ValueChanged
				End If
				Me._HScrollBar1 = value
				flag = (Me._HScrollBar1 IsNot Nothing)
				If flag Then
					AddHandler Me._HScrollBar1.ValueChanged, AddressOf Me.HScrollBar1_ValueChanged
				End If
			End Set
		End Property

		Friend Overridable Property PictureBox1() As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.MouseUp, AddressOf Me.PictureBox1_MouseUp
					RemoveHandler Me._PictureBox1.MouseDown, AddressOf Me.PictureBox1_MouseDown
					RemoveHandler Me._PictureBox1.MouseMove, AddressOf Me.PictureBox1_MouseMove
					RemoveHandler Me._PictureBox1.DoubleClick, AddressOf Me.PictureBox1_DoubleClick
					RemoveHandler Me._PictureBox1.KeyUp, AddressOf Me.PictureBox1_KeyUp
					RemoveHandler Me._PictureBox1.Paint, AddressOf Me.PictureBox1_Paint
				End If
				Me._PictureBox1 = value
				flag = (Me._PictureBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox1.MouseUp, AddressOf Me.PictureBox1_MouseUp
					AddHandler Me._PictureBox1.MouseDown, AddressOf Me.PictureBox1_MouseDown
					AddHandler Me._PictureBox1.MouseMove, AddressOf Me.PictureBox1_MouseMove
					AddHandler Me._PictureBox1.DoubleClick, AddressOf Me.PictureBox1_DoubleClick
					AddHandler Me._PictureBox1.KeyUp, AddressOf Me.PictureBox1_KeyUp
					AddHandler Me._PictureBox1.Paint, AddressOf Me.PictureBox1_Paint
				End If
			End Set
		End Property

		Friend Overridable Property StatusBarPanel4() As StatusBarPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBarPanel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBarPanel)
				Me._StatusBarPanel4 = value
			End Set
		End Property

		Friend Overridable Property MnuSplitShape() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuSplitShape
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuSplitShape IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuSplitShape.Click, AddressOf Me.MnuSplitShape_Click
				End If
				Me._MnuSplitShape = value
				flag = (Me._MnuSplitShape IsNot Nothing)
				If flag Then
					AddHandler Me._MnuSplitShape.Click, AddressOf Me.MnuSplitShape_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem17() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem17 = value
			End Set
		End Property

		Friend Overridable Property MenuItem15() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem15 = value
			End Set
		End Property

		Friend Overridable Property mnuGroupAllPast() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuGroupAllPast
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuGroupAllPast IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuGroupAllPast.Click, AddressOf Me.mnuGroupAllPast_Click
				End If
				Me._mnuGroupAllPast = value
				flag = (Me._mnuGroupAllPast IsNot Nothing)
				If flag Then
					AddHandler Me._mnuGroupAllPast.Click, AddressOf Me.mnuGroupAllPast_Click
				End If
			End Set
		End Property

		Friend Overridable Property cmnuKyHieu() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._cmnuKyHieu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._cmnuKyHieu = value
			End Set
		End Property

		Friend Overridable Property cmnuCopyTo() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._cmnuCopyTo
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._cmnuCopyTo IsNot Nothing
				If flag Then
					RemoveHandler Me._cmnuCopyTo.Click, AddressOf Me.cmnuCopyTo_Click
				End If
				Me._cmnuCopyTo = value
				flag = (Me._cmnuCopyTo IsNot Nothing)
				If flag Then
					AddHandler Me._cmnuCopyTo.Click, AddressOf Me.cmnuCopyTo_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem19() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem19 = value
			End Set
		End Property

		Friend Overridable Property cmnuDeleteKH() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._cmnuDeleteKH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._cmnuDeleteKH IsNot Nothing
				If flag Then
					RemoveHandler Me._cmnuDeleteKH.Click, AddressOf Me.cmnuDeleteKH_Click
				End If
				Me._cmnuDeleteKH = value
				flag = (Me._cmnuDeleteKH IsNot Nothing)
				If flag Then
					AddHandler Me._cmnuDeleteKH.Click, AddressOf Me.cmnuDeleteKH_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnUp() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnUp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnUp IsNot Nothing
				If flag Then
					RemoveHandler Me._btnUp.Click, AddressOf Me.btnUp_Click
				End If
				Me._btnUp = value
				flag = (Me._btnUp IsNot Nothing)
				If flag Then
					AddHandler Me._btnUp.Click, AddressOf Me.btnUp_Click
				End If
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property MenuItem20() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem20 = value
			End Set
		End Property

		Friend Overridable Property MnuGroupCopy() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGroupCopy
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGroupCopy IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGroupCopy.Click, AddressOf Me.MnuGroupCopy_Click
				End If
				Me._MnuGroupCopy = value
				flag = (Me._MnuGroupCopy IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGroupCopy.Click, AddressOf Me.MnuGroupCopy_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem21() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem21 = value
			End Set
		End Property

		Friend Overridable Property mnuGroupPast() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._mnuGroupPast
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._mnuGroupPast IsNot Nothing
				If flag Then
					RemoveHandler Me._mnuGroupPast.Click, AddressOf Me.mnuGroupPast_Click
				End If
				Me._mnuGroupPast = value
				flag = (Me._mnuGroupPast IsNot Nothing)
				If flag Then
					AddHandler Me._mnuGroupPast.Click, AddressOf Me.mnuGroupPast_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuSendFront() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuSendFront
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuSendFront IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuSendFront.Click, AddressOf Me.MnuSendFront_Click
				End If
				Me._MnuSendFront = value
				flag = (Me._MnuSendFront IsNot Nothing)
				If flag Then
					AddHandler Me._MnuSendFront.Click, AddressOf Me.MnuSendFront_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnDown() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnDown
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnDown IsNot Nothing
				If flag Then
					RemoveHandler Me._btnDown.Click, AddressOf Me.btnDown_Click
				End If
				Me._btnDown = value
				flag = (Me._btnDown IsNot Nothing)
				If flag Then
					AddHandler Me._btnDown.Click, AddressOf Me.btnDown_Click
				End If
			End Set
		End Property

		Friend Overridable Property myThumbNails() As CThumbNails
			<DebuggerNonUserCode()>
			Get
				Return Me._myThumbNails
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CThumbNails)
				Dim flag As Boolean = Me._myThumbNails IsNot Nothing
				If flag Then
					RemoveHandler Me._myThumbNails.SelectedIndexChanged, AddressOf Me.myThumbNails_SelectedIndexChanged
				End If
				Me._myThumbNails = value
				flag = (Me._myThumbNails IsNot Nothing)
				If flag Then
					AddHandler Me._myThumbNails.SelectedIndexChanged, AddressOf Me.myThumbNails_SelectedIndexChanged
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
				Dim flag As Boolean = value IsNot Me.m_SelectedObject
				If flag Then
					Dim flag2 As Boolean = Me.m_drawingObjects.Contains(value) OrElse value Is Nothing
					If flag2 Then
						Me.m_SelectedObject = value
						flag2 = (value Is Nothing)
						If flag2 Then
						End If
						Me.Invalidate()
					End If
				End If
			End Set
		End Property

		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Container()
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(dlgCacKyHieu))
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
			Me.Label2 = New Label()
			Me.txtTyLe = New TextBox()
			Me.Label1 = New Label()
			Me.DBiCombo1 = New DBiCombo()
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
			Me.ToolBarButton8 = New ToolBarButton()
			Me.ToolBarButton9 = New ToolBarButton()
			Me.ToolBarButton10 = New ToolBarButton()
			Me.ToolBarButton11 = New ToolBarButton()
			Me.ToolBarButton12 = New ToolBarButton()
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
			Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
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
			Dim arg_E5C_0 As Control = Me.Panel1
			Dim location As Point = New Point(0, 0)
			arg_E5C_0.Location = location
			Me.Panel1.Name = "Panel1"
			Dim arg_E8C_0 As Control = Me.Panel1
			Dim size As Size = New Size(239, 462)
			arg_E8C_0.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel3.BorderStyle = BorderStyle.Fixed3D
			Me.Panel3.Controls.Add(Me.Label2)
			Me.Panel3.Controls.Add(Me.txtTyLe)
			Me.Panel3.Controls.Add(Me.Label1)
			Me.Panel3.Controls.Add(Me.DBiCombo1)
			Me.Panel3.Controls.Add(Me.picThumbNails)
			Me.Panel3.Dock = DockStyle.Fill
			Dim arg_F3D_0 As Control = Me.Panel3
			location = New Point(0, 0)
			arg_F3D_0.Location = location
			Me.Panel3.Name = "Panel3"
			Dim arg_F6D_0 As Control = Me.Panel3
			size = New Size(239, 307)
			arg_F6D_0.Size = size
			Me.Panel3.TabIndex = 4
			Me.Label2.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Dim arg_FB0_0 As Control = Me.Label2
			location = New Point(10, 281)
			arg_FB0_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_FDA_0 As Control = Me.Label2
			size = New Size(38, 13)
			arg_FDA_0.Size = size
			Me.Label2.TabIndex = 22
			Me.Label2.Text = "Label2"
			Me.txtTyLe.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Dim arg_1026_0 As Control = Me.txtTyLe
			location = New Point(195, 278)
			arg_1026_0.Location = location
			Me.txtTyLe.Name = "txtTyLe"
			Dim arg_1050_0 As Control = Me.txtTyLe
			size = New Size(32, 21)
			arg_1050_0.Size = size
			Me.txtTyLe.TabIndex = 20
			Me.txtTyLe.Text = "1"
			Me.Label1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Label1.AutoSize = True
			Dim arg_10A6_0 As Control = Me.Label1
			location = New Point(84, 281)
			arg_10A6_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_10D0_0 As Control = Me.Label1
			size = New Size(105, 13)
			arg_10D0_0.Size = size
			Me.Label1.TabIndex = 19
			Me.Label1.Text = "T" & ChrW(7927) & " l" & ChrW(7879) & " khi l" & ChrW(7845) & "y vào B" & ChrW(272) & ":"
			Me.Label1.TextAlign = ContentAlignment.MiddleRight
			Me.DBiCombo1.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.DBiCombo1.ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\binh\CacKyHieu.mdb;"
			Me.DBiCombo1.CuoiFieldName = "Cuoi"
			Me.DBiCombo1.DMIDFieldName = ""
			Me.DBiCombo1.DMIDValue = 0
			Me.DBiCombo1.FilterFieldName = ""
			Me.DBiCombo1.FilterValue = 0
			Me.DBiCombo1.IDFieldName = "LoaiKH_ID"
			Me.DBiCombo1.IDValue = 0L
			Dim arg_119F_0 As Control = Me.DBiCombo1
			location = New Point(8, 8)
			arg_119F_0.Location = location
			Me.DBiCombo1.MaFieldName = "MaLoaiKH"
			Me.DBiCombo1.MnuChonText = ""
			Me.DBiCombo1.MucLen = 2
			Me.DBiCombo1.Name = "DBiCombo1"
			Me.DBiCombo1.Password = ""
			Dim arg_120C_0 As Control = Me.DBiCombo1
			size = New Size(219, 24)
			arg_120C_0.Size = size
			Me.DBiCombo1.TabIndex = 18
			Me.DBiCombo1.TableName = "tblLoaiKH"
			Me.DBiCombo1.TenFieldName = "TenLoaiKH"
			Me.DBiCombo1.TextValue = ""
			Me.DBiCombo1.TreeLinesNo = 10
			Me.DBiCombo1.TreeWidthScale = 1F
			Me.DBiCombo1.UserID = ""
			Me.picThumbNails.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.picThumbNails.BackColor = SystemColors.Window
			Me.picThumbNails.BorderStyle = BorderStyle.Fixed3D
			Dim arg_12C1_0 As Control = Me.picThumbNails
			location = New Point(8, 40)
			arg_12C1_0.Location = location
			Me.picThumbNails.Name = "picThumbNails"
			Dim arg_12F1_0 As Control = Me.picThumbNails
			size = New Size(219, 232)
			arg_12F1_0.Size = size
			Me.picThumbNails.TabIndex = 0
			Me.picThumbNails.TabStop = False
			Me.Splitter2.Dock = DockStyle.Bottom
			Dim arg_1333_0 As Control = Me.Splitter2
			location = New Point(0, 307)
			arg_1333_0.Location = location
			Me.Splitter2.Name = "Splitter2"
			Dim arg_135F_0 As Control = Me.Splitter2
			size = New Size(239, 3)
			arg_135F_0.Size = size
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
			Dim arg_147D_0 As Control = Me.Panel4
			location = New Point(0, 310)
			arg_147D_0.Location = location
			Me.Panel4.Name = "Panel4"
			Dim arg_14AD_0 As Control = Me.Panel4
			size = New Size(239, 152)
			arg_14AD_0.Size = size
			Me.Panel4.TabIndex = 2
			Me.btnDown.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.btnDown.Image = Resources.FillDown
			Dim arg_14F4_0 As Control = Me.btnDown
			location = New Point(206, 4)
			arg_14F4_0.Location = location
			Me.btnDown.Name = "btnDown"
			Dim arg_151E_0 As Control = Me.btnDown
			size = New Size(25, 23)
			arg_151E_0.Size = size
			Me.btnDown.TabIndex = 35
			Me.btnDown.UseVisualStyleBackColor = True
			Dim arg_1555_0 As Control = Me.txtKyHieu_ID
			location = New Point(187, 105)
			arg_1555_0.Location = location
			Me.txtKyHieu_ID.Name = "txtKyHieu_ID"
			Dim arg_157F_0 As Control = Me.txtKyHieu_ID
			size = New Size(40, 21)
			arg_157F_0.Size = size
			Me.txtKyHieu_ID.TabIndex = 34
			Me.txtKyHieu_ID.Text = "44"
			Me.txtKyHieu_ID.Visible = False
			Me.btnUp.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.btnUp.Image = Resources.FillUp
			Dim arg_15E5_0 As Control = Me.btnUp
			location = New Point(183, 4)
			arg_15E5_0.Location = location
			Me.btnUp.Name = "btnUp"
			Dim arg_160F_0 As Control = Me.btnUp
			size = New Size(23, 23)
			arg_160F_0.Size = size
			Me.btnUp.TabIndex = 21
			Me.btnUp.UseVisualStyleBackColor = True
			Dim arg_1642_0 As Control = Me.btnDelete
			location = New Point(120, 4)
			arg_1642_0.Location = location
			Me.btnDelete.Name = "btnDelete"
			Dim arg_166C_0 As Control = Me.btnDelete
			size = New Size(48, 24)
			arg_166C_0.Size = size
			Me.btnDelete.TabIndex = 23
			Me.btnDelete.Text = "Del"
			Dim arg_16A3_0 As Control = Me.btnSave
			location = New Point(56, 4)
			arg_16A3_0.Location = location
			Me.btnSave.Name = "btnSave"
			Dim arg_16CD_0 As Control = Me.btnSave
			size = New Size(56, 24)
			arg_16CD_0.Size = size
			Me.btnSave.TabIndex = 22
			Me.btnSave.Text = "Update"
			Me.txtTenKH.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.txtTenKH.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_1730_0 As Control = Me.txtTenKH
			location = New Point(6, 36)
			arg_1730_0.Location = location
			Me.txtTenKH.Name = "txtTenKH"
			Dim arg_175D_0 As Control = Me.txtTenKH
			size = New Size(223, 21)
			arg_175D_0.Size = size
			Me.txtTenKH.TabIndex = 17
			Dim arg_1782_0 As Control = Me.btnNew
			location = New Point(8, 4)
			arg_1782_0.Location = location
			Me.btnNew.Name = "btnNew"
			Dim arg_17AC_0 As Control = Me.btnNew
			size = New Size(40, 24)
			arg_17AC_0.Size = size
			Me.btnNew.TabIndex = 21
			Me.btnNew.Text = "New"
			Me.btnEdit.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_17F5_0 As Control = Me.btnEdit
			location = New Point(183, 72)
			arg_17F5_0.Location = location
			Me.btnEdit.Name = "btnEdit"
			Dim arg_181F_0 As Control = Me.btnEdit
			size = New Size(48, 24)
			arg_181F_0.Size = size
			Me.btnEdit.TabIndex = 20
			Me.btnEdit.Text = "Edit"
			Me.PictureBox2.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.PictureBox2.BackColor = SystemColors.Window
			Me.PictureBox2.BorderStyle = BorderStyle.Fixed3D
			Dim arg_1882_0 As Control = Me.PictureBox2
			location = New Point(8, 68)
			arg_1882_0.Location = location
			Me.PictureBox2.Name = "PictureBox2"
			Dim arg_18AF_0 As Control = Me.PictureBox2
			size = New Size(167, 73)
			arg_18AF_0.Size = size
			Me.PictureBox2.TabIndex = 18
			Me.PictureBox2.TabStop = False
			Dim arg_18E5_0 As Control = Me.Splitter1
			location = New Point(239, 0)
			arg_18E5_0.Location = location
			Me.Splitter1.Name = "Splitter1"
			Dim arg_1911_0 As Control = Me.Splitter1
			size = New Size(4, 462)
			arg_1911_0.Size = size
			Me.Splitter1.TabIndex = 2
			Me.Splitter1.TabStop = False
			Me.ToolBar1.Buttons.AddRange(New ToolBarButton() { Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton12, Me.ToolBarButton11, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton10 })
			Me.ToolBar1.DropDownArrows = True
			Me.ToolBar1.ImageList = Me.ImageList1
			Dim arg_1A08_0 As Control = Me.ToolBar1
			location = New Point(243, 0)
			arg_1A08_0.Location = location
			Me.ToolBar1.Name = "ToolBar1"
			Me.ToolBar1.ShowToolTips = True
			Dim arg_1A42_0 As Control = Me.ToolBar1
			size = New Size(506, 28)
			arg_1A42_0.Size = size
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
			Me.ToolBarButton11.ImageIndex = 10
			Me.ToolBarButton11.Name = "ToolBarButton11"
			Me.ToolBarButton11.Tag = "Root"
			Me.ToolBarButton11.ToolTipText = "Change Root"
			Me.ToolBarButton12.ImageIndex = 11
			Me.ToolBarButton12.Name = "ToolBarButton12"
			Me.ToolBarButton12.Tag = "Image"
			Me.ToolBarButton12.ToolTipText = "Image"
			Dim arg_1D71_0 As Control = Me.StatusBar1
			location = New Point(243, 440)
			arg_1D71_0.Location = location
			Me.StatusBar1.Name = "StatusBar1"
			Me.StatusBar1.Panels.AddRange(New StatusBarPanel() { Me.StatusBarPanel4, Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3 })
			Me.StatusBar1.ShowPanels = True
			Dim arg_1DF2_0 As Control = Me.StatusBar1
			size = New Size(506, 22)
			arg_1DF2_0.Size = size
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
			Dim arg_1F3B_0 As Control = Me.Panel2
			location = New Point(243, 28)
			arg_1F3B_0.Location = location
			Me.Panel2.Name = "Panel2"
			Dim arg_1F6B_0 As Control = Me.Panel2
			size = New Size(506, 412)
			arg_1F6B_0.Size = size
			Me.Panel2.TabIndex = 12
			Me.VScrollBar1.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_1FA2_0 As Control = Me.VScrollBar1
			location = New Point(485, 0)
			arg_1FA2_0.Location = location
			Me.VScrollBar1.Name = "VScrollBar1"
			Dim arg_1FCF_0 As Control = Me.VScrollBar1
			size = New Size(17, 271)
			arg_1FCF_0.Size = size
			Me.VScrollBar1.TabIndex = 2
			Me.HScrollBar1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_2004_0 As Control = Me.HScrollBar1
			location = New Point(0, 391)
			arg_2004_0.Location = location
			Me.HScrollBar1.Name = "HScrollBar1"
			Dim arg_2031_0 As Control = Me.HScrollBar1
			size = New Size(344, 17)
			arg_2031_0.Size = size
			Me.HScrollBar1.TabIndex = 1
			Me.PictureBox1.Anchor = AnchorStyles.None
			Me.PictureBox1.BackColor = SystemColors.Window
			Dim arg_2075_0 As Control = Me.PictureBox1
			location = New Point(40, 21)
			arg_2075_0.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim arg_20A5_0 As Control = Me.PictureBox1
			size = New Size(296, 280)
			arg_20A5_0.Size = size
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
			modBanDo.myTyLeKH2Map = 1F
			Try
				modBanDo.myTyLeKH2Map = Conversions.ToSingle(Me.txtTyLe.Text)
			Catch expr_23 As Exception
				ProjectData.SetProjectError(expr_23)
				ProjectData.ClearProjectError()
			End Try
			Me.myThumbNails = Nothing
			modBanDo.fCacKyHieu = Nothing
			myModule.fMain.myBando.NhanKHXong()
		End Sub

		Private Sub dlgCacKyHieu_Load(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Me.Location = myModule.fCallForm.Location
				Me.Height = myModule.fCallForm.Height - 20
				Me.Panel1.Width = modBanDo.defaImageWidth * 3 + modBanDo.defaHorizontalSpacing * 10
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
				Me.myKHConnStr = "File Name = " + modBanDo.myCacKyHieuUDL
				Me.myThumbNails = New CThumbNails(Me.picThumbNails)
				Me.btnEdit.Enabled = False
				modBanDo.EditNodesCount = 0
				modBanDo.EditNodes = New modBanDo.EDITNODE(modBanDo.EditNodesCount - 1 + 1 - 1) {}
				Me.iEditNode = 0
				Me.DBiCombo1.ConnStr = Me.myKHConnStr
				Me.DBiCombo1.KhoiDong(modBanDo.myLoaiKH_ID)
				Dim flag As Boolean = Me.m_drawingObjects.Count > 0
				If flag Then
					Me.EditFromMap()
				End If
				Me.PopulateList(CInt(modBanDo.myLoaiKH_ID))
				Me.PopulateForm()
				Me.txtTyLe.Text = Conversions.ToString(modBanDo.myTyLeKH2Map)
			Catch arg_1AB_0 As Exception
				ProjectData.SetProjectError(arg_1AB_0)
				Me.Close()
				ProjectData.ClearProjectError()
			End Try
			modBanDo.fCacKyHieu = Me
			Me.bLoadXong = True
		End Sub

		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.btnEdit.Text, "Edit", False) = 0
			If flag Then
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
			Dim mPicSize As Size = Me.m_drawingObjects.GetSize()
			Dim flag As Boolean = Operators.CompareString(Me.Mode, "Add", False) = 0
			If flag Then
				Me.myWidth = 50
				Me.myHeight = 50
			Else
				Me.myWidth = mPicSize.Width
				Me.myHeight = mPicSize.Height
			End If
			Me.ThayDoiGrid()
			Me.pointTL = New Point(0, 0)
			Me.PictureBox1.Location = Me.pointTL
			Dim arg_123_0 As Control = Me.PictureBox1
			Dim size As Size = New Size(Me.myWidth * Me.myScale, Me.myHeight * Me.myScale)
			arg_123_0.Size = size
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
			Dim flag As Boolean = Me.myThumbNails.SelectedIndex > -1
			If flag Then
				Dim objListItem As CThumbNail = Me.myThumbNails(Me.myThumbNails.SelectedIndex)
				Me.txtTenKH.Text = objListItem.Value
				Me.txtKyHieu_ID.Text = Conversions.ToString(objListItem.ID)
				Dim strKyHieu As String = objListItem.Symbols
				Me.GetSize(strKyHieu)
				Me.m_drawingObjects = CGraphicObjs.Str2Objects(strKyHieu, 0, 0)
				Me.PictureBox2.Invalidate()
				Me.btnDelete.Enabled = True
				Me.btnNew.Enabled = True
				Me.btnEdit.Enabled = True
				Me.Mode = "Update"
			Else
				Me.m_drawingObjects = CGraphicObjs.Str2Objects("", 0, 0)
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
			Dim dragPoint As PointF = Me.gscTogoc(e.X, e.Y)
			Dim flag As Boolean = Me.bSnap
			If flag Then
				dragPoint = Me.Snap(dragPoint.X, dragPoint.Y)
			End If
			Me.StatusBarPanel4.Text = dragPoint.X.ToString() + ", " + dragPoint.Y.ToString()
			flag = (Me.m_SelectedObject IsNot Nothing)
			If flag Then
				Dim flag2 As Boolean = Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape
				If flag2 Then
					Me.mytoPt = dragPoint
					Me.m_SelectedObject.Rotate(Me.myrootPt, Me.myfromPt, Me.mytoPt)
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else
					flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape)
					If flag2 Then
						Me.mytoPt = dragPoint
						Me.m_SelectedObject.Zoom(Me.myrootPt, Me.myfromPt, Me.mytoPt)
						Me.myfromPt = Me.mytoPt
						Me.PictureBox1.Invalidate()
					Else
						flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit)
						If flag2 Then
							Me.mytoPt = dragPoint
							Me.PictureBox1.Invalidate()
						Else
							flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape)
							If flag2 Then
								Me.mytoPt = dragPoint
								Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
								Me.myfromPt = Me.mytoPt
								Me.PictureBox1.Invalidate()
							Else
								flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape)
								If flag2 Then
									Me.mytoPt = dragPoint
									Try
										Dim enumerator As IEnumerator = Me.m_EditingObjects.GetEnumerator()
										While enumerator.MoveNext()
											Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
											mObj.Move(Me.myfromPt, Me.mytoPt)
										End While
									Finally
										Dim enumerator As IEnumerator
										flag2 = (TypeOf enumerator Is IDisposable)
										If flag2 Then
											(TryCast(enumerator, IDisposable)).Dispose()
										End If
									End Try
									Me.myfromPt = Me.mytoPt
									Me.PictureBox1.Invalidate()
								Else
									flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape)
									If flag2 Then
										Me.mytoPt = dragPoint
										Try
											Dim enumerator2 As IEnumerator = Me.m_EditingObjects.GetEnumerator()
											While enumerator2.MoveNext()
												Dim mObj2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
												mObj2.Zoom(Me.myrootPt, Me.myfromPt, Me.mytoPt)
											End While
										Finally
											Dim enumerator2 As IEnumerator
											flag2 = (TypeOf enumerator2 Is IDisposable)
											If flag2 Then
												(TryCast(enumerator2, IDisposable)).Dispose()
											End If
										End Try
										Me.myfromPt = Me.mytoPt
										Me.PictureBox1.Invalidate()
									End If
								End If
							End If
						End If
					End If
				End If
			Else
				Dim flag2 As Boolean = Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape
				' The following expression was wrapped in a checked-statement
				If flag2 Then
					Me.mytoPt = dragPoint
					Try
						Dim enumerator3 As IEnumerator = Me.m_EditingObjects.GetEnumerator()
						While enumerator3.MoveNext()
							Dim mObj3 As GraphicObject = CType(enumerator3.Current, GraphicObject)
							mObj3.Move(Me.myfromPt, Me.mytoPt)
						End While
					Finally
						Dim enumerator3 As IEnumerator
						flag2 = (TypeOf enumerator3 Is IDisposable)
						If flag2 Then
							(TryCast(enumerator3, IDisposable)).Dispose()
						End If
					End Try
					Me.myfromPt = Me.mytoPt
					Me.PictureBox1.Invalidate()
				Else
					flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape)
					If flag2 Then
						Me.mytoPt = dragPoint
						Try
							Dim enumerator4 As IEnumerator = Me.m_EditingObjects.GetEnumerator()
							While enumerator4.MoveNext()
								Dim mObj4 As GraphicObject = CType(enumerator4.Current, GraphicObject)
								mObj4.Zoom(Me.myrootPt, Me.myfromPt, Me.mytoPt)
							End While
						Finally
							Dim enumerator4 As IEnumerator
							flag2 = (TypeOf enumerator4 Is IDisposable)
							If flag2 Then
								(TryCast(enumerator4, IDisposable)).Dispose()
							End If
						End Try
						Me.myfromPt = Me.mytoPt
						Me.PictureBox1.Invalidate()
					Else
						flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.ChangeRoot)
						If flag2 Then
							flag = Me.RootDragging
							If flag Then
								Me.myRootX = CInt(Math.Round(CDec(dragPoint.X)))
								flag2 = (Me.myRootX < 0)
								If flag2 Then
									Me.myRootX = 0
								End If
								flag2 = (Me.myRootX > Me.myWidth)
								If flag2 Then
									Me.myRootX = Me.myWidth
								End If
								Me.myRootY = CInt(Math.Round(CDec(dragPoint.Y)))
								flag2 = (Me.myRootY < 0)
								If flag2 Then
									Me.myRootY = 0
								End If
								flag2 = (Me.myRootY > Me.myHeight)
								If flag2 Then
									Me.myRootY = Me.myHeight
								End If
								Me.PictureBox1.Invalidate()
								Me.StatusBarPanel1.Text = "Root"
								Me.StatusBarPanel2.Text = String.Concat(New String() { "G" & ChrW(7889) & "c=(", Conversions.ToString(Me.myRootX), ",", Conversions.ToString(Me.myRootY), ") Kéo g" & ChrW(7889) & "c " & ChrW(273) & ChrW(7871) & "n v" & ChrW(7883) & " trí m" & ChrW(7899) & "i..." })
							End If
						End If
					End If
				End If
				flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode > -1)
				If flag2 Then
					Me.EditObj.MoveNodeTo(Me.iEditNode, dragPoint)
					Me.PictureBox1.Invalidate()
				End If
				flag2 = Me.DrawingDragging
				If flag2 Then
					' The following expression was wrapped in a unchecked-expression
					Me.DrawingRect.Width = CInt(Math.Round(CDec((dragPoint.X - CSng(Me.DrawingRect.X)))))
					' The following expression was wrapped in a unchecked-expression
					Me.DrawingRect.Height = CInt(Math.Round(CDec((dragPoint.Y - CSng(Me.DrawingRect.Y)))))
					Me.PictureBox1.Invalidate()
				End If
				flag2 = Me.DrawingPicking
				If flag2 Then
					Dim i As Object = Me.myPts.GetUpperBound(0)
					Me.myPts(Conversions.ToInteger(i)) = dragPoint
					Me.PictureBox1.Invalidate()
				End If
				flag2 = Me.selectionDragging
				If flag2 Then
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
					Dim mButton As ToolBarButton = CType(enumerator.Current, ToolBarButton)
					Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(mButton.Tag, pTag, False)
					If flag Then
						mButton.Pushed = True
					Else
						mButton.Pushed = False
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Public Sub PastObjectAt(pObj As GraphicObject, pt1 As PointF)
			Dim flag As Boolean = pObj IsNot Nothing
			If flag Then
				Dim mObj As GraphicObject = pObj.Clone()
				Dim arg_2A_0 As GraphicObject = mObj
				Dim fromPt As PointF = New PointF(mObj.X, mObj.Y)
				arg_2A_0.Move(fromPt, pt1)
				Me.m_drawingObjects.Add(mObj)
			End If
		End Sub

		Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
			Me.PictureBox1.[Select]()
			Dim selePT As PointF = Me.gscTogoc(e.X, e.Y)
			Dim mousePT As PointF = Me.gscTogoc(e.X, e.Y)
			Dim flag As Boolean = Me.bSnap
			If flag Then
				mousePT = Me.Snap(mousePT.X, mousePT.Y)
			End If
			' The following expression was wrapped in a checked-statement
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.None
					Dim flag2 As Boolean = (Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Shift) = Keys.Shift
					If flag2 Then
						Me.m_SelectedObject = Me.m_drawingObjects.FindObjectAtPoint(selePT)
						flag2 = (Me.m_SelectedObject IsNot Nothing)
						If flag2 Then
							Dim bCoRoi As Boolean = False
							Try
								Dim enumerator As IEnumerator = Me.m_selectedObjects.GetEnumerator()
								While enumerator.MoveNext()
									Dim mSObj As GraphicObject = CType(enumerator.Current, GraphicObject)
									flag2 = (mSObj Is Me.m_SelectedObject)
									If flag2 Then
										bCoRoi = True
									End If
								End While
							Finally
								Dim enumerator As IEnumerator
								flag2 = (TypeOf enumerator Is IDisposable)
								If flag2 Then
									(TryCast(enumerator, IDisposable)).Dispose()
								End If
							End Try
							flag2 = bCoRoi
							If flag2 Then
								Me.m_selectedObjects.Remove(Me.m_SelectedObject)
							Else
								Me.m_selectedObjects.Add(Me.m_SelectedObject)
							End If
							Me.PictureBox1.Invalidate()
						End If
					Else
						flag2 = (Me.m_selectedObjects.Count > 0)
						If flag2 Then
							Me.m_EditingObjects.Clear()
							Try
								Dim enumerator2 As IEnumerator = Me.m_selectedObjects.GetEnumerator()
								While enumerator2.MoveNext()
									Dim mObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
									Me.m_EditingObjects.Add(mObj)
								End While
							Finally
								Dim enumerator2 As IEnumerator
								flag2 = (TypeOf enumerator2 Is IDisposable)
								If flag2 Then
									(TryCast(enumerator2, IDisposable)).Dispose()
								End If
							End Try
							flag2 = ((e.Button And MouseButtons.Right) > MouseButtons.None)
							If flag2 Then
								Dim arg_49F_0 As ContextMenu = Me.MnuGroup
								Dim arg_49F_1 As Control = Me.PictureBox1
								Dim autoScrollPosition As Point = New Point(e.X, e.Y)
								arg_49F_0.Show(arg_49F_1, autoScrollPosition)
							End If
							Me.m_selectedObjects.Clear()
						Else
							flag2 = ((Control.ModifierKeys And Keys.Shift) = Keys.Shift)
							If flag2 Then
								flag = ((e.Button And MouseButtons.Left) > MouseButtons.None)
								If flag Then
									Me.selectionDragging = True
									Dim arg_50A_0 As Single = CSng(e.X)
									Dim autoScrollPosition As Point = Me.AutoScrollPosition
									Me.selectionRect.X = arg_50A_0 - CSng(autoScrollPosition.X)
									Dim arg_52D_0 As Single = CSng(e.Y)
									autoScrollPosition = Me.AutoScrollPosition
									Me.selectionRect.Y = arg_52D_0 - CSng(autoScrollPosition.Y)
									Me.selectionRect.Height = 0F
									Me.selectionRect.Width = 0F
								End If
							Else
								Me.m_SelectedObject = Me.m_drawingObjects.FindObjectAtPoint(selePT)
								Me.m_selectedObjects.Clear()
								Me.PictureBox1.Invalidate()
								flag2 = (Me.m_SelectedObject IsNot Nothing)
								If flag2 Then
									flag = ((e.Button And MouseButtons.Left) > MouseButtons.None)
									If flag Then
										Dim flag3 As Boolean = (Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt
										If flag3 Then
											Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape
											Me.myfromPt = mousePT
											Me.mytoPt = mousePT
											Me.myrootPt = New PointF(100F, 100F)
											Me.myrootPt = Me.m_SelectedObject.GetCenter()
										Else
											flag3 = ((Control.ModifierKeys And Keys.Control) = Keys.Control)
											If flag3 Then
												Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape
												Me.myfromPt = mousePT
												Me.mytoPt = mousePT
											Else
												flag3 = ((Control.ModifierKeys And Keys.Alt) = Keys.Alt)
												If flag3 Then
													Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape
													Me.myfromPt = mousePT
													Me.mytoPt = mousePT
													Me.myrootPt = Nothing
													Me.myrootPt = Me.m_SelectedObject.GetCenter()
												End If
											End If
										End If
									Else
										Dim arg_6C3_0 As ContextMenu = Me.ContextMenu2
										Dim arg_6C3_1 As Control = Me.PictureBox1
										Dim autoScrollPosition As Point = New Point(e.X, e.Y)
										arg_6C3_0.Show(arg_6C3_1, autoScrollPosition)
									End If
								Else
									Dim flag3 As Boolean = (e.Button And MouseButtons.Right) > MouseButtons.None
									If flag3 Then
										Dim arg_704_0 As ContextMenu = Me.mnuGroupAll
										Dim arg_704_1 As Control = Me.PictureBox1
										Dim autoScrollPosition As Point = New Point(e.X, e.Y)
										arg_704_0.Show(arg_704_1, autoScrollPosition)
									End If
								End If
							End If
						End If
					End If
				Case dlgCacKyHieu.VeTools.Edit
					Me.iEditNode = Me.EditObj.FindNodeAtPoint(selePT)
					flag = (Me.iEditNode > -1)
					If flag Then
						Dim flag2 As Boolean = (e.Button And MouseButtons.Right) > MouseButtons.None
						If flag2 Then
							Me.StatusBarPanel3.Text = Me.iEditNode.ToString() + "/" + Me.EditObj.GetPoints().GetUpperBound(0).ToString()
							Me.iEditNode2 = Me.iEditNode
							Dim arg_19A_0 As ContextMenu = Me.ContextMenu1
							Dim arg_19A_1 As Control = Me.PictureBox1
							Dim autoScrollPosition As Point = New Point(e.X, e.Y)
							arg_19A_0.Show(arg_19A_1, autoScrollPosition)
						End If
					Else
						Me.OnCapNhatCT()
					End If
				Case dlgCacKyHieu.VeTools.Polygon, dlgCacKyHieu.VeTools.Line, dlgCacKyHieu.VeTools.Curve, dlgCacKyHieu.VeTools.ClosedCurve
					Dim flag3 As Boolean = (e.Button And MouseButtons.Left) > MouseButtons.None
					If flag3 Then
						Dim flag2 As Boolean = Not Me.DrawingPicking
						If flag2 Then
							Me.DrawingPicking = True
							Me.myPts = New PointF(1) {}
							Me.myPts(0) = mousePT
							Me.myPts(1) = mousePT
						Else
							Dim i As Integer = Me.myPts.GetUpperBound(0)
							i += 1
							Me.myPts = CType(Utils.CopyArray(CType(Me.myPts, Array), New PointF(i + 1 - 1) {}), PointF())
							Me.myPts(i) = mousePT
						End If
					Else
						flag3 = (Me.myPts.GetUpperBound(0) > 0)
						If flag3 Then
							Me.AddNewObj()
						End If
						Me.OnCapNhatCT()
						Me.DrawingPicking = False
					End If
				Case dlgCacKyHieu.VeTools.Cycle
					Dim flag3 As Boolean = (e.Button And MouseButtons.Left) > MouseButtons.None
					If flag3 Then
						Me.DrawingDragging = True
						Me.DrawingRect.X = CInt(Math.Round(CDec(mousePT.X)))
						Me.DrawingRect.Y = CInt(Math.Round(CDec(mousePT.Y)))
						Me.DrawingRect.Height = 0
						Me.DrawingRect.Width = 0
					End If
				Case dlgCacKyHieu.VeTools.Pie
					Dim flag3 As Boolean = (e.Button And MouseButtons.Left) > MouseButtons.None
					If flag3 Then
						Me.DrawingDragging = True
						Me.DrawingRect.X = CInt(Math.Round(CDec(mousePT.X)))
						Me.DrawingRect.Y = CInt(Math.Round(CDec(mousePT.Y)))
						Me.DrawingRect.Height = 0
						Me.DrawingRect.Width = 0
					End If
				Case dlgCacKyHieu.VeTools.Text
					Me.myPts = New PointF(0) {}
					Me.myPts(0) = mousePT
					Me.AddNewObj()
					Me.OnCapNhatCT()
				Case dlgCacKyHieu.VeTools.Image
					Me.myPts = New PointF(0) {}
					Me.myPts(0) = mousePT
					Me.AddNewObj()
					Me.OnCapNhatCT()
				Case dlgCacKyHieu.VeTools.Move
					Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape
					Me.myfromPt = mousePT
					Me.mytoPt = mousePT
				Case dlgCacKyHieu.VeTools.Scale
					Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape
					Me.myfromPt = mousePT
					Me.mytoPt = mousePT
					Me.myrootPt = New PointF(100F, 100F)
					Me.myrootPt = Me.m_SelectedObject.GetCenter()
				Case dlgCacKyHieu.VeTools.Rotate
					Me.StatusBarPanel1.Text = "dang Rotate"
					Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape
					Me.myfromPt = mousePT
					Me.mytoPt = mousePT
					Me.myrootPt = Nothing
					Me.myrootPt = Me.m_SelectedObject.GetCenter()
				Case dlgCacKyHieu.VeTools.GroupMove
					Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape
					Me.myfromPt = mousePT
					Me.mytoPt = mousePT
					Me.m_selectedObjects.Clear()
					Me.m_SelectedObject = Nothing
				Case dlgCacKyHieu.VeTools.GroupScale
					Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape
					Me.myfromPt = mousePT
					Me.mytoPt = mousePT
					Me.myrootPt = New PointF(0F, 0F)
					Me.m_selectedObjects.Clear()
					Me.m_SelectedObject = Nothing
				Case dlgCacKyHieu.VeTools.Split
					Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit
					Me.myfromPt = mousePT
					Me.mytoPt = mousePT
				Case dlgCacKyHieu.VeTools.ChangeRoot
					flag = Me.RootHitTest(mousePT)
					If flag Then
						Me.RootDragging = True
					Else
						Me.OnCapNhatCT()
						Me.RootDragging = False
					End If
			End Select
		End Sub

		Private Sub AddNewObj()
			Dim gObj As GraphicObject
			Dim flag As Boolean
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.Polygon
					gObj = New PolygonGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .Fill = modBanDo.defaGenFill, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.Line
					gObj = New LinesGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.Curve
					gObj = New CurveGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.ClosedCurve
					flag = (Me.myPts.GetUpperBound(0) > 1)
					If flag Then
						gObj = New ClosedCurveGraphic(Me.myPts, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .Fill = modBanDo.defaGenFill, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle }
					End If
				Case dlgCacKyHieu.VeTools.Cycle
					gObj = New EllipseGraphic(CSng(Me.DrawingRect.Left), CSng(Me.DrawingRect.Top), CSng(Me.DrawingRect.Width), CSng(Me.DrawingRect.Height), 0F) With { .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .Fill = modBanDo.defaGenFill, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle }
				Case dlgCacKyHieu.VeTools.Pie
					flag = Me.DrawDrawingPie(Me.PictureBox1.CreateGraphics(), Me.DrawingRect)
					If flag Then
						gObj = New PieGraphic(CSng(Me.DrawingRect.Left), CSng(Me.DrawingRect.Top), CSng(Me.DrawingRect.Width), CSng(Me.DrawingRect.Height), 0F) With { .LineWidth = CSng(modBanDo.defaPiePen1W), .Fill = modBanDo.defaPieFill, .FillColor = modBanDo.defaPieFillC, .LineColor = modBanDo.defaPiePen1C, .IsArc = modBanDo.defaPieArc, .StartAngle = CSng(modBanDo.defaPieStartA), .SweepAngle = CSng(modBanDo.defaPieSweepA) }
					End If
				Case dlgCacKyHieu.VeTools.Text
					gObj = New TextGraphic(Me.myPts(0).X, Me.myPts(0).Y, "Text", modBanDo.defaTextFont, modBanDo.defaTextC) With { .Rotation = 0F, .AutoSize = True }
					gObj.Rotation = 0F
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
					flag = (openFileDialog.ShowDialog() = DialogResult.OK)
					If flag Then
						Dim mFileName As String = openFileDialog.FileName
						flag = (mFileName.Length > 0)
						If flag Then
							Try
								Dim mImage As Image = New Bitmap(mFileName)
								modBanDo.fCacKyHieu.myScale = 1
								modBanDo.fCacKyHieu.myGridWidth = 4
								Me.myWidth = mImage.Width
								Me.myHeight = mImage.Height
								Me.ThayDoiGrid()
								Me.DisplayScrollBars()
								Me.PictureBox1.Invalidate()
								Dim mType As String = "bmp"
								flag = mImage.RawFormat.Equals(ImageFormat.MemoryBmp)
								If flag Then
									mType = "kro"
								End If
								' The following expression was wrapped in a checked-expression
								gObj = New EmbeddedImageGraphic(mType, CInt(Math.Round(CDec(Me.myPts(0).X))), CInt(Math.Round(CDec(Me.myPts(0).Y))), mImage) With { .Transparent = True, .TransparentColor = Color.White }
								Dim graphicObject As GraphicObject = gObj
								graphicObject.Rotation = 0F
								graphicObject.AutoSize = False
								graphicObject.X = Me.myPts(0).X
								graphicObject.Y = Me.myPts(0).Y
								graphicObject.Width = CSng(mImage.Width)
								graphicObject.Height = CSng(mImage.Height)
								flag = (graphicObject.Width > 1500F)
								If flag Then
									graphicObject.Width = 1500F
								End If
								flag = (graphicObject.Height > 1500F)
								If flag Then
									graphicObject.Height = 1500F
								End If
							Catch expr_60E As Exception
								ProjectData.SetProjectError(expr_60E)
								ProjectData.ClearProjectError()
							End Try
						End If
					End If
			End Select
			flag = (gObj IsNot Nothing)
			If flag Then
				Me.m_drawingObjects.Add(gObj)
			End If
		End Sub

		Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs)
			Dim dragPoint As PointF = Me.gscTogoc(e.X, e.Y)
			Dim flag As Boolean = Me.bSnap
			If flag Then
				dragPoint = Me.Snap(dragPoint.X, dragPoint.Y)
			End If
			flag = (Me.m_EditingObjects.Count > 0)
			Dim flag2 As Boolean
			If flag Then
				flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape)
				If flag2 Then
					Me.m_EditingObjects.Clear()
					Me.OnCapNhatCT()
				Else
					flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScaleShape)
					If flag2 Then
						Me.m_EditingObjects.Clear()
						Me.OnCapNhatCT()
					End If
				End If
			End If
			flag2 = (Me.m_SelectedObject IsNot Nothing)
			If flag2 Then
				flag = (Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape)
				If flag Then
					Me.OnCapNhatCT()
				Else
					flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape)
					If flag2 Then
						Me.OnCapNhatCT()
					Else
						flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit)
						If flag2 Then
							Dim mSplitObjects As dlgCacKyHieu.SPLITOBJECTS = Me.To2Objects(Me.m_SelectedObject, Me.myfromPt, Me.mytoPt)
							Me.m_drawingObjects.Remove(Me.m_SelectedObject)
							flag2 = Not Information.IsNothing(mSplitObjects.Obj1)
							If flag2 Then
								Me.m_drawingObjects.Add(mSplitObjects.Obj1)
								Me.m_SelectedObject = mSplitObjects.Obj1
							End If
							flag2 = Not Information.IsNothing(mSplitObjects.Obj2)
							If flag2 Then
								Me.m_drawingObjects.Add(mSplitObjects.Obj2)
								Me.m_SelectedObject = mSplitObjects.Obj2
							End If
							Me.OnCapNhatCT()
						Else
							flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.MoveShape)
							If flag2 Then
								Me.OnCapNhatCT()
							Else
								flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupMoveShape)
								If flag2 Then
									Me.OnCapNhatCT()
								End If
							End If
						End If
					End If
				End If
			Else
				flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0)
				If flag2 Then
					Me.EditObj.Reset()
					Me.iEditNode = -1
					Me.PictureBox2.Invalidate()
				End If
			End If
			flag2 = Me.selectionDragging
			If flag2 Then
				Dim zoomedSelection As RectangleF = Me.DeZoomRectangle(Me.selectionRect)
				Me.m_selectedObjects.Clear()
				Try
					Dim enumerator As IEnumerator = Me.m_drawingObjects.GetEnumerator()
					While enumerator.MoveNext()
						Dim graphicObj As GraphicObject = CType(enumerator.Current, GraphicObject)
						flag2 = graphicObj.HitTest(zoomedSelection)
						If flag2 Then
							Me.m_SelectedObject = graphicObj
							Me.m_selectedObjects.Add(graphicObj)
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					flag2 = (TypeOf enumerator Is IDisposable)
					If flag2 Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				Me.selectionDragging = False
				Me.PictureBox1.Invalidate()
			End If
			flag2 = Me.DrawingDragging
			If flag2 Then
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
			Dim mTag As String = Conversions.ToString(e.Button.Tag)
			Me.UpdateTB(mTag)
			Dim left As String = mTag
			Dim flag As Boolean = Operators.CompareString(left, "Line", False) = 0
			If flag Then
				Me.m_DrawTool = dlgCacKyHieu.VeTools.Line
				Me.m_SelectedObject = Nothing
				Me.StatusBarPanel1.Text = "Line"
				Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
			Else
				flag = (Operators.CompareString(left, "Polygon", False) = 0)
				If flag Then
					Me.m_DrawTool = dlgCacKyHieu.VeTools.Polygon
					Me.m_SelectedObject = Nothing
					Me.StatusBarPanel1.Text = "Polygon"
					Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
				Else
					flag = (Operators.CompareString(left, "Curve", False) = 0)
					If flag Then
						Me.m_DrawTool = dlgCacKyHieu.VeTools.Curve
						Me.m_SelectedObject = Nothing
						Me.StatusBarPanel1.Text = "Curve"
						Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
					Else
						flag = (Operators.CompareString(left, "ClosedCurve", False) = 0)
						If flag Then
							Me.m_DrawTool = dlgCacKyHieu.VeTools.ClosedCurve
							Me.m_SelectedObject = Nothing
							Me.StatusBarPanel1.Text = "ClosedCurve"
							Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
						Else
							flag = (Operators.CompareString(left, "Text", False) = 0)
							If flag Then
								Me.m_DrawTool = dlgCacKyHieu.VeTools.Text
								Me.m_SelectedObject = Nothing
								Me.StatusBarPanel1.Text = "Text"
								Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n v" & ChrW(7883) & " trí Text."
							Else
								flag = (Operators.CompareString(left, "Ellipse", False) = 0)
								If flag Then
									Me.m_DrawTool = dlgCacKyHieu.VeTools.Cycle
									Me.m_SelectedObject = Nothing
									Me.StatusBarPanel1.Text = "Elippse"
									Me.StatusBarPanel2.Text = "Kéo chu" & ChrW(7897) & "t d" & ChrW(7885) & "c theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng kính " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " Ellipse"
								Else
									flag = (Operators.CompareString(left, "Pie", False) = 0)
									If flag Then
										Me.m_DrawTool = dlgCacKyHieu.VeTools.Pie
										Me.m_SelectedObject = Nothing
										Me.StatusBarPanel1.Text = "Pie"
										Me.StatusBarPanel2.Text = "Kéo chu" & ChrW(7897) & "t d" & ChrW(7885) & "c theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng kính " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " Pie"
									Else
										flag = (Operators.CompareString(left, "Edit", False) = 0)
										If flag Then
											Me.OnNodesEdit()
										Else
											flag = (Operators.CompareString(left, "Past", False) = 0)
											If flag Then
												Dim flag2 As Boolean = Me.m_CopyObject IsNot Nothing
												If flag2 Then
													Dim arg_2A7_1 As GraphicObject = Me.m_CopyObject
													Dim pt As PointF = New PointF(Me.m_CopyObject.X + 5F, Me.m_CopyObject.Y + 5F)
													Me.PastObjectAt(arg_2A7_1, pt)
													Me.PictureBox1.Invalidate()
													Me.PictureBox2.Invalidate()
												End If
											Else
												Dim flag2 As Boolean = Operators.CompareString(left, "Option", False) = 0
												If flag2 Then
													Dim f As dlgOption = New dlgOption()
													f.nudScale.Value = New Decimal(Me.myScale)
													f.nudGrid.Value = New Decimal(Me.myGridWidth)
													f.nudWidth.Value = New Decimal(Me.myWidth)
													f.nudHeight.Value = New Decimal(Me.myHeight)
													f.chkSnap.Checked = Me.bSnap
													flag2 = (f.ShowDialog(Me) = DialogResult.OK)
													If flag2 Then
														Me.myScale = Convert.ToInt32(f.nudScale.Value)
														Me.myGridWidth = Convert.ToInt32(f.nudGrid.Value)
														Me.myWidth = Convert.ToInt32(f.nudWidth.Value)
														Me.myHeight = Convert.ToInt32(f.nudHeight.Value)
														Me.ThayDoiGrid()
														Me.bSnap = f.chkSnap.Checked
													End If
													Me.DisplayScrollBars()
													Me.PictureBox1.Invalidate()
												Else
													flag2 = (Operators.CompareString(left, "Root", False) = 0)
													If flag2 Then
														Me.m_DrawTool = dlgCacKyHieu.VeTools.ChangeRoot
														flag2 = (Me.myRootX < 0)
														If flag2 Then
															Me.myRootX = 0
														End If
														flag2 = (Me.myRootX > Me.myWidth)
														If flag2 Then
															Me.myRootX = Me.myWidth
														End If
														flag2 = (Me.myRootY < 0)
														If flag2 Then
															Me.myRootY = 0
														End If
														flag2 = (Me.myRootY > Me.myHeight)
														If flag2 Then
															Me.myRootY = Me.myHeight
														End If
														Dim g As Graphics = Me.PictureBox1.CreateGraphics()
														Me.PictureBox1.Invalidate()
														Me.StatusBarPanel1.Text = "Root"
														Me.StatusBarPanel2.Text = String.Concat(New String() { "G" & ChrW(7889) & "c=(", Conversions.ToString(Me.myRootX), ",", Conversions.ToString(Me.myRootY), ") Kéo g" & ChrW(7889) & "c " & ChrW(273) & ChrW(7871) & "n v" & ChrW(7883) & " trí m" & ChrW(7899) & "i..." })
													Else
														flag2 = (Operators.CompareString(left, "Image", False) = 0)
														If flag2 Then
															Me.m_DrawTool = dlgCacKyHieu.VeTools.Image
															Me.m_SelectedObject = Nothing
															Me.StatusBarPanel1.Text = "Image"
															Me.StatusBarPanel2.Text = "Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n v" & ChrW(7883) & " trí Image."
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		Private Sub MnuAddNode_Click(sender As Object, e As EventArgs)
			Me.EditObj.InsertNode(Me.iEditNode2)
			Dim flag As Boolean = Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0
			If flag Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub MnuChangeNodeType_Click(sender As Object, e As EventArgs)
			Me.EditObj.ChangeNodeType(Me.iEditNode2)
			Dim flag As Boolean = Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0
			If flag Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub MnXoaNode_Click(sender As Object, e As EventArgs)
			Me.EditObj.RemoveNode(Me.iEditNode2)
			Dim flag As Boolean = Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit AndAlso Me.iEditNode >= 0
			If flag Then
				Me.EditObj.Reset()
				Me.iEditNode = -1
				Me.PictureBox2.Invalidate()
			End If
			Me.PictureBox1.Invalidate()
		End Sub

		Private Sub MnuChangeColor_Click(sender As Object, e As EventArgs)
			Select Case Me.m_SelectedObject.GetObjType()
				Case OBJECTTYPE.Polygon, OBJECTTYPE.Line, OBJECTTYPE.Curve, OBJECTTYPE.ClosedCurve, OBJECTTYPE.Cycle, OBJECTTYPE.Ellipse
					Dim f As dlgChangeColor = New dlgChangeColor()
					Dim myObj As ShapeGraphic = CType(Me.m_SelectedObject, ShapeGraphic)
					Dim shapeGraphic As ShapeGraphic = myObj
					f.txtColor.BackColor = shapeGraphic.LineColor
					f.txtColor2.BackColor = shapeGraphic.Line2Color
					f.txtDashValues.Text = shapeGraphic.DValues
					f.nudPenWidth.Value = New Decimal(shapeGraphic.LineWidth)
					f.nudPenWidth2.Value = New Decimal(shapeGraphic.Line2Width)
					f.nudLineStyle.Value = New Decimal(shapeGraphic.LineStyle)
					f.nudStyleWidth.Value = New Decimal(shapeGraphic.StyleWidth)
					f.chkBrush.Checked = myObj.Fill
					Dim flag As Boolean = f.chkBrush.Checked
					If flag Then
						f.txtBrushColor.BackColor = Color.FromArgb(255, CInt(shapeGraphic.FillColor.R), CInt(shapeGraphic.FillColor.G), CInt(shapeGraphic.FillColor.B))
						f.nudAlpha.Value = New Decimal(CInt(shapeGraphic.FillColor.A))
						f.txtHatchColor.BackColor = Color.FromArgb(255, CInt(shapeGraphic.HatchColor.R), CInt(shapeGraphic.HatchColor.G), CInt(shapeGraphic.HatchColor.B))
						f.nudHStyle.Value = New Decimal(shapeGraphic.HatchStyle)
					End If
					flag = (f.ShowDialog(Me) = DialogResult.OK)
					If flag Then
						Dim shapeGraphic2 As ShapeGraphic = myObj
						shapeGraphic2.LineColor = f.txtColor.BackColor
						shapeGraphic2.LineWidth = Convert.ToSingle(f.nudPenWidth.Value)
						shapeGraphic2.Line2Color = f.txtColor2.BackColor
						shapeGraphic2.Line2Width = Convert.ToSingle(f.nudPenWidth2.Value)
						shapeGraphic2.DValues = f.txtDashValues.Text
						shapeGraphic2.LineStyle = Convert.ToInt32(f.nudLineStyle.Value)
						shapeGraphic2.StyleWidth = Convert.ToSingle(f.nudStyleWidth.Value)
						flag = f.chkBrush.Checked
						If flag Then
							shapeGraphic2.Fill = True
							shapeGraphic2.FillColor = Color.FromArgb(Convert.ToInt32(f.nudAlpha.Value), f.txtBrushColor.BackColor)
							shapeGraphic2.HatchColor = f.txtHatchColor.BackColor
							shapeGraphic2.HatchStyle = Convert.ToInt32(f.nudHStyle.Value)
						Else
							shapeGraphic2.Fill = False
						End If
					End If
					Me.PictureBox1.Invalidate()
					Me.PictureBox2.Invalidate()
				Case OBJECTTYPE.Pie
					Dim f2 As dlgChangePie = New dlgChangePie()
					Dim myObj2 As PieGraphic = CType(Me.m_SelectedObject, PieGraphic)
					f2.nudStartAngle.Value = New Decimal(myObj2.StartAngle)
					f2.nudSweepAngle.Value = New Decimal(myObj2.SweepAngle)
					f2.chkArc.Checked = myObj2.IsArc
					f2.txtColor.BackColor = myObj2.LineColor
					f2.txtColor2.BackColor = myObj2.Line2Color
					f2.txtDashValues.Text = myObj2.DValues
					f2.nudPenWidth.Value = New Decimal(myObj2.LineWidth)
					f2.nudPenWidth2.Value = New Decimal(myObj2.Line2Width)
					f2.chkBrush.Checked = myObj2.Fill
					Dim flag As Boolean = f2.chkBrush.Checked
					If flag Then
						f2.txtBrushColor.BackColor = Color.FromArgb(255, CInt(myObj2.FillColor.R), CInt(myObj2.FillColor.G), CInt(myObj2.FillColor.B))
						f2.nudAlpha.Value = New Decimal(CInt(myObj2.FillColor.A))
						f2.txtHatchColor.BackColor = Color.FromArgb(255, CInt(myObj2.HatchColor.R), CInt(myObj2.HatchColor.G), CInt(myObj2.HatchColor.B))
						f2.txtHStyle.Text = Conversions.ToString(myObj2.HatchStyle)
					End If
					flag = (f2.ShowDialog(Me) = DialogResult.OK)
					If flag Then
						myObj2.StartAngle = Convert.ToSingle(f2.nudStartAngle.Value)
						myObj2.SweepAngle = Convert.ToSingle(f2.nudSweepAngle.Value)
						flag = f2.chkArc.Checked
						If flag Then
							myObj2.IsArc = True
						Else
							myObj2.IsArc = False
						End If
						myObj2.LineColor = f2.txtColor.BackColor
						myObj2.LineWidth = Convert.ToSingle(f2.nudPenWidth.Value)
						myObj2.Line2Color = f2.txtColor2.BackColor
						myObj2.Line2Width = Convert.ToSingle(f2.nudPenWidth2.Value)
						myObj2.DValues = f2.txtDashValues.Text
						flag = f2.chkBrush.Checked
						If flag Then
							myObj2.Fill = True
							myObj2.FillColor = Color.FromArgb(Convert.ToInt32(f2.nudAlpha.Value), f2.txtBrushColor.BackColor)
							myObj2.HatchColor = f2.txtHatchColor.BackColor
							' The following expression was wrapped in a checked-expression
							myObj2.HatchStyle = CInt(Math.Round(Conversion.Val(f2.txtHStyle.Text)))
						Else
							myObj2.Fill = False
						End If
					End If
					Me.PictureBox1.Invalidate()
					Me.PictureBox2.Invalidate()
				Case OBJECTTYPE.Text
					Dim f3 As dlgChangeLabel = New dlgChangeLabel()
					Dim myObj3 As TextGraphic = CType(Me.m_SelectedObject, TextGraphic)
					f3.txtLabel.Text = myObj3.Text
					f3.txtLabel.Font = myObj3.Font
					f3.txtLabel.ForeColor = myObj3.Color
					Dim flag As Boolean = f3.ShowDialog(Me) = DialogResult.OK
					If flag Then
						myObj3.Text = f3.txtLabel.Text
						myObj3.Font = f3.txtLabel.Font
						myObj3.Color = f3.txtLabel.ForeColor
					End If
					Me.PictureBox1.Invalidate()
					Me.PictureBox2.Invalidate()
				Case OBJECTTYPE.EmbeddedImage
					Dim mImage As EmbeddedImageGraphic = CType(Me.m_SelectedObject, EmbeddedImageGraphic)
					Dim f4 As dlgChangeImage = New dlgChangeImage()
					f4.chkTransparent.Checked = mImage.Transparent
					f4.txtTransparentColor.BackColor = mImage.TransparentColor
					Dim flag As Boolean = f4.ShowDialog(Me) = DialogResult.OK
					If flag Then
						mImage.Transparent = f4.chkTransparent.Checked
						mImage.TransparentColor = f4.txtTransparentColor.BackColor
					End If
			End Select
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
			Dim mPicSize As Size = Me.m_drawingObjects.GetSize()
			Me.myWidth = mPicSize.Width
			Me.myHeight = mPicSize.Height
			Dim flag As Boolean = Me.myRootX < 0 Or Me.myRootX > Me.myWidth
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.myRootX = CInt(Math.Round(CDec(Me.myWidth) / 2.0))
			End If
			flag = (Me.myRootY < 0 Or Me.myRootY > Me.myHeight)
			If flag Then
				Me.myRootY = CInt(Math.Round(CDec(Me.myHeight) / 2.0))
			End If
			flag = (Operators.CompareString(Me.Mode, "Add", False) = 0)
			If flag Then
				Dim flag2 As Boolean = Me.AddKyHieu()
				If flag2 Then
					Me.myThumbNails.SelectedIndex = Me.myThumbNails.Count - 1
				End If
			Else
				Dim flag2 As Boolean = Me.UpdateKyHieu()
				If flag2 Then
					Me.picThumbNails.Invalidate()
				End If
			End If
		End Sub

		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.OnUpdate()
			Me.myThumbNails_SelectedIndexChanged(Nothing)
		End Sub

		Private Function CreateKHTable() As DataTable
			Dim mDataTable As DataTable = New DataTable("MyDataTable")
			Dim mDataColumn As DataColumn = New DataColumn()
			mDataColumn.DataType = Type.[GetType]("System.Int32")
			mDataColumn.ColumnName = "KH_ID"
			mDataTable.Columns.Add(mDataColumn)
			mDataColumn = New DataColumn()
			mDataColumn.DataType = Type.[GetType]("System.String")
			mDataColumn.ColumnName = "TenKH"
			mDataTable.Columns.Add(mDataColumn)
			Return mDataTable
		End Function

		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.myThumbNails.SelectedIndex > -1
			If flag Then
				Dim mIndex As Integer = Me.myThumbNails.SelectedIndex
				Me.DeleteKyHieu(Me.myThumbNails(mIndex))
				flag = (mIndex >= Me.myThumbNails.Count)
				If flag Then
					' The following expression was wrapped in a checked-expression
					Me.myThumbNails.SelectedIndex = mIndex - 1
				End If
				Me.myThumbNails_SelectedIndexChanged(Nothing)
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
			Dim flag As Boolean = Not Me.IsValidForm()
			' The following expression was wrapped in a checked-statement
			Dim AddKyHieu As Boolean
			If flag Then
				AddKyHieu = False
			Else
				Dim mStt As Object = Me.GetMaxStt(CInt(modBanDo.myLoaiKH_ID)) + 1
				Dim mKyHieu As String = Me.Objects2String(Me.myWidth, Me.myHeight, Me.myRootX, Me.myRootY, Me.m_drawingObjects)
				AddKyHieu = Me.AddKyHieu(mKyHieu, Me.txtTenKH.Text, CInt(modBanDo.myLoaiKH_ID), Conversions.ToInteger(mStt))
			End If
			Return AddKyHieu
		End Function

		Private Function AddKyHieu(pKH As String, pTenKH As String, pLoaiKH_ID As Integer, pStt As Integer) As Boolean
			Dim bKQ As Boolean = False
			Dim flag As Boolean
			Dim mLastKH_ID As Integer
			Try
				Dim strSQL As String = "INSERT INTO tblKyHieu "
				strSQL += "(LoaiKH_ID"
				strSQL += ", TenKH"
				strSQL += ", KyHieu, Stt)"
				strSQL += " VALUES (?, ?, ?, ?)"
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				cmSQL.Parameters.Add(New OleDbParameter("LoaiKH_ID", OleDbType.[Integer], 0, "LoaiKH_ID"))
				cmSQL.Parameters.Add(New OleDbParameter("TenKH", OleDbType.VarWChar, 50, "TenKH"))
				cmSQL.Parameters.Add(New OleDbParameter("KyHieu", OleDbType.VarWChar, 0, "KyHieu"))
				cmSQL.Parameters.Add(New OleDbParameter("Stt", OleDbType.[Integer], 0, "Stt"))
				cmSQL.Parameters("LoaiKH_ID").Value = pLoaiKH_ID
				cmSQL.Parameters("TenKH").Value = pTenKH
				cmSQL.Parameters("KyHieu").Value = pKH
				cmSQL.Parameters("Stt").Value = pStt
				flag = (cmSQL.ExecuteNonQuery() = 1)
				If flag Then
					cmSQL.CommandText = "SELECT @@IDENTITY AS 'Identity'"
					mLastKH_ID = Conversions.ToInteger(cmSQL.ExecuteScalar())
				End If
				cnSQL.Close()
				cmSQL.Dispose()
				cnSQL.Dispose()
				bKQ = True
			Catch expr_185 As OleDbException
				ProjectData.SetProjectError(expr_185)
				Dim Exp As OleDbException = expr_185
				Interaction.MsgBox(Exp.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_1A9 As Exception
				ProjectData.SetProjectError(expr_1A9)
				Dim Exp2 As Exception = expr_1A9
				Interaction.MsgBox(Exp2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			flag = bKQ
			If flag Then
				Dim flag2 As Boolean = CLng(pLoaiKH_ID) = modBanDo.myLoaiKH_ID
				If flag2 Then
					Dim aThumbnail As CThumbNail = New CThumbNail(pTenKH, mLastKH_ID, pKH)
					Me.myThumbNails.Add(aThumbnail)
					Me.myThumbNails.CalculateRowsAndColumns()
					Me.picThumbNails.Invalidate()
				End If
			End If
			Return bKQ
		End Function

		Private Function IsValidForm() As Boolean
			Dim flag As Boolean = Me.txtTenKH.Text.Length > 0
			Dim IsValidForm As Boolean
			If flag Then
				IsValidForm = True
			Else
				Interaction.MsgBox("Ten Ky Hieu Sai.", MsgBoxStyle.Exclamation, Me.Text)
				IsValidForm = False
			End If
			Return IsValidForm
		End Function

		Private Function UpdateKyHieu() As Boolean
			Dim bKQ As Boolean = False
			Dim flag As Boolean = Not Me.IsValidForm()
			Dim UpdateKyHieu As Boolean
			If flag Then
				UpdateKyHieu = False
			Else
				Dim mKyHieu As String = Me.Objects2String(Me.myWidth, Me.myHeight, Me.myRootX, Me.myRootY, Me.m_drawingObjects)
				Me.myThumbNails(Me.myThumbNails.SelectedIndex).Symbols = mKyHieu
				Me.myThumbNails(Me.myThumbNails.SelectedIndex).Value = Me.txtTenKH.Text
				Dim strSQL As String = ""
				Try
					strSQL = "UPDATE tblKyHieu SET"
					strSQL += " TenKH = ?"
					strSQL += ", KyHieu = ?"
					strSQL += " WHERE KH_ID = ?"
					Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
					cnSQL.Open()
					Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
					cmSQL.Parameters.Add(New OleDbParameter("TenKH", OleDbType.VarWChar, 50, "TenKH"))
					cmSQL.Parameters.Add(New OleDbParameter("KyHieu", OleDbType.VarWChar, 0, "KyHieu"))
					cmSQL.Parameters.Add(New OleDbParameter("Original_KH_ID", OleDbType.[Integer], 0, ParameterDirection.Input, False, 10, 0, "KH_ID", DataRowVersion.Original, Nothing))
					cmSQL.Parameters("TenKH").Value = Me.txtTenKH.Text
					cmSQL.Parameters("KyHieu").Value = mKyHieu
					cmSQL.Parameters("Original_KH_ID").Value = Me.myThumbNails(Me.myThumbNails.SelectedIndex).ID
					Dim intRowsAffected As Integer = cmSQL.ExecuteNonQuery()
					flag = (intRowsAffected <> 1)
					If flag Then
						Interaction.MsgBox("Update Failed.", MsgBoxStyle.Critical, "Update")
					End If
					cnSQL.Close()
					cmSQL.Dispose()
					cnSQL.Dispose()
					bKQ = True
				Catch expr_1F5 As OleDbException
					ProjectData.SetProjectError(expr_1F5)
					Dim e As OleDbException = expr_1F5
					Interaction.MsgBox(strSQL, MsgBoxStyle.OkOnly, Nothing)
					Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "SQL Error")
					ProjectData.ClearProjectError()
				Catch expr_223 As Exception
					ProjectData.SetProjectError(expr_223)
					Dim e2 As Exception = expr_223
					Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
					ProjectData.ClearProjectError()
				End Try
				UpdateKyHieu = bKQ
			End If
			Return UpdateKyHieu
		End Function

		Public Sub DeleteKyHieu(aThumbNail As CThumbNail)
			Dim bKQ As Boolean = False
			Dim flag As Boolean
			Try
				Dim strSQL As String = "DELETE FROM tblKyHieu WHERE KH_ID = " + Conversions.ToString(aThumbNail.ID)
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				Dim intRowsAffected As Integer = cmSQL.ExecuteNonQuery()
				flag = (intRowsAffected <> 1)
				If flag Then
					Interaction.MsgBox("Delete Failed. KyHieu ID " + Conversions.ToString(aThumbNail.ID) + " not found.", MsgBoxStyle.Critical, "Delete")
				Else
					bKQ = True
				End If
				cnSQL.Close()
				cmSQL.Dispose()
				cnSQL.Dispose()
			Catch expr_8F As OleDbException
				ProjectData.SetProjectError(expr_8F)
				Dim e As OleDbException = expr_8F
				Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_B3 As Exception
				ProjectData.SetProjectError(expr_B3)
				Dim e2 As Exception = expr_B3
				Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			flag = bKQ
			If flag Then
				Me.myThumbNails.Remove(aThumbNail)
				Me.myThumbNails.CalculateRowsAndColumns()
				Me.picThumbNails.Invalidate()
			End If
		End Sub

		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Try
				Dim g As Graphics = e.Graphics
				ControlPaint.DrawGrid(g, Me.GridRect, Me.GridSize, Color.Red)
				Dim drawingObjects As CGraphicObjs = Me.m_drawingObjects
				drawingObjects.DrawObjects(g, CSng(Me.myScale))
				drawingObjects.DrawSelectedObject(g, Me.m_SelectedObject, CSng(Me.myScale))
				Dim flag As Boolean = Me.m_DrawTool = dlgCacKyHieu.VeTools.RotateShape
				If flag Then
					Me.DrawMuiTen(g)
				End If
				flag = (Me.m_DrawTool = dlgCacKyHieu.VeTools.ScaleShape)
				If flag Then
					Me.DrawMuiTen(g)
				End If
				flag = (Me.m_DrawTool = dlgCacKyHieu.VeTools.DangSplit)
				If flag Then
					Me.DrawSplitLine(g)
				End If
				flag = Me.selectionDragging
				If flag Then
					Me.DrawSelectionRectangle(g, Me.selectionRect)
				End If
				flag = Me.DrawingDragging
				Dim flag2 As Boolean
				If flag Then
					flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.Cycle)
					If flag2 Then
						Me.DrawDrawingEllipse(g, Me.DrawingRect)
					Else
						flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.Pie)
						If flag2 Then
							Me.DrawDrawingPie(g, Me.DrawingRect)
						End If
					End If
				End If
				flag2 = Me.DrawingPicking
				If flag2 Then
					flag = (Me.myPts.GetUpperBound(0) > 0)
					If flag Then
						Me.DrawDrawingLine(g, Me.myPts)
					End If
				End If
				flag2 = (Me.m_selectedObjects.Count > 0)
				If flag2 Then
					Try
						Dim enumerator As IEnumerator = Me.m_selectedObjects.GetEnumerator()
						While enumerator.MoveNext()
							Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
							Me.m_selectedObjects.DrawSelectedObject(g, mObj, CSng(Me.myScale))
						End While
					Finally
						Dim enumerator As IEnumerator
						flag2 = (TypeOf enumerator Is IDisposable)
						If flag2 Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
				End If
				flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.Edit)
				If flag2 Then
					Me.DrawEditNodes(g)
				End If
				flag2 = (Me.m_DrawTool = dlgCacKyHieu.VeTools.ChangeRoot)
				If flag2 Then
					Dim arg_1EB_1 As Graphics = g
					Dim pPt As PointF = New PointF(CSng(Me.myRootX), CSng(Me.myRootY))
					Me.DrawDrawingRoot(arg_1EB_1, pPt)
				End If
			Catch expr_1F4 As Exception
				ProjectData.SetProjectError(expr_1F4)
				Dim ex As Exception = expr_1F4
				Throw New ApplicationException("Error Drawing Graphics Surface", ex)
			End Try
		End Sub

		Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs)
			Dim g As Graphics = e.Graphics
			Me.m_drawingObjects.DrawObjects(g, 1F)
		End Sub

		Public Sub SetScrollBarValues(pImageSize As Size)
			Me.VScrollBar1.Minimum = 0
			Me.HScrollBar1.Minimum = 0
			Me.VScrollBar1.Maximum = 0
			Me.HScrollBar1.Maximum = 0
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = pImageSize.Width - Me.Panel2.ClientSize.Width > 0
			If flag Then
				Me.HScrollBar1.Maximum = pImageSize.Width - Me.Panel2.ClientSize.Width
			End If
			flag = Me.VScrollBar1.Visible
			Dim hScrollBar As HScrollBar
			If flag Then
				hScrollBar = Me.HScrollBar1
				hScrollBar.Maximum += Me.VScrollBar1.Width
			End If
			Me.HScrollBar1.LargeChange = CInt(Math.Round(CDec((Me.HScrollBar1.Maximum * Me.Panel2.ClientSize.Width)) / CDec(pImageSize.Width)))
			Me.HScrollBar1.SmallChange = CInt(Math.Round(CDec(Me.HScrollBar1.Maximum) / 20.0))
			hScrollBar = Me.HScrollBar1
			hScrollBar.Maximum += Me.HScrollBar1.LargeChange
			flag = (pImageSize.Height - Me.Panel2.ClientSize.Height > 0)
			If flag Then
				Me.VScrollBar1.Maximum = pImageSize.Height - Me.Panel2.ClientSize.Height
			End If
			flag = Me.HScrollBar1.Visible
			Dim vScrollBar As VScrollBar
			If flag Then
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
			Dim flag As Boolean = Me.PictureBox1.Visible
			' The following expression was wrapped in a checked-statement
			Dim clientSize As Size
			If flag Then
				Me.PictureBox1.Location = Me.pointTL
				Dim arg_82_0 As Control = Me.PictureBox1
				clientSize = New Size(Me.myWidth * Me.myScale, Me.myHeight * Me.myScale)
				arg_82_0.Size = clientSize
				flag = (Me.Panel2.Width > Me.PictureBox1.Width)
				If flag Then
					Me.HScrollBar1.Visible = False
				Else
					Me.HScrollBar1.Visible = True
				End If
				flag = (Me.Panel2.Height > Me.PictureBox1.Height)
				If flag Then
					Me.VScrollBar1.Visible = False
				Else
					Me.VScrollBar1.Visible = True
				End If
				flag = Me.VScrollBar1.Visible
				If flag Then
					Dim arg_130_0 As Control = Me.HScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_130_0.Width = clientSize.Width - Me.VScrollBar1.Width
				Else
					Dim arg_152_0 As Control = Me.HScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_152_0.Width = clientSize.Width
				End If
				flag = Me.HScrollBar1.Visible
				If flag Then
					Dim arg_18D_0 As Control = Me.VScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_18D_0.Height = clientSize.Height - Me.HScrollBar1.Height
				Else
					Dim arg_1AF_0 As Control = Me.VScrollBar1
					clientSize = Me.Panel2.ClientSize
					arg_1AF_0.Height = clientSize.Height
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
			Dim myNewPoint As PointF
			myNewPoint.X = CSng((CInt(Math.Round(CDec(gsPT.X) / CDec(Me.myScale)))))
			myNewPoint.Y = CSng((CInt(Math.Round(CDec(gsPT.Y) / CDec(Me.myScale)))))
			Return myNewPoint
		End Function

		Private Function gscTogoc(X As Integer, Y As Integer) As PointF
			' The following expression was wrapped in a checked-statement
			Dim myNewPoint As PointF
			myNewPoint.X = CSng((CInt(Math.Round(CDec(X) / CDec(Me.myScale)))))
			myNewPoint.Y = CSng((CInt(Math.Round(CDec(Y) / CDec(Me.myScale)))))
			Return myNewPoint
		End Function

		Private Sub DrawSelectionRectangle(g As Graphics, selectionRect As RectangleF)
			Dim selectionBrush As SolidBrush = New SolidBrush(Color.FromArgb(75, Color.Gray))
			Dim normalizedRectangle As RectangleF
			normalizedRectangle.Size = selectionRect.Size
			Dim flag As Boolean = selectionRect.Width < 0F
			If flag Then
				normalizedRectangle.X = selectionRect.X - normalizedRectangle.Width
			Else
				normalizedRectangle.X = selectionRect.X
			End If
			flag = (selectionRect.Height < 0F)
			If flag Then
				normalizedRectangle.Y = selectionRect.Y - normalizedRectangle.Height
			Else
				normalizedRectangle.Y = selectionRect.Y
			End If
			g.FillRectangle(selectionBrush, normalizedRectangle)
		End Sub

		Private Sub DrawDrawingRectangle(g As Graphics, DrawingRect As Rectangle)
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			Dim normalizedRectangle As Rectangle
			normalizedRectangle.Size = DrawingRect.Size
			Dim flag As Boolean = DrawingRect.Width < 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				normalizedRectangle.X = DrawingRect.X - normalizedRectangle.Width
			Else
				normalizedRectangle.X = DrawingRect.X
			End If
			flag = (DrawingRect.Height < 0)
			If flag Then
				normalizedRectangle.Y = DrawingRect.Y - normalizedRectangle.Height
			Else
				normalizedRectangle.Y = DrawingRect.Y
			End If
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawRectangle(DrawingPen, normalizedRectangle)
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
		End Sub

		Private Function DrawDrawingPie(g As Graphics, DrawingRect As Rectangle) As Boolean
			Dim mKQ As Boolean = False
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			' The following expression was wrapped in a checked-expression
			Dim mRect As Rectangle = New Rectangle(DrawingRect.Left - DrawingRect.Width, DrawingRect.Top - DrawingRect.Height, DrawingRect.Width * 2, DrawingRect.Height * 2)
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			Try
				Dim defaPieArc As Boolean = modBanDo.defaPieArc
				If defaPieArc Then
					g.DrawArc(DrawingPen, mRect, CSng(modBanDo.defaPieStartA), CSng(modBanDo.defaPieSweepA))
				Else
					g.DrawPie(DrawingPen, mRect, CSng(modBanDo.defaPieStartA), CSng(modBanDo.defaPieSweepA))
				End If
				mKQ = True
			Catch arg_BE_0 As Exception
				ProjectData.SetProjectError(arg_BE_0)
				ProjectData.ClearProjectError()
			End Try
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
			Return mKQ
		End Function

		Private Sub DrawDrawingEllipse(g As Graphics, DrawingRect As Rectangle)
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawEllipse(DrawingPen, DrawingRect)
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
		End Sub

		Private Sub DrawDrawingLine(g As Graphics, pPts As PointF())
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			Select Case Me.m_DrawTool
				Case dlgCacKyHieu.VeTools.Polygon
					g.DrawPolygon(DrawingPen, pPts)
				Case dlgCacKyHieu.VeTools.Line
					g.DrawLines(DrawingPen, pPts)
				Case dlgCacKyHieu.VeTools.Curve
					g.DrawCurve(DrawingPen, pPts)
				Case dlgCacKyHieu.VeTools.ClosedCurve
					Dim flag As Boolean = pPts.GetUpperBound(0) > 1
					If flag Then
						g.DrawClosedCurve(DrawingPen, pPts)
					Else
						g.DrawLines(DrawingPen, pPts)
					End If
			End Select
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
		End Sub

		Private Sub DrawEditNodes(g As Graphics)
			Dim gCon As GraphicsContainer = g.BeginContainer()
			Try
				g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
				Me.EditObj.DrawNodes(g)
			Catch arg_2D_0 As Exception
				ProjectData.SetProjectError(arg_2D_0)
				ProjectData.ClearProjectError()
			End Try
			g.EndContainer(gCon)
		End Sub

		Private Sub DrawMuiTen(g As Graphics)
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			DrawingPen.EndCap = LineCap.ArrowAnchor
			DrawingPen.StartCap = LineCap.RoundAnchor
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawLine(DrawingPen, Me.myrootPt, Me.mytoPt)
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
		End Sub

		Private Sub DrawSplitLine(g As Graphics)
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 1F)
			DrawingPen.EndCap = LineCap.ArrowAnchor
			DrawingPen.StartCap = LineCap.RoundAnchor
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawLine(DrawingPen, Me.myfromPt, Me.mytoPt)
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
		End Sub

		Protected Function DeZoomRectangle(originalRect As RectangleF) As RectangleF
			Dim myNewRect As RectangleF = New RectangleF(originalRect.X / CSng(Me.myScale), originalRect.Y / CSng(Me.myScale), originalRect.Width / CSng(Me.myScale), originalRect.Height / CSng(Me.myScale))
			Return myNewRect
		End Function

		Public Sub OnNodesEdit()
			Dim flag As Boolean = Me.m_SelectedObject IsNot Nothing
			If flag Then
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

		Private Sub myThumbNails_SelectedIndexChanged(e As EventArgs)
			Me.PopulateForm()
			Dim mTyle As Single = myModule.fMain.GetTyleLayKH()
			Me.m_OdrawingObjects = Me.GetTyLeGObjs(Me.m_drawingObjects, mTyle)
			' The following expression was wrapped in a checked-statement
			Me.myORootX = CInt(Math.Round(CDec((CSng(Me.myRootX) * mTyle))))
			Me.myORootY = CInt(Math.Round(CDec((CSng(Me.myRootY) * mTyle))))
		End Sub

		Private Sub DBiCombo1_DaChon1(IdValue As Long, TxtValue As String)
			modBanDo.myLoaiKH_ID = IdValue
			' The following expression was wrapped in a checked-expression
			Me.PopulateList(CInt(modBanDo.myLoaiKH_ID))
			Me.PopulateForm()
		End Sub

		Private Function GetTyLeGObjs(pGObjs As CGraphicObjs, pTyle As Single) As CGraphicObjs
			Dim mGObjects As CGraphicObjs = New CGraphicObjs()
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim oGObj As GraphicObject = aGObj.Clone()
					Select Case oGObj.GetObjType()
						Case OBJECTTYPE.Ellipse, OBJECTTYPE.Pie
							Dim mShape As ShapeGraphic = CType(oGObj, ShapeGraphic)
							Dim shapeGraphic As ShapeGraphic = mShape
							Dim shapeGraphic2 As ShapeGraphic = shapeGraphic
							shapeGraphic2.Width *= pTyle
							shapeGraphic2 = shapeGraphic
							shapeGraphic2.Height *= pTyle
							shapeGraphic2 = shapeGraphic
							shapeGraphic2.X *= pTyle
							shapeGraphic2 = shapeGraphic
							shapeGraphic2.Y *= pTyle
						Case OBJECTTYPE.Text
							Dim mShape2 As TextGraphic = CType(oGObj, TextGraphic)
							Dim textGraphic As TextGraphic = mShape2
							Dim textGraphic2 As TextGraphic = textGraphic
							textGraphic2.Width *= pTyle
							textGraphic2 = textGraphic
							textGraphic2.Height *= pTyle
							textGraphic2 = textGraphic
							textGraphic2.X *= pTyle
							textGraphic2 = textGraphic
							textGraphic2.Y *= pTyle
							Dim StringFont As Font = New Font(textGraphic.Font.Name, textGraphic.Font.Size * pTyle, textGraphic.Font.Style, textGraphic.Font.Unit)
							textGraphic.Font = StringFont
						Case OBJECTTYPE.Table
						Case OBJECTTYPE.EmbeddedImage
							Dim mShape3 As EmbeddedImageGraphic = CType(oGObj, EmbeddedImageGraphic)
							Dim embeddedImageGraphic As EmbeddedImageGraphic = mShape3
							Dim embeddedImageGraphic2 As EmbeddedImageGraphic = embeddedImageGraphic
							embeddedImageGraphic2.Width *= pTyle
							embeddedImageGraphic2 = embeddedImageGraphic
							embeddedImageGraphic2.Height *= pTyle
							embeddedImageGraphic2 = embeddedImageGraphic
							embeddedImageGraphic2.X *= pTyle
							embeddedImageGraphic2 = embeddedImageGraphic
							embeddedImageGraphic2.Y *= pTyle
						Case Else
							Try
								Dim mShape4 As NodesShapeGraphic = CType(oGObj, NodesShapeGraphic)
								Dim nodesShapeGraphic As NodesShapeGraphic = mShape4
								Dim nodesShapeGraphic2 As NodesShapeGraphic = nodesShapeGraphic
								nodesShapeGraphic2.Width *= pTyle
								nodesShapeGraphic2 = nodesShapeGraphic
								nodesShapeGraphic2.Height *= pTyle
								nodesShapeGraphic2 = nodesShapeGraphic
								nodesShapeGraphic2.X *= pTyle
								nodesShapeGraphic2 = nodesShapeGraphic
								nodesShapeGraphic2.Y *= pTyle
								Try
									Dim enumerator2 As IEnumerator = mShape4.Nodes.GetEnumerator()
									While enumerator2.MoveNext()
										Dim aNode As CNODE = CType(enumerator2.Current, CNODE)
										Dim cNODE As CNODE = aNode
										cNODE.X *= pTyle
										cNODE = aNode
										cNODE.Y *= pTyle
									End While
								Finally
									Dim enumerator2 As IEnumerator
									Dim flag As Boolean = TypeOf enumerator2 Is IDisposable
									If flag Then
										(TryCast(enumerator2, IDisposable)).Dispose()
									End If
								End Try
							Catch expr_2C4 As Exception
								ProjectData.SetProjectError(expr_2C4)
								ProjectData.ClearProjectError()
							End Try
					End Select
					mGObjects.Add(oGObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return mGObjects
		End Function

		Private Sub mnuFlip_Click(sender As Object, e As EventArgs)
			Dim mRect As RectangleF = Me.m_SelectedObject.GetBounds()
			Dim mX0 As Single = (mRect.Left + mRect.Right) / 2F
			Me.m_SelectedObject.VFlip(mX0)
			Me.PictureBox1.Invalidate()
			Me.PictureBox2.Invalidate()
		End Sub

		Private Sub mnuClosedCurveToCurve_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_SelectedObject.GetObjType() = OBJECTTYPE.ClosedCurve
			If flag Then
				Me.m_drawingObjects.MoClosedCurve(Me.m_SelectedObject)
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			Else
				Interaction.MsgBox("Chi lam duoc voi ClosedCurve thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub mnuCurveToClosedCurve_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_SelectedObject.GetObjType() = OBJECTTYPE.Curve
			If flag Then
				Me.m_drawingObjects.DongCurve(Me.m_SelectedObject)
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			Else
				Interaction.MsgBox("Chi lam duoc voi Curve thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub mnu1stNode_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.EditObj.GetObjType() = OBJECTTYPE.ClosedCurve
			If flag Then
				Dim mCCurve As ClosedCurveGraphic = CType(Me.EditObj, ClosedCurveGraphic)
				mCCurve.To1stNode(Me.iEditNode2)
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			Else
				Interaction.MsgBox("Chi lam duoc voi ClosedCurve thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub cmnuKichThuoc_Click(sender As Object, e As EventArgs)
			Dim f As dlgThumbnailOption = New dlgThumbnailOption()
			f.txtImageWidth.Text = Conversions.ToString(Me.myThumbNails.ImageWidth)
			f.txtImageHeight.Text = Conversions.ToString(Me.myThumbNails.ImageHeight)
			f.txtHorizontalSpacing.Text = Conversions.ToString(Me.myThumbNails.HorizontalSpacing)
			f.txtVerticalSpacing.Text = Conversions.ToString(Me.myThumbNails.VerticalSpacing)
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Try
					Me.myThumbNails.ImageWidth = Conversions.ToInteger(f.txtImageWidth.Text)
					Me.myThumbNails.ImageHeight = Conversions.ToInteger(f.txtImageHeight.Text)
					Me.myThumbNails.HorizontalSpacing = Conversions.ToInteger(f.txtHorizontalSpacing.Text)
					Me.myThumbNails.VerticalSpacing = Conversions.ToInteger(f.txtVerticalSpacing.Text)
					' The following expression was wrapped in a checked-expression
					Me.PopulateList(CInt(modBanDo.myLoaiKH_ID))
					modBanDo.defaImageWidth = Me.myThumbNails.ImageWidth
					modBanDo.defaImageHeight = Me.myThumbNails.ImageHeight
					modBanDo.defaHorizontalSpacing = Me.myThumbNails.HorizontalSpacing
					modBanDo.defaVerticalSpacing = Me.myThumbNails.VerticalSpacing
				Catch expr_148 As Exception
					ProjectData.SetProjectError(expr_148)
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
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_EditingObjects.Add(mObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
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
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Me.m_EditingObjects.Add(mObj)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.m_DrawTool = dlgCacKyHieu.VeTools.GroupScale
			Me.StatusBarPanel1.Text = "GroupScale"
			Me.StatusBarPanel2.Text = "GroupScale: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " thu, phóng"
		End Sub

		Private Sub GetSize(xmlFrag As String)
			Dim nt As NameTable = New NameTable()
			Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(nt)
			nsmgr.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, nsmgr, Nothing, XmlSpace.None)
			Dim rr As XmlTextReader = New XmlTextReader(xmlFrag, XmlNodeType.Element, context)
			Dim mWidth As Integer = 40
			Dim mHeight As Integer = 40
			Dim mCX As Integer = 0
			Dim mCY As Integer = 0
			While rr.Read()
				Dim oNodeType As XmlNodeType = rr.NodeType
				Dim xmlNodeType As XmlNodeType = oNodeType
				Dim flag As Boolean = xmlNodeType = XmlNodeType.Element
				If flag Then
					Dim name As String = rr.Name
					Dim flag2 As Boolean = Operators.CompareString(name, "KyHieu", False) = 0
					If flag2 Then
						Dim flag3 As Boolean = rr.AttributeCount > 0
						If flag3 Then
							While rr.MoveToNextAttribute()
								Dim name2 As String = rr.Name
								Dim flag4 As Boolean = Operators.CompareString(name2, "W", False) = 0
								If flag4 Then
									mWidth = Conversions.ToInteger(rr.Value)
								Else
									flag4 = (Operators.CompareString(name2, "H", False) = 0)
									If flag4 Then
										mHeight = Conversions.ToInteger(rr.Value)
									Else
										flag4 = (Operators.CompareString(name2, "CX", False) = 0)
										If flag4 Then
											mCX = Conversions.ToInteger(rr.Value)
										Else
											flag4 = (Operators.CompareString(name2, "CY", False) = 0)
											If flag4 Then
												mCY = Conversions.ToInteger(rr.Value)
											End If
										End If
									End If
								End If
							End While
						End If
					End If
				End If
			End While
			rr.Close()
			Me.myWidth = mWidth
			Me.myHeight = mHeight
			Me.myRootX = mCX
			Me.myRootY = mCY
		End Sub

		Private Function Objects2String(pWidth As Integer, pHeight As Integer, pRootX As Integer, pRootY As Integer, pGObjs As CGraphicObjs) As String
			Dim sw As StringWriter = New StringWriter()
			Dim wr As XmlTextWriter = New XmlTextWriter(sw)
			wr.WriteStartElement("KyHieu")
			wr.WriteAttributeString("W", pWidth.ToString())
			wr.WriteAttributeString("H", pHeight.ToString())
			wr.WriteAttributeString("CX", pRootX.ToString())
			wr.WriteAttributeString("CY", pRootY.ToString())
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mPart As GraphicObject = CType(enumerator.Current, GraphicObject)
					wr.WriteStartElement("Part")
					Dim mType As OBJECTTYPE = mPart.GetObjType()
					wr.WriteAttributeString("Type", mType.ToString())
					Dim flag As Boolean = mType = OBJECTTYPE.Text
					If flag Then
						Dim mTextObj As TextGraphic = CType(mPart, TextGraphic)
						wr.WriteAttributeString("Text", mTextObj.Text)
						wr.WriteAttributeString("FName", mTextObj.Font.Name)
						wr.WriteAttributeString("FSize", mTextObj.Font.Size.ToString())
						wr.WriteAttributeString("FStyle", mTextObj.Font.Style.ToString())
						wr.WriteAttributeString("FColor", Conversions.ToString(mTextObj.Color.ToArgb()))
						wr.WriteStartElement("Pos")
						wr.WriteAttributeString("X", mTextObj.X.ToString())
						wr.WriteAttributeString("Y", mTextObj.Y.ToString())
						wr.WriteAttributeString("A", mTextObj.Rotation.ToString())
						wr.WriteEndElement()
					Else
						flag = (mType = OBJECTTYPE.EmbeddedImage)
						If flag Then
							Dim mImageObj As EmbeddedImageGraphic = CType(mPart, EmbeddedImageGraphic)
							wr.WriteAttributeString("ITYPE", mImageObj.ImageType)
							wr.WriteAttributeString("IMAGEW", mImageObj.Width.ToString())
							wr.WriteAttributeString("IMAGEH", mImageObj.Height.ToString())
							flag = mImageObj.Transparent
							If flag Then
								wr.WriteAttributeString("Transparent", mImageObj.Transparent.ToString())
								wr.WriteAttributeString("TransparentColor", Conversions.ToString(mImageObj.TransparentColor.ToArgb()))
							End If
							Dim strImage As String = ""
							Dim imageType As String = mImageObj.ImageType
							If Operators.CompareString(imageType, "wmf", False) = 0 OrElse Operators.CompareString(imageType, "emf", False) = 0 Then
								GoTo IL_2C0
							End If
							If Operators.CompareString(imageType, "kro", False) = 0 Then
								GoTo IL_2C0
							End If
							Dim arg_2C1_0 As Boolean = False
							IL_2C1:
							flag = arg_2C1_0
							If flag Then
								Try
									Dim mFileName As Object = "tmp.kro"
									Dim mMetaFile As Image = mImageObj.Image
									mMetaFile.Save(Conversions.ToString(mFileName))
									Dim arrImageByte As Byte() = Me.GetarrImage(Conversions.ToString(mFileName))
									strImage = Convert.ToBase64String(arrImageByte)
								Catch expr_300 As Exception
									ProjectData.SetProjectError(expr_300)
									Dim ex As Exception = expr_300
									Interaction.MsgBox("kro sai: " + ex.Message, MsgBoxStyle.OkOnly, Nothing)
									ProjectData.ClearProjectError()
								End Try
							Else
								Dim memStream As MemoryStream = New MemoryStream()
								mImageObj.Image.Save(memStream, ImageFormat.Bmp)
								strImage = Convert.ToBase64String(memStream.ToArray())
							End If
							wr.WriteAttributeString("IMAGE", strImage)
							wr.WriteStartElement("Pos")
							wr.WriteAttributeString("X", mImageObj.X.ToString())
							wr.WriteAttributeString("Y", mImageObj.Y.ToString())
							wr.WriteAttributeString("A", mImageObj.Rotation.ToString())
							wr.WriteEndElement()
							GoTo IL_852
							IL_2C0:
							arg_2C1_0 = True
							GoTo IL_2C1
						End If
						Dim mShapeObj As ShapeGraphic = CType(mPart, ShapeGraphic)
						wr.WriteAttributeString("Color", Conversions.ToString(mShapeObj.LineColor.ToArgb()))
						wr.WriteAttributeString("Width", mShapeObj.LineWidth.ToString())
						flag = (mShapeObj.LineStyle > 0)
						If flag Then
							wr.WriteAttributeString("Style", mShapeObj.LineStyle.ToString())
							wr.WriteAttributeString("SWidth", mShapeObj.StyleWidth.ToString())
						End If
						flag = (mShapeObj.Line2Width > 0F)
						If flag Then
							wr.WriteAttributeString("Color2", Conversions.ToString(mShapeObj.Line2Color.ToArgb()))
							wr.WriteAttributeString("Width2", mShapeObj.Line2Width.ToString())
						End If
						flag = (mShapeObj.DValues.Length > 0)
						If flag Then
							wr.WriteAttributeString("DV", mShapeObj.DValues)
						End If
						flag = mShapeObj.Fill
						If flag Then
							wr.WriteAttributeString("Fill", mShapeObj.Fill.ToString())
							wr.WriteAttributeString("FColor", Conversions.ToString(mShapeObj.FillColor.ToArgb()))
							wr.WriteAttributeString("HColor", Conversions.ToString(mShapeObj.HatchColor.ToArgb()))
							wr.WriteAttributeString("HStyle", mShapeObj.HatchStyle.ToString())
						End If
						flag = (mType = OBJECTTYPE.Ellipse)
						If flag Then
							Dim mEllipseObj As EllipseGraphic = CType(mShapeObj, EllipseGraphic)
							wr.WriteStartElement("Rect")
							wr.WriteAttributeString("X", mEllipseObj.X.ToString())
							wr.WriteAttributeString("Y", mEllipseObj.Y.ToString())
							wr.WriteAttributeString("W", mEllipseObj.Width.ToString())
							wr.WriteAttributeString("H", mEllipseObj.Height.ToString())
							wr.WriteAttributeString("A", mEllipseObj.Rotation.ToString())
							wr.WriteEndElement()
						Else
							flag = (mType = OBJECTTYPE.Pie)
							If flag Then
								Dim mPieObj As PieGraphic = CType(mShapeObj, PieGraphic)
								wr.WriteStartElement("Pie")
								wr.WriteAttributeString("X", mPieObj.X.ToString())
								wr.WriteAttributeString("Y", mPieObj.Y.ToString())
								wr.WriteAttributeString("W", mPieObj.Width.ToString())
								wr.WriteAttributeString("H", mPieObj.Height.ToString())
								wr.WriteAttributeString("ST", mPieObj.StartAngle.ToString())
								wr.WriteAttributeString("SW", mPieObj.SweepAngle.ToString())
								flag = mPieObj.IsArc
								If flag Then
									wr.WriteAttributeString("ARC", mPieObj.IsArc.ToString())
								End If
								wr.WriteAttributeString("A", mPieObj.Rotation.ToString())
								wr.WriteEndElement()
							Else
								Dim i As Integer = 0
								Dim mNodesShapeObj As NodesShapeGraphic = CType(mShapeObj, NodesShapeGraphic)
								Try
									Dim enumerator2 As IEnumerator = mNodesShapeObj.Nodes.GetEnumerator()
									While enumerator2.MoveNext()
										Dim mNode As CNODE = CType(enumerator2.Current, CNODE)
										i += 1
										wr.WriteStartElement("Node")
										wr.WriteAttributeString("X", mNode.Pt.X.ToString())
										wr.WriteAttributeString("Y", mNode.Pt.Y.ToString())
										flag = mNode.IsControl
										If flag Then
											wr.WriteAttributeString("Type", mNode.IsControl.ToString())
										End If
										wr.WriteElementString("i", i.ToString())
										wr.WriteEndElement()
									End While
								Finally
									Dim enumerator2 As IEnumerator
									flag = (TypeOf enumerator2 Is IDisposable)
									If flag Then
										(TryCast(enumerator2, IDisposable)).Dispose()
									End If
								End Try
							End If
						End If
					End If
					IL_852:
					wr.WriteEndElement()
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			wr.WriteEndElement()
			wr.Close()
			Return sw.ToString()
		End Function

		Private Function GetarrImage(mFileName As String) As Byte()
			Dim arrByte As Byte() = Nothing
			Dim flag As Boolean = mFileName.Length > 0
			If flag Then
				Dim fs As FileStream = New FileStream(mFileName, FileMode.Open)
				Dim r As BinaryReader = New BinaryReader(fs)
				' The following expression was wrapped in a checked-expression
				Dim fsCount As Integer = CInt(fs.Length)
				arrByte = r.ReadBytes(fsCount)
				fs.Close()
			End If
			Return arrByte
		End Function

		Private Sub DrawDrawingRoot(g As Graphics, pPt As PointF)
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Black), 1F)
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.ScaleTransform(CSng(Me.myScale), CSng(Me.myScale))
			g.DrawLine(DrawingPen, pPt.X - 2F, pPt.Y - 2F, pPt.X + 2F, pPt.Y + 2F)
			g.DrawLine(DrawingPen, pPt.X - 2F, pPt.Y + 2F, pPt.X + 2F, pPt.Y - 2F)
			DrawingPen.Dispose()
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
		End Sub

		Private Function RootHitTest(pt As PointF) As Boolean
			' The following expression was wrapped in a checked-expression
			Dim r As RectangleF = New RectangleF(CSng((Me.myRootX - 3)), CSng((Me.myRootY - 3)), 7F, 7F)
			Return r.Contains(pt)
		End Function

		Private Function GetMaxStt(pLoaiKH_ID As Integer) As Integer
			Dim kq As Integer = 0
			Try
				Dim strSQL As String = "SELECT Stt"
				strSQL += " FROM tblKyHieu"
				strSQL = strSQL + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				strSQL += " ORDER BY tblKyHieu.Stt"
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				Dim drSQL As OleDbDataReader = cmSQL.ExecuteReader()
				While drSQL.Read()
					kq = Conversions.ToInteger(drSQL(0))
				End While
				drSQL.Close()
				cmSQL.Dispose()
				cnSQL.Close()
				cnSQL.Dispose()
			Catch expr_9A As OleDbException
				ProjectData.SetProjectError(expr_9A)
				Dim e As OleDbException = expr_9A
				Interaction.MsgBox(Conversions.ToString(e.ErrorCode) + ":" + e.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_D4 As Exception
				ProjectData.SetProjectError(expr_D4)
				Dim e2 As Exception = expr_D4
				Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Return kq
		End Function

		Private Sub PopulateList(pLoaiKH_ID As Integer)
			Dim flag As Boolean
			Try
				Dim strSQL As String = "SELECT tblKyHieu.KH_ID, tblKyHieu.TenKH, tblKyHieu.KyHieu"
				strSQL += " FROM tblKyHieu LEFT JOIN tblLoaiKH ON tblKyHieu.LoaiKH_ID = tblLoaiKH.LoaiKH_ID"
				flag = (pLoaiKH_ID > 0)
				If flag Then
					strSQL = strSQL + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				End If
				strSQL += " ORDER BY tblLoaiKH.MaLoaiKH, tblKyHieu.Stt"
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				Dim drSQL As OleDbDataReader = cmSQL.ExecuteReader()
				Me.myThumbNails.Clear()
				While drSQL.Read()
					Me.myThumbNails.Add(New CThumbNail(drSQL("TenKH").ToString(), Conversions.ToInteger(drSQL("KH_ID")), Conversions.ToString(drSQL("KyHieu"))))
				End While
				drSQL.Close()
				cmSQL.Dispose()
				cnSQL.Close()
				cnSQL.Dispose()
			Catch expr_D9 As OleDbException
				ProjectData.SetProjectError(expr_D9)
				Dim e As OleDbException = expr_D9
				Interaction.MsgBox(Conversions.ToString(e.ErrorCode) + ":" + e.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_113 As Exception
				ProjectData.SetProjectError(expr_113)
				Dim e2 As Exception = expr_113
				Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			flag = (Me.myThumbNails.Count > 0)
			If flag Then
				' The following expression was wrapped in a checked-expression
				Me.myThumbNails.SelectedIndex = Me.myThumbNails.Count - 1
				Me.myThumbNails.SelectedIndex = 0
			Else
				Me.myThumbNails.SelectedIndex = -1
			End If
			Me.picThumbNails.Invalidate()
		End Sub

		Private Function UpdateSoTT(pKH_ID As Integer, pStt As Integer) As Boolean
			Dim bKQ As Boolean = False
			Dim flag As Boolean = Not Me.IsValidForm()
			Dim UpdateSoTT As Boolean
			If flag Then
				UpdateSoTT = False
			Else
				Dim strSQL As String = ""
				Try
					strSQL = "UPDATE tblKyHieu SET"
					strSQL += " Stt = ?"
					strSQL += " WHERE KH_ID = ?"
					Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
					cnSQL.Open()
					Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
					cmSQL.Parameters.Add(New OleDbParameter("Stt", OleDbType.[Integer], 0, "Stt"))
					cmSQL.Parameters.Add(New OleDbParameter("Original_KH_ID", OleDbType.[Integer], 0, ParameterDirection.Input, False, 10, 0, "KH_ID", DataRowVersion.Original, Nothing))
					cmSQL.Parameters("Stt").Value = pStt
					cmSQL.Parameters("Original_KH_ID").Value = pKH_ID
					Dim intRowsAffected As Integer = cmSQL.ExecuteNonQuery()
					flag = (intRowsAffected <> 1)
					If flag Then
						Interaction.MsgBox("Update Failed.", MsgBoxStyle.Critical, "Update")
					End If
					cnSQL.Close()
					cmSQL.Dispose()
					cnSQL.Dispose()
					bKQ = True
				Catch expr_11F As OleDbException
					ProjectData.SetProjectError(expr_11F)
					Dim e As OleDbException = expr_11F
					Interaction.MsgBox(strSQL, MsgBoxStyle.OkOnly, Nothing)
					Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "SQL Error")
					ProjectData.ClearProjectError()
				Catch expr_14D As Exception
					ProjectData.SetProjectError(expr_14D)
					Dim e2 As Exception = expr_14D
					Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
					ProjectData.ClearProjectError()
				End Try
				UpdateSoTT = bKQ
			End If
			Return UpdateSoTT
		End Function

		Private Function SoTTisOK(pLoaiKH_ID As Integer) As Boolean
			Dim kq As Boolean = True
			Try
				Dim strSQL As String = "SELECT tblKyHieu.KH_ID, tblKyHieu.TenKH, tblKyHieu.Stt"
				strSQL += " FROM tblKyHieu LEFT JOIN tblLoaiKH ON tblKyHieu.LoaiKH_ID = tblLoaiKH.LoaiKH_ID"
				Dim flag As Boolean = pLoaiKH_ID > 0
				If flag Then
					strSQL = strSQL + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				End If
				strSQL += " ORDER BY tblLoaiKH.MaLoaiKH, tblKyHieu.Stt"
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				Dim drSQL As OleDbDataReader = cmSQL.ExecuteReader()
				Dim mPrevStt As Integer = 0
				While drSQL.Read()
					Dim mStt As Integer = Conversions.ToInteger(drSQL("Stt"))
					flag = (mStt = mPrevStt)
					If flag Then
						kq = False
						Exit While
					End If
					mPrevStt = mStt
				End While
				drSQL.Close()
				cmSQL.Dispose()
				cnSQL.Close()
				cnSQL.Dispose()
			Catch expr_C4 As OleDbException
				ProjectData.SetProjectError(expr_C4)
				Dim e As OleDbException = expr_C4
				Interaction.MsgBox(Conversions.ToString(e.ErrorCode) + ":" + e.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_FE As Exception
				ProjectData.SetProjectError(expr_FE)
				Dim e2 As Exception = expr_FE
				Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Return kq
		End Function

		Private Function GetSoTT(pKH_ID As Integer) As Integer
			Dim kq As Integer = -1
			Try
				Dim strSQL As String = "SELECT tblKyHieu.Stt  FROM tblKyHieu"
				strSQL = strSQL + " WHERE tblKyHieu.KH_ID = " + Conversions.ToString(pKH_ID)
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				Dim drSQL As OleDbDataReader = cmSQL.ExecuteReader()
				While drSQL.Read()
					kq = Conversions.ToInteger(drSQL("Stt"))
				End While
				drSQL.Close()
				cmSQL.Dispose()
				cnSQL.Close()
				cnSQL.Dispose()
			Catch expr_82 As OleDbException
				ProjectData.SetProjectError(expr_82)
				Dim e As OleDbException = expr_82
				Interaction.MsgBox(Conversions.ToString(e.ErrorCode) + ":" + e.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_BC As Exception
				ProjectData.SetProjectError(expr_BC)
				Dim e2 As Exception = expr_BC
				Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Return kq
		End Function

		Private Sub DanhSoTT(pLoaiKH_ID As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				Dim strSQL As String = "SELECT tblKyHieu.KH_ID, tblKyHieu.TenKH, tblKyHieu.KyHieu"
				strSQL += " FROM tblKyHieu LEFT JOIN tblLoaiKH ON tblKyHieu.LoaiKH_ID = tblLoaiKH.LoaiKH_ID"
				Dim flag As Boolean = pLoaiKH_ID > 0
				If flag Then
					strSQL = strSQL + " WHERE tblKyHieu.LoaiKH_ID = " + Conversions.ToString(pLoaiKH_ID)
				End If
				strSQL += " ORDER BY tblLoaiKH.MaLoaiKH, tblKyHieu.Stt"
				Dim cnSQL As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				cnSQL.Open()
				Dim cmSQL As OleDbCommand = New OleDbCommand(strSQL, cnSQL)
				Dim drSQL As OleDbDataReader = cmSQL.ExecuteReader()
				Dim mStt As Integer = 0
				While drSQL.Read()
					mStt += 1
					Me.UpdateSoTT(Conversions.ToInteger(drSQL("KH_ID")), mStt)
				End While
				drSQL.Close()
				cmSQL.Dispose()
				cnSQL.Close()
				cnSQL.Dispose()
			Catch expr_AE As OleDbException
				ProjectData.SetProjectError(expr_AE)
				Dim e As OleDbException = expr_AE
				Interaction.MsgBox(Conversions.ToString(e.ErrorCode) + ":" + e.Message, MsgBoxStyle.Critical, "SQL Error")
				ProjectData.ClearProjectError()
			Catch expr_E8 As Exception
				ProjectData.SetProjectError(expr_E8)
				Dim e2 As Exception = expr_E8
				Interaction.MsgBox(e2.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Function GetFirstLoaiKH() As Long
			Dim lngKQ As Long = 0L
			Dim strSQL As String = "SELECT LoaiKH_ID FROM tblLoaiKH"
			strSQL += " WHERE Cuoi <> 0"
			strSQL += " ORDER BY MaLoaiKH;"
			Try
				Dim myConn As OleDbConnection = New OleDbConnection(Me.myKHConnStr)
				myConn.Open()
				Dim mCommand As OleDbCommand = New OleDbCommand(strSQL, myConn)
				Dim mReader As OleDbDataReader = mCommand.ExecuteReader()
				If mReader.Read() Then
					lngKQ = Conversions.ToLong(mReader.GetValue(0))
				End If
				mReader.Close()
				myConn.Close()
			Catch arg_7F_0 As Exception
				ProjectData.SetProjectError(arg_7F_0)
				ProjectData.ClearProjectError()
			End Try
			Return lngKQ
		End Function

		Private Sub MnuSplitShape_Click(sender As Object, e As EventArgs)
			Me.m_DrawTool = dlgCacKyHieu.VeTools.Split
			Me.StatusBarPanel1.Text = "Split"
			Me.StatusBarPanel2.Text = "C" & ChrW(7855) & "t: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng c" & ChrW(7855) & "t."
		End Sub

		Private Function To2Objects(pObject As GraphicObject, pPT0 As PointF, pPT1 As PointF) As dlgCacKyHieu.SPLITOBJECTS
			Dim mSPLITSYMBOLS As dlgCacKyHieu.SPLITOBJECTS = Nothing
			mSPLITSYMBOLS.Obj1 = Nothing
			mSPLITSYMBOLS.Obj2 = Nothing
			Dim mPTs2 As PointF() = New PointF() { pPT0, pPT1 }
			Dim mA0 As Single = modBanDo.AngleToPoint(mPTs2(0), mPTs2(1))
			Dim mObj As GraphicObject = modBanDo.ObjToCurve(pObject)
			Dim flag As Boolean = mObj.GetObjType() = OBJECTTYPE.Curve
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mPTs3 As PointF() = mObj.GetPoints()
				Dim mINTERSECTNODEs As modBanDo.INTERSECTNODE() = modBanDo.GetIntersectPoints(mPTs2(0), mPTs2(1), mPTs3)
				flag = (mINTERSECTNODEs.GetUpperBound(0) > -1)
				If flag Then
					Dim mPts As PointF() = New PointF(mPTs3.GetUpperBound(0) + mINTERSECTNODEs.GetUpperBound(0) + 1 + 1 - 1) {}
					Dim i As Integer = 0
					Dim arg_D8_0 As Integer = 0
					Dim upperBound As Integer = mINTERSECTNODEs.GetUpperBound(0)
					Dim j As Integer = arg_D8_0
					While True
						Dim arg_194_0 As Integer = j
						Dim num As Integer = upperBound
						If arg_194_0 > num Then
							Exit While
						End If
						Dim arg_F1_0 As Integer = i
						Dim nodeIndex As Integer = mINTERSECTNODEs(j).NodeIndex
						Dim k As Integer = arg_F1_0
						While True
							Dim arg_123_0 As Integer = k
							num = nodeIndex
							If arg_123_0 > num Then
								Exit While
							End If
							mPts(k + j) = mPTs3(k)
							k += 1
						End While
						mPts(mINTERSECTNODEs(j).NodeIndex + j + 1) = mINTERSECTNODEs(j).PT
						i = mINTERSECTNODEs(j).NodeIndex + 1
						mINTERSECTNODEs(j).NodeIndex = mINTERSECTNODEs(j).NodeIndex + j + 1
						j += 1
					End While
					Dim arg_1A5_0 As Integer = i
					Dim upperBound2 As Integer = mPTs3.GetUpperBound(0)
					Dim l As Integer = arg_1A5_0
					While True
						Dim arg_1DF_0 As Integer = l
						Dim num As Integer = upperBound2
						If arg_1DF_0 > num Then
							Exit While
						End If
						mPts(l + mINTERSECTNODEs.GetUpperBound(0) + 1) = mPTs3(l)
						l += 1
					End While
					Dim mPTS4O As PointF() = New PointF(-1) {}
					Dim mPTS4O2 As PointF() = New PointF(-1) {}
					Dim k2 As Integer = 0
					Dim arg_1FF_0 As Integer = 0
					Dim upperBound3 As Integer = mINTERSECTNODEs.GetUpperBound(0)
					Dim m As Integer = arg_1FF_0
					While True
						Dim arg_39D_0 As Integer = m
						Dim num As Integer = upperBound3
						If arg_39D_0 > num Then
							Exit While
						End If
						Dim mPts2 As PointF() = New PointF(mINTERSECTNODEs(m).NodeIndex - k2 + 1 - 1) {}
						Dim arg_232_0 As Integer = k2
						Dim nodeIndex2 As Integer = mINTERSECTNODEs(m).NodeIndex
						Dim n As Integer = arg_232_0
						While True
							Dim arg_264_0 As Integer = n
							num = nodeIndex2
							If arg_264_0 > num Then
								Exit While
							End If
							mPts2(n - k2) = mPts(n)
							n += 1
						End While
						k2 = mINTERSECTNODEs(m).NodeIndex
						flag = (modBanDo.AngleToPoint(mPTs2(0), mPts2(mPts2.GetUpperBound(0) - 1)) > mA0)
						If flag Then
							Dim l2 As Integer = mPTS4O.GetUpperBound(0)
							mPTS4O = CType(Utils.CopyArray(CType(mPTS4O, Array), New PointF(l2 + mPts2.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_2E2_0 As Integer = 0
							Dim upperBound4 As Integer = mPts2.GetUpperBound(0)
							Dim j2 As Integer = arg_2E2_0
							While True
								Dim arg_316_0 As Integer = j2
								num = upperBound4
								If arg_316_0 > num Then
									Exit While
								End If
								mPTS4O(j2 + l2 + 1) = mPts2(j2)
								j2 += 1
							End While
						Else
							Dim l3 As Integer = mPTS4O2.GetUpperBound(0)
							mPTS4O2 = CType(Utils.CopyArray(CType(mPTS4O2, Array), New PointF(l3 + mPts2.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_357_0 As Integer = 0
							Dim upperBound5 As Integer = mPts2.GetUpperBound(0)
							Dim j3 As Integer = arg_357_0
							While True
								Dim arg_38B_0 As Integer = j3
								num = upperBound5
								If arg_38B_0 > num Then
									Exit While
								End If
								mPTS4O2(j3 + l3 + 1) = mPts2(j3)
								j3 += 1
							End While
						End If
						m += 1
					End While
					Dim mPts3 As PointF() = New PointF(mPts.GetUpperBound(0) - k2 + 1 - 1) {}
					Dim arg_3C2_0 As Integer = k2
					Dim upperBound6 As Integer = mPts.GetUpperBound(0)
					Dim j4 As Integer = arg_3C2_0
					While True
						Dim arg_3F4_0 As Integer = j4
						Dim num As Integer = upperBound6
						If arg_3F4_0 > num Then
							Exit While
						End If
						mPts3(j4 - k2) = mPts(j4)
						j4 += 1
					End While
					flag = (modBanDo.AngleToPoint(mPTs2(0), mPts3(1)) > mA0)
					If flag Then
						Dim l4 As Integer = mPTS4O.GetUpperBound(0)
						mPTS4O = CType(Utils.CopyArray(CType(mPTS4O, Array), New PointF(l4 + mPts3.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
						Dim arg_459_0 As Integer = 0
						Dim upperBound7 As Integer = mPts3.GetUpperBound(0)
						Dim j5 As Integer = arg_459_0
						While True
							Dim arg_48D_0 As Integer = j5
							Dim num As Integer = upperBound7
							If arg_48D_0 > num Then
								Exit While
							End If
							mPTS4O(j5 + l4 + 1) = mPts3(j5)
							j5 += 1
						End While
					Else
						Dim l5 As Integer = mPTS4O2.GetUpperBound(0)
						mPTS4O2 = CType(Utils.CopyArray(CType(mPTS4O2, Array), New PointF(l5 + mPts3.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
						Dim arg_4CE_0 As Integer = 0
						Dim upperBound8 As Integer = mPts3.GetUpperBound(0)
						Dim j6 As Integer = arg_4CE_0
						While True
							Dim arg_502_0 As Integer = j6
							Dim num As Integer = upperBound8
							If arg_502_0 > num Then
								Exit While
							End If
							mPTS4O2(j6 + l5 + 1) = mPts3(j6)
							j6 += 1
						End While
					End If
					Dim mObject As CurveGraphic = CType(mObj.Clone(), CurveGraphic)
					mObject.Nodes.Clear()
					Dim arg_52A_0 As Integer = 0
					Dim upperBound9 As Integer = mPTS4O.GetUpperBound(0)
					Dim j7 As Integer = arg_52A_0
					While True
						Dim arg_56A_0 As Integer = j7
						Dim num As Integer = upperBound9
						If arg_56A_0 > num Then
							Exit While
						End If
						Dim mNode As CNODE = New CNODE(mPTS4O(j7))
						mNode.IsControl = True
						mObject.Nodes.Add(mNode)
						j7 += 1
					End While
					mSPLITSYMBOLS.Obj1 = mObject
					Dim mObject2 As CurveGraphic = CType(mObj.Clone(), CurveGraphic)
					mObject2.Nodes.Clear()
					Dim arg_59A_0 As Integer = 0
					Dim upperBound10 As Integer = mPTS4O2.GetUpperBound(0)
					Dim j8 As Integer = arg_59A_0
					While True
						Dim arg_5DA_0 As Integer = j8
						Dim num As Integer = upperBound10
						If arg_5DA_0 > num Then
							Exit While
						End If
						Dim mNode2 As CNODE = New CNODE(mPTS4O2(j8))
						mNode2.IsControl = True
						mObject2.Nodes.Add(mNode2)
						j8 += 1
					End While
					mSPLITSYMBOLS.Obj2 = mObject2
				Else
					flag = (modBanDo.AngleToPoint(mPTs2(0), mPTs3(0)) > mA0)
					If flag Then
						mSPLITSYMBOLS.Obj1 = pObject
					Else
						mSPLITSYMBOLS.Obj2 = pObject
					End If
				End If
			Else
				flag = (mObj.GetObjType() = OBJECTTYPE.ClosedCurve)
				If flag Then
					Dim mPTs4 As PointF() = mObj.GetPoints()
					Dim iDim As Integer = mPTs4.GetUpperBound(0)
					mPTs4 = CType(Utils.CopyArray(CType(mPTs4, Array), New PointF(iDim + 1 + 1 - 1) {}), PointF())
					mPTs4(iDim + 1) = mPTs4(0)
					Dim mINTERSECTNODEs2 As modBanDo.INTERSECTNODE() = modBanDo.GetIntersectPoints(mPTs2(0), mPTs2(1), mPTs4)
					mPTs4 = CType(Utils.CopyArray(CType(mPTs4, Array), New PointF(iDim + 1 - 1) {}), PointF())
					flag = (mINTERSECTNODEs2.GetUpperBound(0) > 0)
					If flag Then
						Dim mPTS4O3 As PointF() = New PointF(-1) {}
						Dim mPTS4O4 As PointF() = New PointF(-1) {}
						Dim arg_6F6_0 As Integer = 0
						Dim num2 As Integer = mINTERSECTNODEs2.GetUpperBound(0) - 1
						Dim i2 As Integer = arg_6F6_0
						While True
							Dim arg_8DF_0 As Integer = i2
							Dim num As Integer = num2
							If arg_8DF_0 > num Then
								Exit While
							End If
							Dim k3 As Integer = mINTERSECTNODEs2(i2).NodeIndex
							Dim mPts4 As PointF() = New PointF(mINTERSECTNODEs2(i2 + 1).NodeIndex - k3 + 1 + 1 - 1) {}
							mPts4(0) = mINTERSECTNODEs2(i2).PT
							Dim arg_75C_0 As Integer = 1
							Dim num3 As Integer = mINTERSECTNODEs2(i2 + 1).NodeIndex - k3
							Dim j9 As Integer = arg_75C_0
							While True
								Dim arg_78E_0 As Integer = j9
								num = num3
								If arg_78E_0 > num Then
									Exit While
								End If
								mPts4(j9) = mPTs4(k3 + j9)
								j9 += 1
							End While
							mPts4(mINTERSECTNODEs2(i2 + 1).NodeIndex - k3 + 1) = mINTERSECTNODEs2(i2 + 1).PT
							flag = (modBanDo.AngleToPoint(mPTs2(0), mPts4(1)) > mA0)
							If flag Then
								Dim l6 As Integer = mPTS4O3.GetUpperBound(0)
								mPTS4O3 = CType(Utils.CopyArray(CType(mPTS4O3, Array), New PointF(l6 + mPts4.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
								Dim arg_824_0 As Integer = 0
								Dim upperBound11 As Integer = mPts4.GetUpperBound(0)
								Dim j10 As Integer = arg_824_0
								While True
									Dim arg_858_0 As Integer = j10
									num = upperBound11
									If arg_858_0 > num Then
										Exit While
									End If
									mPTS4O3(j10 + l6 + 1) = mPts4(j10)
									j10 += 1
								End While
							Else
								Dim l7 As Integer = mPTS4O4.GetUpperBound(0)
								mPTS4O4 = CType(Utils.CopyArray(CType(mPTS4O4, Array), New PointF(l7 + mPts4.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
								Dim arg_899_0 As Integer = 0
								Dim upperBound12 As Integer = mPts4.GetUpperBound(0)
								Dim j11 As Integer = arg_899_0
								While True
									Dim arg_8CD_0 As Integer = j11
									num = upperBound12
									If arg_8CD_0 > num Then
										Exit While
									End If
									mPTS4O4(j11 + l7 + 1) = mPts4(j11)
									j11 += 1
								End While
							End If
							i2 += 1
						End While
						Dim i3 As Integer = mINTERSECTNODEs2.GetUpperBound(0)
						Dim l8 As Integer = iDim - mINTERSECTNODEs2(i3).NodeIndex
						Dim l9 As Integer = mINTERSECTNODEs2(0).NodeIndex + 1
						Dim mPts5 As PointF() = New PointF(l8 + l9 + 1 + 1 - 1) {}
						mPts5(0) = mINTERSECTNODEs2(i3).PT
						Dim k4 As Integer = mINTERSECTNODEs2(i3).NodeIndex
						Dim arg_952_0 As Integer = 1
						Dim num4 As Integer = l8
						Dim j12 As Integer = arg_952_0
						While True
							Dim arg_984_0 As Integer = j12
							Dim num As Integer = num4
							If arg_984_0 > num Then
								Exit While
							End If
							mPts5(j12) = mPTs4(k4 + j12)
							j12 += 1
						End While
						Dim arg_98D_0 As Integer = 0
						Dim num5 As Integer = l9 - 1
						Dim j13 As Integer = arg_98D_0
						While True
							Dim arg_9C1_0 As Integer = j13
							Dim num As Integer = num5
							If arg_9C1_0 > num Then
								Exit While
							End If
							mPts5(j13 + l8 + 1) = mPTs4(j13)
							j13 += 1
						End While
						mPts5(l8 + l9 + 1) = mINTERSECTNODEs2(0).PT
						flag = (modBanDo.AngleToPoint(mPTs2(0), mPts5(1)) > mA0)
						If flag Then
							Dim l10 As Integer = mPTS4O3.GetUpperBound(0)
							mPTS4O3 = CType(Utils.CopyArray(CType(mPTS4O3, Array), New PointF(l10 + mPts5.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_A46_0 As Integer = 0
							Dim upperBound13 As Integer = mPts5.GetUpperBound(0)
							Dim j14 As Integer = arg_A46_0
							While True
								Dim arg_A7A_0 As Integer = j14
								Dim num As Integer = upperBound13
								If arg_A7A_0 > num Then
									Exit While
								End If
								mPTS4O3(j14 + l10 + 1) = mPts5(j14)
								j14 += 1
							End While
						Else
							Dim l11 As Integer = mPTS4O4.GetUpperBound(0)
							mPTS4O4 = CType(Utils.CopyArray(CType(mPTS4O4, Array), New PointF(l11 + mPts5.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
							Dim arg_ABB_0 As Integer = 0
							Dim upperBound14 As Integer = mPts5.GetUpperBound(0)
							Dim j15 As Integer = arg_ABB_0
							While True
								Dim arg_AEF_0 As Integer = j15
								Dim num As Integer = upperBound14
								If arg_AEF_0 > num Then
									Exit While
								End If
								mPTS4O4(j15 + l11 + 1) = mPts5(j15)
								j15 += 1
							End While
						End If
						Dim mObject3 As ClosedCurveGraphic = CType(mObj.Clone(), ClosedCurveGraphic)
						mObject3.Nodes.Clear()
						Dim arg_B17_0 As Integer = 0
						Dim upperBound15 As Integer = mPTS4O3.GetUpperBound(0)
						Dim j16 As Integer = arg_B17_0
						While True
							Dim arg_B57_0 As Integer = j16
							Dim num As Integer = upperBound15
							If arg_B57_0 > num Then
								Exit While
							End If
							Dim mNode3 As CNODE = New CNODE(mPTS4O3(j16))
							mNode3.IsControl = True
							mObject3.Nodes.Add(mNode3)
							j16 += 1
						End While
						mSPLITSYMBOLS.Obj1 = mObject3
						Dim mObject4 As ClosedCurveGraphic = CType(mObj.Clone(), ClosedCurveGraphic)
						mObject4.Nodes.Clear()
						Dim arg_B87_0 As Integer = 0
						Dim upperBound16 As Integer = mPTS4O4.GetUpperBound(0)
						Dim j17 As Integer = arg_B87_0
						While True
							Dim arg_BC7_0 As Integer = j17
							Dim num As Integer = upperBound16
							If arg_BC7_0 > num Then
								Exit While
							End If
							Dim mNode4 As CNODE = New CNODE(mPTS4O4(j17))
							mNode4.IsControl = True
							mObject4.Nodes.Add(mNode4)
							j17 += 1
						End While
						mSPLITSYMBOLS.Obj2 = mObject4
					Else
						flag = (modBanDo.AngleToPoint(mPTs2(0), mPTs4(0)) > mA0)
						If flag Then
							mSPLITSYMBOLS.Obj1 = pObject
						Else
							mSPLITSYMBOLS.Obj2 = pObject
						End If
					End If
				Else
					Dim mPTs5 As PointF() = pObject.GetPoints()
					flag = (modBanDo.AngleToPoint(mPTs2(0), mPTs5(0)) > mA0)
					If flag Then
						mSPLITSYMBOLS.Obj1 = pObject
					Else
						mSPLITSYMBOLS.Obj2 = pObject
					End If
				End If
			End If
			Return mSPLITSYMBOLS
		End Function

		Private Sub PictureBox1_KeyUp(sender As Object, e As KeyEventArgs)
			Select Case e.KeyCode
				Case Keys.Left
					Dim flag As Boolean = Not Information.IsNothing(Me.m_SelectedObject)
					If flag Then
						Dim flag2 As Boolean = (Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt
						If flag2 Then
							Dim rect As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim dX As Single = (rect.Width - 1F) / rect.Width
							Dim dY As Single = 1F
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, dX, dY)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else
							flag = ((Control.ModifierKeys And Keys.Control) = Keys.Control)
							If flag Then
								Me.myfromPt = Me.m_SelectedObject.GetCenter()
								Me.mytoPt = Me.myfromPt
								Me.mytoPt.X = Me.mytoPt.X - 1F
								Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
								Me.PictureBox1.Invalidate()
								Me.PictureBox2.Invalidate()
							Else
								flag = ((Control.ModifierKeys And Keys.Alt) = Keys.Alt)
								If flag Then
									Me.myrootPt = Me.m_SelectedObject.GetCenter()
									Me.m_SelectedObject.Rotate2(Me.myrootPt, -modBanDo.myTinhChinhGocQuay)
									Me.PictureBox1.Invalidate()
									Me.PictureBox2.Invalidate()
								End If
							End If
						End If
					End If
				Case Keys.Up
					Dim flag As Boolean = Not Information.IsNothing(Me.m_SelectedObject)
					If flag Then
						Dim flag2 As Boolean = (Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt
						If flag2 Then
							Dim rect2 As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim dX2 As Single = 1F
							Dim dY2 As Single = (rect2.Height + 1F) / rect2.Height
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, dX2, dY2)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else
							flag = ((Control.ModifierKeys And Keys.Control) = Keys.Control)
							If flag Then
								Me.myfromPt = Me.m_SelectedObject.GetCenter()
								Me.mytoPt = Me.myfromPt
								Me.mytoPt.Y = Me.mytoPt.Y - 1F
								Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
								Me.PictureBox1.Invalidate()
								Me.PictureBox2.Invalidate()
							Else
								flag = ((Control.ModifierKeys And Keys.Alt) = Keys.Alt)
								If flag Then
								End If
							End If
						End If
					End If
				Case Keys.Right
					Dim flag2 As Boolean = Not Information.IsNothing(Me.m_SelectedObject)
					If flag2 Then
						Dim flag As Boolean = (Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt
						If flag Then
							Dim rect3 As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim dX3 As Single = (rect3.Width + 1F) / rect3.Width
							Dim dY3 As Single = 1F
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, dX3, dY3)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else
							flag = ((Control.ModifierKeys And Keys.Control) = Keys.Control)
							If flag Then
								Me.myfromPt = Me.m_SelectedObject.GetCenter()
								Me.mytoPt = Me.myfromPt
								Me.mytoPt.X = Me.mytoPt.X + 1F
								Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
								Me.PictureBox1.Invalidate()
								Me.PictureBox2.Invalidate()
							Else
								flag = ((Control.ModifierKeys And Keys.Alt) = Keys.Alt)
								If flag Then
									Me.myrootPt = Me.m_SelectedObject.GetCenter()
									Me.m_SelectedObject.Rotate2(Me.myrootPt, modBanDo.myTinhChinhGocQuay)
									Me.PictureBox1.Invalidate()
									Me.PictureBox2.Invalidate()
								End If
							End If
						End If
					End If
				Case Keys.Down
					Dim flag As Boolean = Not Information.IsNothing(Me.m_SelectedObject)
					If flag Then
						Dim flag2 As Boolean = (Control.ModifierKeys And Keys.Control) = Keys.Control And (Control.ModifierKeys And Keys.Alt) = Keys.Alt
						If flag2 Then
							Dim rect4 As RectangleF = Me.m_SelectedObject.GetBounds()
							Dim dX4 As Single = 1F
							Dim dY4 As Single = (rect4.Height - 1F) / rect4.Height
							Me.myrootPt = Me.m_SelectedObject.GetCenter()
							Me.m_SelectedObject.Zoom2(Me.myrootPt, dX4, dY4)
							Me.PictureBox1.Invalidate()
							Me.PictureBox2.Invalidate()
						Else
							flag = ((Control.ModifierKeys And Keys.Control) = Keys.Control)
							If flag Then
								Me.myfromPt = Me.m_SelectedObject.GetCenter()
								Me.mytoPt = Me.myfromPt
								Me.mytoPt.Y = Me.mytoPt.Y + 1F
								Me.m_SelectedObject.Move(Me.myfromPt, Me.mytoPt)
								Me.PictureBox1.Invalidate()
								Me.PictureBox2.Invalidate()
							Else
								flag = ((Control.ModifierKeys And Keys.Alt) = Keys.Alt)
								If flag Then
								End If
							End If
						End If
					End If
				Case Keys.Delete
					Dim flag2 As Boolean = Not Information.IsNothing(Me.m_SelectedObject)
					If flag2 Then
						Me.m_drawingObjects.Remove(Me.m_SelectedObject)
						Me.PictureBox1.Invalidate()
						Me.PictureBox2.Invalidate()
					End If
			End Select
		End Sub

		Private Sub mnuGroupAllPast_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(myModule.fMain.myBando.SelectedSymbol)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.m_drawingObjects.Clear()
				Dim mLeft As Single = 0F
				Dim mTop As Single = 0F
				Dim mWidth As Single = 0F
				Dim mHeight As Single = 0F
				Try
					Dim enumerator As IEnumerator = myModule.fMain.myBando.SelectedSymbol.GObjs.GetEnumerator()
					While enumerator.MoveNext()
						Dim obj As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim mRect As RectangleF = obj.GetBounds()
						flag = (mRect.Left < mLeft)
						If flag Then
							mLeft = mRect.Left
						End If
						flag = (mRect.Top < mTop)
						If flag Then
							mTop = mRect.Top
						End If
						flag = (mRect.Width > mWidth)
						If flag Then
							mWidth = mRect.Width
						End If
						flag = (mRect.Height > mHeight)
						If flag Then
							mHeight = mRect.Height
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				' The following expression was wrapped in a unchecked-expression
				Me.myRootX = CInt(Math.Round(CDec(-mLeft)))
				' The following expression was wrapped in a unchecked-expression
				Me.myRootY = CInt(Math.Round(CDec(-mTop)))
				Me.myWidth = CInt(Math.Round(CDec(mWidth)))
				Me.myHeight = CInt(Math.Round(CDec(mHeight)))
				Try
					Dim enumerator2 As IEnumerator = myModule.fMain.myBando.SelectedSymbol.GObjs.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
						Dim oobj As GraphicObject = obj2.Clone()
						Dim arg_1AF_0 As GraphicObject = oobj
						Dim pointF As PointF = New PointF(0F, 0F)
						Dim arg_1AF_1 As PointF = pointF
						Dim toPt As PointF = New PointF(CSng(Me.myRootX), CSng(Me.myRootY))
						arg_1AF_0.Move(arg_1AF_1, toPt)
						Me.m_drawingObjects.Add(oobj)
					End While
				Finally
					Dim enumerator2 As IEnumerator
					flag = (TypeOf enumerator2 Is IDisposable)
					If flag Then
						(TryCast(enumerator2, IDisposable)).Dispose()
					End If
				End Try
				Me.ThayDoiGrid()
				Me.DisplayScrollBars()
				Me.PictureBox1.Invalidate()
				Me.PictureBox2.Invalidate()
			End If
		End Sub

		Public Sub CopyFromMap(pSymbol As CSymbol)
			Dim flag As Boolean = Not Information.IsNothing(pSymbol)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mObjects As CGraphicObjs = New CGraphicObjs()
				Dim mLeft As Single = 0F
				Dim mTop As Single = 0F
				Dim mWidth As Single = 10F
				Dim mHeight As Single = 10F
				Try
					Dim enumerator As IEnumerator = pSymbol.GObjs.GetEnumerator()
					While enumerator.MoveNext()
						Dim obj As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim mRect As RectangleF = obj.GetBounds()
						flag = (mRect.Left < mLeft)
						If flag Then
							mLeft = mRect.Left
						End If
						flag = (mRect.Top < mTop)
						If flag Then
							mTop = mRect.Top
						End If
						flag = (mRect.Width > mWidth)
						If flag Then
							mWidth = mRect.Width
						End If
						flag = (mRect.Height > mHeight)
						If flag Then
							mHeight = mRect.Height
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				' The following expression was wrapped in a unchecked-expression
				Dim mRootX As Integer = CInt(Math.Round(CDec(-mLeft)))
				' The following expression was wrapped in a unchecked-expression
				Dim mRootY As Integer = CInt(Math.Round(CDec(-mTop)))
				Try
					Dim enumerator2 As IEnumerator = pSymbol.GObjs.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj2 As GraphicObject = CType(enumerator2.Current, GraphicObject)
						Dim oobj As GraphicObject = obj2.Clone()
						Dim arg_15A_0 As GraphicObject = oobj
						Dim pointF As PointF = New PointF(0F, 0F)
						Dim arg_15A_1 As PointF = pointF
						Dim toPt As PointF = New PointF(CSng(mRootX), CSng(mRootY))
						arg_15A_0.Move(arg_15A_1, toPt)
						mObjects.Add(oobj)
					End While
				Finally
					Dim enumerator2 As IEnumerator
					flag = (TypeOf enumerator2 Is IDisposable)
					If flag Then
						(TryCast(enumerator2, IDisposable)).Dispose()
					End If
				End Try
				Dim mKyHieu As String = Me.Objects2String(CInt(Math.Round(CDec(mWidth))), CInt(Math.Round(CDec(mHeight))), mRootX, mRootY, mObjects)
				Dim mStt As Object = Me.GetMaxStt(CInt(modBanDo.myLoaiKH_ID)) + 1
				flag = Me.AddKyHieu(mKyHieu, pSymbol.Description, CInt(modBanDo.myLoaiKH_ID), Conversions.ToInteger(mStt))
				If flag Then
					Me.myThumbNails.SelectedIndex = Me.myThumbNails.Count - 1
				End If
			End If
		End Sub

		Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs)
			myModule.fMain.myBando.NhanKHXong()
		End Sub

		Private Sub cmnuDeleteKH_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = MessageBox.Show("Xóa ký hi" & ChrW(7879) & "u này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Me.btnDelete_Click(Nothing, Nothing)
			End If
		End Sub

		Private Sub cmnuCopyTo_Click(sender As Object, e As EventArgs)
			Dim f As dlgCopyKH = New dlgCopyKH()
			Dim dBiTraDM As DBiTraDM = f.DBiTraDM1
			dBiTraDM.ConnStr = Me.myKHConnStr
			dBiTraDM.TableName = "tblLoaiKH"
			dBiTraDM.MaFieldName = "MaLoaiKH"
			dBiTraDM.TenFieldName = "TenLoaiKH"
			dBiTraDM.CuoiFieldName = "Cuoi"
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Dim mKyHieu As String = Me.Objects2String(Me.myWidth, Me.myHeight, Me.myRootX, Me.myRootY, Me.m_drawingObjects)
				' The following expression was wrapped in a checked-expression
				Dim mStt As Object = Me.GetMaxStt(Conversions.ToInteger(f.txtLoaiKH_ID.Text)) + 1
				Me.AddKyHieu(mKyHieu, Me.txtTenKH.Text, Conversions.ToInteger(f.txtLoaiKH_ID.Text), Conversions.ToInteger(mStt))
			End If
		End Sub

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgCacKyHieu_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgCacKyHieu_Load
			dlgCacKyHieu.__ENCList.Add(New WeakReference(Me))
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
			Dim flag As Boolean = modBanDo.myLoaiKH_ID > 0L
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean = Me.myThumbNails.SelectedIndex > 0
				If flag2 Then
					Dim mIndex As Integer = Me.myThumbNails.SelectedIndex
					flag2 = Not Me.SoTTisOK(CInt(modBanDo.myLoaiKH_ID))
					If flag2 Then
						Me.DanhSoTT(CInt(modBanDo.myLoaiKH_ID))
					End If
					Dim mcurrKH_ID As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex).ID
					Dim mprevKH_ID As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex - 1).ID
					Dim prevSoTT As Integer = Me.GetSoTT(mprevKH_ID)
					Dim currSoTT As Integer = Me.GetSoTT(mcurrKH_ID)
					Me.UpdateSoTT(mprevKH_ID, currSoTT)
					Me.UpdateSoTT(mcurrKH_ID, prevSoTT)
					Me.PopulateList(CInt(modBanDo.myLoaiKH_ID))
					Me.myThumbNails.SelectedIndex = mIndex - 1
					Me.myThumbNails.CalculateRowsAndColumns()
					Me.picThumbNails.Invalidate()
				End If
			Else
				Interaction.MsgBox("Ch" & ChrW(7881) & " s" & ChrW(7855) & "p x" & ChrW(7871) & "p th" & ChrW(7913) & " t" & ChrW(7921) & " trong t" & ChrW(7915) & "ng nhóm!", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub MnuGroupCopy_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_EditingObjects.Count > 0
			If flag Then
				Me.m_CopyObjects.Clear()
				Try
					Dim enumerator As IEnumerator = Me.m_EditingObjects.GetEnumerator()
					While enumerator.MoveNext()
						Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim oobj As GraphicObject = mObj.Clone()
						Me.m_CopyObjects.Add(oobj)
					End While
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
			End If
		End Sub

		Private Sub mnuGroupPast_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_CopyObjects.Count > 0
			If flag Then
				Me.m_selectedObjects.Clear()
				Try
					Dim enumerator As IEnumerator = Me.m_CopyObjects.GetEnumerator()
					While enumerator.MoveNext()
						Dim obj As GraphicObject = CType(enumerator.Current, GraphicObject)
						Dim oobj As GraphicObject = obj.Clone()
						Me.m_drawingObjects.Add(oobj)
						Me.m_selectedObjects.Add(oobj)
					End While
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
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
			Dim flag As Boolean = modBanDo.myLoaiKH_ID > 0L
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean = Me.myThumbNails.SelectedIndex < Me.myThumbNails.Count - 1
				If flag2 Then
					Dim mIndex As Integer = Me.myThumbNails.SelectedIndex
					flag2 = Not Me.SoTTisOK(CInt(modBanDo.myLoaiKH_ID))
					If flag2 Then
						Me.DanhSoTT(CInt(modBanDo.myLoaiKH_ID))
					End If
					Dim mcurrKH_ID As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex).ID
					Dim mnextKH_ID As Integer = Me.myThumbNails(Me.myThumbNails.SelectedIndex + 1).ID
					Dim nextSoTT As Integer = Me.GetSoTT(mnextKH_ID)
					Dim currSoTT As Integer = Me.GetSoTT(mcurrKH_ID)
					Me.UpdateSoTT(mnextKH_ID, currSoTT)
					Me.UpdateSoTT(mcurrKH_ID, nextSoTT)
					Me.PopulateList(CInt(modBanDo.myLoaiKH_ID))
					Me.myThumbNails.SelectedIndex = mIndex + 1
					Me.myThumbNails.CalculateRowsAndColumns()
					Me.picThumbNails.Invalidate()
				End If
			Else
				Interaction.MsgBox("Ch" & ChrW(7881) & " s" & ChrW(7855) & "p x" & ChrW(7871) & "p th" & ChrW(7913) & " t" & ChrW(7921) & " trong t" & ChrW(7915) & "ng nhóm!", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub
	End Class
End Namespace
