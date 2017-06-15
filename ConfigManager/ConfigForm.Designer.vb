<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigForm))
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDbName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckDebug = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(265, 134)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(348, 29)
        Me.txtPass.TabIndex = 7
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(265, 87)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(348, 29)
        Me.txtUser.TabIndex = 8
        Me.txtUser.Text = "root"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(265, 41)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(348, 29)
        Me.txtServer.TabIndex = 9
        Me.txtServer.Text = "127.0.0.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MYSQL SERVER PASSWORD : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MYSQL SERVER USER : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MYSQL SERVER ADRESS : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MASTER DB NAME : "
        '
        'txtDbName
        '
        Me.txtDbName.Location = New System.Drawing.Point(265, 179)
        Me.txtDbName.Name = "txtDbName"
        Me.txtDbName.Size = New System.Drawing.Size(348, 29)
        Me.txtDbName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DEBUG MODE : "
        '
        'ckDebug
        '
        Me.ckDebug.AutoSize = True
        Me.ckDebug.Location = New System.Drawing.Point(265, 235)
        Me.ckDebug.Name = "ckDebug"
        Me.ckDebug.Size = New System.Drawing.Size(15, 14)
        Me.ckDebug.TabIndex = 10
        Me.ckDebug.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNext.Location = New System.Drawing.Point(389, 269)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(109, 35)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(504, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 35)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "ANNULER"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 314)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ckDebug)
        Me.Controls.Add(Me.txtDbName)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfigForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDbName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckDebug As System.Windows.Forms.CheckBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
