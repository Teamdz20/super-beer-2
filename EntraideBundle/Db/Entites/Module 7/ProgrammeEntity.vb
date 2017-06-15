Namespace Db.Entities
    Public Class ProgrammeEntity
        Inherits EntraideOrm.Programmes

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("programme_id")
            If Not myRecord("programme_nom") Is DBNull.Value Then nom = myRecord("programme_nom")
            If Not myRecord("programme_code") Is DBNull.Value Then code = myRecord("programme_code")
        End Sub

    End Class

End Namespace