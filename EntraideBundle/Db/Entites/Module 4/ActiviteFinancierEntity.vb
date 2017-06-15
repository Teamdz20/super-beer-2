Namespace Db.Entities
    Public Class ActiviteFinancierEntity
        Inherits EntraideOrm.Activite_financiers


        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("activite_financier_id")
            If Not myRecord("activite_financier_nom") Is DBNull.Value Then nom = myRecord("activite_financier_nom")
            If Not myRecord("activite_financier_code") Is DBNull.Value Then code = myRecord("activite_financier_code")
        End Sub

    End Class
End Namespace