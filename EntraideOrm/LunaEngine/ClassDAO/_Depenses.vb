#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 26/04/2017 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Depenses
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _Depenses
    Inherits LUNA.LunaBaseClassEntity
    Implements _IDepenses
    '******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
    '******So you can replace this file without lost your code

    Public Sub New()

    End Sub

    Public Sub New(myRecord As IDataRecord)
        FillFromDataRecord(myRecord)
    End Sub

    Public Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _IDepenses.FillFromDataRecord
        id = myRecord("id")
        If Not myRecord("created") Is DBNull.Value Then created = myRecord("created")
        If Not myRecord("ref_id") Is DBNull.Value Then ref_id = myRecord("ref_id")
        If Not myRecord("type_depense_id") Is DBNull.Value Then type_depense_id = myRecord("type_depense_id")
        If Not myRecord("departement_id") Is DBNull.Value Then departement_id = myRecord("departement_id")
        If Not myRecord("code_depense_id") Is DBNull.Value Then code_depense_id = myRecord("code_depense_id")
        If Not myRecord("manager_id") Is DBNull.Value Then manager_id = myRecord("manager_id")
        If Not myRecord("montant") Is DBNull.Value Then montant = myRecord("montant")
        If Not myRecord("devise_id") Is DBNull.Value Then devise_id = myRecord("devise_id")
        If Not myRecord("beneficiere_id") Is DBNull.Value Then beneficiere_id = myRecord("beneficiere_id")
        If Not myRecord("motif_depense") Is DBNull.Value Then motif_depense = myRecord("motif_depense")
        If Not myRecord("realiser_par") Is DBNull.Value Then realiser_par = myRecord("realiser_par")
        If Not myRecord("code_demande") Is DBNull.Value Then code_demande = myRecord("code_demande")
        If Not myRecord("memo") Is DBNull.Value Then memo = myRecord("memo")
        If Not myRecord("activite") Is DBNull.Value Then activite = myRecord("activite")
        If Not myRecord("programme_id") Is DBNull.Value Then programme_id = myRecord("programme_id")

    End Sub

    Private Property Manager As LUNA.ILunaBaseClassDAO(Of Depenses)
        Get
            If _Mgr Is Nothing Then
                Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
                If _MgrType Is Nothing Then _MgrType = GetType(DepensesDAO)
                _Mgr = Activator.CreateInstance(_MgrType)
            End If
            Return _Mgr
        End Get
        Set(value As LUNA.ILunaBaseClassDAO(Of Depenses))
            _Mgr = value
        End Set
    End Property

