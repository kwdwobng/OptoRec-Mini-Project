Imports MySql.Data.MySqlClient
Imports System.Xml

'Add to visual acuity exam findings
Public Class frmVA
    Dim sqlComm As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlQuery As String
    Dim dialog As DialogResult
    Dim card_num, surname, first_name, other_name, age As String

    'Show client's biodata
    Private Sub frmVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPdOut.Select()

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

    'Save info to database
    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        If txtPdOut.Text = "" Then
            txtPdOut.Text = "NULL"
        End If

        If txtPdIn.Text = "" Then
            txtPdIn.Text = "NULL"
        End If

        If txtLmono.Text = "" Then
            txtLmono.Text = "NULL"
        End If

        If txtRmono.Text = "" Then
            txtRmono.Text = "NULL"
        End If
        sqlQuery = "UPDATE va_exam SET outer_pd =" & txtPdOut.Text & ", inner_pd =" & txtPdIn.Text & ", od_mono_pd =" & txtRmono.Text & ", os_mono_pd =" _
            & txtLmono.Text & ", od_unaided ='" & txtOdUnAid.Text & "', os_unaided ='" & txtOsUnAid.Text & "', od_aided ='" & txtOdAid.Text & "', os_aided ='" _
            & txtOsAid.Text & "', od_unaided ='" & txtOdUnAid.Text & "', os_unaided ='" & txtOsUnAid.Text & "', od_plus_one ='" & txtOdPlus.Text & "', os_plus_one ='" _
            & txtOsPlus.Text & "', od_pinhole ='" & txtOdPin.Text & "', os_pinhole='" & txtOsPin.Text & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"

        dialog = MessageBox.Show("Do want to update the current data entries in your record?", "Update Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        DB.sqlConnect.Close()
        If dialog = DialogResult.Yes Then
            Try
                DB.sqlConnect.Open()
                sqlComm.CommandText = sqlQuery
                sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
                sqlReader = sqlComm.ExecuteReader
                MessageBox.Show("Data saved.")
                DB.sqlConnect.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                DB.sqlConnect.Dispose()
            End Try
        End If

        If txtPdOut.Text = "NULL" Then
            txtPdOut.Clear()
        End If

        If txtPdIn.Text = "NULL" Then
            txtPdIn.Clear()
        End If

        If txtLmono.Text = "NULL" Then
            txtLmono.Clear()
        End If

        If txtRmono.Text = "NULL" Then
            txtRmono.Clear()
        End If
    End Sub


    'Go to history
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmHistory)
            Hide()
        End If
    End Sub

    'Go to cardio
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the '" & frmMainUI.lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmMainUI.ViewInPanel(frmCardio)
            Hide()
        End If
    End Sub
End Class