<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLove
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLove))
        Me.btnTellMe = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtWord = New System.Windows.Forms.TextBox
        Me.lblLove = New System.Windows.Forms.Label
        Me.picHeart = New System.Windows.Forms.PictureBox
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTellMe
        '
        Me.btnTellMe.Location = New System.Drawing.Point(9, 84)
        Me.btnTellMe.Name = "btnTellMe"
        Me.btnTellMe.Size = New System.Drawing.Size(109, 23)
        Me.btnTellMe.TabIndex = 0
        Me.btnTellMe.Text = "Is this correct?"
        Me.btnTellMe.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(134, 83)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(256, 83)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(230, 47)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 3
        '
        'lblLove
        '
        Me.lblLove.AutoSize = True
        Me.lblLove.Location = New System.Drawing.Point(9, 21)
        Me.lblLove.Name = "lblLove"
        Me.lblLove.Size = New System.Drawing.Size(295, 13)
        Me.lblLove.TabIndex = 4
        Me.lblLove.Text = "What do you tell someone if they ask if you like your parents?"
        '
        'picHeart
        '
        Me.picHeart.Image = CType(resources.GetObject("picHeart.Image"), System.Drawing.Image)
        Me.picHeart.Location = New System.Drawing.Point(16, 132)
        Me.picHeart.Name = "picHeart"
        Me.picHeart.Size = New System.Drawing.Size(314, 254)
        Me.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeart.TabIndex = 5
        Me.picHeart.TabStop = False
        Me.picHeart.Visible = False
        '
        'frmLove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 398)
        Me.Controls.Add(Me.picHeart)
        Me.Controls.Add(Me.lblLove)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTellMe)
        Me.Name = "frmLove"
        Me.Text = "Happy Valentines Day!!!"
        CType(Me.picHeart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTellMe As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents lblLove As System.Windows.Forms.Label
    Friend WithEvents picHeart As System.Windows.Forms.PictureBox

End Class
