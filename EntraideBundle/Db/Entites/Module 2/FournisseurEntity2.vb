Imports EntraideBundle.Db.Entities

Public Class FournisseurEntity2
    Private _id As Integer = 0
    Private _nom As String
    Private _created As Date
    Private _code As String
    Private _adresse As String
    Private _email As String
    Private _tel1 As String
    Private _tel2 As String
    Private _site As String
    Private _domaineBusiness As String
    Private _classificationPrix As String
    Private _note As String
    Private _nomRepresentant As String
    Private _poste As String
    Private _produit As String
    Private _categorieDonneur As CategorieDonneurEntity
    Private _user As UserEntity
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set

    End Property
    Public Property DateFournisseur As Date
        Get
            Return _created
        End Get
        Set(value As Date)
            _created = value
        End Set

    End Property
    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set

    End Property
    Public Property Adresse As String
        Get
            Return _adresse
        End Get
        Set(value As String)
            _adresse = value
        End Set

    End Property
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set

    End Property
    Public Property Tel1 As String
        Get
            Return _tel1
        End Get
        Set(value As String)
            _tel1 = value
        End Set

    End Property
    Public Property Tel2 As String
        Get
            Return _tel2
        End Get
        Set(value As String)
            _tel2 = value
        End Set

    End Property
    Public Property Site As String
        Get
            Return _site
        End Get
        Set(value As String)
            _site = value
        End Set

    End Property
    Public Property DomaineBusiness As String
        Get
            Return _domaineBusiness
        End Get
        Set(value As String)
            _domaineBusiness = value
        End Set

    End Property
    Public Property ClassificationPrix As String
        Get
            Return _classificationPrix
        End Get
        Set(value As String)
            _classificationPrix = value
        End Set

    End Property
    Public Property Note As String
        Get
            Return _note
        End Get
        Set(value As String)
            _note = value
        End Set

    End Property
    Public Property Nomrepresentant As String
        Get
            Return _nomRepresentant
        End Get
        Set(value As String)
            _nomRepresentant = value
        End Set

    End Property
    Public Property Poste As String
        Get
            Return _poste
        End Get
        Set(value As String)
            _poste = value
        End Set

    End Property
    Public Property Produit As String
        Get
            Return _produit
        End Get
        Set(value As String)
            _produit = value
        End Set

    End Property
    Public Property CategorieDonneur As CategorieDonneurEntity
        Get
            If IsNothing(_categorieDonneur) Then
                _categorieDonneur = New CategorieDonneurEntity
            End If

            Return _categorieDonneur
        End Get
        Set(value As CategorieDonneurEntity)
            _categorieDonneur = value
        End Set
    End Property
    Public Property User As UserEntity
        Get
            If IsNothing(_user) Then
                _user = New UserEntity
            End If

            Return _user
        End Get
        Set(value As UserEntity)
            _user = value
        End Set
    End Property

End Class
