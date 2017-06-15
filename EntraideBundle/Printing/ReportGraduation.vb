Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class ReportGraduation

        Private ds As DataSetTables
        Private generation As String
        Private formation As String


        Public Sub New(ds As DataSetTables, generation As String, formation As String)

            InitializeComponent()

            Me.ds = ds
            Me.generation = generation
            Me.formation = formation
        End Sub

        Private Sub ReportGraduation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub

        Private Sub RefreshReport()
            Try
                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\ReportGraduation.rdlc"
                    .SetParameters(New ReportParameter("rptGeneration", generation))
                    .SetParameters(New ReportParameter("rptFormation", formation))
                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.Graduation, DataTable)))
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