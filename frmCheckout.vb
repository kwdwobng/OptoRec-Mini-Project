Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports Google.Protobuf
Imports MySql.Data.MySqlClient

'Record receipts of transactions
Public Class frmCheckOut
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim dbData As New DataTable
    Dim dbSource As New BindingSource
    Dim dbRow As New DataGridViewRow
    Dim sqlQuery, item, item_id, cost, qty As String

    'Sum total cost of receipt items
    Private Sub total()
        Dim amount As Decimal
        For x As Integer = 0 To ListView1.Items.Count - 1
            amount += Val(ListView1.Items(x).SubItems(3).Text)
            txtTotal.Text = "₵ " & FormatNumber(amount, 2)
        Next
    End Sub

    'Display products and services
    Private Sub frmCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = frmClientCentre.first_name & " " & frmClientCentre.other_name & " " & frmClientCentre.surname & ", " & frmClientCentre.card_num

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
    End Sub

    'Select product or service
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter
        If e.RowIndex >= 0 Then
            dbRow = DataGridView1.Rows(e.RowIndex)
            item = dbRow.Cells("Name").Value.ToString
            cost = dbRow.Cells("Cost").Value.ToString
            item_id = dbRow.Cells("item_id").Value.ToString
        End If
    End Sub

    'Search items in DataGridView
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dbDataView As New DataView(dbData)
        dbDataView.RowFilter = String.Format("Name LIKE '%{0}%'", txtSearch.Text)
        DataGridView1.DataSource = dbDataView
    End Sub

    'Adds items to receipt
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        'Prevent same item being added to receipt

        If Not ListView1.FindItemWithText(item) Is Nothing Then
            For x As Integer = 0 To ListView1.Items.Count - 1
                If ListView1.Items(x).SubItems(4).Text = item_id Then '"item_id" as primary key used to identify item
                    MessageBox.Show("Item already added to the receipt")
                End If
            Next
            'Add item to receipt
        Else
            Dim i As Integer = 1
            Dim items As New ListViewItem
            items = ListView1.Items.Add(item)
            items.SubItems.Add(i)
            items.SubItems.Add(cost)
            items.SubItems.Add(FormatNumber(i * cost, 2))
            items.SubItems.Add(item_id)
            total()
        End If

    End Sub

    'Increase quantity of item on recept
    Private Sub btnPlus1_Click(sender As Object, e As EventArgs) Handles btnPlus1.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim i As Integer = 1
            Dim a As Integer = ListView1.SelectedIndices(0)
            ListView1.Items(a).SubItems(1).Text += i
            Dim amount As Decimal = (Val(ListView1.Items(a).SubItems(2).Text) * Val(ListView1.Items(a).SubItems(1).Text))
            ListView1.Items(a).SubItems(3).Text = FormatNumber(amount, 2)
            total()
        Else
            MessageBox.Show("Please select an item on the receipt")
        End If
    End Sub

    'Decrease quantity of item on receipt
    Private Sub btnMinus1_Click(sender As Object, e As EventArgs) Handles btnMinus1.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim i As Integer = 1
            Dim a As Integer = ListView1.SelectedIndices(0)
            If ListView1.Items(a).SubItems(1).Text >= 2 Then
                ListView1.Items(a).SubItems(1).Text -= i
                Dim amount As Decimal = (Val(ListView1.Items(a).SubItems(2).Text) * Val(ListView1.Items(a).SubItems(1).Text))
                ListView1.Items(a).SubItems(3).Text = FormatNumber(amount, 2)
                'Remove item from receipt
            ElseIf ListView1.Items(a).SubItems(1).Text = 1 Then
                ListView1.Items.RemoveAt(a)
                txtTotal.Clear()
            End If
            total()
        Else
            MessageBox.Show("Please select an item on the receipt")
        End If
    End Sub

    'Enable or disable save button
    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text = "" Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

    'Clears all items on receipt
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListView1.Items.Clear()
        txtTotal.Clear()
    End Sub

    'Save receipt
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dialog As DialogResult
        If Not txtName.Text = "" Then
            'Save record of receipt to database
            sqlQuery = "INSERT INTO receipts VALUES(DEFAULT, DEFAULT);"
            Try
                DB.sqlConnect.Open()
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlRead = sqlComm.ExecuteReader
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try

            'Save items on receipt to database
            dialog = MessageBox.Show("Do you wish to save the receipt and checkout?", "Save Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If dialog = DialogResult.Yes Then
                For x As Integer = 0 To ListView1.Items.Count - 1
                    Try
                        DB.sqlConnect.Open()
                        sqlComm = New MySqlCommand("INSERT INTO checkout VALUES((SELECT MAX(receipt_id) FROM receipts), @id, @client, @qty, DEFAULT)", DB.sqlConnect)
                        sqlComm.Parameters.AddWithValue("@id", ListView1.Items(x).SubItems(4).Text)
                        sqlComm.Parameters.AddWithValue("@client", frmClientCentre.client_id)
                        sqlComm.Parameters.AddWithValue("@qty", ListView1.Items(x).SubItems(1).Text)
                        sqlComm.ExecuteNonQuery()
                        DB.sqlConnect.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        DB.sqlConnect.Dispose()
                    End Try
                Next
                MessageBox.Show("Receipt saved")
            End If

        Else
            MessageBox.Show("Please select a client from the Client Centre in order to save the receipt.", "Select client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    'View history of client's receipts
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        frmViewHistory.Show()
    End Sub


End Class
