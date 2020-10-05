Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "23 = 25 :" & CStr(23 = 25) & vbCrLf & "24 <> 24 :" & CStr(24 <> 24) & vbCrLf & "31 > 33 :" & CStr(31 > 33) & vbCrLf & "11>=10 :" & CStr(11 >= 10) & vbCrLf & "9 < 15 :" & CStr(9 < 15) & vbCrLf & "21 <= 21 :" & CStr(21 <= 21) & vbCrLf & "Basic Like Basi :" & CStr("Basic" Like "Basi")
    End Sub
End Class
