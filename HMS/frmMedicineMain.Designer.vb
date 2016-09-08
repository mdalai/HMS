<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicineMain
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
        Me.TabControl_medicine = New System.Windows.Forms.TabControl()
        Me.TabPage_paid = New System.Windows.Forms.TabPage()
        Me.btnRefresh_MDPick = New System.Windows.Forms.Button()
        Me.btnGetMedicine = New System.Windows.Forms.Button()
        Me.DataGridView_paid = New System.Windows.Forms.DataGridView()
        Me.TabPage_medi_check = New System.Windows.Forms.TabPage()
        Me.btnRefresh_MDPickCheck = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.DataGridView_got_medicine = New System.Windows.Forms.DataGridView()
        Me.TabPage_add = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMStorage_add = New System.Windows.Forms.TextBox()
        Me.labelMStorage_add = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStorage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSale_unit_price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_sale_unit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProduction = New System.Windows.Forms.TextBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.txtEffect_date = New System.Windows.Forms.TextBox()
        Me.txtMedicine_norms = New System.Windows.Forms.TextBox()
        Me.txtMedicine_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage_medi_mng = New System.Windows.Forms.TabPage()
        Me.txtMedicine_search = New System.Windows.Forms.TextBox()
        Me.btnRefresh_MD = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_medicine_del = New System.Windows.Forms.Button()
        Me.DataGridView_medicine = New System.Windows.Forms.DataGridView()
        Me.txtGID_search = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnGID_search = New System.Windows.Forms.Button()
        Me.TabControl_medicine.SuspendLayout()
        Me.TabPage_paid.SuspendLayout()
        CType(Me.DataGridView_paid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_medi_check.SuspendLayout()
        CType(Me.DataGridView_got_medicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_add.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_medi_mng.SuspendLayout()
        CType(Me.DataGridView_medicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_medicine
        '
        Me.TabControl_medicine.Controls.Add(Me.TabPage_paid)
        Me.TabControl_medicine.Controls.Add(Me.TabPage_medi_check)
        Me.TabControl_medicine.Controls.Add(Me.TabPage_add)
        Me.TabControl_medicine.Controls.Add(Me.TabPage_medi_mng)
        Me.TabControl_medicine.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl_medicine.Location = New System.Drawing.Point(12, 12)
        Me.TabControl_medicine.Name = "TabControl_medicine"
        Me.TabControl_medicine.SelectedIndex = 0
        Me.TabControl_medicine.Size = New System.Drawing.Size(1300, 675)
        Me.TabControl_medicine.TabIndex = 0
        '
        'TabPage_paid
        '
        Me.TabPage_paid.Controls.Add(Me.btnRefresh_MDPick)
        Me.TabPage_paid.Controls.Add(Me.btnGetMedicine)
        Me.TabPage_paid.Controls.Add(Me.DataGridView_paid)
        Me.TabPage_paid.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_paid.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_paid.Name = "TabPage_paid"
        Me.TabPage_paid.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_paid.Size = New System.Drawing.Size(1292, 640)
        Me.TabPage_paid.TabIndex = 0
        Me.TabPage_paid.Text = "发药"
        Me.TabPage_paid.UseVisualStyleBackColor = True
        '
        'btnRefresh_MDPick
        '
        Me.btnRefresh_MDPick.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_MDPick.Location = New System.Drawing.Point(24, 22)
        Me.btnRefresh_MDPick.Name = "btnRefresh_MDPick"
        Me.btnRefresh_MDPick.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_MDPick.TabIndex = 13
        Me.btnRefresh_MDPick.Text = ">> 刷新 >>"
        Me.btnRefresh_MDPick.UseVisualStyleBackColor = True
        '
        'btnGetMedicine
        '
        Me.btnGetMedicine.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetMedicine.Location = New System.Drawing.Point(1017, 55)
        Me.btnGetMedicine.Name = "btnGetMedicine"
        Me.btnGetMedicine.Size = New System.Drawing.Size(100, 27)
        Me.btnGetMedicine.TabIndex = 12
        Me.btnGetMedicine.Text = ">> 发药 >>"
        Me.btnGetMedicine.UseVisualStyleBackColor = True
        '
        'DataGridView_paid
        '
        Me.DataGridView_paid.AllowUserToAddRows = False
        Me.DataGridView_paid.AllowUserToDeleteRows = False
        Me.DataGridView_paid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_paid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_paid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_paid.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_paid.Location = New System.Drawing.Point(24, 55)
        Me.DataGridView_paid.MultiSelect = False
        Me.DataGridView_paid.Name = "DataGridView_paid"
        Me.DataGridView_paid.ReadOnly = True
        Me.DataGridView_paid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_paid.Size = New System.Drawing.Size(975, 575)
        Me.DataGridView_paid.TabIndex = 11
        '
        'TabPage_medi_check
        '
        Me.TabPage_medi_check.Controls.Add(Me.txtGID_search)
        Me.TabPage_medi_check.Controls.Add(Me.Label26)
        Me.TabPage_medi_check.Controls.Add(Me.btnGID_search)
        Me.TabPage_medi_check.Controls.Add(Me.btnRefresh_MDPickCheck)
        Me.TabPage_medi_check.Controls.Add(Me.btnCheck)
        Me.TabPage_medi_check.Controls.Add(Me.DataGridView_got_medicine)
        Me.TabPage_medi_check.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_medi_check.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_medi_check.Name = "TabPage_medi_check"
        Me.TabPage_medi_check.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_medi_check.Size = New System.Drawing.Size(1292, 640)
        Me.TabPage_medi_check.TabIndex = 1
        Me.TabPage_medi_check.Text = "发药查看"
        Me.TabPage_medi_check.UseVisualStyleBackColor = True
        '
        'btnRefresh_MDPickCheck
        '
        Me.btnRefresh_MDPickCheck.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_MDPickCheck.Location = New System.Drawing.Point(23, 15)
        Me.btnRefresh_MDPickCheck.Name = "btnRefresh_MDPickCheck"
        Me.btnRefresh_MDPickCheck.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_MDPickCheck.TabIndex = 17
        Me.btnRefresh_MDPickCheck.Text = ">> 刷新 >>"
        Me.btnRefresh_MDPickCheck.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(1151, 48)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 27)
        Me.btnCheck.TabIndex = 16
        Me.btnCheck.Text = ">> 查看 >>"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'DataGridView_got_medicine
        '
        Me.DataGridView_got_medicine.AllowUserToAddRows = False
        Me.DataGridView_got_medicine.AllowUserToDeleteRows = False
        Me.DataGridView_got_medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_got_medicine.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_got_medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_got_medicine.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_got_medicine.Location = New System.Drawing.Point(23, 48)
        Me.DataGridView_got_medicine.MultiSelect = False
        Me.DataGridView_got_medicine.Name = "DataGridView_got_medicine"
        Me.DataGridView_got_medicine.ReadOnly = True
        Me.DataGridView_got_medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_got_medicine.Size = New System.Drawing.Size(1122, 575)
        Me.DataGridView_got_medicine.TabIndex = 13
        '
        'TabPage_add
        '
        Me.TabPage_add.Controls.Add(Me.GroupBox1)
        Me.TabPage_add.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_add.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_add.Name = "TabPage_add"
        Me.TabPage_add.Size = New System.Drawing.Size(1292, 640)
        Me.TabPage_add.TabIndex = 3
        Me.TabPage_add.Text = "医药管理 [新增&修改]"
        Me.TabPage_add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMStorage_add)
        Me.GroupBox1.Controls.Add(Me.labelMStorage_add)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStorage)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSale_unit_price)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_sale_unit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAlias)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtProduction)
        Me.GroupBox1.Controls.Add(Me.btnAddUser)
        Me.GroupBox1.Controls.Add(Me.txtEffect_date)
        Me.GroupBox1.Controls.Add(Me.txtMedicine_norms)
        Me.GroupBox1.Controls.Add(Me.txtMedicine_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1098, 478)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "请输入药品的信息"
        '
        'txtMStorage_add
        '
        Me.txtMStorage_add.Location = New System.Drawing.Point(573, 204)
        Me.txtMStorage_add.Name = "txtMStorage_add"
        Me.txtMStorage_add.Size = New System.Drawing.Size(183, 27)
        Me.txtMStorage_add.TabIndex = 43
        '
        'labelMStorage_add
        '
        Me.labelMStorage_add.AutoSize = True
        Me.labelMStorage_add.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMStorage_add.Location = New System.Drawing.Point(446, 201)
        Me.labelMStorage_add.Name = "labelMStorage_add"
        Me.labelMStorage_add.Size = New System.Drawing.Size(94, 21)
        Me.labelMStorage_add.TabIndex = 42
        Me.labelMStorage_add.Text = "新增库存量:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "(请务必按日期格式输入!! 如: 2010-01-21)"
        '
        'txtStorage
        '
        Me.txtStorage.Location = New System.Drawing.Point(171, 204)
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.Size = New System.Drawing.Size(183, 27)
        Me.txtStorage.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 21)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "库存量:"
        '
        'txtSale_unit_price
        '
        Me.txtSale_unit_price.Location = New System.Drawing.Point(171, 167)
        Me.txtSale_unit_price.Name = "txtSale_unit_price"
        Me.txtSale_unit_price.Size = New System.Drawing.Size(183, 27)
        Me.txtSale_unit_price.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "销售单价:"
        '
        'cmb_sale_unit
        '
        Me.cmb_sale_unit.FormattingEnabled = True
        Me.cmb_sale_unit.Items.AddRange(New Object() {"片", "盒", "粒", "袋", "支", "瓶", "包", "板", "个", "付", "套"})
        Me.cmb_sale_unit.Location = New System.Drawing.Point(171, 130)
        Me.cmb_sale_unit.Name = "cmb_sale_unit"
        Me.cmb_sale_unit.Size = New System.Drawing.Size(183, 28)
        Me.cmb_sale_unit.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "销售单位:"
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(171, 291)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(266, 27)
        Me.txtAlias.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(60, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 21)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "别名:"
        '
        'txtProduction
        '
        Me.txtProduction.Location = New System.Drawing.Point(171, 334)
        Me.txtProduction.Name = "txtProduction"
        Me.txtProduction.Size = New System.Drawing.Size(266, 27)
        Me.txtProduction.TabIndex = 7
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(171, 389)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(95, 31)
        Me.btnAddUser.TabIndex = 10
        Me.btnAddUser.Text = "确定"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'txtEffect_date
        '
        Me.txtEffect_date.Location = New System.Drawing.Point(171, 251)
        Me.txtEffect_date.Name = "txtEffect_date"
        Me.txtEffect_date.Size = New System.Drawing.Size(183, 27)
        Me.txtEffect_date.TabIndex = 8
        '
        'txtMedicine_norms
        '
        Me.txtMedicine_norms.Location = New System.Drawing.Point(171, 91)
        Me.txtMedicine_norms.Name = "txtMedicine_norms"
        Me.txtMedicine_norms.Size = New System.Drawing.Size(183, 27)
        Me.txtMedicine_norms.TabIndex = 6
        '
        'txtMedicine_name
        '
        Me.txtMedicine_name.Location = New System.Drawing.Point(171, 55)
        Me.txtMedicine_name.Name = "txtMedicine_name"
        Me.txtMedicine_name.Size = New System.Drawing.Size(183, 27)
        Me.txtMedicine_name.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "有效期:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "生产厂家:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "药品规格:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "药品名称:"
        '
        'TabPage_medi_mng
        '
        Me.TabPage_medi_mng.Controls.Add(Me.txtMedicine_search)
        Me.TabPage_medi_mng.Controls.Add(Me.btnRefresh_MD)
        Me.TabPage_medi_mng.Controls.Add(Me.btn_update)
        Me.TabPage_medi_mng.Controls.Add(Me.btn_medicine_del)
        Me.TabPage_medi_mng.Controls.Add(Me.DataGridView_medicine)
        Me.TabPage_medi_mng.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_medi_mng.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_medi_mng.Name = "TabPage_medi_mng"
        Me.TabPage_medi_mng.Size = New System.Drawing.Size(1292, 640)
        Me.TabPage_medi_mng.TabIndex = 2
        Me.TabPage_medi_mng.Text = "医药管理 [查看]"
        Me.TabPage_medi_mng.UseVisualStyleBackColor = True
        '
        'txtMedicine_search
        '
        Me.txtMedicine_search.Location = New System.Drawing.Point(250, 15)
        Me.txtMedicine_search.Name = "txtMedicine_search"
        Me.txtMedicine_search.Size = New System.Drawing.Size(412, 23)
        Me.txtMedicine_search.TabIndex = 16
        '
        'btnRefresh_MD
        '
        Me.btnRefresh_MD.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_MD.Location = New System.Drawing.Point(44, 15)
        Me.btnRefresh_MD.Name = "btnRefresh_MD"
        Me.btnRefresh_MD.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_MD.TabIndex = 14
        Me.btnRefresh_MD.Text = ">> 刷新 >>"
        Me.btnRefresh_MD.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(217, 572)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(152, 33)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "修改"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_medicine_del
        '
        Me.btn_medicine_del.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medicine_del.Location = New System.Drawing.Point(44, 572)
        Me.btn_medicine_del.Name = "btn_medicine_del"
        Me.btn_medicine_del.Size = New System.Drawing.Size(157, 33)
        Me.btn_medicine_del.TabIndex = 2
        Me.btn_medicine_del.Text = "确认删除"
        Me.btn_medicine_del.UseVisualStyleBackColor = True
        '
        'DataGridView_medicine
        '
        Me.DataGridView_medicine.AllowUserToAddRows = False
        Me.DataGridView_medicine.AllowUserToDeleteRows = False
        Me.DataGridView_medicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_medicine.Location = New System.Drawing.Point(44, 48)
        Me.DataGridView_medicine.Name = "DataGridView_medicine"
        Me.DataGridView_medicine.ReadOnly = True
        Me.DataGridView_medicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_medicine.Size = New System.Drawing.Size(1205, 507)
        Me.DataGridView_medicine.TabIndex = 1
        '
        'txtGID_search
        '
        Me.txtGID_search.Location = New System.Drawing.Point(662, 17)
        Me.txtGID_search.Name = "txtGID_search"
        Me.txtGID_search.Size = New System.Drawing.Size(61, 23)
        Me.txtGID_search.TabIndex = 27
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(594, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 17)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = "挂号ID："
        '
        'btnGID_search
        '
        Me.btnGID_search.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGID_search.Location = New System.Drawing.Point(753, 17)
        Me.btnGID_search.Name = "btnGID_search"
        Me.btnGID_search.Size = New System.Drawing.Size(75, 25)
        Me.btnGID_search.TabIndex = 25
        Me.btnGID_search.Text = "搜索"
        Me.btnGID_search.UseVisualStyleBackColor = True
        '
        'frmMedicineMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1360, 723)
        Me.Controls.Add(Me.TabControl_medicine)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMedicineMain"
        Me.Text = "药物管理平台"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl_medicine.ResumeLayout(False)
        Me.TabPage_paid.ResumeLayout(False)
        CType(Me.DataGridView_paid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_medi_check.ResumeLayout(False)
        Me.TabPage_medi_check.PerformLayout()
        CType(Me.DataGridView_got_medicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_add.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage_medi_mng.ResumeLayout(False)
        Me.TabPage_medi_mng.PerformLayout()
        CType(Me.DataGridView_medicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl_medicine As TabControl
    Friend WithEvents TabPage_paid As TabPage
    Friend WithEvents TabPage_medi_check As TabPage
    Friend WithEvents DataGridView_paid As DataGridView
    Friend WithEvents btnGetMedicine As Button
    Friend WithEvents DataGridView_got_medicine As DataGridView
    Friend WithEvents btnCheck As Button
    Friend WithEvents TabPage_medi_mng As TabPage
    Friend WithEvents DataGridView_medicine As DataGridView
    Friend WithEvents btn_medicine_del As Button
    Friend WithEvents TabPage_add As TabPage
    Friend WithEvents btn_update As Button
    Friend WithEvents btnRefresh_MDPick As Button
    Friend WithEvents btnRefresh_MDPickCheck As Button
    Friend WithEvents btnRefresh_MD As Button
    Friend WithEvents txtMedicine_search As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtStorage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSale_unit_price As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_sale_unit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProduction As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents txtEffect_date As TextBox
    Friend WithEvents txtMedicine_norms As TextBox
    Friend WithEvents txtMedicine_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMStorage_add As TextBox
    Friend WithEvents labelMStorage_add As Label
    Friend WithEvents txtGID_search As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnGID_search As Button
End Class
