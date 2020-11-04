Public Class frmPicColor
    Private Sub hsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbRed.Scroll
        picColor.BackColor = Color.FromArgb(255, hsbRed.Value, hsbGreen.Value, hsbBlue.Value)

    End Sub

    Private Sub hsbGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbGreen.Scroll
        picColor.BackColor = Color.FromArgb(255, hsbRed.Value, hsbGreen.Value, hsbBlue.Value)

    End Sub

    Private Sub hsbBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbBlue.Scroll
        picColor.BackColor = Color.FromArgb(255, hsbRed.Value, hsbGreen.Value, hsbBlue.Value)

    End Sub
End Class
