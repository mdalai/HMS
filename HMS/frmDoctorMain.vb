Imports System.Data
Imports System.Data.SqlClient

Public Class frmDoctorMain
    Private conn As New SqlConnection
    Private DaAdap As SqlDataAdapter
    Private DaSet As New DataSet
    Private cmb As SqlCommandBuilder
    Private DaTable As DataTable
    Private sql As String
    Private DaAdap2 As SqlDataAdapter
    Private DaTable2 As DataTable
    Private sql2 As String

    Private Sub frmDoctorMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()
            sql = "select id, patient_name, patient_id, sex, patient_age, doctor, guahao_date, patient_contact, '已挂号'
                    from patient_work where work_type= '1' and doctor = '" & My.Settings.username & "' order by guahao_date DESC "
            DaAdap = New SqlDataAdapter(sql, conn)
            cmb = New SqlCommandBuilder(DaAdap)
            DaTable = New DataTable
            DaAdap.Fill(DaTable)
            DataGridView_doctor.DataSource = DaTable
            With DataGridView_doctor
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "挂号ID"
                .Columns(0).Width = 50
                .Columns(1).HeaderCell.Value = "病人姓名"
                .Columns(2).HeaderCell.Value = "身份证"
                .Columns(2).Width = 145
                .Columns(3).HeaderCell.Value = "性别"
                .Columns(3).Width = 25
                .Columns(4).HeaderCell.Value = "年龄"
                .Columns(4).Width = 45
                .Columns(5).HeaderCell.Value = "挂号医生"
                .Columns(6).HeaderCell.Value = "挂号时间"
                .Columns(7).HeaderCell.Value = "病人联系方式"
                .Columns(8).HeaderCell.Value = "状态"
                .Columns(8).Width = 65
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnDoctor_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        Dim formPrescription As New frmPrescription()
        formPrescription = New frmPrescription()
        formPrescription.txtGuahao_ID.Text = DataGridView_doctor.SelectedRows(0).Cells(0).Value
        formPrescription.txtDoctor_Name.Text = DataGridView_doctor.SelectedRows(0).Cells(1).Value
        formPrescription.txtDoctor_PID.Text = DataGridView_doctor.SelectedRows(0).Cells(2).Value
        formPrescription.txtSex.Text = DataGridView_doctor.SelectedRows(0).Cells(3).Value
        formPrescription.txtDoctor_Age.Text = DataGridView_doctor.SelectedRows(0).Cells(4).Value
        formPrescription.txtDoctor_Contact.Text = DataGridView_doctor.SelectedRows(0).Cells(5).Value
        'Me.Close()
        formPrescription.ShowDialog()

        'make sure after finish prescription go to different Tab Control
        TabControl_doctor.SelectedIndex = 1
    End Sub

    Private Sub TabControl_doctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_doctor.SelectedIndexChanged
        Select Case TabControl_doctor.SelectedIndex
            Case 0 ' User clicks on First Tab
                sql = "select id, patient_name, patient_id,sex, patient_age, doctor, guahao_date, patient_contact, '已挂号'
                    from patient_work where work_type= '1' and doctor = '" & My.Settings.username & "' order by guahao_date DESC "
                DaAdap = New SqlDataAdapter(sql, conn)
                cmb = New SqlCommandBuilder(DaAdap)
                DaTable = New DataTable
                DaAdap.Fill(DaTable)
                DataGridView_doctor.DataSource = DaTable
                With DataGridView_doctor
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 145
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 45
                    .Columns(5).HeaderCell.Value = "挂号医生"
                    .Columns(6).HeaderCell.Value = "挂号时间"
                    .Columns(7).HeaderCell.Value = "病人联系方式"
                    .Columns(8).HeaderCell.Value = "状态"
                    .Columns(8).Width = 65
                End With

            Case 1 ' User clicks on Second Tab
                sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, chufang_date, patient_contact, 
                    CASE work_type WHEN '2' THEN '已开处方' WHEN '3' THEN '已付费' WHEN '4' THEN '已发药' 
                                   WHEN '7' THEN '发药前退费' WHEN '8' THEN '发药后退费' END
                    from patient_work where work_type in('2','3','4','7','8') and doctor = '" & My.Settings.username & "' order by chufang_date DESC"
                DaAdap2 = New SqlDataAdapter(sql2, conn)
                cmb = New SqlCommandBuilder(DaAdap2)
                DaTable2 = New DataTable
                DaAdap2.Fill(DaTable2)
                DaAdap2.FillSchema(DaSet, SchemaType.Source, "patient_work")
                DaAdap2.Fill(DaSet, "patient_work")
                DataGridView_prescription.DataSource = DaTable2
                With DataGridView_prescription
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "挂号ID"
                    .Columns(0).Width = 50
                    .Columns(1).HeaderCell.Value = "病人姓名"
                    .Columns(2).HeaderCell.Value = "身份证"
                    .Columns(2).Width = 145
                    .Columns(3).HeaderCell.Value = "性别"
                    .Columns(3).Width = 25
                    .Columns(4).HeaderCell.Value = "年龄"
                    .Columns(4).Width = 45
                    .Columns(5).HeaderCell.Value = "开处方医生"
                    .Columns(6).HeaderCell.Value = "开处方时间"
                    .Columns(7).HeaderCell.Value = "病人联系方式"
                    .Columns(8).HeaderCell.Value = "状态"
                    .Columns(8).Width = 65
                End With


        End Select
    End Sub

    Private Sub btn_check_prescription_Click(sender As Object, e As EventArgs) Handles btn_check_prescription.Click
        Dim formCheckPrescription As New frmCheckPrescription()
        formCheckPrescription = New frmCheckPrescription()
        formCheckPrescription.txtID.Text = DataGridView_prescription.SelectedRows(0).Cells(0).Value
        formCheckPrescription.txtName.Text = DataGridView_prescription.SelectedRows(0).Cells(1).Value
        formCheckPrescription.txtPID.Text = DataGridView_prescription.SelectedRows(0).Cells(2).Value
        formCheckPrescription.txtSex.Text = DataGridView_prescription.SelectedRows(0).Cells(3).Value
        formCheckPrescription.txtAge.Text = DataGridView_prescription.SelectedRows(0).Cells(4).Value
        formCheckPrescription.txtDoctor.Text = DataGridView_prescription.SelectedRows(0).Cells(5).Value
        formCheckPrescription.txtDatetime.Text = DataGridView_prescription.SelectedRows(0).Cells(6).Value
        formCheckPrescription.ShowDialog()
    End Sub


    Private Sub frmDoctorMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub btnRefresh_prescription_Click(sender As Object, e As EventArgs) Handles btnRefresh_prescription.Click
        sql = "select id, patient_name, patient_id, sex,patient_age, doctor, guahao_date, patient_contact, '已挂号'
                    from patient_work where work_type= '1' and doctor = '" & My.Settings.username & "' order by guahao_date DESC "
        DaAdap = New SqlDataAdapter(sql, conn)
        cmb = New SqlCommandBuilder(DaAdap)
        DaTable = New DataTable
        DaAdap.Fill(DaTable)
        DataGridView_doctor.DataSource = DaTable
        With DataGridView_doctor
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 145
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "挂号医生"
            .Columns(6).HeaderCell.Value = "挂号时间"
            .Columns(7).HeaderCell.Value = "病人联系方式"
            .Columns(8).HeaderCell.Value = "状态"
            .Columns(8).Width = 65
        End With
    End Sub

    Private Sub btnRefresh_prescriptionCheck_Click(sender As Object, e As EventArgs) Handles btnRefresh_prescriptionCheck.Click
        sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, chufang_date, patient_contact, 
                    CASE work_type WHEN '2' THEN '已开处方' WHEN '3' THEN '已付费' WHEN '4' THEN '已发药' 
                                   WHEN '7' THEN '发药前退费' WHEN '8' THEN '发药后退费' END
                    from patient_work where work_type in('2','3','4','7','8') and doctor = '" & My.Settings.username & "' order by chufang_date DESC"
        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb = New SqlCommandBuilder(DaAdap2)
        DaTable2 = New DataTable
        DaAdap2.Fill(DaTable2)
        DaAdap2.FillSchema(DaSet, SchemaType.Source, "patient_work")
        DaAdap2.Fill(DaSet, "patient_work")
        DataGridView_prescription.DataSource = DaTable2
        With DataGridView_prescription
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 145
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "开处方医生"
            .Columns(6).HeaderCell.Value = "开处方时间"
            .Columns(7).HeaderCell.Value = "病人联系方式"
            .Columns(8).HeaderCell.Value = "状态"
            .Columns(8).Width = 65
        End With
    End Sub

    Private Sub btnGuahao_search_Click(sender As Object, e As EventArgs) Handles btnGuahao_search.Click
        Dim myDataview As New DataView
        Dim myBR As New BindingSource

        DaSet.Clear()
        sql2 = "select id, patient_name, patient_id,sex, patient_age, doctor, chufang_date, patient_contact, 
                    CASE work_type WHEN '2' THEN '已开处方' WHEN '3' THEN '已付费' WHEN '4' THEN '已发药' 
                                   WHEN '7' THEN '发药前退费' WHEN '8' THEN '发药后退费' END
                    from patient_work where work_type in('2','3','4','7','8') and doctor = '" & My.Settings.username & "' order by chufang_date DESC"

        DaAdap2 = New SqlDataAdapter(sql2, conn)
        cmb = New SqlCommandBuilder(DaAdap2)
        DaAdap2.Fill(DaSet, "patient_work")
        DaAdap2.Fill(DaSet, "patient_work")
        myDataview = DaSet.Tables("patient_work").DefaultView
        myBR.DataSource = myDataview
        myBR.Filter = " patient_name like '%" & txtGuahao_search.Text.Trim() & "%' and CONVERT(id,'System.String') like '" & txtGID_search.Text.Trim() & "%' "
        myBR.Sort = "chufang_date"
        Me.DataGridView_prescription.DataSource = myBR

        With DataGridView_prescription
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "挂号ID"
            .Columns(0).Width = 50
            .Columns(1).HeaderCell.Value = "病人姓名"
            .Columns(2).HeaderCell.Value = "身份证"
            .Columns(2).Width = 145
            .Columns(3).HeaderCell.Value = "性别"
            .Columns(3).Width = 25
            .Columns(4).HeaderCell.Value = "年龄"
            .Columns(4).Width = 45
            .Columns(5).HeaderCell.Value = "开处方医生"
            .Columns(6).HeaderCell.Value = "开处方时间"
            .Columns(7).HeaderCell.Value = "病人联系方式"
            .Columns(8).HeaderCell.Value = "状态"
            .Columns(8).Width = 65
        End With
    End Sub
End Class