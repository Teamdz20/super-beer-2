Namespace Db.Entities
    Public Class MaterielEntity
        Inherits EntraideOrm.Materiels

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
            TypeMateriel.FillFromDataRecord(myRecord)
            Employe.FillFromDataRecord(myRecord)
            Departement = New DepartementEntity(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("materiel_id")
            If Not myRecord("materiel_libelle") Is DBNull.Value Then libelle = myRecord("materiel_libelle")
            If Not myRecord("materiel_type_materiel_id") Is DBNull.Value Then type_materiel_id = myRecord("materiel_type_materiel_id")
            If Not myRecord("materiel_code") Is DBNull.Value Then code = myRecord("materiel_code")
            If Not myRecord("materiel_marque") Is DBNull.Value Then marque = myRecord("materiel_marque")
            If Not myRecord("materiel_description") Is DBNull.Value Then description = myRecord("materiel_description")
            If Not myRecord("materiel_num_facture") Is DBNull.Value Then num_facture = myRecord("materiel_num_facture")
            If Not myRecord("materiel_prix_achat") Is DBNull.Value Then prix_achat = myRecord("materiel_prix_achat")
            If Not myRecord("materiel_mode_obtention") Is DBNull.Value Then mode_obtention = myRecord("materiel_mode_obtention")
            If Not myRecord("materiel_ref_obtention_id") Is DBNull.Value Then ref_obtention_id = myRecord("materiel_ref_obtention_id")
            If Not myRecord("materiel_departement_id") Is DBNull.Value Then departement_id = myRecord("materiel_departement_id")
            If Not myRecord("materiel_activite_id") Is DBNull.Value Then activite_id = myRecord("materiel_activite_id")
            If Not myRecord("materiel_employe_id") Is DBNull.Value Then employe_id = myRecord("materiel_employe_id")
            If Not myRecord("materiel_amortissement_necessaire") Is DBNull.Value Then amortissement_necessaire = myRecord("materiel_amortissement_necessaire")
            If Not myRecord("materiel_annee_amortissement") Is DBNull.Value Then annee_amortissement = myRecord("materiel_annee_amortissement")
            If Not myRecord("materiel_montant_par_an") Is DBNull.Value Then montant_par_an = myRecord("materiel_montant_par_an")
            If Not myRecord("materiel_created") Is DBNull.Value Then created = myRecord("materiel_created")
            If Not myRecord("materiel_neuf") Is DBNull.Value Then neuf = myRecord("materiel_neuf")
            If Not myRecord("materiel_deja_utiliser") Is DBNull.Value Then deja_utiliser = myRecord("materiel_deja_utiliser")
            If Not myRecord("materiel_tres_bon_etat") Is DBNull.Value Then tres_bon_etat = myRecord("materiel_tres_bon_etat")
            If Not myRecord("materiel_avec_defaut") Is DBNull.Value Then avec_defaut = myRecord("materiel_avec_defaut")
            If Not myRecord("materiel_mauvaise_etat") Is DBNull.Value Then mauvaise_etat = myRecord("materiel_mauvaise_etat")
            If Not myRecord("materiel_activite") Is DBNull.Value Then activite = myRecord("materiel_activite")

        End Sub


#Region "Logical fields"
        Private _departement As DepartementEntity = Nothing
        Public Property Departement As DepartementEntity
            Get
                If IsNothing(_departement) Then _departement = New DepartementEntity
                Return _departement
            End Get
            Set(value As DepartementEntity)
                If Not value.Equals(_departement) Then
                    IsChanged = True
                End If
                _departement = value
            End Set
        End Property

        Private _type_materiel As TypeMaterielEntity = Nothing
        Public Property TypeMateriel As TypeMaterielEntity
            Get
                If IsNothing(_type_materiel) Then _type_materiel = New TypeMaterielEntity
                Return _type_materiel
            End Get
            Set(value As TypeMaterielEntity)
                If Not value.Equals(_type_materiel) Then IsChanged = True
                _type_materiel = value
            End Set
        End Property


        Private _employe As EmployeEntity = Nothing
        Public Property Employe As EmployeEntity
            Get
                If IsNothing(_employe) Then _employe = New EmployeEntity
                Return _employe
            End Get
            Set(value As EmployeEntity)
                If Not value.Equals(_employe) Then
                    IsChanged = True
                End If
                _employe = value
            End Set
        End Property


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


        Private _don As DonEntity
        Public Property Don As DonEntity
            Get
                If IsNothing(_don) Then _don = New DonEntity
                Return _don
            End Get
            Set(value As DonEntity)
                If Not value.Equals(_don) Then IsChanged = True
                _don = value
            End Set
        End Property

        Private _achat As AchatEntity
        Public Property Achat As AchatEntity
            Get
                If IsNothing(_achat) Then _achat = New AchatEntity
                Return _achat
            End Get
            Set(value As AchatEntity)
                If Not value.Equals(_achat) Then IsChanged = True
                _achat = value
            End Set
        End Property


        Private _quantite As Integer = 1
        Public Property quantite As Integer
            Get
                Return _quantite
            End Get
            Set(value As Integer)
                _quantite = value
            End Set
        End Property
#End Region

    End Class

End Namespace