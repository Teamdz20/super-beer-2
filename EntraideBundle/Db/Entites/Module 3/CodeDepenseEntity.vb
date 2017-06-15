Public Class CodeDepenseEntity

    Public _id As Integer = 0

    Public _nom As String

    Public _codeRevenu As String

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

    Public Property CodeRevenu As String
        Get
            Return _codeRevenu
        End Get
        Set(value As String)
            _codeRevenu = value
        End Set
    End Property



End Class
