' Kelsey Cameron
' November 23, 2010
' Period 1

Option Strict On
Public Class WeeklyPay

    Private Sub btnWeeklyPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeeklyPay.Click
        Dim intHoursWorked As Integer
        Dim intTotalMinutes As Integer
        Dim decPayRate As Decimal
        Dim decWeeklyPay As Decimal
        Dim strHoursWorked As String
        intHoursWorked = intTotalMinutes \ 60
        strHoursWorked = Me.txtTotalMinutes.Text
        intTotalMinutes = Convert.ToInt32(strHoursWorked)
        decWeeklyPay = intHoursWorked * decPayRate
        Me.lblHoursWorked.Text = decWeeklyPay.ToString("C")



    End Sub
End Class
