Imports System.IO
Imports System.Reflection.Metadata.Ecma335
Imports MySql.Data.MySqlClient

'Export all client data as CSV
Public Class frmExport
    Dim sqlConn As New MySqlConnection
    Dim sqlComm As New MySqlCommand
    Dim sqlRead As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim dbData, dbData2 As New DataTable
    Dim dbSource, dbSource2 As New BindingSource
    Dim dbRow As New DataGridViewRow
    Dim sqlQuery As String

    'Display all client data in DataGridViews
    'All data is anonymous
    Private Sub frmDataExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.sqlConnect.Close()
        'Display client clinical data
        sqlQuery = "SELECT
	                    bd.client_id, card_num, co.consult_id, co.added_on,
                        job, birth_date, gender, bd.added_on,
                        bp, sugar,
                        outer_pd, inner_pd,
                        od_mono_pd, od_unaided, od_aided, od_plus_one, od_pinhole,
                        os_mono_pd, os_unaided, os_aided, os_plus_one, os_pinhole,
	                    pc_cc, hpc,	odq, poh, pmh_psh, dh, allergy, sh, foh, fmh, ddx,
                        od_lids, od_conjuct, od_cornea, od_ac, od_iris, od_pupil, od_lens,
	                    os_lids, os_conjuct, os_cornea, os_ac, os_iris, os_pupil, os_lens,
                        od_vitr, od_disc, od_cd, od_rim, od_av, od_peripap, od_macular, od_peri_ret,
	                    os_vitr, os_disc, os_cd, os_rim, os_av, os_peripap, os_macular, os_peri_ret,
                        dx, px_mngmnt, comments
                    FROM
	                    consult co
	                        LEFT JOIN cardio_vasc cv
		                        ON co.consult_id = cv.consult_id
	                        LEFT JOIN va_exam va
		                        ON co.consult_id = va.consult_id
	                        LEFT JOIN patient_hist ph
		                        ON co.consult_id = ph.consult_id
	                        LEFT JOIN ext_exam ee
		                        ON co.consult_id = ee.consult_id
	                        LEFT JOIN int_exam ie
		                        ON co.consult_id = ie.consult_id
	                        LEFT JOIN dx_mngmnt dm
		                        ON co.consult_id = dm.consult_id
                            LEFT JOIN biodata bd
                                ON bd.client_id = cv.client_id
                    WHERE
	                    bd.account_id = " & frmAccPass.account_id & " 
                    ORDER BY
                        co.added_on DESC;"


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

    'Create all consults csv file
    Private Sub btnExportCon_Click(sender As Object, e As EventArgs) Handles btnExportCon.Click
        Dim sfd As New SaveFileDialog
        sfd.FileName = "OptoRec Clinical Data"
        sfd.Filter = "CSV File | *.csv"

        If sfd.ShowDialog = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgvColNames As List(Of String) = DataGridView1.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.Name).ToList()
                sw.WriteLine(String.Join(",", dgvColNames))

                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim rowData As New List(Of String)
                    For Each column As DataGridViewColumn In DataGridView1.Columns
                        rowData.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next

                sw.Close()

                Dim psi As New ProcessStartInfo

                'Open csv file
                With psi
                    .FileName = sfd.FileName
                    .UseShellExecute = True
                End With

                System.Diagnostics.Process.Start(psi)
            End Using
        End If

    End Sub

End Class
