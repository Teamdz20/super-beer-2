<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportOrganisation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RapportOrganisation))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabEntete = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextEntete = New System.Windows.Forms.RichTextBox()
        Me.TabMission = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextMission = New System.Windows.Forms.RichTextBox()
        Me.TabVision = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextVision = New System.Windows.Forms.RichTextBox()
        Me.TabValeur = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextValeur = New System.Windows.Forms.RichTextBox()
        Me.TabOrganigramme = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextOrganigramme = New System.Windows.Forms.RichTextBox()
        Me.TabHistoire = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextHistoire = New System.Windows.Forms.RichTextBox()
        Me.TabBranche = New MetroFramework.Controls.MetroTabPage()
        Me.RichTextBranche = New System.Windows.Forms.RichTextBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnOpen = New System.Windows.Forms.ToolStripButton()
        Me.EnregistrerToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnRedo = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tscmbFont = New System.Windows.Forms.ToolStripComboBox()
        Me.tscmbFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCut = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBold = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnItalic = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnUnderline = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAlignRight = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAlignCenter = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAlignLeft = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFontColor = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnIncreaseFontSize = New System.Windows.Forms.ToolStripButton()
        Me.btnDecreaseFontSize = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBullets = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDecreaseIndentation = New System.Windows.Forms.ToolStripButton()
        Me.btnIncreaseIndentation = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnInsertPicture = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabEntete.SuspendLayout()
        Me.TabMission.SuspendLayout()
        Me.TabVision.SuspendLayout()
        Me.TabValeur.SuspendLayout()
        Me.TabOrganigramme.SuspendLayout()
        Me.TabHistoire.SuspendLayout()
        Me.TabBranche.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabEntete)
        Me.MetroTabControl1.Controls.Add(Me.TabMission)
        Me.MetroTabControl1.Controls.Add(Me.TabVision)
        Me.MetroTabControl1.Controls.Add(Me.TabValeur)
        Me.MetroTabControl1.Controls.Add(Me.TabOrganigramme)
        Me.MetroTabControl1.Controls.Add(Me.TabHistoire)
        Me.MetroTabControl1.Controls.Add(Me.TabBranche)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1201, 559)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabEntete
        '
        Me.TabEntete.BackColor = System.Drawing.Color.Transparent
        Me.TabEntete.Controls.Add(Me.RichTextEntete)
        Me.TabEntete.HorizontalScrollbarBarColor = True
        Me.TabEntete.HorizontalScrollbarHighlightOnWheel = False
        Me.TabEntete.HorizontalScrollbarSize = 10
        Me.TabEntete.Location = New System.Drawing.Point(4, 38)
        Me.TabEntete.Name = "TabEntete"
        Me.TabEntete.Size = New System.Drawing.Size(1193, 517)
        Me.TabEntete.TabIndex = 0
        Me.TabEntete.Text = "ENTETE   "
        Me.TabEntete.VerticalScrollbarBarColor = True
        Me.TabEntete.VerticalScrollbarHighlightOnWheel = False
        Me.TabEntete.VerticalScrollbarSize = 10
        '
        'RichTextEntete
        '
        Me.RichTextEntete.AcceptsTab = True
        Me.RichTextEntete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextEntete.EnableAutoDragDrop = True
        Me.RichTextEntete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextEntete.Location = New System.Drawing.Point(0, 0)
        Me.RichTextEntete.Name = "RichTextEntete"
        Me.RichTextEntete.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextEntete.TabIndex = 2
        Me.RichTextEntete.Text = ""
        '
        'TabMission
        '
        Me.TabMission.BackColor = System.Drawing.Color.Transparent
        Me.TabMission.Controls.Add(Me.RichTextMission)
        Me.TabMission.HorizontalScrollbarBarColor = True
        Me.TabMission.HorizontalScrollbarHighlightOnWheel = False
        Me.TabMission.HorizontalScrollbarSize = 10
        Me.TabMission.Location = New System.Drawing.Point(4, 38)
        Me.TabMission.Name = "TabMission"
        Me.TabMission.Size = New System.Drawing.Size(1193, 517)
        Me.TabMission.TabIndex = 1
        Me.TabMission.Text = "MISSION    "
        Me.TabMission.VerticalScrollbarBarColor = True
        Me.TabMission.VerticalScrollbarHighlightOnWheel = False
        Me.TabMission.VerticalScrollbarSize = 10
        '
        'RichTextMission
        '
        Me.RichTextMission.AcceptsTab = True
        Me.RichTextMission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextMission.EnableAutoDragDrop = True
        Me.RichTextMission.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextMission.Location = New System.Drawing.Point(0, 0)
        Me.RichTextMission.Name = "RichTextMission"
        Me.RichTextMission.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextMission.TabIndex = 3
        Me.RichTextMission.Text = ""
        '
        'TabVision
        '
        Me.TabVision.BackColor = System.Drawing.Color.Transparent
        Me.TabVision.Controls.Add(Me.RichTextVision)
        Me.TabVision.HorizontalScrollbarBarColor = True
        Me.TabVision.HorizontalScrollbarHighlightOnWheel = False
        Me.TabVision.HorizontalScrollbarSize = 10
        Me.TabVision.Location = New System.Drawing.Point(4, 38)
        Me.TabVision.Name = "TabVision"
        Me.TabVision.Size = New System.Drawing.Size(1193, 517)
        Me.TabVision.TabIndex = 2
        Me.TabVision.Text = "VISION    "
        Me.TabVision.VerticalScrollbarBarColor = True
        Me.TabVision.VerticalScrollbarHighlightOnWheel = False
        Me.TabVision.VerticalScrollbarSize = 10
        '
        'RichTextVision
        '
        Me.RichTextVision.AcceptsTab = True
        Me.RichTextVision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextVision.EnableAutoDragDrop = True
        Me.RichTextVision.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextVision.Location = New System.Drawing.Point(0, 0)
        Me.RichTextVision.Name = "RichTextVision"
        Me.RichTextVision.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextVision.TabIndex = 3
        Me.RichTextVision.Text = ""
        '
        'TabValeur
        '
        Me.TabValeur.BackColor = System.Drawing.Color.Transparent
        Me.TabValeur.Controls.Add(Me.RichTextValeur)
        Me.TabValeur.HorizontalScrollbarBarColor = True
        Me.TabValeur.HorizontalScrollbarHighlightOnWheel = False
        Me.TabValeur.HorizontalScrollbarSize = 10
        Me.TabValeur.Location = New System.Drawing.Point(4, 38)
        Me.TabValeur.Name = "TabValeur"
        Me.TabValeur.Size = New System.Drawing.Size(1193, 517)
        Me.TabValeur.TabIndex = 3
        Me.TabValeur.Text = "VALEURS    "
        Me.TabValeur.VerticalScrollbarBarColor = True
        Me.TabValeur.VerticalScrollbarHighlightOnWheel = False
        Me.TabValeur.VerticalScrollbarSize = 10
        '
        'RichTextValeur
        '
        Me.RichTextValeur.AcceptsTab = True
        Me.RichTextValeur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextValeur.EnableAutoDragDrop = True
        Me.RichTextValeur.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextValeur.Location = New System.Drawing.Point(0, 0)
        Me.RichTextValeur.Name = "RichTextValeur"
        Me.RichTextValeur.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextValeur.TabIndex = 3
        Me.RichTextValeur.Text = ""
        '
        'TabOrganigramme
        '
        Me.TabOrganigramme.BackColor = System.Drawing.Color.Transparent
        Me.TabOrganigramme.Controls.Add(Me.RichTextOrganigramme)
        Me.TabOrganigramme.HorizontalScrollbarBarColor = True
        Me.TabOrganigramme.HorizontalScrollbarHighlightOnWheel = False
        Me.TabOrganigramme.HorizontalScrollbarSize = 10
        Me.TabOrganigramme.Location = New System.Drawing.Point(4, 38)
        Me.TabOrganigramme.Name = "TabOrganigramme"
        Me.TabOrganigramme.Size = New System.Drawing.Size(1193, 517)
        Me.TabOrganigramme.TabIndex = 4
        Me.TabOrganigramme.Text = "ORGANIGRAMME    "
        Me.TabOrganigramme.VerticalScrollbarBarColor = True
        Me.TabOrganigramme.VerticalScrollbarHighlightOnWheel = False
        Me.TabOrganigramme.VerticalScrollbarSize = 10
        '
        'RichTextOrganigramme
        '
        Me.RichTextOrganigramme.AcceptsTab = True
        Me.RichTextOrganigramme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextOrganigramme.EnableAutoDragDrop = True
        Me.RichTextOrganigramme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextOrganigramme.Location = New System.Drawing.Point(0, 0)
        Me.RichTextOrganigramme.Name = "RichTextOrganigramme"
        Me.RichTextOrganigramme.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextOrganigramme.TabIndex = 3
        Me.RichTextOrganigramme.Text = ""
        '
        'TabHistoire
        '
        Me.TabHistoire.BackColor = System.Drawing.Color.Transparent
        Me.TabHistoire.Controls.Add(Me.RichTextHistoire)
        Me.TabHistoire.HorizontalScrollbarBarColor = True
        Me.TabHistoire.HorizontalScrollbarHighlightOnWheel = False
        Me.TabHistoire.HorizontalScrollbarSize = 10
        Me.TabHistoire.Location = New System.Drawing.Point(4, 38)
        Me.TabHistoire.Name = "TabHistoire"
        Me.TabHistoire.Size = New System.Drawing.Size(1193, 517)
        Me.TabHistoire.TabIndex = 5
        Me.TabHistoire.Text = "HISTOIRE    "
        Me.TabHistoire.VerticalScrollbarBarColor = True
        Me.TabHistoire.VerticalScrollbarHighlightOnWheel = False
        Me.TabHistoire.VerticalScrollbarSize = 10
        '
        'RichTextHistoire
        '
        Me.RichTextHistoire.AcceptsTab = True
        Me.RichTextHistoire.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextHistoire.EnableAutoDragDrop = True
        Me.RichTextHistoire.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextHistoire.Location = New System.Drawing.Point(0, 0)
        Me.RichTextHistoire.Name = "RichTextHistoire"
        Me.RichTextHistoire.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextHistoire.TabIndex = 3
        Me.RichTextHistoire.Text = ""
        '
        'TabBranche
        '
        Me.TabBranche.BackColor = System.Drawing.Color.Transparent
        Me.TabBranche.Controls.Add(Me.RichTextBranche)
        Me.TabBranche.HorizontalScrollbarBarColor = True
        Me.TabBranche.HorizontalScrollbarHighlightOnWheel = False
        Me.TabBranche.HorizontalScrollbarSize = 10
        Me.TabBranche.Location = New System.Drawing.Point(4, 38)
        Me.TabBranche.Name = "TabBranche"
        Me.TabBranche.Size = New System.Drawing.Size(1193, 517)
        Me.TabBranche.TabIndex = 6
        Me.TabBranche.Text = "BRANCHE   "
        Me.TabBranche.VerticalScrollbarBarColor = True
        Me.TabBranche.VerticalScrollbarHighlightOnWheel = False
        Me.TabBranche.VerticalScrollbarSize = 10
        '
        'RichTextBranche
        '
        Me.RichTextBranche.AcceptsTab = True
        Me.RichTextBranche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBranche.EnableAutoDragDrop = True
        Me.RichTextBranche.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBranche.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBranche.Name = "RichTextBranche"
        Me.RichTextBranche.Size = New System.Drawing.Size(1193, 517)
        Me.RichTextBranche.TabIndex = 3
        Me.RichTextBranche.Text = ""
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(539, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 36)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "FERMER"
        Me.btnClose.UseSelectable = True
        '
        'toolStrip
        '
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel2, Me.toolStripSeparator1, Me.tsbtnOpen, Me.EnregistrerToolStripButton, Me.toolStripSeparator, Me.btnUndo, Me.btnRedo, Me.toolStripSeparator3, Me.tscmbFont, Me.tscmbFontSize, Me.ToolStripSeparator2, Me.btnCut, Me.btnCopy, Me.btnPaste, Me.toolStripSeparator4, Me.tsbtnBold, Me.tsbtnItalic, Me.ToolStripSeparator9, Me.tsbtnUnderline, Me.tsbtnAlignRight, Me.tsbtnAlignCenter, Me.tsbtnAlignLeft, Me.ToolStripSeparator10, Me.tsbtnFontColor, Me.toolStripSeparator5, Me.btnIncreaseFontSize, Me.btnDecreaseFontSize, Me.toolStripSeparator6, Me.tsbtnBullets, Me.toolStripSeparator7, Me.btnDecreaseIndentation, Me.btnIncreaseIndentation, Me.toolStripSeparator8, Me.tsbtnInsertPicture})
        Me.toolStrip.Location = New System.Drawing.Point(20, 60)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(1207, 25)
        Me.toolStrip.TabIndex = 4
        Me.toolStrip.Text = "toolStrip"
        '
        'toolStripLabel2
        '
        Me.toolStripLabel2.Name = "toolStripLabel2"
        Me.toolStripLabel2.Size = New System.Drawing.Size(53, 22)
        Me.toolStripLabel2.Text = "Controle"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnOpen
        '
        Me.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnOpen.Image = CType(resources.GetObject("tsbtnOpen.Image"), System.Drawing.Image)
        Me.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOpen.Name = "tsbtnOpen"
        Me.tsbtnOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnOpen.Text = "&Ouvrir"
        '
        'EnregistrerToolStripButton
        '
        Me.EnregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnregistrerToolStripButton.Image = CType(resources.GetObject("EnregistrerToolStripButton.Image"), System.Drawing.Image)
        Me.EnregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EnregistrerToolStripButton.Name = "EnregistrerToolStripButton"
        Me.EnregistrerToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EnregistrerToolStripButton.Text = "&Enregistrer"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(23, 22)
        Me.btnUndo.Text = "toolStripButton1"
        Me.btnUndo.ToolTipText = "Annuler"
        '
        'btnRedo
        '
        Me.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
        Me.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(23, 22)
        Me.btnRedo.Text = "toolStripButton1"
        Me.btnRedo.ToolTipText = "Retablir"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tscmbFont
        '
        Me.tscmbFont.Name = "tscmbFont"
        Me.tscmbFont.Size = New System.Drawing.Size(180, 25)
        '
        'tscmbFontSize
        '
        Me.tscmbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.tscmbFontSize.Name = "tscmbFontSize"
        Me.tscmbFontSize.Size = New System.Drawing.Size(75, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCut
        '
        Me.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCut.Image = CType(resources.GetObject("btnCut.Image"), System.Drawing.Image)
        Me.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(23, 22)
        Me.btnCut.Text = "X"
        Me.btnCut.ToolTipText = "Couper"
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "C"
        Me.btnCopy.ToolTipText = "Copier"
        '
        'btnPaste
        '
        Me.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(23, 22)
        Me.btnPaste.Text = "V"
        Me.btnPaste.ToolTipText = "Coller"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnBold
        '
        Me.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnBold.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsbtnBold.Image = CType(resources.GetObject("tsbtnBold.Image"), System.Drawing.Image)
        Me.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBold.Name = "tsbtnBold"
        Me.tsbtnBold.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnBold.Text = "B"
        Me.tsbtnBold.ToolTipText = "Gras"
        '
        'tsbtnItalic
        '
        Me.tsbtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnItalic.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsbtnItalic.Image = CType(resources.GetObject("tsbtnItalic.Image"), System.Drawing.Image)
        Me.tsbtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnItalic.Name = "tsbtnItalic"
        Me.tsbtnItalic.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnItalic.Text = "I"
        Me.tsbtnItalic.ToolTipText = "Italique"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnUnderline
        '
        Me.tsbtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUnderline.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsbtnUnderline.Image = CType(resources.GetObject("tsbtnUnderline.Image"), System.Drawing.Image)
        Me.tsbtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUnderline.Name = "tsbtnUnderline"
        Me.tsbtnUnderline.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnUnderline.Text = "U"
        Me.tsbtnUnderline.ToolTipText = "Souligner"
        '
        'tsbtnAlignRight
        '
        Me.tsbtnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAlignRight.Image = CType(resources.GetObject("tsbtnAlignRight.Image"), System.Drawing.Image)
        Me.tsbtnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAlignRight.Name = "tsbtnAlignRight"
        Me.tsbtnAlignRight.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnAlignRight.Text = "toolStripButton1"
        Me.tsbtnAlignRight.ToolTipText = "Aligner le texte a gauche"
        '
        'tsbtnAlignCenter
        '
        Me.tsbtnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAlignCenter.Image = CType(resources.GetObject("tsbtnAlignCenter.Image"), System.Drawing.Image)
        Me.tsbtnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAlignCenter.Name = "tsbtnAlignCenter"
        Me.tsbtnAlignCenter.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnAlignCenter.Text = "toolStripButton1"
        Me.tsbtnAlignCenter.ToolTipText = "Aligner le texte centre"
        '
        'tsbtnAlignLeft
        '
        Me.tsbtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAlignLeft.Image = CType(resources.GetObject("tsbtnAlignLeft.Image"), System.Drawing.Image)
        Me.tsbtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAlignLeft.Name = "tsbtnAlignLeft"
        Me.tsbtnAlignLeft.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnAlignLeft.Text = "toolStripButton1"
        Me.tsbtnAlignLeft.ToolTipText = "Aligner le texte a droite"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnFontColor
        '
        Me.tsbtnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnFontColor.Image = CType(resources.GetObject("tsbtnFontColor.Image"), System.Drawing.Image)
        Me.tsbtnFontColor.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsbtnFontColor.Name = "tsbtnFontColor"
        Me.tsbtnFontColor.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnFontColor.Text = "toolStripButton4"
        Me.tsbtnFontColor.ToolTipText = "Pick Font Color"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnIncreaseFontSize
        '
        Me.btnIncreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIncreaseFontSize.Image = CType(resources.GetObject("btnIncreaseFontSize.Image"), System.Drawing.Image)
        Me.btnIncreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncreaseFontSize.Name = "btnIncreaseFontSize"
        Me.btnIncreaseFontSize.Size = New System.Drawing.Size(23, 22)
        Me.btnIncreaseFontSize.Text = "toolStripButton1"
        Me.btnIncreaseFontSize.ToolTipText = "Augmenter la police"
        '
        'btnDecreaseFontSize
        '
        Me.btnDecreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDecreaseFontSize.Image = CType(resources.GetObject("btnDecreaseFontSize.Image"), System.Drawing.Image)
        Me.btnDecreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDecreaseFontSize.Name = "btnDecreaseFontSize"
        Me.btnDecreaseFontSize.Size = New System.Drawing.Size(23, 22)
        Me.btnDecreaseFontSize.Text = "toolStripButton1"
        Me.btnDecreaseFontSize.ToolTipText = "Reduire la police"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnBullets
        '
        Me.tsbtnBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBullets.Image = CType(resources.GetObject("tsbtnBullets.Image"), System.Drawing.Image)
        Me.tsbtnBullets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBullets.Name = "tsbtnBullets"
        Me.tsbtnBullets.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnBullets.Text = "toolStripButton1"
        Me.tsbtnBullets.ToolTipText = "Demarrer une liste"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btnDecreaseIndentation
        '
        Me.btnDecreaseIndentation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDecreaseIndentation.Image = CType(resources.GetObject("btnDecreaseIndentation.Image"), System.Drawing.Image)
        Me.btnDecreaseIndentation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDecreaseIndentation.Name = "btnDecreaseIndentation"
        Me.btnDecreaseIndentation.Size = New System.Drawing.Size(23, 22)
        Me.btnDecreaseIndentation.Text = "toolStripButton1"
        Me.btnDecreaseIndentation.ToolTipText = "Reduire le retrait"
        '
        'btnIncreaseIndentation
        '
        Me.btnIncreaseIndentation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIncreaseIndentation.Image = CType(resources.GetObject("btnIncreaseIndentation.Image"), System.Drawing.Image)
        Me.btnIncreaseIndentation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncreaseIndentation.Name = "btnIncreaseIndentation"
        Me.btnIncreaseIndentation.Size = New System.Drawing.Size(23, 22)
        Me.btnIncreaseIndentation.Text = "toolStripButton1"
        Me.btnIncreaseIndentation.ToolTipText = "Augmenter le retrait"
        '
        'toolStripSeparator8
        '
        Me.toolStripSeparator8.Name = "toolStripSeparator8"
        Me.toolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnInsertPicture
        '
        Me.tsbtnInsertPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnInsertPicture.Image = CType(resources.GetObject("tsbtnInsertPicture.Image"), System.Drawing.Image)
        Me.tsbtnInsertPicture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnInsertPicture.Name = "tsbtnInsertPicture"
        Me.tsbtnInsertPicture.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnInsertPicture.Text = "ToolStripButton1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 85)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.62661!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37339!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1207, 638)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroTabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1201, 559)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 568)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1201, 67)
        Me.Panel2.TabIndex = 1
        '
        'RapportOrganisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 743)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.toolStrip)
        Me.Name = "RapportOrganisation"
        Me.Text = "ORGANISATION"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabEntete.ResumeLayout(False)
        Me.TabMission.ResumeLayout(False)
        Me.TabVision.ResumeLayout(False)
        Me.TabValeur.ResumeLayout(False)
        Me.TabOrganigramme.ResumeLayout(False)
        Me.TabHistoire.ResumeLayout(False)
        Me.TabBranche.ResumeLayout(False)
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabEntete As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabMission As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabVision As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabValeur As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabOrganigramme As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabHistoire As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabBranche As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Private WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Private WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Private WithEvents btnRedo As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnCut As System.Windows.Forms.ToolStripButton
    Private WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Private WithEvents btnPaste As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbtnBold As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbtnItalic As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbtnUnderline As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnIncreaseFontSize As System.Windows.Forms.ToolStripButton
    Private WithEvents btnDecreaseFontSize As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbtnBullets As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnDecreaseIndentation As System.Windows.Forms.ToolStripButton
    Private WithEvents btnIncreaseIndentation As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbtnAlignLeft As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbtnAlignCenter As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbtnAlignRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents EnregistrerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RichTextEntete As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextMission As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextVision As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextValeur As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextOrganigramme As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextHistoire As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBranche As System.Windows.Forms.RichTextBox
    Friend WithEvents tscmbFont As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tscmbFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnInsertPicture As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbtnFontColor As System.Windows.Forms.ToolStripButton
End Class
