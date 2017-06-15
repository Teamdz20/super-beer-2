#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 05/06/2017 
#End Region



''' <summary>
'''Entity Class for table Donneurs
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Donneurs
    Inherits _Donneurs
    Implements IDonneurs

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


    Public Overrides Property date_donneur() As DateTime
        Get
            Return MyBase.date_donneur
        End Get
        Set(ByVal value As DateTime)
            MyBase.date_donneur = value
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


    Public Overrides Property email() As String
        Get
            Return MyBase.email
        End Get
        Set(ByVal value As String)
            MyBase.email = value
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


    Public Overrides Property categorie_donneur_id() As Integer
        Get
            Return MyBase.categorie_donneur_id
        End Get
        Set(ByVal value As Integer)
            MyBase.categorie_donneur_id = value
        End Set
    End Property


    Public Overrides Property site_internet() As String
        Get
            Return MyBase.site_internet
        End Get
        Set(ByVal value As String)
            MyBase.site_internet = value
        End Set
    End Property


    Public Overrides Property restriction() As String
        Get
            Return MyBase.restriction
        End Get
        Set(ByVal value As String)
            MyBase.restriction = value
        End Set
    End Property


    Public Overrides Property periode_sollicitation() As String
        Get
            Return MyBase.periode_sollicitation
        End Get
        Set(ByVal value As String)
            MyBase.periode_sollicitation = value
        End Set
    End Property


    Public Overrides Property note_sollicitation() As String
        Get
            Return MyBase.note_sollicitation
        End Get
        Set(ByVal value As String)
            MyBase.note_sollicitation = value
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


    Public Overrides Property user_id() As Integer
        Get
            Return MyBase.user_id
        End Get
        Set(ByVal value As Integer)
            MyBase.user_id = value
        End Set
    End Property


    Public Overrides Property type_don() As String
        Get
            Return MyBase.type_don
        End Get
        Set(ByVal value As String)
            MyBase.type_don = value
        End Set
    End Property


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IDonneurs.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IDonneurs.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IDonneurs.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Donneurs
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IDonneurs
    Inherits _IDonneurs

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface