Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Text 속성"
        TextBox2.Visible = True
        TextBox3.BackColor = Color.Green
        TextBox4.PasswordChar = "%"
    End Sub
End Class
