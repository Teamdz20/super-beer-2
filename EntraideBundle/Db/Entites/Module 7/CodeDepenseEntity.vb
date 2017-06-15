Namespace Db.Entities
    Public Class CodeDepenseEntity
        Inherits EntraideOrm.Code_depenses


        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        ''' <summary>
        ''' Filling Data from record
        ''' </summary>
        ''' <param name="myRecord"></param>
        ''' <remarks></remarks>
        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("code_depense_id")
            If Not myRecord("code_depense_nom") Is DBNull.Value Then nom = myRecord("code_depense_nom")
            If Not myRecord("code_depense_code") Is DBNull.Value Then code = myRecord("code_depense_code")

        End Sub

    End Class

End Namespace