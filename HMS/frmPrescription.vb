Imports System.Data
Imports System.Data.SqlClient

Public Class frmPrescription
    'Public PID As Integer
    Private conn As New SqlConnection
    Private DaAdap As SqlDataAdapter
    Private DaSet As New DataSet
    Private cmb As SqlCommandBuilder
    Private DaTable As DataTable
    Private sql As String

    Private DaAdap_f As SqlDataAdapter
    Private DaTable_f As DataTable
    Private DaSet_f As New DataSet
    Private cmb_f As SqlCommandBuilder
    Private sql_f As String
    Private fee1_1st_value As String
    Private fee2_1st_value As String
    Private fee3_1st_value As String
    Private fee4_1st_value As String

    Private DaAdap_mu1 As SqlDataAdapter
    Private DaSet_mu1 As New DataSet
    Private cmb_mu1 As SqlCommandBuilder
    Private DaTable_mu1 As DataTable
    Private sql_mu1 As String

    Private Sub frmPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()
            sql = "select medicine_name, sale_unit, sale_unit_price, medicine_norms, storage, alias from medicine WHERE storage > 0 and medicine_status='1' "
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            'DaTable = New DataTable
            'DaAdap.Fill(DaTable)
            DaAdap.Fill(DaSet, "medicine")
            DataGridView_m1.DataSource = DaSet.Tables("medicine")
            With DataGridView_m1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "药名"
                .Columns(0).Width = 170
                .Columns(1).HeaderCell.Value = "单位"
                .Columns(1).Width = 30
                .Columns(2).HeaderCell.Value = "单价"
                .Columns(2).Width = 40
                .Columns(3).HeaderCell.Value = "规格"
                .Columns(3).Width = 90
                .Columns(4).HeaderCell.Value = "存量"
                .Columns(4).Width = 30
                .Columns(5).HeaderCell.Value = "别名"
            End With
            '***** hide the [alias] column ***********
            Me.DataGridView_m1.Columns("alias").Visible = False

            '****** allow only the column "quantity" editable *********
            DataGridView_m2.ReadOnly = False
            For Each col As DataGridViewColumn In Me.DataGridView_m2.Columns
                col.ReadOnly = True
            Next
            DataGridView_m2.Columns(4).ReadOnly = False
            DataGridView_m2.Columns(5).ReadOnly = False
            DataGridView_m2.Columns(6).ReadOnly = False
            DataGridView_m2.Columns(7).ReadOnly = False

            With DataGridView_m2
                '.RowHeadersVisible = False
                '.Columns(0).HeaderCell.Value = "药名"
                .Columns(0).Width = 170
                .Columns(1).Width = 30
                .Columns(2).Width = 40
                .Columns(3).Width = 100
                .Columns(4).Width = 30
                .Columns(5).Width = 90
                .Columns(6).Width = 90
                .Columns(7).Width = 90
            End With
            '****** end *********

            '****** Other Feeitem ***************************
            sql_f = "select feeitem_name, feeitem_price from feeitem WHERE feeitem_status='1' "
            DaAdap_f = New SqlDataAdapter(sql_f, conn)
            cmb_f = New SqlCommandBuilder(DaAdap_f)
            DaTable_f = New DataTable
            DaAdap_f.Fill(DaTable_f)
            DaAdap_f.FillSchema(DaSet_f, SchemaType.Source, "feeitem")
            DaAdap_f.Fill(DaSet_f, "feeitem")
            ShowDataInLvw(DaTable_f, ListView1)

            '*** 其他项费用 不可用，必须点击checkbox后才可用****
            ComboBox_fee1.Enabled = False
            ComboBox_fee2.Enabled = False
            ComboBox_fee3.Enabled = False
            ComboBox_fee4.Enabled = False

            '****** do not show Prescription_remark ***************************
            GroupBox_prescriptionRemark.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btnSelectOK_Click(sender As Object, e As EventArgs) Handles btnSelectOK.Click
        If DataGridView_m2.Rows.Count = 0 And ListView1.CheckedItems.Count = 0 And
           txt_fee1.Text = "" And txt_fee2.Text = "" And txt_fee3.Text = "" And txt_fee4.Text = "" Then
            MessageBox.Show("请开处方!!")
        Else
            '**** 判断 feeitem不能超过5项 *******
            Dim feeitem_selected_count As Integer = 0
            feeitem_selected_count += ListView1.CheckedItems.Count
            If txt_fee1.Text <> "" Then
                feeitem_selected_count += 1
            End If
            If txt_fee2.Text <> "" Then
                feeitem_selected_count += 1
            End If
            If txt_fee3.Text <> "" Then
                feeitem_selected_count += 1
            End If
            If txt_fee4.Text <> "" Then
                feeitem_selected_count += 1
            End If

            If feeitem_selected_count > 5 Then
                MessageBox.Show("其他费用项不能超过5项!!")
            Else
                '****Insert Data into table [prescription] ***********
                Dim command As New SqlCommand
                command.CommandText = "INSERT INTO prescription (PID, p_medicine_name, p_sale_unit, p_unit_price, p_amount, p_row_total,p_norms,p_instruction,insert_date)
                               VALUES (@pid, @p_Name,@p_sale_unit, @p_unit_price, @p_amount, @p_total,@p_norms,@p_instruction, @p_insert_date)"
                command.Parameters.Add("@pid", SqlDbType.Int)
                command.Parameters.Add("@p_Name", SqlDbType.VarChar)
                command.Parameters.Add("@p_sale_unit", SqlDbType.VarChar)
                command.Parameters.Add("@p_unit_price", SqlDbType.Decimal)
                command.Parameters.Add("@p_amount", SqlDbType.Int)
                command.Parameters.Add("@p_total", SqlDbType.Decimal)
                command.Parameters.Add("@p_norms", SqlDbType.VarChar)
                command.Parameters.Add("@p_instruction", SqlDbType.VarChar)
                command.Parameters.Add("@p_insert_date", SqlDbType.DateTime)
                'conn.Open()
                command.Connection = conn

                For i As Integer = 0 To DataGridView_m2.Rows.Count - 1
                    command.Parameters(0).Value = txtGuahao_ID.Text
                    command.Parameters(1).Value = DataGridView_m2.Rows(i).Cells(0).Value
                    command.Parameters(2).Value = DataGridView_m2.Rows(i).Cells(1).Value
                    command.Parameters(3).Value = DataGridView_m2.Rows(i).Cells(2).Value
                    command.Parameters(4).Value = DataGridView_m2.Rows(i).Cells(4).Value

                    command.Parameters(5).Value = DataGridView_m2.Rows(i).Cells(2).Value * DataGridView_m2.Rows(i).Cells(4).Value
                    command.Parameters(6).Value = DataGridView_m2.Rows(i).Cells(3).Value
                    command.Parameters(7).Value = DataGridView_m2.Rows(i).Cells(5).Value & "  " & DataGridView_m2.Rows(i).Cells(6).Value & "  " & DataGridView_m2.Rows(i).Cells(7).Value
                    command.Parameters(8).Value = DateTime.Now
                    command.ExecuteNonQuery()
                Next

                '****Insert Data into table [prescription_feeitem] ***********
                '**** 固定其他费用项************************
                Dim command4 As New SqlCommand
                command4.CommandText = "INSERT INTO prescription_feeitem (PFID, pf_feeitem_name, pf_feeitem_price,insert_date)
                               VALUES (@fid, @f_name, @f_price,@f_insert_date)"
                command4.Parameters.Add("@fid", SqlDbType.Int)
                command4.Parameters.Add("@f_name", SqlDbType.Text)
                command4.Parameters.Add("@f_price", SqlDbType.Decimal)
                command4.Parameters.Add("@f_insert_date", SqlDbType.DateTime)
                'conn.Open()
                command4.Connection = conn

                For Each item As ListViewItem In ListView1.CheckedItems
                    command4.Parameters(0).Value = txtGuahao_ID.Text
                    command4.Parameters(1).Value = item.Text
                    command4.Parameters(2).Value = item.SubItems(1).Text
                    command4.Parameters(3).Value = DateTime.Now
                    command4.ExecuteNonQuery()
                Next
                '**** 变动其他费用项**************************
                If CheckBox_fee1.Checked = True And txt_fee1.Text <> "" Then
                    command4.Parameters(0).Value = txtGuahao_ID.Text
                    command4.Parameters(1).Value = ComboBox_fee1.Text
                    command4.Parameters(2).Value = txt_fee1.Text
                    command4.Parameters(3).Value = DateTime.Now
                    command4.ExecuteNonQuery()
                End If

                If CheckBox_fee2.Checked = True And txt_fee2.Text <> "" Then
                    command4.Parameters(0).Value = txtGuahao_ID.Text
                    command4.Parameters(1).Value = ComboBox_fee2.Text
                    command4.Parameters(2).Value = txt_fee2.Text
                    command4.Parameters(3).Value = DateTime.Now
                    command4.ExecuteNonQuery()
                End If

                If CheckBox_fee3.Checked = True And txt_fee3.Text <> "" Then
                    command4.Parameters(0).Value = txtGuahao_ID.Text
                    command4.Parameters(1).Value = ComboBox_fee3.Text
                    command4.Parameters(2).Value = txt_fee3.Text
                    command4.Parameters(3).Value = DateTime.Now
                    command4.ExecuteNonQuery()
                End If

                If CheckBox_fee4.Checked = True And txt_fee4.Text <> "" Then
                    command4.Parameters(0).Value = txtGuahao_ID.Text
                    command4.Parameters(1).Value = ComboBox_fee4.Text
                    command4.Parameters(2).Value = txt_fee4.Text
                    command4.Parameters(3).Value = DateTime.Now
                    command4.ExecuteNonQuery()
                End If

                '****update Data in table [patient_work], [work_type=2, chufang_date=now]***********
                Dim command2 As New SqlCommand
                command2.CommandText = "UPDATE patient_work SET work_type='2', chufang_date = @current_date WHERE ID = @pid"
                command2.Parameters.Add("@pid", SqlDbType.Int)
                command2.Parameters.Add("@current_date", SqlDbType.DateTime)
                command2.Connection = conn
                command2.Parameters(0).Value = txtGuahao_ID.Text
                command2.Parameters(1).Value = DateTime.Now
                command2.ExecuteNonQuery()

                MessageBox.Show("开处方成功！")
                Me.Close()

                '******* Open frmCheckPrescription to PRINT *********************
                Dim formCheckPrescription As New frmCheckPrescription()
                formCheckPrescription = New frmCheckPrescription()
                formCheckPrescription.txtID.Text = txtGuahao_ID.Text
                formCheckPrescription.txtName.Text = txtDoctor_Name.Text
                formCheckPrescription.txtPID.Text = txtDoctor_PID.Text
                formCheckPrescription.txtSex.Text = txtSex.Text
                formCheckPrescription.txtAge.Text = txtDoctor_Age.Text
                formCheckPrescription.txtDoctor.Text = My.Settings.username
                formCheckPrescription.txtDatetime.Text = DateTime.Today
                formCheckPrescription.ShowDialog()

            End If
        End If
    End Sub

    Private Sub frmPrescription_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim myDataview As New DataView
        Dim myBR As New BindingSource
        DaSet.Clear()
        sql = "select medicine_name, sale_unit,sale_unit_price,medicine_norms,storage,alias from medicine WHERE storage > 0 and medicine_status='1' "
        DaAdap = New SqlDataAdapter(sql, conn)
        cmb = New SqlCommandBuilder(DaAdap)
        DaAdap.Fill(DaSet, "medicine")
        myDataview = DaSet.Tables("medicine").DefaultView
        myBR.DataSource = myDataview
        myBR.Filter = " medicine_name like '%" & txtSearch.Text.Trim() & "%' or alias like '%" & txtSearch.Text.Trim() & "%' "
        myBR.Sort = "medicine_name"
        Me.DataGridView_m1.DataSource = myBR

        With DataGridView_m1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "药名"
            .Columns(0).Width = 170
            .Columns(1).HeaderCell.Value = "单位"
            .Columns(1).Width = 30
            .Columns(2).HeaderCell.Value = "单价"
            .Columns(2).Width = 40
            .Columns(3).HeaderCell.Value = "规格"
            .Columns(3).Width = 90
            .Columns(4).HeaderCell.Value = "存量"
            .Columns(4).Width = 30
            .Columns(5).HeaderCell.Value = "别名"
        End With
        '***** hide the [alias] column ***********
        Me.DataGridView_m1.Columns("alias").Visible = False
    End Sub

    '****** Delete a selected row from the DataGridView *********
    Private Sub btn_delRows_Click(sender As Object, e As EventArgs) Handles btn_delRows.Click
        'Me.DataGridView_m2.Rows.Clear()
        If DataGridView_m2.SelectedCells.Count > 0 Then
            Me.DataGridView_m2.Rows.RemoveAt(DataGridView_m2.CurrentCell.RowIndex)
        Else
            MessageBox.Show("请选择删除数据")
        End If

    End Sub


    '******* Conducting selection by Double Click ***********
    Private Sub DataGridView_m1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_m1.CellDoubleClick

        '*****判断药品选择是否重复**************
        Dim repeat As Int16 = 0
        For Each row As DataGridViewRow In Me.DataGridView_m1.SelectedRows
            For j As Integer = 0 To DataGridView_m2.Rows.Count - 1
                If row.Cells(0).Value = DataGridView_m2.Rows(j).Cells(0).Value Then
                    repeat = 1
                End If
            Next
        Next

        If repeat = 1 Then
            MsgBox("不可重复选择药品！")
        Else

            For Each row As DataGridViewRow In Me.DataGridView_m1.SelectedRows
                Dim rowData(row.Cells.Count - 1) As Object
                For i As Integer = 0 To rowData.Length - 1
                    If i = 4 Then
                        rowData(i) = 1
                    ElseIf i = 5 Then
                        rowData(i) = ""
                    Else
                        rowData(i) = row.Cells(i).Value
                    End If
                Next
                Me.DataGridView_m2.Rows.Add(rowData)
            Next

            '******** 增加 用法用量 选择项******
            Dim gridComboBox1 As New DataGridViewComboBoxCell
            sql = "select * from medi_usage1 "
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            gridComboBox1.DataSource = DaTable
            gridComboBox1.DisplayMember = "medi_usage1_name"

            Dim gridComboBox2 As New DataGridViewComboBoxCell
            sql_mu1 = "select * from medi_usage2 "
            DaAdap_mu1 = New SqlDataAdapter(sql_mu1, conn)
            cmb_mu1 = New SqlCommandBuilder(DaAdap_mu1)
            DaTable_mu1 = New DataTable
            DaAdap_mu1.Fill(DaTable_mu1)
            gridComboBox2.DataSource = DaTable_mu1
            gridComboBox2.DisplayMember = "medi_usage2_name"

            Dim gridComboBox3 As New DataGridViewComboBoxCell
            sql = "select * from medi_use_unit "
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            gridComboBox3.DataSource = DaTable
            gridComboBox3.DisplayMember = "medi_use_unit"

            Dim rowCount_m2 As Integer = DataGridView_m2.RowCount - 1
            DataGridView_m2.Item(5, rowCount_m2) = gridComboBox1
            DataGridView_m2.Item(6, rowCount_m2) = gridComboBox2
            DataGridView_m2.Item(7, rowCount_m2) = gridComboBox3

            '-------- Added Invisible column to the end of DataGridView_m2, Name:storage -------------
            DataGridView_m2.Item(8, rowCount_m2).Value = DataGridView_m1.SelectedRows(0).Cells(4).Value
            'MsgBox(DataGridView_m2.Item(8, rowCount_m2).Value)

            '-------- After selection clear search box -------------
            txtSearch.Text = ""

        End If
    End Sub

    Private Sub ShowDataInLvw(ByVal data As DataTable, ByVal lvw As ListView)
        lvw.CheckBoxes = True
        lvw.View = View.Details
        lvw.GridLines = False

        lvw.Columns.Clear()
        lvw.Items.Clear()
        For Each col As DataColumn In data.Columns
            lvw.Columns.Add(col.ToString)

        Next
        lvw.Columns(0).Width = 110
        For Each row As DataRow In data.Rows
            Dim lst As ListViewItem
            lst = lvw.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
            For i As Integer = 1 To data.Columns.Count - 1
                lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, ""))
            Next
        Next

    End Sub


    '************** Other item fees those are needed to input manually *****************************************************
    Private Sub CheckBox_fee1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_fee1.CheckStateChanged
        If CheckBox_fee1.Checked = True Then
            txt_fee1.Enabled = True
            ComboBox_fee1.Enabled = True

            sql = "select * from feeitem where feeitem_status='2'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            ComboBox_fee1.DataSource = DaTable
            ComboBox_fee1.DisplayMember = "feeitem_name"
            ComboBox_fee1.SelectedIndex = 0
            fee1_1st_value = DaTable.Rows(0).Item(2).ToString
            txt_fee1.Text = fee1_1st_value

        Else
            txt_fee1.Text = ""
            txt_fee1.Enabled = False
            ComboBox_fee1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox_fee2_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_fee2.CheckStateChanged
        If CheckBox_fee2.Checked = True Then
            txt_fee2.Enabled = True
            ComboBox_fee2.Enabled = True
            sql = "select * from feeitem where feeitem_status='2'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            ComboBox_fee2.DataSource = DaTable
            ComboBox_fee2.DisplayMember = "feeitem_name"
            ComboBox_fee2.SelectedIndex = 0
            fee2_1st_value = DaTable.Rows(0).Item(2).ToString
            txt_fee2.Text = fee2_1st_value
        Else
            txt_fee2.Text = ""
            txt_fee2.Enabled = False
            ComboBox_fee2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox_fee3_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_fee3.CheckStateChanged
        If CheckBox_fee3.Checked = True Then
            txt_fee3.Enabled = True
            ComboBox_fee3.Enabled = True
            sql = "select * from feeitem where feeitem_status='2'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            ComboBox_fee3.DataSource = DaTable
            ComboBox_fee3.DisplayMember = "feeitem_name"
            ComboBox_fee3.SelectedIndex = 0
            fee3_1st_value = DaTable.Rows(0).Item(2).ToString
            txt_fee3.Text = fee3_1st_value
        Else
            txt_fee3.Text = ""
            txt_fee3.Enabled = False
            ComboBox_fee3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox_fee4_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_fee4.CheckStateChanged
        If CheckBox_fee4.Checked = True Then
            txt_fee4.Enabled = True
            ComboBox_fee4.Enabled = True
            sql = "select * from feeitem where feeitem_status='2'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            ComboBox_fee4.DataSource = DaTable
            ComboBox_fee4.DisplayMember = "feeitem_name"
            ComboBox_fee4.SelectedIndex = 0
            fee4_1st_value = DaTable.Rows(0).Item(2).ToString
            txt_fee4.Text = fee4_1st_value
        Else
            txt_fee4.Text = ""
            txt_fee4.Enabled = False
            ComboBox_fee4.Enabled = False
        End If
    End Sub

    Private Sub ComboBox_fee1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_fee1.SelectedIndexChanged
        If ComboBox_fee1.SelectedIndex = 0 Then
            txt_fee1.Text = fee1_1st_value
        Else
            sql = "select feeitem_price from feeitem where feeitem_status='2' and feeitem_name ='" & ComboBox_fee1.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            txt_fee1.Text = DaTable.Rows(0).Item(0).ToString
        End If
    End Sub

    Private Sub ComboBox_fee2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_fee2.SelectedIndexChanged
        If ComboBox_fee2.SelectedIndex = 0 Then
            txt_fee2.Text = fee2_1st_value
        Else
            sql = "select feeitem_price from feeitem where feeitem_status='2' and feeitem_name ='" & ComboBox_fee2.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            txt_fee2.Text = DaTable.Rows(0).Item(0).ToString
        End If
    End Sub

    Private Sub ComboBox_fee3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_fee3.SelectedIndexChanged
        If ComboBox_fee3.SelectedIndex = 0 Then
            txt_fee3.Text = fee3_1st_value
        Else
            sql = "select feeitem_price from feeitem where feeitem_status='2' and feeitem_name ='" & ComboBox_fee3.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            txt_fee3.Text = DaTable.Rows(0).Item(0).ToString
        End If
    End Sub

    Private Sub ComboBox_fee4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_fee4.SelectedIndexChanged
        If ComboBox_fee4.SelectedIndex = 0 Then
            txt_fee4.Text = fee4_1st_value
        Else
            sql = "select feeitem_price from feeitem where feeitem_status='2' and feeitem_name ='" & ComboBox_fee4.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            txt_fee4.Text = DaTable.Rows(0).Item(0).ToString
        End If
    End Sub

    '------- validating (1) the cell input ‘数量’ has to be 整数 (2) 输入数量不可超出库存量---------------------------------
    Private Sub DataGridView_m2_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView_m2.CellValidating
        Dim newInteger As Integer
        If e.ColumnIndex = 4 Then
            If Not Integer.TryParse(e.FormattedValue.ToString(), newInteger) _
        OrElse newInteger < 0 Then
                e.Cancel = True
                MessageBox.Show("数量必须是整数!!")
            End If

            If e.FormattedValue > DataGridView_m2.SelectedRows(0).Cells(8).Value Then
                e.Cancel = True
                MessageBox.Show("数量不能超出库存量[ " & DataGridView_m2.SelectedRows(0).Cells(8).Value & " ]")
            End If
        End If

    End Sub








    '********** selection by Button Function - May use it later***************************
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Me.DataGridView_m2.Rows.Clear()
    'For Each row As DataGridViewRow In Me.DataGridView_m1.SelectedRows
    'Dim rowData(row.Cells.Count - 1) As Object
    'For i As Integer = 0 To rowData.Length - 1
    'If i = 3 Then
    '               rowData(i) = 1
    'Else
    '               rowData(i) = row.Cells(i).Value
    'End If
    'Next
    'Me.DataGridView_m2.Rows.Add(rowData)
    'Next
    'End Sub
    '********** END *****************************************************
End Class