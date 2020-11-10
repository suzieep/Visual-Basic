<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRichText
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
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblFontColor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFontSize = New System.Windows.Forms.ComboBox()
        Me.cboFontColor = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupFont = New System.Windows.Forms.GroupBox()
        Me.optBold = New System.Windows.Forms.RadioButton()
        Me.optItalic = New System.Windows.Forms.RadioButton()
        Me.optStrikeThru = New System.Windows.Forms.RadioButton()
        Me.optUnderline = New System.Windows.Forms.RadioButton()
        Me.GroupFont.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(35, 87)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(65, 12)
        Me.lblFontSize.TabIndex = 0
        Me.lblFontSize.Text = "글꼴 크기 :"
        '
        'lblFontColor
        '
        Me.lblFontColor.AutoSize = True
        Me.lblFontColor.Location = New System.Drawing.Point(35, 140)
        Me.lblFontColor.Name = "lblFontColor"
        Me.lblFontColor.Size = New System.Drawing.Size(53, 12)
        Me.lblFontColor.TabIndex = 1
        Me.lblFontColor.Text = "글꼴 색 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 12)
        Me.Label3.TabIndex = 2
        '
        'cboFontSize
        '
        Me.cboFontSize.FormattingEnabled = True
        Me.cboFontSize.Location = New System.Drawing.Point(37, 102)
        Me.cboFontSize.Name = "cboFontSize"
        Me.cboFontSize.Size = New System.Drawing.Size(121, 20)
        Me.cboFontSize.TabIndex = 3
        '
        'cboFontColor
        '
        Me.cboFontColor.FormattingEnabled = True
        Me.cboFontColor.Location = New System.Drawing.Point(37, 155)
        Me.cboFontColor.Name = "cboFontColor"
        Me.cboFontColor.Size = New System.Drawing.Size(121, 20)
        Me.cboFontColor.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(212, 79)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(218, 238)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'GroupFont
        '
        Me.GroupFont.Controls.Add(Me.optUnderline)
        Me.GroupFont.Controls.Add(Me.optStrikeThru)
        Me.GroupFont.Controls.Add(Me.optItalic)
        Me.GroupFont.Controls.Add(Me.optBold)
        Me.GroupFont.Location = New System.Drawing.Point(37, 185)
        Me.GroupFont.Name = "GroupFont"
        Me.GroupFont.Size = New System.Drawing.Size(148, 132)
        Me.GroupFont.TabIndex = 6
        Me.GroupFont.TabStop = False
        Me.GroupFont.Text = "속성"
        '
        'optBold
        '
        Me.optBold.AutoSize = True
        Me.optBold.Location = New System.Drawing.Point(25, 28)
        Me.optBold.Name = "optBold"
        Me.optBold.Size = New System.Drawing.Size(47, 16)
        Me.optBold.TabIndex = 0
        Me.optBold.TabStop = True
        Me.optBold.Text = "굵게"
        Me.optBold.UseVisualStyleBackColor = True
        '
        'optItalic
        '
        Me.optItalic.AutoSize = True
        Me.optItalic.Location = New System.Drawing.Point(25, 50)
        Me.optItalic.Name = "optItalic"
        Me.optItalic.Size = New System.Drawing.Size(71, 16)
        Me.optItalic.TabIndex = 1
        Me.optItalic.TabStop = True
        Me.optItalic.Text = "이탤릭체"
        Me.optItalic.UseVisualStyleBackColor = True
        '
        'optStrikeThru
        '
        Me.optStrikeThru.AutoSize = True
        Me.optStrikeThru.Location = New System.Drawing.Point(25, 72)
        Me.optStrikeThru.Name = "optStrikeThru"
        Me.optStrikeThru.Size = New System.Drawing.Size(59, 16)
        Me.optStrikeThru.TabIndex = 2
        Me.optStrikeThru.TabStop = True
        Me.optStrikeThru.Text = "취소선"
        Me.optStrikeThru.UseVisualStyleBackColor = True
        '
        'optUnderline
        '
        Me.optUnderline.AutoSize = True
        Me.optUnderline.Location = New System.Drawing.Point(25, 94)
        Me.optUnderline.Name = "optUnderline"
        Me.optUnderline.Size = New System.Drawing.Size(47, 16)
        Me.optUnderline.TabIndex = 3
        Me.optUnderline.TabStop = True
        Me.optUnderline.Text = "밑줄"
        Me.optUnderline.UseVisualStyleBackColor = True
        '
        'frmRichText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupFont)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.cboFontColor)
        Me.Controls.Add(Me.cboFontSize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFontColor)
        Me.Controls.Add(Me.lblFontSize)
        Me.Name = "frmRichText"
        Me.Text = "글꼴 속성 적용하기"
        Me.GroupFont.ResumeLayout(False)
        Me.GroupFont.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFontSize As Label
    Friend WithEvents lblFontColor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboFontSize As ComboBox
    Friend WithEvents cboFontColor As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupFont As GroupBox
    Friend WithEvents optUnderline As RadioButton
    Friend WithEvents optStrikeThru As RadioButton
    Friend WithEvents optItalic As RadioButton
    Friend WithEvents optBold As RadioButton
End Class
