Imports MetroFramework.Controls

Public Class DemandeSoutien

    Dim interval As Integer = 0

    Public id_etudiant As Integer = 0

    Dim depTable As TableDepense = New TableDepense

    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2)
        PanelContainer.Location = location
    End Sub


    Private Sub lnkEtudiant_Click(sender As Object, e As EventArgs) Handles lnkEtudiant.Click
        Dim form As New ListeEtudiants
        form.ShowDialog()
        If form.ListeEtudiant.Items.Count > 0 Then
            Dim nom As String = form.ListeEtudiant.Items(form.index).SubItems(1).Text
            id_etudiant = form.ListeEtudiant.Items(form.index).SubItems(0).Text
            cmbEtudiant.SelectedValue = id_etudiant
        End If
    End Sub

    Dim form_initialized As Boolean = False

    Private Sub DemandeSoutien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateCombo(cmbEtudiant, "SELECT id, CONCAT_WS(' ',nom, prenom) as nom FROM etudiants", "id", "nom")
        form_initialized = True
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If cmbEtudiant.SelectedValue = "0" OrElse txtMontantRecu.Text = "0" OrElse txtDelais.Text = "0" OrElse txtTypeBusiness.Text.Trim.Length = 0 OrElse txtNbreRepaiement.Text = "0" Then
            Util.ShowMessage(Me, "Veuillez remplir tous les champs", 1)
        Else
            Try
                Dim id As Long = depTable.Save(Me)

                If id = 0 Then
                    MsgBox("Non enregistré")
                Else
                    Util.ShowMessage(Me, "Fond enregistré avec succès")
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btClean_Click(sender As Object, e As EventArgs) Handles btClean.Click
        Util.EmptyForm(GroupBox1)
        Util.EmptyForm(GroupBox2)
    End Sub

    Private Sub ControlNumKey(sender As Object, e As KeyPressEventArgs) Handles txtPeriodeGrace.KeyPress, txtPenalite.KeyPress, txtPaimentRetard.KeyPress, txtPaiementRestant.KeyPress, txtNetAPayer.KeyPress, txtNbreRepaiement.KeyPress, txtNbrePaiementEffec.KeyPress, txtMontantSoli.KeyPress, txtMontantRecu.KeyPress, txtMontantHIC.KeyPress, txtInteret.KeyPress, txtDelais.KeyPress
        Util.checkkey(e)
    End Sub

    Private Sub cmbEtudiant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEtudiant.SelectedIndexChanged
        If IsNumeric(cmbEtudiant.SelectedValue) Then
            id_etudiant = cmbEtudiant.SelectedValue
        End If
    End Sub

    Private Sub NumControlLeave(sender As Object, e As EventArgs) Handles txtPeriodeGrace.Leave, txtPenalite.Leave, txtMontantRecu.Leave, txtMontantHIC.Leave, txtInteret.Leave, txtDelais.Leave, txtMontantSoli.Leave, txtNbreRepaiement.Leave, MetroLabel13.Leave
        Dim c As MetroTextBox = DirectCast(sender, MetroTextBox)
        If c.Text.Trim.Length = 0 Then
            c.Text = "0"
        End If
    End Sub

    Private Sub txtDelais_TextChanged(sender As Object, e As EventArgs) Handles txtDelais.TextChanged
        If form_initialized Then
            dtFinPaiement.Value = DateAdd(DateInterval.Month, CDbl(txtDelais.Text), dtDebutPaiement.Value)
        End If
    End Sub

   
    Private Sub txtInteret_TextChanged(sender As Object, e As EventArgs) Handles txtPenalite.TextChanged, txtMontantRecu.TextChanged, txtInteret.TextChanged
        Dim c As MetroTextBox = DirectCast(sender, MetroTextBox)
        If c.Text.Trim.Length = 0 Then
            c.Text = "0"
        End If
        ComputeTotal()
    End Sub

    Private Sub ComputeTotal()
        If form_initialized Then
            Dim netAPayer As Double = CDbl(txtMontantRecu.Text) + CDbl(txtInteret.Text) + CDbl(txtPenalite.Text)
            txtNetAPayer.Text = FormatNumber(netAPayer, 0)
        End If
    End Sub

End Class