Imports EntraideBundle.Db.Tables

Public Class Poste

    Public id As String = ""

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez entrer le nom du poste à ajouter", 1)
        Else

            Dim table As PostesTable = New PostesTable

            Try
                If id.Length > 0 Then
                    If table.UpdatePoste(id, txtNom.Text.Trim) > 0 Then
                        Util.ShowMessage(Me, "Modification effectuer avec success")
                    End If
                    Close()
                Else
                    Dim poste_id As Long = table.Save(txtNom.Text.Trim)
                    If poste_id = 0 Then
                        Util.ShowMessage(Me, "Enregistrement non éffectué", 2)
                    Else
                        Util.ShowMessage(Me, "Le poste a été ajouté avec succès")
                        Close()
                    End If
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            End Try
        End If
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub
End Class