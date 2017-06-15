Namespace Db.Entities
    Public Class DonneurEntity
        Inherits EntraideOrm.Donneurs

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)

            Try
                _categorie_donneur = New CategorieDonneurEntity
                _categorie_donneur.Id = myRecord("categorie_donneur_id")
                If myRecord("categorie_donneur_nom") IsNot DBNull.Value Then _categorie_donneur.Nom = myRecord("categorie_donneur_nom")
            Catch ex As Exception

            End Try

        End Sub

        ''' <summary>
        ''' Filling Data from Record
        ''' </summary>
        ''' <param name="myRecord"></param>
        ''' <remarks></remarks>
        Public Overrides Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("donneur_id")
            If Not myRecord("donneur_date") Is DBNull.Value Then date_donneur = myRecord("donneur_date")
            If Not myRecord("donneur_nom") Is DBNull.Value Then nom = myRecord("donneur_nom")
            If Not myRecord("donneur_code") Is DBNull.Value Then code = myRecord("donneur_code")
            If Not myRecord("donneur_adresse") Is DBNull.Value Then adresse = myRecord("donneur_adresse")
            If Not myRecord("donneur_email") Is DBNull.Value Then email = myRecord("donneur_email")
            If Not myRecord("donneur_tel1") Is DBNull.Value Then tel1 = myRecord("donneur_tel1")
            If Not myRecord("donneur_tel2") Is DBNull.Value Then tel2 = myRecord("donneur_tel2")
            If Not myRecord("donneur_categorie_donneur_id") Is DBNull.Value Then categorie_donneur_id = myRecord("donneur_categorie_donneur_id")
            If Not myRecord("donneur_site_internet") Is DBNull.Value Then site_internet = myRecord("donneur_site_internet")
            If Not myRecord("donneur_restriction") Is DBNull.Value Then restriction = myRecord("donneur_restriction")
            If Not myRecord("donneur_periode_sollicitation") Is DBNull.Value Then periode_sollicitation = myRecord("donneur_periode_sollicitation")
            If Not myRecord("donneur_note_sollicitation") Is DBNull.Value Then note_sollicitation = myRecord("donneur_note_sollicitation")
            If Not myRecord("donneur_nom_representant") Is DBNull.Value Then nom_representant = myRecord("donneur_nom_representant")
            If Not myRecord("donneur_poste") Is DBNull.Value Then poste = myRecord("donneur_poste")
            If Not myRecord("donneur_user_id") Is DBNull.Value Then user_id = myRecord("donneur_user_id")
            If Not myRecord("donneur_type_don") Is DBNull.Value Then type_don = myRecord("donneur_type_don")
        End Sub

#Region "Virtual fields"
        Public _categorie_donneur As CategorieDonneurEntity
        Public Property CategorieDonneur As CategorieDonneurEntity
            Get
                Return _categorie_donneur
            End Get
            Set(value As CategorieDonneurEntity)
                _categorie_donneur = value
            End Set
        End Property
#End Region

    End Class

End Namespace