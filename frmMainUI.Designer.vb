<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMainUI))
        pnlTitle = New Panel()
        lblTitle = New Label()
        pnlMain = New Panel()
        ToolTip1 = New ToolTip(components)
        btnUser = New Button()
        btnNewUser = New Button()
        btnCheckout = New Button()
        btnItems = New Button()
        btnExitAcc = New Button()
        btnExitExport = New Button()
        btnVA = New Button()
        btnHistory = New Button()
        btnExam = New Button()
        btnDDx = New Button()
        btnExitClinic = New Button()
        btnCardio = New Button()
        btnMessage = New Button()
        btnMenu = New Button()
        pnlAcc = New Panel()
        pnlExport = New Panel()
        pnlClinic = New Panel()
        pnlThickBorder = New Panel()
        pnlMenu = New Panel()
        pnlTitle.SuspendLayout()
        pnlAcc.SuspendLayout()
        pnlExport.SuspendLayout()
        pnlClinic.SuspendLayout()
        pnlThickBorder.SuspendLayout()
        pnlMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = SystemColors.ActiveCaptionText
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Dock = DockStyle.Top
        pnlTitle.Location = New Point(150, 0)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(1130, 23)
        pnlTitle.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.BackColor = SystemColors.InactiveCaptionText
        lblTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(471, 1)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(38, 20)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Title"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlMain
        ' 
        pnlMain.AutoScroll = True
        pnlMain.BackColor = SystemColors.ControlLightLight
        pnlMain.Location = New Point(150, 23)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1130, 697)
        pnlMain.TabIndex = 2
        ' 
        ' btnUser
        ' 
        btnUser.BackColor = Color.Transparent
        btnUser.FlatAppearance.BorderSize = 0
        btnUser.FlatStyle = FlatStyle.Flat
        btnUser.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUser.ForeColor = Color.Black
        btnUser.Image = CType(resources.GetObject("btnUser.Image"), Image)
        btnUser.ImageAlign = ContentAlignment.MiddleLeft
        btnUser.Location = New Point(0, 23)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(150, 45)
        btnUser.TabIndex = 101
        btnUser.Text = "User"
        btnUser.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnUser, "User Accounts")
        btnUser.UseVisualStyleBackColor = False
        ' 
        ' btnNewUser
        ' 
        btnNewUser.BackColor = Color.Transparent
        btnNewUser.FlatAppearance.BorderSize = 0
        btnNewUser.FlatStyle = FlatStyle.Flat
        btnNewUser.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNewUser.ForeColor = Color.Black
        btnNewUser.Image = CType(resources.GetObject("btnNewUser.Image"), Image)
        btnNewUser.ImageAlign = ContentAlignment.MiddleLeft
        btnNewUser.Location = New Point(0, 74)
        btnNewUser.Name = "btnNewUser"
        btnNewUser.Size = New Size(150, 45)
        btnNewUser.TabIndex = 102
        btnNewUser.Text = "Add User"
        btnNewUser.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnNewUser, "Add new User Account")
        btnNewUser.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.Transparent
        btnCheckout.FlatAppearance.BorderSize = 0
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCheckout.ForeColor = Color.Black
        btnCheckout.Image = CType(resources.GetObject("btnCheckout.Image"), Image)
        btnCheckout.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckout.Location = New Point(0, 23)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(150, 45)
        btnCheckout.TabIndex = 301
        btnCheckout.Text = "Transactions"
        btnCheckout.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnCheckout, "Client Receipts")
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' btnItems
        ' 
        btnItems.Anchor = AnchorStyles.Top
        btnItems.BackColor = Color.Transparent
        btnItems.FlatAppearance.BorderSize = 0
        btnItems.FlatStyle = FlatStyle.Flat
        btnItems.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnItems.ForeColor = Color.Black
        btnItems.Image = CType(resources.GetObject("btnItems.Image"), Image)
        btnItems.ImageAlign = ContentAlignment.MiddleLeft
        btnItems.Location = New Point(0, 74)
        btnItems.Name = "btnItems"
        btnItems.Size = New Size(150, 45)
        btnItems.TabIndex = 302
        btnItems.Text = "Products etc."
        btnItems.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnItems, "Products & Services")
        btnItems.UseVisualStyleBackColor = False
        ' 
        ' btnExitAcc
        ' 
        btnExitAcc.Anchor = AnchorStyles.Top
        btnExitAcc.BackColor = SystemColors.Info
        btnExitAcc.FlatAppearance.BorderSize = 0
        btnExitAcc.FlatStyle = FlatStyle.Flat
        btnExitAcc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExitAcc.ForeColor = Color.Black
        btnExitAcc.Image = CType(resources.GetObject("btnExitAcc.Image"), Image)
        btnExitAcc.ImageAlign = ContentAlignment.MiddleLeft
        btnExitAcc.Location = New Point(0, 125)
        btnExitAcc.Name = "btnExitAcc"
        btnExitAcc.Size = New Size(150, 45)
        btnExitAcc.TabIndex = 303
        btnExitAcc.Text = "Exit"
        btnExitAcc.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnExitAcc, "Exit Accounting Centre")
        btnExitAcc.UseVisualStyleBackColor = False
        ' 
        ' btnExitExport
        ' 
        btnExitExport.BackColor = SystemColors.Info
        btnExitExport.FlatAppearance.BorderSize = 0
        btnExitExport.FlatStyle = FlatStyle.Flat
        btnExitExport.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExitExport.ForeColor = Color.Black
        btnExitExport.Image = CType(resources.GetObject("btnExitExport.Image"), Image)
        btnExitExport.ImageAlign = ContentAlignment.MiddleLeft
        btnExitExport.Location = New Point(0, 23)
        btnExitExport.Name = "btnExitExport"
        btnExitExport.Size = New Size(150, 45)
        btnExitExport.TabIndex = 401
        btnExitExport.Text = "Exit"
        btnExitExport.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnExitExport, "Exit Data Export Centre")
        btnExitExport.UseVisualStyleBackColor = False
        ' 
        ' btnVA
        ' 
        btnVA.BackColor = Color.Transparent
        btnVA.FlatAppearance.BorderSize = 0
        btnVA.FlatStyle = FlatStyle.Flat
        btnVA.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnVA.ForeColor = Color.Black
        btnVA.Image = CType(resources.GetObject("btnVA.Image"), Image)
        btnVA.ImageAlign = ContentAlignment.MiddleLeft
        btnVA.Location = New Point(0, 74)
        btnVA.Name = "btnVA"
        btnVA.Size = New Size(150, 45)
        btnVA.TabIndex = 202
        btnVA.Text = "Visual Acuity"
        btnVA.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnVA, "Visual Acuity Examination")
        btnVA.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.Transparent
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnHistory.ForeColor = Color.Black
        btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), Image)
        btnHistory.ImageAlign = ContentAlignment.MiddleLeft
        btnHistory.Location = New Point(0, 125)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(150, 45)
        btnHistory.TabIndex = 203
        btnHistory.Text = "History"
        btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnHistory, "Client History")
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnExam
        ' 
        btnExam.BackColor = Color.Transparent
        btnExam.FlatAppearance.BorderSize = 0
        btnExam.FlatStyle = FlatStyle.Flat
        btnExam.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExam.ForeColor = Color.Black
        btnExam.Image = CType(resources.GetObject("btnExam.Image"), Image)
        btnExam.ImageAlign = ContentAlignment.MiddleLeft
        btnExam.Location = New Point(0, 176)
        btnExam.Name = "btnExam"
        btnExam.Size = New Size(150, 45)
        btnExam.TabIndex = 204
        btnExam.Text = "Examination"
        btnExam.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnExam, "Internal/External Examination")
        btnExam.UseVisualStyleBackColor = False
        ' 
        ' btnDDx
        ' 
        btnDDx.BackColor = Color.Transparent
        btnDDx.FlatAppearance.BorderSize = 0
        btnDDx.FlatStyle = FlatStyle.Flat
        btnDDx.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDDx.ForeColor = Color.Black
        btnDDx.Image = CType(resources.GetObject("btnDDx.Image"), Image)
        btnDDx.ImageAlign = ContentAlignment.MiddleLeft
        btnDDx.Location = New Point(0, 227)
        btnDDx.Name = "btnDDx"
        btnDDx.Size = New Size(150, 45)
        btnDDx.TabIndex = 205
        btnDDx.Text = "DDx/Rx"
        btnDDx.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnDDx, "Diagnosis, Prescription," & vbCrLf & "Plan of Management &" & vbCrLf & "Clinical Comments" & vbCrLf)
        btnDDx.UseVisualStyleBackColor = False
        ' 
        ' btnExitClinic
        ' 
        btnExitClinic.BackColor = SystemColors.Info
        btnExitClinic.FlatAppearance.BorderSize = 0
        btnExitClinic.FlatStyle = FlatStyle.Flat
        btnExitClinic.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExitClinic.ForeColor = Color.Black
        btnExitClinic.Image = CType(resources.GetObject("btnExitClinic.Image"), Image)
        btnExitClinic.ImageAlign = ContentAlignment.MiddleLeft
        btnExitClinic.Location = New Point(0, 329)
        btnExitClinic.Name = "btnExitClinic"
        btnExitClinic.Size = New Size(150, 45)
        btnExitClinic.TabIndex = 207
        btnExitClinic.Text = "Exit"
        btnExitClinic.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnExitClinic, "Exit clinical records")
        btnExitClinic.UseVisualStyleBackColor = False
        ' 
        ' btnCardio
        ' 
        btnCardio.BackColor = Color.Transparent
        btnCardio.FlatAppearance.BorderSize = 0
        btnCardio.FlatStyle = FlatStyle.Flat
        btnCardio.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCardio.ForeColor = Color.Black
        btnCardio.Image = CType(resources.GetObject("btnCardio.Image"), Image)
        btnCardio.ImageAlign = ContentAlignment.MiddleLeft
        btnCardio.Location = New Point(0, 23)
        btnCardio.Name = "btnCardio"
        btnCardio.Size = New Size(150, 45)
        btnCardio.TabIndex = 201
        btnCardio.Text = "Cardiovasc."
        btnCardio.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnCardio, "Cardiovascular Examination")
        btnCardio.UseVisualStyleBackColor = False
        ' 
        ' btnMessage
        ' 
        btnMessage.BackColor = SystemColors.ControlLightLight
        btnMessage.FlatAppearance.BorderSize = 0
        btnMessage.FlatStyle = FlatStyle.Flat
        btnMessage.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnMessage.Image = CType(resources.GetObject("btnMessage.Image"), Image)
        btnMessage.ImageAlign = ContentAlignment.MiddleLeft
        btnMessage.Location = New Point(0, 278)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(150, 45)
        btnMessage.TabIndex = 206
        btnMessage.Text = "Messenger"
        btnMessage.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnMessage, "Leave a short message")
        btnMessage.UseVisualStyleBackColor = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.Transparent
        btnMenu.Dock = DockStyle.Top
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), Image)
        btnMenu.ImageAlign = ContentAlignment.MiddleLeft
        btnMenu.Location = New Point(0, 0)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(150, 23)
        btnMenu.TabIndex = 0
        ToolTip1.SetToolTip(btnMenu, "Menu")
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' pnlAcc
        ' 
        pnlAcc.BackColor = SystemColors.ControlDark
        pnlAcc.Controls.Add(btnExitAcc)
        pnlAcc.Controls.Add(btnItems)
        pnlAcc.Controls.Add(btnCheckout)
        pnlAcc.Location = New Point(60, 431)
        pnlAcc.Name = "pnlAcc"
        pnlAcc.Size = New Size(150, 164)
        pnlAcc.TabIndex = 2
        ' 
        ' pnlExport
        ' 
        pnlExport.BackColor = SystemColors.ControlDark
        pnlExport.Controls.Add(btnExitExport)
        pnlExport.Location = New Point(60, 601)
        pnlExport.Name = "pnlExport"
        pnlExport.Size = New Size(150, 79)
        pnlExport.TabIndex = 3
        ' 
        ' pnlClinic
        ' 
        pnlClinic.BackColor = SystemColors.ControlDark
        pnlClinic.Controls.Add(btnMessage)
        pnlClinic.Controls.Add(btnCardio)
        pnlClinic.Controls.Add(btnExitClinic)
        pnlClinic.Controls.Add(btnDDx)
        pnlClinic.Controls.Add(btnExam)
        pnlClinic.Controls.Add(btnHistory)
        pnlClinic.Controls.Add(btnVA)
        pnlClinic.Location = New Point(60, 287)
        pnlClinic.Name = "pnlClinic"
        pnlClinic.Size = New Size(150, 138)
        pnlClinic.TabIndex = 2
        ' 
        ' pnlThickBorder
        ' 
        pnlThickBorder.BackColor = SystemColors.ControlDarkDark
        pnlThickBorder.Controls.Add(btnMenu)
        pnlThickBorder.Dock = DockStyle.Top
        pnlThickBorder.Location = New Point(0, 0)
        pnlThickBorder.Name = "pnlThickBorder"
        pnlThickBorder.Size = New Size(150, 23)
        pnlThickBorder.TabIndex = 0
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = SystemColors.ControlDark
        pnlMenu.Controls.Add(pnlThickBorder)
        pnlMenu.Controls.Add(pnlClinic)
        pnlMenu.Controls.Add(pnlExport)
        pnlMenu.Controls.Add(pnlAcc)
        pnlMenu.Controls.Add(btnNewUser)
        pnlMenu.Controls.Add(btnUser)
        pnlMenu.Dock = DockStyle.Left
        pnlMenu.Location = New Point(0, 0)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(150, 720)
        pnlMenu.TabIndex = 1
        ' 
        ' frmMainUI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1280, 720)
        Controls.Add(pnlMain)
        Controls.Add(pnlTitle)
        Controls.Add(pnlMenu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMainUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OptoRec 1.0.0"
        ToolTip1.SetToolTip(Me, "Menu")
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        pnlAcc.ResumeLayout(False)
        pnlExport.ResumeLayout(False)
        pnlClinic.ResumeLayout(False)
        pnlThickBorder.ResumeLayout(False)
        pnlMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnUser As Button
    Friend WithEvents btnNewUser As Button
    Friend WithEvents pnlAcc As Panel
    Friend WithEvents btnExitAcc As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents pnlExport As Panel
    Friend WithEvents btnExitExport As Button
    Friend WithEvents pnlClinic As Panel
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnCardio As Button
    Friend WithEvents btnExitClinic As Button
    Friend WithEvents btnDDx As Button
    Friend WithEvents btnExam As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnVA As Button
    Friend WithEvents pnlThickBorder As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnMenu As Button
End Class
