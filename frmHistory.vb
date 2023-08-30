Imports System.Runtime.Intrinsics.X86
Imports MySql.Data.MySqlClient

'Add history findings
Public Class frmHistory
    Public front, temp, occip, pain, photo, diplo, red, burn, halo, discharge, float, flash, prick, tear, itch, grit As String
    Public PC, HPC, POH, FOH, SH, DH, FMH, PMH, Ddx, allergies As String

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBioTag.Select()
        txtBioTag.Text = frmCardio.BioTag
    End Sub

    Private Sub chkFront_CheckedChanged(sender As Object, e As EventArgs) Handles chkFront.CheckedChanged
        front = "Frontal_Headache "
    End Sub

    Private Sub chkTemp_CheckedChanged(sender As Object, e As EventArgs) Handles chkTemp.CheckedChanged
        temp = "Temporal_Headache "
    End Sub

    Private Sub chkOcc_CheckedChanged(sender As Object, e As EventArgs) Handles chkOcc.CheckedChanged
        occip = "Occipital_Headache "
    End Sub

    Private Sub chkPain_CheckedChanged(sender As Object, e As EventArgs) Handles chkPain.CheckedChanged
        pain = "Pain "
    End Sub

    Private Sub chkPhoto_CheckedChanged(sender As Object, e As EventArgs) Handles chkPhoto.CheckedChanged
        photo = "Photophobia "
    End Sub

    Private Sub chkHalo_CheckedChanged(sender As Object, e As EventArgs) Handles chkHalo.CheckedChanged
        halo = "Haloes "
    End Sub

    Private Sub chkFloat_CheckedChanged(sender As Object, e As EventArgs) Handles chkFloat.CheckedChanged
        float = "Foaters "
    End Sub

    Private Sub chkFlash_CheckedChanged(sender As Object, e As EventArgs) Handles chkFlash.CheckedChanged
        flash = "Flashes_of_Light "
    End Sub

    Private Sub chkPrick_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrick.CheckedChanged
        prick = "Prickly "
    End Sub

    Private Sub chkDisch_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisch.CheckedChanged
        discharge = "Discharge "
    End Sub

    Private Sub chkTear_CheckedChanged(sender As Object, e As EventArgs) Handles chkTear.CheckedChanged
        tear = "Tearing "
    End Sub

    Private Sub chkDiplo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiplo.CheckedChanged
        diplo = "Diplopia "
    End Sub

    Private Sub chkItch_CheckedChanged(sender As Object, e As EventArgs) Handles chkItch.CheckedChanged
        itch = "Itchiness "
    End Sub

    Private Sub chkBurn_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurn.CheckedChanged
        burn = "Burning_Sensation "
    End Sub

    Private Sub chkGrit_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrit.CheckedChanged
        grit = "Gritty_Sensation "
    End Sub

    Private Sub chkRed_CheckedChanged(sender As Object, e As EventArgs) Handles chkRed.CheckedChanged
        red = "Redness "
    End Sub

    Private Sub txtPC_TextChanged(sender As Object, e As EventArgs) Handles txtPC.TextChanged
        PC = txtPC.Text
    End Sub

    Private Sub txtHPC_TextChanged(sender As Object, e As EventArgs) Handles txtHPC.TextChanged
        HPC = txtHPC.Text
    End Sub

    Private Sub txtPOH_TextChanged(sender As Object, e As EventArgs) Handles txtPOH.TextChanged
        POH = txtPOH.Text
    End Sub

    Private Sub txtPMH_TextChanged(sender As Object, e As EventArgs) Handles txtPMH.TextChanged
        PMH = txtPMH.Text
    End Sub

    Private Sub txtDH_TextChanged(sender As Object, e As EventArgs) Handles txtDH.TextChanged
        DH = txtDH.Text
    End Sub

    Private Sub txtAllerg_TextChanged(sender As Object, e As EventArgs) Handles txtAllerg.TextChanged
        allergies = txtAllerg.Text
    End Sub

    Private Sub txtSH_TextChanged(sender As Object, e As EventArgs) Handles txtSH.TextChanged
        SH = txtSH.Text
    End Sub

    Private Sub txtFOH_TextChanged(sender As Object, e As EventArgs) Handles txtFOH.TextChanged
        FOH = txtFOH.Text
    End Sub

    Private Sub txtFMH_TextChanged(sender As Object, e As EventArgs) Handles txtFMH.TextChanged
        FMH = txtFMH.Text
    End Sub

    Private Sub txtDdx_TextChanged(sender As Object, e As EventArgs) Handles txtDdx.TextChanged
        Ddx = txtDdx.Text
    End Sub


    'Go to VA form
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        frmMainUI.ViewInPanel(frmVA)
        Hide()
    End Sub

    'Go to history form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmMainUI.ViewInPanel(frmExam)
        Hide()
    End Sub
End Class