
Option Strict On

Public Class frmHealthClubMembership

    Private Sub frmHealthClubMembership_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtName.Clear()
        txtMonths.Clear()
        lblTotal.Text = ""
        radSingle.Checked = True
        radFamily.Checked = False
        radSenior.Checked = False

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Const _Single As Decimal = 38D
        Const _Family As Decimal = 58D
        Const _Senior As Decimal = 27D

        Dim strName As String
        Dim strMonths As String
        Dim intMonths As Integer
        Dim decTotal As Decimal

        strName = txtName.Text

        strMonths = txtMonths.Text
        If IsNumeric(txtMonths.Text) Then
            intMonths = Convert.ToInt32(strMonths)

            If intMonths > 0 Then
                If radSingle.Checked = True Then
                    decTotal = _Single * intMonths
                ElseIf radFamily.Checked = True Then
                    decTotal = _Family * intMonths
                ElseIf radSenior.Checked = True Then
                    decTotal = _Senior * intMonths
                End If

                lblTotal.Text = strName.ToString & decTotal.ToString("C")

            Else
                MsgBox("Please enter a posetive number of months you wish to prepay", MsgBoxStyle.Exclamation, "Oops")
            End If
        Else
            MsgBox("Please enter the number of months you wish to prepay", MsgBoxStyle.Exclamation, "Oops")
        End If

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtMonths.Clear()
        lblTotal.Text = ""
        radSingle.Checked = True
        radFamily.Checked = False
        radSenior.Checked = False

    End Sub
End Class
