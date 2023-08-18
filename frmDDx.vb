Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports MySql.Data.MySqlClient

'Add diagnoses, management and clinical comments
Public Class frmDDx
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Public sqlQuery As String
    Dim sqlReader As MySqlDataReader
    Dim dialog As DialogResult
    Dim card_num, surname, first_name, other_name, age As String

    'Show client's biodata
    Private Sub frmDDx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDx.Select()


        sqlQuery = "SELECT card_num, first_name, other_name, surname, timestampdiff(YEAR, birth_date, curdate()) AS 'Age' FROM biodata WHERE client_id =" & frmClientCentre.client_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            While sqlReader.Read
                card_num = sqlReader.GetString("card_num")
                first_name = sqlReader.GetString("first_name")
                other_name = sqlReader.GetString("other_name")
                surname = sqlReader.GetString("surname")
                age = sqlReader.GetString("Age")
            End While

            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
        txtBioTag.Text = card_num & ", " & first_name & " " & other_name & " " & surname & ", " & age & " years old"
    End Sub
    'Go to exam form
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Asterisk)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmExam)
            Hide()
        End If
    End Sub

    'Save diagnoses etc
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        sqlQuery = "UPDATE dx_mngmnt SET dx ='" & txtDx.Text & "', px_mngmnt ='" & txtPx.Text & "', comments ='" & txtComments.Text &
            "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        dialog = MessageBox.Show("Do want to update the current data entries in your record?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery & frmCardio.sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Data saved.")
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If
    End Sub

End Class