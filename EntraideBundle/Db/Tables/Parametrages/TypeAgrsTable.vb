Imports EntraideBundle.Db.Entities
Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class TypeAgrsTable

        Public Function GetAll() As List(Of TypeAgrEntity)
            Dim list_agrs As List(Of TypeAgrEntity) = New List(Of TypeAgrEntity)
            Try
                Using cmd As MySqlCommand = Database.GetCommand
                    cmd.CommandText = "SELECT type_agrs.id AS type_agr_id, type_agrs.nom AS type_agr_nom FROM type_agrs"
                    Dim result As MySqlDataReader = cmd.ExecuteReader
                    While result.Read
                        list_agrs.Add(New TypeAgrEntity(result))
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
            Return list_agrs
        End Function


        Public Function GetByName(ByVal name As String) As List(Of TypeAgrEntity)
            Dim list_agrs As List(Of TypeAgrEntity) = New List(Of TypeAgrEntity)
            Try
                Using cmd As MySqlCommand = Database.GetCommand
                    cmd.CommandText = "SELECT type_agrs.id AS type_agr_id, type_agrs.nom AS type_agr_nom FROM type_agrs WHERE nom LIKE '" & Util.E(name) & "%'"
                    Dim result As MySqlDataReader = cmd.ExecuteReader
                    While result.Read
                        list_agrs.Add(New TypeAgrEntity(result))
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
            Return list_agrs
        End Function

    End Class
End Namespace