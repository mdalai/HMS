<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicineGive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView_check = New System.Windows.Forms.DataGridView()
        Me.txtDatetime = New System.Windows.Forms.TextBox()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm_medicine = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_giver = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotal_all = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFeeitem_total = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView_feeitem = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPriceTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(517, 105)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(182, 13)
        Me.txtID.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(441, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "挂号ID:"
        '
        'DataGridView_check
        '
        Me.DataGridView_check.AllowUserToAddRows = False
        Me.DataGridView_check.AllowUserToDeleteRows = False
        Me.DataGridView_check.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_check.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_check.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_check.Location = New System.Drawing.Point(26, 129)
        Me.DataGridView_check.MultiSelect = False
        Me.DataGridView_check.Name = "DataGridView_check"
        Me.DataGridView_check.ReadOnly = True
        Me.DataGridView_check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_check.Size = New System.Drawing.Size(876, 323)
        Me.DataGridView_check.TabIndex = 61
        '
        'txtDatetime
        '
        Me.txtDatetime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDatetime.Enabled = False
        Me.txtDatetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatetime.Location = New System.Drawing.Point(517, 80)
        Me.txtDatetime.Name = "txtDatetime"
        Me.txtDatetime.Size = New System.Drawing.Size(182, 13)
        Me.txtDatetime.TabIndex = 60
        '
        'txtDoctor
        '
        Me.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDoctor.Enabled = False
        Me.txtDoctor.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(517, 56)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(182, 15)
        Me.txtDoctor.TabIndex = 59
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(176, 107)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(166, 15)
        Me.txtAge.TabIndex = 58
        '
        'txtPID
        '
        Me.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPID.Enabled = False
        Me.txtPID.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPID.Location = New System.Drawing.Point(176, 66)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(166, 15)
        Me.txtPID.TabIndex = 57
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(177, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(165, 15)
        Me.txtName.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(441, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "交费时间:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "开处方医生:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "身份证:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "年龄:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "桑根达来镇中心卫生院"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "姓名:"
        '
        'btnConfirm_medicine
        '
        Me.btnConfirm_medicine.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnConfirm_medicine.Location = New System.Drawing.Point(692, 570)
        Me.btnConfirm_medicine.Name = "btnConfirm_medicine"
        Me.btnConfirm_medicine.Size = New System.Drawing.Size(90, 23)
        Me.btnConfirm_medicine.TabIndex = 67
        Me.btnConfirm_medicine.Text = "确认发药"
        Me.btnConfirm_medicine.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(481, 568)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 19)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "发药者:"
        '
        'cmb_giver
        '
        Me.cmb_giver.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_giver.FormattingEnabled = True
        Me.cmb_giver.Location = New System.Drawing.Point(539, 568)
        Me.cmb_giver.Name = "cmb_giver"
        Me.cmb_giver.Size = New System.Drawing.Size(133, 25)
        Me.cmb_giver.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(689, 508)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 15)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "(元)"
        '
        'txtTotal_all
        '
        Me.txtTotal_all.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal_all.Enabled = False
        Me.txtTotal_all.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTotal_all.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTotal_all.Location = New System.Drawing.Point(614, 509)
        Me.txtTotal_all.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal_all.Name = "txtTotal_all"
        Me.txtTotal_all.Size = New System.Drawing.Size(68, 16)
        Me.txtTotal_all.TabIndex = 78
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(542, 509)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 19)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "总金额:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(689, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "(元)"
        '
        'txtFeeitem_total
        '
        Me.txtFeeitem_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeeitem_total.Enabled = False
        Me.txtFeeitem_total.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtFeeitem_total.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtFeeitem_total.Location = New System.Drawing.Point(614, 483)
        Me.txtFeeitem_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFeeitem_total.Name = "txtFeeitem_total"
        Me.txtFeeitem_total.Size = New System.Drawing.Size(68, 16)
        Me.txtFeeitem_total.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(542, 483)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "其他项:"
        '
        'DataGridView_feeitem
        '
        Me.DataGridView_feeitem.AllowUserToAddRows = False
        Me.DataGridView_feeitem.AllowUserToDeleteRows = False
        Me.DataGridView_feeitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_feeitem.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_feeitem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_feeitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_feeitem.Enabled = False
        Me.DataGridView_feeitem.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_feeitem.Location = New System.Drawing.Point(93, 459)
        Me.DataGridView_feeitem.Name = "DataGridView_feeitem"
        Me.DataGridView_feeitem.ReadOnly = True
        Me.DataGridView_feeitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_feeitem.Size = New System.Drawing.Size(329, 134)
        Me.DataGridView_feeitem.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(689, 458)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "(元)"
        '
        'txtPriceTotal
        '
        Me.txtPriceTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPriceTotal.Enabled = False
        Me.txtPriceTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPriceTotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtPriceTotal.Location = New System.Drawing.Point(614, 459)
        Me.txtPriceTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPriceTotal.Name = "txtPriceTotal"
        Me.txtPriceTotal.Size = New System.Drawing.Size(68, 16)
        Me.txtPriceTotal.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(542, 459)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 19)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "医药费:"
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSex.Enabled = False
        Me.txtSex.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(176, 87)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(166, 15)
        Me.txtSex.TabIndex = 81
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(127, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "性别:"
        '
        'frmMedicineGive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(938, 637)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotal_all)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFeeitem_total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView_feeitem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPriceTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmb_giver)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnConfirm_medicine)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView_check)
        Me.Controls.Add(Me.txtDatetime)
        Me.Controls.Add(Me.txtDoctor)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtPID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMedicineGive"
        Me.Text = "发药确认"
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView_check As DataGridView
    Friend WithEvents txtDatetime As TextBox
    Friend WithEvents txtDoctor As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirm_medicine As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_giver As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotal_all As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFeeitem_total As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView_feeitem As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPriceTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label15 As Label
End Class
