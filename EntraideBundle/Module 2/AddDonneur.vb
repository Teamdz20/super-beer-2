Imports EntraideBundle.Db.Tables

Public Class AddDonneur

    Dim DonTable As DonneursTable = New DonneursTable

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If txtAdresse.Text = "" Or txtMail.Text = "" Or txtNomDonneur.Text = "" Or txtNomRepresentant.Text = "" Or txtPhone1.Text = "" Or txtPoste.Text = "" Or txtPoste.Text = "" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Dim id As Long
            id = DonTable.Save(Me)
            If id = 0 Then
                Util.ShowMessage(Me, "Enregistrement échoué", 1)
            Else
                Util.ShowMessage(Me, "Donneur enregistré avec succèès", 0)
                Close()
            End If
        End If
    End Sub

    Private Sub AddDonneur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbCategorieDonneur, "SELECT id, nom FROM categorie_donneurs", "id", "nom")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub btClean_Click(sender As Object, e As EventArgs) Handles btClean.Click
        Util.EmptyForm(GroupBox1)
        Util.EmptyForm(GroupBox2)
    End Sub
End Class