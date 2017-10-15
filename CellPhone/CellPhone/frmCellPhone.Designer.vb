<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCellPhone
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
        Me.lblMinutesLabel = New System.Windows.Forms.Label
        Me.lblRegMinLabel = New System.Windows.Forms.Label
        Me.lblXtraMinLabel = New System.Windows.Forms.Label
        Me.lblTaxesLabel = New System.Windows.Forms.Label
        Me.lblTotalBillLabel = New System.Windows.Forms.Label
        Me.txtMinutes = New System.Windows.Forms.TextBox
        Me.lblRegMin = New System.Windows.Forms.Label
        Me.lblXtraMin = New System.Windows.Forms.Label
        Me.lblTaxes = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.btnDisplayBill = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblMinutesLabel
        '
        Me.lblMinutesLabel.AutoSize = True
        Me.lblMinutesLabel.Location = New System.Drawing.Point(15, 9)
        Me.lblMinutesLabel.Name = "lblMinutesLabel"
        Me.lblMinutesLabel.Size = New System.Drawing.Size(127, 13)
        Me.lblMinutesLabel.TabIndex = 0
        Me.lblMinutesLabel.Text = "Enter Number of Minutes:"
        '
        'lblRegMinLabel
        '
        Me.lblRegMinLabel.AutoSize = True
        Me.lblRegMinLabel.Location = New System.Drawing.Point(15, 61)
        Me.lblRegMinLabel.Name = "lblRegMinLabel"
        Me.lblRegMinLabel.Size = New System.Drawing.Size(111, 13)
        Me.lblRegMinLabel.TabIndex = 1
        Me.lblRegMinLabel.Text = "Regular Minutes Cost:"
        '
        'lblXtraMinLabel
        '
        Me.lblXtraMinLabel.AutoSize = True
        Me.lblXtraMinLabel.Location = New System.Drawing.Point(15, 113)
        Me.lblXtraMinLabel.Name = "lblXtraMinLabel"
        Me.lblXtraMinLabel.Size = New System.Drawing.Size(98, 13)
        Me.lblXtraMinLabel.TabIndex = 2
        Me.lblXtraMinLabel.Text = "Extra Minutes Cost:"
        '
        'lblTaxesLabel
        '
        Me.lblTaxesLabel.AutoSize = True
        Me.lblTaxesLabel.Location = New System.Drawing.Point(15, 165)
        Me.lblTaxesLabel.Name = "lblTaxesLabel"
        Me.lblTaxesLabel.Size = New System.Drawing.Size(86, 13)
        Me.lblTaxesLabel.TabIndex = 3
        Me.lblTaxesLabel.Text = "Taxes and Fees:"
        '
        'lblTotalBillLabel
        '
        Me.lblTotalBillLabel.AutoSize = True
        Me.lblTotalBillLabel.Location = New System.Drawing.Point(15, 217)
        Me.lblTotalBillLabel.Name = "lblTotalBillLabel"
        Me.lblTotalBillLabel.Size = New System.Drawing.Size(50, 13)
        Me.lblTotalBillLabel.TabIndex = 4
        Me.lblTotalBillLabel.Text = "Total Bill:"
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(201, 2)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutes.TabIndex = 5
        '
        'lblRegMin
        '
        Me.lblRegMin.AutoSize = True
        Me.lblRegMin.Location = New System.Drawing.Point(201, 60)
        Me.lblRegMin.Name = "lblRegMin"
        Me.lblRegMin.Size = New System.Drawing.Size(46, 13)
        Me.lblRegMin.TabIndex = 6
        Me.lblRegMin.Text = "$888.88"
        '
        'lblXtraMin
        '
        Me.lblXtraMin.AutoSize = True
        Me.lblXtraMin.Location = New System.Drawing.Point(201, 112)
        Me.lblXtraMin.Name = "lblXtraMin"
        Me.lblXtraMin.Size = New System.Drawing.Size(46, 13)
        Me.lblXtraMin.TabIndex = 7
        Me.lblXtraMin.Text = "$888.88"
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Location = New System.Drawing.Point(201, 164)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(46, 13)
        Me.lblTaxes.TabIndex = 8
        Me.lblTaxes.Text = "$888.88"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(204, 217)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(46, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "$888.88"
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Location = New System.Drawing.Point(12, 260)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayBill.TabIndex = 10
        Me.btnDisplayBill.Text = "Display Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(102, 260)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(191, 260)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCellPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 295)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.lblXtraMin)
        Me.Controls.Add(Me.lblRegMin)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.lblTotalBillLabel)
        Me.Controls.Add(Me.lblTaxesLabel)
        Me.Controls.Add(Me.lblXtraMinLabel)
        Me.Controls.Add(Me.lblRegMinLabel)
        Me.Controls.Add(Me.lblMinutesLabel)
        Me.Name = "frmCellPhone"
        Me.Text = "Cell Phone Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMinutesLabel As System.Windows.Forms.Label
    Friend WithEvents lblRegMinLabel As System.Windows.Forms.Label
    Friend WithEvents lblXtraMinLabel As System.Windows.Forms.Label
    Friend WithEvents lblTaxesLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotalBillLabel As System.Windows.Forms.Label
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblRegMin As System.Windows.Forms.Label
    Friend WithEvents lblXtraMin As System.Windows.Forms.Label
    Friend WithEvents lblTaxes As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnDisplayBill As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
