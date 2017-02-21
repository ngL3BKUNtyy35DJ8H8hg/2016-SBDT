Imports DBiGraphicObjs.DBiGraphicObjects
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgChangeText
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("txtLabel")>
		Private _txtLabel As TextBox

		Private m_myObj As TextGraphic

		Private m_Pos As Point

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

		Friend Overridable Property txtLabel() As TextBox
			Get
				Return Me._txtLabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtLabel_DoubleClick
				If Me._txtLabel IsNot Nothing Then
					RemoveHandler Me._txtLabel.DoubleClick, value2
				End If
				Me._txtLabel = value
				If Me._txtLabel IsNot Nothing Then
					AddHandler Me._txtLabel.DoubleClick, value2
				End If
			End Set
		End Property

		Public WriteOnly Property myObj() As TextGraphic
			Set(value As TextGraphic)
				Me.m_myObj = value
			End Set
		End Property

		Public Property Pos() As Point
			Get
				Return Me.m_Pos
			End Get
			Set(value As Point)
				Me.m_Pos = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgChangeText_Load
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
			Me.txtLabel = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_D3_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(106, 144)
			arg_D3_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_125_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_125_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_152_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_152_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_179_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_179_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1C3_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1C3_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_1EA_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_1EA_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.txtLabel.Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.txtLabel.ForeColor = SystemColors.InactiveCaptionText
			Dim arg_238_0 As Control = Me.txtLabel
			location = New Point(4, 4)
			arg_238_0.Location = location
			Me.txtLabel.Multiline = True
			Me.txtLabel.Name = "txtLabel"
			Dim arg_271_0 As Control = Me.txtLabel
			size = New Size(254, 134)
			arg_271_0.Size = size
			Me.txtLabel.TabIndex = 2
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(264, 182)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtLabel)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChangeText"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Thay " & ChrW(273) & ChrW(7893) & "i Text"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Dim myObj As TextGraphic = Me.m_myObj
			myObj.Text = Me.txtLabel.Text
			myObj.Font = Me.txtLabel.Font
			myObj.Color = Me.txtLabel.ForeColor
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgChangeText_Load(sender As Object, e As EventArgs)
			Me.Location = Me.m_Pos
			Dim myObj As TextGraphic = Me.m_myObj
			Me.txtLabel.Text = myObj.Text
			Me.txtLabel.Font = myObj.Font
			Me.txtLabel.ForeColor = myObj.Color
		End Sub

		Private Sub txtLabel_DoubleClick(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.txtLabel.Font
			fontDialog.Color = Me.txtLabel.ForeColor
			fontDialog.ShowColor = True
			If fontDialog.ShowDialog() <> DialogResult.Cancel Then
				Me.txtLabel.Font = fontDialog.Font
				Me.txtLabel.ForeColor = fontDialog.Color
			End If
		End Sub
	End Class
End Namespace
