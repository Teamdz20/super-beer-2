Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class ListeMateriel


    Dim matTable As MaterielsTable = New MaterielsTable

    Private Sub Responive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim pos As New Point
        pos.X = (Me.Width - PanelContainer.Width) / 2
        pos.Y = ((Me.Height - PanelContainer.Height) / 2) + 30
        PanelContainer.Location = pos
    End Sub

    Private Sub LoadData(Optional byMode As Boolean = False, Optional byDepartement As Boolean = False, Optional byModeDep As Boolean = False)

        Dim liste_materiel As List(Of MaterielEntity) = New List(Of MaterielEntity)
       
        If byMode Then
            liste_materiel = matTable.GetByMode(cmbDu.Value, cmbAu.Value, cmbModeObtention.Text)
        ElseIf byDepartement Then
            liste_materiel = matTable.GetByDepartement(cmbDu.Value, cmbAu.Value, cmbDepartement.SelectedValue)
        ElseIf byModeDep Then
            liste_materiel = matTable.GetByModeDepartement(cmbDu.Value, cmbAu.Value, cmbModeObtention.Text, cmbDepartement.SelectedValue)
        Else
            liste_materiel = matTable.GetByDefault(cmbDu.Value, cmbAu.Value)
        End If

        Try
            Dim iter As Integer = 1
            ListMateriel.Items.Clear()
            Dim index As Integer = 0

            For Each theEntity As MaterielEntity In liste_materiel
                Dim item As New ListViewItem(theEntity.id)
                item.SubItems.Add(theEntity.TypeMateriel.nom)
                item.SubItems.Add(theEntity.marque)
                item.SubItems.Add(theEntity.description)
                item.SubItems.Add(theEntity.mode_obtention)
                item.SubItems.Add(FormatNumber(theEntity.prix_achat, 0))
                item.SubItems.Add(FormatNumber(theEntity.quantite, 0))
                item.SubItems.Add(theEntity.code)
                item.SubItems.Add(theEntity.num_facture)
                item.SubItems.Add(theEntity.Achat.CodeDepense.code)
                item.SubItems.Add(FormatNumber(theEntity.Achat.cout, 0))
                item.SubItems.Add(theEntity.Achat.Fournisseur.nom)
                item.SubItems.Add(theEntity.Don.Donneur.nom)
                item.SubItems.Add(theEntity.Departement.nom)
                item.SubItems.Add(theEntity.activite)
                item.SubItems.Add(theEntity.Employe.FullName)

                item.SubItems.Add(index)


                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListMateriel.Items.Add(item)
                iter += 1
                index += 1
            Next

        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            txtTotal.Text = ListMateriel.Items.Count
        End Try

    End Sub

    Private Sub ListeMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)
        cmbTypeRapport.Text = "Annuel"
        ckPredefini.Checked = True
        TriggerSearch()
    End Sub

    Private Sub TriggerSearch()
        If ckMode.Checked AndAlso ckDep.Checked = False Then
            LoadData(True)
        ElseIf ckMode.Checked = False AndAlso ckDep.Checked Then
            LoadData(False, True)
        ElseIf ckMode.Checked = True AndAlso ckDep.Checked = True Then
            LoadData(False, False, True)
        Else
            LoadData()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TriggerSearch()
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

   
    Private Sub ckDep_CheckedChanged(sender As Object, e As EventArgs) Handles ckDep.CheckedChanged
        cmbDepartement.Enabled = ckDep.Checked
        If ckDep.Checked = False Then
            cmbDepartement.SelectedValue = "0"
        End If
    End Sub

    Private Sub ckMode_CheckedChanged(sender As Object, e As EventArgs) Handles ckMode.CheckedChanged
        cmbModeObtention.Enabled = ckMode.Checked
        If ckMode.Checked = False Then
            cmbModeObtention.Text = ""
        End If
    End Sub

    Private Sub cmbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub ckPredefini_CheckedChanged(sender As Object, e As EventArgs) Handles ckPredefini.CheckedChanged
        If ckPredefini.Checked Then
            For i As Integer = 7 To 15
                ListMateriel.Columns(i).Width = 0
            Next
        End If
    End Sub

    Private Sub ckDetail_CheckedChanged(sender As Object, e As EventArgs) Handles ckDetail.CheckedChanged
        If ckDetail.Checked Then
            For i As Integer = 7 To 15
                ListMateriel.Columns(i).Width = 200
            Next
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim form As New Printing.ReportMateriels(MaterielsTable.data_set)
        form.ShowDialog()
    End Sub
End Class