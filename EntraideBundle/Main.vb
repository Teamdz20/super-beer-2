Public Class Main

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        Dim form As New ListeEmployees
        form.ShowDialog()
    End Sub

    Private Sub NouvequToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvequToolStripMenuItem.Click
        Dim form As New Employee
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VueMiseÀJoursToolStripMenuItem.Click
        Dim form As New MajEmploye
        form.ShowDialog()
    End Sub

    Private Sub ListeRevenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeRevenuToolStripMenuItem.Click
        Dim form As New ListeRevenu
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem1.Click
        Dim form As New Revenu
        form.ShowDialog()
    End Sub

    Private Sub ListeDesDonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesDonsToolStripMenuItem.Click
        Dim form As New ListeDons
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem2.Click
        Dim form As New Don
        form.ShowDialog()
    End Sub


    Private Sub ListeDesEtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesEtudiantsToolStripMenuItem.Click
        Dim form As New RapportEtudiant
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem3.Click
        Dim form As New Inscription
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJoursToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VueMiseÀJoursToolStripMenuItem2.Click
        Dim form As New UpdateEtudiant
        form.ShowDialog()
    End Sub


    Private Sub NouveauToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem4.Click
        Dim form As New ListeDepenses
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem5.Click
        Dim form As New Depenses
        form.ShowDialog()
    End Sub

    Private Sub MiseÀJoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiseÀJoursToolStripMenuItem.Click
        Dim form As New MajDepenses
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VueMiseÀJourToolStripMenuItem.Click
        Dim form As New MajRevenu
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJoursToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VueMiseÀJoursToolStripMenuItem1.Click
        Dim form As New MajDon
        form.ShowDialog()
    End Sub

    Private Sub RapportDesMaterielsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportDesMaterielsToolStripMenuItem.Click
        Dim form As New ListeMateriel
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem6.Click
        Dim form As New Materiel
        form.ShowDialog()
    End Sub

    Private Sub VueMiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VueMiseToolStripMenuItem.Click
        Dim form As New MajMateriel
        form.ShowDialog()
    End Sub

    Private Sub RapportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportToolStripMenuItem.Click
        Dim form As New RapportDonneur
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJoursToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles VueMiseÀJoursToolStripMenuItem3.Click
        Dim form As New AddDonneur
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem7.Click
        Dim form As New UpdateDonneur
        form.ShowDialog()
    End Sub

    Private Sub RapportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RapportToolStripMenuItem1.Click
        Dim form As New RapportFournisseur
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem8.Click
        Dim form As New AddFournisseur
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJoursToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles VueMiseÀJoursToolStripMenuItem4.Click
        Dim form As New UpdateFournisseur
        form.ShowDialog()
    End Sub

    Private Sub RapportToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RapportToolStripMenuItem2.Click
        Dim form As New RapportFond
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem9.Click
        Dim form As New DemandeSoutien
        form.ShowDialog()
    End Sub

    Private Sub VueMiseÀJoursToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles VueMiseÀJoursToolStripMenuItem5.Click
        Dim form As New UpdateFond
        form.ShowDialog()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        labelUserName.Text = My.Settings.user_full_name & " connecté"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTime.Text = FormatDateTime(Today, DateFormat.ShortDate) & " " & TimeOfDay
    End Sub


    Private Sub FermerLaSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerLaSessionToolStripMenuItem.Click
        Dim result As DialogResult = Util.ShowMessage(Me, "Voulez-vous vraiment fermer la session ?", 3)
        If result = Windows.Forms.DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Dim result As DialogResult = Util.ShowMessage(Me, "Voulez-vous vraiment quitter l'application ?", 3)
        If result = Windows.Forms.DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Dim form As New ListeEmployees
        form.ShowDialog()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Dim form As New ListeRevenu
        form.ShowDialog()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        Dim form As New ListeDons
        form.ShowDialog()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        Dim form As New ListeDepenses
        form.ShowDialog()
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        Dim form As New RapportEtudiant
        form.ShowDialog()
    End Sub

    Private Sub CategorieDonneurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieDonneurToolStripMenuItem.Click
        Dim form As New ListeCategorieDonneurs
        form.ShowDialog()
    End Sub

    Private Sub CategorieFournisseurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategorieFournisseurToolStripMenuItem.Click
        Dim form As New ListeCategorieFournisseur
        form.ShowDialog()
    End Sub

    Private Sub CodeDepenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeDepenseToolStripMenuItem.Click
        Dim form As New ListeCodeDepense
        form.ShowDialog()
    End Sub

    Private Sub TypeDeFormationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypeDeFormationsToolStripMenuItem.Click
        Dim form As New ListeTypeFormations
        form.ShowDialog()
    End Sub

    Private Sub DepartementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartementsToolStripMenuItem.Click
        Dim form As New ListeDepartement
        form.ShowDialog()
    End Sub

    Private Sub PostesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostesToolStripMenuItem.Click
        Dim form As New ListePoste
        form.ShowDialog()
    End Sub

    Private Sub OrganisationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganisationToolStripMenuItem.Click
        Dim form As New RapportOrganisation
        form.ShowDialog()
    End Sub

    Private Sub ListeDesGraduésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesGraduésToolStripMenuItem.Click
        Dim form As New RapportGraduation
        form.ShowDialog()
    End Sub

    Private Sub NouveauGraduéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauGraduéToolStripMenuItem.Click
        Dim form As New AddGraduation
        form.ShowDialog()
    End Sub

    Private Sub ListeDesMembresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesMembresToolStripMenuItem.Click
        Dim form As New ListeAlumni
        form.ShowDialog()
    End Sub

    Private Sub BureauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BureauToolStripMenuItem.Click
        Dim form As New AddBureau
        form.ShowDialog()
    End Sub

    Private Sub UtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilisateursToolStripMenuItem.Click
        Dim form As New ListeUsers
        form.ShowDialog()
    End Sub

    Private Sub RapportDesRevenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportDesRevenusToolStripMenuItem.Click
        Dim form As New RevenuGeneral
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Using form As New ListeProgrammes
            form.ShowDialog()
        End Using

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim form As New ListeTypeRevenu
        form.ShowDialog()
    End Sub

    Private Sub RecouvremenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecouvremenToolStripMenuItem.Click
        Dim form As New ListeEtudiantsDette
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem10.Click
        Dim form As New UpdatePaiement
        form.ShowDialog()
    End Sub

    Private Sub RapportToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RapportToolStripMenuItem3.Click
        Dim form As New RevenuGeneral
        form.type_rapport = RevenuGeneral.E_TYPE_RAPPORT.INSCRIPTION_ETUDIANT
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem11.Click
        Dim form As New AddPaiementFond
        form.ShowDialog()
    End Sub

    Private Sub RapportToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles RapportToolStripMenuItem4.Click
        Dim form As New RevenuGeneral
        form.type_rapport = RevenuGeneral.E_TYPE_RAPPORT.FOND_DE_SOUTIENS
        form.ShowDialog()
    End Sub

    Private Sub GenerationEtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerationEtudiantsToolStripMenuItem.Click
        Using f As New ListeGeneration
            f.ShowDialog()
        End Using
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Using f As New ListeCodeRevenu
            f.ShowDialog()
        End Using
    End Sub

End Class
