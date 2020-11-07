Public Class frmGugudan
    Private Sub frmGugudan_Leave(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, r1, c1 As Integer
        Dim result(9, 9) As Integer
        For r1 = 0 To 8 Step 1
            For r2 = 0 To 8 Step 1
                result(r1, r2) = IIf((r1 + 1) * (r2 + 1) < 10, " " &
                       (r1 + 1) * (r2 + 1), (r1 + 1) * (r2 + 1))
            Next r2
        Next r1
        lblOutput.Text = ""
        For i = 1 To 9 Step 1
            lblOutput.Text = lblOutput.Text & Space(5) & i & "단" & Space(8)
        Next
        lblOutput.Text = lblOutput.Text & vbCrLf
        For r1 = 0 To 8 Step 1
            For r2 = 0 To 8 Step 1
                lblOutput.Text = lblOutput.Text & (r1 + 1) & " * " & (r2 + 1) & " = " & result(r1, r2) & Space(5)
            Next r2
            lblOutput.Text = lblOutput.Text & vbCrLf
        Next r1
    End Sub

End Class
