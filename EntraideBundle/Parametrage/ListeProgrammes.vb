Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class ListeProgrammes

    Private Sub LoadData(Optional search As Boolean = False)
        Dim pTable As ProgrammesTable = New ProgrammesTable

        Dim list_programs As List(Of ProgrammeEntity) = New List(Of ProgrammeEntity)

        If search Then
            list_programs = pTable.GetByName(txtSearch.Text.Trim)
        Else
            list_programs = pTable.GetAll
        End If

        ListProgrammes.Items.Clear()
        Dim iter As Integer = 1

        For Each entity As ProgrammeEntity In list_programs
            Dim item As New ListViewItem(entity.id)
            item.SubItems.Add(entity.nom)
            item.SubItems.Add(entity.code)

            If iter = 4 Then
                item.BackColor = Color.AliceBlue
                iter = 0
            End If

            ListProgrammes.Items.Add(item)
            iter += 1
        Next
    End Sub

    Private Sub ListeProgrammes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim.Length > 0 Then
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim form As New Programmes
        form.ShowDialog()
        LoadData()
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        TriggerSearch()
    End Sub

    Private Sub TriggerSearch()
        If ListProgrammes.SelectedItems.Count > 0 Then
            With ListProgrammes.SelectedItems(0)
                Dim form As New Programmes
                form.id = .SubItems(0).Text
                form.txtNom.Text = .SubItems(1).Text
                form.txtCode.Text = .SubItems(2).Text
                form.Text = "PROGRAMMES : EDITION"
                form.ShowDialog()
                LoadData()
            End With
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class