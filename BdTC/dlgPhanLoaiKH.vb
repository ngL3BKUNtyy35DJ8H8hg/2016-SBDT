Imports System.Windows.Forms

Public Class dlgPhanLoaiKH

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private myKHConnStr As String
    Private Sub dlgPhanLoaiKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Phân nhóm Ký hiệu"

        'myKHConnStr = "File Name = KHdata.udl"
        myKHConnStr = "File Name = " & myCacKyHieuUDL

        With Me.DMucCtrl1
            .ConnStr = myKHConnStr
            .TableName = "tblLoaiKH"
            .MaFieldName = "MaLoaiKH"
            .TenFieldName = "TenLoaiKH"
            .CuoiFieldName = "Cuoi"
            .TenCay = "Các nhóm"
            '.SuaKhacText = "Thông tin khác"
            '.MucLen = myLoaiHinhHDMucLen
            '.FirstMa = myFirstMa

            .LoadDanhMuc()
        End With
    End Sub
End Class
