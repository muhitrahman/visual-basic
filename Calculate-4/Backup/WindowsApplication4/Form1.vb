Public Class Form1
    Dim first, second, code, result As Integer
    Dim signal As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Please input the first number.")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please input the second number.")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please input the code.")
        Else
            first = TextBox1.Text
            second = TextBox2.Text
            code = TextBox3.Text

            If code = 1 Then
                result = first + second
                signal = " + "
            ElseIf code = 2 Then
                result = first - second
                signal = " - "
            ElseIf code = 3 Then
                result = first * second
                signal = " * "
            ElseIf code = 4 Then
                result = first / second
                signal = " / "
            End If

            Label4.Text = "Result: " + first.ToString + signal + second.ToString + " = " + result.ToString


            Label4.Visible = True






        End If





    End Sub
End Class
