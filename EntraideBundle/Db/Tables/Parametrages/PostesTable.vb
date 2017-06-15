Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db.Entities

Namespace Db.Tables
    Public Class PostesTable

        Public Function Save(ByVal name As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "INSERT INTO postes(nom) VALUE(@nom)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@nom", name)
                cmd.ExecuteNonQuery()
                id = cmd.LastInsertedId
                cmd.Dispose()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Echec de connexion")
                End If
            Finally
                Database.CloseConnection()
            End Try
            Return id
        End Function


        Public Function UpdatePoste(ByVal pos_id As String, ByVal name As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "UPDATE postes SET nom=@nom WHERE id =@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", pos_id)
                cmd.Parameters.AddWithValue("@nom", name)
                id = cmd.ExecuteNonQuery()

                cmd.Dispose()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Echec de connexion")
                End If
            Finally
                Database.CloseConnection()
            End Try
            Return id
        End Function

        Public Function GetAll() As List(Of PosteEntity)
            Dim liste As List(Of PosteEntity) = New List(Of PosteEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom FROM postes"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New PosteEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    liste.Add(entity)

                End While
                result.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return liste
        End Function


        Public Function GetByName(ByVal name As String) As List(Of PosteEntity)
            Dim liste As List(Of PosteEntity) = New List(Of PosteEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom FROM postes WHERE nom LIKE '" & Util.E(name) & "%'"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader
                While result.Read
                    Dim entity As New PosteEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    liste.Add(entity)

                End While
                result.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return liste
        End Function

    End Class

End Namespace
