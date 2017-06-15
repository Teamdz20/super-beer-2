Imports MetroFramework.Controls
Imports MetroFramework
Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class Revenu

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


    Dim revenuTable As New RevenusTable

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim revTAble As RevenusTable = New RevenusTable

        If txtMontant.Text.Trim.Length = 0 OrElse txtReglement.Text.Trim.Length = 0 OrElse cmbClassification.SelectedValue = "0" OrElse cmbDevise.SelectedValue = "0" OrElse cmbManager.SelectedValue = "0" OrElse cmbRecuDe.SelectedValue = "0" OrElse cmbActivite.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        ElseIf Not IsNumeric(txtMontant.Text) Then
            Util.ShowMessage(Me, "Le montant doit être de type numérique", 1)
        Else
            Try

                Dim revenu As EntraideBundle.Db.Entities.RevenuEntity = New EntraideBundle.Db.Entities.RevenuEntity
                revenu.RecuDe.Id = cmbRecuDe.SelectedValue

                revenu.Devise.id = cmbDevise.SelectedValue

                revenu.Classification.Id = cmbClassification.SelectedValue
                revenu.Type.Id = cmbType.SelectedValue

                revenu.Employe.Id = cmbManager.SelectedValue

                revenu.Employe.Nom = cmbRecuDe.Text
                revenu.Montant = txtMontant.Text
                revenu.Reglement = txtReglement.Text
                revenu.Date_revenu = dtDate.Text
                revenu.Memo = txtMemo.Text
                revenu.Date_revenu = dtDate.Text
                revenu.activite_financier_id = cmbActivite.SelectedValue

                Dim id As Long = revenuTable.Save(revenu)

                If id = 0 Then
                    MsgBox("Non enregistré")
                Else
                    Util.ShowMessage(Me, "Revenu encaissé avec succès")
                    Dim mRecu As Printing.Recu = New Printing.Recu(id, txtMontant.Text, Printing.Recu.TYPE_RECU.AGR)

                    Using report As New Printing.RecuCaisse(mRecu)
                        report.ShowDialog()
                    End Using

                    Close()
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Echec de connection")
                End If
            End Try
        End If
    End Sub



    Private Sub revenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        Util.PopulateCombo(cmbManager, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbDevise, "SELECT id, nom FROM devises", "id", "nom")
        Util.PopulateCombo(cmbRecuDe, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbClassification, "SELECT id, nom FROM classification_revenus ", "id", "nom")
        Util.PopulateCombo(cmbType, "SELECT id, nom FROM type_agrs", "id", "nom")

        Util.PopulateCombo(cmbActivite, "SELECT id, code FROM activite_financiers", "id", "code")
    End Sub




    Private Sub txtMontant_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtMontant.KeyPress
        Util.checkkey(e)
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs)
        'Me.Visible = False
        'MajRevenu.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'Dim form As New Form4
        'form.ShowDialog()

        'Dim nom As String = form.txtNom.Text & " " & form.txtPrenom.Text

        'cbNomManager.Text = nom
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

    Private Sub btVider_Click(sender As Object, e As EventArgs) Handles btVider.Click
        Util.EmptyForm(PanelContainer)
    End Sub
End Class
