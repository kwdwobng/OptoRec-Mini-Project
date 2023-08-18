<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBConfig
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
        txtServer = New TextBox()
        txtPort = New TextBox()
        txtUID = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnTest = New Button()
        btnExit = New Button()
        btnCreate = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' txtServer
        ' 
        txtServer.Location = New Point(125, 24)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(268, 27)
        txtServer.TabIndex = 0
        ' 
        ' txtPort
        ' 
        txtPort.Location = New Point(125, 57)
        txtPort.Name = "txtPort"
        txtPort.Size = New Size(268, 27)
        txtPort.TabIndex = 1
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(125, 90)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(268, 27)
        txtUID.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(125, 123)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(268, 27)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 4
        Label1.Text = "Server:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 20)
        Label2.TabIndex = 5
        Label2.Text = "Port:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 6
        Label3.Text = "User ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 7
        Label4.Text = "Password:"
        ' 
        ' btnTest
        ' 
        btnTest.BackColor = SystemColors.ButtonHighlight
        btnTest.Location = New Point(125, 186)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(120, 42)
        btnTest.TabIndex = 10
        btnTest.Text = "Test"
        btnTest.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(251, 239)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(120, 42)
        btnExit.TabIndex = 11
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = SystemColors.ButtonHighlight
        btnCreate.Location = New Point(251, 186)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(120, 42)
        btnCreate.TabIndex = 13
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(125, 156)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' frmDBConfig
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(440, 293)
        Controls.Add(CheckBox1)
        Controls.Add(btnCreate)
        Controls.Add(btnExit)
        Controls.Add(btnTest)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUID)
        Controls.Add(txtPort)
        Controls.Add(txtServer)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "frmDBConfig"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Database Settings"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
