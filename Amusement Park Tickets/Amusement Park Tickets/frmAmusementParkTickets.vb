Public Class frmAmusementParkTickets

    Private Sub frmAmusementParkTickets_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtTickets.Clear()              'load empty text box
        radAAA.Checked = False          'radio button loaded un-checked
        radAARP.Checked = False         'radio button loaded un-checked
        radMilitary.Checked = False     'radio button loaded un-checked
        lblTotal.Text = ""              'load the text of a lable empty
        txtTickets.Focus()              'focus on the text box

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Const _Tickets As Decimal = 72D     'constant price of tickets

        Const _AAA As Decimal = 0.15D       'constant price of AAA discount
        Const _AARP As Decimal = 0.175D     'constant price of AARP discount
        Const _Military As Decimal = 0.2D   'constant price of Military discount

        Dim strTickets As String            'free up room in RAM for string of tickets
        Dim intTickets As Integer           'free up room in RAM for integer of tickets

        Dim decSubtotal As Decimal          'free up room in RAM for decimal tickets * price of tickets
        Dim decTotal As Decimal             'free up room in RAM for decimal total


        strTickets = txtTickets.Text                    'text of the textbox is concidered as a string
        If IsNumeric(txtTickets.Text) Then              'if text of the text box is a number, then    
            intTickets = Convert.ToInt32(strTickets)    'convert that number to integers and store it in RAM 
            If intTickets > 0 Then
                decSubtotal = _Tickets * intTickets         'intTickets (aka # of tickets) * Ticket price = totalin cedimal, then store in RAM
            End If

            If intTickets > 0 And radAAA.Checked = True Then                           'if this radio button is checked, then
                decTotal = decSubtotal - (decSubtotal * _AAA)       'subtotal minus AAA the discount from subtotal
            ElseIf intTickets > 0 And radAARP.Checked = True Then                      'if this radio button is checked, then
                decTotal = decSubtotal - (decSubtotal * _AARP)      'subtotal minus AARP the discount from subtotal
            ElseIf intTickets > 0 And radMilitary.Checked = True Then                  'if this radio button is checked, then
                decTotal = decSubtotal - (decSubtotal * _Military)  'subtotal minus Military the discount from subtotal
            ElseIf intTickets > 0 And radAAA.Checked = False And radAARP.Checked = False And radMilitary.Checked = False Then   '
                decTotal = (_Tickets * intTickets)                                                                              '
            Else
                MsgBox("Please enter a posetive Number of Tickets.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Please enter how many tickets you need.", MsgBoxStyle.Critical, "Error") 'if text in the textbox is not numeric then display this error
        End If

        decSubtotal = _Tickets * intTickets                     'intTickets (aka # of tickets) * Ticket price = totalin cedimal, then store in RAM

        lblTotal.Text = decTotal.ToString("C")                    'take decTotal from ram and place it in the text of the lblTotal
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        txtTickets.Clear()              'clear text
        radAAA.Checked = False          'uncheck radio button
        radAARP.Checked = False         'uncheck radio button
        radMilitary.Checked = False     'uncheck radio button
        lblTotal.Text = ""              'clear text of the label
        txtTickets.Focus()              'focus on the text box

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

        btnClear_Click(Nothing, e)      'execute the clear button

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculateToolStripMenuItem.Click

        btnCalculate_Click(Nothing, e)  'execute the calculate button

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Close()                         'execute the closse button

    End Sub
End Class
