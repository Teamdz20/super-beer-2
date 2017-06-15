Imports EntraideBundle.Db.Tables

Public Class ListeTypeFormations

    Public id_type As Integer = 0

    Dim listeTable As TypeFormationsTable = New TypeFormationsTable

    Private Sub UpdateTypeFormation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RechercheAll()
    End Sub

    Public Sub Recherche()
        Dim liste As List(Of TypeFormationEntity) = New List(Of TypeFormationEntity)
        liste = listeTable.GetByName(txtSearch.Text.Trim)
        ListeTypeformation.Items.Clear()
        For Each elem As TypeFormationEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)
            item.SubItems.Add(elem.Montant)
            ListeTypeformation.Items.Add(item)
        Next
    End Sub

    Public Sub RechercheAll()
        Dim liste As List(Of TypeFormationEntity) = New List(Of TypeFormationEntity)
        liste = listeTable.GetAll
        ListeTypeformation.Items.Clear()
        For Each elem As TypeFormationEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)
            item.SubItems.Add(elem.Montant)
            ListeTypeformation.Items.Add(item)
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
        If ListeTypeformation.SelectedItems.Count > 0 Then
            With ListeTypeformation.SelectedItems(0)
                Dim form As New TypeFormation
                form.txtNom.Text = .SubItems(1).Text
                form.txtMontant.Text = .SubItems(2).Text
                form.id = .SubItems(0).Text
                form.Text = "TYPE DE FORMATION : MODIFICATION"
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
        Dim form As New TypeFormation
        form.ShowDialog()
        RechercheAll()
    End Sub
End Class