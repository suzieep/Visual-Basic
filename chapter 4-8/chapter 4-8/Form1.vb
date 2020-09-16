Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then Label2.Text = RadioButton1.Text
        If RadioButton2.Checked = True Then Label2.Text = RadioButton2.Text
        If RadioButton3.Checked = True Then Label2.Text = RadioButton3.Text
        If RadioButton4.Checked = True Then Label2.Text = RadioButton4.Text
        If RadioButton5.Checked = True Then Label2.Text = RadioButton5.Text
        If RadioButton6.Checked = True Then Label2.Text = RadioButton6.Text
    End Sub
End Class
