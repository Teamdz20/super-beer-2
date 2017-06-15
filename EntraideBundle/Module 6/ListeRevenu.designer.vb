<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeRevenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeRevenu))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnRapport = New MetroFramework.Controls.MetroButton()
        Me.ListRevenu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.btSearch = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.cmbType = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.chkDetail = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.chkPredefini = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ImprimerLeRecuDeCaisseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.MetroButton2)
        Me.PanelContainer.Controls.Add(Me.btnRapport)
        Me.PanelContainer.Controls.Add(Me.ListRevenu)
        Me.PanelContainer.Controls.Add(Me.txtTotal)
        Me.PanelContainer.Controls.Add(Me.MetroLabel7)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 73)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1160, 634)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(650, 581)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 37)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(382, 581)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(128, 37)
        Me.MetroButton2.TabIndex = 9
        Me.MetroButton2.Text = "EXPORTER"
        Me.MetroButton2.UseSelectable = True
        '
        'btnRapport
        '
        Me.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRapport.Location = New System.Drawing.Point(516, 581)
        Me.btnRapport.Name = "btnRapport"
        Me.btnRapport.Size = New System.Drawing.Size(128, 37)
        Me.btnRapport.TabIndex = 10
        Me.btnRapport.Text = "RAPPORT"
        Me.btnRapport.UseSelectable = True
        '
        'ListRevenu
        '
        Me.ListRevenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader7})
        Me.ListRevenu.ContextMenuStrip = Me.MetroContextMenu1
        Me.ListRevenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListRevenu.FullRowSelect = True
        Me.ListRevenu.GridLines = True
        Me.ListRevenu.Location = New System.Drawing.Point(5, 110)
        Me.ListRevenu.Name = "ListRevenu"
        Me.ListRevenu.Size = New System.Drawing.Size(1152, 413)
        Me.ListRevenu.TabIndex = 1
        Me.ListRevenu.UseCompatibleStateImageBehavior = False
        Me.ListRevenu.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 1
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TYPE AGR"
        Me.ColumnHeader6.Width = 182
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOM DU MANAGER"
        Me.ColumnHeader2.Width = 195
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MONTANT ENREGISTRER"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 192
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "RECU DE"
        Me.ColumnHeader4.Width = 225
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "EN REGLEMENT DE"
        Me.ColumnHeader5.Width = 203
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "POSTE"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DEVISE"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "MEMO"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CLASSIFICATION"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DATE"
        Me.ColumnHeader7.Width = 147
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.CustomButton.Image = Nothing
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(229, 2)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotal.Lines = New String(-1) {}
        Me.txtTotal.Location = New System.Drawing.Point(542, 533)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.ShortcutsEnabled = True
        Me.txtTotal.Size = New System.Drawing.Size(257, 30)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(362, 539)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(160, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Montat total des revenus :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.chkDetail)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.chkPredefini)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1152, 97)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'cmbAu
        '
        Me.cmbAu.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(309, 60)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(157, 29)
        Me.cmbAu.TabIndex = 12
        '
        'cmbDu
        '
        Me.cmbDu.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.CustomFormat = ""
        Me.cmbDu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(66, 60)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(142, 29)
        Me.cmbDu.TabIndex = 12
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Location = New System.Drawing.Point(925, 53)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 31)
        Me.btSearch.TabIndex = 11
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(844, 53)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 31)
        Me.MetroButton1.TabIndex = 10
        Me.MetroButton1.Text = "Vider"
        Me.MetroButton1.UseSelectable = True
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 23
        Me.cmbType.Location = New System.Drawing.Point(613, 25)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(185, 29)
        Me.cmbType.TabIndex = 7
        Me.cmbType.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(474, 30)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Triage par Type AGR"
        '
        'chkDetail
        '
        Me.chkDetail.AutoSize = True
        Me.chkDetail.Location = New System.Drawing.Point(844, 30)
        Me.chkDetail.Name = "chkDetail"
        Me.chkDetail.Size = New System.Drawing.Size(174, 15)
        Me.chkDetail.TabIndex = 4
        Me.chkDetail.Text = "Inclure tous les autres détails"
        Me.chkDetail.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(66, 25)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(142, 29)
        Me.cmbAnnee.TabIndex = 4
        Me.cmbAnnee.UseSelectable = True
        '
        'chkPredefini
        '
        Me.chkPredefini.AutoSize = True
        Me.chkPredefini.Location = New System.Drawing.Point(844, 15)
        Me.chkPredefini.Name = "chkPredefini"
        Me.chkPredefini.Size = New System.Drawing.Size(145, 15)
        Me.chkPredefini.TabIndex = 4
        Me.chkPredefini.Text = "Présentation prédéfinie"
        Me.chkPredefini.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(334, 25)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(132, 29)
        Me.cmbTypeRapport.TabIndex = 3
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(7, 30)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Année"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(278, 65)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "Au"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(7, 65)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "Du"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(220, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type de rapport"
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerLeRecuDeCaisseToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(212, 48)
        '
        'ImprimerLeRecuDeCaisseToolStripMenuItem
        '
        Me.ImprimerLeRecuDeCaisseToolStripMenuItem.Name = "ImprimerLeRecuDeCaisseToolStripMenuItem"
        Me.ImprimerLeRecuDeCaisseToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ImprimerLeRecuDeCaisseToolStripMenuItem.Text = "Imprimer le recu de caisse"
        '
        'ListeRevenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 772)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeRevenu"
        Me.Text = "REVENUS : RAPPORT REVENUS AGR"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkDetail As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPredefini As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ListRevenu As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRapport As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ImprimerLeRecuDeCaisseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
