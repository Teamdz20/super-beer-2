Imports EntraideBundle.Db.Entities
Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class ProgrammesTable

        Public Function GetAll() As List(Of ProgrammeEntity)
            Dim list_programs As List(Of ProgrammeEntity) = New List(Of ProgrammeEntity)

            Try
                Using cmd As MySqlCommand = Database.GetCommand
                    cmd.CommandText = "SELECT programmes.id AS programme_id, programmes.nom AS programme_nom, programmes.code AS programme_code FROM programmes"
                    Dim result As MySqlDataReader = cmd.ExecuteReader
                    While result.Read
                        Dim pEntity As New ProgrammeEntity(result)
                        list_programs.Add(pEntity)
                    End While
                    result.Close()
                End Using
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            End Try

            Return list_programs
        End Function


        Public Function GetByName(ByVal name As String) As List(Of ProgrammeEntity)
            Dim list_programs As List(Of ProgrammeEntity) = New List(Of ProgrammeEntity)

            Try
                Using cmd As MySqlCommand = Database.GetCommand
                    cmd.CommandText = "SELECT programmes.id AS programme_id, programmes.nom AS programme_nom, programmes.code AS programme_code FROM programmes WHERE nom LIKE '" & Util.E(name) & "%'"
                    Dim result As MySqlDataReader = cmd.ExecuteReader
                    While result.Read
                        Dim pEntity As New ProgrammeEntity(result)
                        list_programs.Add(pEntity)
                    End While
                    result.Close()
                End Using
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            End Try

            Return list_programs
        End Function

    End Class
End Namespace