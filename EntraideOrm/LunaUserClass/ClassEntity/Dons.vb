#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 31/03/2017 
#End Region



''' <summary>
'''Entity Class for table Dons
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Dons
	Inherits _Dons
    Implements IDons

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property id() as integer
    Get
	    Return MyBase.id
    End Get
    Set (byval value as integer)
        MyBase.id= value
    End Set
End property 


Public Overrides Property activite_financier_id() as integer
    Get
	    Return MyBase.activite_financier_id
    End Get
    Set (byval value as integer)
        MyBase.activite_financier_id= value
    End Set
End property 


Public Overrides Property departement_id() as integer
    Get
	    Return MyBase.departement_id
    End Get
    Set (byval value as integer)
        MyBase.departement_id= value
    End Set
End property 


Public Overrides Property donneur_id() as string
    Get
	    Return MyBase.donneur_id
    End Get
    Set (byval value as string)
        MyBase.donneur_id= value
    End Set
End property 


Public Overrides Property type_don() as string
    Get
	    Return MyBase.type_don
    End Get
    Set (byval value as string)
        MyBase.type_don= value
    End Set
End property 


Public Overrides Property materiel_id() as integer
    Get
	    Return MyBase.materiel_id
    End Get
    Set (byval value as integer)
        MyBase.materiel_id= value
    End Set
End property 


Public Overrides Property mode_reception() as string
    Get
	    Return MyBase.mode_reception
    End Get
    Set (byval value as string)
        MyBase.mode_reception= value
    End Set
End property 


Public Overrides Property montant_recu() as Single
    Get
	    Return MyBase.montant_recu
    End Get
    Set (byval value as Single)
        MyBase.montant_recu= value
    End Set
End property 


Public Overrides Property montant_sollicite() as Single
    Get
	    Return MyBase.montant_sollicite
    End Get
    Set (byval value as Single)
        MyBase.montant_sollicite= value
    End Set
End property 


Public Overrides Property code() as string
    Get
	    Return MyBase.code
    End Get
    Set (byval value as string)
        MyBase.code= value
    End Set
End property 


Public Overrides Property non_sollicite() as string
    Get
	    Return MyBase.non_sollicite
    End Get
    Set (byval value as string)
        MyBase.non_sollicite= value
    End Set
End property 


Public Overrides Property numero_cheque() as string
    Get
	    Return MyBase.numero_cheque
    End Get
    Set (byval value as string)
        MyBase.numero_cheque= value
    End Set
End property 


Public Overrides Property restriction() as string
    Get
	    Return MyBase.restriction
    End Get
    Set (byval value as string)
        MyBase.restriction= value
    End Set
End property 


Public Overrides Property note_restriction() as string
    Get
	    Return MyBase.note_restriction
    End Get
    Set (byval value as string)
        MyBase.note_restriction= value
    End Set
End property 


Public Overrides Property activite_menee() as string
    Get
	    Return MyBase.activite_menee
    End Get
    Set (byval value as string)
        MyBase.activite_menee= value
    End Set
End property 


Public Overrides Property created() as DateTime
    Get
	    Return MyBase.created
    End Get
    Set (byval value as DateTime)
        MyBase.created= value
    End Set
End property 


Public Overrides Property user_id() as integer
    Get
	    Return MyBase.user_id
    End Get
    Set (byval value as integer)
        MyBase.user_id= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IDons.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IDons.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IDons.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Dons
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IDons
        Inherits _IDons

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface