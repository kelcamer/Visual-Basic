<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSequences
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
        Me.lblConvert = New System.Windows.Forms.Label
        Me.lblEnter = New System.Windows.Forms.Label
        Me.txtNum1 = New System.Windows.Forms.TextBox
        Me.txtNum3 = New System.Windows.Forms.TextBox
        Me.txtNum4 = New System.Windows.Forms.TextBox
        Me.txtNum2 = New System.Windows.Forms.TextBox
        Me.txtNum5 = New System.Windows.Forms.TextBox
        Me.lblTypeLabel = New System.Windows.Forms.Label
        Me.lblFormulaLabel = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.lblFormula = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Location = New System.Drawing.Point(30, 35)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(176, 13)
        Me.lblConvert.TabIndex = 0
        Me.lblConvert.Text = "Series Converter for Explicit Formula"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(33, 91)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(238, 13)
        Me.lblEnter.TabIndex = 1
        Me.lblEnter.Text = "Please enter the first 5 numbers of the sequence:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(36, 141)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(19, 20)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(86, 141)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(19, 20)
        Me.txtNum3.TabIndex = 4
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(111, 141)
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(19, 20)
        Me.txtNum4.TabIndex = 5
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(61, 141)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(19, 20)
        Me.txtNum2.TabIndex = 6
        '
        'txtNum5
        '
        Me.txtNum5.Location = New System.Drawing.Point(136, 141)
        Me.txtNum5.Name = "txtNum5"
        Me.txtNum5.Size = New System.Drawing.Size(19, 20)
        Me.txtNum5.TabIndex = 7
        '
        'lblTypeLabel
        '
        Me.lblTypeLabel.AutoSize = True
        Me.lblTypeLabel.Location = New System.Drawing.Point(36, 206)
        Me.lblTypeLabel.Name = "lblTypeLabel"
        Me.lblTypeLabel.Size = New System.Drawing.Size(171, 13)
        Me.lblTypeLabel.TabIndex = 8
        Me.lblTypeLabel.Text = "Geometric or Arithmetic or Neither?"
        '
        'lblFormulaLabel
        '
        Me.lblFormulaLabel.AutoSize = True
        Me.lblFormulaLabel.Location = New System.Drawing.Point(36, 268)
        Me.lblFormulaLabel.Name = "lblFormulaLabel"
        Me.lblFormulaLabel.Size = New System.Drawing.Size(47, 13)
        Me.lblFormulaLabel.TabIndex = 10
        Me.lblFormulaLabel.Text = "Formula:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(290, 206)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(63, 13)
        Me.lblType.TabIndex = 11
        Me.lblType.Text = "OOOOOOO"
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Location = New System.Drawing.Point(290, 268)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(43, 13)
        Me.lblFormula.TabIndex = 13
        Me.lblFormula.Text = "888888"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(33, 314)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(196, 314)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSequences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 365)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblFormulaLabel)
        Me.Controls.Add(Me.lblTypeLabel)
        Me.Controls.Add(Me.txtNum5)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum4)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblConvert)
        Me.Name = "frmSequences"
        Me.Text = "Series Converter for Explicit Formula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConvert As System.Windows.Forms.Label
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum5 As System.Windows.Forms.TextBox
    Friend WithEvents lblTypeLabel As System.Windows.Forms.Label
    Friend WithEvents lblFormulaLabel As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
