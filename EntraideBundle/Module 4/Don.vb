Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db
Imports EntraideBundle.Db.Entities


Public Class Don

    Private Sub Don_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateActiviteFinancier()

        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)

        PopulateDonneurs()

    End Sub

    Private Sub PopulateActiviteFinancier()
        Dim dt As DataTable = Database.GetDataTable("SELECT id, nom, code FROM activite_financiers")
        Dim row = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbActiviteFinancier.DataSource = dt
        cmbActiviteFinancier.DisplayMember = "nom"
        cmbActiviteFinancier.ValueMember = "id"

        cmbCodeRevenu.DataSource = dt
        cmbCodeRevenu.DisplayMember = "code"
        cmbCodeRevenu.ValueMember = "id"
    End Sub

    Private Sub PopulateDonneurs()
        Dim dt As DataTable = Database.GetDataTable(DonneursTable.SQL_COMBO)
        Dim row = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbCodeDonneur.DataSource = dt
        cmbCodeDonneur.ValueMember = DonneursTable.P_K
        cmbCodeDonneur.DisplayMember = "code"

        cmbDonneur.DataSource = dt
        cmbDonneur.DisplayMember = DonneursTable.D_N
        cmbDonneur.ValueMember = DonneursTable.P_K
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ckNonSollicite.Checked And (txtMontantSollicite.Text.Length = 0 And txtMontantSollicite.Text = "0") Then
            Util.ShowMessage(Me, "Veuillez selectionner le montant sollicité", 1)
        ElseIf txtMontrecu.Text.Length = 0 OrElse txtMontrecu.Text = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le montant réçu", 1)
        ElseIf txtActiviteMenee.Text.Trim.Length = 0 Then
            Util.ShowMessage(Me, "Veuillez saisir l'activite menee", 1)
        ElseIf cmbDonneur.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le donneur", 1)
        ElseIf cmbActiviteFinancier.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner l'activiter financier", 1)
        ElseIf cmbDepartement.SelectedValue = "0" Then
            Util.ShowMessage(Me, "Veuillez selectionner le departement", 1)
        Else
            Using trans As EntraideOrm.LUNA.LunaTransactionBox = EntraideOrm.LUNA.LunaContext.CreateTransactionBox

                Try
                    trans.TransactionBegin()

                    Dim theEntity As DonEntity = New DonEntity
                    theEntity.created = txtDate.Value
                    Dim type As String = "ARGENT"
                    If ckMaterial.Checked Then
                        type = "MATERIEL"
                    End If


                    theEntity.type_don = type
                    theEntity.montant_sollicite = CDbl(txtMontantSollicite.Text)
                    theEntity.montant_recu = CDbl(txtMontrecu.Text)

                    Dim mode_reception As String = "Espece"
                    If ckCheque.Checked Then mode_reception = "Cheque"
                    If ckVirement.Checked Then mode_reception = "Virement"
                    theEntity.mode_reception = mode_reception
                    theEntity.numero_cheque = txtNumCheque.Text.Trim

                    Dim restriction As String = "SANS"
                    If ckResLimite.Checked Then restriction = "LIMITE"
                    If ckResIllimite.Checked Then restriction = "ILLIMITE"
                    theEntity.restriction = restriction
                    theEntity.activite_menee = txtActiviteMenee.Text.Trim
                    theEntity.donneur_id = cmbDonneur.SelectedValue
                    theEntity.note_restriction = txtNoteRestriction.Text.Trim
                    theEntity.activite_financier_id = cmbActiviteFinancier.SelectedValue
                    theEntity.departement_id = cmbDepartement.SelectedValue
                    theEntity.user_id = My.Settings.user_id

                    Dim don_id As Long = theEntity.Save()

                    If don_id > 0 Then
                        trans.TransactionCommit()
                        Util.ShowMessage(Me, "Enregistrement effectue avec succès")

                        Dim mRecu As Printing.Recu = New Printing.Recu(don_id, theEntity.montant_recu, Printing.Recu.TYPE_RECU.DON)

                        Using report As New Printing.RecuCaisse(mRecu)
                            report.ShowDialog()
                        End Using

                        Close()
                    Else
                        Util.ShowMessage(Me, "Une erreur est survenu, veuillez reessayer plus tard", 1)
                    End If

                Catch ex As Exception
                    trans.TransactionRollBack()
                    If My.Settings.app_debug_mode Then
                        Util.ShowMessage(ex.ToString, 2)
                    Else
                        Util.ShowMessage("Fatal error : " & ex.Message, 2)
                    End If
                End Try
            End Using
        End If

    End Sub

    Private Sub ckNonSollicite_CheckedChanged(sender As Object, e As EventArgs) Handles ckNonSollicite.CheckedChanged
        txtMontantSollicite.Text = "0"
        txtMontantSollicite.Visible = Not ckNonSollicite.Checked
    End Sub

    Private Sub CheckKey(sender As Object, e As KeyPressEventArgs) Handles txtMontrecu.KeyPress, txtMontantSollicite.KeyPress
        Util.checkkey(e)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub cmbDonneur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDonneur.SelectedIndexChanged

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Util.EmptyForm(Panel3)
    End Sub


End Class
