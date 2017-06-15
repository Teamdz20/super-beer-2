Imports Microsoft.Win32

Public Class Login

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2) - 20
        PanelContainer.Location = location
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.RefreshSettings()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        'Beep()
        Dim result As DialogResult = Util.ShowMessage(Me, "Voulez-vous vraiment quitter l'application ?", 3)
        If result = Windows.Forms.DialogResult.Yes Then
            Close()
        End If
    End Sub


    Private Sub LogUser()
        If txtUsername.Text.Trim.Length = 0 OrElse txtPass.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
            Exit Sub
        End If

        Dim user As New EntraideBundle.Db.Entities.UserEntity
        user.username = txtUsername.Text.Trim
        user.password = txtPass.Text.Trim
        user = EntraideBundle.Db.Tables.UsersTable.LogUser(user)
        If user.IsLogged Then
            My.Settings.user_id = user.id
            My.Settings.username = user.username
            My.Settings.user_full_name = user.EmpFullName
            Main.Show()
            Me.Close()
        Else
            Util.ShowMessage(Me, "Nom d'utilisateur ou mot de passe invalide", 1)
        End If

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        LogUser()
    End Sub


    Private Sub MetroTextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPass.KeyUp
        If e.KeyData = Keys.Enter Then
            LogUser()
        End If
    End Sub


    Public Shared Sub RefreshSettings()

        ConfigManager.Settings.RefreshSettings()

        My.Settings.app_debug_mode = ConfigManager.Settings.AppDebugMode
        My.Settings.dbhost = ConfigManager.Settings.DbHost
        My.Settings.dbname = ConfigManager.Settings.DbName
        My.Settings.dbuser = ConfigManager.Settings.DbUser
        My.Settings.dbpass = ConfigManager.Settings.DbPass

        'Util.ShowMessage(My.Settings.dbpass)

        My.Settings.Save()
    End Sub

    Private Sub ChangeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
        Dim form As New ConfigManager.ConfigForm
        form.ShowDialog()

        Login.RefreshSettings()
    End Sub
End Class