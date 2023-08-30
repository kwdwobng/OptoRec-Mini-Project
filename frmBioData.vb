Imports MySql.Data.MySqlClient

'Display client biodata
Public Class frmBioData
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult

    Private Sub frmBioData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display client biodata from database
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM biodata WHERE client_id =" & frmClientCentre.client_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader

            While sqlReader.Read
                txtCardNum.Text = sqlReader.GetString("card_num")
                txtFirstName.Text = sqlReader.GetString("first_name")
                txtSurname.Text = sqlReader.GetString("surname")
                txtOtherName.Text = sqlReader.GetString("other_name")
                txtBirthDate.Text = sqlReader.GetString("birth_date")
                txtGender.Text = sqlReader.GetString("gender")
                txtJob.Text = sqlReader.GetString("job")
                txtPhoneNum.Text = sqlReader.GetString("phone_num")
                txtEmail.Text = sqlReader.GetString("email")
                txtReligion.Text = sqlReader.GetString("religion")
                txtDate.Text = sqlReader.GetString("added_on")
            End While
            txtBirthDate.Text = Replace(txtBirthDate.Text, " 00:00:00", "")
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

        'Find client age from date of birth
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT timestampdiff(YEAR, birth_date, curdate()) AS 'Age' FROM biodata WHERE client_id = " & frmClientCentre.client_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            'In order to avoid a "Data is Null" null value exception error, make sure all entries in the database are NOT NULL
            While sqlReader.Read
                txtAge.Text = sqlReader.GetString("Age")
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub

    'Save client cardiovascular exam data to database
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click

        sqlQuery = "UPDATE biodata SET first_name ='" & txtFirstName.Text & "', surname='" & txtSurname.Text & "', other_name='" & txtOtherName.Text & "', job='" & txtJob.Text &
            "', phone_num='" & txtPhoneNum.Text & "', email='" & txtEmail.Text & "', religion='" & txtReligion.Text &
            "' WHERE (first_name='" & txtFirstName.Text & "' OR surname='" & txtSurname.Text & "' OR other_name='" & txtOtherName.Text &
            "' OR job='" & txtJob.Text & "' OR phone_num='" & txtPhoneNum.Text & "' OR email='" & txtEmail.Text & "' OR religion='" & txtReligion.Text &
            "') AND (account_id =" & frmClientCentre.account_id & " AND client_id =" & frmClientCentre.client_id &
            ");"

        dialog = MessageBox.Show("Do want to save any changes you have made to client biodata?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Data Updated")
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If
    End Sub

    'Go to form to access clinical records
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmConsultView.Show()
    End Sub

    'Delete client info
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dialog = MessageBox.Show("Do wish to delete the current client record? Once deleted, the client record will no longer be accessible in the app.", "Delete client record",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        sqlQuery = "INSERT INTO biodata_archive SELECT * FROM biodata WHERE client_id = " & frmClientCentre.client_id &
                    "; DELETE FROM biodata WHERE client_id =" & frmClientCentre.client_id & ";"
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Client deleted")
                DB.sqlConnect.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
            'Return to Client Centre form
            frmMainUI.ViewInPanel(frmClientCentre)
        End If
    End Sub
    'Exit form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private Sub frmBioData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dialog = MessageBox.Show("Have you have you saved saved any changes before exiting?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            'Return to "Client Centre' form
            frmConsultView.Close()
            frmMainUI.ViewInPanel(frmClientCentre)
            Dispose()
        End If
    End Sub

End Class