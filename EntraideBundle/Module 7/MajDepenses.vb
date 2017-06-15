Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db
Imports EntraideBundle.Db.Entities

Public Class MajDepenses

    Dim liste_depenses As New List(Of DepenseEntity)

    Dim depTable As New DepensesTable

    Dim current_index As Integer = -1

    Private Sub Search(Optional byCode As Boolean = False, Optional byType As Boolean = False)

        liste_depenses.Clear()

        current_index = -1

        Try
            If byCode Then
                liste_depenses = depTable.GetByCodeDepense(txtRechCode.Text, True, cmbAnnee.Text, cmbMois.SelectedValue)
            ElseIf byType Then
                liste_depenses = depTable.GetByTypeDepense(cmbRechType.SelectedValue, True, cmbAnnee.Text, cmbMois.SelectedValue)
            Else
                liste_depenses = depTable.GetByYearMonth(cmbAnnee.Text, cmbMois.SelectedValue)
            End If

            ListDepense.Items.Clear()
            Dim index As Integer = 0
            Dim iter As Integer = 1

            For Each theEntity As DepenseEntity In liste_depenses
                Dim item As New ListViewItem(theEntity.id)
                item.SubItems.Add(theEntity.motif_depense)
                item.SubItems.Add(theEntity.montant)
                item.SubItems.Add(theEntity.Devise.Nom)
                item.SubItems.Add(theEntity.Realisateur.FullName)
                item.SubItems.Add(theEntity.Beneficiaire.FullName)
                item.SubItems.Add(theEntity.TypeDepense.nom)
                item.SubItems.Add(theEntity.Departement.nom)
                item.SubItems.Add(index)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListDepense.Items.Add(item)
                iter += 1
                index += 1
            Next

        Catch ex As Exception
            Util.ShowMessage("Une erreur est survenu", 2)
        End Try
        
    End Sub

    Private Sub MajDepenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        Util.PopulateComboMonth(cmbMois)
        Util.PopulateCombo(cmbRechType, "SELECT id, nom FROM type_depenses", "id", "nom")


        Util.PopulateCombo(cmbTypeDepense, "SELECT id, nom FROM type_depenses", "id", "nom")
        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)
        Util.PopulateCombo(cmbManager, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbDevise, "SELECT id, nom FROM devises", "id", "nom")
        Util.PopulateCombo(cmbBeneficiaire, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbRealiser, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbCodeDepense, "SELECT id, code FROM code_depenses", "id", "code")
        Util.PopulateCombo(cmbProgramme, "SELECT id, nom FROM programmes", "id", "nom")
    End Sub

    Private Sub PopulateActiviteFinancier()
        Dim dt As DataTable = Database.GetDataTable("SELECT id, nom, code FROM code_depenses")
        Dim row = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbProgramme.DataSource = dt
        cmbProgramme.DisplayMember = "nom"
        cmbProgramme.ValueMember = "id"

        cmbCodeDepense.DataSource = dt
        cmbCodeDepense.DisplayMember = "code"
        cmbCodeDepense.ValueMember = "id"
    End Sub

    Private Sub ckCode_CheckedChanged(sender As Object, e As EventArgs) Handles ckCode.CheckedChanged
        txtRechCode.Enabled = ckCode.Checked
        If ckCode.Checked = False Then
            txtRechCode.Clear()
        Else
            ckType.Checked = False
        End If
    End Sub

    Private Sub ckType_CheckedChanged(sender As Object, e As EventArgs) Handles ckType.CheckedChanged
        cmbRechType.Enabled = ckType.Checked
        If ckType.Checked Then
            ckCode.Checked = False
        Else
            cmbRechType.SelectedValue = "0"
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TriggerSearch()
    End Sub

    Private Sub TriggerSearch()
        If ckCode.Checked Then
            Search(True)
        ElseIf ckType.Checked Then
            Search(False, True)
        Else
            Search()
        End If
    End Sub

    Private Sub ListDepense_ItemActivate(sender As Object, e As EventArgs) Handles ListDepense.ItemActivate
        DisplayDetails()
    End Sub


    Private Sub DisplayDetails()
        If ListDepense.SelectedItems.Count = 0 Then
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
            Exit Sub
        End If

        Dim index As Integer = CInt(ListDepense.SelectedItems(0).SubItems(8).Text)
        Dim theEntity As DepenseEntity = liste_depenses.Item(index)

        txtDate.Value = theEntity.created
        cmbTypeDepense.SelectedValue = theEntity.type_depense_id
        cmbDepartement.SelectedValue = theEntity.departement_id
        cmbCodeDepense.SelectedValue = theEntity.code_depense_id
        cmbManager.SelectedValue = theEntity.manager_id
        txtMontant.Text = theEntity.montant
        cmbDevise.SelectedValue = theEntity.devise_id
        cmbBeneficiaire.SelectedValue = theEntity.beneficiere_id
        txtReglement.Text = theEntity.motif_depense
        cmbRealiser.SelectedValue = theEntity.realiser_par
        txtCodeDemande.Text = theEntity.code_demande
        txtMemo.Text = theEntity.memo

        current_index = index

    End Sub

    Private Sub btFermer_Click(sender As Object, e As EventArgs) Handles btFermer.Click
        Close()
    End Sub

    Private Sub btMiseAjour_Click(sender As Object, e As EventArgs) Handles btMiseAjour.Click

        If current_index <= 0 Then
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
            Exit Sub
        End If

        Try

            If cmbTypeDepense.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectioner le type de depense", 1)
            ElseIf cmbDepartement.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le departement", 1)
            ElseIf cmbCodeDepense.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner l'activite", 1)
            ElseIf txtMontant.Text.Length = 0 OrElse txtMontant.Text = "0" Then
                Util.ShowMessage(Me, "Veuillez saisir le montant", 1)
            ElseIf cmbDevise.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner la devise", 1)
            ElseIf cmbBeneficiaire.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le beneficiaire", 1)
            ElseIf txtReglement.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir le motif", 1)
            ElseIf cmbRealiser.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le realisateur", 1)
            ElseIf txtCodeDemande.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir le code de la demande", 1)
            Else
                Dim entity As DepenseEntity = liste_depenses.Item(current_index)
                entity.created = txtDate.Value
                entity.type_depense_id = cmbTypeDepense.SelectedValue
                entity.departement_id = cmbDepartement.SelectedValue
                entity.code_depense_id = cmbCodeDepense.SelectedValue
                entity.manager_id = cmbManager.SelectedValue
                entity.montant = txtMontant.Text.Trim
                entity.devise_id = cmbDevise.SelectedValue
                entity.beneficiere_id = cmbBeneficiaire.SelectedValue
                entity.motif_depense = txtReglement.Text.Trim
                entity.realiser_par = cmbRealiser.SelectedValue
                entity.code_demande = txtCodeDemande.Text.Trim
                entity.memo = txtMemo.Text.Trim
                entity.programme_id = cmbProgramme.SelectedValue
                entity.activite = txtActivite.Text.Trim
                entity.IsChanged = True

                If entity.Save Then
                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    Util.EmptyForm(GroupBox2)
                    Util.EmptyForm(GroupBox3)
                    TriggerSearch()
                Else
                    Util.ShowMessage(Me, "L'enregistrement n'a pas aboutit, veuillez reessayer plus tard", 2)
                End If
            End If
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        End Try
    End Sub

End Class