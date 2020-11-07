Public Class frmGugudan
    Private Sub frmGugudan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        Dim k As Integer
        Dim n As Integer 'i,j,k,n 을 정수로 선언
        Dim l, m, o As String ' l,m,o 를 문자열로 선언
        lblOutput.Text = ""
        lblOutput.Text = lblOutput.Text & vbCrLf & Space(35) & "** 구 구 단 **" & vbCrLf & vbCrLf
        For i = 1 To 7 Step 3
            k = i + 1
            n = i + 2
            lblOutput.Text = lblOutput.Text & Space(10) & i & "단" & Space(17) & k & "단" & Space(17) & n & "단" & vbCrLf
            'i단 ,i+1단, i+2단
            For j = 1 To 9 '1부터 9까지 반복
                l = IIf(i * j < 10, " " & i * j, i * j) 'i 단 구구단 우변저장 단, 1의 자리일때 공백 추가해서 길이 맞춰줌
                m = IIf(k * j < 10, " " & k * j, k * j) 'i+1 단 구구단 우변저장 단, 1의 자리일때 공백 추가해서 길이 맞춰줌
                o = IIf(n * j < 10, " " & n * j, n * j) 'i+2 단 구구단 우변저장 단, 1의 자리일때 공백 추가해서 길이 맞춰줌
                lblOutput.Text = lblOutput.Text & Space(5) & i & " * " & j & " = " & l &
                                         Space(10) & k & " * " & j & " = " & m
                lblOutput.Text = lblOutput.Text & Space(10) & n & " * " & j & " = " & o & vbCrLf
                ' i단 i+1단 i+2단 j줄 출력 아까 저장했던 우변 이용해서 한줄에 출력
            Next j
            lblOutput.Text = lblOutput.Text & vbCrLf ' 구분위해 한줄 띄기
        Next i
    End Sub
End Class
