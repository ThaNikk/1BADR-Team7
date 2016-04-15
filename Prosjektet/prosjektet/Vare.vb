Public Class Vare
    Dim db As New Database()

    Dim varenr As String
    Dim statusvare As String
    Dim antallvare As Integer = 0

    'tom konstruktør
    Public Sub New()
    End Sub

    Public Sub New(ByVal varenr As String, ByVal statusvare As String)
        Me.varenr = varenr
        Me.statusvare = statusvare
    End Sub

    'søk etter vare
    Public Function varesøk(ByVal varenr As String)
        Return db.Query("SELECT * FROM vare WHERE vare.varenr= '" & varenr & "'")
    End Function

End Class

