#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 24/04/2017 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of Employes object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _EmployesDAO
    Inherits LUNA.LunaBaseClassDAO(Of Employes)

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
    '''Read from DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return a Employes object
    ''' </returns>
    Public Overrides Function Read(Id As Integer) As Employes
        Dim cls As New Employes

        Try
            Using myCommand As DbCommand = _cn.CreateCommand

                myCommand.CommandText = "SELECT * FROM Employes WHERE id = " & Id
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
    '''Save on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return ID insert in DB
    ''' </returns>
    Public Overrides Function Save(ByRef cls As Employes) As Integer

        Dim Ris As Integer = 0 'in Ris return Insert Id

        If cls.IsValid Then
            If cls.IsChanged Then
                Using myCommand As DbCommand = _Cn.CreateCommand()
                    Try
                        Dim sql As String = String.Empty
                        If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                        If cls.id = 0 Then
                            sql = "INSERT INTO Employes ("
                            sql &= " code,"
                            sql &= " nom,"
                            sql &= " prenom,"
                            sql &= " sexe,"
                            sql &= " situation_matrimonial,"
                            sql &= " nb_enfant,"
                            sql &= " date_naissance,"
                            sql &= " lieu_naissance,"
                            sql &= " nationnalite,"
                            sql &= " bp,"
                            sql &= " tel1,"
                            sql &= " tel2,"
                            sql &= " email,"
                            sql &= " religion,"
                            sql &= " precision_autre,"
                            sql &= " delis,"
                            sql &= " detail_delis,"
                            sql &= " recu_formation,"
                            sql &= " type_formation_recu,"
                            sql &= " niveau_etude,"
                            sql &= " diplome,"
                            sql &= " ecole,"
                            sql &= " nom_contact_urgent,"
                            sql &= " adresse_contact_urgent,"
                            sql &= " phone_contact_urgent,"
                            sql &= " email_contact_urgent,"
                            sql &= " competance_fr,"
                            sql &= " competance_en,"
                            sql &= " competance_information,"
                            sql &= " autres_competances,"
                            sql &= " note_exp_professionnelle,"
                            sql &= " departement_id,"
                            sql &= " poste_id,"
                            sql &= " debut_contract,"
                            sql &= " fin_contract,"
                            sql &= " date_enregistrement,"
                            sql &= " adresse"
                            sql &= ") VALUES ("
                            sql &= " @code,"
                            sql &= " @nom,"
                            sql &= " @prenom,"
                            sql &= " @sexe,"
                            sql &= " @situation_matrimonial,"
                            sql &= " @nb_enfant,"
                            sql &= " @date_naissance,"
                            sql &= " @lieu_naissance,"
                            sql &= " @nationnalite,"
                            sql &= " @bp,"
                            sql &= " @tel1,"
                            sql &= " @tel2,"
                            sql &= " @email,"
                            sql &= " @religion,"
                            sql &= " @precision_autre,"
                            sql &= " @delis,"
                            sql &= " @detail_delis,"
                            sql &= " @recu_formation,"
                            sql &= " @type_formation_recu,"
                            sql &= " @niveau_etude,"
                            sql &= " @diplome,"
                            sql &= " @ecole,"
                            sql &= " @nom_contact_urgent,"
                            sql &= " @adresse_contact_urgent,"
                            sql &= " @phone_contact_urgent,"
                            sql &= " @email_contact_urgent,"
                            sql &= " @competance_fr,"
                            sql &= " @competance_en,"
                            sql &= " @competance_information,"
                            sql &= " @autres_competances,"
                            sql &= " @note_exp_professionnelle,"
                            sql &= " @departement_id,"
                            sql &= " @poste_id,"
                            sql &= " @debut_contract,"
                            sql &= " @fin_contract,"
                            sql &= " @date_enregistrement,"
                            sql &= " @adresse"
                            sql &= ")"
                        Else
                            sql = "UPDATE Employes SET "
                            sql &= "code = @code,"
                            sql &= "nom = @nom,"
                            sql &= "prenom = @prenom,"
                            sql &= "sexe = @sexe,"
                            sql &= "situation_matrimonial = @situation_matrimonial,"
                            sql &= "nb_enfant = @nb_enfant,"
                            sql &= "date_naissance = @date_naissance,"
                            sql &= "lieu_naissance = @lieu_naissance,"
                            sql &= "nationnalite = @nationnalite,"
                            sql &= "bp = @bp,"
                            sql &= "tel1 = @tel1,"
                            sql &= "tel2 = @tel2,"
                            sql &= "email = @email,"
                            sql &= "religion = @religion,"
                            sql &= "precision_autre = @precision_autre,"
                            sql &= "delis = @delis,"
                            sql &= "detail_delis = @detail_delis,"
                            sql &= "recu_formation = @recu_formation,"
                            sql &= "type_formation_recu = @type_formation_recu,"
                            sql &= "niveau_etude = @niveau_etude,"
                            sql &= "diplome = @diplome,"
                            sql &= "ecole = @ecole,"
                            sql &= "nom_contact_urgent = @nom_contact_urgent,"
                            sql &= "adresse_contact_urgent = @adresse_contact_urgent,"
                            sql &= "phone_contact_urgent = @phone_contact_urgent,"
                            sql &= "email_contact_urgent = @email_contact_urgent,"
                            sql &= "competance_fr = @competance_fr,"
                            sql &= "competance_en = @competance_en,"
                            sql &= "competance_information = @competance_information,"
                            sql &= "autres_competances = @autres_competances,"
                            sql &= "note_exp_professionnelle = @note_exp_professionnelle,"
                            sql &= "departement_id = @departement_id,"
                            sql &= "poste_id = @poste_id,"
                            sql &= "debut_contract = @debut_contract,"
                            sql &= "fin_contract = @fin_contract,"
                            sql &= "date_enregistrement = @date_enregistrement,"
                            sql &= "adresse = @adresse"
                            sql &= " WHERE id= " & cls.id
                        End If

                        Dim p As DbParameter = Nothing
                        p = myCommand.CreateParameter
                        p.ParameterName = "@code"
                        p.Value = cls.code
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@nom"
                        p.Value = cls.nom
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@prenom"
                        p.Value = cls.prenom
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@sexe"
                        p.Value = cls.sexe
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@situation_matrimonial"
                        p.Value = cls.situation_matrimonial
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@nb_enfant"
                        p.Value = cls.nb_enfant
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@date_naissance"
                        p.DbType = DbType.DateTime
                        If cls.date_naissance <> Date.MinValue Then
                            p.Value = cls.date_naissance
                        Else
                            p.Value = DBNull.Value
                        End If
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@lieu_naissance"
                        p.Value = cls.lieu_naissance
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@nationnalite"
                        p.Value = cls.nationnalite
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@bp"
                        p.Value = cls.bp
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
                        p.ParameterName = "@email"
                        p.Value = cls.email
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@religion"
                        p.Value = cls.religion
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@precision_autre"
                        p.Value = cls.precision_autre
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@delis"
                        p.Value = cls.delis
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@detail_delis"
                        p.Value = cls.detail_delis
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@recu_formation"
                        p.Value = cls.recu_formation
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@type_formation_recu"
                        p.Value = cls.type_formation_recu
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@niveau_etude"
                        p.Value = cls.niveau_etude
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@diplome"
                        p.Value = cls.diplome
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@ecole"
                        p.Value = cls.ecole
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@nom_contact_urgent"
                        p.Value = cls.nom_contact_urgent
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@adresse_contact_urgent"
                        p.Value = cls.adresse_contact_urgent
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@phone_contact_urgent"
                        p.Value = cls.phone_contact_urgent
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@email_contact_urgent"
                        p.Value = cls.email_contact_urgent
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@competance_fr"
                        p.Value = cls.competance_fr
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@competance_en"
                        p.Value = cls.competance_en
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@competance_information"
                        p.Value = cls.competance_information
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@autres_competances"
                        p.Value = cls.autres_competances
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@note_exp_professionnelle"
                        p.Value = cls.note_exp_professionnelle
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@departement_id"
                        p.Value = cls.departement_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@poste_id"
                        p.Value = cls.poste_id
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@debut_contract"
                        p.DbType = DbType.DateTime
                        If cls.debut_contract <> Date.MinValue Then
                            p.Value = cls.debut_contract
                        Else
                            p.Value = DBNull.Value
                        End If
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@fin_contract"
                        p.DbType = DbType.DateTime
                        If cls.fin_contract <> Date.MinValue Then
                            p.Value = cls.fin_contract
                        Else
                            p.Value = DBNull.Value
                        End If
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@date_enregistrement"
                        p.DbType = DbType.DateTime
                        If cls.date_enregistrement <> Date.MinValue Then
                            p.Value = cls.date_enregistrement
                        Else
                            p.Value = DBNull.Value
                        End If
                        myCommand.Parameters.Add(p)

                        p = myCommand.CreateParameter
                        p.ParameterName = "@adresse"
                        p.Value = cls.adresse
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
                'Dim Sql As String = "UPDATE Employes SET DELETED=True "
                Dim Sql As String = "DELETE FROM Employes"
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
    '''Delete from DB table Employes. Accept id of object to delete.
    ''' </summary>
    Public Overrides Sub Delete(Id As Integer)
        DestroyPermanently(Id)
    End Sub

    ''' <summary>
    '''Delete from DB table Employes. Accept object to delete and optional a List to remove the object from.
    ''' </summary>
    Public Overrides Sub Delete(ByRef obj As Employes, Optional ByRef ListaObj As List(Of Employes) = Nothing)
        DestroyPermanently(obj.id)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    ''' <summary>
    '''Find on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return first of Employes
    ''' </returns>
    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Employes
        Dim ris As Employes = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1}
        Dim l As IEnumerable(Of Employes) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function

    ''' <summary>
    '''Find on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return first of Employes
    ''' </returns>
    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As Employes
        Dim ris As Employes = Nothing
        Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
        Dim l As IEnumerable(Of Employes) = FindReal(So, Parameter)
        If l.Count Then
            ris = l(0)
        End If
        Return ris
    End Function
    ''' <summary>
    '''Find on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return a list of Employes
    ''' </returns>
    Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Employes)
        Dim So As New Luna.LunaSearchOption
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return a list of Employes
    ''' </returns>
    Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Employes)
        Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return a list of Employes
    ''' </returns>
    Public Overloads Function FindAll(ByVal Top As Integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Employes)
        Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
        Return FindReal(So, Parameter)
    End Function

    ''' <summary>
    '''Find on DB table Employes by custom query 
    ''' </summary>
    ''' <returns>
    '''Return a list of Employes
    ''' </returns>
    Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of Employes)
        Dim Ls As New List(Of Employes)
        Try
            Ls = GetData(SQlQuery, AddEmptyItem)

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    ''' <summary>
    '''Find on DB table Employes
    ''' </summary>
    ''' <returns>
    '''Return a list of Employes
    ''' </returns>
    Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Employes)
        Return FindReal(SearchOption, Parameter)
    End Function

    Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As iEnumerable(Of Employes)
        Dim Ls As New List(Of Employes)
        Try

            Dim sql As String = ""
            sql = "SELECT "
            sql &= " * FROM Employes"
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

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Employes)
        Dim Ls As New List(Of Employes)
        Try

            Dim sql As String = ""
            sql = "SELECT * FROM Employes"
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

    Protected Function GetData(sql As String, Optional ByVal AddEmptyItem As Boolean = False) As iEnumerable(Of Employes)
        Dim Ls As New List(Of Employes)
        Try
            Using myCommand As DbCommand = _Cn.CreateCommand
                myCommand.CommandText = sql
                If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
                Using myReader As DbDataReader = myCommand.ExecuteReader()
                    If AddEmptyItem Then Ls.Add(New Employes() With {.id = 0, .code = "", .nom = "", .prenom = "", .sexe = "", .situation_matrimonial = "", .nb_enfant = 0, .date_naissance = Nothing, .lieu_naissance = "", .nationnalite = "", .bp = "", .tel1 = "", .tel2 = "", .email = "", .religion = "", .precision_autre = "", .delis = False, .detail_delis = "", .recu_formation = False, .type_formation_recu = "", .niveau_etude = "", .diplome = "", .ecole = "", .nom_contact_urgent = "", .adresse_contact_urgent = "", .phone_contact_urgent = "", .email_contact_urgent = "", .competance_fr = "", .competance_en = "", .competance_information = "", .autres_competances = "", .note_exp_professionnelle = "", .departement_id = 0, .poste_id = 0, .debut_contract = Nothing, .fin_contract = Nothing, .date_enregistrement = Nothing, .adresse = ""})
                    While myReader.Read
                        Dim classe As New Employes(CType(myReader, IDataRecord))
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
