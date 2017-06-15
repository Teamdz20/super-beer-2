Namespace Printing
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ReportDons
        Inherits System.Windows.Forms.Form

        'Form remplace la méthode Dispose pour nettoyer la liste des composants.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requise par le Concepteur Windows Form
        Private components As System.ComponentModel.IContainer

        'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        'Ne la modifiez pas à l'aide de l'éditeur de code.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDons))
            Me.DonsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.DataSetTables = New EntraideBundle.DataSetTables()
            Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
            CType(Me.DonsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DonsBindingSource
            '
            Me.DonsBindingSource.DataMember = "Dons"
            Me.DonsBindingSource.DataSource = Me.DataSetTables
            '
            'DataSetTables
            '
            Me.DataSetTables.DataSetName = "DataSetTables"
            Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Report
            '
            Me.Report.Dock = System.Windows.Forms.DockStyle.Fill
            ReportDataSource1.Name = "DataSetTables"
            ReportDataSource1.Value = Me.DonsBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.EnableExternalImages = True
            Me.Report.LocalReport.ReportEmbeddedResource = "EntraideBundle.ReportDons.rdlc"
            Me.Report.Location = New System.Drawing.Point(0, 0)
            Me.Report.Name = "Report"
            Me.Report.Size = New System.Drawing.Size(1007, 541)
            Me.Report.TabIndex = 0
            '
            'ReportDons
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1007, 541)
            Me.Controls.Add(Me.Report)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ReportDons"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ReportDons"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DonsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents DonsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents DataSetTables As EntraideBundle.DataSetTables
    End Class

End Namespace