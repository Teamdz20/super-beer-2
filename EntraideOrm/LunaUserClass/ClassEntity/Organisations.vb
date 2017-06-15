#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 11/04/2017 
#End Region



''' <summary>
'''Entity Class for table Organisations
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Organisations
    Inherits _Organisations
    Implements IOrganisations

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


    Public Overrides Property entete() As Byte
        Get
            Return MyBase.entete
        End Get
        Set(ByVal value As Byte)
            MyBase.entete = value
        End Set
    End Property


    Public Overrides Property mission() As Byte
        Get
            Return MyBase.mission
        End Get
        Set(ByVal value As Byte)
            MyBase.mission = value
        End Set
    End Property


    Public Overrides Property vision() As Byte
        Get
            Return MyBase.vision
        End Get
        Set(ByVal value As Byte)
            MyBase.vision = value
        End Set
    End Property


    Public Overrides Property valeur() As Byte
        Get
            Return MyBase.valeur
        End Get
        Set(ByVal value As Byte)
            MyBase.valeur = value
        End Set
    End Property


    Public Overrides Property organigramme() As Byte
        Get
            Return MyBase.organigramme
        End Get
        Set(ByVal value As Byte)
            MyBase.organigramme = value
        End Set
    End Property


    Public Overrides Property histoire() As Byte
        Get
            Return MyBase.histoire
        End Get
        Set(ByVal value As Byte)
            MyBase.histoire = value
        End Set
    End Property


    Public Overrides Property branche() As Byte
        Get
            Return MyBase.branche
        End Get
        Set(ByVal value As Byte)
            MyBase.branche = value
        End Set
    End Property


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IOrganisations.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IOrganisations.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IOrganisations.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Organisations
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IOrganisations
    Inherits _IOrganisations

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface