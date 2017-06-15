Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class RapportFournisseur

    Dim fournisseurTable As FournisseursTable = New FournisseursTable

    Private Sub RapportFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkPredef.Checked = True
        Util.PopulateComboYear(cmbAnnee)
        cmbTypeRapport.Text = "Trimestriel"
        Recherche()
    End Sub

    Private Sub cbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Public Sub Recherche()
        Try
            Dim liste As List(Of FournisseurEntity) = New List(Of FournisseurEntity)

            liste = fournisseurTable.GetByDate(cmbDu.Value, cmbAu.Value)

            ListeFournisseur.Items.Clear()

            Dim iter As Integer = 1

            For Each elem As FournisseurEntity In liste
                Dim item As New ListViewItem(elem.id)
                item.SubItems.Add(elem.nom)
                item.SubItems.Add(elem.nom_representant)
                item.SubItems.Add(elem.adresse)
                item.SubItems.Add(elem.email)
                item.SubItems.Add(elem.created)
                item.SubItems.Add(elem.code)
                item.SubItems.Add(elem.tel1)
                item.SubItems.Add(elem.tel2)
                item.SubItems.Add(elem.CategorieFournisseur.Nom)
                item.SubItems.Add(elem.site)
                item.SubItems.Add(elem.domaine_business)
                item.SubItems.Add(elem.classification_prix)
                item.SubItems.Add(elem.note)
                item.SubItems.Add(elem.poste)
                item.SubItems.Add(elem.produit)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListeFournisseur.Items.Add(item)
                iter += 1
            Next
        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            labelTotal.Text = FormatNumber(ListeFournisseur.Items.Count, 0)
        End Try
    End Sub


    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Recherche()
    End Sub

    Private Sub ChkPredef_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkPredef.CheckedChanged
        If ChkPredef.Checked Then
            chkAll.Checked = False
            ListeFournisseur.Columns.Item(9).Width = 0
            ListeFournisseur.Columns.Item(10).Width = 0
            ListeFournisseur.Columns.Item(11).Width = 0
            ListeFournisseur.Columns.Item(12).Width = 0
            ListeFournisseur.Columns.Item(13).Width = 0
            ListeFournisseur.Columns.Item(14).Width = 0
            ListeFournisseur.Columns.Item(15).Width = 0
        Else
            chkAll.Checked = True
        End If
    End Sub



    Private Sub chkAll_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            ChkPredef.Checked = False
            ListeFournisseur.Columns.Item(9).Width = 160
            ListeFournisseur.Columns.Item(10).Width = 160
            ListeFournisseur.Columns.Item(11).Width = 160
            ListeFournisseur.Columns.Item(12).Width = 160
            ListeFournisseur.Columns.Item(13).Width = 160
            ListeFournisseur.Columns.Item(14).Width = 160
            ListeFournisseur.Columns.Item(15).Width = 160
        Else
            ChkPredef.Checked = True
        End If
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRapport_Click(sender As Object, e As EventArgs) Handles btnRapport.Click
        Dim form As New Printing.ReportFournisseurs(FournisseursTable.data_source)
        form.ShowDialog()

    End Sub
End Class