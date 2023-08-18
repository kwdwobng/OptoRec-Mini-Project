<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicalPass
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmClinicalPass))
        btnLogin = New Button()
        txtPassword = New TextBox()
        lblPassword = New Label()
        ToolTip1 = New ToolTip(components)
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.GradientInactiveCaption
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(115, 98)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(141, 45)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Login"
        ToolTip1.SetToolTip(btnLogin, "Login  to access clinical records")
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(115, 21)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Clinical Password"
        txtPassword.Size = New Size(219, 27)
        txtPassword.TabIndex = 0
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(36, 24)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(73, 20)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(115, 57)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' frmClinicalPass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(362, 169)
        Controls.Add(CheckBox1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmClinicalPass"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clinical Records"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox1 As CheckBox
End Class
