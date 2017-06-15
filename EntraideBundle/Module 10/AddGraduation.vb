Imports EntraideBundle.Db.Tables

Public Class AddGraduation


    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2)
        PanelContainer.Location = location
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If cmbEtudiant.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez choisir un étudiant", 1)
        Else

            Dim etudiantTable As GraduationsTable = New GraduationsTable

            Dim id As Long = 0

            id = etudiantTable.Save(cmbDate.Value, txtNote.Text.Trim, cmbEtudiant.SelectedValue, My.Settings.user_id)
            If id = 0 Then
                Util.ShowMessage(Me, "Gradué non enregistré", 1)
            Else
                Util.ShowMessage(Me, "Gradué enregistré avec succès")
                Close()
            End If
        End If
    End Sub

    Private Sub AddGraduation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbEtudiant, "SELECT id, CONCAT_WS(' ',nom, prenom) as nom FROM etudiants WHERE etudiants.id NOT IN (SELECT etudiant_id FROM graduations)", "id", "nom")
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

    Private Sub cmbEtudiant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEtudiant.SelectedIndexChanged
        If IsNumeric(cmbEtudiant.SelectedValue) Then
            LoadDetails(id:=cmbEtudiant.SelectedValue)
        End If
    End Sub

    Private Sub LoadDetails(ByVal id As String)
        Try
            Db.Database.Query("SELECT etudiants.nom, etudiants.prenom, etudiants.sexe, etudiants.date_inscription, etudiants.tel1, etudiants.adresse, generations.libelle AS generation, type_formations.nom AS formation FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation WHERE etudiants.id = '" & id & "'")

            Dim result = Db.Database.ExecuteResult

            If result.HasRows Then
                While result.Read
                    txtNom.Text = result.GetValue(0).ToString
                    txtPrenom.Text = result.GetValue(1).ToString
                    txtSexe.Text = result.GetValue(2).ToString
                    txtDateInscription.Text = result.GetValue(3).ToString
                    txtTel.Text = result.GetValue(4).ToString
                    txtAdresse.Text = result.GetValue(5).ToString
                    txtGeneration.Text = result.GetValue(6).ToString
                    txtFormation.Text = result.GetValue(7).ToString
                End While
            Else
                txtNom.Clear()
                txtPrenom.Clear()
                txtSexe.Clear()
                txtDateInscription.Clear()
                txtTel.Clear()
                txtAdresse.Clear()
                txtGeneration.Clear()
                txtFormation.Clear()
            End If
            result.Close()
        Catch ex As Exception

        Finally
            Db.Database.CloseConnection()
        End Try
    End Sub
End Class