<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHealthClubMembership
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radFamily = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(319, 136)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of months to prepay"
        '
        'txtMonths
        '
        Me.txtMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonths.Location = New System.Drawing.Point(319, 172)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 22)
        Me.txtMonths.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSenior)
        Me.GroupBox1.Controls.Add(Me.radFamily)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(228, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership Type"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(7, 68)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(143, 20)
        Me.radSenior.TabIndex = 2
        Me.radSenior.TabStop = True
        Me.radSenior.Text = "Senior Membership"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radFamily
        '
        Me.radFamily.AutoSize = True
        Me.radFamily.Location = New System.Drawing.Point(7, 44)
        Me.radFamily.Name = "radFamily"
        Me.radFamily.Size = New System.Drawing.Size(144, 20)
        Me.radFamily.TabIndex = 1
        Me.radFamily.TabStop = True
        Me.radFamily.Text = "Family Membership"
        Me.radFamily.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Checked = True
        Me.radSingle.Location = New System.Drawing.Point(7, 20)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(142, 20)
        Me.radSingle.TabIndex = 0
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single Membership"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Health Club Memberships"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(140, 374)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(380, 374)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(237, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(283, 452)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 9
        '
        'frmHealthClubMembership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 507)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMonths)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHealthClubMembership"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSenior As System.Windows.Forms.RadioButton
    Friend WithEvents radFamily As System.Windows.Forms.RadioButton
    Friend WithEvents radSingle As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
