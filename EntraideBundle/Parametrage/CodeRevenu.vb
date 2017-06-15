Imports EntraideBundle.Db

Public Class CodeRevenu

    Public id As String = ""

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtCode.Text.Trim.Length = 0 Or txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        Else
            If id.Length > 0 Then
                Database.Query("UPDATE activite_financiers SET nom  = '" & Util.E(txtNom.Text) & "', code = '" & Util.E(txtCode.Text) & "' WHERE id = '" & id & "'")
                id = Database.Execute
                Util.ShowMessage(Me, "Modification effectuer avec success")
                Close()
            Else
                Database.Query("INSERT INTO activite_financiers SET nom  = '" & Util.E(txtNom.Text) & "', code = '" & Util.E(txtCode.Text) & "'")
                id = Database.Execute
                If id.Length > 0 Then
                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    Close()
                Else
                    Util.ShowMessage(Me, "Une erreur est survenu, veuillez ressayer", 1)
                End If
            End If
        End If
    End Sub
End Class