Imports BdTC.My
Imports BdTC.My.Resources
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
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgActions
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		<AccessedThroughProperty("btnWipe")>
		Private _btnWipe As Button

		<AccessedThroughProperty("btnHide")>
		Private _btnHide As Button

		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("OpenToolStripMenuItem")>
		Private _OpenToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("NewToolStripMenuItem")>
		Private _NewToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripSeparator

		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripSeparator

		<AccessedThroughProperty("cboMenuItem")>
		Private _cboMenuItem As ComboBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("SaBanToolStripMenuItem")>
		Private _SaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("NewSaBanToolStripMenuItem")>
		Private _NewSaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripSeparator

		<AccessedThroughProperty("OpenSaBanToolStripMenuItem")>
		Private _OpenSaBanToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripMenuItem4")>
		Private _ToolStripMenuItem4 As ToolStripSeparator

		<AccessedThroughProperty("UpdateMenuToolStripMenuItem")>
		Private _UpdateMenuToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("txtActFileName")>
		Private _txtActFileName As TextBox

		<AccessedThroughProperty("btnRebuild")>
		Private _btnRebuild As Button

		Private MenuFileName As String

		Private ActItems As List(Of CActMenuItem)

		Private Parentf As frmMain

		Private actions As List(Of CActionDef)

		Private CurrIndex As Integer

		Private bDirty As Boolean

		Private bMenuLoaded As Boolean

		Friend Overridable Property Cancel_Button() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cancel_Button
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._Cancel_Button IsNot Nothing
				If flag Then
					RemoveHandler Me._Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
				End If
				Me._Cancel_Button = value
				flag = (Me._Cancel_Button IsNot Nothing)
				If flag Then
					AddHandler Me._Cancel_Button.Click, AddressOf Me.Cancel_Button_Click
				End If
			End Set
		End Property

		Friend Overridable Property OK_Button() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._OK_Button
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._OK_Button IsNot Nothing
				If flag Then
					RemoveHandler Me._OK_Button.Click, AddressOf Me.OK_Button_Click
				End If
				Me._OK_Button = value
				flag = (Me._OK_Button IsNot Nothing)
				If flag Then
					AddHandler Me._OK_Button.Click, AddressOf Me.OK_Button_Click
				End If
			End Set
		End Property

		Friend Overridable Property lstActions() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstActions
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstActions IsNot Nothing
				If flag Then
					RemoveHandler Me._lstActions.KeyUp, AddressOf Me.lstActions_KeyUp
					RemoveHandler Me._lstActions.DoubleClick, AddressOf Me.lstActions_DoubleClick
				End If
				Me._lstActions = value
				flag = (Me._lstActions IsNot Nothing)
				If flag Then
					AddHandler Me._lstActions.KeyUp, AddressOf Me.lstActions_KeyUp
					AddHandler Me._lstActions.DoubleClick, AddressOf Me.lstActions_DoubleClick
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

		Friend Overridable Property GroupBox1() As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property btnShoot() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnShoot
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnShoot IsNot Nothing
				If flag Then
					RemoveHandler Me._btnShoot.Click, AddressOf Me.btnShoot_Click
				End If
				Me._btnShoot = value
				flag = (Me._btnShoot IsNot Nothing)
				If flag Then
					AddHandler Me._btnShoot.Click, AddressOf Me.btnShoot_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnExplode() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnExplode
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnExplode IsNot Nothing
				If flag Then
					RemoveHandler Me._btnExplode.Click, AddressOf Me.btnExplode_Click
				End If
				Me._btnExplode = value
				flag = (Me._btnExplode IsNot Nothing)
				If flag Then
					AddHandler Me._btnExplode.Click, AddressOf Me.btnExplode_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnRun() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnRun
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnRun IsNot Nothing
				If flag Then
					RemoveHandler Me._btnRun.Click, AddressOf Me.btnRun_Click
				End If
				Me._btnRun = value
				flag = (Me._btnRun IsNot Nothing)
				If flag Then
					AddHandler Me._btnRun.Click, AddressOf Me.btnRun_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnFly() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnFly
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnFly IsNot Nothing
				If flag Then
					RemoveHandler Me._btnFly.Click, AddressOf Me.btnFly_Click
				End If
				Me._btnFly = value
				flag = (Me._btnFly IsNot Nothing)
				If flag Then
					AddHandler Me._btnFly.Click, AddressOf Me.btnFly_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnBlink() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnBlink
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnBlink IsNot Nothing
				If flag Then
					RemoveHandler Me._btnBlink.Click, AddressOf Me.btnBlink_Click
				End If
				Me._btnBlink = value
				flag = (Me._btnBlink IsNot Nothing)
				If flag Then
					AddHandler Me._btnBlink.Click, AddressOf Me.btnBlink_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnWipe() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnWipe
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnWipe IsNot Nothing
				If flag Then
					RemoveHandler Me._btnWipe.Click, AddressOf Me.btnWipe_Click
				End If
				Me._btnWipe = value
				flag = (Me._btnWipe IsNot Nothing)
				If flag Then
					AddHandler Me._btnWipe.Click, AddressOf Me.btnWipe_Click
				End If
			End Set
		End Property

		Friend Overridable Property btnHide() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnHide
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnHide IsNot Nothing
				If flag Then
					RemoveHandler Me._btnHide.Click, AddressOf Me.btnHide_Click
				End If
				Me._btnHide = value
				flag = (Me._btnHide IsNot Nothing)
				If flag Then
					AddHandler Me._btnHide.Click, AddressOf Me.btnHide_Click
				End If
			End Set
		End Property

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

		Friend Overridable Property cboMenuItem() As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._cboMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim flag As Boolean = Me._cboMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._cboMenuItem.SelectedIndexChanged, AddressOf Me.cboMenuItem_SelectedIndexChanged
				End If
				Me._cboMenuItem = value
				flag = (Me._cboMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._cboMenuItem.SelectedIndexChanged, AddressOf Me.cboMenuItem_SelectedIndexChanged
				End If
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

		Friend Overridable Property SaBanToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaBanToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaBanToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property NewSaBanToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewSaBanToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._NewSaBanToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewSaBanToolStripMenuItem.Click, AddressOf Me.NewSaBanToolStripMenuItem_Click
				End If
				Me._NewSaBanToolStripMenuItem = value
				flag = (Me._NewSaBanToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NewSaBanToolStripMenuItem.Click, AddressOf Me.NewSaBanToolStripMenuItem_Click
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

		Friend Overridable Property OpenSaBanToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenSaBanToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._OpenSaBanToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenSaBanToolStripMenuItem.Click, AddressOf Me.OpenSaBanToolStripMenuItem_Click
				End If
				Me._OpenSaBanToolStripMenuItem = value
				flag = (Me._OpenSaBanToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._OpenSaBanToolStripMenuItem.Click, AddressOf Me.OpenSaBanToolStripMenuItem_Click
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

		Friend Overridable Property UpdateMenuToolStripMenuItem() As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UpdateMenuToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim flag As Boolean = Me._UpdateMenuToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._UpdateMenuToolStripMenuItem.Click, AddressOf Me.UpdateMenuToolStripMenuItem_Click
				End If
				Me._UpdateMenuToolStripMenuItem = value
				flag = (Me._UpdateMenuToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._UpdateMenuToolStripMenuItem.Click, AddressOf Me.UpdateMenuToolStripMenuItem_Click
				End If
			End Set
		End Property

		Friend Overridable Property txtActFileName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtActFileName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtActFileName = value
			End Set
		End Property

		Friend Overridable Property btnRebuild() As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._btnRebuild
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim flag As Boolean = Me._btnRebuild IsNot Nothing
				If flag Then
					RemoveHandler Me._btnRebuild.Click, AddressOf Me.btnRebuild_Click
				End If
				Me._btnRebuild = value
				flag = (Me._btnRebuild IsNot Nothing)
				If flag Then
					AddHandler Me._btnRebuild.Click, AddressOf Me.btnRebuild_Click
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgActions_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgActions_Load
			dlgActions.__ENCList.Add(New WeakReference(Me))
			Me.CurrIndex = 0
			Me.bDirty = False
			Me.bMenuLoaded = False
			Me.InitializeComponent()
		End Sub

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
			Me.Cancel_Button = New Button()
			Me.OK_Button = New Button()
			Me.lstActions = New ListBox()
			Me.btnDown = New Button()
			Me.btnUp = New Button()
			Me.GroupBox1 = New GroupBox()
			Me.btnShoot = New Button()
			Me.btnExplode = New Button()
			Me.btnRun = New Button()
			Me.btnFly = New Button()
			Me.btnBlink = New Button()
			Me.btnWipe = New Button()
			Me.btnHide = New Button()
			Me.MenuStrip1 = New MenuStrip()
			Me.SaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.NewSaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem3 = New ToolStripSeparator()
			Me.OpenSaBanToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem4 = New ToolStripSeparator()
			Me.UpdateMenuToolStripMenuItem = New ToolStripMenuItem()
			Me.FileToolStripMenuItem = New ToolStripMenuItem()
			Me.NewToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem1 = New ToolStripSeparator()
			Me.OpenToolStripMenuItem = New ToolStripMenuItem()
			Me.ToolStripMenuItem2 = New ToolStripSeparator()
			Me.SaveAsToolStripMenuItem = New ToolStripMenuItem()
			Me.cboMenuItem = New ComboBox()
			Me.Label1 = New Label()
			Me.Label2 = New Label()
			Me.txtActFileName = New TextBox()
			Me.btnRebuild = New Button()
			Me.GroupBox1.SuspendLayout()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.Cancel_Button.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1C5_0 As Control = Me.Cancel_Button
			Dim location As Point = New Point(420, 36)
			arg_1C5_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_1EF_0 As Control = Me.Cancel_Button
			Dim size As Size = New Size(67, 23)
			arg_1EF_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.OK_Button.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_237_0 As Control = Me.OK_Button
			location = New Point(347, 36)
			arg_237_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_261_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_261_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.lstActions.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstActions.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lstActions.FormattingEnabled = True
			Me.lstActions.ItemHeight = 14
			Dim arg_2DF_0 As Control = Me.lstActions
			location = New Point(12, 94)
			arg_2DF_0.Location = location
			Me.lstActions.Name = "lstActions"
			Dim arg_30F_0 As Control = Me.lstActions
			size = New Size(475, 284)
			arg_30F_0.Size = size
			Me.lstActions.TabIndex = 2
			Me.btnDown.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.btnDown.Image = Resources.FillDown
			Dim arg_35A_0 As Control = Me.btnDown
			location = New Point(431, 387)
			arg_35A_0.Location = location
			Me.btnDown.Name = "btnDown"
			Dim arg_384_0 As Control = Me.btnDown
			size = New Size(25, 23)
			arg_384_0.Size = size
			Me.btnDown.TabIndex = 4
			Me.btnDown.UseVisualStyleBackColor = True
			Me.btnUp.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.btnUp.Image = Resources.FillUp
			Dim arg_3DC_0 As Control = Me.btnUp
			location = New Point(464, 387)
			arg_3DC_0.Location = location
			Me.btnUp.Name = "btnUp"
			Dim arg_406_0 As Control = Me.btnUp
			size = New Size(23, 23)
			arg_406_0.Size = size
			Me.btnUp.TabIndex = 3
			Me.btnUp.UseVisualStyleBackColor = True
			Me.GroupBox1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.GroupBox1.Controls.Add(Me.btnShoot)
			Me.GroupBox1.Controls.Add(Me.btnExplode)
			Me.GroupBox1.Controls.Add(Me.btnRun)
			Me.GroupBox1.Controls.Add(Me.btnFly)
			Me.GroupBox1.Controls.Add(Me.btnBlink)
			Me.GroupBox1.Controls.Add(Me.btnWipe)
			Me.GroupBox1.Controls.Add(Me.btnHide)
			Dim arg_4EA_0 As Control = Me.GroupBox1
			location = New Point(14, 387)
			arg_4EA_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_517_0 As Control = Me.GroupBox1
			size = New Size(374, 86)
			arg_517_0.Size = size
			Me.GroupBox1.TabIndex = 5
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Thêm m" & ChrW(7899) & "i:"
			Dim arg_55E_0 As Control = Me.btnShoot
			location = New Point(259, 49)
			arg_55E_0.Location = location
			Me.btnShoot.Name = "btnShoot"
			Dim arg_588_0 As Control = Me.btnShoot
			size = New Size(75, 23)
			arg_588_0.Size = size
			Me.btnShoot.TabIndex = 6
			Me.btnShoot.Text = "B" & ChrW(7855) & "n"
			Me.btnShoot.UseVisualStyleBackColor = True
			Dim arg_5CF_0 As Control = Me.btnExplode
			location = New Point(178, 49)
			arg_5CF_0.Location = location
			Me.btnExplode.Name = "btnExplode"
			Dim arg_5F9_0 As Control = Me.btnExplode
			size = New Size(75, 23)
			arg_5F9_0.Size = size
			Me.btnExplode.TabIndex = 5
			Me.btnExplode.Text = "N" & ChrW(7893)
			Me.btnExplode.UseVisualStyleBackColor = True
			Dim arg_63D_0 As Control = Me.btnRun
			location = New Point(97, 49)
			arg_63D_0.Location = location
			Me.btnRun.Name = "btnRun"
			Dim arg_667_0 As Control = Me.btnRun
			size = New Size(75, 23)
			arg_667_0.Size = size
			Me.btnRun.TabIndex = 4
			Me.btnRun.Text = "Ch" & ChrW(7841) & "y"
			Me.btnRun.UseVisualStyleBackColor = True
			Dim arg_6AB_0 As Control = Me.btnFly
			location = New Point(16, 49)
			arg_6AB_0.Location = location
			Me.btnFly.Name = "btnFly"
			Dim arg_6D5_0 As Control = Me.btnFly
			size = New Size(75, 23)
			arg_6D5_0.Size = size
			Me.btnFly.TabIndex = 3
			Me.btnFly.Text = "Bay"
			Me.btnFly.UseVisualStyleBackColor = True
			Dim arg_71C_0 As Control = Me.btnBlink
			location = New Point(259, 20)
			arg_71C_0.Location = location
			Me.btnBlink.Name = "btnBlink"
			Dim arg_746_0 As Control = Me.btnBlink
			size = New Size(75, 23)
			arg_746_0.Size = size
			Me.btnBlink.TabIndex = 2
			Me.btnBlink.Text = "Nh" & ChrW(7845) & "p nháy"
			Me.btnBlink.UseVisualStyleBackColor = True
			Dim arg_78A_0 As Control = Me.btnWipe
			location = New Point(97, 20)
			arg_78A_0.Location = location
			Me.btnWipe.Name = "btnWipe"
			Dim arg_7B7_0 As Control = Me.btnWipe
			size = New Size(156, 23)
			arg_7B7_0.Size = size
			Me.btnWipe.TabIndex = 1
			Me.btnWipe.Text = "Di chuy" & ChrW(7875) & "n theo h" & ChrW(432) & ChrW(7899) & "ng"
			Me.btnWipe.UseVisualStyleBackColor = True
			Dim arg_7FB_0 As Control = Me.btnHide
			location = New Point(16, 20)
			arg_7FB_0.Location = location
			Me.btnHide.Name = "btnHide"
			Dim arg_825_0 As Control = Me.btnHide
			size = New Size(75, 23)
			arg_825_0.Size = size
			Me.btnHide.TabIndex = 0
			Me.btnHide.Text = ChrW(7848) & "n"
			Me.btnHide.UseVisualStyleBackColor = True
			Me.MenuStrip1.Items.AddRange(New ToolStripItem() { Me.SaBanToolStripMenuItem, Me.FileToolStripMenuItem })
			Dim arg_894_0 As Control = Me.MenuStrip1
			location = New Point(0, 0)
			arg_894_0.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim arg_8C1_0 As Control = Me.MenuStrip1
			size = New Size(499, 24)
			arg_8C1_0.Size = size
			Me.MenuStrip1.TabIndex = 6
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.SaBanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.NewSaBanToolStripMenuItem, Me.ToolStripMenuItem3, Me.OpenSaBanToolStripMenuItem, Me.ToolStripMenuItem4, Me.UpdateMenuToolStripMenuItem })
			Me.SaBanToolStripMenuItem.Name = "SaBanToolStripMenuItem"
			Dim arg_954_0 As ToolStripItem = Me.SaBanToolStripMenuItem
			size = New Size(52, 20)
			arg_954_0.Size = size
			Me.SaBanToolStripMenuItem.Text = "Sa bàn"
			Me.NewSaBanToolStripMenuItem.Name = "NewSaBanToolStripMenuItem"
			Dim arg_992_0 As ToolStripItem = Me.NewSaBanToolStripMenuItem
			size = New Size(138, 22)
			arg_992_0.Size = size
			Me.NewSaBanToolStripMenuItem.Text = "Sa bàn m" & ChrW(7899) & "i"
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Dim arg_9CF_0 As ToolStripItem = Me.ToolStripMenuItem3
			size = New Size(135, 6)
			arg_9CF_0.Size = size
			Me.OpenSaBanToolStripMenuItem.Name = "OpenSaBanToolStripMenuItem"
			Dim arg_9FC_0 As ToolStripItem = Me.OpenSaBanToolStripMenuItem
			size = New Size(138, 22)
			arg_9FC_0.Size = size
			Me.OpenSaBanToolStripMenuItem.Text = "M" & ChrW(7903) & " Sa bàn"
			Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
			Dim arg_A39_0 As ToolStripItem = Me.ToolStripMenuItem4
			size = New Size(135, 6)
			arg_A39_0.Size = size
			Me.UpdateMenuToolStripMenuItem.Name = "UpdateMenuToolStripMenuItem"
			Dim arg_A66_0 As ToolStripItem = Me.UpdateMenuToolStripMenuItem
			size = New Size(138, 22)
			arg_A66_0.Size = size
			Me.UpdateMenuToolStripMenuItem.Text = "So" & ChrW(7841) & "n Menu"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.NewToolStripMenuItem, Me.ToolStripMenuItem1, Me.OpenToolStripMenuItem, Me.ToolStripMenuItem2, Me.SaveAsToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim arg_AEC_0 As ToolStripItem = Me.FileToolStripMenuItem
			size = New Size(80, 20)
			arg_AEC_0.Size = size
			Me.FileToolStripMenuItem.Text = "Các K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
			Dim arg_B2A_0 As ToolStripItem = Me.NewToolStripMenuItem
			size = New Size(145, 22)
			arg_B2A_0.Size = size
			Me.NewToolStripMenuItem.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n m" & ChrW(7899) & "i"
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim arg_B67_0 As ToolStripItem = Me.ToolStripMenuItem1
			size = New Size(142, 6)
			arg_B67_0.Size = size
			Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
			Dim arg_B94_0 As ToolStripItem = Me.OpenToolStripMenuItem
			size = New Size(145, 22)
			arg_B94_0.Size = size
			Me.OpenToolStripMenuItem.Text = "M" & ChrW(7903) & " k" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
			Dim arg_BD1_0 As ToolStripItem = Me.ToolStripMenuItem2
			size = New Size(142, 6)
			arg_BD1_0.Size = size
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Dim arg_BFE_0 As ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Size(145, 22)
			arg_BFE_0.Size = size
			Me.SaveAsToolStripMenuItem.Text = "L" & ChrW(432) & "u k" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.cboMenuItem.FormattingEnabled = True
			Dim arg_C35_0 As Control = Me.cboMenuItem
			location = New Point(76, 36)
			arg_C35_0.Location = location
			Me.cboMenuItem.Name = "cboMenuItem"
			Dim arg_C62_0 As Control = Me.cboMenuItem
			size = New Size(201, 21)
			arg_C62_0.Size = size
			Me.cboMenuItem.TabIndex = 7
			Me.Label1.AutoSize = True
			Dim arg_C95_0 As Control = Me.Label1
			location = New Point(12, 39)
			arg_C95_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_CBF_0 As Control = Me.Label1
			size = New Size(51, 13)
			arg_CBF_0.Size = size
			Me.Label1.TabIndex = 8
			Me.Label1.Text = "Các m" & ChrW(7909) & "c:"
			Me.Label2.AutoSize = True
			Dim arg_D03_0 As Control = Me.Label2
			location = New Point(12, 78)
			arg_D03_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_D2D_0 As Control = Me.Label2
			size = New Size(51, 13)
			arg_D2D_0.Size = size
			Me.Label2.TabIndex = 9
			Me.Label2.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n:"
			Dim arg_D65_0 As Control = Me.txtActFileName
			location = New Point(76, 70)
			arg_D65_0.Location = location
			Me.txtActFileName.Name = "txtActFileName"
			Me.txtActFileName.[ReadOnly] = True
			Dim arg_D9F_0 As Control = Me.txtActFileName
			size = New Size(201, 21)
			arg_D9F_0.Size = size
			Me.txtActFileName.TabIndex = 10
			Me.btnRebuild.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_DD7_0 As Control = Me.btnRebuild
			location = New Point(347, 65)
			arg_DD7_0.Location = location
			Me.btnRebuild.Name = "btnRebuild"
			Dim arg_E01_0 As Control = Me.btnRebuild
			size = New Size(67, 23)
			arg_E01_0.Size = size
			Me.btnRebuild.TabIndex = 11
			Me.btnRebuild.Text = "Rebuild"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(499, 485)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnRebuild)
			Me.Controls.Add(Me.txtActFileName)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.cboMenuItem)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.btnDown)
			Me.Controls.Add(Me.btnUp)
			Me.Controls.Add(Me.lstActions)
			Me.Controls.Add(Me.Cancel_Button)
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
			Me.cboMenuItem.DataSource = Nothing
			Me.cboMenuItem.DataSource = Me.ActItems
			Dim flag As Boolean = pIndex < Me.cboMenuItem.Items.Count
			If flag Then
				Me.cboMenuItem.SelectedIndex = pIndex
			End If
		End Sub

		Private Sub RefreshList(pIndex As Integer)
			Me.lstActions.DataSource = Nothing
			Me.lstActions.DataSource = Me.actions
			Dim flag As Boolean = pIndex < Me.lstActions.Items.Count
			If flag Then
				Me.lstActions.SelectedIndex = pIndex
			End If
		End Sub

		Public Sub AddAction(pAction As CActionDef)
			Dim i As Integer = Me.lstActions.SelectedIndex
			Dim flag As Boolean = i >= 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Me.actions.Insert(i + 1, pAction)
			Else
				Me.actions.Add(pAction)
			End If
			Me.RefreshList(i + 1)
		End Sub

		Public Sub UpdateAction()
			Me.RefreshList(Me.CurrIndex)
		End Sub

		Public Function IsNameOK(pName As String) As Boolean
			Dim Kq As Boolean = True
			Dim mFounds As Integer = 0
			Dim flag As Boolean = pName.Length > 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim flag2 As Boolean
				Try
					Dim enumerator As IEnumerator = myModule.fMain.myBando.drawingSymbols.GetEnumerator()
					While enumerator.MoveNext()
						Dim aSB As CSymbol = CType(enumerator.Current, CSymbol)
						flag2 = (Operators.CompareString(aSB.Description, pName, False) = 0)
						If flag2 Then
							mFounds += 1
							flag2 = (mFounds > 1)
							If flag2 Then
								Exit While
							End If
						End If
					End While
				Finally
					Dim enumerator As IEnumerator
					flag2 = (TypeOf enumerator Is IDisposable)
					If flag2 Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				flag2 = (mFounds > 1)
				If flag2 Then
					Kq = False
				End If
			Else
				Kq = False
			End If
			Return Kq
		End Function

		Private Sub UpdateScript(pActFileName As String)
			Dim flag As Boolean = Me.bDirty
			If flag Then
				CActionDefs.WriteActionDef(Me.actions, pActFileName)
			End If
		End Sub

		Private Sub ExportSounds(pFileName As String, pActions As List(Of CActionDef))
			Dim SoundNames As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			Dim mTexImage As Bitmap = New Bitmap(modBanDo.myTextureFile)
			Dim g As Graphics = Graphics.FromImage(mTexImage)
			Dim sw As StreamWriter = New StreamWriter(pFileName)
			Try
				sw.WriteLine("<Sounds>")
				Try
					Dim enumerator As List(Of CActionDef).Enumerator = pActions.GetEnumerator()
					While enumerator.MoveNext()
						Dim aAction As CActionDef = enumerator.Current
						Try
							Dim mSoundName As String = aAction.SoundName
							Dim flag As Boolean = mSoundName.Length > 0
							If flag Then
								SoundNames.Add(mSoundName, "sounds\" + mSoundName)
								sw.WriteLine("<Sound File=""sounds\" + mSoundName + """ />")
							End If
						Catch expr_8C As Exception
							ProjectData.SetProjectError(expr_8C)
							ProjectData.ClearProjectError()
						End Try
					End While
				Finally
					Dim enumerator As List(Of CActionDef).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
				sw.WriteLine("</Sounds>")
				sw.Close()
			Finally
				Dim flag As Boolean = sw IsNot Nothing
				If flag Then
					(CType(sw, IDisposable)).Dispose()
				End If
			End Try
		End Sub

		Private Sub ExportObjs()
			Dim allActions As List(Of CActionDef) = New List(Of CActionDef)()
			Try
				Dim enumerator As IEnumerator = Me.cboMenuItem.Items.GetEnumerator()
				While enumerator.MoveNext()
					Dim mMenuItem As CActMenuItem = CType(enumerator.Current, CActMenuItem)
					Me.actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
					Try
						Dim enumerator2 As List(Of CActionDef).Enumerator = Me.actions.GetEnumerator()
						While enumerator2.MoveNext()
							Dim action As CActionDef = enumerator2.Current
							allActions.Add(action)
						End While
					Finally
						Dim enumerator2 As List(Of CActionDef).Enumerator
						(CType(enumerator2, IDisposable)).Dispose()
					End Try
				End While
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					(TryCast(enumerator, IDisposable)).Dispose()
				End If
			End Try
			Me.ExportSounds(modBanDo.mySaBanDir + "\D3DSounds.xml", allActions)
			Me.Parentf.ExportCacDT(allActions)
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Computer.FileSystem.DirectoryExists(modBanDo.mySaBanDir)
			If flag Then
				Dim flag2 As Boolean = Me.bDirty
				If flag2 Then
					Me.UpdateScript(Me.txtActFileName.Text)
					Me.ExportObjs()
				End If
			End If
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgActions_FormClosing(sender As Object, e As FormClosingEventArgs)
			myModule.fActions = Nothing
		End Sub

		Private Sub dlgActions_Load(sender As Object, e As EventArgs)
			myModule.fActions = Me
			Me.Text = "Các K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.LoadKichBan(Me.MenuFileName)
		End Sub

		Private Sub LoadKichBan(pMenuFileName As String)
			Dim flag As Boolean = MyProject.Computer.FileSystem.FileExists(pMenuFileName)
			If flag Then
				Me.ActItems = CActItemsDef.LoadItems(pMenuFileName)
			Else
				Me.ActItems = New List(Of CActMenuItem)()
			End If
			Me.bMenuLoaded = True
			Me.RefreshCombo(0)
		End Sub

		Public Sub Show(pFileName As String, pform As Form)
			Me.MenuFileName = pFileName
			Me.Parentf = CType(pform, frmMain)
			Me.Show(Me.ParentForm)
		End Sub

		Private Sub FlyToolStripButton_Click(sender As Object, e As EventArgs)
			New dlgFlyAction() With { .TopMost = True }.Show(Me)
		End Sub

		Private Sub btnDown_Click(sender As Object, e As EventArgs)
			Dim i As Integer = Me.lstActions.SelectedIndex
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = i < Me.actions.Count - 1
			If flag Then
				Dim oAction As CActionDef = Me.actions(i)
				Me.actions.Remove(oAction)
				Me.actions.Insert(i + 1, oAction)
			End If
			Me.RefreshList(i + 1)
			Me.bDirty = True
		End Sub

		Private Sub btnUp_Click(sender As Object, e As EventArgs)
			Dim i As Integer = Me.lstActions.SelectedIndex
			Dim flag As Boolean = i > 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Dim oAction As CActionDef = Me.actions(i)
				Me.actions.Remove(oAction)
				Me.actions.Insert(i - 1, oAction)
			End If
			Me.RefreshList(i - 1)
			Me.bDirty = True
		End Sub

		Private Sub lstActions_KeyUp(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Delete
			If flag Then
				Dim i As Integer = Me.lstActions.SelectedIndex
				flag = (i >= 0)
				If flag Then
					Dim oAction As CActionDef = Me.actions(i)
					Me.actions.Remove(oAction)
				End If
				Me.RefreshList(i)
				Me.bDirty = True
			End If
		End Sub

		Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n files (*.scrpt)|*.scrpt|All files (*.*)|*.*"
			openFileDialog.FilterIndex = 1
			openFileDialog.RestoreDirectory = True
			Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim mFileName As String = openFileDialog.FileName
				flag = (mFileName.Length > 0)
				If flag Then
					Try
						Me.actions = CActionDefs.ReadActionDef(mFileName)
						Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n (" + mFileName + ")"
						Me.RefreshList(0)
						Me.bDirty = True
					Catch expr_79 As Exception
						ProjectData.SetProjectError(expr_79)
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
			Dim flag As Boolean = saveFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim mFileName As String = saveFileDialog.FileName
				flag = (mFileName.Length > 0)
				If flag Then
					CActionDefs.WriteActionDef(Me.actions, mFileName)
					Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n (" + mFileName + ")"
				End If
			End If
		End Sub

		Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Try
				Me.actions = New List(Of CActionDef)()
				Me.RefreshList(0)
				Me.bDirty = True
			Catch expr_2A As Exception
				ProjectData.SetProjectError(expr_2A)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub lstActions_DoubleClick(sender As Object, e As EventArgs)
			Me.CurrIndex = Me.lstActions.SelectedIndex
			Dim oAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
			Dim actionType As String = oAction.ActionType
			Dim flag As Boolean = Operators.CompareString(actionType, "FlyModel", False) = 0
			If flag Then
				New dlgFlyAction() With { .TopMost = True }.Show(Me, oAction, "Update")
			Else
				flag = (Operators.CompareString(actionType, "MoveModel", False) = 0 OrElse Operators.CompareString(actionType, "MoveBillboard", False) = 0)
				If flag Then
					New dlgFlyAction() With { .TopMost = True }.Show(Me, oAction, "Update")
				Else
					flag = (Operators.CompareString(actionType, "MoveTex", False) = 0)
					If flag Then
						New dlgFlyAction() With { .TopMost = True }.Show(Me, oAction, "Update")
					Else
						Dim arg_131_0 As Boolean
						If Operators.CompareString(actionType, "Wipe", False) <> 0 AndAlso Operators.CompareString(actionType, "WipeLeft", False) <> 0 Then
							If Operators.CompareString(actionType, "WipeUp", False) <> 0 Then
								If Operators.CompareString(actionType, "WipeDown", False) <> 0 Then
									arg_131_0 = False
									GoTo IL_131
								End If
							End If
						End If
						arg_131_0 = True
						IL_131:
						flag = arg_131_0
						If flag Then
							New dlgWipeAction() With { .TopMost = True }.Show(Me, oAction, "Update")
						Else
							flag = (Operators.CompareString(actionType, "Blink", False) = 0 OrElse Operators.CompareString(actionType, "BlinkModel", False) = 0)
							If flag Then
								New dlgBlinkAction() With { .TopMost = True }.Show(Me, oAction, "Update")
							Else
								Dim arg_1E1_0 As Boolean
								If Operators.CompareString(actionType, "HideTex", False) <> 0 AndAlso Operators.CompareString(actionType, "HideModel", False) <> 0 Then
									If Operators.CompareString(actionType, "HideBillboard", False) <> 0 Then
										arg_1E1_0 = False
										GoTo IL_1E1
									End If
								End If
								arg_1E1_0 = True
								IL_1E1:
								flag = arg_1E1_0
								If flag Then
									New dlgHideAction() With { .TopMost = True }.Show(Me, oAction, "Update")
								Else
									Dim arg_254_0 As Boolean
									If Operators.CompareString(actionType, "Shoot", False) <> 0 AndAlso Operators.CompareString(actionType, "ShootFromModel", False) <> 0 Then
										If Operators.CompareString(actionType, "ShootFromTexObj", False) <> 0 Then
											If Operators.CompareString(actionType, "ShootFromBillboard", False) <> 0 Then
												arg_254_0 = False
												GoTo IL_254
											End If
										End If
									End If
									arg_254_0 = True
									IL_254:
									flag = arg_254_0
									If flag Then
										New dlgShootAction() With { .TopMost = True }.Show(Me, oAction, "Update")
									Else
										Dim arg_2B2_0 As Boolean
										If Operators.CompareString(actionType, "Explosion", False) <> 0 AndAlso Operators.CompareString(actionType, "ExplodeModel", False) <> 0 Then
											If Operators.CompareString(actionType, "ExplodeTex", False) <> 0 Then
												arg_2B2_0 = False
												GoTo IL_2B2
											End If
										End If
										arg_2B2_0 = True
										IL_2B2:
										flag = arg_2B2_0
										If flag Then
											New dlgExplodeAction() With { .TopMost = True }.Show(Me, oAction, "Update")
										Else
											Interaction.MsgBox(oAction.GetActionStr(), MsgBoxStyle.OkOnly, Nothing)
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Me.bDirty = True
		End Sub

		Private Sub btnWipe_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				oAction = New CWipeDef("Wipe", "Xu" & ChrW(7845) & "t hi" & ChrW(7879) & "n", "", mAction.startanimation, 15, 5, 1, "", False)
			Else
				oAction = New CWipeDef("Wipe", "Xu" & ChrW(7845) & "t hi" & ChrW(7879) & "n", "", "Start()", 15, 5, 1, "", False)
			End If
			New dlgWipeAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub btnBlink_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				oAction = New CBlinkDef("Blink", "Nh" & ChrW(7845) & "p nháy", "", mAction.startanimation, 15, 5, "", False)
			Else
				oAction = New CBlinkDef("Blink", "Nh" & ChrW(7845) & "p nháy", "", "Start()", 15, 5, "", False)
			End If
			New dlgBlinkAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub btnRun_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				oAction = New CMoveDef("MoveModel", "Ch" & ChrW(7841) & "y", "", mAction.startanimation, 0.08F, New List(Of Vector3)(), "", True)
			Else
				oAction = New CMoveDef("MoveModel", "Ch" & ChrW(7841) & "y", "", "Start()", 0.08F, New List(Of Vector3)(), "", True)
			End If
			New dlgFlyAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub btnFly_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				oAction = New CMoveDef("FlyModel", "Bay", "", mAction.startanimation, 0.18F, New List(Of Vector3)(), "b17-01.wav", True)
			Else
				oAction = New CMoveDef("FlyModel", "Bay", "", "Start()", 0.18F, New List(Of Vector3)(), "b17-01.wav", True)
			End If
			New dlgFlyAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub cboMenuItem_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.bMenuLoaded
			If flag Then
				Dim flag2 As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.cboMenuItem.SelectedItem))
				If flag2 Then
					Me.UpdateScript(Me.txtActFileName.Text)
					Dim mMenuItem As CActMenuItem = CType(Me.cboMenuItem.SelectedItem, CActMenuItem)
					Me.actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
					Me.txtActFileName.Text = mMenuItem.ActFileName
					Me.bDirty = False
					Me.RefreshList(0)
				End If
			End If
		End Sub

		Private Sub btnHide_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				oAction = New CHideDef("Hide", ChrW(7848) & "n", "", mAction.startanimation)
			Else
				oAction = New CHideDef("Hide", ChrW(7848) & "n", "", "0")
			End If
			New dlgHideAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub btnShoot_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				Dim arg_86_0 As String = "Shoot"
				Dim arg_86_1 As String = "B" & ChrW(7855) & "n"
				Dim arg_86_2 As String = "dan2.bmp"
				Dim arg_86_3 As Single = 1F
				Dim arg_86_4 As Single = 1.5F
				Dim arg_86_5 As String = mAction.startanimation
				Dim arg_86_6 As Integer = 400
				Dim arg_86_7 As Single = 2F
				Dim vector As Vector3 = New Vector3(0F, 0F, 0F)
				Dim arg_86_8 As Vector3 = vector
				Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
				oAction = New CShootDef(arg_86_0, arg_86_1, arg_86_2, arg_86_3, arg_86_4, arg_86_5, arg_86_6, arg_86_7, arg_86_8, vector2, "gun_shotgun1.wav", True)
			Else
				Dim arg_EE_0 As String = "Shoot"
				Dim arg_EE_1 As String = "B" & ChrW(7855) & "n"
				Dim arg_EE_2 As String = "dan2.bmp"
				Dim arg_EE_3 As Single = 1F
				Dim arg_EE_4 As Single = 1.5F
				Dim arg_EE_5 As String = "Start()"
				Dim arg_EE_6 As Integer = 400
				Dim arg_EE_7 As Single = 2F
				Dim vector2 As Vector3 = New Vector3(0F, 0F, 0F)
				Dim arg_EE_8 As Vector3 = vector2
				Dim vector As Vector3 = New Vector3(0F, 0F, 0F)
				oAction = New CShootDef(arg_EE_0, arg_EE_1, arg_EE_2, arg_EE_3, arg_EE_4, arg_EE_5, arg_EE_6, arg_EE_7, arg_EE_8, vector, "gun_shotgun1.wav", True)
			End If
			New dlgShootAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub btnExplode_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.lstActions.SelectedIndex > -1
			Dim oAction As CActionDef
			If flag Then
				Dim mAction As CActionDef = CType(Me.lstActions.SelectedItem, CActionDef)
				Dim arg_65_0 As String = "Explosion"
				Dim arg_65_1 As String = "N" & ChrW(7893)
				Dim arg_65_2 As String = mAction.startanimation
				Dim arg_65_3 As Integer = 1
				Dim arg_65_4 As Integer = 3
				Dim arg_65_5 As String = "explosion1.bmp"
				Dim arg_65_6 As Single = 3F
				Dim arg_65_7 As Single = 3F
				Dim pPos As Vector3 = New Vector3(0F, 0F, 0F)
				oAction = New CExplodeDef(arg_65_0, arg_65_1, arg_65_2, arg_65_3, arg_65_4, arg_65_5, arg_65_6, arg_65_7, pPos, "explosion.wav", True)
			Else
				Dim arg_AC_0 As String = "Explosion"
				Dim arg_AC_1 As String = "N" & ChrW(7893)
				Dim arg_AC_2 As String = "Start()"
				Dim arg_AC_3 As Integer = 1
				Dim arg_AC_4 As Integer = 3
				Dim arg_AC_5 As String = "explosion1.bmp"
				Dim arg_AC_6 As Single = 3F
				Dim arg_AC_7 As Single = 3F
				Dim pPos As Vector3 = New Vector3(0F, 0F, 0F)
				oAction = New CExplodeDef(arg_AC_0, arg_AC_1, arg_AC_2, arg_AC_3, arg_AC_4, arg_AC_5, arg_AC_6, arg_AC_7, pPos, "explosion.wav", True)
			End If
			New dlgExplodeAction() With { .TopMost = True }.Show(Me, oAction, "Add")
			Me.bDirty = True
		End Sub

		Private Sub NewSaBanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim f As dlgNewSaBan = New dlgNewSaBan()
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Me.MenuFileName = modBanDo.mySaBanDir + "\MyMenu.xml"
				Me.LoadKichBan(Me.MenuFileName)
				Me.bDirty = True
			End If
		End Sub

		Private Sub OpenSaBanToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = New dlgNewSaBan() With { .txtMode = { .Text = "Open" } }.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Me.MenuFileName = modBanDo.mySaBanDir + "\MyMenu.xml"
				Me.LoadKichBan(Me.MenuFileName)
				Me.bDirty = False
			End If
		End Sub

		Private Sub UpdateMenuToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim f As dlgEditMenu = New dlgEditMenu()
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Me.MenuFileName = modBanDo.mySaBanDir + "\MyMenu.xml"
				Me.LoadKichBan(Me.MenuFileName)
			End If
		End Sub

		Private Sub btnRebuild_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = MyProject.Computer.FileSystem.DirectoryExists(modBanDo.mySaBanDir)
			If flag Then
				Try
					Dim enumerator As IEnumerator = Me.cboMenuItem.Items.GetEnumerator()
					While enumerator.MoveNext()
						Dim mMenuItem As CActMenuItem = CType(enumerator.Current, CActMenuItem)
						Me.actions = CActionDefs.ReadActionDef(mMenuItem.ActFileName)
						CActionDefs.WriteActionDef(Me.actions, mMenuItem.ActFileName)
					End While
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				Me.ExportObjs()
				Me.bDirty = False
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub
	End Class
End Namespace
