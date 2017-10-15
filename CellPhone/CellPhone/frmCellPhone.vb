' Kelsey Cameron
' Period 1
' February 10, 2010

Option Strict On


Public Class frmCellPhone

    Private Sub btnDisplayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBill.Click
        ' Defining Variables
        Dim strMinutes As String
        Dim intMinutes As Integer
        Dim decRegMin As Decimal = 29.95D
        Dim decXtraMinCost As Decimal
        Dim decTaxes As Decimal = 4.85D
        Dim decFinalCost As Decimal
        ' strMinutes is given the same value of the textbox
        strMinutes = Me.txtMinutes.Text
        ' If the data in the textbox is numeric, then it calculates
        ' the cost.
        If IsNumeric(Me.txtMinutes.Text) Then
            intMinutes = Convert.ToInt32(strMinutes)
            decFinalCost = decRegMin + decTaxes + decXtraMinCost
            Me.lblRegMin.Text = decRegMin.ToString("C")
            Me.lblTaxes.Text = decTaxes.ToString("C")
        Else
            ' else then a message box pops up.
            MsgBox("You entered " & decFinalCost & ". Please Enter Numeric Data.", , "Input Error")
        End If

        If intMinutes > 300 Then
            decXtraMinCost = (intMinutes - 300) * 0.17D
        End If

        If intMinutes < 0 Then
            MsgBox("You entered " & decFinalCost & ". Enter a number greater than zero.", , "Input Error")
        End If

        Me.lblXtraMin.Text = decXtraMinCost.ToString("C")
        Me.lblTotal.Text = decFinalCost.ToString("C")

     

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.lblRegMin.Text = ""
        Me.lblTaxes.Text = ""
        Me.lblTotal.Text = ""
        Me.lblXtraMin.Text = ""
        Me.txtMinutes.Clear()
        Me.txtMinutes.Focus()
    End Sub

    Private Sub frmCellPhone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblRegMin.Text = ""
        Me.lblTaxes.Text = ""
        Me.lblTotal.Text = ""
        Me.lblXtraMin.Text = ""
        Me.txtMinutes.Clear()
        Me.txtMinutes.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
