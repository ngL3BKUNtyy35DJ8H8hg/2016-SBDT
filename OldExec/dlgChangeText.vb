Imports DBiGraphicObjs.DBiGraphicObjects
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
	Public Class dlgChangeText
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("txtLabel")>
		Private _txtLabel As TextBox

		Private m_TextObj As TextGraphic

		Private m_Pos As Point

		Friend Overridable Property txtLabel() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtLabel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtLabel IsNot Nothing
				If flag Then
					RemoveHandler Me._txtLabel.DoubleClick, AddressOf Me.txtLabel_DoubleClick
				End If
				Me._txtLabel = value
				flag = (Me._txtLabel IsNot Nothing)
				If flag Then
					AddHandler Me._txtLabel.DoubleClick, AddressOf Me.txtLabel_DoubleClick
				End If
			End Set
		End Property

		Public Property TextObj() As TextGraphic
			Get
				Return Me.m_TextObj
			End Get
			Set(value As TextGraphic)
				Me.m_TextObj = value
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

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgChangeText_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgChangeText_Load
			dlgChangeText.__ENCList.Add(New WeakReference(Me))
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
			Me.txtLabel = New TextBox()
			Me.SuspendLayout()
			Me.txtLabel.Dock = DockStyle.Fill
			Me.txtLabel.ForeColor = SystemColors.InactiveCaptionText
			Dim arg_43_0 As Control = Me.txtLabel
			Dim location As Point = New Point(0, 0)
			arg_43_0.Location = location
			Me.txtLabel.Multiline = True
			Me.txtLabel.Name = "txtLabel"
			Dim arg_7D_0 As Control = Me.txtLabel
			Dim size As Size = New Size(240, 110)
			arg_7D_0.Size = size
			Me.txtLabel.TabIndex = 2
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(240, 110)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtLabel)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgChangeText"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Nh" & ChrW(7853) & "p Text:"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub dlgChangeText_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.m_TextObj.Text = Me.txtLabel.Text
			Me.m_TextObj.Font = Me.txtLabel.Font
			Me.m_TextObj.Color = Me.txtLabel.ForeColor
		End Sub

		Private Sub dlgChangeText_Load(sender As Object, e As EventArgs)
			Me.Location = Me.m_Pos
			Me.txtLabel.Text = Me.m_TextObj.Text
			Me.txtLabel.Font = Me.m_TextObj.Font
			Me.txtLabel.ForeColor = Me.m_TextObj.Color
		End Sub

		Private Sub txtLabel_DoubleClick(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.txtLabel.Font
			fontDialog.Color = Me.txtLabel.ForeColor
			fontDialog.ShowColor = True
			Dim flag As Boolean = fontDialog.ShowDialog() <> DialogResult.Cancel
			If flag Then
				Me.txtLabel.Font = fontDialog.Font
				Me.txtLabel.ForeColor = fontDialog.Color
			End If
		End Sub
	End Class
End Namespace
