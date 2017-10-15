<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberGuess
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
        Me.lblNumberGuessLabel = New System.Windows.Forms.Label
        Me.lblYouGuessedIt = New System.Windows.Forms.Label
        Me.btnCheckGuess = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtFinalGuess = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblNumberGuessLabel
        '
        Me.lblNumberGuessLabel.AutoSize = True
        Me.lblNumberGuessLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberGuessLabel.Location = New System.Drawing.Point(7, 30)
        Me.lblNumberGuessLabel.Name = "lblNumberGuessLabel"
        Me.lblNumberGuessLabel.Size = New System.Drawing.Size(209, 16)
        Me.lblNumberGuessLabel.TabIndex = 0
        Me.lblNumberGuessLabel.Text = "Enter a number between 1 and 10:"
        '
        'lblYouGuessedIt
        '
        Me.lblYouGuessedIt.AutoSize = True
        Me.lblYouGuessedIt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouGuessedIt.Location = New System.Drawing.Point(79, 77)
        Me.lblYouGuessedIt.Name = "lblYouGuessedIt"
        Me.lblYouGuessedIt.Size = New System.Drawing.Size(134, 20)
        Me.lblYouGuessedIt.TabIndex = 1
        Me.lblYouGuessedIt.Text = "You guessed it!"
        Me.lblYouGuessedIt.Visible = False
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.Location = New System.Drawing.Point(31, 200)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(84, 23)
        Me.btnCheckGuess.TabIndex = 2
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(178, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtFinalGuess
        '
        Me.txtFinalGuess.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalGuess.Location = New System.Drawing.Point(247, 26)
        Me.txtFinalGuess.Name = "txtFinalGuess"
        Me.txtFinalGuess.Size = New System.Drawing.Size(33, 23)
        Me.txtFinalGuess.TabIndex = 4
        '
        'frmNumberGuess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtFinalGuess)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Controls.Add(Me.lblYouGuessedIt)
        Me.Controls.Add(Me.lblNumberGuessLabel)
        Me.Name = "frmNumberGuess"
        Me.Text = "Number Guess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumberGuessLabel As System.Windows.Forms.Label
    Friend WithEvents lblYouGuessedIt As System.Windows.Forms.Label
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtFinalGuess As System.Windows.Forms.TextBox

End Class
