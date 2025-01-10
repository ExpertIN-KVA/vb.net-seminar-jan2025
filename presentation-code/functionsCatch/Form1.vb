Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim five_square As Integer = Square(5)
        MessageBox.Show(five_square)

    End Sub


    Private Function Square(x As Integer) As Integer
        Return x ^ 2
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showMessage()
    End Sub

    Private Sub showMessage()
        MessageBox.Show("Hello World!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim result As Double = 10 / 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class
