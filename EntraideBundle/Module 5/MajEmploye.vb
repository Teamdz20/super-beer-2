'Imports EntraideOrm.Employes
'Imports EntraideOrm.Contrats
'Imports EntraideOrm.Salaires
'Imports EntraideOrm.Departements
Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class MajEmploye

    ''' <summary>
    ''' EmployeTable instance
    ''' </summary>
    ''' <remarks></remarks>
    Private empTable As EmployesTable = New EmployesTable

    ''' <summary>
    ''' Active item editing
    ''' </summary>
    ''' <remarks></remarks>
    Public current_index As Integer = -1


    ''' <summary>
    ''' Liste of employes displayed
    ''' </summary>
    ''' <remarks></remarks>
    Public empListe As List(Of EmployeEntity) = New List(Of EmployeEntity)

    ''' <summary>
    ''' Populating liste from cashed datas
    ''' </summary>
    ''' <remarks></remarks>
    Public from_cash As Boolean = False


    ''' <summary>
    ''' Responsive perform
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Seach method
    ''' </summary>
    ''' <param name="byCode"></param>
    ''' <param name="byName"></param>
    ''' <param name="byDepartement"></param>
    ''' <remarks></remarks>
    Private Sub Search(Optional byCode As Boolean = False, Optional byName As Boolean = False, _
                       Optional byDepartement As Boolean = False)

        ListEmploye.Items.Clear()

        If from_cash = False Then
            empListe.Clear()

            If byCode Then
                empListe = empTable.GetByCode(txtRechCode.Text)
            ElseIf byName AndAlso byDepartement = False Then
                empListe = empTable.GetByname(txtRechNom.Text)
            ElseIf byName AndAlso byDepartement Then
                ' Recherche par nom et departement
                empListe = empTable.GetByNameDepartement(txtRechNom.Text, cmbRechDep.SelectedValue)
            ElseIf byDepartement AndAlso byName = False Then
                ' Recherche par departement
                empListe = empTable.GetByDepartement(cmbRechDep.SelectedValue)
            End If
        End If

        If empListe.Count = 0 Then
            Util.ShowMessage(Me, "Aucun résultat ne correspond à votre recherche")
        End If

        Dim iter As Integer = 1
        Dim index As Integer = 0

        For Each employe As EmployeEntity In empListe
            Dim item As New ListViewItem(employe.id)
            item.SubItems.Add(employe.nom)
            item.SubItems.Add(employe.prenom)
            item.SubItems.Add(employe.Departement.nom)
            item.SubItems.Add(employe.email)
            item.SubItems.Add(FormatDateTime(employe.Contrat.date_debut, DateFormat.ShortDate))
            item.SubItems.Add(FormatDateTime(employe.Contrat.date_fin, DateFormat.ShortDate))
            item.SubItems.Add(index)

            If iter = 4 Then
                item.BackColor = Color.AliceBlue
                iter = 0
            End If
            ListEmploye.Items.Add(item)
            iter += 1
            index += 1
        Next

        EmptyForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub ckCode_CheckedChanged(sender As Object, e As EventArgs) Handles ckCode.CheckedChanged
        txtRechCode.Enabled = ckCode.Checked
        If ckCode.Checked Then
            ckNom.Checked = False
            ckDepartement.Checked = False
        Else
            txtRechCode.Clear()
        End If
    End Sub

    Private Sub ckNom_CheckedChanged(sender As Object, e As EventArgs) Handles ckNom.CheckedChanged
        txtRechNom.Enabled = ckNom.Checked
        If ckNom.Checked Then
            ckCode.Checked = False
        Else
            txtRechNom.Clear()
        End If
    End Sub

    Private Sub ckDepartement_CheckedChanged(sender As Object, e As EventArgs) Handles ckDepartement.CheckedChanged
        cmbRechDep.Enabled = ckDepartement.Checked
        If ckDepartement.Checked Then
            ckCode.Checked = False
        Else
            cmbRechDep.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MajEmploye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Util.PopulateCombo(cmbRechDep, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)

            Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)
            Util.PopulateCombo(cmbPoste, "SELECT id, nom FROM postes", "id", "nom")
            Util.PopulateCombo(cmbSuperviseur, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)

            Util.PopulateAutoCompletation(txtRechNom, "SELECT CONCAT_WS(' ', nom, prenom) AS nom FROM employes")

            If from_cash Then
                GroupBox7.Enabled = False
                btnSave.Visible = False
                btnClear.Visible = False
                Search()
                Edit()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ckCode.Checked Then
            If txtRechCode.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir le code", 1)
                Exit Sub
            End If
            Search(True)
        ElseIf ckNom.Checked AndAlso ckDepartement.Checked = False Then
            If txtRechNom.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir un nom", 1)
                Exit Sub
            End If
            Search(False, True)
        ElseIf ckNom.Checked = False AndAlso ckDepartement.Checked Then
            If cmbRechDep.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le département", 1)
                Exit Sub
            End If
            Search(False, False, True)
        ElseIf ckNom.Checked AndAlso ckDepartement.Checked Then
            If cmbRechDep.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le département", 1)
                Exit Sub
            End If

            If txtRechNom.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir un nom", 1)
                Exit Sub
            End If
            Search(False, True, True)
        Else
            Util.ShowMessage(Me, "Aucun critère de recherche specifier", 1)
        End If
    End Sub

    ''' <summary>
    ''' Edit methode
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Edit()
        If ListEmploye.SelectedItems.Count = 0 AndAlso from_cash = False Then
            Util.ShowMessage(Me, "Veuillez sélectionner un enregistrement", 1)
            Exit Sub
        End If

        Dim index As Integer = 0

        If from_cash = False Then
            index = CInt(ListEmploye.SelectedItems(0).SubItems(7).Text)
        End If

        Dim employe As EmployeEntity = empListe.Item(index)

        txtNom.Text = employe.nom
        txtPrenom.Text = employe.prenom
        cmbSexe.Text = employe.sexe
        cmbSituationMatri.Text = employe.situation_matrimonial
        txtNbEnfant.Text = employe.nb_enfant
        txtDateNaiss.Value = employe.date_naissance
        txtLieuNaiss.Text = employe.lieu_naissance
        txtNationalite.Text = employe.nationnalite
        txtAdresse.Text = employe.adresse
        txtBp.Text = employe.bp
        txtPhone1.Text = employe.tel1
        txtPhone2.Text = employe.tel2
        txtEmail.Text = employe.email

        txtNomUrgence.Text = employe.nom_contact_urgent
        txtAdresseUrgence.Text = employe.adresse_contact_urgent
        txtTelUrgence.Text = employe.adresse_contact_urgent
        txtEmailUrgence.Text = employe.email_contact_urgent

        txtCompFr.Text = employe.competance_fr
        txtCompEn.Text = employe.competance_en
        txtInformation.Text = employe.competance_information
        txtNoteExperience.Text = employe.note_exp_professionnelle

        cmbDepartement.SelectedValue = employe.Departement.id
        cmbPoste.SelectedValue = employe.Poste.id
        cmbClassification.Text = employe.Contrat.classification
        'txtDureeContrat .Text = ""
        txtDateDebutContrat.Value = employe.Contrat.date_debut
        txtFinContrat.Value = employe.Contrat.date_fin
        txtNbHeure.Text = employe.Contrat.nb_heure_travail
        cmbSuperviseur.SelectedValue = employe.Contrat.superviseur

        cmbReligion.Text = employe.religion
        txtAutreRelion.Text = employe.precision_autre

        Dim delis As String = "Oui"
        If employe.delis = False Then delis = "Non"
        cmbDelis.Text = delis
        txtDetailDelis.Text = employe.detail_delis
        Dim formation As String = "Oui"
        If employe.recu_formation = False Then formation = "Non"
        cmbFormation.Text = formation
        txtTypeFormation.Text = employe.type_formation_recu
        txtNiveauEt.Text = employe.niveau_etude
        txtDiplome.Text = employe.diplome
        txtEcole.Text = employe.ecole

        cmbTermePaiement.Text = employe.Salaire.term_paiement
        txtTauxSalaire.Text = employe.Salaire.taux
        txtNbJourTravail.Text = employe.Salaire.nb_jour_travail
        txtSalaireMensuel.Text = employe.Salaire.salaire

        GroupBoxCompetance.Enabled = True
        GroupContrat.Enabled = True
        GroupContactUrgence.Enabled = True
        GroupBoxAutreInfo.Enabled = True
        GroupBoxSalaire.Enabled = True
        GroupInfoGeneral.Enabled = True

        current_index = index
    End Sub

    Private Sub EditerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem.Click
        Edit()
    End Sub

    Private Sub EmptyForm()
        Util.EmptyForm(PanelContainer)
        current_index = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        EmptyForm()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If current_index < 0 Then
            Util.ShowMessage(Me, "Opération invalide", 1)
            Exit Sub
        End If

        Dim emp As EmployeEntity = empListe.Item(current_index)
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

        If emp.Save() > 0 Then
            Util.ShowMessage(Me, "Modification effectuer avec success")
            EmptyForm()
        End If

    End Sub

    Private Sub ListEmploye_ItemActivate(sender As Object, e As EventArgs) Handles ListEmploye.ItemActivate
        Edit()
    End Sub

    Private Sub cmbDelis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDelis.SelectedIndexChanged
        txtDetailDelis.Visible = cmbDelis.Text.Equals("oui", StringComparison.CurrentCultureIgnoreCase)
        LabelDelis.Visible = cmbDelis.Text.Equals("oui", StringComparison.CurrentCultureIgnoreCase)
    End Sub
End Class