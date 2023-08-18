Imports System.ComponentModel.DataAnnotations
Imports MySql.Data.MySqlClient

'Access user accounts
Public Class frmUAC
    Public account_id, username, clinic_name, location1, clinician, owner1, phone_num, email, password1, password2 As String
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader

    'Display all user accounts
    Private Sub frmUAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Select()
        DB.sqlConnect.Close()
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM acc_info ai, passwords pw WHERE ai.account_id = pw.account_id"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader

            'Add account name to listbox
            While sqlReader.Read
                Dim username = sqlReader.GetString("username")
                ListBox1.Items.Add(username)
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
    End Sub

    'Select user account
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        DB.sqlConnect.Close()
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM acc_info ai, passwords pw WHERE ai.account_id = pw.account_id AND username = '" & ListBox1.Text & "';"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            'Selected account info
            While sqlReader.Read
                account_id = sqlReader.GetString("account_id")
                username = sqlReader.GetString("username")
                clinic_name = sqlReader.GetString("clinic_name")
                owner1 = sqlReader.GetString("owner")
                location1 = sqlReader.GetString("location")
                clinician = sqlReader.GetString("clinician")
                email = sqlReader.GetString("email")
                phone_num = sqlReader.GetString("phone_num")
                password1 = sqlReader.GetString("password1")
                password2 = sqlReader.GetString("password2")
                txtInfo.Text = clinic_name & vbCrLf & clinician & vbCrLf & location1
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
    End Sub

    'Login to user account
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtInfo.Text = "" Then
            MessageBox.Show("Please select an account")
        Else
            frmAccPass.Show()
        End If
    End Sub

    'Edit user account info
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtInfo.Text = "" Then
            MessageBox.Show("Please select an account")
        Else
            frmAccEditPass.Show()
        End If
    End Sub
    'Exit to welcome screen
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmStart.Show()
        frmMainUI.Hide()
    End Sub

End Class