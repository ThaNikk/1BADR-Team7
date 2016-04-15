Public Class SaleScreen

    Dim kunde As New Kunde()

    'Når selgergrenesnittet lastes.
    Private Sub SaleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viseKunder()
    End Sub

    'Når man trykker legg til kunde
    Private Sub btnLeggTilKunde_Click(sender As Object, e As EventArgs) Handles btnLeggTilKunde.Click
        Form3.Show()
    End Sub

    'Oppdaterer kundelisten
    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        viseKunder()
    End Sub

    'Slette kunde
    Private Sub btnSlettKunde_Click(sender As Object, e As EventArgs) Handles btnSlettKunde.Click

        Dim tabell As New DataTable

        Dim pID As Integer
        Dim fornavn As String
        Dim etternavn As String
        Dim tlf As Integer
        Dim epost As String
        Dim postnr As Integer

        tabell = kunde.getAll()
        For Each row In tabell.Rows
            pID = row("personID")
            fornavn = row("fornavn")
            etternavn = row("etternavn")
            tlf = row("tlf")
            epost = row("epost")
            postnr = row("postnr")

            If ListBox1.SelectedItem.ToString() = pID & ": " & fornavn & ", " & etternavn & ", " & tlf & ", " & epost & ", " & postnr Then
                kunde.slettePerson(pID)
            End If

        Next row

        viseKunder()
    End Sub


    'Hjelpemetoder

    'Viser kundene
    Private Sub viseKunder()
        Dim tabell As New DataTable

        Dim pID As Integer
        Dim fornavn As String
        Dim etternavn As String
        Dim tlf As Integer
        Dim epost As String
        Dim postnr As Integer

        ListBox1.Items.Clear()

        tabell = Kunde.getAlleKunder()
        For Each row In tabell.Rows
            pID = row("personID")
            fornavn = row("fornavn")
            etternavn = row("etternavn")
            tlf = row("tlf")
            epost = row("epost")
            postnr = row("postnr")
            ListBox1.Items.Add(pID & ": " & fornavn & ", " & etternavn & ", " & tlf & ", " & epost & ", " & postnr)
        Next row

    End Sub

    'Legger inn ordre
    Private Sub btnOrdre_Click(sender As Object, e As EventArgs) Handles btnOrdre.Click
        Dim nyOrdre As New Ordre(kunde.getPersonID2(ListBox1.SelectedItem), "Ikke levert")
        nyOrdre.regOrdre()
        Form2.Show()
    End Sub

    'Avslutter applikasjonen
    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt.Click
        Me.Close()
        Form1.Close()
    End Sub

    'Se statistikk
    Private Sub btnStatistikk_Click(sender As Object, e As EventArgs) Handles btnStatistikk.Click
        Statistikk.Show()
    End Sub
End Class