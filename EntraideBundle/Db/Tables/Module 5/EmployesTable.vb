Imports EntraideBundle.Db.Entities
Imports EntraideBundle.Db
Imports MySql.Data.MySqlClient

Namespace Db.Tables

    Public Class EmployesTable

        Public Shared active_query As String = ""

        Public Shared data_source As DataSetTables = Nothing

#Region "Constants"

        ''' <summary>
        ''' Sql request to populate comboBox
        ''' </summary>
        ''' <remarks></remarks>
        Public Const SqlComboDep As String = "SELECT id, nom FROM departements"

        ''' <summary>
        ''' Primary Key
        ''' </summary>
        ''' <remarks></remarks>
        Public Const P_K As String = "id"

        ''' <summary>
        ''' Display name
        ''' </summary>
        ''' <remarks></remarks>
        Public Const D_N As String = "nom"


        Public Const SQL_COMBO As String = "SELECT employes.id AS id, CONCAT_WS(' ', employes.nom, employes.prenom) AS nom FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id"


        Private Const BASE_FIELDS As String = "employes.id AS emp_id, employes.code AS emp_code, employes.nom AS emp_nom, employes.prenom AS emp_prenom, employes.sexe AS emp_sexe, employes.situation_matrimonial AS emp_situation_matrimonial, employes.nb_enfant AS emp_nb_enfant, employes.date_naissance AS emp_date_naissance, employes.lieu_naissance AS emp_lieu_naissance, employes.nationnalite AS emp_nationnalite, employes.bp AS emp_bp, employes.tel1 AS emp_tel1, employes.tel2 AS emp_tel2, employes.email AS emp_email, employes.religion AS emp_religion, employes.precision_autre AS emp_precision_autre, employes.delis AS emp_delis, employes.detail_delis AS emp_detail_delis, employes.recu_formation AS emp_recu_formation, employes.type_formation_recu AS emp_type_formation_recu, employes.niveau_etude AS emp_niveau_etude, employes.diplome AS emp_diplome, employes.ecole AS emp_ecole, employes.nom_contact_urgent AS emp_nom_contact_urgent, employes.adresse_contact_urgent AS emp_adresse_contact_urgent, employes.phone_contact_urgent AS emp_phone_contact_urgent, employes.email_contact_urgent AS emp_email_contact_urgent, employes.competance_fr AS emp_competance_fr, employes.competance_en AS emp_competance_en, employes.competance_information AS emp_competance_information, employes.autres_competances AS emp_autres_competances, employes.note_exp_professionnelle AS emp_note_exp_professionnelle, employes.departement_id AS emp_departement_id, employes.poste_id AS emp_poste_id, employes.debut_contract AS emp_debut_contract, employes.fin_contract AS emp_fin_contract, employes.date_enregistrement AS emp_date_enregistrement, employes.adresse AS emp_adresse, departements.id AS departement_id, departements.nom AS departement_nom, postes.id AS poste_id, postes.nom AS poste_nom, salaires.id AS salaire_id, salaires.term_paiement AS salaire_term_paiement, salaires.taux AS salaire_taux, salaires.nb_jour_travail AS salaire_nb_jour_travail, salaires.salaire AS salaire_salaire, contrats.id AS contrat_id, contrats.employe_id AS contrat_employe_id, contrats.departement_id AS contrat_departement_id, contrats.salaire_id AS contrat_salaire_id, contrats.poste_id AS contrat_poste_id, contrats.date_debut AS contrat_date_debut, contrats.date_fin AS contrat_date_fin, contrats.nb_heure_travail AS contrat_nb_heure_travail, contrats.classification AS contrat_classification, contrats.superviseur AS contrat_superviseur"

