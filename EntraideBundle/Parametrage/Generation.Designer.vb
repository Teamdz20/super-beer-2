<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generation))
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btAdd = New MetroFramework.Controls.MetroButton()
        Me.txtLibelle = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(293, 205)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 36)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Location = New System.Drawing.Point(173, 205)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(114, 36)
        Me.btAdd.TabIndex = 3
        Me.btAdd.Text = "ENREGISTRER"
        Me.btAdd.UseSelectable = True
        '
        'txtLibelle
        '
        '
        '
        '
        Me.txtLibelle.CustomButton.Image = Nothing
        Me.txtLibelle.CustomButton.Location = New System.Drawing.Point(275, 2)
        Me.txtLibelle.CustomButton.Name = ""
        Me.txtLibelle.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtLibelle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLibelle.CustomButton.TabIndex = 1
        Me.txtLibelle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLibelle.CustomButton.UseSelectable = True
        Me.txtLibelle.CustomButton.Visible = False
        Me.txtLibelle.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLibelle.Lines = New String(-1) {}
        Me.txtLibelle.Location = New System.Drawing.Point(173, 81)
        Me.txtLibelle.MaxLength = 32767
        Me.txtLibelle.Name = "txtLibelle"
        Me.txtLibelle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLibelle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLibelle.SelectedText = ""
        Me.txtLibelle.SelectionLength = 0
        Me.txtLibelle.SelectionStart = 0
        Me.txtLibelle.ShortcutsEnabled = True
        Me.txtLibelle.Size = New System.Drawing.Size(303, 30)
        Me.txtLibelle.TabIndex = 1
        Me.txtLibelle.UseSelectable = True
        Me.txtLibelle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLibelle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(73, 92)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Libellé :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(73, 138)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Description :"
        '
        'txtDescription
        '
        '
        '
        '
        Me.txtDescription.CustomButton.Image = Nothing
        Me.txtDescription.CustomButton.Location = New System.Drawing.Point(247, 1)
        Me.txtDescription.CustomButton.Name = ""
        Me.txtDescription.CustomButton.Size = New System.Drawing.Size(55, 55)
        Me.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescription.CustomButton.TabIndex = 1
        Me.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescription.CustomButton.UseSelectable = True
        Me.txtDescription.CustomButton.Visible = False
        Me.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDescription.Lines = New String(-1) {}
        Me.txtDescription.Location = New System.Drawing.Point(173, 127)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.ShortcutsEnabled = True
        Me.txtDescription.Size = New System.Drawing.Size(303, 57)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.UseSelectable = True
        Me.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Generation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 276)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtLibelle)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Generation"
        Me.Text = "GENERATION : NOUVEAU"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtLibelle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
End Class
