Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y As Boolean
        x = True
        y = False
        TextBox1.Text = "x And y :" & CStr(x And y) & vbCrLf & "x Or y :" & CStr(x Or y) & vbCrLf & "x Xor y : " & CStr(x Xor y) & vbCrLf & "Not x :" & CStr(Not x) & vbCrLf & "x Andalso y :" & CStr(x AndAlso y) & vbCrLf & "x OrElse y :" & CStr(x OrElse y)
    End Sub
End Class
