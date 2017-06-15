<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeCodeDepense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeCodeDepense))
        Me.lb_msg = New MetroFramework.Controls.MetroLabel()
        Me.ListeCodesDepenses = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkAll = New MetroFramework.Controls.MetroCheckBox()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTriggerUpdate = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_msg
        '
        Me.lb_msg.AutoSize = True
        Me.lb_msg.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lb_msg.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lb_msg.Location = New System.Drawing.Point(549, 549)
        Me.lb_msg.Name = "lb_msg"
        Me.lb_msg.Size = New System.Drawing.Size(0, 0)
        Me.lb_msg.TabIndex = 8
        '
        'ListeCodesDepenses
        '
        Me.ListeCodesDepenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListeCodesDepenses.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeCodesDepenses.FullRowSelect = True
        Me.ListeCodesDepenses.GridLines = True
        Me.ListeCodesDepenses.Location = New System.Drawing.Point(24, 140)
        Me.ListeCodesDepenses.Name = "ListeCodesDepenses"
        Me.ListeCodesDepenses.Size = New System.Drawing.Size(737, 444)
        Me.ListeCodesDepenses.TabIndex = 3
        Me.ListeCodesDepenses.UseCompatibleStateImageBehavior = False
        Me.ListeCodesDepenses.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom"
        Me.ColumnHeader2.Width = 392
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Code dépense"
        Me.ColumnHeader3.Width = 336
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(427, 36)
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
        Me.txtSearch.Location = New System.Drawing.Point(142, 28)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 34)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Recherche rapide"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 71)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche rapide"
        '
        'btnTriggerUpdate
        '
        Me.btnTriggerUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTriggerUpdate.Location = New System.Drawing.Point(342, 590)
        Me.btnTriggerUpdate.Name = "btnTriggerUpdate"
        Me.btnTriggerUpdate.Size = New System.Drawing.Size(100, 34)
        Me.btnTriggerUpdate.TabIndex = 17
        Me.btnTriggerUpdate.Text = "MODIFIER"
        Me.btnTriggerUpdate.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(236, 590)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 34)
        Me.MetroButton1.TabIndex = 18
        Me.MetroButton1.Text = "NOUVEAU"
        Me.MetroButton1.UseSelectable = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(448, 590)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 34)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'ListeCodeDepense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 645)
        Me.Controls.Add(Me.btnTriggerUpdate)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lb_msg)
        Me.Controls.Add(Me.ListeCodesDepenses)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListeCodeDepense"
        Me.Text = "CODE DEPENSE : LISTE / RAPPORT"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_msg As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListeCodesDepenses As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkAll As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTriggerUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
End Class
