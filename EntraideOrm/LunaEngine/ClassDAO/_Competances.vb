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
'''DAO Class for table Competances
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Competances
	Inherits LUNA.LunaBaseClassEntity
    Implements _ICompetances
'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ICompetances.FillFromDataRecord
     id = myRecord("id")
    		if not myRecord("etudiant_id") is DBNull.Value then etudiant_id = myRecord("etudiant_id")
    		if not myRecord("niveau_id") is DBNull.Value then niveau_id = myRecord("niveau_id")
    		if not myRecord("type_competance_id") is DBNull.Value then type_competance_id = myRecord("type_competance_id")
    		if not myRecord("evaluation_id") is DBNull.Value then evaluation_id = myRecord("evaluation_id")
       
End Sub

Private Property Manager As LUNA.ILunaBaseClassDAO(Of Competances)
    Get
        If _Mgr Is Nothing Then
            Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
            If _MgrType Is Nothing Then _MgrType = GetType(CompetancesDAO)
            _Mgr = Activator.CreateInstance(_MgrType)
        End If
        Return _Mgr
    End Get
    Set(value As LUNA.ILunaBaseClassDAO(Of Competances))
        _Mgr = value
    End Set
End Property

#Region "Database Field Map"

Protected _id as integer  = 0 
Public Overridable Property id() as integer  Implements _ICompetances.id
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

Protected _etudiant_id as integer  = 0 
Public Overridable Property etudiant_id() as integer  Implements _ICompetances.etudiant_id
    Get
	    Return _etudiant_id
    End Get
    Set (byval value as integer)
	    If _etudiant_id <> value Then
	        IsChanged = True
	        _etudiant_id= value
	    End If
    End Set
End property 

Protected _niveau_id as integer  = 0 
Public Overridable Property niveau_id() as integer  Implements _ICompetances.niveau_id
    Get
	    Return _niveau_id
    End Get
    Set (byval value as integer)
	    If _niveau_id <> value Then
	        IsChanged = True
	        _niveau_id= value
	    End If
    End Set
End property 

Protected _type_competance_id as integer  = 0 
Public Overridable Property type_competance_id() as integer  Implements _ICompetances.type_competance_id
    Get
	    Return _type_competance_id
    End Get
    Set (byval value as integer)
	    If _type_competance_id <> value Then
	        IsChanged = True
	        _type_competance_id= value
	    End If
    End Set
End property 

Protected _evaluation_id as integer  = 0 
Public Overridable Property evaluation_id() as integer  Implements _ICompetances.evaluation_id
    Get
	    Return _evaluation_id
    End Get
    Set (byval value as integer)
	    If _evaluation_id <> value Then
	        IsChanged = True
	        _evaluation_id= value
	    End If
    End Set
End property 


#End Region

#Region "Method"
''' <summary>
'''This method read an Competances from DB.
''' </summary>
''' <returns>
'''Return 0 if all ok, 1 if error
''' </returns>
Public Overridable Function Read(Id As Integer) As Integer
    'Return 0 if all ok
    Dim Ris As Integer = 0
    Try
	    Using Manager
	        Dim int As Competances = Manager.Read(Id)
                    _id = int.id
                    _etudiant_id = int.etudiant_id
                    _niveau_id = int.niveau_id
                    _type_competance_id = int.type_competance_id
                    _evaluation_id = int.evaluation_id
        	    End Using
        Manager = nothing
    Catch ex As Exception
	    ManageError(ex)
	    Ris = 1
    End Try
    Return Ris
End Function

''' <summary>
'''This method save an Competances on DB.
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
	
	Return Ris
End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Competances
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ICompetances

Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

    
    Property id() as integer

    
    Property etudiant_id() as integer

    
    Property niveau_id() as integer

    
    Property type_competance_id() as integer

    
    Property evaluation_id() as integer

    
#End Region

End Interface