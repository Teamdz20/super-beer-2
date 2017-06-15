Namespace Db.Entities
    Public Class TypeMaterielEntity
        Inherits EntraideOrm.Type_materiels

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("type_materiel_id")
            If Not myRecord("type_materiel_nom") Is DBNull.Value Then nom = myRecord("type_materiel_nom")
        End Sub

    End Class

End Namespace