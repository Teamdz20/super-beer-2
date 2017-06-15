Imports EntraideBundle.Db
Imports MySql.Data.MySqlClient

Public Class RevenuGeneral

    Enum E_TYPE_RAPPORT
        ALL = 0
        DON = 1
        FOND_DE_SOUTIENS = 2
        AGR = 3
        INSCRIPTION_ETUDIANT = 4
    End Enum

    Public type_rapport As E_TYPE_RAPPORT = E_TYPE_RAPPORT.ALL

    Public Shared data_source As DataSetTables = Nothing

    ''' <summary>
    ''' Responsive manage
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Responsive(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim location As New Point
        location.X = (Me.Width - PanelContainer.Width) / 2
        location.Y = ((Me.Height - PanelContainer.Height) / 2) + 20
        PanelContainer.Location = location
    End Sub


    Private Sub LoadData(Optional byType As Boolean = False)
        Dim total As Double = 0
        Try

            Dim sql As String = ""

            If byType Then
                sql = "SELECT * FROM v_revenu_general WHERE (DATE(created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "') AND type = '" & cmbType.Text & "' ORDER BY created DESC"
            Else
                sql = "SELECT * FROM v_revenu_general WHERE (DATE(created) BETWEEN '" & Util.GetDateToMysqlFormat(cmbDu) & "' AND '" & Util.GetDateToMysqlFormat(cmbAu) & "' ) ORDER BY created DESC"
            End If

            Dim cmd As MySqlCommand = Database.GetCommand
            cmd.CommandText = sql

            Dim result As MySqlDataReader = cmd.ExecuteReader

            ListRevenu.Items.Clear()
            Dim iter As Integer = 1

            While result.Read
                Dim item As New ListViewItem(result.GetValue(0).ToString)
                item.SubItems.Add(result.GetValue(1).ToString)
                item.SubItems.Add(FormatNumber(result.GetValue(2).ToString, 0))
                item.SubItems.Add(result.GetValue(3).ToString)

                Dim t As Double = 0
                Double.TryParse(result.GetValue(2).ToString, t)
                total += t

                If iter = 4 Then
                    item.BackColor = Color.AliceBlue
                    iter = 0
                End If

                ListRevenu.Items.Add(item)
                iter += 1
            End While

            result.Close()

            FillDataSource(cmd)

            cmd.Dispose()

        Catch ex As Exception
            If My.Settings.app_debug_mode Then
                Util.ShowMessage(ex.ToString, 2)
            Else
                Util.ShowMessage("Fatal error : " & ex.Message, 2)
            End If
        Finally
            Database.CloseConnection()
            GC.Collect()

            labelTotal.Text = FormatNumber(total, 0)
        End Try
    End Sub

    Private Sub RevenuGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Util.PopulateComboYear(cmbAnnee)
        cmbTypeRapport.Text = "Hebdomadaire"
        If type_rapport = E_TYPE_RAPPORT.ALL Then
            LoadData()
        Else
            SelectTypeReport()
            LoadData(True)
        End If
    End Sub

    Private Sub SelectTypeReport()
        Select Case type_rapport
            Case E_TYPE_RAPPORT.AGR
                cmbType.Text = "AGR"
            Case E_TYPE_RAPPORT.DON
                cmbType.Text = "DON"
            Case E_TYPE_RAPPORT.FOND_DE_SOUTIENS
                cmbType.Text = "FOND DE SOUTIENS"
            Case E_TYPE_RAPPORT.INSCRIPTION_ETUDIANT
                cmbType.Text = "INSCRIPTION ETUDIANT"
        End Select
        ckType.Checked = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cmbTypeRapport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypeRapport.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub cmbAnnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnnee.SelectedIndexChanged
        Util.ManageTypeReport(cmbTypeRapport, cmbAnnee, cmbDu, cmbAu)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ckType.Checked Then
            If cmbType.Text.Trim.Length = 0 Then
                Util.ShowMessage(Me, "Selectionner le type de revenu", 1)
                Exit Sub
            End If
            LoadData(True)
        Else
            LoadData()
        End If
    End Sub

    Private Sub ckType_CheckedChanged(sender As Object, e As EventArgs) Handles ckType.CheckedChanged
        cmbType.Enabled = ckType.Checked
        If ckType.Checked = False Then
            cmbType.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' Filling DataSource to generate a report
    ''' </summary>
    ''' <param name="cmd"></param>
    ''' <remarks></remarks>
    Private Sub FillDataSource(ByRef cmd As MySqlCommand)
        Try
            data_source = New DataSetTables
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.FillAsync(data_source.RapportRevenu)
            adapter.Dispose()
        Catch ex As Exception
            Util.ShowMessage("Unable to provide datas to a DataSource : " & ex.Message, 2)
        End Try
    End Sub

    Private Sub btnRapport_Click(sender As Object, e As EventArgs) Handles btnRapport.Click
        Dim source As String = cmbType.Text.Trim
        If source.Length = 0 Then source = "Toutes"
        Dim periode As String = FormatDateTime(cmbDu.Value, DateFormat.ShortDate)
        periode &= " - " & FormatDateTime(cmbAu.Value, DateFormat.ShortDate)

        Using report As New Printing.ReportAllRevenu(data_source, source, periode)
            report.ShowDialog()
        End Using
    End Sub
End Class