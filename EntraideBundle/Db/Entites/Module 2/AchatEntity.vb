Namespace Db.Entities
    Public Class AchatEntity
        Inherits EntraideOrm.Achats


        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
            CodeDepense = New CodeDepenseEntity(myRecord)
            Fournisseur = New FournisseurEntity(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("achat_id")
            If Not myRecord("achat_fournisseur_id") Is DBNull.Value Then fournisseur_id = myRecord("achat_fournisseur_id")
            If Not myRecord("achat_code_depense_id") Is DBNull.Value Then code_depense_id = myRecord("achat_code_depense_id")
            If Not myRecord("achat_num_facture") Is DBNull.Value Then num_facture = myRecord("achat_num_facture")
            If Not myRecord("achat_prix_achat") Is DBNull.Value Then prix_achat = myRecord("achat_prix_achat")
            If Not myRecord("achat_cout") Is DBNull.Value Then cout = myRecord("achat_cout")
            If Not myRecord("achat_created") Is DBNull.Value Then created = myRecord("achat_created")
            If Not myRecord("achat_user_id") Is DBNull.Value Then user_id = myRecord("achat_user_id")
        End Sub


#Region "Relationship Properties"
        Private _code_depense As CodeDepenseEntity
        Public Property CodeDepense As CodeDepenseEntity
            Get
                If IsNothing(_code_depense) Then _code_depense = New CodeDepenseEntity
                Return _code_depense
            End Get
            Set(value As CodeDepenseEntity)
                If Not value.Equals(_code_depense) Then IsChanged = True
                _code_depense = value
            End Set
        End Property

        Private _fournisseur As FournisseurEntity
        Public Property Fournisseur As FournisseurEntity
            Get
                If IsNothing(_fournisseur) Then _fournisseur = New FournisseurEntity
                Return _fournisseur
            End Get
            Set(value As FournisseurEntity)
                If Not value.Equals(_fournisseur) Then IsChanged = True
                _fournisseur = value
            End Set
        End Property
#End Region

    End Class
End Namespace
