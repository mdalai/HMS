
Imports System.Drawing.Printing
Public Class Frm_print_testing

    Private Enum PrintDestination
        Printer = 0
        PrintPreview = 1
    End Enum

    Private Sub PrintContent(ByVal Destination As PrintDestination)
        PrintDocument1.PrinterSettings.Copies = 1
        If Destination = PrintDestination.PrintPreview Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Else
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintContent(PrintDestination.Printer)
    End Sub

    Private Sub btn_print_review_Click(sender As Object, e As EventArgs) Handles btn_print_review.Click
        PrintContent(PrintDestination.PrintPreview)
    End Sub

    Dim counter As Integer = 1
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim HeaderFont As Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold)
        e.Graphics.DrawString("PRINTING PAGE " & counter & "", HeaderFont, Brushes.Blue, 250, 50 + (20 * counter))
        e.HasMorePages = True
        counter += 1
        If counter > 4 Then
            e.HasMorePages = False
            Exit Sub
        End If
    End Sub

End Class