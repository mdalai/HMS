<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckPrescription))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.txtDatetime = New System.Windows.Forms.TextBox()
        Me.DataGridView_check = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label_presciptionRemark = New System.Windows.Forms.Label()
        Me.btn_print_review = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DataGridView_feeitem = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_feeitem_NO = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFeeitem_total = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPriceTotal = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "姓名:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "桑根达来镇中心卫生院 处方"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "年龄:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "身份证:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "开处方医生:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "开处方时间:"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(103, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(165, 15)
        Me.txtName.TabIndex = 6
        '
        'txtPID
        '
        Me.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPID.Enabled = False
        Me.txtPID.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPID.Location = New System.Drawing.Point(102, 70)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(166, 15)
        Me.txtPID.TabIndex = 7
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(102, 111)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(166, 15)
        Me.txtAge.TabIndex = 8
        '
        'txtDoctor
        '
        Me.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDoctor.Enabled = False
        Me.txtDoctor.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(432, 53)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(158, 15)
        Me.txtDoctor.TabIndex = 9
        '
        'txtDatetime
        '
        Me.txtDatetime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDatetime.Enabled = False
        Me.txtDatetime.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatetime.Location = New System.Drawing.Point(432, 77)
        Me.txtDatetime.Name = "txtDatetime"
        Me.txtDatetime.Size = New System.Drawing.Size(158, 15)
        Me.txtDatetime.TabIndex = 10
        '
        'DataGridView_check
        '
        Me.DataGridView_check.AllowUserToAddRows = False
        Me.DataGridView_check.AllowUserToDeleteRows = False
        Me.DataGridView_check.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_check.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_check.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_check.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_check.Location = New System.Drawing.Point(12, 132)
        Me.DataGridView_check.Name = "DataGridView_check"
        Me.DataGridView_check.ReadOnly = True
        Me.DataGridView_check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_check.Size = New System.Drawing.Size(843, 239)
        Me.DataGridView_check.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(356, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "挂号ID:"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(432, 102)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(158, 15)
        Me.txtID.TabIndex = 13
        '
        'txtRemark
        '
        Me.txtRemark.BackColor = System.Drawing.Color.White
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemark.Enabled = False
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.ForeColor = System.Drawing.Color.Black
        Me.txtRemark.Location = New System.Drawing.Point(528, 507)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(264, 30)
        Me.txtRemark.TabIndex = 14
        '
        'Label_presciptionRemark
        '
        Me.Label_presciptionRemark.AutoSize = True
        Me.Label_presciptionRemark.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_presciptionRemark.Location = New System.Drawing.Point(470, 507)
        Me.Label_presciptionRemark.Name = "Label_presciptionRemark"
        Me.Label_presciptionRemark.Size = New System.Drawing.Size(59, 17)
        Me.Label_presciptionRemark.TabIndex = 15
        Me.Label_presciptionRemark.Text = "处方描述:"
        '
        'btn_print_review
        '
        Me.btn_print_review.Location = New System.Drawing.Point(595, 568)
        Me.btn_print_review.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_print_review.Name = "btn_print_review"
        Me.btn_print_review.Size = New System.Drawing.Size(105, 28)
        Me.btn_print_review.TabIndex = 31
        Me.btn_print_review.Text = "Print Review"
        Me.btn_print_review.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(473, 568)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 28)
        Me.btnPrint.TabIndex = 30
        Me.btnPrint.Text = "打印"
        Me.btnPrint.UseVisualStyleBackColor = True
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
        'DataGridView_feeitem
        '
        Me.DataGridView_feeitem.AllowUserToAddRows = False
        Me.DataGridView_feeitem.AllowUserToDeleteRows = False
        Me.DataGridView_feeitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_feeitem.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_feeitem.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_feeitem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_feeitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_feeitem.Enabled = False
        Me.DataGridView_feeitem.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_feeitem.Location = New System.Drawing.Point(56, 398)
        Me.DataGridView_feeitem.Name = "DataGridView_feeitem"
        Me.DataGridView_feeitem.ReadOnly = True
        Me.DataGridView_feeitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_feeitem.Size = New System.Drawing.Size(256, 163)
        Me.DataGridView_feeitem.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "其他项:"
        '
        'Label_feeitem_NO
        '
        Me.Label_feeitem_NO.AutoSize = True
        Me.Label_feeitem_NO.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_feeitem_NO.Location = New System.Drawing.Point(83, 342)
        Me.Label_feeitem_NO.Name = "Label_feeitem_NO"
        Me.Label_feeitem_NO.Size = New System.Drawing.Size(0, 19)
        Me.Label_feeitem_NO.TabIndex = 34
        Me.Label_feeitem_NO.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(575, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "药品总金额:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(136, 568)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "其他项总金额:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(298, 570)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 15)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "(元)"
        '
        'txtFeeitem_total
        '
        Me.txtFeeitem_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeeitem_total.Enabled = False
        Me.txtFeeitem_total.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtFeeitem_total.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtFeeitem_total.Location = New System.Drawing.Point(224, 568)
        Me.txtFeeitem_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFeeitem_total.Name = "txtFeeitem_total"
        Me.txtFeeitem_total.Size = New System.Drawing.Size(68, 16)
        Me.txtFeeitem_total.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(727, 377)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "(元)"
        '
        'txtPriceTotal
        '
        Me.txtPriceTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPriceTotal.Enabled = False
        Me.txtPriceTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPriceTotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtPriceTotal.Location = New System.Drawing.Point(652, 378)
        Me.txtPriceTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPriceTotal.Name = "txtPriceTotal"
        Me.txtPriceTotal.Size = New System.Drawing.Size(68, 16)
        Me.txtPriceTotal.TabIndex = 37
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSex.Enabled = False
        Me.txtSex.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(102, 91)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(166, 15)
        Me.txtSex.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(53, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 15)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "性别:"
        '
        'frmCheckPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(867, 621)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFeeitem_total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPriceTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_feeitem_NO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView_feeitem)
        Me.Controls.Add(Me.btn_print_review)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label_presciptionRemark)
        Me.Controls.Add(Me.txtRemark)
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
        Me.Name = "frmCheckPrescription"
        Me.Text = "查看处方"
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtDoctor As TextBox
    Friend WithEvents txtDatetime As TextBox
    Friend WithEvents DataGridView_check As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label_presciptionRemark As Label
    Friend WithEvents btn_print_review As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DataGridView_feeitem As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label_feeitem_NO As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFeeitem_total As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPriceTotal As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label13 As Label
End Class
