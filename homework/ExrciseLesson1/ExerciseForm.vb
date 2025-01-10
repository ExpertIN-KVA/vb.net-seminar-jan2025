Public Class ExerciseForm
    Private Sub trigger_calculation_Click(sender As Object, e As EventArgs) Handles trigger_calculation.Click

        Dim number1 As Integer = CInt(number1_text.Text)
        Dim number2 As Integer = CInt(number2_text.Text)

        Dim result As Integer
        result = number1 + number2


        calculation_result.Text = result

    End Sub

End Class
