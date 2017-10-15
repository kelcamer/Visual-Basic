<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParkingTicket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.radIllegalHandicap = New System.Windows.Forms.RadioButton
        Me.radBlockingDriveway = New System.Windows.Forms.RadioButton
        Me.radNoParkingZone = New System.Windows.Forms.RadioButton
        Me.radExpiredMeter = New System.Windows.Forms.RadioButton
        Me.lblParkingViolation = New System.Windows.Forms.Label
        Me.radRepeatOffender = New System.Windows.Forms.RadioButton
        Me.btnDisplayFine = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblCostLabel = New System.Windows.Forms.Label
        Me.lblFinalCost = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radIllegalHandicap)
        Me.Panel1.Controls.Add(Me.radBlockingDriveway)
        Me.Panel1.Controls.Add(Me.radNoParkingZone)
        Me.Panel1.Controls.Add(Me.radExpiredMeter)
        Me.Panel1.Location = New System.Drawing.Point(88, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 152)
        Me.Panel1.TabIndex = 0
        '
        'radIllegalHandicap
        '
        Me.radIllegalHandicap.AutoSize = True
        Me.radIllegalHandicap.Location = New System.Drawing.Point(32, 117)
        Me.radIllegalHandicap.Name = "radIllegalHandicap"
        Me.radIllegalHandicap.Size = New System.Drawing.Size(101, 17)
        Me.radIllegalHandicap.TabIndex = 3
        Me.radIllegalHandicap.Text = "Illegal Handicap"
        Me.radIllegalHandicap.UseVisualStyleBackColor = True
        '
        'radBlockingDriveway
        '
        Me.radBlockingDriveway.AutoSize = True
        Me.radBlockingDriveway.Location = New System.Drawing.Point(32, 82)
        Me.radBlockingDriveway.Name = "radBlockingDriveway"
        Me.radBlockingDriveway.Size = New System.Drawing.Size(113, 17)
        Me.radBlockingDriveway.TabIndex = 2
        Me.radBlockingDriveway.Text = "Blocking Driveway"
        Me.radBlockingDriveway.UseVisualStyleBackColor = True
        '
        'radNoParkingZone
        '
        Me.radNoParkingZone.AutoSize = True
        Me.radNoParkingZone.Location = New System.Drawing.Point(32, 42)
        Me.radNoParkingZone.Name = "radNoParkingZone"
        Me.radNoParkingZone.Size = New System.Drawing.Size(106, 17)
        Me.radNoParkingZone.TabIndex = 1
        Me.radNoParkingZone.Text = "No Parking Zone"
        Me.radNoParkingZone.UseVisualStyleBackColor = True
        '
        'radExpiredMeter
        '
        Me.radExpiredMeter.AutoSize = True
        Me.radExpiredMeter.Checked = True
        Me.radExpiredMeter.Location = New System.Drawing.Point(32, 3)
        Me.radExpiredMeter.Name = "radExpiredMeter"
        Me.radExpiredMeter.Size = New System.Drawing.Size(93, 18)
        Me.radExpiredMeter.TabIndex = 0
        Me.radExpiredMeter.TabStop = True
        Me.radExpiredMeter.Text = "Expired Meter"
        Me.radExpiredMeter.UseCompatibleTextRendering = True
        Me.radExpiredMeter.UseVisualStyleBackColor = True
        '
        'lblParkingViolation
        '
        Me.lblParkingViolation.AutoSize = True
        Me.lblParkingViolation.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParkingViolation.Location = New System.Drawing.Point(75, 23)
        Me.lblParkingViolation.Name = "lblParkingViolation"
        Me.lblParkingViolation.Size = New System.Drawing.Size(187, 22)
        Me.lblParkingViolation.TabIndex = 1
        Me.lblParkingViolation.Text = "Parking Violation"
        '
        'radRepeatOffender
        '
        Me.radRepeatOffender.AutoSize = True
        Me.radRepeatOffender.Location = New System.Drawing.Point(120, 206)
        Me.radRepeatOffender.Name = "radRepeatOffender"
        Me.radRepeatOffender.Size = New System.Drawing.Size(104, 17)
        Me.radRepeatOffender.TabIndex = 2
        Me.radRepeatOffender.TabStop = True
        Me.radRepeatOffender.Text = "Repeat Offender"
        Me.radRepeatOffender.UseVisualStyleBackColor = True
        '
        'btnDisplayFine
        '
        Me.btnDisplayFine.Location = New System.Drawing.Point(10, 261)
        Me.btnDisplayFine.Name = "btnDisplayFine"
        Me.btnDisplayFine.Size = New System.Drawing.Size(80, 23)
        Me.btnDisplayFine.TabIndex = 3
        Me.btnDisplayFine.Text = "Display Fine"
        Me.btnDisplayFine.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 260)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(250, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCostLabel
        '
        Me.lblCostLabel.AutoSize = True
        Me.lblCostLabel.Font = New System.Drawing.Font("Snap ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostLabel.Location = New System.Drawing.Point(40, 226)
        Me.lblCostLabel.Name = "lblCostLabel"
        Me.lblCostLabel.Size = New System.Drawing.Size(103, 17)
        Me.lblCostLabel.TabIndex = 6
        Me.lblCostLabel.Text = "Cost Label:"
        '
        'lblFinalCost
        '
        Me.lblFinalCost.AutoSize = True
        Me.lblFinalCost.Location = New System.Drawing.Point(208, 226)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(40, 13)
        Me.lblFinalCost.TabIndex = 7
        Me.lblFinalCost.Text = "888.88"
        '
        'frmParkingTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 306)
        Me.Controls.Add(Me.lblFinalCost)
        Me.Controls.Add(Me.lblCostLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayFine)
        Me.Controls.Add(Me.radRepeatOffender)
        Me.Controls.Add(Me.lblParkingViolation)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmParkingTicket"
        Me.Text = "Parking Ticket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents radIllegalHandicap As System.Windows.Forms.RadioButton
    Friend WithEvents radBlockingDriveway As System.Windows.Forms.RadioButton
    Friend WithEvents radNoParkingZone As System.Windows.Forms.RadioButton
    Friend WithEvents radExpiredMeter As System.Windows.Forms.RadioButton
    Friend WithEvents lblParkingViolation As System.Windows.Forms.Label
    Friend WithEvents radRepeatOffender As System.Windows.Forms.RadioButton
    Friend WithEvents btnDisplayFine As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCostLabel As System.Windows.Forms.Label
    Friend WithEvents lblFinalCost As System.Windows.Forms.Label

End Class
