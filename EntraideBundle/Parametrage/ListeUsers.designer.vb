<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeUsers))
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.btnNouveau = New MetroFramework.Controls.MetroButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListUser = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnToogleStatus = New System.Windows.Forms.Button()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContainer.Controls.Add(Me.btnNouveau)
        Me.PanelContainer.Controls.Add(Me.Button1)
        Me.PanelContainer.Controls.Add(Me.ListUser)
        Me.PanelContainer.Controls.Add(Me.btnClose)
        Me.PanelContainer.Controls.Add(Me.btnToogleStatus)
        Me.PanelContainer.Location = New System.Drawing.Point(23, 68)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1063, 599)
        Me.PanelContainer.TabIndex = 0
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(927, 7)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(109, 32)
        Me.btnNouveau.TabIndex = 71
        Me.btnNouveau.Text = "NOUVEAU"
        Me.btnNouveau.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(475, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 40)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Afficher/Modifier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListUser
        '
        Me.ListUser.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListUser.AllowColumnReorder = True
        Me.ListUser.BackColor = System.Drawing.Color.White
        Me.ListUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListUser.FullRowSelect = True
        Me.ListUser.GridLines = True
        Me.ListUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListUser.Location = New System.Drawing.Point(41, 45)
        Me.ListUser.MultiSelect = False
        Me.ListUser.Name = "ListUser"
        Me.ListUser.Size = New System.Drawing.Size(995, 471)
        Me.ListUser.TabIndex = 49
        Me.ListUser.UseCompatibleStateImageBehavior = False
        Me.ListUser.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Employe"
        Me.ColumnHeader2.Width = 241
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nom d'utilisateur"
        Me.ColumnHeader3.Width = 205
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mot de passe"
        Me.ColumnHeader4.Width = 205
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 134
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Derniere connexion"
        Me.ColumnHeader6.Width = 187
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "status"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "pass"
        Me.ColumnHeader8.Width = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(626, 534)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 40)
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "Fermer"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnToogleStatus
        '
        Me.btnToogleStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnToogleStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToogleStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnToogleStatus.FlatAppearance.BorderSize = 2
        Me.btnToogleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToogleStatus.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToogleStatus.Image = CType(resources.GetObject("btnToogleStatus.Image"), System.Drawing.Image)
        Me.btnToogleStatus.Location = New System.Drawing.Point(328, 534)
        Me.btnToogleStatus.Name = "btnToogleStatus"
        Me.btnToogleStatus.Size = New System.Drawing.Size(143, 40)
        Me.btnToogleStatus.TabIndex = 46
        Me.btnToogleStatus.Text = "Changer status"
        Me.btnToogleStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnToogleStatus.UseVisualStyleBackColor = False
        '
        'ListeUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 689)
        Me.Controls.Add(Me.PanelContainer)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListeUsers"
        Me.Padding = New System.Windows.Forms.Padding(20, 57, 20, 19)
        Me.Text = "UTILISATEURS: LISTE / RAPPORT"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnToogleStatus As System.Windows.Forms.Button
    Friend WithEvents ListUser As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNouveau As MetroFramework.Controls.MetroButton
End Class
