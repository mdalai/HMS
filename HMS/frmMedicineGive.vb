Imports System.Data
Imports System.Data.SqlClient

Public Class frmMedicineGive
    Private conn As New SqlConnection
    Private DaAdap As SqlDataAdapter
    Private DaAdap2 As SqlDataAdapter
    Private DaSet As New DataSet
    Private DaSet2 As New DataSet
    Private cmb As SqlCommandBuilder
    Private DaTable As DataTable
    Private DaTable2 As DataTable
    Private sql As String
    Private sql2 As String

    Private DaAdap_f As SqlDataAdapter
    Private DaTable_f As DataTable
    Private DaSet_f As New DataSet
    Private cmb_f As SqlCommandBuilder
    Private sql_f As String

    Private Sub frmMedicineGive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()
            sql = "select p_medicine_name,p_amount,p_sale_unit,p_unit_price, p_row_total, p_norms from prescription where pid='" & txtID.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            DataGridView_check.DataSource = DaTable
            With DataGridView_check
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "药名"
                .Columns(0).Width = 300
                .Columns(1).HeaderCell.Value = "量"
                .Columns(2).HeaderCell.Value = "单位"
                .Columns(3).HeaderCell.Value = "单价"
                .Columns(4).HeaderCell.Value = "金额"
                .Columns(5).HeaderCell.Value = "药品规格"
                .Columns(5).Width = 200
            End With

            '**** Medicine price total ****
            Dim price_total_medicine As Decimal = 0
            For i As Integer = 0 To DataGridView_check.Rows.Count - 1
                price_total_medicine += DataGridView_check.Rows(i).Cells(4).Value
            Next
            txtPriceTotal.Text = price_total_medicine

            '****** Show Other Feeitem ***************************
            sql_f = "select pf_feeitem_name, pf_feeitem_price from prescription_feeitem WHERE PFID='" & txtID.Text & "'"
            DaAdap_f = New SqlDataAdapter(sql_f, conn)
            cmb_f = New SqlCommandBuilder(DaAdap_f)
            DaTable_f = New DataTable
            DaAdap_f.Fill(DaTable_f)
            DataGridView_feeitem.DataSource = DaTable_f
            With DataGridView_feeitem
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "项目名称"
                .Columns(0).Width = 150
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

            sql2 = "select * from staff where job_type= '药物管理员' and staff_status ='有效'"
            DaAdap2 = New SqlDataAdapter(sql2, conn)
            cmb = New SqlCommandBuilder(DaAdap2)
            DaTable2 = New DataTable
            DaAdap2.Fill(DaTable2)
            cmb_giver.DataSource = DaTable2
            cmb_giver.DisplayMember = "staff_name"
            cmb_giver.Text = My.Settings.username

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPaySure_Click(sender As Object, e As EventArgs) Handles btnConfirm_medicine.Click
        '****update Data in table [patient_work], [work_type=4, quyao_date=now, medicine_giver=() ]***********
        Dim command2 As New SqlCommand
        command2.CommandText = "UPDATE patient_work SET work_type='4', quyao_date = @current_date,
                                 medicine_giver=@giver WHERE ID = @pid"
        command2.Parameters.Add("@pid", SqlDbType.Int)
        command2.Parameters.Add("@current_date", SqlDbType.DateTime)
        command2.Parameters.Add("@giver", SqlDbType.VarChar)
        command2.Connection = conn
        command2.Parameters(0).Value = txtID.Text
        command2.Parameters(1).Value = DateTime.Now
        command2.Parameters(2).Value = cmb_giver.Text
        command2.ExecuteNonQuery()

        Dim command As New SqlCommand
        command.CommandText = "UPDATE me SET  me.storage = me.storage - pr.p_amount 
        From medicine me, prescription pr WHERE me.medicine_name=pr.p_medicine_name AND pr.PID = @pid"
        command.Parameters.Add("@pid", SqlDbType.Int)
        command.Connection = conn
        command.Parameters(0).Value = txtID.Text
        command.ExecuteNonQuery()

        MessageBox.Show("成功发药！")

        Me.Close()
        ' Dim formMedicineMain As New frmMedicineMain()
        'formMedicineMain = New frmMedicineMain()
        'formMedicineMain.ShowDialog()
    End Sub
End Class