Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Numbers(4) As Integer
        Dim i As Integer

        Numbers(0) = 1
        Numbers(1) = 2
        Numbers(2) = 3
        Numbers(3) = 4
        Numbers(4) = 5
        MsgBox("firsr number is :" & Numbers(0))
        MsgBox("second number is :" & Numbers(1))
        MsgBox("third number is :" & Numbers(2))
        MsgBox("fourth number is :" & Numbers(3))
        MsgBox("fifth number is :" & Numbers(4))

        For i = 0 To 4
            ListBox1.Items.Add(Numbers(i))
        Next i
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim Numbers(4) As Integer
        Dim times As Integer
        Dim StoreAnswer As Integer
        Dim i As Integer

        ListBox1.Items.Clear()
        times = Val(TextBox1.Text)

        For i = 0 To 4
            StoreAnswer = i * times
            Numbers(i) = StoreAnswer
            ListBox1.Items.Add(times & "times" & i & "=" & Numbers(i))
        Next i

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim Numbers() As Integer
        Dim start As Integer
        Dim ends As Integer
        Dim times As Integer
        Dim StoreAnswer As Integer
        Dim i As Integer

        times = Val(TextBox2.Text)
        start = Val(TextBox3.Text)
        ends = Val(TextBox4.Text)

        ReDim Numbers(ends)

        For i = start To ends
            StoreAnswer = i * times
            Numbers(i) = StoreAnswer
            ListBox1.Items.Add(times & Space$(5) & "times" & Space$(5) & i & "=" & Numbers(i))
        Next i

    End Sub
End Class
