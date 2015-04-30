'Program Name:  Parking Ticket Fines
'Author:        Denis Prokopenko
'Date:          10/29/2013
'Purpos:        This application allows the user to display the price of the ticket based 
'               on the type of a violation and if there were repeats of the violation.


Option Strict On

Public Class frmParkingTicketFines

    Private Sub frmParkingTicketFines_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        radExpired.Checked = True              'load with unchecked radio button
        radNoParking.Checked = False            'load with unchecked radio button
        radBlockingDriveway.Checked = False     'load with unchecked radio button
        radIllegalHandicap.Checked = False      'load with unchecked radio button

        radRepeat.Checked = False               'load with unchecked radio button

        lblTotal.Text = ""                      'load with cleared total

    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Const _Expired As Decimal = 35D             'constant price for a violation
        Const _NoParking As Decimal = 75D           'constant price for a violation
        Const _Blocking As Decimal = 150D           'constant price for a violation
        Const _IllegalHandicap As Decimal = 500D    'constant price for a violation

        Const _Repeat As Decimal = 2D               'constant price for a violation

        Dim decTotal As Decimal                     'make room in RAM for decimal value

        If radExpired.Checked = False And radNoParking.Checked = False And _
            radBlockingDriveway.Checked = False And radIllegalHandicap.Checked = False Then
            MsgBox("Please pick one of the Parking Violations first.", MsgBoxStyle.Exclamation, "Parking Violations")   'message box if none of the violation types are selected
        End If

        If radExpired.Checked = True And radRepeat.Checked = True Then                  'if violation and repeat are checked then do the calculation
            decTotal = _Expired * _Repeat                                               'violation * repeat =total saved in RAM
        ElseIf radExpired.Checked = True And radRepeat.Checked = False Then             'if violation is the only one checked, then do the calculation
            decTotal = _Expired                                                         'violation =total saved in RAM

        ElseIf radNoParking.Checked = True And radRepeat.Checked = True Then            'if violation and repeat are checked then do the calculation
            decTotal = _NoParking * _Repeat                                             'violation * repeat =total saved in RAM
        ElseIf radNoParking.Checked = True And radRepeat.Checked = False Then           'if violation is the only one checked, then do the calculation
            decTotal = _NoParking                                                       'violation =total saved in RAM

        ElseIf radBlockingDriveway.Checked = True And radRepeat.Checked = True Then     'if violation and repeat are checked then do the calculation
            decTotal = _Blocking * _Repeat                                              'violation * repeat =total saved in RAM
        ElseIf radBlockingDriveway.Checked = True And radRepeat.Checked = False Then    'if violation is the only one checked, then do the calculation
            decTotal = _Blocking                                                        'violation =total saved in RAM

        ElseIf radIllegalHandicap.Checked = True And radRepeat.Checked = True Then      'if violation and repeat are checked then do the calculation
            decTotal = _IllegalHandicap * _Repeat                                       'violation * repeat =total saved in RAM
        ElseIf radIllegalHandicap.Checked = True And radRepeat.Checked = False Then     'if violation is the only one checked, then do the calculation
            decTotal = _IllegalHandicap                                                 'violation =total saved in RAM
        End If

        lblTotal.Text = decTotal.ToString("C")          '
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        radExpired.Checked = True                       'check the violation
        radNoParking.Checked = False                    'uncheck the violation if checked
        radBlockingDriveway.Checked = False             'uncheck the violation if checked
        radIllegalHandicap.Checked = False              'uncheck the violation if checked
        radRepeat.Checked = False                       'uncheck the violation if checked
        lblTotal.Text = ""                              'clear total
    End Sub

End Class
