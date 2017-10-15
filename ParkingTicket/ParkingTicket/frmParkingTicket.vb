Public Class frmParkingTicket

    Private Sub btnDisplayFine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFine.Click

        Dim intCost As Integer
        Dim intMeterCost As Integer = 35D
        Dim intNoParking As Integer = 75D
        Dim intBlockingDriveway As Integer = 150D
        Dim intIllegalHandicapParking As Integer = 500D

        If Me.radExpiredMeter.Checked = True Then
            intCost = intMeterCost
        ElseIf Me.radNoParkingZone.Checked = True Then
            intCost = intNoParking
        ElseIf Me.radBlockingDriveway.Checked = True Then
            intCost = intBlockingDriveway
        ElseIf Me.radIllegalHandicap.Checked = True Then
            intCost = intIllegalHandicapParking
        End If

        If Me.radRepeatOffender.Checked = True Then
            intCost = 2 * intCost
        End If
        Me.lblFinalCost.Text = intCost.ToString("C")

    End Sub

    Private Sub frmParkingTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblFinalCost.Text = ""
        Me.radRepeatOffender.Checked = False
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.lblFinalCost.Text = ""
        Me.radRepeatOffender.Checked = False
        Me.radNoParkingZone.Checked = False
        Me.radIllegalHandicap.Checked = False
        Me.radBlockingDriveway.Checked = False
        Me.radExpiredMeter.Checked = True

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
