Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class RapportGraduation

    Dim gradTable As GraduationsTable = New GraduationsTable

    Public id_graduation As Integer = 0


    Public Sub LoadData(Optional byDate As Boolean = False, Optional byEtudiant As Boolean = False, Optional byGeneration As Boolean = False, Optional byFormation As Boolean = False)
        Try

            Dim liste As List(Of GraduationEntity) = New List(Of GraduationEntity)

            If byDate Then
                liste = gradTable.GetByDate(Util.GetDateToMysqlFormat(cmbDu.Value), Util.GetDateToMysqlFormat(cmbAu.Value))
            ElseIf byEtudiant Then
                liste = gradTable.GetByEtudiant(cmbEtudiant.SelectedValue)
            ElseIf byGeneration = True AndAlso byFormation = False Then
                liste = gradTable.GetByGeneration(cmbGeneration.SelectedValue)
            ElseIf byFormation = True AndAlso byGeneration = False Then
                liste = gradTable.GetByFormation(Util.GetDateToMysqlFormat(cmbDu), Util.GetDateToMysqlFormat(cmbAu), cmbFormation.SelectedValue)
            Else
                liste = gradTable.GetAll
            End If

            ListeGraduation.Items.Clear()

            Dim iter As Integer = 1

            For Each elem As GraduationEntity In liste
                Dim item As New ListViewItem(elem.Id)
                item.SubItems.Add(elem.Etudiant.nom)
                item.SubItems.Add(elem.Etudiant.prenom)
                item.SubItems.Add(elem.Etudiant.tel1)
                item.SubItems.Add(elem.Etudiant.adresse)
                item.SubItems.Add(elem.Etudiant.generation_id)
                item.SubItems.Add(elem.Etudiant.TypeFormationId.Nom)
                item.SubItems.Add(elem.DateGraduation)
                'item.SubItems.Add(elem.Note)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListeGraduation.Items.Add(item)
                iter += 1
            Next

        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            labelTotal.Text = FormatNumber(ListeGraduation.Items.Count, 0)
        End Try
    End Sub

    Private Sub RapportGraduation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        Util.PopulateCombo(cmbEtudiant, "SELECT id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom) AS nom FROM etudiants WHERE etudiants.id IN (SELECT etudiant_id FROM graduations)", "id", "nom")
        Util.PopulateCombo(cmbGeneration, "SELECT id, libelle FROM generations", "id", "libelle")
        Util.PopulateCombo(cmbFormation, "SELECT id, nom FROM type_formations", "id", "nom")

        cmbTypeRapport.Text = "Annuel"

        LoadData(True)
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click

        If ckEtudiant.Checked Then
            LoadData(False, True)
        ElseIf ckGeneration.Checked Then
            LoadData(False, False, True)
        ElseIf ckFormation.Checked Then
            LoadData(False, False, False, True)
        Else
            LoadData(True)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ckEtudiant_CheckedChanged(sender As Object, e As EventArgs) Handles ckEtudiant.CheckedChanged
        cmbEtudiant.Enabled = ckEtudiant.Checked
        If ckEtudiant.Checked Then
            ckGeneration.Checked = False
        End If
    End Sub

    Private Sub ckGeneration_CheckedChanged(sender As Object, e As EventArgs) Handles ckGeneration.CheckedChanged
        cmbGeneration.Enabled = ckGeneration.Checked
        If ckGeneration.Checked Then
            ckEtudiant.Checked = False
        End If
    End Sub

    Private Sub ckFormation_CheckedChanged(sender As Object, e As EventArgs) Handles ckFormation.CheckedChanged
        cmbFormation.Enabled = ckFormation.Checked
        If ckFormation.Checked Then
            ckEtudiant.Checked = False
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub


    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim generation As String = cmbGeneration.Text.Trim
        If generation.Length = 0 Then generation = "Toutes"

        Dim formation As String = cmbFormation.Text.Trim
        If formation.Length = 0 Then formation = "Toutes"

        Using report As New Printing.ReportGraduation(GraduationsTable.data_source, generation, formation)
            report.ShowDialog()
        End Using
    End Sub
End Class