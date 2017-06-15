<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnToggleSidebar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.MessagesControl1 = New EntraideBundle.MessagesControl()
        Me.BunifuGradientPanel1 = New ns1.BunifuGradientPanel()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BunifuCards1 = New ns1.BunifuCards()
        Me.BunifuGauge1 = New ns1.BunifuGauge()
        Me.BunifuCircleProgressbar1 = New ns1.BunifuCircleProgressbar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelSidebar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSidebar
        '
        Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelSidebar.Controls.Add(Me.Panel3)
        Me.PanelSidebar.Controls.Add(Me.Panel2)
        Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New System.Drawing.Size(246, 603)
        Me.PanelSidebar.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(246, 452)
        Me.Panel3.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(0, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 56)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "USER PROFILE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnToggleSidebar)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(246, 54)
        Me.Panel2.TabIndex = 1
        '
        'btnToggleSidebar
        '
        Me.btnToggleSidebar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToggleSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnToggleSidebar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnToggleSidebar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnToggleSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleSidebar.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.btnToggleSidebar.ForeColor = System.Drawing.Color.White
        Me.btnToggleSidebar.Image = Global.EntraideBundle.My.Resources.Resources.ic_menu_white_48dp
        Me.btnToggleSidebar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnToggleSidebar.Location = New System.Drawing.Point(188, 6)
        Me.btnToggleSidebar.Name = "btnToggleSidebar"
        Me.btnToggleSidebar.Size = New System.Drawing.Size(48, 35)
        Me.btnToggleSidebar.TabIndex = 1
        Me.btnToggleSidebar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(1104, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 29)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(1171, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 29)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(1137, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 29)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "+"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PanelContainer.Controls.Add(Me.MessagesControl1)
        Me.PanelContainer.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelContainer.Controls.Add(Me.BunifuCards1)
        Me.PanelContainer.Controls.Add(Me.Panel4)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(246, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(965, 603)
        Me.PanelContainer.TabIndex = 3
        '
        'MessagesControl1
        '
        Me.MessagesControl1.BackColor = System.Drawing.Color.Transparent
        Me.MessagesControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MessagesControl1.Location = New System.Drawing.Point(515, 60)
        Me.MessagesControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MessagesControl1.Name = "MessagesControl1"
        Me.MessagesControl1.Size = New System.Drawing.Size(325, 1)
        Me.MessagesControl1.TabIndex = 6
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(383, 101)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(250, 234)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BunifuImageButton1.Location = New System.Drawing.Point(41, 29)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(75, 71)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.DodgerBlue
        Me.BunifuCards1.Controls.Add(Me.BunifuGauge1)
        Me.BunifuCards1.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(13, 101)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(364, 234)
        Me.BunifuCards1.TabIndex = 3
        '
        'BunifuGauge1
        '
        Me.BunifuGauge1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGauge1.BackgroundImage = CType(resources.GetObject("BunifuGauge1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGauge1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuGauge1.Location = New System.Drawing.Point(158, 47)
        Me.BunifuGauge1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuGauge1.Name = "BunifuGauge1"
        Me.BunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray
        Me.BunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen
        Me.BunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato
        Me.BunifuGauge1.Size = New System.Drawing.Size(186, 142)
        Me.BunifuGauge1.TabIndex = 5
        Me.BunifuGauge1.Thickness = 20
        Me.BunifuGauge1.Value = 20
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = False
        Me.BunifuCircleProgressbar1.animationIterval = 5
        Me.BunifuCircleProgressbar1.animationSpeed = 300
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 8
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(10, 47)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Blue
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(142, 142)
        Me.BunifuCircleProgressbar1.TabIndex = 1
        Me.BunifuCircleProgressbar1.Value = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Button15)
        Me.Panel4.Controls.Add(Me.Button14)
        Me.Panel4.Controls.Add(Me.Button13)
        Me.Panel4.Controls.Add(Me.btnMessage)
        Me.Panel4.Controls.Add(Me.Button11)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(965, 54)
        Me.Panel4.TabIndex = 2
        '
        'Button15
        '
        Me.Button15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Image = Global.EntraideBundle.My.Resources.Resources.ic_account_circle_grey600_24dp
        Me.Button15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button15.Location = New System.Drawing.Point(869, 2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(62, 53)
        Me.Button15.TabIndex = 8
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Image = Global.EntraideBundle.My.Resources.Resources.ic_build_grey600_24dp
        Me.Button14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button14.Location = New System.Drawing.Point(807, 2)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(62, 53)
        Me.Button14.TabIndex = 7
        Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Image = Global.EntraideBundle.My.Resources.Resources.ic_https_grey600_24dp
        Me.Button13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button13.Location = New System.Drawing.Point(745, 0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(62, 53)
        Me.Button13.TabIndex = 6
        Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button13.UseVisualStyleBackColor = False
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessage.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnMessage.ForeColor = System.Drawing.Color.Black
        Me.btnMessage.Image = Global.EntraideBundle.My.Resources.Resources.ic_mail_grey600_24dp
        Me.btnMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMessage.Location = New System.Drawing.Point(624, 1)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(100, 53)
        Me.btnMessage.TabIndex = 5
        Me.btnMessage.Text = "0"
        Me.btnMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button11.ForeColor = System.Drawing.Color.Green
        Me.Button11.Image = Global.EntraideBundle.My.Resources.Resources.ic_notifications_black_36dp
        Me.Button11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button11.Location = New System.Drawing.Point(524, 1)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 53)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "3"
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Image = Global.EntraideBundle.My.Resources.Resources.ic_domain_black_36dp
        Me.Button10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button10.Location = New System.Drawing.Point(424, 1)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 53)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "18"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.Red
        Me.Button9.Image = Global.EntraideBundle.My.Resources.Resources.ic_vpn_lock_grey600_48dp
        Me.Button9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button9.Location = New System.Drawing.Point(324, 1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 53)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "6"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N-SAT CONGO"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Orange
        Me.Button8.Image = Global.EntraideBundle.My.Resources.Resources.ic_event_note_grey600_36dp
        Me.Button8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button8.Location = New System.Drawing.Point(224, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 53)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "20"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 31)
        Me.Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PanelContainer)
        Me.Panel5.Controls.Add(Me.PanelSidebar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 31)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1211, 603)
        Me.Panel5.TabIndex = 4
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1211, 634)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelSidebar.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelSidebar As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents btnToggleSidebar As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents BunifuCards1 As ns1.BunifuCards
    Friend WithEvents BunifuCircleProgressbar1 As ns1.BunifuCircleProgressbar
    Friend WithEvents BunifuGauge1 As ns1.BunifuGauge
    Friend WithEvents BunifuGradientPanel1 As ns1.BunifuGradientPanel
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents MessagesControl1 As EntraideBundle.MessagesControl
End Class
