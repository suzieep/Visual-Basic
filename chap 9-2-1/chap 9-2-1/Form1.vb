Public Class frmProgressBar
    Private Sub frmProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Timer1.Interval = 250
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pBar1.Increment(1)
        lblDisp.Text = pBar1.Value.ToString() + "% Completed"
        If pBar1.Value = pBar1.Maximum Then
            Timer1.Stop()
        End If
    End Sub
End Class
