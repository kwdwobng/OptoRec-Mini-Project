Imports MySql.Data.MySqlClient

'Access account details for editing and deletion
Public Class frmAccEditPass
    Public username, password As String
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlQuery As String

    Private Sub frmAccEditPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblusername.Select()
    End Sub

    'Login to account
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim count As Integer
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM passwords WHERE username = '" & txtUsername.Text & "' AND password1 = '" & txtPassword.Text & "';"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader

            While sqlReader.Read
                count += 1
            End While

            If count = 1 Then
                'Save password
                username = txtUsername.Text
                password = txtPassword.Text
                txtUsername.Clear()
                txtPassword.Clear()

                'Show client centre
                frmAccEdit.Dispose()
                frmMainUI.ViewInPanel(frmAccEdit)
                frmUAC.Hide()
                Hide()
            Else
                MessageBox.Show("Username or password is incorrect.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
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