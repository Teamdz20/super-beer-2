Imports EntraideBundle.Db.Entities
Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class DepensesTable

#Region "CONSTANTS"
        Private Const TABLE_FIELDS As String = "depenses.id AS depense_id, depenses.created AS depense_created, depenses.type_depense_id AS depense_type_depense_id, depenses.departement_id AS depense_departement_id, depenses.code_depense_id AS depense_code_depense_id, depenses.manager_id AS depense_manager_id, depenses.montant AS depense_montant, depenses.devise_id AS depense_devise_id, depenses.beneficiere_id AS depense_beneficiere_id, depenses.motif_depense AS depense_motif_depense, depenses.realiser_par AS depense_realiser_par, depenses.code_demande AS depense_code_demande, depenses.memo AS depense_memo, type_depenses.id AS type_depense_id, type_depenses.nom AS type_depense_nom, departements.id AS departement_id, departements.nom AS departement_nom, departements.id_util AS departement_id_util, code_depenses.id AS code_depense_id, code_depenses.nom AS code_depense_nom, code_depenses.code AS code_depense_code, devises.id AS devise_id, devises.nom AS devise_nom, programmes.id AS programme_id, programmes.nom AS programme_nom, programmes.code AS programme_code"


        Private Const JOIN_TABLE As String = "NATURAL LEFT JOIN (SELECT employes.id AS depense_manager_id, CONCAT_WS(' ', employes.nom, employes.prenom) AS nom_manager FROM employes) AS B NATURAL LEFT JOIN (SELECT employes.id AS depense_beneficiere_id, CONCAT_WS(' ', employes.nom, employes.prenom) AS nom_beneficiaire FROM employes) AS C NATURAL LEFT JOIN (SELECT employes.id AS depense_realiser_par, CONCAT_WS(' ', employes.nom, employes.prenom) AS nom_realisateur FROM employes) AS D"
