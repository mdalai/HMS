<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.cmbLogin_username = New System.Windows.Forms.ComboBox()
        Me.btnLoginExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cmbLogin_type = New System.Windows.Forms.ComboBox()
        Me.txtLogin_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbLogin
        '
        Me.gbLogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbLogin.Controls.Add(Me.cmbLogin_username)
        Me.gbLogin.Controls.Add(Me.btnLoginExit)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.cmbLogin_type)
        Me.gbLogin.Controls.Add(Me.txtLogin_password)
        Me.gbLogin.Controls.Add(Me.Label3)
        Me.gbLogin.Controls.Add(Me.Label2)
        Me.gbLogin.Controls.Add(Me.Label1)
        Me.gbLogin.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.gbLogin.Location = New System.Drawing.Point(557, 125)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(380, 230)
        Me.gbLogin.TabIndex = 0
        Me.gbLogin.TabStop = False
        Me.gbLogin.Text = "请登录"
        '
        'cmbLogin_username
        '
        Me.cmbLogin_username.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLogin_username.FormattingEnabled = True
        Me.cmbLogin_username.Location = New System.Drawing.Point(131, 84)
        Me.cmbLogin_username.Name = "cmbLogin_username"
        Me.cmbLogin_username.Size = New System.Drawing.Size(167, 29)
        Me.cmbLogin_username.TabIndex = 8
        '
        'btnLoginExit
        '
        Me.btnLoginExit.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginExit.Location = New System.Drawing.Point(223, 175)
        Me.btnLoginExit.Name = "btnLoginExit"
        Me.btnLoginExit.Size = New System.Drawing.Size(75, 38)
        Me.btnLoginExit.TabIndex = 7
        Me.btnLoginExit.Text = "退出"
        Me.btnLoginExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(131, 175)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 38)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "登录"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'cmbLogin_type
        '
        Me.cmbLogin_type.AllowDrop = True
        Me.cmbLogin_type.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbLogin_type.FormattingEnabled = True
        Me.cmbLogin_type.Items.AddRange(New Object() {"收银员", "医生", "药物管理员", "系统管理员"})
        Me.cmbLogin_type.Location = New System.Drawing.Point(131, 46)
        Me.cmbLogin_type.Name = "cmbLogin_type"
        Me.cmbLogin_type.Size = New System.Drawing.Size(167, 29)
        Me.cmbLogin_type.TabIndex = 5
        Me.cmbLogin_type.Text = "------请选择------"
        '
        'txtLogin_password
        '
        Me.txtLogin_password.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin_password.Location = New System.Drawing.Point(131, 122)
        Me.txtLogin_password.Name = "txtLogin_password"
        Me.txtLogin_password.Size = New System.Drawing.Size(167, 29)
        Me.txtLogin_password.TabIndex = 4
        Me.txtLogin_password.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "密码:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "用户名:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "类型:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(169, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 381)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Text = "桑根达来镇中心卫生院"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents btnLoginExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents cmbLogin_type As ComboBox
    Friend WithEvents txtLogin_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbLogin_username As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
