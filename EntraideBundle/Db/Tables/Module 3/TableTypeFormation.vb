
Imports MySql.Data.MySqlClient

Namespace Db.Tables

    Public Class TableTypeFormation

        Public Function getMontant(id As Integer) As Integer
            Dim montant As Integer
            Dim cmd As MySqlCommand = Nothing
            Dim result As MySqlDataReader = Nothing

            Dim command As MySqlCommand = Nothing
            command = database.GetCommand


            Try

                cmd = database.GetCommand
                cmd.CommandText = "SELECT type_formation.montant FROM type_formation WHERE id=@id"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@id", id)

                result = cmd.ExecuteReader

                If result.HasRows Then
                    result.Read()
                    montant = result.GetInt32("montant")



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

            Return montant
        End Function

    End Class
End Namespace
