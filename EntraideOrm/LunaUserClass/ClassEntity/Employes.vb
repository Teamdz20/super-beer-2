#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 24/04/2017 
#End Region



''' <summary>
'''Entity Class for table Employes
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Employes
    Inherits _Employes
    Implements IEmployes

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord As IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


    Public Overrides Property id() As Integer
        Get
            Return MyBase.id
        End Get
        Set(ByVal value As Integer)
            MyBase.id = value
        End Set
    End Property


    Public Overrides Property code() As String
        Get
            Return MyBase.code
        End Get
        Set(ByVal value As String)
            MyBase.code = value
        End Set
    End Property


    Public Overrides Property nom() As String
        Get
            Return MyBase.nom
        End Get
        Set(ByVal value As String)
            MyBase.nom = value
        End Set
    End Property


    Public Overrides Property prenom() As String
        Get
            Return MyBase.prenom
        End Get
        Set(ByVal value As String)
            MyBase.prenom = value
        End Set
    End Property


    Public Overrides Property sexe() As String
        Get
            Return MyBase.sexe
        End Get
        Set(ByVal value As String)
            MyBase.sexe = value
        End Set
    End Property


    Public Overrides Property situation_matrimonial() As String
        Get
            Return MyBase.situation_matrimonial
        End Get
        Set(ByVal value As String)
            MyBase.situation_matrimonial = value
        End Set
    End Property


    Public Overrides Property nb_enfant() As Integer
        Get
            Return MyBase.nb_enfant
        End Get
        Set(ByVal value As Integer)
            MyBase.nb_enfant = value
        End Set
    End Property


    Public Overrides Property date_naissance() As DateTime
        Get
            Return MyBase.date_naissance
        End Get
        Set(ByVal value As DateTime)
            MyBase.date_naissance = value
        End Set
    End Property


    Public Overrides Property lieu_naissance() As String
        Get
            Return MyBase.lieu_naissance
        End Get
        Set(ByVal value As String)
            MyBase.lieu_naissance = value
        End Set
    End Property


    Public Overrides Property nationnalite() As String
        Get
            Return MyBase.nationnalite
        End Get
        Set(ByVal value As String)
            MyBase.nationnalite = value
        End Set
    End Property


    Public Overrides Property bp() As String
        Get
            Return MyBase.bp
        End Get
        Set(ByVal value As String)
            MyBase.bp = value
        End Set
    End Property


    Public Overrides Property tel1() As String
        Get
            Return MyBase.tel1
        End Get
        Set(ByVal value As String)
            MyBase.tel1 = value
        End Set
    End Property


    Public Overrides Property tel2() As String
        Get
            Return MyBase.tel2
        End Get
        Set(ByVal value As String)
            MyBase.tel2 = value
        End Set
    End Property


    Public Overrides Property email() As String
        Get
            Return MyBase.email
        End Get
        Set(ByVal value As String)
            MyBase.email = value
        End Set
    End Property


    Public Overrides Property religion() As String
        Get
            Return MyBase.religion
        End Get
        Set(ByVal value As String)
            MyBase.religion = value
        End Set
    End Property


    Public Overrides Property precision_autre() As String
        Get
            Return MyBase.precision_autre
        End Get
        Set(ByVal value As String)
            MyBase.precision_autre = value
        End Set
    End Property


    Public Overrides Property delis() As Boolean
        Get
            Return MyBase.delis
        End Get
        Set(ByVal value As Boolean)
            MyBase.delis = value
        End Set
    End Property


    Public Overrides Property detail_delis() As String
        Get
            Return MyBase.detail_delis
        End Get
        Set(ByVal value As String)
            MyBase.detail_delis = value
        End Set
    End Property


    Public Overrides Property recu_formation() As Boolean
        Get
            Return MyBase.recu_formation
        End Get
        Set(ByVal value As Boolean)
            MyBase.recu_formation = value
        End Set
    End Property


    Public Overrides Property type_formation_recu() As String
        Get
            Return MyBase.type_formation_recu
        End Get
        Set(ByVal value As String)
            MyBase.type_formation_recu = value
        End Set
    End Property


    Public Overrides Property niveau_etude() As String
        Get
            Return MyBase.niveau_etude
        End Get
        Set(ByVal value As String)
            MyBase.niveau_etude = value
        End Set
    End Property


    Public Overrides Property diplome() As String
        Get
            Return MyBase.diplome
        End Get
        Set(ByVal value As String)
            MyBase.diplome = value
        End Set
    End Property


    Public Overrides Property ecole() As String
        Get
            Return MyBase.ecole
        End Get
        Set(ByVal value As String)
            MyBase.ecole = value
        End Set
    End Property


    Public Overrides Property nom_contact_urgent() As String
        Get
            Return MyBase.nom_contact_urgent
        End Get
        Set(ByVal value As String)
            MyBase.nom_contact_urgent = value
        End Set
    End Property


    Public Overrides Property adresse_contact_urgent() As String
        Get
            Return MyBase.adresse_contact_urgent
        End Get
        Set(ByVal value As String)
            MyBase.adresse_contact_urgent = value
        End Set
    End Property


    Public Overrides Property phone_contact_urgent() As String
        Get
            Return MyBase.phone_contact_urgent
        End Get
        Set(ByVal value As String)
            MyBase.phone_contact_urgent = value
        End Set
    End Property


    Public Overrides Property email_contact_urgent() As String
        Get
            Return MyBase.email_contact_urgent
        End Get
        Set(ByVal value As String)
            MyBase.email_contact_urgent = value
        End Set
    End Property


    Public Overrides Property competance_fr() As String
        Get
            Return MyBase.competance_fr
        End Get
        Set(ByVal value As String)
            MyBase.competance_fr = value
        End Set
    End Property


    Public Overrides Property competance_en() As String
        Get
            Return MyBase.competance_en
        End Get
        Set(ByVal value As String)
            MyBase.competance_en = value
        End Set
    End Property


    Public Overrides Property competance_information() As String
        Get
            Return MyBase.competance_information
        End Get
        Set(ByVal value As String)
            MyBase.competance_information = value
        End Set
    End Property


    Public Overrides Property autres_competances() As String
        Get
            Return MyBase.autres_competances
        End Get
        Set(ByVal value As String)
            MyBase.autres_competances = value
        End Set
    End Property


    Public Overrides Property note_exp_professionnelle() As String
        Get
            Return MyBase.note_exp_professionnelle
        End Get
        Set(ByVal value As String)
            MyBase.note_exp_professionnelle = value
        End Set
    End Property


    Public Overrides Property departement_id() As Integer
        Get
            Return MyBase.departement_id
        End Get
        Set(ByVal value As Integer)
            MyBase.departement_id = value
        End Set
    End Property


    Public Overrides Property poste_id() As Integer
        Get
            Return MyBase.poste_id
        End Get
        Set(ByVal value As Integer)
            MyBase.poste_id = value
        End Set
    End Property


    Public Overrides Property debut_contract() As DateTime
        Get
            Return MyBase.debut_contract
        End Get
        Set(ByVal value As DateTime)
            MyBase.debut_contract = value
        End Set
    End Property


    Public Overrides Property fin_contract() As DateTime
        Get
            Return MyBase.fin_contract
        End Get
        Set(ByVal value As DateTime)
            MyBase.fin_contract = value
        End Set
    End Property


    Public Overrides Property date_enregistrement() As DateTime
        Get
            Return MyBase.date_enregistrement
        End Get
        Set(ByVal value As DateTime)
            MyBase.date_enregistrement = value
        End Set
    End Property


    Public Overrides Property adresse() As String
        Get
            Return MyBase.adresse
        End Get
        Set(ByVal value As String)
            MyBase.adresse = value
        End Set
    End Property


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IEmployes.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IEmployes.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IEmployes.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Employes
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IEmployes
    Inherits _IEmployes

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface