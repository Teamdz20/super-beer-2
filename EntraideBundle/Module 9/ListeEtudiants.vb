Public Class ListeEtudiants
    Dim etudiantTable As EtudiantsTable = New EtudiantsTable
    Public index As Integer

    Public Sub Recherche()
        Dim liste As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        liste = etudiantTable.getEtudiant
        ListeEtudiant.Items.Clear()
        For Each elem As EtudiantEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom + " " + elem.prenom)
            item.SubItems.Add(elem.code)
            ListeEtudiant.Items.Add(item)
        Next

    End Sub

    Public Sub SearchByName()

        Dim liste As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        liste = etudiantTable.getByNom(txtNom.Text)
        ListeEtudiant.Items.Clear()
        For Each elem As EtudiantEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom + " " + elem.prenom)
            item.SubItems.Add(elem.code)
            ListeEtudiant.Items.Add(item)
        Next
    End Sub
    Private Sub ListeEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Recherche()
    End Sub

    Private Sub ListeEtudiant_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListeEtudiant.ItemSelectionChanged
        index = e.ItemIndex

       


        Me.Close()
    End Sub

   

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        lb_msg.Visible = False
        If chkAll.Checked Then
            Recherche()
            txtNom.Text = ""
        Else
            ListeEtudiant.Items.Clear()
        End If
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        If txtNom.Text.Trim.Length > 0 And chkAll.Checked Then
            chkAll.Checked = False
        End If

        SearchByName()
        If ListeEtudiant.Items.Count <= 0 Then
            lb_msg.Visible = True
            lb_msg.Text = etudiantTable.tempText
        Else
            lb_msg.Visible = False
        End If
    End Sub

End Class