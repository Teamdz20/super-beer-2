Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls
Namespace Db.Tables
    Public Class TableDevise
        Public Function GetAll() As DataTable
            Dim dataTable As New DataTable

            Try

                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT * FROM devises"

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

            Dim id_devise As Integer
            Dim cmd As MySqlCommand = Nothing
            Dim result As MySqlDataReader = Nothing
            Dim command As MySqlCommand = Nothing
            command = Database.GetCommand


            Try

                cmd = Database.GetCommand
                cmd.CommandText = "SELECT devise.id FROM devises WHERE devises.nom = @id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", id)

                result = cmd.ExecuteReader

                If result.HasRows Then
                    result.Read()
                    id_devise = result.GetInt32("id")
                End If

            Catch ex As MySqlException
                If My.Settings.app_debug_mode Then
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                Else
                    MsgBox("Echec de connexion a la db", MsgBoxStyle.Critical)
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

            Return id_devise
        End Function

    End Class
End Namespace
