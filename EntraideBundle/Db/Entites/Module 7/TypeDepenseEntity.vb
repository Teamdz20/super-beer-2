Namespace Db.Entities
    Public Class TypeDepenseEntity
        Inherits EntraideOrm.Type_depenses

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("type_depense_id")
            If Not myRecord("type_depense_nom") Is DBNull.Value Then nom = myRecord("type_depense_nom")
        End Sub

    End Class
End Namespace