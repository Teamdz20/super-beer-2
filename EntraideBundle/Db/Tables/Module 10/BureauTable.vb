Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db.Entities

Namespace Db.Tables
    Public Class BureauTable


        Public Function GetAll() As List(Of BureauAlumniEntity)
            Dim categorie As List(Of BureauAlumniEntity) = New List(Of BureauAlumniEntity)
            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT bureau_alumni.id,  bureau_alumni.date_fonction,bureau_alumni.poste, CONCAT_WS(' ',etudiants.nom, etudiants.prenom) FROM bureau_alumni INNER JOIN etudiants ON etudiants.id = bureau_alumni.etudiant_id"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New BureauAlumniEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.DateFonction = result.GetValue(1).ToString
                    entity.Poste = result.GetValue(2).ToString
                    entity.Etudiant.nom = result.GetValue(3).ToString

                    categorie.Add(entity)

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return categorie
        End Function


        Public Function Save(ByVal poste As String, date_fonction As DateTime, etudiant_id As String) As Long
            Dim id As Long = 0
            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "INSERT INTO bureau_alumni(poste, date_fonction, etudiant_id) VALUE(@poste, @date_fonction, @etudiant_id)"
                cmd.Prepare()

                Dim p As MySqlParameter = cmd.CreateParameter
                p.MySqlDbType = MySqlDbType.DateTime
                p.ParameterName = "@date_fonction"
                p.Value = date_fonction
                cmd.Parameters.Add(p)

                cmd.Parameters.AddWithValue("@poste", poste)
                cmd.Parameters.AddWithValue("@etudiant_id", etudiant_id)
                
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


        Public Function UpdateBureau(ByVal b_id As String, ByVal date_fonction As DateTime, ByVal poste As String, ByVal etudiant_id As String) As Long
            Dim id As Long = 0
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "UPDATE bureau_alumni SET date_fonction=@date_fonction, poste=@poste, etudiant_id=@etudiant_id WHERE id =@id"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", b_id)

                Dim p As MySqlParameter = cmd.CreateParameter
                p.MySqlDbType = MySqlDbType.DateTime
                p.ParameterName = "@date_fonction"
                p.Value = date_fonction
                cmd.Parameters.Add(p)

                cmd.Parameters.AddWithValue("@poste", poste)
                cmd.Parameters.AddWithValue("@etudiant_id", etudiant_id)

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
