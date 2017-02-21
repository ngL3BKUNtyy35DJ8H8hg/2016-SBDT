Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgOption
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("nudHeight")>
		Private _nudHeight As NumericUpDown

		<AccessedThroughProperty("nudWidth")>
		Private _nudWidth As NumericUpDown

		<AccessedThroughProperty("nudScale")>
		Private _nudScale As NumericUpDown

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("nudGrid")>
		Private _nudGrid As NumericUpDown

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("chkSnap")>
		Private _chkSnap As CheckBox

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

		Friend Overridable Property nudHeight() As NumericUpDown
			Get
				Return Me._nudHeight
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudHeight = value
			End Set
		End Property

		Friend Overridable Property nudWidth() As NumericUpDown
			Get
				Return Me._nudWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudWidth = value
			End Set
		End Property

		Friend Overridable Property nudScale() As NumericUpDown
			Get
				Return Me._nudScale
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudScale = value
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

		Friend Overridable Property nudGrid() As NumericUpDown
			Get
				Return Me._nudGrid
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudGrid = value
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

		Friend Overridable Property Label2() As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
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

		Friend Overridable Property chkSnap() As CheckBox
			Get
				Return Me._chkSnap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSnap = value
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
			Me.nudHeight = New NumericUpDown()
			Me.nudWidth = New NumericUpDown()
			Me.nudScale = New NumericUpDown()
			Me.Label4 = New Label()
			Me.nudGrid = New NumericUpDown()
			Me.Label3 = New Label()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.chkSnap = New CheckBox()
			Me.TableLayoutPanel1.SuspendLayout()
			(CType(Me.nudHeight, ISupportInitialize)).BeginInit()
			(CType(Me.nudWidth, ISupportInitialize)).BeginInit()
			(CType(Me.nudScale, ISupportInitialize)).BeginInit()
			(CType(Me.nudGrid, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_157_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(11, 163)
			arg_157_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1A9_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1A9_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1D6_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1D6_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1FD_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1FD_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_247_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_247_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_26E_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_26E_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_2BD_0 As NumericUpDown = Me.nudHeight
			Dim num As Decimal = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_2BD_0.Increment = num
			Dim arg_2D4_0 As Control = Me.nudHeight
			location = New Point(74, 46)
			arg_2D4_0.Location = location
			Dim arg_30A_0 As NumericUpDown = Me.nudHeight
			num = New Decimal(New Integer() { 1500, 0, 0, 0 })
			arg_30A_0.Maximum = num
			Dim arg_33D_0 As NumericUpDown = Me.nudHeight
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_33D_0.Minimum = num
			Me.nudHeight.Name = "nudHeight"
			Dim arg_364_0 As Control = Me.nudHeight
			size = New Size(48, 21)
			arg_364_0.Size = size
			Me.nudHeight.TabIndex = 55
			Dim arg_3A4_0 As NumericUpDown = Me.nudHeight
			num = New Decimal(New Integer() { 80, 0, 0, 0 })
			arg_3A4_0.Value = num
			Dim arg_3D7_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_3D7_0.Increment = num
			Dim arg_3EE_0 As Control = Me.nudWidth
			location = New Point(74, 22)
			arg_3EE_0.Location = location
			Dim arg_424_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 1500, 0, 0, 0 })
			arg_424_0.Maximum = num
			Dim arg_457_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_457_0.Minimum = num
			Me.nudWidth.Name = "nudWidth"
			Dim arg_47E_0 As Control = Me.nudWidth
			size = New Size(48, 21)
			arg_47E_0.Size = size
			Me.nudWidth.TabIndex = 54
			Dim arg_4BE_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			arg_4BE_0.Value = num
			Dim arg_4D5_0 As Control = Me.nudScale
			location = New Point(74, 94)
			arg_4D5_0.Location = location
			Dim arg_508_0 As NumericUpDown = Me.nudScale
			num = New Decimal(New Integer() { 20, 0, 0, 0 })
			arg_508_0.Maximum = num
			Dim arg_53A_0 As NumericUpDown = Me.nudScale
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_53A_0.Minimum = num
			Me.nudScale.Name = "nudScale"
			Dim arg_561_0 As Control = Me.nudScale
			size = New Size(48, 21)
			arg_561_0.Size = size
			Me.nudScale.TabIndex = 53
			Dim arg_5A0_0 As NumericUpDown = Me.nudScale
			num = New Decimal(New Integer() { 4, 0, 0, 0 })
			arg_5A0_0.Value = num
			Me.Label4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_5D4_0 As Control = Me.Label4
			location = New Point(34, 94)
			arg_5D4_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_5FB_0 As Control = Me.Label4
			size = New Size(40, 16)
			arg_5FB_0.Size = size
			Me.Label4.TabIndex = 52
			Me.Label4.Text = "Scale:"
			Dim arg_62F_0 As Control = Me.nudGrid
			location = New Point(74, 70)
			arg_62F_0.Location = location
			Dim arg_662_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 20, 0, 0, 0 })
			arg_662_0.Maximum = num
			Dim arg_694_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_694_0.Minimum = num
			Me.nudGrid.Name = "nudGrid"
			Dim arg_6BB_0 As Control = Me.nudGrid
			size = New Size(48, 21)
			arg_6BB_0.Size = size
			Me.nudGrid.TabIndex = 51
			Dim arg_6FA_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_6FA_0.Value = num
			Me.Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_72E_0 As Control = Me.Label3
			location = New Point(34, 70)
			arg_72E_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_755_0 As Control = Me.Label3
			size = New Size(40, 16)
			arg_755_0.Size = size
			Me.Label3.TabIndex = 50
			Me.Label3.Text = "Grid:"
			Me.Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_7A6_0 As Control = Me.Label2
			location = New Point(34, 46)
			arg_7A6_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_7CD_0 As Control = Me.Label2
			size = New Size(40, 16)
			arg_7CD_0.Size = size
			Me.Label2.TabIndex = 49
			Me.Label2.Text = "Height:"
			Me.Label1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_81E_0 As Control = Me.Label1
			location = New Point(34, 22)
			arg_81E_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_845_0 As Control = Me.Label1
			size = New Size(40, 16)
			arg_845_0.Size = size
			Me.Label1.TabIndex = 48
			Me.Label1.Text = "Width:"
			Me.chkSnap.AutoSize = True
			Me.chkSnap.Checked = True
			Me.chkSnap.CheckState = CheckState.Checked
			Dim arg_8A0_0 As Control = Me.chkSnap
			location = New Point(37, 131)
			arg_8A0_0.Location = location
			Me.chkSnap.Name = "chkSnap"
			Dim arg_8C7_0 As Control = Me.chkSnap
			size = New Size(50, 17)
			arg_8C7_0.Size = size
			Me.chkSnap.TabIndex = 56
			Me.chkSnap.Text = "Snap"
			Me.chkSnap.UseVisualStyleBackColor = True
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(169, 204)
			Me.ClientSize = size
			Me.Controls.Add(Me.chkSnap)
			Me.Controls.Add(Me.nudHeight)
			Me.Controls.Add(Me.nudWidth)
			Me.Controls.Add(Me.nudScale)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.nudGrid)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgOption"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Option"
			Me.TableLayoutPanel1.ResumeLayout(False)
			(CType(Me.nudHeight, ISupportInitialize)).EndInit()
			(CType(Me.nudWidth, ISupportInitialize)).EndInit()
			(CType(Me.nudScale, ISupportInitialize)).EndInit()
			(CType(Me.nudGrid, ISupportInitialize)).EndInit()
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
