Imports EntraideBundle.Db.Entities

Public Class Programmes

    Public id As String = ""

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If txtNom.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez saisir le nom", 1)
        ElseIf txtCode.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez saisir le code", 1)
        Else
            If id.Length > 0 Then
                Dim p As ProgrammeEntity = New ProgrammeEntity
                p.code = txtCode.Text.Trim
                p.nom = txtNom.Text.Trim
                p.id = id
                p.IsChanged = True
                p.Save()
                Util.ShowMessage(Me, "Edition effectuer avec success")
                Close()
            Else
                Dim p As ProgrammeEntity = New ProgrammeEntity
                p.code = txtCode.Text.Trim
                p.nom = txtNom.Text.Trim
                If p.Save > 0 Then
                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    Close()
                Else
                    Util.ShowMessage(Me, "Une erreur est survenu", 1)
                End If
            End If
        End If
    End Sub
End Class