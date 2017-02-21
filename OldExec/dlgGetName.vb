Imports BdTC.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgGetName
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("lstNames")>
		Private _lstNames As ListBox

		<AccessedThroughProperty("txtName")>
		Private _txtName As TextBox

		<AccessedThroughProperty("txtNameType")>
		Private _txtNameType As TextBox

		Private names As List(Of String)

		Friend Overridable Property TableLayoutPanel1() As TableLayoutPanel
			<DebuggerNonUserCode()>
			Get
				Return Me._TableLayoutPanel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TableLayoutPanel)
				Me._TableLayoutPanel1 = value
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

		Friend Overridable Property lstNames() As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._lstNames
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim flag As Boolean = Me._lstNames IsNot Nothing
				If flag Then
					RemoveHandler Me._lstNames.SelectedIndexChanged, AddressOf Me.lstNames_SelectedIndexChanged
					RemoveHandler Me._lstNames.DoubleClick, AddressOf Me.lstNames_DoubleClick
				End If
				Me._lstNames = value
				flag = (Me._lstNames IsNot Nothing)
				If flag Then
					AddHandler Me._lstNames.SelectedIndexChanged, AddressOf Me.lstNames_SelectedIndexChanged
					AddHandler Me._lstNames.DoubleClick, AddressOf Me.lstNames_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtName = value
			End Set
		End Property

		Friend Overridable Property txtNameType() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtNameType
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtNameType = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgGetName_Load
			dlgGetName.__ENCList.Add(New WeakReference(Me))
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
			Me.TableLayoutPanel1 = New TableLayoutPanel()
			Me.OK_Button = New Button()
			Me.Cancel_Button = New Button()
			Me.lstNames = New ListBox()
			Me.txtName = New TextBox()
			Me.txtNameType = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_FA_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(159, 274)
			arg_FA_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_150_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_150_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_181_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_181_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1AB_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1AB_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1FB_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1FB_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_225_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_225_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.lstNames.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstNames.FormattingEnabled = True
			Dim arg_277_0 As Control = Me.lstNames
			location = New Point(9, 11)
			arg_277_0.Location = location
			Me.lstNames.Name = "lstNames"
			Dim arg_2A7_0 As Control = Me.lstNames
			size = New Size(299, 225)
			arg_2A7_0.Size = size
			Me.lstNames.TabIndex = 1
			Me.txtName.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_2DE_0 As Control = Me.txtName
			location = New Point(9, 248)
			arg_2DE_0.Location = location
			Me.txtName.Name = "txtName"
			Dim arg_30B_0 As Control = Me.txtName
			size = New Size(299, 21)
			arg_30B_0.Size = size
			Me.txtName.TabIndex = 2
			Me.txtNameType.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_341_0 As Control = Me.txtNameType
			location = New Point(9, 274)
			arg_341_0.Location = location
			Me.txtNameType.Name = "txtNameType"
			Dim arg_36B_0 As Control = Me.txtNameType
			size = New Size(92, 21)
			arg_36B_0.Size = size
			Me.txtNameType.TabIndex = 3
			Me.txtNameType.Visible = False
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(317, 315)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtNameType)
			Me.Controls.Add(Me.txtName)
			Me.Controls.Add(Me.lstNames)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgGetName"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgGetName"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgGetName_Load(sender As Object, e As EventArgs)
			Me.names = Me.GetNames()
			Me.lstNames.DataSource = Me.names
		End Sub

		Private Function GetNames() As List(Of String)
			Dim names As List(Of String) = New List(Of String)()
			Dim text As String = Me.txtNameType.Text
			Dim flag As Boolean = Operators.CompareString(text, "Dir", False) = 0
			' The following expression was wrapped in a checked-statement
			If flag Then
				Try
					Dim enumerator As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetDirectories(MyProject.Computer.FileSystem.CurrentDirectory).GetEnumerator()
					While enumerator.MoveNext()
						Dim subdir As String = enumerator.Current
						Dim i As Integer = subdir.LastIndexOf("\")
						flag = (i > -1)
						Dim dirName As String
						If flag Then
							dirName = subdir.Substring(i + 1)
						Else
							dirName = subdir
						End If
						names.Add(dirName)
					End While
				Finally
					Dim enumerator As IEnumerator(Of String)
					flag = (enumerator IsNot Nothing)
					If flag Then
						enumerator.Dispose()
					End If
				End Try
			Else
				flag = (Operators.CompareString(text, "Sound", False) = 0)
				If flag Then
					Try
						Dim enumerator2 As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.CurrentDirectory + "\sounds", SearchOption.SearchTopLevelOnly, New String() { "*.wav" }).GetEnumerator()
						While enumerator2.MoveNext()
							Dim mPath As String = enumerator2.Current
							Dim j As Integer = mPath.LastIndexOf("\")
							flag = (j > -1)
							Dim mName As String
							If flag Then
								mName = mPath.Substring(j + 1)
							Else
								mName = mPath
							End If
							names.Add(mName)
						End While
					Finally
						Dim enumerator2 As IEnumerator(Of String)
						flag = (enumerator2 IsNot Nothing)
						If flag Then
							enumerator2.Dispose()
						End If
					End Try
				Else
					flag = (Operators.CompareString(text, "Image", False) = 0)
					If flag Then
						Try
							Dim enumerator3 As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetFiles(MyProject.Computer.FileSystem.CurrentDirectory + "\images", SearchOption.SearchTopLevelOnly, New String() { "*.bmp" }).GetEnumerator()
							While enumerator3.MoveNext()
								Dim mPath2 As String = enumerator3.Current
								Dim k As Integer = mPath2.LastIndexOf("\")
								flag = (k > -1)
								Dim mName2 As String
								If flag Then
									mName2 = mPath2.Substring(k + 1)
								Else
									mName2 = mPath2
								End If
								names.Add(mName2)
							End While
						Finally
							Dim enumerator3 As IEnumerator(Of String)
							flag = (enumerator3 IsNot Nothing)
							If flag Then
								enumerator3.Dispose()
							End If
						End Try
					End If
				End If
			End If
			Return names
		End Function

		Private Sub lstNames_DoubleClick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstNames.SelectedItem))
			If flag Then
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		Private Sub lstNames_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.txtName.Text = Me.names(Me.lstNames.SelectedIndex)
		End Sub
	End Class
End Namespace
