Imports MySql.Data.MySqlClient

Imports MetroFramework.Controls
Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class ListeRevenu


    Dim revTable As RevenusTable = New RevenusTable

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2) + 20
        PanelContainer.Location = location
    End Sub

    Private Sub LoadData(Optional byType As Boolean = False)
        Dim liste As List(Of EntraideBundle.Db.Entities.RevenuEntity) = New List(Of EntraideBundle.Db.Entities.RevenuEntity)

        If byType Then
            liste = revTable.GetByType(cmbDu.Value, cmbAu.Value, cmbType.SelectedValue)
        Else
            liste = revTable.GetByInterval(cmbDu.Value, cmbAu.Value)
        End If

        ListRevenu.Items.Clear()

        Dim total As Double = 0

        Try

            Dim iter As Integer = 1

            For Each elem As EntraideBundle.Db.Entities.RevenuEntity In liste
                Dim item As New ListViewItem(elem.Id)
                item.SubItems.Add(elem.Type.Nom)
                item.SubItems.Add(elem.Employe.Nom)
                item.SubItems.Add(elem.Montant)
                item.SubItems.Add(elem.RecuDe.Nom)
                item.SubItems.Add(elem.Reglement)
                item.SubItems.Add(elem.Poste)
                item.SubItems.Add(elem.Devise.nom)
                item.SubItems.Add(elem.Memo)
                item.SubItems.Add(elem.Classification.Nom)
                item.SubItems.Add(elem.Date_revenu)

                total += elem.Montant

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListRevenu.Items.Add(item)
                iter += 1
            Next
        Catch ex As Exception
            Util.ShowMessage(Me, "Fatal error : " & ex.Message, 2)
        Finally
            txtTotal.Text = FormatNumber(total, 0)
        End Try
    End Sub


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles Me.Load
        Util.PopulateComboYear(cmbAnnee)
        cmbTypeRapport.Text = "Mensuel"
        LoadData()
        Util.PopulateCombo(cmbType, "SELECT id, nom AS type FROM type_agrs", "id", "type")
    End Sub

    Private Sub cbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        If cmbType.Text.Length > 0 Then
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRapport_Click(sender As Object, e As EventArgs) Handles btnRapport.Click
        Dim periode As String = FormatDateTime(cmbDu.Value, DateFormat.ShortDate)
        periode &= " - " & FormatDateTime(cmbAu.Value, DateFormat.ShortDate)
        Using report As New Printing.ReportRevenu(RevenusTable.data_source, periode)
            report.ShowDialog()
        End Using
    End Sub

    Private Sub ImprimerLeRecuDeCaisseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerLeRecuDeCaisseToolStripMenuItem.Click
        If ListRevenu.SelectedItems.Count > 0 Then
            With ListRevenu.SelectedItems(0)
                Dim mRecu As Printing.Recu = New Printing.Recu(.Text, .SubItems(3).Text.Replace(" ", ""), Printing.Recu.TYPE_RECU.AGR)

                Using report As New Printing.RecuCaisse(mRecu)
                    report.ShowDialog()
                End Using
            End With
        Else
            Beep()
        End If
    End Sub
End Class