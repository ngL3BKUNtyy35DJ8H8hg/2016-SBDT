Imports DienTapLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports SaBan.My.Resources
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgActions
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("lstActions")>
		Private _lstActions As ListBox

		<AccessedThroughProperty("btnUp")>
		Private _btnUp As Button

		<AccessedThroughProperty("btnDown")>
		Private _btnDown As Button

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("btnShoot")>
		Private _btnShoot As Button

		<AccessedThroughProperty("btnExplode")>
		Private _btnExplode As Button

		<AccessedThroughProperty("btnRun")>
		Private _btnRun As Button

		<AccessedThroughProperty("btnFly")>
		Private _btnFly As Button

		<AccessedThroughProperty("btnBlink")>
		Private _btnBlink As Button

		<AccessedThroughProperty("btnAppear")>
		Private _btnAppear As Button

		<AccessedThroughProperty("btnDisappear")>
		Private _btnDisappear As Button

		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		<AccessedThroughProperty("cboScripts")>
		Private _cboScripts As ComboBox

		<AccessedThroughProperty("SaBanToolStripMenuItem")>
		Private _SaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("NewSaBanToolStripMenuItem")>
		Private _NewSaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripSeparator

		<AccessedThroughProperty("OpenSaBanToolStripMenuItem")>
		Private _OpenSaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem4")>
		Private _ToolStripMenuItem4 As ToolStripSeparator

		<AccessedThroughProperty("UpdateMenuToolStripMenuItem")>
		Private _UpdateMenuToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("btnBombard")>
		Private _btnBombard As Button

		<AccessedThroughProperty("btnCopy")>
		Private _btnCopy As Button

		<AccessedThroughProperty("txtActFileName")>
		Private _txtActFileName As TextBox

		<AccessedThroughProperty("btnComment")>
		Private _btnComment As Button

		<AccessedThroughProperty("btnExplodeDecl")>
		Private _btnExplodeDecl As Button

		<AccessedThroughProperty("btnSave")>
		Private _btnSave As Button

		<AccessedThroughProperty("btnSpin")>
		Private _btnSpin As Button

		<AccessedThroughProperty("ListActsToolStripMenuItem")>
		Private _ListActsToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("RebuildToolStripMenuItem")>
		Private _RebuildToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("btnFocusAt")>
		Private _btnFocusAt As Button

		<AccessedThroughProperty("btnDescription")>
		Private _btnDescription As Button

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("TitleFontToolStripMenuItem")>
		Private _TitleFontToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("DescFontToolStripMenuItem")>
		Private _DescFontToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DescTrenFontToolStripMenuItem")>
		Private _DescTrenFontToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("DescGiuaFontToolStripMenuItem")>
		Private _DescGiuaFontToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("btnCornerTitle")>
		Private _btnCornerTitle As Button

		Private MenuFileName As String

		Private mymnu As CMnu

		Private Parentf As frmMain

		Private actions As List(Of CActDef)

		Private CurrIndex As Integer

		Private actID As Integer

		Public bDirty As Boolean

		Private bMenuLoaded As Boolean

		Private bRefresh As Boolean

		Public bView As Boolean

		Friend Overridable Property Cancel_Button() As Button
			Get
				Return Me._Cancel_Button
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cancel_Button_Click
				If Me._Cancel_Button IsNot Nothing Then
					RemoveHandler Me._Cancel_Button.Click, value2
				End If
				Me._Cancel_Button = value
				If Me._Cancel_Button IsNot Nothing Then
					AddHandler Me._Cancel_Button.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property OK_Button() As Button
			Get
				Return Me._OK_Button
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.OK_Button_Click
				If Me._OK_Button IsNot Nothing Then
					RemoveHandler Me._OK_Button.Click, value2
				End If
				Me._OK_Button = value
				If Me._OK_Button IsNot Nothing Then
					AddHandler Me._OK_Button.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lstActions() As ListBox
			Get
				Return Me._lstActions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstActions_DoubleClick
				Dim value3 As KeyEventHandler = AddressOf Me.lstActions_KeyUp
				Dim value4 As EventHandler = AddressOf Me.lstActions_Click
				If Me._lstActions IsNot Nothing Then
					RemoveHandler Me._lstActions.DoubleClick, value2
					RemoveHandler Me._lstActions.KeyUp, value3
					RemoveHandler Me._lstActions.Click, value4
				End If
				Me._lstActions = value
				If Me._lstActions IsNot Nothing Then
					AddHandler Me._lstActions.DoubleClick, value2
					AddHandler Me._lstActions.KeyUp, value3
					AddHandler Me._lstActions.Click, value4
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

		Friend Overridable Property GroupBox1() As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property btnShoot() As Button
			Get
				Return Me._btnShoot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnShoot_Click
				If Me._btnShoot IsNot Nothing Then
					RemoveHandler Me._btnShoot.Click, value2
				End If
				Me._btnShoot = value
				If Me._btnShoot IsNot Nothing Then
					AddHandler Me._btnShoot.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnExplode() As Button
			Get
				Return Me._btnExplode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnExplode_Click
				If Me._btnExplode IsNot Nothing Then
					RemoveHandler Me._btnExplode.Click, value2
				End If
				Me._btnExplode = value
				If Me._btnExplode IsNot Nothing Then
					AddHandler Me._btnExplode.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnRun() As Button
			Get
				Return Me._btnRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnRun_Click
				If Me._btnRun IsNot Nothing Then
					RemoveHandler Me._btnRun.Click, value2
				End If
				Me._btnRun = value
				If Me._btnRun IsNot Nothing Then
					AddHandler Me._btnRun.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnFly() As Button
			Get
				Return Me._btnFly
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnFly_Click
				If Me._btnFly IsNot Nothing Then
					RemoveHandler Me._btnFly.Click, value2
				End If
				Me._btnFly = value
				If Me._btnFly IsNot Nothing Then
					AddHandler Me._btnFly.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnBlink() As Button
			Get
				Return Me._btnBlink
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnBlink_Click
				If Me._btnBlink IsNot Nothing Then
					RemoveHandler Me._btnBlink.Click, value2
				End If
				Me._btnBlink = value
				If Me._btnBlink IsNot Nothing Then
					AddHandler Me._btnBlink.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnAppear() As Button
			Get
				Return Me._btnAppear
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnWipe_Click
				If Me._btnAppear IsNot Nothing Then
					RemoveHandler Me._btnAppear.Click, value2
				End If
				Me._btnAppear = value
				If Me._btnAppear IsNot Nothing Then
					AddHandler Me._btnAppear.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnDisappear() As Button
			Get
				Return Me._btnDisappear
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDisappear_Click
				If Me._btnDisappear IsNot Nothing Then
					RemoveHandler Me._btnDisappear.Click, value2
				End If
				Me._btnDisappear = value
				If Me._btnDisappear IsNot Nothing Then
					AddHandler Me._btnDisappear.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuStrip1() As MenuStrip
			Get
				Return Me._MenuStrip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		Friend Overridable Property cboScripts() As ComboBox
			Get
				Return Me._cboScripts
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboMenuItem_SelectedIndexChanged
				If Me._cboScripts IsNot Nothing Then
					RemoveHandler Me._cboScripts.SelectedIndexChanged, value2
				End If
				Me._cboScripts = value
				If Me._cboScripts IsNot Nothing Then
					AddHandler Me._cboScripts.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property SaBanToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._SaBanToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaBanToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property NewSaBanToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._NewSaBanToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewSaBanToolStripMenuItem_Click
				If Me._NewSaBanToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewSaBanToolStripMenuItem.Click, value2
				End If
				Me._NewSaBanToolStripMenuItem = value
				If Me._NewSaBanToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewSaBanToolStripMenuItem.Click, value2
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

		Friend Overridable Property OpenSaBanToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._OpenSaBanToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenSaBanToolStripMenuItem_Click
				If Me._OpenSaBanToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenSaBanToolStripMenuItem.Click, value2
				End If
				Me._OpenSaBanToolStripMenuItem = value
				If Me._OpenSaBanToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenSaBanToolStripMenuItem.Click, value2
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

		Friend Overridable Property UpdateMenuToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._UpdateMenuToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UpdateMenuToolStripMenuItem_Click
				If Me._UpdateMenuToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UpdateMenuToolStripMenuItem.Click, value2
				End If
				Me._UpdateMenuToolStripMenuItem = value
				If Me._UpdateMenuToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UpdateMenuToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnBombard() As Button
			Get
				Return Me._btnBombard
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnBombard_Click
				If Me._btnBombard IsNot Nothing Then
					RemoveHandler Me._btnBombard.Click, value2
				End If
				Me._btnBombard = value
				If Me._btnBombard IsNot Nothing Then
					AddHandler Me._btnBombard.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnCopy() As Button
			Get
				Return Me._btnCopy
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCopy_Click
				If Me._btnCopy IsNot Nothing Then
					RemoveHandler Me._btnCopy.Click, value2
				End If
				Me._btnCopy = value
				If Me._btnCopy IsNot Nothing Then
					AddHandler Me._btnCopy.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtActFileName() As TextBox
			Get
				Return Me._txtActFileName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActFileName = value
			End Set
		End Property

		Friend Overridable Property btnComment() As Button
			Get
				Return Me._btnComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnComment_Click
				If Me._btnComment IsNot Nothing Then
					RemoveHandler Me._btnComment.Click, value2
				End If
				Me._btnComment = value
				If Me._btnComment IsNot Nothing Then
					AddHandler Me._btnComment.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnExplodeDecl() As Button
			Get
				Return Me._btnExplodeDecl
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnExplodeDecl_Click
				If Me._btnExplodeDecl IsNot Nothing Then
					RemoveHandler Me._btnExplodeDecl.Click, value2
				End If
				Me._btnExplodeDecl = value
				If Me._btnExplodeDecl IsNot Nothing Then
					AddHandler Me._btnExplodeDecl.Click, value2
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

		Friend Overridable Property btnSpin() As Button
			Get
				Return Me._btnSpin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSpin_Click
				If Me._btnSpin IsNot Nothing Then
					RemoveHandler Me._btnSpin.Click, value2
				End If
				Me._btnSpin = value
				If Me._btnSpin IsNot Nothing Then
					AddHandler Me._btnSpin.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ListActsToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._ListActsToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ListActsToolStripMenuItem_Click
				If Me._ListActsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ListActsToolStripMenuItem.Click, value2
				End If
				Me._ListActsToolStripMenuItem = value
				If Me._ListActsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ListActsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property RebuildToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._RebuildToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RebuildToolStripMenuItem_Click
				If Me._RebuildToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RebuildToolStripMenuItem.Click, value2
				End If
				Me._RebuildToolStripMenuItem = value
				If Me._RebuildToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RebuildToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnFocusAt() As Button
			Get
				Return Me._btnFocusAt
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnFocusAt_Click
				If Me._btnFocusAt IsNot Nothing Then
					RemoveHandler Me._btnFocusAt.Click, value2
				End If
				Me._btnFocusAt = value
				If Me._btnFocusAt IsNot Nothing Then
					AddHandler Me._btnFocusAt.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnDescription() As Button
			Get
				Return Me._btnDescription
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnDescription_Click
				If Me._btnDescription IsNot Nothing Then
					RemoveHandler Me._btnDescription.Click, value2
				End If
				Me._btnDescription = value
				If Me._btnDescription IsNot Nothing Then
					AddHandler Me._btnDescription.Click, value2
				End If
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

		Friend Overridable Property TitleFontToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._TitleFontToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.TitleFontToolStripMenuItem_Click
				If Me._TitleFontToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._TitleFontToolStripMenuItem.Click, value2
				End If
				Me._TitleFontToolStripMenuItem = value
				If Me._TitleFontToolStripMenuItem IsNot Nothing Then
					AddHandler Me._TitleFontToolStripMenuItem.Click, value2
				End If
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

		Friend Overridable Property DescFontToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DescFontToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DescFontToolStripMenuItem_Click
				If Me._DescFontToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DescFontToolStripMenuItem.Click, value2
				End If
				Me._DescFontToolStripMenuItem = value
				If Me._DescFontToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DescFontToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DescTrenFontToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DescTrenFontToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DescTrenFontToolStripMenuItem_Click
				If Me._DescTrenFontToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DescTrenFontToolStripMenuItem.Click, value2
				End If
				Me._DescTrenFontToolStripMenuItem = value
				If Me._DescTrenFontToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DescTrenFontToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property DescGiuaFontToolStripMenuItem() As ToolStripMenuItem
			Get
				Return Me._DescGiuaFontToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DescGiuaFontToolStripMenuItem_Click
				If Me._DescGiuaFontToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DescGiuaFontToolStripMenuItem.Click, value2
				End If
				Me._DescGiuaFontToolStripMenuItem = value
				If Me._DescGiuaFontToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DescGiuaFontToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnCornerTitle() As Button
			Get
				Return Me._btnCornerTitle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCornerTitle_Click
				If Me._btnCornerTitle IsNot Nothing Then
					RemoveHandler Me._btnCornerTitle.Click, value2
				End If
				Me._btnCornerTitle = value
				If Me._btnCornerTitle IsNot Nothing Then
					AddHandler Me._btnCornerTitle.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgActions_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgActions_Load
			Me.CurrIndex = 0
			Me.bDirty = False
			Me.bMenuLoaded = False
			Me.bRefresh = False
			Me.bView = True
			Me.InitializeComponent()
		End Sub

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
			Me.Cancel_Button = New Button()
			Me.OK_Button = New Button()
			Me.lstActions = New ListBox()
			Me.GroupBox1 = New GroupBox()
			Me.btnDescription = New Button()
			Me.btnFocusAt = New Button()
			Me.btnSpin = New Button()
			Me.btnExplodeDecl = New Button()
			Me.btnComment = New Button()
			Me.btnBombard = New Button()
			Me.btnShoot = New Button()
			Me.btnExplode = New Button()
			Me.btnRun = New Button()
			Me.btnFly = New Button()
			Me.btnBlink = New Button()
			Me.btnAppear = New Button()
			Me.btnDisappear = New Button()
			Me.MenuStrip1 = New MenuStrip()
			Me.SaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.NewSaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem3 = New ToolStripSeparator()
			Me.OpenSaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem4 = New ToolStripSeparator()
			Me.UpdateMenuToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.TitleFontToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.DescFontToolStripMenuItem = New ToolStripMenuItem()
			Me.DescTrenFontToolStripMenuItem = New ToolStripMenuItem()
			Me.DescGiuaFontToolStripMenuItem = New ToolStripMenuItem()
			Me.RebuildToolStripMenuItem = New ToolStripMenuItem()
			Me.ListActsToolStripMenuItem = New ToolStripMenuItem()
			Me.cboScripts = New ComboBox()
			Me.btnCopy = New Button()
			Me.txtActFileName = New TextBox()
			Me.btnSave = New Button()
			Me.btnDown = New Button()
			Me.btnUp = New Button()
			Me.btnCornerTitle = New Button()
			Me.GroupBox1.SuspendLayout()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.Cancel_Button.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1F7_0 As Control = Me.Cancel_Button
			Dim location As Point = New Point(420, 36)
			arg_1F7_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_21E_0 As Control = Me.Cancel_Button
			Dim size As Size = New Size(67, 23)
			arg_21E_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.OK_Button.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_261_0 As Control = Me.OK_Button
			location = New Point(347, 36)
			arg_261_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_288_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_288_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.lstActions.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstActions.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lstActions.FormattingEnabled = True
			Me.lstActions.ItemHeight = 14
			Dim arg_2FE_0 As Control = Me.lstActions
			location = New Point(12, 66)
			arg_2FE_0.Location = location
			Me.lstActions.Name = "lstActions"
			Dim arg_32B_0 As Control = Me.lstActions
			size = New Size(475, 326)
			arg_32B_0.Size = size
			Me.lstActions.TabIndex = 2
			Me.GroupBox1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.GroupBox1.Controls.Add(Me.btnCornerTitle)
			Me.GroupBox1.Controls.Add(Me.btnDescription)
			Me.GroupBox1.Controls.Add(Me.btnFocusAt)
			Me.GroupBox1.Controls.Add(Me.btnSpin)
			Me.GroupBox1.Controls.Add(Me.btnExplodeDecl)
			Me.GroupBox1.Controls.Add(Me.btnComment)
			Me.GroupBox1.Controls.Add(Me.btnBombard)
			Me.GroupBox1.Controls.Add(Me.btnShoot)
			Me.GroupBox1.Controls.Add(Me.btnExplode)
			Me.GroupBox1.Controls.Add(Me.btnRun)
			Me.GroupBox1.Controls.Add(Me.btnFly)
			Me.GroupBox1.Controls.Add(Me.btnBlink)
			Me.GroupBox1.Controls.Add(Me.btnAppear)
			Me.GroupBox1.Controls.Add(Me.btnDisappear)
			Dim arg_491_0 As Control = Me.GroupBox1
			location = New Point(14, 409)
			arg_491_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_4BB_0 As Control = Me.GroupBox1
			size = New Size(390, 113)
			arg_4BB_0.Size = size
			Me.GroupBox1.TabIndex = 5
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Thêm m" & ChrW(7899) & "i:"
			Dim arg_4FA_0 As Control = Me.btnDescription
			location = New Point(74, 78)
			arg_4FA_0.Location = location
			Me.btnDescription.Name = "btnDescription"
			Dim arg_521_0 As Control = Me.btnDescription
			size = New Size(88, 23)
			arg_521_0.Size = size
			Me.btnDescription.TabIndex = 12
			Me.btnDescription.Text = "Thuy" & ChrW(7871) & "t minh"
			Me.btnDescription.UseVisualStyleBackColor = True
			Dim arg_560_0 As Control = Me.btnFocusAt
			location = New Point(7, 78)
			arg_560_0.Location = location
			Me.btnFocusAt.Name = "btnFocusAt"
			Dim arg_587_0 As Control = Me.btnFocusAt
			size = New Size(61, 23)
			arg_587_0.Size = size
			Me.btnFocusAt.TabIndex = 11
			Me.btnFocusAt.Text = "Tiêu " & ChrW(273) & "i" & ChrW(7875) & "m"
			Me.btnFocusAt.UseVisualStyleBackColor = True
			Dim arg_5CA_0 As Control = Me.btnSpin
			location = New Point(312, 49)
			arg_5CA_0.Location = location
			Me.btnSpin.Name = "btnSpin"
			Dim arg_5F1_0 As Control = Me.btnSpin
			size = New Size(71, 23)
			arg_5F1_0.Size = size
			Me.btnSpin.TabIndex = 10
			Me.btnSpin.Text = "H" & ChrW(432) & ChrW(7899) & "ng t" & ChrW(7899) & "i"
			Me.btnSpin.UseVisualStyleBackColor = True
			Dim arg_631_0 As Control = Me.btnExplodeDecl
			location = New Point(55, 49)
			arg_631_0.Location = location
			Me.btnExplodeDecl.Name = "btnExplodeDecl"
			Dim arg_658_0 As Control = Me.btnExplodeDecl
			size = New Size(95, 23)
			arg_658_0.Size = size
			Me.btnExplodeDecl.TabIndex = 9
			Me.btnExplodeDecl.Text = "Khai báo qu" & ChrW(7843) & " n" & ChrW(7893)
			Me.btnExplodeDecl.UseVisualStyleBackColor = True
			Dim arg_69B_0 As Control = Me.btnComment
			location = New Point(323, 78)
			arg_69B_0.Location = location
			Me.btnComment.Name = "btnComment"
			Dim arg_6C2_0 As Control = Me.btnComment
			size = New Size(60, 23)
			arg_6C2_0.Size = size
			Me.btnComment.TabIndex = 8
			Me.btnComment.Text = "Ghi chú"
			Me.btnComment.UseVisualStyleBackColor = True
			Dim arg_704_0 As Control = Me.btnBombard
			location = New Point(241, 49)
			arg_704_0.Location = location
			Me.btnBombard.Name = "btnBombard"
			Dim arg_72B_0 As Control = Me.btnBombard
			size = New Size(65, 23)
			arg_72B_0.Size = size
			Me.btnBombard.TabIndex = 7
			Me.btnBombard.Text = "B" & ChrW(7855) & "n cong"
			Me.btnBombard.UseVisualStyleBackColor = True
			Dim arg_76D_0 As Control = Me.btnShoot
			location = New Point(156, 49)
			arg_76D_0.Location = location
			Me.btnShoot.Name = "btnShoot"
			Dim arg_794_0 As Control = Me.btnShoot
			size = New Size(79, 23)
			arg_794_0.Size = size
			Me.btnShoot.TabIndex = 6
			Me.btnShoot.Text = "B" & ChrW(7855) & "n th" & ChrW(7859) & "ng"
			Me.btnShoot.UseVisualStyleBackColor = True
			Dim arg_7D2_0 As Control = Me.btnExplode
			location = New Point(7, 49)
			arg_7D2_0.Location = location
			Me.btnExplode.Name = "btnExplode"
			Dim arg_7F9_0 As Control = Me.btnExplode
			size = New Size(42, 23)
			arg_7F9_0.Size = size
			Me.btnExplode.TabIndex = 5
			Me.btnExplode.Text = "N" & ChrW(7893)
			Me.btnExplode.UseVisualStyleBackColor = True
			Dim arg_83B_0 As Control = Me.btnRun
			location = New Point(312, 20)
			arg_83B_0.Location = location
			Me.btnRun.Name = "btnRun"
			Dim arg_862_0 As Control = Me.btnRun
			size = New Size(71, 23)
			arg_862_0.Size = size
			Me.btnRun.TabIndex = 4
			Me.btnRun.Text = "Ch" & ChrW(7841) & "y"
			Me.btnRun.UseVisualStyleBackColor = True
			Dim arg_8A4_0 As Control = Me.btnFly
			location = New Point(241, 20)
			arg_8A4_0.Location = location
			Me.btnFly.Name = "btnFly"
			Dim arg_8CB_0 As Control = Me.btnFly
			size = New Size(65, 23)
			arg_8CB_0.Size = size
			Me.btnFly.TabIndex = 3
			Me.btnFly.Text = "Bay"
			Me.btnFly.UseVisualStyleBackColor = True
			Dim arg_90D_0 As Control = Me.btnBlink
			location = New Point(156, 20)
			arg_90D_0.Location = location
			Me.btnBlink.Name = "btnBlink"
			Dim arg_934_0 As Control = Me.btnBlink
			size = New Size(79, 23)
			arg_934_0.Size = size
			Me.btnBlink.TabIndex = 2
			Me.btnBlink.Text = "Nh" & ChrW(7845) & "p nháy"
			Me.btnBlink.UseVisualStyleBackColor = True
			Me.btnAppear.Font = New Font("Tahoma", 8.164948F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_98F_0 As Control = Me.btnAppear
			location = New Point(6, 20)
			arg_98F_0.Location = location
			Me.btnAppear.Name = "btnAppear"
			Dim arg_9B6_0 As Control = Me.btnAppear
			size = New Size(75, 23)
			arg_9B6_0.Size = size
			Me.btnAppear.TabIndex = 1
			Me.btnAppear.Text = "Xu" & ChrW(7845) & "t hi" & ChrW(7879) & "n"
			Me.btnAppear.UseVisualStyleBackColor = True
			Dim arg_9F5_0 As Control = Me.btnDisappear
			location = New Point(87, 20)
			arg_9F5_0.Location = location
			Me.btnDisappear.Name = "btnDisappear"
			Dim arg_A1C_0 As Control = Me.btnDisappear
			size = New Size(63, 23)
			arg_A1C_0.Size = size
			Me.btnDisappear.TabIndex = 0
			Me.btnDisappear.Text = ChrW(7848) & "n"
			Me.btnDisappear.UseVisualStyleBackColor = True
			Me.MenuStrip1.Items.AddRange(New ToolStripItem() { Me.SaBanToolStripMenuItem, Me.RebuildToolStripMenuItem, Me.ListActsToolStripMenuItem })
			Dim arg_A91_0 As Control = Me.MenuStrip1
			location = New Point(0, 0)
			arg_A91_0.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim arg_ABB_0 As Control = Me.MenuStrip1
			size = New Size(499, 24)
			arg_ABB_0.Size = size
			Me.MenuStrip1.TabIndex = 6
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.SaBanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.NewSaBanToolStripMenuItem, Me.ToolStripMenuItem3, Me.OpenSaBanToolStripMenuItem, Me.ToolStripMenuItem4, Me.UpdateMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.TitleFontToolStripMenuItem, Me.ToolStripSeparator2, Me.DescFontToolStripMenuItem, Me.DescTrenFontToolStripMenuItem, Me.DescGiuaFontToolStripMenuItem })
			Me.SaBanToolStripMenuItem.Name = "SaBanToolStripMenuItem"
			Dim arg_B89_0 As ToolStripItem = Me.SaBanToolStripMenuItem
			size = New Size(50, 20)
			arg_B89_0.Size = size
			Me.SaBanToolStripMenuItem.Text = "Menu"
			Me.NewSaBanToolStripMenuItem.Name = "NewSaBanToolStripMenuItem"
			Dim arg_BC3_0 As ToolStripItem = Me.NewSaBanToolStripMenuItem
			size = New Size(233, 22)
			arg_BC3_0.Size = size
			Me.NewSaBanToolStripMenuItem.Text = "H" & ChrW(7879) & " th" & ChrW(7889) & "ng Menu, k" & ChrW(7883) & "ch b" & ChrW(7843) & "n m" & ChrW(7899) & "i"
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Dim arg_BFC_0 As ToolStripItem = Me.ToolStripMenuItem3
			size = New Size(230, 6)
			arg_BFC_0.Size = size
			Me.OpenSaBanToolStripMenuItem.Name = "OpenSaBanToolStripMenuItem"
			Dim arg_C26_0 As ToolStripItem = Me.OpenSaBanToolStripMenuItem
			size = New Size(233, 22)
			arg_C26_0.Size = size
			Me.OpenSaBanToolStripMenuItem.Text = "M" & ChrW(7903) & " H" & ChrW(7879) & " th" & ChrW(7889) & "ng menu"
			Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
			Dim arg_C5F_0 As ToolStripItem = Me.ToolStripMenuItem4
			size = New Size(230, 6)
			arg_C5F_0.Size = size
			Me.UpdateMenuToolStripMenuItem.Name = "UpdateMenuToolStripMenuItem"
			Dim arg_C89_0 As ToolStripItem = Me.UpdateMenuToolStripMenuItem
			size = New Size(233, 22)
			arg_C89_0.Size = size
			Me.UpdateMenuToolStripMenuItem.Text = "So" & ChrW(7841) & "n th" & ChrW(7843) & "o, b" & ChrW(7889) & " trí Menu"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim arg_CC2_0 As ToolStripItem = Me.ToolStripSeparator1
			size = New Size(230, 6)
			arg_CC2_0.Size = size
			Me.TitleFontToolStripMenuItem.Name = "TitleFontToolStripMenuItem"
			Dim arg_CEC_0 As ToolStripItem = Me.TitleFontToolStripMenuItem
			size = New Size(233, 22)
			arg_CEC_0.Size = size
			Me.TitleFontToolStripMenuItem.Text = "Tiêu " & ChrW(273) & ChrW(7873) & ", font Tiêu " & ChrW(273) & ChrW(7873)
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim arg_D25_0 As ToolStripItem = Me.ToolStripSeparator2
			size = New Size(230, 6)
			arg_D25_0.Size = size
			Me.DescFontToolStripMenuItem.Name = "DescFontToolStripMenuItem"
			Dim arg_D4F_0 As ToolStripItem = Me.DescFontToolStripMenuItem
			size = New Size(233, 22)
			arg_D4F_0.Size = size
			Me.DescFontToolStripMenuItem.Text = "font cho Thuy" & ChrW(7871) & "t minh d" & ChrW(432) & ChrW(7899) & "i"
			Me.DescTrenFontToolStripMenuItem.Name = "DescTrenFontToolStripMenuItem"
			Dim arg_D89_0 As ToolStripItem = Me.DescTrenFontToolStripMenuItem
			size = New Size(233, 22)
			arg_D89_0.Size = size
			Me.DescTrenFontToolStripMenuItem.Text = "font cho Thuy" & ChrW(7871) & "t minh trên"
			Me.DescGiuaFontToolStripMenuItem.Name = "DescGiuaFontToolStripMenuItem"
			Dim arg_DC3_0 As ToolStripItem = Me.DescGiuaFontToolStripMenuItem
			size = New Size(233, 22)
			arg_DC3_0.Size = size
			Me.DescGiuaFontToolStripMenuItem.Text = "font cho Thuy" & ChrW(7871) & "t minh gi" & ChrW(7919) & "a"
			Me.RebuildToolStripMenuItem.Name = "RebuildToolStripMenuItem"
			Dim arg_DFA_0 As ToolStripItem = Me.RebuildToolStripMenuItem
			size = New Size(59, 20)
			arg_DFA_0.Size = size
			Me.RebuildToolStripMenuItem.Text = "Rebuild"
			Me.ListActsToolStripMenuItem.Name = "ListActsToolStripMenuItem"
			Dim arg_E31_0 As ToolStripItem = Me.ListActsToolStripMenuItem
			size = New Size(114, 20)
			arg_E31_0.Size = size
			Me.ListActsToolStripMenuItem.Text = "Li" & ChrW(7879) & "t kê hành " & ChrW(273) & ChrW(7897) & "ng"
			Me.cboScripts.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.cboScripts.FormattingEnabled = True
			Dim arg_E71_0 As Control = Me.cboScripts
			location = New Point(14, 36)
			arg_E71_0.Location = location
			Me.cboScripts.Name = "cboScripts"
			Dim arg_E9B_0 As Control = Me.cboScripts
			size = New Size(317, 21)
			arg_E9B_0.Size = size
			Me.cboScripts.TabIndex = 7
			Me.btnCopy.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Dim arg_ED1_0 As Control = Me.btnCopy
			location = New Point(431, 465)
			arg_ED1_0.Location = location
			Me.btnCopy.Name = "btnCopy"
			Dim arg_EF8_0 As Control = Me.btnCopy
			size = New Size(56, 23)
			arg_EF8_0.Size = size
			Me.btnCopy.TabIndex = 12
			Me.btnCopy.Text = "Copy"
			Me.btnCopy.UseVisualStyleBackColor = True
			Dim arg_F3B_0 As Control = Me.txtActFileName
			location = New Point(176, 53)
			arg_F3B_0.Location = location
			Me.txtActFileName.Name = "txtActFileName"
			Me.txtActFileName.[ReadOnly] = True
			Dim arg_F6E_0 As Control = Me.txtActFileName
			size = New Size(32, 21)
			arg_F6E_0.Size = size
			Me.txtActFileName.TabIndex = 10
			Me.txtActFileName.Visible = False
			Me.btnSave.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Dim arg_FB1_0 As Control = Me.btnSave
			location = New Point(431, 494)
			arg_FB1_0.Location = location
			Me.btnSave.Name = "btnSave"
			Dim arg_FD8_0 As Control = Me.btnSave
			size = New Size(56, 23)
			arg_FD8_0.Size = size
			Me.btnSave.TabIndex = 13
			Me.btnSave.Text = "Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnDown.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.btnDown.Image = Resources.FillDown
			Dim arg_103B_0 As Control = Me.btnDown
			location = New Point(431, 399)
			arg_103B_0.Location = location
			Me.btnDown.Name = "btnDown"
			Dim arg_1062_0 As Control = Me.btnDown
			size = New Size(25, 23)
			arg_1062_0.Size = size
			Me.btnDown.TabIndex = 4
			Me.btnDown.UseVisualStyleBackColor = True
			Me.btnUp.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.btnUp.Image = Resources.FillUp
			Dim arg_10B4_0 As Control = Me.btnUp
			location = New Point(464, 399)
			arg_10B4_0.Location = location
			Me.btnUp.Name = "btnUp"
			Dim arg_10DB_0 As Control = Me.btnUp
			size = New Size(23, 23)
			arg_10DB_0.Size = size
			Me.btnUp.TabIndex = 3
			Me.btnUp.UseVisualStyleBackColor = True
			Dim arg_110D_0 As Control = Me.btnCornerTitle
			location = New Point(168, 78)
			arg_110D_0.Location = location
			Me.btnCornerTitle.Name = "btnCornerTitle"
			Dim arg_1134_0 As Control = Me.btnCornerTitle
			size = New Size(88, 23)
			arg_1134_0.Size = size
			Me.btnCornerTitle.TabIndex = 13
			Me.btnCornerTitle.Text = "Tiêu " & ChrW(273) & ChrW(7873) & " góc"
			Me.btnCornerTitle.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(499, 534)
			Me.ClientSize = size
			Me.Controls.Add(Me.Cancel_Button)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.btnCopy)
			Me.Controls.Add(Me.txtActFileName)
			Me.Controls.Add(Me.cboScripts)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.btnDown)
			Me.Controls.Add(Me.btnUp)
			Me.Controls.Add(Me.lstActions)
			Me.Controls.Add(Me.OK_Button)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MainMenuStrip = Me.MenuStrip1
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActions"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgActions"
			Me.GroupBox1.ResumeLayout(False)
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub RefreshCombo(pIndex As Integer)
			Me.cboScripts.DataSource = Nothing
			Me.cboScripts.DataSource = Me.mymnu.scripts
			If pIndex < Me.cboScripts.Items.Count Then
				Me.cboScripts.SelectedIndex = pIndex
			End If
		End Sub

		Private Sub RefreshList(pIndex As Integer)
			Me.bRefresh = False
			Me.lstActions.DataSource = Nothing
			Me.lstActions.DataSource = Me.actions
			If pIndex < Me.lstActions.Items.Count Then
				Me.lstActions.SelectedIndex = pIndex
			End If
			Me.bRefresh = True
			myModule.fMain.myVeActs.OnActDefEdit(Me.actions)
		End Sub

		Private Function GetNewActID() As Integer
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CActDef).Enumerator = Me.actions.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CActDef = enumerator.Current
					Dim num2 As Integer = CInt(Math.Round(Conversion.Val(current.Name)))
					If num2 > num Then
						num = num2
					End If
				End While
			Finally
				Dim enumerator As List(Of CActDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Return num + 1
		End Function

		Public Sub AddAction(pAction As CActDef)
			Dim selectedIndex As Integer = Me.lstActions.SelectedIndex
			' The following expression was wrapped in a checked-statement
			If selectedIndex >= 0 Then
				Me.actions.Insert(selectedIndex + 1, pAction)
			Else
				Me.actions.Add(pAction)
			End If
			Me.RefreshList(selectedIndex + 1)
		End Sub

		Public Sub UpdateAction()
			Me.RefreshList(Me.CurrIndex)
		End Sub

		Public Function IsNameOK(pName As String) As Boolean
			Dim result As Boolean = True
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			If pName.Length > 0 Then
				Try
					Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
					While enumerator.MoveNext()
						Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
						If Operators.CompareString(cSymbol.Description, pName, False) = 0 Then
							num += 1
							If num > 1 Then
								Exit While
							End If
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				If num > 1 Then
					result = False
				End If
			Else
				result = False
			End If
			Return result
		End Function

		Public Function GetUniqObjName(pName As String) As String
			Dim num As Integer = pName.IndexOf("(")
			Dim text As String
			If num >= 0 Then
				text = pName.Substring(0, num)
			Else
				text = pName
			End If
			Dim num2 As Integer = 0
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					If cSymbol.Description.IndexOf(text) = 0 Then
						num = cSymbol.Description.IndexOf("(")
						Dim num3 As Integer = cSymbol.Description.IndexOf(")")
						If num3 > num + 1 Then
							Dim num4 As Integer = CInt(Math.Round(Conversion.Val(cSymbol.Description.Substring(num + 1, num3 - num - 1))))
							If num4 > num2 Then
								num2 = num4
							End If
						End If
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return text + "(" + (num2 + 1).ToString() + ")"
		End Function

		Public Sub UpdateScript(pActFileName As String)
			Try
				CActDefs.WriteActionDef(Me.actions, pActFileName)
			Catch expr_0E As Exception
				ProjectData.SetProjectError(expr_0E)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub ExportSounds(pFileName As String, pActions As List(Of CActDef))
			Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			Dim image As Bitmap = New Bitmap(modSaBan.myTextureFile)
			Dim graphics As Graphics = Graphics.FromImage(image)
			Using Dim streamWriter As StreamWriter = New StreamWriter(pFileName)
				streamWriter.WriteLine("<Sounds>")
				Try
					Dim enumerator As List(Of CActDef).Enumerator = pActions.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As CActDef = enumerator.Current
						Try
							Dim soundName As String = current.SoundName
							If soundName.Length > 0 Then
								If soundName.IndexOf(modSaBan.myCurrentDirectory) > -1 Then
									Dim text As String = soundName.Replace(modSaBan.myCurrentDirectory, ".")
									dictionary.Add(soundName, text)
									streamWriter.WriteLine("<Sound File=""" + text + """ />")
								Else If soundName.IndexOf("\") > -1 Then
									dictionary.Add(soundName, soundName)
									streamWriter.WriteLine("<Sound File=""" + soundName + """ />")
								Else
									dictionary.Add(soundName, modSaBan.mySoundsPath + "\" + soundName)
									streamWriter.WriteLine(String.Concat(New String() { "<Sound File=""", modSaBan.mySoundsPath, "\", soundName, """ />" }))
								End If
							End If
						Catch expr_12A As Exception
							ProjectData.SetProjectError(expr_12A)
							ProjectData.ClearProjectError()
						End Try
					End While
				Finally
					Dim enumerator As List(Of CActDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
				streamWriter.WriteLine("</Sounds>")
				streamWriter.Close()
			End Using
		End Sub

		Private Sub ExportObjs()
			Dim list As List(Of CActDef) = New List(Of CActDef)()
			Try
				Dim enumerator As IEnumerator = Me.cboScripts.Items.GetEnumerator()
				While enumerator.MoveNext()
					Dim cScript As CScript = CType(enumerator.Current, CScript)
					Me.actions = CActDefs.ReadActionDef(cScript.ScrptFile)
					Try
						Dim enumerator2 As List(Of CActDef).Enumerator = Me.actions.GetEnumerator()
						While enumerator2.MoveNext()
							Dim current As CActDef = enumerator2.Current
							list.Add(current)
						End While
					Finally
						Dim enumerator2 As List(Of CActDef).Enumerator
						(CType(enumerator2, IDisposable)).Dispose()
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.ExportSounds(modSaBan.mySaBanDir + "\D3DSounds.xml", list)
			myModule.fMain.myTerrain.ExportCacDT(list)
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir) AndAlso Me.bDirty Then
				Me.UpdateScript(Me.txtActFileName.Text)
				Me.ExportObjs()
			End If
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgActions_FormClosing(sender As Object, e As FormClosingEventArgs)
			modSaBan.DienTap2File(modSaBan.myLastSaBan)
			myModule.fMain.myBando.RefreshMap()
			modSaBan.fActions = Nothing
		End Sub

		Private Sub dlgActions_Load(sender As Object, e As EventArgs)
		End Sub

		Private Sub LoadKichBan(pMenuFileName As String)
			Me.bMenuLoaded = False
			Me.mymnu = New CMnu(Nothing)
			Try
				If MyProject.Computer.FileSystem.FileExists(pMenuFileName) Then
					Me.mymnu.LoadScripts(pMenuFileName)
				End If
				Me.bMenuLoaded = True
				Me.RefreshCombo(0)
			Catch expr_41 As Exception
				ProjectData.SetProjectError(expr_41)
				Interaction.MsgBox("LoadKichBan truc trac " + pMenuFileName, MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Public Sub Show(pFileName As String, pform As Form)
			Me.MenuFileName = pFileName
			Me.Parentf = CType(pform, frmMain)
			modSaBan.fActions = Me
			Me.Text = "Các K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			' The following expression was wrapped in a checked-expression
			myModule.fMain.myVeActs.dlx = (modSaBan.myMap2X - modSaBan.myMap1X) / CDec((modSaBan.myGRID_WIDTH - 1))
			' The following expression was wrapped in a checked-expression
			myModule.fMain.myVeActs.dly = (modSaBan.myMap1Y - modSaBan.myMap2Y) / CDec((modSaBan.myGRID_HEIGHT - 1))
			Me.LoadKichBan(Me.MenuFileName)
			Me.Show(Me.Parentf)
		End Sub

		Private Sub btnDown_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lstActions.SelectedIndex
			' The following expression was wrapped in a checked-statement
			If selectedIndex < Me.actions.Count - 1 Then
				Dim item As CActDef = Me.actions(selectedIndex)
				Me.actions.Remove(item)
				Me.actions.Insert(selectedIndex + 1, item)
			End If
			Me.RefreshList(selectedIndex + 1)
			Me.bDirty = True
		End Sub

		Private Sub btnUp_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lstActions.SelectedIndex
			' The following expression was wrapped in a checked-statement
			If selectedIndex > 0 Then
				Dim item As CActDef = Me.actions(selectedIndex)
				Me.actions.Remove(item)
				Me.actions.Insert(selectedIndex - 1, item)
			End If
			Me.RefreshList(selectedIndex - 1)
			Me.bDirty = True
		End Sub

		Private Sub lstActions_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.bRefresh And Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstActions.SelectedItem)) Then
				Dim pActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				myModule.fMain.myVeActs.OnSeleActDef(pActDef)
			End If
		End Sub

		Private Sub lstActions_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstActions.SelectedItem)) Then
				Me.lstActions.SelectionMode = SelectionMode.One
				Me.lstActions_SelectedIndexChanged(Nothing, Nothing)
			End If
		End Sub

		Private Sub lstActions_KeyUp(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Delete Then
				Dim selectedIndex As Integer = Me.lstActions.SelectedIndex
				If selectedIndex >= 0 Then
					Dim item As CActDef = Me.actions(selectedIndex)
					Me.actions.Remove(item)
				End If
				Me.RefreshList(selectedIndex)
				Me.bDirty = True
			End If
		End Sub

		Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n files (*.scrpt)|*.scrpt|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			openFileDialog.RestoreDirectory = True
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = openFileDialog.FileName
				If fileName.Length > 0 Then
					Try
						Me.actions = CActDefs.ReadActionDef(fileName)
						Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n (" + fileName + ")"
						Me.RefreshList(0)
						Me.bDirty = True
					Catch expr_6A As Exception
						ProjectData.SetProjectError(expr_6A)
						ProjectData.ClearProjectError()
					End Try
				End If
			End If
		End Sub

		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n files (*.scrpt)|*.scrpt|All files (*.*)|*.*"
			saveFileDialog.FilterIndex = 1
			saveFileDialog.RestoreDirectory = True
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = saveFileDialog.FileName
				If fileName.Length > 0 Then
					CActDefs.WriteActionDef(Me.actions, fileName)
					Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n (" + fileName + ")"
				End If
			End If
		End Sub

		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Try
				Me.actions = New List(Of CActDef)()
				Me.RefreshList(0)
				Me.bDirty = True
			Catch expr_26 As Exception
				ProjectData.SetProjectError(expr_26)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub lstActions_DoubleClick(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstActions.SelectedItem)) Then
				Me.CurrIndex = Me.lstActions.SelectedIndex
				Dim oAction As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				Me.onActEdit(oAction)
			End If
		End Sub

		Public Sub onActEdit(oAction As CActDef)
			Dim actionType As String = oAction.ActionType
			If Operators.CompareString(actionType, "Fly", False) = 0 Then
				New dlgActFly() With { .TopMost = True }.Show(Me, oAction, "Update")
			Else If Operators.CompareString(actionType, "Move", False) = 0 Then
				New dlgActFly() With { .TopMost = True }.Show(Me, oAction, "Update")
			Else
				If Operators.CompareString(actionType, "Appear", False) <> 0 AndAlso Operators.CompareString(actionType, "AppearLeft", False) <> 0 Then
					If Operators.CompareString(actionType, "AppearUp", False) <> 0 Then
						If Operators.CompareString(actionType, "AppearDown", False) <> 0 Then
							If Operators.CompareString(actionType, "AppearA", False) <> 0 Then
								If Operators.CompareString(actionType, "Unhide", False) = 0 Then
									New dlgActAppear() With { .TopMost = True, .txtObjType = { .Text = "NonTexObj" } }.Show(Me, oAction, "Update")
									Return
								End If
								If Operators.CompareString(actionType, "Disappear", False) <> 0 AndAlso Operators.CompareString(actionType, "DisappearLeft", False) <> 0 Then
									If Operators.CompareString(actionType, "DisappearUp", False) <> 0 Then
										If Operators.CompareString(actionType, "DisappearDown", False) <> 0 Then
											If Operators.CompareString(actionType, "DisappearA", False) <> 0 Then
												If Operators.CompareString(actionType, "Hide", False) = 0 Then
													New dlgActDisappear() With { .TopMost = True, .txtObjType = { .Text = "NonTexObj" } }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "SpinTo", False) = 0 Then
													New dlgActSpin() With { .TopMost = True, .txtObjType = { .Text = "Model" } }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "Blink", False) = 0 Then
													New dlgActBlink() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "Shoot", False) = 0 Then
													New dlgActShoot() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "Bombard", False) = 0 Then
													New dlgActBombard() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "Explode", False) = 0 Then
													New dlgActExplode() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "ExplodeDcl", False) = 0 Then
													New dlgActExplodeDecl() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "Comment", False) = 0 Then
													New dlgActComment() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "FocusAt", False) = 0 Then
													Dim cFocusAtDef As CFocusAtDef = CType(oAction, CFocusAtDef)
													cFocusAtDef.cameraPos = myModule.fMain.myTerrain.cameraPos
													cFocusAtDef.angleZ = myModule.fMain.myTerrain.GetAngleZ()
													cFocusAtDef.angleX = myModule.fMain.myTerrain.GetAngleX()
													New dlgActFocusAt() With { .TopMost = True }.Show(Me, cFocusAtDef, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "Description", False) = 0 Then
													New dlgActDescription() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												If Operators.CompareString(actionType, "CornerTitle", False) = 0 Then
													New dlgActCornerTitle() With { .TopMost = True }.Show(Me, oAction, "Update")
													Return
												End If
												Interaction.MsgBox(oAction.GetActionStr(), MsgBoxStyle.OkOnly, Nothing)
												Return
											End If
										End If
									End If
								End If
								New dlgActDisappear() With { .TopMost = True }.Show(Me, oAction, "Update")
								Return
							End If
						End If
					End If
				End If
				New dlgActAppear() With { .TopMost = True }.Show(Me, oAction, "Update")
			End If
		End Sub

		Private Sub cboMenuItem_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.bMenuLoaded AndAlso Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.cboScripts.SelectedItem)) Then
				If Me.bDirty Then
					Me.UpdateScript(Me.txtActFileName.Text)
				End If
				Dim cScript As CScript = CType(Me.cboScripts.SelectedItem, CScript)
				Me.actions = CActDefs.ReadActionDef(cScript.ScrptFile)
				Me.txtActFileName.Text = cScript.ScrptFile
				Me.RefreshList(0)
			End If
		End Sub

		Private Sub NewSaBanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgNewSaBan As dlgNewSaBan = New dlgNewSaBan()
			If dlgNewSaBan.ShowDialog(Me) = DialogResult.OK Then
				Me.MenuFileName = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
				Me.LoadKichBan(Me.MenuFileName)
				Me.bDirty = True
			End If
		End Sub

		Private Sub OpenSaBanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If New dlgNewSaBan() With { .txtMode = { .Text = "Open" } }.ShowDialog(Me) = DialogResult.OK Then
				Me.MenuFileName = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
				Me.LoadKichBan(Me.MenuFileName)
				Me.bDirty = False
			End If
		End Sub

		Private Sub UpdateMenuToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgMenuEdit As dlgMenuEdit = New dlgMenuEdit()
			If dlgMenuEdit.ShowDialog(Me) = DialogResult.OK Then
				Me.MenuFileName = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
				Me.LoadKichBan(Me.MenuFileName)
			End If
		End Sub

		Private Sub btnCopy_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lstActions.SelectedIndex
			Dim cActDef As CActDef = Me.actions(selectedIndex).Clone()
			If Operators.CompareString(cActDef.ActionType, "Comment", False) <> 0 Then
				cActDef.Name = Me.GetNewActID().ToString()
			End If
			' The following expression was wrapped in a checked-statement
			Me.actions.Insert(selectedIndex + 1, cActDef)
			Me.RefreshList(selectedIndex + 1)
			Me.bDirty = True
		End Sub

		Private Sub btnWipe_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CAppearDef("Appear", pName, "", cActDef.start, Conversions.ToString(1.5), 30, 1F, False, "", False, 1)
			Else
				pAction = New CAppearDef("Appear", pName, "", "0", Conversions.ToString(1.5), 30, 1F, False, "", False, 1)
			End If
			New dlgActAppear() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnDisappear_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CAppearDef("Disappear", pName, "", cActDef.start, Conversions.ToString(1.5), 30, 1F, False, "", False, 1)
			Else
				pAction = New CAppearDef("Disappear", pName, "", "0", Conversions.ToString(1.5), 30, 1F, False, "", False, 1)
			End If
			New dlgActDisappear() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnFly_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CMoveObjDef("Fly", pName, "", cActDef.start, Conversions.ToString(5), True, New List(Of Vector3)(), "b17-01.wav", True)
			Else
				pAction = New CMoveObjDef("Fly", pName, "", "0", Conversions.ToString(5), True, New List(Of Vector3)(), "b17-01.wav", True)
			End If
			New dlgActFly() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnRun_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CMoveObjDef("Move", pName, "", cActDef.start, Conversions.ToString(10), True, New List(Of Vector3)(), "xetang.wav", True)
			Else
				pAction = New CMoveObjDef("Move", pName, "", "0", Conversions.ToString(10), True, New List(Of Vector3)(), "xetang.wav", True)
			End If
			New dlgActFly() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnBlink_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CBlinkDef("Blink", pName, "", cActDef.start, Conversions.ToString(2), 6F, "", False)
			Else
				pAction = New CBlinkDef("Blink", pName, "", "0", Conversions.ToString(2), 6F, "", False)
			End If
			New dlgActBlink() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnShoot_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				Dim arg_91_0 As String = "Shoot"
				Dim arg_91_1 As String = text
				Dim arg_91_2 As String = "dan2.bmp"
				Dim arg_91_3 As Single = 1.5F
				Dim arg_91_4 As Single = 1F
				Dim arg_91_5 As String = cActDef.start
				Dim arg_91_6 As String = Conversions.ToString(5)
				Dim arg_91_7 As Single = 0.4F
				Dim vector As Vector3 = New Vector3(0F, 0F, 0F)
				Dim arg_91_8 As Vector3 = vector
				Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CShootFromDef(arg_91_0, arg_91_1, arg_91_2, arg_91_3, arg_91_4, arg_91_5, arg_91_6, arg_91_7, arg_91_8, vector2, "gun_shotgun1.wav", True, "", 1)
			Else
				Dim arg_FA_0 As String = "Shoot"
				Dim arg_FA_1 As String = text
				Dim arg_FA_2 As String = "dan2.bmp"
				Dim arg_FA_3 As Single = 1.5F
				Dim arg_FA_4 As Single = 1F
				Dim arg_FA_5 As String = "0"
				Dim arg_FA_6 As String = Conversions.ToString(5)
				Dim arg_FA_7 As Single = 0.4F
				Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
				Dim arg_FA_8 As Vector3 = vector2
				Dim vector As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CShootFromDef(arg_FA_0, arg_FA_1, arg_FA_2, arg_FA_3, arg_FA_4, arg_FA_5, arg_FA_6, arg_FA_7, arg_FA_8, vector, "gun_shotgun1.wav", True, "", 1)
			End If
			New dlgActShoot() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnBombard_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				Dim arg_99_0 As String = "Bombard"
				Dim arg_99_1 As String = text
				Dim arg_99_2 As String = "rocket2.png"
				Dim arg_99_3 As Single = 2F
				Dim arg_99_4 As Single = 2F
				Dim arg_99_5 As String = cActDef.start
				Dim arg_99_6 As String = Conversions.ToString(5)
				Dim arg_99_7 As Single = 1F
				Dim arg_99_8 As Single = -45F
				Dim vector As Vector3 = New Vector3(0F, 0F, 0F)
				Dim arg_99_9 As Vector3 = vector
				Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CBombardFromDef(arg_99_0, arg_99_1, arg_99_2, arg_99_3, arg_99_4, arg_99_5, arg_99_6, arg_99_7, arg_99_8, arg_99_9, vector2, "gun_shotgun1.wav", True, "", 1)
			Else
				Dim arg_107_0 As String = "Bombard"
				Dim arg_107_1 As String = text
				Dim arg_107_2 As String = "rocket2.png"
				Dim arg_107_3 As Single = 2F
				Dim arg_107_4 As Single = 2F
				Dim arg_107_5 As String = "0"
				Dim arg_107_6 As String = Conversions.ToString(5)
				Dim arg_107_7 As Single = 1F
				Dim arg_107_8 As Single = -45F
				Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
				Dim arg_107_9 As Vector3 = vector2
				Dim vector As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CBombardFromDef(arg_107_0, arg_107_1, arg_107_2, arg_107_3, arg_107_4, arg_107_5, arg_107_6, arg_107_7, arg_107_8, arg_107_9, vector, "gun_shotgun1.wav", True, "", 1)
			End If
			New dlgActBombard() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnExplode_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				Dim arg_78_0 As String = "Explode"
				Dim arg_78_1 As String = text
				Dim arg_78_2 As String = "explosion1.bmp"
				Dim arg_78_3 As Single = 3F
				Dim arg_78_4 As Single = 3F
				Dim arg_78_5 As Single = 0F
				Dim arg_78_6 As String = cActDef.start
				Dim arg_78_7 As String = Conversions.ToString(1)
				Dim arg_78_8 As Single = 60F
				Dim pFromPos As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CExplodeObjDef(arg_78_0, arg_78_1, arg_78_2, arg_78_3, arg_78_4, arg_78_5, arg_78_6, arg_78_7, arg_78_8, pFromPos, "explosion.wav", False)
			Else
				Dim arg_C8_0 As String = "Explode"
				Dim arg_C8_1 As String = text
				Dim arg_C8_2 As String = "explosion1.bmp"
				Dim arg_C8_3 As Single = 3F
				Dim arg_C8_4 As Single = 3F
				Dim arg_C8_5 As Single = 0F
				Dim arg_C8_6 As String = "0"
				Dim arg_C8_7 As String = Conversions.ToString(1)
				Dim arg_C8_8 As Single = 60F
				Dim pFromPos As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CExplodeObjDef(arg_C8_0, arg_C8_1, arg_C8_2, arg_C8_3, arg_C8_4, arg_C8_5, arg_C8_6, arg_C8_7, arg_C8_8, pFromPos, "explosion.wav", False)
			End If
			New dlgActExplode() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnComment_Click(sender As Object, e As EventArgs)
			Dim pAction As CActDef = New CCommentDef("Ghi chú")
			New dlgActComment() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Function GetSymbolByName(Name As String) As CSymbol
			Dim result As CSymbol = Nothing
			Try
				Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
				While enumerator.MoveNext()
					Dim cSymbol As CSymbol = CType(enumerator.Current, CSymbol)
					If Operators.CompareString(cSymbol.Description, Name, False) = 0 Then
						result = cSymbol
						Exit While
					End If
				End While
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Return result
		End Function

		Private Sub btnExplodeDecl_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef = New CExplodeDclDef("ExplodeDcl", pName, "explosion1.bmp", 2F, 2F, 0F, Conversions.ToString(0.2), 80F, "explosion.wav", False)
			New dlgActExplodeDecl() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			If MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir) Then
				Me.UpdateScript(Me.txtActFileName.Text)
			End If
		End Sub

		Private Sub btnSpin_Click(sender As Object, e As EventArgs)
			Dim text As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				Dim arg_64_0 As String = "SpinTo"
				Dim arg_64_1 As String = text
				Dim arg_64_2 As String = ""
				Dim arg_64_3 As String = cActDef.start
				Dim arg_64_4 As String = Conversions.ToString(1)
				Dim pTo As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CSpinToDef(arg_64_0, arg_64_1, arg_64_2, arg_64_3, arg_64_4, pTo, "", False)
			Else
				Dim arg_A0_0 As String = "SpinTo"
				Dim arg_A0_1 As String = text
				Dim arg_A0_2 As String = ""
				Dim arg_A0_3 As String = "0"
				Dim arg_A0_4 As String = Conversions.ToString(1)
				Dim pTo As Vector3 = New Vector3(0F, 0F, 0F)
				pAction = New CSpinToDef(arg_A0_0, arg_A0_1, arg_A0_2, arg_A0_3, arg_A0_4, pTo, "", False)
			End If
			New dlgActSpin() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub ListActsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			modSaBan.LoadDienTap(modSaBan.myLastSaBan)
			New dlgActDef2s() With { .TopMost = True }.Show(modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName, myModule.fMain)
		End Sub

		Private Sub RebuildToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If MyProject.Computer.FileSystem.DirectoryExists(modSaBan.mySaBanDir) Then
				Try
					Me.UpdateScript(Me.txtActFileName.Text)
				Catch expr_29 As Exception
					ProjectData.SetProjectError(expr_29)
					ProjectData.ClearProjectError()
				End Try
				Me.ExportObjs()
				Me.bDirty = False
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		Private Sub btnFocusAt_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CFocusAtDef("FocusAt", pName, cActDef.start, "0", 0.5F, 0.5F, myModule.fMain.myTerrain.cameraPos, myModule.fMain.myTerrain.GetAngleZ(), myModule.fMain.myTerrain.GetAngleX())
			Else
				pAction = New CFocusAtDef("FocusAt", pName, "0", "0", 0.5F, 0.5F, myModule.fMain.myTerrain.cameraPos, myModule.fMain.myTerrain.GetAngleZ(), myModule.fMain.myTerrain.GetAngleX())
			End If
			New dlgActFocusAt() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub btnDescription_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CDescriptionDef("Description", pName, cActDef.start, Conversions.ToString(0), "", DescPos.Duoi, False, "", False)
			Else
				pAction = New CDescriptionDef("Description", pName, "0", Conversions.ToString(0), "", DescPos.Duoi, False, "", False)
			End If
			New dlgActDescription() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub

		Private Sub MenuFontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgMenuRepos As dlgMenuRepos = New dlgMenuRepos()
			dlgMenuRepos.ShowDialog(Me)
		End Sub

		Private Sub TitleFontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgMenuFont As dlgMenuFont = New dlgMenuFont()
			dlgMenuFont.Text = "Tiêu " & ChrW(273) & ChrW(7873) & " text, font"
			dlgMenuFont.txtLabel.Font = New Font(modSaBan.TitleFontName, modSaBan.TitleFontSize, modSaBan.TitleFontStyle, GraphicsUnit.Point)
			dlgMenuFont.txtLabel.ForeColor = modSaBan.TitleColor
			dlgMenuFont.txtLabel.BackColor = modSaBan.BGrColor
			dlgMenuFont.txtLabel.Text = modSaBan.TitleText
			If dlgMenuFont.ShowDialog(Me) = DialogResult.OK Then
				modSaBan.TitleFontName = dlgMenuFont.txtLabel.Font.Name
				modSaBan.TitleFontSize = dlgMenuFont.txtLabel.Font.Size
				modSaBan.TitleFontStyle = dlgMenuFont.txtLabel.Font.Style
				modSaBan.TitleColor = dlgMenuFont.txtLabel.ForeColor
				modSaBan.TitleText = dlgMenuFont.txtLabel.Text
			End If
		End Sub

		Private Sub DescFontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgMenuFont As dlgMenuFont = New dlgMenuFont()
			dlgMenuFont.Text = "font cho Thuy" & ChrW(7871) & "t minh d" & ChrW(432) & ChrW(7899) & "i"
			dlgMenuFont.txtLabel.Font = New Font(modSaBan.DescFontName, modSaBan.DescFontSize, modSaBan.DescFontStyle, GraphicsUnit.Point)
			dlgMenuFont.txtLabel.ForeColor = modSaBan.DescColor
			dlgMenuFont.txtLabel.BackColor = modSaBan.clrColor
			dlgMenuFont.txtLabel.Text = "Thuy" & ChrW(7871) & "t minh, L" & ChrW(7901) & "i bình"
			If dlgMenuFont.ShowDialog(Me) = DialogResult.OK Then
				modSaBan.DescFontName = dlgMenuFont.txtLabel.Font.Name
				modSaBan.DescFontSize = dlgMenuFont.txtLabel.Font.Size
				modSaBan.DescFontStyle = dlgMenuFont.txtLabel.Font.Style
				modSaBan.DescColor = dlgMenuFont.txtLabel.ForeColor
			End If
		End Sub

		Private Sub DescTrenFontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgMenuFont As dlgMenuFont = New dlgMenuFont()
			dlgMenuFont.Text = "font cho Thuy" & ChrW(7871) & "t minh trên"
			dlgMenuFont.txtLabel.Font = New Font(modSaBan.DescTrenFontName, modSaBan.DescTrenFontSize, modSaBan.DescTrenFontStyle, GraphicsUnit.Point)
			dlgMenuFont.txtLabel.ForeColor = modSaBan.DescTrenColor
			dlgMenuFont.txtLabel.BackColor = modSaBan.BGrColor
			dlgMenuFont.txtLabel.Text = "Thuy" & ChrW(7871) & "t minh, L" & ChrW(7901) & "i bình"
			If dlgMenuFont.ShowDialog(Me) = DialogResult.OK Then
				modSaBan.DescTrenFontName = dlgMenuFont.txtLabel.Font.Name
				modSaBan.DescTrenFontSize = dlgMenuFont.txtLabel.Font.Size
				modSaBan.DescTrenFontStyle = dlgMenuFont.txtLabel.Font.Style
				modSaBan.DescTrenColor = dlgMenuFont.txtLabel.ForeColor
			End If
		End Sub

		Private Sub DescGiuaFontToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim dlgMenuFont As dlgMenuFont = New dlgMenuFont()
			dlgMenuFont.Text = "font cho Thuy" & ChrW(7871) & "t minh gi" & ChrW(7919) & "a"
			dlgMenuFont.txtLabel.Font = New Font(modSaBan.DescGiuaFontName, modSaBan.DescGiuaFontSize, modSaBan.DescGiuaFontStyle, GraphicsUnit.Point)
			dlgMenuFont.txtLabel.ForeColor = modSaBan.DescGiuaColor
			dlgMenuFont.txtLabel.BackColor = modSaBan.BGrColor
			dlgMenuFont.txtLabel.Text = "Thuy" & ChrW(7871) & "t minh, L" & ChrW(7901) & "i bình"
			If dlgMenuFont.ShowDialog(Me) = DialogResult.OK Then
				modSaBan.DescGiuaFontName = dlgMenuFont.txtLabel.Font.Name
				modSaBan.DescGiuaFontSize = dlgMenuFont.txtLabel.Font.Size
				modSaBan.DescGiuaFontStyle = dlgMenuFont.txtLabel.Font.Style
				modSaBan.DescGiuaColor = dlgMenuFont.txtLabel.ForeColor
			End If
		End Sub

		Private Sub btnCornerTitle_Click(sender As Object, e As EventArgs)
			Dim pName As String = Me.GetNewActID().ToString()
			Dim pAction As CActDef
			If Me.lstActions.SelectedIndex > -1 Then
				Dim cActDef As CActDef = CType(Me.lstActions.SelectedItem, CActDef)
				pAction = New CCornerTitleDef("CornerTitle", pName, cActDef.start, Conversions.ToString(0), "")
			Else
				pAction = New CCornerTitleDef("CornerTitle", pName, "0", Conversions.ToString(0), "")
			End If
			New dlgActCornerTitle() With { .TopMost = True }.Show(Me, pAction, "Add")
		End Sub
	End Class
End Namespace
