Public Class central_form


    Private Sub central_button_Click(sender As Object, e As EventArgs) Handles central_button.Click

        'fullname_label.Text = "Hello, " & fullname_text.Text & "!"

        Dim fullname As String
        fullname = fullname_text.Text

        Dim completed_sentence As String = "Hello, " & fullname & "!"


        fullname_label.Text = completed_sentence

    End Sub

End Class
