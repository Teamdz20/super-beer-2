Public Class CategorieDonneurEntity
    Private _id As Integer = 0
    Private _nom As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
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
End Class
