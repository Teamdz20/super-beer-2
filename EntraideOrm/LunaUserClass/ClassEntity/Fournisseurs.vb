#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 06/06/2017 
#End Region



''' <summary>
'''Entity Class for table Fournisseurs
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Fournisseurs
    Inherits _Fournisseurs
    Implements IFournisseurs

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


    Public Overrides Property created() As DateTime
        Get
            Return MyBase.created
        End Get
        Set(ByVal value As DateTime)
            MyBase.created = value
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


    Public Overrides Property nom_representant() As String
        Get
            Return MyBase.nom_representant
        End Get
        Set(ByVal value As String)
            MyBase.nom_representant = value
        End Set
    End Property


    Public Overrides Property poste() As String
        Get
            Return MyBase.poste
        End Get
        Set(ByVal value As String)
            MyBase.poste = value
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


    Public Overrides Property adresse() As String
        Get
            Return MyBase.adresse
        End Get
        Set(ByVal value As String)
            MyBase.adresse = value
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


    Public Overrides Property site() As String
        Get
            Return MyBase.site
        End Get
        Set(ByVal value As String)
            MyBase.site = value
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


    Public Overrides Property domaine_business() As String
        Get
            Return MyBase.domaine_business
        End Get
        Set(ByVal value As String)
            MyBase.domaine_business = value
        End Set
    End Property


    Public Overrides Property produit() As String
        Get
            Return MyBase.produit
        End Get
        Set(ByVal value As String)
            MyBase.produit = value
        End Set
    End Property


    Public Overrides Property classification_prix() As String
        Get
            Return MyBase.classification_prix
        End Get
        Set(ByVal value As String)
            MyBase.classification_prix = value
        End Set
    End Property


    Public Overrides Property note() As String
        Get
            Return MyBase.note
        End Get
        Set(ByVal value As String)
            MyBase.note = value
        End Set
    End Property


    Public Overrides Property categorie_fournisseur_id() As Integer
        Get
            Return MyBase.categorie_fournisseur_id
        End Get
        Set(ByVal value As Integer)
            MyBase.categorie_fournisseur_id = value
        End Set
    End Property


    Public Overrides Property user_id() As Integer
        Get
            Return MyBase.user_id
        End Get
        Set(ByVal value As Integer)
            MyBase.user_id = value
        End Set
    End Property


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IFournisseurs.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IFournisseurs.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IFournisseurs.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Fournisseurs
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IFournisseurs
    Inherits _IFournisseurs

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface