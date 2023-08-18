Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MySql.Data.MySqlClient

'Access client receipt history
Public Class frmViewHistory
    Public receipt_id As String
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim dbData As New DataTable
    Dim dbSource As New BindingSource
    Dim dbRow As New DataGridViewRow
    Dim sqlQuery As String

    'Display receipt history
    Private Sub frmViewHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT added_on, receipt_id, client_id FROM checkout WHERE client_id = " & frmClientCentre.client_id & " GROUP BY receipt_id ORDER BY added_on DESC;"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlAdapt.SelectCommand = sqlComm
            sqlAdapt.Fill(dbData)
            dbSource.DataSource = dbData
            DataGridView1.DataSource = dbSource
            sqlAdapt.Update(dbData)
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub

    'Select receipt to view
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter
        If e.RowIndex >= 0 Then
            dbRow = Me.DataGridView1.Rows(e.RowIndex)
            receipt_id = dbRow.Cells("receipt_id").Value.ToString
        End If
    End Sub

    'Open new instance of CompForm1 for each selected item from DataGridView


    'Delete receipt and refresh database
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialog As DialogResult
        sqlQuery = "INSERT INTO checkout_archive SELECT * FROM checkout WHERE receipt_id = " & receipt_id &
            "; DELETE FROM checkout WHERE receipt_id =" & receipt_id & ";"
        dialog = MessageBox.Show("Do you wish to delete the last saved receipt? Once deleted, the receipt will no longer be accessible in the app.", "Delete Receipt",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.Yes Then
            'Delete item from database
            Try
                DB.sqlConnect.Open()
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlRead = sqlComm.ExecuteReader
                MessageBox.Show("Receipt deleted")
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try

            'Refresh database
            Try
                DB.sqlConnect.Open()
                sqlQuery = "SELECT added_on, receipt_id, client_id FROM checkout WHERE client_id = " & frmClientCentre.client_id & " GROUP BY receipt_id ORDER BY added_on DESC;"
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlAdapt.SelectCommand = sqlComm
                sqlAdapt.Fill(dbData)
                dbSource.DataSource = dbData
                DataGridView1.DataSource = dbSource
                sqlAdapt.Update(dbData)
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmViewReceipt2.Show()
    End Sub
End Class