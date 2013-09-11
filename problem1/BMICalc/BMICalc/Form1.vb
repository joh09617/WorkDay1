Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim hSt As String
        Dim wSt As String
        'Everything the user types is a string until it is converted

        hSt = txtHeight.Text 'reads height input and stores it into hSt
        wSt = txtWeight.Text 'reads weight input and stores it into wSt

        Dim h As Double
        Dim w As Double

        h = CDbl(hSt) 'converts hSt to a double and stores it in h
        w = CDbl(wSt) 'converts wSt to a double and stores it in w

        Dim BMI As Double
        BMI = (w * 703) / (h ^ 2) 'computation

        TextBox1.Text = CStr(BMI) 'converts number to string in order to display

    End Sub
End Class
