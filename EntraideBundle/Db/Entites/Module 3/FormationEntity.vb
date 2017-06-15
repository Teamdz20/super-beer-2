Namespace Db.Entities
    Public Class FormationEntity
        Private _id As Integer = 0
        Private _date As Date
        Private _typeFormation As TypeFormationEntity
        Private _etudiant As EtudiantEntity
        Private _revenu As EtudiantEntity

        Public Property id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property
        Public Property DateInscription As Date
            Get
                Return _date
            End Get
            Set(value As Date)
                _date = value
            End Set
        End Property

        Public Property TypeFormation As TypeFormationEntity
            Get
                If IsNothing(_typeFormation) Then
                    _typeFormation = New TypeFormationEntity
                End If

                Return _typeFormation
            End Get
            Set(value As TypeFormationEntity)
                _typeFormation = value
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
        Public Property Revenu As EtudiantEntity
            Get
                If IsNothing(_revenu) Then
                    _revenu = New EtudiantEntity
                End If

                Return _revenu
            End Get
            Set(value As EtudiantEntity)
                _revenu = value
            End Set
        End Property


    End Class
End Namespace
