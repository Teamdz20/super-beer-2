Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class ListeDepenses

    Dim liste_depenses As New List(Of DepenseEntity)

    Dim depTable As New DepensesTable


    Private Sub LoadData(Optional byType As Boolean = False, Optional byAll As Boolean = False)

        Dim total As Double = 0

        Try

            liste_depenses.Clear()

            ListDepense.Items.Clear()

            If byType Then
                liste_depenses = depTable.GetByIntervalType(cmbDu.Value, cmbAu.Value, cmbTypeDepense.SelectedValue)
            ElseIf byAll Then
                liste_depenses = depTable.GetAll
            Else
                liste_depenses = depTable.GetByInterval(cmbDu.Value, cmbAu.Value)
            End If

            Dim iter As Integer = 1

            For Each theEntity As DepenseEntity In liste_depenses
                Dim item As New ListViewItem(theEntity.id)
                item.SubItems.Add(theEntity.motif_depense)
                item.SubItems.Add(FormatNumber(theEntity.montant, 0))
                item.SubItems.Add(theEntity.Devise.nom)
                item.SubItems.Add(theEntity.Realisateur.FullName)
                item.SubItems.Add(theEntity.Beneficiaire.FullName)
                item.SubItems.Add(theEntity.TypeDepense.nom)
                item.SubItems.Add(theEntity.Departement.nom)
                item.SubItems.Add(theEntity.CodeDepense.nom)
                item.SubItems.Add(theEntity.CodeDepense.code)
                item.SubItems.Add(theEntity.Manager.FullName)
                item.SubItems.Add(theEntity.code_demande)
                item.SubItems.Add(theEntity.created)
                item.SubItems.Add(theEntity.Programme.nom)

                total += theEntity.montant

                If iter = 4 Then
                    iter = 0
                    item.BackColor = Color.AliceBlue
                End If

                ListDepense.Items.Add(item)
                iter += 1
            Next

        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            txtTotal.Text = FormatNumber(total, 0)
        End Try
    End Sub



    Private Sub ListeDepenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        Util.PopulateCombo(cmbTypeDepense, "SELECT id, nom FROM type_depenses", "id", "nom")
        cmbTypeRapport.Text = "Mensuel"
        LoadData()
        ckPredefini.Checked = True
    End Sub

    Private Sub btRecherche_Click(sender As Object, e As EventArgs) Handles btRecherche.Click
        If cmbTypeDepense.SelectedValue <> "0" Then
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub

    Private Sub linkAll_Click(sender As Object, e As EventArgs) Handles linkAll.Click
        cmbTypeDepense.SelectedValue = "0"
        LoadData(False, True)
    End Sub

    Private Sub cmbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Close()
    End Sub

    Private Sub ckDetail_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckPredefini_CheckedChanged(sender As Object, e As EventArgs) Handles ckPredefini.CheckedChanged
        If ckPredefini.Checked Then
            For i As Integer = 8 To 13
                ListDepense.Columns(i).Width = 0
            Next
        End If
    End Sub

    Private Sub ckDetail_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckDetail.CheckedChanged
        If ckDetail.Checked Then
            For i As Integer = 8 To 13
                ListDepense.Columns(i).Width = 200
            Next
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim form As New Printing.ReportDepenses(DepensesTable.data_set)
        form.total = txtTotal.Text.Trim
        form.ShowDialog()
    End Sub
End Class