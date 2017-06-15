#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 05/06/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Donneurs object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _DonneursDAO
    Inherits LUNA.LunaBaseClassDAO(Of Donneurs)

    ''' <summary>
    '''New() create an istance of this class. Use default DB Connection
    ''' </summary>
    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    '''New() create an istance of this class and specify an OPENED DB connection
    ''' </summary>
    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    ''' <summary>
    '''Read from DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return a Donneurs object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Donneurs
        Dim cls As New Donneurs

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Donneurs WHERE id = " & Id
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader

                    myReader.Read()
                    If myReader.HasRows Then
                        cls.FillFromDataRecord(CType(myReader, IDataRecord))
                    End If
                    myReader.Close()
                End Using
            End Using
        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function

    ''' <summary>
    '''Save on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Donneurs) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Donneurs ("
                            sql &= " date,"
                            sql &= " nom,"
                            sql &= " code,"
                            sql &= " adresse,"
                            sql &= " email,"
                            sql &= " tel1,"
                            sql &= " tel2,"
                            sql &= " categorie_donneur_id,"
                            sql &= " site_internet,"
                            sql &= " restriction,"
                            sql &= " periode_sollicitation,"
                            sql &= " note_sollicitation,"
                            sql &= " nom_representant,"
                            sql &= " poste,"
                            sql &= " user_id,"
                            sql &= " type_don"
                            sql &= ") VALUES ("
                            sql &= " @date,"
                            sql &= " @nom,"
                            sql &= " @code,"
                            sql &= " @adresse,"
                            sql &= " @email,"
                            sql &= " @tel1,"
                            sql &= " @tel2,"
                            sql &= " @categorie_donneur_id,"
                            sql &= " @site_internet,"
                            sql &= " @restriction,"
                            sql &= " @periode_sollicitation,"
                            sql &= " @note_sollicitation,"
                            sql &= " @nom_representant,"
                            sql &= " @poste,"
                            sql &= " @user_id,"
                            sql &= " @type_don"
                            sql &= ")"
                        Else
                            sql = "UPDATE Donneurs SET "
                            sql &= "date = @date,"
                            sql &= "nom = @nom,"
                            sql &= "code = @code,"
                            sql &= "adresse = @adresse,"
                            sql &= "email = @email,"
                            sql &= "tel1 = @tel1,"
                            sql &= "tel2 = @tel2,"
                            sql &= "categorie_donneur_id = @categorie_donneur_id,"
                            sql &= "site_internet = @site_internet,"
                            sql &= "restriction = @restriction,"
                            sql &= "periode_sollicitation = @periode_sollicitation,"
                            sql &= "note_sollicitation = @note_sollicitation,"
                            sql &= "nom_representant = @nom_representant,"
                            sql &= "poste = @poste,"
                            sql &= "user_id = @user_id,"
                            sql &= "type_don = @type_don"
                            sql &= " WHERE id= " & cls.id
                        End If

                        Dim p As DbParameter = Nothing
                        p = myCommand.CreateParameter
                        p.ParameterName = "@date"
                        p.DbType = DbType.DateTime
                        If cls.date_donneur <> Date.MinValue Then
                            p.Value = cls.date_donneur
                        Else
                            p.Value = DBNull.Value
                        End If
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@nom"
                        p.Value = cls.nom
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@code"
                        p.Value = cls.code
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@adresse"
                        p.Value = cls.adresse
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@email"
                        p.Value = cls.email
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@tel1"
                        p.Value = cls.tel1
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@tel2"
                        p.Value = cls.tel2
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@categorie_donneur_id"
                        p.Value = cls.categorie_donneur_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@site_internet"
                        p.Value = cls.site_internet
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@restriction"
                        p.Value = cls.restriction
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@periode_sollicitation"
                        p.Value = cls.periode_sollicitation
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@note_sollicitation"
                        p.Value = cls.note_sollicitation
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@nom_representant"
                        p.Value = cls.nom_representant
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@poste"
                        p.Value = cls.poste
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@user_id"
                        p.Value = cls.user_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@type_don"
                        p.Value = cls.type_don
                        myCommand.Parameters.Add(p)

                        myCommand.CommandType = CommandType.Text
                        myCommand.CommandText = sql
                        myCommand.ExecuteNonQuery()


                        If cls.id = 0 Then
                            Dim IdInserito As Integer = 0
                            Sql = "select @@identity"
                            myCommand.CommandText = Sql
                            Idinserito = myCommand.ExecuteScalar()
                            cls.id = Idinserito
                            Ris = Idinserito
                        Else
                            Ris = cls.id
                        End If


                    Catch ex As Exception
                        ManageError(ex)
                    End Try
                End Using
            Else
                Ris = cls.id
            End If

        Else
            Throw New ApplicationException("Object data is not valid")
        End If
        Return Ris
    End Function

    Private Sub DestroyPermanently(Id As Integer)
        Try

            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.Connection = _cn

                '******IMPORTANT: You can use this commented instruction to make a logical delete .
                '******Replace DELETED Field with your logic deleted field name.
                'Dim Sql As String = "UPDATE Donneurs SET DELETED=True "
                Dim Sql As String = "DELETE FROM Donneurs"
                Sql &= " WHERE id = " & Id

                myCommand.CommandText = Sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                myCommand.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    ''' <summary>
    '''Delete from DB table Donneurs. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Donneurs. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Donneurs, Optional ByRef ListaObj As List(Of Donneurs) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return first of Donneurs
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Donneurs
        Dim ris As Donneurs = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Donneurs) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return first of Donneurs
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Donneurs
        Dim ris As Donneurs = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Donneurs) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Donneurs
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Donneurs)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Donneurs
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Donneurs)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Donneurs
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Donneurs)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Donneurs by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Donneurs
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Donneurs)
        Dim Ls As New List(Of Donneurs)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Donneurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Donneurs
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Donneurs)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Donneurs)
        Dim Ls As New List(Of Donneurs)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Donneurs"
            For Each Par As LUNA.LunaSearchParameter In Parameter
                If Not Par Is Nothing Then
                    If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &= " " & Par.LogicOperatorStr & " "
                    sql &= Par.FieldName & " " & Par.SqlOperator
                    If Par.SqlOperator.ToUpper.IndexOf("IN") <> -1 Then
                        sql &= " " & ApIn(Par.Value)
                    Else
                        sql &= " " & Ap(Par.Value)
                    End If
                End If
            Next

            If SearchOption.OrderBy.Length Then Sql &= " ORDER BY " & SearchOption.OrderBy

            If SearchOption.Top Then sql &= " LIMIT " & SearchOption.Top

            Ls = GetData(sql, SearchOption.AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Donneurs)
        Dim Ls As New List(Of Donneurs)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Donneurs"
            If OrderByField.Length Then
                Sql &= " ORDER BY " & OrderByField
            End If

            Ls = GetData(Sql, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Protected Overridable Property EmptyItemDescription As String = "Selezionare una voce"

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Donneurs)
        Dim Ls As New List(Of Donneurs)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Donneurs() With {.id = 0, .date_donneur = Nothing, .nom = "", .code = "", .adresse = "", .email = "", .tel1 = "", .tel2 = "", .categorie_donneur_id = 0, .site_internet = "", .restriction = "", .periode_sollicitation = "", .note_sollicitation = "", .nom_representant = "", .poste = "", .user_id = 0, .type_don = ""})
                    While myReader.Read
                        Dim classe As New Donneurs(CType(myReader, IDataRecord))
                        Ls.Add(classe)
                    End While
                    myReader.Close()
                End Using
            End Using

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
End Class
