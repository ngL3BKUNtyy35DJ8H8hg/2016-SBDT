Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgZoomTo
		Inherits Form

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

		<AccessedThroughProperty("txtMapScale")>
		Private _txtMapScale As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

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

		Friend Overridable Property txtLat() As TextBox
			Get
				Return Me._txtLat
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtLat = value
			End Set
		End Property

		Friend Overridable Property txtLon() As TextBox
			Get
				Return Me._txtLon
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtLon = value
			End Set
		End Property

		Friend Overridable Property txtZoomLevel() As TextBox
			Get
				Return Me._txtZoomLevel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtZoomLevel_Validated
				Dim value3 As KeyEventHandler = AddressOf Me.txtZoomLevel_KeyUp
				If Me._txtZoomLevel IsNot Nothing Then
					RemoveHandler Me._txtZoomLevel.Validated, value2
					RemoveHandler Me._txtZoomLevel.KeyUp, value3
				End If
				Me._txtZoomLevel = value
				If Me._txtZoomLevel IsNot Nothing Then
					AddHandler Me._txtZoomLevel.Validated, value2
					AddHandler Me._txtZoomLevel.KeyUp, value3
				End If
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

		Friend Overridable Property txtMapScale() As TextBox
			Get
				Return Me._txtMapScale
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtMapScale_KeyUp
				Dim value3 As EventHandler = AddressOf Me.txtMapScale_Validated
				If Me._txtMapScale IsNot Nothing Then
					RemoveHandler Me._txtMapScale.KeyUp, value2
					RemoveHandler Me._txtMapScale.Validated, value3
				End If
				Me._txtMapScale = value
				If Me._txtMapScale IsNot Nothing Then
					AddHandler Me._txtMapScale.KeyUp, value2
					AddHandler Me._txtMapScale.Validated, value3
				End If
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

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgZoomTo_Load
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
			Me.txtLat = New TextBox()
			Me.txtLon = New TextBox()
			Me.txtZoomLevel = New TextBox()
			Me.Label4 = New Label()
			Me.Label3 = New Label()
			Me.Label2 = New Label()
			Me.Label1 = New Label()
			Me.txtMapScale = New TextBox()
			Me.Label5 = New Label()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_12B_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(49, 159)
			arg_12B_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_17D_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_17D_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1AA_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1AA_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1D1_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1D1_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_21B_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_21B_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_242_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_242_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Dim arg_275_0 As Control = Me.txtLat
			location = New Point(112, 117)
			arg_275_0.Location = location
			Me.txtLat.Name = "txtLat"
			Dim arg_29C_0 As Control = Me.txtLat
			size = New Size(80, 21)
			arg_29C_0.Size = size
			Me.txtLat.TabIndex = 9
			Dim arg_2C0_0 As Control = Me.txtLon
			location = New Point(112, 93)
			arg_2C0_0.Location = location
			Me.txtLon.Name = "txtLon"
			Dim arg_2E7_0 As Control = Me.txtLon
			size = New Size(80, 21)
			arg_2E7_0.Size = size
			Me.txtLon.TabIndex = 7
			Dim arg_30A_0 As Control = Me.txtZoomLevel
			location = New Point(112, 53)
			arg_30A_0.Location = location
			Me.txtZoomLevel.Name = "txtZoomLevel"
			Dim arg_331_0 As Control = Me.txtZoomLevel
			size = New Size(80, 21)
			arg_331_0.Size = size
			Me.txtZoomLevel.TabIndex = 6
			Dim arg_354_0 As Control = Me.Label4
			location = New Point(16, 84)
			arg_354_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_37B_0 As Control = Me.Label4
			size = New Size(64, 16)
			arg_37B_0.Size = size
			Me.Label4.TabIndex = 10
			Me.Label4.Text = "Trung tâm:"
			Dim arg_3AF_0 As Control = Me.Label3
			location = New Point(81, 93)
			arg_3AF_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_3D6_0 As Control = Me.Label3
			size = New Size(25, 16)
			arg_3D6_0.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "X:"
			Dim arg_409_0 As Control = Me.Label2
			location = New Point(81, 117)
			arg_409_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_430_0 As Control = Me.Label2
			size = New Size(25, 16)
			arg_430_0.Size = size
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Y:"
			Dim arg_463_0 As Control = Me.Label1
			location = New Point(16, 53)
			arg_463_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_48A_0 As Control = Me.Label1
			size = New Size(96, 16)
			arg_48A_0.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = ChrW(272) & ChrW(7897) & " phóng (mét):"
			Dim arg_4BD_0 As Control = Me.txtMapScale
			location = New Point(112, 12)
			arg_4BD_0.Location = location
			Me.txtMapScale.Name = "txtMapScale"
			Dim arg_4E4_0 As Control = Me.txtMapScale
			size = New Size(80, 21)
			arg_4E4_0.Size = size
			Me.txtMapScale.TabIndex = 11
			Dim arg_508_0 As Control = Me.Label5
			location = New Point(16, 12)
			arg_508_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_52F_0 As Control = Me.Label5
			size = New Size(96, 16)
			arg_52F_0.Size = size
			Me.Label5.TabIndex = 12
			Me.Label5.Text = "T" & ChrW(7927) & " l" & ChrW(7879) & " (1:xxxxxx):"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(207, 200)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtMapScale)
			Me.Controls.Add(Me.Label5)
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
			myModule.fMain.AxMap1.ZoomTo(Conversions.ToDouble(Me.txtZoomLevel.Text), Conversions.ToDouble(Me.txtLon.Text), Conversions.ToDouble(Me.txtLat.Text))
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgZoomTo_Load(sender As Object, e As EventArgs)
			Me.txtMapScale.Text = Conversions.ToString(modBanDo.GetTyLeBD(myModule.fMain.AxMap1, myModule.fMain.AxMap1.Zoom))
			Me.txtZoomLevel.Text = Conversions.ToString(myModule.fMain.AxMap1.Zoom)
			Me.txtLon.Text = Conversions.ToString(myModule.fMain.AxMap1.CenterX)
			Me.txtLat.Text = Conversions.ToString(myModule.fMain.AxMap1.CenterY)
		End Sub

		Private Sub txtMapScale_Validated(sender As Object, e As EventArgs)
			Me.txtZoomLevel.Text = Conversions.ToString(modBanDo.GetZoomLevel(myModule.fMain.AxMap1, Conversions.ToInteger(Me.txtMapScale.Text)))
		End Sub

		Private Sub txtZoomLevel_Validated(sender As Object, e As EventArgs)
			Me.txtMapScale.Text = Conversions.ToString(modBanDo.GetTyLeBD(myModule.fMain.AxMap1, Conversions.ToDouble(Me.txtZoomLevel.Text)))
		End Sub

		Private Sub txtMapScale_KeyUp(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				SendKeys.Send("{TAB}")
			End If
		End Sub

		Private Sub txtZoomLevel_KeyUp(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.[Return] Then
				SendKeys.Send("{TAB}")
			End If
		End Sub
	End Class
End Namespace
