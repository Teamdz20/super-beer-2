Public Class TypeFormationEntity

    Private _id As Integer = 0
    Private _nom As String
    Private _montant As Integer = 0
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


    Public Property Montant As Integer
        Get
            Return _montant
        End Get
        Set(value As Integer)
            _montant = value
        End Set
    End Property


End Class
