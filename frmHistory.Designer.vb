<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtPC = New TextBox()
        txtHPC = New TextBox()
        txtPOH = New TextBox()
        txtPMH = New TextBox()
        txtDH = New TextBox()
        txtAllerg = New TextBox()
        txtSH = New TextBox()
        txtFOH = New TextBox()
        txtFMH = New TextBox()
        btnPrev = New Button()
        GroupBox1 = New GroupBox()
        chkGrit = New CheckBox()
        chkBurn = New CheckBox()
        chkItch = New CheckBox()
        chkRed = New CheckBox()
        chkDiplo = New CheckBox()
        chkTear = New CheckBox()
        chkDisch = New CheckBox()
        chkPhoto = New CheckBox()
        chkPain = New CheckBox()
        chkPrick = New CheckBox()
        chkOcc = New CheckBox()
        chkTemp = New CheckBox()
        chkFlash = New CheckBox()
        chkFront = New CheckBox()
        chkHalo = New CheckBox()
        chkFloat = New CheckBox()
        btnUpdateAcc = New Button()
        btnNext = New Button()
        txtDdx = New TextBox()
        lblDdx = New Label()
        ToolTip1 = New ToolTip(components)
        txtBioTag = New TextBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(16, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "PC/CC:"
        ToolTip1.SetToolTip(Label1, "Presenting Complaint or Chief Complaint")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 1
        Label2.Text = "HPC:"
        ToolTip1.SetToolTip(Label2, "History of Presenting Complaint")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(17, 271)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 2
        Label3.Text = "ODQ:"
        ToolTip1.SetToolTip(Label3, "On Direct Questiong")
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 586)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 3
        Label4.Text = "POH:"
        ToolTip1.SetToolTip(Label4, "Past Ocular History")
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(8, 704)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 4
        Label5.Text = "PMH+PSH:"
        ToolTip1.SetToolTip(Label5, "Past Medical History and Past Systemic History")
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(614, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 20)
        Label6.TabIndex = 5
        Label6.Text = "DH:"
        ToolTip1.SetToolTip(Label6, "Drug History")
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(614, 150)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 20)
        Label7.TabIndex = 6
        Label7.Text = "Allergies:"
        ToolTip1.SetToolTip(Label7, "Allergies")
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(617, 207)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 20)
        Label8.TabIndex = 7
        Label8.Text = "SH:"
        ToolTip1.SetToolTip(Label8, "Social History")
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(617, 328)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 20)
        Label9.TabIndex = 8
        Label9.Text = "FOH:"
        ToolTip1.SetToolTip(Label9, "Family Ocular History")
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(616, 445)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 20)
        Label10.TabIndex = 9
        Label10.Text = "FMH:"
        ToolTip1.SetToolTip(Label10, "Family Medical History")
        ' 
        ' txtPC
        ' 
        txtPC.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPC.Location = New Point(94, 28)
        txtPC.Multiline = True
        txtPC.Name = "txtPC"
        txtPC.Size = New Size(501, 111)
        txtPC.TabIndex = 2
        ' 
        ' txtHPC
        ' 
        txtHPC.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtHPC.Location = New Point(95, 145)
        txtHPC.Multiline = True
        txtHPC.Name = "txtHPC"
        txtHPC.PlaceholderText = "Location, Onset, Duration, Frequency, Type, Severity, Exacerbation, Alleviation"
        txtHPC.Size = New Size(501, 111)
        txtHPC.TabIndex = 3
        ' 
        ' txtPOH
        ' 
        txtPOH.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPOH.Location = New Point(94, 578)
        txtPOH.Multiline = True
        txtPOH.Name = "txtPOH"
        txtPOH.Size = New Size(501, 111)
        txtPOH.TabIndex = 21
        ' 
        ' txtPMH
        ' 
        txtPMH.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPMH.Location = New Point(95, 695)
        txtPMH.Multiline = True
        txtPMH.Name = "txtPMH"
        txtPMH.Size = New Size(501, 111)
        txtPMH.TabIndex = 22
        ' 
        ' txtDH
        ' 
        txtDH.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtDH.Location = New Point(707, 33)
        txtDH.Multiline = True
        txtDH.Name = "txtDH"
        txtDH.Size = New Size(501, 106)
        txtDH.TabIndex = 23
        ' 
        ' txtAllerg
        ' 
        txtAllerg.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtAllerg.Location = New Point(707, 145)
        txtAllerg.Multiline = True
        txtAllerg.Name = "txtAllerg"
        txtAllerg.Size = New Size(502, 55)
        txtAllerg.TabIndex = 24
        ' 
        ' txtSH
        ' 
        txtSH.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSH.Location = New Point(707, 206)
        txtSH.Multiline = True
        txtSH.Name = "txtSH"
        txtSH.Size = New Size(501, 111)
        txtSH.TabIndex = 25
        ' 
        ' txtFOH
        ' 
        txtFOH.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtFOH.Location = New Point(707, 323)
        txtFOH.Multiline = True
        txtFOH.Name = "txtFOH"
        txtFOH.Size = New Size(501, 111)
        txtFOH.TabIndex = 26
        ' 
        ' txtFMH
        ' 
        txtFMH.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtFMH.Location = New Point(706, 440)
        txtFMH.Multiline = True
        txtFMH.Name = "txtFMH"
        txtFMH.Size = New Size(501, 111)
        txtFMH.TabIndex = 27
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = SystemColors.Control
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrev.Image = My.Resources.Resources.left_arrow
        btnPrev.Location = New Point(1105, 21)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(68, 45)
        btnPrev.TabIndex = 30
        ToolTip1.SetToolTip(btnPrev, "Previous form")
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkGrit)
        GroupBox1.Controls.Add(chkBurn)
        GroupBox1.Controls.Add(chkItch)
        GroupBox1.Controls.Add(chkRed)
        GroupBox1.Controls.Add(chkDiplo)
        GroupBox1.Controls.Add(chkTear)
        GroupBox1.Controls.Add(chkDisch)
        GroupBox1.Controls.Add(chkPhoto)
        GroupBox1.Controls.Add(chkPain)
        GroupBox1.Controls.Add(chkPrick)
        GroupBox1.Controls.Add(chkOcc)
        GroupBox1.Controls.Add(chkTemp)
        GroupBox1.Controls.Add(chkFlash)
        GroupBox1.Controls.Add(chkFront)
        GroupBox1.Controls.Add(chkHalo)
        GroupBox1.Controls.Add(chkFloat)
        GroupBox1.Location = New Point(95, 259)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(501, 313)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        ' 
        ' chkGrit
        ' 
        chkGrit.AutoSize = True
        chkGrit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkGrit.Location = New Point(340, 214)
        chkGrit.Name = "chkGrit"
        chkGrit.Size = New Size(95, 44)
        chkGrit.TabIndex = 19
        chkGrit.Text = "Gritty" & vbCrLf & "Sensation"
        chkGrit.UseVisualStyleBackColor = True
        ' 
        ' chkBurn
        ' 
        chkBurn.AutoSize = True
        chkBurn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkBurn.Location = New Point(186, 214)
        chkBurn.Name = "chkBurn"
        chkBurn.Size = New Size(95, 44)
        chkBurn.TabIndex = 18
        chkBurn.Text = "Burning" & vbCrLf & "Sensation"
        chkBurn.UseVisualStyleBackColor = True
        ' 
        ' chkItch
        ' 
        chkItch.AutoSize = True
        chkItch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkItch.Location = New Point(29, 227)
        chkItch.Name = "chkItch"
        chkItch.Size = New Size(87, 24)
        chkItch.TabIndex = 17
        chkItch.Text = "Itchiness"
        chkItch.UseVisualStyleBackColor = True
        ' 
        ' chkRed
        ' 
        chkRed.AutoSize = True
        chkRed.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkRed.Location = New Point(29, 274)
        chkRed.Name = "chkRed"
        chkRed.Size = New Size(85, 24)
        chkRed.TabIndex = 20
        chkRed.Text = "Redness"
        chkRed.UseVisualStyleBackColor = True
        ' 
        ' chkDiplo
        ' 
        chkDiplo.AutoSize = True
        chkDiplo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkDiplo.Location = New Point(339, 175)
        chkDiplo.Name = "chkDiplo"
        chkDiplo.Size = New Size(89, 24)
        chkDiplo.TabIndex = 15
        chkDiplo.Text = "Diplopia"
        chkDiplo.UseVisualStyleBackColor = True
        ' 
        ' chkTear
        ' 
        chkTear.AutoSize = True
        chkTear.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkTear.Location = New Point(185, 175)
        chkTear.Name = "chkTear"
        chkTear.Size = New Size(80, 24)
        chkTear.TabIndex = 14
        chkTear.Text = "Tearing"
        chkTear.UseVisualStyleBackColor = True
        ' 
        ' chkDisch
        ' 
        chkDisch.AutoSize = True
        chkDisch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkDisch.Location = New Point(29, 176)
        chkDisch.Name = "chkDisch"
        chkDisch.Size = New Size(97, 24)
        chkDisch.TabIndex = 13
        chkDisch.Text = "Discharge"
        chkDisch.UseVisualStyleBackColor = True
        ' 
        ' chkPhoto
        ' 
        chkPhoto.AutoSize = True
        chkPhoto.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkPhoto.Location = New Point(185, 84)
        chkPhoto.Name = "chkPhoto"
        chkPhoto.Size = New Size(117, 24)
        chkPhoto.TabIndex = 8
        chkPhoto.Text = "Photophobia"
        chkPhoto.UseVisualStyleBackColor = True
        ' 
        ' chkPain
        ' 
        chkPain.AutoSize = True
        chkPain.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkPain.Location = New Point(29, 84)
        chkPain.Name = "chkPain"
        chkPain.Size = New Size(58, 24)
        chkPain.TabIndex = 7
        chkPain.Text = "Pain"
        chkPain.UseVisualStyleBackColor = True
        ' 
        ' chkPrick
        ' 
        chkPrick.AutoSize = True
        chkPrick.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkPrick.Location = New Point(339, 119)
        chkPrick.Name = "chkPrick"
        chkPrick.Size = New Size(95, 44)
        chkPrick.TabIndex = 12
        chkPrick.Text = "Prickly" & vbCrLf & "Sensation"
        chkPrick.UseVisualStyleBackColor = True
        ' 
        ' chkOcc
        ' 
        chkOcc.AutoSize = True
        chkOcc.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkOcc.Location = New Point(339, 26)
        chkOcc.Name = "chkOcc"
        chkOcc.Size = New Size(98, 44)
        chkOcc.TabIndex = 6
        chkOcc.Text = "Occipital" & vbCrLf & "Headache"
        chkOcc.UseVisualStyleBackColor = True
        ' 
        ' chkTemp
        ' 
        chkTemp.AutoSize = True
        chkTemp.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkTemp.Location = New Point(185, 26)
        chkTemp.Name = "chkTemp"
        chkTemp.Size = New Size(98, 44)
        chkTemp.TabIndex = 5
        chkTemp.Text = "Temporal" & vbCrLf & "Headache"
        chkTemp.UseVisualStyleBackColor = True
        ' 
        ' chkFlash
        ' 
        chkFlash.AutoSize = True
        chkFlash.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkFlash.Location = New Point(185, 119)
        chkFlash.Name = "chkFlash"
        chkFlash.Size = New Size(84, 44)
        chkFlash.TabIndex = 11
        chkFlash.Text = "Flashes" & vbCrLf & "Of Light"
        chkFlash.UseVisualStyleBackColor = True
        ' 
        ' chkFront
        ' 
        chkFront.AutoSize = True
        chkFront.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkFront.Location = New Point(29, 26)
        chkFront.Name = "chkFront"
        chkFront.Size = New Size(98, 44)
        chkFront.TabIndex = 4
        chkFront.Text = "Frontal" & vbCrLf & "Headache"
        chkFront.UseVisualStyleBackColor = True
        ' 
        ' chkHalo
        ' 
        chkHalo.AutoSize = True
        chkHalo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkHalo.Location = New Point(339, 84)
        chkHalo.Name = "chkHalo"
        chkHalo.Size = New Size(77, 24)
        chkHalo.TabIndex = 9
        chkHalo.Text = "Haloes"
        chkHalo.UseVisualStyleBackColor = True
        ' 
        ' chkFloat
        ' 
        chkFloat.AutoSize = True
        chkFloat.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chkFloat.Location = New Point(29, 132)
        chkFloat.Name = "chkFloat"
        chkFloat.Size = New Size(83, 24)
        chkFloat.TabIndex = 10
        chkFloat.Text = "Floaters"
        chkFloat.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateAcc
        ' 
        btnUpdateAcc.BackColor = SystemColors.GradientInactiveCaption
        btnUpdateAcc.FlatStyle = FlatStyle.Flat
        btnUpdateAcc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateAcc.Image = CType(resources.GetObject("btnUpdateAcc.Image"), Image)
        btnUpdateAcc.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdateAcc.Location = New Point(1106, 909)
        btnUpdateAcc.Name = "btnUpdateAcc"
        btnUpdateAcc.Size = New Size(141, 45)
        btnUpdateAcc.TabIndex = 29
        btnUpdateAcc.Text = "Save"
        ToolTip1.SetToolTip(btnUpdateAcc, "Save info")
        btnUpdateAcc.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.Control
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Image = My.Resources.Resources.right_arrow
        btnNext.Location = New Point(1179, 21)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(68, 45)
        btnNext.TabIndex = 31
        ToolTip1.SetToolTip(btnNext, "Next form")
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' txtDdx
        ' 
        txtDdx.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtDdx.Location = New Point(706, 557)
        txtDdx.Multiline = True
        txtDdx.Name = "txtDdx"
        txtDdx.Size = New Size(501, 55)
        txtDdx.TabIndex = 28
        ' 
        ' lblDdx
        ' 
        lblDdx.AutoSize = True
        lblDdx.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDdx.Location = New Point(616, 562)
        lblDdx.Name = "lblDdx"
        lblDdx.Size = New Size(84, 40)
        lblDdx.TabIndex = 29
        lblDdx.Text = "Differential" & vbCrLf & "Diagnosis:"
        ToolTip1.SetToolTip(lblDdx, "Differential Diagnosis")
        ' 
        ' txtBioTag
        ' 
        txtBioTag.BackColor = Color.WhiteSmoke
        txtBioTag.BorderStyle = BorderStyle.FixedSingle
        txtBioTag.Location = New Point(15, 21)
        txtBioTag.Name = "txtBioTag"
        txtBioTag.ReadOnly = True
        txtBioTag.Size = New Size(406, 27)
        txtBioTag.TabIndex = 32
        txtBioTag.TabStop = False
        ToolTip1.SetToolTip(txtBioTag, "Present client")
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtDdx)
        GroupBox2.Controls.Add(lblDdx)
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Controls.Add(txtFMH)
        GroupBox2.Controls.Add(txtFOH)
        GroupBox2.Controls.Add(txtSH)
        GroupBox2.Controls.Add(txtAllerg)
        GroupBox2.Controls.Add(txtDH)
        GroupBox2.Controls.Add(txtPMH)
        GroupBox2.Controls.Add(txtPOH)
        GroupBox2.Controls.Add(txtHPC)
        GroupBox2.Controls.Add(txtPC)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(15, 72)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1232, 831)
        GroupBox2.TabIndex = 30
        GroupBox2.TabStop = False
        ' 
        ' frmHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 1026)
        Controls.Add(txtBioTag)
        Controls.Add(GroupBox2)
        Controls.Add(btnNext)
        Controls.Add(btnUpdateAcc)
        Controls.Add(btnPrev)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "History"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPC As TextBox
    Friend WithEvents txtHPC As TextBox
    Friend WithEvents txtPOH As TextBox
    Friend WithEvents txtPMH As TextBox
    Friend WithEvents txtDH As TextBox
    Friend WithEvents txtAllerg As TextBox
    Friend WithEvents txtSH As TextBox
    Friend WithEvents txtFOH As TextBox
    Friend WithEvents txtFMH As TextBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkPhoto As CheckBox
    Friend WithEvents chkPain As CheckBox
    Friend WithEvents chkOcc As CheckBox
    Friend WithEvents chkTemp As CheckBox
    Friend WithEvents chkFront As CheckBox
    Friend WithEvents chkHalo As CheckBox
    Friend WithEvents chkFloat As CheckBox
    Friend WithEvents chkFlash As CheckBox
    Friend WithEvents chkPrick As CheckBox
    Friend WithEvents chkDisch As CheckBox
    Friend WithEvents chkDiplo As CheckBox
    Friend WithEvents chkTear As CheckBox
    Friend WithEvents chkGrit As CheckBox
    Friend WithEvents chkBurn As CheckBox
    Friend WithEvents chkItch As CheckBox
    Friend WithEvents chkRed As CheckBox
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtDdx As TextBox
    Friend WithEvents lblDdx As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBioTag As TextBox
End Class
