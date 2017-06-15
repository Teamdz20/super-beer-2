Imports EntraideBundle.Db.Tables

Public Class ListeCodeDepense

    Dim catTable As CodeDepensesTable = New CodeDepensesTable

    Public id_code As Integer = 0

    Public Sub Recherche()
        Dim liste As List(Of CodeDepenseEntity) = New List(Of CodeDepenseEntity)
        liste = catTable.GetByName(txtSearch.Text)
        ListeCodesDepenses.Items.Clear()
        For Each elem As CodeDepenseEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)
            item.SubItems.Add(elem.CodeRevenu)
            ListeCodesDepenses.Items.Add(item)
        Next
    End Sub

    Public Sub RechercheAll()
        Dim liste As List(Of CodeDepenseEntity) = New List(Of CodeDepenseEntity)
        liste = catTable.GetAll
        ListeCodesDepenses.Items.Clear()
        For Each elem As CodeDepenseEntity In liste
            Dim item As New ListViewItem(elem.Id)
            item.SubItems.Add(elem.Nom)
            item.SubItems.Add(elem.CodeRevenu)
            ListeCodesDepenses.Items.Add(item)
        Next
    End Sub

    Private Sub UpdateCodeDepense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RechercheAll()
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked Then
            RechercheAll()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Recherche()
    End Sub

    Private Sub TriggerUpdate()
        If ListeCodesDepenses.SelectedItems.Count > 0 Then
            With ListeCodesDepenses.SelectedItems(0)
                Dim form As New CodeDepense
                form.txtNom.Text = .SubItems(1).Text
                form.txtCode.Text = .SubItems(2).Text
                form.id = .SubItems(0).Text
                form.Text = "CODE DEPENSE : MODIFICATION"
                form.ShowDialog()
                RechercheAll()
            End With
        Else
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
        End If

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnTriggerUpdate_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        TriggerUpdate()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim form As New CodeDepense
        form.ShowDialog()
        RechercheAll()
    End Sub

End Class