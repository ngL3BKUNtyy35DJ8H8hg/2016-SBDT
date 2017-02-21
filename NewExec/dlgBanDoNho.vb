Imports AxMapXLib
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgBanDoNho
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("ContextMenu1")>
		Private _ContextMenu1 As ContextMenu

		<AccessedThroughProperty("MnuArrow")>
		Private _MnuArrow As MenuItem

		<AccessedThroughProperty("MenuItem1")>
		Private _MenuItem1 As MenuItem

		<AccessedThroughProperty("MnuPan")>
		Private _MnuPan As MenuItem

		<AccessedThroughProperty("MnuZoomIn")>
		Private _MnuZoomIn As MenuItem

		<AccessedThroughProperty("MnuZoomOut")>
		Private _MnuZoomOut As MenuItem

		<AccessedThroughProperty("MenuItem4")>
		Private _MenuItem4 As MenuItem

		<AccessedThroughProperty("MnuLayers")>
		Private _MnuLayers As MenuItem

		<AccessedThroughProperty("MenuItem7")>
		Private _MenuItem7 As MenuItem

		<AccessedThroughProperty("MnuSaveGeoSet")>
		Private _MnuSaveGeoSet As MenuItem

		<AccessedThroughProperty("AxMap1")>
		Private _AxMap1 As AxMap

		Private fHinhChuNhat As Feature

		Friend Overridable Property ContextMenu1() As ContextMenu
			Get
				Return Me._ContextMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Friend Overridable Property MnuArrow() As MenuItem
			Get
				Return Me._MnuArrow
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuArrow_Click
				If Me._MnuArrow IsNot Nothing Then
					RemoveHandler Me._MnuArrow.Click, value2
				End If
				Me._MnuArrow = value
				If Me._MnuArrow IsNot Nothing Then
					AddHandler Me._MnuArrow.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem1() As MenuItem
			Get
				Return Me._MenuItem1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem1 = value
			End Set
		End Property

		Friend Overridable Property MnuPan() As MenuItem
			Get
				Return Me._MnuPan
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuPan_Click
				If Me._MnuPan IsNot Nothing Then
					RemoveHandler Me._MnuPan.Click, value2
				End If
				Me._MnuPan = value
				If Me._MnuPan IsNot Nothing Then
					AddHandler Me._MnuPan.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MnuZoomIn() As MenuItem
			Get
				Return Me._MnuZoomIn
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuZoomIn_Click
				If Me._MnuZoomIn IsNot Nothing Then
					RemoveHandler Me._MnuZoomIn.Click, value2
				End If
				Me._MnuZoomIn = value
				If Me._MnuZoomIn IsNot Nothing Then
					AddHandler Me._MnuZoomIn.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MnuZoomOut() As MenuItem
			Get
				Return Me._MnuZoomOut
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuZoomOut_Click
				If Me._MnuZoomOut IsNot Nothing Then
					RemoveHandler Me._MnuZoomOut.Click, value2
				End If
				Me._MnuZoomOut = value
				If Me._MnuZoomOut IsNot Nothing Then
					AddHandler Me._MnuZoomOut.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem4() As MenuItem
			Get
				Return Me._MenuItem4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem4 = value
			End Set
		End Property

		Friend Overridable Property MnuLayers() As MenuItem
			Get
				Return Me._MnuLayers
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuLayers_Click
				If Me._MnuLayers IsNot Nothing Then
					RemoveHandler Me._MnuLayers.Click, value2
				End If
				Me._MnuLayers = value
				If Me._MnuLayers IsNot Nothing Then
					AddHandler Me._MnuLayers.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem7() As MenuItem
			Get
				Return Me._MenuItem7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem7 = value
			End Set
		End Property

		Friend Overridable Property MnuSaveGeoSet() As MenuItem
			Get
				Return Me._MnuSaveGeoSet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.MnuSaveGeoSet_Click
				If Me._MnuSaveGeoSet IsNot Nothing Then
					RemoveHandler Me._MnuSaveGeoSet.Click, value2
				End If
				Me._MnuSaveGeoSet = value
				If Me._MnuSaveGeoSet IsNot Nothing Then
					AddHandler Me._MnuSaveGeoSet.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property AxMap1() As AxMap
			Get
				Return Me._AxMap1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxMap)
				Dim value2 As AxMapXLib.CMapXEvents_MouseUpEventHandler = AddressOf Me.AxMap1_MouseUpEvent
				Dim value3 As AxMapXLib.CMapXEvents_MouseMoveEventHandler = AddressOf Me.AxMap1_MouseMoveEvent
				Dim value4 As AxMapXLib.CMapXEvents_MouseDownEventHandler = AddressOf Me.AxMap1_MouseDownEvent
				If Me._AxMap1 IsNot Nothing Then
					RemoveHandler Me._AxMap1.MouseUpEvent, value2
					RemoveHandler Me._AxMap1.MouseMoveEvent, value3
					RemoveHandler Me._AxMap1.MouseDownEvent, value4
				End If
				Me._AxMap1 = value
				If Me._AxMap1 IsNot Nothing Then
					AddHandler Me._AxMap1.MouseUpEvent, value2
					AddHandler Me._AxMap1.MouseMoveEvent, value3
					AddHandler Me._AxMap1.MouseDownEvent, value4
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Closing, AddressOf Me.frmBanDoNho_Closing
			AddHandler MyBase.Load, AddressOf Me.dlgBanDoNho_Load
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
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(dlgBanDoNho))
			Me.ContextMenu1 = New ContextMenu()
			Me.MnuArrow = New MenuItem()
			Me.MenuItem1 = New MenuItem()
			Me.MnuPan = New MenuItem()
			Me.MnuZoomIn = New MenuItem()
			Me.MnuZoomOut = New MenuItem()
			Me.MenuItem4 = New MenuItem()
			Me.MnuLayers = New MenuItem()
			Me.MenuItem7 = New MenuItem()
			Me.MnuSaveGeoSet = New MenuItem()
			Me.AxMap1 = New AxMap()
			(CType(Me.AxMap1, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.ContextMenu1.MenuItems.AddRange(New MenuItem() { Me.MnuArrow, Me.MenuItem1, Me.MnuPan, Me.MnuZoomIn, Me.MnuZoomOut, Me.MenuItem4, Me.MnuLayers, Me.MenuItem7, Me.MnuSaveGeoSet })
			Me.MnuArrow.Index = 0
			Me.MnuArrow.Text = "M" & ChrW(361) & "i tên"
			Me.MenuItem1.Index = 1
			Me.MenuItem1.Text = "-"
			Me.MnuPan.Index = 2
			Me.MnuPan.Text = "Tr" & ChrW(432) & ChrW(7907) & "t"
			Me.MnuZoomIn.Index = 3
			Me.MnuZoomIn.Text = "Phóng to"
			Me.MnuZoomOut.Index = 4
			Me.MnuZoomOut.Text = "Thu nh" & ChrW(7887)
			Me.MenuItem4.Index = 5
			Me.MenuItem4.Text = "-"
			Me.MnuLayers.Index = 6
			Me.MnuLayers.Text = "Các l" & ChrW(7899) & "p B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.MenuItem7.Index = 7
			Me.MenuItem7.Text = "-"
			Me.MnuSaveGeoSet.Index = 8
			Me.MnuSaveGeoSet.Text = "L" & ChrW(432) & "u c" & ChrW(7845) & "u hình B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891)
			Me.AxMap1.Dock = DockStyle.Fill
			Me.AxMap1.Enabled = True
			Dim arg_228_0 As Control = Me.AxMap1
			Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
			arg_228_0.Location = location
			Me.AxMap1.Name = "AxMap1"
			Me.AxMap1.OcxState = CType(componentResourceManager.GetObject("AxMap1.OcxState"), AxHost.State)
			Dim arg_271_0 As Control = Me.AxMap1
			Dim size As Size = New Size(231, 240)
			arg_271_0.Size = size
			Me.AxMap1.TabIndex = 1
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(231, 240)
			Me.ClientSize = size
			Me.Controls.Add(Me.AxMap1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgBanDoNho"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "BanDoNho"
			Me.TopMost = True
			(CType(Me.AxMap1, ISupportInitialize)).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private Sub InitHinhChuNhat()
			Dim animationLayer As Layer = Me.AxMap1.Layers.CreateLayer("tempAnimate", Missing.Value, 1, Missing.Value, Missing.Value)
			Me.AxMap1.Layers.AnimationLayer = animationLayer
			Dim style As Style = New StyleClass()
			style.LineWidth = 1S
			style.LineColor = UInteger.Parse(Conversions.ToString(255))
			Dim points As Points = New PointsClass()
			Dim point As MapXLib.Point = New PointClass()
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			points.Add(point, Missing.Value)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMin)
			points.Add(point, Missing.Value)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMax)
			points.Add(point, Missing.Value)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMax)
			points.Add(point, Missing.Value)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			points.Add(point, Missing.Value)
			Me.fHinhChuNhat = Me.AxMap1.Layers("tempAnimate").AddFeature(Me.AxMap1.FeatureFactory.CreateLine(points, style), Missing.Value)
		End Sub

		Public Sub UpdateHinhChuNhat()
			Dim points As Points = Me.fHinhChuNhat.Parts(1)
			Dim point As MapXLib.Point = points(1)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			point = points(2)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMin)
			point = points(3)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMax)
			point = points(4)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMax)
			point = points(5)
			point.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			Me.fHinhChuNhat.Update(Missing.Value, Missing.Value)
		End Sub

		Private Sub dlgBanDoNho_Load(sender As Object, e As EventArgs)
			modBanDo.fBanDoNho = Me
			Dim num As Integer = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoLeft", "0"))
			Dim num2 As Integer = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoTop", "0"))
			If num > myModule.intMonitorW Then
				num = 0
			End If
			If num2 > myModule.intMonitorH Then
				num2 = 0
			End If
			Me.Left = num
			Me.Top = num2
			Me.Width = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoWidth", Me.Width.ToString()))
			Me.Height = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoHeight", Me.Height.ToString()))
			Try
				Me.AxMap1.GeoSet = modBanDo.myMapNhoGst
				Me.AxMap1.Title.Visible = False
				Me.AxMap1.InfotipSupport = False
				Dim displayCoordSys As CoordSys = Me.AxMap1.DisplayCoordSys
				Me.AxMap1.NumericCoordSys = displayCoordSys
				Me.AxMap1.NumericCoordSys.[Set](CType(modBanDo.myCoordSysType, CoordSysTypeConstants), Me.AxMap1.NumericCoordSys.Datum, Me.AxMap1.NumericCoordSys.Units, Me.AxMap1.NumericCoordSys.OriginLongitude, Me.AxMap1.NumericCoordSys.OriginLatitude, Me.AxMap1.NumericCoordSys.StandardParallelOne, Me.AxMap1.NumericCoordSys.StandardParallelTwo, Me.AxMap1.NumericCoordSys.Azimuth, Me.AxMap1.NumericCoordSys.ScaleFactor, Me.AxMap1.NumericCoordSys.FalseEasting, Me.AxMap1.NumericCoordSys.FalseNorthing, Me.AxMap1.NumericCoordSys.Range, Missing.Value, Missing.Value)
				Me.AxMap1.PaperUnit = PaperUnitConstants.miPaperUnitPoint
			Catch arg_215_0 As Exception
				ProjectData.SetProjectError(arg_215_0)
				ProjectData.ClearProjectError()
			End Try
			myModule.fMain.bBanDo2Loaded = True
			myModule.fMain.ToolStripMenuBDView.Checked = True
			Me.InitHinhChuNhat()
		End Sub

		Private Sub frmBanDoNho_Closing(sender As Object, e As CancelEventArgs)
			If Me.WindowState <> FormWindowState.Minimized Or Me.WindowState <> FormWindowState.Maximized Then
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoLeft", Me.Left.ToString())
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoTop", Me.Top.ToString())
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoWidth", Me.Width.ToString())
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoHeight", Me.Height.ToString())
			End If
			myModule.fMain.bBanDo2Loaded = False
			myModule.fMain.ToolStripMenuBDView.Checked = False
			modBanDo.fBanDoNho = Nothing
		End Sub

		Private Sub AxMap1_MouseDownEvent(sender As Object, e As CMapXEvents_MouseDownEvent)
			If e.button = 1S And Me.AxMap1.CurrentTool = ToolConstants.miArrowTool Then
				Dim x As Double
				Dim y As Double
				Me.AxMap1.ConvertCoord(e.x, e.y, x, y, ConversionConstants.miScreenToMap)
				myModule.fMain.AxMap1.ZoomTo(myModule.fMain.AxMap1.Zoom, x, y)
			End If
		End Sub

		Private Sub AxMap1_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			Dim num As Double
			Dim num2 As Double
			Me.AxMap1.ConvertCoord(e.x, e.y, num, num2, ConversionConstants.miScreenToMap)
			Me.Text = "X:" + Strings.Format(num, "000.000") + " Y:" + Strings.Format(num2, "00.000")
			If e.button = 1S And Me.AxMap1.CurrentTool = ToolConstants.miArrowTool Then
				myModule.fMain.AxMap1.ZoomTo(myModule.fMain.AxMap1.Zoom, num, num2)
			End If
		End Sub

		Private Sub AxMap1_MouseUpEvent(sender As Object, e As CMapXEvents_MouseUpEvent)
			If e.button = 2S Then
				' The following expression was wrapped in a checked-expression
				Dim pos As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
				Me.ContextMenu1.Show(Me, pos)
			End If
		End Sub

		Private Sub MnuZoomIn_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miZoomInTool
		End Sub

		Private Sub MnuZoomOut_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miZoomOutTool
		End Sub

		Private Sub MnuPan_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miPanTool
		End Sub

		Private Sub MnuArrow_Click(sender As Object, e As EventArgs)
			Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
		End Sub

		Private Sub MnuLayers_Click(sender As Object, e As EventArgs)
			If Me.AxMap1.Layers.LayersDlg(Missing.Value, Missing.Value) Then
				Directory.SetCurrentDirectory(modSaBan.myCurrentDirectory)
			End If
		End Sub

		Private Sub MnuSaveGeoSet_Click(sender As Object, e As EventArgs)
			Try
				Me.AxMap1.SaveMapAsGeoset("BanDoNho", modBanDo.myMapNhoGst)
			Catch arg_17_0 As Exception
				ProjectData.SetProjectError(arg_17_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub
	End Class
End Namespace
