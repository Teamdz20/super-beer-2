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
'''This class manage persistency on db of Dons object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _DonsDAO
Inherits LUNA.LunaBaseClassDAO(Of Dons)

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
'''Read from DB table Dons
''' </summary>
''' <returns>
'''Return a Dons object
''' </returns>
Public Overrides Function Read(Id as integer) as Dons
    Dim cls as new Dons

    Try
        Using myCommand As DbCommand = _cn.CreateCommand
        
            myCommand.CommandText = "SELECT * FROM Dons WHERE id = " & Id
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
'''Save on DB table Dons
''' </summary>
''' <returns>
'''Return ID insert in DB
''' </returns>
Public Overrides Function Save(byRef cls as Dons) as Integer

    Dim Ris as integer=0 'in Ris return Insert Id

    If cls.IsValid Then
        If cls.IsChanged Then
            Using myCommand As DbCommand = _Cn.CreateCommand()
	            Try
		            Dim sql As String = String.Empty
		            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
		            If cls.id = 0 Then
                        sql = "INSERT INTO Dons ("
                            sql &= " activite_financier_id,"
                            sql &= " departement_id,"
                            sql &= " donneur_id,"
                            sql &= " type_don,"
                            sql &= " materiel_id,"
                            sql &= " mode_reception,"
                            sql &= " montant_recu,"
                            sql &= " montant_sollicite,"
                            sql &= " code,"
                            sql &= " non_sollicite,"
                            sql &= " numero_cheque,"
                            sql &= " restriction,"
                            sql &= " note_restriction,"
                            sql &= " activite_menee,"
                            sql &= " created,"
                            sql &= " user_id"
                      sql &= ") VALUES ("
                      sql &= " @activite_financier_id,"
                      sql &= " @departement_id,"
                      sql &= " @donneur_id,"
                      sql &= " @type_don,"
                      sql &= " @materiel_id,"
                      sql &= " @mode_reception,"
                      sql &= " @montant_recu,"
                      sql &= " @montant_sollicite,"
                      sql &= " @code,"
                      sql &= " @non_sollicite,"
                      sql &= " @numero_cheque,"
                      sql &= " @restriction,"
                      sql &= " @note_restriction,"
                      sql &= " @activite_menee,"
                      sql &= " @created,"
                      sql &= " @user_id"
                      sql &= ")"
		            Else
			            sql = "UPDATE Dons SET "
                  sql &= "activite_financier_id = @activite_financier_id,"
                  sql &= "departement_id = @departement_id,"
                  sql &= "donneur_id = @donneur_id,"
                  sql &= "type_don = @type_don,"
                  sql &= "materiel_id = @materiel_id,"
                  sql &= "mode_reception = @mode_reception,"
                  sql &= "montant_recu = @montant_recu,"
                  sql &= "montant_sollicite = @montant_sollicite,"
                  sql &= "code = @code,"
                  sql &= "non_sollicite = @non_sollicite,"
                  sql &= "numero_cheque = @numero_cheque,"
                  sql &= "restriction = @restriction,"
                  sql &= "note_restriction = @note_restriction,"
                  sql &= "activite_menee = @activite_menee,"
                  sql &= "created = @created,"
                  sql &= "user_id = @user_id"
			            sql &= " WHERE id= " & cls.id
		            End if

					Dim p As DbParameter = Nothing 
					p = myCommand.CreateParameter
					p.ParameterName = "@activite_financier_id"
					p.Value = cls.activite_financier_id
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@departement_id"
					p.Value = cls.departement_id
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@donneur_id"
					p.Value = cls.donneur_id
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@type_don"
					p.Value = cls.type_don
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@materiel_id"
					p.Value = cls.materiel_id
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@mode_reception"
					p.Value = cls.mode_reception
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@montant_recu"
					p.Value = cls.montant_recu
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@montant_sollicite"
					p.Value = cls.montant_sollicite
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@code"
					p.Value = cls.code
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@non_sollicite"
					p.Value = cls.non_sollicite
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@numero_cheque"
					p.Value = cls.numero_cheque
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@restriction"
					p.Value = cls.restriction
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@note_restriction"
					p.Value = cls.note_restriction
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@activite_menee"
					p.Value = cls.activite_menee
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@created"
					p.DbType = DbType.DateTime
					if cls.created <> Date.MinValue then
			            p.Value = cls.created
                    else
                        p.Value = DBNull.Value
                    end if  
  					myCommand.Parameters.Add(p)

					p = myCommand.CreateParameter
					p.ParameterName = "@user_id"
					p.Value = cls.user_id
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
        'Dim Sql As String = "UPDATE Dons SET DELETED=True "
        Dim Sql As String = "DELETE FROM Dons"
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
'''Delete from DB table Dons. Accept id of object to delete.
''' </summary>
Public Overrides Sub Delete(Id as integer) 
        DestroyPermanently (Id)
    End Sub

''' <summary>
'''Delete from DB table Dons. Accept object to delete and optional a List to remove the object from.
''' </summary>
Public Overrides Sub Delete(byref obj as Dons, Optional ByRef ListaObj as List (of Dons) = Nothing)
        DestroyPermanently (obj.id)
    If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
     
End Sub

''' <summary>
'''Find on DB table Dons
''' </summary>
''' <returns>
'''Return first of Dons
''' </returns>
Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Dons
    Dim ris As Dons = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1}
    Dim l As IEnumerable(Of Dons) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function

''' <summary>
'''Find on DB table Dons
''' </summary>
''' <returns>
'''Return first of Dons
''' </returns>
Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Dons
    Dim ris As Dons = Nothing
    Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
    Dim l As IEnumerable(Of Dons) = FindReal(So, Parameter)
    If l.Count Then
        ris = l(0)
    End If
    Return ris
End Function
''' <summary>
'''Find on DB table Dons
''' </summary>
''' <returns>
'''Return a list of Dons
''' </returns>
Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Dons)
    Dim So As New Luna.LunaSearchOption
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Dons
''' </summary>
''' <returns>
'''Return a list of Dons
''' </returns>
Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Dons)
    Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

''' <summary>
'''Find on DB table Dons
''' </summary>
''' <returns>
'''Return a list of Dons
''' </returns>
Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of Dons)
    Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
    Return FindReal(So, Parameter)
End Function

																																							  ''' <summary>
'''Find on DB table Dons by custom query 
''' </summary>
''' <returns>
'''Return a list of Dons
''' </returns>
Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Dons)
     Dim Ls As New List(Of Dons)
    Try
	 Ls = GetData(SQlQuery, AddEmptyItem)

    Catch ex As Exception
	    ManageError(ex)
    End Try
    Return Ls
End Function

''' <summary>
'''Find on DB table Dons
''' </summary>
''' <returns>
'''Return a list of Dons
''' </returns>
Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Dons)
    Return FindReal(SearchOption, Parameter)
End Function

Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Dons)
    Dim Ls As New List(Of Dons)
    Try

    Dim sql As String = ""
    sql ="SELECT "   
		sql &=" * FROM Dons" 
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

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Dons)
    Dim Ls As New List(Of Dons)
    Try

    Dim sql As String = ""
    sql ="SELECT * FROM Dons" 
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

Protected Function GetData(sql as string, Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Dons)
    Dim Ls As New List(Of Dons)
    Try
        Using myCommand As DbCommand = _Cn.CreateCommand
            myCommand.CommandText = sql
            If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
            Using myReader As DbDataReader = myCommand.ExecuteReader()
                If AddEmptyItem Then Ls.Add(New  Dons() With {.id = 0 ,.activite_financier_id = 0 ,.departement_id = 0 ,.donneur_id = "" ,.type_don = "" ,.materiel_id = 0 ,.mode_reception = "" ,.montant_recu = 0 ,.montant_sollicite = 0 ,.code = "" ,.non_sollicite = "" ,.numero_cheque = "" ,.restriction = "" ,.note_restriction = "" ,.activite_menee = "" ,.created = Nothing ,.user_id = 0  })
                while myReader.Read
	                Dim classe as new Dons(CType(myReader, IDataRecord))
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
