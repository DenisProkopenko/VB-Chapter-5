<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWoodCabinetCost
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.radPine = New System.Windows.Forms.RadioButton()
        Me.radOak = New System.Windows.Forms.RadioButton()
        Me.radCherry = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wood Cabinet Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Linear Feet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost Estimate:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(176, 276)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 16)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "$5,000.00"
        '
        'txtFeet
        '
        Me.txtFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeet.Location = New System.Drawing.Point(176, 87)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(36, 22)
        Me.txtFeet.TabIndex = 4
        Me.txtFeet.Text = "25"
        Me.txtFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Wood Type"})
        Me.ListBox1.Location = New System.Drawing.Point(110, 140)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(96, 116)
        Me.ListBox1.TabIndex = 5
        '
        'radPine
        '
        Me.radPine.AutoSize = True
        Me.radPine.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radPine.Checked = True
        Me.radPine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPine.Location = New System.Drawing.Point(126, 178)
        Me.radPine.Name = "radPine"
        Me.radPine.Size = New System.Drawing.Size(53, 20)
        Me.radPine.TabIndex = 6
        Me.radPine.TabStop = True
        Me.radPine.Text = "Pine"
        Me.radPine.UseVisualStyleBackColor = False
        '
        'radOak
        '
        Me.radOak.AutoSize = True
        Me.radOak.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radOak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOak.Location = New System.Drawing.Point(126, 201)
        Me.radOak.Name = "radOak"
        Me.radOak.Size = New System.Drawing.Size(51, 20)
        Me.radOak.TabIndex = 7
        Me.radOak.Text = "Oak"
        Me.radOak.UseVisualStyleBackColor = False
        '
        'radCherry
        '
        Me.radCherry.AutoSize = True
        Me.radCherry.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radCherry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCherry.Location = New System.Drawing.Point(126, 224)
        Me.radCherry.Name = "radCherry"
        Me.radCherry.Size = New System.Drawing.Size(65, 20)
        Me.radCherry.TabIndex = 8
        Me.radCherry.Text = "Cherry"
        Me.radCherry.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(60, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(182, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Cabinets
        Me.PictureBox1.Location = New System.Drawing.Point(12, 360)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmWoodCabinetCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(316, 510)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.radCherry)
        Me.Controls.Add(Me.radOak)
        Me.Controls.Add(Me.radPine)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmWoodCabinetCost"
        Me.Text = "Wood Cabinet Cost"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtFeet As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents radPine As System.Windows.Forms.RadioButton
    Friend WithEvents radOak As System.Windows.Forms.RadioButton
    Friend WithEvents radCherry As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
