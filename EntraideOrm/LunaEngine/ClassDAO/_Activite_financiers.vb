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
'''DAO Class for table Activite_financiers
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Activite_financiers
	Inherits LUNA.LunaBaseClassEntity
    Implements _IActivite_financiers
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IActivite_financiers.FillFromDataRecord
     id = myRecord("id")
    		if not myRecord("nom") is DBNull.Value then nom = myRecord("nom")
    		if not myRecord("code") is DBNull.Value then code = myRecord("code")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Activite_financiers)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(Activite_financiersDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Activite_financiers))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _IActivite_financiers.id
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
Public Overridable Property nom() as string  Implements _IActivite_financiers.nom
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

Protected _code as string  = "" 
Public Overridable Property code() as string  Implements _IActivite_financiers.code
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


#End Region

#Region "Method"
''' <summary>
'''This method read an Activite_financiers from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Activite_financiers = Manager.Read(Id)
                    _id = int.id
                    _nom = int.nom
                    _code = int.code
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Activite_financiers on DB.
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
  if _code.Length > 255 then Ris = False

	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Activite_financiers
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IActivite_financiers

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property nom() as string

    
    Property code() as string

    
#End Region

End Interface