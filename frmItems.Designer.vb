<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItems
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmItems))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtItem = New TextBox()
        lblItem = New Label()
        lblCost = New Label()
        txtCost = New TextBox()
        GroupBox1 = New GroupBox()
        btnDelete = New Button()
        btnClear = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        txtSearch = New TextBox()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        btnRefresh = New Button()
        DataGridView1 = New DataGridView()
        ToolTip1 = New ToolTip(components)
        txtUsername = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtItem
        ' 
        txtItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtItem.Location = New Point(48, 71)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(549, 27)
        txtItem.TabIndex = 1
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblItem.Location = New Point(48, 45)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(132, 20)
        lblItem.TabIndex = 1
        lblItem.Text = "Product or Service:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblCost.Location = New Point(603, 45)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(63, 20)
        lblCost.TabIndex = 3
        lblCost.Text = "Cost (₵):"
        ' 
        ' txtCost
        ' 
        txtCost.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtCost.Location = New Point(603, 71)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(72, 27)
        txtCost.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(btnUpdate)
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Controls.Add(lblCost)
        GroupBox1.Controls.Add(txtCost)
        GroupBox1.Controls.Add(lblItem)
        GroupBox1.Controls.Add(txtItem)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1017, 177)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add, Update, Delete"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Info
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(855, 114)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(141, 45)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        ToolTip1.SetToolTip(btnDelete, "Delete product or service")
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Info
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Image = CType(resources.GetObject("btnClear.Image"), Image)
        btnClear.ImageAlign = ContentAlignment.MiddleLeft
        btnClear.Location = New Point(708, 114)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(141, 45)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        ToolTip1.SetToolTip(btnClear, "Clear product or service name and cost")
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.GradientInactiveCaption
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(855, 63)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(141, 45)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        ToolTip1.SetToolTip(btnUpdate, "Update product or service info")
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.GradientInactiveCaption
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.ImageAlign = ContentAlignment.MiddleLeft
        btnAdd.Location = New Point(708, 63)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(141, 45)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        ToolTip1.SetToolTip(btnAdd, "Add product or service")
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(48, 29)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Enter product or service to search"
        txtSearch.Size = New Size(549, 27)
        txtSearch.TabIndex = 9
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(btnRefresh)
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Controls.Add(txtSearch)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(12, 231)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1017, 376)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "View Products and Services"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.magnifying_glass
        PictureBox1.Location = New Point(597, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 27)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.Control
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(708, 82)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(141, 45)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        ToolTip1.SetToolTip(btnRefresh, "Refresh list of products and services")
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
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
        DataGridView1.Location = New Point(48, 82)
        DataGridView1.Margin = New Padding(0, 3, 3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(627, 265)
        DataGridView1.TabIndex = 8
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ButtonHighlight
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(720, 15)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(309, 27)
        txtUsername.TabIndex = 8
        txtUsername.TabStop = False
        ToolTip1.SetToolTip(txtUsername, "Username of Account")
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(578, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 9
        Label1.Text = "Account Username:"
        ' 
        ' frmItems
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1405, 959)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmItems"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Products & Services Centre"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtItem As TextBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
