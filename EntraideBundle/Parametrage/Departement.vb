Imports EntraideBundle.Db.Tables

Public Class Departement

    Public id As String = ""

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        Else
            Dim table As DepartementsTable = New DepartementsTable
            Try
                If id.Length > 0 Then
                    If table.Update(id, txtNom.Text.Trim) Then
                        Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    End If
                    Close()
                Else
                    Dim dep_id As Long = table.Save(txtNom.Text.Trim)
                    If dep_id = 0 Then
                        Util.ShowMessage(Me, "Enregistrement échoué", 1)
                    Else
                        Util.ShowMessage(Me, "Le département a été ajouté avec succès")
                        Close()
                    End If
                End If
            Catch ex As Exception
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


End Class