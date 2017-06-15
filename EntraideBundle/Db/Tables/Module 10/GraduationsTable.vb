Imports EntraideBundle.Db.Entities
Imports MySql.Data.MySqlClient

Namespace Db.Tables

    Public Class GraduationsTable

        Public Shared data_source As DataSetTables = Nothing

        ''' <summary>
        ''' Membres alumni
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetMembers() As List(Of GraduationEntity)
            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT graduations.id, graduations.date_graduation, graduations.note, CONCAT_WS(' ',etudiants.nom, etudiants.prenom) AS etudiant, users.username, etudiants.tel1, etudiants.email, type_formations.nom, etudiants.adresse FROM graduations  INNER JOIN etudiants ON etudiants.id = graduations.etudiant_id INNER JOIN users ON users.id = graduations.user_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.DateGraduation = result.GetValue(1).ToString
                    entity.Note = result.GetValue(2).ToString
                    entity.Etudiant.nom = result.GetValue(3).ToString
                    entity.User.Nom = result.GetValue(4).ToString
                    entity.Etudiant.tel1 = result.GetValue(5).ToString
                    entity.Etudiant.email = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString
                    entity.Etudiant.adresse = result.GetValue(8).ToString

                    gradues.Add(entity)
                End While
                result.Close()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function

        ''' <summary>
        ''' Get member by name
        ''' </summary>
        ''' <param name="needle"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetMembersByName(ByVal needle As String) As List(Of GraduationEntity)
            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT graduations.id, graduations.date_graduation, graduations.note, CONCAT_WS(' ',etudiants.nom, etudiants.prenom) AS etudiant, users.username, etudiants.tel1, etudiants.email, type_formations.nom, etudiants.adresse FROM graduations  INNER JOIN etudiants ON etudiants.id = graduations.etudiant_id INNER JOIN users ON users.id = graduations.user_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation WHERE CONCAT_WS(' ', etudiants.nom, etudiants.prenom) LIKE '" & Util.E(needle) & "%' "

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.DateGraduation = result.GetValue(1).ToString
                    entity.Note = result.GetValue(2).ToString
                    entity.Etudiant.nom = result.GetValue(3).ToString
                    entity.User.Nom = result.GetValue(4).ToString
                    entity.Etudiant.tel1 = result.GetValue(5).ToString
                    entity.Etudiant.email = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString
                    entity.Etudiant.adresse = result.GetValue(8).ToString

                    gradues.Add(entity)
                End While
                result.Close()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function

        ''' <summary>
        ''' Save graduation
        ''' </summary>
        ''' <param name="date_grad"></param>
        ''' <param name="note"></param>
        ''' <param name="etudiant_id"></param>
        ''' <param name="user_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Save(ByVal date_grad As DateTime, ByVal note As String, ByVal etudiant_id As String, ByVal user_id As String) As Long
            Dim id As Long = 0
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "INSERT INTO graduations(date_graduation, note, etudiant_id, user_id) VALUE(@date_graduation, @note, @etudiant_id, @user_id)"
                cmd.Prepare()

                Dim p As MySqlParameter = cmd.CreateParameter
                p.ParameterName = "@date_graduation"
                p.MySqlDbType = MySqlDbType.DateTime
                p.Value = date_grad

                cmd.Parameters.Add(p)
                cmd.Parameters.AddWithValue("@note", note)
                cmd.Parameters.AddWithValue("@etudiant_id", etudiant_id)
                cmd.Parameters.AddWithValue("@user_id", user_id)

                cmd.ExecuteNonQuery()

                id = cmd.LastInsertedId

                cmd.Dispose()

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
            Return id
        End Function

        ''' <summary>
        ''' Get all gradues
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetAll() As List(Of GraduationEntity)

            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT graduations.id, etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, etudiants.tel1, etudiants.adresse, generations.libelle AS generation, type_formations.nom AS type_formation, DATE(graduations.date_graduation) AS date_graduation, graduations.note AS observation FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN graduations ON etudiants.id = graduations.etudiant_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.id = result.GetValue(1).ToString
                    entity.Etudiant.nom = result.GetValue(2).ToString
                    entity.Etudiant.prenom = result.GetValue(3).ToString
                    entity.Etudiant.tel1 = result.GetValue(4).ToString
                    entity.Etudiant.adresse = result.GetValue(5).ToString
                    entity.Etudiant.generation_id = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString

                    entity.DateGraduation = result.GetValue(8).ToString
                    entity.Note = result.GetValue(9).ToString

                    gradues.Add(entity)
                End While
                result.Close()
                FillDataSource(cmd)
                cmd.Dispose()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function

        ''' <summary>
        ''' Get gradue by date
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDate(ByVal du As String, ByVal au As String) As List(Of GraduationEntity)

            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT graduations.id, etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, etudiants.tel1, etudiants.adresse, generations.libelle AS generation, type_formations.nom AS type_formation, DATE(graduations.date_graduation) AS date_graduation, graduations.note AS observation FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN graduations ON etudiants.id = graduations.etudiant_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation WHERE DATE(graduations.date_graduation) BETWEEN @du AND @au"

                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", du)
                cmd.Parameters.AddWithValue("@au", au)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.id = result.GetValue(1).ToString
                    entity.Etudiant.nom = result.GetValue(2).ToString
                    entity.Etudiant.prenom = result.GetValue(3).ToString
                    entity.Etudiant.tel1 = result.GetValue(4).ToString
                    entity.Etudiant.adresse = result.GetValue(5).ToString
                    entity.Etudiant.generation_id = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString

                    entity.DateGraduation = result.GetValue(8).ToString
                    entity.Note = result.GetValue(9).ToString

                    gradues.Add(entity)
                End While
                result.Close()
                FillDataSource(cmd)
                cmd.Dispose()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function

        ''' <summary>
        ''' Get by etudiant
        ''' </summary>
        ''' <param name="etudiant_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByEtudiant(ByVal etudiant_id As String) As List(Of GraduationEntity)

            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT graduations.id, etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, etudiants.tel1, etudiants.adresse, generations.libelle AS generation, type_formations.nom AS type_formation, DATE(graduations.date_graduation) AS date_graduation, graduations.note AS observation FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN graduations ON etudiants.id = graduations.etudiant_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation WHERE etudiants.id = @et_id"

                cmd.Prepare()
                cmd.Parameters.AddWithValue("@et_id", etudiant_id)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.id = result.GetValue(1).ToString
                    entity.Etudiant.nom = result.GetValue(2).ToString
                    entity.Etudiant.prenom = result.GetValue(3).ToString
                    entity.Etudiant.tel1 = result.GetValue(4).ToString
                    entity.Etudiant.adresse = result.GetValue(5).ToString
                    entity.Etudiant.generation_id = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString

                    entity.DateGraduation = result.GetValue(8).ToString
                    entity.Note = result.GetValue(9).ToString

                    gradues.Add(entity)
                End While
                result.Close()
                FillDataSource(cmd)
                cmd.Dispose()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function

        ''' <summary>
        ''' Get by generation
        ''' </summary>
        ''' <param name="generation_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByGeneration(ByVal generation_id As String) As List(Of GraduationEntity)

            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT graduations.id, etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, etudiants.tel1, etudiants.adresse, generations.libelle AS generation, type_formations.nom AS type_formation, DATE(graduations.date_graduation) AS date_graduation, graduations.note AS observation FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN graduations ON etudiants.id = graduations.etudiant_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation WHERE generations.id = @gen_id"

                cmd.Prepare()
                cmd.Parameters.AddWithValue("@gen_id", generation_id)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.id = result.GetValue(1).ToString
                    entity.Etudiant.nom = result.GetValue(2).ToString
                    entity.Etudiant.prenom = result.GetValue(3).ToString
                    entity.Etudiant.tel1 = result.GetValue(4).ToString
                    entity.Etudiant.adresse = result.GetValue(5).ToString
                    entity.Etudiant.generation_id = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString

                    entity.DateGraduation = result.GetValue(8).ToString
                    entity.Note = result.GetValue(9).ToString

                    gradues.Add(entity)
                End While
                result.Close()
                FillDataSource(cmd)
                cmd.Dispose()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function

        ''' <summary>
        ''' Get By formation
        ''' </summary>
        ''' <param name="formation_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByFormation(ByVal du As String, ByVal au As String, ByVal formation_id As String) As List(Of GraduationEntity)

            Dim gradues As List(Of GraduationEntity) = New List(Of GraduationEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT graduations.id, etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, etudiants.tel1, etudiants.adresse, generations.libelle AS generation, type_formations.nom AS type_formation, DATE(graduations.date_graduation) AS date_graduation, graduations.note AS observation FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN graduations ON etudiants.id = graduations.etudiant_id INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN type_formations ON type_formations.id = formations.id_type_formation WHERE type_formations.id = @f_id AND (DATE(graduations.date_graduation) BETWEEN @du AND @au)"

                cmd.Prepare()
                cmd.Parameters.AddWithValue("@f_id", formation_id)
                cmd.Parameters.AddWithValue("@du", du)
                cmd.Parameters.AddWithValue("@au", au)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New GraduationEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.id = result.GetValue(1).ToString
                    entity.Etudiant.nom = result.GetValue(2).ToString
                    entity.Etudiant.prenom = result.GetValue(3).ToString
                    entity.Etudiant.tel1 = result.GetValue(4).ToString
                    entity.Etudiant.adresse = result.GetValue(5).ToString
                    entity.Etudiant.generation_id = result.GetValue(6).ToString
                    entity.Etudiant.TypeFormationId.Nom = result.GetValue(7).ToString

                    entity.DateGraduation = result.GetValue(8).ToString
                    entity.Note = result.GetValue(9).ToString

                    gradues.Add(entity)
                End While
                result.Close()
                FillDataSource(cmd)
                cmd.Dispose()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try

            Return gradues
        End Function


        ''' <summary>
        ''' Filling DataSource to generate a report
        ''' </summary>
        ''' <param name="cmd"></param>
        ''' <remarks></remarks>
        Private Sub FillDataSource(ByRef cmd As MySqlCommand)
            Try
                data_source = New DataSetTables
                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter
                adapter.SelectCommand = cmd
                adapter.FillAsync(data_source.Graduation)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
            End Try
        End Sub

    End Class
End Namespace
