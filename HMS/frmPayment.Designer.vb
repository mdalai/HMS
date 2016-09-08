<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
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
        Me.btnPaySure = New System.Windows.Forms.Button()
        Me.btn_print_review = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPriceTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView_feeitem = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFeeitem_total = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotal_all = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(631, 129)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(231, 15)
        Me.txtID.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(542, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 26
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
        Me.DataGridView_check.Location = New System.Drawing.Point(178, 159)
        Me.DataGridView_check.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView_check.MultiSelect = False
        Me.DataGridView_check.Name = "DataGridView_check"
        Me.DataGridView_check.ReadOnly = True
        Me.DataGridView_check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_check.Size = New System.Drawing.Size(707, 169)
        Me.DataGridView_check.TabIndex = 25
        '
        'txtDatetime
        '
        Me.txtDatetime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDatetime.Enabled = False
        Me.txtDatetime.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatetime.Location = New System.Drawing.Point(631, 98)
        Me.txtDatetime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDatetime.Name = "txtDatetime"
        Me.txtDatetime.Size = New System.Drawing.Size(231, 15)
        Me.txtDatetime.TabIndex = 24
        '
        'txtDoctor
        '
        Me.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDoctor.Enabled = False
        Me.txtDoctor.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(631, 69)
        Me.txtDoctor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(231, 15)
        Me.txtDoctor.TabIndex = 23
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(259, 130)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(206, 15)
        Me.txtAge.TabIndex = 22
        '
        'txtPID
        '
        Me.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPID.Enabled = False
        Me.txtPID.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPID.Location = New System.Drawing.Point(259, 89)
        Me.txtPID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(206, 15)
        Me.txtPID.TabIndex = 21
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(260, 69)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(205, 15)
        Me.txtName.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(542, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "开处方时间:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(542, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "开处方医生:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(202, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "身份证:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(202, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "年龄:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(414, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "桑根达来镇中心卫生院"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "姓名:"
        '
        'btnPaySure
        '
        Me.btnPaySure.Location = New System.Drawing.Point(669, 431)
        Me.btnPaySure.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPaySure.Name = "btnPaySure"
        Me.btnPaySure.Size = New System.Drawing.Size(105, 28)
        Me.btnPaySure.TabIndex = 28
        Me.btnPaySure.Text = "确认收费"
        Me.btnPaySure.UseVisualStyleBackColor = True
        '
        'btn_print_review
        '
        Me.btn_print_review.Location = New System.Drawing.Point(780, 431)
        Me.btn_print_review.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_print_review.Name = "btn_print_review"
        Me.btn_print_review.Size = New System.Drawing.Size(105, 28)
        Me.btn_print_review.TabIndex = 29
        Me.btn_print_review.Text = "Print Review"
        Me.btn_print_review.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(630, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "医药费:"
        '
        'txtPriceTotal
        '
        Me.txtPriceTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPriceTotal.Enabled = False
        Me.txtPriceTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPriceTotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtPriceTotal.Location = New System.Drawing.Point(702, 338)
        Me.txtPriceTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPriceTotal.Name = "txtPriceTotal"
        Me.txtPriceTotal.Size = New System.Drawing.Size(68, 16)
        Me.txtPriceTotal.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(777, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "(元)"
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
        Me.DataGridView_feeitem.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_feeitem.Location = New System.Drawing.Point(205, 338)
        Me.DataGridView_feeitem.Name = "DataGridView_feeitem"
        Me.DataGridView_feeitem.ReadOnly = True
        Me.DataGridView_feeitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_feeitem.Size = New System.Drawing.Size(306, 134)
        Me.DataGridView_feeitem.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(777, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "(元)"
        '
        'txtFeeitem_total
        '
        Me.txtFeeitem_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeeitem_total.Enabled = False
        Me.txtFeeitem_total.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtFeeitem_total.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtFeeitem_total.Location = New System.Drawing.Point(702, 362)
        Me.txtFeeitem_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFeeitem_total.Name = "txtFeeitem_total"
        Me.txtFeeitem_total.Size = New System.Drawing.Size(68, 16)
        Me.txtFeeitem_total.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(630, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "其他项:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(777, 387)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "(元)"
        '
        'txtTotal_all
        '
        Me.txtTotal_all.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal_all.Enabled = False
        Me.txtTotal_all.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTotal_all.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTotal_all.Location = New System.Drawing.Point(702, 388)
        Me.txtTotal_all.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal_all.Name = "txtTotal_all"
        Me.txtTotal_all.Size = New System.Drawing.Size(68, 16)
        Me.txtTotal_all.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(630, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 19)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "总金额:"
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSex.Enabled = False
        Me.txtSex.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(259, 109)
        Me.txtSex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(206, 15)
        Me.txtSex.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(202, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "性别:"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1029, 489)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotal_all)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFeeitem_total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView_feeitem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPriceTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_print_review)
        Me.Controls.Add(Me.btnPaySure)
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
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPayment"
        Me.Text = "收费界面"
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
    Friend WithEvents btnPaySure As Button
    Friend WithEvents btn_print_review As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPriceTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView_feeitem As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFeeitem_total As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotal_all As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label14 As Label
End Class
