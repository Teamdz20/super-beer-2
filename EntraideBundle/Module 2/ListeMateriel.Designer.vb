<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeMateriel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeMateriel))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.ListMateriel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckDep = New MetroFramework.Controls.MetroCheckBox()
        Me.ckMode = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbDepartement = New MetroFramework.Controls.MetroComboBox()
        Me.cmbModeObtention = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.AU = New MetroFramework.Controls.MetroLabel()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.btVider = New MetroFramework.Controls.MetroButton()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ckDetail = New MetroFramework.Controls.MetroRadioButton()
        Me.ckPredefini = New MetroFramework.Controls.MetroRadioButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.txtTotal)
        Me.PanelContainer.Controls.Add(Me.MetroLabel9)
        Me.PanelContainer.Controls.Add(Me.MetroButton3)
        Me.PanelContainer.Controls.Add(Me.MetroButton2)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.ListMateriel)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1176, 632)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'MetroButton3
        '
        Me.MetroButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton3.Location = New System.Drawing.Point(424, 579)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(107, 40)
        Me.MetroButton3.TabIndex = 6
        Me.MetroButton3.Text = "EXPORTER"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(535, 579)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(107, 40)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "RAPPORT"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(646, 579)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(107, 40)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'ListMateriel
        '
        Me.ListMateriel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader7})
        Me.ListMateriel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListMateriel.FullRowSelect = True
        Me.ListMateriel.GridLines = True
        Me.ListMateriel.Location = New System.Drawing.Point(11, 115)
        Me.ListMateriel.Name = "ListMateriel"
        Me.ListMateriel.Size = New System.Drawing.Size(1151, 403)
        Me.ListMateriel.TabIndex = 5
        Me.ListMateriel.UseCompatibleStateImageBehavior = False
        Me.ListMateriel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TYPE DE MATERIEL"
        Me.ColumnHeader2.Width = 185
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MARQUE"
        Me.ColumnHeader3.Width = 202
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DESCRIPTION"
        Me.ColumnHeader4.Width = 315
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MODE D'OBTENTION"
        Me.ColumnHeader5.Width = 168
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PRIX TOTAL"
        Me.ColumnHeader6.Width = 149
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "index"
        Me.ColumnHeader7.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckDetail)
        Me.GroupBox1.Controls.Add(Me.ckPredefini)
        Me.GroupBox1.Controls.Add(Me.ckDep)
        Me.GroupBox1.Controls.Add(Me.ckMode)
        Me.GroupBox1.Controls.Add(Me.cmbDepartement)
        Me.GroupBox1.Controls.Add(Me.cmbModeObtention)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.AU)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btVider)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1151, 105)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche Rapide"
        '
        'ckDep
        '
        Me.ckDep.AutoSize = True
        Me.ckDep.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckDep.Location = New System.Drawing.Point(468, 71)
        Me.ckDep.Name = "ckDep"
        Me.ckDep.Size = New System.Drawing.Size(117, 19)
        Me.ckDep.TabIndex = 24
        Me.ckDep.Text = "Departement : "
        Me.ckDep.UseSelectable = True
        '
        'ckMode
        '
        Me.ckMode.AutoSize = True
        Me.ckMode.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckMode.Location = New System.Drawing.Point(468, 26)
        Me.ckMode.Name = "ckMode"
        Me.ckMode.Size = New System.Drawing.Size(167, 19)
        Me.ckMode.TabIndex = 24
        Me.ckMode.Text = "Methode d'obtention : "
        Me.ckMode.UseSelectable = True
        '
        'cmbDepartement
        '
        Me.cmbDepartement.Enabled = False
        Me.cmbDepartement.FormattingEnabled = True
        Me.cmbDepartement.ItemHeight = 23
        Me.cmbDepartement.Items.AddRange(New Object() {"DON", "ACHAT", "Tout"})
        Me.cmbDepartement.Location = New System.Drawing.Point(638, 64)
        Me.cmbDepartement.Name = "cmbDepartement"
        Me.cmbDepartement.Size = New System.Drawing.Size(163, 29)
        Me.cmbDepartement.TabIndex = 20
        Me.cmbDepartement.UseSelectable = True
        '
        'cmbModeObtention
        '
        Me.cmbModeObtention.Enabled = False
        Me.cmbModeObtention.FormattingEnabled = True
        Me.cmbModeObtention.ItemHeight = 23
        Me.cmbModeObtention.Items.AddRange(New Object() {"", "DON", "ACHAT"})
        Me.cmbModeObtention.Location = New System.Drawing.Point(638, 22)
        Me.cmbModeObtention.Name = "cmbModeObtention"
        Me.cmbModeObtention.Size = New System.Drawing.Size(163, 29)
        Me.cmbModeObtention.TabIndex = 20
        Me.cmbModeObtention.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.CustomFormat = "dd/MM/YYYY"
        Me.cmbAu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(260, 64)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(191, 27)
        Me.cmbAu.TabIndex = 19
        '
        'cmbDu
        '
        Me.cmbDu.CustomFormat = "dd/MM/YYYY"
        Me.cmbDu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(51, 64)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(134, 27)
        Me.cmbDu.TabIndex = 18
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(8, 68)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(27, 19)
        Me.MetroLabel4.TabIndex = 17
        Me.MetroLabel4.Text = "Du"
        '
        'AU
        '
        Me.AU.AutoSize = True
        Me.AU.Location = New System.Drawing.Point(229, 68)
        Me.AU.Name = "AU"
        Me.AU.Size = New System.Drawing.Size(25, 19)
        Me.AU.TabIndex = 17
        Me.AU.Text = "Au"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(963, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(125, 30)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseSelectable = True
        '
        'btVider
        '
        Me.btVider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVider.Location = New System.Drawing.Point(832, 65)
        Me.btVider.Name = "btVider"
        Me.btVider.Size = New System.Drawing.Size(125, 30)
        Me.btVider.TabIndex = 12
        Me.btVider.Text = "Vider"
        Me.btVider.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(68, 22)
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
        Me.cmbTypeRapport.Location = New System.Drawing.Point(323, 22)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(128, 29)
        Me.cmbTypeRapport.TabIndex = 6
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(9, 27)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Année :"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(202, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type de Rapport :"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "QUANTITE"
        Me.ColumnHeader8.Width = 125
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "CODE"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "N° FACTURE/RECU"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CODE DEPENSE"
        Me.ColumnHeader11.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "COUT/VALEUR"
        Me.ColumnHeader12.Width = 200
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "FOURNISSEUR"
        Me.ColumnHeader13.Width = 200
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "DONNEUR"
        Me.ColumnHeader14.Width = 200
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "DEPARTEMENT"
        Me.ColumnHeader15.Width = 200
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "ACTIVITE"
        Me.ColumnHeader16.Width = 200
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "RECU PAR"
        Me.ColumnHeader17.Width = 200
        '
        'ckDetail
        '
        Me.ckDetail.AutoSize = True
        Me.ckDetail.Location = New System.Drawing.Point(832, 44)
        Me.ckDetail.Name = "ckDetail"
        Me.ckDetail.Size = New System.Drawing.Size(174, 15)
        Me.ckDetail.TabIndex = 26
        Me.ckDetail.Text = "Inclure tous les autres détails"
        Me.ckDetail.UseSelectable = True
        '
        'ckPredefini
        '
        Me.ckPredefini.AutoSize = True
        Me.ckPredefini.Location = New System.Drawing.Point(832, 22)
        Me.ckPredefini.Name = "ckPredefini"
        Me.ckPredefini.Size = New System.Drawing.Size(145, 15)
        Me.ckPredefini.TabIndex = 25
        Me.ckPredefini.Text = "Présentation prédéfinie"
        Me.ckPredefini.UseSelectable = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(567, 530)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(191, 33)
        Me.txtTotal.TabIndex = 28
        Me.txtTotal.Text = "0"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(419, 537)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(147, 19)
        Me.MetroLabel9.TabIndex = 27
        Me.MetroLabel9.Text = "Elements sur la liste : "
        '
        'ListeMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 718)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeMateriel"
        Me.Text = "MATERIEL : LISTE MATERIEL"
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
    Friend WithEvents cmbModeObtention As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents AU As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btVider As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbDepartement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ListMateriel As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ckDep As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckMode As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ckDetail As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckPredefini As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
End Class
