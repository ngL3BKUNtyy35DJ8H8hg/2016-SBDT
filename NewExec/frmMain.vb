Imports AxMapXLib
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports SaBan.My.Resources
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class frmMain
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		<AccessedThroughProperty("Splitter1")>
		Private _Splitter1 As Splitter

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		<AccessedThroughProperty("Splitter2")>
		Private _Splitter2 As Splitter

		<AccessedThroughProperty("lstCacKyHieu")>
		Private _lstCacKyHieu As ListBox

		<AccessedThroughProperty("lvPages")>
		Private _lvPages As ListView

		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("PagesToolStripMenuItem")>
		Private _PagesToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("NewPageToolStripMenuItem")>
		Private _NewPageToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DuplicatePageToolStripMenuItem")>
		Private _DuplicatePageToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("CheDoToolStripMenuItem")>
		Private _CheDoToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("StatusBarToolStripMenuItem")>
		Private _StatusBarToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DanhSachToolStripMenuItem")>
		Private _DanhSachToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem8")>
		Private _ToolStripMenuItem8 As ToolStripSeparator

		<AccessedThroughProperty("SaBanToolStripMenuItem")>
		Private _SaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("BdTCToolStripMenuItem")>
		Private _BdTCToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("LstKHContextMenuStrip")>
		Private _LstKHContextMenuStrip As ContextMenuStrip

		<AccessedThroughProperty("NhapNhayToolStripMenuItem")>
		Private _NhapNhayToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripSeparator

		<AccessedThroughProperty("XoaToolStripMenuItem")>
		Private _XoaToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem4")>
		Private _ToolStripMenuItem4 As ToolStripSeparator

		<AccessedThroughProperty("XoaTatToolStripMenuItem")>
		Private _XoaTatToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem5")>
		Private _ToolStripMenuItem5 As ToolStripSeparator

		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("BanDoNenToolStripMenuItem")>
		Private _BanDoNenToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator4")>
		Private _ToolStripSeparator4 As ToolStripSeparator

		<AccessedThroughProperty("ToolStripMenuCacLopBD")>
		Private _ToolStripMenuCacLopBD As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuLuuGeoSet")>
		Private _ToolStripMenuLuuGeoSet As ToolStripMenuItem

		<AccessedThroughProperty("lstPagesContextMenuStrip")>
		Private _lstPagesContextMenuStrip As ContextMenuStrip

		<AccessedThroughProperty("PageReNameToolStripMenuItem")>
		Private _PageReNameToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator5")>
		Private _ToolStripSeparator5 As ToolStripSeparator

		<AccessedThroughProperty("PageDeleteToolStripMenuItem")>
		Private _PageDeleteToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem7")>
		Private _ToolStripMenuItem7 As ToolStripSeparator

		<AccessedThroughProperty("ZoomToToolStripMenuItem")>
		Private _ZoomToToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem9")>
		Private _ToolStripMenuItem9 As ToolStripSeparator

		<AccessedThroughProperty("ShowAllToolStripMenuItem")>
		Private _ShowAllToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("Splitter3D")>
		Private _Splitter3D As Splitter

		<AccessedThroughProperty("Panel3D")>
		Private _Panel3D As Panel

		<AccessedThroughProperty("Panel2DMap")>
		Private _Panel2DMap As Panel

		<AccessedThroughProperty("AxMap1")>
		Private _AxMap1 As AxMap

		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		<AccessedThroughProperty("ToolStripStatusLabel2")>
		Private _ToolStripStatusLabel2 As ToolStripStatusLabel

		<AccessedThroughProperty("ToolStripStatusLabel3")>
		Private _ToolStripStatusLabel3 As ToolStripStatusLabel

		<AccessedThroughProperty("ToolStripStatusLabel4")>
		Private _ToolStripStatusLabel4 As ToolStripStatusLabel

		<AccessedThroughProperty("ToolStrip1")>
		Private _ToolStrip1 As ToolStrip

		<AccessedThroughProperty("SelectorToolStripButton")>
		Private _SelectorToolStripButton As ToolStripButton

		<AccessedThroughProperty("PanToolStripButton")>
		Private _PanToolStripButton As ToolStripButton

		<AccessedThroughProperty("ZoomInToolStripButton")>
		Private _ZoomInToolStripButton As ToolStripButton

		<AccessedThroughProperty("ZoomOutToolStripButton")>
		Private _ZoomOutToolStripButton As ToolStripButton

		<AccessedThroughProperty("Zoom1XToolStripButton")>
		Private _Zoom1XToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("CNToolStripButton")>
		Private _CNToolStripButton As ToolStripButton

		<AccessedThroughProperty("SymbolToolStripButton")>
		Private _SymbolToolStripButton As ToolStripButton

		<AccessedThroughProperty("UndoToolStripButton")>
		Private _UndoToolStripButton As ToolStripButton

		<AccessedThroughProperty("RedoToolStripButton")>
		Private _RedoToolStripButton As ToolStripButton

		<AccessedThroughProperty("MuiTenDonToolStripButton")>
		Private _MuiTenDonToolStripButton As ToolStripButton

		<AccessedThroughProperty("ClosedCurveToolStripButton")>
		Private _ClosedCurveToolStripButton As ToolStripButton

		<AccessedThroughProperty("CurveToolStripSplitButton")>
		Private _CurveToolStripSplitButton As ToolStripSplitButton

		<AccessedThroughProperty("SongSongKinToolStripButton")>
		Private _SongSongKinToolStripButton As ToolStripButton

		<AccessedThroughProperty("LineToolStripButton")>
		Private _LineToolStripButton As ToolStripButton

		<AccessedThroughProperty("PolygonToolStripButton")>
		Private _PolygonToolStripButton As ToolStripButton

		<AccessedThroughProperty("RectangleToolStripButton")>
		Private _RectangleToolStripButton As ToolStripButton

		<AccessedThroughProperty("EllipseToolStripButton")>
		Private _EllipseToolStripButton As ToolStripButton

		<AccessedThroughProperty("TextToolStripButton")>
		Private _TextToolStripButton As ToolStripButton

		<AccessedThroughProperty("TableToolStripButton")>
		Private _TableToolStripButton As ToolStripButton

		<AccessedThroughProperty("OptionsToolStripButton")>
		Private _OptionsToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStrip2")>
		Private _ToolStrip2 As ToolStrip

		<AccessedThroughProperty("Symbol3DHideToolStripButton")>
		Private _Symbol3DHideToolStripButton As ToolStripButton

		<AccessedThroughProperty("Symbol3DDrawToolStripButton")>
		Private _Symbol3DDrawToolStripButton As ToolStripButton

		<AccessedThroughProperty("PhanLoaiKyHieuToolStripMenuItem")>
		Private _PhanLoaiKyHieuToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("MuiTenDacToolStripButton")>
		Private _MuiTenDacToolStripButton As ToolStripButton

		<AccessedThroughProperty("ArcToolStripButton")>
		Private _ArcToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStripStatusLabel5")>
		Private _ToolStripStatusLabel5 As ToolStripStatusLabel

		<AccessedThroughProperty("RullerToolStripButton")>
		Private _RullerToolStripButton As ToolStripButton

		<AccessedThroughProperty("Symbol3DDemoToolStripMenuItem")>
		Private _Symbol3DDemoToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("Symbol3DScriptsEditToolStripMenuItem")>
		Private _Symbol3DScriptsEditToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("Symbol3DShowToolStripMenuItem")>
		Private _Symbol3DShowToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("btnTimKH")>
		Private _btnTimKH As Button

		<AccessedThroughProperty("txtName")>
		Private _txtName As TextBox

		<AccessedThroughProperty("LoadDiaHinhToolStripMenuItem")>
		Private _LoadDiaHinhToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator3")>
		Private _ToolStripSeparator3 As ToolStripSeparator

		<AccessedThroughProperty("BdTCDefToolStripButton")>
		Private _BdTCDefToolStripButton As ToolStripButton

		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator8")>
		Private _ToolStripSeparator8 As ToolStripSeparator

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("ToJPGToolStripMenuItem")>
		Private _ToJPGToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripSeparator

		<AccessedThroughProperty("OLuoiJumpToToolStripMenuItem")>
		Private _OLuoiJumpToToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("OLuoiDefToolStripMenuItem")>
		Private _OLuoiDefToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuBDView")>
		Private _ToolStripMenuBDView As ToolStripMenuItem

		<AccessedThroughProperty("ShiftAllToolStripMenuItem")>
		Private _ShiftAllToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator6")>
		Private _ToolStripSeparator6 As ToolStripSeparator

		Public myTerrain As CDiaHinh

		Private m_bNewBdTC As Boolean

		Public myVeActs As CVeActs

		<AccessedThroughProperty("myBando")>
		Private _myBando As CBdTC

		Public myBanDoNen As CBanDoNen

		Public bBanDo2Loaded As Boolean

		Friend myPages As CPages

		Private CurrPage As CPage

		Private bLoaded As Boolean

		Public myDirty As Boolean

		Public lyrCacKyHieu As Layer

		Friend Overridable Property MenuStrip1() As MenuStrip
			Get
				Return Me._MenuStrip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
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

		Friend Overridable Property Splitter1() As Splitter
			Get
				Return Me._Splitter1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter1 = value
			End Set
		End Property

		Friend Overridable Property Panel2() As Panel
			Get
				Return Me._Panel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
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

		Friend Overridable Property Splitter2() As Splitter
			Get
				Return Me._Splitter2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter2 = value
			End Set
		End Property

		Friend Overridable Property lstCacKyHieu() As ListBox
			Get
				Return Me._lstCacKyHieu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstCacKyHieu_DoubleClick
				Dim value3 As EventHandler = AddressOf Me.lstCacKyHieu_Click
				If Me._lstCacKyHieu IsNot Nothing Then
					RemoveHandler Me._lstCacKyHieu.DoubleClick, value2
					RemoveHandler Me._lstCacKyHieu.Click, value3
				End If
				Me._lstCacKyHieu = value
				If Me._lstCacKyHieu IsNot Nothing Then
					AddHandler Me._lstCacKyHieu.DoubleClick, value2
					AddHandler Me._lstCacKyHieu.Click, value3
				End If
			End Set
		End Property

		Friend Overridable Property lvPages() As ListView
			Get
				Return Me._lvPages
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As ItemDragEventHandler = AddressOf Me.lvPages_ItemDrag
				Dim value3 As DragEventHandler = AddressOf Me.lvPages_DragEnter
				Dim value4 As DragEventHandler = AddressOf Me.lvPages_DragDrop
				Dim value5 As EventHandler = AddressOf Me.lvPages_Click
				Dim value6 As LabelEditEventHandler = AddressOf Me.lvPages_AfterLabelEdit
				If Me._lvPages IsNot Nothing Then
					RemoveHandler Me._lvPages.ItemDrag, value2
					RemoveHandler Me._lvPages.DragEnter, value3
					RemoveHandler Me._lvPages.DragDrop, value4
					RemoveHandler Me._lvPages.Click, value5
					RemoveHandler Me._lvPages.AfterLabelEdit, value6
				End If
				Me._lvPages = value
				If Me._lvPages IsNot Nothing Then
					AddHandler Me._lvPages.ItemDrag, value2
					AddHandler Me._lvPages.DragEnter, value3
					AddHandler Me._lvPages.DragDrop, value4
					AddHandler Me._lvPages.Click, value5
					AddHandler Me._lvPages.AfterLabelEdit, value6
				End If
			End Set
		End Property

		Friend Overridable Property FileToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._FileToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FileToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property PagesToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._PagesToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PagesToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property NewPageToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._NewPageToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewPageToolStripMenuItem_Click
				If Me._NewPageToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewPageToolStripMenuItem.Click, value2
				End If
				Me._NewPageToolStripMenuItem = value
				If Me._NewPageToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewPageToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DuplicatePageToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DuplicatePageToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DuplicatePageToolStripMenuItem_Click
				If Me._DuplicatePageToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DuplicatePageToolStripMenuItem.Click, value2
				End If
				Me._DuplicatePageToolStripMenuItem = value
				If Me._DuplicatePageToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DuplicatePageToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property CheDoToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._CheDoToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._CheDoToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property StatusBarToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._StatusBarToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StatusBarToolStripMenuItem_Click
				Dim value3 As EventHandler = AddressOf Me.StatusBarToolStripMenuItem_CheckStateChanged
				If Me._StatusBarToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._StatusBarToolStripMenuItem.Click, value2
					RemoveHandler Me._StatusBarToolStripMenuItem.CheckStateChanged, value3
				End If
				Me._StatusBarToolStripMenuItem = value
				If Me._StatusBarToolStripMenuItem IsNot Nothing Then
					AddHandler Me._StatusBarToolStripMenuItem.Click, value2
					AddHandler Me._StatusBarToolStripMenuItem.CheckStateChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property DanhSachToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DanhSachToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DanhSachToolStripMenuItem_Click
				Dim value3 As EventHandler = AddressOf Me.DanhSachToolStripMenuItem_CheckStateChanged
				If Me._DanhSachToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DanhSachToolStripMenuItem.Click, value2
					RemoveHandler Me._DanhSachToolStripMenuItem.CheckStateChanged, value3
				End If
				Me._DanhSachToolStripMenuItem = value
				If Me._DanhSachToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DanhSachToolStripMenuItem.Click, value2
					AddHandler Me._DanhSachToolStripMenuItem.CheckStateChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem8() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem8 = value
			End Set
		End Property

		Friend Overridable Property SaBanToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._SaBanToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaBanToolStripMenuItem_Click
				Dim value3 As EventHandler = AddressOf Me.SaBanToolStripMenuItem_CheckStateChanged
				If Me._SaBanToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SaBanToolStripMenuItem.Click, value2
					RemoveHandler Me._SaBanToolStripMenuItem.CheckStateChanged, value3
				End If
				Me._SaBanToolStripMenuItem = value
				If Me._SaBanToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SaBanToolStripMenuItem.Click, value2
					AddHandler Me._SaBanToolStripMenuItem.CheckStateChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property BdTCToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._BdTCToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.BdTCToolStripMenuItem_Click
				Dim value3 As EventHandler = AddressOf Me.BdTCToolStripMenuItem_CheckStateChanged
				If Me._BdTCToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._BdTCToolStripMenuItem.Click, value2
					RemoveHandler Me._BdTCToolStripMenuItem.CheckStateChanged, value3
				End If
				Me._BdTCToolStripMenuItem = value
				If Me._BdTCToolStripMenuItem IsNot Nothing Then
					AddHandler Me._BdTCToolStripMenuItem.Click, value2
					AddHandler Me._BdTCToolStripMenuItem.CheckStateChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property LstKHContextMenuStrip() As ContextMenuStrip
			Get
				Return Me._LstKHContextMenuStrip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._LstKHContextMenuStrip = value
			End Set
		End Property

		Friend Overridable Property NhapNhayToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._NhapNhayToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NhapNhayToolStripMenuItem_Click
				If Me._NhapNhayToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NhapNhayToolStripMenuItem.Click, value2
				End If
				Me._NhapNhayToolStripMenuItem = value
				If Me._NhapNhayToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NhapNhayToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem3() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem3 = value
			End Set
		End Property

		Friend Overridable Property XoaToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._XoaToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.XoaToolStripMenuItem_Click
				If Me._XoaToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._XoaToolStripMenuItem.Click, value2
				End If
				Me._XoaToolStripMenuItem = value
				If Me._XoaToolStripMenuItem IsNot Nothing Then
					AddHandler Me._XoaToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem4() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem4 = value
			End Set
		End Property

		Friend Overridable Property XoaTatToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._XoaTatToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.XoaTatToolStripMenuItem_Click
				If Me._XoaTatToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._XoaTatToolStripMenuItem.Click, value2
				End If
				Me._XoaTatToolStripMenuItem = value
				If Me._XoaTatToolStripMenuItem IsNot Nothing Then
					AddHandler Me._XoaTatToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem5() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem5 = value
			End Set
		End Property

		Friend Overridable Property RenameToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				If Me._RenameToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RenameToolStripMenuItem.Click, value2
				End If
				Me._RenameToolStripMenuItem = value
				If Me._RenameToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RenameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property BanDoNenToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._BanDoNenToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._BanDoNenToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator4() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator4 = value
			End Set
		End Property

		Friend Overridable Property ToolStripMenuCacLopBD() As ToolStripMenuItem
			Get
				Return Me._ToolStripMenuCacLopBD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuCacLopBD_Click
				If Me._ToolStripMenuCacLopBD IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuCacLopBD.Click, value2
				End If
				Me._ToolStripMenuCacLopBD = value
				If Me._ToolStripMenuCacLopBD IsNot Nothing Then
					AddHandler Me._ToolStripMenuCacLopBD.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuLuuGeoSet() As ToolStripMenuItem
			Get
				Return Me._ToolStripMenuLuuGeoSet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuLuuGeoSet_Click
				If Me._ToolStripMenuLuuGeoSet IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuLuuGeoSet.Click, value2
				End If
				Me._ToolStripMenuLuuGeoSet = value
				If Me._ToolStripMenuLuuGeoSet IsNot Nothing Then
					AddHandler Me._ToolStripMenuLuuGeoSet.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lstPagesContextMenuStrip() As ContextMenuStrip
			Get
				Return Me._lstPagesContextMenuStrip
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._lstPagesContextMenuStrip = value
			End Set
		End Property

		Friend Overridable Property PageReNameToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._PageReNameToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PageReNameToolStripMenuItem_Click
				If Me._PageReNameToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PageReNameToolStripMenuItem.Click, value2
				End If
				Me._PageReNameToolStripMenuItem = value
				If Me._PageReNameToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PageReNameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator5() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator5 = value
			End Set
		End Property

		Friend Overridable Property PageDeleteToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._PageDeleteToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PageDeleteToolStripMenuItem_Click
				If Me._PageDeleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PageDeleteToolStripMenuItem.Click, value2
				End If
				Me._PageDeleteToolStripMenuItem = value
				If Me._PageDeleteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PageDeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem7() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem7 = value
			End Set
		End Property

		Friend Overridable Property ZoomToToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._ZoomToToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ZoomToToolStripMenuItem_Click
				If Me._ZoomToToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ZoomToToolStripMenuItem.Click, value2
				End If
				Me._ZoomToToolStripMenuItem = value
				If Me._ZoomToToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ZoomToToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem9() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem9 = value
			End Set
		End Property

		Friend Overridable Property ShowAllToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._ShowAllToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ShowAllToolStripMenuItem_Click
				If Me._ShowAllToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ShowAllToolStripMenuItem.Click, value2
				End If
				Me._ShowAllToolStripMenuItem = value
				If Me._ShowAllToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ShowAllToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Splitter3D() As Splitter
			Get
				Return Me._Splitter3D
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter3D = value
			End Set
		End Property

		Friend Overridable Property Panel3D() As Panel
			Get
				Return Me._Panel3D
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As MouseEventHandler = AddressOf Me.Panel3D_MouseClick
				If Me._Panel3D IsNot Nothing Then
					RemoveHandler Me._Panel3D.MouseClick, value2
				End If
				Me._Panel3D = value
				If Me._Panel3D IsNot Nothing Then
					AddHandler Me._Panel3D.MouseClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property Panel2DMap() As Panel
			Get
				Return Me._Panel2DMap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2DMap = value
			End Set
		End Property

		Friend Overridable Property AxMap1() As AxMap
			Get
				Return Me._AxMap1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxMap)
				Dim value2 As AxMapXLib.CMapXEvents_MouseUpEventHandler = AddressOf Me.AxMap1_MouseUpEvent
				Dim value3 As AxMapXLib.CMapXEvents_MouseMoveEventHandler = AddressOf Me.AxMap1_MouseMoveEvent
				Dim value4 As AxMapXLib.CMapXEvents_MouseDownEventHandler = AddressOf Me.AxMap1_MouseDownEvent
				Dim value5 As AxMapXLib.CMapXEvents_ToolUsedEventHandler = AddressOf Me.AxMap1_ToolUsed
				Dim value6 As EventHandler = AddressOf Me.AxMap1_MapViewChanged
				Dim value7 As AxMapXLib.CMapXEvents_MapDrawEventHandler = AddressOf Me.AxMap1_MapDraw
				Dim value8 As AxMapXLib.CMapXEvents_KeyUpEventHandler = AddressOf Me.AxMap1_KeyUpEvent
				Dim value9 As AxMapXLib.CMapXEvents_DrawUserLayerEventHandler = AddressOf Me.AxMap1_DrawUserLayer
				If Me._AxMap1 IsNot Nothing Then
					RemoveHandler Me._AxMap1.MouseUpEvent, value2
					RemoveHandler Me._AxMap1.MouseMoveEvent, value3
					RemoveHandler Me._AxMap1.MouseDownEvent, value4
					RemoveHandler Me._AxMap1.ToolUsed, value5
					RemoveHandler Me._AxMap1.MapViewChanged, value6
					RemoveHandler Me._AxMap1.MapDraw, value7
					RemoveHandler Me._AxMap1.KeyUpEvent, value8
					RemoveHandler Me._AxMap1.DrawUserLayer, value9
				End If
				Me._AxMap1 = value
				If Me._AxMap1 IsNot Nothing Then
					AddHandler Me._AxMap1.MouseUpEvent, value2
					AddHandler Me._AxMap1.MouseMoveEvent, value3
					AddHandler Me._AxMap1.MouseDownEvent, value4
					AddHandler Me._AxMap1.ToolUsed, value5
					AddHandler Me._AxMap1.MapViewChanged, value6
					AddHandler Me._AxMap1.MapDraw, value7
					AddHandler Me._AxMap1.KeyUpEvent, value8
					AddHandler Me._AxMap1.DrawUserLayer, value9
				End If
			End Set
		End Property

		Friend Overridable Property StatusStrip1() As StatusStrip
			Get
				Return Me._StatusStrip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel1() As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel2() As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel2 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel3() As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel3 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel4() As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel4 = value
			End Set
		End Property

		Friend Overridable Property ToolStrip1() As ToolStrip
			Get
				Return Me._ToolStrip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStrip)
				Dim value2 As ToolStripItemClickedEventHandler = AddressOf Me.ToolStrip1_ItemClicked
				If Me._ToolStrip1 IsNot Nothing Then
					RemoveHandler Me._ToolStrip1.ItemClicked, value2
				End If
				Me._ToolStrip1 = value
				If Me._ToolStrip1 IsNot Nothing Then
					AddHandler Me._ToolStrip1.ItemClicked, value2
				End If
			End Set
		End Property

		Friend Overridable Property SelectorToolStripButton() As ToolStripButton
			Get
				Return Me._SelectorToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._SelectorToolStripButton = value
			End Set
		End Property

		Friend Overridable Property PanToolStripButton() As ToolStripButton
			Get
				Return Me._PanToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._PanToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ZoomInToolStripButton() As ToolStripButton
			Get
				Return Me._ZoomInToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._ZoomInToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ZoomOutToolStripButton() As ToolStripButton
			Get
				Return Me._ZoomOutToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._ZoomOutToolStripButton = value
			End Set
		End Property

		Friend Overridable Property Zoom1XToolStripButton() As ToolStripButton
			Get
				Return Me._Zoom1XToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._Zoom1XToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator1() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		Friend Overridable Property CNToolStripButton() As ToolStripButton
			Get
				Return Me._CNToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._CNToolStripButton = value
			End Set
		End Property

		Friend Overridable Property SymbolToolStripButton() As ToolStripButton
			Get
				Return Me._SymbolToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._SymbolToolStripButton = value
			End Set
		End Property

		Friend Overridable Property UndoToolStripButton() As ToolStripButton
			Get
				Return Me._UndoToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._UndoToolStripButton = value
			End Set
		End Property

		Friend Overridable Property RedoToolStripButton() As ToolStripButton
			Get
				Return Me._RedoToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._RedoToolStripButton = value
			End Set
		End Property

		Friend Overridable Property MuiTenDonToolStripButton() As ToolStripButton
			Get
				Return Me._MuiTenDonToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._MuiTenDonToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ClosedCurveToolStripButton() As ToolStripButton
			Get
				Return Me._ClosedCurveToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._ClosedCurveToolStripButton = value
			End Set
		End Property

		Friend Overridable Property CurveToolStripSplitButton() As ToolStripSplitButton
			Get
				Return Me._CurveToolStripSplitButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSplitButton)
				Me._CurveToolStripSplitButton = value
			End Set
		End Property

		Friend Overridable Property SongSongKinToolStripButton() As ToolStripButton
			Get
				Return Me._SongSongKinToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._SongSongKinToolStripButton = value
			End Set
		End Property

		Friend Overridable Property LineToolStripButton() As ToolStripButton
			Get
				Return Me._LineToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._LineToolStripButton = value
			End Set
		End Property

		Friend Overridable Property PolygonToolStripButton() As ToolStripButton
			Get
				Return Me._PolygonToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._PolygonToolStripButton = value
			End Set
		End Property

		Friend Overridable Property RectangleToolStripButton() As ToolStripButton
			Get
				Return Me._RectangleToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._RectangleToolStripButton = value
			End Set
		End Property

		Friend Overridable Property EllipseToolStripButton() As ToolStripButton
			Get
				Return Me._EllipseToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._EllipseToolStripButton = value
			End Set
		End Property

		Friend Overridable Property TextToolStripButton() As ToolStripButton
			Get
				Return Me._TextToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._TextToolStripButton = value
			End Set
		End Property

		Friend Overridable Property TableToolStripButton() As ToolStripButton
			Get
				Return Me._TableToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._TableToolStripButton = value
			End Set
		End Property

		Friend Overridable Property OptionsToolStripButton() As ToolStripButton
			Get
				Return Me._OptionsToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._OptionsToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ToolStrip2() As ToolStrip
			Get
				Return Me._ToolStrip2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStrip)
				Me._ToolStrip2 = value
			End Set
		End Property

		Friend Overridable Property Symbol3DHideToolStripButton() As ToolStripButton
			Get
				Return Me._Symbol3DHideToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.Symbol3DHideToolStripButton_Click
				If Me._Symbol3DHideToolStripButton IsNot Nothing Then
					RemoveHandler Me._Symbol3DHideToolStripButton.Click, value2
				End If
				Me._Symbol3DHideToolStripButton = value
				If Me._Symbol3DHideToolStripButton IsNot Nothing Then
					AddHandler Me._Symbol3DHideToolStripButton.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Symbol3DDrawToolStripButton() As ToolStripButton
			Get
				Return Me._Symbol3DDrawToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim value2 As EventHandler = AddressOf Me.Symbol3DDrawToolStripButton_Click
				If Me._Symbol3DDrawToolStripButton IsNot Nothing Then
					RemoveHandler Me._Symbol3DDrawToolStripButton.Click, value2
				End If
				Me._Symbol3DDrawToolStripButton = value
				If Me._Symbol3DDrawToolStripButton IsNot Nothing Then
					AddHandler Me._Symbol3DDrawToolStripButton.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property PhanLoaiKyHieuToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._PhanLoaiKyHieuToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PhanLoaiKyHieuToolStripMenuItem_Click
				If Me._PhanLoaiKyHieuToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PhanLoaiKyHieuToolStripMenuItem.Click, value2
				End If
				Me._PhanLoaiKyHieuToolStripMenuItem = value
				If Me._PhanLoaiKyHieuToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PhanLoaiKyHieuToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MuiTenDacToolStripButton() As ToolStripButton
			Get
				Return Me._MuiTenDacToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._MuiTenDacToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ArcToolStripButton() As ToolStripButton
			Get
				Return Me._ArcToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._ArcToolStripButton = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel5() As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel5 = value
			End Set
		End Property

		Friend Overridable Property RullerToolStripButton() As ToolStripButton
			Get
				Return Me._RullerToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._RullerToolStripButton = value
			End Set
		End Property

		Friend Overridable Property Symbol3DDemoToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._Symbol3DDemoToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._Symbol3DDemoToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property Symbol3DScriptsEditToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._Symbol3DScriptsEditToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.Symbol3DScriptsEditToolStripMenuItem_Click
				If Me._Symbol3DScriptsEditToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._Symbol3DScriptsEditToolStripMenuItem.Click, value2
				End If
				Me._Symbol3DScriptsEditToolStripMenuItem = value
				If Me._Symbol3DScriptsEditToolStripMenuItem IsNot Nothing Then
					AddHandler Me._Symbol3DScriptsEditToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Symbol3DShowToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._Symbol3DShowToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.Symbol3DShowToolStripMenuItem_Click
				If Me._Symbol3DShowToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._Symbol3DShowToolStripMenuItem.Click, value2
				End If
				Me._Symbol3DShowToolStripMenuItem = value
				If Me._Symbol3DShowToolStripMenuItem IsNot Nothing Then
					AddHandler Me._Symbol3DShowToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnTimKH() As Button
			Get
				Return Me._btnTimKH
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnTimKH_Click
				If Me._btnTimKH IsNot Nothing Then
					RemoveHandler Me._btnTimKH.Click, value2
				End If
				Me._btnTimKH = value
				If Me._btnTimKH IsNot Nothing Then
					AddHandler Me._btnTimKH.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtName() As TextBox
			Get
				Return Me._txtName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtName = value
			End Set
		End Property

		Friend Overridable Property LoadDiaHinhToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._LoadDiaHinhToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.LoadDiaHinhToolStripMenuItem_Click
				If Me._LoadDiaHinhToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._LoadDiaHinhToolStripMenuItem.Click, value2
				End If
				Me._LoadDiaHinhToolStripMenuItem = value
				If Me._LoadDiaHinhToolStripMenuItem IsNot Nothing Then
					AddHandler Me._LoadDiaHinhToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator3() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator3 = value
			End Set
		End Property

		Friend Overridable Property BdTCDefToolStripButton() As ToolStripButton
			Get
				Return Me._BdTCDefToolStripButton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Me._BdTCDefToolStripButton = value
			End Set
		End Property

		Friend Overridable Property NewToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._NewToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewToolStripMenuItem_Click
				If Me._NewToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewToolStripMenuItem.Click, value2
				End If
				Me._NewToolStripMenuItem = value
				If Me._NewToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property OpenToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._OpenToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenToolStripMenuItem_Click
				If Me._OpenToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenToolStripMenuItem.Click, value2
				End If
				Me._OpenToolStripMenuItem = value
				If Me._OpenToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property SaveToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaveToolStripMenuItem_Click
				If Me._SaveToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SaveToolStripMenuItem.Click, value2
				End If
				Me._SaveToolStripMenuItem = value
				If Me._SaveToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SaveToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property SaveAsToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaveAsToolStripMenuItem_Click
				If Me._SaveAsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, value2
				End If
				Me._SaveAsToolStripMenuItem = value
				If Me._SaveAsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator8() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator8 = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator2() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		Friend Overridable Property ToJPGToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._ToJPGToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToJPGToolStripMenuItem_Click
				If Me._ToJPGToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ToJPGToolStripMenuItem.Click, value2
				End If
				Me._ToJPGToolStripMenuItem = value
				If Me._ToJPGToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ToJPGToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem1() As ToolStripSeparator
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem1 = value
			End Set
		End Property

		Friend Overridable Property OLuoiJumpToToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._OLuoiJumpToToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OLuoiJumpToToolStripMenuItem_Click
				If Me._OLuoiJumpToToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OLuoiJumpToToolStripMenuItem.Click, value2
				End If
				Me._OLuoiJumpToToolStripMenuItem = value
				If Me._OLuoiJumpToToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OLuoiJumpToToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property OLuoiDefToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._OLuoiDefToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OLuoiDefToolStripMenuItem_Click
				If Me._OLuoiDefToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OLuoiDefToolStripMenuItem.Click, value2
				End If
				Me._OLuoiDefToolStripMenuItem = value
				If Me._OLuoiDefToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OLuoiDefToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuBDView() As ToolStripMenuItem
			Get
				Return Me._ToolStripMenuBDView
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ToolStripMenuBDView = value
			End Set
		End Property

		Friend Overridable Property ShiftAllToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._ShiftAllToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ShiftAllToolStripMenuItem_Click
				If Me._ShiftAllToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ShiftAllToolStripMenuItem.Click, value2
				End If
				Me._ShiftAllToolStripMenuItem = value
				If Me._ShiftAllToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ShiftAllToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator6() As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator6 = value
			End Set
		End Property

		Public WriteOnly Property bNewBdTC() As Boolean
			Set(value As Boolean)
				Me.m_bNewBdTC = value
			End Set
		End Property

		Public Overridable Property myBando() As CBdTC
			Get
				Return Me._myBando
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CBdTC)
				Dim obj As CBdTC.SelectedSymbolChangedEventHandler = AddressOf Me.myBando_SelectedSymbolChanged
				Dim obj2 As CBdTC.ListKHChangedEventHandler = AddressOf Me.myBando_ListKHChanged
				If Me._myBando IsNot Nothing Then
					RemoveHandler Me._myBando.SelectedSymbolChanged, obj
					RemoveHandler Me._myBando.ListKHChanged, obj2
				End If
				Me._myBando = value
				If Me._myBando IsNot Nothing Then
					AddHandler Me._myBando.SelectedSymbolChanged, obj
					AddHandler Me._myBando.ListKHChanged, obj2
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(frmMain))
			Me.MenuStrip1 = New MenuStrip()
			Me.FileToolStripMenuItem = New ToolStripMenuItem()
			Me.LoadDiaHinhToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator3 = New ToolStripSeparator()
			Me.PhanLoaiKyHieuToolStripMenuItem = New ToolStripMenuItem()
			Me.ShiftAllToolStripMenuItem = New ToolStripMenuItem()
			Me.BanDoNenToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuBDView = New ToolStripMenuItem()
			Me.ToolStripSeparator4 = New ToolStripSeparator()
			Me.ToolStripMenuCacLopBD = New ToolStripMenuItem()
			Me.ToolStripMenuLuuGeoSet = New ToolStripMenuItem()
			Me.ToolStripMenuItem7 = New ToolStripSeparator()
			Me.ZoomToToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem1 = New ToolStripSeparator()
			Me.OLuoiJumpToToolStripMenuItem = New ToolStripMenuItem()
			Me.OLuoiDefToolStripMenuItem = New ToolStripMenuItem()
			Me.PagesToolStripMenuItem = New ToolStripMenuItem()
			Me.NewToolStripMenuItem = New ToolStripMenuItem()
			Me.OpenToolStripMenuItem = New ToolStripMenuItem()
			Me.SaveToolStripMenuItem = New ToolStripMenuItem()
			Me.SaveAsToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator8 = New ToolStripSeparator()
			Me.NewPageToolStripMenuItem = New ToolStripMenuItem()
			Me.DuplicatePageToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.ToJPGToolStripMenuItem = New ToolStripMenuItem()
			Me.CheDoToolStripMenuItem = New ToolStripMenuItem()
			Me.BdTCToolStripMenuItem = New ToolStripMenuItem()
			Me.SaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem8 = New ToolStripSeparator()
			Me.StatusBarToolStripMenuItem = New ToolStripMenuItem()
			Me.DanhSachToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem9 = New ToolStripSeparator()
			Me.ShowAllToolStripMenuItem = New ToolStripMenuItem()
			Me.Symbol3DDemoToolStripMenuItem = New ToolStripMenuItem()
			Me.Symbol3DScriptsEditToolStripMenuItem = New ToolStripMenuItem()
			Me.Symbol3DShowToolStripMenuItem = New ToolStripMenuItem()
			Me.Panel1 = New Panel()
			Me.Panel4 = New Panel()
			Me.txtName = New TextBox()
			Me.btnTimKH = New Button()
			Me.lstCacKyHieu = New ListBox()
			Me.LstKHContextMenuStrip = New ContextMenuStrip(Me.components)
			Me.NhapNhayToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem3 = New ToolStripSeparator()
			Me.XoaToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem4 = New ToolStripSeparator()
			Me.XoaTatToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem5 = New ToolStripSeparator()
			Me.RenameToolStripMenuItem = New ToolStripMenuItem()
			Me.Splitter2 = New Splitter()
			Me.Panel3 = New Panel()
			Me.lvPages = New ListView()
			Me.lstPagesContextMenuStrip = New ContextMenuStrip(Me.components)
			Me.PageReNameToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator5 = New ToolStripSeparator()
			Me.PageDeleteToolStripMenuItem = New ToolStripMenuItem()
			Me.Splitter1 = New Splitter()
			Me.Panel2 = New Panel()
			Me.Panel2DMap = New Panel()
			Me.AxMap1 = New AxMap()
			Me.StatusStrip1 = New StatusStrip()
			Me.ToolStripStatusLabel1 = New ToolStripStatusLabel()
			Me.ToolStripStatusLabel2 = New ToolStripStatusLabel()
			Me.ToolStripStatusLabel3 = New ToolStripStatusLabel()
			Me.ToolStripStatusLabel4 = New ToolStripStatusLabel()
			Me.ToolStripStatusLabel5 = New ToolStripStatusLabel()
			Me.ToolStrip1 = New ToolStrip()
			Me.RullerToolStripButton = New ToolStripButton()
			Me.SelectorToolStripButton = New ToolStripButton()
			Me.PanToolStripButton = New ToolStripButton()
			Me.ZoomInToolStripButton = New ToolStripButton()
			Me.ZoomOutToolStripButton = New ToolStripButton()
			Me.BdTCDefToolStripButton = New ToolStripButton()
			Me.Zoom1XToolStripButton = New ToolStripButton()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.CNToolStripButton = New ToolStripButton()
			Me.SymbolToolStripButton = New ToolStripButton()
			Me.UndoToolStripButton = New ToolStripButton()
			Me.RedoToolStripButton = New ToolStripButton()
			Me.MuiTenDonToolStripButton = New ToolStripButton()
			Me.MuiTenDacToolStripButton = New ToolStripButton()
			Me.ClosedCurveToolStripButton = New ToolStripButton()
			Me.CurveToolStripSplitButton = New ToolStripSplitButton()
			Me.SongSongKinToolStripButton = New ToolStripButton()
			Me.LineToolStripButton = New ToolStripButton()
			Me.PolygonToolStripButton = New ToolStripButton()
			Me.RectangleToolStripButton = New ToolStripButton()
			Me.ArcToolStripButton = New ToolStripButton()
			Me.EllipseToolStripButton = New ToolStripButton()
			Me.TextToolStripButton = New ToolStripButton()
			Me.TableToolStripButton = New ToolStripButton()
			Me.OptionsToolStripButton = New ToolStripButton()
			Me.Splitter3D = New Splitter()
			Me.Panel3D = New Panel()
			Me.ToolStrip2 = New ToolStrip()
			Me.Symbol3DHideToolStripButton = New ToolStripButton()
			Me.Symbol3DDrawToolStripButton = New ToolStripButton()
			Me.ToolStripSeparator6 = New ToolStripSeparator()
			Me.MenuStrip1.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.Panel4.SuspendLayout()
			Me.LstKHContextMenuStrip.SuspendLayout()
			Me.Panel3.SuspendLayout()
			Me.lstPagesContextMenuStrip.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.Panel2DMap.SuspendLayout()
			(CType(Me.AxMap1, ISupportInitialize)).BeginInit()
			Me.StatusStrip1.SuspendLayout()
			Me.ToolStrip1.SuspendLayout()
			Me.Panel3D.SuspendLayout()
			Me.ToolStrip2.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.Items.AddRange(New ToolStripItem() { Me.FileToolStripMenuItem, Me.BanDoNenToolStripMenuItem, Me.PagesToolStripMenuItem, Me.CheDoToolStripMenuItem, Me.Symbol3DDemoToolStripMenuItem })
			Dim arg_552_0 As Control = Me.MenuStrip1
			Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
			arg_552_0.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim arg_57D_0 As Control = Me.MenuStrip1
			Dim size As Size = New Size(897, 24)
			arg_57D_0.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.LoadDiaHinhToolStripMenuItem, Me.ToolStripSeparator3, Me.PhanLoaiKyHieuToolStripMenuItem, Me.ToolStripSeparator6, Me.ShiftAllToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim arg_606_0 As ToolStripItem = Me.FileToolStripMenuItem
			size = New Size(41, 20)
			arg_606_0.Size = size
			Me.FileToolStripMenuItem.Text = "T" & ChrW(7879) & "p"
			Me.LoadDiaHinhToolStripMenuItem.Name = "LoadDiaHinhToolStripMenuItem"
			Dim arg_641_0 As ToolStripItem = Me.LoadDiaHinhToolStripMenuItem
			size = New Size(277, 22)
			arg_641_0.Size = size
			Me.LoadDiaHinhToolStripMenuItem.Text = "Sa bàn khác"
			Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
			Dim arg_67B_0 As ToolStripItem = Me.ToolStripSeparator3
			size = New Size(274, 6)
			arg_67B_0.Size = size
			Me.PhanLoaiKyHieuToolStripMenuItem.Name = "PhanLoaiKyHieuToolStripMenuItem"
			Dim arg_6A6_0 As ToolStripItem = Me.PhanLoaiKyHieuToolStripMenuItem
			size = New Size(277, 22)
			arg_6A6_0.Size = size
			Me.PhanLoaiKyHieuToolStripMenuItem.Text = "Các nhóm ký hi" & ChrW(7879) & "u"
			Me.ShiftAllToolStripMenuItem.Name = "ShiftAllToolStripMenuItem"
			Dim arg_6E1_0 As ToolStripItem = Me.ShiftAllToolStripMenuItem
			size = New Size(277, 22)
			arg_6E1_0.Size = size
			Me.ShiftAllToolStripMenuItem.Text = "D" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n các Ký hi" & ChrW(7879) & "u và Hi" & ChrW(7879) & "u " & ChrW(7913) & "ng"
			Me.BanDoNenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.ToolStripMenuBDView, Me.ToolStripSeparator4, Me.ToolStripMenuCacLopBD, Me.ToolStripMenuLuuGeoSet, Me.ToolStripMenuItem7, Me.ZoomToToolStripMenuItem, Me.ToolStripMenuItem1, Me.OLuoiJumpToToolStripMenuItem, Me.OLuoiDefToolStripMenuItem })
			Me.BanDoNenToolStripMenuItem.Name = "BanDoNenToolStripMenuItem"
			Dim arg_783_0 As ToolStripItem = Me.BanDoNenToolStripMenuItem
			size = New Size(82, 20)
			arg_783_0.Size = size
			Me.BanDoNenToolStripMenuItem.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7893) & " n" & ChrW(7873) & "n"
			Me.ToolStripMenuBDView.Name = "ToolStripMenuBDView"
			Dim arg_7BE_0 As ToolStripItem = Me.ToolStripMenuBDView
			size = New Size(187, 22)
			arg_7BE_0.Size = size
			Me.ToolStripMenuBDView.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " nh" & ChrW(7887)
			Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
			Dim arg_7F8_0 As ToolStripItem = Me.ToolStripSeparator4
			size = New Size(184, 6)
			arg_7F8_0.Size = size
			Me.ToolStripMenuCacLopBD.Name = "ToolStripMenuCacLopBD"
			Dim arg_823_0 As ToolStripItem = Me.ToolStripMenuCacLopBD
			size = New Size(187, 22)
			arg_823_0.Size = size
			Me.ToolStripMenuCacLopBD.Text = "Các l" & ChrW(7899) & "p B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.ToolStripMenuLuuGeoSet.Name = "ToolStripMenuLuuGeoSet"
			Dim arg_85E_0 As ToolStripItem = Me.ToolStripMenuLuuGeoSet
			size = New Size(187, 22)
			arg_85E_0.Size = size
			Me.ToolStripMenuLuuGeoSet.Text = "L" & ChrW(432) & "u c" & ChrW(7845) & "u hình B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
			Dim arg_898_0 As ToolStripItem = Me.ToolStripMenuItem7
			size = New Size(184, 6)
			arg_898_0.Size = size
			Me.ZoomToToolStripMenuItem.Name = "ZoomToToolStripMenuItem"
			Dim arg_8C3_0 As ToolStripItem = Me.ZoomToToolStripMenuItem
			size = New Size(187, 22)
			arg_8C3_0.Size = size
			Me.ZoomToToolStripMenuItem.Text = "Phóng b" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim arg_8FD_0 As ToolStripItem = Me.ToolStripMenuItem1
			size = New Size(184, 6)
			arg_8FD_0.Size = size
			Me.OLuoiJumpToToolStripMenuItem.Name = "OLuoiJumpToToolStripMenuItem"
			Dim arg_928_0 As ToolStripItem = Me.OLuoiJumpToToolStripMenuItem
			size = New Size(187, 22)
			arg_928_0.Size = size
			Me.OLuoiJumpToToolStripMenuItem.Text = "Nh" & ChrW(7849) & "y t" & ChrW(7899) & "i Ô lu" & ChrW(7899) & "i"
			Me.OLuoiDefToolStripMenuItem.Name = "OLuoiDefToolStripMenuItem"
			Dim arg_963_0 As ToolStripItem = Me.OLuoiDefToolStripMenuItem
			size = New Size(187, 22)
			arg_963_0.Size = size
			Me.OLuoiDefToolStripMenuItem.Text = "Xác l" & ChrW(7853) & "p Ô l" & ChrW(432) & ChrW(7899) & "i"
			Me.PagesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator8, Me.NewPageToolStripMenuItem, Me.DuplicatePageToolStripMenuItem, Me.ToolStripSeparator2, Me.ToJPGToolStripMenuItem })
			Me.PagesToolStripMenuItem.Name = "PagesToolStripMenuItem"
			Dim arg_A05_0 As ToolStripItem = Me.PagesToolStripMenuItem
			size = New Size(48, 20)
			arg_A05_0.Size = size
			Me.PagesToolStripMenuItem.Text = "B" & ChrW(273) & "TC"
			Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
			Dim arg_A40_0 As ToolStripItem = Me.NewToolStripMenuItem
			size = New Size(171, 22)
			arg_A40_0.Size = size
			Me.NewToolStripMenuItem.Text = "B" & ChrW(273) & "TC m" & ChrW(7899) & "i"
			Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
			Dim arg_A7B_0 As ToolStripItem = Me.OpenToolStripMenuItem
			size = New Size(171, 22)
			arg_A7B_0.Size = size
			Me.OpenToolStripMenuItem.Text = "M" & ChrW(7903) & " B" & ChrW(273) & "TC"
			Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
			Dim arg_AB6_0 As ToolStripItem = Me.SaveToolStripMenuItem
			size = New Size(171, 22)
			arg_AB6_0.Size = size
			Me.SaveToolStripMenuItem.Text = "L" & ChrW(432) & "u B" & ChrW(273) & "TC"
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Dim arg_AF1_0 As ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Size(171, 22)
			arg_AF1_0.Size = size
			Me.SaveAsToolStripMenuItem.Text = "L" & ChrW(432) & "u nh" & ChrW(432) & " ..."
			Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
			Dim arg_B2B_0 As ToolStripItem = Me.ToolStripSeparator8
			size = New Size(168, 6)
			arg_B2B_0.Size = size
			Me.NewPageToolStripMenuItem.Name = "NewPageToolStripMenuItem"
			Dim arg_B56_0 As ToolStripItem = Me.NewPageToolStripMenuItem
			size = New Size(171, 22)
			arg_B56_0.Size = size
			Me.NewPageToolStripMenuItem.Text = "Trang m" & ChrW(7899) & "i"
			Me.DuplicatePageToolStripMenuItem.Name = "DuplicatePageToolStripMenuItem"
			Dim arg_B91_0 As ToolStripItem = Me.DuplicatePageToolStripMenuItem
			size = New Size(171, 22)
			arg_B91_0.Size = size
			Me.DuplicatePageToolStripMenuItem.Text = "B" & ChrW(7843) & "n sao trang"
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim arg_BCB_0 As ToolStripItem = Me.ToolStripSeparator2
			size = New Size(168, 6)
			arg_BCB_0.Size = size
			Me.ToJPGToolStripMenuItem.Name = "ToJPGToolStripMenuItem"
			Dim arg_BF6_0 As ToolStripItem = Me.ToJPGToolStripMenuItem
			size = New Size(171, 22)
			arg_BF6_0.Size = size
			Me.ToJPGToolStripMenuItem.Text = "Xu" & ChrW(7845) & "t ra " & ChrW(7843) & "nh (JPG)"
			Me.CheDoToolStripMenuItem.Checked = True
			Me.CheDoToolStripMenuItem.CheckState = CheckState.Checked
			Me.CheDoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.BdTCToolStripMenuItem, Me.SaBanToolStripMenuItem, Me.ToolStripMenuItem8, Me.StatusBarToolStripMenuItem, Me.DanhSachToolStripMenuItem, Me.ToolStripMenuItem9, Me.ShowAllToolStripMenuItem })
			Me.CheDoToolStripMenuItem.Name = "CheDoToolStripMenuItem"
			Dim arg_C9D_0 As ToolStripItem = Me.CheDoToolStripMenuItem
			size = New Size(43, 20)
			arg_C9D_0.Size = size
			Me.CheDoToolStripMenuItem.Text = "Xem"
			Me.BdTCToolStripMenuItem.Checked = True
			Me.BdTCToolStripMenuItem.CheckState = CheckState.Checked
			Me.BdTCToolStripMenuItem.Name = "BdTCToolStripMenuItem"
			Dim arg_CF0_0 As ToolStripItem = Me.BdTCToolStripMenuItem
			size = New Size(232, 22)
			arg_CF0_0.Size = size
			Me.BdTCToolStripMenuItem.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n"
			Me.SaBanToolStripMenuItem.Checked = True
			Me.SaBanToolStripMenuItem.CheckState = CheckState.Checked
			Me.SaBanToolStripMenuItem.Name = "SaBanToolStripMenuItem"
			Dim arg_D43_0 As ToolStripItem = Me.SaBanToolStripMenuItem
			size = New Size(232, 22)
			arg_D43_0.Size = size
			Me.SaBanToolStripMenuItem.Text = ChrW(272) & ChrW(7883) & "a hình"
			Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
			Dim arg_D7D_0 As ToolStripItem = Me.ToolStripMenuItem8
			size = New Size(229, 6)
			arg_D7D_0.Size = size
			Me.StatusBarToolStripMenuItem.Checked = True
			Me.StatusBarToolStripMenuItem.CheckState = CheckState.Checked
			Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
			Dim arg_DC0_0 As ToolStripItem = Me.StatusBarToolStripMenuItem
			size = New Size(232, 22)
			arg_DC0_0.Size = size
			Me.StatusBarToolStripMenuItem.Text = "Thanh tr" & ChrW(7841) & "ng thái"
			Me.DanhSachToolStripMenuItem.Checked = True
			Me.DanhSachToolStripMenuItem.CheckState = CheckState.Checked
			Me.DanhSachToolStripMenuItem.Name = "DanhSachToolStripMenuItem"
			Dim arg_E13_0 As ToolStripItem = Me.DanhSachToolStripMenuItem
			size = New Size(232, 22)
			arg_E13_0.Size = size
			Me.DanhSachToolStripMenuItem.Text = "Danh sách các trang, ký hi" & ChrW(7879) & "u"
			Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
			Dim arg_E4D_0 As ToolStripItem = Me.ToolStripMenuItem9
			size = New Size(229, 6)
			arg_E4D_0.Size = size
			Me.ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
			Dim arg_E78_0 As ToolStripItem = Me.ShowAllToolStripMenuItem
			size = New Size(232, 22)
			arg_E78_0.Size = size
			Me.ShowAllToolStripMenuItem.Text = "Xem toàn màn hình"
			Me.Symbol3DDemoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.Symbol3DScriptsEditToolStripMenuItem, Me.Symbol3DShowToolStripMenuItem })
			Me.Symbol3DDemoToolStripMenuItem.Name = "Symbol3DDemoToolStripMenuItem"
			Dim arg_EDA_0 As ToolStripItem = Me.Symbol3DDemoToolStripMenuItem
			size = New Size(74, 20)
			arg_EDA_0.Size = size
			Me.Symbol3DDemoToolStripMenuItem.Text = "Trình di" & ChrW(7877) & "n"
			Me.Symbol3DScriptsEditToolStripMenuItem.Name = "Symbol3DScriptsEditToolStripMenuItem"
			Dim arg_F12_0 As ToolStripItem = Me.Symbol3DScriptsEditToolStripMenuItem
			size = New Size(120, 22)
			arg_F12_0.Size = size
			Me.Symbol3DScriptsEditToolStripMenuItem.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.Symbol3DShowToolStripMenuItem.Name = "Symbol3DShowToolStripMenuItem"
			Dim arg_F4A_0 As ToolStripItem = Me.Symbol3DShowToolStripMenuItem
			size = New Size(120, 22)
			arg_F4A_0.Size = size
			Me.Symbol3DShowToolStripMenuItem.Text = "Xem"
			Me.Panel1.Controls.Add(Me.Panel4)
			Me.Panel1.Controls.Add(Me.Splitter2)
			Me.Panel1.Controls.Add(Me.Panel3)
			Me.Panel1.Dock = DockStyle.Left
			Dim arg_FBE_0 As Control = Me.Panel1
			location = New System.Drawing.Point(0, 24)
			arg_FBE_0.Location = location
			Me.Panel1.Name = "Panel1"
			Dim arg_FEC_0 As Control = Me.Panel1
			size = New Size(175, 618)
			arg_FEC_0.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel4.BorderStyle = BorderStyle.Fixed3D
			Me.Panel4.Controls.Add(Me.txtName)
			Me.Panel4.Controls.Add(Me.btnTimKH)
			Me.Panel4.Controls.Add(Me.lstCacKyHieu)
			Me.Panel4.Dock = DockStyle.Fill
			Dim arg_1068_0 As Control = Me.Panel4
			location = New System.Drawing.Point(0, 119)
			arg_1068_0.Location = location
			Me.Panel4.Name = "Panel4"
			Dim arg_1096_0 As Control = Me.Panel4
			size = New Size(175, 499)
			arg_1096_0.Size = size
			Me.Panel4.TabIndex = 2
			Me.txtName.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_10C4_0 As Control = Me.txtName
			location = New System.Drawing.Point(3, 7)
			arg_10C4_0.Location = location
			Me.txtName.Name = "txtName"
			Dim arg_10EC_0 As Control = Me.txtName
			size = New Size(123, 21)
			arg_10EC_0.Size = size
			Me.txtName.TabIndex = 3
			Me.btnTimKH.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_111E_0 As Control = Me.btnTimKH
			location = New System.Drawing.Point(132, 5)
			arg_111E_0.Location = location
			Me.btnTimKH.Name = "btnTimKH"
			Dim arg_1146_0 As Control = Me.btnTimKH
			size = New Size(36, 23)
			arg_1146_0.Size = size
			Me.btnTimKH.TabIndex = 2
			Me.btnTimKH.Text = "Tìm"
			Me.btnTimKH.UseVisualStyleBackColor = True
			Me.lstCacKyHieu.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstCacKyHieu.ContextMenuStrip = Me.LstKHContextMenuStrip
			Me.lstCacKyHieu.FormattingEnabled = True
			Dim arg_11AE_0 As Control = Me.lstCacKyHieu
			location = New System.Drawing.Point(3, 36)
			arg_11AE_0.Location = location
			Me.lstCacKyHieu.Name = "lstCacKyHieu"
			Dim arg_11DC_0 As Control = Me.lstCacKyHieu
			size = New Size(164, 446)
			arg_11DC_0.Size = size
			Me.lstCacKyHieu.TabIndex = 1
			Me.LstKHContextMenuStrip.Items.AddRange(New ToolStripItem() { Me.NhapNhayToolStripMenuItem, Me.ToolStripMenuItem3, Me.XoaToolStripMenuItem, Me.ToolStripMenuItem4, Me.XoaTatToolStripMenuItem, Me.ToolStripMenuItem5, Me.RenameToolStripMenuItem })
			Me.LstKHContextMenuStrip.Name = "LstKHContextMenuStrip"
			Dim arg_126A_0 As Control = Me.LstKHContextMenuStrip
			size = New Size(172, 110)
			arg_126A_0.Size = size
			Me.NhapNhayToolStripMenuItem.Name = "NhapNhayToolStripMenuItem"
			Dim arg_1295_0 As ToolStripItem = Me.NhapNhayToolStripMenuItem
			size = New Size(171, 22)
			arg_1295_0.Size = size
			Me.NhapNhayToolStripMenuItem.Text = "Nh" & ChrW(7845) & "p nháy"
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Dim arg_12CF_0 As ToolStripItem = Me.ToolStripMenuItem3
			size = New Size(168, 6)
			arg_12CF_0.Size = size
			Me.XoaToolStripMenuItem.Name = "XoaToolStripMenuItem"
			Dim arg_12FA_0 As ToolStripItem = Me.XoaToolStripMenuItem
			size = New Size(171, 22)
			arg_12FA_0.Size = size
			Me.XoaToolStripMenuItem.Text = "Xóa"
			Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
			Dim arg_1334_0 As ToolStripItem = Me.ToolStripMenuItem4
			size = New Size(168, 6)
			arg_1334_0.Size = size
			Me.XoaTatToolStripMenuItem.Name = "XoaTatToolStripMenuItem"
			Dim arg_135F_0 As ToolStripItem = Me.XoaTatToolStripMenuItem
			size = New Size(171, 22)
			arg_135F_0.Size = size
			Me.XoaTatToolStripMenuItem.Text = "Xóa t" & ChrW(7845) & "t c" & ChrW(7843) & " các KH"
			Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
			Dim arg_1399_0 As ToolStripItem = Me.ToolStripMenuItem5
			size = New Size(168, 6)
			arg_1399_0.Size = size
			Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
			Dim arg_13C4_0 As ToolStripItem = Me.RenameToolStripMenuItem
			size = New Size(171, 22)
			arg_13C4_0.Size = size
			Me.RenameToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i ghi chú"
			Me.Splitter2.Dock = DockStyle.Top
			Dim arg_13F6_0 As Control = Me.Splitter2
			location = New System.Drawing.Point(0, 116)
			arg_13F6_0.Location = location
			Me.Splitter2.Name = "Splitter2"
			Dim arg_1420_0 As Control = Me.Splitter2
			size = New Size(175, 3)
			arg_1420_0.Size = size
			Me.Splitter2.TabIndex = 1
			Me.Splitter2.TabStop = False
			Me.Panel3.BorderStyle = BorderStyle.Fixed3D
			Me.Panel3.Controls.Add(Me.lvPages)
			Me.Panel3.Dock = DockStyle.Top
			Dim arg_147B_0 As Control = Me.Panel3
			location = New System.Drawing.Point(0, 0)
			arg_147B_0.Location = location
			Me.Panel3.Name = "Panel3"
			Dim arg_14A6_0 As Control = Me.Panel3
			size = New Size(175, 116)
			arg_14A6_0.Size = size
			Me.Panel3.TabIndex = 0
			Me.lvPages.AllowDrop = True
			Me.lvPages.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lvPages.CheckBoxes = True
			Me.lvPages.ContextMenuStrip = Me.lstPagesContextMenuStrip
			Me.lvPages.FullRowSelect = True
			Me.lvPages.HideSelection = False
			Me.lvPages.LabelEdit = True
			Dim arg_1521_0 As Control = Me.lvPages
			location = New System.Drawing.Point(3, 3)
			arg_1521_0.Location = location
			Me.lvPages.Name = "lvPages"
			Dim arg_154C_0 As Control = Me.lvPages
			size = New Size(164, 105)
			arg_154C_0.Size = size
			Me.lvPages.TabIndex = 1
			Me.lvPages.UseCompatibleStateImageBehavior = False
			Me.lvPages.View = View.List
			Me.lstPagesContextMenuStrip.Items.AddRange(New ToolStripItem() { Me.PageReNameToolStripMenuItem, Me.ToolStripSeparator5, Me.PageDeleteToolStripMenuItem })
			Me.lstPagesContextMenuStrip.Name = "LstKHContextMenuStrip"
			Dim arg_15CB_0 As Control = Me.lstPagesContextMenuStrip
			size = New Size(115, 54)
			arg_15CB_0.Size = size
			Me.PageReNameToolStripMenuItem.Name = "PageReNameToolStripMenuItem"
			Dim arg_15F3_0 As ToolStripItem = Me.PageReNameToolStripMenuItem
			size = New Size(114, 22)
			arg_15F3_0.Size = size
			Me.PageReNameToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i tên"
			Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
			Dim arg_162A_0 As ToolStripItem = Me.ToolStripSeparator5
			size = New Size(111, 6)
			arg_162A_0.Size = size
			Me.PageDeleteToolStripMenuItem.Name = "PageDeleteToolStripMenuItem"
			Dim arg_1652_0 As ToolStripItem = Me.PageDeleteToolStripMenuItem
			size = New Size(114, 22)
			arg_1652_0.Size = size
			Me.PageDeleteToolStripMenuItem.Text = "Xóa"
			Dim arg_167C_0 As Control = Me.Splitter1
			location = New System.Drawing.Point(175, 24)
			arg_167C_0.Location = location
			Me.Splitter1.Name = "Splitter1"
			Dim arg_16A6_0 As Control = Me.Splitter1
			size = New Size(3, 618)
			arg_16A6_0.Size = size
			Me.Splitter1.TabIndex = 2
			Me.Splitter1.TabStop = False
			Me.Panel2.Controls.Add(Me.Panel2DMap)
			Me.Panel2.Controls.Add(Me.Splitter3D)
			Me.Panel2.Controls.Add(Me.Panel3D)
			Me.Panel2.Dock = DockStyle.Fill
			Dim arg_1726_0 As Control = Me.Panel2
			location = New System.Drawing.Point(178, 24)
			arg_1726_0.Location = location
			Me.Panel2.Name = "Panel2"
			Dim arg_1754_0 As Control = Me.Panel2
			size = New Size(719, 618)
			arg_1754_0.Size = size
			Me.Panel2.TabIndex = 3
			Me.Panel2DMap.BorderStyle = BorderStyle.Fixed3D
			Me.Panel2DMap.Controls.Add(Me.AxMap1)
			Me.Panel2DMap.Controls.Add(Me.StatusStrip1)
			Me.Panel2DMap.Controls.Add(Me.ToolStrip1)
			Me.Panel2DMap.Dock = DockStyle.Fill
			Dim arg_17CF_0 As Control = Me.Panel2DMap
			location = New System.Drawing.Point(0, 0)
			arg_17CF_0.Location = location
			Me.Panel2DMap.Name = "Panel2DMap"
			Dim arg_17FD_0 As Control = Me.Panel2DMap
			size = New Size(719, 274)
			arg_17FD_0.Size = size
			Me.Panel2DMap.TabIndex = 7
			Me.AxMap1.Dock = DockStyle.Fill
			Me.AxMap1.Enabled = True
			Dim arg_1837_0 As Control = Me.AxMap1
			location = New System.Drawing.Point(0, 25)
			arg_1837_0.Location = location
			Me.AxMap1.Name = "AxMap1"
			Me.AxMap1.OcxState = CType(componentResourceManager.GetObject("AxMap1.OcxState"), AxHost.State)
			Dim arg_1880_0 As Control = Me.AxMap1
			size = New Size(715, 223)
			arg_1880_0.Size = size
			Me.AxMap1.TabIndex = 1
			Me.StatusStrip1.Items.AddRange(New ToolStripItem() { Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5 })
			Dim arg_18EA_0 As Control = Me.StatusStrip1
			location = New System.Drawing.Point(0, 248)
			arg_18EA_0.Location = location
			Me.StatusStrip1.Name = "StatusStrip1"
			Dim arg_1915_0 As Control = Me.StatusStrip1
			size = New Size(715, 22)
			arg_1915_0.Size = size
			Me.StatusStrip1.TabIndex = 0
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.ToolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Right
			Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
			Dim arg_1964_0 As ToolStripItem = Me.ToolStripStatusLabel1
			size = New Size(4, 17)
			arg_1964_0.Size = size
			Me.ToolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right
			Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
			Dim arg_1997_0 As ToolStripItem = Me.ToolStripStatusLabel2
			size = New Size(4, 17)
			arg_1997_0.Size = size
			Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
			Dim arg_19BE_0 As ToolStripItem = Me.ToolStripStatusLabel3
			size = New Size(0, 17)
			arg_19BE_0.Size = size
			Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
			Dim arg_19E5_0 As ToolStripItem = Me.ToolStripStatusLabel4
			size = New Size(0, 17)
			arg_19E5_0.Size = size
			Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
			Dim arg_1A0C_0 As ToolStripItem = Me.ToolStripStatusLabel5
			size = New Size(0, 17)
			arg_1A0C_0.Size = size
			Me.ToolStrip1.Items.AddRange(New ToolStripItem() { Me.RullerToolStripButton, Me.SelectorToolStripButton, Me.PanToolStripButton, Me.ZoomInToolStripButton, Me.ZoomOutToolStripButton, Me.BdTCDefToolStripButton, Me.Zoom1XToolStripButton, Me.ToolStripSeparator1, Me.CNToolStripButton, Me.SymbolToolStripButton, Me.UndoToolStripButton, Me.RedoToolStripButton, Me.MuiTenDonToolStripButton, Me.MuiTenDacToolStripButton, Me.ClosedCurveToolStripButton, Me.CurveToolStripSplitButton, Me.SongSongKinToolStripButton, Me.LineToolStripButton, Me.PolygonToolStripButton, Me.RectangleToolStripButton, Me.ArcToolStripButton, Me.EllipseToolStripButton, Me.TextToolStripButton, Me.TableToolStripButton, Me.OptionsToolStripButton })
			Dim arg_1B2B_0 As Control = Me.ToolStrip1
			location = New System.Drawing.Point(0, 0)
			arg_1B2B_0.Location = location
			Me.ToolStrip1.Name = "ToolStrip1"
			Dim arg_1B56_0 As Control = Me.ToolStrip1
			size = New Size(715, 25)
			arg_1B56_0.Size = size
			Me.ToolStrip1.TabIndex = 0
			Me.ToolStrip1.Text = "ToolStrip1"
			Me.RullerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.RullerToolStripButton.Image = Resources.ruler
			Me.RullerToolStripButton.ImageTransparentColor = Color.Magenta
			Me.RullerToolStripButton.Name = "RullerToolStripButton"
			Dim arg_1BC6_0 As ToolStripItem = Me.RullerToolStripButton
			size = New Size(23, 22)
			arg_1BC6_0.Size = size
			Me.RullerToolStripButton.Text = ChrW(272) & "o kho" & ChrW(7843) & "ng cách"
			Me.SelectorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.SelectorToolStripButton.Image = Resources.arrow
			Me.SelectorToolStripButton.ImageTransparentColor = Color.Magenta
			Me.SelectorToolStripButton.Name = "SelectorToolStripButton"
			Dim arg_1C2A_0 As ToolStripItem = Me.SelectorToolStripButton
			size = New Size(23, 22)
			arg_1C2A_0.Size = size
			Me.SelectorToolStripButton.Text = "ToolStripButton5"
			Me.SelectorToolStripButton.ToolTipText = "Select"
			Me.PanToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.PanToolStripButton.Image = Resources.hand
			Me.PanToolStripButton.ImageTransparentColor = Color.Magenta
			Me.PanToolStripButton.Name = "PanToolStripButton"
			Dim arg_1C9E_0 As ToolStripItem = Me.PanToolStripButton
			size = New Size(23, 22)
			arg_1C9E_0.Size = size
			Me.PanToolStripButton.Text = "ToolStripButton6"
			Me.PanToolStripButton.ToolTipText = "Grabber"
			Me.ZoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ZoomInToolStripButton.Image = Resources.zoomin
			Me.ZoomInToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ZoomInToolStripButton.Name = "ZoomInToolStripButton"
			Dim arg_1D12_0 As ToolStripItem = Me.ZoomInToolStripButton
			size = New Size(23, 22)
			arg_1D12_0.Size = size
			Me.ZoomInToolStripButton.Text = "ToolStripButton7"
			Me.ZoomInToolStripButton.ToolTipText = "ZoomIn"
			Me.ZoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ZoomOutToolStripButton.Image = Resources.zoomout
			Me.ZoomOutToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ZoomOutToolStripButton.Name = "ZoomOutToolStripButton"
			Dim arg_1D86_0 As ToolStripItem = Me.ZoomOutToolStripButton
			size = New Size(23, 22)
			arg_1D86_0.Size = size
			Me.ZoomOutToolStripButton.Text = "ToolStripButton8"
			Me.ZoomOutToolStripButton.ToolTipText = "ZoomOut"
			Me.BdTCDefToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.BdTCDefToolStripButton.Image = CType(componentResourceManager.GetObject("BdTCDefToolStripButton.Image"), Image)
			Me.BdTCDefToolStripButton.ImageTransparentColor = Color.Magenta
			Me.BdTCDefToolStripButton.Name = "BdTCDefToolStripButton"
			Dim arg_1E05_0 As ToolStripItem = Me.BdTCDefToolStripButton
			size = New Size(23, 22)
			arg_1E05_0.Size = size
			Me.BdTCDefToolStripButton.Text = "BdTC def"
			Me.BdTCDefToolStripButton.ToolTipText = ChrW(272) & ChrW(7893) & "i S" & ChrW(7889) & " li" & ChrW(7879) & "u m" & ChrW(7863) & "c " & ChrW(273) & ChrW(7883) & "nh c" & ChrW(7911) & "a  B" & ChrW(272) & "TC"
			Me.Zoom1XToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.Zoom1XToolStripButton.Image = Resources.zoom1x
			Me.Zoom1XToolStripButton.ImageTransparentColor = Color.Magenta
			Me.Zoom1XToolStripButton.Name = "Zoom1XToolStripButton"
			Dim arg_1E79_0 As ToolStripItem = Me.Zoom1XToolStripButton
			size = New Size(23, 22)
			arg_1E79_0.Size = size
			Me.Zoom1XToolStripButton.Text = "ToolStripButton1"
			Me.Zoom1XToolStripButton.ToolTipText = "V" & ChrW(7883) & " trí, kích th" & ChrW(432) & ChrW(7899) & "c ban " & ChrW(273) & ChrW(7847) & "u"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim arg_1EC0_0 As ToolStripItem = Me.ToolStripSeparator1
			size = New Size(6, 25)
			arg_1EC0_0.Size = size
			Me.CNToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.CNToolStripButton.Image = Resources.CN
			Me.CNToolStripButton.ImageTransparentColor = Color.Magenta
			Me.CNToolStripButton.Name = "CNToolStripButton"
			Dim arg_1F14_0 As ToolStripItem = Me.CNToolStripButton
			size = New Size(23, 22)
			arg_1F14_0.Size = size
			Me.CNToolStripButton.Text = "ToolStripButton9"
			Me.CNToolStripButton.ToolTipText = "C" & ChrW(7853) & "p nh" & ChrW(7853) & "t các ký hi" & ChrW(7879) & "u"
			Me.SymbolToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.SymbolToolStripButton.Image = Resources.NewDT
			Me.SymbolToolStripButton.ImageTransparentColor = Color.Magenta
			Me.SymbolToolStripButton.Name = "SymbolToolStripButton"
			Dim arg_1F88_0 As ToolStripItem = Me.SymbolToolStripButton
			size = New Size(23, 22)
			arg_1F88_0.Size = size
			Me.SymbolToolStripButton.Text = "ToolStripButton1"
			Me.SymbolToolStripButton.ToolTipText = "Các ký hi" & ChrW(7879) & "u QS"
			Me.UndoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.UndoToolStripButton.Image = Resources.UNDO
			Me.UndoToolStripButton.ImageTransparentColor = Color.Magenta
			Me.UndoToolStripButton.Name = "UndoToolStripButton"
			Dim arg_1FFC_0 As ToolStripItem = Me.UndoToolStripButton
			size = New Size(23, 22)
			arg_1FFC_0.Size = size
			Me.UndoToolStripButton.Text = "Undo"
			Me.RedoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.RedoToolStripButton.Image = Resources.REDO
			Me.RedoToolStripButton.ImageTransparentColor = Color.Magenta
			Me.RedoToolStripButton.Name = "RedoToolStripButton"
			Dim arg_2060_0 As ToolStripItem = Me.RedoToolStripButton
			size = New Size(23, 22)
			arg_2060_0.Size = size
			Me.RedoToolStripButton.Text = "Redo"
			Me.MuiTenDonToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.MuiTenDonToolStripButton.Image = Resources.MuiTenDon
			Me.MuiTenDonToolStripButton.ImageTransparentColor = Color.Magenta
			Me.MuiTenDonToolStripButton.Name = "MuiTenDonToolStripButton"
			Dim arg_20C4_0 As ToolStripItem = Me.MuiTenDonToolStripButton
			size = New Size(23, 22)
			arg_20C4_0.Size = size
			Me.MuiTenDonToolStripButton.Text = "ToolStripButton1"
			Me.MuiTenDonToolStripButton.ToolTipText = "M" & ChrW(361) & "i tên " & ChrW(273) & ChrW(417) & "n"
			Me.MuiTenDacToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.MuiTenDacToolStripButton.Image = Resources.MuiTenNho
			Me.MuiTenDacToolStripButton.ImageTransparentColor = Color.Magenta
			Me.MuiTenDacToolStripButton.Name = "MuiTenDacToolStripButton"
			Dim arg_2138_0 As ToolStripItem = Me.MuiTenDacToolStripButton
			size = New Size(23, 22)
			arg_2138_0.Size = size
			Me.MuiTenDacToolStripButton.Text = "M" & ChrW(361) & "i tên t" & ChrW(7927) & " l" & ChrW(7879)
			Me.ClosedCurveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ClosedCurveToolStripButton.Image = Resources.closedcurve
			Me.ClosedCurveToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ClosedCurveToolStripButton.Name = "ClosedCurveToolStripButton"
			Dim arg_219C_0 As ToolStripItem = Me.ClosedCurveToolStripButton
			size = New Size(23, 22)
			arg_219C_0.Size = size
			Me.ClosedCurveToolStripButton.Text = "ToolStripButton3"
			Me.ClosedCurveToolStripButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng cong kín"
			Me.CurveToolStripSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.CurveToolStripSplitButton.Image = Resources.curve
			Me.CurveToolStripSplitButton.ImageTransparentColor = Color.Magenta
			Me.CurveToolStripSplitButton.Name = "CurveToolStripSplitButton"
			Dim arg_2210_0 As ToolStripItem = Me.CurveToolStripSplitButton
			size = New Size(32, 22)
			arg_2210_0.Size = size
			Me.CurveToolStripSplitButton.Text = "ToolStripSplitButton1"
			Me.CurveToolStripSplitButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng cong"
			Me.SongSongKinToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.SongSongKinToolStripButton.Image = Resources.SongSongKin
			Me.SongSongKinToolStripButton.ImageTransparentColor = Color.Magenta
			Me.SongSongKinToolStripButton.Name = "SongSongKinToolStripButton"
			Dim arg_2284_0 As ToolStripItem = Me.SongSongKinToolStripButton
			size = New Size(23, 22)
			arg_2284_0.Size = size
			Me.SongSongKinToolStripButton.Text = "ToolStripButton1"
			Me.SongSongKinToolStripButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng song song"
			Me.LineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.LineToolStripButton.Image = Resources.AddPolyLine
			Me.LineToolStripButton.ImageTransparentColor = Color.Magenta
			Me.LineToolStripButton.Name = "LineToolStripButton"
			Dim arg_22F8_0 As ToolStripItem = Me.LineToolStripButton
			size = New Size(23, 22)
			arg_22F8_0.Size = size
			Me.LineToolStripButton.Text = "LineToolStripButton"
			Me.LineToolStripButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng g" & ChrW(7845) & "p khúc"
			Me.PolygonToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.PolygonToolStripButton.Image = Resources.polygon1
			Me.PolygonToolStripButton.ImageTransparentColor = Color.Magenta
			Me.PolygonToolStripButton.Name = "PolygonToolStripButton"
			Dim arg_236C_0 As ToolStripItem = Me.PolygonToolStripButton
			size = New Size(23, 22)
			arg_236C_0.Size = size
			Me.PolygonToolStripButton.Text = ChrW(272) & "a giác"
			Me.RectangleToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.RectangleToolStripButton.Image = Resources.Rectangle
			Me.RectangleToolStripButton.ImageTransparentColor = Color.Magenta
			Me.RectangleToolStripButton.Name = "RectangleToolStripButton"
			Dim arg_23D0_0 As ToolStripItem = Me.RectangleToolStripButton
			size = New Size(23, 22)
			arg_23D0_0.Size = size
			Me.RectangleToolStripButton.Text = "ToolStripButton1"
			Me.RectangleToolStripButton.ToolTipText = "Hình ch" & ChrW(7919) & " nh" & ChrW(7853) & "t"
			Me.ArcToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ArcToolStripButton.Image = Resources.Arc
			Me.ArcToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ArcToolStripButton.Name = "ArcToolStripButton"
			Dim arg_2444_0 As ToolStripItem = Me.ArcToolStripButton
			size = New Size(23, 22)
			arg_2444_0.Size = size
			Me.ArcToolStripButton.Text = "Cung"
			Me.EllipseToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.EllipseToolStripButton.Image = Resources.cycle
			Me.EllipseToolStripButton.ImageTransparentColor = Color.Magenta
			Me.EllipseToolStripButton.Name = "EllipseToolStripButton"
			Dim arg_24A8_0 As ToolStripItem = Me.EllipseToolStripButton
			size = New Size(23, 22)
			arg_24A8_0.Size = size
			Me.EllipseToolStripButton.Text = "ToolStripButton1"
			Me.EllipseToolStripButton.ToolTipText = "Hình ê líp"
			Me.TextToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.TextToolStripButton.Image = Resources.Text
			Me.TextToolStripButton.ImageTransparentColor = Color.Magenta
			Me.TextToolStripButton.Name = "TextToolStripButton"
			Dim arg_251C_0 As ToolStripItem = Me.TextToolStripButton
			size = New Size(23, 22)
			arg_251C_0.Size = size
			Me.TextToolStripButton.Text = "ToolStripButton1"
			Me.TextToolStripButton.ToolTipText = "Ch" & ChrW(7919)
			Me.TableToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.TableToolStripButton.Image = Resources.Table
			Me.TableToolStripButton.ImageTransparentColor = Color.Magenta
			Me.TableToolStripButton.Name = "TableToolStripButton"
			Dim arg_2590_0 As ToolStripItem = Me.TableToolStripButton
			size = New Size(23, 22)
			arg_2590_0.Size = size
			Me.TableToolStripButton.Text = "ToolStripButton1"
			Me.TableToolStripButton.ToolTipText = "B" & ChrW(7843) & "ng"
			Me.OptionsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.OptionsToolStripButton.Image = Resources.Options
			Me.OptionsToolStripButton.ImageTransparentColor = Color.Magenta
			Me.OptionsToolStripButton.Name = "OptionsToolStripButton"
			Dim arg_2604_0 As ToolStripItem = Me.OptionsToolStripButton
			size = New Size(23, 22)
			arg_2604_0.Size = size
			Me.OptionsToolStripButton.Text = "ToolStripButton1"
			Me.OptionsToolStripButton.ToolTipText = "Các m" & ChrW(7863) & "c " & ChrW(273) & ChrW(7883) & "nh"
			Me.Splitter3D.Dock = DockStyle.Bottom
			Dim arg_2649_0 As Control = Me.Splitter3D
			location = New System.Drawing.Point(0, 274)
			arg_2649_0.Location = location
			Me.Splitter3D.Name = "Splitter3D"
			Dim arg_2673_0 As Control = Me.Splitter3D
			size = New Size(719, 3)
			arg_2673_0.Size = size
			Me.Splitter3D.TabIndex = 6
			Me.Splitter3D.TabStop = False
			Me.Panel3D.BorderStyle = BorderStyle.Fixed3D
			Me.Panel3D.Controls.Add(Me.ToolStrip2)
			Me.Panel3D.Dock = DockStyle.Bottom
			Dim arg_26D2_0 As Control = Me.Panel3D
			location = New System.Drawing.Point(0, 277)
			arg_26D2_0.Location = location
			Me.Panel3D.Name = "Panel3D"
			Dim arg_2700_0 As Control = Me.Panel3D
			size = New Size(719, 341)
			arg_2700_0.Size = size
			Me.Panel3D.TabIndex = 5
			Me.ToolStrip2.Dock = DockStyle.None
			Me.ToolStrip2.Items.AddRange(New ToolStripItem() { Me.Symbol3DHideToolStripButton, Me.Symbol3DDrawToolStripButton })
			Dim arg_2757_0 As Control = Me.ToolStrip2
			location = New System.Drawing.Point(0, 0)
			arg_2757_0.Location = location
			Me.ToolStrip2.Name = "ToolStrip2"
			Dim arg_277F_0 As Control = Me.ToolStrip2
			size = New Size(58, 25)
			arg_277F_0.Size = size
			Me.ToolStrip2.TabIndex = 2
			Me.ToolStrip2.Text = "ToolStrip2"
			Me.Symbol3DHideToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.Symbol3DHideToolStripButton.Image = Resources.DauKyHieu
			Me.Symbol3DHideToolStripButton.ImageTransparentColor = Color.Magenta
			Me.Symbol3DHideToolStripButton.Name = "Symbol3DHideToolStripButton"
			Dim arg_27EF_0 As ToolStripItem = Me.Symbol3DHideToolStripButton
			size = New Size(23, 22)
			arg_27EF_0.Size = size
			Me.Symbol3DHideToolStripButton.Text = "D" & ChrW(7845) & "u ký hi" & ChrW(7879) & "u"
			Me.Symbol3DDrawToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.Symbol3DDrawToolStripButton.Image = Resources.NewDT
			Me.Symbol3DDrawToolStripButton.ImageTransparentColor = Color.Magenta
			Me.Symbol3DDrawToolStripButton.Name = "Symbol3DDrawToolStripButton"
			Dim arg_2853_0 As ToolStripItem = Me.Symbol3DDrawToolStripButton
			size = New Size(23, 22)
			arg_2853_0.Size = size
			Me.Symbol3DDrawToolStripButton.Text = "Hi" & ChrW(7879) & "n ký hi" & ChrW(7879) & "u"
			Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
			Dim arg_288D_0 As ToolStripItem = Me.ToolStripSeparator6
			size = New Size(274, 6)
			arg_288D_0.Size = size
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(897, 642)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Splitter1)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.MinimizeBox = False
			Me.Name = "frmMain"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			Me.LstKHContextMenuStrip.ResumeLayout(False)
			Me.Panel3.ResumeLayout(False)
			Me.lstPagesContextMenuStrip.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			Me.Panel2DMap.ResumeLayout(False)
			Me.Panel2DMap.PerformLayout()
			(CType(Me.AxMap1, ISupportInitialize)).EndInit()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.ToolStrip1.ResumeLayout(False)
			Me.ToolStrip1.PerformLayout()
			Me.Panel3D.ResumeLayout(False)
			Me.Panel3D.PerformLayout()
			Me.ToolStrip2.ResumeLayout(False)
			Me.ToolStrip2.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Function LoadPara2(pDefFile As String) As Boolean
			Dim result As Boolean = False
			If modSaBan.LoadPara(pDefFile) Then
				Try
					Me.ClearBanDo()
					modSaBan.LoadDienTap(modSaBan.myLastSaBan)
					Me.Init2DMap()
					If Not Information.IsNothing(Me.myTerrain) Then
						Me.myTerrain.Dispose()
						Me.myTerrain = Nothing
					End If
					Me.myTerrain = New CDiaHinh(Me.AxMap1, Me, modSaBan.heightData, modBdTC.cDecSepa, modBdTC.cGrpSepa)
					Me.myTerrain.InitDiaHinh(modSaBan.myCamPos)
					result = True
				Catch expr_74 As Exception
					ProjectData.SetProjectError(expr_74)
					ProjectData.ClearProjectError()
				End Try
			End If
			Return result
		End Function

		Private Sub PopulatePageList()
			Me.lvPages.Clear()
			Try
				Dim enumerator As IEnumerator = Me.myPages.GetEnumerator()
				While enumerator.MoveNext()
					Dim cPage As CPage = CType(enumerator.Current, CPage)
					Dim value As String = cPage.Value
					Dim tag As String = cPage.ID.ToString()
					Dim listViewItem As ListViewItem = New ListViewItem(value)
					listViewItem.Tag = tag
					listViewItem.ImageIndex = 0
					listViewItem.StateImageIndex = 0
					listViewItem.Checked = cPage.Checked
					Me.lvPages.Items.Add(listViewItem)
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub PopulateSelePage()
			Try
				If Me.lvPages.SelectedItems.Count > 0 Then
					Dim listViewItem As ListViewItem = Me.lvPages.SelectedItems(0)
					If listViewItem IsNot Nothing Then
						Dim pId As Integer = Conversions.ToInteger(listViewItem.Tag)
						Me.CurrPage = Me.myPages.GetItemByID(pId)
						If Not Information.IsNothing(Me.CurrPage) Then
							Me.myBando.KHsFromString(Me.CurrPage.Symbols)
						Else
							Me.myBando.KHsFromString("")
						End If
					End If
				Else
					Me.myBando.KHsFromString("")
				End If
				Me.myBando.HideDrawTools()
				Dim zoomLevel As Double = modBanDo.GetZoomLevel(Me.AxMap1, modBanDo.BDTyLeBanDo)
				If zoomLevel > 0.0 Then
					Me.AxMap1.ZoomTo(zoomLevel, modBanDo.BDKinhDo, modBanDo.BDViDo)
				End If
				Me.AxMap1.Refresh()
				Me.PopulateListKH(Nothing)
			Catch expr_E1 As Exception
				ProjectData.SetProjectError(expr_E1)
				Dim ex As Exception = expr_E1
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PopulateSelePage Error")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub RefreshBdTC(iPage As Integer)
			Try
				Me.PopulatePageList()
				If Me.lvPages.Items.Count > 0 Then
					Me.lvPages.Items(iPage).Selected = True
				End If
				Me.PopulateSelePage()
			Catch expr_38 As Exception
				ProjectData.SetProjectError(expr_38)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs)
			If Me.bLoaded Then
				Me.LuuThayDoi()
				Try
					modSaBan.DienTap2File(modSaBan.myLastSaBan)
				Catch expr_1A As Exception
					ProjectData.SetProjectError(expr_1A)
					ProjectData.ClearProjectError()
				End Try
			End If
			Try
				Me.myBando.Dispose()
			Catch expr_35 As Exception
				ProjectData.SetProjectError(expr_35)
				ProjectData.ClearProjectError()
			End Try
			Try
				Me.myTerrain.Dispose()
			Catch expr_50 As Exception
				ProjectData.SetProjectError(expr_50)
				ProjectData.ClearProjectError()
			End Try
			myModule.fMain = Nothing
		End Sub

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub frmMain_Load(sender As Object, e As EventArgs)
			myModule.RegisterOK = True
			If Not myModule.RegisterOK Then
				MessageBox.Show("Chua Dang ky. Stop.")
				ProjectData.EndApp()
			End If
			myModule.fMain = Me
			modSaBan.myApplPath = Directory.GetCurrentDirectory()
			modSaBan.LoadOLuoiDef("OLUOI.DEF")
			modSaBan.myHienDanhSach = False
			Me.DanhSachToolStripMenuItem.Checked = modSaBan.myHienDanhSach
			Me.DanhSachToolStripMenuItem_CheckStateChanged(Nothing, Nothing)
			Me.WindowState = FormWindowState.Maximized
			modSaBan.myCTpara = modSaBan.myApplPath + "\" + MySettingsProperty.Settings.myCTpara
			If MyProject.Computer.FileSystem.FileExists(modSaBan.myCTpara) Then
				modSaBan.LoadLastDiaHinh(modSaBan.myCTpara)
				If File.Exists(modSaBan.myDiaHinhDef) Then
					Me.bLoaded = Me.LoadPara2(modSaBan.myDiaHinhDef)
				Else
					Try
						MyProject.Forms.SplashScreen1.Close()
					Catch expr_CA As Exception
						ProjectData.SetProjectError(expr_CA)
						ProjectData.ClearProjectError()
					End Try
					Interaction.MsgBox("Không th" & ChrW(7845) & "y " + modSaBan.myDiaHinhDef, MsgBoxStyle.OkOnly, Nothing)
					Me.LoadDiaHinhToolStripMenuItem_Click(Nothing, Nothing)
				End If
			End If
			If Not Me.bLoaded Then
				Try
					MyProject.Forms.SplashScreen1.Close()
				Catch expr_110 As Exception
					ProjectData.SetProjectError(expr_110)
					ProjectData.ClearProjectError()
				End Try
				Me.Close()
			End If
		End Sub

		Private Sub ClearBanDo()
			Me.LuuThayDoi()
			Try
				Me.myPages.Clear()
				Me.AxMap1.Layers.RemoveAll()
			Catch expr_23 As Exception
				ProjectData.SetProjectError(expr_23)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub UpdateTitle()
			Me.Text = String.Concat(New String() { "Sa bàn:(", modSaBan.myDiaHinhDef, ") -  B" & ChrW(273) & "TC:(", modSaBan.LastBdTC, ")" })
		End Sub

		Public Function initBanDo(pMap As AxMap) As Layer
			Dim result As Layer
			Try
				pMap.GeoSet = modBanDo.myMapGst
				pMap.Title.Visible = False
				pMap.MapUnit = MapUnitConstants.miUnitMeter
				Dim displayCoordSys As CoordSys = pMap.DisplayCoordSys
				pMap.NumericCoordSys = displayCoordSys
				pMap.InfotipSupport = False
				pMap.NumericCoordSys.[Set](CType(modBanDo.myCoordSysType, CoordSysTypeConstants), displayCoordSys.Datum, pMap.NumericCoordSys.Units, pMap.NumericCoordSys.OriginLongitude, pMap.NumericCoordSys.OriginLatitude, pMap.NumericCoordSys.StandardParallelOne, pMap.NumericCoordSys.StandardParallelTwo, pMap.NumericCoordSys.Azimuth, pMap.NumericCoordSys.ScaleFactor, pMap.NumericCoordSys.FalseEasting, pMap.NumericCoordSys.FalseNorthing, pMap.NumericCoordSys.Range, Missing.Value, Missing.Value)
				pMap.PaperUnit = PaperUnitConstants.miPaperUnitCentimeter
				result = pMap.Layers.AddUserDrawLayer("LopVeKyHieu", 1S)
			Catch expr_110 As Exception
				ProjectData.SetProjectError(expr_110)
				result = Nothing
				ProjectData.ClearProjectError()
			End Try
			Return result
		End Function

		Private Sub Init2DMap()
			modBdTC.LoadDefa(modBdTC.myDefaFileName)
			Me.lyrCacKyHieu = Me.initBanDo(Me.AxMap1)
			Me.myBanDoNen = New CBanDoNen(Me.AxMap1, Me, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1)
			Me.bBanDo2Loaded = False
			Me.myBando = New CBdTC(Me.AxMap1, Me, Me.Panel2DMap, Me.ToolStrip1)
			Me.myVeActs = New CVeActs(Me.AxMap1, Me)
			Me.OpenBdTC(modSaBan.LastBdTC)
			Me.UpdateTitle()
		End Sub

		Private Sub CacLopBD()
			If Me.AxMap1.Layers.LayersDlg(Missing.Value, Missing.Value) Then
				Directory.SetCurrentDirectory(modSaBan.myCurrentDirectory)
			End If
		End Sub

		Private Sub LuuGeoSet()
			Try
				Me.AxMap1.Layers.Remove("LopVeKyHieu")
				Me.AxMap1.SaveMapAsGeoset("BanDo", modBanDo.myMapGst)
				Me.lyrCacKyHieu = Me.AxMap1.Layers.AddUserDrawLayer("LopVeKyHieu", 1S)
			Catch arg_48_0 As Exception
				ProjectData.SetProjectError(arg_48_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub SaBanToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			If Me.SaBanToolStripMenuItem.Checked Then
				Me.Panel3D.Visible = True
				Me.Splitter3D.Visible = True
			Else
				Me.Panel3D.Visible = False
				Me.Splitter3D.Visible = False
			End If
		End Sub

		Private Sub SaBanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.SaBanToolStripMenuItem.Checked = Not Me.SaBanToolStripMenuItem.Checked
		End Sub

		Private Sub DanhSachToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			If Me.DanhSachToolStripMenuItem.Checked Then
				Me.Splitter1.Visible = True
				Me.Panel1.Visible = True
			Else
				Me.Panel1.Visible = False
				Me.Splitter1.Visible = False
			End If
		End Sub

		Private Sub DanhSachToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.DanhSachToolStripMenuItem.Checked = Not Me.DanhSachToolStripMenuItem.Checked
		End Sub

		Private Sub StatusBarToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			Me.StatusStrip1.Visible = Me.StatusBarToolStripMenuItem.Checked
		End Sub

		Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.StatusBarToolStripMenuItem.Checked = Not Me.StatusBarToolStripMenuItem.Checked
		End Sub

		Private Sub BdTCToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			If Me.BdTCToolStripMenuItem.Checked Then
				Me.Panel2DMap.Visible = True
				Me.Splitter3D.Visible = True
				Me.Panel3D.Dock = DockStyle.Bottom
			Else
				Me.Panel2DMap.Visible = False
				Me.Splitter3D.Visible = False
				Me.Panel3D.Dock = DockStyle.Fill
			End If
		End Sub

		Private Sub BdTCToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.BdTCToolStripMenuItem.Checked = Not Me.BdTCToolStripMenuItem.Checked
		End Sub

		Private Sub NewPageToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(Me.myPages) Then
				Me.UpdatePage()
				Me.CurrPage = Me.myPages.AddNewPage("")
				Me.myDirty = True
				' The following expression was wrapped in a checked-expression
				Me.RefreshBdTC(Me.myPages.Count - 1)
			End If
		End Sub

		Private Sub lstCacKyHieu_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem)) Then
				Me.lstCacKyHieu.SelectionMode = SelectionMode.One
			End If
		End Sub

		Private Sub NhapNhayKH()
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem)) Then
				Me.lstCacKyHieu.Enabled = False
				Try
					Dim cSymbol As CSymbol = CType(Me.lstCacKyHieu.SelectedItem, CSymbol)
					If Not Me.AxMap1.IsPointVisible(cSymbol.GocX, cSymbol.GocY) Then
						Me.AxMap1.CenterX = cSymbol.GocX
						Me.AxMap1.CenterY = cSymbol.GocY
					End If
					Me.myBando.NhapNhaySymbol(cSymbol, 5)
				Catch arg_7E_0 As Exception
					ProjectData.SetProjectError(arg_7E_0)
					ProjectData.ClearProjectError()
				End Try
				Me.lstCacKyHieu.Enabled = True
			End If
		End Sub

		Private Sub lstCacKyHieu_DoubleClick(sender As Object, e As EventArgs)
			Me.NhapNhayKH()
		End Sub

		Private Sub NhapNhayToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.NhapNhayKH()
		End Sub

		Private Sub XoaToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.lstCacKyHieu.Enabled = False
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem)) AndAlso MessageBox.Show(Me, "Th" & ChrW(7853) & "t s" & ChrW(7921) & " mu" & ChrW(7889) & "n xoá Ký hi" & ChrW(7879) & "u này?", "Xoá:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				Me.myBando.SelectedSymbol = CType(Me.lstCacKyHieu.SelectedItem, CSymbol)
				Me.myBando.OnXoa()
			End If
			Me.lstCacKyHieu.Enabled = True
		End Sub

		Private Sub XoaTatToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.lstCacKyHieu.Enabled = False
			If Me.myBando.drawingSymbols.Count > 0 AndAlso MessageBox.Show(Me, "Th" & ChrW(7853) & "t s" & ChrW(7921) & " mu" & ChrW(7889) & "n xoá t" & ChrW(7845) & "t c" & ChrW(7843) & " các Ký hi" & ChrW(7879) & "u?", "Xoá:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				Me.myBando.OnXoaTat()
			End If
			Me.lstCacKyHieu.Enabled = True
		End Sub

		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem)) Then
				Dim pSymbol As CSymbol = CType(Me.lstCacKyHieu.SelectedItem, CSymbol)
				Me.myBando.ChangeDesc(pSymbol, Me)
			End If
		End Sub

		Private Sub lvPages_AfterLabelEdit(sender As Object, e As LabelEditEventArgs)
			If Not Information.IsNothing(Me.CurrPage) Then
				Me.CurrPage.Value = e.Label
				Me.myDirty = True
			End If
		End Sub

		Private Sub PageReNameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.lvPages.SelectedItems.Count > 0 Then
				Me.lvPages.SelectedItems(0).BeginEdit()
			End If
		End Sub

		Private Sub PageDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.lvPages.SelectedItems.Count > 0 Then
				Dim pId As Integer = Conversions.ToInteger(Me.lvPages.SelectedItems(0).Tag)
				Dim itemByID As CPage = Me.myPages.GetItemByID(pId)
				Me.myPages.Remove(itemByID)
				Me.PopulatePageList()
				Me.myDirty = True
			End If
		End Sub

		Private Sub DuplicatePageToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(Me.myPages) Then
				Me.UpdatePage()
				Me.CurrPage = Me.myPages.AddNewPage(Me.CurrPage.Symbols)
				Me.myDirty = True
				' The following expression was wrapped in a checked-expression
				Me.RefreshBdTC(Me.myPages.Count - 1)
			End If
		End Sub

		Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			openFileDialog.RestoreDirectory = True
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = openFileDialog.FileName
				Me.OpenBdTC(fileName)
			End If
		End Sub

		Private Sub OpenBdTC(mFileName As String)
			If mFileName.Length > 0 Then
				Me.LuuThayDoi()
				If Me.LoadPages(mFileName) Then
					Me.RefreshBdTC(0)
					If modBanDo.BDTyLeBanDo = 0 Then
						modBanDo.BDTyLeBanDo = modBanDo.GetTyLeBD(Me.AxMap1, Me.AxMap1.Zoom)
						modBanDo.BDKinhDo = Me.AxMap1.CenterX
						modBanDo.BDViDo = Me.AxMap1.CenterY
					End If
					Me.m_bNewBdTC = True
					Me.myDirty = False
					modSaBan.LastBdTC = mFileName
					Me.UpdateTitle()
				End If
			End If
		End Sub

		Private Function LoadPages(pFileName As String) As Boolean
			Dim result As Boolean = False
			Dim streamReader As StreamReader = Nothing
			Try
				streamReader = File.OpenText(pFileName)
				Dim text As String = streamReader.ReadToEnd()
				If text.IndexOf(";&#xD;&#xA;") > -1 Then
					text = text.Replace(";&#xD;&#xA;", ";")
				End If
				result = Me.myPages.LoadFromStr(text)
			Catch expr_46 As Exception
				ProjectData.SetProjectError(expr_46)
				Dim ex As Exception = expr_46
				Interaction.MsgBox("File could not be opened or read." & vbCrLf & "Please verify that the filename is correct, and that you have read permissions for the desired directory." & vbCrLf & vbCrLf & "Exception: " + ex.Message, MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			Finally
				If streamReader IsNot Nothing Then
					streamReader.Close()
				End If
			End Try
			Return result
		End Function

		Private Sub ToolStripMenuBDView_Click(sender As Object, e As EventArgs)
			If Not Me.bBanDo2Loaded Then
				If Not Information.IsNothing(modBanDo.fBanDoNho) Then
					modBanDo.fBanDoNho.Close()
				End If
				modBanDo.fBanDoNho = New dlgBanDoNho()
				modBanDo.fBanDoNho.Show(Me)
			Else If Not Information.IsNothing(modBanDo.fBanDoNho) Then
				modBanDo.fBanDoNho.Close()
			End If
			Me.ToolStripMenuBDView.Checked = Me.bBanDo2Loaded
		End Sub

		Private Sub ToolStripMenuCacLopBD_Click(sender As Object, e As EventArgs)
			Me.CacLopBD()
		End Sub

		Private Sub ToolStripMenuLuuGeoSet_Click(sender As Object, e As EventArgs)
			Me.LuuGeoSet()
		End Sub

		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.LuuThayDoi()
			If Me.GetNewBdTC() Then
				modSaBan.LastBdTC = modBdTC.myNewBdTC
				Me.SaveBDTC(modSaBan.LastBdTC)
				Me.UpdateTitle()
				Me.myDirty = True
			End If
		End Sub

		Private Function GetNewBdTC() As Boolean
			Dim result As Boolean = False
			Dim dlgDefBdTC As dlgDefBdTC = New dlgDefBdTC()
			Me.m_bNewBdTC = False
			If dlgDefBdTC.ShowDialog(Me) = DialogResult.OK Then
			End If
			If Me.m_bNewBdTC Then
				Me.myPages.Clear()
				Me.CurrPage = Me.myPages.AddNewPage("")
				Me.RefreshBdTC(0)
				result = True
			End If
			Return result
		End Function

		Private Sub ZoomToToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgZoomTo As dlgZoomTo = New dlgZoomTo()
			dlgZoomTo.ShowDialog(Me)
		End Sub

		Private Sub lvPages_Click(sender As Object, e As EventArgs)
			Me.lvPages.Enabled = False
			Me.UpdatePage()
			Me.PopulateSelePage()
			Me.lvPages.Enabled = True
		End Sub

		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(Me.myPages) Then
				Me.UpdatePage()
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
				saveFileDialog.FilterIndex = 1
				saveFileDialog.RestoreDirectory = True
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					Dim fileName As String = saveFileDialog.FileName
					If fileName.Length > 0 Then
						Me.SaveBDTC(fileName)
						modSaBan.LastBdTC = fileName
						Me.UpdateTitle()
					End If
				End If
			End If
		End Sub

		Private Sub SaveBDTC(mFileName As String)
			Dim arg_15_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.lvPages.Items.Count - 1
			For i As Integer = arg_15_0 To num
				Me.myPages(i).Checked = Me.lvPages.Items(i).Checked
			Next
			Dim text As String = ""
			Try
				text = Me.myPages.Pages2String(Me.AxMap1)
			Catch expr_62 As Exception
				ProjectData.SetProjectError(expr_62)
				ProjectData.ClearProjectError()
			End Try
			If text.Length > 8 Then
				Dim streamWriter As StreamWriter = New StreamWriter(mFileName)
				streamWriter.Write(text)
				streamWriter.Close()
			End If
			Me.myDirty = False
		End Sub

		Private Sub UpdatePage()
			If Not Information.IsNothing(Me.CurrPage) AndAlso Not Information.IsNothing(Me.myBando.drawingSymbols) Then
				Dim pKHstr As String = Me.myBando.drawingSymbols.KH2String(Me.AxMap1)
				Me.CurrPage.Update(pKHstr)
			End If
		End Sub

		Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(Me.myPages) Then
				Me.UpdatePage()
				If Operators.CompareString(modSaBan.LastBdTC, modBdTC.myNewBdTC, False) = 0 Then
					Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
					saveFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
					saveFileDialog.FilterIndex = 1
					saveFileDialog.RestoreDirectory = True
					If saveFileDialog.ShowDialog() = DialogResult.OK Then
						Dim fileName As String = saveFileDialog.FileName
						If fileName.Length > 0 Then
							modSaBan.LastBdTC = fileName
							Me.UpdateTitle()
						End If
					End If
				End If
				Me.SaveBDTC(modSaBan.LastBdTC)
			End If
		End Sub

		Private Sub LuuThayDoi()
			If Me.myDirty AndAlso MessageBox.Show("Có thay " & ChrW(273) & ChrW(7893) & "i, l" & ChrW(432) & "u B" & ChrW(273) & "TC?", "L" & ChrW(432) & "u B" & ChrW(273) & "TC", MessageBoxButtons.YesNo) = DialogResult.Yes Then
				Me.SaveToolStripMenuItem_Click(Nothing, Nothing)
			End If
		End Sub

		Private Function isCheckedItem() As Boolean
			Dim arg_14_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.lvPages.Items.Count - 1
			Dim result As Boolean
			For i As Integer = arg_14_0 To num
				If Me.lvPages.Items(i).Checked Then
					result = True
					Return result
				End If
			Next
			result = False
			Return result
		End Function

		Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.isCheckedItem() Then
				Me.UpdatePage()
				New dlgShow() With { .iCurrPage = Me.lvPages.SelectedIndices(0) }.ShowDialog(Me)
			Else
				Interaction.MsgBox("Khong con Trang nao duoc chon.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.frmMain_FormClosing
			AddHandler MyBase.Load, AddressOf Me.frmMain_Load
			Me.myTerrain = Nothing
			Me.myPages = New CPages()
			Me.bLoaded = False
			Me.myDirty = False
			Me.InitializeComponent()
			myModule.intMonitorW = MyProject.Computer.Screen.WorkingArea.Width
			myModule.intMonitorH = MyProject.Computer.Screen.WorkingArea.Height
		End Sub

		Private Sub PhanLoaiKyHieuToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgPhanLoaiKH As dlgPhanLoaiKH = New dlgPhanLoaiKH()
			dlgPhanLoaiKH.ShowDialog(Me)
		End Sub

		Private Sub btnTimKH_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.txtName.Text.Length > 0 Then
				Me.lstCacKyHieu.SelectionMode = SelectionMode.MultiSimple
				Me.lstCacKyHieu.SelectedItems.Clear()
				Dim arg_46_0 As Integer = 0
				Dim num As Integer = Me.lstCacKyHieu.Items.Count - 1
				For i As Integer = arg_46_0 To num
					Dim cSymbol As CSymbol = CType(Me.lstCacKyHieu.Items(i), CSymbol)
					If cSymbol.Description.Contains(Me.txtName.Text) Then
						Me.lstCacKyHieu.SelectedItems.Add(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.Items(i)))
					End If
				Next
			End If
		End Sub

		Private Sub Symbol3DDrawToolStripButton_Click(sender As Object, e As EventArgs)
			Me.myTerrain.Hien3DSymbols()
		End Sub

		Private Sub Symbol3DHideToolStripButton_Click(sender As Object, e As EventArgs)
			Me.myTerrain.Xoa3DSymbols()
		End Sub

		Private Sub Panel3D_MouseClick(sender As Object, e As MouseEventArgs)
			Me.Panel3D.[Select]()
		End Sub

		Private Sub Symbol3DScriptsEditToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Me.SaveToolStripMenuItem_Click(Nothing, Nothing)
			Catch expr_0A As Exception
				ProjectData.SetProjectError(expr_0A)
				ProjectData.ClearProjectError()
			End Try
			modSaBan.LoadDienTap(modSaBan.myLastSaBan)
			Me.myTerrain.ScriptsEdit()
		End Sub

		Private Sub Symbol3DShowToolStripMenuItem_Click(sender As Object, e As EventArgs)
			modSaBan.myCenterX = Me.myTerrain.CenterX
			modSaBan.myCenterY = Me.myTerrain.CenterY
			modSaBan.myCamPos = Me.myTerrain.cameraPos
			modSaBan.myCamTarget = Me.myTerrain.cameraTarget
			modSaBan.myAngleZ = Me.myTerrain.GetAngleZ()
			modSaBan.myAngleX = Me.myTerrain.GetAngleX()
			Me.ShowSaBan()
		End Sub

		Private Sub ShowSaBan()
			modSaBan.LoadDienTap(modSaBan.myLastSaBan)
			Dim text As String = modSaBan.mySaBanDir + "\SaBan.pos"
			If MyProject.Computer.FileSystem.FileExists(text) Then
				modSaBan.LoadSaBanPos(text)
			Else
				modSaBan.myCenterX = Me.myTerrain.CenterX
				modSaBan.myCenterY = Me.myTerrain.CenterY
				modSaBan.myCamPos = Me.myTerrain.cameraPos
				modSaBan.myCamTarget = Me.myTerrain.cameraTarget
				modSaBan.myAngleZ = Me.myTerrain.GetAngleZ()
				modSaBan.myAngleX = Me.myTerrain.GetAngleX()
			End If
			If MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir) Then
				Dim text2 As String = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
				Dim text3 As String = modSaBan.mySaBanDir + "\DienTapMap.jpg"
				If MyProject.Computer.FileSystem.FileExists(text2) And MyProject.Computer.FileSystem.FileExists(text3) Then
					Try
						Dim dlg3DShow As Dlg3DShow = New Dlg3DShow()
						Dim bitmap As Bitmap = New Bitmap(text3)
						dlg3DShow.ShowDialog(bitmap, modSaBan.heightData, modSaBan.myCamPos, modSaBan.myCamTarget, text2, modSaBan.myLightDir, modSaBan.myAngleZ, modSaBan.myAngleX)
						bitmap.Dispose()
						dlg3DShow.Dispose()
					Catch expr_139 As Exception
						ProjectData.SetProjectError(expr_139)
						Dim ex As Exception = expr_139
						Throw ex
					End Try
				Else
					Interaction.MsgBox("Không th" & ChrW(7845) & "y file: " + text2 + ", " + text3, MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Không th" & ChrW(7845) & "y th" & ChrW(432) & " m" & ChrW(7909) & "c: " + modSaBan.mySaBanDir, MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub LoadDiaHinhToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim myDiaHinhDef As String = modSaBan.myDiaHinhDef
			Dim text As String = modSaBan.myDiaHinhDef
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.FileName = text
			openFileDialog.Filter = "Dia hinh def file (*.diahinh)|*.diahinh|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				text = openFileDialog.FileName
				If text.Length > 0 Then
					Me.bLoaded = Me.LoadPara2(text)
					If Not Me.bLoaded Then
						modSaBan.myDiaHinhDef = myDiaHinhDef
						If File.Exists(modSaBan.myDiaHinhDef) Then
							Me.bLoaded = Me.LoadPara2(modSaBan.myDiaHinhDef)
						End If
						If Not Me.bLoaded Then
							ProjectData.EndApp()
						End If
					End If
				End If
			End If
		End Sub

		Private Sub AxMap1_DrawUserLayer(sender As Object, e As CMapXEvents_DrawUserLayerEvent)
			Me.myBando.m_Map_DrawUserLayer(RuntimeHelpers.GetObjectValue(sender), e)
			If Not Information.IsNothing(modSaBan.fActions) Then
				Me.myVeActs.m_Map_DrawUserLayer(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		Private Sub AxMap1_KeyUpEvent(sender As Object, e As CMapXEvents_KeyUpEvent)
			Me.myBando.m_Map_KeyUpEvent(RuntimeHelpers.GetObjectValue(sender), e)
		End Sub

		Private Sub AxMap1_MapDraw(sender As Object, e As CMapXEvents_MapDrawEvent)
			Dim num2 As Integer
			Dim num3 As Integer
			Try
				IL_00:
				Dim num As Integer = 1
				If e.flag <> 2S Then
					GoTo IL_50
				End If
				IL_0B:
				num = 2
				If Not Me.ToolStripMenuBDView.Checked Then
					GoTo IL_2D
				End If
				IL_1A:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_21:
				num = 4
				modBanDo.fBanDoNho.UpdateHinhChuNhat()
				IL_2D:
				num = 6
				Me.myTerrain.ChangeDHFocus(Me.AxMap1.CenterX, Me.AxMap1.CenterY)
				IL_50:
				GoTo IL_C2
				IL_55:
				Dim arg_5A_0 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_5A_0)
				IL_83:
				GoTo IL_B7
				num3 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_95:
				GoTo IL_B7
			End Try
			Dim arg_97_0 As Object
			endfilter(TypeOf arg_97_0 Is Exception And num2 <> 0 And num3 = 0)
			IL_B7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C2:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub AxMap1_MapViewChanged(sender As Object, e As EventArgs)
			Me.ToolStripStatusLabel2.Text = String.Concat(New String() { Me.AxMap1.Zoom.ToString("#,# m"), " | ", Me.AxMap1.MapPaperWidth.ToString("#.## cm"), " | ", (Me.AxMap1.MapPaperWidth * modBanDo.BDSaiSo).ToString("#.## cm") })
		End Sub

		Private Sub AxMap1_MouseDownEvent(sender As Object, e As CMapXEvents_MouseDownEvent)
			Me.myBanDoNen.m_Map_MouseDownEvent(RuntimeHelpers.GetObjectValue(sender), e)
			If Me.CNToolStripButton.Checked Then
				Me.myBando.m_Map_MouseDownEvent(RuntimeHelpers.GetObjectValue(sender), e)
			End If
			If Not Information.IsNothing(modSaBan.fActions) Then
				Me.myVeActs.m_Map_MouseDownEvent(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		Private Sub AxMap1_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			Me.myBando.ShowTooltip(e)
			Me.myBanDoNen.m_Map_MouseMoveEvent(RuntimeHelpers.GetObjectValue(sender), e)
			If Me.CNToolStripButton.Checked Then
				Me.myBando.m_Map_MouseMoveEvent(RuntimeHelpers.GetObjectValue(sender), e)
			End If
			If Not Information.IsNothing(modSaBan.fActions) Then
				Me.myVeActs.m_Map_MouseMoveEvent(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		Private Sub AxMap1_MouseUpEvent(sender As Object, e As CMapXEvents_MouseUpEvent)
			If Me.CNToolStripButton.Checked Then
				Me.myBando.m_Map_MouseUpEvent(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		Private Sub AxMap1_ToolUsed(sender As Object, e As CMapXEvents_ToolUsedEvent)
			If e.toolNum = 3S Then
				Me.myBanDoNen.procThongTin(e.x1, e.y1)
			End If
		End Sub

		Private Sub myBando_ListKHChanged(seleSymbol As CSymbol)
			Me.PopulateListKH(seleSymbol)
		End Sub

		Private Sub myBando_SelectedSymbolChanged(seleSymbol As CSymbol)
			Me.lstCacKyHieu.SelectedIndex = Me.lstCacKyHieu.Items.IndexOf(seleSymbol)
		End Sub

		Private Sub PopulateListKH(pSymbol As CSymbol)
			Cursor.Current = Cursors.WaitCursor
			Me.lstCacKyHieu.DataSource = Nothing
			Me.lstCacKyHieu.DataSource = Me.myBando.drawingSymbols
			Try
				If Me.lstCacKyHieu.Items.Count > 0 Then
					Dim num As Integer = Me.myBando.drawingSymbols.get_IndexOf(pSymbol)
					If num > -1 Then
						Me.lstCacKyHieu.SetSelected(num, True)
					Else
						Me.lstCacKyHieu.SetSelected(0, True)
					End If
				End If
			Catch expr_75 As Exception
				ProjectData.SetProjectError(expr_75)
				Dim ex As Exception = expr_75
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		Private Sub UnseleKH()
			If Me.bLoaded AndAlso Me.myBando.myMapTool <> CBdTC.MapTools.None Then
				Me.myBando.UnseleKH()
			End If
		End Sub

		Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
			If e.ClickedItem Is Me.SelectorToolStripButton Then
				Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Else If e.ClickedItem Is Me.PanToolStripButton Then
				Me.AxMap1.CurrentTool = ToolConstants.miPanTool
				Me.UnseleKH()
			Else If e.ClickedItem Is Me.ZoomInToolStripButton Then
				Me.AxMap1.CurrentTool = ToolConstants.miZoomInTool
				Me.UnseleKH()
			Else If e.ClickedItem Is Me.ZoomOutToolStripButton Then
				Me.AxMap1.CurrentTool = ToolConstants.miZoomOutTool
				Me.UnseleKH()
			Else If e.ClickedItem Is Me.RullerToolStripButton Then
				Me.myBanDoNen.OnDoKhoangCach()
				Me.UnseleKH()
			Else If e.ClickedItem Is Me.Zoom1XToolStripButton Then
				Me.myBanDoNen.Zoom1X()
				Me.UnseleKH()
			Else If e.ClickedItem Is Me.BdTCDefToolStripButton Then
				Dim dlgDefBdTC As dlgDefBdTC = New dlgDefBdTC()
				Me.m_bNewBdTC = False
				If dlgDefBdTC.ShowDialog(Me) = DialogResult.OK Then
					Me.UpdatePage()
					Me.SaveBDTC(modSaBan.LastBdTC)
					Me.UnseleKH()
				End If
			Else
				Me.myBando.m_ToolStrip_ItemClicked(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		Private Sub lvPages_DragDrop(sender As Object, e As DragEventArgs)
			Me.UpdatePage()
			Dim listViewItem As ListViewItem = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
			If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", False) Then
				Dim arg_4A_0 As Control = CType(sender, ListView)
				Dim p As System.Drawing.Point = New System.Drawing.Point(e.X, e.Y)
				Dim point As System.Drawing.Point = arg_4A_0.PointToClient(p)
				Dim itemAt As ListViewItem = (CType(sender, ListView)).GetItemAt(point.X, point.Y)
				If itemAt IsNot listViewItem Then
					Dim iPage As Integer = Me.myPages.MoveItem(Conversions.ToInteger(listViewItem.Tag), Conversions.ToInteger(itemAt.Tag))
					Me.myDirty = True
					Me.RefreshBdTC(iPage)
				End If
			End If
		End Sub

		Private Sub lvPages_DragEnter(sender As Object, e As DragEventArgs)
			If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem") Then
				e.Effect = DragDropEffects.Move
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Sub lvPages_ItemDrag(sender As Object, e As ItemDragEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.DoDragDrop(RuntimeHelpers.GetObjectValue(e.Item), DragDropEffects.Copy Or DragDropEffects.Move)
			End If
		End Sub

		Private Sub ToJPGToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgToBitmap As dlgToBitmap = New dlgToBitmap()
			dlgToBitmap.ShowDialog(Me)
		End Sub

		Private Sub OLuoiJumpToToolStripMenuItem_Click(sender As Object, e As EventArgs)
			New dlgOLuoiGoto() With { .TopMost = True }.Show(Me)
		End Sub

		Private Sub OLuoiDefToolStripMenuItem_Click(sender As Object, e As EventArgs)
			New dlgOLuoiDef() With { .TopMost = True }.Show()
		End Sub

		Private Sub ShiftAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgShiftAll As dlgShiftAll = New dlgShiftAll()
			If dlgShiftAll.ShowDialog(Me) = DialogResult.OK Then
				Me.SaveToolStripMenuItem_Click(Nothing, Nothing)
			End If
		End Sub
	End Class
End Namespace
