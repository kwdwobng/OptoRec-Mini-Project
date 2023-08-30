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
        btnUserInfo = New Button()
        btnExitExport = New Button()
        btnVA = New Button()
        btnHistory = New Button()
        btnExam = New Button()
        btnDDx = New Button()
        btnExitClinic = New Button()
        btnCardio = New Button()
        btnMessage = New Button()
        btnMenu = New Button()
        btnHelp = New Button()
        btnSave = New Button()
        pnlExport = New Panel()
        pnlClinic = New Panel()
        pnlThickBorder = New Panel()
        pnlMenu = New Panel()
        pnlTitle.SuspendLayout()
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
        pnlTitle.Size = New Size(1130, 27)
        pnlTitle.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.AutoSize = True
        lblTitle.BackColor = SystemColors.InactiveCaptionText
        lblTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(500, 2)
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
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(150, 27)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1130, 693)
        pnlMain.TabIndex = 2
        ' 
        ' btnUserInfo
        ' 
        btnUserInfo.BackColor = Color.Transparent
        btnUserInfo.FlatAppearance.BorderSize = 0
        btnUserInfo.FlatStyle = FlatStyle.Flat
        btnUserInfo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUserInfo.ForeColor = Color.Black
        btnUserInfo.Image = CType(resources.GetObject("btnUserInfo.Image"), Image)
        btnUserInfo.ImageAlign = ContentAlignment.MiddleLeft
        btnUserInfo.Location = New Point(0, 23)
        btnUserInfo.Name = "btnUserInfo"
        btnUserInfo.Size = New Size(150, 45)
        btnUserInfo.TabIndex = 101
        btnUserInfo.Text = "User Info"
        btnUserInfo.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnUserInfo, "User Accounts")
        btnUserInfo.UseVisualStyleBackColor = False
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
        btnExitClinic.Location = New Point(0, 380)
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
        btnMessage.Location = New Point(0, 329)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(150, 45)
        btnMessage.TabIndex = 206
        btnMessage.Text = "Quick Message"
        btnMessage.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnMessage, "Quick Message")
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
        btnMenu.Size = New Size(150, 24)
        btnMenu.TabIndex = 0
        ToolTip1.SetToolTip(btnMenu, "Menu")
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnHelp
        ' 
        btnHelp.BackColor = Color.Transparent
        btnHelp.FlatAppearance.BorderSize = 0
        btnHelp.FlatStyle = FlatStyle.Flat
        btnHelp.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnHelp.ForeColor = Color.Black
        btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), Image)
        btnHelp.ImageAlign = ContentAlignment.MiddleLeft
        btnHelp.Location = New Point(0, 663)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(150, 45)
        btnHelp.TabIndex = 103
        btnHelp.Text = "Help"
        btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnHelp, "OptoRec Help Guide")
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.GradientInactiveCaption
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(0, 278)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 45)
        btnSave.TabIndex = 34
        btnSave.Text = "Save"
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnSave, "Save clinical info")
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' pnlExport
        ' 
        pnlExport.BackColor = SystemColors.ControlDark
        pnlExport.Controls.Add(btnExitExport)
        pnlExport.Location = New Point(60, 547)
        pnlExport.Name = "pnlExport"
        pnlExport.Size = New Size(150, 79)
        pnlExport.TabIndex = 3
        ' 
        ' pnlClinic
        ' 
        pnlClinic.BackColor = SystemColors.ControlDark
        pnlClinic.Controls.Add(btnSave)
        pnlClinic.Controls.Add(btnMessage)
        pnlClinic.Controls.Add(btnCardio)
        pnlClinic.Controls.Add(btnExitClinic)
        pnlClinic.Controls.Add(btnDDx)
        pnlClinic.Controls.Add(btnExam)
        pnlClinic.Controls.Add(btnHistory)
        pnlClinic.Controls.Add(btnVA)
        pnlClinic.Location = New Point(60, 238)
        pnlClinic.Name = "pnlClinic"
        pnlClinic.Size = New Size(150, 127)
        pnlClinic.TabIndex = 2
        ' 
        ' pnlThickBorder
        ' 
        pnlThickBorder.BackColor = SystemColors.ControlDarkDark
        pnlThickBorder.Controls.Add(btnMenu)
        pnlThickBorder.Dock = DockStyle.Top
        pnlThickBorder.Location = New Point(0, 0)
        pnlThickBorder.Name = "pnlThickBorder"
        pnlThickBorder.Size = New Size(150, 27)
        pnlThickBorder.TabIndex = 0
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = SystemColors.ControlDark
        pnlMenu.Controls.Add(btnHelp)
        pnlMenu.Controls.Add(pnlThickBorder)
        pnlMenu.Controls.Add(pnlClinic)
        pnlMenu.Controls.Add(pnlExport)
        pnlMenu.Controls.Add(btnUserInfo)
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
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMainUI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OptoRec 1.0.0"
        ToolTip1.SetToolTip(Me, "Menu")
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
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
    Friend WithEvents btnUserInfo As Button
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
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnSave As Button
End Class
