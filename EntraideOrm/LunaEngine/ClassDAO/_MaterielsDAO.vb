#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 25/04/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Materiels object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _MaterielsDAO
    Inherits LUNA.LunaBaseClassDAO(Of Materiels)

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
    '''Read from DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return a Materiels object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Materiels
        Dim cls As New Materiels

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Materiels WHERE id = " & Id
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
    '''Save on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Materiels) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Materiels ("
                            sql &= " libelle,"
                            sql &= " type_materiel_id,"
                            sql &= " code,"
                            sql &= " marque,"
                            sql &= " description,"
                            sql &= " num_facture,"
                            sql &= " prix_achat,"
                            sql &= " mode_obtention,"
                            sql &= " ref_obtention_id,"
                            sql &= " departement_id,"
                            sql &= " activite_id,"
                            sql &= " employe_id,"
                            sql &= " amortissement_necessaire,"
                            sql &= " annee_amortissement,"
                            sql &= " montant_par_an,"
                            sql &= " created,"
                            sql &= " neuf,"
                            sql &= " deja_utiliser,"
                            sql &= " tres_bon_etat,"
                            sql &= " avec_defaut,"
                            sql &= " mauvaise_etat,"
                            sql &= " note_etat,"
                            sql &= " activite"
                            sql &= ") VALUES ("
                            sql &= " @libelle,"
                            sql &= " @type_materiel_id,"
                            sql &= " @code,"
                            sql &= " @marque,"
                            sql &= " @description,"
                            sql &= " @num_facture,"
                            sql &= " @prix_achat,"
                            sql &= " @mode_obtention,"
                            sql &= " @ref_obtention_id,"
                            sql &= " @departement_id,"
                            sql &= " @activite_id,"
                            sql &= " @employe_id,"
                            sql &= " @amortissement_necessaire,"
                            sql &= " @annee_amortissement,"
                            sql &= " @montant_par_an,"
                            sql &= " @created,"
                            sql &= " @neuf,"
                            sql &= " @deja_utiliser,"
                            sql &= " @tres_bon_etat,"
                            sql &= " @avec_defaut,"
                            sql &= " @mauvaise_etat,"
                            sql &= " @note_etat,"
                            sql &= " @activite"
                            sql &= ")"
                        Else
                            sql = "UPDATE Materiels SET "
                            sql &= "libelle = @libelle,"
                            sql &= "type_materiel_id = @type_materiel_id,"
                            sql &= "code = @code,"
                            sql &= "marque = @marque,"
                            sql &= "description = @description,"
                            sql &= "num_facture = @num_facture,"
                            sql &= "prix_achat = @prix_achat,"
                            sql &= "mode_obtention = @mode_obtention,"
                            sql &= "ref_obtention_id = @ref_obtention_id,"
                            sql &= "departement_id = @departement_id,"
                            sql &= "activite_id = @activite_id,"
                            sql &= "employe_id = @employe_id,"
                            sql &= "amortissement_necessaire = @amortissement_necessaire,"
                            sql &= "annee_amortissement = @annee_amortissement,"
                            sql &= "montant_par_an = @montant_par_an,"
                            sql &= "created = @created,"
                            sql &= "neuf = @neuf,"
                            sql &= "deja_utiliser = @deja_utiliser,"
                            sql &= "tres_bon_etat = @tres_bon_etat,"
                            sql &= "avec_defaut = @avec_defaut,"
                            sql &= "mauvaise_etat = @mauvaise_etat,"
                            sql &= "note_etat = @note_etat,"
                            sql &= "activite = @activite"
                            sql &= " WHERE id= " & cls.id
                        End If

                        Dim p As DbParameter = Nothing
                        p = myCommand.CreateParameter
                        p.ParameterName = "@libelle"
                        p.Value = cls.libelle
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@type_materiel_id"
                        p.Value = cls.type_materiel_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@code"
                        p.Value = cls.code
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@marque"
                        p.Value = cls.marque
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@description"
                        p.Value = cls.description
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@num_facture"
                        p.Value = cls.num_facture
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@prix_achat"
                        p.Value = cls.prix_achat
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@mode_obtention"
                        p.Value = cls.mode_obtention
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@ref_obtention_id"
                        p.Value = cls.ref_obtention_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@departement_id"
                        p.Value = cls.departement_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@activite_id"
                        p.Value = cls.activite_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@employe_id"
                        p.Value = cls.employe_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@amortissement_necessaire"
                        p.Value = cls.amortissement_necessaire
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@annee_amortissement"
                        p.Value = cls.annee_amortissement
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@montant_par_an"
                        p.Value = cls.montant_par_an
                        myCommand.Parameters.Add(p)

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
                        p.ParameterName = "@neuf"
                        p.Value = cls.neuf
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@deja_utiliser"
                        p.Value = cls.deja_utiliser
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@tres_bon_etat"
                        p.Value = cls.tres_bon_etat
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@avec_defaut"
                        p.Value = cls.avec_defaut
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@mauvaise_etat"
                        p.Value = cls.mauvaise_etat
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@note_etat"
                        p.Value = cls.note_etat
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@activite"
                        p.Value = cls.activite
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
                'Dim Sql As String = "UPDATE Materiels SET DELETED=True "
                Dim Sql As String = "DELETE FROM Materiels"
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
    '''Delete from DB table Materiels. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Materiels. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Materiels, Optional ByRef ListaObj As List(Of Materiels) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return first of Materiels
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Materiels
        Dim ris As Materiels = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Materiels) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return first of Materiels
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Materiels
        Dim ris As Materiels = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Materiels) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return a list of Materiels
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Materiels)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return a list of Materiels
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Materiels)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return a list of Materiels
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Materiels)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Materiels by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Materiels
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Materiels)
        Dim Ls As New List(Of Materiels)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Materiels
    ''' </summary>
    ''' <returns>
    '''Return a list of Materiels
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Materiels)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Materiels)
        Dim Ls As New List(Of Materiels)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Materiels"
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

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Materiels)
        Dim Ls As New List(Of Materiels)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Materiels"
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

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Materiels)
        Dim Ls As New List(Of Materiels)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Materiels() With {.id = 0, .libelle = "", .type_materiel_id = 0, .code = "", .marque = "", .description = "", .num_facture = "", .prix_achat = 0, .mode_obtention = "", .ref_obtention_id = 0, .departement_id = 0, .activite_id = 0, .employe_id = 0, .amortissement_necessaire = "", .annee_amortissement = 0, .montant_par_an = 0, .created = Nothing, .neuf = False, .deja_utiliser = False, .tres_bon_etat = False, .avec_defaut = False, .mauvaise_etat = False, .note_etat = "", .activite = ""})
                    While myReader.Read
                        Dim classe As New Materiels(CType(myReader, IDataRecord))
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
