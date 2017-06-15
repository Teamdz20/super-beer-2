<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeDepense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeDepense))
        Me.btAdd = New MetroFramework.Controls.MetroButton()
        Me.txtCode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNom = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Location = New System.Drawing.Point(157, 173)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(114, 36)
        Me.btAdd.TabIndex = 3
        Me.btAdd.Text = "ENREGISTRER"
        Me.btAdd.UseSelectable = True
        '
        'txtCode
        '
        '
        '
        '
        Me.txtCode.CustomButton.Image = Nothing
        Me.txtCode.CustomButton.Location = New System.Drawing.Point(241, 2)
        Me.txtCode.CustomButton.Name = ""
        Me.txtCode.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCode.CustomButton.TabIndex = 1
        Me.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCode.CustomButton.UseSelectable = True
        Me.txtCode.CustomButton.Visible = False
        Me.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCode.Lines = New String(-1) {}
        Me.txtCode.Location = New System.Drawing.Point(226, 122)
        Me.txtCode.MaxLength = 32767
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCode.SelectedText = ""
        Me.txtCode.SelectionLength = 0
        Me.txtCode.SelectionStart = 0
        Me.txtCode.ShortcutsEnabled = True
        Me.txtCode.Size = New System.Drawing.Size(269, 30)
        Me.txtCode.TabIndex = 2
        Me.txtCode.UseSelectable = True
        Me.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(54, 128)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Code de la dépense"
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
        Me.txtNom.Location = New System.Drawing.Point(226, 87)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(54, 93)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nom de la dépense"
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(277, 173)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 36)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'CodeDepense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 245)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtNom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CodeDepense"
        Me.Text = "CODE DEPENSE : NOUVEAU CODE DEPENSE"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
End Class
