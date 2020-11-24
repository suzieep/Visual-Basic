Public Class frmProgreeBar
    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Dim count As Integer = 1000
        pBar1.Visible = True
        pBar1.Minimum = 1
        pBar1.Maximum = count
        pBar1.Value = 1
        pBar1.Step = 1
        Dim x As Integer
        For x = 1 To count - 1
            pBar1.PerformStep()
        Next x

    End Sub
End Class
