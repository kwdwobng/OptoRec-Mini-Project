<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCheckOut
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmCheckOut))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtSearch = New TextBox()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        btnAdd1 = New Button()
        DataGridView1 = New DataGridView()
        ListView1 = New ListView()
        chdrItem = New ColumnHeader()
        chdrQuantity = New ColumnHeader()
        chdrCost = New ColumnHeader()
        chdrAmount = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        GroupBox3 = New GroupBox()
        btnClear = New Button()
        btnHistory = New Button()
        btnSave = New Button()
        lblTotal = New Label()
        txtTotal = New TextBox()
        btnMinus1 = New Button()
        btnPlus1 = New Button()
        ToolTip1 = New ToolTip(components)
        txtName = New TextBox()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(48, 26)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Enter product or service to search"
        txtSearch.Size = New Size(508, 27)
        txtSearch.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(btnAdd1)
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Controls.Add(txtSearch)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(12, 431)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(997, 377)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.magnifying_glass
        PictureBox1.Location = New Point(556, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 27)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' btnAdd1
        ' 
        btnAdd1.BackColor = SystemColors.GradientInactiveCaption
        btnAdd1.FlatStyle = FlatStyle.Flat
        btnAdd1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd1.Image = CType(resources.GetObject("btnAdd1.Image"), Image)
        btnAdd1.ImageAlign = ContentAlignment.MiddleLeft
        btnAdd1.Location = New Point(751, 65)
        btnAdd1.Name = "btnAdd1"
        btnAdd1.Size = New Size(141, 45)
        btnAdd1.TabIndex = 9
        btnAdd1.Text = "Add"
        ToolTip1.SetToolTip(btnAdd1, "Add product or service to receipt")
        btnAdd1.UseVisualStyleBackColor = False
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
        DataGridView1.Location = New Point(48, 65)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(644, 283)
        DataGridView1.TabIndex = 8
        ' 
        ' ListView1
        ' 
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {chdrItem, chdrQuantity, chdrCost, chdrAmount, ColumnHeader1})
        ListView1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.Location = New Point(42, 24)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(644, 283)
        ListView1.TabIndex = 8
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' chdrItem
        ' 
        chdrItem.Text = "ITEM"
        chdrItem.Width = 450
        ' 
        ' chdrQuantity
        ' 
        chdrQuantity.Tag = "Integer"
        chdrQuantity.Text = "QTY"
        chdrQuantity.Width = 40
        ' 
        ' chdrCost
        ' 
        chdrCost.Text = "UNIT (₵)"
        chdrCost.Width = 70
        ' 
        ' chdrAmount
        ' 
        chdrAmount.Tag = "Decimal"
        chdrAmount.Text = "TOTAL (₵)"
        chdrAmount.Width = 80
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 30
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnClear)
        GroupBox3.Controls.Add(btnHistory)
        GroupBox3.Controls.Add(btnSave)
        GroupBox3.Controls.Add(lblTotal)
        GroupBox3.Controls.Add(txtTotal)
        GroupBox3.Controls.Add(btnMinus1)
        GroupBox3.Controls.Add(btnPlus1)
        GroupBox3.Controls.Add(ListView1)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(12, 48)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(997, 377)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Receipt"
        ToolTip1.SetToolTip(GroupBox3, "Items for purchase in transaction")
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.Info
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Image = CType(resources.GetObject("btnClear.Image"), Image)
        btnClear.ImageAlign = ContentAlignment.MiddleLeft
        btnClear.Location = New Point(747, 126)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(141, 45)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        ToolTip1.SetToolTip(btnClear, "Clear receipt")
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = SystemColors.GradientInactiveCaption
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), Image)
        btnHistory.ImageAlign = ContentAlignment.MiddleLeft
        btnHistory.Location = New Point(747, 75)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(141, 45)
        btnHistory.TabIndex = 12
        btnHistory.Text = "History"
        ToolTip1.SetToolTip(btnHistory, "Receipt history")
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.GradientInactiveCaption
        btnSave.Enabled = False
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(747, 24)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(141, 45)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        ToolTip1.SetToolTip(btnSave, "Save receipt")
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.Location = New Point(514, 316)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(76, 20)
        lblTotal.TabIndex = 10
        lblTotal.Text = "Final Cost:"
        ToolTip1.SetToolTip(lblTotal, "Total cost of all iterms on receipt")
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotal.Location = New Point(596, 313)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(90, 27)
        txtTotal.TabIndex = 9
        ' 
        ' btnMinus1
        ' 
        btnMinus1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnMinus1.Location = New Point(688, 70)
        btnMinus1.Name = "btnMinus1"
        btnMinus1.Size = New Size(40, 40)
        btnMinus1.TabIndex = 10
        btnMinus1.Text = "-"
        btnMinus1.UseVisualStyleBackColor = True
        ' 
        ' btnPlus1
        ' 
        btnPlus1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnPlus1.Location = New Point(688, 24)
        btnPlus1.Name = "btnPlus1"
        btnPlus1.Size = New Size(40, 40)
        btnPlus1.TabIndex = 9
        btnPlus1.Text = "+"
        btnPlus1.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ButtonHighlight
        txtName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(700, 12)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(309, 27)
        txtName.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(516, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 20)
        Label1.TabIndex = 11
        Label1.Text = "Client name, card number:"
        ' 
        ' frmCheckOut
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1550, 1026)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCheckOut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Check Out"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chdrItem As ColumnHeader
    Friend WithEvents chdrCost As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents chdrQuantity As ColumnHeader
    Friend WithEvents btnPlus1 As Button
    Friend WithEvents btnMinus1 As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents chdrAmount As ColumnHeader
    Friend WithEvents btnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
End Class
