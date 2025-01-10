Public Class Form1
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Dim number As Integer = CInt(number_text.Text)

        If number > 10 Then
            result_label.Text = "Ο αριθμός είναι μεγαλύτερος του 10"
        ElseIf number = 10 Then
            result_label.Text = "Ο αριθμός είναι ίσος με το 10"
        Else
            result_label.Text = "Ο αριθμός είναι μικρότερος του 10"
        End If

    End Sub

    Private Sub openSecondForm_Click(sender As Object, e As EventArgs) Handles openSecondForm.Click
        comparisonIf.Show()
    End Sub
End Class
