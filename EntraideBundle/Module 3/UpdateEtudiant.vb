Imports EntraideBundle.Db.Tables

Public Class UpdateEtudiant

    Public etudiant_id As Integer = -1

    Public paiement_id As Integer = -1

    Public revenu_id As Integer = -1

    Public formation_id As Integer = -1

    Private current_index As Integer = -1

    Private active_liste As List(Of EtudiantEntity) = New List(Of EtudiantEntity)

    Dim etudiantTable As EtudiantsTable = New EtudiantsTable

    Private Sub Recherche(Optional byName As Boolean = False, Optional byType As Boolean = False, Optional byDate As Boolean = True, Optional byCode As Boolean = False)

        If byName = False And byCode = False And byType = False Then
            active_liste = etudiantTable.GetByDate(dt_du.Value, dt_au.Value)
        ElseIf byType = True And byName = False And byCode = False Then
            active_liste = etudiantTable.GetByType(dt_du.Value, dt_au.Value, cmbRechType.SelectedValue.ToString)
        ElseIf byName = True And byType = True And byCode = False Then
            active_liste = etudiantTable.GetByNameType(dt_du.Value, dt_au.Value, txtNom.Text, cmbRechType.SelectedValue.ToString)
        ElseIf byName = True And byCode = False And byType = False Then
            active_liste = etudiantTable.GetByName(dt_du.Value, dt_au.Value, txtNom.Text)
        ElseIf byCode = True Then
            active_liste = etudiantTable.GetByCode(txtCode.Text)
        End If


        ListeEtudiants.Items.Clear()

        Dim index As Integer = 0

        Dim iter As Integer = 1

        For Each elem As EtudiantEntity In active_liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom)
            item.SubItems.Add(elem.prenom)
            item.SubItems.Add(FormatNumber(elem.Paiement.MontantP, 0) & " F")
            item.SubItems.Add(FormatNumber(elem.Revenu.Montant - elem.Paiement.MontantP, 0) & " F")
            item.SubItems.Add(elem.Paiement.TypePaiement)
            item.SubItems.Add(elem.code)
            item.SubItems.Add(elem.sexe)
            item.SubItems.Add(elem.situation_matri)
            item.SubItems.Add(elem.nombre_enfant)
            item.SubItems.Add(elem.lieu_naissance)
            item.SubItems.Add(elem.nationnalite)
            item.SubItems.Add(elem.adresse)
            item.SubItems.Add(elem.bp)
            item.SubItems.Add(elem.tel1)
            item.SubItems.Add(elem.tel2)
            item.SubItems.Add(elem.email)
            item.SubItems.Add(elem.autre_religion)
            item.SubItems.Add(elem.delit)
            item.SubItems.Add(elem.formation_recu)
            item.SubItems.Add(elem.niveau)
            item.SubItems.Add(elem.nom_urgence)
            item.SubItems.Add(elem.adresse_urgence)
            item.SubItems.Add(elem.phone_urgence)
            item.SubItems.Add(elem.mail_urgence)
            item.SubItems.Add(elem.type_emploie)
            item.SubItems.Add(elem.business)
            item.SubItems.Add(elem.type_business)
            item.SubItems.Add(elem.nombre_employe)
            item.SubItems.Add(elem.annexe)
            item.SubItems.Add(elem.Religion.Nom)
            item.SubItems.Add(elem.TypeFormationId.Nom)
            item.SubItems.Add(elem.Paiement.Id)
            item.SubItems.Add(elem.Revenu.Id)
            item.SubItems.Add(elem.Formation.id)
            item.SubItems.Add(elem.Revenu.Montant)
            item.SubItems.Add(elem.generation_id)
            item.SubItems.Add(index)

            If iter = 4 Then
                item.BackColor = Color.AliceBlue
                iter = 0
            End If

            ListeEtudiants.Items.Add(item)
            iter += 1
            index += 1
        Next
    End Sub


    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click

        If txtCode.Text.Trim.Length > 0 Then
            Recherche(False, False, False, True)
        ElseIf txtNom.Text.Trim.Length > 0 And cmbRechType.SelectedValue = "0" Then
            Recherche(True, False, False, False)
        ElseIf txtNom.Text.Trim.Length > 0 And cmbRechType.SelectedValue <> "0" Then
            Recherche(True, True, False, False)
        ElseIf cmbRechType.SelectedValue <> "0" And txtNom.Text.Trim.Length <= 0 Then
            Recherche(False, True, False, False)
        Else
            Recherche(False, False, True, False)
        End If
    End Sub

    Private Sub UpdateEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbRechType, "SELECT id, nom  FROM type_formation", "id", "nom")
        Util.PopulateCombo(cmbReligion, "SELECT id, nom FROM religions", "id", "nom")
        Util.PopulateCombo(cmbTypeFormation, "SELECT id, nom  FROM type_formations", "id", "nom")
        Util.PopulateCombo(cmbRechGeneration, "SELECT id, libelle FROM generations", "id", "libelle")
        Util.PopulateCombo(cmbGeneration, "SELECT id, libelle FROM generations", "id", "libelle")
    End Sub


    Private Sub ListeEtudiants_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListeEtudiants.ItemSelectionChanged
        If e.IsSelected Then
            Dim index As Integer = CInt(ListeEtudiants.Items(e.ItemIndex).SubItems(37).Text)
            Dim etudiant As EtudiantEntity = active_liste.Item(index)

            txtNomEtudiant.Text = etudiant.nom
            txtPrenom.Text = etudiant.prenom

            txtMontantPayer.Text = etudiant.Paiement.MontantP

            If etudiant.Paiement.TypePaiement = "espece" Then
                chkEspece.Checked = True
            ElseIf etudiant.Paiement.TypePaiement = "virement" Then
                chkVirement.Checked = True
            ElseIf etudiant.Paiement.TypePaiement = "cheque" Then
                chkCheque.Checked = True
            End If

            cmbSex.Text = etudiant.sexe
            cmbSituation.Text = etudiant.situation_matri
            txtNbreEnfant.Text = etudiant.nombre_enfant
            txtLieu.Text = etudiant.lieu_naissance
            txtNationalite.Text = etudiant.nationnalite
            txtAdresse.Text = etudiant.adresse
            txtBP.Text = etudiant.bp
            txtPhone1.Text = etudiant.tel1
            txtPhone2.Text = etudiant.tel2
            txtMail.Text = etudiant.email
            txtAutreReligion.Text = etudiant.autre_religion
            cmbDelit.Text = IIf(etudiant.delit.Length > 0, "Oui", "Non")
            txtDelit.Text = etudiant.delit
            If etudiant.delit.Trim.Length = 0 Then
                cmbDelit.Text = "Non"
            End If

            cmbTypeFormation.SelectedValue = etudiant.TypeFormationId.Id
            txtNiveauEtude.Text = etudiant.niveau
            txtNomUrgence.Text = etudiant.nom_urgence
            txtAdresseUrgence.Text = etudiant.adresse_urgence
            txtMailUrgence.Text = etudiant.mail_urgence
            txtPhoneUrgence.Text = etudiant.phone_urgence
            cmbBusiness.SelectedValue = etudiant.business
            txtTypeBusiness.Text = etudiant.type_business
            txtNombreEmployes.Text = etudiant.nombre_employe
            txtAnnexe.Text = etudiant.annexe
            cmbReligion.SelectedValue = etudiant.Religion.Id
            cmbGeneration.SelectedValue = etudiant.generation_id
            txtTypeFormation.Text = etudiant.formation_recu
            txtTypeEmploi.Text = etudiant.type_emploie
            paiement_id = etudiant.Paiement.Id
            revenu_id = etudiant.Revenu.Id
            formation_id = etudiant.Formation.id


            etudiant_id = etudiant.id
            txtCoutFormation.Text = etudiant.Revenu.Montant

            MetroTabControl1.SelectTab(1)


            If txtCoutFormation.Text = "" Or txtCoutFormation.Text = "0" Then
            Else
                txtMontantRestant.Text = CDbl(txtCoutFormation.Text.Trim.Trim("F")) - CDbl(txtMontantPayer.Text.Trim("F"))
            End If

        End If
    End Sub

    Private Sub chkEcrireExcellentFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireExcellentFr.CheckedChanged
        If chkEcrireExcellentFr.Checked Then
            chkEcrireDebutantFr.Enabled = False
            chkEcrireMoyenFr.Enabled = False
        Else : chkEcrireDebutantFr.Enabled = True
            chkEcrireMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireMoyenFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireMoyenFr.CheckedChanged
        If chkEcrireMoyenFr.Checked Then
            chkEcrireExcellentFr.Enabled = False
            chkEcrireDebutantFr.Enabled = False
        Else
            chkEcrireExcellentFr.Enabled = True
            chkEcrireDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireDebutantFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireDebutantFr.CheckedChanged
        If chkEcrireDebutantFr.Checked Then
            chkEcrireExcellentFr.Enabled = False
            chkEcrireMoyenFr.Enabled = False
        Else
            chkEcrireExcellentFr.Enabled = True
            chkEcrireMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteExcellentFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteExcellentFr.CheckedChanged
        If chkEcouteExcellentFr.Checked Then
            chkEcouterMoyenFr.Enabled = False
            chkEcouteDebutantFr.Enabled = False
        Else
            chkEcouterMoyenFr.Enabled = True
            chkEcouteDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcouterMoyenFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouterMoyenFr.CheckedChanged
        If chkEcouterMoyenFr.Checked Then
            chkEcouteDebutantFr.Enabled = False
            chkEcouteExcellentFr.Enabled = False
        Else
            chkEcouteDebutantFr.Enabled = True
            chkEcouteExcellentFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteDebutantFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteDebutantFr.CheckedChanged
        If chkEcouteDebutantFr.Checked Then
            chkEcouteExcellentFr.Enabled = False
            chkEcouterMoyenFr.Enabled = False
        Else
            chkEcouteExcellentFr.Enabled = True
            chkEcouterMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkParlerExcellentFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerExcellentFr.CheckedChanged
        If chkParlerExcellentFr.Checked Then
            chkParlerMoyenFr.Enabled = False
            chkParlerDebutantFr.Enabled = False
        Else
            chkParlerMoyenFr.Enabled = True
            chkParlerDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkParlerMoyenFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerMoyenFr.CheckedChanged
        If chkParlerMoyenFr.Checked Then
            chkParlerExcellentFr.Enabled = False
            chkParlerDebutantFr.Enabled = False
        Else
            chkParlerExcellentFr.Enabled = True
            chkParlerDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkParlerDebutantFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerDebutantFr.CheckedChanged
        If chkParlerDebutantFr.Checked Then
            chkParlerExcellentFr.Enabled = False
            chkParlerMoyenFr.Enabled = False
        Else
            chkParlerExcellentFr.Enabled = True
            chkParlerMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireExcellentEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireExcellentEN.CheckedChanged
        If chkEcrireExcellentEN.Checked Then
            chkEcrireDebEN.Enabled = False
            chkEcrireMoyenEN.Enabled = False
        Else : chkEcrireDebEN.Enabled = True
            chkEcrireMoyenEN.Enabled = True
        End If

    End Sub

    Private Sub chkEcrireMoyenEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireMoyenEN.CheckedChanged
        If chkEcrireMoyenEN.Checked Then
            chkEcrireExcellentEN.Enabled = False
            chkEcrireDebEN.Enabled = False
        Else
            chkEcrireExcellentEN.Enabled = True
            chkEcrireDebEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireDebEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireDebEN.CheckedChanged
        If chkEcrireDebEN.Checked Then
            chkEcrireExcellentEN.Enabled = False
            chkEcrireMoyenEN.Enabled = False
        Else
            chkEcrireExcellentEN.Enabled = True
            chkEcrireMoyenEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteExEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteExEN.CheckedChanged
        If chkEcouteExEN.Checked Then
            chkEcouteMoyenEN.Enabled = False
            chkEcouteDebEN.Enabled = False
        Else
            chkEcouteMoyenEN.Enabled = True
            chkEcouteDebEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteMoyenEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteMoyenEN.CheckedChanged
        If chkEcouteMoyenEN.Checked Then
            chkEcouteDebEN.Enabled = False
            chkEcouteExEN.Enabled = False
        Else
            chkEcouteDebEN.Enabled = True
            chkEcouteExEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteDebEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteDebEN.CheckedChanged
        If chkEcouteDebEN.Checked Then
            chkEcouteExEN.Enabled = False
            chkEcouteMoyenEN.Enabled = False
        Else
            chkEcouteExEN.Enabled = True
            chkEcouteMoyenEN.Enabled = True
        End If
    End Sub

    Private Sub chkParlerExEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerExEN.CheckedChanged
        If chkParlerExEN.Checked Then
            chkParlerMoyenEN.Enabled = False
            chkParlerDebEN.Enabled = False
        Else
            chkParlerMoyenEN.Enabled = True
            chkParlerDebEN.Enabled = True

        End If
    End Sub

    Private Sub chkParlerMoyenEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerMoyenEN.CheckedChanged
        If chkParlerMoyenEN.Checked Then
            chkParlerExEN.Enabled = False
            chkParlerDebEN.Enabled = False
        Else
            chkParlerExEN.Enabled = True
            chkParlerDebEN.Enabled = True
        End If
    End Sub

    Private Sub chkParlerDebEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerDebEN.CheckedChanged
        If chkParlerDebEN.Checked Then
            chkParlerExEN.Enabled = False
            chkParlerMoyenEN.Enabled = False
        Else
            chkParlerExEN.Enabled = True
            chkParlerMoyenEN.Enabled = True
        End If
    End Sub

    Private Sub cmbBusiness_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBusiness.SelectedIndexChanged
        If cmbBusiness.Text = "Non" Then
            lbTypeBusiness.Visible = False
            lbAnnexe.Visible = False
            lbNbreEmploye.Visible = False

            txtTypeBusiness.Visible = False
            txtNombreEmployes.Visible = False
            txtAnnexe.Visible = False
        Else
            lbTypeBusiness.Visible = True
            lbAnnexe.Visible = True
            lbNbreEmploye.Visible = True

            txtTypeBusiness.Visible = True
            txtNombreEmployes.Visible = True
            txtAnnexe.Visible = True
        End If
    End Sub

    Private Sub cmbDelit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDelit.SelectedIndexChanged
        If cmbDelit.Text = "Non" Then
            lbnomDel.Visible = False
            txtDelit.Visible = False

        Else
            lbnomDel.Visible = True
            txtDelit.Visible = True
        End If
    End Sub

    Private Sub cmbFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormation.SelectedIndexChanged
        If cmbFormation.Text = "Non" Then
            lbTypeFormation.Visible = False
            txtTypeFormation.Visible = False
            lbNiveau.Visible = False
            txtNiveauEtude.Visible = False

        Else
            lbTypeFormation.Visible = True
            txtTypeFormation.Visible = True
            lbNiveau.Visible = True
            txtNiveauEtude.Visible = True
        End If
    End Sub

    Private Sub cmbEmploye_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmploye.SelectedIndexChanged
        If cmbEmploye.Text = "Non" Then
            lbTypeEmploi.Visible = False
            txtTypeEmploi.Visible = False
        Else
            lbTypeEmploi.Visible = True
            txtTypeEmploi.Visible = True
        End If
    End Sub

    Private Sub chkEspece_CheckedChanged(sender As Object, e As EventArgs) Handles chkEspece.CheckedChanged
        If chkEspece.Checked Then
            chkVirement.Enabled = False
            chkCheque.Enabled = False

        Else
            chkVirement.Enabled = True
            chkCheque.Enabled = True
        End If
    End Sub

    Private Sub chkCheque_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheque.CheckedChanged
        If chkCheque.Checked Then
            chkVirement.Enabled = False
            chkEspece.Enabled = False
            lbCheque.Visible = True
            txtNumCheque.Visible = True
        Else
            chkVirement.Enabled = True
            chkEspece.Enabled = True
            lbCheque.Visible = False
            txtNumCheque.Visible = False
        End If
    End Sub

    Private Sub chkVirement_CheckedChanged(sender As Object, e As EventArgs) Handles chkVirement.CheckedChanged
        If chkVirement.Checked Then
            chkEspece.Enabled = False
            chkCheque.Enabled = False

        Else
            chkEspece.Enabled = True
            chkCheque.Enabled = True
        End If
    End Sub

    Private Sub cmbTypeFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeFormation.SelectedIndexChanged
        Dim idtype As TableTypeFormation = New TableTypeFormation
        Dim montantType As TableTypeFormation = New TableTypeFormation

        txtCoutFormation.Text = montantType.getMontant(cmbTypeFormation.SelectedValue)
    End Sub


    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtNomEtudiant.Text = "" Or cmbTypeFormation.Text = "" Or cmbReligion.Text = "" Or txtPrenom.Text = "" Or txtBP.Text = "" Or txtLieu.Text = "" Or txtMail.Text = "" Or txtMontantPayer.Text = "" Or txtNationalite.Text = "" Or txtPhone1.Text = "" Then
            Util.ShowMessage(Me, "Veuillez à bien remplir les champs", 0)
        Else
            Try
                Try

                    Dim execute As Long = etudiantTable.Update(Me)

                    If execute = 0 Then
                        Util.ShowMessage(Me, "Une erreur est survenu", 1)
                    Else
                        Util.ShowMessage(Me, "Mise à jour éffectué avec succès", 0)
                        MetroTabControl1.SelectTab(0)
                        Util.EmptyForm(Panel1)
                        Recherche()
                    End If
                Catch ex As Exception
                    If My.Settings.app_debug_mode Then
                        MsgBox(ex.ToString)
                    Else
                        MsgBox("Echec de connection")
                    End If
                End Try

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtMontantPayer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtMontantPayer_GotFocus(sender As Object, e As EventArgs) Handles txtMontantPayer.GotFocus
        txtMontantPayer.Text = txtMontantPayer.Text.Trim("F")
    End Sub

    Private Sub txtMontantPayer_LostFocus(sender As Object, e As EventArgs) Handles txtMontantPayer.LostFocus
        txtMontantPayer.Text &= "F"
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class