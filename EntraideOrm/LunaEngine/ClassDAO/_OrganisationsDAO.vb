#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 11/04/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Organisations object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _OrganisationsDAO
    Inherits LUNA.LunaBaseClassDAO(Of Organisations)

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
    '''Read from DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return a Organisations object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Organisations
        Dim cls As New Organisations

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Organisations WHERE id = " & Id
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
    '''Save on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Organisations) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Organisations ("
                            sql &= " entete,"
                            sql &= " mission,"
                            sql &= " vision,"
                            sql &= " valeur,"
                            sql &= " organigramme,"
                            sql &= " histoire,"
                            sql &= " branche"
                            sql &= ") VALUES ("
                            sql &= " @entete,"
                            sql &= " @mission,"
                            sql &= " @vision,"
                            sql &= " @valeur,"
                            sql &= " @organigramme,"
                            sql &= " @histoire,"
                            sql &= " @branche"
                            sql &= ")"
                        Else
                            sql = "UPDATE Organisations SET "
                            sql &= "entete = @entete,"
                            sql &= "mission = @mission,"
                            sql &= "vision = @vision,"
                            sql &= "valeur = @valeur,"
                            sql &= "organigramme = @organigramme,"
                            sql &= "histoire = @histoire,"
                            sql &= "branche = @branche"
                            sql &= " WHERE id= " & cls.id
                        End If

                        Dim p As DbParameter = Nothing
                        p = myCommand.CreateParameter
                        p.ParameterName = "@entete"
                        p.Value = cls.entete
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@mission"
                        p.Value = cls.mission
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@vision"
                        p.Value = cls.vision
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@valeur"
                        p.Value = cls.valeur
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@organigramme"
                        p.Value = cls.organigramme
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@histoire"
                        p.Value = cls.histoire
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@branche"
                        p.Value = cls.branche
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
                'Dim Sql As String = "UPDATE Organisations SET DELETED=True "
                Dim Sql As String = "DELETE FROM Organisations"
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
    '''Delete from DB table Organisations. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Organisations. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Organisations, Optional ByRef ListaObj As List(Of Organisations) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return first of Organisations
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Organisations
        Dim ris As Organisations = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Organisations) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return first of Organisations
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Organisations
        Dim ris As Organisations = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Organisations) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return a list of Organisations
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Organisations)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return a list of Organisations
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Organisations)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return a list of Organisations
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Organisations)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Organisations by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Organisations
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Organisations)
        Dim Ls As New List(Of Organisations)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Organisations
    ''' </summary>
    ''' <returns>
    '''Return a list of Organisations
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Organisations)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Organisations)
        Dim Ls As New List(Of Organisations)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Organisations"
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

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Organisations)
        Dim Ls As New List(Of Organisations)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Organisations"
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

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Organisations)
        Dim Ls As New List(Of Organisations)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Organisations() With {.id = 0, .entete = Nothing, .mission = Nothing, .vision = Nothing, .valeur = Nothing, .organigramme = Nothing, .histoire = Nothing, .branche = Nothing})
                    While myReader.Read
                        Dim classe As New Organisations(CType(myReader, IDataRecord))
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
