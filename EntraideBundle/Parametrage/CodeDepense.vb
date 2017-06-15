Imports EntraideBundle.Db.Tables

Public Class CodeDepense

    Public id As String = ""

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtCode.Text.Trim.Length = 0 Or txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        Else
            Dim table As CodeDepensesTable = New CodeDepensesTable

            If id.Length > 0 Then
                If table.Update(id, txtNom.Text.Trim, txtCode.Text.Trim) Then
                    Util.ShowMessage(Me, "Modification effectuer avec success")
                End If
                Close()
            Else
                Dim code_id As Long = table.Save(txtNom.Text.Trim, txtCode.Text.Trim)
                If code_id = 0 Then
                    Util.ShowMessage(Me, "Code dépense non enregistré", 1)
                Else
                    Util.ShowMessage(Me, "Code dépense enregistré avce succès")
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class