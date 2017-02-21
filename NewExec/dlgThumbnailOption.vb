Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgThumbnailOption
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		<AccessedThroughProperty("txtVerticalSpacing")>
		Private _txtVerticalSpacing As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtHorizontalSpacing")>
		Private _txtHorizontalSpacing As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("txtImageHeight")>
		Private _txtImageHeight As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtImageWidth")>
		Private _txtImageWidth As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

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

		Friend Overridable Property GroupBox2() As GroupBox
			Get
				Return Me._GroupBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		Friend Overridable Property txtVerticalSpacing() As TextBox
			Get
				Return Me._txtVerticalSpacing
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtVerticalSpacing = value
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

		Friend Overridable Property txtHorizontalSpacing() As TextBox
			Get
				Return Me._txtHorizontalSpacing
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtHorizontalSpacing = value
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

		Friend Overridable Property GroupBox1() As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		Friend Overridable Property txtImageHeight() As TextBox
			Get
				Return Me._txtImageHeight
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtImageHeight = value
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

		Friend Overridable Property txtImageWidth() As TextBox
			Get
				Return Me._txtImageWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtImageWidth = value
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

		Public Sub New()
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
			Me.GroupBox2 = New GroupBox()
			Me.txtVerticalSpacing = New TextBox()
			Me.Label3 = New Label()
			Me.txtHorizontalSpacing = New TextBox()
			Me.Label4 = New Label()
			Me.GroupBox1 = New GroupBox()
			Me.txtImageHeight = New TextBox()
			Me.Label2 = New Label()
			Me.txtImageWidth = New TextBox()
			Me.Label1 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_14C_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(61, 232)
			arg_14C_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_19E_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_19E_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1CB_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1CB_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1F2_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1F2_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_23C_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_23C_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_263_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_263_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.GroupBox2.Controls.Add(Me.txtVerticalSpacing)
			Me.GroupBox2.Controls.Add(Me.Label3)
			Me.GroupBox2.Controls.Add(Me.txtHorizontalSpacing)
			Me.GroupBox2.Controls.Add(Me.Label4)
			Dim arg_2EE_0 As Control = Me.GroupBox2
			location = New Point(12, 114)
			arg_2EE_0.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim arg_318_0 As Control = Me.GroupBox2
			size = New Size(194, 96)
			arg_318_0.Size = size
			Me.GroupBox2.TabIndex = 5
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Khoang cach:"
			Dim arg_357_0 As Control = Me.txtVerticalSpacing
			location = New Point(83, 56)
			arg_357_0.Location = location
			Me.txtVerticalSpacing.Name = "txtVerticalSpacing"
			Dim arg_37E_0 As Control = Me.txtVerticalSpacing
			size = New Size(72, 21)
			arg_37E_0.Size = size
			Me.txtVerticalSpacing.TabIndex = 5
			Dim arg_3A1_0 As Control = Me.Label3
			location = New Point(27, 56)
			arg_3A1_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_3C8_0 As Control = Me.Label3
			size = New Size(100, 23)
			arg_3C8_0.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "Doc:"
			Dim arg_3FB_0 As Control = Me.txtHorizontalSpacing
			location = New Point(83, 32)
			arg_3FB_0.Location = location
			Me.txtHorizontalSpacing.Name = "txtHorizontalSpacing"
			Dim arg_422_0 As Control = Me.txtHorizontalSpacing
			size = New Size(72, 21)
			arg_422_0.Size = size
			Me.txtHorizontalSpacing.TabIndex = 3
			Dim arg_445_0 As Control = Me.Label4
			location = New Point(27, 32)
			arg_445_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_46C_0 As Control = Me.Label4
			size = New Size(100, 23)
			arg_46C_0.Size = size
			Me.Label4.TabIndex = 2
			Me.Label4.Text = "Ngang:"
			Me.GroupBox1.Controls.Add(Me.txtImageHeight)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.txtImageWidth)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Dim arg_4F7_0 As Control = Me.GroupBox1
			location = New Point(12, 12)
			arg_4F7_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_521_0 As Control = Me.GroupBox1
			size = New Size(194, 96)
			arg_521_0.Size = size
			Me.GroupBox1.TabIndex = 4
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Kich thuoc:"
			Dim arg_560_0 As Control = Me.txtImageHeight
			location = New Point(85, 56)
			arg_560_0.Location = location
			Me.txtImageHeight.Name = "txtImageHeight"
			Dim arg_587_0 As Control = Me.txtImageHeight
			size = New Size(72, 21)
			arg_587_0.Size = size
			Me.txtImageHeight.TabIndex = 5
			Dim arg_5AA_0 As Control = Me.Label2
			location = New Point(29, 56)
			arg_5AA_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_5D1_0 As Control = Me.Label2
			size = New Size(100, 23)
			arg_5D1_0.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Doc:"
			Dim arg_604_0 As Control = Me.txtImageWidth
			location = New Point(85, 32)
			arg_604_0.Location = location
			Me.txtImageWidth.Name = "txtImageWidth"
			Dim arg_62B_0 As Control = Me.txtImageWidth
			size = New Size(72, 21)
			arg_62B_0.Size = size
			Me.txtImageWidth.TabIndex = 3
			Dim arg_64E_0 As Control = Me.Label1
			location = New Point(29, 32)
			arg_64E_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_675_0 As Control = Me.Label1
			size = New Size(100, 23)
			arg_675_0.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Ngang:"
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(219, 273)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgThumbnailOption"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Thay doi"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
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
