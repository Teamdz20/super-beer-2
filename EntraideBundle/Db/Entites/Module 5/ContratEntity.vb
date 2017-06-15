Namespace Db.Entities

    Public Class ContratEntity
        Inherits EntraideOrm.Contrats



        Public Sub New()

        End Sub

        Public Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub


        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("contrat_id")
            employe_id = myRecord("contrat_employe_id")
            departement_id = myRecord("contrat_departement_id")
            If Not myRecord("contrat_salaire_id") Is DBNull.Value Then salaire_id = myRecord("contrat_salaire_id")
            poste_id = myRecord("contrat_poste_id")
            'duree = myRecord("contrat_duree")
            date_debut = myRecord("contrat_date_debut")
            date_fin = myRecord("contrat_date_fin")
            If Not myRecord("contrat_nb_heure_travail") Is DBNull.Value Then nb_heure_travail = myRecord("contrat_nb_heure_travail")
            If Not myRecord("contrat_classification") Is DBNull.Value Then classification = myRecord("contrat_classification")
            If Not myRecord("contrat_superviseur") Is DBNull.Value Then superviseur = myRecord("contrat_superviseur")

        End Sub

    End Class

End Namespace
