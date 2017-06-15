<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDonneur
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btSave = New MetroFramework.Controls.MetroButton()
        Me.btClean = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNote = New System.Windows.Forms.RichTextBox()
        Me.txtPeriodeSollicitation = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.cmbProcedure = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeDon = New MetroFramework.Controls.MetroComboBox()
        Me.txtPhone2 = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMail = New MetroFramework.Controls.MetroTextBox()
        Me.txtSite = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAdresse = New MetroFramework.Controls.MetroTextBox()
        Me.txtPoste = New MetroFramework.Controls.MetroTextBox()
        Me.txtNomRepresentant = New MetroFramework.Controls.MetroTextBox()
        Me.txtNomDonneur = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.cmbCategorieDonneur = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dt_date = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1346, 708)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnClose)
        Me.MetroPanel1.Controls.Add(Me.btSave)
        Me.MetroPanel1.Controls.Add(Me.btClean)
        Me.MetroPanel1.Controls.Add(Me.GroupBox2)
        Me.MetroPanel1.Controls.Add(Me.txtPhone2)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1340, 702)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(724, 571)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 32)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'btSave
        '
        Me.btSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSave.Location = New System.Drawing.Point(621, 571)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(96, 32)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "Enregistrer"
        Me.btSave.UseSelectable = True
        '
        'btClean
        '
        Me.btClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClean.Location = New System.Drawing.Point(520, 571)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(96, 32)
        Me.btClean.TabIndex = 5
        Me.btClean.Text = "Vider"
        Me.btClean.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNote)
        Me.GroupBox2.Controls.Add(Me.txtPeriodeSollicitation)
        Me.GroupBox2.Controls.Add(Me.MetroLabel15)
        Me.GroupBox2.Controls.Add(Me.MetroLabel14)
        Me.GroupBox2.Controls.Add(Me.MetroLabel13)
        Me.GroupBox2.Controls.Add(Me.MetroLabel12)
        Me.GroupBox2.Controls.Add(Me.cmbProcedure)
        Me.GroupBox2.Controls.Add(Me.cmbTypeDon)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(233, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(861, 193)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autres infos"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(359, 124)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(339, 53)
        Me.txtNote.TabIndex = 4
        Me.txtNote.Text = ""
        '
        'txtPeriodeSollicitation
        '
        '
        '
        '
        Me.txtPeriodeSollicitation.CustomButton.Image = Nothing
        Me.txtPeriodeSollicitation.CustomButton.Location = New System.Drawing.Point(317, 1)
        Me.txtPeriodeSollicitation.CustomButton.Name = ""
        Me.txtPeriodeSollicitation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPeriodeSollicitation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPeriodeSollicitation.CustomButton.TabIndex = 1
        Me.txtPeriodeSollicitation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPeriodeSollicitation.CustomButton.UseSelectable = True
        Me.txtPeriodeSollicitation.CustomButton.Visible = False
        Me.txtPeriodeSollicitation.Lines = New String(-1) {}
        Me.txtPeriodeSollicitation.Location = New System.Drawing.Point(359, 94)
        Me.txtPeriodeSollicitation.MaxLength = 32767
        Me.txtPeriodeSollicitation.Name = "txtPeriodeSollicitation"
        Me.txtPeriodeSollicitation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeriodeSollicitation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPeriodeSollicitation.SelectedText = ""
        Me.txtPeriodeSollicitation.SelectionLength = 0
        Me.txtPeriodeSollicitation.SelectionStart = 0
        Me.txtPeriodeSollicitation.ShortcutsEnabled = True
        Me.txtPeriodeSollicitation.Size = New System.Drawing.Size(339, 23)
        Me.txtPeriodeSollicitation.TabIndex = 3
        Me.txtPeriodeSollicitation.UseSelectable = True
        Me.txtPeriodeSollicitation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPeriodeSollicitation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(112, 158)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel15.TabIndex = 0
        Me.MetroLabel15.Text = "Note"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(112, 98)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(151, 19)
        Me.MetroLabel14.TabIndex = 0
        Me.MetroLabel14.Text = "Période de sollicitation"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(113, 63)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(153, 19)
        Me.MetroLabel13.TabIndex = 0
        Me.MetroLabel13.Text = "Procédure de donation"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(113, 26)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel12.TabIndex = 0
        Me.MetroLabel12.Text = "Type de don"
        '
        'cmbProcedure
        '
        Me.cmbProcedure.FormattingEnabled = True
        Me.cmbProcedure.ItemHeight = 23
        Me.cmbProcedure.Items.AddRange(New Object() {"Sollicité", "Non sollicité"})
        Me.cmbProcedure.Location = New System.Drawing.Point(359, 53)
        Me.cmbProcedure.Name = "cmbProcedure"
        Me.cmbProcedure.Size = New System.Drawing.Size(339, 29)
        Me.cmbProcedure.TabIndex = 2
        Me.cmbProcedure.UseSelectable = True
        '
        'cmbTypeDon
        '
        Me.cmbTypeDon.FormattingEnabled = True
        Me.cmbTypeDon.ItemHeight = 23
        Me.cmbTypeDon.Items.AddRange(New Object() {"Argent", "Matériel"})
        Me.cmbTypeDon.Location = New System.Drawing.Point(359, 16)
        Me.cmbTypeDon.Name = "cmbTypeDon"
        Me.cmbTypeDon.Size = New System.Drawing.Size(339, 29)
        Me.cmbTypeDon.TabIndex = 2
        Me.cmbTypeDon.UseSelectable = True
        '
        'txtPhone2
        '
        '
        '
        '
        Me.txtPhone2.CustomButton.Image = Nothing
        Me.txtPhone2.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtPhone2.CustomButton.Name = ""
        Me.txtPhone2.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPhone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone2.CustomButton.TabIndex = 1
        Me.txtPhone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone2.CustomButton.UseSelectable = True
        Me.txtPhone2.CustomButton.Visible = False
        Me.txtPhone2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPhone2.Lines = New String(-1) {}
        Me.txtPhone2.Location = New System.Drawing.Point(592, 257)
        Me.txtPhone2.MaxLength = 32767
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone2.SelectedText = ""
        Me.txtPhone2.SelectionLength = 0
        Me.txtPhone2.SelectionStart = 0
        Me.txtPhone2.ShortcutsEnabled = True
        Me.txtPhone2.Size = New System.Drawing.Size(339, 30)
        Me.txtPhone2.TabIndex = 3
        Me.txtPhone2.UseSelectable = True
        Me.txtPhone2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.txtSite)
        Me.GroupBox1.Controls.Add(Me.txtPhone1)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.txtPoste)
        Me.GroupBox1.Controls.Add(Me.txtNomRepresentant)
        Me.GroupBox1.Controls.Add(Me.txtNomDonneur)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.cmbCategorieDonneur)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.dt_date)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(233, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 363)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info générale"
        '
        'txtMail
        '
        '
        '
        '
        Me.txtMail.CustomButton.Image = Nothing
        Me.txtMail.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtMail.CustomButton.Name = ""
        Me.txtMail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMail.CustomButton.TabIndex = 1
        Me.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMail.CustomButton.UseSelectable = True
        Me.txtMail.CustomButton.Visible = False
        Me.txtMail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMail.Lines = New String(-1) {}
        Me.txtMail.Location = New System.Drawing.Point(359, 323)
        Me.txtMail.MaxLength = 32767
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMail.SelectedText = ""
        Me.txtMail.SelectionLength = 0
        Me.txtMail.SelectionStart = 0
        Me.txtMail.ShortcutsEnabled = True
        Me.txtMail.Size = New System.Drawing.Size(339, 30)
        Me.txtMail.TabIndex = 3
        Me.txtMail.UseSelectable = True
        Me.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSite
        '
        '
        '
        '
        Me.txtSite.CustomButton.Image = Nothing
        Me.txtSite.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtSite.CustomButton.Name = ""
        Me.txtSite.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSite.CustomButton.TabIndex = 1
        Me.txtSite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSite.CustomButton.UseSelectable = True
        Me.txtSite.CustomButton.Visible = False
        Me.txtSite.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSite.Lines = New String(-1) {}
        Me.txtSite.Location = New System.Drawing.Point(359, 289)
        Me.txtSite.MaxLength = 32767
        Me.txtSite.Name = "txtSite"
        Me.txtSite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSite.SelectedText = ""
        Me.txtSite.SelectionLength = 0
        Me.txtSite.SelectionStart = 0
        Me.txtSite.ShortcutsEnabled = True
        Me.txtSite.Size = New System.Drawing.Size(339, 30)
        Me.txtSite.TabIndex = 3
        Me.txtSite.UseSelectable = True
        Me.txtSite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone1
        '
        '
        '
        '
        Me.txtPhone1.CustomButton.Image = Nothing
        Me.txtPhone1.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtPhone1.CustomButton.Name = ""
        Me.txtPhone1.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPhone1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone1.CustomButton.TabIndex = 1
        Me.txtPhone1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone1.CustomButton.UseSelectable = True
        Me.txtPhone1.CustomButton.Visible = False
        Me.txtPhone1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPhone1.Lines = New String(-1) {}
        Me.txtPhone1.Location = New System.Drawing.Point(359, 221)
        Me.txtPhone1.MaxLength = 32767
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone1.SelectedText = ""
        Me.txtPhone1.SelectionLength = 0
        Me.txtPhone1.SelectionStart = 0
        Me.txtPhone1.ShortcutsEnabled = True
        Me.txtPhone1.Size = New System.Drawing.Size(339, 30)
        Me.txtPhone1.TabIndex = 3
        Me.txtPhone1.UseSelectable = True
        Me.txtPhone1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAdresse
        '
        '
        '
        '
        Me.txtAdresse.CustomButton.Image = Nothing
        Me.txtAdresse.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtAdresse.CustomButton.Name = ""
        Me.txtAdresse.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresse.CustomButton.TabIndex = 1
        Me.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresse.CustomButton.UseSelectable = True
        Me.txtAdresse.CustomButton.Visible = False
        Me.txtAdresse.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAdresse.Lines = New String(-1) {}
        Me.txtAdresse.Location = New System.Drawing.Point(359, 187)
        Me.txtAdresse.MaxLength = 32767
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresse.SelectedText = ""
        Me.txtAdresse.SelectionLength = 0
        Me.txtAdresse.SelectionStart = 0
        Me.txtAdresse.ShortcutsEnabled = True
        Me.txtAdresse.Size = New System.Drawing.Size(339, 30)
        Me.txtAdresse.TabIndex = 3
        Me.txtAdresse.UseSelectable = True
        Me.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPoste
        '
        '
        '
        '
        Me.txtPoste.CustomButton.Image = Nothing
        Me.txtPoste.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtPoste.CustomButton.Name = ""
        Me.txtPoste.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPoste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPoste.CustomButton.TabIndex = 1
        Me.txtPoste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPoste.CustomButton.UseSelectable = True
        Me.txtPoste.CustomButton.Visible = False
        Me.txtPoste.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPoste.Lines = New String(-1) {}
        Me.txtPoste.Location = New System.Drawing.Point(359, 152)
        Me.txtPoste.MaxLength = 32767
        Me.txtPoste.Name = "txtPoste"
        Me.txtPoste.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoste.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPoste.SelectedText = ""
        Me.txtPoste.SelectionLength = 0
        Me.txtPoste.SelectionStart = 0
        Me.txtPoste.ShortcutsEnabled = True
        Me.txtPoste.Size = New System.Drawing.Size(339, 30)
        Me.txtPoste.TabIndex = 3
        Me.txtPoste.UseSelectable = True
        Me.txtPoste.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPoste.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNomRepresentant
        '
        '
        '
        '
        Me.txtNomRepresentant.CustomButton.Image = Nothing
        Me.txtNomRepresentant.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtNomRepresentant.CustomButton.Name = ""
        Me.txtNomRepresentant.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNomRepresentant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNomRepresentant.CustomButton.TabIndex = 1
        Me.txtNomRepresentant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNomRepresentant.CustomButton.UseSelectable = True
        Me.txtNomRepresentant.CustomButton.Visible = False
        Me.txtNomRepresentant.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNomRepresentant.Lines = New String(-1) {}
        Me.txtNomRepresentant.Location = New System.Drawing.Point(359, 119)
        Me.txtNomRepresentant.MaxLength = 32767
        Me.txtNomRepresentant.Name = "txtNomRepresentant"
        Me.txtNomRepresentant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomRepresentant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNomRepresentant.SelectedText = ""
        Me.txtNomRepresentant.SelectionLength = 0
        Me.txtNomRepresentant.SelectionStart = 0
        Me.txtNomRepresentant.ShortcutsEnabled = True
        Me.txtNomRepresentant.Size = New System.Drawing.Size(339, 30)
        Me.txtNomRepresentant.TabIndex = 3
        Me.txtNomRepresentant.UseSelectable = True
        Me.txtNomRepresentant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNomRepresentant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNomDonneur
        '
        '
        '
        '
        Me.txtNomDonneur.CustomButton.Image = Nothing
        Me.txtNomDonneur.CustomButton.Location = New System.Drawing.Point(311, 2)
        Me.txtNomDonneur.CustomButton.Name = ""
        Me.txtNomDonneur.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNomDonneur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNomDonneur.CustomButton.TabIndex = 1
        Me.txtNomDonneur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNomDonneur.CustomButton.UseSelectable = True
        Me.txtNomDonneur.CustomButton.Visible = False
        Me.txtNomDonneur.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNomDonneur.Lines = New String(-1) {}
        Me.txtNomDonneur.Location = New System.Drawing.Point(359, 84)
        Me.txtNomDonneur.MaxLength = 32767
        Me.txtNomDonneur.Name = "txtNomDonneur"
        Me.txtNomDonneur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomDonneur.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNomDonneur.SelectedText = ""
        Me.txtNomDonneur.SelectionLength = 0
        Me.txtNomDonneur.SelectionStart = 0
        Me.txtNomDonneur.ShortcutsEnabled = True
        Me.txtNomDonneur.Size = New System.Drawing.Size(339, 30)
        Me.txtNomDonneur.TabIndex = 3
        Me.txtNomDonneur.UseSelectable = True
        Me.txtNomDonneur.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNomDonneur.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(112, 329)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel11.TabIndex = 0
        Me.MetroLabel11.Text = "Email"
        '
        'cmbCategorieDonneur
        '
        Me.cmbCategorieDonneur.FormattingEnabled = True
        Me.cmbCategorieDonneur.ItemHeight = 23
        Me.cmbCategorieDonneur.Location = New System.Drawing.Point(359, 49)
        Me.cmbCategorieDonneur.Name = "cmbCategorieDonneur"
        Me.cmbCategorieDonneur.Size = New System.Drawing.Size(339, 29)
        Me.cmbCategorieDonneur.TabIndex = 2
        Me.cmbCategorieDonneur.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(112, 295)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "SIte internet"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(112, 259)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "Phone2"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(112, 227)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel7.TabIndex = 0
        Me.MetroLabel7.Text = "Phone1"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(112, 193)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "Adresse"
        '
        'dt_date
        '
        Me.dt_date.Location = New System.Drawing.Point(359, 18)
        Me.dt_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(339, 29)
        Me.dt_date.TabIndex = 1
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(112, 158)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "Poste"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(112, 128)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(145, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Nom du représentant"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(112, 95)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Nom du donneur"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(112, 65)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Catégorie donneur"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(112, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Date"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(346, 292)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel8.TabIndex = 0
        Me.MetroLabel8.Text = "Phone2"
        '
        'AddDonneur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AddDonneur"
        Me.Text = "DONNEUR : NOUVEAU DONNEUR"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPoste As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNomRepresentant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNomDonneur As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbCategorieDonneur As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dt_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPhone2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAdresse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btClean As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNote As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPeriodeSollicitation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbProcedure As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeDon As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtMail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
End Class
