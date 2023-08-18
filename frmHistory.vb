Imports MySql.Data.MySqlClient

'Add history findings
Public Class frmHistory
    Dim odq, front, temp, occip, pain, photo, diplo, red, burn, halo, dischar, float, flash, prick, tear, itch, grit As String
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult
    Dim card_num, surname, first_name, other_name, age As String

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPC.Select()

        sqlQuery = "SELECT card_num, first_name, other_name, surname, timestampdiff(YEAR, birth_date, curdate()) AS 'Age' FROM biodata WHERE client_id =" & frmClientCentre.client_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            While sqlReader.Read
                card_num = sqlReader.GetString("card_num")
                first_name = sqlReader.GetString("first_name")
                other_name = sqlReader.GetString("other_name")
                surname = sqlReader.GetString("surname")
                age = sqlReader.GetString("Age")
            End While

            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
        txtBioTag.Text = card_num & ", " & first_name & " " & other_name & " " & surname & ", " & age & " years old"
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
        dischar = "Discharge "
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

    'Go to VA form
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmVA)
            Hide()
        End If
    End Sub

    'Go to history form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmExam)
            Hide()
        End If
    End Sub

    'Save info to database
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        odq = front & temp & occip & pain & photo & diplo & red & burn & halo & float & flash & prick & dischar & tear & itch & grit

        If Not odq = "" Then
            odq = Replace(odq, " ", ", ")
            odq = Replace(odq, "_", " ")
            odq = odq.Remove(odq.LastIndexOf(","))
        End If

        sqlQuery = "UPDATE patient_hist SET pc_cc='" & txtPC.Text & "', hpc='" & txtHPC.Text & "', odq='" & odq & "', poh='" & txtPOH.Text & "',pmh_psh='" _
            & txtPMH.Text & "', dh ='" & txtDH.Text & "', allergy ='" & txtAllerg.Text & "', sh ='" & txtSH.Text & "', foh ='" & txtFOH.Text & "', fmh ='" _
            & txtFMH.Text & "', ddx='" & txtDdx.Text & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        dialog = MessageBox.Show("Do want to update the current data entries in your record?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Data Updated")
                sqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If
    End Sub


End Class