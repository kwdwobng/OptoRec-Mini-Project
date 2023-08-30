<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainComp
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMainComp))
        Panel1 = New Panel()
        btnNext = New Button()
        btnPrev = New Button()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(14, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1030, 1000)
        Panel1.TabIndex = 3
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.Control
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.Image = My.Resources.Resources.right_arrow
        btnNext.Location = New Point(1130, 12)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(69, 45)
        btnNext.TabIndex = 2
        ToolTip1.SetToolTip(btnNext, "Next page of clinical form")
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrev
        ' 
        btnPrev.BackColor = SystemColors.Control
        btnPrev.BackgroundImageLayout = ImageLayout.Zoom
        btnPrev.Enabled = False
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrev.Image = My.Resources.Resources.left_arrow
        btnPrev.Location = New Point(1058, 12)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(69, 45)
        btnPrev.TabIndex = 1
        btnPrev.TextImageRelation = TextImageRelation.ImageBeforeText
        ToolTip1.SetToolTip(btnPrev, "Previous page of clinical form")
        btnPrev.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1084, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 64
        Label1.Text = "Page 1 of 2"
        ToolTip1.SetToolTip(Label1, "Page number")
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lblTitle.Location = New Point(357, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(120, 28)
        lblTitle.TabIndex = 66
        lblTitle.Text = "Clinic Name"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ToolTip1.SetToolTip(lblTitle, "Consultation Form")
        ' 
        ' frmMainComp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1211, 1108)
        Controls.Add(lblTitle)
        Controls.Add(btnPrev)
        Controls.Add(btnNext)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMainComp"
        ShowInTaskbar = False
        Text = "Clinical Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblTitle As Label
End Class
