Namespace Db.Entities
    Public Class TypeAgrEntity
        Inherits EntraideOrm.Type_agrs

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("type_agr_id")
            If Not myRecord("type_agr_nom") Is DBNull.Value Then nom = myRecord("type_agr_nom")
        End Sub

    End Class
End Namespace