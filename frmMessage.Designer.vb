<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMessage))
        TextBox1 = New TextBox()
        btnSave = New Button()
        btnRefresh = New Button()
        btnEdit = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(12, 12)
        TextBox1.MaxLength = 255
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(373, 147)
        TextBox1.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top
        btnSave.BackColor = SystemColors.GradientInactiveCaption
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.Black
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(389, 63)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(141, 45)
        btnSave.TabIndex = 102
        btnSave.Text = "Save"
        ToolTip1.SetToolTip(btnSave, "Save message")
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top
        btnRefresh.BackColor = SystemColors.Info
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.ForeColor = Color.Black
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(389, 114)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(141, 45)
        btnRefresh.TabIndex = 103
        btnRefresh.Text = "Refresh"
        ToolTip1.SetToolTip(btnRefresh, "Refresh to last saved message")
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top
        btnEdit.BackColor = Color.Transparent
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.Black
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.ImageAlign = ContentAlignment.MiddleLeft
        btnEdit.Location = New Point(389, 12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(141, 45)
        btnEdit.TabIndex = 104
        btnEdit.Text = "Add/Edit"
        ToolTip1.SetToolTip(btnEdit, "Create or edit message")
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' frmMessage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(542, 176)
        Controls.Add(btnEdit)
        Controls.Add(btnRefresh)
        Controls.Add(btnSave)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMessage"
        ShowInTaskbar = False
        Text = "Quick Message"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
