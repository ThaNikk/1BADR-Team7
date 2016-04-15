Public Class Person

    Protected db As New Database()

    Protected fornavn As String
    Protected etternavn As String
    Protected telefon As String
    Protected epost As String
    Protected postnr As String

    'Tom konstruktør
    Public Sub New()

    End Sub

    'Opprette objekt av person
    Public Sub New(ByVal fornavn As String, ByVal etternavn As String, ByVal telefon As String, ByVal epost As String, ByVal postnr As String)
        Me.fornavn = fornavn
        Me.etternavn = etternavn
        Me.telefon = telefon
        Me.epost = epost
        Me.postnr = postnr

    End Sub

    'registrere ny person
    Public Sub regPerson()
        db.Query("INSERT INTO personer(fornavn, etternavn, tlf, epost, postnr) VALUES('" & fornavn & "', '" & etternavn &
                 "', '" & telefon & "', '" & epost & "', '" & postnr & "')")
    End Sub

    'Slette person
    Public Sub slettePerson(ByVal personID As String)
        db.Query("DELETE FROM personer WHERE personID = '" & personID & "'")
    End Sub

    'Henter alle personer
    Public Function getAll()
        'Return db.Query("SELECT fornavn FROM personer WHERE personID = 2")
        Return db.Query("SELECT * FROM personer")
    End Function

    'Henter personID
    Public Function getPersonID(ByVal fornavn As String, ByVal etternavn As String, ByVal telefon As Integer, ByVal epost As String, ByVal postnr As Integer)
        Return db.Query("SELECT personID FROM personer WHERE fornavn = '" & fornavn & "' AND etternavn = '" & etternavn & "' AND tlf = '" & telefon & "' AND epost = '" & epost & "' AND postnr = '" & postnr & "'")
    End Function

    'Henter siste personID
    Public Function getLastPersonID()
        Return db.Query("SELECT MAX(personID) FROM personer")
    End Function

    'Henter personID utifra en string
    Public Function getPersonID2(sjekkString As String)

        Dim personID As String = ""

        Dim tabell As New DataTable

        Dim pID As Integer
        Dim fornavn As String
        Dim etternavn As String
        Dim tlf As String
        Dim epost As String
        Dim postnr As Integer

        tabell = getAll()
        For Each row In tabell.Rows
            pID = row("personID")
            fornavn = row("fornavn")
            etternavn = row("etternavn")
            tlf = row("tlf")
            epost = row("epost")
            postnr = row("postnr")

            If sjekkString = pID & ": " & fornavn & ", " & etternavn & ", " & tlf & ", " & epost & ", " & postnr Then
                personID = pID
            End If

        Next row
        Return personID
    End Function


End Class
