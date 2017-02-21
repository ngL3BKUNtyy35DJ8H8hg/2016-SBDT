Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
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
	Public Class dlgScriptEdit
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("txtComment")>
		Private _txtComment As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("txtID")>
		Private _txtID As TextBox

		<AccessedThroughProperty("txtStart")>
		Private _txtStart As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtScrptFile")>
		Private _txtScrptFile As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtMnuItemRef")>
		Private _txtMnuItemRef As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		Private myItemScript As CItemScriptDef

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

		Friend Overridable Property txtComment() As TextBox
			Get
				Return Me._txtComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtComment = value
			End Set
		End Property

		Friend Overridable Property Label1() As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property txtID() As TextBox
			Get
				Return Me._txtID
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtID = value
			End Set
		End Property

		Friend Overridable Property txtStart() As TextBox
			Get
				Return Me._txtStart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtStart = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property txtScrptFile() As TextBox
			Get
				Return Me._txtScrptFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtScrptFile = value
			End Set
		End Property

		Friend Overridable Property Label3() As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property txtMnuItemRef() As TextBox
			Get
				Return Me._txtMnuItemRef
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMnuItemRef = value
			End Set
		End Property

		Friend Overridable Property Label4() As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgScriptEdit_Load
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
			Me.txtComment = New TextBox()
			Me.Label1 = New Label()
			Me.txtID = New TextBox()
			Me.txtStart = New TextBox()
			Me.Label2 = New Label()
			Me.txtScrptFile = New TextBox()
			Me.Label3 = New Label()
			Me.txtMnuItemRef = New TextBox()
			Me.Label4 = New Label()
			Me.Label6 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_139_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(616, 235)
			arg_139_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_18B_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_18B_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1B8_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1B8_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1DF_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1DF_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_229_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_229_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_250_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_250_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.txtComment.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_290_0 As Control = Me.txtComment
			location = New Point(12, 34)
			arg_290_0.Location = location
			Me.txtComment.Multiline = True
			Me.txtComment.Name = "txtComment"
			Me.txtComment.ScrollBars = ScrollBars.Vertical
			Dim arg_2D2_0 As Control = Me.txtComment
			size = New Size(747, 61)
			arg_2D2_0.Size = size
			Me.txtComment.TabIndex = 2
			Me.txtComment.WordWrap = False
			Me.Label1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label1.AutoSize = True
			Dim arg_319_0 As Control = Me.Label1
			location = New Point(118, 123)
			arg_319_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_340_0 As Control = Me.Label1
			size = New Size(25, 13)
			arg_340_0.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "ID: "
			Me.Label1.TextAlign = ContentAlignment.MiddleRight
			Me.txtID.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_38F_0 As Control = Me.txtID
			location = New Point(151, 121)
			arg_38F_0.Location = location
			Me.txtID.Name = "txtID"
			Dim arg_3B6_0 As Control = Me.txtID
			size = New Size(100, 21)
			arg_3B6_0.Size = size
			Me.txtID.TabIndex = 4
			Me.txtStart.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_3EB_0 As Control = Me.txtStart
			location = New Point(151, 148)
			arg_3EB_0.Location = location
			Me.txtStart.Name = "txtStart"
			Dim arg_412_0 As Control = Me.txtStart
			size = New Size(100, 21)
			arg_412_0.Size = size
			Me.txtStart.TabIndex = 6
			Me.Label2.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Dim arg_450_0 As Control = Me.Label2
			location = New Point(103, 150)
			arg_450_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_477_0 As Control = Me.Label2
			size = New Size(38, 13)
			arg_477_0.Size = size
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Start: "
			Me.Label2.TextAlign = ContentAlignment.MiddleRight
			Me.txtScrptFile.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_4C9_0 As Control = Me.txtScrptFile
			location = New Point(151, 175)
			arg_4C9_0.Location = location
			Me.txtScrptFile.Name = "txtScrptFile"
			Dim arg_4F3_0 As Control = Me.txtScrptFile
			size = New Size(535, 21)
			arg_4F3_0.Size = size
			Me.txtScrptFile.TabIndex = 8
			Me.Label3.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label3.AutoSize = True
			Dim arg_531_0 As Control = Me.Label3
			location = New Point(84, 177)
			arg_531_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_558_0 As Control = Me.Label3
			size = New Size(55, 13)
			arg_558_0.Size = size
			Me.Label3.TabIndex = 7
			Me.Label3.Text = "ScrptFile: "
			Me.Label3.TextAlign = ContentAlignment.MiddleRight
			Me.txtMnuItemRef.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_5AA_0 As Control = Me.txtMnuItemRef
			location = New Point(151, 202)
			arg_5AA_0.Location = location
			Me.txtMnuItemRef.Name = "txtMnuItemRef"
			Dim arg_5D4_0 As Control = Me.txtMnuItemRef
			size = New Size(352, 21)
			arg_5D4_0.Size = size
			Me.txtMnuItemRef.TabIndex = 10
			Me.Label4.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label4.AutoSize = True
			Dim arg_613_0 As Control = Me.Label4
			location = New Point(63, 204)
			arg_613_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_63A_0 As Control = Me.Label4
			size = New Size(73, 13)
			arg_63A_0.Size = size
			Me.Label4.TabIndex = 9
			Me.Label4.Text = "MnuItemRef: "
			Me.Label4.TextAlign = ContentAlignment.MiddleRight
			Me.Label6.AutoSize = True
			Dim arg_687_0 As Control = Me.Label6
			location = New Point(21, 17)
			arg_687_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_6AE_0 As Control = Me.Label6
			size = New Size(56, 13)
			arg_6AE_0.Size = size
			Me.Label6.TabIndex = 41
			Me.Label6.Text = "Comment:"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(774, 276)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.txtMnuItemRef)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtScrptFile)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtStart)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtID)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.txtComment)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.164948F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgScriptEdit"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Function GetDir(pFileSpec As String) As String
			Dim result As String = ""
			Dim num As Integer = pFileSpec.LastIndexOf("\")
			If num > -1 Then
				result = pFileSpec.Substring(0, num)
			End If
			Return result
		End Function

		Private Function IsOK() As Boolean
			Dim result As Boolean = False
			Dim text As String = Me.txtScrptFile.Text
			If text.Length > 0 Then
				Try
					Dim dir As String = Me.GetDir(text)
					If Not MyProject.Computer.FileSystem.DirectoryExists(dir) Then
						MyProject.Computer.FileSystem.CreateDirectory(dir)
					End If
					If Not MyProject.Computer.FileSystem.FileExists(text) Then
						MyProject.Computer.FileSystem.WriteAllText(text, "<Actions>" & vbCrLf & "</Actions>", False)
					End If
					result = True
				Catch expr_6D As Exception
					ProjectData.SetProjectError(expr_6D)
					Interaction.MsgBox("Khong tao duoc '" + text + "'", MsgBoxStyle.OkOnly, Nothing)
					ProjectData.ClearProjectError()
				End Try
			Else
				result = True
			End If
			Return result
		End Function

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			If Me.IsOK() Then
				Dim cItemScriptDef As CItemScriptDef = Me.myItemScript
				cItemScriptDef.ID = Me.txtID.Text
				cItemScriptDef.Start = Me.txtStart.Text
				cItemScriptDef.ScrptFile = Me.txtScrptFile.Text
				cItemScriptDef.MnuItemRef = Me.txtMnuItemRef.Text
				cItemScriptDef.Comments = New List(Of String)()
				If Me.txtComment.Text.Length > 0 Then
					cItemScriptDef.Comments.Add(Me.txtComment.Text)
				End If
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Function ShowDialog(pParentf As dlgMenuEdit, pItemScript As CItemScriptDef) As DialogResult
			Me.myItemScript = pItemScript
			Return Me.ShowDialog(pParentf)
		End Function

		Private Function GetComment() As String
			Dim text As String = ""
			Try
				Dim enumerator As List(Of String).Enumerator = Me.myItemScript.Comments.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As String = enumerator.Current
					If text.Length = 0 Then
						text = current
					Else
						text = text + vbCrLf + current
					End If
				End While
			Finally
				Dim enumerator As List(Of String).Enumerator
				(CType(enumerator, IDisposable)).Dispose()
			End Try
			Return text
		End Function

		Private Sub dlgScriptEdit_Load(sender As Object, e As EventArgs)
			Me.txtComment.Text = Me.GetComment()
			Dim cItemScriptDef As CItemScriptDef = Me.myItemScript
			Me.txtID.Text = cItemScriptDef.ID
			Me.txtStart.Text = cItemScriptDef.Start
			Me.txtScrptFile.Text = cItemScriptDef.ScrptFile
			Me.txtMnuItemRef.Text = cItemScriptDef.MnuItemRef
		End Sub
	End Class
End Namespace
