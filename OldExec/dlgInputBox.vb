Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgInputBox
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

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

		Friend Overridable Property TextBox1() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			dlgInputBox.__ENCList.Add(New WeakReference(Me))
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
			Me.Label1 = New Label()
			Me.TextBox1 = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_E8_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(45, 66)
			arg_E8_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_13E_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_13E_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_16F_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_16F_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_199_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_199_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1E9_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1E9_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_213_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_213_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_257_0 As Control = Me.Label1
			location = New Point(14, 12)
			arg_257_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_281_0 As Control = Me.Label1
			size = New Size(45, 13)
			arg_281_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Prompt:"
			Me.TextBox1.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Dim arg_2C6_0 As Control = Me.TextBox1
			location = New Point(12, 28)
			arg_2C6_0.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim arg_2F3_0 As Control = Me.TextBox1
			size = New Size(179, 21)
			arg_2F3_0.Size = size
			Me.TextBox1.TabIndex = 2
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(203, 107)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgInputBox"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Nh" & ChrW(7853) & "p"
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
	End Class
End Namespace
