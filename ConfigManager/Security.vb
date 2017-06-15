Imports System.Text
Imports Microsoft.Win32

Public Class Security

    ''' <summary>
    ''' Encode une chaine de caractere en base64
    ''' </summary>
    ''' <param name="text"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetEncodedString(ByVal text As String) As String
        Dim outString As String = vbNullString

        Dim utf8 As UTF8Encoding = New UTF8Encoding()
        Dim bytes() As Byte = utf8.GetBytes(text)

        outString = System.Convert.ToBase64String(bytes)
        Return outString
    End Function

    ''' <summary>
    ''' Decode une chaine de caractere base64
    ''' </summary>
    ''' <param name="encoded"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetString(ByVal encoded As String) As String
        Dim outString As String = vbNullString

        Dim bytes() As Byte = System.Convert.FromBase64String(encoded)
        Dim utf8 As UTF8Encoding = New UTF8Encoding()

        outString = utf8.GetString(bytes)
        Return outString
    End Function


    Public Shared Sub WriteReg(server As String, user As String, password As String, dbname As String)
        Dim reg As RegistryKey = Registry.CurrentUser
        Dim regKey As RegistryKey = Nothing

        Try
            If reg.OpenSubKey("Software\KS SOFTWARE\Entraide", RegistryKeyPermissionCheck.ReadSubTree) Is Nothing Then
                reg.CreateSubKey("Software\KS SOFTWARE\Entraide", RegistryKeyPermissionCheck.ReadWriteSubTree)
            End If

            regKey = reg.OpenSubKey("Software\KS SOFTWARE\Entraide", RegistryKeyPermissionCheck.ReadWriteSubTree)
            regKey.SetValue("db_host", Security.GetEncodedString(server))
            regKey.SetValue("db_user", Security.GetEncodedString(user))
            regKey.SetValue("db_pass", Security.GetEncodedString(password))
            regKey.SetValue("db_name", Security.GetEncodedString(dbname))
            'regKey.SetValue("db_trainning", Security.GetEncodedString(TRAINNING_DB))
        Catch ex As Exception
            MsgBox("Erreur de configuration interne de la base de données", MsgBoxStyle.Critical)
        Finally
            If Not IsNothing(regKey) Then
                regKey.Close()
            End If

            If Not IsNothing(reg) Then
                reg.Close()
            End If
        End Try
    End Sub

End Class
