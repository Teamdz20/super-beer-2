#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 26/04/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Depenses object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _DepensesDAO
    Inherits LUNA.LunaBaseClassDAO(Of Depenses)

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
    '''Read from DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return a Depenses object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Depenses
        Dim cls As New Depenses

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Depenses WHERE id = " & Id
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
    '''Save on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Depenses) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Depenses ("
                            sql &= " created,"
                            sql &= " ref_id,"
                            sql &= " type_depense_id,"
                            sql &= " departement_id,"
                            sql &= " code_depense_id,"
                            sql &= " manager_id,"
                            sql &= " montant,"
                            sql &= " devise_id,"
                            sql &= " beneficiere_id,"
                            sql &= " motif_depense,"
                            sql &= " realiser_par,"
                            sql &= " code_demande,"
                            sql &= " memo,"
                            sql &= " activite,"
                            sql &= " programme_id"
                            sql &= ") VALUES ("
                            sql &= " @created,"
                            sql &= " @ref_id,"
                            sql &= " @type_depense_id,"
                            sql &= " @departement_id,"
                            sql &= " @code_depense_id,"
                            sql &= " @manager_id,"
                            sql &= " @montant,"
                            sql &= " @devise_id,"
                            sql &= " @beneficiere_id,"
                            sql &= " @motif_depense,"
                            sql &= " @realiser_par,"
                            sql &= " @code_demande,"
                            sql &= " @memo,"
                            sql &= " @activite,"
                            sql &= " @programme_id"
                            sql &= ")"
                        Else
                            sql = "UPDATE Depenses SET "
                            sql &= "created = @created,"
                            sql &= "ref_id = @ref_id,"
                            sql &= "type_depense_id = @type_depense_id,"
                            sql &= "departement_id = @departement_id,"
                            sql &= "code_depense_id = @code_depense_id,"
                            sql &= "manager_id = @manager_id,"
                            sql &= "montant = @montant,"
                            sql &= "devise_id = @devise_id,"
                            sql &= "beneficiere_id = @beneficiere_id,"
                            sql &= "motif_depense = @motif_depense,"
                            sql &= "realiser_par = @realiser_par,"
                            sql &= "code_demande = @code_demande,"
                            sql &= "memo = @memo,"
                            sql &= "activite = @activite,"
                            sql &= "programme_id = @programme_id"
                            sql &= " WHERE id= " & cls.id
                        End If

                        Dim p As DbParameter = Nothing
                        p = myCommand.CreateParameter
                        p.ParameterName = "@created"
                        p.DbType = DbType.DateTime
                        If cls.created <> Date.MinValue Then
                            p.Value = cls.created
                        Else
                            p.Value = DBNull.Value
                        End If
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@ref_id"
                        p.Value = cls.ref_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@type_depense_id"
                        p.Value = cls.type_depense_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@departement_id"
                        p.Value = cls.departement_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@code_depense_id"
                        p.Value = cls.code_depense_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@manager_id"
                        p.Value = cls.manager_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@montant"
                        p.Value = cls.montant
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@devise_id"
                        p.Value = cls.devise_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@beneficiere_id"
                        p.Value = cls.beneficiere_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@motif_depense"
                        p.Value = cls.motif_depense
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@realiser_par"
                        p.Value = cls.realiser_par
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@code_demande"
                        p.Value = cls.code_demande
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@memo"
                        p.Value = cls.memo
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@activite"
                        p.Value = cls.activite
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@programme_id"
                        p.Value = cls.programme_id
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
                'Dim Sql As String = "UPDATE Depenses SET DELETED=True "
                Dim Sql As String = "DELETE FROM Depenses"
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
    '''Delete from DB table Depenses. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Depenses. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Depenses, Optional ByRef ListaObj As List(Of Depenses) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return first of Depenses
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Depenses
        Dim ris As Depenses = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Depenses) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return first of Depenses
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Depenses
        Dim ris As Depenses = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Depenses) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return a list of Depenses
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Depenses)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return a list of Depenses
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Depenses)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return a list of Depenses
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Depenses)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Depenses by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Depenses
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Depenses)
        Dim Ls As New List(Of Depenses)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Depenses
    ''' </summary>
    ''' <returns>
    '''Return a list of Depenses
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Depenses)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Depenses)
        Dim Ls As New List(Of Depenses)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Depenses"
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

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Depenses)
        Dim Ls As New List(Of Depenses)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Depenses"
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

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Depenses)
        Dim Ls As New List(Of Depenses)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Depenses() With {.id = 0, .created = Nothing, .ref_id = 0, .type_depense_id = 0, .departement_id = 0, .code_depense_id = 0, .manager_id = 0, .montant = 0, .devise_id = 0, .beneficiere_id = 0, .motif_depense = "", .realiser_par = 0, .code_demande = "", .memo = "", .activite = "", .programme_id = 0})
                    While myReader.Read
                        Dim classe As New Depenses(CType(myReader, IDataRecord))
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
