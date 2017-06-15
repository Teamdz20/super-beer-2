Namespace Printing
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ReportRevenu
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportRevenu))
            Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.DataSetTables = New EntraideBundle.DataSetTables()
            Me.RevenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RevenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Report
            '
            Me.Report.Dock = System.Windows.Forms.DockStyle.Fill
            ReportDataSource1.Name = "DataSetTables"
            ReportDataSource1.Value = Me.RevenuBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.ReportEmbeddedResource = "EntraideBundle.ReportRevenu.rdlc"
            Me.Report.Location = New System.Drawing.Point(0, 0)
            Me.Report.Name = "Report"
            Me.Report.Size = New System.Drawing.Size(999, 607)
            Me.Report.TabIndex = 0
            '
            'DataSetTables
            '
            Me.DataSetTables.DataSetName = "DataSetTables"
            Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'RevenuBindingSource
            '
            Me.RevenuBindingSource.DataMember = "Revenu"
            Me.RevenuBindingSource.DataSource = Me.DataSetTables
            '
            'ReportRevenu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(999, 607)
            Me.Controls.Add(Me.Report)
            Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "ReportRevenu"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Report des revenus agrs"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RevenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents RevenuBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents DataSetTables As EntraideBundle.DataSetTables
    End Class

End Namespace