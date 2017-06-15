Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db.Tables

Public Class ListePoste

    Dim posTable As PostesTable = New PostesTable

    Public id_poste As Integer = 0

    Private Const LARGE_WIDTH As Integer = 1176

    Private Const TINY_WIDTH As Integer = 686

    Public Sub Recherche()
        Dim liste As List(Of PosteEntity) = New List(Of PosteEntity)
        liste = posTable.GetByName(txtSearch.Text)
        ListePostes.Items.Clear()
        For Each elem As PosteEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom)

            ListePostes.Items.Add(item)
        Next

    End Sub

    Public Sub LoadData()
        Dim liste As List(Of PosteEntity) = New List(Of PosteEntity)
        liste = posTable.GetAll
        ListePostes.Items.Clear()
        For Each elem As PosteEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom)

            ListePostes.Items.Add(item)
        Next

    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Recherche()
        If txtSearch.Text.Trim.Length <= 0 And chkAll.Checked = False Then
            ListePostes.Items.Clear()
            lb_msg.Visible = False
            LoadData()
        ElseIf ListePostes.Items.Count <= 0 Then
            lb_msg.Visible = True
            lb_msg.Text = "Aucun resultat"
        ElseIf chkAll.Checked = True Then
            chkAll.Checked = False
        Else
            lb_msg.Visible = False
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        lb_msg.Visible = False
        If chkAll.Checked Then
            LoadData()
        End If
    End Sub


    Private Sub TriggerUpdate()
        If ListePostes.SelectedItems.Count > 0 Then
            With ListePostes.SelectedItems(0)
                Dim form As New Poste
                form.Text = "POSTE : MODIFICATION"
                form.id = .SubItems(0).Text
                form.txtNom.Text = .SubItems(1).Text
                form.ShowDialog()
                LoadData()
            End With
        Else
            Util.ShowMessage(Me, "Veuillez selectionner un element", 1)
        End If
    End Sub

    Private Sub UpdatePoste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnTriggerUpdate.Click
        TriggerUpdate()
    End Sub

    Private Sub ListePostes_ItemActivate(sender As Object, e As EventArgs) Handles ListePostes.ItemActivate
        TriggerUpdate()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim form As New Poste
        form.Text = "POSTE : NOUVEAU POSTE"
        form.ShowDialog()
        LoadData()
    End Sub

    
End Class