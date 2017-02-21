Imports AxMapXLib
Imports BdTC.My
Imports BdTC.My.Resources
Imports DBiGraphicObjs.DBiGraphicObjects
Imports MapXLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports mySaBanLib
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
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
	Public Class frmMain
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripSeparator

		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripSeparator

		<AccessedThroughProperty("ToolStripMenuItem6")>
		Private _ToolStripMenuItem6 As ToolStripSeparator

		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

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

		<AccessedThroughProperty("ToolStripMenuBDView")>
		Private _ToolStripMenuBDView As ToolStripMenuItem

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

		<AccessedThroughProperty("ToolStripSeparator6")>
		Private _ToolStripSeparator6 As ToolStripSeparator

		<AccessedThroughProperty("TrangSauToolStripMenuItem")>
		Private _TrangSauToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("TrangTruocToolStripMenuItem")>
		Private _TrangTruocToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem7")>
		Private _ToolStripMenuItem7 As ToolStripSeparator

		<AccessedThroughProperty("ZoomToToolStripMenuItem")>
		Private _ZoomToToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator7")>
		Private _ToolStripSeparator7 As ToolStripSeparator

		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

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

		<AccessedThroughProperty("HideSymbolToolStripButton")>
		Private _HideSymbolToolStripButton As ToolStripButton

		<AccessedThroughProperty("DrawSymbolToolStripButton")>
		Private _DrawSymbolToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("PhanLoaiKyHieuToolStripMenuItem")>
		Private _PhanLoaiKyHieuToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("MuiTenDacToolStripButton")>
		Private _MuiTenDacToolStripButton As ToolStripButton

		<AccessedThroughProperty("AddPagesFromToolStripMenuItem")>
		Private _AddPagesFromToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator9")>
		Private _ToolStripSeparator9 As ToolStripSeparator

		<AccessedThroughProperty("ArcToolStripButton")>
		Private _ArcToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStripStatusLabel5")>
		Private _ToolStripStatusLabel5 As ToolStripStatusLabel

		<AccessedThroughProperty("RullerToolStripButton")>
		Private _RullerToolStripButton As ToolStripButton

		<AccessedThroughProperty("DemoDienTapToolStripMenuItem")>
		Private _DemoDienTapToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("MoTaDienBienToolStripMenuItem")>
		Private _MoTaDienBienToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("XemToolStripMenuItem")>
		Private _XemToolStripMenuItem As ToolStripMenuItem

		Private myPixelsPerGridX As Double

		Private myPixelsPerGridY As Double

		Private myDiaHinh As CTerrain

		Private m_TexImage As Bitmap

		Private heightData As Single(,)

		Private m_LastMapCX As Double

		Private m_LastMapCY As Double

		Friend myBando As CBanDo

		Public myLastZoom As Double

		Public myLastCX As Double

		Public myLastCY As Double

		Friend mySlides As CSlides

		Private CurrSlide As CSlide

		Private bLoaded As Boolean

		Public myDirty As Boolean

		Private m_Symbol3Objs As ArrayList

		Friend Overridable Property MenuStrip1() As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
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
				Me._Panel3 = value
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

		Friend Overridable Property Panel2() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
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

		Friend Overridable Property lstCacKyHieu() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstCacKyHieu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstCacKyHieu IsNot Nothing
				If flag Then
					RemoveHandler Me._lstCacKyHieu.DoubleClick, AddressOf Me.lstCacKyHieu_DoubleClick
				End If
				Me._lstCacKyHieu = value
				flag = (Me._lstCacKyHieu IsNot Nothing)
				If flag Then
					AddHandler Me._lstCacKyHieu.DoubleClick, AddressOf Me.lstCacKyHieu_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property lvPages() As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._lvPages
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim flag As Boolean = Me._lvPages IsNot Nothing
				If flag Then
					RemoveHandler Me._lvPages.Click, AddressOf Me.lvPages_Click
					RemoveHandler Me._lvPages.AfterLabelEdit, AddressOf Me.lvPages_AfterLabelEdit
				End If
				Me._lvPages = value
				flag = (Me._lvPages IsNot Nothing)
				If flag Then
					AddHandler Me._lvPages.Click, AddressOf Me.lvPages_Click
					AddHandler Me._lvPages.AfterLabelEdit, AddressOf Me.lvPages_AfterLabelEdit
				End If
			End Set
		End Property

		Friend Overridable Property FileToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FileToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property NewToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._NewToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewToolStripMenuItem.Click, AddressOf Me.NewToolStripMenuItem_Click
				End If
				Me._NewToolStripMenuItem = value
				flag = (Me._NewToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NewToolStripMenuItem.Click, AddressOf Me.NewToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem2() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem2 = value
			End Set
		End Property

		Friend Overridable Property OpenToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._OpenToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenToolStripMenuItem.Click, AddressOf Me.OpenToolStripMenuItem_Click
				End If
				Me._OpenToolStripMenuItem = value
				flag = (Me._OpenToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._OpenToolStripMenuItem.Click, AddressOf Me.OpenToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property SaveToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._SaveToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveToolStripMenuItem.Click, AddressOf Me.SaveToolStripMenuItem_Click
				End If
				Me._SaveToolStripMenuItem = value
				flag = (Me._SaveToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._SaveToolStripMenuItem.Click, AddressOf Me.SaveToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem1() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem6() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem6 = value
			End Set
		End Property

		Friend Overridable Property ExitToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ExitToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property PagesToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PagesToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._PagesToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property NewPageToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewPageToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._NewPageToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewPageToolStripMenuItem.Click, AddressOf Me.NewPageToolStripMenuItem_Click
				End If
				Me._NewPageToolStripMenuItem = value
				flag = (Me._NewPageToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NewPageToolStripMenuItem.Click, AddressOf Me.NewPageToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property DuplicatePageToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DuplicatePageToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._DuplicatePageToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DuplicatePageToolStripMenuItem.Click, AddressOf Me.DuplicatePageToolStripMenuItem_Click
				End If
				Me._DuplicatePageToolStripMenuItem = value
				flag = (Me._DuplicatePageToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DuplicatePageToolStripMenuItem.Click, AddressOf Me.DuplicatePageToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property CheDoToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CheDoToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._CheDoToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property StatusBarToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusBarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._StatusBarToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._StatusBarToolStripMenuItem.Click, AddressOf Me.StatusBarToolStripMenuItem_Click
					RemoveHandler Me._StatusBarToolStripMenuItem.CheckStateChanged, AddressOf Me.StatusBarToolStripMenuItem_CheckStateChanged
				End If
				Me._StatusBarToolStripMenuItem = value
				flag = (Me._StatusBarToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._StatusBarToolStripMenuItem.Click, AddressOf Me.StatusBarToolStripMenuItem_Click
					AddHandler Me._StatusBarToolStripMenuItem.CheckStateChanged, AddressOf Me.StatusBarToolStripMenuItem_CheckStateChanged
				End If
			End Set
		End Property

		Friend Overridable Property DanhSachToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DanhSachToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._DanhSachToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DanhSachToolStripMenuItem.Click, AddressOf Me.DanhSachToolStripMenuItem_Click
					RemoveHandler Me._DanhSachToolStripMenuItem.CheckStateChanged, AddressOf Me.DanhSachToolStripMenuItem_CheckStateChanged
				End If
				Me._DanhSachToolStripMenuItem = value
				flag = (Me._DanhSachToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DanhSachToolStripMenuItem.Click, AddressOf Me.DanhSachToolStripMenuItem_Click
					AddHandler Me._DanhSachToolStripMenuItem.CheckStateChanged, AddressOf Me.DanhSachToolStripMenuItem_CheckStateChanged
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem8() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem8 = value
			End Set
		End Property

		Friend Overridable Property SaBanToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaBanToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._SaBanToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaBanToolStripMenuItem.Click, AddressOf Me.SaBanToolStripMenuItem_Click
					RemoveHandler Me._SaBanToolStripMenuItem.CheckStateChanged, AddressOf Me.SaBanToolStripMenuItem_CheckStateChanged
				End If
				Me._SaBanToolStripMenuItem = value
				flag = (Me._SaBanToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._SaBanToolStripMenuItem.Click, AddressOf Me.SaBanToolStripMenuItem_Click
					AddHandler Me._SaBanToolStripMenuItem.CheckStateChanged, AddressOf Me.SaBanToolStripMenuItem_CheckStateChanged
				End If
			End Set
		End Property

		Friend Overridable Property BdTCToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._BdTCToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._BdTCToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._BdTCToolStripMenuItem.Click, AddressOf Me.BdTCToolStripMenuItem_Click
					RemoveHandler Me._BdTCToolStripMenuItem.CheckStateChanged, AddressOf Me.BdTCToolStripMenuItem_CheckStateChanged
				End If
				Me._BdTCToolStripMenuItem = value
				flag = (Me._BdTCToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._BdTCToolStripMenuItem.Click, AddressOf Me.BdTCToolStripMenuItem_Click
					AddHandler Me._BdTCToolStripMenuItem.CheckStateChanged, AddressOf Me.BdTCToolStripMenuItem_CheckStateChanged
				End If
			End Set
		End Property

		Friend Overridable Property LstKHContextMenuStrip() As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._LstKHContextMenuStrip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._LstKHContextMenuStrip = value
			End Set
		End Property

		Friend Overridable Property NhapNhayToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NhapNhayToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._NhapNhayToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NhapNhayToolStripMenuItem.Click, AddressOf Me.NhapNhayToolStripMenuItem_Click
				End If
				Me._NhapNhayToolStripMenuItem = value
				flag = (Me._NhapNhayToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NhapNhayToolStripMenuItem.Click, AddressOf Me.NhapNhayToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem3() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem3 = value
			End Set
		End Property

		Friend Overridable Property XoaToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._XoaToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._XoaToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._XoaToolStripMenuItem.Click, AddressOf Me.XoaToolStripMenuItem_Click
				End If
				Me._XoaToolStripMenuItem = value
				flag = (Me._XoaToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._XoaToolStripMenuItem.Click, AddressOf Me.XoaToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem4() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem4 = value
			End Set
		End Property

		Friend Overridable Property XoaTatToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._XoaTatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._XoaTatToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._XoaTatToolStripMenuItem.Click, AddressOf Me.XoaTatToolStripMenuItem_Click
				End If
				Me._XoaTatToolStripMenuItem = value
				flag = (Me._XoaTatToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._XoaTatToolStripMenuItem.Click, AddressOf Me.XoaTatToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem5() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem5 = value
			End Set
		End Property

		Friend Overridable Property RenameToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._RenameToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RenameToolStripMenuItem.Click, AddressOf Me.RenameToolStripMenuItem_Click
				End If
				Me._RenameToolStripMenuItem = value
				flag = (Me._RenameToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RenameToolStripMenuItem.Click, AddressOf Me.RenameToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property BanDoNenToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._BanDoNenToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._BanDoNenToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property ToolStripMenuBDView() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuBDView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._ToolStripMenuBDView IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuBDView.Click, AddressOf Me.ToolStripMenuBDView_Click
				End If
				Me._ToolStripMenuBDView = value
				flag = (Me._ToolStripMenuBDView IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuBDView.Click, AddressOf Me.ToolStripMenuBDView_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator4() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator4 = value
			End Set
		End Property

		Friend Overridable Property ToolStripMenuCacLopBD() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuCacLopBD
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._ToolStripMenuCacLopBD IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuCacLopBD.Click, AddressOf Me.ToolStripMenuCacLopBD_Click
				End If
				Me._ToolStripMenuCacLopBD = value
				flag = (Me._ToolStripMenuCacLopBD IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuCacLopBD.Click, AddressOf Me.ToolStripMenuCacLopBD_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuLuuGeoSet() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuLuuGeoSet
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._ToolStripMenuLuuGeoSet IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuLuuGeoSet.Click, AddressOf Me.ToolStripMenuLuuGeoSet_Click
				End If
				Me._ToolStripMenuLuuGeoSet = value
				flag = (Me._ToolStripMenuLuuGeoSet IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuLuuGeoSet.Click, AddressOf Me.ToolStripMenuLuuGeoSet_Click
				End If
			End Set
		End Property

		Friend Overridable Property lstPagesContextMenuStrip() As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._lstPagesContextMenuStrip
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._lstPagesContextMenuStrip = value
			End Set
		End Property

		Friend Overridable Property PageReNameToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PageReNameToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._PageReNameToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PageReNameToolStripMenuItem.Click, AddressOf Me.PageReNameToolStripMenuItem_Click
				End If
				Me._PageReNameToolStripMenuItem = value
				flag = (Me._PageReNameToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._PageReNameToolStripMenuItem.Click, AddressOf Me.PageReNameToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator5() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator5 = value
			End Set
		End Property

		Friend Overridable Property PageDeleteToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PageDeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._PageDeleteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PageDeleteToolStripMenuItem.Click, AddressOf Me.PageDeleteToolStripMenuItem_Click
				End If
				Me._PageDeleteToolStripMenuItem = value
				flag = (Me._PageDeleteToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._PageDeleteToolStripMenuItem.Click, AddressOf Me.PageDeleteToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator6() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator6 = value
			End Set
		End Property

		Friend Overridable Property TrangSauToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TrangSauToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._TrangSauToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._TrangSauToolStripMenuItem.Click, AddressOf Me.TrangSauToolStripMenuItem_Click
				End If
				Me._TrangSauToolStripMenuItem = value
				flag = (Me._TrangSauToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._TrangSauToolStripMenuItem.Click, AddressOf Me.TrangSauToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property TrangTruocToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._TrangTruocToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._TrangTruocToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._TrangTruocToolStripMenuItem.Click, AddressOf Me.TrangTruocToolStripMenuItem_Click
				End If
				Me._TrangTruocToolStripMenuItem = value
				flag = (Me._TrangTruocToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._TrangTruocToolStripMenuItem.Click, AddressOf Me.TrangTruocToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem7() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem7 = value
			End Set
		End Property

		Friend Overridable Property ZoomToToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ZoomToToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._ZoomToToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ZoomToToolStripMenuItem.Click, AddressOf Me.ZoomToToolStripMenuItem_Click
				End If
				Me._ZoomToToolStripMenuItem = value
				flag = (Me._ZoomToToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._ZoomToToolStripMenuItem.Click, AddressOf Me.ZoomToToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator7() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator7 = value
			End Set
		End Property

		Friend Overridable Property SaveAsToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, AddressOf Me.SaveAsToolStripMenuItem_Click
				End If
				Me._SaveAsToolStripMenuItem = value
				flag = (Me._SaveAsToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, AddressOf Me.SaveAsToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripMenuItem9() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripMenuItem9 = value
			End Set
		End Property

		Friend Overridable Property ShowAllToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ShowAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._ShowAllToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ShowAllToolStripMenuItem.Click, AddressOf Me.ShowAllToolStripMenuItem_Click
				End If
				Me._ShowAllToolStripMenuItem = value
				flag = (Me._ShowAllToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._ShowAllToolStripMenuItem.Click, AddressOf Me.ShowAllToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property Splitter3D() As Splitter
			<DebuggerNonUserCode()>
			Get
				Return Me._Splitter3D
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Splitter)
				Me._Splitter3D = value
			End Set
		End Property

		Friend Overridable Property Panel3D() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel3D
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim flag As Boolean = Me._Panel3D IsNot Nothing
				If flag Then
					RemoveHandler Me._Panel3D.MouseClick, AddressOf Me.Panel3D_MouseClick
				End If
				Me._Panel3D = value
				flag = (Me._Panel3D IsNot Nothing)
				If flag Then
					AddHandler Me._Panel3D.MouseClick, AddressOf Me.Panel3D_MouseClick
				End If
			End Set
		End Property

		Friend Overridable Property Panel2DMap() As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2DMap
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2DMap = value
			End Set
		End Property

		Friend Overridable Property AxMap1() As AxMap
			<DebuggerNonUserCode()>
			Get
				Return Me._AxMap1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxMap)
				Dim flag As Boolean = Me._AxMap1 IsNot Nothing
				If flag Then
					RemoveHandler Me._AxMap1.MapDraw, AddressOf Me.AxMap1_MapDraw
				End If
				Me._AxMap1 = value
				flag = (Me._AxMap1 IsNot Nothing)
				If flag Then
					AddHandler Me._AxMap1.MapDraw, AddressOf Me.AxMap1_MapDraw
				End If
			End Set
		End Property

		Friend Overridable Property StatusStrip1() As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel1() As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel2() As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel2 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel3() As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel3 = value
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel4() As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel4 = value
			End Set
		End Property

		Friend Overridable Property ToolStrip1() As ToolStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStrip)
				Me._ToolStrip1 = value
			End Set
		End Property

		Friend Overridable Property SelectorToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._SelectorToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._SelectorToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._SelectorToolStripButton.Click, AddressOf Me.SelectorToolStripButton_Click
				End If
				Me._SelectorToolStripButton = value
				flag = (Me._SelectorToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._SelectorToolStripButton.Click, AddressOf Me.SelectorToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property PanToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._PanToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._PanToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._PanToolStripButton.Click, AddressOf Me.PanToolStripButton_Click
				End If
				Me._PanToolStripButton = value
				flag = (Me._PanToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._PanToolStripButton.Click, AddressOf Me.PanToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ZoomInToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ZoomInToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ZoomInToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ZoomInToolStripButton.Click, AddressOf Me.ZoomInToolStripButton_Click
				End If
				Me._ZoomInToolStripButton = value
				flag = (Me._ZoomInToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ZoomInToolStripButton.Click, AddressOf Me.ZoomInToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ZoomOutToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ZoomOutToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ZoomOutToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ZoomOutToolStripButton.Click, AddressOf Me.ZoomOutToolStripButton_Click
				End If
				Me._ZoomOutToolStripButton = value
				flag = (Me._ZoomOutToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ZoomOutToolStripButton.Click, AddressOf Me.ZoomOutToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property Zoom1XToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Zoom1XToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._Zoom1XToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._Zoom1XToolStripButton.Click, AddressOf Me.Zoom1XToolStripButton_Click
				End If
				Me._Zoom1XToolStripButton = value
				flag = (Me._Zoom1XToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._Zoom1XToolStripButton.Click, AddressOf Me.Zoom1XToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator1() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		Friend Overridable Property CNToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._CNToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._CNToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._CNToolStripButton.Click, AddressOf Me.CNToolStripButton_Click
				End If
				Me._CNToolStripButton = value
				flag = (Me._CNToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._CNToolStripButton.Click, AddressOf Me.CNToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property SymbolToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._SymbolToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._SymbolToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._SymbolToolStripButton.Click, AddressOf Me.SymbolToolStripButton_Click
				End If
				Me._SymbolToolStripButton = value
				flag = (Me._SymbolToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._SymbolToolStripButton.Click, AddressOf Me.SymbolToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property UndoToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._UndoToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._UndoToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._UndoToolStripButton.Click, AddressOf Me.UndoToolStripButton_Click
				End If
				Me._UndoToolStripButton = value
				flag = (Me._UndoToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._UndoToolStripButton.Click, AddressOf Me.UndoToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property RedoToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RedoToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._RedoToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._RedoToolStripButton.Click, AddressOf Me.RedoToolStripButton_Click
				End If
				Me._RedoToolStripButton = value
				flag = (Me._RedoToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._RedoToolStripButton.Click, AddressOf Me.RedoToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property MuiTenDonToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._MuiTenDonToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._MuiTenDonToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._MuiTenDonToolStripButton.Click, AddressOf Me.MuiTenDonToolStripButton_Click
				End If
				Me._MuiTenDonToolStripButton = value
				flag = (Me._MuiTenDonToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._MuiTenDonToolStripButton.Click, AddressOf Me.MuiTenDonToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ClosedCurveToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ClosedCurveToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ClosedCurveToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ClosedCurveToolStripButton.Click, AddressOf Me.ClosedCurveToolStripButton_Click
				End If
				Me._ClosedCurveToolStripButton = value
				flag = (Me._ClosedCurveToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ClosedCurveToolStripButton.Click, AddressOf Me.ClosedCurveToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property CurveToolStripSplitButton() As ToolStripSplitButton
			<DebuggerNonUserCode()>
			Get
				Return Me._CurveToolStripSplitButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSplitButton)
				Dim flag As Boolean = Me._CurveToolStripSplitButton IsNot Nothing
				If flag Then
					RemoveHandler Me._CurveToolStripSplitButton.Click, AddressOf Me.CurveToolStripSplitButton_Click
				End If
				Me._CurveToolStripSplitButton = value
				flag = (Me._CurveToolStripSplitButton IsNot Nothing)
				If flag Then
					AddHandler Me._CurveToolStripSplitButton.Click, AddressOf Me.CurveToolStripSplitButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property SongSongKinToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._SongSongKinToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._SongSongKinToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._SongSongKinToolStripButton.Click, AddressOf Me.SongSongKinToolStripButton_Click
				End If
				Me._SongSongKinToolStripButton = value
				flag = (Me._SongSongKinToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._SongSongKinToolStripButton.Click, AddressOf Me.SongSongKinToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property LineToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._LineToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._LineToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._LineToolStripButton.Click, AddressOf Me.LineToolStripButton_Click
				End If
				Me._LineToolStripButton = value
				flag = (Me._LineToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._LineToolStripButton.Click, AddressOf Me.LineToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property PolygonToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._PolygonToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._PolygonToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._PolygonToolStripButton.Click, AddressOf Me.PolygonToolStripButton_Click
				End If
				Me._PolygonToolStripButton = value
				flag = (Me._PolygonToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._PolygonToolStripButton.Click, AddressOf Me.PolygonToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property RectangleToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RectangleToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._RectangleToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._RectangleToolStripButton.Click, AddressOf Me.RectangleToolStripButton_Click
				End If
				Me._RectangleToolStripButton = value
				flag = (Me._RectangleToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._RectangleToolStripButton.Click, AddressOf Me.RectangleToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property EllipseToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._EllipseToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._EllipseToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._EllipseToolStripButton.Click, AddressOf Me.EllipseToolStripButton_Click
				End If
				Me._EllipseToolStripButton = value
				flag = (Me._EllipseToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._EllipseToolStripButton.Click, AddressOf Me.EllipseToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property TextToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._TextToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._TextToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._TextToolStripButton.Click, AddressOf Me.TextToolStripButton_Click
				End If
				Me._TextToolStripButton = value
				flag = (Me._TextToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._TextToolStripButton.Click, AddressOf Me.TextToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property TableToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._TableToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._TableToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._TableToolStripButton.Click, AddressOf Me.TableToolStripButton_Click
				End If
				Me._TableToolStripButton = value
				flag = (Me._TableToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._TableToolStripButton.Click, AddressOf Me.TableToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property OptionsToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._OptionsToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._OptionsToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._OptionsToolStripButton.Click, AddressOf Me.OptionsToolStripButton_Click
				End If
				Me._OptionsToolStripButton = value
				flag = (Me._OptionsToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._OptionsToolStripButton.Click, AddressOf Me.OptionsToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStrip2() As ToolStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStrip2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStrip)
				Me._ToolStrip2 = value
			End Set
		End Property

		Friend Overridable Property HideSymbolToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._HideSymbolToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._HideSymbolToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._HideSymbolToolStripButton.Click, AddressOf Me.HideSymbolToolStripButton_Click
				End If
				Me._HideSymbolToolStripButton = value
				flag = (Me._HideSymbolToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._HideSymbolToolStripButton.Click, AddressOf Me.HideSymbolToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property DrawSymbolToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._DrawSymbolToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._DrawSymbolToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._DrawSymbolToolStripButton.Click, AddressOf Me.DrawSymbolToolStripButton_Click
				End If
				Me._DrawSymbolToolStripButton = value
				flag = (Me._DrawSymbolToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._DrawSymbolToolStripButton.Click, AddressOf Me.DrawSymbolToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator2() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		Friend Overridable Property PhanLoaiKyHieuToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PhanLoaiKyHieuToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._PhanLoaiKyHieuToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PhanLoaiKyHieuToolStripMenuItem.Click, AddressOf Me.PhanLoaiKyHieuToolStripMenuItem_Click
				End If
				Me._PhanLoaiKyHieuToolStripMenuItem = value
				flag = (Me._PhanLoaiKyHieuToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._PhanLoaiKyHieuToolStripMenuItem.Click, AddressOf Me.PhanLoaiKyHieuToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property MuiTenDacToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._MuiTenDacToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._MuiTenDacToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._MuiTenDacToolStripButton.Click, AddressOf Me.MuiTenDacToolStripButton_Click
				End If
				Me._MuiTenDacToolStripButton = value
				flag = (Me._MuiTenDacToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._MuiTenDacToolStripButton.Click, AddressOf Me.MuiTenDacToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property AddPagesFromToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AddPagesFromToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._AddPagesFromToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._AddPagesFromToolStripMenuItem.Click, AddressOf Me.AddPagesFromToolStripMenuItem_Click
				End If
				Me._AddPagesFromToolStripMenuItem = value
				flag = (Me._AddPagesFromToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._AddPagesFromToolStripMenuItem.Click, AddressOf Me.AddPagesFromToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator9() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator9 = value
			End Set
		End Property

		Friend Overridable Property ArcToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ArcToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ArcToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ArcToolStripButton.Click, AddressOf Me.ArcToolStripButton_Click
				End If
				Me._ArcToolStripButton = value
				flag = (Me._ArcToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ArcToolStripButton.Click, AddressOf Me.ArcToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel5() As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel5 = value
			End Set
		End Property

		Friend Overridable Property RullerToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RullerToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._RullerToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._RullerToolStripButton.Click, AddressOf Me.RullerToolStripButton_Click
				End If
				Me._RullerToolStripButton = value
				flag = (Me._RullerToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._RullerToolStripButton.Click, AddressOf Me.RullerToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property DemoDienTapToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DemoDienTapToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._DemoDienTapToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property MoTaDienBienToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MoTaDienBienToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._MoTaDienBienToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._MoTaDienBienToolStripMenuItem.Click, AddressOf Me.MoTaDienBienToolStripMenuItem_Click
				End If
				Me._MoTaDienBienToolStripMenuItem = value
				flag = (Me._MoTaDienBienToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._MoTaDienBienToolStripMenuItem.Click, AddressOf Me.MoTaDienBienToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property XemToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._XemToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._XemToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._XemToolStripMenuItem.Click, AddressOf Me.XemToolStripMenuItem_Click
				End If
				Me._XemToolStripMenuItem = value
				flag = (Me._XemToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._XemToolStripMenuItem.Click, AddressOf Me.XemToolStripMenuItem_Click
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmMain))
			Me.MenuStrip1 = New MenuStrip()
			Me.FileToolStripMenuItem = New ToolStripMenuItem()
			Me.NewToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator7 = New ToolStripSeparator()
			Me.OpenToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem2 = New ToolStripSeparator()
			Me.AddPagesFromToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator9 = New ToolStripSeparator()
			Me.SaveToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem1 = New ToolStripSeparator()
			Me.SaveAsToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem6 = New ToolStripSeparator()
			Me.ExitToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.PhanLoaiKyHieuToolStripMenuItem = New ToolStripMenuItem()
			Me.BanDoNenToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuBDView = New ToolStripMenuItem()
			Me.ToolStripSeparator4 = New ToolStripSeparator()
			Me.ToolStripMenuCacLopBD = New ToolStripMenuItem()
			Me.ToolStripMenuLuuGeoSet = New ToolStripMenuItem()
			Me.ToolStripMenuItem7 = New ToolStripSeparator()
			Me.ZoomToToolStripMenuItem = New ToolStripMenuItem()
			Me.PagesToolStripMenuItem = New ToolStripMenuItem()
			Me.NewPageToolStripMenuItem = New ToolStripMenuItem()
			Me.DuplicatePageToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator6 = New ToolStripSeparator()
			Me.TrangSauToolStripMenuItem = New ToolStripMenuItem()
			Me.TrangTruocToolStripMenuItem = New ToolStripMenuItem()
			Me.CheDoToolStripMenuItem = New ToolStripMenuItem()
			Me.BdTCToolStripMenuItem = New ToolStripMenuItem()
			Me.SaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem8 = New ToolStripSeparator()
			Me.StatusBarToolStripMenuItem = New ToolStripMenuItem()
			Me.DanhSachToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem9 = New ToolStripSeparator()
			Me.ShowAllToolStripMenuItem = New ToolStripMenuItem()
			Me.DemoDienTapToolStripMenuItem = New ToolStripMenuItem()
			Me.MoTaDienBienToolStripMenuItem = New ToolStripMenuItem()
			Me.XemToolStripMenuItem = New ToolStripMenuItem()
			Me.Panel1 = New Panel()
			Me.Panel4 = New Panel()
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
			Me.SelectorToolStripButton = New ToolStripButton()
			Me.PanToolStripButton = New ToolStripButton()
			Me.ZoomInToolStripButton = New ToolStripButton()
			Me.ZoomOutToolStripButton = New ToolStripButton()
			Me.Zoom1XToolStripButton = New ToolStripButton()
			Me.RullerToolStripButton = New ToolStripButton()
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
			Me.HideSymbolToolStripButton = New ToolStripButton()
			Me.DrawSymbolToolStripButton = New ToolStripButton()
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
			Me.MenuStrip1.Items.AddRange(New ToolStripItem() { Me.FileToolStripMenuItem, Me.BanDoNenToolStripMenuItem, Me.PagesToolStripMenuItem, Me.CheDoToolStripMenuItem, Me.DemoDienTapToolStripMenuItem })
			Dim arg_5B3_0 As Control = Me.MenuStrip1
			Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
			arg_5B3_0.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim arg_5E0_0 As Control = Me.MenuStrip1
			Dim size As Size = New Size(897, 24)
			arg_5E0_0.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.NewToolStripMenuItem, Me.ToolStripSeparator7, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem2, Me.AddPagesFromToolStripMenuItem, Me.ToolStripSeparator9, Me.SaveToolStripMenuItem, Me.ToolStripMenuItem1, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem6, Me.ExitToolStripMenuItem, Me.ToolStripSeparator2, Me.PhanLoaiKyHieuToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim arg_6C8_0 As ToolStripItem = Me.FileToolStripMenuItem
			size = New Size(39, 20)
			arg_6C8_0.Size = size
			Me.FileToolStripMenuItem.Text = "T" & ChrW(7879) & "p"
			Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
			Dim arg_706_0 As ToolStripItem = Me.NewToolStripMenuItem
			size = New Size(183, 22)
			arg_706_0.Size = size
			Me.NewToolStripMenuItem.Text = "B" & ChrW(273) & "TC m" & ChrW(7899) & "i"
			Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
			Dim arg_743_0 As ToolStripItem = Me.ToolStripSeparator7
			size = New Size(180, 6)
			arg_743_0.Size = size
			Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
			Dim arg_770_0 As ToolStripItem = Me.OpenToolStripMenuItem
			size = New Size(183, 22)
			arg_770_0.Size = size
			Me.OpenToolStripMenuItem.Text = "M" & ChrW(7903) & " B" & ChrW(273) & "TC"
			Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
			Dim arg_7AD_0 As ToolStripItem = Me.ToolStripMenuItem2
			size = New Size(180, 6)
			arg_7AD_0.Size = size
			Me.AddPagesFromToolStripMenuItem.Name = "AddPagesFromToolStripMenuItem"
			Dim arg_7DA_0 As ToolStripItem = Me.AddPagesFromToolStripMenuItem
			size = New Size(183, 22)
			arg_7DA_0.Size = size
			Me.AddPagesFromToolStripMenuItem.Text = "Thêm các trang t" & ChrW(7915) & " ..."
			Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
			Dim arg_817_0 As ToolStripItem = Me.ToolStripSeparator9
			size = New Size(180, 6)
			arg_817_0.Size = size
			Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
			Dim arg_844_0 As ToolStripItem = Me.SaveToolStripMenuItem
			size = New Size(183, 22)
			arg_844_0.Size = size
			Me.SaveToolStripMenuItem.Text = "L" & ChrW(432) & "u B" & ChrW(273) & "TC"
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim arg_881_0 As ToolStripItem = Me.ToolStripMenuItem1
			size = New Size(180, 6)
			arg_881_0.Size = size
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Dim arg_8AE_0 As ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Size(183, 22)
			arg_8AE_0.Size = size
			Me.SaveAsToolStripMenuItem.Text = "L" & ChrW(432) & "u nh" & ChrW(432) & " ..."
			Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
			Dim arg_8EB_0 As ToolStripItem = Me.ToolStripMenuItem6
			size = New Size(180, 6)
			arg_8EB_0.Size = size
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim arg_918_0 As ToolStripItem = Me.ExitToolStripMenuItem
			size = New Size(183, 22)
			arg_918_0.Size = size
			Me.ExitToolStripMenuItem.Text = "Thoát"
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim arg_955_0 As ToolStripItem = Me.ToolStripSeparator2
			size = New Size(180, 6)
			arg_955_0.Size = size
			Me.PhanLoaiKyHieuToolStripMenuItem.Name = "PhanLoaiKyHieuToolStripMenuItem"
			Dim arg_982_0 As ToolStripItem = Me.PhanLoaiKyHieuToolStripMenuItem
			size = New Size(183, 22)
			arg_982_0.Size = size
			Me.PhanLoaiKyHieuToolStripMenuItem.Text = "Các nhóm ký hi" & ChrW(7879) & "u"
			Me.BanDoNenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.ToolStripMenuBDView, Me.ToolStripSeparator4, Me.ToolStripMenuCacLopBD, Me.ToolStripMenuLuuGeoSet, Me.ToolStripMenuItem7, Me.ZoomToToolStripMenuItem })
			Me.BanDoNenToolStripMenuItem.Name = "BanDoNenToolStripMenuItem"
			Dim arg_A12_0 As ToolStripItem = Me.BanDoNenToolStripMenuItem
			size = New Size(79, 20)
			arg_A12_0.Size = size
			Me.BanDoNenToolStripMenuItem.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7893) & " n" & ChrW(7873) & "n"
			Me.ToolStripMenuBDView.Name = "ToolStripMenuBDView"
			Dim arg_A50_0 As ToolStripItem = Me.ToolStripMenuBDView
			size = New Size(183, 22)
			arg_A50_0.Size = size
			Me.ToolStripMenuBDView.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " nh" & ChrW(7887)
			Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
			Dim arg_A8D_0 As ToolStripItem = Me.ToolStripSeparator4
			size = New Size(180, 6)
			arg_A8D_0.Size = size
			Me.ToolStripMenuCacLopBD.Name = "ToolStripMenuCacLopBD"
			Dim arg_ABA_0 As ToolStripItem = Me.ToolStripMenuCacLopBD
			size = New Size(183, 22)
			arg_ABA_0.Size = size
			Me.ToolStripMenuCacLopBD.Text = "Các l" & ChrW(7899) & "p B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.ToolStripMenuLuuGeoSet.Name = "ToolStripMenuLuuGeoSet"
			Dim arg_AF8_0 As ToolStripItem = Me.ToolStripMenuLuuGeoSet
			size = New Size(183, 22)
			arg_AF8_0.Size = size
			Me.ToolStripMenuLuuGeoSet.Text = "L" & ChrW(432) & "u c" & ChrW(7845) & "u hình B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
			Dim arg_B35_0 As ToolStripItem = Me.ToolStripMenuItem7
			size = New Size(180, 6)
			arg_B35_0.Size = size
			Me.ZoomToToolStripMenuItem.Name = "ZoomToToolStripMenuItem"
			Dim arg_B62_0 As ToolStripItem = Me.ZoomToToolStripMenuItem
			size = New Size(183, 22)
			arg_B62_0.Size = size
			Me.ZoomToToolStripMenuItem.Text = "Phóng b" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.PagesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.NewPageToolStripMenuItem, Me.DuplicatePageToolStripMenuItem, Me.ToolStripSeparator6, Me.TrangSauToolStripMenuItem, Me.TrangTruocToolStripMenuItem })
			Me.PagesToolStripMenuItem.Name = "PagesToolStripMenuItem"
			Dim arg_BE8_0 As ToolStripItem = Me.PagesToolStripMenuItem
			size = New Size(75, 20)
			arg_BE8_0.Size = size
			Me.PagesToolStripMenuItem.Text = "Các_Trang"
			Me.NewPageToolStripMenuItem.Name = "NewPageToolStripMenuItem"
			Dim arg_C26_0 As ToolStripItem = Me.NewPageToolStripMenuItem
			size = New Size(146, 22)
			arg_C26_0.Size = size
			Me.NewPageToolStripMenuItem.Text = "Trang m" & ChrW(7899) & "i"
			Me.DuplicatePageToolStripMenuItem.Name = "DuplicatePageToolStripMenuItem"
			Dim arg_C64_0 As ToolStripItem = Me.DuplicatePageToolStripMenuItem
			size = New Size(146, 22)
			arg_C64_0.Size = size
			Me.DuplicatePageToolStripMenuItem.Text = "B" & ChrW(7843) & "n sao trang"
			Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
			Dim arg_CA1_0 As ToolStripItem = Me.ToolStripSeparator6
			size = New Size(143, 6)
			arg_CA1_0.Size = size
			Me.TrangSauToolStripMenuItem.Name = "TrangSauToolStripMenuItem"
			Dim arg_CCE_0 As ToolStripItem = Me.TrangSauToolStripMenuItem
			size = New Size(146, 22)
			arg_CCE_0.Size = size
			Me.TrangSauToolStripMenuItem.Text = "Trang sau"
			Me.TrangTruocToolStripMenuItem.Name = "TrangTruocToolStripMenuItem"
			Dim arg_D0C_0 As ToolStripItem = Me.TrangTruocToolStripMenuItem
			size = New Size(146, 22)
			arg_D0C_0.Size = size
			Me.TrangTruocToolStripMenuItem.Text = "Trang Tr" & ChrW(432) & ChrW(7899) & "c"
			Me.CheDoToolStripMenuItem.Checked = True
			Me.CheDoToolStripMenuItem.CheckState = CheckState.Checked
			Me.CheDoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.BdTCToolStripMenuItem, Me.SaBanToolStripMenuItem, Me.ToolStripMenuItem8, Me.StatusBarToolStripMenuItem, Me.DanhSachToolStripMenuItem, Me.ToolStripMenuItem9, Me.ShowAllToolStripMenuItem })
			Me.CheDoToolStripMenuItem.Name = "CheDoToolStripMenuItem"
			Dim arg_DC0_0 As ToolStripItem = Me.CheDoToolStripMenuItem
			size = New Size(43, 20)
			arg_DC0_0.Size = size
			Me.CheDoToolStripMenuItem.Text = "Xem"
			Me.BdTCToolStripMenuItem.Checked = True
			Me.BdTCToolStripMenuItem.CheckState = CheckState.Checked
			Me.BdTCToolStripMenuItem.Name = "BdTCToolStripMenuItem"
			Dim arg_E18_0 As ToolStripItem = Me.BdTCToolStripMenuItem
			size = New Size(225, 22)
			arg_E18_0.Size = size
			Me.BdTCToolStripMenuItem.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n"
			Me.SaBanToolStripMenuItem.Checked = True
			Me.SaBanToolStripMenuItem.CheckState = CheckState.Checked
			Me.SaBanToolStripMenuItem.Name = "SaBanToolStripMenuItem"
			Dim arg_E70_0 As ToolStripItem = Me.SaBanToolStripMenuItem
			size = New Size(225, 22)
			arg_E70_0.Size = size
			Me.SaBanToolStripMenuItem.Text = ChrW(272) & ChrW(7883) & "a hình"
			Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
			Dim arg_EAD_0 As ToolStripItem = Me.ToolStripMenuItem8
			size = New Size(222, 6)
			arg_EAD_0.Size = size
			Me.StatusBarToolStripMenuItem.Checked = True
			Me.StatusBarToolStripMenuItem.CheckState = CheckState.Checked
			Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
			Dim arg_EF4_0 As ToolStripItem = Me.StatusBarToolStripMenuItem
			size = New Size(225, 22)
			arg_EF4_0.Size = size
			Me.StatusBarToolStripMenuItem.Text = "Thanh tr" & ChrW(7841) & "ng thái"
			Me.DanhSachToolStripMenuItem.Checked = True
			Me.DanhSachToolStripMenuItem.CheckState = CheckState.Checked
			Me.DanhSachToolStripMenuItem.Name = "DanhSachToolStripMenuItem"
			Dim arg_F4C_0 As ToolStripItem = Me.DanhSachToolStripMenuItem
			size = New Size(225, 22)
			arg_F4C_0.Size = size
			Me.DanhSachToolStripMenuItem.Text = "Danh sách các trang, ký hi" & ChrW(7879) & "u"
			Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
			Dim arg_F89_0 As ToolStripItem = Me.ToolStripMenuItem9
			size = New Size(222, 6)
			arg_F89_0.Size = size
			Me.ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
			Dim arg_FB6_0 As ToolStripItem = Me.ShowAllToolStripMenuItem
			size = New Size(225, 22)
			arg_FB6_0.Size = size
			Me.ShowAllToolStripMenuItem.Text = "Xem toàn màn hình"
			Me.DemoDienTapToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.MoTaDienBienToolStripMenuItem, Me.XemToolStripMenuItem })
			Me.DemoDienTapToolStripMenuItem.Name = "DemoDienTapToolStripMenuItem"
			Dim arg_101E_0 As ToolStripItem = Me.DemoDienTapToolStripMenuItem
			size = New Size(73, 20)
			arg_101E_0.Size = size
			Me.DemoDienTapToolStripMenuItem.Text = "Trình di" & ChrW(7877) & "n"
			Me.MoTaDienBienToolStripMenuItem.Name = "MoTaDienBienToolStripMenuItem"
			Dim arg_1059_0 As ToolStripItem = Me.MoTaDienBienToolStripMenuItem
			size = New Size(120, 22)
			arg_1059_0.Size = size
			Me.MoTaDienBienToolStripMenuItem.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.XemToolStripMenuItem.Name = "XemToolStripMenuItem"
			Dim arg_1094_0 As ToolStripItem = Me.XemToolStripMenuItem
			size = New Size(120, 22)
			arg_1094_0.Size = size
			Me.XemToolStripMenuItem.Text = "Xem"
			Me.Panel1.Controls.Add(Me.Panel4)
			Me.Panel1.Controls.Add(Me.Splitter2)
			Me.Panel1.Controls.Add(Me.Panel3)
			Me.Panel1.Dock = DockStyle.Left
			Dim arg_110F_0 As Control = Me.Panel1
			location = New System.Drawing.Point(0, 24)
			arg_110F_0.Location = location
			Me.Panel1.Name = "Panel1"
			Dim arg_113F_0 As Control = Me.Panel1
			size = New Size(175, 618)
			arg_113F_0.Size = size
			Me.Panel1.TabIndex = 1
			Me.Panel4.BorderStyle = BorderStyle.Fixed3D
			Me.Panel4.Controls.Add(Me.lstCacKyHieu)
			Me.Panel4.Dock = DockStyle.Fill
			Dim arg_1198_0 As Control = Me.Panel4
			location = New System.Drawing.Point(0, 171)
			arg_1198_0.Location = location
			Me.Panel4.Name = "Panel4"
			Dim arg_11C8_0 As Control = Me.Panel4
			size = New Size(175, 447)
			arg_11C8_0.Size = size
			Me.Panel4.TabIndex = 2
			Me.lstCacKyHieu.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstCacKyHieu.ContextMenuStrip = Me.LstKHContextMenuStrip
			Me.lstCacKyHieu.FormattingEnabled = True
			Dim arg_121A_0 As Control = Me.lstCacKyHieu
			location = New System.Drawing.Point(3, 10)
			arg_121A_0.Location = location
			Me.lstCacKyHieu.Name = "lstCacKyHieu"
			Dim arg_124A_0 As Control = Me.lstCacKyHieu
			size = New Size(164, 420)
			arg_124A_0.Size = size
			Me.lstCacKyHieu.TabIndex = 1
			Me.LstKHContextMenuStrip.Items.AddRange(New ToolStripItem() { Me.NhapNhayToolStripMenuItem, Me.ToolStripMenuItem3, Me.XoaToolStripMenuItem, Me.ToolStripMenuItem4, Me.XoaTatToolStripMenuItem, Me.ToolStripMenuItem5, Me.RenameToolStripMenuItem })
			Me.LstKHContextMenuStrip.Name = "LstKHContextMenuStrip"
			Dim arg_12E3_0 As Control = Me.LstKHContextMenuStrip
			size = New Size(167, 110)
			arg_12E3_0.Size = size
			Me.NhapNhayToolStripMenuItem.Name = "NhapNhayToolStripMenuItem"
			Dim arg_1310_0 As ToolStripItem = Me.NhapNhayToolStripMenuItem
			size = New Size(166, 22)
			arg_1310_0.Size = size
			Me.NhapNhayToolStripMenuItem.Text = "Nh" & ChrW(7845) & "p nháy"
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Dim arg_134D_0 As ToolStripItem = Me.ToolStripMenuItem3
			size = New Size(163, 6)
			arg_134D_0.Size = size
			Me.XoaToolStripMenuItem.Name = "XoaToolStripMenuItem"
			Dim arg_137A_0 As ToolStripItem = Me.XoaToolStripMenuItem
			size = New Size(166, 22)
			arg_137A_0.Size = size
			Me.XoaToolStripMenuItem.Text = "Xóa"
			Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
			Dim arg_13B7_0 As ToolStripItem = Me.ToolStripMenuItem4
			size = New Size(163, 6)
			arg_13B7_0.Size = size
			Me.XoaTatToolStripMenuItem.Name = "XoaTatToolStripMenuItem"
			Dim arg_13E4_0 As ToolStripItem = Me.XoaTatToolStripMenuItem
			size = New Size(166, 22)
			arg_13E4_0.Size = size
			Me.XoaTatToolStripMenuItem.Text = "Xóa t" & ChrW(7845) & "t c" & ChrW(7843) & " các KH"
			Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
			Dim arg_1421_0 As ToolStripItem = Me.ToolStripMenuItem5
			size = New Size(163, 6)
			arg_1421_0.Size = size
			Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
			Dim arg_144E_0 As ToolStripItem = Me.RenameToolStripMenuItem
			size = New Size(166, 22)
			arg_144E_0.Size = size
			Me.RenameToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i ghi chú"
			Me.Splitter2.Dock = DockStyle.Top
			Dim arg_1487_0 As Control = Me.Splitter2
			location = New System.Drawing.Point(0, 168)
			arg_1487_0.Location = location
			Me.Splitter2.Name = "Splitter2"
			Dim arg_14B3_0 As Control = Me.Splitter2
			size = New Size(175, 3)
			arg_14B3_0.Size = size
			Me.Splitter2.TabIndex = 1
			Me.Splitter2.TabStop = False
			Me.Panel3.BorderStyle = BorderStyle.Fixed3D
			Me.Panel3.Controls.Add(Me.lvPages)
			Me.Panel3.Dock = DockStyle.Top
			Dim arg_1515_0 As Control = Me.Panel3
			location = New System.Drawing.Point(0, 0)
			arg_1515_0.Location = location
			Me.Panel3.Name = "Panel3"
			Dim arg_1545_0 As Control = Me.Panel3
			size = New Size(175, 168)
			arg_1545_0.Size = size
			Me.Panel3.TabIndex = 0
			Me.lvPages.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lvPages.CheckBoxes = True
			Me.lvPages.ContextMenuStrip = Me.lstPagesContextMenuStrip
			Me.lvPages.FullRowSelect = True
			Me.lvPages.HideSelection = False
			Me.lvPages.LabelEdit = True
			Dim arg_15BD_0 As Control = Me.lvPages
			location = New System.Drawing.Point(3, 3)
			arg_15BD_0.Location = location
			Me.lvPages.Name = "lvPages"
			Dim arg_15ED_0 As Control = Me.lvPages
			size = New Size(164, 157)
			arg_15ED_0.Size = size
			Me.lvPages.TabIndex = 1
			Me.lvPages.UseCompatibleStateImageBehavior = False
			Me.lvPages.View = View.List
			Me.lstPagesContextMenuStrip.Items.AddRange(New ToolStripItem() { Me.PageReNameToolStripMenuItem, Me.ToolStripSeparator5, Me.PageDeleteToolStripMenuItem })
			Me.lstPagesContextMenuStrip.Name = "LstKHContextMenuStrip"
			Dim arg_1675_0 As Control = Me.lstPagesContextMenuStrip
			size = New Size(113, 54)
			arg_1675_0.Size = size
			Me.PageReNameToolStripMenuItem.Name = "PageReNameToolStripMenuItem"
			Dim arg_169F_0 As ToolStripItem = Me.PageReNameToolStripMenuItem
			size = New Size(112, 22)
			arg_169F_0.Size = size
			Me.PageReNameToolStripMenuItem.Text = ChrW(272) & ChrW(7893) & "i tên"
			Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
			Dim arg_16D9_0 As ToolStripItem = Me.ToolStripSeparator5
			size = New Size(109, 6)
			arg_16D9_0.Size = size
			Me.PageDeleteToolStripMenuItem.Name = "PageDeleteToolStripMenuItem"
			Dim arg_1703_0 As ToolStripItem = Me.PageDeleteToolStripMenuItem
			size = New Size(112, 22)
			arg_1703_0.Size = size
			Me.PageDeleteToolStripMenuItem.Text = "Xóa"
			Dim arg_1730_0 As Control = Me.Splitter1
			location = New System.Drawing.Point(175, 24)
			arg_1730_0.Location = location
			Me.Splitter1.Name = "Splitter1"
			Dim arg_175C_0 As Control = Me.Splitter1
			size = New Size(3, 618)
			arg_175C_0.Size = size
			Me.Splitter1.TabIndex = 2
			Me.Splitter1.TabStop = False
			Me.Panel2.Controls.Add(Me.Panel2DMap)
			Me.Panel2.Controls.Add(Me.Splitter3D)
			Me.Panel2.Controls.Add(Me.Panel3D)
			Me.Panel2.Dock = DockStyle.Fill
			Dim arg_17E4_0 As Control = Me.Panel2
			location = New System.Drawing.Point(178, 24)
			arg_17E4_0.Location = location
			Me.Panel2.Name = "Panel2"
			Dim arg_1814_0 As Control = Me.Panel2
			size = New Size(719, 618)
			arg_1814_0.Size = size
			Me.Panel2.TabIndex = 3
			Me.Panel2DMap.BorderStyle = BorderStyle.Fixed3D
			Me.Panel2DMap.Controls.Add(Me.AxMap1)
			Me.Panel2DMap.Controls.Add(Me.StatusStrip1)
			Me.Panel2DMap.Controls.Add(Me.ToolStrip1)
			Me.Panel2DMap.Dock = DockStyle.Fill
			Dim arg_1897_0 As Control = Me.Panel2DMap
			location = New System.Drawing.Point(0, 0)
			arg_1897_0.Location = location
			Me.Panel2DMap.Name = "Panel2DMap"
			Dim arg_18C7_0 As Control = Me.Panel2DMap
			size = New Size(719, 274)
			arg_18C7_0.Size = size
			Me.Panel2DMap.TabIndex = 7
			Me.AxMap1.Dock = DockStyle.Fill
			Me.AxMap1.Enabled = True
			Dim arg_1906_0 As Control = Me.AxMap1
			location = New System.Drawing.Point(0, 25)
			arg_1906_0.Location = location
			Me.AxMap1.Name = "AxMap1"
			Me.AxMap1.OcxState = CType(resources.GetObject("AxMap1.OcxState"), AxHost.State)
			Dim arg_1952_0 As Control = Me.AxMap1
			size = New Size(715, 223)
			arg_1952_0.Size = size
			Me.AxMap1.TabIndex = 1
			Me.StatusStrip1.Items.AddRange(New ToolStripItem() { Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5 })
			Dim arg_19C5_0 As Control = Me.StatusStrip1
			location = New System.Drawing.Point(0, 248)
			arg_19C5_0.Location = location
			Me.StatusStrip1.Name = "StatusStrip1"
			Dim arg_19F2_0 As Control = Me.StatusStrip1
			size = New Size(715, 22)
			arg_19F2_0.Size = size
			Me.StatusStrip1.TabIndex = 0
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.ToolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Right
			Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
			Dim arg_1A46_0 As ToolStripItem = Me.ToolStripStatusLabel1
			size = New Size(4, 17)
			arg_1A46_0.Size = size
			Me.ToolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right
			Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
			Dim arg_1A7C_0 As ToolStripItem = Me.ToolStripStatusLabel2
			size = New Size(4, 17)
			arg_1A7C_0.Size = size
			Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
			Dim arg_1AA5_0 As ToolStripItem = Me.ToolStripStatusLabel3
			size = New Size(0, 17)
			arg_1AA5_0.Size = size
			Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
			Dim arg_1ACE_0 As ToolStripItem = Me.ToolStripStatusLabel4
			size = New Size(0, 17)
			arg_1ACE_0.Size = size
			Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
			Dim arg_1AF7_0 As ToolStripItem = Me.ToolStripStatusLabel5
			size = New Size(0, 17)
			arg_1AF7_0.Size = size
			Me.ToolStrip1.Items.AddRange(New ToolStripItem() { Me.SelectorToolStripButton, Me.PanToolStripButton, Me.ZoomInToolStripButton, Me.ZoomOutToolStripButton, Me.Zoom1XToolStripButton, Me.RullerToolStripButton, Me.ToolStripSeparator1, Me.CNToolStripButton, Me.SymbolToolStripButton, Me.UndoToolStripButton, Me.RedoToolStripButton, Me.MuiTenDonToolStripButton, Me.MuiTenDacToolStripButton, Me.ClosedCurveToolStripButton, Me.CurveToolStripSplitButton, Me.SongSongKinToolStripButton, Me.LineToolStripButton, Me.PolygonToolStripButton, Me.RectangleToolStripButton, Me.ArcToolStripButton, Me.EllipseToolStripButton, Me.TextToolStripButton, Me.TableToolStripButton, Me.OptionsToolStripButton })
			Dim arg_1C27_0 As Control = Me.ToolStrip1
			location = New System.Drawing.Point(0, 0)
			arg_1C27_0.Location = location
			Me.ToolStrip1.Name = "ToolStrip1"
			Dim arg_1C54_0 As Control = Me.ToolStrip1
			size = New Size(715, 25)
			arg_1C54_0.Size = size
			Me.ToolStrip1.TabIndex = 0
			Me.ToolStrip1.Text = "ToolStrip1"
			Me.SelectorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.SelectorToolStripButton.Image = Resources.arrow
			Me.SelectorToolStripButton.ImageTransparentColor = Color.Magenta
			Me.SelectorToolStripButton.Name = "SelectorToolStripButton"
			Dim arg_1CCB_0 As ToolStripItem = Me.SelectorToolStripButton
			size = New Size(23, 22)
			arg_1CCB_0.Size = size
			Me.SelectorToolStripButton.Text = "ToolStripButton5"
			Me.SelectorToolStripButton.ToolTipText = "Select"
			Me.PanToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.PanToolStripButton.Image = Resources.hand
			Me.PanToolStripButton.ImageTransparentColor = Color.Magenta
			Me.PanToolStripButton.Name = "PanToolStripButton"
			Dim arg_1D46_0 As ToolStripItem = Me.PanToolStripButton
			size = New Size(23, 22)
			arg_1D46_0.Size = size
			Me.PanToolStripButton.Text = "ToolStripButton6"
			Me.PanToolStripButton.ToolTipText = "Grabber"
			Me.ZoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ZoomInToolStripButton.Image = Resources.zoomin
			Me.ZoomInToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ZoomInToolStripButton.Name = "ZoomInToolStripButton"
			Dim arg_1DC1_0 As ToolStripItem = Me.ZoomInToolStripButton
			size = New Size(23, 22)
			arg_1DC1_0.Size = size
			Me.ZoomInToolStripButton.Text = "ToolStripButton7"
			Me.ZoomInToolStripButton.ToolTipText = "ZoomIn"
			Me.ZoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ZoomOutToolStripButton.Image = Resources.zoomout
			Me.ZoomOutToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ZoomOutToolStripButton.Name = "ZoomOutToolStripButton"
			Dim arg_1E3C_0 As ToolStripItem = Me.ZoomOutToolStripButton
			size = New Size(23, 22)
			arg_1E3C_0.Size = size
			Me.ZoomOutToolStripButton.Text = "ToolStripButton8"
			Me.ZoomOutToolStripButton.ToolTipText = "ZoomOut"
			Me.Zoom1XToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.Zoom1XToolStripButton.Image = Resources.zoom1x
			Me.Zoom1XToolStripButton.ImageTransparentColor = Color.Magenta
			Me.Zoom1XToolStripButton.Name = "Zoom1XToolStripButton"
			Dim arg_1EB7_0 As ToolStripItem = Me.Zoom1XToolStripButton
			size = New Size(23, 22)
			arg_1EB7_0.Size = size
			Me.Zoom1XToolStripButton.Text = "ToolStripButton1"
			Me.Zoom1XToolStripButton.ToolTipText = "V" & ChrW(7883) & " trí, kích th" & ChrW(432) & ChrW(7899) & "c ban " & ChrW(273) & ChrW(7847) & "u"
			Me.RullerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.RullerToolStripButton.Image = Resources.ruler
			Me.RullerToolStripButton.ImageTransparentColor = Color.Magenta
			Me.RullerToolStripButton.Name = "RullerToolStripButton"
			Dim arg_1F32_0 As ToolStripItem = Me.RullerToolStripButton
			size = New Size(23, 22)
			arg_1F32_0.Size = size
			Me.RullerToolStripButton.Text = ChrW(272) & "o kho" & ChrW(7843) & "ng cách"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim arg_1F6C_0 As ToolStripItem = Me.ToolStripSeparator1
			size = New Size(6, 25)
			arg_1F6C_0.Size = size
			Me.CNToolStripButton.CheckOnClick = True
			Me.CNToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.CNToolStripButton.Image = Resources.CN
			Me.CNToolStripButton.ImageTransparentColor = Color.Magenta
			Me.CNToolStripButton.Name = "CNToolStripButton"
			Dim arg_1FD2_0 As ToolStripItem = Me.CNToolStripButton
			size = New Size(23, 22)
			arg_1FD2_0.Size = size
			Me.CNToolStripButton.Text = "ToolStripButton9"
			Me.CNToolStripButton.ToolTipText = "C" & ChrW(7853) & "p nh" & ChrW(7853) & "t các ký hi" & ChrW(7879) & "u"
			Me.SymbolToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.SymbolToolStripButton.Image = Resources.NewDT
			Me.SymbolToolStripButton.ImageTransparentColor = Color.Magenta
			Me.SymbolToolStripButton.Name = "SymbolToolStripButton"
			Dim arg_204D_0 As ToolStripItem = Me.SymbolToolStripButton
			size = New Size(23, 22)
			arg_204D_0.Size = size
			Me.SymbolToolStripButton.Text = "ToolStripButton1"
			Me.SymbolToolStripButton.ToolTipText = "Các ký hi" & ChrW(7879) & "u QS"
			Me.UndoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.UndoToolStripButton.Image = Resources.UNDO
			Me.UndoToolStripButton.ImageTransparentColor = Color.Magenta
			Me.UndoToolStripButton.Name = "UndoToolStripButton"
			Dim arg_20C8_0 As ToolStripItem = Me.UndoToolStripButton
			size = New Size(23, 22)
			arg_20C8_0.Size = size
			Me.UndoToolStripButton.Text = "Undo"
			Me.RedoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.RedoToolStripButton.Image = Resources.REDO
			Me.RedoToolStripButton.ImageTransparentColor = Color.Magenta
			Me.RedoToolStripButton.Name = "RedoToolStripButton"
			Dim arg_2132_0 As ToolStripItem = Me.RedoToolStripButton
			size = New Size(23, 22)
			arg_2132_0.Size = size
			Me.RedoToolStripButton.Text = "Redo"
			Me.MuiTenDonToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.MuiTenDonToolStripButton.Image = Resources.MuiTenDon
			Me.MuiTenDonToolStripButton.ImageTransparentColor = Color.Magenta
			Me.MuiTenDonToolStripButton.Name = "MuiTenDonToolStripButton"
			Dim arg_219C_0 As ToolStripItem = Me.MuiTenDonToolStripButton
			size = New Size(23, 22)
			arg_219C_0.Size = size
			Me.MuiTenDonToolStripButton.Text = "ToolStripButton1"
			Me.MuiTenDonToolStripButton.ToolTipText = "M" & ChrW(361) & "i tên " & ChrW(273) & ChrW(417) & "n"
			Me.MuiTenDacToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.MuiTenDacToolStripButton.Image = Resources.MuiTenNho
			Me.MuiTenDacToolStripButton.ImageTransparentColor = Color.Magenta
			Me.MuiTenDacToolStripButton.Name = "MuiTenDacToolStripButton"
			Dim arg_2217_0 As ToolStripItem = Me.MuiTenDacToolStripButton
			size = New Size(23, 22)
			arg_2217_0.Size = size
			Me.MuiTenDacToolStripButton.Text = "M" & ChrW(361) & "i tên t" & ChrW(7927) & " l" & ChrW(7879)
			Me.ClosedCurveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ClosedCurveToolStripButton.Image = Resources.closedcurve
			Me.ClosedCurveToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ClosedCurveToolStripButton.Name = "ClosedCurveToolStripButton"
			Dim arg_2281_0 As ToolStripItem = Me.ClosedCurveToolStripButton
			size = New Size(23, 22)
			arg_2281_0.Size = size
			Me.ClosedCurveToolStripButton.Text = "ToolStripButton3"
			Me.ClosedCurveToolStripButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng cong kín"
			Me.CurveToolStripSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.CurveToolStripSplitButton.Image = Resources.curve
			Me.CurveToolStripSplitButton.ImageTransparentColor = Color.Magenta
			Me.CurveToolStripSplitButton.Name = "CurveToolStripSplitButton"
			Dim arg_22FC_0 As ToolStripItem = Me.CurveToolStripSplitButton
			size = New Size(32, 22)
			arg_22FC_0.Size = size
			Me.CurveToolStripSplitButton.Text = "ToolStripSplitButton1"
			Me.CurveToolStripSplitButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng cong"
			Me.SongSongKinToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.SongSongKinToolStripButton.Image = Resources.SongSongKin
			Me.SongSongKinToolStripButton.ImageTransparentColor = Color.Magenta
			Me.SongSongKinToolStripButton.Name = "SongSongKinToolStripButton"
			Dim arg_2377_0 As ToolStripItem = Me.SongSongKinToolStripButton
			size = New Size(23, 22)
			arg_2377_0.Size = size
			Me.SongSongKinToolStripButton.Text = "ToolStripButton1"
			Me.SongSongKinToolStripButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng song song"
			Me.LineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.LineToolStripButton.Image = Resources.AddPolyLine
			Me.LineToolStripButton.ImageTransparentColor = Color.Magenta
			Me.LineToolStripButton.Name = "LineToolStripButton"
			Dim arg_23F2_0 As ToolStripItem = Me.LineToolStripButton
			size = New Size(23, 22)
			arg_23F2_0.Size = size
			Me.LineToolStripButton.Text = "LineToolStripButton"
			Me.LineToolStripButton.ToolTipText = ChrW(272) & ChrW(432) & ChrW(7901) & "ng g" & ChrW(7845) & "p khúc"
			Me.PolygonToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.PolygonToolStripButton.Image = Resources.polygon1
			Me.PolygonToolStripButton.ImageTransparentColor = Color.Magenta
			Me.PolygonToolStripButton.Name = "PolygonToolStripButton"
			Dim arg_246D_0 As ToolStripItem = Me.PolygonToolStripButton
			size = New Size(23, 22)
			arg_246D_0.Size = size
			Me.PolygonToolStripButton.Text = ChrW(272) & "a giác"
			Me.RectangleToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.RectangleToolStripButton.Image = Resources.Rectangle
			Me.RectangleToolStripButton.ImageTransparentColor = Color.Magenta
			Me.RectangleToolStripButton.Name = "RectangleToolStripButton"
			Dim arg_24D7_0 As ToolStripItem = Me.RectangleToolStripButton
			size = New Size(23, 22)
			arg_24D7_0.Size = size
			Me.RectangleToolStripButton.Text = "ToolStripButton1"
			Me.RectangleToolStripButton.ToolTipText = "Hình ch" & ChrW(7919) & " nh" & ChrW(7853) & "t"
			Me.ArcToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ArcToolStripButton.Image = Resources.Arc
			Me.ArcToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ArcToolStripButton.Name = "ArcToolStripButton"
			Dim arg_2552_0 As ToolStripItem = Me.ArcToolStripButton
			size = New Size(23, 22)
			arg_2552_0.Size = size
			Me.ArcToolStripButton.Text = "Cung"
			Me.EllipseToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.EllipseToolStripButton.Image = Resources.cycle
			Me.EllipseToolStripButton.ImageTransparentColor = Color.Magenta
			Me.EllipseToolStripButton.Name = "EllipseToolStripButton"
			Dim arg_25BC_0 As ToolStripItem = Me.EllipseToolStripButton
			size = New Size(23, 22)
			arg_25BC_0.Size = size
			Me.EllipseToolStripButton.Text = "ToolStripButton1"
			Me.EllipseToolStripButton.ToolTipText = "Hình ê líp"
			Me.TextToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.TextToolStripButton.Image = Resources.Text
			Me.TextToolStripButton.ImageTransparentColor = Color.Magenta
			Me.TextToolStripButton.Name = "TextToolStripButton"
			Dim arg_2637_0 As ToolStripItem = Me.TextToolStripButton
			size = New Size(23, 22)
			arg_2637_0.Size = size
			Me.TextToolStripButton.Text = "ToolStripButton1"
			Me.TextToolStripButton.ToolTipText = "Ch" & ChrW(7919)
			Me.TableToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.TableToolStripButton.Image = Resources.Table
			Me.TableToolStripButton.ImageTransparentColor = Color.Magenta
			Me.TableToolStripButton.Name = "TableToolStripButton"
			Dim arg_26B2_0 As ToolStripItem = Me.TableToolStripButton
			size = New Size(23, 22)
			arg_26B2_0.Size = size
			Me.TableToolStripButton.Text = "ToolStripButton1"
			Me.TableToolStripButton.ToolTipText = "B" & ChrW(7843) & "ng"
			Me.OptionsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.OptionsToolStripButton.Image = Resources.Options
			Me.OptionsToolStripButton.ImageTransparentColor = Color.Magenta
			Me.OptionsToolStripButton.Name = "OptionsToolStripButton"
			Dim arg_272D_0 As ToolStripItem = Me.OptionsToolStripButton
			size = New Size(23, 22)
			arg_272D_0.Size = size
			Me.OptionsToolStripButton.Text = "ToolStripButton1"
			Me.OptionsToolStripButton.ToolTipText = "Các m" & ChrW(7863) & "c " & ChrW(273) & ChrW(7883) & "nh"
			Me.Splitter3D.Dock = DockStyle.Bottom
			Dim arg_2777_0 As Control = Me.Splitter3D
			location = New System.Drawing.Point(0, 274)
			arg_2777_0.Location = location
			Me.Splitter3D.Name = "Splitter3D"
			Dim arg_27A3_0 As Control = Me.Splitter3D
			size = New Size(719, 3)
			arg_27A3_0.Size = size
			Me.Splitter3D.TabIndex = 6
			Me.Splitter3D.TabStop = False
			Me.Panel3D.BorderStyle = BorderStyle.Fixed3D
			Me.Panel3D.Controls.Add(Me.ToolStrip2)
			Me.Panel3D.Dock = DockStyle.Bottom
			Dim arg_2809_0 As Control = Me.Panel3D
			location = New System.Drawing.Point(0, 277)
			arg_2809_0.Location = location
			Me.Panel3D.Name = "Panel3D"
			Dim arg_2839_0 As Control = Me.Panel3D
			size = New Size(719, 341)
			arg_2839_0.Size = size
			Me.Panel3D.TabIndex = 5
			Me.ToolStrip2.Dock = DockStyle.None
			Me.ToolStrip2.Items.AddRange(New ToolStripItem() { Me.HideSymbolToolStripButton, Me.DrawSymbolToolStripButton })
			Dim arg_2897_0 As Control = Me.ToolStrip2
			location = New System.Drawing.Point(0, 0)
			arg_2897_0.Location = location
			Me.ToolStrip2.Name = "ToolStrip2"
			Dim arg_28C1_0 As Control = Me.ToolStrip2
			size = New Size(58, 25)
			arg_28C1_0.Size = size
			Me.ToolStrip2.TabIndex = 2
			Me.ToolStrip2.Text = "ToolStrip2"
			Me.HideSymbolToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.HideSymbolToolStripButton.Image = Resources.DauKyHieu
			Me.HideSymbolToolStripButton.ImageTransparentColor = Color.Magenta
			Me.HideSymbolToolStripButton.Name = "HideSymbolToolStripButton"
			Dim arg_2938_0 As ToolStripItem = Me.HideSymbolToolStripButton
			size = New Size(23, 22)
			arg_2938_0.Size = size
			Me.HideSymbolToolStripButton.Text = "D" & ChrW(7845) & "u ký hi" & ChrW(7879) & "u"
			Me.DrawSymbolToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.DrawSymbolToolStripButton.Image = Resources.NewDT
			Me.DrawSymbolToolStripButton.ImageTransparentColor = Color.Magenta
			Me.DrawSymbolToolStripButton.Name = "DrawSymbolToolStripButton"
			Dim arg_29A2_0 As ToolStripItem = Me.DrawSymbolToolStripButton
			size = New Size(23, 22)
			arg_29A2_0.Size = size
			Me.DrawSymbolToolStripButton.Text = "Hi" & ChrW(7879) & "n ký hi" & ChrW(7879) & "u"
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

		Private Sub LoadHeightData(fileName As String)
			' The following expression was wrapped in a checked-statement
			Me.heightData = New Single(modBanDo.myGRID_WIDTH - 1 + 1 - 1, modBanDo.myGRID_HEIGHT - 1 + 1 - 1) {}
			Dim file As StreamReader = New StreamReader(fileName)
			Dim y As Integer = modBanDo.myGRID_HEIGHT - 1
			While True
				Dim arg_94_0 As Integer = y
				Dim num As Integer = 0
				If arg_94_0 < num Then
					Exit While
				End If
				Dim arg_3A_0 As Integer = 0
				Dim num2 As Integer = modBanDo.myGRID_WIDTH - 1
				Dim x As Integer = arg_3A_0
				While True
					Dim arg_84_0 As Integer = x
					num = num2
					If arg_84_0 > num Then
						Exit While
					End If
					Dim line As String = file.ReadLine()
					Dim point As String() = line.Split(New Char() { " "c })
					Dim z As Single = Convert.ToSingle(point(2))
					Me.heightData(x, y) = z
					x += 1
				End While
				y += -1
			End While
			file.Close()
		End Sub

		Private Sub PopulateList()
			Me.lvPages.Clear()
			Try
				Dim enumerator As IEnumerator = Me.mySlides.GetEnumerator()
				While enumerator.MoveNext()
					Dim mSlide As CSlide = CType(enumerator.Current, CSlide)
					Dim mLabel As String = mSlide.Value
					Dim mTag As String = mSlide.ID.ToString()
					Dim mItem As ListViewItem = New ListViewItem(mLabel)
					mItem.Tag = mTag
					mItem.ImageIndex = 0
					mItem.StateImageIndex = 0
					mItem.Checked = mSlide.Checked
					Me.lvPages.Items.Add(mItem)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub PopulateForm()
			Me.Cursor = Cursors.WaitCursor
			Try
				Dim flag As Boolean = Me.lvPages.SelectedItems.Count > 0
				If flag Then
					Dim itmY As ListViewItem = Me.lvPages.SelectedItems(0)
					flag = (itmY IsNot Nothing)
					If flag Then
						Dim iTag As Integer = Conversions.ToInteger(itmY.Tag)
						Me.CurrSlide = Me.mySlides.GetItemByID(iTag)
						flag = Not Information.IsNothing(Me.CurrSlide)
						If flag Then
							Try
								Me.myBando.KHsFromString(Me.CurrSlide.Symbols)
								modBanDo.myTyLeLayKH = Me.CurrSlide.TyLeLayKH
								modBanDo.myDaLayKH = Me.CurrSlide.DaLayKH
							Catch arg_AF_0 As Exception
								ProjectData.SetProjectError(arg_AF_0)
								ProjectData.ClearProjectError()
							End Try
						End If
					End If
				Else
					Me.AxMap1.CenterX = Me.AxMap1.CenterX
				End If
				Me.AxMap1.Refresh()
			Catch expr_EA As Exception
				ProjectData.SetProjectError(expr_EA)
				Dim e As Exception = expr_EA
				Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "Pop General Error")
				ProjectData.ClearProjectError()
			End Try
			Me.PopulateListKH(Nothing)
			Me.Cursor = Cursors.[Default]
		End Sub

		Private Sub PopulateForm(i As Integer)
			Try
				' The following expression was wrapped in a checked-expression
				Dim itmY As ListViewItem = Me.lvPages.Items(i - 1)
				Dim flag As Boolean = itmY IsNot Nothing
				If flag Then
					Dim iTag As Integer = Conversions.ToInteger(itmY.Tag)
					Dim mSlide As CSlide = Me.mySlides.GetItemByID(iTag)
					flag = Not Information.IsNothing(mSlide)
					If flag Then
						Dim mKyHieu As String = mSlide.Symbols
						Try
							Me.myBando.KHsFromString(mKyHieu)
						Catch arg_62_0 As Exception
							ProjectData.SetProjectError(arg_62_0)
							ProjectData.ClearProjectError()
						End Try
					End If
				End If
			Catch expr_78 As Exception
				ProjectData.SetProjectError(expr_78)
				Dim e As Exception = expr_78
				Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "Pop2 General Error")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub FirstSlide()
			Me.HideDrawTools()
			Dim flag As Boolean = Information.IsNothing(Me.mySlides)
			If flag Then
				Me.mySlides = New CSlides()
			Else
				Me.mySlides.Clear()
			End If
			Me.CurrSlide = New CSlide("Trang 1", 1, "", True)
			Me.mySlides.Add(Me.CurrSlide)
			Me.GetTyleLayKH()
			Me.CurrSlide.TyLeLayKH = modBanDo.myTyLeLayKH
			Me.CurrSlide.DaLayKH = True
			Me.PopulateList()
			Me.lvPages.Items(0).Selected = True
			Me.PopulateForm()
		End Sub

		Private Sub HideDrawTools()
			Dim flag As Boolean = Not Information.IsNothing(modBanDo.fCacKyHieu)
			If flag Then
				Try
					modBanDo.fCacKyHieu.Close()
				Catch expr_20 As Exception
					ProjectData.SetProjectError(expr_20)
					ProjectData.ClearProjectError()
				End Try
			End If
			Me.myBando.SelectedSymbol = Nothing
			Me.TableToolStripButton.Visible = False
			Me.OptionsToolStripButton.Visible = False
			Me.UndoToolStripButton.Visible = False
			Me.RedoToolStripButton.Visible = False
			Me.LineToolStripButton.Visible = False
			Me.PolygonToolStripButton.Visible = False
			Me.ArcToolStripButton.Visible = False
			Me.EllipseToolStripButton.Visible = False
			Me.RectangleToolStripButton.Visible = False
			Me.MuiTenDonToolStripButton.Visible = False
			Me.MuiTenDacToolStripButton.Visible = False
			Me.CurveToolStripSplitButton.Visible = False
			Me.ClosedCurveToolStripButton.Visible = False
			Me.SongSongKinToolStripButton.Visible = False
			Me.TextToolStripButton.Visible = False
			Me.SymbolToolStripButton.Visible = False
			Me.CNToolStripButton.Checked = False
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.myMapTool = CBanDo.MapTools.None
			Me.ToolStripStatusLabel3.Text = ""
		End Sub

		Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.myBando.Dispose()
			myModule.fMain = Nothing
		End Sub

		Private Sub frmMain_Load(sender As Object, e As EventArgs)
			myModule.RegisterOK = True
			Dim flag As Boolean = Not myModule.RegisterOK
			If flag Then
				MessageBox.Show("Chua Dang ky. Stop.")
				ProjectData.EndApp()
			End If
			myModule.fMain = Me
			modBanDo.myCacKyHieuUDL = MySettingsProperty.Settings.myCacKyHieuUDL
			modBanDo.myDefaFileName = MySettingsProperty.Settings.myDefaFileName
			modBanDo.LoadDefa(modBanDo.myDefaFileName)
			myModule.myHienDanhSach = MySettingsProperty.Settings.myHienDanhSach
			' The following expression was wrapped in a checked-statement
			modBanDo.mySoPixelsPer1000m = CInt(MySettingsProperty.Settings.mySoPixelsPer1000m)
			modBanDo.myKHQSZoom = CInt(MySettingsProperty.Settings.myKHQSZoom)
			modBanDo.myKHQSMWidth = CInt(MySettingsProperty.Settings.myKHQSMWidth)
			modBanDo.myTinhChinhGocQuay = MySettingsProperty.Settings.myTinhChinhGocQuay
			modBanDo.myTextureFile = MySettingsProperty.Settings.myTextureFile
			modBanDo.myGridDataFile = MySettingsProperty.Settings.myGridDataFile
			modBanDo.myGRID_WIDTH = CInt(MySettingsProperty.Settings.myGRID_WIDTH)
			modBanDo.myGRID_HEIGHT = CInt(MySettingsProperty.Settings.myGRID_HEIGHT)
			modBanDo.mySCALE_FACTOR = MySettingsProperty.Settings.mySCALE_FACTOR
			modBanDo.myMap1X = MySettingsProperty.Settings.myMap1X
			modBanDo.myMap1Y = MySettingsProperty.Settings.myMap1Y
			modBanDo.myMap2X = MySettingsProperty.Settings.myMap2X
			modBanDo.myMap2Y = MySettingsProperty.Settings.myMap2Y
			modBanDo.myFlag3DsFile = MySettingsProperty.Settings.myFlag3DsFile
			Dim mIndex As Integer = modBanDo.myFlag3DsFile.LastIndexOf("\"c)
			Dim mPath As String = modBanDo.myFlag3DsFile.Substring(0, mIndex + 1)
			modBanDo.myResourcePath = mPath
			Directory.SetCurrentDirectory(mPath)
			modBanDo.my3DSoPixelsPer1000m = CInt(MySettingsProperty.Settings.my3DSoPixelsPer1000m)
			Try
				myModule.myMapNhoGst = MySettingsProperty.Settings.myMapNhoGst
			Catch expr_187 As Exception
				ProjectData.SetProjectError(expr_187)
				ProjectData.ClearProjectError()
			End Try
			Try
				myModule.myMapGst = MySettingsProperty.Settings.myMapGst
			Catch expr_1A9 As Exception
				ProjectData.SetProjectError(expr_1A9)
				ProjectData.ClearProjectError()
			End Try
			Me.myBando = New CBanDo(Me.AxMap1, Me, Me.Panel2DMap)
			modBanDo.MyOtherLineStyle = New COtherLineStyle()
			Me.CreateMyMenu()
			Me.DanhSachToolStripMenuItem.Checked = myModule.myHienDanhSach
			Me.DanhSachToolStripMenuItem_CheckStateChanged(Nothing, Nothing)
			Me.WindowState = FormWindowState.Maximized
			Me.FirstSlide()
			modBanDo.LastBdTC = modBanDo.myNewBdTC
			Me.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n (" + modBanDo.LastBdTC + ")"
			Me.InitTerrain()
			Me.bLoaded = True
		End Sub

		Private Function GetReg() As Boolean
			Dim f As frmRegister = New frmRegister()
			Dim mRegisterOK As Boolean = f.IsRegOK()
			Dim flag As Boolean = Not mRegisterOK
			If flag Then
				Dim flag2 As Boolean = f.ShowDialog() = DialogResult.OK
				If flag2 Then
					mRegisterOK = f.RegKQ
				End If
			End If
			Return mRegisterOK
		End Function

		Private Sub SaBanToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.SaBanToolStripMenuItem.Checked
			If checked Then
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
			Dim checked As Boolean = Me.DanhSachToolStripMenuItem.Checked
			If checked Then
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

		Private Sub SelectorToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Dim checked As Boolean = Me.CNToolStripButton.Checked
			If checked Then
				Me.myBando.OnCapNhatKH()
			Else
				Me.HideDrawTools()
			End If
		End Sub

		Private Sub PanToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miPanTool
			Me.myBando.myMapTool = CBanDo.MapTools.None
			Me.ToolStripStatusLabel3.Text = ""
		End Sub

		Private Sub ZoomInToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miZoomInTool
			Me.myBando.myMapTool = CBanDo.MapTools.None
			Me.ToolStripStatusLabel3.Text = ""
		End Sub

		Private Sub ZoomOutToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miZoomOutTool
			Me.myBando.myMapTool = CBanDo.MapTools.None
			Me.ToolStripStatusLabel3.Text = ""
		End Sub

		Public Sub ChangeDesc(pSymbol As CSymbol, pParent As Form)
			Dim f As dlgInputBox = New dlgInputBox()
			f.Label1.Text = "Ghi chú:"
			f.TextBox1.Text = pSymbol.Description
			Dim flag As Boolean = f.ShowDialog(pParent) = DialogResult.OK
			If flag Then
				pSymbol.Description = f.TextBox1.Text
			End If
			Me.PopulateListKH(pSymbol)
		End Sub

		Private Sub MenuItemFileClick(sender As Object, e As EventArgs)
			Dim mSeleItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
			Dim mTag As String = Conversions.ToString(mSeleItem.Tag)
			Dim data As String() = mTag.Split(New Char() { "|"c })
			Dim flag As Boolean = data.GetUpperBound(0) > 0
			If flag Then
				Dim iNhom As Integer = Conversions.ToInteger(data(0))
				Dim iMuc As Integer = Conversions.ToInteger(data(1))
				Dim iStyle As Integer = modBanDo.MyOtherLineStyle.GetStyleIndex(iNhom, iMuc)
				' The following expression was wrapped in a checked-expression
				modBanDo.defaMyLineStyle = iStyle + 1
				Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
				Me.myBando.OnDrawObj("Curve")
				Me.ToolStripStatusLabel3.Text = "v" & ChrW(7869) & " " + modBanDo.MyOtherLineStyle.StyleName(iStyle) + ": Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n các " & ChrW(273) & "i" & ChrW(7875) & "m, RightClick " & ChrW(273) & ChrW(7875) & " k" & ChrW(7871) & "t thúc."
			End If
		End Sub

		Private Sub CreateMyMenu()
			Dim handlerFile As EventHandler = AddressOf Me.MenuItemFileClick
			Dim mNhomCount As Object = modBanDo.MyOtherLineStyle.NhomCount
			' The following expression was wrapped in a checked-statement
			Dim pMenuItems As ToolStripMenuItem() = New ToolStripMenuItem(Conversions.ToInteger(Operators.SubtractObject(mNhomCount, 1)) + 1 - 1) {}
			Dim arg_4C_0 As Integer = 0
			Dim num As Integer = Conversions.ToInteger(Operators.SubtractObject(mNhomCount, 1))
			Dim i As Integer = arg_4C_0
			While True
				Dim arg_147_0 As Integer = i
				Dim num2 As Integer = num
				If arg_147_0 > num2 Then
					Exit While
				End If
				pMenuItems(i) = New ToolStripMenuItem(modBanDo.MyOtherLineStyle.NhomName(i))
				Me.CurveToolStripSplitButton.DropDownItems.Add(pMenuItems(i))
				Dim flag As Boolean = modBanDo.MyOtherLineStyle.StyleCount(i) > 0
				If flag Then
					Dim arg_A1_0 As Integer = 0
					Dim num3 As Integer = modBanDo.MyOtherLineStyle.StyleCount(i) - 1
					Dim j As Integer = arg_A1_0
					While True
						Dim arg_135_0 As Integer = j
						num2 = num3
						If arg_135_0 > num2 Then
							Exit While
						End If
						Dim mIndex As Integer = modBanDo.MyOtherLineStyle.GetStyleIndex(i, j)
						Dim mBitmap As Bitmap = Me.getImage(mIndex + 1)
						Dim mToolStripMenuItem As ToolStripMenuItem = New ToolStripMenuItem(modBanDo.MyOtherLineStyle.StyleName(mIndex) + " ", mBitmap, handlerFile)
						mToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
						mToolStripMenuItem.Tag = i.ToString("00") + "|" + j.ToString("00")
						pMenuItems(i).DropDownItems.Add(mToolStripMenuItem)
						j += 1
					End While
				End If
				i += 1
			End While
		End Sub

		Private Function getImage(StyleIndex As Integer) As Bitmap
			Dim mNewBmp As Bitmap = New Bitmap(64, 24)
			Dim g As Graphics = Graphics.FromImage(mNewBmp)
			Me.VeLineStyle(g, StyleIndex, 0F, 0F)
			Return mNewBmp
		End Function

		Private Sub VeLineStyle(g As Graphics, StyleIndex As Integer, pLeft As Single, pTop As Single)
			Dim mPts As PointF() = New PointF(1) {}
			mPts(0).X = 8F
			mPts(0).Y = 12F
			mPts(1).X = 64F
			mPts(1).Y = 12F
			Dim mObjs As GraphicObject() = modBanDo.MyOtherLineStyle.GetGraphicObjs(StyleIndex, mPts)
			Dim mySymbol As CGraphicObjs = New CGraphicObjs()
			Dim array As GraphicObject() = mObjs
			' The following expression was wrapped in a checked-statement
			For i As Integer = 0 To array.Length - 1
				Dim mObj As GraphicObject = array(i)
				mySymbol.Add(mObj)
			Next
			Dim gCon As GraphicsContainer = g.BeginContainer()
			g.TranslateTransform(pLeft, pTop)
			mySymbol.DrawObjects(g, 0.8F)
			g.EndContainer(gCon)
		End Sub

		Public Sub PopulateListKH(pSymbol As CSymbol)
			Cursor.Current = Cursors.WaitCursor
			Me.lstCacKyHieu.DataSource = Nothing
			Me.lstCacKyHieu.DataSource = Me.myBando.drawingSymbols
			Dim i As Integer = -1
			Dim index As Integer = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				Try
					Dim enumerator As IEnumerator = Me.myBando.drawingSymbols.GetEnumerator()
					While enumerator.MoveNext()
						Dim aSymbol As CSymbol = CType(enumerator.Current, CSymbol)
						i += 1
						flag = aSymbol.Equals(pSymbol)
						If flag Then
							index = i
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				flag = (Me.lstCacKyHieu.Items.Count > 0)
				If flag Then
					Dim flag2 As Boolean = index > -1
					If flag2 Then
						Me.lstCacKyHieu.SetSelected(index, True)
					Else
						Me.lstCacKyHieu.SetSelected(0, True)
					End If
				End If
			Catch expr_E4 As Exception
				ProjectData.SetProjectError(expr_E4)
				Dim e As Exception = expr_E4
				Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "General Error")
				ProjectData.ClearProjectError()
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		Private Sub StatusBarToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			Me.StatusStrip1.Visible = Me.StatusBarToolStripMenuItem.Checked
		End Sub

		Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.StatusBarToolStripMenuItem.Checked = Not Me.StatusBarToolStripMenuItem.Checked
		End Sub

		Private Sub BdTCToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.BdTCToolStripMenuItem.Checked
			If checked Then
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

		Private Sub MuiTenToolStripSplitButton_Click(sender As Object, e As EventArgs)
			modBanDo.myMuiTenDoRong = modBanDo.defaMuiTenDoRong
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTen")
		End Sub

		Private Sub MuiTenToToolStripMenuItem_Click(sender As Object, e As EventArgs)
			modBanDo.myMuiTenDoRong = CSng((CDec(modBanDo.defaMuiTenDoRong) * 1.5))
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTen")
		End Sub

		Private Sub MuiTenNhoToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			modBanDo.myMuiTenDoRong = CSng((CDec(modBanDo.defaMuiTenDoRong) * 0.5))
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTen")
		End Sub

		Private Sub MuiTenKhacToolStripMenuItem_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim mPhanTram As Integer = CInt(Math.Round(CDec((modBanDo.myMuiTenDoRong * 100F / modBanDo.defaMuiTenDoRong))))
			Dim f As dlgInputBox = New dlgInputBox()
			f.Label1.Text = "Bao nhiêu %:"
			f.TextBox1.Text = mPhanTram.ToString()
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				' The following expression was wrapped in a checked-expression
				mPhanTram = CInt(Math.Round(Conversion.Val(f.TextBox1.Text)))
				flag = (mPhanTram > 0)
				If flag Then
					modBanDo.myMuiTenDoRong = modBanDo.defaMuiTenDoRong * CSng(mPhanTram) / 100F
					Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
					Me.myBando.OnDrawObj("MuiTen")
				End If
			End If
		End Sub

		Private Sub MuiTenHoToolStripSplitButton_Click(sender As Object, e As EventArgs)
			modBanDo.myMuiTenDoRong = modBanDo.defaMuiTenDoRong
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTenHo")
		End Sub

		Private Sub MuiTenHoToToolStripMenuItem_Click(sender As Object, e As EventArgs)
			modBanDo.myMuiTenDoRong = CSng((CDec(modBanDo.defaMuiTenDoRong) * 1.5))
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTenHo")
		End Sub

		Private Sub MuiTenHoNhoToolStripMenuItem_CheckStateChanged(sender As Object, e As EventArgs)
			modBanDo.myMuiTenDoRong = CSng((CDec(modBanDo.defaMuiTenDoRong) * 0.5))
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTenHo")
		End Sub

		Private Sub MuiTenHoKhacToolStripMenuItem_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			' The following expression was wrapped in a unchecked-expression
			Dim mPhanTram As Integer = CInt(Math.Round(CDec((modBanDo.myMuiTenDoRong * 100F / modBanDo.defaMuiTenDoRong))))
			Dim f As dlgInputBox = New dlgInputBox()
			f.Label1.Text = "Bao nhiêu %:"
			f.TextBox1.Text = mPhanTram.ToString()
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				' The following expression was wrapped in a checked-expression
				mPhanTram = CInt(Math.Round(Conversion.Val(f.TextBox1.Text)))
				flag = (mPhanTram > 0)
				If flag Then
					modBanDo.myMuiTenDoRong = modBanDo.defaMuiTenDoRong * CSng(mPhanTram) / 100F
					Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
					Me.myBando.OnDrawObj("MuiTenHo")
				End If
			End If
		End Sub

		Private Sub MuiTenDonToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTenDon")
		End Sub

		Private Sub EllipseToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Ellipse")
		End Sub

		Private Sub RectangleToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Rectangle")
		End Sub

		Private Sub CurveToolStripSplitButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Curve")
		End Sub

		Private Sub ClosedCurveToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("ClosedCurve")
		End Sub

		Private Sub SongSongKinToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("SongSongKin")
		End Sub

		Private Sub TextToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Text")
		End Sub

		Private Sub SymbolToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Dim flag As Boolean = Information.IsNothing(modBanDo.fCacKyHieu)
			If flag Then
				Me.myBando.myMapCurrTool = Me.AxMap1.CurrentTool
				Dim f As dlgCacKyHieu = New dlgCacKyHieu()
				myModule.fCallForm = Me
				Me.ToolStripStatusLabel3.Text = "AddKH: Click " & ChrW(273) & ChrW(7875) & " ch" & ChrW(7885) & "n vi tri ky hieu."
				f.TopMost = True
				f.Show()
			End If
			Me.myBando.OnCapNhatKH()
		End Sub

		Private Sub CNToolStripButton_Click(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.CNToolStripButton.Checked
			If checked Then
				Me.TableToolStripButton.Visible = True
				Me.OptionsToolStripButton.Visible = True
				Me.UndoToolStripButton.Visible = True
				Me.RedoToolStripButton.Visible = True
				Me.LineToolStripButton.Visible = True
				Me.PolygonToolStripButton.Visible = True
				Me.ArcToolStripButton.Visible = True
				Me.EllipseToolStripButton.Visible = True
				Me.RectangleToolStripButton.Visible = True
				Me.MuiTenDonToolStripButton.Visible = True
				Me.MuiTenDacToolStripButton.Visible = True
				Me.CurveToolStripSplitButton.Visible = True
				Me.ClosedCurveToolStripButton.Visible = True
				Me.SongSongKinToolStripButton.Visible = True
				Me.TextToolStripButton.Visible = True
				Me.SymbolToolStripButton.Visible = True
				Me.myBando.OnCapNhatKH()
			Else
				Me.HideDrawTools()
			End If
			Me.ToolStripStatusLabel3.Text = ""
		End Sub

		Private Sub UpdateSlide()
			Me.HideDrawTools()
			Dim flag As Boolean = Not Information.IsNothing(Me.CurrSlide)
			If flag Then
				Dim flag2 As Boolean = Not Information.IsNothing(Me.myBando.drawingSymbols)
				If flag2 Then
					Dim mKyHieu As String = Me.myBando.drawingSymbols.KH2String(Me.AxMap1)
					Me.mySlides.Update(Me.CurrSlide, mKyHieu, modBanDo.myTyLeLayKH, modBanDo.myDaLayKH)
				End If
			End If
		End Sub

		Private Sub NewPageToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(Me.mySlides)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.UpdateSlide()
				Dim mSlideId As Integer = Me.mySlides.GetMaxID() + 1
				Dim mNewSlide As CSlide = New CSlide("Trang " + mSlideId.ToString(), mSlideId, "", True)
				Dim cSlide As CSlide = mNewSlide
				cSlide.DaLayKH = Me.CurrSlide.DaLayKH
				cSlide.TyLeLayKH = Me.CurrSlide.TyLeLayKH
				Me.mySlides.Add(mNewSlide)
				Me.PopulateList()
				Me.lvPages.Items(Me.mySlides.Count - 1).Selected = True
				Me.PopulateForm()
			End If
		End Sub

		Private Sub NhapNhayKH()
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Dim flag As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem))
			If flag Then
				Me.lstCacKyHieu.Enabled = False
				Try
					Dim oSymbol As CSymbol = CType(Me.lstCacKyHieu.SelectedItem, CSymbol)
					flag = Not Me.AxMap1.IsPointVisible(oSymbol.GocX, oSymbol.GocY)
					If flag Then
						Me.AxMap1.CenterX = oSymbol.GocX
						Me.AxMap1.CenterY = oSymbol.GocY
					End If
					Me.myBando.NhapNhaySymbol(oSymbol, 5)
				Catch arg_A3_0 As Exception
					ProjectData.SetProjectError(arg_A3_0)
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

		Public Sub XoaKH(pSymbol As CSymbol)
			Try
				Dim i As Integer = Me.lstCacKyHieu.Items.IndexOf(pSymbol)
				Me.myBando.drawingSymbols.Remove(pSymbol)
				Me.myBando.RefreshMap()
				Me.lstCacKyHieu.Items.Remove(pSymbol)
				Dim flag As Boolean = i < Me.lstCacKyHieu.Items.Count
				Dim index As Integer
				If flag Then
					index = i
				Else
					' The following expression was wrapped in a checked-expression
					index = i - 1
				End If
				flag = (index > -1)
				If flag Then
					Me.lstCacKyHieu.SelectedIndex = index
				End If
			Catch arg_7F_0 As Exception
				ProjectData.SetProjectError(arg_7F_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub XoaToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem))
			If flag Then
				Me.lstCacKyHieu.Enabled = False
				Dim mKyHieu As CSymbol = CType(Me.lstCacKyHieu.SelectedItem, CSymbol)
				flag = (MessageBox.Show(Me, "Th" & ChrW(7853) & "t s" & ChrW(7921) & " mu" & ChrW(7889) & "n xoá Ký hi" & ChrW(7879) & "u này?", "Xoá:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes)
				If flag Then
					Me.myBando.SelectedSymbol = mKyHieu
					Me.myBando.OnXoa()
				End If
				Me.lstCacKyHieu.Enabled = True
			End If
		End Sub

		Private Sub XoaTatToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.lstCacKyHieu.Enabled = False
			Dim flag As Boolean = Me.myBando.drawingSymbols.Count > 0
			If flag Then
				Try
					Dim flag2 As Boolean = MessageBox.Show(Me, "Th" & ChrW(7853) & "t s" & ChrW(7921) & " mu" & ChrW(7889) & "n xoá t" & ChrW(7845) & "t c" & ChrW(7843) & " các Ký hi" & ChrW(7879) & "u?", "Xoá:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
					If flag2 Then
						Me.myBando.drawingSymbols.Clear()
						Me.myBando.RefreshMap()
						Me.PopulateListKH(Nothing)
					End If
				Catch arg_68_0 As Exception
					ProjectData.SetProjectError(arg_68_0)
					ProjectData.ClearProjectError()
				End Try
			End If
			Me.lstCacKyHieu.Enabled = True
		End Sub

		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstCacKyHieu.SelectedItem))
			If flag Then
				Dim oSymbol As CSymbol = CType(Me.lstCacKyHieu.SelectedItem, CSymbol)
				Me.ChangeDesc(oSymbol, Me)
			End If
		End Sub

		Private Sub lvPages_AfterLabelEdit(sender As Object, e As LabelEditEventArgs)
			Dim flag As Boolean = Not Information.IsNothing(Me.CurrSlide)
			If flag Then
				Me.CurrSlide.Value = e.Label
			End If
		End Sub

		Private Sub PageReNameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lvPages.SelectedItems.Count > 0
			If flag Then
				Me.lvPages.SelectedItems(0).BeginEdit()
			End If
		End Sub

		Private Sub PageDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lvPages.SelectedItems.Count > 0
			If flag Then
				Dim i As Integer = Conversions.ToInteger(Me.lvPages.SelectedItems(0).Tag)
				Dim aSlide As CSlide = Me.mySlides.GetItemByID(i)
				Me.mySlides.Remove(aSlide)
				Me.PopulateList()
			End If
		End Sub

		Private Sub DuplicatePageToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(Me.mySlides)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.UpdateSlide()
				Dim mSlideId As Integer = Me.mySlides.GetMaxID() + 1
				Dim mNewSlide As CSlide = New CSlide("Trang " + mSlideId.ToString(), mSlideId, "", True)
				Dim cSlide As CSlide = mNewSlide
				cSlide.Symbols = Me.CurrSlide.Symbols
				cSlide.DaLayKH = Me.CurrSlide.DaLayKH
				cSlide.TyLeLayKH = Me.CurrSlide.TyLeLayKH
				Me.mySlides.Add(mNewSlide)
				Me.PopulateList()
				Me.lvPages.Items(Me.mySlides.Count - 1).Selected = True
				Me.PopulateForm()
			End If
		End Sub

		Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			openFileDialog.RestoreDirectory = True
			Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim mFileName As String = openFileDialog.FileName
				flag = (mFileName.Length > 0)
				If flag Then
					Me.myBando.drawingSymbols.Clear()
					Me.myBando.XoaUndoStack()
					flag = Information.IsNothing(Me.mySlides)
					If flag Then
						Me.mySlides = New CSlides()
					Else
						Me.mySlides.Clear()
					End If
					flag = Me.LoadSlides(mFileName)
					If flag Then
						Me.AxMap1.ZoomTo(modBanDo.BDZoomLevel, modBanDo.BDKinhDo, modBanDo.BDViDo)
						Me.HideDrawTools()
						Me.PopulateList()
						Me.lvPages.Items(0).Selected = True
						Me.PopulateForm()
						Me.myBando.UnseleKH()
					End If
					modBanDo.LastBdTC = mFileName
					Me.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n (" + modBanDo.LastBdTC + ")"
				End If
			End If
		End Sub

		Private Function LoadSlides(pFileName As String) As Boolean
			Dim bKQ As Boolean = False
			Dim strKQ As String = ""
			Dim flag As Boolean
			Try
				Dim sr As StreamReader = File.OpenText(pFileName)
				strKQ = sr.ReadToEnd()
			Catch expr_1A As Exception
				ProjectData.SetProjectError(expr_1A)
				Dim exc As Exception = expr_1A
				Interaction.MsgBox("File could not be opened or read." & vbCrLf & "Please verify that the filename is correct, and that you have read permissions for the desired directory." & vbCrLf & vbCrLf & "Exception: " + exc.Message, MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			Finally
				Dim sr As StreamReader
				flag = (sr IsNot Nothing)
				If flag Then
					sr.Close()
				End If
			End Try
			flag = (strKQ.Length > 8)
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean = strKQ.StartsWith("<Slides")
				If flag2 Then
					Dim mSlides As CSlides = Me.Str2Slides(strKQ)
					flag2 = (mSlides.Count > 0)
					If flag2 Then
						Dim i As Integer = Me.mySlides.Count
						Try
							Dim enumerator As IEnumerator = mSlides.GetEnumerator()
							While enumerator.MoveNext()
								Dim mSlide As CSlide = CType(enumerator.Current, CSlide)
								i += 1
								mSlide.ID = i
								mSlide.TyLeLayKH = modBanDo.myTyLeLayKH
								mSlide.DaLayKH = True
								Me.mySlides.Add(mSlide)
							End While
						Finally
							Dim enumerator As IEnumerator
							flag2 = (TypeOf enumerator Is IDisposable)
							If flag2 Then
								(TryCast(enumerator, IDisposable)).Dispose()
							End If
						End Try
						bKQ = True
					End If
				Else
					Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c ...", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
			Return bKQ
		End Function

		Private Function Str2Slides(pStr As String) As CSlides
			Dim mSlides As CSlides = Nothing
			Dim flag As Boolean = pStr.StartsWith("<Slides")
			If flag Then
				Dim nt As NameTable = New NameTable()
				Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(nt)
				nsmgr.AddNamespace("bk", "urn:sample")
				Dim context As XmlParserContext = New XmlParserContext(Nothing, nsmgr, Nothing, XmlSpace.None)
				Dim rr As XmlTextReader = New XmlTextReader(pStr, XmlNodeType.Element, context)
				mSlides = Me.XML2Slides(rr)
				rr.Close()
			End If
			Return mSlides
		End Function

		Private Function XML2Slides(rr As XmlTextReader) As CSlides
			Dim mSlides As CSlides = New CSlides()
			Dim mName As String = ""
			Dim mSymbols As String = ""
			Dim mChecked As Boolean = False
			Dim mDaLayKH As Boolean = False
			Dim mTyleLayKH As Single = 1F
			Dim mBDKinhDo As Double = Me.AxMap1.CenterX
			Dim mBDViDo As Double = Me.AxMap1.CenterY
			' The following expression was wrapped in a checked-expression
			Dim mBDZoomLevel As Integer = CInt(Math.Round(Me.AxMap1.Zoom))
			Try
				While rr.Read()
					Dim oNodeType As XmlNodeType = rr.NodeType
					Dim xmlNodeType As XmlNodeType = oNodeType
					Dim flag As Boolean = xmlNodeType = XmlNodeType.Element
					If flag Then
						Dim name As String = rr.Name
						Dim flag2 As Boolean = Operators.CompareString(name, "Slides", False) = 0
						If flag2 Then
							Dim flag3 As Boolean = rr.AttributeCount > 0
							If flag3 Then
								While rr.MoveToNextAttribute()
									Dim name2 As String = rr.Name
									Dim flag4 As Boolean = Operators.CompareString(name2, "BDLON", False) = 0
									If flag4 Then
										mBDKinhDo = Conversions.ToDouble(rr.Value)
									Else
										flag4 = (Operators.CompareString(name2, "BDLAT", False) = 0)
										If flag4 Then
											mBDViDo = Conversions.ToDouble(rr.Value)
										Else
											flag4 = (Operators.CompareString(name2, "BDZOOM", False) = 0)
											If flag4 Then
												mBDZoomLevel = Conversions.ToInteger(rr.Value)
											End If
										End If
									End If
								End While
							End If
						Else
							Dim flag4 As Boolean = Operators.CompareString(name, "Slide", False) = 0
							If flag4 Then
								mName = ""
								mSymbols = ""
								mTyleLayKH = 1F
								mChecked = False
								mDaLayKH = False
								flag4 = (rr.AttributeCount > 0)
								If flag4 Then
									While rr.MoveToNextAttribute()
										Dim name3 As String = rr.Name
										Dim flag3 As Boolean = Operators.CompareString(name3, "Name", False) = 0
										If flag3 Then
											mName = rr.Value
										Else
											flag4 = (Operators.CompareString(name3, "Checked", False) = 0)
											If flag4 Then
												mChecked = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
											Else
												flag4 = (Operators.CompareString(name3, "DaLayKH", False) = 0)
												If flag4 Then
													mDaLayKH = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(rr.Value, "True", False) = 0, True, False))
												Else
													flag4 = (Operators.CompareString(name3, "TyLe", False) = 0)
													If flag4 Then
														mTyleLayKH = 1F
														Try
															mTyleLayKH = Conversions.ToSingle(rr.Value)
														Catch expr_264 As Exception
															ProjectData.SetProjectError(expr_264)
															ProjectData.ClearProjectError()
														End Try
													Else
														flag4 = (Operators.CompareString(name3, "Symbols", False) = 0)
														If flag4 Then
															mSymbols = rr.Value
														End If
													End If
												End If
											End If
										End If
									End While
								End If
							End If
						End If
					Else
						Dim flag4 As Boolean = xmlNodeType = XmlNodeType.EndElement
						If flag4 Then
							Dim name4 As String = rr.Name
							Dim flag3 As Boolean = Operators.CompareString(name4, "Slide", False) = 0
							If flag3 Then
								mSlides.Add(New CSlide() With { .Value = mName, .Symbols = mSymbols, .Checked = mChecked, .DaLayKH = mDaLayKH, .TyLeLayKH = mTyleLayKH })
							End If
						End If
					End If
				End While
				modBanDo.BDKinhDo = mBDKinhDo
				modBanDo.BDViDo = mBDViDo
				modBanDo.BDZoomLevel = CDec(mBDZoomLevel)
			Catch arg_341_0 As Exception
				ProjectData.SetProjectError(arg_341_0)
				Interaction.MsgBox("Khong doc duoc XML Nay", MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			End Try
			Return mSlides
		End Function

		Private Sub ToolStripMenuBDView_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.myBando.bBanDo2Loaded
			If flag Then
				Dim flag2 As Boolean = Not Information.IsNothing(myModule.fBanDoNho)
				If flag2 Then
					myModule.fBanDoNho.Close()
				End If
				myModule.fCallForm = Me
				myModule.fBanDoNho = New dlgBanDoNho()
				myModule.fBanDoNho.Show(Me)
			Else
				Dim flag2 As Boolean = Not Information.IsNothing(myModule.fBanDoNho)
				If flag2 Then
					myModule.fBanDoNho.Close()
				End If
			End If
			Me.ToolStripMenuBDView.Checked = Me.myBando.bBanDo2Loaded
		End Sub

		Private Sub ToolStripMenuCacLopBD_Click(sender As Object, e As EventArgs)
			Me.myBando.CacLopBD()
		End Sub

		Private Sub ToolStripMenuLuuGeoSet_Click(sender As Object, e As EventArgs)
			Me.myBando.LuuGeoSet()
		End Sub

		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.myBando.drawingSymbols.Clear()
			Me.myBando.XoaUndoStack()
			Me.myBando.Zoom1X()
			Me.FirstSlide()
			modBanDo.LastBdTC = modBanDo.myNewBdTC
			Me.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n (" + modBanDo.LastBdTC + ")"
		End Sub

		Private Sub TrangSauToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lvPages.Items.Count > 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mIndex As Integer = 0
				Dim arg_31_0 As Integer = 0
				Dim num As Integer = Me.lvPages.Items.Count - 1
				Dim i As Integer = arg_31_0
				While True
					Dim arg_5F_0 As Integer = i
					Dim num2 As Integer = num
					If arg_5F_0 > num2 Then
						GoTo IL_61
					End If
					flag = Me.lvPages.Items(i).Selected
					If flag Then
						Exit While
					End If
					i += 1
				End While
				mIndex = i
				IL_61:
				flag = (mIndex < Me.lvPages.Items.Count - 1)
				If flag Then
					Me.UpdateSlide()
					Me.lvPages.Items(mIndex).Selected = False
					Me.lvPages.Items(mIndex + 1).Selected = True
					Me.PopulateForm()
				Else
					Interaction.MsgBox("Trang cu" & ChrW(7889) & "i r" & ChrW(7891) & "i", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub TrangTruocToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lvPages.Items.Count > 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim mIndex As Integer = 0
				Dim arg_31_0 As Integer = 0
				Dim num As Integer = Me.lvPages.Items.Count - 1
				Dim i As Integer = arg_31_0
				While True
					Dim arg_5F_0 As Integer = i
					Dim num2 As Integer = num
					If arg_5F_0 > num2 Then
						GoTo IL_61
					End If
					flag = Me.lvPages.Items(i).Selected
					If flag Then
						Exit While
					End If
					i += 1
				End While
				mIndex = i
				IL_61:
				flag = (mIndex > 0)
				If flag Then
					Me.UpdateSlide()
					Me.lvPages.Items(mIndex).Selected = False
					Me.lvPages.Items(mIndex - 1).Selected = True
					Me.PopulateForm()
				Else
					Interaction.MsgBox("Trang " & ChrW(273) & ChrW(7847) & "u r" & ChrW(7891) & "i", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub LineToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Line")
		End Sub

		Private Sub PolygonToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Polygon")
		End Sub

		Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs)
			Me.myBando.OnUndoClick()
		End Sub

		Private Sub RedoToolStripButton_Click(sender As Object, e As EventArgs)
			Me.myBando.OnRedoClick()
		End Sub

		Private Sub TableToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Table")
		End Sub

		Private Sub OptionsToolStripButton_Click(sender As Object, e As EventArgs)
			Dim f As Form = New dlgOptions()
			myModule.fCallForm = Me
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				modBanDo.Defa2File(modBanDo.myDefaFileName)
			End If
		End Sub

		Private Sub Zoom1XToolStripButton_Click(sender As Object, e As EventArgs)
			Me.myBando.Zoom1X()
		End Sub

		Private Sub ZoomToToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim f As dlgZoomTo = New dlgZoomTo()
			f.ShowDialog(Me)
		End Sub

		Private Sub lvPages_Click(sender As Object, e As EventArgs)
			Me.lvPages.Enabled = False
			Me.UpdateSlide()
			Me.PopulateForm()
			Me.lvPages.Enabled = True
		End Sub

		Public Function GetTyleLayKH() As Single
			Dim kq As Single = modBanDo.myTyLeLayKH
			Dim flag As Boolean = Not modBanDo.myDaLayKH
			If flag Then
				' The following expression was wrapped in a checked-expression
				modBanDo.myTyLeLayKH = CSng((CDec((Me.AxMap1.Width * 1000)) / (Me.AxMap1.Zoom * CDec(modBanDo.mySoPixelsPer1000m))))
			End If
			Return modBanDo.myTyLeLayKH
		End Function

		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(Me.mySlides)
			If flag Then
				Me.UpdateSlide()
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
				saveFileDialog.FilterIndex = 1
				saveFileDialog.RestoreDirectory = True
				flag = (saveFileDialog.ShowDialog() = DialogResult.OK)
				If flag Then
					Dim mFileName As String = saveFileDialog.FileName
					flag = (mFileName.Length > 0)
					If flag Then
						Me.SaveBDTC(mFileName)
						modBanDo.LastBdTC = mFileName
						Me.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n (" + modBanDo.LastBdTC + ")"
					End If
				End If
			End If
		End Sub

		Private Sub SaveBDTC(mFileName As String)
			Dim arg_16_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.lvPages.Items.Count - 1
			Dim i As Integer = arg_16_0
			While True
				Dim arg_4D_0 As Integer = i
				Dim num2 As Integer = num
				If arg_4D_0 > num2 Then
					Exit While
				End If
				Me.mySlides(i).Checked = Me.lvPages.Items(i).Checked
				i += 1
			End While
			Dim strKQ As String = ""
			Try
				strKQ = Me.mySlides.Slides2String(Me.AxMap1)
			Catch expr_6A As Exception
				ProjectData.SetProjectError(expr_6A)
				ProjectData.ClearProjectError()
			End Try
			Dim flag As Boolean = strKQ.Length > 8
			If flag Then
				Dim sw2 As StreamWriter = New StreamWriter(mFileName)
				sw2.Write(strKQ)
				sw2.Close()
			End If
		End Sub

		Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(Me.mySlides)
			If flag Then
				Me.UpdateSlide()
				flag = (Operators.CompareString(modBanDo.LastBdTC, modBanDo.myNewBdTC, False) = 0)
				If flag Then
					Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
					saveFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
					saveFileDialog.FilterIndex = 1
					saveFileDialog.RestoreDirectory = True
					flag = (saveFileDialog.ShowDialog() = DialogResult.OK)
					If flag Then
						Dim mFileName As String = saveFileDialog.FileName
						flag = (mFileName.Length > 0)
						If flag Then
							modBanDo.LastBdTC = mFileName
							Me.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " tác chi" & ChrW(7871) & "n (" + modBanDo.LastBdTC + ")"
						End If
					End If
				End If
				Me.SaveBDTC(modBanDo.LastBdTC)
			End If
		End Sub

		Private Function isCheckedItem() As Boolean
			Dim arg_15_0 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.lvPages.Items.Count - 1
			Dim i As Integer = arg_15_0
			While True
				Dim arg_45_0 As Integer = i
				Dim num2 As Integer = num
				If arg_45_0 > num2 Then
					GoTo Block_2
				End If
				Dim checked As Boolean = Me.lvPages.Items(i).Checked
				If checked Then
					Exit While
				End If
				i += 1
			End While
			Dim isCheckedItem As Boolean = True
			Return isCheckedItem
			Block_2:
			isCheckedItem = False
			Return isCheckedItem
		End Function

		Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.isCheckedItem()
			If flag Then
				Me.UpdateSlide()
				New dlgShow() With { .iCurrSlide = Me.lvPages.SelectedIndices(0) }.ShowDialog(Me)
			Else
				Interaction.MsgBox("Khong con Trang nao duoc chon.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub AxMap1_MapDraw(sender As Object, e As CMapXEvents_MapDrawEvent)
			Dim num2 As Integer
			Dim num3 As Integer
			Try
				IL_01:
				Dim num As Integer = 1
				Dim flag As Boolean = e.flag = 2S
				If Not flag Then
					GoTo IL_8E
				End If
				IL_10:
				num = 2
				Dim flag2 As Boolean = Me.ToolStripMenuBDView.Checked
				If Not flag2 Then
					GoTo IL_38
				End If
				IL_23:
				ProjectData.ClearProjectError()
				num2 = -2
				IL_2B:
				num = 4
				myModule.fBanDoNho.UpdateHinhChuNhat()
				IL_38:
				IL_39:
				num = 6
				flag2 = (Me.AxMap1.CenterX <> Me.m_LastMapCX Or Me.AxMap1.CenterY <> Me.m_LastMapCY)
				If Not flag2 Then
					GoTo IL_8D
				End If
				IL_6E:
				num = 7
				Me.ChangeDHFocus(Me.AxMap1.CenterX, Me.AxMap1.CenterY)
				IL_8D:
				IL_8E:
				IL_8F:
				GoTo IL_114
				IL_97:
				Dim arg_9C_0 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_9C_0)
				IL_CD:
				GoTo IL_109
				num3 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], If((num2 > -2), num2, 1))
				IL_E7:
				GoTo IL_109
			End Try
			Dim arg_E9_0 As Object
			endfilter(TypeOf arg_E9_0 Is Exception And num2 <> 0 And num3 = 0)
			IL_109:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_114:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub ChangeDHFocus(pLon As Double, pLat As Double)
			Dim flag As Boolean = pLon > modBanDo.myMap1X And pLon < modBanDo.myMap2X And (pLat < modBanDo.myMap1Y And pLat > modBanDo.myMap2Y)
			If flag Then
				Dim mSurfPos As PointF = modBanDo.GetSurfPosition(pLon, pLat)
				Me.myDiaHinh.ChangeFocus(mSurfPos.X / CSng(Me.m_TexImage.Width), (CSng(Me.m_TexImage.Height) - mSurfPos.Y) / CSng(Me.m_TexImage.Height))
				Me.m_LastMapCX = pLon
				Me.m_LastMapCY = pLat
			End If
		End Sub

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.frmMain_FormClosing
			AddHandler MyBase.Load, AddressOf Me.frmMain_Load
			frmMain.__ENCList.Add(New WeakReference(Me))
			Me.m_LastMapCX = 0.0
			Me.m_LastMapCY = 0.0
			Me.bLoaded = False
			Me.myDirty = False
			Me.InitializeComponent()
			myModule.intMonitorW = MyProject.Computer.Screen.WorkingArea.Width
			myModule.intMonitorH = MyProject.Computer.Screen.WorkingArea.Height
		End Sub

		Private Sub DrawSymbolToolStripButton_Click(sender As Object, e As EventArgs)
			Me.HienKyHieu()
		End Sub

		Private Sub HideSymbolToolStripButton_Click(sender As Object, e As EventArgs)
			Me.XoaKyHieu()
		End Sub

		Private Sub PhanLoaiKyHieuToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim f As dlgPhanLoaiKH = New dlgPhanLoaiKH()
			f.ShowDialog(Me)
		End Sub

		Private Sub MuiTenDacToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("MuiTenDac")
		End Sub

		Private Sub AddPagesFromToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.UpdateSlide()
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.InitialDirectory = Application.StartupPath
			openFileDialog.Filter = "BanDoTacChien files (*.bdtc)|*.BDTC|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			openFileDialog.RestoreDirectory = True
			Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim mFileName As String = openFileDialog.FileName
				flag = (mFileName.Length > 0)
				If flag Then
					Me.myBando.drawingSymbols.Clear()
					Me.myBando.XoaUndoStack()
					flag = Me.LoadSlides(mFileName)
					If flag Then
						Me.AxMap1.ZoomTo(modBanDo.BDZoomLevel, modBanDo.BDKinhDo, modBanDo.BDViDo)
						Me.HideDrawTools()
						Me.PopulateList()
						Me.lvPages.Items(0).Selected = True
						Me.PopulateForm()
						Me.myBando.UnseleKH()
					End If
				End If
			End If
		End Sub

		Private Sub ArcToolStripButton_Click(sender As Object, e As EventArgs)
			modBanDo.defaMyLineStyle = 0
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			Me.myBando.OnDrawObj("Arc")
		End Sub

		Private Sub RullerToolStripButton_Click(sender As Object, e As EventArgs)
			Me.myBando.OnDoKhoangCach()
		End Sub

		Private Sub InitTerrain()
			Me.LoadHeightData(modBanDo.myGridDataFile)
			Me.myDiaHinh = New CTerrain(Me.Panel3D, Me.heightData, modBanDo.mySCALE_FACTOR)
			Me.m_TexImage = New Bitmap(modBanDo.myTextureFile)
			' The following expression was wrapped in a checked-statement
			Me.myPixelsPerGridX = CDec(Me.m_TexImage.Width) / CDec((modBanDo.myGRID_WIDTH - 1))
			Me.myPixelsPerGridY = CDec(Me.m_TexImage.Height) / CDec((modBanDo.myGRID_HEIGHT - 1))
			modBanDo.mySurf2X = CDec(Me.m_TexImage.Width)
			modBanDo.mySurf2Y = CDec(Me.m_TexImage.Height)
			Dim arg_102_0 As CTerrain = Me.myDiaHinh
			Dim arg_102_1 As Bitmap = Me.m_TexImage
			Dim vector As Vector3 = New Vector3(0F, -44F, -22F)
			Dim arg_102_2 As Vector3 = vector
			Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
			Dim arg_102_3 As Vector3 = vector2
			Dim arg_102_4 As Single = -0.448798954F
			Dim vector3 As Vector3 = New Vector3(-15F, -15F, -20F)
			Dim arg_102_5 As Vector3 = vector3
			Dim pModellightDirection As Vector3 = New Vector3(0F, 10F, 5F)
			arg_102_0.InitTerrain(arg_102_1, arg_102_2, arg_102_3, arg_102_4, arg_102_5, pModellightDirection)
			Me.m_Symbol3Objs = New ArrayList()
			Me.myDiaHinh.LoadModelMeshs("D3DModelMesh.xml")
			Me.myDiaHinh.LoadBillboardMeshs("D3DBillboardMesh.xml")
		End Sub

		Private Sub HienKyHieu()
			Me.LoadSymbols()
			Me.m_TexImage = New Bitmap(modBanDo.myTextureFile)
			Me.DrawSymbol(Me.m_TexImage)
			Me.myDiaHinh.LoadMemStream(Me.m_TexImage)
		End Sub

		Public Sub XoaKyHieu()
			Me.myDiaHinh.ClearModels()
			Me.m_TexImage = New Bitmap(modBanDo.myTextureFile)
			Me.myDiaHinh.LoadMemStream(Me.m_TexImage)
		End Sub

		Public Function GetSymbolType(pSymbol As CSymbol) As String
			Dim Kq As String = "TexObj"
			Dim mIndex As Integer = Me.myDiaHinh.GetModelMeshIndex(pSymbol.Description)
			Dim flag As Boolean = mIndex > -1
			If flag Then
				Kq = "Model"
			Else
				mIndex = Me.myDiaHinh.GetBillboardMeshIndex(pSymbol.Description)
				flag = (mIndex > -1)
				If flag Then
					Kq = "Billboard"
				End If
			End If
			Return Kq
		End Function

		Private Sub LoadSymbols()
			Me.myDiaHinh.ClearModels()
			Me.myDiaHinh.ClearBillboards()
			Me.m_Symbol3Objs.Clear()
			Dim m_OWidth As Double
			Dim m_OHeight As Double
			' The following expression was wrapped in a checked-statement
			m_OWidth = Convert.ToDouble(Decimal.Multiply(New Decimal(Me.m_TexImage.Width), New Decimal(1000L))) / CDec((modBanDo.myGRID_WIDTH - 1)) / 1000.0
			m_OHeight = Convert.ToDouble(Decimal.Multiply(New Decimal(Me.m_TexImage.Height), New Decimal(1000L))) / CDec((modBanDo.myGRID_HEIGHT - 1)) / 1000.0
			Try
				Dim enumerator As IEnumerator = Me.myBando.drawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim aSB As CSymbol = CType(enumerator.Current, CSymbol)
					Dim mSurfPos As PointF = modBanDo.GetSurfPosition(aSB.GocX, aSB.GocY)
					Dim mIndex As Integer = Me.myDiaHinh.GetModelMeshIndex(aSB.Description)
					Dim flag As Boolean = mIndex > -1
					If flag Then
						Dim mSX As Single = CSng((CDec(mSurfPos.X) / m_OWidth))
						' The following expression was wrapped in a checked-expression
						Dim mSY As Single = CSng((CDec((modBanDo.myGRID_HEIGHT - 1)) - CDec(mSurfPos.Y) / m_OHeight))
						Dim mPos As Vector3 = New Vector3(mSX, mSY, -7F)
						Me.myDiaHinh.Load1Model(aSB.Description, mIndex, mPos)
					Else
						mIndex = Me.myDiaHinh.GetBillboardMeshIndex(aSB.Description)
						flag = (mIndex > -1)
						If flag Then
							Dim mSX2 As Single = CSng((CDec(mSurfPos.X) / m_OWidth))
							' The following expression was wrapped in a checked-expression
							Dim mSY2 As Single = CSng((CDec((modBanDo.myGRID_HEIGHT - 1)) - CDec(mSurfPos.Y) / m_OHeight))
							Dim mPos2 As Vector3 = New Vector3(mSX2, mSY2, -7F)
							Me.myDiaHinh.Load1Billboard(aSB.Description, mIndex, mPos2)
						Else
							Dim Scale As Single = CSng((aSB.Zoom / CDec(aSB.MWidth) * (CDec(modBanDo.my3DSoPixelsPer1000m) / 1000.0)))
							Dim mGObjs As CGraphicObjs = New CGraphicObjs()
							Try
								Dim enumerator2 As IEnumerator = aSB.GObjs.GetEnumerator()
								While enumerator2.MoveNext()
									Dim aGObj As GraphicObject = CType(enumerator2.Current, GraphicObject)
									Dim mGobj As GraphicObject = aGObj.Clone()
									mGObjs.Add(mGobj)
								End While
							Finally
								Dim enumerator2 As IEnumerator
								flag = (TypeOf enumerator2 Is IDisposable)
								If flag Then
									(TryCast(enumerator2, IDisposable)).Dispose()
								End If
							End Try
							Dim mSymbolObj As CSymbol3 = New CSymbol3(aSB.Description, mSurfPos, mGObjs)
							mSymbolObj.Zoom = CDec(Scale)
							Me.m_Symbol3Objs.Add(mSymbolObj)
						End If
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

		Private Sub DrawSymbol(bmpImage As Image)
			Dim g As Graphics = Graphics.FromImage(bmpImage)
			Try
				Dim enumerator As IEnumerator = Me.m_Symbol3Objs.GetEnumerator()
				While enumerator.MoveNext()
					Dim aSymbol As CSymbol3 = CType(enumerator.Current, CSymbol3)
					aSymbol.Draw(g)
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub ExportModels(pFileName As String)
			Dim sw As StreamWriter = New StreamWriter(pFileName)
			Dim wr As XmlTextWriter = New XmlTextWriter(sw)
			Dim i As Integer = 0
			wr.WriteStartElement("Models")
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CModel).Enumerator = Me.myDiaHinh.Models.GetEnumerator()
				While enumerator.MoveNext()
					Dim aModel As CModel = enumerator.Current
					i += 1
					Dim mName As String = aModel.Name
					Dim iMesh As Integer = Me.myDiaHinh.ModelMeshs.IndexOf(aModel.ModelMesh)
					wr.WriteStartElement("Model")
					wr.WriteAttributeString("Name", mName)
					wr.WriteAttributeString("iMesh", iMesh.ToString())
					wr.WriteAttributeString("X", aModel.X.ToString())
					wr.WriteAttributeString("Y", aModel.Y.ToString())
					wr.WriteAttributeString("Z", aModel.Z.ToString())
					wr.WriteEndElement()
				End While
			Finally
				Dim enumerator As List(Of CModel).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			wr.WriteEndElement()
			wr.Close()
		End Sub

		Private Sub ExportBillboards(pFileName As String)
			Dim sw As StreamWriter = New StreamWriter(pFileName)
			Dim wr As XmlTextWriter = New XmlTextWriter(sw)
			Dim i As Integer = 0
			wr.WriteStartElement("Billboards")
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CBillboard).Enumerator = Me.myDiaHinh.Billboards.GetEnumerator()
				While enumerator.MoveNext()
					Dim aBillboard As CBillboard = enumerator.Current
					i += 1
					Dim mName As String = aBillboard.Name
					Dim iMesh As Integer = Me.myDiaHinh.BillboardMeshs.IndexOf(aBillboard.BillboardMesh)
					wr.WriteStartElement("Billboard")
					wr.WriteAttributeString("Name", mName)
					wr.WriteAttributeString("iMesh", iMesh.ToString())
					Dim arg_AF_0 As XmlWriter = wr
					Dim arg_AF_1 As String = "X"
					Dim position As Vector3 = aBillboard.Position
					arg_AF_0.WriteAttributeString(arg_AF_1, position.X.ToString())
					Dim arg_D1_0 As XmlWriter = wr
					Dim arg_D1_1 As String = "Y"
					position = aBillboard.Position
					arg_D1_0.WriteAttributeString(arg_D1_1, position.Y.ToString())
					wr.WriteAttributeString("Z", aBillboard.Z.ToString())
					wr.WriteEndElement()
				End While
			Finally
				Dim enumerator As List(Of CBillboard).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			wr.WriteEndElement()
			wr.Close()
		End Sub

		Private Function IsActiveSymbol(pName As String, pActions As List(Of CActionDef)) As Boolean
			Dim kq As Boolean = False
			Dim flag As Boolean = pName.Length > 0
			If flag Then
				Try
					Dim enumerator As List(Of CActionDef).Enumerator = pActions.GetEnumerator()
					While enumerator.MoveNext()
						Dim aAction As CActionDef = enumerator.Current
						Dim flag2 As Boolean = Operators.CompareString(aAction.ObjName, pName, False) = 0
						If flag2 Then
							kq = True
							Exit While
						End If
					End While
				Finally
					Dim enumerator As List(Of CActionDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
			End If
			Return kq
		End Function

		Private Sub ExportTexObjs(pFileName As String, pActions As List(Of CActionDef))
			Dim i As Integer = 0
			Dim TexObjNames As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			Dim mTexImage As Bitmap = New Bitmap(modBanDo.myTextureFile)
			Dim g As Graphics = Graphics.FromImage(mTexImage)
			Dim sw As StreamWriter = New StreamWriter(pFileName)
			' The following expression was wrapped in a checked-statement
			Try
				sw.WriteLine("<TexObjs>")
				Try
					Dim enumerator As IEnumerator = Me.m_Symbol3Objs.GetEnumerator()
					While enumerator.MoveNext()
						Dim aSymbol As CSymbol3 = CType(enumerator.Current, CSymbol3)
						Dim flag As Boolean = Me.IsActiveSymbol(aSymbol.Name, pActions)
						If flag Then
							i += 1
							Dim mImageFile As String = modBanDo.mySaBanDir + "\TexObj" + i.ToString("000") + ".bmp"
							sw.WriteLine(Me.GetTexObjStr(aSymbol, mImageFile))
						Else
							aSymbol.Draw(g)
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					Dim flag As Boolean = TypeOf enumerator Is IDisposable
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				sw.WriteLine("</TexObjs>")
				sw.Close()
			Finally
				Dim flag As Boolean = sw IsNot Nothing
				If flag Then
					(CType(sw, IDisposable)).Dispose()
				End If
			End Try
			mTexImage.Save(modBanDo.mySaBanDir + "\DienTapMap.jpg")
			mTexImage.Dispose()
		End Sub

		Private Function GetTexObjStr(aSymbol As CSymbol3, mImageFile As String) As String
			Dim strKQ As String = "<TexObj"
			Dim rect As System.Drawing.Rectangle = aSymbol.GetBounds()
			Dim mName As String
			Dim mWidth As Integer
			Dim mHeight As Integer
			Dim mShiftX As Integer
			Dim mShiftY As Integer
			Dim mSymbolRect As System.Drawing.Rectangle
			Dim mSymbolImage As Bitmap
			' The following expression was wrapped in a checked-statement
			Dim mMinX As Integer = CInt(Math.Round(Math.Floor(CDec(rect.X) / Me.myPixelsPerGridX)))
			Dim mMinY As Integer = CInt(Math.Round(Math.Floor(CDec(rect.Y) / Me.myPixelsPerGridY)))
			Dim mMaxX As Integer = CInt(Math.Round(Math.Ceiling(CDec((rect.X + rect.Width)) / Me.myPixelsPerGridX)))
			Dim mMaxY As Integer = CInt(Math.Round(Math.Ceiling(CDec((rect.Y + rect.Height)) / Me.myPixelsPerGridY)))
			mName = aSymbol.Name
			mWidth = mMaxX - mMinX
			mHeight = mMaxY - mMinY
			mShiftX = mMinX
			mShiftY = modBanDo.myGRID_HEIGHT - 1 - mMaxY
			mSymbolRect = New System.Drawing.Rectangle(CInt(Math.Round(CDec(mMinX) * Me.myPixelsPerGridX)), CInt(Math.Round(CDec(mMinY) * Me.myPixelsPerGridY)), CInt(Math.Round(CDec((mMaxX - mMinX)) * Me.myPixelsPerGridX)), CInt(Math.Round(CDec((mMaxY - mMinY)) * Me.myPixelsPerGridY)))
			mSymbolImage = New Bitmap(mSymbolRect.Width, mSymbolRect.Height)
			aSymbol.GocX -= CDec(mSymbolRect.X)
			aSymbol.GocY -= CDec(mSymbolRect.Y)
			Dim g As Graphics = Graphics.FromImage(mSymbolImage)
			g.SmoothingMode = SmoothingMode.AntiAlias
			g.Clear(Color.White)
			aSymbol.Draw(g)
			g.Dispose()
			mSymbolImage.Save(mImageFile, ImageFormat.Bmp)
			strKQ = strKQ + " Name=""" + mName + """"
			strKQ = strKQ + " ImageFile=""" + mImageFile + """"
			strKQ = strKQ + " Width=""" + Conversions.ToString(mWidth) + """"
			strKQ = strKQ + " Height=""" + Conversions.ToString(mHeight) + """"
			strKQ = strKQ + " ShiftX=""" + Conversions.ToString(mShiftX) + """"
			strKQ = strKQ + " ShiftY=""" + Conversions.ToString(mShiftY) + """"
			Return strKQ + " />"
		End Function

		Private Sub Panel3D_MouseClick(sender As Object, e As MouseEventArgs)
			Me.Panel3D.[Select]()
		End Sub

		Private Sub XemToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim fileReader As String = MyProject.Computer.FileSystem.ReadAllText(modBanDo.mySaBanDefFileName)
			Dim flag As Boolean = fileReader.Length > 0
			If flag Then
				modBanDo.mySaBanDir = fileReader
			End If
			flag = MyProject.Computer.FileSystem.DirectoryExists(modBanDo.mySaBanDir)
			If flag Then
				Dim flag2 As Boolean = MyProject.Computer.FileSystem.FileExists(modBanDo.mySaBanDir + "\MyMenu.xml")
				If flag2 Then
					Dim f As Object = New Dlg3DShow()
					Dim mTexImage As Bitmap = New Bitmap(modBanDo.mySaBanDir + "\DienTapMap.jpg")
					Dim arg_122_0 As Object = f
					Dim arg_122_1 As Type = Nothing
					Dim arg_122_2 As String = "ShowDialog"
					Dim array As Object() = New Object() { mTexImage, Me.heightData, Me.myDiaHinh.cameraPos * 1.4F, Me.myDiaHinh.cameraTarget * 1.4F, modBanDo.mySaBanDir + "\MyMenu.xml" }
					Dim arg_122_3 As Object() = array
					Dim arg_122_4 As String() = Nothing
					Dim arg_122_5 As Type() = Nothing
					Dim array2 As Boolean() = New Boolean() { True, True, False, False, False }
					NewLateBinding.LateCall(arg_122_0, arg_122_1, arg_122_2, arg_122_3, arg_122_4, arg_122_5, array2, True)
					If array2(0) Then
						mTexImage = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Bitmap)), Bitmap)
					End If
					If array2(1) Then
						Me.heightData = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Single(,))), Single(,))
					End If
					mTexImage.Dispose()
					NewLateBinding.LateCall(f, Nothing, "Dispose", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Else
					Interaction.MsgBox("Không th" & ChrW(7845) & "y file: " + modBanDo.mySaBanDir + "\MyMenu.xml", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Không th" & ChrW(7845) & "y th" & ChrW(432) & " m" & ChrW(7909) & "c: " + modBanDo.mySaBanDir, MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Public Sub ExportCacDT(pActions As List(Of CActionDef))
			Me.LoadSymbols()
			Me.ExportModels(modBanDo.mySaBanDir + "\D3DModels.xml")
			Me.ExportBillboards(modBanDo.mySaBanDir + "\D3DBillboards.xml")
			Me.ExportTexObjs(modBanDo.mySaBanDir + "\D3DTexObjs.xml", pActions)
		End Sub

		Private Sub MoTaDienBienToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim fileReader As String = MyProject.Computer.FileSystem.ReadAllText(modBanDo.mySaBanDefFileName)
			Dim flag As Boolean = fileReader.Length > 0
			If flag Then
				modBanDo.mySaBanDir = fileReader
			End If
			New dlgActions() With { .TopMost = True }.Show(modBanDo.mySaBanDir + "\MyMenu.xml", Me)
		End Sub
	End Class
End Namespace
