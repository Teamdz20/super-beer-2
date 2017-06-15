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
'''DAO Class for table Salaires
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Salaires
	Inherits LUNA.LunaBaseClassEntity
    Implements _ISalaires
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ISalaires.FillFromDataRecord
     id = myRecord("id")
    term_paiement = myRecord("term_paiement")
    taux = myRecord("taux")
    		if not myRecord("nb_jour_travail") is DBNull.Value then nb_jour_travail = myRecord("nb_jour_travail")
    		if not myRecord("salaire") is DBNull.Value then salaire = myRecord("salaire")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Salaires)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(SalairesDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Salaires))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _ISalaires.id
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

Protected _term_paiement as string  = "" 
Public Overridable Property term_paiement() as string  Implements _ISalaires.term_paiement
    Get
	    Return _term_paiement
    End Get
    Set (byval value as string)
	    If _term_paiement <> value Then
	        IsChanged = True
	        _term_paiement= value
	    End If
    End Set
End property 

Protected _taux as Single  = 0 
Public Overridable Property taux() as Single  Implements _ISalaires.taux
    Get
	    Return _taux
    End Get
    Set (byval value as Single)
	    If _taux <> value Then
	        IsChanged = True
	        _taux= value
	    End If
    End Set
End property 

Protected _nb_jour_travail as integer  = 0 
Public Overridable Property nb_jour_travail() as integer  Implements _ISalaires.nb_jour_travail
    Get
	    Return _nb_jour_travail
    End Get
    Set (byval value as integer)
	    If _nb_jour_travail <> value Then
	        IsChanged = True
	        _nb_jour_travail= value
	    End If
    End Set
End property 

Protected _salaire as Single  = 0 
Public Overridable Property salaire() as Single  Implements _ISalaires.salaire
    Get
	    Return _salaire
    End Get
    Set (byval value as Single)
	    If _salaire <> value Then
	        IsChanged = True
	        _salaire= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Salaires from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Salaires = Manager.Read(Id)
                    _id = int.id
                    _term_paiement = int.term_paiement
                    _taux = int.taux
                    _nb_jour_travail = int.nb_jour_travail
                    _salaire = int.salaire
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Salaires on DB.
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
	  if _term_paiement.Length = 0 then Ris = False
  if _term_paiement.Length > 9 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Salaires
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ISalaires

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property term_paiement() as string

    
    Property taux() as Single

    
    Property nb_jour_travail() as integer

    
    Property salaire() as Single

    
#End Region

End Interface