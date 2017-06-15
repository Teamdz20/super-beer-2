#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 05/04/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Achats
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Achats
    Inherits LUNA.LunaBaseClassEntity
    Implements _IAchats
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IAchats.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("fournisseur_id") Is DBNull.Value Then fournisseur_id = myRecord("fournisseur_id")
        If Not myRecord("code_depense_id") Is DBNull.Value Then code_depense_id = myRecord("code_depense_id")
        If Not myRecord("num_facture") Is DBNull.Value Then num_facture = myRecord("num_facture")
        If Not myRecord("prix_achat") Is DBNull.Value Then prix_achat = myRecord("prix_achat")
        If Not myRecord("cout") Is DBNull.Value Then cout = myRecord("cout")
        If Not myRecord("created") Is DBNull.Value Then created = myRecord("created")
        If Not myRecord("user_id") Is DBNull.Value Then user_id = myRecord("user_id")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Achats)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(AchatsDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Achats))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IAchats.id
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

    Protected _fournisseur_id As Integer = 0
    Public Overridable Property fournisseur_id() As Integer Implements _IAchats.fournisseur_id
        Get
            Return _fournisseur_id
        End Get
        Set(ByVal value As Integer)
            If _fournisseur_id <> value Then
                IsChanged = True
                _fournisseur_id = value
            End If
        End Set
    End Property

    Protected _code_depense_id As Integer = 0
    Public Overridable Property code_depense_id() As Integer Implements _IAchats.code_depense_id
        Get
            Return _code_depense_id
        End Get
        Set(ByVal value As Integer)
            If _code_depense_id <> value Then
                IsChanged = True
                _code_depense_id = value
            End If
        End Set
    End Property

    Protected _num_facture As String = ""
    Public Overridable Property num_facture() As String Implements _IAchats.num_facture
        Get
            Return _num_facture
        End Get
        Set(ByVal value As String)
            If _num_facture <> value Then
                IsChanged = True
                _num_facture = value
            End If
        End Set
    End Property

    Protected _prix_achat As Single = 0
    Public Overridable Property prix_achat() As Single Implements _IAchats.prix_achat
        Get
            Return _prix_achat
        End Get
        Set(ByVal value As Single)
            If _prix_achat <> value Then
                IsChanged = True
                _prix_achat = value
            End If
        End Set
    End Property

    Protected _cout As Single = 0
    Public Overridable Property cout() As Single Implements _IAchats.cout
        Get
            Return _cout
        End Get
        Set(ByVal value As Single)
            If _cout <> value Then
                IsChanged = True
                _cout = value
            End If
        End Set
    End Property

    Protected _created As DateTime = Nothing
    Public Overridable Property created() As DateTime Implements _IAchats.created
        Get
            Return _created
        End Get
        Set(ByVal value As DateTime)
            If _created <> value Then
                IsChanged = True
                _created = value
            End If
        End Set
    End Property

    Protected _user_id As Integer = 0
    Public Overridable Property user_id() As Integer Implements _IAchats.user_id
        Get
            Return _user_id
        End Get
        Set(ByVal value As Integer)
            If _user_id <> value Then
                IsChanged = True
                _user_id = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Achats from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Achats = Manager.Read(Id)
                _id = int.id
                _fournisseur_id = int.fournisseur_id
                _code_depense_id = int.code_depense_id
                _num_facture = int.num_facture
                _prix_achat = int.prix_achat
                _cout = int.cout
                _created = int.created
                _user_id = int.user_id
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Achats on DB.
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
        If _num_facture.Length > 255 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Achats
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IAchats

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property fournisseur_id() As Integer


    Property code_depense_id() As Integer


    Property num_facture() As String


    Property prix_achat() As Single


    Property cout() As Single


    Property created() As DateTime


    Property user_id() As Integer


#End Region

End Interface