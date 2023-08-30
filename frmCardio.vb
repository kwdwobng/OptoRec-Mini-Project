Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml

'Add cardiovascular exam findings
Public Class frmCardio
    Public BP, sugar, BioTag As String

    'Show client's biodata
    Private Sub frmCardio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlQuery, card_num, surname, first_name, other_name, age As String
        Dim sqlComm As New MySqlCommand
        Dim sqlReader As MySqlDataReader

        txtBioTag.Select()

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
                BioTag = card_num & ", " & first_name & " " & other_name & " " & surname & ", " & age & " years old"
            End While

            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
        txtBioTag.Text = BioTag
    End Sub

    'GO to VA form
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        frmMainUI.ViewInPanel(frmVA)
        Hide()
    End Sub

    Private Sub txtSugar_TextChanged(sender As Object, e As EventArgs) Handles txtSugar.TextChanged
        sugar = txtSugar.Text
    End Sub

    Private Sub txtBP_TextChanged(sender As Object, e As EventArgs) Handles txtBP.TextChanged
        BP = txtBP.Text
    End Sub
End Class