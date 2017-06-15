Imports Microsoft.Win32

Public Class Settings

    Public Shared ReadOnly Property ShareConnection As Boolean
        Get
            Return My.Settings.ShareConnection
        End Get
    End Property

    Public Shared ReadOnly Property DisableLazyLoading As Boolean
        Get
            Return My.Settings.DisableLazyLoading
        End Get
    End Property

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Dim cnxStr As String = "Database=" & DbName & ";User Id=" & DbUser & ";Datasource=" & DbHost & ";password=" & DbPass & ";charset=utf8"
            Return cnxStr
        End Get
    End Property


    Public Shared ReadOnly Property AppDebugMode As Boolean
        Get
            Return My.Settings.app_debug_mode
        End Get
    End Property

    Public Shared ReadOnly Property DbHost As String
        Get
            Return My.Settings.db_host
        End Get
    End Property


    Public Shared ReadOnly Property DbName As String
        Get
            Return My.Settings.db_name
        End Get
    End Property

    Public Shared ReadOnly Property DbUser As String
        Get
            Return My.Settings.db_user
        End Get
    End Property

    Public Shared ReadOnly Property DbPass As String
        Get
            Return My.Settings.db_pass
        End Get
    End Property



    Public Shared Sub RefreshSettings()
        Dim reg As RegistryKey = Registry.CurrentUser
        Dim regKey As RegistryKey = Nothing

        Try
            regKey = reg.OpenSubKey("Software\KS SOFTWARE\Entraide", RegistryKeyPermissionCheck.ReadSubTree)
            If IsNothing(regKey) Then
                Exit Sub
            End If


            Dim host As String = CStr(regKey.GetValue("db_host", Nothing))
            Dim pass As String = CStr(regKey.GetValue("db_pass", Nothing))
            Dim name As String = CStr(regKey.GetValue("db_name", Nothing))
            Dim user As String = CStr(regKey.GetValue("db_user", Nothing))
            Dim trainning As String = CStr(regKey.GetValue("db_trainning", Nothing))


            If Not IsNothing(host) Then
                My.Settings.db_host = ConfigManager.Security.GetString(host)
            End If

            If Not IsNothing(pass) Then
                My.Settings.db_pass = ConfigManager.Security.GetString(pass)
            End If

            If Not IsNothing(name) Then
                My.Settings.db_name = ConfigManager.Security.GetString(name)
            End If

            If Not IsNothing(user) Then
                My.Settings.db_user = ConfigManager.Security.GetString(user)
            End If

            If Not IsNothing(trainning) Then
                My.Settings.trainning_db = ConfigManager.Security.GetString(trainning)
            End If

            My.Settings.Save()
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical)
        Finally
            If Not IsNothing(regKey) Then
                regKey.Close()
            End If
            If Not IsNothing(reg) Then
                reg.Close()
            End If

            GC.Collect()
        End Try
    End Sub

End Class
