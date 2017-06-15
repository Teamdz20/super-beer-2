<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeEmployees))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckDetail = New MetroFramework.Controls.MetroRadioButton()
        Me.ckPredefini = New MetroFramework.Controls.MetroRadioButton()
        Me.cmbAu = New System.Windows.Forms.DateTimePicker()
        Me.cmbDu = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.ckClassification = New MetroFramework.Controls.MetroCheckBox()
        Me.ckOrganiser = New MetroFramework.Controls.MetroCheckBox()
        Me.ckNom = New MetroFramework.Controls.MetroCheckBox()
        Me.ckCode = New MetroFramework.Controls.MetroCheckBox()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cmbClassification = New MetroFramework.Controls.MetroComboBox()
        Me.cmbAnnee = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox4 = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeRapport = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.labelTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.labelEmp = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.labelVol = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.labelStg = New MetroFramework.Controls.MetroLabel()
        Me.btnRapport = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.ListEmployes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckDetail)
        Me.GroupBox1.Controls.Add(Me.ckPredefini)
        Me.GroupBox1.Controls.Add(Me.cmbAu)
        Me.GroupBox1.Controls.Add(Me.cmbDu)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.ckClassification)
        Me.GroupBox1.Controls.Add(Me.ckOrganiser)
        Me.GroupBox1.Controls.Add(Me.ckNom)
        Me.GroupBox1.Controls.Add(Me.ckCode)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.MetroButton2)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.cmbClassification)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Controls.Add(Me.MetroComboBox4)
        Me.GroupBox1.Controls.Add(Me.cmbTypeRapport)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Open Sans Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1215, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtres"
        '
        'ckDetail
        '
        Me.ckDetail.AutoSize = True
        Me.ckDetail.Location = New System.Drawing.Point(840, 54)
        Me.ckDetail.Name = "ckDetail"
        Me.ckDetail.Size = New System.Drawing.Size(174, 15)
        Me.ckDetail.TabIndex = 20
        Me.ckDetail.Text = "Inclure tous les autres détails"
        Me.ckDetail.UseSelectable = True
        '
        'ckPredefini
        '
        Me.ckPredefini.AutoSize = True
        Me.ckPredefini.Location = New System.Drawing.Point(840, 32)
        Me.ckPredefini.Name = "ckPredefini"
        Me.ckPredefini.Size = New System.Drawing.Size(145, 15)
        Me.ckPredefini.TabIndex = 19
        Me.ckPredefini.Text = "Présentation prédéfinie"
        Me.ckPredefini.UseSelectable = True
        '
        'cmbAu
        '
        Me.cmbAu.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbAu.Location = New System.Drawing.Point(250, 98)
        Me.cmbAu.Name = "cmbAu"
        Me.cmbAu.Size = New System.Drawing.Size(126, 29)
        Me.cmbAu.TabIndex = 15
        '
        'cmbDu
        '
        Me.cmbDu.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.CustomFormat = ""
        Me.cmbDu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbDu.Location = New System.Drawing.Point(84, 98)
        Me.cmbDu.Name = "cmbDu"
        Me.cmbDu.Size = New System.Drawing.Size(126, 29)
        Me.cmbDu.TabIndex = 16
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(219, 102)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel4.TabIndex = 13
        Me.MetroLabel4.Text = "Au"
        '
        'ckClassification
        '
        Me.ckClassification.AutoSize = True
        Me.ckClassification.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckClassification.Location = New System.Drawing.Point(399, 110)
        Me.ckClassification.Name = "ckClassification"
        Me.ckClassification.Size = New System.Drawing.Size(114, 19)
        Me.ckClassification.TabIndex = 6
        Me.ckClassification.Text = "Classification : "
        Me.ckClassification.UseSelectable = True
        '
        'ckOrganiser
        '
        Me.ckOrganiser.AutoSize = True
        Me.ckOrganiser.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckOrganiser.Location = New System.Drawing.Point(399, 80)
        Me.ckOrganiser.Name = "ckOrganiser"
        Me.ckOrganiser.Size = New System.Drawing.Size(120, 19)
        Me.ckOrganiser.TabIndex = 6
        Me.ckOrganiser.Text = "Organiser par : "
        Me.ckOrganiser.UseSelectable = True
        '
        'ckNom
        '
        Me.ckNom.AutoSize = True
        Me.ckNom.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckNom.Location = New System.Drawing.Point(399, 50)
        Me.ckNom.Name = "ckNom"
        Me.ckNom.Size = New System.Drawing.Size(122, 19)
        Me.ckNom.TabIndex = 6
        Me.ckNom.Text = "Nom Employe : "
        Me.ckNom.UseSelectable = True
        '
        'ckCode
        '
        Me.ckCode.AutoSize = True
        Me.ckCode.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ckCode.Location = New System.Drawing.Point(399, 20)
        Me.ckCode.Name = "ckCode"
        Me.ckCode.Size = New System.Drawing.Size(124, 19)
        Me.ckCode.TabIndex = 6
        Me.ckCode.Text = "Code Employe : "
        Me.ckCode.UseSelectable = True
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.txtNom.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.Enabled = False
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(538, 49)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(210, 23)
        Me.txtNom.TabIndex = 5
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCode
        '
        '
        '
        '
        Me.txtCode.CustomButton.Image = Nothing
        Me.txtCode.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.txtCode.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.CustomButton.Name = ""
        Me.txtCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCode.CustomButton.TabIndex = 1
        Me.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCode.CustomButton.UseSelectable = True
        Me.txtCode.CustomButton.Visible = False
        Me.txtCode.Enabled = False
        Me.txtCode.Lines = New String(-1) {}
        Me.txtCode.Location = New System.Drawing.Point(538, 18)
        Me.txtCode.MaxLength = 32767
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCode.SelectedText = ""
        Me.txtCode.SelectionLength = 0
        Me.txtCode.SelectionStart = 0
        Me.txtCode.ShortcutsEnabled = True
        Me.txtCode.Size = New System.Drawing.Size(210, 23)
        Me.txtCode.TabIndex = 5
        Me.txtCode.UseSelectable = True
        Me.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(840, 89)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 32)
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "Vider"
        Me.MetroButton2.UseSelectable = True
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(946, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 32)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Recherche"
        Me.btnSearch.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(21, 102)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Periode : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 62)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Annee : "
        '
        'cmbClassification
        '
        Me.cmbClassification.Enabled = False
        Me.cmbClassification.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.ItemHeight = 19
        Me.cmbClassification.Items.AddRange(New Object() {"", "Stagiaire", "Volentaire", "Employees"})
        Me.cmbClassification.Location = New System.Drawing.Point(538, 107)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(210, 25)
        Me.cmbClassification.TabIndex = 1
        Me.cmbClassification.UseSelectable = True
        '
        'cmbAnnee
        '
        Me.cmbAnnee.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.ItemHeight = 19
        Me.cmbAnnee.Location = New System.Drawing.Point(138, 58)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.PromptText = "2015"
        Me.cmbAnnee.Size = New System.Drawing.Size(238, 25)
        Me.cmbAnnee.TabIndex = 1
        Me.cmbAnnee.UseSelectable = True
        '
        'MetroComboBox4
        '
        Me.MetroComboBox4.Enabled = False
        Me.MetroComboBox4.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox4.FormattingEnabled = True
        Me.MetroComboBox4.ItemHeight = 19
        Me.MetroComboBox4.Location = New System.Drawing.Point(538, 76)
        Me.MetroComboBox4.Name = "MetroComboBox4"
        Me.MetroComboBox4.Size = New System.Drawing.Size(210, 25)
        Me.MetroComboBox4.TabIndex = 1
        Me.MetroComboBox4.UseSelectable = True
        '
        'cmbTypeRapport
        '
        Me.cmbTypeRapport.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbTypeRapport.FormattingEnabled = True
        Me.cmbTypeRapport.ItemHeight = 19
        Me.cmbTypeRapport.Items.AddRange(New Object() {"Journalier", "Hebdomadaire", "Mensuel", "Trimestriel", "Annuel"})
        Me.cmbTypeRapport.Location = New System.Drawing.Point(138, 29)
        Me.cmbTypeRapport.Name = "cmbTypeRapport"
        Me.cmbTypeRapport.PromptText = "Mensuel"
        Me.cmbTypeRapport.Size = New System.Drawing.Size(238, 25)
        Me.cmbTypeRapport.TabIndex = 1
        Me.cmbTypeRapport.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(21, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type de rapport : "
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(92, 557)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Total des employes : "
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelTotal.Location = New System.Drawing.Point(237, 552)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(100, 30)
        Me.labelTotal.TabIndex = 3
        Me.labelTotal.Text = "0"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(414, 561)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel8.TabIndex = 2
        Me.MetroLabel8.Text = "Employes : "
        '
        'labelEmp
        '
        Me.labelEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelEmp.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelEmp.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelEmp.Location = New System.Drawing.Point(496, 554)
        Me.labelEmp.Name = "labelEmp"
        Me.labelEmp.Size = New System.Drawing.Size(100, 30)
        Me.labelEmp.TabIndex = 3
        Me.labelEmp.Text = "0"
        Me.labelEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(645, 559)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel10.TabIndex = 2
        Me.MetroLabel10.Text = "Volentaire : "
        '
        'labelVol
        '
        Me.labelVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelVol.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelVol.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelVol.Location = New System.Drawing.Point(734, 554)
        Me.labelVol.Name = "labelVol"
        Me.labelVol.Size = New System.Drawing.Size(100, 30)
        Me.labelVol.TabIndex = 3
        Me.labelVol.Text = "0"
        Me.labelVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(890, 559)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel12.TabIndex = 2
        Me.MetroLabel12.Text = "Stagiaire : "
        '
        'labelStg
        '
        Me.labelStg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelStg.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelStg.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelStg.Location = New System.Drawing.Point(968, 552)
        Me.labelStg.Name = "labelStg"
        Me.labelStg.Size = New System.Drawing.Size(100, 30)
        Me.labelStg.TabIndex = 3
        Me.labelStg.Text = "0"
        Me.labelStg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRapport
        '
        Me.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRapport.Location = New System.Drawing.Point(516, 606)
        Me.btnRapport.Name = "btnRapport"
        Me.btnRapport.Size = New System.Drawing.Size(128, 37)
        Me.btnRapport.TabIndex = 4
        Me.btnRapport.Text = "RAPPORT"
        Me.btnRapport.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(650, 606)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 37)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'ListEmployes
        '
        Me.ListEmployes.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListEmployes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader19, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader18, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader20})
        Me.ListEmployes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEmployes.FullRowSelect = True
        Me.ListEmployes.GridLines = True
        Me.ListEmployes.Location = New System.Drawing.Point(10, 153)
        Me.ListEmployes.Name = "ListEmployes"
        Me.ListEmployes.Size = New System.Drawing.Size(1215, 389)
        Me.ListEmployes.TabIndex = 5
        Me.ListEmployes.UseCompatibleStateImageBehavior = False
        Me.ListEmployes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "CODE"
        Me.ColumnHeader19.Width = 119
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOM"
        Me.ColumnHeader2.Width = 197
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRENOM"
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "EMAIL"
        Me.ColumnHeader4.Width = 172
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "POSTE"
        Me.ColumnHeader5.Width = 155
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DEPARTEMENT"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DEBUT CONTRACT"
        Me.ColumnHeader7.Width = 130
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "FIN CONTRACT"
        Me.ColumnHeader8.Width = 130
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "CLASSIFICATION"
        Me.ColumnHeader18.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "TAUX SALAIRE / PRIMER"
        Me.ColumnHeader9.Width = 200
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "SEXE"
        Me.ColumnHeader10.Width = 200
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DATE NAISSANCE"
        Me.ColumnHeader11.Width = 200
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "NATIONALITE"
        Me.ColumnHeader12.Width = 200
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ADRESSE"
        Me.ColumnHeader13.Width = 200
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "TEL. 1"
        Me.ColumnHeader14.Width = 200
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "TEL. 2"
        Me.ColumnHeader15.Width = 200
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "NOM CONTACT U."
        Me.ColumnHeader16.Width = 200
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "TEL. CONTACT U"
        Me.ColumnHeader17.Width = 200
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "index"
        Me.ColumnHeader20.Width = 0
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.ListEmployes)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.btnRapport)
        Me.PanelContainer.Controls.Add(Me.labelEmp)
        Me.PanelContainer.Controls.Add(Me.labelStg)
        Me.PanelContainer.Controls.Add(Me.MetroLabel5)
        Me.PanelContainer.Controls.Add(Me.MetroLabel12)
        Me.PanelContainer.Controls.Add(Me.labelTotal)
        Me.PanelContainer.Controls.Add(Me.labelVol)
        Me.PanelContainer.Controls.Add(Me.MetroLabel8)
        Me.PanelContainer.Controls.Add(Me.MetroLabel10)
        Me.PanelContainer.Location = New System.Drawing.Point(15, 55)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1237, 656)
        Me.PanelContainer.TabIndex = 6
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(382, 606)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(128, 37)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "EXPORTER"
        Me.MetroButton1.UseSelectable = True
        '
        'ListeEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 729)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeEmployees"
        Me.Text = "LISTE/RAPPORT DES EMPLOYES"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbTypeRapport As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbClassification As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbAnnee As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox4 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelEmp As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelVol As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelStg As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnRapport As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents ListEmployes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents ckClassification As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckOrganiser As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckNom As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckCode As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbAu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDu As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
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
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
End Class
