Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db.Entities

Namespace Db.Tables
    Public Class UsersTable


        Public Shared Function LogUser(ByRef user As UserEntity) As UserEntity
            Dim loggged As Boolean = False

            Try
                Dim cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = "SELECT users.id AS user_id, username AS user_username, CONCAT_WS(' ', employes.nom, employes.prenom) AS full_name FROM users INNER JOIN employes ON users.employe_id = employes.id WHERE username = @uname AND password = PASSWORD('" & user.password & "') "
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@uname", user.username)
                Dim result As MySqlDataReader = cmd.ExecuteReader
                user.IsLogged = result.HasRows
                If user.IsLogged Then
                    result.Read()
                    user.id = result("user_id")
                    user.EmpFullName = result("full_name")
                End If
                result.Close()
            Catch ex As Exception
                loggged = False
                Util.ShowMessage("Error : " & ex.Message, 2)
            Finally
                Database.CloseConnection()
            End Try


            Return user
        End Function

    End Class
End Namespace