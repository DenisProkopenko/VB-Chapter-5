<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParkingTicketFines
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radIllegalHandicap = New System.Windows.Forms.RadioButton()
        Me.radBlockingDriveway = New System.Windows.Forms.RadioButton()
        Me.radNoParking = New System.Windows.Forms.RadioButton()
        Me.radExpired = New System.Windows.Forms.RadioButton()
        Me.radRepeat = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radIllegalHandicap)
        Me.GroupBox1.Controls.Add(Me.radBlockingDriveway)
        Me.GroupBox1.Controls.Add(Me.radNoParking)
        Me.GroupBox1.Controls.Add(Me.radExpired)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(112, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parking Violations"
        '
        'radIllegalHandicap
        '
        Me.radIllegalHandicap.AutoSize = True
        Me.radIllegalHandicap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radIllegalHandicap.Location = New System.Drawing.Point(17, 99)
        Me.radIllegalHandicap.Name = "radIllegalHandicap"
        Me.radIllegalHandicap.Size = New System.Drawing.Size(173, 20)
        Me.radIllegalHandicap.TabIndex = 3
        Me.radIllegalHandicap.Text = "Illegal Handicap Parking"
        Me.radIllegalHandicap.UseVisualStyleBackColor = True
        '
        'radBlockingDriveway
        '
        Me.radBlockingDriveway.AutoSize = True
        Me.radBlockingDriveway.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBlockingDriveway.Location = New System.Drawing.Point(17, 73)
        Me.radBlockingDriveway.Name = "radBlockingDriveway"
        Me.radBlockingDriveway.Size = New System.Drawing.Size(137, 20)
        Me.radBlockingDriveway.TabIndex = 2
        Me.radBlockingDriveway.Text = "Blocking Driveway"
        Me.radBlockingDriveway.UseVisualStyleBackColor = True
        '
        'radNoParking
        '
        Me.radNoParking.AutoSize = True
        Me.radNoParking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoParking.Location = New System.Drawing.Point(17, 47)
        Me.radNoParking.Name = "radNoParking"
        Me.radNoParking.Size = New System.Drawing.Size(127, 20)
        Me.radNoParking.TabIndex = 1
        Me.radNoParking.Text = "No Parking Zone"
        Me.radNoParking.UseVisualStyleBackColor = True
        '
        'radExpired
        '
        Me.radExpired.AutoSize = True
        Me.radExpired.Checked = True
        Me.radExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radExpired.Location = New System.Drawing.Point(17, 21)
        Me.radExpired.Name = "radExpired"
        Me.radExpired.Size = New System.Drawing.Size(117, 20)
        Me.radExpired.TabIndex = 0
        Me.radExpired.TabStop = True
        Me.radExpired.Text = "Expired Meeter"
        Me.radExpired.UseVisualStyleBackColor = True
        '
        'radRepeat
        '
        Me.radRepeat.AutoSize = True
        Me.radRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRepeat.Location = New System.Drawing.Point(152, 186)
        Me.radRepeat.Name = "radRepeat"
        Me.radRepeat.Size = New System.Drawing.Size(125, 20)
        Me.radRepeat.TabIndex = 3
        Me.radRepeat.TabStop = True
        Me.radRepeat.Text = "Repeat Offender"
        Me.radRepeat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Parking
        Me.PictureBox1.Location = New System.Drawing.Point(91, 212)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Parking Ticket Fines:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(91, 452)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(96, 34)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display Fine"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(242, 452)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(259, 412)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(67, 20)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "$300.00"
        '
        'frmParkingTicketFines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(429, 498)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.radRepeat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmParkingTicketFines"
        Me.Text = "Parking Ticket Fines"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radIllegalHandicap As System.Windows.Forms.RadioButton
    Friend WithEvents radBlockingDriveway As System.Windows.Forms.RadioButton
    Friend WithEvents radNoParking As System.Windows.Forms.RadioButton
    Friend WithEvents radExpired As System.Windows.Forms.RadioButton
    Friend WithEvents radRepeat As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
