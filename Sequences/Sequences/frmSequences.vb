Public Class frmSequences

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim intNum1 As Integer = 0
        Dim intNum2 As Integer = 0
        Dim intNum3 As Integer = 0
        Dim intNum4 As Integer = 0
        Dim intNum5 As Integer = 0
        Dim strType As String = ""
        Dim strNum1 As String = ""
        Dim strNum2 As String = ""
        Dim strNum3 As String = ""
        Dim strNum4 As String = ""
        Dim strNum5 As String = ""

        strNum1 = Me.txtNum1.Text
        strNum2 = Me.txtNum2.Text
        strNum3 = Me.txtNum3.Text
        strNum4 = Me.txtNum4.Text
        strNum5 = Me.txtNum5.Text


        intNum1 = Convert.ToInt32(strNum1)
        intNum2 = Convert.ToInt32(strNum2)
        intNum3 = Convert.ToInt32(strNum3)
        intNum4 = Convert.ToInt32(strNum4)
        intNum5 = Convert.ToInt32(strNum5)



        If (IsNumeric(intNum1 And intNum2 And intNum3 And intNum4 And intNum5)) Then

            Dim intDifference As Integer = 0
            Dim intRatio As Integer = 0

            If intNum5 / intNum4 = intNum4 / intNum3 And intNum4 / intNum3 = intNum3 / intNum2 And intNum3 / intNum2 = intNum2 / intNum1 Then
                strType = "Geometric"
                intRatio = intNum5 / intNum4
            ElseIf intNum5 - intNum4 = intNum4 - intNum3 And intNum4 - intNum3 = intNum3 - intNum2 And intNum3 - intNum2 = intNum2 - intNum1 Then
                strType = "Arithmetic"
                intDifference = intNum5 - intNum4
            Else
                strType = "Neither"
            End If

            Me.lblType.Text = strType
            Dim intNumber As Integer = (intDifference * -1) + intNum1

            If strType = "Geometric" Then
                Me.lblFormula.Text = "an = " & intNum1 & "* " & intRatio & "^n"
            ElseIf strType = "Arithmetic" Then
                Me.lblFormula.Text = "an = " & intDifference & "n + " & intNumber
            End If

            If strType = "Neither" Then
                Me.lblFormula.Text = ""
            End If


        Else
            MsgBox("", "Please enter an Non-negative Numeric Number")
        End If




    End Sub

    Private Sub frmSequences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblType.Text = ""
        Me.txtNum1.Clear()
        Me.txtNum2.Clear()
        Me.txtNum3.Clear()
        Me.txtNum4.Clear()
        Me.txtNum5.Clear()
        Me.lblFormula.Text = ""

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.lblType.Text = ""
        Me.txtNum1.Clear()
        Me.txtNum2.Clear()
        Me.txtNum3.Clear()
        Me.txtNum4.Clear()
        Me.txtNum5.Clear()
        Me.lblFormula.Text = ""
    End Sub
End Class
