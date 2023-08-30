<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmStart))
        btnConfig = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        btnLogin = New Button()
        btnNewUser = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnConfig
        ' 
        btnConfig.BackColor = Color.Transparent
        btnConfig.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnConfig.Image = My.Resources.Resources.settings
        btnConfig.Location = New Point(243, 12)
        btnConfig.Name = "btnConfig"
        btnConfig.RightToLeft = RightToLeft.No
        btnConfig.Size = New Size(45, 45)
        btnConfig.TabIndex = 2
        ToolTip1.SetToolTip(btnConfig, "Database settings")
        btnConfig.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 365)
        Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(11, 263)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 6
        Label2.Text = "OptoRec"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(11, 291)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 60)
        Label1.TabIndex = 5
        Label1.Text = "Optometric Record Management System" & vbCrLf & "Version: 1.0.0" & vbCrLf & "Release: 2023"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(250, 228)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.Black
        btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), Image)
        btnLogin.ImageAlign = ContentAlignment.MiddleLeft
        btnLogin.Location = New Point(80, 109)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(141, 45)
        btnLogin.TabIndex = 102
        btnLogin.Text = "Login"
        ToolTip1.SetToolTip(btnLogin, "Login to User Account")
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnNewUser
        ' 
        btnNewUser.BackColor = Color.Transparent
        btnNewUser.FlatStyle = FlatStyle.Flat
        btnNewUser.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNewUser.ForeColor = Color.Black
        btnNewUser.Image = CType(resources.GetObject("btnNewUser.Image"), Image)
        btnNewUser.ImageAlign = ContentAlignment.MiddleLeft
        btnNewUser.Location = New Point(80, 160)
        btnNewUser.Name = "btnNewUser"
        btnNewUser.Size = New Size(141, 45)
        btnNewUser.TabIndex = 103
        btnNewUser.Text = "New"
        ToolTip1.SetToolTip(btnNewUser, "Create new user account")
        btnNewUser.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnNewUser)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(btnConfig)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(300, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 365)
        Panel2.TabIndex = 4
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(600, 365)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmStart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OptoRec - Start"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnConfig As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnNewUser As Button
End Class
