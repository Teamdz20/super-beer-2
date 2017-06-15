Namespace Db.Entities
    Public Class DepartementEntity
        Inherits EntraideOrm.Departements


        Public Sub New()

        End Sub

        Public Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("departement_id")
            If Not myRecord("departement_nom") Is DBNull.Value Then nom = myRecord("departement_nom")

        End Sub

    End Class

End Namespace