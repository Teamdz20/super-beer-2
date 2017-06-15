#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 25/04/2017 
#End Region



''' <summary>
'''Entity Class for table Materiels
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Materiels
    Inherits _Materiels
    Implements IMateriels

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord As IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


    Public Overrides Property id() As Integer
        Get
            Return MyBase.id
        End Get
        Set(ByVal value As Integer)
            MyBase.id = value
        End Set
    End Property


    Public Overrides Property libelle() As String
        Get
            Return MyBase.libelle
        End Get
        Set(ByVal value As String)
            MyBase.libelle = value
        End Set
    End Property


    Public Overrides Property type_materiel_id() As Integer
        Get
            Return MyBase.type_materiel_id
        End Get
        Set(ByVal value As Integer)
            MyBase.type_materiel_id = value
        End Set
    End Property


    Public Overrides Property code() As String
        Get
            Return MyBase.code
        End Get
        Set(ByVal value As String)
            MyBase.code = value
        End Set
    End Property


    Public Overrides Property marque() As String
        Get
            Return MyBase.marque
        End Get
        Set(ByVal value As String)
            MyBase.marque = value
        End Set
    End Property


    Public Overrides Property description() As String
        Get
            Return MyBase.description
        End Get
        Set(ByVal value As String)
            MyBase.description = value
        End Set
    End Property


    Public Overrides Property num_facture() As String
        Get
            Return MyBase.num_facture
        End Get
        Set(ByVal value As String)
            MyBase.num_facture = value
        End Set
    End Property


    Public Overrides Property prix_achat() As Single
        Get
            Return MyBase.prix_achat
        End Get
        Set(ByVal value As Single)
            MyBase.prix_achat = value
        End Set
    End Property


    Public Overrides Property mode_obtention() As String
        Get
            Return MyBase.mode_obtention
        End Get
        Set(ByVal value As String)
            MyBase.mode_obtention = value
        End Set
    End Property


    Public Overrides Property ref_obtention_id() As Integer
        Get
            Return MyBase.ref_obtention_id
        End Get
        Set(ByVal value As Integer)
            MyBase.ref_obtention_id = value
        End Set
    End Property


    Public Overrides Property departement_id() As Integer
        Get
            Return MyBase.departement_id
        End Get
        Set(ByVal value As Integer)
            MyBase.departement_id = value
        End Set
    End Property


    Public Overrides Property activite_id() As Integer
        Get
            Return MyBase.activite_id
        End Get
        Set(ByVal value As Integer)
            MyBase.activite_id = value
        End Set
    End Property


    Public Overrides Property employe_id() As Integer
        Get
            Return MyBase.employe_id
        End Get
        Set(ByVal value As Integer)
            MyBase.employe_id = value
        End Set
    End Property


    Public Overrides Property amortissement_necessaire() As String
        Get
            Return MyBase.amortissement_necessaire
        End Get
        Set(ByVal value As String)
            MyBase.amortissement_necessaire = value
        End Set
    End Property


    Public Overrides Property annee_amortissement() As Integer
        Get
            Return MyBase.annee_amortissement
        End Get
        Set(ByVal value As Integer)
            MyBase.annee_amortissement = value
        End Set
    End Property


    Public Overrides Property montant_par_an() As Single
        Get
            Return MyBase.montant_par_an
        End Get
        Set(ByVal value As Single)
            MyBase.montant_par_an = value
        End Set
    End Property


    Public Overrides Property created() As DateTime
        Get
            Return MyBase.created
        End Get
        Set(ByVal value As DateTime)
            MyBase.created = value
        End Set
    End Property


    Public Overrides Property neuf() As Boolean
        Get
            Return MyBase.neuf
        End Get
        Set(ByVal value As Boolean)
            MyBase.neuf = value
        End Set
    End Property


    Public Overrides Property deja_utiliser() As Boolean
        Get
            Return MyBase.deja_utiliser
        End Get
        Set(ByVal value As Boolean)
            MyBase.deja_utiliser = value
        End Set
    End Property


    Public Overrides Property tres_bon_etat() As Boolean
        Get
            Return MyBase.tres_bon_etat
        End Get
        Set(ByVal value As Boolean)
            MyBase.tres_bon_etat = value
        End Set
    End Property


    Public Overrides Property avec_defaut() As Boolean
        Get
            Return MyBase.avec_defaut
        End Get
        Set(ByVal value As Boolean)
            MyBase.avec_defaut = value
        End Set
    End Property


    Public Overrides Property mauvaise_etat() As Boolean
        Get
            Return MyBase.mauvaise_etat
        End Get
        Set(ByVal value As Boolean)
            MyBase.mauvaise_etat = value
        End Set
    End Property


    Public Overrides Property note_etat() As String
        Get
            Return MyBase.note_etat
        End Get
        Set(ByVal value As String)
            MyBase.note_etat = value
        End Set
    End Property


    Public Overrides Property activite() As String
        Get
            Return MyBase.activite
        End Get
        Set(ByVal value As String)
            MyBase.activite = value
        End Set
    End Property


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IMateriels.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IMateriels.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IMateriels.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Materiels
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IMateriels
    Inherits _IMateriels

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface