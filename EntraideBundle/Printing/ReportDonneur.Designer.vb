Namespace Printing
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ReportDonneur
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDonneur))
            Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.DataSetTables = New EntraideBundle.DataSetTables()
            Me.DonneursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DonneursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Report
            '
            Me.Report.Dock = System.Windows.Forms.DockStyle.Fill
            ReportDataSource1.Name = "DataSetTables"
            ReportDataSource1.Value = Me.DonneursBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.ReportEmbeddedResource = "EntraideBundle.ReportDonneurs.rdlc"
            Me.Report.Location = New System.Drawing.Point(0, 0)
            Me.Report.Name = "Report"
            Me.Report.Size = New System.Drawing.Size(1008, 505)
            Me.Report.TabIndex = 0
            '
            'DataSetTables
            '
            Me.DataSetTables.DataSetName = "DataSetTables"
            Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DonneursBindingSource
            '
            Me.DonneursBindingSource.DataMember = "Donneurs"
            Me.DonneursBindingSource.DataSource = Me.DataSetTables
            '
            'ReportDonneur
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1008, 505)
            Me.Controls.Add(Me.Report)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ReportDonneur"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ReportDonneur"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DonneursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents DonneursBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents DataSetTables As EntraideBundle.DataSetTables
    End Class

End Namespace