#Region "Database Field Map"

    Protected _id As Integer = 0
    Public Overridable Property id() As Integer Implements _IDepenses.id
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
    Public Overridable Property created() As DateTime Implements _IDepenses.created
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

    Protected _ref_id As Integer = 0
    Public Overridable Property ref_id() As Integer Implements _IDepenses.ref_id
        Get
            Return _ref_id
        End Get
        Set(ByVal value As Integer)
            If _ref_id <> value Then
                IsChanged = True
                _ref_id = value
            End If
        End Set
    End Property

    Protected _type_depense_id As Integer = 0
    Public Overridable Property type_depense_id() As Integer Implements _IDepenses.type_depense_id
        Get
            Return _type_depense_id
        End Get
        Set(ByVal value As Integer)
            If _type_depense_id <> value Then
                IsChanged = True
                _type_depense_id = value
            End If
        End Set
    End Property

    Protected _departement_id As Integer = 0
    Public Overridable Property departement_id() As Integer Implements _IDepenses.departement_id
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

    Protected _code_depense_id As Integer = 0
    Public Overridable Property code_depense_id() As Integer Implements _IDepenses.code_depense_id
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

    Protected _manager_id As Integer = 0
    Public Overridable Property manager_id() As Integer Implements _IDepenses.manager_id
        Get
            Return _manager_id
        End Get
        Set(ByVal value As Integer)
            If _manager_id <> value Then
                IsChanged = True
                _manager_id = value
            End If
        End Set
    End Property

    Protected _montant As Single = 0
    Public Overridable Property montant() As Single Implements _IDepenses.montant
        Get
            Return _montant
        End Get
        Set(ByVal value As Single)
            If _montant <> value Then
                IsChanged = True
                _montant = value
            End If
        End Set
    End Property

    Protected _devise_id As Integer = 0
    Public Overridable Property devise_id() As Integer Implements _IDepenses.devise_id
        Get
            Return _devise_id
        End Get
        Set(ByVal value As Integer)
            If _devise_id <> value Then
                IsChanged = True
                _devise_id = value
            End If
        End Set
    End Property

    Protected _beneficiere_id As Integer = 0
    Public Overridable Property beneficiere_id() As Integer Implements _IDepenses.beneficiere_id
        Get
            Return _beneficiere_id
        End Get
        Set(ByVal value As Integer)
            If _beneficiere_id <> value Then
                IsChanged = True
                _beneficiere_id = value
            End If
        End Set
    End Property

    Protected _motif_depense As String = ""
    Public Overridable Property motif_depense() As String Implements _IDepenses.motif_depense
        Get
            Return _motif_depense
        End Get
        Set(ByVal value As String)
            If _motif_depense <> value Then
                IsChanged = True
                _motif_depense = value
            End If
        End Set
    End Property

    Protected _realiser_par As Integer = 0
    Public Overridable Property realiser_par() As Integer Implements _IDepenses.realiser_par
        Get
            Return _realiser_par
        End Get
        Set(ByVal value As Integer)
            If _realiser_par <> value Then
                IsChanged = True
                _realiser_par = value
            End If
        End Set
    End Property

    Protected _code_demande As String = ""
    Public Overridable Property code_demande() As String Implements _IDepenses.code_demande
        Get
            Return _code_demande
        End Get
        Set(ByVal value As String)
            If _code_demande <> value Then
                IsChanged = True
                _code_demande = value
            End If
        End Set
    End Property

    Protected _memo As String = ""
    Public Overridable Property memo() As String Implements _IDepenses.memo
        Get
            Return _memo
        End Get
        Set(ByVal value As String)
            If _memo <> value Then
                IsChanged = True
                _memo = value
            End If
        End Set
    End Property

    Protected _activite As String = ""
    Public Overridable Property activite() As String Implements _IDepenses.activite
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

    Protected _programme_id As Integer = 0
    Public Overridable Property programme_id() As Integer Implements _IDepenses.programme_id
        Get
            Return _programme_id
        End Get
        Set(ByVal value As Integer)
            If _programme_id <> value Then
                IsChanged = True
                _programme_id = value
            End If
        End Set
    End Property


#End Region

#Region "Method"
    ''' <summary>
    '''This method read an Depenses from DB.
    ''' </summary>
    ''' <returns>
    '''Return 0 if all ok, 1 if error
    ''' </returns>
    Public Overridable Function Read(Id As Integer) As Integer
        'Return 0 if all ok
        Dim Ris As Integer = 0
        Try
            Using Manager
                Dim int As Depenses = Manager.Read(Id)
                _id = int.id
                _created = int.created
                _ref_id = int.ref_id
                _type_depense_id = int.type_depense_id
                _departement_id = int.departement_id
                _code_depense_id = int.code_depense_id
                _manager_id = int.manager_id
                _montant = int.montant
                _devise_id = int.devise_id
                _beneficiere_id = int.beneficiere_id
                _motif_depense = int.motif_depense
                _realiser_par = int.realiser_par
                _code_demande = int.code_demande
                _memo = int.memo
                _activite = int.activite
                _programme_id = int.programme_id
            End Using
            Manager = Nothing
        Catch ex As Exception
            ManageError(ex)
            Ris = 1
        End Try
        Return Ris
    End Function

    ''' <summary>
    '''This method save an Depenses on DB.
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
        If _motif_depense.Length > 21845 Then Ris = False
        If _code_demande.Length > 255 Then Ris = False
        If _memo.Length > 21845 Then Ris = False
        If _activite.Length > 255 Then Ris = False

        Return Ris
    End Function

#End Region

#Region "Embedded Class"


#End Region

End Class

''' <summary>
'''Interface for table Depenses
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _IDepenses

    Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"


    Property id() As Integer


    Property created() As DateTime


    Property ref_id() As Integer


    Property type_depense_id() As Integer


    Property departement_id() As Integer


    Property code_depense_id() As Integer


    Property manager_id() As Integer


    Property montant() As Single


    Property devise_id() As Integer


    Property beneficiere_id() As Integer


    Property motif_depense() As String


    Property realiser_par() As Integer


    Property code_demande() As String


    Property memo() As String


    Property activite() As String


    Property programme_id() As Integer


#End Region

End Interface