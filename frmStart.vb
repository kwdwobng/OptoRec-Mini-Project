'Welcome screen
Public Class frmStart
    'Access main interface
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmMainUI.Dispose()
        frmMainUI.Show()
        Hide()
    End Sub

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
    End Sub
End Class
