Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgMnuItemEdit
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

		<AccessedThroughProperty("txtName")>
		Private _txtName As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtPosX")>
		Private _txtPosX As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtPosY")>
		Private _txtPosY As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtTitle")>
		Private _txtTitle As TextBox

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		Private myMnuItem As CMnuItemDef

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

		Friend Overridable Property txtName() As TextBox
			Get
				Return Me._txtName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtName = value
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

		Friend Overridable Property txtPosX() As TextBox
			Get
				Return Me._txtPosX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPosX = value
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

		Friend Overridable Property txtPosY() As TextBox
			Get
				Return Me._txtPosY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtPosY = value
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

		Friend Overridable Property Label5() As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
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

		Friend Overridable Property txtTitle() As TextBox
			Get
				Return Me._txtTitle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTitle = value
			End Set
		End Property

		Friend Overridable Property Label7() As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgMnuItemEdit_Load
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
			Me.txtName = New TextBox()
			Me.Label2 = New Label()
			Me.txtPosX = New TextBox()
			Me.Label3 = New Label()
			Me.txtPosY = New TextBox()
			Me.Label4 = New Label()
			Me.Label5 = New Label()
			Me.Label6 = New Label()
			Me.txtTitle = New TextBox()
			Me.Label7 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_15A_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(616, 235)
			arg_15A_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1AC_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1AC_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1D9_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1D9_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_200_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_200_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_24A_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_24A_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_271_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_271_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.txtComment.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_2B1_0 As Control = Me.txtComment
			location = New Point(12, 27)
			arg_2B1_0.Location = location
			Me.txtComment.Multiline = True
			Me.txtComment.Name = "txtComment"
			Me.txtComment.ScrollBars = ScrollBars.Vertical
			Dim arg_2F3_0 As Control = Me.txtComment
			size = New Size(747, 61)
			arg_2F3_0.Size = size
			Me.txtComment.TabIndex = 2
			Me.txtComment.WordWrap = False
			Me.Label1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label1.AutoSize = True
			Dim arg_33A_0 As Control = Me.Label1
			location = New Point(118, 112)
			arg_33A_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_361_0 As Control = Me.Label1
			size = New Size(25, 13)
			arg_361_0.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "ID: "
			Me.Label1.TextAlign = ContentAlignment.MiddleRight
			Me.txtID.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_3B0_0 As Control = Me.txtID
			location = New Point(151, 110)
			arg_3B0_0.Location = location
			Me.txtID.Name = "txtID"
			Dim arg_3D7_0 As Control = Me.txtID
			size = New Size(100, 21)
			arg_3D7_0.Size = size
			Me.txtID.TabIndex = 4
			Me.txtName.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_40C_0 As Control = Me.txtName
			location = New Point(151, 137)
			arg_40C_0.Location = location
			Me.txtName.Name = "txtName"
			Dim arg_436_0 As Control = Me.txtName
			size = New Size(420, 21)
			arg_436_0.Size = size
			Me.txtName.TabIndex = 6
			Me.Label2.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label2.AutoSize = True
			Dim arg_474_0 As Control = Me.Label2
			location = New Point(99, 139)
			arg_474_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_49B_0 As Control = Me.Label2
			size = New Size(41, 13)
			arg_49B_0.Size = size
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Name: "
			Me.Label2.TextAlign = ContentAlignment.MiddleRight
			Me.txtPosX.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_4ED_0 As Control = Me.txtPosX
			location = New Point(151, 164)
			arg_4ED_0.Location = location
			Me.txtPosX.Name = "txtPosX"
			Dim arg_514_0 As Control = Me.txtPosX
			size = New Size(100, 21)
			arg_514_0.Size = size
			Me.txtPosX.TabIndex = 8
			Me.Label3.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label3.AutoSize = True
			Dim arg_552_0 As Control = Me.Label3
			location = New Point(104, 166)
			arg_552_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_579_0 As Control = Me.Label3
			size = New Size(37, 13)
			arg_579_0.Size = size
			Me.Label3.TabIndex = 7
			Me.Label3.Text = "PosX: "
			Me.Label3.TextAlign = ContentAlignment.MiddleRight
			Me.txtPosY.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_5CB_0 As Control = Me.txtPosY
			location = New Point(151, 191)
			arg_5CB_0.Location = location
			Me.txtPosY.Name = "txtPosY"
			Dim arg_5F2_0 As Control = Me.txtPosY
			size = New Size(100, 21)
			arg_5F2_0.Size = size
			Me.txtPosY.TabIndex = 10
			Me.Label4.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label4.AutoSize = True
			Dim arg_631_0 As Control = Me.Label4
			location = New Point(103, 193)
			arg_631_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_658_0 As Control = Me.Label4
			size = New Size(37, 13)
			arg_658_0.Size = size
			Me.Label4.TabIndex = 9
			Me.Label4.Text = "PosY: "
			Me.Label4.TextAlign = ContentAlignment.MiddleRight
			Me.Label5.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Label5.ForeColor = SystemColors.ActiveCaption
			Dim arg_6BC_0 As Control = Me.Label5
			location = New Point(272, 171)
			arg_6BC_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_6E6_0 As Control = Me.Label5
			size = New Size(216, 36)
			arg_6E6_0.Size = size
			Me.Label5.TabIndex = 39
			Me.Label5.Text = "(Mu" & ChrW(7889) & "n không hi" & ChrW(7879) & "n MenuItem thì cho PosX=0 và PosY=0)"
			Me.Label5.TextAlign = ContentAlignment.MiddleCenter
			Me.Label6.AutoSize = True
			Dim arg_733_0 As Control = Me.Label6
			location = New Point(12, 9)
			arg_733_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_75A_0 As Control = Me.Label6
			size = New Size(56, 13)
			arg_75A_0.Size = size
			Me.Label6.TabIndex = 40
			Me.Label6.Text = "Comment:"
			Me.txtTitle.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Dim arg_7A0_0 As Control = Me.txtTitle
			location = New Point(151, 218)
			arg_7A0_0.Location = location
			Me.txtTitle.Name = "txtTitle"
			Dim arg_7CA_0 As Control = Me.txtTitle
			size = New Size(420, 21)
			arg_7CA_0.Size = size
			Me.txtTitle.TabIndex = 42
			Me.Label7.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Label7.AutoSize = True
			Dim arg_809_0 As Control = Me.Label7
			location = New Point(106, 221)
			arg_809_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_830_0 As Control = Me.Label7
			size = New Size(34, 13)
			arg_830_0.Size = size
			Me.Label7.TabIndex = 41
			Me.Label7.Text = "Title: "
			Me.Label7.TextAlign = ContentAlignment.MiddleRight
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(774, 276)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtTitle)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.txtPosY)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtPosX)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtName)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtID)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.txtComment)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.164948F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgMnuItemEdit"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Menu"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Dim cMnuItemDef As CMnuItemDef = Me.myMnuItem
			cMnuItemDef.ID = Me.txtID.Text
			cMnuItemDef.Name = Me.txtName.Text
			cMnuItemDef.Title = Me.txtName.Text
			' The following expression was wrapped in a checked-statement
			cMnuItemDef.PosX = CInt(Math.Round(Conversion.Val(Me.txtPosX.Text)))
			cMnuItemDef.PosY = CInt(Math.Round(Conversion.Val(Me.txtPosY.Text)))
			cMnuItemDef.Comments = New List(Of String)()
			If Me.txtComment.Text.Length > 0 Then
				cMnuItemDef.Comments.Add(Me.txtComment.Text)
			End If
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Public Function ShowDialog(pParentf As dlgMenuEdit, pMnuItem As CMnuItemDef) As DialogResult
			Me.myMnuItem = pMnuItem
			Return Me.ShowDialog(pParentf)
		End Function

		Private Function GetComment() As String
			Dim text As String = ""
			Try
				Dim enumerator As List(Of String).Enumerator = Me.myMnuItem.Comments.GetEnumerator()
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

		Private Sub dlgMnuItemEdit_Load(sender As Object, e As EventArgs)
			Me.txtComment.Text = Me.GetComment()
			Dim cMnuItemDef As CMnuItemDef = Me.myMnuItem
			Me.txtID.Text = cMnuItemDef.ID
			Me.txtName.Text = cMnuItemDef.Name
			Me.txtTitle.Text = cMnuItemDef.Title
			Me.txtPosX.Text = Conversions.ToString(cMnuItemDef.PosX)
			Me.txtPosY.Text = Conversions.ToString(cMnuItemDef.PosY)
		End Sub
	End Class
End Namespace
