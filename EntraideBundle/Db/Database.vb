Imports MySql.Data.MySqlClient

Namespace Db

    Public Class Database

        Public Shared trainning_mode As Boolean = False

        Private Shared host As String = My.Settings.dbhost
        Private Shared pass As String = My.Settings.dbpass
        Private Shared user As String = My.Settings.dbuser
        Private Shared dbname As String = My.Settings.dbname

        Private Shared connection As MySqlConnection

        Private Shared command As MySqlCommand

        ''' <summary>
        ''' Get Db connection
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property GetConnection As MySqlConnection
            Get
                If IsNothing(connection) Then
                    Try
                        Dim connectString As String = "Database=" & dbname & ";User Id=" & user & ";Datasource=" & host & ";password=" & pass

                        connection = New MySqlConnection(connectString)

                        If connection.State = ConnectionState.Closed Then
                            connection.Open()
                            Dim cmd As MySqlCommand = connection.CreateCommand
                            cmd.CommandText = "SET NAMES utf8"
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                        End If

                    Catch ex As Exception
                        If My.Settings.app_debug_mode = True Then
                            MsgBox(ex.ToString)
                        Else
                            MsgBox("Echec de connexion a la base de donnees")
                        End If
                    End Try
                End If


                Return connection

            End Get
        End Property



        Public Shared ReadOnly Property GetCommand As MySqlCommand
            Get
                Return GetConnection.CreateCommand
            End Get
        End Property


        Public Shared Sub CloseConnection()
            Try
                If Not IsNothing(connection) Then
                    connection.Close()
                    connection = Nothing
                End If
            Catch ex As Exception

            End Try
        End Sub


        Friend Shared Sub Query(ByVal sql As String)
            command = GetCommand()
            command.CommandText = sql
        End Sub

        ''' <summary>
        ''' Prepare l'execution d'une requete
        ''' </summary>
        ''' <param name="sql"></param>
        ''' <param name="cmd"></param>
        ''' <remarks></remarks>
        Friend Shared Sub Query(ByVal sql As String, cmd As MySqlCommand)
            cmd.CommandText = sql
        End Sub


        ''' <summary>
        ''' Execute la requete et renvoie l'affected rows
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Execute() As Integer
            Dim affectedRows As Integer = 0
            Try
                affectedRows = command.ExecuteNonQuery
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnes", 2)
                End If
            End Try
            Return affectedRows
        End Function

        ''' <summary>
        ''' Execute une requete puis renvoie le resultat
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ExecuteResult() As MySqlDataReader
            Dim reader As MySqlDataReader = Nothing
            Try
                reader = command.ExecuteReader
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Echec de connexion a la base de donnes", 2)
                End If
            End Try
            Return reader
        End Function


        ''' <summary>
        ''' Get DataTable
        ''' </summary>
        ''' <param name="sql"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetDataTable(ByVal sql As String) As DataTable
            Dim dataTable As New DataTable

            Try
                Dim adapter As New MySqlDataAdapter
                Dim cmd = Database.GetCommand

                cmd.CommandText = sql
                adapter.SelectCommand = cmd
                adapter.Fill(dataTable)

                Dim row = dataTable.NewRow

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Erreur de recuperation du dataTable" & vbCrLf & "Message : " & ex.Message)
                End If
            End Try

            Return dataTable
        End Function



        Public Shared ReadOnly Property NewConnecion() As MySqlConnection
            Get
                Dim sql = ""

                If trainning_mode Then
                    sql = "Datasource=" & My.Settings.dbhost & ";Database=" & My.Settings.trainning_db & ";user id=" & My.Settings.dbuser & ";password=" & My.Settings.dbpass & ""
                Else
                    sql = "Datasource=" & My.Settings.dbhost & ";Database=" & My.Settings.dbname & ";user id=" & My.Settings.dbuser & ";password=" & My.Settings.dbpass & ""
                End If

                Dim connection = New MySqlConnection(sql)
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                    Dim mc As New MySqlCommand("SET lc_time_names = 'fr_FR'", connection)
                    mc.ExecuteNonQuery()
                End If
                Return connection
            End Get
        End Property

    End Class

End Namespace
