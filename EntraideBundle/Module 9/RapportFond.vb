Public Class RapportFond

    Dim etudiantTable As EtudiantsTable = New EtudiantsTable

    Dim form_loaded As Boolean = False

    Private Sub RapportFond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        cmbTypeRapport.Text = "Trimestriel"
        LoadData()
        form_loaded = True
    End Sub
    Private Sub cbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub


    Public Sub LoadData()

        Dim totalFond As Double = 0

        Dim totalRemb As Double = 0

        Dim totalAPayer As Double = 0

        Dim lEtudiands As List(Of String) = New List(Of String)


        Try
            Dim liste As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
            liste = etudiantTable.GetByDateFond(cmbDu.Value, cmbAu.Value)

            ListeEtudiants.Items.Clear()

            Dim iter As Integer = 1

            For Each elem As FondSoutienEntity In liste
                Dim item As New ListViewItem(elem.Id)
                item.SubItems.Add(elem.Etudiant.nom + " " + elem.Etudiant.prenom)
                item.SubItems.Add(FormatNumber(elem.MontantRecu, 0))
                item.SubItems.Add(DateDiff(DateInterval.Month, elem.DateDebut, elem.DateFin) & " Mois")
                item.SubItems.Add(FormatNumber(CDbl(elem.Interet) + CDbl(elem.Penalite), 0))
                item.SubItems.Add(FormatNumber(CDbl(elem.MontantRecu) + CDbl(elem.Interet) + CDbl(elem.Penalite), 0))
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

                totalFond += elem.MontantRecu
                totalRemb += elem.Paiement.MontantP
                totalAPayer += (elem.MontantRecu + CDbl(elem.Interet) + CDbl(elem.Penalite))

                If Not lEtudiands.Contains(elem.Etudiant.id) Then
                    lEtudiands.Add(elem.Etudiant.id)
                End If

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListeEtudiants.Items.Add(item)
                iter += 1
            Next
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.ToString, 2)
            End If
        Finally
            labelTotal.Text = FormatNumber(totalFond, 0)
            labelRembourssement.Text = FormatNumber(totalRemb, 0)
            labelNet.Text = FormatNumber(totalAPayer, 0)
            labelEt.Text = FormatNumber(lEtudiands.Count, 0)
            lEtudiands = Nothing
            GC.Collect()
        End Try
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        LoadData()
    End Sub

    Private Sub chkPredef_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPredef.CheckedChanged
        If Not form_loaded Then
            Exit Sub
        End If
        If ChkPredef.Checked Then
            chkAll.Checked = False
            ListeEtudiants.Columns.Item(8).Width = 0
            ListeEtudiants.Columns.Item(9).Width = 0
            ListeEtudiants.Columns.Item(10).Width = 0
            ListeEtudiants.Columns.Item(11).Width = 0
            ListeEtudiants.Columns.Item(12).Width = 0
            ListeEtudiants.Columns.Item(13).Width = 0
            ListeEtudiants.Columns.Item(14).Width = 0
            ListeEtudiants.Columns.Item(15).Width = 0
        Else
            chkAll.Checked = True
        End If

    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If Not form_loaded Then
            Exit Sub
        End If
        If chkAll.Checked Then
            ChkPredef.Checked = False
            ListeEtudiants.Columns.Item(8).Width = 160
            ListeEtudiants.Columns.Item(9).Width = 160
            ListeEtudiants.Columns.Item(10).Width = 160
            ListeEtudiants.Columns.Item(11).Width = 160
            ListeEtudiants.Columns.Item(12).Width = 160
            ListeEtudiants.Columns.Item(13).Width = 160
            ListeEtudiants.Columns.Item(14).Width = 160
            ListeEtudiants.Columns.Item(15).Width = 160
        Else
            ChkPredef.Checked = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Using form As New Printing.ReportFond(EtudiantsTable.fond_data_source, labelTotal.Text, labelEt.Text)
            form.ShowDialog()
        End Using
    End Sub

    Private Sub ImprimerLhistoriqueDesPaiementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerLhistoriqueDesPaiementsToolStripMenuItem.Click
        If ListeEtudiants.SelectedItems.Count > 0 Then
            Dim fond_id As String = ListeEtudiants.SelectedItems(0).Text
            Using report As New Printing.RecuFond(fond_id)
                report.ShowDialog()
            End Using
        Else
            Beep()
        End If
    End Sub
End Class