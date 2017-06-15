#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 06/06/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Fournisseurs object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _FournisseursDAO
    Inherits LUNA.LunaBaseClassDAO(Of Fournisseurs)

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
    '''Read from DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return a Fournisseurs object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Fournisseurs
        Dim cls As New Fournisseurs

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Fournisseurs WHERE id = " & Id
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
    '''Save on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Fournisseurs) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Fournisseurs ("
                            sql &= " created,"
                            sql &= " nom,"
                            sql &= " nom_representant,"
                            sql &= " poste,"
                            sql &= " code,"
                            sql &= " adresse,"
                            sql &= " tel1,"
                            sql &= " tel2,"
                            sql &= " site,"
                            sql &= " email,"
                            sql &= " domaine_business,"
                            sql &= " produit,"
                            sql &= " classification_prix,"
                            sql &= " note,"
                            sql &= " categorie_fournisseur_id,"
                            sql &= " user_id"
                            sql &= ") VALUES ("
                            sql &= " @created,"
                            sql &= " @nom,"
                            sql &= " @nom_representant,"
                            sql &= " @poste,"
                            sql &= " @code,"
                            sql &= " @adresse,"
                            sql &= " @tel1,"
                            sql &= " @tel2,"
                            sql &= " @site,"
                            sql &= " @email,"
                            sql &= " @domaine_business,"
                            sql &= " @produit,"
                            sql &= " @classification_prix,"
                            sql &= " @note,"
                            sql &= " @categorie_fournisseur_id,"
                            sql &= " @user_id"
                            sql &= ")"
                        Else
                            sql = "UPDATE Fournisseurs SET "
                            sql &= "created = @created,"
                            sql &= "nom = @nom,"
                            sql &= "nom_representant = @nom_representant,"
                            sql &= "poste = @poste,"
                            sql &= "code = @code,"
                            sql &= "adresse = @adresse,"
                            sql &= "tel1 = @tel1,"
                            sql &= "tel2 = @tel2,"
                            sql &= "site = @site,"
                            sql &= "email = @email,"
                            sql &= "domaine_business = @domaine_business,"
                            sql &= "produit = @produit,"
                            sql &= "classification_prix = @classification_prix,"
                            sql &= "note = @note,"
                            sql &= "categorie_fournisseur_id = @categorie_fournisseur_id,"
                            sql &= "user_id = @user_id"
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
                        p.ParameterName = "@nom"
                        p.Value = cls.nom
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
                        p.ParameterName = "@code"
                        p.Value = cls.code
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@adresse"
                        p.Value = cls.adresse
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
                        p.ParameterName = "@site"
                        p.Value = cls.site
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@email"
                        p.Value = cls.email
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@domaine_business"
                        p.Value = cls.domaine_business
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@produit"
                        p.Value = cls.produit
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@classification_prix"
                        p.Value = cls.classification_prix
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@note"
                        p.Value = cls.note
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@categorie_fournisseur_id"
                        p.Value = cls.categorie_fournisseur_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@user_id"
                        p.Value = cls.user_id
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
                'Dim Sql As String = "UPDATE Fournisseurs SET DELETED=True "
                Dim Sql As String = "DELETE FROM Fournisseurs"
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
    '''Delete from DB table Fournisseurs. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Fournisseurs. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Fournisseurs, Optional ByRef ListaObj As List(Of Fournisseurs) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return first of Fournisseurs
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Fournisseurs
        Dim ris As Fournisseurs = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Fournisseurs) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return first of Fournisseurs
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Fournisseurs
        Dim ris As Fournisseurs = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Fournisseurs) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Fournisseurs
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Fournisseurs)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Fournisseurs
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Fournisseurs)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Fournisseurs
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Fournisseurs)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Fournisseurs by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Fournisseurs
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Fournisseurs)
        Dim Ls As New List(Of Fournisseurs)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Fournisseurs
    ''' </summary>
    ''' <returns>
    '''Return a list of Fournisseurs
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Fournisseurs)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Fournisseurs)
        Dim Ls As New List(Of Fournisseurs)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Fournisseurs"
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

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Fournisseurs)
        Dim Ls As New List(Of Fournisseurs)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Fournisseurs"
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

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Fournisseurs)
        Dim Ls As New List(Of Fournisseurs)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Fournisseurs() With {.id = 0, .created = Nothing, .nom = "", .nom_representant = "", .poste = "", .code = "", .adresse = "", .tel1 = "", .tel2 = "", .site = "", .email = "", .domaine_business = "", .produit = "", .classification_prix = "", .note = "", .categorie_fournisseur_id = 0, .user_id = 0})
                    While myReader.Read
                        Dim classe As New Fournisseurs(CType(myReader, IDataRecord))
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
