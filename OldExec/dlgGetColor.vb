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
	Public Class dlgGetColor
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

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

		Public SeleColor As Color

		Private myRect As Rectangle

		Friend Overridable Property txtColor32() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor32
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor32 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor32.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor32.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor32 = value
				flag = (Me._txtColor32 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor32.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor32.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor24() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor24 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor24.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor24.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor24 = value
				flag = (Me._txtColor24 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor24.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor24.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor16() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor16 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor16.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor16.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor16 = value
				flag = (Me._txtColor16 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor16.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor16.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor08() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor08
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor08 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor08.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor08.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor08 = value
				flag = (Me._txtColor08 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor08.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor08.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor31() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor31
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor31 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor31.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor31.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor31 = value
				flag = (Me._txtColor31 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor31.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor31.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor30() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor30
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor30 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor30.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor30.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor30 = value
				flag = (Me._txtColor30 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor30.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor30.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor29() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor29
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor29 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor29.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor29.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor29 = value
				flag = (Me._txtColor29 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor29.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor29.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor28() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor28 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor28.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor28.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor28 = value
				flag = (Me._txtColor28 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor28.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor28.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor27() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor27
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor27 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor27.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor27.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor27 = value
				flag = (Me._txtColor27 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor27.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor27.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor26() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor26 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor26.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor26.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor26 = value
				flag = (Me._txtColor26 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor26.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor26.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor25() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor25 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor25.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor25.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor25 = value
				flag = (Me._txtColor25 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor25.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor25.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor23() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor23 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor23.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor23.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor23 = value
				flag = (Me._txtColor23 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor23.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor23.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor22() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor22 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor22.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor22.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor22 = value
				flag = (Me._txtColor22 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor22.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor22.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor21() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor21 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor21.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor21.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor21 = value
				flag = (Me._txtColor21 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor21.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor21.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor20() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor20 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor20.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor20.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor20 = value
				flag = (Me._txtColor20 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor20.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor20.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor19() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor19 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor19.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor19.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor19 = value
				flag = (Me._txtColor19 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor19.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor19.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor18() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor18 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor18.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor18.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor18 = value
				flag = (Me._txtColor18 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor18.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor18.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor17() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor17 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor17.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor17.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor17 = value
				flag = (Me._txtColor17 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor17.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor17.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor15() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor15 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor15.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor15.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor15 = value
				flag = (Me._txtColor15 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor15.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor15.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor14() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor14 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor14.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor14.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor14 = value
				flag = (Me._txtColor14 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor14.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor14.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor13() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor13 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor13.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor13.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor13 = value
				flag = (Me._txtColor13 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor13.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor13.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor12() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor12 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor12.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor12.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor12 = value
				flag = (Me._txtColor12 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor12.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor12.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor11() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor11 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor11.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor11.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor11 = value
				flag = (Me._txtColor11 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor11.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor11.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor10() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor10 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor10.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor10.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor10 = value
				flag = (Me._txtColor10 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor10.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor10.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor09() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor09
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor09 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor09.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor09.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor09 = value
				flag = (Me._txtColor09 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor09.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor09.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor07() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor07
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor07 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor07.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor07.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor07 = value
				flag = (Me._txtColor07 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor07.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor07.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor06() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor06
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor06 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor06.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor06.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor06 = value
				flag = (Me._txtColor06 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor06.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor06.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor05() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor05
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor05 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor05.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor05.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor05 = value
				flag = (Me._txtColor05 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor05.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor05.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor04() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor04
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor04 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor04.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor04.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor04 = value
				flag = (Me._txtColor04 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor04.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor04.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor03() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor03
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor03 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor03.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor03.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor03 = value
				flag = (Me._txtColor03 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor03.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor03.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor02() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor02
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor02 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor02.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor02.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor02 = value
				flag = (Me._txtColor02 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor02.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor02.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtColor01() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtColor01
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtColor01 IsNot Nothing
				If flag Then
					RemoveHandler Me._txtColor01.GotFocus, AddressOf Me.txtColor01_GotFocus
					RemoveHandler Me._txtColor01.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
				Me._txtColor01 = value
				flag = (Me._txtColor01 IsNot Nothing)
				If flag Then
					AddHandler Me._txtColor01.GotFocus, AddressOf Me.txtColor01_GotFocus
					AddHandler Me._txtColor01.DoubleClick, AddressOf Me.txtColor01_DoubleClick
				End If
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgGetColor_Load
			AddHandler MyBase.Paint, AddressOf Me.dlgGetColor_Paint
			dlgGetColor.__ENCList.Add(New WeakReference(Me))
			Me.myRect = Nothing
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
			Me.SuspendLayout()
			Me.txtColor32.BackColor = Color.Red
			Me.txtColor32.ForeColor = SystemColors.HighlightText
			Dim arg_1C0_0 As Control = Me.txtColor32
			Dim location As Point = New Point(197, 92)
			arg_1C0_0.Location = location
			Me.txtColor32.Name = "txtColor32"
			Dim arg_1EA_0 As Control = Me.txtColor32
			Dim size As Size = New Size(21, 21)
			arg_1EA_0.Size = size
			Me.txtColor32.TabIndex = 95
			Me.txtColor24.BackColor = Color.Red
			Me.txtColor24.ForeColor = SystemColors.HighlightText
			Dim arg_236_0 As Control = Me.txtColor24
			location = New Point(197, 65)
			arg_236_0.Location = location
			Me.txtColor24.Name = "txtColor24"
			Dim arg_260_0 As Control = Me.txtColor24
			size = New Size(21, 21)
			arg_260_0.Size = size
			Me.txtColor24.TabIndex = 87
			Me.txtColor16.BackColor = Color.Red
			Me.txtColor16.ForeColor = SystemColors.HighlightText
			Dim arg_2AC_0 As Control = Me.txtColor16
			location = New Point(197, 39)
			arg_2AC_0.Location = location
			Me.txtColor16.Name = "txtColor16"
			Dim arg_2D6_0 As Control = Me.txtColor16
			size = New Size(21, 21)
			arg_2D6_0.Size = size
			Me.txtColor16.TabIndex = 79
			Me.txtColor08.BackColor = Color.Red
			Me.txtColor08.ForeColor = SystemColors.HighlightText
			Dim arg_322_0 As Control = Me.txtColor08
			location = New Point(197, 12)
			arg_322_0.Location = location
			Me.txtColor08.Name = "txtColor08"
			Dim arg_34C_0 As Control = Me.txtColor08
			size = New Size(21, 21)
			arg_34C_0.Size = size
			Me.txtColor08.TabIndex = 71
			Me.txtColor31.BackColor = Color.Red
			Me.txtColor31.ForeColor = SystemColors.HighlightText
			Dim arg_398_0 As Control = Me.txtColor31
			location = New Point(170, 93)
			arg_398_0.Location = location
			Me.txtColor31.Name = "txtColor31"
			Dim arg_3C2_0 As Control = Me.txtColor31
			size = New Size(21, 21)
			arg_3C2_0.Size = size
			Me.txtColor31.TabIndex = 94
			Me.txtColor30.BackColor = Color.Red
			Me.txtColor30.ForeColor = SystemColors.HighlightText
			Dim arg_40E_0 As Control = Me.txtColor30
			location = New Point(143, 93)
			arg_40E_0.Location = location
			Me.txtColor30.Name = "txtColor30"
			Dim arg_438_0 As Control = Me.txtColor30
			size = New Size(21, 21)
			arg_438_0.Size = size
			Me.txtColor30.TabIndex = 93
			Me.txtColor29.BackColor = Color.Red
			Me.txtColor29.ForeColor = SystemColors.HighlightText
			Dim arg_481_0 As Control = Me.txtColor29
			location = New Point(116, 93)
			arg_481_0.Location = location
			Me.txtColor29.Name = "txtColor29"
			Dim arg_4AB_0 As Control = Me.txtColor29
			size = New Size(21, 21)
			arg_4AB_0.Size = size
			Me.txtColor29.TabIndex = 92
			Me.txtColor28.BackColor = Color.Red
			Me.txtColor28.ForeColor = SystemColors.HighlightText
			Dim arg_4F4_0 As Control = Me.txtColor28
			location = New Point(89, 93)
			arg_4F4_0.Location = location
			Me.txtColor28.Name = "txtColor28"
			Dim arg_51E_0 As Control = Me.txtColor28
			size = New Size(21, 21)
			arg_51E_0.Size = size
			Me.txtColor28.TabIndex = 91
			Me.txtColor27.BackColor = Color.Red
			Me.txtColor27.ForeColor = SystemColors.HighlightText
			Dim arg_567_0 As Control = Me.txtColor27
			location = New Point(62, 93)
			arg_567_0.Location = location
			Me.txtColor27.Name = "txtColor27"
			Dim arg_591_0 As Control = Me.txtColor27
			size = New Size(21, 21)
			arg_591_0.Size = size
			Me.txtColor27.TabIndex = 90
			Me.txtColor26.BackColor = Color.Red
			Me.txtColor26.ForeColor = SystemColors.HighlightText
			Dim arg_5DA_0 As Control = Me.txtColor26
			location = New Point(35, 93)
			arg_5DA_0.Location = location
			Me.txtColor26.Name = "txtColor26"
			Dim arg_604_0 As Control = Me.txtColor26
			size = New Size(21, 21)
			arg_604_0.Size = size
			Me.txtColor26.TabIndex = 89
			Me.txtColor25.BackColor = Color.Red
			Me.txtColor25.ForeColor = SystemColors.HighlightText
			Dim arg_64C_0 As Control = Me.txtColor25
			location = New Point(8, 93)
			arg_64C_0.Location = location
			Me.txtColor25.Name = "txtColor25"
			Dim arg_676_0 As Control = Me.txtColor25
			size = New Size(21, 21)
			arg_676_0.Size = size
			Me.txtColor25.TabIndex = 88
			Me.txtColor23.BackColor = Color.Red
			Me.txtColor23.ForeColor = SystemColors.HighlightText
			Dim arg_6C2_0 As Control = Me.txtColor23
			location = New Point(170, 66)
			arg_6C2_0.Location = location
			Me.txtColor23.Name = "txtColor23"
			Dim arg_6EC_0 As Control = Me.txtColor23
			size = New Size(21, 21)
			arg_6EC_0.Size = size
			Me.txtColor23.TabIndex = 86
			Me.txtColor22.BackColor = Color.Red
			Me.txtColor22.ForeColor = SystemColors.HighlightText
			Dim arg_738_0 As Control = Me.txtColor22
			location = New Point(143, 66)
			arg_738_0.Location = location
			Me.txtColor22.Name = "txtColor22"
			Dim arg_762_0 As Control = Me.txtColor22
			size = New Size(21, 21)
			arg_762_0.Size = size
			Me.txtColor22.TabIndex = 85
			Me.txtColor21.BackColor = Color.Red
			Me.txtColor21.ForeColor = SystemColors.HighlightText
			Dim arg_7AB_0 As Control = Me.txtColor21
			location = New Point(116, 66)
			arg_7AB_0.Location = location
			Me.txtColor21.Name = "txtColor21"
			Dim arg_7D5_0 As Control = Me.txtColor21
			size = New Size(21, 21)
			arg_7D5_0.Size = size
			Me.txtColor21.TabIndex = 84
			Me.txtColor20.BackColor = Color.Red
			Me.txtColor20.ForeColor = SystemColors.HighlightText
			Dim arg_81E_0 As Control = Me.txtColor20
			location = New Point(89, 66)
			arg_81E_0.Location = location
			Me.txtColor20.Name = "txtColor20"
			Dim arg_848_0 As Control = Me.txtColor20
			size = New Size(21, 21)
			arg_848_0.Size = size
			Me.txtColor20.TabIndex = 83
			Me.txtColor19.BackColor = Color.Red
			Me.txtColor19.ForeColor = SystemColors.HighlightText
			Dim arg_891_0 As Control = Me.txtColor19
			location = New Point(62, 66)
			arg_891_0.Location = location
			Me.txtColor19.Name = "txtColor19"
			Dim arg_8BB_0 As Control = Me.txtColor19
			size = New Size(21, 21)
			arg_8BB_0.Size = size
			Me.txtColor19.TabIndex = 82
			Me.txtColor18.BackColor = Color.Red
			Me.txtColor18.ForeColor = SystemColors.HighlightText
			Dim arg_904_0 As Control = Me.txtColor18
			location = New Point(35, 66)
			arg_904_0.Location = location
			Me.txtColor18.Name = "txtColor18"
			Dim arg_92E_0 As Control = Me.txtColor18
			size = New Size(21, 21)
			arg_92E_0.Size = size
			Me.txtColor18.TabIndex = 81
			Me.txtColor17.BackColor = Color.Red
			Me.txtColor17.ForeColor = SystemColors.HighlightText
			Dim arg_976_0 As Control = Me.txtColor17
			location = New Point(8, 66)
			arg_976_0.Location = location
			Me.txtColor17.Name = "txtColor17"
			Dim arg_9A0_0 As Control = Me.txtColor17
			size = New Size(21, 21)
			arg_9A0_0.Size = size
			Me.txtColor17.TabIndex = 80
			Me.txtColor15.BackColor = Color.Red
			Me.txtColor15.ForeColor = SystemColors.HighlightText
			Dim arg_9EC_0 As Control = Me.txtColor15
			location = New Point(170, 39)
			arg_9EC_0.Location = location
			Me.txtColor15.Name = "txtColor15"
			Dim arg_A16_0 As Control = Me.txtColor15
			size = New Size(21, 21)
			arg_A16_0.Size = size
			Me.txtColor15.TabIndex = 78
			Me.txtColor14.BackColor = Color.Red
			Me.txtColor14.ForeColor = SystemColors.HighlightText
			Dim arg_A62_0 As Control = Me.txtColor14
			location = New Point(143, 39)
			arg_A62_0.Location = location
			Me.txtColor14.Name = "txtColor14"
			Dim arg_A8C_0 As Control = Me.txtColor14
			size = New Size(21, 21)
			arg_A8C_0.Size = size
			Me.txtColor14.TabIndex = 77
			Me.txtColor13.BackColor = Color.Red
			Me.txtColor13.ForeColor = SystemColors.HighlightText
			Dim arg_AD5_0 As Control = Me.txtColor13
			location = New Point(116, 39)
			arg_AD5_0.Location = location
			Me.txtColor13.Name = "txtColor13"
			Dim arg_AFF_0 As Control = Me.txtColor13
			size = New Size(21, 21)
			arg_AFF_0.Size = size
			Me.txtColor13.TabIndex = 76
			Me.txtColor12.BackColor = Color.Red
			Me.txtColor12.ForeColor = SystemColors.HighlightText
			Dim arg_B48_0 As Control = Me.txtColor12
			location = New Point(89, 39)
			arg_B48_0.Location = location
			Me.txtColor12.Name = "txtColor12"
			Dim arg_B72_0 As Control = Me.txtColor12
			size = New Size(21, 21)
			arg_B72_0.Size = size
			Me.txtColor12.TabIndex = 75
			Me.txtColor11.BackColor = Color.Red
			Me.txtColor11.ForeColor = SystemColors.HighlightText
			Dim arg_BBB_0 As Control = Me.txtColor11
			location = New Point(62, 39)
			arg_BBB_0.Location = location
			Me.txtColor11.Name = "txtColor11"
			Dim arg_BE5_0 As Control = Me.txtColor11
			size = New Size(21, 21)
			arg_BE5_0.Size = size
			Me.txtColor11.TabIndex = 74
			Me.txtColor10.BackColor = Color.Red
			Me.txtColor10.ForeColor = SystemColors.HighlightText
			Dim arg_C2E_0 As Control = Me.txtColor10
			location = New Point(35, 39)
			arg_C2E_0.Location = location
			Me.txtColor10.Name = "txtColor10"
			Dim arg_C58_0 As Control = Me.txtColor10
			size = New Size(21, 21)
			arg_C58_0.Size = size
			Me.txtColor10.TabIndex = 73
			Me.txtColor09.BackColor = Color.Red
			Me.txtColor09.ForeColor = SystemColors.HighlightText
			Dim arg_CA0_0 As Control = Me.txtColor09
			location = New Point(8, 39)
			arg_CA0_0.Location = location
			Me.txtColor09.Name = "txtColor09"
			Dim arg_CCA_0 As Control = Me.txtColor09
			size = New Size(21, 21)
			arg_CCA_0.Size = size
			Me.txtColor09.TabIndex = 72
			Me.txtColor07.BackColor = Color.Red
			Me.txtColor07.ForeColor = SystemColors.HighlightText
			Dim arg_D16_0 As Control = Me.txtColor07
			location = New Point(170, 12)
			arg_D16_0.Location = location
			Me.txtColor07.Name = "txtColor07"
			Dim arg_D40_0 As Control = Me.txtColor07
			size = New Size(21, 21)
			arg_D40_0.Size = size
			Me.txtColor07.TabIndex = 70
			Me.txtColor06.BackColor = Color.Red
			Me.txtColor06.ForeColor = SystemColors.HighlightText
			Dim arg_D8C_0 As Control = Me.txtColor06
			location = New Point(143, 12)
			arg_D8C_0.Location = location
			Me.txtColor06.Name = "txtColor06"
			Dim arg_DB6_0 As Control = Me.txtColor06
			size = New Size(21, 21)
			arg_DB6_0.Size = size
			Me.txtColor06.TabIndex = 69
			Me.txtColor05.BackColor = Color.Red
			Me.txtColor05.ForeColor = SystemColors.HighlightText
			Dim arg_DFF_0 As Control = Me.txtColor05
			location = New Point(116, 12)
			arg_DFF_0.Location = location
			Me.txtColor05.Name = "txtColor05"
			Dim arg_E29_0 As Control = Me.txtColor05
			size = New Size(21, 21)
			arg_E29_0.Size = size
			Me.txtColor05.TabIndex = 68
			Me.txtColor04.BackColor = Color.Red
			Me.txtColor04.ForeColor = SystemColors.HighlightText
			Dim arg_E72_0 As Control = Me.txtColor04
			location = New Point(89, 12)
			arg_E72_0.Location = location
			Me.txtColor04.Name = "txtColor04"
			Dim arg_E9C_0 As Control = Me.txtColor04
			size = New Size(21, 21)
			arg_E9C_0.Size = size
			Me.txtColor04.TabIndex = 67
			Me.txtColor03.BackColor = Color.Red
			Me.txtColor03.ForeColor = SystemColors.HighlightText
			Dim arg_EE5_0 As Control = Me.txtColor03
			location = New Point(62, 12)
			arg_EE5_0.Location = location
			Me.txtColor03.Name = "txtColor03"
			Dim arg_F0F_0 As Control = Me.txtColor03
			size = New Size(21, 21)
			arg_F0F_0.Size = size
			Me.txtColor03.TabIndex = 66
			Me.txtColor02.BackColor = Color.Red
			Me.txtColor02.ForeColor = SystemColors.HighlightText
			Dim arg_F58_0 As Control = Me.txtColor02
			location = New Point(35, 12)
			arg_F58_0.Location = location
			Me.txtColor02.Name = "txtColor02"
			Dim arg_F82_0 As Control = Me.txtColor02
			size = New Size(21, 21)
			arg_F82_0.Size = size
			Me.txtColor02.TabIndex = 65
			Me.txtColor01.BackColor = Color.Red
			Me.txtColor01.ForeColor = SystemColors.HighlightText
			Dim arg_FCA_0 As Control = Me.txtColor01
			location = New Point(8, 12)
			arg_FCA_0.Location = location
			Me.txtColor01.Name = "txtColor01"
			Dim arg_FF4_0 As Control = Me.txtColor01
			size = New Size(21, 21)
			arg_FF4_0.Size = size
			Me.txtColor01.TabIndex = 64
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(230, 125)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtColor32)
			Me.Controls.Add(Me.txtColor24)
			Me.Controls.Add(Me.txtColor16)
			Me.Controls.Add(Me.txtColor08)
			Me.Controls.Add(Me.txtColor31)
			Me.Controls.Add(Me.txtColor30)
			Me.Controls.Add(Me.txtColor29)
			Me.Controls.Add(Me.txtColor28)
			Me.Controls.Add(Me.txtColor27)
			Me.Controls.Add(Me.txtColor26)
			Me.Controls.Add(Me.txtColor25)
			Me.Controls.Add(Me.txtColor23)
			Me.Controls.Add(Me.txtColor22)
			Me.Controls.Add(Me.txtColor21)
			Me.Controls.Add(Me.txtColor20)
			Me.Controls.Add(Me.txtColor19)
			Me.Controls.Add(Me.txtColor18)
			Me.Controls.Add(Me.txtColor17)
			Me.Controls.Add(Me.txtColor15)
			Me.Controls.Add(Me.txtColor14)
			Me.Controls.Add(Me.txtColor13)
			Me.Controls.Add(Me.txtColor12)
			Me.Controls.Add(Me.txtColor11)
			Me.Controls.Add(Me.txtColor10)
			Me.Controls.Add(Me.txtColor09)
			Me.Controls.Add(Me.txtColor07)
			Me.Controls.Add(Me.txtColor06)
			Me.Controls.Add(Me.txtColor05)
			Me.Controls.Add(Me.txtColor04)
			Me.Controls.Add(Me.txtColor03)
			Me.Controls.Add(Me.txtColor02)
			Me.Controls.Add(Me.txtColor01)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgGetColor"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "B" & ChrW(7843) & "ng m" & ChrW(7847) & "u"
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

		Private Sub dlgGetColor_Load(sender As Object, e As EventArgs)
			Dim i As Integer = 0
			' The following expression was wrapped in a checked-statement
			Dim arg_AF_0 As Integer
			Dim num As Integer
			Do
				Me.Controls("txtColor" + (i + 1).ToString("00")).BackColor = modBanDo.myColor(i)
				Dim flag As Boolean = Me.Controls("txtColor" + (i + 1).ToString("00")).BackColor = Me.SeleColor
				If flag Then
					Me.Controls("txtColor" + (i + 1).ToString("00")).[Select]()
				End If
				i += 1
				arg_AF_0 = i
				num = 31
			Loop While arg_AF_0 <= num
		End Sub

		Private Sub txtColor01_DoubleClick(sender As Object, e As EventArgs)
			Dim txtbox As TextBox = CType(sender, TextBox)
			Me.SeleColor = txtbox.BackColor
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		Private Sub txtColor01_GotFocus(sender As Object, e As EventArgs)
			Dim txtbox As TextBox = CType(sender, TextBox)
			Me.myRect.X = txtbox.Left
			Me.myRect.Y = txtbox.Top
			Me.myRect.Width = txtbox.Width
			Me.myRect.Height = txtbox.Height
			Me.Invalidate()
		End Sub

		Private Sub drawRectangle(g As Graphics)
			Dim mPen As Pen = New Pen(Color.Black, 2F)
			g.DrawRectangle(mPen, Me.myRect)
			mPen.Dispose()
		End Sub

		Private Sub dlgGetColor_Paint(sender As Object, e As PaintEventArgs)
			Me.drawRectangle(e.Graphics)
		End Sub
	End Class
End Namespace
