Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgOptions
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TabControl1")>
		Private _TabControl1 As TabControl

		<AccessedThroughProperty("TabGeneral")>
		Private _TabGeneral As TabPage

		<AccessedThroughProperty("nudLineStyle")>
		Private _nudLineStyle As NumericUpDown

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("txtBrushColor")>
		Private _txtBrushColor As TextBox

		<AccessedThroughProperty("txtColor2")>
		Private _txtColor2 As TextBox

		<AccessedThroughProperty("txtColor")>
		Private _txtColor As TextBox

		<AccessedThroughProperty("nudAlpha")>
		Private _nudAlpha As NumericUpDown

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("chkBrush")>
		Private _chkBrush As CheckBox

		<AccessedThroughProperty("nudPenWidth2")>
		Private _nudPenWidth2 As NumericUpDown

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("nudPenWidth")>
		Private _nudPenWidth As NumericUpDown

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("TabTable")>
		Private _TabTable As TabPage

		<AccessedThroughProperty("txtTableFont")>
		Private _txtTableFont As TextBox

		<AccessedThroughProperty("nudTblRowsNo")>
		Private _nudTblRowsNo As NumericUpDown

		<AccessedThroughProperty("Label21")>
		Private _Label21 As Label

		<AccessedThroughProperty("nudTblColsNo")>
		Private _nudTblColsNo As NumericUpDown

		<AccessedThroughProperty("Label20")>
		Private _Label20 As Label

		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		<AccessedThroughProperty("txtTblFillColor")>
		Private _txtTblFillColor As TextBox

		<AccessedThroughProperty("txtTblLineColor")>
		Private _txtTblLineColor As TextBox

		<AccessedThroughProperty("txtTblBorderColor")>
		Private _txtTblBorderColor As TextBox

		<AccessedThroughProperty("nudTblAlpha")>
		Private _nudTblAlpha As NumericUpDown

		<AccessedThroughProperty("Label17")>
		Private _Label17 As Label

		<AccessedThroughProperty("nudTblLineW")>
		Private _nudTblLineW As NumericUpDown

		<AccessedThroughProperty("Label18")>
		Private _Label18 As Label

		<AccessedThroughProperty("nudTblBorderW")>
		Private _nudTblBorderW As NumericUpDown

		<AccessedThroughProperty("Label19")>
		Private _Label19 As Label

		<AccessedThroughProperty("TabMuiTen")>
		Private _TabMuiTen As TabPage

		<AccessedThroughProperty("txtMTDoRong")>
		Private _txtMTDoRong As TextBox

		<AccessedThroughProperty("Label26")>
		Private _Label26 As Label

		<AccessedThroughProperty("txtMTFillColor")>
		Private _txtMTFillColor As TextBox

		<AccessedThroughProperty("txtMT2Color")>
		Private _txtMT2Color As TextBox

		<AccessedThroughProperty("txtMT1Color")>
		Private _txtMT1Color As TextBox

		<AccessedThroughProperty("nudMTAlpha")>
		Private _nudMTAlpha As NumericUpDown

		<AccessedThroughProperty("Label22")>
		Private _Label22 As Label

		<AccessedThroughProperty("chkMTFill")>
		Private _chkMTFill As CheckBox

		<AccessedThroughProperty("nudMTPen2W")>
		Private _nudMTPen2W As NumericUpDown

		<AccessedThroughProperty("Label23")>
		Private _Label23 As Label

		<AccessedThroughProperty("nudMTPen1W")>
		Private _nudMTPen1W As NumericUpDown

		<AccessedThroughProperty("Label24")>
		Private _Label24 As Label

		<AccessedThroughProperty("TabSongSong")>
		Private _TabSongSong As TabPage

		<AccessedThroughProperty("nudSSLinesNo")>
		Private _nudSSLinesNo As NumericUpDown

		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		<AccessedThroughProperty("nudSSSize")>
		Private _nudSSSize As NumericUpDown

		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		<AccessedThroughProperty("txtSS2Color")>
		Private _txtSS2Color As TextBox

		<AccessedThroughProperty("txtSS1Color")>
		Private _txtSS1Color As TextBox

		<AccessedThroughProperty("nudSSPen2W")>
		Private _nudSSPen2W As NumericUpDown

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("nudSSPen1W")>
		Private _nudSSPen1W As NumericUpDown

		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		<AccessedThroughProperty("TabMuiTenTyLe")>
		Private _TabMuiTenTyLe As TabPage

		<AccessedThroughProperty("TabText")>
		Private _TabText As TabPage

		<AccessedThroughProperty("txtTextFont")>
		Private _txtTextFont As TextBox

		<AccessedThroughProperty("TabGrid")>
		Private _TabGrid As TabPage

		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		<AccessedThroughProperty("nudGrid")>
		Private _nudGrid As NumericUpDown

		<AccessedThroughProperty("Label15")>
		Private _Label15 As Label

		<AccessedThroughProperty("TabUndo")>
		Private _TabUndo As TabPage

		<AccessedThroughProperty("nudUndosNo")>
		Private _nudUndosNo As NumericUpDown

		<AccessedThroughProperty("Label25")>
		Private _Label25 As Label

		<AccessedThroughProperty("btnSave")>
		Private _btnSave As Button

		<AccessedThroughProperty("txtMTDDoRong")>
		Private _txtMTDDoRong As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("txtMTDDoDai")>
		Private _txtMTDDoDai As TextBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("txtMTDFillColor")>
		Private _txtMTDFillColor As TextBox

		<AccessedThroughProperty("txtMTD2Color")>
		Private _txtMTD2Color As TextBox

		<AccessedThroughProperty("txtMTD1Color")>
		Private _txtMTD1Color As TextBox

		<AccessedThroughProperty("nudMTDAlpha")>
		Private _nudMTDAlpha As NumericUpDown

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("chkMTDFill")>
		Private _chkMTDFill As CheckBox

		<AccessedThroughProperty("nudMTDPen2W")>
		Private _nudMTDPen2W As NumericUpDown

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		<AccessedThroughProperty("nudMTDPen1W")>
		Private _nudMTDPen1W As NumericUpDown

		<AccessedThroughProperty("Label27")>
		Private _Label27 As Label

		<AccessedThroughProperty("TabColorTable")>
		Private _TabColorTable As TabPage

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("txtColor32")>
		Private _txtColor32 As TextBox

		<AccessedThroughProperty("txtColor24")>
		Private _txtColor24 As TextBox

		<AccessedThroughProperty("txtColor16")>
		Private _txtColor16 As TextBox

		<AccessedThroughProperty("txtColor08")>
		Private _txtColor08 As TextBox

		<AccessedThroughProperty("txtColor31")>
		Private _txtColor31 As TextBox

		<AccessedThroughProperty("txtColor30")>
		Private _txtColor30 As TextBox

		<AccessedThroughProperty("txtColor29")>
		Private _txtColor29 As TextBox

		<AccessedThroughProperty("txtColor28")>
		Private _txtColor28 As TextBox

		<AccessedThroughProperty("txtColor27")>
		Private _txtColor27 As TextBox

		<AccessedThroughProperty("txtColor26")>
		Private _txtColor26 As TextBox

		<AccessedThroughProperty("txtColor25")>
		Private _txtColor25 As TextBox

		<AccessedThroughProperty("txtColor23")>
		Private _txtColor23 As TextBox

		<AccessedThroughProperty("txtColor22")>
		Private _txtColor22 As TextBox

		<AccessedThroughProperty("txtColor21")>
		Private _txtColor21 As TextBox

		<AccessedThroughProperty("txtColor20")>
		Private _txtColor20 As TextBox

		<AccessedThroughProperty("txtColor19")>
		Private _txtColor19 As TextBox

		<AccessedThroughProperty("txtColor18")>
		Private _txtColor18 As TextBox

		<AccessedThroughProperty("txtColor17")>
		Private _txtColor17 As TextBox

		<AccessedThroughProperty("txtColor15")>
		Private _txtColor15 As TextBox

		<AccessedThroughProperty("txtColor14")>
		Private _txtColor14 As TextBox

		<AccessedThroughProperty("txtColor13")>
		Private _txtColor13 As TextBox

		<AccessedThroughProperty("txtColor12")>
		Private _txtColor12 As TextBox

		<AccessedThroughProperty("txtColor11")>
		Private _txtColor11 As TextBox

		<AccessedThroughProperty("txtColor10")>
		Private _txtColor10 As TextBox

		<AccessedThroughProperty("txtColor09")>
		Private _txtColor09 As TextBox

		<AccessedThroughProperty("txtColor07")>
		Private _txtColor07 As TextBox

		<AccessedThroughProperty("txtColor06")>
		Private _txtColor06 As TextBox

		<AccessedThroughProperty("txtColor05")>
		Private _txtColor05 As TextBox

		<AccessedThroughProperty("txtColor04")>
		Private _txtColor04 As TextBox

		<AccessedThroughProperty("txtColor03")>
		Private _txtColor03 As TextBox

		<AccessedThroughProperty("txtColor02")>
		Private _txtColor02 As TextBox

		<AccessedThroughProperty("txtColor01")>
		Private _txtColor01 As TextBox

		<AccessedThroughProperty("txtQuanXanhColor")>
		Private _txtQuanXanhColor As TextBox

		<AccessedThroughProperty("Label28")>
		Private _Label28 As Label

		<AccessedThroughProperty("txtQuanDoColor")>
		Private _txtQuanDoColor As TextBox

		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		Private myBanDo As CBdTC

		Private myRect As Rectangle

		Friend Overridable Property TabControl1() As TabControl
			Get
				Return Me._TabControl1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._TabControl1 = value
			End Set
		End Property

		Friend Overridable Property TabGeneral() As TabPage
			Get
				Return Me._TabGeneral
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabGeneral = value
			End Set
		End Property

		Friend Overridable Property nudLineStyle() As NumericUpDown
			Get
				Return Me._nudLineStyle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudLineStyle = value
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

		Friend Overridable Property txtBrushColor() As TextBox
			Get
				Return Me._txtBrushColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtBrushColor_DoubleClick
				If Me._txtBrushColor IsNot Nothing Then
					RemoveHandler Me._txtBrushColor.DoubleClick, value2
				End If
				Me._txtBrushColor = value
				If Me._txtBrushColor IsNot Nothing Then
					AddHandler Me._txtBrushColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtColor2() As TextBox
			Get
				Return Me._txtColor2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor2_DoubleClick
				If Me._txtColor2 IsNot Nothing Then
					RemoveHandler Me._txtColor2.DoubleClick, value2
				End If
				Me._txtColor2 = value
				If Me._txtColor2 IsNot Nothing Then
					AddHandler Me._txtColor2.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtColor() As TextBox
			Get
				Return Me._txtColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor_DoubleClick
				If Me._txtColor IsNot Nothing Then
					RemoveHandler Me._txtColor.DoubleClick, value2
				End If
				Me._txtColor = value
				If Me._txtColor IsNot Nothing Then
					AddHandler Me._txtColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudAlpha() As NumericUpDown
			Get
				Return Me._nudAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudAlpha = value
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

		Friend Overridable Property chkBrush() As CheckBox
			Get
				Return Me._chkBrush
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkBrush = value
			End Set
		End Property

		Friend Overridable Property nudPenWidth2() As NumericUpDown
			Get
				Return Me._nudPenWidth2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudPenWidth2 = value
			End Set
		End Property

		Friend Overridable Property Label8() As Label
			Get
				Return Me._Label8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		Friend Overridable Property nudPenWidth() As NumericUpDown
			Get
				Return Me._nudPenWidth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudPenWidth = value
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

		Friend Overridable Property TabTable() As TabPage
			Get
				Return Me._TabTable
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabTable = value
			End Set
		End Property

		Friend Overridable Property txtTableFont() As TextBox
			Get
				Return Me._txtTableFont
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTableFont_DoubleClick
				If Me._txtTableFont IsNot Nothing Then
					RemoveHandler Me._txtTableFont.DoubleClick, value2
				End If
				Me._txtTableFont = value
				If Me._txtTableFont IsNot Nothing Then
					AddHandler Me._txtTableFont.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudTblRowsNo() As NumericUpDown
			Get
				Return Me._nudTblRowsNo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudTblRowsNo = value
			End Set
		End Property

		Friend Overridable Property Label21() As Label
			Get
				Return Me._Label21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label21 = value
			End Set
		End Property

		Friend Overridable Property nudTblColsNo() As NumericUpDown
			Get
				Return Me._nudTblColsNo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudTblColsNo = value
			End Set
		End Property

		Friend Overridable Property Label20() As Label
			Get
				Return Me._Label20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label20 = value
			End Set
		End Property

		Friend Overridable Property Label16() As Label
			Get
				Return Me._Label16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label16 = value
			End Set
		End Property

		Friend Overridable Property txtTblFillColor() As TextBox
			Get
				Return Me._txtTblFillColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTblFillColor_DoubleClick
				If Me._txtTblFillColor IsNot Nothing Then
					RemoveHandler Me._txtTblFillColor.DoubleClick, value2
				End If
				Me._txtTblFillColor = value
				If Me._txtTblFillColor IsNot Nothing Then
					AddHandler Me._txtTblFillColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtTblLineColor() As TextBox
			Get
				Return Me._txtTblLineColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTblLineColor_DoubleClick
				If Me._txtTblLineColor IsNot Nothing Then
					RemoveHandler Me._txtTblLineColor.DoubleClick, value2
				End If
				Me._txtTblLineColor = value
				If Me._txtTblLineColor IsNot Nothing Then
					AddHandler Me._txtTblLineColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtTblBorderColor() As TextBox
			Get
				Return Me._txtTblBorderColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTblBorderColor_DoubleClick
				If Me._txtTblBorderColor IsNot Nothing Then
					RemoveHandler Me._txtTblBorderColor.DoubleClick, value2
				End If
				Me._txtTblBorderColor = value
				If Me._txtTblBorderColor IsNot Nothing Then
					AddHandler Me._txtTblBorderColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudTblAlpha() As NumericUpDown
			Get
				Return Me._nudTblAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudTblAlpha = value
			End Set
		End Property

		Friend Overridable Property Label17() As Label
			Get
				Return Me._Label17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label17 = value
			End Set
		End Property

		Friend Overridable Property nudTblLineW() As NumericUpDown
			Get
				Return Me._nudTblLineW
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudTblLineW = value
			End Set
		End Property

		Friend Overridable Property Label18() As Label
			Get
				Return Me._Label18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label18 = value
			End Set
		End Property

		Friend Overridable Property nudTblBorderW() As NumericUpDown
			Get
				Return Me._nudTblBorderW
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudTblBorderW = value
			End Set
		End Property

		Friend Overridable Property Label19() As Label
			Get
				Return Me._Label19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label19 = value
			End Set
		End Property

		Friend Overridable Property TabMuiTen() As TabPage
			Get
				Return Me._TabMuiTen
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabMuiTen = value
			End Set
		End Property

		Friend Overridable Property txtMTDoRong() As TextBox
			Get
				Return Me._txtMTDoRong
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMTDoRong = value
			End Set
		End Property

		Friend Overridable Property Label26() As Label
			Get
				Return Me._Label26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label26 = value
			End Set
		End Property

		Friend Overridable Property txtMTFillColor() As TextBox
			Get
				Return Me._txtMTFillColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMTFillColor_DoubleClick
				If Me._txtMTFillColor IsNot Nothing Then
					RemoveHandler Me._txtMTFillColor.DoubleClick, value2
				End If
				Me._txtMTFillColor = value
				If Me._txtMTFillColor IsNot Nothing Then
					AddHandler Me._txtMTFillColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMT2Color() As TextBox
			Get
				Return Me._txtMT2Color
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMT2Color_DoubleClick
				If Me._txtMT2Color IsNot Nothing Then
					RemoveHandler Me._txtMT2Color.DoubleClick, value2
				End If
				Me._txtMT2Color = value
				If Me._txtMT2Color IsNot Nothing Then
					AddHandler Me._txtMT2Color.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMT1Color() As TextBox
			Get
				Return Me._txtMT1Color
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMT1Color_DoubleClick
				If Me._txtMT1Color IsNot Nothing Then
					RemoveHandler Me._txtMT1Color.DoubleClick, value2
				End If
				Me._txtMT1Color = value
				If Me._txtMT1Color IsNot Nothing Then
					AddHandler Me._txtMT1Color.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudMTAlpha() As NumericUpDown
			Get
				Return Me._nudMTAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudMTAlpha = value
			End Set
		End Property

		Friend Overridable Property Label22() As Label
			Get
				Return Me._Label22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label22 = value
			End Set
		End Property

		Friend Overridable Property chkMTFill() As CheckBox
			Get
				Return Me._chkMTFill
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkMTFill = value
			End Set
		End Property

		Friend Overridable Property nudMTPen2W() As NumericUpDown
			Get
				Return Me._nudMTPen2W
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudMTPen2W = value
			End Set
		End Property

		Friend Overridable Property Label23() As Label
			Get
				Return Me._Label23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label23 = value
			End Set
		End Property

		Friend Overridable Property nudMTPen1W() As NumericUpDown
			Get
				Return Me._nudMTPen1W
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudMTPen1W = value
			End Set
		End Property

		Friend Overridable Property Label24() As Label
			Get
				Return Me._Label24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label24 = value
			End Set
		End Property

		Friend Overridable Property TabSongSong() As TabPage
			Get
				Return Me._TabSongSong
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabSongSong = value
			End Set
		End Property

		Friend Overridable Property nudSSLinesNo() As NumericUpDown
			Get
				Return Me._nudSSLinesNo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudSSLinesNo = value
			End Set
		End Property

		Friend Overridable Property Label13() As Label
			Get
				Return Me._Label13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label13 = value
			End Set
		End Property

		Friend Overridable Property nudSSSize() As NumericUpDown
			Get
				Return Me._nudSSSize
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudSSSize = value
			End Set
		End Property

		Friend Overridable Property Label12() As Label
			Get
				Return Me._Label12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label12 = value
			End Set
		End Property

		Friend Overridable Property txtSS2Color() As TextBox
			Get
				Return Me._txtSS2Color
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSS2Color_DoubleClick
				If Me._txtSS2Color IsNot Nothing Then
					RemoveHandler Me._txtSS2Color.DoubleClick, value2
				End If
				Me._txtSS2Color = value
				If Me._txtSS2Color IsNot Nothing Then
					AddHandler Me._txtSS2Color.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtSS1Color() As TextBox
			Get
				Return Me._txtSS1Color
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSS1Color_DoubleClick
				If Me._txtSS1Color IsNot Nothing Then
					RemoveHandler Me._txtSS1Color.DoubleClick, value2
				End If
				Me._txtSS1Color = value
				If Me._txtSS1Color IsNot Nothing Then
					AddHandler Me._txtSS1Color.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudSSPen2W() As NumericUpDown
			Get
				Return Me._nudSSPen2W
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudSSPen2W = value
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

		Friend Overridable Property nudSSPen1W() As NumericUpDown
			Get
				Return Me._nudSSPen1W
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudSSPen1W = value
			End Set
		End Property

		Friend Overridable Property Label11() As Label
			Get
				Return Me._Label11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		Friend Overridable Property TabMuiTenTyLe() As TabPage
			Get
				Return Me._TabMuiTenTyLe
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabMuiTenTyLe = value
			End Set
		End Property

		Friend Overridable Property TabText() As TabPage
			Get
				Return Me._TabText
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabText = value
			End Set
		End Property

		Friend Overridable Property txtTextFont() As TextBox
			Get
				Return Me._txtTextFont
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTextFont_DoubleClick
				If Me._txtTextFont IsNot Nothing Then
					RemoveHandler Me._txtTextFont.DoubleClick, value2
				End If
				Me._txtTextFont = value
				If Me._txtTextFont IsNot Nothing Then
					AddHandler Me._txtTextFont.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property TabGrid() As TabPage
			Get
				Return Me._TabGrid
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabGrid = value
			End Set
		End Property

		Friend Overridable Property Label14() As Label
			Get
				Return Me._Label14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label14 = value
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

		Friend Overridable Property Label15() As Label
			Get
				Return Me._Label15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label15 = value
			End Set
		End Property

		Friend Overridable Property TabUndo() As TabPage
			Get
				Return Me._TabUndo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabUndo = value
			End Set
		End Property

		Friend Overridable Property nudUndosNo() As NumericUpDown
			Get
				Return Me._nudUndosNo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudUndosNo = value
			End Set
		End Property

		Friend Overridable Property Label25() As Label
			Get
				Return Me._Label25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label25 = value
			End Set
		End Property

		Friend Overridable Property btnSave() As Button
			Get
				Return Me._btnSave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnSave_Click
				If Me._btnSave IsNot Nothing Then
					RemoveHandler Me._btnSave.Click, value2
				End If
				Me._btnSave = value
				If Me._btnSave IsNot Nothing Then
					AddHandler Me._btnSave.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMTDDoRong() As TextBox
			Get
				Return Me._txtMTDDoRong
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMTDDoRong = value
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

		Friend Overridable Property txtMTDDoDai() As TextBox
			Get
				Return Me._txtMTDDoDai
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMTDDoDai = value
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

		Friend Overridable Property txtMTDFillColor() As TextBox
			Get
				Return Me._txtMTDFillColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMTDFillColor_DoubleClick
				If Me._txtMTDFillColor IsNot Nothing Then
					RemoveHandler Me._txtMTDFillColor.DoubleClick, value2
				End If
				Me._txtMTDFillColor = value
				If Me._txtMTDFillColor IsNot Nothing Then
					AddHandler Me._txtMTDFillColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMTD2Color() As TextBox
			Get
				Return Me._txtMTD2Color
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMTD2Color_DoubleClick
				If Me._txtMTD2Color IsNot Nothing Then
					RemoveHandler Me._txtMTD2Color.DoubleClick, value2
				End If
				Me._txtMTD2Color = value
				If Me._txtMTD2Color IsNot Nothing Then
					AddHandler Me._txtMTD2Color.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMTD1Color() As TextBox
			Get
				Return Me._txtMTD1Color
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMTD1Color_DoubleClick
				If Me._txtMTD1Color IsNot Nothing Then
					RemoveHandler Me._txtMTD1Color.DoubleClick, value2
				End If
				Me._txtMTD1Color = value
				If Me._txtMTD1Color IsNot Nothing Then
					AddHandler Me._txtMTD1Color.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property nudMTDAlpha() As NumericUpDown
			Get
				Return Me._nudMTDAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudMTDAlpha = value
			End Set
		End Property

		Friend Overridable Property Label7() As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		Friend Overridable Property chkMTDFill() As CheckBox
			Get
				Return Me._chkMTDFill
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkMTDFill = value
			End Set
		End Property

		Friend Overridable Property nudMTDPen2W() As NumericUpDown
			Get
				Return Me._nudMTDPen2W
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudMTDPen2W = value
			End Set
		End Property

		Friend Overridable Property Label9() As Label
			Get
				Return Me._Label9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		Friend Overridable Property nudMTDPen1W() As NumericUpDown
			Get
				Return Me._nudMTDPen1W
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._nudMTDPen1W = value
			End Set
		End Property

		Friend Overridable Property Label27() As Label
			Get
				Return Me._Label27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label27 = value
			End Set
		End Property

		Friend Overridable Property TabColorTable() As TabPage
			Get
				Return Me._TabColorTable
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabColorTable = value
			End Set
		End Property

		Friend Overridable Property GroupBox1() As GroupBox
			Get
				Return Me._GroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As PaintEventHandler = AddressOf Me.GroupBox1_Paint
				If Me._GroupBox1 IsNot Nothing Then
					RemoveHandler Me._GroupBox1.Paint, value2
				End If
				Me._GroupBox1 = value
				If Me._GroupBox1 IsNot Nothing Then
					AddHandler Me._GroupBox1.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtColor32() As TextBox
			Get
				Return Me._txtColor32
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor32 IsNot Nothing Then
					RemoveHandler Me._txtColor32.GotFocus, value2
					RemoveHandler Me._txtColor32.DoubleClick, value3
				End If
				Me._txtColor32 = value
				If Me._txtColor32 IsNot Nothing Then
					AddHandler Me._txtColor32.GotFocus, value2
					AddHandler Me._txtColor32.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor24() As TextBox
			Get
				Return Me._txtColor24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor24 IsNot Nothing Then
					RemoveHandler Me._txtColor24.GotFocus, value2
					RemoveHandler Me._txtColor24.DoubleClick, value3
				End If
				Me._txtColor24 = value
				If Me._txtColor24 IsNot Nothing Then
					AddHandler Me._txtColor24.GotFocus, value2
					AddHandler Me._txtColor24.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor16() As TextBox
			Get
				Return Me._txtColor16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor16 IsNot Nothing Then
					RemoveHandler Me._txtColor16.GotFocus, value2
					RemoveHandler Me._txtColor16.DoubleClick, value3
				End If
				Me._txtColor16 = value
				If Me._txtColor16 IsNot Nothing Then
					AddHandler Me._txtColor16.GotFocus, value2
					AddHandler Me._txtColor16.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor08() As TextBox
			Get
				Return Me._txtColor08
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor08 IsNot Nothing Then
					RemoveHandler Me._txtColor08.GotFocus, value2
					RemoveHandler Me._txtColor08.DoubleClick, value3
				End If
				Me._txtColor08 = value
				If Me._txtColor08 IsNot Nothing Then
					AddHandler Me._txtColor08.GotFocus, value2
					AddHandler Me._txtColor08.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor31() As TextBox
			Get
				Return Me._txtColor31
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor31 IsNot Nothing Then
					RemoveHandler Me._txtColor31.GotFocus, value2
					RemoveHandler Me._txtColor31.DoubleClick, value3
				End If
				Me._txtColor31 = value
				If Me._txtColor31 IsNot Nothing Then
					AddHandler Me._txtColor31.GotFocus, value2
					AddHandler Me._txtColor31.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor30() As TextBox
			Get
				Return Me._txtColor30
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor30 IsNot Nothing Then
					RemoveHandler Me._txtColor30.GotFocus, value2
					RemoveHandler Me._txtColor30.DoubleClick, value3
				End If
				Me._txtColor30 = value
				If Me._txtColor30 IsNot Nothing Then
					AddHandler Me._txtColor30.GotFocus, value2
					AddHandler Me._txtColor30.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor29() As TextBox
			Get
				Return Me._txtColor29
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor29 IsNot Nothing Then
					RemoveHandler Me._txtColor29.GotFocus, value2
					RemoveHandler Me._txtColor29.DoubleClick, value3
				End If
				Me._txtColor29 = value
				If Me._txtColor29 IsNot Nothing Then
					AddHandler Me._txtColor29.GotFocus, value2
					AddHandler Me._txtColor29.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor28() As TextBox
			Get
				Return Me._txtColor28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor28 IsNot Nothing Then
					RemoveHandler Me._txtColor28.GotFocus, value2
					RemoveHandler Me._txtColor28.DoubleClick, value3
				End If
				Me._txtColor28 = value
				If Me._txtColor28 IsNot Nothing Then
					AddHandler Me._txtColor28.GotFocus, value2
					AddHandler Me._txtColor28.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor27() As TextBox
			Get
				Return Me._txtColor27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor27 IsNot Nothing Then
					RemoveHandler Me._txtColor27.GotFocus, value2
					RemoveHandler Me._txtColor27.DoubleClick, value3
				End If
				Me._txtColor27 = value
				If Me._txtColor27 IsNot Nothing Then
					AddHandler Me._txtColor27.GotFocus, value2
					AddHandler Me._txtColor27.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor26() As TextBox
			Get
				Return Me._txtColor26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor26 IsNot Nothing Then
					RemoveHandler Me._txtColor26.GotFocus, value2
					RemoveHandler Me._txtColor26.DoubleClick, value3
				End If
				Me._txtColor26 = value
				If Me._txtColor26 IsNot Nothing Then
					AddHandler Me._txtColor26.GotFocus, value2
					AddHandler Me._txtColor26.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor25() As TextBox
			Get
				Return Me._txtColor25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor25 IsNot Nothing Then
					RemoveHandler Me._txtColor25.GotFocus, value2
					RemoveHandler Me._txtColor25.DoubleClick, value3
				End If
				Me._txtColor25 = value
				If Me._txtColor25 IsNot Nothing Then
					AddHandler Me._txtColor25.GotFocus, value2
					AddHandler Me._txtColor25.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor23() As TextBox
			Get
				Return Me._txtColor23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor23 IsNot Nothing Then
					RemoveHandler Me._txtColor23.GotFocus, value2
					RemoveHandler Me._txtColor23.DoubleClick, value3
				End If
				Me._txtColor23 = value
				If Me._txtColor23 IsNot Nothing Then
					AddHandler Me._txtColor23.GotFocus, value2
					AddHandler Me._txtColor23.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor22() As TextBox
			Get
				Return Me._txtColor22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor22 IsNot Nothing Then
					RemoveHandler Me._txtColor22.GotFocus, value2
					RemoveHandler Me._txtColor22.DoubleClick, value3
				End If
				Me._txtColor22 = value
				If Me._txtColor22 IsNot Nothing Then
					AddHandler Me._txtColor22.GotFocus, value2
					AddHandler Me._txtColor22.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor21() As TextBox
			Get
				Return Me._txtColor21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor21 IsNot Nothing Then
					RemoveHandler Me._txtColor21.GotFocus, value2
					RemoveHandler Me._txtColor21.DoubleClick, value3
				End If
				Me._txtColor21 = value
				If Me._txtColor21 IsNot Nothing Then
					AddHandler Me._txtColor21.GotFocus, value2
					AddHandler Me._txtColor21.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor20() As TextBox
			Get
				Return Me._txtColor20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor20 IsNot Nothing Then
					RemoveHandler Me._txtColor20.GotFocus, value2
					RemoveHandler Me._txtColor20.DoubleClick, value3
				End If
				Me._txtColor20 = value
				If Me._txtColor20 IsNot Nothing Then
					AddHandler Me._txtColor20.GotFocus, value2
					AddHandler Me._txtColor20.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor19() As TextBox
			Get
				Return Me._txtColor19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor19 IsNot Nothing Then
					RemoveHandler Me._txtColor19.GotFocus, value2
					RemoveHandler Me._txtColor19.DoubleClick, value3
				End If
				Me._txtColor19 = value
				If Me._txtColor19 IsNot Nothing Then
					AddHandler Me._txtColor19.GotFocus, value2
					AddHandler Me._txtColor19.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor18() As TextBox
			Get
				Return Me._txtColor18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor18 IsNot Nothing Then
					RemoveHandler Me._txtColor18.GotFocus, value2
					RemoveHandler Me._txtColor18.DoubleClick, value3
				End If
				Me._txtColor18 = value
				If Me._txtColor18 IsNot Nothing Then
					AddHandler Me._txtColor18.GotFocus, value2
					AddHandler Me._txtColor18.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor17() As TextBox
			Get
				Return Me._txtColor17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor17 IsNot Nothing Then
					RemoveHandler Me._txtColor17.GotFocus, value2
					RemoveHandler Me._txtColor17.DoubleClick, value3
				End If
				Me._txtColor17 = value
				If Me._txtColor17 IsNot Nothing Then
					AddHandler Me._txtColor17.GotFocus, value2
					AddHandler Me._txtColor17.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor15() As TextBox
			Get
				Return Me._txtColor15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor15 IsNot Nothing Then
					RemoveHandler Me._txtColor15.GotFocus, value2
					RemoveHandler Me._txtColor15.DoubleClick, value3
				End If
				Me._txtColor15 = value
				If Me._txtColor15 IsNot Nothing Then
					AddHandler Me._txtColor15.GotFocus, value2
					AddHandler Me._txtColor15.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor14() As TextBox
			Get
				Return Me._txtColor14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor14 IsNot Nothing Then
					RemoveHandler Me._txtColor14.GotFocus, value2
					RemoveHandler Me._txtColor14.DoubleClick, value3
				End If
				Me._txtColor14 = value
				If Me._txtColor14 IsNot Nothing Then
					AddHandler Me._txtColor14.GotFocus, value2
					AddHandler Me._txtColor14.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor13() As TextBox
			Get
				Return Me._txtColor13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor13 IsNot Nothing Then
					RemoveHandler Me._txtColor13.GotFocus, value2
					RemoveHandler Me._txtColor13.DoubleClick, value3
				End If
				Me._txtColor13 = value
				If Me._txtColor13 IsNot Nothing Then
					AddHandler Me._txtColor13.GotFocus, value2
					AddHandler Me._txtColor13.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor12() As TextBox
			Get
				Return Me._txtColor12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor12 IsNot Nothing Then
					RemoveHandler Me._txtColor12.GotFocus, value2
					RemoveHandler Me._txtColor12.DoubleClick, value3
				End If
				Me._txtColor12 = value
				If Me._txtColor12 IsNot Nothing Then
					AddHandler Me._txtColor12.GotFocus, value2
					AddHandler Me._txtColor12.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor11() As TextBox
			Get
				Return Me._txtColor11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor11 IsNot Nothing Then
					RemoveHandler Me._txtColor11.GotFocus, value2
					RemoveHandler Me._txtColor11.DoubleClick, value3
				End If
				Me._txtColor11 = value
				If Me._txtColor11 IsNot Nothing Then
					AddHandler Me._txtColor11.GotFocus, value2
					AddHandler Me._txtColor11.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor10() As TextBox
			Get
				Return Me._txtColor10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor10 IsNot Nothing Then
					RemoveHandler Me._txtColor10.GotFocus, value2
					RemoveHandler Me._txtColor10.DoubleClick, value3
				End If
				Me._txtColor10 = value
				If Me._txtColor10 IsNot Nothing Then
					AddHandler Me._txtColor10.GotFocus, value2
					AddHandler Me._txtColor10.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor09() As TextBox
			Get
				Return Me._txtColor09
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor09 IsNot Nothing Then
					RemoveHandler Me._txtColor09.GotFocus, value2
					RemoveHandler Me._txtColor09.DoubleClick, value3
				End If
				Me._txtColor09 = value
				If Me._txtColor09 IsNot Nothing Then
					AddHandler Me._txtColor09.GotFocus, value2
					AddHandler Me._txtColor09.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor07() As TextBox
			Get
				Return Me._txtColor07
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor07 IsNot Nothing Then
					RemoveHandler Me._txtColor07.GotFocus, value2
					RemoveHandler Me._txtColor07.DoubleClick, value3
				End If
				Me._txtColor07 = value
				If Me._txtColor07 IsNot Nothing Then
					AddHandler Me._txtColor07.GotFocus, value2
					AddHandler Me._txtColor07.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor06() As TextBox
			Get
				Return Me._txtColor06
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor06 IsNot Nothing Then
					RemoveHandler Me._txtColor06.GotFocus, value2
					RemoveHandler Me._txtColor06.DoubleClick, value3
				End If
				Me._txtColor06 = value
				If Me._txtColor06 IsNot Nothing Then
					AddHandler Me._txtColor06.GotFocus, value2
					AddHandler Me._txtColor06.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor05() As TextBox
			Get
				Return Me._txtColor05
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor05 IsNot Nothing Then
					RemoveHandler Me._txtColor05.GotFocus, value2
					RemoveHandler Me._txtColor05.DoubleClick, value3
				End If
				Me._txtColor05 = value
				If Me._txtColor05 IsNot Nothing Then
					AddHandler Me._txtColor05.GotFocus, value2
					AddHandler Me._txtColor05.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor04() As TextBox
			Get
				Return Me._txtColor04
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor04 IsNot Nothing Then
					RemoveHandler Me._txtColor04.GotFocus, value2
					RemoveHandler Me._txtColor04.DoubleClick, value3
				End If
				Me._txtColor04 = value
				If Me._txtColor04 IsNot Nothing Then
					AddHandler Me._txtColor04.GotFocus, value2
					AddHandler Me._txtColor04.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor03() As TextBox
			Get
				Return Me._txtColor03
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor03 IsNot Nothing Then
					RemoveHandler Me._txtColor03.GotFocus, value2
					RemoveHandler Me._txtColor03.DoubleClick, value3
				End If
				Me._txtColor03 = value
				If Me._txtColor03 IsNot Nothing Then
					AddHandler Me._txtColor03.GotFocus, value2
					AddHandler Me._txtColor03.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor02() As TextBox
			Get
				Return Me._txtColor02
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor02 IsNot Nothing Then
					RemoveHandler Me._txtColor02.GotFocus, value2
					RemoveHandler Me._txtColor02.DoubleClick, value3
				End If
				Me._txtColor02 = value
				If Me._txtColor02 IsNot Nothing Then
					AddHandler Me._txtColor02.GotFocus, value2
					AddHandler Me._txtColor02.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtColor01() As TextBox
			Get
				Return Me._txtColor01
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtColor01_GotFocus
				Dim value3 As EventHandler = AddressOf Me.txtColor01_DoubleClick
				If Me._txtColor01 IsNot Nothing Then
					RemoveHandler Me._txtColor01.GotFocus, value2
					RemoveHandler Me._txtColor01.DoubleClick, value3
				End If
				Me._txtColor01 = value
				If Me._txtColor01 IsNot Nothing Then
					AddHandler Me._txtColor01.GotFocus, value2
					AddHandler Me._txtColor01.DoubleClick, value3
				End If
			End Set
		End Property

		Friend Overridable Property txtQuanXanhColor() As TextBox
			Get
				Return Me._txtQuanXanhColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtQuanXanhColor_DoubleClick
				If Me._txtQuanXanhColor IsNot Nothing Then
					RemoveHandler Me._txtQuanXanhColor.DoubleClick, value2
				End If
				Me._txtQuanXanhColor = value
				If Me._txtQuanXanhColor IsNot Nothing Then
					AddHandler Me._txtQuanXanhColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label28() As Label
			Get
				Return Me._Label28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label28 = value
			End Set
		End Property

		Friend Overridable Property txtQuanDoColor() As TextBox
			Get
				Return Me._txtQuanDoColor
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtQuanDoColor_DoubleClick
				If Me._txtQuanDoColor IsNot Nothing Then
					RemoveHandler Me._txtQuanDoColor.DoubleClick, value2
				End If
				Me._txtQuanDoColor = value
				If Me._txtQuanDoColor IsNot Nothing Then
					AddHandler Me._txtQuanDoColor.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property Label10() As Label
			Get
				Return Me._Label10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgOptions_Load
			AddHandler MyBase.Closing, AddressOf Me.frmOptions_Closing
			Me.myRect = Nothing
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
			Me.TabControl1 = New TabControl()
			Me.TabGeneral = New TabPage()
			Me.nudLineStyle = New NumericUpDown()
			Me.Label6 = New Label()
			Me.txtBrushColor = New TextBox()
			Me.txtColor2 = New TextBox()
			Me.txtColor = New TextBox()
			Me.nudAlpha = New NumericUpDown()
			Me.Label1 = New Label()
			Me.chkBrush = New CheckBox()
			Me.nudPenWidth2 = New NumericUpDown()
			Me.Label8 = New Label()
			Me.nudPenWidth = New NumericUpDown()
			Me.Label5 = New Label()
			Me.TabMuiTen = New TabPage()
			Me.txtMTDoRong = New TextBox()
			Me.Label26 = New Label()
			Me.txtMTFillColor = New TextBox()
			Me.txtMT2Color = New TextBox()
			Me.txtMT1Color = New TextBox()
			Me.nudMTAlpha = New NumericUpDown()
			Me.Label22 = New Label()
			Me.chkMTFill = New CheckBox()
			Me.nudMTPen2W = New NumericUpDown()
			Me.Label23 = New Label()
			Me.nudMTPen1W = New NumericUpDown()
			Me.Label24 = New Label()
			Me.TabMuiTenTyLe = New TabPage()
			Me.txtMTDDoRong = New TextBox()
			Me.Label2 = New Label()
			Me.txtMTDDoDai = New TextBox()
			Me.Label3 = New Label()
			Me.txtMTDFillColor = New TextBox()
			Me.txtMTD2Color = New TextBox()
			Me.txtMTD1Color = New TextBox()
			Me.nudMTDAlpha = New NumericUpDown()
			Me.Label7 = New Label()
			Me.chkMTDFill = New CheckBox()
			Me.nudMTDPen2W = New NumericUpDown()
			Me.Label9 = New Label()
			Me.nudMTDPen1W = New NumericUpDown()
			Me.Label27 = New Label()
			Me.TabSongSong = New TabPage()
			Me.nudSSLinesNo = New NumericUpDown()
			Me.Label13 = New Label()
			Me.nudSSSize = New NumericUpDown()
			Me.Label12 = New Label()
			Me.txtSS2Color = New TextBox()
			Me.txtSS1Color = New TextBox()
			Me.nudSSPen2W = New NumericUpDown()
			Me.Label4 = New Label()
			Me.nudSSPen1W = New NumericUpDown()
			Me.Label11 = New Label()
			Me.TabText = New TabPage()
			Me.txtTextFont = New TextBox()
			Me.TabTable = New TabPage()
			Me.txtTableFont = New TextBox()
			Me.nudTblRowsNo = New NumericUpDown()
			Me.Label21 = New Label()
			Me.nudTblColsNo = New NumericUpDown()
			Me.Label20 = New Label()
			Me.Label16 = New Label()
			Me.txtTblFillColor = New TextBox()
			Me.txtTblLineColor = New TextBox()
			Me.txtTblBorderColor = New TextBox()
			Me.nudTblAlpha = New NumericUpDown()
			Me.Label17 = New Label()
			Me.nudTblLineW = New NumericUpDown()
			Me.Label18 = New Label()
			Me.nudTblBorderW = New NumericUpDown()
			Me.Label19 = New Label()
			Me.TabGrid = New TabPage()
			Me.Label14 = New Label()
			Me.nudGrid = New NumericUpDown()
			Me.Label15 = New Label()
			Me.TabColorTable = New TabPage()
			Me.GroupBox1 = New GroupBox()
			Me.txtColor32 = New TextBox()
			Me.txtColor24 = New TextBox()
			Me.txtColor16 = New TextBox()
			Me.txtColor08 = New TextBox()
			Me.txtColor31 = New TextBox()
			Me.txtColor30 = New TextBox()
			Me.txtColor29 = New TextBox()
			Me.txtColor28 = New TextBox()
			Me.txtColor27 = New TextBox()
			Me.txtColor26 = New TextBox()
			Me.txtColor25 = New TextBox()
			Me.txtColor23 = New TextBox()
			Me.txtColor22 = New TextBox()
			Me.txtColor21 = New TextBox()
			Me.txtColor20 = New TextBox()
			Me.txtColor19 = New TextBox()
			Me.txtColor18 = New TextBox()
			Me.txtColor17 = New TextBox()
			Me.txtColor15 = New TextBox()
			Me.txtColor14 = New TextBox()
			Me.txtColor13 = New TextBox()
			Me.txtColor12 = New TextBox()
			Me.txtColor11 = New TextBox()
			Me.txtColor10 = New TextBox()
			Me.txtColor09 = New TextBox()
			Me.txtColor07 = New TextBox()
			Me.txtColor06 = New TextBox()
			Me.txtColor05 = New TextBox()
			Me.txtColor04 = New TextBox()
			Me.txtColor03 = New TextBox()
			Me.txtColor02 = New TextBox()
			Me.txtColor01 = New TextBox()
			Me.txtQuanXanhColor = New TextBox()
			Me.Label28 = New Label()
			Me.txtQuanDoColor = New TextBox()
			Me.Label10 = New Label()
			Me.TabUndo = New TabPage()
			Me.nudUndosNo = New NumericUpDown()
			Me.Label25 = New Label()
			Me.btnSave = New Button()
			Me.TabControl1.SuspendLayout()
			Me.TabGeneral.SuspendLayout()
			(CType(Me.nudLineStyle, ISupportInitialize)).BeginInit()
			(CType(Me.nudAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.nudPenWidth2, ISupportInitialize)).BeginInit()
			(CType(Me.nudPenWidth, ISupportInitialize)).BeginInit()
			Me.TabMuiTen.SuspendLayout()
			(CType(Me.nudMTAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.nudMTPen2W, ISupportInitialize)).BeginInit()
			(CType(Me.nudMTPen1W, ISupportInitialize)).BeginInit()
			Me.TabMuiTenTyLe.SuspendLayout()
			(CType(Me.nudMTDAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.nudMTDPen2W, ISupportInitialize)).BeginInit()
			(CType(Me.nudMTDPen1W, ISupportInitialize)).BeginInit()
			Me.TabSongSong.SuspendLayout()
			(CType(Me.nudSSLinesNo, ISupportInitialize)).BeginInit()
			(CType(Me.nudSSSize, ISupportInitialize)).BeginInit()
			(CType(Me.nudSSPen2W, ISupportInitialize)).BeginInit()
			(CType(Me.nudSSPen1W, ISupportInitialize)).BeginInit()
			Me.TabText.SuspendLayout()
			Me.TabTable.SuspendLayout()
			(CType(Me.nudTblRowsNo, ISupportInitialize)).BeginInit()
			(CType(Me.nudTblColsNo, ISupportInitialize)).BeginInit()
			(CType(Me.nudTblAlpha, ISupportInitialize)).BeginInit()
			(CType(Me.nudTblLineW, ISupportInitialize)).BeginInit()
			(CType(Me.nudTblBorderW, ISupportInitialize)).BeginInit()
			Me.TabGrid.SuspendLayout()
			(CType(Me.nudGrid, ISupportInitialize)).BeginInit()
			Me.TabColorTable.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.TabUndo.SuspendLayout()
			(CType(Me.nudUndosNo, ISupportInitialize)).BeginInit()
			Me.SuspendLayout()
			Me.TabControl1.Controls.Add(Me.TabColorTable)
			Me.TabControl1.Controls.Add(Me.TabGeneral)
			Me.TabControl1.Controls.Add(Me.TabMuiTen)
			Me.TabControl1.Controls.Add(Me.TabMuiTenTyLe)
			Me.TabControl1.Controls.Add(Me.TabSongSong)
			Me.TabControl1.Controls.Add(Me.TabText)
			Me.TabControl1.Controls.Add(Me.TabTable)
			Me.TabControl1.Controls.Add(Me.TabGrid)
			Me.TabControl1.Controls.Add(Me.TabUndo)
			Dim arg_745_0 As Control = Me.TabControl1
			Dim location As Point = New Point(16, 12)
			arg_745_0.Location = location
			Me.TabControl1.Name = "TabControl1"
			Me.TabControl1.SelectedIndex = 0
			Dim arg_77E_0 As Control = Me.TabControl1
			Dim size As Size = New Size(462, 168)
			arg_77E_0.Size = size
			Me.TabControl1.TabIndex = 1
			Me.TabGeneral.Controls.Add(Me.nudLineStyle)
			Me.TabGeneral.Controls.Add(Me.Label6)
			Me.TabGeneral.Controls.Add(Me.txtBrushColor)
			Me.TabGeneral.Controls.Add(Me.txtColor2)
			Me.TabGeneral.Controls.Add(Me.txtColor)
			Me.TabGeneral.Controls.Add(Me.nudAlpha)
			Me.TabGeneral.Controls.Add(Me.Label1)
			Me.TabGeneral.Controls.Add(Me.chkBrush)
			Me.TabGeneral.Controls.Add(Me.nudPenWidth2)
			Me.TabGeneral.Controls.Add(Me.Label8)
			Me.TabGeneral.Controls.Add(Me.nudPenWidth)
			Me.TabGeneral.Controls.Add(Me.Label5)
			Dim arg_8A8_0 As TabPage = Me.TabGeneral
			location = New Point(4, 22)
			arg_8A8_0.Location = location
			Me.TabGeneral.Name = "TabGeneral"
			Dim arg_8D5_0 As Control = Me.TabGeneral
			size = New Size(454, 142)
			arg_8D5_0.Size = size
			Me.TabGeneral.TabIndex = 2
			Me.TabGeneral.Text = "Chung"
			Me.TabGeneral.UseVisualStyleBackColor = True
			Dim arg_917_0 As Control = Me.nudLineStyle
			location = New Point(304, 24)
			arg_917_0.Location = location
			Dim arg_94D_0 As NumericUpDown = Me.nudLineStyle
			Dim num As Decimal = New Decimal(New Integer() { 300, 0, 0, 0 })
			arg_94D_0.Maximum = num
			Me.nudLineStyle.Name = "nudLineStyle"
			Dim arg_974_0 As Control = Me.nudLineStyle
			size = New Size(40, 21)
			arg_974_0.Size = size
			Me.nudLineStyle.TabIndex = 91
			Dim arg_9B3_0 As NumericUpDown = Me.nudLineStyle
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_9B3_0.Value = num
			Dim arg_9CD_0 As Control = Me.Label6
			location = New Point(256, 24)
			arg_9CD_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_9F4_0 As Control = Me.Label6
			size = New Size(48, 16)
			arg_9F4_0.Size = size
			Me.Label6.TabIndex = 90
			Me.Label6.Text = "Ki" & ChrW(7875) & "u nét:"
			Me.txtBrushColor.BackColor = Color.Red
			Me.txtBrushColor.ForeColor = SystemColors.HighlightText
			Dim arg_A4B_0 As Control = Me.txtBrushColor
			location = New Point(208, 24)
			arg_A4B_0.Location = location
			Me.txtBrushColor.Name = "txtBrushColor"
			Dim arg_A72_0 As Control = Me.txtBrushColor
			size = New Size(24, 21)
			arg_A72_0.Size = size
			Me.txtBrushColor.TabIndex = 87
			Me.txtColor2.BackColor = Color.Yellow
			Me.txtColor2.ForeColor = SystemColors.HighlightText
			Dim arg_AB6_0 As Control = Me.txtColor2
			location = New Point(72, 48)
			arg_AB6_0.Location = location
			Me.txtColor2.Name = "txtColor2"
			Dim arg_ADD_0 As Control = Me.txtColor2
			size = New Size(24, 21)
			arg_ADD_0.Size = size
			Me.txtColor2.TabIndex = 84
			Me.txtColor.BackColor = Color.Red
			Me.txtColor.ForeColor = SystemColors.HighlightText
			Dim arg_B21_0 As Control = Me.txtColor
			location = New Point(72, 24)
			arg_B21_0.Location = location
			Me.txtColor.Name = "txtColor"
			Dim arg_B48_0 As Control = Me.txtColor
			size = New Size(24, 21)
			arg_B48_0.Size = size
			Me.txtColor.TabIndex = 81
			Dim arg_B6F_0 As Control = Me.nudAlpha
			location = New Point(192, 48)
			arg_B6F_0.Location = location
			Dim arg_BA5_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_BA5_0.Maximum = num
			Me.nudAlpha.Name = "nudAlpha"
			Dim arg_BCC_0 As Control = Me.nudAlpha
			size = New Size(40, 21)
			arg_BCC_0.Size = size
			Me.nudAlpha.TabIndex = 89
			Dim arg_C0F_0 As NumericUpDown = Me.nudAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_C0F_0.Value = num
			Dim arg_C29_0 As Control = Me.Label1
			location = New Point(144, 48)
			arg_C29_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_C50_0 As Control = Me.Label1
			size = New Size(48, 16)
			arg_C50_0.Size = size
			Me.Label1.TabIndex = 88
			Me.Label1.Text = ChrW(272) & ChrW(7897) & " m" & ChrW(7901) & ":"
			Dim arg_C87_0 As Control = Me.chkBrush
			location = New Point(144, 24)
			arg_C87_0.Location = location
			Me.chkBrush.Name = "chkBrush"
			Dim arg_CAE_0 As Control = Me.chkBrush
			size = New Size(87, 24)
			arg_CAE_0.Size = size
			Me.chkBrush.TabIndex = 86
			Me.chkBrush.Text = "M" & ChrW(7847) & "u tô"
			Dim arg_CE2_0 As Control = Me.nudPenWidth2
			location = New Point(96, 48)
			arg_CE2_0.Location = location
			Dim arg_D15_0 As NumericUpDown = Me.nudPenWidth2
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_D15_0.Maximum = num
			Me.nudPenWidth2.Name = "nudPenWidth2"
			Dim arg_D3C_0 As Control = Me.nudPenWidth2
			size = New Size(32, 21)
			arg_D3C_0.Size = size
			Me.nudPenWidth2.TabIndex = 85
			Dim arg_D60_0 As Control = Me.Label8
			location = New Point(16, 48)
			arg_D60_0.Location = location
			Me.Label8.Name = "Label8"
			Dim arg_D87_0 As Control = Me.Label8
			size = New Size(56, 16)
			arg_D87_0.Size = size
			Me.Label8.TabIndex = 83
			Me.Label8.Text = "Nét ph" & ChrW(7909) & ":"
			Dim arg_DBB_0 As Control = Me.nudPenWidth
			location = New Point(96, 24)
			arg_DBB_0.Location = location
			Dim arg_DEE_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_DEE_0.Maximum = num
			Dim arg_E20_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_E20_0.Minimum = num
			Me.nudPenWidth.Name = "nudPenWidth"
			Dim arg_E47_0 As Control = Me.nudPenWidth
			size = New Size(32, 21)
			arg_E47_0.Size = size
			Me.nudPenWidth.TabIndex = 82
			Dim arg_E86_0 As NumericUpDown = Me.nudPenWidth
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_E86_0.Value = num
			Dim arg_E9D_0 As Control = Me.Label5
			location = New Point(16, 24)
			arg_E9D_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_EC4_0 As Control = Me.Label5
			size = New Size(56, 16)
			arg_EC4_0.Size = size
			Me.Label5.TabIndex = 80
			Me.Label5.Text = "Nét chính:"
			Me.TabMuiTen.Controls.Add(Me.txtMTDoRong)
			Me.TabMuiTen.Controls.Add(Me.Label26)
			Me.TabMuiTen.Controls.Add(Me.txtMTFillColor)
			Me.TabMuiTen.Controls.Add(Me.txtMT2Color)
			Me.TabMuiTen.Controls.Add(Me.txtMT1Color)
			Me.TabMuiTen.Controls.Add(Me.nudMTAlpha)
			Me.TabMuiTen.Controls.Add(Me.Label22)
			Me.TabMuiTen.Controls.Add(Me.chkMTFill)
			Me.TabMuiTen.Controls.Add(Me.nudMTPen2W)
			Me.TabMuiTen.Controls.Add(Me.Label23)
			Me.TabMuiTen.Controls.Add(Me.nudMTPen1W)
			Me.TabMuiTen.Controls.Add(Me.Label24)
			Dim arg_FFF_0 As TabPage = Me.TabMuiTen
			location = New Point(4, 22)
			arg_FFF_0.Location = location
			Me.TabMuiTen.Name = "TabMuiTen"
			Dim arg_102C_0 As Control = Me.TabMuiTen
			size = New Size(454, 142)
			arg_102C_0.Size = size
			Me.TabMuiTen.TabIndex = 1
			Me.TabMuiTen.Text = "M" & ChrW(361) & "i tên"
			Me.TabMuiTen.UseVisualStyleBackColor = True
			Dim arg_106E_0 As Control = Me.txtMTDoRong
			location = New Point(131, 91)
			arg_106E_0.Location = location
			Me.txtMTDoRong.Name = "txtMTDoRong"
			Dim arg_1095_0 As Control = Me.txtMTDoRong
			size = New Size(40, 21)
			arg_1095_0.Size = size
			Me.txtMTDoRong.TabIndex = 75
			Me.txtMTDoRong.Text = "30"
			Dim arg_10C9_0 As Control = Me.Label26
			location = New Point(75, 91)
			arg_10C9_0.Location = location
			Me.Label26.Name = "Label26"
			Dim arg_10F0_0 As Control = Me.Label26
			size = New Size(56, 23)
			arg_10F0_0.Size = size
			Me.Label26.TabIndex = 74
			Me.Label26.Text = ChrW(272) & ChrW(7897) & " r" & ChrW(7897) & "ng:"
			Me.txtMTFillColor.BackColor = Color.Red
			Me.txtMTFillColor.ForeColor = SystemColors.HighlightText
			Dim arg_1147_0 As Control = Me.txtMTFillColor
			location = New Point(291, 27)
			arg_1147_0.Location = location
			Me.txtMTFillColor.Name = "txtMTFillColor"
			Dim arg_116E_0 As Control = Me.txtMTFillColor
			size = New Size(24, 21)
			arg_116E_0.Size = size
			Me.txtMTFillColor.TabIndex = 71
			Me.txtMT2Color.BackColor = Color.FromArgb(255, 255, 192)
			Me.txtMT2Color.ForeColor = SystemColors.HighlightText
			Dim arg_11C4_0 As Control = Me.txtMT2Color
			location = New Point(131, 51)
			arg_11C4_0.Location = location
			Me.txtMT2Color.Name = "txtMT2Color"
			Dim arg_11EB_0 As Control = Me.txtMT2Color
			size = New Size(24, 21)
			arg_11EB_0.Size = size
			Me.txtMT2Color.TabIndex = 68
			Me.txtMT1Color.BackColor = Color.Red
			Me.txtMT1Color.ForeColor = SystemColors.HighlightText
			Dim arg_1232_0 As Control = Me.txtMT1Color
			location = New Point(131, 27)
			arg_1232_0.Location = location
			Me.txtMT1Color.Name = "txtMT1Color"
			Dim arg_1259_0 As Control = Me.txtMT1Color
			size = New Size(24, 21)
			arg_1259_0.Size = size
			Me.txtMT1Color.TabIndex = 65
			Dim arg_1280_0 As Control = Me.nudMTAlpha
			location = New Point(275, 51)
			arg_1280_0.Location = location
			Dim arg_12B6_0 As NumericUpDown = Me.nudMTAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_12B6_0.Maximum = num
			Me.nudMTAlpha.Name = "nudMTAlpha"
			Dim arg_12DD_0 As Control = Me.nudMTAlpha
			size = New Size(40, 21)
			arg_12DD_0.Size = size
			Me.nudMTAlpha.TabIndex = 73
			Dim arg_1320_0 As NumericUpDown = Me.nudMTAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_1320_0.Value = num
			Dim arg_133A_0 As Control = Me.Label22
			location = New Point(227, 51)
			arg_133A_0.Location = location
			Me.Label22.Name = "Label22"
			Dim arg_1361_0 As Control = Me.Label22
			size = New Size(40, 16)
			arg_1361_0.Size = size
			Me.Label22.TabIndex = 72
			Me.Label22.Text = ChrW(272) & ChrW(7897) & " m" & ChrW(7901) & ":"
			Dim arg_1398_0 As Control = Me.chkMTFill
			location = New Point(227, 27)
			arg_1398_0.Location = location
			Me.chkMTFill.Name = "chkMTFill"
			Dim arg_13BF_0 As Control = Me.chkMTFill
			size = New Size(87, 24)
			arg_13BF_0.Size = size
			Me.chkMTFill.TabIndex = 70
			Me.chkMTFill.Text = "M" & ChrW(7847) & "u tô"
			Dim arg_13F6_0 As Control = Me.nudMTPen2W
			location = New Point(155, 51)
			arg_13F6_0.Location = location
			Dim arg_1429_0 As NumericUpDown = Me.nudMTPen2W
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_1429_0.Maximum = num
			Me.nudMTPen2W.Name = "nudMTPen2W"
			Dim arg_1450_0 As Control = Me.nudMTPen2W
			size = New Size(32, 21)
			arg_1450_0.Size = size
			Me.nudMTPen2W.TabIndex = 69
			Dim arg_1474_0 As Control = Me.Label23
			location = New Point(75, 51)
			arg_1474_0.Location = location
			Me.Label23.Name = "Label23"
			Dim arg_149B_0 As Control = Me.Label23
			size = New Size(56, 16)
			arg_149B_0.Size = size
			Me.Label23.TabIndex = 67
			Me.Label23.Text = "Nét ph" & ChrW(7909) & ":"
			Dim arg_14D2_0 As Control = Me.nudMTPen1W
			location = New Point(155, 27)
			arg_14D2_0.Location = location
			Dim arg_1505_0 As NumericUpDown = Me.nudMTPen1W
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_1505_0.Maximum = num
			Dim arg_1537_0 As NumericUpDown = Me.nudMTPen1W
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_1537_0.Minimum = num
			Me.nudMTPen1W.Name = "nudMTPen1W"
			Dim arg_155E_0 As Control = Me.nudMTPen1W
			size = New Size(32, 21)
			arg_155E_0.Size = size
			Me.nudMTPen1W.TabIndex = 66
			Dim arg_159D_0 As NumericUpDown = Me.nudMTPen1W
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_159D_0.Value = num
			Dim arg_15B4_0 As Control = Me.Label24
			location = New Point(75, 27)
			arg_15B4_0.Location = location
			Me.Label24.Name = "Label24"
			Dim arg_15DB_0 As Control = Me.Label24
			size = New Size(56, 16)
			arg_15DB_0.Size = size
			Me.Label24.TabIndex = 64
			Me.Label24.Text = "Nét chính:"
			Me.TabMuiTenTyLe.Controls.Add(Me.txtMTDDoRong)
			Me.TabMuiTenTyLe.Controls.Add(Me.Label2)
			Me.TabMuiTenTyLe.Controls.Add(Me.txtMTDDoDai)
			Me.TabMuiTenTyLe.Controls.Add(Me.Label3)
			Me.TabMuiTenTyLe.Controls.Add(Me.txtMTDFillColor)
			Me.TabMuiTenTyLe.Controls.Add(Me.txtMTD2Color)
			Me.TabMuiTenTyLe.Controls.Add(Me.txtMTD1Color)
			Me.TabMuiTenTyLe.Controls.Add(Me.nudMTDAlpha)
			Me.TabMuiTenTyLe.Controls.Add(Me.Label7)
			Me.TabMuiTenTyLe.Controls.Add(Me.chkMTDFill)
			Me.TabMuiTenTyLe.Controls.Add(Me.nudMTDPen2W)
			Me.TabMuiTenTyLe.Controls.Add(Me.Label9)
			Me.TabMuiTenTyLe.Controls.Add(Me.nudMTDPen1W)
			Me.TabMuiTenTyLe.Controls.Add(Me.Label27)
			Dim arg_1742_0 As TabPage = Me.TabMuiTenTyLe
			location = New Point(4, 22)
			arg_1742_0.Location = location
			Me.TabMuiTenTyLe.Name = "TabMuiTenTyLe"
			Dim arg_176F_0 As Control = Me.TabMuiTenTyLe
			size = New Size(454, 142)
			arg_176F_0.Size = size
			Me.TabMuiTenTyLe.TabIndex = 3
			Me.TabMuiTenTyLe.Text = "Mtên t" & ChrW(7927) & " l" & ChrW(7879)
			Me.TabMuiTenTyLe.UseVisualStyleBackColor = True
			Dim arg_17AE_0 As Control = Me.txtMTDDoRong
			location = New Point(124, 105)
			arg_17AE_0.Location = location
			Me.txtMTDDoRong.Name = "txtMTDDoRong"
			Dim arg_17D5_0 As Control = Me.txtMTDDoRong
			size = New Size(40, 21)
			arg_17D5_0.Size = size
			Me.txtMTDDoRong.TabIndex = 91
			Me.txtMTDDoRong.Text = "6"
			Dim arg_1809_0 As Control = Me.Label2
			location = New Point(68, 105)
			arg_1809_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_1830_0 As Control = Me.Label2
			size = New Size(56, 23)
			arg_1830_0.Size = size
			Me.Label2.TabIndex = 90
			Me.Label2.Text = ChrW(272) & ChrW(7897) & " r" & ChrW(7897) & "ng:"
			Dim arg_1864_0 As Control = Me.txtMTDDoDai
			location = New Point(124, 79)
			arg_1864_0.Location = location
			Me.txtMTDDoDai.Name = "txtMTDDoDai"
			Dim arg_188B_0 As Control = Me.txtMTDDoDai
			size = New Size(40, 21)
			arg_188B_0.Size = size
			Me.txtMTDDoDai.TabIndex = 89
			Me.txtMTDDoDai.Text = "100"
			Dim arg_18BF_0 As Control = Me.Label3
			location = New Point(68, 79)
			arg_18BF_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_18E6_0 As Control = Me.Label3
			size = New Size(56, 23)
			arg_18E6_0.Size = size
			Me.Label3.TabIndex = 88
			Me.Label3.Text = ChrW(272) & ChrW(7897) & " dài:"
			Me.txtMTDFillColor.BackColor = Color.Red
			Me.txtMTDFillColor.ForeColor = SystemColors.HighlightText
			Dim arg_193D_0 As Control = Me.txtMTDFillColor
			location = New Point(284, 15)
			arg_193D_0.Location = location
			Me.txtMTDFillColor.Name = "txtMTDFillColor"
			Dim arg_1964_0 As Control = Me.txtMTDFillColor
			size = New Size(24, 21)
			arg_1964_0.Size = size
			Me.txtMTDFillColor.TabIndex = 85
			Me.txtMTD2Color.BackColor = Color.FromArgb(255, 255, 192)
			Me.txtMTD2Color.ForeColor = SystemColors.HighlightText
			Dim arg_19B7_0 As Control = Me.txtMTD2Color
			location = New Point(124, 39)
			arg_19B7_0.Location = location
			Me.txtMTD2Color.Name = "txtMTD2Color"
			Dim arg_19DE_0 As Control = Me.txtMTD2Color
			size = New Size(24, 21)
			arg_19DE_0.Size = size
			Me.txtMTD2Color.TabIndex = 82
			Me.txtMTD1Color.BackColor = Color.Red
			Me.txtMTD1Color.ForeColor = SystemColors.HighlightText
			Dim arg_1A22_0 As Control = Me.txtMTD1Color
			location = New Point(124, 15)
			arg_1A22_0.Location = location
			Me.txtMTD1Color.Name = "txtMTD1Color"
			Dim arg_1A49_0 As Control = Me.txtMTD1Color
			size = New Size(24, 21)
			arg_1A49_0.Size = size
			Me.txtMTD1Color.TabIndex = 79
			Dim arg_1A70_0 As Control = Me.nudMTDAlpha
			location = New Point(268, 39)
			arg_1A70_0.Location = location
			Dim arg_1AA6_0 As NumericUpDown = Me.nudMTDAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_1AA6_0.Maximum = num
			Me.nudMTDAlpha.Name = "nudMTDAlpha"
			Dim arg_1ACD_0 As Control = Me.nudMTDAlpha
			size = New Size(40, 21)
			arg_1ACD_0.Size = size
			Me.nudMTDAlpha.TabIndex = 87
			Dim arg_1B10_0 As NumericUpDown = Me.nudMTDAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_1B10_0.Value = num
			Dim arg_1B2A_0 As Control = Me.Label7
			location = New Point(220, 39)
			arg_1B2A_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_1B51_0 As Control = Me.Label7
			size = New Size(40, 16)
			arg_1B51_0.Size = size
			Me.Label7.TabIndex = 86
			Me.Label7.Text = ChrW(272) & ChrW(7897) & " m" & ChrW(7901) & ":"
			Dim arg_1B88_0 As Control = Me.chkMTDFill
			location = New Point(220, 15)
			arg_1B88_0.Location = location
			Me.chkMTDFill.Name = "chkMTDFill"
			Dim arg_1BAF_0 As Control = Me.chkMTDFill
			size = New Size(87, 24)
			arg_1BAF_0.Size = size
			Me.chkMTDFill.TabIndex = 84
			Me.chkMTDFill.Text = "M" & ChrW(7847) & "u tô"
			Dim arg_1BE6_0 As Control = Me.nudMTDPen2W
			location = New Point(148, 39)
			arg_1BE6_0.Location = location
			Dim arg_1C19_0 As NumericUpDown = Me.nudMTDPen2W
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_1C19_0.Maximum = num
			Me.nudMTDPen2W.Name = "nudMTDPen2W"
			Dim arg_1C40_0 As Control = Me.nudMTDPen2W
			size = New Size(32, 21)
			arg_1C40_0.Size = size
			Me.nudMTDPen2W.TabIndex = 83
			Dim arg_1C64_0 As Control = Me.Label9
			location = New Point(68, 39)
			arg_1C64_0.Location = location
			Me.Label9.Name = "Label9"
			Dim arg_1C8B_0 As Control = Me.Label9
			size = New Size(56, 16)
			arg_1C8B_0.Size = size
			Me.Label9.TabIndex = 81
			Me.Label9.Text = "Nét ph" & ChrW(7909) & ":"
			Dim arg_1CC2_0 As Control = Me.nudMTDPen1W
			location = New Point(148, 15)
			arg_1CC2_0.Location = location
			Dim arg_1CF5_0 As NumericUpDown = Me.nudMTDPen1W
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_1CF5_0.Maximum = num
			Dim arg_1D27_0 As NumericUpDown = Me.nudMTDPen1W
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_1D27_0.Minimum = num
			Me.nudMTDPen1W.Name = "nudMTDPen1W"
			Dim arg_1D4E_0 As Control = Me.nudMTDPen1W
			size = New Size(32, 21)
			arg_1D4E_0.Size = size
			Me.nudMTDPen1W.TabIndex = 80
			Dim arg_1D8D_0 As NumericUpDown = Me.nudMTDPen1W
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_1D8D_0.Value = num
			Dim arg_1DA4_0 As Control = Me.Label27
			location = New Point(68, 15)
			arg_1DA4_0.Location = location
			Me.Label27.Name = "Label27"
			Dim arg_1DCB_0 As Control = Me.Label27
			size = New Size(56, 16)
			arg_1DCB_0.Size = size
			Me.Label27.TabIndex = 78
			Me.Label27.Text = "Nét chính:"
			Me.TabSongSong.Controls.Add(Me.nudSSLinesNo)
			Me.TabSongSong.Controls.Add(Me.Label13)
			Me.TabSongSong.Controls.Add(Me.nudSSSize)
			Me.TabSongSong.Controls.Add(Me.Label12)
			Me.TabSongSong.Controls.Add(Me.txtSS2Color)
			Me.TabSongSong.Controls.Add(Me.txtSS1Color)
			Me.TabSongSong.Controls.Add(Me.nudSSPen2W)
			Me.TabSongSong.Controls.Add(Me.Label4)
			Me.TabSongSong.Controls.Add(Me.nudSSPen1W)
			Me.TabSongSong.Controls.Add(Me.Label11)
			Dim arg_1EDA_0 As TabPage = Me.TabSongSong
			location = New Point(4, 22)
			arg_1EDA_0.Location = location
			Me.TabSongSong.Name = "TabSongSong"
			Dim arg_1F07_0 As Control = Me.TabSongSong
			size = New Size(454, 142)
			arg_1F07_0.Size = size
			Me.TabSongSong.TabIndex = 0
			Me.TabSongSong.Text = "Song Song"
			Me.TabSongSong.UseVisualStyleBackColor = True
			Me.nudSSLinesNo.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_1F66_0 As Control = Me.nudSSLinesNo
			location = New Point(208, 48)
			arg_1F66_0.Location = location
			Dim arg_1F99_0 As NumericUpDown = Me.nudSSLinesNo
			num = New Decimal(New Integer() { 32, 0, 0, 0 })
			arg_1F99_0.Maximum = num
			Dim arg_1FCB_0 As NumericUpDown = Me.nudSSLinesNo
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_1FCB_0.Minimum = num
			Me.nudSSLinesNo.Name = "nudSSLinesNo"
			Dim arg_1FF2_0 As Control = Me.nudSSLinesNo
			size = New Size(40, 21)
			arg_1FF2_0.Size = size
			Me.nudSSLinesNo.TabIndex = 69
			Dim arg_2031_0 As NumericUpDown = Me.nudSSLinesNo
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_2031_0.Value = num
			Me.Label13.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_2068_0 As Control = Me.Label13
			location = New Point(144, 48)
			arg_2068_0.Location = location
			Me.Label13.Name = "Label13"
			Dim arg_208F_0 As Control = Me.Label13
			size = New Size(72, 24)
			arg_208F_0.Size = size
			Me.Label13.TabIndex = 68
			Me.Label13.Text = "S" & ChrW(7889) & " " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng:"
			Me.nudSSSize.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_20E3_0 As Control = Me.nudSSSize
			location = New Point(296, 24)
			arg_20E3_0.Location = location
			Dim arg_2116_0 As NumericUpDown = Me.nudSSSize
			num = New Decimal(New Integer() { 32, 0, 0, 0 })
			arg_2116_0.Maximum = num
			Me.nudSSSize.Name = "nudSSSize"
			Dim arg_213D_0 As Control = Me.nudSSSize
			size = New Size(40, 21)
			arg_213D_0.Size = size
			Me.nudSSSize.TabIndex = 67
			Dim arg_217C_0 As NumericUpDown = Me.nudSSSize
			num = New Decimal(New Integer() { 8, 0, 0, 0 })
			arg_217C_0.Value = num
			Me.Label12.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_21B3_0 As Control = Me.Label12
			location = New Point(144, 24)
			arg_21B3_0.Location = location
			Me.Label12.Name = "Label12"
			Dim arg_21DD_0 As Control = Me.Label12
			size = New Size(168, 24)
			arg_21DD_0.Size = size
			Me.Label12.TabIndex = 66
			Me.Label12.Text = "Kho" & ChrW(7843) & "ng cách gi" & ChrW(7919) & "a các " & ChrW(273) & ChrW(432) & ChrW(7901) & "ng:"
			Me.txtSS2Color.BackColor = SystemColors.Highlight
			Me.txtSS2Color.ForeColor = SystemColors.HighlightText
			Dim arg_2231_0 As Control = Me.txtSS2Color
			location = New Point(72, 48)
			arg_2231_0.Location = location
			Me.txtSS2Color.Name = "txtSS2Color"
			Dim arg_2258_0 As Control = Me.txtSS2Color
			size = New Size(24, 21)
			arg_2258_0.Size = size
			Me.txtSS2Color.TabIndex = 64
			Me.txtSS1Color.BackColor = Color.Red
			Me.txtSS1Color.ForeColor = SystemColors.HighlightText
			Dim arg_229C_0 As Control = Me.txtSS1Color
			location = New Point(72, 24)
			arg_229C_0.Location = location
			Me.txtSS1Color.Name = "txtSS1Color"
			Dim arg_22C3_0 As Control = Me.txtSS1Color
			size = New Size(24, 21)
			arg_22C3_0.Size = size
			Me.txtSS1Color.TabIndex = 61
			Dim arg_22E7_0 As Control = Me.nudSSPen2W
			location = New Point(96, 48)
			arg_22E7_0.Location = location
			Dim arg_231A_0 As NumericUpDown = Me.nudSSPen2W
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_231A_0.Maximum = num
			Me.nudSSPen2W.Name = "nudSSPen2W"
			Dim arg_2341_0 As Control = Me.nudSSPen2W
			size = New Size(32, 21)
			arg_2341_0.Size = size
			Me.nudSSPen2W.TabIndex = 65
			Dim arg_2365_0 As Control = Me.Label4
			location = New Point(16, 48)
			arg_2365_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_238C_0 As Control = Me.Label4
			size = New Size(48, 16)
			arg_238C_0.Size = size
			Me.Label4.TabIndex = 63
			Me.Label4.Text = "Nét ph" & ChrW(7909) & ":"
			Dim arg_23C0_0 As Control = Me.nudSSPen1W
			location = New Point(96, 24)
			arg_23C0_0.Location = location
			Dim arg_23F3_0 As NumericUpDown = Me.nudSSPen1W
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_23F3_0.Maximum = num
			Dim arg_2425_0 As NumericUpDown = Me.nudSSPen1W
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_2425_0.Minimum = num
			Me.nudSSPen1W.Name = "nudSSPen1W"
			Dim arg_244C_0 As Control = Me.nudSSPen1W
			size = New Size(32, 21)
			arg_244C_0.Size = size
			Me.nudSSPen1W.TabIndex = 62
			Dim arg_248B_0 As NumericUpDown = Me.nudSSPen1W
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_248B_0.Value = num
			Dim arg_24A2_0 As Control = Me.Label11
			location = New Point(16, 24)
			arg_24A2_0.Location = location
			Me.Label11.Name = "Label11"
			Dim arg_24C9_0 As Control = Me.Label11
			size = New Size(56, 16)
			arg_24C9_0.Size = size
			Me.Label11.TabIndex = 60
			Me.Label11.Text = "Nét chính:"
			Me.TabText.Controls.Add(Me.txtTextFont)
			Dim arg_2512_0 As TabPage = Me.TabText
			location = New Point(4, 22)
			arg_2512_0.Location = location
			Me.TabText.Name = "TabText"
			Dim arg_253F_0 As Control = Me.TabText
			size = New Size(454, 142)
			arg_253F_0.Size = size
			Me.TabText.TabIndex = 7
			Me.TabText.Text = "Text"
			Me.TabText.UseVisualStyleBackColor = True
			Dim arg_257E_0 As Control = Me.txtTextFont
			location = New Point(16, 24)
			arg_257E_0.Location = location
			Me.txtTextFont.Name = "txtTextFont"
			Dim arg_25A8_0 As Control = Me.txtTextFont
			size = New Size(200, 21)
			arg_25A8_0.Size = size
			Me.txtTextFont.TabIndex = 90
			Me.txtTextFont.Text = "Font, m" & ChrW(7847) & "u ch" & ChrW(7919)
			Me.txtTextFont.WordWrap = False
			Me.TabTable.Controls.Add(Me.txtTableFont)
			Me.TabTable.Controls.Add(Me.nudTblRowsNo)
			Me.TabTable.Controls.Add(Me.Label21)
			Me.TabTable.Controls.Add(Me.nudTblColsNo)
			Me.TabTable.Controls.Add(Me.Label20)
			Me.TabTable.Controls.Add(Me.Label16)
			Me.TabTable.Controls.Add(Me.txtTblFillColor)
			Me.TabTable.Controls.Add(Me.txtTblLineColor)
			Me.TabTable.Controls.Add(Me.txtTblBorderColor)
			Me.TabTable.Controls.Add(Me.nudTblAlpha)
			Me.TabTable.Controls.Add(Me.Label17)
			Me.TabTable.Controls.Add(Me.nudTblLineW)
			Me.TabTable.Controls.Add(Me.Label18)
			Me.TabTable.Controls.Add(Me.nudTblBorderW)
			Me.TabTable.Controls.Add(Me.Label19)
			Dim arg_2731_0 As TabPage = Me.TabTable
			location = New Point(4, 22)
			arg_2731_0.Location = location
			Me.TabTable.Name = "TabTable"
			Dim arg_275E_0 As Control = Me.TabTable
			size = New Size(454, 142)
			arg_275E_0.Size = size
			Me.TabTable.TabIndex = 6
			Me.TabTable.Text = "B" & ChrW(7843) & "ng"
			Me.TabTable.UseVisualStyleBackColor = True
			Dim arg_279D_0 As Control = Me.txtTableFont
			location = New Point(24, 80)
			arg_279D_0.Location = location
			Me.txtTableFont.Name = "txtTableFont"
			Dim arg_27C7_0 As Control = Me.txtTableFont
			size = New Size(200, 21)
			arg_27C7_0.Size = size
			Me.txtTableFont.TabIndex = 91
			Me.txtTableFont.Text = "Font, m" & ChrW(7847) & "u ch" & ChrW(7919)
			Me.txtTableFont.WordWrap = False
			Dim arg_2807_0 As Control = Me.nudTblRowsNo
			location = New Point(80, 40)
			arg_2807_0.Location = location
			Dim arg_283A_0 As NumericUpDown = Me.nudTblRowsNo
			num = New Decimal(New Integer() { 32, 0, 0, 0 })
			arg_283A_0.Maximum = num
			Dim arg_286C_0 As NumericUpDown = Me.nudTblRowsNo
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_286C_0.Minimum = num
			Me.nudTblRowsNo.Name = "nudTblRowsNo"
			Dim arg_2893_0 As Control = Me.nudTblRowsNo
			size = New Size(40, 21)
			arg_2893_0.Size = size
			Me.nudTblRowsNo.TabIndex = 86
			Dim arg_28D2_0 As NumericUpDown = Me.nudTblRowsNo
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_28D2_0.Value = num
			Me.Label21.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_2906_0 As Control = Me.Label21
			location = New Point(24, 40)
			arg_2906_0.Location = location
			Me.Label21.Name = "Label21"
			Dim arg_292D_0 As Control = Me.Label21
			size = New Size(56, 24)
			arg_292D_0.Size = size
			Me.Label21.TabIndex = 85
			Me.Label21.Text = "S" & ChrW(7889) & " dòng:"
			Dim arg_2961_0 As Control = Me.nudTblColsNo
			location = New Point(80, 16)
			arg_2961_0.Location = location
			Dim arg_2994_0 As NumericUpDown = Me.nudTblColsNo
			num = New Decimal(New Integer() { 32, 0, 0, 0 })
			arg_2994_0.Maximum = num
			Dim arg_29C6_0 As NumericUpDown = Me.nudTblColsNo
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_29C6_0.Minimum = num
			Me.nudTblColsNo.Name = "nudTblColsNo"
			Dim arg_29ED_0 As Control = Me.nudTblColsNo
			size = New Size(40, 21)
			arg_29ED_0.Size = size
			Me.nudTblColsNo.TabIndex = 84
			Dim arg_2A2C_0 As NumericUpDown = Me.nudTblColsNo
			num = New Decimal(New Integer() { 2, 0, 0, 0 })
			arg_2A2C_0.Value = num
			Me.Label20.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_2A60_0 As Control = Me.Label20
			location = New Point(24, 16)
			arg_2A60_0.Location = location
			Me.Label20.Name = "Label20"
			Dim arg_2A87_0 As Control = Me.Label20
			size = New Size(56, 24)
			arg_2A87_0.Size = size
			Me.Label20.TabIndex = 83
			Me.Label20.Text = "S" & ChrW(7889) & " c" & ChrW(7897) & "t:"
			Dim arg_2ABE_0 As Control = Me.Label16
			location = New Point(264, 16)
			arg_2ABE_0.Location = location
			Me.Label16.Name = "Label16"
			Dim arg_2AE5_0 As Control = Me.Label16
			size = New Size(56, 16)
			arg_2AE5_0.Size = size
			Me.Label16.TabIndex = 82
			Me.Label16.Text = "M" & ChrW(7847) & "u n" & ChrW(7873) & "n:"
			Me.txtTblFillColor.BackColor = Color.Red
			Me.txtTblFillColor.ForeColor = SystemColors.HighlightText
			Dim arg_2B3C_0 As Control = Me.txtTblFillColor
			location = New Point(320, 16)
			arg_2B3C_0.Location = location
			Me.txtTblFillColor.Name = "txtTblFillColor"
			Dim arg_2B63_0 As Control = Me.txtTblFillColor
			size = New Size(24, 21)
			arg_2B63_0.Size = size
			Me.txtTblFillColor.TabIndex = 78
			Me.txtTblLineColor.BackColor = SystemColors.Highlight
			Me.txtTblLineColor.ForeColor = SystemColors.HighlightText
			Dim arg_2BAA_0 As Control = Me.txtTblLineColor
			location = New Point(192, 40)
			arg_2BAA_0.Location = location
			Me.txtTblLineColor.Name = "txtTblLineColor"
			Dim arg_2BD1_0 As Control = Me.txtTblLineColor
			size = New Size(24, 21)
			arg_2BD1_0.Size = size
			Me.txtTblLineColor.TabIndex = 76
			Me.txtTblBorderColor.BackColor = Color.Red
			Me.txtTblBorderColor.ForeColor = SystemColors.HighlightText
			Dim arg_2C18_0 As Control = Me.txtTblBorderColor
			location = New Point(192, 16)
			arg_2C18_0.Location = location
			Me.txtTblBorderColor.Name = "txtTblBorderColor"
			Dim arg_2C3F_0 As Control = Me.txtTblBorderColor
			size = New Size(24, 21)
			arg_2C3F_0.Size = size
			Me.txtTblBorderColor.TabIndex = 73
			Dim arg_2C66_0 As Control = Me.nudTblAlpha
			location = New Point(320, 40)
			arg_2C66_0.Location = location
			Dim arg_2C9C_0 As NumericUpDown = Me.nudTblAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_2C9C_0.Maximum = num
			Me.nudTblAlpha.Name = "nudTblAlpha"
			Dim arg_2CC3_0 As Control = Me.nudTblAlpha
			size = New Size(48, 21)
			arg_2CC3_0.Size = size
			Me.nudTblAlpha.TabIndex = 81
			Dim arg_2D06_0 As NumericUpDown = Me.nudTblAlpha
			num = New Decimal(New Integer() { 255, 0, 0, 0 })
			arg_2D06_0.Value = num
			Dim arg_2D20_0 As Control = Me.Label17
			location = New Point(272, 40)
			arg_2D20_0.Location = location
			Me.Label17.Name = "Label17"
			Dim arg_2D47_0 As Control = Me.Label17
			size = New Size(48, 16)
			arg_2D47_0.Size = size
			Me.Label17.TabIndex = 80
			Me.Label17.Text = ChrW(272) & ChrW(7897) & " m" & ChrW(7901) & ":"
			Dim arg_2D7E_0 As Control = Me.nudTblLineW
			location = New Point(216, 40)
			arg_2D7E_0.Location = location
			Dim arg_2DB1_0 As NumericUpDown = Me.nudTblLineW
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_2DB1_0.Maximum = num
			Me.nudTblLineW.Name = "nudTblLineW"
			Dim arg_2DD8_0 As Control = Me.nudTblLineW
			size = New Size(32, 21)
			arg_2DD8_0.Size = size
			Me.nudTblLineW.TabIndex = 77
			Dim arg_2E17_0 As NumericUpDown = Me.nudTblLineW
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_2E17_0.Value = num
			Dim arg_2E31_0 As Control = Me.Label18
			location = New Point(136, 40)
			arg_2E31_0.Location = location
			Me.Label18.Name = "Label18"
			Dim arg_2E58_0 As Control = Me.Label18
			size = New Size(56, 16)
			arg_2E58_0.Size = size
			Me.Label18.TabIndex = 75
			Me.Label18.Text = ChrW(272) & ChrW(432) & ChrW(7901) & "ng k" & ChrW(7867) & ":"
			Dim arg_2E8F_0 As Control = Me.nudTblBorderW
			location = New Point(216, 16)
			arg_2E8F_0.Location = location
			Dim arg_2EC2_0 As NumericUpDown = Me.nudTblBorderW
			num = New Decimal(New Integer() { 72, 0, 0, 0 })
			arg_2EC2_0.Maximum = num
			Me.nudTblBorderW.Name = "nudTblBorderW"
			Dim arg_2EE9_0 As Control = Me.nudTblBorderW
			size = New Size(32, 21)
			arg_2EE9_0.Size = size
			Me.nudTblBorderW.TabIndex = 74
			Dim arg_2F28_0 As NumericUpDown = Me.nudTblBorderW
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_2F28_0.Value = num
			Dim arg_2F42_0 As Control = Me.Label19
			location = New Point(136, 16)
			arg_2F42_0.Location = location
			Me.Label19.Name = "Label19"
			Dim arg_2F69_0 As Control = Me.Label19
			size = New Size(64, 16)
			arg_2F69_0.Size = size
			Me.Label19.TabIndex = 72
			Me.Label19.Text = "Vi" & ChrW(7873) & "n ngoài:"
			Me.TabGrid.Controls.Add(Me.Label14)
			Me.TabGrid.Controls.Add(Me.nudGrid)
			Me.TabGrid.Controls.Add(Me.Label15)
			Dim arg_2FDE_0 As TabPage = Me.TabGrid
			location = New Point(4, 22)
			arg_2FDE_0.Location = location
			Me.TabGrid.Name = "TabGrid"
			Dim arg_300B_0 As Control = Me.TabGrid
			size = New Size(454, 142)
			arg_300B_0.Size = size
			Me.TabGrid.TabIndex = 5
			Me.TabGrid.Text = "L" & ChrW(432) & ChrW(7899) & "i"
			Me.TabGrid.UseVisualStyleBackColor = True
			Me.Label14.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label14.ForeColor = SystemColors.ActiveCaption
			Dim arg_307A_0 As Control = Me.Label14
			location = New Point(200, 32)
			arg_307A_0.Location = location
			Me.Label14.Name = "Label14"
			Dim arg_30A4_0 As Control = Me.Label14
			size = New Size(152, 40)
			arg_30A4_0.Size = size
			Me.Label14.TabIndex = 53
			Me.Label14.Text = "(B" & ChrW(7845) & "m 'G' " & ChrW(273) & ChrW(7875) & " hi" & ChrW(7879) & "n l" & ChrW(432) & ChrW(7899) & "i, 'S' " & ChrW(273) & ChrW(7875) & " con tr" & ChrW(7887) & " " & ChrW(273) & "i theo l" & ChrW(432) & ChrW(7899) & "i)"
			Dim arg_30D8_0 As Control = Me.nudGrid
			location = New Point(120, 32)
			arg_30D8_0.Location = location
			Dim arg_310B_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 32, 0, 0, 0 })
			arg_310B_0.Maximum = num
			Dim arg_313D_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 4, 0, 0, 0 })
			arg_313D_0.Minimum = num
			Me.nudGrid.Name = "nudGrid"
			Dim arg_3164_0 As Control = Me.nudGrid
			size = New Size(48, 21)
			arg_3164_0.Size = size
			Me.nudGrid.TabIndex = 51
			Dim arg_31A3_0 As NumericUpDown = Me.nudGrid
			num = New Decimal(New Integer() { 8, 0, 0, 0 })
			arg_31A3_0.Value = num
			Me.Label15.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim arg_31D7_0 As Control = Me.Label15
			location = New Point(32, 32)
			arg_31D7_0.Location = location
			Me.Label15.Name = "Label15"
			Dim arg_31FE_0 As Control = Me.Label15
			size = New Size(96, 16)
			arg_31FE_0.Size = size
			Me.Label15.TabIndex = 50
			Me.Label15.Text = ChrW(272) & ChrW(7897) & " r" & ChrW(7897) & "ng m" & ChrW(7855) & "t l" & ChrW(432) & ChrW(7899) & "i:"
			Me.TabColorTable.Controls.Add(Me.GroupBox1)
			Me.TabColorTable.Controls.Add(Me.txtQuanXanhColor)
			Me.TabColorTable.Controls.Add(Me.Label28)
			Me.TabColorTable.Controls.Add(Me.txtQuanDoColor)
			Me.TabColorTable.Controls.Add(Me.Label10)
			Dim arg_329F_0 As TabPage = Me.TabColorTable
			location = New Point(4, 22)
			arg_329F_0.Location = location
			Me.TabColorTable.Name = "TabColorTable"
			Dim arg_32CC_0 As Control = Me.TabColorTable
			size = New Size(454, 142)
			arg_32CC_0.Size = size
			Me.TabColorTable.TabIndex = 9
			Me.TabColorTable.Text = "B" & ChrW(7843) & "ng m" & ChrW(7847) & "u"
			Me.TabColorTable.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.txtColor32)
			Me.GroupBox1.Controls.Add(Me.txtColor24)
			Me.GroupBox1.Controls.Add(Me.txtColor16)
			Me.GroupBox1.Controls.Add(Me.txtColor08)
			Me.GroupBox1.Controls.Add(Me.txtColor31)
			Me.GroupBox1.Controls.Add(Me.txtColor30)
			Me.GroupBox1.Controls.Add(Me.txtColor29)
			Me.GroupBox1.Controls.Add(Me.txtColor28)
			Me.GroupBox1.Controls.Add(Me.txtColor27)
			Me.GroupBox1.Controls.Add(Me.txtColor26)
			Me.GroupBox1.Controls.Add(Me.txtColor25)
			Me.GroupBox1.Controls.Add(Me.txtColor23)
			Me.GroupBox1.Controls.Add(Me.txtColor22)
			Me.GroupBox1.Controls.Add(Me.txtColor21)
			Me.GroupBox1.Controls.Add(Me.txtColor20)
			Me.GroupBox1.Controls.Add(Me.txtColor19)
			Me.GroupBox1.Controls.Add(Me.txtColor18)
			Me.GroupBox1.Controls.Add(Me.txtColor17)
			Me.GroupBox1.Controls.Add(Me.txtColor15)
			Me.GroupBox1.Controls.Add(Me.txtColor14)
			Me.GroupBox1.Controls.Add(Me.txtColor13)
			Me.GroupBox1.Controls.Add(Me.txtColor12)
			Me.GroupBox1.Controls.Add(Me.txtColor11)
			Me.GroupBox1.Controls.Add(Me.txtColor10)
			Me.GroupBox1.Controls.Add(Me.txtColor09)
			Me.GroupBox1.Controls.Add(Me.txtColor07)
			Me.GroupBox1.Controls.Add(Me.txtColor06)
			Me.GroupBox1.Controls.Add(Me.txtColor05)
			Me.GroupBox1.Controls.Add(Me.txtColor04)
			Me.GroupBox1.Controls.Add(Me.txtColor03)
			Me.GroupBox1.Controls.Add(Me.txtColor02)
			Me.GroupBox1.Controls.Add(Me.txtColor01)
			Dim arg_35CE_0 As Control = Me.GroupBox1
			location = New Point(189, 3)
			arg_35CE_0.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim arg_35FB_0 As Control = Me.GroupBox1
			size = New Size(248, 136)
			arg_35FB_0.Size = size
			Me.GroupBox1.TabIndex = 105
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Các m" & ChrW(7847) & "u"
			Me.txtColor32.BackColor = Color.Red
			Me.txtColor32.ForeColor = SystemColors.HighlightText
			Dim arg_365E_0 As Control = Me.txtColor32
			location = New Point(208, 104)
			arg_365E_0.Location = location
			Me.txtColor32.Name = "txtColor32"
			Dim arg_3685_0 As Control = Me.txtColor32
			size = New Size(21, 21)
			arg_3685_0.Size = size
			Me.txtColor32.TabIndex = 63
			Me.txtColor24.BackColor = Color.Red
			Me.txtColor24.ForeColor = SystemColors.HighlightText
			Dim arg_36CC_0 As Control = Me.txtColor24
			location = New Point(208, 77)
			arg_36CC_0.Location = location
			Me.txtColor24.Name = "txtColor24"
			Dim arg_36F3_0 As Control = Me.txtColor24
			size = New Size(21, 21)
			arg_36F3_0.Size = size
			Me.txtColor24.TabIndex = 55
			Me.txtColor16.BackColor = Color.Red
			Me.txtColor16.ForeColor = SystemColors.HighlightText
			Dim arg_373A_0 As Control = Me.txtColor16
			location = New Point(208, 51)
			arg_373A_0.Location = location
			Me.txtColor16.Name = "txtColor16"
			Dim arg_3761_0 As Control = Me.txtColor16
			size = New Size(21, 21)
			arg_3761_0.Size = size
			Me.txtColor16.TabIndex = 47
			Me.txtColor08.BackColor = Color.Red
			Me.txtColor08.ForeColor = SystemColors.HighlightText
			Dim arg_37A8_0 As Control = Me.txtColor08
			location = New Point(208, 24)
			arg_37A8_0.Location = location
			Me.txtColor08.Name = "txtColor08"
			Dim arg_37CF_0 As Control = Me.txtColor08
			size = New Size(21, 21)
			arg_37CF_0.Size = size
			Me.txtColor08.TabIndex = 39
			Me.txtColor31.BackColor = Color.Red
			Me.txtColor31.ForeColor = SystemColors.HighlightText
			Dim arg_3816_0 As Control = Me.txtColor31
			location = New Point(181, 105)
			arg_3816_0.Location = location
			Me.txtColor31.Name = "txtColor31"
			Dim arg_383D_0 As Control = Me.txtColor31
			size = New Size(21, 21)
			arg_383D_0.Size = size
			Me.txtColor31.TabIndex = 62
			Me.txtColor30.BackColor = Color.Red
			Me.txtColor30.ForeColor = SystemColors.HighlightText
			Dim arg_3884_0 As Control = Me.txtColor30
			location = New Point(154, 105)
			arg_3884_0.Location = location
			Me.txtColor30.Name = "txtColor30"
			Dim arg_38AB_0 As Control = Me.txtColor30
			size = New Size(21, 21)
			arg_38AB_0.Size = size
			Me.txtColor30.TabIndex = 61
			Me.txtColor29.BackColor = Color.Red
			Me.txtColor29.ForeColor = SystemColors.HighlightText
			Dim arg_38EF_0 As Control = Me.txtColor29
			location = New Point(127, 105)
			arg_38EF_0.Location = location
			Me.txtColor29.Name = "txtColor29"
			Dim arg_3916_0 As Control = Me.txtColor29
			size = New Size(21, 21)
			arg_3916_0.Size = size
			Me.txtColor29.TabIndex = 60
			Me.txtColor28.BackColor = Color.Red
			Me.txtColor28.ForeColor = SystemColors.HighlightText
			Dim arg_395A_0 As Control = Me.txtColor28
			location = New Point(100, 105)
			arg_395A_0.Location = location
			Me.txtColor28.Name = "txtColor28"
			Dim arg_3981_0 As Control = Me.txtColor28
			size = New Size(21, 21)
			arg_3981_0.Size = size
			Me.txtColor28.TabIndex = 59
			Me.txtColor27.BackColor = Color.Red
			Me.txtColor27.ForeColor = SystemColors.HighlightText
			Dim arg_39C5_0 As Control = Me.txtColor27
			location = New Point(73, 105)
			arg_39C5_0.Location = location
			Me.txtColor27.Name = "txtColor27"
			Dim arg_39EC_0 As Control = Me.txtColor27
			size = New Size(21, 21)
			arg_39EC_0.Size = size
			Me.txtColor27.TabIndex = 58
			Me.txtColor26.BackColor = Color.Red
			Me.txtColor26.ForeColor = SystemColors.HighlightText
			Dim arg_3A30_0 As Control = Me.txtColor26
			location = New Point(46, 105)
			arg_3A30_0.Location = location
			Me.txtColor26.Name = "txtColor26"
			Dim arg_3A57_0 As Control = Me.txtColor26
			size = New Size(21, 21)
			arg_3A57_0.Size = size
			Me.txtColor26.TabIndex = 57
			Me.txtColor25.BackColor = Color.Red
			Me.txtColor25.ForeColor = SystemColors.HighlightText
			Dim arg_3A9B_0 As Control = Me.txtColor25
			location = New Point(19, 105)
			arg_3A9B_0.Location = location
			Me.txtColor25.Name = "txtColor25"
			Dim arg_3AC2_0 As Control = Me.txtColor25
			size = New Size(21, 21)
			arg_3AC2_0.Size = size
			Me.txtColor25.TabIndex = 56
			Me.txtColor23.BackColor = Color.Red
			Me.txtColor23.ForeColor = SystemColors.HighlightText
			Dim arg_3B09_0 As Control = Me.txtColor23
			location = New Point(181, 78)
			arg_3B09_0.Location = location
			Me.txtColor23.Name = "txtColor23"
			Dim arg_3B30_0 As Control = Me.txtColor23
			size = New Size(21, 21)
			arg_3B30_0.Size = size
			Me.txtColor23.TabIndex = 54
			Me.txtColor22.BackColor = Color.Red
			Me.txtColor22.ForeColor = SystemColors.HighlightText
			Dim arg_3B77_0 As Control = Me.txtColor22
			location = New Point(154, 78)
			arg_3B77_0.Location = location
			Me.txtColor22.Name = "txtColor22"
			Dim arg_3B9E_0 As Control = Me.txtColor22
			size = New Size(21, 21)
			arg_3B9E_0.Size = size
			Me.txtColor22.TabIndex = 53
			Me.txtColor21.BackColor = Color.Red
			Me.txtColor21.ForeColor = SystemColors.HighlightText
			Dim arg_3BE2_0 As Control = Me.txtColor21
			location = New Point(127, 78)
			arg_3BE2_0.Location = location
			Me.txtColor21.Name = "txtColor21"
			Dim arg_3C09_0 As Control = Me.txtColor21
			size = New Size(21, 21)
			arg_3C09_0.Size = size
			Me.txtColor21.TabIndex = 52
			Me.txtColor20.BackColor = Color.Red
			Me.txtColor20.ForeColor = SystemColors.HighlightText
			Dim arg_3C4D_0 As Control = Me.txtColor20
			location = New Point(100, 78)
			arg_3C4D_0.Location = location
			Me.txtColor20.Name = "txtColor20"
			Dim arg_3C74_0 As Control = Me.txtColor20
			size = New Size(21, 21)
			arg_3C74_0.Size = size
			Me.txtColor20.TabIndex = 51
			Me.txtColor19.BackColor = Color.Red
			Me.txtColor19.ForeColor = SystemColors.HighlightText
			Dim arg_3CB8_0 As Control = Me.txtColor19
			location = New Point(73, 78)
			arg_3CB8_0.Location = location
			Me.txtColor19.Name = "txtColor19"
			Dim arg_3CDF_0 As Control = Me.txtColor19
			size = New Size(21, 21)
			arg_3CDF_0.Size = size
			Me.txtColor19.TabIndex = 50
			Me.txtColor18.BackColor = Color.Red
			Me.txtColor18.ForeColor = SystemColors.HighlightText
			Dim arg_3D23_0 As Control = Me.txtColor18
			location = New Point(46, 78)
			arg_3D23_0.Location = location
			Me.txtColor18.Name = "txtColor18"
			Dim arg_3D4A_0 As Control = Me.txtColor18
			size = New Size(21, 21)
			arg_3D4A_0.Size = size
			Me.txtColor18.TabIndex = 49
			Me.txtColor17.BackColor = Color.Red
			Me.txtColor17.ForeColor = SystemColors.HighlightText
			Dim arg_3D8E_0 As Control = Me.txtColor17
			location = New Point(19, 78)
			arg_3D8E_0.Location = location
			Me.txtColor17.Name = "txtColor17"
			Dim arg_3DB5_0 As Control = Me.txtColor17
			size = New Size(21, 21)
			arg_3DB5_0.Size = size
			Me.txtColor17.TabIndex = 48
			Me.txtColor15.BackColor = Color.Red
			Me.txtColor15.ForeColor = SystemColors.HighlightText
			Dim arg_3DFC_0 As Control = Me.txtColor15
			location = New Point(181, 51)
			arg_3DFC_0.Location = location
			Me.txtColor15.Name = "txtColor15"
			Dim arg_3E23_0 As Control = Me.txtColor15
			size = New Size(21, 21)
			arg_3E23_0.Size = size
			Me.txtColor15.TabIndex = 46
			Me.txtColor14.BackColor = Color.Red
			Me.txtColor14.ForeColor = SystemColors.HighlightText
			Dim arg_3E6A_0 As Control = Me.txtColor14
			location = New Point(154, 51)
			arg_3E6A_0.Location = location
			Me.txtColor14.Name = "txtColor14"
			Dim arg_3E91_0 As Control = Me.txtColor14
			size = New Size(21, 21)
			arg_3E91_0.Size = size
			Me.txtColor14.TabIndex = 45
			Me.txtColor13.BackColor = Color.Red
			Me.txtColor13.ForeColor = SystemColors.HighlightText
			Dim arg_3ED5_0 As Control = Me.txtColor13
			location = New Point(127, 51)
			arg_3ED5_0.Location = location
			Me.txtColor13.Name = "txtColor13"
			Dim arg_3EFC_0 As Control = Me.txtColor13
			size = New Size(21, 21)
			arg_3EFC_0.Size = size
			Me.txtColor13.TabIndex = 44
			Me.txtColor12.BackColor = Color.Red
			Me.txtColor12.ForeColor = SystemColors.HighlightText
			Dim arg_3F40_0 As Control = Me.txtColor12
			location = New Point(100, 51)
			arg_3F40_0.Location = location
			Me.txtColor12.Name = "txtColor12"
			Dim arg_3F67_0 As Control = Me.txtColor12
			size = New Size(21, 21)
			arg_3F67_0.Size = size
			Me.txtColor12.TabIndex = 43
			Me.txtColor11.BackColor = Color.Red
			Me.txtColor11.ForeColor = SystemColors.HighlightText
			Dim arg_3FAB_0 As Control = Me.txtColor11
			location = New Point(73, 51)
			arg_3FAB_0.Location = location
			Me.txtColor11.Name = "txtColor11"
			Dim arg_3FD2_0 As Control = Me.txtColor11
			size = New Size(21, 21)
			arg_3FD2_0.Size = size
			Me.txtColor11.TabIndex = 42
			Me.txtColor10.BackColor = Color.Red
			Me.txtColor10.ForeColor = SystemColors.HighlightText
			Dim arg_4016_0 As Control = Me.txtColor10
			location = New Point(46, 51)
			arg_4016_0.Location = location
			Me.txtColor10.Name = "txtColor10"
			Dim arg_403D_0 As Control = Me.txtColor10
			size = New Size(21, 21)
			arg_403D_0.Size = size
			Me.txtColor10.TabIndex = 41
			Me.txtColor09.BackColor = Color.Red
			Me.txtColor09.ForeColor = SystemColors.HighlightText
			Dim arg_4081_0 As Control = Me.txtColor09
			location = New Point(19, 51)
			arg_4081_0.Location = location
			Me.txtColor09.Name = "txtColor09"
			Dim arg_40A8_0 As Control = Me.txtColor09
			size = New Size(21, 21)
			arg_40A8_0.Size = size
			Me.txtColor09.TabIndex = 40
			Me.txtColor07.BackColor = Color.Red
			Me.txtColor07.ForeColor = SystemColors.HighlightText
			Dim arg_40EF_0 As Control = Me.txtColor07
			location = New Point(181, 24)
			arg_40EF_0.Location = location
			Me.txtColor07.Name = "txtColor07"
			Dim arg_4116_0 As Control = Me.txtColor07
			size = New Size(21, 21)
			arg_4116_0.Size = size
			Me.txtColor07.TabIndex = 38
			Me.txtColor06.BackColor = Color.Red
			Me.txtColor06.ForeColor = SystemColors.HighlightText
			Dim arg_415D_0 As Control = Me.txtColor06
			location = New Point(154, 24)
			arg_415D_0.Location = location
			Me.txtColor06.Name = "txtColor06"
			Dim arg_4184_0 As Control = Me.txtColor06
			size = New Size(21, 21)
			arg_4184_0.Size = size
			Me.txtColor06.TabIndex = 37
			Me.txtColor05.BackColor = Color.Red
			Me.txtColor05.ForeColor = SystemColors.HighlightText
			Dim arg_41C8_0 As Control = Me.txtColor05
			location = New Point(127, 24)
			arg_41C8_0.Location = location
			Me.txtColor05.Name = "txtColor05"
			Dim arg_41EF_0 As Control = Me.txtColor05
			size = New Size(21, 21)
			arg_41EF_0.Size = size
			Me.txtColor05.TabIndex = 36
			Me.txtColor04.BackColor = Color.Red
			Me.txtColor04.ForeColor = SystemColors.HighlightText
			Dim arg_4233_0 As Control = Me.txtColor04
			location = New Point(100, 24)
			arg_4233_0.Location = location
			Me.txtColor04.Name = "txtColor04"
			Dim arg_425A_0 As Control = Me.txtColor04
			size = New Size(21, 21)
			arg_425A_0.Size = size
			Me.txtColor04.TabIndex = 35
			Me.txtColor03.BackColor = Color.Red
			Me.txtColor03.ForeColor = SystemColors.HighlightText
			Dim arg_429E_0 As Control = Me.txtColor03
			location = New Point(73, 24)
			arg_429E_0.Location = location
			Me.txtColor03.Name = "txtColor03"
			Dim arg_42C5_0 As Control = Me.txtColor03
			size = New Size(21, 21)
			arg_42C5_0.Size = size
			Me.txtColor03.TabIndex = 34
			Me.txtColor02.BackColor = Color.Red
			Me.txtColor02.ForeColor = SystemColors.HighlightText
			Dim arg_4309_0 As Control = Me.txtColor02
			location = New Point(46, 24)
			arg_4309_0.Location = location
			Me.txtColor02.Name = "txtColor02"
			Dim arg_4330_0 As Control = Me.txtColor02
			size = New Size(21, 21)
			arg_4330_0.Size = size
			Me.txtColor02.TabIndex = 33
			Me.txtColor01.BackColor = Color.Red
			Me.txtColor01.ForeColor = SystemColors.HighlightText
			Dim arg_4374_0 As Control = Me.txtColor01
			location = New Point(19, 24)
			arg_4374_0.Location = location
			Me.txtColor01.Name = "txtColor01"
			Dim arg_439B_0 As Control = Me.txtColor01
			size = New Size(21, 21)
			arg_439B_0.Size = size
			Me.txtColor01.TabIndex = 32
			Me.txtQuanXanhColor.BackColor = Color.Red
			Me.txtQuanXanhColor.ForeColor = SystemColors.HighlightText
			Dim arg_43DF_0 As Control = Me.txtQuanXanhColor
			location = New Point(110, 60)
			arg_43DF_0.Location = location
			Me.txtQuanXanhColor.Name = "txtQuanXanhColor"
			Dim arg_4406_0 As Control = Me.txtQuanXanhColor
			size = New Size(21, 21)
			arg_4406_0.Size = size
			Me.txtQuanXanhColor.TabIndex = 1
			Dim arg_4429_0 As Control = Me.Label28
			location = New Point(18, 60)
			arg_4429_0.Location = location
			Me.Label28.Name = "Label28"
			Dim arg_4450_0 As Control = Me.Label28
			size = New Size(86, 16)
			arg_4450_0.Size = size
			Me.Label28.TabIndex = 104
			Me.Label28.Text = "M" & ChrW(7847) & "u quân xanh:"
			Me.txtQuanDoColor.BackColor = Color.Red
			Me.txtQuanDoColor.ForeColor = SystemColors.HighlightText
			Dim arg_44A4_0 As Control = Me.txtQuanDoColor
			location = New Point(110, 30)
			arg_44A4_0.Location = location
			Me.txtQuanDoColor.Name = "txtQuanDoColor"
			Dim arg_44CB_0 As Control = Me.txtQuanDoColor
			size = New Size(21, 21)
			arg_44CB_0.Size = size
			Me.txtQuanDoColor.TabIndex = 0
			Dim arg_44EE_0 As Control = Me.Label10
			location = New Point(18, 30)
			arg_44EE_0.Location = location
			Me.Label10.Name = "Label10"
			Dim arg_4515_0 As Control = Me.Label10
			size = New Size(86, 16)
			arg_4515_0.Size = size
			Me.Label10.TabIndex = 103
			Me.Label10.Text = "M" & ChrW(7847) & "u quân " & ChrW(273) & ChrW(7887) & ":"
			Me.TabUndo.Controls.Add(Me.nudUndosNo)
			Me.TabUndo.Controls.Add(Me.Label25)
			Dim arg_4574_0 As TabPage = Me.TabUndo
			location = New Point(4, 22)
			arg_4574_0.Location = location
			Me.TabUndo.Name = "TabUndo"
			Dim arg_45A1_0 As Control = Me.TabUndo
			size = New Size(454, 142)
			arg_45A1_0.Size = size
			Me.TabUndo.TabIndex = 8
			Me.TabUndo.Text = "Undo"
			Me.TabUndo.UseVisualStyleBackColor = True
			Dim arg_45E3_0 As Control = Me.nudUndosNo
			location = New Point(175, 38)
			arg_45E3_0.Location = location
			Dim arg_4615_0 As NumericUpDown = Me.nudUndosNo
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_4615_0.Minimum = num
			Me.nudUndosNo.Name = "nudUndosNo"
			Dim arg_463C_0 As Control = Me.nudUndosNo
			size = New Size(41, 21)
			arg_463C_0.Size = size
			Me.nudUndosNo.TabIndex = 2
			Dim arg_467A_0 As NumericUpDown = Me.nudUndosNo
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			arg_467A_0.Value = num
			Dim arg_4691_0 As Control = Me.Label25
			location = New Point(87, 40)
			arg_4691_0.Location = location
			Me.Label25.Name = "Label25"
			Dim arg_46B8_0 As Control = Me.Label25
			size = New Size(96, 16)
			arg_46B8_0.Size = size
			Me.Label25.TabIndex = 92
			Me.Label25.Text = "S" & ChrW(7889) & " l" & ChrW(432) & ChrW(7907) & "ng Undo:"
			Dim arg_46F2_0 As Control = Me.btnSave
			location = New Point(354, 186)
			arg_46F2_0.Location = location
			Me.btnSave.Name = "btnSave"
			Dim arg_4719_0 As Control = Me.btnSave
			size = New Size(117, 23)
			arg_4719_0.Size = size
			Me.btnSave.TabIndex = 2
			Me.btnSave.Text = "L" & ChrW(432) & "u các m" & ChrW(7863) & "c " & ChrW(273) & ChrW(7883) & "nh"
			Me.btnSave.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(490, 221)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.TabControl1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgOptions"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Các m" & ChrW(7863) & "c " & ChrW(273) & ChrW(7883) & "nh"
			Me.TabControl1.ResumeLayout(False)
			Me.TabGeneral.ResumeLayout(False)
			Me.TabGeneral.PerformLayout()
			(CType(Me.nudLineStyle, ISupportInitialize)).EndInit()
			(CType(Me.nudAlpha, ISupportInitialize)).EndInit()
			(CType(Me.nudPenWidth2, ISupportInitialize)).EndInit()
			(CType(Me.nudPenWidth, ISupportInitialize)).EndInit()
			Me.TabMuiTen.ResumeLayout(False)
			Me.TabMuiTen.PerformLayout()
			(CType(Me.nudMTAlpha, ISupportInitialize)).EndInit()
			(CType(Me.nudMTPen2W, ISupportInitialize)).EndInit()
			(CType(Me.nudMTPen1W, ISupportInitialize)).EndInit()
			Me.TabMuiTenTyLe.ResumeLayout(False)
			Me.TabMuiTenTyLe.PerformLayout()
			(CType(Me.nudMTDAlpha, ISupportInitialize)).EndInit()
			(CType(Me.nudMTDPen2W, ISupportInitialize)).EndInit()
			(CType(Me.nudMTDPen1W, ISupportInitialize)).EndInit()
			Me.TabSongSong.ResumeLayout(False)
			Me.TabSongSong.PerformLayout()
			(CType(Me.nudSSLinesNo, ISupportInitialize)).EndInit()
			(CType(Me.nudSSSize, ISupportInitialize)).EndInit()
			(CType(Me.nudSSPen2W, ISupportInitialize)).EndInit()
			(CType(Me.nudSSPen1W, ISupportInitialize)).EndInit()
			Me.TabText.ResumeLayout(False)
			Me.TabText.PerformLayout()
			Me.TabTable.ResumeLayout(False)
			Me.TabTable.PerformLayout()
			(CType(Me.nudTblRowsNo, ISupportInitialize)).EndInit()
			(CType(Me.nudTblColsNo, ISupportInitialize)).EndInit()
			(CType(Me.nudTblAlpha, ISupportInitialize)).EndInit()
			(CType(Me.nudTblLineW, ISupportInitialize)).EndInit()
			(CType(Me.nudTblBorderW, ISupportInitialize)).EndInit()
			Me.TabGrid.ResumeLayout(False)
			(CType(Me.nudGrid, ISupportInitialize)).EndInit()
			Me.TabColorTable.ResumeLayout(False)
			Me.TabColorTable.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.TabUndo.ResumeLayout(False)
			(CType(Me.nudUndosNo, ISupportInitialize)).EndInit()
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

		Private Sub dlgOptions_Load(sender As Object, e As EventArgs)
			Me.myBanDo = myModule.fMain.myBando
			Me.nudGrid.Value = New Decimal(Me.myBanDo.myGridWidth)
			Me.txtColor.BackColor = modBdTC.defaGenPen1C
			Me.txtColor2.BackColor = modBdTC.defaGenPen2C
			Me.nudPenWidth.Value = New Decimal(modBdTC.defaGenPen1W)
			Me.nudPenWidth2.Value = New Decimal(modBdTC.defaGenPen2W)
			Me.nudLineStyle.Value = New Decimal(modBdTC.defaGenLineStyle)
			Me.chkBrush.Checked = modBdTC.defaGenFill
			Me.txtBrushColor.BackColor = Color.FromArgb(255, CInt(modBdTC.defaGenFillC.R), CInt(modBdTC.defaGenFillC.G), CInt(modBdTC.defaGenFillC.B))
			Me.nudAlpha.Value = New Decimal(CInt(modBdTC.defaGenFillC.A))
			Me.nudSSSize.Value = New Decimal(modBdTC.defaSongSongSize)
			Me.nudSSLinesNo.Value = New Decimal(modBdTC.defaSongSongLinesNo)
			Me.txtSS1Color.BackColor = modBdTC.defaSongSongPen1C
			Me.txtSS2Color.BackColor = modBdTC.defaSongSongPen2C
			Me.nudSSPen1W.Value = New Decimal(modBdTC.defaSongSongPen1W)
			Me.nudSSPen2W.Value = New Decimal(modBdTC.defaSongSongPen2W)
			Me.txtMT1Color.BackColor = modBdTC.defaMuiTenPen1C
			Me.txtMT2Color.BackColor = modBdTC.defaMuiTenPen2C
			Me.nudMTPen1W.Value = New Decimal(modBdTC.defaMuiTenPen1W)
			Me.nudMTPen2W.Value = New Decimal(modBdTC.defaMuiTenPen2W)
			Me.txtMTDoRong.Text = Conversions.ToString(modBdTC.defaMuiTenDoRong)
			Me.chkMTFill.Checked = modBdTC.defaMuiTenFill
			Me.txtMTFillColor.BackColor = Color.FromArgb(255, CInt(modBdTC.defaMuiTenFillC.R), CInt(modBdTC.defaMuiTenFillC.G), CInt(modBdTC.defaMuiTenFillC.B))
			Me.nudMTAlpha.Value = New Decimal(CInt(modBdTC.defaMuiTenFillC.A))
			Me.txtMTD1Color.BackColor = modBdTC.defaMuiTenDacPen1C
			Me.txtMTD2Color.BackColor = modBdTC.defaMuiTenDacPen2C
			Me.nudMTDPen1W.Value = New Decimal(modBdTC.defaMuiTenDacPen1W)
			Me.nudMTDPen2W.Value = New Decimal(modBdTC.defaMuiTenDacPen2W)
			Me.txtMTDDoRong.Text = Conversions.ToString(modBdTC.defaMuiTenDacDoRong)
			Me.txtMTDDoDai.Text = Conversions.ToString(modBdTC.defaMuiTenDacDoDai)
			Me.chkMTDFill.Checked = modBdTC.defaMuiTenDacFill
			Me.txtMTDFillColor.BackColor = Color.FromArgb(255, CInt(modBdTC.defaMuiTenDacFillC.R), CInt(modBdTC.defaMuiTenDacFillC.G), CInt(modBdTC.defaMuiTenDacFillC.B))
			Me.nudMTDAlpha.Value = New Decimal(CInt(modBdTC.defaMuiTenDacFillC.A))
			Me.nudTblRowsNo.Value = New Decimal(modBdTC.defaTableRowsNo)
			Me.nudTblColsNo.Value = New Decimal(modBdTC.defaTableColsNo)
			Me.txtTblBorderColor.BackColor = modBdTC.defaTableBorderC
			Me.txtTblLineColor.BackColor = modBdTC.defaTableLineC
			Me.nudTblBorderW.Value = New Decimal(modBdTC.defaTableBorderW)
			Me.nudTblLineW.Value = New Decimal(modBdTC.defaTableLineW)
			Me.txtTblFillColor.BackColor = Color.FromArgb(255, CInt(modBdTC.defaTableFillC.R), CInt(modBdTC.defaTableFillC.G), CInt(modBdTC.defaTableFillC.B))
			Me.nudTblAlpha.Value = New Decimal(CInt(modBdTC.defaTableFillC.A))
			Me.txtTableFont.Font = modBdTC.defaTableTFont
			Me.txtTableFont.ForeColor = modBdTC.defaTableTextC
			Me.txtTextFont.Font = modBdTC.defaTextFont
			Me.txtTextFont.ForeColor = modBdTC.defaTextC
			Me.nudUndosNo.Value = New Decimal(modBdTC.defaUndosNo)
			Me.txtQuanDoColor.BackColor = modBdTC.QuanDoColor
			Me.txtQuanXanhColor.BackColor = modBdTC.QuanXanhColor
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Do
				Me.GroupBox1.Controls("txtColor" + (num + 1).ToString("00")).BackColor = modBdTC.myColor(num)
				num += 1
			Loop While num <= 31
		End Sub

		Private Sub txtColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtColor.BackColor = modBdTC.GetMau(Me.txtColor.BackColor)
		End Sub

		Private Sub txtBrushColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtBrushColor.BackColor = modBdTC.GetMau(Me.txtBrushColor.BackColor)
		End Sub

		Private Sub txtColor2_DoubleClick(sender As Object, e As EventArgs)
			Me.txtColor2.BackColor = modBdTC.GetMau(Me.txtColor2.BackColor)
		End Sub

		Private Sub txtMT1Color_DoubleClick(sender As Object, e As EventArgs)
			Me.txtMT1Color.BackColor = modBdTC.GetMau(Me.txtMT1Color.BackColor)
		End Sub

		Private Sub txtMT2Color_DoubleClick(sender As Object, e As EventArgs)
			Me.txtMT2Color.BackColor = modBdTC.GetMau(Me.txtMT2Color.BackColor)
		End Sub

		Private Sub txtMTFillColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtMTFillColor.BackColor = modBdTC.GetMau(Me.txtMTFillColor.BackColor)
		End Sub

		Private Sub txtMTD1Color_DoubleClick(sender As Object, e As EventArgs)
			Me.txtMTD1Color.BackColor = modBdTC.GetMau(Me.txtMTD1Color.BackColor)
		End Sub

		Private Sub txtMTD2Color_DoubleClick(sender As Object, e As EventArgs)
			Me.txtMTD2Color.BackColor = modBdTC.GetMau(Me.txtMTD2Color.BackColor)
		End Sub

		Private Sub txtMTDFillColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtMTDFillColor.BackColor = modBdTC.GetMau(Me.txtMTDFillColor.BackColor)
		End Sub

		Private Sub txtSS1Color_DoubleClick(sender As Object, e As EventArgs)
			Me.txtSS1Color.BackColor = modBdTC.GetMau(Me.txtSS1Color.BackColor)
		End Sub

		Private Sub txtSS2Color_DoubleClick(sender As Object, e As EventArgs)
			Me.txtSS2Color.BackColor = modBdTC.GetMau(Me.txtSS2Color.BackColor)
		End Sub

		Private Sub txtTblBorderColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtTblBorderColor.BackColor = modBdTC.GetMau(Me.txtTblBorderColor.BackColor)
		End Sub

		Private Sub txtTblFillColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtTblFillColor.BackColor = modBdTC.GetMau(Me.txtTblFillColor.BackColor)
		End Sub

		Private Sub txtTblLineColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtTblLineColor.BackColor = modBdTC.GetMau(Me.txtTblLineColor.BackColor)
		End Sub

		Private Sub txtTextFont_DoubleClick(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.txtTextFont.Font
			fontDialog.Color = Me.txtTextFont.ForeColor
			fontDialog.ShowColor = True
			If fontDialog.ShowDialog() <> DialogResult.Cancel Then
				Me.txtTextFont.Font = fontDialog.Font
				Me.txtTextFont.ForeColor = fontDialog.Color
			End If
		End Sub

		Private Sub txtTableFont_DoubleClick(sender As Object, e As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.txtTableFont.Font
			fontDialog.Color = Me.txtTableFont.ForeColor
			fontDialog.ShowColor = True
			If fontDialog.ShowDialog() <> DialogResult.Cancel Then
				Me.txtTableFont.Font = fontDialog.Font
				Me.txtTableFont.ForeColor = fontDialog.Color
			End If
		End Sub

		Private Sub frmOptions_Closing(sender As Object, e As CancelEventArgs)
			Me.ChangeDefa()
		End Sub

		Private Sub ChangeDefa()
			Me.myBanDo.myGridWidth = Convert.ToInt32(Me.nudGrid.Value)
			modBdTC.defaGenPen1C = Me.txtColor.BackColor
			modBdTC.defaGenPen1W = Convert.ToInt32(Me.nudPenWidth.Value)
			modBdTC.defaGenPen2C = Me.txtColor2.BackColor
			modBdTC.defaGenPen2W = Convert.ToInt32(Me.nudPenWidth2.Value)
			modBdTC.defaGenLineStyle = Convert.ToInt32(Me.nudLineStyle.Value)
			If Me.chkBrush.Checked Then
				modBdTC.defaGenFill = True
			Else
				modBdTC.defaGenFill = False
			End If
			modBdTC.defaGenFillC = Color.FromArgb(Convert.ToInt32(Me.nudAlpha.Value), Me.txtBrushColor.BackColor)
			modBdTC.defaMuiTenPen1C = Me.txtMT1Color.BackColor
			modBdTC.defaMuiTenPen1W = Convert.ToInt32(Me.nudMTPen1W.Value)
			modBdTC.defaMuiTenPen2C = Me.txtMT2Color.BackColor
			modBdTC.defaMuiTenPen2W = Convert.ToInt32(Me.nudMTPen2W.Value)
			modBdTC.defaMuiTenDoRong = CSng(Conversion.Val(Me.txtMTDoRong.Text))
			If Me.chkMTFill.Checked Then
				modBdTC.defaMuiTenFill = True
			Else
				modBdTC.defaMuiTenFill = False
			End If
			modBdTC.defaMuiTenFillC = Color.FromArgb(Convert.ToInt32(Me.nudMTAlpha.Value), Me.txtMTFillColor.BackColor)
			modBdTC.defaMuiTenDacPen1C = Me.txtMTD1Color.BackColor
			modBdTC.defaMuiTenDacPen1W = Convert.ToInt32(Me.nudMTDPen1W.Value)
			modBdTC.defaMuiTenDacPen2C = Me.txtMTD2Color.BackColor
			modBdTC.defaMuiTenDacPen2W = Convert.ToInt32(Me.nudMTDPen2W.Value)
			modBdTC.defaMuiTenDacDoRong = CSng(Conversion.Val(Me.txtMTDDoRong.Text))
			modBdTC.defaMuiTenDacDoDai = CSng(Conversion.Val(Me.txtMTDDoDai.Text))
			If Me.chkMTDFill.Checked Then
				modBdTC.defaMuiTenDacFill = True
			Else
				modBdTC.defaMuiTenDacFill = False
			End If
			modBdTC.defaMuiTenDacFillC = Color.FromArgb(Convert.ToInt32(Me.nudMTDAlpha.Value), Me.txtMTDFillColor.BackColor)
			modBdTC.defaSongSongSize = Convert.ToInt32(Me.nudSSSize.Value)
			modBdTC.defaSongSongLinesNo = Convert.ToInt32(Me.nudSSLinesNo.Value)
			modBdTC.defaSongSongPen1C = Me.txtSS1Color.BackColor
			modBdTC.defaSongSongPen2C = Me.txtSS2Color.BackColor
			modBdTC.defaSongSongPen1W = Convert.ToInt32(Me.nudSSPen1W.Value)
			modBdTC.defaSongSongPen2W = Convert.ToInt32(Me.nudSSPen2W.Value)
			modBdTC.defaTableRowsNo = Convert.ToInt32(Me.nudTblRowsNo.Value)
			modBdTC.defaTableColsNo = Convert.ToInt32(Me.nudTblColsNo.Value)
			modBdTC.defaTableBorderC = Me.txtTblBorderColor.BackColor
			modBdTC.defaTableLineC = Me.txtTblLineColor.BackColor
			modBdTC.defaTableBorderW = Convert.ToInt32(Me.nudTblBorderW.Value)
			modBdTC.defaTableLineW = Convert.ToInt32(Me.nudTblLineW.Value)
			modBdTC.defaTableFillC = Color.FromArgb(Convert.ToInt32(Me.nudTblAlpha.Value), Me.txtTblFillColor.BackColor)
			modBdTC.defaTableTFontName = Me.txtTableFont.Font.Name
			modBdTC.defaTableTFontSize = Me.txtTableFont.Font.Size
			modBdTC.defaTableTFontStyle = CInt(Me.txtTableFont.Font.Style)
			modBdTC.defaTableTFont = Me.txtTableFont.Font
			modBdTC.defaTableTextC = Me.txtTableFont.ForeColor
			modBdTC.defaTextFontName = Me.txtTextFont.Font.Name
			modBdTC.defaTextFontSize = Me.txtTextFont.Font.Size
			modBdTC.defaTextFontStyle = CSng(Me.txtTextFont.Font.Style)
			modBdTC.defaTextFont = Me.txtTextFont.Font
			modBdTC.defaTextC = Me.txtTextFont.ForeColor
			If Decimal.Compare(Me.nudUndosNo.Value, New Decimal(modBdTC.defaUndosNo)) <> 0 Then
				modBdTC.defaUndosNo = Convert.ToInt32(Me.nudUndosNo.Value)
				myModule.fMain.myBando.XoaUndoStack()
			End If
			modBdTC.QuanDoColor = Me.txtQuanDoColor.BackColor
			modBdTC.QuanXanhColor = Me.txtQuanXanhColor.BackColor
			Dim num As Integer = 0
			' The following expression was wrapped in a checked-statement
			Do
				modBdTC.myColor(num) = Me.GroupBox1.Controls("txtColor" + (num + 1).ToString("00")).BackColor
				num += 1
			Loop While num <= 31
		End Sub

		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub txtColor01_DoubleClick(sender As Object, e As EventArgs)
			Dim textBox As TextBox = CType(sender, TextBox)
			textBox.BackColor = Me.GetMauGoc(textBox.BackColor)
		End Sub

		Private Sub txtColor01_GotFocus(sender As Object, e As EventArgs)
			Dim textBox As TextBox = CType(sender, TextBox)
			Me.myRect.X = textBox.Left
			Me.myRect.Y = textBox.Top
			Me.myRect.Width = textBox.Width
			Me.myRect.Height = textBox.Height
			Me.GroupBox1.Invalidate()
		End Sub

		Private Sub drawRectangle(g As Graphics)
			Dim pen As Pen = New Pen(Color.Black, 2F)
			g.DrawRectangle(pen, Me.myRect)
			pen.Dispose()
		End Sub

		Private Sub GroupBox1_Paint(sender As Object, e As PaintEventArgs)
			Me.drawRectangle(e.Graphics)
		End Sub

		Private Sub txtQuanDoColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtQuanDoColor.BackColor = modBdTC.GetMau(Me.txtQuanDoColor.BackColor)
		End Sub

		Private Sub txtQuanXanhColor_DoubleClick(sender As Object, e As EventArgs)
			Me.txtQuanXanhColor.BackColor = modBdTC.GetMau(Me.txtQuanXanhColor.BackColor)
		End Sub

		Private Function GetMauGoc(pColor As Color) As Color
			Dim colorDialog As ColorDialog = New ColorDialog()
			colorDialog.AllowFullOpen = True
			colorDialog.ShowHelp = True
			colorDialog.Color = pColor
			Dim result As Color
			If colorDialog.ShowDialog() = DialogResult.OK Then
				result = colorDialog.Color
			Else
				result = pColor
			End If
			Return result
		End Function
	End Class
End Namespace
