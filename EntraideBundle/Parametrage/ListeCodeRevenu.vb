Imports EntraideBundle.Db

Public Class ListeCodeRevenu

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Using f As New CodeRevenu
            f.ShowDialog()
            If f.id.Length > 0 Then
                txtSearch.Clear()
                LoadData()
            End If
        End Using
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        If ListCodeRevenu.SelectedItems.Count > 0 Then
            Using f As New CodeRevenu
                With ListCodeRevenu.SelectedItems(0)
                    f.id = .Text
                    f.txtNom.Text = .SubItems(1).Text
                    f.txtCode.Text = .SubItems(2).Text
                End With
                f.ShowDialog()
                If f.id.Length > 0 Then
                    txtSearch.Clear()
                    LoadData()
                End If
            End Using
        Else
            Beep()
        End If
    End Sub


    Private Sub LoadData(Optional byFilter As Boolean = False)
        Try
            If byFilter Then
                Database.Query("SELECT id, nom, code FROM activite_financiers WHERE nom LIKE '" & Util.E(txtSearch.Text.Trim) & "%'")
            Else
                Database.Query("SELECT id, nom, code FROM activite_financiers")
            End If

            Dim result = Database.ExecuteResult

            ListCodeRevenu.Items.Clear()

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(result.GetValue(2).ToString)

                ListCodeRevenu.Items.Add(item)
            End While

            result.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        End Try
    End Sub


    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        txtSearch.Clear()
        LoadData()
    End Sub

    Private Sub ListeCodeRevenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim.Length > 0 Then
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub
End Class