Public Class Statistikk

    Dim kunde As New Kunde()
    Dim ordre As New Ordre()

    'Når statistikkformet lastes
    Private Sub Statistikk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim kundeListe As New ArrayList
        Dim kunder As DataTable = kunde.getAlleKunder()

        Dim pID As String
        Dim fornavn As String
        Dim etternavn As String
        Dim tlf As Integer
        Dim epost As String
        Dim postnr As Integer

        For Each row In kunder.Rows
            pID = row("personID")
            fornavn = row("fornavn")
            etternavn = row("etternavn")
            tlf = row("tlf")
            epost = row("epost")
            postnr = row("postnr")
            kundeListe.Add(pID & ": " & fornavn & ", " & etternavn & ", " & tlf & ", " & epost & ", " & postnr)
        Next row

        For Each item In kundeListe
            cbStatistikk.Items.Add(item.ToString())
        Next item
    End Sub

    'Når comboboksen endres
    Private Sub cbStatistikk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatistikk.SelectedIndexChanged


        'Dim navn As String = ordre.g

        'lbStatistikk.Items.Add(cbStatistikk.SelectedItem.ToString())

        getAlleOrdre()
    End Sub

    'Alle ordre fra en person
    Private Sub getAlleOrdre()

        Dim kundeNR As String

        kundeNR = kunde.getPersonID2(cbStatistikk.SelectedItem.ToString())

        Dim tabell As New DataTable

        Dim oNR As Integer
        Dim pID As Integer
        Dim status As String
        Dim antBestillinger As Integer

        lbStatistikk.Items.Clear()

        tabell = ordre.getAllFromPerson(kundeNR)
        For Each row In tabell.Rows
            oNR = row("ordreNR")
            pID = row("personID")
            status = row("status")
            antBestillinger = row("antBestillinger")
            lbStatistikk.Items.Add(oNR & ": " & pID & ", " & status & ", " & antBestillinger)
        Next row


    End Sub

End Class