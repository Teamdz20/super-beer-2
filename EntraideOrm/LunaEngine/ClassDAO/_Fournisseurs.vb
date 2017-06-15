#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 06/06/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Fournisseurs
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Fournisseurs
    Inherits LUNA.LunaBaseClassEntity
    Implements _IFournisseurs
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IFournisseurs.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("created") Is DBNull.Value Then created = myRecord("created")
        If Not myRecord("nom") Is DBNull.Value Then nom = myRecord("nom")
        If Not myRecord("nom_representant") Is DBNull.Value Then nom_representant = myRecord("nom_representant")
        If Not myRecord("poste") Is DBNull.Value Then poste = myRecord("poste")
        If Not myRecord("code") Is DBNull.Value Then code = myRecord("code")
        If Not myRecord("adresse") Is DBNull.Value Then adresse = myRecord("adresse")
        If Not myRecord("tel1") Is DBNull.Value Then tel1 = myRecord("tel1")
        If Not myRecord("tel2") Is DBNull.Value Then tel2 = myRecord("tel2")
        If Not myRecord("site") Is DBNull.Value Then site = myRecord("site")
        If Not myRecord("email") Is DBNull.Value Then email = myRecord("email")
        If Not myRecord("domaine_business") Is DBNull.Value Then domaine_business = myRecord("domaine_business")
        If Not myRecord("produit") Is DBNull.Value Then produit = myRecord("produit")
        If Not myRecord("classification_prix") Is DBNull.Value Then classification_prix = myRecord("classification_prix")
        If Not myRecord("note") Is DBNull.Value Then note = myRecord("note")
        If Not myRecord("categorie_fournisseur_id") Is DBNull.Value Then categorie_fournisseur_id = myRecord("categorie_fournisseur_id")
        If Not myRecord("user_id") Is DBNull.Value Then user_id = myRecord("user_id")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Fournisseurs)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(FournisseursDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Fournisseurs))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IFournisseurs.id
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

    Protected _created As DateTime = Nothing
    Public Overridable Property created() As DateTime Implements _IFournisseurs.created
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

    Protected _nom As String = ""
    Public Overridable Property nom() As String Implements _IFournisseurs.nom
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

    Protected _nom_representant As String = ""
    Public Overridable Property nom_representant() As String Implements _IFournisseurs.nom_representant
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
    Public Overridable Property poste() As String Implements _IFournisseurs.poste
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

    Protected _code As String = ""
    Public Overridable Property code() As String Implements _IFournisseurs.code
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
    Public Overridable Property adresse() As String Implements _IFournisseurs.adresse
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

    Protected _tel1 As String = ""
    Public Overridable Property tel1() As String Implements _IFournisseurs.tel1
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
    Public Overridable Property tel2() As String Implements _IFournisseurs.tel2
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

    Protected _site As String = ""
    Public Overridable Property site() As String Implements _IFournisseurs.site
        Get
            Return _site
        End Get
        Set(ByVal value As String)
            If _site <> value Then
                IsChanged = True
                _site = value
            End If
        End Set
    End Property

    Protected _email As String = ""
    Public Overridable Property email() As String Implements _IFournisseurs.email
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

    Protected _domaine_business As String = ""
    Public Overridable Property domaine_business() As String Implements _IFournisseurs.domaine_business
        Get
            Return _domaine_business
        End Get
        Set(ByVal value As String)
            If _domaine_business <> value Then
                IsChanged = True
                _domaine_business = value
            End If
        End Set
    End Property

    Protected _produit As String = ""
    Public Overridable Property produit() As String Implements _IFournisseurs.produit
        Get
            Return _produit
        End Get
        Set(ByVal value As String)
            If _produit <> value Then
                IsChanged = True
                _produit = value
            End If
        End Set
    End Property

    Protected _classification_prix As String = ""
    Public Overridable Property classification_prix() As String Implements _IFournisseurs.classification_prix
        Get
            Return _classification_prix
        End Get
        Set(ByVal value As String)
            If _classification_prix <> value Then
                IsChanged = True
                _classification_prix = value
            End If
        End Set
    End Property

    Protected _note As String = ""
    Public Overridable Property note() As String Implements _IFournisseurs.note
        Get
            Return _note
        End Get
        Set(ByVal value As String)
            If _note <> value Then
                IsChanged = True
                _note = value
            End If
        End Set
    End Property

    Protected _categorie_fournisseur_id As Integer = 0
    Public Overridable Property categorie_fournisseur_id() As Integer Implements _IFournisseurs.categorie_fournisseur_id
        Get
            Return _categorie_fournisseur_id
        End Get
        Set(ByVal value As Integer)
            If _categorie_fournisseur_id <> value Then
                IsChanged = True
                _categorie_fournisseur_id = value
            End If
        End Set
    End Property

    Protected _user_id As Integer = 0
    Public Overridable Property user_id() As Integer Implements _IFournisseurs.user_id
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
    '''This method read an Fournisseurs from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Fournisseurs = Manager.Read(Id)
                _id = int.id
                _created = int.created
                _nom = int.nom
                _nom_representant = int.nom_representant
                _poste = int.poste
                _code = int.code
                _adresse = int.adresse
                _tel1 = int.tel1
                _tel2 = int.tel2
                _site = int.site
                _email = int.email
                _domaine_business = int.domaine_business
                _produit = int.produit
                _classification_prix = int.classification_prix
                _note = int.note
                _categorie_fournisseur_id = int.categorie_fournisseur_id
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
    '''This method save an Fournisseurs on DB.
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
        If _nom_representant.Length > 50 Then Ris = False
        If _poste.Length > 50 Then Ris = False
        If _code.Length > 50 Then Ris = False
        If _adresse.Length > 30 Then Ris = False
        If _tel1.Length > 50 Then Ris = False
        If _tel2.Length > 50 Then Ris = False
        If _site.Length > 50 Then Ris = False
        If _email.Length > 50 Then Ris = False
        If _domaine_business.Length > 50 Then Ris = False
        If _produit.Length > 50 Then Ris = False
        If _classification_prix.Length > 14 Then Ris = False
        If _note.Length > 21845 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Fournisseurs
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IFournisseurs

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property created() As DateTime


    Property nom() As String


    Property nom_representant() As String


    Property poste() As String


    Property code() As String


    Property adresse() As String


    Property tel1() As String


    Property tel2() As String


    Property site() As String


    Property email() As String


    Property domaine_business() As String


    Property produit() As String


    Property classification_prix() As String


    Property note() As String


    Property categorie_fournisseur_id() As Integer


    Property user_id() As Integer


#End Region

End Interface