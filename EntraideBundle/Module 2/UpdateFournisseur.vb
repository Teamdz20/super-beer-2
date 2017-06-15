Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class UpdateFournisseur

    Dim fournisseurTable As FournisseursTable = New FournisseursTable

    Public id_fournisseur As Integer = 0

    Private Sub UpdateFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbCode, "SELECT id, code FROM  fournisseurs", "id", "code")
        Util.PopulateCombo(cmbCategorie, " SELECT id, nom FROM categorie_donneurs", "id", "nom")
    End Sub

    Private Sub chkPredef_CheckedChanged(sender As Object, e As EventArgs) Handles chkPredef.CheckedChanged
        If chkPredef.Checked Then
            chkAll.Checked = False
            ListeFournisseur.Columns.Item(9).Width = 0
            ListeFournisseur.Columns.Item(10).Width = 0
            ListeFournisseur.Columns.Item(11).Width = 0
            ListeFournisseur.Columns.Item(12).Width = 0
            ListeFournisseur.Columns.Item(13).Width = 0
            ListeFournisseur.Columns.Item(14).Width = 0
            ListeFournisseur.Columns.Item(15).Width = 0
        Else
            chkAll.Checked = True
        End If

    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            chkPredef.Checked = False
            ListeFournisseur.Columns.Item(9).Width = 160
            ListeFournisseur.Columns.Item(10).Width = 160
            ListeFournisseur.Columns.Item(11).Width = 160
            ListeFournisseur.Columns.Item(12).Width = 160
            ListeFournisseur.Columns.Item(13).Width = 160
            ListeFournisseur.Columns.Item(14).Width = 160
            ListeFournisseur.Columns.Item(15).Width = 160
        Else
            chkPredef.Checked = True
        End If
    End Sub

    Public Sub Recherche(Optional ByVal ByDate As Boolean = True, Optional ByVal byNom As Boolean = False, Optional ByVal byCode As Boolean = False)
        Dim liste As List(Of FournisseurEntity) = New List(Of FournisseurEntity)

        If byCode = True Then
            liste = fournisseurTable.getByCode(cmbCode.Text)
        ElseIf byNom = True And byCode = False And ByDate = False Then
            liste = fournisseurTable.GetByNom(cmbDu.Value, cmbAu.Value, txtNom.Text)
        ElseIf byNom = False And byCode = False Then
            liste = fournisseurTable.GetByDate(cmbDu.Value, cmbAu.Value)
        End If


        ListeFournisseur.Items.Clear()
        For Each elem As FournisseurEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom)
            item.SubItems.Add(elem.nom_representant)
            item.SubItems.Add(elem.adresse)
            item.SubItems.Add(elem.email)
            item.SubItems.Add(elem.created)
            item.SubItems.Add(elem.code)
            item.SubItems.Add(elem.tel1)
            item.SubItems.Add(elem.tel2)
            item.SubItems.Add(elem.CategorieFournisseur.Nom)
            item.SubItems.Add(elem.site)
            item.SubItems.Add(elem.domaine_business)
            item.SubItems.Add(elem.classification_prix)
            item.SubItems.Add(elem.note)
            item.SubItems.Add(elem.poste)
            item.SubItems.Add(elem.produit)

            ListeFournisseur.Items.Add(item)
        Next
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        If txtNom.Text.Trim.Length > 0 And cmbCode.Text.Trim.Length <= 0 Then
            Recherche(False, True, False)
        ElseIf cmbCode.Text.Trim.Length > 0 Then
            Recherche(False, False, True)
        ElseIf txtNom.Text.Trim.Length <= 0 And cmbCode.Text.Trim.Length <= 0 Then
            Recherche(True, False, False)
        End If
    End Sub

    Private Sub ListeFournisseur_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListeFournisseur.ItemSelectionChanged
        If e.IsSelected Then

            With ListeFournisseur.Items(e.ItemIndex)
                txtNomSociete.Text = .SubItems(1).Text
                txtNomRepresentant.Text = .SubItems(2).Text
                txtAdresse.Text = .SubItems(3).Text
                txtMail.Text = .SubItems(4).Text
                dt_date.Value = .SubItems(5).Text
                cmbCode.Text = .SubItems(6).Text
                txtPhone1.Text = .SubItems(7).Text
                txtPhone2.Text = .SubItems(8).Text
                cmbCategorie.SelectedValue = .SubItems(9).Text
                txtSite.Text = .SubItems(10).Text
                txtDomaine.Text = .SubItems(11).Text
                cmbClassification.Text = .SubItems(12).Text
                txtNote.Text = .SubItems(13).Text
                txtPoste.Text = .SubItems(14).Text
                txtProduit.Text = .SubItems(15).Text
                id_fournisseur = .SubItems(0).Text

            End With
        End If
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAdresse.Text = "" Or txtMail.Text = "" Or txtNomSociete.Text = "" Or txtNomRepresentant.Text = "" Or txtPhone1.Text = "" Or txtPoste.Text = "" Or txtPoste.Text = "" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Dim execute As Long = 0
            execute = fournisseurTable.Update(Me)
            If execute = 0 Then
                Util.ShowMessage(Me, "Mise à jour non effectuée", 1)
            Else
                Util.ShowMessage(Me, "Mise à jour effectuée avec succès", 0)
                Util.EmptyForm(GroupBox4)
                Util.EmptyForm(GroupBox3)
                Recherche()
            End If

        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class