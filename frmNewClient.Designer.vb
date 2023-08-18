<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewClient
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmNewClient))
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
        DateTimePicker1 = New DateTimePicker()
        rbtnFemale = New RadioButton()
        rbtnMale = New RadioButton()
        lblGender = New Label()
        txtCardNum = New TextBox()
        txtReligion = New TextBox()
        lblCardNum = New Label()
        lblReligion = New Label()
        lblBirthDate = New Label()
        txtSurname = New TextBox()
        lblSurname = New Label()
        btnExit = New Button()
        btnSaveAcc = New Button()
        ToolTip1 = New ToolTip(components)
        Label1 = New Label()
        grpBioData.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstName.Location = New Point(25, 65)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(83, 20)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name:"
        ' 
        ' lblOtherName
        ' 
        lblOtherName.AutoSize = True
        lblOtherName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblOtherName.Location = New Point(23, 135)
        lblOtherName.Name = "lblOtherName"
        lblOtherName.Size = New Size(99, 20)
        lblOtherName.TabIndex = 1
        lblOtherName.Text = "Other Names:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(542, 131)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(112, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "E-mail Address:"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhoneNum.Location = New Point(540, 98)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(111, 20)
        lblPhoneNum.TabIndex = 3
        lblPhoneNum.Text = "Phone Number:"
        ' 
        ' lblJob
        ' 
        lblJob.AutoSize = True
        lblJob.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblJob.Location = New Point(539, 65)
        lblJob.Name = "lblJob"
        lblJob.Size = New Size(88, 20)
        lblJob.TabIndex = 4
        lblJob.Text = "Occupation:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstName.Location = New Point(132, 62)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(257, 27)
        txtFirstName.TabIndex = 2
        ' 
        ' txtOtherName
        ' 
        txtOtherName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOtherName.Location = New Point(132, 128)
        txtOtherName.Name = "txtOtherName"
        txtOtherName.Size = New Size(395, 27)
        txtOtherName.TabIndex = 4
        ' 
        ' txtJob
        ' 
        txtJob.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtJob.Location = New Point(660, 62)
        txtJob.Name = "txtJob"
        txtJob.Size = New Size(395, 27)
        txtJob.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(660, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(395, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNum.Location = New Point(660, 95)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(395, 27)
        txtPhoneNum.TabIndex = 10
        ' 
        ' grpBioData
        ' 
        grpBioData.Controls.Add(DateTimePicker1)
        grpBioData.Controls.Add(rbtnFemale)
        grpBioData.Controls.Add(rbtnMale)
        grpBioData.Controls.Add(lblGender)
        grpBioData.Controls.Add(txtCardNum)
        grpBioData.Controls.Add(txtReligion)
        grpBioData.Controls.Add(lblCardNum)
        grpBioData.Controls.Add(txtJob)
        grpBioData.Controls.Add(lblEmail)
        grpBioData.Controls.Add(lblReligion)
        grpBioData.Controls.Add(lblPhoneNum)
        grpBioData.Controls.Add(lblJob)
        grpBioData.Controls.Add(lblBirthDate)
        grpBioData.Controls.Add(txtEmail)
        grpBioData.Controls.Add(txtPhoneNum)
        grpBioData.Controls.Add(txtSurname)
        grpBioData.Controls.Add(lblSurname)
        grpBioData.Controls.Add(txtOtherName)
        grpBioData.Controls.Add(txtFirstName)
        grpBioData.Controls.Add(lblOtherName)
        grpBioData.Controls.Add(lblFirstName)
        grpBioData.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpBioData.ImeMode = ImeMode.NoControl
        grpBioData.Location = New Point(12, 12)
        grpBioData.Name = "grpBioData"
        grpBioData.Size = New Size(1086, 235)
        grpBioData.TabIndex = 15
        grpBioData.TabStop = False
        grpBioData.Text = "New Record"
        ToolTip1.SetToolTip(grpBioData, "Enter information to create a new client record")
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(132, 164)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(141, 27)
        DateTimePicker1.TabIndex = 6
        ' 
        ' rbtnFemale
        ' 
        rbtnFemale.AutoSize = True
        rbtnFemale.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        rbtnFemale.Location = New Point(729, 32)
        rbtnFemale.Name = "rbtnFemale"
        rbtnFemale.Size = New Size(78, 24)
        rbtnFemale.TabIndex = 8
        rbtnFemale.TabStop = True
        rbtnFemale.Text = "Female"
        rbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' rbtnMale
        ' 
        rbtnMale.AutoSize = True
        rbtnMale.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        rbtnMale.Location = New Point(660, 32)
        rbtnMale.Name = "rbtnMale"
        rbtnMale.Size = New Size(63, 24)
        rbtnMale.TabIndex = 7
        rbtnMale.TabStop = True
        rbtnMale.Text = "Male"
        rbtnMale.UseVisualStyleBackColor = True
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(539, 36)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(66, 20)
        lblGender.TabIndex = 22
        lblGender.Text = "*Gender:"
        ' 
        ' txtCardNum
        ' 
        txtCardNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCardNum.Location = New Point(132, 29)
        txtCardNum.Name = "txtCardNum"
        txtCardNum.Size = New Size(82, 27)
        txtCardNum.TabIndex = 1
        ' 
        ' txtReligion
        ' 
        txtReligion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtReligion.Location = New Point(660, 161)
        txtReligion.Name = "txtReligion"
        txtReligion.Size = New Size(257, 27)
        txtReligion.TabIndex = 12
        ' 
        ' lblCardNum
        ' 
        lblCardNum.AutoSize = True
        lblCardNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblCardNum.Location = New Point(25, 32)
        lblCardNum.Name = "lblCardNum"
        lblCardNum.Size = New Size(107, 20)
        lblCardNum.TabIndex = 21
        lblCardNum.Text = "*Card Number:"
        ' 
        ' lblReligion
        ' 
        lblReligion.AutoSize = True
        lblReligion.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblReligion.Location = New Point(542, 164)
        lblReligion.Name = "lblReligion"
        lblReligion.Size = New Size(67, 20)
        lblReligion.TabIndex = 19
        lblReligion.Text = "Religion:"
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.AutoSize = True
        lblBirthDate.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblBirthDate.Location = New Point(25, 169)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(103, 20)
        lblBirthDate.TabIndex = 17
        lblBirthDate.Text = "*Date of Birth:"
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSurname.Location = New Point(132, 95)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(257, 27)
        txtSurname.TabIndex = 3
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblSurname.Location = New Point(25, 98)
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
        btnExit.Location = New Point(957, 253)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(141, 45)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        ToolTip1.SetToolTip(btnExit, "Exit to client centre")
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnSaveAcc
        ' 
        btnSaveAcc.BackColor = SystemColors.GradientInactiveCaption
        btnSaveAcc.Enabled = False
        btnSaveAcc.FlatStyle = FlatStyle.Flat
        btnSaveAcc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSaveAcc.Image = CType(resources.GetObject("btnSaveAcc.Image"), Image)
        btnSaveAcc.ImageAlign = ContentAlignment.MiddleLeft
        btnSaveAcc.Location = New Point(810, 253)
        btnSaveAcc.Name = "btnSaveAcc"
        btnSaveAcc.Size = New Size(141, 45)
        btnSaveAcc.TabIndex = 13
        btnSaveAcc.Text = "Save"
        ToolTip1.SetToolTip(btnSaveAcc, "Save info")
        btnSaveAcc.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(361, 20)
        Label1.TabIndex = 16
        Label1.Text = "*These entries cannot be altered once they are saved!"
        ' 
        ' frmNewClient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(grpBioData)
        Controls.Add(btnSaveAcc)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmNewClient"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create Client Record"
        grpBioData.ResumeLayout(False)
        grpBioData.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents btnSaveAcc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents txtReligion As TextBox
    Friend WithEvents lblReligion As Label
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents lblCardNum As Label
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents lblGender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
End Class
