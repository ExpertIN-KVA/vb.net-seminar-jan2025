Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox.Text = "" Then
            MessageBox.Show("Πρέπει να συμπληρωθεί πρώτα ο αριθμός του ορίου", "Warning")
        End If



        Dim number As Integer = CInt(TextBox.Text)

        For i = 1 To number
            ListBox.Items.Add(i)
        Next

    End Sub
End Class
