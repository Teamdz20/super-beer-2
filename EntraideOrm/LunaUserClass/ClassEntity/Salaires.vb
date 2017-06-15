#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 31/03/2017 
#End Region



''' <summary>
'''Entity Class for table Salaires
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Salaires
	Inherits _Salaires
    Implements ISalaires

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


Public Overrides Property term_paiement() as string
    Get
	    Return MyBase.term_paiement
    End Get
    Set (byval value as string)
        MyBase.term_paiement= value
    End Set
End property 


Public Overrides Property taux() as Single
    Get
	    Return MyBase.taux
    End Get
    Set (byval value as Single)
        MyBase.taux= value
    End Set
End property 


Public Overrides Property nb_jour_travail() as integer
    Get
	    Return MyBase.nb_jour_travail
    End Get
    Set (byval value as integer)
        MyBase.nb_jour_travail= value
    End Set
End property 


Public Overrides Property salaire() as Single
    Get
	    Return MyBase.salaire
    End Get
    Set (byval value as Single)
        MyBase.salaire= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ISalaires.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ISalaires.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ISalaires.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Salaires
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ISalaires
        Inherits _ISalaires

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface