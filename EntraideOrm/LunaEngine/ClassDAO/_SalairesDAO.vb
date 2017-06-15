#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 31/03/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Salaires object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _SalairesDAO
Inherits LUNA.LunaBaseClassDAO(Of Salaires)

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
'''Read from DB table Salaires
''' </summary>
''' <returns>
'''Return a Salaires object
''' </returns>
Public Overrides Function Read(Id as integer) as Salaires
    Dim cls as new Salaires

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Salaires WHERE id = " & Id
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            Using myReader As DbDataReader = myCommand.ExecuteReader

                myReader.Read()
                if myReader.HasRows then
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
'''Save on DB table Salaires
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Salaires) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.id = 0 Then
                        sql = "INSERT INTO Salaires ("
                            sql &= " term_paiement,"
                            sql &= " taux,"
                            sql &= " nb_jour_travail,"
                            sql &= " salaire"
                      sql &= ") VALUES ("
                      sql &= " @term_paiement,"
                      sql &= " @taux,"
                      sql &= " @nb_jour_travail,"
                      sql &= " @salaire"
                      sql &= ")"
		            Else
			            sql = "UPDATE Salaires SET "
                  sql &= "term_paiement = @term_paiement,"
                  sql &= "taux = @taux,"
                  sql &= "nb_jour_travail = @nb_jour_travail,"
                  sql &= "salaire = @salaire"
			            sql &= " WHERE id= " & cls.id
		            End if
					
					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@term_paiement"
					p.Value = cls.term_paiement
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@taux"
					p.Value = cls.taux
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@nb_jour_travail"
					p.Value = cls.nb_jour_travail
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@salaire"
					p.Value = cls.salaire
  					myCommand.Parameters.Add(p)

                    myCommand.CommandType = CommandType.Text
		            myCommand.CommandText = sql
		            myCommand.ExecuteNonQuery()

		            
					If cls.id=0 Then
			            Dim IdInserito as integer = 0
			            Sql = "select @@identity"
			            myCommand.CommandText = Sql
			            Idinserito = myCommand.ExecuteScalar()
			            cls.id = Idinserito
			            Ris = Idinserito
		            else
			            Ris  =  cls.id
		            End If
		            

	            Catch ex As Exception
		            ManageError(ex)
	            End Try
            End Using
        else
	        Ris  =  cls.id
        End If

    Else
	    MsgBox("Veuillez correctement remplir tous les champs", MsgBoxStyle.Exclamation)
    End If
    Return Ris
End Function

Private Sub DestroyPermanently(Id as integer) 
    Try

    Using myCommand As DbCommand = _Cn.CreateCommand
        myCommand.Connection = _cn

        '******IMPORTANT: You can use this commented instruction to make a logical delete .
        '******Replace DELETED Field with your logic deleted field name.
        'Dim Sql As String = "UPDATE Salaires SET DELETED=True "
        Dim Sql As String = "DELETE FROM Salaires"
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
'''Delete from DB table Salaires. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Salaires. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Salaires, Optional ByRef ListaObj as List (of Salaires) = Nothing)
        DestroyPermanently (obj.id)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Salaires
''' </summary>
''' <returns>
'''Return first of Salaires
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Salaires
    Dim ris As Salaires = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Salaires) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Salaires
''' </summary>
''' <returns>
'''Return first of Salaires
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Salaires
    Dim ris As Salaires = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Salaires) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Salaires
''' </summary>
''' <returns>
'''Return a list of Salaires
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Salaires)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Salaires
''' </summary>
''' <returns>
'''Return a list of Salaires
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Salaires)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Salaires
''' </summary>
''' <returns>
'''Return a list of Salaires
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Salaires)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

																																							  ''' <summary>
'''Find on DB table Salaires by custom query 
''' </summary>
''' <returns>
'''Return a list of Salaires
''' </returns>
Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Salaires)
     Dim Ls As New List(Of Salaires)
    Try
	 Ls = GetData(SQlQuery, AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

''' <summary>
'''Find on DB table Salaires
''' </summary>
''' <returns>
'''Return a list of Salaires
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Salaires)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Salaires)
    Dim Ls As New List(Of Salaires)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		sql &=" * FROM Salaires" 
    For Each Par As LUNA.LunaSearchParameter In Parameter
	    If Not Par Is Nothing Then
		    If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		        sql &= Par.FieldName & " " & Par.SqlOperator
                If Par.SqlOperator.ToUpper.IndexOf("IN") <> -1 Then
                    sql &= " " & ApIn(Par.Value)
                Else
                    sql &= " " & Ap(Par.Value)
                End If
	    End if
    Next

    If SearchOption.OrderBy.Length Then Sql &= " ORDER BY " & SearchOption.OrderBy

		if SearchOption.Top then sql &= " LIMIT " & SearchOption.Top
	
    Ls = GetData(sql, SearchOption.AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Salaires)
    Dim Ls As New List(Of Salaires)
    Try

    Dim sql As String = ""
    sql ="SELECT * FROM Salaires" 
    If OrderByField.Length Then
	    Sql &= " ORDER BY " & OrderByField
    End If

    Ls = GetData(Sql,AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

Protected Overridable Property EmptyItemDescription As String = "Selezionare una voce"

Protected Function GetData(sql as string, Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Salaires)
    Dim Ls As New List(Of Salaires)
    Try
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = sql
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            Using myReader As DbDataReader = myCommand.ExecuteReader()
                If AddEmptyItem Then Ls.Add(New  Salaires() With {.id = 0 ,.term_paiement = "" ,.taux = 0 ,.nb_jour_travail = 0 ,.salaire = 0  })
                while myReader.Read
	                Dim classe as new Salaires(CType(myReader, IDataRecord))
	                Ls.Add(classe)
                end while
                myReader.Close()
            End Using
        End Using

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function
End Class
