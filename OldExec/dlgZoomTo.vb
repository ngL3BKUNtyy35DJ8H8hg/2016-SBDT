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
	Public Class dlgZoomTo
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("txtLat")>
		Private _txtLat As TextBox

		<AccessedThroughProperty("txtLon")>
		Private _txtLon As TextBox

		<AccessedThroughProperty("txtZoomLevel")>
		Private _txtZoomLevel As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		Private myBanDo As CBanDo

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

		Friend Overridable Property txtLat() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtLat
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtLat = value
			End Set
		End Property

		Friend Overridable Property txtLon() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtLon
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtLon = value
			End Set
		End Property

		Friend Overridable Property txtZoomLevel() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtZoomLevel
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtZoomLevel = value
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

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgZoomTo_Load
			dlgZoomTo.__ENCList.Add(New WeakReference(Me))
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
			Me.txtLat = New TextBox()
			Me.txtLon = New TextBox()
			Me.txtZoomLevel = New TextBox()
			Me.Label4 = New Label()
			Me.Label3 = New Label()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_124_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(49, 111)
			arg_124_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_17A_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_17A_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1AB_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1AB_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1D5_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1D5_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_225_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_225_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_24F_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_24F_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_286_0 As Control = Me.txtLat
			location = New Point(111, 76)
			arg_286_0.Location = location
			Me.txtLat.Name = "txtLat"
			Dim arg_2B0_0 As Control = Me.txtLat
			size = New Size(80, 21)
			arg_2B0_0.Size = size
			Me.txtLat.TabIndex = 9
			Dim arg_2D7_0 As Control = Me.txtLon
			location = New Point(111, 52)
			arg_2D7_0.Location = location
			Me.txtLon.Name = "txtLon"
			Dim arg_301_0 As Control = Me.txtLon
			size = New Size(80, 21)
			arg_301_0.Size = size
			Me.txtLon.TabIndex = 7
			Dim arg_327_0 As Control = Me.txtZoomLevel
			location = New Point(111, 12)
			arg_327_0.Location = location
			Me.txtZoomLevel.Name = "txtZoomLevel"
			Dim arg_351_0 As Control = Me.txtZoomLevel
			size = New Size(80, 21)
			arg_351_0.Size = size
			Me.txtZoomLevel.TabIndex = 6
			Dim arg_377_0 As Control = Me.Label4
			location = New Point(15, 43)
			arg_377_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_3A1_0 As Control = Me.Label4
			size = New Size(64, 16)
			arg_3A1_0.Size = size
			Me.Label4.TabIndex = 10
			Me.Label4.Text = "Trung tâm:"
			Dim arg_3D9_0 As Control = Me.Label3
			location = New Point(80, 52)
			arg_3D9_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_403_0 As Control = Me.Label3
			size = New Size(25, 16)
			arg_403_0.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "X:"
			Dim arg_43A_0 As Control = Me.Label2
			location = New Point(80, 76)
			arg_43A_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_464_0 As Control = Me.Label2
			size = New Size(25, 16)
			arg_464_0.Size = size
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Y:"
			Dim arg_49B_0 As Control = Me.Label1
			location = New Point(15, 12)
			arg_49B_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_4C5_0 As Control = Me.Label1
			size = New Size(96, 16)
			arg_4C5_0.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = ChrW(272) & ChrW(7897) & " phóng (mét):"
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(207, 152)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtLat)
			Me.Controls.Add(Me.txtLon)
			Me.Controls.Add(Me.txtZoomLevel)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgZoomTo"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Phóng b" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Me.myBanDo.myMap.ZoomTo(Conversions.ToDouble(Me.txtZoomLevel.Text), Conversions.ToDouble(Me.txtLon.Text), Conversions.ToDouble(Me.txtLat.Text))
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgZoomTo_Load(sender As Object, e As EventArgs)
			Me.myBanDo = myModule.fMain.myBando
			Me.txtZoomLevel.Text = Conversions.ToString(Me.myBanDo.myMap.Zoom)
			Me.txtLon.Text = Conversions.ToString(Me.myBanDo.myMap.CenterX)
			Me.txtLat.Text = Conversions.ToString(Me.myBanDo.myMap.CenterY)
		End Sub
	End Class
End Namespace
