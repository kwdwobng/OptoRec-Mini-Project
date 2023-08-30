Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports MySql.Data.MySqlClient

'Add diagnoses, management and clinical comments
Public Class frmDDx
    Public Dx, Px, comments As String

    Private Sub frmDDx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBioTag.Select()
        txtBioTag.Text = frmCardio.BioTag 'Show client's biodata
    End Sub
    'Go to exam form
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        frmMainUI.ViewInPanel(frmExam)
        Hide()
    End Sub

    'Diagnosis
    Private Sub txtDx_TextChanged(sender As Object, e As EventArgs) Handles txtDx.TextChanged
        Dx = txtDx.Text
    End Sub

    'Prescription
    Private Sub txtPx_TextChanged(sender As Object, e As EventArgs) Handles txtPx.TextChanged
        Px = txtPx.Text
    End Sub

    Private Sub txtComments_TextChanged(sender As Object, e As EventArgs) Handles txtComments.TextChanged
        Comments = txtComments.Text
    End Sub
End Class