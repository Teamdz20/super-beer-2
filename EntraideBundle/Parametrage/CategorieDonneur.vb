Imports EntraideBundle.Db.Tables

Public Class CategorieDonneur

    Public id As String = ""


    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez entrer le nom de la catégorie", 0)
        Else

            Dim table As CategorieDonneursTable = New CategorieDonneursTable

            If id.Length > 0 Then
                If table.Update(id, txtNom.Text.Trim) Then
                    Util.ShowMessage(Me, "Modification effectuer avec success")
                End If
                Close()
            Else

                Dim cat_id As Long = table.Save(txtNom.Text.Trim)
                If cat_id = 0 Then
                    Util.ShowMessage(Me, "Catégorie non enregistré", 1)
                Else
                    Util.ShowMessage(Me, "Catérie donneur enregistré avec succès")
                    Close()
                End If
            End If


        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class