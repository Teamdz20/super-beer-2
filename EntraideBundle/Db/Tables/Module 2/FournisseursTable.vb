Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls
Imports EntraideBundle.Db
Imports EntraideBundle.Db.Entities

Namespace Db.Tables

    Public Class FournisseursTable

#Region "Conctants"
        Private Const BASE_FIELDS As String = "fournisseurs.id AS fournisseur_id, fournisseurs.created AS fournisseur_created, fournisseurs.nom AS fournisseur_nom, fournisseurs.nom_representant AS fournisseur_nom_representant, fournisseurs.poste AS fournisseur_poste, fournisseurs.code AS fournisseur_code, fournisseurs.adresse AS fournisseur_adresse, fournisseurs.tel1 AS fournisseur_tel1, fournisseurs.tel2 AS fournisseur_tel2, fournisseurs.site AS fournisseur_site, fournisseurs.email AS fournisseur_email, fournisseurs.domaine_business AS fournisseur_domaine_business, fournisseurs.produit AS fournisseur_produit, fournisseurs.classification_prix AS fournisseur_classification_prix, fournisseurs.note AS fournisseur_note, fournisseurs.categorie_fournisseur_id AS fournisseur_categorie_fournisseur_id, fournisseurs.user_id AS fournisseur_user_id, categorie_fournisseurs.id AS categorie_fournisseur_id, categorie_fournisseurs.nom AS categorie_fournisseur_nom, users.id AS user_id, users.username AS user_username, users.password AS user_password, users.employe_id AS user_employe_id, users.state AS user_state, users.last_login AS user_last_login"

        Private Const BASE_TABLE As String = "fournisseurs INNER JOIN categorie_fournisseurs ON categorie_fournisseurs.id = fournisseurs.categorie_fournisseur_id INNER JOIN users ON users.id = fournisseurs.user_id"
