Imports MySql.Data.MySqlClient

'Access and modify all clinical data 
Public Class frmClinicalPass
    Public username, password As String
    Dim sqlComm As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlQuery As String
    Private Sub frmClinicalPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPassword.Select()
    End Sub

    'Login to account
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim count As Integer
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT * FROM passwords WHERE password2 = '" & txtPassword.Text & "' AND account_id=" & frmUAC.account_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader

            While sqlReader.Read 'The DataReader executes the search once every entry. THerefore if the entry is not correct then the reader function is repeated
                count += 1
            End While

            If count = 1 Then
                password = txtPassword.Text
                txtPassword.Clear()
                frmConsultView.Show()
                'frmBioData.Hide()
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