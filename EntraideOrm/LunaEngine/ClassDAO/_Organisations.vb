#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 11/04/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Organisations
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Organisations
    Inherits LUNA.LunaBaseClassEntity
    Implements _IOrganisations
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IOrganisations.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("entete") Is DBNull.Value Then entete = myRecord("entete")
        If Not myRecord("mission") Is DBNull.Value Then mission = myRecord("mission")
        If Not myRecord("vision") Is DBNull.Value Then vision = myRecord("vision")
        If Not myRecord("valeur") Is DBNull.Value Then valeur = myRecord("valeur")
        If Not myRecord("organigramme") Is DBNull.Value Then organigramme = myRecord("organigramme")
        If Not myRecord("histoire") Is DBNull.Value Then histoire = myRecord("histoire")
        If Not myRecord("branche") Is DBNull.Value Then branche = myRecord("branche")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Organisations)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(OrganisationsDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Organisations))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IOrganisations.id
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

    Protected _entete As Byte = Nothing
    Public Overridable Property entete() As Byte Implements _IOrganisations.entete
        Get
            Return _entete
        End Get
        Set(ByVal value As Byte)
            If _entete <> value Then
                IsChanged = True
                _entete = value
            End If
        End Set
    End Property

    Protected _mission As Byte = Nothing
    Public Overridable Property mission() As Byte Implements _IOrganisations.mission
        Get
            Return _mission
        End Get
        Set(ByVal value As Byte)
            If _mission <> value Then
                IsChanged = True
                _mission = value
            End If
        End Set
    End Property

    Protected _vision As Byte = Nothing
    Public Overridable Property vision() As Byte Implements _IOrganisations.vision
        Get
            Return _vision
        End Get
        Set(ByVal value As Byte)
            If _vision <> value Then
                IsChanged = True
                _vision = value
            End If
        End Set
    End Property

    Protected _valeur As Byte = Nothing
    Public Overridable Property valeur() As Byte Implements _IOrganisations.valeur
        Get
            Return _valeur
        End Get
        Set(ByVal value As Byte)
            If _valeur <> value Then
                IsChanged = True
                _valeur = value
            End If
        End Set
    End Property

    Protected _organigramme As Byte = Nothing
    Public Overridable Property organigramme() As Byte Implements _IOrganisations.organigramme
        Get
            Return _organigramme
        End Get
        Set(ByVal value As Byte)
            If _organigramme <> value Then
                IsChanged = True
                _organigramme = value
            End If
        End Set
    End Property

    Protected _histoire As Byte = Nothing
    Public Overridable Property histoire() As Byte Implements _IOrganisations.histoire
        Get
            Return _histoire
        End Get
        Set(ByVal value As Byte)
            If _histoire <> value Then
                IsChanged = True
                _histoire = value
            End If
        End Set
    End Property

    Protected _branche As Byte = Nothing
    Public Overridable Property branche() As Byte Implements _IOrganisations.branche
        Get
            Return _branche
        End Get
        Set(ByVal value As Byte)
            If _branche <> value Then
                IsChanged = True
                _branche = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Organisations from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Organisations = Manager.Read(Id)
                _id = int.id
                _entete = int.entete
                _mission = int.mission
                _vision = int.vision
                _valeur = int.valeur
                _organigramme = int.organigramme
                _histoire = int.histoire
                _branche = int.branche
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Organisations on DB.
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

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Organisations
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IOrganisations

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property entete() As Byte


    Property mission() As Byte


    Property vision() As Byte


    Property valeur() As Byte


    Property organigramme() As Byte


    Property histoire() As Byte


    Property branche() As Byte


#End Region

End Interface