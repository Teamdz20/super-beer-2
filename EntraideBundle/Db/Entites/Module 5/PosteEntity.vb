Namespace Db.Entities
    Public Class PosteEntity
        Inherits EntraideOrm.Postes


        Public Sub New()

        End Sub

        Public Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("poste_id")
            If Not myRecord("poste_nom") Is DBNull.Value Then nom = myRecord("poste_nom")
            'If Not myRecord("responsable_id") Is DBNull.Value Then responsable_id = myRecord("responsable_id")
        End Sub
    End Class

End Namespace