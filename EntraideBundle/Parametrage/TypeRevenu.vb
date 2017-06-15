Imports EntraideBundle.Db.Entities

Public Class TypeRevenu

    Public id As String = ""

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez saisir le nom", 1)
        Else
            If id.Length > 0 Then
                Dim entity As TypeAgrEntity = New TypeAgrEntity
                entity.nom = txtNom.Text.Trim
                entity.id = id
                entity.IsChanged = True
                entity.Save()
                Util.ShowMessage(Me, "Modification effectuer avec success")
                Close()
            Else
                Dim entity As TypeAgrEntity = New TypeAgrEntity
                entity.nom = txtNom.Text.Trim
                If entity.Save Then
                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    Close()
                Else
                    Util.ShowMessage(Me, "Une erreur est survenu", 1)
                End If
            End If
        End If
    End Sub
End Class