Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class AddBureau

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2)
        PanelContainer.Location = location
    End Sub

    Dim bTable As BureauTable = New BureauTable

    Public id_bureau As Integer = 0

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbEtudiant.Text.Length <= 0 And cmbPoste.Text.Length <= 0 Then
            Util.ShowMessage(Me, "Veuilez sélectionner un poste et un étudiant", 1)
        Else
            Dim id As Long = bTable.Save(cmbPoste.Text, cmbDate.Value, cmbEtudiant.SelectedValue)
            If id = 0 Then
                Util.ShowMessage(Me, "Etudiant non ajouté", 1)
            Else
                cmbPoste.Text = ""
                cmbEtudiant.SelectedValue = "0"
                RechercheAll()
            End If
        End If
    End Sub

    Public Sub RechercheAll()
        Try
            Dim liste As List(Of BureauAlumniEntity) = New List(Of BureauAlumniEntity)

            liste = bTable.GetAll

            ListeEtudiants.Items.Clear()

            For Each elem As BureauAlumniEntity In liste
                Dim item As New ListViewItem(elem.Id)
                item.SubItems.Add(elem.Etudiant.nom)
                item.SubItems.Add(elem.Poste)
                item.SubItems.Add(elem.DateFonction)

                ListeEtudiants.Items.Add(item)
            Next
        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            If ListeEtudiants.Items.Count = 3 Then
                btnAdd.Visible = False
            End If
        End Try
    End Sub

    Private Sub AddBureau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbEtudiant, " SELECT id, CONCAT_WS(' ', nom, prenom) as nom FROM etudiants WHERE etudiants.id IN (SELECT etudiant_id FROM graduations)", "id", "nom")
        RechercheAll()
    End Sub

    Private Sub ListeEtudiants_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListeEtudiants.ItemSelectionChanged
        If e.IsSelected Then
            btnUpdate.Visible = True
            btnAdd.Visible = False
            With ListeEtudiants.Items(e.ItemIndex)
                id_bureau = .SubItems(0).Text
                cmbEtudiant.Text = .SubItems(1).Text
                cmbPoste.Text = .SubItems(2).Text
                cmbDate.Value = .SubItems(3).Text
            End With
        Else
            btnUpdate.Visible = False
            btnAdd.Visible = True
            cmbPoste.Text = ""
            cmbEtudiant.SelectedValue = "0"
            cmbDate.Value = Today
        End If
    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbEtudiant.Text.Length <= 0 Or cmbPoste.Text.Length <= 0 Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Dim id As Long = bTable.UpdateBureau(id_bureau, cmbDate.Value, cmbPoste.Text, cmbEtudiant.SelectedValue)
            If id = 0 Then
                Util.ShowMessage(Me, "Mise à jour non éffectuée", 1)
            Else
                RechercheAll()
            End If
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub
End Class