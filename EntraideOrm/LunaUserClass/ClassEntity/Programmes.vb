#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 02/05/2017 
#End Region



''' <summary>
'''Entity Class for table Programmes
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Programmes
    Inherits _Programmes
    Implements IProgrammes

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


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IProgrammes.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IProgrammes.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IProgrammes.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Programmes
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IProgrammes
    Inherits _IProgrammes

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface