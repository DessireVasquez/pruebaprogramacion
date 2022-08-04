Public Class FrmColores
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        TxtColores.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtColores.BackColor = Color.Blue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxtColores.BackColor = Color.Yellow

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TxtColores.BackColor = Color.Black

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TxtColores.BackColor = Color.Pink

    End Sub
End Class
