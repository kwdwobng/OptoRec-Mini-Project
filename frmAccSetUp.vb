Imports MySql.Data.MySqlClient

'Setup user account
Public Class frmAccSetUp
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult

    'Save account info to database
    Private Sub btnSaveAcc_Click(sender As Object, e As EventArgs) Handles btnSaveAcc.Click
        Dim acc_info, passwords, items, message As String
        If Not txtPassword1.Text = "" Or Not txtPassword2.Text = "" Then
            acc_info = "INSERT INTO acc_info VALUES(DEFAULT,'" & txtClinic.Text & "', '" & txtOwner.Text & "', '" & txtLocation.Text & "', '" & txtClinician.Text & "', '" _
                       & txtPhoneNum.Text & "', '" & txtEmail.Text & "', DEFAULT);"
            passwords = "INSERT INTO passwords VALUES((SELECT MAX(account_id) FROM acc_info), '" & txtUserName.Text & "', '" & txtPassword1.Text & "', '" & txtPassword2.Text & "');"
            items = "INSERT INTO items VALUES ((SELECT MAX(account_id) FROM acc_info), DEFAULT, 'OptoRec Test Item for Accounting', 0, DEFAULT);"
            message = "INSERT INTO message VALUES((SELECT MAX(account_id) FROM acc_info), DEFAULT);"
            sqlQuery = acc_info & passwords & items + message
            dialog = MessageBox.Show("Please review the data you have entered." & vbCrLf & "If it is, correct click 'Yes' to save. If it is not, correct click 'No' and correct the data.",
                                     "Review Data", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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
                btnSaveAcc.Enabled = False
            End If


        Else
            MessageBox.Show("Please enter a General Password and a Clinical Password", "Missing Passwords", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    'Show general password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtPassword1.UseSystemPasswordChar = False
        Else
            txtPassword1.UseSystemPasswordChar = True
        End If
    End Sub

    'Show clinical password
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            txtPassword2.UseSystemPasswordChar = False
        Else
            txtPassword2.UseSystemPasswordChar = True
        End If
    End Sub

    'Exit form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Dispose()
            frmUAC.Dispose()
            frmMainUI.ViewInPanel(frmUAC)
            Hide()
        Else
            Show()
        End If
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If Not txtUserName.Text = "" Then
            btnSaveAcc.Enabled = True
        ElseIf txtUserName.Text = "" Then
            btnSaveAcc.Enabled = False
        End If
    End Sub
End Class