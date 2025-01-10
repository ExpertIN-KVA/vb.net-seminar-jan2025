Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        numbers_label.Text = ""

        For i = 1 To 10

            numbers_label.Text = numbers_label.Text & i

            If i < 10 Then
                numbers_label.Text = numbers_label.Text & Environment.NewLine
            End If

        Next

    End Sub
End Class
