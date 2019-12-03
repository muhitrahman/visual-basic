
Public Class Form1

    Dim emp_number As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ListBox1.Items.Clear()


        Dim hours, rate, gross_pay, net_pay, result As Decimal
        Dim tax As Decimal = 0.05


        emp_number = TextBox1.Text
        hours = TextBox2.Text
        rate = TextBox3.Text

        ListBox1.Items.Add("Fixed Tax : 5%")


        emp_number = emp_number
        ListBox1.Items.Add("Employee Number:" & Space(1) & emp_number)


        gross_pay = hours * rate
        ListBox1.Items.Add("Gross Payment:" & Space(1) & gross_pay)


        net_pay = gross_pay - (gross_pay * tax)
        ListBox1.Items.Add("Net Payment:" & Space(1) & net_pay)



  
        'gross_pay = result
        'net_pay = gross_pay *
        'If TextBox1.Text = "" Then
        'MsgBox("Please input the first number.")
        ' LblResult.Text = "Student number is: " & StudentNo & " Grade is: " & grade
        'ListBox1.Items.Add(MyNumber(i))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub
End Class
