Namespace Db.Entities
    Public Class DonEntity
        Inherits EntraideOrm.Dons

#Region "CONSTANTS"
        Public Const TYPE_MATERIEL As String = "MATERIEL"

        Public Const TYPE_ARGENT As String = "ARGENT"
#End Region

        Sub New()

        End Sub

        Sub New(ByVal myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
            Donneur = New DonneurEntity(myRecord)
            Departement = New DepartementEntity(myRecord)
            User = New UserEntity(myRecord)
            ActiviteFinancier = New ActiviteFinancierEntity(myRecord)
        End Sub

        Public Overrides Function Save() As Integer
            'Me.restriction = "'" & Me.restriction & "'"
            'Me.type_don = "'" & Me.type_don & "'"
            'Me.mode_reception = "'" & Me.mode_reception & "'"
            Return MyBase.Save()
        End Function

        ''' <summary>
        ''' Filling entity data from Record
        ''' </summary>
        ''' <param name="myRecord"></param>
        ''' <remarks></remarks>
        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("don_id")
            If Not myRecord("don_activite_financier_id") Is DBNull.Value Then activite_financier_id = myRecord("don_activite_financier_id")
            If Not myRecord("don_departement_id") Is DBNull.Value Then departement_id = myRecord("don_departement_id")
            If Not myRecord("don_donneur_id") Is DBNull.Value Then donneur_id = myRecord("don_donneur_id")
            If Not myRecord("don_type_don") Is DBNull.Value Then type_don = myRecord("don_type_don")
            If Not myRecord("don_materiel_id") Is DBNull.Value Then materiel_id = myRecord("don_materiel_id")
            If Not myRecord("don_mode_reception") Is DBNull.Value Then mode_reception = myRecord("don_mode_reception")
            If Not myRecord("don_montant_recu") Is DBNull.Value Then montant_recu = myRecord("don_montant_recu")
            If Not myRecord("don_montant_sollicite") Is DBNull.Value Then montant_sollicite = myRecord("don_montant_sollicite")
            If Not myRecord("don_code") Is DBNull.Value Then code = myRecord("don_code")
            If Not myRecord("don_non_sollicite") Is DBNull.Value Then non_sollicite = myRecord("don_non_sollicite")
            If Not myRecord("don_numero_cheque") Is DBNull.Value Then numero_cheque = myRecord("don_numero_cheque")
            If Not myRecord("don_restriction") Is DBNull.Value Then restriction = myRecord("don_restriction")
            If Not myRecord("don_note_restriction") Is DBNull.Value Then note_restriction = myRecord("don_note_restriction")
            If Not myRecord("don_activite_menee") Is DBNull.Value Then activite_menee = myRecord("don_activite_menee")
            If Not myRecord("don_created") Is DBNull.Value Then created = myRecord("don_created")
            If Not myRecord("don_user_id") Is DBNull.Value Then user_id = myRecord("don_user_id")
        End Sub


#Region "RelationShip Fields"
        Private _donneur As DonneurEntity
        Public Property Donneur As DonneurEntity
            Get
                If IsNothing(_donneur) Then _donneur = New DonneurEntity
                Return _donneur
            End Get
            Set(value As DonneurEntity)
                If Not value.Equals(_donneur) Then IsChanged = True
                _donneur = value
            End Set
        End Property


        Private _departement As DepartementEntity
        Public Property Departement As DepartementEntity
            Get
                If IsNothing(_departement) Then _departement = New DepartementEntity
                Return _departement
            End Get
            Set(value As DepartementEntity)
                If Not value.Equals(_departement) Then IsChanged = True
                _departement = value
            End Set
        End Property


        Private _user As UserEntity
        Public Property User As UserEntity
            Get
                If IsNothing(_user) Then _user = New UserEntity
                Return _user
            End Get
            Set(value As UserEntity)
                If Not value.Equals(_user) Then IsChanged = True
                _user = value
            End Set
        End Property


        Private _activite_financier As ActiviteFinancierEntity
        Public Property ActiviteFinancier As ActiviteFinancierEntity
            Get
                If IsNothing(_activite_financier) Then _activite_financier = New ActiviteFinancierEntity
                Return _activite_financier
            End Get
            Set(value As ActiviteFinancierEntity)
                If Not value.Equals(_activite_financier) Then IsChanged = True
                _activite_financier = value
            End Set
        End Property


#End Region

    End Class
End Namespace