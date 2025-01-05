Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        'Mascaras de Entrada 
        If MaskedTextBox1.Text = "555-55-1212" _
        And MaskedTextBox2.Text = "54321" Then
            MsgBox("¡Bienvenido al sistema!")
        Else
            MsgBox("Número irreconocible")
        End If
    End Sub
End Class
