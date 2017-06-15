#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 25/04/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Materiels
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Materiels
    Inherits LUNA.LunaBaseClassEntity
    Implements _IMateriels
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IMateriels.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("libelle") Is DBNull.Value Then libelle = myRecord("libelle")
        If Not myRecord("type_materiel_id") Is DBNull.Value Then type_materiel_id = myRecord("type_materiel_id")
        If Not myRecord("code") Is DBNull.Value Then code = myRecord("code")
        If Not myRecord("marque") Is DBNull.Value Then marque = myRecord("marque")
        If Not myRecord("description") Is DBNull.Value Then description = myRecord("description")
        If Not myRecord("num_facture") Is DBNull.Value Then num_facture = myRecord("num_facture")
        If Not myRecord("prix_achat") Is DBNull.Value Then prix_achat = myRecord("prix_achat")
        If Not myRecord("mode_obtention") Is DBNull.Value Then mode_obtention = myRecord("mode_obtention")
        If Not myRecord("ref_obtention_id") Is DBNull.Value Then ref_obtention_id = myRecord("ref_obtention_id")
        If Not myRecord("departement_id") Is DBNull.Value Then departement_id = myRecord("departement_id")
        If Not myRecord("activite_id") Is DBNull.Value Then activite_id = myRecord("activite_id")
        If Not myRecord("employe_id") Is DBNull.Value Then employe_id = myRecord("employe_id")
        If Not myRecord("amortissement_necessaire") Is DBNull.Value Then amortissement_necessaire = myRecord("amortissement_necessaire")
        If Not myRecord("annee_amortissement") Is DBNull.Value Then annee_amortissement = myRecord("annee_amortissement")
        If Not myRecord("montant_par_an") Is DBNull.Value Then montant_par_an = myRecord("montant_par_an")
        If Not myRecord("created") Is DBNull.Value Then created = myRecord("created")
        If Not myRecord("neuf") Is DBNull.Value Then neuf = myRecord("neuf")
        If Not myRecord("deja_utiliser") Is DBNull.Value Then deja_utiliser = myRecord("deja_utiliser")
        If Not myRecord("tres_bon_etat") Is DBNull.Value Then tres_bon_etat = myRecord("tres_bon_etat")
        If Not myRecord("avec_defaut") Is DBNull.Value Then avec_defaut = myRecord("avec_defaut")
        If Not myRecord("mauvaise_etat") Is DBNull.Value Then mauvaise_etat = myRecord("mauvaise_etat")
        If Not myRecord("note_etat") Is DBNull.Value Then note_etat = myRecord("note_etat")
        If Not myRecord("activite") Is DBNull.Value Then activite = myRecord("activite")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Materiels)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(MaterielsDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Materiels))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IMateriels.id
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

    Protected _libelle As String = ""
    Public Overridable Property libelle() As String Implements _IMateriels.libelle
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            If _libelle <> value Then
                IsChanged = True
                _libelle = value
            End If
        End Set
    End Property

    Protected _type_materiel_id As Integer = 0
    Public Overridable Property type_materiel_id() As Integer Implements _IMateriels.type_materiel_id
        Get
            Return _type_materiel_id
        End Get
        Set(ByVal value As Integer)
            If _type_materiel_id <> value Then
                IsChanged = True
                _type_materiel_id = value
            End If
        End Set
    End Property

    Protected _code As String = ""
    Public Overridable Property code() As String Implements _IMateriels.code
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

    Protected _marque As String = ""
    Public Overridable Property marque() As String Implements _IMateriels.marque
        Get
            Return _marque
        End Get
        Set(ByVal value As String)
            If _marque <> value Then
                IsChanged = True
                _marque = value
            End If
        End Set
    End Property

    Protected _description As String = ""
    Public Overridable Property description() As String Implements _IMateriels.description
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            If _description <> value Then
                IsChanged = True
                _description = value
            End If
        End Set
    End Property

    Protected _num_facture As String = ""
    Public Overridable Property num_facture() As String Implements _IMateriels.num_facture
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
    Public Overridable Property prix_achat() As Single Implements _IMateriels.prix_achat
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

    Protected _mode_obtention As String = ""
    Public Overridable Property mode_obtention() As String Implements _IMateriels.mode_obtention
        Get
            Return _mode_obtention
        End Get
        Set(ByVal value As String)
            If _mode_obtention <> value Then
                IsChanged = True
                _mode_obtention = value
            End If
        End Set
    End Property

    Protected _ref_obtention_id As Integer = 0
    Public Overridable Property ref_obtention_id() As Integer Implements _IMateriels.ref_obtention_id
        Get
            Return _ref_obtention_id
        End Get
        Set(ByVal value As Integer)
            If _ref_obtention_id <> value Then
                IsChanged = True
                _ref_obtention_id = value
            End If
        End Set
    End Property

    Protected _departement_id As Integer = 0
    Public Overridable Property departement_id() As Integer Implements _IMateriels.departement_id
        Get
            Return _departement_id
        End Get
        Set(ByVal value As Integer)
            If _departement_id <> value Then
                IsChanged = True
                _departement_id = value
            End If
        End Set
    End Property

    Protected _activite_id As Integer = 0
    Public Overridable Property activite_id() As Integer Implements _IMateriels.activite_id
        Get
            Return _activite_id
        End Get
        Set(ByVal value As Integer)
            If _activite_id <> value Then
                IsChanged = True
                _activite_id = value
            End If
        End Set
    End Property

    Protected _employe_id As Integer = 0
    Public Overridable Property employe_id() As Integer Implements _IMateriels.employe_id
        Get
            Return _employe_id
        End Get
        Set(ByVal value As Integer)
            If _employe_id <> value Then
                IsChanged = True
                _employe_id = value
            End If
        End Set
    End Property

    Protected _amortissement_necessaire As String = ""
    Public Overridable Property amortissement_necessaire() As String Implements _IMateriels.amortissement_necessaire
        Get
            Return _amortissement_necessaire
        End Get
        Set(ByVal value As String)
            If _amortissement_necessaire <> value Then
                IsChanged = True
                _amortissement_necessaire = value
            End If
        End Set
    End Property

    Protected _annee_amortissement As Integer = 0
    Public Overridable Property annee_amortissement() As Integer Implements _IMateriels.annee_amortissement
        Get
            Return _annee_amortissement
        End Get
        Set(ByVal value As Integer)
            If _annee_amortissement <> value Then
                IsChanged = True
                _annee_amortissement = value
            End If
        End Set
    End Property

    Protected _montant_par_an As Single = 0
    Public Overridable Property montant_par_an() As Single Implements _IMateriels.montant_par_an
        Get
            Return _montant_par_an
        End Get
        Set(ByVal value As Single)
            If _montant_par_an <> value Then
                IsChanged = True
                _montant_par_an = value
            End If
        End Set
    End Property

    Protected _created As DateTime = Nothing
    Public Overridable Property created() As DateTime Implements _IMateriels.created
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

    Protected _neuf As Boolean = False
    Public Overridable Property neuf() As Boolean Implements _IMateriels.neuf
        Get
            Return _neuf
        End Get
        Set(ByVal value As Boolean)
            If _neuf <> value Then
                IsChanged = True
                _neuf = value
            End If
        End Set
    End Property

    Protected _deja_utiliser As Boolean = False
    Public Overridable Property deja_utiliser() As Boolean Implements _IMateriels.deja_utiliser
        Get
            Return _deja_utiliser
        End Get
        Set(ByVal value As Boolean)
            If _deja_utiliser <> value Then
                IsChanged = True
                _deja_utiliser = value
            End If
        End Set
    End Property

    Protected _tres_bon_etat As Boolean = False
    Public Overridable Property tres_bon_etat() As Boolean Implements _IMateriels.tres_bon_etat
        Get
            Return _tres_bon_etat
        End Get
        Set(ByVal value As Boolean)
            If _tres_bon_etat <> value Then
                IsChanged = True
                _tres_bon_etat = value
            End If
        End Set
    End Property

    Protected _avec_defaut As Boolean = False
    Public Overridable Property avec_defaut() As Boolean Implements _IMateriels.avec_defaut
        Get
            Return _avec_defaut
        End Get
        Set(ByVal value As Boolean)
            If _avec_defaut <> value Then
                IsChanged = True
                _avec_defaut = value
            End If
        End Set
    End Property

    Protected _mauvaise_etat As Boolean = False
    Public Overridable Property mauvaise_etat() As Boolean Implements _IMateriels.mauvaise_etat
        Get
            Return _mauvaise_etat
        End Get
        Set(ByVal value As Boolean)
            If _mauvaise_etat <> value Then
                IsChanged = True
                _mauvaise_etat = value
            End If
        End Set
    End Property

    Protected _note_etat As String = ""
    Public Overridable Property note_etat() As String Implements _IMateriels.note_etat
        Get
            Return _note_etat
        End Get
        Set(ByVal value As String)
            If _note_etat <> value Then
                IsChanged = True
                _note_etat = value
            End If
        End Set
    End Property

    Protected _activite As String = ""
    Public Overridable Property activite() As String Implements _IMateriels.activite
        Get
            Return _activite
        End Get
        Set(ByVal value As String)
            If _activite <> value Then
                IsChanged = True
                _activite = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Materiels from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Materiels = Manager.Read(Id)
                _id = int.id
                _libelle = int.libelle
                _type_materiel_id = int.type_materiel_id
                _code = int.code
                _marque = int.marque
                _description = int.description
                _num_facture = int.num_facture
                _prix_achat = int.prix_achat
                _mode_obtention = int.mode_obtention
                _ref_obtention_id = int.ref_obtention_id
                _departement_id = int.departement_id
                _activite_id = int.activite_id
                _employe_id = int.employe_id
                _amortissement_necessaire = int.amortissement_necessaire
                _annee_amortissement = int.annee_amortissement
                _montant_par_an = int.montant_par_an
                _created = int.created
                _neuf = int.neuf
                _deja_utiliser = int.deja_utiliser
                _tres_bon_etat = int.tres_bon_etat
                _avec_defaut = int.avec_defaut
                _mauvaise_etat = int.mauvaise_etat
                _note_etat = int.note_etat
                _activite = int.activite
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Materiels on DB.
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
        If _libelle.Length > 255 Then Ris = False
        If _code.Length > 255 Then Ris = False
        If _marque.Length > 255 Then Ris = False
        If _description.Length > 21845 Then Ris = False
        If _num_facture.Length > 255 Then Ris = False
        If _mode_obtention.Length > 5 Then Ris = False
        If _amortissement_necessaire.Length > 3 Then Ris = False
        If _note_etat.Length > 21845 Then Ris = False
        If _activite.Length > 255 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Materiels
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IMateriels

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property libelle() As String


    Property type_materiel_id() As Integer


    Property code() As String


    Property marque() As String


    Property description() As String


    Property num_facture() As String


    Property prix_achat() As Single


    Property mode_obtention() As String


    Property ref_obtention_id() As Integer


    Property departement_id() As Integer


    Property activite_id() As Integer


    Property employe_id() As Integer


    Property amortissement_necessaire() As String


    Property annee_amortissement() As Integer


    Property montant_par_an() As Single


    Property created() As DateTime


    Property neuf() As Boolean


    Property deja_utiliser() As Boolean


    Property tres_bon_etat() As Boolean


    Property avec_defaut() As Boolean


    Property mauvaise_etat() As Boolean


    Property note_etat() As String


    Property activite() As String


#End Region

End Interface