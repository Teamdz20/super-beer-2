Imports EntraideBundle.Db.Entities

Public Class EtudiantEntity


    Private _id As Integer = 0
    Private _date As Date
    Private _nom As String
    Private _prenom As String
    Private _sexe As Char
    Private _situation As String
    Private _nbreenfant As Integer = 0
    Private _lieu As String
    Private _nationalite As String
    Private _adresse As String
    Private _bp As String
    Private _tel1 As String
    Private _tel2 As String
    Private _email As String
    Private _autrereligion As String
    Private _delit As String
    Private _formation As String
    Private _typeFormation As String
    Private _niveau As String
    Private _nomUrgence As String
    Private _adresseUrgence As String
    Private _phoneUrgence As String
    Private _emailUrgence As String
    Private _code As String
    Private _typeEmploi As String
    Private _business As String
    Private _typeBusiness As String
    Private _nbreEmployes As Integer = 0
    Private _annexe As Integer = 0

    Private _paiement As PaiementEntity


    Private _religion As ReligionEntity
    Private _typeFormationId As TypeFormationEntity
    Private _revenu As RevenuEntity
    Private _formationT As FormationEntity


    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Date_revenu As Date
        Get
            Return _date
        End Get
        Set(value As Date)
            _date = value
        End Set
    End Property

    Public Property nom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property
    Public Property prenom As String
        Get
            Return _prenom
        End Get
        Set(value As String)
            _prenom = value
        End Set
    End Property
    Public Property sexe As Char
        Get
            Return _sexe
        End Get
        Set(value As Char)
            _sexe = value
        End Set
    End Property

    Public Property situation_matri As String
        Get
            Return _situation
        End Get
        Set(value As String)
            _situation = value
        End Set
    End Property
    Public Property nombre_enfant As Integer
        Get
            Return _nbreenfant
        End Get
        Set(value As Integer)
            _nbreenfant = value
        End Set
    End Property
    Public Property lieu_naissance As String
        Get
            Return _lieu
        End Get
        Set(value As String)
            _lieu = value
        End Set
    End Property
    Public Property nationnalite As String
        Get
            Return _nationalite
        End Get
        Set(value As String)
            _nationalite = value
        End Set
    End Property
    Public Property adresse As String
        Get
            Return _adresse
        End Get
        Set(value As String)
            _adresse = value
        End Set
    End Property
    Public Property bp As String
        Get
            Return _bp
        End Get
        Set(value As String)
            _bp = value
        End Set
    End Property
    Public Property tel1 As String
        Get
            Return _tel1
        End Get
        Set(value As String)
            _tel1 = value
        End Set
    End Property
    Public Property tel2 As String
        Get
            Return _tel2
        End Get
        Set(value As String)
            _tel2 = value
        End Set
    End Property
    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property autre_religion As String
        Get
            Return _autrereligion
        End Get
        Set(value As String)
            _autrereligion = value
        End Set
    End Property
    Public Property delit As String
        Get
            Return _delit
        End Get
        Set(value As String)
            _delit = value
        End Set
    End Property
    Public Property formation_recu As String
        Get
            Return _formation
        End Get
        Set(value As String)
            _formation = value
        End Set
    End Property
    Public Property TypeFormation As String
        Get
            Return _typeFormation
        End Get
        Set(value As String)
            _typeFormation = value
        End Set
    End Property
    Public Property niveau As String
        Get
            Return _niveau
        End Get
        Set(value As String)
            _niveau = value
        End Set
    End Property
    Public Property nom_urgence As String
        Get
            Return _nomUrgence
        End Get
        Set(value As String)
            _nomUrgence = value
        End Set
    End Property
    Public Property adresse_urgence As String
        Get
            Return _adresseUrgence
        End Get
        Set(value As String)
            _adresseUrgence = value
        End Set
    End Property
    Public Property mail_urgence As String
        Get
            Return _emailUrgence
        End Get
        Set(value As String)
            _emailUrgence = value
        End Set
    End Property
    Public Property phone_urgence As String
        Get
            Return _phoneUrgence
        End Get
        Set(value As String)
            _phoneUrgence = value
        End Set
    End Property
    Public Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property
    Public Property type_emploie As String
        Get
            Return _typeEmploi
        End Get
        Set(value As String)
            _typeEmploi = value
        End Set
    End Property
    Public Property business As String
        Get
            Return _business
        End Get
        Set(value As String)
            _business = value
        End Set
    End Property
    Public Property type_business As String
        Get
            Return _typeBusiness
        End Get
        Set(value As String)
            _typeBusiness = value
        End Set
    End Property
    Public Property nombre_employe As Integer
        Get
            Return _nbreEmployes
        End Get
        Set(value As Integer)
            _nbreEmployes = value
        End Set
    End Property
    Public Property annexe As Integer
        Get
            Return _annexe
        End Get
        Set(value As Integer)
            _annexe = value
        End Set
    End Property








    Public Property Religion As ReligionEntity
        Get
            If IsNothing(_religion) Then
                _religion = New ReligionEntity
            End If

            Return _religion
        End Get
        Set(value As ReligionEntity)
            _religion = value
        End Set
    End Property

    Public Property Paiement As PaiementEntity
        Get
            If IsNothing(_paiement) Then
                _paiement = New PaiementEntity
            End If

            Return _paiement
        End Get
        Set(value As PaiementEntity)
            _paiement = value
        End Set
    End Property

    Public Property TypeFormationId As TypeFormationEntity
        Get
            If IsNothing(_typeFormationId) Then
                _typeFormationId = New TypeFormationEntity
            End If

            Return _typeFormationId
        End Get
        Set(value As TypeFormationEntity)
            _typeFormationId = value
        End Set
    End Property

    Public Property Revenu As RevenuEntity
        Get
            If IsNothing(_revenu) Then
                _revenu = New RevenuEntity
            End If

            Return _revenu
        End Get
        Set(value As RevenuEntity)
            _revenu = value
        End Set
    End Property

    Public Property Formation As FormationEntity
        Get
            If IsNothing(_formationT) Then
                _formationT = New FormationEntity
            End If

            Return _formationT
        End Get
        Set(value As FormationEntity)
            _formationT = value
        End Set
    End Property

    Private _generation_id As String = ""
    Property generation_id As String
        Get
            Return _generation_id
        End Get
        Set(value As String)
            _generation_id = value
        End Set
    End Property

    Public Property generation As String
End Class

