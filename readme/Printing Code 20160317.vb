



Private Enum PrintDestination
    Printer = 0
    PrintPreview = 1
End Enum

'********** PrintContent Procedure ****************
Private Sub PrintContent(ByVal Destination As PrintDestination)
    If DataGridView_check.Rows.Count = 0 And DataGridView_feeitem.Rows.Count = 0 Then
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
'********** END PrintContent Procedure ****************


Private Sub btn_print_review_Click(sender As Object, e As EventArgs) Handles btn_print_review.Click
    PrintContent(PrintDestination.PrintPreview)
End Sub

Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '**************** Printing Invoice ******************************* 
    'Dim HeaderFont As Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold)
    Dim nrmlfnt As Font = New Drawing.Font("Microsoft YaHei", 9)
    Dim nrmlfnt2 As Font = New Drawing.Font("Microsoft YaHei", 7.5)
    Dim drawBrush As New SolidBrush(Color.Blue)
    Dim ObjFont2 As New Font("Microsoft YaHei", 9, FontStyle.Bold, GraphicsUnit.Point)

    Dim newpage As Boolean = False
    Dim price_total_all_da_p1 As String
    Dim price_total_all_da_p2 As String
    Dim price_total_all_p1 As Decimal = 0
    Dim price_total_all_p2 As Decimal = 0
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim h As Integer = 0

    price_total_all_p1 = txtPriceTotal.Text

    '**** add header ***********
    'e.Graphics.DrawString("桑根达来镇中心卫生院处方发药单", HeaderFont, drawBrush, 250, 50)
    x = 105 'before=135
    e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt, drawBrush, x + 10, 70)
    e.Graphics.DrawString(" 医药费 ", nrmlfnt, drawBrush, x, 105)
    e.Graphics.DrawString(" " & txtPriceTotal.Text & "", nrmlfnt, drawBrush, x, 140)
    '*** if there is 其他项费用
    Dim feeitem_index As Integer = 0
    Do While feeitem_index < DataGridView_feeitem.Rows.Count
        Select Case feeitem_index
            Case 0
                price_total_all_p1 += DataGridView_feeitem.Rows(0).Cells(1).Value
                x = 205 '235
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(0).Cells(0).Value & "", nrmlfnt, drawBrush, x, 105) '其他项1
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(0).Cells(1).Value & "", nrmlfnt, drawBrush, x, 140)
                '***** add reciept for feeItem  (x=140) x=+25********
                x = 605 '625
                y = 90 '80
                h = 35
                e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt2, drawBrush, x, y)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(0).Cells(0).Value & "", nrmlfnt2, drawBrush, x, y + h)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(0).Cells(1).Value & "", nrmlfnt2, drawBrush, x, y + (2 * h))
                e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt2, drawBrush, x, y + (3 * h))
                e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt2, drawBrush, x, y + (4 * h))
            Case 1
                price_total_all_p1 += DataGridView_feeitem.Rows(1).Cells(1).Value
                x = 305 '335
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(1).Cells(0).Value & "", nrmlfnt, drawBrush, x, 105) '其他项2
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(1).Cells(1).Value & "", nrmlfnt, drawBrush, x, 140)
                '***** add reciept for feeItem2  (x=140) x=+25********
                x = 745 '765
                y = 90 '80
                h = 35
                e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt2, drawBrush, x, y)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(1).Cells(0).Value & "", nrmlfnt2, drawBrush, x, y + h)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(1).Cells(1).Value & "", nrmlfnt2, drawBrush, x, y + (2 * h))
                e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt2, drawBrush, x, y + (3 * h))
                e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt2, drawBrush, x, y + (4 * h))

            Case 2
                price_total_all_p2 += DataGridView_feeitem.Rows(2).Cells(1).Value
                y = 365 '355
                x = 105 '135
                e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt, drawBrush, x + 10, y + 70)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(2).Cells(0).Value & "", nrmlfnt, drawBrush, x, y + 105)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(2).Cells(1).Value & "", nrmlfnt, drawBrush, x, y + 140)
                '***** add reciept for feeItem3  (x=140) x=+25********
                x = 465 '485
                e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt2, drawBrush, x, y + 80)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(2).Cells(0).Value & "", nrmlfnt2, drawBrush, x, y + 115)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(2).Cells(1).Value & "", nrmlfnt2, drawBrush, x, y + 150)
                e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt2, drawBrush, x, y + 185)
                e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt2, drawBrush, x, y + 220)
                    'e.HasMorePages = True
                    'Exit Sub
            Case 3
                price_total_all_p2 += DataGridView_feeitem.Rows(3).Cells(1).Value
                y = 365
                x = 205 '235
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(3).Cells(0).Value & "", nrmlfnt, drawBrush, x, y + 105) '其他项4
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(3).Cells(1).Value & "", nrmlfnt, drawBrush, x, y + 140)
                '***** add reciept for feeItem4  ********
                x = 605 '625
                e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt2, drawBrush, x, y + 80)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(3).Cells(0).Value & "", nrmlfnt2, drawBrush, x, y + 115)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(3).Cells(1).Value & "", nrmlfnt2, drawBrush, x, y + 150)
                e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt2, drawBrush, x, y + 185)
                e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt2, drawBrush, x, y + 220)

            Case 4
                price_total_all_p2 += DataGridView_feeitem.Rows(4).Cells(1).Value
                y = 365
                x = 305 'before=335
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(4).Cells(0).Value & "", nrmlfnt, drawBrush, x, y + 105) '其他项5
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(4).Cells(1).Value & "", nrmlfnt, drawBrush, x, y + 140)
                '***** add reciept for feeItem5  (x=140) x=+25********
                x = 745 '765
                e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt2, drawBrush, x, y + 80)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(4).Cells(0).Value & "", nrmlfnt2, drawBrush, x, y + 115)
                e.Graphics.DrawString(" " & DataGridView_feeitem.Rows(4).Cells(1).Value & "", nrmlfnt2, drawBrush, x, y + 150)
                e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt2, drawBrush, x, y + 185)
                e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt2, drawBrush, x, y + 220)
        End Select
        feeitem_index += 1

    Loop

    price_total_all_da_p1 = ConvertToRMB(price_total_all_p1) '金额大写显示 ***
    x = 105 '135
    e.Graphics.DrawString(" " & price_total_all_da_p1 & "", ObjFont2, drawBrush, x, 175)
    e.Graphics.DrawString(" " & price_total_all_p1 & "", ObjFont2, drawBrush, x + 208, 175)
    e.Graphics.DrawString(" " & DateTime.Now & "", nrmlfnt, drawBrush, x - 5, 210)
    e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt, drawBrush, x + 165, 210)
    e.Graphics.DrawString(" " & My.Settings.username & "", nrmlfnt, drawBrush, x + 165, 245)

    '***** add reciept for medicine (x=125) x=+25*******
    x = 465 '485
    y = 90 '80
    e.Graphics.DrawString(" " & txtName.Text & "", nrmlfnt2, drawBrush, x, y)
    e.Graphics.DrawString(" 医药费 ", nrmlfnt2, drawBrush, x, y + 35)
    e.Graphics.DrawString(" " & txtPriceTotal.Text & "", nrmlfnt2, drawBrush, x, y + 70)
    e.Graphics.DrawString(" " & DateTime.Today & "", nrmlfnt2, drawBrush, x, y + 105)
    e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt2, drawBrush, x, y + 140)

    '*********** 第二页***************************************************************
    If DataGridView_feeitem.Rows.Count > 2 Then
        y = 355
        x = 105 ' 135
        price_total_all_da_p2 = ConvertToRMB(price_total_all_p2) '金额大写显示 ***
        e.Graphics.DrawString(" " & price_total_all_da_p2 & "", ObjFont2, drawBrush, x, y + 175)
        e.Graphics.DrawString(" " & price_total_all_p2 & "", ObjFont2, drawBrush, x + 208, y + 175)
        e.Graphics.DrawString(" " & DateTime.Now & "", nrmlfnt, drawBrush, x - 5, y + 210)
        e.Graphics.DrawString(" " & txtID.Text & "", nrmlfnt, drawBrush, x + 165, y + 210)
        e.Graphics.DrawString(" " & My.Settings.username & "", nrmlfnt, drawBrush, x + 165, y + 245)
    End If

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
