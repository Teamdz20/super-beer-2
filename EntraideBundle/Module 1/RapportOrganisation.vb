Imports MySql.Data.MySqlClient
Imports System.Text
Imports EntraideBundle.Db

Public Class RapportOrganisation

    Private rtbDocument As RichTextBox


    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rtbDocument = Me.RichTextEntete
    End Sub

    Sub Initialize()
        For Each family As FontFamily In FontFamily.Families
            tscmbFont.Items.Add(family.Name)
        Next
        tscmbFont.SelectedItem = "Calibri"

        tscmbFontSize.SelectedItem = "12"

        Dim richTexts() As RichTextBox = {RichTextEntete, RichTextMission, RichTextVision, RichTextValeur, RichTextOrganigramme, RichTextHistoire, RichTextBranche}
        For Each elem As RichTextBox In richTexts
            AddHandler elem.SelectionChanged, AddressOf rtbDocument_SelectionChanged
        Next

    End Sub

    Sub PreloadFields()
        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            cmd.CommandText = "SELECT entete, mission, vision, valeur, organigramme, histoire, branche FROM organisations"

            Dim entete() As Byte = Nothing
            Dim mission() As Byte = Nothing
            Dim vision() As Byte = Nothing
            Dim valeur() As Byte = Nothing
            Dim organigramme() As Byte = Nothing
            Dim histoire() As Byte = Nothing
            Dim branche() As Byte = Nothing

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read
                entete = result("entete")
                mission = result("mission")
                vision = result("vision")
                valeur = result("valeur")
                organigramme = result("organigramme")
                histoire = result("histoire")
                branche = result("branche")
            End While

            result.Close()

            If Not IsNothing(entete) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(entete)
                    RichTextEntete.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

            If Not IsNothing(mission) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(mission)
                    RichTextMission.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

            If Not IsNothing(vision) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(vision)
                    RichTextVision.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

            If Not IsNothing(valeur) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(valeur)
                    RichTextValeur.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

            If Not IsNothing(organigramme) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(organigramme)
                    RichTextOrganigramme.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

            If Not IsNothing(histoire) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(histoire)
                    RichTextHistoire.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

            If Not IsNothing(branche) Then
                Try
                    Dim rtf As String = ASCIIEncoding.ASCII.GetString(branche)
                    RichTextBranche.Rtf = rtf
                Catch ex As Exception

                End Try
            End If

        Catch ex As Exception
            Util.ShowMessage(ex.ToString, 2)
        Finally
            Database.CloseConnection()
        End Try
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub RapportOrganisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        PreloadFields()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If rtbDocument.CanUndo Then
            rtbDocument.Undo()
        End If
    End Sub

    Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        If rtbDocument.CanRedo Then
            rtbDocument.Redo()
        End If
    End Sub

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        rtbDocument.Cut()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        rtbDocument.Copy()
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        rtbDocument.Paste()
    End Sub

    Private Sub btnIncreaseFontSize_Click(sender As Object, e As EventArgs) Handles btnIncreaseFontSize.Click
        Try
            Dim fSize As Single = 0
            Single.TryParse(tscmbFontSize.Text, fSize)
            tscmbFontSize.Text = (fSize + 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDecreaseFontSize_Click(sender As Object, e As EventArgs) Handles btnDecreaseFontSize.Click
        Try
            Dim fSize As Single = 0
            Single.TryParse(tscmbFontSize.Text, fSize)
            tscmbFontSize.Text = (fSize - 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnToggleBullets_Click(sender As Object, e As EventArgs) Handles tsbtnBullets.Click
        rtbDocument.SelectionBullet = Not rtbDocument.SelectionBullet
    End Sub

    Private Sub btnDecreaseIndentation_Click(sender As Object, e As EventArgs) Handles btnDecreaseIndentation.Click
        rtbDocument.SelectionIndent -= 10
    End Sub

    Private Sub btnIncreaseIndentation_Click(sender As Object, e As EventArgs) Handles btnIncreaseIndentation.Click
        rtbDocument.SelectionIndent += 10
    End Sub

    Private Sub btnAlignLeft_Click(sender As Object, e As EventArgs)
        rtbDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub btnAlignCenter_Click(sender As Object, e As EventArgs)
        rtbDocument.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnAlignRight_Click(sender As Object, e As EventArgs)
        rtbDocument.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub EnregistrerToolStripButton_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripButton.Click

        Try
            Dim entete() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(rtbDocument.Rtf)
            Dim mission() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(RichTextMission.Rtf)
            Dim vision() As Byte = ASCIIEncoding.ASCII.GetBytes(RichTextVision.Rtf)
            Dim valeur() As Byte = ASCIIEncoding.ASCII.GetBytes(RichTextValeur.Rtf)
            Dim organigramme() As Byte = ASCIIEncoding.ASCII.GetBytes(RichTextOrganigramme.Rtf)
            Dim histoire() As Byte = ASCIIEncoding.ASCII.GetBytes(RichTextHistoire.Rtf)
            Dim branche() As Byte = ASCIIEncoding.ASCII.GetBytes(RichTextBranche.Rtf)

            Dim cmd As MySqlCommand = Database.GetCommand
            cmd.CommandText = "INSERT INTO organisations (entete, mission, vision, valeur, organigramme, histoire, branche) VALUE (@entete, @mission, @vision, @valeur, @organigramme, @histoire, @branche)"
            cmd.Prepare()

            Dim p As MySqlParameter = Nothing

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@entete"
            p.Value = entete
            cmd.Parameters.Add(p)

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@mission"
            p.Value = mission
            cmd.Parameters.Add(p)

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@vision"
            p.Value = vision
            cmd.Parameters.Add(p)

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@valeur"
            p.Value = valeur
            cmd.Parameters.Add(p)

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@organigramme"
            p.Value = organigramme
            cmd.Parameters.Add(p)

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@histoire"
            p.Value = histoire
            cmd.Parameters.Add(p)

            p = cmd.CreateParameter
            p.MySqlDbType = MySqlDbType.LongBlob
            p.ParameterName = "@branche"
            p.Value = branche
            cmd.Parameters.Add(p)

            If (cmd.ExecuteNonQuery) > 0 Then
                Util.ShowMessage(Me, "Enregistrement effectuer avec success")
                Close()
            End If

            cmd.Dispose()

        Catch ex As Exception
            Util.ShowMessage("Fatal error : " & ex.Message, 2)
        Finally
            Database.CloseConnection()
        End Try

    End Sub


    Private Sub ChangeSyle(sender As Object, e As EventArgs) Handles tsbtnUnderline.Click, tsbtnItalic.Click, tsbtnBold.Click
        ' bold, italic, underline
        Try
            If Not (rtbDocument.SelectionFont Is Nothing) Then
                Dim currentFont As Font = rtbDocument.SelectionFont
                Dim newFontStyle As FontStyle = rtbDocument.SelectionFont.Style
                Dim txt As String = TryCast(sender, ToolStripButton).Name
                If txt.IndexOf("tsbtnBold") >= 0 Then
                    newFontStyle = rtbDocument.SelectionFont.Style Xor FontStyle.Bold
                ElseIf txt.IndexOf("tsbtnItalic") >= 0 Then
                    newFontStyle = rtbDocument.SelectionFont.Style Xor FontStyle.Italic
                ElseIf txt.IndexOf("tsbtnUnderline") >= 0 Then
                    newFontStyle = rtbDocument.SelectionFont.Style Xor FontStyle.Underline
                End If

                rtbDocument.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error")
        End Try
    End Sub


    Private Sub tscmbFontSize_Click(sender As Object, e As EventArgs) Handles tscmbFontSize.SelectedIndexChanged
        Try
            If Not (rtbDocument.SelectionFont Is Nothing) Then
                Dim currentFont As Font = rtbDocument.SelectionFont
                Dim newSize As Single = Convert.ToSingle(tscmbFontSize.SelectedItem.ToString())
                rtbDocument.SelectionFont = New Font(currentFont.FontFamily, newSize, currentFont.Style)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error")
        End Try
    End Sub

    Private Sub tscmbFont_Click(sender As Object, e As EventArgs) Handles tscmbFont.SelectedIndexChanged
        ' font
        Try
            If Not (rtbDocument.SelectionFont Is Nothing) Then
                Dim currentFont As Font = rtbDocument.SelectionFont
                Dim newFamily As New FontFamily(tscmbFont.SelectedItem.ToString())
                rtbDocument.SelectionFont = New Font(newFamily, currentFont.Size, currentFont.Style)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error")
        End Try
    End Sub



    Private Sub rtbDocument_SelectionChanged(sender As Object, e As EventArgs)
        If rtbDocument.SelectionFont IsNot Nothing Then
            tsbtnBold.Checked = rtbDocument.SelectionFont.Bold
            tsbtnItalic.Checked = rtbDocument.SelectionFont.Italic
            tsbtnUnderline.Checked = rtbDocument.SelectionFont.Underline

            Select Case rtbDocument.SelectionAlignment
                Case HorizontalAlignment.Left
                    tsbtnAlignLeft.Checked = True
                    tsbtnAlignCenter.Checked = False
                    tsbtnAlignRight.Checked = False

                    Exit Select

                Case HorizontalAlignment.Center
                    tsbtnAlignLeft.Checked = False
                    tsbtnAlignCenter.Checked = True
                    tsbtnAlignRight.Checked = False

                    Exit Select

                Case HorizontalAlignment.Right
                    tsbtnAlignLeft.Checked = False
                    tsbtnAlignCenter.Checked = False
                    tsbtnAlignRight.Checked = True

                    Exit Select
            End Select

            tsbtnBullets.Checked = rtbDocument.SelectionBullet

            tscmbFont.SelectedItem = rtbDocument.SelectionFont.FontFamily.Name
            tscmbFontSize.SelectedItem = rtbDocument.SelectionFont.Size.ToString()
        End If
    End Sub

    Private Sub ChangeAlignement(sender As Object, e As EventArgs) Handles tsbtnAlignRight.Click, tsbtnAlignLeft.Click, tsbtnAlignCenter.Click
        ' alignment: left, center, right
        Try
            Dim txt As String = TryCast(sender, ToolStripButton).Name
            If txt.IndexOf("tsbtnAlignLeft") >= 0 Then
                rtbDocument.SelectionAlignment = HorizontalAlignment.Left
                tsbtnAlignLeft.Checked = True
                tsbtnAlignCenter.Checked = False
                tsbtnAlignRight.Checked = False
            ElseIf txt.IndexOf("tsbtnAlignCenter") >= 0 Then
                rtbDocument.SelectionAlignment = HorizontalAlignment.Center
                tsbtnAlignLeft.Checked = False
                tsbtnAlignCenter.Checked = True
                tsbtnAlignRight.Checked = False
            ElseIf txt.IndexOf("tsbtnAlignRight") >= 0 Then
                rtbDocument.SelectionAlignment = HorizontalAlignment.Right
                tsbtnAlignLeft.Checked = False
                tsbtnAlignCenter.Checked = False
                tsbtnAlignRight.Checked = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error")
        End Try
    End Sub

    Private Sub tsbtnFontColor_Click(sender As Object, e As EventArgs) Handles tsbtnFontColor.Click
        ' font color
        Try
            Using dlg As New ColorDialog()
                dlg.Color = rtbDocument.SelectionColor
                If dlg.ShowDialog() = DialogResult.OK Then
                    rtbDocument.SelectionColor = dlg.Color
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error")
        End Try
    End Sub

    Private Sub tscmbFontSize_TextChanged(sender As Object, e As EventArgs) Handles tscmbFontSize.TextChanged
        ' font size custom
        Try
            If Not (rtbDocument.SelectionFont Is Nothing) Then
                Dim currentFont As Font = rtbDocument.SelectionFont
                Dim newSize As Single = Convert.ToSingle(tscmbFontSize.Text)
                rtbDocument.SelectionFont = New Font(currentFont.FontFamily, newSize, currentFont.Style)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error")
        End Try
    End Sub

    Private Sub tsbtnInsertPicture_Click(sender As Object, e As EventArgs) Handles tsbtnInsertPicture.Click
        Using dlg As New OpenFileDialog()
            dlg.Title = "Insert picture"
            dlg.DefaultExt = "jpg"
            dlg.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|All files|*.*"
            dlg.FilterIndex = 1
            If dlg.ShowDialog() = DialogResult.OK Then
                Try
                    Dim strImagePath As String = dlg.FileName
                    Dim img As Image = Image.FromFile(strImagePath)
                    Clipboard.SetDataObject(img)
                    Dim df As DataFormats.Format
                    df = DataFormats.GetFormat(DataFormats.Bitmap)
                    If Me.rtbDocument.CanPaste(df) Then
                        Me.rtbDocument.Paste(df)
                    End If
                Catch
                    MessageBox.Show("Unable to insert image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            End If
        End Using
    End Sub

    Private Sub tsbtnOpen_Click(sender As Object, e As EventArgs) Handles tsbtnOpen.Click
        Using dlg As New OpenFileDialog()
            dlg.Filter = "Rich text format|*.rtf"
            dlg.FilterIndex = 0
            If dlg.ShowDialog() = DialogResult.OK Then
                Try
                    rtbDocument.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText)
                Catch exc As System.IO.IOException
                    MessageBox.Show("Error reading file: " & vbLf & exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Catch exc_a As ArgumentException
                    MessageBox.Show("Error reading file: " & vbLf & exc_a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])

                End Try
            End If
        End Using
    End Sub



#Region "Changing active richTextBox"
    Private Sub TabEntete_Enter(sender As Object, e As EventArgs) Handles TabEntete.Enter
        rtbDocument = RichTextEntete
    End Sub

    Private Sub TabMission_Enter(sender As Object, e As EventArgs) Handles TabMission.Enter
        rtbDocument = RichTextMission
    End Sub


    Private Sub TabVision_Enter(sender As Object, e As EventArgs) Handles TabVision.Enter
        rtbDocument = RichTextVision
    End Sub

    Private Sub TabValeur_Enter(sender As Object, e As EventArgs) Handles TabValeur.Enter
        rtbDocument = RichTextValeur
    End Sub

    Private Sub TabHistoire_Enter(sender As Object, e As EventArgs) Handles TabHistoire.Enter
        rtbDocument = RichTextHistoire
    End Sub

    Private Sub TabOrganisation_Enter(sender As Object, e As EventArgs) Handles TabOrganigramme.Enter
        rtbDocument = RichTextOrganigramme
    End Sub

    Private Sub TabBranche_Enter(sender As Object, e As EventArgs) Handles TabBranche.Enter
        rtbDocument = RichTextBranche
    End Sub
#End Region

End Class