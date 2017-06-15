<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevenuGeneral
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RevenuGeneral))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnRapport = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.labelTotal = New MetroFramework.Controls.MetroLabel()
        Me.ListRevenu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.ckType = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cmbType = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.btnRapport)
        Me.PanelContainer.Controls.Add(Me.MetroLabel5)
        Me.PanelContainer.Controls.Add(Me.labelTotal)
        Me.PanelContainer.Controls.Add(Me.ListRevenu)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1054, 637)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(597, 587)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 37)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(329, 587)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(128, 37)
        Me.MetroButton1.TabIndex = 12
        Me.MetroButton1.Text = "EXPORTER"
        Me.MetroButton1.UseSelectable = True
        '
        'btnRapport
        '
        Me.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRapport.Location = New System.Drawing.Point(463, 587)
        Me.btnRapport.Name = "btnRapport"
        Me.btnRapport.Size = New System.Drawing.Size(128, 37)
        Me.btnRapport.TabIndex = 13
        Me.btnRapport.Text = "RAPPORT"
        Me.btnRapport.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(375, 545)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Total des fonds : "
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelTotal.Location = New System.Drawing.Point(492, 539)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(187, 30)
        Me.labelTotal.TabIndex = 10
        Me.labelTotal.Text = "0"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListRevenu
        '
        Me.ListRevenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListRevenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListRevenu.FullRowSelect = True
        Me.ListRevenu.GridLines = True
        Me.ListRevenu.Location = New System.Drawing.Point(3, 132)
        Me.ListRevenu.Name = "ListRevenu"
        Me.ListRevenu.Size = New System.Drawing.Size(1048, 388)
        Me.ListRevenu.TabIndex = 3
        Me.ListRevenu.UseCompatibleStateImageBehavior = False
        Me.ListRevenu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SOURCE DE REVENU"
        Me.ColumnHeader1.Width = 306
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DE"
        Me.ColumnHeader2.Width = 258
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MONTANT"
        Me.ColumnHeader3.Width = 258
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATE"
        Me.ColumnHeader4.Width = 217
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.ckType)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1048, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(833, 43)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 32)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Recherche"
        Me.btnSearch.UseSelectable = True
        '
        'ckType
        '
        Me.ckType.AutoSize = True
        Me.ckType.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckType.Location = New System.Drawing.Point(393, 50)
        Me.ckType.Name = "ckType"
        Me.ckType.Size = New System.Drawing.Size(126, 19)
        Me.ckType.TabIndex = 26
        Me.ckType.Text = "Filtrer par type : "
        Me.ckType.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(240, 88)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(126, 29)
        Me.cmbAu.TabIndex = 23
        '
        'cmbDu
        '
        Me.cmbDu.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.CustomFormat = ""
        Me.cmbDu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(74, 88)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(126, 29)
        Me.cmbDu.TabIndex = 24
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(209, 92)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel4.TabIndex = 22
        Me.MetroLabel4.Text = "Au"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(11, 92)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 20
        Me.MetroLabel3.Text = "Periode : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(11, 61)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel2.TabIndex = 21
        Me.MetroLabel2.Text = "Annee : "
        '
        'cmbType
        '
        Me.cmbType.Enabled = False
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 23
        Me.cmbType.Items.AddRange(New Object() {"", "DON", "FOND DE SOUTIENS", "AGR", "INSCRIPTION ETUDIANT"})
        Me.cmbType.Location = New System.Drawing.Point(525, 46)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(238, 29)
        Me.cmbType.TabIndex = 18
        Me.cmbType.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 19
        Me.cmbAnnee.Location = New System.Drawing.Point(128, 58)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.PromptText = "2015"
        Me.cmbAnnee.Size = New System.Drawing.Size(238, 25)
        Me.cmbAnnee.TabIndex = 18
        Me.cmbAnnee.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 19
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(128, 28)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(238, 25)
        Me.cmbTypeRapport.TabIndex = 19
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 31)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Type de rapport : "
        '
        'RevenuGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 723)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RevenuGeneral"
        Me.Text = "REVENU GENERAL : RAPPORT"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ckType As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents ListRevenu As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRapport As MetroFramework.Controls.MetroButton
End Class
