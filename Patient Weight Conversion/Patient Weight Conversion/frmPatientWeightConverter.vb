Public Class frmPatientWeightConverter

    Private Sub frmPatientWeightConverter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtWeight.Clear()               'load with cleared text box
        radPounds.Checked = False       'load with radi button unchecked
        radKilograms.Checked = False    'load with radio button unchecked
        lblConverted.Text = ""          'load with cleared text in the label
        lblWeight.Text = ""             'load with cleared text in the label
        txtWeight.Focus()               'focus in the text box

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Const _Kilograms As Decimal = 2.2D  'constant
        Const _Pounds As Decimal = 2.2D     'constant

        Dim strWeight As String             'make room in RAM for strWeight
        Dim intWeight As Integer            'make room in RAM for intWeight

        Dim decTotal As Decimal             'make room in RAM for decTotal

        strWeight = txtWeight.Text                      'text in the txtBox is known as a string
        If IsNumeric(txtWeight.Text) Then               'If it is a number, then
            intWeight = Convert.ToInt32(strWeight)      'convert string into integers
        Else
            MsgBox("Please enter Weight", MsgBoxStyle.Information, "Oops")  'error message if no weight was entered
        End If

        
        If intWeight > 0 And radPounds.Checked Then                     'if intWeight is more than zero, and radio button is checked, then
            decTotal = intWeight / _Kilograms                           'pounds = divide by constant
            If radPounds.Checked = True Then                            'Also if radio button is checked, then
                lblWeight.Text = "Pounds"                               'add text to the label
            End If

        ElseIf intWeight > 0 And radKilograms.Checked Then              'if intWeight is more than zero, and radio button is checked, then
            decTotal = intWeight * _Pounds                              'kilograms = multiply by constant
            If radKilograms.Checked = True Then                         'Also if radio button is checked, then
                lblWeight.Text = "Kilograms"                            'add text to the label
            End If
        ElseIf intWeight > 0 And radPounds.Checked = False And radKilograms.Checked = False Then        'if none of the radio buttons are checked, then
            MsgBox("Please chose what conversion you are using.", MsgBoxStyle.Exclamation, "Oh No!")    'diplay the message
        ElseIf intWeight < 0 Then                                                                       'if none above got triggered, then
            MsgBox("Please enter weight in posetive numbers.", MsgBoxStyle.Exclamation, "Oh No!")       'display the message
        End If

        lblConverted.Text = decTotal.ToString("F1")                     'place dec total into the text of the lblTotal, in fixed form with 1 past the decimal

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        txtWeight.Clear()               'load with cleared text box
        radPounds.Checked = False       'load with radi button unchecked
        radKilograms.Checked = False    'load with radio button unchecked
        lblConverted.Text = ""          'load with cleared text in the label
        lblWeight.Text = ""             'load with cleared text in the label
        txtWeight.Focus()               'focus in the text box

    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayToolStripMenuItem.Click

        btnCalculate_Click(Nothing, e)      'execute calculate click event

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        btnClear_Click(Nothing, e)          'execute clear click event

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Close()                             'close the application and terminate the program

    End Sub
End Class
