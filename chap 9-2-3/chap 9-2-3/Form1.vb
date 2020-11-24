Public Class Form1
    Private Sub cboListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboListView.SelectedIndexChanged
        Select Case cboListView.SelectedIndex
            Case 0
                ListView1.View = View.LargeIcon
            Case 1
                ListView1.View = View.SmallIcon
            Case 2
                ListView1.View = View.List
            Case 3
                ListView1.View = View.Tile
            Case 4
                ListView1.View = View.Details
        End Select

    End Sub
End Class
