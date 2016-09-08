<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrescription
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGuahao_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDoctor_Contact = New System.Windows.Forms.TextBox()
        Me.txtDoctor_Age = New System.Windows.Forms.TextBox()
        Me.txtDoctor_PID = New System.Windows.Forms.TextBox()
        Me.txtDoctor_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectOK = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delRows = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView_m2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView_m1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox_prescriptionRemark = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_fee4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_fee4 = New System.Windows.Forms.TextBox()
        Me.CheckBox_fee4 = New System.Windows.Forms.CheckBox()
        Me.ComboBox_fee3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_fee3 = New System.Windows.Forms.TextBox()
        Me.CheckBox_fee3 = New System.Windows.Forms.CheckBox()
        Me.ComboBox_fee2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_fee2 = New System.Windows.Forms.TextBox()
        Me.CheckBox_fee2 = New System.Windows.Forms.CheckBox()
        Me.ComboBox_fee1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_fee1 = New System.Windows.Forms.TextBox()
        Me.CheckBox_fee1 = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.fee1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fee2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_m2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_m1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_prescriptionRemark.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSex)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtGuahao_ID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDoctor_Contact)
        Me.GroupBox1.Controls.Add(Me.txtDoctor_Age)
        Me.GroupBox1.Controls.Add(Me.txtDoctor_PID)
        Me.GroupBox1.Controls.Add(Me.txtDoctor_Name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本信息"
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSex.Enabled = False
        Me.txtSex.Location = New System.Drawing.Point(100, 78)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(133, 25)
        Me.txtSex.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "性别"
        '
        'txtGuahao_ID
        '
        Me.txtGuahao_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuahao_ID.Enabled = False
        Me.txtGuahao_ID.Location = New System.Drawing.Point(362, 78)
        Me.txtGuahao_ID.Name = "txtGuahao_ID"
        Me.txtGuahao_ID.Size = New System.Drawing.Size(133, 25)
        Me.txtGuahao_ID.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "挂号ID"
        '
        'txtDoctor_Contact
        '
        Me.txtDoctor_Contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctor_Contact.Enabled = False
        Me.txtDoctor_Contact.Location = New System.Drawing.Point(362, 52)
        Me.txtDoctor_Contact.Name = "txtDoctor_Contact"
        Me.txtDoctor_Contact.Size = New System.Drawing.Size(133, 25)
        Me.txtDoctor_Contact.TabIndex = 7
        '
        'txtDoctor_Age
        '
        Me.txtDoctor_Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctor_Age.Enabled = False
        Me.txtDoctor_Age.Location = New System.Drawing.Point(362, 26)
        Me.txtDoctor_Age.Name = "txtDoctor_Age"
        Me.txtDoctor_Age.Size = New System.Drawing.Size(133, 25)
        Me.txtDoctor_Age.TabIndex = 6
        '
        'txtDoctor_PID
        '
        Me.txtDoctor_PID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctor_PID.Enabled = False
        Me.txtDoctor_PID.Location = New System.Drawing.Point(100, 51)
        Me.txtDoctor_PID.Name = "txtDoctor_PID"
        Me.txtDoctor_PID.Size = New System.Drawing.Size(133, 25)
        Me.txtDoctor_PID.TabIndex = 5
        '
        'txtDoctor_Name
        '
        Me.txtDoctor_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctor_Name.Enabled = False
        Me.txtDoctor_Name.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor_Name.Location = New System.Drawing.Point(100, 25)
        Me.txtDoctor_Name.Name = "txtDoctor_Name"
        Me.txtDoctor_Name.Size = New System.Drawing.Size(133, 25)
        Me.txtDoctor_Name.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "联系电话"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "年龄"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "身份证"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "姓名"
        '
        'btnSelectOK
        '
        Me.btnSelectOK.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSelectOK.Location = New System.Drawing.Point(1035, 652)
        Me.btnSelectOK.Name = "btnSelectOK"
        Me.btnSelectOK.Size = New System.Drawing.Size(206, 39)
        Me.btnSelectOK.TabIndex = 5
        Me.btnSelectOK.Text = ">>>　确认处方　<<<"
        Me.btnSelectOK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delRows)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.DataGridView_m2)
        Me.GroupBox2.Controls.Add(Me.DataGridView_m1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1346, 471)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "药品选择器"
        '
        'btn_delRows
        '
        Me.btn_delRows.Location = New System.Drawing.Point(493, 176)
        Me.btn_delRows.Name = "btn_delRows"
        Me.btn_delRows.Size = New System.Drawing.Size(43, 24)
        Me.btn_delRows.TabIndex = 8
        Me.btn_delRows.Text = "删除<<"
        Me.btn_delRows.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(10, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(477, 25)
        Me.txtSearch.TabIndex = 7
        '
        'DataGridView_m2
        '
        Me.DataGridView_m2.AllowUserToAddRows = False
        Me.DataGridView_m2.AllowUserToDeleteRows = False
        Me.DataGridView_m2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_m2.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_m2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_m2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6, Me.Column7, Me.Column8, Me.storage})
        Me.DataGridView_m2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView_m2.Location = New System.Drawing.Point(540, 60)
        Me.DataGridView_m2.Name = "DataGridView_m2"
        Me.DataGridView_m2.RowHeadersVisible = False
        Me.DataGridView_m2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_m2.Size = New System.Drawing.Size(786, 393)
        Me.DataGridView_m2.TabIndex = 6
        '
        'DataGridView_m1
        '
        Me.DataGridView_m1.AllowUserToAddRows = False
        Me.DataGridView_m1.AllowUserToDeleteRows = False
        Me.DataGridView_m1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_m1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_m1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_m1.Location = New System.Drawing.Point(10, 60)
        Me.DataGridView_m1.Name = "DataGridView_m1"
        Me.DataGridView_m1.ReadOnly = True
        Me.DataGridView_m1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_m1.Size = New System.Drawing.Size(477, 393)
        Me.DataGridView_m1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = ">>>>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox_prescriptionRemark
        '
        Me.GroupBox_prescriptionRemark.Controls.Add(Me.txtRemark)
        Me.GroupBox_prescriptionRemark.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_prescriptionRemark.Location = New System.Drawing.Point(148, 693)
        Me.GroupBox_prescriptionRemark.Name = "GroupBox_prescriptionRemark"
        Me.GroupBox_prescriptionRemark.Size = New System.Drawing.Size(464, 58)
        Me.GroupBox_prescriptionRemark.TabIndex = 10
        Me.GroupBox_prescriptionRemark.TabStop = False
        Me.GroupBox_prescriptionRemark.Text = "处方描述"
        '
        'txtRemark
        '
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(25, 21)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(413, 25)
        Me.txtRemark.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox_fee4)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txt_fee4)
        Me.GroupBox4.Controls.Add(Me.CheckBox_fee4)
        Me.GroupBox4.Controls.Add(Me.ComboBox_fee3)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txt_fee3)
        Me.GroupBox4.Controls.Add(Me.CheckBox_fee3)
        Me.GroupBox4.Controls.Add(Me.ComboBox_fee2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txt_fee2)
        Me.GroupBox4.Controls.Add(Me.CheckBox_fee2)
        Me.GroupBox4.Controls.Add(Me.ComboBox_fee1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txt_fee1)
        Me.GroupBox4.Controls.Add(Me.CheckBox_fee1)
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(605, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(610, 147)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "其他收费项"
        '
        'ComboBox_fee4
        '
        Me.ComboBox_fee4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_fee4.FormattingEnabled = True
        Me.ComboBox_fee4.Location = New System.Drawing.Point(407, 111)
        Me.ComboBox_fee4.Name = "ComboBox_fee4"
        Me.ComboBox_fee4.Size = New System.Drawing.Size(105, 25)
        Me.ComboBox_fee4.TabIndex = 27
        Me.ComboBox_fee4.Text = "---- 请选择 ---"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(578, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "元"
        '
        'txt_fee4
        '
        Me.txt_fee4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fee4.Enabled = False
        Me.txt_fee4.Location = New System.Drawing.Point(523, 112)
        Me.txt_fee4.Name = "txt_fee4"
        Me.txt_fee4.Size = New System.Drawing.Size(53, 25)
        Me.txt_fee4.TabIndex = 24
        '
        'CheckBox_fee4
        '
        Me.CheckBox_fee4.AutoSize = True
        Me.CheckBox_fee4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox_fee4.Location = New System.Drawing.Point(336, 112)
        Me.CheckBox_fee4.Name = "CheckBox_fee4"
        Me.CheckBox_fee4.Size = New System.Drawing.Size(65, 23)
        Me.CheckBox_fee4.TabIndex = 25
        Me.CheckBox_fee4.Text = "费用4:"
        Me.CheckBox_fee4.UseVisualStyleBackColor = True
        '
        'ComboBox_fee3
        '
        Me.ComboBox_fee3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_fee3.FormattingEnabled = True
        Me.ComboBox_fee3.Location = New System.Drawing.Point(407, 82)
        Me.ComboBox_fee3.Name = "ComboBox_fee3"
        Me.ComboBox_fee3.Size = New System.Drawing.Size(105, 25)
        Me.ComboBox_fee3.TabIndex = 23
        Me.ComboBox_fee3.Text = "---- 请选择 ---"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(578, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "元"
        '
        'txt_fee3
        '
        Me.txt_fee3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fee3.Enabled = False
        Me.txt_fee3.Location = New System.Drawing.Point(523, 83)
        Me.txt_fee3.Name = "txt_fee3"
        Me.txt_fee3.Size = New System.Drawing.Size(53, 25)
        Me.txt_fee3.TabIndex = 20
        '
        'CheckBox_fee3
        '
        Me.CheckBox_fee3.AutoSize = True
        Me.CheckBox_fee3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox_fee3.Location = New System.Drawing.Point(336, 83)
        Me.CheckBox_fee3.Name = "CheckBox_fee3"
        Me.CheckBox_fee3.Size = New System.Drawing.Size(65, 23)
        Me.CheckBox_fee3.TabIndex = 21
        Me.CheckBox_fee3.Text = "费用3:"
        Me.CheckBox_fee3.UseVisualStyleBackColor = True
        '
        'ComboBox_fee2
        '
        Me.ComboBox_fee2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_fee2.FormattingEnabled = True
        Me.ComboBox_fee2.Location = New System.Drawing.Point(407, 53)
        Me.ComboBox_fee2.Name = "ComboBox_fee2"
        Me.ComboBox_fee2.Size = New System.Drawing.Size(105, 25)
        Me.ComboBox_fee2.TabIndex = 19
        Me.ComboBox_fee2.Text = "---- 请选择 ---"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(578, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "元"
        '
        'txt_fee2
        '
        Me.txt_fee2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fee2.Enabled = False
        Me.txt_fee2.Location = New System.Drawing.Point(523, 54)
        Me.txt_fee2.Name = "txt_fee2"
        Me.txt_fee2.Size = New System.Drawing.Size(53, 25)
        Me.txt_fee2.TabIndex = 16
        '
        'CheckBox_fee2
        '
        Me.CheckBox_fee2.AutoSize = True
        Me.CheckBox_fee2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox_fee2.Location = New System.Drawing.Point(336, 54)
        Me.CheckBox_fee2.Name = "CheckBox_fee2"
        Me.CheckBox_fee2.Size = New System.Drawing.Size(65, 23)
        Me.CheckBox_fee2.TabIndex = 17
        Me.CheckBox_fee2.Text = "费用2:"
        Me.CheckBox_fee2.UseVisualStyleBackColor = True
        '
        'ComboBox_fee1
        '
        Me.ComboBox_fee1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox_fee1.FormattingEnabled = True
        Me.ComboBox_fee1.Location = New System.Drawing.Point(407, 24)
        Me.ComboBox_fee1.Name = "ComboBox_fee1"
        Me.ComboBox_fee1.Size = New System.Drawing.Size(105, 25)
        Me.ComboBox_fee1.TabIndex = 15
        Me.ComboBox_fee1.Text = "---- 请选择 ---"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(578, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "元"
        '
        'txt_fee1
        '
        Me.txt_fee1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fee1.Enabled = False
        Me.txt_fee1.Location = New System.Drawing.Point(523, 25)
        Me.txt_fee1.Name = "txt_fee1"
        Me.txt_fee1.Size = New System.Drawing.Size(53, 25)
        Me.txt_fee1.TabIndex = 12
        '
        'CheckBox_fee1
        '
        Me.CheckBox_fee1.AutoSize = True
        Me.CheckBox_fee1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox_fee1.Location = New System.Drawing.Point(336, 25)
        Me.CheckBox_fee1.Name = "CheckBox_fee1"
        Me.CheckBox_fee1.Size = New System.Drawing.Size(65, 23)
        Me.CheckBox_fee1.TabIndex = 13
        Me.CheckBox_fee1.Text = "费用1:"
        Me.CheckBox_fee1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.SkyBlue
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.fee1, Me.fee2})
        Me.ListView1.ForeColor = System.Drawing.Color.DarkBlue
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(30, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(238, 105)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'fee1
        '
        Me.fee1.Text = "收费项"
        Me.fee1.Width = 250
        '
        'fee2
        '
        Me.fee2.Text = "价格"
        '
        'Column1
        '
        Me.Column1.FillWeight = 27.47858!
        Me.Column1.HeaderText = "药名"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.FillWeight = 3.075121!
        Me.Column2.HeaderText = "单位"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.FillWeight = 16.89551!
        Me.Column3.HeaderText = "单价"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.FillWeight = 26.94587!
        Me.Column5.HeaderText = "规格"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 4.346648!
        Me.Column4.HeaderText = "数量"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.FillWeight = 38.23433!
        Me.Column6.HeaderText = "用法"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.FillWeight = 9.177974!
        Me.Column7.HeaderText = "用药途径"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.FillWeight = 9.177974!
        Me.Column8.HeaderText = "用量"
        Me.Column8.Name = "Column8"
        '
        'storage
        '
        Me.storage.HeaderText = "库存量"
        Me.storage.Name = "storage"
        Me.storage.Visible = False
        '
        'frmPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1370, 724)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox_prescriptionRemark)
        Me.Controls.Add(Me.btnSelectOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmPrescription"
        Me.Text = "医生开处方"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView_m2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_m1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_prescriptionRemark.ResumeLayout(False)
        Me.GroupBox_prescriptionRemark.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDoctor_Contact As TextBox
    Friend WithEvents txtDoctor_Age As TextBox
    Friend WithEvents txtDoctor_PID As TextBox
    Friend WithEvents txtDoctor_Name As TextBox
    Friend WithEvents txtGuahao_ID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSelectOK As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_m2 As DataGridView
    Friend WithEvents DataGridView_m1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btn_delRows As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox_prescriptionRemark As GroupBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents fee1 As ColumnHeader
    Friend WithEvents fee2 As ColumnHeader
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_fee4 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_fee4 As TextBox
    Friend WithEvents CheckBox_fee4 As CheckBox
    Friend WithEvents ComboBox_fee3 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_fee3 As TextBox
    Friend WithEvents CheckBox_fee3 As CheckBox
    Friend WithEvents ComboBox_fee2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_fee2 As TextBox
    Friend WithEvents CheckBox_fee2 As CheckBox
    Friend WithEvents ComboBox_fee1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_fee1 As TextBox
    Friend WithEvents CheckBox_fee1 As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents storage As DataGridViewTextBoxColumn
End Class
