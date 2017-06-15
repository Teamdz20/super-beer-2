<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeGeneration
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
        Me.ListGeneration = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnTriggerUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListGeneration
        '
        Me.ListGeneration.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListGeneration.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListGeneration.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListGeneration.FullRowSelect = True
        Me.ListGeneration.GridLines = True
        Me.ListGeneration.Location = New System.Drawing.Point(23, 135)
        Me.ListGeneration.Name = "ListGeneration"
        Me.ListGeneration.Size = New System.Drawing.Size(636, 434)
        Me.ListGeneration.TabIndex = 17
        Me.ListGeneration.UseCompatibleStateImageBehavior = False
        Me.ListGeneration.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Libelle"
        Me.ColumnHeader2.Width = 265
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
        Me.txtSearch.Location = New System.Drawing.Point(144, 26)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Recherche rapide"
        '
        'btnTriggerUpdate
        '
        Me.btnTriggerUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTriggerUpdate.Location = New System.Drawing.Point(291, 575)
        Me.btnTriggerUpdate.Name = "btnTriggerUpdate"
        Me.btnTriggerUpdate.Size = New System.Drawing.Size(100, 34)
        Me.btnTriggerUpdate.TabIndex = 19
        Me.btnTriggerUpdate.Text = "MODIFIER"
        Me.btnTriggerUpdate.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(185, 575)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 34)
        Me.MetroButton1.TabIndex = 20
        Me.MetroButton1.Text = "NOUVEAU"
        Me.MetroButton1.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(397, 575)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 34)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MetroLink1)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.MetroLabel1)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(636, 67)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recherche rapide"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 360
        '
        'MetroLink1
        '
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.Location = New System.Drawing.Point(439, 32)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(119, 23)
        Me.MetroLink1.TabIndex = 3
        Me.MetroLink1.Text = "Tout afficher"
        Me.MetroLink1.UseSelectable = True
        '
        'ListeGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 627)
        Me.Controls.Add(Me.ListGeneration)
        Me.Controls.Add(Me.btnTriggerUpdate)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ListeGeneration"
        Me.Text = "GENERATION : LISTE / RAPPORT"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListGeneration As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnTriggerUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
End Class
