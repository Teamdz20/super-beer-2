Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db
Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class Depenses

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

    Private Sub FrmFinanceEnregistement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Util.PopulateCombo(cmbTypeDepense, "SELECT id, nom FROM type_depenses", "id", "nom")
        Util.PopulateCombo(cmbDepartement, DepartementsTable.COMBO_SQL, DepartementsTable.P_K, DepartementsTable.D_N)
        Util.PopulateCombo(cmbManager, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbDevise, "SELECT id, nom FROM devises", "id", "nom")
        Util.PopulateCombo(cmbBeneficiaire, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbRealiser, EmployesTable.SQL_COMBO, EmployesTable.P_K, EmployesTable.D_N)
        Util.PopulateCombo(cmbCodeDepense, "SELECT id, code FROM code_depenses", "id", "code")
        Util.PopulateCombo(cmbProgramme, "SELECT id, nom FROM programmes", "id", "nom")

        'PopulateActiviteFinancier()
    End Sub

    Private Sub PopulateActiviteFinancier()
        Dim dt As DataTable = Database.GetDataTable("SELECT id, nom, code FROM code_depenses")
        Dim row = dt.NewRow
        row(0) = "0"
        row(1) = ""
        row(2) = ""
        dt.Rows.InsertAt(row, 0)

        cmbProgramme.DataSource = dt
        cmbProgramme.DisplayMember = "nom"
        cmbProgramme.ValueMember = "id"

        cmbCodeDepense.DataSource = dt
        cmbCodeDepense.DisplayMember = "code"
        cmbCodeDepense.ValueMember = "id"
    End Sub


    Private Sub btEnregistrement_Click(sender As Object, e As EventArgs) Handles btEnregistrement.Click
        Try

            If cmbTypeDepense.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectioner le type de depense", 1)
            ElseIf cmbDepartement.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le departement", 1)
            ElseIf cmbCodeDepense.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner l'activite", 1)
            ElseIf txtMontant.Text.Length = 0 OrElse txtMontant.Text = "0" Then
                Util.ShowMessage(Me, "Veuillez saisir le montant", 1)
            ElseIf cmbDevise.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner la devise", 1)
            ElseIf cmbBeneficiaire.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le beneficiaire", 1)
            ElseIf txtReglement.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir le motif", 1)
            ElseIf cmbRealiser.SelectedValue = "0" Then
                Util.ShowMessage(Me, "Veuillez selectionner le realisateur", 1)
            ElseIf txtCodeDemande.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Veuillez saisir le code de la demande", 1)
            Else
                Dim entity As DepenseEntity = New DepenseEntity
                entity.created = txtDate.Value
                entity.type_depense_id = cmbTypeDepense.SelectedValue
                entity.departement_id = cmbDepartement.SelectedValue
                entity.code_depense_id = cmbCodeDepense.SelectedValue
                entity.manager_id = cmbManager.SelectedValue
                entity.montant = txtMontant.Text.Trim
                entity.devise_id = cmbDevise.SelectedValue
                entity.beneficiere_id = cmbBeneficiaire.SelectedValue
                entity.motif_depense = txtReglement.Text.Trim
                entity.realiser_par = cmbRealiser.SelectedValue
                entity.code_demande = txtCodeDemande.Text.Trim
                entity.memo = txtMemo.Text.Trim
                entity.programme_id = cmbProgramme.SelectedValue
                entity.activite = txtActivite.Text.Trim

                If entity.Save Then
                    Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                    Close()
                Else
                    Util.ShowMessage(Me, "L'enregistrement n'a pas aboutit, veuillez reessayer plus tard", 2)
                End If
            End If
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        End Try
    End Sub

    Private Sub txtAnnuler_Click(sender As Object, e As EventArgs) Handles txtAnnuler.Click
        Util.EmptyForm(GroupBox2)
        Util.EmptyForm(GroupBox3)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Close()
    End Sub


    Private Sub txtMontant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontant.KeyPress
        Util.checkkey(e)
    End Sub
End Class
