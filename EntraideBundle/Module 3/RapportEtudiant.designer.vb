<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportEtudiant
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.txtTotalComplet = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotalDette = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.ListEtudians = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckDetail = New MetroFramework.Controls.MetroRadioButton()
        Me.ckPredefini = New MetroFramework.Controls.MetroRadioButton()
        Me.ckGeneration = New MetroFramework.Controls.MetroCheckBox()
        Me.btSearch = New MetroFramework.Controls.MetroButton()
        Me.btClean = New MetroFramework.Controls.MetroButton()
        Me.cmbAu = New MetroFramework.Controls.MetroDateTime()
        Me.cmbDu = New MetroFramework.Controls.MetroDateTime()
        Me.cmbGeneration = New MetroFramework.Controls.MetroComboBox()
        Me.cmbPaiement = New MetroFramework.Controls.MetroComboBox()
        Me.cmbFormation = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelContainer, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1338, 700)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.txtTotalComplet)
        Me.PanelContainer.Controls.Add(Me.MetroLabel10)
        Me.PanelContainer.Controls.Add(Me.txtTotalDette)
        Me.PanelContainer.Controls.Add(Me.MetroLabel9)
        Me.PanelContainer.Controls.Add(Me.txtTotal)
        Me.PanelContainer.Controls.Add(Me.MetroLabel7)
        Me.PanelContainer.Controls.Add(Me.ListEtudians)
        Me.PanelContainer.Controls.Add(Me.MetroButton3)
        Me.PanelContainer.Controls.Add(Me.btnReport)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Location = New System.Drawing.Point(3, 3)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1332, 660)
        Me.PanelContainer.TabIndex = 0
        '
        'txtTotalComplet
        '
        '
        '
        '
        Me.txtTotalComplet.CustomButton.Image = Nothing
        Me.txtTotalComplet.CustomButton.Location = New System.Drawing.Point(47, 2)
        Me.txtTotalComplet.CustomButton.Name = ""
        Me.txtTotalComplet.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotalComplet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalComplet.CustomButton.TabIndex = 1
        Me.txtTotalComplet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalComplet.CustomButton.UseSelectable = True
        Me.txtTotalComplet.CustomButton.Visible = False
        Me.txtTotalComplet.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotalComplet.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotalComplet.Lines = New String() {"0"}
        Me.txtTotalComplet.Location = New System.Drawing.Point(1078, 558)
        Me.txtTotalComplet.MaxLength = 32767
        Me.txtTotalComplet.Name = "txtTotalComplet"
        Me.txtTotalComplet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalComplet.ReadOnly = True
        Me.txtTotalComplet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalComplet.SelectedText = ""
        Me.txtTotalComplet.SelectionLength = 0
        Me.txtTotalComplet.SelectionStart = 0
        Me.txtTotalComplet.ShortcutsEnabled = True
        Me.txtTotalComplet.Size = New System.Drawing.Size(75, 30)
        Me.txtTotalComplet.TabIndex = 4
        Me.txtTotalComplet.Text = "0"
        Me.txtTotalComplet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalComplet.UseSelectable = True
        Me.txtTotalComplet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalComplet.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(773, 564)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(278, 19)
        Me.MetroLabel10.TabIndex = 3
        Me.MetroLabel10.Text = "Total des inscris ayant completé le paiement : "
        '
        'txtTotalDette
        '
        '
        '
        '
        Me.txtTotalDette.CustomButton.Image = Nothing
        Me.txtTotalDette.CustomButton.Location = New System.Drawing.Point(47, 2)
        Me.txtTotalDette.CustomButton.Name = ""
        Me.txtTotalDette.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotalDette.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalDette.CustomButton.TabIndex = 1
        Me.txtTotalDette.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalDette.CustomButton.UseSelectable = True
        Me.txtTotalDette.CustomButton.Visible = False
        Me.txtTotalDette.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotalDette.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotalDette.Lines = New String() {"0"}
        Me.txtTotalDette.Location = New System.Drawing.Point(636, 558)
        Me.txtTotalDette.MaxLength = 32767
        Me.txtTotalDette.Name = "txtTotalDette"
        Me.txtTotalDette.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalDette.ReadOnly = True
        Me.txtTotalDette.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalDette.SelectedText = ""
        Me.txtTotalDette.SelectionLength = 0
        Me.txtTotalDette.SelectionStart = 0
        Me.txtTotalDette.ShortcutsEnabled = True
        Me.txtTotalDette.Size = New System.Drawing.Size(75, 30)
        Me.txtTotalDette.TabIndex = 4
        Me.txtTotalDette.Text = "0"
        Me.txtTotalDette.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalDette.UseSelectable = True
        Me.txtTotalDette.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalDette.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(441, 564)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(175, 19)
        Me.MetroLabel9.TabIndex = 3
        Me.MetroLabel9.Text = "Total des inscris avec dette : "
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.CustomButton.Image = Nothing
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(47, 2)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotal.Lines = New String() {"0"}
        Me.txtTotal.Location = New System.Drawing.Point(326, 558)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.ShortcutsEnabled = True
        Me.txtTotal.Size = New System.Drawing.Size(75, 30)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(180, 564)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel7.TabIndex = 3
        Me.MetroLabel7.Text = "Total des etudiants : "
        '
        'ListEtudians
        '
        Me.ListEtudians.AllowColumnReorder = True
        Me.ListEtudians.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader15, Me.ColumnHeader23})
        Me.ListEtudians.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEtudians.FullRowSelect = True
        Me.ListEtudians.GridLines = True
        Me.ListEtudians.Location = New System.Drawing.Point(3, 157)
        Me.ListEtudians.Name = "ListEtudians"
        Me.ListEtudians.Size = New System.Drawing.Size(1320, 389)
        Me.ListEtudians.TabIndex = 1
        Me.ListEtudians.UseCompatibleStateImageBehavior = False
        Me.ListEtudians.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NOM ETUDIANT"
        Me.ColumnHeader1.Width = 236
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PRENOM"
        Me.ColumnHeader2.Width = 173
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MONTANT A PAYER"
        Me.ColumnHeader3.Width = 153
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DETTE"
        Me.ColumnHeader4.Width = 145
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PAIEMENT PAR"
        Me.ColumnHeader5.Width = 135
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CODE"
        Me.ColumnHeader6.Width = 156
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "TEL 1."
        Me.ColumnHeader8.Width = 130
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TEL. 2"
        Me.ColumnHeader9.Width = 130
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "EMAIL"
        Me.ColumnHeader10.Width = 140
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ADRESSE"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "B.P"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "SEXE"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "NATIONALITE"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "LIEU DE NAISSANCE"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "SITUATION MATRIMONIALE"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "PERSONNE A CONTACTER"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "ADR. PERSONNE A CONTACTER"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "TEL. PERSONNE A CONTACTER"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "FORMATION"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "GENERATION"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "TYPE DE BUSINNESS"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "NIVEAU D'ETUDE"
        '
        'MetroButton3
        '
        Me.MetroButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton3.Location = New System.Drawing.Point(509, 615)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(101, 34)
        Me.MetroButton3.TabIndex = 2
        Me.MetroButton3.Text = "EXPORTER"
        Me.MetroButton3.UseSelectable = True
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.Location = New System.Drawing.Point(616, 615)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(101, 34)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "RARPORT"
        Me.btnReport.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(723, 615)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckDetail)
        Me.GroupBox1.Controls.Add(Me.ckPredefini)
        Me.GroupBox1.Controls.Add(Me.ckGeneration)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.btClean)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.cmbGeneration)
        Me.GroupBox1.Controls.Add(Me.cmbPaiement)
        Me.GroupBox1.Controls.Add(Me.cmbFormation)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1312, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ckDetail
        '
        Me.ckDetail.AutoSize = True
        Me.ckDetail.Location = New System.Drawing.Point(1099, 41)
        Me.ckDetail.Name = "ckDetail"
        Me.ckDetail.Size = New System.Drawing.Size(174, 15)
        Me.ckDetail.TabIndex = 22
        Me.ckDetail.Text = "Inclure tous les autres détails"
        Me.ckDetail.UseSelectable = True
        '
        'ckPredefini
        '
        Me.ckPredefini.AutoSize = True
        Me.ckPredefini.Checked = True
        Me.ckPredefini.Location = New System.Drawing.Point(1099, 19)
        Me.ckPredefini.Name = "ckPredefini"
        Me.ckPredefini.Size = New System.Drawing.Size(145, 15)
        Me.ckPredefini.TabIndex = 21
        Me.ckPredefini.TabStop = True
        Me.ckPredefini.Text = "Présentation prédéfinie"
        Me.ckPredefini.UseSelectable = True
        '
        'ckGeneration
        '
        Me.ckGeneration.AutoSize = True
        Me.ckGeneration.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckGeneration.Location = New System.Drawing.Point(504, 30)
        Me.ckGeneration.Name = "ckGeneration"
        Me.ckGeneration.Size = New System.Drawing.Size(156, 19)
        Me.ckGeneration.TabIndex = 5
        Me.ckGeneration.Text = "Triage par génération"
        Me.ckGeneration.UseSelectable = True
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Location = New System.Drawing.Point(1198, 89)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(78, 36)
        Me.btSearch.TabIndex = 4
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'btClean
        '
        Me.btClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClean.Location = New System.Drawing.Point(1099, 89)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(93, 36)
        Me.btClean.TabIndex = 4
        Me.btClean.Text = "Vider"
        Me.btClean.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(321, 101)
        Me.cmbAu.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(123, 29)
        Me.cmbAu.TabIndex = 2
        '
        'cmbDu
        '
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(161, 101)
        Me.cmbDu.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(123, 29)
        Me.cmbDu.TabIndex = 2
        '
        'cmbGeneration
        '
        Me.cmbGeneration.Enabled = False
        Me.cmbGeneration.FormattingEnabled = True
        Me.cmbGeneration.ItemHeight = 23
        Me.cmbGeneration.Location = New System.Drawing.Point(666, 25)
        Me.cmbGeneration.Name = "cmbGeneration"
        Me.cmbGeneration.Size = New System.Drawing.Size(280, 29)
        Me.cmbGeneration.TabIndex = 1
        Me.cmbGeneration.UseSelectable = True
        '
        'cmbPaiement
        '
        Me.cmbPaiement.FormattingEnabled = True
        Me.cmbPaiement.ItemHeight = 23
        Me.cmbPaiement.Items.AddRange(New Object() {"", "Espece", "Virement", "Cheque"})
        Me.cmbPaiement.Location = New System.Drawing.Point(666, 98)
        Me.cmbPaiement.Name = "cmbPaiement"
        Me.cmbPaiement.Size = New System.Drawing.Size(280, 29)
        Me.cmbPaiement.TabIndex = 1
        Me.cmbPaiement.UseSelectable = True
        '
        'cmbFormation
        '
        Me.cmbFormation.FormattingEnabled = True
        Me.cmbFormation.ItemHeight = 23
        Me.cmbFormation.Location = New System.Drawing.Point(666, 62)
        Me.cmbFormation.Name = "cmbFormation"
        Me.cmbFormation.Size = New System.Drawing.Size(280, 29)
        Me.cmbFormation.TabIndex = 1
        Me.cmbFormation.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(504, 101)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(140, 19)
        Me.MetroLabel8.TabIndex = 0
        Me.MetroLabel8.Text = "Methode de paiement"
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 23
        Me.cmbAnnee.Location = New System.Drawing.Point(161, 58)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(283, 29)
        Me.cmbAnnee.TabIndex = 1
        Me.cmbAnnee.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(504, 67)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "Formation"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(11, 63)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Année"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(290, 104)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Au"
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 23
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(161, 25)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(283, 29)
        Me.cmbTypeRapport.TabIndex = 1
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(11, 107)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Perdiode :"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type de rappport"
        '
        'RapportEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "RapportEtudiant"
        Me.Text = "INSCRIPTION : RAPPORT/LISTE INSCRIPTION"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbAu As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbDu As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbGeneration As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbPaiement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbFormation As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListEtudians As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btClean As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalComplet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalDette As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ckGeneration As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ckDetail As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckPredefini As MetroFramework.Controls.MetroRadioButton
End Class
