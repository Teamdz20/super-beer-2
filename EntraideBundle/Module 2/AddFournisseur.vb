Imports EntraideBundle.Db.Tables

Public Class AddFournisseur
    Dim fournisseurTable As FournisseursTable = New FournisseursTable
    Private Sub AddFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Util.PopulateCombo(cmbCategorie, " SELECT id, nom FROM categorie_donneurs", "id", "nom")

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If txtAdresse.Text = "" Or txtMail.Text = "" Or txtNomSociete.Text = "" Or txtNomRepresentant.Text = "" Or txtPhone1.Text = "" Or txtPoste.Text = "" Or txtPoste.Text = "" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Dim id As Long
            id = fournisseurTable.Save(Me)
            If id = 0 Then
                Util.ShowMessage(Me, "Enregistrement échoué", 1)
            Else
                Util.ShowMessage(Me, "Donneur enregistré avec succès", 0)
                Close()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class