Public Class frmDynamicArray
    Private Sub frmDynamicArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intArray() As Integer
        Dim i As Integer
        ReDim intArray(5)
        For i = 1 To 5
            intArray(i) = i
        Next
        lblDisplay.Text = lblDisplay.Text & "intArray 배열의 값 출력~" & vbCrLf
        For i = 1 To 5
            lblDisplay.Text = lblDisplay.Text & "intArray(" & i & ") = " & intArray(i) & vbCrLf
        Next
        lblDisplay.Text = lblDisplay.Text & vbCrLf
        ReDim Preserve intArray(UBound(intArray) + 2)
        For i = UBound(intArray) - 1 To UBound(intArray)
            intArray(i) = i * 10
        Next
        lblDisplay.Text = lblDisplay.Text & "동적배열 intArray 배열의 값 출력~" & vbCrLf
        For i = 1 To UBound(intArray)
            lblDisplay.Text = lblDisplay.Text & "intArray(" & i & ") = " & intArray(i) & vbCrLf
        Next
    End Sub
End Class
