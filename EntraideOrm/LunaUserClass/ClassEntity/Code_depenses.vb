#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 01/04/2017 
#End Region



''' <summary>
'''Entity Class for table Code_depenses
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class Code_depenses
	Inherits _Code_depenses
    Implements ICode_depenses

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


Public Overrides Property nom() as string
    Get
	    Return MyBase.nom
    End Get
    Set (byval value as string)
        MyBase.nom= value
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


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements ICode_depenses.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements ICode_depenses.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements ICode_depenses.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Code_depenses
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface ICode_depenses
        Inherits _ICode_depenses

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface