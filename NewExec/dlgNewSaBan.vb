Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports SaBan.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SaBan
	<DesignerGenerated()>
	Public Class dlgNewSaBan
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

		<AccessedThroughProperty("txtName")>
		Private _txtName As TextBox

		<AccessedThroughProperty("txtMode")>
		Private _txtMode As TextBox

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

		Friend Overridable Property txtName() As TextBox
			Get
				Return Me._txtName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtName_DoubleClick
				If Me._txtName IsNot Nothing Then
					RemoveHandler Me._txtName.DoubleClick, value2
				End If
				Me._txtName = value
				If Me._txtName IsNot Nothing Then
					AddHandler Me._txtName.DoubleClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property txtMode() As TextBox
			Get
				Return Me._txtMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMode = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgNewSaBan_Load
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
			Dim arg_E9_0 As Control = Me.TableLayoutPanel1
			Dim location As Point = New Point(139, 65)
			arg_E9_0.Location = location
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
			Dim arg_13B_0 As Control = Me.TableLayoutPanel1
			Dim size As Size = New Size(146, 29)
			arg_13B_0.Size = size
			Me.TableLayoutPanel1.TabIndex = 0
			Me.OK_Button.Anchor = AnchorStyles.None
			Dim arg_168_0 As Control = Me.OK_Button
			location = New Point(3, 3)
			arg_168_0.Location = location
			Me.OK_Button.Name = "OK_Button"
			Dim arg_18F_0 As Control = Me.OK_Button
			size = New Size(67, 23)
			arg_18F_0.Size = size
			Me.OK_Button.TabIndex = 0
			Me.OK_Button.Text = "OK"
			Me.Cancel_Button.Anchor = AnchorStyles.None
			Me.Cancel_Button.DialogResult = DialogResult.Cancel
			Dim arg_1D9_0 As Control = Me.Cancel_Button
			location = New Point(76, 3)
			arg_1D9_0.Location = location
			Me.Cancel_Button.Name = "Cancel_Button"
			Dim arg_200_0 As Control = Me.Cancel_Button
			size = New Size(67, 23)
			arg_200_0.Size = size
			Me.Cancel_Button.TabIndex = 1
			Me.Cancel_Button.Text = "Cancel"
			Me.Label1.AutoSize = True
			Dim arg_23F_0 As Control = Me.Label1
			location = New Point(12, 27)
			arg_23F_0.Location = location
			Me.Label1.Name = "Label1"
			Dim arg_266_0 As Control = Me.Label1
			size = New Size(71, 13)
			arg_266_0.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Tên th" & ChrW(432) & " m" & ChrW(7909) & "c:"
			Dim arg_299_0 As Control = Me.txtName
			location = New Point(89, 24)
			arg_299_0.Location = location
			Me.txtName.Name = "txtName"
			Dim arg_2C3_0 As Control = Me.txtName
			size = New Size(193, 21)
			arg_2C3_0.Size = size
			Me.txtName.TabIndex = 2
			Dim arg_2E6_0 As Control = Me.txtMode
			location = New Point(15, 67)
			arg_2E6_0.Location = location
			Me.txtMode.Name = "txtMode"
			Dim arg_30D_0 As Control = Me.txtMode
			size = New Size(68, 21)
			arg_30D_0.Size = size
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
			If Operators.CompareString(Me.txtMode.Text, "New", False) = 0 Then
				If Me.CreateNew() Then
					modSaBan.mySaBanDir = Me.txtName.Text
					modSaBan.DienTap2File(modSaBan.myLastSaBan)
					Me.DialogResult = DialogResult.OK
					Me.Close()
				Else
					Interaction.MsgBox("Truc trac", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else If Conversions.ToBoolean(Me.OpenSB()) Then
				modSaBan.mySaBanDir = Me.txtName.Text
				modSaBan.DienTap2File(modSaBan.myLastSaBan)
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Interaction.MsgBox("Truc trac", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub dlgNewSaBan_Load(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.txtMode.Text, "New", False) = 0 Then
				Me.Text = "K" & ChrW(7883) & "ch b" & ChrW(7843) & "n m" & ChrW(7899) & "i"
			Else
				Me.Text = "M" & ChrW(7903) & " K" & ChrW(7883) & "ch b" & ChrW(7843) & "n"
			End If
		End Sub

		Private Function GetNoActStr() As String
			Return "<Actions>" & vbCrLf & "</Actions>"
		End Function

		Private Function GetMyMenuStr(pDirName As String) As String
			Dim str As String = "<Mnu>"
			str += vbCrLf & "<MnuItem Name=""Hanh dong 1"" PosX=""10"" PosY=""60"" Width=""80"" Height=""18"">"
			str = str + vbCrLf & "<Script ScrptFile=""" + pDirName + "\Script1.xml"" Start=""0"">  </Script>"
			str += vbCrLf & "</MnuItem>"
			str += vbCrLf & "<MnuItem Name=""Hanh dong 2"" PosX=""10"" PosY=""90"" Width=""80"" Height=""18"">"
			str = str + vbCrLf & "<Script ScrptFile=""" + pDirName + "\Script2.xml"" Start=""0"">  </Script>"
			str += vbCrLf & "</MnuItem>"
			str += vbCrLf & "<MnuItem Name=""Phoi hop"" PosX=""10"" PosY=""120"" Width=""80"" Height=""18"">"
			str = str + vbCrLf & "<Script ID=""1"" ScrptFile=""" + pDirName + "\Script1.xml"" Start=""0"">  </Script>"
			str = str + vbCrLf & "<Script ScrptFile=""" + pDirName + "\Script2.xml"" Start=""Stop(1)+2"">  </Script>"
			str += vbCrLf & "</MnuItem>"
			Return str + vbCrLf & "</Mnu>"
		End Function

		Private Function CreateNew() As Boolean
			Dim value As Object = False
			Dim text As String = Me.txtName.Text
			If text.Length > 0 Then
				If MyProject.Computer.FileSystem.DirectoryExists(text) Then
					Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c, " & ChrW(273) & ChrW(7863) & "t tên khác", MsgBoxStyle.OkOnly, Nothing)
				Else
					Try
						MyProject.Computer.FileSystem.CreateDirectory(text)
						MyProject.Computer.FileSystem.WriteAllText(text + "\Script1.xml", Me.GetNoActStr(), False)
						MyProject.Computer.FileSystem.WriteAllText(text + "\Script2.xml", Me.GetNoActStr(), False)
						MyProject.Computer.FileSystem.WriteAllText(text + "\" + modSaBan.MyMnuName, Me.GetMyMenuStr(text), False)
						value = True
					Catch expr_C5 As Exception
						ProjectData.SetProjectError(expr_C5)
						ProjectData.ClearProjectError()
					End Try
				End If
			Else
				Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c, " & ChrW(273) & ChrW(7863) & "t tên khác", MsgBoxStyle.OkOnly, Nothing)
			End If
			Return Conversions.ToBoolean(value)
		End Function

		Private Function OpenSB() As Object
			Dim result As Object = False
			Dim text As String = Me.txtName.Text
			If text.Length > 0 Then
				If MyProject.Computer.FileSystem.DirectoryExists(text) Then
					result = True
				Else
					Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Không " & ChrW(273) & ChrW(432) & ChrW(7907) & "c", MsgBoxStyle.OkOnly, Nothing)
			End If
			Return result
		End Function

		Private Sub txtName_DoubleClick(sender As Object, e As EventArgs)
			Dim dlgGetName As dlgGetName = New dlgGetName()
			dlgGetName.txtNameType.Text = "Dir"
			If dlgGetName.ShowDialog(Me) = DialogResult.OK Then
				Me.txtName.Text = dlgGetName.txtName.Text
			End If
		End Sub
	End Class
End Namespace
