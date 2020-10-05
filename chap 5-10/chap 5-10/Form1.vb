Public Class Form1
    Private intX, intY, Result As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        intX = Val(TextBox1.Text)
        intY = Val(TextBox2.Text)
        Result = intX * intY
        TextBox3.Text = Result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        intX = Val(TextBox1.Text)
        intY = Val(TextBox2.Text)
        Result = intX / intY
        TextBox3.Text = Result
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intX = Val(TextBox1.Text)
        intY = Val(TextBox2.Text)
        Result = intX - intY
        TextBox3.Text = Result
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intX = Val(TextBox1.Text)
        intY = Val(TextBox2.Text)
        Result = intX + intY
        TextBox3.Text = Result
    End Sub

End Class
