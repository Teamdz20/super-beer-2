<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseSetup
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseSetup))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelProgress.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(490, 304)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 35)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "ANNULER"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNext.Location = New System.Drawing.Point(375, 304)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(109, 35)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(101, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 65)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATABASE SETUP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MYSQL SERVER ADRESS : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MYSQL SERVER USER : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "MYSQL SERVER PASSWORD : "
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(282, 122)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(316, 29)
        Me.txtServer.TabIndex = 3
        Me.txtServer.Text = "127.0.0.1"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(282, 168)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(316, 29)
        Me.txtUser.TabIndex = 3
        Me.txtUser.Text = "root"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(282, 215)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(316, 29)
        Me.txtPass.TabIndex = 3
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(12, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "powered by ksprogramming © 2017 all rights reserved"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(111, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(316, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Location = New System.Drawing.Point(7, 6)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(36, 21)
        Me.labelTotal.TabIndex = 6
        Me.labelTotal.Text = "0 %"
        '
        'PanelProgress
        '
        Me.PanelProgress.Controls.Add(Me.ProgressBar1)
        Me.PanelProgress.Controls.Add(Me.labelTotal)
        Me.PanelProgress.Location = New System.Drawing.Point(165, 259)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(434, 32)
        Me.PanelProgress.TabIndex = 7
        Me.PanelProgress.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(635, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "DUMP"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'DatabaseSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 354)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelProgress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DatabaseSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseSetup"
        Me.PanelProgress.ResumeLayout(False)
        Me.PanelProgress.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents labelTotal As System.Windows.Forms.Label
    Friend WithEvents PanelProgress As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChangeSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
