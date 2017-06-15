<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeAlumni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeAlumni))
        Me.ListeEtudiants = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.labelTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListeEtudiants
        '
        Me.ListeEtudiants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader3})
        Me.ListeEtudiants.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeEtudiants.FullRowSelect = True
        Me.ListeEtudiants.GridLines = True
        Me.ListeEtudiants.Location = New System.Drawing.Point(5, 71)
        Me.ListeEtudiants.Name = "ListeEtudiants"
        Me.ListeEtudiants.Size = New System.Drawing.Size(1184, 448)
        Me.ListeEtudiants.TabIndex = 0
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
        Me.ColumnHeader2.Text = "NOM & PRENOM"
        Me.ColumnHeader2.Width = 197
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TELEPHONE"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "EMAIL"
        Me.ColumnHeader5.Width = 187
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DATE GRADUATION"
        Me.ColumnHeader6.Width = 190
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "FORMATION"
        Me.ColumnHeader7.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ADRESSE"
        Me.ColumnHeader3.Width = 222
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(539, 571)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(117, 34)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroButton2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1185, 62)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.Location = New System.Drawing.Point(661, 25)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(175, 23)
        Me.MetroButton2.TabIndex = 2
        Me.MetroButton2.Text = "Tout afficher"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(142, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Nom / Prenom : "
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(349, 2)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(257, 22)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(377, 30)
        Me.txtNom.TabIndex = 0
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'labelTotal
        '
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.labelTotal.Location = New System.Drawing.Point(603, 528)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(156, 34)
        Me.labelTotal.TabIndex = 7
        Me.labelTotal.Text = "0"
        Me.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(435, 534)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(162, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Nombre des membres : "
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.labelTotal)
        Me.PanelContainer.Controls.Add(Me.MetroLabel2)
        Me.PanelContainer.Controls.Add(Me.ListeEtudiants)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Location = New System.Drawing.Point(23, 58)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1195, 622)
        Me.PanelContainer.TabIndex = 8
        '
        'ListeAlumni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 703)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeAlumni"
        Me.Text = "LISTE DES MEMBRES ALUMNI"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeEtudiants As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents labelTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
End Class
