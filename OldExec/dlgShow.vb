Imports AxMapXLib
Imports BdTC.My.Resources
Imports MapXLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BdTC
	<DesignerGenerated()>
	Public Class dlgShow
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("AxMap1")>
		Private _AxMap1 As AxMap

		<AccessedThroughProperty("ToolStrip1")>
		Private _ToolStrip1 As ToolStrip

		<AccessedThroughProperty("ZoomInToolStripButton")>
		Private _ZoomInToolStripButton As ToolStripButton

		<AccessedThroughProperty("ZoomOutToolStripButton")>
		Private _ZoomOutToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("ToPPTToolStripButton")>
		Private _ToPPTToolStripButton As ToolStripButton

		<AccessedThroughProperty("PrevToolStripButton")>
		Private _PrevToolStripButton As ToolStripButton

		<AccessedThroughProperty("NextToolStripButton")>
		Private _NextToolStripButton As ToolStripButton

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("ToolStripSeparator3")>
		Private _ToolStripSeparator3 As ToolStripSeparator

		<AccessedThroughProperty("ExitToolStripButton")>
		Private _ExitToolStripButton As ToolStripButton

		Private mySlides As CSlides

		Private myBanDo As CBanDo

		Private SlideCount As Integer

		Public iCurrSlide As Integer

		Private ZoomDelta As Single

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
					RemoveHandler Me._AxMap1.MouseMoveEvent, AddressOf Me.AxMap1_MouseMoveEvent
				End If
				Me._AxMap1 = value
				flag = (Me._AxMap1 IsNot Nothing)
				If flag Then
					AddHandler Me._AxMap1.MouseMoveEvent, AddressOf Me.AxMap1_MouseMoveEvent
				End If
			End Set
		End Property

		Friend Overridable Property ToolStrip1() As ToolStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStrip)
				Me._ToolStrip1 = value
			End Set
		End Property

		Friend Overridable Property ZoomInToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ZoomInToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ZoomInToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ZoomInToolStripButton.Click, AddressOf Me.ZoomInToolStripButton_Click
				End If
				Me._ZoomInToolStripButton = value
				flag = (Me._ZoomInToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ZoomInToolStripButton.Click, AddressOf Me.ZoomInToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ZoomOutToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ZoomOutToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ZoomOutToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ZoomOutToolStripButton.Click, AddressOf Me.ZoomOutToolStripButton_Click
				End If
				Me._ZoomOutToolStripButton = value
				flag = (Me._ZoomOutToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ZoomOutToolStripButton.Click, AddressOf Me.ZoomOutToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator1() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		Friend Overridable Property ToPPTToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ToPPTToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ToPPTToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ToPPTToolStripButton.Click, AddressOf Me.ToPPTToolStripButton_Click
				End If
				Me._ToPPTToolStripButton = value
				flag = (Me._ToPPTToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ToPPTToolStripButton.Click, AddressOf Me.ToPPTToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property PrevToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._PrevToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._PrevToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._PrevToolStripButton.Click, AddressOf Me.PrevToolStripButton_Click
				End If
				Me._PrevToolStripButton = value
				flag = (Me._PrevToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._PrevToolStripButton.Click, AddressOf Me.PrevToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property NextToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._NextToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._NextToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._NextToolStripButton.Click, AddressOf Me.NextToolStripButton_Click
				End If
				Me._NextToolStripButton = value
				flag = (Me._NextToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._NextToolStripButton.Click, AddressOf Me.NextToolStripButton_Click
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator2() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator3() As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator3 = value
			End Set
		End Property

		Friend Overridable Property ExitToolStripButton() As ToolStripButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripButton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripButton)
				Dim flag As Boolean = Me._ExitToolStripButton IsNot Nothing
				If flag Then
					RemoveHandler Me._ExitToolStripButton.Click, AddressOf Me.ExitToolStripButton_Click
				End If
				Me._ExitToolStripButton = value
				flag = (Me._ExitToolStripButton IsNot Nothing)
				If flag Then
					AddHandler Me._ExitToolStripButton.Click, AddressOf Me.ExitToolStripButton_Click
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.dlgShow_FormClosing
			AddHandler MyBase.Load, AddressOf Me.dlgShow_Load
			dlgShow.__ENCList.Add(New WeakReference(Me))
			Me.iCurrSlide = 0
			Me.ZoomDelta = 0.05F
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
			Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(dlgShow))
			Me.ToolStrip1 = New ToolStrip()
			Me.ExitToolStripButton = New ToolStripButton()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.PrevToolStripButton = New ToolStripButton()
			Me.NextToolStripButton = New ToolStripButton()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.ZoomInToolStripButton = New ToolStripButton()
			Me.ZoomOutToolStripButton = New ToolStripButton()
			Me.ToolStripSeparator3 = New ToolStripSeparator()
			Me.ToPPTToolStripButton = New ToolStripButton()
			Me.AxMap1 = New AxMap()
			Me.ToolStrip1.SuspendLayout()
			(CType(Me.AxMap1, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.ToolStrip1.Dock = DockStyle.None
			Me.ToolStrip1.Items.AddRange(New ToolStripItem() { Me.ExitToolStripButton, Me.ToolStripSeparator1, Me.PrevToolStripButton, Me.NextToolStripButton, Me.ToolStripSeparator2, Me.ZoomInToolStripButton, Me.ZoomOutToolStripButton, Me.ToolStripSeparator3, Me.ToPPTToolStripButton })
			Dim arg_146_0 As Control = Me.ToolStrip1
			Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
			arg_146_0.Location = location
			Me.ToolStrip1.Name = "ToolStrip1"
			Dim arg_173_0 As Control = Me.ToolStrip1
			Dim size As Size = New Size(226, 25)
			arg_173_0.Size = size
			Me.ToolStrip1.TabIndex = 3
			Me.ToolStrip1.Text = "ToolStrip1"
			Me.ExitToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me.ExitToolStripButton.Image = CType(resources.GetObject("ExitToolStripButton.Image"), Image)
			Me.ExitToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ExitToolStripButton.Name = "ExitToolStripButton"
			Dim arg_1F5_0 As ToolStripItem = Me.ExitToolStripButton
			size = New Size(29, 22)
			arg_1F5_0.Size = size
			Me.ExitToolStripButton.Text = "Exit"
			Me.ExitToolStripButton.ToolTipText = "Thoát"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim arg_240_0 As ToolStripItem = Me.ToolStripSeparator1
			size = New Size(6, 25)
			arg_240_0.Size = size
			Me.PrevToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.PrevToolStripButton.Image = Resources.GoToPrevious
			Me.PrevToolStripButton.ImageTransparentColor = Color.Magenta
			Me.PrevToolStripButton.Name = "PrevToolStripButton"
			Dim arg_299_0 As ToolStripItem = Me.PrevToolStripButton
			size = New Size(23, 22)
			arg_299_0.Size = size
			Me.PrevToolStripButton.Text = "Trang tr" & ChrW(432) & ChrW(7899) & "c"
			Me.PrevToolStripButton.ToolTipText = "Trang tr" & ChrW(432) & ChrW(7899) & "c"
			Me.NextToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.NextToolStripButton.Image = Resources.GoToNext
			Me.NextToolStripButton.ImageTransparentColor = Color.Magenta
			Me.NextToolStripButton.Name = "NextToolStripButton"
			Dim arg_314_0 As ToolStripItem = Me.NextToolStripButton
			size = New Size(23, 22)
			arg_314_0.Size = size
			Me.NextToolStripButton.Text = "Trang sau"
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim arg_34E_0 As ToolStripItem = Me.ToolStripSeparator2
			size = New Size(6, 25)
			arg_34E_0.Size = size
			Me.ZoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ZoomInToolStripButton.Image = Resources.zoomin
			Me.ZoomInToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ZoomInToolStripButton.Name = "ZoomInToolStripButton"
			Dim arg_3A7_0 As ToolStripItem = Me.ZoomInToolStripButton
			size = New Size(23, 22)
			arg_3A7_0.Size = size
			Me.ZoomInToolStripButton.Text = "Phóng to"
			Me.ZoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.ZoomOutToolStripButton.Image = Resources.zoomout
			Me.ZoomOutToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ZoomOutToolStripButton.Name = "ZoomOutToolStripButton"
			Dim arg_411_0 As ToolStripItem = Me.ZoomOutToolStripButton
			size = New Size(23, 22)
			arg_411_0.Size = size
			Me.ZoomOutToolStripButton.Text = "Thu nh" & ChrW(7887)
			Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
			Dim arg_44B_0 As ToolStripItem = Me.ToolStripSeparator3
			size = New Size(6, 25)
			arg_44B_0.Size = size
			Me.ToPPTToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me.ToPPTToolStripButton.Image = CType(resources.GetObject("ToPPTToolStripButton.Image"), Image)
			Me.ToPPTToolStripButton.ImageTransparentColor = Color.Magenta
			Me.ToPPTToolStripButton.Name = "ToPPTToolStripButton"
			Dim arg_4AF_0 As ToolStripItem = Me.ToPPTToolStripButton
			size = New Size(44, 22)
			arg_4AF_0.Size = size
			Me.ToPPTToolStripButton.Text = "To PPT"
			Me.ToPPTToolStripButton.ToolTipText = "Xu" & ChrW(7845) & "t ra PowerPoint"
			Me.AxMap1.Dock = DockStyle.Fill
			Me.AxMap1.Enabled = True
			Dim arg_502_0 As Control = Me.AxMap1
			location = New System.Drawing.Point(0, 0)
			arg_502_0.Location = location
			Me.AxMap1.Name = "AxMap1"
			Me.AxMap1.OcxState = CType(resources.GetObject("AxMap1.OcxState"), AxHost.State)
			Dim arg_54E_0 As Control = Me.AxMap1
			size = New Size(435, 315)
			arg_54E_0.Size = size
			Me.AxMap1.TabIndex = 2
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(435, 315)
			Me.ClientSize = size
			Me.Controls.Add(Me.ToolStrip1)
			Me.Controls.Add(Me.AxMap1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.None
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgShow"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "dlgShow"
			Me.ToolStrip1.ResumeLayout(False)
			Me.ToolStrip1.PerformLayout()
			(CType(Me.AxMap1, ISupportInitialize)).EndInit()
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

		Private Sub dlgShow_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.myBanDo.Dispose()
			Me.myBanDo = Nothing
		End Sub

		Private Sub dlgShow_Load(sender As Object, e As EventArgs)
			Me.WindowState = FormWindowState.Maximized
			Try
				Me.myBanDo = New CBanDo(Me.AxMap1, myModule.fMain)
				Me.mySlides = New CSlides()
				Try
					Dim enumerator As IEnumerator = myModule.fMain.mySlides.GetEnumerator()
					While enumerator.MoveNext()
						Dim aSlide As CSlide = CType(enumerator.Current, CSlide)
						Me.mySlides.Add(aSlide)
					End While
				Finally
					Dim enumerator As IEnumerator
					Dim flag As Boolean = TypeOf enumerator Is IDisposable
					If flag Then
						(TryCast(enumerator, IDisposable)).Dispose()
					End If
				End Try
				Me.SlideCount = Me.mySlides.Count
			Catch expr_96 As Exception
				ProjectData.SetProjectError(expr_96)
				Dim ex As Exception = expr_96
				MessageBox.Show("SaiRoi: " + ex.Message)
				Me.Dispose()
				ProjectData.ClearProjectError()
			End Try
			Me.AxMap1.ZoomTo(myModule.fMain.AxMap1.Zoom, myModule.fMain.AxMap1.CenterX, myModule.fMain.AxMap1.CenterY)
			Me.ShowSlide(Me.iCurrSlide)
		End Sub

		Private Sub ShowSlide(pSlideIndex As Integer)
			Me.Cursor = Cursors.WaitCursor
			Try
				Dim mSlide As CSlide = Me.mySlides(pSlideIndex)
				Dim flag As Boolean = Not Information.IsNothing(mSlide)
				If flag Then
					Me.myBanDo.KHsFromString(mSlide.Symbols)
				End If
				Me.AxMap1.Refresh()
			Catch expr_4B As Exception
				ProjectData.SetProjectError(expr_4B)
				Dim e As Exception = expr_4B
				Interaction.MsgBox(e.Message, MsgBoxStyle.Critical, "Show Error")
				ProjectData.ClearProjectError()
			End Try
			Me.Cursor = Cursors.[Default]
			Me.iCurrSlide = pSlideIndex
			Me.AxMap1.[Select]()
			Me.AxMap1.CurrentTool = ToolConstants.miPanTool
		End Sub

		Private Sub Exp2PPT(pFileSpec As String)
		End Sub

		Private Sub ExpBanDo2EMF(pFileSpec As String)
			Dim mMapFileName As String = "MapTemp.wmf"
			Me.AxMap1.ExportMap(mMapFileName, ExportFormatConstants.miFormatWMF)
			Dim myMapfile As Metafile = New Metafile(mMapFileName)
			Dim g As Graphics = Me.AxMap1.CreateGraphics()
			Dim hdc As IntPtr = g.GetHdc()
			Dim mMetafile As Metafile = New Metafile(pFileSpec, hdc)
			Dim g2 As Graphics = Graphics.FromImage(mMetafile)
			g2.DrawImage(myMapfile, 0, 0)
			mMetafile.Dispose()
		End Sub

		Private Sub ToPPTToolStripButton_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "PowerPoint files (*.ppt)|*.ppt|All files (*.*)|*.*"
			saveFileDialog.FilterIndex = 1
			saveFileDialog.RestoreDirectory = True
			Dim flag As Boolean = saveFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim mFileName As String = saveFileDialog.FileName
				flag = (mFileName.Length > 0)
				If flag Then
					Me.Exp2PPT(mFileName)
				End If
			End If
		End Sub

		Private Sub CheckNextPrev()
			Dim flag As Boolean = Me.iCurrSlide > 0
			If flag Then
				Me.PrevToolStripButton.Enabled = True
			Else
				Me.PrevToolStripButton.Enabled = False
			End If
			' The following expression was wrapped in a checked-expression
			flag = (Me.iCurrSlide < Me.SlideCount - 1)
			If flag Then
				Me.NextToolStripButton.Enabled = True
			Else
				Me.NextToolStripButton.Enabled = False
			End If
		End Sub

		Private Sub AxMap1_MouseMoveEvent(sender As Object, e As CMapXEvents_MouseMoveEvent)
			Dim flag As Boolean = e.y < 40F And e.x < 300F
			If flag Then
				Me.CheckNextPrev()
				Me.ToolStrip1.Visible = True
			Else
				Me.ToolStrip1.Visible = False
			End If
		End Sub

		Private Sub PrevToolStripButton_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.iCurrSlide > 0
			If flag Then
				' The following expression was wrapped in a checked-expression
				Me.ShowSlide(Me.iCurrSlide - 1)
			End If
			Me.CheckNextPrev()
		End Sub

		Private Sub NextToolStripButton_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim flag As Boolean = Me.iCurrSlide < Me.SlideCount - 1
			If flag Then
				Me.ShowSlide(Me.iCurrSlide + 1)
			End If
			Me.CheckNextPrev()
		End Sub

		Private Sub ExitToolStripButton_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub ZoomInToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.ZoomTo(Me.AxMap1.Zoom * (1.0 - CDec(Me.ZoomDelta)), Me.AxMap1.CenterX, Me.AxMap1.CenterY)
		End Sub

		Private Sub ZoomOutToolStripButton_Click(sender As Object, e As EventArgs)
			Me.AxMap1.ZoomTo(Me.AxMap1.Zoom * (1.0 + CDec(Me.ZoomDelta)), Me.AxMap1.CenterX, Me.AxMap1.CenterY)
		End Sub
	End Class
End Namespace
