Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db.Entities
Imports MetroFramework.Controls
Imports EntraideBundle.Db

Public Class EtudiantsTable

#Region "Constants"
    Private Const FOND_BASE_FIELDS As String = "fond_de_soutiens.id AS fond_de_soutien_id, fond_de_soutiens.date_depense AS fond_de_soutien_date_depense, fond_de_soutiens.montant_solicite AS fond_de_soutien_montant_solicite, fond_de_soutiens.montant_recu AS fond_de_soutien_montant_recu, fond_de_soutiens.interet AS fond_de_soutien_interet, fond_de_soutiens.echeance AS fond_de_soutien_echeance, fond_de_soutiens.type_business AS fond_de_soutien_type_business, fond_de_soutiens.date_debut AS fond_de_soutien_date_debut, fond_de_soutiens.date_fin AS fond_de_soutien_date_fin, fond_de_soutiens.penalite AS fond_de_soutien_penalite, fond_de_soutiens.id_etudiant AS fond_de_soutien_id_etudiant, fond_de_soutiens.id_code_depense AS fond_de_soutien_id_code_depense, fond_de_soutiens.mode_reception AS fond_de_soutien_mode_reception, etudiants.id AS etudiant_id, etudiants.date_inscription AS etudiant_date_inscription, etudiants.nom AS etudiant_nom, etudiants.prenom AS etudiant_prenom, etudiants.sexe AS etudiant_sexe, etudiants.situation AS etudiant_situation, etudiants.nombre_enfant AS etudiant_nombre_enfant, etudiants.lieu_naissance AS etudiant_lieu_naissance, etudiants.nationalite AS etudiant_nationalite, etudiants.adresse AS etudiant_adresse, etudiants.BP AS etudiant_BP, etudiants.tel1 AS etudiant_tel1, etudiants.tel2 AS etudiant_tel2, etudiants.email AS etudiant_email, etudiants.autre_religion AS etudiant_autre_religion, etudiants.delit AS etudiant_delit, etudiants.formation AS etudiant_formation, etudiants.niveau_etude AS etudiant_niveau_etude, etudiants.nom_urgence AS etudiant_nom_urgence, etudiants.adresse_urgence AS etudiant_adresse_urgence, etudiants.phone_urgence AS etudiant_phone_urgence, etudiants.email_urgence AS etudiant_email_urgence, etudiants.code_etudiant AS etudiant_code_etudiant, etudiants.type_emploi AS etudiant_type_emploi, etudiants.business AS etudiant_business, etudiants.type_business AS etudiant_type_business, etudiants.nombre_employes AS etudiant_nombre_employes, etudiants.annexe AS etudiant_annexe, etudiants.religion_id AS etudiant_religion_id, etudiants.generation_id AS etudiant_generation_id, code_depenses.id AS code_depense_id, code_depenses.nom AS code_depense_nom, code_depenses.code AS code_depense_code, paiement.id AS paiement_id, paiement.type_paiement AS paiemen_type_paiement, paiement.montant_paye AS paiement_montant_paye, paiement.id_revenu AS paiement_id_revenu, paiement.id_fond_soutien AS paiement_id_fond_soutien, paiement.created AS paiement_created"

    Private Const FOND_BASE_TABLE As String = "fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense"

    Private Const BASE_QUERY As String = "SELECT etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, SUM(paiement.montant_paye) as paiement, paiement.type_paiement, etudiants.code_etudiant, etudiants.sexe, etudiants.situation, etudiants.nombre_enfant, etudiants.lieu_naissance, etudiants.nationalite, etudiants.adresse, etudiants.BP, etudiants.tel1, etudiants.tel2, etudiants.email, etudiants.autre_religion, etudiants.delit, etudiants.formation, etudiants.niveau_etude, etudiants.nom_urgence, etudiants.adresse_urgence, etudiants.phone_urgence, etudiants.email_urgence, etudiants.type_emploi, etudiants.business, etudiants.type_business, etudiants.nombre_employes, etudiants.annexe, religions.nom AS religion, type_formation.nom AS type_formation_nom, paiement.id AS paiement_id, revenu.id AS revenu_id, formations.id AS formation_id, revenu.montant AS revenu_montant, etudiants.generation_id, generations.libelle AS generation, type_formation.id AS type_formation_id, etudiants.religion_id FROM etudiants INNER JOIN generations ON etudiants.generation_id = generations.id INNER JOIN formations ON etudiants.id = formations.id_etudiant INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id INNER JOIN type_formation ON type_formation.id = formations.id_type_formation"

