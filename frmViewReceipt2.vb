Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

'Transaction receipt
Public Class frmViewReceipt2
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Dim sqlQuery, item, cost, qty As String

    'Function to caculate cost of receipt
    Private Sub total()
        Dim amount As Decimal
        For x As Integer = 0 To ListView1.Items.Count - 1
            amount += Val(ListView1.Items(x).SubItems(3).Text)
            txtTotal.Text = "₵ " & FormatNumber(amount, 2)
        Next
    End Sub

    'View receipt
    Private Sub frmViewReceipt2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim first_name, surname, other_name, card_num, phone_num, clinic_name, location As String
        Dim item As ListViewItem
        ListView1.Items.Clear()
        sqlQuery = "SELECT item_name, quantity, cost, cost * quantity AS 'Total', receipt_id FROM items i, checkout c WHERE i.item_id = c.item_id AND receipt_id =" _
            & frmViewHistory.receipt_id & ";"
        Try
            DB.sqlConnect.Open()
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlRead = sqlComm.ExecuteReader
            While sqlRead.Read
                item = ListView1.Items.Add(sqlRead.Item("item_name").ToString)
                item.SubItems.Add(sqlRead.Item("quantity").ToString)
                item.SubItems.Add(sqlRead.Item("cost").ToString)
                item.SubItems.Add(sqlRead.Item("Total").ToString)
                item.SubItems.Add(sqlRead.Item("receipt_id").ToString)
            End While
            DB.sqlConnect.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

        'Display account and client info
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT first_name, other_name, surname, card_num, clinic_name, location, a.phone_num AS 'Clinic Number'
                        FROM biodata b
                        JOIN checkout c
	                        ON  b.client_id = c.client_id
                        JOIN acc_info a
	                        ON b.account_id = a.account_id
                        WHERE receipt_id =" & frmViewHistory.receipt_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlRead = sqlComm.ExecuteReader


            While sqlRead.Read
                first_name = sqlRead.GetString("first_name")
                other_name = sqlRead.GetString("other_name")
                surname = sqlRead.GetString("surname")
                card_num = sqlRead.GetString("card_num")
                clinic_name = sqlRead.GetString("clinic_name")
                location = sqlRead.GetString("location")
                phone_num = sqlRead.GetString("Clinic Number")
                txtInfo.Text = card_num & ", " & first_name & " " & other_name & " " & surname
                lblClinicInfo.Text = clinic_name & vbCrLf & location & vbCrLf & phone_num
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try
        total()
    End Sub

    'Create pdf for print
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'FormBorderStyle = FormBorderStyle.None
        g = CreateGraphics()
        bmp = New Bitmap(750, Size.Height - 20, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Me.Size)
        PrintPreviewDialog1.ShowDialog()
    End Sub
    'Print document
    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImageUnscaled(bmp, 0, 0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class