Public Class Bestilling

    Dim ordre As New Ordre()
    Dim db As New Database()

    Dim ordreNR As Integer
    Dim type As String
    Dim bestillingsliste As New ArrayList()

    'Tom konstruktør
    Public Sub New()

    End Sub

    Public Sub New(ByVal type As String, ByVal ordreNR As Integer)
        Me.type = type
        Me.ordreNR = ordreNR
    End Sub

    'Registrer bestilling
    Public Sub regBestilling()
        db.Query("INSERT INTO bestilling (type, ordreNR) VALUES('" & type & "', '" & ordreNR & "')")
        'ordre.updateAntBestillinger(ordreNR)
    End Sub

    'Legger bestillingene i en liste
    Public Sub leggTilBestilling(ByVal item As String)
        bestillingsliste.Add(item)
    End Sub

    'Returnerer bestillingene som en liste
    Public Function bestillingene()
        Return bestillingsliste
    End Function

    'Returnerer antall bstillinger på en ordre
    Public Function getAntallBestillinger()
        Return bestillingsliste.Count()
    End Function

    'Slette bestilling

End Class
