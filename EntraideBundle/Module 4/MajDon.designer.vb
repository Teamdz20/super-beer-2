<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MajDon
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
        Me.TabDetails = New MetroFramework.Controls.MetroTabControl()
        Me.tgp1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.ckMaterial = New MetroFramework.Controls.MetroRadioButton()
        Me.ckArgent = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.ckResIllimite = New MetroFramework.Controls.MetroRadioButton()
        Me.ckResLimite = New MetroFramework.Controls.MetroRadioButton()
        Me.ckSansResctriction = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.ckVirement = New MetroFramework.Controls.MetroRadioButton()
        Me.ckEspece = New MetroFramework.Controls.MetroRadioButton()
        Me.ckCheque = New MetroFramework.Controls.MetroRadioButton()
        Me.txtMontantSollicite = New MetroFramework.Controls.MetroTextBox()
        Me.Lbnumchek = New MetroFramework.Controls.MetroLabel()
        Me.lbmodrestric = New MetroFramework.Controls.MetroLabel()
        Me.ckNonSollicite = New MetroFramework.Controls.MetroCheckBox()
        Me.lbdifference = New MetroFramework.Controls.MetroLabel()
        Me.txtMontrecu = New MetroFramework.Controls.MetroTextBox()
        Me.lbmontantrecu = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumCheque = New MetroFramework.Controls.MetroTextBox()
        Me.lbmontantsol = New MetroFramework.Controls.MetroLabel()
        Me.txtDiference = New MetroFramework.Controls.MetroTextBox()
        Me.txtDate = New MetroFramework.Controls.MetroDateTime()
        Me.txtActiviteMenee = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.linkmateriel = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.tgp2 = New MetroFramework.Controls.MetroTabPage()
        Me.cmbCodeRevenu = New System.Windows.Forms.ComboBox()
        Me.cmbActiviteFinancier = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDepartement = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoteRestriction = New MetroFramework.Controls.MetroTextBox()
        Me.tgp3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.btenregistrementdonneur = New MetroFramework.Controls.MetroButton()
        Me.txtEmailDo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtSiteInternet = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtTelDo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.cmbResDon = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.txtAdresseDonneur = New MetroFramework.Controls.MetroTextBox()
        Me.cmbCodeDonneur = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDonneur = New MetroFramework.Controls.MetroComboBox()
        Me.cmbCategorieDonneur = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckDonneur = New MetroFramework.Controls.MetroCheckBox()
        Me.ckActivite = New MetroFramework.Controls.MetroCheckBox()
        Me.ckTypeDon = New MetroFramework.Controls.MetroCheckBox()
        Me.ckDate = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbDate = New MetroFramework.Controls.MetroDateTime()
        Me.txtRechActiviteMenee = New MetroFramework.Controls.MetroTextBox()
        Me.cmbRechTypeDon = New MetroFramework.Controls.MetroComboBox()
        Me.btRecher = New MetroFramework.Controls.MetroButton()
        Me.btvidrecher = New MetroFramework.Controls.MetroButton()
        Me.btenregistrer = New MetroFramework.Controls.MetroButton()
        Me.btannuler = New MetroFramework.Controls.MetroButton()
        Me.ListDon = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btfermer = New MetroFramework.Controls.MetroButton()
        Me.cmbRechDonneur = New MetroFramework.Controls.MetroComboBox()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabDetails.SuspendLayout()
        Me.tgp1.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.tgp2.SuspendLayout()
        Me.tgp3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabDetails
        '
        Me.TabDetails.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabDetails.Controls.Add(Me.tgp1)
        Me.TabDetails.Controls.Add(Me.tgp2)
        Me.TabDetails.Controls.Add(Me.tgp3)
        Me.TabDetails.Location = New System.Drawing.Point(23, 349)
        Me.TabDetails.Name = "TabDetails"
        Me.TabDetails.SelectedIndex = 0
        Me.TabDetails.Size = New System.Drawing.Size(1168, 377)
        Me.TabDetails.TabIndex = 2
        Me.TabDetails.UseSelectable = True
        '
        'tgp1
        '
        Me.tgp1.Controls.Add(Me.MetroPanel4)
        Me.tgp1.Controls.Add(Me.MetroPanel1)
        Me.tgp1.Controls.Add(Me.txtDate)
        Me.tgp1.Controls.Add(Me.txtActiviteMenee)
        Me.tgp1.Controls.Add(Me.MetroLabel9)
        Me.tgp1.Controls.Add(Me.MetroLabel8)
        Me.tgp1.Controls.Add(Me.linkmateriel)
        Me.tgp1.Controls.Add(Me.MetroLabel3)
        Me.tgp1.HorizontalScrollbarBarColor = True
        Me.tgp1.HorizontalScrollbarHighlightOnWheel = False
        Me.tgp1.HorizontalScrollbarSize = 10
        Me.tgp1.Location = New System.Drawing.Point(4, 41)
        Me.tgp1.Name = "tgp1"
        Me.tgp1.Size = New System.Drawing.Size(1160, 332)
        Me.tgp1.TabIndex = 0
        Me.tgp1.Text = "Information Générale  /"
        Me.tgp1.VerticalScrollbarBarColor = True
        Me.tgp1.VerticalScrollbarHighlightOnWheel = False
        Me.tgp1.VerticalScrollbarSize = 10
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.ckMaterial)
        Me.MetroPanel4.Controls.Add(Me.ckArgent)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(419, 66)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(200, 25)
        Me.MetroPanel4.TabIndex = 28
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'ckMaterial
        '
        Me.ckMaterial.AutoSize = True
        Me.ckMaterial.Location = New System.Drawing.Point(94, 5)
        Me.ckMaterial.Name = "ckMaterial"
        Me.ckMaterial.Size = New System.Drawing.Size(66, 15)
        Me.ckMaterial.TabIndex = 20
        Me.ckMaterial.Text = "Material"
        Me.ckMaterial.UseSelectable = True
        '
        'ckArgent
        '
        Me.ckArgent.AutoSize = True
        Me.ckArgent.Checked = True
        Me.ckArgent.Location = New System.Drawing.Point(4, 5)
        Me.ckArgent.Name = "ckArgent"
        Me.ckArgent.Size = New System.Drawing.Size(59, 15)
        Me.ckArgent.TabIndex = 20
        Me.ckArgent.TabStop = True
        Me.ckArgent.Text = "Argent"
        Me.ckArgent.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroPanel3)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Controls.Add(Me.txtMontantSollicite)
        Me.MetroPanel1.Controls.Add(Me.Lbnumchek)
        Me.MetroPanel1.Controls.Add(Me.lbmodrestric)
        Me.MetroPanel1.Controls.Add(Me.ckNonSollicite)
        Me.MetroPanel1.Controls.Add(Me.lbdifference)
        Me.MetroPanel1.Controls.Add(Me.txtMontrecu)
        Me.MetroPanel1.Controls.Add(Me.lbmontantrecu)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel14)
        Me.MetroPanel1.Controls.Add(Me.txtNumCheque)
        Me.MetroPanel1.Controls.Add(Me.lbmontantsol)
        Me.MetroPanel1.Controls.Add(Me.txtDiference)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(266, 103)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(628, 175)
        Me.MetroPanel1.TabIndex = 30
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.ckResIllimite)
        Me.MetroPanel3.Controls.Add(Me.ckResLimite)
        Me.MetroPanel3.Controls.Add(Me.ckSansResctriction)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(145, 140)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(316, 25)
        Me.MetroPanel3.TabIndex = 20
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'ckResIllimite
        '
        Me.ckResIllimite.AutoSize = True
        Me.ckResIllimite.Location = New System.Drawing.Point(194, 5)
        Me.ckResIllimite.Name = "ckResIllimite"
        Me.ckResIllimite.Size = New System.Drawing.Size(59, 15)
        Me.ckResIllimite.TabIndex = 20
        Me.ckResIllimite.Text = "Illimite"
        Me.ckResIllimite.UseSelectable = True
        '
        'ckResLimite
        '
        Me.ckResLimite.AutoSize = True
        Me.ckResLimite.Location = New System.Drawing.Point(103, 5)
        Me.ckResLimite.Name = "ckResLimite"
        Me.ckResLimite.Size = New System.Drawing.Size(56, 15)
        Me.ckResLimite.TabIndex = 20
        Me.ckResLimite.Text = "Limite"
        Me.ckResLimite.UseSelectable = True
        '
        'ckSansResctriction
        '
        Me.ckSansResctriction.AutoSize = True
        Me.ckSansResctriction.Checked = True
        Me.ckSansResctriction.Location = New System.Drawing.Point(4, 5)
        Me.ckSansResctriction.Name = "ckSansResctriction"
        Me.ckSansResctriction.Size = New System.Drawing.Size(47, 15)
        Me.ckSansResctriction.TabIndex = 20
        Me.ckSansResctriction.TabStop = True
        Me.ckSansResctriction.Text = "Sans"
        Me.ckSansResctriction.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.ckVirement)
        Me.MetroPanel2.Controls.Add(Me.ckEspece)
        Me.MetroPanel2.Controls.Add(Me.ckCheque)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(145, 83)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(316, 25)
        Me.MetroPanel2.TabIndex = 20
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'ckVirement
        '
        Me.ckVirement.AutoSize = True
        Me.ckVirement.Location = New System.Drawing.Point(183, 5)
        Me.ckVirement.Name = "ckVirement"
        Me.ckVirement.Size = New System.Drawing.Size(71, 15)
        Me.ckVirement.TabIndex = 20
        Me.ckVirement.Text = "Virement"
        Me.ckVirement.UseSelectable = True
        '
        'ckEspece
        '
        Me.ckEspece.AutoSize = True
        Me.ckEspece.Checked = True
        Me.ckEspece.Location = New System.Drawing.Point(5, 5)
        Me.ckEspece.Name = "ckEspece"
        Me.ckEspece.Size = New System.Drawing.Size(59, 15)
        Me.ckEspece.TabIndex = 20
        Me.ckEspece.TabStop = True
        Me.ckEspece.Text = "Espece"
        Me.ckEspece.UseSelectable = True
        '
        'ckCheque
        '
        Me.ckCheque.AutoSize = True
        Me.ckCheque.Location = New System.Drawing.Point(96, 5)
        Me.ckCheque.Name = "ckCheque"
        Me.ckCheque.Size = New System.Drawing.Size(64, 15)
        Me.ckCheque.TabIndex = 20
        Me.ckCheque.Text = "Cheque"
        Me.ckCheque.UseSelectable = True
        '
        'txtMontantSollicite
        '
        '
        '
        '
        Me.txtMontantSollicite.CustomButton.Image = Nothing
        Me.txtMontantSollicite.CustomButton.Location = New System.Drawing.Point(295, 1)
        Me.txtMontantSollicite.CustomButton.Name = ""
        Me.txtMontantSollicite.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMontantSollicite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantSollicite.CustomButton.TabIndex = 1
        Me.txtMontantSollicite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantSollicite.CustomButton.UseSelectable = True
        Me.txtMontantSollicite.CustomButton.Visible = False
        Me.txtMontantSollicite.Lines = New String(-1) {}
        Me.txtMontantSollicite.Location = New System.Drawing.Point(145, 3)
        Me.txtMontantSollicite.MaxLength = 32767
        Me.txtMontantSollicite.Name = "txtMontantSollicite"
        Me.txtMontantSollicite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantSollicite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantSollicite.SelectedText = ""
        Me.txtMontantSollicite.SelectionLength = 0
        Me.txtMontantSollicite.SelectionStart = 0
        Me.txtMontantSollicite.ShortcutsEnabled = True
        Me.txtMontantSollicite.Size = New System.Drawing.Size(317, 23)
        Me.txtMontantSollicite.TabIndex = 5
        Me.txtMontantSollicite.UseSelectable = True
        Me.txtMontantSollicite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantSollicite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Lbnumchek
        '
        Me.Lbnumchek.AutoSize = True
        Me.Lbnumchek.Location = New System.Drawing.Point(5, 112)
        Me.Lbnumchek.Name = "Lbnumchek"
        Me.Lbnumchek.Size = New System.Drawing.Size(85, 19)
        Me.Lbnumchek.TabIndex = 21
        Me.Lbnumchek.Text = "N° Chèque :"
        '
        'lbmodrestric
        '
        Me.lbmodrestric.AutoSize = True
        Me.lbmodrestric.Location = New System.Drawing.Point(5, 86)
        Me.lbmodrestric.Name = "lbmodrestric"
        Me.lbmodrestric.Size = New System.Drawing.Size(139, 19)
        Me.lbmodrestric.TabIndex = 22
        Me.lbmodrestric.Text = "Mode de Recéption :"
        '
        'ckNonSollicite
        '
        Me.ckNonSollicite.AutoSize = True
        Me.ckNonSollicite.Location = New System.Drawing.Point(468, 7)
        Me.ckNonSollicite.Name = "ckNonSollicite"
        Me.ckNonSollicite.Size = New System.Drawing.Size(90, 15)
        Me.ckNonSollicite.TabIndex = 4
        Me.ckNonSollicite.Text = "Non Sollicité"
        Me.ckNonSollicite.UseSelectable = True
        '
        'lbdifference
        '
        Me.lbdifference.AutoSize = True
        Me.lbdifference.Location = New System.Drawing.Point(5, 60)
        Me.lbdifference.Name = "lbdifference"
        Me.lbdifference.Size = New System.Drawing.Size(81, 19)
        Me.lbdifference.TabIndex = 23
        Me.lbdifference.Text = "Différence :"
        '
        'txtMontrecu
        '
        '
        '
        '
        Me.txtMontrecu.CustomButton.Image = Nothing
        Me.txtMontrecu.CustomButton.Location = New System.Drawing.Point(391, 1)
        Me.txtMontrecu.CustomButton.Name = ""
        Me.txtMontrecu.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMontrecu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontrecu.CustomButton.TabIndex = 1
        Me.txtMontrecu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontrecu.CustomButton.UseSelectable = True
        Me.txtMontrecu.CustomButton.Visible = False
        Me.txtMontrecu.Lines = New String(-1) {}
        Me.txtMontrecu.Location = New System.Drawing.Point(145, 29)
        Me.txtMontrecu.MaxLength = 32767
        Me.txtMontrecu.Name = "txtMontrecu"
        Me.txtMontrecu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontrecu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontrecu.SelectedText = ""
        Me.txtMontrecu.SelectionLength = 0
        Me.txtMontrecu.SelectionStart = 0
        Me.txtMontrecu.ShortcutsEnabled = True
        Me.txtMontrecu.Size = New System.Drawing.Size(413, 23)
        Me.txtMontrecu.TabIndex = 6
        Me.txtMontrecu.UseSelectable = True
        Me.txtMontrecu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontrecu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbmontantrecu
        '
        Me.lbmontantrecu.AutoSize = True
        Me.lbmontantrecu.Location = New System.Drawing.Point(5, 33)
        Me.lbmontantrecu.Name = "lbmontantrecu"
        Me.lbmontantrecu.Size = New System.Drawing.Size(104, 19)
        Me.lbmontantrecu.TabIndex = 24
        Me.lbmontantrecu.Text = "Montant Reçu :"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(5, 140)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel14.TabIndex = 7
        Me.MetroLabel14.Text = "Restriction :"
        '
        'txtNumCheque
        '
        '
        '
        '
        Me.txtNumCheque.CustomButton.Image = Nothing
        Me.txtNumCheque.CustomButton.Location = New System.Drawing.Point(389, 1)
        Me.txtNumCheque.CustomButton.Name = ""
        Me.txtNumCheque.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNumCheque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumCheque.CustomButton.TabIndex = 1
        Me.txtNumCheque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumCheque.CustomButton.UseSelectable = True
        Me.txtNumCheque.CustomButton.Visible = False
        Me.txtNumCheque.Lines = New String(-1) {}
        Me.txtNumCheque.Location = New System.Drawing.Point(145, 112)
        Me.txtNumCheque.MaxLength = 32767
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCheque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumCheque.SelectedText = ""
        Me.txtNumCheque.SelectionLength = 0
        Me.txtNumCheque.SelectionStart = 0
        Me.txtNumCheque.ShortcutsEnabled = True
        Me.txtNumCheque.Size = New System.Drawing.Size(411, 23)
        Me.txtNumCheque.TabIndex = 28
        Me.txtNumCheque.UseSelectable = True
        Me.txtNumCheque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumCheque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbmontantsol
        '
        Me.lbmontantsol.AutoSize = True
        Me.lbmontantsol.Location = New System.Drawing.Point(5, 7)
        Me.lbmontantsol.Name = "lbmontantsol"
        Me.lbmontantsol.Size = New System.Drawing.Size(128, 19)
        Me.lbmontantsol.TabIndex = 25
        Me.lbmontantsol.Text = "Monatant Sollicité :"
        '
        'txtDiference
        '
        '
        '
        '
        Me.txtDiference.CustomButton.Image = Nothing
        Me.txtDiference.CustomButton.Location = New System.Drawing.Point(391, 1)
        Me.txtDiference.CustomButton.Name = ""
        Me.txtDiference.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDiference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDiference.CustomButton.TabIndex = 1
        Me.txtDiference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDiference.CustomButton.UseSelectable = True
        Me.txtDiference.CustomButton.Visible = False
        Me.txtDiference.Enabled = False
        Me.txtDiference.Lines = New String(-1) {}
        Me.txtDiference.Location = New System.Drawing.Point(145, 56)
        Me.txtDiference.MaxLength = 32767
        Me.txtDiference.Name = "txtDiference"
        Me.txtDiference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDiference.SelectedText = ""
        Me.txtDiference.SelectionLength = 0
        Me.txtDiference.SelectionStart = 0
        Me.txtDiference.ShortcutsEnabled = True
        Me.txtDiference.Size = New System.Drawing.Size(413, 23)
        Me.txtDiference.TabIndex = 7
        Me.txtDiference.UseSelectable = True
        Me.txtDiference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDiference.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(419, 26)
        Me.txtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(440, 29)
        Me.txtDate.TabIndex = 23
        '
        'txtActiviteMenee
        '
        '
        '
        '
        Me.txtActiviteMenee.CustomButton.Image = Nothing
        Me.txtActiviteMenee.CustomButton.Location = New System.Drawing.Point(391, 1)
        Me.txtActiviteMenee.CustomButton.Name = ""
        Me.txtActiviteMenee.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtActiviteMenee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtActiviteMenee.CustomButton.TabIndex = 1
        Me.txtActiviteMenee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtActiviteMenee.CustomButton.UseSelectable = True
        Me.txtActiviteMenee.CustomButton.Visible = False
        Me.txtActiviteMenee.Lines = New String(-1) {}
        Me.txtActiviteMenee.Location = New System.Drawing.Point(411, 282)
        Me.txtActiviteMenee.MaxLength = 32767
        Me.txtActiviteMenee.Name = "txtActiviteMenee"
        Me.txtActiviteMenee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtActiviteMenee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtActiviteMenee.SelectedText = ""
        Me.txtActiviteMenee.SelectionLength = 0
        Me.txtActiviteMenee.SelectionStart = 0
        Me.txtActiviteMenee.ShortcutsEnabled = True
        Me.txtActiviteMenee.Size = New System.Drawing.Size(413, 23)
        Me.txtActiviteMenee.TabIndex = 27
        Me.txtActiviteMenee.UseSelectable = True
        Me.txtActiviteMenee.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtActiviteMenee.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(266, 26)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel9.TabIndex = 26
        Me.MetroLabel9.Text = "Date :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(266, 69)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel8.TabIndex = 25
        Me.MetroLabel8.Text = "Type Don :"
        '
        'linkmateriel
        '
        Me.linkmateriel.Location = New System.Drawing.Point(643, 71)
        Me.linkmateriel.Name = "linkmateriel"
        Me.linkmateriel.Size = New System.Drawing.Size(143, 14)
        Me.linkmateriel.TabIndex = 29
        Me.linkmateriel.Text = "Liste de Materiels"
        Me.linkmateriel.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(266, 287)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel3.TabIndex = 24
        Me.MetroLabel3.Text = "Activité Menée :"
        '
        'tgp2
        '
        Me.tgp2.Controls.Add(Me.cmbCodeRevenu)
        Me.tgp2.Controls.Add(Me.cmbActiviteFinancier)
        Me.tgp2.Controls.Add(Me.cmbDepartement)
        Me.tgp2.Controls.Add(Me.MetroLabel10)
        Me.tgp2.Controls.Add(Me.MetroLabel11)
        Me.tgp2.Controls.Add(Me.MetroLabel12)
        Me.tgp2.Controls.Add(Me.MetroLabel13)
        Me.tgp2.Controls.Add(Me.txtNoteRestriction)
        Me.tgp2.HorizontalScrollbarBarColor = True
        Me.tgp2.HorizontalScrollbarHighlightOnWheel = False
        Me.tgp2.HorizontalScrollbarSize = 10
        Me.tgp2.Location = New System.Drawing.Point(4, 41)
        Me.tgp2.Name = "tgp2"
        Me.tgp2.Size = New System.Drawing.Size(1160, 332)
        Me.tgp2.TabIndex = 1
        Me.tgp2.Text = "Utilistation DON    /"
        Me.tgp2.VerticalScrollbarBarColor = True
        Me.tgp2.VerticalScrollbarHighlightOnWheel = False
        Me.tgp2.VerticalScrollbarSize = 10
        '
        'cmbCodeRevenu
        '
        Me.cmbCodeRevenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodeRevenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCodeRevenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodeRevenu.FormattingEnabled = True
        Me.cmbCodeRevenu.Location = New System.Drawing.Point(514, 193)
        Me.cmbCodeRevenu.Name = "cmbCodeRevenu"
        Me.cmbCodeRevenu.Size = New System.Drawing.Size(262, 29)
        Me.cmbCodeRevenu.TabIndex = 27
        '
        'cmbActiviteFinancier
        '
        Me.cmbActiviteFinancier.FormattingEnabled = True
        Me.cmbActiviteFinancier.ItemHeight = 23
        Me.cmbActiviteFinancier.Items.AddRange(New Object() {"Administration Général", "Finace et Comptabilité"})
        Me.cmbActiviteFinancier.Location = New System.Drawing.Point(514, 159)
        Me.cmbActiviteFinancier.Name = "cmbActiviteFinancier"
        Me.cmbActiviteFinancier.Size = New System.Drawing.Size(262, 29)
        Me.cmbActiviteFinancier.TabIndex = 25
        Me.cmbActiviteFinancier.UseSelectable = True
        '
        'cmbDepartement
        '
        Me.cmbDepartement.FormattingEnabled = True
        Me.cmbDepartement.ItemHeight = 23
        Me.cmbDepartement.Items.AddRange(New Object() {"Administration Général", "Finace et Comptabilité"})
        Me.cmbDepartement.Location = New System.Drawing.Point(514, 228)
        Me.cmbDepartement.Name = "cmbDepartement"
        Me.cmbDepartement.Size = New System.Drawing.Size(262, 29)
        Me.cmbDepartement.TabIndex = 26
        Me.cmbDepartement.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(377, 238)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel10.TabIndex = 20
        Me.MetroLabel10.Text = "Département :"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(377, 202)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel11.TabIndex = 21
        Me.MetroLabel11.Text = "Code Revenu :"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(377, 165)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel12.TabIndex = 22
        Me.MetroLabel12.Text = "Activité Financer :"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(377, 76)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(156, 19)
        Me.MetroLabel13.TabIndex = 23
        Me.MetroLabel13.Text = "Note sur la Restriction :"
        '
        'txtNoteRestriction
        '
        '
        '
        '
        Me.txtNoteRestriction.CustomButton.Image = Nothing
        Me.txtNoteRestriction.CustomButton.Location = New System.Drawing.Point(350, 2)
        Me.txtNoteRestriction.CustomButton.Name = ""
        Me.txtNoteRestriction.CustomButton.Size = New System.Drawing.Size(51, 51)
        Me.txtNoteRestriction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNoteRestriction.CustomButton.TabIndex = 1
        Me.txtNoteRestriction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNoteRestriction.CustomButton.UseSelectable = True
        Me.txtNoteRestriction.CustomButton.Visible = False
        Me.txtNoteRestriction.Lines = New String(-1) {}
        Me.txtNoteRestriction.Location = New System.Drawing.Point(372, 97)
        Me.txtNoteRestriction.MaxLength = 32767
        Me.txtNoteRestriction.Multiline = True
        Me.txtNoteRestriction.Name = "txtNoteRestriction"
        Me.txtNoteRestriction.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoteRestriction.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoteRestriction.SelectedText = ""
        Me.txtNoteRestriction.SelectionLength = 0
        Me.txtNoteRestriction.SelectionStart = 0
        Me.txtNoteRestriction.ShortcutsEnabled = True
        Me.txtNoteRestriction.Size = New System.Drawing.Size(404, 56)
        Me.txtNoteRestriction.TabIndex = 24
        Me.txtNoteRestriction.UseSelectable = True
        Me.txtNoteRestriction.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNoteRestriction.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tgp3
        '
        Me.tgp3.Controls.Add(Me.MetroLabel22)
        Me.tgp3.Controls.Add(Me.MetroLabel21)
        Me.tgp3.Controls.Add(Me.btenregistrementdonneur)
        Me.tgp3.Controls.Add(Me.txtEmailDo)
        Me.tgp3.Controls.Add(Me.MetroLabel20)
        Me.tgp3.Controls.Add(Me.MetroLabel15)
        Me.tgp3.Controls.Add(Me.txtSiteInternet)
        Me.tgp3.Controls.Add(Me.MetroLabel19)
        Me.tgp3.Controls.Add(Me.MetroLabel16)
        Me.tgp3.Controls.Add(Me.txtTelDo)
        Me.tgp3.Controls.Add(Me.MetroLabel17)
        Me.tgp3.Controls.Add(Me.cmbResDon)
        Me.tgp3.Controls.Add(Me.MetroLabel18)
        Me.tgp3.Controls.Add(Me.txtAdresseDonneur)
        Me.tgp3.Controls.Add(Me.cmbCodeDonneur)
        Me.tgp3.Controls.Add(Me.cmbDonneur)
        Me.tgp3.Controls.Add(Me.cmbCategorieDonneur)
        Me.tgp3.HorizontalScrollbarBarColor = True
        Me.tgp3.HorizontalScrollbarHighlightOnWheel = False
        Me.tgp3.HorizontalScrollbarSize = 10
        Me.tgp3.Location = New System.Drawing.Point(4, 41)
        Me.tgp3.Name = "tgp3"
        Me.tgp3.Size = New System.Drawing.Size(1160, 332)
        Me.tgp3.TabIndex = 2
        Me.tgp3.Text = "Information Donneur"
        Me.tgp3.VerticalScrollbarBarColor = True
        Me.tgp3.VerticalScrollbarHighlightOnWheel = False
        Me.tgp3.VerticalScrollbarSize = 10
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(251, 116)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel22.TabIndex = 35
        Me.MetroLabel22.Text = "Code Donneur :"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(251, 153)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(135, 19)
        Me.MetroLabel21.TabIndex = 34
        Me.MetroLabel21.Text = "Categorie Donneur :"
        '
        'btenregistrementdonneur
        '
        Me.btenregistrementdonneur.Location = New System.Drawing.Point(406, 70)
        Me.btenregistrementdonneur.Name = "btenregistrementdonneur"
        Me.btenregistrementdonneur.Size = New System.Drawing.Size(188, 19)
        Me.btenregistrementdonneur.TabIndex = 36
        Me.btenregistrementdonneur.Text = "Enregistrer Nouveau Donneur"
        Me.btenregistrementdonneur.UseSelectable = True
        '
        'txtEmailDo
        '
        '
        '
        '
        Me.txtEmailDo.CustomButton.Image = Nothing
        Me.txtEmailDo.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.txtEmailDo.CustomButton.Name = ""
        Me.txtEmailDo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailDo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailDo.CustomButton.TabIndex = 1
        Me.txtEmailDo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailDo.CustomButton.UseSelectable = True
        Me.txtEmailDo.CustomButton.Visible = False
        Me.txtEmailDo.Lines = New String(-1) {}
        Me.txtEmailDo.Location = New System.Drawing.Point(693, 87)
        Me.txtEmailDo.MaxLength = 32767
        Me.txtEmailDo.Name = "txtEmailDo"
        Me.txtEmailDo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailDo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailDo.SelectedText = ""
        Me.txtEmailDo.SelectionLength = 0
        Me.txtEmailDo.SelectionStart = 0
        Me.txtEmailDo.ShortcutsEnabled = True
        Me.txtEmailDo.Size = New System.Drawing.Size(216, 23)
        Me.txtEmailDo.TabIndex = 44
        Me.txtEmailDo.UseSelectable = True
        Me.txtEmailDo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailDo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(251, 185)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel20.TabIndex = 33
        Me.MetroLabel20.Text = "Nom du Donneur :"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(604, 87)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel15.TabIndex = 28
        Me.MetroLabel15.Text = "Email :"
        '
        'txtSiteInternet
        '
        '
        '
        '
        Me.txtSiteInternet.CustomButton.Image = Nothing
        Me.txtSiteInternet.CustomButton.Location = New System.Drawing.Point(481, 1)
        Me.txtSiteInternet.CustomButton.Name = ""
        Me.txtSiteInternet.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSiteInternet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSiteInternet.CustomButton.TabIndex = 1
        Me.txtSiteInternet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSiteInternet.CustomButton.UseSelectable = True
        Me.txtSiteInternet.CustomButton.Visible = False
        Me.txtSiteInternet.Lines = New String(-1) {}
        Me.txtSiteInternet.Location = New System.Drawing.Point(406, 240)
        Me.txtSiteInternet.MaxLength = 32767
        Me.txtSiteInternet.Name = "txtSiteInternet"
        Me.txtSiteInternet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSiteInternet.ReadOnly = True
        Me.txtSiteInternet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSiteInternet.SelectedText = ""
        Me.txtSiteInternet.SelectionLength = 0
        Me.txtSiteInternet.SelectionStart = 0
        Me.txtSiteInternet.ShortcutsEnabled = True
        Me.txtSiteInternet.Size = New System.Drawing.Size(503, 23)
        Me.txtSiteInternet.TabIndex = 42
        Me.txtSiteInternet.UseSelectable = True
        Me.txtSiteInternet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSiteInternet.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(251, 214)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel19.TabIndex = 32
        Me.MetroLabel19.Text = "Adress Donneur :"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(604, 150)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel16.TabIndex = 29
        Me.MetroLabel16.Text = "Restriction :"
        '
        'txtTelDo
        '
        '
        '
        '
        Me.txtTelDo.CustomButton.Image = Nothing
        Me.txtTelDo.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.txtTelDo.CustomButton.Name = ""
        Me.txtTelDo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelDo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelDo.CustomButton.TabIndex = 1
        Me.txtTelDo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelDo.CustomButton.UseSelectable = True
        Me.txtTelDo.CustomButton.Visible = False
        Me.txtTelDo.Lines = New String(-1) {}
        Me.txtTelDo.Location = New System.Drawing.Point(693, 116)
        Me.txtTelDo.MaxLength = 32767
        Me.txtTelDo.Name = "txtTelDo"
        Me.txtTelDo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelDo.ReadOnly = True
        Me.txtTelDo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelDo.SelectedText = ""
        Me.txtTelDo.SelectionLength = 0
        Me.txtTelDo.SelectionStart = 0
        Me.txtTelDo.ShortcutsEnabled = True
        Me.txtTelDo.Size = New System.Drawing.Size(216, 23)
        Me.txtTelDo.TabIndex = 43
        Me.txtTelDo.UseSelectable = True
        Me.txtTelDo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelDo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(604, 115)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel17.TabIndex = 30
        Me.MetroLabel17.Text = "Pone1 :"
        '
        'cmbResDon
        '
        Me.cmbResDon.FormattingEnabled = True
        Me.cmbResDon.ItemHeight = 23
        Me.cmbResDon.Items.AddRange(New Object() {"", "SOLLICITER", "NON SOLLICITER"})
        Me.cmbResDon.Location = New System.Drawing.Point(693, 143)
        Me.cmbResDon.Name = "cmbResDon"
        Me.cmbResDon.Size = New System.Drawing.Size(216, 29)
        Me.cmbResDon.TabIndex = 37
        Me.cmbResDon.UseSelectable = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(251, 244)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel18.TabIndex = 31
        Me.MetroLabel18.Text = "Site Internet :"
        '
        'txtAdresseDonneur
        '
        '
        '
        '
        Me.txtAdresseDonneur.CustomButton.Image = Nothing
        Me.txtAdresseDonneur.CustomButton.Location = New System.Drawing.Point(481, 1)
        Me.txtAdresseDonneur.CustomButton.Name = ""
        Me.txtAdresseDonneur.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAdresseDonneur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresseDonneur.CustomButton.TabIndex = 1
        Me.txtAdresseDonneur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresseDonneur.CustomButton.UseSelectable = True
        Me.txtAdresseDonneur.CustomButton.Visible = False
        Me.txtAdresseDonneur.Lines = New String(-1) {}
        Me.txtAdresseDonneur.Location = New System.Drawing.Point(406, 210)
        Me.txtAdresseDonneur.MaxLength = 32767
        Me.txtAdresseDonneur.Name = "txtAdresseDonneur"
        Me.txtAdresseDonneur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresseDonneur.ReadOnly = True
        Me.txtAdresseDonneur.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresseDonneur.SelectedText = ""
        Me.txtAdresseDonneur.SelectionLength = 0
        Me.txtAdresseDonneur.SelectionStart = 0
        Me.txtAdresseDonneur.ShortcutsEnabled = True
        Me.txtAdresseDonneur.Size = New System.Drawing.Size(503, 23)
        Me.txtAdresseDonneur.TabIndex = 41
        Me.txtAdresseDonneur.UseSelectable = True
        Me.txtAdresseDonneur.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresseDonneur.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbCodeDonneur
        '
        Me.cmbCodeDonneur.FormattingEnabled = True
        Me.cmbCodeDonneur.ItemHeight = 23
        Me.cmbCodeDonneur.Location = New System.Drawing.Point(406, 106)
        Me.cmbCodeDonneur.Name = "cmbCodeDonneur"
        Me.cmbCodeDonneur.Size = New System.Drawing.Size(188, 29)
        Me.cmbCodeDonneur.TabIndex = 38
        Me.cmbCodeDonneur.UseSelectable = True
        '
        'cmbDonneur
        '
        Me.cmbDonneur.FormattingEnabled = True
        Me.cmbDonneur.ItemHeight = 23
        Me.cmbDonneur.Location = New System.Drawing.Point(406, 177)
        Me.cmbDonneur.Name = "cmbDonneur"
        Me.cmbDonneur.Size = New System.Drawing.Size(503, 29)
        Me.cmbDonneur.TabIndex = 39
        Me.cmbDonneur.UseSelectable = True
        '
        'cmbCategorieDonneur
        '
        Me.cmbCategorieDonneur.FormattingEnabled = True
        Me.cmbCategorieDonneur.ItemHeight = 23
        Me.cmbCategorieDonneur.Location = New System.Drawing.Point(406, 143)
        Me.cmbCategorieDonneur.Name = "cmbCategorieDonneur"
        Me.cmbCategorieDonneur.Size = New System.Drawing.Size(188, 29)
        Me.cmbCategorieDonneur.TabIndex = 40
        Me.cmbCategorieDonneur.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckDonneur)
        Me.GroupBox1.Controls.Add(Me.ckActivite)
        Me.GroupBox1.Controls.Add(Me.ckTypeDon)
        Me.GroupBox1.Controls.Add(Me.ckDate)
        Me.GroupBox1.Controls.Add(Me.cmbDate)
        Me.GroupBox1.Controls.Add(Me.txtRechActiviteMenee)
        Me.GroupBox1.Controls.Add(Me.cmbRechDonneur)
        Me.GroupBox1.Controls.Add(Me.cmbRechTypeDon)
        Me.GroupBox1.Controls.Add(Me.btRecher)
        Me.GroupBox1.Controls.Add(Me.btvidrecher)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1171, 108)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche Rapide"
        '
        'ckDonneur
        '
        Me.ckDonneur.AutoSize = True
        Me.ckDonneur.Location = New System.Drawing.Point(474, 72)
        Me.ckDonneur.Name = "ckDonneur"
        Me.ckDonneur.Size = New System.Drawing.Size(146, 15)
        Me.ckDonneur.TabIndex = 25
        Me.ckDonneur.Text = "Recherche par donneur"
        Me.ckDonneur.UseSelectable = True
        '
        'ckActivite
        '
        Me.ckActivite.AutoSize = True
        Me.ckActivite.Location = New System.Drawing.Point(22, 72)
        Me.ckActivite.Name = "ckActivite"
        Me.ckActivite.Size = New System.Drawing.Size(187, 15)
        Me.ckActivite.TabIndex = 24
        Me.ckActivite.Text = "Recherche par activité financée"
        Me.ckActivite.UseSelectable = True
        '
        'ckTypeDon
        '
        Me.ckTypeDon.AutoSize = True
        Me.ckTypeDon.Location = New System.Drawing.Point(474, 29)
        Me.ckTypeDon.Name = "ckTypeDon"
        Me.ckTypeDon.Size = New System.Drawing.Size(154, 15)
        Me.ckTypeDon.TabIndex = 23
        Me.ckTypeDon.Text = "Recherche par Typr DON"
        Me.ckTypeDon.UseSelectable = True
        '
        'ckDate
        '
        Me.ckDate.AutoSize = True
        Me.ckDate.Location = New System.Drawing.Point(22, 29)
        Me.ckDate.Name = "ckDate"
        Me.ckDate.Size = New System.Drawing.Size(124, 15)
        Me.ckDate.TabIndex = 22
        Me.ckDate.Text = "Recherche par date"
        Me.ckDate.UseSelectable = True
        '
        'cmbDate
        '
        Me.cmbDate.Enabled = False
        Me.cmbDate.Location = New System.Drawing.Point(218, 22)
        Me.cmbDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(231, 29)
        Me.cmbDate.TabIndex = 21
        '
        'txtRechActiviteMenee
        '
        '
        '
        '
        Me.txtRechActiviteMenee.CustomButton.Image = Nothing
        Me.txtRechActiviteMenee.CustomButton.Location = New System.Drawing.Point(202, 1)
        Me.txtRechActiviteMenee.CustomButton.Name = ""
        Me.txtRechActiviteMenee.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txtRechActiviteMenee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRechActiviteMenee.CustomButton.TabIndex = 1
        Me.txtRechActiviteMenee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRechActiviteMenee.CustomButton.UseSelectable = True
        Me.txtRechActiviteMenee.CustomButton.Visible = False
        Me.txtRechActiviteMenee.Enabled = False
        Me.txtRechActiviteMenee.Lines = New String(-1) {}
        Me.txtRechActiviteMenee.Location = New System.Drawing.Point(217, 64)
        Me.txtRechActiviteMenee.MaxLength = 32767
        Me.txtRechActiviteMenee.Name = "txtRechActiviteMenee"
        Me.txtRechActiviteMenee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRechActiviteMenee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRechActiviteMenee.SelectedText = ""
        Me.txtRechActiviteMenee.SelectionLength = 0
        Me.txtRechActiviteMenee.SelectionStart = 0
        Me.txtRechActiviteMenee.ShortcutsEnabled = True
        Me.txtRechActiviteMenee.Size = New System.Drawing.Size(232, 31)
        Me.txtRechActiviteMenee.TabIndex = 20
        Me.txtRechActiviteMenee.UseSelectable = True
        Me.txtRechActiviteMenee.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRechActiviteMenee.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbRechTypeDon
        '
        Me.cmbRechTypeDon.Enabled = False
        Me.cmbRechTypeDon.FormattingEnabled = True
        Me.cmbRechTypeDon.ItemHeight = 23
        Me.cmbRechTypeDon.Location = New System.Drawing.Point(662, 22)
        Me.cmbRechTypeDon.Name = "cmbRechTypeDon"
        Me.cmbRechTypeDon.Size = New System.Drawing.Size(231, 29)
        Me.cmbRechTypeDon.TabIndex = 18
        Me.cmbRechTypeDon.UseSelectable = True
        '
        'btRecher
        '
        Me.btRecher.Location = New System.Drawing.Point(940, 65)
        Me.btRecher.Name = "btRecher"
        Me.btRecher.Size = New System.Drawing.Size(165, 30)
        Me.btRecher.TabIndex = 10
        Me.btRecher.Text = "Rechercher"
        Me.btRecher.UseSelectable = True
        '
        'btvidrecher
        '
        Me.btvidrecher.Location = New System.Drawing.Point(940, 25)
        Me.btvidrecher.Name = "btvidrecher"
        Me.btvidrecher.Size = New System.Drawing.Size(165, 30)
        Me.btvidrecher.TabIndex = 9
        Me.btvidrecher.Text = "Vider les case de recherche"
        Me.btvidrecher.UseSelectable = True
        '
        'btenregistrer
        '
        Me.btenregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btenregistrer.Location = New System.Drawing.Point(878, 316)
        Me.btenregistrer.Name = "btenregistrer"
        Me.btenregistrer.Size = New System.Drawing.Size(171, 30)
        Me.btenregistrer.TabIndex = 1
        Me.btenregistrer.Text = "Mettre à Jour"
        Me.btenregistrer.UseSelectable = True
        '
        'btannuler
        '
        Me.btannuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btannuler.Location = New System.Drawing.Point(701, 316)
        Me.btannuler.Name = "btannuler"
        Me.btannuler.Size = New System.Drawing.Size(171, 30)
        Me.btannuler.TabIndex = 2
        Me.btannuler.Text = "Vider les champs mise à jour"
        Me.btannuler.UseSelectable = True
        Me.btannuler.Visible = False
        '
        'ListDon
        '
        Me.ListDon.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListDon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.ListDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDon.FullRowSelect = True
        Me.ListDon.GridLines = True
        Me.ListDon.Location = New System.Drawing.Point(20, 177)
        Me.ListDon.Name = "ListDon"
        Me.ListDon.Size = New System.Drawing.Size(1168, 128)
        Me.ListDon.TabIndex = 0
        Me.ListDon.UseCompatibleStateImageBehavior = False
        Me.ListDon.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TYPE DON"
        Me.ColumnHeader1.Width = 181
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MONTANT RECU"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PAR"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 202
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NOM DONNEUR"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 251
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "RESTRICTION"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 180
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CODE REVENU"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 196
        '
        'btfermer
        '
        Me.btfermer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btfermer.Location = New System.Drawing.Point(1061, 316)
        Me.btfermer.Name = "btfermer"
        Me.btfermer.Size = New System.Drawing.Size(125, 30)
        Me.btfermer.TabIndex = 0
        Me.btfermer.Text = "Fermer"
        Me.btfermer.UseSelectable = True
        '
        'cmbRechDonneur
        '
        Me.cmbRechDonneur.Enabled = False
        Me.cmbRechDonneur.FormattingEnabled = True
        Me.cmbRechDonneur.ItemHeight = 23
        Me.cmbRechDonneur.Location = New System.Drawing.Point(662, 65)
        Me.cmbRechDonneur.Name = "cmbRechDonneur"
        Me.cmbRechDonneur.Size = New System.Drawing.Size(231, 29)
        Me.cmbRechDonneur.TabIndex = 18
        Me.cmbRechDonneur.UseSelectable = True
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "index"
        Me.ColumnHeader8.Width = 0
        '
        'MajDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 772)
        Me.Controls.Add(Me.ListDon)
        Me.Controls.Add(Me.btfermer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabDetails)
        Me.Controls.Add(Me.btenregistrer)
        Me.Controls.Add(Me.btannuler)
        Me.Name = "MajDon"
        Me.Text = "                                                             Formulaire de Vue et" & _
    " de Mise à Jour des DONS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabDetails.ResumeLayout(False)
        Me.tgp1.ResumeLayout(False)
        Me.tgp1.PerformLayout()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.tgp2.ResumeLayout(False)
        Me.tgp2.PerformLayout()
        Me.tgp3.ResumeLayout(False)
        Me.tgp3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btRecher As MetroFramework.Controls.MetroButton
    Friend WithEvents btvidrecher As MetroFramework.Controls.MetroButton
    Friend WithEvents ListDon As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ckDonneur As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckActivite As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckTypeDon As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ckDate As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtRechActiviteMenee As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbRechTypeDon As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabDetails As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tgp1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tgp2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tgp3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btenregistrer As MetroFramework.Controls.MetroButton
    Friend WithEvents btannuler As MetroFramework.Controls.MetroButton
    Friend WithEvents btfermer As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbCodeRevenu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbActiviteFinancier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDepartement As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNoteRestriction As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btenregistrementdonneur As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEmailDo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSiteInternet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTelDo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbResDon As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAdresseDonneur As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbCodeDonneur As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDonneur As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbCategorieDonneur As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ckMaterial As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckArgent As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ckResIllimite As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckResLimite As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckSansResctriction As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ckVirement As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckEspece As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ckCheque As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtMontantSollicite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Lbnumchek As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbmodrestric As MetroFramework.Controls.MetroLabel
    Friend WithEvents ckNonSollicite As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbdifference As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontrecu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbmontantrecu As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumCheque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbmontantsol As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDiference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtActiviteMenee As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents linkmateriel As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbRechDonneur As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
