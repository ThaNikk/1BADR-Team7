Public Class RegistrereKunde

    'Bekreft registrering av kunde
    Private Sub btnRegKundeBekreft_Click(sender As Object, e As EventArgs) Handles btnRegKundeBekreft.Click

        Dim nyKunde As New Kunde(txtFornavn.Text, txtEtternavn.Text, txtEpost.Text, txtTlf.Text, txtPostnr.Text)
        nyKunde.RegKunde()

        'Cleaner inputfeltene etter at personen er registrert.
        txtFornavn.Clear()
        txtEtternavn.Clear()
        txtEpost.Clear()
        txtTlf.Clear()
        txtPostnr.Clear()

        Me.Close()

    End Sub

End Class