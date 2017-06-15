Public Class ListeEtudiantsDette

    Dim etudiantTable As EtudiantsTable = New EtudiantsTable


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

    Private Sub ListeEtudiantsDette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Recherche()
    End Sub

    Public Sub Recherche()
        Dim liste As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        liste = etudiantTable.getEtudiantByDette
        ListeEtudiant.Items.Clear()
        For Each elem As EtudiantEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom + " " + elem.prenom)
            item.SubItems.Add(FormatNumber(elem.Revenu.Montant, 0))
            item.SubItems.Add(FormatNumber(elem.Paiement.MontantP, 0))
            item.SubItems.Add(FormatNumber(CDbl(elem.Revenu.Montant) - CDbl(elem.Paiement.MontantP), 0))
            ListeEtudiant.Items.Add(item)
        Next
    End Sub

    Public Sub SearchByName()

        Dim liste As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        liste = etudiantTable.getByNomDette(txtNom.Text)
        ListeEtudiant.Items.Clear()
        For Each elem As EtudiantEntity In liste
            Dim item As New ListViewItem(elem.id)
            item.SubItems.Add(elem.nom + " " + elem.prenom)
            item.SubItems.Add(elem.Revenu.Montant & "F")
            item.SubItems.Add(elem.Paiement.MontantP & "F")
            item.SubItems.Add(CDbl(elem.Revenu.Montant) - CDbl(elem.Paiement.MontantP) & "F")
            ListeEtudiant.Items.Add(item)
        Next
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class