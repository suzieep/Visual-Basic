<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"국화", "국화입니다"}, 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"사과", "사과입니다"}, 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"펭귄", "국화입니다"}, 2)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblViewStyle = New System.Windows.Forms.Label()
        Me.cboListView = New System.Windows.Forms.ComboBox()
        Me.lblView = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "실습3. 국화.PNG")
        Me.ImageList1.Images.SetKeyName(1, "실습3. 사과.PNG")
        Me.ImageList1.Images.SetKeyName(2, "실습3. 팽귄.PNG")
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(181, 75)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(292, 212)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "꽃 폴더"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "기능 설명"
        '
        'lblViewStyle
        '
        Me.lblViewStyle.AutoSize = True
        Me.lblViewStyle.Location = New System.Drawing.Point(35, 48)
        Me.lblViewStyle.Name = "lblViewStyle"
        Me.lblViewStyle.Size = New System.Drawing.Size(65, 12)
        Me.lblViewStyle.TabIndex = 2
        Me.lblViewStyle.Text = "표시 방법 :"
        '
        'cboListView
        '
        Me.cboListView.FormattingEnabled = True
        Me.cboListView.Items.AddRange(New Object() {"Large Icon", "Small Icon", "List", "Title", "Datails"})
        Me.cboListView.Location = New System.Drawing.Point(37, 75)
        Me.cboListView.Name = "cboListView"
        Me.cboListView.Size = New System.Drawing.Size(121, 20)
        Me.cboListView.TabIndex = 3
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Location = New System.Drawing.Point(179, 48)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(65, 12)
        Me.lblView.TabIndex = 4
        Me.lblView.Text = "항목 보기 :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.cboListView)
        Me.Controls.Add(Me.lblViewStyle)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListView1 As ListView
    Protected Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lblViewStyle As Label
    Friend WithEvents cboListView As ComboBox
    Friend WithEvents lblView As Label
End Class
