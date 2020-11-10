Public Class frmCalendar
    Private Sub cmdSet_Click(sender As Object, e As EventArgs) Handles cmdSet.Click
        Dim today As Date = DateTimePicker1.Text
        Dim selectYear As Integer = today.Year
        Dim selectMonth As Integer = today.Month
        Dim selectDay As Integer = today.Day
        MonthCalendar1.TodayDate = New Date(selectYear, selectMonth, selectDay)
        lblDisplay.Text = DateTimePicker1.Text
    End Sub

    Private Sub cmdWeek_Click(sender As Object, e As EventArgs) Handles cmdWeek.Click
        Dim today As Date = MonthCalendar1.TodayDate
        Dim selectMonth As Integer = today.Month
        Dim selectYear As Integer = today.Year
        If (today.Month = 12) Then
            selectYear += 1
            selectMonth = 1
        End If
        MonthCalendar1.SelectionStart = New Date(selectYear, selectMonth, today.Day)
        MonthCalendar1.SelectionEnd = New Date(selectYear, selectMonth, today.Day + 6)
        lblDisplay.Text = MonthCalendar1.SelectionStart & "에서 " & MonthCalendar1.SelectionEnd & "까지의 날짜를 선택하셨습니다."
    End Sub
    Private Sub cmdMonthlySet_Click(sender As Object, e As EventArgs) Handles cmdMonthlySet.Click
        Dim boldDate1 As Date = New DateTime(2020, 11, 10)
        Dim boldDate2 As Date = New DateTime(2020, 12, 10)
        MonthCalendar1.AddBoldedDate(boldDate1)
        MonthCalendar1.AddBoldedDate(boldDate2)
    End Sub

End Class
