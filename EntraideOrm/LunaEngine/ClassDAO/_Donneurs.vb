#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 05/06/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Donneurs
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Donneurs
    Inherits LUNA.LunaBaseClassEntity
    Implements _IDonneurs
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IDonneurs.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("date") Is DBNull.Value Then date_donneur = myRecord("date")
        If Not myRecord("nom") Is DBNull.Value Then nom = myRecord("nom")
        If Not myRecord("code") Is DBNull.Value Then code = myRecord("code")
        If Not myRecord("adresse") Is DBNull.Value Then adresse = myRecord("adresse")
        If Not myRecord("email") Is DBNull.Value Then email = myRecord("email")
        If Not myRecord("tel1") Is DBNull.Value Then tel1 = myRecord("tel1")
        If Not myRecord("tel2") Is DBNull.Value Then tel2 = myRecord("tel2")
        If Not myRecord("categorie_donneur_id") Is DBNull.Value Then categorie_donneur_id = myRecord("categorie_donneur_id")
        If Not myRecord("site_internet") Is DBNull.Value Then site_internet = myRecord("site_internet")
        If Not myRecord("restriction") Is DBNull.Value Then restriction = myRecord("restriction")
        If Not myRecord("periode_sollicitation") Is DBNull.Value Then periode_sollicitation = myRecord("periode_sollicitation")
        If Not myRecord("note_sollicitation") Is DBNull.Value Then note_sollicitation = myRecord("note_sollicitation")
        If Not myRecord("nom_representant") Is DBNull.Value Then nom_representant = myRecord("nom_representant")
        If Not myRecord("poste") Is DBNull.Value Then poste = myRecord("poste")
        If Not myRecord("user_id") Is DBNull.Value Then user_id = myRecord("user_id")
        If Not myRecord("type_don") Is DBNull.Value Then type_don = myRecord("type_don")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Donneurs)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(DonneursDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Donneurs))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IDonneurs.id
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

    Protected _date As DateTime = Nothing
    Public Overridable Property date_donneur() As DateTime Implements _IDonneurs.date_donneur
        Get
            Return _date
        End Get
        Set(ByVal value As DateTime)
            If _date <> value Then
                IsChanged = True
                _date = value
            End If
        End Set
    End Property

    Protected _nom As String = ""
    Public Overridable Property nom() As String Implements _IDonneurs.nom
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
    Public Overridable Property code() As String Implements _IDonneurs.code
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

    Protected _adresse As String = ""
    Public Overridable Property adresse() As String Implements _IDonneurs.adresse
        Get
            Return _adresse
        End Get
        Set(ByVal value As String)
            If _adresse <> value Then
                IsChanged = True
                _adresse = value
            End If
        End Set
    End Property

    Protected _email As String = ""
    Public Overridable Property email() As String Implements _IDonneurs.email
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            If _email <> value Then
                IsChanged = True
                _email = value
            End If
        End Set
    End Property

    Protected _tel1 As String = ""
    Public Overridable Property tel1() As String Implements _IDonneurs.tel1
        Get
            Return _tel1
        End Get
        Set(ByVal value As String)
            If _tel1 <> value Then
                IsChanged = True
                _tel1 = value
            End If
        End Set
    End Property

    Protected _tel2 As String = ""
    Public Overridable Property tel2() As String Implements _IDonneurs.tel2
        Get
            Return _tel2
        End Get
        Set(ByVal value As String)
            If _tel2 <> value Then
                IsChanged = True
                _tel2 = value
            End If
        End Set
    End Property

    Protected _categorie_donneur_id As Integer = 0
    Public Overridable Property categorie_donneur_id() As Integer Implements _IDonneurs.categorie_donneur_id
        Get
            Return _categorie_donneur_id
        End Get
        Set(ByVal value As Integer)
            If _categorie_donneur_id <> value Then
                IsChanged = True
                _categorie_donneur_id = value
            End If
        End Set
    End Property

    Protected _site_internet As String = ""
    Public Overridable Property site_internet() As String Implements _IDonneurs.site_internet
        Get
            Return _site_internet
        End Get
        Set(ByVal value As String)
            If _site_internet <> value Then
                IsChanged = True
                _site_internet = value
            End If
        End Set
    End Property

    Protected _restriction As String = ""
    Public Overridable Property restriction() As String Implements _IDonneurs.restriction
        Get
            Return _restriction
        End Get
        Set(ByVal value As String)
            If _restriction <> value Then
                IsChanged = True
                _restriction = value
            End If
        End Set
    End Property

    Protected _periode_sollicitation As String = ""
    Public Overridable Property periode_sollicitation() As String Implements _IDonneurs.periode_sollicitation
        Get
            Return _periode_sollicitation
        End Get
        Set(ByVal value As String)
            If _periode_sollicitation <> value Then
                IsChanged = True
                _periode_sollicitation = value
            End If
        End Set
    End Property

    Protected _note_sollicitation As String = ""
    Public Overridable Property note_sollicitation() As String Implements _IDonneurs.note_sollicitation
        Get
            Return _note_sollicitation
        End Get
        Set(ByVal value As String)
            If _note_sollicitation <> value Then
                IsChanged = True
                _note_sollicitation = value
            End If
        End Set
    End Property

    Protected _nom_representant As String = ""
    Public Overridable Property nom_representant() As String Implements _IDonneurs.nom_representant
        Get
            Return _nom_representant
        End Get
        Set(ByVal value As String)
            If _nom_representant <> value Then
                IsChanged = True
                _nom_representant = value
            End If
        End Set
    End Property

    Protected _poste As String = ""
    Public Overridable Property poste() As String Implements _IDonneurs.poste
        Get
            Return _poste
        End Get
        Set(ByVal value As String)
            If _poste <> value Then
                IsChanged = True
                _poste = value
            End If
        End Set
    End Property

    Protected _user_id As Integer = 0
    Public Overridable Property user_id() As Integer Implements _IDonneurs.user_id
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

    Protected _type_don As String = ""
    Public Overridable Property type_don() As String Implements _IDonneurs.type_don
        Get
            Return _type_don
        End Get
        Set(ByVal value As String)
            If _type_don <> value Then
                IsChanged = True
                _type_don = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Donneurs from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Donneurs = Manager.Read(Id)
                _id = int.id
                _date = int.date_donneur
                _nom = int.nom
                _code = int.code
                _adresse = int.adresse
                _email = int.email
                _tel1 = int.tel1
                _tel2 = int.tel2
                _categorie_donneur_id = int.categorie_donneur_id
                _site_internet = int.site_internet
                _restriction = int.restriction
                _periode_sollicitation = int.periode_sollicitation
                _note_sollicitation = int.note_sollicitation
                _nom_representant = int.nom_representant
                _poste = int.poste
                _user_id = int.user_id
                _type_don = int.type_don
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Donneurs on DB.
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
        If _nom.Length > 50 Then Ris = False
        If _code.Length > 50 Then Ris = False
        If _adresse.Length > 50 Then Ris = False
        If _email.Length > 50 Then Ris = False
        If _tel1.Length > 50 Then Ris = False
        If _tel2.Length > 50 Then Ris = False
        If _site_internet.Length > 50 Then Ris = False
        If _restriction.Length > 13 Then Ris = False
        If _periode_sollicitation.Length > 50 Then Ris = False
        If _note_sollicitation.Length > 21845 Then Ris = False
        If _nom_representant.Length > 50 Then Ris = False
        If _poste.Length > 50 Then Ris = False
        If _type_don.Length > 8 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Donneurs
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IDonneurs

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property date_donneur() As DateTime


    Property nom() As String


    Property code() As String


    Property adresse() As String


    Property email() As String


    Property tel1() As String


    Property tel2() As String


    Property categorie_donneur_id() As Integer


    Property site_internet() As String


    Property restriction() As String


    Property periode_sollicitation() As String


    Property note_sollicitation() As String


    Property nom_representant() As String


    Property poste() As String


    Property user_id() As Integer


    Property type_don() As String


#End Region

End Interface