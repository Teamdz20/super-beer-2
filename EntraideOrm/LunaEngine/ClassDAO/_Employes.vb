#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 24/04/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Employes
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Employes
    Inherits LUNA.LunaBaseClassEntity
    Implements _IEmployes
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IEmployes.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("code") Is DBNull.Value Then code = myRecord("code")
        nom = myRecord("nom")
        prenom = myRecord("prenom")
        sexe = myRecord("sexe")
        situation_matrimonial = myRecord("situation_matrimonial")
        nb_enfant = myRecord("nb_enfant")
        date_naissance = myRecord("date_naissance")
        lieu_naissance = myRecord("lieu_naissance")
        nationnalite = myRecord("nationnalite")
        If Not myRecord("bp") Is DBNull.Value Then bp = myRecord("bp")
        tel1 = myRecord("tel1")
        If Not myRecord("tel2") Is DBNull.Value Then tel2 = myRecord("tel2")
        If Not myRecord("email") Is DBNull.Value Then email = myRecord("email")
        If Not myRecord("religion") Is DBNull.Value Then religion = myRecord("religion")
        If Not myRecord("precision_autre") Is DBNull.Value Then precision_autre = myRecord("precision_autre")
        If Not myRecord("delis") Is DBNull.Value Then delis = myRecord("delis")
        If Not myRecord("detail_delis") Is DBNull.Value Then detail_delis = myRecord("detail_delis")
        If Not myRecord("recu_formation") Is DBNull.Value Then recu_formation = myRecord("recu_formation")
        If Not myRecord("type_formation_recu") Is DBNull.Value Then type_formation_recu = myRecord("type_formation_recu")
        If Not myRecord("niveau_etude") Is DBNull.Value Then niveau_etude = myRecord("niveau_etude")
        If Not myRecord("diplome") Is DBNull.Value Then diplome = myRecord("diplome")
        If Not myRecord("ecole") Is DBNull.Value Then ecole = myRecord("ecole")
        nom_contact_urgent = myRecord("nom_contact_urgent")
        adresse_contact_urgent = myRecord("adresse_contact_urgent")
        phone_contact_urgent = myRecord("phone_contact_urgent")
        If Not myRecord("email_contact_urgent") Is DBNull.Value Then email_contact_urgent = myRecord("email_contact_urgent")
        If Not myRecord("competance_fr") Is DBNull.Value Then competance_fr = myRecord("competance_fr")
        If Not myRecord("competance_en") Is DBNull.Value Then competance_en = myRecord("competance_en")
        If Not myRecord("competance_information") Is DBNull.Value Then competance_information = myRecord("competance_information")
        If Not myRecord("autres_competances") Is DBNull.Value Then autres_competances = myRecord("autres_competances")
        If Not myRecord("note_exp_professionnelle") Is DBNull.Value Then note_exp_professionnelle = myRecord("note_exp_professionnelle")
        If Not myRecord("departement_id") Is DBNull.Value Then departement_id = myRecord("departement_id")
        If Not myRecord("poste_id") Is DBNull.Value Then poste_id = myRecord("poste_id")
        If Not myRecord("debut_contract") Is DBNull.Value Then debut_contract = myRecord("debut_contract")
        If Not myRecord("fin_contract") Is DBNull.Value Then fin_contract = myRecord("fin_contract")
        If Not myRecord("date_enregistrement") Is DBNull.Value Then date_enregistrement = myRecord("date_enregistrement")
        If Not myRecord("adresse") Is DBNull.Value Then adresse = myRecord("adresse")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Employes)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(EmployesDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Employes))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IEmployes.id
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

    Protected _code As String = ""
    Public Overridable Property code() As String Implements _IEmployes.code
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

    Protected _nom As String = ""
    Public Overridable Property nom() As String Implements _IEmployes.nom
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

    Protected _prenom As String = ""
    Public Overridable Property prenom() As String Implements _IEmployes.prenom
        Get
            Return _prenom
        End Get
        Set(ByVal value As String)
            If _prenom <> value Then
                IsChanged = True
                _prenom = value
            End If
        End Set
    End Property

    Protected _sexe As String = ""
    Public Overridable Property sexe() As String Implements _IEmployes.sexe
        Get
            Return _sexe
        End Get
        Set(ByVal value As String)
            If _sexe <> value Then
                IsChanged = True
                _sexe = value
            End If
        End Set
    End Property

    Protected _situation_matrimonial As String = ""
    Public Overridable Property situation_matrimonial() As String Implements _IEmployes.situation_matrimonial
        Get
            Return _situation_matrimonial
        End Get
        Set(ByVal value As String)
            If _situation_matrimonial <> value Then
                IsChanged = True
                _situation_matrimonial = value
            End If
        End Set
    End Property

    Protected _nb_enfant As Integer = 0
    Public Overridable Property nb_enfant() As Integer Implements _IEmployes.nb_enfant
        Get
            Return _nb_enfant
        End Get
        Set(ByVal value As Integer)
            If _nb_enfant <> value Then
                IsChanged = True
                _nb_enfant = value
            End If
        End Set
    End Property

    Protected _date_naissance As DateTime = Nothing
    Public Overridable Property date_naissance() As DateTime Implements _IEmployes.date_naissance
        Get
            Return _date_naissance
        End Get
        Set(ByVal value As DateTime)
            If _date_naissance <> value Then
                IsChanged = True
                _date_naissance = value
            End If
        End Set
    End Property

    Protected _lieu_naissance As String = ""
    Public Overridable Property lieu_naissance() As String Implements _IEmployes.lieu_naissance
        Get
            Return _lieu_naissance
        End Get
        Set(ByVal value As String)
            If _lieu_naissance <> value Then
                IsChanged = True
                _lieu_naissance = value
            End If
        End Set
    End Property

    Protected _nationnalite As String = ""
    Public Overridable Property nationnalite() As String Implements _IEmployes.nationnalite
        Get
            Return _nationnalite
        End Get
        Set(ByVal value As String)
            If _nationnalite <> value Then
                IsChanged = True
                _nationnalite = value
            End If
        End Set
    End Property

    Protected _bp As String = ""
    Public Overridable Property bp() As String Implements _IEmployes.bp
        Get
            Return _bp
        End Get
        Set(ByVal value As String)
            If _bp <> value Then
                IsChanged = True
                _bp = value
            End If
        End Set
    End Property

    Protected _tel1 As String = ""
    Public Overridable Property tel1() As String Implements _IEmployes.tel1
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
    Public Overridable Property tel2() As String Implements _IEmployes.tel2
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

    Protected _email As String = ""
    Public Overridable Property email() As String Implements _IEmployes.email
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

    Protected _religion As String = ""
    Public Overridable Property religion() As String Implements _IEmployes.religion
        Get
            Return _religion
        End Get
        Set(ByVal value As String)
            If _religion <> value Then
                IsChanged = True
                _religion = value
            End If
        End Set
    End Property

    Protected _precision_autre As String = ""
    Public Overridable Property precision_autre() As String Implements _IEmployes.precision_autre
        Get
            Return _precision_autre
        End Get
        Set(ByVal value As String)
            If _precision_autre <> value Then
                IsChanged = True
                _precision_autre = value
            End If
        End Set
    End Property

    Protected _delis As Boolean = False
    Public Overridable Property delis() As Boolean Implements _IEmployes.delis
        Get
            Return _delis
        End Get
        Set(ByVal value As Boolean)
            If _delis <> value Then
                IsChanged = True
                _delis = value
            End If
        End Set
    End Property

    Protected _detail_delis As String = ""
    Public Overridable Property detail_delis() As String Implements _IEmployes.detail_delis
        Get
            Return _detail_delis
        End Get
        Set(ByVal value As String)
            If _detail_delis <> value Then
                IsChanged = True
                _detail_delis = value
            End If
        End Set
    End Property

    Protected _recu_formation As Boolean = False
    Public Overridable Property recu_formation() As Boolean Implements _IEmployes.recu_formation
        Get
            Return _recu_formation
        End Get
        Set(ByVal value As Boolean)
            If _recu_formation <> value Then
                IsChanged = True
                _recu_formation = value
            End If
        End Set
    End Property

    Protected _type_formation_recu As String = ""
    Public Overridable Property type_formation_recu() As String Implements _IEmployes.type_formation_recu
        Get
            Return _type_formation_recu
        End Get
        Set(ByVal value As String)
            If _type_formation_recu <> value Then
                IsChanged = True
                _type_formation_recu = value
            End If
        End Set
    End Property

    Protected _niveau_etude As String = ""
    Public Overridable Property niveau_etude() As String Implements _IEmployes.niveau_etude
        Get
            Return _niveau_etude
        End Get
        Set(ByVal value As String)
            If _niveau_etude <> value Then
                IsChanged = True
                _niveau_etude = value
            End If
        End Set
    End Property

    Protected _diplome As String = ""
    Public Overridable Property diplome() As String Implements _IEmployes.diplome
        Get
            Return _diplome
        End Get
        Set(ByVal value As String)
            If _diplome <> value Then
                IsChanged = True
                _diplome = value
            End If
        End Set
    End Property

    Protected _ecole As String = ""
    Public Overridable Property ecole() As String Implements _IEmployes.ecole
        Get
            Return _ecole
        End Get
        Set(ByVal value As String)
            If _ecole <> value Then
                IsChanged = True
                _ecole = value
            End If
        End Set
    End Property

    Protected _nom_contact_urgent As String = ""
    Public Overridable Property nom_contact_urgent() As String Implements _IEmployes.nom_contact_urgent
        Get
            Return _nom_contact_urgent
        End Get
        Set(ByVal value As String)
            If _nom_contact_urgent <> value Then
                IsChanged = True
                _nom_contact_urgent = value
            End If
        End Set
    End Property

    Protected _adresse_contact_urgent As String = ""
    Public Overridable Property adresse_contact_urgent() As String Implements _IEmployes.adresse_contact_urgent
        Get
            Return _adresse_contact_urgent
        End Get
        Set(ByVal value As String)
            If _adresse_contact_urgent <> value Then
                IsChanged = True
                _adresse_contact_urgent = value
            End If
        End Set
    End Property

    Protected _phone_contact_urgent As String = ""
    Public Overridable Property phone_contact_urgent() As String Implements _IEmployes.phone_contact_urgent
        Get
            Return _phone_contact_urgent
        End Get
        Set(ByVal value As String)
            If _phone_contact_urgent <> value Then
                IsChanged = True
                _phone_contact_urgent = value
            End If
        End Set
    End Property

    Protected _email_contact_urgent As String = ""
    Public Overridable Property email_contact_urgent() As String Implements _IEmployes.email_contact_urgent
        Get
            Return _email_contact_urgent
        End Get
        Set(ByVal value As String)
            If _email_contact_urgent <> value Then
                IsChanged = True
                _email_contact_urgent = value
            End If
        End Set
    End Property

    Protected _competance_fr As String = ""
    Public Overridable Property competance_fr() As String Implements _IEmployes.competance_fr
        Get
            Return _competance_fr
        End Get
        Set(ByVal value As String)
            If _competance_fr <> value Then
                IsChanged = True
                _competance_fr = value
            End If
        End Set
    End Property

    Protected _competance_en As String = ""
    Public Overridable Property competance_en() As String Implements _IEmployes.competance_en
        Get
            Return _competance_en
        End Get
        Set(ByVal value As String)
            If _competance_en <> value Then
                IsChanged = True
                _competance_en = value
            End If
        End Set
    End Property

    Protected _competance_information As String = ""
    Public Overridable Property competance_information() As String Implements _IEmployes.competance_information
        Get
            Return _competance_information
        End Get
        Set(ByVal value As String)
            If _competance_information <> value Then
                IsChanged = True
                _competance_information = value
            End If
        End Set
    End Property

    Protected _autres_competances As String = ""
    Public Overridable Property autres_competances() As String Implements _IEmployes.autres_competances
        Get
            Return _autres_competances
        End Get
        Set(ByVal value As String)
            If _autres_competances <> value Then
                IsChanged = True
                _autres_competances = value
            End If
        End Set
    End Property

    Protected _note_exp_professionnelle As String = ""
    Public Overridable Property note_exp_professionnelle() As String Implements _IEmployes.note_exp_professionnelle
        Get
            Return _note_exp_professionnelle
        End Get
        Set(ByVal value As String)
            If _note_exp_professionnelle <> value Then
                IsChanged = True
                _note_exp_professionnelle = value
            End If
        End Set
    End Property

    Protected _departement_id As Integer = 0
    Public Overridable Property departement_id() As Integer Implements _IEmployes.departement_id
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

    Protected _poste_id As Integer = 0
    Public Overridable Property poste_id() As Integer Implements _IEmployes.poste_id
        Get
            Return _poste_id
        End Get
        Set(ByVal value As Integer)
            If _poste_id <> value Then
                IsChanged = True
                _poste_id = value
            End If
        End Set
    End Property

    Protected _debut_contract As DateTime = Nothing
    Public Overridable Property debut_contract() As DateTime Implements _IEmployes.debut_contract
        Get
            Return _debut_contract
        End Get
        Set(ByVal value As DateTime)
            If _debut_contract <> value Then
                IsChanged = True
                _debut_contract = value
            End If
        End Set
    End Property

    Protected _fin_contract As DateTime = Nothing
    Public Overridable Property fin_contract() As DateTime Implements _IEmployes.fin_contract
        Get
            Return _fin_contract
        End Get
        Set(ByVal value As DateTime)
            If _fin_contract <> value Then
                IsChanged = True
                _fin_contract = value
            End If
        End Set
    End Property

    Protected _date_enregistrement As DateTime = Nothing
    Public Overridable Property date_enregistrement() As DateTime Implements _IEmployes.date_enregistrement
        Get
            Return _date_enregistrement
        End Get
        Set(ByVal value As DateTime)
            If _date_enregistrement <> value Then
                IsChanged = True
                _date_enregistrement = value
            End If
        End Set
    End Property

    Protected _adresse As String = ""
    Public Overridable Property adresse() As String Implements _IEmployes.adresse
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


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Employes from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Employes = Manager.Read(Id)
                _id = int.id
                _code = int.code
                _nom = int.nom
                _prenom = int.prenom
                _sexe = int.sexe
                _situation_matrimonial = int.situation_matrimonial
                _nb_enfant = int.nb_enfant
                _date_naissance = int.date_naissance
                _lieu_naissance = int.lieu_naissance
                _nationnalite = int.nationnalite
                _bp = int.bp
                _tel1 = int.tel1
                _tel2 = int.tel2
                _email = int.email
                _religion = int.religion
                _precision_autre = int.precision_autre
                _delis = int.delis
                _detail_delis = int.detail_delis
                _recu_formation = int.recu_formation
                _type_formation_recu = int.type_formation_recu
                _niveau_etude = int.niveau_etude
                _diplome = int.diplome
                _ecole = int.ecole
                _nom_contact_urgent = int.nom_contact_urgent
                _adresse_contact_urgent = int.adresse_contact_urgent
                _phone_contact_urgent = int.phone_contact_urgent
                _email_contact_urgent = int.email_contact_urgent
                _competance_fr = int.competance_fr
                _competance_en = int.competance_en
                _competance_information = int.competance_information
                _autres_competances = int.autres_competances
                _note_exp_professionnelle = int.note_exp_professionnelle
                _departement_id = int.departement_id
                _poste_id = int.poste_id
                _debut_contract = int.debut_contract
                _fin_contract = int.fin_contract
                _date_enregistrement = int.date_enregistrement
                _adresse = int.adresse
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Employes on DB.
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
        If _code.Length > 100 Then Ris = False
        If _nom.Length = 0 Then Ris = False
        If _nom.Length > 100 Then Ris = False
        If _prenom.Length = 0 Then Ris = False
        If _prenom.Length > 100 Then Ris = False
        If _sexe.Length = 0 Then Ris = False
        If _sexe.Length > 1 Then Ris = False
        If _situation_matrimonial.Length = 0 Then Ris = False
        If _situation_matrimonial.Length > 11 Then Ris = False
        If _lieu_naissance.Length = 0 Then Ris = False
        If _lieu_naissance.Length > 255 Then Ris = False
        If _nationnalite.Length = 0 Then Ris = False
        If _nationnalite.Length > 255 Then Ris = False
        If _bp.Length > 20 Then Ris = False
        If _tel1.Length = 0 Then Ris = False
        If _tel1.Length > 20 Then Ris = False
        If _tel2.Length > 20 Then Ris = False
        If _email.Length > 50 Then Ris = False
        If _religion.Length > 19 Then Ris = False
        If _precision_autre.Length > 255 Then Ris = False
        If _detail_delis.Length > 21845 Then Ris = False
        If _type_formation_recu.Length > 255 Then Ris = False
        If _niveau_etude.Length > 255 Then Ris = False
        If _diplome.Length > 255 Then Ris = False
        If _ecole.Length > 255 Then Ris = False
        If _nom_contact_urgent.Length = 0 Then Ris = False
        If _nom_contact_urgent.Length > 255 Then Ris = False
        If _adresse_contact_urgent.Length = 0 Then Ris = False
        If _adresse_contact_urgent.Length > 21845 Then Ris = False
        If _phone_contact_urgent.Length = 0 Then Ris = False
        If _phone_contact_urgent.Length > 20 Then Ris = False
        If _email_contact_urgent.Length > 50 Then Ris = False
        If _competance_fr.Length > 21845 Then Ris = False
        If _competance_en.Length > 21845 Then Ris = False
        If _competance_information.Length > 21845 Then Ris = False
        If _autres_competances.Length > 21845 Then Ris = False
        If _note_exp_professionnelle.Length > 21845 Then Ris = False
        If _adresse.Length > 85 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Employes
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IEmployes

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property code() As String


    Property nom() As String


    Property prenom() As String


    Property sexe() As String


    Property situation_matrimonial() As String


    Property nb_enfant() As Integer


    Property date_naissance() As DateTime


    Property lieu_naissance() As String


    Property nationnalite() As String


    Property bp() As String


    Property tel1() As String


    Property tel2() As String


    Property email() As String


    Property religion() As String


    Property precision_autre() As String


    Property delis() As Boolean


    Property detail_delis() As String


    Property recu_formation() As Boolean


    Property type_formation_recu() As String


    Property niveau_etude() As String


    Property diplome() As String


    Property ecole() As String


    Property nom_contact_urgent() As String


    Property adresse_contact_urgent() As String


    Property phone_contact_urgent() As String


    Property email_contact_urgent() As String


    Property competance_fr() As String


    Property competance_en() As String


    Property competance_information() As String


    Property autres_competances() As String


    Property note_exp_professionnelle() As String


    Property departement_id() As Integer


    Property poste_id() As Integer


    Property debut_contract() As DateTime


    Property fin_contract() As DateTime


    Property date_enregistrement() As DateTime


    Property adresse() As String


#End Region

End Interface