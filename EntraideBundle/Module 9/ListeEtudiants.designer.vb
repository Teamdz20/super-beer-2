<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeEtudiants
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
        Me.ListeEtudiant = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.chkAll = New MetroFramework.Controls.MetroCheckBox()
        Me.lb_msg = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'ListeEtudiant
        '
        Me.ListeEtudiant.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListeEtudiant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListeEtudiant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeEtudiant.FullRowSelect = True
        Me.ListeEtudiant.GridLines = True
        Me.ListeEtudiant.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListeEtudiant.Location = New System.Drawing.Point(23, 108)
        Me.ListeEtudiant.MultiSelect = False
        Me.ListeEtudiant.Name = "ListeEtudiant"
        Me.ListeEtudiant.ShowItemToolTips = True
        Me.ListeEtudiant.Size = New System.Drawing.Size(620, 546)
        Me.ListeEtudiant.TabIndex = 0
        Me.ListeEtudiant.UseCompatibleStateImageBehavior = False
        Me.ListeEtudiant.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Liste des étudiants"
        Me.ColumnHeader2.Width = 362
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = ""
        Me.ColumnHeader3.Width = 230
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(157, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Rechercher un étudiant"
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(181, 1)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(216, 69)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(203, 23)
        Me.txtNom.TabIndex = 0
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(448, 77)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(160, 15)
        Me.chkAll.TabIndex = 4
        Me.chkAll.Text = "Afficher tous les étudiants"
        Me.chkAll.UseSelectable = True
        '
        'lb_msg
        '
        Me.lb_msg.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lb_msg.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lb_msg.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lb_msg.Location = New System.Drawing.Point(234, 247)
        Me.lb_msg.Name = "lb_msg"
        Me.lb_msg.Size = New System.Drawing.Size(305, 55)
        Me.lb_msg.TabIndex = 5
        Me.lb_msg.Visible = False
        '
        'ListeEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 662)
        Me.Controls.Add(Me.lb_msg)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.ListeEtudiant)
        Me.Name = "ListeEtudiants"
        Me.Resizable = False
        Me.Text = "Sélectionnez un étudiant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListeEtudiant As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lb_msg As MetroFramework.Controls.MetroLabel
End Class
