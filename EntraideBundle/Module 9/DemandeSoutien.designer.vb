<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemandeSoutien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemandeSoutien))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btSave = New MetroFramework.Controls.MetroButton()
        Me.btClean = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPeriodeGrace = New MetroFramework.Controls.MetroTextBox()
        Me.txtNetAPayer = New MetroFramework.Controls.MetroTextBox()
        Me.txtPenalite = New MetroFramework.Controls.MetroTextBox()
        Me.txtPaiementRestant = New MetroFramework.Controls.MetroTextBox()
        Me.txtPaimentRetard = New MetroFramework.Controls.MetroTextBox()
        Me.txtNbrePaiementEffec = New MetroFramework.Controls.MetroTextBox()
        Me.txtNbreRepaiement = New MetroFramework.Controls.MetroTextBox()
        Me.txtDelais = New MetroFramework.Controls.MetroTextBox()
        Me.txtInteret = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtMontantHIC = New MetroFramework.Controls.MetroTextBox()
        Me.dtFinPaiement = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.dtDebutPaiement = New MetroFramework.Controls.MetroDateTime()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEtudiant = New System.Windows.Forms.ComboBox()
        Me.chkVirement = New MetroFramework.Controls.MetroRadioButton()
        Me.chkCheque = New MetroFramework.Controls.MetroRadioButton()
        Me.chkEspece = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkEtudiant = New MetroFramework.Controls.MetroLink()
        Me.txtTypeBusiness = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontantRecu = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontantSoli = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumCheque = New MetroFramework.Controls.MetroTextBox()
        Me.dt_date = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.btSave)
        Me.PanelContainer.Controls.Add(Me.btClean)
        Me.PanelContainer.Controls.Add(Me.GroupBox2)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 59)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1185, 588)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(642, 508)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'btSave
        '
        Me.btSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSave.Location = New System.Drawing.Point(545, 508)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(91, 35)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "Enregistrer"
        Me.btSave.UseSelectable = True
        '
        'btClean
        '
        Me.btClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClean.Location = New System.Drawing.Point(448, 508)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(91, 35)
        Me.btClean.TabIndex = 5
        Me.btClean.Text = "Vider"
        Me.btClean.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPeriodeGrace)
        Me.GroupBox2.Controls.Add(Me.txtNetAPayer)
        Me.GroupBox2.Controls.Add(Me.txtPenalite)
        Me.GroupBox2.Controls.Add(Me.txtPaiementRestant)
        Me.GroupBox2.Controls.Add(Me.txtPaimentRetard)
        Me.GroupBox2.Controls.Add(Me.txtNbrePaiementEffec)
        Me.GroupBox2.Controls.Add(Me.txtNbreRepaiement)
        Me.GroupBox2.Controls.Add(Me.txtDelais)
        Me.GroupBox2.Controls.Add(Me.txtInteret)
        Me.GroupBox2.Controls.Add(Me.MetroLabel19)
        Me.GroupBox2.Controls.Add(Me.MetroLabel18)
        Me.GroupBox2.Controls.Add(Me.MetroLabel17)
        Me.GroupBox2.Controls.Add(Me.MetroLabel16)
        Me.GroupBox2.Controls.Add(Me.MetroLabel15)
        Me.GroupBox2.Controls.Add(Me.MetroLabel13)
        Me.GroupBox2.Controls.Add(Me.MetroLabel14)
        Me.GroupBox2.Controls.Add(Me.MetroLabel12)
        Me.GroupBox2.Controls.Add(Me.MetroLabel11)
        Me.GroupBox2.Controls.Add(Me.MetroLabel10)
        Me.GroupBox2.Controls.Add(Me.MetroLabel9)
        Me.GroupBox2.Controls.Add(Me.txtMontantHIC)
        Me.GroupBox2.Controls.Add(Me.dtFinPaiement)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.dtDebutPaiement)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1165, 284)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info sur le fond"
        '
        'txtPeriodeGrace
        '
        '
        '
        '
        Me.txtPeriodeGrace.CustomButton.Image = Nothing
        Me.txtPeriodeGrace.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtPeriodeGrace.CustomButton.Name = ""
        Me.txtPeriodeGrace.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPeriodeGrace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPeriodeGrace.CustomButton.TabIndex = 1
        Me.txtPeriodeGrace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPeriodeGrace.CustomButton.UseSelectable = True
        Me.txtPeriodeGrace.CustomButton.Visible = False
        Me.txtPeriodeGrace.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPeriodeGrace.Lines = New String() {"0"}
        Me.txtPeriodeGrace.Location = New System.Drawing.Point(263, 158)
        Me.txtPeriodeGrace.MaxLength = 32767
        Me.txtPeriodeGrace.Name = "txtPeriodeGrace"
        Me.txtPeriodeGrace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeriodeGrace.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPeriodeGrace.SelectedText = ""
        Me.txtPeriodeGrace.SelectionLength = 0
        Me.txtPeriodeGrace.SelectionStart = 0
        Me.txtPeriodeGrace.ShortcutsEnabled = True
        Me.txtPeriodeGrace.Size = New System.Drawing.Size(303, 30)
        Me.txtPeriodeGrace.TabIndex = 3
        Me.txtPeriodeGrace.Text = "0"
        Me.txtPeriodeGrace.UseSelectable = True
        Me.txtPeriodeGrace.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPeriodeGrace.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNetAPayer
        '
        '
        '
        '
        Me.txtNetAPayer.CustomButton.Image = Nothing
        Me.txtNetAPayer.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtNetAPayer.CustomButton.Name = ""
        Me.txtNetAPayer.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNetAPayer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNetAPayer.CustomButton.TabIndex = 1
        Me.txtNetAPayer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNetAPayer.CustomButton.UseSelectable = True
        Me.txtNetAPayer.CustomButton.Visible = False
        Me.txtNetAPayer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNetAPayer.Lines = New String() {"0"}
        Me.txtNetAPayer.Location = New System.Drawing.Point(849, 80)
        Me.txtNetAPayer.MaxLength = 32767
        Me.txtNetAPayer.Name = "txtNetAPayer"
        Me.txtNetAPayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNetAPayer.ReadOnly = True
        Me.txtNetAPayer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNetAPayer.SelectedText = ""
        Me.txtNetAPayer.SelectionLength = 0
        Me.txtNetAPayer.SelectionStart = 0
        Me.txtNetAPayer.ShortcutsEnabled = True
        Me.txtNetAPayer.Size = New System.Drawing.Size(302, 30)
        Me.txtNetAPayer.TabIndex = 3
        Me.txtNetAPayer.Text = "0"
        Me.txtNetAPayer.UseSelectable = True
        Me.txtNetAPayer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNetAPayer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPenalite
        '
        '
        '
        '
        Me.txtPenalite.CustomButton.Image = Nothing
        Me.txtPenalite.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtPenalite.CustomButton.Name = ""
        Me.txtPenalite.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPenalite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPenalite.CustomButton.TabIndex = 1
        Me.txtPenalite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPenalite.CustomButton.UseSelectable = True
        Me.txtPenalite.CustomButton.Visible = False
        Me.txtPenalite.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPenalite.Lines = New String() {"0"}
        Me.txtPenalite.Location = New System.Drawing.Point(849, 39)
        Me.txtPenalite.MaxLength = 32767
        Me.txtPenalite.Name = "txtPenalite"
        Me.txtPenalite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPenalite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPenalite.SelectedText = ""
        Me.txtPenalite.SelectionLength = 0
        Me.txtPenalite.SelectionStart = 0
        Me.txtPenalite.ShortcutsEnabled = True
        Me.txtPenalite.Size = New System.Drawing.Size(302, 30)
        Me.txtPenalite.TabIndex = 3
        Me.txtPenalite.Text = "0"
        Me.txtPenalite.UseSelectable = True
        Me.txtPenalite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPenalite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPaiementRestant
        '
        '
        '
        '
        Me.txtPaiementRestant.CustomButton.Image = Nothing
        Me.txtPaiementRestant.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtPaiementRestant.CustomButton.Name = ""
        Me.txtPaiementRestant.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPaiementRestant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPaiementRestant.CustomButton.TabIndex = 1
        Me.txtPaiementRestant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPaiementRestant.CustomButton.UseSelectable = True
        Me.txtPaiementRestant.CustomButton.Visible = False
        Me.txtPaiementRestant.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPaiementRestant.Lines = New String() {"0"}
        Me.txtPaiementRestant.Location = New System.Drawing.Point(849, 238)
        Me.txtPaiementRestant.MaxLength = 32767
        Me.txtPaiementRestant.Name = "txtPaiementRestant"
        Me.txtPaiementRestant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaiementRestant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPaiementRestant.SelectedText = ""
        Me.txtPaiementRestant.SelectionLength = 0
        Me.txtPaiementRestant.SelectionStart = 0
        Me.txtPaiementRestant.ShortcutsEnabled = True
        Me.txtPaiementRestant.Size = New System.Drawing.Size(302, 30)
        Me.txtPaiementRestant.TabIndex = 3
        Me.txtPaiementRestant.Text = "0"
        Me.txtPaiementRestant.UseSelectable = True
        Me.txtPaiementRestant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPaiementRestant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPaimentRetard
        '
        '
        '
        '
        Me.txtPaimentRetard.CustomButton.Image = Nothing
        Me.txtPaimentRetard.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtPaimentRetard.CustomButton.Name = ""
        Me.txtPaimentRetard.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPaimentRetard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPaimentRetard.CustomButton.TabIndex = 1
        Me.txtPaimentRetard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPaimentRetard.CustomButton.UseSelectable = True
        Me.txtPaimentRetard.CustomButton.Visible = False
        Me.txtPaimentRetard.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPaimentRetard.Lines = New String() {"0"}
        Me.txtPaimentRetard.Location = New System.Drawing.Point(849, 196)
        Me.txtPaimentRetard.MaxLength = 32767
        Me.txtPaimentRetard.Name = "txtPaimentRetard"
        Me.txtPaimentRetard.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaimentRetard.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPaimentRetard.SelectedText = ""
        Me.txtPaimentRetard.SelectionLength = 0
        Me.txtPaimentRetard.SelectionStart = 0
        Me.txtPaimentRetard.ShortcutsEnabled = True
        Me.txtPaimentRetard.Size = New System.Drawing.Size(302, 30)
        Me.txtPaimentRetard.TabIndex = 3
        Me.txtPaimentRetard.Text = "0"
        Me.txtPaimentRetard.UseSelectable = True
        Me.txtPaimentRetard.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPaimentRetard.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNbrePaiementEffec
        '
        '
        '
        '
        Me.txtNbrePaiementEffec.CustomButton.Image = Nothing
        Me.txtNbrePaiementEffec.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtNbrePaiementEffec.CustomButton.Name = ""
        Me.txtNbrePaiementEffec.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNbrePaiementEffec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbrePaiementEffec.CustomButton.TabIndex = 1
        Me.txtNbrePaiementEffec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbrePaiementEffec.CustomButton.UseSelectable = True
        Me.txtNbrePaiementEffec.CustomButton.Visible = False
        Me.txtNbrePaiementEffec.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNbrePaiementEffec.Lines = New String() {"0"}
        Me.txtNbrePaiementEffec.Location = New System.Drawing.Point(849, 158)
        Me.txtNbrePaiementEffec.MaxLength = 32767
        Me.txtNbrePaiementEffec.Name = "txtNbrePaiementEffec"
        Me.txtNbrePaiementEffec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbrePaiementEffec.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbrePaiementEffec.SelectedText = ""
        Me.txtNbrePaiementEffec.SelectionLength = 0
        Me.txtNbrePaiementEffec.SelectionStart = 0
        Me.txtNbrePaiementEffec.ShortcutsEnabled = True
        Me.txtNbrePaiementEffec.Size = New System.Drawing.Size(302, 30)
        Me.txtNbrePaiementEffec.TabIndex = 3
        Me.txtNbrePaiementEffec.Text = "0"
        Me.txtNbrePaiementEffec.UseSelectable = True
        Me.txtNbrePaiementEffec.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbrePaiementEffec.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNbreRepaiement
        '
        '
        '
        '
        Me.txtNbreRepaiement.CustomButton.Image = Nothing
        Me.txtNbreRepaiement.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtNbreRepaiement.CustomButton.Name = ""
        Me.txtNbreRepaiement.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNbreRepaiement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbreRepaiement.CustomButton.TabIndex = 1
        Me.txtNbreRepaiement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbreRepaiement.CustomButton.UseSelectable = True
        Me.txtNbreRepaiement.CustomButton.Visible = False
        Me.txtNbreRepaiement.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNbreRepaiement.Lines = New String() {"1"}
        Me.txtNbreRepaiement.Location = New System.Drawing.Point(263, 238)
        Me.txtNbreRepaiement.MaxLength = 32767
        Me.txtNbreRepaiement.Name = "txtNbreRepaiement"
        Me.txtNbreRepaiement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbreRepaiement.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbreRepaiement.SelectedText = ""
        Me.txtNbreRepaiement.SelectionLength = 0
        Me.txtNbreRepaiement.SelectionStart = 0
        Me.txtNbreRepaiement.ShortcutsEnabled = True
        Me.txtNbreRepaiement.Size = New System.Drawing.Size(303, 30)
        Me.txtNbreRepaiement.TabIndex = 3
        Me.txtNbreRepaiement.Text = "1"
        Me.txtNbreRepaiement.UseSelectable = True
        Me.txtNbreRepaiement.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbreRepaiement.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDelais
        '
        '
        '
        '
        Me.txtDelais.CustomButton.Image = Nothing
        Me.txtDelais.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtDelais.CustomButton.Name = ""
        Me.txtDelais.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtDelais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDelais.CustomButton.TabIndex = 1
        Me.txtDelais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDelais.CustomButton.UseSelectable = True
        Me.txtDelais.CustomButton.Visible = False
        Me.txtDelais.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDelais.Lines = New String() {"0"}
        Me.txtDelais.Location = New System.Drawing.Point(263, 119)
        Me.txtDelais.MaxLength = 32767
        Me.txtDelais.Name = "txtDelais"
        Me.txtDelais.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDelais.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDelais.SelectedText = ""
        Me.txtDelais.SelectionLength = 0
        Me.txtDelais.SelectionStart = 0
        Me.txtDelais.ShortcutsEnabled = True
        Me.txtDelais.Size = New System.Drawing.Size(303, 30)
        Me.txtDelais.TabIndex = 3
        Me.txtDelais.Text = "0"
        Me.txtDelais.UseSelectable = True
        Me.txtDelais.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDelais.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtInteret
        '
        '
        '
        '
        Me.txtInteret.CustomButton.Image = Nothing
        Me.txtInteret.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtInteret.CustomButton.Name = ""
        Me.txtInteret.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtInteret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInteret.CustomButton.TabIndex = 1
        Me.txtInteret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInteret.CustomButton.UseSelectable = True
        Me.txtInteret.CustomButton.Visible = False
        Me.txtInteret.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtInteret.Lines = New String() {"0"}
        Me.txtInteret.Location = New System.Drawing.Point(263, 80)
        Me.txtInteret.MaxLength = 32767
        Me.txtInteret.Name = "txtInteret"
        Me.txtInteret.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInteret.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInteret.SelectedText = ""
        Me.txtInteret.SelectionLength = 0
        Me.txtInteret.SelectionStart = 0
        Me.txtInteret.ShortcutsEnabled = True
        Me.txtInteret.Size = New System.Drawing.Size(303, 30)
        Me.txtInteret.TabIndex = 3
        Me.txtInteret.Text = "0"
        Me.txtInteret.UseSelectable = True
        Me.txtInteret.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInteret.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(600, 86)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel19.TabIndex = 0
        Me.MetroLabel19.Text = "Net à payer"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(600, 45)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel18.TabIndex = 0
        Me.MetroLabel18.Text = "Charge/Pénalités"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(600, 244)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(185, 19)
        Me.MetroLabel17.TabIndex = 0
        Me.MetroLabel17.Text = "Nombre de paiements restant"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(600, 202)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(200, 19)
        Me.MetroLabel16.TabIndex = 0
        Me.MetroLabel16.Text = "Nombre de paiements en retard"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(600, 164)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(197, 19)
        Me.MetroLabel15.TabIndex = 0
        Me.MetroLabel15.Text = "Nombre de paiements éffectués"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(14, 244)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(228, 19)
        Me.MetroLabel13.TabIndex = 0
        Me.MetroLabel13.Text = "Nombre de période de repaiement *"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(600, 125)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(151, 19)
        Me.MetroLabel14.TabIndex = 0
        Me.MetroLabel14.Text = "Date de fin de paiement"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(14, 202)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(181, 19)
        Me.MetroLabel12.TabIndex = 0
        Me.MetroLabel12.Text = "Date du début de paiement *"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(14, 164)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(169, 19)
        Me.MetroLabel11.TabIndex = 0
        Me.MetroLabel11.Text = "Période de grâce (en mois)"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(14, 125)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(234, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "Délai de paiement du fond (en mois) *"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(14, 86)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "Intérêt"
        '
        'txtMontantHIC
        '
        '
        '
        '
        Me.txtMontantHIC.CustomButton.Image = Nothing
        Me.txtMontantHIC.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtMontantHIC.CustomButton.Name = ""
        Me.txtMontantHIC.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantHIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantHIC.CustomButton.TabIndex = 1
        Me.txtMontantHIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantHIC.CustomButton.UseSelectable = True
        Me.txtMontantHIC.CustomButton.Visible = False
        Me.txtMontantHIC.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantHIC.Lines = New String() {"0"}
        Me.txtMontantHIC.Location = New System.Drawing.Point(263, 39)
        Me.txtMontantHIC.MaxLength = 32767
        Me.txtMontantHIC.Name = "txtMontantHIC"
        Me.txtMontantHIC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantHIC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantHIC.SelectedText = ""
        Me.txtMontantHIC.SelectionLength = 0
        Me.txtMontantHIC.SelectionStart = 0
        Me.txtMontantHIC.ShortcutsEnabled = True
        Me.txtMontantHIC.Size = New System.Drawing.Size(303, 30)
        Me.txtMontantHIC.TabIndex = 3
        Me.txtMontantHIC.Text = "0"
        Me.txtMontantHIC.UseSelectable = True
        Me.txtMontantHIC.Visible = False
        Me.txtMontantHIC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantHIC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtFinPaiement
        '
        Me.dtFinPaiement.Location = New System.Drawing.Point(849, 120)
        Me.dtFinPaiement.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFinPaiement.Name = "dtFinPaiement"
        Me.dtFinPaiement.Size = New System.Drawing.Size(302, 29)
        Me.dtFinPaiement.TabIndex = 1
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(14, 45)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel8.TabIndex = 0
        Me.MetroLabel8.Text = "Montant HIC à repayer"
        Me.MetroLabel8.Visible = False
        '
        'dtDebutPaiement
        '
        Me.dtDebutPaiement.Location = New System.Drawing.Point(263, 197)
        Me.dtDebutPaiement.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDebutPaiement.Name = "dtDebutPaiement"
        Me.dtDebutPaiement.Size = New System.Drawing.Size(303, 29)
        Me.dtDebutPaiement.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEtudiant)
        Me.GroupBox1.Controls.Add(Me.chkVirement)
        Me.GroupBox1.Controls.Add(Me.chkCheque)
        Me.GroupBox1.Controls.Add(Me.chkEspece)
        Me.GroupBox1.Controls.Add(Me.lnkEtudiant)
        Me.GroupBox1.Controls.Add(Me.txtTypeBusiness)
        Me.GroupBox1.Controls.Add(Me.txtMontantRecu)
        Me.GroupBox1.Controls.Add(Me.txtMontantSoli)
        Me.GroupBox1.Controls.Add(Me.txtNumCheque)
        Me.GroupBox1.Controls.Add(Me.dt_date)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1165, 193)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Infos générales"
        '
        'cmbEtudiant
        '
        Me.cmbEtudiant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEtudiant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEtudiant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEtudiant.FormattingEnabled = True
        Me.cmbEtudiant.Location = New System.Drawing.Point(199, 67)
        Me.cmbEtudiant.Name = "cmbEtudiant"
        Me.cmbEtudiant.Size = New System.Drawing.Size(222, 29)
        Me.cmbEtudiant.TabIndex = 7
        '
        'chkVirement
        '
        Me.chkVirement.AutoSize = True
        Me.chkVirement.Location = New System.Drawing.Point(1029, 82)
        Me.chkVirement.Name = "chkVirement"
        Me.chkVirement.Size = New System.Drawing.Size(71, 15)
        Me.chkVirement.TabIndex = 6
        Me.chkVirement.Text = "Virement"
        Me.chkVirement.UseSelectable = True
        '
        'chkCheque
        '
        Me.chkCheque.AutoSize = True
        Me.chkCheque.Location = New System.Drawing.Point(919, 82)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(64, 15)
        Me.chkCheque.TabIndex = 6
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.UseSelectable = True
        '
        'chkEspece
        '
        Me.chkEspece.AutoSize = True
        Me.chkEspece.Checked = True
        Me.chkEspece.Location = New System.Drawing.Point(823, 82)
        Me.chkEspece.Name = "chkEspece"
        Me.chkEspece.Size = New System.Drawing.Size(59, 15)
        Me.chkEspece.TabIndex = 6
        Me.chkEspece.TabStop = True
        Me.chkEspece.Text = "Espèce"
        Me.chkEspece.UseSelectable = True
        '
        'lnkEtudiant
        '
        Me.lnkEtudiant.Location = New System.Drawing.Point(427, 71)
        Me.lnkEtudiant.Name = "lnkEtudiant"
        Me.lnkEtudiant.Size = New System.Drawing.Size(150, 23)
        Me.lnkEtudiant.TabIndex = 4
        Me.lnkEtudiant.Text = "Retrouver un étudiant"
        Me.lnkEtudiant.UseSelectable = True
        '
        'txtTypeBusiness
        '
        '
        '
        '
        Me.txtTypeBusiness.CustomButton.Image = Nothing
        Me.txtTypeBusiness.CustomButton.Location = New System.Drawing.Point(284, 2)
        Me.txtTypeBusiness.CustomButton.Name = ""
        Me.txtTypeBusiness.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTypeBusiness.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTypeBusiness.CustomButton.TabIndex = 1
        Me.txtTypeBusiness.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTypeBusiness.CustomButton.UseSelectable = True
        Me.txtTypeBusiness.CustomButton.Visible = False
        Me.txtTypeBusiness.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTypeBusiness.Lines = New String(-1) {}
        Me.txtTypeBusiness.Location = New System.Drawing.Point(823, 36)
        Me.txtTypeBusiness.MaxLength = 32767
        Me.txtTypeBusiness.Name = "txtTypeBusiness"
        Me.txtTypeBusiness.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTypeBusiness.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTypeBusiness.SelectedText = ""
        Me.txtTypeBusiness.SelectionLength = 0
        Me.txtTypeBusiness.SelectionStart = 0
        Me.txtTypeBusiness.ShortcutsEnabled = True
        Me.txtTypeBusiness.Size = New System.Drawing.Size(312, 30)
        Me.txtTypeBusiness.TabIndex = 3
        Me.txtTypeBusiness.UseSelectable = True
        Me.txtTypeBusiness.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTypeBusiness.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMontantRecu
        '
        '
        '
        '
        Me.txtMontantRecu.CustomButton.Image = Nothing
        Me.txtMontantRecu.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtMontantRecu.CustomButton.Name = ""
        Me.txtMontantRecu.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantRecu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantRecu.CustomButton.TabIndex = 1
        Me.txtMontantRecu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantRecu.CustomButton.UseSelectable = True
        Me.txtMontantRecu.CustomButton.Visible = False
        Me.txtMontantRecu.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantRecu.Lines = New String() {"0"}
        Me.txtMontantRecu.Location = New System.Drawing.Point(199, 139)
        Me.txtMontantRecu.MaxLength = 32767
        Me.txtMontantRecu.Name = "txtMontantRecu"
        Me.txtMontantRecu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantRecu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantRecu.SelectedText = ""
        Me.txtMontantRecu.SelectionLength = 0
        Me.txtMontantRecu.SelectionStart = 0
        Me.txtMontantRecu.ShortcutsEnabled = True
        Me.txtMontantRecu.Size = New System.Drawing.Size(367, 30)
        Me.txtMontantRecu.TabIndex = 3
        Me.txtMontantRecu.Text = "0"
        Me.txtMontantRecu.UseSelectable = True
        Me.txtMontantRecu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantRecu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMontantSoli
        '
        '
        '
        '
        Me.txtMontantSoli.CustomButton.Image = Nothing
        Me.txtMontantSoli.CustomButton.Location = New System.Drawing.Point(339, 2)
        Me.txtMontantSoli.CustomButton.Name = ""
        Me.txtMontantSoli.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantSoli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantSoli.CustomButton.TabIndex = 1
        Me.txtMontantSoli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantSoli.CustomButton.UseSelectable = True
        Me.txtMontantSoli.CustomButton.Visible = False
        Me.txtMontantSoli.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantSoli.Lines = New String(-1) {}
        Me.txtMontantSoli.Location = New System.Drawing.Point(199, 104)
        Me.txtMontantSoli.MaxLength = 32767
        Me.txtMontantSoli.Name = "txtMontantSoli"
        Me.txtMontantSoli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantSoli.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantSoli.SelectedText = ""
        Me.txtMontantSoli.SelectionLength = 0
        Me.txtMontantSoli.SelectionStart = 0
        Me.txtMontantSoli.ShortcutsEnabled = True
        Me.txtMontantSoli.Size = New System.Drawing.Size(367, 30)
        Me.txtMontantSoli.TabIndex = 3
        Me.txtMontantSoli.UseSelectable = True
        Me.txtMontantSoli.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantSoli.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNumCheque
        '
        '
        '
        '
        Me.txtNumCheque.CustomButton.Image = Nothing
        Me.txtNumCheque.CustomButton.Location = New System.Drawing.Point(130, 2)
        Me.txtNumCheque.CustomButton.Name = ""
        Me.txtNumCheque.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNumCheque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumCheque.CustomButton.TabIndex = 1
        Me.txtNumCheque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumCheque.CustomButton.UseSelectable = True
        Me.txtNumCheque.CustomButton.Visible = False
        Me.txtNumCheque.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumCheque.Lines = New String(-1) {}
        Me.txtNumCheque.Location = New System.Drawing.Point(820, 111)
        Me.txtNumCheque.MaxLength = 32767
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCheque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumCheque.SelectedText = ""
        Me.txtNumCheque.SelectionLength = 0
        Me.txtNumCheque.SelectionStart = 0
        Me.txtNumCheque.ShortcutsEnabled = True
        Me.txtNumCheque.Size = New System.Drawing.Size(158, 30)
        Me.txtNumCheque.TabIndex = 3
        Me.txtNumCheque.UseSelectable = True
        Me.txtNumCheque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumCheque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dt_date
        '
        Me.dt_date.Location = New System.Drawing.Point(199, 30)
        Me.dt_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Size = New System.Drawing.Size(367, 29)
        Me.dt_date.TabIndex = 1
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(600, 117)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "N° Cheque"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(600, 40)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(204, 19)
        Me.MetroLabel7.TabIndex = 0
        Me.MetroLabel7.Text = "Type de business du bénéficiare *"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(600, 80)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "Mode de réception"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(26, 145)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Montant reçu *"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(26, 110)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Montant sollicité"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(26, 73)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Bénéficiare *"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(26, 36)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Date"
        '
        'DemandeSoutien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 670)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DemandeSoutien"
        Me.Text = "FOND DE SOUTIEN : DEMANDE DE DON"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lnkEtudiant As MetroFramework.Controls.MetroLink
    Friend WithEvents txtTypeBusiness As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontantRecu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontantSoli As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumCheque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dt_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btClean As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPeriodeGrace As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNetAPayer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPenalite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPaiementRestant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPaimentRetard As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNbrePaiementEffec As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNbreRepaiement As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDelais As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInteret As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontantHIC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtFinPaiement As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtDebutPaiement As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents chkVirement As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents chkCheque As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents chkEspece As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents cmbEtudiant As System.Windows.Forms.ComboBox
End Class
