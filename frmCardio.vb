Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml

'Add cardiovascular exam findings
Public Class frmCardio
    Dim sqlComm As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Public sqlQuery As String
    Dim dialog As DialogResult
    Dim card_num, surname, first_name, other_name, age As String

    'Show client's biodata
    Private Sub frmCardio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmskBP.Select()

        sqlQuery = "SELECT card_num, first_name, other_name, surname, timestampdiff(YEAR, birth_date, curdate()) AS 'Age' FROM biodata WHERE client_id =" & frmClientCentre.client_id
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

    'GO to VA form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmVA)
            Hide()
        End If
    End Sub

    'Save info to database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSugar.Text = "" Then
            txtSugar.Text = "NULL"
        End If
        sqlQuery = "UPDATE cardio_vasc SET bp ='" & txtmskBP.Text & "', sugar=" & txtSugar.Text & " WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"

        dialog = MessageBox.Show("Do want to update current data entries?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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

        If txtSugar.Text = "NULL" Then
            txtSugar.Clear()
        End If
    End Sub
End Class