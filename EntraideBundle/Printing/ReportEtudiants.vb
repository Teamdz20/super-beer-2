Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class ReportEtudiants

        Private ds As DataSetTables

        Private generation As String

        Private formation As String

        Private nbDette As String

        Private nbComplete As String

        Public Sub New(ds As DataSetTables, generation As String, formation As String, nbDette As String, nbComplete As String)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.ds = ds
            Me.generation = generation
            Me.formation = formation
            Me.nbDette = nbDette
            Me.nbComplete = nbComplete
        End Sub

        Private Sub ReportEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Private Sub RefreshReport()
            Try
                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\ReportEtudiants.rdlc"
                    .SetParameters(New ReportParameter("rptGeneration", generation))
                    .SetParameters(New ReportParameter("rptFormation", formation))
                    .SetParameters(New ReportParameter("rptNbDette", nbDette))
                    .SetParameters(New ReportParameter("rptNbComplet", nbComplete))
                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.Etudiants, DataTable)))
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