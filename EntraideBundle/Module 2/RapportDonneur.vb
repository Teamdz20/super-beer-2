Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class RapportDonneur

    Dim donTable As DonneursTable = New DonneursTable

    Private Sub RapportDonneur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkPredef.Checked = True
        Util.PopulateComboYear(cbAnnee)
        cmbTypeRapport.Text = "Trimestriel"
        Recherche()
    End Sub

    Private Sub cbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub chkPredef_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPredef.CheckedChanged
        If ChkPredef.Checked Then
            chkAll.Checked = False
            ListeDonneur.Columns.Item(9).Width = 0
            ListeDonneur.Columns.Item(10).Width = 0
            ListeDonneur.Columns.Item(11).Width = 0
            ListeDonneur.Columns.Item(12).Width = 0
            ListeDonneur.Columns.Item(13).Width = 0
            ListeDonneur.Columns.Item(14).Width = 0
            ListeDonneur.Columns.Item(15).Width = 0

        Else
            chkAll.Checked = True
        End If

    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            ChkPredef.Checked = False
            ListeDonneur.Columns.Item(9).Width = 160
            ListeDonneur.Columns.Item(10).Width = 160
            ListeDonneur.Columns.Item(11).Width = 160
            ListeDonneur.Columns.Item(12).Width = 160
            ListeDonneur.Columns.Item(13).Width = 160
            ListeDonneur.Columns.Item(14).Width = 160
            ListeDonneur.Columns.Item(15).Width = 160
        Else
            ChkPredef.Checked = True
        End If
    End Sub

    Public Sub Recherche()
        Try
            Dim liste As List(Of DonneurEntity) = New List(Of DonneurEntity)
            liste = donTable.GetBydate(cmbDu.Value, cmbAu.Value)
            ListeDonneur.Items.Clear()

            Dim iter As Integer = 1

            For Each elem As DonneurEntity In liste
                Dim item As New ListViewItem(elem.id)
                item.SubItems.Add(elem.nom)
                item.SubItems.Add(elem.nom_representant)
                item.SubItems.Add(elem.adresse)
                item.SubItems.Add(elem.email)
                item.SubItems.Add(elem.date_donneur)
                item.SubItems.Add(elem.code)
                item.SubItems.Add(elem.tel1)
                item.SubItems.Add(elem.tel2)
                item.SubItems.Add(elem.CategorieDonneur.Nom)
                item.SubItems.Add(elem.site_internet)
                item.SubItems.Add(elem.restriction)
                item.SubItems.Add(elem.periode_sollicitation)
                item.SubItems.Add(elem.note_sollicitation)
                item.SubItems.Add(elem.poste)
                item.SubItems.Add(elem.type_don)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListeDonneur.Items.Add(item)
                iter += 1
            Next
        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            labelTotal.Text = FormatNumber(ListeDonneur.Items.Count, 0)
        End Try
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Recherche()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim report As New Printing.ReportDonneur(DonneursTable.data_source)
        report.ShowDialog()
    End Sub
End Class