Imports EntraideBundle.Db
Imports EntraideBundle.Db.Entities
Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class DonsTable

#Region "CONSTANTS"
        Private Const TABLE_FIELDS As String = "dons.id AS don_id, dons.activite_financier_id AS don_activite_financier_id, dons.departement_id AS don_departement_id, dons.donneur_id AS don_donneur_id,dons.type_don AS don_type_don,dons.materiel_id AS don_materiel_id,dons.mode_reception AS don_mode_reception,dons.montant_recu AS don_montant_recu,dons.montant_sollicite AS don_montant_sollicite,dons.code AS don_code,dons.non_sollicite AS don_non_sollicite,dons.numero_cheque AS don_numero_cheque,dons.restriction AS don_restriction,dons.note_restriction AS don_note_restriction,dons.activite_menee AS don_activite_menee,dons.created AS don_created,dons.user_id AS don_user_id, users.id AS user_id, users.username AS user_username, donneurs.id AS donneur_id, donneurs.date AS donneur_date, donneurs.nom AS donneur_nom, donneurs.code AS donneur_code, donneurs.adresse AS donneur_adresse, donneurs.email AS donneur_email, donneurs.tel1 AS donneur_tel1, donneurs.tel2 AS donneur_tel2, donneurs.categorie_donneur_id AS donneur_categorie_donneur_id, donneurs.site_internet AS donneur_site_internet, donneurs.restriction AS donneur_restriction, donneurs.periode_sollicitation AS donneur_periode_sollicitation, donneurs.note_sollicitation AS donneur_note_sollicitation, donneurs.nom_representant AS donneur_nom_representant, donneurs.poste AS donneur_poste, donneurs.user_id AS donneur_user_id, donneurs.type_don AS donneur_type_don, activite_financiers.id AS activite_financier_id, activite_financiers.nom AS activite_financier_nom, activite_financiers.code AS activite_financier_code, departements.id AS departement_id, departements.nom AS departement_nom, materiels.id AS materiel_id, materiels.libelle AS materiel_libelle"
#End Region

        ''' <summary>
        ''' DataSet used for report
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared data_set As DataSetTables

        ''' <summary>
        ''' Get all dons
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetAll() As List(Of DonEntity)

            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id"
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function


        ''' <summary>
        ''' Default liste on report liste
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetDefault() As List(Of DonEntity)

            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE DATE(dons.created) = DATE(NOW())"
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function


        ''' <summary>
        ''' Get by date interval
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByInterval(ByVal du As Date, ByVal au As Date) As List(Of DonEntity)

            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE DATE(dons.created) BETWEEN @du AND @au"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function

        ''' <summary>
        ''' Get By Date
        ''' </summary>
        ''' <param name="dt"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDate(ByVal dt As Date) As List(Of DonEntity)
            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE DATE(dons.created) = '" & Util.GetDateToMysqlFormat(dt) & "'"
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function

        ''' <summary>
        ''' Get By type
        ''' </summary>
        ''' <param name="type_don"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByType(ByVal type_don As String) As List(Of DonEntity)
            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE dons.type_don = @tid"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@tid", type_don)
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function


        ''' <summary>
        ''' Get by type
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <param name="type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByType(ByVal du As Date, ByVal au As Date, ByVal type As String) As List(Of DonEntity)

            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE (DATE(dons.created) BETWEEN @du AND @au) AND dons.type_don = @type"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@type", type)

                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function
        ''' <summary>
        ''' Get by mode paiement
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <param name="mode"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByModePaiement(ByVal du As Date, ByVal au As Date, ByVal mode As String) As List(Of DonEntity)

            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE (DATE(dons.created) BETWEEN @du AND @au) AND dons.mode_reception = @mode"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@mode", mode)

                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function
        Public Function GetByTypeMode(ByVal du As Date, ByVal au As Date, ByVal type As String, ByVal mode As String) As List(Of DonEntity)

            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE (DATE(dons.created) BETWEEN @du AND @au) AND (dons.mode_reception = @mode AND dons.type_don = @type)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@mode", mode)
                cmd.Parameters.AddWithValue("@type", type)

                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function



        ''' <summary>
        ''' Get By type
        ''' </summary>
        ''' <param name="donneur_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDonneur(ByVal donneur_id As String) As List(Of DonEntity)
            Dim dons As List(Of DonEntity) = New List(Of DonEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE dons.donneur_id = @tid"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@tid", donneur_id)
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim theEntity As DonEntity = New DonEntity(result)
                    dons.Add(theEntity)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function


        ''' <summary>
        ''' Get By Id
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetById(ByVal id As String) As DonEntity
            Dim dons As DonEntity = New DonEntity

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & DonsTable.TABLE_FIELDS & " FROM dons INNER JOIN users ON dons.user_id = users.id INNER JOIN donneurs ON dons.donneur_id = donneurs.id INNER JOIN activite_financiers ON dons.activite_financier_id = activite_financiers.id INNER JOIN departements ON dons.departement_id = departements.id LEFT JOIN materiels ON dons.materiel_id = materiels.id WHERE dons.id = @id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", id)
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    dons = New DonEntity(result)
                End While
                result.Close()
                FillDataTable(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.Message, 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return dons
        End Function

        Private Sub FillDataTable(ByRef cmd As MySqlCommand)
            Try
                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                data_set = New DataSetTables
                adapter.FillAsync(data_set.Dons)
                adapter.Dispose()
            Catch ex As Exception

            End Try
        End Sub

    End Class
End Namespace