<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccPass
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAccPass))
        lblusername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        CheckBox1 = New CheckBox()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblusername.Location = New Point(23, 25)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(78, 20)
        lblusername.TabIndex = 0
        lblusername.Text = "Username:"
        ToolTip1.SetToolTip(lblusername, "Username for account")
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(23, 56)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(73, 20)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password:"
        ToolTip1.SetToolTip(lblPassword, "General password for account")
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(107, 22)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Account Username"
        txtUsername.Size = New Size(219, 27)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(107, 53)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "General Password"
        txtPassword.Size = New Size(219, 27)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.GradientInactiveCaption
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(107, 126)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(141, 45)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        ToolTip1.SetToolTip(btnLogin, "Login to view client records")
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(107, 86)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Show Password"
        ToolTip1.SetToolTip(CheckBox1, "Display typed password")
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' frmAccPass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(358, 193)
        Controls.Add(CheckBox1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblusername)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAccPass"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Account Access"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblusername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
