<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.cmdWeek = New System.Windows.Forms.Button()
        Me.cmdMonthlySet = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 63)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'cmdSet
        '
        Me.cmdSet.Location = New System.Drawing.Point(271, 61)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdSet.TabIndex = 1
        Me.cmdSet.Text = "설정"
        Me.cmdSet.UseVisualStyleBackColor = True
        '
        'cmdWeek
        '
        Me.cmdWeek.Location = New System.Drawing.Point(271, 115)
        Me.cmdWeek.Name = "cmdWeek"
        Me.cmdWeek.Size = New System.Drawing.Size(75, 23)
        Me.cmdWeek.TabIndex = 2
        Me.cmdWeek.Text = "1주일 선택"
        Me.cmdWeek.UseVisualStyleBackColor = True
        '
        'cmdMonthlySet
        '
        Me.cmdMonthlySet.Location = New System.Drawing.Point(271, 173)
        Me.cmdMonthlySet.Name = "cmdMonthlySet"
        Me.cmdMonthlySet.Size = New System.Drawing.Size(75, 23)
        Me.cmdMonthlySet.TabIndex = 3
        Me.cmdMonthlySet.Text = "매달 반복 설정"
        Me.cmdMonthlySet.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(390, 49)
        Me.MonthCalendar1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar1.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(291, 247)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 12)
        Me.lblDisplay.TabIndex = 5
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.cmdMonthlySet)
        Me.Controls.Add(Me.cmdWeek)
        Me.Controls.Add(Me.cmdSet)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmCalendar"
        Me.Text = "Calendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmdSet As Button
    Friend WithEvents cmdWeek As Button
    Friend WithEvents cmdMonthlySet As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lblDisplay As Label
End Class
