<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEmploye = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnRevoke = New System.Windows.Forms.Button()
        Me.btnGrant = New System.Windows.Forms.Button()
        Me.ListeGranted = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListAccess = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbEmploye)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 534)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utilisateur"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(130, 276)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(261, 29)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(129, 242)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(261, 29)
        Me.txtNom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mot de passe : "
        '
        'cmbEmploye
        '
        Me.cmbEmploye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmploye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmploye.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmploye.FormattingEnabled = True
        Me.cmbEmploye.Location = New System.Drawing.Point(129, 209)
        Me.cmbEmploye.Name = "cmbEmploye"
        Me.cmbEmploye.Size = New System.Drawing.Size(261, 29)
        Me.cmbEmploye.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Login : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employe : "
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.Transparent
        Me.btnValider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnValider.FlatAppearance.BorderSize = 2
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.Location = New System.Drawing.Point(450, 564)
        Me.btnValider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(141, 42)
        Me.btnValider.TabIndex = 48
        Me.btnValider.Text = "Valider"
        Me.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(599, 564)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 42)
        Me.btnClose.TabIndex = 47
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.btnRevoke)
        Me.PanelContainer.Controls.Add(Me.btnGrant)
        Me.PanelContainer.Controls.Add(Me.ListeGranted)
        Me.PanelContainer.Controls.Add(Me.ListAccess)
        Me.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.PanelContainer.Controls.Add(Me.btnValider)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Location = New System.Drawing.Point(12, 63)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1167, 620)
        Me.PanelContainer.TabIndex = 49
        '
        'btnRevoke
        '
        Me.btnRevoke.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRevoke.FlatAppearance.BorderSize = 2
        Me.btnRevoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevoke.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevoke.Location = New System.Drawing.Point(746, 300)
        Me.btnRevoke.Name = "btnRevoke"
        Me.btnRevoke.Size = New System.Drawing.Size(75, 31)
        Me.btnRevoke.TabIndex = 50
        Me.btnRevoke.Text = "<<"
        Me.btnRevoke.UseVisualStyleBackColor = True
        '
        'btnGrant
        '
        Me.btnGrant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGrant.FlatAppearance.BorderSize = 2
        Me.btnGrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrant.Location = New System.Drawing.Point(746, 263)
        Me.btnGrant.Name = "btnGrant"
        Me.btnGrant.Size = New System.Drawing.Size(75, 31)
        Me.btnGrant.TabIndex = 50
        Me.btnGrant.Text = ">>"
        Me.btnGrant.UseVisualStyleBackColor = True
        '
        'ListeGranted
        '
        Me.ListeGranted.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.ListeGranted.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeGranted.FullRowSelect = True
        Me.ListeGranted.GridLines = True
        Me.ListeGranted.Location = New System.Drawing.Point(828, 14)
        Me.ListeGranted.Name = "ListeGranted"
        Me.ListeGranted.Size = New System.Drawing.Size(324, 534)
        Me.ListeGranted.TabIndex = 49
        Me.ListeGranted.UseCompatibleStateImageBehavior = False
        Me.ListeGranted.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "access"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Accès accordés"
        Me.ColumnHeader4.Width = 315
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "position"
        Me.ColumnHeader6.Width = 0
        '
        'ListAccess
        '
        Me.ListAccess.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5})
        Me.ListAccess.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListAccess.FullRowSelect = True
        Me.ListAccess.GridLines = True
        Me.ListAccess.Location = New System.Drawing.Point(414, 14)
        Me.ListAccess.Name = "ListAccess"
        Me.ListAccess.Size = New System.Drawing.Size(324, 534)
        Me.ListAccess.TabIndex = 49
        Me.ListAccess.UseCompatibleStateImageBehavior = False
        Me.ListAccess.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "access"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Accès dipsonible"
        Me.ColumnHeader2.Width = 316
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "position"
        Me.ColumnHeader5.Width = 0
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 712)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Users"
        Me.Text = "UTILISATEUR"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEmploye As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents ListeGranted As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListAccess As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRevoke As System.Windows.Forms.Button
    Friend WithEvents btnGrant As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
