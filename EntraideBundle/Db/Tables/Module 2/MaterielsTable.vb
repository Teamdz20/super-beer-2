Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db.Entities

Namespace Db.Tables
    Public Class MaterielsTable

#Region "CONSTANTS"
        Private Const TABLE_FIELDS As String = "materiels.id AS materiel_id, materiels.libelle AS materiel_libelle, materiels.type_materiel_id AS materiel_type_materiel_id, materiels.code AS materiel_code, materiels.marque AS materiel_marque, materiels.description AS materiel_description, materiels.num_facture AS materiel_num_facture, materiels.prix_achat AS materiel_prix_achat, materiels.mode_obtention AS materiel_mode_obtention, materiels.ref_obtention_id AS materiel_ref_obtention_id, materiels.departement_id AS materiel_departement_id, materiels.activite_id AS materiel_activite_id, materiels.employe_id AS materiel_employe_id, materiels.amortissement_necessaire AS materiel_amortissement_necessaire, materiels.annee_amortissement AS materiel_annee_amortissement, materiels.montant_par_an AS materiel_montant_par_an, materiels.created AS materiel_created, materiels.neuf AS materiel_neuf, materiels.deja_utiliser AS materiel_deja_utiliser, materiels.tres_bon_etat AS materiel_tres_bon_etat, materiels.avec_defaut AS materiel_avec_defaut, materiels.mauvaise_etat AS materiel_mauvaise_etat, materiels.activite AS materiel_activite, departements.id AS departement_id, departements.nom AS departement_nom, departements.id_util AS departement_id_util, employes.id AS emp_id, employes.code AS emp_code, employes.nom AS emp_nom, employes.prenom AS emp_prenom, employes.sexe AS emp_sexe, employes.situation_matrimonial AS emp_situation_matrimonial, employes.nb_enfant AS emp_nb_enfant, employes.date_naissance AS emp_date_naissance, employes.lieu_naissance AS emp_lieu_naissance, employes.nationnalite AS emp_nationnalite, employes.bp AS emp_bp, employes.tel1 AS emp_tel1, employes.tel2 AS emp_tel2, employes.email AS emp_email, employes.religion AS emp_religion, employes.precision_autre AS emp_precision_autre, employes.delis AS emp_delis, employes.detail_delis AS emp_detail_delis, employes.recu_formation AS emp_recu_formation, employes.type_formation_recu AS emp_type_formation_recu, employes.niveau_etude AS emp_niveau_etude, employes.diplome AS emp_diplome, employes.ecole AS emp_ecole, employes.nom_contact_urgent AS emp_nom_contact_urgent, employes.adresse_contact_urgent AS emp_adresse_contact_urgent, employes.phone_contact_urgent AS emp_phone_contact_urgent, employes.email_contact_urgent AS emp_email_contact_urgent, employes.competance_fr AS emp_competance_fr, employes.competance_en AS emp_competance_en, employes.competance_information AS emp_competance_information, employes.autres_competances AS emp_autres_competances, employes.note_exp_professionnelle AS emp_note_exp_professionnelle, employes.departement_id AS emp_departement_id, employes.poste_id AS emp_poste_id, employes.adresse AS emp_adresse, employes.debut_contract AS emp_debut_contract, employes.fin_contract AS emp_fin_contract, employes.date_enregistrement AS emp_date_enregistrement, type_materiels.id AS type_materiel_id, type_materiels.nom AS type_materiel_nom"


        Public Const TYPE_DEPENSE_ID As Integer = 3
