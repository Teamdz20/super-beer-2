Namespace Db.Entities
    Public Class UserEntity

        Sub New()

        End Sub

        Sub New(myRecord As IDataRecord)
            FillFromDataRecord(myRecord)
        End Sub

        Private _nom As String
        Public Property Nom As String
            Get
                Return _nom
            End Get
            Set(value As String)
                _nom = value
            End Set
        End Property

        Private _password As String = ""
        Public Property password As String
            Get
                Return _password
            End Get
            Set(value As String)
                _password = value
            End Set
        End Property

        Private _logged As Boolean = False
        Public Property IsLogged As Boolean
            Get
                Return _logged
            End Get
            Set(value As Boolean)
                _logged = value
            End Set
        End Property


        Private _emp_full_name As String = ""
        Public Property EmpFullName As String
            Get
                Return _emp_full_name
            End Get
            Set(value As String)
                _emp_full_name = value
            End Set
        End Property

        Public Sub FillFromDataRecord(myRecord As IDataRecord)
            id = myRecord("user_id")
            If Not myRecord("user_username") Is DBNull.Value Then username = myRecord("user_username")
        End Sub


#Region "Database Fields"
        Private _id As Integer = 0
        Public Property id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Private _username As String = ""
        Public Property username As String
            Get
                Return _username
            End Get
            Set(value As String)
                _username = value
            End Set
        End Property
#End Region

    End Class
End Namespace
