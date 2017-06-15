Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls
Imports EntraideBundle.Db

Public Class TableDepense

    Public Function GetAll() As DataTable
        Dim dataTable As New DataTable

        Try
            Dim cmd As MySqlCommand = Database.GetCommand
            cmd.CommandText = "SELECT * FROM depense"

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

    Public Function Save(ByVal depense As DemandeSoutien) As Long
        Dim id As Long
        Try
            Dim cnx As MySqlConnection = Database.GetConnection
            Dim trans As MySqlTransaction = cnx.BeginTransaction
            Dim cmd As MySqlCommand = cnx.CreateCommand

            'insert depense
            cmd.CommandText = "INSERT INTO fond_de_soutiens (date_depense, montant_solicite, montant_recu, interet, echeance,type_business, date_debut,  date_fin, penalite, id_etudiant, id_code_depense, mode_reception) VALUES (@date_depense, @montant_solicite, @montant_recu, @interet, @echeance,@type_business, @date_debut,  @date_fin, @penalite, @id_etudiant, @id_code_depense, @mode_reception)"
            cmd.Prepare()
            Dim mode_paiement As Integer = 1
            If depense.chkEspece.Checked Then
                mode_paiement = 1
            ElseIf depense.chkCheque.Checked Then
                mode_paiement = 2
            ElseIf depense.chkVirement.Checked Then
                mode_paiement = 3
            End If

            cmd.Parameters.AddWithValue("@date_depense", depense.dt_date.Value)
            cmd.Parameters.AddWithValue("@montant_solicite", depense.txtMontantSoli.Text)
            cmd.Parameters.AddWithValue("@montant_recu", depense.txtMontantRecu.Text)
            cmd.Parameters.AddWithValue("@interet", depense.txtInteret.Text)
            cmd.Parameters.AddWithValue("@echeance", depense.txtNbreRepaiement.Text)
            cmd.Parameters.AddWithValue("@type_business", depense.txtTypeBusiness.Text)
            cmd.Parameters.AddWithValue("@date_debut", depense.dtDebutPaiement.Value)
            cmd.Parameters.AddWithValue("@date_fin", depense.dtFinPaiement.Value)
            cmd.Parameters.AddWithValue("@penalite", depense.txtPenalite.Text)
            cmd.Parameters.AddWithValue("@id_etudiant", depense.id_etudiant.ToString)
            cmd.Parameters.AddWithValue("@id_code_depense", 1)
            cmd.Parameters.AddWithValue("@mode_reception", mode_paiement)

            cmd.ExecuteNonQuery()
            id = cmd.LastInsertedId
            cmd.Dispose()

            'insert paiement

            cmd = cnx.CreateCommand
            cmd.Transaction = trans
            cmd.CommandText = "INSERT INTO paiement(montant_paye, id_fond_soutien) VALUES (@montant_paye, @id_fond_soutien) "
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@montant_paye", 0)
            cmd.Parameters.AddWithValue("@id_fond_soutien", id)
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


        Return id

    End Function

    Public Function UpdateFond(ByVal depense As UpdateFond) As Long
        Dim id As Long = 0

        Try
            Dim cnx As MySqlConnection = Database.GetConnection
            Dim cmd = cnx.CreateCommand
            cmd.CommandText = "UPDATE fond_de_soutiens SET date_depense =@date_depense, montant_solicite=@montant_solicite, montant_recu=@montant_recu, interet=@interet, echeance=@echeance, type_business=@type_business, date_debut=@date_debut, date_fin=@date_fin, penalite=@penalite, mode_reception=@mode_reception WHERE id=@id"
            cmd.Prepare()
            Dim paie As Integer = 1
            If depense.chkEspece.Checked Then
                paie = 1
            ElseIf depense.chkCheque.Checked Then
                paie = 2
            ElseIf depense.chkVirement.Checked Then
                paie = 3
            End If
            cmd.Parameters.AddWithValue("@id", depense.id_depense)
            cmd.Parameters.AddWithValue("@date_depense", depense.dt_date.Value)
            cmd.Parameters.AddWithValue("@montant_solicite", depense.txtMontantSoli.Text)
            cmd.Parameters.AddWithValue("@montant_recu", depense.txtMontantRecu.Text)
            cmd.Parameters.AddWithValue("@interet", depense.txtIntere.Text)
            cmd.Parameters.AddWithValue("@echeance", depense.txtNombreRepaiement.Text)
            cmd.Parameters.AddWithValue("@type_business", depense.txtTypeBusiness.Text)
            cmd.Parameters.AddWithValue("@date_debut", depense.dtDebutP.Value)
            cmd.Parameters.AddWithValue("@date_fin", depense.dtFinP.Value)
            cmd.Parameters.AddWithValue("@penalite", depense.txtPenalites.Text)
            cmd.Parameters.AddWithValue("@mode_reception", paie)

            id = cmd.ExecuteNonQuery()

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
