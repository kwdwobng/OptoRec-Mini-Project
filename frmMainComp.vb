'View complete clinical form
Imports System.Drawing.Printing
Imports Org.BouncyCastle.Asn1
Imports Org.BouncyCastle.Crypto.Agreement
Public Class frmMainComp
    'Function to display form in panel
    Public Sub ViewInPanel(ByRef ViewForm As Form)
        Panel1.Controls.Clear()
        ViewForm.TopLevel = False
        Panel1.Controls.Add(ViewForm)
        ViewForm.Show()
    End Sub

    'Go to next page
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ViewInPanel(CompForm2)
        CompForm1.Hide()
        Label1.Text = "Page 2 of 2"
        btnPrev.Enabled = True
        btnNext.Enabled = False
    End Sub

    'Go to previous page
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ViewInPanel(CompForm1)
        CompForm2.Hide()
        Label1.Text = "Page 1 of 2"
        btnPrev.Enabled = False
        btnNext.Enabled = True
    End Sub

End Class