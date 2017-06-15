Imports EntraideBundle.Db
Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class MajDon

    Dim donTable As New DonsTable

    Dim liste_dons As New List(Of DonEntity)

    Dim current_index As Integer = -1

    Private Sub Search(Optional byDate As Boolean = False, Optional byType As Boolean = False, Optional byActivite As Boolean = False, Optional byDonneur As Boolean = False)

        liste_dons.Clear()
        ListDon.Items.Clear()

        Try
            If byDate Then
                liste_dons = donTable.GetByDate(cmbDate.Value)
            ElseIf byType Then
                liste_dons = donTable.GetByDate(cmbRechTypeDon.Text)
                'liste_dons.Where(Function(o) (o.activite_financier_id = 1)).ToList()
            ElseIf byDonneur Then
                liste_dons = donTable.GetByDonneur(cmbRechDonneur.SelectedValue)
            End If

            Dim iter As Integer = 1
            Dim index As Integer = 0

            For Each d As DonEntity In liste_dons
                Dim item As New ListViewItem(d.id)
                item.SubItems.Add(d.type_don)
                item.SubItems.Add(d.montant_recu)
                item.SubItems.Add(d.User.username)
                item.SubItems.Add(d.Donneur.nom)
                item.SubItems.Add(d.restriction)
                item.SubItems.Add(d.ActiviteFinancier.code)
                item.SubItems.Add(index)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListDon.Items.Add(item)
                iter += 1
                index += 1
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Don_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Util.PopulateCombo(cmbRechDonneur, "SELECT id, nom FROM donneurs", "id", "nom")


        PopulateActiviteFinancier()

        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)

        PopulateDonneurs()

    End Sub

    Private Sub PopulateActiviteFinancier()
        Dim dt As DataTable = Database.GetDataTable("SELECT id, nom, code FROM activite_financiers")
        Dim row = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbActiviteFinancier.DataSource = dt
        cmbActiviteFinancier.DisplayMember = "nom"
        cmbActiviteFinancier.ValueMember = "id"

        cmbCodeRevenu.DataSource = dt
        cmbCodeRevenu.DisplayMember = "code"
        cmbCodeRevenu.ValueMember = "id"
    End Sub

    Private Sub PopulateDonneurs()
        Dim dt As DataTable = Database.GetDataTable(DonneursTable.SQL_COMBO)
        Dim row = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbCodeDonneur.DataSource = dt
        cmbCodeDonneur.ValueMember = DonneursTable.P_K
        cmbCodeDonneur.DisplayMember = "code"

        cmbDonneur.DataSource = dt
        cmbDonneur.DisplayMember = DonneursTable.D_N
        cmbDonneur.ValueMember = DonneursTable.P_K
    End Sub


    Private Sub ckDate_CheckedChanged(sender As Object, e As EventArgs) Handles ckDate.CheckedChanged
        cmbDate.Enabled = ckDate.Checked
    End Sub

    Private Sub ckTypeDon_CheckedChanged(sender As Object, e As EventArgs) Handles ckTypeDon.CheckedChanged
        cmbRechTypeDon.Enabled = ckTypeDon.Checked
    End Sub

    Private Sub ckDonneur_CheckedChanged(sender As Object, e As EventArgs) Handles ckDonneur.CheckedChanged
        cmbRechDonneur.Enabled = ckDonneur.Checked
    End Sub

    Private Sub btRecher_Click(sender As Object, e As EventArgs) Handles btRecher.Click
        LauchSearch()
    End Sub


    Private Sub LauchSearch()
        If ckDate.Checked Then
            Search(True)
        ElseIf ckTypeDon.Checked Then
            Search(False, True)
        ElseIf ckDonneur.Checked Then
            Search(False, False, False, True)
        End If
    End Sub

    Private Sub DisplayDetails()
        Try
            If ListDon.SelectedItems.Count = 0 Then
                Util.ShowMessage(Me, "Veuillez selectionner une ligne du tableau", 1)
                Exit Sub
            End If

            Dim index As Integer = CInt(ListDon.SelectedItems(0).SubItems(7).Text)

            Dim theEntity As DonEntity = liste_dons.Item(index)
            txtDate.Value = theEntity.created
            ckArgent.Checked = True
            If Not theEntity.type_don.Equals("Argent", StringComparison.CurrentCultureIgnoreCase) Then
                ckMaterial.Checked = True
            End If
            txtMontantSollicite.Text = theEntity.montant_sollicite
            ckNonSollicite.Checked = (txtMontantSollicite.Text.Length = 0 Or txtMontantSollicite.Text = "0")
            txtMontrecu.Text = theEntity.montant_recu
            txtDiference.Text = (theEntity.montant_sollicite - theEntity.montant_recu)
            ckEspece.Checked = True
            If theEntity.mode_reception.Equals("Cheque", StringComparison.CurrentCultureIgnoreCase) Then ckCheque.Checked = True
            If theEntity.mode_reception.Equals("Virement", StringComparison.CurrentCultureIgnoreCase) Then ckVirement.Checked = True
            txtNumCheque.Text = theEntity.numero_cheque
            ckSansResctriction.Checked = True
            If theEntity.restriction.Equals("LIMITE", StringComparison.CurrentCultureIgnoreCase) Then ckResLimite.Checked = True
            If theEntity.restriction.Equals("ILLIMITE", StringComparison.CurrentCultureIgnoreCase) Then ckResIllimite.Checked = True
            txtActiviteMenee.Text = theEntity.activite_menee
            txtNoteRestriction.Text = theEntity.note_restriction
            cmbActiviteFinancier.SelectedValue = theEntity.activite_financier_id
            cmbDepartement.SelectedValue = theEntity.departement_id
            cmbDonneur.SelectedValue = theEntity.donneur_id

            current_index = index
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        End Try
    End Sub

    Private Sub ListDon_ItemActivate(sender As Object, e As EventArgs) Handles ListDon.ItemActivate

        DisplayDetails()

    End Sub

    Private Sub btfermer_Click(sender As Object, e As EventArgs) Handles btfermer.Click
        Close()
    End Sub

    Private Sub btenregistrer_Click(sender As Object, e As EventArgs) Handles btenregistrer.Click
        If current_index <= 0 Then
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
            Exit Sub
        End If
        If ckNonSollicite.Checked And (txtMontantSollicite.Text.Length = 0 And txtMontantSollicite.Text = "0") Then
            Util.ShowMessage(Me, "Veuillez selectionner le montant sollicité", 1)
        ElseIf txtMontrecu.Text.Length = 0 OrElse txtMontrecu.Text = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le montant réçu", 1)
        ElseIf txtActiviteMenee.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez saisir l'activite menee", 1)
        ElseIf cmbDonneur.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le donneur", 1)
        ElseIf cmbActiviteFinancier.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner l'activiter financier", 1)
        ElseIf cmbDepartement.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le departement", 1)
        Else
            Using trans As EntraideOrm.LUNA.LunaTransactionBox = EntraideOrm.LUNA.LunaContext.CreateTransactionBox

                Try
                    trans.TransactionBegin()

                    Dim theEntity As DonEntity = liste_dons.Item(current_index)

                    theEntity.created = txtDate.Value
                    Dim type As String = "ARGENT"
                    If ckMaterial.Checked Then
                        type = "MATERIEL"
                    End If

                    theEntity.type_don = type
                    theEntity.montant_sollicite = CDbl(txtMontantSollicite.Text)
                    theEntity.montant_recu = CDbl(txtMontrecu.Text)

                    Dim mode_reception As String = "Espece"
                    If ckCheque.Checked Then mode_reception = "Cheque"
                    If ckVirement.Checked Then mode_reception = "Virement"
                    theEntity.mode_reception = mode_reception
                    theEntity.numero_cheque = txtNumCheque.Text.Trim

                    Dim restriction As String = "SANS"
                    If ckResLimite.Checked Then restriction = "LIMITE"
                    If ckResIllimite.Checked Then restriction = "ILLIMITE"
                    theEntity.restriction = restriction

                    theEntity.activite_menee = txtActiviteMenee.Text.Trim
                    theEntity.donneur_id = cmbDonneur.SelectedValue
                    theEntity.note_restriction = txtNoteRestriction.Text.Trim
                    theEntity.activite_financier_id = cmbActiviteFinancier.SelectedValue
                    theEntity.departement_id = cmbDepartement.SelectedValue

                    ' Force call of update
                    theEntity.IsChanged = True

                    If theEntity.Save() > 0 Then
                        trans.TransactionCommit()
                        Util.ShowMessage(Me, "Enregistrement effectue avec success")
                        Util.EmptyForm(TabDetails)
                        LauchSearch()
                    Else
                        Util.ShowMessage(Me, "Une erreur est survenu, veuillez reessayer plus tard", 1)
                    End If

                Catch ex As Exception
                    trans.TransactionRollBack()
                    If My.Settings.app_debug_mode Then
                        Util.ShowMessage(ex.ToString, 2)
                    Else
                        Util.ShowMessage("Fatal error : " & ex.Message, 2)
                    End If
                End Try
            End Using
        End If
    End Sub
End Class
