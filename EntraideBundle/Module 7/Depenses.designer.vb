<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Depenses))
        Me.btEnregistrement = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.txtAnnuler = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbDevise = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.txtMemo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtPoste = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodeDemande = New MetroFramework.Controls.MetroTextBox()
        Me.txtReglement = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontant = New MetroFramework.Controls.MetroTextBox()
        Me.cmbBeneficiaire = New System.Windows.Forms.ComboBox()
        Me.cmbRealiser = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbManager = New MetroFramework.Controls.MetroComboBox()
        Me.cmbCodeDepense = New MetroFramework.Controls.MetroComboBox()
        Me.cmbProgramme = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDepartement = New MetroFramework.Controls.MetroComboBox()
        Me.cmbTypeDepense = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtActivite = New MetroFramework.Controls.MetroTextBox()
        Me.txtDate = New MetroFramework.Controls.MetroDateTime()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btEnregistrement
        '
        Me.btEnregistrement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnregistrement.Location = New System.Drawing.Point(482, 399)
        Me.btEnregistrement.Name = "btEnregistrement"
        Me.btEnregistrement.Size = New System.Drawing.Size(98, 37)
        Me.btEnregistrement.TabIndex = 10
        Me.btEnregistrement.Text = "Enregistrer"
        Me.btEnregistrement.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(587, 399)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(98, 37)
        Me.MetroButton2.TabIndex = 9
        Me.MetroButton2.Text = "Fermer"
        Me.MetroButton2.UseSelectable = True
        '
        'txtAnnuler
        '
        Me.txtAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtAnnuler.Location = New System.Drawing.Point(378, 399)
        Me.txtAnnuler.Name = "txtAnnuler"
        Me.txtAnnuler.Size = New System.Drawing.Size(98, 37)
        Me.txtAnnuler.TabIndex = 8
        Me.txtAnnuler.Text = "Vider"
        Me.txtAnnuler.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbDevise)
        Me.GroupBox3.Controls.Add(Me.MetroLink2)
        Me.GroupBox3.Controls.Add(Me.txtMemo)
        Me.GroupBox3.Controls.Add(Me.MetroLabel16)
        Me.GroupBox3.Controls.Add(Me.MetroLabel15)
        Me.GroupBox3.Controls.Add(Me.MetroLabel14)
        Me.GroupBox3.Controls.Add(Me.MetroLabel13)
        Me.GroupBox3.Controls.Add(Me.MetroLink1)
        Me.GroupBox3.Controls.Add(Me.MetroLabel12)
        Me.GroupBox3.Controls.Add(Me.MetroLabel11)
        Me.GroupBox3.Controls.Add(Me.MetroLabel10)
        Me.GroupBox3.Controls.Add(Me.MetroLabel9)
        Me.GroupBox3.Controls.Add(Me.txtPoste)
        Me.GroupBox3.Controls.Add(Me.txtCodeDemande)
        Me.GroupBox3.Controls.Add(Me.txtReglement)
        Me.GroupBox3.Controls.Add(Me.txtMontant)
        Me.GroupBox3.Controls.Add(Me.cmbBeneficiaire)
        Me.GroupBox3.Controls.Add(Me.cmbRealiser)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(542, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(583, 373)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Partie II"
        '
        'cmbDevise
        '
        Me.cmbDevise.FormattingEnabled = True
        Me.cmbDevise.ItemHeight = 23
        Me.cmbDevise.Items.AddRange(New Object() {"", "FCFA"})
        Me.cmbDevise.Location = New System.Drawing.Point(194, 65)
        Me.cmbDevise.Name = "cmbDevise"
        Me.cmbDevise.Size = New System.Drawing.Size(349, 29)
        Me.cmbDevise.TabIndex = 28
        Me.cmbDevise.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Location = New System.Drawing.Point(385, 186)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(154, 21)
        Me.MetroLink2.TabIndex = 27
        Me.MetroLink2.Text = "Retrouver un Employer "
        Me.MetroLink2.UseSelectable = True
        '
        'txtMemo
        '
        '
        '
        '
        Me.txtMemo.CustomButton.Image = Nothing
        Me.txtMemo.CustomButton.Location = New System.Drawing.Point(293, 1)
        Me.txtMemo.CustomButton.Name = ""
        Me.txtMemo.CustomButton.Size = New System.Drawing.Size(55, 55)
        Me.txtMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMemo.CustomButton.TabIndex = 1
        Me.txtMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMemo.CustomButton.UseSelectable = True
        Me.txtMemo.CustomButton.Visible = False
        Me.txtMemo.Lines = New String(-1) {}
        Me.txtMemo.Location = New System.Drawing.Point(194, 299)
        Me.txtMemo.MaxLength = 32767
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMemo.SelectedText = ""
        Me.txtMemo.SelectionLength = 0
        Me.txtMemo.SelectionStart = 0
        Me.txtMemo.ShortcutsEnabled = True
        Me.txtMemo.Size = New System.Drawing.Size(349, 57)
        Me.txtMemo.TabIndex = 26
        Me.txtMemo.UseSelectable = True
        Me.txtMemo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMemo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(17, 318)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel16.TabIndex = 25
        Me.MetroLabel16.Text = "Mémo :"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(15, 254)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(163, 38)
        Me.MetroLabel15.TabIndex = 24
        Me.MetroLabel15.Text = "Code de la Demande des " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sortie des Fonds :"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(15, 222)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel14.TabIndex = 23
        Me.MetroLabel14.Text = "Poste :"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(15, 187)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel13.TabIndex = 22
        Me.MetroLabel13.Text = "Réalisé par :"
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(375, 110)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(177, 21)
        Me.MetroLink1.TabIndex = 21
        Me.MetroLink1.Text = "Retrouver dand le Système"
        Me.MetroLink1.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(15, 148)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel12.TabIndex = 20
        Me.MetroLabel12.Text = "En reglément de:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(15, 111)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel11.TabIndex = 19
        Me.MetroLabel11.Text = "Bénéficiaire :"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(15, 65)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel10.TabIndex = 18
        Me.MetroLabel10.Text = "Devise :"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(15, 26)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Montant des Dépense :"
        '
        'txtPoste
        '
        '
        '
        '
        Me.txtPoste.CustomButton.Image = Nothing
        Me.txtPoste.CustomButton.Location = New System.Drawing.Point(321, 1)
        Me.txtPoste.CustomButton.Name = ""
        Me.txtPoste.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPoste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPoste.CustomButton.TabIndex = 1
        Me.txtPoste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPoste.CustomButton.UseSelectable = True
        Me.txtPoste.CustomButton.Visible = False
        Me.txtPoste.Enabled = False
        Me.txtPoste.Lines = New String(-1) {}
        Me.txtPoste.Location = New System.Drawing.Point(194, 217)
        Me.txtPoste.MaxLength = 32767
        Me.txtPoste.Name = "txtPoste"
        Me.txtPoste.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoste.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPoste.SelectedText = ""
        Me.txtPoste.SelectionLength = 0
        Me.txtPoste.SelectionStart = 0
        Me.txtPoste.ShortcutsEnabled = True
        Me.txtPoste.Size = New System.Drawing.Size(349, 29)
        Me.txtPoste.TabIndex = 16
        Me.txtPoste.UseSelectable = True
        Me.txtPoste.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPoste.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodeDemande
        '
        '
        '
        '
        Me.txtCodeDemande.CustomButton.Image = Nothing
        Me.txtCodeDemande.CustomButton.Location = New System.Drawing.Point(321, 1)
        Me.txtCodeDemande.CustomButton.Name = ""
        Me.txtCodeDemande.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCodeDemande.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodeDemande.CustomButton.TabIndex = 1
        Me.txtCodeDemande.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodeDemande.CustomButton.UseSelectable = True
        Me.txtCodeDemande.CustomButton.Visible = False
        Me.txtCodeDemande.Lines = New String(-1) {}
        Me.txtCodeDemande.Location = New System.Drawing.Point(194, 259)
        Me.txtCodeDemande.MaxLength = 32767
        Me.txtCodeDemande.Name = "txtCodeDemande"
        Me.txtCodeDemande.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodeDemande.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodeDemande.SelectedText = ""
        Me.txtCodeDemande.SelectionLength = 0
        Me.txtCodeDemande.SelectionStart = 0
        Me.txtCodeDemande.ShortcutsEnabled = True
        Me.txtCodeDemande.Size = New System.Drawing.Size(349, 29)
        Me.txtCodeDemande.TabIndex = 15
        Me.txtCodeDemande.UseSelectable = True
        Me.txtCodeDemande.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodeDemande.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtReglement
        '
        '
        '
        '
        Me.txtReglement.CustomButton.Image = Nothing
        Me.txtReglement.CustomButton.Location = New System.Drawing.Point(321, 1)
        Me.txtReglement.CustomButton.Name = ""
        Me.txtReglement.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtReglement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReglement.CustomButton.TabIndex = 1
        Me.txtReglement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReglement.CustomButton.UseSelectable = True
        Me.txtReglement.CustomButton.Visible = False
        Me.txtReglement.Lines = New String(-1) {}
        Me.txtReglement.Location = New System.Drawing.Point(194, 143)
        Me.txtReglement.MaxLength = 32767
        Me.txtReglement.Name = "txtReglement"
        Me.txtReglement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReglement.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReglement.SelectedText = ""
        Me.txtReglement.SelectionLength = 0
        Me.txtReglement.SelectionStart = 0
        Me.txtReglement.ShortcutsEnabled = True
        Me.txtReglement.Size = New System.Drawing.Size(349, 29)
        Me.txtReglement.TabIndex = 14
        Me.txtReglement.UseSelectable = True
        Me.txtReglement.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReglement.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMontant
        '
        '
        '
        '
        Me.txtMontant.CustomButton.Image = Nothing
        Me.txtMontant.CustomButton.Location = New System.Drawing.Point(321, 1)
        Me.txtMontant.CustomButton.Name = ""
        Me.txtMontant.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontant.CustomButton.TabIndex = 1
        Me.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontant.CustomButton.UseSelectable = True
        Me.txtMontant.CustomButton.Visible = False
        Me.txtMontant.Lines = New String(-1) {}
        Me.txtMontant.Location = New System.Drawing.Point(194, 26)
        Me.txtMontant.MaxLength = 32767
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontant.SelectedText = ""
        Me.txtMontant.SelectionLength = 0
        Me.txtMontant.SelectionStart = 0
        Me.txtMontant.ShortcutsEnabled = True
        Me.txtMontant.Size = New System.Drawing.Size(349, 29)
        Me.txtMontant.TabIndex = 13
        Me.txtMontant.UseSelectable = True
        Me.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbBeneficiaire
        '
        Me.cmbBeneficiaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBeneficiaire.FormattingEnabled = True
        Me.cmbBeneficiaire.Location = New System.Drawing.Point(194, 106)
        Me.cmbBeneficiaire.Name = "cmbBeneficiaire"
        Me.cmbBeneficiaire.Size = New System.Drawing.Size(168, 28)
        Me.cmbBeneficiaire.TabIndex = 12
        '
        'cmbRealiser
        '
        Me.cmbRealiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRealiser.FormattingEnabled = True
        Me.cmbRealiser.Location = New System.Drawing.Point(194, 182)
        Me.cmbRealiser.Name = "cmbRealiser"
        Me.cmbRealiser.Size = New System.Drawing.Size(168, 28)
        Me.cmbRealiser.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbManager)
        Me.GroupBox2.Controls.Add(Me.cmbCodeDepense)
        Me.GroupBox2.Controls.Add(Me.cmbProgramme)
        Me.GroupBox2.Controls.Add(Me.cmbDepartement)
        Me.GroupBox2.Controls.Add(Me.cmbTypeDepense)
        Me.GroupBox2.Controls.Add(Me.MetroLabel1)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.MetroLabel7)
        Me.GroupBox2.Controls.Add(Me.MetroLabel6)
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.txtActivite)
        Me.GroupBox2.Controls.Add(Me.txtDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 373)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Partie I"
        '
        'cmbManager
        '
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.ItemHeight = 23
        Me.cmbManager.Location = New System.Drawing.Point(147, 253)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(349, 29)
        Me.cmbManager.TabIndex = 19
        Me.cmbManager.UseSelectable = True
        '
        'cmbCodeDepense
        '
        Me.cmbCodeDepense.FormattingEnabled = True
        Me.cmbCodeDepense.ItemHeight = 23
        Me.cmbCodeDepense.Location = New System.Drawing.Point(147, 210)
        Me.cmbCodeDepense.Name = "cmbCodeDepense"
        Me.cmbCodeDepense.Size = New System.Drawing.Size(349, 29)
        Me.cmbCodeDepense.TabIndex = 19
        Me.cmbCodeDepense.UseSelectable = True
        '
        'cmbProgramme
        '
        Me.cmbProgramme.FormattingEnabled = True
        Me.cmbProgramme.ItemHeight = 23
        Me.cmbProgramme.Location = New System.Drawing.Point(147, 170)
        Me.cmbProgramme.Name = "cmbProgramme"
        Me.cmbProgramme.Size = New System.Drawing.Size(349, 29)
        Me.cmbProgramme.TabIndex = 19
        Me.cmbProgramme.UseSelectable = True
        '
        'cmbDepartement
        '
        Me.cmbDepartement.FormattingEnabled = True
        Me.cmbDepartement.ItemHeight = 23
        Me.cmbDepartement.Location = New System.Drawing.Point(147, 133)
        Me.cmbDepartement.Name = "cmbDepartement"
        Me.cmbDepartement.Size = New System.Drawing.Size(349, 29)
        Me.cmbDepartement.TabIndex = 19
        Me.cmbDepartement.UseSelectable = True
        '
        'cmbTypeDepense
        '
        Me.cmbTypeDepense.FormattingEnabled = True
        Me.cmbTypeDepense.ItemHeight = 23
        Me.cmbTypeDepense.Items.AddRange(New Object() {"Rembourssement", "Autre Paiement"})
        Me.cmbTypeDepense.Location = New System.Drawing.Point(147, 89)
        Me.cmbTypeDepense.Name = "cmbTypeDepense"
        Me.cmbTypeDepense.Size = New System.Drawing.Size(349, 29)
        Me.cmbTypeDepense.TabIndex = 17
        Me.cmbTypeDepense.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(21, 300)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel1.TabIndex = 14
        Me.MetroLabel1.Text = "Activité :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(21, 138)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "Departement :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(21, 175)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Programme :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(21, 215)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Code Dépense :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(21, 94)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Type Dépense :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(21, 258)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Nom du Manager :"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(21, 47)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Date :"
        '
        'txtActivite
        '
        '
        '
        '
        Me.txtActivite.CustomButton.Image = Nothing
        Me.txtActivite.CustomButton.Location = New System.Drawing.Point(321, 1)
        Me.txtActivite.CustomButton.Name = ""
        Me.txtActivite.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtActivite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtActivite.CustomButton.TabIndex = 1
        Me.txtActivite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtActivite.CustomButton.UseSelectable = True
        Me.txtActivite.CustomButton.Visible = False
        Me.txtActivite.Enabled = False
        Me.txtActivite.Lines = New String(-1) {}
        Me.txtActivite.Location = New System.Drawing.Point(147, 295)
        Me.txtActivite.MaxLength = 32767
        Me.txtActivite.Name = "txtActivite"
        Me.txtActivite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtActivite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtActivite.SelectedText = ""
        Me.txtActivite.SelectionLength = 0
        Me.txtActivite.SelectionStart = 0
        Me.txtActivite.ShortcutsEnabled = True
        Me.txtActivite.Size = New System.Drawing.Size(349, 29)
        Me.txtActivite.TabIndex = 16
        Me.txtActivite.UseSelectable = True
        Me.txtActivite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtActivite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(147, 42)
        Me.txtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(349, 29)
        Me.txtDate.TabIndex = 8
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.GroupBox2)
        Me.PanelContainer.Controls.Add(Me.GroupBox3)
        Me.PanelContainer.Controls.Add(Me.btEnregistrement)
        Me.PanelContainer.Controls.Add(Me.MetroButton2)
        Me.PanelContainer.Controls.Add(Me.txtAnnuler)
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1138, 463)
        Me.PanelContainer.TabIndex = 1
        '
        'Depenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 576)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Depenses"
        Me.Text = "FINANCE : ENREGISTREMENT DEPENSES"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btEnregistrement As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAnnuler As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPoste As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodeDemande As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtReglement As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbBeneficiaire As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRealiser As System.Windows.Forms.ComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMemo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents cmbDevise As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeDepense As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDepartement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbManager As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbCodeDepense As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbProgramme As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtActivite As MetroFramework.Controls.MetroTextBox

End Class
