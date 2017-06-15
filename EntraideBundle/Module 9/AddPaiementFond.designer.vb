<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaiementFond
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPaiementFond))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.lbPAiement = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtMontantAPayer = New MetroFramework.Controls.MetroTextBox()
        Me.lbMontP = New MetroFramework.Controls.MetroLabel()
        Me.lbTypeP = New MetroFramework.Controls.MetroLabel()
        Me.btUpdate = New MetroFramework.Controls.MetroButton()
        Me.lbCheque = New MetroFramework.Controls.MetroLabel()
        Me.chkVirement = New MetroFramework.Controls.MetroCheckBox()
        Me.lbMontR = New MetroFramework.Controls.MetroLabel()
        Me.chkCheque = New MetroFramework.Controls.MetroCheckBox()
        Me.txtNumCheque = New MetroFramework.Controls.MetroTextBox()
        Me.chkEspece = New MetroFramework.Controls.MetroCheckBox()
        Me.txtMontantR = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMontantRecu = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtNbreEff = New MetroFramework.Controls.MetroTextBox()
        Me.txtNbreR = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtDette = New MetroFramework.Controls.MetroTextBox()
        Me.lbNumFond = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAll = New MetroFramework.Controls.MetroCheckBox()
        Me.lb_msg = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.ListeEtudiants = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.MetroPanel1.Controls.Add(Me.GroupBox2)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.lbPAiement)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lbNumFond)
        Me.GroupBox2.Controls.Add(Me.MetroLabel9)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1334, 371)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PAIEMENT"
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(585, 325)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(147, 40)
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'lbPAiement
        '
        Me.lbPAiement.AutoSize = True
        Me.lbPAiement.Location = New System.Drawing.Point(710, 25)
        Me.lbPAiement.Name = "lbPAiement"
        Me.lbPAiement.Size = New System.Drawing.Size(15, 19)
        Me.lbPAiement.TabIndex = 0
        Me.lbPAiement.Text = "-"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtMontantAPayer)
        Me.GroupBox4.Controls.Add(Me.lbMontP)
        Me.GroupBox4.Controls.Add(Me.lbTypeP)
        Me.GroupBox4.Controls.Add(Me.btUpdate)
        Me.GroupBox4.Controls.Add(Me.lbCheque)
        Me.GroupBox4.Controls.Add(Me.chkVirement)
        Me.GroupBox4.Controls.Add(Me.lbMontR)
        Me.GroupBox4.Controls.Add(Me.chkCheque)
        Me.GroupBox4.Controls.Add(Me.txtNumCheque)
        Me.GroupBox4.Controls.Add(Me.chkEspece)
        Me.GroupBox4.Controls.Add(Me.txtMontantR)
        Me.GroupBox4.Location = New System.Drawing.Point(648, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(656, 264)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NOUVEAU PAIEMENT"
        '
        'txtMontantAPayer
        '
        '
        '
        '
        Me.txtMontantAPayer.CustomButton.Image = Nothing
        Me.txtMontantAPayer.CustomButton.Location = New System.Drawing.Point(236, 2)
        Me.txtMontantAPayer.CustomButton.Name = ""
        Me.txtMontantAPayer.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantAPayer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantAPayer.CustomButton.TabIndex = 1
        Me.txtMontantAPayer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantAPayer.CustomButton.UseSelectable = True
        Me.txtMontantAPayer.CustomButton.Visible = False
        Me.txtMontantAPayer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantAPayer.Lines = New String(-1) {}
        Me.txtMontantAPayer.Location = New System.Drawing.Point(321, 31)
        Me.txtMontantAPayer.MaxLength = 32767
        Me.txtMontantAPayer.Name = "txtMontantAPayer"
        Me.txtMontantAPayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantAPayer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantAPayer.SelectedText = ""
        Me.txtMontantAPayer.SelectionLength = 0
        Me.txtMontantAPayer.SelectionStart = 0
        Me.txtMontantAPayer.ShortcutsEnabled = True
        Me.txtMontantAPayer.Size = New System.Drawing.Size(264, 30)
        Me.txtMontantAPayer.TabIndex = 1
        Me.txtMontantAPayer.UseSelectable = True
        Me.txtMontantAPayer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantAPayer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbMontP
        '
        Me.lbMontP.AutoSize = True
        Me.lbMontP.Location = New System.Drawing.Point(72, 34)
        Me.lbMontP.Name = "lbMontP"
        Me.lbMontP.Size = New System.Drawing.Size(106, 19)
        Me.lbMontP.TabIndex = 0
        Me.lbMontP.Text = "Montant à payer"
        '
        'lbTypeP
        '
        Me.lbTypeP.AutoSize = True
        Me.lbTypeP.Location = New System.Drawing.Point(72, 73)
        Me.lbTypeP.Name = "lbTypeP"
        Me.lbTypeP.Size = New System.Drawing.Size(115, 19)
        Me.lbTypeP.TabIndex = 0
        Me.lbTypeP.Text = "Type de paiement"
        '
        'btUpdate
        '
        Me.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btUpdate.Location = New System.Drawing.Point(256, 188)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(145, 45)
        Me.btUpdate.TabIndex = 4
        Me.btUpdate.Text = "Ajouter paiement"
        Me.btUpdate.UseSelectable = True
        '
        'lbCheque
        '
        Me.lbCheque.AutoSize = True
        Me.lbCheque.Location = New System.Drawing.Point(72, 147)
        Me.lbCheque.Name = "lbCheque"
        Me.lbCheque.Size = New System.Drawing.Size(73, 19)
        Me.lbCheque.TabIndex = 0
        Me.lbCheque.Text = "N° Cheque"
        Me.lbCheque.Visible = False
        '
        'chkVirement
        '
        Me.chkVirement.AutoSize = True
        Me.chkVirement.Location = New System.Drawing.Point(495, 75)
        Me.chkVirement.Name = "chkVirement"
        Me.chkVirement.Size = New System.Drawing.Size(71, 15)
        Me.chkVirement.TabIndex = 3
        Me.chkVirement.Text = "Virement"
        Me.chkVirement.UseSelectable = True
        '
        'lbMontR
        '
        Me.lbMontR.AutoSize = True
        Me.lbMontR.Location = New System.Drawing.Point(72, 109)
        Me.lbMontR.Name = "lbMontR"
        Me.lbMontR.Size = New System.Drawing.Size(101, 19)
        Me.lbMontR.TabIndex = 0
        Me.lbMontR.Text = "Montant restant"
        '
        'chkCheque
        '
        Me.chkCheque.AutoSize = True
        Me.chkCheque.Location = New System.Drawing.Point(413, 75)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(64, 15)
        Me.chkCheque.TabIndex = 3
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.UseSelectable = True
        '
        'txtNumCheque
        '
        '
        '
        '
        Me.txtNumCheque.CustomButton.Image = Nothing
        Me.txtNumCheque.CustomButton.Location = New System.Drawing.Point(236, 2)
        Me.txtNumCheque.CustomButton.Name = ""
        Me.txtNumCheque.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNumCheque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumCheque.CustomButton.TabIndex = 1
        Me.txtNumCheque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumCheque.CustomButton.UseSelectable = True
        Me.txtNumCheque.CustomButton.Visible = False
        Me.txtNumCheque.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumCheque.Lines = New String(-1) {}
        Me.txtNumCheque.Location = New System.Drawing.Point(321, 141)
        Me.txtNumCheque.MaxLength = 32767
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCheque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumCheque.SelectedText = ""
        Me.txtNumCheque.SelectionLength = 0
        Me.txtNumCheque.SelectionStart = 0
        Me.txtNumCheque.ShortcutsEnabled = True
        Me.txtNumCheque.Size = New System.Drawing.Size(264, 30)
        Me.txtNumCheque.TabIndex = 1
        Me.txtNumCheque.UseSelectable = True
        Me.txtNumCheque.Visible = False
        Me.txtNumCheque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumCheque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkEspece
        '
        Me.chkEspece.AutoSize = True
        Me.chkEspece.Checked = True
        Me.chkEspece.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEspece.Location = New System.Drawing.Point(330, 75)
        Me.chkEspece.Name = "chkEspece"
        Me.chkEspece.Size = New System.Drawing.Size(59, 15)
        Me.chkEspece.TabIndex = 3
        Me.chkEspece.Text = "Espèce"
        Me.chkEspece.UseSelectable = True
        '
        'txtMontantR
        '
        '
        '
        '
        Me.txtMontantR.CustomButton.Image = Nothing
        Me.txtMontantR.CustomButton.Location = New System.Drawing.Point(236, 2)
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
        Me.txtMontantR.Location = New System.Drawing.Point(321, 103)
        Me.txtMontantR.MaxLength = 32767
        Me.txtMontantR.Name = "txtMontantR"
        Me.txtMontantR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantR.SelectedText = ""
        Me.txtMontantR.SelectionLength = 0
        Me.txtMontantR.SelectionStart = 0
        Me.txtMontantR.ShortcutsEnabled = True
        Me.txtMontantR.Size = New System.Drawing.Size(264, 30)
        Me.txtMontantR.TabIndex = 1
        Me.txtMontantR.UseSelectable = True
        Me.txtMontantR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMontantRecu)
        Me.GroupBox3.Controls.Add(Me.MetroLabel2)
        Me.GroupBox3.Controls.Add(Me.MetroLabel10)
        Me.GroupBox3.Controls.Add(Me.MetroLabel11)
        Me.GroupBox3.Controls.Add(Me.txtNbreEff)
        Me.GroupBox3.Controls.Add(Me.txtNbreR)
        Me.GroupBox3.Controls.Add(Me.MetroLabel3)
        Me.GroupBox3.Controls.Add(Me.txtDette)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(624, 264)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ANCIEN PAIEMENT"
        '
        'txtMontantRecu
        '
        '
        '
        '
        Me.txtMontantRecu.CustomButton.Image = Nothing
        Me.txtMontantRecu.CustomButton.Location = New System.Drawing.Point(217, 2)
        Me.txtMontantRecu.CustomButton.Name = ""
        Me.txtMontantRecu.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontantRecu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontantRecu.CustomButton.TabIndex = 1
        Me.txtMontantRecu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontantRecu.CustomButton.UseSelectable = True
        Me.txtMontantRecu.CustomButton.Visible = False
        Me.txtMontantRecu.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontantRecu.Lines = New String(-1) {}
        Me.txtMontantRecu.Location = New System.Drawing.Point(328, 61)
        Me.txtMontantRecu.MaxLength = 32767
        Me.txtMontantRecu.Name = "txtMontantRecu"
        Me.txtMontantRecu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontantRecu.ReadOnly = True
        Me.txtMontantRecu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontantRecu.SelectedText = ""
        Me.txtMontantRecu.SelectionLength = 0
        Me.txtMontantRecu.SelectionStart = 0
        Me.txtMontantRecu.ShortcutsEnabled = True
        Me.txtMontantRecu.Size = New System.Drawing.Size(245, 30)
        Me.txtMontantRecu.TabIndex = 1
        Me.txtMontantRecu.UseSelectable = True
        Me.txtMontantRecu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontantRecu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(50, 64)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Montant Total"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(50, 137)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(192, 19)
        Me.MetroLabel10.TabIndex = 0
        Me.MetroLabel10.Text = "Nombre de paiement effectués"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(50, 174)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(180, 19)
        Me.MetroLabel11.TabIndex = 0
        Me.MetroLabel11.Text = "Nombre de paiement restant"
        '
        'txtNbreEff
        '
        '
        '
        '
        Me.txtNbreEff.CustomButton.Image = Nothing
        Me.txtNbreEff.CustomButton.Location = New System.Drawing.Point(217, 2)
        Me.txtNbreEff.CustomButton.Name = ""
        Me.txtNbreEff.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNbreEff.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbreEff.CustomButton.TabIndex = 1
        Me.txtNbreEff.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbreEff.CustomButton.UseSelectable = True
        Me.txtNbreEff.CustomButton.Visible = False
        Me.txtNbreEff.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNbreEff.Lines = New String(-1) {}
        Me.txtNbreEff.Location = New System.Drawing.Point(329, 134)
        Me.txtNbreEff.MaxLength = 32767
        Me.txtNbreEff.Name = "txtNbreEff"
        Me.txtNbreEff.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbreEff.ReadOnly = True
        Me.txtNbreEff.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbreEff.SelectedText = ""
        Me.txtNbreEff.SelectionLength = 0
        Me.txtNbreEff.SelectionStart = 0
        Me.txtNbreEff.ShortcutsEnabled = True
        Me.txtNbreEff.Size = New System.Drawing.Size(245, 30)
        Me.txtNbreEff.TabIndex = 1
        Me.txtNbreEff.UseSelectable = True
        Me.txtNbreEff.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbreEff.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNbreR
        '
        '
        '
        '
        Me.txtNbreR.CustomButton.Image = Nothing
        Me.txtNbreR.CustomButton.Location = New System.Drawing.Point(217, 2)
        Me.txtNbreR.CustomButton.Name = ""
        Me.txtNbreR.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNbreR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNbreR.CustomButton.TabIndex = 1
        Me.txtNbreR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNbreR.CustomButton.UseSelectable = True
        Me.txtNbreR.CustomButton.Visible = False
        Me.txtNbreR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNbreR.Lines = New String(-1) {}
        Me.txtNbreR.Location = New System.Drawing.Point(329, 173)
        Me.txtNbreR.MaxLength = 32767
        Me.txtNbreR.Name = "txtNbreR"
        Me.txtNbreR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNbreR.ReadOnly = True
        Me.txtNbreR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNbreR.SelectedText = ""
        Me.txtNbreR.SelectionLength = 0
        Me.txtNbreR.SelectionStart = 0
        Me.txtNbreR.ShortcutsEnabled = True
        Me.txtNbreR.Size = New System.Drawing.Size(245, 30)
        Me.txtNbreR.TabIndex = 1
        Me.txtNbreR.UseSelectable = True
        Me.txtNbreR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNbreR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(50, 101)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Dette actuelle"
        '
        'txtDette
        '
        '
        '
        '
        Me.txtDette.CustomButton.Image = Nothing
        Me.txtDette.CustomButton.Location = New System.Drawing.Point(217, 2)
        Me.txtDette.CustomButton.Name = ""
        Me.txtDette.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtDette.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDette.CustomButton.TabIndex = 1
        Me.txtDette.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDette.CustomButton.UseSelectable = True
        Me.txtDette.CustomButton.Visible = False
        Me.txtDette.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDette.Lines = New String(-1) {}
        Me.txtDette.Location = New System.Drawing.Point(328, 98)
        Me.txtDette.MaxLength = 32767
        Me.txtDette.Name = "txtDette"
        Me.txtDette.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDette.ReadOnly = True
        Me.txtDette.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDette.SelectedText = ""
        Me.txtDette.SelectionLength = 0
        Me.txtDette.SelectionStart = 0
        Me.txtDette.ShortcutsEnabled = True
        Me.txtDette.Size = New System.Drawing.Size(245, 30)
        Me.txtDette.TabIndex = 1
        Me.txtDette.UseSelectable = True
        Me.txtDette.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDette.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lbNumFond
        '
        Me.lbNumFond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNumFond.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbNumFond.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbNumFond.Location = New System.Drawing.Point(199, 21)
        Me.lbNumFond.Name = "lbNumFond"
        Me.lbNumFond.Size = New System.Drawing.Size(443, 28)
        Me.lbNumFond.TabIndex = 5
        Me.lbNumFond.Text = "...."
        Me.lbNumFond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(32, 26)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel9.TabIndex = 0
        Me.MetroLabel9.Text = "Nom de l'étudiant"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Controls.Add(Me.lb_msg)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.ListeEtudiants)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1328, 267)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(830, 29)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(196, 15)
        Me.chkAll.TabIndex = 6
        Me.chkAll.Text = "Afficher tous les enregistrements"
        Me.chkAll.UseSelectable = True
        '
        'lb_msg
        '
        Me.lb_msg.AutoSize = True
        Me.lb_msg.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lb_msg.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lb_msg.Location = New System.Drawing.Point(585, 155)
        Me.lb_msg.Name = "lb_msg"
        Me.lb_msg.Size = New System.Drawing.Size(0, 0)
        Me.lb_msg.TabIndex = 5
        Me.lb_msg.Visible = False
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(207, 2)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(575, 21)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(235, 30)
        Me.txtNom.TabIndex = 4
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ListeEtudiants
        '
        Me.ListeEtudiants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListeEtudiants.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeEtudiants.FullRowSelect = True
        Me.ListeEtudiants.GridLines = True
        Me.ListeEtudiants.Location = New System.Drawing.Point(18, 69)
        Me.ListeEtudiants.Name = "ListeEtudiants"
        Me.ListeEtudiants.Size = New System.Drawing.Size(1272, 189)
        Me.ListeEtudiants.TabIndex = 2
        Me.ListeEtudiants.UseCompatibleStateImageBehavior = False
        Me.ListeEtudiants.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom du bénéficiare"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 327
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Montant déja payé"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 211
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Montant restant"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 269
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Début paeiment"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 236
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fin paiement"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 221
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "echeance"
        Me.ColumnHeader7.Width = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(406, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Rechercher un étudiant"
        '
        'AddPaiementFond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddPaiementFond"
        Me.Text = "FOND DE SOUTIEN :  ADDITION DE PAIEMENT"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListeEtudiants As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDette As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontantRecu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkVirement As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCheque As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkEspece As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtMontantAPayer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbTypeP As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbMontP As MetroFramework.Controls.MetroLabel
    Friend WithEvents btUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents txtMontantR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbMontR As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumCheque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbCheque As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbNumFond As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lb_msg As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtNbreR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNbreEff As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents lbPAiement As MetroFramework.Controls.MetroLabel
End Class
