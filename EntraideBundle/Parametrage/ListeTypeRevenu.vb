Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class ListeTypeRevenu


    Private Sub LoadData(Optional search As Boolean = False)

        Dim agrsTable As TypeAgrsTable = New TypeAgrsTable
        Dim list_agrs As List(Of TypeAgrEntity) = New List(Of TypeAgrEntity)

        If search Then
            list_agrs = agrsTable.GetByName(txtSearch.Text.Trim)
        Else
            list_agrs = agrsTable.GetAll
        End If

        ListTypeRevenu.Items.Clear()
        Dim iter As Integer = 1

        For Each entity As TypeAgrEntity In list_agrs
            Dim item As New ListViewItem(entity.id)
            item.SubItems.Add(entity.nom)

            If iter = 4 Then
                item.BackColor = Color.AliceBlue
                iter = 0
            End If
            ListTypeRevenu.Items.Add(item)
            iter += 1
        Next

    End Sub

    Private Sub ListeTypeRevenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim.Length > 0 Then
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Using form As New TypeRevenu
            form.ShowDialog()
            LoadData()
        End Using
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        TriggerSearch()
    End Sub


    Private Sub TriggerSearch()
        If ListTypeRevenu.SelectedItems.Count > 0 Then
            With ListTypeRevenu.SelectedItems(0)
                Using form As New TypeRevenu
                    form.id = .SubItems(0).Text
                    form.txtNom.Text = .SubItems(1).Text
                    form.ShowDialog()
                    LoadData()
                End Using
            End With
        End If
    End Sub
End Class