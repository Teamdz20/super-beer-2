Imports EntraideBundle.Db.Entities
Imports MySql.Data.MySqlClient

Namespace Db.Tables
    Public Class AchatsTable


#Region "Constants"
        Private Const TABLE_FIELDS As String = "achats.id AS achat_id, achats.fournisseur_id AS achat_fournisseur_id, achats.code_depense_id AS achat_code_depense_id, achats.num_facture AS achat_num_facture, achats.prix_achat AS achat_prix_achat, achats.cout AS achat_cout, achats.created AS achat_created, achats.user_id AS achat_user_id, fournisseurs.id AS fournisseur_id, fournisseurs.created AS fournisseur_created, fournisseurs.nom AS fournisseur_nom, fournisseurs.nom_representant AS fournisseur_nom_representant, fournisseurs.poste AS fournisseur_poste, fournisseurs.code AS fournisseur_code, fournisseurs.adresse AS fournisseur_adresse, fournisseurs.tel1 AS fournisseur_tel1, fournisseurs.tel2 AS fournisseur_tel2, fournisseurs.site AS fournisseur_site, fournisseurs.email AS fournisseur_email, fournisseurs.domaine_business AS fournisseur_domaine_business, fournisseurs.produit AS fournisseur_produit, fournisseurs.classification_prix AS fournisseur_classification_prix, fournisseurs.note AS fournisseur_note, fournisseurs.categorie_fournisseur_id AS fournisseur_categorie_fournisseur_id, fournisseurs.user_id AS fournisseur_user_id, code_depenses.id AS code_depense_id, code_depenses.nom AS code_depense_nom, code_depenses.code AS code_depense_code"
#End Region


        Public Function GetById(ByRef id As String) As AchatEntity
            Dim achat As AchatEntity = New AchatEntity

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT " & TABLE_FIELDS & " FROM achats INNER JOIN fournisseurs ON achats.fournisseur_id = fournisseurs.id INNER JOIN code_depenses ON achats.code_depense_id = code_depenses.id WHERE achats.id = @id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", id)

                Dim result As MySqlDataReader = cmd.ExecuteReader
                While result.Read
                    achat = New AchatEntity(result)
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

            Return achat
        End Function


    End Class
End Namespace
