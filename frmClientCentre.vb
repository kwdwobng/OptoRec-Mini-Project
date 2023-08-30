Imports System.Globalization
Imports MySql.Data.MySqlClient

'Access to all client records
Public Class frmClientCentre
    Public account_id, client_id, info, first_name, other_name, surname, card_num As String
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim dbData As New DataTable
    Dim dbSource As New BindingSource
    Dim dbRow As New DataGridViewRow
    Dim sqlQuery As String

    'Display client biodata from database in DataGridView
    Private Sub frmClientCentre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmBioData.Dispose()
        DB.sqlConnect.Close()
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT card_num AS 'Card Number', first_name AS 'First Name', surname AS 'Surname', other_name AS 'Other Name(s)', birth_date AS 'Date of Birth', 
            gender AS 'Gender', job AS 'Occupation', phone_num AS 'Phone Number', account_id, client_id, CONCAT_WS(' ', card_num, first_name, other_name, surname) AS 'Name' FROM biodata 
            WHERE account_id =" & frmAccPass.account_id & " ORDER BY client_id DESC;"
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

    'Select client
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView1.CellEnter
        Dim birth_date, gender, phone_num, job As String
        If e.RowIndex >= 0 Then
            dbRow = Me.DataGridView1.Rows(e.RowIndex)
            account_id = dbRow.Cells("account_id").Value.ToString
            client_id = dbRow.Cells("client_id").Value.ToString
            card_num = dbRow.Cells("Card Number").Value.ToString
            first_name = dbRow.Cells("First Name").Value.ToString
            other_name = dbRow.Cells("Other Name(s)").Value.ToString
            surname = dbRow.Cells("Surname").Value.ToString
            birth_date = dbRow.Cells("Date of Birth").Value.ToString
            gender = dbRow.Cells("Gender").Value.ToString
            job = dbRow.Cells("Occupation").Value.ToString
            phone_num = dbRow.Cells("Phone Number").Value.ToString

            'Display client info
            birth_date = Replace(birth_date, " 00:00:00", "")
            txtInfo.Text = card_num & vbCrLf & first_name & " " & other_name & vbCrLf & surname & vbCrLf & gender & vbCrLf & birth_date & vbCrLf & job & vbCrLf & phone_num
            info = txtInfo.Text
        End If
    End Sub

    'Search client
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dbDataView As New DataView(dbData)
        dbDataView.RowFilter = String.Format("Name LIKE '%{0}%'", txtSearch.Text) '%{0}% finds all phrases with search term with in it
        DataGridView1.DataSource = dbDataView
    End Sub

    'Go to messenger
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        frmMessage.Show()
    End Sub

    'View client clinical records
    Private Sub btnClient_Click(sender As Object, e As EventArgs) Handles btnClient.Click
        If txtInfo.Text = "" Then
            MessageBox.Show("Please select a client record from the table OR" & vbCrLf & "click the 'New' button to create a new client record to select.")
        Else
            frmMainUI.ViewInPanel(frmBioData)
            Hide()
        End If
    End Sub

    'Create new client records
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmNewClient.Dispose()
        frmMainUI.ViewInPanel(frmNewClient)
        Hide()
    End Sub

    'View data export form
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        frmMainUI.ViewInPanel(frmExport)
        Hide()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub
    Private Sub frmClientCentre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you wish to logout of your user account?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            'Return to start
            frmStart.Show()
            frmAccPass.Dispose()
            Dispose()
            frmMainUI.Hide()
        End If
    End Sub

    'Refresh datagridview
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        btnClient.Select()
        DB.sqlConnect.Close()
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT card_num AS 'Card Number', first_name AS 'First Name', surname AS 'Surname', other_name AS 'Other Name(s)', birth_date AS 'Date of Birth', 
            gender AS 'Gender', job AS 'Occupation', phone_num AS 'Phone Number', account_id, client_id, CONCAT_WS(' ', card_num, first_name, other_name, surname) AS 'Name' FROM biodata 
            WHERE account_id =" & frmAccPass.account_id & " ORDER BY client_id DESC;"
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
        txtInfo.Clear()
    End Sub
End Class