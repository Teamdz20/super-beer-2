Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db.Entities

Namespace Db.Tables
    Public Class DepartementsTable

        ''' <summary>
        ''' Requete SQL pour les comboboxs
        ''' </summary>
        ''' <remarks></remarks>
        Public Const COMBO_SQL As String = "SELECT id, nom FROM departements"

        ''' <summary>
        ''' Primary Key
        ''' </summary>
        ''' <remarks></remarks>
        Public Const P_K As String = "id"

        ''' <summary>
        ''' Display Name
        ''' </summary>
        ''' <remarks></remarks>
        Public Const D_N As String = "nom"

        ''' <summary>
        ''' Save
        ''' </summary>
        ''' <param name="name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Save(ByVal name As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "INSERT INTO departements(nom) VALUE(@nom)"
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


        Public Function GetByName(ByVal name As String) As List(Of DepartementEntity)
            Dim departements As List(Of DepartementEntity) = New List(Of DepartementEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom FROM departements WHERE nom LIKE '" & Util.E(name) & "%'"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New DepartementEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    departements.Add(entity)

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return departements
        End Function

        Public Function GetAll() As List(Of DepartementEntity)
            Dim departements As List(Of DepartementEntity) = New List(Of DepartementEntity)
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT id, nom FROM departements"
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New DepartementEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    departements.Add(entity)

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return departements
        End Function

        Public Function Update(ByVal dep_id As String, ByVal name As String) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "UPDATE departements SET nom=@nom WHERE id=@id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", dep_id)
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

    End Class
End Namespace