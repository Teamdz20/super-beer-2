Imports EntraideBundle.Db.Tables
Imports EntraideBundle.Db.Entities

Public Class ListeEmployees

    ''' <summary>
    ''' Employe Table Instance
    ''' </summary>
    ''' <remarks></remarks>
    Private empTable As EmployesTable = New EmployesTable

    ''' <summary>
    ''' Current employes list displayed
    ''' </summary>
    ''' <remarks></remarks>
    Private liste_employes As List(Of EmployeEntity) = New List(Of EmployeEntity)

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


    Private Sub LoadEmployes(Optional byCode As Boolean = False, Optional byNom As Boolean = False, Optional byClass As Boolean = False)

        liste_employes.Clear()

        If byCode Then
            liste_employes = empTable.GetByCode(txtCode.Text.Trim)
        ElseIf byNom Then
            liste_employes = empTable.GetByname(txtNom.Text.Trim)
        ElseIf byClass Then
            liste_employes = empTable.GetByClassification(cmbClassification.Text)
        Else
            liste_employes = empTable.GetAll()
        End If

        ListEmployes.Items.Clear()

        Dim total As Double = 0
        Dim totalEmp As Double = 0
        Dim totalVol As Double = 0
        Dim totalStg As Double = 0

        Try
            Dim iter As Integer = 1

            Dim index As Integer = 0

            For Each employe As EmployeEntity In liste_employes

                Dim item As New ListViewItem(employe.id)
                item.SubItems.Add(employe.code)
                item.SubItems.Add(employe.nom)
                item.SubItems.Add(employe.prenom)
                item.SubItems.Add(employe.email)
                item.SubItems.Add(employe.Poste.nom)
                item.SubItems.Add(employe.Departement.nom)
                item.SubItems.Add(FormatDateTime(employe.Contrat.date_debut, DateFormat.ShortDate))
                item.SubItems.Add(FormatDateTime(employe.Contrat.date_fin, DateFormat.ShortDate))
                item.SubItems.Add(employe.Contrat.classification)
                item.SubItems.Add(FormatNumber(employe.Salaire.taux, 0))
                item.SubItems.Add(employe.sexe)
                item.SubItems.Add(FormatDateTime(employe.date_naissance, DateFormat.ShortDate))
                item.SubItems.Add(employe.nationnalite)
                item.SubItems.Add(employe.adresse)
                item.SubItems.Add(employe.tel1)
                item.SubItems.Add(employe.tel2)
                item.SubItems.Add(employe.nom_contact_urgent)
                item.SubItems.Add(employe.adresse_contact_urgent)

                item.SubItems.Add(index)

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListEmployes.Items.Add(item)
                iter += 1

                If employe.IsClass("Employees") Then
                    totalEmp += 1
                ElseIf employe.IsClass("Volentaire") Then
                    totalVol += 1
                Else
                    totalStg += 1
                End If

                index += 1
            Next
        Catch ex As Exception
        Finally
            labelTotal.Text = liste_employes.Count
            labelEmp.Text = totalEmp
            labelVol.Text = totalVol
            labelStg.Text = totalStg
        End Try

    End Sub


    Private Sub ListeEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployes()
        Util.PopulateComboYear(cmbAnnee)
        ckPredefini.Checked = True
    End Sub

    Private Sub btnRapport_Click(sender As Object, e As EventArgs) Handles btnRapport.Click, MetroButton1.Click
        Dim form As New Printing.ReportEmployes(EmployesTable.data_source)
        form.total = labelTotal.Text
        form.employes = labelEmp.Text
        form.volentaire = labelVol.Text
        form.stagiaire = labelStg.Text
        form.ShowDialog()
    End Sub

  
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ckCode.Checked Then
            LoadEmployes(True)
        ElseIf ckNom.Checked Then
            LoadEmployes(False, True)
        ElseIf ckClassification.Checked Then
            LoadEmployes(False, False, True)
        Else
            LoadEmployes()
        End If
    End Sub

    Private Sub cmbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub ckCode_CheckedChanged(sender As Object, e As EventArgs) Handles ckCode.CheckedChanged
        txtCode.Enabled = ckCode.Checked
        If ckCode.Checked = False Then
            txtCode.Text = ""
        Else
            ckNom.Checked = False
            ckClassification.Checked = False
        End If
    End Sub

    Private Sub ckNom_CheckedChanged(sender As Object, e As EventArgs) Handles ckNom.CheckedChanged
        txtNom.Enabled = ckNom.Checked
        If ckNom.Checked = False Then
            txtNom.Text = ""
        Else
            ckCode.Checked = False
            ckClassification.Checked = False
        End If
    End Sub

    Private Sub ckClassification_CheckedChanged(sender As Object, e As EventArgs) Handles ckClassification.CheckedChanged
        cmbClassification.Enabled = ckClassification.Checked
        If ckClassification.Checked = False Then
            cmbClassification.Text = ""
        Else
            ckCode.Checked = False
            ckNom.Checked = False
        End If
    End Sub

    Private Sub chkPredefini_CheckedChanged(sender As Object, e As EventArgs) Handles ckPredefini.CheckedChanged
        If ckPredefini.Checked Then
            For i As Integer = 9 To 18
                ListEmployes.Columns(i).Width = 0
            Next
        End If
    End Sub

    Private Sub ckDetail_CheckedChanged(sender As Object, e As EventArgs) Handles ckDetail.CheckedChanged
        If ckDetail.Checked Then
            For i As Integer = 9 To 18
                ListEmployes.Columns(i).Width = 200
            Next
        End If
    End Sub

    Private Sub ShowDetails()
        If ListEmployes.SelectedItems.Count > 0 Then
            Try
                Dim index As Integer = CInt(ListEmployes.SelectedItems(0).SubItems(19).Text)
                Dim form As New MajEmploye
                form.from_cash = True
                form.empListe.Add(liste_employes.Item(index))
                form.ShowDialog()
            Catch ex As Exception
                Util.ShowMessage(ex.Message, 1)
            End Try
        End If
    End Sub

    Private Sub ListEmployes_ItemActivate(sender As Object, e As EventArgs) Handles ListEmployes.ItemActivate
        ShowDetails()
    End Sub
End Class