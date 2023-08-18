Imports MySql.Data.MySqlClient

'List of all products and services
Public Class frmItems
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim dbData As New DataTable
    Dim dbSource As New BindingSource
    Dim dbRow As New DataGridViewRow
    Dim sqlQuery, item, item_id, cost As String

    'Loads items from items database into DataGridView
    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.sqlConnect.Close()
        sqlQuery = "SELECT item_name AS 'Name', cost AS 'Cost', account_id, item_id, added_on FROM items WHERE account_id = " & frmUAC.account_id & " ORDER BY item_id DESC;"
        Try
            DB.sqlConnect.Open()
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

        txtItem.Clear()
        txtCost.Clear()

        txtUsername.Text = frmAccPass.username
    End Sub

    'Inserts text in item and cost textbox into items database
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dialog As New DialogResult
        If txtItem.Text = "" Or txtCost.Text = "" Then
            MessageBox.Show("Please enter a product or service item and its cost.")
        Else
            dialog = MessageBox.Show("Do you want to add this product or service?", "Add Product or Serice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            sqlQuery = "INSERT INTO items VALUES(" & frmUAC.account_id & ", DEFAULT, '" & txtItem.Text & "', " & txtCost.Text & ", DEFAULT);"
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                If dialog = DialogResult.Yes Then
                    sqlRead = sqlComm.ExecuteReader
                    MessageBox.Show("Product or service successfully added")
                End If
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If

    End Sub

    'Updates text from item textbox and cost textbox in items database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtItem.Text = "" Or txtCost.Text = "" Then
            MessageBox.Show("Please enter a product or service item and its cost.")
        Else
            sqlQuery = "UPDATE items SET item_name ='" & txtItem.Text & "', cost =" & txtCost.Text & ", added_on = DEFAULT WHERE item_id= " & item_id & ";"
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlRead = sqlComm.ExecuteReader
                MessageBox.Show("Product or service successfully updated")
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If
    End Sub

    'Refreshes DataGridView to reflect upates or changes in the items database
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DB.sqlConnect.Close()
        sqlQuery = "SELECT item_name AS 'Name', cost AS 'Cost', account_id, item_id, added_on FROM items WHERE account_id = " & frmUAC.account_id & " ORDER BY item_id DESC;"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlAdapt.SelectCommand = sqlComm
            dbData = New DataTable
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

        txtItem.Clear()
        txtCost.Clear()
    End Sub

    'Select items
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter
        If e.RowIndex >= 0 Then
            dbRow = Me.DataGridView1.Rows(e.RowIndex)
            item = dbRow.Cells("Name").Value.ToString
            cost = dbRow.Cells("Cost").Value.ToString
            item_id = dbRow.Cells("item_id").Value.ToString
            txtItem.Text = item
            txtCost.Text = cost
        End If
    End Sub

    'Clears item and cost textboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItem.Clear()
        txtCost.Clear()
    End Sub

    'Displays results of search in DataGridView when a string is entered in search textbox
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dbDataView As New DataView(dbData)
        dbDataView.RowFilter = String.Format("item_name LIKE '{0}%'", txtSearch.Text)
        DataGridView1.DataSource = dbDataView
    End Sub

    'Delete item in item textbox from database 
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dialog As New DialogResult
        dialog = MessageBox.Show("Are you sure want to delete the item? Once deleted, the item will no longer be accessible in the app.", "Delete item",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        sqlQuery = "INSERT INTO items_archive SELECT * FROM items WHERE item_name = '" & item & "' AND account_id = " & frmUAC.account_id &
            "; DELETE FROM items WHERE item_name = '" & item & "' AND account_id = " & frmUAC.account_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            If dialog = DialogResult.Yes Then
                sqlRead = sqlComm.ExecuteReader
                MessageBox.Show("Product or service deleted")
            End If
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
    End Sub

End Class
