Imports EntraideBundle.Db.Tables
Imports MetroFramework.Controls

Public Class Employee

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (TableLayoutPanel1.Width - PanelContainer.Width) / 2
        location.Y = ((TableLayoutPanel1.Height - PanelContainer.Height) / 2) - 20
        PanelContainer.Location = location

        Dim loc As New Point

        loc.X = ((PanelBottom.Width - PanelButtons.Width) / 2)
        loc.Y = (PanelBottom.Height - PanelButtons.Height) / 2
        PanelButtons.Location = loc

    End Sub


    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbDepartement, "SELECT id, nom FROM departements", "id", "nom")
        Util.PopulateCombo(cmbPoste, "SELECT id, nom FROM postes", "id", "nom")
        Util.PopulateCombo(cmbSuperviseur, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim hasError As Boolean = False

            For Each c As Control In GroupBox4.Controls
                If TypeOf c Is MetroComboBox Then
                    If DirectCast(c, MetroComboBox).Text.Trim.Length = 0 Then
                        Util.ShowMessage(Me, "Veuillez remplir tous les informations de la section contrat/responsabilite", 1)
                        Exit For
                    End If
                ElseIf TypeOf c Is MetroTextBox Then
                    If DirectCast(c, MetroTextBox).Text.Trim.Length = 0 Then
                        Util.ShowMessage(Me, "Veuillez remplir tous les informations de la section contrat/responsabilite", 1)
                        Exit For
                    End If
                End If
            Next


            For Each c As Control In GroupBox6.Controls
                If Not TypeOf c Is MetroFramework.Controls.MetroLabel Then
                    If c.Text.Length = 0 Then
                        Util.ShowMessage(Me, "Veuillez remplir tous les informations concernant le salaire", 1)
                        hasError = True
                        Exit For
                    End If
                End If

            Next

            If hasError Then
                Exit Sub
            End If

            Dim emp = EmployesTable.NewEntity
            emp.nom = txtNom.Text.Trim
            emp.prenom = txtPrenom.Text.Trim
            emp.sexe = cmbSexe.Text
            emp.situation_matrimonial = cmbSituationMatri.Text
            emp.nb_enfant = txtNbEnfant.Text.Trim
            emp.date_naissance = txtDateNaiss.Value
            emp.lieu_naissance = txtLieuNaiss.Text.Trim
            emp.nationnalite = txtNationalite.Text.Trim
            emp.bp = txtBp.Text.Trim
            emp.tel1 = txtPhone1.Text.Trim
            emp.tel2 = txtPhone2.Text.Trim
            emp.email = txtEmail.Text.Trim
            emp.religion = cmbReligion.Text.Trim
            emp.precision_autre = txtAutreRelion.Text.Trim
            emp.delis = cmbDelis.Text.Equals("oui", StringComparison.CurrentCultureIgnoreCase)
            emp.detail_delis = txtDetailDelis.Text.Trim
            emp.recu_formation = cmbFormation.Text.Equals("oui", StringComparison.CurrentCultureIgnoreCase)
            emp.type_formation_recu = txtTypeFormation.Text.Trim
            emp.niveau_etude = txtNiveauEt.Text.Trim
            emp.diplome = txtDiplome.Text.Trim
            emp.ecole = txtEcole.Text.Trim
            emp.nom_contact_urgent = txtNomUrgence.Text.Trim
            emp.adresse_contact_urgent = txtAdresseUrgence.Text.Trim
            emp.phone_contact_urgent = txtTelUrgence.Text.Trim
            emp.email_contact_urgent = txtEmailUrgence.Text.Trim
            emp.competance_fr = txtCompFr.Text.Trim
            emp.competance_en = txtCompEn.Text.Trim
            emp.competance_information = txtInformation.Text.Trim
            emp.autres_competances = txtAutreComp.Text.Trim
            emp.note_exp_professionnelle = txtNoteExperience.Text.Trim
            emp.date_enregistrement = Now

            emp.Salaire.term_paiement = cmbTermePaiement.Text
            Dim taux As Single = 0
            Single.TryParse(txtTauxSalaire.Text, taux)
            emp.Salaire.taux = taux
            emp.Salaire.nb_jour_travail = txtNbJourTravail.Text
            Dim prime As Single = 0
            Single.TryParse(txtSalaireMensuel.Text, prime)
            emp.Salaire.salaire = prime


            emp.Contrat.departement_id = cmbDepartement.SelectedValue
            emp.Contrat.poste_id = cmbPoste.SelectedValue
            emp.Contrat.duree = 0
            emp.Contrat.date_debut = txtDateDebutContrat.Value
            emp.Contrat.date_fin = txtFinContrat.Value
            emp.Contrat.nb_heure_travail = txtNbHeure.Text
            emp.Contrat.classification = cmbClassification.Text
            emp.Contrat.superviseur = cmbSuperviseur.SelectedValue

            emp.adresse = txtAdresse.Text.Trim

            If emp.Save Then
                Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                Close()
            Else
                Util.ShowMessage(Me, "Echec de l'enregistrement", 2)
            End If

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Erreur fatale : " & ex.Message, 2)
            End If
        End Try

    End Sub
End Class