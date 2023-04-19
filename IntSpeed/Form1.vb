Public Class Form1
    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decFinalSpeed As Decimal = 0D
        Dim decAvgSpeed As Decimal
        Dim strInputMess As String = "Enter internet speed number "
        Dim strNormal As String = "Enter internet speed number "
        Dim strNegative As String = "Please enter a positive value. Retry speed "
        Dim strAlpha As String = "Please enter a numeric value. Retry speed "

        Dim strCancel As String = ""
        Dim intMaxInput As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strInputMess & intEntries, "Internet Speed", " ")

        Do Until intEntries > intMaxInput Or strSpeed = strCancel
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeed.Items.Add(decSpeed)
                    decFinalSpeed += decSpeed
                    intEntries += 1
                    strInputMess = strNormal
                Else
                    strInputMess = strNegative

                End If
            Else
                strInputMess = strAlpha
            End If
            If intEntries <= intMaxInput Then
                strSpeed = InputBox(strInputMess & intEntries, "Internet Speed", " ")
            End If
        Loop

        If intEntries > 1 Then
            lblActualSpeed.Visible = True
            decAvgSpeed = decFinalSpeed / (intEntries - 1)
            lblActualSpeed.Text = decAvgSpeed.ToString("F2") & " Mbps"

        End If

    End Sub
End Class
