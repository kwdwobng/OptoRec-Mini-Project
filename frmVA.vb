Imports MySql.Data.MySqlClient
Imports System.Xml

'Add to visual acuity exam findings
Public Class frmVA
    Public PdOut, PdIn, Rmono, Lmono, OdUnAid, OsUnaid, OdAid, OsAid, OdPlus, OsPlus, OdPin, OsPin As String

    'Show client's biodata
    Private Sub frmVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBioTag.Text = frmCardio.BioTag
    End Sub

    'Go to history
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmMainUI.ViewInPanel(frmHistory)
        Hide()
    End Sub

    'Go to cardio
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        frmMainUI.ViewInPanel(frmCardio)
        Hide()
    End Sub

    Private Sub txtPdOut_TextChanged(sender As Object, e As EventArgs) Handles txtPdOut.TextChanged
        PdOut = txtPdOut.Text
    End Sub

    Private Sub txtPdIn_TextChanged(sender As Object, e As EventArgs) Handles txtPdIn.TextChanged
        PdIn = txtPdIn.Text
    End Sub

    Private Sub txtRmono_TextChanged(sender As Object, e As EventArgs) Handles txtRmono.TextChanged
        Rmono = txtRmono.Text
    End Sub
    Private Sub txtLmono_TextChanged(sender As Object, e As EventArgs) Handles txtLmono.TextChanged
        Lmono = txtLmono.Text
    End Sub
    Private Sub txtOdUnAid_TextChanged(sender As Object, e As EventArgs) Handles txtOdUnAid.TextChanged
        OdUnAid = txtOdUnAid.Text
    End Sub

    Private Sub txtOsUnAid_TextChanged(sender As Object, e As EventArgs) Handles txtOsUnAid.TextChanged
        OsUnAid = txtOsUnAid.Text
    End Sub

    Private Sub txtOdAid_TextChanged(sender As Object, e As EventArgs) Handles txtOdAid.TextChanged
        OdAid = txtOdAid.Text
    End Sub

    Private Sub txtOsAid_TextChanged(sender As Object, e As EventArgs) Handles txtOsAid.TextChanged
        OsAid = txtOsAid.Text
    End Sub

    Private Sub txtOdPlus_TextChanged(sender As Object, e As EventArgs) Handles txtOdPlus.TextChanged
        OdPlus = txtOdPlus.Text
    End Sub

    Private Sub txtOsPlus_TextChanged(sender As Object, e As EventArgs) Handles txtOsPlus.TextChanged
        OsPlus = txtOsPlus.Text
    End Sub

    Private Sub txtOdPin_TextChanged(sender As Object, e As EventArgs) Handles txtOdPin.TextChanged
        OdPin = txtOdPin.Text
    End Sub

    Private Sub txtOsPin_TextChanged(sender As Object, e As EventArgs) Handles txtOsPin.TextChanged
        OsPin = txtOsPin.Text
    End Sub
End Class