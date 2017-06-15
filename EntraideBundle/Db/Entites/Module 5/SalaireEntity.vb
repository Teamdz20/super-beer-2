Namespace Db.Entities
    Public Class SalaireEntity
        Inherits EntraideOrm.Salaires

        Public Sub New()

        End Sub

        Public Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("salaire_id")
            term_paiement = myRecord("salaire_term_paiement")
            taux = myRecord("salaire_taux")
            If Not myRecord("salaire_nb_jour_travail") Is DBNull.Value Then nb_jour_travail = myRecord("salaire_nb_jour_travail")
            If Not myRecord("salaire_salaire") Is DBNull.Value Then salaire = myRecord("salaire_salaire")

        End Sub

    End Class

End Namespace


