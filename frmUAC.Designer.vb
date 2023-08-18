<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUAC
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmUAC))
        ListBox1 = New ListBox()
        txtInfo = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        ToolTip1 = New ToolTip(components)
        btnEdit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 28
        ListBox1.Location = New Point(22, 26)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(268, 340)
        ListBox1.TabIndex = 0
        ' 
        ' txtInfo
        ' 
        txtInfo.BackColor = SystemColors.ControlLightLight
        txtInfo.BorderStyle = BorderStyle.FixedSingle
        txtInfo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtInfo.Location = New Point(23, 26)
        txtInfo.Multiline = True
        txtInfo.Name = "txtInfo"
        txtInfo.ReadOnly = True
        txtInfo.Size = New Size(268, 340)
        txtInfo.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.GradientInactiveCaption
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), Image)
        btnLogin.ImageAlign = ContentAlignment.MiddleLeft
        btnLogin.Location = New Point(674, 29)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(141, 45)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        ToolTip1.SetToolTip(btnLogin, "Login to user account")
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.Info
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(674, 131)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(141, 45)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        ToolTip1.SetToolTip(btnExit, "Exit to welcome screen")
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(314, 393)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Account"
        ToolTip1.SetToolTip(GroupBox1, "List of user accounts")
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtInfo)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(354, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(314, 393)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Info"
        ToolTip1.SetToolTip(GroupBox2, "Account info summary")
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.GradientInactiveCaption
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.ImageAlign = ContentAlignment.MiddleLeft
        btnEdit.Location = New Point(674, 80)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(141, 45)
        btnEdit.TabIndex = 4
        btnEdit.Text = "Edit"
        ToolTip1.SetToolTip(btnEdit, "Edit user account")
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' frmUAC
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1280, 720)
        Controls.Add(btnEdit)
        Controls.Add(GroupBox2)
        Controls.Add(btnExit)
        Controls.Add(GroupBox1)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmUAC"
        Text = "User Account Centre"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnEdit As Button
End Class
