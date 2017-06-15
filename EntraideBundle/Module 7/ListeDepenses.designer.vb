<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeDepenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeDepenses))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckDetail = New MetroFramework.Controls.MetroRadioButton()
        Me.ckPredefini = New MetroFramework.Controls.MetroRadioButton()
        Me.linkAll = New MetroFramework.Controls.MetroLink()
        Me.cmbTypeDepense = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.AU = New MetroFramework.Controls.MetroLabel()
        Me.btRecherche = New MetroFramework.Controls.MetroButton()
        Me.btVider = New MetroFramework.Controls.MetroButton()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListDepense = New System.Windows.Forms.ListView()
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.85714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1338, 700)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1332, 106)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckDetail)
        Me.GroupBox1.Controls.Add(Me.ckPredefini)
        Me.GroupBox1.Controls.Add(Me.linkAll)
        Me.GroupBox1.Controls.Add(Me.cmbTypeDepense)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.AU)
        Me.GroupBox1.Controls.Add(Me.btRecherche)
        Me.GroupBox1.Controls.Add(Me.btVider)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1332, 105)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche Rapide"
        '
        'ckDetail
        '
        Me.ckDetail.AutoSize = True
        Me.ckDetail.Location = New System.Drawing.Point(953, 42)
        Me.ckDetail.Name = "ckDetail"
        Me.ckDetail.Size = New System.Drawing.Size(174, 15)
        Me.ckDetail.TabIndex = 24
        Me.ckDetail.Text = "Inclure tous les autres détails"
        Me.ckDetail.UseSelectable = True
        '
        'ckPredefini
        '
        Me.ckPredefini.AutoSize = True
        Me.ckPredefini.Location = New System.Drawing.Point(953, 20)
        Me.ckPredefini.Name = "ckPredefini"
        Me.ckPredefini.Size = New System.Drawing.Size(145, 15)
        Me.ckPredefini.TabIndex = 23
        Me.ckPredefini.Text = "Présentation prédéfinie"
        Me.ckPredefini.UseSelectable = True
        '
        'linkAll
        '
        Me.linkAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkAll.Location = New System.Drawing.Point(571, 63)
        Me.linkAll.Name = "linkAll"
        Me.linkAll.Size = New System.Drawing.Size(119, 27)
        Me.linkAll.TabIndex = 22
        Me.linkAll.Text = "TOUT AFFICHER"
        Me.linkAll.UseSelectable = True
        '
        'cmbTypeDepense
        '
        Me.cmbTypeDepense.FormattingEnabled = True
        Me.cmbTypeDepense.ItemHeight = 23
        Me.cmbTypeDepense.Items.AddRange(New Object() {"Rembourssement", "Autre Paiement"})
        Me.cmbTypeDepense.Location = New System.Drawing.Point(751, 20)
        Me.cmbTypeDepense.Name = "cmbTypeDepense"
        Me.cmbTypeDepense.Size = New System.Drawing.Size(163, 29)
        Me.cmbTypeDepense.TabIndex = 20
        Me.cmbTypeDepense.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(249, 65)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(117, 29)
        Me.cmbAu.TabIndex = 19
        '
        'cmbDu
        '
        Me.cmbDu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(68, 65)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(117, 29)
        Me.cmbDu.TabIndex = 18
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(8, 71)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel4.TabIndex = 17
        Me.MetroLabel4.Text = "Periode"
        '
        'AU
        '
        Me.AU.AutoSize = True
        Me.AU.Location = New System.Drawing.Point(218, 70)
        Me.AU.Name = "AU"
        Me.AU.Size = New System.Drawing.Size(25, 19)
        Me.AU.TabIndex = 17
        Me.AU.Text = "Au"
        '
        'btRecherche
        '
        Me.btRecherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRecherche.Location = New System.Drawing.Point(1061, 66)
        Me.btRecherche.Name = "btRecherche"
        Me.btRecherche.Size = New System.Drawing.Size(100, 32)
        Me.btRecherche.TabIndex = 13
        Me.btRecherche.Text = "Rechercher"
        Me.btRecherche.UseSelectable = True
        '
        'btVider
        '
        Me.btVider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVider.Location = New System.Drawing.Point(955, 66)
        Me.btVider.Name = "btVider"
        Me.btVider.Size = New System.Drawing.Size(100, 32)
        Me.btVider.TabIndex = 12
        Me.btVider.Text = "Vider"
        Me.btVider.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(68, 24)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(117, 29)
        Me.cmbAnnee.TabIndex = 11
        Me.cmbAnnee.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(319, 24)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(128, 29)
        Me.cmbTypeRapport.TabIndex = 6
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(9, 29)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Année :"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Location = New System.Drawing.Point(558, 24)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(186, 25)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Triage par type de Depense" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(198, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type de Rapport :"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.GroupBox2)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(3, 115)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(1332, 441)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListDepense)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1332, 420)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste de Depense"
        '
        'ListDepense
        '
        Me.ListDepense.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListDepense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDepense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDepense.FullRowSelect = True
        Me.ListDepense.GridLines = True
        Me.ListDepense.Location = New System.Drawing.Point(3, 22)
        Me.ListDepense.Name = "ListDepense"
        Me.ListDepense.Size = New System.Drawing.Size(1326, 395)
        Me.ListDepense.TabIndex = 0
        Me.ListDepense.UseCompatibleStateImageBehavior = False
        Me.ListDepense.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "id"
        Me.ColumnHeader22.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "EN REGLEMENT DE"
        Me.ColumnHeader1.Width = 225
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MONTANT"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DEVISE"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "REALISER PAR"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "BENEFICIAIRE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TYPE DE DEPENSE"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DEPARTEMENT"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ACTIVITE MENEE"
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "CODE DEPENSE"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "NOM MANAGER"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CODE SORTIE"
        Me.ColumnHeader11.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DATE"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.txtTotal)
        Me.MetroPanel3.Controls.Add(Me.MetroButton6)
        Me.MetroPanel3.Controls.Add(Me.btnReport)
        Me.MetroPanel3.Controls.Add(Me.MetroButton3)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(3, 562)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(1332, 135)
        Me.MetroPanel3.TabIndex = 2
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(655, 19)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(191, 33)
        Me.txtTotal.TabIndex = 26
        '
        'MetroButton6
        '
        Me.MetroButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton6.Location = New System.Drawing.Point(734, 76)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(125, 38)
        Me.MetroButton6.TabIndex = 25
        Me.MetroButton6.Text = "Fermer"
        Me.MetroButton6.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Location = New System.Drawing.Point(604, 76)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(125, 38)
        Me.btnReport.TabIndex = 24
        Me.btnReport.Text = "Rapport"
        Me.btnReport.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton3.Location = New System.Drawing.Point(473, 76)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(125, 38)
        Me.MetroButton3.TabIndex = 23
        Me.MetroButton3.Text = "Exporter"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(486, 24)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(142, 25)
        Me.MetroLabel9.TabIndex = 6
        Me.MetroLabel9.Text = "Totale depense"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PROGRAMME"
        Me.ColumnHeader13.Width = 0
        '
        'ListeDepenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeDepenses"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "FINANCE : RAPPORT DES DEPENSE"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents AU As MetroFramework.Controls.MetroLabel
    Friend WithEvents btRecherche As MetroFramework.Controls.MetroButton
    Friend WithEvents btVider As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListDepense As System.Windows.Forms.ListView
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbTypeDepense As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents linkAll As MetroFramework.Controls.MetroLink
    Friend WithEvents ckDetail As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckPredefini As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
End Class
