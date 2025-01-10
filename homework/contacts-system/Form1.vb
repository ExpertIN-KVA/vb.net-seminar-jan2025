Public Class Form1

    Dim selectedIndex As Integer = -1


    Private Sub SaveContactBtn_Click(sender As Object, e As EventArgs) Handles save_contact_btn.Click

        Dim firstName As String = first_name.Text
        Dim lastName As String = last_name.Text
        Dim phoneNumber As String = phone_number.Text


        If firstName = "" Or lastName = "" Or phoneNumber = "" Then
            MessageBox.Show("Πρέπει πρώτα να συμπληρώσετε όλα τα στοιχεία για την επαφή.", "Ειδοποίηση")
            Return
        End If


        Dim full_string = firstName & " " & lastName & ", " & phoneNumber

        contacts_list.Items.Add(full_string)


        clearFormFields()

    End Sub





    Private Sub clearFormFields()
        first_name.Text = ""
        last_name.Text = ""
        phone_number.Text = ""
    End Sub

    Private Sub update_contact_btn_Click(sender As Object, e As EventArgs) Handles update_contact_btn.Click

        Dim firstName As String = first_name.Text
        Dim lastName As String = last_name.Text
        Dim phoneNumber As String = phone_number.Text


        If firstName = "" Or lastName = "" Or phoneNumber = "" Then
            MessageBox.Show("Πρέπει πρώτα να συμπληρώσετε όλα τα στοιχεία για την επαφή.", "Ειδοποίηση")
            Return
        End If


        Dim full_string = firstName & " " & lastName & ", " & phoneNumber

        contacts_list.Items(selectedIndex) = full_string


        selectedIndex = -1
        clearFormFields()
        save_contact_btn.Visible = True
        update_contact_btn.Visible = False

    End Sub


    Private Sub fillFormUpdate()

        Dim indexed_item As String = contacts_list.SelectedItem
        selectedIndex = contacts_list.SelectedIndex


        Dim splitted_item(2) As String
        splitted_item = indexed_item.Split(", ")
        Dim splitted_name(2) As String
        splitted_name = splitted_item(0).Split(" ")


        first_name.Text = splitted_name(0)
        last_name.Text = splitted_name(1)
        phone_number.Text = splitted_item(1)


        save_contact_btn.Visible = False
        update_contact_btn.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If contacts_list.SelectedIndex <> -1 Then
            fillFormUpdate()
        Else
            MessageBox.Show("Παρακαλώ επιλέξτε πρώτα επαφή που θέλετε να επεξεργαστείτε", "Προσοχή!")
        End If

    End Sub


    Private Sub contacts_list_DoubleClick(sender As Object, e As EventArgs) Handles contacts_list.DoubleClick

        If contacts_list.SelectedIndex <> -1 Then
            fillFormUpdate()
        Else
            MessageBox.Show("Παρακαλώ επιλέξτε πρώτα επαφή που θέλετε να επεξεργαστείτε", "Προσοχή!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If contacts_list.SelectedIndex <> -1 Then
            contacts_list.Items.Remove(contacts_list.SelectedIndex)
        Else
            MessageBox.Show("Παρακαλώ επιλέξτε πρώτα επαφή που θέλετε να διαγράψετε", "Προσοχή!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If contacts_list.SelectedIndex <> -1 Then
            contacts_list.Items.Add(contacts_list.SelectedItem)
        Else
            MessageBox.Show("Παρακαλώ επιλέξτε πρώτα επαφή που θέλετε να επεξεργαστείτε", "Προσοχή!")
        End If

    End Sub
End Class
