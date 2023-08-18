<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewHistory
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmViewHistory))
        DataGridView1 = New DataGridView()
        btnView = New Button()
        btnDelete = New Button()
        ToolTip1 = New ToolTip(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(278, 319)
        DataGridView1.TabIndex = 3
        ToolTip1.SetToolTip(DataGridView1, "Client receipt history")
        ' 
        ' btnView
        ' 
        btnView.BackColor = SystemColors.GradientInactiveCaption
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnView.Image = CType(resources.GetObject("btnView.Image"), Image)
        btnView.ImageAlign = ContentAlignment.MiddleLeft
        btnView.Location = New Point(307, 12)
        btnView.Name = "btnView"
        btnView.Size = New Size(141, 45)
        btnView.TabIndex = 4
        btnView.Text = "View" & vbCrLf
        ToolTip1.SetToolTip(btnView, "View receipt")
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Info
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(307, 63)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(141, 45)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        ToolTip1.SetToolTip(btnDelete, "Delete receipt")
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' frmViewHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(455, 347)
        Controls.Add(btnDelete)
        Controls.Add(btnView)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmViewHistory"
        Text = "Receipt History"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
