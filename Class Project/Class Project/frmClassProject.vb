Option Strict Off

Public Class frmClassProject

    Private Sub frmClassProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtCredits.Clear()
        lblDisplay.Text = ""
        txtCredits.Focus()

    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        Dim strCredits As String
        Dim intCredits As String

        strCredits = txtCredits.Text
        intCredits = Convert.ToInt32(strCredits)

        If intCredits >= 0 And intCredits <= 30 Then
            lblDisplay.Text = "Freshman"
        ElseIf intCredits >= 31 And intCredits <= 60 Then
            lblDisplay.Text = "Sphmore"
        ElseIf intCredits >= 61 And intCredits <= 90 Then
            lblDisplay.Text = "Junior"
        ElseIf intCredits >= 91 And intCredits <= 120 Then
            lblDisplay.Text = "Senior"
        End If

    End Sub

End Class
