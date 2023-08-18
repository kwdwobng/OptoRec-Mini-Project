<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAccEdit))
        lblClinic = New Label()
        lblLocation = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblClinician = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtClinic = New TextBox()
        txtLocation = New TextBox()
        txtClinician = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtUserName = New TextBox()
        txtPassword1 = New TextBox()
        grpAccInfo = New GroupBox()
        txtOwner = New TextBox()
        lblOwner = New Label()
        grpAccSec = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        txtPassword2 = New TextBox()
        lblPassword2 = New Label()
        btnExit = New Button()
        btnUpdateAcc = New Button()
        ToolTip1 = New ToolTip(components)
        btnDelete = New Button()
        grpAccInfo.SuspendLayout()
        grpAccSec.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblClinic
        ' 
        lblClinic.AutoSize = True
        lblClinic.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblClinic.Location = New Point(32, 65)
        lblClinic.Name = "lblClinic"
        lblClinic.Size = New Size(92, 20)
        lblClinic.TabIndex = 0
        lblClinic.Text = "Clinic Name:"
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblLocation.Location = New Point(32, 137)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(69, 20)
        lblLocation.TabIndex = 1
        lblLocation.Text = "Location:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(32, 244)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(112, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "E-mail Address:"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhoneNum.Location = New Point(32, 209)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(111, 20)
        lblPhoneNum.TabIndex = 3
        lblPhoneNum.Text = "Phone Number:"
        ' 
        ' lblClinician
        ' 
        lblClinician.AutoSize = True
        lblClinician.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblClinician.Location = New Point(32, 173)
        lblClinician.Name = "lblClinician"
        lblClinician.Size = New Size(68, 20)
        lblClinician.TabIndex = 4
        lblClinician.Text = "Clinician:"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.Location = New Point(32, 29)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(78, 20)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(24, 37)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(128, 20)
        lblPassword.TabIndex = 6
        lblPassword.Text = "General Password:"
        ToolTip1.SetToolTip(lblPassword, "General account password. for all features" & vbCrLf & "except entering or modifying clinical data.")
        ' 
        ' txtClinic
        ' 
        txtClinic.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtClinic.Location = New Point(150, 61)
        txtClinic.Name = "txtClinic"
        txtClinic.Size = New Size(395, 27)
        txtClinic.TabIndex = 7
        ' 
        ' txtLocation
        ' 
        txtLocation.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtLocation.Location = New Point(150, 133)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(395, 27)
        txtLocation.TabIndex = 9
        ' 
        ' txtClinician
        ' 
        txtClinician.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtClinician.Location = New Point(150, 169)
        txtClinician.Name = "txtClinician"
        txtClinician.Size = New Size(395, 27)
        txtClinician.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(150, 241)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(395, 27)
        txtEmail.TabIndex = 12
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNum.Location = New Point(150, 205)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(395, 27)
        txtPhoneNum.TabIndex = 11
        ' 
        ' txtUserName
        ' 
        txtUserName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUserName.Location = New Point(150, 25)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(182, 27)
        txtUserName.TabIndex = 6
        ' 
        ' txtPassword1
        ' 
        txtPassword1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword1.Location = New Point(154, 34)
        txtPassword1.Name = "txtPassword1"
        txtPassword1.Size = New Size(182, 27)
        txtPassword1.TabIndex = 14
        ToolTip1.SetToolTip(txtPassword1, "Enter password to access user account")
        txtPassword1.UseSystemPasswordChar = True
        ' 
        ' grpAccInfo
        ' 
        grpAccInfo.Controls.Add(txtOwner)
        grpAccInfo.Controls.Add(lblOwner)
        grpAccInfo.Controls.Add(txtPhoneNum)
        grpAccInfo.Controls.Add(txtUserName)
        grpAccInfo.Controls.Add(txtEmail)
        grpAccInfo.Controls.Add(txtClinician)
        grpAccInfo.Controls.Add(lblUsername)
        grpAccInfo.Controls.Add(txtLocation)
        grpAccInfo.Controls.Add(txtClinic)
        grpAccInfo.Controls.Add(lblClinician)
        grpAccInfo.Controls.Add(lblPhoneNum)
        grpAccInfo.Controls.Add(lblEmail)
        grpAccInfo.Controls.Add(lblLocation)
        grpAccInfo.Controls.Add(lblClinic)
        grpAccInfo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpAccInfo.Location = New Point(12, 12)
        grpAccInfo.Name = "grpAccInfo"
        grpAccInfo.Size = New Size(579, 301)
        grpAccInfo.TabIndex = 15
        grpAccInfo.TabStop = False
        grpAccInfo.Text = "Account Information"
        ' 
        ' txtOwner
        ' 
        txtOwner.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOwner.Location = New Point(150, 97)
        txtOwner.Name = "txtOwner"
        txtOwner.Size = New Size(395, 27)
        txtOwner.TabIndex = 8
        ' 
        ' lblOwner
        ' 
        lblOwner.AutoSize = True
        lblOwner.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblOwner.Location = New Point(32, 101)
        lblOwner.Name = "lblOwner"
        lblOwner.Size = New Size(79, 20)
        lblOwner.TabIndex = 12
        lblOwner.Text = "Proprietor:"
        ' 
        ' grpAccSec
        ' 
        grpAccSec.Controls.Add(CheckBox2)
        grpAccSec.Controls.Add(CheckBox1)
        grpAccSec.Controls.Add(txtPassword2)
        grpAccSec.Controls.Add(lblPassword2)
        grpAccSec.Controls.Add(txtPassword1)
        grpAccSec.Controls.Add(lblPassword)
        grpAccSec.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpAccSec.Location = New Point(597, 12)
        grpAccSec.Name = "grpAccSec"
        grpAccSec.Size = New Size(449, 301)
        grpAccSec.TabIndex = 16
        grpAccSec.TabStop = False
        grpAccSec.Text = "Account Security"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(342, 78)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(67, 24)
        CheckBox2.TabIndex = 17
        CheckBox2.Text = "Show"
        ToolTip1.SetToolTip(CheckBox2, "Show clinical records password")
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(342, 36)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 24)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Show"
        ToolTip1.SetToolTip(CheckBox1, "Show administrative password")
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtPassword2
        ' 
        txtPassword2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword2.Location = New Point(154, 78)
        txtPassword2.Name = "txtPassword2"
        txtPassword2.Size = New Size(182, 27)
        txtPassword2.TabIndex = 16
        ToolTip1.SetToolTip(txtPassword2, "Enter password to access all client clinical records in the user account")
        txtPassword2.UseSystemPasswordChar = True
        ' 
        ' lblPassword2
        ' 
        lblPassword2.AutoSize = True
        lblPassword2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword2.Location = New Point(24, 81)
        lblPassword2.Name = "lblPassword2"
        lblPassword2.Size = New Size(125, 20)
        lblPassword2.TabIndex = 18
        lblPassword2.Text = "Clinical Password:"
        ToolTip1.SetToolTip(lblPassword2, "Clinical password for entering and modifying clinical data.")
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Info
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = SystemColors.ControlText
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(905, 370)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(141, 45)
        btnExit.TabIndex = 20
        btnExit.Text = "Exit"
        ToolTip1.SetToolTip(btnExit, "Exit form")
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateAcc
        ' 
        btnUpdateAcc.BackColor = SystemColors.GradientInactiveCaption
        btnUpdateAcc.Enabled = False
        btnUpdateAcc.FlatStyle = FlatStyle.Flat
        btnUpdateAcc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateAcc.Image = CType(resources.GetObject("btnUpdateAcc.Image"), Image)
        btnUpdateAcc.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdateAcc.Location = New Point(758, 319)
        btnUpdateAcc.Name = "btnUpdateAcc"
        btnUpdateAcc.Size = New Size(141, 45)
        btnUpdateAcc.TabIndex = 19
        btnUpdateAcc.Text = "Update"
        ToolTip1.SetToolTip(btnUpdateAcc, "Update info")
        btnUpdateAcc.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Info
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(905, 319)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(141, 45)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete"
        ToolTip1.SetToolTip(btnDelete, "Delete account")
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' frmAccEdit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(btnDelete)
        Controls.Add(grpAccSec)
        Controls.Add(btnExit)
        Controls.Add(grpAccInfo)
        Controls.Add(btnUpdateAcc)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmAccEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Account Setup"
        grpAccInfo.ResumeLayout(False)
        grpAccInfo.PerformLayout()
        grpAccSec.ResumeLayout(False)
        grpAccSec.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblClinic As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblClinician As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtClinic As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtClinician As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents grpAccInfo As GroupBox
    Friend WithEvents grpAccSec As GroupBox
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtOwner As TextBox
    Friend WithEvents lblOwner As Label
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnDelete As Button
End Class
