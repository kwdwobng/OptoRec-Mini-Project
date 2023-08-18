<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDDx
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmDDx))
        btnUpdateAcc = New Button()
        btnPrev = New Button()
        txtComments = New TextBox()
        txtPx = New TextBox()
        txtDx = New TextBox()
        Label8 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        txtBioTag = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnUpdateAcc
        ' 
        btnUpdateAcc.BackColor = SystemColors.GradientInactiveCaption
        btnUpdateAcc.FlatStyle = FlatStyle.Flat
        btnUpdateAcc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateAcc.Image = CType(resources.GetObject("btnUpdateAcc.Image"), Image)
        btnUpdateAcc.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdateAcc.Location = New Point(738, 489)
        btnUpdateAcc.Name = "btnUpdateAcc"
        btnUpdateAcc.Size = New Size(141, 45)
        btnUpdateAcc.TabIndex = 35
        btnUpdateAcc.Text = "Save"
        ToolTip1.SetToolTip(btnUpdateAcc, "Save info")
        btnUpdateAcc.UseVisualStyleBackColor = False
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = SystemColors.Control
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrev.Image = My.Resources.Resources.left_arrow
        btnPrev.Location = New Point(811, 21)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(68, 45)
        btnPrev.TabIndex = 36
        ToolTip1.SetToolTip(btnPrev, "Previous form")
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' txtComments
        ' 
        txtComments.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtComments.Location = New Point(168, 233)
        txtComments.Multiline = True
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(671, 158)
        txtComments.TabIndex = 34
        ' 
        ' txtPx
        ' 
        txtPx.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPx.Location = New Point(168, 69)
        txtPx.Multiline = True
        txtPx.Name = "txtPx"
        txtPx.Size = New Size(671, 158)
        txtPx.TabIndex = 33
        ' 
        ' txtDx
        ' 
        txtDx.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtDx.Location = New Point(168, 20)
        txtDx.Multiline = True
        txtDx.Name = "txtDx"
        txtDx.Size = New Size(671, 43)
        txtDx.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(15, 236)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 40)
        Label8.TabIndex = 31
        Label8.Text = "Doctor's" & vbCrLf & "Comment:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 40)
        Label6.TabIndex = 29
        Label6.Text = "Impression/" & vbCrLf & "Diagnosis:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 60)
        Label1.TabIndex = 40
        Label1.Text = "Management Plan" & vbCrLf & "And" & vbCrLf & "Prescription:"
        ' 
        ' txtBioTag
        ' 
        txtBioTag.BackColor = Color.WhiteSmoke
        txtBioTag.BorderStyle = BorderStyle.FixedSingle
        txtBioTag.Location = New Point(12, 21)
        txtBioTag.Name = "txtBioTag"
        txtBioTag.ReadOnly = True
        txtBioTag.Size = New Size(406, 27)
        txtBioTag.TabIndex = 42
        txtBioTag.TabStop = False
        ToolTip1.SetToolTip(txtBioTag, "Present client")
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtComments)
        GroupBox1.Controls.Add(txtPx)
        GroupBox1.Controls.Add(txtDx)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(12, 72)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(867, 411)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        ' 
        ' frmDDx
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(txtBioTag)
        Controls.Add(GroupBox1)
        Controls.Add(btnUpdateAcc)
        Controls.Add(btnPrev)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "frmDDx"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Diagnosis & Prescription"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents txtComments As TextBox
    Friend WithEvents txtPx As TextBox
    Friend WithEvents txtDx As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBioTag As TextBox
End Class
