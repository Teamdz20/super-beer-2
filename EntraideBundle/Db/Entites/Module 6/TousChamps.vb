Namespace bd.Entity
    Public Class TousChamps
        'Table employé
        Private _id_employe As String
        Private _nom As String
        Private _prenom As String
        Public Property id_employe As String

            Get
                Return _id_employe
            End Get
            Set(value As String)
                _id_employe = value
            End Set
        End Property
        Public Property nom As String

            Get
                Return _nom
            End Get
            Set(value As String)
                _nom = value
            End Set
        End Property
        Public Property prenom As String

            Get
                Return _prenom
            End Get
            Set(value As String)
                _prenom = value
            End Set
        End Property
    End Class
End Namespace
