<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revenu
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
        Me.CustomInstaller1 = New MySql.Data.MySqlClient.CustomInstaller()
        Me.PanelContainer = New System.Windows.Forms.GroupBox()
        Me.btSave = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btVider = New MetroFramework.Controls.MetroButton()
        Me.txtMemo = New MetroFramework.Controls.MetroTextBox()
        Me.txtReglement = New MetroFramework.Controls.MetroTextBox()
        Me.txtPoste = New MetroFramework.Controls.MetroTextBox()
        Me.cmbRecuDe = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDevise = New MetroFramework.Controls.MetroComboBox()
        Me.txtMontant = New MetroFramework.Controls.MetroTextBox()
        Me.cmbManager = New MetroFramework.Controls.MetroComboBox()
        Me.cmbType = New MetroFramework.Controls.MetroComboBox()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.cmbClassification = New MetroFramework.Controls.MetroComboBox()
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmbActivite = New MetroFramework.Controls.MetroComboBox()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btSave)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.btVider)
        Me.PanelContainer.Controls.Add(Me.cmbActivite)
        Me.PanelContainer.Controls.Add(Me.txtMemo)
        Me.PanelContainer.Controls.Add(Me.txtReglement)
        Me.PanelContainer.Controls.Add(Me.txtPoste)
        Me.PanelContainer.Controls.Add(Me.cmbRecuDe)
        Me.PanelContainer.Controls.Add(Me.cmbDevise)
        Me.PanelContainer.Controls.Add(Me.txtMontant)
        Me.PanelContainer.Controls.Add(Me.cmbManager)
        Me.PanelContainer.Controls.Add(Me.cmbType)
        Me.PanelContainer.Controls.Add(Me.txtCode)
        Me.PanelContainer.Controls.Add(Me.cmbClassification)
        Me.PanelContainer.Controls.Add(Me.dtDate)
        Me.PanelContainer.Controls.Add(Me.MetroLabel11)
        Me.PanelContainer.Controls.Add(Me.MetroLabel10)
        Me.PanelContainer.Controls.Add(Me.MetroLabel9)
        Me.PanelContainer.Controls.Add(Me.MetroLabel8)
        Me.PanelContainer.Controls.Add(Me.MetroLabel7)
        Me.PanelContainer.Controls.Add(Me.MetroLabel6)
        Me.PanelContainer.Controls.Add(Me.MetroLabel5)
        Me.PanelContainer.Controls.Add(Me.MetroLabel4)
        Me.PanelContainer.Controls.Add(Me.MetroLabel3)
        Me.PanelContainer.Controls.Add(Me.MetroLabel2)
        Me.PanelContainer.Controls.Add(Me.MetroLabel1)
        Me.PanelContainer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(810, 569)
        Me.PanelContainer.TabIndex = 4
        Me.PanelContainer.TabStop = False
        Me.PanelContainer.Text = "Uniquement pour les revenus provenat des AGRs"
        '
        'btSave
        '
        Me.btSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSave.Location = New System.Drawing.Point(350, 506)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(111, 35)
        Me.btSave.TabIndex = 48
        Me.btSave.Text = "Enregistrer"
        Me.btSave.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(465, 506)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(111, 35)
        Me.MetroButton1.TabIndex = 47
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'btVider
        '
        Me.btVider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btVider.Location = New System.Drawing.Point(235, 506)
        Me.btVider.Name = "btVider"
        Me.btVider.Size = New System.Drawing.Size(111, 35)
        Me.btVider.TabIndex = 47
        Me.btVider.Text = "Vider"
        Me.btVider.UseSelectable = True
        '
        'txtMemo
        '
        '
        '
        '
        Me.txtMemo.CustomButton.Image = Nothing
        Me.txtMemo.CustomButton.Location = New System.Drawing.Point(366, 2)
        Me.txtMemo.CustomButton.Name = ""
        Me.txtMemo.CustomButton.Size = New System.Drawing.Size(41, 41)
        Me.txtMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMemo.CustomButton.TabIndex = 1
        Me.txtMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMemo.CustomButton.UseSelectable = True
        Me.txtMemo.CustomButton.Visible = False
        Me.txtMemo.Lines = New String(-1) {}
        Me.txtMemo.Location = New System.Drawing.Point(280, 449)
        Me.txtMemo.MaxLength = 32767
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMemo.SelectedText = ""
        Me.txtMemo.SelectionLength = 0
        Me.txtMemo.SelectionStart = 0
        Me.txtMemo.ShortcutsEnabled = True
        Me.txtMemo.Size = New System.Drawing.Size(410, 46)
        Me.txtMemo.TabIndex = 44
        Me.txtMemo.UseSelectable = True
        Me.txtMemo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMemo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtReglement
        '
        '
        '
        '
        Me.txtReglement.CustomButton.Image = Nothing
        Me.txtReglement.CustomButton.Location = New System.Drawing.Point(373, 2)
        Me.txtReglement.CustomButton.Name = ""
        Me.txtReglement.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtReglement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReglement.CustomButton.TabIndex = 1
        Me.txtReglement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReglement.CustomButton.UseSelectable = True
        Me.txtReglement.CustomButton.Visible = False
        Me.txtReglement.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtReglement.Lines = New String(-1) {}
        Me.txtReglement.Location = New System.Drawing.Point(280, 398)
        Me.txtReglement.MaxLength = 32767
        Me.txtReglement.Multiline = True
        Me.txtReglement.Name = "txtReglement"
        Me.txtReglement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReglement.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReglement.SelectedText = ""
        Me.txtReglement.SelectionLength = 0
        Me.txtReglement.SelectionStart = 0
        Me.txtReglement.ShortcutsEnabled = True
        Me.txtReglement.Size = New System.Drawing.Size(411, 40)
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
        Me.txtPoste.CustomButton.Location = New System.Drawing.Point(383, 2)
        Me.txtPoste.CustomButton.Name = ""
        Me.txtPoste.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPoste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPoste.CustomButton.TabIndex = 1
        Me.txtPoste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPoste.CustomButton.UseSelectable = True
        Me.txtPoste.CustomButton.Visible = False
        Me.txtPoste.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPoste.Lines = New String(-1) {}
        Me.txtPoste.Location = New System.Drawing.Point(280, 357)
        Me.txtPoste.MaxLength = 32767
        Me.txtPoste.Name = "txtPoste"
        Me.txtPoste.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPoste.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPoste.SelectedText = ""
        Me.txtPoste.SelectionLength = 0
        Me.txtPoste.SelectionStart = 0
        Me.txtPoste.ShortcutsEnabled = True
        Me.txtPoste.Size = New System.Drawing.Size(411, 30)
        Me.txtPoste.TabIndex = 43
        Me.txtPoste.UseSelectable = True
        Me.txtPoste.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPoste.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbRecuDe
        '
        Me.cmbRecuDe.FormattingEnabled = True
        Me.cmbRecuDe.ItemHeight = 23
        Me.cmbRecuDe.Location = New System.Drawing.Point(280, 317)
        Me.cmbRecuDe.Name = "cmbRecuDe"
        Me.cmbRecuDe.Size = New System.Drawing.Size(411, 29)
        Me.cmbRecuDe.TabIndex = 42
        Me.cmbRecuDe.UseSelectable = True
        '
        'cmbDevise
        '
        Me.cmbDevise.FormattingEnabled = True
        Me.cmbDevise.ItemHeight = 23
        Me.cmbDevise.Location = New System.Drawing.Point(280, 277)
        Me.cmbDevise.Name = "cmbDevise"
        Me.cmbDevise.Size = New System.Drawing.Size(411, 29)
        Me.cmbDevise.TabIndex = 41
        Me.cmbDevise.UseSelectable = True
        '
        'txtMontant
        '
        '
        '
        '
        Me.txtMontant.CustomButton.Image = Nothing
        Me.txtMontant.CustomButton.Location = New System.Drawing.Point(383, 2)
        Me.txtMontant.CustomButton.Name = ""
        Me.txtMontant.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontant.CustomButton.TabIndex = 1
        Me.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontant.CustomButton.UseSelectable = True
        Me.txtMontant.CustomButton.Visible = False
        Me.txtMontant.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontant.Lines = New String(-1) {}
        Me.txtMontant.Location = New System.Drawing.Point(280, 236)
        Me.txtMontant.MaxLength = 32767
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontant.SelectedText = ""
        Me.txtMontant.SelectionLength = 0
        Me.txtMontant.SelectionStart = 0
        Me.txtMontant.ShortcutsEnabled = True
        Me.txtMontant.Size = New System.Drawing.Size(411, 30)
        Me.txtMontant.TabIndex = 40
        Me.txtMontant.UseSelectable = True
        Me.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbManager
        '
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.ItemHeight = 23
        Me.cmbManager.Location = New System.Drawing.Point(280, 196)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(410, 29)
        Me.cmbManager.TabIndex = 39
        Me.cmbManager.UseSelectable = True
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 23
        Me.cmbType.Location = New System.Drawing.Point(280, 115)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(411, 29)
        Me.cmbType.TabIndex = 38
        Me.cmbType.UseSelectable = True
        '
        'txtCode
        '
        '
        '
        '
        Me.txtCode.CustomButton.Image = Nothing
        Me.txtCode.CustomButton.Location = New System.Drawing.Point(11, 2)
        Me.txtCode.CustomButton.Name = ""
        Me.txtCode.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCode.CustomButton.TabIndex = 1
        Me.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCode.CustomButton.UseSelectable = True
        Me.txtCode.CustomButton.Visible = False
        Me.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCode.Lines = New String(-1) {}
        Me.txtCode.Location = New System.Drawing.Point(735, 236)
        Me.txtCode.MaxLength = 32767
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCode.SelectedText = ""
        Me.txtCode.SelectionLength = 0
        Me.txtCode.SelectionStart = 0
        Me.txtCode.ShortcutsEnabled = True
        Me.txtCode.Size = New System.Drawing.Size(39, 30)
        Me.txtCode.TabIndex = 37
        Me.txtCode.UseSelectable = True
        Me.txtCode.Visible = False
        Me.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbClassification
        '
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.ItemHeight = 23
        Me.cmbClassification.Location = New System.Drawing.Point(280, 75)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(411, 29)
        Me.cmbClassification.TabIndex = 36
        Me.cmbClassification.UseSelectable = True
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(279, 35)
        Me.dtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(411, 29)
        Me.dtDate.TabIndex = 35
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(119, 463)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel11.TabIndex = 34
        Me.MetroLabel11.Text = "Memo :"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(119, 409)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel10.TabIndex = 33
        Me.MetroLabel10.Text = "En réglement de :"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(119, 363)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel9.TabIndex = 32
        Me.MetroLabel9.Text = "Poste :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(119, 322)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel8.TabIndex = 31
        Me.MetroLabel8.Text = "Reçu de :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(119, 282)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel7.TabIndex = 30
        Me.MetroLabel7.Text = "Devise :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(119, 242)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(153, 19)
        Me.MetroLabel6.TabIndex = 29
        Me.MetroLabel6.Text = "Montant à enregistrer :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(119, 201)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel5.TabIndex = 28
        Me.MetroLabel5.Text = "Nom du manager :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(119, 161)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 27
        Me.MetroLabel4.Text = "Code revenu"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(119, 120)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 26
        Me.MetroLabel3.Text = "Type AGR"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(119, 80)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(137, 19)
        Me.MetroLabel2.TabIndex = 25
        Me.MetroLabel2.Text = "Classification revenu"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(119, 40)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 24
        Me.MetroLabel1.Text = "Date :"
        '
        'cmbActivite
        '
        Me.cmbActivite.FormattingEnabled = True
        Me.cmbActivite.ItemHeight = 23
        Me.cmbActivite.Location = New System.Drawing.Point(279, 155)
        Me.cmbActivite.Name = "cmbActivite"
        Me.cmbActivite.Size = New System.Drawing.Size(411, 29)
        Me.cmbActivite.TabIndex = 39
        Me.cmbActivite.UseSelectable = True
        '
        'Revenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 655)
        Me.Controls.Add(Me.PanelContainer)
        Me.Name = "Revenu"
        Me.Text = "REVENU : NOUVEAU REVENU"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomInstaller1 As MySql.Data.MySqlClient.CustomInstaller
    Friend WithEvents PanelContainer As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPoste As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtReglement As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btVider As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbRecuDe As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDevise As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbManager As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbClassification As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtMemo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbActivite As MetroFramework.Controls.MetroComboBox

End Class
