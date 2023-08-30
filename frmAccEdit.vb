Imports Google.Protobuf.Reflection.SourceCodeInfo.Types
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

'Modify and delete account details
Public Class frmAccEdit
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult

    Private Sub frmAccEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user account info
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM acc_info ai, passwords pw WHERE ai.account_id = " & frmAccPass.account_id & " AND pw.account_id = " & frmAccPass.account_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            'Selected account info
            While sqlReader.Read
                'account_id = sqlReader.GetString("account_id")
                txtUserName.Text = sqlReader.GetString("username")
                txtClinic.Text = sqlReader.GetString("clinic_name")
                txtOwner.Text = sqlReader.GetString("owner")
                txtLocation.Text = sqlReader.GetString("location")
                txtClinician.Text = sqlReader.GetString("clinician")
                txtEmail.Text = sqlReader.GetString("email")
                txtPhoneNum.Text = sqlReader.GetString("phone_num")
                txtPassword1.Text = sqlReader.GetString("password1")
                txtPassword2.Text = sqlReader.GetString("password2")
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub
    'Update account info in database
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        'sqlConn.ConnectionString = "server=localhost; userid=root; password=; database=opt_app"
        sqlQuery = "UPDATE acc_info SET clinic_name ='" & txtClinic.Text & "', owner= '" & txtOwner.Text & "', location='" & txtLocation.Text & "', clinician='" & txtClinician.Text &
            "', phone_num='" & txtPhoneNum.Text & "', email='" & txtEmail.Text & "' WHERE account_id=" & frmAccPass.account_id & "; UPDATE passwords SET username='" & txtUserName.Text &
            "', password1='" & txtPassword1.Text & "', password2='" & txtPassword2.Text & "' WHERE account_id=" & frmAccPass.account_id & ";"
        dialog = MessageBox.Show("Do you wish to save the current data you have updated?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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
        dialog = MessageBox.Show("Have you updated your data and saved any changes you made?", "Exit to Client Centre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmClientCentre)
            Dispose()
            Hide()
        Else
            Show()
        End If
    End Sub

    'Delete account
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dialog = MessageBox.Show("Do wish to delete the current account? Once deleted, the account will no longer be accessible in the app.", "Delete account",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        sqlQuery = "INSERT INTO acc_info_archive SELECT * FROM acc_info WHERE account_id = " & frmAccPass.account_id &
                    "; DELETE FROM acc_info WHERE account_id =" & frmAccPass.account_id &
                    "; INSERT INTO passwords_archive SELECT * FROM passwords WHERE account_id = " & frmAccPass.account_id &
                    "; DELETE FROM passwords WHERE account_id =" & frmAccPass.account_id & ";"
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

            'Exit to start
            frmStart.Show()
            frmMainUI.Hide()
            Dispose()
        End If
    End Sub

End Class