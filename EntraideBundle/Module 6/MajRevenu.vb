Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class MajRevenu

    ''' <summary>
    ''' Responsive manage
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2) + 20
        PanelContainer.Location = location
    End Sub

    Dim revTable As RevenusTable = New RevenusTable

    Private Sub LoadRevenus()

    End Sub


    ''' <summary>
    ''' Filter
    ''' </summary>
    ''' <param name="byType"></param>
    ''' <remarks></remarks>
    Private Sub Recherche(Optional byType As Boolean = False)

        Dim liste As List(Of EntraideBundle.Db.Entities.RevenuEntity) = New List(Of EntraideBundle.Db.Entities.RevenuEntity)


        If byType Then
            liste = revTable.GetByAll(cmbAnnee.Text, cmbMois.SelectedValue, cmbRechType.SelectedValue)
        Else
            liste = revTable.GetByMonthYear(cmbAnnee.Text, cmbMois.SelectedValue)
        End If

        ListRevenu.Items.Clear()

        For Each elem As EntraideBundle.Db.Entities.RevenuEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Type.Nom)
            item.SubItems.Add(elem.Employe.Nom)
            item.SubItems.Add(FormatNumber(elem.Montant, 0))
            item.SubItems.Add(elem.RecuDe.Nom)
            item.SubItems.Add(elem.Reglement)
            item.SubItems.Add(elem.Devise.nom)
            item.SubItems.Add(elem.Memo)
            item.SubItems.Add(elem.Classification.Nom)
            item.SubItems.Add(elem.Date_revenu)
            item.SubItems.Add(elem.activite_financier_id)

            ListRevenu.Items.Add(item)

        Next
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        Util.PopulateCombo(cmbRechType, "SELECT id, nom FROM type_agrs", "id", "nom")
        Util.PopulateCombo(cmbClass, "SELECT id, nom FROM classification_revenus", "id", "nom")
        Util.PopulateCombo(cmbDevise, "SELECT id, nom FROM devises", "id", "nom")
        Util.PopulateCombo(cbNomManager, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbRecuDe, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbType, "SELECT id, nom AS type FROM type_agrs", "id", "type")
        Util.PopulateCombo(cmbActivite, "SELECT id, code FROM activite_financiers", "id", "code")

        Util.PopulateComboYear(cmbAnnee)

        Util.PopulateComboMonth(cmbMois)

    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        If cmbAnnee.Text.Length = 0 OrElse cmbMois.Text.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez selectionner l'annee et le mois", 1)
            Exit Sub
        End If
        If cmbRechType.SelectedValue <> "0" Then
            Recherche(True)
        Else
            Recherche()
        End If
    End Sub

    Private Sub ListRevenu_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListRevenu.ItemSelectionChanged
        If e.IsSelected Then
            With ListRevenu.Items(e.ItemIndex)
                txtMontant.Text = .SubItems(3).Text

                cmbRecuDe.Text = .SubItems(4).Text
                txtReglement.Text = .SubItems(5).Text
                idRev.Text = .SubItems(0).Text

                cmbClass.Text = .SubItems(8).Text
                cbNomManager.Text = .SubItems(2).Text
                txtPoste.Text = .SubItems(7).Text
                cmbDevise.Text = .SubItems(6).Text
                txtMemo.Text = .SubItems(8).Text
                cmbClass.Text = .SubItems(2).Text
                cmbRecuDe.Text = .SubItems(4).Text
                cmbType.Text = .SubItems(1).Text
                dtDate.Text = .SubItems(9).Text
                cmbActivite.SelectedValue = .SubItems(10).Text
            End With
        End If
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If cmbActivite.SelectedValue = "0" OrElse txtMontant.Text.Trim.Length = 0 OrElse txtReglement.Text.Trim.Length = 0 Or cmbClass.SelectedValue = "0" Or cmbDevise.SelectedValue = "0" Or cbNomManager.SelectedValue = "0" Or cmbRecuDe.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        Else
            Try

                Dim revenu As EntraideBundle.Db.Entities.RevenuEntity = New EntraideBundle.Db.Entities.RevenuEntity
                revenu.RecuDe.Id = cmbRecuDe.SelectedValue

                revenu.Devise.id = cmbDevise.SelectedValue

                revenu.Classification.Id = cmbClass.SelectedValue
                revenu.Type.Id = cmbType.SelectedValue

                revenu.Employe.Id = cbNomManager.SelectedValue

                revenu.Employe.Nom = cmbRecuDe.Text
                revenu.Montant = txtMontant.Text
                revenu.Reglement = txtReglement.Text
                revenu.Date_revenu = dtDate.Text
                revenu.Memo = txtMemo.Text
                revenu.Date_revenu = dtDate.Text
                revenu.Id = idRev.Text
                revenu.activite_financier_id = cmbActivite.SelectedValue

                Dim id As Long = revTable.UpdateRevenu(revenu)

                If id = 0 Then
                    Util.ShowMessage(Me, "Une erreur est survenu", 1)
                Else
                    Util.ShowMessage(Me, "Mise à jour éffectuée avec succès")
                    Close()
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
        ListRevenu.Items.Clear()
    End Sub

    Private Sub btVider_Click(sender As Object, e As EventArgs) Handles btVider.Click
        cmbActivite.Text = ""
        txtMemo.Text = ""
        txtMontant.Text = ""
        txtPoste.Text = ""
        txtReglement.Text = ""
        cmbClass.Text = ""
        cmbDevise.Text = ""
        cbNomManager.Text = ""
        cmbRecuDe.Text = ""
        dtDate.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class