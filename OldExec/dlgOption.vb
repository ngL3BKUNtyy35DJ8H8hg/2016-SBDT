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
	Public Class dlgOption
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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

		Friend Overridable Property nudHeight() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudHeight
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudHeight = value
			End Set
		End Property

		Friend Overridable Property nudWidth() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudWidth
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudWidth = value
			End Set
		End Property

		Friend Overridable Property nudScale() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudScale
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudScale = value
			End Set
		End Property

		Friend Overridable Property Label4() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property nudGrid() As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._nudGrid
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudGrid = value
			End Set
		End Property

		Friend Overridable Property Label3() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property Label2() As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
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

		Friend Overridable Property chkSnap() As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._chkSnap
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSnap = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			dlgOption.__ENCList.Add(New WeakReference(Me))
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
			Dim arg_16F_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(11, 163)
			arg_16F_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1C5_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1C5_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1F6_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1F6_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_220_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_220_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_270_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_270_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_29A_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_29A_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_2E6_0 As NumericUpDown = Me.nudHeight
			Dim num As Decimal = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_2E6_0.Increment = num
			Dim arg_2FF_0 As Control = Me.nudHeight
			location = New Point(74, 46)
			arg_2FF_0.Location = location
			Dim arg_330_0 As NumericUpDown = Me.nudHeight
			num = New Decimal(New Integer() { 1500, 0, 0, 0 })
			arg_330_0.Maximum = num
			Dim arg_35E_0 As NumericUpDown = Me.nudHeight
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_35E_0.Minimum = num
			Me.nudHeight.Name = "nudHeight"
			Dim arg_388_0 As Control = Me.nudHeight
			size = New Size(48, 21)
			arg_388_0.Size = size
			Me.nudHeight.TabIndex = 55
			Dim arg_3C4_0 As NumericUpDown = Me.nudHeight
			num = New Decimal(New Integer() { 80, 0, 0, 0 })
			arg_3C4_0.Value = num
			Dim arg_3F2_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_3F2_0.Increment = num
			Dim arg_40B_0 As Control = Me.nudWidth
			location = New Point(74, 22)
			arg_40B_0.Location = location
			Dim arg_43C_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 1500, 0, 0, 0 })
			arg_43C_0.Maximum = num
			Dim arg_46A_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 10, 0, 0, 0 })
			arg_46A_0.Minimum = num
			Me.nudWidth.Name = "nudWidth"
			Dim arg_494_0 As Control = Me.nudWidth
			size = New Size(48, 21)
			arg_494_0.Size = size
			Me.nudWidth.TabIndex = 54
			Dim arg_4D0_0 As NumericUpDown = Me.nudWidth
			num = New Decimal(New Integer() { 100, 0, 0, 0 })
			arg_4D0_0.Value = num
			Dim arg_4E9_0 As Control = Me.nudScale
			location = New Point(74, 94)
			arg_4E9_0.Location = location
			Dim arg_517_0 As NumericUpDown = Me.nudScale
			num = New Decimal(New Integer() { 20, 0, 0, 0 })
			arg_517_0.Maximum = num
			Dim arg_544_0 As NumericUpDown = Me.nudScale
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_544_0.Minimum = num
			Me.nudScale.Name = "nudScale"
			Dim arg_56E_0 As Control = Me.nudScale
			size = New Size(48, 21)
			arg_56E_0.Size = size
			Me.nudScale.TabIndex = 53
			Dim arg_5A9_0 As NumericUpDown = Me.nudScale
			num = New Decimal(New Integer() { 4, 0, 0, 0 })
			arg_5A9_0.Value = num
			Me.Label4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_5E0_0 As Control = Me.Label4
			location = New Point(34, 94)
			arg_5E0_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_60A_0 As Control = Me.Label4
			size = New Size(40, 16)
			arg_60A_0.Size = size
			Me.Label4.TabIndex = 52
			Me.Label4.Text = "Scale:"
			Dim arg_642_0 As Control = Me.nudGrid
			location = New Point(74, 70)
			arg_642_0.Location = location
			Dim arg_670_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 20, 0, 0, 0 })
			arg_670_0.Maximum = num
			Dim arg_69D_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_69D_0.Minimum = num
			Me.nudGrid.Name = "nudGrid"
			Dim arg_6C7_0 As Control = Me.nudGrid
			size = New Size(48, 21)
			arg_6C7_0.Size = size
			Me.nudGrid.TabIndex = 51
			Dim arg_702_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_702_0.Value = num
			Me.Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_739_0 As Control = Me.Label3
			location = New Point(34, 70)
			arg_739_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_763_0 As Control = Me.Label3
			size = New Size(40, 16)
			arg_763_0.Size = size
			Me.Label3.TabIndex = 50
			Me.Label3.Text = "Grid:"
			Me.Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_7B9_0 As Control = Me.Label2
			location = New Point(34, 46)
			arg_7B9_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_7E3_0 As Control = Me.Label2
			size = New Size(40, 16)
			arg_7E3_0.Size = size
			Me.Label2.TabIndex = 49
			Me.Label2.Text = "Height:"
			Me.Label1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_839_0 As Control = Me.Label1
			location = New Point(34, 22)
			arg_839_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_863_0 As Control = Me.Label1
			size = New Size(40, 16)
			arg_863_0.Size = size
			Me.Label1.TabIndex = 48
			Me.Label1.Text = "Width:"
			Me.chkSnap.AutoSize = True
			Me.chkSnap.Checked = True
			Me.chkSnap.CheckState = CheckState.Checked
			Dim arg_8C5_0 As Control = Me.chkSnap
			location = New Point(37, 131)
			arg_8C5_0.Location = location
			Me.chkSnap.Name = "chkSnap"
			Dim arg_8EF_0 As Control = Me.chkSnap
			size = New Size(50, 17)
			arg_8EF_0.Size = size
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
