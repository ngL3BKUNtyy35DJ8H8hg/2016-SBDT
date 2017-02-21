Imports BdTC.My
Imports Microsoft.VisualBasic
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
	Public Class dlgNewSaBan
		Inherits Form

		Private Shared __ENCList As ArrayList = New ArrayList()

		Private components As IContainer

		<AccessedThroughProperty("TableLayoutPanel1")>
		Private _TableLayoutPanel1 As TableLayoutPanel

		<AccessedThroughProperty("OK_Button")>
		Private _OK_Button As Button

		<AccessedThroughProperty("Cancel_Button")>
		Private _Cancel_Button As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("txtName")>
		Private _txtName As TextBox

		<AccessedThroughProperty("txtMode")>
		Private _txtMode As TextBox

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

		Friend Overridable Property txtName() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtName
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim flag As Boolean = Me._txtName IsNot Nothing
				If flag Then
					RemoveHandler Me._txtName.DoubleClick, AddressOf Me.txtName_DoubleClick
				End If
				Me._txtName = value
				flag = (Me._txtName IsNot Nothing)
				If flag Then
					AddHandler Me._txtName.DoubleClick, AddressOf Me.txtName_DoubleClick
				End If
			End Set
		End Property

		Friend Overridable Property txtMode() As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._txtMode
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMode = value
			End Set
		End Property

		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgNewSaBan_Load
			dlgNewSaBan.__ENCList.Add(New WeakReference(Me))
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
			Me.Label1 = New Label()
			Me.txtName = New TextBox()
			Me.txtMode = New TextBox()
			Me.TableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TableLayoutPanel1.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.TableLayoutPanel1.ColumnCount = 2
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
			Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
			Dim arg_F7_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(139, 65)
			arg_F7_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_14D_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_14D_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_17E_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_17E_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_1A8_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_1A8_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1F8_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1F8_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_222_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_222_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_266_0 As Control = Me.Label1
			location = New Point(12, 27)
			arg_266_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_290_0 As Control = Me.Label1
			size = New Size(71, 13)
			arg_290_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên th" & ChrW(432) & " m" & ChrW(7909) & "c:"
			Dim arg_2C7_0 As Control = Me.txtName
			location = New Point(89, 24)
			arg_2C7_0.Location = location
			Me.txtName.Name = "txtName"
			Dim arg_2F4_0 As Control = Me.txtName
			size = New Size(193, 21)
			arg_2F4_0.Size = size
			Me.txtName.TabIndex = 2
			Dim arg_31A_0 As Control = Me.txtMode
			location = New Point(15, 67)
			arg_31A_0.Location = location
			Me.txtMode.Name = "txtMode"
			Dim arg_344_0 As Control = Me.txtMode
			size = New Size(68, 21)
			arg_344_0.Size = size
			Me.txtMode.TabIndex = 3
			Me.txtMode.Text = "New"
			Me.txtMode.Visible = False
			Me.AcceptButton = Me.OK_Button
			Dim autoScaleDimensions As SizeF = New SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.Cancel_Button
			size = New Size(297, 106)
			Me.ClientSize = size
			Me.Controls.Add(Me.txtMode)
			Me.Controls.Add(Me.txtName)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TableLayoutPanel1)
			Me.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgNewSaBan"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Sa bàn m" & ChrW(7899) & "i"
			Me.TableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub OK_Button_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtMode.Text, "New", False) = 0
			If flag Then
				Dim flag2 As Boolean = Conversions.ToBoolean(Me.CreateNew())
				If flag2 Then
					modBanDo.mySaBanDir = Me.txtName.Text
					MyProject.Computer.FileSystem.WriteAllText(modBanDo.mySaBanDefFileName, modBanDo.mySaBanDir, False)
					Me.DialogResult = DialogResult.OK
					Me.Close()
				Else
					Interaction.MsgBox("Truc trac", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Dim flag2 As Boolean = Conversions.ToBoolean(Me.OpenSB())
				If flag2 Then
					modBanDo.mySaBanDir = Me.txtName.Text
					MyProject.Computer.FileSystem.WriteAllText(modBanDo.mySaBanDefFileName, modBanDo.mySaBanDir, False)
					Me.DialogResult = DialogResult.OK
					Me.Close()
				Else
					Interaction.MsgBox("Truc trac", MsgBoxStyle.OkOnly, Nothing)
				End If
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgNewSaBan_Load(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtMode.Text, "New", False) = 0
			If flag Then
				Me.Text = "Sa bàn m" & ChrW(7899) & "i"
			Else
				Me.Text = "M" & ChrW(7903) & " Sa bàn"
			End If
		End Sub

		Private Function GetNoActStr() As String
			Return "<Actions>" & vbCrLf & "</Actions>"
		End Function

		Private Function GetMyMenuStr(pDirName As String) As String
			Dim kq As String = "<MenuItems>"
			kq = kq + vbCrLf & "<MenuItem Name="""" PosX=""0"" PosY=""0"" Width=""0"" Height=""0"" ActFileName=""" + pDirName + "\NoAct.xml"">1</MenuItem>"
			Return kq + vbCrLf & "</MenuItems>"
		End Function

		Private Function CreateNew() As Object
			Dim kq As Object = False
			Dim mName As String = Me.txtName.Text
			Dim flag As Boolean = mName.Length > 0
			If flag Then
				Dim flag2 As Boolean = MyProject.Computer.FileSystem.DirectoryExists(mName)
				If flag2 Then
					Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c, " & ChrW(273) & ChrW(7863) & "t tên khác", MsgBoxStyle.OkOnly, Nothing)
				Else
					Try
						MyProject.Computer.FileSystem.CreateDirectory(mName)
						MyProject.Computer.FileSystem.WriteAllText(mName + "\NoAct.xml", Me.GetNoActStr(), False)
						MyProject.Computer.FileSystem.WriteAllText(mName + "\MyMenu.xml", Me.GetMyMenuStr(mName), False)
						kq = True
					Catch expr_AC As Exception
						ProjectData.SetProjectError(expr_AC)
						ProjectData.ClearProjectError()
					End Try
				End If
			Else
				Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c, " & ChrW(273) & ChrW(7863) & "t tên khác", MsgBoxStyle.OkOnly, Nothing)
			End If
			Return kq
		End Function

		Private Function OpenSB() As Object
			Dim kq As Object = False
			Dim mName As String = Me.txtName.Text
			Dim flag As Boolean = mName.Length > 0
			If flag Then
				Dim flag2 As Boolean = MyProject.Computer.FileSystem.DirectoryExists(mName)
				If flag2 Then
					kq = True
				Else
					Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c", MsgBoxStyle.OkOnly, Nothing)
			End If
			Return kq
		End Function

		Private Sub txtName_DoubleClick(sender As Object, e As EventArgs)
			Dim f As dlgGetName = New dlgGetName()
			f.txtNameType.Text = "Dir"
			Dim flag As Boolean = f.ShowDialog(Me) = DialogResult.OK
			If flag Then
				Me.txtName.Text = f.txtName.Text
			End If
		End Sub
	End Class
End Namespace
