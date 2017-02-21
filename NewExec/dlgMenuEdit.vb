Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports SaBan.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgMenuEdit
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("Splitter1")>
		Private _Splitter1 As Splitter

		<AccessedThroughProperty("lstMnuItems")>
		Private _lstMnuItems As ListBox

		<AccessedThroughProperty("btnMnuItemAdd")>
		Private _btnMnuItemAdd As Button

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		<AccessedThroughProperty("btnDown")>
		Private _btnDown As Button

		<AccessedThroughProperty("btnUp")>
		Private _btnUp As Button

		<AccessedThroughProperty("btnScriptAdd")>
		Private _btnScriptAdd As Button

		<AccessedThroughProperty("lstScripts")>
		Private _lstScripts As ListBox

		<AccessedThroughProperty("btnMnuItemReloc")>
		Private _btnMnuItemReloc As Button

		<AccessedThroughProperty("btnMnuItemDel")>
		Private _btnMnuItemDel As Button

		<AccessedThroughProperty("btnScriptDel")>
		Private _btnScriptDel As Button

		Private bLoaded As Boolean

		Private MyMnuDef As CMyMnuDef

		Private mnufile As String

		Private SeleMnuItem As CMnuItemDef

		Private CurrIndex As Integer

		Friend Overridable Property TableLayoutPanel1() As TableLayoutPanel
			Get
				Return Me._TableLayoutPanel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel1 = value
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

		Friend Overridable Property Panel1() As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
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

		Friend Overridable Property lstMnuItems() As ListBox
			Get
				Return Me._lstMnuItems
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstMnuItems_SelectedIndexChanged
				Dim value3 As EventHandler = AddressOf Me.lstMnuItems_DoubleClick
				If Me._lstMnuItems IsNot Nothing Then
					RemoveHandler Me._lstMnuItems.SelectedIndexChanged, value2
					RemoveHandler Me._lstMnuItems.DoubleClick, value3
				End If
				Me._lstMnuItems = value
				If Me._lstMnuItems IsNot Nothing Then
					AddHandler Me._lstMnuItems.SelectedIndexChanged, value2
					AddHandler Me._lstMnuItems.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property btnMnuItemAdd() As Button
			Get
				Return Me._btnMnuItemAdd
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnMnuItemAdd_Click
				If Me._btnMnuItemAdd IsNot Nothing Then
					RemoveHandler Me._btnMnuItemAdd.Click, value2
				End If
				Me._btnMnuItemAdd = value
				If Me._btnMnuItemAdd IsNot Nothing Then
					AddHandler Me._btnMnuItemAdd.Click, value2
				End If
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

		Friend Overridable Property btnScriptAdd() As Button
			Get
				Return Me._btnScriptAdd
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnScriptAdd_Click
				If Me._btnScriptAdd IsNot Nothing Then
					RemoveHandler Me._btnScriptAdd.Click, value2
				End If
				Me._btnScriptAdd = value
				If Me._btnScriptAdd IsNot Nothing Then
					AddHandler Me._btnScriptAdd.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lstScripts() As ListBox
			Get
				Return Me._lstScripts
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstScripts_DoubleClick
				If Me._lstScripts IsNot Nothing Then
					RemoveHandler Me._lstScripts.DoubleClick, value2
				End If
				Me._lstScripts = value
				If Me._lstScripts IsNot Nothing Then
					AddHandler Me._lstScripts.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnMnuItemReloc() As Button
			Get
				Return Me._btnMnuItemReloc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnMnuItemReloc_Click
				If Me._btnMnuItemReloc IsNot Nothing Then
					RemoveHandler Me._btnMnuItemReloc.Click, value2
				End If
				Me._btnMnuItemReloc = value
				If Me._btnMnuItemReloc IsNot Nothing Then
					AddHandler Me._btnMnuItemReloc.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnMnuItemDel() As Button
			Get
				Return Me._btnMnuItemDel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnMnuItemDel_Click
				If Me._btnMnuItemDel IsNot Nothing Then
					RemoveHandler Me._btnMnuItemDel.Click, value2
				End If
				Me._btnMnuItemDel = value
				If Me._btnMnuItemDel IsNot Nothing Then
					AddHandler Me._btnMnuItemDel.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnScriptDel() As Button
			Get
				Return Me._btnScriptDel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnScriptDel_Click
				If Me._btnScriptDel IsNot Nothing Then
					RemoveHandler Me._btnScriptDel.Click, value2
				End If
				Me._btnScriptDel = value
				If Me._btnScriptDel IsNot Nothing Then
					AddHandler Me._btnScriptDel.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgMenuEdit_Load
			Me.bLoaded = False
			Me.MyMnuDef = Nothing
			Me.mnufile = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
			Me.SeleMnuItem = Nothing
			Me.CurrIndex = 0
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
			Me.TableLayoutPanel1 = New TableLayoutPanel()
			Me.OK_Button = New Button()
			Me.Cancel_Button = New Button()
			Me.Panel1 = New Panel()
			Me.btnMnuItemDel = New Button()
			Me.btnMnuItemReloc = New Button()
			Me.btnMnuItemAdd = New Button()
			Me.lstMnuItems = New ListBox()
			Me.Splitter1 = New Splitter()
			Me.Panel2 = New Panel()
			Me.btnScriptDel = New Button()
			Me.btnDown = New Button()
			Me.btnUp = New Button()
			Me.btnScriptAdd = New Button()
			Me.lstScripts = New ListBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_165_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(380, 552)
			arg_165_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1B7_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1B7_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1E4_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1E4_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_20B_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_20B_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_255_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_255_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_27C_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_27C_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Panel1.BorderStyle = BorderStyle.Fixed3D
			Me.Panel1.Controls.Add(Me.btnMnuItemDel)
			Me.Panel1.Controls.Add(Me.btnMnuItemReloc)
			Me.Panel1.Controls.Add(Me.btnMnuItemAdd)
			Me.Panel1.Controls.Add(Me.lstMnuItems)
			Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
			Me.Panel1.Dock = DockStyle.Left
			Dim arg_333_0 As Control = Me.Panel1
			location = New Point(0, 0)
			arg_333_0.Location = location
			Me.Panel1.Name = "Panel1"
			Dim arg_360_0 As Control = Me.Panel1
			size = New Size(534, 588)
			arg_360_0.Size = size
			Me.Panel1.TabIndex = 1
			Me.btnMnuItemDel.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_392_0 As Control = Me.btnMnuItemDel
			location = New Point(10, 485)
			arg_392_0.Location = location
			Me.btnMnuItemDel.Name = "btnMnuItemDel"
			Dim arg_3B9_0 As Control = Me.btnMnuItemDel
			size = New Size(102, 23)
			arg_3B9_0.Size = size
			Me.btnMnuItemDel.TabIndex = 6
			Me.btnMnuItemDel.Text = "Xóa MenuItem "
			Me.btnMnuItemDel.UseVisualStyleBackColor = True
			Me.btnMnuItemReloc.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_407_0 As Control = Me.btnMnuItemReloc
			location = New Point(10, 551)
			arg_407_0.Location = location
			Me.btnMnuItemReloc.Name = "btnMnuItemReloc"
			Dim arg_42E_0 As Control = Me.btnMnuItemReloc
			size = New Size(102, 23)
			arg_42E_0.Size = size
			Me.btnMnuItemReloc.TabIndex = 5
			Me.btnMnuItemReloc.Text = "B" & ChrW(7889) & " trí l" & ChrW(7841) & "i Menu"
			Me.btnMnuItemReloc.UseVisualStyleBackColor = True
			Me.btnMnuItemAdd.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Dim arg_480_0 As Control = Me.btnMnuItemAdd
			location = New Point(421, 485)
			arg_480_0.Location = location
			Me.btnMnuItemAdd.Name = "btnMnuItemAdd"
			Dim arg_4A7_0 As Control = Me.btnMnuItemAdd
			size = New Size(102, 23)
			arg_4A7_0.Size = size
			Me.btnMnuItemAdd.TabIndex = 4
			Me.btnMnuItemAdd.Text = "MenuItem m" & ChrW(7899) & "i"
			Me.btnMnuItemAdd.UseVisualStyleBackColor = True
			Me.lstMnuItems.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstMnuItems.Font = New Font("Tahoma", 11.13402F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lstMnuItems.FormattingEnabled = True
			Me.lstMnuItems.ItemHeight = 18
			Dim arg_529_0 As Control = Me.lstMnuItems
			location = New Point(10, 16)
			arg_529_0.Location = location
			Me.lstMnuItems.Name = "lstMnuItems"
			Dim arg_556_0 As Control = Me.lstMnuItems
			size = New Size(516, 454)
			arg_556_0.Size = size
			Me.lstMnuItems.TabIndex = 3
			Dim arg_57B_0 As Control = Me.Splitter1
			location = New Point(534, 0)
			arg_57B_0.Location = location
			Me.Splitter1.Name = "Splitter1"
			Dim arg_5A4_0 As Control = Me.Splitter1
			size = New Size(3, 588)
			arg_5A4_0.Size = size
			Me.Splitter1.TabIndex = 2
			Me.Splitter1.TabStop = False
			Me.Panel2.BorderStyle = BorderStyle.Fixed3D
			Me.Panel2.Controls.Add(Me.btnScriptDel)
			Me.Panel2.Controls.Add(Me.btnDown)
			Me.Panel2.Controls.Add(Me.btnUp)
			Me.Panel2.Controls.Add(Me.btnScriptAdd)
			Me.Panel2.Controls.Add(Me.lstScripts)
			Me.Panel2.Dock = DockStyle.Fill
			Dim arg_65B_0 As Control = Me.Panel2
			location = New Point(537, 0)
			arg_65B_0.Location = location
			Me.Panel2.Name = "Panel2"
			Dim arg_688_0 As Control = Me.Panel2
			size = New Size(499, 588)
			arg_688_0.Size = size
			Me.Panel2.TabIndex = 3
			Me.btnScriptDel.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_6BA_0 As Control = Me.btnScriptDel
			location = New Point(9, 518)
			arg_6BA_0.Location = location
			Me.btnScriptDel.Name = "btnScriptDel"
			Dim arg_6E1_0 As Control = Me.btnScriptDel
			size = New Size(102, 23)
			arg_6E1_0.Size = size
			Me.btnScriptDel.TabIndex = 11
			Me.btnScriptDel.Text = "Xóa k" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.btnScriptDel.UseVisualStyleBackColor = True
			Me.btnDown.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.btnDown.Image = Resources.FillDown
			Dim arg_744_0 As Control = Me.btnDown
			location = New Point(429, 518)
			arg_744_0.Location = location
			Me.btnDown.Name = "btnDown"
			Dim arg_76B_0 As Control = Me.btnDown
			size = New Size(25, 23)
			arg_76B_0.Size = size
			Me.btnDown.TabIndex = 10
			Me.btnDown.UseVisualStyleBackColor = True
			Me.btnUp.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.btnUp.Image = Resources.FillUp
			Dim arg_7BE_0 As Control = Me.btnUp
			location = New Point(462, 518)
			arg_7BE_0.Location = location
			Me.btnUp.Name = "btnUp"
			Dim arg_7E5_0 As Control = Me.btnUp
			size = New Size(23, 23)
			arg_7E5_0.Size = size
			Me.btnUp.TabIndex = 9
			Me.btnUp.UseVisualStyleBackColor = True
			Me.btnScriptAdd.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Dim arg_828_0 As Control = Me.btnScriptAdd
			location = New Point(273, 518)
			arg_828_0.Location = location
			Me.btnScriptAdd.Name = "btnScriptAdd"
			Dim arg_852_0 As Control = Me.btnScriptAdd
			size = New Size(132, 23)
			arg_852_0.Size = size
			Me.btnScriptAdd.TabIndex = 8
			Me.btnScriptAdd.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n m" & ChrW(7899) & "i"
			Me.btnScriptAdd.UseVisualStyleBackColor = True
			Me.lstScripts.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstScripts.Font = New Font("Tahoma", 11.13402F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lstScripts.FormattingEnabled = True
			Me.lstScripts.ItemHeight = 18
			Dim arg_8D4_0 As Control = Me.lstScripts
			location = New Point(9, 18)
			arg_8D4_0.Location = location
			Me.lstScripts.Name = "lstScripts"
			Dim arg_901_0 As Control = Me.lstScripts
			size = New Size(477, 490)
			arg_901_0.Size = size
			Me.lstScripts.TabIndex = 7
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(1036, 588)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Splitter1)
			Me.Controls.Add(Me.Panel1)
			Me.Font = New Font("Tahoma", 8.164948F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgMenuEdit"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "So" & ChrW(7841) & "n Menu"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(Me.MyMnuDef) Then
				If Interaction.MsgBox("Có c" & ChrW(7847) & "n b" & ChrW(7889) & " trí l" & ChrW(7841) & "i Menu không?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
					Dim dlgMenuReloc As dlgMenuReloc = New dlgMenuReloc()
					dlgMenuReloc.ShowDialog(Me, Me.MyMnuDef)
				End If
				Me.MyMnuDef.ToFile(Me.mnufile)
			End If
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgMenuEdit_Load(sender As Object, e As EventArgs)
			If MyProject.Computer.FileSystem.FileExists(Me.mnufile) Then
				Me.MyMnuDef = CMyMnu.LoadMyMnu(Me.mnufile)
				Me.bLoaded = True
				Me.RefreshMnuItemList(0)
			Else
				Interaction.MsgBox("Không th" & ChrW(7845) & "y file: " + Me.mnufile, MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub RefreshMnuItemList(pIndex As Integer)
			Me.lstMnuItems.DataSource = Nothing
			Me.lstMnuItems.DataSource = Me.MyMnuDef.MnuItems
			If pIndex < Me.lstMnuItems.Items.Count Then
				Me.lstMnuItems.SelectedIndex = pIndex
			End If
		End Sub

		Private Sub RefreshScriptList(pIndex As Integer)
			If Not Information.IsNothing(Me.SeleMnuItem) Then
				Me.lstScripts.DataSource = Nothing
				Me.lstScripts.DataSource = Me.SeleMnuItem.ItemScripts
				If pIndex < Me.lstScripts.Items.Count Then
					Me.lstScripts.SelectedIndex = pIndex
				End If
			End If
		End Sub

		Private Sub lstMnuItems_DoubleClick(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstMnuItems.SelectedItem)) Then
				Dim selectedIndex As Integer = Me.lstMnuItems.SelectedIndex
				Dim dlgMnuItemEdit As dlgMnuItemEdit = New dlgMnuItemEdit()
				If dlgMnuItemEdit.ShowDialog(Me, CType(Me.lstMnuItems.SelectedItem, CMnuItemDef)) = DialogResult.OK Then
					Me.RefreshMnuItemList(selectedIndex)
				End If
			End If
		End Sub

		Private Sub lstMnuItems_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.bLoaded Then
				Me.SeleMnuItem = CType(Me.lstMnuItems.SelectedItem, CMnuItemDef)
				Me.RefreshScriptList(0)
			End If
		End Sub

		Private Sub lstScripts_DoubleClick(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstScripts.SelectedItem)) Then
				Dim value As Object = Me.lstScripts.SelectedIndex
				Dim dlgScriptEdit As dlgScriptEdit = New dlgScriptEdit()
				If dlgScriptEdit.ShowDialog(Me, CType(Me.lstScripts.SelectedItem, CItemScriptDef)) = DialogResult.OK Then
					Me.RefreshScriptList(Conversions.ToInteger(value))
				End If
			End If
		End Sub

		Private Sub btnMnuItemAdd_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim cMnuItemDef As CMnuItemDef
			If Me.lstMnuItems.Items.Count > 0 Then
				cMnuItemDef = CType(Me.lstMnuItems.Items(Me.lstMnuItems.Items.Count - 1), CMnuItemDef)
			Else
				cMnuItemDef = New CMnuItemDef()
				Dim cMnuItemDef2 As CMnuItemDef = cMnuItemDef
				cMnuItemDef2.PosX = 10
				cMnuItemDef2.PosY = CInt(Math.Round(CDec(modSaBan.MenuFontSize))) + 18
				cMnuItemDef2.Width = 100
				cMnuItemDef2.Height = CInt(Math.Round(CDec(modSaBan.MenuFontSize)))
			End If
			Dim cMnuItemDef3 As CMnuItemDef = New CMnuItemDef()
			Dim cMnuItemDef4 As CMnuItemDef = cMnuItemDef3
			cMnuItemDef4.Name = "MenuItem moi"
			cMnuItemDef4.PosX = cMnuItemDef.PosX
			cMnuItemDef4.PosY = cMnuItemDef.PosY + CInt(Math.Round(CDec(modSaBan.MenuFontSize))) + 8
			cMnuItemDef4.Width = cMnuItemDef.Width
			cMnuItemDef4.Height = cMnuItemDef.Height
			Dim value As Object = Me.lstMnuItems.Items.Count
			Dim dlgMnuItemEdit As dlgMnuItemEdit = New dlgMnuItemEdit()
			If dlgMnuItemEdit.ShowDialog(Me, cMnuItemDef3) = DialogResult.OK Then
				Me.MyMnuDef.MnuItems.Add(cMnuItemDef3)
				Me.RefreshMnuItemList(Conversions.ToInteger(value))
			End If
		End Sub

		Private Sub btnDown_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lstScripts.SelectedIndex
			' The following expression was wrapped in a checked-statement
			If selectedIndex < Me.SeleMnuItem.ItemScripts.Count - 1 Then
				Dim item As CItemScriptDef = Me.SeleMnuItem.ItemScripts(selectedIndex)
				Me.SeleMnuItem.ItemScripts.Remove(item)
				Me.SeleMnuItem.ItemScripts.Insert(selectedIndex + 1, item)
			End If
			Me.RefreshScriptList(selectedIndex + 1)
		End Sub

		Private Sub btnUp_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.lstScripts.SelectedIndex
			' The following expression was wrapped in a checked-statement
			If selectedIndex > 0 Then
				Dim item As CItemScriptDef = Me.SeleMnuItem.ItemScripts(selectedIndex)
				Me.SeleMnuItem.ItemScripts.Remove(item)
				Me.SeleMnuItem.ItemScripts.Insert(selectedIndex - 1, item)
			End If
			Me.RefreshScriptList(selectedIndex - 1)
		End Sub

		Private Sub btnScriptAdd_Click(sender As Object, e As EventArgs)
			Dim cItemScriptDef As CItemScriptDef = New CItemScriptDef()
			Dim cItemScriptDef2 As CItemScriptDef = cItemScriptDef
			If Me.lstScripts.Items.Count > 0 Then
				cItemScriptDef2.Start = "Stop()"
			Else
				cItemScriptDef2.Start = "0"
			End If
			Dim value As Object = Me.lstScripts.Items.Count
			Dim dlgScriptEdit As dlgScriptEdit = New dlgScriptEdit()
			If dlgScriptEdit.ShowDialog(Me, cItemScriptDef) = DialogResult.OK Then
				Me.SeleMnuItem.ItemScripts.Add(cItemScriptDef)
				Me.RefreshScriptList(Conversions.ToInteger(value))
			End If
		End Sub

		Private Sub btnMnuItemReloc_Click(sender As Object, e As EventArgs)
			Dim dlgMenuReloc As dlgMenuReloc = New dlgMenuReloc()
			dlgMenuReloc.ShowDialog(Me, Me.MyMnuDef)
		End Sub

		Private Sub btnMnuItemDel_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstMnuItems.SelectedItem)) Then
				Me.SeleMnuItem = CType(Me.lstMnuItems.SelectedItem, CMnuItemDef)
				Dim selectedIndex As Integer = Me.lstMnuItems.SelectedIndex
				If Interaction.MsgBox("Xóa MenuItem này?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
					Me.MyMnuDef.MnuItems.Remove(Me.SeleMnuItem)
					' The following expression was wrapped in a checked-expression
					Dim pIndex As Integer = Math.Min(selectedIndex, Me.lstMnuItems.Items.Count - 2)
					Me.RefreshMnuItemList(pIndex)
				End If
			End If
		End Sub

		Private Sub btnScriptDel_Click(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstScripts.SelectedItem)) Then
				Dim item As CItemScriptDef = CType(Me.lstScripts.SelectedItem, CItemScriptDef)
				Dim selectedIndex As Integer = Me.lstScripts.SelectedIndex
				If Interaction.MsgBox("Xóa MenuItem này?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
					Me.SeleMnuItem.ItemScripts.Remove(item)
					' The following expression was wrapped in a checked-expression
					Dim pIndex As Integer = Math.Min(selectedIndex, Me.lstScripts.Items.Count - 2)
					Me.RefreshScriptList(pIndex)
				End If
			End If
		End Sub
	End Class
End Namespace
