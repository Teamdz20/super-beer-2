Namespace Db.Entities
    Public Class DonneurEntity2
        Private _id As Integer = 0
        Private _nom As String
        Private _date As Date
        Private _code As String
        Private _adresse As String
        Private _email As String
        Private _tel1 As String
        Private _tel2 As String
        Private _site As String
        Private _restriction As String
        Private _periode As String
        Private _note As String
        Private _nomRepresentant As String
        Private _poste As String
        Private _typeDon As String
        Private _categorieDonneur As CategorieDonneurEntity
        Private _user As UserEntity


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
        Public Property DateDonneur As Date
            Get
                Return _date
            End Get
            Set(value As Date)
                _date = value
            End Set

        End Property
        Public Property Code As String
            Get
                Return _code
            End Get
            Set(value As String)
                _code = value
            End Set

        End Property
        Public Property Adresse As String
            Get
                Return _adresse
            End Get
            Set(value As String)
                _adresse = value
            End Set

        End Property
        Public Property Email As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
            End Set

        End Property
        Public Property Tel1 As String
            Get
                Return _tel1
            End Get
            Set(value As String)
                _tel1 = value
            End Set

        End Property
        Public Property Tel2 As String
            Get
                Return _tel2
            End Get
            Set(value As String)
                _tel2 = value
            End Set

        End Property
        Public Property Site As String
            Get
                Return _site
            End Get
            Set(value As String)
                _site = value
            End Set

        End Property

        Public Property Restriction As String
            Get
                Return _restriction
            End Get
            Set(value As String)
                _restriction = value
            End Set

        End Property
        Public Property Periode As String
            Get
                Return _periode
            End Get
            Set(value As String)
                _periode = value
            End Set

        End Property
        Public Property Note As String
            Get
                Return _note
            End Get
            Set(value As String)
                _note = value
            End Set

        End Property
        Public Property Nomrepresentant As String
            Get
                Return _nomRepresentant
            End Get
            Set(value As String)
                _nomRepresentant = value
            End Set

        End Property
        Public Property Poste As String
            Get
                Return _poste
            End Get
            Set(value As String)
                _poste = value
            End Set

        End Property
        Public Property TypeDon As String
            Get
                Return _typeDon
            End Get
            Set(value As String)
                _typeDon = value
            End Set

        End Property
        Public Property CategorieDonneur As CategorieDonneurEntity
            Get
                If IsNothing(_categorieDonneur) Then
                    _categorieDonneur = New CategorieDonneurEntity
                End If

                Return _categorieDonneur
            End Get
            Set(value As CategorieDonneurEntity)
                _categorieDonneur = value
            End Set
        End Property
        Public Property User As UserEntity
            Get
                If IsNothing(_user) Then
                    _user = New UserEntity
                End If

                Return _user
            End Get
            Set(value As UserEntity)
                _user = value
            End Set
        End Property
    End Class
End Namespace
