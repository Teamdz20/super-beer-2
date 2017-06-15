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
'''DAO Class for table Revenus
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Revenus
	Inherits LUNA.LunaBaseClassEntity
    Implements _IRevenus
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IRevenus.FillFromDataRecord
     id = myRecord("id")
    		if not myRecord("montant") is DBNull.Value then montant = myRecord("montant")
    		if not myRecord("reglement") is DBNull.Value then reglement = myRecord("reglement")
    		if not myRecord("date_revenu") is DBNull.Value then date_revenu = myRecord("date_revenu")
    		if not myRecord("memo") is DBNull.Value then memo = myRecord("memo")
    		if not myRecord("id_type_agr") is DBNull.Value then id_type_agr = myRecord("id_type_agr")
    		if not myRecord("id_classification_revenu") is DBNull.Value then id_classification_revenu = myRecord("id_classification_revenu")
    		if not myRecord("id_employe") is DBNull.Value then id_employe = myRecord("id_employe")
    		if not myRecord("id_devise") is DBNull.Value then id_devise = myRecord("id_devise")
    		if not myRecord("id_recu") is DBNull.Value then id_recu = myRecord("id_recu")
    		if not myRecord("code_revenu") is DBNull.Value then code_revenu = myRecord("code_revenu")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Revenus)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(RevenusDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Revenus))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _IRevenus.id
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

Protected _montant as integer  = 0 
Public Overridable Property montant() as integer  Implements _IRevenus.montant
    Get
	    Return _montant
    End Get
    Set (byval value as integer)
	    If _montant <> value Then
	        IsChanged = True
	        _montant= value
	    End If
    End Set
End property 

Protected _reglement as string  = "" 
Public Overridable Property reglement() as string  Implements _IRevenus.reglement
    Get
	    Return _reglement
    End Get
    Set (byval value as string)
	    If _reglement <> value Then
	        IsChanged = True
	        _reglement= value
	    End If
    End Set
End property 

Protected _date_revenu as DateTime  = Nothing 
Public Overridable Property date_revenu() as DateTime  Implements _IRevenus.date_revenu
    Get
	    Return _date_revenu
    End Get
    Set (byval value as DateTime)
	    If _date_revenu <> value Then
	        IsChanged = True
	        _date_revenu= value
	    End If
    End Set
End property 

Protected _memo as string  = "" 
Public Overridable Property memo() as string  Implements _IRevenus.memo
    Get
	    Return _memo
    End Get
    Set (byval value as string)
	    If _memo <> value Then
	        IsChanged = True
	        _memo= value
	    End If
    End Set
End property 

Protected _id_type_agr as integer  = 0 
Public Overridable Property id_type_agr() as integer  Implements _IRevenus.id_type_agr
    Get
	    Return _id_type_agr
    End Get
    Set (byval value as integer)
	    If _id_type_agr <> value Then
	        IsChanged = True
	        _id_type_agr= value
	    End If
    End Set
End property 

Protected _id_classification_revenu as integer  = 0 
Public Overridable Property id_classification_revenu() as integer  Implements _IRevenus.id_classification_revenu
    Get
	    Return _id_classification_revenu
    End Get
    Set (byval value as integer)
	    If _id_classification_revenu <> value Then
	        IsChanged = True
	        _id_classification_revenu= value
	    End If
    End Set
End property 

Protected _id_employe as integer  = 0 
Public Overridable Property id_employe() as integer  Implements _IRevenus.id_employe
    Get
	    Return _id_employe
    End Get
    Set (byval value as integer)
	    If _id_employe <> value Then
	        IsChanged = True
	        _id_employe= value
	    End If
    End Set
End property 

Protected _id_devise as integer  = 0 
Public Overridable Property id_devise() as integer  Implements _IRevenus.id_devise
    Get
	    Return _id_devise
    End Get
    Set (byval value as integer)
	    If _id_devise <> value Then
	        IsChanged = True
	        _id_devise= value
	    End If
    End Set
End property 

Protected _id_recu as integer  = 0 
Public Overridable Property id_recu() as integer  Implements _IRevenus.id_recu
    Get
	    Return _id_recu
    End Get
    Set (byval value as integer)
	    If _id_recu <> value Then
	        IsChanged = True
	        _id_recu= value
	    End If
    End Set
End property 

Protected _code_revenu as string  = "" 
Public Overridable Property code_revenu() as string  Implements _IRevenus.code_revenu
    Get
	    Return _code_revenu
    End Get
    Set (byval value as string)
	    If _code_revenu <> value Then
	        IsChanged = True
	        _code_revenu= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Revenus from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Revenus = Manager.Read(Id)
                    _id = int.id
                    _montant = int.montant
                    _reglement = int.reglement
                    _date_revenu = int.date_revenu
                    _memo = int.memo
                    _id_type_agr = int.id_type_agr
                    _id_classification_revenu = int.id_classification_revenu
                    _id_employe = int.id_employe
                    _id_devise = int.id_devise
                    _id_recu = int.id_recu
                    _code_revenu = int.code_revenu
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Revenus on DB.
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
	  if _reglement.Length > 30 then Ris = False
  if _memo.Length > 21845 then Ris = False
  if _code_revenu.Length > 255 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Revenus
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IRevenus

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property montant() as integer

    
    Property reglement() as string

    
    Property date_revenu() as DateTime

    
    Property memo() as string

    
    Property id_type_agr() as integer

    
    Property id_classification_revenu() as integer

    
    Property id_employe() as integer

    
    Property id_devise() as integer

    
    Property id_recu() as integer

    
    Property code_revenu() as string

    
#End Region

End Interface