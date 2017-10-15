<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza
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
        Me.lblSizeOfPizzaLabel = New System.Windows.Forms.Label
        Me.lblTotalCostLabel = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtSizeOfPizza = New System.Windows.Forms.TextBox
        Me.lblTotalCost = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblSizeOfPizzaLabel
        '
        Me.lblSizeOfPizzaLabel.AutoSize = True
        Me.lblSizeOfPizzaLabel.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSizeOfPizzaLabel.Location = New System.Drawing.Point(25, 41)
        Me.lblSizeOfPizzaLabel.Name = "lblSizeOfPizzaLabel"
        Me.lblSizeOfPizzaLabel.Size = New System.Drawing.Size(251, 25)
        Me.lblSizeOfPizzaLabel.TabIndex = 0
        Me.lblSizeOfPizzaLabel.Text = "Enter Size of Pizza"
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(26, 117)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(289, 22)
        Me.lblTotalCostLabel.TabIndex = 1
        Me.lblTotalCostLabel.Text = "The total cost of the pizza is:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(36, 264)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 32)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(187, 264)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 32)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(338, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtSizeOfPizza
        '
        Me.txtSizeOfPizza.Location = New System.Drawing.Point(338, 46)
        Me.txtSizeOfPizza.Name = "txtSizeOfPizza"
        Me.txtSizeOfPizza.Size = New System.Drawing.Size(70, 20)
        Me.txtSizeOfPizza.TabIndex = 5
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(335, 123)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "88888888888"
        '
        'Pizza
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 390)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtSizeOfPizza)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.lblSizeOfPizzaLabel)
        Me.Name = "Pizza"
        Me.Text = "Pizza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSizeOfPizzaLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostLabel As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtSizeOfPizza As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label

End Class
