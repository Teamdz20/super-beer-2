#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 31/03/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Contrats
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Contrats
	Inherits LUNA.LunaBaseClassEntity
    Implements _IContrats
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IContrats.FillFromDataRecord
     id = myRecord("id")
    employe_id = myRecord("employe_id")
    departement_id = myRecord("departement_id")
    		if not myRecord("salaire_id") is DBNull.Value then salaire_id = myRecord("salaire_id")
    poste_id = myRecord("poste_id")
    duree = myRecord("duree")
    date_debut = myRecord("date_debut")
    date_fin = myRecord("date_fin")
    		if not myRecord("nb_heure_travail") is DBNull.Value then nb_heure_travail = myRecord("nb_heure_travail")
    		if not myRecord("classification") is DBNull.Value then classification = myRecord("classification")
    		if not myRecord("superviseur") is DBNull.Value then superviseur = myRecord("superviseur")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Contrats)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(ContratsDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Contrats))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _IContrats.id
    Get
	    Return _id
    End Get
    Set (byval value as integer)
	    If _id <> value Then
	        IsChanged = True
	        _id= value
	    End If
    End Set
End property 

Protected _employe_id as integer  = 0 
Public Overridable Property employe_id() as integer  Implements _IContrats.employe_id
    Get
	    Return _employe_id
    End Get
    Set (byval value as integer)
	    If _employe_id <> value Then
	        IsChanged = True
	        _employe_id= value
	    End If
    End Set
End property 

Protected _departement_id as integer  = 0 
Public Overridable Property departement_id() as integer  Implements _IContrats.departement_id
    Get
	    Return _departement_id
    End Get
    Set (byval value as integer)
	    If _departement_id <> value Then
	        IsChanged = True
	        _departement_id= value
	    End If
    End Set
End property 

Protected _salaire_id as integer  = 0 
Public Overridable Property salaire_id() as integer  Implements _IContrats.salaire_id
    Get
	    Return _salaire_id
    End Get
    Set (byval value as integer)
	    If _salaire_id <> value Then
	        IsChanged = True
	        _salaire_id= value
	    End If
    End Set
End property 

Protected _poste_id as integer  = 0 
Public Overridable Property poste_id() as integer  Implements _IContrats.poste_id
    Get
	    Return _poste_id
    End Get
    Set (byval value as integer)
	    If _poste_id <> value Then
	        IsChanged = True
	        _poste_id= value
	    End If
    End Set
End property 

Protected _duree as integer  = 0 
Public Overridable Property duree() as integer  Implements _IContrats.duree
    Get
	    Return _duree
    End Get
    Set (byval value as integer)
	    If _duree <> value Then
	        IsChanged = True
	        _duree= value
	    End If
    End Set
End property 

Protected _date_debut as DateTime  = Nothing 
Public Overridable Property date_debut() as DateTime  Implements _IContrats.date_debut
    Get
	    Return _date_debut
    End Get
    Set (byval value as DateTime)
	    If _date_debut <> value Then
	        IsChanged = True
	        _date_debut= value
	    End If
    End Set
End property 

Protected _date_fin as DateTime  = Nothing 
Public Overridable Property date_fin() as DateTime  Implements _IContrats.date_fin
    Get
	    Return _date_fin
    End Get
    Set (byval value as DateTime)
	    If _date_fin <> value Then
	        IsChanged = True
	        _date_fin= value
	    End If
    End Set
End property 

Protected _nb_heure_travail as integer  = 0 
Public Overridable Property nb_heure_travail() as integer  Implements _IContrats.nb_heure_travail
    Get
	    Return _nb_heure_travail
    End Get
    Set (byval value as integer)
	    If _nb_heure_travail <> value Then
	        IsChanged = True
	        _nb_heure_travail= value
	    End If
    End Set
End property 

Protected _classification as string  = "" 
Public Overridable Property classification() as string  Implements _IContrats.classification
    Get
	    Return _classification
    End Get
    Set (byval value as string)
	    If _classification <> value Then
	        IsChanged = True
	        _classification= value
	    End If
    End Set
End property 

Protected _superviseur as integer  = 0 
Public Overridable Property superviseur() as integer  Implements _IContrats.superviseur
    Get
	    Return _superviseur
    End Get
    Set (byval value as integer)
	    If _superviseur <> value Then
	        IsChanged = True
	        _superviseur= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Contrats from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Contrats = Manager.Read(Id)
                    _id = int.id
                    _employe_id = int.employe_id
                    _departement_id = int.departement_id
                    _salaire_id = int.salaire_id
                    _poste_id = int.poste_id
                    _duree = int.duree
                    _date_debut = int.date_debut
                    _date_fin = int.date_fin
                    _nb_heure_travail = int.nb_heure_travail
                    _classification = int.classification
                    _superviseur = int.superviseur
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Contrats on DB.
''' </summary>
''' <returns>
'''Return Id insert in DB if all ok, 0 if error
''' </returns>
Public Overridable Function Save() As Integer
    'Return the id Inserted
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Ris = Manager.Save(Me)
	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ris
End Function

Protected Function InternalIsValid() As Boolean
	Dim Ris As Boolean = True
	  if _classification.Length > 10 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Contrats
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IContrats

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property employe_id() as integer

    
    Property departement_id() as integer

    
    Property salaire_id() as integer

    
    Property poste_id() as integer

    
    Property duree() as integer

    
    Property date_debut() as DateTime

    
    Property date_fin() as DateTime

    
    Property nb_heure_travail() as integer

    
    Property classification() as string

    
    Property superviseur() as integer

    
#End Region

End Interface