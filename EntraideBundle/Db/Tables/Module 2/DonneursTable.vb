Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls
Imports EntraideBundle.Db.Entities

Namespace Db.Tables

    Public Class DonneursTable


#Region "Constants"
        Public Const P_K As String = "id"

        Public Const D_N As String = "nom"

        Public Const TABLE_FIELDS As String = ""

        Public Const SQL_COMBO As String = "SELECT id, code, nom FROM donneurs"

        Private Const BASE_FIELDS As String = "donneurs.id AS donneur_id, donneurs.date AS donneur_date, donneurs.nom AS donneur_nom, donneurs.code AS donneur_code, donneurs.adresse AS donneur_adresse, donneurs.email AS donneur_email, donneurs.tel1 AS donneur_tel1, donneurs.tel2 AS donneur_tel2, donneurs.categorie_donneur_id AS donneur_categorie_donneur_id, donneurs.site_internet AS donneur_site_internet, donneurs.restriction AS donneur_restriction, donneurs.periode_sollicitation AS donneur_periode_sollicitation, donneurs.note_sollicitation AS donneur_note_sollicitation, donneurs.nom_representant AS donneur_nom_representant, donneurs.poste AS donneur_poste, donneurs.user_id AS donneur_user_id, donneurs.type_don AS donneur_type_don, categorie_donneurs.id AS categorie_donneur_id, categorie_donneurs.nom AS categorie_donneur_nom, users.username AS user_username"

        Private Const BASE_TABLE As String = "donneurs INNER JOIN categorie_donneurs ON categorie_donneurs.id = donneurs.categorie_donneur_id INNER JOIN users ON users.id = donneurs.user_id"

#End Region

        Public Shared data_source As DataSetTables = Nothing

        Public Function GetAll() As DataTable
            Dim dataTable As New DataTable

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT * FROM donneurs"

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

        Public Function Save(ByVal donneur As AddDonneur) As Long
            Dim id As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand

                'insert donneur
                cmd.CommandText = "INSERT INTO donneurs(date, nom, adresse, email, tel1, tel2, site_internet, restriction, periode_sollicitation, note_sollicitation, nom_representant, poste, type_don, user_id, categorie_donneur_id) VALUES(@date, @nom, @adresse, @email, @tel1, @tel2, @site_internet, @restriction, @periode_sollicite, @note_sollicitation, @nom_representant, @poste, @type_don, @user_id, @categorie_donneur_id)"
                Dim restriction As Integer = 1
                Dim typeDon As Integer = 1
                If donneur.cmbProcedure.Text = " Sollicité" Then
                    restriction = 1
                ElseIf donneur.cmbProcedure.Text = "Non sollicité" Then
                    restriction = 2
                End If
                If donneur.cmbTypeDon.Text = "Argent" Then
                    typeDon = 1
                ElseIf donneur.cmbTypeDon.Text = "Matériel" Then
                    typeDon = 2
                End If


                cmd.Prepare()
                cmd.Parameters.AddWithValue("@date", donneur.dt_date.Value)
                cmd.Parameters.AddWithValue("@nom", donneur.txtNomDonneur.Text)
                cmd.Parameters.AddWithValue("@adresse", donneur.txtAdresse.Text)
                cmd.Parameters.AddWithValue("@email", donneur.txtMail.Text)
                cmd.Parameters.AddWithValue("@tel1", donneur.txtPhone1.Text)
                cmd.Parameters.AddWithValue("@tel2", donneur.txtPhone2.Text)
                cmd.Parameters.AddWithValue("@site_internet", donneur.txtSite.Text)
                cmd.Parameters.AddWithValue("@restriction", restriction)
                cmd.Parameters.AddWithValue("@periode_sollicite", donneur.txtPeriodeSollicitation.Text)
                cmd.Parameters.AddWithValue("@note_sollicitation", donneur.txtNote.Text)
                cmd.Parameters.AddWithValue("@nom_representant", donneur.txtNomRepresentant.Text)
                cmd.Parameters.AddWithValue("@poste", donneur.txtPoste.Text)
                cmd.Parameters.AddWithValue("@type_don", typeDon)
                cmd.Parameters.AddWithValue("@user_id", 1)
                cmd.Parameters.AddWithValue("@categorie_donneur_id", donneur.cmbCategorieDonneur.SelectedValue.ToString)
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


        Public Function GetByDate(ByVal dateDu As Date, ByVal dateAU As Date) As List(Of DonneurEntity)

            Dim donneur As List(Of DonneurEntity) = New List(Of DonneurEntity)

            Try
                Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
                Dim d2 As String = Format(dateAU, "yyyy-MM-dd")
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT " & BASE_FIELDS & " FROM " & BASE_TABLE & " WHERE donneurs.date BETWEEN '" & d1 & "' AND '" & d2 & "' "
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                While result.Read

                    Dim entity As New DonneurEntity(result)
                    donneur.Add(entity)

                End While

                result.Close()

                FillDataSource(cmd)

                cmd.Dispose()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return donneur
        End Function

        Public Function GetByNom(ByVal dateDu As Date, ByVal dateAU As Date, ByVal nom As String) As List(Of DonneurEntity)
            Dim donneur As List(Of DonneurEntity) = New List(Of DonneurEntity)
            Try
                Dim d1 As String = Format(dateDu, "yyyy-MM-dd")
                Dim d2 As String = Format(dateAU, "yyyy-MM-dd")
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = "SELECT " & BASE_FIELDS & " FROM " & BASE_TABLE & " WHERE donneurs.date BETWEEN '" & d1 & "' AND '" & d2 & "' AND donneurs.nom LIKE '" & nom & "%' "
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader


                While result.Read
                    Dim entity As New DonneurEntity(result)
                    donneur.Add(entity)
                End While

                result.Close()

                FillDataSource(cmd)

                cmd.Dispose()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return donneur
        End Function

        Public Function GetByCode(ByVal code As String) As List(Of DonneurEntity)
            Dim donneur As List(Of DonneurEntity) = New List(Of DonneurEntity)
            Try

                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand
                cmd.CommandText = " SELECT " & BASE_FIELDS & " FROM " & BASE_TABLE & " WHERE donneurs.code= '" & code & "' "
                Dim result As MySqlDataReader = Nothing
                result = cmd.ExecuteReader

                If result.HasRows = False Then
                    Util.ShowMessage(UpdateDonneur, " Aucun étudiant trouvé avec les filtres selectionnés, Essayez la recherche tout confondu", 1)
                Else
                    While result.Read
                        Dim entity As New DonneurEntity(result)
                        donneur.Add(entity)
                    End While
                End If

                result.Close()

                FillDataSource(cmd)

                cmd.Dispose()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Database.CloseConnection()
            End Try

            Return donneur
        End Function

        Public Function Update(ByVal donneur As UpdateDonneur) As Long
            Dim execute As Long = 0
            Try
                Dim cnx As MySqlConnection = Database.GetConnection
                Dim cmd As MySqlCommand = cnx.CreateCommand

                'update donneur
                cmd.CommandText = "UPDATE donneurs SET date=@date, nom=@nom, adresse =@adresse, email=@email, tel1=@tel1, tel2=@tel2, site_internet=@site_internet, restriction=@restriction, periode_sollicitation=@periode_sollicitation, note_sollicitation=@note_sollicitation, nom_representant=@nom_representant, poste=@poste, type_don=@type_don, user_id=@user_id, categorie_donneur_id=@categorie_donneur_id WHERE id=@id"
                Dim restriction As Integer = 1
                Dim typeDon As Integer = 1
                If donneur.cmbProcedure.Text = " Sollicité" Then
                    restriction = 1
                ElseIf donneur.cmbProcedure.Text = "Non sollicité" Then
                    restriction = 2
                End If
                If donneur.cmbTypeDon.Text = "Argent" Then
                    typeDon = 1
                ElseIf donneur.cmbTypeDon.Text = "Matériel" Then
                    typeDon = 2
                End If


                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", donneur.id_donneur)
                cmd.Parameters.AddWithValue("@date", donneur.dt_date.Value)
                cmd.Parameters.AddWithValue("@nom", donneur.txtNomDonneur.Text)
                cmd.Parameters.AddWithValue("@adresse", donneur.txtAdresse.Text)
                cmd.Parameters.AddWithValue("@email", donneur.txtMail.Text)
                cmd.Parameters.AddWithValue("@tel1", donneur.txtPhone1.Text)
                cmd.Parameters.AddWithValue("@tel2", donneur.txtPhone2.Text)
                cmd.Parameters.AddWithValue("@site_internet", donneur.txtSite.Text)
                cmd.Parameters.AddWithValue("@restriction", restriction)
                cmd.Parameters.AddWithValue("@periode_sollicitation", donneur.txtPeriodeSollicitation.Text)
                cmd.Parameters.AddWithValue("@note_sollicitation", donneur.txtNote.Text)
                cmd.Parameters.AddWithValue("@nom_representant", donneur.txtNomRepresentant.Text)
                cmd.Parameters.AddWithValue("@poste", donneur.txtPoste.Text)
                cmd.Parameters.AddWithValue("@type_don", typeDon)
                cmd.Parameters.AddWithValue("@user_id", 1)
                cmd.Parameters.AddWithValue("@categorie_donneur_id", donneur.cmbCategorieDonneur.SelectedValue.ToString)
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
                adapter.FillAsync(data_source.Donneurs)
                adapter.Dispose()
            Catch ex As Exception
                Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
            End Try
        End Sub

    End Class

End Namespace
