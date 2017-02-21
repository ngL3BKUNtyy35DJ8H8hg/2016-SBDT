Imports DienTapLib
Imports Microsoft.DirectX
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgShiftAll
		Inherits Form

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("txtDeltaX")>
		Private _txtDeltaX As TextBox

		<AccessedThroughProperty("txtDeltaY")>
		Private _txtDeltaY As TextBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("chkSymbols")>
		Private _chkSymbols As CheckBox

		<AccessedThroughProperty("chkActs")>
		Private _chkActs As CheckBox

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("txtGiayLeftX")>
		Private _txtGiayLeftX As TextBox

		<AccessedThroughProperty("txtGiayUpY")>
		Private _txtGiayUpY As TextBox

		<AccessedThroughProperty("txtVTUpY")>
		Private _txtVTUpY As TextBox

		<AccessedThroughProperty("txtVTLeftX")>
		Private _txtVTLeftX As TextBox

		Private MenuFileName As String

		Private mymenu As CMnu

		Private myScripts As List(Of CScript)

		Private mDeltaX As Double

		Private mDeltaY As Double

		Private mChenhLechX As Double

		Private mChenhLechY As Double

		Private mResolution As Double

		Private mDeltaX2 As Single

		Private mDeltaY2 As Single

		Private mChenhLechX2 As Double

		Private mChenhLechY2 As Double

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

		Friend Overridable Property Label1() As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property txtDeltaX() As TextBox
			Get
				Return Me._txtDeltaX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDeltaX = value
			End Set
		End Property

		Friend Overridable Property txtDeltaY() As TextBox
			Get
				Return Me._txtDeltaY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtDeltaY = value
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

		Friend Overridable Property chkSymbols() As CheckBox
			Get
				Return Me._chkSymbols
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkSymbols = value
			End Set
		End Property

		Friend Overridable Property chkActs() As CheckBox
			Get
				Return Me._chkActs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._chkActs = value
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

		Friend Overridable Property Label4() As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
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

		Friend Overridable Property Label6() As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
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

		Friend Overridable Property txtGiayLeftX() As TextBox
			Get
				Return Me._txtGiayLeftX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtGiayLeftX = value
			End Set
		End Property

		Friend Overridable Property txtGiayUpY() As TextBox
			Get
				Return Me._txtGiayUpY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtGiayUpY = value
			End Set
		End Property

		Friend Overridable Property txtVTUpY() As TextBox
			Get
				Return Me._txtVTUpY
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtVTUpY = value
			End Set
		End Property

		Friend Overridable Property txtVTLeftX() As TextBox
			Get
				Return Me._txtVTLeftX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtVTLeftX = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgShiftAll_Load
			Me.mDeltaX = 0.0
			Me.mDeltaY = 0.0
			Me.mChenhLechX = 0.0
			Me.mChenhLechY = 0.0
			Me.mResolution = 0.001
			Me.mDeltaX2 = 0F
			Me.mDeltaY2 = 0F
			Me.mChenhLechX2 = 0.0
			Me.mChenhLechY2 = 0.0
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
			Me.Label1 = New Label()
			Me.txtDeltaX = New TextBox()
			Me.txtDeltaY = New TextBox()
			Me.Label2 = New Label()
			Me.chkSymbols = New CheckBox()
			Me.chkActs = New CheckBox()
			Me.Label3 = New Label()
			Me.Label4 = New Label()
			Me.Label5 = New Label()
			Me.Label6 = New Label()
			Me.Label7 = New Label()
			Me.txtGiayLeftX = New TextBox()
			Me.txtGiayUpY = New TextBox()
			Me.txtVTUpY = New TextBox()
			Me.txtVTLeftX = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_170_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(204, 340)
			arg_170_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_1C2_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_1C2_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_1EF_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_1EF_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_216_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_216_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_260_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_260_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_287_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_287_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_2C9_0 As Control = Me.Label1
			location = New Point(30, 207)
			arg_2C9_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_2F0_0 As Control = Me.Label1
			size = New Size(101, 14)
			arg_2F0_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "DeltaX (Kinh " & ChrW(273) & ChrW(7897) & "):"
			Dim arg_329_0 As Control = Me.txtDeltaX
			location = New Point(140, 204)
			arg_329_0.Location = location
			Me.txtDeltaX.Name = "txtDeltaX"
			Dim arg_350_0 As Control = Me.txtDeltaX
			size = New Size(100, 21)
			arg_350_0.Size = size
			Me.txtDeltaX.TabIndex = 2
			Me.txtDeltaX.Text = "-0.0044"
			Dim arg_389_0 As Control = Me.txtDeltaY
			location = New Point(140, 231)
			arg_389_0.Location = location
			Me.txtDeltaY.Name = "txtDeltaY"
			Dim arg_3B0_0 As Control = Me.txtDeltaY
			size = New Size(100, 21)
			arg_3B0_0.Size = size
			Me.txtDeltaY.TabIndex = 4
			Me.txtDeltaY.Text = "0.00126"
			Me.Label2.AutoSize = True
			Dim arg_3F2_0 As Control = Me.Label2
			location = New Point(30, 234)
			arg_3F2_0.Location = location
			Me.Label2.Name = "Label2"
			Dim arg_419_0 As Control = Me.Label2
			size = New Size(89, 14)
			arg_419_0.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "DeltaY (V" & ChrW(297) & " " & ChrW(273) & ChrW(7897) & "):"
			Me.chkSymbols.AutoSize = True
			Dim arg_45E_0 As Control = Me.chkSymbols
			location = New Point(140, 267)
			arg_45E_0.Location = location
			Me.chkSymbols.Name = "chkSymbols"
			Dim arg_485_0 As Control = Me.chkSymbols
			size = New Size(113, 18)
			arg_485_0.Size = size
			Me.chkSymbols.TabIndex = 5
			Me.chkSymbols.Text = "Cho các Ký hi" & ChrW(7879) & "u"
			Me.chkSymbols.UseVisualStyleBackColor = True
			Me.chkActs.AutoSize = True
			Dim arg_4D6_0 As Control = Me.chkActs
			location = New Point(140, 291)
			arg_4D6_0.Location = location
			Me.chkActs.Name = "chkActs"
			Dim arg_4FD_0 As Control = Me.chkActs
			size = New Size(122, 18)
			arg_4FD_0.Size = size
			Me.chkActs.TabIndex = 6
			Me.chkActs.Text = "Cho các hi" & ChrW(7879) & "u " & ChrW(7913) & "ng"
			Me.chkActs.UseVisualStyleBackColor = True
			Me.Label3.BorderStyle = BorderStyle.Fixed3D
			Me.Label3.ForeColor = SystemColors.ActiveCaption
			Dim arg_558_0 As Control = Me.Label3
			location = New Point(13, 9)
			arg_558_0.Location = location
			Me.Label3.Name = "Label3"
			Dim arg_582_0 As Control = Me.Label3
			size = New Size(337, 76)
			arg_582_0.Size = size
			Me.Label3.TabIndex = 7
			Me.Label3.Text = "Sau khi " & ChrW(273) & "ánh d" & ChrW(7845) & "u check và b" & ChrW(7845) & "m OK, T" & ChrW(7845) & "t c" & ChrW(7843) & " các ký hi" & ChrW(7879) & "u trong file B" & ChrW(273) & "TC, và T" & ChrW(7845) & "t c" & ChrW(7843) & " các Hi" & ChrW(7879) & "u " & ChrW(7913) & "ng trong các file k" & ChrW(7883) & "ch b" & ChrW(7843) & "n s" & ChrW(7869) & " b" & ChrW(7883) & " d" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n theo các tham s" & ChrW(7889) & " d" & ChrW(432) & ChrW(7899) & "i " & ChrW(273) & "ây."
			Me.Label3.TextAlign = ContentAlignment.MiddleCenter
			Me.Label4.AutoSize = True
			Dim arg_5D1_0 As Control = Me.Label4
			location = New Point(12, 129)
			arg_5D1_0.Location = location
			Me.Label4.Name = "Label4"
			Dim arg_5F8_0 As Control = Me.Label4
			size = New Size(74, 14)
			arg_5F8_0.Size = size
			Me.Label4.TabIndex = 8
			Me.Label4.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " gi" & ChrW(7845) & "y:"
			Me.Label5.AutoSize = True
			Dim arg_63A_0 As Control = Me.Label5
			location = New Point(12, 154)
			arg_63A_0.Location = location
			Me.Label5.Name = "Label5"
			Dim arg_661_0 As Control = Me.Label5
			size = New Size(69, 14)
			arg_661_0.Size = size
			Me.Label5.TabIndex = 9
			Me.Label5.Text = "B" & ChrW(7843) & "n " & ChrW(273) & ChrW(7891) & " VT:"
			Me.Label6.AutoSize = True
			Dim arg_6A1_0 As Control = Me.Label6
			location = New Point(97, 109)
			arg_6A1_0.Location = location
			Me.Label6.Name = "Label6"
			Dim arg_6C8_0 As Control = Me.Label6
			size = New Size(73, 14)
			arg_6C8_0.Size = size
			Me.Label6.TabIndex = 10
			Me.Label6.Text = "Kinh " & ChrW(273) & ChrW(7897) & " trái:"
			Me.Label7.AutoSize = True
			Dim arg_70B_0 As Control = Me.Label7
			location = New Point(204, 109)
			arg_70B_0.Location = location
			Me.Label7.Name = "Label7"
			Dim arg_732_0 As Control = Me.Label7
			size = New Size(66, 14)
			arg_732_0.Size = size
			Me.Label7.TabIndex = 11
			Me.Label7.Text = "V" & ChrW(297) & " " & ChrW(273) & ChrW(7897) & " trên:"
			Dim arg_766_0 As Control = Me.txtGiayLeftX
			location = New Point(100, 126)
			arg_766_0.Location = location
			Me.txtGiayLeftX.Name = "txtGiayLeftX"
			Dim arg_78D_0 As Control = Me.txtGiayLeftX
			size = New Size(86, 21)
			arg_78D_0.Size = size
			Me.txtGiayLeftX.TabIndex = 12
			Me.txtGiayLeftX.Text = "107.11"
			Dim arg_7C4_0 As Control = Me.txtGiayUpY
			location = New Point(100, 151)
			arg_7C4_0.Location = location
			Me.txtGiayUpY.Name = "txtGiayUpY"
			Dim arg_7EB_0 As Control = Me.txtGiayUpY
			size = New Size(86, 21)
			arg_7EB_0.Size = size
			Me.txtGiayUpY.TabIndex = 13
			Me.txtGiayUpY.Text = "16.75"
			Dim arg_825_0 As Control = Me.txtVTUpY
			location = New Point(204, 151)
			arg_825_0.Location = location
			Me.txtVTUpY.Name = "txtVTUpY"
			Dim arg_84C_0 As Control = Me.txtVTUpY
			size = New Size(86, 21)
			arg_84C_0.Size = size
			Me.txtVTUpY.TabIndex = 15
			Me.txtVTUpY.Text = "16.7515"
			Dim arg_883_0 As Control = Me.txtVTLeftX
			location = New Point(204, 126)
			arg_883_0.Location = location
			Me.txtVTLeftX.Name = "txtVTLeftX"
			Dim arg_8AA_0 As Control = Me.txtVTLeftX
			size = New Size(86, 21)
			arg_8AA_0.Size = size
			Me.txtVTLeftX.TabIndex = 14
			Me.txtVTLeftX.Text = "107.1057"
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			size = New Size(362, 381)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtVTUpY)
			Me.Controls.Add(Me.txtVTLeftX)
			Me.Controls.Add(Me.txtGiayUpY)
			Me.Controls.Add(Me.txtGiayLeftX)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.chkActs)
			Me.Controls.Add(Me.chkSymbols)
			Me.Controls.Add(Me.txtDeltaY)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.txtDeltaX)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.164948F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgShiftAll"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "D" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n t" & ChrW(7845) & "t c" & ChrW(7843) & " các Ký hi" & ChrW(7879) & "u và Hi" & ChrW(7879) & "u " & ChrW(7913) & "ng"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Try
				Me.mDeltaX = Conversions.ToDouble(Me.txtDeltaX.Text)
				Me.mDeltaY = Conversions.ToDouble(Me.txtDeltaY.Text)
				Me.mDeltaX2 = CSng((Me.mDeltaX / Me.mResolution))
				Me.mDeltaY2 = CSng((Me.mDeltaY / Me.mResolution))
				Me.mChenhLechX = Conversions.ToDouble(Me.txtGiayLeftX.Text) - Conversions.ToDouble(Me.txtVTLeftX.Text)
				Me.mChenhLechY = Conversions.ToDouble(Me.txtGiayUpY.Text) - Conversions.ToDouble(Me.txtVTUpY.Text)
				Me.mChenhLechX2 = Me.mChenhLechX / Me.mResolution
				Me.mChenhLechY2 = Me.mChenhLechY / Me.mResolution
				Me.mDeltaX2 = CSng((CDec(Me.mDeltaX2) + Me.mChenhLechX2))
				Me.mDeltaY2 = CSng((CDec(Me.mDeltaY2) + Me.mChenhLechY2))
				If Me.chkSymbols.Checked AndAlso Interaction.MsgBox("D" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n các Ký hi" & ChrW(7879) & "u?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
					myModule.fMain.myBando.ShiftAll(Me.mDeltaX, Me.mDeltaY)
					Interaction.MsgBox("D" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n các Ký hi" & ChrW(7879) & "u xong...", MsgBoxStyle.OkOnly, Nothing)
				End If
				If Me.chkActs.Checked AndAlso Interaction.MsgBox("D" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n các Hi" & ChrW(7879) & "u " & ChrW(7913) & "ng?", MsgBoxStyle.YesNo, Nothing) = MsgBoxResult.Yes Then
					Me.ShiftAllScripts()
					Interaction.MsgBox("D" & ChrW(7883) & "ch chuy" & ChrW(7875) & "n các Hi" & ChrW(7879) & "u " & ChrW(7913) & "ng xong...", MsgBoxStyle.OkOnly, Nothing)
				End If
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Catch expr_174 As Exception
				ProjectData.SetProjectError(expr_174)
				Interaction.MsgBox("Shift truc trac...", MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub ShiftAllScripts()
			If Me.myScripts.Count > 0 Then
				Try
					Try
						Dim enumerator As List(Of CScript).Enumerator = Me.myScripts.GetEnumerator()
						While enumerator.MoveNext()
							Dim current As CScript = enumerator.Current
							MyProject.Application.DoEvents()
							Me.ShiftAllActs(current)
						End While
					Finally
						Dim enumerator As List(Of CScript).Enumerator
						(CType(enumerator, IDisposable)).Dispose()
					End Try
				Catch expr_50 As Exception
					ProjectData.SetProjectError(expr_50)
					Dim ex As Exception = expr_50
					Interaction.MsgBox("ShiftAllActs truc trac...", MsgBoxStyle.OkOnly, Nothing)
					Throw ex
				End Try
			Else
				Interaction.MsgBox("Khong co Script file nao.", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub ShiftAllActs(mScript As CScript)
			Try
				Dim list As List(Of CActDef) = Nothing
				Try
					list = CActDefs.ReadActionDef(mScript.ScrptFile)
					MyProject.Application.DoEvents()
				Catch expr_1A As Exception
					ProjectData.SetProjectError(expr_1A)
					Dim ex As Exception = expr_1A
					list = Nothing
					Interaction.MsgBox("ReadActionDef truc trac", MsgBoxStyle.OkOnly, Nothing)
					Throw ex
				End Try
				If Not Information.IsNothing(list) Then
					Try
						Dim enumerator As List(Of CActDef).Enumerator = list.GetEnumerator()
						While enumerator.MoveNext()
							Dim current As CActDef = enumerator.Current
							Dim actionType As String = current.ActionType
							If Operators.CompareString(actionType, "Fly", False) = 0 OrElse Operators.CompareString(actionType, "Move", False) = 0 Then
								Dim cMoveObjDef As CMoveObjDef = CType(current, CMoveObjDef)
								Dim list2 As List(Of Vector3) = New List(Of Vector3)()
								Try
									Dim enumerator2 As List(Of Vector3).Enumerator = cMoveObjDef.targets.GetEnumerator()
									While enumerator2.MoveNext()
										Dim current2 As Vector3 = enumerator2.Current
										Dim item As Vector3 = New Vector3(current2.X + Me.mDeltaX2, current2.Y + Me.mDeltaY2, current2.Z)
										list2.Add(item)
									End While
								Finally
									Dim enumerator2 As List(Of Vector3).Enumerator
									(CType(enumerator2, IDisposable)).Dispose()
								End Try
								cMoveObjDef.targets.Clear()
								Try
									Dim enumerator3 As List(Of Vector3).Enumerator = list2.GetEnumerator()
									While enumerator3.MoveNext()
										Dim current3 As Vector3 = enumerator3.Current
										cMoveObjDef.targets.Add(current3)
									End While
								Finally
									Dim enumerator3 As List(Of Vector3).Enumerator
									(CType(enumerator3, IDisposable)).Dispose()
								End Try
							Else If Operators.CompareString(actionType, "Shoot", False) = 0 Then
								Dim cShootFromDef As CShootFromDef = CType(current, CShootFromDef)
								Dim cShootFromDef2 As CShootFromDef = cShootFromDef
								cShootFromDef2.frompos.X = cShootFromDef2.frompos.X + Me.mDeltaX2
								cShootFromDef2 = cShootFromDef
								cShootFromDef2.frompos.Y = cShootFromDef2.frompos.Y + Me.mDeltaY2
								cShootFromDef2 = cShootFromDef
								cShootFromDef2.topos.X = cShootFromDef2.topos.X + Me.mDeltaX2
								cShootFromDef2 = cShootFromDef
								cShootFromDef2.topos.Y = cShootFromDef2.topos.Y + Me.mDeltaY2
							Else If Operators.CompareString(actionType, "Bombard", False) = 0 Then
								Dim cBombardFromDef As CBombardFromDef = CType(current, CBombardFromDef)
								Dim cBombardFromDef2 As CBombardFromDef = cBombardFromDef
								cBombardFromDef2.frompos.X = cBombardFromDef2.frompos.X + Me.mDeltaX2
								cBombardFromDef2 = cBombardFromDef
								cBombardFromDef2.frompos.Y = cBombardFromDef2.frompos.Y + Me.mDeltaY2
								cBombardFromDef2 = cBombardFromDef
								cBombardFromDef2.topos.X = cBombardFromDef2.topos.X + Me.mDeltaX2
								cBombardFromDef2 = cBombardFromDef
								cBombardFromDef2.topos.Y = cBombardFromDef2.topos.Y + Me.mDeltaY2
							Else If Operators.CompareString(actionType, "Explode", False) = 0 Then
								Dim cExplodeObjDef As CExplodeObjDef = CType(current, CExplodeObjDef)
								Dim cExplodeObjDef2 As CExplodeObjDef = cExplodeObjDef
								cExplodeObjDef2.frompos.X = cExplodeObjDef2.frompos.X + Me.mDeltaX2
								cExplodeObjDef2 = cExplodeObjDef
								cExplodeObjDef2.frompos.Y = cExplodeObjDef2.frompos.Y + Me.mDeltaY2
							Else
								If Operators.CompareString(actionType, "SpinTo", False) <> 0 Then
									If Operators.CompareString(actionType, "Appear", False) <> 0 AndAlso Operators.CompareString(actionType, "AppearLeft", False) <> 0 Then
										If Operators.CompareString(actionType, "AppearUp", False) <> 0 Then
											If Operators.CompareString(actionType, "AppearDown", False) <> 0 Then
												If Operators.CompareString(actionType, "AppearA", False) <> 0 Then
													If Operators.CompareString(actionType, "Unhide", False) <> 0 Then
														If Operators.CompareString(actionType, "Disappear", False) <> 0 AndAlso Operators.CompareString(actionType, "DisappearLeft", False) <> 0 Then
															If Operators.CompareString(actionType, "DisappearUp", False) <> 0 Then
																If Operators.CompareString(actionType, "DisappearDown", False) <> 0 Then
																	If Operators.CompareString(actionType, "DisappearA", False) <> 0 Then
																		If Operators.CompareString(actionType, "Hide", False) <> 0 Then
																			If Operators.CompareString(actionType, "Blink", False) <> 0 Then
																				If Operators.CompareString(actionType, "ExplodeDcl", False) <> 0 Then
																					If Operators.CompareString(actionType, "Comment", False) <> 0 Then
																						If Operators.CompareString(actionType, "FocusAt", False) <> 0 Then
																							If Operators.CompareString(actionType, "Description", False) <> 0 Then
																								Interaction.MsgBox(current.GetActionStr(), MsgBoxStyle.OkOnly, Nothing)
																							End If
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
														Continue While
														Continue While
													End If
												End If
											End If
										End If
									End If
									Continue While
									Continue While
								End If
								Dim cSpinToDef As CSpinToDef = CType(current, CSpinToDef)
								Dim cSpinToDef2 As CSpinToDef = cSpinToDef
								cSpinToDef2.topos.X = cSpinToDef2.topos.X + Me.mDeltaX2
								cSpinToDef2 = cSpinToDef
								cSpinToDef2.topos.Y = cSpinToDef2.topos.Y + Me.mDeltaY2
							End If
						End While
					Finally
						Dim enumerator As List(Of CActDef).Enumerator
						(CType(enumerator, IDisposable)).Dispose()
					End Try
					Try
						MyProject.Application.DoEvents()
						CActDefs.WriteActionDef(list, mScript.ScrptFile)
					Catch expr_4F3 As Exception
						ProjectData.SetProjectError(expr_4F3)
						Dim ex2 As Exception = expr_4F3
						Interaction.MsgBox("WriteActionDef truc trac", MsgBoxStyle.OkOnly, Nothing)
						Throw ex2
					End Try
				End If
			Catch expr_514 As Exception
				ProjectData.SetProjectError(expr_514)
				Dim ex3 As Exception = expr_514
				Interaction.MsgBox("Shift cho file '" + mScript.ScrptFile + "' truc trac.", MsgBoxStyle.OkOnly, Nothing)
				Throw ex3
			End Try
		End Sub

		Private Sub dlgShiftAll_Load(sender As Object, e As EventArgs)
			Me.MenuFileName = modSaBan.mySaBanDir + "\" + modSaBan.MyMnuName
			Me.mResolution = 0.001
			Try
				' The following expression was wrapped in a checked-expression
				Me.mResolution = (modSaBan.myMap1X - modSaBan.myMap2X) / CDec((modSaBan.myGRID_WIDTH - 1))
				If MyProject.Computer.FileSystem.FileExists(Me.MenuFileName) Then
					Me.mymenu = New CMnu(Nothing)
					Me.mymenu.LoadScripts(Me.MenuFileName)
					Me.myScripts = Me.mymenu.scripts
				Else
					Me.myScripts = New List(Of CScript)()
				End If
			Catch expr_97 As Exception
				ProjectData.SetProjectError(expr_97)
				Interaction.MsgBox("Load Scripts truc trac.", MsgBoxStyle.OkOnly, Nothing)
				Me.Close()
				ProjectData.ClearProjectError()
			End Try
		End Sub
	End Class
End Namespace
