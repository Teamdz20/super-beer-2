Public Class EmployesEntity
    Private _id As String
    Private _nom As String
    Private _prenom As String
    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property


    Public Property Prenon As String
        Get
            Return _prenom
        End Get
        Set(value As String)
            _prenom = value
        End Set
    End Property
 
End Class
