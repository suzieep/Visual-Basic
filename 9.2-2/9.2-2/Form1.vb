Public Class frmRichText
    Private Sub frmRichText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 8 To 50 Step 2
            cboFontSize.Items.Add(i)
        Next
        cboFontColor.Items.Add("빨강")
        cboFontColor.Items.Add("파랑")
        cboFontColor.Items.Add("노랑")
        cboFontColor.Items.Add("다홍")
        cboFontColor.Items.Add("보라")
        cboFontColor.Items.Add("초록")
        cboFontSize.Text = "크기 선택"
        cboFontColor.Text = "색 선택"
    End Sub


    Private Sub cboFontSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFontSize.SelectedIndexChanged
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, Val(cboFontSize.Text))
    End Sub

    Private Sub cboFontColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFontColor.SelectedIndexChanged
        RichTextBox1.SelectAll()
        Select Case cboFontColor.SelectedIndex
            Case 0
                RichTextBox1.SelectionColor = Color.Red
            Case 1
                RichTextBox1.SelectionColor = Color.Blue
            Case 2
                RichTextBox1.SelectionColor = Color.Yellow
            Case 3
                RichTextBox1.SelectionColor = Color.Magenta
            Case 4
                RichTextBox1.SelectionColor = Color.Purple
            Case 5
                RichTextBox1.SelectionColor = Color.Green
        End Select
    End Sub

    Private Sub optBold_CheckedChanged(sender As Object, e As EventArgs) Handles optBold.CheckedChanged
        Dim sizefont As Integer
        sizefont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizefont, FontStyle.Bold)
    End Sub
    Private Sub optItalic_CheckedChanged(sender As Object, e As EventArgs) Handles optItalic.CheckedChanged
        Dim sizefont As Integer
        sizefont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizefont, FontStyle.Italic)
    End Sub
    Private Sub optStrikeThru_CheckedChanged(sender As Object, e As EventArgs) Handles optStrikeThru.CheckedChanged
        Dim sizefont As Integer
        sizefont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizefont, FontStyle.Strikeout)
    End Sub
    Private Sub optUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles optUnderline.CheckedChanged
        Dim sizefont As Integer
        sizefont = Val(cboFontSize.Text)
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionFont = New Font(FontFamily.GenericSerif, sizefont, FontStyle.Underline)
    End Sub
End Class