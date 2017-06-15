Imports MySql.Data.MySqlClient
Imports System.Threading
Imports EntraideBundle.Db

Public Class Users

    Public user_id As String = ""

    Public visu_mode As Boolean = False


    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Private Sub LoadAccess()
        Try
            If user_id.Length > 0 Then
                Database.Query("SELECT id, name FROM access WHERE id NOT IN (SELECT access_id FROM access_granted WHERE user_id = '" & user_id & "') ORDER BY value")
            Else
                Database.Query("SELECT id, name FROM access ORDER BY value")
            End If
            Dim result = Database.ExecuteResult

            ListAccess.Items.Clear()
            Dim iter As Integer = 1
            Dim position As Integer = 0
            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(position)
                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If
                ListAccess.Items.Add(item)
                iter += 1
                position += 1
            End While
            result.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnees", 2)
            End If
        Finally
            Database.CloseConnection()
        End Try
    End Sub


    Private Sub LoadGrantedAccess()
        Try
            Database.Query("SELECT access.id, access.name FROM access INNER JOIN access_granted ON access.id = access_granted.access_id WHERE access_granted.user_id = '" & user_id & "' ORDER BY access.value")
            Dim result = Database.ExecuteResult

            ListeGranted.Items.Clear()
            Dim iter As Integer = 1
            Dim position As Integer = 0
            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(position)
                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If
                ListeGranted.Items.Add(item)
                iter += 1
                position += 1
            End While
            result.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnees", 2)
            End If
        Finally
            Database.CloseConnection()
        End Try
    End Sub


    Private Sub LoadUserInfos()
        Try
            Database.Query("SELECT username, password, employe_id FROM users WHERE id = '" & user_id & "'")
            Dim result = Database.ExecuteResult
            While result.Read
                txtNom.Text = result.GetValue(0).ToString
                txtPassword.Text = result.GetValue(1).ToString
                cmbEmploye.SelectedValue = result.GetValue(2).ToString
            End While
            result.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Echec de connexion a la base de donnees", 2)
            End If
        Finally
            Database.CloseConnection()
        End Try
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Util.setupFrame(Me)
        Util.PopulateCombo(cmbEmploye, "SELECT id, CONCAT_WS(' ', nom, prenom) AS nom FROM employes", "id", "nom")
        LoadAccess()

        If user_id.Length > 0 Then
            LoadUserInfos()
            LoadGrantedAccess()
        End If

        If user_id = "1" Then
            btnRevoke.Enabled = False
        End If

        If visu_mode Then
            txtNom.ReadOnly = True
            txtPassword.ReadOnly = True
            cmbEmploye.Enabled = False
            btnGrant.Enabled = False
            btnRevoke.Enabled = False
            ListAccess.FullRowSelect = False
            ListeGranted.FullRowSelect = False
            btnValider.Enabled = False
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If cmbEmploye.SelectedValue = "0" Then
            Util.ShowMessage("Veuillez sélectionner un employé", 1)
        ElseIf txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage("Veuillez remplir le nom d'utilisateur", 1)
        ElseIf txtPassword.Text.Trim.Length = 0 Then
            Util.ShowMessage("Veuillez remplir le mot de passe", 1)
        Else
            Dim cmd As MySqlCommand = Nothing
            Try
                If user_id.Length > 0 Then
                    cmd = Database.GetCommand
                    cmd.CommandText = "DELETE FROM access_granted WHERE user_id = @uid; UPDATE users SET username = @uname, password = @pass, employe_id = @emp WHERE id = @uid"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@uid", user_id)
                    cmd.Parameters.AddWithValue("@uname", txtNom.Text.Trim)
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim)
                    cmd.Parameters.AddWithValue("@emp", cmbEmploye.SelectedValue)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Dim sql As String = "REPLACE INTO access_granted (access_id, user_id) VALUES "
                    For Each item As ListViewItem In ListeGranted.Items
                        sql &= "('" & item.Text & "', @uid), "
                    Next

                    sql = sql.Trim
                    sql = sql.Remove(sql.Length - 1, 1)

                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Util.ShowMessage("Modification terminer avec success")
                    Close()

                Else
                    Database.Query("SELECT username FROM users WHERE username = '" & txtNom.Text & "'")
                    Dim result = Database.ExecuteResult
                    Dim found As Boolean = result.HasRows
                    result.Close()
                    Database.CloseConnection()
                    If found Then
                        Util.ShowMessage("Ce nom d'utilisateur à déjà été attribuer", 1)
                        Exit Sub
                    End If

                    cmd = Database.GetCommand
                    cmd.CommandText = "INSERT INTO users (username, password, employe_id) VALUE (@uname, @pass, @emp)"
                    cmd.Parameters.AddWithValue("@uname", txtNom.Text.Trim)
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim)
                    cmd.Parameters.AddWithValue("@emp", cmbEmploye.SelectedValue)
                    cmd.ExecuteNonQuery()
                    user_id = cmd.LastInsertedId
                    cmd.Dispose()

                    Dim sql As String = "REPLACE INTO access_granted (access_id, user_id) VALUES "
                    For Each item As ListViewItem In ListeGranted.Items
                        sql &= "('" & item.Text & "', @uid), "
                    Next

                    sql = sql.Trim
                    sql = sql.Remove(sql.Length - 1, 1)

                    cmd.Parameters.AddWithValue("@uid", user_id)
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Util.ShowMessage("Enregistrement effectuer avec success")
                    Close()


                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion à la base de donnée", 2)
                End If
            Finally
                Try
                    If Not IsNothing(cmd) Then
                        cmd.Dispose()
                        cmd.Connection.Close()
                    End If
                Catch ex As Exception

                End Try
            End Try

        End If
    End Sub

    Private Sub btnGrant_Click(sender As Object, e As EventArgs) Handles btnGrant.Click
        For Each item As ListViewItem In ListAccess.SelectedItems
            ListeGranted.Items.Add(item.Clone)
            ListAccess.Items.Remove(item)
        Next
    End Sub

    Private Sub btnRevoke_Click(sender As Object, e As EventArgs) Handles btnRevoke.Click
        For Each item As ListViewItem In ListeGranted.SelectedItems
            ListAccess.Items.Insert(CInt(item.SubItems(2).Text), item.Clone)
            ListeGranted.Items.Remove(item)
        Next
    End Sub



End Class