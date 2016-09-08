Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmCashier
    Private conn As New SqlConnection
    Private DaAdap1 As SqlDataAdapter
    Private DaAdap2 As SqlDataAdapter
    Private DaSet As New DataSet
    Private DaSet2 As New DataSet
    Private cmb As SqlCommandBuilder
    Private cmb2 As SqlCommandBuilder
    Private DaTable1 As DataTable
    Private DaTable2 As DataTable
    Private sql1 As String
    Private sql2 As String

    Private DaAdap_f As SqlDataAdapter
    Private DaTable_f As DataTable
    Private DaSet_f As New DataSet
    Private cmb_f As SqlCommandBuilder
    Private sql_f As String

    Private DaAdap_p As SqlDataAdapter
    Private DaTable_p As DataTable
    Private DaSet_p As New DataSet
    Private cmb_p As SqlCommandBuilder
    Private sql_p As String

    Private price_total_all_da As String
    Private price_total_medicine_refund As Decimal = 0
    Private price_total_feeitem_refund As Decimal = 0
    Private refund_work_type As String = 0

    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()
            sql1 = "select id, patient_name, patient_id,sex, patient_age, doctor, guahao_date, patient_contact, work_type
                    from patient_work where work_type= '1'"
            DaAdap1 = New SqlDataAdapter(sql1, conn)
            cmb = New SqlCommandBuilder(DaAdap1)
            DaAdap1.FillSchema(DaSet, SchemaType.Source, "patient_work")
            DaAdap1.Fill(DaSet, "patient_work")

            DaTable1 = New DataTable
            DaAdap1.Fill(DaTable1)
            dataGridView_guahao.DataSource = DaTable1

            With dataGridView_guahao
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "挂号ID"
                .Columns(0).Width = 50
                .Columns(1).HeaderCell.Value = "病人姓名"
                .Columns(2).HeaderCell.Value = "身份证"
                .Columns(2).Width = 110
                .Columns(3).HeaderCell.Value = "性别"
                .Columns(3).Width = 25
                .Columns(4).HeaderCell.Value = "年龄"
                .Columns(4).Width = 25
                .Columns(5).HeaderCell.Value = "挂号医生"
                .Columns(6).HeaderCell.Value = "挂号时间"
                .Columns(7).HeaderCell.Value = "病人联系方式"
                .Columns(8).HeaderCell.Value = "状态"
                .Columns(8).Width = 25
            End With

            sql2 = "select * from staff where job_type= '医生' and staff_status='有效'"
            DaAdap2 = New SqlDataAdapter(sql2, conn)
            cmb = New SqlCommandBuilder(DaAdap2)
            DaTable2 = New DataTable
            DaAdap2.Fill(DaTable2)
            cmbDoctor.DataSource = DaTable2
            cmbDoctor.DisplayMember = "staff_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmCashier_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub btnGuahao_Click(sender As Object, e As EventArgs) Handles btnGuahao.Click
        If txtName.Text = "" Or cmbDoctor.Text = "" Or txtAge.Text = "" Or cmbCashier_sex.Text = "" Then
            MessageBox.Show("姓名、性别、年龄和医生必须都填写！！")
        Else
            Dim drNewRow As DataRow = DaTable1.NewRow()
            drNewRow("patient_name") = txtName.Text
            drNewRow("patient_id") = txtPID.Text
            drNewRow("sex") = cmbCashier_sex.Text
            drNewRow("patient_age") = txtAge.Text
            drNewRow("doctor") = cmbDoctor.Text
            drNewRow("guahao_date") = DateTime.Now
            drNewRow("patient_contact") = txtContact.Text
            drNewRow("work_type") = "1"
            DaTable1.Rows.Add(drNewRow)
            DaAdap1.Update(DaTable1)

            txtName.Text = ""
            txtPID.Text = ""
            cmbCashier_sex.Text = ""
            txtAge.Text = ""
            cmbDoctor.Text = ""
            txtContact.Text = ""

            Me.dataGridView_guahao.Refresh()
            '*****************
            'BEGIN SEND CHANGES TO SQL SERVER
            'Dim cmb As New SqlCommandBuilder(DaAdap1)
            DaAdap1.Update(DaSet, "patient_work")
            'MsgBox("SQL Server updated successfully")
            '*****************
            MessageBox.Show("挂号成功!!")

        End If
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If DataGridView_delGuahao.SelectedRows.Count > 0 Then
            Dim command As New SqlCommand
            command.CommandText = "UPDATE patient_work SET work_type= CASE work_type WHEN '1' THEN '5' WHEN '2' THEN '6' END, 
                   status_update_date = @current_date WHERE ID = @Gid"
            command.Parameters.Add("@Gid", SqlDbType.Int)
            command.Parameters.Add("@current_date", SqlDbType.DateTime)
            command.Connection = conn
            command.Parameters(0).Value = DataGridView_delGuahao.SelectedRows(0).Cells(0).Value
            command.Parameters(1).Value = DateTime.Now
            command.ExecuteNonQuery()

            '********删除数据**************************
            'DaTable1.Rows(DataGridView_delGuahao.SelectedRows(0).Index).Delete()
            'DaAdap1.Update(DaTable1)
            'Me.DataGridView_delGuahao.Refresh()

            MessageBox.Show("成功删除数据！")
        Else
            MessageBox.Show("请先选中删除数据,然后删除！")
        End If
    End Sub

    Private Sub TabControl_cashier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_cashier.SelectedIndexChanged
        Select Case TabControl_cashier.SelectedIndex
            Case 0 ' User clicks on First Tab
                sql1 = "select id, patient_name, patient_id, sex, patient_age, doctor, guahao_date, patient_contact, work_type
                    from patient_work where work_type= '1'"
                DaAdap1 = New SqlDataAdapter(sql1, conn)
                cmb = New SqlCommandBuilder(DaAdap1)
                DaAdap1.FillSchema(DaSet, SchemaType.Source, "patient_work")
                DaAdap1.Fill(DaSet, "patient_work")

                DaTable1 = New DataTable
                DaAdap1.Fill(DaTable1)
                dataGridView_guahao.DataSource = DaTable1

                With dataGridView_guahao
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 110
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 25
                    .Columns(5).HeaderCell.Value = "挂号医生"
                    .Columns(6).HeaderCell.Value = "挂号时间"
                    .Columns(7).HeaderCell.Value = "病人联系方式"
                    .Columns(8).HeaderCell.Value = "状态"
                    .Columns(8).Width = 25
                End With

            Case 1 ' User clicks on Second Tab
                sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, chufang_date, patient_contact, work_type
                    from patient_work where work_type= '2' order by chufang_date DESC"
                DaAdap2 = New SqlDataAdapter(sql2, conn)
                cmb = New SqlCommandBuilder(DaAdap2)
                DaTable2 = New DataTable
                DaAdap2.Fill(DaTable2)
                DataGridView_prescription.DataSource = DaTable2
                With DataGridView_prescription
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 110
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 25
                    .Columns(5).HeaderCell.Value = "挂号医生"
                    .Columns(6).HeaderCell.Value = "处方时间"
                    .Columns(7).HeaderCell.Value = "病人联系方式"
                    .Columns(8).HeaderCell.Value = "状态"
                    .Columns(8).Width = 25
                End With

            Case 3 ' User clicks on Forth Tab 
                sql1 = "select id, patient_name, patient_id,sex, patient_age, doctor, guahao_date, patient_contact,
                    CASE work_type WHEN '2' THEN '已开处方' WHEN '1' THEN '已挂号' END AS work_type
                    from patient_work where work_type in ('1','2') order by guahao_date desc"
                DaAdap1 = New SqlDataAdapter(sql1, conn)
                cmb = New SqlCommandBuilder(DaAdap1)
                DaAdap1.FillSchema(DaSet, SchemaType.Source, "patient_work")
                DaAdap1.Fill(DaSet, "patient_work")

                DaTable1 = New DataTable
                DaAdap1.Fill(DaTable1)
                DataGridView_delGuahao.DataSource = DaTable1

                With DataGridView_delGuahao
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 135
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 45
                    .Columns(5).HeaderCell.Value = "挂号医生"
                    .Columns(6).HeaderCell.Value = "挂号时间"
                    .Columns(7).HeaderCell.Value = "病人联系方式"
                    .Columns(8).HeaderCell.Value = "状态"
                    .Columns(8).Width = 55
                End With

            Case 2 ' User clicks on Third Tab
                sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, pay_date, pay_amount,patient_contact, work_type
                    from patient_work where work_type in ('3','4','7','8') order by pay_date DESC"
                DaAdap2 = New SqlDataAdapter(sql2, conn)
                cmb2 = New SqlCommandBuilder(DaAdap2)
                DaTable2 = New DataTable
                DaAdap2.Fill(DaTable2)
                DaAdap2.Fill(DaSet2, "patient_work")
                DataGridView_paid.DataSource = DaTable2
                With DataGridView_paid
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 135
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 45
                    .Columns(5).HeaderCell.Value = "挂号医生"
                    .Columns(6).HeaderCell.Value = "交费时间"
                    .Columns(7).HeaderCell.Value = "金额"
                    .Columns(8).HeaderCell.Value = "联系方式"
                    .Columns(9).HeaderCell.Value = "状态"
                    .Columns(9).Width = 25
                End With

            Case 4 ' 取药后退费

                txtRefund_name.Text = ""
                txtRefund_PID.Text = ""
                txtRefund_age.Text = ""
                txtRefund_doctor.Text = ""
                txtRefund_datetime.Text = ""
                txtRefund_GID.Text = ""

                DataGridView_medi_refund.Rows.Clear()
                DataGridView_feeitem_refund.Rows.Clear()
                btnRefund_sure.Enabled = False

        End Select
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim formPayment As New frmPayment()
        formPayment = New frmPayment()
        formPayment.txtID.Text = DataGridView_prescription.SelectedRows(0).Cells(0).Value
        formPayment.txtName.Text = DataGridView_prescription.SelectedRows(0).Cells(1).Value
        formPayment.txtPID.Text = DataGridView_prescription.SelectedRows(0).Cells(2).Value
        formPayment.txtSex.Text = DataGridView_prescription.SelectedRows(0).Cells(3).Value
        formPayment.txtAge.Text = DataGridView_prescription.SelectedRows(0).Cells(4).Value
        formPayment.txtDoctor.Text = DataGridView_prescription.SelectedRows(0).Cells(5).Value
        formPayment.txtDatetime.Text = DataGridView_prescription.SelectedRows(0).Cells(6).Value
        'Me.Close()
        formPayment.ShowDialog()

        'make sure after finishing the payment go to different Tab Control
        TabControl_cashier.SelectedIndex = 2
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim formCheckPayment As New frmCheckPayment()
        formCheckPayment = New frmCheckPayment()
        formCheckPayment.txtID.Text = DataGridView_paid.SelectedRows(0).Cells(0).Value
        formCheckPayment.txtName.Text = DataGridView_paid.SelectedRows(0).Cells(1).Value
        formCheckPayment.txtPID.Text = DataGridView_paid.SelectedRows(0).Cells(2).Value
        formCheckPayment.txtSex.Text = DataGridView_paid.SelectedRows(0).Cells(3).Value
        formCheckPayment.txtAge.Text = DataGridView_paid.SelectedRows(0).Cells(4).Value
        formCheckPayment.txtDoctor.Text = DataGridView_paid.SelectedRows(0).Cells(5).Value
        formCheckPayment.txtDatetime.Text = DataGridView_paid.SelectedRows(0).Cells(6).Value
        formCheckPayment.txtPriceTotal.Text = DataGridView_paid.SelectedRows(0).Cells(7).Value
        formCheckPayment.ShowDialog()
    End Sub

    Private Sub DataGridView_delGuahao_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView_delGuahao.DoubleClick
        sql1 = "select id, patient_name, patient_id,sex, patient_age, doctor, guahao_date, patient_contact,
                    CASE work_type WHEN '2' THEN '已开处方' WHEN '1' THEN '已挂号' END AS work_type
                    from patient_work where work_type in ('1','2') order by guahao_date DESC"
        DaAdap1 = New SqlDataAdapter(sql1, conn)
        cmb = New SqlCommandBuilder(DaAdap1)
        DaAdap1.FillSchema(DaSet, SchemaType.Source, "patient_work")
        DaAdap1.Fill(DaSet, "patient_work")

        DaTable1 = New DataTable
        DaAdap1.Fill(DaTable1)
        DataGridView_delGuahao.DataSource = DaTable1

        With DataGridView_delGuahao
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 135
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "挂号医生"
            .Columns(6).HeaderCell.Value = "挂号时间"
            .Columns(7).HeaderCell.Value = "病人联系方式"
            .Columns(8).HeaderCell.Value = "状态"
            .Columns(8).Width = 55
        End With
    End Sub

    Private Sub btnRefresh_pay_Click(sender As Object, e As EventArgs) Handles btnRefresh_pay.Click
        sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, chufang_date, patient_contact, work_type
                    from patient_work where work_type= '2' order by chufang_date DESC"
        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb = New SqlCommandBuilder(DaAdap2)
        DaTable2 = New DataTable
        DaAdap2.Fill(DaTable2)
        DataGridView_prescription.DataSource = DaTable2
        With DataGridView_prescription
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 135
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "挂号医生"
            .Columns(6).HeaderCell.Value = "挂号时间"
            .Columns(7).HeaderCell.Value = "病人联系方式"
            .Columns(8).HeaderCell.Value = "状态"
            .Columns(8).Width = 25
        End With
    End Sub

    Private Sub btnRefresh_paycheck_Click(sender As Object, e As EventArgs) Handles btnRefresh_paycheck.Click
        sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, pay_date, pay_amount,patient_contact, work_type
                    from patient_work where work_type in('3','4','7','8') order by pay_date DESC"
        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb = New SqlCommandBuilder(DaAdap2)
        DaTable2 = New DataTable
        DaAdap2.Fill(DaTable2)
        DaAdap2.Fill(DaSet2, "patient_work")
        DataGridView_paid.DataSource = DaTable2
        With DataGridView_paid
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 135
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "挂号医生"
            .Columns(6).HeaderCell.Value = "交费时间"
            .Columns(7).HeaderCell.Value = "金额"
            .Columns(8).HeaderCell.Value = "病人联系方式"
            .Columns(9).HeaderCell.Value = "状态"
            .Columns(9).Width = 25
        End With
    End Sub

    '**********************   退费操作  ***************************************************************************************
    '********************************************************************************************************************
    Private Sub btnGuahao_search_Click(sender As Object, e As EventArgs) Handles btnGuahao_search.Click
        If txtSearch_GuahaoID.Text.Trim() = "" Then
            MsgBox("请输入ID后才可搜索！")
        Else
            DaTable2.Rows.Clear()

            '******显示 挂号病人数据*******************
            sql2 = "select patient_name, patient_id,sex, patient_age, doctor, quyao_date, id, work_type, pay_date
                    from patient_work where work_type in(3,4) and id= '" & txtSearch_GuahaoID.Text.Trim() & "'"
            DaAdap2 = New SqlDataAdapter(sql2, conn)
            cmb = New SqlCommandBuilder(DaAdap2)
            DaTable2 = New DataTable
            DaAdap2.Fill(DaTable2)
            If DaTable2.Rows.Count > 0 Then
                '****** clear data in Datagridview *********
                If DataGridView_medi_refund.Rows.Count > 0 Then
                    DataGridView_medi_refund.Rows.Clear()
                End If
                If DataGridView_feeitem_refund.Rows.Count > 0 Then
                    DataGridView_feeitem_refund.Rows.Clear()
                End If

                txtRefund_name.Text = DaTable2.Rows(0).Item(0)
                txtRefund_PID.Text = DaTable2.Rows(0).Item(1)
                If IsDBNull(DaTable2.Rows(0).Item(2)) Then
                    txtRefund_age.Text = ""
                Else
                    txtRefund_age.Text = DaTable2.Rows(0).Item(2)
                End If

                txtSex.Text = DaTable2.Rows(0).Item(3)
                txtRefund_doctor.Text = DaTable2.Rows(0).Item(4)
                If IsDBNull(DaTable2.Rows(0).Item(4)) Then
                    txtRefund_datetime.Text = DaTable2.Rows(0).Item(7)
                    Label6.Text = "收费时间"
                Else
                    txtRefund_datetime.Text = DaTable2.Rows(0).Item(4)
                End If
                If IsDBNull(DaTable2.Rows(0).Item(5)) Then
                    txtRefund_GID.Text = ""
                Else
                    txtRefund_GID.Text = DaTable2.Rows(0).Item(5)
                End If
                If DaTable2.Rows(0).Item(6) = 4 Then
                    refund_work_type = 8
                    MsgBox("已领取药物，退费前请务必让退药！", MsgBoxStyle.Critical, "请先退药")
                Else
                    refund_work_type = 7
                End If

                '----------------------------------------------------------------
                '******显示 处方数据*******************
                sql_p = "select p_medicine_name,p_amount,p_sale_unit,p_unit_price, p_row_total from prescription where pid='" & txtSearch_GuahaoID.Text.Trim() & "'"
                    DaAdap_p = New SqlDataAdapter(sql_p, conn)
                    cmb_p = New SqlCommandBuilder(DaAdap_p)
                    DaTable_p = New DataTable
                    DaAdap_p.Fill(DaTable_p)
                    If DaTable_p.Rows.Count > 0 Then
                        DataGridView_check.DataSource = DaTable_p
                        With DataGridView_check
                            .RowHeadersVisible = False
                            .Columns(0).HeaderCell.Value = "药名"
                            .Columns(0).Width = 200
                            .Columns(1).HeaderCell.Value = "量"
                            .Columns(2).HeaderCell.Value = "单位"
                            .Columns(3).HeaderCell.Value = "单价"
                            .Columns(4).HeaderCell.Value = "金额"
                        End With
                        '**** Medicine price total ****
                        Dim price_total_medicine As Decimal = 0
                        For i As Integer = 0 To DataGridView_check.Rows.Count - 1
                            price_total_medicine += DataGridView_check.Rows(i).Cells(4).Value
                        Next
                        txtPriceTotal.Text = price_total_medicine

                        '****** Show Other Feeitem ***************************
                        sql_f = "select pf_feeitem_name, pf_feeitem_price from prescription_feeitem WHERE PFID='" & txtSearch_GuahaoID.Text.Trim() & "'"
                        DaAdap_f = New SqlDataAdapter(sql_f, conn)
                        cmb_f = New SqlCommandBuilder(DaAdap_f)
                        DaTable_f = New DataTable
                        DaAdap_f.Fill(DaTable_f)
                        DataGridView_feeitem.DataSource = DaTable_f
                        With DataGridView_feeitem
                            .RowHeadersVisible = False
                            .Columns(0).HeaderCell.Value = "项目名称"
                            .Columns(0).Width = 120
                            .Columns(1).HeaderCell.Value = "价格"
                        End With
                        '**** Feeitem price total ****
                        Dim price_total_feeitem As Decimal = 0
                        For i As Integer = 0 To DataGridView_feeitem.Rows.Count - 1
                            price_total_feeitem += DataGridView_feeitem.Rows(i).Cells(1).Value
                        Next
                        txtFeeitem_total.Text = price_total_feeitem

                        '**** price total ALL ****
                        Dim price_total_all As Decimal = 0
                        price_total_all = price_total_medicine + price_total_feeitem
                        txtTotal_all.Text = price_total_all

                        '**** show the Buttion ******
                        btnRefund_sure.Enabled = True

                    Else
                        MsgBox("此数据不可退费！", MsgBoxStyle.Critical, "无效")
                        Me.txtSearch_GuahaoID.Text = ""
                    End If

                    '----------------------------------------------------------------
                Else

                    MsgBox("此数据不可退费！", MsgBoxStyle.Critical, "无效")
                Me.txtSearch_GuahaoID.Text = ""
                btnRefund_sure.Enabled = False
            End If

        End If


    End Sub

    Private Sub DataGridView_check_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_check.CellDoubleClick
        '*****判断药品选择是否重复**************
        Dim repeat As Int16 = 0
        For Each row As DataGridViewRow In Me.DataGridView_check.SelectedRows
            For j As Integer = 0 To DataGridView_medi_refund.Rows.Count - 1
                If row.Cells(0).Value = DataGridView_medi_refund.Rows(j).Cells(0).Value Then
                    repeat = 1
                End If
            Next
        Next

        If repeat = 1 Then
            MsgBox("不可重复选择药品！")
        Else
            For Each row As DataGridViewRow In Me.DataGridView_check.SelectedRows
                Dim rowData(row.Cells.Count - 1) As Object
                For i As Integer = 0 To rowData.Length - 1
                    rowData(i) = row.Cells(i).Value
                Next
                Me.DataGridView_medi_refund.Rows.Add(rowData)
            Next

            '**** REFUND - Medicine price total ****
            price_total_medicine_refund = 0
            For i As Integer = 0 To DataGridView_medi_refund.Rows.Count - 1
                price_total_medicine_refund += DataGridView_medi_refund.Rows(i).Cells(4).Value
            Next

            '**** REFUND - feeitem price total ****
            price_total_feeitem_refund = 0
            For i As Integer = 0 To DataGridView_feeitem_refund.Rows.Count - 1
                price_total_feeitem_refund += DataGridView_feeitem_refund.Rows(i).Cells(1).Value
            Next
            txtRefund_total.Text = -price_total_medicine_refund - price_total_feeitem_refund
            txt_price_totalAll_new.Text = txtTotal_all.Text - price_total_medicine_refund - price_total_feeitem_refund

        End If
    End Sub

    Private Sub DataGridView_feeitem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_feeitem.CellDoubleClick
        '*****判断选择是否重复**************
        Dim repeat As Int16 = 0
        For Each row As DataGridViewRow In Me.DataGridView_feeitem.SelectedRows
            For j As Integer = 0 To DataGridView_feeitem_refund.Rows.Count - 1
                If row.Cells(0).Value = DataGridView_feeitem_refund.Rows(j).Cells(0).Value Then
                    repeat = 1
                End If
            Next
        Next

        If repeat = 1 Then
            MsgBox("不可重复选择药品！")
        Else
            For Each row As DataGridViewRow In Me.DataGridView_feeitem.SelectedRows
                Dim rowData(row.Cells.Count - 1) As Object
                For i As Integer = 0 To rowData.Length - 1
                    rowData(i) = row.Cells(i).Value
                Next
                Me.DataGridView_feeitem_refund.Rows.Add(rowData)
            Next

            '**** REFUND - Medicine price total ****
            Dim price_total_medicine_refund As Decimal = 0
            For i As Integer = 0 To DataGridView_medi_refund.Rows.Count - 1
                price_total_medicine_refund += DataGridView_medi_refund.Rows(i).Cells(4).Value
            Next

            '**** REFUND - feeitem price total ****
            Dim price_total_feeitem_refund As Decimal = 0
            For i As Integer = 0 To DataGridView_feeitem_refund.Rows.Count - 1
                price_total_feeitem_refund += DataGridView_feeitem_refund.Rows(i).Cells(1).Value
            Next
            txtRefund_total.Text = -price_total_medicine_refund - price_total_feeitem_refund
            txt_price_totalAll_new.Text = txtTotal_all.Text - price_total_medicine_refund - price_total_feeitem_refund

        End If
    End Sub

    '****** Delete a selected row from the DataGridView *********
    Private Sub btn_delRow_medi_Click(sender As Object, e As EventArgs) Handles btn_delRow_medi.Click
        If DataGridView_medi_refund.SelectedCells.Count > 0 Then
            Me.DataGridView_medi_refund.Rows.RemoveAt(DataGridView_medi_refund.CurrentCell.RowIndex)
        Else
            MessageBox.Show("请选择删除数据")
        End If
    End Sub

    Private Sub btnDel_row_feeitem_Click(sender As Object, e As EventArgs) Handles btnDel_row_feeitem.Click
        If DataGridView_feeitem_refund.SelectedCells.Count > 0 Then
            Me.DataGridView_feeitem_refund.Rows.RemoveAt(DataGridView_feeitem_refund.CurrentCell.RowIndex)
        Else
            MessageBox.Show("请选择删除数据")
        End If
    End Sub
    '****** END- Delete a selected row from the DataGridView *********

    Private Sub btnRefund_sure_Click(sender As Object, e As EventArgs) Handles btnRefund_sure.Click
        If DataGridView_medi_refund.Rows.Count = 0 And DataGridView_feeitem_refund.Rows.Count = 0 Then
            MessageBox.Show("请选择退费数据!!")
        Else
            '****Insert Data into table [prescription] ***********
            Dim command As New SqlCommand
            command.CommandText = "INSERT INTO prescription (PID,p_medicine_name,p_amount,p_sale_unit,p_unit_price, p_row_total,insert_date)
                               VALUES (@pid, @p_Name,@p_amount, @p_sale_unit, @p_unit_price, @p_total,@p_insert_date)"
            command.Parameters.Add("@pid", SqlDbType.Int)
            command.Parameters.Add("@p_Name", SqlDbType.VarChar)
            command.Parameters.Add("@p_amount", SqlDbType.Int)
            command.Parameters.Add("@p_sale_unit", SqlDbType.VarChar)
            command.Parameters.Add("@p_unit_price", SqlDbType.Decimal)
            command.Parameters.Add("@p_total", SqlDbType.Decimal)
            command.Parameters.Add("@p_insert_date", SqlDbType.DateTime)
            command.Connection = conn

            For i As Integer = 0 To DataGridView_medi_refund.Rows.Count - 1
                command.Parameters(0).Value = txtSearch_GuahaoID.Text.Trim()
                command.Parameters(1).Value = DataGridView_medi_refund.Rows(i).Cells(0).Value
                command.Parameters(2).Value = -DataGridView_medi_refund.Rows(i).Cells(1).Value
                command.Parameters(3).Value = DataGridView_medi_refund.Rows(i).Cells(2).Value
                command.Parameters(4).Value = DataGridView_medi_refund.Rows(i).Cells(3).Value
                command.Parameters(5).Value = -DataGridView_medi_refund.Rows(i).Cells(4).Value
                command.Parameters(6).Value = DateTime.Now
                command.ExecuteNonQuery()
            Next


            '****Insert Data into table [prescription_feeitem] ***********
            Dim command4 As New SqlCommand
            command4.CommandText = "INSERT INTO prescription_feeitem (PFID, pf_feeitem_name, pf_feeitem_price,insert_date)
                               VALUES (@fid, @f_name, @f_price,@f_insert_date)"
            command4.Parameters.Add("@fid", SqlDbType.Int)
            command4.Parameters.Add("@f_name", SqlDbType.Text)
            command4.Parameters.Add("@f_price", SqlDbType.Decimal)
            command4.Parameters.Add("@f_insert_date", SqlDbType.DateTime)
            'conn.Open()
            command4.Connection = conn

            For i As Integer = 0 To DataGridView_feeitem_refund.Rows.Count - 1
                command4.Parameters(0).Value = txtSearch_GuahaoID.Text.Trim()
                command4.Parameters(1).Value = DataGridView_feeitem_refund.Rows(i).Cells(0).Value
                command4.Parameters(2).Value = -DataGridView_feeitem_refund.Rows(i).Cells(1).Value
                command4.Parameters(3).Value = DateTime.Now
                command4.ExecuteNonQuery()
            Next

            '****Insert Data into table [refund] ***********
            Dim command5 As New SqlCommand
            command5.CommandText = "INSERT INTO refund (GID, current_medi_total, current_feeitem_total,current_price_total, refund_total, new_price_total,work_type,insert_date)
                               VALUES (@r_id, @r_price1, @r_price2,@r_price3,@r_price4,@r_price5,@r_status,@r_insert_date)"
            command5.Parameters.Add("@r_id", SqlDbType.Int)
            command5.Parameters.Add("@r_price1", SqlDbType.Decimal)
            command5.Parameters.Add("@r_price2", SqlDbType.Decimal)
            command5.Parameters.Add("@r_price3", SqlDbType.Decimal)
            command5.Parameters.Add("@r_price4", SqlDbType.Decimal)
            command5.Parameters.Add("@r_price5", SqlDbType.Decimal)
            command5.Parameters.Add("@r_status", SqlDbType.VarChar)
            command5.Parameters.Add("@r_insert_date", SqlDbType.DateTime)
            command5.Connection = conn

            command5.Parameters(0).Value = txtSearch_GuahaoID.Text.Trim()
            command5.Parameters(1).Value = txtPriceTotal.Text
            command5.Parameters(2).Value = txtFeeitem_total.Text
            command5.Parameters(3).Value = txtTotal_all.Text
            command5.Parameters(4).Value = txtRefund_total.Text
            command5.Parameters(5).Value = txt_price_totalAll_new.Text
            command5.Parameters(6).Value = refund_work_type
            command5.Parameters(7).Value = DateTime.Now
            command5.ExecuteNonQuery()

            '****update Data in table [patient_work], [pay_amount= txt_price_totalAll_new.text, work_type="8", status_update_date=now ]***********
            Dim command2 As New SqlCommand
            command2.CommandText = "UPDATE patient_work SET pay_amount= @price_total_new, work_type= @status,status_update_date=@status_date  WHERE ID = @pid"
            command2.Parameters.Add("@pid", SqlDbType.Int)
            command2.Parameters.Add("@price_total_new", SqlDbType.Decimal)
            command2.Parameters.Add("@status", SqlDbType.VarChar)
            command2.Parameters.Add("@status_date", SqlDbType.DateTime)
            command2.Connection = conn
            command2.Parameters(0).Value = txtSearch_GuahaoID.Text.Trim()
            command2.Parameters(1).Value = txt_price_totalAll_new.Text
            command2.Parameters(2).Value = refund_work_type
            command2.Parameters(3).Value = DateTime.Now
            command2.ExecuteNonQuery()
            MessageBox.Show("退费成功！")

            '******* 金额大写显示 ******************
            price_total_all_da = ConvertToRMB(txt_price_totalAll_new.Text)

            PrintContent(PrintDestination.Printer)

            TabControl_cashier.SelectedIndex = 2

        End If
    End Sub

    '*************** PRINTING CODE START ***************************************************************
    Private Enum PrintDestination
        Printer = 0
        PrintPreview = 1
    End Enum

    '********** PrintContent Procedure ****************
    Private Sub PrintContent(ByVal Destination As PrintDestination)
        If DataGridView_check.Rows.Count = 0 Then
            MessageBox.Show("没有记录可收费！！")
            Exit Sub
        End If
        'ChangePageSettings()
        PrintDocument1.PrinterSettings.Copies = 1
        If Destination = PrintDestination.PrintPreview Then
            ' Specify document for print preview dialog box and show.
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Else
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub ChangePageSettings()
        ' Let the user change the printer settings
        Dim PrintPageSettings As New System.Drawing.Printing.PageSettings

        PageSetupDialog1.PageSettings = PrintPageSettings
        PageSetupDialog1.ShowDialog()

        'Specify current page settings
        PrintDocument1.DefaultPageSettings = PrintPageSettings
    End Sub

    Private Sub btn_print_review_Click(sender As Object, e As EventArgs) Handles btn_print_review.Click
        PrintContent(PrintDestination.PrintPreview)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '**************** Printing Invoice ******************************* 
        'Dim HeaderFont As Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold)
        Dim nrmlfnt As Font = New Drawing.Font("Microsoft YaHei", 9)
        'Dim listheadfont As Font = New Drawing.Font("Microsoft YaHei", 8, FontStyle.Bold)
        Dim drawBrush As New SolidBrush(Color.Blue)
        Dim ObjFont2 As New Font("Microsoft YaHei", 9, FontStyle.Bold, GraphicsUnit.Point)

        '**** add header ***********
        e.Graphics.DrawString(" " & txtRefund_name.Text & "", nrmlfnt, drawBrush, 145, 70)
        e.Graphics.DrawString(" 医药费 ", nrmlfnt, drawBrush, 135, 105)
        e.Graphics.DrawString(" 其他项 ", nrmlfnt, drawBrush, 235, 105)
        'e.Graphics.DrawString(" 检验费 ", nrmlfnt, drawBrush, 335, 105) ' height = 35, distance = 100
        e.Graphics.DrawString(" " & txtPriceTotal.Text - price_total_medicine_refund & "", nrmlfnt, drawBrush, 135, 140)
        e.Graphics.DrawString(" " & txtFeeitem_total.Text - price_total_feeitem_refund & "", nrmlfnt, drawBrush, 235, 140)
        'e.Graphics.DrawString(" 00.00 ", nrmlfnt, drawBrush, 335, 140)
        e.Graphics.DrawString(" " & price_total_all_da & "", ObjFont2, drawBrush, 135, 175)
        e.Graphics.DrawString(" " & txt_price_totalAll_new.Text & "", ObjFont2, drawBrush, 343, 175)
        'e.Graphics.DrawString(" " & DateTime.Now & "", nrmlfnt, drawBrush, 130, 210)
        e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt, drawBrush, 130, 210)
        e.Graphics.DrawString(" " & txtSearch_GuahaoID.Text & "", nrmlfnt, drawBrush, 300, 210)
        e.Graphics.DrawString(" " & My.Settings.username & "", nrmlfnt, drawBrush, 300, 245)

        '***** add reciept for medicine (x=125)*******
        e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt, drawBrush, 460, 70)
        e.Graphics.DrawString(" 医药费 ", nrmlfnt, drawBrush, 460, 105)
        e.Graphics.DrawString(" " & txtPriceTotal.Text - price_total_medicine_refund & "", nrmlfnt, drawBrush, 460, 140)
        e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt, drawBrush, 460, 175)

        '***** add reciept for feeItem  (x=140)********
        e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt, drawBrush, 600, 70)
        e.Graphics.DrawString(" 其他项 ", nrmlfnt, drawBrush, 600, 105)
        e.Graphics.DrawString(" " & txtFeeitem_total.Text - price_total_feeitem_refund & "", nrmlfnt, drawBrush, 600, 140)
        e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt, drawBrush, 600, 175)

    End Sub

    '*********** 人民币金额的大小写实现****************************************************
    Function ConvertToRMB(ByVal inputString As String) As String
        Dim numList As String = “零壹贰叁肆伍陆柒捌玖”
        Dim rmbList As String = “分角元拾佰仟万拾佰仟亿拾佰仟万”
        Dim number As Double = 0
        Dim tempOutString As String = “”
        Try
            number = Double.Parse(inputString)
        Catch ex As SystemException
            MessageBox.Show("传入参数非数字")
        End Try

        If number > 9999999999999.99 Then
            Return "超出范围的人民币值"
        End If

        Dim tempNumberString As String = Convert.ToInt64(number * 100).ToString()
        Dim tempNmberLength As Integer = tempNumberString.Length
        Dim i As Integer = 0
        If tempNumberString.StartsWith("-") Then
            tempOutString = "负"
            i = i + 1
        End If
        While i < tempNmberLength
            Dim oneNumber As Integer = Int32.Parse(tempNumberString.Substring(i, 1))
            Dim oneNumberChar As String = numList.Substring(oneNumber, 1)
            Dim oneNumberUnit As String = rmbList.Substring(tempNmberLength - i - 1, 1)
            If Not (oneNumberChar = "零") Then
                tempOutString += oneNumberChar + oneNumberUnit
            Else
                If oneNumberUnit = "亿" OrElse oneNumberUnit = "万" OrElse oneNumberUnit = "元" OrElse oneNumberUnit = "零" Then
                    While tempOutString.EndsWith("零")
                        tempOutString = tempOutString.Substring(0, tempOutString.Length - 1)
                    End While
                End If
                If oneNumberUnit = "亿" OrElse (oneNumberUnit = "万" AndAlso Not tempOutString.EndsWith("亿")) OrElse oneNumberUnit = "元" Then
                    tempOutString += oneNumberUnit
                Else
                    If Not tempOutString Is Nothing Then
                        Dim tempEnd As Boolean = tempOutString.EndsWith("亿")
                        Dim zeroEnd As Boolean = tempOutString.EndsWith("零")
                        If tempOutString.Length > 1 Then
                            Dim zeroStart As Boolean = tempOutString.Substring(tempOutString.Length - 2, 2).StartsWith("零")
                            If Not zeroEnd AndAlso (zeroStart OrElse Not tempEnd) Then
                                tempOutString += oneNumberChar
                            End If
                        Else
                            If Not zeroEnd AndAlso Not tempEnd Then
                                tempOutString += oneNumberChar
                            End If
                        End If
                    End If

                End If
            End If
            i += 1

        End While
        If Not tempOutString Is Nothing Then
            While tempOutString.EndsWith("零")
                tempOutString = tempOutString.Substring(0, tempOutString.Length - 1)
            End While
            While tempOutString.EndsWith("元")
                tempOutString = tempOutString + "整"
            End While
            Return tempOutString
        Else
            Return ""
        End If
    End Function
    '********** PRINTING CODE END  ***********************************************

    Private Sub btnGID_search_Click(sender As Object, e As EventArgs) Handles btnGID_search.Click
        Dim myDataview As New DataView
        Dim myBR As New BindingSource

        DaSet2.Clear()
        sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, pay_date, pay_amount,patient_contact, work_type
                    from patient_work where work_type in ('3','4','7','8') order by pay_date DESC"
        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb2 = New SqlCommandBuilder(DaAdap2)
        DaAdap2.Fill(DaSet2, "patient_work")
        myDataview = DaSet2.Tables("patient_work").DefaultView
        myBR.DataSource = myDataview
        myBR.Filter = " CONVERT(id,'System.String') like '" & txtGID_search.Text.Trim() & "%' "
        myBR.Sort = "id"
        Me.DataGridView_paid.DataSource = myBR
        With DataGridView_paid
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 135
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "挂号医生"
            .Columns(6).HeaderCell.Value = "交费时间"
            .Columns(7).HeaderCell.Value = "金额"
            .Columns(8).HeaderCell.Value = "联系方式"
            .Columns(9).HeaderCell.Value = "状态"
            .Columns(9).Width = 25
        End With


    End Sub



End Class