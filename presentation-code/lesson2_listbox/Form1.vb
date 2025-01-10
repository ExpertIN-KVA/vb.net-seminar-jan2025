Public Class Form1
    Private Sub addItem_Click(sender As Object, e As EventArgs) Handles addItem.Click

        Dim itemInput As String = InputBox("Παρακαλώ εισάγετε ένα αντικείμενο", "Δημιουργία αντικειμένου στην λίστα", "<χωρίς_τίτλο>")
        ListBox.Items.Add(itemInput)

    End Sub

    Private Sub deleteItem_Click(sender As Object, e As EventArgs) Handles deleteItem.Click

        If ListBox.SelectedIndex <> -1 Then
            ListBox.Items.RemoveAt(ListBox.SelectedIndex)
        Else
            MessageBox.Show("Παρακαλώ επιλέξτε μία τιμή για να διαγράψετε", "Warning")
        End If

    End Sub

    Private Sub duplicateItem_Click(sender As Object, e As EventArgs) Handles duplicateItem.Click

        If ListBox.SelectedIndex <> -1 Then
            ListBox.Items.Add(ListBox.SelectedItem)
        Else
            MessageBox.Show("Παρακαλώ επιλέξτε μία τιμή για να αντιγράψετε", "Warning")
        End If

    End Sub
End Class
