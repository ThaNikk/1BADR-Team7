Public Class Form2
    Dim bestilling As New Bestilling()
    Dim ordre As New Ordre()

    'Når bestillingsformet lastes
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbBestilling.Items.Add("Kurs")
        cbBestilling.Items.Add("Utstyr")
    End Sub

    'Registrerer vare
    Private Sub btnRegistrerVare_Click(sender As Object, e As EventArgs) Handles btnRegistrerVare.Click
        bestilling.leggTilBestilling(cbBestilling.SelectedItem.ToString())
        Dim liste As ArrayList = bestilling.bestillingene()
        ListBox1.Items.Add("VARE: " & cbBestilling.SelectedItem.ToString() & " ANTALL: " & teller.Value())
    End Sub

    'Ferdig med bestilling
    Private Sub btnRegBestilling_Click(sender As Object, e As EventArgs) Handles btnRegBestilling.Click

        Dim oNR As Integer

        Dim table As DataTable = ordre.getLastOrderNr()
        For Each row In table.Rows
            oNR = CInt(row(0).ToString())
        Next row


        For Each item In bestilling.bestillingene()
            Dim nyBestilling As New Bestilling(item.ToString(), oNR)
            nyBestilling.regBestilling()
        Next item

        ordre.updateAntBestillinger(ordre.getLastOrderNr().ToString())
        Me.Close()
    End Sub
End Class