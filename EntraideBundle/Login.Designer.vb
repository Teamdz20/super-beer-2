<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PanelContainer = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.MetroButton2)
        Me.PanelContainer.Controls.Add(Me.MetroButton1)
        Me.PanelContainer.Controls.Add(Me.txtPass)
        Me.PanelContainer.Controls.Add(Me.txtUsername)
        Me.PanelContainer.Controls.Add(Me.PictureBox1)
        Me.PanelContainer.HorizontalScrollbarBarColor = True
        Me.PanelContainer.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelContainer.HorizontalScrollbarSize = 10
        Me.PanelContainer.Location = New System.Drawing.Point(92, 122)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(493, 419)
        Me.PanelContainer.TabIndex = 0
        Me.PanelContainer.VerticalScrollbarBarColor = True
        Me.PanelContainer.VerticalScrollbarHighlightOnWheel = False
        Me.PanelContainer.VerticalScrollbarSize = 10
        '
        'MetroButton2
        '
        Me.MetroButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton2.Location = New System.Drawing.Point(100, 356)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(143, 39)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "CONNEXION"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.Location = New System.Drawing.Point(248, 356)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(143, 39)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "FERMER"
        Me.MetroButton1.UseSelectable = True
        '
        'txtPass
        '
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(383, 2)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(40, 317)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.PromptText = "Mot de passe ....."
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.ShowButton = True
        Me.txtPass.ShowClearButton = True
        Me.txtPass.Size = New System.Drawing.Size(411, 30)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WaterMark = "Mot de passe ....."
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(383, 2)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(41, 276)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PromptText = "Nom d'utilisateur ..."
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.ShowButton = True
        Me.txtUsername.ShowClearButton = True
        Me.txtUsername.Size = New System.Drawing.Size(411, 30)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "Nom d'utilisateur ..."
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ChangeSettingsToolStripMenuItem
        '
        Me.ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem"
        Me.ChangeSettingsToolStripMenuItem.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ChangeSettingsToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.ChangeSettingsToolStripMenuItem.Text = "Change settings"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 629)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelContainer As MetroFramework.Controls.MetroPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChangeSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
