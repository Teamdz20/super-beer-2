Imports EntraideBundle.Db

Public Class ListeGeneration

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Using f As New Generation
            f.ShowDialog()
            If f.id.Length > 0 Then
                txtSearch.Text = ""
                LoadData()
            End If
        End Using
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        If ListGeneration.SelectedItems.Count > 0 Then
            Using f As New Generation
                With ListGeneration.SelectedItems(0)
                    f.id = .Text
                    f.txtLibelle.Text = .SubItems(1).Text
                    f.txtDescription.Text = .SubItems(2).Text
                End With
                f.Text = "GENERATION : MISE A JOUR"
                f.ShowDialog()
                If f.id.Length > 0 Then
                    txtSearch.Text = ""
                    LoadData()
                End If
            End Using
        Else
            Beep()
        End If
    End Sub

    Private Sub LoadData(Optional filter As Boolean = False)
        Try
            ListGeneration.Items.Clear()

            If filter Then
                Database.Query("SELECT id, libelle, description FROM generations WHERE libelle LIKE '" & Util.E(txtSearch.Text.Trim) & "%'")
            Else
                Database.Query("SELECT id, libelle, description FROM generations")
            End If

            Dim result = Database.ExecuteResult

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)

                ListGeneration.Items.Add(item)
            End While

            result.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        Finally
            Database.CloseConnection()
        End Try
    End Sub

    Private Sub ListeGeneration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim.Length > 0 Then
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        txtSearch.Text = ""
        LoadData()
    End Sub
End Class