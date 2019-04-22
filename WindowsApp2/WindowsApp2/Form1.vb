Public Class Form1
    Dim out As String
    Dim contador = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        q0()
    End Sub
    Sub q0()
        If TextBox1.Text(contador) = "1" Then
            PictureBox1.Image = ImageList1.Images(1)
            out += "1"
            contador += "1"
            Label1.Text = out
            MsgBox("Se encuenta 1, se cambia a 1 y se deja Igual")
            Label2.Text = contador

            q0()
        ElseIf TextBox1.Text(contador) = " " Then
            PictureBox1.Image = ImageList1.Images(2)
            MsgBox("Se encuentra cadena vacia, se queda igual, se mueve a la izquierda")
            contador = contador - 1
            q1()



        ElseIf TextBox1.Text(contador) <> "1" Then
            MsgBox("NO SE ACEPTA LA CADENA")
            Label1.Text = ""
            TextBox1.Text = ""
            out = ""
            contador = 0
            PictureBox1.Image = ImageList1.Images(0)

        End If

    End Sub

    Sub q1()
        If TextBox1.Text(contador) = "1" Then
            PictureBox1.Image = ImageList1.Images(3)
            MsgBox("Se encuenta 1,se cambia a cadena vacia, se queda estatico")

            out = out.Remove(contador, 1)
            Label1.Text = out
            MsgBox("Estado final")
        End If
    End Sub
End Class
