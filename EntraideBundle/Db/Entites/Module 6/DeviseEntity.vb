Namespace Db.Entities
    Public Class DeviseEntity
        Inherits EntraideOrm.Devises


        Public Sub New(ByVal nom As String)
            Me._nom = nom
        End Sub

        Public Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("devise_id")
            If Not myRecord("devise_nom") Is DBNull.Value Then nom = myRecord("devise_nom")
        End Sub

        Public Sub New(ByVal id As String, ByVal nom As String)
            Me._id = id
            Me._nom = nom
        End Sub

    End Class

End Namespace