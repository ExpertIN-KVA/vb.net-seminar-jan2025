Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim number As Integer = CInt(InputBox("Please enter a number: ", "Number", 0))


        MessageBox.Show("Final result: " & square_number(number), "Result")

    End Sub


    Private Function square_number(x)
        Return x ^ 2
    End Function

End Class
