<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeCategorieFournisseur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeCategorieFournisseur))
        Me.ListeCategorie = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkAll = New MetroFramework.Controls.MetroCheckBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTriggerUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListeCategorie
        '
        Me.ListeCategorie.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListeCategorie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListeCategorie.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeCategorie.FullRowSelect = True
        Me.ListeCategorie.GridLines = True
        Me.ListeCategorie.Location = New System.Drawing.Point(24, 153)
        Me.ListeCategorie.Name = "ListeCategorie"
        Me.ListeCategorie.Size = New System.Drawing.Size(634, 402)
        Me.ListeCategorie.TabIndex = 3
        Me.ListeCategorie.UseCompatibleStateImageBehavior = False
        Me.ListeCategorie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom"
        Me.ColumnHeader2.Width = 593
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(422, 36)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(142, 15)
        Me.chkAll.TabIndex = 2
        Me.chkAll.Text = "Afficher tous les codes"
        Me.chkAll.UseSelectable = True
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(251, 2)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(137, 28)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(279, 30)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 34)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Recherche rapide"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.MetroLabel1)
        Me.GroupBox3.Controls.Add(Me.chkAll)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(634, 67)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche rapide"
        '
        'btnTriggerUpdate
        '
        Me.btnTriggerUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTriggerUpdate.Location = New System.Drawing.Point(292, 570)
        Me.btnTriggerUpdate.Name = "btnTriggerUpdate"
        Me.btnTriggerUpdate.Size = New System.Drawing.Size(100, 34)
        Me.btnTriggerUpdate.TabIndex = 14
        Me.btnTriggerUpdate.Text = "MODIFIER"
        Me.btnTriggerUpdate.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(186, 570)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 34)
        Me.MetroButton1.TabIndex = 15
        Me.MetroButton1.Text = "NOUVEAU"
        Me.MetroButton1.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(398, 570)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 34)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'ListeCategorieFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 627)
        Me.Controls.Add(Me.btnTriggerUpdate)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListeCategorie)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListeCategorieFournisseur"
        Me.Resizable = False
        Me.Text = "CATEGORIE FOURNISSEUR : NOUVELLE CATEGORIE"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeCategorie As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTriggerUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
End Class
