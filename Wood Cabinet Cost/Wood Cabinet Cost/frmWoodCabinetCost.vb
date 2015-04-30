Option Strict On

Public Class frmWoodCabinetCost

    Private Sub frmWoodCabinetCost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtFeet.Clear()
        lblTotal.Text = ""
        txtFeet.Focus()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Const intPineConstant As Integer = 150I
        Const intOakConstant As Integer = 200I
        Const intCherryConstant As Integer = 350I

        Dim intFeet As Integer
        Dim intCostPerFoot As Integer
        Dim intTotal As Integer

        If IsNumeric(txtFeet.Text) Then
            intFeet = Convert.ToInt32(txtFeet.Text)

            If intFeet > 0 Then
                If radPine.Checked Then
                    intCostPerFoot = intPineConstant
                ElseIf radOak.Checked Then
                    intCostPerFoot = intOakConstant
                ElseIf radCherry.Checked Then
                    intCostPerFoot = intCherryConstant
                End If

                intTotal = intFeet * intCostPerFoot
                lblTotal.Text = intTotal.ToString("C")
            

            End If

        Else
            MsgBox("Enter the Linear Feet of the Cabinets", , "Imput Error")
            txtFeet.Text = ""
            txtFeet.Focus()

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        txtFeet.Clear()
        lblTotal.Text = ""
        txtFeet.Focus()
        radPine.Checked = True
        radOak.Checked = False
        radCherry.Checked = False

    End Sub
End Class
