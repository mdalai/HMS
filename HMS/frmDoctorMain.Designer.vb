<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDoctorMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl_doctor = New System.Windows.Forms.TabControl()
        Me.TabPage_prescription = New System.Windows.Forms.TabPage()
        Me.btnRefresh_prescription = New System.Windows.Forms.Button()
        Me.btnDoctor = New System.Windows.Forms.Button()
        Me.DataGridView_doctor = New System.Windows.Forms.DataGridView()
        Me.TabPage_Check = New System.Windows.Forms.TabPage()
        Me.txtGID_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuahao_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGuahao_search = New System.Windows.Forms.TextBox()
        Me.btnRefresh_prescriptionCheck = New System.Windows.Forms.Button()
        Me.btn_check_prescription = New System.Windows.Forms.Button()
        Me.DataGridView_prescription = New System.Windows.Forms.DataGridView()
        Me.TabControl_doctor.SuspendLayout()
        Me.TabPage_prescription.SuspendLayout()
        CType(Me.DataGridView_doctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Check.SuspendLayout()
        CType(Me.DataGridView_prescription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_doctor
        '
        Me.TabControl_doctor.Controls.Add(Me.TabPage_prescription)
        Me.TabControl_doctor.Controls.Add(Me.TabPage_Check)
        Me.TabControl_doctor.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl_doctor.Location = New System.Drawing.Point(39, 12)
        Me.TabControl_doctor.Name = "TabControl_doctor"
        Me.TabControl_doctor.SelectedIndex = 0
        Me.TabControl_doctor.Size = New System.Drawing.Size(1250, 630)
        Me.TabControl_doctor.TabIndex = 0
        '
        'TabPage_prescription
        '
        Me.TabPage_prescription.Controls.Add(Me.btnRefresh_prescription)
        Me.TabPage_prescription.Controls.Add(Me.btnDoctor)
        Me.TabPage_prescription.Controls.Add(Me.DataGridView_doctor)
        Me.TabPage_prescription.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_prescription.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_prescription.Name = "TabPage_prescription"
        Me.TabPage_prescription.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_prescription.Size = New System.Drawing.Size(1242, 595)
        Me.TabPage_prescription.TabIndex = 0
        Me.TabPage_prescription.Text = "处方"
        Me.TabPage_prescription.UseVisualStyleBackColor = True
        '
        'btnRefresh_prescription
        '
        Me.btnRefresh_prescription.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_prescription.Location = New System.Drawing.Point(25, 13)
        Me.btnRefresh_prescription.Name = "btnRefresh_prescription"
        Me.btnRefresh_prescription.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_prescription.TabIndex = 9
        Me.btnRefresh_prescription.Text = ">> 刷新 >>"
        Me.btnRefresh_prescription.UseVisualStyleBackColor = True
        '
        'btnDoctor
        '
        Me.btnDoctor.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctor.Location = New System.Drawing.Point(1070, 46)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.Size = New System.Drawing.Size(114, 27)
        Me.btnDoctor.TabIndex = 2
        Me.btnDoctor.Text = ">> 开处方 >>"
        Me.btnDoctor.UseVisualStyleBackColor = True
        '
        'DataGridView_doctor
        '
        Me.DataGridView_doctor.AllowUserToAddRows = False
        Me.DataGridView_doctor.AllowUserToDeleteRows = False
        Me.DataGridView_doctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_doctor.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_doctor.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_doctor.Location = New System.Drawing.Point(25, 46)
        Me.DataGridView_doctor.MultiSelect = False
        Me.DataGridView_doctor.Name = "DataGridView_doctor"
        Me.DataGridView_doctor.ReadOnly = True
        Me.DataGridView_doctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_doctor.Size = New System.Drawing.Size(1025, 535)
        Me.DataGridView_doctor.TabIndex = 1
        '
        'TabPage_Check
        '
        Me.TabPage_Check.Controls.Add(Me.txtGID_search)
        Me.TabPage_Check.Controls.Add(Me.Label2)
        Me.TabPage_Check.Controls.Add(Me.btnGuahao_search)
        Me.TabPage_Check.Controls.Add(Me.Label1)
        Me.TabPage_Check.Controls.Add(Me.txtGuahao_search)
        Me.TabPage_Check.Controls.Add(Me.btnRefresh_prescriptionCheck)
        Me.TabPage_Check.Controls.Add(Me.btn_check_prescription)
        Me.TabPage_Check.Controls.Add(Me.DataGridView_prescription)
        Me.TabPage_Check.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage_Check.Location = New System.Drawing.Point(4, 31)
        Me.TabPage_Check.Name = "TabPage_Check"
        Me.TabPage_Check.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Check.Size = New System.Drawing.Size(1242, 595)
        Me.TabPage_Check.TabIndex = 1
        Me.TabPage_Check.Text = "查看处方"
        Me.TabPage_Check.UseVisualStyleBackColor = True
        '
        'txtGID_search
        '
        Me.txtGID_search.Location = New System.Drawing.Point(546, 15)
        Me.txtGID_search.Name = "txtGID_search"
        Me.txtGID_search.Size = New System.Drawing.Size(61, 25)
        Me.txtGID_search.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "挂号ID："
        '
        'btnGuahao_search
        '
        Me.btnGuahao_search.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuahao_search.Location = New System.Drawing.Point(660, 13)
        Me.btnGuahao_search.Name = "btnGuahao_search"
        Me.btnGuahao_search.Size = New System.Drawing.Size(75, 25)
        Me.btnGuahao_search.TabIndex = 19
        Me.btnGuahao_search.Text = "搜索"
        Me.btnGuahao_search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "请输入姓名查询："
        '
        'txtGuahao_search
        '
        Me.txtGuahao_search.Location = New System.Drawing.Point(282, 17)
        Me.txtGuahao_search.Name = "txtGuahao_search"
        Me.txtGuahao_search.Size = New System.Drawing.Size(136, 25)
        Me.txtGuahao_search.TabIndex = 17
        '
        'btnRefresh_prescriptionCheck
        '
        Me.btnRefresh_prescriptionCheck.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_prescriptionCheck.Location = New System.Drawing.Point(20, 15)
        Me.btnRefresh_prescriptionCheck.Name = "btnRefresh_prescriptionCheck"
        Me.btnRefresh_prescriptionCheck.Size = New System.Drawing.Size(100, 27)
        Me.btnRefresh_prescriptionCheck.TabIndex = 10
        Me.btnRefresh_prescriptionCheck.Text = ">> 刷新 >>"
        Me.btnRefresh_prescriptionCheck.UseVisualStyleBackColor = True
        '
        'btn_check_prescription
        '
        Me.btn_check_prescription.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check_prescription.Location = New System.Drawing.Point(956, 48)
        Me.btn_check_prescription.Name = "btn_check_prescription"
        Me.btn_check_prescription.Size = New System.Drawing.Size(126, 27)
        Me.btn_check_prescription.TabIndex = 6
        Me.btn_check_prescription.Text = ">> 查看处方 <<"
        Me.btn_check_prescription.UseVisualStyleBackColor = True
        '
        'DataGridView_prescription
        '
        Me.DataGridView_prescription.AllowUserToAddRows = False
        Me.DataGridView_prescription.AllowUserToDeleteRows = False
        Me.DataGridView_prescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_prescription.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_prescription.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_prescription.Location = New System.Drawing.Point(20, 48)
        Me.DataGridView_prescription.MultiSelect = False
        Me.DataGridView_prescription.Name = "DataGridView_prescription"
        Me.DataGridView_prescription.ReadOnly = True
        Me.DataGridView_prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_prescription.Size = New System.Drawing.Size(908, 534)
        Me.DataGridView_prescription.TabIndex = 3
        '
        'frmDoctorMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1364, 670)
        Me.Controls.Add(Me.TabControl_doctor)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDoctorMain"
        Me.Text = "医生工作平台"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl_doctor.ResumeLayout(False)
        Me.TabPage_prescription.ResumeLayout(False)
        CType(Me.DataGridView_doctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Check.ResumeLayout(False)
        Me.TabPage_Check.PerformLayout()
        CType(Me.DataGridView_prescription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl_doctor As TabControl
    Friend WithEvents TabPage_prescription As TabPage
    Friend WithEvents TabPage_Check As TabPage
    Friend WithEvents DataGridView_doctor As DataGridView
    Friend WithEvents btnDoctor As Button
    Friend WithEvents DataGridView_prescription As DataGridView
    Friend WithEvents btn_check_prescription As Button
    Friend WithEvents btnRefresh_prescription As Button
    Friend WithEvents btnRefresh_prescriptionCheck As Button
    Friend WithEvents txtGuahao_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuahao_search As Button
    Friend WithEvents txtGID_search As TextBox
    Friend WithEvents Label2 As Label
End Class
