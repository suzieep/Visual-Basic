Public Class Form1
    Dim func As New ArrayList()
    Dim cnt As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnt = 0
    End Sub

    Private Sub bu0_Click(sender As Object, e As EventArgs) Handles bu0.Click
        func.Add(0)
    End Sub

    Private Sub bu1_Click(sender As Object, e As EventArgs) Handles bu1.Click
        func.Add(1)
    End Sub

    Private Sub bu2_Click(sender As Object, e As EventArgs) Handles bu2.Click
        func.Add(2)
    End Sub

    Private Sub bu3_Click(sender As Object, e As EventArgs) Handles bu3.Click
        func.Add(3)
    End Sub

    Private Sub bu4_Click(sender As Object, e As EventArgs) Handles bu4.Click
        func.Add(4)
    End Sub

    Private Sub bu5_Click(sender As Object, e As EventArgs) Handles bu5.Click
        func.Add(5)
    End Sub

    Private Sub bu6_Click(sender As Object, e As EventArgs) Handles bu6.Click
        func.Add(6)
    End Sub

    Private Sub bu7_Click(sender As Object, e As EventArgs) Handles bu7.Click
        func.Add(7)
    End Sub

    Private Sub bu8_Click(sender As Object, e As EventArgs) Handles bu8.Click
        func.Add(8)
    End Sub

    Private Sub bu9_Click(sender As Object, e As EventArgs) Handles bu9.Click
        func.Add(9)
    End Sub

    Private Sub buSum_Click(sender As Object, e As EventArgs) Handles buSum.Click
        func.Add(1)
    End Sub

    Private Sub buMi_Click(sender As Object, e As EventArgs) Handles buMi.Click
        func.Add("-")
    End Sub

    Private Sub buMul_Click(sender As Object, e As EventArgs) Handles buMul.Click
        func.Add("*")
    End Sub

    Private Sub buDiv_Click(sender As Object, e As EventArgs) Handles buDiv.Click
        func.Add("/")
    End Sub

    Private Sub buC_Click(sender As Object, e As EventArgs) Handles buC.Click
        func.Clear()
        labInput.Text = ""
    End Sub

    Private Sub buEqual_Click(sender As Object, e As EventArgs) Handles buEqual.Click
        Dim inputs As String
        inputs = ""
        labInput.Text = ""
        For i = 0 To func.Count - 1 Step 1
            inputs = inputs & CStr(func(i))
        Next
        labInput.Text = inputs
    End Sub
End Class
