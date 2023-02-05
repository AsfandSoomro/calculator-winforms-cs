Public Class Calculator
    'muziishere'
    'Global variables to store the current calculated answer and sign'
    Dim answer As Integer
    Dim sign As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim nums(2) As Integer
        Dim temp(2) As String

        If sign = "+" Then
            temp = Split(txtDisplay.Text, "+")
            nums(0) = Convert.ToInt32(temp(0))
            nums(1) = Convert.ToInt32(temp(1))
            answer = nums(0) + nums(1)
        ElseIf sign = "-" Then
            temp = Split(txtDisplay.Text, "-")
            nums(0) = Convert.ToInt32(temp(0))
            nums(1) = Convert.ToInt32(temp(1))
            answer = nums(0) - nums(1)
        ElseIf sign = "/" Then
            temp = Split(txtDisplay.Text, "/")
            nums(0) = Convert.ToInt32(temp(0))
            nums(1) = Convert.ToInt32(temp(1))
            answer = nums(0) / nums(1)
        ElseIf sign = "x" Then
            temp = Split(txtDisplay.Text, "x")
            nums(0) = Convert.ToInt32(temp(0))
            nums(1) = Convert.ToInt32(temp(1))
            answer = nums(0) * nums(1)
        End If

        txtDisplay.Text &= Environment.NewLine & Convert.ToString(answer)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        sign = "+"
        If answer > 0 Or answer < 0 Then
            txtDisplay.Text = Convert.ToString(answer) & "+"
        Else
            txtDisplay.Text &= "+"
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        sign = "-"
        If answer > 0 Or answer < 0 Then
            txtDisplay.Text = Convert.ToString(answer) & "-"
        Else
            txtDisplay.Text &= "-"
        End If
    End Sub
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        sign = "/"
        If answer > 0 Or answer < 0 Then
            txtDisplay.Text = Convert.ToString(answer) & "/"
        Else
            txtDisplay.Text &= "/"
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        sign = "x"
        If answer > 0 Or answer < 0 Then
            txtDisplay.Text = Convert.ToString(answer) & "x"
        Else
            txtDisplay.Text &= "x"
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""
        answer = Nothing
        sign = Nothing
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text &= "0"
    End Sub

End Class
