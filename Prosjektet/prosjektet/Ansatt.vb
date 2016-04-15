Public Class ansatt

    Inherits Person

    Protected lonn As String
    Protected ansattID As String
    'Tom konstruktør
    Public Sub New()
    End Sub

    'ByVal ansattnummer As Integer
    Public Sub New(ByVal fornavn As String, ByVal etternavn As String, ByVal telefon As String, ByVal epost As String, ByVal postnr As String)
        MyBase.New(fornavn, etternavn, telefon, epost, postnr)
        'Me.ansattnummer = ansattnummer
    End Sub

    'Registrer kunde
    Public Sub Regansatt()
        regPerson()
        'Dim pID As DataTable = getPersonID(fornavn, etternavn, telefon, epost, postnr)
        Dim pID As DataTable = getLastPersonID()
        Dim personID As String = ""

        For Each id In pID.Rows
            personID = id(0).ToString()
        Next id

        db.Query("INSERT INTO ansatt(personID) VALUES('" & personID & "')")

    End Sub

    'Hent ansatt ut fra personID
    Public Function getAnsatt(ByVal id As String)
        Return db.Query("SELECT * FROM personer, ansatt WHERE personer.personID = '" & id & "' AND ansatt.personID = '" & id & "' AND personer.personID = ansatt.personID")
    End Function

    'Henter alle ansatte
    Public Function getAlleAnsatte()
        Return db.Query("SELECT * FROM personer, ansatt WHERE personer.personID = ansatt.personID")
    End Function

    'Slett ansatt
    Public Sub sletteAnsatt(ByVal personID As String)
        db.Query("DELETE FROM ansatt WHERE personID  = '" & personID & "'")
    End Sub

    Public Function getBruker()
        Return db.Query("SELECT bruker from ansatt")
    End Function
    Public Function getPassord()
        Return db.Query("SELECT passord from ansatt WHERE passord.ansattID = bruker.ansattID")
    End Function

    Public Function getAvdeling()
        Return db.Query("SELECT avdeling from ansatt WHERE bruker.ansattID = avdeling.ansattID")
    End Function
End Class
