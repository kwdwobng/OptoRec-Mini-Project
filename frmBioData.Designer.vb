<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBioData
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmBioData))
        lblFirstName = New Label()
        lblOtherName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblJob = New Label()
        txtFirstName = New TextBox()
        txtOtherName = New TextBox()
        txtJob = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        grpBioData = New GroupBox()
        txtGender = New TextBox()
        lblGender = New Label()
        txtCardNum = New TextBox()
        txtReligion = New TextBox()
        lblCardNum = New Label()
        lblReligion = New Label()
        txtBirthDate = New TextBox()
        lblBirthDate = New Label()
        txtDate = New TextBox()
        lblDate = New Label()
        txtAge = New TextBox()
        lblAge = New Label()
        txtSurname = New TextBox()
        lblSurname = New Label()
        btnExit = New Button()
        btnUpdateAcc = New Button()
        btnView = New Button()
        ToolTip1 = New ToolTip(components)
        btnDelete = New Button()
        GroupBox2 = New GroupBox()
        grpBioData.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstName.Location = New Point(6, 67)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(83, 20)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name:"
        ' 
        ' lblOtherName
        ' 
        lblOtherName.AutoSize = True
        lblOtherName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblOtherName.Location = New Point(6, 155)
        lblOtherName.Name = "lblOtherName"
        lblOtherName.Size = New Size(99, 20)
        lblOtherName.TabIndex = 1
        lblOtherName.Text = "Other Names:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(506, 193)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(112, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "E-mail Address:"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhoneNum.Location = New Point(506, 149)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(111, 20)
        lblPhoneNum.TabIndex = 3
        lblPhoneNum.Text = "Phone Number:"
        ' 
        ' lblJob
        ' 
        lblJob.AutoSize = True
        lblJob.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblJob.Location = New Point(506, 108)
        lblJob.Name = "lblJob"
        lblJob.Size = New Size(88, 20)
        lblJob.TabIndex = 4
        lblJob.Text = "Occupation:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstName.Location = New Point(113, 61)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(257, 27)
        txtFirstName.TabIndex = 2
        ' 
        ' txtOtherName
        ' 
        txtOtherName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOtherName.Location = New Point(113, 149)
        txtOtherName.Name = "txtOtherName"
        txtOtherName.Size = New Size(257, 27)
        txtOtherName.TabIndex = 4
        ' 
        ' txtJob
        ' 
        txtJob.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtJob.Location = New Point(623, 102)
        txtJob.Name = "txtJob"
        txtJob.Size = New Size(395, 27)
        txtJob.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(623, 190)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(395, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNum.Location = New Point(623, 146)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(395, 27)
        txtPhoneNum.TabIndex = 10
        ' 
        ' grpBioData
        ' 
        grpBioData.Controls.Add(txtGender)
        grpBioData.Controls.Add(lblGender)
        grpBioData.Controls.Add(txtCardNum)
        grpBioData.Controls.Add(txtReligion)
        grpBioData.Controls.Add(lblCardNum)
        grpBioData.Controls.Add(txtJob)
        grpBioData.Controls.Add(lblEmail)
        grpBioData.Controls.Add(lblReligion)
        grpBioData.Controls.Add(lblPhoneNum)
        grpBioData.Controls.Add(txtBirthDate)
        grpBioData.Controls.Add(lblJob)
        grpBioData.Controls.Add(lblBirthDate)
        grpBioData.Controls.Add(txtEmail)
        grpBioData.Controls.Add(txtDate)
        grpBioData.Controls.Add(txtPhoneNum)
        grpBioData.Controls.Add(lblDate)
        grpBioData.Controls.Add(txtAge)
        grpBioData.Controls.Add(lblAge)
        grpBioData.Controls.Add(txtSurname)
        grpBioData.Controls.Add(lblSurname)
        grpBioData.Controls.Add(txtOtherName)
        grpBioData.Controls.Add(txtFirstName)
        grpBioData.Controls.Add(lblOtherName)
        grpBioData.Controls.Add(lblFirstName)
        grpBioData.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grpBioData.ImeMode = ImeMode.NoControl
        grpBioData.Location = New Point(21, 104)
        grpBioData.Name = "grpBioData"
        grpBioData.Size = New Size(1041, 307)
        grpBioData.TabIndex = 15
        grpBioData.TabStop = False
        ' 
        ' txtGender
        ' 
        txtGender.BackColor = SystemColors.InactiveBorder
        txtGender.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtGender.Location = New Point(623, 58)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(82, 27)
        txtGender.TabIndex = 8
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(506, 61)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(60, 20)
        lblGender.TabIndex = 23
        lblGender.Text = "Gender:"
        ' 
        ' txtCardNum
        ' 
        txtCardNum.BackColor = SystemColors.InactiveBorder
        txtCardNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCardNum.Location = New Point(113, 20)
        txtCardNum.Name = "txtCardNum"
        txtCardNum.ReadOnly = True
        txtCardNum.Size = New Size(82, 27)
        txtCardNum.TabIndex = 1
        ' 
        ' txtReligion
        ' 
        txtReligion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtReligion.Location = New Point(623, 234)
        txtReligion.Name = "txtReligion"
        txtReligion.Size = New Size(257, 27)
        txtReligion.TabIndex = 12
        ' 
        ' lblCardNum
        ' 
        lblCardNum.AutoSize = True
        lblCardNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblCardNum.Location = New Point(6, 23)
        lblCardNum.Name = "lblCardNum"
        lblCardNum.Size = New Size(101, 20)
        lblCardNum.TabIndex = 21
        lblCardNum.Text = "Card Number:"
        ' 
        ' lblReligion
        ' 
        lblReligion.AutoSize = True
        lblReligion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblReligion.Location = New Point(506, 237)
        lblReligion.Name = "lblReligion"
        lblReligion.Size = New Size(67, 20)
        lblReligion.TabIndex = 19
        lblReligion.Text = "Religion:"
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.BackColor = SystemColors.InactiveBorder
        txtBirthDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtBirthDate.Location = New Point(113, 237)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.ReadOnly = True
        txtBirthDate.Size = New Size(82, 27)
        txtBirthDate.TabIndex = 6
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.AutoSize = True
        lblBirthDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblBirthDate.Location = New Point(6, 240)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(97, 20)
        lblBirthDate.TabIndex = 17
        lblBirthDate.Text = "Date of Birth:"
        ' 
        ' txtDate
        ' 
        txtDate.BackColor = SystemColors.InactiveBorder
        txtDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtDate.Location = New Point(623, 20)
        txtDate.Name = "txtDate"
        txtDate.ReadOnly = True
        txtDate.Size = New Size(82, 27)
        txtDate.TabIndex = 7
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.Location = New Point(506, 23)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(87, 20)
        lblDate.TabIndex = 15
        lblDate.Text = "Created On:"
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = SystemColors.InactiveBorder
        txtAge.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtAge.Location = New Point(113, 193)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(82, 27)
        txtAge.TabIndex = 5
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblAge.Location = New Point(6, 196)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(39, 20)
        lblAge.TabIndex = 13
        lblAge.Text = "Age:"
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSurname.Location = New Point(113, 105)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(257, 27)
        txtSurname.TabIndex = 3
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblSurname.Location = New Point(6, 111)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(70, 20)
        lblSurname.TabIndex = 12
        lblSurname.Text = "Surname:"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Info
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(898, 480)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(141, 45)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        ToolTip1.SetToolTip(btnExit, "Exit")
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateAcc
        ' 
        btnUpdateAcc.BackColor = SystemColors.GradientInactiveCaption
        btnUpdateAcc.FlatStyle = FlatStyle.Flat
        btnUpdateAcc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateAcc.Image = CType(resources.GetObject("btnUpdateAcc.Image"), Image)
        btnUpdateAcc.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdateAcc.Location = New Point(751, 429)
        btnUpdateAcc.Name = "btnUpdateAcc"
        btnUpdateAcc.Size = New Size(141, 45)
        btnUpdateAcc.TabIndex = 16
        btnUpdateAcc.Text = "Update"
        ToolTip1.SetToolTip(btnUpdateAcc, "Update all client info on display")
        btnUpdateAcc.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = SystemColors.GradientInactiveCaption
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnView.Image = CType(resources.GetObject("btnView.Image"), Image)
        btnView.ImageAlign = ContentAlignment.MiddleLeft
        btnView.Location = New Point(23, 26)
        btnView.Name = "btnView"
        btnView.Size = New Size(141, 45)
        btnView.TabIndex = 0
        btnView.Text = "Open"
        ToolTip1.SetToolTip(btnView, "Open Consult Portal")
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Info
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(898, 429)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(141, 45)
        btnDelete.TabIndex = 22
        btnDelete.Text = "Delete"
        ToolTip1.SetToolTip(btnDelete, "Delete account")
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnView)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(875, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(187, 86)
        GroupBox2.TabIndex = 27
        GroupBox2.TabStop = False
        GroupBox2.Text = "Consult Portal"
        ' 
        ' frmBioData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(btnDelete)
        Controls.Add(btnExit)
        Controls.Add(btnUpdateAcc)
        Controls.Add(GroupBox2)
        Controls.Add(grpBioData)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmBioData"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Biographic Data"
        grpBioData.ResumeLayout(False)
        grpBioData.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblOtherName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblJob As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtOtherName As TextBox
    Friend WithEvents txtJob As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents grpBioData As GroupBox
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtReligion As TextBox
    Friend WithEvents lblReligion As Label
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents lblCardNum As Label
    Friend WithEvents txtBP As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDelete As Button
End Class
