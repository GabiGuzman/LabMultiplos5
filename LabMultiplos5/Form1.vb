Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = TextBox1.Text
        If a Mod 5 Then
            TextBox2.Text = "No es un multiplo"
        Else
            TextBox2.Text = "Si es multiplo"
        End If
    End Sub
End Class
