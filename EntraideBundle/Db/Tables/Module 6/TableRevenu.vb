Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls

Namespace Db.Tables
    Public Class RevenusTable


        Public Shared data_source As DataSetTables = Nothing


        Public Function GetAll() As DataTable

            Dim dataTable As New DataTable

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT * FROM revenus"

                Dim tableAdpater As New MySqlDataAdapter
                tableAdpater.SelectCommand = cmd
                tableAdpater.Fill(dataTable)

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Echec de connexion")
                End If

            Finally
                Database.CloseConnection()
            End Try

            Return dataTable
        End Function

        ''' <summary>
        ''' Save
        ''' </summary>
        ''' <param name="revenu">Revenu entity</param>
        ''' <returns>Id de l'etudiant enregistrer</returns>
        ''' <remarks></remarks>
        Public Function Save(ByVal revenu As EntraideBundle.Db.Entities.RevenuEntity) As Long

            Dim id As Long = 0

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "INSERT INTO revenus (id, montant, reglement,memo, date_revenu, id_employe, id_classification_revenu, id_type_agr, id_devise, id_recu, activite_financier_id) VALUES (@id, @montant, @reglement, @memo, @date_revenu, @id_employe, @id_classification, @id_type, @id_devise, @id_recu, @aid)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", revenu.Id)
                cmd.Parameters.AddWithValue("@montant", revenu.Montant)
                cmd.Parameters.AddWithValue("@reglement", revenu.Reglement)
                cmd.Parameters.AddWithValue("@memo", revenu.Memo)
                cmd.Parameters.AddWithValue("@date_revenu", revenu.Date_revenu)
                cmd.Parameters.AddWithValue("@id_employe", revenu.Employe.Id)
                cmd.Parameters.AddWithValue("@id_classification", revenu.Classification.Id)
                cmd.Parameters.AddWithValue("@id_type", revenu.Type.Id)
                cmd.Parameters.AddWithValue("@id_devise", revenu.Devise.id)
                cmd.Parameters.AddWithValue("@id_recu", revenu.RecuDe.Id)
                cmd.Parameters.AddWithValue("@aid", revenu.activite_financier_id)
                cmd.ExecuteNonQuery()

                id = cmd.LastInsertedId

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

            Return id

        End Function

        Public Function GetByAll(ByVal annee As String, ByVal mois As String, ByVal type As String) As List(Of EntraideBundle.Db.Entities.RevenuEntity)
            Dim revenu As List(Of EntraideBundle.Db.Entities.RevenuEntity) = New List(Of EntraideBundle.Db.Entities.RevenuEntity)
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT revenus.id,  type_agrs.nom, CONCAT_WS(' ', employes.nom, employes.prenom), revenus.montant  , (SELECT CONCAT_WS(' ', employes.nom, employes.prenom) FROM employes WHERE employes.id=revenus.id_recu), revenus.reglement, (SELECT nom FROM devises WHERE devises.id=revenus.id_devise),  revenus.memo, (SELECT nom FROM classification_revenus WHERE classification_revenus.id= revenus.id_classification_revenu), revenus.date_revenu, revenus.activite_financier_id FROM employes, revenus, type_agrs, devises, classification_revenus WHERE YEAR(revenus.date_revenu) = '" & annee & "' AND MONTH(revenus.date_revenu) = '" & mois & "' AND type_agrs.id = '" & type & "' AND revenus.id_type_agr = type_agrs.id AND revenus.id_employe = employes.id"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New EntraideBundle.Db.Entities.RevenuEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Type.Nom = result.GetValue(1).ToString
                    entity.Employe.Nom = result.GetValue(2).ToString
                    entity.Montant = result.GetValue(3).ToString
                    entity.RecuDe.Nom = result.GetValue(4).ToString
                    entity.Reglement = result.GetValue(5).ToString
                    entity.Devise.nom = result.GetValue(6).ToString
                    entity.Memo = result.GetValue(7).ToString
                    entity.Classification.Nom = result.GetValue(8).ToString
                    entity.Date_revenu = result.GetDateTime(9)
                    entity.activite_financier_id = result.GetValue(10).ToString

                    revenu.Add(entity)

                End While

                If result.RecordsAffected = 0 Then
                    MsgBox("Not found")
                End If
                result.Close()
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

            Return revenu
        End Function

        Public Function GetByMonthYear(ByVal annee As String, ByVal mois As String) As List(Of EntraideBundle.Db.Entities.RevenuEntity)
            Dim revenu As List(Of EntraideBundle.Db.Entities.RevenuEntity) = New List(Of EntraideBundle.Db.Entities.RevenuEntity)
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT revenus.id,  type_agrs.nom, CONCAT_WS(' ', employes.nom, employes.prenom), revenus.montant  , (SELECT CONCAT_WS(' ', employes.nom, employes.prenom) FROM employes WHERE employes.id=revenus.id_recu), revenus.reglement, (SELECT nom FROM devises WHERE devises.id=revenus.id_devise),  revenus.memo, (SELECT nom FROM classification_revenus WHERE classification_revenus.id= revenus.id_classification_revenu), revenus.date_revenu, revenus.activite_financier_id FROM employes, revenus, type_agrs, devises, classification_revenus WHERE YEAR(revenus.date_revenu) = '" & annee & "' AND MONTH(revenus.date_revenu) = '" & mois & "' AND revenus.id_type_agr = type_agrs.id AND revenus.id_employe = employes.id"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New EntraideBundle.Db.Entities.RevenuEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Type.Nom = result.GetValue(1).ToString
                    entity.Employe.Nom = result.GetValue(2).ToString
                    entity.Montant = result.GetValue(3).ToString
                    entity.RecuDe.Nom = result.GetValue(4).ToString
                    entity.Reglement = result.GetValue(5).ToString
                    entity.Devise.nom = result.GetValue(6).ToString
                    entity.Memo = result.GetValue(7).ToString
                    entity.Classification.Nom = result.GetValue(8).ToString
                    entity.Date_revenu = result.GetDateTime(9)
                    entity.activite_financier_id = result.GetValue(10).ToString

                    revenu.Add(entity)

                End While

                If result.RecordsAffected = 0 Then
                    MsgBox("Not found")
                End If
                result.Close()
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

            Return revenu
        End Function


        ''' <summary>
        ''' Fonction Mise à jour revenu
        ''' </summary>
        ''' <param name="revenu"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UpdateRevenu(ByVal revenu As EntraideBundle.Db.Entities.RevenuEntity) As Long

            Dim id As Long = 0

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "UPDATE revenus SET montant = @montant , reglement = @reglement, memo =@memo, date_revenu = @date_revenu, id_employe= @id_employe, id_classification_revenu=@id_classification , id_type_agr = @id_type, id_devise = @id_devise, id_recu = @id_recu, activite_financier_id = @aid WHERE id = @id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", revenu.Id)
                cmd.Parameters.AddWithValue("@montant", revenu.Montant)
                cmd.Parameters.AddWithValue("@reglement", revenu.Reglement)
                cmd.Parameters.AddWithValue("@memo", revenu.Memo)
                cmd.Parameters.AddWithValue("@date_revenu", revenu.Date_revenu)
                cmd.Parameters.AddWithValue("@id_employe", revenu.Employe.Id)
                cmd.Parameters.AddWithValue("@id_classification", revenu.Classification.Id)
                cmd.Parameters.AddWithValue("@id_type", revenu.Type.Id)
                cmd.Parameters.AddWithValue("@id_devise", revenu.Devise.id)
                cmd.Parameters.AddWithValue("@id_recu", revenu.RecuDe.Id)
                cmd.Parameters.AddWithValue("@aid", revenu.activite_financier_id)
                cmd.ExecuteNonQuery()


                id = revenu.Id

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


            Return id
        End Function

        Public Function GetByType(ByVal date_du As Date, ByVal date_au As Date, ByVal type As String) As List(Of EntraideBundle.Db.Entities.RevenuEntity)

            Dim revenu As List(Of EntraideBundle.Db.Entities.RevenuEntity) = New List(Of EntraideBundle.Db.Entities.RevenuEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT * FROM (SELECT revenus.id, type_agrs.nom AS type, CONCAT_WS(' ', employes.prenom, employes.nom) AS nom_manager, revenus.montant, devises.nom AS devise, revenus.memo, revenus.reglement, classification_revenus.nom AS classification, revenus.date_revenu, type_agrs.id AS type_id FROM revenus INNER JOIN employes ON revenus.id_employe = employes.id INNER JOIN devises ON revenus.id_devise = devises.id  INNER JOIN classification_revenus ON revenus.id_classification_revenu = classification_revenus.id INNER JOIN type_agrs ON revenus.id_type_agr = type_agrs.id) AS A NATURAL LEFT JOIN (SELECT revenus.id, CONCAT_WS(' ', employes.prenom, employes.nom) AS par FROM revenus INNER JOIN employes ON revenus.id_recu = employes.id) AS B WHERE DATE(date_revenu) BETWEEN '" & Util.GetDateToMysqlFormat(date_du) & "' AND '" & Util.GetDateToMysqlFormat(date_au) & "' AND type_id = '" & type & "'"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim entity As New EntraideBundle.Db.Entities.RevenuEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Type.Nom = result.GetValue(1).ToString
                    entity.Employe.Nom = result.GetValue(2).ToString
                    entity.Montant = result.GetValue(3).ToString
                    entity.Devise.nom = result.GetValue(4).ToString
                    entity.Memo = result.GetValue(5).ToString

                    entity.Reglement = result.GetValue(6).ToString
                    entity.Classification.Nom = result.GetValue(7).ToString
                    entity.Date_revenu = result.GetDateTime(8)
                    entity.RecuDe.Nom = result.GetValue(10).ToString

                    revenu.Add(entity)
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

            Return revenu
        End Function

        Public Function GetByInterval(ByVal date_du As Date, ByVal date_au As Date) As List(Of EntraideBundle.Db.Entities.RevenuEntity)

            Dim revenu As List(Of EntraideBundle.Db.Entities.RevenuEntity) = New List(Of EntraideBundle.Db.Entities.RevenuEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT * FROM (SELECT revenus.id, type_agrs.nom AS type, CONCAT_WS(' ', employes.prenom, employes.nom) AS nom_manager, revenus.montant, devises.nom AS devise, revenus.memo, revenus.reglement, classification_revenus.nom AS classification, revenus.date_revenu, type_agrs.id AS type_id FROM revenus INNER JOIN employes ON revenus.id_employe = employes.id INNER JOIN devises ON revenus.id_devise = devises.id  INNER JOIN classification_revenus ON revenus.id_classification_revenu = classification_revenus.id INNER JOIN type_agrs ON revenus.id_type_agr = type_agrs.id) AS A NATURAL LEFT JOIN (SELECT revenus.id, CONCAT_WS(' ', employes.prenom, employes.nom) AS par FROM revenus INNER JOIN employes ON revenus.id_recu = employes.id) AS B WHERE DATE(date_revenu) BETWEEN '" & Util.GetDateToMysqlFormat(date_du) & "' AND '" & Util.GetDateToMysqlFormat(date_au) & "' "


                Dim result As MySqlDataReader = Nothing

                result = cmd.ExecuteReader

                While result.Read
                    Dim entity As New EntraideBundle.Db.Entities.RevenuEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Type.Nom = result.GetValue(1).ToString
                    entity.Employe.Nom = result.GetValue(2).ToString
                    entity.Montant = result.GetValue(3).ToString
                    entity.Devise.nom = result.GetValue(4).ToString
                    entity.Memo = result.GetValue(5).ToString

                    entity.Reglement = result.GetValue(6).ToString
                    entity.Classification.Nom = result.GetValue(7).ToString
                    entity.Date_revenu = result.GetDateTime(8)
                    entity.RecuDe.Nom = result.GetValue(10).ToString

                    revenu.Add(entity)
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

            Return revenu
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
                adapter.FillAsync(data_source.Revenu)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
            End Try
        End Sub

    End Class
End Namespace
