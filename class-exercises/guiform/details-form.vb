Public Class personal_data_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim first_name As String = name_text.Text
        Dim last_name As String = lastname_text.Text
        Dim date_of_birth As String = dateOfBirth.Text


        result_label.Text = "Όνομα: " & first_name & Environment.NewLine & "Επίθετο: " & last_name & Environment.NewLine & "Ημερομηνία γεννήσεως: " & date_of_birth

    End Sub
End Class
