Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

'Create new client record
Public Class frmNewClient
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery, gender As String
    Dim sqlReader As MySqlDataReader


    Private Sub rbtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub rbtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFemale.CheckedChanged
        gender = "Female"
    End Sub

    'Save info to database
    Private Sub btnSaveAcc_Click(sender As Object, e As EventArgs) Handles btnSaveAcc.Click
        If Not DateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd") Then
            Dim biodata, cardio_vasc, va_exam, history, ext_exam, int_exam, dxMngmnt As String
            Dim dialog As DialogResult
            DB.sqlConnect.Close()
            biodata = "INSERT INTO biodata VALUES(" & frmUAC.account_id & ", DEFAULT, '" & txtCardNum.Text & "', '" & txtFirstName.Text & "', '" _
                & txtSurname.Text & "', '" & txtOtherName.Text & "', '" & txtJob.Text & "', '" & DateTimePicker1.Text & "', '" & gender & "', '" _
                & txtPhoneNum.Text & "', '" & txtReligion.Text & "', '" & txtEmail.Text & "', DEFAULT);"

            'Create corresponding entries to tables in database
            'This allows all data in tables to be matched to client
            cardio_vasc = "INSERT INTO cardio_vasc(client_id) SELECT client_id FROM biodata WHERE client_id = last_insert_id();"
            va_exam = "INSERT INTO va_exam(client_id) SELECT client_id FROM biodata WHERE client_id = last_insert_id();"
            history = "INSERT INTO patient_hist(client_id) SELECT client_id FROM biodata WHERE client_id = last_insert_id();"
            ext_exam = "INSERT INTO ext_exam(client_id) SELECT client_id FROM biodata WHERE client_id = last_insert_id();"
            int_exam = "INSERT INTO int_exam(client_id) SELECT client_id FROM biodata WHERE client_id = last_insert_id();"
            dxMngmnt = "INSERT INTO dx_mngmnt(client_id) SELECT client_id FROM biodata WHERE client_id = last_insert_id();"

            sqlQuery = biodata & cardio_vasc & va_exam & history & ext_exam & int_exam & dxMngmnt

            dialog = MessageBox.Show("Please review your data entries before you save them. Click 'OK' to save.", "Check Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            If dialog = DialogResult.OK Then
                Try
                    DB.sqlConnect.Open()
                    sqlComm.CommandText = sqlQuery
                    sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                    sqlReader = sqlComm.ExecuteReader
                    MessageBox.Show("Data saved")
                    DB.sqlConnect.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    DB.sqlConnect.Dispose()
                End Try
                btnSaveAcc.Enabled = False
            Else
                btnSaveAcc.Enabled = True
            End If
        Else
            MessageBox.Show("Please enter a valid Date of Birth", "Select Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


    Private Sub frmNewClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved changes before exiting?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            'Return to client centre
            frmMainUI.ViewInPanel(frmClientCentre)
            Dispose()
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If Not txtFirstName.Text = "" Then
            btnSaveAcc.Enabled = True
        ElseIf txtFirstName.Text = "" Then
            btnSaveAcc.Enabled = False
        End If
    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        If Not txtSurname.Text = "" Then
            btnSaveAcc.Enabled = True
        ElseIf txtSurname.Text = "" Then
            btnSaveAcc.Enabled = False
        End If
    End Sub
End Class