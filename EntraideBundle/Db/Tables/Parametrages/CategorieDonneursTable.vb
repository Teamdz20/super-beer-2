Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class CategorieDonneursTable


        Public Function Save(ByVal name As String) As Integer
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "INSERT INTO categorie_donneurs(nom) VALUE(@nom)"
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


        Public Function Update(ByVal cat_id As String, ByVal name As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "UPDATE categorie_donneurs SET nom=@nom WHERE id =@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", cat_id)
                cmd.Parameters.AddWithValue("@nom", name)

                id = cmd.ExecuteNonQuery()

                cmd.Dispose()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Faral error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
            Return id
        End Function


        Public Function GetByName(ByVal name As String) As List(Of CategorieDonneurEntity)
            Dim categories As List(Of CategorieDonneurEntity) = New List(Of CategorieDonneurEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom FROM categorie_donneurs WHERE nom LIKE '" & Util.E(name) & "%'"
                Dim result = cmd.ExecuteReader
                While result.Read
                    Dim entity As New CategorieDonneurEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Nom = result.GetValue(1).ToString
                    categories.Add(entity)
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return categories
        End Function


        Public Function GetAll() As List(Of CategorieDonneurEntity)
            Dim categorie As List(Of CategorieDonneurEntity) = New List(Of CategorieDonneurEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom FROM categorie_donneurs"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New CategorieDonneurEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Nom = result.GetValue(1).ToString

                    categorie.Add(entity)

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return categorie
        End Function

    End Class
End Namespace