#End Region

        Public Shared data_set As DataSetTables

        ''' <summary>
        ''' Search by specific date
        ''' </summary>
        ''' <param name="created"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDate(ByVal created As Date) As List(Of MaterielEntity)

            Dim liste As New List(Of MaterielEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                cmd.CommandText = "SELECT " & TABLE_FIELDS & " FROM materiels INNER JOIN departements ON materiels.departement_id = departements.id INNER JOIN type_materiels ON materiels.type_materiel_id = type_materiels.id INNER JOIN employes ON materiels.employe_id = employes.id WHERE DATE(materiels.created) = @d ORDER BY materiels.created DESC"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@d", Util.GetDateToMysqlFormat(created))
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim mat As MaterielEntity = New MaterielEntity(result)
                    If mat.mode_obtention = "DON" Then
                        Dim donT As DonsTable = New DonsTable
                        mat.Don = donT.GetById(mat.ref_obtention_id)
                    Else
                        Dim achatT As AchatsTable = New AchatsTable
                        mat.Achat = achatT.GetById(mat.ref_obtention_id)
                    End If
                    liste.Add(mat)
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
            End Try

            Return liste
        End Function


        ''' <summary>
        ''' Get Default liste on report form
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDefault(ByVal du As Date, ByVal au As Date) As List(Of MaterielEntity)

            Dim liste As New List(Of MaterielEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                cmd.CommandText = "SELECT " & TABLE_FIELDS & " FROM materiels INNER JOIN departements ON materiels.departement_id = departements.id INNER JOIN type_materiels ON materiels.type_materiel_id = type_materiels.id INNER JOIN employes ON materiels.employe_id = employes.id WHERE DATE(materiels.created) BETWEEN @du AND @au ORDER BY materiels.created DESC"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    Dim mat As MaterielEntity = New MaterielEntity(result)
                    If mat.mode_obtention = "DON" Then
                        Dim donT As DonsTable = New DonsTable
                        mat.Don = donT.GetById(mat.ref_obtention_id)
                    Else
                        Dim achatT As AchatsTable = New AchatsTable
                        mat.Achat = achatT.GetById(mat.ref_obtention_id)
                    End If
                    liste.Add(mat)
                End While
                result.Close()
                FillDataSet(cmd)
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




            Return liste
        End Function


        ''' <summary>
        ''' Get by mode
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <param name="mode"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByMode(ByVal du As Date, ByVal au As Date, ByVal mode As String) As List(Of MaterielEntity)

            Dim liste As New List(Of MaterielEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                cmd.CommandText = "SELECT " & TABLE_FIELDS & " FROM materiels INNER JOIN departements ON materiels.departement_id = departements.id INNER JOIN type_materiels ON materiels.type_materiel_id = type_materiels.id INNER JOIN employes ON materiels.employe_id = employes.id WHERE (DATE(materiels.created) BETWEEN @du AND @au) AND (materiels.mode_obtention = @mode) ORDER BY materiels.created DESC"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@mode", mode)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim mat As MaterielEntity = New MaterielEntity(result)
                    If mat.mode_obtention = "DON" Then
                        Dim donT As DonsTable = New DonsTable
                        mat.Don = donT.GetById(mat.ref_obtention_id)
                    Else
                        Dim achatT As AchatsTable = New AchatsTable
                        mat.Achat = achatT.GetById(mat.ref_obtention_id)
                    End If
                    liste.Add(mat)
                End While
                result.Close()
                FillDataSet(cmd)
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

            Return liste
        End Function

        ''' <summary>
        ''' Find by departement
        ''' </summary>
        ''' <param name="du"></param>
        ''' <param name="au"></param>
        ''' <param name="dep"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetByDepartement(ByVal du As Date, ByVal au As Date, ByVal dep As String) As List(Of MaterielEntity)

            Dim liste As New List(Of MaterielEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                cmd.CommandText = "SELECT " & TABLE_FIELDS & " FROM materiels INNER JOIN departements ON materiels.departement_id = departements.id INNER JOIN type_materiels ON materiels.type_materiel_id = type_materiels.id INNER JOIN employes ON materiels.employe_id = employes.id WHERE (DATE(materiels.created) BETWEEN @du AND @au) AND (materiels.departement_id = @dep) ORDER BY materiels.created DESC"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@dep", dep)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim mat As MaterielEntity = New MaterielEntity(result)
                    If mat.mode_obtention = "DON" Then
                        Dim donT As DonsTable = New DonsTable
                        mat.Don = donT.GetById(mat.ref_obtention_id)
                    Else
                        Dim achatT As AchatsTable = New AchatsTable
                        mat.Achat = achatT.GetById(mat.ref_obtention_id)
                    End If
                    liste.Add(mat)
                End While
                result.Close()
                FillDataSet(cmd)
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

            Return liste
        End Function

        Public Function GetByModeDepartement(ByVal du As Date, ByVal au As Date, ByVal mode As String, ByVal dep As String) As List(Of MaterielEntity)

            Dim liste As New List(Of MaterielEntity)

            Try
                Dim cmd As MySqlCommand = Database.NewConnecion.CreateCommand
                cmd.CommandText = "SELECT " & TABLE_FIELDS & " FROM materiels INNER JOIN departements ON materiels.departement_id = departements.id INNER JOIN type_materiels ON materiels.type_materiel_id = type_materiels.id INNER JOIN employes ON materiels.employe_id = employes.id WHERE (DATE(materiels.created) BETWEEN @du AND @au) AND (materiels.departement_id = @dep AND materiels.mode_obtention = @mode) ORDER BY materiels.created DESC"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@du", Util.GetDateToMysqlFormat(du))
                cmd.Parameters.AddWithValue("@au", Util.GetDateToMysqlFormat(au))
                cmd.Parameters.AddWithValue("@dep", dep)
                cmd.Parameters.AddWithValue("@mode", mode)

                Dim result As MySqlDataReader = cmd.ExecuteReader

                While result.Read
                    Dim mat As MaterielEntity = New MaterielEntity(result)
                    If mat.mode_obtention = "DON" Then
                        Dim donT As DonsTable = New DonsTable
                        mat.Don = donT.GetById(mat.ref_obtention_id)
                    Else
                        Dim achatT As AchatsTable = New AchatsTable
                        mat.Achat = achatT.GetById(mat.ref_obtention_id)
                    End If
                    liste.Add(mat)
                End While
                result.Close()
                FillDataSet(cmd)
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

            Return liste
        End Function

        ''' <summary>
        ''' Filling dataTable for reporting
        ''' </summary>
        ''' <param name="cmd">the request commande</param>
        ''' <remarks></remarks>
        Private Sub FillDataSet(ByRef cmd As MySqlCommand)
            Try
                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                data_set = New DataSetTables
                adapter.Fill(data_set.Materiels)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Unable to fill dataTable, report maybe unavailable : " & ex.Message, 2)
            End Try
        End Sub

    End Class
End Namespace
