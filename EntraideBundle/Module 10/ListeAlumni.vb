Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class ListeAlumni


    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2)
        PanelContainer.Location = location
    End Sub

    Dim etudiantTable As GraduationsTable = New GraduationsTable

    Private Sub ListeAlumni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Sub LoadData(Optional byName As Boolean = False)
        Try

            Dim liste As List(Of GraduationEntity) = New List(Of GraduationEntity)

            If byName Then
                liste = etudiantTable.GetMembersByName(txtNom.Text.Trim)
            Else
                liste = etudiantTable.GetMembers
            End If

            ListeEtudiants.Items.Clear()

            Dim iter As Integer = 1

            For Each elem As GraduationEntity In liste
                Dim item As New ListViewItem(elem.Id)
                item.SubItems.Add(elem.Etudiant.nom)
                item.SubItems.Add(elem.Etudiant.tel1)
                item.SubItems.Add(elem.Etudiant.email)
                item.SubItems.Add(elem.DateGraduation)
                item.SubItems.Add(elem.Etudiant.TypeFormationId.Nom)
                item.SubItems.Add(elem.Etudiant.adresse)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListeEtudiants.Items.Add(item)

                iter += 1
            Next
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        Finally
            labelTotal.Text = FormatNumber(ListeEtudiants.Items.Count, 0)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        LoadData()
    End Sub


    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        LoadData(True)
    End Sub
End Class