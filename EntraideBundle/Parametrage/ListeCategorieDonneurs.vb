Imports EntraideBundle.Db.Tables

Public Class ListeCategorieDonneurs

    Dim catTable As CategorieDonneursTable = New CategorieDonneursTable

    Public id_categorie As Integer = 0

    Public Sub Recherche()
        Dim liste As List(Of CategorieDonneurEntity) = New List(Of CategorieDonneurEntity)
        liste = catTable.GetByName(txtSearch.Text)
        ListeCategorie.Items.Clear()
        For Each elem As CategorieDonneurEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)
            ListeCategorie.Items.Add(item)
        Next
    End Sub

    Public Sub LoadData()
        Dim liste As List(Of CategorieDonneurEntity) = New List(Of CategorieDonneurEntity)
        liste = catTable.GetAll
        ListeCategorie.Items.Clear()
        For Each elem As CategorieDonneurEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)

            ListeCategorie.Items.Add(item)
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Recherche()
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            LoadData()
        End If
    End Sub

    Private Sub UpdateCategorieDonneur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        chkAll.Checked = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim form As New CategorieDonneur
        form.ShowDialog()
        LoadData()
    End Sub


    Private Sub TriggerUpdate()
        If ListeCategorie.SelectedItems.Count > 0 Then
            With ListeCategorie.SelectedItems(0)
                Dim form As New CategorieDonneur
                form.txtNom.Text = .SubItems(1).Text
                form.id = .SubItems(0).Text
                form.Text = "CATEGORIE DONNEUR : MODIFICATION"
                form.ShowDialog()
                LoadData()
            End With
        Else
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
        End If
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        TriggerUpdate()
    End Sub

    Private Sub ListeCategorie_ItemActivate(sender As Object, e As EventArgs) Handles ListeCategorie.ItemActivate
        TriggerUpdate()
    End Sub
End Class