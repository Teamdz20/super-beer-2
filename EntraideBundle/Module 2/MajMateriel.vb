Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db

Public Class MajMateriel

    Dim matTable As MaterielsTable = New MaterielsTable

    Dim liste_materiels As List(Of MaterielEntity) = New List(Of MaterielEntity)

    Dim current_index As Integer = -1

    Private Sub Responive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim pos As New Point
        pos.X = (Me.Width - PanelContainer.Width) / 2
        pos.Y = ((Me.Height - PanelContainer.Height) / 2) + 40
        PanelContainer.Location = pos
    End Sub


    Private Sub Search(Optional byDate As Boolean = False)

        current_index = -1

        liste_materiels.Clear()

        Try
            If byDate Then
                liste_materiels = matTable.GetByDate(cmbRechDate.Value)
            End If


            ListMateriel.Items.Clear()
            Dim iter As Integer = 1
            Dim index As Integer = 0

            For Each theEntity As MaterielEntity In liste_materiels
                Dim item As New ListViewItem(theEntity.id)
                item.SubItems.Add(theEntity.TypeMateriel.nom)
                item.SubItems.Add(theEntity.marque)
                item.SubItems.Add(theEntity.mode_obtention)
                item.SubItems.Add(theEntity.prix_achat)
                item.SubItems.Add(theEntity.description)
                item.SubItems.Add(index)

                If iter = 4 Then
                    iter = 0
                    item.BackColor = Color.AliceBlue
                End If

                ListMateriel.Items.Add(item)
                iter += 1
                index += 1
            Next

        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message)
        End Try
    End Sub

    Private Sub MajMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbTypeMateriel, "SELECT id, nom FROM type_materiels", "id", "nom")
        Util.PopulateCombo(cmbCodeDepense, "SELECT id, code FROM code_depenses", "id", "code")
        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)
        'Util.PopulateCombo(cmbActivite, "SELECT id, nom FROM activite_financiers", "id", "nom")
        Util.PopulateCombo(cmbRecuPar, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbCategorieDonneur, "SELECT id, nom FROM categorie_donneurs", "id", "nom")

        LoadDonneur()
        LoadFounisseur()
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub TriggerSearch()
        If ckDate.Checked Then
            Search(True)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TriggerSearch()
    End Sub

    Sub RefreshListe(ByRef item As ListViewItem)
        For Each i As ListViewItem In ListMateriel.Items
            i.BackColor = Color.White
        Next
        item.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub SelectItem()
        If ListMateriel.SelectedItems.Count = 0 Then
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
            Exit Sub
        End If

        RefreshListe(ListMateriel.SelectedItems(0))

        Dim index As Integer = CInt(ListMateriel.SelectedItems(0).SubItems(6).Text)
        Dim theEntity As MaterielEntity = liste_materiels.Item(index)

        ckDon.Checked = True
        If theEntity.mode_obtention = "ACHAT" Then
            ckAchat.Checked = True
        End If

        cmbDate.Value = theEntity.created
        cmbTypeMateriel.SelectedValue = theEntity.type_materiel_id
        txtMarque.Text = theEntity.marque
        txtDescription.Text = theEntity.description
        ckNeuf.Checked = theEntity.neuf
        ckDejaUsed.Checked = theEntity.deja_utiliser
        ckTresBonEtas.Checked = theEntity.tres_bon_etat
        ckQuelqueDef.Checked = theEntity.avec_defaut
        ckMauvaisEtas.Checked = theEntity.mauvaise_etat
        txtNote.Text = theEntity.note_etat
        cmbDepartement.SelectedValue = theEntity.departement_id
        txtActivite.Text = theEntity.activite
        cmbRecuPar.SelectedValue = theEntity.employe_id

        radOui.Checked = True
        If theEntity.amortissement_necessaire = "NOM" Then
            radNon.Checked = True
        End If
        txtAnneeAmor.Text = theEntity.annee_amortissement
        txtMontantAn.Text = theEntity.montant_par_an

        If theEntity.mode_obtention = "DON" Then
            cmbCodeDonneur.SelectedValue = theEntity.Don.donneur_id
            cmbCodeFournisseur.SelectedValue = "0"
            txtNumFacture.Clear()
            txtPrixAchat.Text = "0"
            cmbCodeDepense.SelectedValue = "0"
            txtCout.Text = "0"
        Else
            txtNumFacture.Text = theEntity.Achat.num_facture
            txtPrixAchat.Text = theEntity.Achat.prix_achat
            cmbCodeDepense.SelectedValue = theEntity.Achat.code_depense_id
            txtCout.Text = theEntity.Achat.cout
            cmbCodeFournisseur.SelectedValue = theEntity.Achat.fournisseur_id
            cmbCodeDonneur.SelectedValue = "0"
        End If

        current_index = index

    End Sub

    Private Sub ListMateriel_ItemActivate(sender As Object, e As EventArgs) Handles ListMateriel.ItemActivate
        SelectItem()
    End Sub


    Private Sub ckDon_CheckedChanged(sender As Object, e As EventArgs) Handles ckDon.CheckedChanged
        GroupDonneur.Enabled = ckDon.Checked
        If ckDon.Checked = False Then
            cmbCodeDonneur.SelectedValue = "0"
        End If
    End Sub

    Private Sub ckAchat_CheckedChanged(sender As Object, e As EventArgs) Handles ckAchat.CheckedChanged
        GroupFournisseur.Enabled = ckAchat.Checked
        GroupPrix.Enabled = ckAchat.Checked
    End Sub

    Private Sub LoadDonneur()
        Dim dt As DataTable = Database.GetDataTable("SELECT id, code, nom FROM donneurs")
        Dim row As DataRow = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbCodeDonneur.DataSource = dt
        cmbCodeDonneur.ValueMember = "id"
        cmbCodeDonneur.DisplayMember = "code"

        cmbNomDodeur.DataSource = dt
        cmbNomDodeur.ValueMember = "id"
        cmbNomDodeur.DisplayMember = "nom"
    End Sub

    Private Sub LoadFounisseur()
        Dim dt As DataTable = Database.GetDataTable("SELECT id, code, nom FROM fournisseurs")
        Dim row As DataRow = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)


        cmbCodeFournisseur.DataSource = dt
        cmbCodeFournisseur.ValueMember = "id"
        cmbCodeFournisseur.DisplayMember = "code"

        cmbNomFournisseur.DataSource = dt
        cmbNomFournisseur.ValueMember = "id"
        cmbNomFournisseur.DisplayMember = "nom"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbTypeMateriel.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le type de materiel", 1)
            If txtMarque.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez entrer la marque", 1)
            End If
        Else

            Using trans As EntraideOrm.LUNA.LunaTransactionBox = EntraideOrm.LUNA.LunaContext.CreateTransactionBox
                trans.TransactionBegin()

                Dim theEntity As MaterielEntity = liste_materiels.Item(current_index)

                Try
                    Dim ref_id As Integer = 0

                    If ckDon.Checked Then
                        Dim dEntity As DonEntity = theEntity.Don
                        dEntity.donneur_id = cmbCodeDonneur.SelectedValue
                        dEntity.type_don = DonEntity.TYPE_MATERIEL
                        dEntity.restriction = "SANS"
                        'dEntity.activite_financier_id = cmbActivite.SelectedValue
                        dEntity.departement_id = cmbDepartement.SelectedValue
                        dEntity.created = cmbDate.Value
                        dEntity.user_id = My.Settings.user_id
                        ref_id = dEntity.Save
                    Else
                        Dim achat As AchatEntity = theEntity.Achat
                        achat.fournisseur_id = cmbCodeFournisseur.SelectedValue
                        achat.prix_achat = txtPrixAchat.Text
                        achat.num_facture = txtNumFacture.Text
                        achat.code_depense_id = cmbCodeDepense.SelectedValue
                        achat.cout = txtCout.Text
                        achat.created = cmbDate.Value
                        achat.user_id = My.Settings.user_id
                        ref_id = achat.Save
                    End If

                    Dim mode_obtention As String = "DON"
                    If ckAchat.Checked Then
                        mode_obtention = "ACHAT"
                    End If
                    theEntity.mode_obtention = mode_obtention

                    theEntity.created = cmbDate.Value
                    theEntity.type_materiel_id = cmbTypeMateriel.SelectedValue
                    theEntity.marque = txtMarque.Text.Trim
                    theEntity.libelle = txtMarque.Text.Trim
                    theEntity.description = txtDescription.Text.Trim
                    theEntity.num_facture = txtNumFacture.Text.Trim
                    theEntity.prix_achat = txtPrixAchat.Text

                    theEntity.departement_id = cmbDepartement.SelectedValue
                    theEntity.activite = txtActivite.Text.Trim
                    theEntity.employe_id = cmbRecuPar.SelectedValue
                    theEntity.neuf = ckNeuf.Checked
                    theEntity.deja_utiliser = ckDejaUsed.Checked
                    theEntity.tres_bon_etat = ckTresBonEtas.Checked
                    theEntity.avec_defaut = ckQuelqueDef.Checked
                    theEntity.mauvaise_etat = ckMauvaisEtas.Checked
                    theEntity.note_etat = txtNote.Text.Trim

                    Dim amortissement As String = "OUI"
                    If radNon.Checked Then
                        amortissement = "NON"
                    End If

                    theEntity.amortissement_necessaire = amortissement
                    theEntity.annee_amortissement = txtAnneeAmor.Text
                    theEntity.montant_par_an = txtMontantAn.Text
                    theEntity.ref_obtention_id = ref_id
                    theEntity.IsChanged = True

                    Dim materiel_id As Integer = theEntity.Save

                    If materiel_id > 0 AndAlso ref_id > 0 Then
                        trans.TransactionCommit()
                        Util.ShowMessage(Me, "Modification effectuer avec succèss")
                        Util.EmptyForm(MetroTabControl1)
                        TriggerSearch()
                    Else
                        Util.ShowMessage(Me, "Une erreur est survenu veuillez reessayer plus tard", 1)
                    End If

                Catch ex As Exception
                    trans.TransactionRollBack()
                    If My.Settings.app_debug_mode Then
                        Util.ShowMessage(ex.ToString, 2)
                    Else
                        Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                    End If
                End Try
            End Using
        End If
    End Sub
End Class