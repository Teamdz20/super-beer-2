<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportFond
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAll = New MetroFramework.Controls.MetroCheckBox()
        Me.ChkPredef = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbAu = New MetroFramework.Controls.MetroDateTime()
        Me.cmbDu = New MetroFramework.Controls.MetroDateTime()
        Me.btSearch = New MetroFramework.Controls.MetroButton()
        Me.btClean = New MetroFramework.Controls.MetroButton()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.labelRembourssement = New MetroFramework.Controls.MetroLabel()
        Me.labelEt = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.labelTotal = New MetroFramework.Controls.MetroLabel()
        Me.labelNet = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.ListeEtudiants = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ImprimerLhistoriqueDesPaiementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 581.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1346, 708)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1340, 120)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Controls.Add(Me.ChkPredef)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.btClean)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1334, 116)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(1137, 39)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(174, 15)
        Me.chkAll.TabIndex = 6
        Me.chkAll.Text = "Inclure tous les autres détails"
        Me.chkAll.UseSelectable = True
        '
        'ChkPredef
        '
        Me.ChkPredef.AutoSize = True
        Me.ChkPredef.Checked = True
        Me.ChkPredef.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPredef.Location = New System.Drawing.Point(1137, 17)
        Me.ChkPredef.Name = "ChkPredef"
        Me.ChkPredef.Size = New System.Drawing.Size(145, 15)
        Me.ChkPredef.TabIndex = 6
        Me.ChkPredef.Text = "Présentation prédéfinie"
        Me.ChkPredef.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.Location = New System.Drawing.Point(379, 70)
        Me.cmbAu.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(200, 29)
        Me.cmbAu.TabIndex = 5
        '
        'cmbDu
        '
        Me.cmbDu.Location = New System.Drawing.Point(379, 23)
        Me.cmbDu.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(200, 29)
        Me.cmbDu.TabIndex = 5
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Location = New System.Drawing.Point(1231, 62)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(89, 39)
        Me.btSearch.TabIndex = 4
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'btClean
        '
        Me.btClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClean.Location = New System.Drawing.Point(1137, 62)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(89, 39)
        Me.btClean.TabIndex = 4
        Me.btClean.Text = "Vider"
        Me.btClean.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(120, 23)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(155, 29)
        Me.cmbTypeRapport.TabIndex = 2
        Me.cmbTypeRapport.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(120, 70)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(155, 29)
        Me.cmbAnnee.TabIndex = 2
        Me.cmbAnnee.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(294, 75)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Au"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 28)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Type de rapport"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(294, 28)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Periode Du"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 75)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Année"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.labelRembourssement)
        Me.MetroPanel2.Controls.Add(Me.labelEt)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel2.Controls.Add(Me.labelTotal)
        Me.MetroPanel2.Controls.Add(Me.labelNet)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel2.Controls.Add(Me.MetroButton3)
        Me.MetroPanel2.Controls.Add(Me.btnReport)
        Me.MetroPanel2.Controls.Add(Me.btnClose)
        Me.MetroPanel2.Controls.Add(Me.ListeEtudiants)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(3, 130)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(1340, 575)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'labelRembourssement
        '
        Me.labelRembourssement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelRembourssement.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelRembourssement.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelRembourssement.Location = New System.Drawing.Point(581, 459)
        Me.labelRembourssement.Name = "labelRembourssement"
        Me.labelRembourssement.Size = New System.Drawing.Size(123, 30)
        Me.labelRembourssement.TabIndex = 11
        Me.labelRembourssement.Text = "0"
        Me.labelRembourssement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelEt
        '
        Me.labelEt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelEt.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelEt.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelEt.Location = New System.Drawing.Point(1174, 459)
        Me.labelEt.Name = "labelEt"
        Me.labelEt.Size = New System.Drawing.Size(100, 30)
        Me.labelEt.TabIndex = 12
        Me.labelEt.Text = "0"
        Me.labelEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(57, 465)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(177, 19)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Montant total des fonds sorti"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(1041, 465)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel12.TabIndex = 8
        Me.MetroLabel12.Text = "Nombre d'etudiant"
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelTotal.Location = New System.Drawing.Point(240, 459)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(135, 30)
        Me.labelTotal.TabIndex = 13
        Me.labelTotal.Text = "0"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelNet
        '
        Me.labelNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelNet.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelNet.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelNet.Location = New System.Drawing.Point(861, 459)
        Me.labelNet.Name = "labelNet"
        Me.labelNet.Size = New System.Drawing.Size(131, 30)
        Me.labelNet.TabIndex = 14
        Me.labelNet.Text = "0"
        Me.labelNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(391, 465)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(191, 19)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "Montant total rembourssement"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(745, 465)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel10.TabIndex = 10
        Me.MetroLabel10.Text = "Total net a payer"
        '
        'MetroButton3
        '
        Me.MetroButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton3.Location = New System.Drawing.Point(513, 508)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(101, 34)
        Me.MetroButton3.TabIndex = 4
        Me.MetroButton3.Text = "EXPORTER"
        Me.MetroButton3.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Location = New System.Drawing.Point(620, 508)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(101, 34)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "RARPORT"
        Me.btnReport.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(727, 508)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 34)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'ListeEtudiants
        '
        Me.ListeEtudiants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.ListeEtudiants.ContextMenuStrip = Me.MetroContextMenu1
        Me.ListeEtudiants.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeEtudiants.FullRowSelect = True
        Me.ListeEtudiants.GridLines = True
        Me.ListeEtudiants.Location = New System.Drawing.Point(2, 0)
        Me.ListeEtudiants.Name = "ListeEtudiants"
        Me.ListeEtudiants.Size = New System.Drawing.Size(1335, 447)
        Me.ListeEtudiants.TabIndex = 3
        Me.ListeEtudiants.UseCompatibleStateImageBehavior = False
        Me.ListeEtudiants.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom Etudiant"
        Me.ColumnHeader2.Width = 189
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Montant reçu"
        Me.ColumnHeader3.Width = 215
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Delai"
        Me.ColumnHeader4.Width = 185
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "I/CP"
        Me.ColumnHeader5.Width = 169
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nette à payer"
        Me.ColumnHeader6.Width = 173
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Debut paiement"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Fin paiement"
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Date"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Code"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Montant Sollicite"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Mode Reception"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "N° cheque"
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Type Business"
        Me.ColumnHeader14.Width = 0
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Echeange"
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Montant payer"
        Me.ColumnHeader16.Width = 0
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLhistoriqueDesPaiementsToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(265, 48)
        '
        'ImprimerLhistoriqueDesPaiementsToolStripMenuItem
        '
        Me.ImprimerLhistoriqueDesPaiementsToolStripMenuItem.Name = "ImprimerLhistoriqueDesPaiementsToolStripMenuItem"
        Me.ImprimerLhistoriqueDesPaiementsToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ImprimerLhistoriqueDesPaiementsToolStripMenuItem.Text = "Imprimer l'historique des paiements"
        '
        'RapportFond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "RapportFond"
        Me.Text = "FOND DE SOUTIEN : RAPPORT DE FOND DE SOUTIEN"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAu As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbDu As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btClean As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkPredef As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ListeEtudiants As System.Windows.Forms.ListView
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents labelRembourssement As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelEt As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelNet As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ImprimerLhistoriqueDesPaiementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
