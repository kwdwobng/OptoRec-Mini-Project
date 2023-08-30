<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVA
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
        lblVA = New Label()
        lblOs = New Label()
        lblOd = New Label()
        lblUnaid = New Label()
        lblAid = New Label()
        lblPlus1 = New Label()
        lblPhTest = New Label()
        grpVA = New GroupBox()
        txtOsPin = New TextBox()
        txtOsPlus = New TextBox()
        txtOsAid = New TextBox()
        txtOsUnAid = New TextBox()
        txtOdPin = New TextBox()
        txtOdPlus = New TextBox()
        txtOdAid = New TextBox()
        txtOdUnAid = New TextBox()
        lblLE = New Label()
        lblRE = New Label()
        txtLmono = New TextBox()
        lblSlash = New Label()
        txtRmono = New TextBox()
        lblMonoPD = New Label()
        txtPdIn = New TextBox()
        txtPdOut = New TextBox()
        lblPD = New Label()
        btnNext = New Button()
        ToolTip1 = New ToolTip(components)
        btnPrev = New Button()
        txtBioTag = New TextBox()
        GroupBox1 = New GroupBox()
        grpVA.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblVA
        ' 
        lblVA.AutoSize = True
        lblVA.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblVA.Location = New Point(6, 36)
        lblVA.Name = "lblVA"
        lblVA.Size = New Size(27, 20)
        lblVA.TabIndex = 0
        lblVA.Text = "VA"
        ' 
        ' lblOs
        ' 
        lblOs.AutoSize = True
        lblOs.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblOs.Location = New Point(6, 109)
        lblOs.Name = "lblOs"
        lblOs.Size = New Size(28, 20)
        lblOs.TabIndex = 1
        lblOs.Text = "OS"
        ' 
        ' lblOd
        ' 
        lblOd.AutoSize = True
        lblOd.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblOd.Location = New Point(6, 70)
        lblOd.Name = "lblOd"
        lblOd.Size = New Size(31, 20)
        lblOd.TabIndex = 2
        lblOd.Text = "OD"
        ' 
        ' lblUnaid
        ' 
        lblUnaid.AutoSize = True
        lblUnaid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblUnaid.Location = New Point(39, 36)
        lblUnaid.Name = "lblUnaid"
        lblUnaid.Size = New Size(65, 20)
        lblUnaid.TabIndex = 3
        lblUnaid.Text = "Unaided"
        ' 
        ' lblAid
        ' 
        lblAid.AutoSize = True
        lblAid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblAid.Location = New Point(120, 36)
        lblAid.Name = "lblAid"
        lblAid.Size = New Size(49, 20)
        lblAid.TabIndex = 4
        lblAid.Text = "Aided"
        ' 
        ' lblPlus1
        ' 
        lblPlus1.AutoSize = True
        lblPlus1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPlus1.Location = New Point(201, 23)
        lblPlus1.Name = "lblPlus1"
        lblPlus1.Size = New Size(57, 40)
        lblPlus1.TabIndex = 5
        lblPlus1.Text = "+1 Blur" & vbCrLf & "Test"
        ' 
        ' lblPhTest
        ' 
        lblPhTest.AutoSize = True
        lblPhTest.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhTest.Location = New Point(282, 36)
        lblPhTest.Name = "lblPhTest"
        lblPhTest.Size = New Size(58, 20)
        lblPhTest.TabIndex = 6
        lblPhTest.Text = "PH Test"
        ' 
        ' grpVA
        ' 
        grpVA.Controls.Add(txtOsPin)
        grpVA.Controls.Add(lblPlus1)
        grpVA.Controls.Add(txtOsPlus)
        grpVA.Controls.Add(lblAid)
        grpVA.Controls.Add(txtOsAid)
        grpVA.Controls.Add(lblPhTest)
        grpVA.Controls.Add(txtOsUnAid)
        grpVA.Controls.Add(lblUnaid)
        grpVA.Controls.Add(txtOdPin)
        grpVA.Controls.Add(lblOd)
        grpVA.Controls.Add(txtOdPlus)
        grpVA.Controls.Add(lblOs)
        grpVA.Controls.Add(txtOdAid)
        grpVA.Controls.Add(lblVA)
        grpVA.Controls.Add(txtOdUnAid)
        grpVA.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        grpVA.Location = New Point(18, 144)
        grpVA.Name = "grpVA"
        grpVA.Size = New Size(588, 165)
        grpVA.TabIndex = 15
        grpVA.TabStop = False
        ' 
        ' txtOsPin
        ' 
        txtOsPin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOsPin.Location = New Point(282, 105)
        txtOsPin.Name = "txtOsPin"
        txtOsPin.Size = New Size(65, 27)
        txtOsPin.TabIndex = 12
        ' 
        ' txtOsPlus
        ' 
        txtOsPlus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOsPlus.Location = New Point(201, 105)
        txtOsPlus.Name = "txtOsPlus"
        txtOsPlus.Size = New Size(65, 27)
        txtOsPlus.TabIndex = 11
        ' 
        ' txtOsAid
        ' 
        txtOsAid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOsAid.Location = New Point(120, 106)
        txtOsAid.Name = "txtOsAid"
        txtOsAid.Size = New Size(65, 27)
        txtOsAid.TabIndex = 10
        ' 
        ' txtOsUnAid
        ' 
        txtOsUnAid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOsUnAid.Location = New Point(39, 106)
        txtOsUnAid.Name = "txtOsUnAid"
        txtOsUnAid.Size = New Size(65, 27)
        txtOsUnAid.TabIndex = 9
        ' 
        ' txtOdPin
        ' 
        txtOdPin.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOdPin.Location = New Point(282, 66)
        txtOdPin.Name = "txtOdPin"
        txtOdPin.Size = New Size(65, 27)
        txtOdPin.TabIndex = 8
        ' 
        ' txtOdPlus
        ' 
        txtOdPlus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOdPlus.Location = New Point(201, 66)
        txtOdPlus.Name = "txtOdPlus"
        txtOdPlus.Size = New Size(65, 27)
        txtOdPlus.TabIndex = 7
        ' 
        ' txtOdAid
        ' 
        txtOdAid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOdAid.Location = New Point(120, 67)
        txtOdAid.Name = "txtOdAid"
        txtOdAid.Size = New Size(65, 27)
        txtOdAid.TabIndex = 6
        ' 
        ' txtOdUnAid
        ' 
        txtOdUnAid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOdUnAid.Location = New Point(39, 67)
        txtOdUnAid.Name = "txtOdUnAid"
        txtOdUnAid.Size = New Size(65, 27)
        txtOdUnAid.TabIndex = 5
        ' 
        ' lblLE
        ' 
        lblLE.AutoSize = True
        lblLE.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblLE.Location = New Point(479, 28)
        lblLE.Name = "lblLE"
        lblLE.Size = New Size(24, 20)
        lblLE.TabIndex = 16
        lblLE.Text = "LE"
        ' 
        ' lblRE
        ' 
        lblRE.AutoSize = True
        lblRE.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblRE.Location = New Point(393, 28)
        lblRE.Name = "lblRE"
        lblRE.Size = New Size(26, 20)
        lblRE.TabIndex = 15
        lblRE.Text = "RE"
        ' 
        ' txtLmono
        ' 
        txtLmono.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtLmono.Location = New Point(509, 23)
        txtLmono.Name = "txtLmono"
        txtLmono.Size = New Size(51, 27)
        txtLmono.TabIndex = 4
        ' 
        ' lblSlash
        ' 
        lblSlash.AutoSize = True
        lblSlash.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblSlash.Location = New Point(138, 28)
        lblSlash.Name = "lblSlash"
        lblSlash.Size = New Size(15, 20)
        lblSlash.TabIndex = 14
        lblSlash.Text = "/"
        ' 
        ' txtRmono
        ' 
        txtRmono.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtRmono.Location = New Point(425, 23)
        txtRmono.Name = "txtRmono"
        txtRmono.Size = New Size(51, 27)
        txtRmono.TabIndex = 3
        ' 
        ' lblMonoPD
        ' 
        lblMonoPD.AutoSize = True
        lblMonoPD.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonoPD.Location = New Point(241, 28)
        lblMonoPD.Name = "lblMonoPD"
        lblMonoPD.Size = New Size(146, 20)
        lblMonoPD.TabIndex = 1
        lblMonoPD.Text = "Monocular PD (mm):"
        ' 
        ' txtPdIn
        ' 
        txtPdIn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPdIn.Location = New Point(155, 25)
        txtPdIn.Name = "txtPdIn"
        txtPdIn.Size = New Size(51, 27)
        txtPdIn.TabIndex = 2
        ' 
        ' txtPdOut
        ' 
        txtPdOut.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPdOut.Location = New Point(83, 25)
        txtPdOut.Name = "txtPdOut"
        txtPdOut.Size = New Size(51, 27)
        txtPdOut.TabIndex = 1
        ' 
        ' lblPD
        ' 
        lblPD.AutoSize = True
        lblPD.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPD.Location = New Point(6, 28)
        lblPD.Name = "lblPD"
        lblPD.Size = New Size(71, 20)
        lblPD.TabIndex = 2
        lblPD.Text = "PD (mm):"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.Control
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Image = My.Resources.Resources.right_arrow
        btnNext.Location = New Point(529, 21)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(68, 45)
        btnNext.TabIndex = 15
        ToolTip1.SetToolTip(btnNext, "Next form")
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = SystemColors.Control
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrev.Image = My.Resources.Resources.left_arrow
        btnPrev.Location = New Point(455, 21)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(68, 45)
        btnPrev.TabIndex = 14
        ToolTip1.SetToolTip(btnPrev, "Previous form")
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' txtBioTag
        ' 
        txtBioTag.BackColor = Color.WhiteSmoke
        txtBioTag.BorderStyle = BorderStyle.FixedSingle
        txtBioTag.Location = New Point(18, 21)
        txtBioTag.Name = "txtBioTag"
        txtBioTag.ReadOnly = True
        txtBioTag.Size = New Size(406, 27)
        txtBioTag.TabIndex = 27
        txtBioTag.TabStop = False
        ToolTip1.SetToolTip(txtBioTag, "Present client")
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblLE)
        GroupBox1.Controls.Add(lblPD)
        GroupBox1.Controls.Add(txtPdOut)
        GroupBox1.Controls.Add(lblRE)
        GroupBox1.Controls.Add(txtPdIn)
        GroupBox1.Controls.Add(txtLmono)
        GroupBox1.Controls.Add(txtRmono)
        GroupBox1.Controls.Add(lblSlash)
        GroupBox1.Controls.Add(lblMonoPD)
        GroupBox1.Location = New Point(18, 72)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(588, 66)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        ' 
        ' frmVA
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(txtBioTag)
        Controls.Add(btnPrev)
        Controls.Add(GroupBox1)
        Controls.Add(btnNext)
        Controls.Add(grpVA)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmVA"
        Text = "Refraction"
        grpVA.ResumeLayout(False)
        grpVA.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblVA As Label
    Friend WithEvents lblOs As Label
    Friend WithEvents lblOd As Label
    Friend WithEvents lblUnaid As Label
    Friend WithEvents lblAid As Label
    Friend WithEvents lblPlus1 As Label
    Friend WithEvents lblPhTest As Label
    Friend WithEvents grpVA As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtLmono As TextBox
    Friend WithEvents txtRmono As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txtPdIn As TextBox
    Friend WithEvents txtPdOut As TextBox
    Private lblPD As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMonoPD As Label
    Friend WithEvents lblLE As Label
    Friend WithEvents lblRE As Label
    Friend WithEvents lblSlash As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtOsPin As TextBox
    Friend WithEvents txtOsPlus As TextBox
    Friend WithEvents txtOsAid As TextBox
    Friend WithEvents txtOsUnAid As TextBox
    Friend WithEvents txtOdPin As TextBox
    Friend WithEvents txtOdPlus As TextBox
    Friend WithEvents txtOdAid As TextBox
    Friend WithEvents txtOdUnAid As TextBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents txtBioTag As TextBox
End Class
