Public Class ConfigForm

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        My.Settings.db_host = txtServer.Text.Trim
        My.Settings.db_name = txtDbName.Text.Trim
        My.Settings.db_user = txtUser.Text.Trim
        My.Settings.db_pass = txtPass.Text.Trim
        My.Settings.app_debug_mode = ckDebug.Checked
        My.Settings.Save()

        Security.WriteReg(txtServer.Text, txtUser.Text, txtPass.Text, txtDbName.Text)

        MsgBox("Success", MsgBoxStyle.Information)
        Close()
    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.db_host
        txtDbName.Text = My.Settings.db_name
        txtUser.Text = My.Settings.db_user
        txtPass.Text = My.Settings.db_pass
        ckDebug.Checked = My.Settings.app_debug_mode
    End Sub
End Class