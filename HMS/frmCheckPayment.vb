Imports System.Data
Imports System.Data.SqlClient

Public Class frmCheckPayment
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

    Private Sub frmCheckPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()
            sql = "select p_medicine_name,p_amount,p_sale_unit,p_unit_price, p_row_total from prescription where pid='" & txtID.Text & "'"
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            DataGridView_check.DataSource = DaTable
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

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmCheckPayment_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()

    End Sub
End Class