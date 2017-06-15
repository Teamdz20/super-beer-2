<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportFournisseur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RapportFournisseur))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnRapport = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.labelTotal = New MetroFramework.Controls.MetroLabel()
        Me.ListeFournisseur = New System.Windows.Forms.ListView()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1346, 668)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnClose)
        Me.MetroPanel1.Controls.Add(Me.MetroButton2)
        Me.MetroPanel1.Controls.Add(Me.btnRapport)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.labelTotal)
        Me.MetroPanel1.Controls.Add(Me.ListeFournisseur)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1340, 662)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(740, 605)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 37)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(472, 605)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(128, 37)
        Me.MetroButton2.TabIndex = 17
        Me.MetroButton2.Text = "EXPORTER"
        Me.MetroButton2.UseSelectable = True
        '
        'btnRapport
        '
        Me.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRapport.Location = New System.Drawing.Point(606, 605)
        Me.btnRapport.Name = "btnRapport"
        Me.btnRapport.Size = New System.Drawing.Size(128, 37)
        Me.btnRapport.TabIndex = 18
        Me.btnRapport.Text = "RAPPORT"
        Me.btnRapport.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(46, 587)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(156, 19)
        Me.MetroLabel5.TabIndex = 14
        Me.MetroLabel5.Text = "Nombre de fournisseur : "
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelTotal.Location = New System.Drawing.Point(217, 581)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(100, 30)
        Me.labelTotal.TabIndex = 15
        Me.labelTotal.Text = "0"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListeFournisseur
        '
        Me.ListeFournisseur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.ListeFournisseur.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeFournisseur.FullRowSelect = True
        Me.ListeFournisseur.GridLines = True
        Me.ListeFournisseur.Location = New System.Drawing.Point(6, 116)
        Me.ListeFournisseur.Name = "ListeFournisseur"
        Me.ListeFournisseur.Size = New System.Drawing.Size(1331, 459)
        Me.ListeFournisseur.TabIndex = 0
        Me.ListeFournisseur.UseCompatibleStateImageBehavior = False
        Me.ListeFournisseur.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Représentant"
        Me.ColumnHeader3.Width = 196
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Adresse"
        Me.ColumnHeader4.Width = 177
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email"
        Me.ColumnHeader5.Width = 181
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date"
        Me.ColumnHeader6.Width = 157
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Code"
        Me.ColumnHeader7.Width = 129
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Tel 1"
        Me.ColumnHeader8.Width = 167
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Tel 2"
        Me.ColumnHeader9.Width = 156
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Categorie Donneur"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Site"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Restriction"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Periode"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Note"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Poste"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Type don"
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1331, 107)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(1030, 87)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(174, 15)
        Me.chkAll.TabIndex = 6
        Me.chkAll.Text = "Inclure tous les autres détails"
        Me.chkAll.UseSelectable = True
        '
        'ChkPredef
        '
        Me.ChkPredef.AutoSize = True
        Me.ChkPredef.Location = New System.Drawing.Point(1030, 65)
        Me.ChkPredef.Name = "ChkPredef"
        Me.ChkPredef.Size = New System.Drawing.Size(145, 15)
        Me.ChkPredef.TabIndex = 6
        Me.ChkPredef.Text = "Présentation prédéfinie"
        Me.ChkPredef.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.Location = New System.Drawing.Point(379, 68)
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
        Me.btSearch.Location = New System.Drawing.Point(1122, 18)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 35)
        Me.btSearch.TabIndex = 4
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'btClean
        '
        Me.btClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClean.Location = New System.Drawing.Point(1030, 18)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(75, 35)
        Me.btClean.TabIndex = 4
        Me.btClean.Text = "Vider"
        Me.btClean.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(152, 23)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(155, 29)
        Me.cmbTypeRapport.TabIndex = 2
        Me.cmbTypeRapport.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(152, 68)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(155, 29)
        Me.cmbAnnee.TabIndex = 2
        Me.cmbAnnee.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(331, 74)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Au"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 29)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Type de rapport"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(331, 29)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Du"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Année"
        '
        'RapportFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 748)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RapportFournisseur"
        Me.Text = "FOURNISSEUR : RAPPORT"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ListeFournisseur As System.Windows.Forms.ListView
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ChkPredef As MetroFramework.Controls.MetroCheckBox
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
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRapport As MetroFramework.Controls.MetroButton
End Class
