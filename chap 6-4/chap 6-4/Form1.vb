﻿Public Class Form1
    Dim coin As Integer
    Dim selection As Integer
    Dim orange As Integer
    Dim grape As Integer
    Dim apple As Integer
    Dim mango As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        Label2.Visible = False
        Label3.Text = "잔액 : 0원"
        orange = 0
        grape = 0
        apple = 0
        mango = 0

    End Sub
    'form 로드 했을 때 구매버튼이랑 잔액 반환 버튼 비활성화하고 잔액 안보이게 함. 
    '그리고 구매 주스 개수 초기화


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("투입할 금액을 입력하시오.")
        Else
            coin = TextBox1.Text
            TextBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True

        End If
    End Sub
    '투입금액에 빈칸 제출시 알림창 띄우고, 제대로 값을 입력했을 경우 잔액을 coin에 저장하고 
    '구매버튼, 잔액 반환버튼, 잔액라벨을 활성화함

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        selection = 1
    End Sub
    '오렌지 주스 선택이 case 1

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        selection = 2
    End Sub
    '포도 주스 선택이 case 2

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        selection = 3
    End Sub
    '사과 주스 선택이 case 3

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        selection = 4
    End Sub
    '망고 주스 선택이 case 4

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case selection
            Case 1
                If coin >= 1000 Then
                    coin -= 1000
                    orange += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
                '오렌지 주스 선택했을 때 coin이 주스 가격보다 크면 주스가격만큼을 coin에서 빼주고
                '주스가격보다 돈이 적으면 금액부족 알림창 띄움
            Case 2
                If coin >= 700 Then
                    coin -= 700
                    grape += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
                '포도 주스 선택했을 때 coin이 주스 가격보다 크면 주스가격만큼을 coin에서 빼주고
                '주스가격보다 돈이 적으면 금액부족 알림창 띄움
            Case 3
                If coin >= 500 Then
                    coin -= 500
                    apple += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
                '사과 주스 선택했을 때 coin이 주스 가격보다 크면 주스가격만큼을 coin에서 빼주고
                '주스가격보다 돈이 적으면 금액부족 알림창 띄움
            Case 4
                If coin >= 100 Then
                    coin -= 100
                    mango += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
                '망고 주스 선택했을 때 coin이 주스 가격보다 크면 주스가격만큼을 coin에서 빼주고
                '주스가격보다 돈이 적으면 금액부족 알림창 띄움

        End Select
        Label3.Text = "잔액 : " & coin & "원"
        Label2.Text = "오렌지 주스 :" & orange & "개" & vbCr & "포도 주스 :" & grape & "개" & vbCr & "사과 주스 :" & apple & "개" & vbCr & "망고 주스 :" & mango & "개"
        Label2.Visible = True
        Label3.Visible = True
        '잔액을 띄우고, 현재 구입한 주스의 갯수를 표현함, 이 표현한 라벨들을 보이도록 설정함
    End Sub
End Class
