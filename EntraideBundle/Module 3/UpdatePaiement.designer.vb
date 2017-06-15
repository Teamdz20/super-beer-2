<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePaiement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePaiement))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMontantAPayer = New System.Windows.Forms.TextBox()
        Me.txtDette = New System.Windows.Forms.TextBox()
        Me.btUpdate = New MetroFramework.Controls.MetroButton()
        Me.ListHidden = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNumCheque = New MetroFramework.Controls.MetroTextBox()
        Me.chkVirement = New MetroFramework.Controls.MetroCheckBox()
        Me.chkCheque = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEspece = New MetroFramework.Controls.MetroCheckBox()
        Me.txtActivite = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodeRevenu = New MetroFramework.Controls.MetroTextBox()
        Me.txtDelai = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontantR = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontantPaye = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtCout = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCode = New System.Windows.Forms.ComboBox()
        Me.btSearch = New MetroFramework.Controls.MetroButton()
        Me.txtMail = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhone1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtBP = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel54 = New MetroFramework.Controls.MetroLabel()
        Me.txtNationalite = New MetroFramework.Controls.MetroTextBox()
        Me.txtAdresse = New MetroFramework.Controls.MetroTextBox()
        Me.txtLieu = New MetroFramework.Controls.MetroTextBox()
        Me.txtNbreEnfant = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrenom = New MetroFramework.Controls.MetroTextBox()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.cmbSituation = New System.Windows.Forms.ComboBox()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.cmbTypeFormation = New System.Windows.Forms.ComboBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContainer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.GroupBox2)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1127, 658)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(474, 595)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(178, 39)
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMontantAPayer)
        Me.GroupBox2.Controls.Add(Me.txtDette)
        Me.GroupBox2.Controls.Add(Me.btUpdate)
        Me.GroupBox2.Controls.Add(Me.ListHidden)
        Me.GroupBox2.Controls.Add(Me.txtNumCheque)
        Me.GroupBox2.Controls.Add(Me.chkVirement)
        Me.GroupBox2.Controls.Add(Me.chkCheque)
        Me.GroupBox2.Controls.Add(Me.chkEspece)
        Me.GroupBox2.Controls.Add(Me.txtActivite)
        Me.GroupBox2.Controls.Add(Me.txtCodeRevenu)
        Me.GroupBox2.Controls.Add(Me.txtDelai)
        Me.GroupBox2.Controls.Add(Me.txtMontantR)
        Me.GroupBox2.Controls.Add(Me.txtMontantPaye)
        Me.GroupBox2.Controls.Add(Me.MetroLabel22)
        Me.GroupBox2.Controls.Add(Me.MetroLabel21)
        Me.GroupBox2.Controls.Add(Me.MetroLabel20)
        Me.GroupBox2.Controls.Add(Me.MetroLabel23)
        Me.GroupBox2.Controls.Add(Me.MetroLabel19)
        Me.GroupBox2.Controls.Add(Me.MetroLabel18)
        Me.GroupBox2.Controls.Add(Me.MetroLabel17)
        Me.GroupBox2.Controls.Add(Me.MetroLabel16)
        Me.GroupBox2.Controls.Add(Me.txtCout)
        Me.GroupBox2.Controls.Add(Me.MetroLabel15)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(564, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 571)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Addition de paiement"
        '
        'txtMontantAPayer
        '
        Me.txtMontantAPayer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontantAPayer.Location = New System.Drawing.Point(172, 154)
        Me.txtMontantAPayer.Name = "txtMontantAPayer"
        Me.txtMontantAPayer.Size = New System.Drawing.Size(352, 29)
        Me.txtMontantAPayer.TabIndex = 9
        '
        'txtDette
        '
        Me.txtDette.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDette.Location = New System.Drawing.Point(172, 117)
        Me.txtDette.Name = "txtDette"
        Me.txtDette.Size = New System.Drawing.Size(352, 29)
        Me.txtDette.TabIndex = 9
        '
        'btUpdate
        '
        Me.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btUpdate.Location = New System.Drawing.Point(192, 417)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(164, 33)
        Me.btUpdate.TabIndex = 8
        Me.btUpdate.Text = "ENREGISTRER LE PAIEMENT"
        Me.btUpdate.UseSelectable = True
        '
        'ListHidden
        '
        Me.ListHidden.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader23, Me.ColumnHeader22, Me.ColumnHeader24, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.ListHidden.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListHidden.Location = New System.Drawing.Point(6, 470)
        Me.ListHidden.Name = "ListHidden"
        Me.ListHidden.Size = New System.Drawing.Size(434, 75)
        Me.ListHidden.TabIndex = 7
        Me.ListHidden.UseCompatibleStateImageBehavior = False
        Me.ListHidden.View = System.Windows.Forms.View.Details
        Me.ListHidden.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "nom"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "prenom"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "sex"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "situation"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "nbreenft"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "lieu"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "nationalite"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "adress"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "bp"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "phone1"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "phone2"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "email"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "type_formation"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Cout"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "montantP"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "dette"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "delai"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "code_rev"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.DisplayIndex = 20
        Me.ColumnHeader23.Text = "paiement"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.DisplayIndex = 19
        Me.ColumnHeader22.Text = "actu"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "num_cheque"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "paiement_id"
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "index"
        '
        'txtNumCheque
        '
        '
        '
        '
        Me.txtNumCheque.CustomButton.Image = Nothing
        Me.txtNumCheque.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtNumCheque.CustomButton.Name = ""
        Me.txtNumCheque.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNumCheque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumCheque.CustomButton.TabIndex = 1
        Me.txtNumCheque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumCheque.CustomButton.UseSelectable = True
        Me.txtNumCheque.CustomButton.Visible = False
        Me.txtNumCheque.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumCheque.Lines = New String(-1) {}
        Me.txtNumCheque.Location = New System.Drawing.Point(172, 231)
        Me.txtNumCheque.MaxLength = 32767
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCheque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumCheque.SelectedText = ""
        Me.txtNumCheque.SelectionLength = 0
        Me.txtNumCheque.SelectionStart = 0
        Me.txtNumCheque.ShortcutsEnabled = True
        Me.txtNumCheque.Size = New System.Drawing.Size(352, 30)
        Me.txtNumCheque.TabIndex = 6
        Me.txtNumCheque.UseSelectable = True
        Me.txtNumCheque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumCheque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkVirement
        '
        Me.chkVirement.AutoSize = True
        Me.chkVirement.Location = New System.Drawing.Point(347, 200)
        Me.chkVirement.Name = "chkVirement"
        Me.chkVirement.Size = New System.Drawing.Size(71, 15)
        Me.chkVirement.TabIndex = 3
        Me.chkVirement.Text = "Virement"
        Me.chkVirement.UseSelectable = True
        '
        'chkCheque
        '
        Me.chkCheque.AutoSize = True
        Me.chkCheque.Location = New System.Drawing.Point(254, 200)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(64, 15)
        Me.chkCheque.TabIndex = 4
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.UseSelectable = True
        '
        'chkEspece
        '
        Me.chkEspece.AutoSize = True
        Me.chkEspece.Location = New System.Drawing.Point(172, 200)
        Me.chkEspece.Name = "chkEspece"
        Me.chkEspece.Size = New System.Drawing.Size(59, 15)
        Me.chkEspece.TabIndex = 5
        Me.chkEspece.Text = "Espèce"
        Me.chkEspece.UseSelectable = True
        '
        'txtActivite
        '
        '
        '
        '
        Me.txtActivite.CustomButton.Image = Nothing
        Me.txtActivite.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtActivite.CustomButton.Name = ""
        Me.txtActivite.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtActivite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtActivite.CustomButton.TabIndex = 1
        Me.txtActivite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtActivite.CustomButton.UseSelectable = True
        Me.txtActivite.CustomButton.Visible = False
        Me.txtActivite.Enabled = False
        Me.txtActivite.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtActivite.Lines = New String(-1) {}
        Me.txtActivite.Location = New System.Drawing.Point(172, 377)
        Me.txtActivite.MaxLength = 32767
        Me.txtActivite.Name = "txtActivite"
        Me.txtActivite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtActivite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtActivite.SelectedText = ""
        Me.txtActivite.SelectionLength = 0
        Me.txtActivite.SelectionStart = 0
        Me.txtActivite.ShortcutsEnabled = True
        Me.txtActivite.Size = New System.Drawing.Size(352, 30)
        Me.txtActivite.TabIndex = 1
        Me.txtActivite.UseSelectable = True
        Me.txtActivite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtActivite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodeRevenu
        '
        '
        '
        '
        Me.txtCodeRevenu.CustomButton.Image = Nothing
        Me.txtCodeRevenu.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtCodeRevenu.CustomButton.Name = ""
        Me.txtCodeRevenu.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCodeRevenu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodeRevenu.CustomButton.TabIndex = 1
        Me.txtCodeRevenu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodeRevenu.CustomButton.UseSelectable = True
        Me.txtCodeRevenu.CustomButton.Visible = False
        Me.txtCodeRevenu.Enabled = False
        Me.txtCodeRevenu.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCodeRevenu.Lines = New String(-1) {}
        Me.txtCodeRevenu.Location = New System.Drawing.Point(172, 339)
        Me.txtCodeRevenu.MaxLength = 32767
        Me.txtCodeRevenu.Name = "txtCodeRevenu"
        Me.txtCodeRevenu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodeRevenu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodeRevenu.SelectedText = ""
        Me.txtCodeRevenu.SelectionLength = 0
        Me.txtCodeRevenu.SelectionStart = 0
        Me.txtCodeRevenu.ShortcutsEnabled = True
        Me.txtCodeRevenu.Size = New System.Drawing.Size(352, 30)
        Me.txtCodeRevenu.TabIndex = 1
        Me.txtCodeRevenu.UseSelectable = True
        Me.txtCodeRevenu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodeRevenu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDelai
        '
        '
        '
        '
        Me.txtDelai.CustomButton.Image = Nothing
        Me.txtDelai.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtDelai.CustomButton.Name = ""
        Me.txtDelai.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtDelai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDelai.CustomButton.TabIndex = 1
        Me.txtDelai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDelai.CustomButton.UseSelectable = True
        Me.txtDelai.CustomButton.Visible = False
        Me.txtDelai.Enabled = False
        Me.txtDelai.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDelai.Lines = New String(-1) {}
        Me.txtDelai.Location = New System.Drawing.Point(172, 305)
        Me.txtDelai.MaxLength = 32767
        Me.txtDelai.Name = "txtDelai"
        Me.txtDelai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDelai.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDelai.SelectedText = ""
        Me.txtDelai.SelectionLength = 0
        Me.txtDelai.SelectionStart = 0
        Me.txtDelai.ShortcutsEnabled = True
        Me.txtDelai.Size = New System.Drawing.Size(352, 30)
        Me.txtDelai.TabIndex = 1
        Me.txtDelai.UseSelectable = True
        Me.txtDelai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDelai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMontantR
        '
        '
        '
        '
        Me.txtMontantR.CustomButton.Image = Nothing
        Me.txtMontantR.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtMontantR.CustomButton.Name = ""
        Me.txtMontantR.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantR.CustomButton.TabIndex = 1
        Me.txtMontantR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantR.CustomButton.UseSelectable = True
        Me.txtMontantR.CustomButton.Visible = False
        Me.txtMontantR.Enabled = False
        Me.txtMontantR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantR.Lines = New String(-1) {}
        Me.txtMontantR.Location = New System.Drawing.Point(172, 267)
        Me.txtMontantR.MaxLength = 32767
        Me.txtMontantR.Name = "txtMontantR"
        Me.txtMontantR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantR.SelectedText = ""
        Me.txtMontantR.SelectionLength = 0
        Me.txtMontantR.SelectionStart = 0
        Me.txtMontantR.ShortcutsEnabled = True
        Me.txtMontantR.Size = New System.Drawing.Size(352, 30)
        Me.txtMontantR.TabIndex = 1
        Me.txtMontantR.UseSelectable = True
        Me.txtMontantR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMontantPaye
        '
        '
        '
        '
        Me.txtMontantPaye.CustomButton.Image = Nothing
        Me.txtMontantPaye.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtMontantPaye.CustomButton.Name = ""
        Me.txtMontantPaye.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantPaye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantPaye.CustomButton.TabIndex = 1
        Me.txtMontantPaye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantPaye.CustomButton.UseSelectable = True
        Me.txtMontantPaye.CustomButton.Visible = False
        Me.txtMontantPaye.Enabled = False
        Me.txtMontantPaye.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantPaye.Lines = New String(-1) {}
        Me.txtMontantPaye.Location = New System.Drawing.Point(172, 78)
        Me.txtMontantPaye.MaxLength = 32767
        Me.txtMontantPaye.Name = "txtMontantPaye"
        Me.txtMontantPaye.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantPaye.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantPaye.SelectedText = ""
        Me.txtMontantPaye.SelectionLength = 0
        Me.txtMontantPaye.SelectionStart = 0
        Me.txtMontantPaye.ShortcutsEnabled = True
        Me.txtMontantPaye.Size = New System.Drawing.Size(352, 30)
        Me.txtMontantPaye.TabIndex = 1
        Me.txtMontantPaye.UseSelectable = True
        Me.txtMontantPaye.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantPaye.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(24, 383)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel22.TabIndex = 0
        Me.MetroLabel22.Text = "Activité"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(24, 345)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel21.TabIndex = 0
        Me.MetroLabel21.Text = "Code revenu"
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(24, 309)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel20.TabIndex = 0
        Me.MetroLabel20.Text = "Delai paiement"
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(24, 239)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel23.TabIndex = 0
        Me.MetroLabel23.Text = "Numéro chèque"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(24, 271)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel19.TabIndex = 0
        Me.MetroLabel19.Text = "Montant restant"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(24, 160)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel18.TabIndex = 0
        Me.MetroLabel18.Text = "Montant paiement"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(24, 123)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel17.TabIndex = 0
        Me.MetroLabel17.Text = "Dette actuelle"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(24, 82)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel16.TabIndex = 0
        Me.MetroLabel16.Text = "Montant déja payé"
        '
        'txtCout
        '
        '
        '
        '
        Me.txtCout.CustomButton.Image = Nothing
        Me.txtCout.CustomButton.Location = New System.Drawing.Point(324, 2)
        Me.txtCout.CustomButton.Name = ""
        Me.txtCout.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCout.CustomButton.TabIndex = 1
        Me.txtCout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCout.CustomButton.UseSelectable = True
        Me.txtCout.CustomButton.Visible = False
        Me.txtCout.Enabled = False
        Me.txtCout.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCout.Lines = New String(-1) {}
        Me.txtCout.Location = New System.Drawing.Point(172, 34)
        Me.txtCout.MaxLength = 32767
        Me.txtCout.Name = "txtCout"
        Me.txtCout.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCout.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCout.SelectedText = ""
        Me.txtCout.SelectionLength = 0
        Me.txtCout.SelectionStart = 0
        Me.txtCout.ShortcutsEnabled = True
        Me.txtCout.Size = New System.Drawing.Size(352, 30)
        Me.txtCout.TabIndex = 1
        Me.txtCout.UseSelectable = True
        Me.txtCout.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCout.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(24, 39)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel15.TabIndex = 0
        Me.MetroLabel15.Text = "Coût de la formation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCode)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.txtPhone2)
        Me.GroupBox1.Controls.Add(Me.txtPhone1)
        Me.GroupBox1.Controls.Add(Me.txtBP)
        Me.GroupBox1.Controls.Add(Me.MetroLabel54)
        Me.GroupBox1.Controls.Add(Me.txtNationalite)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.txtLieu)
        Me.GroupBox1.Controls.Add(Me.txtNbreEnfant)
        Me.GroupBox1.Controls.Add(Me.txtPrenom)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.cmbSituation)
        Me.GroupBox1.Controls.Add(Me.cmbSex)
        Me.GroupBox1.Controls.Add(Me.cmbTypeFormation)
        Me.GroupBox1.Controls.Add(Me.MetroLabel13)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel9)
        Me.GroupBox1.Controls.Add(Me.MetroLabel14)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 571)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'cmbCode
        '
        Me.cmbCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCode.FormattingEnabled = True
        Me.cmbCode.Location = New System.Drawing.Point(138, 36)
        Me.cmbCode.Name = "cmbCode"
        Me.cmbCode.Size = New System.Drawing.Size(230, 28)
        Me.cmbCode.TabIndex = 59
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Location = New System.Drawing.Point(401, 34)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(127, 33)
        Me.btSearch.TabIndex = 58
        Me.btSearch.Text = "Rechercher"
        Me.btSearch.UseSelectable = True
        '
        'txtMail
        '
        '
        '
        '
        Me.txtMail.CustomButton.Image = Nothing
        Me.txtMail.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtMail.CustomButton.Name = ""
        Me.txtMail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMail.CustomButton.TabIndex = 1
        Me.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMail.CustomButton.UseSelectable = True
        Me.txtMail.CustomButton.Visible = False
        Me.txtMail.Enabled = False
        Me.txtMail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMail.Lines = New String(-1) {}
        Me.txtMail.Location = New System.Drawing.Point(209, 524)
        Me.txtMail.MaxLength = 32767
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMail.SelectedText = ""
        Me.txtMail.SelectionLength = 0
        Me.txtMail.SelectionStart = 0
        Me.txtMail.ShortcutsEnabled = True
        Me.txtMail.Size = New System.Drawing.Size(302, 30)
        Me.txtMail.TabIndex = 57
        Me.txtMail.UseSelectable = True
        Me.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone2
        '
        '
        '
        '
        Me.txtPhone2.CustomButton.Image = Nothing
        Me.txtPhone2.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtPhone2.CustomButton.Name = ""
        Me.txtPhone2.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPhone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone2.CustomButton.TabIndex = 1
        Me.txtPhone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone2.CustomButton.UseSelectable = True
        Me.txtPhone2.CustomButton.Visible = False
        Me.txtPhone2.Enabled = False
        Me.txtPhone2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPhone2.Lines = New String() {"0"}
        Me.txtPhone2.Location = New System.Drawing.Point(209, 491)
        Me.txtPhone2.MaxLength = 32767
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone2.SelectedText = ""
        Me.txtPhone2.SelectionLength = 0
        Me.txtPhone2.SelectionStart = 0
        Me.txtPhone2.ShortcutsEnabled = True
        Me.txtPhone2.Size = New System.Drawing.Size(302, 30)
        Me.txtPhone2.TabIndex = 56
        Me.txtPhone2.Text = "0"
        Me.txtPhone2.UseSelectable = True
        Me.txtPhone2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhone1
        '
        '
        '
        '
        Me.txtPhone1.CustomButton.Image = Nothing
        Me.txtPhone1.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtPhone1.CustomButton.Name = ""
        Me.txtPhone1.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPhone1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhone1.CustomButton.TabIndex = 1
        Me.txtPhone1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhone1.CustomButton.UseSelectable = True
        Me.txtPhone1.CustomButton.Visible = False
        Me.txtPhone1.Enabled = False
        Me.txtPhone1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPhone1.Lines = New String() {"0"}
        Me.txtPhone1.Location = New System.Drawing.Point(209, 457)
        Me.txtPhone1.MaxLength = 32767
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone1.SelectedText = ""
        Me.txtPhone1.SelectionLength = 0
        Me.txtPhone1.SelectionStart = 0
        Me.txtPhone1.ShortcutsEnabled = True
        Me.txtPhone1.Size = New System.Drawing.Size(302, 30)
        Me.txtPhone1.TabIndex = 55
        Me.txtPhone1.Text = "0"
        Me.txtPhone1.UseSelectable = True
        Me.txtPhone1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhone1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBP
        '
        '
        '
        '
        Me.txtBP.CustomButton.Image = Nothing
        Me.txtBP.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtBP.CustomButton.Name = ""
        Me.txtBP.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtBP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBP.CustomButton.TabIndex = 1
        Me.txtBP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBP.CustomButton.UseSelectable = True
        Me.txtBP.CustomButton.Visible = False
        Me.txtBP.Enabled = False
        Me.txtBP.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBP.Lines = New String(-1) {}
        Me.txtBP.Location = New System.Drawing.Point(209, 425)
        Me.txtBP.MaxLength = 32767
        Me.txtBP.Name = "txtBP"
        Me.txtBP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBP.SelectedText = ""
        Me.txtBP.SelectionLength = 0
        Me.txtBP.SelectionStart = 0
        Me.txtBP.ShortcutsEnabled = True
        Me.txtBP.Size = New System.Drawing.Size(302, 30)
        Me.txtBP.TabIndex = 54
        Me.txtBP.UseSelectable = True
        Me.txtBP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel54
        '
        Me.MetroLabel54.AutoSize = True
        Me.MetroLabel54.Location = New System.Drawing.Point(43, 397)
        Me.MetroLabel54.Name = "MetroLabel54"
        Me.MetroLabel54.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel54.TabIndex = 36
        Me.MetroLabel54.Text = "Adresse"
        '
        'txtNationalite
        '
        '
        '
        '
        Me.txtNationalite.CustomButton.Image = Nothing
        Me.txtNationalite.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtNationalite.CustomButton.Name = ""
        Me.txtNationalite.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNationalite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNationalite.CustomButton.TabIndex = 1
        Me.txtNationalite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNationalite.CustomButton.UseSelectable = True
        Me.txtNationalite.CustomButton.Visible = False
        Me.txtNationalite.Enabled = False
        Me.txtNationalite.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNationalite.Lines = New String(-1) {}
        Me.txtNationalite.Location = New System.Drawing.Point(209, 358)
        Me.txtNationalite.MaxLength = 32767
        Me.txtNationalite.Name = "txtNationalite"
        Me.txtNationalite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNationalite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNationalite.SelectedText = ""
        Me.txtNationalite.SelectionLength = 0
        Me.txtNationalite.SelectionStart = 0
        Me.txtNationalite.ShortcutsEnabled = True
        Me.txtNationalite.Size = New System.Drawing.Size(302, 30)
        Me.txtNationalite.TabIndex = 53
        Me.txtNationalite.UseSelectable = True
        Me.txtNationalite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNationalite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAdresse
        '
        '
        '
        '
        Me.txtAdresse.CustomButton.Image = Nothing
        Me.txtAdresse.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtAdresse.CustomButton.Name = ""
        Me.txtAdresse.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresse.CustomButton.TabIndex = 1
        Me.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresse.CustomButton.UseSelectable = True
        Me.txtAdresse.CustomButton.Visible = False
        Me.txtAdresse.Enabled = False
        Me.txtAdresse.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAdresse.Lines = New String(-1) {}
        Me.txtAdresse.Location = New System.Drawing.Point(209, 391)
        Me.txtAdresse.MaxLength = 32767
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresse.SelectedText = ""
        Me.txtAdresse.SelectionLength = 0
        Me.txtAdresse.SelectionStart = 0
        Me.txtAdresse.ShortcutsEnabled = True
        Me.txtAdresse.Size = New System.Drawing.Size(302, 30)
        Me.txtAdresse.TabIndex = 52
        Me.txtAdresse.UseSelectable = True
        Me.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLieu
        '
        '
        '
        '
        Me.txtLieu.CustomButton.Image = Nothing
        Me.txtLieu.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtLieu.CustomButton.Name = ""
        Me.txtLieu.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtLieu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLieu.CustomButton.TabIndex = 1
        Me.txtLieu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLieu.CustomButton.UseSelectable = True
        Me.txtLieu.CustomButton.Visible = False
        Me.txtLieu.Enabled = False
        Me.txtLieu.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLieu.Lines = New String(-1) {}
        Me.txtLieu.Location = New System.Drawing.Point(209, 326)
        Me.txtLieu.MaxLength = 32767
        Me.txtLieu.Name = "txtLieu"
        Me.txtLieu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLieu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLieu.SelectedText = ""
        Me.txtLieu.SelectionLength = 0
        Me.txtLieu.SelectionStart = 0
        Me.txtLieu.ShortcutsEnabled = True
        Me.txtLieu.Size = New System.Drawing.Size(302, 30)
        Me.txtLieu.TabIndex = 51
        Me.txtLieu.UseSelectable = True
        Me.txtLieu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLieu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNbreEnfant
        '
        '
        '
        '
        Me.txtNbreEnfant.CustomButton.Image = Nothing
        Me.txtNbreEnfant.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtNbreEnfant.CustomButton.Name = ""
        Me.txtNbreEnfant.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNbreEnfant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbreEnfant.CustomButton.TabIndex = 1
        Me.txtNbreEnfant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbreEnfant.CustomButton.UseSelectable = True
        Me.txtNbreEnfant.CustomButton.Visible = False
        Me.txtNbreEnfant.Enabled = False
        Me.txtNbreEnfant.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNbreEnfant.Lines = New String() {"0"}
        Me.txtNbreEnfant.Location = New System.Drawing.Point(209, 294)
        Me.txtNbreEnfant.MaxLength = 32767
        Me.txtNbreEnfant.Name = "txtNbreEnfant"
        Me.txtNbreEnfant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbreEnfant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbreEnfant.SelectedText = ""
        Me.txtNbreEnfant.SelectionLength = 0
        Me.txtNbreEnfant.SelectionStart = 0
        Me.txtNbreEnfant.ShortcutsEnabled = True
        Me.txtNbreEnfant.Size = New System.Drawing.Size(302, 30)
        Me.txtNbreEnfant.TabIndex = 50
        Me.txtNbreEnfant.Text = "0"
        Me.txtNbreEnfant.UseSelectable = True
        Me.txtNbreEnfant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbreEnfant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrenom
        '
        '
        '
        '
        Me.txtPrenom.CustomButton.Image = Nothing
        Me.txtPrenom.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtPrenom.CustomButton.Name = ""
        Me.txtPrenom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPrenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrenom.CustomButton.TabIndex = 1
        Me.txtPrenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrenom.CustomButton.UseSelectable = True
        Me.txtPrenom.CustomButton.Visible = False
        Me.txtPrenom.Enabled = False
        Me.txtPrenom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrenom.Lines = New String(-1) {}
        Me.txtPrenom.Location = New System.Drawing.Point(209, 195)
        Me.txtPrenom.MaxLength = 32767
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrenom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrenom.SelectedText = ""
        Me.txtPrenom.SelectionLength = 0
        Me.txtPrenom.SelectionStart = 0
        Me.txtPrenom.ShortcutsEnabled = True
        Me.txtPrenom.Size = New System.Drawing.Size(302, 30)
        Me.txtPrenom.TabIndex = 49
        Me.txtPrenom.UseSelectable = True
        Me.txtPrenom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrenom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(274, 2)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.Enabled = False
        Me.txtNom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(209, 161)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(302, 30)
        Me.txtNom.TabIndex = 48
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbSituation
        '
        Me.cmbSituation.Enabled = False
        Me.cmbSituation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSituation.FormattingEnabled = True
        Me.cmbSituation.Items.AddRange(New Object() {"Marié", "Célibataire"})
        Me.cmbSituation.Location = New System.Drawing.Point(209, 263)
        Me.cmbSituation.Name = "cmbSituation"
        Me.cmbSituation.Size = New System.Drawing.Size(302, 28)
        Me.cmbSituation.TabIndex = 46
        Me.cmbSituation.Text = "Marié"
        '
        'cmbSex
        '
        Me.cmbSex.DisplayMember = "M"
        Me.cmbSex.Enabled = False
        Me.cmbSex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSex.Location = New System.Drawing.Point(209, 230)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(302, 28)
        Me.cmbSex.TabIndex = 45
        Me.cmbSex.Text = "M"
        '
        'cmbTypeFormation
        '
        Me.cmbTypeFormation.AutoCompleteCustomSource.AddRange(New String() {"Entrepreunariat", "Metier"})
        Me.cmbTypeFormation.Enabled = False
        Me.cmbTypeFormation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeFormation.FormattingEnabled = True
        Me.cmbTypeFormation.Location = New System.Drawing.Point(209, 127)
        Me.cmbTypeFormation.Name = "cmbTypeFormation"
        Me.cmbTypeFormation.Size = New System.Drawing.Size(302, 28)
        Me.cmbTypeFormation.TabIndex = 47
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(43, 530)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel13.TabIndex = 43
        Me.MetroLabel13.Text = "Email"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(43, 497)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel12.TabIndex = 42
        Me.MetroLabel12.Text = "Phone2"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(43, 463)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel11.TabIndex = 41
        Me.MetroLabel11.Text = "Phone1"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(43, 431)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(25, 19)
        Me.MetroLabel10.TabIndex = 40
        Me.MetroLabel10.Text = "BP"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(43, 364)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel8.TabIndex = 39
        Me.MetroLabel8.Text = "Nationalité"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(43, 332)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel7.TabIndex = 38
        Me.MetroLabel7.Text = "Lieu de naissance"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(43, 300)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel6.TabIndex = 37
        Me.MetroLabel6.Text = "Nombre enfants"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(43, 268)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel5.TabIndex = 35
        Me.MetroLabel5.Text = "Situation matrimoniale"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(43, 235)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel4.TabIndex = 34
        Me.MetroLabel4.Text = "Sexe"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(43, 201)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel3.TabIndex = 33
        Me.MetroLabel3.Text = "Prénom"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(43, 161)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel9.TabIndex = 44
        Me.MetroLabel9.Text = "Nom de l'étudiant"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(43, 132)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel14.TabIndex = 32
        Me.MetroLabel14.Text = "Type de formation"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(148, 91)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(272, 25)
        Me.MetroLabel2.TabIndex = 31
        Me.MetroLabel2.Text = "FICHE INDIVIDUEL D'INSCRIPTION"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 41)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel1.TabIndex = 29
        Me.MetroLabel1.Text = "Code Etudiant"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'UpdatePaiement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 788)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdatePaiement"
        Me.Text = "ANCIENNE INSCRIPTION : ADDITION DE PAIEMENT"
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
    Friend WithEvents txtMail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhone1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel54 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNationalite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAdresse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLieu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNbreEnfant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrenom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbSituation As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypeFormation As System.Windows.Forms.ComboBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtActivite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodeRevenu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDelai As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontantR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontantPaye As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCout As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNumCheque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkVirement As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCheque As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkEspece As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbCode As System.Windows.Forms.ComboBox
    Friend WithEvents ListHidden As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtMontantAPayer As System.Windows.Forms.TextBox
    Friend WithEvents txtDette As System.Windows.Forms.TextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
End Class
