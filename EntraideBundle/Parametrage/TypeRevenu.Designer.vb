<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeRevenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeRevenu))
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btAdd = New MetroFramework.Controls.MetroButton()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.Location = New System.Drawing.Point(269, 162)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(114, 36)
        Me.MetroButton1.TabIndex = 7
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Location = New System.Drawing.Point(152, 162)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(111, 36)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "ENREGISTRER"
        Me.btAdd.UseSelectable = True
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
        Me.txtNom.Location = New System.Drawing.Point(185, 104)
        Me.txtNom.MaxLength = 32767
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNom.SelectedText = ""
        Me.txtNom.SelectionLength = 0
        Me.txtNom.SelectionStart = 0
        Me.txtNom.ShortcutsEnabled = True
        Me.txtNom.Size = New System.Drawing.Size(269, 30)
        Me.txtNom.TabIndex = 5
        Me.txtNom.UseSelectable = True
        Me.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(80, 110)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Nom du type : "
        '
        'TypeRevenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 237)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TypeRevenu"
        Me.Text = "TYPE REVENU : NOUVEAU"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
