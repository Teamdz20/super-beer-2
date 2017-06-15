Public Class UpdateFond

    Dim etudiantTable As EtudiantsTable = New EtudiantsTable
    Dim depTable As TableDepense = New TableDepense
    Public id_depense As Integer = 0
    
    Private Sub UpdateFond_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Util.PopulateComboYear(cbAnnee)

        Dim mois() As String = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"}
        cbMois.Items.AddRange(mois)
        Util.PopulateCombo(cbCode, "SELECT etudiants.id AS id, code_etudiant FROM etudiants INNER JOIN formations ON etudiants.id = formations.id_etudiant INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id INNER JOIN type_formation ON type_formation.id = formations.id_type_formation", "id", "code_etudiant")

    End Sub


    Public Sub Recherche(Optional ByVal byYear As Boolean = True, Optional ByVal byMonth As Boolean = False, Optional ByVal byCode As Boolean = False, Optional ByVal byName As Boolean = False)
        Dim liste As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)


        If byCode = True Then
            liste = etudiantTable.getByCodeEtudiant(cbCode.Text)
        ElseIf byMonth = True And byName = False And byCode = False Then
            liste = etudiantTable.getByMonth(cbAnnee.Text, cbMois.Text)
        ElseIf byMonth = False And byName = True And byCode = False Then
            liste = etudiantTable.getByName(cbAnnee.Text, txtNom.Text)
        ElseIf byMonth = True And byName = True And byCode = False Then
            liste = etudiantTable.getByNameMonth(cbAnnee.Text, txtNom.Text, cbMois.Text)
        ElseIf byMonth = False And byCode = False And byName = False Then
            liste = etudiantTable.getByYear(cbAnnee.Text)


        End If


        ListeEtudiants.Items.Clear()
        For Each elem As FondSoutienEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Etudiant.nom + " " + elem.Etudiant.prenom)
            item.SubItems.Add(elem.MontantRecu)
            item.SubItems.Add(DateDiff(DateInterval.Month, elem.DateDebut, elem.DateFin) & " mois")
            item.SubItems.Add(CDbl(elem.Interet) + CDbl(elem.Penalite))
            item.SubItems.Add(CDbl(elem.MontantRecu) + CDbl(elem.Interet) + CDbl(elem.Penalite))
            item.SubItems.Add(elem.DateDebut)
            item.SubItems.Add(elem.DateFin)
            item.SubItems.Add(elem.DateDepense)
            item.SubItems.Add(elem.CodeDepense.CodeRevenu)
            item.SubItems.Add(elem.MontantSollicite)
            item.SubItems.Add(elem.ModeReception)
            item.SubItems.Add(elem.MontantRecu)
            item.SubItems.Add(elem.TypeBusiness)
            item.SubItems.Add(elem.Echeance)

            item.SubItems.Add(elem.Paiement.MontantP)



            ListeEtudiants.Items.Add(item)
        Next
    End Sub


    Private Sub TriggerSearch()
        If chkCode.Checked Then
            Recherche(False, False, True, False)
        ElseIf chkMois.Checked = True And txtNom.Text.Trim.Length <= 0 Then
            Recherche(False, True, False, False)
        ElseIf chkMois.Checked = True And txtNom.Text.Trim.Length > 0 Then
            Recherche(False, True, False, True)
        ElseIf chkMois.Checked = False And txtNom.Text.Trim.Length > 0 Then
            Recherche(False, False, False, True)
        Else
            Recherche(True, False, False, False)

        End If
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        TriggerSearch()
    End Sub

    Private Sub ListeEtudiants_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListeEtudiants.ItemSelectionChanged
        If e.IsSelected Then
            MetroTabControl1.SelectTab(1)
            With ListeEtudiants.Items(e.ItemIndex)
                txtBeneficiare.Text = .SubItems(1).Text
                txtMontantRecu.Text = .SubItems(2).Text
                txtIntere.Text = .SubItems(4).Text
                txtNetAPayer.Text = .SubItems(5).Text
                dtDebutP.Value = .SubItems(6).Text
                dtFinP.Value = .SubItems(7).Text
                txtMontantSoli.Text = .SubItems(10).Text
                txtTypeBusiness.Text = .SubItems(13).Text

                dt_date.Value = .SubItems(8).Text
                txtMontHIC.Text = txtMontantRecu.Text
                txtNombreRepaiement.Text = .SubItems(14).Text
                txtCodeDepense.Text = .SubItems(9).Text
                id_depense = .SubItems(0).Text

                If .SubItems(15).Text = 0 Then
                    txtNbrePaiementEff.Text = "0"
                End If

                txtPaiementR.Text = CDbl(txtNombreRepaiement.Text) - CDbl(txtNbrePaiementEff.Text)

                If .SubItems(11).Text = "espece" Then
                    chkEspece.Checked = True
                ElseIf .SubItems(11).Text = "virement" Then
                    chkVirement.Checked = True
                ElseIf .SubItems(11).Text = "cheque" Then
                    chkCheque.Checked = True

                End If
            End With
        End If
    End Sub

    Private Sub chkMois_CheckedChanged(sender As Object, e As EventArgs) Handles chkMois.CheckedChanged
        If chkMois.Checked Then
            cbMois.Enabled = True
            chkCode.Checked = False
        Else
            cbMois.Enabled = False
        End If
    End Sub

    Private Sub chkCode_CheckedChanged(sender As Object, e As EventArgs) Handles chkCode.CheckedChanged
        If chkCode.Checked Then
            cbCode.Enabled = True
            chkMois.Checked = False
        Else
        End If
    End Sub

   
    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        If txtBeneficiare.Text = "" Or txtCodeDepense.Text = "" Or txtIntere.Text = "" Or txtMontHIC.Text = "" Or txtMontantRecu.Text = "" Or txtMontantSoli.Text = "" Or txtNombreRepaiement.Text = "" Or txtPenalites.Text = "" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Try
                Dim id As Long = depTable.UpdateFond(Me)
                If id = 0 Then
                    Util.ShowMessage(Me, "Enregistrement échoué", 2)
                Else
                    Util.ShowMessage(Me, "Ensregistrement correctement mis à jour", 0)
                    Util.EmptyForm(GroupBox2)
                    Util.EmptyForm(GroupBox4)
                    MetroTabControl1.SelectTab(0)
                    TriggerSearch()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class