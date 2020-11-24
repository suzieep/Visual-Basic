Public Class Form1
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim txtContent As String
        lblDisp.Text = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtContent = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            lblDisp.Text = lblDisp.Text & OpenFileDialog1.FileName & vbCrLf & txtContent
        End If

    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Dim saveFileName As String

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            saveFileName = SaveFileDialog1.FileName
            lblDisp.Text = lblDisp.Text & vbCrLf & "저장된 파일에는 이 내용이 추가됩니다~"
            My.Computer.FileSystem.WriteAllText(saveFileName, lblDisp.Text, True)
        End If

    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            lblDisp.Font = FontDialog1.Font
            lblDisp.ForeColor = FontDialog1.Color
        End If

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply
        lblDisp.Font = FontDialog1.Font
        lblDisp.ForeColor = FontDialog1.Color

    End Sub

    Private Sub mnuColor_Click(sender As Object, e As EventArgs) Handles mnuColor.Click
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lblDisp.ForeColor = ColorDialog1.Color
        End If

    End Sub
End Class
