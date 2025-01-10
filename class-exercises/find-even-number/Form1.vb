Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim number As Integer
        number = CInt(number_text.Text)

        If number Mod 2 = 0 Then
            result_label.Text = "Ο αριθμός είναι άρτιος"
        Else
            result_label.Text = "Ο αριθμός είναι περιττός"
        End If

    End Sub
End Class
