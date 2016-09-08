Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmCheckPrescription
    Private conn As New SqlConnection
    Private DaAdap As SqlDataAdapter
    Private DaSet As New DataSet
    Private cmb As SqlCommandBuilder
    Private DaTable As DataTable
    Private sql As String

    Private DaAdap2 As SqlDataAdapter
    Private DaSet2 As New DataSet
    Private cmb2 As SqlCommandBuilder
    Private DaTable2 As DataTable
    Private sql2 As String

    Private DaAdap_f As SqlDataAdapter
    Private DaTable_f As DataTable
    Private DaSet_f As New DataSet
    Private cmb_f As SqlCommandBuilder
    Private sql_f As String

    Private Sub frmCheckPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = dbConnString
            conn.Open()

            '******* Show the prescription data in the DataGridView ***********
            sql = "select p_medicine_name,p_amount,p_sale_unit,p_unit_price, p_row_total,p_norms,p_instruction from prescription where pid='" & txtID.Text & "'"
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
                .Columns(5).HeaderCell.Value = "规格"
                .Columns(5).Width = 120
                .Columns(6).HeaderCell.Value = "用法"
                .Columns(6).Width = 160
            End With

            '**** Medicine price total ****
            Dim price_total_medicine As Decimal = 0
            For i As Integer = 0 To DataGridView_check.Rows.Count - 1
                price_total_medicine += DataGridView_check.Rows(i).Cells(4).Value
            Next
            txtPriceTotal.Text = price_total_medicine

            '******* Show the prescription_remark in the Textbox ***********
            'sql2 = "select prescription_remark from prescription_remark where GID='" & txtID.Text & "'"
            'DaAdap2 = New SqlDataAdapter(sql2, conn)
            'cmb2 = New SqlCommandBuilder(DaAdap2)
            'DaTable2 = New DataTable
            'DaAdap2.Fill(DaTable2)
            'If DaTable2 IsNot Nothing And DaTable2.Rows.Count > 0 Then
            'txtRemark.Text = DaTable2.Rows(0)("prescription_remark").ToString()
            'Else
            'txtRemark.Text = "无"
            'End If

            '****** do not show Prescription_remark ***************************
            Label_presciptionRemark.Visible = False
            txtRemark.Visible = False

            '****** Show Other Feeitem ***************************
            sql_f = "select pf_feeitem_name, pf_feeitem_price from prescription_feeitem WHERE PFID='" & txtID.Text & "'"
            DaAdap_f = New SqlDataAdapter(sql_f, conn)
            cmb_f = New SqlCommandBuilder(DaAdap_f)
            DaTable_f = New DataTable
            DaAdap_f.Fill(DaTable_f)
            If DaTable_f IsNot Nothing And DaTable_f.Rows.Count > 0 Then
                DataGridView_feeitem.DataSource = DaTable_f
                With DataGridView_feeitem
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "项目名称"
                    .Columns(0).Width = 175
                    .Columns(1).HeaderCell.Value = "价格"
                End With
            Else
                Label_feeitem_NO.Visible = True
                Label_feeitem_NO.Text = "无"
            End If

            '**** Feeitem price total ****
            Dim price_total_feeitem As Decimal = 0
            For i As Integer = 0 To DataGridView_feeitem.Rows.Count - 1
                price_total_feeitem += DataGridView_feeitem.Rows(i).Cells(1).Value
            Next
            txtFeeitem_total.Text = price_total_feeitem

            '****** Print Review Button *********
            btn_print_review.Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmCheckPrescription_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conn.Close()
        conn.Dispose()

    End Sub

    '**********######### Printing Function ############****************
    Private Enum PrintDestination
        Printer = 0
        PrintPreview = 1
    End Enum

    '********** PrintContent Procedure ****************
    Private Sub PrintContent(ByVal Destination As PrintDestination)
        If DataGridView_check.Rows.Count = 0 And DataGridView_feeitem.Rows.Count = 0 Then
            MessageBox.Show("没有记录！！")
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

        ' Dim pagesetup As New PageSettings
        'With pagesetup
        '.Margins.Left = 10
        '.Margins.Right = 10
        '.Margins.Top = 10
        '.Margins.Bottom = 10
        '.Landscape = False
        'End With

        'Specify current page settings
        PrintDocument1.DefaultPageSettings = PrintPageSettings

    End Sub
    '********** END PrintContent Procedure ****************

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintContent(PrintDestination.Printer)
        Me.Close()
    End Sub

    Private Sub btn_print_review_Click(sender As Object, e As EventArgs) Handles btn_print_review.Click
        PrintContent(PrintDestination.PrintPreview)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim frmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        frmt.LineAlignment = StringAlignment.Center
        frmt.Trimming = StringTrimming.EllipsisCharacter

        Dim HeaderFont As Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold)
        Dim nrmlfnt As Font = New Drawing.Font("Microsoft YaHei", 9)
        Dim listheadfont As Font = New Drawing.Font("Microsoft YaHei", 8, FontStyle.Bold)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim blackpen As New Pen(Color.Black, 1)
        Dim y As Single = e.MarginBounds.Top + 80

        '**** add header ***********
        e.Graphics.DrawString("桑根达来镇中心卫生院 处方笺 ", HeaderFont, drawBrush, 270, 50)
        e.Graphics.DrawString("姓名:     " & txtName.Text & "", nrmlfnt, drawBrush, 240, 100)
        e.Graphics.DrawString("性别: " & txtSex.Text & "", nrmlfnt, drawBrush, 240, 120)
        e.Graphics.DrawString("年龄: " & txtAge.Text & "", nrmlfnt, drawBrush, 300, 120)
        e.Graphics.DrawString("医师:       " & txtDoctor.Text & "", nrmlfnt, drawBrush, 420, 100)
        e.Graphics.DrawString("打印日期:   " & DateTime.Now & "", nrmlfnt, drawBrush, 420, 120)

        '**** draw line ***********
        Dim L1P1 As Point = New Point(100, 150)
        Dim L1P2 As Point = New Point(800, 150)
        e.Graphics.DrawLine(Pens.Black, L1P1, L1P2)

        '**** add the list header ***********
        e.Graphics.DrawString("药名", listheadfont, drawBrush, 110, 155) '** width= 155
        e.Graphics.DrawString("数量", listheadfont, drawBrush, 260, 155) '** width= 70
        e.Graphics.DrawString("单位", listheadfont, drawBrush, 325, 155) '** width= 65
        e.Graphics.DrawString("单价", listheadfont, drawBrush, 390, 155) '** width= 65
        e.Graphics.DrawString("金额", listheadfont, drawBrush, 455, 155) '** width= 80
        e.Graphics.DrawString("规格", listheadfont, drawBrush, 520, 155) '** width= 100
        e.Graphics.DrawString("用法", listheadfont, drawBrush, 620, 155) '** width= 100

        '**** draw line ***********
        Dim L2P1 As Point = New Point(100, 175)
        Dim L2P2 As Point = New Point(800, 175)
        e.Graphics.DrawLine(Pens.Black, L2P1, L2P2)

        '**** Printing DataGridView Medicine ******************************* 
        With DataGridView_check
            Dim mRow As Integer = 0
            Dim newpage As Boolean = True
            Dim rc As RectangleF

            '**** print list ***********
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left + 10
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    rc = New RectangleF(x, y, cell.Size.Width - 20, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.White, rc.Left, rc.Top, rc.Width, rc.Height)
                    e.Graphics.DrawString(DataGridView_check.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString, .Font, Brushes.Black, rc, frmt)
                    'End If

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                'newpage = False
                y += h
                mRow += 1
                'If y + h > e.MarginBounds.Bottom Then
                'e.HasMorePages = True
                'newpage = True
                'Exit Sub
                'End If
            Loop
            mRow = 0
        End With

        '**** draw line ***********
        Dim pointx As New Point(100, y + 1)
        Dim pointy As New Point(800, y + 1)
        e.Graphics.DrawLine(Pens.Black, pointx, pointy)

        '**** show Medicine Fee total ***********
        Dim ObjFont5 As New Font("Microsoft YaHei", 8, FontStyle.Bold, GraphicsUnit.Point)
        e.Graphics.DrawString("药品总额:  " & txtPriceTotal.Text & " 元", ObjFont5, Brushes.Black, 500, y + 6)

        '**** Printing DataGridView FeeItem ******************************* 
        y = y + 26
        If DataGridView_feeitem.Rows.Count > 0 Then
            '**** draw line ***********
            Dim pointx1 As New Point(100, y + 5)
            Dim pointy1 As New Point(800, y + 5)
            e.Graphics.DrawLine(Pens.Black, pointx1, pointy1)

            y = y + 11
            '**** add the list header ***********
            e.Graphics.DrawString("其他项", listheadfont, drawBrush, 110, y)
            e.Graphics.DrawString("价格", listheadfont, drawBrush, 265, y)
            '**** draw line ***********
            y = y + 20
            Dim L5P1 As Point = New Point(100, y)
            Dim L5P2 As Point = New Point(800, y)
            e.Graphics.DrawLine(Pens.Black, L5P1, L5P2)

            y = y + 3
            With DataGridView_feeitem
                Dim mRow As Integer = 0
                Dim rc As RectangleF
                '**** print list ***********
                Do While mRow < .RowCount
                    Dim row As DataGridViewRow = .Rows(mRow)
                    Dim x As Single = e.MarginBounds.Left + 10
                    Dim h As Single = 0
                    For Each cell As DataGridViewCell In row.Cells
                        rc = New RectangleF(x, y, cell.Size.Width - 20, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.White, rc.Left, rc.Top, rc.Width, rc.Height)
                        e.Graphics.DrawString(DataGridView_feeitem.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString, .Font, Brushes.Black, rc, frmt)

                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    Next
                    y += h
                    mRow += 1
                Loop
                mRow = 0
            End With

        End If
        '**** draw line ***********
        Dim L4P1 As New Point(100, y + 1)
        Dim L4P2 As New Point(800, y + 1)
        e.Graphics.DrawLine(Pens.Black, L4P1, L4P2)

        '**** show FeeItem Fee total ***********
        Dim ObjFont6 As New Font("Microsoft YaHei", 8, FontStyle.Bold, GraphicsUnit.Point)
        e.Graphics.DrawString("其他项总额:  " & txtFeeitem_total.Text & " 元", ObjFont6, Brushes.Black, 500, y + 6)

        '**** Printing prescription_remark ***********
        'Dim ObjFont3 As New Font("Microsoft YaHei", 10, FontStyle.Bold, GraphicsUnit.Point)
        'e.Graphics.DrawString("【处方描述】:    ", ObjFont3, Brushes.Black, 150, y + 30)
        'Dim ObjFont2 As New Font("Microsoft YaHei", 10, FontStyle.Regular, GraphicsUnit.Point)
        'e.Graphics.DrawString(" " & txtRemark.Text, ObjFont2, Brushes.Black, 160, y + 55)

        '**** Printing prescription_remark ***********
        Dim ObjFont4 As New Font("Microsoft YaHei", 10, FontStyle.Bold, GraphicsUnit.Point)
        e.Graphics.DrawString("医师签字:    ", ObjFont4, Brushes.Black, 500, y + 30)
        '**** draw underline ***********
        y = y + 30
        Dim L6P1 As New Point(570, y + 20)
        Dim L6P2 As New Point(800, y + 20)
        e.Graphics.DrawLine(Pens.Black, L6P1, L6P2)


    End Sub

    '**********######### END Printing Function ############****************
End Class