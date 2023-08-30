'Welcome screen
Public Class frmStart
    'Access database config settings
    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        frmDBConfig.Dispose()
        frmDBConfig.Show()
    End Sub
    Private Sub frmStart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to exit the app?", "Exit OptoRec", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Select()
        'Check to see if there is a connection error
        Try
            DB.sqlConnect.Open()
            DB.sqlConnect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("There is a database error which prevents you from using the app. Configure database settings to resolve this problem.",
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLogin.Enabled = False
            frmDBConfig.Show()
            My.Settings.Reset()
            My.Settings.setDB = "opt_rec_1"
            My.Settings.Save()
        Finally
            DB.sqlConnect.Dispose()
        End Try
    End Sub

    'Login to user account
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmAccPass.Show()
    End Sub

    'Go to new user account form
    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        frmAccSetUp.Dispose()
        frmMainUI.Dispose()
        frmMainUI.Show()
        frmMainUI.ViewInPanel(frmAccSetUp)
    End Sub
End Class
