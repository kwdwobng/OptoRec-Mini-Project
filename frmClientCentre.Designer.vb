<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientCentre
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmClientCentre))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnLogout = New Button()
        DataGridView1 = New DataGridView()
        txtSearch = New TextBox()
        txtInfo = New TextBox()
        btnClient = New Button()
        btnNew = New Button()
        grpSearch = New GroupBox()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        btnTrans = New Button()
        btnExport = New Button()
        GroupBox1 = New GroupBox()
        btnMessage = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        grpSearch.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = SystemColors.Info
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(900, 539)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(141, 45)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        ToolTip1.SetToolTip(btnLogout, "Logout of client centre")
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(18, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(795, 297)
        DataGridView1.TabIndex = 5
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(18, 26)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Card number or name"
        txtSearch.Size = New Size(508, 27)
        txtSearch.TabIndex = 4
        ToolTip1.SetToolTip(txtSearch, "Search box")
        ' 
        ' txtInfo
        ' 
        txtInfo.BackColor = SystemColors.Control
        txtInfo.BorderStyle = BorderStyle.FixedSingle
        txtInfo.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtInfo.Location = New Point(819, 63)
        txtInfo.Multiline = True
        txtInfo.Name = "txtInfo"
        txtInfo.ReadOnly = True
        txtInfo.Size = New Size(217, 297)
        txtInfo.TabIndex = 64
        ToolTip1.SetToolTip(txtInfo, "Biodata info summary")
        ' 
        ' btnClient
        ' 
        btnClient.BackColor = SystemColors.GradientInactiveCaption
        btnClient.FlatStyle = FlatStyle.Flat
        btnClient.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnClient.Image = CType(resources.GetObject("btnClient.Image"), Image)
        btnClient.ImageAlign = ContentAlignment.MiddleLeft
        btnClient.Location = New Point(18, 26)
        btnClient.Name = "btnClient"
        btnClient.Size = New Size(141, 45)
        btnClient.TabIndex = 1
        btnClient.Text = "Client"
        ToolTip1.SetToolTip(btnClient, "Client clinical record")
        btnClient.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = SystemColors.GradientInactiveCaption
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageAlign = ContentAlignment.MiddleLeft
        btnNew.Location = New Point(165, 26)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(141, 45)
        btnNew.TabIndex = 2
        btnNew.Text = "New"
        ToolTip1.SetToolTip(btnNew, "Create new client record")
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' grpSearch
        ' 
        grpSearch.Controls.Add(btnRefresh)
        grpSearch.Controls.Add(PictureBox1)
        grpSearch.Controls.Add(txtInfo)
        grpSearch.Controls.Add(txtSearch)
        grpSearch.Controls.Add(DataGridView1)
        grpSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        grpSearch.Location = New Point(12, 111)
        grpSearch.Name = "grpSearch"
        grpSearch.Size = New Size(1051, 422)
        grpSearch.TabIndex = 9
        grpSearch.TabStop = False
        grpSearch.Text = "Search Client"
        ToolTip1.SetToolTip(grpSearch, "Search client records")
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Transparent
        btnRefresh.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.Location = New Point(768, 366)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(45, 45)
        btnRefresh.TabIndex = 65
        ToolTip1.SetToolTip(btnRefresh, "Refresh table")
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.magnifying_glass
        PictureBox1.Location = New Point(527, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 27)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnTrans
        ' 
        btnTrans.BackColor = SystemColors.GradientInactiveCaption
        btnTrans.FlatStyle = FlatStyle.Flat
        btnTrans.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnTrans.Image = CType(resources.GetObject("btnTrans.Image"), Image)
        btnTrans.ImageAlign = ContentAlignment.MiddleLeft
        btnTrans.Location = New Point(312, 26)
        btnTrans.Name = "btnTrans"
        btnTrans.Size = New Size(141, 45)
        btnTrans.TabIndex = 3
        btnTrans.Text = " Transactions"
        ToolTip1.SetToolTip(btnTrans, "Transaction Centre")
        btnTrans.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = SystemColors.InactiveBorder
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Image = CType(resources.GetObject("btnExport.Image"), Image)
        btnExport.ImageAlign = ContentAlignment.MiddleLeft
        btnExport.Location = New Point(12, 539)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(141, 45)
        btnExport.TabIndex = 7
        btnExport.Text = "Export"
        ToolTip1.SetToolTip(btnExport, "Export client data")
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTrans)
        GroupBox1.Controls.Add(btnClient)
        GroupBox1.Controls.Add(btnNew)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(588, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(475, 92)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Client Portal"
        ToolTip1.SetToolTip(GroupBox1, "Client Menu")
        ' 
        ' btnMessage
        ' 
        btnMessage.BackColor = SystemColors.ControlLightLight
        btnMessage.FlatStyle = FlatStyle.Flat
        btnMessage.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnMessage.Image = CType(resources.GetObject("btnMessage.Image"), Image)
        btnMessage.ImageAlign = ContentAlignment.MiddleLeft
        btnMessage.Location = New Point(12, 37)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(141, 45)
        btnMessage.TabIndex = 12
        btnMessage.Text = "Messenger"
        ToolTip1.SetToolTip(btnMessage, "Leave a short message")
        btnMessage.UseVisualStyleBackColor = False
        ' 
        ' frmClientCentre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(btnMessage)
        Controls.Add(btnExport)
        Controls.Add(GroupBox1)
        Controls.Add(grpSearch)
        Controls.Add(btnLogout)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmClientCentre"
        Text = "Client Record Centre"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        grpSearch.ResumeLayout(False)
        grpSearch.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnClient As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnTrans As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnRefresh As Button
End Class
