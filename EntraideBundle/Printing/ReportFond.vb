Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class ReportFond

        Private ds As DataSetTables
        Private total As String
        Private nb_etudiant As String

        Public Sub New(ds As DataSetTables, total As String, nbEtudiant As String)

            ' Cet appel est requis par le concepteur.
            InitializeComponent()

            ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
            Me.ds = ds
            Me.total = total
            Me.nb_etudiant = nbEtudiant
        End Sub

        Private Sub ReportFond_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub

        Private Sub RefreshReport()
            Try
                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\ReportFond.rdlc"
                    .SetParameters(New ReportParameter("rptTotal", total))
                    .SetParameters(New ReportParameter("rptNbEtudiant", nb_etudiant))
                    .SetParameters(New ReportParameter("rptNbRetard", 0))
                    .SetParameters(New ReportParameter("rptNonRetard", 0))
                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.FondSoutiens, DataTable)))
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
                GC.Collect()
            End Try
        End Sub

    End Class
End Namespace