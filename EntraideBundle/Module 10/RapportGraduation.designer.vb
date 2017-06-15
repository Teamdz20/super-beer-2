<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportGraduation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RapportGraduation))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.labelTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.ListeGraduation = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbFormation = New System.Windows.Forms.ComboBox()
        Me.ckFormation = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbGeneration = New System.Windows.Forms.ComboBox()
        Me.ckGeneration = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbEtudiant = New System.Windows.Forms.ComboBox()
        Me.ckEtudiant = New MetroFramework.Controls.MetroCheckBox()
        Me.btSearch = New MetroFramework.Controls.MetroButton()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAu = New MetroFramework.Controls.MetroDateTime()
        Me.cmbDu = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.labelTotal)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MetroButton3)
        Me.MetroPanel1.Controls.Add(Me.btnReport)
        Me.MetroPanel1.Controls.Add(Me.btnClose)
        Me.MetroPanel1.Controls.Add(Me.ListeGraduation)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1324, 668)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelTotal.Location = New System.Drawing.Point(664, 555)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(156, 34)
        Me.labelTotal.TabIndex = 5
        Me.labelTotal.Text = "0"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(504, 563)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(146, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Nombre des Gradués : "
        '
        'MetroButton3
        '
        Me.MetroButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton3.Location = New System.Drawing.Point(497, 604)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(106, 39)
        Me.MetroButton3.TabIndex = 3
        Me.MetroButton3.Text = "EXPORTER"
        Me.MetroButton3.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Location = New System.Drawing.Point(609, 604)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(106, 39)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "RAPPORT"
        Me.btnReport.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(721, 604)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 39)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'ListeGraduation
        '
        Me.ListeGraduation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListeGraduation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeGraduation.FullRowSelect = True
        Me.ListeGraduation.GridLines = True
        Me.ListeGraduation.Location = New System.Drawing.Point(3, 143)
        Me.ListeGraduation.Name = "ListeGraduation"
        Me.ListeGraduation.Size = New System.Drawing.Size(1314, 395)
        Me.ListeGraduation.TabIndex = 0
        Me.ListeGraduation.UseCompatibleStateImageBehavior = False
        Me.ListeGraduation.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOM"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRENOM"
        Me.ColumnHeader3.Width = 174
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TEL"
        Me.ColumnHeader4.Width = 185
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ADRESSE"
        Me.ColumnHeader5.Width = 188
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GENERATION"
        Me.ColumnHeader6.Width = 184
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "FORMATION"
        Me.ColumnHeader7.Width = 209
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DATE GRADUATION"
        Me.ColumnHeader8.Width = 179
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbFormation)
        Me.GroupBox1.Controls.Add(Me.ckFormation)
        Me.GroupBox1.Controls.Add(Me.cmbGeneration)
        Me.GroupBox1.Controls.Add(Me.ckGeneration)
        Me.GroupBox1.Controls.Add(Me.cmbEtudiant)
        Me.GroupBox1.Controls.Add(Me.ckEtudiant)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1314, 137)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'cmbFormation
        '
        Me.cmbFormation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFormation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFormation.Enabled = False
        Me.cmbFormation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormation.FormattingEnabled = True
        Me.cmbFormation.Location = New System.Drawing.Point(671, 89)
        Me.cmbFormation.Name = "cmbFormation"
        Me.cmbFormation.Size = New System.Drawing.Size(241, 29)
        Me.cmbFormation.TabIndex = 23
        '
        'ckFormation
        '
        Me.ckFormation.AutoSize = True
        Me.ckFormation.Location = New System.Drawing.Point(553, 96)
        Me.ckFormation.Name = "ckFormation"
        Me.ckFormation.Size = New System.Drawing.Size(107, 15)
        Me.ckFormation.TabIndex = 22
        Me.ckFormation.Text = "Par Formation : "
        Me.ckFormation.UseSelectable = True
        '
        'cmbGeneration
        '
        Me.cmbGeneration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGeneration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGeneration.Enabled = False
        Me.cmbGeneration.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGeneration.FormattingEnabled = True
        Me.cmbGeneration.Location = New System.Drawing.Point(671, 58)
        Me.cmbGeneration.Name = "cmbGeneration"
        Me.cmbGeneration.Size = New System.Drawing.Size(241, 29)
        Me.cmbGeneration.TabIndex = 23
        '
        'ckGeneration
        '
        Me.ckGeneration.AutoSize = True
        Me.ckGeneration.Location = New System.Drawing.Point(553, 65)
        Me.ckGeneration.Name = "ckGeneration"
        Me.ckGeneration.Size = New System.Drawing.Size(110, 15)
        Me.ckGeneration.TabIndex = 22
        Me.ckGeneration.Text = "Par Generation : "
        Me.ckGeneration.UseSelectable = True
        '
        'cmbEtudiant
        '
        Me.cmbEtudiant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEtudiant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEtudiant.Enabled = False
        Me.cmbEtudiant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEtudiant.FormattingEnabled = True
        Me.cmbEtudiant.Location = New System.Drawing.Point(671, 25)
        Me.cmbEtudiant.Name = "cmbEtudiant"
        Me.cmbEtudiant.Size = New System.Drawing.Size(241, 29)
        Me.cmbEtudiant.TabIndex = 23
        '
        'ckEtudiant
        '
        Me.ckEtudiant.AutoSize = True
        Me.ckEtudiant.Location = New System.Drawing.Point(553, 32)
        Me.ckEtudiant.Name = "ckEtudiant"
        Me.ckEtudiant.Size = New System.Drawing.Size(96, 15)
        Me.ckEtudiant.TabIndex = 22
        Me.ckEtudiant.Text = "Par Etudiant : "
        Me.ckEtudiant.UseSelectable = True
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Location = New System.Drawing.Point(1125, 58)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(94, 32)
        Me.btSearch.TabIndex = 21
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(128, 25)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(170, 29)
        Me.cmbTypeRapport.TabIndex = 19
        Me.cmbTypeRapport.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(128, 58)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(170, 29)
        Me.cmbAnnee.TabIndex = 20
        Me.cmbAnnee.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(353, 89)
        Me.cmbAu.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(151, 29)
        Me.cmbAu.TabIndex = 17
        '
        'cmbDu
        '
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(128, 89)
        Me.cmbDu.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(170, 29)
        Me.cmbDu.TabIndex = 18
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(322, 94)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Au"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(6, 30)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel8.TabIndex = 14
        Me.MetroLabel8.Text = "Type de rappport"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(6, 94)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel5.TabIndex = 15
        Me.MetroLabel5.Text = "Periode du :"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 16
        Me.MetroLabel1.Text = "Année"
        '
        'RapportGraduation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 760)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RapportGraduation"
        Me.Text = "GRADUATION  :  LISTE / RAPPORT DES GRADUES"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbAu As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbDu As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListeGraduation As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents labelTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbEtudiant As System.Windows.Forms.ComboBox
    Friend WithEvents ckEtudiant As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbGeneration As System.Windows.Forms.ComboBox
    Friend WithEvents ckGeneration As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbFormation As System.Windows.Forms.ComboBox
    Friend WithEvents ckFormation As MetroFramework.Controls.MetroCheckBox
End Class
