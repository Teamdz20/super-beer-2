Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class ReportAllRevenu

        Private ds As DataSetTables
        Private source As String
        Private periode As String

        Public Sub New(ds As DataSetTables, source As String, periode As String)

            ' Cet appel est requis par le concepteur.
            InitializeComponent()

            ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
            Me.ds = ds
            Me.source = source
            Me.periode = periode
        End Sub

        Private Sub ReportAllRevenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub

        Private Sub RefreshReport()
            Try
                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\ReportAllRevenu.rdlc"
                    .SetParameters(New ReportParameter("rptSource", source))
                    .SetParameters(New ReportParameter("rptPeriode", periode))
                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.RapportRevenu, DataTable)))
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