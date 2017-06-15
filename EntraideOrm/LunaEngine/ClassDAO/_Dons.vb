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
'''DAO Class for table Dons
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Dons
	Inherits LUNA.LunaBaseClassEntity
    Implements _IDons
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IDons.FillFromDataRecord
        id = myRecord("id")
    		if not myRecord("activite_financier_id") is DBNull.Value then activite_financier_id = myRecord("activite_financier_id")
    		if not myRecord("departement_id") is DBNull.Value then departement_id = myRecord("departement_id")
    		if not myRecord("donneur_id") is DBNull.Value then donneur_id = myRecord("donneur_id")
    		if not myRecord("type_don") is DBNull.Value then type_don = myRecord("type_don")
    		if not myRecord("materiel_id") is DBNull.Value then materiel_id = myRecord("materiel_id")
    		if not myRecord("mode_reception") is DBNull.Value then mode_reception = myRecord("mode_reception")
    		if not myRecord("montant_recu") is DBNull.Value then montant_recu = myRecord("montant_recu")
    		if not myRecord("montant_sollicite") is DBNull.Value then montant_sollicite = myRecord("montant_sollicite")
    		if not myRecord("code") is DBNull.Value then code = myRecord("code")
    		if not myRecord("non_sollicite") is DBNull.Value then non_sollicite = myRecord("non_sollicite")
    		if not myRecord("numero_cheque") is DBNull.Value then numero_cheque = myRecord("numero_cheque")
    		if not myRecord("restriction") is DBNull.Value then restriction = myRecord("restriction")
    		if not myRecord("note_restriction") is DBNull.Value then note_restriction = myRecord("note_restriction")
    		if not myRecord("activite_menee") is DBNull.Value then activite_menee = myRecord("activite_menee")
    		if not myRecord("created") is DBNull.Value then created = myRecord("created")
    		if not myRecord("user_id") is DBNull.Value then user_id = myRecord("user_id")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Dons)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(DonsDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Dons))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _IDons.id
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

Protected _activite_financier_id as integer  = 0 
Public Overridable Property activite_financier_id() as integer  Implements _IDons.activite_financier_id
    Get
	    Return _activite_financier_id
    End Get
    Set (byval value as integer)
	    If _activite_financier_id <> value Then
	        IsChanged = True
	        _activite_financier_id= value
	    End If
    End Set
End property 

Protected _departement_id as integer  = 0 
Public Overridable Property departement_id() as integer  Implements _IDons.departement_id
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

Protected _donneur_id as string  = "" 
Public Overridable Property donneur_id() as string  Implements _IDons.donneur_id
    Get
	    Return _donneur_id
    End Get
    Set (byval value as string)
	    If _donneur_id <> value Then
	        IsChanged = True
	        _donneur_id= value
	    End If
    End Set
End property 

Protected _type_don as string  = "" 
Public Overridable Property type_don() as string  Implements _IDons.type_don
    Get
	    Return _type_don
    End Get
    Set (byval value as string)
	    If _type_don <> value Then
	        IsChanged = True
	        _type_don= value
	    End If
    End Set
End property 

Protected _materiel_id as integer  = 0 
Public Overridable Property materiel_id() as integer  Implements _IDons.materiel_id
    Get
	    Return _materiel_id
    End Get
    Set (byval value as integer)
	    If _materiel_id <> value Then
	        IsChanged = True
	        _materiel_id= value
	    End If
    End Set
End property 

Protected _mode_reception as string  = "" 
Public Overridable Property mode_reception() as string  Implements _IDons.mode_reception
    Get
	    Return _mode_reception
    End Get
    Set (byval value as string)
	    If _mode_reception <> value Then
	        IsChanged = True
	        _mode_reception= value
	    End If
    End Set
End property 

Protected _montant_recu as Single  = 0 
Public Overridable Property montant_recu() as Single  Implements _IDons.montant_recu
    Get
	    Return _montant_recu
    End Get
    Set (byval value as Single)
	    If _montant_recu <> value Then
	        IsChanged = True
	        _montant_recu= value
	    End If
    End Set
End property 

Protected _montant_sollicite as Single  = 0 
Public Overridable Property montant_sollicite() as Single  Implements _IDons.montant_sollicite
    Get
	    Return _montant_sollicite
    End Get
    Set (byval value as Single)
	    If _montant_sollicite <> value Then
	        IsChanged = True
	        _montant_sollicite= value
	    End If
    End Set
End property 

Protected _code as string  = "" 
Public Overridable Property code() as string  Implements _IDons.code
    Get
	    Return _code
    End Get
    Set (byval value as string)
	    If _code <> value Then
	        IsChanged = True
	        _code= value
	    End If
    End Set
End property 

Protected _non_sollicite as string  = "" 
Public Overridable Property non_sollicite() as string  Implements _IDons.non_sollicite
    Get
	    Return _non_sollicite
    End Get
    Set (byval value as string)
	    If _non_sollicite <> value Then
	        IsChanged = True
	        _non_sollicite= value
	    End If
    End Set
End property 

Protected _numero_cheque as string  = "" 
Public Overridable Property numero_cheque() as string  Implements _IDons.numero_cheque
    Get
	    Return _numero_cheque
    End Get
    Set (byval value as string)
	    If _numero_cheque <> value Then
	        IsChanged = True
	        _numero_cheque= value
	    End If
    End Set
End property 

Protected _restriction as string  = "" 
Public Overridable Property restriction() as string  Implements _IDons.restriction
    Get
	    Return _restriction
    End Get
    Set (byval value as string)
	    If _restriction <> value Then
	        IsChanged = True
	        _restriction= value
	    End If
    End Set
End property 

Protected _note_restriction as string  = "" 
Public Overridable Property note_restriction() as string  Implements _IDons.note_restriction
    Get
	    Return _note_restriction
    End Get
    Set (byval value as string)
	    If _note_restriction <> value Then
	        IsChanged = True
	        _note_restriction= value
	    End If
    End Set
End property 

Protected _activite_menee as string  = "" 
Public Overridable Property activite_menee() as string  Implements _IDons.activite_menee
    Get
	    Return _activite_menee
    End Get
    Set (byval value as string)
	    If _activite_menee <> value Then
	        IsChanged = True
	        _activite_menee= value
	    End If
    End Set
End property 

Protected _created as DateTime  = Nothing 
Public Overridable Property created() as DateTime  Implements _IDons.created
    Get
	    Return _created
    End Get
    Set (byval value as DateTime)
	    If _created <> value Then
	        IsChanged = True
	        _created= value
	    End If
    End Set
End property 

Protected _user_id as integer  = 0 
Public Overridable Property user_id() as integer  Implements _IDons.user_id
    Get
	    Return _user_id
    End Get
    Set (byval value as integer)
	    If _user_id <> value Then
	        IsChanged = True
	        _user_id= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Dons from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Dons = Manager.Read(Id)
                    _id = int.id
                    _activite_financier_id = int.activite_financier_id
                    _departement_id = int.departement_id
                    _donneur_id = int.donneur_id
                    _type_don = int.type_don
                    _materiel_id = int.materiel_id
                    _mode_reception = int.mode_reception
                    _montant_recu = int.montant_recu
                    _montant_sollicite = int.montant_sollicite
                    _code = int.code
                    _non_sollicite = int.non_sollicite
                    _numero_cheque = int.numero_cheque
                    _restriction = int.restriction
                    _note_restriction = int.note_restriction
                    _activite_menee = int.activite_menee
                    _created = int.created
                    _user_id = int.user_id
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Dons on DB.
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
	  if _donneur_id.Length > 255 then Ris = False
  if _type_don.Length > 8 then Ris = False
  if _mode_reception.Length > 8 then Ris = False
  if _code.Length > 255 then Ris = False
  if _non_sollicite.Length > 255 then Ris = False
  if _numero_cheque.Length > 255 then Ris = False
  if _restriction.Length > 8 then Ris = False
  if _note_restriction.Length > 21845 then Ris = False
  if _activite_menee.Length > 255 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Dons
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IDons

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property activite_financier_id() as integer

    
    Property departement_id() as integer

    
    Property donneur_id() as string

    
    Property type_don() as string

    
    Property materiel_id() as integer

    
    Property mode_reception() as string

    
    Property montant_recu() as Single

    
    Property montant_sollicite() as Single

    
    Property code() as string

    
    Property non_sollicite() as string

    
    Property numero_cheque() as string

    
    Property restriction() as string

    
    Property note_restriction() as string

    
    Property activite_menee() as string

    
    Property created() as DateTime

    
    Property user_id() as integer

    
#End Region

End Interface