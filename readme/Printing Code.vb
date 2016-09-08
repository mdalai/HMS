
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
        ChangePageSettings()
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
'********** END PrintContent Procedure ****************

Private Sub btn_print_review_Click(sender As Object, e As EventArgs) Handles btn_print_review.Click
    PrintContent(PrintDestination.PrintPreview)
End Sub

Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '**************** Printing DataGridView ******************************* 
    With DataGridView_check
        Dim frmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        frmt.LineAlignment = StringAlignment.Center
        frmt.Trimming = StringTrimming.EllipsisCharacter

        Dim HeaderFont As Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold)
        Dim nrmlfnt As Font = New Drawing.Font("Microsoft YaHei", 9)
        Dim listheadfont As Font = New Drawing.Font("Microsoft YaHei", 8, FontStyle.Bold)
        Dim drawBrush As New SolidBrush(Color.Blue)
        Dim blackpen As New Pen(Color.Black, 1)

        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        Dim rc As RectangleF

        '**** add header ***********
        e.Graphics.DrawString("桑根达来镇卫生中心处方发药单", HeaderFont, drawBrush, 250, 50)
        e.Graphics.DrawString("姓名:     " & txtName.Text & "", nrmlfnt, drawBrush, 240, 100)
        e.Graphics.DrawString("年龄:     " & txtAge.Text & "", nrmlfnt, drawBrush, 240, 120)
        e.Graphics.DrawString("医生:     " & txtDoctor.Text & "", nrmlfnt, drawBrush, 420, 100)
        e.Graphics.DrawString("时间:     " & DateTime.Now & "", nrmlfnt, drawBrush, 420, 120)

        '**** draw line ***********
        Dim L1P1 As Point = New Point(150, 150)
        Dim L1P2 As Point = New Point(700, 150)
        e.Graphics.DrawLine(Pens.Blue, L1P1, L1P2)

        '**** add the list header ***********
        e.Graphics.DrawString("药名", listheadfont, drawBrush, 160, 155)
        e.Graphics.DrawString("数量", listheadfont, drawBrush, 330, 155)
        e.Graphics.DrawString("单位", listheadfont, drawBrush, 430, 155)
        e.Graphics.DrawString("单价", listheadfont, drawBrush, 530, 155)
        e.Graphics.DrawString("金额", listheadfont, drawBrush, 630, 155)

        '**** draw line ***********
        Dim L2P1 As Point = New Point(150, 175)
        Dim L2P2 As Point = New Point(700, 175)
        e.Graphics.DrawLine(Pens.Blue, L2P1, L2P2)

        '**** print list ***********
        Dim y As Single = e.MarginBounds.Top + 80
        Do While mRow < .RowCount
            Dim row As DataGridViewRow = .Rows(mRow)
            Dim x As Single = e.MarginBounds.Left + 60
            Dim h As Single = 0
            For Each cell As DataGridViewCell In row.Cells
                If (newpage) Then
                    Dim rc1 As RectangleF = New RectangleF(x, y - 25, cell.Size.Width - 20, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.White, rc1.Left, rc1.Top, rc1.Width, rc1.Height)
                    Dim point1 As Point = New Point(x, y - 5)
                    Dim point2 As Point = New Point(x + 100, y - 5)
                    e.Graphics.DrawLine(Pens.Black, point1, point2)
                    e.Graphics.DrawString(DataGridView_check.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc1, frmt)
                    rc = New RectangleF(x, y, cell.Size.Width - 20, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.White, rc.Left, rc.Top, rc.Width, rc.Height)
                    e.Graphics.DrawString(DataGridView_check.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString, .Font, Brushes.Black, rc, frmt)
                Else
                    rc = New RectangleF(x, y, cell.Size.Width - 20, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.White, rc.Left, rc.Top, rc.Width, rc.Height)
                    e.Graphics.DrawString(DataGridView_check.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString, .Font, Brushes.Blue, rc, frmt)
                End If

                x += rc.Width
                h = Math.Max(h, rc.Height)
            Next
            newpage = False
            y += h
            mRow += 1
            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newpage = True
                Exit Sub
            End If
        Loop
        mRow = 0

        '**** add footer ***********
        Dim pointx As New Point(150, y + 1)
        Dim pointy As New Point(700, y + 1)
        e.Graphics.DrawLine(Pens.Blue, pointx, pointy)

        Dim ObjFont2 As New Font("Microsoft YaHei", 9, FontStyle.Bold, GraphicsUnit.Point)
        e.Graphics.DrawString("总金额:    " & txtPriceTotal.Text & "  元", ObjFont2, Brushes.Blue, 500, y + 10)

    End With
End Sub