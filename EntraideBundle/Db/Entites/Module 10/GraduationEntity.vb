Imports EntraideBundle.Db.Entities

Namespace Db.Entities

    Public Class GraduationEntity
        Private _id As Integer = 0
        Private _date As Date
        Private _note As String
        Private _etudiant As EtudiantEntity
        Private _user As UserEntity

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set

        End Property
        Public Property DateGraduation As Date
            Get
                Return _date
            End Get
            Set(value As Date)
                _date = value
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
        Public Property Etudiant As EtudiantEntity
            Get
                If IsNothing(_etudiant) Then
                    _etudiant = New EtudiantEntity
                End If

                Return _etudiant
            End Get
            Set(value As EtudiantEntity)
                _etudiant = value
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
