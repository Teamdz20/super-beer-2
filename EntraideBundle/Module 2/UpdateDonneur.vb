Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class UpdateDonneur

    Dim dontable As DonneursTable = New DonneursTable

    Public id_donneur As Integer = 0

    Private Sub UpdateDonneur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbCode, "SELECT id, code FROM donneurs", "id", "code")
        Util.PopulateCombo(cmbCategorieDonneur, " SELECT id, nom FROM categorie_donneurs", "id", "nom")
    End Sub

    Public Sub Recherche(Optional ByVal ByDate As Boolean = True, Optional ByVal byNom As Boolean = False, Optional ByVal byCode As Boolean = False)
        Dim liste As List(Of DonneurEntity) = New List(Of DonneurEntity)

        If byCode = True Then
            liste = dontable.getByCode(cmbCode.Text)
        ElseIf byNom = True And byCode = False And ByDate = False Then
            liste = dontable.GetByNom(cmbDu.Value, cmbAu.Value, txtNom.Text)
        ElseIf byNom = False And byCode = False Then
            liste = dontable.GetBydate(cmbDu.Value, cmbAu.Value)
        End If

        ListeDonneur.Items.Clear()

        For Each elem As DonneurEntity In liste

            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom)
            item.SubItems.Add(elem.nom_representant)
            item.SubItems.Add(elem.adresse)
            item.SubItems.Add(elem.email)
            item.SubItems.Add(elem.date_donneur)
            item.SubItems.Add(elem.code)
            item.SubItems.Add(elem.tel1)
            item.SubItems.Add(elem.tel2)
            item.SubItems.Add(elem.CategorieDonneur.Nom)
            item.SubItems.Add(elem.site_internet)
            item.SubItems.Add(elem.restriction)
            item.SubItems.Add(elem.periode_sollicitation)
            item.SubItems.Add(elem.note_sollicitation)
            item.SubItems.Add(elem.poste)
            item.SubItems.Add(elem.type_don)

            ListeDonneur.Items.Add(item)
        Next
    End Sub


    Private Sub TriggerSearch()
        If txtNom.Text.Trim.Length > 0 And cmbCode.Text.Trim.Length <= 0 Then
            Recherche(False, True, False)
        ElseIf cmbCode.Text.Trim.Length > 0 Then
            Recherche(False, False, True)
        ElseIf txtNom.Text.Trim.Length <= 0 And cmbCode.Text.Trim.Length <= 0 Then
            Recherche(True, False, False)
        End If

    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        TriggerSearch()
    End Sub


    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If txtAdresse.Text = "" Or txtMail.Text = "" Or txtNomDonneur.Text = "" Or txtNomRepresentant.Text = "" Or txtPhone1.Text = "" Or txtPoste.Text = "" Or txtPoste.Text = "" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Dim execute As Long = 0
            execute = dontable.Update(Me)
            If execute = 0 Then
                Util.ShowMessage(Me, "Mise à jour non effectuée", 1)
                Util.EmptyForm(GroupBox4)
                Util.EmptyForm(GroupBox3)
                TriggerSearch()
            Else
                Util.ShowMessage(Me, "Mise à jour effectuée avec succès", 0)
                Recherche()
            End If

        End If
    End Sub

    Private Sub chkPredef_CheckedChanged(sender As Object, e As EventArgs) Handles chkPredef.CheckedChanged
        If chkPredef.Checked Then
            chkAll.Checked = False
            ListeDonneur.Columns.Item(9).Width = 0
            ListeDonneur.Columns.Item(10).Width = 0
            ListeDonneur.Columns.Item(11).Width = 0
            ListeDonneur.Columns.Item(12).Width = 0
            ListeDonneur.Columns.Item(13).Width = 0
            ListeDonneur.Columns.Item(14).Width = 0
            ListeDonneur.Columns.Item(15).Width = 0

        Else
            chkAll.Checked = True
        End If

    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            chkPredef.Checked = False
            ListeDonneur.Columns.Item(9).Width = 160
            ListeDonneur.Columns.Item(10).Width = 160
            ListeDonneur.Columns.Item(11).Width = 160
            ListeDonneur.Columns.Item(12).Width = 160
            ListeDonneur.Columns.Item(13).Width = 160
            ListeDonneur.Columns.Item(14).Width = 160
            ListeDonneur.Columns.Item(15).Width = 160
        Else
            chkPredef.Checked = True
        End If
    End Sub

    Private Sub ListeDonneur_ItemActivate(sender As Object, e As EventArgs) Handles ListeDonneur.ItemActivate
        If ListeDonneur.SelectedItems.Count = 0 Then
            Beep()
            Exit Sub
        End If
        With ListeDonneur.SelectedItems(0)
            txtNomDonneur.Text = .SubItems(1).Text
            txtNomRepresentant.Text = .SubItems(2).Text
            txtAdresse.Text = .SubItems(3).Text
            txtMail.Text = .SubItems(4).Text
            dt_date.Value = .SubItems(5).Text
            cmbCode.Text = .SubItems(6).Text
            txtPhone1.Text = .SubItems(7).Text
            txtPhone2.Text = .SubItems(8).Text
            cmbCategorieDonneur.SelectedValue = .SubItems(9).Text
            txtSite.Text = .SubItems(10).Text
            cmbProcedure.Text = .SubItems(11).Text
            txtPeriodeSollicitation.Text = .SubItems(12).Text
            txtNote.Text = .SubItems(13).Text
            txtPoste.Text = .SubItems(14).Text
            cmbTypeDon.Text = .SubItems(15).Text
            id_donneur = .SubItems(0).Text

        End With
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Close()
    End Sub

End Class