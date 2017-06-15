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
'''DAO Class for table Type_formations
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Type_formations
	Inherits LUNA.LunaBaseClassEntity
    Implements _IType_formations
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IType_formations.FillFromDataRecord
     id = myRecord("id")
    		if not myRecord("nom") is DBNull.Value then nom = myRecord("nom")
    		if not myRecord("montant") is DBNull.Value then montant = myRecord("montant")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Type_formations)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(Type_formationsDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Type_formations))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _IType_formations.id
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

Protected _nom as string  = "" 
Public Overridable Property nom() as string  Implements _IType_formations.nom
    Get
	    Return _nom
    End Get
    Set (byval value as string)
	    If _nom <> value Then
	        IsChanged = True
	        _nom= value
	    End If
    End Set
End property 

Protected _montant as Single  = 0 
Public Overridable Property montant() as Single  Implements _IType_formations.montant
    Get
	    Return _montant
    End Get
    Set (byval value as Single)
	    If _montant <> value Then
	        IsChanged = True
	        _montant= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Type_formations from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Type_formations = Manager.Read(Id)
                    _id = int.id
                    _nom = int.nom
                    _montant = int.montant
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Type_formations on DB.
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
	  if _nom.Length > 255 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Type_formations
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IType_formations

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property nom() as string

    
    Property montant() as Single

    
#End Region

End Interface