<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MajEmploye
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MajEmploye))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.PanelContainer = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.ckDepartement = New System.Windows.Forms.CheckBox()
        Me.ckNom = New System.Windows.Forms.CheckBox()
        Me.ckCode = New System.Windows.Forms.CheckBox()
        Me.cmbRechDep = New System.Windows.Forms.ComboBox()
        Me.txtRechCode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel45 = New MetroFramework.Controls.MetroLabel()
        Me.txtRechNom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel49 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel46 = New MetroFramework.Controls.MetroLabel()
        Me.ListEmploye = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupContactUrgence = New System.Windows.Forms.GroupBox()
        Me.txtEmailUrgence = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.txtTelUrgence = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.txtAdresseUrgence = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.txtNomUrgence = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.GroupInfoGeneral = New System.Windows.Forms.GroupBox()
        Me.txtDateNaiss = New MetroFramework.Controls.MetroDateTime()
        Me.cmbSituationMatri = New MetroFramework.Controls.MetroComboBox()
        Me.cmbSexe = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtNationalite = New MetroFramework.Controls.MetroTextBox()
        Me.txtLieuNaiss = New MetroFramework.Controls.MetroTextBox()
        Me.txtNbEnfant = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtBp = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAdresse = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrenom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBoxSalaire = New System.Windows.Forms.GroupBox()
        Me.cmbTermePaiement = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.txtSalaireMensuel = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel40 = New MetroFramework.Controls.MetroLabel()
        Me.txtNbJourTravail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel39 = New MetroFramework.Controls.MetroLabel()
        Me.txtTauxSalaire = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel38 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBoxAutreInfo = New System.Windows.Forms.GroupBox()
        Me.cmbFormation = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDelis = New MetroFramework.Controls.MetroComboBox()
        Me.cmbReligion = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtEcole = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.txtDiplome = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.txtNiveauEt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.txtTypeFormation = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.txtDetailDelis = New MetroFramework.Controls.MetroTextBox()
        Me.LabelDelis = New MetroFramework.Controls.MetroLabel()
        Me.txtAutreRelion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBoxCompetance = New System.Windows.Forms.GroupBox()
        Me.MetroLabel41 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel36 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel42 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel43 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoteExperience = New MetroFramework.Controls.MetroTextBox()
        Me.txtAutreComp = New MetroFramework.Controls.MetroTextBox()
        Me.txtInformation = New MetroFramework.Controls.MetroTextBox()
        Me.txtCompEn = New MetroFramework.Controls.MetroTextBox()
        Me.txtCompFr = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel44 = New MetroFramework.Controls.MetroLabel()
        Me.GroupContrat = New System.Windows.Forms.GroupBox()
        Me.txtFinContrat = New MetroFramework.Controls.MetroDateTime()
        Me.txtDateDebutContrat = New MetroFramework.Controls.MetroDateTime()
        Me.txtNbHeure = New MetroFramework.Controls.MetroTextBox()
        Me.txtDureeContrat = New MetroFramework.Controls.MetroTextBox()
        Me.cmbUniteDuree = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.cmbSuperviseur = New MetroFramework.Controls.MetroComboBox()
        Me.cmbClassification = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.cmbPoste = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.cmbDepartement = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.PanelBottom = New MetroFramework.Controls.MetroPanel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()
        Me.GroupContactUrgence.SuspendLayout()
        Me.GroupInfoGeneral.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.GroupBoxSalaire.SuspendLayout()
        Me.GroupBoxAutreInfo.SuspendLayout()
        Me.GroupBoxCompetance.SuspendLayout()
        Me.GroupContrat.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBottom, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1271, 676)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.50661!))
        Me.TableLayoutPanel2.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(29, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.19608!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1209, 623)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.PanelContainer)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1203, 617)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.MetroTabPage1)
        Me.PanelContainer.Controls.Add(Me.MetroTabPage2)
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.SelectedIndex = 0
        Me.PanelContainer.Size = New System.Drawing.Size(1200, 617)
        Me.PanelContainer.TabIndex = 4
        Me.PanelContainer.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.GroupBox7)
        Me.MetroTabPage1.Controls.Add(Me.ListEmploye)
        Me.MetroTabPage1.Controls.Add(Me.GroupContactUrgence)
        Me.MetroTabPage1.Controls.Add(Me.GroupInfoGeneral)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1192, 575)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Recherche / Informations et contacts  "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.btnSearch)
        Me.GroupBox7.Controls.Add(Me.ckDepartement)
        Me.GroupBox7.Controls.Add(Me.ckNom)
        Me.GroupBox7.Controls.Add(Me.ckCode)
        Me.GroupBox7.Controls.Add(Me.cmbRechDep)
        Me.GroupBox7.Controls.Add(Me.txtRechCode)
        Me.GroupBox7.Controls.Add(Me.MetroLabel45)
        Me.GroupBox7.Controls.Add(Me.txtRechNom)
        Me.GroupBox7.Controls.Add(Me.MetroLabel49)
        Me.GroupBox7.Controls.Add(Me.MetroLabel46)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1186, 120)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Recherche Rapide"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(812, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 37)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "RECHERCHER"
        Me.btnSearch.UseSelectable = True
        '
        'ckDepartement
        '
        Me.ckDepartement.AutoSize = True
        Me.ckDepartement.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckDepartement.Location = New System.Drawing.Point(30, 83)
        Me.ckDepartement.Name = "ckDepartement"
        Me.ckDepartement.Size = New System.Drawing.Size(163, 21)
        Me.ckDepartement.TabIndex = 3
        Me.ckDepartement.Text = "Filtrer par departement"
        Me.ckDepartement.UseVisualStyleBackColor = True
        '
        'ckNom
        '
        Me.ckNom.AutoSize = True
        Me.ckNom.Checked = True
        Me.ckNom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckNom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckNom.Location = New System.Drawing.Point(31, 57)
        Me.ckNom.Name = "ckNom"
        Me.ckNom.Size = New System.Drawing.Size(114, 21)
        Me.ckNom.TabIndex = 3
        Me.ckNom.Text = "Filtrer par nom"
        Me.ckNom.UseVisualStyleBackColor = True
        '
        'ckCode
        '
        Me.ckCode.AutoSize = True
        Me.ckCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckCode.Location = New System.Drawing.Point(31, 31)
        Me.ckCode.Name = "ckCode"
        Me.ckCode.Size = New System.Drawing.Size(117, 21)
        Me.ckCode.TabIndex = 3
        Me.ckCode.Text = "Filtrer par code"
        Me.ckCode.UseVisualStyleBackColor = True
        '
        'cmbRechDep
        '
        Me.cmbRechDep.Enabled = False
        Me.cmbRechDep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRechDep.FormattingEnabled = True
        Me.cmbRechDep.Location = New System.Drawing.Point(437, 80)
        Me.cmbRechDep.Name = "cmbRechDep"
        Me.cmbRechDep.Size = New System.Drawing.Size(322, 29)
        Me.cmbRechDep.TabIndex = 2
        '
        'txtRechCode
        '
        '
        '
        '
        Me.txtRechCode.CustomButton.Image = Nothing
        Me.txtRechCode.CustomButton.Location = New System.Drawing.Point(300, 1)
        Me.txtRechCode.CustomButton.Name = ""
        Me.txtRechCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRechCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRechCode.CustomButton.TabIndex = 1
        Me.txtRechCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRechCode.CustomButton.UseSelectable = True
        Me.txtRechCode.CustomButton.Visible = False
        Me.txtRechCode.Enabled = False
        Me.txtRechCode.Lines = New String(-1) {}
        Me.txtRechCode.Location = New System.Drawing.Point(437, 20)
        Me.txtRechCode.MaxLength = 32767
        Me.txtRechCode.Name = "txtRechCode"
        Me.txtRechCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRechCode.PromptText = "ex: EMP0001"
        Me.txtRechCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRechCode.SelectedText = ""
        Me.txtRechCode.SelectionLength = 0
        Me.txtRechCode.SelectionStart = 0
        Me.txtRechCode.ShortcutsEnabled = True
        Me.txtRechCode.Size = New System.Drawing.Size(322, 23)
        Me.txtRechCode.TabIndex = 1
        Me.txtRechCode.UseSelectable = True
        Me.txtRechCode.WaterMark = "ex: EMP0001"
        Me.txtRechCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRechCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel45
        '
        Me.MetroLabel45.AutoSize = True
        Me.MetroLabel45.Location = New System.Drawing.Point(317, 24)
        Me.MetroLabel45.Name = "MetroLabel45"
        Me.MetroLabel45.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel45.TabIndex = 0
        Me.MetroLabel45.Text = "Code : "
        '
        'txtRechNom
        '
        '
        '
        '
        Me.txtRechNom.CustomButton.Image = Nothing
        Me.txtRechNom.CustomButton.Location = New System.Drawing.Point(300, 1)
        Me.txtRechNom.CustomButton.Name = ""
        Me.txtRechNom.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRechNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRechNom.CustomButton.TabIndex = 1
        Me.txtRechNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRechNom.CustomButton.UseSelectable = True
        Me.txtRechNom.CustomButton.Visible = False
        Me.txtRechNom.Lines = New String(-1) {}
        Me.txtRechNom.Location = New System.Drawing.Point(437, 50)
        Me.txtRechNom.MaxLength = 32767
        Me.txtRechNom.Name = "txtRechNom"
        Me.txtRechNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRechNom.PromptText = "ex: John Doe"
        Me.txtRechNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRechNom.SelectedText = ""
        Me.txtRechNom.SelectionLength = 0
        Me.txtRechNom.SelectionStart = 0
        Me.txtRechNom.ShortcutsEnabled = True
        Me.txtRechNom.Size = New System.Drawing.Size(322, 23)
        Me.txtRechNom.TabIndex = 1
        Me.txtRechNom.UseSelectable = True
        Me.txtRechNom.WaterMark = "ex: John Doe"
        Me.txtRechNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRechNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel49
        '
        Me.MetroLabel49.AutoSize = True
        Me.MetroLabel49.Location = New System.Drawing.Point(317, 90)
        Me.MetroLabel49.Name = "MetroLabel49"
        Me.MetroLabel49.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel49.TabIndex = 0
        Me.MetroLabel49.Text = "Departement"
        '
        'MetroLabel46
        '
        Me.MetroLabel46.AutoSize = True
        Me.MetroLabel46.Location = New System.Drawing.Point(317, 57)
        Me.MetroLabel46.Name = "MetroLabel46"
        Me.MetroLabel46.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel46.TabIndex = 0
        Me.MetroLabel46.Text = "Nom / Prenom : "
        '
        'ListEmploye
        '
        Me.ListEmploye.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListEmploye.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.ListEmploye.ContextMenuStrip = Me.MetroContextMenu1
        Me.ListEmploye.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEmploye.FullRowSelect = True
        Me.ListEmploye.GridLines = True
        Me.ListEmploye.Location = New System.Drawing.Point(3, 126)
        Me.ListEmploye.Name = "ListEmploye"
        Me.ListEmploye.Size = New System.Drawing.Size(1186, 168)
        Me.ListEmploye.TabIndex = 11
        Me.ListEmploye.UseCompatibleStateImageBehavior = False
        Me.ListEmploye.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NOM"
        Me.ColumnHeader1.Width = 214
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PRENOM"
        Me.ColumnHeader2.Width = 207
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DEPARTEMENT"
        Me.ColumnHeader3.Width = 227
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "EMAIL"
        Me.ColumnHeader4.Width = 193
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DEBUT CONTRAT"
        Me.ColumnHeader5.Width = 170
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "FIN CONTRAT"
        Me.ColumnHeader6.Width = 165
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "index"
        Me.ColumnHeader8.Width = 0
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditerToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(105, 26)
        '
        'EditerToolStripMenuItem
        '
        Me.EditerToolStripMenuItem.Name = "EditerToolStripMenuItem"
        Me.EditerToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditerToolStripMenuItem.Text = "Editer"
        '
        'GroupContactUrgence
        '
        Me.GroupContactUrgence.BackColor = System.Drawing.Color.Transparent
        Me.GroupContactUrgence.Controls.Add(Me.txtEmailUrgence)
        Me.GroupContactUrgence.Controls.Add(Me.MetroLabel28)
        Me.GroupContactUrgence.Controls.Add(Me.txtTelUrgence)
        Me.GroupContactUrgence.Controls.Add(Me.MetroLabel29)
        Me.GroupContactUrgence.Controls.Add(Me.txtAdresseUrgence)
        Me.GroupContactUrgence.Controls.Add(Me.MetroLabel30)
        Me.GroupContactUrgence.Controls.Add(Me.txtNomUrgence)
        Me.GroupContactUrgence.Controls.Add(Me.MetroLabel31)
        Me.GroupContactUrgence.Enabled = False
        Me.GroupContactUrgence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContactUrgence.Location = New System.Drawing.Point(840, 295)
        Me.GroupContactUrgence.Name = "GroupContactUrgence"
        Me.GroupContactUrgence.Size = New System.Drawing.Size(349, 248)
        Me.GroupContactUrgence.TabIndex = 10
        Me.GroupContactUrgence.TabStop = False
        Me.GroupContactUrgence.Text = "Contact urgence"
        '
        'txtEmailUrgence
        '
        '
        '
        '
        Me.txtEmailUrgence.CustomButton.Image = Nothing
        Me.txtEmailUrgence.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtEmailUrgence.CustomButton.Name = ""
        Me.txtEmailUrgence.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailUrgence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailUrgence.CustomButton.TabIndex = 1
        Me.txtEmailUrgence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailUrgence.CustomButton.UseSelectable = True
        Me.txtEmailUrgence.CustomButton.Visible = False
        Me.txtEmailUrgence.Lines = New String(-1) {}
        Me.txtEmailUrgence.Location = New System.Drawing.Point(82, 164)
        Me.txtEmailUrgence.MaxLength = 32767
        Me.txtEmailUrgence.Name = "txtEmailUrgence"
        Me.txtEmailUrgence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailUrgence.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailUrgence.SelectedText = ""
        Me.txtEmailUrgence.SelectionLength = 0
        Me.txtEmailUrgence.SelectionStart = 0
        Me.txtEmailUrgence.ShortcutsEnabled = True
        Me.txtEmailUrgence.Size = New System.Drawing.Size(251, 23)
        Me.txtEmailUrgence.TabIndex = 1
        Me.txtEmailUrgence.UseSelectable = True
        Me.txtEmailUrgence.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailUrgence.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.Location = New System.Drawing.Point(13, 169)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel28.TabIndex = 0
        Me.MetroLabel28.Text = "Email :"
        '
        'txtTelUrgence
        '
        '
        '
        '
        Me.txtTelUrgence.CustomButton.Image = Nothing
        Me.txtTelUrgence.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtTelUrgence.CustomButton.Name = ""
        Me.txtTelUrgence.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelUrgence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelUrgence.CustomButton.TabIndex = 1
        Me.txtTelUrgence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelUrgence.CustomButton.UseSelectable = True
        Me.txtTelUrgence.CustomButton.Visible = False
        Me.txtTelUrgence.Lines = New String(-1) {}
        Me.txtTelUrgence.Location = New System.Drawing.Point(82, 134)
        Me.txtTelUrgence.MaxLength = 32767
        Me.txtTelUrgence.Name = "txtTelUrgence"
        Me.txtTelUrgence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelUrgence.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelUrgence.SelectedText = ""
        Me.txtTelUrgence.SelectionLength = 0
        Me.txtTelUrgence.SelectionStart = 0
        Me.txtTelUrgence.ShortcutsEnabled = True
        Me.txtTelUrgence.Size = New System.Drawing.Size(251, 23)
        Me.txtTelUrgence.TabIndex = 1
        Me.txtTelUrgence.UseSelectable = True
        Me.txtTelUrgence.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelUrgence.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.Location = New System.Drawing.Point(13, 138)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel29.TabIndex = 0
        Me.MetroLabel29.Text = "Tel 1 :"
        '
        'txtAdresseUrgence
        '
        '
        '
        '
        Me.txtAdresseUrgence.CustomButton.Image = Nothing
        Me.txtAdresseUrgence.CustomButton.Location = New System.Drawing.Point(217, 2)
        Me.txtAdresseUrgence.CustomButton.Name = ""
        Me.txtAdresseUrgence.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtAdresseUrgence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresseUrgence.CustomButton.TabIndex = 1
        Me.txtAdresseUrgence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresseUrgence.CustomButton.UseSelectable = True
        Me.txtAdresseUrgence.CustomButton.Visible = False
        Me.txtAdresseUrgence.Lines = New String(-1) {}
        Me.txtAdresseUrgence.Location = New System.Drawing.Point(82, 92)
        Me.txtAdresseUrgence.MaxLength = 32767
        Me.txtAdresseUrgence.Multiline = True
        Me.txtAdresseUrgence.Name = "txtAdresseUrgence"
        Me.txtAdresseUrgence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresseUrgence.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresseUrgence.SelectedText = ""
        Me.txtAdresseUrgence.SelectionLength = 0
        Me.txtAdresseUrgence.SelectionStart = 0
        Me.txtAdresseUrgence.ShortcutsEnabled = True
        Me.txtAdresseUrgence.Size = New System.Drawing.Size(251, 36)
        Me.txtAdresseUrgence.TabIndex = 1
        Me.txtAdresseUrgence.UseSelectable = True
        Me.txtAdresseUrgence.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresseUrgence.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(13, 97)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel30.TabIndex = 0
        Me.MetroLabel30.Text = "Adresse : "
        '
        'txtNomUrgence
        '
        '
        '
        '
        Me.txtNomUrgence.CustomButton.Image = Nothing
        Me.txtNomUrgence.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtNomUrgence.CustomButton.Name = ""
        Me.txtNomUrgence.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNomUrgence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNomUrgence.CustomButton.TabIndex = 1
        Me.txtNomUrgence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNomUrgence.CustomButton.UseSelectable = True
        Me.txtNomUrgence.CustomButton.Visible = False
        Me.txtNomUrgence.Lines = New String(-1) {}
        Me.txtNomUrgence.Location = New System.Drawing.Point(82, 62)
        Me.txtNomUrgence.MaxLength = 32767
        Me.txtNomUrgence.Name = "txtNomUrgence"
        Me.txtNomUrgence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomUrgence.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNomUrgence.SelectedText = ""
        Me.txtNomUrgence.SelectionLength = 0
        Me.txtNomUrgence.SelectionStart = 0
        Me.txtNomUrgence.ShortcutsEnabled = True
        Me.txtNomUrgence.Size = New System.Drawing.Size(251, 23)
        Me.txtNomUrgence.TabIndex = 1
        Me.txtNomUrgence.UseSelectable = True
        Me.txtNomUrgence.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNomUrgence.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.Location = New System.Drawing.Point(13, 66)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel31.TabIndex = 0
        Me.MetroLabel31.Text = "Nom : "
        '
        'GroupInfoGeneral
        '
        Me.GroupInfoGeneral.BackColor = System.Drawing.Color.Transparent
        Me.GroupInfoGeneral.Controls.Add(Me.txtDateNaiss)
        Me.GroupInfoGeneral.Controls.Add(Me.cmbSituationMatri)
        Me.GroupInfoGeneral.Controls.Add(Me.cmbSexe)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel4)
        Me.GroupInfoGeneral.Controls.Add(Me.txtNationalite)
        Me.GroupInfoGeneral.Controls.Add(Me.txtLieuNaiss)
        Me.GroupInfoGeneral.Controls.Add(Me.txtNbEnfant)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel8)
        Me.GroupInfoGeneral.Controls.Add(Me.txtEmail)
        Me.GroupInfoGeneral.Controls.Add(Me.txtPhone2)
        Me.GroupInfoGeneral.Controls.Add(Me.txtBp)
        Me.GroupInfoGeneral.Controls.Add(Me.txtPhone1)
        Me.GroupInfoGeneral.Controls.Add(Me.txtAdresse)
        Me.GroupInfoGeneral.Controls.Add(Me.txtPrenom)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel13)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel7)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel12)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel6)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel10)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel11)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel5)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel9)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel3)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel2)
        Me.GroupInfoGeneral.Controls.Add(Me.txtNom)
        Me.GroupInfoGeneral.Controls.Add(Me.MetroLabel1)
        Me.GroupInfoGeneral.Enabled = False
        Me.GroupInfoGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupInfoGeneral.Location = New System.Drawing.Point(3, 295)
        Me.GroupInfoGeneral.Name = "GroupInfoGeneral"
        Me.GroupInfoGeneral.Size = New System.Drawing.Size(821, 251)
        Me.GroupInfoGeneral.TabIndex = 2
        Me.GroupInfoGeneral.TabStop = False
        Me.GroupInfoGeneral.Text = "Info Generale"
        '
        'txtDateNaiss
        '
        Me.txtDateNaiss.Location = New System.Drawing.Point(150, 180)
        Me.txtDateNaiss.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDateNaiss.Name = "txtDateNaiss"
        Me.txtDateNaiss.Size = New System.Drawing.Size(277, 29)
        Me.txtDateNaiss.TabIndex = 3
        '
        'cmbSituationMatri
        '
        Me.cmbSituationMatri.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSituationMatri.FormattingEnabled = True
        Me.cmbSituationMatri.ItemHeight = 19
        Me.cmbSituationMatri.Items.AddRange(New Object() {"Celibataire", "Marier"})
        Me.cmbSituationMatri.Location = New System.Drawing.Point(150, 116)
        Me.cmbSituationMatri.Name = "cmbSituationMatri"
        Me.cmbSituationMatri.Size = New System.Drawing.Size(277, 25)
        Me.cmbSituationMatri.TabIndex = 4
        Me.cmbSituationMatri.UseSelectable = True
        '
        'cmbSexe
        '
        Me.cmbSexe.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSexe.FormattingEnabled = True
        Me.cmbSexe.ItemHeight = 19
        Me.cmbSexe.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexe.Location = New System.Drawing.Point(150, 83)
        Me.cmbSexe.Name = "cmbSexe"
        Me.cmbSexe.Size = New System.Drawing.Size(277, 25)
        Me.cmbSexe.TabIndex = 3
        Me.cmbSexe.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 122)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Situation matri. : "
        '
        'txtNationalite
        '
        '
        '
        '
        Me.txtNationalite.CustomButton.Image = Nothing
        Me.txtNationalite.CustomButton.Location = New System.Drawing.Point(235, 1)
        Me.txtNationalite.CustomButton.Name = ""
        Me.txtNationalite.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNationalite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNationalite.CustomButton.TabIndex = 1
        Me.txtNationalite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNationalite.CustomButton.UseSelectable = True
        Me.txtNationalite.CustomButton.Visible = False
        Me.txtNationalite.Lines = New String(-1) {}
        Me.txtNationalite.Location = New System.Drawing.Point(552, 22)
        Me.txtNationalite.MaxLength = 32767
        Me.txtNationalite.Name = "txtNationalite"
        Me.txtNationalite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNationalite.PromptText = "Congolaise"
        Me.txtNationalite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNationalite.SelectedText = ""
        Me.txtNationalite.SelectionLength = 0
        Me.txtNationalite.SelectionStart = 0
        Me.txtNationalite.ShortcutsEnabled = True
        Me.txtNationalite.Size = New System.Drawing.Size(257, 23)
        Me.txtNationalite.TabIndex = 1
        Me.txtNationalite.UseSelectable = True
        Me.txtNationalite.WaterMark = "Congolaise"
        Me.txtNationalite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNationalite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLieuNaiss
        '
        '
        '
        '
        Me.txtLieuNaiss.CustomButton.Image = Nothing
        Me.txtLieuNaiss.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.txtLieuNaiss.CustomButton.Name = ""
        Me.txtLieuNaiss.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLieuNaiss.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLieuNaiss.CustomButton.TabIndex = 1
        Me.txtLieuNaiss.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLieuNaiss.CustomButton.UseSelectable = True
        Me.txtLieuNaiss.CustomButton.Visible = False
        Me.txtLieuNaiss.Lines = New String(-1) {}
        Me.txtLieuNaiss.Location = New System.Drawing.Point(150, 217)
        Me.txtLieuNaiss.MaxLength = 32767
        Me.txtLieuNaiss.Name = "txtLieuNaiss"
        Me.txtLieuNaiss.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLieuNaiss.PromptText = "Saisissez le lieu de naissance...."
        Me.txtLieuNaiss.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLieuNaiss.SelectedText = ""
        Me.txtLieuNaiss.SelectionLength = 0
        Me.txtLieuNaiss.SelectionStart = 0
        Me.txtLieuNaiss.ShortcutsEnabled = True
        Me.txtLieuNaiss.Size = New System.Drawing.Size(277, 23)
        Me.txtLieuNaiss.TabIndex = 1
        Me.txtLieuNaiss.UseSelectable = True
        Me.txtLieuNaiss.WaterMark = "Saisissez le lieu de naissance...."
        Me.txtLieuNaiss.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLieuNaiss.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNbEnfant
        '
        '
        '
        '
        Me.txtNbEnfant.CustomButton.Image = Nothing
        Me.txtNbEnfant.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.txtNbEnfant.CustomButton.Name = ""
        Me.txtNbEnfant.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNbEnfant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbEnfant.CustomButton.TabIndex = 1
        Me.txtNbEnfant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbEnfant.CustomButton.UseSelectable = True
        Me.txtNbEnfant.CustomButton.Visible = False
        Me.txtNbEnfant.Lines = New String(-1) {}
        Me.txtNbEnfant.Location = New System.Drawing.Point(150, 149)
        Me.txtNbEnfant.MaxLength = 32767
        Me.txtNbEnfant.Name = "txtNbEnfant"
        Me.txtNbEnfant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbEnfant.PromptText = "Saisissez le nombre d'enfant...."
        Me.txtNbEnfant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbEnfant.SelectedText = ""
        Me.txtNbEnfant.SelectionLength = 0
        Me.txtNbEnfant.SelectionStart = 0
        Me.txtNbEnfant.ShortcutsEnabled = True
        Me.txtNbEnfant.Size = New System.Drawing.Size(277, 23)
        Me.txtNbEnfant.TabIndex = 1
        Me.txtNbEnfant.UseSelectable = True
        Me.txtNbEnfant.WaterMark = "Saisissez le nombre d'enfant...."
        Me.txtNbEnfant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbEnfant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(450, 26)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel8.TabIndex = 0
        Me.MetroLabel8.Text = "Nationnalite : "
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(235, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(552, 172)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(257, 23)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone2
        '
        '
        '
        '
        Me.txtPhone2.CustomButton.Image = Nothing
        Me.txtPhone2.CustomButton.Location = New System.Drawing.Point(235, 1)
        Me.txtPhone2.CustomButton.Name = ""
        Me.txtPhone2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone2.CustomButton.TabIndex = 1
        Me.txtPhone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone2.CustomButton.UseSelectable = True
        Me.txtPhone2.CustomButton.Visible = False
        Me.txtPhone2.Lines = New String(-1) {}
        Me.txtPhone2.Location = New System.Drawing.Point(552, 142)
        Me.txtPhone2.MaxLength = 32767
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone2.SelectedText = ""
        Me.txtPhone2.SelectionLength = 0
        Me.txtPhone2.SelectionStart = 0
        Me.txtPhone2.ShortcutsEnabled = True
        Me.txtPhone2.Size = New System.Drawing.Size(257, 23)
        Me.txtPhone2.TabIndex = 1
        Me.txtPhone2.UseSelectable = True
        Me.txtPhone2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBp
        '
        '
        '
        '
        Me.txtBp.CustomButton.Image = Nothing
        Me.txtBp.CustomButton.Location = New System.Drawing.Point(235, 1)
        Me.txtBp.CustomButton.Name = ""
        Me.txtBp.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBp.CustomButton.TabIndex = 1
        Me.txtBp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBp.CustomButton.UseSelectable = True
        Me.txtBp.CustomButton.Visible = False
        Me.txtBp.Lines = New String(-1) {}
        Me.txtBp.Location = New System.Drawing.Point(552, 82)
        Me.txtBp.MaxLength = 32767
        Me.txtBp.Name = "txtBp"
        Me.txtBp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBp.SelectedText = ""
        Me.txtBp.SelectionLength = 0
        Me.txtBp.SelectionStart = 0
        Me.txtBp.ShortcutsEnabled = True
        Me.txtBp.Size = New System.Drawing.Size(257, 23)
        Me.txtBp.TabIndex = 1
        Me.txtBp.UseSelectable = True
        Me.txtBp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone1
        '
        '
        '
        '
        Me.txtPhone1.CustomButton.Image = Nothing
        Me.txtPhone1.CustomButton.Location = New System.Drawing.Point(235, 1)
        Me.txtPhone1.CustomButton.Name = ""
        Me.txtPhone1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhone1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone1.CustomButton.TabIndex = 1
        Me.txtPhone1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone1.CustomButton.UseSelectable = True
        Me.txtPhone1.CustomButton.Visible = False
        Me.txtPhone1.Lines = New String(-1) {}
        Me.txtPhone1.Location = New System.Drawing.Point(552, 112)
        Me.txtPhone1.MaxLength = 32767
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone1.PromptText = "Saisissez l'adresse...."
        Me.txtPhone1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone1.SelectedText = ""
        Me.txtPhone1.SelectionLength = 0
        Me.txtPhone1.SelectionStart = 0
        Me.txtPhone1.ShortcutsEnabled = True
        Me.txtPhone1.Size = New System.Drawing.Size(257, 23)
        Me.txtPhone1.TabIndex = 1
        Me.txtPhone1.UseSelectable = True
        Me.txtPhone1.WaterMark = "Saisissez l'adresse...."
        Me.txtPhone1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAdresse
        '
        '
        '
        '
        Me.txtAdresse.CustomButton.Image = Nothing
        Me.txtAdresse.CustomButton.Location = New System.Drawing.Point(235, 1)
        Me.txtAdresse.CustomButton.Name = ""
        Me.txtAdresse.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresse.CustomButton.TabIndex = 1
        Me.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresse.CustomButton.UseSelectable = True
        Me.txtAdresse.CustomButton.Visible = False
        Me.txtAdresse.Lines = New String(-1) {}
        Me.txtAdresse.Location = New System.Drawing.Point(552, 52)
        Me.txtAdresse.MaxLength = 32767
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresse.PromptText = "Saisissez l'adresse...."
        Me.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresse.SelectedText = ""
        Me.txtAdresse.SelectionLength = 0
        Me.txtAdresse.SelectionStart = 0
        Me.txtAdresse.ShortcutsEnabled = True
        Me.txtAdresse.Size = New System.Drawing.Size(257, 23)
        Me.txtAdresse.TabIndex = 1
        Me.txtAdresse.UseSelectable = True
        Me.txtAdresse.WaterMark = "Saisissez l'adresse...."
        Me.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrenom
        '
        '
        '
        '
        Me.txtPrenom.CustomButton.Image = Nothing
        Me.txtPrenom.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.txtPrenom.CustomButton.Name = ""
        Me.txtPrenom.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrenom.CustomButton.TabIndex = 1
        Me.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrenom.CustomButton.UseSelectable = True
        Me.txtPrenom.CustomButton.Visible = False
        Me.txtPrenom.Lines = New String(-1) {}
        Me.txtPrenom.Location = New System.Drawing.Point(150, 52)
        Me.txtPrenom.MaxLength = 32767
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrenom.PromptText = "Saisissez le prenom...."
        Me.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrenom.SelectedText = ""
        Me.txtPrenom.SelectionLength = 0
        Me.txtPrenom.SelectionStart = 0
        Me.txtPrenom.ShortcutsEnabled = True
        Me.txtPrenom.Size = New System.Drawing.Size(277, 23)
        Me.txtPrenom.TabIndex = 2
        Me.txtPrenom.UseSelectable = True
        Me.txtPrenom.WaterMark = "Saisissez le prenom...."
        Me.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrenom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(450, 176)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel13.TabIndex = 0
        Me.MetroLabel13.Text = "Email : "
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(17, 221)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel7.TabIndex = 0
        Me.MetroLabel7.Text = "Lieu de naissance : "
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(450, 148)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel12.TabIndex = 0
        Me.MetroLabel12.Text = "Phone 2 : "
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(17, 190)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "Date de naissance :"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(450, 86)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "BP. : "
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(450, 117)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel11.TabIndex = 0
        Me.MetroLabel11.Text = "Phone 1 : "
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 153)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "Nombre Enfant : "
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(450, 57)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "Adresse : "
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 90)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Sexe : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 56)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Prenom : "
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(150, 21)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.PromptText = "Saisissez le nom...."
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(277, 23)
        Me.txtNom.TabIndex = 1
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMark = "Saisissez le nom...."
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 25)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nom : "
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.GroupBoxSalaire)
        Me.MetroTabPage2.Controls.Add(Me.GroupBoxAutreInfo)
        Me.MetroTabPage2.Controls.Add(Me.GroupBoxCompetance)
        Me.MetroTabPage2.Controls.Add(Me.GroupContrat)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1192, 575)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Contrat / Comptétances / Salaire    "
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'GroupBoxSalaire
        '
        Me.GroupBoxSalaire.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxSalaire.Controls.Add(Me.cmbTermePaiement)
        Me.GroupBoxSalaire.Controls.Add(Me.MetroLabel37)
        Me.GroupBoxSalaire.Controls.Add(Me.txtSalaireMensuel)
        Me.GroupBoxSalaire.Controls.Add(Me.MetroLabel40)
        Me.GroupBoxSalaire.Controls.Add(Me.txtNbJourTravail)
        Me.GroupBoxSalaire.Controls.Add(Me.MetroLabel39)
        Me.GroupBoxSalaire.Controls.Add(Me.txtTauxSalaire)
        Me.GroupBoxSalaire.Controls.Add(Me.MetroLabel38)
        Me.GroupBoxSalaire.Enabled = False
        Me.GroupBoxSalaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSalaire.Location = New System.Drawing.Point(603, 398)
        Me.GroupBoxSalaire.Name = "GroupBoxSalaire"
        Me.GroupBoxSalaire.Size = New System.Drawing.Size(584, 148)
        Me.GroupBoxSalaire.TabIndex = 10
        Me.GroupBoxSalaire.TabStop = False
        Me.GroupBoxSalaire.Text = "Salaire / Paiements"
        '
        'cmbTermePaiement
        '
        Me.cmbTermePaiement.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbTermePaiement.FormattingEnabled = True
        Me.cmbTermePaiement.ItemHeight = 19
        Me.cmbTermePaiement.Items.AddRange(New Object() {"PAR MOIS", "PAR HEURE"})
        Me.cmbTermePaiement.Location = New System.Drawing.Point(187, 22)
        Me.cmbTermePaiement.Name = "cmbTermePaiement"
        Me.cmbTermePaiement.Size = New System.Drawing.Size(377, 25)
        Me.cmbTermePaiement.TabIndex = 1
        Me.cmbTermePaiement.UseSelectable = True
        '
        'MetroLabel37
        '
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.Location = New System.Drawing.Point(21, 28)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel37.TabIndex = 0
        Me.MetroLabel37.Text = "Terme paiement :"
        '
        'txtSalaireMensuel
        '
        '
        '
        '
        Me.txtSalaireMensuel.CustomButton.Image = Nothing
        Me.txtSalaireMensuel.CustomButton.Location = New System.Drawing.Point(353, 1)
        Me.txtSalaireMensuel.CustomButton.Name = ""
        Me.txtSalaireMensuel.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtSalaireMensuel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSalaireMensuel.CustomButton.TabIndex = 1
        Me.txtSalaireMensuel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSalaireMensuel.CustomButton.UseSelectable = True
        Me.txtSalaireMensuel.CustomButton.Visible = False
        Me.txtSalaireMensuel.Lines = New String(-1) {}
        Me.txtSalaireMensuel.Location = New System.Drawing.Point(187, 112)
        Me.txtSalaireMensuel.MaxLength = 32767
        Me.txtSalaireMensuel.Name = "txtSalaireMensuel"
        Me.txtSalaireMensuel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSalaireMensuel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSalaireMensuel.SelectedText = ""
        Me.txtSalaireMensuel.SelectionLength = 0
        Me.txtSalaireMensuel.SelectionStart = 0
        Me.txtSalaireMensuel.ShortcutsEnabled = True
        Me.txtSalaireMensuel.Size = New System.Drawing.Size(377, 25)
        Me.txtSalaireMensuel.TabIndex = 2
        Me.txtSalaireMensuel.UseSelectable = True
        Me.txtSalaireMensuel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSalaireMensuel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel40
        '
        Me.MetroLabel40.AutoSize = True
        Me.MetroLabel40.Location = New System.Drawing.Point(21, 118)
        Me.MetroLabel40.Name = "MetroLabel40"
        Me.MetroLabel40.Size = New System.Drawing.Size(168, 19)
        Me.MetroLabel40.TabIndex = 0
        Me.MetroLabel40.Text = "Salaire / Prime mensuel : "
        '
        'txtNbJourTravail
        '
        '
        '
        '
        Me.txtNbJourTravail.CustomButton.Image = Nothing
        Me.txtNbJourTravail.CustomButton.Location = New System.Drawing.Point(353, 1)
        Me.txtNbJourTravail.CustomButton.Name = ""
        Me.txtNbJourTravail.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtNbJourTravail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbJourTravail.CustomButton.TabIndex = 1
        Me.txtNbJourTravail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbJourTravail.CustomButton.UseSelectable = True
        Me.txtNbJourTravail.CustomButton.Visible = False
        Me.txtNbJourTravail.Lines = New String(-1) {}
        Me.txtNbJourTravail.Location = New System.Drawing.Point(187, 82)
        Me.txtNbJourTravail.MaxLength = 32767
        Me.txtNbJourTravail.Name = "txtNbJourTravail"
        Me.txtNbJourTravail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbJourTravail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbJourTravail.SelectedText = ""
        Me.txtNbJourTravail.SelectionLength = 0
        Me.txtNbJourTravail.SelectionStart = 0
        Me.txtNbJourTravail.ShortcutsEnabled = True
        Me.txtNbJourTravail.Size = New System.Drawing.Size(377, 25)
        Me.txtNbJourTravail.TabIndex = 2
        Me.txtNbJourTravail.UseSelectable = True
        Me.txtNbJourTravail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbJourTravail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel39
        '
        Me.MetroLabel39.AutoSize = True
        Me.MetroLabel39.Location = New System.Drawing.Point(21, 88)
        Me.MetroLabel39.Name = "MetroLabel39"
        Me.MetroLabel39.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel39.TabIndex = 0
        Me.MetroLabel39.Text = "Nbre jour de Travail : "
        '
        'txtTauxSalaire
        '
        '
        '
        '
        Me.txtTauxSalaire.CustomButton.Image = Nothing
        Me.txtTauxSalaire.CustomButton.Location = New System.Drawing.Point(353, 1)
        Me.txtTauxSalaire.CustomButton.Name = ""
        Me.txtTauxSalaire.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtTauxSalaire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTauxSalaire.CustomButton.TabIndex = 1
        Me.txtTauxSalaire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTauxSalaire.CustomButton.UseSelectable = True
        Me.txtTauxSalaire.CustomButton.Visible = False
        Me.txtTauxSalaire.Lines = New String(-1) {}
        Me.txtTauxSalaire.Location = New System.Drawing.Point(187, 53)
        Me.txtTauxSalaire.MaxLength = 32767
        Me.txtTauxSalaire.Name = "txtTauxSalaire"
        Me.txtTauxSalaire.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTauxSalaire.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTauxSalaire.SelectedText = ""
        Me.txtTauxSalaire.SelectionLength = 0
        Me.txtTauxSalaire.SelectionStart = 0
        Me.txtTauxSalaire.ShortcutsEnabled = True
        Me.txtTauxSalaire.Size = New System.Drawing.Size(377, 25)
        Me.txtTauxSalaire.TabIndex = 2
        Me.txtTauxSalaire.UseSelectable = True
        Me.txtTauxSalaire.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTauxSalaire.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel38
        '
        Me.MetroLabel38.AutoSize = True
        Me.MetroLabel38.Location = New System.Drawing.Point(21, 59)
        Me.MetroLabel38.Name = "MetroLabel38"
        Me.MetroLabel38.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel38.TabIndex = 0
        Me.MetroLabel38.Text = "Taux salaire / Prime : "
        '
        'GroupBoxAutreInfo
        '
        Me.GroupBoxAutreInfo.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxAutreInfo.Controls.Add(Me.cmbFormation)
        Me.GroupBoxAutreInfo.Controls.Add(Me.cmbDelis)
        Me.GroupBoxAutreInfo.Controls.Add(Me.cmbReligion)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel18)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel14)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel16)
        Me.GroupBoxAutreInfo.Controls.Add(Me.txtEcole)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel22)
        Me.GroupBoxAutreInfo.Controls.Add(Me.txtDiplome)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel21)
        Me.GroupBoxAutreInfo.Controls.Add(Me.txtNiveauEt)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel20)
        Me.GroupBoxAutreInfo.Controls.Add(Me.txtTypeFormation)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel19)
        Me.GroupBoxAutreInfo.Controls.Add(Me.txtDetailDelis)
        Me.GroupBoxAutreInfo.Controls.Add(Me.LabelDelis)
        Me.GroupBoxAutreInfo.Controls.Add(Me.txtAutreRelion)
        Me.GroupBoxAutreInfo.Controls.Add(Me.MetroLabel15)
        Me.GroupBoxAutreInfo.Enabled = False
        Me.GroupBoxAutreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAutreInfo.Location = New System.Drawing.Point(603, 13)
        Me.GroupBoxAutreInfo.Name = "GroupBoxAutreInfo"
        Me.GroupBoxAutreInfo.Size = New System.Drawing.Size(584, 376)
        Me.GroupBoxAutreInfo.TabIndex = 8
        Me.GroupBoxAutreInfo.TabStop = False
        Me.GroupBoxAutreInfo.Text = "Autres info"
        '
        'cmbFormation
        '
        Me.cmbFormation.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbFormation.FormattingEnabled = True
        Me.cmbFormation.ItemHeight = 19
        Me.cmbFormation.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cmbFormation.Location = New System.Drawing.Point(323, 178)
        Me.cmbFormation.Name = "cmbFormation"
        Me.cmbFormation.Size = New System.Drawing.Size(241, 25)
        Me.cmbFormation.TabIndex = 2
        Me.cmbFormation.UseSelectable = True
        '
        'cmbDelis
        '
        Me.cmbDelis.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbDelis.FormattingEnabled = True
        Me.cmbDelis.ItemHeight = 19
        Me.cmbDelis.Items.AddRange(New Object() {"Oui", "Non"})
        Me.cmbDelis.Location = New System.Drawing.Point(316, 114)
        Me.cmbDelis.Name = "cmbDelis"
        Me.cmbDelis.Size = New System.Drawing.Size(248, 25)
        Me.cmbDelis.TabIndex = 2
        Me.cmbDelis.UseSelectable = True
        '
        'cmbReligion
        '
        Me.cmbReligion.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbReligion.FormattingEnabled = True
        Me.cmbReligion.ItemHeight = 19
        Me.cmbReligion.Items.AddRange(New Object() {"Marmom", "Catholique", "Kimbaguiste", "Temoin de Jehovah", "Eglise de Reveil", "Je suis Non Croyant", "Autres"})
        Me.cmbReligion.Location = New System.Drawing.Point(187, 50)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(377, 25)
        Me.cmbReligion.TabIndex = 2
        Me.cmbReligion.UseSelectable = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(21, 181)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(234, 19)
        Me.MetroLabel18.TabIndex = 0
        Me.MetroLabel18.Text = "Avez vous déjà réçu une formation ?"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(21, 56)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel14.TabIndex = 0
        Me.MetroLabel14.Text = "Réligion : "
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(21, 118)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(214, 19)
        Me.MetroLabel16.TabIndex = 0
        Me.MetroLabel16.Text = "Avez vous déjà commit un délis ?"
        '
        'txtEcole
        '
        '
        '
        '
        Me.txtEcole.CustomButton.Image = Nothing
        Me.txtEcole.CustomButton.Location = New System.Drawing.Point(355, 1)
        Me.txtEcole.CustomButton.Name = ""
        Me.txtEcole.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEcole.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEcole.CustomButton.TabIndex = 1
        Me.txtEcole.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEcole.CustomButton.UseSelectable = True
        Me.txtEcole.CustomButton.Visible = False
        Me.txtEcole.Lines = New String(-1) {}
        Me.txtEcole.Location = New System.Drawing.Point(187, 304)
        Me.txtEcole.MaxLength = 32767
        Me.txtEcole.Name = "txtEcole"
        Me.txtEcole.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEcole.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEcole.SelectedText = ""
        Me.txtEcole.SelectionLength = 0
        Me.txtEcole.SelectionStart = 0
        Me.txtEcole.ShortcutsEnabled = True
        Me.txtEcole.Size = New System.Drawing.Size(377, 23)
        Me.txtEcole.TabIndex = 1
        Me.txtEcole.UseSelectable = True
        Me.txtEcole.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEcole.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(21, 307)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel22.TabIndex = 0
        Me.MetroLabel22.Text = "Ecole :"
        '
        'txtDiplome
        '
        '
        '
        '
        Me.txtDiplome.CustomButton.Image = Nothing
        Me.txtDiplome.CustomButton.Location = New System.Drawing.Point(355, 1)
        Me.txtDiplome.CustomButton.Name = ""
        Me.txtDiplome.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDiplome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDiplome.CustomButton.TabIndex = 1
        Me.txtDiplome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDiplome.CustomButton.UseSelectable = True
        Me.txtDiplome.CustomButton.Visible = False
        Me.txtDiplome.Lines = New String(-1) {}
        Me.txtDiplome.Location = New System.Drawing.Point(187, 273)
        Me.txtDiplome.MaxLength = 32767
        Me.txtDiplome.Name = "txtDiplome"
        Me.txtDiplome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiplome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDiplome.SelectedText = ""
        Me.txtDiplome.SelectionLength = 0
        Me.txtDiplome.SelectionStart = 0
        Me.txtDiplome.ShortcutsEnabled = True
        Me.txtDiplome.Size = New System.Drawing.Size(377, 23)
        Me.txtDiplome.TabIndex = 1
        Me.txtDiplome.UseSelectable = True
        Me.txtDiplome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDiplome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(21, 269)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel21.TabIndex = 0
        Me.MetroLabel21.Text = "Diplome :"
        '
        'txtNiveauEt
        '
        '
        '
        '
        Me.txtNiveauEt.CustomButton.Image = Nothing
        Me.txtNiveauEt.CustomButton.Location = New System.Drawing.Point(355, 1)
        Me.txtNiveauEt.CustomButton.Name = ""
        Me.txtNiveauEt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNiveauEt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNiveauEt.CustomButton.TabIndex = 1
        Me.txtNiveauEt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNiveauEt.CustomButton.UseSelectable = True
        Me.txtNiveauEt.CustomButton.Visible = False
        Me.txtNiveauEt.Lines = New String(-1) {}
        Me.txtNiveauEt.Location = New System.Drawing.Point(187, 242)
        Me.txtNiveauEt.MaxLength = 32767
        Me.txtNiveauEt.Name = "txtNiveauEt"
        Me.txtNiveauEt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNiveauEt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNiveauEt.SelectedText = ""
        Me.txtNiveauEt.SelectionLength = 0
        Me.txtNiveauEt.SelectionStart = 0
        Me.txtNiveauEt.ShortcutsEnabled = True
        Me.txtNiveauEt.Size = New System.Drawing.Size(377, 23)
        Me.txtNiveauEt.TabIndex = 1
        Me.txtNiveauEt.UseSelectable = True
        Me.txtNiveauEt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNiveauEt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(21, 239)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel20.TabIndex = 0
        Me.MetroLabel20.Text = "Niveau d'etude :"
        '
        'txtTypeFormation
        '
        '
        '
        '
        Me.txtTypeFormation.CustomButton.Image = Nothing
        Me.txtTypeFormation.CustomButton.Location = New System.Drawing.Point(355, 1)
        Me.txtTypeFormation.CustomButton.Name = ""
        Me.txtTypeFormation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTypeFormation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTypeFormation.CustomButton.TabIndex = 1
        Me.txtTypeFormation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTypeFormation.CustomButton.UseSelectable = True
        Me.txtTypeFormation.CustomButton.Visible = False
        Me.txtTypeFormation.Lines = New String(-1) {}
        Me.txtTypeFormation.Location = New System.Drawing.Point(187, 211)
        Me.txtTypeFormation.MaxLength = 32767
        Me.txtTypeFormation.Name = "txtTypeFormation"
        Me.txtTypeFormation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTypeFormation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTypeFormation.SelectedText = ""
        Me.txtTypeFormation.SelectionLength = 0
        Me.txtTypeFormation.SelectionStart = 0
        Me.txtTypeFormation.ShortcutsEnabled = True
        Me.txtTypeFormation.Size = New System.Drawing.Size(377, 23)
        Me.txtTypeFormation.TabIndex = 1
        Me.txtTypeFormation.UseSelectable = True
        Me.txtTypeFormation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTypeFormation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(21, 209)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel19.TabIndex = 0
        Me.MetroLabel19.Text = "Type de formation :"
        '
        'txtDetailDelis
        '
        '
        '
        '
        Me.txtDetailDelis.CustomButton.Image = Nothing
        Me.txtDetailDelis.CustomButton.Location = New System.Drawing.Point(355, 1)
        Me.txtDetailDelis.CustomButton.Name = ""
        Me.txtDetailDelis.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDetailDelis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDetailDelis.CustomButton.TabIndex = 1
        Me.txtDetailDelis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDetailDelis.CustomButton.UseSelectable = True
        Me.txtDetailDelis.CustomButton.Visible = False
        Me.txtDetailDelis.Lines = New String(-1) {}
        Me.txtDetailDelis.Location = New System.Drawing.Point(187, 147)
        Me.txtDetailDelis.MaxLength = 32767
        Me.txtDetailDelis.Name = "txtDetailDelis"
        Me.txtDetailDelis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetailDelis.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDetailDelis.SelectedText = ""
        Me.txtDetailDelis.SelectionLength = 0
        Me.txtDetailDelis.SelectionStart = 0
        Me.txtDetailDelis.ShortcutsEnabled = True
        Me.txtDetailDelis.Size = New System.Drawing.Size(377, 23)
        Me.txtDetailDelis.TabIndex = 1
        Me.txtDetailDelis.UseSelectable = True
        Me.txtDetailDelis.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDetailDelis.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelDelis
        '
        Me.LabelDelis.AutoSize = True
        Me.LabelDelis.Location = New System.Drawing.Point(21, 147)
        Me.LabelDelis.Name = "LabelDelis"
        Me.LabelDelis.Size = New System.Drawing.Size(120, 19)
        Me.LabelDelis.TabIndex = 0
        Me.LabelDelis.Text = "Si oui, expliquez : "
        '
        'txtAutreRelion
        '
        '
        '
        '
        Me.txtAutreRelion.CustomButton.Image = Nothing
        Me.txtAutreRelion.CustomButton.Location = New System.Drawing.Point(355, 1)
        Me.txtAutreRelion.CustomButton.Name = ""
        Me.txtAutreRelion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAutreRelion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAutreRelion.CustomButton.TabIndex = 1
        Me.txtAutreRelion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAutreRelion.CustomButton.UseSelectable = True
        Me.txtAutreRelion.CustomButton.Visible = False
        Me.txtAutreRelion.Lines = New String(-1) {}
        Me.txtAutreRelion.Location = New System.Drawing.Point(187, 83)
        Me.txtAutreRelion.MaxLength = 32767
        Me.txtAutreRelion.Name = "txtAutreRelion"
        Me.txtAutreRelion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAutreRelion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAutreRelion.SelectedText = ""
        Me.txtAutreRelion.SelectionLength = 0
        Me.txtAutreRelion.SelectionStart = 0
        Me.txtAutreRelion.ShortcutsEnabled = True
        Me.txtAutreRelion.Size = New System.Drawing.Size(377, 23)
        Me.txtAutreRelion.TabIndex = 1
        Me.txtAutreRelion.UseSelectable = True
        Me.txtAutreRelion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAutreRelion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(21, 85)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel15.TabIndex = 0
        Me.MetroLabel15.Text = "Autre precisez : "
        '
        'GroupBoxCompetance
        '
        Me.GroupBoxCompetance.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxCompetance.Controls.Add(Me.MetroLabel41)
        Me.GroupBoxCompetance.Controls.Add(Me.MetroLabel36)
        Me.GroupBoxCompetance.Controls.Add(Me.MetroLabel42)
        Me.GroupBoxCompetance.Controls.Add(Me.MetroLabel43)
        Me.GroupBoxCompetance.Controls.Add(Me.txtNoteExperience)
        Me.GroupBoxCompetance.Controls.Add(Me.txtAutreComp)
        Me.GroupBoxCompetance.Controls.Add(Me.txtInformation)
        Me.GroupBoxCompetance.Controls.Add(Me.txtCompEn)
        Me.GroupBoxCompetance.Controls.Add(Me.txtCompFr)
        Me.GroupBoxCompetance.Controls.Add(Me.MetroLabel44)
        Me.GroupBoxCompetance.Enabled = False
        Me.GroupBoxCompetance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCompetance.Location = New System.Drawing.Point(12, 13)
        Me.GroupBoxCompetance.Name = "GroupBoxCompetance"
        Me.GroupBoxCompetance.Size = New System.Drawing.Size(578, 213)
        Me.GroupBoxCompetance.TabIndex = 7
        Me.GroupBoxCompetance.TabStop = False
        Me.GroupBoxCompetance.Text = "Compétances"
        '
        'MetroLabel41
        '
        Me.MetroLabel41.AutoSize = True
        Me.MetroLabel41.Location = New System.Drawing.Point(17, 165)
        Me.MetroLabel41.Name = "MetroLabel41"
        Me.MetroLabel41.Size = New System.Drawing.Size(118, 38)
        Me.MetroLabel41.TabIndex = 0
        Me.MetroLabel41.Text = "Note expérience " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "professionel :"
        '
        'MetroLabel36
        '
        Me.MetroLabel36.AutoSize = True
        Me.MetroLabel36.Location = New System.Drawing.Point(17, 133)
        Me.MetroLabel36.Name = "MetroLabel36"
        Me.MetroLabel36.Size = New System.Drawing.Size(139, 19)
        Me.MetroLabel36.TabIndex = 0
        Me.MetroLabel36.Text = "Autres compétanes :"
        '
        'MetroLabel42
        '
        Me.MetroLabel42.AutoSize = True
        Me.MetroLabel42.Location = New System.Drawing.Point(17, 102)
        Me.MetroLabel42.Name = "MetroLabel42"
        Me.MetroLabel42.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel42.TabIndex = 0
        Me.MetroLabel42.Text = "Information :"
        '
        'MetroLabel43
        '
        Me.MetroLabel43.AutoSize = True
        Me.MetroLabel43.Location = New System.Drawing.Point(17, 68)
        Me.MetroLabel43.Name = "MetroLabel43"
        Me.MetroLabel43.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel43.TabIndex = 0
        Me.MetroLabel43.Text = "Anglais : "
        '
        'txtNoteExperience
        '
        '
        '
        '
        Me.txtNoteExperience.CustomButton.Image = Nothing
        Me.txtNoteExperience.CustomButton.Location = New System.Drawing.Point(328, 1)
        Me.txtNoteExperience.CustomButton.Name = ""
        Me.txtNoteExperience.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtNoteExperience.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNoteExperience.CustomButton.TabIndex = 1
        Me.txtNoteExperience.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNoteExperience.CustomButton.UseSelectable = True
        Me.txtNoteExperience.CustomButton.Visible = False
        Me.txtNoteExperience.Lines = New String(-1) {}
        Me.txtNoteExperience.Location = New System.Drawing.Point(188, 169)
        Me.txtNoteExperience.MaxLength = 32767
        Me.txtNoteExperience.Multiline = True
        Me.txtNoteExperience.Name = "txtNoteExperience"
        Me.txtNoteExperience.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoteExperience.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoteExperience.SelectedText = ""
        Me.txtNoteExperience.SelectionLength = 0
        Me.txtNoteExperience.SelectionStart = 0
        Me.txtNoteExperience.ShortcutsEnabled = True
        Me.txtNoteExperience.Size = New System.Drawing.Size(364, 37)
        Me.txtNoteExperience.TabIndex = 2
        Me.txtNoteExperience.UseSelectable = True
        Me.txtNoteExperience.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNoteExperience.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAutreComp
        '
        '
        '
        '
        Me.txtAutreComp.CustomButton.Image = Nothing
        Me.txtAutreComp.CustomButton.Location = New System.Drawing.Point(336, 2)
        Me.txtAutreComp.CustomButton.Name = ""
        Me.txtAutreComp.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAutreComp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAutreComp.CustomButton.TabIndex = 1
        Me.txtAutreComp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAutreComp.CustomButton.UseSelectable = True
        Me.txtAutreComp.CustomButton.Visible = False
        Me.txtAutreComp.Lines = New String(-1) {}
        Me.txtAutreComp.Location = New System.Drawing.Point(188, 132)
        Me.txtAutreComp.MaxLength = 32767
        Me.txtAutreComp.Multiline = True
        Me.txtAutreComp.Name = "txtAutreComp"
        Me.txtAutreComp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAutreComp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAutreComp.SelectedText = ""
        Me.txtAutreComp.SelectionLength = 0
        Me.txtAutreComp.SelectionStart = 0
        Me.txtAutreComp.ShortcutsEnabled = True
        Me.txtAutreComp.Size = New System.Drawing.Size(364, 30)
        Me.txtAutreComp.TabIndex = 2
        Me.txtAutreComp.UseSelectable = True
        Me.txtAutreComp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAutreComp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtInformation
        '
        '
        '
        '
        Me.txtInformation.CustomButton.Image = Nothing
        Me.txtInformation.CustomButton.Location = New System.Drawing.Point(336, 2)
        Me.txtInformation.CustomButton.Name = ""
        Me.txtInformation.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtInformation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInformation.CustomButton.TabIndex = 1
        Me.txtInformation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInformation.CustomButton.UseSelectable = True
        Me.txtInformation.CustomButton.Visible = False
        Me.txtInformation.Lines = New String(-1) {}
        Me.txtInformation.Location = New System.Drawing.Point(188, 94)
        Me.txtInformation.MaxLength = 32767
        Me.txtInformation.Multiline = True
        Me.txtInformation.Name = "txtInformation"
        Me.txtInformation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInformation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInformation.SelectedText = ""
        Me.txtInformation.SelectionLength = 0
        Me.txtInformation.SelectionStart = 0
        Me.txtInformation.ShortcutsEnabled = True
        Me.txtInformation.Size = New System.Drawing.Size(364, 30)
        Me.txtInformation.TabIndex = 2
        Me.txtInformation.UseSelectable = True
        Me.txtInformation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInformation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCompEn
        '
        '
        '
        '
        Me.txtCompEn.CustomButton.Image = Nothing
        Me.txtCompEn.CustomButton.Location = New System.Drawing.Point(336, 2)
        Me.txtCompEn.CustomButton.Name = ""
        Me.txtCompEn.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCompEn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCompEn.CustomButton.TabIndex = 1
        Me.txtCompEn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCompEn.CustomButton.UseSelectable = True
        Me.txtCompEn.CustomButton.Visible = False
        Me.txtCompEn.Lines = New String(-1) {}
        Me.txtCompEn.Location = New System.Drawing.Point(188, 60)
        Me.txtCompEn.MaxLength = 32767
        Me.txtCompEn.Multiline = True
        Me.txtCompEn.Name = "txtCompEn"
        Me.txtCompEn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompEn.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCompEn.SelectedText = ""
        Me.txtCompEn.SelectionLength = 0
        Me.txtCompEn.SelectionStart = 0
        Me.txtCompEn.ShortcutsEnabled = True
        Me.txtCompEn.Size = New System.Drawing.Size(364, 30)
        Me.txtCompEn.TabIndex = 2
        Me.txtCompEn.UseSelectable = True
        Me.txtCompEn.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCompEn.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCompFr
        '
        '
        '
        '
        Me.txtCompFr.CustomButton.Image = Nothing
        Me.txtCompFr.CustomButton.Location = New System.Drawing.Point(336, 2)
        Me.txtCompFr.CustomButton.Name = ""
        Me.txtCompFr.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCompFr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCompFr.CustomButton.TabIndex = 1
        Me.txtCompFr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCompFr.CustomButton.UseSelectable = True
        Me.txtCompFr.CustomButton.Visible = False
        Me.txtCompFr.Lines = New String(-1) {}
        Me.txtCompFr.Location = New System.Drawing.Point(188, 25)
        Me.txtCompFr.MaxLength = 32767
        Me.txtCompFr.Multiline = True
        Me.txtCompFr.Name = "txtCompFr"
        Me.txtCompFr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCompFr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCompFr.SelectedText = ""
        Me.txtCompFr.SelectionLength = 0
        Me.txtCompFr.SelectionStart = 0
        Me.txtCompFr.ShortcutsEnabled = True
        Me.txtCompFr.Size = New System.Drawing.Size(364, 30)
        Me.txtCompFr.TabIndex = 2
        Me.txtCompFr.UseSelectable = True
        Me.txtCompFr.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCompFr.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel44
        '
        Me.MetroLabel44.AutoSize = True
        Me.MetroLabel44.Location = New System.Drawing.Point(17, 29)
        Me.MetroLabel44.Name = "MetroLabel44"
        Me.MetroLabel44.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel44.TabIndex = 0
        Me.MetroLabel44.Text = "Français : "
        '
        'GroupContrat
        '
        Me.GroupContrat.BackColor = System.Drawing.Color.Transparent
        Me.GroupContrat.Controls.Add(Me.txtFinContrat)
        Me.GroupContrat.Controls.Add(Me.txtDateDebutContrat)
        Me.GroupContrat.Controls.Add(Me.txtNbHeure)
        Me.GroupContrat.Controls.Add(Me.txtDureeContrat)
        Me.GroupContrat.Controls.Add(Me.cmbUniteDuree)
        Me.GroupContrat.Controls.Add(Me.MetroLabel32)
        Me.GroupContrat.Controls.Add(Me.cmbSuperviseur)
        Me.GroupContrat.Controls.Add(Me.cmbClassification)
        Me.GroupContrat.Controls.Add(Me.MetroLabel34)
        Me.GroupContrat.Controls.Add(Me.MetroLabel33)
        Me.GroupContrat.Controls.Add(Me.MetroLabel27)
        Me.GroupContrat.Controls.Add(Me.MetroLabel26)
        Me.GroupContrat.Controls.Add(Me.MetroLabel35)
        Me.GroupContrat.Controls.Add(Me.cmbPoste)
        Me.GroupContrat.Controls.Add(Me.MetroLabel25)
        Me.GroupContrat.Controls.Add(Me.cmbDepartement)
        Me.GroupContrat.Controls.Add(Me.MetroLabel24)
        Me.GroupContrat.Controls.Add(Me.MetroLabel23)
        Me.GroupContrat.Enabled = False
        Me.GroupContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupContrat.Location = New System.Drawing.Point(12, 232)
        Me.GroupContrat.Name = "GroupContrat"
        Me.GroupContrat.Size = New System.Drawing.Size(578, 314)
        Me.GroupContrat.TabIndex = 2
        Me.GroupContrat.TabStop = False
        Me.GroupContrat.Text = "Contrat / Responsabilité"
        '
        'txtFinContrat
        '
        Me.txtFinContrat.Location = New System.Drawing.Point(188, 201)
        Me.txtFinContrat.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtFinContrat.Name = "txtFinContrat"
        Me.txtFinContrat.Size = New System.Drawing.Size(364, 29)
        Me.txtFinContrat.TabIndex = 3
        '
        'txtDateDebutContrat
        '
        Me.txtDateDebutContrat.Location = New System.Drawing.Point(188, 166)
        Me.txtDateDebutContrat.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtDateDebutContrat.Name = "txtDateDebutContrat"
        Me.txtDateDebutContrat.Size = New System.Drawing.Size(364, 29)
        Me.txtDateDebutContrat.TabIndex = 3
        '
        'txtNbHeure
        '
        '
        '
        '
        Me.txtNbHeure.CustomButton.Image = Nothing
        Me.txtNbHeure.CustomButton.Location = New System.Drawing.Point(120, 1)
        Me.txtNbHeure.CustomButton.Name = ""
        Me.txtNbHeure.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtNbHeure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbHeure.CustomButton.TabIndex = 1
        Me.txtNbHeure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbHeure.CustomButton.UseSelectable = True
        Me.txtNbHeure.CustomButton.Visible = False
        Me.txtNbHeure.Lines = New String(-1) {}
        Me.txtNbHeure.Location = New System.Drawing.Point(188, 236)
        Me.txtNbHeure.MaxLength = 32767
        Me.txtNbHeure.Name = "txtNbHeure"
        Me.txtNbHeure.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbHeure.PromptText = "2"
        Me.txtNbHeure.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbHeure.SelectedText = ""
        Me.txtNbHeure.SelectionLength = 0
        Me.txtNbHeure.SelectionStart = 0
        Me.txtNbHeure.ShortcutsEnabled = True
        Me.txtNbHeure.Size = New System.Drawing.Size(144, 25)
        Me.txtNbHeure.TabIndex = 2
        Me.txtNbHeure.UseSelectable = True
        Me.txtNbHeure.WaterMark = "2"
        Me.txtNbHeure.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbHeure.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDureeContrat
        '
        '
        '
        '
        Me.txtDureeContrat.CustomButton.Image = Nothing
        Me.txtDureeContrat.CustomButton.Location = New System.Drawing.Point(148, 1)
        Me.txtDureeContrat.CustomButton.Name = ""
        Me.txtDureeContrat.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtDureeContrat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDureeContrat.CustomButton.TabIndex = 1
        Me.txtDureeContrat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDureeContrat.CustomButton.UseSelectable = True
        Me.txtDureeContrat.CustomButton.Visible = False
        Me.txtDureeContrat.Lines = New String(-1) {}
        Me.txtDureeContrat.Location = New System.Drawing.Point(188, 132)
        Me.txtDureeContrat.MaxLength = 32767
        Me.txtDureeContrat.Name = "txtDureeContrat"
        Me.txtDureeContrat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDureeContrat.PromptText = "2"
        Me.txtDureeContrat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDureeContrat.SelectedText = ""
        Me.txtDureeContrat.SelectionLength = 0
        Me.txtDureeContrat.SelectionStart = 0
        Me.txtDureeContrat.ShortcutsEnabled = True
        Me.txtDureeContrat.Size = New System.Drawing.Size(172, 25)
        Me.txtDureeContrat.TabIndex = 2
        Me.txtDureeContrat.UseSelectable = True
        Me.txtDureeContrat.WaterMark = "2"
        Me.txtDureeContrat.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDureeContrat.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbUniteDuree
        '
        Me.cmbUniteDuree.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbUniteDuree.FormattingEnabled = True
        Me.cmbUniteDuree.ItemHeight = 19
        Me.cmbUniteDuree.Items.AddRange(New Object() {"Mois", "Annee"})
        Me.cmbUniteDuree.Location = New System.Drawing.Point(366, 132)
        Me.cmbUniteDuree.Name = "cmbUniteDuree"
        Me.cmbUniteDuree.Size = New System.Drawing.Size(186, 25)
        Me.cmbUniteDuree.TabIndex = 1
        Me.cmbUniteDuree.UseSelectable = True
        '
        'MetroLabel32
        '
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.Location = New System.Drawing.Point(26, 211)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel32.TabIndex = 0
        Me.MetroLabel32.Text = "Date de fin : "
        '
        'cmbSuperviseur
        '
        Me.cmbSuperviseur.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbSuperviseur.FormattingEnabled = True
        Me.cmbSuperviseur.ItemHeight = 19
        Me.cmbSuperviseur.Location = New System.Drawing.Point(188, 267)
        Me.cmbSuperviseur.Name = "cmbSuperviseur"
        Me.cmbSuperviseur.Size = New System.Drawing.Size(364, 25)
        Me.cmbSuperviseur.TabIndex = 1
        Me.cmbSuperviseur.UseSelectable = True
        '
        'cmbClassification
        '
        Me.cmbClassification.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.ItemHeight = 19
        Me.cmbClassification.Items.AddRange(New Object() {"Stagiaire", "Volentaire", "Employees"})
        Me.cmbClassification.Location = New System.Drawing.Point(188, 101)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(364, 25)
        Me.cmbClassification.TabIndex = 1
        Me.cmbClassification.UseSelectable = True
        '
        'MetroLabel34
        '
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel34.Location = New System.Drawing.Point(351, 241)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel34.TabIndex = 0
        Me.MetroLabel34.Text = "Par jour"
        '
        'MetroLabel33
        '
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.Location = New System.Drawing.Point(26, 242)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(167, 19)
        Me.MetroLabel33.TabIndex = 0
        Me.MetroLabel33.Text = "Nbre d'Heure de Travail : "
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(26, 176)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel27.TabIndex = 0
        Me.MetroLabel27.Text = "Date de début : "
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.Location = New System.Drawing.Point(26, 138)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel26.TabIndex = 0
        Me.MetroLabel26.Text = "Durée de contrat :"
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(26, 273)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel35.TabIndex = 0
        Me.MetroLabel35.Text = "Superviseur Direct : "
        '
        'cmbPoste
        '
        Me.cmbPoste.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbPoste.FormattingEnabled = True
        Me.cmbPoste.ItemHeight = 19
        Me.cmbPoste.Location = New System.Drawing.Point(188, 70)
        Me.cmbPoste.Name = "cmbPoste"
        Me.cmbPoste.Size = New System.Drawing.Size(364, 25)
        Me.cmbPoste.TabIndex = 1
        Me.cmbPoste.UseSelectable = True
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.Location = New System.Drawing.Point(26, 107)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel25.TabIndex = 0
        Me.MetroLabel25.Text = "Classification :"
        '
        'cmbDepartement
        '
        Me.cmbDepartement.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbDepartement.FormattingEnabled = True
        Me.cmbDepartement.ItemHeight = 19
        Me.cmbDepartement.Location = New System.Drawing.Point(188, 39)
        Me.cmbDepartement.Name = "cmbDepartement"
        Me.cmbDepartement.Size = New System.Drawing.Size(364, 25)
        Me.cmbDepartement.TabIndex = 1
        Me.cmbDepartement.UseSelectable = True
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Location = New System.Drawing.Point(26, 76)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel24.TabIndex = 0
        Me.MetroLabel24.Text = "Poste Occupe :"
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(26, 45)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel23.TabIndex = 0
        Me.MetroLabel23.Text = "Departement : "
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.PanelButtons)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBottom.HorizontalScrollbarBarColor = True
        Me.PanelBottom.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelBottom.HorizontalScrollbarSize = 10
        Me.PanelBottom.Location = New System.Drawing.Point(32, 626)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1203, 47)
        Me.PanelBottom.TabIndex = 1
        Me.PanelBottom.VerticalScrollbarBarColor = True
        Me.PanelBottom.VerticalScrollbarHighlightOnWheel = False
        Me.PanelBottom.VerticalScrollbarSize = 10
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.btnClear)
        Me.PanelButtons.Controls.Add(Me.btnClose)
        Me.PanelButtons.Controls.Add(Me.btnSave)
        Me.PanelButtons.Location = New System.Drawing.Point(394, 2)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(414, 42)
        Me.PanelButtons.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Location = New System.Drawing.Point(10, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 34)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "VIDER"
        Me.btnClear.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(279, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(129, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(145, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "ENREGISTRER"
        Me.btnSave.UseSelectable = True
        '
        'MajEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 756)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MajEmploye"
        Me.Text = "VUE / MISE A JOUR EMPLOYEE"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.GroupContactUrgence.ResumeLayout(False)
        Me.GroupContactUrgence.PerformLayout()
        Me.GroupInfoGeneral.ResumeLayout(False)
        Me.GroupInfoGeneral.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.GroupBoxSalaire.ResumeLayout(False)
        Me.GroupBoxSalaire.PerformLayout()
        Me.GroupBoxAutreInfo.ResumeLayout(False)
        Me.GroupBoxAutreInfo.PerformLayout()
        Me.GroupBoxCompetance.ResumeLayout(False)
        Me.GroupBoxCompetance.PerformLayout()
        Me.GroupContrat.ResumeLayout(False)
        Me.GroupContrat.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GroupInfoGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateNaiss As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbSituationMatri As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbSexe As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNationalite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLieuNaiss As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNbEnfant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAdresse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrenom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GroupContrat As System.Windows.Forms.GroupBox
    Friend WithEvents txtFinContrat As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDateDebutContrat As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtNbHeure As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDureeContrat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbUniteDuree As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbSuperviseur As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbClassification As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbPoste As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbDepartement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PanelBottom As MetroFramework.Controls.MetroPanel
    Friend WithEvents PanelButtons As System.Windows.Forms.Panel
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBoxSalaire As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTermePaiement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSalaireMensuel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel40 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNbJourTravail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel39 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTauxSalaire As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel38 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBoxAutreInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFormation As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDelis As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbReligion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEcole As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDiplome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNiveauEt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTypeFormation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDetailDelis As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LabelDelis As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAutreRelion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBoxCompetance As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel41 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel36 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel42 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel43 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNoteExperience As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAutreComp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInformation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCompEn As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCompFr As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel44 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupContactUrgence As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmailUrgence As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTelUrgence As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAdresseUrgence As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNomUrgence As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListEmploye As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRechCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel45 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtRechNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel46 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbRechDep As System.Windows.Forms.ComboBox
    Friend WithEvents MetroLabel49 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ckDepartement As System.Windows.Forms.CheckBox
    Friend WithEvents ckNom As System.Windows.Forms.CheckBox
    Friend WithEvents ckCode As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents EditerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
