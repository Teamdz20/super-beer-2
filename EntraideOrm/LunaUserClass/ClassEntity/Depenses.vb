#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 26/04/2017 
#End Region



''' <summary>
'''Entity Class for table Depenses
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Depenses
    Inherits _Depenses
    Implements IDepenses

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


    Public Overrides Property ref_id() As Integer
        Get
            Return MyBase.ref_id
        End Get
        Set(ByVal value As Integer)
            MyBase.ref_id = value
        End Set
    End Property


    Public Overrides Property type_depense_id() As Integer
        Get
            Return MyBase.type_depense_id
        End Get
        Set(ByVal value As Integer)
            MyBase.type_depense_id = value
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


    Public Overrides Property code_depense_id() As Integer
        Get
            Return MyBase.code_depense_id
        End Get
        Set(ByVal value As Integer)
            MyBase.code_depense_id = value
        End Set
    End Property


    Public Overrides Property manager_id() As Integer
        Get
            Return MyBase.manager_id
        End Get
        Set(ByVal value As Integer)
            MyBase.manager_id = value
        End Set
    End Property


    Public Overrides Property montant() As Single
        Get
            Return MyBase.montant
        End Get
        Set(ByVal value As Single)
            MyBase.montant = value
        End Set
    End Property


    Public Overrides Property devise_id() As Integer
        Get
            Return MyBase.devise_id
        End Get
        Set(ByVal value As Integer)
            MyBase.devise_id = value
        End Set
    End Property


    Public Overrides Property beneficiere_id() As Integer
        Get
            Return MyBase.beneficiere_id
        End Get
        Set(ByVal value As Integer)
            MyBase.beneficiere_id = value
        End Set
    End Property


    Public Overrides Property motif_depense() As String
        Get
            Return MyBase.motif_depense
        End Get
        Set(ByVal value As String)
            MyBase.motif_depense = value
        End Set
    End Property


    Public Overrides Property realiser_par() As Integer
        Get
            Return MyBase.realiser_par
        End Get
        Set(ByVal value As Integer)
            MyBase.realiser_par = value
        End Set
    End Property


    Public Overrides Property code_demande() As String
        Get
            Return MyBase.code_demande
        End Get
        Set(ByVal value As String)
            MyBase.code_demande = value
        End Set
    End Property


    Public Overrides Property memo() As String
        Get
            Return MyBase.memo
        End Get
        Set(ByVal value As String)
            MyBase.memo = value
        End Set
    End Property


    Public Overrides Property activite() As String
        Get
            Return MyBase.activite
        End Get
        Set(ByVal value As String)
            MyBase.activite = value
        End Set
    End Property


    Public Overrides Property programme_id() As Integer
        Get
            Return MyBase.programme_id
        End Get
        Set(ByVal value As Integer)
            MyBase.programme_id = value
        End Set
    End Property


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IDepenses.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IDepenses.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IDepenses.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Depenses
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IDepenses
    Inherits _IDepenses

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface