Imports DienTapLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgActDef2s
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("lstActions")>
		Private _lstActions As ListBox

		<AccessedThroughProperty("txtActFileName")>
		Private _txtActFileName As TextBox

		<AccessedThroughProperty("txtObjName")>
		Private _txtObjName As TextBox

		<AccessedThroughProperty("btnObjName")>
		Private _btnObjName As Button

		<AccessedThroughProperty("txtObjType")>
		Private _txtObjType As TextBox

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("rbtnInvalidName")>
		Private _rbtnInvalidName As RadioButton

		<AccessedThroughProperty("rbtnByName")>
		Private _rbtnByName As RadioButton

		<AccessedThroughProperty("rbtnViewAll")>
		Private _rbtnViewAll As RadioButton

		<AccessedThroughProperty("btnRefresh")>
		Private _btnRefresh As Button

		Private MenuFileName As String

		Private mymnu As CMnu

		Private Scripts As List(Of CScript)

		Private Parentf As frmMain

		Private actdef2s As List(Of CActDef2)

		Private CurrIndex As Integer

		Private actID As Integer

		Private bMenuLoaded As Boolean

		Private bRefresh As Boolean

		Public bView As Boolean

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
				Dim value3 As EventHandler = AddressOf Me.lstActions_SelectedIndexChanged
				If Me._lstActions IsNot Nothing Then
					RemoveHandler Me._lstActions.DoubleClick, value2
					RemoveHandler Me._lstActions.SelectedIndexChanged, value3
				End If
				Me._lstActions = value
				If Me._lstActions IsNot Nothing Then
					AddHandler Me._lstActions.DoubleClick, value2
					AddHandler Me._lstActions.SelectedIndexChanged, value3
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

		Friend Overridable Property txtObjName() As TextBox
			Get
				Return Me._txtObjName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjName = value
			End Set
		End Property

		Friend Overridable Property btnObjName() As Button
			Get
				Return Me._btnObjName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnObjName_Click
				If Me._btnObjName IsNot Nothing Then
					RemoveHandler Me._btnObjName.Click, value2
				End If
				Me._btnObjName = value
				If Me._btnObjName IsNot Nothing Then
					AddHandler Me._btnObjName.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtObjType() As TextBox
			Get
				Return Me._txtObjType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtObjType = value
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

		Friend Overridable Property rbtnInvalidName() As RadioButton
			Get
				Return Me._rbtnInvalidName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtnInvalidName = value
			End Set
		End Property

		Friend Overridable Property rbtnByName() As RadioButton
			Get
				Return Me._rbtnByName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtnByName = value
			End Set
		End Property

		Friend Overridable Property rbtnViewAll() As RadioButton
			Get
				Return Me._rbtnViewAll
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._rbtnViewAll = value
			End Set
		End Property

		Friend Overridable Property btnRefresh() As Button
			Get
				Return Me._btnRefresh
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnRefresh_Click
				If Me._btnRefresh IsNot Nothing Then
					RemoveHandler Me._btnRefresh.Click, value2
				End If
				Me._btnRefresh = value
				If Me._btnRefresh IsNot Nothing Then
					AddHandler Me._btnRefresh.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgActDef2s_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgActDef2s_Load
			Me.CurrIndex = 0
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
			Me.OK_Button = New Button()
			Me.lstActions = New ListBox()
			Me.txtActFileName = New TextBox()
			Me.txtObjName = New TextBox()
			Me.btnObjName = New Button()
			Me.txtObjType = New TextBox()
			Me.GroupBox1 = New GroupBox()
			Me.rbtnViewAll = New RadioButton()
			Me.rbtnInvalidName = New RadioButton()
			Me.rbtnByName = New RadioButton()
			Me.btnRefresh = New Button()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.OK_Button.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_AC_0 As Control = Me.OK_Button
			Dim location As Point = New Point(329, 65)
			arg_AC_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_D3_0 As Control = Me.OK_Button
			Dim size As Size = New Size(93, 23)
			arg_D3_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "L" & ChrW(7885) & "c"
			Me.lstActions.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstActions.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lstActions.FormattingEnabled = True
			Me.lstActions.ItemHeight = 14
			Dim arg_14C_0 As Control = Me.lstActions
			location = New Point(12, 136)
			arg_14C_0.Location = location
			Me.lstActions.Name = "lstActions"
			Dim arg_179_0 As Control = Me.lstActions
			size = New Size(428, 186)
			arg_179_0.Size = size
			Me.lstActions.TabIndex = 2
			Dim arg_19C_0 As Control = Me.txtActFileName
			location = New Point(12, 109)
			arg_19C_0.Location = location
			Me.txtActFileName.Name = "txtActFileName"
			Me.txtActFileName.[ReadOnly] = True
			Dim arg_1D2_0 As Control = Me.txtActFileName
			size = New Size(277, 21)
			arg_1D2_0.Size = size
			Me.txtActFileName.TabIndex = 10
			Me.txtObjName.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_206_0 As Control = Me.txtObjName
			location = New Point(136, 20)
			arg_206_0.Location = location
			Me.txtObjName.Name = "txtObjName"
			Dim arg_230_0 As Control = Me.txtObjName
			size = New Size(187, 21)
			arg_230_0.Size = size
			Me.txtObjName.TabIndex = 13
			Me.btnObjName.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_264_0 As Control = Me.btnObjName
			location = New Point(329, 18)
			arg_264_0.Location = location
			Me.btnObjName.Name = "btnObjName"
			Dim arg_28B_0 As Control = Me.btnObjName
			size = New Size(93, 23)
			arg_28B_0.Size = size
			Me.btnObjName.TabIndex = 14
			Me.btnObjName.Text = "L" & ChrW(7845) & "y " & ChrW(272) & "T trên B" & ChrW(272)
			Me.btnObjName.UseVisualStyleBackColor = True
			Dim arg_2CE_0 As Control = Me.txtObjType
			location = New Point(300, 43)
			arg_2CE_0.Location = location
			Me.txtObjType.Name = "txtObjType"
			Dim arg_2F5_0 As Control = Me.txtObjType
			size = New Size(38, 21)
			arg_2F5_0.Size = size
			Me.txtObjType.TabIndex = 19
			Me.txtObjType.Visible = False
			Me.GroupBox1.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.GroupBox1.Controls.Add(Me.txtObjName)
			Me.GroupBox1.Controls.Add(Me.OK_Button)
			Me.GroupBox1.Controls.Add(Me.rbtnViewAll)
			Me.GroupBox1.Controls.Add(Me.rbtnInvalidName)
			Me.GroupBox1.Controls.Add(Me.rbtnByName)
			Me.GroupBox1.Controls.Add(Me.txtObjType)
			Me.GroupBox1.Controls.Add(Me.btnObjName)
			Dim arg_3CB_0 As Control = Me.GroupBox1
			location = New Point(12, 0)
			arg_3CB_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_3F5_0 As Control = Me.GroupBox1
			size = New Size(428, 94)
			arg_3F5_0.Size = size
			Me.GroupBox1.TabIndex = 21
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "L" & ChrW(7885) & "c"
			Me.rbtnViewAll.AutoSize = True
			Dim arg_441_0 As Control = Me.rbtnViewAll
			location = New Point(18, 68)
			arg_441_0.Location = location
			Me.rbtnViewAll.Name = "rbtnViewAll"
			Dim arg_468_0 As Control = Me.rbtnViewAll
			size = New Size(60, 18)
			arg_468_0.Size = size
			Me.rbtnViewAll.TabIndex = 20
			Me.rbtnViewAll.TabStop = True
			Me.rbtnViewAll.Text = "T" & ChrW(7845) & "t c" & ChrW(7843)
			Me.rbtnViewAll.UseVisualStyleBackColor = True
			Me.rbtnInvalidName.AutoSize = True
			Dim arg_4C0_0 As Control = Me.rbtnInvalidName
			location = New Point(18, 47)
			arg_4C0_0.Location = location
			Me.rbtnInvalidName.Name = "rbtnInvalidName"
			Dim arg_4EA_0 As Control = Me.rbtnInvalidName
			size = New Size(181, 18)
			arg_4EA_0.Size = size
			Me.rbtnInvalidName.TabIndex = 1
			Me.rbtnInvalidName.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng không h" & ChrW(7907) & "p l" & ChrW(7879)
			Me.rbtnInvalidName.UseVisualStyleBackColor = True
			Me.rbtnByName.AutoSize = True
			Me.rbtnByName.Checked = True
			Dim arg_541_0 As Control = Me.rbtnByName
			location = New Point(18, 24)
			arg_541_0.Location = location
			Me.rbtnByName.Name = "rbtnByName"
			Dim arg_568_0 As Control = Me.rbtnByName
			size = New Size(121, 18)
			arg_568_0.Size = size
			Me.rbtnByName.TabIndex = 0
			Me.rbtnByName.TabStop = True
			Me.rbtnByName.Text = "Tên " & ChrW(273) & ChrW(7889) & "i t" & ChrW(432) & ChrW(7907) & "ng là:"
			Me.rbtnByName.UseVisualStyleBackColor = True
			Me.btnRefresh.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Dim arg_5C3_0 As Control = Me.btnRefresh
			location = New Point(341, 107)
			arg_5C3_0.Location = location
			Me.btnRefresh.Name = "btnRefresh"
			Dim arg_5EA_0 As Control = Me.btnRefresh
			size = New Size(93, 23)
			arg_5EA_0.Size = size
			Me.btnRefresh.TabIndex = 21
			Me.btnRefresh.Text = "Refresh"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(452, 338)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnRefresh)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.txtActFileName)
			Me.Controls.Add(Me.lstActions)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgActDef2s"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgActions"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub RefreshList(pIndex As Integer)
			Me.bRefresh = False
			Me.lstActions.DataSource = Nothing
			Me.lstActions.DataSource = Me.actdef2s
			If pIndex < Me.lstActions.Items.Count Then
				Me.lstActions.SelectedIndex = pIndex
			End If
			Dim cActDef As CActDef2 = CType(Me.lstActions.SelectedItem, CActDef2)
			Me.txtActFileName.Text = cActDef.scrname
			Me.bRefresh = True
		End Sub

		Public Sub UpdateAction()
			Me.RefreshList(Me.CurrIndex)
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgActDef2s_FormClosing(sender As Object, e As FormClosingEventArgs)
			modSaBan.fActions.cboScripts.Enabled = True
			modSaBan.fActions.lstActions.Enabled = True
		End Sub

		Private Sub dlgActDef2s_Load(sender As Object, e As EventArgs)
			Me.Text = "Li" & ChrW(7879) & "t kê các hành " & ChrW(273) & ChrW(7897) & "ng"
			Me.LoadAllScripts(Me.MenuFileName)
			modSaBan.fActions.lstActions.Enabled = False
			modSaBan.fActions.cboScripts.Enabled = False
		End Sub

		Private Sub LoadAllScripts(pMenuFileName As String)
			If MyProject.Computer.FileSystem.FileExists(pMenuFileName) Then
				Me.mymnu = New CMnu(Nothing)
				Me.mymnu.LoadScripts(pMenuFileName)
				Me.Scripts = Me.mymnu.scripts
			Else
				Me.Scripts = New List(Of CScript)()
			End If
			Me.actdef2s = New List(Of CActDef2)()
			Dim num As Integer = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CScript).Enumerator = Me.Scripts.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CScript = enumerator.Current
					num += 1
					Dim list As List(Of CActDef)
					If num = modSaBan.fActions.cboScripts.SelectedIndex Then
						list = CType(modSaBan.fActions.lstActions.DataSource, List(Of CActDef))
					Else
						list = CActDefs.ReadActionDef(current.ScrptFile)
					End If
					Dim num2 As Integer = -1
					Try
						Dim enumerator2 As List(Of CActDef).Enumerator = list.GetEnumerator()
						While enumerator2.MoveNext()
							Dim current2 As CActDef = enumerator2.Current
							num2 += 1
							Dim cActDef As CActDef2 = New CActDef2()
							cActDef.scrname = current.ScrptFile
							cActDef.actdef = current2
							cActDef.scrindex = num
							cActDef.actindex = num2
							Me.actdef2s.Add(cActDef)
						End While
					Finally
						Dim enumerator2 As List(Of CActDef).Enumerator
						(CType(enumerator2, IDisposable)).Dispose()
					End Try
				End While
			Finally
				Dim enumerator As List(Of CScript).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Me.RefreshList(0)
		End Sub

		Private Sub LoadCurrScript()
			Dim list As List(Of CActDef) = CType(modSaBan.fActions.lstActions.DataSource, List(Of CActDef))
			Dim num As Integer = -1
			' The following expression was wrapped in a checked-statement
			Try
				Dim enumerator As List(Of CActDef).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As CActDef = enumerator.Current
					num += 1
					Dim cActDef As CActDef2 = New CActDef2()
					cActDef.scrname = modSaBan.fActions.cboScripts.SelectedText
					cActDef.actdef = current
					cActDef.scrindex = modSaBan.fActions.cboScripts.SelectedIndex
					cActDef.actindex = num
					Me.actdef2s.Add(cActDef)
				End While
			Finally
				Dim enumerator As List(Of CActDef).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
		End Sub

		Public Sub Show(pFileName As String, pform As Form)
			Me.MenuFileName = pFileName
			Me.Parentf = CType(pform, frmMain)
			Me.Show(Me.Parentf)
		End Sub

		Private Sub lstActions_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.bRefresh And Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstActions.SelectedItem)) Then
				Dim cActDef As CActDef2 = CType(Me.lstActions.SelectedItem, CActDef2)
				Me.txtActFileName.Text = cActDef.scrname
				If cActDef.scrindex <> modSaBan.fActions.cboScripts.SelectedIndex Then
					modSaBan.fActions.UpdateScript(modSaBan.fActions.txtActFileName.Text)
					modSaBan.fActions.cboScripts.SelectedIndex = cActDef.scrindex
				End If
				modSaBan.fActions.lstActions.SelectionMode = SelectionMode.One
				modSaBan.fActions.lstActions.SelectedIndex = cActDef.actindex
			End If
		End Sub

		Private Sub lstActions_DoubleClick(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(modSaBan.fActions.lstActions.SelectedItem)) Then
				Me.CurrIndex = Me.lstActions.SelectedIndex
				Dim oAction As CActDef = CType(modSaBan.fActions.lstActions.SelectedItem, CActDef)
				modSaBan.fActions.onActEdit(oAction)
			End If
		End Sub

		Private Function GetSymbolByName(Name As String) As CSymbol
			Dim result As CSymbol = Nothing
			Try
				Dim enumerator As IEnumerator = Me.Parentf.myBando.drawingSymbols.GetEnumerator()
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

		Private Sub btnObjName_Click(sender As Object, e As EventArgs)
			Me.txtObjName.Text = ""
			myModule.fMain.myVeActs.OnGetObjName2(Me.txtObjName, Me.txtObjType)
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.RefreshActs()
		End Sub

		Private Sub RefreshActs()
			If Me.rbtnByName.Checked Then
				Me.bRefresh = False
				Me.lstActions.DataSource = Nothing
				Me.LoadAllScripts(Me.MenuFileName)
				Dim list As List(Of CActDef2) = New List(Of CActDef2)()
				Try
					Dim enumerator As List(Of CActDef2).Enumerator = Me.actdef2s.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As CActDef2 = enumerator.Current
						If current.actdef.ObjName.Contains(Me.txtObjName.Text) Then
							list.Add(current)
						End If
					End While
				Finally
					Dim enumerator As List(Of CActDef2).Enumerator
					(CType(enumerator, IDisposable)).Dispose()
				End Try
				Me.lstActions.DataSource = list
				Me.bRefresh = True
			Else If Me.rbtnInvalidName.Checked Then
				Me.bRefresh = False
				Me.lstActions.DataSource = Nothing
				Me.LoadAllScripts(Me.MenuFileName)
				Dim list2 As List(Of CActDef2) = New List(Of CActDef2)()
				Try
					Dim enumerator2 As List(Of CActDef2).Enumerator = Me.actdef2s.GetEnumerator()
					While enumerator2.MoveNext()
						Dim current2 As CActDef2 = enumerator2.Current
						If Not Me.IsNameOK(current2.actdef.ObjName) Then
							list2.Add(current2)
						End If
					End While
				Finally
					Dim enumerator2 As List(Of CActDef2).Enumerator
					(CType(enumerator2, IDisposable)).Dispose()
				End Try
				Me.lstActions.DataSource = list2
				Me.bRefresh = True
			Else If Me.rbtnViewAll.Checked Then
				Me.LoadAllScripts(Me.MenuFileName)
			End If
		End Sub

		Private Function IsNameOK(pName As String) As Boolean
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
				If num <> 1 Then
					result = False
				End If
			End If
			Return result
		End Function

		Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
			Me.RefreshActs()
		End Sub
	End Class
End Namespace
