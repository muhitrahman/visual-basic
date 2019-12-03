Public Class Txtcalculate

    Dim Rent As Integer
    Dim Commission As Decimal
    Const ServiceFee As Decimal = 200
    Dim NoWeeks As Integer
    Dim TotalCommission As Decimal

    Private Sub Calculatebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculatebutton.Click
        Rent = Txtrent.Text
        Commission = Txtcommission.Text
        NoWeeks = Txtnweeks.Text

        TotalCommission = ((Rent * Commission) + 200 / 12) * NoWeeks

        OutputLabel.Text = TotalCommission
    End Sub

    Private Sub Txtcalculate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
