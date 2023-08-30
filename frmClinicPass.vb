Imports MySql.Data.MySqlClient

'Login to Clinical Environment
Public Class frmClinicalPass
    Public username, password As String
    Dim sqlComm As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlQuery As String
    Private Sub frmClinicalPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPassword.Select()
    End Sub

    'Login to consultation
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim count As Integer
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM passwords WHERE password2 = '" & txtPassword.Text & "' AND account_id=" & frmAccPass.account_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader

            While sqlReader.Read
                count += 1
            End While

            If count = 1 Then
                password = txtPassword.Text
                txtPassword.Clear()
            Else
                MessageBox.Show("Username or password is incorrect.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

        'Start new consultation
        If count = 1 Then
            Dim consult, cardio_vasc, va_exam, patient_hist, ext_exam, int_exam, dx_mngmnt As String
            Dim dialog As DialogResult

            consult = "INSERT INTO consult VALUES(DEFAULT, DEFAULT);"

            cardio_vasc = "INSERT INTO cardio_vasc(consult_id, client_id) VALUES((SELECT MAX(consult_id) FROM consult), " & frmClientCentre.client_id & ");"
            va_exam = "INSERT INTO va_exam(consult_id, client_id) VALUES((SELECT MAX(consult_id) FROM consult), " & frmClientCentre.client_id & ");"
            patient_hist = "INSERT INTO patient_hist(consult_id, client_id) VALUES((SELECT MAX(consult_id) FROM consult), " & frmClientCentre.client_id & ");"
            ext_exam = "INSERT INTO ext_exam(consult_id, client_id) VALUES((SELECT MAX(consult_id) FROM consult), " & frmClientCentre.client_id & ");"
            int_exam = "INSERT INTO int_exam(consult_id, client_id) VALUES((SELECT MAX(consult_id) FROM consult), " & frmClientCentre.client_id & ");"
            dx_mngmnt = "INSERT INTO dx_mngmnt(consult_id, client_id) VALUES((SELECT MAX(consult_id) FROM consult), " & frmClientCentre.client_id & ");"


            sqlQuery = consult & cardio_vasc & va_exam & patient_hist & ext_exam & int_exam & dx_mngmnt

            dialog = MessageBox.Show("Do you wish to start a new consultation session with a client?", "New Consultation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dialog = DialogResult.Yes Then
                Try
                    DB.sqlConnect.Open()
                    sqlComm.CommandText = sqlQuery
                    sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                    sqlReader = sqlComm.ExecuteReader
                    MessageBox.Show("New consultation ready to start")
                    DB.sqlConnect.Close()
                    frmMainUI.ViewInPanel(frmCardio)
                    Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    DB.sqlConnect.Dispose()
                End Try
                Hide()
                frmConsultView.WindowState = FormWindowState.Minimized
            End If
        End If
    End Sub

    'Show password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class