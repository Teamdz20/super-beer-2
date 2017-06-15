Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading
Imports Microsoft.Win32

Public Class DatabaseSetup

    Private script_location As String = Environment.CurrentDirectory & "\\db_config.db"

    Dim master_db_name As String = My.Settings.db_name

    Private Const S_KEY As String = "@!#$%&zA^"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        My.Settings.db_host = txtServer.Text.Trim
        My.Settings.db_user = txtUser.Text.Trim
        My.Settings.db_pass = txtPass.Text.Trim
        My.Settings.db_name = "mysql"

        PanelProgress.Visible = True

        Dim t As Thread = New Thread(New ThreadStart(AddressOf StartBgThread))
        t.Start()

    End Sub


    Sub StartBgThread()
        Dim tmp As String = Path.GetTempFileName

        Try

            Using cnx As MySqlConnection = New MySqlConnection(Settings.ConnectionString)
                Using cmd As MySqlCommand = New MySqlCommand
                    Using myBack As MySqlBackup = New MySqlBackup(cmd)
                        cmd.Connection = cnx
                        cnx.Open()


                        cmd.CommandText = "CREATE DATABASE IF NOT EXISTS " & master_db_name & " CHARACTER SET utf8"
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        My.Settings.db_name = master_db_name
                        My.Settings.Save()

                        cnx.ChangeDatabase(master_db_name)

                        AddHandler myBack.ImportProgressChanged, AddressOf ImportProgressChanged
                        AddHandler myBack.ImportCompleted, AddressOf ImportComplte

                        'myBack.ExportToFile(location & "db.sql")
                        'myBack.EncryptDumpFile(location & "db.sql", location & "db_enc.sql", "@!#$%&zA")
                        myBack.DecryptDumpFile(script_location, tmp, S_KEY)
                        myBack.ImportFromFile(tmp)
                        cnx.Clone()
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Echec de connexion au serverur de base de donnees", MsgBoxStyle.Critical)
            If My.Settings.app_debug_mode Then
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End If
        Finally
            My.Settings.db_name = master_db_name
            My.Settings.Save()
            Try
                File.Delete(tmp)
            Catch ex As Exception

            End Try
        End Try
    End Sub


    Private Delegate Sub UpdateTotalRowDelegate(ByVal val As Integer)

    Private Sub UpdateTotalRow(ByVal val As Integer)
        If InvokeRequired Then
            BeginInvoke(New UpdateTotalRowDelegate(AddressOf UpdateTotalRow), val)
        Else
            labelTotal.Text = val & " %"

            If val <= ProgressBar1.Maximum Then
                ProgressBar1.Value = val
            End If
        End If
    End Sub


    Private Sub ImportProgressChanged(sender As Object, e As ImportProgressArgs)
        UpdateTotalRow(e.PercentageCompleted)
    End Sub

    Private Sub DatabaseSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Visible = False
        txtServer.Text = My.Settings.db_host
        txtUser.Text = My.Settings.db_user
        txtPass.Text = My.Settings.db_pass
    End Sub

    Private Sub ChangeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
        Dim form As New ConfigForm
        form.ShowDialog()
    End Sub

    Private Sub ImportComplte(sender As Object, e As ImportCompleteArgs)
        ImportComplete(e)
    End Sub

    Private Delegate Sub ImportCompleteDelegate(ByVal e As ImportCompleteArgs)

    Sub ImportComplete(ByVal e As ImportCompleteArgs)
        If InvokeRequired Then
            BeginInvoke(New ImportCompleteDelegate(AddressOf ImportComplete), e)
        Else
            If e.CompletedType = ImportCompleteArgs.CompleteType.Cancelled Then
                MsgBox("Operation was cancelled", MsgBoxStyle.Exclamation)
            ElseIf e.CompletedType = ImportCompleteArgs.CompleteType.Error Then
                MsgBox("Operation fail", MsgBoxStyle.Critical)
            ElseIf e.CompletedType = ImportCompleteArgs.CompleteType.Completed Then
                MsgBox("Done", MsgBoxStyle.Information)

                Security.WriteReg(txtServer.Text, txtUser.Text, txtPass.Text, master_db_name)

                Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using cnx As MySqlConnection = New MySqlConnection(Settings.ConnectionString)
            Using cmd As MySqlCommand = New MySqlCommand
                Using myBack As MySqlBackup = New MySqlBackup(cmd)
                    cmd.Connection = cnx
                    cnx.Open()

                    Dim location As String = "C:\\Users\\Dev\\Desktop\\"

                    myBack.ExportToFile(location & "db.sql")
                    myBack.EncryptDumpFile(location & "db.sql", location & "db_enc.sql", S_KEY)
                    cnx.Close()
                End Using
            End Using
        End Using
    End Sub
End Class