#End Region

        ''' <summary>
        ''' Data set filled for repport
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared data_set As DataSetTables


        ''' <summary>
        ''' Find by code
        ''' </summary>
        ''' <param name="code_depense"></param>
        ''' <param name="fromUpdate"></param>
        ''' <param name="year"></param>
        ''' <param name="month"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByCodeDepense(ByVal code_depense As String, Optional fromUpdate As Boolean = False, Optional year As String = "", Optional month As String = "") As List(Of DepenseEntity)

            Dim depenses As List(Of DepenseEntity) = New List(Of DepenseEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                Dim sql As String = "SELECT " & DepensesTable.TABLE_FIELDS & " FROM depenses INNER JOIN departements ON depenses.departement_id = departements.id INNER JOIN type_depenses ON depenses.type_depense_id = type_depenses.id INNER JOIN code_depenses ON depenses.code_depense_id = code_depenses.id INNER JOIN devises ON depenses.devise_id = devises.id WHERE code_depenses.code LIKE @code "
                
                If fromUpdate Then
                    sql &= " AND YEAR(depenses.created) = @year AND MONTH(depenses.created) = @month"
                End If

                cmd.CommandText = sql
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@code", code_depense)

                If fromUpdate Then
                    cmd.Parameters.AddWithValue("@year", year)
                    cmd.Parameters.AddWithValue("@month", month)
                End If

                Dim result As MySqlDataReader = cmd.ExecuteReader

                Dim empTable As EmployesTable = New EmployesTable

                While result.Read
                    Dim theEntity As New DepenseEntity(result)
                    theEntity.Manager = empTable.GetById(theEntity.manager_id, Database.NewConnecion)
                    theEntity.Beneficiaire = empTable.GetById(theEntity.beneficiere_id, Database.NewConnecion)
                    theEntity.Realisateur = empTable.GetById(theEntity.realiser_par, Database.NewConnecion)
                    depenses.Add(theEntity)
                End While
                result.Close()
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


            Return depenses
        End Function

        ''' <summary>
        ''' Find by type depenses
        ''' </summary>
        ''' <param name="type_id"></param>
        ''' <param name="fromUpdate"></param>
        ''' <param name="year"></param>
        ''' <param name="month"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByTypeDepense(ByVal type_id As String, Optional fromUpdate As Boolean = False, Optional year As String = "", Optional month As String = "") As List(Of DepenseEntity)

            Dim depenses As List(Of DepenseEntity) = New List(Of DepenseEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                Dim sql As String = "SELECT * FROM (SELECT " & DepensesTable.TABLE_FIELDS & " FROM depenses INNER JOIN departements ON depenses.departement_id = departements.id INNER JOIN type_depenses ON depenses.type_depense_id = type_depenses.id INNER JOIN code_depenses ON depenses.code_depense_id = code_depenses.id INNER JOIN devises ON depenses.devise_id = devises.id INNER JOIN programmes ON depenses.programme_id = programmes.id WHERE depenses.type_depense_id LIKE @type_id) AS A " & JOIN_TABLE

                If fromUpdate Then
                    sql &= " AND YEAR(depenses.created) = @year AND MONTH(depenses.created) = @month"
                End If

                cmd.CommandText = sql
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@type_id", type_id)

                If fromUpdate Then
                    cmd.Parameters.AddWithValue("@year", year)
                    cmd.Parameters.AddWithValue("@month", month)
                End If

                Dim result As MySqlDataReader = cmd.ExecuteReader

                Dim empTable As EmployesTable = New EmployesTable

                While result.Read
                    Dim theEntity As New DepenseEntity(result)
                    theEntity.Manager = empTable.GetById(theEntity.manager_id, Database.NewConnecion)
                    theEntity.Beneficiaire = empTable.GetById(theEntity.beneficiere_id, Database.NewConnecion)
                    theEntity.Realisateur = empTable.GetById(theEntity.realiser_par, Database.NewConnecion)
                    depenses.Add(theEntity)
                End While
                result.Close()
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


            Return depenses
        End Function
        ''' <summary>
        ''' Find by date
        ''' </summary>
        ''' <param name="year"></param>
        ''' <param name="month"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByYearMonth(year As String, month As String) As List(Of DepenseEntity)

            Dim depenses As List(Of DepenseEntity) = New List(Of DepenseEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                Dim sql As String = "SELECT " & DepensesTable.TABLE_FIELDS & " FROM depenses INNER JOIN departements ON depenses.departement_id = departements.id INNER JOIN type_depenses ON depenses.type_depense_id = type_depenses.id INNER JOIN code_depenses ON depenses.code_depense_id = code_depenses.id INNER JOIN devises ON depenses.devise_id = devises.id INNER JOIN programmes ON depenses.programme_id = programmes.id WHERE YEAR(depenses.created) = @year AND MONTH(depenses.created) = @month "
                cmd.CommandText = sql
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@year", year)
                cmd.Parameters.AddWithValue("@month", month)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                Dim empTable As EmployesTable = New EmployesTable

                While result.Read
                    Dim theEntity As New DepenseEntity(result)
                    theEntity.Manager = empTable.GetById(theEntity.manager_id)
                    theEntity.Beneficiaire = empTable.GetById(theEntity.beneficiere_id)
                    theEntity.Realisateur = empTable.GetById(theEntity.realiser_par)
                    depenses.Add(theEntity)
                End While
                result.Close()
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

            Return depenses
        End Function



        ''' <summary>
        ''' Find by date
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByInterval(du As Date, au As Date) As List(Of DepenseEntity)

            Dim depenses As List(Of DepenseEntity) = New List(Of DepenseEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                Dim sql As String = "SELECT * FROM (SELECT " & DepensesTable.TABLE_FIELDS & " FROM depenses INNER JOIN departements ON depenses.departement_id = departements.id INNER JOIN type_depenses ON depenses.type_depense_id = type_depenses.id INNER JOIN code_depenses ON depenses.code_depense_id = code_depenses.id INNER JOIN devises ON depenses.devise_id = devises.id INNER JOIN programmes ON depenses.programme_id = programmes.id WHERE DATE(depenses.created) BETWEEN @du AND @au) AS A " & JOIN_TABLE

                cmd.CommandText = sql
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))

                Dim result As MySqlDataReader = cmd.ExecuteReader

                Dim empTable As EmployesTable = New EmployesTable

                While result.Read
                    Dim theEntity As New DepenseEntity(result)
                    theEntity.Manager = empTable.GetById(theEntity.manager_id)
                    theEntity.Beneficiaire = empTable.GetById(theEntity.beneficiere_id)
                    theEntity.Realisateur = empTable.GetById(theEntity.realiser_par)
                    depenses.Add(theEntity)
                End While
                result.Close()
                FillDataSet(cmd)
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


            Return depenses
        End Function



        ''' <summary>
        ''' Get by interval and type depenses
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <param name="type_id"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByIntervalType(du As Date, au As Date, type_id As String) As List(Of DepenseEntity)

            Dim depenses As List(Of DepenseEntity) = New List(Of DepenseEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                Dim sql As String = "SELECT * FROM (SELECT " & DepensesTable.TABLE_FIELDS & " FROM depenses INNER JOIN departements ON depenses.departement_id = departements.id INNER JOIN type_depenses ON depenses.type_depense_id = type_depenses.id INNER JOIN code_depenses ON depenses.code_depense_id = code_depenses.id INNER JOIN devises ON depenses.devise_id = devises.id INNER JOIN programmes ON depenses.programme_id = programmes.id WHERE (DATE(depenses.created) BETWEEN @du AND @au) AND depenses.type_depense_id = @tid) AS A " & JOIN_TABLE

                cmd.CommandText = sql
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@tid", type_id)
                Dim result As MySqlDataReader = cmd.ExecuteReader

                Dim empTable As EmployesTable = New EmployesTable

                While result.Read
                    Dim theEntity As New DepenseEntity(result)
                    theEntity.Manager = empTable.GetById(theEntity.manager_id)
                    theEntity.Beneficiaire = empTable.GetById(theEntity.beneficiere_id)
                    theEntity.Realisateur = empTable.GetById(theEntity.realiser_par)
                    depenses.Add(theEntity)
                End While
                result.Close()
                FillDataSet(cmd)
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


            Return depenses
        End Function


        Public Function GetAll() As List(Of DepenseEntity)

            Dim depenses As List(Of DepenseEntity) = New List(Of DepenseEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                Dim sql As String = "SELECT * FROM (SELECT " & DepensesTable.TABLE_FIELDS & " FROM depenses INNER JOIN departements ON depenses.departement_id = departements.id INNER JOIN type_depenses ON depenses.type_depense_id = type_depenses.id INNER JOIN code_depenses ON depenses.code_depense_id = code_depenses.id INNER JOIN devises ON depenses.devise_id = devises.id INNER JOIN programmes ON depenses.programme_id = programmes.id) AS A " & JOIN_TABLE

                cmd.CommandText = sql

                Dim result As MySqlDataReader = cmd.ExecuteReader

                Dim empTable As EmployesTable = New EmployesTable

                While result.Read
                    Dim theEntity As New DepenseEntity(result)
                    theEntity.Manager = empTable.GetById(theEntity.manager_id)
                    theEntity.Beneficiaire = empTable.GetById(theEntity.beneficiere_id)
                    theEntity.Realisateur = empTable.GetById(theEntity.realiser_par)
                    depenses.Add(theEntity)
                End While
                result.Close()
                FillDataSet(cmd)
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


            Return depenses
        End Function


        ''' <summary>
        ''' Filling dataTable to report
        ''' </summary>
        ''' <param name="cmd">request command</param>
        ''' <remarks></remarks>
        Private Sub FillDataSet(ByRef cmd As MySqlCommand)
            Try
                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                data_set = New DataSetTables
                adapter.Fill(data_set.Depeses)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Fatal error, unable to fillig dataTable. report maybe unavailable : " & ex.Message, 2)
            End Try
        End Sub

    End Class

End Namespace
