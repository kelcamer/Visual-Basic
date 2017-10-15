' Program:   Pizza
' Author:    Kelsey Cameron
' Date:      October 27, 2010
' Purpose:   This application calculates and displays
'            the total cost of a single pizza based on inches.

Public Class Pizza

    Const _cdecPricePerInch As Decimal = 0.05D

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decSizeOfPizza As Decimal
        Dim strSizeOfPizza As String
        Dim decTotalCost As Decimal

        strSizeOfPizza = Me.txtSizeOfPizza.Text
        decSizeOfPizza = Convert.ToDecimal(strSizeOfPizza)
        decTotalCost = (_cdecPricePerInch * decSizeOfPizza) + 1.75
        Me.lblTotalCost.Text = decTotalCost.ToString("C")



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        Me.txtSizeOfPizza.Clear()
        Me.lblTotalCost.Text = ""
        Me.txtSizeOfPizza.Focus()

    End Sub

    Private Sub Pizza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTotalCost.Text = ""
        Me.txtSizeOfPizza.Clear()
        Me.txtSizeOfPizza.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
