#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 05/04/2017 
#End Region



''' <summary>
'''Entity Class for table Achats
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Achats
    Inherits _Achats
    Implements IAchats

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


    Public Overrides Property fournisseur_id() As Integer
        Get
            Return MyBase.fournisseur_id
        End Get
        Set(ByVal value As Integer)
            MyBase.fournisseur_id = value
        End Set
    End Property


    Public Overrides Property code_depense_id() As Integer
        Get
            Return MyBase.code_depense_id
        End Get
        Set(ByVal value As Integer)
            MyBase.code_depense_id = value
        End Set
    End Property


    Public Overrides Property num_facture() As String
        Get
            Return MyBase.num_facture
        End Get
        Set(ByVal value As String)
            MyBase.num_facture = value
        End Set
    End Property


    Public Overrides Property prix_achat() As Single
        Get
            Return MyBase.prix_achat
        End Get
        Set(ByVal value As Single)
            MyBase.prix_achat = value
        End Set
    End Property


    Public Overrides Property cout() As Single
        Get
            Return MyBase.cout
        End Get
        Set(ByVal value As Single)
            MyBase.cout = value
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

    Public Overrides Function IsValid() As Boolean Implements IAchats.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IAchats.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IAchats.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Achats
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IAchats
    Inherits _IAchats

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface