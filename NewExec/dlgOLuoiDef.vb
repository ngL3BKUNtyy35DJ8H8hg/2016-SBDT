Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Xml

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgOLuoiDef
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("btnOK")>
		Private _btnOK As Button

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtDoRong")>
		Private _txtDoRong As TextBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("txtKinhDo")>
		Private _txtKinhDo As TextBox

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("txtViDo")>
		Private _txtViDo As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtX")>
		Private _txtX As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtY")>
		Private _txtY As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		Friend Overridable Property btnOK() As Button
			Get
				Return Me._btnOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOK_Click
				If Me._btnOK IsNot Nothing Then
					RemoveHandler Me._btnOK.Click, value2
				End If
				Me._btnOK = value
				If Me._btnOK IsNot Nothing Then
					AddHandler Me._btnOK.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label6() As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property txtDoRong() As TextBox
			Get
				Return Me._txtDoRong
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDoRong = value
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

		Friend Overridable Property txtKinhDo() As TextBox
			Get
				Return Me._txtKinhDo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtKinhDo = value
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

		Friend Overridable Property txtViDo() As TextBox
			Get
				Return Me._txtViDo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtViDo = value
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

		Friend Overridable Property txtX() As TextBox
			Get
				Return Me._txtX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtX = value
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

		Friend Overridable Property txtY() As TextBox
			Get
				Return Me._txtY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtY = value
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
			AddHandler MyBase.Load, AddressOf Me.dlgOLuoiDef_Load
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
			Me.btnOK = New Button()
			Me.Label6 = New Label()
			Me.txtDoRong = New TextBox()
			Me.Label5 = New Label()
			Me.txtKinhDo = New TextBox()
			Me.Label4 = New Label()
			Me.txtViDo = New TextBox()
			Me.Label3 = New Label()
			Me.txtX = New TextBox()
			Me.Label2 = New Label()
			Me.txtY = New TextBox()
			Me.Label1 = New Label()
			Me.SuspendLayout()
			Dim arg_9F_0 As Control = Me.btnOK
			Dim location As Point = New Point(97, 196)
			arg_9F_0.Location = location
			Me.btnOK.Name = "btnOK"
			Dim arg_C6_0 As Control = Me.btnOK
			Dim size As Size = New Size(88, 24)
			arg_C6_0.Size = size
			Me.btnOK.TabIndex = 23
			Me.btnOK.Text = "Ch" & ChrW(7845) & "p nh" & ChrW(7853) & "n"
			Dim arg_100_0 As Control = Me.Label6
			location = New Point(185, 148)
			arg_100_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_127_0 As Control = Me.Label6
			size = New Size(24, 23)
			arg_127_0.Size = size
			Me.Label6.TabIndex = 22
			Me.Label6.Text = "m"
			Dim arg_15E_0 As Control = Me.txtDoRong
			location = New Point(121, 148)
			arg_15E_0.Location = location
			Me.txtDoRong.Name = "txtDoRong"
			Dim arg_185_0 As Control = Me.txtDoRong
			size = New Size(64, 21)
			arg_185_0.Size = size
			Me.txtDoRong.TabIndex = 21
			Me.txtDoRong.Text = "1000"
			Dim arg_1BC_0 As Control = Me.Label5
			location = New Point(17, 148)
			arg_1BC_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_1E3_0 As Control = Me.Label5
			size = New Size(100, 23)
			arg_1E3_0.Size = size
			Me.Label5.TabIndex = 20
			Me.Label5.Text = ChrW(272) & ChrW(7897) & " r" & ChrW(7897) & "ng c" & ChrW(7911) & "a L" & ChrW(432) & ChrW(7899) & "i:"
			Dim arg_217_0 As Control = Me.txtKinhDo
			location = New Point(121, 116)
			arg_217_0.Location = location
			Me.txtKinhDo.Name = "txtKinhDo"
			Dim arg_23E_0 As Control = Me.txtKinhDo
			size = New Size(64, 21)
			arg_23E_0.Size = size
			Me.txtKinhDo.TabIndex = 19
			Me.txtKinhDo.Text = "105.2980"
			Dim arg_272_0 As Control = Me.Label4
			location = New Point(17, 116)
			arg_272_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_299_0 As Control = Me.Label4
			size = New Size(100, 23)
			arg_299_0.Size = size
			Me.Label4.TabIndex = 18
			Me.Label4.Text = "Kinh " & ChrW(273) & ChrW(7897) & ":"
			Dim arg_2CD_0 As Control = Me.txtViDo
			location = New Point(121, 84)
			arg_2CD_0.Location = location
			Me.txtViDo.Name = "txtViDo"
			Dim arg_2F4_0 As Control = Me.txtViDo
			size = New Size(64, 21)
			arg_2F4_0.Size = size
			Me.txtViDo.TabIndex = 17
			Me.txtViDo.Text = "21.4469"
			Dim arg_328_0 As Control = Me.Label3
			location = New Point(17, 84)
			arg_328_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_34F_0 As Control = Me.Label3
			size = New Size(100, 23)
			arg_34F_0.Size = size
			Me.Label3.TabIndex = 16
			Me.Label3.Text = "V" & ChrW(297) & " " & ChrW(273) & ChrW(7897) & ":"
			Dim arg_383_0 As Control = Me.txtX
			location = New Point(121, 52)
			arg_383_0.Location = location
			Me.txtX.Name = "txtX"
			Dim arg_3AA_0 As Control = Me.txtX
			size = New Size(64, 21)
			arg_3AA_0.Size = size
			Me.txtX.TabIndex = 15
			Me.txtX.Text = "82"
			Dim arg_3DE_0 As Control = Me.Label2
			location = New Point(17, 52)
			arg_3DE_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_405_0 As Control = Me.Label2
			size = New Size(100, 23)
			arg_405_0.Size = size
			Me.Label2.TabIndex = 14
			Me.Label2.Text = "x:"
			Dim arg_439_0 As Control = Me.txtY
			location = New Point(121, 20)
			arg_439_0.Location = location
			Me.txtY.Name = "txtY"
			Dim arg_460_0 As Control = Me.txtY
			size = New Size(64, 21)
			arg_460_0.Size = size
			Me.txtY.TabIndex = 13
			Me.txtY.Text = "171"
			Dim arg_494_0 As Control = Me.Label1
			location = New Point(17, 20)
			arg_494_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_4BB_0 As Control = Me.Label1
			size = New Size(100, 23)
			arg_4BB_0.Size = size
			Me.Label1.TabIndex = 12
			Me.Label1.Text = "y:"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(226, 240)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.txtDoRong)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.txtKinhDo)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.txtViDo)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.txtX)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtY)
			Me.Controls.Add(Me.Label1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgOLuoiDef"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Xác l" & ChrW(7853) & "p Ô l" & ChrW(432) & ChrW(7899) & "i"
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

		Private Sub dlgOLuoiDef_Load(sender As Object, e As EventArgs)
			Me.txtX.Text = Conversions.ToString(modBanDo.OLuoiX)
			Me.txtY.Text = Conversions.ToString(modBanDo.OLuoiY)
			Me.txtKinhDo.Text = Conversions.ToString(modBanDo.OLuoiKinhDo)
			Me.txtViDo.Text = Conversions.ToString(modBanDo.OLuoiViDo)
			Me.txtDoRong.Text = Conversions.ToString(modBanDo.OLuoiSize)
		End Sub

		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			modBanDo.OLuoiX = CInt(Math.Round(Conversion.Val(Me.txtX.Text)))
			modBanDo.OLuoiY = CInt(Math.Round(Conversion.Val(Me.txtY.Text)))
			modBanDo.OLuoiKinhDo = Conversions.ToDouble(Me.txtKinhDo.Text)
			modBanDo.OLuoiViDo = Conversions.ToDouble(Me.txtViDo.Text)
			modBanDo.OLuoiSize = CInt(Math.Round(Conversion.Val(Me.txtDoRong.Text)))
			modBanDo.OluoiXRate = myModule.fMain.AxMap1.Distance(modBanDo.OLuoiKinhDo, modBanDo.OLuoiViDo, modBanDo.OLuoiKinhDo + 1.0, modBanDo.OLuoiViDo) / CDec(modBanDo.OLuoiSize)
			modBanDo.OluoiYRate = myModule.fMain.AxMap1.Distance(modBanDo.OLuoiKinhDo, modBanDo.OLuoiViDo, modBanDo.OLuoiKinhDo, modBanDo.OLuoiViDo + 1.0) / CDec(modBanDo.OLuoiSize)
			Directory.SetCurrentDirectory(modSaBan.myApplPath)
			Dim pFileName As String = "OLUOI.DEF"
			Me.Def2File(pFileName)
			Me.Close()
		End Sub

		Private Sub Def2File(pFileName As String)
			Dim w As StreamWriter = New StreamWriter(pFileName)
			Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(w)
			Me.Def2xml(xmlTextWriter)
			xmlTextWriter.Close()
		End Sub

		Private Sub Def2xml(ByRef wr As XmlTextWriter)
			wr.WriteStartElement("OLUOI")
			wr.WriteAttributeString("X", modBanDo.OLuoiX.ToString())
			wr.WriteAttributeString("Y", modBanDo.OLuoiY.ToString())
			wr.WriteAttributeString("LON", modBanDo.OLuoiKinhDo.ToString())
			wr.WriteAttributeString("LAT", modBanDo.OLuoiViDo.ToString())
			wr.WriteAttributeString("SIZE", modBanDo.OLuoiSize.ToString())
			wr.WriteAttributeString("XRATE", modBanDo.OluoiXRate.ToString())
			wr.WriteAttributeString("YRATE", modBanDo.OluoiYRate.ToString())
			wr.WriteEndElement()
		End Sub
	End Class
End Namespace
