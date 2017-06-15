Namespace Db.Entities
    Public Class BureauAlumniEntity
        Private _id As Integer = 0
        Private _poste As String
        Private _date As Date
        Private _etudiant As EtudiantEntity
        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
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
        Public Property DateFonction As Date
            Get
                Return _date
            End Get
            Set(value As Date)
                _date = value
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
    End Class
End Namespace