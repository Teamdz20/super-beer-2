<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MajRevenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbActivite = New MetroFramework.Controls.MetroComboBox()
        Me.idRev = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtMemo = New System.Windows.Forms.RichTextBox()
        Me.txtReglement = New MetroFramework.Controls.MetroTextBox()
        Me.txtPoste = New MetroFramework.Controls.MetroTextBox()
        Me.cmbRecuDe = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDevise = New MetroFramework.Controls.MetroComboBox()
        Me.txtMontant = New MetroFramework.Controls.MetroTextBox()
        Me.cbNomManager = New MetroFramework.Controls.MetroComboBox()
        Me.cmbType = New MetroFramework.Controls.MetroComboBox()
        Me.cmbClass = New MetroFramework.Controls.MetroComboBox()
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.btSave = New MetroFramework.Controls.MetroButton()
        Me.btVider = New MetroFramework.Controls.MetroButton()
        Me.ListRevenu = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbRechType = New System.Windows.Forms.ComboBox()
        Me.cmbAnnee = New System.Windows.Forms.ComboBox()
        Me.cmbMois = New System.Windows.Forms.ComboBox()
        Me.btSearch = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbActivite)
        Me.GroupBox1.Controls.Add(Me.idRev)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.txtMemo)
        Me.GroupBox1.Controls.Add(Me.txtReglement)
        Me.GroupBox1.Controls.Add(Me.txtPoste)
        Me.GroupBox1.Controls.Add(Me.cmbRecuDe)
        Me.GroupBox1.Controls.Add(Me.cmbDevise)
        Me.GroupBox1.Controls.Add(Me.txtMontant)
        Me.GroupBox1.Controls.Add(Me.cbNomManager)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.cmbClass)
        Me.GroupBox1.Controls.Add(Me.dtDate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel13)
        Me.GroupBox1.Controls.Add(Me.MetroLabel14)
        Me.GroupBox1.Controls.Add(Me.MetroLabel15)
        Me.GroupBox1.Controls.Add(Me.MetroLabel16)
        Me.GroupBox1.Controls.Add(Me.MetroLabel17)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(997, 296)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Uniquement pour les revenus provenat des AGRs"
        '
        'cmbActivite
        '
        Me.cmbActivite.FormattingEnabled = True
        Me.cmbActivite.ItemHeight = 23
        Me.cmbActivite.Location = New System.Drawing.Point(169, 169)
        Me.cmbActivite.Name = "cmbActivite"
        Me.cmbActivite.Size = New System.Drawing.Size(303, 29)
        Me.cmbActivite.TabIndex = 51
        Me.cmbActivite.UseSelectable = True
        '
        'idRev
        '
        '
        '
        '
        Me.idRev.CustomButton.Image = Nothing
        Me.idRev.CustomButton.Location = New System.Drawing.Point(37, 1)
        Me.idRev.CustomButton.Name = ""
        Me.idRev.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.idRev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.idRev.CustomButton.TabIndex = 1
        Me.idRev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.idRev.CustomButton.UseSelectable = True
        Me.idRev.CustomButton.Visible = False
        Me.idRev.Lines = New String(-1) {}
        Me.idRev.Location = New System.Drawing.Point(69, 28)
        Me.idRev.MaxLength = 32767
        Me.idRev.Name = "idRev"
        Me.idRev.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idRev.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.idRev.SelectedText = ""
        Me.idRev.SelectionLength = 0
        Me.idRev.SelectionStart = 0
        Me.idRev.ShortcutsEnabled = True
        Me.idRev.Size = New System.Drawing.Size(59, 23)
        Me.idRev.TabIndex = 50
        Me.idRev.UseSelectable = True
        Me.idRev.Visible = False
        Me.idRev.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.idRev.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 32)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel2.TabIndex = 49
        Me.MetroLabel2.Text = "idRev :"
        Me.MetroLabel2.Visible = False
        '
        'txtMemo
        '
        Me.txtMemo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemo.Location = New System.Drawing.Point(668, 212)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(303, 63)
        Me.txtMemo.TabIndex = 46
        Me.txtMemo.Text = ""
        '
        'txtReglement
        '
        '
        '
        '
        Me.txtReglement.CustomButton.Image = Nothing
        Me.txtReglement.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtReglement.CustomButton.Name = ""
        Me.txtReglement.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtReglement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReglement.CustomButton.TabIndex = 1
        Me.txtReglement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReglement.CustomButton.UseSelectable = True
        Me.txtReglement.CustomButton.Visible = False
        Me.txtReglement.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtReglement.Lines = New String(-1) {}
        Me.txtReglement.Location = New System.Drawing.Point(668, 169)
        Me.txtReglement.MaxLength = 32767
        Me.txtReglement.Name = "txtReglement"
        Me.txtReglement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReglement.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReglement.SelectedText = ""
        Me.txtReglement.SelectionLength = 0
        Me.txtReglement.SelectionStart = 0
        Me.txtReglement.ShortcutsEnabled = True
        Me.txtReglement.Size = New System.Drawing.Size(303, 30)
        Me.txtReglement.TabIndex = 44
        Me.txtReglement.UseSelectable = True
        Me.txtReglement.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReglement.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPoste
        '
        '
        '
        '
        Me.txtPoste.CustomButton.Image = Nothing
        Me.txtPoste.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtPoste.CustomButton.Name = ""
        Me.txtPoste.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPoste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPoste.CustomButton.TabIndex = 1
        Me.txtPoste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPoste.CustomButton.UseSelectable = True
        Me.txtPoste.CustomButton.Visible = False
        Me.txtPoste.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPoste.Lines = New String(-1) {}
        Me.txtPoste.Location = New System.Drawing.Point(668, 129)
        Me.txtPoste.MaxLength = 32767
        Me.txtPoste.Name = "txtPoste"
        Me.txtPoste.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoste.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPoste.SelectedText = ""
        Me.txtPoste.SelectionLength = 0
        Me.txtPoste.SelectionStart = 0
        Me.txtPoste.ShortcutsEnabled = True
        Me.txtPoste.Size = New System.Drawing.Size(303, 30)
        Me.txtPoste.TabIndex = 43
        Me.txtPoste.UseSelectable = True
        Me.txtPoste.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPoste.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbRecuDe
        '
        Me.cmbRecuDe.FormattingEnabled = True
        Me.cmbRecuDe.ItemHeight = 23
        Me.cmbRecuDe.Location = New System.Drawing.Point(668, 90)
        Me.cmbRecuDe.Name = "cmbRecuDe"
        Me.cmbRecuDe.Size = New System.Drawing.Size(303, 29)
        Me.cmbRecuDe.TabIndex = 42
        Me.cmbRecuDe.UseSelectable = True
        '
        'cmbDevise
        '
        Me.cmbDevise.FormattingEnabled = True
        Me.cmbDevise.ItemHeight = 23
        Me.cmbDevise.Location = New System.Drawing.Point(667, 52)
        Me.cmbDevise.Name = "cmbDevise"
        Me.cmbDevise.Size = New System.Drawing.Size(303, 29)
        Me.cmbDevise.TabIndex = 41
        Me.cmbDevise.UseSelectable = True
        '
        'txtMontant
        '
        '
        '
        '
        Me.txtMontant.CustomButton.Image = Nothing
        Me.txtMontant.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtMontant.CustomButton.Name = ""
        Me.txtMontant.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontant.CustomButton.TabIndex = 1
        Me.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontant.CustomButton.UseSelectable = True
        Me.txtMontant.CustomButton.Visible = False
        Me.txtMontant.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontant.Lines = New String(-1) {}
        Me.txtMontant.Location = New System.Drawing.Point(169, 250)
        Me.txtMontant.MaxLength = 32767
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontant.SelectedText = ""
        Me.txtMontant.SelectionLength = 0
        Me.txtMontant.SelectionStart = 0
        Me.txtMontant.ShortcutsEnabled = True
        Me.txtMontant.Size = New System.Drawing.Size(303, 30)
        Me.txtMontant.TabIndex = 40
        Me.txtMontant.UseSelectable = True
        Me.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbNomManager
        '
        Me.cbNomManager.FormattingEnabled = True
        Me.cbNomManager.ItemHeight = 23
        Me.cbNomManager.Location = New System.Drawing.Point(169, 211)
        Me.cbNomManager.Name = "cbNomManager"
        Me.cbNomManager.Size = New System.Drawing.Size(303, 29)
        Me.cbNomManager.TabIndex = 39
        Me.cbNomManager.UseSelectable = True
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 23
        Me.cmbType.Location = New System.Drawing.Point(169, 130)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(303, 29)
        Me.cmbType.TabIndex = 38
        Me.cmbType.UseSelectable = True
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.ItemHeight = 23
        Me.cmbClass.Location = New System.Drawing.Point(169, 90)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(303, 29)
        Me.cmbClass.TabIndex = 36
        Me.cmbClass.UseSelectable = True
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(169, 52)
        Me.dtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(303, 29)
        Me.dtDate.TabIndex = 35
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(515, 216)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel11.TabIndex = 34
        Me.MetroLabel11.Text = "Memo :"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(515, 175)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel10.TabIndex = 33
        Me.MetroLabel10.Text = "En réglement de :"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(515, 135)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel9.TabIndex = 32
        Me.MetroLabel9.Text = "Poste :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(515, 95)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel8.TabIndex = 31
        Me.MetroLabel8.Text = "Reçu de :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(515, 57)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel7.TabIndex = 30
        Me.MetroLabel7.Text = "Devise :"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(16, 256)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(153, 19)
        Me.MetroLabel12.TabIndex = 29
        Me.MetroLabel12.Text = "Montant à enregistrer :"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(16, 216)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel13.TabIndex = 28
        Me.MetroLabel13.Text = "Nom du manager :"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(16, 175)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel14.TabIndex = 27
        Me.MetroLabel14.Text = "Code revenu"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(16, 135)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel15.TabIndex = 26
        Me.MetroLabel15.Text = "Type AGR"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(16, 95)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(137, 19)
        Me.MetroLabel16.TabIndex = 25
        Me.MetroLabel16.Text = "Classification revenu"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(16, 57)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel17.TabIndex = 24
        Me.MetroLabel17.Text = "Date :"
        '
        'btSave
        '
        Me.btSave.AutoSize = True
        Me.btSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSave.Location = New System.Drawing.Point(447, 607)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(111, 35)
        Me.btSave.TabIndex = 48
        Me.btSave.Text = "Mettre à jour"
        Me.btSave.UseSelectable = True
        '
        'btVider
        '
        Me.btVider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVider.Location = New System.Drawing.Point(328, 607)
        Me.btVider.Name = "btVider"
        Me.btVider.Size = New System.Drawing.Size(111, 35)
        Me.btVider.TabIndex = 47
        Me.btVider.Text = "Vider"
        Me.btVider.UseSelectable = True
        '
        'ListRevenu
        '
        Me.ListRevenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListRevenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListRevenu.FullRowSelect = True
        Me.ListRevenu.GridLines = True
        Me.ListRevenu.Location = New System.Drawing.Point(5, 97)
        Me.ListRevenu.Name = "ListRevenu"
        Me.ListRevenu.Size = New System.Drawing.Size(997, 187)
        Me.ListRevenu.TabIndex = 0
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
        Me.ColumnHeader6.Width = 188
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOM MANAGER"
        Me.ColumnHeader2.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "MONTANT ENREGISTRE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 148
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "RECU DE"
        Me.ColumnHeader4.Width = 197
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "EN REGLEMENT DE"
        Me.ColumnHeader5.Width = 277
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "devise"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "memo"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "classification"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "date"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "activite_financier_id"
        Me.ColumnHeader8.Width = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbRechType)
        Me.GroupBox3.Controls.Add(Me.cmbAnnee)
        Me.GroupBox3.Controls.Add(Me.cmbMois)
        Me.GroupBox3.Controls.Add(Me.btSearch)
        Me.GroupBox3.Controls.Add(Me.MetroButton1)
        Me.GroupBox3.Controls.Add(Me.MetroLabel3)
        Me.GroupBox3.Controls.Add(Me.MetroLabel5)
        Me.GroupBox3.Controls.Add(Me.MetroLabel4)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(997, 85)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche rapide"
        '
        'cmbRechType
        '
        Me.cmbRechType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRechType.FormattingEnabled = True
        Me.cmbRechType.Location = New System.Drawing.Point(512, 31)
        Me.cmbRechType.Name = "cmbRechType"
        Me.cmbRechType.Size = New System.Drawing.Size(234, 29)
        Me.cmbRechType.TabIndex = 12
        '
        'cmbAnnee
        '
        Me.cmbAnnee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.Location = New System.Drawing.Point(80, 31)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(111, 29)
        Me.cmbAnnee.TabIndex = 11
        '
        'cmbMois
        '
        Me.cmbMois.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMois.FormattingEnabled = True
        Me.cmbMois.Location = New System.Drawing.Point(262, 31)
        Me.cmbMois.Name = "cmbMois"
        Me.cmbMois.Size = New System.Drawing.Size(121, 29)
        Me.cmbMois.TabIndex = 10
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Location = New System.Drawing.Point(882, 31)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(87, 28)
        Me.btSearch.TabIndex = 8
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(790, 31)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(87, 28)
        Me.MetroButton1.TabIndex = 7
        Me.MetroButton1.Text = "Vider"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 36)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Année :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(420, 36)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Type AGR :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(212, 36)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Mois :"
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.ListRevenu)
        Me.PanelContainer.Controls.Add(Me.GroupBox3)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.btSave)
        Me.PanelContainer.Controls.Add(Me.btVider)
        Me.PanelContainer.Location = New System.Drawing.Point(23, 60)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1005, 670)
        Me.PanelContainer.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(566, 607)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 35)
        Me.btnClose.TabIndex = 49
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'MajRevenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 753)
        Me.Controls.Add(Me.PanelContainer)
        Me.Name = "MajRevenu"
        Me.Text = "REVENUS : VUE/MISE A JOUR REVENUS"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btVider As MetroFramework.Controls.MetroButton
    Friend WithEvents txtMemo As System.Windows.Forms.RichTextBox
    Friend WithEvents txtReglement As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPoste As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbRecuDe As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDevise As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtMontant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbNomManager As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbClass As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListRevenu As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbRechType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMois As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents idRev As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbActivite As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
