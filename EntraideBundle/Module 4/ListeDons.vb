Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class ListeDons

    ''' <summary>
    ''' List contains donates
    ''' </summary>
    ''' <remarks></remarks>
    Private dons_list As List(Of DonEntity) = New List(Of DonEntity)

    ''' <summary>
    ''' DonTable
    ''' </summary>
    ''' <remarks></remarks>
    Private donTable As DonsTable = New DonsTable

    ''' <summary>
    ''' Responsive manage
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2) + 20
        PanelContainer.Location = location
    End Sub

    ''' <summary>
    ''' Loading donations data
    ''' </summary>
    ''' <param name="byType"></param>
    ''' <param name="byModePaiement"></param>
    ''' <param name="byTypeMode"></param>
    ''' <remarks></remarks>
    Private Sub LoadDonations(Optional byType As Boolean = False, Optional byModePaiement As Boolean = False, Optional byTypeMode As Boolean = False)

        Dim totalDon As Double = 0

        Dim list_donneur As New List(Of String)

        Try
            dons_list.Clear()

            ListDon.Items.Clear()

            If byType Then
                dons_list = donTable.GetByType(cmbDu.Value, cmbAu.Value, cmbTypeDon.Text)
            ElseIf byModePaiement Then
                dons_list = donTable.GetByModePaiement(cmbDu.Value, cmbAu.Value, cmbModePaiement.Text)
            ElseIf byTypeMode Then
                dons_list = donTable.GetByTypeMode(cmbDu.Value, cmbAu.Value, cmbTypeDon.Text, cmbModePaiement.Text)
            Else
                dons_list = donTable.GetByInterval(cmbDu.Value, cmbAu.Value)
            End If

            Dim iter As Integer = 1

            Dim index As Integer = 0

            For Each theEntity As DonEntity In dons_list
                Dim item As New ListViewItem(theEntity.id)
                item.SubItems.Add(theEntity.code)
                item.SubItems.Add(theEntity.type_don)
                item.SubItems.Add(FormatNumber(theEntity.montant_recu, 0))
                item.SubItems.Add(theEntity.User.username)
                item.SubItems.Add(theEntity.Donneur.nom)
                item.SubItems.Add(theEntity.restriction)
                item.SubItems.Add(theEntity.ActiviteFinancier.code)
                item.SubItems.Add(theEntity.mode_reception)
                item.SubItems.Add(theEntity.montant_sollicite)
                item.SubItems.Add(theEntity.numero_cheque)
                item.SubItems.Add(theEntity.activite_menee)
                item.SubItems.Add(theEntity.Departement.nom)

                totalDon += theEntity.montant_recu

                If Not list_donneur.Contains(theEntity.donneur_id) Then
                    list_donneur.Add(theEntity.donneur_id)
                End If

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListDon.Items.Add(item)
                iter += 1
            Next
        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            txtTotalDon.Text = FormatNumber(ListDon.Items.Count, 0)
            txtTotalDonneur.Text = FormatNumber(list_donneur.Count, 0)
            txtMontantTotal.Text = FormatNumber(totalDon, 0)

            GC.Collect()
        End Try
    End Sub

    Private Sub ListeDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        cmbTypeRapport.Text = "Trimestriel"
        TriggerSearch()
        ckPredefini.Checked = True
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub cmbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub ckTypeDon_CheckedChanged(sender As Object, e As EventArgs) Handles ckTypeDon.CheckedChanged
        cmbTypeDon.Enabled = ckTypeDon.Checked
        If ckTypeDon.Checked = False Then
            cmbTypeDon.Text = ""
        End If
    End Sub

    Private Sub ckModePaiement_CheckedChanged(sender As Object, e As EventArgs) Handles ckModePaiement.CheckedChanged
        cmbModePaiement.Enabled = ckModePaiement.Checked
        If ckModePaiement.Checked = False Then
            cmbModePaiement.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' Trigger Search
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TriggerSearch()
        If ckTypeDon.Checked AndAlso ckModePaiement.Checked = False Then
            LoadDonations(True)
        ElseIf ckModePaiement.Checked AndAlso ckTypeDon.Checked = False Then
            LoadDonations(False, True)
        ElseIf ckModePaiement.Checked AndAlso ckTypeDon.Checked Then
            LoadDonations(False, False, True)
        Else
            LoadDonations()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TriggerSearch()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim form As New Printing.ReportDons(DonsTable.data_set)
        form.total = txtTotalDon.Text
        form.nb_donneur = txtTotalDonneur.Text
        form.montant = txtMontantTotal.Text
        form.ShowDialog()
    End Sub

    Private Sub ckPredefini_CheckedChanged(sender As Object, e As EventArgs) Handles ckPredefini.CheckedChanged
        If ckPredefini.Checked Then
            For i As Integer = 8 To 12
                ListDon.Columns(i).Width = 0
            Next
        End If
    End Sub

    Private Sub ckDetail_CheckedChanged(sender As Object, e As EventArgs) Handles ckDetail.CheckedChanged
        If ckDetail.Checked Then
            For i As Integer = 8 To 12
                ListDon.Columns(i).Width = 200
            Next
        End If
    End Sub

    Private Sub ImprimerLeRecuDeCaisseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerLeRecuDeCaisseToolStripMenuItem.Click
        If ListDon.SelectedItems.Count > 0 Then
            With ListDon.SelectedItems(0)
                Dim mRecu As Printing.Recu = New Printing.Recu(.Text, .SubItems(3).Text, Printing.Recu.TYPE_RECU.DON)

                Using report As New Printing.RecuCaisse(mRecu)
                    report.ShowDialog()
                End Using
            End With
        Else
            Beep()
        End If
    End Sub
End Class