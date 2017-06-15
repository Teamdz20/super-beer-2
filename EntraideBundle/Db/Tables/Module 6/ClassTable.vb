Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls
Namespace Db.Tables
    Public Class ClassTable

        Public Function GetAll() As DataTable
            Dim dataTable As New DataTable

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT * FROM classification_revenus"

                Dim tableAdpater As New MySqlDataAdapter
                tableAdpater.SelectCommand = cmd
                tableAdpater.Fill(dataTable)

            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString)
                Else
                    MsgBox("Echec de connexion")
                End If

            Finally
                Database.CloseConnection()
            End Try

            Return dataTable
        End Function

        Public Function GetById(ByVal id As String) As Integer

            Dim id_class As Integer
            Dim cmd As MySqlCommand = Nothing
            Dim result As MySqlDataReader = Nothing
            Dim command As MySqlCommand = Nothing
            command = Database.GetCommand


            Try

                cmd = Database.GetCommand
                cmd.CommandText = "SELECT classification_revenus.id FROM classification_revenus WHERE classification_revenus.nom = @id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", id)

                result = cmd.ExecuteReader

                If result.HasRows Then
                    result.Read()
                    id_class = result.GetInt32("id")
                End If

            Catch ex As MySqlException
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage(ex.ToString, 2)
                End If
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                Else
                    MsgBox("Erreur inconnue " & ex.Message, MsgBoxStyle.Critical)
                End If
            Finally
                Try
                    If Not IsNothing(result) Then
                        result.Close()
                    End If

                    If Not IsNothing(cmd) Then
                        cmd.Dispose()
                        cmd.Connection.Close()
                    End If
                    Database.CloseConnection()
                Catch ex As Exception

                End Try
            End Try

            Return id_class
        End Function

    End Class
End Namespace
