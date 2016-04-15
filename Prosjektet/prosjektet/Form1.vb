Public Class Form1

    Dim brukernavn As New ansatt()
    Dim passord As New ansatt()
    Dim forsok As Integer = 3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim brukernavn = TextBox1.Text
        Dim passord = TextBox2.Text
        Dim sqlSporring = "select * from brukere where brukernavn = @brukernavn " & "and passord=@passord"

        Dim sql As New MySqplCommand(sqlSporring)

        sql.Parameters.AddWithValue("@brukernavn", brukernavn)
        sql.Parameters.AddWithValue("@passord", passord)

        Do
            forsok -= 1
        Loop Until TextBox1.Text = brukernavn.getBruker And TextBox2.Text = passord.getPassord And forsok <= 0
        TextBox1.Clear()
        TextBox2.Clear()

        If brukernavn = 
    End Sub
End Class