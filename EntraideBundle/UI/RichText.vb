Imports System.IO

Public Class RichText

    Sub Initialize()
        For Each family As FontFamily In FontFamily.Families
            tscmbFont.Items.Add(family.Name)
        Next
        tscmbFont.SelectedItem = "Calibri"

        tscmbFontSize.SelectedItem = "12"
    End Sub

    Private Sub RichText_Load(sender As Object, e As EventArgs) Handles Me.Load
        Initialize()
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

    Private Sub rtbDocument_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocument.SelectionChanged
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


    Private Sub OpenWordDoc()

        Dim openFile As OpenFileDialog = New OpenFileDialog
        openFile.Filter = "Document Word (*.docx)|*.docx|Document Word 97-2003 (*.doc)|*.doc|Texte mise en forme (*.rtf)|*.rtf|Fichier texte (*.txt)|*.txt"

        If openFile.ShowDialog() = DialogResult.OK Then
            Try
                ' Open document 
                Dim originalfilename As String = System.IO.Path.GetFullPath(openFile.FileName)

                'AndAlso {".docx", ".doc", ".txt", ".rtf"}.Contains(Path.GetExtension(originalfilename).ToLower()) 

                If openFile.CheckFileExists Then
                    Dim wordObject__1 As New Microsoft.Office.Interop.Word.Application()
                    Dim File As Object = originalfilename
                    Dim nullobject As Object = System.Reflection.Missing.Value
                    Dim wordobject__2 As New Microsoft.Office.Interop.Word.Application()
                    wordobject__2.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone
                    Dim docs As Microsoft.Office.Interop.Word._Document = wordObject__1.Documents.Open(File, nullobject, nullobject, nullobject, nullobject, nullobject, _
                        nullobject, nullobject, nullobject, nullobject, nullobject, nullobject, _
                        nullobject, nullobject, nullobject, nullobject)
                    docs.ActiveWindow.Selection.WholeStory()
                    docs.ActiveWindow.Selection.Copy()
                    rtbDocument.Paste()

                    docs.Close(nullobject, nullobject, nullobject)
                    wordobject__2.Quit(nullobject, nullobject, nullobject)
                    MessageBox.Show("file loaded")
                End If
            Catch ex As Exception
                Util.ShowMessage(ex.Message, 2)
            End Try
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        OpenWordDoc()
    End Sub
End Class
