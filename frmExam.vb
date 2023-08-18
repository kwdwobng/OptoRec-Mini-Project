Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports MySql.Data.MySqlClient

'Add internal/external exam findings
Public Class frmExam
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery, ext_exam, int_exam As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult
    Dim card_num, surname, first_name, other_name, age As String

    'Show client's biodata
    Private Sub frmExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOdLids.Select()

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
    'Go to history form
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmHistory)
            Hide()
        End If
    End Sub

    'Go to diagnoses etc. form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmDDx)
            Hide()
        End If
    End Sub

    'Save info to database
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        sqlConn.ConnectionString = "server=localhost;userid=root;password=;database=opt_app"
        ext_exam = "UPDATE ext_exam SET od_lids='" & txtOdLids.Text & "', od_conjuct='" & txtOdConjuct.Text & "', od_cornea='" & txtOdCornea.Text & "', od_ac='" _
            & txtOdAc.Text & "', od_iris='" & txtOdIris.Text & "', od_pupil='" & txtOdPupil.Text & "', od_lens='" & txtOdLens.Text &
            "', os_lids='" & txtOsLids.Text & "', os_conjuct='" & txtOsConjuct.Text & "', os_cornea='" & txtOsCornea.Text & "', os_ac='" _
            & txtOsAc.Text & "', os_iris='" & txtOsIris.Text & "', os_pupil='" & txtOsPupil.Text & "', os_lens='" & txtOsLens.Text &
           "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        int_exam = "UPDATE int_exam SET od_vitr='" & txtOdVitr.Text & "', od_disc='" & txtOdDisc.Text & "', od_cd='" & txtOdCd.Text & "', od_rim='" & txtOdRim.Text &
            "', od_av='" & txtOdAv.Text & "', od_peripap='" & txtOdPeripap.Text & "', od_macular='" & txtOdMacular.Text & "', od_peri_ret='" & txtOdPeriRet.Text &
            "', os_vitr='" & txtOsVitr.Text & "', os_disc='" & txtOsDisc.Text & "', os_cd='" & txtOsCd.Text & "', os_rim='" & txtOsRim.Text & "', os_av='" _
            & txtOsAv.Text & "', os_peripap='" & txtOsPeripap.Text & "', os_macular='" & txtOsMacular.Text & "', os_peri_ret='" & txtOsPeriRet.Text &
            "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        sqlQuery = ext_exam & int_exam
        dialog = MessageBox.Show("Do want to update the current data entries in your record?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Data Saved")
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If
    End Sub

End Class