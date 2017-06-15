Imports EntraideBundle.Db

Public Class Generation

    Public id As String = ""

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtLibelle.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez saisir le libellé", 1)
        Else
            If id.Length > 0 Then
                Database.Query("UPDATE generations SET libelle = '" & Util.E(txtLibelle.Text) & "', description = '" & Util.E(txtDescription.Text) & "' WHERE id = '" & id & "' ")
                id = Database.Execute
                Util.ShowMessage(Me, "Modification effectuer avec success")
                Close()
            Else
                Database.Query("INSERT INTO generations SET libelle = '" & Util.E(txtLibelle.Text) & "', description = '" & Util.E(txtDescription.Text) & "'")
                id = Database.Execute
                If id > 0 Then
                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    Close()
                Else
                    Util.ShowMessage(Me, "Une erreur est survenu, reessayer", 1)
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class