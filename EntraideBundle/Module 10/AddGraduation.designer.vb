<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGraduation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddGraduation))
        Me.cmbDate = New MetroFramework.Controls.MetroDateTime()
        Me.btAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtNote = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEtudiant = New System.Windows.Forms.ComboBox()
        Me.txtFormation = New MetroFramework.Controls.MetroTextBox()
        Me.txtDateInscription = New MetroFramework.Controls.MetroTextBox()
        Me.txtGeneration = New MetroFramework.Controls.MetroTextBox()
        Me.txtSexe = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtAdresse = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrenom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtTel = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDate
        '
        Me.cmbDate.Location = New System.Drawing.Point(396, 245)
        Me.cmbDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(307, 29)
        Me.cmbDate.TabIndex = 4
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Location = New System.Drawing.Point(337, 392)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(121, 36)
        Me.btAdd.TabIndex = 2
        Me.btAdd.Text = "ENREGISTRER"
        Me.btAdd.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(219, 320)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Note"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(219, 250)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Date de graduation"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(187, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(165, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Sélectionnez un étudiant"
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(464, 392)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(121, 36)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'txtNote
        '
        '
        '
        '
        Me.txtNote.CustomButton.Image = Nothing
        Me.txtNote.CustomButton.Location = New System.Drawing.Point(219, 1)
        Me.txtNote.CustomButton.Name = ""
        Me.txtNote.CustomButton.Size = New System.Drawing.Size(87, 87)
        Me.txtNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNote.CustomButton.TabIndex = 1
        Me.txtNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNote.CustomButton.UseSelectable = True
        Me.txtNote.CustomButton.Visible = False
        Me.txtNote.Lines = New String(-1) {}
        Me.txtNote.Location = New System.Drawing.Point(396, 285)
        Me.txtNote.MaxLength = 32767
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNote.SelectedText = ""
        Me.txtNote.SelectionLength = 0
        Me.txtNote.SelectionStart = 0
        Me.txtNote.ShortcutsEnabled = True
        Me.txtNote.Size = New System.Drawing.Size(307, 89)
        Me.txtNote.TabIndex = 7
        Me.txtNote.UseSelectable = True
        Me.txtNote.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNote.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEtudiant)
        Me.GroupBox1.Controls.Add(Me.txtFormation)
        Me.GroupBox1.Controls.Add(Me.txtDateInscription)
        Me.GroupBox1.Controls.Add(Me.txtGeneration)
        Me.GroupBox1.Controls.Add(Me.txtSexe)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.txtPrenom)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 223)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Etudiant"
        '
        'cmbEtudiant
        '
        Me.cmbEtudiant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEtudiant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEtudiant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEtudiant.FormattingEnabled = True
        Me.cmbEtudiant.Location = New System.Drawing.Point(358, 27)
        Me.cmbEtudiant.Name = "cmbEtudiant"
        Me.cmbEtudiant.Size = New System.Drawing.Size(344, 29)
        Me.cmbEtudiant.TabIndex = 5
        '
        'txtFormation
        '
        '
        '
        '
        Me.txtFormation.CustomButton.Image = Nothing
        Me.txtFormation.CustomButton.Location = New System.Drawing.Point(280, 2)
        Me.txtFormation.CustomButton.Name = ""
        Me.txtFormation.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtFormation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFormation.CustomButton.TabIndex = 1
        Me.txtFormation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFormation.CustomButton.UseSelectable = True
        Me.txtFormation.CustomButton.Visible = False
        Me.txtFormation.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFormation.Lines = New String(-1) {}
        Me.txtFormation.Location = New System.Drawing.Point(552, 176)
        Me.txtFormation.MaxLength = 32767
        Me.txtFormation.Name = "txtFormation"
        Me.txtFormation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFormation.ReadOnly = True
        Me.txtFormation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFormation.SelectedText = ""
        Me.txtFormation.SelectionLength = 0
        Me.txtFormation.SelectionStart = 0
        Me.txtFormation.ShortcutsEnabled = True
        Me.txtFormation.Size = New System.Drawing.Size(308, 30)
        Me.txtFormation.TabIndex = 4
        Me.txtFormation.UseSelectable = True
        Me.txtFormation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFormation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDateInscription
        '
        '
        '
        '
        Me.txtDateInscription.CustomButton.Image = Nothing
        Me.txtDateInscription.CustomButton.Location = New System.Drawing.Point(265, 2)
        Me.txtDateInscription.CustomButton.Name = ""
        Me.txtDateInscription.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtDateInscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDateInscription.CustomButton.TabIndex = 1
        Me.txtDateInscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDateInscription.CustomButton.UseSelectable = True
        Me.txtDateInscription.CustomButton.Visible = False
        Me.txtDateInscription.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDateInscription.Lines = New String(-1) {}
        Me.txtDateInscription.Location = New System.Drawing.Point(112, 176)
        Me.txtDateInscription.MaxLength = 32767
        Me.txtDateInscription.Name = "txtDateInscription"
        Me.txtDateInscription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDateInscription.ReadOnly = True
        Me.txtDateInscription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDateInscription.SelectedText = ""
        Me.txtDateInscription.SelectionLength = 0
        Me.txtDateInscription.SelectionStart = 0
        Me.txtDateInscription.ShortcutsEnabled = True
        Me.txtDateInscription.Size = New System.Drawing.Size(293, 30)
        Me.txtDateInscription.TabIndex = 4
        Me.txtDateInscription.UseSelectable = True
        Me.txtDateInscription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDateInscription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGeneration
        '
        '
        '
        '
        Me.txtGeneration.CustomButton.Image = Nothing
        Me.txtGeneration.CustomButton.Location = New System.Drawing.Point(280, 2)
        Me.txtGeneration.CustomButton.Name = ""
        Me.txtGeneration.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtGeneration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGeneration.CustomButton.TabIndex = 1
        Me.txtGeneration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGeneration.CustomButton.UseSelectable = True
        Me.txtGeneration.CustomButton.Visible = False
        Me.txtGeneration.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtGeneration.Lines = New String(-1) {}
        Me.txtGeneration.Location = New System.Drawing.Point(552, 140)
        Me.txtGeneration.MaxLength = 32767
        Me.txtGeneration.Name = "txtGeneration"
        Me.txtGeneration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGeneration.ReadOnly = True
        Me.txtGeneration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGeneration.SelectedText = ""
        Me.txtGeneration.SelectionLength = 0
        Me.txtGeneration.SelectionStart = 0
        Me.txtGeneration.ShortcutsEnabled = True
        Me.txtGeneration.Size = New System.Drawing.Size(308, 30)
        Me.txtGeneration.TabIndex = 4
        Me.txtGeneration.UseSelectable = True
        Me.txtGeneration.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGeneration.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSexe
        '
        '
        '
        '
        Me.txtSexe.CustomButton.Image = Nothing
        Me.txtSexe.CustomButton.Location = New System.Drawing.Point(265, 2)
        Me.txtSexe.CustomButton.Name = ""
        Me.txtSexe.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSexe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSexe.CustomButton.TabIndex = 1
        Me.txtSexe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSexe.CustomButton.UseSelectable = True
        Me.txtSexe.CustomButton.Visible = False
        Me.txtSexe.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSexe.Lines = New String(-1) {}
        Me.txtSexe.Location = New System.Drawing.Point(112, 140)
        Me.txtSexe.MaxLength = 32767
        Me.txtSexe.Name = "txtSexe"
        Me.txtSexe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSexe.ReadOnly = True
        Me.txtSexe.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSexe.SelectedText = ""
        Me.txtSexe.SelectionLength = 0
        Me.txtSexe.SelectionStart = 0
        Me.txtSexe.ShortcutsEnabled = True
        Me.txtSexe.Size = New System.Drawing.Size(293, 30)
        Me.txtSexe.TabIndex = 4
        Me.txtSexe.UseSelectable = True
        Me.txtSexe.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSexe.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(444, 182)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel11.TabIndex = 0
        Me.MetroLabel11.Text = "FORMATION :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(22, 182)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel7.TabIndex = 0
        Me.MetroLabel7.Text = "INSCRIT LE :"
        '
        'txtAdresse
        '
        '
        '
        '
        Me.txtAdresse.CustomButton.Image = Nothing
        Me.txtAdresse.CustomButton.Location = New System.Drawing.Point(280, 2)
        Me.txtAdresse.CustomButton.Name = ""
        Me.txtAdresse.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresse.CustomButton.TabIndex = 1
        Me.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresse.CustomButton.UseSelectable = True
        Me.txtAdresse.CustomButton.Visible = False
        Me.txtAdresse.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAdresse.Lines = New String(-1) {}
        Me.txtAdresse.Location = New System.Drawing.Point(552, 104)
        Me.txtAdresse.MaxLength = 32767
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresse.ReadOnly = True
        Me.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresse.SelectedText = ""
        Me.txtAdresse.SelectionLength = 0
        Me.txtAdresse.SelectionStart = 0
        Me.txtAdresse.ShortcutsEnabled = True
        Me.txtAdresse.Size = New System.Drawing.Size(308, 30)
        Me.txtAdresse.TabIndex = 4
        Me.txtAdresse.UseSelectable = True
        Me.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrenom
        '
        '
        '
        '
        Me.txtPrenom.CustomButton.Image = Nothing
        Me.txtPrenom.CustomButton.Location = New System.Drawing.Point(265, 2)
        Me.txtPrenom.CustomButton.Name = ""
        Me.txtPrenom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrenom.CustomButton.TabIndex = 1
        Me.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrenom.CustomButton.UseSelectable = True
        Me.txtPrenom.CustomButton.Visible = False
        Me.txtPrenom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrenom.Lines = New String(-1) {}
        Me.txtPrenom.Location = New System.Drawing.Point(112, 104)
        Me.txtPrenom.MaxLength = 32767
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrenom.ReadOnly = True
        Me.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrenom.SelectedText = ""
        Me.txtPrenom.SelectionLength = 0
        Me.txtPrenom.SelectionStart = 0
        Me.txtPrenom.ShortcutsEnabled = True
        Me.txtPrenom.Size = New System.Drawing.Size(293, 30)
        Me.txtPrenom.TabIndex = 4
        Me.txtPrenom.UseSelectable = True
        Me.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrenom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(444, 146)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "GENERATION :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(22, 146)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "SEXE :"
        '
        'txtTel
        '
        '
        '
        '
        Me.txtTel.CustomButton.Image = Nothing
        Me.txtTel.CustomButton.Location = New System.Drawing.Point(280, 2)
        Me.txtTel.CustomButton.Name = ""
        Me.txtTel.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTel.CustomButton.TabIndex = 1
        Me.txtTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTel.CustomButton.UseSelectable = True
        Me.txtTel.CustomButton.Visible = False
        Me.txtTel.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTel.Lines = New String(-1) {}
        Me.txtTel.Location = New System.Drawing.Point(552, 69)
        Me.txtTel.MaxLength = 32767
        Me.txtTel.Name = "txtTel"
        Me.txtTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.ReadOnly = True
        Me.txtTel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTel.SelectedText = ""
        Me.txtTel.SelectionLength = 0
        Me.txtTel.SelectionStart = 0
        Me.txtTel.ShortcutsEnabled = True
        Me.txtTel.Size = New System.Drawing.Size(308, 30)
        Me.txtTel.TabIndex = 4
        Me.txtTel.UseSelectable = True
        Me.txtTel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(444, 110)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "ADRESSE :"
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(265, 2)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(112, 69)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ReadOnly = True
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(293, 30)
        Me.txtNom.TabIndex = 4
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(444, 75)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel8.TabIndex = 0
        Me.MetroLabel8.Text = "TEL :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(22, 110)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "PRENOM :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(22, 75)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "NOM :"
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.btAdd)
        Me.PanelContainer.Controls.Add(Me.txtNote)
        Me.PanelContainer.Controls.Add(Me.cmbDate)
        Me.PanelContainer.Controls.Add(Me.MetroLabel3)
        Me.PanelContainer.Controls.Add(Me.MetroLabel2)
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(922, 470)
        Me.PanelContainer.TabIndex = 9
        '
        'AddGraduation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 641)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddGraduation"
        Me.Text = "GRADUATION : NOUVEAU GRADUE"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNote As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEtudiant As System.Windows.Forms.ComboBox
    Friend WithEvents txtSexe As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrenom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDateInscription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFormation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGeneration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAdresse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
End Class
