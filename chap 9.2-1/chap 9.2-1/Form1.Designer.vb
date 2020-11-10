<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckedList
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
        Me.chkListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.chkListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.cmdCheckedList = New System.Windows.Forms.Button()
        Me.cmdCheckedCount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkListBox1
        '
        Me.chkListBox1.FormattingEnabled = True
        Me.chkListBox1.Items.AddRange(New Object() {"경영학", "비주얼베이직", "컴퓨터활용", "논리적 사고와 글쓰기", "영어회화"})
        Me.chkListBox1.Location = New System.Drawing.Point(52, 57)
        Me.chkListBox1.Name = "chkListBox1"
        Me.chkListBox1.Size = New System.Drawing.Size(120, 84)
        Me.chkListBox1.TabIndex = 0
        '
        'chkListBox2
        '
        Me.chkListBox2.FormattingEnabled = True
        Me.chkListBox2.Items.AddRange(New Object() {"경영학", "비주얼베이직", "컴퓨터활용", "논리적 사고와 글쓰기", "영어회화"})
        Me.chkListBox2.Location = New System.Drawing.Point(229, 57)
        Me.chkListBox2.Name = "chkListBox2"
        Me.chkListBox2.Size = New System.Drawing.Size(120, 84)
        Me.chkListBox2.TabIndex = 1
        '
        'cmdCheckedList
        '
        Me.cmdCheckedList.Location = New System.Drawing.Point(58, 167)
        Me.cmdCheckedList.Name = "cmdCheckedList"
        Me.cmdCheckedList.Size = New System.Drawing.Size(114, 23)
        Me.cmdCheckedList.TabIndex = 2
        Me.cmdCheckedList.Text = "선택 항목 보기 "
        Me.cmdCheckedList.UseVisualStyleBackColor = True
        '
        'cmdCheckedCount
        '
        Me.cmdCheckedCount.Location = New System.Drawing.Point(238, 167)
        Me.cmdCheckedCount.Name = "cmdCheckedCount"
        Me.cmdCheckedCount.Size = New System.Drawing.Size(111, 23)
        Me.cmdCheckedCount.TabIndex = 3
        Me.cmdCheckedCount.Text = "선택 항목 개수"
        Me.cmdCheckedCount.UseVisualStyleBackColor = True
        '
        'frmCheckedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdCheckedCount)
        Me.Controls.Add(Me.cmdCheckedList)
        Me.Controls.Add(Me.chkListBox2)
        Me.Controls.Add(Me.chkListBox1)
        Me.Name = "frmCheckedList"
        Me.Text = "선택한 항목 확인하기"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkListBox1 As CheckedListBox
    Friend WithEvents chkListBox2 As CheckedListBox
    Friend WithEvents cmdCheckedList As Button
    Friend WithEvents cmdCheckedCount As Button
End Class
