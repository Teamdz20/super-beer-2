#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 02/05/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Programmes
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Programmes
    Inherits LUNA.LunaBaseClassEntity
    Implements _IProgrammes
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IProgrammes.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("nom") Is DBNull.Value Then nom = myRecord("nom")
        If Not myRecord("code") Is DBNull.Value Then code = myRecord("code")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Programmes)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(ProgrammesDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Programmes))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IProgrammes.id
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            If _id <> value Then
                IsChanged = True
                _id = value
            End If
        End Set
    End Property

    Protected _nom As String = ""
    Public Overridable Property nom() As String Implements _IProgrammes.nom
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            If _nom <> value Then
                IsChanged = True
                _nom = value
            End If
        End Set
    End Property

    Protected _code As String = ""
    Public Overridable Property code() As String Implements _IProgrammes.code
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            If _code <> value Then
                IsChanged = True
                _code = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Programmes from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Programmes = Manager.Read(Id)
                _id = int.id
                _nom = int.nom
                _code = int.code
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Programmes on DB.
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
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function

    Protected Function InternalIsValid() As Boolean
        Dim Ris As Boolean = True
        If _nom.Length > 255 Then Ris = False
        If _code.Length > 255 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Programmes
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IProgrammes

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property nom() As String


    Property code() As String


#End Region

End Interface