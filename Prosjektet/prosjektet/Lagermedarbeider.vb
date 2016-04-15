Public Class Lagermedarbeider

    Inherits ansatt

    Dim vare As New Vare()

    'tom konstruktør
    Public Sub New()
    End Sub
    Public Sub New(ByVal fornavn As String, ByVal etternavn As String, ByVal telefon As String, ByVal epost As String, ByVal postnr As String, ByVal lonn As String, ByVal ansattID As String)
        MyBase.New(fornavn, etternavn, telefon, epost, postnr, lonn, ansattID)
    End Sub
End Class
