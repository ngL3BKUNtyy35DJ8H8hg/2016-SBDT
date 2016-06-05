<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPhanLoaiKH
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DMucCtrl1 = New DanhMuc.DMucCtrl
        Me.SuspendLayout()
        '
        'DMucCtrl1
        '
        Me.DMucCtrl1.BxFieldName = ""
        Me.DMucCtrl1.ConnStr = ""
        Me.DMucCtrl1.CuoiFieldName = ""
        Me.DMucCtrl1.DMIDFieldName = ""
        Me.DMucCtrl1.DMIDValue = 0
        Me.DMucCtrl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DMucCtrl1.FilterFieldName = ""
        Me.DMucCtrl1.FilterValue = 0
        Me.DMucCtrl1.Location = New System.Drawing.Point(0, 0)
        Me.DMucCtrl1.MaFieldName = ""
        Me.DMucCtrl1.MucLen = 2
        Me.DMucCtrl1.Name = "DMucCtrl1"
        Me.DMucCtrl1.Password = ""
        Me.DMucCtrl1.Size = New System.Drawing.Size(583, 315)
        Me.DMucCtrl1.TabIndex = 0
        Me.DMucCtrl1.TableName = ""
        Me.DMucCtrl1.TenCay = ""
        Me.DMucCtrl1.TenFieldName = ""
        Me.DMucCtrl1.UserID = ""
        '
        'dlgPhanLoaiKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 315)
        Me.Controls.Add(Me.DMucCtrl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPhanLoaiKH"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlgPhanLoaiKH"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DMucCtrl1 As DanhMuc.DMucCtrl

End Class
