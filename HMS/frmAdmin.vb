Imports System.Data
Imports System.Data.SqlClient

Public Class frmAdmin
    Private conn As New SqlConnection
    Private DaAdap1 As SqlDataAdapter
    Private DaAdap2 As SqlDataAdapter
    Private DaSet As New DataSet
    Private cmb As SqlCommandBuilder
    Private DaTable1 As DataTable
    Private DaTable2 As DataTable
    Private sql1 As String
    Private sql2 As String

    Private DaAdap_f As SqlDataAdapter
    Private DaTable_f As DataTable
    Private DaSet_f As New DataSet
    Private cmb_f As SqlCommandBuilder
    Private sql_f As String
    Private f_id As Integer = Nothing
    Private staff_id As Integer = Nothing

    Private DaAdap_mu1 As SqlDataAdapter
    Private DaSet_mu1 As New DataSet
    Private cmb_mu1 As SqlCommandBuilder
    Private sql_mu1 As String

    Private DaAdap_mu2 As SqlDataAdapter
    Private DaSet_mu2 As New DataSet
    Private cmb_mu2 As SqlCommandBuilder
    Private sql_mu2 As String

    Private DaAdap_mu3 As SqlDataAdapter
    Private DaSet_mu3 As New DataSet
    Private cmb_mu3 As SqlCommandBuilder
    Private sql_mu3 As String



    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()

            sql_mu1 = "select * from medi_usage1 "
            DaAdap_mu1 = New SqlDataAdapter(sql_mu1, conn)
            cmb_mu1 = New SqlCommandBuilder(DaAdap_mu1)
            DaAdap_mu1.Fill(DaSet_mu1, "medi_usage1")
            DataGridView_medi_usage1.DataSource = DaSet_mu1.Tables("medi_usage1")

            With DataGridView_medi_usage1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(1).HeaderCell.Value = "用法"
            End With

            sql_mu2 = "select * from medi_usage2 "
            DaAdap_mu2 = New SqlDataAdapter(sql_mu2, conn)
            cmb_mu2 = New SqlCommandBuilder(DaAdap_mu2)
            DaAdap_mu2.Fill(DaSet_mu2, "medi_usage2")
            DataGridView_medi_usage2.DataSource = DaSet_mu2.Tables("medi_usage2")

            With DataGridView_medi_usage2
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(1).HeaderCell.Value = "服用"
            End With

            sql_mu3 = "select * from medi_use_unit "
            DaAdap_mu3 = New SqlDataAdapter(sql_mu3, conn)
            cmb_mu3 = New SqlCommandBuilder(DaAdap_mu3)
            DaAdap_mu3.Fill(DaSet_mu3, "medi_use_unit")
            DataGridView_medi_use_unit.DataSource = DaSet_mu3.Tables("medi_use_unit")

            With DataGridView_medi_use_unit
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(1).HeaderCell.Value = "用量"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmb_Usertype.Text = "" Then
            MessageBox.Show("用户名、密码和用户类别必须都填写！！")
        Else
            sql1 = "select staff_id,staff_name,staff_password,job_type,department,work_date,remark,created_date,staff_status from staff where staff_status='有效' "
            DaAdap1 = New SqlDataAdapter(sql1, conn)
            cmb = New SqlCommandBuilder(DaAdap1)
            DaAdap1.FillSchema(DaSet, SchemaType.Source, "staff")
            DaAdap1.Fill(DaSet, "staff")

            DaTable1 = New DataTable
            DaAdap1.Fill(DaTable1)
            DaAdap1.FillSchema(DaSet, SchemaType.Source, "staff")
            DaAdap1.Fill(DaSet, "staff")
            DataGridView_user.DataSource = DaTable1

            If staff_id = Nothing Then
                Dim drNewRow As DataRow = DaTable1.NewRow()
                drNewRow("staff_name") = txtUsername.Text
                drNewRow("staff_password") = txtPassword.Text
                drNewRow("job_type") = cmb_Usertype.Text
                drNewRow("department") = txtDepartment.Text
                drNewRow("work_date") = txtWork_date.Text
                drNewRow("remark") = txtRemark.Text
                drNewRow("created_date") = DateTime.Now
                drNewRow("staff_status") = "有效"
                DaTable1.Rows.Add(drNewRow)
            Else
                Dim currentRow As DataRow = DaSet.Tables("staff").Rows.Find(staff_id) 'Find in the primary key
                currentRow.BeginEdit()
                currentRow("staff_password") = txtPassword.Text
                currentRow("job_type") = cmb_Usertype.Text
                currentRow("department") = txtDepartment.Text
                currentRow("work_date") = txtWork_date.Text
                currentRow("remark") = txtRemark.Text
                currentRow.EndEdit()
            End If
            DaAdap1.Update(DaTable1)


            txtUsername.Text = ""
                txtPassword.Text = ""
                txtDepartment.Text = ""
                txtWork_date.Text = ""
                txtRemark.Text = ""

                Me.DataGridView_user.Refresh()
                '*****************
                'BEGIN SEND CHANGES TO SQL SERVER
                'Dim cmb As New SqlCommandBuilder(DaAdap1)
                DaAdap1.Update(DaSet, "staff")
            'MsgBox("SQL Server updated successfully")
            '*****************
            MessageBox.Show("操作成功!!")

        End If
    End Sub

    Private Sub TabControl_admin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_admin.SelectedIndexChanged
        Select Case TabControl_admin.SelectedIndex

            Case 0
                txtUsername.Enabled = True
                txtUsername.Text = ""
                txtPassword.Text = ""
                cmb_Usertype.Text = ""
                txtDepartment.Text = ""
                txtWork_date.Text = ""
                txtRemark.Text = ""

            Case 1 ' User clicks on Second Tab
                sql1 = "select staff_id,staff_name,staff_password,job_type,department,work_date,remark from staff where staff_status='有效' "
                DaAdap1 = New SqlDataAdapter(sql1, conn)
                cmb = New SqlCommandBuilder(DaAdap1)
                DaAdap1.FillSchema(DaSet, SchemaType.Source, "staff")
                DaAdap1.Fill(DaSet, "staff")

                DaTable1 = New DataTable
                DaAdap1.Fill(DaTable1)
                DataGridView_user.DataSource = DaTable1

                With DataGridView_user
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "用户ID"
                    .Columns(1).HeaderCell.Value = "用户名"
                    .Columns(2).HeaderCell.Value = "用户密码"
                    .Columns(3).HeaderCell.Value = "用户类别"
                    .Columns(4).HeaderCell.Value = "科室"
                    .Columns(5).HeaderCell.Value = "入职日期"
                    .Columns(6).HeaderCell.Value = "注释"

                End With

            Case 2 ' User clicks on Third Tab 
                sql2 = "select * from patient_work"
                DaAdap2 = New SqlDataAdapter(sql2, conn)
                cmb = New SqlCommandBuilder(DaAdap2)
                DaAdap2.FillSchema(DaSet, SchemaType.Source, "patient_work")
                DaAdap2.Fill(DaSet, "patient_work")

                DaTable2 = New DataTable
                DaAdap2.Fill(DaTable2)
                DataGridView_Guahao.DataSource = DaTable2

                With DataGridView_Guahao
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 110
                    .Columns(3).HeaderCell.Value = "年龄"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "联系方式"
                    .Columns(5).HeaderCell.Value = "挂号医生"
                    .Columns(6).HeaderCell.Value = "状态"
                    .Columns(7).HeaderCell.Value = "挂号日期"
                    .Columns(8).HeaderCell.Value = "开处方日期"
                    .Columns(9).HeaderCell.Value = "收费日期"
                    .Columns(10).HeaderCell.Value = "取药日期"
                    .Columns(11).HeaderCell.Value = "收费额度"
                    .Columns(12).HeaderCell.Value = "发药者"
                    .Columns(13).HeaderCell.Value = "退药时间"
                    .Columns(14).HeaderCell.Value = "性别"
                End With

            Case 3
                txtFeeItem1_name.Enabled = True
                txtFeeItem1_name.Text = ""
                txtFeeItem1_price.Text = ""
                txtFeeItem1_remark.Text = ""
                cmb_feeitem_type.SelectedIndex = 0

            Case 4 ' User clicks on Fifth Tab
                '********** Begin FeeItem Management **************
                Try
                    sql_f = "select FID,feeitem_name,feeitem_price, feeitem_remark,
                              CASE feeitem_status WHEN '1' THEN '固定费用' WHEN '2' THEN '变动费用' END AS feeitem_status
                             from feeitem WHERE feeitem_status in('1','2') "
                    DaAdap_f = New SqlDataAdapter(sql_f, conn)
                    cmb_f = New SqlCommandBuilder(DaAdap_f)
                    DaTable_f = New DataTable
                    DaAdap_f.Fill(DaTable_f)
                    'DaAdap_f.FillSchema(DaSet_f, SchemaType.Source, "feeitem")
                    DaAdap_f.Fill(DaSet_f, "feeitem")
                    DataGridView_FeeItem1.DataSource = DaTable_f

                    With DataGridView_FeeItem1
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "ID"
                        .Columns(1).HeaderCell.Value = "收费项"
                        .Columns(2).HeaderCell.Value = "价格"
                        .Columns(3).HeaderCell.Value = "说明"
                        .Columns(4).HeaderCell.Value = "费用类别"
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                '********** End FeeItem Management **************


        End Select
    End Sub

    Private Sub frmAdmin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub btn_FeeItem1_OK_Click(sender As Object, e As EventArgs) Handles btn_FeeItem1_OK.Click
        If txtFeeItem1_name.Text = "" Or txtFeeItem1_price.Text = "" Then
            MessageBox.Show("请务必填写所有内容！！")
        Else
            Dim feeitem_status_value As String = ""
            If cmb_feeitem_type.Text = "变动费用" Then
                feeitem_status_value = 2
            Else
                feeitem_status_value = 1
            End If

            sql_f = "select * from Feeitem"
            DaAdap_f = New SqlDataAdapter(sql_f, conn)
            cmb_f = New SqlCommandBuilder(DaAdap_f)
            DaTable_f = New DataTable
            DaAdap_f.Fill(DaTable_f)
            DaAdap_f.FillSchema(DaSet_f, SchemaType.Source, "feeitem")
            DaAdap_f.Fill(DaSet_f, "feeitem")

            If f_id = Nothing Then
                Dim drNewRow As DataRow = DaTable_f.NewRow()
                drNewRow("feeitem_name") = txtFeeItem1_name.Text
                drNewRow("feeitem_price") = txtFeeItem1_price.Text
                drNewRow("feeitem_remark") = txtFeeItem1_remark.Text
                drNewRow("create_date") = DateTime.Now
                drNewRow("feeitem_status") = feeitem_status_value
                DaTable_f.Rows.Add(drNewRow)
            Else
                Dim currentRow As DataRow = DaSet_f.Tables("feeitem").Rows.Find(f_id) 'Find in the primary key
                currentRow.BeginEdit()
                currentRow("feeitem_name") = txtFeeItem1_name.Text
                currentRow("feeitem_price") = txtFeeItem1_price.Text
                currentRow("feeitem_remark") = txtFeeItem1_remark.Text
                currentRow("feeitem_status") = feeitem_status_value
                currentRow.EndEdit()
            End If
            DaAdap_f.Update(DaTable_f)

            txtFeeItem1_name.Text = ""
            txtFeeItem1_price.Text = ""
            txtFeeItem1_remark.Text = ""

            Me.DataGridView_FeeItem1.Refresh()
            '*****************
            'BEGIN SEND CHANGES TO SQL SERVER
            'Dim cmb As New SqlCommandBuilder(DaAdap1)
            DaAdap_f.Update(DaSet_f, "feeitem")
            'MsgBox("SQL Server updated successfully")
            '*****************

            f_id = Nothing
            MessageBox.Show("操作成功!!")

        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If DataGridView_FeeItem1.SelectedRows.Count > 0 Then
            Dim command As New SqlCommand
            command.CommandText = "UPDATE feeitem SET feeitem_status='3' WHERE FID = @Fid"
            command.Parameters.Add("@Fid", SqlDbType.Int)
            command.Connection = conn
            command.Parameters(0).Value = DataGridView_FeeItem1.SelectedRows(0).Cells(0).Value
            command.ExecuteNonQuery()

            MessageBox.Show("成功删除！")
        Else
            MessageBox.Show("请先选中删除数据,然后删除！")
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If DataGridView_FeeItem1.SelectedRows.Count > 0 Then
            f_id = DataGridView_FeeItem1.SelectedRows(0).Cells(0).Value
            TabControl_admin.SelectedIndex = 3
            txtFeeItem1_name.Text = DataGridView_FeeItem1.SelectedRows(0).Cells(1).Value
            txtFeeItem1_name.Enabled = False
            txtFeeItem1_price.Text = DataGridView_FeeItem1.SelectedRows(0).Cells(2).Value
            txtFeeItem1_remark.Text = DataGridView_FeeItem1.SelectedRows(0).Cells(3).Value
            cmb_feeitem_type.Text = DataGridView_FeeItem1.SelectedRows(0).Cells(4).Value
        Else
            MessageBox.Show("请选择数据后才可修改内容！")
        End If
    End Sub

    Private Sub btnStaff_update_Click(sender As Object, e As EventArgs) Handles btnStaff_update.Click
        If DataGridView_user.SelectedRows.Count > 0 Then
            staff_id = DataGridView_user.SelectedRows(0).Cells(0).Value
            TabControl_admin.SelectedIndex = 0
            txtUsername.Text = DataGridView_user.SelectedRows(0).Cells(1).Value
            txtUsername.Enabled = False
            txtPassword.Text = DataGridView_user.SelectedRows(0).Cells(2).Value
            cmb_Usertype.Text = DataGridView_user.SelectedRows(0).Cells(3).Value
            txtDepartment.Text = DataGridView_user.SelectedRows(0).Cells(4).Value
            txtWork_date.Text = DataGridView_user.SelectedRows(0).Cells(5).Value
            If IsDBNull(DataGridView_user.SelectedRows(0).Cells(6).Value) Then
                txtRemark.Text = ""
            Else
                txtRemark.Text = DataGridView_user.SelectedRows(0).Cells(6).Value
            End If

        Else
                MessageBox.Show("请选择数据后才可修改内容！")
        End If
    End Sub

    Private Sub btnStaff_del_Click(sender As Object, e As EventArgs) Handles btnStaff_del.Click
        If DataGridView_user.SelectedRows.Count > 0 Then
            Dim command As New SqlCommand
            command.CommandText = "UPDATE staff SET staff_status='已删除', delete_date=@del_date WHERE staff_id = @Sid"
            command.Parameters.Add("@Sid", SqlDbType.Int)
            command.Parameters.Add("@del_date", SqlDbType.DateTime)
            command.Connection = conn
            command.Parameters(0).Value = DataGridView_user.SelectedRows(0).Cells(0).Value
            command.Parameters(1).Value = DateTime.Now
            command.ExecuteNonQuery()

            MessageBox.Show("成功删除！")
            TabControl_admin.SelectedIndex = 0

        Else
            MessageBox.Show("请先选中删除数据,然后删除！")
        End If
    End Sub

    Private Sub btn_medi_usage1_update_Click(sender As Object, e As EventArgs) Handles btn_medi_usage1_update.Click
        Dim x As Integer
        DaAdap_mu1.UpdateCommand = cmb_mu1.GetUpdateCommand
        x = DaAdap_mu1.Update(DaSet_mu1.Tables("medi_usage1"))
        MessageBox.Show(x & " record(s")
    End Sub


    Private Sub btn_medi_usage1_del_Click_1(sender As Object, e As EventArgs) Handles btn_medi_usage1_del.Click
        For Each row As DataGridViewRow In DataGridView_medi_usage1.SelectedRows
            DataGridView_medi_usage1.Rows.Remove(row)
        Next
        DaAdap_mu1.Update(DaSet_mu1, "medi_usage1")
        DataGridView_medi_usage1.DataSource = DaSet_mu1.Tables("medi_usage1")
    End Sub

    Private Sub btn_medi_usage2_update_Click(sender As Object, e As EventArgs) Handles btn_medi_usage2_update.Click
        Dim x As Integer
        DaAdap_mu2.UpdateCommand = cmb_mu2.GetUpdateCommand
        x = DaAdap_mu2.Update(DaSet_mu2.Tables("medi_usage2"))
        MessageBox.Show(x & " record(s")
    End Sub

    Private Sub btn_medi_usage2_del_Click(sender As Object, e As EventArgs) Handles btn_medi_usage2_del.Click
        For Each row As DataGridViewRow In DataGridView_medi_usage2.SelectedRows
            DataGridView_medi_usage2.Rows.Remove(row)
        Next
        DaAdap_mu2.Update(DaSet_mu2, "medi_usage2")
        DataGridView_medi_usage2.DataSource = DaSet_mu2.Tables("medi_usage2")
    End Sub

    Private Sub btn_medi_unit_update_Click(sender As Object, e As EventArgs) Handles btn_medi_unit_update.Click
        Dim x As Integer
        DaAdap_mu3.UpdateCommand = cmb_mu3.GetUpdateCommand
        x = DaAdap_mu3.Update(DaSet_mu3.Tables("medi_use_unit"))
        MessageBox.Show(x & " record(s")
    End Sub

    Private Sub btn_medi_unit_del_Click(sender As Object, e As EventArgs) Handles btn_medi_unit_del.Click
        For Each row As DataGridViewRow In DataGridView_medi_use_unit.SelectedRows
            DataGridView_medi_use_unit.Rows.Remove(row)
        Next
        DaAdap_mu3.Update(DaSet_mu3, "medi_use_unit")
        DataGridView_medi_use_unit.DataSource = DaSet_mu3.Tables("medi_use_unit")
    End Sub
End Class