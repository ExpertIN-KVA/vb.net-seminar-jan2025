Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox.Items.Clear()

        For i = 1 To 10
            ListBox.Items.Add(i)
        Next

    End Sub
End Class
