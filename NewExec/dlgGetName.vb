Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports SaBan.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgGetName
		Inherits Form

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

		Friend Overridable Property lstNames() As ListBox
			Get
				Return Me._lstNames
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.lstNames_DoubleClick
				Dim value3 As EventHandler = AddressOf Me.lstNames_SelectedIndexChanged
				If Me._lstNames IsNot Nothing Then
					RemoveHandler Me._lstNames.DoubleClick, value2
					RemoveHandler Me._lstNames.SelectedIndexChanged, value3
				End If
				Me._lstNames = value
				If Me._lstNames IsNot Nothing Then
					AddHandler Me._lstNames.DoubleClick, value2
					AddHandler Me._lstNames.SelectedIndexChanged, value3
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

		Friend Overridable Property txtNameType() As TextBox
			Get
				Return Me._txtNameType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtNameType = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgGetName_Load
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
			Dim arg_EC_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(159, 274)
			arg_EC_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_13E_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_13E_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_16B_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_16B_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_192_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_192_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1DC_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1DC_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_203_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_203_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.lstNames.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.lstNames.FormattingEnabled = True
			Dim arg_24F_0 As Control = Me.lstNames
			location = New Point(9, 11)
			arg_24F_0.Location = location
			Me.lstNames.Name = "lstNames"
			Dim arg_27C_0 As Control = Me.lstNames
			size = New Size(299, 225)
			arg_27C_0.Size = size
			Me.lstNames.TabIndex = 1
			Me.txtName.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_2AF_0 As Control = Me.txtName
			location = New Point(9, 248)
			arg_2AF_0.Location = location
			Me.txtName.Name = "txtName"
			Dim arg_2D9_0 As Control = Me.txtName
			size = New Size(299, 21)
			arg_2D9_0.Size = size
			Me.txtName.TabIndex = 2
			Me.txtNameType.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_30B_0 As Control = Me.txtNameType
			location = New Point(9, 274)
			arg_30B_0.Location = location
			Me.txtNameType.Name = "txtNameType"
			Dim arg_332_0 As Control = Me.txtNameType
			size = New Size(92, 21)
			arg_332_0.Size = size
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
			Me.OK_Button.Enabled = False
			Dim list As List(Of String) = New List(Of String)()
			Dim text As String = Me.txtNameType.Text
			' The following expression was wrapped in a checked-statement
			If Operators.CompareString(text, "Dir", False) = 0 Then
				Try
					Try
						Dim enumerator As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetDirectories(MyProject.Computer.FileSystem.CurrentDirectory).GetEnumerator()
						While enumerator.MoveNext()
							Dim current As String = enumerator.Current
							Dim num As Integer = current.LastIndexOf("\")
							Dim item As String
							If num > -1 Then
								item = current.Substring(num + 1)
							Else
								item = current
							End If
							list.Add(item)
						End While
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					Me.OK_Button.Enabled = True
				Catch expr_AE As Exception
					ProjectData.SetProjectError(expr_AE)
					ProjectData.ClearProjectError()
				End Try
			Else If Operators.CompareString(text, "Sound", False) = 0 Then
				Try
					Try
						Dim enumerator2 As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetFiles(modSaBan.mySoundsPath, SearchOption.SearchTopLevelOnly, New String() { "*.wav" }).GetEnumerator()
						While enumerator2.MoveNext()
							Dim current2 As String = enumerator2.Current
							Dim num2 As Integer = current2.LastIndexOf("\")
							Dim item2 As String
							If num2 > -1 Then
								item2 = current2.Substring(num2 + 1)
							Else
								item2 = current2
							End If
							list.Add(item2)
						End While
					Finally
						Dim enumerator2 As IEnumerator(Of String)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
					Me.OK_Button.Enabled = True
				Catch expr_162 As Exception
					ProjectData.SetProjectError(expr_162)
					ProjectData.ClearProjectError()
				End Try
			Else If Operators.CompareString(text, "TMSound", False) = 0 Then
				Try
					Try
						Dim enumerator3 As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetFiles(modSaBan.myTMSoundsPath, SearchOption.SearchTopLevelOnly, New String() { "*.wav" }).GetEnumerator()
						While enumerator3.MoveNext()
							Dim current3 As String = enumerator3.Current
							Dim num3 As Integer = current3.LastIndexOf("\")
							Dim item3 As String
							If num3 > -1 Then
								item3 = current3.Substring(num3 + 1)
							Else
								item3 = current3
							End If
							list.Add(item3)
						End While
					Finally
						Dim enumerator3 As IEnumerator(Of String)
						If enumerator3 IsNot Nothing Then
							enumerator3.Dispose()
						End If
					End Try
					Me.OK_Button.Enabled = True
				Catch expr_216 As Exception
					ProjectData.SetProjectError(expr_216)
					ProjectData.ClearProjectError()
				End Try
			Else If Operators.CompareString(text, "Image", False) = 0 Then
				Try
					Dim wildcards As String() = New String() { "*.bmp", "*.png" }
					Try
						Dim enumerator4 As IEnumerator(Of String) = MyProject.Computer.FileSystem.GetFiles(modSaBan.myImagesPath, SearchOption.SearchTopLevelOnly, wildcards).GetEnumerator()
						While enumerator4.MoveNext()
							Dim current4 As String = enumerator4.Current
							Dim num4 As Integer = current4.LastIndexOf("\")
							Dim item4 As String
							If num4 > -1 Then
								item4 = current4.Substring(num4 + 1)
							Else
								item4 = current4
							End If
							list.Add(item4)
						End While
					Finally
						Dim enumerator4 As IEnumerator(Of String)
						If enumerator4 IsNot Nothing Then
							enumerator4.Dispose()
						End If
					End Try
					Me.OK_Button.Enabled = True
				Catch expr_2D7 As Exception
					ProjectData.SetProjectError(expr_2D7)
					ProjectData.ClearProjectError()
				End Try
			End If
			Return list
		End Function

		Private Sub lstNames_DoubleClick(sender As Object, e As EventArgs)
			If Not Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.lstNames.SelectedItem)) Then
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		Private Sub lstNames_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.txtName.Text = Me.names(Me.lstNames.SelectedIndex)
		End Sub
	End Class
End Namespace