#End Region


        ''' <summary>
        ''' Recherche par code
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetById(ByVal id As String, Optional ByRef connection As MySqlConnection = Nothing) As EmployeEntity
            Dim employees As New EmployeEntity

            Try

                If IsNothing(connection) Then
                    connection = Database.GetConnection
                End If

                Dim cmd As MySqlCommand = connection.CreateCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE employes.id = @emp_id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@emp_id", id)
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    employees = New EmployeEntity(result)
                End While
                result.Close()
                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                Try
                    connection.Close()
                Catch ex As Exception

                End Try
                GC.Collect()
            End Try

            Return employees
        End Function

        ''' <summary>
        ''' Recherche par code
        ''' </summary>
        ''' <param name="code"></param>
        ''' <returns></returns>za
        ''' <remarks></remarks>
        Public Function GetByCode(ByVal code As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE employes.code LIKE @emp_code"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@emp_code", code)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)

                    employees.Add(employe)
                End While
                result.Close()
                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function


        ''' <summary>
        ''' Recherche par code
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <param name="code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByCode(ByVal du As Date, ByVal au As Date, ByVal code As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE (employes.code LIKE @emp_code) AND (DATE(employes.date_enregistrement) BETWEEN @du AND @au)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@emp_code", code)
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)

                    employees.Add(employe)
                End While
                result.Close()
                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function

        ''' <summary>
        ''' Recherche par nom
        ''' </summary>
        ''' <param name="needle"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByname(ByVal needle As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE CONCAT_WS(' ', employes.nom, employes.prenom) LIKE '" & Util.E(needle) & "%'"
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)

                    employees.Add(employe)
                End While

                result.Close()
                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function


        Public Function GetByname(ByVal du As Date, ByVal au As Date, ByVal needle As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE (CONCAT_WS(' ', employes.nom, employes.prenom) LIKE '" & Util.E(needle) & "%') AND (DATE(employes.date_enregistrement) BETWEEN '" & Util.GetDateToMysqlFormat(du) & "' AND '" & Util.GetDateToMysqlFormat(au) & "')"
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)
                    employees.Add(employe)
                End While

                result.Close()
                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function


        ''' <summary>
        ''' Recherche par departement
        ''' </summary>
        ''' <param name="needle"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDepartement(ByVal needle As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE contrats.departement_id = @depid"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@depid", needle)
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)
                    employees.Add(employe)
                End While
                result.Close()
                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function


        ''' <summary>
        ''' Recherche par nom et departement
        ''' </summary>
        ''' <param name="name"></param>
        ''' <param name="depid"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByNameDepartement(ByVal name As String, ByVal depid As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE CONCAT_WS(' ', employes.nom, employes.prenom) LIKE '" & Util.E(name) & "%' AND contrats.departement_id = @depid"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@depid", depid)
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)
                    employees.Add(employe)
                End While

                result.Close()

                FillDataSource(cmd)

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function

        ''' <summary>
        ''' Save a new employe
        ''' </summary>
        ''' <param name="employe"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Save(ByVal employe As EmployeEntity) As Long

            Return employe.Save

        End Function

        ''' <summary>
        ''' Lectures de tous les employes
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetAll() As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id"

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)
                    employees.Add(employe)
                End While

                result.Close()

                FillDataSource(cmd)

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function


        ''' <summary>
        ''' Get by classification
        ''' </summary>
        ''' <param name="needle"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByClassification(ByVal needle As String) As List(Of EmployeEntity)
            Dim employees As New List(Of EmployeEntity)
            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & EmployesTable.BASE_FIELDS & " FROM employes INNER JOIN contrats ON employes.id = contrats.employe_id INNER JOIN departements ON contrats.departement_id = departements.id INNER JOIN postes ON contrats.poste_id = postes.id INNER JOIN salaires ON contrats.salaire_id = salaires.id WHERE (contrats.classification = @class)"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@class", needle)
                'cmd.Parameters.AddWithValue("@du", Util.DateToMySQLFormat(du))
                'cmd.Parameters.AddWithValue("@au", Util.DateToMySQLFormat(au))
                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim employe As New EmployeEntity(result)
                    employees.Add(employe)
                End While

                result.Close()

                FillDataSource(cmd)
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnees", 2)
                End If
            Finally
                Database.CloseConnection()
                GC.Collect()
            End Try

            Return employees
        End Function


        ''' <summary>
        ''' EntityFactory
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function NewEntity() As EmployeEntity
            Return New EmployeEntity
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
                adapter.FillAsync(data_source.Employes)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
            End Try
        End Sub

    End Class
End Namespace