#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 31/03/2017 
#End Region



''' <summary>
'''Entity Class for table Contrats
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Contrats
	Inherits _Contrats
    Implements IContrats

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


Public Overrides Property employe_id() as integer
    Get
	    Return MyBase.employe_id
    End Get
    Set (byval value as integer)
        MyBase.employe_id= value
    End Set
End property 


Public Overrides Property departement_id() as integer
    Get
	    Return MyBase.departement_id
    End Get
    Set (byval value as integer)
        MyBase.departement_id= value
    End Set
End property 


Public Overrides Property salaire_id() as integer
    Get
	    Return MyBase.salaire_id
    End Get
    Set (byval value as integer)
        MyBase.salaire_id= value
    End Set
End property 


Public Overrides Property poste_id() as integer
    Get
	    Return MyBase.poste_id
    End Get
    Set (byval value as integer)
        MyBase.poste_id= value
    End Set
End property 


Public Overrides Property duree() as integer
    Get
	    Return MyBase.duree
    End Get
    Set (byval value as integer)
        MyBase.duree= value
    End Set
End property 


Public Overrides Property date_debut() as DateTime
    Get
	    Return MyBase.date_debut
    End Get
    Set (byval value as DateTime)
        MyBase.date_debut= value
    End Set
End property 


Public Overrides Property date_fin() as DateTime
    Get
	    Return MyBase.date_fin
    End Get
    Set (byval value as DateTime)
        MyBase.date_fin= value
    End Set
End property 


Public Overrides Property nb_heure_travail() as integer
    Get
	    Return MyBase.nb_heure_travail
    End Get
    Set (byval value as integer)
        MyBase.nb_heure_travail= value
    End Set
End property 


Public Overrides Property classification() as string
    Get
	    Return MyBase.classification
    End Get
    Set (byval value as string)
        MyBase.classification= value
    End Set
End property 


Public Overrides Property superviseur() as integer
    Get
	    Return MyBase.superviseur
    End Get
    Set (byval value as integer)
        MyBase.superviseur= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IContrats.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IContrats.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IContrats.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Contrats
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IContrats
        Inherits _IContrats

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface