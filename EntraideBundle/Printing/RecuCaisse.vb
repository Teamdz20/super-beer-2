Imports EntraideBundle.Printing.Recu
Imports MySql.Data.MySqlClient
Imports EntraideBundle.Db
Imports Microsoft.Reporting.WinForms

Namespace Printing
    Public Class RecuCaisse


        Private mRecu As Recu

        Public Sub New(recu As Recu)

            ' Cet appel est requis par le concepteur.
            InitializeComponent()

            ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
            mRecu = recu
        End Sub

        Public Sub New()

            ' Cet appel est requis par le concepteur.
            InitializeComponent()

            ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        End Sub

        Private Sub RecuCaisse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshReport()
        End Sub

        Private Sub RefreshReport()
            Using cmd As MySqlCommand = Database.GetCommand
                cmd.CommandText = mRecu.sql
                Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As New DataSetTables
                adapter.Fill(ds.RecuCaisse)

                With Report.LocalReport
                    .ReportPath = System.Environment.CurrentDirectory & "\reports\RecuCaisse.rdlc"
                    .SetParameters(New ReportParameter("rptNom", mRecu.nom))
                    .SetParameters(New ReportParameter("rptAdresse", mRecu.adresse))
                    .SetParameters(New ReportParameter("rptTel", mRecu.tel))
                    .SetParameters(New ReportParameter("rptTotal", mRecu.cout_total))
                    .SetParameters(New ReportParameter("rptMontantPayer", mRecu.montant_payer))
                    .SetParameters(New ReportParameter("rptReste", mRecu.reste))
                    .SetParameters(New ReportParameter("rptTva", 0))
                    .SetParameters(New ReportParameter("rptAutre", 0))
                    .DataSources.Clear()
                    .DataSources.Add(New ReportDataSource("DataSetTables", CType(ds.RecuCaisse, DataTable)))
                End With

                With Report
                    .ZoomMode = ZoomMode.PageWidth
                    .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                    .RefreshReport()
                End With

            End Using
        End Sub

    End Class

    ''' <summary>
    ''' Description du recu
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Recu

        Enum TYPE_RECU
            ETUDIANT = 1
            DON = 2
            AGR = 3
        End Enum

        Private _id As String

        Private _nom As String

        Private _adresse As String

        Private _tel As String

        Private _cout_total As String

        Private _montant_payer As String

        Private _reste As String

        Private _type_recu As TYPE_RECU

        Public Sub New(id As String, montant_payer As String, type As TYPE_RECU)
            Me._id = id
            _type_recu = type
            If type = TYPE_RECU.ETUDIANT Then
                GetDetailsEtudiant()
            ElseIf type = TYPE_RECU.AGR Then
                GetDetailsEmployes()
            ElseIf type = TYPE_RECU.DON Then
                GetDetailsDonneur()
            Else
                Throw New Exception("Type de recu inconnu")
            End If
        End Sub

        ''' <summary>
        ''' Recupere les informations de etudiants
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub GetDetailsEtudiant()

            Try
                Database.Query("SELECT CONCAT_WS(' ', etudiants.nom, etudiants.prenom) AS nom, etudiants.adresse, etudiants.tel1, revenu.montant, SUM(paiement.montant_paye) AS montant_payer FROM etudiants INNER JOIN formations ON formations.id_etudiant = etudiants.id INNER JOIN revenu ON formations.id = revenu.ref_id INNER JOIN paiement ON revenu.id = paiement.id_revenu WHERE revenu.id = '" & id & "' GROUP BY revenu.id")
                Dim result = Database.ExecuteResult

                If result.HasRows Then
                    result.Read()
                    _nom = result("nom")
                    _adresse = result("adresse")
                    _tel = result("tel1")
                    _cout_total = result("montant")
                    _montant_payer = result("montant_payer")
                End If
                result.Close()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        ''' <summary>
        ''' Get infos Employes
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub GetDetailsEmployes()
            Try
                Database.Query("SELECT CONCAT_WS(' ', employes.nom, employes.prenom) AS nom, employes.adresse, employes.tel1, revenus.montant FROM employes INNER JOIN revenus ON employes.id = revenus.id_employe WHERE revenus.id = '" & id & "'")
                Dim result = Database.ExecuteResult

                If result.HasRows Then
                    result.Read()
                    _nom = result("nom")
                    _adresse = result("adresse")
                    _tel = result("tel1")
                    _cout_total = result("montant")
                    _montant_payer = result("montant")
                End If
                result.Close()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        ''' <summary>
        ''' Get infos donneur
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub GetDetailsDonneur()
            Try
                Database.Query("SELECT donneurs.nom AS nom, donneurs.adresse, donneurs.tel1, dons.montant_recu AS montant FROM donneurs INNER JOIN dons ON donneurs.id = dons.donneur_id WHERE dons.id = '" & id & "'")
                Dim result = Database.ExecuteResult

                If result.HasRows Then
                    result.Read()
                    _nom = result("nom")
                    _adresse = result("adresse")
                    _tel = result("tel1")
                    _cout_total = result("montant")
                    _montant_payer = result("montant")
                End If
                result.Close()
            Catch ex As Exception
                If My.Settings.app_debug_mode Then
                    Util.ShowMessage(ex.ToString, 2)
                Else
                    Util.ShowMessage("Fatal error : " & ex.ToString, 2)
                End If
            Finally
                Database.CloseConnection()
            End Try
        End Sub

        Public ReadOnly Property id As String
            Get
                Return _id
            End Get
        End Property

        Public ReadOnly Property nom As String
            Get
                Return _nom
            End Get
        End Property

        Public ReadOnly Property adresse As String
            Get
                Return _adresse
            End Get
        End Property

        Public ReadOnly Property tel As String
            Get
                Return _tel
            End Get
        End Property

        Public ReadOnly Property cout_total As String
            Get
                Return _cout_total
            End Get
        End Property

        Public ReadOnly Property montant_payer As String
            Get
                Return _montant_payer
            End Get
        End Property

        Public ReadOnly Property reste As String
            Get
                Return _reste
            End Get
        End Property

        Public Property type As TYPE_RECU
            Get
                If IsNothing(_type_recu) Then
                    _type_recu = TYPE_RECU.ETUDIANT
                End If
                Return _type_recu
            End Get
            Set(value As TYPE_RECU)
                _type_recu = value
            End Set
        End Property


        Private _sql As String

        Public ReadOnly Property sql
            Get
                If type = TYPE_RECU.ETUDIANT Then
                    _sql = "SELECT paiement.created AS 'date', 'Paiement frais scolaire' AS 'designation', 1 AS 'qte', paiement.montant_paye AS 'pu', (1* montant_paye) AS 'total' FROM paiement WHERE paiement.id_revenu = '" & _id & "' ORDER BY paiement.created DESC LIMIT 1"
                ElseIf type = TYPE_RECU.AGR Then
                    _sql = "SELECT revenus.date_revenu AS 'date', revenus.reglement AS 'designation', 1 AS 'qte', revenus.montant AS 'pu', revenus.montant AS 'total' FROM revenus WHERE id = '" & _id & "'"
                ElseIf type = TYPE_RECU.DON Then
                    _sql = "SELECT dons.created AS 'date', dons.activite_menee AS 'designation', 1 AS 'qte', dons.montant_recu AS 'pu', dons.montant_recu AS 'total' FROM dons WHERE id = '" & _id & "'"
                End If
                Return _sql
            End Get
        End Property
    End Class
End Namespace