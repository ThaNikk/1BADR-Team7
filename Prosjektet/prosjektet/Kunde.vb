Public Class Kunde

    Inherits Person

    'Tom konstruktør
    Public Sub New()
    End Sub

    'ByVal kundenummer As Integer
    Public Sub New(ByVal fornavn As String, ByVal etternavn As String, ByVal telefon As String, ByVal epost As String, ByVal postnr As String)
        MyBase.New(fornavn, etternavn, telefon, epost, postnr)
        'Me.kundenummer = kundenummer
    End Sub

    'Registrer kunde
    Public Sub RegKunde()
        regPerson()
        'Dim pID As DataTable = getPersonID(fornavn, etternavn, telefon, epost, postnr)
        Dim pID As DataTable = getLastPersonID()
        Dim personID As String = ""

        For Each id In pID.Rows
            personID = id(0).ToString()
        Next id

        db.Query("INSERT INTO kunder(personID) VALUES('" & personID & "')")

    End Sub

    'Hent kunde ut fra personID
    Public Function getKunde(ByVal id As String)
        Return db.Query("SELECT * FROM personer, kunder WHERE personer.personID = '" & id & "' AND kunder.personID = '" & id & "' AND personer.personID = kunder.personID")
    End Function

    'Henter alle kunder
    Public Function getAlleKunder()
        Return db.Query("SELECT * FROM personer, kunder WHERE personer.personID = kunder.personID")
    End Function

    'Slett kunde
    Public Sub sletteKunde(ByVal personID As String)
        db.Query("DELETE FROM kunde WHERE personID  = '" & personID & "'")
    End Sub

End Class
