Imports EntraideBundle.Db.Tables

Public Class TypeFormation

    Public id As String = ""

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtMontant.Text.Trim.Length = 0 Or txtNom.Text = "" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        Else

            Dim typeTable As TypeFormationsTable = New TypeFormationsTable

            If id.Length > 0 Then
                If typeTable.Update(id, txtNom.Text, txtMontant.Text) Then
                    Util.ShowMessage(Me, "Modification effectuer avec success")
                    Close()
                End If
            Else
                Dim type_id As Long = typeTable.Save(txtNom.Text.Trim, txtMontant.Text.Trim)
                If type_id = 0 Then
                    Util.ShowMessage(Me, "Enregistrement non effectué", 2)
                Else
                    Util.ShowMessage(Me, "Type de formation ajouté avec succès")
                    Close()
                End If
            End If
        End If
    End Sub

    Private Sub txtMontant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontant.KeyPress
        Util.checkkey(e)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub
End Class