Public Class Form1
    Dim StudentNo As Integer
    Dim score As Integer
    Dim grade As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

       
        score = TextBox1.Text
        StudentNo = TextBox2.Text

        'score = Integer.Parse(TextBox1.Text)
        'StudentNo = Integer.Parse(TextBox2.Text)



        If score >= 90 Then
            grade = "A"

        Else
            If score >= 80 Then
                grade = "B"
            Else
                If score >= 70 Then
                    grade = "C"
                Else
                    If score >= 60 Then
                        grade = "D"
                    Else
                        grade = "Fail"

                    End If
                End If
            End If
        End If

        'MsgBox("Student number is: " & StudentNo & " Grade is: " & grade)

        LblResult.Text = "Student number is: " & StudentNo & " Grade is: " & grade


    End Sub

  
    Private Sub LblResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblResult.Click

    End Sub
End Class
