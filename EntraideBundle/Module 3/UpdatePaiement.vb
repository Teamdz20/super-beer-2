Public Class UpdatePaiement


    Dim etTable As EtudiantsTable = New EtudiantsTable

    Public revenu_id As Integer

    Public current_entity As New EtudiantEntity

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


    Private Sub UpdatePaiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbCode, "SELECT DISTINCT etudiants.id AS id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom) AS nom FROM etudiants INNER JOIN formations ON etudiants.id = formations.id_etudiant INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id INNER JOIN type_formation ON type_formation.id = formations.id_type_formation", "id", "nom")
        Util.PopulateCombo(cmbTypeFormation, "SELECT id, nom FROM type_formation", "id", "nom")
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        If cmbCode.SelectedValue = "0" Then
            Beep()
            Exit Sub
        End If

        txtDette.BackColor = Color.White

        Util.EmptyForm(GroupBox2)

        chkCheque.Checked = False
        chkEspece.Checked = True
        chkVirement.Checked = False

        Recherche()

    End Sub

    Public Sub Recherche()

        current_entity = etTable.GetById(cmbCode.SelectedValue)

        txtNom.Text = current_entity.nom
        txtPrenom.Text = current_entity.prenom
        cmbSex.Text = current_entity.sexe
        cmbSituation.Text = current_entity.situation_matri
        txtNbreEnfant.Text = current_entity.nombre_enfant
        txtLieu.Text = current_entity.lieu_naissance
        txtNationalite.Text = current_entity.nationnalite
        txtAdresse.Text = current_entity.adresse
        txtBP.Text = current_entity.bp
        txtPhone1.Text = current_entity.tel1
        txtPhone2.Text = current_entity.tel2
        txtMail.Text = current_entity.email
        cmbTypeFormation.Text = current_entity.TypeFormationId.Nom
        txtCout.Text = current_entity.Revenu.Montant
        txtMontantPaye.Text = current_entity.Paiement.MontantP
        txtDette.Text = current_entity.Revenu.Montant - current_entity.Paiement.MontantP
        txtCodeRevenu.Text = current_entity.Revenu.CodeRevenu
        txtActivite.Text = current_entity.Revenu.NomActivite
        If current_entity.Paiement.TypePaiement = "virement" Then
            chkVirement.Checked = True
        ElseIf current_entity.Paiement.TypePaiement = "espece" Then
            chkEspece.Checked = True
        Else
            chkCheque.Checked = True
        End If

        revenu_id = current_entity.Revenu.Id

        If txtDette.Text = "" Then
        Else
            txtMontantR.Text = txtDette.Text
        End If
        txtDette.BackColor = Color.Red

        btUpdate.Enabled = current_entity.id > 0

        btUpdate.Enabled = CDbl(txtDette.Text) > 0

    End Sub

    Private Sub chkEspece_CheckedChanged(sender As Object, e As EventArgs) Handles chkEspece.CheckedChanged
        If chkEspece.Checked Then
            chkVirement.Enabled = False
            chkCheque.Enabled = False

        Else
            chkVirement.Enabled = True
            chkCheque.Enabled = True
        End If
    End Sub

    Private Sub chkCheque_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheque.CheckedChanged
        If chkCheque.Checked Then
            chkVirement.Enabled = False
            chkEspece.Enabled = False

            txtNumCheque.Visible = True
        Else
            chkVirement.Enabled = True
            chkEspece.Enabled = True

            txtNumCheque.Visible = False
        End If
    End Sub

    Private Sub chkVirement_CheckedChanged(sender As Object, e As EventArgs) Handles chkVirement.CheckedChanged
        If chkVirement.Checked Then
            chkEspece.Enabled = False
            chkCheque.Enabled = False
        Else
            chkEspece.Enabled = True
            chkCheque.Enabled = True

        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        If txtMontantAPayer.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez remplir le champs Montant A Payer", 0)
        Else
            Try
                Dim montant As String = txtMontantAPayer.Text.Trim

                Dim mode_paiement As Integer = 1

                If chkEspece.Checked Then
                    mode_paiement = 1
                ElseIf chkCheque.Checked Then
                    mode_paiement = 2
                ElseIf chkVirement.Checked Then
                    mode_paiement = 3
                End If

                Dim id As Long = etTable.AddPaiement(revenu_id, montant, mode_paiement)

                If id = 0 Then
                    Util.ShowMessage(Me, "Addition de paiement échouée", 1)
                Else
                    Util.ShowMessage(Me, "Addition de paiement effectuée avec succès", 0)

                    Dim mRecu As New Printing.Recu(revenu_id, txtMontantAPayer.Text, Printing.Recu.TYPE_RECU.ETUDIANT)

                    Using report As New Printing.RecuCaisse(mRecu)
                        report.ShowDialog()
                    End Using

                    Recherche()
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


    Private Sub txtMontantAPayer_TextChanged_1(sender As Object, e As EventArgs) Handles txtMontantAPayer.TextChanged
        If txtMontantAPayer.Text.Trim.Length > 0 Then
            Dim saisie As Double = CDbl(txtMontantAPayer.Text.Trim)
            If saisie > CDbl(txtDette.Text) Then
                Beep()
                txtMontantAPayer.Text = "0"
            End If
        End If
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

    Private Sub txtMontantAPayer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontantAPayer.KeyPress
        Util.checkkey(e)
    End Sub
End Class