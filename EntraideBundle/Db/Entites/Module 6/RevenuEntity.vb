Namespace Db.Entities
    Public Class RevenuEntity
        Private _id As String
        Private _date As Date
        Private _montant As Double
        Private _reglement As String
        Private _devise As DeviseEntity
        Private _poste As String
        Private _memo As String
        Private _employe As EmployesEntity
        Private _employe1 As EmployesEntity
        Private _type As TypeEntity
        Private _classif As ClassEntity
        Private _activite_financier_id As String

        Public Property Id As String
            Get
                Return _id
            End Get
            Set(value As String)
                _id = value
            End Set
        End Property

        Public Property Date_revenu As Date
            Get
                Return _date
            End Get
            Set(value As Date)
                _date = value
            End Set
        End Property

        Public Property Montant As Double
            Get
                Return _montant
            End Get
            Set(value As Double)
                _montant = value
            End Set
        End Property

        Public Property Reglement As String
            Get
                Return _reglement
            End Get
            Set(value As String)
                _reglement = value
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
        Public Property Memo As String
            Get
                Return _memo
            End Get
            Set(value As String)
                _memo = value
            End Set
        End Property

        Public Property Employe As EmployesEntity
            Get
                If IsNothing(_employe) Then
                    _employe = New EmployesEntity
                End If

                Return _employe
            End Get
            Set(value As EmployesEntity)
                _employe = value
            End Set
        End Property

        Public Property RecuDe As EmployesEntity
            Get
                If IsNothing(_employe1) Then
                    _employe1 = New EmployesEntity
                End If

                Return _employe1
            End Get
            Set(value As EmployesEntity)
                _employe1 = value
            End Set
        End Property
        Public Property Type As TypeEntity
            Get
                If IsNothing(_type) Then
                    _type = New TypeEntity
                End If

                Return _type
            End Get
            Set(value As TypeEntity)
                _type = value
            End Set
        End Property
        Public Property Classification As ClassEntity
            Get
                If IsNothing(_classif) Then
                    _classif = New ClassEntity
                End If
                Return _classif

            End Get
            Set(value As ClassEntity)
                _classif = value
            End Set
        End Property

        Public Property Devise As DeviseEntity
            Get
                If IsNothing(_devise) Then
                    _devise = New DeviseEntity

                End If
                Return _devise
            End Get
            Set(value As DeviseEntity)
                _devise = value
            End Set
        End Property

        Private _activite_financier As ActiviteFinancierEntity

        Property ActiviteFinancier As ActiviteFinancierEntity
            Get
                If IsNothing(_activite_financier) Then _activite_financier = New ActiviteFinancierEntity
                Return _activite_financier
            End Get
            Set(value As ActiviteFinancierEntity)
                _activite_financier = value
            End Set
        End Property


        Public Property activite_financier_id As String
            Get
                If IsNothing(_activite_financier_id) Then _activite_financier_id = ""
                Return _activite_financier_id
            End Get
            Set(value As String)
                _activite_financier_id = value
            End Set
        End Property

    End Class
End Namespace
