<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardio
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmCardio))
        GroupBox1 = New GroupBox()
        txtmskBP = New MaskedTextBox()
        lblSugar = New Label()
        lblBP = New Label()
        txtSugar = New TextBox()
        btnSave = New Button()
        btnNext = New Button()
        txtBioTag = New TextBox()
        ToolTip1 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtmskBP)
        GroupBox1.Controls.Add(lblSugar)
        GroupBox1.Controls.Add(lblBP)
        GroupBox1.Controls.Add(txtSugar)
        GroupBox1.Location = New Point(12, 63)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(561, 87)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        ' 
        ' txtmskBP
        ' 
        txtmskBP.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtmskBP.Location = New Point(196, 38)
        txtmskBP.Mask = "000/000"
        txtmskBP.Name = "txtmskBP"
        txtmskBP.Size = New Size(60, 27)
        txtmskBP.TabIndex = 1
        ' 
        ' lblSugar
        ' 
        lblSugar.AutoSize = True
        lblSugar.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblSugar.Location = New Point(262, 41)
        lblSugar.Name = "lblSugar"
        lblSugar.Size = New Size(212, 20)
        lblSugar.TabIndex = 22
        lblSugar.Text = "Blood Glucose Level (mmol/L):"
        ' 
        ' lblBP
        ' 
        lblBP.AutoSize = True
        lblBP.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblBP.Location = New Point(20, 41)
        lblBP.Name = "lblBP"
        lblBP.Size = New Size(170, 20)
        lblBP.TabIndex = 23
        lblBP.Text = "Blood Pressure (mmHg):"
        ' 
        ' txtSugar
        ' 
        txtSugar.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSugar.Location = New Point(480, 38)
        txtSugar.Name = "txtSugar"
        txtSugar.Size = New Size(59, 27)
        txtSugar.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.GradientInactiveCaption
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(432, 156)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(141, 45)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        ToolTip1.SetToolTip(btnSave, "Save info")
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.Control
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Image = My.Resources.Resources.right_arrow
        btnNext.Location = New Point(505, 12)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(68, 45)
        btnNext.TabIndex = 4
        ToolTip1.SetToolTip(btnNext, "Next form")
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' txtBioTag
        ' 
        txtBioTag.BackColor = Color.WhiteSmoke
        txtBioTag.BorderStyle = BorderStyle.FixedSingle
        txtBioTag.Location = New Point(12, 12)
        txtBioTag.Name = "txtBioTag"
        txtBioTag.ReadOnly = True
        txtBioTag.Size = New Size(406, 27)
        txtBioTag.TabIndex = 26
        txtBioTag.TabStop = False
        ToolTip1.SetToolTip(txtBioTag, "Present client")
        ' 
        ' frmCardio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(730, 450)
        Controls.Add(txtBioTag)
        Controls.Add(btnNext)
        Controls.Add(GroupBox1)
        Controls.Add(btnSave)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCardio"
        Text = "frmCardio"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtmskBP As MaskedTextBox
    Friend WithEvents lblSugar As Label
    Friend WithEvents txtSugar As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblBP As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents txtBioTag As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
