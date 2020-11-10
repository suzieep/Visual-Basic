Public Class frmCheckedList
    Private Sub chkListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkListBox1.SelectedIndexChanged

    End Sub

    Private Sub cmdCheckedList_Click(sender As Object, e As EventArgs) Handles cmdCheckedList.Click
        Dim i As Integer
        Dim CheckedList As String = ""
        If chkListBox1.CheckedItems.Count <> 0 Then
            For i = 0 To chkListBox1.CheckedItems.Count - 1
                CheckedList = CheckedList & "Checked List : " & (i + 1).ToString &
                               " = " & chkListBox1.CheckedItems(i).ToString & vbCrLf
                'CheckedList = ChekedList & ~~ 인 이유는 CheckedList String에 누적해서 글을 담기 위해서이다
            Next i
            MessageBox.Show(CheckedList)
        End If
    End Sub

    Private Sub cmdCheckedCount_Click(sender As Object, e As EventArgs) Handles cmdCheckedCount.Click
        Dim i, SelectedCount As Integer
        For i = 0 To (chkListBox2.Items.Count - 1)
            If chkListBox2.GetItemChecked(i) = True Then
                SelectedCount = SelectedCount + 1
            End If
        Next
        MessageBox.Show("Checked Count :" & SelectedCount)
    End Sub
End Class
