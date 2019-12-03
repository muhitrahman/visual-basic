

Imports SpeechLib



Public Class Form1

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click


        Dim myCode As Long
        Dim myMessage As String = ""
        Dim compVoice As New SpeechLib.SpVoice

        myCode = TextBox1.Text
        TextBox1.Text = ""


        Select Case myCode
            Case Is < 1000
                myMessage = "Access denied"
                Beep()
                compVoice.Speak("Access Denied")

            Case 1645 To 1689
                myMessage = "Technicians"
                compVoice.Speak("Welcome Technicians")

            Case 8345
                myMessage = "Custodians"
                compVoice.Speak("Welcome Custodians")

            Case 55875
                myMessage = "Special Services"
                compVoice.Speak("Welcome Special Services")

            Case 999898
                myMessage = "Junior Scientists"
                compVoice.Speak("Welcome Junior Scientists")

            Case 1000001 To 1000009
                myMessage = "Senior Scientist"
                compVoice.Speak("Welcome Senior Scientist")

            Case Else
                myMessage = "Access Denied"
                compVoice.Speak("Access Denied")
        End Select

        ListBox1.Items.Add(Now & Space$(5) & myMessage)

    End Sub
#Region "NUMBER BUTTONS"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TextBox1.Text = TextBox1.Text & "1"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "4"

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "5"

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "6"

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "7"

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "8"

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "9"

    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text & "0"

    End Sub
#End Region

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = ""
    End Sub
End Class
