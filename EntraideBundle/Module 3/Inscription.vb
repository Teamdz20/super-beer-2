Imports MySql.Data.MySqlClient

Imports MetroFramework.Controls
Imports MetroFramework
Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db

Public Class Inscription

    Dim etudiantTable As New EtudiantsTable

    Private Sub PopulateTypeFormation()
        Try
            Dim dt As DataTable = Database.GetDataTable("SELECT id, nom, montant FROM type_formations")
            Dim row As DataRow = dt.NewRow
            row(0) = "0"
            row(1) = ""
            row(2) = "0"
            dt.Rows.InsertAt(row, 0)

            cmbTypeFormation.DataSource = dt
            cmbTypeFormation.DisplayMember = "nom"
            cmbTypeFormation.ValueMember = "id"

            cmbCout.DataSource = dt
            cmbCout.DisplayMember = "montant"
            cmbCout.ValueMember = "id"
            cmbCout.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbReligion, "SELECT id,nom FROM religions ORDER BY id ASC", "id", "nom")
        'Util.PopulateCombo(cmbTypeFormation, "SELECT id, nom FROM type_formations", "id", "nom")
        'Util.PopulateCombo(cmbCout, "SELECT id, montant FROM type_formations", "id", "montant")
        'cmbCout.Visible = False
        Util.PopulateCombo(cmbGeneration, "SELECT id, libelle FROM generations", "id", "libelle")
        PopulateTypeFormation()

        'GenererCode(cmbGeneration)

        chkEspece.Checked = True

        If cmbBusiness.Text = "Non" Then
            lbTypeBusiness.Visible = False
        End If
    End Sub


    Private Sub chkEcrireExcellentFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireExcellentFr.CheckedChanged
        If chkEcrireExcellentFr.Checked Then
            chkEcrireDebutantFr.Enabled = False
            chkEcrireMoyenFr.Enabled = False
        ElseIf chkEcrireDebutantFr.Enabled = True Then
            chkEcrireMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireMoyenFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireMoyenFr.CheckedChanged
        If chkEcrireMoyenFr.Checked Then
            chkEcrireExcellentFr.Enabled = False
            chkEcrireDebutantFr.Enabled = False
        Else
            chkEcrireExcellentFr.Enabled = True
            chkEcrireDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireDebutantFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireDebutantFr.CheckedChanged
        If chkEcrireDebutantFr.Checked Then
            chkEcrireExcellentFr.Enabled = False
            chkEcrireMoyenFr.Enabled = False
        Else
            chkEcrireExcellentFr.Enabled = True
            chkEcrireMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteExcellentFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteExcellentFr.CheckedChanged
        If chkEcouteExcellentFr.Checked Then
            chkEcouterMoyenFr.Enabled = False
            chkEcouteDebutantFr.Enabled = False
        Else
            chkEcouterMoyenFr.Enabled = True
            chkEcouteDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcouterMoyenFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouterMoyenFr.CheckedChanged
        If chkEcouterMoyenFr.Checked Then
            chkEcouteDebutantFr.Enabled = False
            chkEcouteExcellentFr.Enabled = False
        Else
            chkEcouteDebutantFr.Enabled = True
            chkEcouteExcellentFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteDebutantFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteDebutantFr.CheckedChanged
        If chkEcouteDebutantFr.Checked Then
            chkEcouteExcellentFr.Enabled = False
            chkEcouterMoyenFr.Enabled = False
        Else
            chkEcouteExcellentFr.Enabled = True
            chkEcouterMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkParlerExcellentFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerExcellentFr.CheckedChanged
        If chkParlerExcellentFr.Checked Then
            chkParlerMoyenFr.Enabled = False
            chkParlerDebutantFr.Enabled = False
        Else
            chkParlerMoyenFr.Enabled = True
            chkParlerDebutantFr.Enabled = True

        End If
    End Sub

    Private Sub chkParlerMoyenFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerMoyenFr.CheckedChanged
        If chkParlerMoyenFr.Checked Then
            chkParlerExcellentFr.Enabled = False
            chkParlerDebutantFr.Enabled = False
        Else
            chkParlerExcellentFr.Enabled = True
            chkParlerDebutantFr.Enabled = True
        End If
    End Sub

    Private Sub chkParlerDebutantFr_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerDebutantFr.CheckedChanged
        If chkParlerDebutantFr.Checked Then
            chkParlerExcellentFr.Enabled = False
            chkParlerMoyenFr.Enabled = False
        Else
            chkParlerExcellentFr.Enabled = True
            chkParlerMoyenFr.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireExcellentEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireExcellentEN.CheckedChanged
        If chkEcrireExcellentEN.Checked Then
            chkEcrireDebEN.Enabled = False
            chkEcrireMoyenEN.Enabled = False
        Else : chkEcrireDebEN.Enabled = True
            chkEcrireMoyenEN.Enabled = True
        End If

    End Sub

    Private Sub chkEcrireMoyenEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireMoyenEN.CheckedChanged
        If chkEcrireMoyenEN.Checked Then
            chkEcrireExcellentEN.Enabled = False
            chkEcrireDebEN.Enabled = False
        Else
            chkEcrireExcellentEN.Enabled = True
            chkEcrireDebEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcrireDebEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcrireDebEN.CheckedChanged
        If chkEcrireDebEN.Checked Then
            chkEcrireExcellentEN.Enabled = False
            chkEcrireMoyenEN.Enabled = False
        Else
            chkEcrireExcellentEN.Enabled = True
            chkEcrireMoyenEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteExEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteExEN.CheckedChanged
        If chkEcouteExEN.Checked Then
            chkEcouteMoyenEN.Enabled = False
            chkEcouteDebEN.Enabled = False
        Else
            chkEcouteMoyenEN.Enabled = True
            chkEcouteDebEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteMoyenEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteMoyenEN.CheckedChanged
        If chkEcouteMoyenEN.Checked Then
            chkEcouteDebEN.Enabled = False
            chkEcouteExEN.Enabled = False
        Else
            chkEcouteDebEN.Enabled = True
            chkEcouteExEN.Enabled = True
        End If
    End Sub

    Private Sub chkEcouteDebEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkEcouteDebEN.CheckedChanged
        If chkEcouteDebEN.Checked Then
            chkEcouteExEN.Enabled = False
            chkEcouteMoyenEN.Enabled = False
        Else
            chkEcouteExEN.Enabled = True
            chkEcouteMoyenEN.Enabled = True
        End If
    End Sub

    Private Sub chkParlerExEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerExEN.CheckedChanged
        If chkParlerExEN.Checked Then
            chkParlerMoyenEN.Enabled = False
            chkParlerDebEN.Enabled = False
        Else
            chkParlerMoyenEN.Enabled = True
            chkParlerDebEN.Enabled = True

        End If
    End Sub

    Private Sub chkParlerMoyenEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerMoyenEN.CheckedChanged
        If chkParlerMoyenEN.Checked Then
            chkParlerExEN.Enabled = False
            chkParlerDebEN.Enabled = False
        Else
            chkParlerExEN.Enabled = True
            chkParlerDebEN.Enabled = True
        End If
    End Sub

    Private Sub chkParlerDebEN_CheckedChanged(sender As Object, e As EventArgs) Handles chkParlerDebEN.CheckedChanged
        If chkParlerDebEN.Checked Then
            chkParlerExEN.Enabled = False
            chkParlerMoyenEN.Enabled = False
        Else
            chkParlerExEN.Enabled = True
            chkParlerMoyenEN.Enabled = True
        End If
    End Sub

    Private Sub cmbBusiness_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBusiness.SelectedIndexChanged
        If cmbBusiness.Text = "Non" Then
            lbTypeBusiness.Visible = False
            lbAnnexe.Visible = False
            lbNbreEmploye.Visible = False

            txtTypeBusiness.Visible = False
            txtNombreEmployes.Visible = False
            txtAnnexe.Visible = False
        Else
            lbTypeBusiness.Visible = True
            lbAnnexe.Visible = True
            lbNbreEmploye.Visible = True

            txtTypeBusiness.Visible = True
            txtNombreEmployes.Visible = True
            txtAnnexe.Visible = True
        End If
    End Sub

    Private Sub cmbDelit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDelit.SelectedIndexChanged
        If cmbDelit.Text = "Non" Then
            lbnomDel.Visible = False
            txtDelit.Visible = False

        Else
            lbnomDel.Visible = True
            txtDelit.Visible = True
        End If
    End Sub

    Private Sub cmbFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormation.SelectedIndexChanged
        If cmbFormation.Text = "Non" Then
            lbTypeFormation.Visible = False
            txtTypeFormation.Visible = False
            lbNiveau.Visible = False
            txtNiveauEtude.Visible = False

        Else
            lbTypeFormation.Visible = True
            txtTypeFormation.Visible = True
            lbNiveau.Visible = True
            txtNiveauEtude.Visible = True
        End If
    End Sub

    Private Sub cmbEmploye_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmploye.SelectedIndexChanged
        If cmbEmploye.Text = "Non" Then
            lbTypeEmploi.Visible = False
            txtTypeEmploi.Visible = False
        Else
            lbTypeEmploi.Visible = True
            txtTypeEmploi.Visible = True
        End If
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
            lbCheque.Visible = False
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

    'Private Sub cmbTypeFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeFormation.SelectedIndexChanged
    '    If IsNumeric(cmbTypeFormation.SelectedValue) Then
    '        cmbCout.SelectedValue = cmbTypeFormation.SelectedValue
    '    End If
    'End Sub

    Private Sub cmbCout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCout.SelectedIndexChanged

        If IsNumeric(cmbCout.SelectedValue) Then
            txtCoutFormation.Text = cmbCout.Text
        End If
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

        If txtNom.Text = "" Or txtPrenom.Text = "" Or txtBP.Text = "" Or txtLieu.Text = "" Or txtMail.Text = "" Or txtMontantPayer.Text = "" Or txtNationalite.Text = "" Or txtPhone1.Text = "" Then
            Util.ShowMessage(Me, "Veuillez à bien remplir les champs", 0)
        Else
            Try

                Dim execute As Long = etudiantTable.Save(Me)

                If execute = 0 Then
                    Util.ShowMessage(Me, "Une erreur est survenu, veillez réessayer plus tard", 1)
                Else
                    
                    Dim mRecu As New Printing.Recu(EtudiantsTable.revenu_id, txtMontantPayer.Text, Printing.Recu.TYPE_RECU.ETUDIANT)

                    Using report As New Printing.RecuCaisse(mRecu)
                        report.ShowDialog()
                    End Using

                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
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


    Private Sub txtMontantPayer_TextChanged(sender As Object, e As EventArgs) Handles txtMontantPayer.TextChanged
        Dim idtype As TableTypeFormation = New TableTypeFormation
        Dim montantType As TableTypeFormation = New TableTypeFormation
        Dim montantR As Integer = 0

        If IsNumeric(txtMontantPayer.Text) Then
            Dim montantAPayer As Integer = txtMontantPayer.Text
            Dim montantTotal As Integer = txtCoutFormation.Text
            montantR = montantTotal - montantAPayer
            txtMontantRestant.Text = montantR & "F"

        ElseIf txtMontantPayer.Text = "" Then
            txtMontantRestant.Text = "0"
        End If
    End Sub

    Private Sub btClean_Click(sender As Object, e As EventArgs) Handles btClean.Click
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtBP.Text = ""
        txtLieu.Text = ""
        txtMail.Text = ""
        txtMontantPayer.Text = ""
        txtNationalite.Text = ""
        txtPhone1.Text = ""
        txtActivite.Text = ""
        txtAdresse.Text = ""
        txtAdresseUrgence.Text = ""
        txtAnnexe.Text = ""
        txtAutreCompetence.Text = ""
        txtAutreReligion.Text = ""
        txtNiveauEtude.Text = ""
        txtNomUrgence.Text = ""
        txtNumCheque.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtPhoneUrgence.Text = ""
        txtTypeBusiness.Text = ""
        txtTypeEmploi.Text = ""
        txtTypeFormation.Text = ""
        txtDelaiPaiement.Text = ""
        txtDelit.Text = ""
        txtMontantPayer.Text = ""
        txtMontantRestant.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using f As New ListeGeneration
            f.ShowDialog()
            Util.PopulateCombo(cmbGeneration, "SELECT id, libelle FROM generations", "id", "libelle")
        End Using
    End Sub

    Private Shared Sub GenererCode(ByVal cmb As ComboBox)
        Dim alpha As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim tab() As Char = alpha.ToCharArray
        Dim s, s2, s3 As Single
        Randomize()
        s = Rnd() * 20
        Randomize()
        s2 = Rnd() * 20
        Randomize()
        s3 = Rnd() * 20
        cmb.Text = tab(Math.Round(s)) & tab(Math.Round(s2)) & tab(Math.Round(s3)) & Math.Round(Rnd() * 1000)
    End Sub

    Private Sub cmbReligion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReligion.SelectedIndexChanged

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class
