Namespace Db.Entities
    Public Class EmployeEntity
        Inherits EntraideOrm.Employes

        Public Sub New()

        End Sub

        Public Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)

            Departement = New DepartementEntity(myRecord)
            Salaire = New SalaireEntity(myRecord)
            Contrat = New ContratEntity(myRecord)
            Poste = New PosteEntity(myRecord)
        End Sub

        ''' <summary>
        ''' Create or Update the current record
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overrides Function Save() As Integer
            Using trans As EntraideOrm.LUNA.LunaTransactionBox = EntraideOrm.LUNA.LunaContext.CreateTransactionBox

                Try
                    trans.TransactionBegin()

                    Dim id As Integer = MyBase.Save()
                    Dim salaire_id = Me.Salaire.Save()

                    Me.Contrat.employe_id = id
                    Me.Contrat.salaire_id = salaire_id

                    Dim contrat_id = Me.Contrat.Save()

                    Dim valideCommit = (id > 0 AndAlso salaire_id > 0 And contrat_id > 0)

                    If valideCommit Then
                        trans.TransactionCommit()
                    End If

                Catch ex As Exception
                    trans.TransactionRollBack()
                    Util.ShowMessage(ex.ToString, 2)
                End Try

            End Using

            Return id
        End Function


        ''' <summary>
        ''' Fill entity from IDataRecord
        ''' </summary>
        ''' <param name="myRecord"></param>
        ''' <remarks></remarks>
        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("emp_id")
            If Not myRecord("emp_code") Is DBNull.Value Then code = myRecord("emp_code")
            nom = myRecord("emp_nom")
            prenom = myRecord("emp_prenom")
            sexe = myRecord("emp_sexe")
            situation_matrimonial = myRecord("emp_situation_matrimonial")
            nb_enfant = myRecord("emp_nb_enfant")
            date_naissance = myRecord("emp_date_naissance")
            lieu_naissance = myRecord("emp_lieu_naissance")
            nationnalite = myRecord("emp_nationnalite")
            If Not myRecord("emp_bp") Is DBNull.Value Then bp = myRecord("emp_bp")
            tel1 = myRecord("emp_tel1")
            If Not myRecord("emp_tel2") Is DBNull.Value Then tel2 = myRecord("emp_tel2")
            If Not myRecord("emp_email") Is DBNull.Value Then email = myRecord("emp_email")
            If Not myRecord("emp_religion") Is DBNull.Value Then religion = myRecord("emp_religion")
            If Not myRecord("emp_precision_autre") Is DBNull.Value Then precision_autre = myRecord("emp_precision_autre")
            If Not myRecord("emp_delis") Is DBNull.Value Then delis = myRecord("emp_delis")
            If Not myRecord("emp_detail_delis") Is DBNull.Value Then detail_delis = myRecord("emp_detail_delis")
            If Not myRecord("emp_recu_formation") Is DBNull.Value Then recu_formation = myRecord("emp_recu_formation")
            If Not myRecord("emp_type_formation_recu") Is DBNull.Value Then type_formation_recu = myRecord("emp_type_formation_recu")
            If Not myRecord("emp_niveau_etude") Is DBNull.Value Then niveau_etude = myRecord("emp_niveau_etude")
            If Not myRecord("emp_diplome") Is DBNull.Value Then diplome = myRecord("emp_diplome")
            If Not myRecord("emp_ecole") Is DBNull.Value Then ecole = myRecord("emp_ecole")
            nom_contact_urgent = myRecord("emp_nom_contact_urgent")
            adresse_contact_urgent = myRecord("emp_adresse_contact_urgent")
            phone_contact_urgent = myRecord("emp_phone_contact_urgent")
            If Not myRecord("emp_email_contact_urgent") Is DBNull.Value Then email_contact_urgent = myRecord("emp_email_contact_urgent")
            If Not myRecord("emp_competance_fr") Is DBNull.Value Then competance_fr = myRecord("emp_competance_fr")
            If Not myRecord("emp_competance_en") Is DBNull.Value Then competance_en = myRecord("emp_competance_en")
            If Not myRecord("emp_competance_information") Is DBNull.Value Then competance_information = myRecord("emp_competance_information")
            If Not myRecord("emp_autres_competances") Is DBNull.Value Then autres_competances = myRecord("emp_autres_competances")
            If Not myRecord("emp_note_exp_professionnelle") Is DBNull.Value Then note_exp_professionnelle = myRecord("emp_note_exp_professionnelle")
            If Not myRecord("emp_departement_id") Is DBNull.Value Then departement_id = myRecord("emp_departement_id")
            If Not myRecord("emp_poste_id") Is DBNull.Value Then poste_id = myRecord("emp_poste_id")
            If Not myRecord("emp_debut_contract") Is DBNull.Value Then debut_contract = myRecord("emp_debut_contract")
            If Not myRecord("emp_fin_contract") Is DBNull.Value Then fin_contract = myRecord("emp_fin_contract")
            If Not myRecord("emp_date_enregistrement") Is DBNull.Value Then date_enregistrement = myRecord("emp_date_enregistrement")
            If Not myRecord("emp_adresse") Is DBNull.Value Then adresse = myRecord("emp_adresse")

        End Sub


#Region "RelationProperties"

        Private _Departement As DepartementEntity = New DepartementEntity
        Public Overridable Property Departement As DepartementEntity
            Get
                Return _Departement
            End Get
            Set(value As DepartementEntity)
                If Not value.Equals(_Departement) Then
                    IsChanged = True
                    _Departement = value
                End If
            End Set
        End Property

        Private _Salaire As SalaireEntity = New SalaireEntity
        Public Overridable Property Salaire As SalaireEntity
            Get
                Return _Salaire
            End Get
            Set(value As SalaireEntity)
                If Not value.Equals(_Salaire) Then
                    IsChanged = True
                    _Salaire = value
                End If
            End Set
        End Property


        Private _Poste As PosteEntity = New PosteEntity
        Public Overridable Property Poste As PosteEntity
            Get
                Return _Poste
            End Get
            Set(value As PosteEntity)
                If Not value.Equals(_Poste) Then
                    IsChanged = True
                    _Poste = value
                End If
            End Set
        End Property

        Private _Contrat As ContratEntity = New ContratEntity
        Public Overridable Property Contrat As ContratEntity
            Get
                Return _Contrat
            End Get
            Set(value As ContratEntity)
                If Not value.Equals(_Contrat) Then
                    IsChanged = True
                    _Contrat = value
                End If
            End Set
        End Property

#End Region


#Region "Logic Field"

        Public Function IsClass(ByVal classification As String) As Boolean
            Return Me.Contrat.classification.Equals(classification, StringComparison.CurrentCultureIgnoreCase)
        End Function

        Public Function FullName() As String
            Return Me.nom & " " & Me.prenom
        End Function

#End Region



    End Class


End Namespace