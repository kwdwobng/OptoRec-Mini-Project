<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultView
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmConsultView))
        btnNew = New Button()
        btnView = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = SystemColors.InactiveBorder
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageAlign = ContentAlignment.MiddleLeft
        btnNew.Location = New Point(296, 61)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(141, 45)
        btnNew.TabIndex = 0
        btnNew.Text = "New"
        ToolTip1.SetToolTip(btnNew, "Start new consultation")
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = SystemColors.GradientInactiveCaption
        btnView.Enabled = False
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnView.Image = CType(resources.GetObject("btnView.Image"), Image)
        btnView.ImageAlign = ContentAlignment.MiddleLeft
        btnView.Location = New Point(296, 112)
        btnView.Name = "btnView"
        btnView.Size = New Size(141, 45)
        btnView.TabIndex = 1
        btnView.Text = "View"
        ToolTip1.SetToolTip(btnView, "View past consultations")
        btnView.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(278, 253)
        DataGridView1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 20)
        Label1.TabIndex = 5
        Label1.Text = "Complete clinical records of:" & vbCrLf
        ' 
        ' frmConsultView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(464, 331)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(btnView)
        Controls.Add(btnNew)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmConsultView"
        ShowInTaskbar = False
        Text = "Consult Portal"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents btnView As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
