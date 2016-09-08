Imports System.Data
Imports System.Data.SqlClient


Public Class frmLogin
    Private conn As New SqlConnection
    Private DaAdap As New SqlDataAdapter
    Private DaSet As New DataSet
    Private cmb As New SqlCommandBuilder
    Private DaTable As DataTable
    Private sql As String
    Private intRowPosition As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbLogin_type.Text = "------请选择------" Then
            MessageBox.Show("请选择'类型'!!!")
        ElseIf txtLogin_password.Text = "" Then
            MessageBox.Show("请输入登录'密码'!!!")
        Else
            '******* Remembering the username ******************
            My.Settings.username = cmbLogin_username.Text
            My.Settings.Save()
            '******* End Remembering the username ******************

            sql = "select * from staff where staff_status='有效' and staff_name='" & cmbLogin_username.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            If txtLogin_password.Text = DaTable.Rows(intRowPosition)("staff_password").ToString() Then
                If cmbLogin_type.Text = "收银员" Then
                    Dim formCashier As New frmCashier
                    formCashier.ShowDialog()
                ElseIf cmbLogin_type.Text = "医生" Then
                    Dim formDoctorMain As New frmDoctorMain
                    formDoctorMain.ShowDialog()
                ElseIf cmbLogin_type.Text = "药物管理员" Then
                    Dim formMedicineMain As New frmMedicineMain
                    formMedicineMain.ShowDialog()
                ElseIf cmbLogin_type.Text = "系统管理员" Then
                    Dim formAdmin As New frmAdmin
                    formAdmin.ShowDialog()
                Else
                    MessageBox.Show("选择类型错误！")
                End If

            Else
                MsgBox("密码错误！", MsgBoxStyle.Critical, "无效")
            End If
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbLogin_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLogin_type.SelectedIndexChanged
        sql = "select * from staff where staff_status='有效' and job_type='" & cmbLogin_type.Text & "'"
        DaAdap = New SqlDataAdapter(sql, conn)
        cmb = New SqlCommandBuilder(DaAdap)
        DaTable = New DataTable
        DaAdap.Fill(DaTable)
        cmbLogin_username.DataSource = DaTable
        cmbLogin_username.DisplayMember = "staff_name"

    End Sub

    Private Sub frmLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub btnLoginExit_Click(sender As Object, e As EventArgs) Handles btnLoginExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim From_print_testing As New Frm_print_testing
        From_print_testing.ShowDialog()
    End Sub
End Class
