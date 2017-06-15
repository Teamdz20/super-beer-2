<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeEtudiantsDette
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
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.lb_msg = New MetroFramework.Controls.MetroLabel()
        Me.ListeEtudiant = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.chkAll = New MetroFramework.Controls.MetroCheckBox()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.lb_msg)
        Me.PanelContainer.Controls.Add(Me.ListeEtudiant)
        Me.PanelContainer.Controls.Add(Me.MetroLabel1)
        Me.PanelContainer.Controls.Add(Me.chkAll)
        Me.PanelContainer.Controls.Add(Me.txtNom)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(23, 58)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1044, 598)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(452, 554)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 33)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'lb_msg
        '
        Me.lb_msg.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lb_msg.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lb_msg.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lb_msg.Location = New System.Drawing.Point(370, 243)
        Me.lb_msg.Name = "lb_msg"
        Me.lb_msg.Size = New System.Drawing.Size(305, 55)
        Me.lb_msg.TabIndex = 9
        Me.lb_msg.Text = "..."
        Me.lb_msg.Visible = False
        '
        'ListeEtudiant
        '
        Me.ListeEtudiant.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListeEtudiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListeEtudiant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListeEtudiant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeEtudiant.FullRowSelect = True
        Me.ListeEtudiant.GridLines = True
        Me.ListeEtudiant.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListeEtudiant.Location = New System.Drawing.Point(9, 56)
        Me.ListeEtudiant.MultiSelect = False
        Me.ListeEtudiant.Name = "ListeEtudiant"
        Me.ListeEtudiant.ShowItemToolTips = True
        Me.ListeEtudiant.Size = New System.Drawing.Size(1028, 492)
        Me.ListeEtudiant.TabIndex = 8
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
        Me.ColumnHeader2.Text = "Nom de l'étudiant"
        Me.ColumnHeader2.Width = 299
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Montant de la formation"
        Me.ColumnHeader3.Width = 230
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Montant Payé"
        Me.ColumnHeader4.Width = 249
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Dette Actuelle"
        Me.ColumnHeader5.Width = 226
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(186, 20)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Rechercher un étudiant"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(601, 21)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(160, 15)
        Me.chkAll.TabIndex = 6
        Me.chkAll.Text = "Afficher tous les étudiants"
        Me.chkAll.UseSelectable = True
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
        Me.txtNom.Location = New System.Drawing.Point(367, 17)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(203, 23)
        Me.txtNom.TabIndex = 5
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ListeEtudiantsDette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 679)
        Me.Controls.Add(Me.PanelContainer)
        Me.MaximizeBox = False
        Me.Name = "ListeEtudiantsDette"
        Me.Resizable = False
        Me.Text = "LISTE DES ETUDIANTS AYANT DES DETTES"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ListeEtudiant As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lb_msg As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
End Class
