<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBureau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBureau))
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.ListeEtudiants = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbDate = New MetroFramework.Controls.MetroDateTime()
        Me.cmbPoste = New MetroFramework.Controls.MetroComboBox()
        Me.cmbEtudiant = New MetroFramework.Controls.MetroComboBox()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(335, 130)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 40)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "METTRE A JOUR"
        Me.btnUpdate.UseSelectable = True
        Me.btnUpdate.Visible = False
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(75, 222)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(335, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Liste des membres du bureau, cliquer pour modifier"
        '
        'ListeEtudiants
        '
        Me.ListeEtudiants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListeEtudiants.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeEtudiants.FullRowSelect = True
        Me.ListeEtudiants.GridLines = True
        Me.ListeEtudiants.Location = New System.Drawing.Point(75, 248)
        Me.ListeEtudiants.Name = "ListeEtudiants"
        Me.ListeEtudiants.Size = New System.Drawing.Size(761, 217)
        Me.ListeEtudiants.TabIndex = 5
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
        Me.ColumnHeader2.Text = "Nom de l'étudiant"
        Me.ColumnHeader2.Width = 301
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Poste"
        Me.ColumnHeader3.Width = 211
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date de prise de fonction"
        Me.ColumnHeader4.Width = 237
        '
        'cmbDate
        '
        Me.cmbDate.Location = New System.Drawing.Point(358, 91)
        Me.cmbDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(315, 29)
        Me.cmbDate.TabIndex = 4
        '
        'cmbPoste
        '
        Me.cmbPoste.FormattingEnabled = True
        Me.cmbPoste.ItemHeight = 23
        Me.cmbPoste.Items.AddRange(New Object() {"", "DIRECTEUR", "ASSISTANT", "SECRETAIRE"})
        Me.cmbPoste.Location = New System.Drawing.Point(358, 53)
        Me.cmbPoste.Name = "cmbPoste"
        Me.cmbPoste.Size = New System.Drawing.Size(315, 29)
        Me.cmbPoste.TabIndex = 3
        Me.cmbPoste.UseSelectable = True
        '
        'cmbEtudiant
        '
        Me.cmbEtudiant.FormattingEnabled = True
        Me.cmbEtudiant.ItemHeight = 23
        Me.cmbEtudiant.Location = New System.Drawing.Point(358, 19)
        Me.cmbEtudiant.Name = "cmbEtudiant"
        Me.cmbEtudiant.Size = New System.Drawing.Size(315, 29)
        Me.cmbEtudiant.TabIndex = 3
        Me.cmbEtudiant.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(457, 130)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 40)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "AJOUTER"
        Me.btnAdd.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(173, 96)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(176, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Date de prise de fonction :"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(173, 24)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(171, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Sélectionner un étudiant :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(173, 58)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Poste : "
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.cmbEtudiant)
        Me.PanelContainer.Controls.Add(Me.MetroLabel4)
        Me.PanelContainer.Controls.Add(Me.btnUpdate)
        Me.PanelContainer.Controls.Add(Me.ListeEtudiants)
        Me.PanelContainer.Controls.Add(Me.cmbPoste)
        Me.PanelContainer.Controls.Add(Me.btnAdd)
        Me.PanelContainer.Controls.Add(Me.MetroLabel1)
        Me.PanelContainer.Controls.Add(Me.cmbDate)
        Me.PanelContainer.Controls.Add(Me.MetroLabel3)
        Me.PanelContainer.Controls.Add(Me.MetroLabel2)
        Me.PanelContainer.Location = New System.Drawing.Point(23, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(903, 521)
        Me.PanelContainer.TabIndex = 8
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(393, 472)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(117, 34)
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'AddBureau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 607)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddBureau"
        Me.Text = "BUREAU ALUMNI"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeEtudiants As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbPoste As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbEtudiant As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
