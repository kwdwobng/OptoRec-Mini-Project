Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Xml
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Engines
Imports Org.BouncyCastle.Ocsp

'OptoRec main interface
Public Class frmMainUI
    Dim sqlComm As New MySqlCommand
    Dim sqlReader As MySqlDataReader
    Dim sqlQuery As String
    Dim dialog As DialogResult

    'Function to display form in panel
    Public Sub ViewInPanel(ByRef ViewForm As Form)
        pnlMain.Controls.Clear()
        ViewForm.TopLevel = False
        pnlMain.Controls.Add(ViewForm)
        ViewForm.Show()
    End Sub

    'Function to hide buttons in pnlClinic
    Private Sub hideClinic()
        btnCardio.Hide()
        btnVA.Hide()
        btnHistory.Hide()
        btnExam.Hide()
        btnDDx.Hide()
        btnSave.Hide()
        btnExitClinic.Hide()
        btnMessage.Hide()
    End Sub

    'Function to show buttons in pnlClinic
    Private Sub showClinic()
        btnCardio.Show()
        btnVA.Show()
        btnHistory.Show()
        btnExam.Show()
        btnDDx.Show()
        btnSave.Show()
        btnExitClinic.Show()
        btnMessage.Show()
    End Sub

    'View and edit user account info
    Private Sub btnUserInfo_Click(sender As Object, e As EventArgs) Handles btnUserInfo.Click
        ViewInPanel(frmAccEdit)
    End Sub

    'Show Cardio
    Private Sub btnCardio_Click(sender As Object, e As EventArgs) Handles btnCardio.Click
        ViewInPanel(frmCardio)
    End Sub

    'Show VA
    Private Sub btnVA_Click(sender As Object, e As EventArgs) Handles btnVA.Click
        ViewInPanel(frmVA)
    End Sub

    'Show History
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ViewInPanel(frmHistory)
    End Sub

    'Show Exam
    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
        ViewInPanel(frmExam)
    End Sub

    'Show DDx/Rx
    Private Sub btnDDx_Click(sender As Object, e As EventArgs) Handles btnDDx.Click
        ViewInPanel(frmDDx)
    End Sub

    'Go to Messenger
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        frmMessage.Show()
    End Sub

    'Go to Client Centre from pnlClinic
    Private Sub btnExitClinic_Click(sender As Object, e As EventArgs) Handles btnExitClinic.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your clinical data before exiting the consultation session?", "Exit Consultation", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning)
        If dialog = DialogResult.Yes Then
            frmCardio.Close()
            frmVA.Close()
            frmHistory.Close()
            frmExam.Close()
            frmDDx.Close()
            frmConsultView.Close()
            frmCardio.Dispose()
            frmVA.Dispose()
            frmHistory.Dispose()
            frmExam.Dispose()
            frmDDx.Dispose()
            frmConsultView.Show()
            ViewInPanel(frmBioData)
        End If

    End Sub

    'Go to Client Centre from pnlExport
    Private Sub btnExitExport_Click(sender As Object, e As EventArgs) Handles btnExitExport.Click
        frmExport.Dispose()
        frmExport.Close()
        frmClientCentre.Dispose()
        ViewInPanel(frmClientCentre)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        'Alternate menus depending on form in main panel
        If pnlMain.Controls.Contains(frmNewClient) Then
            lblTitle.Text = "New Client Record"
            pnlClinic.Hide()
            btnUserInfo.Hide()
        ElseIf pnlMain.Controls.Contains(frmAccSetUp) Then
            lblTitle.Text = "New User Account"
            btnUserInfo.Hide()
            pnlClinic.Hide()
            pnlExport.Hide()
            Me.Text = "OptoRec - User Account"
        ElseIf pnlMain.Controls.Contains(frmAccEdit) Then
            lblTitle.Text = "Edit User Account"
            btnUserInfo.Hide()
            pnlClinic.Hide()
            Me.Text = frmAccPass.username & " - User Account"
        ElseIf pnlMain.Controls.Contains(frmBioData) Then
            lblTitle.Text = "Biographic Data"
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            hideClinic()
            Me.Text = frmAccPass.username & " - Clients"
        ElseIf pnlMain.Controls.Contains(frmCardio) Then
            lblTitle.Text = "Cardiovascular Examination"
            btnCardio.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = SystemColors.ControlLight
            btnVA.BackColor = Color.Transparent
            btnHistory.BackColor = Color.Transparent
            btnExam.BackColor = Color.Transparent
            btnDDx.BackColor = Color.Transparent
            Me.Text = frmAccPass.username & " - Clinical Consultation"
        ElseIf pnlMain.Controls.Contains(frmVA) Then
            lblTitle.Text = "Visual Acuity Examination"
            btnVA.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = Color.Transparent
            btnVA.BackColor = SystemColors.ControlLight
            btnHistory.BackColor = Color.Transparent
            btnExam.BackColor = Color.Transparent
            btnDDx.BackColor = Color.Transparent
        ElseIf pnlMain.Controls.Contains(frmHistory) Then
            lblTitle.Text = "History"
            btnHistory.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = Color.Transparent
            btnVA.BackColor = Color.Transparent
            btnHistory.BackColor = SystemColors.ControlLight
            btnExam.BackColor = Color.Transparent
            btnDDx.BackColor = Color.Transparent
        ElseIf pnlMain.Controls.Contains(frmExam) Then
            lblTitle.Text = "Internal/External Examination"
            btnExam.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = Color.Transparent
            btnVA.BackColor = Color.Transparent
            btnHistory.BackColor = Color.Transparent
            btnExam.BackColor = SystemColors.ControlLight
            btnDDx.BackColor = Color.Transparent
        ElseIf pnlMain.Controls.Contains(frmDDx) Then
            lblTitle.Text = "Diagnosis/Management"
            btnDDx.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = Color.Transparent
            btnVA.BackColor = Color.Transparent
            btnHistory.BackColor = Color.Transparent
            btnExam.BackColor = Color.Transparent
            btnDDx.BackColor = SystemColors.ControlLight
        ElseIf pnlMain.Controls.Contains(frmExport) Then
            lblTitle.Text = "Data Export Centre"
            btnExitExport.Select()
            pnlExport.Show()
            pnlExport.Dock = DockStyle.Fill
            Me.Text = frmAccPass.username & " - Export"
        Else
            lblTitle.Text = "Client Centre"
            pnlClinic.Hide()
            pnlExport.Hide()
            pnlMenu.Show()
            btnUserInfo.Show()
            Me.Text = frmAccPass.username & " - Clients"
        End If
    End Sub

    'Return to Start screen
    Private Sub frmMainUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As New DialogResult
        dialog = MessageBox.Show("Do you wish to exit and return to the Start window? If 'Yes', any entries you have not saved will be lost.", "Exit",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.Yes Then
            frmConsultView.Close()
            frmMainComp.Close()
            frmStart.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    'Save consultation info
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim VA, cardio, odq, history, ext_exam, int_exam, DxPx As String
        If frmVA.PdOut = "" Then
            frmVA.PdOut = "NULL"
        End If

        If frmVA.PdIn = "" Then
            frmVA.PdIn = "NULL"
        End If

        If frmVA.Lmono = "" Then
            frmVA.Lmono = "NULL"
        End If

        If frmVA.Rmono = "" Then
            frmVA.Rmono = "NULL"
        End If

        If frmCardio.sugar = "" Then
            frmCardio.sugar = "NULL"
        End If

        odq = frmHistory.front & frmHistory.temp & frmHistory.occip & frmHistory.pain & frmHistory.photo & frmHistory.diplo & frmHistory.red & frmHistory.burn & frmHistory.halo &
            frmHistory.float & frmHistory.flash & frmHistory.prick & frmHistory.discharge & frmHistory.tear & frmHistory.itch & frmHistory.grit

        If Not odq = "" Then
            odq = Replace(odq, " ", ", ")
            odq = Replace(odq, "_", " ")
            odq = odq.Remove(odq.LastIndexOf(","))
        End If
        cardio = "UPDATE cardio_vasc SET bp ='" & frmCardio.BP & "', sugar=" & frmCardio.sugar & " WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        VA = "UPDATE va_exam SET outer_pd =" & frmVA.PdOut & ", inner_pd =" & frmVA.PdIn & ", od_mono_pd =" & frmVA.Rmono & ", os_mono_pd =" _
            & frmVA.Lmono & ", od_unaided ='" & frmVA.OdUnAid & "', os_unaided ='" & frmVA.OsUnaid & "', od_aided ='" & frmVA.OdAid & "', os_aided ='" _
            & frmVA.OsAid & "', od_unaided ='" & frmVA.OdUnAid & "', os_unaided ='" & frmVA.OsUnaid & "', od_plus_one ='" & frmVA.OdPlus & "', os_plus_one ='" _
            & frmVA.OsPlus & "', od_pinhole ='" & frmVA.OdPin & "', os_pinhole='" & frmVA.OsPin & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        history = "UPDATE patient_hist SET pc_cc='" & frmHistory.PC & "', hpc='" & frmHistory.HPC & "', odq='" & odq & "', poh='" & frmHistory.POH & "',pmh_psh='" _
            & frmHistory.PMH & "', dh ='" & frmHistory.DH & "', allergy ='" & frmHistory.allergies & "', sh ='" & frmHistory.SH & "', foh ='" & frmHistory.FOH & "', fmh ='" _
            & frmHistory.FMH & "', ddx='" & frmHistory.Ddx & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        ext_exam = "UPDATE ext_exam SET od_lids='" & frmExam.OdLids & "', od_conjuct='" & frmExam.OdConjuct & "', od_cornea='" & frmExam.OdCornea & "', od_ac='" _
            & frmExam.OdAc & "', od_iris='" & frmExam.OdIris & "', od_pupil='" & frmExam.OdPupil & "', od_lens='" & frmExam.OdLens & "', os_lids='" & frmExam.OsLids & "', os_conjuct='" _
            & frmExam.OsConjuct & "', os_cornea='" & frmExam.OsCornea & "', os_ac='" & frmExam.OsAc & "', os_iris='" & frmExam.Osiris & "', os_pupil='" & frmExam.OsPupil & "', os_lens='" _
            & frmExam.OsLens & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        int_exam = "UPDATE int_exam SET od_vitr='" & frmExam.OdVitr & "', od_disc='" & frmExam.OdDisc & "', od_cd='" & frmExam.OdCd & "', od_rim='" & frmExam.OdRim & "', od_av='" _
            & frmExam.OdAv & "', od_peripap='" & frmExam.OdPeripap & "', od_macular='" & frmExam.OdMacular & "', od_peri_ret='" & frmExam.OdPeriRet & "', os_vitr='" _
            & frmExam.OsVitr & "', os_disc='" & frmExam.OsDisc & "', os_cd='" & frmExam.OsCd & "', os_rim='" & frmExam.OsRim & "', os_av='" & frmExam.OsAv & "', os_peripap='" _
            & frmExam.OsPeripap & "', os_macular='" & frmExam.OsMacular & "', os_peri_ret='" & frmExam.OsPeriRet & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        DxPx = "UPDATE dx_mngmnt SET dx ='" & frmDDx.Dx & "', px_mngmnt ='" & frmDDx.Px & "', comments ='" & frmDDx.comments & "' WHERE consult_id =(SELECT MAX(consult_id) FROM consult);"
        sqlQuery = cardio & VA & history & ext_exam & int_exam & DxPx
        dialog = MessageBox.Show("Do you want to save your data entries?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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

        If frmVA.PdOut = "NULL" Then
            frmVA.PdOut = ""
        End If

        If frmVA.PdIn = "NULL" Then
            frmVA.PdIn = ""
        End If

        If frmVA.Lmono = "NULL" Then
            frmVA.Lmono = ""
        End If

        If frmVA.Rmono = "NULL" Then
            frmVA.Rmono = ""
        End If

        If frmCardio.sugar = "NULL" Then
            frmCardio.sugar = ""
        End If

    End Sub

    'Open Help Guide
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim open As New OpenFileDialog
        Dim psi As New ProcessStartInfo

        open.FileName = "OptoRec Mini Project Help Guide.pdf"

        With psi
            .FileName = open.FileName
            .UseShellExecute = True
        End With

        System.Diagnostics.Process.Start(psi)
    End Sub

End Class