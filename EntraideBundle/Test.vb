Imports Microsoft.Office.Interop

Public Class Test

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Try
            oWord = New Word.Application
            oDoc = oWord.Documents.Add("C:\\users\\dev\\Desktop\\Doc2.dotx")

            oDoc.Bookmarks.Item("nom").Range.Text = "KIKOUNGA"
            oDoc.Bookmarks.Item("prenom").Range.Text = "Lepres"
            oDoc.Bookmarks.Item("date_creation").Range.Text = FormatDateTime(Today, DateFormat.LongDate)
            oDoc.SaveAs2("C:\\users\\dev\\Desktop\\document.docx")
            oDoc.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        Finally
            If oDoc IsNot Nothing Then
                ReleaseObject(oDoc)
            End If

            If oWord IsNot Nothing Then
                ReleaseObject(oWord)
            End If
        End Try

    End Sub


    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New ConfigManager.DatabaseSetup
        form.ShowDialog()
    End Sub
End Class