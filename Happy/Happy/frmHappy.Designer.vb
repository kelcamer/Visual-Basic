<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHappy
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
        Me.lblSquares = New System.Windows.Forms.Label
        Me.lblNine = New System.Windows.Forms.Label
        Me.lstSquares = New System.Windows.Forms.ListBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblSquares
        '
        Me.lblSquares.AutoSize = True
        Me.lblSquares.Location = New System.Drawing.Point(55, 109)
        Me.lblSquares.Name = "lblSquares"
        Me.lblSquares.Size = New System.Drawing.Size(39, 13)
        Me.lblSquares.TabIndex = 1
        Me.lblSquares.Text = "Series:"
        '
        'lblNine
        '
        Me.lblNine.AutoSize = True
        Me.lblNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNine.Location = New System.Drawing.Point(96, 38)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(172, 24)
        Me.lblNine.TabIndex = 4
        Me.lblNine.Text = "Multiplying 9 by 2"
        '
        'lstSquares
        '
        Me.lstSquares.FormattingEnabled = True
        Me.lstSquares.Location = New System.Drawing.Point(145, 109)
        Me.lstSquares.Name = "lstSquares"
        Me.lstSquares.Size = New System.Drawing.Size(122, 251)
        Me.lstSquares.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(145, 367)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(122, 32)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmHappy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 437)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstSquares)
        Me.Controls.Add(Me.lblNine)
        Me.Controls.Add(Me.lblSquares)
        Me.Name = "frmHappy"
        Me.Text = "Happy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSquares As System.Windows.Forms.Label
    Friend WithEvents lblNine As System.Windows.Forms.Label
    Friend WithEvents lstSquares As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
