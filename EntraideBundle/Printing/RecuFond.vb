Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db
Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class RecuFond

        Private _fond_id As String

        Public Sub New(fond_id As String)

            ' Cet appel est requis par le concepteur.
            InitializeComponent()

            ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
            _fond_id = fond_id
        End Sub

        Private Sub RecuFond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub


        Private Sub RefreshReport()
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT paiement.created AS 'date', '' AS designation, paiement.montant_paye AS 'montant_remboursser' FROM paiement WHERE id_fond_soutien = '" & _fond_id & "' ORDER BY paiement.created ASC"
                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As DataSetTables = New DataSetTables
                adapter.Fill(ds.RecuFond)
                cmd.Dispose()

                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\RecuFond.rdlc"

                    cmd.CommandText = "SELECT CONCAT_WS(' ', etudiants.nom, etudiants.prenom) AS nom, etudiants.adresse, etudiants.tel1, DATE(graduations.date_graduation) AS date_graduation, fond_de_soutiens.montant_recu, fond_de_soutiens.interet, fond_de_soutiens.penalite, SUM(paiement.montant_paye) AS montant_remboursser FROM etudiants INNER JOIN fond_de_soutiens ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON fond_de_soutiens.id = paiement.id_fond_soutien LEFT JOIN graduations ON etudiants.id = graduations.etudiant_id WHERE fond_de_soutiens.id = '" & _fond_id & "'"
                    Dim result As MySqlDataReader = cmd.ExecuteReader

                    If result.HasRows Then
                        result.Read()
                        .SetParameters(New ReportParameter("rptNom", result("nom").ToString))
                        .SetParameters(New ReportParameter("rptAdresse", result("adresse").ToString))
                        .SetParameters(New ReportParameter("rptTel", result("tel1").ToString))
                        .SetParameters(New ReportParameter("rptDateGraduation", result _
                                                           ("date_graduation").ToString))
                        .SetParameters(New ReportParameter("rptMontantRecu", result _
                                                           ("montant_recu").ToString))
                        .SetParameters(New ReportParameter("rptInteret", result("interet").ToString))
                        .SetParameters(New ReportParameter("rptPenalite", result("penalite").ToString))
                        .SetParameters(New ReportParameter("rptMontantRembourser", result _
                                                           ("montant_remboursser").ToString))
                    End If
                    result.Close()

                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.RecuFond, DataTable)))
                End With

                With Report
                    .ZoomMode = ZoomMode.PageWidth
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .RefreshReport()
                End With


            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

        End Sub

    End Class
End Namespace