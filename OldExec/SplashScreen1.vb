Imports BdTC.My
Imports BdTC.My.Resources
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
	Public Class SplashScreen1
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("ApplicationTitle")>
		Private _ApplicationTitle As Label

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

		Friend Overridable Property ApplicationTitle() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._ApplicationTitle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._ApplicationTitle = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.SplashScreen1_Load
			SplashScreen1.__ENCList.Add(New WeakReference(Me))
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
			Me.Label1 = New Label()
			Me.ApplicationTitle = New Label()
			Me.SuspendLayout()
			Me.Label1.BackColor = Color.Transparent
			Me.Label1.Dock = DockStyle.Bottom
			Me.Label1.Image = Resources.progbar
			Dim arg_64_0 As Control = Me.Label1
			Dim location As Point = New Point(0, 257)
			arg_64_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_91_0 As Control = Me.Label1
			Dim size As Size = New Size(496, 18)
			arg_91_0.Size = size
			Me.Label1.TabIndex = 2
			Me.ApplicationTitle.BackColor = Color.Transparent
			Me.ApplicationTitle.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
			Me.ApplicationTitle.ForeColor = Color.Red
			Dim arg_FA_0 As Control = Me.ApplicationTitle
			location = New Point(44, 204)
			arg_FA_0.Location = location
			Me.ApplicationTitle.Name = "ApplicationTitle"
			Dim arg_127_0 As Control = Me.ApplicationTitle
			size = New Size(423, 53)
			arg_127_0.Size = size
			Me.ApplicationTitle.TabIndex = 3
			Me.ApplicationTitle.Text = "ApplicationTitle"
			Me.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackgroundImage = Resources.Bando1
			Me.BackgroundImageLayout = ImageLayout.Stretch
			size = New Size(496, 275)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.ApplicationTitle)
			Me.Controls.Add(Me.Label1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SplashScreen1"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.ResumeLayout(False)
		End Sub

		Private Sub SplashScreen1_Load(sender As Object, e As EventArgs)
			Me.ApplicationTitle.Text = MySettingsProperty.Settings.myTenCT
		End Sub
	End Class
End Namespace
