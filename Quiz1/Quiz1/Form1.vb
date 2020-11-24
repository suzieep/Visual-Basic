Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        Dim a2 As Integer
        Dim b2 As Integer
        Dim c2 As Integer

        a2 = (TextBox2.Text) ^ 2
        b2 = (TextBox3.Text) ^ 2
        c2 = (TextBox1.Text) ^ 2

        If a2 + b2 = c2 Then
            result = "입력한 삼각형은 직각 삼각형입니다."

        Else
            result = "입력한 삼각형은 직각 삼각형이 아닙니다."

        End If

        MessageBox.Show(result, "QUIZ1104")
    End Sub
End Class
