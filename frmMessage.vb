Imports MySql.Data.MySqlClient
Imports System.Xml

'Post short messages
Public Class frmMessage
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader

    'Select user account
    Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        sqlQuery = "SELECT message FROM message WHERE account_id = " & frmClientCentre.account_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            While sqlReader.Read
                TextBox1.Text = sqlReader.GetString("message")
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
    End Sub

    'Save message
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sqlQuery = "UPDATE message SET message = '" & TextBox1.Text & "' WHERE account_id = " & frmUAC.account_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try


        TextBox1.ReadOnly = True
    End Sub
    'Edit message to be saved
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        TextBox1.ReadOnly = False
    End Sub

    'View saved message
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TextBox1.ReadOnly = True
        sqlQuery = "SELECT message FROM message WHERE account_id = " & frmUAC.account_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            While sqlReader.Read
                TextBox1.Text = sqlReader.GetString("message")
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub
End Class