#End Region

    Public Shared fond_data_source As DataSetTables = Nothing

    Public Shared data_source As DataSetTables = Nothing

    Public tempText As String = ""

    Public Shared revenu_id As Integer = 0

    Public Function GetAll() As DataTable

        Dim dataTable As New DataTable

        Try

            Dim cmd As MySqlCommand = Database.GetCommand
            cmd.CommandText = "SELECT * FROM etudiants"

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
    ''' Creer un nouveau etudiant
    ''' </summary>
    ''' <param name="form">L'entite etudiant a enregistrer</param>
    ''' <returns>Id de l'etudiant enregistrer</returns>
    ''' <remarks></remarks>
    Public Function Save(ByVal form As Inscription) As Long

        Dim id As Long = 0
        Dim execute As Long = 0
        Dim col As String = ""
        Dim paiement As PaiementEntity = New PaiementEntity

        Try
            Dim cnx As MySqlConnection = Database.GetConnection
            Dim trans As MySqlTransaction = cnx.BeginTransaction
            Dim cmd As MySqlCommand = cnx.CreateCommand
            cmd.Transaction = trans

            cmd.CommandText = "INSERT INTO etudiants  (date_inscription,nom,prenom,sexe, situation, nombre_enfant, lieu_naissance, nationalite, adresse, BP, tel1, tel2, email, autre_religion, delit, formation, niveau_etude, nom_urgence, adresse_urgence, phone_urgence, email_urgence, code_etudiant, type_emploi, business, type_business, nombre_employes, annexe, religion_id, generation_id) VALUES (@date_inscription,@nom,@prenom,@sexe, @situation, @nombre_enfant, @lieu_naissance, @nationalite, @adresse, @BP, @tel1, @tel2, @email, @autre_religion, @delit, @formation, @niveau_etude, @nom_urgence, @adresse_urgence, @phone_urgence, @email_urgence, @code_etudiant, @type_emploi, @business, @type_business, @nombre_employes, @annexe, @religion_id, @gen_id)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@date_inscription", form.dt_date.Value)
            cmd.Parameters.AddWithValue("@nom", form.txtNom.Text.ToString)
            cmd.Parameters.AddWithValue("@prenom", form.txtPrenom.Text)
            cmd.Parameters.AddWithValue("@sexe", form.cmbSex.Text)
            cmd.Parameters.AddWithValue("@situation", form.cmbSituation.Text)
            cmd.Parameters.AddWithValue("@nombre_enfant", form.txtNbreEnfant.Text)
            cmd.Parameters.AddWithValue("@lieu_naissance", form.txtLieu.Text)
            cmd.Parameters.AddWithValue("@nationalite", form.txtNationalite.Text)
            cmd.Parameters.AddWithValue("@adresse", form.txtAdresse.Text)
            cmd.Parameters.AddWithValue("@bp", form.txtBP.Text)
            cmd.Parameters.AddWithValue("@tel1", form.txtPhone1.Text)
            cmd.Parameters.AddWithValue("@tel2", form.txtPhone2.Text)
            cmd.Parameters.AddWithValue("@email", form.txtMail.Text)
            cmd.Parameters.AddWithValue("@autre_religion", form.txtAutreReligion.Text)
            cmd.Parameters.AddWithValue("@delit", form.txtDelit.Text)
            cmd.Parameters.AddWithValue("@formation", form.cmbFormation.Text)

            cmd.Parameters.AddWithValue("@niveau_etude", form.txtNiveauEtude.Text)
            cmd.Parameters.AddWithValue("@nom_urgence", form.txtNomUrgence.Text)
            cmd.Parameters.AddWithValue("@adresse_urgence", form.txtAdresseUrgence.Text)
            cmd.Parameters.AddWithValue("@phone_urgence", form.txtPhoneUrgence.Text)
            cmd.Parameters.AddWithValue("@email_urgence", form.txtMailUrgence.Text)
            cmd.Parameters.AddWithValue("@code_etudiant", form.txtCodeRevenu.Text)
            cmd.Parameters.AddWithValue("@type_emploi", form.txtTypeEmploi.Text)
            cmd.Parameters.AddWithValue("@business", form.cmbBusiness.Text)
            cmd.Parameters.AddWithValue("@type_business", form.txtTypeBusiness.Text)
            cmd.Parameters.AddWithValue("@nombre_employes", form.txtNombreEmployes.Text)
            cmd.Parameters.AddWithValue("@annexe", form.txtAnnexe.Text)
            cmd.Parameters.AddWithValue("@religion_id", form.cmbReligion.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@gen_id", form.cmbGeneration.SelectedValue)
            execute = cmd.ExecuteNonQuery

            id = cmd.LastInsertedId

            cmd.Dispose()
            ' insert competence etudiant

            For i As Integer = 1 To 2

                For j As Integer = 1 To 3
                    cmd = cnx.CreateCommand
                    cmd.Transaction = trans
                    cmd.CommandText = "INSERT INTO competence_etudiant (id_etudiants, id_langues," &
                                "id_competences, id_niveau) VALUE (@idet, @nid, @typeid, @evlid)"
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@idet", id)
                    cmd.Parameters.AddWithValue("@nid", i)
                    cmd.Parameters.AddWithValue("@typeid", j)

                    Dim evalId As String = ""

                    If i = 1 Then
                        If j = 1 Then
                            If form.chkEcrireExcellentFr.Checked Then
                                evalId = 1
                            ElseIf form.chkEcrireMoyenFr.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebutantFr.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 2 Then
                            If form.chkEcouteExcellentFr.Checked Then
                                evalId = 1
                            ElseIf form.chkEcouterMoyenFr.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebutantFr.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 3 Then
                            If form.chkParlerExcellentFr.Checked Then
                                evalId = 1
                            ElseIf form.chkParlerMoyenFr.Checked Then
                                evalId = 2
                            ElseIf form.chkParlerDebutantFr.Checked Then
                                evalId = 3
                            End If
                        End If
                    Else
                        If j = 1 Then
                            If form.chkEcrireExcellentEN.Checked Then
                                evalId = 1
                            ElseIf form.chkEcrireMoyenEN.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebEN.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 2 Then
                            If form.chkEcouteExEN.Checked Then
                                evalId = 1
                            ElseIf form.chkEcouteMoyenEN.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebEN.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 3 Then
                            If form.chkParlerExEN.Checked Then
                                evalId = 1
                            ElseIf form.chkParlerMoyenEN.Checked Then
                                evalId = 2
                            ElseIf form.chkParlerDebEN.Checked Then
                                evalId = 3
                            End If
                        End If
                    End If

                    cmd.Parameters.AddWithValue("@evlid", evalId)

                    execute += cmd.ExecuteNonQuery


                    cmd.Dispose()
                Next
            Next


            'insert formation
            cmd = cnx.CreateCommand
            cmd.Transaction = trans
            cmd.CommandText = "INSERT INTO formations (id_etudiant, id_type_formation, date_inscription) VALUE (@id_etudiant, @id_type_formation, @date_inscription)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@id_etudiant", id)
            cmd.Parameters.AddWithValue("@id_type_formation", form.cmbTypeFormation.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@date_inscription", form.dt_date.Value)


            execute += cmd.ExecuteNonQuery

            Dim id_formation = cmd.LastInsertedId

            cmd.Dispose()
            'insert revenu

            cmd = cnx.CreateCommand
            cmd.Transaction = trans
            cmd.CommandText = "INSERT INTO revenu (nom_activite, montant, type_revenu, ref_id) VALUE (@nom_activite, @montant, @type_revenu, @ref_id)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@nom_activite", form.txtActivite.Text)
            cmd.Parameters.AddWithValue("@montant", form.txtCoutFormation.Text)
            cmd.Parameters.AddWithValue("@type_revenu", "Formation")
            cmd.Parameters.AddWithValue("@ref_id", id_formation)

            execute += cmd.ExecuteNonQuery

            Dim id_revenu = cmd.LastInsertedId
            revenu_id = id_revenu
            cmd.Dispose()

            'insert paiement
            cmd = cnx.CreateCommand
            cmd.Transaction = trans

            Dim paie As Integer = 1
            If form.chkEspece.Checked Then
                paie = 1
            ElseIf form.chkCheque.Checked Then
                paie = 2
            ElseIf form.chkVirement.Checked Then
                paie = 3
            End If

            cmd.CommandText = "INSERT INTO paiement (type_paiement, montant_paye, id_revenu) VALUE (@type_paiement, @montant_paye, @id_revenu)"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@type_paiement", paie)
            cmd.Parameters.AddWithValue("@montant_paye", form.txtMontantPayer.Text)
            cmd.Parameters.AddWithValue("@id_revenu", id_revenu)


            execute += cmd.ExecuteNonQuery

            Dim id5 = cmd.LastInsertedId

            cmd.Dispose()





            trans.Commit()
            trans.Dispose()
            'cnx.Close()

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                MsgBox(ex.ToString)
            Else
                MsgBox("Echec de connexion")
            End If
        Finally
            Database.CloseConnection()
        End Try


        Return execute
    End Function


    Public Function GetByNameType(ByVal dateDu As Date, ByVal DateAu As Date, ByVal name As String, ByVal type As String) As List(Of EtudiantEntity)

        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)

        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
            Dim d2 As String = Format(DateAu, "yyyy-MM-dd")
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE etudiants.date_inscription BETWEEN '" & d1 & "' AND '" & d2 & "' AND etudiants.nom = '" & name & "' AND type_formation.id = '" & type & "' GROUP BY formations.id "
            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read
                etudiants.Add(GetCursorEntity(result))
            End While

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

        Return etudiants
    End Function

    Public Function GetByName(ByVal dateDu As Date, ByVal DateAu As Date, ByVal name As String) As List(Of EtudiantEntity)

        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)

        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
            Dim d2 As String = Format(DateAu, "yyyy-MM-dd")
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE etudiants.date_inscription BETWEEN '" & d1 & "' AND '" & d2 & "' AND etudiants.nom = '" & name & "' GROUP BY formations.id"
            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read

                etudiants.Add(GetCursorEntity(result))

            End While

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

        Return etudiants
    End Function

    Public Function GetByDate(ByVal dateDu As Date, ByVal dateAu As Date, Optional generation As String = "") As List(Of EtudiantEntity)

        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)

        Try
            Dim d1 As String = Util.GetDateToMysqlFormat(dateDu)
            Dim d2 As String = Util.GetDateToMysqlFormat(dateAu)
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE DATE(etudiants.date_inscription) BETWEEN '" & d1 & "' AND '" & d2 & "' " & IIf(generation.Length > 0, " AND etudiants.generation_id = " & generation, "") & " GROUP BY formations.id "

            cmd.CommandText = sql

            Dim result As MySqlDataReader = Nothing

            result = cmd.ExecuteReader

            While result.Read
                etudiants.Add(GetCursorEntity(result))
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

        Return etudiants
    End Function

    ''' <summary>
    ''' Get the Entity on the current resultset cursor
    ''' </summary>
    ''' <param name="result">DataReader Object</param>
    ''' <returns></returns>
    Private Function GetCursorEntity(ByRef result As MySqlDataReader) As EtudiantEntity
        Dim entity As New EtudiantEntity
        entity.id = result.GetValue(0).ToString
        entity.nom = result.GetValue(1).ToString
        entity.prenom = result.GetValue(2).ToString
        entity.Paiement.MontantP = result.GetValue(3).ToString
        entity.Paiement.TypePaiement = result.GetValue(4).ToString
        entity.code = result.GetValue(5).ToString
        entity.sexe = result.GetValue(6).ToString
        entity.situation_matri = result.GetValue(7).ToString
        entity.nombre_enfant = result.GetValue(8).ToString
        entity.lieu_naissance = result.GetValue(9).ToString
        entity.nationnalite = result.GetValue(10).ToString
        entity.adresse = result.GetValue(11).ToString
        entity.bp = result.GetValue(12).ToString
        entity.tel1 = result.GetValue(13).ToString
        entity.tel2 = result.GetValue(14).ToString
        entity.email = result.GetValue(15).ToString
        entity.autre_religion = result.GetValue(16).ToString
        entity.delit = result.GetValue(17).ToString
        entity.formation_recu = result.GetValue(18).ToString
        entity.niveau = result.GetValue(19).ToString
        entity.nom_urgence = result.GetValue(20).ToString
        entity.adresse_urgence = result.GetValue(21).ToString
        entity.phone_urgence = result.GetValue(22).ToString
        entity.mail_urgence = result.GetValue(23).ToString
        entity.type_emploie = result.GetValue(24).ToString
        entity.business = result.GetValue(25).ToString
        entity.type_business = result.GetValue(26).ToString
        entity.nombre_employe = result.GetValue(27).ToString
        entity.annexe = result.GetValue(28).ToString
        entity.Religion.Nom = result.GetValue(29).ToString
        entity.TypeFormationId.Nom = result.GetValue(30).ToString
        entity.Paiement.Id = result.GetValue(31).ToString
        entity.Revenu.Id = result.GetValue(32).ToString
        entity.Formation.id = result.GetValue(33).ToString
        entity.Revenu.Montant = result.GetValue(34).ToString
        entity.generation_id = result.GetValue(35).ToString
        entity.generation = result.GetValue(36).ToString
        entity.TypeFormationId.Id = result.GetValue(37).ToString
        entity.Religion.Id = result.GetValue(38).ToString
        Return entity
    End Function


    Public Function GetByCode(ByVal code As String) As List(Of EtudiantEntity)

        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)

        Try
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & "  WHERE etudiants.code_etudiant  = '" & code & "' GROUP BY formations.id"

            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read
                etudiants.Add(GetCursorEntity(result))
            End While

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

        Return etudiants
    End Function


    Public Function GetByType(ByVal dateDu As Date, ByVal DateAu As Date, ByVal type As String) As List(Of EtudiantEntity)
        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
            Dim d2 As String = Format(DateAu, "yyyy-MM-dd")
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE etudiants.date_inscription BETWEEN '" & d1 & "' AND '" & d2 & "' AND type_formation.id = '" & type & "' GROUP BY formations.id"

            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read
                etudiants.Add(GetCursorEntity(result))
            End While

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

        Return etudiants

    End Function


    Public Function GetByPaiement(ByVal dateDu As Date, ByVal DateAu As Date, ByVal paiement As String, Optional generation As String = "") As List(Of EtudiantEntity)
        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
            Dim d2 As String = Format(DateAu, "yyyy-MM-dd")
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE etudiants.date_inscription BETWEEN '" & d1 & "' AND '" & d2 & "' AND paiement.type_paiement = '" & paiement & "' " & IIf(generation.Length > 0, " AND etudiants.generation_id = " & generation, "") & " GROUP BY formations.id"
            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read

                etudiants.Add(GetCursorEntity(result))
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

        Return etudiants
    End Function

    Public Function GetByFormation(ByVal dateDu As Date, ByVal DateAu As Date, ByVal formation As String, Optional generation As String = "") As List(Of EtudiantEntity)
        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
            Dim d2 As String = Format(DateAu, "yyyy-MM-dd")
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE etudiants.date_inscription BETWEEN '" & d1 & "' AND '" & d2 & "' AND type_formation.id = '" & formation & "' " & IIf(generation.Length > 0, " AND etudiants.generation_id = " & generation, "") & " GROUP BY formations.id"

            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read

                etudiants.Add(GetCursorEntity(result))
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

        Return etudiants
    End Function

    Public Function GetByFormationPaiement(ByVal dateDu As Date, ByVal DateAu As Date, ByVal formation As String, ByVal paiement As String, Optional generation As String = "") As List(Of EtudiantEntity)

        Dim etudiants As List(Of EtudiantEntity) = New List(Of EtudiantEntity)

        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")

            Dim d2 As String = Format(DateAu, "yyyy-MM-dd")

            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = BASE_QUERY & " WHERE etudiants.date_inscription BETWEEN '" & d1 & "' AND '" & d2 & "' AND paiement.type_paiement = '" & paiement & "' AND type_formation.id = '" & formation & "' " & IIf(generation.Length > 0, " AND etudiants.generation_id = " & generation, "") & " GROUP BY formations.id"
            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            While result.Read

                etudiants.Add(GetCursorEntity(result))

            End While

            result.Close()

            FillDataSource(cmd)

            cmd.Dispose()

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message)
            End If
        Finally
            Database.CloseConnection()
        End Try

        Return etudiants
    End Function

    ''' <summary>
    ''' Get By id
    ''' </summary>
    ''' <param name="id">id</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetById(ByVal id As String) As EtudiantEntity

        Dim etudiant As EtudiantEntity = New EtudiantEntity

        Try
            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = "SELECT etudiants.id AS etudiant_id, etudiants.nom, etudiants.prenom, sum(paiement.montant_paye) as paiement, paiement.type_paiement, etudiants.code_etudiant, etudiants.sexe, etudiants.situation, etudiants.nombre_enfant, etudiants.lieu_naissance, etudiants.nationalite, etudiants.adresse, etudiants.BP, etudiants.tel1, etudiants.tel2, etudiants.email, etudiants.autre_religion, etudiants.delit, etudiants.formation, etudiants.niveau_etude, etudiants.nom_urgence, etudiants.adresse_urgence, etudiants.phone_urgence, etudiants.email_urgence, etudiants.type_emploi, etudiants.business, etudiants.type_business, etudiants.nombre_employes, etudiants.annexe, religions.nom, type_formation.nom, paiement.id AS paiement_id, revenu.id AS reveneu_id, formations.id AS formation_id, revenu.montant, revenu.code_revenu, revenu.nom_activite, etudiants.generation_id FROM etudiants INNER JOIN formations ON etudiants.id = formations.id_etudiant INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id	INNER JOIN type_formation ON type_formation.id = formations.id_type_formation  WHERE etudiants.id  = '" & id & "' GROUP BY formations.id ORDER BY formations.date_inscription LIMIT 1"

            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            If result.HasRows Then
                result.Read()
                etudiant.id = result.GetValue(0).ToString
                etudiant.nom = result.GetValue(1).ToString
                etudiant.prenom = result.GetValue(2).ToString
                etudiant.Paiement.MontantP = result.GetValue(3).ToString
                etudiant.Paiement.TypePaiement = result.GetValue(4).ToString
                etudiant.code = result.GetValue(5).ToString
                etudiant.sexe = result.GetValue(6).ToString
                etudiant.situation_matri = result.GetValue(7).ToString
                etudiant.nombre_enfant = result.GetValue(8).ToString
                etudiant.lieu_naissance = result.GetValue(9).ToString
                etudiant.nationnalite = result.GetValue(10).ToString
                etudiant.adresse = result.GetValue(11).ToString
                etudiant.bp = result.GetValue(12).ToString
                etudiant.tel1 = result.GetValue(13).ToString
                etudiant.tel2 = result.GetValue(14).ToString
                etudiant.email = result.GetValue(15).ToString
                etudiant.autre_religion = result.GetValue(16).ToString
                etudiant.delit = result.GetValue(17).ToString
                etudiant.formation_recu = result.GetValue(18).ToString
                etudiant.niveau = result.GetValue(19).ToString
                etudiant.nom_urgence = result.GetValue(20).ToString
                etudiant.adresse_urgence = result.GetValue(21).ToString
                etudiant.phone_urgence = result.GetValue(22).ToString
                etudiant.mail_urgence = result.GetValue(23).ToString
                etudiant.type_emploie = result.GetValue(24).ToString
                etudiant.business = result.GetValue(25).ToString
                etudiant.type_business = result.GetValue(26).ToString
                etudiant.nombre_employe = result.GetValue(27).ToString
                etudiant.annexe = result.GetValue(28).ToString
                etudiant.Religion.Nom = result.GetValue(29).ToString
                etudiant.TypeFormationId.Nom = result.GetValue(30).ToString
                etudiant.Paiement.Id = result.GetValue(31).ToString
                etudiant.Revenu.Id = result.Item("reveneu_id").ToString
                etudiant.Formation.id = result.GetValue(33).ToString
                etudiant.Revenu.Montant = result.GetValue(34).ToString
                etudiant.Revenu.CodeRevenu = result.GetValue(35).ToString
                etudiant.Revenu.NomActivite = result.GetValue(36).ToString
                etudiant.generation_id = result.GetValue(37).ToString
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

        Return etudiant
    End Function


    Public Function AddPaiement(ByVal revenu_id As String, ByVal montant As String, type As String) As Long
        Dim back_value As Long = 0
        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            cmd.CommandText = "INSERT INTO paiement SET id_revenu = @rev_id, montant_paye = @mnt, type_paiement = @tp"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@rev_id", revenu_id)
            cmd.Parameters.AddWithValue("@mnt", montant)
            cmd.Parameters.AddWithValue("@tp", type)

            back_value = cmd.ExecuteNonQuery
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
        Return back_value
    End Function


    Public Function Update(ByVal form As UpdateEtudiant) As Long

        Dim execute As Long = 0

        Try

            Dim cnx As MySqlConnection = Database.GetConnection
            Dim trans As MySqlTransaction = cnx.BeginTransaction
            Dim cmd As MySqlCommand = cnx.CreateCommand
            cmd.Transaction = trans

            'update etudiant

            cmd.CommandText = "UPDATE etudiants SET nom = @nom, prenom=@prenom, sexe=@sexe, situation=@situation, nombre_enfant=@nombre_enfant,lieu_naissance=@lieu_naissance, nationalite=@nationalite, adresse=@adresse, bp=@bp, tel1=@tel1, tel2=@tel2, email=@email,autre_religion=@autre_religion, delit=@delit, formation=@formation, niveau_etude=@niveau_etude, nom_urgence=@nom_urgence, adresse_urgence=@adresse_urgence, phone_urgence=@phone_urgence, email_urgence=@email_urgence, type_emploi=@type_emploi, business=@business, type_business= @type_business, nombre_employes=@nombre_employes, annexe=@annexe,religion_id=@religion_id, generation_id = @gen_id WHERE id=@id "

            cmd.Prepare()

            Util.ShowMessage(form.etudiant_id.ToString)

            cmd.Parameters.AddWithValue("@id", form.etudiant_id.ToString)
            cmd.Parameters.AddWithValue("@nom", form.txtNomEtudiant.Text.ToString)
            cmd.Parameters.AddWithValue("@prenom", form.txtPrenom.Text)
            cmd.Parameters.AddWithValue("@sexe", form.cmbSex.Text)
            cmd.Parameters.AddWithValue("@situation", form.cmbSituation.Text)
            cmd.Parameters.AddWithValue("@nombre_enfant", form.txtNbreEnfant.Text)
            cmd.Parameters.AddWithValue("@lieu_naissance", form.txtLieu.Text)
            cmd.Parameters.AddWithValue("@nationalite", form.txtNationalite.Text)
            cmd.Parameters.AddWithValue("@adresse", form.txtAdresse.Text)
            cmd.Parameters.AddWithValue("@bp", form.txtBP.Text)
            cmd.Parameters.AddWithValue("@tel1", form.txtPhone1.Text)
            cmd.Parameters.AddWithValue("@tel2", form.txtPhone2.Text)
            cmd.Parameters.AddWithValue("@email", form.txtMail.Text)
            cmd.Parameters.AddWithValue("@autre_religion", form.txtAutreReligion.Text)
            cmd.Parameters.AddWithValue("@delit", form.txtDelit.Text)
            cmd.Parameters.AddWithValue("@formation", form.cmbFormation.Text)
            cmd.Parameters.AddWithValue("@niveau_etude", form.txtNiveauEtude.Text)
            cmd.Parameters.AddWithValue("@nom_urgence", form.txtNomUrgence.Text)
            cmd.Parameters.AddWithValue("@adresse_urgence", form.txtAdresseUrgence.Text)
            cmd.Parameters.AddWithValue("@phone_urgence", form.txtPhoneUrgence.Text)
            cmd.Parameters.AddWithValue("@email_urgence", form.txtMailUrgence.Text)
            cmd.Parameters.AddWithValue("@type_emploi", form.txtTypeEmploi.Text)
            cmd.Parameters.AddWithValue("@business", form.cmbBusiness.Text)
            cmd.Parameters.AddWithValue("@type_business", form.txtTypeBusiness.Text)
            cmd.Parameters.AddWithValue("@nombre_employes", form.txtNombreEmployes.Text)
            cmd.Parameters.AddWithValue("@annexe", form.txtAnnexe.Text)
            cmd.Parameters.AddWithValue("@religion_id", form.cmbReligion.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@gen_id", form.cmbGeneration.SelectedValue)

            execute = cmd.ExecuteNonQuery

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'update competence_etudiant

            cmd = cnx.CreateCommand
            cmd.CommandText = "DELETE FROM competence_etudiant WHERE id_etudiants = @id"
            cmd.Parameters.AddWithValue("@id", form.etudiant_id.ToString)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            For i As Integer = 1 To 2

                For j As Integer = 1 To 3
                    cmd = cnx.CreateCommand
                    cmd.Transaction = trans
                    cmd.CommandText = "UPDATE competence_etudiant SET id_langues= @nid," &
                                "id_competences=@typeid, id_niveau =@evlid  WHERE id=@id"
                    cmd.Prepare()

                    cmd.Parameters.AddWithValue("@idet", form.etudiant_id)
                    cmd.Parameters.AddWithValue("@nid", i)
                    cmd.Parameters.AddWithValue("@typeid", j)
                    cmd.Parameters.AddWithValue("@id", form.etudiant_id.ToString)

                    Dim evalId As String = ""

                    If i = 1 Then
                        If j = 1 Then
                            If form.chkEcrireExcellentFr.Checked Then
                                evalId = 1
                            ElseIf form.chkEcrireMoyenFr.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebutantFr.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 2 Then
                            If form.chkEcouteExcellentFr.Checked Then
                                evalId = 1
                            ElseIf form.chkEcouterMoyenFr.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebutantFr.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 3 Then
                            If form.chkParlerExcellentFr.Checked Then
                                evalId = 1
                            ElseIf form.chkParlerMoyenFr.Checked Then
                                evalId = 2
                            ElseIf form.chkParlerDebutantFr.Checked Then
                                evalId = 3
                            End If
                        End If
                    Else
                        If j = 1 Then
                            If form.chkEcrireExcellentEN.Checked Then
                                evalId = 1
                            ElseIf form.chkEcrireMoyenEN.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebEN.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 2 Then
                            If form.chkEcouteExEN.Checked Then
                                evalId = 1
                            ElseIf form.chkEcouteMoyenEN.Checked Then
                                evalId = 2
                            ElseIf form.chkEcrireDebEN.Checked Then
                                evalId = 3
                            End If
                        ElseIf j = 3 Then
                            If form.chkParlerExEN.Checked Then
                                evalId = 1
                            ElseIf form.chkParlerMoyenEN.Checked Then
                                evalId = 2
                            ElseIf form.chkParlerDebEN.Checked Then
                                evalId = 3
                            End If
                        End If
                    End If

                    cmd.Parameters.AddWithValue("@evlid", evalId)

                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Next
            Next

            'Update formation
            cmd = cnx.CreateCommand
            cmd.Transaction = trans
            cmd.CommandText = "UPDATE formations SET id_type_formation = @id_type_formation WHERE id=@id "

            cmd.Prepare()
            cmd.Parameters.AddWithValue("@id", form.formation_id.ToString)
            cmd.Parameters.AddWithValue("@id_type_formation", form.cmbTypeFormation.SelectedValue.ToString)

            execute += cmd.ExecuteNonQuery
            cmd.ExecuteNonQuery()


            cmd.Dispose()

            'Update revenu
            cmd = cnx.CreateCommand
            cmd.Transaction = trans
            cmd.CommandText = "UPDATE revenu SET montant = @montant, nom_activite=@nom_activite WHERE id=@id "
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@id", form.revenu_id.ToString)
            cmd.Parameters.AddWithValue("@montant", form.txtCoutFormation.Text)
            cmd.Parameters.AddWithValue("@nom_activite", form.txtActivite.Text)

            execute += cmd.ExecuteNonQuery
            cmd.ExecuteNonQuery()


            cmd.Dispose()

            'update paiement

            cmd = cnx.CreateCommand
            cmd.Transaction = trans
            Dim paie As Integer = 1
            If form.chkEspece.Checked Then
                paie = 1
            ElseIf form.chkCheque.Checked Then
                paie = 2
            ElseIf form.chkVirement.Checked Then
                paie = 3
            End If
            cmd.CommandText = "UPDATE paiement SET type_paiement = @type_paiement , montant_paye = @montant_paye WHERE id=@id"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@id", form.paiement_id.ToString)

            cmd.Parameters.AddWithValue("@type_paiement", paie)
            cmd.Parameters.AddWithValue("@montant_paye", form.txtMontantPayer.Text.Trim("F"))

            execute += cmd.ExecuteNonQuery
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            trans.Commit()
            trans.Dispose()
            'cnx.Close()
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                MsgBox(ex.ToString)
            Else
                MsgBox("Echec de connexion")
            End If
        Finally
            Database.CloseConnection()
        End Try


        Return execute
    End Function

    Public Function getEtudiant() As List(Of EtudiantEntity)
        Dim etudiant As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            Dim sql As String = "SELECT id, nom,prenom, code_etudiant FROM etudiants ORDER BY nom ASC"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé", 1)
            Else
                While result.Read

                    Dim entity As New EtudiantEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    entity.prenom = result.GetValue(2).ToString
                    entity.code = result.GetValue(3).ToString


                    etudiant.Add(entity)

                End While
            End If




            result.Close()
            cmd.Dispose()

        Catch ex As Exception

        End Try


        Return etudiant

    End Function
    Public Function getEtudiantByDette() As List(Of EtudiantEntity)
        Dim etudiant As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            Dim sql As String = "SELECT id, nom, prenom,code_etudiant, montant, montant_paye FROM (SELECT etudiants.id as id, etudiants.nom as nom, etudiants.prenom as prenom, etudiants.code_etudiant as code_etudiant, type_formation.montant as montant, paiement.montant_paye as montant_paye FROM etudiants INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id	INNER JOIN type_formation ON type_formation.id = formations.id_type_formation) AS A NATURAL LEFT JOIN (SELECT etudiants.id as id, sum(paiement.montant_paye) as montant_paye FROM etudiants INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id	INNER JOIN type_formation ON type_formation.id = formations.id_type_formation GROUP BY formations.id ) AS B WHERE montant_paye < montant"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé", 1)
            Else
                While result.Read

                    Dim entity As New EtudiantEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    entity.prenom = result.GetValue(2).ToString
                    entity.code = result.GetValue(3).ToString
                    entity.Revenu.Montant = result.GetValue(4).ToString
                    entity.Paiement.MontantP = result.GetValue(5).ToString


                    etudiant.Add(entity)

                End While
            End If

            result.Close()
            cmd.Dispose()

        Catch ex As Exception

        End Try


        Return etudiant

    End Function
    Public Function getByNomDette(ByVal nom As String) As List(Of EtudiantEntity)
        Dim etudiant As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            Dim sql As String = "SELECT id, nom, prenom,code_etudiant, montant, montant_paye FROM (SELECT etudiants.id as id, etudiants.nom as nom, etudiants.prenom as prenom, etudiants.code_etudiant as code_etudiant, type_formation.montant as montant, paiement.montant_paye as montant_paye FROM etudiants INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id	INNER JOIN type_formation ON type_formation.id = formations.id_type_formation) AS A NATURAL LEFT JOIN (SELECT etudiants.id as id, sum(paiement.montant_paye) as montant_paye FROM etudiants INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN revenu ON formations.id = revenu.ref_id  	INNER JOIN paiement ON revenu.id = paiement.id_revenu 	INNER JOiN religions ON etudiants.religion_id = religions.id	INNER JOIN type_formation ON type_formation.id = formations.id_type_formation GROUP BY formations.id ) AS B WHERE montant_paye < montant AND nom LIKE '" & nom & "%'"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                tempText = " Aucun étudiant trouvé"
            Else
                While result.Read

                    Dim entity As New EtudiantEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    entity.prenom = result.GetValue(2).ToString
                    entity.code = result.GetValue(3).ToString
                    entity.Revenu.Montant = result.GetValue(4).ToString
                    entity.Paiement.MontantP = result.GetValue(5).ToString


                    etudiant.Add(entity)

                End While
            End If

            result.Close()
            cmd.Dispose()

        Catch ex As Exception

        End Try


        Return etudiant

    End Function

    Public Function getByNom(ByVal nom As String) As List(Of EtudiantEntity)
        Dim etudiant As List(Of EtudiantEntity) = New List(Of EtudiantEntity)
        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            Dim sql As String = "SELECT id, nom,prenom, code_etudiant FROM etudiants WHERE CONCAT_WS(' ', nom, prenom) LIKE '" & nom & "%' ORDER BY nom ASC"
            cmd.CommandText = sql

            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                tempText = " Aucun étudiant trouvé"
            Else
                While result.Read

                    Dim entity As New EtudiantEntity
                    entity.id = result.GetValue(0).ToString
                    entity.nom = result.GetValue(1).ToString
                    entity.prenom = result.GetValue(2).ToString
                    entity.code = result.GetValue(3).ToString


                    etudiant.Add(entity)

                End While
            End If

            result.Close()
            cmd.Dispose()

        Catch ex As Exception

        End Try


        Return etudiant

    End Function

    Public Function getByYear(ByVal dateFond As String) As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try

            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = "SELECT fond_de_soutiens.id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom), fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code, sum(paiement.montant_paye) FROM fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense  WHERE YEAR(fond_de_soutiens.date_depense) =  '" & dateFond & "' GROUP BY fond_de_soutiens.id"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé avec les filtres selectionnés, Essayez la recherche tout confondu", 1)
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
            End If




            result.Close()
            cmd.Dispose()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return fond
    End Function
    Public Function getByCodeEtudiant(ByVal code As String) As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try



            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = "SELECT fond_de_soutiens.id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom), fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code, sum(paiement.montant_paye) FROM fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense  WHERE etudiants.code_etudiant =  '" & code & "'   GROUP BY fond_de_soutiens.id"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé avec les filtres selectionnés, Essayez la recherche tout confondu", 1)
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
            End If




            result.Close()
            cmd.Dispose()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return fond
    End Function
    Public Function getByMonth(ByVal dateFond As String, ByVal month As String) As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try



            Dim cmd As MySqlCommand = Database.GetCommand
            Dim mois As String
            If month = "Janvier" Then
                mois = "01"
            ElseIf month = "Février" Then
                mois = "02"
            ElseIf month = "Mars" Then
                mois = "03"
            ElseIf month = "Avril" Then
                mois = "04"
            ElseIf month = "Mai" Then
                mois = "05"
            ElseIf month = "Juin" Then
                mois = "06"
            ElseIf month = "Juillet" Then
                mois = "07"
            ElseIf month = "Aout" Then
                mois = "08"
            ElseIf month = "Septembre" Then
                mois = "09"
            ElseIf month = "Octobre" Then
                mois = "10"
            ElseIf month = "Novembre" Then
                mois = "11"
            Else
                mois = "12"
            End If
            Dim sql As String = "SELECT fond_de_soutiens.id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom), fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code, sum(paiement.montant_paye) FROM fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense  WHERE YEAR(fond_de_soutiens.date_depense) =  '" & dateFond & "' AND MONTH(fond_de_soutiens.date_debut) = '" & mois & "' GROUP BY fond_de_soutiens.id"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé avec les filtres selectionnés, Essayez la recherche tout confondu", 1)
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
            End If




            result.Close()
            cmd.Dispose()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return fond
    End Function
    Public Function getByName(ByVal dateFond As String, ByVal name As String) As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try



            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = "SELECT fond_de_soutiens.id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom), fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code, sum(paiement.montant_paye) FROM fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense  WHERE YEAR(fond_de_soutiens.date_depense) =  '" & dateFond & "' AND etudiants.nom LIKE '" & name & "%' GROUP BY fond_de_soutiens.id"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé avec les filtres selectionnés, Essayez la recherche tout confondu", 1)
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
            End If

            result.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return fond
    End Function
    Public Function getByNameMonth(ByVal dateFond As String, ByVal name As String, ByVal month As String) As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try



            Dim cmd As MySqlCommand = Database.GetCommand
            Dim mois As String
            If month = "Janvier" Then
                mois = "01"
            ElseIf month = "Février" Then
                mois = "02"
            ElseIf month = "Mars" Then
                mois = "03"
            ElseIf month = "Avril" Then
                mois = "04"
            ElseIf month = "Mai" Then
                mois = "05"
            ElseIf month = "Juin" Then
                mois = "06"
            ElseIf month = "Juillet" Then
                mois = "07"
            ElseIf month = "Aout" Then
                mois = "08"
            ElseIf month = "Septembre" Then
                mois = "09"
            ElseIf month = "Octobre" Then
                mois = "10"
            ElseIf month = "Novembre" Then
                mois = "11"
            Else
                mois = "12"
            End If
            Dim sql As String = "SELECT fond_de_soutiens.id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom), fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code, sum(paiement.montant_paye) FROM fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense  WHERE YEAR(fond_de_soutiens.date_depense) =  '" & dateFond & "' AND etudiants.nom LIKE '" & name & "%' AND MONTH(fond_de_soutiens.date_debut)= '" & mois & "' GROUP BY fond_de_soutiens.id"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                Util.ShowMessage(UpdateEtudiant, " Aucun étudiant trouvé avec les filtres selectionnés, Essayez la recherche tout confondu", 1)
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
            End If




            result.Close()
            cmd.Dispose()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return fond
    End Function

    Public Function SavePaiement(ByVal paiement As AddPaiementFond) As Long
        Dim id As Long = 0
        Try
            Dim cnx As MySqlConnection = Database.GetConnection
            Dim cmd As MySqlCommand = cnx.CreateCommand
            cmd.CommandText = "INSERT INTO paiement (type_paiement, montant_paye, id_fond_soutien) VALUES (@type_paiement, @montant_paye, @id_fond_soutien)"
            Dim paie As Integer = 1
            If paiement.chkEspece.Checked Then
                paie = 1
            ElseIf paiement.chkCheque.Checked Then
                paie = 2
            ElseIf paiement.chkVirement.Checked Then
                paie = 3
            End If
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@type_paiement", paie)
            cmd.Parameters.AddWithValue("@montant_paye", paiement.txtMontantAPayer.Text)
            cmd.Parameters.AddWithValue("@id_fond_soutien", paiement.id_fond)
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


    Public Function GetFondDefault() As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try

            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = "SELECT id, nom, date_depense, montant_solicite, montant_recu, interet, echeance, type_business,date_debut, date_fin, penalite, id_etudiant, mode_reception, code_depense, montant_paye FROM (SELECT fond_de_soutiens.id as id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom) as nom, fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant as id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code AS code_depense, (fond_de_soutiens.montant_recu + fond_de_soutiens.interet + fond_de_soutiens.penalite) AS montant FROM  fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN code_depenses ON code_depenses.id=fond_de_soutiens.id_code_depense ) AS A NATURAL LEFT JOIN (SELECT fond_de_soutiens.id as id, sum(paiement.montant_paye) as montant_paye FROM fond_de_soutiens INNER JOIN paiement ON fond_de_soutiens.id = paiement.id_fond_soutien  GROUP BY fond_de_soutiens.id  ) AS B  WHERE montant_paye < montant"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                tempText = " Aucun étudiant trouvé"
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
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

        Return fond

    End Function

    Public Function GetFondByEtudiantName(ByVal nom As String) As List(Of FondSoutienEntity)
        Dim fond As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)
        Try

            Dim cmd As MySqlCommand = Database.GetCommand

            Dim sql As String = "SELECT id, nom, date_depense, montant_solicite, montant_recu, interet, echeance, type_business,date_debut, date_fin, penalite, id_etudiant, mode_reception, code_depense, montant_paye FROM (SELECT fond_de_soutiens.id as id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom) as nom, fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant as id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code AS code_depense, (fond_de_soutiens.montant_recu + fond_de_soutiens.interet + fond_de_soutiens.penalite) AS montant FROM  fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN code_depenses ON code_depenses.id=fond_de_soutiens.id_code_depense ) AS A NATURAL LEFT JOIN (SELECT fond_de_soutiens.id as id, sum(paiement.montant_paye) as montant_paye FROM fond_de_soutiens INNER JOIN paiement ON fond_de_soutiens.id = paiement.id_fond_soutien  GROUP BY fond_de_soutiens.id  ) AS B  WHERE montant_paye < montant and nom like '" & nom & "%'"
            cmd.CommandText = sql
            Dim result As MySqlDataReader = Nothing
            result = cmd.ExecuteReader

            If result.HasRows = False Then
                tempText = " Aucun étudiant trouvé"
            Else
                While result.Read

                    Dim entity As New FondSoutienEntity
                    entity.Id = result.GetValue(0).ToString
                    entity.Etudiant.nom = result.GetValue(1).ToString
                    entity.DateDepense = result.GetValue(2).ToString
                    entity.MontantSollicite = result.GetValue(3).ToString
                    entity.MontantRecu = result.GetValue(4).ToString
                    entity.Interet = result.GetValue(5).ToString
                    entity.Echeance = result.GetValue(6).ToString
                    entity.TypeBusiness = result.GetValue(7).ToString
                    entity.DateDebut = result.GetValue(8).ToString
                    entity.DateFin = result.GetValue(9).ToString
                    entity.Penalite = result.GetValue(10).ToString
                    entity.Etudiant.id = result.GetValue(11).ToString
                    entity.ModeReception = result.GetValue(12).ToString
                    entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                    entity.Paiement.MontantP = result.GetValue(14).ToString
                    fond.Add(entity)

                End While
            End If

            result.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return fond

    End Function

    Public Function GetByDateFond(ByVal dateDu As Date, ByVal dateAu As Date) As List(Of FondSoutienEntity)

        Dim revenu As List(Of FondSoutienEntity) = New List(Of FondSoutienEntity)

        Try

            Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
            Dim d2 As String = Format(dateAu, "yyyy-MM-dd")
            Dim cmd As MySqlCommand = Database.GetCommand

            'Dim _sql As String = "SELECT " & FOND_BASE_FIELDS & ", SUM(paiement.montant_paye) AS sum_montant_payer FROM  " & FOND_BASE_TABLE & " WHERE fond_de_soutiens.date_depense BETWEEN  '" & d1 & "' AND '" & d2 & "' GROUP BY fond_de_soutiens.id"

            Dim sql As String = "SELECT fond_de_soutiens.id, CONCAT_WS(' ', etudiants.nom, etudiants.prenom) AS etudiant, fond_de_soutiens.date_depense, fond_de_soutiens.montant_solicite,fond_de_soutiens.montant_recu,fond_de_soutiens.interet,fond_de_soutiens.echeance,fond_de_soutiens.type_business,fond_de_soutiens.date_debut,fond_de_soutiens.date_fin,fond_de_soutiens.penalite, fond_de_soutiens.id_etudiant, fond_de_soutiens.mode_reception, code_depenses.code, SUM(paiement.montant_paye) AS montant_payer FROM fond_de_soutiens INNER JOIN etudiants ON etudiants.id = fond_de_soutiens.id_etudiant INNER JOIN paiement ON paiement.id_fond_soutien = fond_de_soutiens.id INNER JOIN code_depenses ON code_depenses.id= fond_de_soutiens.id_code_depense  WHERE DATE(fond_de_soutiens.date_depense) BETWEEN  '" & d1 & "' AND '" & d2 & "' GROUP BY fond_de_soutiens.id"

            cmd.CommandText = sql

            Dim result As MySqlDataReader = Nothing

            result = cmd.ExecuteReader

            While result.Read
                Dim entity As FondSoutienEntity = New FondSoutienEntity
                entity.Id = result.GetValue(0).ToString
                entity.Etudiant.nom = result.GetValue(1).ToString
                entity.DateDepense = result.GetValue(2).ToString
                entity.MontantSollicite = result.GetValue(3).ToString
                entity.MontantRecu = result.GetValue(4).ToString
                entity.Interet = result.GetValue(5).ToString
                entity.Echeance = result.GetValue(6).ToString
                entity.TypeBusiness = result.GetValue(7).ToString
                entity.DateDebut = result.GetValue(8).ToString
                entity.DateFin = result.GetValue(9).ToString
                entity.Penalite = result.GetValue(10).ToString
                entity.Etudiant.id = result.GetValue(11).ToString
                entity.ModeReception = result.GetValue(12).ToString
                entity.CodeDepense.CodeRevenu = result.GetValue(13).ToString
                entity.Paiement.MontantP = result.GetValue(14).ToString
                revenu.Add(entity)
            End While

            result.Close()

            FillFondDataSource(cmd)

            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Database.CloseConnection()
        End Try

        Return revenu
    End Function


    Public Function GetPaiement(ByVal id As Integer) As Integer

        Dim id_fond As Integer = 0

        Dim cnx = Database.GetConnection

        Dim result As MySqlDataReader = Nothing

        Dim cmd As MySqlCommand = cnx.CreateCommand

        Try

            cmd.CommandText = "SELECT count(paiement.id_fond_soutien) from paiement WHERE id_fond_soutien='" & id & "'"

            result = cmd.ExecuteReader
            If result.HasRows Then
                result.Read()
                id_fond = result.GetValue(0).ToString
            End If

        Catch ex As MySqlException
            If My.Settings.app_debug_mode Then
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Else
                MsgBox("Echec de connexion a la db", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Else
                MsgBox("Erreur inconnue " & ex.Message, MsgBoxStyle.Critical)
            End If
        Finally
            Try
                If Not IsNothing(result) Then
                    result.Close()
                End If

                If Not IsNothing(cmd) Then
                    cmd.Dispose()
                    cmd.Connection.Close()
                End If
                Database.CloseConnection()
            Catch ex As Exception

            End Try
        End Try
        Return id_fond
    End Function


    ''' <summary>
    ''' Filling DataSource to generate a report
    ''' </summary>
    ''' <param name="cmd"></param>
    ''' <remarks></remarks>
    Private Sub FillFondDataSource(ByRef cmd As MySqlCommand)
        Try
            fond_data_source = New DataSetTables
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.FillAsync(fond_data_source.FondSoutiens)
            adapter.Dispose()
        Catch ex As Exception
            Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
        End Try
    End Sub

    ''' <summary>
    ''' Filling etudians data source
    ''' </summary>
    ''' <param name="cmd"></param>
    Private Sub FillDataSource(ByRef cmd As MySqlCommand)
        Try
            data_source = New DataSetTables
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.FillAsync(data_source.Etudiants)
            adapter.Dispose()
        Catch ex As Exception
            Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
        End Try
    End Sub

End Class

