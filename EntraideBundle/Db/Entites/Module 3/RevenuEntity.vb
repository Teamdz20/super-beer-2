Public Class RevenuEntity
    Private _id As Integer = 0
    Private _codeRevenu As String
    Private _nomActivite As String
    Private _montant As Integer


    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property CodeRevenu As String
        Get
            Return _codeRevenu
        End Get
        Set(value As String)
            _codeRevenu = value
        End Set
    End Property
    Public Property NomActivite As String
        Get
            Return _nomActivite
        End Get
        Set(value As String)
            _nomActivite = value
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
