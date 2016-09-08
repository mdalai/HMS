<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashier
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashier))
        Me.TabControl_cashier = New System.Windows.Forms.TabControl()
        Me.TabPage_guahao = New System.Windows.Forms.TabPage()
        Me.dataGridView_guahao = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCashier_sex = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnGuahao = New System.Windows.Forms.Button()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage_shoufei = New System.Windows.Forms.TabPage()
        Me.btnRefresh_pay = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.DataGridView_prescription = New System.Windows.Forms.DataGridView()
        Me.TabPage_checkPay = New System.Windows.Forms.TabPage()
        Me.btnRefresh_paycheck = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.DataGridView_paid = New System.Windows.Forms.DataGridView()
        Me.TabPage_delGuahao = New System.Windows.Forms.TabPage()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.DataGridView_delGuahao = New System.Windows.Forms.DataGridView()
        Me.TabPage_refund = New System.Windows.Forms.TabPage()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnDel_row_feeitem = New System.Windows.Forms.Button()
        Me.btn_delRow_medi = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_price_totalAll_new = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRefund_total = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DataGridView_feeitem_refund = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_medi_refund = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuahao_search = New System.Windows.Forms.Button()
        Me.txtSearch_GuahaoID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotal_all = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFeeitem_total = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView_feeitem = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPriceTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_print_review = New System.Windows.Forms.Button()
        Me.btnRefund_sure = New System.Windows.Forms.Button()
        Me.txtRefund_GID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView_check = New System.Windows.Forms.DataGridView()
        Me.txtRefund_datetime = New System.Windows.Forms.TextBox()
        Me.txtRefund_doctor = New System.Windows.Forms.TextBox()
        Me.txtRefund_age = New System.Windows.Forms.TextBox()
        Me.txtRefund_PID = New System.Windows.Forms.TextBox()
        Me.txtRefund_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtGID_search = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnGID_search = New System.Windows.Forms.Button()
        Me.TabControl_cashier.SuspendLayout()
        Me.TabPage_guahao.SuspendLayout()
        CType(Me.dataGridView_guahao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_shoufei.SuspendLayout()
        CType(Me.DataGridView_prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_checkPay.SuspendLayout()
        CType(Me.DataGridView_paid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_delGuahao.SuspendLayout()
        CType(Me.DataGridView_delGuahao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_refund.SuspendLayout()
        CType(Me.DataGridView_feeitem_refund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_medi_refund, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_cashier
        '
        Me.TabControl_cashier.Controls.Add(Me.TabPage_guahao)
        Me.TabControl_cashier.Controls.Add(Me.TabPage_shoufei)
        Me.TabControl_cashier.Controls.Add(Me.TabPage_checkPay)
        Me.TabControl_cashier.Controls.Add(Me.TabPage_delGuahao)
        Me.TabControl_cashier.Controls.Add(Me.TabPage_refund)
        Me.TabControl_cashier.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl_cashier.ItemSize = New System.Drawing.Size(100, 24)
        Me.TabControl_cashier.Location = New System.Drawing.Point(2, 12)
        Me.TabControl_cashier.Name = "TabControl_cashier"
        Me.TabControl_cashier.SelectedIndex = 0
        Me.TabControl_cashier.Size = New System.Drawing.Size(1020, 630)
        Me.TabControl_cashier.TabIndex = 0
        '
        'TabPage_guahao
        '
        Me.TabPage_guahao.Controls.Add(Me.dataGridView_guahao)
        Me.TabPage_guahao.Controls.Add(Me.GroupBox1)
        Me.TabPage_guahao.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_guahao.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_guahao.Name = "TabPage_guahao"
        Me.TabPage_guahao.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_guahao.Size = New System.Drawing.Size(1012, 598)
        Me.TabPage_guahao.TabIndex = 0
        Me.TabPage_guahao.Text = "挂号"
        Me.TabPage_guahao.UseVisualStyleBackColor = True
        '
        'dataGridView_guahao
        '
        Me.dataGridView_guahao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridView_guahao.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dataGridView_guahao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView_guahao.GridColor = System.Drawing.SystemColors.Window
        Me.dataGridView_guahao.Location = New System.Drawing.Point(363, 26)
        Me.dataGridView_guahao.MultiSelect = False
        Me.dataGridView_guahao.Name = "dataGridView_guahao"
        Me.dataGridView_guahao.ReadOnly = True
        Me.dataGridView_guahao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView_guahao.Size = New System.Drawing.Size(639, 560)
        Me.dataGridView_guahao.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCashier_sex)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.btnGuahao)
        Me.GroupBox1.Controls.Add(Me.cmbDoctor)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtPID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 362)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "请输入挂号信息"
        '
        'cmbCashier_sex
        '
        Me.cmbCashier_sex.FormattingEnabled = True
        Me.cmbCashier_sex.Items.AddRange(New Object() {"女", "男"})
        Me.cmbCashier_sex.Location = New System.Drawing.Point(122, 112)
        Me.cmbCashier_sex.Name = "cmbCashier_sex"
        Me.cmbCashier_sex.Size = New System.Drawing.Size(183, 28)
        Me.cmbCashier_sex.TabIndex = 12
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 19)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "性别:"
        '
        'btnGuahao
        '
        Me.btnGuahao.Location = New System.Drawing.Point(122, 273)
        Me.btnGuahao.Name = "btnGuahao"
        Me.btnGuahao.Size = New System.Drawing.Size(95, 31)
        Me.btnGuahao.TabIndex = 10
        Me.btnGuahao.Text = "挂号"
        Me.btnGuahao.UseVisualStyleBackColor = True
        '
        'cmbDoctor
        '
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(122, 185)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(183, 28)
        Me.cmbDoctor.TabIndex = 9
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(122, 223)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(183, 27)
        Me.txtContact.TabIndex = 8
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(122, 149)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(183, 27)
        Me.txtAge.TabIndex = 7
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(122, 77)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(183, 27)
        Me.txtPID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(122, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(183, 27)
        Me.txtName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "病人联系方式:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "挂号医生:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "年龄:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "身份证:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "病人姓名:"
        '
        'TabPage_shoufei
        '
        Me.TabPage_shoufei.Controls.Add(Me.btnRefresh_pay)
        Me.TabPage_shoufei.Controls.Add(Me.btnPay)
        Me.TabPage_shoufei.Controls.Add(Me.DataGridView_prescription)
        Me.TabPage_shoufei.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_shoufei.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_shoufei.Name = "TabPage_shoufei"
        Me.TabPage_shoufei.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_shoufei.Size = New System.Drawing.Size(1012, 598)
        Me.TabPage_shoufei.TabIndex = 1
        Me.TabPage_shoufei.Text = "收费"
        Me.TabPage_shoufei.UseVisualStyleBackColor = True
        '
        'btnRefresh_pay
        '
        Me.btnRefresh_pay.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_pay.Location = New System.Drawing.Point(17, 10)
        Me.btnRefresh_pay.Name = "btnRefresh_pay"
        Me.btnRefresh_pay.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_pay.TabIndex = 8
        Me.btnRefresh_pay.Text = ">> 刷新 >>"
        Me.btnRefresh_pay.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(17, 543)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(100, 27)
        Me.btnPay.TabIndex = 7
        Me.btnPay.Text = ">> 收费 >>"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'DataGridView_prescription
        '
        Me.DataGridView_prescription.AllowUserToAddRows = False
        Me.DataGridView_prescription.AllowUserToDeleteRows = False
        Me.DataGridView_prescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_prescription.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_prescription.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_prescription.Location = New System.Drawing.Point(17, 43)
        Me.DataGridView_prescription.MultiSelect = False
        Me.DataGridView_prescription.Name = "DataGridView_prescription"
        Me.DataGridView_prescription.ReadOnly = True
        Me.DataGridView_prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_prescription.Size = New System.Drawing.Size(968, 494)
        Me.DataGridView_prescription.TabIndex = 6
        '
        'TabPage_checkPay
        '
        Me.TabPage_checkPay.Controls.Add(Me.txtGID_search)
        Me.TabPage_checkPay.Controls.Add(Me.Label26)
        Me.TabPage_checkPay.Controls.Add(Me.btnGID_search)
        Me.TabPage_checkPay.Controls.Add(Me.btnRefresh_paycheck)
        Me.TabPage_checkPay.Controls.Add(Me.btnCheck)
        Me.TabPage_checkPay.Controls.Add(Me.DataGridView_paid)
        Me.TabPage_checkPay.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_checkPay.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_checkPay.Name = "TabPage_checkPay"
        Me.TabPage_checkPay.Size = New System.Drawing.Size(1012, 598)
        Me.TabPage_checkPay.TabIndex = 3
        Me.TabPage_checkPay.Text = "收费查看"
        Me.TabPage_checkPay.UseVisualStyleBackColor = True
        '
        'btnRefresh_paycheck
        '
        Me.btnRefresh_paycheck.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_paycheck.Location = New System.Drawing.Point(30, 10)
        Me.btnRefresh_paycheck.Name = "btnRefresh_paycheck"
        Me.btnRefresh_paycheck.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_paycheck.TabIndex = 12
        Me.btnRefresh_paycheck.Text = ">> 刷新 >>"
        Me.btnRefresh_paycheck.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(56, 551)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 27)
        Me.btnCheck.TabIndex = 11
        Me.btnCheck.Text = ">> 查看 >>"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'DataGridView_paid
        '
        Me.DataGridView_paid.AllowUserToAddRows = False
        Me.DataGridView_paid.AllowUserToDeleteRows = False
        Me.DataGridView_paid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_paid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_paid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_paid.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_paid.Location = New System.Drawing.Point(30, 47)
        Me.DataGridView_paid.MultiSelect = False
        Me.DataGridView_paid.Name = "DataGridView_paid"
        Me.DataGridView_paid.ReadOnly = True
        Me.DataGridView_paid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_paid.Size = New System.Drawing.Size(972, 499)
        Me.DataGridView_paid.TabIndex = 8
        '
        'TabPage_delGuahao
        '
        Me.TabPage_delGuahao.Controls.Add(Me.btn_delete)
        Me.TabPage_delGuahao.Controls.Add(Me.DataGridView_delGuahao)
        Me.TabPage_delGuahao.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_delGuahao.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_delGuahao.Name = "TabPage_delGuahao"
        Me.TabPage_delGuahao.Size = New System.Drawing.Size(1012, 598)
        Me.TabPage_delGuahao.TabIndex = 2
        Me.TabPage_delGuahao.Text = "挂号清理"
        Me.TabPage_delGuahao.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(18, 552)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(82, 26)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "删除"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'DataGridView_delGuahao
        '
        Me.DataGridView_delGuahao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_delGuahao.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_delGuahao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_delGuahao.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_delGuahao.Location = New System.Drawing.Point(18, 20)
        Me.DataGridView_delGuahao.MultiSelect = False
        Me.DataGridView_delGuahao.Name = "DataGridView_delGuahao"
        Me.DataGridView_delGuahao.ReadOnly = True
        Me.DataGridView_delGuahao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_delGuahao.Size = New System.Drawing.Size(958, 520)
        Me.DataGridView_delGuahao.TabIndex = 4
        '
        'TabPage_refund
        '
        Me.TabPage_refund.Controls.Add(Me.txtSex)
        Me.TabPage_refund.Controls.Add(Me.Label25)
        Me.TabPage_refund.Controls.Add(Me.btnDel_row_feeitem)
        Me.TabPage_refund.Controls.Add(Me.btn_delRow_medi)
        Me.TabPage_refund.Controls.Add(Me.Label23)
        Me.TabPage_refund.Controls.Add(Me.Label21)
        Me.TabPage_refund.Controls.Add(Me.txt_price_totalAll_new)
        Me.TabPage_refund.Controls.Add(Me.Label22)
        Me.TabPage_refund.Controls.Add(Me.Label19)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_total)
        Me.TabPage_refund.Controls.Add(Me.Label20)
        Me.TabPage_refund.Controls.Add(Me.DataGridView_feeitem_refund)
        Me.TabPage_refund.Controls.Add(Me.DataGridView_medi_refund)
        Me.TabPage_refund.Controls.Add(Me.btnGuahao_search)
        Me.TabPage_refund.Controls.Add(Me.txtSearch_GuahaoID)
        Me.TabPage_refund.Controls.Add(Me.Label18)
        Me.TabPage_refund.Controls.Add(Me.Label12)
        Me.TabPage_refund.Controls.Add(Me.txtTotal_all)
        Me.TabPage_refund.Controls.Add(Me.Label13)
        Me.TabPage_refund.Controls.Add(Me.Label10)
        Me.TabPage_refund.Controls.Add(Me.txtFeeitem_total)
        Me.TabPage_refund.Controls.Add(Me.Label11)
        Me.TabPage_refund.Controls.Add(Me.DataGridView_feeitem)
        Me.TabPage_refund.Controls.Add(Me.Label9)
        Me.TabPage_refund.Controls.Add(Me.txtPriceTotal)
        Me.TabPage_refund.Controls.Add(Me.Label8)
        Me.TabPage_refund.Controls.Add(Me.btn_print_review)
        Me.TabPage_refund.Controls.Add(Me.btnRefund_sure)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_GID)
        Me.TabPage_refund.Controls.Add(Me.Label7)
        Me.TabPage_refund.Controls.Add(Me.DataGridView_check)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_datetime)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_doctor)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_age)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_PID)
        Me.TabPage_refund.Controls.Add(Me.txtRefund_name)
        Me.TabPage_refund.Controls.Add(Me.Label6)
        Me.TabPage_refund.Controls.Add(Me.Label14)
        Me.TabPage_refund.Controls.Add(Me.Label15)
        Me.TabPage_refund.Controls.Add(Me.Label16)
        Me.TabPage_refund.Controls.Add(Me.Label17)
        Me.TabPage_refund.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_refund.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_refund.Name = "TabPage_refund"
        Me.TabPage_refund.Size = New System.Drawing.Size(1012, 598)
        Me.TabPage_refund.TabIndex = 4
        Me.TabPage_refund.Text = "退费"
        Me.TabPage_refund.UseVisualStyleBackColor = True
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSex.Enabled = False
        Me.txtSex.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(78, 93)
        Me.txtSex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(206, 15)
        Me.txtSex.TabIndex = 81
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(21, 91)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 15)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "性别:"
        '
        'btnDel_row_feeitem
        '
        Me.btnDel_row_feeitem.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDel_row_feeitem.Location = New System.Drawing.Point(263, 528)
        Me.btnDel_row_feeitem.Name = "btnDel_row_feeitem"
        Me.btnDel_row_feeitem.Size = New System.Drawing.Size(43, 24)
        Me.btnDel_row_feeitem.TabIndex = 79
        Me.btnDel_row_feeitem.Text = "删除<<"
        Me.btnDel_row_feeitem.UseVisualStyleBackColor = True
        '
        'btn_delRow_medi
        '
        Me.btn_delRow_medi.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_delRow_medi.Location = New System.Drawing.Point(651, 380)
        Me.btn_delRow_medi.Name = "btn_delRow_medi"
        Me.btn_delRow_medi.Size = New System.Drawing.Size(43, 24)
        Me.btn_delRow_medi.TabIndex = 78
        Me.btn_delRow_medi.Text = "删除<<"
        Me.btn_delRow_medi.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(237, 457)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 15)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = ">>"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label21.Location = New System.Drawing.Point(652, 494)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 15)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "(元)"
        '
        'txt_price_totalAll_new
        '
        Me.txt_price_totalAll_new.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_price_totalAll_new.Enabled = False
        Me.txt_price_totalAll_new.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_price_totalAll_new.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_price_totalAll_new.Location = New System.Drawing.Point(577, 495)
        Me.txt_price_totalAll_new.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_price_totalAll_new.Name = "txt_price_totalAll_new"
        Me.txt_price_totalAll_new.Size = New System.Drawing.Size(68, 16)
        Me.txt_price_totalAll_new.TabIndex = 75
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label22.Location = New System.Drawing.Point(514, 495)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 19)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "新总金额:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(652, 475)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 15)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "(元)"
        '
        'txtRefund_total
        '
        Me.txtRefund_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_total.Enabled = False
        Me.txtRefund_total.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtRefund_total.ForeColor = System.Drawing.Color.Red
        Me.txtRefund_total.Location = New System.Drawing.Point(577, 476)
        Me.txtRefund_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_total.Name = "txtRefund_total"
        Me.txtRefund_total.Size = New System.Drawing.Size(68, 16)
        Me.txtRefund_total.TabIndex = 72
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(519, 476)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 19)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "退费:"
        '
        'DataGridView_feeitem_refund
        '
        Me.DataGridView_feeitem_refund.AllowUserToAddRows = False
        Me.DataGridView_feeitem_refund.AllowUserToDeleteRows = False
        Me.DataGridView_feeitem_refund.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_feeitem_refund.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_feeitem_refund.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_feeitem_refund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_feeitem_refund.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView_feeitem_refund.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_feeitem_refund.Location = New System.Drawing.Point(263, 411)
        Me.DataGridView_feeitem_refund.Name = "DataGridView_feeitem_refund"
        Me.DataGridView_feeitem_refund.ReadOnly = True
        Me.DataGridView_feeitem_refund.RowHeadersVisible = False
        Me.DataGridView_feeitem_refund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_feeitem_refund.Size = New System.Drawing.Size(209, 112)
        Me.DataGridView_feeitem_refund.TabIndex = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 111.6751!
        Me.DataGridViewTextBoxColumn1.HeaderText = "项目名称"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 88.32487!
        Me.DataGridViewTextBoxColumn2.HeaderText = "价格"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridView_medi_refund
        '
        Me.DataGridView_medi_refund.AllowUserToAddRows = False
        Me.DataGridView_medi_refund.AllowUserToDeleteRows = False
        Me.DataGridView_medi_refund.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_medi_refund.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_medi_refund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_medi_refund.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView_medi_refund.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_medi_refund.Location = New System.Drawing.Point(23, 267)
        Me.DataGridView_medi_refund.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView_medi_refund.MultiSelect = False
        Me.DataGridView_medi_refund.Name = "DataGridView_medi_refund"
        Me.DataGridView_medi_refund.ReadOnly = True
        Me.DataGridView_medi_refund.RowHeadersVisible = False
        Me.DataGridView_medi_refund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_medi_refund.Size = New System.Drawing.Size(622, 137)
        Me.DataGridView_medi_refund.TabIndex = 69
        '
        'Column1
        '
        Me.Column1.FillWeight = 152.2842!
        Me.Column1.HeaderText = "药名"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 86.9289!
        Me.Column2.HeaderText = "量"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 86.9289!
        Me.Column3.HeaderText = "单位"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 86.9289!
        Me.Column4.HeaderText = "单价"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 86.9289!
        Me.Column5.HeaderText = "金额"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnGuahao_search
        '
        Me.btnGuahao_search.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuahao_search.Location = New System.Drawing.Point(241, 15)
        Me.btnGuahao_search.Name = "btnGuahao_search"
        Me.btnGuahao_search.Size = New System.Drawing.Size(75, 25)
        Me.btnGuahao_search.TabIndex = 68
        Me.btnGuahao_search.Text = "搜索"
        Me.btnGuahao_search.UseVisualStyleBackColor = True
        '
        'txtSearch_GuahaoID
        '
        Me.txtSearch_GuahaoID.Location = New System.Drawing.Point(121, 16)
        Me.txtSearch_GuahaoID.Name = "txtSearch_GuahaoID"
        Me.txtSearch_GuahaoID.Size = New System.Drawing.Size(99, 23)
        Me.txtSearch_GuahaoID.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 17)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "请输入挂号ID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(652, 452)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 15)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "(元)"
        '
        'txtTotal_all
        '
        Me.txtTotal_all.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal_all.Enabled = False
        Me.txtTotal_all.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTotal_all.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTotal_all.Location = New System.Drawing.Point(577, 453)
        Me.txtTotal_all.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal_all.Name = "txtTotal_all"
        Me.txtTotal_all.Size = New System.Drawing.Size(68, 16)
        Me.txtTotal_all.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(519, 453)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 19)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "总金额:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(652, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 15)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "(元)"
        '
        'txtFeeitem_total
        '
        Me.txtFeeitem_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeeitem_total.Enabled = False
        Me.txtFeeitem_total.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtFeeitem_total.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtFeeitem_total.Location = New System.Drawing.Point(577, 430)
        Me.txtFeeitem_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFeeitem_total.Name = "txtFeeitem_total"
        Me.txtFeeitem_total.Size = New System.Drawing.Size(68, 16)
        Me.txtFeeitem_total.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(519, 430)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "其他项:"
        '
        'DataGridView_feeitem
        '
        Me.DataGridView_feeitem.AllowUserToAddRows = False
        Me.DataGridView_feeitem.AllowUserToDeleteRows = False
        Me.DataGridView_feeitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_feeitem.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_feeitem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_feeitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_feeitem.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_feeitem.Location = New System.Drawing.Point(23, 411)
        Me.DataGridView_feeitem.Name = "DataGridView_feeitem"
        Me.DataGridView_feeitem.ReadOnly = True
        Me.DataGridView_feeitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_feeitem.Size = New System.Drawing.Size(209, 112)
        Me.DataGridView_feeitem.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(652, 407)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "(元)"
        '
        'txtPriceTotal
        '
        Me.txtPriceTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPriceTotal.Enabled = False
        Me.txtPriceTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPriceTotal.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtPriceTotal.Location = New System.Drawing.Point(577, 408)
        Me.txtPriceTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPriceTotal.Name = "txtPriceTotal"
        Me.txtPriceTotal.Size = New System.Drawing.Size(68, 16)
        Me.txtPriceTotal.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(519, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "医药费:"
        '
        'btn_print_review
        '
        Me.btn_print_review.Location = New System.Drawing.Point(628, 526)
        Me.btn_print_review.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_print_review.Name = "btn_print_review"
        Me.btn_print_review.Size = New System.Drawing.Size(105, 28)
        Me.btn_print_review.TabIndex = 54
        Me.btn_print_review.Text = "Print Review"
        Me.btn_print_review.UseVisualStyleBackColor = True
        '
        'btnRefund_sure
        '
        Me.btnRefund_sure.Location = New System.Drawing.Point(517, 526)
        Me.btnRefund_sure.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefund_sure.Name = "btnRefund_sure"
        Me.btnRefund_sure.Size = New System.Drawing.Size(105, 28)
        Me.btnRefund_sure.TabIndex = 53
        Me.btnRefund_sure.Text = "确认退费"
        Me.btnRefund_sure.UseVisualStyleBackColor = True
        '
        'txtRefund_GID
        '
        Me.txtRefund_GID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_GID.Enabled = False
        Me.txtRefund_GID.Location = New System.Drawing.Point(449, 106)
        Me.txtRefund_GID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_GID.Name = "txtRefund_GID"
        Me.txtRefund_GID.Size = New System.Drawing.Size(196, 16)
        Me.txtRefund_GID.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(360, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 51
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
        Me.DataGridView_check.Location = New System.Drawing.Point(23, 130)
        Me.DataGridView_check.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView_check.MultiSelect = False
        Me.DataGridView_check.Name = "DataGridView_check"
        Me.DataGridView_check.ReadOnly = True
        Me.DataGridView_check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_check.Size = New System.Drawing.Size(622, 129)
        Me.DataGridView_check.TabIndex = 50
        '
        'txtRefund_datetime
        '
        Me.txtRefund_datetime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_datetime.Enabled = False
        Me.txtRefund_datetime.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund_datetime.Location = New System.Drawing.Point(449, 81)
        Me.txtRefund_datetime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_datetime.Name = "txtRefund_datetime"
        Me.txtRefund_datetime.Size = New System.Drawing.Size(196, 15)
        Me.txtRefund_datetime.TabIndex = 49
        '
        'txtRefund_doctor
        '
        Me.txtRefund_doctor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_doctor.Enabled = False
        Me.txtRefund_doctor.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund_doctor.Location = New System.Drawing.Point(449, 60)
        Me.txtRefund_doctor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_doctor.Name = "txtRefund_doctor"
        Me.txtRefund_doctor.Size = New System.Drawing.Size(196, 15)
        Me.txtRefund_doctor.TabIndex = 48
        '
        'txtRefund_age
        '
        Me.txtRefund_age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_age.Enabled = False
        Me.txtRefund_age.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund_age.Location = New System.Drawing.Point(78, 111)
        Me.txtRefund_age.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_age.Name = "txtRefund_age"
        Me.txtRefund_age.Size = New System.Drawing.Size(206, 15)
        Me.txtRefund_age.TabIndex = 47
        '
        'txtRefund_PID
        '
        Me.txtRefund_PID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_PID.Enabled = False
        Me.txtRefund_PID.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund_PID.Location = New System.Drawing.Point(77, 75)
        Me.txtRefund_PID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_PID.Name = "txtRefund_PID"
        Me.txtRefund_PID.Size = New System.Drawing.Size(206, 15)
        Me.txtRefund_PID.TabIndex = 46
        '
        'txtRefund_name
        '
        Me.txtRefund_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefund_name.Enabled = False
        Me.txtRefund_name.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund_name.Location = New System.Drawing.Point(78, 56)
        Me.txtRefund_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefund_name.Name = "txtRefund_name"
        Me.txtRefund_name.Size = New System.Drawing.Size(205, 15)
        Me.txtRefund_name.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "取药时间:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "医师:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 15)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "身份证:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 15)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "年龄:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 15)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "姓名:"
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
        'txtGID_search
        '
        Me.txtGID_search.Location = New System.Drawing.Point(613, 16)
        Me.txtGID_search.Name = "txtGID_search"
        Me.txtGID_search.Size = New System.Drawing.Size(61, 23)
        Me.txtGID_search.TabIndex = 24
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(545, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 17)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "挂号ID："
        '
        'btnGID_search
        '
        Me.btnGID_search.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGID_search.Location = New System.Drawing.Point(704, 16)
        Me.btnGID_search.Name = "btnGID_search"
        Me.btnGID_search.Size = New System.Drawing.Size(75, 25)
        Me.btnGID_search.TabIndex = 22
        Me.btnGID_search.Text = "搜索"
        Me.btnGID_search.UseVisualStyleBackColor = True
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1020, 630)
        Me.Controls.Add(Me.TabControl_cashier)
        Me.Name = "frmCashier"
        Me.Text = "收银员工作平台"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl_cashier.ResumeLayout(False)
        Me.TabPage_guahao.ResumeLayout(False)
        CType(Me.dataGridView_guahao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage_shoufei.ResumeLayout(False)
        CType(Me.DataGridView_prescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_checkPay.ResumeLayout(False)
        Me.TabPage_checkPay.PerformLayout()
        CType(Me.DataGridView_paid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_delGuahao.ResumeLayout(False)
        CType(Me.DataGridView_delGuahao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_refund.ResumeLayout(False)
        Me.TabPage_refund.PerformLayout()
        CType(Me.DataGridView_feeitem_refund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_medi_refund, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_feeitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl_cashier As TabControl
    Friend WithEvents TabPage_guahao As TabPage
    Friend WithEvents TabPage_shoufei As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGuahao As Button
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataGridView_guahao As DataGridView
    Friend WithEvents TabPage_delGuahao As TabPage
    Friend WithEvents btn_delete As Button
    Friend WithEvents DataGridView_delGuahao As DataGridView
    Friend WithEvents DataGridView_prescription As DataGridView
    Friend WithEvents btnPay As Button
    Friend WithEvents TabPage_checkPay As TabPage
    Friend WithEvents DataGridView_paid As DataGridView
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnRefresh_pay As Button
    Friend WithEvents btnRefresh_paycheck As Button
    Friend WithEvents TabPage_refund As TabPage
    Friend WithEvents txtSearch_GuahaoID As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotal_all As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFeeitem_total As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView_feeitem As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPriceTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_print_review As Button
    Friend WithEvents btnRefund_sure As Button
    Friend WithEvents txtRefund_GID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView_check As DataGridView
    Friend WithEvents txtRefund_datetime As TextBox
    Friend WithEvents txtRefund_doctor As TextBox
    Friend WithEvents txtRefund_age As TextBox
    Friend WithEvents txtRefund_PID As TextBox
    Friend WithEvents txtRefund_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnGuahao_search As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_price_totalAll_new As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtRefund_total As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridView_feeitem_refund As DataGridView
    Friend WithEvents DataGridView_medi_refund As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnDel_row_feeitem As Button
    Friend WithEvents btn_delRow_medi As Button
    Friend WithEvents cmbCashier_sex As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtGID_search As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnGID_search As Button
End Class
