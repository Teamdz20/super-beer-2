#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 02/05/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Programmes object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _ProgrammesDAO
    Inherits LUNA.LunaBaseClassDAO(Of Programmes)

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
    '''Read from DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return a Programmes object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Programmes
        Dim cls As New Programmes

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Programmes WHERE id = " & Id
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
    '''Save on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Programmes) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Programmes ("
                            sql &= " nom,"
                            sql &= " code"
                            sql &= ") VALUES ("
                            sql &= " @nom,"
                            sql &= " @code"
                            sql &= ")"
                        Else
                            sql = "UPDATE Programmes SET "
                            sql &= "nom = @nom,"
                            sql &= "code = @code"
                            sql &= " WHERE id= " & cls.id
                        End If

                        Dim p As DbParameter = Nothing
                        p = myCommand.CreateParameter
                        p.ParameterName = "@nom"
                        p.Value = cls.nom
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@code"
                        p.Value = cls.code
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
                'Dim Sql As String = "UPDATE Programmes SET DELETED=True "
                Dim Sql As String = "DELETE FROM Programmes"
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
    '''Delete from DB table Programmes. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Programmes. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Programmes, Optional ByRef ListaObj As List(Of Programmes) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return first of Programmes
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Programmes
        Dim ris As Programmes = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Programmes) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return first of Programmes
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Programmes
        Dim ris As Programmes = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Programmes) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return a list of Programmes
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Programmes)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return a list of Programmes
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Programmes)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return a list of Programmes
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Programmes)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Programmes by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Programmes
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Programmes)
        Dim Ls As New List(Of Programmes)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Programmes
    ''' </summary>
    ''' <returns>
    '''Return a list of Programmes
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Programmes)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Programmes)
        Dim Ls As New List(Of Programmes)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Programmes"
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

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Programmes)
        Dim Ls As New List(Of Programmes)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Programmes"
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

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Programmes)
        Dim Ls As New List(Of Programmes)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Programmes() With {.id = 0, .nom = "", .code = ""})
                    While myReader.Read
                        Dim classe As New Programmes(CType(myReader, IDataRecord))
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
