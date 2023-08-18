Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports Microsoft.VisualBasic.Devices
Imports Org.BouncyCastle.Crypto.Engines

'OptoRec main interface
Public Class frmMainUI

    Private Sub frmMainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewInPanel(frmUAC)
        pnlClinic.Hide()
    End Sub

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
        btnExitClinic.Show()
        btnMessage.Show()
    End Sub

    'Function to hide buttons pnlMenu
    Private Sub hideBtn()
        btnUser.Hide()
        btnNewUser.Hide()
    End Sub

    'Function to show buttons pnlMenu
    Private Sub showBtn()
        btnUser.Show()
        btnNewUser.Show()
    End Sub

    'Show User Account Centre
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ViewInPanel(frmUAC)
    End Sub

    'Show User Account Setup
    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        frmAccSetUp.Dispose()
        ViewInPanel(frmAccSetUp)
    End Sub

    'Show cardio
    Private Sub btnCardio_Click(sender As Object, e As EventArgs) Handles btnCardio.Click
        Dim dialog As DialogResult
        If Not pnlMain.Controls.Contains(frmCardio) Then
            dialog = MessageBox.Show("Have you saved your data before exiting the '" & lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                ViewInPanel(frmCardio)
            End If
        End If
    End Sub

    'Show VA
    Private Sub btnVA_Click(sender As Object, e As EventArgs) Handles btnVA.Click
        Dim dialog As DialogResult
        If Not pnlMain.Controls.Contains(frmVA) Then
            dialog = MessageBox.Show("Have you saved your data before exiting the '" & lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                ViewInPanel(frmVA)
            End If
        End If

    End Sub

    'Show history
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim dialog As DialogResult
        If Not pnlMain.Controls.Contains(frmHistory) Then
            dialog = MessageBox.Show("Have you saved your data before exiting the '" & lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                ViewInPanel(frmHistory)
            End If
        End If

    End Sub

    'Show exam
    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
        Dim dialog As DialogResult
        If Not pnlMain.Controls.Contains(frmExam) Then
            dialog = MessageBox.Show("Have you saved your data before exiting the '" & lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                ViewInPanel(frmExam)
            End If
        End If

    End Sub

    'Show diagnoses etc.
    Private Sub btnDDx_Click(sender As Object, e As EventArgs) Handles btnDDx.Click
        Dim dialog As DialogResult
        If Not pnlMain.Controls.Contains(frmVA) Then
            dialog = MessageBox.Show("Have you saved your data before exiting the '" & lblTitle.Text & "' form?", "Exit", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                ViewInPanel(frmDDx)
            End If
        End If
    End Sub

    'Go to messenger
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        frmMessage.Show()
    End Sub
    'Show products and services
    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        ViewInPanel(frmItems)
    End Sub

    'Show receipts
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        frmCheckOut.Dispose()
        ViewInPanel(frmCheckOut)
    End Sub

    'Return to welcome screen
    Private Sub frmMainUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmStart.Show()
    End Sub

    'Go to client centre from pnlAcc
    Private Sub btnExitAcc_Click(sender As Object, e As EventArgs) Handles btnExitAcc.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting the 'Accounting Centre'?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            frmItems.Dispose()
            frmViewHistory.Dispose()
            frmCheckOut.Dispose()
            frmClientCentre.Dispose()
            ViewInPanel(frmClientCentre)
        End If
    End Sub

    'Go to client centre from pnlClinic
    Private Sub btnExitClinic_Click(sender As Object, e As EventArgs) Handles btnExitClinic.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Have you saved your data before exiting this client's clinical form?", "Exit clincal records", MessageBoxButtons.YesNo,
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

    'Go to client centre from pnlExport
    Private Sub btnExitExport_Click(sender As Object, e As EventArgs) Handles btnExitExport.Click
        frmExport.Dispose()
        frmExport.Close()
        frmClientCentre.Dispose()
        ViewInPanel(frmClientCentre)
    End Sub

    'Alternate panel menus depending on form in main panel
    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        If pnlMain.Controls.Contains(frmClientCentre) Then
            lblTitle.Text = "Client Centre"
            pnlAcc.Hide()
            pnlClinic.Hide()
            pnlExport.Hide()
            hideBtn()
        ElseIf pnlMain.Controls.Contains(frmNewClient) Then
            lblTitle.Text = "New Client Record"
            pnlClinic.Hide()
        ElseIf pnlMain.Controls.Contains(frmAccSetUp) Then
            lblTitle.Text = "New User Account"
            btnUser.BackColor = Color.Transparent
            btnNewUser.BackColor = Color.FromArgb(229, 229, 229)
            btnNewUser.Select()
            pnlClinic.Hide()
        ElseIf pnlMain.Controls.Contains(frmAccEdit) Then
            lblTitle.Text = "Edit User Account"
            hideBtn()
            pnlClinic.Hide()
        ElseIf pnlMain.Controls.Contains(frmBioData) Then
            lblTitle.Text = "Biographic Data"
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            hideClinic()
        ElseIf pnlMain.Controls.Contains(frmCardio) Then
            lblTitle.Text = "Cardiovascular Examination"
            btnCardio.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = Color.FromArgb(229, 229, 229)
            btnVA.BackColor = Color.Transparent
            btnHistory.BackColor = Color.Transparent
            btnExam.BackColor = Color.Transparent
            btnDDx.BackColor = Color.Transparent
        ElseIf pnlMain.Controls.Contains(frmVA) Then
            lblTitle.Text = "Visual Acuity Examination"
            btnVA.Select()
            pnlClinic.Show()
            pnlClinic.Dock = DockStyle.Fill
            showClinic()
            btnCardio.BackColor = Color.Transparent
            btnVA.BackColor = Color.FromArgb(229, 229, 229)
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
            btnHistory.BackColor = Color.FromArgb(229, 229, 229)
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
            btnExam.BackColor = Color.FromArgb(229, 229, 229)
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
            btnDDx.BackColor = Color.FromArgb(229, 229, 229)
        ElseIf pnlMain.Controls.Contains(frmCheckOut) Then
            lblTitle.Text = "Transaction Centre"
            btnCheckout.Select()
            pnlAcc.Show()
            pnlAcc.Dock = DockStyle.Fill
            btnCheckout.BackColor = Color.FromArgb(229, 229, 229)
            btnItems.BackColor = Color.Transparent
        ElseIf pnlMain.Controls.Contains(frmItems) Then
            lblTitle.Text = "Products And Services"
            btnItems.Select()
            pnlAcc.Show()
            pnlAcc.Dock = DockStyle.Fill
            btnCheckout.BackColor = Color.Transparent
            btnItems.BackColor = Color.FromArgb(229, 229, 229)
        ElseIf pnlMain.Controls.Contains(frmExport) Then
            lblTitle.Text = "Data Export Centre"
            btnExitExport.Select()
            pnlExport.Show()
            pnlExport.Dock = DockStyle.Fill
        Else
            lblTitle.Text = "User Account Centre"
            btnUser.BackColor = Color.FromArgb(229, 229, 229)
            btnNewUser.BackColor = Color.Transparent
            btnUser.Select()
            pnlClinic.Hide()
            pnlAcc.Hide()
            pnlExport.Hide()
            pnlMenu.Show()
            showBtn()
        End If
    End Sub

End Class