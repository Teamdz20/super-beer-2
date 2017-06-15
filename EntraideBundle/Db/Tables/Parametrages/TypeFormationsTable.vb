Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class TypeFormationsTable

        Public Function Save(ByVal name As String, ByVal montant As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "INSERT INTO type_formations(nom, montant) VALUE(@nom, @montant)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@nom", name)
                cmd.Parameters.AddWithValue("@montant", montant)
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

        Public Function GetByName(ByVal name As String) As List(Of TypeFormationEntity)

            Dim liste As List(Of TypeFormationEntity) = New List(Of TypeFormationEntity)

            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom, montant FROM type_formations WHERE nom LIKE '" & Util.E(name) & "%'"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New TypeFormationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Nom = result.GetValue(1).ToString
                    entity.Montant = result.GetValue(2).ToString
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

        Public Function GetAll() As List(Of TypeFormationEntity)
            Dim liste As List(Of TypeFormationEntity) = New List(Of TypeFormationEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom, montant FROM type_formations"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New TypeFormationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Nom = result.GetValue(1).ToString
                    entity.Montant = result.GetValue(2).ToString
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


        Public Function Update(ByVal type_id As String, ByVal name As String, ByVal montant As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "UPDATE type_formations SET nom=@nom, montant=@montant WHERE id =@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", type_id)
                cmd.Parameters.AddWithValue("@nom", name)
                cmd.Parameters.AddWithValue("@montant", montant)
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

    End Class
End Namespace
