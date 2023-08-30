Imports MySql.Data.MySqlClient
Imports System.Reflection.Emit
Imports System.Xml

'Start new consultation and view consultation history of client
Public Class frmConsultView
    Public client_id, consult_id, first_name, surname, other_name, card_num, birth_date, age, gender, phone_num, job, religion, email, added_on, BP, sugar As String
    Public PdIn, PdOut, Lmono, RMono, OdAid, OdPin, OdUnAid, OsAid, OsPin, OdPlus, OsPlus, OsUnAid As String
    Public odq, pcCC, HPC, POH, PMH, DH, Allerg, SH, FOH, FMH, Ddx As String
    Public OdLids, OsLids, OdConjuct, OsConjuct, OdCornea, OsCornea, OdAc, OsAc, OdIris, OsIris, OdPupil, OsPupil, OdLens, OsLens As String
    Public OdVitr, OdDisc, OdCd, OdRim, OdAv, OdPeripap, OdMacular, OdPeriRet, OsVitr, OsDisc, OsCd, OsRim, OsAv, OsPeripap, OsMacular, OsPeriRet As String
    Public Dx, Px, Comments As String
    Dim sqlComm As New MySqlCommand
    Dim sqlQuery As String
    Dim sqlReader As MySqlDataReader
    Dim sqlAdapt As New MySqlDataAdapter
    Dim dbData As New DataTable
    Dim dbSource As New BindingSource
    Dim dbRow As New DataGridViewRow

    'View consultation history
    Private Sub frmConsultView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.sqlConnect.Close()
        sqlQuery = "SELECT *
                    FROM consult co
                    LEFT JOIN cardio_vasc cv
	                    ON co.consult_id = cv.consult_id
                    LEFT JOIN va_exam va
                        ON co.consult_id =  va.consult_id
                    LEFT JOIN patient_hist ph
	                    ON co.consult_id = ph.consult_id
                    LEFT JOIN ext_exam ee
	                    ON co.consult_id = ee.consult_id
                    LEFT JOIN int_exam ie
	                    ON co.consult_id = ie.consult_id
                    LEFT JOIN dx_mngmnt dx
	                    ON co.consult_id = dx.consult_id
                    LEFT JOIN biodata bd
	                    ON cv.client_id = bd.client_id
                    WHERE cv.client_id = " & frmClientCentre.client_id & "
                    ORDER BY co.added_on DESC;"
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

        'Client age
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT timestampdiff(YEAR, birth_date, curdate()) AS 'Age' FROM biodata WHERE client_id = " & frmClientCentre.client_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            While sqlReader.Read
                age = sqlReader.GetString("Age")
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

        'Client details summary
        Try
            DB.sqlConnect.Open()
            sqlQuery = "SELECT card_num, first_name, surname, other_name FROM biodata WHERE client_id = " & frmClientCentre.client_id & ";"
            sqlComm.CommandText = sqlQuery
            sqlComm = New MySqlCommand(sqlQuery, DB.sqlConnect)
            sqlReader = sqlComm.ExecuteReader
            While sqlReader.Read
                Dim cardNum = sqlReader.GetString("card_num")
                Dim firstName = sqlReader.GetString("first_name")
                Dim otherName = sqlReader.GetString("other_name")
                Dim surName = sqlReader.GetString("surname")
                Label1.Text = "Consultation history of:" & vbCrLf & firstName & " " & otherName & " " & surName & ", " & cardNum
            End While
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DB.sqlConnect.Dispose()
        End Try

        'Prevent viewing of clinical form where there is no consultation history 
        If Not first_name = "" Then
            btnView.Enabled = True
        Else
            btnView.Enabled = False
        End If
    End Sub

    'Start a new consultation
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmClinicalPass.Show()
    End Sub

    'Select consultation from consultation history
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellEnter
        If e.RowIndex >= 0 Then
            dbRow = Me.DataGridView1.Rows(e.RowIndex)
            client_id = dbRow.Cells("client_id").Value.ToString
            card_num = dbRow.Cells("card_num").Value.ToString
            first_name = dbRow.Cells("first_name").Value.ToString
            surname = dbRow.Cells("surname").Value.ToString
            other_name = dbRow.Cells("other_name").Value.ToString
            gender = dbRow.Cells("gender").Value.ToString
            job = dbRow.Cells("job").Value.ToString
            phone_num = dbRow.Cells("phone_num").Value.ToString
            religion = dbRow.Cells("religion").Value.ToString
            email = dbRow.Cells("email").Value.ToString
            birth_date = dbRow.Cells("birth_date").Value.ToString
            added_on = dbRow.Cells("added_on").Value.ToString
            consult_id = dbRow.Cells("consult_id").Value.ToString

            BP = dbRow.Cells("bp").Value.ToString
            sugar = dbRow.Cells("sugar").Value.ToString

            PdOut = dbRow.Cells("outer_pd").Value.ToString
            PdIn = dbRow.Cells("inner_pd").Value.ToString
            RMono = dbRow.Cells("od_mono_pd").Value.ToString
            Lmono = dbRow.Cells("os_mono_pd").Value.ToString
            OdUnAid = dbRow.Cells("od_unaided").Value.ToString
            OsUnAid = dbRow.Cells("os_unaided").Value.ToString
            OdAid = dbRow.Cells("od_aided").Value.ToString
            OsAid = dbRow.Cells("os_aided").Value.ToString
            OdPlus = dbRow.Cells("od_plus_one").Value.ToString
            OsPlus = dbRow.Cells("os_plus_one").Value.ToString
            OdPin = dbRow.Cells("od_pinhole").Value.ToString
            OsPin = dbRow.Cells("os_pinhole").Value.ToString

            pcCC = dbRow.Cells("pc_cc").Value.ToString
            HPC = dbRow.Cells("hpc").Value.ToString
            odq = dbRow.Cells("odq").Value.ToString
            POH = dbRow.Cells("poh").Value.ToString
            PMH = dbRow.Cells("pmh_psh").Value.ToString
            DH = dbRow.Cells("dh").Value.ToString
            Allerg = dbRow.Cells("allergy").Value.ToString
            SH = dbRow.Cells("sh").Value.ToString
            FOH = dbRow.Cells("foh").Value.ToString
            FMH = dbRow.Cells("fmh").Value.ToString
            Ddx = dbRow.Cells("ddx").Value.ToString

            OdLids = dbRow.Cells("od_lids").Value.ToString
            OdConjuct = dbRow.Cells("od_conjuct").Value.ToString
            OdCornea = dbRow.Cells("od_cornea").Value.ToString
            OdIris = dbRow.Cells("od_iris").Value.ToString
            OdPupil = dbRow.Cells("od_pupil").Value.ToString
            OdAc = dbRow.Cells("od_ac").Value.ToString
            OdLens = dbRow.Cells("od_lens").Value.ToString

            OsLids = dbRow.Cells("os_lids").Value.ToString
            OsConjuct = dbRow.Cells("os_conjuct").Value.ToString
            OsCornea = dbRow.Cells("os_cornea").Value.ToString
            OsPupil = dbRow.Cells("os_pupil").Value.ToString
            OsIris = dbRow.Cells("os_iris").Value.ToString
            OsAc = dbRow.Cells("os_ac").Value.ToString
            OsLens = dbRow.Cells("os_lens").Value.ToString

            OdVitr = dbRow.Cells("od_vitr").Value.ToString
            OdDisc = dbRow.Cells("od_disc").Value.ToString
            OdCd = dbRow.Cells("od_cd").Value.ToString
            OdRim = dbRow.Cells("os_rim").Value.ToString
            OdAv = dbRow.Cells("od_av").Value.ToString
            OdPeripap = dbRow.Cells("od_peripap").Value.ToString
            OdMacular = dbRow.Cells("od_macular").Value.ToString
            OdPeriRet = dbRow.Cells("od_peri_ret").Value.ToString

            OsVitr = dbRow.Cells("os_vitr").Value.ToString
            OsDisc = dbRow.Cells("os_disc").Value.ToString
            OsCd = dbRow.Cells("os_cd").Value.ToString
            OsRim = dbRow.Cells("os_rim").Value.ToString
            OsAv = dbRow.Cells("os_av").Value.ToString
            OsPeripap = dbRow.Cells("os_peripap").Value.ToString
            OsMacular = dbRow.Cells("os_macular").Value.ToString
            OsPeriRet = dbRow.Cells("os_peri_ret").Value.ToString

            Dx = dbRow.Cells("dx").Value.ToString
            Px = dbRow.Cells("px_mngmnt").Value.ToString
            Comments = dbRow.Cells("comments").Value.ToString
        End If
    End Sub

    'View consultation form from consultation history
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmMainComp.ViewInPanel(CompForm1)
        frmMainComp.Show()
    End Sub

End Class