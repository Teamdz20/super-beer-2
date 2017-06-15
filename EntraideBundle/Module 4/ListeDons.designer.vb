<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeDons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeDons))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.ListDon = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckDetail = New MetroFramework.Controls.MetroRadioButton()
        Me.ckPredefini = New MetroFramework.Controls.MetroRadioButton()
        Me.ckModePaiement = New MetroFramework.Controls.MetroCheckBox()
        Me.ckTypeDon = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.AU = New MetroFramework.Controls.MetroLabel()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.btVider = New MetroFramework.Controls.MetroButton()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeDon = New MetroFramework.Controls.MetroComboBox()
        Me.cmbModePaiement = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMontantTotal = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalDonneur = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalDon = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.btnExport = New MetroFramework.Controls.MetroButton()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ImprimerLeRecuDeCaisseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.ListDon)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.GroupBox3)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.btnReport)
        Me.PanelContainer.Controls.Add(Me.btnExport)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1237, 653)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'ListDon
        '
        Me.ListDon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListDon.ContextMenuStrip = Me.MetroContextMenu1
        Me.ListDon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDon.FullRowSelect = True
        Me.ListDon.GridLines = True
        Me.ListDon.Location = New System.Drawing.Point(6, 119)
        Me.ListDon.Name = "ListDon"
        Me.ListDon.Size = New System.Drawing.Size(1223, 347)
        Me.ListDon.TabIndex = 0
        Me.ListDon.UseCompatibleStateImageBehavior = False
        Me.ListDon.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CODE"
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TYPE DE DON"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MONTANT RECU"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PAR"
        Me.ColumnHeader4.Width = 170
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NOM DONNEUR"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "RESTRICTION"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CODE REVENU"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "MODE DE RECEPTION"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "MONTANT SOLLICITE"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "N° CHEQUE"
        Me.ColumnHeader11.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ACTIVITE MENEE"
        Me.ColumnHeader12.Width = 200
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "DEPARTEMENT"
        Me.ColumnHeader13.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckDetail)
        Me.GroupBox1.Controls.Add(Me.ckPredefini)
        Me.GroupBox1.Controls.Add(Me.ckModePaiement)
        Me.GroupBox1.Controls.Add(Me.ckTypeDon)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.AU)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btVider)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.cmbTypeDon)
        Me.GroupBox1.Controls.Add(Me.cmbModePaiement)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 110)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche Rapide"
        '
        'ckDetail
        '
        Me.ckDetail.AutoSize = True
        Me.ckDetail.Location = New System.Drawing.Point(951, 44)
        Me.ckDetail.Name = "ckDetail"
        Me.ckDetail.Size = New System.Drawing.Size(174, 15)
        Me.ckDetail.TabIndex = 22
        Me.ckDetail.Text = "Inclure tous les autres détails"
        Me.ckDetail.UseSelectable = True
        '
        'ckPredefini
        '
        Me.ckPredefini.AutoSize = True
        Me.ckPredefini.Location = New System.Drawing.Point(951, 22)
        Me.ckPredefini.Name = "ckPredefini"
        Me.ckPredefini.Size = New System.Drawing.Size(145, 15)
        Me.ckPredefini.TabIndex = 21
        Me.ckPredefini.Text = "Présentation prédéfinie"
        Me.ckPredefini.UseSelectable = True
        '
        'ckModePaiement
        '
        Me.ckModePaiement.AutoSize = True
        Me.ckModePaiement.Location = New System.Drawing.Point(531, 67)
        Me.ckModePaiement.Name = "ckModePaiement"
        Me.ckModePaiement.Size = New System.Drawing.Size(132, 15)
        Me.ckModePaiement.TabIndex = 20
        Me.ckModePaiement.Text = "Mode de paiement : "
        Me.ckModePaiement.UseSelectable = True
        '
        'ckTypeDon
        '
        Me.ckTypeDon.AutoSize = True
        Me.ckTypeDon.Location = New System.Drawing.Point(531, 33)
        Me.ckTypeDon.Name = "ckTypeDon"
        Me.ckTypeDon.Size = New System.Drawing.Size(98, 15)
        Me.ckTypeDon.TabIndex = 20
        Me.ckTypeDon.Text = "Type de don : "
        Me.ckTypeDon.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(289, 69)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(175, 26)
        Me.cmbAu.TabIndex = 19
        '
        'cmbDu
        '
        Me.cmbDu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(47, 71)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(163, 24)
        Me.cmbDu.TabIndex = 18
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 74)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel4.TabIndex = 17
        Me.MetroLabel4.Text = "Du"
        '
        'AU
        '
        Me.AU.AutoSize = True
        Me.AU.Location = New System.Drawing.Point(258, 73)
        Me.AU.Name = "AU"
        Me.AU.Size = New System.Drawing.Size(25, 19)
        Me.AU.TabIndex = 17
        Me.AU.Text = "Au"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(1057, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 32)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseSelectable = True
        '
        'btVider
        '
        Me.btVider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVider.Location = New System.Drawing.Point(951, 69)
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
        Me.cmbAnnee.Location = New System.Drawing.Point(93, 22)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(117, 29)
        Me.cmbAnnee.TabIndex = 11
        Me.cmbAnnee.UseSelectable = True
        '
        'cmbTypeDon
        '
        Me.cmbTypeDon.Enabled = False
        Me.cmbTypeDon.FormattingEnabled = True
        Me.cmbTypeDon.ItemHeight = 23
        Me.cmbTypeDon.Items.AddRange(New Object() {"", "MATERIEL", "ARGENT"})
        Me.cmbTypeDon.Location = New System.Drawing.Point(673, 26)
        Me.cmbTypeDon.Name = "cmbTypeDon"
        Me.cmbTypeDon.Size = New System.Drawing.Size(222, 29)
        Me.cmbTypeDon.TabIndex = 9
        Me.cmbTypeDon.UseSelectable = True
        '
        'cmbModePaiement
        '
        Me.cmbModePaiement.Enabled = False
        Me.cmbModePaiement.FormattingEnabled = True
        Me.cmbModePaiement.ItemHeight = 23
        Me.cmbModePaiement.Items.AddRange(New Object() {"", "Virement", "Cheque", "Espece"})
        Me.cmbModePaiement.Location = New System.Drawing.Point(673, 60)
        Me.cmbModePaiement.Name = "cmbModePaiement"
        Me.cmbModePaiement.Size = New System.Drawing.Size(222, 29)
        Me.cmbModePaiement.TabIndex = 8
        Me.cmbModePaiement.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(336, 22)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(128, 29)
        Me.cmbTypeRapport.TabIndex = 6
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(34, 27)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Année :"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(215, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type de Rapport :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMontantTotal)
        Me.GroupBox3.Controls.Add(Me.txtTotalDonneur)
        Me.GroupBox3.Controls.Add(Me.txtTotalDon)
        Me.GroupBox3.Controls.Add(Me.MetroLabel9)
        Me.GroupBox3.Controls.Add(Me.MetroLabel8)
        Me.GroupBox3.Controls.Add(Me.MetroLabel7)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 469)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1220, 134)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'txtMontantTotal
        '
        '
        '
        '
        Me.txtMontantTotal.CustomButton.Image = Nothing
        Me.txtMontantTotal.CustomButton.Location = New System.Drawing.Point(185, 2)
        Me.txtMontantTotal.CustomButton.Name = ""
        Me.txtMontantTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantTotal.CustomButton.TabIndex = 1
        Me.txtMontantTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantTotal.CustomButton.UseSelectable = True
        Me.txtMontantTotal.CustomButton.Visible = False
        Me.txtMontantTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtMontantTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtMontantTotal.Lines = New String(-1) {}
        Me.txtMontantTotal.Location = New System.Drawing.Point(626, 87)
        Me.txtMontantTotal.MaxLength = 32767
        Me.txtMontantTotal.Name = "txtMontantTotal"
        Me.txtMontantTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantTotal.ReadOnly = True
        Me.txtMontantTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantTotal.SelectedText = ""
        Me.txtMontantTotal.SelectionLength = 0
        Me.txtMontantTotal.SelectionStart = 0
        Me.txtMontantTotal.ShortcutsEnabled = True
        Me.txtMontantTotal.Size = New System.Drawing.Size(213, 30)
        Me.txtMontantTotal.TabIndex = 5
        Me.txtMontantTotal.UseSelectable = True
        Me.txtMontantTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTotalDonneur
        '
        '
        '
        '
        Me.txtTotalDonneur.CustomButton.Image = Nothing
        Me.txtTotalDonneur.CustomButton.Location = New System.Drawing.Point(185, 2)
        Me.txtTotalDonneur.CustomButton.Name = ""
        Me.txtTotalDonneur.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotalDonneur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalDonneur.CustomButton.TabIndex = 1
        Me.txtTotalDonneur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalDonneur.CustomButton.UseSelectable = True
        Me.txtTotalDonneur.CustomButton.Visible = False
        Me.txtTotalDonneur.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotalDonneur.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotalDonneur.Lines = New String(-1) {}
        Me.txtTotalDonneur.Location = New System.Drawing.Point(626, 52)
        Me.txtTotalDonneur.MaxLength = 32767
        Me.txtTotalDonneur.Name = "txtTotalDonneur"
        Me.txtTotalDonneur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDonneur.ReadOnly = True
        Me.txtTotalDonneur.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalDonneur.SelectedText = ""
        Me.txtTotalDonneur.SelectionLength = 0
        Me.txtTotalDonneur.SelectionStart = 0
        Me.txtTotalDonneur.ShortcutsEnabled = True
        Me.txtTotalDonneur.Size = New System.Drawing.Size(213, 30)
        Me.txtTotalDonneur.TabIndex = 4
        Me.txtTotalDonneur.UseSelectable = True
        Me.txtTotalDonneur.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalDonneur.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTotalDon
        '
        '
        '
        '
        Me.txtTotalDon.CustomButton.Image = Nothing
        Me.txtTotalDon.CustomButton.Location = New System.Drawing.Point(185, 2)
        Me.txtTotalDon.CustomButton.Name = ""
        Me.txtTotalDon.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotalDon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalDon.CustomButton.TabIndex = 1
        Me.txtTotalDon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalDon.CustomButton.UseSelectable = True
        Me.txtTotalDon.CustomButton.Visible = False
        Me.txtTotalDon.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotalDon.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotalDon.Lines = New String() {"      "}
        Me.txtTotalDon.Location = New System.Drawing.Point(626, 12)
        Me.txtTotalDon.MaxLength = 32767
        Me.txtTotalDon.Name = "txtTotalDon"
        Me.txtTotalDon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDon.ReadOnly = True
        Me.txtTotalDon.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalDon.SelectedText = ""
        Me.txtTotalDon.SelectionLength = 0
        Me.txtTotalDon.SelectionStart = 0
        Me.txtTotalDon.ShortcutsEnabled = True
        Me.txtTotalDon.Size = New System.Drawing.Size(213, 30)
        Me.txtTotalDon.TabIndex = 3
        Me.txtTotalDon.Text = "      "
        Me.txtTotalDon.UseSelectable = True
        Me.txtTotalDon.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalDon.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(382, 93)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(204, 19)
        Me.MetroLabel9.TabIndex = 2
        Me.MetroLabel9.Text = "montant total des dons collectés :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(382, 18)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel8.TabIndex = 1
        Me.MetroLabel8.Text = "Total des dons collectés :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(382, 58)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(131, 19)
        Me.MetroLabel7.TabIndex = 0
        Me.MetroLabel7.Text = "Total des donneurs : "
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(687, 609)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 33)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Fermer"
        Me.btnClose.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Location = New System.Drawing.Point(556, 609)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(125, 33)
        Me.btnReport.TabIndex = 20
        Me.btnReport.Text = "Rapport"
        Me.btnReport.UseSelectable = True
        '
        'btnExport
        '
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.Location = New System.Drawing.Point(425, 609)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(125, 33)
        Me.btnExport.TabIndex = 19
        Me.btnExport.Text = "Exporter"
        Me.btnExport.UseSelectable = True
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
        'ListeDons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 739)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeDons"
        Me.Text = " DON : RAPPORT / LISTE DES DONS"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMontantTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotalDonneur As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotalDon As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents btnExport As MetroFramework.Controls.MetroButton
    Friend WithEvents ListDon As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btVider As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeDon As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbModePaiement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents AU As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckModePaiement As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckTypeDon As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckDetail As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckPredefini As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ImprimerLeRecuDeCaisseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
