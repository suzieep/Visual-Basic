<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgressBar
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
        Me.components = New System.ComponentModel.Container()
        Me.pBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pBar1
        '
        Me.pBar1.Location = New System.Drawing.Point(46, 75)
        Me.pBar1.Name = "pBar1"
        Me.pBar1.Size = New System.Drawing.Size(400, 23)
        Me.pBar1.TabIndex = 0
        '
        'lblDisp
        '
        Me.lblDisp.AutoSize = True
        Me.lblDisp.Location = New System.Drawing.Point(60, 118)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(0, 12)
        Me.lblDisp.TabIndex = 1
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(175, 150)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 2
        Me.cmdStart.Text = "시작~"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.pBar1)
        Me.Name = "frmProgressBar"
        Me.Text = "ProgressBar 컨트롤 사용하기"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pBar1 As ProgressBar
    Friend WithEvents lblDisp As Label
    Friend WithEvents cmdStart As Button
    Friend WithEvents Timer1 As Timer
End Class