#End Region

        Public Shared data_source As DataSetTables = Nothing

        Public Function GetAll() As DataTable

            Dim dataTable As New DataTable

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT * FROM fournisseurs"

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


        Public Function Save(ByVal fournisseur As AddFournisseur) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand

                'insert donneur
                cmd.CommandText = "INSERT INTO fournisseurs(date, nom, adresse, email, tel1, tel2, site, domaine_business, classification_prix, note, nom_representant, poste, produit, user_id, categorie_fournisseur_id) VALUES(@date, @nom, @adresse, @email, @tel1, @tel2, @site_internet, @domaine_business, @classification_prix, @note, @nom_representant, @poste, @produit, @user_id, @categorie_fournisseur_id)"
                Dim prix As Integer = 1

                If fournisseur.cmbClassification.Text = " Excellent prix" Then
                    prix = 1
                ElseIf fournisseur.cmbClassification.Text = "Bon prix" Then
                    prix = 2

                ElseIf fournisseur.cmbClassification.Text = "Assez bon prix" Then
                    prix = 3
                ElseIf fournisseur.cmbClassification.Text = "Mauvais prix" Then
                    prix = 4
                End If


                cmd.Prepare()
                cmd.Parameters.AddWithValue("@date", fournisseur.dt_date.Value)
                cmd.Parameters.AddWithValue("@nom", fournisseur.txtNomSociete.Text)
                cmd.Parameters.AddWithValue("@adresse", fournisseur.txtAdresse.Text)
                cmd.Parameters.AddWithValue("@email", fournisseur.txtMail.Text)
                cmd.Parameters.AddWithValue("@tel1", fournisseur.txtPhone1.Text)
                cmd.Parameters.AddWithValue("@tel2", fournisseur.txtPhone2.Text)
                cmd.Parameters.AddWithValue("@site_internet", fournisseur.txtSite.Text)
                cmd.Parameters.AddWithValue("@domaine_business", fournisseur.txtDomaine.Text)
                cmd.Parameters.AddWithValue("@classification_prix", prix)
                cmd.Parameters.AddWithValue("@note", fournisseur.txtNote.Text)
                cmd.Parameters.AddWithValue("@nom_representant", fournisseur.txtNomRepresentant.Text)
                cmd.Parameters.AddWithValue("@poste", fournisseur.txtPoste.Text)
                cmd.Parameters.AddWithValue("@produit", fournisseur.txtProduit.Text)
                cmd.Parameters.AddWithValue("@user_id", 1)
                cmd.Parameters.AddWithValue("@categorie_fournisseur_id", fournisseur.cmbCategorie.SelectedValue.ToString)
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


        Public Function GetByDate(ByVal dateDu As Date, ByVal dateAU As Date) As List(Of FournisseurEntity)

            Dim donneur As List(Of FournisseurEntity) = New List(Of FournisseurEntity)

            Try
                Dim d1 As String = Format(dateDu, "yyyy-MM-dd")

                Dim d2 As String = Format(dateAU, "yyyy-MM-dd")

                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT " & BASE_FIELDS & " FROM " & BASE_TABLE & " WHERE fournisseurs.created BETWEEN '" & d1 & "' AND '" & d2 & "' "

                Dim result = cmd.ExecuteReader

                While result.Read

                    Dim entity As New FournisseurEntity(result)

                    donneur.Add(entity)

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

            Return donneur
        End Function

        Public Function GetByNom(ByVal dateDu As Date, ByVal dateAU As Date, ByVal nom As String) As List(Of FournisseurEntity)
            Dim donneur As List(Of FournisseurEntity) = New List(Of FournisseurEntity)
            Try
                Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
                Dim d2 As String = Format(dateAU, "yyyy-MM-dd")

                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT " & BASE_FIELDS & " FROM " & BASE_TABLE & " WHERE fournisseurs.created BETWEEN '" & d1 & "' AND '" & d2 & "' AND fournisseurs.nom LIKE '" & nom & "%' "
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read

                    Dim entity As New FournisseurEntity(result)

                    donneur.Add(entity)

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

            Return donneur
        End Function

        Public Function GetByCode(ByVal code As String) As List(Of FournisseurEntity)

            Dim donneur As List(Of FournisseurEntity) = New List(Of FournisseurEntity)

            Try

                Dim cmd As MySqlCommand = Database.GetCommand

                cmd.CommandText = "SELECT " & BASE_FIELDS & " FROM " & BASE_TABLE & " WHERE fournisseurs.code = '" & code & "' "

                Dim result = cmd.ExecuteReader

                While result.Read

                    Dim entity As New FournisseurEntity(result)

                    donneur.Add(entity)

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

            Return donneur

        End Function

        Public Function Update(ByVal fournisseur As UpdateFournisseur) As Long
            Dim execute As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand

                'update donneur
                cmd.CommandText = "UPDATE fournisseurs SET date=@date, nom=@nom, adresse =@adresse, email=@email, tel1=@tel1, tel2=@tel2, site=@site_internet, domaine_business=@domaine_business, classification_prix=@classification_prix, note=@note, nom_representant=@nom_representant, poste=@poste, produit=@produit, user_id=@user_id, categorie_fournisseur_id=@categorie_fournisseur_id WHERE id=@id"
                Dim prix As Integer = 1
                If fournisseur.cmbClassification.Text = " Excellent prix" Then
                    prix = 1
                ElseIf fournisseur.cmbClassification.Text = "Bon prix" Then
                    prix = 2

                ElseIf fournisseur.cmbClassification.Text = "Assez bon prix" Then
                    prix = 3
                ElseIf fournisseur.cmbClassification.Text = "Mauvais prix" Then
                    prix = 4
                End If

                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", fournisseur.id_fournisseur)
                cmd.Parameters.AddWithValue("@date", fournisseur.dt_date.Value)
                cmd.Parameters.AddWithValue("@nom", fournisseur.txtNomSociete.Text)
                cmd.Parameters.AddWithValue("@adresse", fournisseur.txtAdresse.Text)
                cmd.Parameters.AddWithValue("@email", fournisseur.txtMail.Text)
                cmd.Parameters.AddWithValue("@tel1", fournisseur.txtPhone1.Text)
                cmd.Parameters.AddWithValue("@tel2", fournisseur.txtPhone2.Text)
                cmd.Parameters.AddWithValue("@site_internet", fournisseur.txtSite.Text)
                cmd.Parameters.AddWithValue("@domaine_business", fournisseur.txtDomaine.Text)
                cmd.Parameters.AddWithValue("@classification_prix", prix)
                cmd.Parameters.AddWithValue("@note", fournisseur.txtNote.Text)
                cmd.Parameters.AddWithValue("@nom_representant", fournisseur.txtNomRepresentant.Text)
                cmd.Parameters.AddWithValue("@poste", fournisseur.txtPoste.Text)
                cmd.Parameters.AddWithValue("@produit", fournisseur.txtProduit.Text)
                cmd.Parameters.AddWithValue("@user_id", 1)
                cmd.Parameters.AddWithValue("@categorie_fournisseur_id", fournisseur.cmbCategorie.SelectedValue.ToString)
                execute = cmd.ExecuteNonQuery()

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
            Return execute
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
                adapter.FillAsync(data_source.Fournisseurs)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
            End Try
        End Sub

    End Class

End Namespace