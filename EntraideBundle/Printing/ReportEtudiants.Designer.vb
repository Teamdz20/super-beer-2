Namespace Printing
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ReportEtudiants
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportEtudiants))
            Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
            Me.DataSetTables = New EntraideBundle.DataSetTables()
            Me.EtudiantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Report
            '
            Me.Report.Dock = System.Windows.Forms.DockStyle.Fill
            ReportDataSource1.Name = "DataSetTables"
            ReportDataSource1.Value = Me.EtudiantsBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.EnableExternalImages = True
            Me.Report.LocalReport.ReportEmbeddedResource = "EntraideBundle.ReportEtudiants.rdlc"
            Me.Report.Location = New System.Drawing.Point(0, 0)
            Me.Report.Name = "Report"
            Me.Report.Size = New System.Drawing.Size(859, 484)
            Me.Report.TabIndex = 1
            '
            'DataSetTables
            '
            Me.DataSetTables.DataSetName = "DataSetTables"
            Me.DataSetTables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'EtudiantsBindingSource
            '
            Me.EtudiantsBindingSource.DataMember = "Etudiants"
            Me.EtudiantsBindingSource.DataSource = Me.DataSetTables
            '
            'ReportEtudiants
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(859, 484)
            Me.Controls.Add(Me.Report)
            Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "ReportEtudiants"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Rapport / Liste des etudiants"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DataSetTables, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EtudiantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
        Friend WithEvents EtudiantsBindingSource As BindingSource
        Friend WithEvents DataSetTables As DataSetTables
    End Class

End Namespace