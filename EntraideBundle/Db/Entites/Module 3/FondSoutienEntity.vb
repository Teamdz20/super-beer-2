Public Class FondSoutienEntity
    Private _id As Integer = 0
    Private _date As Date
    Private _montantSollicite As Integer = 0
    Private _montantrecu As Integer = 0
    Private _interet As Integer = 0
    Private _echeance As Integer = 0
    Private _type_business As String
    Private _dateDebutP As Date
    Private _dateFinP As Date
    Private _penalite As Integer
    Private _modeReception As String
    Private _paiement As PaiementEntity
    Private _etudiant As EtudiantEntity
    Public _code As CodeDepenseEntity

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property DateDepense As Date
        Get
            Return _date
        End Get
        Set(value As Date)
            _date = value
        End Set
    End Property
    Public Property MontantSollicite As Integer
        Get
            Return _montantSollicite
        End Get
        Set(value As Integer)
            _montantSollicite = value
        End Set
    End Property
    Public Property MontantRecu As Integer
        Get
            Return _montantrecu
        End Get
        Set(value As Integer)
            _montantrecu = value
        End Set
    End Property
    Public Property Interet As Integer
        Get
            Return _interet
        End Get
        Set(value As Integer)
            _interet = value
        End Set
    End Property
    Public Property Echeance As Integer
        Get
            Return _echeance
        End Get
        Set(value As Integer)
            _echeance = value
        End Set
    End Property
    Public Property TypeBusiness As String
        Get
            Return _type_business
        End Get
        Set(value As String)
            _type_business = value
        End Set
    End Property
    Public Property ModeReception As String
        Get
            Return _modeReception
        End Get
        Set(value As String)
            _modeReception = value
        End Set
    End Property
    Public Property DateDebut As Date
        Get
            Return _dateDebutP
        End Get
        Set(value As Date)
            _dateDebutP = value
        End Set
    End Property
    Public Property DateFin As Date
        Get
            Return _dateFinP
        End Get
        Set(value As Date)
            _dateFinP = value
        End Set
    End Property
    Public Property Penalite As Integer
        Get
            Return _penalite
        End Get
        Set(value As Integer)
            _penalite = value
        End Set
    End Property
    Public Property Etudiant As EtudiantEntity
        Get
            If IsNothing(_etudiant) Then
                _etudiant = New EtudiantEntity
            End If

            Return _etudiant
        End Get
        Set(value As EtudiantEntity)
            _etudiant = value
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
    Public Property CodeDepense As CodeDepenseEntity
        Get
            If IsNothing(_code) Then
                _code = New CodeDepenseEntity
            End If

            Return _code
        End Get
        Set(value As CodeDepenseEntity)
            _code = value
        End Set
    End Property

End Class
