Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class ListeDepartement

    Dim revTable As DepartementsTable = New DepartementsTable

    Public id_departement As Integer = 0

    Private Sub UpdateDepartement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RechercheAll()
    End Sub

    Public Sub Recherche()
        Dim liste As List(Of DepartementEntity) = New List(Of DepartementEntity)
        liste = revTable.getByName(txtSearch.Text)
        ListeDepartements.Items.Clear()
        For Each elem As DepartementEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)

            ListeDepartements.Items.Add(item)
        Next

    End Sub
    Public Sub RechercheAll()
        Dim liste As List(Of DepartementEntity) = New List(Of DepartementEntity)
        liste = revTable.GetAll
        ListeDepartements.Items.Clear()
        For Each elem As DepartementEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)

            ListeDepartements.Items.Add(item)
        Next

    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            RechercheAll()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Recherche()
    End Sub

    Private Sub TriggerUpdate()
        If ListeDepartements.SelectedItems.Count > 0 Then
            With ListeDepartements.SelectedItems(0)
                Dim form As New Departement
                form.txtNom.Text = .SubItems(1).Text
                form.id = .SubItems(0).Text
                form.Text = "DEPARTEMENTS : MODIFICATION"
                form.ShowDialog()
                RechercheAll()
            End With
        Else
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim form As New Departement
        form.ShowDialog()
        RechercheAll()
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        TriggerUpdate()
    End Sub

    Private Sub ListeDepartements_ItemActivate(sender As Object, e As EventArgs) Handles ListeDepartements.ItemActivate
        TriggerUpdate()
    End Sub
End Class