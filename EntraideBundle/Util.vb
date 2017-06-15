Imports MetroFramework.Controls
Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db
Imports MetroFramework


Public Class Util

    ''' <summary>
    ''' Populate un combobo
    ''' </summary>
    ''' <param name="combobox">Le combobox a populate</param>
    ''' <param name="req">La requete sql</param>
    ''' <param name="valueMember">le nom du champ des valeurs</param>
    ''' <param name="displayMember">le nom du champ à afficher</param>
    Friend Shared Sub PopulateCombo(ByRef combobox As ComboBox, ByVal req As String, ByVal valueMember As String, ByVal displayMember As String)
        Try
            Dim dataTable As New DataTable
            Dim adapter As New MySqlDataAdapter
            Dim cmd = Database.GetCommand
            cmd.CommandText = req
            adapter.SelectCommand = cmd
            adapter.Fill(dataTable)
            Dim row = dataTable.NewRow
            row(0) = "0"
            row(1) = ""
            dataTable.Rows.InsertAt(row, 0)
            combobox.DataSource = dataTable
            combobox.DisplayMember = displayMember
            combobox.ValueMember = valueMember

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            End If
            Util.ShowMessage("Impossible de charger les informations sur la liste deroulant" & combobox.Name, 2)
        Finally
            Database.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' Poplulate autocompletion
    ''' </summary>
    ''' <param name="txtBox"></param>
    ''' <param name="req"></param>
    ''' <remarks></remarks>
    Public Shared Sub PopulateAutoCompletation(ByRef txtBox As MetroTextBox, ByVal req As String)
        Try
            Database.Query(req)
            Dim result = Database.ExecuteResult
            Dim collec As New AutoCompleteStringCollection
            While result.Read
                collec.Add(result.GetValue(0).ToString)
            End While
            Database.CloseConnection()
            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBox.AutoCompleteCustomSource = collec
        Catch ex As Exception
            Util.ShowMessage("Impossible de recuperer les valeurs d'autocompletation", 2)
        Finally
            Database.CloseConnection()
        End Try
    End Sub


    ''' <summary>
    ''' Affiche un message
    ''' </summary>
    ''' <param name="message"></param>
    ''' <param name="type"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ShowMessage(ByVal message As String, Optional ByVal type As Integer = 0) As DialogResult

        Dim result As DialogResult

        If type = 0 Then
            result = MsgBox(message, MsgBoxStyle.Information)
        ElseIf type = 1 Then
            result = MsgBox(message, MsgBoxStyle.Exclamation)
        ElseIf type = 2 Then
            result = MsgBox(message, MsgBoxStyle.Critical)
        ElseIf type = 3 Then
            Beep()
            result = MsgBox(message, MsgBoxStyle.YesNo)
        End If


        Return result
    End Function

    ''' <summary>
    ''' Affiche un MetroMessageBox
    ''' </summary>
    ''' <param name="form"></param>
    ''' <param name="message"></param>
    ''' <param name="type"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ShowMessage(ByVal form As IWin32Window, ByVal message As String, Optional ByVal type As Integer = 0) As DialogResult

        Dim result As DialogResult

        If type = 0 Then
            result = MetroMessageBox.Show(form, message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf type = 1 Then
            result = MetroMessageBox.Show(form, message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf type = 2 Then
            result = MetroMessageBox.Show(form, message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf type = 3 Then
            result = MetroMessageBox.Show(form, message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        Return result
    End Function


    ''' <summary>
    ''' Escape String
    ''' </summary>
    ''' <param name="text"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function E(ByVal text As String) As String

        Return text.Replace("'", "").Replace(";", "").Replace("\", "\\")
    End Function

    ''' <summary>
    ''' Parse un champ DatePicker pour renvoie un format de date Mysql
    ''' </summary>
    ''' <param name="picker">Le dateTimePicker a laquel la date sera retirer</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetDateToMysqlFormat(ByVal picker As DateTimePicker) As String
        Dim temp = picker.Value.Date
        Dim month = temp.Month.ToString
        Dim day = temp.Day.ToString

        If month.Length = 1 Then
            month = "0" & month
        End If

        If day.Length = 1 Then
            day = "0" & day
        End If

        Return temp.Year & "-" & month & "-" & day
    End Function

    Public Shared Function GetDateToMysqlFormat(ByVal value As Date) As String

        Dim month = value.Month.ToString
        Dim day = value.Day

        If month.Length = 1 Then
            month = "0" & month
        End If

        If day.ToString.Length = 1 Then
            day = "0" & day
        End If

        Return value.Year & "-" & month & "-" & day
    End Function



    Public Shared Sub EmptyForm(ByRef form As Control)
        For Each c As Control In form.Controls
            If TypeOf c Is MetroTextBox Then
                DirectCast(c, MetroTextBox).Clear()
            ElseIf TypeOf c Is TextBox Then
                DirectCast(c, TextBox).Clear()
            ElseIf TypeOf c Is MetroComboBox Then
                DirectCast(c, MetroComboBox).Text = ""
            ElseIf TypeOf c Is ComboBox Then
                DirectCast(c, ComboBox).Text = ""
            ElseIf TypeOf c Is CheckBox Then
                DirectCast(c, CheckBox).Checked = False
            End If
            If c.Controls.Count > 0 Then
                EmptyForm(c)
            End If
        Next
    End Sub


    ''' <summary>
    ''' Verifie si le catactere siaise est un nombre
    ''' </summary>
    ''' <param name="e"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function checkkey(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            Beep()
            e.Handled = True
        End If
        Return Nothing
    End Function


    ''' <summary>
    ''' Populate Year combobox
    ''' </summary>
    ''' <param name="combo"></param>
    ''' <remarks></remarks>
    Public Shared Sub PopulateComboYear(ByRef combo As ComboBox)
        Dim dt As DataTable = New DataTable
        dt.Columns.Add(New DataColumn("year"))

        For i As Integer = 2013 To 2030
            Dim row As DataRow = dt.NewRow
            row(0) = i
            dt.Rows.Add(row)

        Next

        combo.DataSource = dt
        combo.DisplayMember = "year"
        combo.Text = Now.Year
    End Sub


    ''' <summary>
    ''' Populate Year combobox
    ''' </summary>
    ''' <param name="combo"></param>
    ''' <remarks></remarks>
    Public Shared Sub PopulateComboMonth(ByRef combo As ComboBox)
        Dim dt As DataTable = New DataTable
        dt.Columns.Add(New DataColumn("name"))
        dt.Columns.Add(New DataColumn("value"))

        Dim months As String() = {"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Auout", "Septembre", "Octobre", "Novembre", "Decembrer"}

        For i As Integer = 0 To months.Length - 1
            Dim value As String = CStr(i + 1)
            If value.Length = 1 Then
                value = "0" & value
            End If
            Dim row As DataRow = dt.NewRow
            row(0) = months(i)
            row(1) = value
            dt.Rows.Add(row)
        Next

        combo.DataSource = dt
        combo.DisplayMember = "name"
        combo.ValueMember = "value"
        Dim v As String = CStr(Now.Month)
        If v.Length = 1 Then
            v = "0" & v
        End If
        combo.SelectedValue = v
    End Sub



    Public Shared Sub ManageTypeReport(ByRef cmbTypeRapport As ComboBox, ByRef cmbAnnee As ComboBox, ByRef cmbDu As DateTimePicker, ByRef cmbAu As DateTimePicker)
        If cmbTypeRapport.Text = "Journalier" Then
            cmbDu.Value = Now
            cmbAu.Value = Now
        ElseIf cmbTypeRapport.Text = "Hebdomadaire" Then
            Dim monday As Date = Today.AddDays((Today.DayOfWeek - DayOfWeek.Monday) * -1)
            cmbDu.Value = (New Date(cmbAnnee.Text, Now.Month, monday.Day))
            cmbAu.Value = (New Date(cmbAnnee.Text, Now.Month, monday.AddDays(6).Day))
        ElseIf cmbTypeRapport.Text = "Mensuel" Then
            cmbDu.Value = (New Date(cmbAnnee.Text, Now.Month, 1))
            cmbAu.Value = DateAdd(DateInterval.Month, 1, New Date(cmbAnnee.Text, Now.Month, 1)).AddDays(-1)
        ElseIf cmbTypeRapport.Text = "Trimestriel" Then
            Dim currentMonth As Integer = Now.Month
            Dim d1 As Date = Nothing
            Dim d2 As Date = Nothing
            If currentMonth >= 1 AndAlso currentMonth <= 3 Then
                d1 = New Date(cmbAnnee.Text, 1, 1)
                Dim tempDate As Date = (New Date(cmbAnnee.Text, 3, 1))
                d2 = DateAdd(DateInterval.Month, 1, New Date(cmbAnnee.Text, tempDate.Month, 1)).AddDays(-1)
            ElseIf currentMonth >= 3 AndAlso currentMonth <= 6 Then
                d1 = New Date(cmbAnnee.Text, 3, 1)
                Dim tempDate As Date = (New Date(cmbAnnee.Text, 6, 1))
                d2 = DateAdd(DateInterval.Month, 1, New Date(cmbAnnee.Text, tempDate.Month, 1)).AddDays(-1)
            ElseIf currentMonth >= 6 AndAlso currentMonth <= 9 Then
                d1 = New Date(cmbAnnee.Text, 6, 1)
                Dim tempDate As Date = (New Date(cmbAnnee.Text, 9, 1))
                d2 = DateAdd(DateInterval.Month, 1, New Date(cmbAnnee.Text, tempDate.Month, 1)).AddDays(-1)
            ElseIf currentMonth >= 9 AndAlso currentMonth <= 12 Then
                d1 = New Date(cmbAnnee.Text, 9, 1)
                Dim tempDate As Date = (New Date(cmbAnnee.Text, 12, 1))
                d2 = DateAdd(DateInterval.Month, 1, New Date(cmbAnnee.Text, tempDate.Month, 1)).AddDays(-1)
            End If

            cmbDu.Value = d1
            cmbAu.Value = d2
        ElseIf cmbTypeRapport.Text = "Annuel" Then
            cmbDu.Value = (New Date(cmbAnnee.Text, 1, 1))
            cmbAu.Value = (New Date(cmbAnnee.Text, 12, 31))
        End If
    End Sub
End Class
