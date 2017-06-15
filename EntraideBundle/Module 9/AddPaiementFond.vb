Public Class AddPaiementFond

    Dim etudiantTable As EtudiantsTable = New EtudiantsTable

    Public id_fond As Integer = 0

    Private Sub AddPaiementFond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNumFond.Visible = False
        Recherche(True)
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
            lbCheque.Visible = True
            txtNumCheque.Visible = True
        Else
            chkVirement.Enabled = True
            chkEspece.Enabled = True

            txtNumCheque.Visible = False
            lbCheque.Visible = False

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

    Public Sub Recherche(Optional byDefault As Boolean = False)

        Dim liste As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)

        If byDefault Then
            liste = etudiantTable.GetFondDefault
        Else
            liste = etudiantTable.GetFondByEtudiantName(txtNom.Text)
        End If

        ListeEtudiants.Items.Clear()

        For Each elem As FondSoutienEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Etudiant.nom)
            item.SubItems.Add(FormatNumber(elem.Paiement.MontantP, 0))
            If CDbl(elem.Paiement.MontantP) < CDbl(elem.MontantRecu) + CDbl(elem.Interet) + CDbl(elem.Penalite) Then
                item.SubItems.Add(FormatNumber(CDbl(elem.MontantRecu) + CDbl(elem.Interet) + CDbl(elem.Penalite) - CDbl(elem.Paiement.MontantP), 0))
            Else
                item.SubItems.Add("0")
            End If
            item.SubItems.Add(elem.DateDebut)
            item.SubItems.Add(elem.DateFin)
            item.SubItems.Add(elem.Echeance)

            ListeEtudiants.Items.Add(item)
        Next
    End Sub


    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        If txtMontantAPayer.Text = "0" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 0)
        Else
            Try
                Try

                    Dim id As Long = etudiantTable.SavePaiement(Me)

                    If id = 0 Then
                        Util.ShowMessage(Me, "Addition de paiement échouée", 1)
                    Else

                        Util.ShowMessage(Me, "Paiement enregistré avec succès")

                        Using report As New Printing.RecuFond(id_fond)
                            report.ShowDialog()
                        End Using

                        Recherche()

                        txtDette.Text = ""
                        txtMontantAPayer.Text = ""
                        txtMontantR.Text = ""
                        txtMontantRecu.Text = ""
                        txtNbreEff.Text = ""
                        txtNbreR.Text = ""
                        txtNumCheque.Text = ""
                    End If

                Catch ex As Exception
                    If My.Settings.app_debug_mode Then
                        MsgBox(ex.ToString)
                    Else
                        MsgBox("Echec de connection")
                    End If
                End Try

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub ListeEtudiants_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListeEtudiants.ItemSelectionChanged
        If e.IsSelected Then
            txtMontantR.Text = ""
            With ListeEtudiants.Items(e.ItemIndex)
                txtMontantRecu.Text = CDbl(.SubItems(2).Text.Trim("F") + CDbl(.SubItems(3).Text.Trim("F"))) & "F"
                txtDette.Text = .SubItems(3).Text
                id_fond = .SubItems(0).Text
                lbNumFond.Visible = True
                lbNumFond.Text = .SubItems(1).Text
                txtNbreEff.Text = etudiantTable.GetPaiement(.SubItems(0).Text)
                If txtNbreEff.Text <= CDbl(.SubItems(6).Text) Then
                    txtNbreR.Text = CDbl(.SubItems(6).Text) - CDbl(txtNbreEff.Text)
                Else
                    txtNbreR.Text = "0"
                End If
                If .SubItems(3).Text = "0F" Then
                    lbPAiement.Text = "Dette soldée, Merci à vous!"
                    lbPAiement.TextAlign = ContentAlignment.BottomLeft

                    lbMontP.Visible = False
                    lbMontR.Visible = False
                    lbTypeP.Visible = False
                    txtMontantAPayer.Visible = False
                    txtMontantR.Visible = False
                    chkCheque.Visible = False
                    chkEspece.Visible = False
                    chkVirement.Visible = False
                    btUpdate.Visible = False
                Else
                    lbPAiement.Text = "NOUVEAU PAIEMENT"
                    lbMontP.Visible = True
                    lbMontR.Visible = True
                    lbTypeP.Visible = True
                    txtMontantAPayer.Visible = True
                    txtMontantR.Visible = True
                    chkCheque.Visible = True
                    chkEspece.Visible = True
                    chkVirement.Visible = True
                    btUpdate.Visible = True
                End If
            End With


        Else
            lbNumFond.Text = ""
            lbNumFond.Visible = False

        End If
    End Sub

    Private Sub txtMontantAPayer_TextChanged(sender As Object, e As EventArgs) Handles txtMontantAPayer.TextChanged
        If IsNumeric(txtMontantAPayer.Text) Then
            txtMontantAPayer.BackColor = Color.White
            txtMontantR.Text = CDbl(txtDette.Text.Trim("F") - CDbl(txtMontantAPayer.Text.Trim("F"))) & "F"
            If CDbl(txtMontantAPayer.Text.Trim("F") <= CDbl(txtDette.Text.Trim("F"))) Then
            Else

                Try

                    txtMontantAPayer.Text = txtMontantAPayer.Text.Remove(txtMontantAPayer.Text.Length - 1, 1)
                    txtMontantAPayer.SelectAll()

                    txtMontantAPayer.Text = txtMontantAPayer.Text.Insert(txtMontantAPayer.Text.Length, "")
                    txtMontantAPayer.Select(txtMontantAPayer.Text.Length, 1)

                Catch ex As Exception
                End Try


            End If

        ElseIf txtMontantAPayer.Text.Length <= 0 Then
            txtMontantAPayer.Text = ""
            txtMontantR.Text = ""
        Else

            Try
                txtMontantAPayer.Text = txtMontantAPayer.Text.Remove(txtMontantAPayer.Text.Length - 1, 1)
                txtMontantAPayer.SelectAll()

                txtMontantAPayer.Text = txtMontantAPayer.Text.Insert(txtMontantAPayer.Text.Length, "")
                txtMontantAPayer.Select(txtMontantAPayer.Text.Length, 1)

                txtMontantAPayer.BackColor = Color.Red

                Beep()


            Catch ex As Exception
            End Try


        End If
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged

        Recherche()
        If txtNom.Text.Trim.Length <= 0 And chkAll.Checked = False Then
            ListeEtudiants.Items.Clear()
            lb_msg.Visible = False
        ElseIf ListeEtudiants.Items.Count <= 0 Then
            lb_msg.Visible = True
            lb_msg.Text = etudiantTable.tempText
        ElseIf chkAll.Checked = True And txtNom.Text.Trim.Length > 0 Then
            chkAll.Checked = False
        Else
            lb_msg.Visible = False
        End If
    End Sub
    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        lb_msg.Visible = False
        If chkAll.Checked Then
            Recherche()
            txtNom.Text = ""
        End If
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Close()
    End Sub

End Class