Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        End If

        Button1.Text = Button1.Text + 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button2.Text = Button2.Text - 1

        If CInt(Button2.Text) = 0 Then
            Timer1.Enabled = False
            Button1.Enabled = False
            MsgBox("To timer σταμάτησε, πέρασαν 5 δευτερόλεπτα")
            Button3.Visible = True
            ResetToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.Enabled = True
        Button3.Visible = False

        ResetToolStripMenuItem.Enabled = False

        Button1.Text = 0
        Button2.Text = 5

        MsgBox("Το πρόγραμμα μόλις έγινε Reset και μπορείς να παίξεις ξανά")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ResetToolStripMenuItem.Enabled = False


        Button1.Enabled = True
        Button3.Visible = False



        Button1.Text = 0
        Button2.Text = 5

        MsgBox("Το πρόγραμμα μόλις έγινε Reset και μπορείς να παίξεις ξανά")

    End Sub
End Class

