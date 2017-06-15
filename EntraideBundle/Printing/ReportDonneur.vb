Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class ReportDonneur

        Public ds As DataSetTables

        Sub New(ByVal ds As DataSetTables)

            ' Cet appel est requis par le concepteur.
            InitializeComponent()

            ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
            Me.ds = ds
        End Sub

        Private Sub ReportDonneur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub

        Sub RefreshReport()
            Try
                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\ReportDonneurs.rdlc"
                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.Donneurs, DataTable)))
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