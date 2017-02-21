Imports AxMapXLib
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgBanDoNho
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

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
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenu1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Friend Overridable Property MnuArrow() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuArrow
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuArrow IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuArrow.Click, AddressOf Me.MnuArrow_Click
				End If
				Me._MnuArrow = value
				flag = (Me._MnuArrow IsNot Nothing)
				If flag Then
					AddHandler Me._MnuArrow.Click, AddressOf Me.MnuArrow_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem1() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem1 = value
			End Set
		End Property

		Friend Overridable Property MnuPan() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuPan
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuPan IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuPan.Click, AddressOf Me.MnuPan_Click
				End If
				Me._MnuPan = value
				flag = (Me._MnuPan IsNot Nothing)
				If flag Then
					AddHandler Me._MnuPan.Click, AddressOf Me.MnuPan_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuZoomIn() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuZoomIn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuZoomIn IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuZoomIn.Click, AddressOf Me.MnuZoomIn_Click
				End If
				Me._MnuZoomIn = value
				flag = (Me._MnuZoomIn IsNot Nothing)
				If flag Then
					AddHandler Me._MnuZoomIn.Click, AddressOf Me.MnuZoomIn_Click
				End If
			End Set
		End Property

		Friend Overridable Property MnuZoomOut() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuZoomOut
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuZoomOut IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuZoomOut.Click, AddressOf Me.MnuZoomOut_Click
				End If
				Me._MnuZoomOut = value
				flag = (Me._MnuZoomOut IsNot Nothing)
				If flag Then
					AddHandler Me._MnuZoomOut.Click, AddressOf Me.MnuZoomOut_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem4() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem4 = value
			End Set
		End Property

		Friend Overridable Property MnuLayers() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuLayers
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuLayers IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuLayers.Click, AddressOf Me.MnuLayers_Click
				End If
				Me._MnuLayers = value
				flag = (Me._MnuLayers IsNot Nothing)
				If flag Then
					AddHandler Me._MnuLayers.Click, AddressOf Me.MnuLayers_Click
				End If
			End Set
		End Property

		Friend Overridable Property MenuItem7() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuItem7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._MenuItem7 = value
			End Set
		End Property

		Friend Overridable Property MnuSaveGeoSet() As MenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MnuSaveGeoSet
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim flag As Boolean = Me._MnuSaveGeoSet IsNot Nothing
				If flag Then
					RemoveHandler Me._MnuSaveGeoSet.Click, AddressOf Me.MnuSaveGeoSet_Click
				End If
				Me._MnuSaveGeoSet = value
				flag = (Me._MnuSaveGeoSet IsNot Nothing)
				If flag Then
					AddHandler Me._MnuSaveGeoSet.Click, AddressOf Me.MnuSaveGeoSet_Click
				End If
			End Set
		End Property

		Friend Overridable Property AxMap1() As AxMap
			<DebuggerNonUserCode()>
			Get
				Return Me._AxMap1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AxMap)
				Dim flag As Boolean = Me._AxMap1 IsNot Nothing
				If flag Then
					RemoveHandler Me._AxMap1.MouseDownEvent, AddressOf Me.AxMap1_MouseDownEvent
					RemoveHandler Me._AxMap1.MouseUpEvent, AddressOf Me.AxMap1_MouseUpEvent
					RemoveHandler Me._AxMap1.MouseMoveEvent, AddressOf Me.AxMap1_MouseMoveEvent
				End If
				Me._AxMap1 = value
				flag = (Me._AxMap1 IsNot Nothing)
				If flag Then
					AddHandler Me._AxMap1.MouseDownEvent, AddressOf Me.AxMap1_MouseDownEvent
					AddHandler Me._AxMap1.MouseUpEvent, AddressOf Me.AxMap1_MouseUpEvent
					AddHandler Me._AxMap1.MouseMoveEvent, AddressOf Me.AxMap1_MouseMoveEvent
				End If
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Closing, AddressOf Me.frmBanDoNho_Closing
			AddHandler MyBase.Load, AddressOf Me.dlgBanDoNho_Load
			dlgBanDoNho.__ENCList.Add(New WeakReference(Me))
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(dlgBanDoNho))
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
			Dim arg_255_0 As Control = Me.AxMap1
			Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
			arg_255_0.Location = location
			Me.AxMap1.Name = "AxMap1"
			Me.AxMap1.OcxState = CType(resources.GetObject("AxMap1.OcxState"), AxHost.State)
			Dim arg_2A1_0 As Control = Me.AxMap1
			Dim size As Size = New Size(231, 240)
			arg_2A1_0.Size = size
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
			Dim lyr As Layer = Me.AxMap1.Layers.CreateLayer("tempAnimate", Missing.Value, 1, Missing.Value, Missing.Value)
			Me.AxMap1.Layers.AnimationLayer = lyr
			Dim mStyle As Style = New StyleClass()
			mStyle.LineWidth = 1S
			mStyle.LineColor = UInteger.Parse(Conversions.ToString(255))
			Dim pts As Points = New PointsClass()
			Dim pt As MapXLib.Point = New PointClass()
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			pts.Add(pt, Missing.Value)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMin)
			pts.Add(pt, Missing.Value)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMax)
			pts.Add(pt, Missing.Value)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMax)
			pts.Add(pt, Missing.Value)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			pts.Add(pt, Missing.Value)
			Me.fHinhChuNhat = Me.AxMap1.Layers("tempAnimate").AddFeature(Me.AxMap1.FeatureFactory.CreateLine(pts, mStyle), Missing.Value)
		End Sub

		Public Sub UpdateHinhChuNhat()
			Dim pts As Points = Me.fHinhChuNhat.Parts(1)
			Dim pt As MapXLib.Point = pts(1)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			pt = pts(2)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMin)
			pt = pts(3)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMax, myModule.fMain.AxMap1.CtlBounds.YMax)
			pt = pts(4)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMax)
			pt = pts(5)
			pt.[Set](myModule.fMain.AxMap1.CtlBounds.XMin, myModule.fMain.AxMap1.CtlBounds.YMin)
			Me.fHinhChuNhat.Update(Missing.Value, Missing.Value)
		End Sub

		Private Sub dlgBanDoNho_Load(sender As Object, e As EventArgs)
			myModule.fBanDoNho = Me
			Dim mL As Integer = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoLeft", "0"))
			Dim mT As Integer = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoTop", "0"))
			Dim flag As Boolean = mL > myModule.intMonitorW
			If flag Then
				mL = 0
			End If
			flag = (mT > myModule.intMonitorH)
			If flag Then
				mT = 0
			End If
			Me.Left = mL
			Me.Top = mT
			Me.Width = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoWidth", Me.Width.ToString()))
			Me.Height = Conversions.ToInteger(Interaction.GetSetting(Application.ProductName, "Settings", "BDNhoHeight", Me.Height.ToString()))
			Try
				Me.AxMap1.GeoSet = myModule.myMapNhoGst
				Me.AxMap1.Title.Visible = False
				Me.AxMap1.InfotipSupport = False
				Dim mydcs As CoordSys = Me.AxMap1.DisplayCoordSys
				Me.AxMap1.NumericCoordSys = mydcs
				Me.AxMap1.NumericCoordSys.[Set](CType(myModule.myCoordSysType, CoordSysTypeConstants), Me.AxMap1.NumericCoordSys.Datum, Me.AxMap1.NumericCoordSys.Units, Me.AxMap1.NumericCoordSys.OriginLongitude, Me.AxMap1.NumericCoordSys.OriginLatitude, Me.AxMap1.NumericCoordSys.StandardParallelOne, Me.AxMap1.NumericCoordSys.StandardParallelTwo, Me.AxMap1.NumericCoordSys.Azimuth, Me.AxMap1.NumericCoordSys.ScaleFactor, Me.AxMap1.NumericCoordSys.FalseEasting, Me.AxMap1.NumericCoordSys.FalseNorthing, Me.AxMap1.NumericCoordSys.Range, Missing.Value, Missing.Value)
				Me.AxMap1.PaperUnit = PaperUnitConstants.miPaperUnitPoint
			Catch arg_22D_0 As Exception
				ProjectData.SetProjectError(arg_22D_0)
				ProjectData.ClearProjectError()
			End Try
			myModule.fMain.myBando.bBanDo2Loaded = True
			myModule.fMain.ToolStripMenuBDView.Checked = True
			Me.InitHinhChuNhat()
		End Sub

		Private Sub frmBanDoNho_Closing(sender As Object, e As CancelEventArgs)
			Dim flag As Boolean = Me.WindowState <> FormWindowState.Minimized Or Me.WindowState <> FormWindowState.Maximized
			If flag Then
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoLeft", Me.Left.ToString())
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoTop", Me.Top.ToString())
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoWidth", Me.Width.ToString())
				Interaction.SaveSetting(Application.ProductName, "Settings", "BDNhoHeight", Me.Height.ToString())
			End If
			myModule.fMain.myBando.bBanDo2Loaded = False
			myModule.fMain.ToolStripMenuBDView.Checked = False
			myModule.fBanDoNho = Nothing
		End Sub

		Private Sub AxMap1_MouseDownEvent(sender As Object, e As CMapXEvents_MouseDownEvent)
			Dim flag As Boolean = e.button = 1S And Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			If flag Then
				Dim mLon As Double
				Dim mLat As Double
				Me.AxMap1.ConvertCoord(e.x, e.y, mLon, mLat, ConversionConstants.miScreenToMap)
				myModule.fMain.AxMap1.ZoomTo(myModule.fMain.AxMap1.Zoom, mLon, mLat)
			End If
		End Sub

		Private Sub AxMap1_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			Dim mLon As Double
			Dim mLat As Double
			Me.AxMap1.ConvertCoord(e.x, e.y, mLon, mLat, ConversionConstants.miScreenToMap)
			Me.Text = "X:" + Strings.Format(mLon, "000.000") + " Y:" + Strings.Format(mLat, "00.000")
			Dim flag As Boolean = e.button = 1S And Me.AxMap1.CurrentTool = ToolConstants.miArrowTool
			If flag Then
				myModule.fMain.AxMap1.ZoomTo(myModule.fMain.AxMap1.Zoom, mLon, mLat)
			End If
		End Sub

		Private Sub AxMap1_MouseUpEvent(sender As Object, e As CMapXEvents_MouseUpEvent)
			Dim flag As Boolean = e.button = 2S
			If flag Then
				' The following expression was wrapped in a checked-expression
				Dim pt As System.Drawing.Point = New System.Drawing.Point(CInt(Math.Round(CDec(e.x))), CInt(Math.Round(CDec(e.y))))
				Me.ContextMenu1.Show(Me, pt)
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
			Me.AxMap1.Layers.LayersDlg(Missing.Value, Missing.Value)
		End Sub

		Private Sub MnuSaveGeoSet_Click(sender As Object, e As EventArgs)
			Try
				Me.AxMap1.SaveMapAsGeoset("BanDoNho", myModule.myMapNhoGst)
			Catch arg_1A_0 As Exception
				ProjectData.SetProjectError(arg_1A_0)
				ProjectData.ClearProjectError()
			End Try
		End Sub
	End Class
End Namespace
