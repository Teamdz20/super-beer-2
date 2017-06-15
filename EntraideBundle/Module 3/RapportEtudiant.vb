Public Class RapportEtudiant

    Dim etudTable As EtudiantsTable = New EtudiantsTable


    Private ReadOnly Property _generation As String
        Get
            Dim generation As String = ""
            If ckGeneration.Checked AndAlso cmbGeneration.Text.Trim.Length > 0 Then
                generation = cmbGeneration.SelectedValue
            End If
            Return generation
        End Get
    End Property


    Private Sub Recherche(Optional byDate As Boolean = True, Optional byPaiement As Boolean = False, Optional byFormation As Boolean = False)

        Dim liste As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        If cmbFormation.Text = "Tout confondu" Then
            byFormation = False
        End If

        If byPaiement = False And byFormation = False Then
            liste = etudTable.GetByDate(cmbDu.Value, cmbAu.Value, _generation)
        ElseIf byPaiement = True And byFormation = False Then
            liste = etudTable.GetByPaiement(cmbDu.Value, cmbAu.Value, cmbPaiement.Text, _generation)
        ElseIf byFormation = True And byPaiement = False Then
            liste = etudTable.GetByFormation(cmbDu.Value, cmbAu.Value, cmbFormation.SelectedValue.ToString, _generation)
        ElseIf byFormation = True And byPaiement = True Then
            liste = etudTable.GetByFormationPaiement(cmbDu.Value, cmbAu.Value, cmbFormation.SelectedValue, cmbPaiement.Text.Length, _generation)
        End If

        Dim totalDette As Double = 0
        Dim totalComplet As Double = 0

        Try
            ListEtudians.Items.Clear()

            Dim iter As Integer = 1

            For Each elem As EtudiantEntity In liste
                Dim item As New ListViewItem(elem.id)
                item.SubItems.Add(elem.nom)
                item.SubItems.Add(elem.prenom)
                item.SubItems.Add(FormatNumber(elem.Revenu.Montant, 0))

                Dim dette = CDbl(elem.Revenu.Montant) - CDbl(elem.Paiement.MontantP)
                If dette < 0 Then dette = 0

                If dette > 0 Then
                    totalDette += 1
                Else
                    totalComplet += 1
                End If

                item.SubItems.Add(FormatNumber(dette, 0))
                item.SubItems.Add(elem.Paiement.TypePaiement.ToUpper)
                item.SubItems.Add(elem.code)
                item.SubItems.Add(elem.tel1)
                item.SubItems.Add(elem.tel2)
                item.SubItems.Add(elem.email)
                item.SubItems.Add(elem.adresse)
                item.SubItems.Add(elem.bp)
                item.SubItems.Add(elem.sexe)
                item.SubItems.Add(elem.nationnalite)
                item.SubItems.Add(elem.lieu_naissance)
                item.SubItems.Add(elem.situation_matri)
                item.SubItems.Add(elem.nom_urgence)
                item.SubItems.Add(elem.adresse_urgence)
                item.SubItems.Add(elem.phone_urgence)
                item.SubItems.Add(elem.TypeFormationId.Nom)
                item.SubItems.Add(elem.generation)
                item.SubItems.Add(elem.type_business)
                item.SubItems.Add(elem.niveau)

                item.SubItems.Add(elem.nombre_enfant)
                item.SubItems.Add(elem.Religion.Nom)

                item.SubItems.Add(elem.autre_religion)
                item.SubItems.Add(elem.delit)
                item.SubItems.Add(elem.formation_recu)

                item.SubItems.Add(elem.mail_urgence)
                item.SubItems.Add(elem.type_emploie)
                item.SubItems.Add(elem.business)

                item.SubItems.Add(elem.nombre_employe)
                item.SubItems.Add(elem.annexe)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If


                ListEtudians.Items.Add(item)

                iter += 1
            Next
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.ToString, 2)
            End If
        Finally
            txtTotal.Text = FormatNumber(ListEtudians.Items.Count, 0)
            txtTotalDette.Text = FormatNumber(totalDette, 0)
            txtTotalComplet.Text = FormatNumber(totalComplet, 0)
        End Try
    End Sub



    Private Sub cbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub RapportEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExpandDetails(True)
        Util.PopulateComboYear(cmbAnnee)
        Util.PopulateCombo(cmbFormation, "SELECT id, nom  FROM type_formation", "id", "nom")
        Util.PopulateCombo(cmbGeneration, "SELECT id, libelle FROM generations", "id", "libelle")
        cmbTypeRapport.Text = "Annuel"
        TriggerSearch()
    End Sub


    Private Sub TriggerSearch()
        If cmbFormation.Text.Trim.Length <= 0 And cmbPaiement.Text.Trim.Length <= 0 Then
            Recherche(True, False, False)
        ElseIf cmbFormation.Text.Length <= 0 And cmbPaiement.Text.Trim.Length > 0 Then
            Recherche(True, True, False)
        ElseIf cmbFormation.Text.Length > 0 And cmbPaiement.Text.Length <= 0 Then
            Recherche(True, False, True)
        ElseIf cmbFormation.Text.Length > 0 And cmbPaiement.Text.Length > 0 Then
            Recherche(True, True, True)
        End If
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        TriggerSearch()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ckGeneration_CheckedChanged(sender As Object, e As EventArgs) Handles ckGeneration.CheckedChanged
        cmbGeneration.Enabled = ckGeneration.Checked
        If ckGeneration.Checked = False Then
            cmbGeneration.Text = ""
        End If
    End Sub

    Private Sub ExpandDetails(Optional minimize As Boolean = False)
        If minimize Then
            For i As Integer = 10 To 22
                ListEtudians.Columns(i).Width = 0
            Next
        Else
            For i As Integer = 10 To 22
                ListEtudians.Columns(i).Width = 200
            Next
        End If
    End Sub

    Private Sub ckDetail_CheckedChanged(sender As Object, e As EventArgs) Handles ckDetail.CheckedChanged
        ExpandDetails()
    End Sub

    Private Sub ckPredefini_CheckedChanged(sender As Object, e As EventArgs) Handles ckPredefini.CheckedChanged
        ExpandDetails(True)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        Dim generation As String = cmbGeneration.Text.Trim
        If generation.Length = 0 Then generation = "Toutes"

        Dim formation As String = cmbFormation.Text.Trim
        If formation.Length = 0 Then formation = "Toutes"

        Using report As New Printing.ReportEtudiants(EtudiantsTable.data_source, generation, formation, txtTotalDette.Text, txtTotalComplet.Text)
            report.ShowDialog()
        End Using
    End Sub
End Class