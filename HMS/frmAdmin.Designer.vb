<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.TabControl_admin = New System.Windows.Forms.TabControl()
        Me.TabPage_add_staff = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.cmb_Usertype = New System.Windows.Forms.ComboBox()
        Me.txtWork_date = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage_staff_management = New System.Windows.Forms.TabPage()
        Me.btnStaff_update = New System.Windows.Forms.Button()
        Me.btnStaff_del = New System.Windows.Forms.Button()
        Me.DataGridView_user = New System.Windows.Forms.DataGridView()
        Me.TabPage_guahao_management = New System.Windows.Forms.TabPage()
        Me.DataGridView_Guahao = New System.Windows.Forms.DataGridView()
        Me.TabPage_feeItem1_add = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_feeitem_type = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFeeItem1_remark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_FeeItem1_OK = New System.Windows.Forms.Button()
        Me.txtFeeItem1_price = New System.Windows.Forms.TextBox()
        Me.txtFeeItem1_name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage_feeItem1 = New System.Windows.Forms.TabPage()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.DataGridView_FeeItem1 = New System.Windows.Forms.DataGridView()
        Me.TabPage_usage1 = New System.Windows.Forms.TabPage()
        Me.btn_medi_usage1_del = New System.Windows.Forms.Button()
        Me.btn_medi_usage1_update = New System.Windows.Forms.Button()
        Me.DataGridView_medi_usage1 = New System.Windows.Forms.DataGridView()
        Me.TabPage_usage2 = New System.Windows.Forms.TabPage()
        Me.TabPage_use_unit = New System.Windows.Forms.TabPage()
        Me.DataGridView_medi_usage2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView_medi_use_unit = New System.Windows.Forms.DataGridView()
        Me.btn_medi_usage2_del = New System.Windows.Forms.Button()
        Me.btn_medi_usage2_update = New System.Windows.Forms.Button()
        Me.btn_medi_unit_del = New System.Windows.Forms.Button()
        Me.btn_medi_unit_update = New System.Windows.Forms.Button()
        Me.TabControl_admin.SuspendLayout()
        Me.TabPage_add_staff.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_staff_management.SuspendLayout()
        CType(Me.DataGridView_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_guahao_management.SuspendLayout()
        CType(Me.DataGridView_Guahao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_feeItem1_add.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage_feeItem1.SuspendLayout()
        CType(Me.DataGridView_FeeItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_usage1.SuspendLayout()
        CType(Me.DataGridView_medi_usage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_usage2.SuspendLayout()
        Me.TabPage_use_unit.SuspendLayout()
        CType(Me.DataGridView_medi_usage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_medi_use_unit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_admin
        '
        Me.TabControl_admin.Controls.Add(Me.TabPage_add_staff)
        Me.TabControl_admin.Controls.Add(Me.TabPage_staff_management)
        Me.TabControl_admin.Controls.Add(Me.TabPage_guahao_management)
        Me.TabControl_admin.Controls.Add(Me.TabPage_feeItem1_add)
        Me.TabControl_admin.Controls.Add(Me.TabPage_feeItem1)
        Me.TabControl_admin.Controls.Add(Me.TabPage_usage1)
        Me.TabControl_admin.Controls.Add(Me.TabPage_usage2)
        Me.TabControl_admin.Controls.Add(Me.TabPage_use_unit)
        Me.TabControl_admin.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl_admin.ItemSize = New System.Drawing.Size(100, 24)
        Me.TabControl_admin.Location = New System.Drawing.Point(52, 3)
        Me.TabControl_admin.Name = "TabControl_admin"
        Me.TabControl_admin.SelectedIndex = 0
        Me.TabControl_admin.Size = New System.Drawing.Size(1300, 680)
        Me.TabControl_admin.TabIndex = 1
        '
        'TabPage_add_staff
        '
        Me.TabPage_add_staff.Controls.Add(Me.GroupBox1)
        Me.TabPage_add_staff.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_add_staff.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_add_staff.Name = "TabPage_add_staff"
        Me.TabPage_add_staff.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_add_staff.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_add_staff.TabIndex = 0
        Me.TabPage_add_staff.Text = "新增&修改用户"
        Me.TabPage_add_staff.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRemark)
        Me.GroupBox1.Controls.Add(Me.txtDepartment)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnAddUser)
        Me.GroupBox1.Controls.Add(Me.cmb_Usertype)
        Me.GroupBox1.Controls.Add(Me.txtWork_date)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(81, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 444)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "请输入用户信息"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "(日期格式: 2000-10-05)"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(207, 282)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(183, 27)
        Me.txtRemark.TabIndex = 12
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(207, 202)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(183, 27)
        Me.txtDepartment.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "注释:"
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(295, 346)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(95, 31)
        Me.btnAddUser.TabIndex = 10
        Me.btnAddUser.Text = "确定"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'cmb_Usertype
        '
        Me.cmb_Usertype.FormattingEnabled = True
        Me.cmb_Usertype.Items.AddRange(New Object() {"收银员", "医生", "药物管理员"})
        Me.cmb_Usertype.Location = New System.Drawing.Point(207, 164)
        Me.cmb_Usertype.Name = "cmb_Usertype"
        Me.cmb_Usertype.Size = New System.Drawing.Size(183, 28)
        Me.cmb_Usertype.TabIndex = 9
        '
        'txtWork_date
        '
        Me.txtWork_date.Location = New System.Drawing.Point(207, 241)
        Me.txtWork_date.Name = "txtWork_date"
        Me.txtWork_date.Size = New System.Drawing.Size(183, 27)
        Me.txtWork_date.TabIndex = 8
        Me.txtWork_date.Text = "2000-01-01"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(207, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(183, 27)
        Me.txtPassword.TabIndex = 6
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(207, 91)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(183, 27)
        Me.txtUsername.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "入职日期:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "科室:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "用户类别:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "登录密码:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户姓名:"
        '
        'TabPage_staff_management
        '
        Me.TabPage_staff_management.Controls.Add(Me.btnStaff_update)
        Me.TabPage_staff_management.Controls.Add(Me.btnStaff_del)
        Me.TabPage_staff_management.Controls.Add(Me.DataGridView_user)
        Me.TabPage_staff_management.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_staff_management.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_staff_management.Name = "TabPage_staff_management"
        Me.TabPage_staff_management.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_staff_management.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_staff_management.TabIndex = 1
        Me.TabPage_staff_management.Text = "用户管理"
        Me.TabPage_staff_management.UseVisualStyleBackColor = True
        '
        'btnStaff_update
        '
        Me.btnStaff_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff_update.Location = New System.Drawing.Point(868, 25)
        Me.btnStaff_update.Name = "btnStaff_update"
        Me.btnStaff_update.Size = New System.Drawing.Size(115, 33)
        Me.btnStaff_update.TabIndex = 8
        Me.btnStaff_update.Text = "修改"
        Me.btnStaff_update.UseVisualStyleBackColor = True
        '
        'btnStaff_del
        '
        Me.btnStaff_del.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff_del.Location = New System.Drawing.Point(868, 74)
        Me.btnStaff_del.Name = "btnStaff_del"
        Me.btnStaff_del.Size = New System.Drawing.Size(115, 33)
        Me.btnStaff_del.TabIndex = 7
        Me.btnStaff_del.Text = "确认删除"
        Me.btnStaff_del.UseVisualStyleBackColor = True
        '
        'DataGridView_user
        '
        Me.DataGridView_user.AllowUserToAddRows = False
        Me.DataGridView_user.AllowUserToDeleteRows = False
        Me.DataGridView_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_user.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_user.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_user.Location = New System.Drawing.Point(57, 25)
        Me.DataGridView_user.MultiSelect = False
        Me.DataGridView_user.Name = "DataGridView_user"
        Me.DataGridView_user.ReadOnly = True
        Me.DataGridView_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_user.Size = New System.Drawing.Size(770, 560)
        Me.DataGridView_user.TabIndex = 6
        '
        'TabPage_guahao_management
        '
        Me.TabPage_guahao_management.Controls.Add(Me.DataGridView_Guahao)
        Me.TabPage_guahao_management.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_guahao_management.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_guahao_management.Name = "TabPage_guahao_management"
        Me.TabPage_guahao_management.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_guahao_management.TabIndex = 3
        Me.TabPage_guahao_management.Text = "挂号信息管理"
        Me.TabPage_guahao_management.UseVisualStyleBackColor = True
        '
        'DataGridView_Guahao
        '
        Me.DataGridView_Guahao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Guahao.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_Guahao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Guahao.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_Guahao.Location = New System.Drawing.Point(24, 25)
        Me.DataGridView_Guahao.MultiSelect = False
        Me.DataGridView_Guahao.Name = "DataGridView_Guahao"
        Me.DataGridView_Guahao.ReadOnly = True
        Me.DataGridView_Guahao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Guahao.Size = New System.Drawing.Size(1254, 600)
        Me.DataGridView_Guahao.TabIndex = 12
        '
        'TabPage_feeItem1_add
        '
        Me.TabPage_feeItem1_add.Controls.Add(Me.GroupBox2)
        Me.TabPage_feeItem1_add.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_feeItem1_add.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_feeItem1_add.Name = "TabPage_feeItem1_add"
        Me.TabPage_feeItem1_add.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_feeItem1_add.TabIndex = 4
        Me.TabPage_feeItem1_add.Text = "收费项添加&修改"
        Me.TabPage_feeItem1_add.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmb_feeitem_type)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtFeeItem1_remark)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_FeeItem1_OK)
        Me.GroupBox2.Controls.Add(Me.txtFeeItem1_price)
        Me.GroupBox2.Controls.Add(Me.txtFeeItem1_name)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(71, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 400)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "请输入其他费用项"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(381, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "(请务必选择费用类别， 不同费用类别显示不同结果)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(381, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "( 默认费用 )"
        '
        'cmb_feeitem_type
        '
        Me.cmb_feeitem_type.DisplayMember = "0"
        Me.cmb_feeitem_type.FormattingEnabled = True
        Me.cmb_feeitem_type.Items.AddRange(New Object() {"固定费用", "变动费用"})
        Me.cmb_feeitem_type.Location = New System.Drawing.Point(171, 93)
        Me.cmb_feeitem_type.Name = "cmb_feeitem_type"
        Me.cmb_feeitem_type.Size = New System.Drawing.Size(183, 28)
        Me.cmb_feeitem_type.TabIndex = 14
        Me.cmb_feeitem_type.Tag = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "类别:"
        '
        'txtFeeItem1_remark
        '
        Me.txtFeeItem1_remark.Location = New System.Drawing.Point(171, 183)
        Me.txtFeeItem1_remark.Name = "txtFeeItem1_remark"
        Me.txtFeeItem1_remark.Size = New System.Drawing.Size(358, 27)
        Me.txtFeeItem1_remark.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "说明:"
        '
        'btn_FeeItem1_OK
        '
        Me.btn_FeeItem1_OK.Location = New System.Drawing.Point(171, 234)
        Me.btn_FeeItem1_OK.Name = "btn_FeeItem1_OK"
        Me.btn_FeeItem1_OK.Size = New System.Drawing.Size(95, 31)
        Me.btn_FeeItem1_OK.TabIndex = 10
        Me.btn_FeeItem1_OK.Text = "确定"
        Me.btn_FeeItem1_OK.UseVisualStyleBackColor = True
        '
        'txtFeeItem1_price
        '
        Me.txtFeeItem1_price.Location = New System.Drawing.Point(171, 140)
        Me.txtFeeItem1_price.Name = "txtFeeItem1_price"
        Me.txtFeeItem1_price.Size = New System.Drawing.Size(183, 27)
        Me.txtFeeItem1_price.TabIndex = 8
        '
        'txtFeeItem1_name
        '
        Me.txtFeeItem1_name.Location = New System.Drawing.Point(171, 55)
        Me.txtFeeItem1_name.Name = "txtFeeItem1_name"
        Me.txtFeeItem1_name.Size = New System.Drawing.Size(183, 27)
        Me.txtFeeItem1_name.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "价格:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(44, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 21)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "费用项名称:"
        '
        'TabPage_feeItem1
        '
        Me.TabPage_feeItem1.Controls.Add(Me.btn_update)
        Me.TabPage_feeItem1.Controls.Add(Me.btn_del)
        Me.TabPage_feeItem1.Controls.Add(Me.DataGridView_FeeItem1)
        Me.TabPage_feeItem1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_feeItem1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_feeItem1.Name = "TabPage_feeItem1"
        Me.TabPage_feeItem1.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_feeItem1.TabIndex = 5
        Me.TabPage_feeItem1.Text = "收费项"
        Me.TabPage_feeItem1.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(217, 517)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(152, 33)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "修改"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(44, 517)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(157, 33)
        Me.btn_del.TabIndex = 5
        Me.btn_del.Text = "确认删除"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'DataGridView_FeeItem1
        '
        Me.DataGridView_FeeItem1.AllowUserToAddRows = False
        Me.DataGridView_FeeItem1.AllowUserToDeleteRows = False
        Me.DataGridView_FeeItem1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_FeeItem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_FeeItem1.Location = New System.Drawing.Point(44, 46)
        Me.DataGridView_FeeItem1.Name = "DataGridView_FeeItem1"
        Me.DataGridView_FeeItem1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_FeeItem1.Size = New System.Drawing.Size(639, 440)
        Me.DataGridView_FeeItem1.TabIndex = 4
        '
        'TabPage_usage1
        '
        Me.TabPage_usage1.Controls.Add(Me.btn_medi_usage1_del)
        Me.TabPage_usage1.Controls.Add(Me.btn_medi_usage1_update)
        Me.TabPage_usage1.Controls.Add(Me.DataGridView_medi_usage1)
        Me.TabPage_usage1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_usage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_usage1.Name = "TabPage_usage1"
        Me.TabPage_usage1.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_usage1.TabIndex = 6
        Me.TabPage_usage1.Text = "用法"
        Me.TabPage_usage1.UseVisualStyleBackColor = True
        '
        'btn_medi_usage1_del
        '
        Me.btn_medi_usage1_del.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medi_usage1_del.Location = New System.Drawing.Point(187, 372)
        Me.btn_medi_usage1_del.Name = "btn_medi_usage1_del"
        Me.btn_medi_usage1_del.Size = New System.Drawing.Size(99, 33)
        Me.btn_medi_usage1_del.TabIndex = 8
        Me.btn_medi_usage1_del.Text = "删除"
        Me.btn_medi_usage1_del.UseVisualStyleBackColor = True
        '
        'btn_medi_usage1_update
        '
        Me.btn_medi_usage1_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medi_usage1_update.Location = New System.Drawing.Point(48, 372)
        Me.btn_medi_usage1_update.Name = "btn_medi_usage1_update"
        Me.btn_medi_usage1_update.Size = New System.Drawing.Size(99, 33)
        Me.btn_medi_usage1_update.TabIndex = 7
        Me.btn_medi_usage1_update.Text = "更新"
        Me.btn_medi_usage1_update.UseVisualStyleBackColor = True
        '
        'DataGridView_medi_usage1
        '
        Me.DataGridView_medi_usage1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_medi_usage1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_medi_usage1.Location = New System.Drawing.Point(34, 26)
        Me.DataGridView_medi_usage1.Name = "DataGridView_medi_usage1"
        Me.DataGridView_medi_usage1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_medi_usage1.Size = New System.Drawing.Size(361, 316)
        Me.DataGridView_medi_usage1.TabIndex = 5
        '
        'TabPage_usage2
        '
        Me.TabPage_usage2.Controls.Add(Me.btn_medi_usage2_del)
        Me.TabPage_usage2.Controls.Add(Me.btn_medi_usage2_update)
        Me.TabPage_usage2.Controls.Add(Me.DataGridView_medi_usage2)
        Me.TabPage_usage2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_usage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_usage2.Name = "TabPage_usage2"
        Me.TabPage_usage2.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_usage2.TabIndex = 7
        Me.TabPage_usage2.Text = "服用"
        Me.TabPage_usage2.UseVisualStyleBackColor = True
        '
        'TabPage_use_unit
        '
        Me.TabPage_use_unit.Controls.Add(Me.btn_medi_unit_del)
        Me.TabPage_use_unit.Controls.Add(Me.btn_medi_unit_update)
        Me.TabPage_use_unit.Controls.Add(Me.DataGridView_medi_use_unit)
        Me.TabPage_use_unit.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_use_unit.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_use_unit.Name = "TabPage_use_unit"
        Me.TabPage_use_unit.Size = New System.Drawing.Size(1292, 648)
        Me.TabPage_use_unit.TabIndex = 8
        Me.TabPage_use_unit.Text = "用量"
        Me.TabPage_use_unit.UseVisualStyleBackColor = True
        '
        'DataGridView_medi_usage2
        '
        Me.DataGridView_medi_usage2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_medi_usage2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_medi_usage2.Location = New System.Drawing.Point(57, 32)
        Me.DataGridView_medi_usage2.Name = "DataGridView_medi_usage2"
        Me.DataGridView_medi_usage2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_medi_usage2.Size = New System.Drawing.Size(361, 317)
        Me.DataGridView_medi_usage2.TabIndex = 6
        '
        'DataGridView_medi_use_unit
        '
        Me.DataGridView_medi_use_unit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_medi_use_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_medi_use_unit.Location = New System.Drawing.Point(67, 26)
        Me.DataGridView_medi_use_unit.Name = "DataGridView_medi_use_unit"
        Me.DataGridView_medi_use_unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_medi_use_unit.Size = New System.Drawing.Size(361, 329)
        Me.DataGridView_medi_use_unit.TabIndex = 6
        '
        'btn_medi_usage2_del
        '
        Me.btn_medi_usage2_del.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medi_usage2_del.Location = New System.Drawing.Point(196, 380)
        Me.btn_medi_usage2_del.Name = "btn_medi_usage2_del"
        Me.btn_medi_usage2_del.Size = New System.Drawing.Size(99, 33)
        Me.btn_medi_usage2_del.TabIndex = 10
        Me.btn_medi_usage2_del.Text = "删除"
        Me.btn_medi_usage2_del.UseVisualStyleBackColor = True
        '
        'btn_medi_usage2_update
        '
        Me.btn_medi_usage2_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medi_usage2_update.Location = New System.Drawing.Point(57, 380)
        Me.btn_medi_usage2_update.Name = "btn_medi_usage2_update"
        Me.btn_medi_usage2_update.Size = New System.Drawing.Size(99, 33)
        Me.btn_medi_usage2_update.TabIndex = 9
        Me.btn_medi_usage2_update.Text = "更新"
        Me.btn_medi_usage2_update.UseVisualStyleBackColor = True
        '
        'btn_medi_unit_del
        '
        Me.btn_medi_unit_del.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medi_unit_del.Location = New System.Drawing.Point(206, 369)
        Me.btn_medi_unit_del.Name = "btn_medi_unit_del"
        Me.btn_medi_unit_del.Size = New System.Drawing.Size(99, 33)
        Me.btn_medi_unit_del.TabIndex = 10
        Me.btn_medi_unit_del.Text = "删除"
        Me.btn_medi_unit_del.UseVisualStyleBackColor = True
        '
        'btn_medi_unit_update
        '
        Me.btn_medi_unit_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_medi_unit_update.Location = New System.Drawing.Point(67, 369)
        Me.btn_medi_unit_update.Name = "btn_medi_unit_update"
        Me.btn_medi_unit_update.Size = New System.Drawing.Size(99, 33)
        Me.btn_medi_unit_update.TabIndex = 9
        Me.btn_medi_unit_update.Text = "更新"
        Me.btn_medi_unit_update.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1364, 683)
        Me.Controls.Add(Me.TabControl_admin)
        Me.Name = "frmAdmin"
        Me.Text = "系统管理员"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl_admin.ResumeLayout(False)
        Me.TabPage_add_staff.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage_staff_management.ResumeLayout(False)
        CType(Me.DataGridView_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_guahao_management.ResumeLayout(False)
        CType(Me.DataGridView_Guahao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_feeItem1_add.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage_feeItem1.ResumeLayout(False)
        CType(Me.DataGridView_FeeItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_usage1.ResumeLayout(False)
        CType(Me.DataGridView_medi_usage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_usage2.ResumeLayout(False)
        Me.TabPage_use_unit.ResumeLayout(False)
        CType(Me.DataGridView_medi_usage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_medi_use_unit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl_admin As TabControl
    Friend WithEvents TabPage_add_staff As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents cmb_Usertype As ComboBox
    Friend WithEvents txtWork_date As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage_staff_management As TabPage
    Friend WithEvents DataGridView_user As DataGridView
    Friend WithEvents TabPage_guahao_management As TabPage
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView_Guahao As DataGridView
    Friend WithEvents TabPage_feeItem1_add As TabPage
    Friend WithEvents TabPage_feeItem1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_FeeItem1_OK As Button
    Friend WithEvents txtFeeItem1_price As TextBox
    Friend WithEvents txtFeeItem1_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFeeItem1_remark As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents DataGridView_FeeItem1 As DataGridView
    Friend WithEvents btnStaff_update As Button
    Friend WithEvents btnStaff_del As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_feeitem_type As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage_usage1 As TabPage
    Friend WithEvents DataGridView_medi_usage1 As DataGridView
    Friend WithEvents TabPage_usage2 As TabPage
    Friend WithEvents TabPage_use_unit As TabPage
    Friend WithEvents btn_medi_usage1_update As Button
    Friend WithEvents btn_medi_usage1_del As Button
    Friend WithEvents btn_medi_usage2_del As Button
    Friend WithEvents btn_medi_usage2_update As Button
    Friend WithEvents DataGridView_medi_usage2 As DataGridView
    Friend WithEvents btn_medi_unit_del As Button
    Friend WithEvents btn_medi_unit_update As Button
    Friend WithEvents DataGridView_medi_use_unit As DataGridView
End Class
