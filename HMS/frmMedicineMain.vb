Imports System.Data
Imports System.Data.SqlClient

Public Class frmMedicineMain
    Private conn As New SqlConnection
    Private DaAdap As SqlDataAdapter
    Private DaSet As New DataSet
    Private cmb As SqlCommandBuilder
    Private DaTable As DataTable
    Private sql As String
    Private DaAdap2 As SqlDataAdapter
    Private DaTable2 As DataTable
    Private DaSet2 As New DataSet
    Private sql2 As String

    '********** Begin Medicine Management **************
    Private DaAdap_m As SqlDataAdapter
    Private DaTable_m As DataTable
    Private DaSet_m As New DataSet
    Private cmb_m As SqlCommandBuilder
    Private sql_m As String
    Private m_id As Integer = Nothing

    '***** For database update ********
    Private DaAdap_m_db As SqlDataAdapter
    Private DaTable_m_db As DataTable
    Private DaSet_m_db As New DataSet
    Private cmb_m_db As SqlCommandBuilder
    Private sql_m_db As String
    '***** END             ************

    Private DaAdap_s As SqlDataAdapter
    Private DaTable_s As DataTable
    Private DaSet_s As New DataSet
    Private cmb_s As SqlCommandBuilder
    Private sql_s As String
    Private s_id As Integer = Nothing
    Private storage As Integer
    '********** End Medicine Management **************

    Private Sub frmMedicineMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbConnString
        conn.Open()
        sql = "select id, patient_name, patient_id,sex, patient_age, doctor, pay_date, pay_amount,patient_contact, work_type
                    from patient_work where work_type= '3' order by pay_date DESC "
        DaAdap = New SqlDataAdapter(sql, conn)
        cmb = New SqlCommandBuilder(DaAdap)
        DaTable = New DataTable
        DaAdap.Fill(DaTable)
        DataGridView_paid.DataSource = DaTable
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

        '****** 库存量新增项 hide ***********
        labelMStorage_add.Visible = False
        txtMStorage_add.Visible = False



    End Sub

    Private Sub frmMedicineMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub btnGetMedicine_Click(sender As Object, e As EventArgs) Handles btnGetMedicine.Click
        Dim formMedicineGive As New frmMedicineGive()
        formMedicineGive = New frmMedicineGive()
        formMedicineGive.txtID.Text = DataGridView_paid.SelectedRows(0).Cells(0).Value
        formMedicineGive.txtName.Text = DataGridView_paid.SelectedRows(0).Cells(1).Value
        formMedicineGive.txtPID.Text = DataGridView_paid.SelectedRows(0).Cells(2).Value
        formMedicineGive.txtSex.Text = DataGridView_paid.SelectedRows(0).Cells(3).Value
        formMedicineGive.txtAge.Text = DataGridView_paid.SelectedRows(0).Cells(4).Value
        formMedicineGive.txtDoctor.Text = DataGridView_paid.SelectedRows(0).Cells(5).Value
        formMedicineGive.txtDatetime.Text = DataGridView_paid.SelectedRows(0).Cells(6).Value
        formMedicineGive.txtPriceTotal.Text = DataGridView_paid.SelectedRows(0).Cells(7).Value
        'Me.Close()
        formMedicineGive.ShowDialog()

        'make sure after finish giving the medicine go to different Tab Control
        TabControl_medicine.SelectedIndex = 1
    End Sub

    Private Sub TabControl_medicine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_medicine.SelectedIndexChanged
        Select Case TabControl_medicine.SelectedIndex
            Case 0 ' User clicks on First Tab
                sql = "select id, patient_name, patient_id, sex, patient_age, doctor, pay_date, pay_amount,patient_contact, work_type
                    from patient_work where work_type= '3' ORDER BY pay_date DESC"
                DaAdap = New SqlDataAdapter(sql, conn)
                cmb = New SqlCommandBuilder(DaAdap)
                DaTable = New DataTable
                DaAdap.Fill(DaTable)
                DataGridView_paid.DataSource = DaTable
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

            Case 1 ' User clicks on Second Tab
                sql2 = "select id, patient_name, patient_id, sex, patient_age, doctor, quyao_date, medicine_giver,patient_contact, work_type, pay_amount
                    from patient_work where work_type in('4','8') ORDER BY quyao_date DESC "
                DaAdap2 = New SqlDataAdapter(sql2, conn)
                cmb = New SqlCommandBuilder(DaAdap2)
                DaTable2 = New DataTable
                DaAdap2.Fill(DaTable2)
                DaAdap2.Fill(DaSet2, "patient_work")
                DataGridView_got_medicine.DataSource = DaTable2
                With DataGridView_got_medicine
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 145
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 25
                    .Columns(5).HeaderCell.Value = "医生"
                    .Columns(6).HeaderCell.Value = "发药时间"
                    .Columns(7).HeaderCell.Value = "发药者"
                    .Columns(8).HeaderCell.Value = "病人联系方式"
                    .Columns(9).HeaderCell.Value = "状态"
                    .Columns(9).Width = 25
                    .Columns(10).HeaderCell.Value = "金额"
                    .Columns(10).Width = 50
                End With
            Case 2
                txtMedicine_name.Enabled = True
                txtMedicine_name.Text = ""
                txtMedicine_norms.Text = ""
                txtProduction.Text = ""
                txtEffect_date.Text = ""
                txtAlias.Text = ""
                txtSale_unit_price.Text = ""
                txtStorage.Enabled = True
                txtStorage.Text = ""



            Case 3 ' User clicks on Forth Tab

                '********** Begin Medicine Management **************
                Try
                    sql_m = "select medicine_ID, medicine_name, medicine_norms, sale_unit, sale_unit_price,storage,alias, 
                      production, effect_date from medicine WHERE medicine_status='1' ORDER BY storage "
                    DaAdap_m = New SqlDataAdapter(sql_m, conn)
                    cmb_m = New SqlCommandBuilder(DaAdap_m)
                    DaTable_m = New DataTable
                    DaAdap_m.Fill(DaTable_m)
                    DaAdap_m.FillSchema(DaSet_m, SchemaType.Source, "medicine")
                    DaAdap_m.Fill(DaSet_m, "medicine")
                    DataGridView_medicine.DataSource = DaTable_m

                    With DataGridView_medicine
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "ID"
                        .Columns(0).Width = 60
                        .Columns(1).HeaderCell.Value = "药名"
                        .Columns(1).Width = 300
                        .Columns(2).HeaderCell.Value = "规格"
                        .Columns(2).Width = 200
                        .Columns(3).HeaderCell.Value = "单位"
                        .Columns(4).HeaderCell.Value = "单价"
                        .Columns(5).HeaderCell.Value = "库存量"
                        .Columns(6).HeaderCell.Value = "别名"
                        .Columns(7).HeaderCell.Value = "生产厂家"
                        .Columns(8).HeaderCell.Value = "有效期"
                    End With

                    '***** heighlight库存量<10 ************
                    For Each row As DataGridViewRow In DataGridView_medicine.Rows
                        Dim num As Integer = Val(row.Cells(5).Value)
                        If num <= 10 Then
                            row.DefaultCellStyle.BackColor = Color.Red
                            row.DefaultCellStyle.SelectionBackColor = Color.Red
                        End If
                    Next
                    '***** END ****************************
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                '********** End Medicine Management **************


        End Select
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim giver As String
        Dim formCheckMedicine As New frmCheckMedicine()
        formCheckMedicine = New frmCheckMedicine()
        formCheckMedicine.txtID.Text = DataGridView_got_medicine.SelectedRows(0).Cells(0).Value
        formCheckMedicine.txtName.Text = DataGridView_got_medicine.SelectedRows(0).Cells(1).Value
        formCheckMedicine.txtPID.Text = DataGridView_got_medicine.SelectedRows(0).Cells(2).Value
        formCheckMedicine.txtSex.Text = DataGridView_got_medicine.SelectedRows(0).Cells(3).Value
        formCheckMedicine.txtAge.Text = DataGridView_got_medicine.SelectedRows(0).Cells(4).Value
        formCheckMedicine.txtDoctor.Text = DataGridView_got_medicine.SelectedRows(0).Cells(5).Value
        formCheckMedicine.txtDatetime.Text = DataGridView_got_medicine.SelectedRows(0).Cells(6).Value
        If IsDBNull(DataGridView_got_medicine.SelectedRows(0).Cells(7).Value()) Or DataGridView_got_medicine.SelectedRows(0).Cells(7).Value() Is Nothing Or DataGridView_got_medicine.SelectedRows(0).Cells(7).Value().ToString().Trim() = "" Then
            giver = ""
        Else
            giver = DataGridView_got_medicine.SelectedRows(0).Cells(7).Value()
        End If
        formCheckMedicine.TextBox_giver.Text = giver
        formCheckMedicine.ShowDialog()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtMedicine_name.Text = "" Or txtMedicine_norms.Text = "" Or
           txtSale_unit_price.Text = "" Or cmb_sale_unit.Text = "" Or txtStorage.Text = "" Then
            MessageBox.Show("请务必填写所有内容！！")
        Else
            sql_m_db = "select * from medicine"
            DaAdap_m_db = New SqlDataAdapter(sql_m_db, conn)
            cmb_m_db = New SqlCommandBuilder(DaAdap_m_db)
            DaTable_m_db = New DataTable
            DaAdap_m_db.Fill(DaTable_m_db)
            DaAdap_m_db.FillSchema(DaSet_m_db, SchemaType.Source, "medicine")
            DaAdap_m_db.Fill(DaSet_m_db, "medicine")
            DataGridView_medicine.DataSource = DaTable_m_db

            '**** check if Adding New or Modifying ******
            If txtMedicine_name.Enabled = True Then 'm_id = Nothing
                Dim drNewRow As DataRow = DaTable_m_db.NewRow()
                drNewRow("medicine_name") = txtMedicine_name.Text
                drNewRow("medicine_norms") = txtMedicine_norms.Text
                drNewRow("effect_date") = txtEffect_date.Text
                drNewRow("sale_unit") = cmb_sale_unit.Text
                drNewRow("sale_unit_price") = txtSale_unit_price.Text
                drNewRow("storage") = txtStorage.Text
                drNewRow("alias") = txtAlias.Text
                drNewRow("production") = txtProduction.Text
                'drNewRow("instruction") = txtMedi_quantity.Text & "|" & txtMedi_ways.Text & "|" & txtMedi_times.Text
                drNewRow("medicine_status") = "1"
                drNewRow("created_date") = DateTime.Now
                DaTable_m_db.Rows.Add(drNewRow)
                'DaAdap_m.Update(DaTable_m)
            Else
                Dim currentRow As DataRow = DaSet_m_db.Tables("medicine").Rows.Find(m_id) 'Find in the primary key
                currentRow.BeginEdit()
                currentRow("medicine_name") = txtMedicine_name.Text
                currentRow("medicine_norms") = txtMedicine_norms.Text
                currentRow("effect_date") = txtEffect_date.Text
                currentRow("sale_unit") = cmb_sale_unit.Text
                currentRow("sale_unit_price") = txtSale_unit_price.Text

                currentRow("alias") = txtAlias.Text
                currentRow("production") = txtProduction.Text
                currentRow.EndEdit()
                'DaTable_m.Rows.Add(currentRow)

                '****** 库存量新增 ***********
                If txtMStorage_add.Text.Trim() <> "" Then
                    currentRow("storage") = Int(txtStorage.Text) + Int(txtMStorage_add.Text.Trim())

                    sql_s = "select * from medicine_storage"
                    DaAdap_s = New SqlDataAdapter(sql_s, conn)
                    cmb_s = New SqlCommandBuilder(DaAdap_s)
                    DaTable_s = New DataTable
                    DaAdap_s.Fill(DaTable_s)
                    DaAdap_s.FillSchema(DaSet_s, SchemaType.Source, "medicine_storage")
                    DaAdap_s.Fill(DaSet_s, "medicine_storage")
                    'DataGridView_medicine.DataSource = DaTable_s

                    Dim drNewRow_s As DataRow = DaTable_s.NewRow()
                    drNewRow_s("medicine_id") = m_id
                    drNewRow_s("medicine_name") = txtMedicine_name.Text
                    drNewRow_s("medicine_norms") = txtMedicine_norms.Text
                    drNewRow_s("sale_unit") = cmb_sale_unit.Text
                    drNewRow_s("sale_unit_price") = txtSale_unit_price.Text
                    drNewRow_s("current_storage") = txtStorage.Text
                    drNewRow_s("add_storage") = txtMStorage_add.Text
                    drNewRow_s("storage") = Int(txtStorage.Text) + Int(txtMStorage_add.Text.Trim())
                    drNewRow_s("insert_date") = DateTime.Now
                    DaTable_s.Rows.Add(drNewRow_s)
                    DaAdap_s.Update(DaTable_s)
                    DaAdap_s.Update(DaSet_s, "medicine_storage")

                    txtMStorage_add.Text = ""
                    '****** 库存量新增项 hide ***********
                    labelMStorage_add.Visible = False
                    txtMStorage_add.Visible = False
                End If

            End If
            DaAdap_m_db.Update(DaTable_m_db)

            txtMedicine_name.Text = ""
            txtMedicine_norms.Text = ""
            txtProduction.Text = ""
            txtEffect_date.Text = ""
            txtStorage.Text = ""
            txtAlias.Text = ""
            txtSale_unit_price.Text = ""


            '*****************
            'BEGIN SEND CHANGES TO SQL SERVER
            'Dim cmb As New SqlCommandBuilder(DaAdap1)
            DaAdap_m_db.Update(DaSet_m_db, "medicine")
            'MsgBox("SQL Server updated successfully")
            '*****************

            'Me.DataGridView_medicine.Refresh()

            m_id = Nothing
            MessageBox.Show("操作成功!!")

        End If
    End Sub

    Private Sub btn_medicine_del_Click(sender As Object, e As EventArgs) Handles btn_medicine_del.Click
        If DataGridView_medicine.SelectedRows.Count > 0 Then
            Dim command As New SqlCommand
            command.CommandText = "UPDATE medicine SET medicine_status='2', cancelled_date = @current_date WHERE medicine_ID = @Mid"
            command.Parameters.Add("@Mid", SqlDbType.Int)
            command.Parameters.Add("@current_date", SqlDbType.DateTime)
            command.Connection = conn
            command.Parameters(0).Value = DataGridView_medicine.SelectedRows(0).Cells(0).Value
            command.Parameters(1).Value = DateTime.Now
            command.ExecuteNonQuery()

            MessageBox.Show("成功删除药品！")

            sql_m = "select medicine_ID, medicine_name, medicine_norms, sale_unit, sale_unit_price,storage,alias, 
                      production, effect_date from medicine WHERE medicine_status='1' ORDER BY storage "
            DaAdap_m = New SqlDataAdapter(sql_m, conn)
            cmb_m = New SqlCommandBuilder(DaAdap_m)
            DaTable_m = New DataTable
            DaAdap_m.Fill(DaTable_m)
            DaAdap_m.FillSchema(DaSet_m, SchemaType.Source, "medicine")
            DaAdap_m.Fill(DaSet_m, "medicine")
            DataGridView_medicine.DataSource = DaTable_m

            With DataGridView_medicine
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Width = 60
                .Columns(1).HeaderCell.Value = "药名"
                .Columns(1).Width = 300
                .Columns(2).HeaderCell.Value = "规格"
                .Columns(2).Width = 200
                .Columns(3).HeaderCell.Value = "单位"
                .Columns(4).HeaderCell.Value = "单价"
                .Columns(5).HeaderCell.Value = "库存量"
                .Columns(6).HeaderCell.Value = "别名"
                .Columns(7).HeaderCell.Value = "生产厂家"
                .Columns(8).HeaderCell.Value = "有效期"
            End With

            '***** heighlight库存量<10 ************
            For Each row As DataGridViewRow In DataGridView_medicine.Rows
                Dim num As Integer = Val(row.Cells(5).Value)
                If num <= 10 Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    row.DefaultCellStyle.SelectionBackColor = Color.Red
                End If
            Next
            '***** END ****************************

            '**** After operation clear search box ***
            txtMedicine_search.Text = ""
        Else
            MessageBox.Show("请先选中删除数据,然后删除！")
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If DataGridView_medicine.SelectedRows.Count > 0 Then
            m_id = DataGridView_medicine.SelectedRows(0).Cells(0).Value
            TabControl_medicine.SelectedIndex = 2
            txtMedicine_name.Text = DataGridView_medicine.SelectedRows(0).Cells(1).Value
            txtMedicine_name.Enabled = False
            txtMedicine_norms.Text = DataGridView_medicine.SelectedRows(0).Cells(2).Value
            cmb_sale_unit.Text = DataGridView_medicine.SelectedRows(0).Cells(3).Value
            txtSale_unit_price.Text = DataGridView_medicine.SelectedRows(0).Cells(4).Value
            txtStorage.Text = DataGridView_medicine.SelectedRows(0).Cells(5).Value
            txtStorage.Enabled = False
            txtAlias.Text = DataGridView_medicine.SelectedRows(0).Cells(6).Value
            txtProduction.Text = DataGridView_medicine.SelectedRows(0).Cells(7).Value
            If IsDBNull(DataGridView_medicine.SelectedRows(0).Cells(8).Value) Then
                txtEffect_date.Text = ""
            Else
                txtEffect_date.Text = DataGridView_medicine.SelectedRows(0).Cells(8).Value
            End If

            '****** 库存量新增项 hide ***********
            labelMStorage_add.Visible = True
            txtMStorage_add.Visible = True

            '**** After operation clear search box ***
            txtMedicine_search.Text = ""
        Else
            MessageBox.Show("请选择数据后才可修改内容！")
        End If
    End Sub


    Private Sub btnRefresh_MDPick_Click(sender As Object, e As EventArgs) Handles btnRefresh_MDPick.Click
        sql = "select id, patient_name, patient_id,sex,patient_age, doctor, pay_date, pay_amount,patient_contact, work_type
                    from patient_work where work_type= '3' ORDER BY pay_date DESC"
        DaAdap = New SqlDataAdapter(sql, conn)
        cmb = New SqlCommandBuilder(DaAdap)
        DaTable = New DataTable
        DaAdap.Fill(DaTable)
        DataGridView_paid.DataSource = DaTable
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

    Private Sub btnRefresh_MD_Click(sender As Object, e As EventArgs) Handles btnRefresh_MD.Click
        sql_m = "select medicine_ID, medicine_name, medicine_norms, sale_unit, sale_unit_price,storage,alias, 
                      production, effect_date from medicine WHERE medicine_status='1' ORDER BY storage "
        DaAdap_m = New SqlDataAdapter(sql_m, conn)
        cmb_m = New SqlCommandBuilder(DaAdap_m)
        DaTable_m = New DataTable
        DaAdap_m.Fill(DaTable_m)
        DaAdap_m.FillSchema(DaSet_m, SchemaType.Source, "medicine")
        DaAdap_m.Fill(DaSet_m, "medicine")
        DataGridView_medicine.DataSource = DaTable_m

        With DataGridView_medicine
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(0).Width = 60
            .Columns(1).HeaderCell.Value = "药名"
            .Columns(1).Width = 300
            .Columns(2).HeaderCell.Value = "规格"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "单位"
            .Columns(4).HeaderCell.Value = "单价"
            .Columns(5).HeaderCell.Value = "库存量"
            .Columns(6).HeaderCell.Value = "别名"
            .Columns(7).HeaderCell.Value = "生产厂家"
            .Columns(8).HeaderCell.Value = "有效期"
        End With

        '***** heighlight库存量<10 ************
        For Each row As DataGridViewRow In DataGridView_medicine.Rows
            Dim num As Integer = Val(row.Cells(5).Value)
            If num <= 10 Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.SelectionBackColor = Color.Red
            End If
        Next
        '***** END ****************************
    End Sub

    Private Sub btnRefresh_MDPickCheck_Click(sender As Object, e As EventArgs) Handles btnRefresh_MDPickCheck.Click
        sql2 = "select id, patient_name, patient_id, sex, patient_age, doctor, quyao_date, medicine_giver,patient_contact, work_type,pay_amount
                    from patient_work where work_type in('4','8') order by quyao_date DESC "
        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb = New SqlCommandBuilder(DaAdap2)
        DaTable2 = New DataTable
        DaAdap2.Fill(DaTable2)
        DaAdap2.Fill(DaSet2, "patient_work")
        DataGridView_got_medicine.DataSource = DaTable2
        With DataGridView_got_medicine
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 145
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 25
            .Columns(5).HeaderCell.Value = "医生"
            .Columns(6).HeaderCell.Value = "发药时间"
            .Columns(7).HeaderCell.Value = "发药者"
            .Columns(8).HeaderCell.Value = "病人联系方式"
            .Columns(9).HeaderCell.Value = "状态"
            .Columns(9).Width = 25
            .Columns(10).HeaderCell.Value = "金额"
            .Columns(10).Width = 50
        End With
    End Sub

    Private Sub txtMedicine_search_TextChanged(sender As Object, e As EventArgs) Handles txtMedicine_search.TextChanged
        Dim myDataview As New DataView
        Dim myBR As New BindingSource
        DaSet_m.Clear()
        sql_m = "select medicine_ID, medicine_name, medicine_norms, sale_unit, sale_unit_price,storage,alias, 
                      production, effect_date from medicine WHERE medicine_status='1' ORDER BY storage "
        DaAdap_m = New SqlDataAdapter(sql_m, conn)
        cmb_m = New SqlCommandBuilder(DaAdap_m)
        DaAdap_m.Fill(DaSet_m, "medicine")
        myDataview = DaSet_m.Tables("medicine").DefaultView
        myBR.DataSource = myDataview
        myBR.Filter = " medicine_name like '%" & txtMedicine_search.Text.Trim() & "%' or alias like '%" & txtMedicine_search.Text.Trim() & "%' "
        myBR.Sort = "storage"
        Me.DataGridView_medicine.DataSource = myBR


        With DataGridView_medicine
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(0).Width = 60
            .Columns(1).HeaderCell.Value = "药名"
            .Columns(1).Width = 300
            .Columns(2).HeaderCell.Value = "规格"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "单位"
            .Columns(4).HeaderCell.Value = "单价"
            .Columns(5).HeaderCell.Value = "库存量"
            .Columns(6).HeaderCell.Value = "别名"
            .Columns(7).HeaderCell.Value = "生产厂家"
            .Columns(8).HeaderCell.Value = "有效期"
        End With

        '***** heighlight库存量<10 ************
        For Each row As DataGridViewRow In DataGridView_medicine.Rows
            Dim num As Integer = Val(row.Cells(5).Value)
            If num <= 10 Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.SelectionBackColor = Color.Red
            End If
        Next
        '***** END ****************************
    End Sub

    Private Sub btnGID_search_Click(sender As Object, e As EventArgs) Handles btnGID_search.Click
        Dim myDataview As New DataView
        Dim myBR As New BindingSource

        DaSet2.Clear()
        sql2 = "select id, patient_name, patient_id, sex, patient_age, doctor, quyao_date, medicine_giver,patient_contact, work_type, pay_amount
                    from patient_work where work_type in('4','8') ORDER BY quyao_date DESC "
        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb = New SqlCommandBuilder(DaAdap2)
        DaAdap2.Fill(DaSet2, "patient_work")
        myDataview = DaSet2.Tables("patient_work").DefaultView
        myBR.DataSource = myDataview
        myBR.Filter = " CONVERT(id,'System.String') like '" & txtGID_search.Text.Trim() & "%' "
        myBR.Sort = "id"
        Me.DataGridView_got_medicine.DataSource = myBR

        With DataGridView_got_medicine
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 145
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 25
            .Columns(5).HeaderCell.Value = "医生"
            .Columns(6).HeaderCell.Value = "发药时间"
            .Columns(7).HeaderCell.Value = "发药者"
            .Columns(8).HeaderCell.Value = "病人联系方式"
            .Columns(9).HeaderCell.Value = "状态"
            .Columns(9).Width = 25
            .Columns(10).HeaderCell.Value = "金额"
            .Columns(10).Width = 50
        End With

    End Sub
End Class