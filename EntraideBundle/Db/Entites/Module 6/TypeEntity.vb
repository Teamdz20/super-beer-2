
Public Class TypeEntity
    Private _id As Integer = 0
    Private _nom As String = ""


    Public Sub New(ByVal nom As String)
        Me._nom = nom
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal nom As String)
        Me._id = id
        Me._nom = nom
    End Sub

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

