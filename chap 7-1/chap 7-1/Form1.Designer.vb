<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicColor
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
        Me.picColor = New System.Windows.Forms.PictureBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.hsbRed = New System.Windows.Forms.HScrollBar()
        Me.hsbGreen = New System.Windows.Forms.HScrollBar()
        Me.hsbBlue = New System.Windows.Forms.HScrollBar()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picColor
        '
        Me.picColor.Location = New System.Drawing.Point(47, 66)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(140, 132)
        Me.picColor.TabIndex = 0
        Me.picColor.TabStop = False
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Location = New System.Drawing.Point(208, 80)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(37, 12)
        Me.lblRed.TabIndex = 1
        Me.lblRed.Text = "빨강 :"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Location = New System.Drawing.Point(208, 123)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(37, 12)
        Me.lblGreen.TabIndex = 2
        Me.lblGreen.Text = "초록 :"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(208, 164)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(37, 12)
        Me.lblBlue.TabIndex = 3
        Me.lblBlue.Text = "파랑 :"
        '
        'hsbRed
        '
        Me.hsbRed.Location = New System.Drawing.Point(262, 76)
        Me.hsbRed.Maximum = 255
        Me.hsbRed.Name = "hsbRed"
        Me.hsbRed.Size = New System.Drawing.Size(144, 19)
        Me.hsbRed.TabIndex = 4
        '
        'hsbGreen
        '
        Me.hsbGreen.Location = New System.Drawing.Point(262, 118)
        Me.hsbGreen.Maximum = 255
        Me.hsbGreen.Name = "hsbGreen"
        Me.hsbGreen.Size = New System.Drawing.Size(144, 19)
        Me.hsbGreen.TabIndex = 5
        '
        'hsbBlue
        '
        Me.hsbBlue.Location = New System.Drawing.Point(262, 157)
        Me.hsbBlue.Maximum = 255
        Me.hsbBlue.Name = "hsbBlue"
        Me.hsbBlue.Size = New System.Drawing.Size(144, 19)
        Me.hsbBlue.TabIndex = 6
        '
        'frmPicColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.hsbBlue)
        Me.Controls.Add(Me.hsbGreen)
        Me.Controls.Add(Me.hsbRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.picColor)
        Me.Name = "frmPicColor"
        Me.Text = "픽처박스 컨트롤 색 변경하"
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picColor As PictureBox
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents hsbRed As HScrollBar
    Friend WithEvents hsbGreen As HScrollBar
    Friend WithEvents hsbBlue As HScrollBar
End Class
