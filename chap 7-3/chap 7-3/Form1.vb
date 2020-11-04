Public Class frmDomainUpDown
    Private Sub upDownList_SelectedItemChanged(sender As Object, e As EventArgs) Handles upDownList.SelectedItemChanged

        Select Case upDownList.SelectedIndex
            Case 0
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
            Case 1
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
            Case 2
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
            Case 3
                lblSelectedList.Text = upDownList.SelectedItem.ToString()
        End Select

    End Sub
End Class
