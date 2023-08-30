'View complete clinical form
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1
Imports Org.BouncyCastle.Crypto.Agreement
Public Class frmMainComp
    Dim formName As String = "EYE HEALTH EXAMINATION FORM"
    'Function to display form in panel
    Public Sub ViewInPanel(ByRef ViewForm As Form)
        Panel1.Controls.Clear()
        ViewForm.TopLevel = False
        Panel1.Controls.Add(ViewForm)
        ViewForm.Show()
    End Sub

    'Go to next page
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ViewInPanel(CompForm2)
        CompForm1.Hide()
        Label1.Text = "Page 2 of 2"
        btnPrev.Enabled = True
        btnNext.Enabled = False
    End Sub

    'Go to previous page
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ViewInPanel(CompForm1)
        CompForm2.Hide()
        Label1.Text = "Page 1 of 2"
        btnPrev.Enabled = False
        btnNext.Enabled = True
    End Sub

    Private Sub frmMainComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load clinic name in title label
        Dim sqlRead As MySqlDataReader
        Dim sqlQuery As String = "SELECT clinic_name FROM acc_info WHERE account_id =" & frmAccPass.account_id & ";"
        Try
            DB.sqlConnect.Open()
            Dim sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlRead = sqlComm.ExecuteReader
            While sqlRead.Read
                Dim clinic = sqlRead.GetString("clinic_name")
                lblTitle.Text = clinic.ToUpper & vbCrLf & formName
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

    End Sub

End Class