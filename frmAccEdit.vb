Imports MySql.Data.MySqlClient

'Modify and delete account details
Public Class frmAccEdit
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery, sqlInsert1, sqlInsert2, sqlUpdate1, sqlUpdate2, gender As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult

    Private Sub frmAccEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = frmUAC.username
        txtClinic.Text = frmUAC.clinic_name
        txtClinician.Text = frmUAC.clinician
        txtOwner.Text = frmUAC.owner1
        txtLocation.Text = frmUAC.location1
        txtEmail.Text = frmUAC.email
        txtPhoneNum.Text = frmUAC.phone_num
        txtPassword1.Text = frmUAC.password1
        txtPassword2.Text = frmUAC.password2
    End Sub
    'Update account info in database
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        'sqlConn.ConnectionString = "server=localhost; userid=root; password=; database=opt_app"
        sqlQuery = "UPDATE acc_info SET clinic_name ='" & txtClinic.Text & "', owner= '" & txtOwner.Text & "', location='" & txtLocation.Text & "', clinician='" & txtClinician.Text &
            "', phone_num='" & txtPhoneNum.Text & "', email='" & txtEmail.Text & "' WHERE account_id=" & frmUAC.account_id & "; UPDATE passwords SET username='" & txtUserName.Text &
            "', password1='" & txtPassword1.Text & "', password2='" & txtPassword2.Text & "' WHERE account_id=" & frmUAC.account_id & ";"
        dialog = MessageBox.Show("Do wish to save the current data you have updated?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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

    'Exit form to User Account Centre
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you updated your data?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Dispose()
            frmUAC.Close()
            frmUAC.Dispose()
            frmMainUI.ViewInPanel(frmUAC)
            Hide()
        Else
            Show()
        End If
    End Sub

    'Delete account
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dialog = MessageBox.Show("Do wish to delete the current account? Once deleted, the account will no longer be accessible in the app.", "Delete account",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        sqlQuery = "INSERT INTO acc_info_archive SELECT * FROM acc_info WHERE account_id = " & frmUAC.account_id &
                    "; DELETE FROM acc_info WHERE account_id =" & frmUAC.account_id &
                    "; INSERT INTO passwords_archive SELECT * FROM passwords WHERE account_id = " & frmUAC.account_id &
                    "; DELETE FROM passwords WHERE account_id =" & frmUAC.account_id & ";"
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Account deleted")
                DB.sqlConnect.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
            'Exit form to User Account Centre
            Dispose()
            frmUAC.Dispose()
            frmMainUI.ViewInPanel(frmUAC)
            Hide()
        End If
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If Not txtUserName.Text = "" Then
            btnUpdateAcc.Enabled = True
        ElseIf txtUserName.Text = "" Then
            btnUpdateAcc.Enabled = False
        End If
    End Sub
End Class