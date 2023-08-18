<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReceipt2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmViewReceipt2))
        lblTotal = New Label()
        txtTotal = New TextBox()
        ListView1 = New ListView()
        chdrItem = New ColumnHeader()
        chdrQuantity = New ColumnHeader()
        chdrCost = New ColumnHeader()
        chdrAmount = New ColumnHeader()
        btnPrint = New Button()
        lblClinicInfo = New Label()
        txtInfo = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        btnExit = New Button()
        ToolTip1 = New ToolTip(components)
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.Location = New Point(490, 458)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(88, 23)
        lblTotal.TabIndex = 10
        lblTotal.Text = "Final Cost:"
        ToolTip1.SetToolTip(lblTotal, "Total cost of all iterms on receipt")
        ' 
        ' txtTotal
        ' 
        txtTotal.BorderStyle = BorderStyle.None
        txtTotal.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotal.Location = New Point(585, 459)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(87, 23)
        txtTotal.TabIndex = 9
        ' 
        ' ListView1
        ' 
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {chdrItem, chdrQuantity, chdrCost, chdrAmount})
        ListView1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.Location = New Point(20, 135)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(652, 318)
        ListView1.TabIndex = 2
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
        ' btnPrint
        ' 
        btnPrint.BackColor = SystemColors.InactiveBorder
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), Image)
        btnPrint.ImageAlign = ContentAlignment.MiddleLeft
        btnPrint.Location = New Point(818, 17)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(125, 39)
        btnPrint.TabIndex = 0
        btnPrint.Text = "Print"
        ToolTip1.SetToolTip(btnPrint, "Print receipt form")
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblClinicInfo
        ' 
        lblClinicInfo.AutoSize = True
        lblClinicInfo.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblClinicInfo.Location = New Point(20, 17)
        lblClinicInfo.Name = "lblClinicInfo"
        lblClinicInfo.Size = New Size(74, 69)
        lblClinicInfo.TabIndex = 17
        lblClinicInfo.Text = "Selected" & vbCrLf & "Account" & vbCrLf & "Info"
        ' 
        ' txtInfo
        ' 
        txtInfo.BackColor = SystemColors.ControlLightLight
        txtInfo.BorderStyle = BorderStyle.None
        txtInfo.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtInfo.Location = New Point(196, 82)
        txtInfo.Name = "txtInfo"
        txtInfo.ReadOnly = True
        txtInfo.Size = New Size(476, 23)
        txtInfo.TabIndex = 12
        txtInfo.Text = "Client Info"
        txtInfo.TextAlign = HorizontalAlignment.Right
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Info
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(818, 62)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(125, 39)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        ToolTip1.SetToolTip(btnExit, "Exit receipt form")
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblTotal)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(990, 626)
        Panel1.TabIndex = 15
        ' 
        ' frmViewReceipt2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(990, 626)
        Controls.Add(btnExit)
        Controls.Add(lblClinicInfo)
        Controls.Add(txtInfo)
        Controls.Add(txtTotal)
        Controls.Add(ListView1)
        Controls.Add(btnPrint)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        ImeMode = ImeMode.On
        Name = "frmViewReceipt2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Saved Receipt"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chdrItem As ColumnHeader
    Friend WithEvents chdrQuantity As ColumnHeader
    Friend WithEvents chdrCost As ColumnHeader
    Friend WithEvents chdrAmount As ColumnHeader
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblClinicInfo As Label
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
End Class
