<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_print_testing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_print_testing))
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_print_review = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(33, 136)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 0
        Me.btn_print.Text = "print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_print_review
        '
        Me.btn_print_review.Location = New System.Drawing.Point(124, 136)
        Me.btn_print_review.Name = "btn_print_review"
        Me.btn_print_review.Size = New System.Drawing.Size(75, 23)
        Me.btn_print_review.TabIndex = 1
        Me.btn_print_review.Text = "print_review"
        Me.btn_print_review.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Frm_print_testing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_print_review)
        Me.Controls.Add(Me.btn_print)
        Me.Name = "Frm_print_testing"
        Me.Text = "Frm_print_testing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_print As Button
    Friend WithEvents btn_print_review As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
