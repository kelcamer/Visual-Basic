<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadMusic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadMusic))
        Me.btnCalculatecost = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.lbldigitaldownloads = New System.Windows.Forms.Label
        Me.lblCostHeading = New System.Windows.Forms.Label
        Me.lblnumberofdownloads = New System.Windows.Forms.Label
        Me.lblTotalCostLabel = New System.Windows.Forms.Label
        Me.picdownloadheading = New System.Windows.Forms.PictureBox
        Me.txtNumberOfDownloads = New System.Windows.Forms.TextBox
        Me.lbltotalcostofdownloads = New System.Windows.Forms.Label
        CType(Me.picdownloadheading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculatecost
        '
        Me.btnCalculatecost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculatecost.Location = New System.Drawing.Point(26, 352)
        Me.btnCalculatecost.Name = "btnCalculatecost"
        Me.btnCalculatecost.Size = New System.Drawing.Size(143, 33)
        Me.btnCalculatecost.TabIndex = 0
        Me.btnCalculatecost.Text = "Calculate Cost"
        Me.btnCalculatecost.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(190, 352)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(143, 33)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(354, 352)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(143, 33)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lbldigitaldownloads
        '
        Me.lbldigitaldownloads.AutoSize = True
        Me.lbldigitaldownloads.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldigitaldownloads.Location = New System.Drawing.Point(36, 9)
        Me.lbldigitaldownloads.Name = "lbldigitaldownloads"
        Me.lbldigitaldownloads.Size = New System.Drawing.Size(257, 27)
        Me.lbldigitaldownloads.TabIndex = 3
        Me.lbldigitaldownloads.Text = "Digital Downloads"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(83, 77)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(163, 21)
        Me.lblCostHeading.TabIndex = 4
        Me.lblCostHeading.Text = "$X.XX Per Download"
        '
        'lblnumberofdownloads
        '
        Me.lblnumberofdownloads.AutoSize = True
        Me.lblnumberofdownloads.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumberofdownloads.Location = New System.Drawing.Point(46, 177)
        Me.lblnumberofdownloads.Name = "lblnumberofdownloads"
        Me.lblnumberofdownloads.Size = New System.Drawing.Size(230, 21)
        Me.lblnumberofdownloads.TabIndex = 5
        Me.lblnumberofdownloads.Text = "Number of Song Downloads:"
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(59, 243)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(203, 21)
        Me.lblTotalCostLabel.TabIndex = 6
        Me.lblTotalCostLabel.Text = "Total Cost of Downloads:"
        '
        'picdownloadheading
        '
        Me.picdownloadheading.Image = CType(resources.GetObject("picdownloadheading.Image"), System.Drawing.Image)
        Me.picdownloadheading.Location = New System.Drawing.Point(405, 9)
        Me.picdownloadheading.Name = "picdownloadheading"
        Me.picdownloadheading.Size = New System.Drawing.Size(81, 110)
        Me.picdownloadheading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picdownloadheading.TabIndex = 7
        Me.picdownloadheading.TabStop = False
        '
        'txtNumberOfDownloads
        '
        Me.txtNumberOfDownloads.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDownloads.Location = New System.Drawing.Point(348, 174)
        Me.txtNumberOfDownloads.Name = "txtNumberOfDownloads"
        Me.txtNumberOfDownloads.Size = New System.Drawing.Size(41, 27)
        Me.txtNumberOfDownloads.TabIndex = 9
        Me.txtNumberOfDownloads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltotalcostofdownloads
        '
        Me.lbltotalcostofdownloads.AutoSize = True
        Me.lbltotalcostofdownloads.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcostofdownloads.Location = New System.Drawing.Point(345, 249)
        Me.lbltotalcostofdownloads.Name = "lbltotalcostofdownloads"
        Me.lbltotalcostofdownloads.Size = New System.Drawing.Size(67, 19)
        Me.lbltotalcostofdownloads.TabIndex = 10
        Me.lbltotalcostofdownloads.Text = "$888.88"
        '
        'DownloadMusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(523, 449)
        Me.Controls.Add(Me.lbltotalcostofdownloads)
        Me.Controls.Add(Me.txtNumberOfDownloads)
        Me.Controls.Add(Me.picdownloadheading)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.lblnumberofdownloads)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lbldigitaldownloads)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnCalculatecost)
        Me.Name = "DownloadMusic"
        Me.Text = "Download Music"
        CType(Me.picdownloadheading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculatecost As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lbldigitaldownloads As System.Windows.Forms.Label
    Friend WithEvents lblCostHeading As System.Windows.Forms.Label
    Friend WithEvents lblnumberofdownloads As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostLabel As System.Windows.Forms.Label
    Friend WithEvents picdownloadheading As System.Windows.Forms.PictureBox
    Friend WithEvents txtNumberOfDownloads As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalcostofdownloads As System.Windows.Forms.Label

End Class
