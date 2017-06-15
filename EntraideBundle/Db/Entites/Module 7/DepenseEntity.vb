Namespace Db.Entities
    Public Class DepenseEntity
        Inherits EntraideOrm.Depenses

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
            TypeDepense = New TypeDepenseEntity(myRecord)
            CodeDepense = New CodeDepenseEntity(myRecord)
            Departement = New DepartementEntity(myRecord)
            Devise = New DeviseEntity(myRecord)
            Programme = New ProgrammeEntity(myRecord)
        End Sub

        ''' <summary>
        ''' Filling entity data from database record
        ''' </summary>
        ''' <param name="myRecord"></param>
        ''' <remarks></remarks>
        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("depense_id")
            If Not myRecord("depense_created") Is DBNull.Value Then created = myRecord("depense_created")
            If Not myRecord("depense_type_depense_id") Is DBNull.Value Then type_depense_id = myRecord("depense_type_depense_id")
            If Not myRecord("depense_departement_id") Is DBNull.Value Then departement_id = myRecord("depense_departement_id")
            If Not myRecord("depense_code_depense_id") Is DBNull.Value Then code_depense_id = myRecord("depense_code_depense_id")
            If Not myRecord("depense_manager_id") Is DBNull.Value Then manager_id = myRecord("depense_manager_id")
            If Not myRecord("depense_montant") Is DBNull.Value Then montant = myRecord("depense_montant")
            If Not myRecord("depense_devise_id") Is DBNull.Value Then devise_id = myRecord("depense_devise_id")
            If Not myRecord("depense_beneficiere_id") Is DBNull.Value Then beneficiere_id = myRecord("depense_beneficiere_id")
            If Not myRecord("depense_motif_depense") Is DBNull.Value Then motif_depense = myRecord("depense_motif_depense")
            If Not myRecord("depense_realiser_par") Is DBNull.Value Then realiser_par = myRecord("depense_realiser_par")
            If Not myRecord("depense_code_demande") Is DBNull.Value Then code_demande = myRecord("depense_code_demande")
            If Not myRecord("depense_memo") Is DBNull.Value Then memo = myRecord("depense_memo")
        End Sub


#Region "RELATIONSHIP PROPERTIES"

        Private _type_depense As TypeDepenseEntity
        Public Property TypeDepense As TypeDepenseEntity
            Get
                If IsNothing(_type_depense) Then _type_depense = New TypeDepenseEntity
                Return _type_depense
            End Get
            Set(value As TypeDepenseEntity)
                If Not value.Equals(_type_depense) Then IsChanged = True
                _type_depense = value
            End Set
        End Property


        Private _code_depense As CodeDepenseEntity
        Public Property CodeDepense As CodeDepenseEntity
            Get
                If IsNothing(_code_depense) Then _code_depense = New CodeDepenseEntity
                Return _code_depense
            End Get
            Set(value As CodeDepenseEntity)
                If Not value.Equals(_code_depense) Then IsChanged = True
                _code_depense = value
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


        Private _manager As EmployeEntity
        Public Property Manager As EmployeEntity
            Get
                If IsNothing(_manager) Then _manager = New EmployeEntity
                Return _manager
            End Get
            Set(value As EmployeEntity)
                If Not value.Equals(_manager) Then IsChanged = True
                _manager = value
            End Set
        End Property


        Private _devise As DeviseEntity
        Public Property Devise As DeviseEntity
            Get
                If IsNothing(_devise) Then
                    _devise = New DeviseEntity
                End If
                Return _devise
            End Get
            Set(value As DeviseEntity)
                If Not value.Equals(_devise) Then IsChanged = True
                _devise = value
            End Set
        End Property


        Private _beneficiaire As EmployeEntity
        Public Property Beneficiaire As EmployeEntity
            Get
                If IsNothing(_beneficiaire) Then
                    _devise = New DeviseEntity
                End If

                Return _beneficiaire
            End Get
            Set(value As EmployeEntity)
                If Not value.Equals(_beneficiaire) Then IsChanged = True
                _beneficiaire = value
            End Set
        End Property


        Private _realisateur As EmployeEntity
        Public Property Realisateur As EmployeEntity
            Get
                If IsNothing(_realisateur) Then _realisateur = New EmployeEntity
                Return _realisateur
            End Get
            Set(value As EmployeEntity)
                If Not value.Equals(_realisateur) Then IsChanged = True
                _realisateur = value
            End Set
        End Property

        Private _programme As ProgrammeEntity
        Public Property Programme As ProgrammeEntity
            Get
                If IsNothing(_programme) Then _programme = New ProgrammeEntity
                Return _programme
            End Get
            Set(value As ProgrammeEntity)
                If Not value.Equals(_programme) Then IsChanged = True
                _programme = value
            End Set
        End Property
#End Region

    End Class

End Namespace