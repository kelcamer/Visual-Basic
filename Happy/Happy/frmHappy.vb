Public Class frmHappy

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        
        Dim intCounter As Integer = 0
        Dim intSquares As Integer = 2
        Me.lstSquares.Items.Add(intSquares)

        Do Until intCounter > 25
            Multiply(intSquares)
            Me.lstSquares.Items.Add(intSquares)
            intCounter += 1
        Loop


    End Sub
    Private Function Multiply(ByRef intNumber)
        intNumber *= 2
        Return intNumber
    End Function



End Class
