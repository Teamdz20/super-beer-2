Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db

Public Class Materiel

    'Public mode_obtention As String = "DON"

    'Public departement_id As String = "1"

    'Public code_depense_id As String = MaterielsTable.TYPE_DEPENSE_ID

    'Public activite_id As String = "1"

    Private Sub Responive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim pos As New Point
        pos.X = (Me.Width - PanelContainer.Width) / 2
        pos.Y = (Me.Height - PanelContainer.Height) / 2
        PanelContainer.Location = pos
    End Sub

    Private Sub Materiel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbTypeMateriel, "SELECT id, nom FROM type_materiels", "id", "nom")
        Util.PopulateCombo(cmbCodeDepense, "SELECT id, code FROM code_depenses", "id", "code")
        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)
        'Util.PopulateCombo(cmbActivite, "SELECT id, nom FROM activite_financiers", "id", "nom")
        Util.PopulateCombo(cmbRecuPar, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbCategorieDonneur, "SELECT id, nom FROM categorie_donneurs", "id", "nom")

        LoadDonneur()
        LoadFounisseur()
        'cmbDepartement.SelectedValue = departement_id
        'cmbCodeDepense.SelectedValue = code_depense_id
        'cmbActivite.SelectedValue = activite_id
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbTypeMateriel.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le type de materiel", 1)
            If txtMarque.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez entrer la marque", 1)
            End If
        Else

            Using trans As EntraideOrm.LUNA.LunaTransactionBox = EntraideOrm.LUNA.LunaContext.CreateTransactionBox
                trans.TransactionBegin()

                Try
                    Dim ref_id As Integer = 0

                    If ckDon.Checked Then
                        Dim dEntity As DonEntity = New DonEntity
                        dEntity.donneur_id = cmbCodeDonneur.SelectedValue
                        dEntity.type_don = DonEntity.TYPE_MATERIEL
                        dEntity.restriction = "SANS"
                        dEntity.activite_menee = txtActivite.Text.Trim
                        dEntity.departement_id = cmbDepartement.SelectedValue
                        dEntity.created = cmbDate.Value
                        dEntity.user_id = My.Settings.user_id
                        ref_id = dEntity.Save
                    Else
                        Dim achat As AchatEntity = New AchatEntity
                        achat.fournisseur_id = cmbCodeFournisseur.SelectedValue
                        achat.prix_achat = txtPrixAchat.Text
                        achat.num_facture = txtNumFacture.Text
                        achat.code_depense_id = cmbCodeDepense.SelectedValue
                        achat.cout = txtCout.Text
                        achat.created = cmbDate.Value
                        achat.user_id = My.Settings.user_id
                        ref_id = achat.Save
                    End If

                    Dim theEntity As MaterielEntity = New MaterielEntity

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
                    theEntity.activite_id = txtActivite.Text.Trim
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

                    Dim materiel_id As Integer = theEntity.Save

                    If materiel_id > 0 AndAlso ref_id > 0 Then
                        trans.TransactionCommit()
                        Util.ShowMessage(Me, "Enregistrement effectuer avec succèss")
                        Close()
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



    Private Sub ckDon_CheckedChanged(sender As Object, e As EventArgs) Handles ckDon.CheckedChanged
        GroupDonneur.Enabled = ckDon.Checked
    End Sub

    Private Sub ckAchat_CheckedChanged(sender As Object, e As EventArgs) Handles ckAchat.CheckedChanged
        GroupFournisseur.Enabled = ckAchat.Checked
        GroupPrix.Enabled = ckAchat.Checked
    End Sub


End Class