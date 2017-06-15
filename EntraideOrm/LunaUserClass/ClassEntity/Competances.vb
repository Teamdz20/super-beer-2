#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 31/03/2017 
#End Region



''' <summary>
'''Entity Class for table Competances
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Competances
	Inherits _Competances
    Implements ICompetances

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property id() as integer
    Get
	    Return MyBase.id
    End Get
    Set (byval value as integer)
        MyBase.id= value
    End Set
End property 


Public Overrides Property etudiant_id() as integer
    Get
	    Return MyBase.etudiant_id
    End Get
    Set (byval value as integer)
        MyBase.etudiant_id= value
    End Set
End property 


Public Overrides Property niveau_id() as integer
    Get
	    Return MyBase.niveau_id
    End Get
    Set (byval value as integer)
        MyBase.niveau_id= value
    End Set
End property 


Public Overrides Property type_competance_id() as integer
    Get
	    Return MyBase.type_competance_id
    End Get
    Set (byval value as integer)
        MyBase.type_competance_id= value
    End Set
End property 


Public Overrides Property evaluation_id() as integer
    Get
	    Return MyBase.evaluation_id
    End Get
    Set (byval value as integer)
        MyBase.evaluation_id= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ICompetances.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ICompetances.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ICompetances.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Competances
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ICompetances
        Inherits _ICompetances

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface