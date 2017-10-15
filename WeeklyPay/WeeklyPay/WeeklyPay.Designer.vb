<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeeklyPay))
        Me.picWorkers = New System.Windows.Forms.PictureBox
        Me.lblWestDistribution = New System.Windows.Forms.Label
        Me.lblWeeklyPayroll = New System.Windows.Forms.Label
        Me.lblCalculation = New System.Windows.Forms.Label
        Me.lblTotalMinutes = New System.Windows.Forms.Label
        Me.lblPayRate = New System.Windows.Forms.Label
        Me.txtTotalMinutes = New System.Windows.Forms.TextBox
        Me.txtPayRate = New System.Windows.Forms.TextBox
        Me.btnWeeklyPay = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblHoursWorkedDisplay = New System.Windows.Forms.Label
        Me.lblHoursWorked = New System.Windows.Forms.Label
        Me.lblLeftoverMinutesDisplay = New System.Windows.Forms.Label
        Me.lblLeftoverMinutes = New System.Windows.Forms.Label
        Me.lblWeeklyPayDisplay = New System.Windows.Forms.Label
        Me.lblWeeklyPay = New System.Windows.Forms.Label
        CType(Me.picWorkers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWorkers
        '
        Me.picWorkers.Image = CType(resources.GetObject("picWorkers.Image"), System.Drawing.Image)
        Me.picWorkers.Location = New System.Drawing.Point(13, 13)
        Me.picWorkers.Name = "picWorkers"
        Me.picWorkers.Size = New System.Drawing.Size(211, 163)
        Me.picWorkers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWorkers.TabIndex = 0
        Me.picWorkers.TabStop = False
        '
        'lblWestDistribution
        '
        Me.lblWestDistribution.AutoSize = True
        Me.lblWestDistribution.Font = New System.Drawing.Font("Snap ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWestDistribution.Location = New System.Drawing.Point(240, 13)
        Me.lblWestDistribution.Name = "lblWestDistribution"
        Me.lblWestDistribution.Size = New System.Drawing.Size(267, 27)
        Me.lblWestDistribution.TabIndex = 1
        Me.lblWestDistribution.Text = "Western Distribution"
        '
        'lblWeeklyPayroll
        '
        Me.lblWeeklyPayroll.AutoSize = True
        Me.lblWeeklyPayroll.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyPayroll.Location = New System.Drawing.Point(268, 95)
        Me.lblWeeklyPayroll.Name = "lblWeeklyPayroll"
        Me.lblWeeklyPayroll.Size = New System.Drawing.Size(178, 25)
        Me.lblWeeklyPayroll.TabIndex = 2
        Me.lblWeeklyPayroll.Text = "Weekly Payroll"
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.Location = New System.Drawing.Point(288, 120)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(136, 25)
        Me.lblCalculation.TabIndex = 4
        Me.lblCalculation.Text = "Calculation"
        '
        'lblTotalMinutes
        '
        Me.lblTotalMinutes.AutoSize = True
        Me.lblTotalMinutes.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMinutes.Location = New System.Drawing.Point(9, 192)
        Me.lblTotalMinutes.Name = "lblTotalMinutes"
        Me.lblTotalMinutes.Size = New System.Drawing.Size(279, 22)
        Me.lblTotalMinutes.TabIndex = 5
        Me.lblTotalMinutes.Text = "Enter Total Minutes Worked:"
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRate.Location = New System.Drawing.Point(13, 245)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(227, 22)
        Me.lblPayRate.TabIndex = 6
        Me.lblPayRate.Text = "Enter Hourly Pay Rate:"
        '
        'txtTotalMinutes
        '
        Me.txtTotalMinutes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMinutes.Location = New System.Drawing.Point(334, 193)
        Me.txtTotalMinutes.Name = "txtTotalMinutes"
        Me.txtTotalMinutes.Size = New System.Drawing.Size(60, 27)
        Me.txtTotalMinutes.TabIndex = 7
        '
        'txtPayRate
        '
        Me.txtPayRate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayRate.Location = New System.Drawing.Point(334, 246)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(60, 27)
        Me.txtPayRate.TabIndex = 8
        '
        'btnWeeklyPay
        '
        Me.btnWeeklyPay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeeklyPay.Location = New System.Drawing.Point(9, 301)
        Me.btnWeeklyPay.Name = "btnWeeklyPay"
        Me.btnWeeklyPay.Size = New System.Drawing.Size(113, 26)
        Me.btnWeeklyPay.TabIndex = 9
        Me.btnWeeklyPay.Text = "Weekly Pay"
        Me.btnWeeklyPay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(205, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(400, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 26)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHoursWorkedDisplay
        '
        Me.lblHoursWorkedDisplay.AutoSize = True
        Me.lblHoursWorkedDisplay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorkedDisplay.Location = New System.Drawing.Point(17, 346)
        Me.lblHoursWorkedDisplay.Name = "lblHoursWorkedDisplay"
        Me.lblHoursWorkedDisplay.Size = New System.Drawing.Size(105, 16)
        Me.lblHoursWorkedDisplay.TabIndex = 12
        Me.lblHoursWorkedDisplay.Text = "Hours Worked:"
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorked.Location = New System.Drawing.Point(155, 348)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(35, 13)
        Me.lblHoursWorked.TabIndex = 13
        Me.lblHoursWorked.Text = "8888"
        '
        'lblLeftoverMinutesDisplay
        '
        Me.lblLeftoverMinutesDisplay.AutoSize = True
        Me.lblLeftoverMinutesDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftoverMinutesDisplay.Location = New System.Drawing.Point(245, 348)
        Me.lblLeftoverMinutesDisplay.Name = "lblLeftoverMinutesDisplay"
        Me.lblLeftoverMinutesDisplay.Size = New System.Drawing.Size(106, 13)
        Me.lblLeftoverMinutesDisplay.TabIndex = 14
        Me.lblLeftoverMinutesDisplay.Text = "Leftover Minutes:"
        '
        'lblLeftoverMinutes
        '
        Me.lblLeftoverMinutes.AutoSize = True
        Me.lblLeftoverMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftoverMinutes.Location = New System.Drawing.Point(389, 348)
        Me.lblLeftoverMinutes.Name = "lblLeftoverMinutes"
        Me.lblLeftoverMinutes.Size = New System.Drawing.Size(35, 13)
        Me.lblLeftoverMinutes.TabIndex = 15
        Me.lblLeftoverMinutes.Text = "8888"
        '
        'lblWeeklyPayDisplay
        '
        Me.lblWeeklyPayDisplay.AutoSize = True
        Me.lblWeeklyPayDisplay.Font = New System.Drawing.Font("Snap ITC", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblWeeklyPayDisplay.Location = New System.Drawing.Point(184, 382)
        Me.lblWeeklyPayDisplay.Name = "lblWeeklyPayDisplay"
        Me.lblWeeklyPayDisplay.Size = New System.Drawing.Size(158, 25)
        Me.lblWeeklyPayDisplay.TabIndex = 16
        Me.lblWeeklyPayDisplay.Text = "Weekly Pay:"
        '
        'lblWeeklyPay
        '
        Me.lblWeeklyPay.AutoSize = True
        Me.lblWeeklyPay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyPay.Location = New System.Drawing.Point(397, 385)
        Me.lblWeeklyPay.Name = "lblWeeklyPay"
        Me.lblWeeklyPay.Size = New System.Drawing.Size(60, 16)
        Me.lblWeeklyPay.TabIndex = 17
        Me.lblWeeklyPay.Text = "$888.88"
        '
        'WeeklyPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 416)
        Me.Controls.Add(Me.lblWeeklyPay)
        Me.Controls.Add(Me.lblWeeklyPayDisplay)
        Me.Controls.Add(Me.lblLeftoverMinutes)
        Me.Controls.Add(Me.lblLeftoverMinutesDisplay)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.lblHoursWorkedDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnWeeklyPay)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtTotalMinutes)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.lblTotalMinutes)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.lblWeeklyPayroll)
        Me.Controls.Add(Me.lblWestDistribution)
        Me.Controls.Add(Me.picWorkers)
        Me.Name = "WeeklyPay"
        Me.Text = "Western Distribution Weekly Payroll"
        CType(Me.picWorkers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picWorkers As System.Windows.Forms.PictureBox
    Friend WithEvents lblWestDistribution As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyPayroll As System.Windows.Forms.Label
    Friend WithEvents lblCalculation As System.Windows.Forms.Label
    Friend WithEvents lblTotalMinutes As System.Windows.Forms.Label
    Friend WithEvents lblPayRate As System.Windows.Forms.Label
    Friend WithEvents txtTotalMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents btnWeeklyPay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHoursWorkedDisplay As System.Windows.Forms.Label
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents lblLeftoverMinutesDisplay As System.Windows.Forms.Label
    Friend WithEvents lblLeftoverMinutes As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyPayDisplay As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyPay As System.Windows.Forms.Label

End Class
