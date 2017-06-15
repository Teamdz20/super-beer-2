Namespace Db.Entities
    Public Class FournisseurEntity
        Inherits EntraideOrm.Fournisseurs


        Public Sub New()

        End Sub


        Public Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
            Try
                _user = New UserEntity(myRecord)
                _categorie_fournisseur = New CategorieFournisseurEntity
                _categorie_fournisseur.Id = myRecord("categorie_fournisseur_id")
                If Not myRecord("categorie_fournisseur_nom") Is DBNull.Value Then _categorie_fournisseur.Nom = myRecord("categorie_fournisseur_nom")
            Catch ex As Exception

            End Try
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("fournisseur_id")
            If Not myRecord("fournisseur_created") Is DBNull.Value Then created = myRecord("fournisseur_created")
            If Not myRecord("fournisseur_nom") Is DBNull.Value Then nom = myRecord("fournisseur_nom")
            If Not myRecord("fournisseur_nom_representant") Is DBNull.Value Then nom_representant = myRecord("fournisseur_nom_representant")
            If Not myRecord("fournisseur_poste") Is DBNull.Value Then poste = myRecord("fournisseur_poste")
            If Not myRecord("fournisseur_code") Is DBNull.Value Then code = myRecord("fournisseur_code")
            If Not myRecord("fournisseur_adresse") Is DBNull.Value Then adresse = myRecord("fournisseur_adresse")
            If Not myRecord("fournisseur_tel1") Is DBNull.Value Then tel1 = myRecord("fournisseur_tel1")
            If Not myRecord("fournisseur_tel2") Is DBNull.Value Then tel2 = myRecord("fournisseur_tel2")
            If Not myRecord("fournisseur_site") Is DBNull.Value Then site = myRecord("fournisseur_site")
            If Not myRecord("fournisseur_email") Is DBNull.Value Then email = myRecord("fournisseur_email")
            If Not myRecord("fournisseur_domaine_business") Is DBNull.Value Then domaine_business = myRecord("fournisseur_domaine_business")
            If Not myRecord("fournisseur_produit") Is DBNull.Value Then produit = myRecord("fournisseur_produit")
            If Not myRecord("fournisseur_classification_prix") Is DBNull.Value Then classification_prix = myRecord("fournisseur_classification_prix")
            If Not myRecord("fournisseur_note") Is DBNull.Value Then note = myRecord("fournisseur_note")
            If Not myRecord("fournisseur_categorie_fournisseur_id") Is DBNull.Value Then categorie_fournisseur_id = myRecord("fournisseur_categorie_fournisseur_id")
            If Not myRecord("fournisseur_user_id") Is DBNull.Value Then user_id = myRecord("fournisseur_user_id")
        End Sub

#Region "Virtual Field"
        Private _categorie_fournisseur As CategorieFournisseurEntity
        Public Property CategorieFournisseur As CategorieFournisseurEntity
            Get
                Return _categorie_fournisseur
            End Get
            Set(value As CategorieFournisseurEntity)
                _categorie_fournisseur = value
            End Set
        End Property

        Private _user As UserEntity
        Public Property User As UserEntity
            Get
                Return _user
            End Get
            Set(value As UserEntity)
                _user = value
            End Set
        End Property
#End Region

    End Class

End Namespace