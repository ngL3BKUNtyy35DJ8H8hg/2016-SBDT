Imports AxMapXLib
Imports DBiGraphicObjs.DBiGraphicObjects
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml

Namespace BdTC
	Public Class CBanDo
		Private Structure SPLITSYMBOLS
			Public Symbol1 As CSymbol

			Public Symbol2 As CSymbol
		End Structure

		Public Enum MapTools
			None
			Polygon
			Line
			Curve
			ClosedCurve
			Bezier
			Cycle
			Rectangle
			arc
			Text
			Table
			MuiTenDon
			MuiTen
			MuiTenDac
			MuiTenHo
			SongSong
			SongSongKin
			ChonKH
			Move
			DangMove
			Scale
			DangScale
			Rotate
			DangRotate
			GrMove
			GrDangMove
			Split
			DangSplit
			DangLayKH
			NodesEdit
			ChangeRoot
			Ruler
			GetTarget
			GetObjName
		End Enum

		Private Shared __ENCList As ArrayList = New ArrayList()

		<AccessedThroughProperty("CxtMnuLineStyle")>
		Private _CxtMnuLineStyle As ContextMenu

		<AccessedThroughProperty("CxtMnuKyHieu")>
		Private _CxtMnuKyHieu As ContextMenu

		<AccessedThroughProperty("MnuKHMove")>
		Private _MnuKHMove As MenuItem

		<AccessedThroughProperty("MnuKHBar1")>
		Private _MnuKHBar1 As MenuItem

		<AccessedThroughProperty("MnuScale")>
		Private _MnuScale As MenuItem

		<AccessedThroughProperty("MenuItem8")>
		Private _MenuItem8 As MenuItem

		<AccessedThroughProperty("MnuRotate")>
		Private _MnuRotate As MenuItem

		<AccessedThroughProperty("MnuKHBar3")>
		Private _MnuKHBar3 As MenuItem

		<AccessedThroughProperty("MnuVFlip")>
		Private _MnuVFlip As MenuItem

		<AccessedThroughProperty("MenuItem10")>
		Private _MenuItem10 As MenuItem

		<AccessedThroughProperty("MnuEditNodes")>
		Private _MnuEditNodes As MenuItem

		<AccessedThroughProperty("MenuItem11")>
		Private _MenuItem11 As MenuItem

		<AccessedThroughProperty("MnuChangeRoot")>
		Private _MnuChangeRoot As MenuItem

		<AccessedThroughProperty("MenuItem13")>
		Private _MenuItem13 As MenuItem

		<AccessedThroughProperty("MnuChangeDesc")>
		Private _MnuChangeDesc As MenuItem

		<AccessedThroughProperty("MnuKHBar2")>
		Private _MnuKHBar2 As MenuItem

		<AccessedThroughProperty("MnuBlinking")>
		Private _MnuBlinking As MenuItem

		<AccessedThroughProperty("MenuItem9")>
		Private _MenuItem9 As MenuItem

		<AccessedThroughProperty("MnuDeleteKH")>
		Private _MnuDeleteKH As MenuItem

		<AccessedThroughProperty("MnuPartsBar")>
		Private _MnuPartsBar As MenuItem

		<AccessedThroughProperty("MnuParts")>
		Private _MnuParts As MenuItem

		<AccessedThroughProperty("MnuCopyKHprev")>
		Private _MnuCopyKHprev As MenuItem

		<AccessedThroughProperty("MnuCopyKH")>
		Private _MnuCopyKH As MenuItem

		<AccessedThroughProperty("MnuCopyToVeKHprev")>
		Private _MnuCopyToVeKHprev As MenuItem

		<AccessedThroughProperty("MnuCopyToVeKH")>
		Private _MnuCopyToVeKH As MenuItem

		<AccessedThroughProperty("MnuSendBackprev")>
		Private _MnuSendBackprev As MenuItem

		<AccessedThroughProperty("MnuSendBack")>
		Private _MnuSendBack As MenuItem

		<AccessedThroughProperty("MnuSendFrontprev")>
		Private _MnuSendFrontprev As MenuItem

		<AccessedThroughProperty("MnuSendFront")>
		Private _MnuSendFront As MenuItem

		<AccessedThroughProperty("MnuCutPrev")>
		Private _MnuCutPrev As MenuItem

		<AccessedThroughProperty("MnuCut")>
		Private _MnuCut As MenuItem

		<AccessedThroughProperty("MnuToCurvePrev")>
		Private _MnuToCurvePrev As MenuItem

		<AccessedThroughProperty("MnuToCurve")>
		Private _MnuToCurve As MenuItem

		<AccessedThroughProperty("MnuToPhanRaPrev")>
		Private _MnuToPhanRaPrev As MenuItem

		<AccessedThroughProperty("MnuToPhanRa")>
		Private _MnuToPhanRa As MenuItem

		<AccessedThroughProperty("MnuClosed2Curveprev")>
		Private _MnuClosed2Curveprev As MenuItem

		<AccessedThroughProperty("MnuClosed2Curve")>
		Private _MnuClosed2Curve As MenuItem

		<AccessedThroughProperty("MnuCurve2Closedprev")>
		Private _MnuCurve2Closedprev As MenuItem

		<AccessedThroughProperty("MnuCurve2Closed")>
		Private _MnuCurve2Closed As MenuItem

		<AccessedThroughProperty("MnuTo1stNodeprev")>
		Private _MnuTo1stNodeprev As MenuItem

		<AccessedThroughProperty("MnuTo1stNode")>
		Private _MnuTo1stNode As MenuItem

		<AccessedThroughProperty("MnuTo1ObjectPrev")>
		Private _MnuTo1ObjectPrev As MenuItem

		<AccessedThroughProperty("MnuTo1Object")>
		Private _MnuTo1Object As MenuItem

		<AccessedThroughProperty("CxtMnuGroup")>
		Private _CxtMnuGroup As ContextMenu

		<AccessedThroughProperty("MnuGrMove")>
		Private _MnuGrMove As MenuItem

		<AccessedThroughProperty("MnuGrBar1")>
		Private _MnuGrBar1 As MenuItem

		<AccessedThroughProperty("MnuGrCopy")>
		Private _MnuGrCopy As MenuItem

		<AccessedThroughProperty("MnuGrBar2")>
		Private _MnuGrBar2 As MenuItem

		<AccessedThroughProperty("MnuGrCut")>
		Private _MnuGrCut As MenuItem

		<AccessedThroughProperty("MnuGrBar3")>
		Private _MnuGrBar3 As MenuItem

		<AccessedThroughProperty("MnuGrChangeColor")>
		Private _MnuGrChangeColor As MenuItem

		<AccessedThroughProperty("MnuGrBar4")>
		Private _MnuGrBar4 As MenuItem

		<AccessedThroughProperty("MnuGrNhom")>
		Private _MnuGrNhom As MenuItem

		<AccessedThroughProperty("CxtMnuPart")>
		Private _CxtMnuPart As ContextMenu

		<AccessedThroughProperty("MnuChangeColor")>
		Private _MnuChangeColor As MenuItem

		<AccessedThroughProperty("MnuPartBar1")>
		Private _MnuPartBar1 As MenuItem

		<AccessedThroughProperty("MnuDeleteShape")>
		Private _MnuDeleteShape As MenuItem

		<AccessedThroughProperty("MnuPartBar2")>
		Private _MnuPartBar2 As MenuItem

		<AccessedThroughProperty("MnuPartSendBack")>
		Private _MnuPartSendBack As MenuItem

		<AccessedThroughProperty("MnuPartBar3")>
		Private _MnuPartBar3 As MenuItem

		<AccessedThroughProperty("MnuPartSendFront")>
		Private _MnuPartSendFront As MenuItem

		<AccessedThroughProperty("MnuPartBar4")>
		Private _MnuPartBar4 As MenuItem

		<AccessedThroughProperty("MnuPartTachObject")>
		Private _MnuPartTachObject As MenuItem

		<AccessedThroughProperty("CxtMnuNodeEdit")>
		Private _CxtMnuNodeEdit As ContextMenu

		<AccessedThroughProperty("MnXoaNode")>
		Private _MnXoaNode As MenuItem

		<AccessedThroughProperty("MenuItem5")>
		Private _MenuItem5 As MenuItem

		<AccessedThroughProperty("MnuAddNode")>
		Private _MnuAddNode As MenuItem

		<AccessedThroughProperty("MenuItem7")>
		Private _MenuItem7 As MenuItem

		<AccessedThroughProperty("MnuChangeNodeType")>
		Private _MnuChangeNodeType As MenuItem

		<AccessedThroughProperty("CxtMnuMap")>
		Private _CxtMnuMap As ContextMenu

		<AccessedThroughProperty("MnuPastKH")>
		Private _MnuPastKH As MenuItem

		Private iUndo As Integer

		Private iRedo As Integer

		Private myMapScreenWidth As Single

		Public myMapCurrTool As Object

		Public myMapTool As CBanDo.MapTools

		Private myPts As PointF()

		Private myfromPt As PointF

		Private mytoPt As PointF

		Private myrootPt As PointF

		Private m_SelectedSymbol As CSymbol

		Private m_CopySymbol As CSymbol

		Private m_KHfromVeKH As CSymbol

		Private m_DrawingSymbols As CSymbols

		Private m_SelectedSymbols As CSymbols

		Private m_CopySymbols As CSymbols

		Private m_SelectedObject As GraphicObject

		Private m_drawingObjects As CGraphicObjs

		Private m_selectedObjects As CGraphicObjs

		Private NodeDragging As Boolean

		Private RootDragging As Boolean

		Private selectionDragging As Boolean

		Private selectionRect As RectangleF

		Private DrawingDragging As Boolean

		Private DrawingRect As System.Drawing.Rectangle

		Private DrawingPicking As Boolean

		Private EditObj As GraphicObject

		Private iEditNode As Integer

		Private FoundNode As CFOUNDNODE

		Private FoundObject As CFOUNDOBJECT

		Public bBanDo2Loaded As Boolean

		Private bSnap As Boolean

		Private bGrid As Boolean

		Public myGridWidth As Integer

		Private myWidth As Integer

		Private myHeight As Integer

		Private GridSize As Size

		Private GridRect As System.Drawing.Rectangle

		<AccessedThroughProperty("m_Map")>
		Private _m_Map As AxMap

		Private m_ParentForm As frmMain

		Private m_Panel As Panel

		Public dtDiaDanhTable As DataTable

		Private myDistanceUnit As Integer

		Private strDistanceUnit As String

		Private strDistanceKQ As String

		Private DistanceKQ As Integer

		Public myZoom As Double

		Public myCX As Double

		Public myCY As Double

		Private toolTip1 As ToolTip

		Private mousePos As PointF

		Private myDoCao As Single

		Private txtKQ As TextBox

		Private txtObjType As TextBox

		Friend Overridable Property CxtMnuLineStyle() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._CxtMnuLineStyle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._CxtMnuLineStyle = value
			End Set
		End Property

		Friend Overridable Property CxtMnuKyHieu() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._CxtMnuKyHieu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Dim flag As Boolean = Me._CxtMnuKyHieu IsNot Nothing
				If flag Then
					RemoveHandler Me._CxtMnuKyHieu.Popup, AddressOf Me.CxtMnuKyHieu_Popup
				End If
				Me._CxtMnuKyHieu = value
				flag = (Me._CxtMnuKyHieu IsNot Nothing)
				If flag Then
					AddHandler Me._CxtMnuKyHieu.Popup, AddressOf Me.CxtMnuKyHieu_Popup
				End If
			End Set
		End Property

		Friend Overridable Property MnuKHMove() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuKHMove
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuKHMove IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuKHMove.Click, AddressOf Me.MnuKHMove_Click
				End If
				Me._MnuKHMove = value
				flag = (Me._MnuKHMove IsNot Nothing)
				If flag Then
					AddHandler Me._MnuKHMove.Click, AddressOf Me.MnuKHMove_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuKHBar1() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuKHBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuKHBar1 = value
			End Set
		End Property

		Friend Overridable Property MnuScale() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuScale
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuScale IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuScale.Click, AddressOf Me.MnuScale_Click
				End If
				Me._MnuScale = value
				flag = (Me._MnuScale IsNot Nothing)
				If flag Then
					AddHandler Me._MnuScale.Click, AddressOf Me.MnuScale_Click
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

		Friend Overridable Property MnuRotate() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuRotate
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuRotate IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuRotate.Click, AddressOf Me.MnuRotate_Click
				End If
				Me._MnuRotate = value
				flag = (Me._MnuRotate IsNot Nothing)
				If flag Then
					AddHandler Me._MnuRotate.Click, AddressOf Me.MnuRotate_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuKHBar3() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuKHBar3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuKHBar3 = value
			End Set
		End Property

		Friend Overridable Property MnuVFlip() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuVFlip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuVFlip IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuVFlip.Click, AddressOf Me.MnuVFlip_Click
				End If
				Me._MnuVFlip = value
				flag = (Me._MnuVFlip IsNot Nothing)
				If flag Then
					AddHandler Me._MnuVFlip.Click, AddressOf Me.MnuVFlip_Click
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

		Friend Overridable Property MnuEditNodes() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuEditNodes
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuEditNodes IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuEditNodes.Click, AddressOf Me.MnuEditNodes_Click
				End If
				Me._MnuEditNodes = value
				flag = (Me._MnuEditNodes IsNot Nothing)
				If flag Then
					AddHandler Me._MnuEditNodes.Click, AddressOf Me.MnuEditNodes_Click
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

		Friend Overridable Property MnuChangeRoot() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuChangeRoot
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuChangeRoot IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuChangeRoot.Click, AddressOf Me.MnuChangeRoot_Click
				End If
				Me._MnuChangeRoot = value
				flag = (Me._MnuChangeRoot IsNot Nothing)
				If flag Then
					AddHandler Me._MnuChangeRoot.Click, AddressOf Me.MnuChangeRoot_Click
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

		Friend Overridable Property MnuChangeDesc() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuChangeDesc
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuChangeDesc IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuChangeDesc.Click, AddressOf Me.MnuChangeDesc_Click
				End If
				Me._MnuChangeDesc = value
				flag = (Me._MnuChangeDesc IsNot Nothing)
				If flag Then
					AddHandler Me._MnuChangeDesc.Click, AddressOf Me.MnuChangeDesc_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuKHBar2() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuKHBar2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuKHBar2 = value
			End Set
		End Property

		Friend Overridable Property MnuBlinking() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuBlinking
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuBlinking IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuBlinking.Click, AddressOf Me.MnuBlinking_Click
				End If
				Me._MnuBlinking = value
				flag = (Me._MnuBlinking IsNot Nothing)
				If flag Then
					AddHandler Me._MnuBlinking.Click, AddressOf Me.MnuBlinking_Click
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

		Friend Overridable Property MnuDeleteKH() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuDeleteKH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuDeleteKH IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuDeleteKH.Click, AddressOf Me.MnuDeleteKH_Click
				End If
				Me._MnuDeleteKH = value
				flag = (Me._MnuDeleteKH IsNot Nothing)
				If flag Then
					AddHandler Me._MnuDeleteKH.Click, AddressOf Me.MnuDeleteKH_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuPartsBar() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartsBar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuPartsBar = value
			End Set
		End Property

		Friend Overridable Property MnuParts() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuParts
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuParts = value
			End Set
		End Property

		Friend Overridable Property MnuCopyKHprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCopyKHprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuCopyKHprev = value
			End Set
		End Property

		Friend Overridable Property MnuCopyKH() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCopyKH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuCopyKH IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuCopyKH.Click, AddressOf Me.MnuCopyKH_Click
				End If
				Me._MnuCopyKH = value
				flag = (Me._MnuCopyKH IsNot Nothing)
				If flag Then
					AddHandler Me._MnuCopyKH.Click, AddressOf Me.MnuCopyKH_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuCopyToVeKHprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCopyToVeKHprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuCopyToVeKHprev = value
			End Set
		End Property

		Friend Overridable Property MnuCopyToVeKH() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCopyToVeKH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuCopyToVeKH IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuCopyToVeKH.Click, AddressOf Me.MnuCopyToVeKH_Click
				End If
				Me._MnuCopyToVeKH = value
				flag = (Me._MnuCopyToVeKH IsNot Nothing)
				If flag Then
					AddHandler Me._MnuCopyToVeKH.Click, AddressOf Me.MnuCopyToVeKH_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuSendBackprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuSendBackprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuSendBackprev = value
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

		Friend Overridable Property MnuSendFrontprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuSendFrontprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuSendFrontprev = value
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

		Friend Overridable Property MnuCutPrev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCutPrev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuCutPrev = value
			End Set
		End Property

		Friend Overridable Property MnuCut() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCut
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuCut IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuCut.Click, AddressOf Me.MnuCut_Click
				End If
				Me._MnuCut = value
				flag = (Me._MnuCut IsNot Nothing)
				If flag Then
					AddHandler Me._MnuCut.Click, AddressOf Me.MnuCut_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuToCurvePrev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuToCurvePrev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuToCurvePrev = value
			End Set
		End Property

		Friend Overridable Property MnuToCurve() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuToCurve
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuToCurve IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuToCurve.Click, AddressOf Me.MnuToCurve_Click
				End If
				Me._MnuToCurve = value
				flag = (Me._MnuToCurve IsNot Nothing)
				If flag Then
					AddHandler Me._MnuToCurve.Click, AddressOf Me.MnuToCurve_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuToPhanRaPrev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuToPhanRaPrev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuToPhanRaPrev = value
			End Set
		End Property

		Friend Overridable Property MnuToPhanRa() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuToPhanRa
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuToPhanRa IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuToPhanRa.Click, AddressOf Me.MnuToPhanRa_Click
				End If
				Me._MnuToPhanRa = value
				flag = (Me._MnuToPhanRa IsNot Nothing)
				If flag Then
					AddHandler Me._MnuToPhanRa.Click, AddressOf Me.MnuToPhanRa_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuClosed2Curveprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuClosed2Curveprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuClosed2Curveprev = value
			End Set
		End Property

		Friend Overridable Property MnuClosed2Curve() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuClosed2Curve
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuClosed2Curve IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuClosed2Curve.Click, AddressOf Me.MnuClosed2Curve_Click
				End If
				Me._MnuClosed2Curve = value
				flag = (Me._MnuClosed2Curve IsNot Nothing)
				If flag Then
					AddHandler Me._MnuClosed2Curve.Click, AddressOf Me.MnuClosed2Curve_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuCurve2Closedprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCurve2Closedprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuCurve2Closedprev = value
			End Set
		End Property

		Friend Overridable Property MnuCurve2Closed() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuCurve2Closed
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuCurve2Closed IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuCurve2Closed.Click, AddressOf Me.MnuCurve2Closed_Click
				End If
				Me._MnuCurve2Closed = value
				flag = (Me._MnuCurve2Closed IsNot Nothing)
				If flag Then
					AddHandler Me._MnuCurve2Closed.Click, AddressOf Me.MnuCurve2Closed_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuTo1stNodeprev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuTo1stNodeprev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuTo1stNodeprev = value
			End Set
		End Property

		Friend Overridable Property MnuTo1stNode() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuTo1stNode
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuTo1stNode IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuTo1stNode.Click, AddressOf Me.MnuTo1stNode_Click
				End If
				Me._MnuTo1stNode = value
				flag = (Me._MnuTo1stNode IsNot Nothing)
				If flag Then
					AddHandler Me._MnuTo1stNode.Click, AddressOf Me.MnuTo1stNode_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuTo1ObjectPrev() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuTo1ObjectPrev
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuTo1ObjectPrev = value
			End Set
		End Property

		Friend Overridable Property MnuTo1Object() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuTo1Object
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuTo1Object IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuTo1Object.Click, AddressOf Me.MnuTo1Object_Click
				End If
				Me._MnuTo1Object = value
				flag = (Me._MnuTo1Object IsNot Nothing)
				If flag Then
					AddHandler Me._MnuTo1Object.Click, AddressOf Me.MnuTo1Object_Click
				End If
			End Set
		End Property

		Friend Overridable Property CxtMnuGroup() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._CxtMnuGroup
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._CxtMnuGroup = value
			End Set
		End Property

		Friend Overridable Property MnuGrMove() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrMove
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGrMove IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGrMove.Click, AddressOf Me.MnuGrMove_Click
				End If
				Me._MnuGrMove = value
				flag = (Me._MnuGrMove IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGrMove.Click, AddressOf Me.MnuGrMove_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuGrBar1() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuGrBar1 = value
			End Set
		End Property

		Friend Overridable Property MnuGrCopy() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrCopy
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGrCopy IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGrCopy.Click, AddressOf Me.MnuGrCopy_Click
				End If
				Me._MnuGrCopy = value
				flag = (Me._MnuGrCopy IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGrCopy.Click, AddressOf Me.MnuGrCopy_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuGrBar2() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrBar2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuGrBar2 = value
			End Set
		End Property

		Friend Overridable Property MnuGrCut() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrCut
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGrCut IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGrCut.Click, AddressOf Me.MnuGrCut_Click
				End If
				Me._MnuGrCut = value
				flag = (Me._MnuGrCut IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGrCut.Click, AddressOf Me.MnuGrCut_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuGrBar3() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrBar3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuGrBar3 = value
			End Set
		End Property

		Friend Overridable Property MnuGrChangeColor() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrChangeColor
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGrChangeColor IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGrChangeColor.Click, AddressOf Me.MnuGrChangeColor_Click
				End If
				Me._MnuGrChangeColor = value
				flag = (Me._MnuGrChangeColor IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGrChangeColor.Click, AddressOf Me.MnuGrChangeColor_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuGrBar4() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrBar4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuGrBar4 = value
			End Set
		End Property

		Friend Overridable Property MnuGrNhom() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuGrNhom
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuGrNhom IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuGrNhom.Click, AddressOf Me.MnuGrNhom_Click
				End If
				Me._MnuGrNhom = value
				flag = (Me._MnuGrNhom IsNot Nothing)
				If flag Then
					AddHandler Me._MnuGrNhom.Click, AddressOf Me.MnuGrNhom_Click
				End If
			End Set
		End Property

		Friend Overridable Property CxtMnuPart() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._CxtMnuPart
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._CxtMnuPart = value
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

		Friend Overridable Property MnuPartBar1() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuPartBar1 = value
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

		Friend Overridable Property MnuPartBar2() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartBar2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuPartBar2 = value
			End Set
		End Property

		Friend Overridable Property MnuPartSendBack() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartSendBack
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuPartSendBack IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuPartSendBack.Click, AddressOf Me.MnuPartSendBack_Click
				End If
				Me._MnuPartSendBack = value
				flag = (Me._MnuPartSendBack IsNot Nothing)
				If flag Then
					AddHandler Me._MnuPartSendBack.Click, AddressOf Me.MnuPartSendBack_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuPartBar3() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartBar3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuPartBar3 = value
			End Set
		End Property

		Friend Overridable Property MnuPartSendFront() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartSendFront
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuPartSendFront IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuPartSendFront.Click, AddressOf Me.MnuPartSendFront_Click
				End If
				Me._MnuPartSendFront = value
				flag = (Me._MnuPartSendFront IsNot Nothing)
				If flag Then
					AddHandler Me._MnuPartSendFront.Click, AddressOf Me.MnuPartSendFront_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuPartBar4() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartBar4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MnuPartBar4 = value
			End Set
		End Property

		Friend Overridable Property MnuPartTachObject() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPartTachObject
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuPartTachObject IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuPartTachObject.Click, AddressOf Me.MnuPartTachObject_Click
				End If
				Me._MnuPartTachObject = value
				flag = (Me._MnuPartTachObject IsNot Nothing)
				If flag Then
					AddHandler Me._MnuPartTachObject.Click, AddressOf Me.MnuPartTachObject_Click
				End If
			End Set
		End Property

		Friend Overridable Property CxtMnuNodeEdit() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._CxtMnuNodeEdit
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._CxtMnuNodeEdit = value
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

		Friend Overridable Property CxtMnuMap() As ContextMenu
			<DebuggerNonUserCode()>
			Get
				Return Me._CxtMnuMap
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._CxtMnuMap = value
			End Set
		End Property

		Friend Overridable Property MnuPastKH() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPastKH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuPastKH IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuPastKH.Click, AddressOf Me.MnuPastKH_Click
				End If
				Me._MnuPastKH = value
				flag = (Me._MnuPastKH IsNot Nothing)
				If flag Then
					AddHandler Me._MnuPastKH.Click, AddressOf Me.MnuPastKH_Click
				End If
			End Set
		End Property

		Private Overridable Property m_Map() As AxMap
			<DebuggerNonUserCode()>
			Get
				Return Me._m_Map
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxMap)
				Dim flag As Boolean = Me._m_Map IsNot Nothing
				If flag Then
					RemoveHandler Me._m_Map.KeyUpEvent, AddressOf Me.m_Map_KeyUpEvent
					RemoveHandler Me._m_Map.ToolUsed, AddressOf Me.m_Map_ToolUsed
					RemoveHandler Me._m_Map.MouseUpEvent, AddressOf Me.m_Map_MouseUpEvent
					RemoveHandler Me._m_Map.MouseMoveEvent, AddressOf Me.m_Map_MouseMoveEvent
					RemoveHandler Me._m_Map.MouseDownEvent, AddressOf Me.m_Map_MouseDownEvent
					RemoveHandler Me._m_Map.MapViewChanged, AddressOf Me.m_Map_MapViewChanged
					RemoveHandler Me._m_Map.DrawUserLayer, AddressOf Me.m_Map_DrawUserLayer
				End If
				Me._m_Map = value
				flag = (Me._m_Map IsNot Nothing)
				If flag Then
					AddHandler Me._m_Map.KeyUpEvent, AddressOf Me.m_Map_KeyUpEvent
					AddHandler Me._m_Map.ToolUsed, AddressOf Me.m_Map_ToolUsed
					AddHandler Me._m_Map.MouseUpEvent, AddressOf Me.m_Map_MouseUpEvent
					AddHandler Me._m_Map.MouseMoveEvent, AddressOf Me.m_Map_MouseMoveEvent
					AddHandler Me._m_Map.MouseDownEvent, AddressOf Me.m_Map_MouseDownEvent
					AddHandler Me._m_Map.MapViewChanged, AddressOf Me.m_Map_MapViewChanged
					AddHandler Me._m_Map.DrawUserLayer, AddressOf Me.m_Map_DrawUserLayer
				End If
			End Set
		End Property

		Public ReadOnly Property myMap() As AxMap
			Get
				Return Me.m_Map
			End Get
		End Property

		Public Overridable ReadOnly Property drawingObjects() As CGraphicObjs
			Get
				Return Me.m_drawingObjects
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
						Me.m_Map.CenterX = Me.m_Map.CenterX
					End If
				End If
			End Set
		End Property

		Public Overridable Property drawingSymbols() As CSymbols
			Get
				Return Me.m_DrawingSymbols
			End Get
			Set(value As CSymbols)
				Me.m_DrawingSymbols = value
			End Set
		End Property

		Public Property SelectedSymbol() As CSymbol
			Get
				Return Me.m_SelectedSymbol
			End Get
			Set(value As CSymbol)
				Dim flag As Boolean = value IsNot Me.m_SelectedSymbol
				If flag Then
					Dim flag2 As Boolean = Me.m_DrawingSymbols.Contains(value) OrElse value Is Nothing
					If flag2 Then
						Me.m_SelectedSymbol = value
						Me.m_Map.CenterX = Me.m_Map.CenterX
					End If
				End If
			End Set
		End Property

		Public Overridable ReadOnly Property selectedObjects() As CGraphicObjs
			Get
				Return Me.m_selectedObjects
			End Get
		End Property

		Private Sub InitializeComponent()
			Me.CxtMnuGroup = New ContextMenu()
			Me.MnuGrMove = New MenuItem()
			Me.MnuGrBar1 = New MenuItem()
			Me.MnuGrCopy = New MenuItem()
			Me.MnuGrBar2 = New MenuItem()
			Me.MnuGrCut = New MenuItem()
			Me.MnuGrBar3 = New MenuItem()
			Me.MnuGrChangeColor = New MenuItem()
			Me.MnuGrBar4 = New MenuItem()
			Me.MnuGrNhom = New MenuItem()
			Me.CxtMnuPart = New ContextMenu()
			Me.MnuChangeColor = New MenuItem()
			Me.MnuPartBar1 = New MenuItem()
			Me.MnuDeleteShape = New MenuItem()
			Me.MnuPartBar2 = New MenuItem()
			Me.MnuPartSendBack = New MenuItem()
			Me.MnuPartBar3 = New MenuItem()
			Me.MnuPartSendFront = New MenuItem()
			Me.MnuPartBar4 = New MenuItem()
			Me.MnuPartTachObject = New MenuItem()
			Me.CxtMnuNodeEdit = New ContextMenu()
			Me.MnXoaNode = New MenuItem()
			Me.MenuItem5 = New MenuItem()
			Me.MnuAddNode = New MenuItem()
			Me.MenuItem7 = New MenuItem()
			Me.MnuChangeNodeType = New MenuItem()
			Me.CxtMnuKyHieu = New ContextMenu()
			Me.MnuKHMove = New MenuItem()
			Me.MnuKHBar1 = New MenuItem()
			Me.MnuScale = New MenuItem()
			Me.MenuItem8 = New MenuItem()
			Me.MnuRotate = New MenuItem()
			Me.MnuKHBar3 = New MenuItem()
			Me.MnuVFlip = New MenuItem()
			Me.MenuItem10 = New MenuItem()
			Me.MnuEditNodes = New MenuItem()
			Me.MenuItem11 = New MenuItem()
			Me.MnuChangeRoot = New MenuItem()
			Me.MenuItem13 = New MenuItem()
			Me.MnuChangeDesc = New MenuItem()
			Me.MnuKHBar2 = New MenuItem()
			Me.MnuBlinking = New MenuItem()
			Me.MenuItem9 = New MenuItem()
			Me.MnuDeleteKH = New MenuItem()
			Me.CxtMnuMap = New ContextMenu()
			Me.MnuPastKH = New MenuItem()
			Me.CxtMnuGroup.MenuItems.AddRange(New MenuItem() { Me.MnuGrMove, Me.MnuGrBar1, Me.MnuGrCopy, Me.MnuGrBar2, Me.MnuGrCut, Me.MnuGrBar3, Me.MnuGrChangeColor, Me.MnuGrBar4, Me.MnuGrNhom })
			Me.MnuGrMove.Text = "Di chuy" & ChrW(7875) & "n Nhóm Ký hi" & ChrW(7879) & "u"
			Me.MnuGrBar1.Text = "-"
			Me.MnuGrCopy.Text = "Copy Nhóm Ký hi" & ChrW(7879) & "u"
			Me.MnuGrBar2.Text = "-"
			Me.MnuGrCut.Text = "Xoá c" & ChrW(7843) & " Nhóm Ký hi" & ChrW(7879) & "u"
			Me.MnuGrBar3.Text = "-"
			Me.MnuGrChangeColor.Text = "Thay M" & ChrW(7847) & "u,Nét,Ki" & ChrW(7875) & "u Nét"
			Me.MnuGrBar4.Text = "-"
			Me.MnuGrNhom.Text = "Nhóm thành 1 Ký hi" & ChrW(7879) & "u"
			Me.CxtMnuPart.MenuItems.AddRange(New MenuItem() { Me.MnuChangeColor, Me.MnuPartBar1, Me.MnuDeleteShape, Me.MnuPartBar2, Me.MnuPartSendBack, Me.MnuPartBar3, Me.MnuPartSendFront, Me.MnuPartBar4, Me.MnuPartTachObject })
			Me.MnuChangeColor.Text = ChrW(272) & ChrW(7893) & "i chi ti" & ChrW(7871) & "t"
			Me.MnuPartBar1.Text = "-"
			Me.MnuDeleteShape.Text = "Xóa chi ti" & ChrW(7871) & "t"
			Me.MnuPartBar2.Text = "-"
			Me.MnuPartSendBack.Text = "Chi ti" & ChrW(7871) & "t Xu" & ChrW(7889) & "ng d" & ChrW(432) & ChrW(7899) & "i"
			Me.MnuPartBar3.Text = "-"
			Me.MnuPartSendFront.Text = "Chi ti" & ChrW(7871) & "t Lên trên"
			Me.MnuPartBar4.Text = "-"
			Me.MnuPartTachObject.Text = "Tách thành KH riêng"
			Me.CxtMnuNodeEdit.MenuItems.AddRange(New MenuItem() { Me.MnXoaNode, Me.MenuItem5, Me.MnuAddNode, Me.MenuItem7, Me.MnuChangeNodeType })
			Me.MnXoaNode.Text = "Xóa nút"
			Me.MenuItem5.Text = "-"
			Me.MnuAddNode.Text = "Thêm nút"
			Me.MenuItem7.Text = "-"
			Me.MnuChangeNodeType.Text = ChrW(272) & ChrW(7893) & "i Ki" & ChrW(7875) & "u nút"
			Me.MnuTo1stNodeprev = New MenuItem()
			Me.MnuTo1stNode = New MenuItem()
			Me.CxtMnuNodeEdit.MenuItems.Add(Me.MnuTo1stNodeprev)
			Me.CxtMnuNodeEdit.MenuItems.Add(Me.MnuTo1stNode)
			Me.MnuTo1stNodeprev.Text = "-"
			Me.MnuTo1stNode.Text = "Thành nút " & ChrW(273) & ChrW(7847) & "u"
			Me.MnuTo1ObjectPrev = New MenuItem()
			Me.MnuTo1Object = New MenuItem()
			Me.CxtMnuNodeEdit.MenuItems.Add(Me.MnuTo1ObjectPrev)
			Me.CxtMnuNodeEdit.MenuItems.Add(Me.MnuTo1Object)
			Me.MnuTo1ObjectPrev.Text = "-"
			Me.MnuTo1Object.Text = "N" & ChrW(7889) & "i chi ti" & ChrW(7871) & "t"
			Me.MnuCutPrev = New MenuItem()
			Me.MnuCut = New MenuItem()
			Me.MnuToCurvePrev = New MenuItem()
			Me.MnuToCurve = New MenuItem()
			Me.MnuToPhanRaPrev = New MenuItem()
			Me.MnuToPhanRa = New MenuItem()
			Me.CxtMnuKyHieu.MenuItems.AddRange(New MenuItem() { Me.MnuKHMove, Me.MnuKHBar1, Me.MnuScale, Me.MenuItem8, Me.MnuRotate, Me.MnuKHBar3, Me.MnuVFlip, Me.MnuCutPrev, Me.MnuCut, Me.MnuToCurvePrev, Me.MnuToCurve, Me.MnuToPhanRaPrev, Me.MnuToPhanRa, Me.MenuItem10, Me.MnuEditNodes, Me.MenuItem11, Me.MnuChangeRoot, Me.MenuItem13, Me.MnuChangeDesc, Me.MnuKHBar2, Me.MnuBlinking, Me.MenuItem9, Me.MnuDeleteKH })
			Me.MnuKHMove.Text = "D" & ChrW(7901) & "i Ký hi" & ChrW(7879) & "u"
			Me.MnuKHBar1.Text = "-"
			Me.MnuScale.Text = "Thu-Phóng Ký hi" & ChrW(7879) & "u"
			Me.MenuItem8.Text = "-"
			Me.MnuRotate.Text = "Quay Ký hi" & ChrW(7879) & "u"
			Me.MnuKHBar3.Text = "-"
			Me.MnuVFlip.Text = "L" & ChrW(7853) & "t Ký hi" & ChrW(7879) & "u"
			Me.MnuCutPrev.Text = "-"
			Me.MnuCut.Text = "C" & ChrW(7855) & "t " & ChrW(273) & "ôi Ký hi" & ChrW(7879) & "u"
			Me.MnuToCurvePrev.Text = "-"
			Me.MnuToCurve.Text = ChrW(272) & ChrW(7893) & "i thành " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng cong"
			Me.MnuToPhanRaPrev.Text = "-"
			Me.MnuToPhanRa.Text = "Tách t" & ChrW(7845) & "t c" & ChrW(7843) & " các chi ti" & ChrW(7871) & "t"
			Me.MenuItem10.Text = "-"
			Me.MnuEditNodes.Text = "Tinh ch" & ChrW(7881) & "nh"
			Me.MenuItem11.Text = "-"
			Me.MnuChangeRoot.Text = "Thay " & ChrW(273) & ChrW(7893) & "i g" & ChrW(7889) & "c KH"
			Me.MenuItem13.Text = "-"
			Me.MnuChangeDesc.Text = ChrW(272) & ChrW(7893) & "i ghi chú"
			Me.MnuKHBar2.Text = "-"
			Me.MnuBlinking.Text = "Nh" & ChrW(7845) & "p nháy"
			Me.MenuItem9.Text = "-"
			Me.MnuDeleteKH.Text = "Xóa Ký Hi" & ChrW(7879) & "u"
			Me.CxtMnuMap.MenuItems.AddRange(New MenuItem() { Me.MnuPastKH })
			Me.MnuPastKH.Text = "Dán Ký hi" & ChrW(7879) & "u"
			Me.MnuCopyKHprev = New MenuItem()
			Me.MnuCopyKH = New MenuItem()
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuCopyKHprev)
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuCopyKH)
			Me.MnuCopyKHprev.Text = "-"
			Me.MnuCopyKH.Text = "Copy Ký hi" & ChrW(7879) & "u"
			Me.MnuCopyToVeKHprev = New MenuItem()
			Me.MnuCopyToVeKH = New MenuItem()
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuCopyToVeKHprev)
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuCopyToVeKH)
			Me.MnuCopyToVeKHprev.Text = "-"
			Me.MnuCopyToVeKH.Text = "Copy sang Các Ký hi" & ChrW(7879) & "u"
			Me.MnuSendBackprev = New MenuItem()
			Me.MnuSendBack = New MenuItem()
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuSendBackprev)
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuSendBack)
			Me.MnuSendBackprev.Text = "-"
			Me.MnuSendBack.Text = "Cho xu" & ChrW(7889) & "ng d" & ChrW(432) & ChrW(7899) & "i"
			Me.MnuSendFrontprev = New MenuItem()
			Me.MnuSendFront = New MenuItem()
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuSendFrontprev)
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuSendFront)
			Me.MnuSendFrontprev.Text = "-"
			Me.MnuSendFront.Text = "Cho lên trên"
			Me.MnuPartsBar = New MenuItem()
			Me.MnuParts = New MenuItem()
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuPartsBar)
			Me.CxtMnuKyHieu.MenuItems.Add(Me.MnuParts)
			Me.MnuPartsBar.Text = "-"
			Me.MnuParts.Text = "Thay " & ChrW(273) & ChrW(7893) & "i chi ti" & ChrW(7871) & "t"
			Me.MnuParts.MenuItems.AddRange(New MenuItem() { Me.MnuChangeColor, Me.MnuPartBar1, Me.MnuDeleteShape, Me.MnuPartBar2, Me.MnuPartSendBack, Me.MnuPartBar3, Me.MnuPartSendFront, Me.MnuPartBar4, Me.MnuPartTachObject })
			Me.MnuClosed2Curveprev = New MenuItem()
			Me.MnuClosed2Curve = New MenuItem()
			Me.MnuParts.MenuItems.Add(Me.MnuClosed2Curveprev)
			Me.MnuParts.MenuItems.Add(Me.MnuClosed2Curve)
			Me.MnuClosed2Curveprev.Text = "-"
			Me.MnuClosed2Curve.Text = "M" & ChrW(7903) & " " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng kép kín"
			Me.MnuCurve2Closedprev = New MenuItem()
			Me.MnuCurve2Closed = New MenuItem()
			Me.MnuParts.MenuItems.Add(Me.MnuCurve2Closedprev)
			Me.MnuParts.MenuItems.Add(Me.MnuCurve2Closed)
			Me.MnuCurve2Closedprev.Text = "-"
			Me.MnuCurve2Closed.Text = "Kép kín " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng m" & ChrW(7903)
		End Sub

		Public Sub New(pMap As AxMap, pForm As Form, pPanel As Panel)
			CBanDo.__ENCList.Add(New WeakReference(Me))
			Me.iUndo = -1
			Me.iRedo = -1
			Me.myMapScreenWidth = 677F
			Me.m_KHfromVeKH = Nothing
			Me.m_DrawingSymbols = New CSymbols()
			Me.m_SelectedSymbols = New CSymbols()
			Me.m_CopySymbols = New CSymbols()
			Me.m_drawingObjects = New CGraphicObjs()
			Me.m_selectedObjects = New CGraphicObjs()
			Me.NodeDragging = False
			Me.RootDragging = False
			Me.selectionDragging = False
			Me.DrawingDragging = False
			Me.DrawingPicking = False
			Me.bSnap = False
			Me.bGrid = False
			Me.myGridWidth = 8
			Me.myWidth = 200
			Me.myHeight = 160
			Me.GridSize = New Size(Me.myGridWidth, Me.myGridWidth)
			Me.GridRect = New System.Drawing.Rectangle(0, 0, Me.myWidth, Me.myHeight)
			Me.myDistanceUnit = 7
			Me.strDistanceUnit = "m"
			Me.myDoCao = 0F
			Me.m_ParentForm = CType(pForm, frmMain)
			Me.m_Map = pMap
			Me.m_Panel = pPanel
			Me.InitializeComponent()
			Me.m_Map.GeoSet = myModule.myMapGst
			Me.m_Map.Title.Visible = False
			Me.m_Map.MapUnit = CType(Me.myDistanceUnit, MapUnitConstants)
			Dim mydcs As CoordSys = Me.m_Map.DisplayCoordSys
			Me.m_Map.NumericCoordSys = mydcs
			Me.m_Map.InfotipSupport = False
			Me.m_Map.NumericCoordSys.[Set](CType(myModule.myCoordSysType, CoordSysTypeConstants), mydcs.Datum, Me.m_Map.NumericCoordSys.Units, Me.m_Map.NumericCoordSys.OriginLongitude, Me.m_Map.NumericCoordSys.OriginLatitude, Me.m_Map.NumericCoordSys.StandardParallelOne, Me.m_Map.NumericCoordSys.StandardParallelTwo, Me.m_Map.NumericCoordSys.Azimuth, Me.m_Map.NumericCoordSys.ScaleFactor, Me.m_Map.NumericCoordSys.FalseEasting, Me.m_Map.NumericCoordSys.FalseNorthing, Me.m_Map.NumericCoordSys.Range, Missing.Value, Missing.Value)
			Me.m_Map.PaperUnit = PaperUnitConstants.miPaperUnitMeter
			Me.m_Map.Layers.AddUserDrawLayer("LopVeKyHieu", 1S)
			Me.CreateMyToolTip()
			Me.myMapTool = CBanDo.MapTools.None
			Me.myZoom = Me.m_Map.Zoom
			Me.myCX = Me.m_Map.CenterX
			Me.myCY = Me.m_Map.CenterY
			Me.m_Map.CreateCustomTool(3S, ToolTypeConstants.miToolTypePoint, CursorConstants.miArrowQuestionCursor)
			Me.AddDataSets()
			Me.bBanDo2Loaded = False
			Me.XoaUndoStack()
		End Sub

		Public Sub New(pMap As AxMap, pForm As Form)
			CBanDo.__ENCList.Add(New WeakReference(Me))
			Me.iUndo = -1
			Me.iRedo = -1
			Me.myMapScreenWidth = 677F
			Me.m_KHfromVeKH = Nothing
			Me.m_DrawingSymbols = New CSymbols()
			Me.m_SelectedSymbols = New CSymbols()
			Me.m_CopySymbols = New CSymbols()
			Me.m_drawingObjects = New CGraphicObjs()
			Me.m_selectedObjects = New CGraphicObjs()
			Me.NodeDragging = False
			Me.RootDragging = False
			Me.selectionDragging = False
			Me.DrawingDragging = False
			Me.DrawingPicking = False
			Me.bSnap = False
			Me.bGrid = False
			Me.myGridWidth = 8
			Me.myWidth = 200
			Me.myHeight = 160
			Me.GridSize = New Size(Me.myGridWidth, Me.myGridWidth)
			Me.GridRect = New System.Drawing.Rectangle(0, 0, Me.myWidth, Me.myHeight)
			Me.myDistanceUnit = 7
			Me.strDistanceUnit = "m"
			Me.myDoCao = 0F
			Me.m_ParentForm = CType(pForm, frmMain)
			Me.m_Map = pMap
			Me.m_Map.GeoSet = myModule.myMapGst
			Me.m_Map.Title.Visible = False
			Me.m_Map.MapUnit = CType(Me.myDistanceUnit, MapUnitConstants)
			Dim mydcs As CoordSys = Me.m_Map.DisplayCoordSys
			Me.m_Map.NumericCoordSys = mydcs
			Me.m_Map.InfotipSupport = False
			Me.m_Map.NumericCoordSys.[Set](CType(myModule.myCoordSysType, CoordSysTypeConstants), mydcs.Datum, Me.m_Map.NumericCoordSys.Units, Me.m_Map.NumericCoordSys.OriginLongitude, Me.m_Map.NumericCoordSys.OriginLatitude, Me.m_Map.NumericCoordSys.StandardParallelOne, Me.m_Map.NumericCoordSys.StandardParallelTwo, Me.m_Map.NumericCoordSys.Azimuth, Me.m_Map.NumericCoordSys.ScaleFactor, Me.m_Map.NumericCoordSys.FalseEasting, Me.m_Map.NumericCoordSys.FalseNorthing, Me.m_Map.NumericCoordSys.Range, Missing.Value, Missing.Value)
			Me.m_Map.PaperUnit = PaperUnitConstants.miPaperUnitMeter
			Me.m_Map.Layers.AddUserDrawLayer("LopVeKyHieu", 1S)
			Me.CreateMyToolTip()
			Me.myMapTool = CBanDo.MapTools.None
			Me.myZoom = Me.m_Map.Zoom
			Me.myCX = Me.m_Map.CenterX
			Me.myCY = Me.m_Map.CenterY
			Me.m_Map.CreateCustomTool(3S, ToolTypeConstants.miToolTypePoint, CursorConstants.miArrowQuestionCursor)
			Me.AddDataSets()
			Me.bBanDo2Loaded = False
		End Sub

		Private Sub CreateMyToolTip()
			Me.toolTip1 = New ToolTip()
			Me.toolTip1.AutoPopDelay = 5000
			Me.toolTip1.InitialDelay = 500
			Me.toolTip1.ReshowDelay = 100
			Me.toolTip1.ShowAlways = True
			Me.toolTip1.Active = False
			Me.toolTip1.SetToolTip(Me.m_Map, "My Ban do")
		End Sub

		Private Sub UpdateTB(index As Integer)
		End Sub

		Private Sub UpdateTB(pTag As String)
		End Sub

		Public Sub OnNodesEdit()
			Dim flag As Boolean = Me.m_SelectedSymbol IsNot Nothing
			If flag Then
				Me.iEditNode = -1
				Me.myMapTool = CBanDo.MapTools.NodesEdit
				Me.m_Map.CenterX = Me.m_Map.CenterX
			Else
				Interaction.MsgBox("ko co selEditsymbol", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Public Sub OnChangeRoot()
			Dim flag As Boolean = Me.m_SelectedSymbol IsNot Nothing
			If flag Then
				Me.PopUndo()
				Me.myMapTool = CBanDo.MapTools.ChangeRoot
				Me.m_Map.CenterX = Me.m_Map.CenterX
			Else
				Interaction.MsgBox("ko co selesymbol", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Public Sub OnDoKhoangCach()
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CBanDo.MapTools.Ruler
			Me.m_SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.strDistanceKQ = ""
			Me.myPts = New PointF(-1) {}
			Me.DrawingPicking = False
			Me.m_ParentForm.ToolStripStatusLabel3.Text = ChrW(272) & "o kho" & ChrW(7843) & "ng cách: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các V" & ChrW(7883) & " trí, RightClick " & ChrW(273) & ChrW(7875) & " xem K" & ChrW(7871) & "t qu" & ChrW(7843) & "."
		End Sub

		Public Sub OnGetTarget(ptxtKQ As TextBox, pDoCao As Single)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CBanDo.MapTools.GetTarget
			Me.m_SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.myDoCao = pDoCao
			Me.txtKQ = ptxtKQ
			Me.myPts = New PointF(-1) {}
			Me.DrawingPicking = False
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Lay V" & ChrW(7883) & " trí: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các V" & ChrW(7883) & " trí, RightClick " & ChrW(273) & ChrW(7875) & " xem K" & ChrW(7871) & "t qu" & ChrW(7843) & "."
		End Sub

		Private Sub GetTargets()
			' The following expression was wrapped in a checked-expression
			Dim m_OWidth As Double = modBanDo.mySurf2X * 1000.0 / CDec((modBanDo.myGRID_WIDTH - 1)) / 1000.0
			' The following expression was wrapped in a checked-expression
			Dim m_OHeight As Double = modBanDo.mySurf2Y * 1000.0 / CDec((modBanDo.myGRID_HEIGHT - 1)) / 1000.0
			Dim flag As Boolean = Me.myPts.GetUpperBound(0) <= 1
			If flag Then
				Dim arg_73_0 As Integer = 0
				Dim upperBound As Integer = Me.myPts.GetUpperBound(0)
				Dim i As Integer = arg_73_0
				While True
					Dim arg_1B7_0 As Integer = i
					Dim num As Integer = upperBound
					If arg_1B7_0 > num Then
						Exit While
					End If
					Dim arg_B6_0 As AxMap = Me.m_Map
					Dim arg_8A_0 As PointF() = Me.myPts
					Dim num2 As Integer = i
					Dim num3 As Single = arg_8A_0(num2).X
					Dim arg_A3_0 As PointF() = Me.myPts
					Dim num4 As Integer = i
					Dim num5 As Single = arg_A3_0(num4).Y
					Dim mLon As Double
					Dim mLat As Double
					arg_B6_0.ConvertCoord(num3, num5, mLon, mLat, ConversionConstants.miScreenToMap)
					Me.myPts(num4).Y = num5
					Me.myPts(num2).X = num3
					Dim mSurfPos As PointF = modBanDo.GetSurfPosition(mLon, mLat)
					Dim mSX As Single = CSng((CDec(mSurfPos.X) / m_OWidth))
					' The following expression was wrapped in a checked-expression
					Dim mSY As Single = CSng((CDec((modBanDo.myGRID_HEIGHT - 1)) - CDec(mSurfPos.Y) / m_OHeight))
					Dim textBox As TextBox = Me.txtKQ
					' The following expression was wrapped in a checked-statement
					textBox.Text = String.Concat(New String() { textBox.Text, "<Target X=""", mSX.ToString(), """ Y=""", mSY.ToString(), """ Z=""", Me.myDoCao.ToString(), """>", (i + 1).ToString(), "</Target>" & vbCrLf })
					i += 1
				End While
			Else
				Dim mPath As GraphicsPath = New GraphicsPath()
				mPath.AddCurve(Me.myPts)
				mPath.Flatten(New Matrix(), 0.25F)
				Dim mPts As PointF() = mPath.PathPoints
				Dim arg_1FD_0 As Integer = 0
				Dim upperBound2 As Integer = mPts.GetUpperBound(0)
				Dim i As Integer = arg_1FD_0
				While True
					Dim arg_331_0 As Integer = i
					Dim num As Integer = upperBound2
					If arg_331_0 > num Then
						Exit While
					End If
					Dim arg_238_0 As AxMap = Me.m_Map
					Dim arg_210_0 As PointF() = mPts
					Dim num4 As Integer = i
					Dim num5 As Single = arg_210_0(num4).X
					Dim arg_225_0 As PointF() = mPts
					Dim num2 As Integer = i
					Dim num3 As Single = arg_225_0(num2).Y
					Dim mLon As Double
					Dim mLat As Double
					arg_238_0.ConvertCoord(num5, num3, mLon, mLat, ConversionConstants.miScreenToMap)
					mPts(num2).Y = num3
					mPts(num4).X = num5
					Dim mSurfPos As PointF = modBanDo.GetSurfPosition(mLon, mLat)
					Dim mSX As Single = CSng((CDec(mSurfPos.X) / m_OWidth))
					' The following expression was wrapped in a checked-expression
					Dim mSY As Single = CSng((CDec((modBanDo.myGRID_HEIGHT - 1)) - CDec(mSurfPos.Y) / m_OHeight))
					Dim textBox As TextBox = Me.txtKQ
					' The following expression was wrapped in a checked-statement
					textBox.Text = String.Concat(New String() { textBox.Text, "<Target X=""", mSX.ToString(), """ Y=""", mSY.ToString(), """ Z=""", Me.myDoCao.ToString(), """>", (i + 1).ToString(), "</Target>" & vbCrLf })
					i += 1
				End While
			End If
		End Sub

		Private Sub GetTargets1()
			' The following expression was wrapped in a checked-expression
			Dim m_OWidth As Double = modBanDo.mySurf2X * 1000.0 / CDec((modBanDo.myGRID_WIDTH - 1)) / 1000.0
			' The following expression was wrapped in a checked-expression
			Dim m_OHeight As Double = modBanDo.mySurf2Y * 1000.0 / CDec((modBanDo.myGRID_HEIGHT - 1)) / 1000.0
			Dim arg_58_0 As Integer = 0
			Dim upperBound As Integer = Me.myPts.GetUpperBound(0)
			Dim i As Integer = arg_58_0
			While True
				Dim arg_19C_0 As Integer = i
				Dim num As Integer = upperBound
				If arg_19C_0 > num Then
					Exit While
				End If
				Dim arg_9B_0 As AxMap = Me.m_Map
				Dim arg_6F_0 As PointF() = Me.myPts
				Dim num2 As Integer = i
				Dim x As Single = arg_6F_0(num2).X
				Dim arg_88_0 As PointF() = Me.myPts
				Dim num3 As Integer = i
				Dim y As Single = arg_88_0(num3).Y
				Dim mLon As Double
				Dim mLat As Double
				arg_9B_0.ConvertCoord(x, y, mLon, mLat, ConversionConstants.miScreenToMap)
				Me.myPts(num3).Y = y
				Me.myPts(num2).X = x
				Dim mSurfPos As PointF = modBanDo.GetSurfPosition(mLon, mLat)
				Dim mSX As Single = CSng((CDec(mSurfPos.X) / m_OWidth))
				' The following expression was wrapped in a checked-expression
				Dim mSY As Single = CSng((CDec((modBanDo.myGRID_HEIGHT - 1)) - CDec(mSurfPos.Y) / m_OHeight))
				Dim textBox As TextBox = Me.txtKQ
				' The following expression was wrapped in a checked-statement
				textBox.Text = String.Concat(New String() { textBox.Text, "<Target X=""", mSX.ToString(), """ Y=""", mSY.ToString(), """ Z=""", Me.myDoCao.ToString(), """>", (i + 1).ToString(), "</Target>" & vbCrLf })
				i += 1
			End While
		End Sub

		Public Sub OnGetObjName(ptxtKQ As TextBox, ptxtObjType As TextBox)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CBanDo.MapTools.GetObjName
			Me.m_SelectedSymbol = Nothing
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.txtKQ = ptxtKQ
			Me.txtObjType = ptxtObjType
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Lay Ten DT: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n DT."
		End Sub

		Private Sub GetObjName(pSymbol As CSymbol)
			Me.m_ParentForm.lstCacKyHieu.SelectedIndex = Me.m_ParentForm.lstCacKyHieu.Items.IndexOf(pSymbol)
			Me.m_ParentForm.ChangeDesc(pSymbol, CType(Me.txtKQ.Parent, Form))
			Me.txtKQ.Text = pSymbol.Description
			Me.txtObjType.Text = Me.m_ParentForm.GetSymbolType(pSymbol)
			Me.m_ParentForm.ToolStripStatusLabel3.Text = ""
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CBanDo.MapTools.None
		End Sub

		Public Sub OnXoa()
			Dim flag As Boolean = Me.m_SelectedSymbol IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.PopUndo()
				Dim mIndex As Integer = Me.m_DrawingSymbols.get_IndexOf(Me.m_SelectedSymbol)
				Me.m_DrawingSymbols.Remove(Me.m_SelectedSymbol)
				flag = (mIndex >= Me.m_DrawingSymbols.ListCount)
				If flag Then
					mIndex -= 1
				End If
				flag = (mIndex >= 0)
				If flag Then
					Me.m_SelectedSymbol = Me.m_DrawingSymbols(mIndex)
				Else
					Me.m_SelectedSymbol = Nothing
				End If
				Me.m_Map.CenterX = Me.m_Map.CenterX
				Me.m_ParentForm.PopulateListKH(Me.m_SelectedSymbol)
			End If
		End Sub

		Public Function String2KHs(pstrKyHieu As String) As CSymbols
			Dim nt As NameTable = New NameTable()
			Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(nt)
			nsmgr.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, nsmgr, Nothing, XmlSpace.None)
			Dim rr As XmlTextReader = New XmlTextReader(pstrKyHieu, XmlNodeType.Element, context)
			Dim mKyHieus As CSymbols = Me.XML2Symbols(rr)
			rr.Close()
			Return mKyHieus
		End Function

		Public Sub KHsFromString(strKyHieus As String)
			Me.KHsFromString0(strKyHieus)
			Me.XoaUndoStack()
		End Sub

		Public Sub KHsFromString1(strKyHieus As String)
			Me.KHsFromString0(strKyHieus)
		End Sub

		Private Sub KHsFromString0(strKyHieus As String)
			Dim nt As NameTable = New NameTable()
			Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(nt)
			nsmgr.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, nsmgr, Nothing, XmlSpace.None)
			Dim rr As XmlTextReader = New XmlTextReader(strKyHieus, XmlNodeType.Element, context)
			Dim mKyHieus As CSymbols = Me.XML2Symbols(rr)
			rr.Close()
			Dim drawingSymbols As CSymbols = Me.m_DrawingSymbols
			SyncLock drawingSymbols
				Me.m_DrawingSymbols.Clear()
				Try
					Dim enumerator As IEnumerator = mKyHieus.GetEnumerator()
					While enumerator.MoveNext()
						Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
						Dim flag As Boolean = mSymbol.Zoom <> CDec(modBanDo.myKHQSZoom) Or mSymbol.MWidth <> CSng(modBanDo.myKHQSMWidth)
						If flag Then
							mSymbol.ChangeZoomMWidtht(CDec(modBanDo.myKHQSZoom), CSng(modBanDo.myKHQSMWidth))
						End If
						Me.m_DrawingSymbols.Add(mSymbol)
					End While
				Finally
					Dim enumerator As IEnumerator
					Dim flag As Boolean = TypeOf enumerator Is IDisposable
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
			End SyncLock
		End Sub

		Public Sub AppendKHsFromString(strKyHieus As String)
			Dim nt As NameTable = New NameTable()
			Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(nt)
			nsmgr.AddNamespace("bk", "urn:sample")
			Dim context As XmlParserContext = New XmlParserContext(Nothing, nsmgr, Nothing, XmlSpace.None)
			Dim rr As XmlTextReader = New XmlTextReader(strKyHieus, XmlNodeType.Element, context)
			Dim mKyHieus As CSymbols = Me.XML2Symbols(rr)
			rr.Close()
			Dim drawingSymbols As CSymbols = Me.m_DrawingSymbols
			SyncLock drawingSymbols
				Try
					Dim enumerator As IEnumerator = mKyHieus.GetEnumerator()
					While enumerator.MoveNext()
						Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
						Me.m_DrawingSymbols.Add(mSymbol)
					End While
				Finally
					Dim enumerator As IEnumerator
					Dim flag As Boolean = TypeOf enumerator Is IDisposable
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
			End SyncLock
		End Sub

		Public Function File2KHs(pFileName As String) As CSymbols
			Dim rr As XmlTextReader = New XmlTextReader(pFileName)
			Dim mKyHieus As CSymbols = Me.XML2Symbols(rr)
			rr.Close()
			Return mKyHieus
		End Function

		Public Sub LoadKHs(pFileName As String)
			Dim rr As XmlTextReader = New XmlTextReader(pFileName)
			Dim mKyHieus As CSymbols = Me.XML2Symbols(rr)
			rr.Close()
			Try
				Dim enumerator As IEnumerator = mKyHieus.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Me.m_DrawingSymbols.Add(mSymbol)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Function GetDouble(str1 As String) As Double
			Dim strDouble As String = str1.Replace(modBanDo.cGrpSepa, modBanDo.cDecSepa)
			Return Conversions.ToDouble(strDouble)
		End Function

		Private Function GetSingle(str1 As String) As Single
			Dim strDouble As String = str1.Replace(modBanDo.cGrpSepa, modBanDo.cDecSepa)
			Return Conversions.ToSingle(strDouble)
		End Function

		Private Function XML2Symbols(rr As XmlTextReader) As CSymbols
			Dim mKyHieus As CSymbols = New CSymbols()
			Dim mMapParts As CGraphicObjs = New CGraphicObjs()
			Dim mBlinking As Boolean = False
			Dim mNodes As CNODES = New CNODES()
			Dim mIsArc As Boolean = False
			Dim strTYPE As String = "bmp"
			Dim mIMAGEW As Integer = 0
			Dim mIMAGEH As Integer = 0
			Dim strIMAGE As String = ""
			Dim mCells As CCells = New CCells()
			' The following expression was wrapped in a checked-statement
			Try
				While rr.Read()
					Dim oNodeType As XmlNodeType = rr.NodeType
					Dim xmlNodeType As XmlNodeType = oNodeType
					Dim flag As Boolean = xmlNodeType = XmlNodeType.Element
					If flag Then
						Dim name As String = rr.Name
						Dim flag2 As Boolean = Operators.CompareString(name, "KyHieus", False) = 0
						If flag2 Then
							Dim flag3 As Boolean = rr.AttributeCount > 0
							If flag3 Then
								While rr.MoveToNextAttribute()
									Dim name2 As String = rr.Name
									Dim flag4 As Boolean = Operators.CompareString(name2, "CX", False) = 0
									If Not flag4 Then
										flag4 = (Operators.CompareString(name2, "CY", False) = 0)
										If Not flag4 Then
											flag4 = (Operators.CompareString(name2, "Zoom", False) = 0)
											If flag4 Then
											End If
										End If
									End If
								End While
							End If
						Else
							Dim flag4 As Boolean = Operators.CompareString(name, "KyHieu", False) = 0
							If flag4 Then
								mMapParts.Clear()
								Dim mMWidth As Single = 0F
								Dim mDesc As String = ""
								mBlinking = False
								flag4 = (rr.AttributeCount > 0)
								If flag4 Then
									While rr.MoveToNextAttribute()
										Dim name3 As String = rr.Name
										Dim flag3 As Boolean = Operators.CompareString(name3, "Desc", False) = 0
										If flag3 Then
											mDesc = rr.Value
										Else
											flag4 = (Operators.CompareString(name3, "Blink", False) = 0)
											If flag4 Then
												mBlinking = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
											Else
												flag4 = (Operators.CompareString(name3, "Zoom", False) = 0)
												If flag4 Then
													Dim mMapZoom As Long = Conversions.ToLong(rr.Value)
												Else
													flag4 = (Operators.CompareString(name3, "MWi", False) = 0)
													If flag4 Then
														mMWidth = Me.GetSingle(rr.Value)
													Else
														flag4 = (Operators.CompareString(name3, "GocX", False) = 0)
														If flag4 Then
															Dim mGocX As Double = Me.GetDouble(rr.Value)
														Else
															flag4 = (Operators.CompareString(name3, "GocY", False) = 0)
															If flag4 Then
																Dim mGocY As Double = Me.GetDouble(rr.Value)
															End If
														End If
													End If
												End If
											End If
										End If
									End While
								End If
							Else
								flag4 = (Operators.CompareString(name, "Part", False) = 0)
								If flag4 Then
									mNodes.Clear()
									mCells.Clear()
									Dim mPartType As OBJECTTYPE = OBJECTTYPE.Line
									Dim mColor As Color = Color.Black
									Dim mWidth As Integer = 1
									Dim mLineStyle As Integer = 0
									Dim mStyleWidth As Single = 0F
									Dim mColor2 As Color = Color.Black
									Dim mWidth2 As Integer = 0
									Dim mDValues As String = ""
									Dim mFill As Boolean = False
									Dim mFillColor As Color = Color.Black
									Dim mHColor As Color = Color.Black
									Dim mHStyle As Integer = 0
									Dim mW As Single = 10F
									Dim mH As Single = 10F
									Dim mA As Single = 0F
									Dim mST As Single = 0F
									Dim mSW As Single = 90F
									mIsArc = False
									Dim mText As String = "text"
									Dim mFName As String = "Tahoma"
									Dim mFSize As Integer = 10
									Dim mFStyle As String = "Regular"
									Dim mFColor As Color = Color.Black
									strTYPE = "bmp"
									mIMAGEW = 0
									mIMAGEH = 0
									strIMAGE = ""
									Dim mCols As Integer = 2
									Dim mRows As Integer = 2
									Dim mBColor As Color = Color.Blue
									Dim mBWidth As Integer = 1
									Dim mLColor As Color = Color.Gray
									Dim mLWidth As Integer = 1
									Dim mFiColor As Color = Color.Blue
									Dim mAWS As String = ""
									Dim mAHS As String = ""
									flag4 = (rr.AttributeCount > 0)
									If flag4 Then
										While rr.MoveToNextAttribute()
											Dim name4 As String = rr.Name
											Dim flag3 As Boolean = Operators.CompareString(name4, "Type", False) = 0
											If flag3 Then
												mPartType = CGraphicObjs.toObjectType(rr.Value)
											Else
												flag4 = (Operators.CompareString(name4, "Color", False) = 0)
												If flag4 Then
													mColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
												Else
													flag4 = (Operators.CompareString(name4, "Width", False) = 0)
													If flag4 Then
														mWidth = Conversions.ToInteger(rr.Value)
													Else
														flag4 = (Operators.CompareString(name4, "Style", False) = 0)
														If flag4 Then
															mLineStyle = Conversions.ToInteger(rr.Value)
														Else
															flag4 = (Operators.CompareString(name4, "SWidth", False) = 0)
															If flag4 Then
																mStyleWidth = Me.GetSingle(rr.Value)
															Else
																flag4 = (Operators.CompareString(name4, "Color2", False) = 0)
																If flag4 Then
																	mColor2 = Color.FromArgb(Conversions.ToInteger(rr.Value))
																Else
																	flag4 = (Operators.CompareString(name4, "Width2", False) = 0)
																	If flag4 Then
																		mWidth2 = Conversions.ToInteger(rr.Value)
																	Else
																		flag4 = (Operators.CompareString(name4, "DV", False) = 0)
																		If flag4 Then
																			mDValues = rr.Value.ToString()
																		Else
																			flag4 = (Operators.CompareString(name4, "Fill", False) = 0)
																			If flag4 Then
																				mFill = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "False", False) = 0, False, True))
																			Else
																				flag4 = (Operators.CompareString(name4, "FColor", False) = 0)
																				If flag4 Then
																					mFillColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
																				Else
																					flag4 = (Operators.CompareString(name4, "HColor", False) = 0)
																					If flag4 Then
																						mHColor = Color.FromArgb(Conversions.ToInteger(rr.Value))
																					Else
																						flag4 = (Operators.CompareString(name4, "HStyle", False) = 0)
																						If flag4 Then
																							mHStyle = Conversions.ToInteger(rr.Value)
																						Else
																							flag4 = (Operators.CompareString(name4, "FName", False) = 0)
																							If flag4 Then
																								mFName = rr.Value
																							Else
																								flag4 = (Operators.CompareString(name4, "FSize", False) = 0)
																								If flag4 Then
																									mFSize = Conversions.ToInteger(rr.Value)
																								Else
																									flag4 = (Operators.CompareString(name4, "FStyle", False) = 0)
																									If flag4 Then
																										mFStyle = rr.Value
																									Else
																										flag4 = (Operators.CompareString(name4, "Text", False) = 0)
																										If flag4 Then
																											mText = rr.Value
																										Else
																											flag4 = (Operators.CompareString(name4, "ITYPE", False) = 0)
																											If flag4 Then
																												strTYPE = rr.Value
																											Else
																												flag4 = (Operators.CompareString(name4, "IMAGEW", False) = 0)
																												If flag4 Then
																													mIMAGEW = Conversions.ToInteger(Conversion.Int(rr.Value))
																												Else
																													flag4 = (Operators.CompareString(name4, "IMAGEH", False) = 0)
																													If flag4 Then
																														mIMAGEH = Conversions.ToInteger(Conversion.Int(rr.Value))
																													Else
																														flag4 = (Operators.CompareString(name4, "IMAGE", False) = 0)
																														If flag4 Then
																															strIMAGE = rr.Value
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
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End While
									End If
								Else
									flag4 = (Operators.CompareString(name, "Node", False) = 0)
									If flag4 Then
										Dim flag3 As Boolean = rr.AttributeCount > 0
										If flag3 Then
											Dim mbControl As Boolean = False
											While rr.MoveToNextAttribute()
												Dim name5 As String = rr.Name
												flag4 = (Operators.CompareString(name5, "X", False) = 0)
												If flag4 Then
													Dim mPtX As Single = Me.GetSingle(rr.Value)
												Else
													flag4 = (Operators.CompareString(name5, "Y", False) = 0)
													If flag4 Then
														Dim mPtY As Single = Me.GetSingle(rr.Value)
													Else
														flag4 = (Operators.CompareString(name5, "Type", False) = 0)
														If flag4 Then
															mbControl = Conversions.ToBoolean(rr.Value)
														End If
													End If
												End If
											End While
										End If
									Else
										flag4 = (Operators.CompareString(name, "Cell", False) = 0)
										If flag4 Then
											Dim flag3 As Boolean = rr.AttributeCount > 0
											If flag3 Then
												Dim miC As Integer = 0
												Dim miR As Integer = 0
												Dim mCNo As Integer = 1
												Dim mRNo As Integer = 1
												Dim mCText As String = ""
												While rr.MoveToNextAttribute()
													Dim name6 As String = rr.Name
													flag4 = (Operators.CompareString(name6, "iR", False) = 0)
													If flag4 Then
														miR = Conversions.ToInteger(rr.Value)
													Else
														flag4 = (Operators.CompareString(name6, "iC", False) = 0)
														If flag4 Then
															miC = Conversions.ToInteger(rr.Value)
														Else
															flag4 = (Operators.CompareString(name6, "RNo", False) = 0)
															If flag4 Then
																mRNo = Conversions.ToInteger(rr.Value)
															Else
																flag4 = (Operators.CompareString(name6, "CNo", False) = 0)
																If flag4 Then
																	mCNo = Conversions.ToInteger(rr.Value)
																Else
																	flag4 = (Operators.CompareString(name6, "Text", False) = 0)
																	If flag4 Then
																		mCText = rr.Value
																	Else
																		flag4 = (Operators.CompareString(name6, "FName", False) = 0)
																		If flag4 Then
																			Dim mFName As String = rr.Value
																		Else
																			flag4 = (Operators.CompareString(name6, "FSize", False) = 0)
																			If flag4 Then
																				Dim mFSize As Integer = Conversions.ToInteger(rr.Value)
																			Else
																				flag4 = (Operators.CompareString(name6, "FStyle", False) = 0)
																				If flag4 Then
																					Dim mFStyle As String = rr.Value
																				Else
																					flag4 = (Operators.CompareString(name6, "Color", False) = 0)
																					If flag4 Then
																						Dim mFColor As Color = Color.FromArgb(Conversions.ToInteger(rr.Value))
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End While
											End If
										Else
											flag4 = (Operators.CompareString(name, "Rect", False) = 0)
											If flag4 Then
												Dim flag3 As Boolean = rr.AttributeCount > 0
												If flag3 Then
													While rr.MoveToNextAttribute()
														Dim name7 As String = rr.Name
														flag2 = (Operators.CompareString(name7, "X", False) = 0)
														If flag2 Then
															Dim mPtX As Single = Me.GetSingle(rr.Value)
														Else
															flag4 = (Operators.CompareString(name7, "Y", False) = 0)
															If flag4 Then
																Dim mPtY As Single = Me.GetSingle(rr.Value)
															Else
																flag4 = (Operators.CompareString(name7, "W", False) = 0)
																If flag4 Then
																	Dim mW As Single = Me.GetSingle(rr.Value)
																Else
																	flag4 = (Operators.CompareString(name7, "H", False) = 0)
																	If flag4 Then
																		Dim mH As Single = Me.GetSingle(rr.Value)
																	Else
																		flag4 = (Operators.CompareString(name7, "A", False) = 0)
																		If flag4 Then
																			Dim mA As Single = Me.GetSingle(rr.Value)
																		End If
																	End If
																End If
															End If
														End If
													End While
												End If
											Else
												flag4 = (Operators.CompareString(name, "Pie", False) = 0)
												If flag4 Then
													Dim flag3 As Boolean = rr.AttributeCount > 0
													If flag3 Then
														While rr.MoveToNextAttribute()
															Dim name8 As String = rr.Name
															flag2 = (Operators.CompareString(name8, "X", False) = 0)
															If flag2 Then
																Dim mPtX As Single = Me.GetSingle(rr.Value)
															Else
																flag4 = (Operators.CompareString(name8, "Y", False) = 0)
																If flag4 Then
																	Dim mPtY As Single = Me.GetSingle(rr.Value)
																Else
																	flag4 = (Operators.CompareString(name8, "W", False) = 0)
																	If flag4 Then
																		Dim mW As Single = Me.GetSingle(rr.Value)
																	Else
																		flag4 = (Operators.CompareString(name8, "H", False) = 0)
																		If flag4 Then
																			Dim mH As Single = Me.GetSingle(rr.Value)
																		Else
																			flag4 = (Operators.CompareString(name8, "ST", False) = 0)
																			If flag4 Then
																				Dim mST As Single = Me.GetSingle(rr.Value)
																			Else
																				flag4 = (Operators.CompareString(name8, "SW", False) = 0)
																				If flag4 Then
																					Dim mSW As Single = Me.GetSingle(rr.Value)
																				Else
																					flag4 = (Operators.CompareString(name8, "ARC", False) = 0)
																					If flag4 Then
																						mIsArc = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "False", False) = 0, False, True))
																					Else
																						flag4 = (Operators.CompareString(name8, "A", False) = 0)
																						If flag4 Then
																							Dim mA As Single = Me.GetSingle(rr.Value)
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End While
													End If
												Else
													flag4 = (Operators.CompareString(name, "Pos", False) = 0)
													If flag4 Then
														Dim flag3 As Boolean = rr.AttributeCount > 0
														If flag3 Then
															While rr.MoveToNextAttribute()
																Dim name9 As String = rr.Name
																flag2 = (Operators.CompareString(name9, "X", False) = 0)
																If flag2 Then
																	Dim mPtX As Single = Me.GetSingle(rr.Value)
																Else
																	flag4 = (Operators.CompareString(name9, "Y", False) = 0)
																	If flag4 Then
																		Dim mPtY As Single = Me.GetSingle(rr.Value)
																	Else
																		flag4 = (Operators.CompareString(name9, "A", False) = 0)
																		If flag4 Then
																			Dim mA As Single = Me.GetSingle(rr.Value)
																		End If
																	End If
																End If
															End While
														End If
													Else
														flag4 = (Operators.CompareString(name, "TBL", False) = 0)
														If flag4 Then
															Dim flag3 As Boolean = rr.AttributeCount > 0
															If flag3 Then
																While rr.MoveToNextAttribute()
																	Dim name10 As String = rr.Name
																	flag2 = (Operators.CompareString(name10, "FiColor", False) = 0)
																	If flag2 Then
																		Dim mFiColor As Color = Color.FromArgb(Conversions.ToInteger(rr.Value))
																	Else
																		flag4 = (Operators.CompareString(name10, "X", False) = 0)
																		If flag4 Then
																			Dim mPtX As Single = Me.GetSingle(rr.Value)
																		Else
																			flag4 = (Operators.CompareString(name10, "Y", False) = 0)
																			If flag4 Then
																				Dim mPtY As Single = Me.GetSingle(rr.Value)
																			Else
																				flag4 = (Operators.CompareString(name10, "W", False) = 0)
																				If flag4 Then
																					Dim mW As Single = Me.GetSingle(rr.Value)
																				Else
																					flag4 = (Operators.CompareString(name10, "H", False) = 0)
																					If flag4 Then
																						Dim mH As Single = Me.GetSingle(rr.Value)
																					Else
																						flag4 = (Operators.CompareString(name10, "A", False) = 0)
																						If flag4 Then
																							Dim mA As Single = Me.GetSingle(rr.Value)
																						Else
																							flag4 = (Operators.CompareString(name10, "Cols", False) = 0)
																							If flag4 Then
																								Dim mCols As Integer = Conversions.ToInteger(rr.Value)
																							Else
																								flag4 = (Operators.CompareString(name10, "Rows", False) = 0)
																								If flag4 Then
																									Dim mRows As Integer = Conversions.ToInteger(rr.Value)
																								Else
																									flag4 = (Operators.CompareString(name10, "BColor", False) = 0)
																									If flag4 Then
																										Dim mBColor As Color = Color.FromArgb(Conversions.ToInteger(rr.Value))
																									Else
																										flag4 = (Operators.CompareString(name10, "BWidth", False) = 0)
																										If flag4 Then
																											Dim mBWidth As Integer = Conversions.ToInteger(rr.Value)
																										Else
																											flag4 = (Operators.CompareString(name10, "LColor", False) = 0)
																											If flag4 Then
																												Dim mLColor As Color = Color.FromArgb(Conversions.ToInteger(rr.Value))
																											Else
																												flag4 = (Operators.CompareString(name10, "LWidth", False) = 0)
																												If flag4 Then
																													Dim mLWidth As Integer = Conversions.ToInteger(rr.Value)
																												Else
																													flag4 = (Operators.CompareString(name10, "AWS", False) = 0)
																													If flag4 Then
																														Dim mAWS As String = rr.Value
																													Else
																														flag4 = (Operators.CompareString(name10, "AHS", False) = 0)
																														If flag4 Then
																															Dim mAHS As String = rr.Value
																														Else
																															flag4 = (Operators.CompareString(name10, "FiColor", False) = 0)
																															If flag4 Then
																																Dim mFiColor As Color = Color.FromArgb(Conversions.ToInteger(rr.Value))
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
																			End If
																		End If
																	End If
																End While
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
					Else
						Dim flag4 As Boolean = xmlNodeType = XmlNodeType.EndElement
						If flag4 Then
							Dim name11 As String = rr.Name
							Dim flag3 As Boolean = Operators.CompareString(name11, "Node", False) = 0
							If flag3 Then
								Dim arg_FD7_0 As CNODES = mNodes
								Dim mPtX As Single
								Dim mPtY As Single
								Dim pPt As PointF = New PointF(mPtX, mPtY)
								Dim mbControl As Boolean
								arg_FD7_0.Add(New CNODE(pPt, mbControl))
							Else
								flag4 = (Operators.CompareString(name11, "Cell", False) = 0)
								If flag4 Then
									Dim mFStyle As String
									Dim left As String = mFStyle
									flag3 = (Operators.CompareString(left, "Bold", False) = 0)
									Dim mFontStyle As FontStyle
									If flag3 Then
										mFontStyle = FontStyle.Bold
									Else
										flag4 = (Operators.CompareString(left, "Italic", False) = 0)
										If flag4 Then
											mFontStyle = FontStyle.Italic
										Else
											flag4 = (Operators.CompareString(left, "Regular", False) = 0)
											If flag4 Then
												mFontStyle = FontStyle.Regular
											Else
												flag4 = (Operators.CompareString(left, "Strikeout", False) = 0)
												If flag4 Then
													mFontStyle = FontStyle.Strikeout
												Else
													flag4 = (Operators.CompareString(left, "Underline", False) = 0)
													If flag4 Then
														mFontStyle = FontStyle.Underline
													Else
														flag4 = (Operators.CompareString(left, "Bold, Italic", False) = 0)
														If flag4 Then
															mFontStyle = (FontStyle.Bold Or FontStyle.Italic)
														End If
													End If
												End If
											End If
										End If
									End If
									Dim mFName As String
									Dim mFSize As Integer
									Dim mFont As Font = New Font(mFName, CSng(mFSize), mFontStyle, GraphicsUnit.Point)
									Dim mFColor As Color
									Dim miC As Integer
									Dim miR As Integer
									Dim mCNo As Integer
									Dim mRNo As Integer
									Dim mCText As String
									mCells.Add(New CCell(miR, miC, mRNo, mCNo, mCText, mFont, mFColor))
								Else
									flag4 = (Operators.CompareString(name11, "Part", False) = 0)
									If flag4 Then
										Dim mPartType As OBJECTTYPE
										Dim gObj As GraphicObject
										Select Case mPartType
											Case OBJECTTYPE.Polygon
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												gObj = New PolygonGraphic(mNodes, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle) With { .Rotation = 0F }
											Case OBJECTTYPE.Line
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												gObj = New LinesGraphic(mNodes, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle) With { .Rotation = 0F }
											Case OBJECTTYPE.Curve
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												gObj = New CurveGraphic(mNodes, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle) With { .Rotation = 0F }
											Case OBJECTTYPE.ClosedCurve
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												gObj = New ClosedCurveGraphic(mNodes, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle) With { .Rotation = 0F }
											Case OBJECTTYPE.Cycle
												' The following expression was wrapped in a unchecked-expression
												Dim dk As Integer = CInt(Math.Round(Math.Sqrt(CDec(((mNodes(1).X - mNodes(0).X) * (mNodes(1).X - mNodes(0).X) + (mNodes(1).Y - mNodes(0).Y) * (mNodes(1).Y - mNodes(0).Y))))))
												' The following expression was wrapped in a unchecked-expression
												Dim x As Integer = CInt(Math.Round(CDec((mNodes(0).X + mNodes(1).X - CSng(dk) / 2F))))
												' The following expression was wrapped in a unchecked-expression
												Dim y As Integer = CInt(Math.Round(CDec((mNodes(0).Y + mNodes(1).Y - CSng(dk) / 2F))))
												Dim mRect As RectangleF = New RectangleF(CSng(x), CSng(y), CSng(dk), CSng(dk))
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												Dim mRotation As Single
												Dim myEllipse As EllipseGraphic = New EllipseGraphic(mRect, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle, mRotation)
												gObj = myEllipse
											Case OBJECTTYPE.Ellipse
												Dim mW As Single
												Dim mH As Single
												Dim mPtX As Single
												Dim mPtY As Single
												Dim mDrawingRect As RectangleF = New RectangleF(mPtX, mPtY, mW, mH)
												Dim mA As Single
												Dim mRotation As Single = mA
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												Dim myEllipse2 As EllipseGraphic = New EllipseGraphic(mDrawingRect, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle, mRotation)
												gObj = myEllipse2
											Case OBJECTTYPE.Pie
												Dim mW As Single
												Dim mH As Single
												Dim mPtX As Single
												Dim mPtY As Single
												Dim mDrawingRect As RectangleF = New RectangleF(mPtX, mPtY, mW, mH)
												Dim mA As Single
												Dim mRotation As Single = mA
												Dim mColor As Color
												Dim mWidth As Integer
												Dim mLineStyle As Integer
												Dim mStyleWidth As Single
												Dim mColor2 As Color
												Dim mWidth2 As Integer
												Dim mDValues As String
												Dim mFill As Boolean
												Dim mFillColor As Color
												Dim mHColor As Color
												Dim mHStyle As Integer
												Dim mST As Single
												Dim mSW As Single
												gObj = New PieGraphic(mDrawingRect, CSng(mWidth), mColor, mLineStyle, mStyleWidth, CSng(mWidth2), mColor2, mDValues, mFill, mFillColor, mHColor, mHStyle, mRotation) With { .StartAngle = mST, .SweepAngle = mSW, .IsArc = mIsArc }
											Case OBJECTTYPE.Text
												Dim mFStyle As String
												Dim left2 As String = mFStyle
												flag4 = (Operators.CompareString(left2, "Bold", False) = 0)
												Dim mFontStyle2 As FontStyle
												If flag4 Then
													mFontStyle2 = FontStyle.Bold
												Else
													flag4 = (Operators.CompareString(left2, "Italic", False) = 0)
													If flag4 Then
														mFontStyle2 = FontStyle.Italic
													Else
														flag4 = (Operators.CompareString(left2, "Regular", False) = 0)
														If flag4 Then
															mFontStyle2 = FontStyle.Regular
														Else
															flag4 = (Operators.CompareString(left2, "Strikeout", False) = 0)
															If flag4 Then
																mFontStyle2 = FontStyle.Strikeout
															Else
																flag4 = (Operators.CompareString(left2, "Underline", False) = 0)
																If flag4 Then
																	mFontStyle2 = FontStyle.Underline
																Else
																	flag4 = (Operators.CompareString(left2, "Bold, Italic", False) = 0)
																	If flag4 Then
																		mFontStyle2 = (FontStyle.Bold Or FontStyle.Italic)
																	End If
																End If
															End If
														End If
													End If
												End If
												Dim mFName As String
												Dim mFSize As Integer
												Dim StringFont As Font = New Font(mFName, CSng(mFSize), mFontStyle2, GraphicsUnit.Point)
												Dim mFillColor As Color
												Dim mA As Single
												Dim mText As String
												Dim mPtX As Single
												Dim mPtY As Single
												Dim myText As TextGraphic = New TextGraphic(mPtX, mPtY, mText, StringFont, mFillColor, mA)
												gObj = myText
											Case OBJECTTYPE.Table
												Dim mAWS As String
												Dim strData As String() = mAWS.Split(New Char() { "|"c })
												Dim mCols As Integer
												Dim mAWidth As Integer() = New Integer(mCols - 1 + 1 - 1) {}
												Dim arg_157D_0 As Integer = 0
												Dim num As Integer = mCols - 1
												Dim i As Integer = arg_157D_0
												While True
													Dim arg_15C0_0 As Integer = i
													Dim num2 As Integer = num
													If arg_15C0_0 > num2 Then
														Exit While
													End If
													Try
														mAWidth(i) = CInt(Math.Round(Conversion.Val(strData(i))))
													Catch expr_1599 As Exception
														ProjectData.SetProjectError(expr_1599)
														mAWidth(i) = 80
														ProjectData.ClearProjectError()
													End Try
													i += 1
												End While
												Dim mAHS As String
												strData = mAHS.Split(New Char() { "|"c })
												Dim mRows As Integer
												Dim mAHeight As Integer() = New Integer(mRows - 1 + 1 - 1) {}
												Dim arg_15EE_0 As Integer = 0
												Dim num3 As Integer = mRows - 1
												Dim j As Integer = arg_15EE_0
												While True
													Dim arg_1631_0 As Integer = j
													Dim num2 As Integer = num3
													If arg_1631_0 > num2 Then
														Exit While
													End If
													Try
														mAHeight(j) = CInt(Math.Round(Conversion.Val(strData(j))))
													Catch expr_160A As Exception
														ProjectData.SetProjectError(expr_160A)
														mAHeight(j) = 20
														ProjectData.ClearProjectError()
													End Try
													j += 1
												End While
												Dim mA As Single
												Dim mBColor As Color
												Dim mBWidth As Integer
												Dim mLColor As Color
												Dim mLWidth As Integer
												Dim mFiColor As Color
												Dim mPtX As Single
												Dim mPtY As Single
												Dim myTable As TableGraphic = New TableGraphic(mPtX, mPtY, mCols, mRows, mAWidth, mAHeight, mCells, mBColor, mBWidth, mLColor, mLWidth, mFiColor, mA)
												gObj = myTable
											Case OBJECTTYPE.EmbeddedImage
												flag4 = (strIMAGE.Length > 0)
												If flag4 Then
													Dim arrImage As Byte() = Convert.FromBase64String(strIMAGE)
													Dim memStream As MemoryStream = New MemoryStream(arrImage)
													Dim mImage As Image = Image.FromStream(memStream)
													Dim mPtX As Single
													Dim mPtY As Single
													gObj = New EmbeddedImageGraphic(strTYPE, CInt(Math.Round(CDec(mPtX))), CInt(Math.Round(CDec(mPtY))), mImage) With { .Transparent = True, .TransparentColor = Color.White }
													Dim graphicObject As GraphicObject = gObj
													Dim mA As Single
													graphicObject.Rotation = mA
													graphicObject.AutoSize = False
													graphicObject.Width = CSng(mIMAGEW)
													graphicObject.Height = CSng(mIMAGEH)
												End If
										End Select
										flag4 = (gObj IsNot Nothing)
										If flag4 Then
											mMapParts.Add(gObj)
										End If
									Else
										flag4 = (Operators.CompareString(name11, "KyHieu", False) = 0)
										If flag4 Then
											Dim mMWidth As Single
											Dim mDesc As String
											Dim mMapZoom As Long
											Dim mGocX As Double
											Dim mGocY As Double
											Dim mKyHieu As CSymbol = New CSymbol(mDesc, mBlinking, CDec(mMapZoom), mMWidth, mGocX, mGocY, mMapParts)
											mKyHieus.Add(mKyHieu)
										End If
									End If
								End If
							End If
						End If
					End If
				End While
			Catch expr_16BD As Exception
				ProjectData.SetProjectError(expr_16BD)
				Interaction.MsgBox("Khong doc duoc XML Nay", MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			End Try
			Return mKyHieus
		End Function

		Private Sub OnChangeColor()
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
			flag = (f.ShowDialog(Me.m_ParentForm) = DialogResult.OK)
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
				Me.RefreshMap()
			End If
		End Sub

		Private Sub OnChangePie()
			Dim f As dlgChangePie = New dlgChangePie()
			Dim myObj As PieGraphic = CType(Me.m_SelectedObject, PieGraphic)
			f.nudStartAngle.Value = New Decimal(myObj.StartAngle)
			f.nudSweepAngle.Value = New Decimal(myObj.SweepAngle)
			f.chkArc.Checked = myObj.IsArc
			f.txtColor.BackColor = myObj.LineColor
			f.txtColor2.BackColor = myObj.Line2Color
			f.txtDashValues.Text = myObj.DValues
			f.nudPenWidth.Value = New Decimal(myObj.LineWidth)
			f.nudPenWidth2.Value = New Decimal(myObj.Line2Width)
			f.chkBrush.Checked = myObj.Fill
			Dim flag As Boolean = f.chkBrush.Checked
			If flag Then
				f.txtBrushColor.BackColor = Color.FromArgb(255, CInt(myObj.FillColor.R), CInt(myObj.FillColor.G), CInt(myObj.FillColor.B))
				f.nudAlpha.Value = New Decimal(CInt(myObj.FillColor.A))
				f.txtHatchColor.BackColor = Color.FromArgb(255, CInt(myObj.HatchColor.R), CInt(myObj.HatchColor.G), CInt(myObj.HatchColor.B))
				f.txtHStyle.Text = Conversions.ToString(myObj.HatchStyle)
			End If
			flag = (f.ShowDialog(Me.m_ParentForm) = DialogResult.OK)
			If flag Then
				myObj.StartAngle = Convert.ToSingle(f.nudStartAngle.Value)
				myObj.SweepAngle = Convert.ToSingle(f.nudSweepAngle.Value)
				flag = f.chkArc.Checked
				If flag Then
					myObj.IsArc = True
				Else
					myObj.IsArc = False
				End If
				myObj.LineColor = f.txtColor.BackColor
				myObj.LineWidth = Convert.ToSingle(f.nudPenWidth.Value)
				myObj.Line2Color = f.txtColor2.BackColor
				myObj.Line2Width = Convert.ToSingle(f.nudPenWidth2.Value)
				myObj.DValues = f.txtDashValues.Text
				flag = f.chkBrush.Checked
				If flag Then
					myObj.Fill = True
					myObj.FillColor = Color.FromArgb(Convert.ToInt32(f.nudAlpha.Value), f.txtBrushColor.BackColor)
					myObj.HatchColor = f.txtHatchColor.BackColor
					' The following expression was wrapped in a checked-expression
					myObj.HatchStyle = CInt(Math.Round(Conversion.Val(f.txtHStyle.Text)))
				Else
					myObj.Fill = False
				End If
				Me.RefreshMap()
			End If
		End Sub

		Private Sub OnChangeTable()
			Dim f As Form = New dlgChangeTable()
			myModule.fCallForm = Me.m_ParentForm
			f.ShowDialog(Me.m_ParentForm)
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub OnChangeText()
			Dim f As dlgChangeLabel = New dlgChangeLabel()
			Dim myObj As TextGraphic = CType(Me.m_SelectedObject, TextGraphic)
			f.txtLabel.Text = myObj.Text
			f.txtLabel.Font = myObj.Font
			f.txtLabel.ForeColor = myObj.Color
			Dim flag As Boolean = f.ShowDialog(Me.m_ParentForm) = DialogResult.OK
			If flag Then
				myObj.Text = f.txtLabel.Text
				myObj.Font = f.txtLabel.Font
				myObj.Color = f.txtLabel.ForeColor
				Me.RefreshMap()
			End If
		End Sub

		Public Sub OnTimDiaDanh(sender As Object, e As EventArgs)
		End Sub

		Public Sub OnDeleteShape()
			Dim flag As Boolean = Me.FoundObject.FoundSymbol.GObjs.Count > 1
			If flag Then
				Me.FoundObject.FoundSymbol.GObjs.Remove(Me.FoundObject.FoundObject)
			Else
				Me.m_DrawingSymbols.Remove(Me.FoundObject.FoundSymbol)
			End If
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Public Sub OnAddNode()
			Dim flag As Boolean = Me.FoundNode IsNot Nothing
			If flag Then
				Me.FoundNode.FoundObject.InsertNode(Me.FoundNode.NodeIndex)
				Me.m_Map.CenterX = Me.m_Map.CenterX
			End If
		End Sub

		Public Sub OnXoaNode()
			Dim flag As Boolean = Me.FoundNode IsNot Nothing
			If flag Then
				Me.FoundNode.FoundObject.RemoveNode(Me.FoundNode.NodeIndex)
				Me.m_Map.CenterX = Me.m_Map.CenterX
			End If
		End Sub

		Public Sub OnChangeNodeType()
			Dim flag As Boolean = Me.FoundNode IsNot Nothing
			If flag Then
				Me.FoundNode.FoundObject.ChangeNodeType(Me.FoundNode.NodeIndex)
				Me.m_Map.CenterX = Me.m_Map.CenterX
			End If
		End Sub

		Public Sub OnChangeDesc(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_SelectedSymbol IsNot Nothing
			If flag Then
				Me.PopUndo()
				Me.m_ParentForm.ChangeDesc(Me.m_SelectedSymbol, Me.m_ParentForm)
				Me.m_SelectedSymbol = Nothing
			End If
		End Sub

		Public Sub NhapNhayKH(iKH As Integer, pLan As Integer)
			Dim seleBrush As HatchBrush = New HatchBrush(HatchStyle.DiagonalCross, Color.Red, Color.Transparent)
			Dim seleBrush2 As HatchBrush = New HatchBrush(HatchStyle.DiagonalCross, Color.White, Color.Transparent)
			Dim mPen As Pen = New Pen(Color.White, 4F)
			mPen.Brush = seleBrush
			Dim mPen2 As Pen = New Pen(Color.Black, 4F)
			mPen2.Brush = seleBrush2
			' The following expression was wrapped in a checked-statement
			Try
				Dim g As Graphics = Me.m_Map.CreateGraphics()
				For i As Integer = 0 To pLan
					Me.m_DrawingSymbols(iKH).DanhDau(Me.m_Map, g, mPen)
					Thread.Sleep(100)
					Application.DoEvents()
					Me.m_DrawingSymbols(iKH).DanhDau(Me.m_Map, g, mPen2)
					Thread.Sleep(100)
					Application.DoEvents()
				Next
			Catch arg_CE_0 As Exception
				ProjectData.SetProjectError(arg_CE_0)
				ProjectData.ClearProjectError()
			Finally
				seleBrush.Dispose()
				seleBrush2.Dispose()
				mPen.Dispose()
				mPen2.Dispose()
			End Try
			Me.m_Map.Refresh()
		End Sub

		Public Sub NhapNhaySymbol(pSymbol As CSymbol, pLan As Integer)
			Dim seleBrush As HatchBrush = New HatchBrush(HatchStyle.DiagonalCross, Color.Red, Color.Transparent)
			Dim seleBrush2 As HatchBrush = New HatchBrush(HatchStyle.DiagonalCross, Color.White, Color.Transparent)
			Dim mPen As Pen = New Pen(Color.White, 2F)
			mPen.Brush = seleBrush
			Dim mPen2 As Pen = New Pen(Color.Red, 2F)
			mPen2.Brush = seleBrush2
			' The following expression was wrapped in a checked-statement
			Try
				Dim g As Graphics = Me.m_Map.CreateGraphics()
				For i As Integer = 0 To pLan
					pSymbol.DanhDau(Me.m_Map, g, mPen)
					Thread.Sleep(50)
					Thread.Sleep(50)
					pSymbol.DanhDau(Me.m_Map, g, mPen2)
					Thread.Sleep(50)
					Me.m_Map.Refresh()
				Next
			Catch arg_C0_0 As Exception
				ProjectData.SetProjectError(arg_C0_0)
				ProjectData.ClearProjectError()
			Finally
				seleBrush.Dispose()
				seleBrush2.Dispose()
				mPen.Dispose()
				mPen2.Dispose()
			End Try
		End Sub

		Public Sub LuuGeoSet()
			Try
				Me.m_Map.Layers.Remove("LopVeKyHieu")
				Me.m_Map.SaveMapAsGeoset("BanDo", myModule.myMapGst)
				Me.m_Map.Layers.AddUserDrawLayer("LopVeKyHieu", 1S)
				Me.myZoom = Me.m_Map.Zoom
				Me.myCX = Me.m_Map.CenterX
				Me.myCY = Me.m_Map.CenterY
			Catch arg_7A_0 As Exception
				ProjectData.SetProjectError(arg_7A_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub AddDataSets()
			Me.m_Map.DataSets.RemoveAll()
			Dim arg_25_0 As Integer = 2
			Dim count As Integer = Me.m_Map.Layers.Count
			Dim i As Integer = arg_25_0
			' The following expression was wrapped in a checked-statement
			While True
				Dim arg_8F_0 As Integer = i
				Dim num As Integer = count
				If arg_8F_0 > num Then
					Exit While
				End If
				Dim lyr As Layer = Me.m_Map.Layers(i)
				Try
					Me.m_Map.DataSets.Add(DatasetTypeConstants.miDataSetLayer, lyr, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value)
				Catch expr_73 As Exception
					ProjectData.SetProjectError(expr_73)
					ProjectData.ClearProjectError()
				End Try
				i += 1
			End While
		End Sub

		Public Sub NhapNhay(pObj As Feature, pSoLan As Integer)
			Dim num2 As Integer
			Dim num3 As Integer
			Try
				IL_01:
				Dim num As Integer = 1
				Dim f As Feature = New FeatureClass()
				IL_0A:
				num = 2
				Dim myStyle As Style = New StyleClass()
				IL_14:
				num = 3
				Dim myStyle2 As Style = New StyleClass()
				IL_1E:
				num = 4
				Dim mColor As UInteger = 0UI
				IL_29:
				ProjectData.ClearProjectError()
				num2 = 2
				IL_31:
				num = 6
				Dim lyr As Layer = Me.m_Map.Layers.CreateLayer("tempAnimate", Missing.Value, 1, Missing.Value, Missing.Value)
				IL_5F:
				num = 7
				Me.m_Map.Layers.AnimationLayer = lyr
				IL_74:
				num = 8
				myStyle.SymbolFont.Name = "MapInfo Cartographic"
				IL_89:
				num = 9
				myStyle.SymbolFont.Size = New Decimal(18L)
				IL_A3:
				num = 10
				myStyle.SymbolCharacter = 72S
				IL_B1:
				num = 11
				myStyle.SymbolFontColor = UInteger.Parse(Conversions.ToString(16711935))
				IL_CC:
				num = 12
				myStyle2.SymbolFont.Name = "MapInfo Cartographic"
				IL_E2:
				num = 13
				myStyle2.SymbolFont.Size = New Decimal(18L)
				IL_FC:
				num = 14
				myStyle2.SymbolCharacter = 72S
				IL_10A:
				num = 15
				myStyle2.SymbolFontColor = UInteger.Parse(Conversions.ToString(16777215))
				IL_125:
				num = 16
				Dim pt As MapXLib.Point = New PointClass()
				IL_130:
				num = 17
				pt.[Set](pObj.Point.X, pObj.Point.Y)
				IL_152:
				num = 18
				Dim mTempNode As Feature = lyr.AddFeature(Me.m_Map.FeatureFactory.CreateSymbol(pt, myStyle), Missing.Value)
				IL_177:
				num = 19
				' The following expression was wrapped in a checked-statement
				For i As Integer = 1 To pSoLan
					IL_182:
					num = 20
					Thread.Sleep(100)
					IL_18E:
					num = 21
					Application.DoEvents()
					IL_198:
					num = 22
					mTempNode.Style = myStyle
					IL_1A6:
					num = 23
					lyr.UpdateFeature(mTempNode, mTempNode, Missing.Value)
					IL_1BA:
					num = 24
					Thread.Sleep(100)
					IL_1C6:
					num = 25
					Application.DoEvents()
					IL_1D0:
					num = 26
					mTempNode.Style = myStyle2
					IL_1DE:
					num = 27
					lyr.UpdateFeature(mTempNode, mTempNode, Missing.Value)
					IL_1F2:
					num = 28
				Next
				IL_207:
				num = 29
				myStyle = Nothing
				IL_20E:
				num = 30
				myStyle2 = Nothing
				IL_215:
				num = 31
				IL_21B:
				num = 32
				mTempNode = Nothing
				IL_222:
				ProjectData.ClearProjectError()
				num2 = -2
				IL_22B:
				num = 34
				Me.m_Map.Layers.Remove("tempAnimate")
				IL_247:
				GoTo IL_36E
				IL_24E:
				IL_24F:
				num = 36
				ProjectData.ClearProjectError()
				If num3 <> 0 Then
					GoTo IL_267
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_267:
				num3 = 0
				IL_26A:
				IL_26C:
				GoTo IL_36E
				IL_275:
				Dim arg_27C_0 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_27C_0)
				IL_31D:
				GoTo IL_363
				num3 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num2 > -2), num2, 1))
				IL_33F:
				GoTo IL_363
			End Try
			Dim arg_341_0 As Object
			endfilter(TypeOf arg_341_0 Is Exception And num2 <> 0 And num3 = 0)
			IL_363:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_36E:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub NhapNhayDT(pLop As String, pFKey As String, pSoLan As Integer)
			Dim num2 As Integer
			Dim num3 As Integer
			Try
				IL_01:
				Dim num As Integer = 1
				Dim myStyle As Style = New StyleClass()
				IL_0B:
				num = 2
				Dim mColor As UInteger = 0UI
				IL_16:
				ProjectData.ClearProjectError()
				num2 = 2
				IL_1E:
				num = 4
				Dim lyr2 As Layer = Me.m_Map.Layers(pLop)
				IL_34:
				num = 5
				Dim f As Feature = lyr2.GetFeatureByKey(pFKey)
				IL_40:
				num = 6
				Dim flag As Boolean = Not Me.m_Map.IsPointVisible(f.CenterX, f.CenterY)
				If Not flag Then
					GoTo IL_8D
				End If
				IL_63:
				num = 7
				Me.m_Map.CenterX = f.CenterX
				IL_78:
				num = 8
				Me.m_Map.CenterY = f.CenterY
				IL_8D:
				IL_8E:
				num = 10
				flag = (f.Type = FeatureTypeConstants.miFeatureTypeSymbol)
				If Not flag Then
					GoTo IL_B3
				End If
				IL_A1:
				num = 11
				Me.NhapNhay(f, pSoLan)
				IL_AE:
				GoTo IL_279
				IL_B3:
				num = 13
				IL_B8:
				num = 14
				myStyle = f.Style
				IL_C4:
				num = 15
				flag = (f.Type = FeatureTypeConstants.miFeatureTypeLine)
				If Not flag Then
					GoTo IL_105
				End If
				IL_D7:
				num = 16
				myStyle.LineColor = UInteger.Parse(Conversions.ToString(255))
				IL_F2:
				num = 17
				myStyle.LineStyle = CType(46, PenStyleConstants)
				IL_100:
				GoTo IL_18B
				IL_105:
				num = 19
				flag = (f.Type = FeatureTypeConstants.miFeatureTypeRegion)
				If Not flag Then
					GoTo IL_15D
				End If
				IL_118:
				num = 20
				myStyle.RegionBorderColor = UInteger.Parse(Conversions.ToString(16777215))
				IL_133:
				num = 21
				myStyle.RegionPattern = FillPatternConstants.miPatternDiagCross
				IL_140:
				num = 22
				myStyle.RegionColor = UInteger.Parse(Conversions.ToString(255))
				IL_15B:
				GoTo IL_18B
				IL_15D:
				num = 24
				flag = (f.Type = FeatureTypeConstants.miFeatureTypeText)
				If Not flag Then
					GoTo IL_18B
				End If
				IL_170:
				num = 25
				myStyle.TextFontColor = UInteger.Parse(Conversions.ToString(16777215))
				IL_18B:
				IL_18C:
				num = 27
				f.Style = myStyle
				IL_199:
				num = 28
				Dim lyr3 As Layer = Me.m_Map.Layers.CreateLayer("tempAnimate", Missing.Value, 1, Missing.Value, Missing.Value)
				IL_1C8:
				num = 29
				Me.m_Map.Layers.AnimationLayer = lyr3
				IL_1DE:
				num = 30
				lyr3.AddFeature(f, Missing.Value)
				IL_1EF:
				num = 31
				' The following expression was wrapped in a checked-statement
				For i As Integer = 1 To pSoLan
					IL_1FA:
					num = 32
					lyr3.Visible = True
					IL_206:
					num = 33
					Thread.Sleep(120)
					IL_212:
					num = 34
					Application.DoEvents()
					IL_21C:
					num = 35
					lyr3.Visible = False
					IL_228:
					num = 36
					Thread.Sleep(120)
					IL_234:
					num = 37
					Application.DoEvents()
					IL_23E:
					num = 38
				Next
				IL_250:
				num = 39
				f = Nothing
				IL_256:
				ProjectData.ClearProjectError()
				num2 = -2
				IL_25F:
				num = 41
				Me.m_Map.Layers.Remove("tempAnimate")
				IL_279:
				IL_27C:
				GoTo IL_3D8
				IL_283:
				IL_284:
				num = 44
				Interaction.MsgBox("Khong tim thay.", MsgBoxStyle.OkOnly, Nothing)
				IL_295:
				num = 45
				ProjectData.ClearProjectError()
				If num3 <> 0 Then
					GoTo IL_2AD
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_2AD:
				num3 = 0
				IL_2B0:
				IL_2B2:
				GoTo IL_3D8
				IL_2BB:
				Dim arg_2C2_0 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_2C2_0)
				IL_387:
				GoTo IL_3CD
				num3 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num2 > -2), num2, 1))
				IL_3A9:
				GoTo IL_3CD
			End Try
			Dim arg_3AB_0 As Object
			endfilter(TypeOf arg_3AB_0 Is Exception And num2 <> 0 And num3 = 0)
			IL_3CD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3D8:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub DiaDanhTrenBD()
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
		End Sub

		Private Sub m_Map_DrawUserLayer(sender As Object, e As CMapXEvents_DrawUserLayerEvent)
			Dim seleBrush As HatchBrush = New HatchBrush(HatchStyle.DiagonalCross, Color.White, Color.Transparent)
			Dim mPen As Pen = New Pen(Color.Blue, 4F)
			mPen.Brush = seleBrush
			Dim hdc As IntPtr = New IntPtr(e.hOutputDC)
			Dim myGraphics As Graphics = Graphics.FromHdc(hdc)
			Dim flag2 As Boolean
			Try
				Me.m_DrawingSymbols.DrawSymbols(Me.m_Map, myGraphics)
				Dim flag As Boolean = Me.m_SelectedSymbol IsNot Nothing
				If flag Then
					flag2 = (Me.myMapTool = CBanDo.MapTools.NodesEdit)
					If flag2 Then
						Me.m_SelectedSymbol.DrawNodes(Me.m_Map, myGraphics)
					Else
						flag2 = (Me.myMapTool = CBanDo.MapTools.ChangeRoot)
						If flag2 Then
							Me.m_SelectedSymbol.DrawRoot(Me.m_Map, myGraphics)
						Else
							Me.m_SelectedSymbol.DanhDau(Me.m_Map, myGraphics, modBanDo.DanhDauColor)
							Me.m_SelectedSymbol.DanhDau(Me.m_Map, myGraphics, mPen)
						End If
					End If
				End If
				flag2 = (Me.m_SelectedSymbols.Count > 0)
				If flag2 Then
					Try
						Dim enumerator As IEnumerator = Me.m_SelectedSymbols.GetEnumerator()
						While enumerator.MoveNext()
							Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
							mSymbol.VeBound(Me.m_Map, myGraphics, modBanDo.VeBoundColor)
						End While
					Finally
						Dim enumerator As IEnumerator
						flag2 = (TypeOf enumerator Is IDisposable)
						If flag2 Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
				End If
			Catch expr_159 As Exception
				ProjectData.SetProjectError(expr_159)
				Dim ex As Exception = expr_159
				Throw New ApplicationException("Error Drawing Graphics Surface", ex)
			Finally
				mPen.Dispose()
				seleBrush.Dispose()
			End Try
			flag2 = Me.bGrid
			' The following expression was wrapped in a checked-statement
			If flag2 Then
				Me.GridSize.Width = Me.myGridWidth
				Me.GridSize.Height = Me.myGridWidth
				Me.GridRect.Width = CInt(Math.Round(CDec(Me.m_Map.MapScreenWidth)))
				Me.GridRect.Height = CInt(Math.Round(CDec(Me.m_Map.MapScreenHeight)))
				ControlPaint.DrawGrid(myGraphics, Me.GridRect, Me.GridSize, Color.Red)
			End If
		End Sub

		Private Sub DrawDrawingLine(pPts As PointF())
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(1F, 1F)
			Dim mPtsCount As Integer = pPts.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim mPts As System.Drawing.Point() = New System.Drawing.Point(mPtsCount + 1 - 1) {}
			Dim arg_71_0 As Integer = 0
			Dim num As Integer = mPtsCount
			Dim i As Integer = arg_71_0
			While True
				Dim arg_C2_0 As Integer = i
				Dim num2 As Integer = num
				If arg_C2_0 > num2 Then
					Exit While
				End If
				mPts(i).X = CInt(Math.Round(CDec(pPts(i).X)))
				mPts(i).Y = CInt(Math.Round(CDec(pPts(i).Y)))
				i += 1
			End While
			Select Case Me.myMapTool
				Case CBanDo.MapTools.Polygon
					Dim flag As Boolean = pPts.GetUpperBound(0) > 1
					If flag Then
						g.DrawPolygon(DrawingPen, mPts)
					Else
						g.DrawLines(DrawingPen, mPts)
					End If
				Case CBanDo.MapTools.Line, CBanDo.MapTools.MuiTenDon, CBanDo.MapTools.MuiTen, CBanDo.MapTools.MuiTenDac, CBanDo.MapTools.MuiTenHo, CBanDo.MapTools.Ruler
					g.DrawLines(DrawingPen, mPts)
				Case CBanDo.MapTools.Curve, CBanDo.MapTools.SongSong, CBanDo.MapTools.GetTarget
					g.DrawCurve(DrawingPen, mPts)
				Case CBanDo.MapTools.ClosedCurve, CBanDo.MapTools.SongSongKin
					Dim flag As Boolean = pPts.GetUpperBound(0) > 1
					If flag Then
						g.DrawClosedCurve(DrawingPen, mPts)
					Else
						g.DrawLines(DrawingPen, mPts)
					End If
			End Select
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
			DrawingPen.Dispose()
		End Sub

		Private Sub DrawMovingSymbol(seleSymbol As CSymbol)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			seleSymbol.Draw(Me.m_Map, g)
		End Sub

		Private Sub DrawMovingSymbols(seleSymbols As CSymbols)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Try
				Dim enumerator As IEnumerator = seleSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					mSymbol.Draw(Me.m_Map, g)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub DrawMovingNode(seleSymbol As CSymbol)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			seleSymbol.Draw(Me.m_Map, g)
			seleSymbol.DrawNodes(Me.m_Map, g)
		End Sub

		Private Sub DrawMovingRoot(seleSymbol As CSymbol)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			seleSymbol.Draw(Me.m_Map, g)
			seleSymbol.DrawRoot(Me.m_Map, g)
		End Sub

		Private Sub DrawRotatingSymbol(ByRef seleSymbol As CSymbol, dragPoint As PointF)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 3F)
			seleSymbol.Draw(Me.m_Map, g)
			Dim mPts As PointF() = New PointF(1) {}
			mPts(0).X = Me.myrootPt.X
			mPts(0).Y = Me.myrootPt.Y
			mPts(1).X = dragPoint.X
			mPts(1).Y = dragPoint.Y
			DrawingPen.EndCap = LineCap.ArrowAnchor
			DrawingPen.StartCap = LineCap.RoundAnchor
			g.DrawLine(DrawingPen, mPts(0), mPts(1))
			DrawingPen.Dispose()
		End Sub

		Private Sub DrawSplittingLine(dragPoint As PointF)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 3F)
			Dim mPts As PointF() = New PointF(1) {}
			mPts(0).X = Me.myfromPt.X
			mPts(0).Y = Me.myfromPt.Y
			mPts(1).X = dragPoint.X
			mPts(1).Y = dragPoint.Y
			g.DrawLine(DrawingPen, mPts(0), mPts(1))
			DrawingPen.Dispose()
		End Sub

		Private Sub DrawSelectionRectangle(selectionRect As RectangleF)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
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

		Private Sub DrawDrawingRectangle(DrawingRect As System.Drawing.Rectangle)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			Dim normalizedRectangle As System.Drawing.Rectangle
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
			g.DrawRectangle(DrawingPen, normalizedRectangle)
			DrawingPen.Dispose()
		End Sub

		Private Sub DrawDrawingArc(DrawingRect As System.Drawing.Rectangle)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim mPt0 As PointF = Nothing
			Dim myPts2 As PointF() = New PointF(3) {}
			myPts2(1).X = CSng(DrawingRect.X)
			myPts2(1).Y = CSng(DrawingRect.Y)
			' The following expression was wrapped in a checked-statement
			myPts2(2).X = CSng((DrawingRect.X + DrawingRect.Width))
			myPts2(2).Y = CSng(DrawingRect.Y)
			myPts2(3).X = CSng((DrawingRect.X + DrawingRect.Width))
			myPts2(3).Y = CSng((DrawingRect.Y + DrawingRect.Height))
			myPts2(0).X = CSng(DrawingRect.X)
			myPts2(0).Y = CSng((DrawingRect.Y + DrawingRect.Height))
			Dim myCurve As NodesShapeGraphic = New LinesGraphic(myPts2, 1F, Color.Red)
			myCurve.Fill = False
			myCurve.FillColor = modBanDo.defaGenFillC
			myCurve.Rotation = 0F
			myCurve.LineWidth = CSng(modBanDo.defaGenPen1W)
			myCurve.LineColor = modBanDo.defaGenPen1C
			myCurve.Line2Width = CSng(modBanDo.defaGenPen2W)
			myCurve.Line2Color = modBanDo.defaGenPen2C
			myCurve.LineStyle = modBanDo.defaGenLineStyle
			myCurve.StyleWidth = 8F
			myCurve.Nodes(1).IsControl = True
			myCurve.Nodes(2).IsControl = True
			myCurve.Draw(g)
		End Sub

		Private Sub DrawDrawingEllipse(DrawingRect As System.Drawing.Rectangle)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			g.DrawEllipse(DrawingPen, DrawingRect)
			DrawingPen.Dispose()
		End Sub

		Private Function DrawDrawingPie(DrawingRect As System.Drawing.Rectangle) As Boolean
			Dim DrawDrawingPie As Boolean
			Try
				Dim g As Graphics = Me.m_Map.CreateGraphics()
				Me.m_Map.Refresh()
				Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
				' The following expression was wrapped in a checked-expression
				Dim mRect As System.Drawing.Rectangle = New System.Drawing.Rectangle(DrawingRect.Left - DrawingRect.Width, DrawingRect.Top - DrawingRect.Height, DrawingRect.Width * 2, DrawingRect.Height * 2)
				g.DrawPie(DrawingPen, mRect, 0F, 90F)
				DrawingPen.Dispose()
				DrawDrawingPie = True
			Catch arg_89_0 As Exception
				ProjectData.SetProjectError(arg_89_0)
				DrawDrawingPie = False
				ProjectData.ClearProjectError()
			End Try
			Return DrawDrawingPie
		End Function

		Private Sub DrawDrawingRectangle0(DrawingRect As RectangleF)
			Dim g As Graphics = Me.m_Map.CreateGraphics()
			Me.m_Map.Refresh()
			Dim DrawingPen As Pen = New Pen(Color.FromArgb(75, Color.Gray), 2F)
			Dim myOriginalMatrix As Matrix = g.Transform
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.PageUnit = GraphicsUnit.Pixel
			g.ScaleTransform(1F, 1F)
			Dim pPts As PointF() = New PointF(1) {}
			pPts(0).X = DrawingRect.X
			pPts(0).Y = DrawingRect.Y
			pPts(1).X = DrawingRect.X + DrawingRect.Width
			pPts(1).Y = DrawingRect.Y + DrawingRect.Height
			Dim mPtsCount As Integer = pPts.GetUpperBound(0)
			' The following expression was wrapped in a checked-statement
			Dim mPts As System.Drawing.Point() = New System.Drawing.Point(mPtsCount + 1 - 1) {}
			Dim arg_DE_0 As Integer = 0
			Dim num As Integer = mPtsCount
			Dim i As Integer = arg_DE_0
			While True
				Dim arg_1A9_0 As Integer = i
				Dim num2 As Integer = num
				If arg_1A9_0 > num2 Then
					Exit While
				End If
				Dim arg_143_0 As AxMap = Me.m_Map
				Dim arg_F1_0 As System.Drawing.Point() = mPts
				Dim num3 As Integer = i
				Dim num4 As Single = CSng(arg_F1_0(num3).X)
				Dim arg_107_0 As System.Drawing.Point() = mPts
				Dim num5 As Integer = i
				Dim num6 As Single = CSng(arg_107_0(num5).Y)
				Dim arg_11D_0 As PointF() = pPts
				Dim num7 As Integer = i
				Dim num8 As Double = CDec(arg_11D_0(num7).X)
				Dim arg_133_0 As PointF() = pPts
				Dim num9 As Integer = i
				Dim num10 As Double = CDec(arg_133_0(num9).Y)
				arg_143_0.ConvertCoord(num4, num6, num8, num10, ConversionConstants.miMapToScreen)
				pPts(num9).Y = CSng(num10)
				pPts(num7).X = CSng(num8)
				mPts(num5).Y = CInt(Math.Round(CDec(num6)))
				mPts(num3).X = CInt(Math.Round(CDec(num4)))
				i += 1
			End While
			Dim rect As System.Drawing.Rectangle = New System.Drawing.Rectangle(mPts(0).X, mPts(0).Y, mPts(1).X - mPts(0).X, mPts(1).Y - mPts(0).Y)
			g.DrawRectangle(DrawingPen, rect)
			g.EndContainer(gCon)
			g.Transform = myOriginalMatrix
			DrawingPen.Dispose()
		End Sub

		Private Sub m_Map_MapViewChanged(sender As Object, e As EventArgs)
			Me.m_ParentForm.ToolStripStatusLabel2.Text = Strings.Format(Me.m_Map.Zoom, "#,# m") + " | " + Strings.Format(Me.m_Map.Width, "#,#")
		End Sub

		Private Sub m_Map_MouseDownEvent(sender As Object, e As CMapXEvents_MouseDownEvent)
			Dim flag As Boolean = Me.bSnap
			' The following expression was wrapped in a checked-statement
			Dim mousePT As System.Drawing.Point
			If flag Then
				mousePT = Me.Snap(e.x, e.y)
			Else
				mousePT = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			End If
			Select Case Me.myMapTool
				Case CBanDo.MapTools.Polygon, CBanDo.MapTools.Line, CBanDo.MapTools.Curve, CBanDo.MapTools.ClosedCurve, CBanDo.MapTools.MuiTenDon, CBanDo.MapTools.MuiTen, CBanDo.MapTools.MuiTenDac, CBanDo.MapTools.MuiTenHo, CBanDo.MapTools.SongSong, CBanDo.MapTools.SongSongKin, CBanDo.MapTools.Ruler, CBanDo.MapTools.GetTarget
					Dim flag2 As Boolean = e.button = 1S
					If flag2 Then
						flag = Not Me.DrawingPicking
						If flag Then
							Me.DrawingPicking = True
							Me.myPts = New PointF(1) {}
							Me.myPts(0) = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
							Me.myPts(1) = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
						Else
							Dim i As Integer = Me.myPts.GetUpperBound(0)
							i += 1
							Me.myPts = CType(Utils.CopyArray(CType(Me.myPts, Array), New PointF(i + 1 - 1) {}), PointF())
							Me.myPts(i) = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
						End If
					Else
						flag2 = Not Me.DrawingPicking
						If flag2 Then
							flag = (Me.myMapTool = CBanDo.MapTools.GetTarget)
							If flag Then
								Me.myPts = New PointF(0) {}
								Me.myPts(0) = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
								Me.GetTargets()
							End If
						End If
						flag2 = (Me.myPts.GetUpperBound(0) > 0)
						Dim flag3 As Boolean
						If flag2 Then
							flag = (Me.myMapTool = CBanDo.MapTools.Ruler)
							If flag Then
								flag3 = (Me.myPts.GetUpperBound(0) > 0)
								If flag3 Then
									Dim arg_E1B_0 As Integer = 1
									Dim upperBound As Integer = Me.myPts.GetUpperBound(0)
									Dim j As Integer = arg_E1B_0
									While True
										Dim arg_F9B_0 As Integer = j
										Dim num As Integer = upperBound
										If arg_F9B_0 > num Then
											Exit While
										End If
										Dim arg_E65_0 As AxMap = Me.m_Map
										Dim arg_E36_0 As PointF() = Me.myPts
										Dim num2 As Integer = j - 1
										Dim num3 As Single = arg_E36_0(num2).X
										Dim arg_E52_0 As PointF() = Me.myPts
										Dim num4 As Integer = j - 1
										Dim num5 As Single = arg_E52_0(num4).Y
										Dim mLon As Double
										Dim mLat As Double
										arg_E65_0.ConvertCoord(num3, num5, mLon, mLat, ConversionConstants.miScreenToMap)
										Me.myPts(num4).Y = num5
										Me.myPts(num2).X = num3
										Dim arg_ED4_0 As AxMap = Me.m_Map
										Dim arg_EA7_0 As PointF() = Me.myPts
										num4 = j
										num3 = arg_EA7_0(num4).X
										Dim arg_EC1_0 As PointF() = Me.myPts
										num2 = j
										num5 = arg_EC1_0(num2).Y
										Dim mLon2 As Double
										Dim mLat2 As Double
										arg_ED4_0.ConvertCoord(num3, num5, mLon2, mLat2, ConversionConstants.miScreenToMap)
										Me.myPts(num2).Y = num5
										Me.myPts(num4).X = num3
										Dim mDist As Integer = CInt(Math.Round(Me.m_Map.Distance(mLon, mLat, mLon2, mLat2)))
										flag3 = (Me.strDistanceKQ.Length > 0)
										If flag3 Then
											Me.DistanceKQ += mDist
											Me.strDistanceKQ = Me.strDistanceKQ + " + " + Strings.Format(mDist, "#,###")
										Else
											Me.DistanceKQ = mDist
											Me.strDistanceKQ = Strings.Format(mDist, "#,###")
										End If
										j += 1
									End While
								End If
								flag3 = (Me.strDistanceKQ.IndexOf("+") > -1)
								If flag3 Then
									Me.strDistanceKQ = String.Concat(New String() { Me.strDistanceKQ, " = ", Strings.Format(Me.DistanceKQ, "#,###"), " ", Me.strDistanceUnit })
								Else
									Me.strDistanceKQ = Strings.Format(Me.DistanceKQ, "#,###") + " " + Me.strDistanceUnit
								End If
								MessageBox.Show(Me.m_ParentForm, Me.strDistanceKQ, "K" & ChrW(7871) & "t qu" & ChrW(7843) & " " & ChrW(273) & "o:", MessageBoxButtons.OK)
							Else
								flag3 = (Me.myMapTool = CBanDo.MapTools.GetTarget)
								If flag3 Then
									Me.GetTargets()
								Else
									Me.AddNewObj(e.shift)
								End If
							End If
						End If
						Me.DrawingPicking = False
						flag3 = (Me.myMapTool = CBanDo.MapTools.Ruler)
						If flag3 Then
							Me.strDistanceKQ = ""
							Me.myPts = New PointF(-1) {}
							Me.m_ParentForm.ToolStripStatusLabel3.Text = ChrW(272) & "o kho" & ChrW(7843) & "ng cách: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các V" & ChrW(7883) & " trí, RightClick " & ChrW(273) & ChrW(7875) & " xem K" & ChrW(7871) & "t qu" & ChrW(7843) & "."
						Else
							flag3 = (Me.myMapTool = CBanDo.MapTools.GetTarget)
							If flag3 Then
								Me.myPts = New PointF(-1) {}
								Me.m_ParentForm.ToolStripStatusLabel3.Text = ""
								Me.m_Map.CurrentTool = ToolConstants.miArrowTool
								Me.myMapTool = CBanDo.MapTools.None
							Else
								Me.OnCapNhatKH()
							End If
						End If
					End If
				Case CBanDo.MapTools.Cycle, CBanDo.MapTools.Rectangle, CBanDo.MapTools.arc
					Dim flag3 As Boolean = e.button = 1S
					If flag3 Then
						Me.DrawingDragging = True
						Me.DrawingRect.X = mousePT.X
						Me.DrawingRect.Y = mousePT.Y
						Me.DrawingRect.Height = 0
						Me.DrawingRect.Width = 0
					End If
				Case CBanDo.MapTools.Text
					Me.myPts = New PointF(0) {}
					Me.myPts(0) = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.AddNewObj(e.shift)
					Dim f As dlgChangeText = New dlgChangeText()
					f.TextObj = CType(Me.m_DrawingSymbols(Me.m_DrawingSymbols.Count - 1).GObjs(0), TextGraphic)
					Dim arg_1252_0 As dlgChangeText = f
					Dim location As System.Drawing.Point = Me.m_ParentForm.Location
					Dim pos As System.Drawing.Point = New System.Drawing.Point(location.X + Me.m_Panel.Left + mousePT.X, Me.m_ParentForm.Location.Y + Me.m_Panel.Top + mousePT.Y)
					arg_1252_0.Pos = pos
					myModule.fCallForm = Me.m_ParentForm
					f.ShowDialog(Me.m_ParentForm)
					Me.m_Map.CenterX = Me.m_Map.CenterX
					Me.OnCapNhatKH()
				Case CBanDo.MapTools.Table
					Me.myPts = New PointF(0) {}
					Me.myPts(0) = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.AddNewObj(e.shift)
					Me.OnCapNhatKH()
				Case CBanDo.MapTools.ChonKH
					flag = (e.button = 1S)
					If flag Then
						Dim flag2 As Boolean = e.shift = 1S
						If flag2 Then
							Me.selectionDragging = True
							Me.selectionRect.X = e.x
							Me.selectionRect.Y = e.y
							Me.selectionRect.Height = 0F
							Me.selectionRect.Width = 0F
						Else
							flag2 = (e.shift = 3S)
							If flag2 Then
								Dim arg_1CD_0 As CSymbols = Me.m_DrawingSymbols
								Dim arg_1CD_1 As AxMap = Me.m_Map
								Dim pointF As PointF = New PointF(e.x, e.y)
								Dim mSymbolObj As CSymbol = arg_1CD_0.FindSymbolAtPoint(arg_1CD_1, pointF)
								flag2 = (mSymbolObj IsNot Nothing)
								If flag2 Then
									Dim bCoRoi As Boolean = False
									Try
										Dim enumerator As IEnumerator = Me.m_SelectedSymbols.GetEnumerator()
										While enumerator.MoveNext()
											Dim mSObj As CSymbol = CType(enumerator.Current, CSymbol)
											flag2 = (mSObj Is mSymbolObj)
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
										Me.m_SelectedSymbols.Remove(mSymbolObj)
									Else
										Me.m_SelectedSymbols.Add(mSymbolObj)
									End If
									Me.m_Map.CenterX = Me.m_Map.CenterX
								End If
							Else
								Me.m_SelectedSymbols.Clear()
								Dim arg_2B6_0 As CSymbols = Me.m_DrawingSymbols
								Dim arg_2B6_1 As AxMap = Me.m_Map
								Dim pointF As PointF = New PointF(e.x, e.y)
								Me.SelectedSymbol = arg_2B6_0.FindSymbolAtPoint(arg_2B6_1, pointF)
								flag2 = (Me.m_SelectedSymbol IsNot Nothing)
								If flag2 Then
									Me.m_ParentForm.lstCacKyHieu.SelectedIndex = Me.m_ParentForm.lstCacKyHieu.Items.IndexOf(Me.m_SelectedSymbol)
									Select Case e.shift
										Case 2S
											Me.PopUndo()
											Me.myMapTool = CBanDo.MapTools.DangMove
											Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
										Case 4S
											Me.PopUndo()
											Me.myMapTool = CBanDo.MapTools.DangRotate
											Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.myrootPt = Nothing
											Dim arg_419_0 As AxMap = Me.m_Map
											Dim num5 As Single = Me.myrootPt.X
											Dim num3 As Single = Me.myrootPt.Y
											Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
											Dim num6 As Double = selectedSymbol.GocX
											Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
											Dim num7 As Double = selectedSymbol2.GocY
											arg_419_0.ConvertCoord(num5, num3, num6, num7, ConversionConstants.miMapToScreen)
											selectedSymbol2.GocY = num7
											selectedSymbol.GocX = num6
											Me.myrootPt.Y = num3
											Me.myrootPt.X = num5
											pointF = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.DrawRotatingSymbol(Me.m_SelectedSymbol, pointF)
										Case 6S
											Me.PopUndo()
											Me.myMapTool = CBanDo.MapTools.DangScale
											Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.myrootPt = Nothing
											Dim arg_51A_0 As AxMap = Me.m_Map
											Dim num3 As Single = Me.myrootPt.X
											Dim num5 As Single = Me.myrootPt.Y
											Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
											Dim num7 As Double = selectedSymbol2.GocX
											Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
											Dim num6 As Double = selectedSymbol.GocY
											arg_51A_0.ConvertCoord(num3, num5, num7, num6, ConversionConstants.miMapToScreen)
											selectedSymbol.GocY = num6
											selectedSymbol2.GocX = num7
											Me.myrootPt.Y = num5
											Me.myrootPt.X = num3
											pointF = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
											Me.DrawRotatingSymbol(Me.m_SelectedSymbol, pointF)
									End Select
								End If
							End If
						End If
					Else
						Dim mapTools As CBanDo.MapTools = Me.myMapTool
						Dim flag2 As Boolean = mapTools = CBanDo.MapTools.ChonKH
						If flag2 Then
							flag = (Me.m_SelectedSymbols.Count > 0)
							If flag Then
								Dim arg_5E0_0 As ContextMenu = Me.CxtMnuGroup
								Dim arg_5E0_1 As Control = Me.m_Panel
								Dim location As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
								arg_5E0_0.Show(arg_5E0_1, location)
							Else
								Dim arg_60F_0 As CSymbols = Me.m_DrawingSymbols
								Dim arg_60F_1 As AxMap = Me.m_Map
								Dim pointF As PointF = New PointF(e.x, e.y)
								Me.FoundObject = arg_60F_0.FindObjectAtPoint(arg_60F_1, pointF)
								flag2 = (Me.FoundObject IsNot Nothing)
								If flag2 Then
									Me.m_Map.Refresh()
									Me.m_SelectedObject = Me.FoundObject.FoundObject
									Me.m_SelectedSymbol = Me.FoundObject.FoundSymbol
									Me.FoundObject.FoundSymbol.DanhDau(Me.m_Map, Me.m_Map.CreateGraphics(), modBanDo.DanhDauColor)
									Me.FoundObject.FoundSymbol.VeBound(Me.m_Map, Me.m_Map.CreateGraphics(), modBanDo.VeBoundColor)
									Me.FoundObject.FoundSymbol.VeBound(Me.m_Map, Me.m_Map.CreateGraphics(), Me.m_SelectedObject, modBanDo.VeBoundColor)
									Me.FoundObject.FoundSymbol.DanhDau(Me.m_Map, Me.m_Map.CreateGraphics(), Me.m_SelectedObject, modBanDo.DanhDauColor2)
									Dim arg_734_0 As ContextMenu = Me.CxtMnuKyHieu
									Dim arg_734_1 As Control = Me.m_Panel
									Dim location As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
									arg_734_0.Show(arg_734_1, location)
								Else
									Me.mousePos = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
									Dim arg_789_0 As ContextMenu = Me.CxtMnuMap
									Dim arg_789_1 As Control = Me.m_Panel
									Dim location As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
									arg_789_0.Show(arg_789_1, location)
								End If
							End If
						End If
					End If
				Case CBanDo.MapTools.Move
					Me.PopUndo()
					Me.myMapTool = CBanDo.MapTools.DangMove
					Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
				Case CBanDo.MapTools.Scale
					Me.PopUndo()
					Me.myMapTool = CBanDo.MapTools.DangScale
					Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.myrootPt = Nothing
					Dim arg_A37_0 As AxMap = Me.m_Map
					Dim num3 As Single = Me.myrootPt.X
					Dim num5 As Single = Me.myrootPt.Y
					Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
					Dim num7 As Double = selectedSymbol2.GocX
					Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
					Dim num6 As Double = selectedSymbol.GocY
					arg_A37_0.ConvertCoord(num3, num5, num7, num6, ConversionConstants.miMapToScreen)
					selectedSymbol.GocY = num6
					selectedSymbol2.GocX = num7
					Me.myrootPt.Y = num5
					Me.myrootPt.X = num3
					Dim pointF As PointF = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.DrawRotatingSymbol(Me.m_SelectedSymbol, pointF)
				Case CBanDo.MapTools.Rotate
					Me.PopUndo()
					Me.myMapTool = CBanDo.MapTools.DangRotate
					Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.myrootPt = Nothing
					Dim arg_B38_0 As AxMap = Me.m_Map
					Dim num3 As Single = Me.myrootPt.X
					Dim num5 As Single = Me.myrootPt.Y
					Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
					Dim num7 As Double = selectedSymbol2.GocX
					Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
					Dim num6 As Double = selectedSymbol.GocY
					arg_B38_0.ConvertCoord(num3, num5, num7, num6, ConversionConstants.miMapToScreen)
					selectedSymbol.GocY = num6
					selectedSymbol2.GocX = num7
					Me.myrootPt.Y = num5
					Me.myrootPt.X = num3
					Dim pointF As PointF = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.DrawRotatingSymbol(Me.m_SelectedSymbol, pointF)
				Case CBanDo.MapTools.GrMove
					Me.PopUndo()
					Me.myMapTool = CBanDo.MapTools.GrDangMove
					Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
				Case CBanDo.MapTools.Split
					Me.PopUndo()
					Me.myMapTool = CBanDo.MapTools.DangSplit
					Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.myrootPt = Nothing
					Dim arg_C39_0 As AxMap = Me.m_Map
					Dim num3 As Single = Me.myrootPt.X
					Dim num5 As Single = Me.myrootPt.Y
					Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
					Dim num7 As Double = selectedSymbol2.GocX
					Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
					Dim num6 As Double = selectedSymbol.GocY
					arg_C39_0.ConvertCoord(num3, num5, num7, num6, ConversionConstants.miMapToScreen)
					selectedSymbol.GocY = num6
					selectedSymbol2.GocX = num7
					Me.myrootPt.Y = num5
					Me.myrootPt.X = num3
					Dim pointF As PointF = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.DrawSplittingLine(pointF)
				Case CBanDo.MapTools.NodesEdit
					Dim arg_7BC_0 As CSymbol = Me.m_SelectedSymbol
					Dim arg_7BC_1 As AxMap = Me.m_Map
					Dim pointF As PointF = New PointF(e.x, e.y)
					Me.FoundNode = arg_7BC_0.FindNodeAtPoint(arg_7BC_1, pointF)
					Dim flag2 As Boolean = Me.FoundNode IsNot Nothing
					If flag2 Then
						Me.PopUndo()
						flag2 = (e.button = 1S)
						If flag2 Then
							Me.NodeDragging = True
							Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
							Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
						Else
							Dim arg_863_0 As ContextMenu = Me.CxtMnuNodeEdit
							Dim arg_863_1 As Control = Me.m_Panel
							Dim location As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
							arg_863_0.Show(arg_863_1, location)
						End If
					Else
						Me.OnCapNhatKH()
					End If
				Case CBanDo.MapTools.ChangeRoot
					Dim arg_89D_0 As CSymbol = Me.m_SelectedSymbol
					Dim arg_89D_1 As AxMap = Me.m_Map
					Dim pointF As PointF = New PointF(e.x, e.y)
					Dim flag2 As Boolean = arg_89D_0.RootHitTest(arg_89D_1, pointF)
					If flag2 Then
						Me.PopUndo()
						Me.RootDragging = True
						Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
						Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Else
						Me.OnCapNhatKH()
					End If
				Case CBanDo.MapTools.GetObjName
					Dim arg_104_0 As CSymbols = Me.m_DrawingSymbols
					Dim arg_104_1 As AxMap = Me.m_Map
					Dim pointF As PointF = New PointF(e.x, e.y)
					Dim mSymbolObj2 As CSymbol = arg_104_0.FindSymbolAtPoint(arg_104_1, pointF)
					flag = (mSymbolObj2 IsNot Nothing)
					If flag Then
						Me.GetObjName(mSymbolObj2)
					End If
			End Select
		End Sub

		Private Sub m_Map_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			Dim flag As Boolean = Me.bSnap
			Dim mousePT As System.Drawing.Point
			' The following expression was wrapped in a checked-statement
			If flag Then
				mousePT = Me.Snap(e.x, e.y)
			Else
				mousePT = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			End If
			Dim dragPoint As MAPPOINT = Me.gscTogoc(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			Me.m_ParentForm.ToolStripStatusLabel1.Text = dragPoint.X.ToString("0.000000000") + ", " + dragPoint.Y.ToString("0.000000000")
			flag = Me.selectionDragging
			If flag Then
				Me.selectionRect.Width = e.x - Me.selectionRect.X
				Me.selectionRect.Height = e.y - Me.selectionRect.Y
				Me.DrawSelectionRectangle(Me.selectionRect)
			End If
			flag = (Me.m_SelectedSymbols.Count > 0)
			Dim flag2 As Boolean
			If flag Then
				flag2 = (Me.myMapTool = CBanDo.MapTools.GrDangMove)
				If flag2 Then
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Try
						Dim enumerator As IEnumerator = Me.m_SelectedSymbols.GetEnumerator()
						While enumerator.MoveNext()
							Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
							mSymbol.Move(Me.m_Map, Me.myfromPt, Me.mytoPt)
						End While
					Finally
						Dim enumerator As IEnumerator
						flag2 = (TypeOf enumerator Is IDisposable)
						If flag2 Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
					Me.myfromPt = Me.mytoPt
					Me.DrawMovingSymbols(Me.m_SelectedSymbols)
				End If
			End If
			flag2 = Not Information.IsNothing(modBanDo.fCacKyHieu)
			Dim flag3 As Boolean
			If flag2 Then
				flag = (Me.myMapTool = CBanDo.MapTools.DangLayKH)
				If flag Then
					flag3 = Information.IsNothing(Me.m_KHfromVeKH)
					If flag3 Then
						Me.myfromPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
						Me.m_KHfromVeKH = Me.GetKHfromVeKH(Me.myfromPt)
					End If
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.m_KHfromVeKH.Move(Me.m_Map, Me.myfromPt, Me.mytoPt)
					Me.myfromPt = Me.mytoPt
					Me.DrawMovingSymbol(Me.m_KHfromVeKH)
				End If
			End If
			flag3 = (Me.m_SelectedSymbol IsNot Nothing)
			' The following expression was wrapped in a checked-statement
			If flag3 Then
				flag2 = (Me.myMapTool = CBanDo.MapTools.DangMove)
				If flag2 Then
					Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
					Me.m_SelectedSymbol.Move(Me.m_Map, Me.myfromPt, Me.mytoPt)
					Me.myfromPt = Me.mytoPt
					Me.DrawMovingSymbol(Me.m_SelectedSymbol)
				Else
					flag3 = (Me.myMapTool = CBanDo.MapTools.DangRotate)
					If flag3 Then
						Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
						Me.m_SelectedSymbol.Rotate(Me.m_Map, Me.myrootPt, Me.myfromPt, Me.mytoPt)
						Me.myfromPt = Me.mytoPt
						Me.DrawRotatingSymbol(Me.m_SelectedSymbol, Me.mytoPt)
					Else
						flag3 = (Me.myMapTool = CBanDo.MapTools.DangScale)
						If flag3 Then
							Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
							Me.m_SelectedSymbol.Rotate(Me.m_Map, Me.myrootPt, Me.myfromPt, Me.mytoPt)
							Me.m_SelectedSymbol.Scale(Me.m_Map, Me.myrootPt, Me.myfromPt, Me.mytoPt)
							Me.myfromPt = Me.mytoPt
							Me.DrawRotatingSymbol(Me.m_SelectedSymbol, Me.mytoPt)
						Else
							flag3 = (Me.myMapTool = CBanDo.MapTools.DangSplit)
							If flag3 Then
								Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
								Me.DrawSplittingLine(Me.mytoPt)
							Else
								flag3 = (Me.myMapTool = CBanDo.MapTools.NodesEdit)
								If flag3 Then
									Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
									flag3 = Me.NodeDragging
									If flag3 Then
										Dim arg_4AC_0 As CSymbol = Me.m_SelectedSymbol
										Dim arg_4AC_1 As AxMap = Me.m_Map
										Dim pt As PointF = New PointF(e.x, e.y)
										Dim mFoundNode As CFOUNDNODE = arg_4AC_0.FindNodeAtPoint(arg_4AC_1, pt)
										flag3 = (mFoundNode IsNot Nothing)
										If flag3 Then
											flag2 = (mFoundNode.FoundObject Is Me.FoundNode.FoundObject)
											If flag2 Then
												flag = (mFoundNode.NodeIndex = Me.FoundNode.NodeIndex)
												If Not flag Then
													Dim mPts As PointF() = mFoundNode.FoundObject.GetPoints()
													Dim mPt As PointF = mPts(mFoundNode.NodeIndex)
													Me.FoundNode.FoundObject.MoveNodeTo(Me.FoundNode.NodeIndex, mPt)
													Me.DrawMovingNode(Me.m_SelectedSymbol)
												End If
											Else
												Dim mPts2 As PointF() = mFoundNode.FoundObject.GetPoints()
												Dim mPt2 As PointF = mPts2(mFoundNode.NodeIndex)
												Me.FoundNode.FoundObject.MoveNodeTo(Me.FoundNode.NodeIndex, mPt2)
												Me.DrawMovingNode(Me.m_SelectedSymbol)
											End If
										Else
											Me.m_SelectedSymbol.MoveNodeTo(Me.m_Map, Me.FoundNode, Me.mytoPt)
											Me.DrawMovingNode(Me.m_SelectedSymbol)
										End If
									End If
								Else
									flag3 = (Me.myMapTool = CBanDo.MapTools.ChangeRoot)
									If flag3 Then
										Me.mytoPt = New PointF(CSng(mousePT.X), CSng(mousePT.Y))
										flag3 = Me.RootDragging
										If flag3 Then
											Dim arg_62D_0 As AxMap = Me.m_Map
											Dim num As Single = Me.mytoPt.X
											Dim num2 As Single = Me.mytoPt.Y
											Dim mRootX As Double
											Dim mRootY As Double
											arg_62D_0.ConvertCoord(num, num2, mRootX, mRootY, ConversionConstants.miScreenToMap)
											Me.mytoPt.Y = num2
											Me.mytoPt.X = num
											Me.m_SelectedSymbol.ChangeRoot(Me.m_Map, mRootX, mRootY)
											Me.DrawMovingRoot(Me.m_SelectedSymbol)
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Else
				flag3 = Me.DrawingPicking
				If flag3 Then
					Dim i As Object = Me.myPts.GetUpperBound(0)
					Me.myPts(Conversions.ToInteger(i)).X = CSng(mousePT.X)
					Me.myPts(Conversions.ToInteger(i)).Y = CSng(mousePT.Y)
					Me.DrawDrawingLine(Me.myPts)
					flag3 = (Me.myMapTool = CBanDo.MapTools.Ruler)
					If flag3 Then
						Dim arg_75B_0 As AxMap = Me.m_Map
						Dim arg_71E_0 As PointF() = Me.myPts
						Dim num3 As Integer = Conversions.ToInteger(Operators.SubtractObject(i, 1))
						Dim num2 As Single = arg_71E_0(num3).X
						Dim arg_748_0 As PointF() = Me.myPts
						Dim num4 As Integer = Conversions.ToInteger(Operators.SubtractObject(i, 1))
						Dim num As Single = arg_748_0(num4).Y
						Dim mLon As Double
						Dim mLat As Double
						arg_75B_0.ConvertCoord(num2, num, mLon, mLat, ConversionConstants.miScreenToMap)
						Me.myPts(num4).Y = num
						Me.myPts(num3).X = num2
						Dim arg_7D4_0 As AxMap = Me.m_Map
						Dim arg_7A2_0 As PointF() = Me.myPts
						num4 = Conversions.ToInteger(i)
						num2 = arg_7A2_0(num4).X
						Dim arg_7C1_0 As PointF() = Me.myPts
						num3 = Conversions.ToInteger(i)
						num = arg_7C1_0(num3).Y
						Dim mLon2 As Double
						Dim mLat2 As Double
						arg_7D4_0.ConvertCoord(num2, num, mLon2, mLat2, ConversionConstants.miScreenToMap)
						Me.myPts(num3).Y = num
						Me.myPts(num4).X = num2
						Dim mDist As Integer = CInt(Math.Round(Me.m_Map.Distance(mLon, mLat, mLon2, mLat2)))
						Me.m_ParentForm.ToolStripStatusLabel3.Text = ChrW(272) & "o: " + mDist.ToString("#,###")
					End If
				End If
				flag3 = Me.DrawingDragging
				If flag3 Then
					Me.DrawingRect.Width = mousePT.X - Me.DrawingRect.X
					Me.DrawingRect.Height = mousePT.Y - Me.DrawingRect.Y
					flag3 = (Me.myMapTool = CBanDo.MapTools.Cycle)
					If flag3 Then
						Me.DrawDrawingEllipse(Me.DrawingRect)
					Else
						flag3 = (Me.myMapTool = CBanDo.MapTools.Rectangle)
						If flag3 Then
							Me.DrawDrawingRectangle(Me.DrawingRect)
						Else
							flag3 = (Me.myMapTool = CBanDo.MapTools.arc)
							If flag3 Then
								Me.DrawDrawingArc(Me.DrawingRect)
							End If
						End If
					End If
				End If
			End If
			flag3 = (Me.myMapTool = CBanDo.MapTools.None)
			If flag3 Then
				flag2 = (Me.m_Map.CurrentTool = ToolConstants.miArrowTool)
				If flag2 Then
					Dim arg_93C_0 As CSymbols = Me.m_DrawingSymbols
					Dim arg_93C_1 As AxMap = Me.m_Map
					Dim pt As PointF = New PointF(e.x, e.y)
					Dim mSymbol2 As CSymbol = arg_93C_0.FindSymbolAtPoint(arg_93C_1, pt)
					flag3 = (mSymbol2 IsNot Nothing)
					If flag3 Then
						Me.toolTip1.Active = True
						Me.toolTip1.SetToolTip(Me.m_Map, mSymbol2.Description)
					Else
						Me.toolTip1.Active = False
					End If
				End If
			End If
		End Sub

		Private Sub m_Map_MouseUpEvent(sender As Object, e As CMapXEvents_MouseUpEvent)
			Dim flag As Boolean = Me.bSnap
			If flag Then
				Dim mousePT As System.Drawing.Point = Me.Snap(e.x, e.y)
			Else
				' The following expression was wrapped in a checked-expression
				Dim mousePT As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
			End If
			flag = Not Information.IsNothing(modBanDo.fCacKyHieu)
			Dim flag3 As Boolean
			If flag Then
				Dim flag2 As Boolean = Me.myMapTool = CBanDo.MapTools.DangLayKH
				If flag2 Then
					flag3 = (e.button = 1S)
					If flag3 Then
						Me.PopUndo()
						Dim toolStripStatusLabel As ToolStripStatusLabel = Me.m_ParentForm.ToolStripStatusLabel3
						toolStripStatusLabel.Text = toolStripStatusLabel.Text + ". Shift=" + e.shift.ToString()
						Me.AddFromVeKH()
						Me.NhanKHXong()
					End If
				End If
			End If
			flag3 = (e.button = 1S)
			If flag3 Then
				Dim flag2 As Boolean = Me.m_SelectedSymbols.Count > 0
				If flag2 Then
					flag = (Me.myMapTool = CBanDo.MapTools.GrDangMove)
					If flag Then
						Me.OnCapNhatKH()
						Me.m_SelectedSymbols.Clear()
					End If
				End If
				flag3 = (Me.m_SelectedSymbol IsNot Nothing)
				If flag3 Then
					flag2 = (Me.myMapTool = CBanDo.MapTools.DangMove)
					If flag2 Then
						Me.OnCapNhatKH()
					Else
						flag3 = (Me.myMapTool = CBanDo.MapTools.DangRotate)
						If flag3 Then
							Me.OnCapNhatKH()
						Else
							flag3 = (Me.myMapTool = CBanDo.MapTools.DangScale)
							If flag3 Then
								Me.OnCapNhatKH()
							Else
								flag3 = (Me.myMapTool = CBanDo.MapTools.DangSplit)
								If flag3 Then
									Dim mSPLITSYMBOLS As CBanDo.SPLITSYMBOLS = Me.To2Symbols(Me.m_SelectedSymbol, Me.myfromPt, Me.mytoPt)
									Me.m_DrawingSymbols.Remove(Me.m_SelectedSymbol)
									flag3 = Not Information.IsNothing(mSPLITSYMBOLS.Symbol1)
									If flag3 Then
										Me.m_DrawingSymbols.Add(mSPLITSYMBOLS.Symbol1)
										Me.m_SelectedSymbol = mSPLITSYMBOLS.Symbol1
									End If
									flag3 = Not Information.IsNothing(mSPLITSYMBOLS.Symbol2)
									If flag3 Then
										Me.m_DrawingSymbols.Add(mSPLITSYMBOLS.Symbol2)
										Me.m_SelectedSymbol = mSPLITSYMBOLS.Symbol2
									End If
									Me.OnCapNhatKH()
								End If
							End If
						End If
					End If
				End If
				flag3 = Me.selectionDragging
				If flag3 Then
					Me.selectionDragging = False
					flag3 = (Me.m_SelectedSymbol IsNot Nothing)
					If flag3 Then
						Me.m_SelectedSymbols.Add(Me.m_SelectedSymbol)
						Me.m_SelectedSymbol = Nothing
						Try
							Dim enumerator As IEnumerator = Me.drawingSymbols.GetEnumerator()
							While enumerator.MoveNext()
								Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
								flag3 = mSymbol.HitTest(Me.m_Map, Me.selectionRect)
								If flag3 Then
									flag2 = (mSymbol IsNot Me.m_SelectedSymbols(0))
									If flag2 Then
										Me.m_SelectedSymbols.Add(mSymbol)
									End If
								End If
							End While
						Finally
							Dim enumerator As IEnumerator
							flag3 = (TypeOf enumerator Is IDisposable)
							If flag3 Then
								(TryCast(enumerator, IDisposable)).Dispose()
							End If
						End Try
					Else
						Try
							Dim enumerator2 As IEnumerator = Me.drawingSymbols.GetEnumerator()
							While enumerator2.MoveNext()
								Dim mSymbol2 As CSymbol = CType(enumerator2.Current, CSymbol)
								flag3 = mSymbol2.HitTest(Me.m_Map, Me.selectionRect)
								If flag3 Then
									Me.m_SelectedSymbols.Add(mSymbol2)
								End If
							End While
						Finally
							Dim enumerator2 As IEnumerator
							flag3 = (TypeOf enumerator2 Is IDisposable)
							If flag3 Then
								(TryCast(enumerator2, IDisposable)).Dispose()
							End If
						End Try
					End If
					Me.m_Map.CenterX = Me.m_Map.CenterX
					flag3 = (Me.m_SelectedSymbols.Count > 1)
					If flag3 Then
					End If
				End If
				flag3 = Me.DrawingDragging
				If flag3 Then
					Me.DrawingDragging = False
					Me.m_Map.CenterX = Me.m_Map.CenterX
				End If
				flag3 = Me.NodeDragging
				If flag3 Then
					Me.NodeDragging = False
					Me.m_Map.CenterX = Me.m_Map.CenterX
				End If
				flag3 = Me.RootDragging
				If flag3 Then
					Me.RootDragging = False
					Me.m_Map.CenterX = Me.m_Map.CenterX
				End If
				Select Case Me.myMapTool
					Case CBanDo.MapTools.Cycle, CBanDo.MapTools.Rectangle, CBanDo.MapTools.arc
						Me.DrawingPicking = False
						Me.AddNewObj(e.shift)
						Me.OnCapNhatKH()
				End Select
			End If
		End Sub

		Public Sub OnUndoClick()
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Try
				Dim mUndoItem As modBanDo.UNDOITEM = Me.PushUndo()
				Dim flag As Boolean = Not Information.IsNothing(mUndoItem)
				If flag Then
					Me.m_DrawingSymbols = mUndoItem.UndoSymbols
					Me.m_Map.CenterX = mUndoItem.MapX
					Me.m_Map.CenterY = mUndoItem.MapY
					Me.m_SelectedSymbol = mUndoItem.SeleSymbol
				End If
			Catch arg_6F_0 As Exception
				ProjectData.SetProjectError(arg_6F_0)
				ProjectData.ClearProjectError()
			End Try
			Me.OnCapNhatKH()
		End Sub

		Public Sub OnRedoClick()
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Try
				Dim mRedoItem As modBanDo.UNDOITEM = Me.PushRedo()
				Dim flag As Boolean = Not Information.IsNothing(mRedoItem)
				If flag Then
					Me.m_DrawingSymbols = mRedoItem.UndoSymbols
					Me.m_Map.CenterX = mRedoItem.MapX
					Me.m_Map.CenterY = mRedoItem.MapY
					Me.m_SelectedSymbol = mRedoItem.SeleSymbol
				End If
			Catch arg_6F_0 As Exception
				ProjectData.SetProjectError(arg_6F_0)
				ProjectData.ClearProjectError()
			End Try
			Me.OnCapNhatKH()
		End Sub

		Private Sub MnuCopyKH_Click(sender As Object, e As EventArgs)
			Me.m_CopySymbol = Me.m_SelectedSymbol
			Me.m_CopySymbols.Clear()
			Me.m_CopySymbols.Add(Me.m_CopySymbol)
		End Sub

		Private Sub MnuEditNodes_Click(sender As Object, e As EventArgs)
			Me.OnNodesEdit()
		End Sub

		Private Sub MnuRotate_Click(sender As Object, e As EventArgs)
			Me.myMapTool = CBanDo.MapTools.Rotate
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Rotate: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " quay."
		End Sub

		Private Sub MnuChangeRoot_Click(sender As Object, e As EventArgs)
			Me.OnChangeRoot()
		End Sub

		Private Sub MnuChangeDesc_Click(sender As Object, e As EventArgs)
			Me.OnChangeDesc(RuntimeHelpers.GetObjectValue(sender), e)
		End Sub

		Private Sub MnuDeleteKH_Click(sender As Object, e As EventArgs)
			Me.OnXoa()
		End Sub

		Private Sub MnuChangeColor_Click(sender As Object, e As EventArgs)
			Select Case Me.m_SelectedObject.GetObjType()
				Case OBJECTTYPE.Polygon, OBJECTTYPE.Line, OBJECTTYPE.Curve, OBJECTTYPE.ClosedCurve, OBJECTTYPE.Cycle, OBJECTTYPE.Ellipse
					Me.OnChangeColor()
				Case OBJECTTYPE.Pie
					Me.OnChangePie()
				Case OBJECTTYPE.Text
					Me.OnChangeText()
				Case OBJECTTYPE.Table
					Me.OnChangeTable()
			End Select
		End Sub

		Private Sub MnuDeleteShape_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.OnDeleteShape()
		End Sub

		Private Sub MnXoaNode_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.OnXoaNode()
		End Sub

		Private Sub MnuAddNode_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.OnAddNode()
		End Sub

		Private Sub MnuChangeNodeType_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.OnChangeNodeType()
		End Sub

		Private Sub MnuSendBack_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.m_DrawingSymbols.SendBack(Me.m_SelectedSymbol)
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub MnuPastKH_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.m_CopySymbols.Count > 0
				If flag Then
					Me.PopUndo()
					Dim mSymbol As CSymbol = Me.m_CopySymbols(0)
					Dim arg_57_0 As AxMap = Me.m_Map
					Dim cSymbol As CSymbol = mSymbol
					Dim num As Double = cSymbol.GocX
					Dim cSymbol2 As CSymbol = mSymbol
					Dim num2 As Double = cSymbol2.GocY
					Dim mPt0X As Single
					Dim mPt0Y As Single
					arg_57_0.ConvertCoord(mPt0X, mPt0Y, num, num2, ConversionConstants.miMapToScreen)
					cSymbol2.GocY = num2
					cSymbol.GocX = num
					Dim arg_94_1 As CSymbol = mSymbol
					Dim pt As PointF = New PointF(Me.mousePos.X, Me.mousePos.Y)
					Dim mSymbol2 As CSymbol = Me.PastSymbolAt(arg_94_1, pt)
					flag = (Me.m_CopySymbols.Count > 1)
					If flag Then
						Dim arg_C2_0 As Integer = 1
						Dim num3 As Integer = Me.m_CopySymbols.Count - 1
						Dim i As Integer = arg_C2_0
						While True
							Dim arg_158_0 As Integer = i
							Dim num4 As Integer = num3
							If arg_158_0 > num4 Then
								Exit While
							End If
							mSymbol = Me.m_CopySymbols(i)
							Dim arg_FF_0 As AxMap = Me.m_Map
							cSymbol2 = mSymbol
							num2 = cSymbol2.GocX
							cSymbol = mSymbol
							num = cSymbol.GocY
							Dim mPtX As Single
							Dim mPtY As Single
							arg_FF_0.ConvertCoord(mPtX, mPtY, num2, num, ConversionConstants.miMapToScreen)
							cSymbol.GocY = num
							cSymbol2.GocX = num2
							Dim arg_145_1 As CSymbol = mSymbol
							' The following expression was wrapped in a unchecked-expression
							pt = New PointF(Me.mousePos.X - mPt0X + mPtX, Me.mousePos.Y - mPt0Y + mPtY)
							mSymbol2 = Me.PastSymbolAt(arg_145_1, pt)
							i += 1
						End While
					End If
					Me.m_ParentForm.PopulateListKH(mSymbol2)
				End If
				Me.m_Map.CenterX = Me.m_Map.CenterX
			Catch arg_186_0 As Exception
				ProjectData.SetProjectError(arg_186_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub m_Map_ToolUsed(sender As Object, e As CMapXEvents_ToolUsedEvent)
			Dim flag As Boolean = e.toolNum = 3S
			If flag Then
				Me.procThongTin(e.x1, e.y1)
			End If
		End Sub

		Public Sub procThongTin(x1 As Double, y1 As Double)
			Dim p As MapXLib.Point = New PointClass()
			p.[Set](x1, y1)
			Dim mBD_ID As Long = 0L
			Dim arg_29_0 As Integer = 2
			Dim count As Integer = Me.m_Map.Layers.Count
			Dim i As Integer = arg_29_0
			Dim flag As Boolean
			Dim f As Feature
			While True
				Dim arg_CE_0 As Integer = i
				Dim num As Integer = count
				If arg_CE_0 > num Then
					Exit While
				End If
				Dim lyr As Layer = Me.m_Map.Layers(i)
				Try
					flag = (mBD_ID = 0L)
					If flag Then
						Dim fs As Features = lyr.SearchAtPoint(p, Missing.Value)
						flag = (fs.Count > 0)
						If flag Then
							f = fs(1)
							lyr.Selection.SelectByID(f.FeatureID, SelectionTypeConstants.miSelectionNew)
							mBD_ID = CLng(f.FeatureID)
						End If
					Else
						lyr.Selection.ClearSelection()
					End If
				Catch expr_B1 As Exception
					ProjectData.SetProjectError(expr_B1)
					ProjectData.ClearProjectError()
				End Try
				' The following expression was wrapped in a checked-statement
				i += 1
			End While
			flag = (mBD_ID > 0L)
			If flag Then
				Me.ThongTinKhac(f)
			End If
		End Sub

		Private Sub ThongTinKhac(pf As Feature)
			Dim lyr As Layer = pf.Layer
			Dim strOutput As String = ""
			Dim arg_22_0 As Integer = 1
			Dim count As Integer = Me.m_Map.DataSets.Count
			Dim i As Integer = arg_22_0
			' The following expression was wrapped in a checked-statement
			Dim ds As Dataset
			While True
				Dim arg_6B_0 As Integer = i
				Dim num As Integer = count
				If arg_6B_0 > num Then
					Exit While
				End If
				ds = Me.m_Map.DataSets(i)
				Dim flag As Boolean = Operators.CompareString(ds.Layer.Name, lyr.Name, False) = 0
				If flag Then
					Exit While
				End If
				i += 1
			End While
			Dim rvs As RowValues = ds.get_RowValues(pf)
			Dim arg_80_0 As Integer = 1
			Dim count2 As Integer = rvs.Count
			i = arg_80_0
			While True
				Dim arg_FC_0 As Integer = i
				Dim num As Integer = count2
				If arg_FC_0 > num Then
					Exit While
				End If
				Dim rv As RowValue = rvs(i)
				Dim mField As Field = CType(rv.Field, Field)
				strOutput = String.Concat(New String() { strOutput, myModule.toUnicode(mField.Name), ": ", myModule.toUnicode(RuntimeHelpers.GetObjectValue(rv.Value)), vbCrLf })
				i += 1
			End While
			strOutput = Strings.Left(strOutput, Strings.Len(strOutput) - 2)
			MessageBox.Show(Me.m_ParentForm, strOutput, "L" & ChrW(7899) & "p: " + lyr.Name)
			lyr.Selection.ClearSelection()
		End Sub

		Public Function PastSymbolAt(pSymbol As CSymbol, pt1 As PointF) As CSymbol
			Dim mSymbolObj As CSymbol = Nothing
			Dim flag As Boolean = pSymbol IsNot Nothing
			If flag Then
				mSymbolObj = New CSymbol(Me.m_Map, pt1, pSymbol.GObjs, pSymbol.Zoom, pSymbol.MWidth)
				mSymbolObj.Description = pSymbol.Description
				Me.m_DrawingSymbols.Add(mSymbolObj)
			End If
			Return mSymbolObj
		End Function

		Public Sub PastSymbol(pSymbol As CSymbol)
			Dim flag As Boolean = pSymbol IsNot Nothing
			If flag Then
				Dim mSymbolObj As CSymbol = New CSymbol(pSymbol.Description, pSymbol.Blinking, pSymbol.Zoom, pSymbol.MWidth, pSymbol.GocX, pSymbol.GocY, pSymbol.GObjs)
				mSymbolObj.Description = pSymbol.Description
				Me.m_DrawingSymbols.Add(mSymbolObj)
			End If
		End Sub

		Private Function Snap(px As Single, py As Single) As System.Drawing.Point
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim result As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(Math.Round(CDec((px / CSng(Me.myGridWidth))), 0) * CDec(Me.myGridWidth))), CInt(Math.Round(Math.Round(CDec((py / CSng(Me.myGridWidth))), 0) * CDec(Me.myGridWidth))))
			Return result
		End Function

		Public Sub OnCapNhatKH()
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.myMapTool = CBanDo.MapTools.ChonKH
			Me.UpdateTB("UpdateKH")
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.m_ParentForm.PopulateListKH(Me.m_SelectedSymbol)
		End Sub

		Private Sub m_Map_KeyUpEvent(sender As Object, e As CMapXEvents_KeyUpEvent)
			Dim keyCode As Short = e.keyCode
			Dim flag As Boolean = keyCode = 83S
			If flag Then
				Me.bSnap = Not Me.bSnap
				flag = Me.bSnap
				If flag Then
					myModule.fMain.ToolStripStatusLabel5.Text = "SNAP"
				Else
					myModule.fMain.ToolStripStatusLabel5.Text = ""
				End If
			Else
				flag = (keyCode = 71S)
				If flag Then
					Me.bGrid = Not Me.bGrid
					Me.m_Map.CenterX = Me.m_Map.CenterX
				Else
					flag = (keyCode = 46S)
					If flag Then
						Me.OnXoa()
					Else
						flag = (keyCode = 38S)
						If flag Then
							Dim flag2 As Boolean = Me.m_SelectedSymbol IsNot Nothing
							If flag2 Then
								Select Case e.shift
									Case 2S
										Me.m_SelectedSymbol.Shift(Me.m_Map, 0F, -1F)
										Me.m_Map.CenterX = Me.m_Map.CenterX
									Case 6S
										Me.myrootPt = Nothing
										Dim arg_196_0 As AxMap = Me.m_Map
										Dim num As Single = Me.myrootPt.X
										Dim num2 As Single = Me.myrootPt.Y
										Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
										Dim num3 As Double = selectedSymbol.GocX
										Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
										Dim num4 As Double = selectedSymbol2.GocY
										arg_196_0.ConvertCoord(num, num2, num3, num4, ConversionConstants.miMapToScreen)
										selectedSymbol2.GocY = num4
										selectedSymbol.GocX = num3
										Me.myrootPt.Y = num2
										Me.myrootPt.X = num
										Me.m_SelectedSymbol.Scale2(Me.m_Map, Me.myrootPt, 0F, 1F)
										Me.m_Map.CenterX = Me.m_Map.CenterX
								End Select
							End If
						Else
							Dim flag2 As Boolean = keyCode = 40S
							If flag2 Then
								flag = (Me.m_SelectedSymbol IsNot Nothing)
								If flag Then
									Select Case e.shift
										Case 2S
											Me.m_SelectedSymbol.Shift(Me.m_Map, 0F, 1F)
											Me.m_Map.CenterX = Me.m_Map.CenterX
										Case 6S
											Me.myrootPt = Nothing
											Dim arg_2EE_0 As AxMap = Me.m_Map
											Dim num2 As Single = Me.myrootPt.X
											Dim num As Single = Me.myrootPt.Y
											Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
											Dim num4 As Double = selectedSymbol2.GocX
											Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
											Dim num3 As Double = selectedSymbol.GocY
											arg_2EE_0.ConvertCoord(num2, num, num4, num3, ConversionConstants.miMapToScreen)
											selectedSymbol.GocY = num3
											selectedSymbol2.GocX = num4
											Me.myrootPt.Y = num
											Me.myrootPt.X = num2
											Me.m_SelectedSymbol.Scale2(Me.m_Map, Me.myrootPt, 0F, -1F)
											Me.m_Map.CenterX = Me.m_Map.CenterX
									End Select
								End If
							Else
								flag2 = (keyCode = 39S)
								If flag2 Then
									flag = (Me.m_SelectedSymbol IsNot Nothing)
									If flag Then
										Select Case e.shift
											Case 2S
												Me.m_SelectedSymbol.Shift(Me.m_Map, 1F, 0F)
												Me.m_Map.CenterX = Me.m_Map.CenterX
											Case 4S
												Me.myrootPt = Nothing
												Dim arg_440_0 As AxMap = Me.m_Map
												Dim num2 As Single = Me.myrootPt.X
												Dim num As Single = Me.myrootPt.Y
												Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
												Dim num4 As Double = selectedSymbol2.GocX
												Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
												Dim num3 As Double = selectedSymbol.GocY
												arg_440_0.ConvertCoord(num2, num, num4, num3, ConversionConstants.miMapToScreen)
												selectedSymbol.GocY = num3
												selectedSymbol2.GocX = num4
												Me.myrootPt.Y = num
												Me.myrootPt.X = num2
												Me.m_SelectedSymbol.Rotate2(Me.m_Map, Me.myrootPt, modBanDo.myTinhChinhGocQuay)
												Me.m_Map.CenterX = Me.m_Map.CenterX
											Case 6S
												Me.myrootPt = Nothing
												Dim arg_503_0 As AxMap = Me.m_Map
												Dim num2 As Single = Me.myrootPt.X
												Dim num As Single = Me.myrootPt.Y
												Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
												Dim num4 As Double = selectedSymbol2.GocX
												Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
												Dim num3 As Double = selectedSymbol.GocY
												arg_503_0.ConvertCoord(num2, num, num4, num3, ConversionConstants.miMapToScreen)
												selectedSymbol.GocY = num3
												selectedSymbol2.GocX = num4
												Me.myrootPt.Y = num
												Me.myrootPt.X = num2
												Me.m_SelectedSymbol.Scale2(Me.m_Map, Me.myrootPt, 1F, 0F)
												Me.m_Map.CenterX = Me.m_Map.CenterX
										End Select
									End If
								Else
									flag2 = (keyCode = 37S)
									If flag2 Then
										flag = (Me.m_SelectedSymbol IsNot Nothing)
										If flag Then
											Select Case e.shift
												Case 2S
													Me.m_SelectedSymbol.Shift(Me.m_Map, -1F, 0F)
													Me.m_Map.CenterX = Me.m_Map.CenterX
												Case 4S
													Me.myrootPt = Nothing
													Dim arg_655_0 As AxMap = Me.m_Map
													Dim num2 As Single = Me.myrootPt.X
													Dim num As Single = Me.myrootPt.Y
													Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
													Dim num4 As Double = selectedSymbol2.GocX
													Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
													Dim num3 As Double = selectedSymbol.GocY
													arg_655_0.ConvertCoord(num2, num, num4, num3, ConversionConstants.miMapToScreen)
													selectedSymbol.GocY = num3
													selectedSymbol2.GocX = num4
													Me.myrootPt.Y = num
													Me.myrootPt.X = num2
													Me.m_SelectedSymbol.Rotate2(Me.m_Map, Me.myrootPt, -modBanDo.myTinhChinhGocQuay)
													Me.m_Map.CenterX = Me.m_Map.CenterX
												Case 6S
													Me.myrootPt = Nothing
													Dim arg_719_0 As AxMap = Me.m_Map
													Dim num2 As Single = Me.myrootPt.X
													Dim num As Single = Me.myrootPt.Y
													Dim selectedSymbol2 As CSymbol = Me.m_SelectedSymbol
													Dim num4 As Double = selectedSymbol2.GocX
													Dim selectedSymbol As CSymbol = Me.m_SelectedSymbol
													Dim num3 As Double = selectedSymbol.GocY
													arg_719_0.ConvertCoord(num2, num, num4, num3, ConversionConstants.miMapToScreen)
													selectedSymbol.GocY = num3
													selectedSymbol2.GocX = num4
													Me.myrootPt.Y = num
													Me.myrootPt.X = num2
													Me.m_SelectedSymbol.Scale2(Me.m_Map, Me.myrootPt, -1F, 0F)
													Me.m_Map.CenterX = Me.m_Map.CenterX
											End Select
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		Private Sub MnuCacLopBD_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_Map.Layers.LayersDlg(Missing.Value, Missing.Value)
			If flag Then
				Me.AddDataSets()
			End If
		End Sub

		Public Sub CacLopBD()
			Dim flag As Boolean = Me.m_Map.Layers.LayersDlg(Missing.Value, Missing.Value)
			If flag Then
				Me.AddDataSets()
			End If
		End Sub

		Private Sub MnuLuuGeoSet_Click(sender As Object, e As EventArgs)
			Me.LuuGeoSet()
		End Sub

		Public Sub UnseleKH()
			Me.m_SelectedSymbol = Nothing
			Me.m_SelectedSymbols.Clear()
			Me.myMapTool = CBanDo.MapTools.None
			Me.UpdateTB("None")
			Me.m_ParentForm.ToolStripStatusLabel3.Text = ""
		End Sub

		Public Sub ResetToolbar()
			Me.myMapTool = CBanDo.MapTools.None
			Me.UpdateTB("None")
			Me.m_ParentForm.ToolStripStatusLabel3.Text = ""
		End Sub

		Private Function gscTogoc(gsPT As System.Drawing.Point) As MAPPOINT
			Dim myNewPoint As MAPPOINT = Nothing
			Dim arg_2C_0 As AxMap = Me.m_Map
			Dim num As Single = CSng(gsPT.X)
			Dim num2 As Single = CSng(gsPT.Y)
			Dim mLon As Double
			Dim mLat As Double
			arg_2C_0.ConvertCoord(num, num2, mLon, mLat, ConversionConstants.miScreenToMap)
			' The following expression was wrapped in a checked-statement
			gsPT.Y = CInt(Math.Round(CDec(num2)))
			gsPT.X = CInt(Math.Round(CDec(num)))
			myNewPoint.X = mLon
			myNewPoint.Y = mLat
			Return myNewPoint
		End Function

		Private Function gscTogoc(X As Integer, Y As Integer) As MAPPOINT
			Dim myNewPoint As MAPPOINT = Nothing
			Dim arg_20_0 As AxMap = Me.m_Map
			Dim num As Single = CSng(X)
			Dim num2 As Single = CSng(Y)
			Dim mLon As Double
			Dim mLat As Double
			arg_20_0.ConvertCoord(num, num2, mLon, mLat, ConversionConstants.miScreenToMap)
			' The following expression was wrapped in a checked-statement
			Y = CInt(Math.Round(CDec(num2)))
			X = CInt(Math.Round(CDec(num)))
			myNewPoint.X = mLon
			myNewPoint.Y = mLat
			Return myNewPoint
		End Function

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

		Private Sub AddFromVeKH0(pGObjs0 As CGraphicObjs, pCX As Integer, pCY As Integer, pTyLe As Single, pPt As PointF)
			Dim mSymbolObj As CSymbol = Me.m_KHfromVeKH
			Me.m_DrawingSymbols.Add(mSymbolObj)
			modBanDo.myDaLayKH = True
			Me.m_CopySymbol = mSymbolObj
			Me.m_CopySymbols.Clear()
			Me.m_CopySymbols.Add(Me.m_CopySymbol)
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.m_SelectedSymbol = mSymbolObj
		End Sub

		Private Sub AddFromVeKH()
			Dim mSymbolObj As CSymbol = Me.m_KHfromVeKH
			Me.m_DrawingSymbols.Add(mSymbolObj)
			modBanDo.myDaLayKH = True
			Me.m_CopySymbol = mSymbolObj
			Me.m_CopySymbols.Clear()
			Me.m_CopySymbols.Add(Me.m_CopySymbol)
			Me.m_Map.CenterX = Me.m_Map.CenterX
			Me.m_SelectedSymbol = mSymbolObj
		End Sub

		Private Sub DoiMau(pGObjs As CGraphicObjs, pMau As Color)
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Select Case aGObj.GetObjType()
						Case OBJECTTYPE.Ellipse, OBJECTTYPE.Pie
							Dim mShape As ShapeGraphic = CType(aGObj, ShapeGraphic)
							Dim shapeGraphic As ShapeGraphic = mShape
							shapeGraphic.LineColor = pMau
							shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), pMau)
						Case OBJECTTYPE.Text
							Dim mShape2 As TextGraphic = CType(aGObj, TextGraphic)
							Dim textGraphic As TextGraphic = mShape2
							textGraphic.Color = pMau
						Case OBJECTTYPE.Table
						Case OBJECTTYPE.EmbeddedImage
						Case Else
							Try
								Dim mShape3 As NodesShapeGraphic = CType(aGObj, NodesShapeGraphic)
								Dim nodesShapeGraphic As NodesShapeGraphic = mShape3
								nodesShapeGraphic.LineColor = pMau
								nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), pMau)
							Catch expr_DC As Exception
								ProjectData.SetProjectError(expr_DC)
								ProjectData.ClearProjectError()
							End Try
					End Select
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub TraoMau(pGObjs As CGraphicObjs)
			Try
				Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Select Case aGObj.GetObjType()
						Case OBJECTTYPE.Ellipse, OBJECTTYPE.Pie
							Dim mShape As ShapeGraphic = CType(aGObj, ShapeGraphic)
							Dim shapeGraphic As ShapeGraphic = mShape
							Dim flag As Boolean = shapeGraphic.LineColor = modBanDo.QuanDoColor
							If flag Then
								shapeGraphic.LineColor = modBanDo.QuanXanhColor
							Else
								flag = (shapeGraphic.LineColor = modBanDo.QuanXanhColor)
								If flag Then
									shapeGraphic.LineColor = modBanDo.QuanDoColor
								End If
							End If
							flag = (shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), modBanDo.QuanDoColor))
							If flag Then
								shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), modBanDo.QuanXanhColor)
							Else
								flag = (shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), modBanDo.QuanXanhColor))
								If flag Then
									shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), modBanDo.QuanDoColor)
								End If
							End If
						Case OBJECTTYPE.Text
							Dim mShape2 As TextGraphic = CType(aGObj, TextGraphic)
							Dim textGraphic As TextGraphic = mShape2
							Dim flag As Boolean = textGraphic.Color = modBanDo.QuanDoColor
							If flag Then
								textGraphic.Color = modBanDo.QuanXanhColor
							Else
								flag = (textGraphic.Color = modBanDo.QuanXanhColor)
								If flag Then
									textGraphic.Color = modBanDo.QuanDoColor
								End If
							End If
						Case OBJECTTYPE.Table
						Case OBJECTTYPE.EmbeddedImage
						Case Else
							Try
								Dim mShape3 As NodesShapeGraphic = CType(aGObj, NodesShapeGraphic)
								Dim nodesShapeGraphic As NodesShapeGraphic = mShape3
								Dim flag As Boolean = nodesShapeGraphic.LineColor = modBanDo.QuanDoColor
								If flag Then
									nodesShapeGraphic.LineColor = modBanDo.QuanXanhColor
								Else
									flag = (nodesShapeGraphic.LineColor = modBanDo.QuanXanhColor)
									If flag Then
										nodesShapeGraphic.LineColor = modBanDo.QuanDoColor
									End If
								End If
								flag = (nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), modBanDo.QuanDoColor))
								If flag Then
									nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), modBanDo.QuanXanhColor)
								Else
									flag = (nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), modBanDo.QuanXanhColor))
									If flag Then
										nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), modBanDo.QuanDoColor)
									End If
								End If
							Catch expr_2AA As Exception
								ProjectData.SetProjectError(expr_2AA)
								ProjectData.ClearProjectError()
							End Try
					End Select
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Function GetKHfromVeKH0(pGObjs0 As CGraphicObjs, pCX As Integer, pCY As Integer, pTyLe As Single, pPt As PointF) As CSymbol
			Dim pGObjs As CGraphicObjs = Me.GetTyLeGObjs(pGObjs0, pTyLe)
			Dim flag As Boolean = (Control.ModifierKeys And Keys.Alt) = Keys.Alt
			If flag Then
				Me.DoiMau(pGObjs, modBanDo.QuanXanhColor)
			End If
			Dim mSymbolObj As CSymbol = New CSymbol(Me.m_Map, pPt, pGObjs, Me.m_Map.Zoom, Me.m_Map.MapScreenWidth)
			mSymbolObj.Description = modBanDo.fCacKyHieu.txtTenKH.Text
			Dim mRec As System.Drawing.Rectangle = mSymbolObj.GetBounds(Me.m_Map)
			Dim fromPt As PointF = New PointF(pPt.X, pPt.Y)
			Dim toPt As PointF = New PointF(pPt.X - CSng(pCX) * pTyLe, pPt.Y - CSng(pCY) * pTyLe)
			toPt.X = pPt.X + CSng(pCX) * pTyLe
			toPt.Y = pPt.Y + CSng(pCY) * pTyLe
			Dim arg_102_0 As AxMap = Me.m_Map
			Dim x As Single = toPt.X
			Dim y As Single = toPt.Y
			Dim mRootX As Double
			Dim mRootY As Double
			arg_102_0.ConvertCoord(x, y, mRootX, mRootY, ConversionConstants.miScreenToMap)
			toPt.Y = y
			toPt.X = x
			mSymbolObj.ChangeRoot(Me.m_Map, mRootX, mRootY)
			fromPt.X = toPt.X
			fromPt.Y = toPt.Y
			toPt.X = pPt.X
			toPt.Y = pPt.Y
			mSymbolObj.Move(Me.m_Map, fromPt, toPt)
			flag = (Me.m_DrawingSymbols.Count > 0)
			If flag Then
				mSymbolObj.Zoom = Me.m_DrawingSymbols(0).Zoom
				mSymbolObj.MWidth = Me.m_DrawingSymbols(0).MWidth
			Else
				mSymbolObj.Zoom = CDec(modBanDo.myKHQSZoom)
				mSymbolObj.MWidth = CSng(modBanDo.myKHQSMWidth)
			End If
			Return mSymbolObj
		End Function

		Private Function GetKHfromVeKH(pPt As PointF) As CSymbol
			Dim mTyLe As Single = 1F
			Try
				mTyLe = Conversions.ToSingle(modBanDo.fCacKyHieu.txtTyLe.Text)
			Catch expr_21 As Exception
				ProjectData.SetProjectError(expr_21)
				ProjectData.ClearProjectError()
			End Try
			Dim pGObjs As CGraphicObjs = Me.GetTyLeGObjs(modBanDo.fCacKyHieu.OdrawingObjects, mTyLe)
			Dim flag As Boolean = (Control.ModifierKeys And Keys.Alt) = Keys.Alt
			If flag Then
				Me.DoiMau(pGObjs, modBanDo.QuanXanhColor)
			End If
			Dim mSymbolObj As CSymbol = New CSymbol(Me.m_Map, pPt, pGObjs, Me.m_Map.Zoom, Me.m_Map.MapScreenWidth)
			mSymbolObj.Description = modBanDo.fCacKyHieu.txtTenKH.Text
			Dim mRec As System.Drawing.Rectangle = mSymbolObj.GetBounds(Me.m_Map)
			Dim fromPt As PointF = New PointF(pPt.X, pPt.Y)
			Dim toPt As PointF = New PointF(pPt.X - CSng(modBanDo.fCacKyHieu.myORootX) * mTyLe, pPt.Y - CSng(modBanDo.fCacKyHieu.myORootY) * mTyLe)
			toPt.X = pPt.X + CSng(modBanDo.fCacKyHieu.myORootX) * mTyLe
			toPt.Y = pPt.Y + CSng(modBanDo.fCacKyHieu.myORootY) * mTyLe
			Dim arg_15F_0 As AxMap = Me.m_Map
			Dim x As Single = toPt.X
			Dim y As Single = toPt.Y
			Dim mRootX As Double
			Dim mRootY As Double
			arg_15F_0.ConvertCoord(x, y, mRootX, mRootY, ConversionConstants.miScreenToMap)
			toPt.Y = y
			toPt.X = x
			mSymbolObj.ChangeRoot(Me.m_Map, mRootX, mRootY)
			fromPt.X = toPt.X
			fromPt.Y = toPt.Y
			toPt.X = pPt.X
			toPt.Y = pPt.Y
			mSymbolObj.Move(Me.m_Map, fromPt, toPt)
			flag = (Me.m_DrawingSymbols.Count > 0)
			If flag Then
				mSymbolObj.Zoom = Me.m_DrawingSymbols(0).Zoom
				mSymbolObj.MWidth = Me.m_DrawingSymbols(0).MWidth
			Else
				mSymbolObj.Zoom = CDec(modBanDo.myKHQSZoom)
				mSymbolObj.MWidth = CSng(modBanDo.myKHQSMWidth)
			End If
			Return mSymbolObj
		End Function

		Public Sub ChuanBiNhanKH()
			Me.myMapCurrTool = Me.m_Map.CurrentTool
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Click vào b" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " KH."
			Me.m_KHfromVeKH = Nothing
			Me.myMapTool = CBanDo.MapTools.DangLayKH
		End Sub

		Public Sub NhanKHXong()
			Me.m_Map.MousePointer = CursorConstants.miDefaultCursor
			Me.m_ParentForm.ToolStripStatusLabel3.Text = ""
			Try
				Me.m_Map.CurrentTool = CType(Conversions.ToInteger(Me.myMapCurrTool), ToolConstants)
			Catch expr_3E As Exception
				ProjectData.SetProjectError(expr_3E)
				Me.m_Map.CurrentTool = ToolConstants.miArrowTool
				ProjectData.ClearProjectError()
			End Try
			Me.m_KHfromVeKH = Nothing
			Me.OnCapNhatKH()
		End Sub

		Private Sub AddNewObj(pShift As Short)
			Dim mPt0 As PointF = Nothing
			Dim flag As Boolean
			Dim gObjs As GraphicObject()
			Select Case Me.myMapTool
				Case CBanDo.MapTools.Polygon
					Dim myPts2 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts2.GetUpperBound(0) > 1)
					If flag Then
						Dim gp As GraphicsPath = New GraphicsPath()
						gp.AddPolygon(myPts2)
						Dim rf As RectangleF = gp.GetBounds()
						mPt0.X = (rf.Left + rf.Right) / 2F
						mPt0.Y = (rf.Top + rf.Bottom) / 2F
						Dim arg_3E5_0 As Integer = 0
						Dim upperBound As Integer = myPts2.GetUpperBound(0)
						Dim i As Integer = arg_3E5_0
						While True
							Dim arg_444_0 As Integer = i
							Dim num As Integer = upperBound
							If arg_444_0 > num Then
								Exit While
							End If
							Dim arg_3EF_0 As PointF() = myPts2
							Dim num2 As Integer = i
							arg_3EF_0(num2).X = myPts2(num2).X - mPt0.X
							Dim arg_417_0 As PointF() = myPts2
							num2 = i
							arg_417_0(num2).Y = myPts2(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = New GraphicObject() { New PolygonGraphic(myPts2, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .Fill = modBanDo.defaGenFill, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle } }
					End If
				Case CBanDo.MapTools.Line
					Dim myPts3 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts3.GetUpperBound(0) > 0)
					If flag Then
						Dim gp2 As GraphicsPath = New GraphicsPath()
						gp2.AddLines(myPts3)
						Dim rf2 As RectangleF = gp2.GetBounds()
						mPt0.X = (rf2.Left + rf2.Right) / 2F
						mPt0.Y = (rf2.Top + rf2.Bottom) / 2F
						Dim arg_558_0 As Integer = 0
						Dim upperBound2 As Integer = myPts3.GetUpperBound(0)
						Dim i As Integer = arg_558_0
						While True
							Dim arg_5B7_0 As Integer = i
							Dim num As Integer = upperBound2
							If arg_5B7_0 > num Then
								Exit While
							End If
							Dim arg_562_0 As PointF() = myPts3
							Dim num2 As Integer = i
							arg_562_0(num2).X = myPts3(num2).X - mPt0.X
							Dim arg_58A_0 As PointF() = myPts3
							num2 = i
							arg_58A_0(num2).Y = myPts3(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = New GraphicObject() { New LinesGraphic(myPts3, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle } }
					End If
				Case CBanDo.MapTools.Curve
					Dim myPts4 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts4.GetUpperBound(0) > 0)
					If flag Then
						Dim gp3 As GraphicsPath = New GraphicsPath()
						gp3.AddCurve(myPts4)
						Dim rf3 As RectangleF = gp3.GetBounds()
						mPt0.X = (rf3.Left + rf3.Right) / 2F
						mPt0.Y = (rf3.Top + rf3.Bottom) / 2F
						Dim arg_DE_0 As Integer = 0
						Dim upperBound3 As Integer = myPts4.GetUpperBound(0)
						Dim i As Integer = arg_DE_0
						While True
							Dim arg_139_0 As Integer = i
							Dim num As Integer = upperBound3
							If arg_139_0 > num Then
								Exit While
							End If
							Dim arg_E7_0 As PointF() = myPts4
							Dim num2 As Integer = i
							arg_E7_0(num2).X = myPts4(num2).X - mPt0.X
							Dim arg_10D_0 As PointF() = myPts4
							num2 = i
							arg_10D_0(num2).Y = myPts4(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						flag = (modBanDo.defaMyLineStyle = 0)
						If flag Then
							gObjs = New GraphicObject() { New CurveGraphic(myPts4, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle, .StyleWidth = 8F } }
						Else
							gObjs = modBanDo.MyOtherLineStyle.GetGraphicObjs(modBanDo.defaMyLineStyle, myPts4)
						End If
					End If
				Case CBanDo.MapTools.ClosedCurve
					Dim myPts5 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts5.GetUpperBound(0) > 1)
					If flag Then
						Dim gp4 As GraphicsPath = New GraphicsPath()
						gp4.AddClosedCurve(myPts5)
						Dim rf4 As RectangleF = gp4.GetBounds()
						mPt0.X = (rf4.Left + rf4.Right) / 2F
						mPt0.Y = (rf4.Top + rf4.Bottom) / 2F
						Dim arg_272_0 As Integer = 0
						Dim upperBound4 As Integer = myPts5.GetUpperBound(0)
						Dim i As Integer = arg_272_0
						While True
							Dim arg_2D1_0 As Integer = i
							Dim num As Integer = upperBound4
							If arg_2D1_0 > num Then
								Exit While
							End If
							Dim arg_27C_0 As PointF() = myPts5
							Dim num2 As Integer = i
							arg_27C_0(num2).X = myPts5(num2).X - mPt0.X
							Dim arg_2A4_0 As PointF() = myPts5
							num2 = i
							arg_2A4_0(num2).Y = myPts5(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = New GraphicObject() { New ClosedCurveGraphic(myPts5, 1F, Color.Red) With { .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .Fill = modBanDo.defaGenFill, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle } }
					End If
				Case CBanDo.MapTools.Cycle
					Dim myPts6 As PointF()
					' The following expression was wrapped in a checked-statement
					mPt0.X = CSng((CDec((Me.DrawingRect.Left + Me.DrawingRect.Right)) / 2.0))
					mPt0.Y = CSng((CDec((Me.DrawingRect.Top + Me.DrawingRect.Bottom)) / 2.0))
					myPts6 = New PointF(1) {}
					myPts6(0).X = CSng((CDec(mPt0.X) - Math.Abs(CDec(Me.DrawingRect.Width) / 2.0)))
					myPts6(0).Y = CSng((CDec(mPt0.Y) - Math.Abs(CDec(Me.DrawingRect.Height) / 2.0)))
					myPts6(1).X = CSng((CDec(mPt0.X) + Math.Abs(CDec(Me.DrawingRect.Width) / 2.0)))
					myPts6(1).Y = CSng((CDec(mPt0.Y) + Math.Abs(CDec(Me.DrawingRect.Height) / 2.0)))
					Dim arg_1012_0 As Integer = 0
					Dim upperBound5 As Integer = myPts6.GetUpperBound(0)
					Dim i As Integer = arg_1012_0
					While True
						Dim arg_1071_0 As Integer = i
						Dim num As Integer = upperBound5
						If arg_1071_0 > num Then
							Exit While
						End If
						Dim arg_101C_0 As PointF() = myPts6
						Dim num2 As Integer = i
						arg_101C_0(num2).X = myPts6(num2).X - mPt0.X
						Dim arg_1044_0 As PointF() = myPts6
						num2 = i
						arg_1044_0(num2).Y = myPts6(num2).Y - mPt0.Y
						' The following expression was wrapped in a checked-statement
						i += 1
					End While
					gObjs = New GraphicObject() { New EllipseGraphic(myPts6(0).X, myPts6(0).Y, myPts6(1).X - myPts6(0).X, myPts6(1).Y - myPts6(0).Y, 0F) With { .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .Fill = modBanDo.defaGenFill, .FillColor = modBanDo.defaGenFillC, .LineStyle = modBanDo.defaGenLineStyle } }
				Case CBanDo.MapTools.Rectangle
					Dim myPts7 As PointF() = New PointF(3) {}
					myPts7(0).X = CSng(Me.DrawingRect.X)
					myPts7(0).Y = CSng(Me.DrawingRect.Y)
					Dim rf5 As RectangleF
					' The following expression was wrapped in a checked-statement
					myPts7(1).X = CSng((Me.DrawingRect.X + Me.DrawingRect.Width))
					myPts7(1).Y = CSng(Me.DrawingRect.Y)
					myPts7(2).X = CSng((Me.DrawingRect.X + Me.DrawingRect.Width))
					myPts7(2).Y = CSng((Me.DrawingRect.Y + Me.DrawingRect.Height))
					myPts7(3).X = CSng(Me.DrawingRect.X)
					myPts7(3).Y = CSng((Me.DrawingRect.Y + Me.DrawingRect.Height))
					Dim gp5 As GraphicsPath = New GraphicsPath()
					gp5.AddCurve(myPts7)
					rf5 = gp5.GetBounds()
					mPt0.X = (rf5.Left + rf5.Right) / 2F
					mPt0.Y = (rf5.Top + rf5.Bottom) / 2F
					Dim arg_12A6_0 As Integer = 0
					Dim upperBound6 As Integer = myPts7.GetUpperBound(0)
					Dim i As Integer = arg_12A6_0
					While True
						Dim arg_1305_0 As Integer = i
						Dim num As Integer = upperBound6
						If arg_1305_0 > num Then
							Exit While
						End If
						Dim arg_12B0_0 As PointF() = myPts7
						Dim num2 As Integer = i
						arg_12B0_0(num2).X = myPts7(num2).X - mPt0.X
						Dim arg_12D8_0 As PointF() = myPts7
						num2 = i
						arg_12D8_0(num2).Y = myPts7(num2).Y - mPt0.Y
						' The following expression was wrapped in a checked-statement
						i += 1
					End While
					gObjs = New GraphicObject() { New PolygonGraphic(myPts7, 1F, Color.Red) With { .Fill = False, .FillColor = modBanDo.defaGenFillC, .Rotation = 0F, .LineWidth = CSng(modBanDo.defaGenPen1W), .LineColor = modBanDo.defaGenPen1C, .Line2Width = CSng(modBanDo.defaGenPen2W), .Line2Color = modBanDo.defaGenPen2C, .LineStyle = modBanDo.defaGenLineStyle, .StyleWidth = 8F } }
				Case CBanDo.MapTools.arc
					Dim myPts8 As PointF() = New PointF(3) {}
					myPts8(1).X = CSng(Me.DrawingRect.X)
					myPts8(1).Y = CSng(Me.DrawingRect.Y)
					Dim rf6 As RectangleF
					' The following expression was wrapped in a checked-statement
					myPts8(2).X = CSng((Me.DrawingRect.X + Me.DrawingRect.Width))
					myPts8(2).Y = CSng(Me.DrawingRect.Y)
					myPts8(3).X = CSng((Me.DrawingRect.X + Me.DrawingRect.Width))
					myPts8(3).Y = CSng((Me.DrawingRect.Y + Me.DrawingRect.Height))
					myPts8(0).X = CSng(Me.DrawingRect.X)
					myPts8(0).Y = CSng((Me.DrawingRect.Y + Me.DrawingRect.Height))
					Dim gp6 As GraphicsPath = New GraphicsPath()
					gp6.AddCurve(myPts8)
					rf6 = gp6.GetBounds()
					mPt0.X = (rf6.Left + rf6.Right) / 2F
					mPt0.Y = (rf6.Top + rf6.Bottom) / 2F
					Dim arg_1507_0 As Integer = 0
					Dim upperBound7 As Integer = myPts8.GetUpperBound(0)
					Dim i As Integer = arg_1507_0
					While True
						Dim arg_1566_0 As Integer = i
						Dim num As Integer = upperBound7
						If arg_1566_0 > num Then
							Exit While
						End If
						Dim arg_1511_0 As PointF() = myPts8
						Dim num2 As Integer = i
						arg_1511_0(num2).X = myPts8(num2).X - mPt0.X
						Dim arg_1539_0 As PointF() = myPts8
						num2 = i
						arg_1539_0(num2).Y = myPts8(num2).Y - mPt0.Y
						' The following expression was wrapped in a checked-statement
						i += 1
					End While
					Dim myCurve As NodesShapeGraphic = New LinesGraphic(myPts8, 1F, Color.Red)
					myCurve.Fill = False
					myCurve.FillColor = modBanDo.defaGenFillC
					myCurve.Rotation = 0F
					myCurve.LineWidth = CSng(modBanDo.defaGenPen1W)
					myCurve.LineColor = modBanDo.defaGenPen1C
					myCurve.Line2Width = CSng(modBanDo.defaGenPen2W)
					myCurve.Line2Color = modBanDo.defaGenPen2C
					myCurve.LineStyle = modBanDo.defaGenLineStyle
					myCurve.StyleWidth = 8F
					myCurve.Nodes(1).IsControl = True
					myCurve.Nodes(2).IsControl = True
					gObjs = New GraphicObject() { myCurve }
				Case CBanDo.MapTools.Text
					mPt0.X = Me.myPts(0).X
					mPt0.Y = Me.myPts(0).Y
					gObjs = New GraphicObject() { New TextGraphic(Me.myPts(0).X - mPt0.X, Me.myPts(0).Y - mPt0.Y, "", modBanDo.defaTextFont, modBanDo.defaTextC) With { .Rotation = 0F, .Rotation = 0F, .AutoSize = True } }
				Case CBanDo.MapTools.Table
					mPt0.X = Me.myPts(0).X
					mPt0.Y = Me.myPts(0).Y
					Dim mySize As SizeF = Me.m_Map.CreateGraphics().MeasureString("TEXT", modBanDo.defaTableTFont)
					' The following expression was wrapped in a checked-statement
					Dim mW As Integer = CInt(Math.Round(CDec((mySize.Width * 10F / 4F))))
					Dim mH As Integer = CInt(Math.Round(CDec(mySize.Height))) + 2
					Dim myTableObject As TableGraphic = New TableGraphic(Me.myPts(0).X - mPt0.X, Me.myPts(0).Y - mPt0.Y, modBanDo.defaTableColsNo * mW, modBanDo.defaTableRowsNo * mH, modBanDo.defaTableColsNo, modBanDo.defaTableRowsNo, modBanDo.defaTableFillC)
					gObjs = New GraphicObject() { myTableObject }
					gObjs(0).Rotation = 0F
					gObjs(0).AutoSize = True
				Case CBanDo.MapTools.MuiTenDon
					Dim myPts9 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts9.GetUpperBound(0) > 0)
					If flag Then
						Dim gp7 As GraphicsPath = New GraphicsPath()
						gp7.AddCurve(myPts9)
						mPt0.X = myPts9(myPts9.GetUpperBound(0)).X
						mPt0.Y = myPts9(myPts9.GetUpperBound(0)).Y
						Dim arg_D9A_0 As Integer = 0
						Dim upperBound8 As Integer = myPts9.GetUpperBound(0)
						Dim i As Integer = arg_D9A_0
						While True
							Dim arg_DF9_0 As Integer = i
							Dim num As Integer = upperBound8
							If arg_DF9_0 > num Then
								Exit While
							End If
							Dim arg_DA4_0 As PointF() = myPts9
							Dim num2 As Integer = i
							arg_DA4_0(num2).X = myPts9(num2).X - mPt0.X
							Dim arg_DCC_0 As PointF() = myPts9
							num2 = i
							arg_DCC_0(num2).Y = myPts9(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = COtherLineStyle.GetMuiTenDon(myPts9, CSng((CDec(modBanDo.defaGenPen1W) * 1.5 * Me.myZoom / Me.m_Map.Zoom)))
						Dim myCurve2 As CurveGraphic = CType(gObjs(0), CurveGraphic)
						myCurve2.Rotation = 0F
						myCurve2.LineWidth = CSng(modBanDo.defaGenPen1W)
						myCurve2.LineColor = modBanDo.defaMuiTenPen1C
						myCurve2.Line2Width = CSng(modBanDo.defaGenPen2W)
						myCurve2.Line2Color = modBanDo.defaGenPen2C
						myCurve2.LineStyle = modBanDo.defaGenLineStyle
						Dim myPolygon As PolygonGraphic = CType(gObjs(1), PolygonGraphic)
						myPolygon.Rotation = 0F
						myPolygon.LineWidth = CSng(modBanDo.defaGenPen1W)
						myPolygon.LineColor = modBanDo.defaMuiTenPen1C
						myPolygon.Fill = True
						myPolygon.FillColor = modBanDo.defaMuiTenPen1C
						myPolygon.LineStyle = modBanDo.defaGenLineStyle
					End If
				Case CBanDo.MapTools.MuiTen
					Dim myPts10 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 16)
					flag = (myPts10.GetUpperBound(0) > 0)
					If flag Then
						mPt0.X = myPts10(myPts10.GetUpperBound(0)).X
						mPt0.Y = myPts10(myPts10.GetUpperBound(0)).Y
						Dim arg_995_0 As Integer = 0
						Dim upperBound9 As Integer = myPts10.GetUpperBound(0)
						Dim i As Integer = arg_995_0
						While True
							Dim arg_9F4_0 As Integer = i
							Dim num As Integer = upperBound9
							If arg_9F4_0 > num Then
								Exit While
							End If
							Dim arg_99F_0 As PointF() = myPts10
							Dim num2 As Integer = i
							arg_99F_0(num2).X = myPts10(num2).X - mPt0.X
							Dim arg_9C7_0 As PointF() = myPts10
							num2 = i
							arg_9C7_0(num2).Y = myPts10(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = COtherLineStyle.GetMuiTen(myPts10, modBanDo.myMuiTenDoRong)
						Dim myCurve3 As ClosedCurveGraphic = CType(gObjs(0), ClosedCurveGraphic)
						myCurve3.LineWidth = CSng(modBanDo.defaMuiTenPen1W)
						myCurve3.LineColor = modBanDo.defaMuiTenPen1C
						myCurve3.Line2Width = CSng(modBanDo.defaMuiTenPen2W)
						myCurve3.Line2Color = modBanDo.defaMuiTenPen2C
						myCurve3.Fill = modBanDo.defaMuiTenFill
						myCurve3.FillColor = modBanDo.defaMuiTenFillC
						myCurve3.Rotation = 0F
					End If
				Case CBanDo.MapTools.MuiTenDac
					Dim myPts11 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 16)
					flag = (myPts11.GetUpperBound(0) > 0)
					If flag Then
						mPt0.X = myPts11(myPts11.GetUpperBound(0)).X
						mPt0.Y = myPts11(myPts11.GetUpperBound(0)).Y
						Dim arg_C19_0 As Integer = 0
						Dim upperBound10 As Integer = myPts11.GetUpperBound(0)
						Dim i As Integer = arg_C19_0
						While True
							Dim arg_C78_0 As Integer = i
							Dim num As Integer = upperBound10
							If arg_C78_0 > num Then
								Exit While
							End If
							Dim arg_C23_0 As PointF() = myPts11
							Dim num2 As Integer = i
							arg_C23_0(num2).X = myPts11(num2).X - mPt0.X
							Dim arg_C4B_0 As PointF() = myPts11
							num2 = i
							arg_C4B_0(num2).Y = myPts11(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = COtherLineStyle.GetMuiTenDac(myPts11, CSng((CDec(modBanDo.defaMuiTenDacDoRong) * Me.myZoom / Me.m_Map.Zoom)), CSng((CDec(modBanDo.defaMuiTenDacDoDai) * Me.myZoom / Me.m_Map.Zoom)))
						Dim myCurve4 As CurveGraphic = CType(gObjs(0), CurveGraphic)
						myCurve4.LineWidth = CSng(modBanDo.defaMuiTenDacPen1W)
						myCurve4.LineColor = modBanDo.defaMuiTenDacPen1C
						myCurve4.Line2Width = CSng(modBanDo.defaMuiTenDacPen2W)
						myCurve4.Line2Color = modBanDo.defaMuiTenDacPen2C
						myCurve4.Fill = modBanDo.defaMuiTenDacFill
						myCurve4.FillColor = modBanDo.defaMuiTenDacFillC
						myCurve4.Rotation = 0F
					End If
				Case CBanDo.MapTools.MuiTenHo
					Dim myPts12 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 16)
					flag = (myPts12.GetUpperBound(0) > 0)
					If flag Then
						mPt0.X = myPts12(myPts12.GetUpperBound(0)).X
						mPt0.Y = myPts12(myPts12.GetUpperBound(0)).Y
						Dim arg_AD7_0 As Integer = 0
						Dim upperBound11 As Integer = myPts12.GetUpperBound(0)
						Dim i As Integer = arg_AD7_0
						While True
							Dim arg_B36_0 As Integer = i
							Dim num As Integer = upperBound11
							If arg_B36_0 > num Then
								Exit While
							End If
							Dim arg_AE1_0 As PointF() = myPts12
							Dim num2 As Integer = i
							arg_AE1_0(num2).X = myPts12(num2).X - mPt0.X
							Dim arg_B09_0 As PointF() = myPts12
							num2 = i
							arg_B09_0(num2).Y = myPts12(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = COtherLineStyle.GetMuiTenHo(myPts12, modBanDo.myMuiTenDoRong)
						Dim myCurve5 As CurveGraphic = CType(gObjs(0), CurveGraphic)
						myCurve5.LineWidth = CSng(modBanDo.defaMuiTenPen1W)
						myCurve5.LineColor = modBanDo.defaMuiTenPen1C
						myCurve5.Line2Width = CSng(modBanDo.defaMuiTenPen2W)
						myCurve5.Line2Color = modBanDo.defaMuiTenPen2C
						myCurve5.Fill = modBanDo.defaMuiTenFill
						myCurve5.FillColor = modBanDo.defaMuiTenFillC
						myCurve5.Rotation = 0F
					End If
				Case CBanDo.MapTools.SongSong
					Dim myPts13 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts13.GetUpperBound(0) > 0)
					If flag Then
						Dim gp8 As GraphicsPath = New GraphicsPath()
						gp8.AddCurve(myPts13)
						Dim rf7 As RectangleF = gp8.GetBounds()
						mPt0.X = (rf7.Left + rf7.Right) / 2F
						mPt0.Y = (rf7.Top + rf7.Bottom) / 2F
						Dim arg_6BE_0 As Integer = 0
						Dim upperBound12 As Integer = myPts13.GetUpperBound(0)
						Dim i As Integer = arg_6BE_0
						While True
							Dim arg_71D_0 As Integer = i
							Dim num As Integer = upperBound12
							If arg_71D_0 > num Then
								Exit While
							End If
							Dim arg_6C8_0 As PointF() = myPts13
							Dim num2 As Integer = i
							arg_6C8_0(num2).X = myPts13(num2).X - mPt0.X
							Dim arg_6F0_0 As PointF() = myPts13
							num2 = i
							arg_6F0_0(num2).Y = myPts13(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = COtherLineStyle.GetSongSong(myPts13, modBanDo.defaSongSongSize, modBanDo.defaSongSongLinesNo)
						Dim arg_73B_0 As Integer = 0
						Dim upperBound13 As Integer = gObjs.GetUpperBound(0)
						Dim j As Integer = arg_73B_0
						' The following expression was wrapped in a checked-statement
						While True
							Dim arg_7B1_0 As Integer = j
							Dim num As Integer = upperBound13
							If arg_7B1_0 > num Then
								Exit While
							End If
							Dim myCurve6 As CurveGraphic = New CurveGraphic(myPts13, 1F, Color.Red)
							myCurve6.LineWidth = CSng(modBanDo.defaSongSongPen1W)
							myCurve6.LineColor = modBanDo.defaSongSongPen1C
							myCurve6.Line2Width = CSng(modBanDo.defaSongSongPen2W)
							myCurve6.Line2Color = modBanDo.defaSongSongPen2C
							myCurve6.LineStyle = modBanDo.defaSongSongLineStyle
							myCurve6.Rotation = 0F
							j += 1
						End While
					End If
				Case CBanDo.MapTools.SongSongKin
					Dim myPts14 As PointF() = COtherLineStyle.GetNormalPts(Me.myPts, 1)
					flag = (myPts14.GetUpperBound(0) > 1)
					If flag Then
						Dim gp9 As GraphicsPath = New GraphicsPath()
						gp9.AddClosedCurve(myPts14)
						Dim rf8 As RectangleF = gp9.GetBounds()
						mPt0.X = (rf8.Left + rf8.Right) / 2F
						mPt0.Y = (rf8.Top + rf8.Bottom) / 2F
						Dim arg_83B_0 As Integer = 0
						Dim upperBound14 As Integer = myPts14.GetUpperBound(0)
						Dim i As Integer = arg_83B_0
						While True
							Dim arg_89A_0 As Integer = i
							Dim num As Integer = upperBound14
							If arg_89A_0 > num Then
								Exit While
							End If
							Dim arg_845_0 As PointF() = myPts14
							Dim num2 As Integer = i
							arg_845_0(num2).X = myPts14(num2).X - mPt0.X
							Dim arg_86D_0 As PointF() = myPts14
							num2 = i
							arg_86D_0(num2).Y = myPts14(num2).Y - mPt0.Y
							' The following expression was wrapped in a checked-statement
							i += 1
						End While
						gObjs = COtherLineStyle.GetSongSongKin(myPts14, modBanDo.defaSongSongSize, modBanDo.defaSongSongLinesNo)
						Dim arg_8B8_0 As Integer = 0
						Dim upperBound15 As Integer = gObjs.GetUpperBound(0)
						Dim k As Integer = arg_8B8_0
						' The following expression was wrapped in a checked-statement
						While True
							Dim arg_926_0 As Integer = k
							Dim num As Integer = upperBound15
							If arg_926_0 > num Then
								Exit While
							End If
							Dim myClosedCurve As ClosedCurveGraphic = CType(gObjs(k), ClosedCurveGraphic)
							myClosedCurve.LineWidth = CSng(modBanDo.defaSongSongPen1W)
							myClosedCurve.LineColor = modBanDo.defaSongSongPen1C
							myClosedCurve.Line2Width = CSng(modBanDo.defaSongSongPen2W)
							myClosedCurve.Line2Color = modBanDo.defaSongSongPen2C
							myClosedCurve.LineStyle = modBanDo.defaSongSongLineStyle
							myClosedCurve.Rotation = 0F
							k += 1
						End While
					End If
			End Select
			flag = (gObjs.GetUpperBound(0) > -1)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mGObjs As CGraphicObjs = New CGraphicObjs()
				Dim array As GraphicObject() = gObjs
				For l As Integer = 0 To array.Length - 1
					Dim gObj As GraphicObject = array(l)
					mGObjs.Add(gObj)
				Next
				flag = ((Control.ModifierKeys And Keys.Alt) = Keys.Alt)
				If flag Then
					Me.TraoMau(mGObjs)
				End If
				Me.PopUndo()
				Dim mSymbolObj As CSymbol = New CSymbol(Me.m_Map, mPt0, mGObjs)
				flag = (Me.m_DrawingSymbols.Count > 0)
				If flag Then
					Dim mFstSymbolZoom As Long = CLng(Math.Round(Me.m_DrawingSymbols(0).Zoom))
					Dim mFstSymbolMWidth As Long = CLng(Math.Round(CDec(Me.m_DrawingSymbols(0).MWidth)))
					flag = (Me.m_Map.Zoom <> CDec(mFstSymbolZoom) Or Me.m_Map.MapScreenWidth <> CSng(mFstSymbolMWidth))
					If flag Then
						mSymbolObj.ChangeZoomMWidtht(CDec(mFstSymbolZoom), CSng(mFstSymbolMWidth))
					End If
				Else
					flag = (Me.m_Map.Zoom <> CDec(modBanDo.myKHQSZoom) Or Me.m_Map.MapScreenWidth <> CSng(modBanDo.myKHQSMWidth))
					If flag Then
						mSymbolObj.ChangeZoomMWidtht(CDec(modBanDo.myKHQSZoom), CSng(modBanDo.myKHQSMWidth))
					End If
				End If
				mSymbolObj.Description = "Ký hi" & ChrW(7879) & "u m" & ChrW(7899) & "i"
				Me.m_DrawingSymbols.Add(mSymbolObj)
				Me.m_Map.CenterX = Me.m_Map.CenterX
				Me.m_SelectedSymbol = mSymbolObj
				Me.m_ParentForm.ToolStripStatusLabel3.Text = ""
			End If
		End Sub

		Private Sub TraoMau0(pGObjs As CGraphicObjs)
			Try
				Try
					Dim enumerator As IEnumerator = pGObjs.GetEnumerator()
					While enumerator.MoveNext()
						Dim aGObj As GraphicObject = CType(enumerator.Current, GraphicObject)
						Select Case aGObj.GetObjType()
							Case OBJECTTYPE.Ellipse, OBJECTTYPE.Pie
								Dim mShape As ShapeGraphic = CType(aGObj, ShapeGraphic)
								Dim shapeGraphic As ShapeGraphic = mShape
								Dim flag As Boolean = shapeGraphic.LineColor = Color.Red
								If flag Then
									shapeGraphic.LineColor = Color.Blue
								Else
									flag = (shapeGraphic.LineColor = Color.Blue)
									If flag Then
										shapeGraphic.LineColor = Color.Red
									End If
								End If
								flag = (shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), Color.Red))
								If flag Then
									shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), Color.Blue)
								Else
									flag = (shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), Color.Blue))
									If flag Then
										shapeGraphic.FillColor = Color.FromArgb(CInt(shapeGraphic.FillColor.A), Color.Red)
									End If
								End If
							Case OBJECTTYPE.Text
								Dim mShape2 As TextGraphic = CType(aGObj, TextGraphic)
								Dim textGraphic As TextGraphic = mShape2
								Dim flag As Boolean = textGraphic.Color = Color.Red
								If flag Then
									textGraphic.Color = Color.Blue
								Else
									flag = (textGraphic.Color = Color.Blue)
									If flag Then
										textGraphic.Color = Color.Red
									End If
								End If
							Case OBJECTTYPE.Table
							Case OBJECTTYPE.EmbeddedImage
							Case Else
								Try
									Dim mShape3 As NodesShapeGraphic = CType(aGObj, NodesShapeGraphic)
									Dim nodesShapeGraphic As NodesShapeGraphic = mShape3
									Dim flag As Boolean = nodesShapeGraphic.LineColor = Color.Red
									If flag Then
										nodesShapeGraphic.LineColor = Color.Blue
									Else
										flag = (nodesShapeGraphic.LineColor = Color.Blue)
										If flag Then
											nodesShapeGraphic.LineColor = Color.Red
										End If
									End If
									flag = (nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), Color.Red))
									If flag Then
										nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), Color.Blue)
									Else
										flag = (nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), Color.Blue))
										If flag Then
											nodesShapeGraphic.FillColor = Color.FromArgb(CInt(nodesShapeGraphic.FillColor.A), Color.Red)
										End If
									End If
								Catch expr_2AB As Exception
									ProjectData.SetProjectError(expr_2AB)
									ProjectData.ClearProjectError()
								End Try
						End Select
					End While
				Finally
					Dim enumerator As IEnumerator
					Dim flag As Boolean = TypeOf enumerator Is IDisposable
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
			Catch expr_2F5 As Exception
				ProjectData.SetProjectError(expr_2F5)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Function TachObject(pFObj As CFOUNDOBJECT) As CSymbol
			Dim KQ As CSymbol = Nothing
			Dim flag As Boolean = pFObj IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean = pFObj.FoundSymbol.GObjs.Count > 1
				If flag2 Then
					Dim mObj As GraphicObject = pFObj.FoundObject.Clone()
					Dim mPt0 As PointF = Nothing
					Dim arg_87_0 As AxMap = Me.m_Map
					Dim x As Single = mPt0.X
					Dim y As Single = mPt0.Y
					Dim foundSymbol As CSymbol = pFObj.FoundSymbol
					Dim gocX As Double = foundSymbol.GocX
					Dim foundSymbol2 As CSymbol = pFObj.FoundSymbol
					Dim gocY As Double = foundSymbol2.GocY
					arg_87_0.ConvertCoord(x, y, gocX, gocY, ConversionConstants.miMapToScreen)
					foundSymbol2.GocY = gocY
					foundSymbol.GocX = gocX
					mPt0.Y = y
					mPt0.X = x
					Dim mGObjs As CGraphicObjs = New CGraphicObjs()
					mGObjs.Add(mObj)
					Dim mSymbolObj As CSymbol = New CSymbol(Me.m_Map, mPt0, mGObjs, pFObj.FoundSymbol.Zoom, pFObj.FoundSymbol.MWidth)
					Dim mRect As System.Drawing.Rectangle = mSymbolObj.GetBounds(Me.m_Map)
					Dim arg_142_0 As AxMap = Me.m_Map
					y = CSng((CDec((mRect.Left + mRect.Right)) / 2.0))
					x = CSng((CDec((mRect.Top + mRect.Bottom)) / 2.0))
					Dim mGocX As Double
					Dim mGocY As Double
					arg_142_0.ConvertCoord(y, x, mGocX, mGocY, ConversionConstants.miScreenToMap)
					mSymbolObj.ChangeRoot(Me.m_Map, mGocX, mGocY)
					mSymbolObj.Description = pFObj.FoundSymbol.Description
					Me.m_DrawingSymbols.Add(mSymbolObj)
					KQ = mSymbolObj
					pFObj.FoundSymbol.GObjs.Remove(pFObj.FoundObject)
				End If
			End If
			Return KQ
		End Function

		Private Sub TachAllObject(pSymbol As CSymbol)
			Dim KQ As Boolean = False
			Dim flag As Boolean = pSymbol IsNot Nothing
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean
				Try
					flag2 = (pSymbol.GObjs.Count > 1)
					If flag2 Then
						Try
							Dim enumerator As IEnumerator = pSymbol.GObjs.GetEnumerator()
							While enumerator.MoveNext()
								Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
								Dim mPt0 As PointF = Nothing
								Dim arg_8D_0 As AxMap = Me.m_Map
								Dim x As Single = mPt0.X
								Dim y As Single = mPt0.Y
								Dim gocX As Double = pSymbol.GocX
								Dim gocY As Double = pSymbol.GocY
								arg_8D_0.ConvertCoord(x, y, gocX, gocY, ConversionConstants.miMapToScreen)
								pSymbol.GocY = gocY
								pSymbol.GocX = gocX
								mPt0.Y = y
								mPt0.X = x
								Dim mGObjs As CGraphicObjs = New CGraphicObjs()
								mGObjs.Add(mObj)
								Dim mSymbolObj As CSymbol = New CSymbol(Me.m_Map, mPt0, mGObjs, pSymbol.Zoom, pSymbol.MWidth)
								Dim mRect As System.Drawing.Rectangle = mSymbolObj.GetBounds(Me.m_Map)
								Dim arg_13E_0 As AxMap = Me.m_Map
								y = CSng((CDec((mRect.Left + mRect.Right)) / 2.0))
								x = CSng((CDec((mRect.Top + mRect.Bottom)) / 2.0))
								Dim mGocX As Double
								Dim mGocY As Double
								arg_13E_0.ConvertCoord(y, x, mGocX, mGocY, ConversionConstants.miScreenToMap)
								mSymbolObj.ChangeRoot(Me.m_Map, mGocX, mGocY)
								mSymbolObj.Description = pSymbol.Description
								Me.m_DrawingSymbols.Add(mSymbolObj)
							End While
						Finally
							Dim enumerator As IEnumerator
							flag2 = (TypeOf enumerator Is IDisposable)
							If flag2 Then
								(TryCast(enumerator, IDisposable)).Dispose()
							End If
						End Try
						KQ = True
					End If
				Catch expr_1AB As Exception
					ProjectData.SetProjectError(expr_1AB)
					ProjectData.ClearProjectError()
				End Try
				flag2 = KQ
				If flag2 Then
					Me.m_DrawingSymbols.Remove(pSymbol)
				End If
			End If
		End Sub

		Private Sub NhomSymbols(SelectedSymbols As CSymbols)
			Dim flag As Boolean = SelectedSymbols.Count > 1
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mGObjs As CGraphicObjs = New CGraphicObjs()
				Dim mSymbol As CSymbol = SelectedSymbols(0)
				Dim arg_2C_0 As Integer = 1
				Dim num As Integer = SelectedSymbols.Count - 1
				Dim i As Integer = arg_2C_0
				While True
					Dim arg_EC_0 As Integer = i
					Dim num2 As Integer = num
					If arg_EC_0 > num2 Then
						Exit While
					End If
					SelectedSymbols(i).ChangeZoomMWidtht(mSymbol.Zoom, mSymbol.MWidth)
					SelectedSymbols(i).ChangeRoot(Me.m_Map, mSymbol.GocX, mSymbol.GocY)
					Try
						Dim enumerator As IEnumerator = SelectedSymbols(i).GObjs.GetEnumerator()
						While enumerator.MoveNext()
							Dim gObj As GraphicObject = CType(enumerator.Current, GraphicObject)
							mSymbol.GObjs.Add(gObj)
						End While
					Finally
						Dim enumerator As IEnumerator
						flag = (TypeOf enumerator Is IDisposable)
						If flag Then
							(TryCast(enumerator, IDisposable)).Dispose()
						End If
					End Try
					Me.m_DrawingSymbols.Remove(SelectedSymbols(i))
					i += 1
				End While
			End If
		End Sub

		Private Sub CopySymbols(SelectedSymbols As CSymbols)
			Dim flag As Boolean = SelectedSymbols.Count > 0
			If flag Then
				Me.m_CopySymbols.Clear()
				Try
					Dim enumerator As IEnumerator = SelectedSymbols.GetEnumerator()
					While enumerator.MoveNext()
						Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
						Me.m_CopySymbols.Add(mSymbol)
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

		Private Sub CutSymbols(SelectedSymbols As CSymbols)
			Dim flag As Boolean = SelectedSymbols.Count > 0
			If flag Then
				Me.m_CopySymbols.Clear()
				Try
					Dim enumerator As IEnumerator = SelectedSymbols.GetEnumerator()
					While enumerator.MoveNext()
						Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
						Me.m_CopySymbols.Add(mSymbol)
						Me.m_DrawingSymbols.Remove(mSymbol)
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

		Public Sub OnDrawObj(pType As String)
			Me.m_SelectedSymbol = Nothing
			Me.m_SelectedObject = Nothing
			Dim flag As Boolean = Operators.CompareString(pType, "Line", False) = 0
			If flag Then
				Me.myMapTool = CBanDo.MapTools.Line
			Else
				flag = (Operators.CompareString(pType, "Polygon", False) = 0)
				If flag Then
					Me.myMapTool = CBanDo.MapTools.Polygon
				Else
					flag = (Operators.CompareString(pType, "Curve", False) = 0)
					If flag Then
						Me.myMapTool = CBanDo.MapTools.Curve
					Else
						flag = (Operators.CompareString(pType, "ClosedCurve", False) = 0)
						If flag Then
							Me.myMapTool = CBanDo.MapTools.ClosedCurve
						Else
							flag = (Operators.CompareString(pType, "Ellipse", False) = 0 OrElse Operators.CompareString(pType, "Cycle", False) = 0)
							If flag Then
								Me.myMapTool = CBanDo.MapTools.Cycle
							Else
								flag = (Operators.CompareString(pType, "Arc", False) = 0)
								If flag Then
									Me.myMapTool = CBanDo.MapTools.arc
								Else
									flag = (Operators.CompareString(pType, "Rectangle", False) = 0)
									If flag Then
										Me.myMapTool = CBanDo.MapTools.Rectangle
									Else
										flag = (Operators.CompareString(pType, "Text", False) = 0)
										If flag Then
											Me.myMapTool = CBanDo.MapTools.Text
										Else
											flag = (Operators.CompareString(pType, "Table", False) = 0)
											If flag Then
												Me.myMapTool = CBanDo.MapTools.Table
											Else
												flag = (Operators.CompareString(pType, "MuiTenDon", False) = 0)
												If flag Then
													Me.myMapTool = CBanDo.MapTools.MuiTenDon
												Else
													flag = (Operators.CompareString(pType, "MuiTen", False) = 0)
													If flag Then
														Me.myMapTool = CBanDo.MapTools.MuiTen
													Else
														flag = (Operators.CompareString(pType, "MuiTenDac", False) = 0)
														If flag Then
															Me.myMapTool = CBanDo.MapTools.MuiTenDac
														Else
															flag = (Operators.CompareString(pType, "MuiTenHo", False) = 0)
															If flag Then
																Me.myMapTool = CBanDo.MapTools.MuiTenHo
															Else
																flag = (Operators.CompareString(pType, "SongSong", False) = 0)
																If flag Then
																	Me.myMapTool = CBanDo.MapTools.SongSong
																Else
																	flag = (Operators.CompareString(pType, "SongSongKin", False) = 0)
																	If flag Then
																		Me.myMapTool = CBanDo.MapTools.SongSongKin
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
					End If
				End If
			End If
			flag = (Operators.CompareString(pType, "Ellipse", False) = 0)
			If flag Then
				Me.m_ParentForm.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + pType + ": kéo theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng chéo (" & ChrW(7845) & "n Alt " & ChrW(273) & ChrW(7875) & " có m" & ChrW(7847) & "u quân Xanh)."
			Else
				flag = (Operators.CompareString(pType, "Rectangle", False) = 0)
				If flag Then
					Me.m_ParentForm.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + pType + ": kéo theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng chéo (" & ChrW(7845) & "n Alt " & ChrW(273) & ChrW(7875) & " có m" & ChrW(7847) & "u quân Xanh)."
				Else
					flag = (Operators.CompareString(pType, "Arc", False) = 0)
					If flag Then
						Me.m_ParentForm.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + pType + ": kéo theo " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng chéo (" & ChrW(7845) & "n Alt " & ChrW(273) & ChrW(7875) & " có m" & ChrW(7847) & "u quân Xanh)."
					Else
						flag = (Operators.CompareString(pType, "Text", False) = 0)
						If flag Then
							Me.m_ParentForm.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + pType + ": Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n v" & ChrW(7883) & " trí Text (" & ChrW(7845) & "n Alt " & ChrW(273) & ChrW(7875) & " có m" & ChrW(7847) & "u quân Xanh)."
						Else
							flag = (Operators.CompareString(pType, "Table", False) = 0)
							If flag Then
								Me.m_ParentForm.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + pType + ": Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n v" & ChrW(7883) & " trí Table (" & ChrW(7845) & "n Alt " & ChrW(273) & ChrW(7875) & " có m" & ChrW(7847) & "u quân Xanh)."
							Else
								Me.m_ParentForm.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + pType + ": Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc (" & ChrW(7845) & "n Alt " & ChrW(273) & ChrW(7875) & " có m" & ChrW(7847) & "u quân Xanh)."
							End If
						End If
					End If
				End If
			End If
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub MnuPartSendBack_Click(sender As Object, e As EventArgs)
			Me.FoundObject.FoundSymbol.GObjs.SendBack(Me.FoundObject.FoundObject)
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub MnuPartTachObject_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Dim mSymbol As CSymbol = Me.TachObject(Me.FoundObject)
			Dim flag As Boolean = Not Information.IsNothing(mSymbol)
			If flag Then
				Me.m_Map.CenterX = Me.m_Map.CenterX
				Me.m_ParentForm.PopulateListKH(mSymbol)
			End If
		End Sub

		Private Sub MnuScale_Click(sender As Object, e As EventArgs)
			Me.myMapTool = CBanDo.MapTools.Scale
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Zoom: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " thay " & ChrW(273) & ChrW(7893) & "i kích th" & ChrW(432) & ChrW(7899) & "c KH."
		End Sub

		Private Sub MnuKHMove_Click(sender As Object, e As EventArgs)
			Me.myMapTool = CBanDo.MapTools.Move
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Move: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " thay " & ChrW(273) & ChrW(7893) & "i vi trí KH."
		End Sub

		Private Sub MnuBlinking_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_SelectedSymbol IsNot Nothing
			If flag Then
				Me.m_SelectedSymbol.Blinking = Not Me.m_SelectedSymbol.Blinking
			End If
		End Sub

		Protected Overrides Sub Finalize()
			MyBase.Finalize()
		End Sub

		Public Sub Dispose()
			Try
				Me.m_Map.Layers.Remove("LopVeKyHieu")
			Catch expr_1A As Exception
				ProjectData.SetProjectError(expr_1A)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub MnuGrNhom_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.m_SelectedSymbols.Count > 1
			If flag Then
				Me.PopUndo()
				Dim mSymbol As CSymbol = Me.m_SelectedSymbols(0)
				Me.NhomSymbols(Me.m_SelectedSymbols)
				Me.m_SelectedSymbols.Clear()
				Me.m_Map.CenterX = Me.m_Map.CenterX
				Me.m_ParentForm.PopulateListKH(mSymbol)
			End If
		End Sub

		Private Sub MnuGrCopy_Click(sender As Object, e As EventArgs)
			Me.CopySymbols(Me.m_SelectedSymbols)
			Me.m_SelectedSymbols.Clear()
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub MnuGrCut_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.CutSymbols(Me.m_SelectedSymbols)
			Me.m_SelectedSymbols.Clear()
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Public Sub RefreshMap()
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Public Sub CenterTo(pLon As Double, pLat As Double)
			Me.m_Map.CenterX = pLon
			Me.m_Map.CenterY = pLat
		End Sub

		Private Sub MnuMapKHsFromFile_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.InitialDirectory = Application.StartupPath
			openFileDialog.Filter = "TrangB" & ChrW(272) & " files (*.TBD)|*.TBD|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			openFileDialog.RestoreDirectory = True
			Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim mFileName As String = openFileDialog.FileName
				flag = (mFileName.Length > 0)
				If flag Then
					Me.PopUndo()
					Me.LoadKHs(mFileName)
					flag = (Me.drawingSymbols.Count > 0)
					If flag Then
						Me.m_Map.ZoomTo(Me.myZoom, Me.myCX, Me.myCY)
					Else
						Me.RefreshMap()
					End If
				End If
			End If
		End Sub

		Private Sub MnuMapKHsFromTT_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub MnuVFlip_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.m_SelectedSymbol.VFlip()
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub MnuClosed2Curve_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FoundObject.FoundObject.GetObjType() = OBJECTTYPE.ClosedCurve Or Me.FoundObject.FoundObject.GetObjType() = OBJECTTYPE.Polygon
			If flag Then
				Me.PopUndo()
				Me.FoundObject.FoundSymbol.GObjs.MoClosedCurve(Me.FoundObject.FoundObject)
				Me.m_Map.CenterX = Me.m_Map.CenterX
			Else
				Interaction.MsgBox("Chi lam duoc voi Duong kin thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub MnuCurve2Closed_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FoundObject.FoundObject.GetObjType() = OBJECTTYPE.Curve Or Me.FoundObject.FoundObject.GetObjType() = OBJECTTYPE.Line
			If flag Then
				Dim mCurve As NodesShapeGraphic = CType(Me.FoundObject.FoundObject, NodesShapeGraphic)
				flag = (mCurve.Nodes.Count > 2)
				If flag Then
					Me.PopUndo()
					Me.FoundObject.FoundSymbol.GObjs.DongCurve(Me.FoundObject.FoundObject)
					Me.m_Map.CenterX = Me.m_Map.CenterX
				Else
					Interaction.MsgBox("Khong kep kin duoc", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Chi lam duoc voi duong mo thoi", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub MnuTo1stNode_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FoundNode IsNot Nothing
			If flag Then
				Dim flag2 As Boolean = Me.FoundNode.FoundObject.GetObjType() = OBJECTTYPE.ClosedCurve
				If flag2 Then
					Dim mCCurve As ClosedCurveGraphic = CType(Me.FoundNode.FoundObject, ClosedCurveGraphic)
					mCCurve.To1stNode(Me.FoundNode.NodeIndex)
					Me.m_Map.CenterX = Me.m_Map.CenterX
				Else
					flag2 = (Me.FoundNode.FoundObject.GetObjType() = OBJECTTYPE.Polygon)
					If flag2 Then
						Dim mPolygon As PolygonGraphic = CType(Me.FoundNode.FoundObject, PolygonGraphic)
						mPolygon.To1stNode(Me.FoundNode.NodeIndex)
						Me.m_Map.CenterX = Me.m_Map.CenterX
					Else
						flag2 = (Me.FoundNode.FoundObject.GetObjType() = OBJECTTYPE.Curve Or Me.FoundNode.FoundObject.GetObjType() = OBJECTTYPE.Line)
						If flag2 Then
							Dim mNShape As NodesShapeGraphic = CType(Me.FoundNode.FoundObject, NodesShapeGraphic)
							' The following expression was wrapped in a checked-expression
							flag2 = (Me.FoundNode.NodeIndex = mNShape.Nodes.Count - 1)
							If flag2 Then
								mNShape.ReverseNodes()
								Me.m_Map.CenterX = Me.m_Map.CenterX
							Else
								Interaction.MsgBox("Chi lam duoc voi node cuoi thoi", MsgBoxStyle.OkOnly, Nothing)
							End If
						Else
							Interaction.MsgBox("Chi lam duoc voi ClosedCurve thoi", MsgBoxStyle.OkOnly, Nothing)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub MnuCut_Click(sender As Object, e As EventArgs)
			Me.myMapTool = CBanDo.MapTools.Split
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "C" & ChrW(7855) & "t: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " v" & ChrW(7869) & " " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng c" & ChrW(7855) & "t."
		End Sub

		Private Function To2Symbols(pSymbol As CSymbol, pPT0 As PointF, pPT1 As PointF) As CBanDo.SPLITSYMBOLS
			Dim mSPLITSYMBOLS As CBanDo.SPLITSYMBOLS = Nothing
			Dim mGObjs As CGraphicObjs = New CGraphicObjs()
			Dim mGObjs2 As CGraphicObjs = New CGraphicObjs()
			Dim mPTs2 As PointF() = New PointF() { pPT0, pPT1 }
			Dim Scale As Single = CSng((pSymbol.Zoom / Me.m_Map.Zoom))
			Scale = Conversions.ToSingle(Operators.MultiplyObject(Scale, Interaction.IIf(pSymbol.MWidth > 0F, Me.m_Map.MapScreenWidth / pSymbol.MWidth, 1)))
			Dim mMatrix As Matrix = New Matrix()
			mMatrix.Translate(-Me.myrootPt.X, -Me.myrootPt.Y, MatrixOrder.Append)
			mMatrix.Scale(1F / Scale, 1F / Scale, MatrixOrder.Append)
			mMatrix.TransformPoints(mPTs2)
			Dim mA0 As Single = modBanDo.AngleToPoint(mPTs2(0), mPTs2(1))
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean
			Try
				Dim enumerator As IEnumerator = pSymbol.GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					Dim mObj2 As GraphicObject = modBanDo.ObjToCurve(mObj)
					flag = (mObj2.GetObjType() = OBJECTTYPE.Curve)
					If flag Then
						Dim mPTs3 As PointF() = mObj2.GetPoints()
						Dim mINTERSECTNODEs As modBanDo.INTERSECTNODE() = modBanDo.GetIntersectPoints(mPTs2(0), mPTs2(1), mPTs3)
						flag = (mINTERSECTNODEs.GetUpperBound(0) > -1)
						If flag Then
							Dim mPts As PointF() = New PointF(mPTs3.GetUpperBound(0) + mINTERSECTNODEs.GetUpperBound(0) + 1 + 1 - 1) {}
							Dim i As Integer = 0
							Dim arg_19E_0 As Integer = 0
							Dim upperBound As Integer = mINTERSECTNODEs.GetUpperBound(0)
							Dim j As Integer = arg_19E_0
							While True
								Dim arg_25A_0 As Integer = j
								Dim num As Integer = upperBound
								If arg_25A_0 > num Then
									Exit While
								End If
								Dim arg_1B7_0 As Integer = i
								Dim nodeIndex As Integer = mINTERSECTNODEs(j).NodeIndex
								Dim k As Integer = arg_1B7_0
								While True
									Dim arg_1E9_0 As Integer = k
									num = nodeIndex
									If arg_1E9_0 > num Then
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
							Dim arg_26B_0 As Integer = i
							Dim upperBound2 As Integer = mPTs3.GetUpperBound(0)
							Dim l As Integer = arg_26B_0
							While True
								Dim arg_2A5_0 As Integer = l
								Dim num As Integer = upperBound2
								If arg_2A5_0 > num Then
									Exit While
								End If
								mPts(l + mINTERSECTNODEs.GetUpperBound(0) + 1) = mPTs3(l)
								l += 1
							End While
							Dim mPTS4O As PointF() = New PointF(-1) {}
							Dim mPTS4O2 As PointF() = New PointF(-1) {}
							Dim k2 As Integer = 0
							Dim arg_2C5_0 As Integer = 0
							Dim upperBound3 As Integer = mINTERSECTNODEs.GetUpperBound(0)
							Dim m As Integer = arg_2C5_0
							While True
								Dim arg_464_0 As Integer = m
								Dim num As Integer = upperBound3
								If arg_464_0 > num Then
									Exit While
								End If
								Dim mPts2 As PointF() = New PointF(mINTERSECTNODEs(m).NodeIndex - k2 + 1 - 1) {}
								Dim arg_2F8_0 As Integer = k2
								Dim nodeIndex2 As Integer = mINTERSECTNODEs(m).NodeIndex
								Dim n As Integer = arg_2F8_0
								While True
									Dim arg_32A_0 As Integer = n
									num = nodeIndex2
									If arg_32A_0 > num Then
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
									Dim arg_3A9_0 As Integer = 0
									Dim upperBound4 As Integer = mPts2.GetUpperBound(0)
									Dim j2 As Integer = arg_3A9_0
									While True
										Dim arg_3DD_0 As Integer = j2
										num = upperBound4
										If arg_3DD_0 > num Then
											Exit While
										End If
										mPTS4O(j2 + l2 + 1) = mPts2(j2)
										j2 += 1
									End While
								Else
									Dim l3 As Integer = mPTS4O2.GetUpperBound(0)
									mPTS4O2 = CType(Utils.CopyArray(CType(mPTS4O2, Array), New PointF(l3 + mPts2.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
									Dim arg_41E_0 As Integer = 0
									Dim upperBound5 As Integer = mPts2.GetUpperBound(0)
									Dim j3 As Integer = arg_41E_0
									While True
										Dim arg_452_0 As Integer = j3
										num = upperBound5
										If arg_452_0 > num Then
											Exit While
										End If
										mPTS4O2(j3 + l3 + 1) = mPts2(j3)
										j3 += 1
									End While
								End If
								m += 1
							End While
							Dim mPts3 As PointF() = New PointF(mPts.GetUpperBound(0) - k2 + 1 - 1) {}
							Dim arg_489_0 As Integer = k2
							Dim upperBound6 As Integer = mPts.GetUpperBound(0)
							Dim j4 As Integer = arg_489_0
							While True
								Dim arg_4BB_0 As Integer = j4
								Dim num As Integer = upperBound6
								If arg_4BB_0 > num Then
									Exit While
								End If
								mPts3(j4 - k2) = mPts(j4)
								j4 += 1
							End While
							flag = (modBanDo.AngleToPoint(mPTs2(0), mPts3(1)) > mA0)
							If flag Then
								Dim l4 As Integer = mPTS4O.GetUpperBound(0)
								mPTS4O = CType(Utils.CopyArray(CType(mPTS4O, Array), New PointF(l4 + mPts3.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
								Dim arg_521_0 As Integer = 0
								Dim upperBound7 As Integer = mPts3.GetUpperBound(0)
								Dim j5 As Integer = arg_521_0
								While True
									Dim arg_555_0 As Integer = j5
									Dim num As Integer = upperBound7
									If arg_555_0 > num Then
										Exit While
									End If
									mPTS4O(j5 + l4 + 1) = mPts3(j5)
									j5 += 1
								End While
							Else
								Dim l5 As Integer = mPTS4O2.GetUpperBound(0)
								mPTS4O2 = CType(Utils.CopyArray(CType(mPTS4O2, Array), New PointF(l5 + mPts3.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
								Dim arg_596_0 As Integer = 0
								Dim upperBound8 As Integer = mPts3.GetUpperBound(0)
								Dim j6 As Integer = arg_596_0
								While True
									Dim arg_5CA_0 As Integer = j6
									Dim num As Integer = upperBound8
									If arg_5CA_0 > num Then
										Exit While
									End If
									mPTS4O2(j6 + l5 + 1) = mPts3(j6)
									j6 += 1
								End While
							End If
							Dim mObject As CurveGraphic = CType(mObj2.Clone(), CurveGraphic)
							mObject.Nodes.Clear()
							Dim arg_5F3_0 As Integer = 0
							Dim upperBound9 As Integer = mPTS4O.GetUpperBound(0)
							Dim j7 As Integer = arg_5F3_0
							While True
								Dim arg_633_0 As Integer = j7
								Dim num As Integer = upperBound9
								If arg_633_0 > num Then
									Exit While
								End If
								Dim mNode As CNODE = New CNODE(mPTS4O(j7))
								mNode.IsControl = True
								mObject.Nodes.Add(mNode)
								j7 += 1
							End While
							mGObjs.Add(mObject)
							Dim mObject2 As CurveGraphic = CType(mObj2.Clone(), CurveGraphic)
							mObject2.Nodes.Clear()
							Dim arg_664_0 As Integer = 0
							Dim upperBound10 As Integer = mPTS4O2.GetUpperBound(0)
							Dim j8 As Integer = arg_664_0
							While True
								Dim arg_6A4_0 As Integer = j8
								Dim num As Integer = upperBound10
								If arg_6A4_0 > num Then
									Exit While
								End If
								Dim mNode2 As CNODE = New CNODE(mPTS4O2(j8))
								mNode2.IsControl = True
								mObject2.Nodes.Add(mNode2)
								j8 += 1
							End While
							mGObjs2.Add(mObject2)
						Else
							flag = (modBanDo.AngleToPoint(mPTs2(0), mPTs3(0)) > mA0)
							If flag Then
								mGObjs.Add(mObj)
							Else
								mGObjs2.Add(mObj)
							End If
						End If
					Else
						flag = (mObj2.GetObjType() = OBJECTTYPE.ClosedCurve)
						If flag Then
							Dim mPTs4 As PointF() = mObj2.GetPoints()
							Dim iDim As Integer = mPTs4.GetUpperBound(0)
							mPTs4 = CType(Utils.CopyArray(CType(mPTs4, Array), New PointF(iDim + 1 + 1 - 1) {}), PointF())
							mPTs4(iDim + 1) = mPTs4(0)
							Dim mINTERSECTNODEs2 As modBanDo.INTERSECTNODE() = modBanDo.GetIntersectPoints(mPTs2(0), mPTs2(1), mPTs4)
							mPTs4 = CType(Utils.CopyArray(CType(mPTs4, Array), New PointF(iDim + 1 - 1) {}), PointF())
							flag = (mINTERSECTNODEs2.GetUpperBound(0) > 0)
							If flag Then
								Dim mPTS4O3 As PointF() = New PointF(-1) {}
								Dim mPTS4O4 As PointF() = New PointF(-1) {}
								Dim arg_7C7_0 As Integer = 0
								Dim num2 As Integer = mINTERSECTNODEs2.GetUpperBound(0) - 1
								Dim i2 As Integer = arg_7C7_0
								While True
									Dim arg_9B1_0 As Integer = i2
									Dim num As Integer = num2
									If arg_9B1_0 > num Then
										Exit While
									End If
									Dim k3 As Integer = mINTERSECTNODEs2(i2).NodeIndex
									Dim mPts4 As PointF() = New PointF(mINTERSECTNODEs2(i2 + 1).NodeIndex - k3 + 1 + 1 - 1) {}
									mPts4(0) = mINTERSECTNODEs2(i2).PT
									Dim arg_82D_0 As Integer = 1
									Dim num3 As Integer = mINTERSECTNODEs2(i2 + 1).NodeIndex - k3
									Dim j9 As Integer = arg_82D_0
									While True
										Dim arg_85F_0 As Integer = j9
										num = num3
										If arg_85F_0 > num Then
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
										Dim arg_8F6_0 As Integer = 0
										Dim upperBound11 As Integer = mPts4.GetUpperBound(0)
										Dim j10 As Integer = arg_8F6_0
										While True
											Dim arg_92A_0 As Integer = j10
											num = upperBound11
											If arg_92A_0 > num Then
												Exit While
											End If
											mPTS4O3(j10 + l6 + 1) = mPts4(j10)
											j10 += 1
										End While
									Else
										Dim l7 As Integer = mPTS4O4.GetUpperBound(0)
										mPTS4O4 = CType(Utils.CopyArray(CType(mPTS4O4, Array), New PointF(l7 + mPts4.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
										Dim arg_96B_0 As Integer = 0
										Dim upperBound12 As Integer = mPts4.GetUpperBound(0)
										Dim j11 As Integer = arg_96B_0
										While True
											Dim arg_99F_0 As Integer = j11
											num = upperBound12
											If arg_99F_0 > num Then
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
								Dim arg_A24_0 As Integer = 1
								Dim num4 As Integer = l8
								Dim j12 As Integer = arg_A24_0
								While True
									Dim arg_A56_0 As Integer = j12
									Dim num As Integer = num4
									If arg_A56_0 > num Then
										Exit While
									End If
									mPts5(j12) = mPTs4(k4 + j12)
									j12 += 1
								End While
								Dim arg_A5F_0 As Integer = 0
								Dim num5 As Integer = l9 - 1
								Dim j13 As Integer = arg_A5F_0
								While True
									Dim arg_A93_0 As Integer = j13
									Dim num As Integer = num5
									If arg_A93_0 > num Then
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
									Dim arg_B19_0 As Integer = 0
									Dim upperBound13 As Integer = mPts5.GetUpperBound(0)
									Dim j14 As Integer = arg_B19_0
									While True
										Dim arg_B4D_0 As Integer = j14
										Dim num As Integer = upperBound13
										If arg_B4D_0 > num Then
											Exit While
										End If
										mPTS4O3(j14 + l10 + 1) = mPts5(j14)
										j14 += 1
									End While
								Else
									Dim l11 As Integer = mPTS4O4.GetUpperBound(0)
									mPTS4O4 = CType(Utils.CopyArray(CType(mPTS4O4, Array), New PointF(l11 + mPts5.GetUpperBound(0) + 1 + 1 - 1) {}), PointF())
									Dim arg_B8E_0 As Integer = 0
									Dim upperBound14 As Integer = mPts5.GetUpperBound(0)
									Dim j15 As Integer = arg_B8E_0
									While True
										Dim arg_BC2_0 As Integer = j15
										Dim num As Integer = upperBound14
										If arg_BC2_0 > num Then
											Exit While
										End If
										mPTS4O4(j15 + l11 + 1) = mPts5(j15)
										j15 += 1
									End While
								End If
								Dim mObject3 As ClosedCurveGraphic = CType(mObj2.Clone(), ClosedCurveGraphic)
								mObject3.Nodes.Clear()
								Dim arg_BEB_0 As Integer = 0
								Dim upperBound15 As Integer = mPTS4O3.GetUpperBound(0)
								Dim j16 As Integer = arg_BEB_0
								While True
									Dim arg_C2B_0 As Integer = j16
									Dim num As Integer = upperBound15
									If arg_C2B_0 > num Then
										Exit While
									End If
									Dim mNode3 As CNODE = New CNODE(mPTS4O3(j16))
									mNode3.IsControl = True
									mObject3.Nodes.Add(mNode3)
									j16 += 1
								End While
								mGObjs.Add(mObject3)
								Dim mObject4 As ClosedCurveGraphic = CType(mObj2.Clone(), ClosedCurveGraphic)
								mObject4.Nodes.Clear()
								Dim arg_C5C_0 As Integer = 0
								Dim upperBound16 As Integer = mPTS4O4.GetUpperBound(0)
								Dim j17 As Integer = arg_C5C_0
								While True
									Dim arg_C9C_0 As Integer = j17
									Dim num As Integer = upperBound16
									If arg_C9C_0 > num Then
										Exit While
									End If
									Dim mNode4 As CNODE = New CNODE(mPTS4O4(j17))
									mNode4.IsControl = True
									mObject4.Nodes.Add(mNode4)
									j17 += 1
								End While
								mGObjs2.Add(mObject4)
							Else
								flag = (modBanDo.AngleToPoint(mPTs2(0), mPTs4(0)) > mA0)
								If flag Then
									mGObjs.Add(mObj)
								Else
									mGObjs2.Add(mObj)
								End If
							End If
						Else
							Dim mPTs5 As PointF() = mObj.GetPoints()
							flag = (modBanDo.AngleToPoint(mPTs2(0), mPTs5(0)) > mA0)
							If flag Then
								mGObjs.Add(mObj)
							Else
								mGObjs2.Add(mObj)
							End If
						End If
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			flag = (mGObjs.Count > 0)
			Dim objSymbol As CSymbol
			If flag Then
				objSymbol = New CSymbol(pSymbol.Description, False, pSymbol.Zoom, pSymbol.MWidth, pSymbol.GocX, pSymbol.GocY, mGObjs)
			Else
				objSymbol = Nothing
			End If
			flag = (mGObjs2.Count > 0)
			Dim objSymbol2 As CSymbol
			If flag Then
				objSymbol2 = New CSymbol(pSymbol.Description, False, pSymbol.Zoom, pSymbol.MWidth, pSymbol.GocX, pSymbol.GocY, mGObjs2)
			Else
				objSymbol2 = Nothing
			End If
			mSPLITSYMBOLS.Symbol1 = objSymbol
			mSPLITSYMBOLS.Symbol2 = objSymbol2
			Return mSPLITSYMBOLS
		End Function

		Private Function ToCurve(pSymbol As CSymbol) As CSymbol
			Dim mGObjs As CGraphicObjs = New CGraphicObjs()
			Dim flag As Boolean
			Try
				Dim enumerator As IEnumerator = pSymbol.GObjs.GetEnumerator()
				While enumerator.MoveNext()
					Dim mObj As GraphicObject = CType(enumerator.Current, GraphicObject)
					flag = (mObj.GetObjType() = OBJECTTYPE.Curve Or mObj.GetObjType() = OBJECTTYPE.ClosedCurve)
					If flag Then
						mGObjs.Add(mObj)
					Else
						mGObjs.Add(modBanDo.ObjToCurve(mObj))
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			flag = (mGObjs.Count > 0)
			Dim objSymbol As CSymbol
			If flag Then
				objSymbol = New CSymbol("", False, pSymbol.Zoom, pSymbol.MWidth, pSymbol.GocX, pSymbol.GocY, mGObjs)
			Else
				objSymbol = Nothing
			End If
			Return objSymbol
		End Function

		Private Sub MnuToCurve_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Dim mSymbol As CSymbol = Me.ToCurve(Me.m_SelectedSymbol)
			Dim flag As Boolean = Not Information.IsNothing(mSymbol)
			If flag Then
				Me.m_DrawingSymbols.Remove(Me.m_SelectedSymbol)
				Me.m_DrawingSymbols.Add(mSymbol)
				Me.m_SelectedSymbol = mSymbol
			End If
			Me.OnCapNhatKH()
		End Sub

		Public Sub PopUndo()
			Dim flag As Boolean = Me.m_ParentForm Is Me.m_ParentForm
			If flag Then
				Me.m_ParentForm.myDirty = True
			End If
			Me.PopUndo0()
			Me.XoaRedoStack()
		End Sub

		Public Sub PopUndo0()
			Dim mSymbols As CSymbols = New CSymbols()
			Dim mSeleSymbol As CSymbol
			Try
				Dim enumerator As IEnumerator = Me.m_DrawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Dim mCloneSymbol As CSymbol = New CSymbol(mSymbol.Description, mSymbol.Blinking, mSymbol.Zoom, mSymbol.MWidth, mSymbol.GocX, mSymbol.GocY, mSymbol.GObjs)
					mSymbols.Add(mCloneSymbol)
					Dim flag As Boolean = mSymbol Is Me.m_SelectedSymbol
					If flag Then
						mSeleSymbol = mCloneSymbol
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = Me.iUndo < modBanDo.defaUndosNo - 1
			If flag Then
				Me.iUndo += 1
			Else
				Dim arg_D1_0 As Integer = 0
				Dim num As Integer = modBanDo.defaUndosNo - 2
				Dim i As Integer = arg_D1_0
				While True
					Dim arg_108_0 As Integer = i
					Dim num2 As Integer = num
					If arg_108_0 > num2 Then
						Exit While
					End If
					modBanDo.stackUnDos(i) = modBanDo.stackUnDos(i + 1)
					i += 1
				End While
				Me.iUndo = modBanDo.defaUndosNo - 1
			End If
			modBanDo.stackUnDos(Me.iUndo).UndoSymbols = mSymbols
			modBanDo.stackUnDos(Me.iUndo).MapX = Me.m_Map.CenterX
			modBanDo.stackUnDos(Me.iUndo).MapY = Me.m_Map.CenterY
			modBanDo.stackUnDos(Me.iUndo).SeleSymbol = mSeleSymbol
			Me.m_ParentForm.UndoToolStripButton.Enabled = True
		End Sub

		Private Function PushUndo() As modBanDo.UNDOITEM
			Dim flag As Boolean = Me.iUndo > -1 And Me.iUndo < modBanDo.defaUndosNo
			' The following expression was wrapped in a checked-statement
			Dim PushUndo As modBanDo.UNDOITEM
			If flag Then
				Me.PopRedo()
				Dim mUndoItem As modBanDo.UNDOITEM = modBanDo.stackUnDos(Me.iUndo)
				Me.iUndo -= 1
				flag = (Me.iUndo < 0)
				If flag Then
					Me.m_ParentForm.UndoToolStripButton.Enabled = False
				End If
				PushUndo = mUndoItem
			Else
				flag = (Me.iUndo < 0)
				If flag Then
					Me.m_ParentForm.UndoToolStripButton.Enabled = False
				End If
				Dim uNDOITEM As modBanDo.UNDOITEM
				PushUndo = uNDOITEM
			End If
			Return PushUndo
		End Function

		Private Sub PopRedo()
			Dim mSymbols As CSymbols = New CSymbols()
			Dim mSeleSymbol As CSymbol
			Try
				Dim enumerator As IEnumerator = Me.m_DrawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					Dim mCloneSymbol As CSymbol = New CSymbol(mSymbol.Description, mSymbol.Blinking, mSymbol.Zoom, mSymbol.MWidth, mSymbol.GocX, mSymbol.GocY, mSymbol.GObjs)
					mSymbols.Add(mCloneSymbol)
					Dim flag As Boolean = mSymbol Is Me.m_SelectedSymbol
					If flag Then
						mSeleSymbol = mCloneSymbol
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = Me.iRedo < modBanDo.defaUndosNo - 1
			If flag Then
				Me.iRedo += 1
			Else
				Dim arg_D1_0 As Integer = 0
				Dim num As Integer = modBanDo.defaUndosNo - 2
				Dim i As Integer = arg_D1_0
				While True
					Dim arg_108_0 As Integer = i
					Dim num2 As Integer = num
					If arg_108_0 > num2 Then
						Exit While
					End If
					modBanDo.stackReDos(i) = modBanDo.stackReDos(i + 1)
					i += 1
				End While
				Me.iRedo = modBanDo.defaUndosNo - 1
			End If
			modBanDo.stackReDos(Me.iRedo).UndoSymbols = mSymbols
			modBanDo.stackReDos(Me.iRedo).MapX = Me.m_Map.CenterX
			modBanDo.stackReDos(Me.iRedo).MapY = Me.m_Map.CenterY
			modBanDo.stackReDos(Me.iRedo).SeleSymbol = mSeleSymbol
			Me.m_ParentForm.RedoToolStripButton.Enabled = True
		End Sub

		Private Function PushRedo() As modBanDo.UNDOITEM
			Dim flag As Boolean = Me.iRedo > -1 And Me.iRedo < modBanDo.defaUndosNo
			' The following expression was wrapped in a checked-statement
			Dim PushRedo As modBanDo.UNDOITEM
			If flag Then
				Me.PopUndo0()
				Dim mRedoItem As modBanDo.UNDOITEM = modBanDo.stackReDos(Me.iRedo)
				Me.iRedo -= 1
				flag = (Me.iRedo < 0)
				If flag Then
					Me.m_ParentForm.RedoToolStripButton.Enabled = False
				End If
				PushRedo = mRedoItem
			Else
				flag = (Me.iRedo < 0)
				If flag Then
					Me.m_ParentForm.RedoToolStripButton.Enabled = False
				End If
				Dim uNDOITEM As modBanDo.UNDOITEM
				PushRedo = uNDOITEM
			End If
			Return PushRedo
		End Function

		Public Sub XoaUndoStack()
			' The following expression was wrapped in a checked-statement
			modBanDo.stackUnDos = New modBanDo.UNDOITEM(modBanDo.defaUndosNo - 1 + 1 - 1) {}
			modBanDo.stackReDos = New modBanDo.UNDOITEM(modBanDo.defaUndosNo - 1 + 1 - 1) {}
			Me.iUndo = -1
			Me.m_ParentForm.UndoToolStripButton.Enabled = False
			Me.iRedo = -1
			Me.m_ParentForm.RedoToolStripButton.Enabled = False
		End Sub

		Private Sub XoaRedoStack()
			Me.iRedo = -1
			Me.m_ParentForm.RedoToolStripButton.Enabled = False
		End Sub

		Private Sub MnuGrChangeColor_Click(sender As Object, e As EventArgs)
			New dlgChangeSymbol() With { .Symbols = Me.m_SelectedSymbols }.ShowDialog(Me.m_ParentForm)
		End Sub

		Private Sub MnuGrMove_Click(sender As Object, e As EventArgs)
			Me.myMapTool = CBanDo.MapTools.GrMove
			Me.m_ParentForm.ToolStripStatusLabel3.Text = "Move: di chu" & ChrW(7897) & "t " & ChrW(273) & ChrW(7875) & " di chuy" & ChrW(7875) & "n nhóm KH."
		End Sub

		Public Sub Zoom1X()
			Me.m_Map.ZoomTo(Me.myZoom, Me.myCX, Me.myCY)
		End Sub

		Private Sub CxtMnuKyHieu_Popup(sender As Object, e As EventArgs)
			Me.m_Map.CurrentTool = ToolConstants.miArrowTool
		End Sub

		Private Sub MnuCopyToVeKH_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(modBanDo.fCacKyHieu)
			If flag Then
				Dim flag2 As Boolean = Not Information.IsNothing(Me.m_SelectedSymbol)
				If flag2 Then
					Dim mTyLe As Single = 1F / modBanDo.myTyLeLayKH
					Dim mObjs As CGraphicObjs = Me.GetTyLeGObjs(Me.m_SelectedSymbol.GObjs, mTyLe)
					Dim mSymbol As CSymbol = New CSymbol(Me.m_Map, mObjs)
					mSymbol.Description = Me.m_SelectedSymbol.Description
					modBanDo.fCacKyHieu.CopyFromMap(mSymbol)
				End If
			Else
				Interaction.MsgBox("Ph" & ChrW(7843) & "i m" & ChrW(7903) & " form Các ký hi" & ChrW(7879) & "u m" & ChrW(7899) & "i copy " & ChrW(273) & ChrW(432) & ChrW(7907) & "c...", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub MnuToPhanRa_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.TachAllObject(Me.m_SelectedSymbol)
			Me.OnCapNhatKH()
		End Sub

		Private Sub MnuTo1Object_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.FoundNode IsNot Nothing
			If flag Then
				Dim flag2 As Boolean = Me.m_SelectedSymbol.Noi2Objs(Me.FoundNode)
				If flag2 Then
					Me.m_Map.CenterX = Me.m_Map.CenterX
				Else
					Interaction.MsgBox("Khong noi duoc.", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub MnuSendFront_Click(sender As Object, e As EventArgs)
			Me.PopUndo()
			Me.m_DrawingSymbols.SendFront(Me.m_SelectedSymbol)
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub

		Private Sub MnuPartSendFront_Click(sender As Object, e As EventArgs)
			Me.FoundObject.FoundSymbol.GObjs.SendFront(Me.FoundObject.FoundObject)
			Me.m_Map.CenterX = Me.m_Map.CenterX
		End Sub
	End Class
End Namespace
