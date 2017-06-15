<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeFormation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeFormation))
        Me.btAdd = New MetroFramework.Controls.MetroButton()
        Me.txtMontant = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(161, 189)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(100, 34)
        Me.btAdd.TabIndex = 3
        Me.btAdd.Text = "ENREGISTRER"
        Me.btAdd.UseSelectable = True
        '
        'txtMontant
        '
        '
        '
        '
        Me.txtMontant.CustomButton.Image = Nothing
        Me.txtMontant.CustomButton.Location = New System.Drawing.Point(241, 2)
        Me.txtMontant.CustomButton.Name = ""
        Me.txtMontant.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMontant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMontant.CustomButton.TabIndex = 1
        Me.txtMontant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMontant.CustomButton.UseSelectable = True
        Me.txtMontant.CustomButton.Visible = False
        Me.txtMontant.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMontant.Lines = New String(-1) {}
        Me.txtMontant.Location = New System.Drawing.Point(213, 130)
        Me.txtMontant.MaxLength = 32767
        Me.txtMontant.Name = "txtMontant"
        Me.txtMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontant.SelectedText = ""
        Me.txtMontant.SelectionLength = 0
        Me.txtMontant.SelectionStart = 0
        Me.txtMontant.ShortcutsEnabled = True
        Me.txtMontant.Size = New System.Drawing.Size(269, 30)
        Me.txtMontant.TabIndex = 2
        Me.txtMontant.UseSelectable = True
        Me.txtMontant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMontant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(46, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(160, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Montant de la formation"
        '
        'txtNom
        '
        '
        '
        '
        Me.txtNom.CustomButton.Image = Nothing
        Me.txtNom.CustomButton.Location = New System.Drawing.Point(241, 2)
        Me.txtNom.CustomButton.Name = ""
        Me.txtNom.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNom.CustomButton.TabIndex = 1
        Me.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNom.CustomButton.UseSelectable = True
        Me.txtNom.CustomButton.Visible = False
        Me.txtNom.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNom.Lines = New String(-1) {}
        Me.txtNom.Location = New System.Drawing.Point(213, 89)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(269, 30)
        Me.txtNom.TabIndex = 1
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(46, 95)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(137, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nom de la formation"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(267, 189)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 34)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'TypeFormation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 257)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtMontant)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TypeFormation"
        Me.Resizable = False
        Me.Text = "TYPE DE FORMATION : NOUVEAU"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtMontant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
