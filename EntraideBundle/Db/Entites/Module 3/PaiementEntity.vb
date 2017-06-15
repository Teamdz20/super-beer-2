Public Class PaiementEntity
    Private _id As Integer = 0
    Private _typePaiement As String
    Private _montantP As Integer = 0
    Private _montantR As Integer = 0

    Private _revenu As EtudiantEntity


    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property TypePaiement As String
        Get
            Return _typePaiement
        End Get
        Set(value As String)
            _typePaiement = value
        End Set
    End Property
    Public Property MontantP As Integer
        Get
            Return _montantP
        End Get
        Set(value As Integer)
            _montantP = value
        End Set
    End Property

    Public Property MontantR As Integer
        Get
            Return _montantR
        End Get
        Set(value As Integer)
            _montantR = value
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
