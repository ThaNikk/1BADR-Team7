Public Class Ordre

    Dim kunde As New Kunde()
    Dim db As New Database()

    Dim status As String
    Dim pID As String
    Dim antallBestillinger As Integer = 0

    'Tom konstruktør
    Public Sub New()

    End Sub

    Public Sub New(ByVal pID As String, ByVal status As String) 'Trenger en OrdreID... databasen genererer...
        Me.pID = pID
        Me.status = status
    End Sub

    'Registrer ordre
    Public Sub regOrdre()
        db.Query("INSERT INTO ordre (personID, status, antBestillinger) VALUES('" & pID & "', '" & status & "', '" & antallBestillinger & "')")
    End Sub

    'Slette ordre
    Public Sub sletteOrdre(ByVal ordreNR As String)
        db.Query("DELETE FROM ordre WHERE ordreNR = '" & ordreNR & "'")
    End Sub

    'Get last ordreNr
    Public Function getLastOrderNr()
        Return db.Query("SELECT MAX(ordreNR) FROM ordre")
    End Function

    'Update antall betillinger
    Public Sub updateAntBestillinger(ByVal ordreNR As String)
        Dim bestilling As New Bestilling()
        'Dim antall = bestilling.getAntBestillinger()
        Dim nyttAntall As Integer = bestilling.getAntallBestillinger()
        db.Query("UPDATE ordre SET antBestillinger = '" & nyttAntall & "' WHERE ordreNR = '" & ordreNR & "'")
    End Sub

    'Get alle ordre fra en person
    Public Function getAllFromPerson(ByVal id As String)
        Return db.Query("Select * FROM ordre, personer WHERE personer.personID = '" & id & "' AND personer.personID = ordre.personID")
    End Function



End Class
