Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports MySql.Data.MySqlClient

'Add internal/external exam findings
Public Class frmExam
    Public OdLids, OsLids, OdConjuct, OsConjuct, OdCornea, OsCornea, OdAc, OsAc, OdLens, OsLens, OdIris, Osiris, OdPupil, OsPupil As String
    Public OdVitr, OsVitr, OdDisc, OsDisc, OdCd, OsCd, OdRim, OsRim, OdAv, OsAv, OdPeripap, OsPeripap, OdMacular, OsMacular, OdPeriRet, OsPeriRet As String


    'Show client biodata
    Private Sub frmExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBioTag.Select()
        txtBioTag.Text = frmCardio.BioTag
    End Sub

    'Go to history form
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        frmMainUI.ViewInPanel(frmHistory)
        Hide()
    End Sub

    'Go to diagnoses etc. form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmMainUI.ViewInPanel(frmDDx)
        Hide()
    End Sub

    Private Sub txtOdLids_TextChanged(sender As Object, e As EventArgs) Handles txtOdLids.TextChanged
        OdLids = txtOdLids.Text
    End Sub

    Private Sub txtOsLids_TextChanged(sender As Object, e As EventArgs) Handles txtOsLids.TextChanged
        OsLids = txtOsLids.Text
    End Sub

    Private Sub txtOdConjuct_TextChanged(sender As Object, e As EventArgs) Handles txtOdConjuct.TextChanged
        OdConjuct = txtOdConjuct.Text
    End Sub

    Private Sub txtOsConjuct_TextChanged(sender As Object, e As EventArgs) Handles txtOsConjuct.TextChanged
        OsConjuct = txtOsConjuct.Text
    End Sub

    Private Sub txtOdCornea_TextChanged(sender As Object, e As EventArgs) Handles txtOdCornea.TextChanged
        OdCornea = txtOdCornea.Text
    End Sub

    Private Sub txtOsCornea_TextChanged(sender As Object, e As EventArgs) Handles txtOsCornea.TextChanged
        OsCornea = txtOsCornea.Text
    End Sub

    Private Sub txtOdAc_TextChanged(sender As Object, e As EventArgs) Handles txtOdAc.TextChanged
        OdAc = txtOdAc.Text
    End Sub

    Private Sub txtOsAc_TextChanged(sender As Object, e As EventArgs) Handles txtOsAc.TextChanged
        OsAc = txtOsAc.Text
    End Sub

    Private Sub txtOdLens_TextChanged(sender As Object, e As EventArgs) Handles txtOdLens.TextChanged
        OdLens = txtOdLens.Text
    End Sub

    Private Sub txtOsLens_TextChanged(sender As Object, e As EventArgs) Handles txtOsLens.TextChanged
        OsLens = txtOsLens.Text
    End Sub

    Private Sub txtOdIris_TextChanged(sender As Object, e As EventArgs) Handles txtOdIris.TextChanged
        OdIris = txtOdIris.Text
    End Sub

    Private Sub txtOsIris_TextChanged(sender As Object, e As EventArgs) Handles txtOsIris.TextChanged
        Osiris = txtOsIris.Text
    End Sub

    Private Sub txtOdPupil_TextChanged(sender As Object, e As EventArgs) Handles txtOdPupil.TextChanged
        OdPupil = txtOdPupil.Text
    End Sub

    Private Sub txtOdVitr_TextChanged(sender As Object, e As EventArgs) Handles txtOdVitr.TextChanged
        OdVitr = txtOdVitr.Text
    End Sub

    Private Sub txtOsVitr_TextChanged(sender As Object, e As EventArgs) Handles txtOsVitr.TextChanged
        OsVitr = txtOsVitr.Text
    End Sub

    Private Sub txtOdDisc_TextChanged(sender As Object, e As EventArgs) Handles txtOdDisc.TextChanged
        OdDisc = txtOdDisc.Text
    End Sub

    Private Sub txtOsDisc_TextChanged(sender As Object, e As EventArgs) Handles txtOsDisc.TextChanged
        OsDisc = txtOsDisc.Text
    End Sub

    Private Sub txtOdCd_TextChanged(sender As Object, e As EventArgs) Handles txtOdCd.TextChanged
        OdCd = txtOdCd.Text
    End Sub

    Private Sub txtOsCd_TextChanged(sender As Object, e As EventArgs) Handles txtOsCd.TextChanged
        OsCd = txtOsCd.Text
    End Sub

    Private Sub txtOdRim_TextChanged(sender As Object, e As EventArgs) Handles txtOdRim.TextChanged
        OdRim = txtOdRim.Text
    End Sub

    Private Sub txtOsRim_TextChanged(sender As Object, e As EventArgs) Handles txtOsRim.TextChanged
        OsRim = txtOsRim.Text
    End Sub

    Private Sub txtOdAv_TextChanged(sender As Object, e As EventArgs) Handles txtOdAv.TextChanged
        OdAv = txtOdAv.Text
    End Sub

    Private Sub txtOsAv_TextChanged(sender As Object, e As EventArgs) Handles txtOsAv.TextChanged
        OsAv = txtOsAv.Text
    End Sub

    Private Sub txtOdPeripap_TextChanged(sender As Object, e As EventArgs) Handles txtOdPeripap.TextChanged
        OdPeripap = txtOdPeripap.Text
    End Sub

    Private Sub txtOsPeripap_TextChanged(sender As Object, e As EventArgs) Handles txtOsPeripap.TextChanged
        OsPeripap = txtOsPeripap.Text
    End Sub

    Private Sub txtOdMacular_TextChanged(sender As Object, e As EventArgs) Handles txtOdMacular.TextChanged
        OdMacular = txtOdMacular.Text
    End Sub

    Private Sub txtOsMacular_TextChanged(sender As Object, e As EventArgs) Handles txtOsMacular.TextChanged
        OsMacular = txtOsMacular.Text
    End Sub

    Private Sub txtOdPeriRet_TextChanged(sender As Object, e As EventArgs) Handles txtOdPeriRet.TextChanged
        OdPeriRet = txtOdPeriRet.Text
    End Sub

    Private Sub txtOsPeriRet_TextChanged(sender As Object, e As EventArgs) Handles txtOsPeriRet.TextChanged
        OsPeriRet = txtOsPeriRet.Text
    End Sub
End Class