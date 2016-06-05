Imports System.Windows.Forms

Public Class dlgNewSaBan

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.txtMode.Text = "New" Then
            If CreateNew() Then
                mySaBanDir = Me.txtName.Text
                My.Computer.FileSystem.WriteAllText(mySaBanDefFileName, mySaBanDir, False)

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Truc trac")
            End If
        Else
            If OpenSB() Then
                mySaBanDir = Me.txtName.Text
                My.Computer.FileSystem.WriteAllText(mySaBanDefFileName, mySaBanDir, False)

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Truc trac")
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgNewSaBan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.txtMode.Text = "New" Then
            Me.Text = "Sa bàn mới"
        Else
            Me.Text = "Mở Sa bàn"
        End If
    End Sub

    Private Function GetNoActStr() As String
        Return "<Actions>" & vbCrLf & "</Actions>"
    End Function

    Private Function GetMyMenuStr(ByVal pDirName As String) As String
        Dim kq As String = "<MenuItems>"
        kq &= vbCrLf & _
        "<MenuItem Name="""" PosX=""0"" PosY=""0"" Width=""0"" Height=""0"" ActFileName=""" & _
        pDirName & "\NoAct.xml"">1</MenuItem>"

        kq &= vbCrLf & "</MenuItems>"
        Return kq
    End Function

    Private Function CreateNew()
        Dim kq = False
        Dim mName As String = Me.txtName.Text
        If mName.Length > 0 Then
            If My.Computer.FileSystem.DirectoryExists(mName) Then
                MsgBox("Không được, đặt tên khác")
            Else
                Try
                    My.Computer.FileSystem.CreateDirectory(mName)
                    'My.Computer.FileSystem.CopyFile("NoAct.xml", mName & "\NoAct.xml")
                    'My.Computer.FileSystem.CopyFile("MyMenu.xml", mName & "\MyMenu.xml")
                    My.Computer.FileSystem.WriteAllText(mName & "\NoAct.xml", GetNoActStr(), False)
                    My.Computer.FileSystem.WriteAllText(mName & "\MyMenu.xml", GetMyMenuStr(mName), False)
                    kq = True
                Catch ex As Exception
                End Try
            End If
        Else
            MsgBox("Không được, đặt tên khác")
        End If
        Return kq
    End Function

    Private Function OpenSB()
        Dim kq = False
        Dim mName As String = Me.txtName.Text
        If mName.Length > 0 Then
            If My.Computer.FileSystem.DirectoryExists(mName) Then
                kq = True
            Else
                MsgBox("Không được")
            End If
        Else
            MsgBox("Không được")
        End If
        Return kq
    End Function

    Private Sub txtName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.DoubleClick
        Dim f As New dlgGetName
        f.txtNameType.Text = "Dir"
        If f.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.txtName.Text = f.txtName.Text
        End If
    End Sub
End Class
