Imports EntraideBundle.Db

Public Class ListeUsers

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = location
    End Sub

    Sub LoadUsers()
        Try
            Database.Query("SELECT users.id, CONCAT_WS(' ', employes.nom, employes.prenom) AS employe, users.username, users.password, users.state, DATE_FORMAT(users.last_login, '%d/%m/%Y %H:%i:%s') AS last_login FROM users INNER JOIN employes ON users.employe_id = employes.id")

            Dim result = Database.ExecuteResult
            ListUser.Items.Clear()
            Dim iter As Integer = 1

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)

                Dim pass = result.GetValue(3).ToString
                Dim formatedPassword As String = pass(0).ToString & pass(1).ToString

                For Each a As Char In pass.Substring(2).ToCharArray
                    formatedPassword &= "*"
                Next

                item.SubItems.Add(formatedPassword)

                Dim status = result.GetBoolean(4)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                If status = True Then
                    item.SubItems.Add("Actif")
                Else
                    item.SubItems.Add("Désactivé")
                    item.BackColor = Color.Tan
                End If

                item.SubItems.Add(result.GetValue(5).ToString)
                item.SubItems.Add(result.GetValue(4))
                item.SubItems.Add(pass)

                ListUser.Items.Add(item)
                iter += 1
            End While

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

    Private Sub ListeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Util.setupFrame(Me)
        LoadUsers()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnToogleStatus_Click(sender As Object, e As EventArgs) Handles btnToogleStatus.Click
        If ListUser.SelectedItems.Count > 0 Then
            Try
                With ListUser.SelectedItems(0)

                    If .Text = "1" Then
                        Util.ShowMessage("Opération invalide pour cet utilisateur", 1)
                        Exit Sub
                    End If

                    If .SubItems(6).Text = "True" Then
                        Database.Query("UPDATE users SET state = 0 WHERE id = '" & .Text & "'")
                    Else
                        Database.Query("UPDATE users SET state = 1 WHERE id = '" & .Text & "'")
                    End If
                    Database.Execute()
                    Util.ShowMessage("Effectuer")
                    LoadUsers()
                End With
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            End Try


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListUser.SelectedItems.Count > 0 Then
            Dim form As New Users
            form.user_id = ListUser.SelectedItems(0).Text
            form.ShowDialog()
        End If
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim form As New Users
        form.ShowDialog()
    End Sub
End Class