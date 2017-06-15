
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MajDepenses
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckCode = New MetroFramework.Controls.MetroCheckBox()
        Me.ckType = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.btviderRecherche = New MetroFramework.Controls.MetroButton()
        Me.cmbRechType = New System.Windows.Forms.ComboBox()
        Me.txtRechCode = New MetroFramework.Controls.MetroTextBox()
        Me.cmbMois = New System.Windows.Forms.ComboBox()
        Me.cmbAnnee = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtDate = New MetroFramework.Controls.MetroDateTime()
        Me.btFermer = New MetroFramework.Controls.MetroButton()
        Me.btMiseAjour = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.ListDepense = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtActivite = New MetroFramework.Controls.MetroTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroPanel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.57143!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.9587!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.53687!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1338, 678)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1332, 72)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckCode)
        Me.GroupBox1.Controls.Add(Me.ckType)
        Me.GroupBox1.Controls.Add(Me.MetroLabel18)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btviderRecherche)
        Me.GroupBox1.Controls.Add(Me.cmbRechType)
        Me.GroupBox1.Controls.Add(Me.txtRechCode)
        Me.GroupBox1.Controls.Add(Me.cmbMois)
        Me.GroupBox1.Controls.Add(Me.cmbAnnee)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1332, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherchce Rapide"
        '
        'ckCode
        '
        Me.ckCode.AutoSize = True
        Me.ckCode.Location = New System.Drawing.Point(454, 33)
        Me.ckCode.Name = "ckCode"
        Me.ckCode.Size = New System.Drawing.Size(99, 15)
        Me.ckCode.TabIndex = 1
        Me.ckCode.Text = "Code Depense"
        Me.ckCode.UseSelectable = True
        '
        'ckType
        '
        Me.ckType.AutoSize = True
        Me.ckType.Location = New System.Drawing.Point(772, 33)
        Me.ckType.Name = "ckType"
        Me.ckType.Size = New System.Drawing.Size(97, 15)
        Me.ckType.TabIndex = 1
        Me.ckType.Text = "Type Depense"
        Me.ckType.UseSelectable = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Enabled = False
        Me.MetroLabel18.Location = New System.Drawing.Point(236, 32)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel18.TabIndex = 18
        Me.MetroLabel18.Text = "Mois"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel1.TabIndex = 18
        Me.MetroLabel1.Text = "Année"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(1233, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(83, 28)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Rechercher"
        Me.btnSearch.UseSelectable = True
        '
        'btviderRecherche
        '
        Me.btviderRecherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btviderRecherche.Location = New System.Drawing.Point(1139, 26)
        Me.btviderRecherche.Name = "btviderRecherche"
        Me.btviderRecherche.Size = New System.Drawing.Size(83, 28)
        Me.btviderRecherche.TabIndex = 16
        Me.btviderRecherche.Text = "Vider"
        Me.btviderRecherche.UseSelectable = True
        '
        'cmbRechType
        '
        Me.cmbRechType.Enabled = False
        Me.cmbRechType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRechType.FormattingEnabled = True
        Me.cmbRechType.Items.AddRange(New Object() {"Rembourssement", "Autre Paiement"})
        Me.cmbRechType.Location = New System.Drawing.Point(877, 26)
        Me.cmbRechType.Name = "cmbRechType"
        Me.cmbRechType.Size = New System.Drawing.Size(147, 28)
        Me.cmbRechType.TabIndex = 9
        '
        'txtRechCode
        '
        '
        '
        '
        Me.txtRechCode.CustomButton.Image = Nothing
        Me.txtRechCode.CustomButton.Location = New System.Drawing.Point(121, 1)
        Me.txtRechCode.CustomButton.Name = ""
        Me.txtRechCode.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtRechCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRechCode.CustomButton.TabIndex = 1
        Me.txtRechCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRechCode.CustomButton.UseSelectable = True
        Me.txtRechCode.CustomButton.Visible = False
        Me.txtRechCode.Enabled = False
        Me.txtRechCode.Lines = New String(-1) {}
        Me.txtRechCode.Location = New System.Drawing.Point(559, 26)
        Me.txtRechCode.MaxLength = 32767
        Me.txtRechCode.Name = "txtRechCode"
        Me.txtRechCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRechCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRechCode.SelectedText = ""
        Me.txtRechCode.SelectionLength = 0
        Me.txtRechCode.SelectionStart = 0
        Me.txtRechCode.ShortcutsEnabled = True
        Me.txtRechCode.Size = New System.Drawing.Size(149, 29)
        Me.txtRechCode.TabIndex = 10
        Me.txtRechCode.UseSelectable = True
        Me.txtRechCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRechCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbMois
        '
        Me.cmbMois.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMois.FormattingEnabled = True
        Me.cmbMois.Location = New System.Drawing.Point(279, 26)
        Me.cmbMois.Name = "cmbMois"
        Me.cmbMois.Size = New System.Drawing.Size(158, 29)
        Me.cmbMois.TabIndex = 9
        '
        'cmbAnnee
        '
        Me.cmbAnnee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnnee.FormattingEnabled = True
        Me.cmbAnnee.Location = New System.Drawing.Point(89, 26)
        Me.cmbAnnee.Name = "cmbAnnee"
        Me.cmbAnnee.Size = New System.Drawing.Size(125, 29)
        Me.cmbAnnee.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btFermer)
        Me.Panel2.Controls.Add(Me.btMiseAjour)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1332, 419)
        Me.Panel2.TabIndex = 2
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
        Me.GroupBox3.Location = New System.Drawing.Point(643, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(872, 334)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Partie II"
        '
        'cmbDevise
        '
        Me.cmbDevise.FormattingEnabled = True
        Me.cmbDevise.ItemHeight = 23
        Me.cmbDevise.Items.AddRange(New Object() {"", "FCFA"})
        Me.cmbDevise.Location = New System.Drawing.Point(291, 56)
        Me.cmbDevise.Name = "cmbDevise"
        Me.cmbDevise.Size = New System.Drawing.Size(336, 29)
        Me.cmbDevise.TabIndex = 28
        Me.cmbDevise.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Location = New System.Drawing.Point(504, 174)
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
        Me.txtMemo.CustomButton.Location = New System.Drawing.Point(296, 1)
        Me.txtMemo.CustomButton.Name = ""
        Me.txtMemo.CustomButton.Size = New System.Drawing.Size(39, 39)
        Me.txtMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMemo.CustomButton.TabIndex = 1
        Me.txtMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMemo.CustomButton.UseSelectable = True
        Me.txtMemo.CustomButton.Visible = False
        Me.txtMemo.Lines = New String(-1) {}
        Me.txtMemo.Location = New System.Drawing.Point(291, 278)
        Me.txtMemo.MaxLength = 32767
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMemo.SelectedText = ""
        Me.txtMemo.SelectionLength = 0
        Me.txtMemo.SelectionStart = 0
        Me.txtMemo.ShortcutsEnabled = True
        Me.txtMemo.Size = New System.Drawing.Size(336, 41)
        Me.txtMemo.TabIndex = 26
        Me.txtMemo.UseSelectable = True
        Me.txtMemo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMemo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(15, 290)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel16.TabIndex = 25
        Me.MetroLabel16.Text = "Mémo :"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(10, 236)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(170, 38)
        Me.MetroLabel15.TabIndex = 24
        Me.MetroLabel15.Text = "Code de la demande des " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sortie des fonds :"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(10, 211)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel14.TabIndex = 23
        Me.MetroLabel14.Text = "Poste :"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(10, 176)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel13.TabIndex = 22
        Me.MetroLabel13.Text = "Réalisé par :"
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(501, 96)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(177, 21)
        Me.MetroLink1.TabIndex = 21
        Me.MetroLink1.Text = "Retrouver dand le Système"
        Me.MetroLink1.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(10, 140)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel12.TabIndex = 20
        Me.MetroLabel12.Text = "En reglément de:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(10, 99)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel11.TabIndex = 19
        Me.MetroLabel11.Text = "Bénéficiaire :"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(10, 62)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel10.TabIndex = 18
        Me.MetroLabel10.Text = "Devise :"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(10, 29)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(164, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Montant de la Dépense :"
        '
        'txtPoste
        '
        '
        '
        '
        Me.txtPoste.CustomButton.Image = Nothing
        Me.txtPoste.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.txtPoste.CustomButton.Name = ""
        Me.txtPoste.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPoste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPoste.CustomButton.TabIndex = 1
        Me.txtPoste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPoste.CustomButton.UseSelectable = True
        Me.txtPoste.CustomButton.Visible = False
        Me.txtPoste.Enabled = False
        Me.txtPoste.Lines = New String(-1) {}
        Me.txtPoste.Location = New System.Drawing.Point(291, 205)
        Me.txtPoste.MaxLength = 32767
        Me.txtPoste.Name = "txtPoste"
        Me.txtPoste.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoste.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPoste.SelectedText = ""
        Me.txtPoste.SelectionLength = 0
        Me.txtPoste.SelectionStart = 0
        Me.txtPoste.ShortcutsEnabled = True
        Me.txtPoste.Size = New System.Drawing.Size(336, 29)
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
        Me.txtCodeDemande.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.txtCodeDemande.CustomButton.Name = ""
        Me.txtCodeDemande.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCodeDemande.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodeDemande.CustomButton.TabIndex = 1
        Me.txtCodeDemande.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodeDemande.CustomButton.UseSelectable = True
        Me.txtCodeDemande.CustomButton.Visible = False
        Me.txtCodeDemande.Lines = New String(-1) {}
        Me.txtCodeDemande.Location = New System.Drawing.Point(291, 241)
        Me.txtCodeDemande.MaxLength = 32767
        Me.txtCodeDemande.Name = "txtCodeDemande"
        Me.txtCodeDemande.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodeDemande.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodeDemande.SelectedText = ""
        Me.txtCodeDemande.SelectionLength = 0
        Me.txtCodeDemande.SelectionStart = 0
        Me.txtCodeDemande.ShortcutsEnabled = True
        Me.txtCodeDemande.Size = New System.Drawing.Size(336, 29)
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
        Me.txtReglement.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.txtReglement.CustomButton.Name = ""
        Me.txtReglement.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtReglement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReglement.CustomButton.TabIndex = 1
        Me.txtReglement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReglement.CustomButton.UseSelectable = True
        Me.txtReglement.CustomButton.Visible = False
        Me.txtReglement.Lines = New String(-1) {}
        Me.txtReglement.Location = New System.Drawing.Point(291, 134)
        Me.txtReglement.MaxLength = 32767
        Me.txtReglement.Name = "txtReglement"
        Me.txtReglement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReglement.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReglement.SelectedText = ""
        Me.txtReglement.SelectionLength = 0
        Me.txtReglement.SelectionStart = 0
        Me.txtReglement.ShortcutsEnabled = True
        Me.txtReglement.Size = New System.Drawing.Size(336, 29)
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
        Me.txtMontant.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.txtMontant.CustomButton.Name = ""
        Me.txtMontant.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontant.CustomButton.TabIndex = 1
        Me.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontant.CustomButton.UseSelectable = True
        Me.txtMontant.CustomButton.Visible = False
        Me.txtMontant.Lines = New String(-1) {}
        Me.txtMontant.Location = New System.Drawing.Point(291, 23)
        Me.txtMontant.MaxLength = 32767
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontant.SelectedText = ""
        Me.txtMontant.SelectionLength = 0
        Me.txtMontant.SelectionStart = 0
        Me.txtMontant.ShortcutsEnabled = True
        Me.txtMontant.Size = New System.Drawing.Size(336, 29)
        Me.txtMontant.TabIndex = 13
        Me.txtMontant.UseSelectable = True
        Me.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbBeneficiaire
        '
        Me.cmbBeneficiaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBeneficiaire.FormattingEnabled = True
        Me.cmbBeneficiaire.Location = New System.Drawing.Point(291, 93)
        Me.cmbBeneficiaire.Name = "cmbBeneficiaire"
        Me.cmbBeneficiaire.Size = New System.Drawing.Size(202, 28)
        Me.cmbBeneficiaire.TabIndex = 12
        '
        'cmbRealiser
        '
        Me.cmbRealiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRealiser.FormattingEnabled = True
        Me.cmbRealiser.Location = New System.Drawing.Point(291, 170)
        Me.cmbRealiser.Name = "cmbRealiser"
        Me.cmbRealiser.Size = New System.Drawing.Size(202, 28)
        Me.cmbRealiser.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.txtActivite)
        Me.GroupBox2.Controls.Add(Me.cmbManager)
        Me.GroupBox2.Controls.Add(Me.cmbCodeDepense)
        Me.GroupBox2.Controls.Add(Me.cmbProgramme)
        Me.GroupBox2.Controls.Add(Me.cmbDepartement)
        Me.GroupBox2.Controls.Add(Me.cmbTypeDepense)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.MetroLabel7)
        Me.GroupBox2.Controls.Add(Me.MetroLabel6)
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.txtDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 334)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Partie I"
        '
        'cmbManager
        '
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.ItemHeight = 23
        Me.cmbManager.Location = New System.Drawing.Point(172, 237)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(349, 29)
        Me.cmbManager.TabIndex = 19
        Me.cmbManager.UseSelectable = True
        '
        'cmbCodeDepense
        '
        Me.cmbCodeDepense.FormattingEnabled = True
        Me.cmbCodeDepense.ItemHeight = 23
        Me.cmbCodeDepense.Location = New System.Drawing.Point(172, 194)
        Me.cmbCodeDepense.Name = "cmbCodeDepense"
        Me.cmbCodeDepense.Size = New System.Drawing.Size(349, 29)
        Me.cmbCodeDepense.TabIndex = 19
        Me.cmbCodeDepense.UseSelectable = True
        '
        'cmbProgramme
        '
        Me.cmbProgramme.FormattingEnabled = True
        Me.cmbProgramme.ItemHeight = 23
        Me.cmbProgramme.Location = New System.Drawing.Point(172, 158)
        Me.cmbProgramme.Name = "cmbProgramme"
        Me.cmbProgramme.Size = New System.Drawing.Size(349, 29)
        Me.cmbProgramme.TabIndex = 19
        Me.cmbProgramme.UseSelectable = True
        '
        'cmbDepartement
        '
        Me.cmbDepartement.FormattingEnabled = True
        Me.cmbDepartement.ItemHeight = 23
        Me.cmbDepartement.Location = New System.Drawing.Point(172, 121)
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
        Me.cmbTypeDepense.Location = New System.Drawing.Point(172, 82)
        Me.cmbTypeDepense.Name = "cmbTypeDepense"
        Me.cmbTypeDepense.Size = New System.Drawing.Size(349, 29)
        Me.cmbTypeDepense.TabIndex = 17
        Me.cmbTypeDepense.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(15, 129)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "Departement :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(15, 166)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Programme :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(15, 202)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Code Dépense :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 90)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Type Dépense :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 245)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Nom du Manager"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 52)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Date :"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(172, 44)
        Me.txtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(349, 29)
        Me.txtDate.TabIndex = 8
        '
        'btFermer
        '
        Me.btFermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFermer.Location = New System.Drawing.Point(669, 357)
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(119, 40)
        Me.btFermer.TabIndex = 21
        Me.btFermer.Text = "Fermer"
        Me.btFermer.UseSelectable = True
        '
        'btMiseAjour
        '
        Me.btMiseAjour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btMiseAjour.Location = New System.Drawing.Point(544, 357)
        Me.btMiseAjour.Name = "btMiseAjour"
        Me.btMiseAjour.Size = New System.Drawing.Size(119, 40)
        Me.btMiseAjour.TabIndex = 19
        Me.btMiseAjour.Text = "Mise à jour"
        Me.btMiseAjour.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.ListDepense)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 81)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1332, 169)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'ListDepense
        '
        Me.ListDepense.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListDepense.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListDepense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDepense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDepense.FullRowSelect = True
        Me.ListDepense.GridLines = True
        Me.ListDepense.Location = New System.Drawing.Point(0, 0)
        Me.ListDepense.Name = "ListDepense"
        Me.ListDepense.Size = New System.Drawing.Size(1332, 169)
        Me.ListDepense.TabIndex = 1
        Me.ListDepense.UseCompatibleStateImageBehavior = False
        Me.ListDepense.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "id"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "EN REGLEMENT DE"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 205
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MONTANT"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 162
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DEVISE"
        Me.ColumnHeader2.Width = 153
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "REALISER PAR"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 215
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "BENEFFICIAIRE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 224
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TYPE DEPENSE"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 209
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DEPARTEMENT"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 175
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "index"
        Me.ColumnHeader7.Width = 0
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 278)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel2.TabIndex = 20
        Me.MetroLabel2.Text = "Activité :"
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
        Me.txtActivite.Location = New System.Drawing.Point(172, 275)
        Me.txtActivite.MaxLength = 32767
        Me.txtActivite.Name = "txtActivite"
        Me.txtActivite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtActivite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtActivite.SelectedText = ""
        Me.txtActivite.SelectionLength = 0
        Me.txtActivite.SelectionStart = 0
        Me.txtActivite.ShortcutsEnabled = True
        Me.txtActivite.Size = New System.Drawing.Size(349, 29)
        Me.txtActivite.TabIndex = 21
        Me.txtActivite.UseSelectable = True
        Me.txtActivite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtActivite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MajDepenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 758)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MajDepenses"
        Me.Text = "FINANCE : VUE/MISE A JOUR DES DEPENSES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRechCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbMois As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents btviderRecherche As MetroFramework.Controls.MetroButton
    Friend WithEvents ListDepense As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btFermer As MetroFramework.Controls.MetroButton
    Friend WithEvents btMiseAjour As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ckCode As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckType As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbRechType As System.Windows.Forms.ComboBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbManager As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbCodeDepense As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbProgramme As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDepartement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbTypeDepense As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDevise As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents txtMemo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPoste As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodeDemande As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtReglement As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbBeneficiaire As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRealiser As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtActivite As MetroFramework.Controls.MetroTextBox
End Class
