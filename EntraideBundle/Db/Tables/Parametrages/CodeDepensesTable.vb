Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class CodeDepensesTable

        Public Function Save(ByVal name As String, ByVal code As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "INSERT INTO code_depenses(nom, code) VALUE(@nom, @code_depense)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@nom", name)
                cmd.Parameters.AddWithValue("@code_depense", code)
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

        Public Function Update(ByVal code_id As String, ByVal name As String, ByVal code As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "UPDATE code_depenses SET nom = @nom, code = @code_depense WHERE id = @id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", code_id)
                cmd.Parameters.AddWithValue("@nom", name)
                cmd.Parameters.AddWithValue("@code_depense", code)
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

        Public Function GetByName(ByVal name As String) As List(Of CodeDepenseEntity)
            Dim liste As List(Of CodeDepenseEntity) = New List(Of CodeDepenseEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom, code FROM code_depenses WHERE nom LIKE '" & name & "%'"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New CodeDepenseEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Nom = result.GetValue(1).ToString
                    entity.CodeRevenu = result.GetValue(2).ToString
                    liste.Add(entity)

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return liste
        End Function

        Public Function GetAll() As List(Of CodeDepenseEntity)
            Dim liste As List(Of CodeDepenseEntity) = New List(Of CodeDepenseEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom, code FROM code_depenses"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New CodeDepenseEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Nom = result.GetValue(1).ToString
                    entity.CodeRevenu = result.GetValue(2).ToString
                    liste.Add(entity)

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return liste
        End Function

    End Class
End Namespace