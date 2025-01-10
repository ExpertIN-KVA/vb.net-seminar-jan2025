Public Class comparisonIf
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Dim selected_operator As String = operatorCombo.SelectedItem
        resultLabel.Text = selected_operator



        If number1_text.Text = "" Or number2_text.Text = "" Then
            resultLabel.Text = "Τα δεδομένα δεν είναι έγκυρα"
        End If



        Dim number1 As Integer = CInt(number1_text.Text)
        Dim number2 As Integer = CInt(number2_text.Text)



        If selected_operator = ">" Then
            If number1 > number2 Then
                resultLabel.Text = "Η συνθήκη ισχύει"
            Else
                resultLabel.Text = "Η συνθήκη ΔΕΝ ισχύει"
            End If
        ElseIf selected_operator = "<" Then
            If number1 < number2 Then
                resultLabel.Text = "Η συνθήκη ισχύει"
            Else
                resultLabel.Text = "Η συνθήκη ΔΕΝ ισχύει"
            End If
        ElseIf selected_operator = ">=" Then
            If number1 >= number2 Then
                resultLabel.Text = "Η συνθήκη ισχύει"
            Else
                resultLabel.Text = "Η συνθήκη ΔΕΝ ισχύει"
            End If
        ElseIf selected_operator = "<=" Then
            If number1 <= number2 Then
                resultLabel.Text = "Η συνθήκη ισχύει"
            Else
                resultLabel.Text = "Η συνθήκη ΔΕΝ ισχύει"
            End If
        ElseIf selected_operator = "=" Then
            If number1 = number2 Then
                resultLabel.Text = "Η συνθήκη ισχύει"
            Else
                resultLabel.Text = "Η συνθήκη ΔΕΝ ισχύει"
            End If
        ElseIf selected_operator = "<>" Then
            If number1 <> number2 Then
                resultLabel.Text = "Η συνθήκη ισχύει"
            Else
                resultLabel.Text = "Η συνθήκη ΔΕΝ ισχύει"
            End If
        End If

    End Sub

End Class